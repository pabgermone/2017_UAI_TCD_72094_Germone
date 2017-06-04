Imports BLL

Public Class FormAsignacion

    Dim mUsuarioSelec As UsuarioBLL
    Dim mRolSelec As RolBLL


#Region "Eventos Form"
    Private Sub FormAsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarRoles()
        ActualizarUsuarios()
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
        mUsuarioSelec.Rol = CType(ComboRoles.SelectedItem, RolBLL).ID

        mUsuarioSelec.Guardar()

        Me.Close()
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