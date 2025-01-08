<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.btnVisitar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtUrl
        '
        Me.txtUrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUrl.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUrl.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtUrl.Location = New System.Drawing.Point(30, 52)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(492, 35)
        Me.txtUrl.TabIndex = 0
        Me.txtUrl.Text = """http://www.mcgraw-hill.com.mx/Mexico/Profesional/Default.htm"""
        '
        'btnVisitar
        '
        Me.btnVisitar.BackColor = System.Drawing.Color.IndianRed
        Me.btnVisitar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisitar.ForeColor = System.Drawing.Color.Blue
        Me.btnVisitar.Location = New System.Drawing.Point(118, 119)
        Me.btnVisitar.Name = "btnVisitar"
        Me.btnVisitar.Size = New System.Drawing.Size(321, 71)
        Me.btnVisitar.TabIndex = 1
        Me.btnVisitar.Text = "Visitar el sitio Web"
        Me.btnVisitar.UseVisualStyleBackColor = False
        '
        'btnListar
        '
        Me.btnListar.BackColor = System.Drawing.Color.IndianRed
        Me.btnListar.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.ForeColor = System.Drawing.Color.Blue
        Me.btnListar.Location = New System.Drawing.Point(118, 227)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(321, 71)
        Me.btnListar.TabIndex = 2
        Me.btnListar.Text = "Listar Sitios Visitados Recientemente"
        Me.btnListar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 360)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnVisitar)
        Me.Controls.Add(Me.txtUrl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUrl As TextBox
    Friend WithEvents btnVisitar As Button
    Friend WithEvents btnListar As Button
End Class
