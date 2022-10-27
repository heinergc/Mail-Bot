<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Gb = New System.Windows.Forms.GroupBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.Img = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnConectar = New System.Windows.Forms.Button
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Gb.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(440, 244)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 113)
        Me.Panel1.TabIndex = 7
        '
        'Gb
        '
        Me.Gb.AutoSize = True
        Me.Gb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Gb.BackColor = System.Drawing.Color.Transparent
        Me.Gb.Controls.Add(Me.PictureBox3)
        Me.Gb.Controls.Add(Me.BtnCancelar)
        Me.Gb.Controls.Add(Me.PictureBox2)
        Me.Gb.Controls.Add(Me.BtnConectar)
        Me.Gb.Controls.Add(Me.txtUserName)
        Me.Gb.Controls.Add(Me.txtPassword)
        Me.Gb.Controls.Add(Me.Label2)
        Me.Gb.Controls.Add(Me.Label1)
        Me.Gb.Font = New System.Drawing.Font("Tahoma", 9.087379!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Gb.Location = New System.Drawing.Point(108, 11)
        Me.Gb.Name = "Gb"
        Me.Gb.Size = New System.Drawing.Size(292, 167)
        Me.Gb.TabIndex = 10
        Me.Gb.TabStop = False
        Me.Gb.Text = "Conexión al Sistema"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(262, 63)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 23)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.White
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.Font = New System.Drawing.Font("Tahoma", 9.087379!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.SlateGray
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.ImageIndex = 1
        Me.BtnCancelar.ImageList = Me.Img
        Me.BtnCancelar.Location = New System.Drawing.Point(185, 92)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(91, 54)
        Me.BtnCancelar.TabIndex = 8
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'Img
        '
        Me.Img.ImageStream = CType(resources.GetObject("Img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Img.TransparentColor = System.Drawing.Color.Transparent
        Me.Img.Images.SetKeyName(0, "Network Connection Manager.png")
        Me.Img.Images.SetKeyName(1, "cancel.png")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(262, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'BtnConectar
        '
        Me.BtnConectar.BackColor = System.Drawing.Color.White
        Me.BtnConectar.Font = New System.Drawing.Font("Tahoma", 9.087379!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConectar.ForeColor = System.Drawing.Color.SlateGray
        Me.BtnConectar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnConectar.ImageIndex = 0
        Me.BtnConectar.ImageList = Me.Img
        Me.BtnConectar.Location = New System.Drawing.Point(88, 92)
        Me.BtnConectar.Name = "BtnConectar"
        Me.BtnConectar.Size = New System.Drawing.Size(91, 54)
        Me.BtnConectar.TabIndex = 9
        Me.BtnConectar.Text = "Conectar"
        Me.BtnConectar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnConectar.UseVisualStyleBackColor = False
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(88, 34)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(167, 22)
        Me.txtUserName.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(88, 63)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(167, 22)
        Me.txtPassword.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario:"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.WAplMsOutlook.My.Resources.Resources.Office_MAIL_open
        Me.LogoPictureBox.Location = New System.Drawing.Point(553, 155)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(259, 76)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WAplMsOutlook.My.Resources.Resources.bannerHorizontal
        Me.PictureBox1.Location = New System.Drawing.Point(1, -11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 213)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WAplMsOutlook.My.Resources.Resources.FondoaguaAzul
        Me.ClientSize = New System.Drawing.Size(414, 193)
        Me.Controls.Add(Me.Gb)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.Opacity = 0.97
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MsOutlook Extraction of emails "
        Me.TransparencyKey = System.Drawing.Color.LightGray
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend WithEvents ConvertCSharp2VBService1 As PasteAsVB.CSToVBWebService.ConvertCSharp2VBService
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Gb As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnConectar As System.Windows.Forms.Button
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Img As System.Windows.Forms.ImageList

End Class
