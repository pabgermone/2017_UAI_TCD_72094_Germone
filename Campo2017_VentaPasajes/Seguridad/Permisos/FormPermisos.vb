Imports BLL
Imports Framework

Public Class FormPermisos
    Implements IObservador

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


    Private Sub FormPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mCompuesto As New PermisoCompuestoBLL(0)
        mCompuesto.MostrarEnTreeview(TreePermisos)

        mTraductor.RegistrarObservador(Me)

        Actualizar(Me)
    End Sub


    'Controla los botones que pueden usarse dependiendo del tipo de permiso que se haya seleccionado
    Private Sub TreePermisos_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreePermisos.AfterSelect
        If TypeOf (TreePermisos.SelectedNode.Tag) Is PermisoBLL Then
            BtnNvoPermiso.Enabled = False
            BtnNvoCompuesto.Enabled = False
            BtnEliminar.Enabled = True
            BtnModificar.Enabled = True
        ElseIf TypeOf (TreePermisos.SelectedNode.Tag) Is PermisoCompuestoBLL Then
            BtnNvoPermiso.Enabled = True
            BtnNvoCompuesto.Enabled = True
            BtnEliminar.Enabled = True
            BtnModificar.Enabled = True
        Else
            BtnNvoPermiso.Enabled = False
            BtnNvoCompuesto.Enabled = False
            BtnModificar.Enabled = False
            BtnEliminar.Enabled = False
        End If
    End Sub


    Private Sub BtnNvoPermiso_Click(sender As Object, e As EventArgs) Handles BtnNvoPermiso.Click
        Dim mSelectedNode As TreeNode = Me.TreePermisos.SelectedNode

        If TypeOf mSelectedNode.Tag Is PermisoCompuestoBLL Then

            Dim mPadre As PermisoCompuestoBLL = mSelectedNode.Tag

            Dim mForm As New AltaPermiso
            mForm.ShowDialog()

            Dim mNombrePermiso As String = mForm.Nombre
            Dim mNombreFormulario As String = mForm.Formulario

            If (mNombrePermiso.Length > 0) And (mNombreFormulario.Length > 0) Then

                Dim mPermiso As New PermisoBLL
                Dim mNodoNuevo As New TreeNode

                mNodoNuevo.Text = mNombrePermiso

                mPermiso.Nombre = mNombrePermiso
                mPermiso.Formulario = mNombreFormulario
                mPermiso.Padre = mPadre.ID

                mPermiso.Guardar()

                mNodoNuevo.Tag = mPermiso

                mSelectedNode.Nodes.Add(mNodoNuevo)
                mPadre.ListaPermisos.Add(mPermiso)
            End If

            TreePermisos.ExpandAll()
        End If
    End Sub


    Private Sub BtnNvoCompuesto_Click(sender As Object, e As EventArgs) Handles BtnNvoCompuesto.Click
        Dim mSelectedNode As TreeNode = TreePermisos.SelectedNode

        If TypeOf mSelectedNode.Tag Is PermisoCompuestoBLL Then
            Dim mPadre As PermisoCompuestoBLL = mSelectedNode.Tag
            Dim mNombrePermiso As String = InputBox("Ingrese el nombre del Permiso: ")

            If mNombrePermiso.Length > 0 Then
                Dim mPermisoCompuesto As New PermisoCompuestoBLL
                mPermisoCompuesto.Nombre = mNombrePermiso
                mPermisoCompuesto.Padre = mPadre.ID

                Dim mNodoNuevo As New TreeNode
                mNodoNuevo.Text = mNombrePermiso
                mNodoNuevo.Tag = mPermisoCompuesto

                mSelectedNode.Nodes.Add(mNodoNuevo)
                mPadre.ListaPermisos.Add(mPermisoCompuesto)

                mPermisoCompuesto.Guardar()
                TreePermisos.Nodes.Clear()

                FormPermisos_Load(Nothing, Nothing)
                TreePermisos.ExpandAll()
            Else
                MsgBox("Debe ingresar un nombre para el nuevo permiso compuesto")
            End If
        End If
    End Sub


    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TypeOf (TreePermisos.SelectedNode.Tag) Is PermisoBLL Then
            Dim mFormulario As New ModificarPermiso(TreePermisos.SelectedNode.Tag)
            mFormulario.ShowDialog()
            TreePermisos.ExpandAll()
        ElseIf TypeOf (TreePermisos.SelectedNode.Tag) Is PermisoCompuestoBLL Then
            Dim mPermiso As PermisoCompuestoBLL = TreePermisos.SelectedNode.Tag

            mPermiso.Nombre = InputBox("Ingrese el nuevo nombre para el permiso compuesto:")

            If mPermiso.Nombre <> "" Then
                mPermiso.Guardar()

                TreePermisos.SelectedNode.Tag = mPermiso
                TreePermisos.Nodes.Clear()
                FormPermisos_Load(Nothing, Nothing)
                TreePermisos.ExpandAll()
            Else
                MsgBox("Debe ingresar el nuevo nombre para el permiso")
            End If
        Else
            MsgBox("Debe seleccionar un nodo")
        End If
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TypeOf (TreePermisos.SelectedNode.Tag) Is PermisoCompuestoBLL Then
            If MsgBox("Esta seguro que quiere eliminar este permiso y todos sus componentes?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                CType(TreePermisos.SelectedNode.Tag, PermisoCompuestoBLL).Eliminar()
            End If
        ElseIf TypeOf TreePermisos.SelectedNode.Tag Is PermisoBLL Then
            If MsgBox("Esta seguro que desea eliminar este permiso?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                CType(TreePermisos.SelectedNode.Tag, PermisoBLL).Eliminar()
            End If
        Else
            MsgBox("Debe seleccionar un nodo")
        End If

        TreePermisos.Nodes.Clear()
        FormPermisos_Load(Nothing, Nothing)
        TreePermisos.ExpandAll()
    End Sub
End Class