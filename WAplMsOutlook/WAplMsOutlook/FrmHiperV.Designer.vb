<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHiperV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHiperV))
        Me.BtnAddHpv = New System.Windows.Forms.Button()
        Me.txtHpv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboTipoCorreo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnAddHpv
        '
        Me.BtnAddHpv.Image = Global.WAplMsOutlook.My.Resources.Resources.plugin_link
        Me.BtnAddHpv.Location = New System.Drawing.Point(258, 24)
        Me.BtnAddHpv.Name = "BtnAddHpv"
        Me.BtnAddHpv.Size = New System.Drawing.Size(42, 27)
        Me.BtnAddHpv.TabIndex = 0
        Me.BtnAddHpv.UseVisualStyleBackColor = True
        '
        'txtHpv
        '
        Me.txtHpv.Location = New System.Drawing.Point(76, 28)
        Me.txtHpv.Name = "txtHpv"
        Me.txtHpv.Size = New System.Drawing.Size(176, 20)
        Me.txtHpv.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hipervínculo"
        '
        'CboTipoCorreo
        '
        Me.CboTipoCorreo.FormattingEnabled = True
        Me.CboTipoCorreo.Items.AddRange(New Object() {"http://", "https://", "file:", "ftp:", "mailto:", "news:", "telnet:"})
        Me.CboTipoCorreo.Location = New System.Drawing.Point(12, 27)
        Me.CboTipoCorreo.Name = "CboTipoCorreo"
        Me.CboTipoCorreo.Size = New System.Drawing.Size(58, 21)
        Me.CboTipoCorreo.TabIndex = 3
        '
        'FrmHiperV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(312, 70)
        Me.Controls.Add(Me.CboTipoCorreo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHpv)
        Me.Controls.Add(Me.BtnAddHpv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmHiperV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignación de Hipervínculo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAddHpv As System.Windows.Forms.Button
    Friend WithEvents txtHpv As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboTipoCorreo As System.Windows.Forms.ComboBox
End Class
