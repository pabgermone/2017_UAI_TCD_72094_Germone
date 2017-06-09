Imports BLL

Public Class FormVerPermisos
    Dim mUsuario As UsuarioBLL
    Dim mRol As RolBLL

    Public Sub New(Optional pUsuario As UsuarioBLL = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not IsNothing(pUsuario) Then
            mUsuario = pUsuario

            mRol = New RolBLL(mUsuario.Rol)
        End If
    End Sub

    Private Sub FormVerPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarPermisos()

        TreePermisos.ExpandAll()
    End Sub

    ''' <summary>
    ''' Arma el treeview con los permisos que tiene el rol pasa por parametro al constructor
    ''' </summary>
    Public Sub ActualizarPermisos()
        If Not IsNothing(mRol) Then
            TreePermisos.Nodes.Clear()

            Dim mNodoRaiz As New TreeNode

            mNodoRaiz.Text = "Permisos de " & mUsuario.ToString
            TreePermisos.Nodes.Add(mNodoRaiz)

            For Each mPermiso As PermisoAbstractoBLL In mRol.ListaPermisos
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