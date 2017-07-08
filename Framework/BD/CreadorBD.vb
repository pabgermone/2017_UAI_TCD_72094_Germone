Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.Sql
Imports System.Windows.Forms
Imports System.Configuration

''' <remarks>
'''     Clase singleton
''' </remarks>
Public Class CreadorBD

    ''' <summary>
    ''' Indica si ya fue ejecutado el String para la creacion de la base
    ''' </summary>
    Dim mFlag As Boolean = False

#Region "Singleton"
    Private Shared mInstance As CreadorBD = Nothing

    Private Sub New()

    End Sub

    Public Shared Function GetInstance() As CreadorBD
        If IsNothing(mInstance) Then
            mInstance = New CreadorBD
        End If

        Return mInstance
    End Function
#End Region


    ''' <summary>
    ''' Revisa que el proceso de creacion de la BD no haya sido ejecutado en esta instancia del programa para
    ''' no volver a ejecutarlo. Si todavia no fue ejecutado, lo hace
    ''' </summary>
    Public Sub Crear()
        Try
            If mFlag = False Then
                CrearString()

                CrearBD()

                mFlag = True
            End If
        Catch ex As Exception

        End Try
    End Sub


    ''' <summary>
    ''' Se encarga de armar el ConnectionString al que se va a conectar para crear la BD
    ''' </summary>
    Private Sub CrearString()
        Try
            Dim mDataSourceEnumerator As SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance
            Dim mDataSources As DataTable = mDataSourceEnumerator.GetDataSources
            Dim mConfig As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("BDConnection")

            If Not mConfig Is Nothing Then
                Dim mString As String
                Dim mConnectioStringBuilder As New SqlConnectionStringBuilder(mConfig.ConnectionString)

                mConnectioStringBuilder.DataSource = mDataSources.Rows(0).Item(0) & "\" & mDataSources.Rows(0).Item(1)
                mConnectioStringBuilder.IntegratedSecurity = True

                mString = mConnectioStringBuilder.ConnectionString

                SetConfig(mString)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Se encarga de la creacion de la BD, si es que no existe
    ''' </summary>
    Private Sub CrearBD()
        Dim mScript As New FileStream(Application.StartupPath & "\Script - Campo2017_VentaPasajes.sql", FileMode.Open)
        Dim mReader As New StreamReader(mScript)
        Dim mConnectionString As String = ConfigurationManager.ConnectionStrings.Item("BDConnection").ConnectionString
        Dim mStringBuilder As New SqlConnectionStringBuilder

        mStringBuilder.ConnectionString = mConnectionString
        mStringBuilder.InitialCatalog = "master"

        Dim mConnection As New SqlConnection(mStringBuilder.ConnectionString)

        mConnection.Open()

        Dim mCommand As New SqlCommand

        Try
            mCommand = New SqlCommand("IF (NOT EXISTS (SELECT name " &
                                                      "FROM master.dbo.sysdatabases " &
                                                      "WHERE ('[' + name + ']' = 'Campo2017_VentaPasajes' " &
                                                             "OR name = 'Campo2017_VentaPasajes'))) " &
                                                      "CREATE DATABASE [Campo2017_VentaPasajes]", mConnection)
            mCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error en creacion de la BD:" & vbCrLf & ex.Message)
        End Try
        Try
            mConnection.ChangeDatabase("Campo2017_VentaPasajes")
            mCommand.CommandText = mReader.ReadToEnd
            mCommand.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        mConnection.Close()
        mReader.Close()
        mScript.Close()
    End Sub


    ''' <summary>
    ''' Actualiza el connectionString BDConnection del archivo app.config
    ''' </summary>
    ''' <param name="pString">connectionString con datos actualizados</param>
    Private Sub SetConfig(pString As String)
        Dim mConfig As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim mAppSettingSection As ConnectionStringsSection = mConfig.ConnectionStrings
        Dim mSettings As ConnectionStringSettings = mAppSettingSection.ConnectionStrings.Item("BDConnection")

        mSettings.ConnectionString = pString
        mConfig.Save(ConfigurationSaveMode.Modified)

        ConfigurationManager.RefreshSection("connectionStrings")
    End Sub

End Class