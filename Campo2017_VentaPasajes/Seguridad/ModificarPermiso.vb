Imports BLL
Imports System.Reflection

Public Class ModificarPermiso
    Dim mPermiso As PermisoBLL

    Public Sub New(pPermiso As PermisoBLL)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mPermiso = pPermiso
    End Sub


    Private Sub ModificarPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Asm As Assembly = Reflection.Assembly.GetExecutingAssembly()

        For Each t As Type In Asm.GetTypes()
            If t.IsSubclassOf(GetType(Form)) Then
                Me.cmbFormularios.Items.Add(t.FullName)

                If t.FullName = mPermiso.Formulario Then
                    cmbFormularios.SelectedItem = t.FullName
                End If
            End If
        Next

        txtNombre.Text = mPermiso.Nombre
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mPermiso.Nombre = txtNombre.Text
        mPermiso.Formulario = cmbFormularios.SelectedItem

        mPermiso.Guardar()

        Me.Close()
    End Sub
End Class