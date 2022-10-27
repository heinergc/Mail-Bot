<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCorreo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Rtxthtml = New System.Windows.Forms.RichTextBox
        Me.rtbFoo = New System.Windows.Forms.RichTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Rtxthtml
        '
        Me.Rtxthtml.Location = New System.Drawing.Point(22, 179)
        Me.Rtxthtml.Name = "Rtxthtml"
        Me.Rtxthtml.Size = New System.Drawing.Size(605, 162)
        Me.Rtxthtml.TabIndex = 0
        Me.Rtxthtml.Text = ""
        '
        'rtbFoo
        '
        Me.rtbFoo.Location = New System.Drawing.Point(22, 12)
        Me.rtbFoo.Name = "rtbFoo"
        Me.rtbFoo.Size = New System.Drawing.Size(605, 161)
        Me.rtbFoo.TabIndex = 1
        Me.rtbFoo.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(566, 520)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(22, 348)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(538, 187)
        Me.WebBrowser1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(573, 434)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 29)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmCorreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 547)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rtbFoo)
        Me.Controls.Add(Me.Rtxthtml)
        Me.Name = "FrmCorreo"
        Me.Text = "FrmCorreo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Rtxthtml As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbFoo As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
