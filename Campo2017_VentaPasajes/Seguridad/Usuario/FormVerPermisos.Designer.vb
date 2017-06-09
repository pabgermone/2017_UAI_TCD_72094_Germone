<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVerPermisos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TreePermisos = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'TreePermisos
        '
        Me.TreePermisos.Location = New System.Drawing.Point(0, 0)
        Me.TreePermisos.Name = "TreePermisos"
        Me.TreePermisos.Size = New System.Drawing.Size(231, 409)
        Me.TreePermisos.TabIndex = 0
        '
        'FormVerPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 409)
        Me.Controls.Add(Me.TreePermisos)
        Me.Name = "FormVerPermisos"
        Me.Text = "FormVerPermisos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreePermisos As TreeView
End Class
