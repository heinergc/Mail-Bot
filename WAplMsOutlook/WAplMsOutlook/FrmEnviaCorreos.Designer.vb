<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEnviaCorreos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEnviaCorreos))
        Me.lbCorreosInvalidos = New System.Windows.Forms.ListBox()
        Me.lbEnviados = New System.Windows.Forms.ListBox()
        Me.LbDuplicados = New System.Windows.Forms.ListBox()
        Me.Panel_Izquierda = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbErrores = New System.Windows.Forms.ListBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LbNoEnviados = New System.Windows.Forms.ListBox()
        Me.BtnCorreosInvalidos = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnNOEnviados = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnCorresEnviados = New System.Windows.Forms.Button()
        Me.TextHoja = New System.Windows.Forms.TextBox()
        Me.BtnGuardaDuplicados = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lvCorreos = New System.Windows.Forms.ListView()
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.BtncFileLp = New System.Windows.Forms.Button()
        Me.cboSheetBooks = New System.Windows.Forms.ComboBox()
        Me.BtnExaminar = New System.Windows.Forms.Button()
        Me.lblHoja = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Imgtree = New System.Windows.Forms.ImageList(Me.components)
        Me.txtTituloCorreo = New System.Windows.Forms.TextBox()
        Me.lblAsunto = New System.Windows.Forms.Label()
        Me.RBtn_MS_Exchange = New System.Windows.Forms.RadioButton()
        Me.RBtn_Hotmail = New System.Windows.Forms.RadioButton()
        Me.RBtnGmail = New System.Windows.Forms.RadioButton()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.GbImagenes = New System.Windows.Forms.GroupBox()
        Me.lblinfoImg = New System.Windows.Forms.Label()
        Me.lblImgFinal = New System.Windows.Forms.Label()
        Me.lblUbicacionImgFinal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUbicacionImgInic = New System.Windows.Forms.Label()
        Me.BtnImgFinal = New System.Windows.Forms.Button()
        Me.BtnImgInic = New System.Windows.Forms.Button()
        Me.TxtImgFinal = New System.Windows.Forms.TextBox()
        Me.txtImgInicio = New System.Windows.Forms.TextBox()
        Me.chkImgFinal = New System.Windows.Forms.CheckBox()
        Me.ChkImgInicio = New System.Windows.Forms.CheckBox()
        Me.Pic_Final = New System.Windows.Forms.PictureBox()
        Me.Pic_Inicio = New System.Windows.Forms.PictureBox()
        Me.WebBrowserEmail = New System.Windows.Forms.WebBrowser()
        Me.GbFormato = New System.Windows.Forms.GroupBox()
        Me.BtnJustifyFull = New System.Windows.Forms.Button()
        Me.BtnJustifyCenter = New System.Windows.Forms.Button()
        Me.lstFont = New System.Windows.Forms.ComboBox()
        Me.BtnJustifyLeft = New System.Windows.Forms.Button()
        Me.lstSize = New System.Windows.Forms.ComboBox()
        Me.btnP = New System.Windows.Forms.Button()
        Me.BtnRemoteFormat = New System.Windows.Forms.Button()
        Me.BtnJustifyRight = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.BtnBackColor = New System.Windows.Forms.Button()
        Me.btnI = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.Btn_InicEditor = New System.Windows.Forms.Button()
        Me.GbAbrir = New System.Windows.Forms.GroupBox()
        Me.rBtn_Word = New System.Windows.Forms.RadioButton()
        Me.rBtn_HTML = New System.Windows.Forms.RadioButton()
        Me.txtConocidoComo = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.txtCorreoEnvia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDe = New System.Windows.Forms.Label()
        Me.lblAdjuntos = New System.Windows.Forms.Label()
        Me.ChkAddImg = New System.Windows.Forms.CheckBox()
        Me.textAttachments = New System.Windows.Forms.TextBox()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.lblProgres = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Pb = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblCargados = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCorreosCargados = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCorreosDuplicados = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCorreosInvalidos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEnviados = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCorreo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.T = New System.Windows.Forms.Timer(Me.components)
        Me.attachmentDlg = New System.Windows.Forms.OpenFileDialog()
        Me.colorDlg = New System.Windows.Forms.ColorDialog()
        Me.TTCorreos = New System.Windows.Forms.ToolTip(Me.components)
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.lblTituloSistema = New System.Windows.Forms.Label()
        Me.Restaurar = New System.Windows.Forms.PictureBox()
        Me.Minimizar = New System.Windows.Forms.PictureBox()
        Me.Maximizar = New System.Windows.Forms.PictureBox()
        Me.Cerrar = New System.Windows.Forms.PictureBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BtnOpenUrl = New System.Windows.Forms.Button()
        Me.Btn_Adelante = New System.Windows.Forms.Button()
        Me.BtnIr = New System.Windows.Forms.Button()
        Me.Btn_Atras = New System.Windows.Forms.Button()
        Me.IconBtnLoadMails = New FontAwesomeIcons.IconButton()
        Me.IconBtnOpenURL = New FontAwesomeIcons.IconButton()
        Me.IconBtnSendMail = New FontAwesomeIcons.IconButton()
        Me.IconBtnSave = New FontAwesomeIcons.IconButton()
        Me.IconBtnClearAttachment = New FontAwesomeIcons.IconButton()
        Me.IconBtnNew = New FontAwesomeIcons.IconButton()
        Me.IconBtnFolderOpen = New FontAwesomeIcons.IconButton()
        Me.IconBtnAttachment = New FontAwesomeIcons.IconButton()
        Me.IconBtnIr = New FontAwesomeIcons.IconButton()
        Me.IconBtnRigth = New FontAwesomeIcons.IconButton()
        Me.IconBtnLeft = New FontAwesomeIcons.IconButton()
        Me.IconBtnInsertLine = New FontAwesomeIcons.IconButton()
        Me.IconBtnAddLink = New FontAwesomeIcons.IconButton()
        Me.iconToolbar = New FontAwesomeIcons.IconButton()
        Me.Panel_Izquierda.SuspendLayout()
        Me.GbImagenes.SuspendLayout()
        CType(Me.Pic_Final, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbFormato.SuspendLayout()
        Me.GbAbrir.SuspendLayout()
        Me.Status.SuspendLayout()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.Restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.IconBtnLoadMails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconBtnOpenURL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconBtnSendMail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconBtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconBtnClearAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconBtnNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconBtnFolderOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconBtnAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconBtnIr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconBtnRigth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconBtnLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconBtnInsertLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconBtnAddLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconToolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbCorreosInvalidos
        '
        Me.lbCorreosInvalidos.FormattingEnabled = True
        Me.lbCorreosInvalidos.ItemHeight = 16
        Me.lbCorreosInvalidos.Location = New System.Drawing.Point(377, 332)
        Me.lbCorreosInvalidos.Margin = New System.Windows.Forms.Padding(4)
        Me.lbCorreosInvalidos.Name = "lbCorreosInvalidos"
        Me.lbCorreosInvalidos.Size = New System.Drawing.Size(259, 196)
        Me.lbCorreosInvalidos.TabIndex = 5
        '
        'lbEnviados
        '
        Me.lbEnviados.FormattingEnabled = True
        Me.lbEnviados.ItemHeight = 16
        Me.lbEnviados.Location = New System.Drawing.Point(905, 70)
        Me.lbEnviados.Margin = New System.Windows.Forms.Padding(4)
        Me.lbEnviados.Name = "lbEnviados"
        Me.lbEnviados.Size = New System.Drawing.Size(259, 196)
        Me.lbEnviados.TabIndex = 3
        '
        'LbDuplicados
        '
        Me.LbDuplicados.FormattingEnabled = True
        Me.LbDuplicados.ItemHeight = 16
        Me.LbDuplicados.Location = New System.Drawing.Point(380, 70)
        Me.LbDuplicados.Margin = New System.Windows.Forms.Padding(4)
        Me.LbDuplicados.Name = "LbDuplicados"
        Me.LbDuplicados.Size = New System.Drawing.Size(259, 196)
        Me.LbDuplicados.TabIndex = 1
        '
        'Panel_Izquierda
        '
        Me.Panel_Izquierda.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel_Izquierda.Controls.Add(Me.Panel6)
        Me.Panel_Izquierda.Controls.Add(Me.lbErrores)
        Me.Panel_Izquierda.Controls.Add(Me.Panel5)
        Me.Panel_Izquierda.Controls.Add(Me.LbNoEnviados)
        Me.Panel_Izquierda.Controls.Add(Me.BtnCorreosInvalidos)
        Me.Panel_Izquierda.Controls.Add(Me.Panel3)
        Me.Panel_Izquierda.Controls.Add(Me.BtnNOEnviados)
        Me.Panel_Izquierda.Controls.Add(Me.Panel2)
        Me.Panel_Izquierda.Controls.Add(Me.lbCorreosInvalidos)
        Me.Panel_Izquierda.Controls.Add(Me.Panel1)
        Me.Panel_Izquierda.Controls.Add(Me.Panel4)
        Me.Panel_Izquierda.Controls.Add(Me.lbEnviados)
        Me.Panel_Izquierda.Controls.Add(Me.BtnCorresEnviados)
        Me.Panel_Izquierda.Controls.Add(Me.TextHoja)
        Me.Panel_Izquierda.Controls.Add(Me.LbDuplicados)
        Me.Panel_Izquierda.Controls.Add(Me.BtnGuardaDuplicados)
        Me.Panel_Izquierda.Controls.Add(Me.Button1)
        Me.Panel_Izquierda.Controls.Add(Me.IconBtnLoadMails)
        Me.Panel_Izquierda.Controls.Add(Me.lvCorreos)
        Me.Panel_Izquierda.Controls.Add(Me.BtnCargar)
        Me.Panel_Izquierda.Controls.Add(Me.BtncFileLp)
        Me.Panel_Izquierda.Controls.Add(Me.cboSheetBooks)
        Me.Panel_Izquierda.Controls.Add(Me.BtnExaminar)
        Me.Panel_Izquierda.Controls.Add(Me.lblHoja)
        Me.Panel_Izquierda.Controls.Add(Me.txtdireccion)
        Me.Panel_Izquierda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Izquierda.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Izquierda.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_Izquierda.Name = "Panel_Izquierda"
        Me.Panel_Izquierda.Size = New System.Drawing.Size(1195, 654)
        Me.Panel_Izquierda.TabIndex = 27
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(905, 278)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 46)
        Me.Panel6.TabIndex = 22
        '
        'lbErrores
        '
        Me.lbErrores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbErrores.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lbErrores.FormattingEnabled = True
        Me.lbErrores.ItemHeight = 16
        Me.lbErrores.Location = New System.Drawing.Point(377, 542)
        Me.lbErrores.Margin = New System.Windows.Forms.Padding(4)
        Me.lbErrores.Name = "lbErrores"
        Me.lbErrores.Size = New System.Drawing.Size(789, 100)
        Me.lbErrores.TabIndex = 71
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(377, 277)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 46)
        Me.Panel5.TabIndex = 21
        '
        'LbNoEnviados
        '
        Me.LbNoEnviados.FormattingEnabled = True
        Me.LbNoEnviados.ItemHeight = 16
        Me.LbNoEnviados.Location = New System.Drawing.Point(905, 332)
        Me.LbNoEnviados.Margin = New System.Windows.Forms.Padding(4)
        Me.LbNoEnviados.Name = "LbNoEnviados"
        Me.LbNoEnviados.Size = New System.Drawing.Size(259, 196)
        Me.LbNoEnviados.TabIndex = 32
        '
        'BtnCorreosInvalidos
        '
        Me.BtnCorreosInvalidos.FlatAppearance.BorderSize = 0
        Me.BtnCorreosInvalidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCorreosInvalidos.ForeColor = System.Drawing.Color.White
        Me.BtnCorreosInvalidos.Image = Global.WAplMsOutlook.My.Resources.Resources.save_icon_18_32
        Me.BtnCorreosInvalidos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnCorreosInvalidos.Location = New System.Drawing.Point(393, 277)
        Me.BtnCorreosInvalidos.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCorreosInvalidos.Name = "BtnCorreosInvalidos"
        Me.BtnCorreosInvalidos.Size = New System.Drawing.Size(241, 47)
        Me.BtnCorreosInvalidos.TabIndex = 4
        Me.BtnCorreosInvalidos.Text = "Guardar Correos Inválidos"
        Me.BtnCorreosInvalidos.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(908, 16)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 46)
        Me.Panel3.TabIndex = 21
        '
        'BtnNOEnviados
        '
        Me.BtnNOEnviados.FlatAppearance.BorderSize = 0
        Me.BtnNOEnviados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNOEnviados.ForeColor = System.Drawing.Color.White
        Me.BtnNOEnviados.Image = Global.WAplMsOutlook.My.Resources.Resources.save_icon_18_32
        Me.BtnNOEnviados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNOEnviados.Location = New System.Drawing.Point(921, 278)
        Me.BtnNOEnviados.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNOEnviados.Name = "BtnNOEnviados"
        Me.BtnNOEnviados.Size = New System.Drawing.Size(241, 46)
        Me.BtnNOEnviados.TabIndex = 6
        Me.BtnNOEnviados.Text = "Guarda Correos No Enviados"
        Me.BtnNOEnviados.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(380, 16)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 46)
        Me.Panel2.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(17, 599)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 46)
        Me.Panel1.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(16, 14)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 46)
        Me.Panel4.TabIndex = 18
        '
        'BtnCorresEnviados
        '
        Me.BtnCorresEnviados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCorresEnviados.FlatAppearance.BorderSize = 0
        Me.BtnCorresEnviados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCorresEnviados.ForeColor = System.Drawing.Color.White
        Me.BtnCorresEnviados.Image = Global.WAplMsOutlook.My.Resources.Resources.save_icon_18_32
        Me.BtnCorresEnviados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCorresEnviados.Location = New System.Drawing.Point(924, 16)
        Me.BtnCorresEnviados.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCorresEnviados.Name = "BtnCorresEnviados"
        Me.BtnCorresEnviados.Size = New System.Drawing.Size(243, 44)
        Me.BtnCorresEnviados.TabIndex = 2
        Me.BtnCorresEnviados.Text = "Guardar Correos Enviados"
        Me.BtnCorresEnviados.UseVisualStyleBackColor = True
        '
        'TextHoja
        '
        Me.TextHoja.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextHoja.Location = New System.Drawing.Point(442, 471)
        Me.TextHoja.Margin = New System.Windows.Forms.Padding(4)
        Me.TextHoja.Name = "TextHoja"
        Me.TextHoja.Size = New System.Drawing.Size(199, 27)
        Me.TextHoja.TabIndex = 3
        Me.TextHoja.Visible = False
        '
        'BtnGuardaDuplicados
        '
        Me.BtnGuardaDuplicados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnGuardaDuplicados.FlatAppearance.BorderSize = 0
        Me.BtnGuardaDuplicados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardaDuplicados.ForeColor = System.Drawing.Color.White
        Me.BtnGuardaDuplicados.Image = Global.WAplMsOutlook.My.Resources.Resources.save_icon_18_32
        Me.BtnGuardaDuplicados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardaDuplicados.Location = New System.Drawing.Point(397, 14)
        Me.BtnGuardaDuplicados.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardaDuplicados.Name = "BtnGuardaDuplicados"
        Me.BtnGuardaDuplicados.Size = New System.Drawing.Size(242, 48)
        Me.BtnGuardaDuplicados.TabIndex = 0
        Me.BtnGuardaDuplicados.Text = "Guardar Correos Duplicados"
        Me.BtnGuardaDuplicados.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(454, 381)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 28)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'lvCorreos
        '
        Me.lvCorreos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvCorreos.HideSelection = False
        Me.lvCorreos.Location = New System.Drawing.Point(16, 153)
        Me.lvCorreos.Margin = New System.Windows.Forms.Padding(4)
        Me.lvCorreos.Name = "lvCorreos"
        Me.lvCorreos.Size = New System.Drawing.Size(328, 438)
        Me.lvCorreos.TabIndex = 2
        Me.lvCorreos.UseCompatibleStateImageBehavior = False
        Me.lvCorreos.View = System.Windows.Forms.View.Details
        '
        'BtnCargar
        '
        Me.BtnCargar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargar.Location = New System.Drawing.Point(440, 435)
        Me.BtnCargar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(88, 28)
        Me.BtnCargar.TabIndex = 4
        Me.BtnCargar.Text = "Cargar"
        Me.BtnCargar.UseVisualStyleBackColor = True
        Me.BtnCargar.Visible = False
        '
        'BtncFileLp
        '
        Me.BtncFileLp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtncFileLp.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtncFileLp.FlatAppearance.BorderSize = 0
        Me.BtncFileLp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtncFileLp.Font = New System.Drawing.Font("Century Gothic", 7.8!)
        Me.BtncFileLp.ForeColor = System.Drawing.SystemColors.Window
        Me.BtncFileLp.Image = Global.WAplMsOutlook.My.Resources.Resources.save_icon_18_32
        Me.BtncFileLp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtncFileLp.Location = New System.Drawing.Point(36, 599)
        Me.BtncFileLp.Margin = New System.Windows.Forms.Padding(4)
        Me.BtncFileLp.Name = "BtncFileLp"
        Me.BtncFileLp.Size = New System.Drawing.Size(308, 46)
        Me.BtncFileLp.TabIndex = 0
        Me.BtncFileLp.Text = "Guardar Correos Depurados"
        Me.BtncFileLp.UseVisualStyleBackColor = True
        '
        'cboSheetBooks
        '
        Me.cboSheetBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cboSheetBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSheetBooks.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSheetBooks.ForeColor = System.Drawing.Color.White
        Me.cboSheetBooks.FormattingEnabled = True
        Me.cboSheetBooks.Location = New System.Drawing.Point(17, 121)
        Me.cboSheetBooks.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSheetBooks.Name = "cboSheetBooks"
        Me.cboSheetBooks.Size = New System.Drawing.Size(268, 24)
        Me.cboSheetBooks.TabIndex = 13
        '
        'BtnExaminar
        '
        Me.BtnExaminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnExaminar.FlatAppearance.BorderSize = 0
        Me.BtnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExaminar.Font = New System.Drawing.Font("Century Gothic", 7.8!)
        Me.BtnExaminar.ForeColor = System.Drawing.Color.White
        Me.BtnExaminar.Image = Global.WAplMsOutlook.My.Resources.Resources.documents_icon_321
        Me.BtnExaminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExaminar.Location = New System.Drawing.Point(32, 14)
        Me.BtnExaminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExaminar.Name = "BtnExaminar"
        Me.BtnExaminar.Size = New System.Drawing.Size(308, 46)
        Me.BtnExaminar.TabIndex = 2
        Me.BtnExaminar.Text = "Seleccionar Archivo"
        Me.BtnExaminar.UseVisualStyleBackColor = False
        '
        'lblHoja
        '
        Me.lblHoja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoja.AutoSize = True
        Me.lblHoja.BackColor = System.Drawing.Color.Transparent
        Me.lblHoja.Location = New System.Drawing.Point(13, 102)
        Me.lblHoja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoja.Name = "lblHoja"
        Me.lblHoja.Size = New System.Drawing.Size(35, 16)
        Me.lblHoja.TabIndex = 12
        Me.lblHoja.Text = "Hoja"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(16, 68)
        Me.txtdireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(324, 22)
        Me.txtdireccion.TabIndex = 1
        '
        'Imgtree
        '
        Me.Imgtree.ImageStream = CType(resources.GetObject("Imgtree.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Imgtree.TransparentColor = System.Drawing.Color.Transparent
        Me.Imgtree.Images.SetKeyName(0, "bullet_go.ico")
        Me.Imgtree.Images.SetKeyName(1, "bullet_delete.ico")
        Me.Imgtree.Images.SetKeyName(2, "email_add.ico")
        Me.Imgtree.Images.SetKeyName(3, "email_delete.ico")
        Me.Imgtree.Images.SetKeyName(4, "email_go.ico")
        Me.Imgtree.Images.SetKeyName(5, "email_edit.png")
        Me.Imgtree.Images.SetKeyName(6, "user_edit.png")
        Me.Imgtree.Images.SetKeyName(7, "email.png")
        Me.Imgtree.Images.SetKeyName(8, "sc_dbclearquery.png")
        Me.Imgtree.Images.SetKeyName(9, "world_link.png")
        Me.Imgtree.Images.SetKeyName(10, "maximize-window-icon-16.png")
        Me.Imgtree.Images.SetKeyName(11, "minimize-window-icon-16.png")
        Me.Imgtree.Images.SetKeyName(12, "restore-window-icon-16.png")
        '
        'txtTituloCorreo
        '
        Me.txtTituloCorreo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTituloCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtTituloCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTituloCorreo.ForeColor = System.Drawing.Color.Silver
        Me.txtTituloCorreo.Location = New System.Drawing.Point(169, 155)
        Me.txtTituloCorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTituloCorreo.Name = "txtTituloCorreo"
        Me.txtTituloCorreo.Size = New System.Drawing.Size(1488, 22)
        Me.txtTituloCorreo.TabIndex = 5
        '
        'lblAsunto
        '
        Me.lblAsunto.AutoSize = True
        Me.lblAsunto.Location = New System.Drawing.Point(18, 159)
        Me.lblAsunto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsunto.Name = "lblAsunto"
        Me.lblAsunto.Size = New System.Drawing.Size(50, 16)
        Me.lblAsunto.TabIndex = 34
        Me.lblAsunto.Text = "Asunto:"
        '
        'RBtn_MS_Exchange
        '
        Me.RBtn_MS_Exchange.AutoSize = True
        Me.RBtn_MS_Exchange.Checked = True
        Me.RBtn_MS_Exchange.Location = New System.Drawing.Point(20, 17)
        Me.RBtn_MS_Exchange.Margin = New System.Windows.Forms.Padding(4)
        Me.RBtn_MS_Exchange.Name = "RBtn_MS_Exchange"
        Me.RBtn_MS_Exchange.Size = New System.Drawing.Size(141, 20)
        Me.RBtn_MS_Exchange.TabIndex = 2
        Me.RBtn_MS_Exchange.TabStop = True
        Me.RBtn_MS_Exchange.Text = "Microsoft Exchange"
        Me.RBtn_MS_Exchange.UseVisualStyleBackColor = True
        '
        'RBtn_Hotmail
        '
        Me.RBtn_Hotmail.AutoSize = True
        Me.RBtn_Hotmail.Location = New System.Drawing.Point(236, 17)
        Me.RBtn_Hotmail.Margin = New System.Windows.Forms.Padding(4)
        Me.RBtn_Hotmail.Name = "RBtn_Hotmail"
        Me.RBtn_Hotmail.Size = New System.Drawing.Size(70, 20)
        Me.RBtn_Hotmail.TabIndex = 36
        Me.RBtn_Hotmail.Text = "Hotmail"
        Me.RBtn_Hotmail.UseVisualStyleBackColor = True
        '
        'RBtnGmail
        '
        Me.RBtnGmail.AutoSize = True
        Me.RBtnGmail.Location = New System.Drawing.Point(168, 17)
        Me.RBtnGmail.Margin = New System.Windows.Forms.Padding(4)
        Me.RBtnGmail.Name = "RBtnGmail"
        Me.RBtnGmail.Size = New System.Drawing.Size(61, 20)
        Me.RBtnGmail.TabIndex = 37
        Me.RBtnGmail.Text = "Gmail"
        Me.RBtnGmail.UseVisualStyleBackColor = True
        '
        'txtURL
        '
        Me.txtURL.BackColor = System.Drawing.Color.White
        Me.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtURL.Location = New System.Drawing.Point(117, 304)
        Me.txtURL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtURL.Multiline = True
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(593, 30)
        Me.txtURL.TabIndex = 6
        '
        'GbImagenes
        '
        Me.GbImagenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GbImagenes.Controls.Add(Me.lblinfoImg)
        Me.GbImagenes.Controls.Add(Me.lblImgFinal)
        Me.GbImagenes.Controls.Add(Me.lblUbicacionImgFinal)
        Me.GbImagenes.Controls.Add(Me.Label2)
        Me.GbImagenes.Controls.Add(Me.lblUbicacionImgInic)
        Me.GbImagenes.Controls.Add(Me.BtnImgFinal)
        Me.GbImagenes.Controls.Add(Me.BtnImgInic)
        Me.GbImagenes.Controls.Add(Me.TxtImgFinal)
        Me.GbImagenes.Controls.Add(Me.txtImgInicio)
        Me.GbImagenes.Controls.Add(Me.chkImgFinal)
        Me.GbImagenes.Controls.Add(Me.ChkImgInicio)
        Me.GbImagenes.Controls.Add(Me.Pic_Final)
        Me.GbImagenes.Controls.Add(Me.Pic_Inicio)
        Me.GbImagenes.ForeColor = System.Drawing.Color.White
        Me.GbImagenes.Location = New System.Drawing.Point(68, 379)
        Me.GbImagenes.Margin = New System.Windows.Forms.Padding(4)
        Me.GbImagenes.Name = "GbImagenes"
        Me.GbImagenes.Padding = New System.Windows.Forms.Padding(4)
        Me.GbImagenes.Size = New System.Drawing.Size(731, 254)
        Me.GbImagenes.TabIndex = 29
        Me.GbImagenes.TabStop = False
        Me.GbImagenes.Text = "Control de Imagenes"
        Me.GbImagenes.Visible = False
        '
        'lblinfoImg
        '
        Me.lblinfoImg.AutoSize = True
        Me.lblinfoImg.Location = New System.Drawing.Point(68, 270)
        Me.lblinfoImg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinfoImg.Name = "lblinfoImg"
        Me.lblinfoImg.Size = New System.Drawing.Size(0, 16)
        Me.lblinfoImg.TabIndex = 12
        '
        'lblImgFinal
        '
        Me.lblImgFinal.AutoSize = True
        Me.lblImgFinal.Location = New System.Drawing.Point(370, 74)
        Me.lblImgFinal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblImgFinal.Name = "lblImgFinal"
        Me.lblImgFinal.Size = New System.Drawing.Size(57, 16)
        Me.lblImgFinal.TabIndex = 11
        Me.lblImgFinal.Text = "Imagen:"
        '
        'lblUbicacionImgFinal
        '
        Me.lblUbicacionImgFinal.AutoSize = True
        Me.lblUbicacionImgFinal.Location = New System.Drawing.Point(370, 48)
        Me.lblUbicacionImgFinal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUbicacionImgFinal.Name = "lblUbicacionImgFinal"
        Me.lblUbicacionImgFinal.Size = New System.Drawing.Size(72, 16)
        Me.lblUbicacionImgFinal.TabIndex = 10
        Me.lblUbicacionImgFinal.Text = "Ubicación:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Imagen:"
        '
        'lblUbicacionImgInic
        '
        Me.lblUbicacionImgInic.AutoSize = True
        Me.lblUbicacionImgInic.Location = New System.Drawing.Point(8, 45)
        Me.lblUbicacionImgInic.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUbicacionImgInic.Name = "lblUbicacionImgInic"
        Me.lblUbicacionImgInic.Size = New System.Drawing.Size(72, 16)
        Me.lblUbicacionImgInic.TabIndex = 8
        Me.lblUbicacionImgInic.Text = "Ubicacion:"
        '
        'BtnImgFinal
        '
        Me.BtnImgFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImgFinal.BackColor = System.Drawing.Color.White
        Me.BtnImgFinal.Enabled = False
        Me.BtnImgFinal.ForeColor = System.Drawing.Color.Black
        Me.BtnImgFinal.Location = New System.Drawing.Point(641, 45)
        Me.BtnImgFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnImgFinal.Name = "BtnImgFinal"
        Me.BtnImgFinal.Size = New System.Drawing.Size(28, 22)
        Me.BtnImgFinal.TabIndex = 7
        Me.BtnImgFinal.Text = "..."
        Me.BtnImgFinal.UseVisualStyleBackColor = False
        '
        'BtnImgInic
        '
        Me.BtnImgInic.BackColor = System.Drawing.Color.White
        Me.BtnImgInic.Enabled = False
        Me.BtnImgInic.ForeColor = System.Drawing.Color.Black
        Me.BtnImgInic.Location = New System.Drawing.Point(273, 45)
        Me.BtnImgInic.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnImgInic.Name = "BtnImgInic"
        Me.BtnImgInic.Size = New System.Drawing.Size(28, 20)
        Me.BtnImgInic.TabIndex = 6
        Me.BtnImgInic.Text = "..."
        Me.BtnImgInic.UseVisualStyleBackColor = False
        '
        'TxtImgFinal
        '
        Me.TxtImgFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtImgFinal.Enabled = False
        Me.TxtImgFinal.Location = New System.Drawing.Point(449, 45)
        Me.TxtImgFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtImgFinal.Name = "TxtImgFinal"
        Me.TxtImgFinal.Size = New System.Drawing.Size(184, 22)
        Me.TxtImgFinal.TabIndex = 5
        '
        'txtImgInicio
        '
        Me.txtImgInicio.Enabled = False
        Me.txtImgInicio.Location = New System.Drawing.Point(95, 45)
        Me.txtImgInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImgInicio.Name = "txtImgInicio"
        Me.txtImgInicio.Size = New System.Drawing.Size(170, 22)
        Me.txtImgInicio.TabIndex = 4
        '
        'chkImgFinal
        '
        Me.chkImgFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkImgFinal.AutoSize = True
        Me.chkImgFinal.Location = New System.Drawing.Point(372, 17)
        Me.chkImgFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.chkImgFinal.Name = "chkImgFinal"
        Me.chkImgFinal.Size = New System.Drawing.Size(207, 20)
        Me.chkImgFinal.TabIndex = 3
        Me.chkImgFinal.Text = "Imagen al final del Documento"
        Me.chkImgFinal.UseVisualStyleBackColor = True
        '
        'ChkImgInicio
        '
        Me.ChkImgInicio.AutoSize = True
        Me.ChkImgInicio.Location = New System.Drawing.Point(11, 21)
        Me.ChkImgInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkImgInicio.Name = "ChkImgInicio"
        Me.ChkImgInicio.Size = New System.Drawing.Size(216, 20)
        Me.ChkImgInicio.TabIndex = 2
        Me.ChkImgInicio.Text = "Imagen al Inicio del documento"
        Me.ChkImgInicio.UseVisualStyleBackColor = True
        '
        'Pic_Final
        '
        Me.Pic_Final.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic_Final.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pic_Final.Enabled = False
        Me.Pic_Final.Location = New System.Drawing.Point(449, 74)
        Me.Pic_Final.Margin = New System.Windows.Forms.Padding(4)
        Me.Pic_Final.Name = "Pic_Final"
        Me.Pic_Final.Size = New System.Drawing.Size(220, 159)
        Me.Pic_Final.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Final.TabIndex = 1
        Me.Pic_Final.TabStop = False
        '
        'Pic_Inicio
        '
        Me.Pic_Inicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pic_Inicio.Enabled = False
        Me.Pic_Inicio.Location = New System.Drawing.Point(95, 77)
        Me.Pic_Inicio.Margin = New System.Windows.Forms.Padding(4)
        Me.Pic_Inicio.Name = "Pic_Inicio"
        Me.Pic_Inicio.Size = New System.Drawing.Size(208, 156)
        Me.Pic_Inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Inicio.TabIndex = 0
        Me.Pic_Inicio.TabStop = False
        '
        'WebBrowserEmail
        '
        Me.WebBrowserEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowserEmail.Location = New System.Drawing.Point(7, 357)
        Me.WebBrowserEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.WebBrowserEmail.MinimumSize = New System.Drawing.Size(23, 25)
        Me.WebBrowserEmail.Name = "WebBrowserEmail"
        Me.WebBrowserEmail.Size = New System.Drawing.Size(1658, 549)
        Me.WebBrowserEmail.TabIndex = 27
        '
        'GbFormato
        '
        Me.GbFormato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbFormato.Controls.Add(Me.IconBtnInsertLine)
        Me.GbFormato.Controls.Add(Me.IconBtnAddLink)
        Me.GbFormato.Controls.Add(Me.BtnJustifyFull)
        Me.GbFormato.Controls.Add(Me.BtnJustifyCenter)
        Me.GbFormato.Controls.Add(Me.lstFont)
        Me.GbFormato.Controls.Add(Me.BtnJustifyLeft)
        Me.GbFormato.Controls.Add(Me.lstSize)
        Me.GbFormato.Controls.Add(Me.btnP)
        Me.GbFormato.Controls.Add(Me.BtnRemoteFormat)
        Me.GbFormato.Controls.Add(Me.BtnJustifyRight)
        Me.GbFormato.Controls.Add(Me.btnB)
        Me.GbFormato.Controls.Add(Me.BtnBackColor)
        Me.GbFormato.Controls.Add(Me.btnI)
        Me.GbFormato.Controls.Add(Me.btnC)
        Me.GbFormato.Controls.Add(Me.btnU)
        Me.GbFormato.Controls.Add(Me.Btn_InicEditor)
        Me.GbFormato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GbFormato.ForeColor = System.Drawing.Color.White
        Me.GbFormato.Location = New System.Drawing.Point(9, 240)
        Me.GbFormato.Margin = New System.Windows.Forms.Padding(4)
        Me.GbFormato.Name = "GbFormato"
        Me.GbFormato.Padding = New System.Windows.Forms.Padding(4)
        Me.GbFormato.Size = New System.Drawing.Size(1656, 50)
        Me.GbFormato.TabIndex = 70
        Me.GbFormato.TabStop = False
        Me.GbFormato.Text = "Formato"
        '
        'BtnJustifyFull
        '
        Me.BtnJustifyFull.FlatAppearance.BorderSize = 0
        Me.BtnJustifyFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJustifyFull.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJustifyFull.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnJustifyFull.Image = Global.WAplMsOutlook.My.Resources.Resources.sc_justifypara
        Me.BtnJustifyFull.Location = New System.Drawing.Point(534, 12)
        Me.BtnJustifyFull.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnJustifyFull.Name = "BtnJustifyFull"
        Me.BtnJustifyFull.Size = New System.Drawing.Size(40, 28)
        Me.BtnJustifyFull.TabIndex = 65
        '
        'BtnJustifyCenter
        '
        Me.BtnJustifyCenter.FlatAppearance.BorderSize = 0
        Me.BtnJustifyCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJustifyCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJustifyCenter.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnJustifyCenter.Image = Global.WAplMsOutlook.My.Resources.Resources.sc_centerpara
        Me.BtnJustifyCenter.Location = New System.Drawing.Point(580, 12)
        Me.BtnJustifyCenter.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnJustifyCenter.Name = "BtnJustifyCenter"
        Me.BtnJustifyCenter.Size = New System.Drawing.Size(40, 28)
        Me.BtnJustifyCenter.TabIndex = 66
        '
        'lstFont
        '
        Me.lstFont.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lstFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lstFont.ForeColor = System.Drawing.Color.White
        Me.lstFont.Location = New System.Drawing.Point(7, 15)
        Me.lstFont.Margin = New System.Windows.Forms.Padding(4)
        Me.lstFont.Name = "lstFont"
        Me.lstFont.Size = New System.Drawing.Size(158, 24)
        Me.lstFont.TabIndex = 48
        '
        'BtnJustifyLeft
        '
        Me.BtnJustifyLeft.FlatAppearance.BorderSize = 0
        Me.BtnJustifyLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJustifyLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJustifyLeft.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnJustifyLeft.Image = Global.WAplMsOutlook.My.Resources.Resources.sc_leftpara
        Me.BtnJustifyLeft.Location = New System.Drawing.Point(626, 12)
        Me.BtnJustifyLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnJustifyLeft.Name = "BtnJustifyLeft"
        Me.BtnJustifyLeft.Size = New System.Drawing.Size(40, 28)
        Me.BtnJustifyLeft.TabIndex = 67
        '
        'lstSize
        '
        Me.lstSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lstSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lstSize.ForeColor = System.Drawing.Color.White
        Me.lstSize.Location = New System.Drawing.Point(173, 15)
        Me.lstSize.Margin = New System.Windows.Forms.Padding(4)
        Me.lstSize.Name = "lstSize"
        Me.lstSize.Size = New System.Drawing.Size(87, 24)
        Me.lstSize.TabIndex = 49
        '
        'btnP
        '
        Me.btnP.FlatAppearance.BorderSize = 0
        Me.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP.Image = Global.WAplMsOutlook.My.Resources.Resources.sc_grafmode
        Me.btnP.Location = New System.Drawing.Point(488, 12)
        Me.btnP.Margin = New System.Windows.Forms.Padding(4)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(40, 28)
        Me.btnP.TabIndex = 54
        '
        'BtnRemoteFormat
        '
        Me.BtnRemoteFormat.FlatAppearance.BorderSize = 0
        Me.BtnRemoteFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemoteFormat.Image = Global.WAplMsOutlook.My.Resources.Resources.sx03163
        Me.BtnRemoteFormat.Location = New System.Drawing.Point(720, 12)
        Me.BtnRemoteFormat.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRemoteFormat.Name = "BtnRemoteFormat"
        Me.BtnRemoteFormat.Size = New System.Drawing.Size(37, 28)
        Me.BtnRemoteFormat.TabIndex = 13
        Me.BtnRemoteFormat.UseVisualStyleBackColor = True
        '
        'BtnJustifyRight
        '
        Me.BtnJustifyRight.FlatAppearance.BorderSize = 0
        Me.BtnJustifyRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJustifyRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJustifyRight.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnJustifyRight.Image = Global.WAplMsOutlook.My.Resources.Resources.sc_rightpara
        Me.BtnJustifyRight.Location = New System.Drawing.Point(673, 12)
        Me.BtnJustifyRight.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnJustifyRight.Name = "BtnJustifyRight"
        Me.BtnJustifyRight.Size = New System.Drawing.Size(40, 28)
        Me.BtnJustifyRight.TabIndex = 68
        '
        'btnB
        '
        Me.btnB.FlatAppearance.BorderSize = 0
        Me.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB.Location = New System.Drawing.Point(268, 12)
        Me.btnB.Margin = New System.Windows.Forms.Padding(4)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(37, 28)
        Me.btnB.TabIndex = 50
        Me.btnB.Text = "N"
        '
        'BtnBackColor
        '
        Me.BtnBackColor.FlatAppearance.BorderSize = 0
        Me.BtnBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBackColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBackColor.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnBackColor.Image = Global.WAplMsOutlook.My.Resources.Resources.sc_backcolor
        Me.BtnBackColor.Location = New System.Drawing.Point(443, 12)
        Me.BtnBackColor.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBackColor.Name = "BtnBackColor"
        Me.BtnBackColor.Size = New System.Drawing.Size(37, 28)
        Me.BtnBackColor.TabIndex = 64
        '
        'btnI
        '
        Me.btnI.FlatAppearance.BorderSize = 0
        Me.btnI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnI.Location = New System.Drawing.Point(310, 12)
        Me.btnI.Margin = New System.Windows.Forms.Padding(4)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(37, 28)
        Me.btnI.TabIndex = 51
        Me.btnI.Text = "K"
        '
        'btnC
        '
        Me.btnC.FlatAppearance.BorderSize = 0
        Me.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.ForeColor = System.Drawing.Color.Red
        Me.btnC.Image = Global.WAplMsOutlook.My.Resources.Resources.sc_fontcolor
        Me.btnC.Location = New System.Drawing.Point(399, 12)
        Me.btnC.Margin = New System.Windows.Forms.Padding(4)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(37, 28)
        Me.btnC.TabIndex = 53
        '
        'btnU
        '
        Me.btnU.FlatAppearance.BorderSize = 0
        Me.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnU.Location = New System.Drawing.Point(355, 12)
        Me.btnU.Margin = New System.Windows.Forms.Padding(4)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(37, 28)
        Me.btnU.TabIndex = 52
        Me.btnU.Text = "S"
        '
        'Btn_InicEditor
        '
        Me.Btn_InicEditor.FlatAppearance.BorderSize = 0
        Me.Btn_InicEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_InicEditor.Image = Global.WAplMsOutlook.My.Resources.Resources.cross_out__2_
        Me.Btn_InicEditor.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_InicEditor.Location = New System.Drawing.Point(1046, 12)
        Me.Btn_InicEditor.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_InicEditor.Name = "Btn_InicEditor"
        Me.Btn_InicEditor.Size = New System.Drawing.Size(124, 28)
        Me.Btn_InicEditor.TabIndex = 61
        Me.Btn_InicEditor.Text = "Iniciar Editor"
        Me.Btn_InicEditor.UseVisualStyleBackColor = True
        '
        'GbAbrir
        '
        Me.GbAbrir.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.GbAbrir.Controls.Add(Me.rBtn_Word)
        Me.GbAbrir.Controls.Add(Me.rBtn_HTML)
        Me.GbAbrir.Location = New System.Drawing.Point(1055, 7)
        Me.GbAbrir.Margin = New System.Windows.Forms.Padding(4)
        Me.GbAbrir.Name = "GbAbrir"
        Me.GbAbrir.Padding = New System.Windows.Forms.Padding(4)
        Me.GbAbrir.Size = New System.Drawing.Size(117, 76)
        Me.GbAbrir.TabIndex = 13
        Me.GbAbrir.TabStop = False
        Me.GbAbrir.Text = "Abrir Archivos"
        Me.GbAbrir.Visible = False
        '
        'rBtn_Word
        '
        Me.rBtn_Word.AutoSize = True
        Me.rBtn_Word.Location = New System.Drawing.Point(21, 47)
        Me.rBtn_Word.Margin = New System.Windows.Forms.Padding(4)
        Me.rBtn_Word.Name = "rBtn_Word"
        Me.rBtn_Word.Size = New System.Drawing.Size(77, 20)
        Me.rBtn_Word.TabIndex = 1
        Me.rBtn_Word.Text = "MS Word"
        Me.rBtn_Word.UseVisualStyleBackColor = True
        '
        'rBtn_HTML
        '
        Me.rBtn_HTML.AutoSize = True
        Me.rBtn_HTML.Checked = True
        Me.rBtn_HTML.Location = New System.Drawing.Point(21, 19)
        Me.rBtn_HTML.Margin = New System.Windows.Forms.Padding(4)
        Me.rBtn_HTML.Name = "rBtn_HTML"
        Me.rBtn_HTML.Size = New System.Drawing.Size(56, 20)
        Me.rBtn_HTML.TabIndex = 0
        Me.rBtn_HTML.TabStop = True
        Me.rBtn_HTML.Text = "HTML"
        Me.rBtn_HTML.UseVisualStyleBackColor = True
        '
        'txtConocidoComo
        '
        Me.txtConocidoComo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConocidoComo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtConocidoComo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConocidoComo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConocidoComo.ForeColor = System.Drawing.Color.Silver
        Me.txtConocidoComo.Location = New System.Drawing.Point(169, 53)
        Me.txtConocidoComo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConocidoComo.Name = "txtConocidoComo"
        Me.txtConocidoComo.Size = New System.Drawing.Size(1488, 23)
        Me.txtConocidoComo.TabIndex = 42
        '
        'txtContrasena
        '
        Me.txtContrasena.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContrasena.ForeColor = System.Drawing.Color.Silver
        Me.txtContrasena.Location = New System.Drawing.Point(169, 118)
        Me.txtContrasena.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(1488, 22)
        Me.txtContrasena.TabIndex = 39
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Location = New System.Drawing.Point(17, 119)
        Me.lblClave.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(78, 16)
        Me.lblClave.TabIndex = 41
        Me.lblClave.Text = "Contraseña:"
        '
        'txtCorreoEnvia
        '
        Me.txtCorreoEnvia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorreoEnvia.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtCorreoEnvia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorreoEnvia.ForeColor = System.Drawing.Color.Silver
        Me.txtCorreoEnvia.Location = New System.Drawing.Point(169, 84)
        Me.txtCorreoEnvia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCorreoEnvia.Name = "txtCorreoEnvia"
        Me.txtCorreoEnvia.Size = New System.Drawing.Size(1488, 22)
        Me.txtCorreoEnvia.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 54)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Conocido como:"
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Location = New System.Drawing.Point(17, 85)
        Me.lblDe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(51, 16)
        Me.lblDe.TabIndex = 40
        Me.lblDe.Text = "Usuario"
        '
        'lblAdjuntos
        '
        Me.lblAdjuntos.AutoSize = True
        Me.lblAdjuntos.Location = New System.Drawing.Point(18, 190)
        Me.lblAdjuntos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdjuntos.Name = "lblAdjuntos"
        Me.lblAdjuntos.Size = New System.Drawing.Size(61, 16)
        Me.lblAdjuntos.TabIndex = 59
        Me.lblAdjuntos.Text = "Adjuntos:"
        '
        'ChkAddImg
        '
        Me.ChkAddImg.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.ChkAddImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ChkAddImg.Location = New System.Drawing.Point(984, 298)
        Me.ChkAddImg.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkAddImg.Name = "ChkAddImg"
        Me.ChkAddImg.Size = New System.Drawing.Size(220, 46)
        Me.ChkAddImg.TabIndex = 40
        Me.ChkAddImg.Text = "Agregar imagen al Inicio o al Final del  documento."
        Me.ChkAddImg.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ChkAddImg.UseVisualStyleBackColor = True
        Me.ChkAddImg.Visible = False
        '
        'textAttachments
        '
        Me.textAttachments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textAttachments.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.textAttachments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textAttachments.ForeColor = System.Drawing.Color.Silver
        Me.textAttachments.Location = New System.Drawing.Point(168, 186)
        Me.textAttachments.Margin = New System.Windows.Forms.Padding(4)
        Me.textAttachments.Multiline = True
        Me.textAttachments.Name = "textAttachments"
        Me.textAttachments.ReadOnly = True
        Me.textAttachments.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textAttachments.Size = New System.Drawing.Size(1373, 48)
        Me.textAttachments.TabIndex = 57
        '
        'Status
        '
        Me.Status.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Status.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblProgres, Me.Pb, Me.lblCargados, Me.lblCorreosCargados, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.lblCorreosDuplicados, Me.ToolStripStatusLabel3, Me.lblCorreosInvalidos, Me.ToolStripStatusLabel4, Me.lblEnviados, Me.ToolStripStatusLabel5, Me.lblCorreo, Me.ToolStripStatusLabel6, Me.lblTime})
        Me.Status.Location = New System.Drawing.Point(0, 716)
        Me.Status.Name = "Status"
        Me.Status.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.Status.Size = New System.Drawing.Size(1203, 29)
        Me.Status.TabIndex = 33
        Me.Status.Text = "StatusStrip1"
        '
        'lblProgres
        '
        Me.lblProgres.ActiveLinkColor = System.Drawing.Color.White
        Me.lblProgres.Image = Global.WAplMsOutlook.My.Resources.Resources.producto
        Me.lblProgres.Name = "lblProgres"
        Me.lblProgres.Size = New System.Drawing.Size(104, 24)
        Me.lblProgres.Text = "Procesando: ..."
        '
        'Pb
        '
        Me.Pb.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Pb.Name = "Pb"
        Me.Pb.Size = New System.Drawing.Size(175, 23)
        Me.Pb.Step = 2
        Me.Pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'lblCargados
        '
        Me.lblCargados.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCargados.Name = "lblCargados"
        Me.lblCargados.Size = New System.Drawing.Size(60, 24)
        Me.lblCargados.Text = "Cargados:"
        '
        'lblCorreosCargados
        '
        Me.lblCorreosCargados.Name = "lblCorreosCargados"
        Me.lblCorreosCargados.Size = New System.Drawing.Size(13, 24)
        Me.lblCorreosCargados.Text = "0"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 24)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(70, 24)
        Me.ToolStripStatusLabel2.Text = "Duplicados:"
        '
        'lblCorreosDuplicados
        '
        Me.lblCorreosDuplicados.Name = "lblCorreosDuplicados"
        Me.lblCorreosDuplicados.Size = New System.Drawing.Size(13, 24)
        Me.lblCorreosDuplicados.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(56, 24)
        Me.ToolStripStatusLabel3.Text = "Inválidos"
        '
        'lblCorreosInvalidos
        '
        Me.lblCorreosInvalidos.Name = "lblCorreosInvalidos"
        Me.lblCorreosInvalidos.Size = New System.Drawing.Size(13, 24)
        Me.lblCorreosInvalidos.Text = "0"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(58, 24)
        Me.ToolStripStatusLabel4.Text = "Enviados:"
        '
        'lblEnviados
        '
        Me.lblEnviados.Name = "lblEnviados"
        Me.lblEnviados.Size = New System.Drawing.Size(13, 24)
        Me.lblEnviados.Text = "0"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(48, 24)
        Me.ToolStripStatusLabel5.Text = "Correo:"
        '
        'lblCorreo
        '
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(129, 24)
        Me.lblCorreo.Text = "muestra@hotmail.com"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(49, 24)
        Me.ToolStripStatusLabel6.Text = "Tiempo"
        Me.ToolStripStatusLabel6.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(383, 24)
        Me.lblTime.Spring = True
        Me.lblTime.Text = "00:00"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'T
        '
        Me.T.Interval = 1000
        '
        'TTCorreos
        '
        Me.TTCorreos.ToolTipTitle = "Información Importante:"
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.BarraTitulo.Controls.Add(Me.iconToolbar)
        Me.BarraTitulo.Controls.Add(Me.lblTituloSistema)
        Me.BarraTitulo.Controls.Add(Me.Restaurar)
        Me.BarraTitulo.Controls.Add(Me.Minimizar)
        Me.BarraTitulo.Controls.Add(Me.Maximizar)
        Me.BarraTitulo.Controls.Add(Me.Cerrar)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Font = New System.Drawing.Font("Century Gothic", 7.8!)
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1203, 33)
        Me.BarraTitulo.TabIndex = 72
        '
        'lblTituloSistema
        '
        Me.lblTituloSistema.AutoSize = True
        Me.lblTituloSistema.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloSistema.ForeColor = System.Drawing.Color.White
        Me.lblTituloSistema.Location = New System.Drawing.Point(37, 11)
        Me.lblTituloSistema.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTituloSistema.Name = "lblTituloSistema"
        Me.lblTituloSistema.Size = New System.Drawing.Size(212, 16)
        Me.lblTituloSistema.TabIndex = 22
        Me.lblTituloSistema.Text = "Mail Delivery Robot System by HGC"
        '
        'Restaurar
        '
        Me.Restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Restaurar.BackColor = System.Drawing.Color.Transparent
        Me.Restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Restaurar.Image = Global.WAplMsOutlook.My.Resources.Resources.restore_window_icon_16
        Me.Restaurar.Location = New System.Drawing.Point(1138, 2)
        Me.Restaurar.Margin = New System.Windows.Forms.Padding(2)
        Me.Restaurar.Name = "Restaurar"
        Me.Restaurar.Size = New System.Drawing.Size(30, 30)
        Me.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Restaurar.TabIndex = 21
        Me.Restaurar.TabStop = False
        Me.Restaurar.Visible = False
        '
        'Minimizar
        '
        Me.Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimizar.BackColor = System.Drawing.Color.Transparent
        Me.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Minimizar.Image = Global.WAplMsOutlook.My.Resources.Resources.minimize_window_icon_16
        Me.Minimizar.InitialImage = CType(resources.GetObject("Minimizar.InitialImage"), System.Drawing.Image)
        Me.Minimizar.Location = New System.Drawing.Point(1104, 1)
        Me.Minimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.Minimizar.Name = "Minimizar"
        Me.Minimizar.Size = New System.Drawing.Size(30, 30)
        Me.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Minimizar.TabIndex = 20
        Me.Minimizar.TabStop = False
        '
        'Maximizar
        '
        Me.Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Maximizar.BackColor = System.Drawing.Color.Transparent
        Me.Maximizar.Image = Global.WAplMsOutlook.My.Resources.Resources.maximize_window_icon_16
        Me.Maximizar.Location = New System.Drawing.Point(1138, 2)
        Me.Maximizar.Margin = New System.Windows.Forms.Padding(2)
        Me.Maximizar.Name = "Maximizar"
        Me.Maximizar.Size = New System.Drawing.Size(30, 30)
        Me.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Maximizar.TabIndex = 19
        Me.Maximizar.TabStop = False
        '
        'Cerrar
        '
        Me.Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cerrar.Image = Global.WAplMsOutlook.My.Resources.Resources.close_window_icon_16
        Me.Cerrar.Location = New System.Drawing.Point(1170, 2)
        Me.Cerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(30, 30)
        Me.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cerrar.TabIndex = 18
        Me.Cerrar.TabStop = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 33)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1203, 683)
        Me.TabControl2.TabIndex = 73
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Black
        Me.TabPage2.Controls.Add(Me.Panel_Izquierda)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1195, 654)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Cargar correos"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.IconBtnOpenURL)
        Me.TabPage4.Controls.Add(Me.IconBtnSendMail)
        Me.TabPage4.Controls.Add(Me.IconBtnSave)
        Me.TabPage4.Controls.Add(Me.IconBtnClearAttachment)
        Me.TabPage4.Controls.Add(Me.IconBtnNew)
        Me.TabPage4.Controls.Add(Me.IconBtnFolderOpen)
        Me.TabPage4.Controls.Add(Me.IconBtnAttachment)
        Me.TabPage4.Controls.Add(Me.IconBtnIr)
        Me.TabPage4.Controls.Add(Me.IconBtnRigth)
        Me.TabPage4.Controls.Add(Me.IconBtnLeft)
        Me.TabPage4.Controls.Add(Me.GbImagenes)
        Me.TabPage4.Controls.Add(Me.WebBrowserEmail)
        Me.TabPage4.Controls.Add(Me.GbFormato)
        Me.TabPage4.Controls.Add(Me.BtnOpenUrl)
        Me.TabPage4.Controls.Add(Me.Btn_Adelante)
        Me.TabPage4.Controls.Add(Me.BtnIr)
        Me.TabPage4.Controls.Add(Me.Btn_Atras)
        Me.TabPage4.Controls.Add(Me.txtURL)
        Me.TabPage4.Controls.Add(Me.RBtn_MS_Exchange)
        Me.TabPage4.Controls.Add(Me.RBtn_Hotmail)
        Me.TabPage4.Controls.Add(Me.RBtnGmail)
        Me.TabPage4.Controls.Add(Me.txtTituloCorreo)
        Me.TabPage4.Controls.Add(Me.lblAsunto)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.txtConocidoComo)
        Me.TabPage4.Controls.Add(Me.ChkAddImg)
        Me.TabPage4.Controls.Add(Me.txtContrasena)
        Me.TabPage4.Controls.Add(Me.lblDe)
        Me.TabPage4.Controls.Add(Me.lblClave)
        Me.TabPage4.Controls.Add(Me.txtCorreoEnvia)
        Me.TabPage4.Controls.Add(Me.lblAdjuntos)
        Me.TabPage4.Controls.Add(Me.textAttachments)
        Me.TabPage4.Controls.Add(Me.GbAbrir)
        Me.TabPage4.ForeColor = System.Drawing.Color.Transparent
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1195, 654)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Mensajes"
        '
        'BtnOpenUrl
        '
        Me.BtnOpenUrl.Image = Global.WAplMsOutlook.My.Resources.Resources.sc_zoomnext
        Me.BtnOpenUrl.Location = New System.Drawing.Point(833, 306)
        Me.BtnOpenUrl.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnOpenUrl.Name = "BtnOpenUrl"
        Me.BtnOpenUrl.Size = New System.Drawing.Size(37, 28)
        Me.BtnOpenUrl.TabIndex = 29
        Me.BtnOpenUrl.UseVisualStyleBackColor = True
        Me.BtnOpenUrl.Visible = False
        '
        'Btn_Adelante
        '
        Me.Btn_Adelante.Image = Global.WAplMsOutlook.My.Resources.Resources.sc06300
        Me.Btn_Adelante.Location = New System.Drawing.Point(930, 306)
        Me.Btn_Adelante.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Adelante.Name = "Btn_Adelante"
        Me.Btn_Adelante.Size = New System.Drawing.Size(44, 28)
        Me.Btn_Adelante.TabIndex = 63
        Me.Btn_Adelante.UseVisualStyleBackColor = True
        Me.Btn_Adelante.Visible = False
        '
        'BtnIr
        '
        Me.BtnIr.Image = Global.WAplMsOutlook.My.Resources.Resources.reload
        Me.BtnIr.Location = New System.Drawing.Point(788, 306)
        Me.BtnIr.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnIr.Name = "BtnIr"
        Me.BtnIr.Size = New System.Drawing.Size(37, 28)
        Me.BtnIr.TabIndex = 39
        Me.BtnIr.UseVisualStyleBackColor = True
        Me.BtnIr.Visible = False
        '
        'Btn_Atras
        '
        Me.Btn_Atras.Image = Global.WAplMsOutlook.My.Resources.Resources.sc06301
        Me.Btn_Atras.Location = New System.Drawing.Point(878, 306)
        Me.Btn_Atras.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Atras.Name = "Btn_Atras"
        Me.Btn_Atras.Size = New System.Drawing.Size(44, 28)
        Me.Btn_Atras.TabIndex = 62
        Me.Btn_Atras.UseVisualStyleBackColor = True
        Me.Btn_Atras.Visible = False
        '
        'IconBtnLoadMails
        '
        Me.IconBtnLoadMails.ActiveColor = System.Drawing.Color.IndianRed
        Me.IconBtnLoadMails.BackColor = System.Drawing.Color.Transparent
        Me.IconBtnLoadMails.IconType = FontAwesomeIcons.IconType.Check
        Me.IconBtnLoadMails.InActiveColor = System.Drawing.Color.White
        Me.IconBtnLoadMails.Location = New System.Drawing.Point(291, 118)
        Me.IconBtnLoadMails.Name = "IconBtnLoadMails"
        Me.IconBtnLoadMails.Size = New System.Drawing.Size(29, 28)
        Me.IconBtnLoadMails.TabIndex = 15
        Me.IconBtnLoadMails.TabStop = False
        Me.IconBtnLoadMails.ToolTipText = Nothing
        '
        'IconBtnOpenURL
        '
        Me.IconBtnOpenURL.ActiveColor = System.Drawing.Color.IndianRed
        Me.IconBtnOpenURL.BackColor = System.Drawing.Color.Transparent
        Me.IconBtnOpenURL.IconType = FontAwesomeIcons.IconType.FolderOpen
        Me.IconBtnOpenURL.InActiveColor = System.Drawing.Color.White
        Me.IconBtnOpenURL.Location = New System.Drawing.Point(769, 297)
        Me.IconBtnOpenURL.Name = "IconBtnOpenURL"
        Me.IconBtnOpenURL.Size = New System.Drawing.Size(41, 42)
        Me.IconBtnOpenURL.TabIndex = 81
        Me.IconBtnOpenURL.TabStop = False
        Me.IconBtnOpenURL.ToolTipText = Nothing
        '
        'IconBtnSendMail
        '
        Me.IconBtnSendMail.ActiveColor = System.Drawing.Color.IndianRed
        Me.IconBtnSendMail.BackColor = System.Drawing.Color.Transparent
        Me.IconBtnSendMail.IconType = FontAwesomeIcons.IconType.Send
        Me.IconBtnSendMail.InActiveColor = System.Drawing.Color.White
        Me.IconBtnSendMail.Location = New System.Drawing.Point(477, 7)
        Me.IconBtnSendMail.Name = "IconBtnSendMail"
        Me.IconBtnSendMail.Size = New System.Drawing.Size(54, 41)
        Me.IconBtnSendMail.TabIndex = 80
        Me.IconBtnSendMail.TabStop = False
        Me.IconBtnSendMail.ToolTipText = Nothing
        '
        'IconBtnSave
        '
        Me.IconBtnSave.ActiveColor = System.Drawing.Color.IndianRed
        Me.IconBtnSave.BackColor = System.Drawing.Color.Transparent
        Me.IconBtnSave.IconType = FontAwesomeIcons.IconType.FloppyO
        Me.IconBtnSave.InActiveColor = System.Drawing.Color.White
        Me.IconBtnSave.Location = New System.Drawing.Point(424, 6)
        Me.IconBtnSave.Name = "IconBtnSave"
        Me.IconBtnSave.Size = New System.Drawing.Size(45, 42)
        Me.IconBtnSave.TabIndex = 79
        Me.IconBtnSave.TabStop = False
        Me.IconBtnSave.ToolTipText = Nothing
        '
        'IconBtnClearAttachment
        '
        Me.IconBtnClearAttachment.ActiveColor = System.Drawing.Color.IndianRed
        Me.IconBtnClearAttachment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconBtnClearAttachment.BackColor = System.Drawing.Color.Transparent
        Me.IconBtnClearAttachment.IconType = FontAwesomeIcons.IconType.TrashO
        Me.IconBtnClearAttachment.InActiveColor = System.Drawing.Color.White
        Me.IconBtnClearAttachment.Location = New System.Drawing.Point(1603, 185)
        Me.IconBtnClearAttachment.Name = "IconBtnClearAttachment"
        Me.IconBtnClearAttachment.Size = New System.Drawing.Size(54, 48)
        Me.IconBtnClearAttachment.TabIndex = 76
        Me.IconBtnClearAttachment.TabStop = False
        Me.IconBtnClearAttachment.ToolTipText = Nothing
        '
        'IconBtnNew
        '
        Me.IconBtnNew.ActiveColor = System.Drawing.Color.IndianRed
        Me.IconBtnNew.BackColor = System.Drawing.Color.Transparent
        Me.IconBtnNew.IconType = FontAwesomeIcons.IconType.FileO
        Me.IconBtnNew.InActiveColor = System.Drawing.Color.White
        Me.IconBtnNew.Location = New System.Drawing.Point(375, 6)
        Me.IconBtnNew.Name = "IconBtnNew"
        Me.IconBtnNew.Size = New System.Drawing.Size(43, 42)
        Me.IconBtnNew.TabIndex = 78
        Me.IconBtnNew.TabStop = False
        Me.IconBtnNew.ToolTipText = Nothing
        '
        'IconBtnFolderOpen
        '
        Me.IconBtnFolderOpen.ActiveColor = System.Drawing.Color.IndianRed
        Me.IconBtnFolderOpen.BackColor = System.Drawing.Color.Transparent
        Me.IconBtnFolderOpen.IconType = FontAwesomeIcons.IconType.FolderOpen
        Me.IconBtnFolderOpen.InActiveColor = System.Drawing.Color.White
        Me.IconBtnFolderOpen.Location = New System.Drawing.Point(328, 6)
        Me.IconBtnFolderOpen.Name = "IconBtnFolderOpen"
        Me.IconBtnFolderOpen.Size = New System.Drawing.Size(41, 42)
        Me.IconBtnFolderOpen.TabIndex = 77
        Me.IconBtnFolderOpen.TabStop = False
        Me.IconBtnFolderOpen.ToolTipText = Nothing
        '
        'IconBtnAttachment
        '
        Me.IconBtnAttachment.ActiveColor = System.Drawing.Color.IndianRed
        Me.IconBtnAttachment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconBtnAttachment.BackColor = System.Drawing.Color.Transparent
        Me.IconBtnAttachment.IconType = FontAwesomeIcons.IconType.Paperclip
        Me.IconBtnAttachment.InActiveColor = System.Drawing.Color.White
        Me.IconBtnAttachment.Location = New System.Drawing.Point(1548, 186)
        Me.IconBtnAttachment.Name = "IconBtnAttachment"
        Me.IconBtnAttachment.Size = New System.Drawing.Size(49, 47)
        Me.IconBtnAttachment.TabIndex = 75
        Me.IconBtnAttachment.TabStop = False
        Me.IconBtnAttachment.ToolTipText = Nothing
        '
        'IconBtnIr
        '
        Me.IconBtnIr.ActiveColor = System.Drawing.Color.IndianRed
        Me.IconBtnIr.BackColor = System.Drawing.Color.Transparent
        Me.IconBtnIr.IconType = FontAwesomeIcons.IconType.History
        Me.IconBtnIr.InActiveColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IconBtnIr.Location = New System.Drawing.Point(717, 297)
        Me.IconBtnIr.Name = "IconBtnIr"
        Me.IconBtnIr.Size = New System.Drawing.Size(49, 43)
        Me.IconBtnIr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IconBtnIr.TabIndex = 73
        Me.IconBtnIr.TabStop = False
        Me.IconBtnIr.ToolTipText = Nothing
        '
        'IconBtnRigth
        '
        Me.IconBtnRigth.ActiveColor = System.Drawing.Color.IndianRed
        Me.IconBtnRigth.BackColor = System.Drawing.Color.Transparent
        Me.IconBtnRigth.IconType = FontAwesomeIcons.IconType.ArrowCircleRight
        Me.IconBtnRigth.InActiveColor = System.Drawing.Color.White
        Me.IconBtnRigth.Location = New System.Drawing.Point(63, 297)
        Me.IconBtnRigth.Name = "IconBtnRigth"
        Me.IconBtnRigth.Size = New System.Drawing.Size(47, 43)
        Me.IconBtnRigth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IconBtnRigth.TabIndex = 72
        Me.IconBtnRigth.TabStop = False
        Me.IconBtnRigth.ToolTipText = Nothing
        '
        'IconBtnLeft
        '
        Me.IconBtnLeft.ActiveColor = System.Drawing.Color.IndianRed
        Me.IconBtnLeft.BackColor = System.Drawing.Color.Transparent
        Me.IconBtnLeft.IconType = FontAwesomeIcons.IconType.ArrowCircleLeft
        Me.IconBtnLeft.InActiveColor = System.Drawing.Color.White
        Me.IconBtnLeft.Location = New System.Drawing.Point(16, 297)
        Me.IconBtnLeft.Name = "IconBtnLeft"
        Me.IconBtnLeft.Size = New System.Drawing.Size(48, 43)
        Me.IconBtnLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.IconBtnLeft.TabIndex = 71
        Me.IconBtnLeft.TabStop = False
        Me.IconBtnLeft.ToolTipText = Nothing
        '
        'IconBtnInsertLine
        '
        Me.IconBtnInsertLine.ActiveColor = System.Drawing.Color.LightCoral
        Me.IconBtnInsertLine.BackColor = System.Drawing.Color.Transparent
        Me.IconBtnInsertLine.IconType = FontAwesomeIcons.IconType.Minus
        Me.IconBtnInsertLine.InActiveColor = System.Drawing.Color.White
        Me.IconBtnInsertLine.Location = New System.Drawing.Point(796, 13)
        Me.IconBtnInsertLine.Name = "IconBtnInsertLine"
        Me.IconBtnInsertLine.Size = New System.Drawing.Size(32, 27)
        Me.IconBtnInsertLine.TabIndex = 72
        Me.IconBtnInsertLine.TabStop = False
        Me.IconBtnInsertLine.ToolTipText = Nothing
        '
        'IconBtnAddLink
        '
        Me.IconBtnAddLink.ActiveColor = System.Drawing.Color.LightCoral
        Me.IconBtnAddLink.BackColor = System.Drawing.Color.Transparent
        Me.IconBtnAddLink.IconType = FontAwesomeIcons.IconType.Chain
        Me.IconBtnAddLink.InActiveColor = System.Drawing.Color.White
        Me.IconBtnAddLink.Location = New System.Drawing.Point(759, 15)
        Me.IconBtnAddLink.Name = "IconBtnAddLink"
        Me.IconBtnAddLink.Size = New System.Drawing.Size(31, 24)
        Me.IconBtnAddLink.TabIndex = 71
        Me.IconBtnAddLink.TabStop = False
        Me.IconBtnAddLink.ToolTipText = Nothing
        '
        'iconToolbar
        '
        Me.iconToolbar.ActiveColor = System.Drawing.Color.Red
        Me.iconToolbar.BackColor = System.Drawing.Color.Transparent
        Me.iconToolbar.IconType = FontAwesomeIcons.IconType.EnvelopeO
        Me.iconToolbar.InActiveColor = System.Drawing.Color.White
        Me.iconToolbar.Location = New System.Drawing.Point(12, 7)
        Me.iconToolbar.Margin = New System.Windows.Forms.Padding(4)
        Me.iconToolbar.Name = "iconToolbar"
        Me.iconToolbar.Size = New System.Drawing.Size(19, 20)
        Me.iconToolbar.TabIndex = 23
        Me.iconToolbar.TabStop = False
        Me.iconToolbar.ToolTipText = Nothing
        '
        'FrmEnviaCorreos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1203, 745)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Controls.Add(Me.Status)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmEnviaCorreos"
        Me.Opacity = 0.99R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración y envio de correos "
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel_Izquierda.ResumeLayout(False)
        Me.Panel_Izquierda.PerformLayout()
        Me.GbImagenes.ResumeLayout(False)
        Me.GbImagenes.PerformLayout()
        CType(Me.Pic_Final, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Inicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbFormato.ResumeLayout(False)
        Me.GbAbrir.ResumeLayout(False)
        Me.GbAbrir.PerformLayout()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.BarraTitulo.ResumeLayout(False)
        Me.BarraTitulo.PerformLayout()
        CType(Me.Restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.IconBtnLoadMails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconBtnOpenURL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconBtnSendMail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconBtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconBtnClearAttachment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconBtnNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconBtnFolderOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconBtnAttachment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconBtnIr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconBtnRigth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconBtnLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconBtnInsertLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconBtnAddLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconToolbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbCorreosInvalidos As System.Windows.Forms.ListBox
    Friend WithEvents lbEnviados As System.Windows.Forms.ListBox
    Friend WithEvents BtncFileLp As System.Windows.Forms.Button
    Friend WithEvents BtnCorreosInvalidos As System.Windows.Forms.Button
    Friend WithEvents BtnCorresEnviados As System.Windows.Forms.Button
    Friend WithEvents LbDuplicados As System.Windows.Forms.ListBox
    Friend WithEvents BtnGuardaDuplicados As System.Windows.Forms.Button
    Friend WithEvents Panel_Izquierda As System.Windows.Forms.Panel
    Friend WithEvents BtnOpenUrl As System.Windows.Forms.Button
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents Panel_Abajo As System.Windows.Forms.Panel
    Friend WithEvents RBtn_MS_Exchange As System.Windows.Forms.RadioButton
    Friend WithEvents lblAsunto As System.Windows.Forms.Label
    Friend WithEvents txtTituloCorreo As System.Windows.Forms.TextBox
    Friend WithEvents RBtnGmail As System.Windows.Forms.RadioButton
    Friend WithEvents RBtn_Hotmail As System.Windows.Forms.RadioButton
    Friend WithEvents BtnIr As System.Windows.Forms.Button
    Friend WithEvents ChkAddImg As System.Windows.Forms.CheckBox
    Friend WithEvents BtnNOEnviados As System.Windows.Forms.Button
    Friend WithEvents txtConocidoComo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LbNoEnviados As System.Windows.Forms.ListBox
    Friend WithEvents lvCorreos As System.Windows.Forms.ListView
    Friend WithEvents Imgtree As System.Windows.Forms.ImageList
    Friend WithEvents Status As System.Windows.Forms.StatusStrip
    Friend WithEvents lblProgres As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Pb As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblCargados As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCorreosCargados As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCorreosDuplicados As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCorreosInvalidos As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblEnviados As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCorreo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents T As System.Windows.Forms.Timer
    Friend WithEvents attachmentDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents colorDlg As System.Windows.Forms.ColorDialog
    Friend WithEvents textAttachments As System.Windows.Forms.TextBox
    Friend WithEvents lblAdjuntos As System.Windows.Forms.Label
    Friend WithEvents Btn_Adelante As System.Windows.Forms.Button
    Friend WithEvents Btn_Atras As System.Windows.Forms.Button
    Public WithEvents WebBrowserEmail As System.Windows.Forms.WebBrowser
    Friend WithEvents lblDe As System.Windows.Forms.Label
    Friend WithEvents txtCorreoEnvia As System.Windows.Forms.TextBox
    Friend WithEvents lblClave As System.Windows.Forms.Label
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents GbAbrir As System.Windows.Forms.GroupBox
    Friend WithEvents rBtn_HTML As System.Windows.Forms.RadioButton
    Friend WithEvents rBtn_Word As System.Windows.Forms.RadioButton
    Friend WithEvents TTCorreos As System.Windows.Forms.ToolTip
    Friend WithEvents GbFormato As GroupBox
    Friend WithEvents BtnJustifyFull As Button
    Friend WithEvents BtnJustifyCenter As Button
    Friend WithEvents lstFont As ComboBox
    Friend WithEvents BtnJustifyLeft As Button
    Friend WithEvents lstSize As ComboBox
    Friend WithEvents btnP As Button
    Friend WithEvents BtnRemoteFormat As Button
    Friend WithEvents BtnJustifyRight As Button
    Friend WithEvents btnB As Button
    Friend WithEvents BtnBackColor As Button
    Friend WithEvents btnI As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnU As Button
    Friend WithEvents Btn_InicEditor As Button
    Friend WithEvents GbImagenes As GroupBox
    Friend WithEvents lblinfoImg As Label
    Friend WithEvents lblImgFinal As Label
    Friend WithEvents lblUbicacionImgFinal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUbicacionImgInic As Label
    Friend WithEvents BtnImgFinal As Button
    Friend WithEvents BtnImgInic As Button
    Friend WithEvents TxtImgFinal As TextBox
    Friend WithEvents txtImgInicio As TextBox
    Friend WithEvents chkImgFinal As CheckBox
    Friend WithEvents ChkImgInicio As CheckBox
    Friend WithEvents Pic_Final As PictureBox
    Friend WithEvents Pic_Inicio As PictureBox
    Friend WithEvents lbErrores As ListBox
    Friend WithEvents BarraTitulo As Panel
    Friend WithEvents lblTituloSistema As Label
    Friend WithEvents Restaurar As PictureBox
    Friend WithEvents Minimizar As PictureBox
    Friend WithEvents Maximizar As PictureBox
    Friend WithEvents Cerrar As PictureBox
    Friend WithEvents iconToolbar As FontAwesomeIcons.IconButton
    Friend WithEvents Button1 As Button
    Friend WithEvents cboSheetBooks As ComboBox
    Friend WithEvents BtnExaminar As Button
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents TextHoja As TextBox
    Friend WithEvents lblHoja As Label
    Friend WithEvents BtnCargar As Button
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents IconBtnLoadMails As FontAwesomeIcons.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents IconBtnLeft As FontAwesomeIcons.IconButton
    Friend WithEvents IconBtnRigth As FontAwesomeIcons.IconButton
    Friend WithEvents IconBtnIr As FontAwesomeIcons.IconButton
    Friend WithEvents IconBtnAttachment As FontAwesomeIcons.IconButton
    Friend WithEvents IconBtnClearAttachment As FontAwesomeIcons.IconButton
    Friend WithEvents IconBtnFolderOpen As FontAwesomeIcons.IconButton
    Friend WithEvents IconBtnNew As FontAwesomeIcons.IconButton
    Friend WithEvents IconBtnSendMail As FontAwesomeIcons.IconButton
    Friend WithEvents IconBtnSave As FontAwesomeIcons.IconButton
    Friend WithEvents IconBtnOpenURL As FontAwesomeIcons.IconButton
    Friend WithEvents IconBtnAddLink As FontAwesomeIcons.IconButton
    Friend WithEvents IconBtnInsertLine As FontAwesomeIcons.IconButton
End Class
