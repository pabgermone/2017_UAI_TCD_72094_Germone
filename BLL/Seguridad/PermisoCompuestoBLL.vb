Imports System.Windows.Forms
Imports System.Reflection
Imports BE
Imports DAL

Public Class PermisoCompuestoBLL
    Inherits PermisoAbstractoBLL

    ''' <summary>
    ''' Lista de todos los permisos "hijos" de este PermisoCompuesto
    ''' </summary>
    ''' <returns></returns>
    Public Property ListaPermisos As New List(Of PermisoAbstractoBLL)

#Region "Constructores"
    Sub New()

    End Sub


    ''' <summary>
    ''' Crea una nueva instancia con los datos de un objeto BE y carga su lista de permisos hijo
    ''' </summary>
    ''' <param name="pBE"></param>
    Sub New(pBE As PermisoCompuestoBE)
        CargarPropiedades(pBE)
        CargarHijos()
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia con los datos recuperados de BD y carga su lista de permisos hijo
    ''' </summary>
    ''' <param name="pID">ID del registro de BD con los datos deseados</param>
    Sub New(pID As Integer)
        CargarPropiedades(pID)
        CargarHijos()
    End Sub
#End Region

#Region "Carga de Datos"
    ''' <summary>
    ''' Carga las propiedades de la instancia con los datos de un objeto BE
    ''' </summary>
    ''' <param name="pBE">Objeto BE con los datos que se quieren copiar</param>
    Private Sub CargarPropiedades(pBE As PermisoCompuestoBE)
        If Not IsNothing(pBE) Then
            Me.ID = pBE.ID
            Me.Nombre = pBE.Nombre
            Me.Padre = pBE.Padre
            Me.Formulario = pBE.Formulario
        End If
    End Sub


    ''' <summary>
    ''' Carga las propiedades de una instancia con los datos recuperados de BD
    ''' </summary>
    ''' <param name="pID">ID del registro de BD con los datos deseados</param>
    Private Sub CargarPropiedades(pID As Integer)
        Dim mBE As PermisoCompuestoBE = PermisoDAL.ObtenerPermiso(pID, True)

        If Not IsNothing(mBE) Then
            Me.ID = mBE.ID
            Me.Nombre = mBE.Nombre
            Me.Padre = mBE.Padre
            Me.Formulario = mBE.Formulario
        End If
    End Sub


    ''' <summary>
    ''' Carga un objeto BE con los datos de las propiedades de esta instancia
    ''' </summary>
    ''' <param name="pBE">Objeto BE que se quiere cargar con datos</param>
    Public Overrides Sub CargarBE(pBE As PermisoAbstractoBE)
        pBE.ID = Me.ID
        pBE.Nombre = Me.Nombre
        pBE.Padre = Me.Padre
        pBE.Formulario = Me.Formulario

        For Each mPermiso As PermisoAbstractoBLL In Me.ListaPermisos
            Dim mPermisoBE As PermisoAbstractoBE = Nothing

            If TypeOf (mPermiso) Is PermisoBLL Then
                mPermisoBE = New PermisoBE
            ElseIf TypeOf (mPermiso) Is PermisoCompuestoBLL Then
                mPermisoBE = New PermisoCompuestoBE
            End If

            mPermiso.CargarBE(mPermisoBE)
            CType(pBE, PermisoCompuestoBE).ListaPermisos.Add(mPermisoBE)
        Next
    End Sub


    ''' <summary>
    ''' Carga la lista de permisos hijo de la instancia que llama a este metodo
    ''' </summary>
    Private Sub CargarHijos()
        Dim mListaCompuestos As List(Of PermisoAbstractoBE) = PermisoDAL.ListarPermisos(True, Me.ID)
        Dim mListaSimples As List(Of PermisoAbstractoBE) = PermisoDAL.ListarPermisos(False, Me.ID)

        If Not IsNothing(mListaCompuestos) Then
            For Each mPermisoAbs As PermisoAbstractoBE In mListaCompuestos
                Dim mPermisoBLL As New PermisoCompuestoBLL(mPermisoAbs)
                Me.ListaPermisos.Add(mPermisoBLL)
            Next
        End If

        If Not IsNothing(mListaSimples) Then
            For Each mPermisoAbs As PermisoAbstractoBE In mListaSimples
                Dim mPermisoBLL As New PermisoBLL(mPermisoAbs)
                Me.ListaPermisos.Add(mPermisoBLL)
            Next
        End If
    End Sub

#End Region


    ''' <summary>
    ''' Guarda los datos de esta instancia en la BD
    ''' </summary>
    Public Overrides Sub Guardar()
        Dim mBE As New PermisoCompuestoBE

        If Me.ID = 0 Then
            CargarBE(mBE)
            PermisoDAL.GuardarNuevo(mBE)
        Else
            CargarBE(mBE)
            PermisoDAL.GuardarModificacion(mBE)
        End If
    End Sub


    ''' <summary>
    ''' Elimina los datos de esta entidad de la BD
    ''' </summary>
    Public Overrides Sub Eliminar()
        Dim mBE As New PermisoCompuestoBE
        CargarBE(mBE)
        PermisoDAL.Eliminar(mBE)
    End Sub


    ''' <summary>
    ''' Lista todos los permisos compuestos guardados eb el sistema
    ''' </summary>
    ''' <returns>Lista de los permisos persistidos en BD</returns>
    Public Shared Function ListarPermisos() As List(Of PermisoAbstractoBLL)
        Dim mListaPermisos As New List(Of PermisoAbstractoBLL)
        Dim mListBE As List(Of PermisoAbstractoBE) = PermisoDAL.ListarPermisos(True)

        If Not IsNothing(mListBE) Then
            For Each mPermiso As PermisoAbstractoBE In mListBE
                If TypeOf (mPermiso) Is PermisoCompuestoBE Then
                    Dim mPermisoBLL As New PermisoCompuestoBLL(mPermiso)
                    mListaPermisos.Add(mPermisoBLL)
                End If
            Next
        End If

        Return mListaPermisos
    End Function


#Region "Metodos Composite"
    ''' <summary>
    ''' Agrega al TreeNode todos los permisos hijo que tenga asociado el PermisoCompuesto guardado en el TreeNode
    ''' </summary>
    ''' <param name="pPermisoPadre">PermisoCompuesto guardado en el TreeNode</param>
    ''' <param name="pTreenode">TreeNode al que se quieren agregar los permisos</param>
    Public Sub AgregarPermisosHijo(pPermisoPadre As PermisoCompuestoBLL, pTreenode As TreeNode)
        For Each mPermisoAbstracto As PermisoAbstractoBLL In pPermisoPadre.ListaPermisos
            Dim mNode As New TreeNode
            mNode.Text = mPermisoAbstracto.Nombre
            mNode.Tag = mPermisoAbstracto
            pTreenode.Nodes.Add(mNode)

            If TypeOf (mPermisoAbstracto) Is PermisoCompuestoBLL Then
                Dim mPermisoCompuesto As PermisoCompuestoBLL
                mPermisoCompuesto = DirectCast(mPermisoAbstracto, PermisoCompuestoBLL)

                If mPermisoCompuesto.ListaPermisos.Count > 0 Then
                    AgregarPermisosHijo(mPermisoCompuesto, pTreenode.LastNode)
                End If
            End If
        Next
    End Sub


    ''' <summary>
    ''' Carga en un TreeView todos los permisos simples y compuestos del sistema
    ''' </summary>
    ''' <param name="pTreeView"></param>
    ''' <returns></returns>
    Public Overrides Function MostrarEnTreeview(pTreeView As TreeView) As TreeView
        Try
            Dim mListaPermisos As List(Of PermisoAbstractoBLL) = ListarPermisos()
            Dim mNode As TreeNode = pTreeView.Nodes.Add(mListaPermisos.Item(0).Nombre)
            mNode.Tag = mListaPermisos.Item(0)

            AgregarPermisosHijo(mNode.Tag, mNode)
        Catch ex As Exception

        End Try

        Return pTreeView
    End Function


    ''' <summary>
    ''' Carga dinamicamente un MenuStrip dependiendo del rol que tenga asignado un usuario
    ''' </summary>
    ''' <param name="pMenuStrip">MenuStrip en el que se quieren generar las opciones</param>
    ''' <param name="pUsuario">Usuario al que esta asociado el rol con el que se generan las pestañas</param>
    ''' <param name="pFormulario">Formulario en el que se encuentra el MenuStrip</param>
    Public Overrides Sub MostrarEnMenuStrip(pMenuStrip As MenuStrip, pUsuario As UsuarioBLL, pFormulario As Form)
        Dim mRol As New RolBLL(pUsuario.Rol)

        For Each mPermisoAbs As PermisoAbstractoBLL In mRol.ListaPermisos
            Dim mMenuItem As New ToolStripMenuItem()

            mMenuItem.Name = mPermisoAbs.Nombre
            mMenuItem.Tag = mPermisoAbs

            pMenuStrip.Items.Add(mMenuItem)
            pMenuStrip.Items.Item(mMenuItem.Name).Text = mPermisoAbs.Nombre

            If TypeOf mPermisoAbs Is PermisoCompuestoBLL Then
                AgregarToolStrip(mPermisoAbs, mMenuItem, pFormulario)
            Else
                AddHandler mMenuItem.Click, AddressOf Menu_Click
            End If
        Next
    End Sub


    ''' <summary>
    ''' Carga en un pestaña del MenuStrip una opcion por cada permiso que contenga el permiso pasado por parametro
    ''' </summary>
    ''' <param name="pPermiso">Permiso padre que contiene los permisos con los datos para las opciones</param>
    ''' <param name="pMenuItem">MenuItem en el que esta contenido el permiso padre</param>
    ''' <param name="pFormulario">Formulario en el que esta contenido el MenuStrip</param>
    Public Sub AgregarToolStrip(pPermiso As PermisoAbstractoBLL, pMenuItem As ToolStripMenuItem, pFormulario As Form)
        Try
            Dim mPadre As PermisoCompuestoBLL = DirectCast(pPermiso, PermisoCompuestoBLL)

            If Not mPadre.ListaPermisos Is Nothing Then
                For Each mPermisoAbs As PermisoAbstractoBLL In mPadre.ListaPermisos
                    Dim mMenuItem As New ToolStripMenuItem

                    mMenuItem.Name = mPermisoAbs.Nombre
                    mMenuItem.Tag = mPermisoAbs

                    pMenuItem.DropDownItems.Add(mMenuItem)
                    pMenuItem.DropDownItems.Item(mMenuItem.Name).Text = mPermisoAbs.Nombre


                    If TypeOf mPermisoAbs Is PermisoCompuestoBLL Then
                        AgregarToolStrip(mPermisoAbs, mMenuItem, pFormulario)
                    Else
                        AddHandler mMenuItem.Click, AddressOf Menu_Click
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub


    ''' <summary>
    ''' Evento que captura el Click de una de las opciones del MenuStrip de permisos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Sub Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim mMenuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Click(mMenuItem)
    End Sub


    ''' <summary>
    ''' Metodo encargado de abrir el formulario asociado con el permiso contenido en el MenuItem clickeado
    ''' </summary>
    ''' <param name="pMenuItem">MenuItem clickeado</param>
    Private Sub Click(pMenuItem As ToolStripItem)
        Dim mFormName As String = DirectCast(pMenuItem.Tag, PermisoBLL).Formulario.ToString
        Dim mAssembly As Assembly = Assembly.GetEntryAssembly
        Dim mType As Type = mAssembly.GetType(mFormName)
        Dim mForm = Activator.CreateInstance(mType)
        mForm.Show()
    End Sub
#End Region

End Class
