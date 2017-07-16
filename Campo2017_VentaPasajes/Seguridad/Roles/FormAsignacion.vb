Imports BLL
Imports Framework

Public Class FormAsignacion
    Implements IObservador

    Dim mUsuarioSelec As UsuarioBLL
    Dim mRolSelec As RolBLL
    Dim mTraductor As Traductor = Traductor.GetInstance


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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


#Region "Eventos Form"
    Private Sub FormAsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarRoles()
        ActualizarUsuarios()

        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
    End Sub


    Private Sub ComboUsuarios_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboUsuarios.SelectedValueChanged
        If Not IsNothing(ComboUsuarios.SelectedItem) And TypeOf (ComboUsuarios.SelectedItem) Is UsuarioBLL Then
            mUsuarioSelec = ComboUsuarios.SelectedItem

            If mUsuarioSelec.Rol = 0 Then
                ComboRoles.SelectedItem = ComboRoles.Items(0)
            Else
                For Each mItem In ComboRoles.Items
                    If TypeOf (mItem) Is RolBLL Then
                        If mItem.ID = mUsuarioSelec.Rol Then
                            ComboRoles.SelectedItem = mItem
                        End If
                    End If
                Next
            End If
        End If
    End Sub


    Private Sub ComboRoles_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboRoles.SelectedValueChanged
        If Not IsNothing(ComboRoles.SelectedItem) And TypeOf (ComboRoles.SelectedItem) Is RolBLL Then
            mRolSelec = ComboRoles.SelectedItem

            ActualizarPermisos()
        Else
            TreePermisos.Nodes.Clear()
        End If
    End Sub
#End Region


#Region "Botones"
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If Not IsNothing(mUsuarioSelec) Then
            If TypeOf ComboRoles.SelectedItem Is RolBLL Then
                mUsuarioSelec.Rol = CType(ComboRoles.SelectedItem, RolBLL).ID

                mUsuarioSelec.Guardar()

                Me.Close()
            Else
                MsgBox("Debe seleccionar el rol que quiere asignar al usuario")
            End If
        Else
            MsgBox("Debe seleccionar un usuario")
        End If
    End Sub


    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
#End Region


    Public Sub ActualizarUsuarios()
        ComboUsuarios.DataSource = Nothing
        ComboUsuarios.DataSource = UsuarioBLL.ListarUsuarios
    End Sub


    Public Sub ActualizarRoles()
        ComboRoles.Items.Clear()

        ComboRoles.Items.Add(" - Seleccione un rol -")

        For Each mRol As RolBLL In RolBLL.ListarRoles
            ComboRoles.Items.Add(mRol)
        Next
    End Sub


    ''' <summary>
    ''' Arma el treeview con los permisos que tiene el rol seleccionado
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
End Class