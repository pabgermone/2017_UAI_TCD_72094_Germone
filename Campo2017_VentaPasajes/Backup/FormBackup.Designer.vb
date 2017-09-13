<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBackup
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
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.BtnExaminar = New System.Windows.Forms.Button()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.BtnCrear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.OpenBackup = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(45, 52)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(514, 26)
        Me.TxtNombre.TabIndex = 0
        '
        'BtnExaminar
        '
        Me.BtnExaminar.Location = New System.Drawing.Point(590, 165)
        Me.BtnExaminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExaminar.Name = "BtnExaminar"
        Me.BtnExaminar.Size = New System.Drawing.Size(160, 35)
        Me.BtnExaminar.TabIndex = 1
        Me.BtnExaminar.Text = "Examinar"
        Me.BtnExaminar.UseVisualStyleBackColor = True
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(44, 168)
        Me.TxtDireccion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(514, 26)
        Me.TxtDireccion.TabIndex = 2
        '
        'BtnCrear
        '
        Me.BtnCrear.Location = New System.Drawing.Point(590, 48)
        Me.BtnCrear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(160, 35)
        Me.BtnCrear.TabIndex = 3
        Me.BtnCrear.Text = "Crear Backup"
        Me.BtnCrear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 144)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Direccion:"
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Location = New System.Drawing.Point(590, 210)
        Me.BtnRestaurar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(160, 35)
        Me.BtnRestaurar.TabIndex = 6
        Me.BtnRestaurar.Text = "Restaurar"
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        '
        'OpenBackup
        '
        Me.OpenBackup.Filter = "SQL Server Bakup | *.bak"
        '
        'FormBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 282)
        Me.Controls.Add(Me.BtnRestaurar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.BtnExaminar)
        Me.Controls.Add(Me.TxtNombre)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormBackup"
        Me.Text = "FormBackup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents BtnExaminar As Button
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents BtnCrear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents OpenBackup As OpenFileDialog
End Class
