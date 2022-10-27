<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMsOutlook
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMsOutlook))
        Me.txtNameFolder = New System.Windows.Forms.TextBox()
        Me.LBCorreos = New System.Windows.Forms.ListBox()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.TreeVOutlook = New System.Windows.Forms.TreeView()
        Me.Imgtree = New System.Windows.Forms.ImageList(Me.components)
        Me.ImgGeneral = New System.Windows.Forms.ImageList(Me.components)
        Me.txtNombreLista = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.CboCuentas = New System.Windows.Forms.ComboBox()
        Me.Sb = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFrom = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSuma = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lvGrupos = New System.Windows.Forms.ListView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelControlErrores = New System.Windows.Forms.Panel()
        Me.LBControlErrores = New System.Windows.Forms.ListBox()
        Me.PnlProcesos = New System.Windows.Forms.Panel()
        Me.pbar = New System.Windows.Forms.ProgressBar()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnlparametros = New System.Windows.Forms.Panel()
        Me.CboListas = New System.Windows.Forms.ComboBox()
        Me.txtNumFolder = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnIniciaScreen = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnCrearListas = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCorreos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Sb.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelControlErrores.SuspendLayout()
        Me.PnlProcesos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnlparametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNameFolder
        '
        Me.txtNameFolder.ForeColor = System.Drawing.Color.Maroon
        Me.txtNameFolder.Location = New System.Drawing.Point(88, 39)
        Me.txtNameFolder.Name = "txtNameFolder"
        Me.txtNameFolder.Size = New System.Drawing.Size(262, 21)
        Me.txtNameFolder.TabIndex = 3
        '
        'LBCorreos
        '
        Me.LBCorreos.BackColor = System.Drawing.Color.Snow
        Me.LBCorreos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBCorreos.FormattingEnabled = True
        Me.LBCorreos.Location = New System.Drawing.Point(0, 0)
        Me.LBCorreos.Name = "LBCorreos"
        Me.LBCorreos.Size = New System.Drawing.Size(347, 656)
        Me.LBCorreos.TabIndex = 4
        '
        'pb
        '
        Me.pb.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pb.Location = New System.Drawing.Point(0, 773)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(1109, 10)
        Me.pb.TabIndex = 6
        '
        'TreeVOutlook
        '
        Me.TreeVOutlook.BackColor = System.Drawing.Color.OldLace
        Me.TreeVOutlook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeVOutlook.ImageKey = "email_go.ico"
        Me.TreeVOutlook.ImageList = Me.Imgtree
        Me.TreeVOutlook.Location = New System.Drawing.Point(0, 0)
        Me.TreeVOutlook.Name = "TreeVOutlook"
        Me.TreeVOutlook.SelectedImageIndex = 0
        Me.TreeVOutlook.ShowNodeToolTips = True
        Me.TreeVOutlook.Size = New System.Drawing.Size(357, 664)
        Me.TreeVOutlook.TabIndex = 1
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
        '
        'ImgGeneral
        '
        Me.ImgGeneral.ImageStream = CType(resources.GetObject("ImgGeneral.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgGeneral.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgGeneral.Images.SetKeyName(0, "Office_MAIL_open.png")
        Me.ImgGeneral.Images.SetKeyName(1, "exit.png")
        Me.ImgGeneral.Images.SetKeyName(2, "lockstart_session.png")
        Me.ImgGeneral.Images.SetKeyName(3, "shutdown.png")
        Me.ImgGeneral.Images.SetKeyName(4, "recycled.png")
        Me.ImgGeneral.Images.SetKeyName(5, "Symbol-Refresh.png")
        Me.ImgGeneral.Images.SetKeyName(6, "mail_get.png")
        Me.ImgGeneral.Images.SetKeyName(7, "mail_forward.png")
        Me.ImgGeneral.Images.SetKeyName(8, "Undo.png")
        Me.ImgGeneral.Images.SetKeyName(9, "Symbol-Delete.png")
        '
        'txtNombreLista
        '
        Me.txtNombreLista.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreLista.Location = New System.Drawing.Point(529, 32)
        Me.txtNombreLista.Name = "txtNombreLista"
        Me.txtNombreLista.Size = New System.Drawing.Size(152, 21)
        Me.txtNombreLista.TabIndex = 14
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(526, 15)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(78, 14)
        Me.lblNombre.TabIndex = 15
        Me.lblNombre.Text = "Nombre Lista"
        '
        'CboCuentas
        '
        Me.CboCuentas.FormattingEnabled = True
        Me.CboCuentas.Location = New System.Drawing.Point(88, 12)
        Me.CboCuentas.Name = "CboCuentas"
        Me.CboCuentas.Size = New System.Drawing.Size(262, 21)
        Me.CboCuentas.TabIndex = 16
        '
        'Sb
        '
        Me.Sb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.lblName, Me.ToolStripStatusLabel3, Me.lblFrom, Me.ToolStripStatusLabel4, Me.lblSuma})
        Me.Sb.Location = New System.Drawing.Point(0, 749)
        Me.Sb.Name = "Sb"
        Me.Sb.Size = New System.Drawing.Size(1109, 24)
        Me.Sb.TabIndex = 18
        Me.Sb.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Firebrick
        Me.ToolStripStatusLabel2.Image = Global.WAplMsOutlook.My.Resources.Resources.user
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(70, 19)
        Me.ToolStripStatusLabel2.Text = "Nombre:"
        '
        'lblName
        '
        Me.lblName.AutoSize = False
        Me.lblName.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(280, 19)
        Me.lblName.Spring = True
        Me.lblName.Text = "N"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblName.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Firebrick
        Me.ToolStripStatusLabel3.Image = Global.WAplMsOutlook.My.Resources.Resources.email_open_image
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(111, 19)
        Me.ToolStripStatusLabel3.Text = "Correo Sustraído"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = False
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.RightToLeftAutoMirrorImage = True
        Me.lblFrom.Size = New System.Drawing.Size(280, 19)
        Me.lblFrom.Spring = True
        Me.lblFrom.Text = "@"
        Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.Firebrick
        Me.ToolStripStatusLabel4.Image = Global.WAplMsOutlook.My.Resources.Resources.sum
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(73, 19)
        Me.ToolStripStatusLabel4.Text = "Contador"
        '
        'lblSuma
        '
        Me.lblSuma.Name = "lblSuma"
        Me.lblSuma.Size = New System.Drawing.Size(280, 19)
        Me.lblSuma.Spring = True
        Me.lblSuma.Text = "++"
        Me.lblSuma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lvGrupos
        '
        Me.lvGrupos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvGrupos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvGrupos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvGrupos.Location = New System.Drawing.Point(0, 0)
        Me.lvGrupos.Name = "lvGrupos"
        Me.lvGrupos.Size = New System.Drawing.Size(393, 656)
        Me.lvGrupos.TabIndex = 20
        Me.lvGrupos.UseCompatibleStateImageBehavior = False
        Me.lvGrupos.View = System.Windows.Forms.View.Details
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TreeVOutlook)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 664)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(357, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 664)
        Me.Panel2.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.LBCorreos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(351, 660)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.PanelControlErrores)
        Me.Panel4.Controls.Add(Me.PnlProcesos)
        Me.Panel4.Controls.Add(Me.lvGrupos)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(351, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(397, 660)
        Me.Panel4.TabIndex = 1
        '
        'PanelControlErrores
        '
        Me.PanelControlErrores.Controls.Add(Me.LBControlErrores)
        Me.PanelControlErrores.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControlErrores.Location = New System.Drawing.Point(0, 584)
        Me.PanelControlErrores.Name = "PanelControlErrores"
        Me.PanelControlErrores.Size = New System.Drawing.Size(393, 72)
        Me.PanelControlErrores.TabIndex = 3
        '
        'LBControlErrores
        '
        Me.LBControlErrores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBControlErrores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBControlErrores.FormattingEnabled = True
        Me.LBControlErrores.Items.AddRange(New Object() {"Control de Errores"})
        Me.LBControlErrores.Location = New System.Drawing.Point(0, 0)
        Me.LBControlErrores.Name = "LBControlErrores"
        Me.LBControlErrores.Size = New System.Drawing.Size(393, 72)
        Me.LBControlErrores.TabIndex = 0
        '
        'PnlProcesos
        '
        Me.PnlProcesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlProcesos.Controls.Add(Me.pbar)
        Me.PnlProcesos.Controls.Add(Me.lblAccion)
        Me.PnlProcesos.Controls.Add(Me.PictureBox1)
        Me.PnlProcesos.Location = New System.Drawing.Point(33, 266)
        Me.PnlProcesos.Name = "PnlProcesos"
        Me.PnlProcesos.Size = New System.Drawing.Size(330, 100)
        Me.PnlProcesos.TabIndex = 21
        Me.PnlProcesos.Visible = False
        '
        'pbar
        '
        Me.pbar.ForeColor = System.Drawing.Color.Teal
        Me.pbar.Location = New System.Drawing.Point(120, 59)
        Me.pbar.Name = "pbar"
        Me.pbar.Size = New System.Drawing.Size(164, 29)
        Me.pbar.TabIndex = 2
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Location = New System.Drawing.Point(117, 29)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(43, 14)
        Me.lblAccion.TabIndex = 3
        Me.lblAccion.Text = "Accion"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WAplMsOutlook.My.Resources.Resources.Rename
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Pnlparametros
        '
        Me.Pnlparametros.BackColor = System.Drawing.Color.Transparent
        Me.Pnlparametros.BackgroundImage = Global.WAplMsOutlook.My.Resources.Resources.Fondoagua
        Me.Pnlparametros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pnlparametros.Controls.Add(Me.CboListas)
        Me.Pnlparametros.Controls.Add(Me.txtNumFolder)
        Me.Pnlparametros.Controls.Add(Me.BtnEliminar)
        Me.Pnlparametros.Controls.Add(Me.BtnIniciaScreen)
        Me.Pnlparametros.Controls.Add(Me.BtnActualizar)
        Me.Pnlparametros.Controls.Add(Me.txtNameFolder)
        Me.Pnlparametros.Controls.Add(Me.BtnCrearListas)
        Me.Pnlparametros.Controls.Add(Me.Label2)
        Me.Pnlparametros.Controls.Add(Me.BtnSalir)
        Me.Pnlparametros.Controls.Add(Me.BtnCorreos)
        Me.Pnlparametros.Controls.Add(Me.txtNombreLista)
        Me.Pnlparametros.Controls.Add(Me.Label1)
        Me.Pnlparametros.Controls.Add(Me.lblNombre)
        Me.Pnlparametros.Controls.Add(Me.CboCuentas)
        Me.Pnlparametros.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnlparametros.Location = New System.Drawing.Point(0, 0)
        Me.Pnlparametros.Name = "Pnlparametros"
        Me.Pnlparametros.Size = New System.Drawing.Size(1109, 85)
        Me.Pnlparametros.TabIndex = 5
        '
        'CboListas
        '
        Me.CboListas.BackColor = System.Drawing.Color.SandyBrown
        Me.CboListas.FormattingEnabled = True
        Me.CboListas.Location = New System.Drawing.Point(88, 59)
        Me.CboListas.Name = "CboListas"
        Me.CboListas.Size = New System.Drawing.Size(121, 21)
        Me.CboListas.TabIndex = 26
        Me.CboListas.Visible = False
        '
        'txtNumFolder
        '
        Me.txtNumFolder.BackColor = System.Drawing.Color.SandyBrown
        Me.txtNumFolder.Location = New System.Drawing.Point(529, 60)
        Me.txtNumFolder.Name = "txtNumFolder"
        Me.txtNumFolder.Size = New System.Drawing.Size(152, 21)
        Me.txtNumFolder.TabIndex = 25
        Me.txtNumFolder.Visible = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.ImageKey = "Symbol-Delete.png"
        Me.BtnEliminar.ImageList = Me.ImgGeneral
        Me.BtnEliminar.Location = New System.Drawing.Point(719, 5)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(79, 58)
        Me.BtnEliminar.TabIndex = 24
        Me.BtnEliminar.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnIniciaScreen
        '
        Me.BtnIniciaScreen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnIniciaScreen.ImageKey = "Undo.png"
        Me.BtnIniciaScreen.ImageList = Me.ImgGeneral
        Me.BtnIniciaScreen.Location = New System.Drawing.Point(885, 5)
        Me.BtnIniciaScreen.Name = "BtnIniciaScreen"
        Me.BtnIniciaScreen.Size = New System.Drawing.Size(79, 58)
        Me.BtnIniciaScreen.TabIndex = 23
        Me.BtnIniciaScreen.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnIniciaScreen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnIniciaScreen.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.ImageIndex = 5
        Me.BtnActualizar.ImageList = Me.ImgGeneral
        Me.BtnActualizar.Location = New System.Drawing.Point(356, 3)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(79, 58)
        Me.BtnActualizar.TabIndex = 17
        Me.BtnActualizar.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnCrearListas
        '
        Me.BtnCrearListas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCrearListas.ImageKey = "mail_forward.png"
        Me.BtnCrearListas.ImageList = Me.ImgGeneral
        Me.BtnCrearListas.Location = New System.Drawing.Point(800, 5)
        Me.BtnCrearListas.Name = "BtnCrearListas"
        Me.BtnCrearListas.Size = New System.Drawing.Size(79, 58)
        Me.BtnCrearListas.TabIndex = 12
        Me.BtnCrearListas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCrearListas.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 14)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Carpeta:"
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.ImageIndex = 2
        Me.BtnSalir.ImageList = Me.ImgGeneral
        Me.BtnSalir.Location = New System.Drawing.Point(1026, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(79, 58)
        Me.BtnSalir.TabIndex = 21
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCorreos
        '
        Me.BtnCorreos.ImageKey = "mail_get.png"
        Me.BtnCorreos.ImageList = Me.ImgGeneral
        Me.BtnCorreos.Location = New System.Drawing.Point(441, 2)
        Me.BtnCorreos.Name = "BtnCorreos"
        Me.BtnCorreos.Size = New System.Drawing.Size(71, 58)
        Me.BtnCorreos.TabIndex = 5
        Me.BtnCorreos.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnCorreos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCorreos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Cuentas"
        '
        'FrmMsOutlook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1109, 783)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Sb)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.Pnlparametros)
        Me.Font = New System.Drawing.Font("Tahoma", 8.307693!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMsOutlook"
        Me.Opacity = 0.97R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Microsoft Outlook - Extración de Correos "
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Sb.ResumeLayout(False)
        Me.Sb.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.PanelControlErrores.ResumeLayout(False)
        Me.PnlProcesos.ResumeLayout(False)
        Me.PnlProcesos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnlparametros.ResumeLayout(False)
        Me.Pnlparametros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNameFolder As System.Windows.Forms.TextBox
    Friend WithEvents LBCorreos As System.Windows.Forms.ListBox
    Friend WithEvents BtnCorreos As System.Windows.Forms.Button
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
    Friend WithEvents TreeVOutlook As System.Windows.Forms.TreeView
    Friend WithEvents BtnCrearListas As System.Windows.Forms.Button
    Friend WithEvents Imgtree As System.Windows.Forms.ImageList
    Friend WithEvents txtNombreLista As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents CboCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents Sb As System.Windows.Forms.StatusStrip
    Friend WithEvents lblName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblFrom As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSuma As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lvGrupos As System.Windows.Forms.ListView
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Pnlparametros As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ImgGeneral As System.Windows.Forms.ImageList
    Friend WithEvents BtnIniciaScreen As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblAccion As System.Windows.Forms.Label
    Friend WithEvents pbar As System.Windows.Forms.ProgressBar
    Friend WithEvents PnlProcesos As System.Windows.Forms.Panel
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents PanelControlErrores As System.Windows.Forms.Panel
    Friend WithEvents txtNumFolder As System.Windows.Forms.TextBox
    Friend WithEvents CboListas As System.Windows.Forms.ComboBox
    Friend WithEvents LBControlErrores As System.Windows.Forms.ListBox
End Class
