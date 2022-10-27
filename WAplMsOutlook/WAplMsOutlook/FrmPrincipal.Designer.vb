<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.Panel_Principal = New System.Windows.Forms.Panel
        Me.BtnAdmMSOutlook = New System.Windows.Forms.Button
        Me.BtnAdmExcel = New System.Windows.Forms.Button
        Me.Panel_Principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Principal
        '
        Me.Panel_Principal.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Principal.Controls.Add(Me.BtnAdmMSOutlook)
        Me.Panel_Principal.Controls.Add(Me.BtnAdmExcel)
        Me.Panel_Principal.Location = New System.Drawing.Point(1, 12)
        Me.Panel_Principal.Name = "Panel_Principal"
        Me.Panel_Principal.Size = New System.Drawing.Size(379, 227)
        Me.Panel_Principal.TabIndex = 2
        '
        'BtnAdmMSOutlook
        '
        Me.BtnAdmMSOutlook.Image = Global.WAplMsOutlook.My.Resources.Resources.Office_MAIL_open
        Me.BtnAdmMSOutlook.Location = New System.Drawing.Point(191, 3)
        Me.BtnAdmMSOutlook.Name = "BtnAdmMSOutlook"
        Me.BtnAdmMSOutlook.Size = New System.Drawing.Size(178, 216)
        Me.BtnAdmMSOutlook.TabIndex = 3
        Me.BtnAdmMSOutlook.UseVisualStyleBackColor = True
        '
        'BtnAdmExcel
        '
        Me.BtnAdmExcel.Image = Global.WAplMsOutlook.My.Resources.Resources.Office_XLS
        Me.BtnAdmExcel.Location = New System.Drawing.Point(6, 3)
        Me.BtnAdmExcel.Name = "BtnAdmExcel"
        Me.BtnAdmExcel.Size = New System.Drawing.Size(179, 216)
        Me.BtnAdmExcel.TabIndex = 2
        Me.BtnAdmExcel.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WAplMsOutlook.My.Resources.Resources.Fondoagua
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(388, 248)
        Me.Controls.Add(Me.Panel_Principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.Opacity = 0.97
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Gestor de Correos"
        Me.Panel_Principal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Principal As System.Windows.Forms.Panel
    Friend WithEvents BtnAdmMSOutlook As System.Windows.Forms.Button
    Friend WithEvents BtnAdmExcel As System.Windows.Forms.Button
End Class
