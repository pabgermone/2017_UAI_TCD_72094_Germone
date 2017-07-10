Imports BLL
Imports Framework

Public Class FormCambioRolUsuario
    Implements IObservador

    Dim mUsuario As UsuarioBLL
    Dim mRolUsuario As RolBLL
    Dim mRolSelec As RolBLL
    Dim mTraductor As Traductor = Traductor.GetInstance

    Public Sub New(Optional pUsuario As UsuarioBLL = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not IsNothing(pUsuario) Then
            mUsuario = pUsuario

            mRolUsuario = New RolBLL(mUsuario.Rol)
        End If

        For Each mControl As Control In Me.Controls
            Try
                CargarTags(mControl)
            Catch ex As Exception

            End Try
        Next
    End Sub


    ''' <summary>
    ''' Carga en pControl.Tag el texto que tiene pControl al momento de instanciar el Form
    ''' </summary>
    ''' <param name="pControl"></param>
    Public Sub CargarTags(pControl As Control)
        pControl.Tag = pControl.Text

        If pControl.Controls.Count > 0 Then
            For Each mControl As Control In pControl.Controls
                CargarTags(mControl)
            Next
        End If
    End Sub


#Region "Observer"

    Public Sub Actualizar(pObservador As Control) Implements IObservador.Actualizar
        For Each mControl As Control In pObservador.Controls
            Try
                mControl.Text = mTraductor.IdiomaSeleccionado.Diccionario.Item(mControl.Tag)
            Catch ex As Exception

            Finally
                If mControl.Controls.Count > 0 Then
                    Actualizar(mControl)
                End If
            End Try
        Next
    End Sub

#End Region


    Private Sub FormCambioRolUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each mRol As RolBLL In RolBLL.ListarRoles
            ComboRoles.Items.Add(mRol)
        Next

        If Not IsNothing(mRolUsuario) Then
            For Each mRol In ComboRoles.Items
                If TypeOf (mRol) Is RolBLL Then
                    If CType(mRol, RolBLL).Nombre = mRolUsuario.Nombre Then
                        ComboRoles.SelectedItem = mRol
                    End If
                End If
            Next
        End If

        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
    End Sub


    Private Sub ComboRoles_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboRoles.SelectedValueChanged
        If Not IsNothing(ComboRoles.SelectedItem) And TypeOf (ComboRoles.SelectedItem) Is RolBLL Then
            mRolSelec = ComboRoles.SelectedItem

            ActualizarPermisos()

            TreePermisos.ExpandAll()
        End If
    End Sub


    ''' <summary>
    ''' Arma el treeview con los permisos que tiene el rol selecionado
    ''' </summary>
    Public Sub ActualizarPermisos()
        If Not IsNothing(mRolSelec) Then
            TreePermisos.Nodes.Clear()

            Dim mNodoRaiz As New TreeNode

            mNodoRaiz.Text = "Permisos de " & mRolSelec.Nombre
            TreePermisos.Nodes.Add(mNodoRaiz)

            For Each mPermiso As PermisoAbstractoBLL In mRolSelec.ListaPermisos
                AgregarNodos(mNodoRaiz, mPermiso)
            Next

            TreePermisos.ExpandAll()
        End If
    End Sub


    ''' <summary>
    ''' Agrega al treeview los nodos correspondientes a un permiso
    ''' </summary>
    ''' <param name="pNodo">Nodo al que agregar los nodos del permiso</param>
    ''' <param name="pPermiso">Permiso del que se quieren agregar nodos</param>
    Public Sub AgregarNodos(pNodo As TreeNode, pPermiso As PermisoAbstractoBLL)
        Dim mNodo As New TreeNode
        mNodo.Text = pPermiso.Nombre
        pNodo.Nodes.Add(mNodo)

        If TypeOf (pPermiso) Is PermisoCompuestoBLL Then
            For Each mPermiso As PermisoAbstractoBLL In CType(pPermiso, PermisoCompuestoBLL).ListaPermisos
                AgregarNodos(mNodo, mPermiso)
            Next
        End If
    End Sub


    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If Not IsNothing(mRolSelec) Then
            If MsgBox("Esta seguro que quiere asignarle el rol seleccionado al usuario " & mUsuario.ToString & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                mUsuario.Rol = mRolSelec.ID

                mUsuario.Guardar()

                Me.Close()
            End If
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class