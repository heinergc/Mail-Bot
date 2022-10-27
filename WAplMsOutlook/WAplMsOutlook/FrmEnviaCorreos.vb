Imports System.Data.OleDb
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Net.Mail
Imports System.Threading
Imports Microsoft.Office.Interop
Imports ExcelDataReader
Imports ExcelDataReader.ExcelReaderFactory
Imports ICSharpCode.SharpZipLib


Public Class FrmEnviaCorreos

    Private ds As New DataSet
    Private m_arCharset(27, 1) As String
    Private m_arAttachment As ArrayList = New ArrayList
    Private m_bcancel As Boolean = False
    Public m_htmlDoc As mshtml.IHTMLDocument2
    Private m_htmlDoc2 As mshtml.IHTMLDocument2

    Public Minutos As Double = 0
    Dim Segundos As Double = 0
    Dim horas As Integer = 0
    Dim dt As New DataTable
    Dim dtCorreos As New DataTable
    Dim DtGuardarInfoCorreo As New DataTable
    Public vMiliSegundos As Int32 = 90000 ' 1- 1/2 minuto
    Dim Contador As Integer = 0
    Public TimeWait As Integer
    Public SMTPNAME As String = ""
    Public SMTPNAMEII As String = ""
    Public DominioUNED As String = "@uned.ac.cr"
    Public SSL As Boolean = False

    ''Mover el formulario sin borde 
    'Private vai As Boolean = False
    Private m As Integer
    Private m_x As Integer
    Private m_y As Integer
    '---------------------------------------
    Public vpUbicacionMaquina As String = ""

    Private Declare Function IsNetworkAlive Lib "SENSAPI.DLL" (ByRef lpdwFlags As Long) As Long

    'Constantes

    Public Const SHACF_AUTOAPPEND_FORCE_OFF = &H80000000
    Public Const SHACF_AUTOAPPEND_FORCE_ON = &H40000000
    Public Const SHACF_AUTOSUGGEST_FORCE_OFF = &H20000000
    Public Const SHACF_AUTOSUGGEST_FORCE_ON = &H10000000
    Public Const SHACF_DEFAULT = &H0
    Public Const SHACF_FILESYSTEM = &H1
    Public Const SHACF_URLHISTORY = &H2
    Public Const SHACF_URLMRU = &H4
    Public Const SHACF_USETAB = &H8
    Public Const SHACF_URLALL = (SHACF_URLHISTORY Or SHACF_URLMRU)

    'Función Api SHAutoComplete para autocompletar la caché
    Private Declare Sub SHAutoComplete Lib "shlwapi.dll" (ByVal controlHandle As Int32, ByVal completeFlags As Int32)
    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal handle As Int32, ByVal hwndChildAfter As Integer, ByVal lpszClass As String, ByVal lpszWindow As String) As Int32

    Public Sub AucompletarCache(ByVal txt As TextBox)

        Dim Handle As Long

        Handle = FindWindowEx(txt.Handle.ToInt32, 0, "edit", vbNullString)
        SHAutoComplete(Handle, SHACF_DEFAULT)

    End Sub

    Public Sub t_ShowTime()


        If TimeWait > 0 Then
            TimeWait = TimeWait - 1000
            Segundos = Math.Truncate((TimeWait / 1000) Mod 60)
            Minutos = Math.Truncate(((TimeWait / 1000) / 60))
            horas = Minutos / 60

        Else
            T.Stop()
        End If



        lblTime.Text = horas.ToString & ":" & Minutos.ToString & ":" & Segundos.ToString
        System.Windows.Forms.Application.DoEvents()
    End Sub




    Private Sub FrmEnviaCorreos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pIniciar()
        TimeWait = vMiliSegundos

        WebBrowserEmail.Navigate("about:blank")

        m_htmlDoc = CType(WebBrowserEmail.Document.DomDocument, mshtml.IHTMLDocument2)
        m_htmlDoc.designMode = "on"
        InitFonts()


        AucompletarCache(txtURL)

        RadioBtnCheck()
        lblTime.Text = Now.TimeOfDay.ToString


        pShowToptip()

    End Sub
    Private Function pObtieneDominio(ByVal Correo As String) As String
        pObtieneDominio = Nothing
        Dim vPos As Integer = 0
        vPos = InStr(Correo.Trim, "@", CompareMethod.Text)
        If vPos > 0 Then
            pObtieneDominio = Mid(Correo, vPos, Len(Correo.Trim))
        End If
        Return pObtieneDominio
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub pIniciar()
        lblEnviados.Text = ""
        lblCorreo.Text = ""
        lblCorreosDuplicados.Text = ""
        lblCorreosCargados.Text = ""
        lblCorreosInvalidos.Text = ""
        'dgvExcel.DataSource = Nothing
        lbCorreosInvalidos.Items.Clear()
        LbDuplicados.Items.Clear()
        lbEnviados.Items.Clear()

        lbErrores.Items.Clear()

        LbNoEnviados.Items.Clear()
        Pb.Value = 0

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Private Function CrearTabla() As DataTable
        Dim miTabla As DataTable = New DataTable("TBCORREOS")
        ' Dim miFila As DataRow
        Dim miColumna As DataColumn
        CrearTabla = Nothing



        miColumna = New DataColumn("Correo")

        With miColumna
            .DataType = System.Type.GetType("System.String")
            .Unique = True
            .MaxLength = 50
            .AllowDBNull = True
            miTabla.Columns.Add(miColumna)
            miTabla.PrimaryKey = New DataColumn() {miColumna}
        End With


        miColumna = New DataColumn("Estado")

        With miColumna
            .DataType = System.Type.GetType("System.String")
            .MaxLength = 50
            '.AutoIncrement = True
            '.AutoIncrementSeed = 1 'Valor Inicial
            '.AutoIncrementStep = 2 'Incremento de 2 
            miTabla.Columns.Add(miColumna)
        End With



        CrearTabla = miTabla
        'Agregar Informacion 
        'Dim i As Integer

        'For i = 0 To 10
        '    miFila = miTabla.NewRow
        '    miFila("Correo") = "hguido@uned.ac.cr" & i
        '    miTabla.Rows.Add(miFila)
        'Next
        Return CrearTabla

    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Correo"></param>
    ''' <param name="Estado"></param>
    Public Sub AddFilasCorreos(ByVal Correo As String, ByVal Estado As String)
        Try
            Dim miFila As DataRow
            'If Correo.Trim = "notifications+vvvq3x2p3lv@zyngamail.com" Then Exit Sub

            If validar_Mail(Correo.Trim) Then
                miFila = dtCorreos.NewRow
                miFila("Correo") = Correo.Trim
                miFila("Estado") = Estado.Trim
                dtCorreos.Rows.Add(miFila)
            Else
                lbCorreosInvalidos.Items.Add(Correo.Trim)
            End If
        Catch ex As System.Exception
            LbDuplicados.Items.Add(Correo.Trim)
        End Try

    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="tables"></param>
    ''' <returns></returns>
    Private Shared Function GetTablenames(ByVal tables As DataTableCollection) As IList(Of String)
        Dim tableList = New List(Of String)()

        For Each table In tables
            tableList.Add(table.ToString())
        Next

        Return tableList
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub UploadMails()
        Try

            If txtdireccion.Text = "" Then
                MsgBox("Debe digitar una dirección valida")
                Exit Sub
            End If


            Using stream1 = New FileStream(txtdireccion.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)

                Dim sw = New Stopwatch()
                sw.Start()



                Using reader As IExcelDataReader = CreateReader(stream1)


                    Dim openTiming = sw.ElapsedMilliseconds

                    ds = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                        .UseColumnDataType = False,
                        .ConfigureDataTable = Function(tableReader) New ExcelDataTableConfiguration() With {
                         .UseHeaderRow = True
                        }
                    })

                End Using

            End Using



            'ToolStripStatusLabel1.Text = "Elapsed: " & sw.ElapsedMilliseconds.ToString() & " ms (" + openTiming.ToString() & " ms to open)"
            Dim tablenames = GetTablenames(ds.Tables)
            cboSheetBooks.DataSource = tablenames
            If tablenames.Count > 0 Then cboSheetBooks.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Private Sub CargaListaCorreos()
        Dim i As Integer = 0
        Dim ds As New DataSet()

        If txtdireccion.Text = "" Then
            MsgBox("Debe digitar una dirección valida")
            Exit Sub
        End If

        If TextHoja.Text = "" Then
            MsgBox("Debe digitar un nombre de hoja valido")
            Exit Sub
        End If



        Dim ruta As String = txtdireccion.Text
        Dim consulta As String = "SELECT * FROM [" & TextHoja.Text & "$]"

        'Dim _cadenaConexion As String = String.Format("Provider=Microsoft.ACE.OLEDB.14.0;Data Source={0};Extended Properties=Excel 8.0", ruta)
        Dim _cadenaConexion As String = String.Format("Provider=Microsoft.Jet.OLEDB.6.0;Data Source=" & txtdireccion.Text & ";Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1"";")

        Dim _oledbConn As New OleDbConnection(_cadenaConexion)
        Dim dt As New DataTable()

        Try
            Dim _cmd As OleDbCommand = New OleDbCommand(consulta, _oledbConn)
            Dim _oleda As OleDbDataAdapter = New OleDbDataAdapter()
            _oleda.SelectCommand = _cmd
            _oledbConn.Open()

            _oleda.Fill(ds)

            Dim _tabla As New DataTable
            _tabla.Clear()
            _tabla = ds.Tables(0)

            dtCorreos.Clear()

            dtCorreos = CrearTabla()

            If _tabla.Rows.Count > 0 Then
                For i = 0 To _tabla.Rows.Count - 1
                    lblCorreosCargados.Text = i + 1
                    AddFilasCorreos(_tabla.Rows(i)("CORREO_ELECT").ToString, "Estado:Sin Enviar")
                Next
            End If

            lblCorreosDuplicados.Text = LbDuplicados.Items.Count
            lblCorreosInvalidos.Text = lbCorreosInvalidos.Items.Count

            RellenarListview(dtCorreos, lvCorreos, Imgtree, Pb)
            'dgvExcel.DataSource = dtCorreos



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub BtnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCargar.Click
        pIniciar()
        'CargaListaCorreos()

        UploadMails()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExaminar.Click
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Excel (*.xls;*.xlsx)|*.xls;*.xlsx"
            '"Microsoft Word(*.doc;*.docx)|*.doc;*.docx"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txtdireccion.Text = .FileName
                cboSheetBooks.Focus()
            End If
        End With
    End Sub

    Private Sub pEnviarCorreo(ByVal vCorreo As String, ByVal fileList() As String)
        Dim str As New StringBuilder
        Dim correo As New System.Net.Mail.MailMessage()

        '----
        'Dim imageView As New AlternateView("c:\carpeta\Programa Desarrollo Profesional en Línea_image001.jpg", Mime.MediaTypeNames.Image.Jpeg)
        'Dim DAta As Attachment = New Attachment(imageView.ContentStream, Mime.MediaTypeNames.Image.Jpeg)


        'DAta.ContentDisposition.Inline = True
        'DAta.ContentId = "uniqueId"
        'DAta.TransferEncoding = TransferEncoding.Base64

        Dim ImgInicial As LinkedResource = Nothing
        Dim ImgFinal As LinkedResource = Nothing

        If ChkImgInicio.Checked = True Then
            If txtImgInicio.Text = "" Then
                MsgBox("La opción de imagen al inicio del documento esta activa, " & Chr(13) & " pero no ha seleccionado una imagen aún.", MsgBoxStyle.Information, Application.ProductName)
                Exit Sub
            Else
                ImgInicial = New LinkedResource(txtImgInicio.Text)
            End If
        End If


        If chkImgFinal.Checked = True Then
            If TxtImgFinal.Text = "" Then
                MsgBox("La opción de imagen al final del documento esta activa, " & Chr(13) & " pero no ha seleccionado una imagen aún.", MsgBoxStyle.Information, Application.ProductName)
                Exit Sub
            Else
                ImgFinal = New LinkedResource(TxtImgFinal.Text)
            End If
        End If



        With correo
            Application.DoEvents()

            .From = New System.Net.Mail.MailAddress(txtCorreoEnvia.Text.Trim, txtConocidoComo.Text.Trim) 'Falta Correo
            .To.Add(New System.Net.Mail.MailAddress(vCorreo.ToString.Trim))
            .Subject = txtTituloCorreo.Text.Trim
            .IsBodyHtml = True
            .Priority = System.Net.Mail.MailPriority.Normal
            '.Attachments.Add(DAta)

            Dim count As Integer = m_arAttachment.Count
            Dim i As Integer = 0
            For i = 0 To count - 1
                Dim MsgAttach As New Attachment(m_arAttachment(i))
                .Attachments.Add(MsgAttach)
            Next

            'If Not fileList Is Nothing Then
            '    For Each strfile As String In fileList
            '        If Not strfile = "" Then
            '            Dim MsgAttach As New Attachment(strfile)
            '            .Attachments.Add(MsgAttach)
            '        End If
            '    Next
            'End If

            'str.Append(WebBrowserEmail.Document.Body.InnerHtml)
            str.Append(GetFileContents(WebBrowserEmail.DocumentStream))

            'Dim vHTML = WebBrowserEmail.Document
            'Dim htmlView As AlternateView
            'Dim ImgX As LinkedResource = Nothing
            'Dim ImgStr As String = String.Empty
            ''Dim i As Integer = 0

            'If vHTML IsNot Nothing Then
            '    If vHTML.Images.Count > 0 Then
            '        For i = 0 To vHTML.Images.Count - 1
            '            Dim imgCompleta = vHTML.Images.Item(i).OuterHtml.ToString()
            '            Dim x2 = imgCompleta.Split("=")
            '            ImgX = New LinkedResource("c:\dsdsd") With {
            '                .ContentId = "img" & i.ToString()
            '            }

            '            ImgStr = $"<img src=cid:{ImgX.ContentId}>"

            '            htmlView = AlternateView.CreateAlternateViewFromString($"</br>{ImgStr}</br>", Nothing, "text/html")
            '            htmlView.LinkedResources.Add(ImgInicial)

            '            .AlternateViews.Add(htmlView)
            '        Next
            '    End If
            'End If



            'correo.Body = str.ToString
            ' hacer algo para mejorar el envio de imagenes del cuerpo del correo
            'Dim plainView As AlternateView = AlternateView.CreateAlternateViewFromString("This is my plain text content, viewable by those clients that don't support html", Nothing, "text/plain")
            If ChkImgInicio.Checked = True Then
                Dim htmlViewImgInic As AlternateView = AlternateView.CreateAlternateViewFromString("</br> <img src=cid:ImgInicial> </br>" & str.ToString, Nothing, "text/html")
                ImgInicial.ContentId = "ImgInicial"
                htmlViewImgInic.LinkedResources.Add(ImgInicial)
                .AlternateViews.Add(htmlViewImgInic)
            Else
                Dim htmlViewBody As AlternateView = AlternateView.CreateAlternateViewFromString("</br> " & str.ToString, Nothing, "text/html")
                .AlternateViews.Add(htmlViewBody)
                'correo.Body = GetFileContents(ObtieneUbicMaquina(txtURL.Text.Trim))
            End If



            If chkImgFinal.Checked = True Then
                Dim htmlViewImgFinal As AlternateView = AlternateView.CreateAlternateViewFromString("</br> <img src=cid:ImgFinal>", Nothing, "text/html")
                ImgFinal.ContentId = "ImgFinal"
                htmlViewImgFinal.LinkedResources.Add(ImgFinal)
                .AlternateViews.Add(htmlViewImgFinal)
            End If
            'create the LinkedResource (embedded image)


            'add the LinkedResource to the appropriate view
            .BodyEncoding = System.Text.Encoding.UTF8

        End With

        Dim smtp As New System.Net.Mail.SmtpClient
        'smtp.Host = "172.16.1.132"
        If RBtn_MS_Exchange.Checked = True Then
            If pObtieneDominio(vCorreo.Trim).ToUpper = DominioUNED.ToUpper Then
                smtp.Host = SMTPNAMEII
            Else
                smtp.Host = SMTPNAME
            End If
        Else
            smtp.Host = SMTPNAME
        End If
        smtp.Credentials = New System.Net.NetworkCredential(txtCorreoEnvia.Text.Trim, txtContrasena.Text.Trim)
        smtp.EnableSsl = SSL
        'smtp.Port = 25

        Try

            smtp.Send(correo)
            Application.DoEvents()
            lbEnviados.Items.Add(vCorreo.Trim)
        Catch ex As Exception
            LbNoEnviados.Items.Add(vCorreo.Trim)
            lbErrores.Items.Add(ex.Message)
            'Throw New Exception(ex.InnerException.Message)
        End Try
    End Sub

    Private Sub BtnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub IniciarListas()
        lbCorreosInvalidos.Items.Clear()
        LbDuplicados.Items.Clear()
        lbEnviados.Items.Clear()
        lbErrores.Items.Clear()
        LbNoEnviados.Items.Clear()
    End Sub

    Private Function Validacion() As Boolean
        Validacion = True

        If txtCorreoEnvia.Text = "" Then
            MsgBox("Debe digitar el correo electrónico encargado de enviar a los demás correos", MsgBoxStyle.Information, Application.ProductName)
            Validacion = False
            txtCorreoEnvia.Focus()
            Exit Function
        ElseIf txtContrasena.Text = "" Then
            MsgBox("Debe digitar la contraseña", MsgBoxStyle.Information, Application.ProductName)
            Validacion = False
            txtContrasena.Focus()
            Exit Function
        ElseIf txtdireccion.Text = "" Then
            MsgBox("Debe seleccionar la dirección del archivo" & Chr(13) & "que mantiene las cuentas de correo electrónico", MsgBoxStyle.Information, Application.ProductName)
            Validacion = False
            txtdireccion.Focus()
            Exit Function
        ElseIf txtTituloCorreo.Text = "" Then
            MsgBox("Digite un Asunto Válido para el envio de correos", MsgBoxStyle.Information, Application.ProductName)
            Validacion = False
            txtTituloCorreo.Focus()
            Exit Function
        ElseIf txtURL.Text = "" Then
            MsgBox("Debe cargar un contenido válido para enviar el correo", MsgBoxStyle.Information, Application.ProductName)
            Validacion = False
            txtURL.Focus()
            Exit Function
        End If

        Return Validacion
    End Function

    Private Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail,
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    Private Sub CrearArchivoTxT(ByVal NameFile As String, ByVal DtFile As DataTable, ByVal Lista As ListBox, ByVal Tipo As Integer)
        Dim sRenglon As String = Nothing
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim ContenidoArchivo As String = Nothing
        ' Donde guardamos los paths de los archivos que vamos a estar utilizando ..
        Dim PathArchivo As String

        'Tipo = 1  = Datatable 
        'Tipo = 2 = Lista 
        Dim i As Integer = 0

        Try

            If Tipo = 1 Then
                If DtFile Is Nothing Or DtFile.Rows.Count <= 0 Then
                    MsgBox("La lista está vacida")
                    Exit Sub
                End If
            ElseIf Tipo = 2 Then
                If Lista Is Nothing Or Lista.Items.Count <= 0 Then
                    MsgBox("La lista está vacida")
                    Exit Sub
                End If
            End If



            If Directory.Exists("C:\Capeta") = False Then ' si no existe la carpeta se crea
                Directory.CreateDirectory("C:\carpeta")
            End If

            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            PathArchivo = "C:\carpeta\Archivo" & NameFile & Format(Today.Date, "ddMMyyyy") & ".txt" ' Se determina el nombre del archivo con la fecha actual

            'verificamos si existe el archivo

            If File.Exists(PathArchivo) Then
                strStreamW = File.Open(PathArchivo, FileMode.Open) 'Abrimos el archivo
            Else
                strStreamW = File.Create(PathArchivo) ' lo creamos
            End If

            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' tipo de codificacion para escritura


            'escribimos en el archivo
            Select Case Tipo
                Case Is = 1
                    For i = 0 To DtFile.Rows.Count - 1
                        strStreamWriter.WriteLine(DtFile.Rows(i)("Correo").ToString)
                    Next
                Case Is = 2
                    For i = 0 To Lista.Items.Count - 1
                        strStreamWriter.WriteLine(Lista.Items(i).ToString)
                    Next
            End Select



            strStreamWriter.Close() ' cerramos
            MsgBox("El Archivo " & NameFile & Format(Today.Date, "ddMMyyyy") & ".txt" & " ha sido creado con éxito", MsgBoxStyle.Information, Application.ProductName)
        Catch ex As Exception
            MsgBox("Error al Guardar la ingormacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
            strStreamWriter.Close() ' cerramos
        End Try
    End Sub

    Private Sub BtncFileLp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtncFileLp.Click
        CrearArchivoTxT("Correos_Depurados_" & TextHoja.Text & "_", dtCorreos, Nothing, 1)
    End Sub

    Private Sub BtnCorreosInvalidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCorreosInvalidos.Click
        CrearArchivoTxT("Correos_Invalidos_" & TextHoja.Text & "_", Nothing, lbCorreosInvalidos, 2)
    End Sub


    Private Sub BtnCorresEnviados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCorresEnviados.Click
        CrearArchivoTxT("Correos_Enviados_" & TextHoja.Text & "_", Nothing, lbEnviados, 2)
    End Sub

    Private Sub BtnGuardaDuplicados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardaDuplicados.Click
        CrearArchivoTxT("Correos_Duplicados_" & TextHoja.Text & "_", Nothing, LbDuplicados, 2)
    End Sub

    Private Sub BtnOpenUrl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpenUrl.Click

    End Sub

    Private Function NombredeArchivo(ByVal Direccion As String, Optional ByVal SinTerminacion As Boolean = False) As String
        Dim vPos As Integer = 0
        NombredeArchivo = ""

        vPos = InStrRev(Direccion, "\", Len(Direccion), CompareMethod.Text)

        If vPos > 0 Then
            NombredeArchivo = Mid(Direccion, vPos + 1, Len(Direccion))
        Else
            vPos = InStrRev(Direccion, "/", Len(Direccion), CompareMethod.Text)
            If vPos > 0 Then
                NombredeArchivo = Mid(Direccion, vPos + 1, Len(Direccion))
            End If
        End If

        If SinTerminacion = False Then
            Return NombredeArchivo
        Else
            vPos = InStr(1, NombredeArchivo, ".", CompareMethod.Text)
            If vPos > 0 Then
                NombredeArchivo = Mid(NombredeArchivo, 1, vPos - 1)
            End If
        End If

    End Function

    Private Function DirecciondeArchivo(ByVal Direccion As String) As String
        Dim vPos As Integer = 0
        DirecciondeArchivo = ""

        vPos = InStrRev(Direccion, "\", Len(Direccion), CompareMethod.Text)

        If vPos > 0 Then
            DirecciondeArchivo = Mid(Direccion, 1, vPos - 1)
        Else
            vPos = InStrRev(Direccion, "/", Len(Direccion), CompareMethod.Text)
            If vPos > 0 Then
                DirecciondeArchivo = Mid(Direccion, 1, vPos - 1)
            End If

        End If
        Return DirecciondeArchivo
    End Function

    Private Function ExtraeTerminacion(ByVal NombreArchivo As String) As String
        Dim vPos As Integer = 0
        ExtraeTerminacion = ""

        vPos = InStrRev(NombreArchivo, ".", NombreArchivo.Length, CompareMethod.Text)
        If vPos > 0 Then
            ExtraeTerminacion = Mid(NombreArchivo, vPos + 1, NombreArchivo.Length)
        End If

        Return ExtraeTerminacion
    End Function

    Private Function ConvertFileWordToHTML(ByVal Direccion As String) As String
        Dim wordApp As New Word.Application
        Dim doc As New Word.Document
        Dim oWordApplic As New Word.ApplicationClass
        Dim vUbicicacion As String = DirecciondeArchivo(Direccion)
        Dim vNameFile As String = NombredeArchivo(Direccion)
        Dim vNameFileConvert As String = NombredeArchivo(Direccion)
        Dim vTerminacion As String = ".htm"
        Dim vPos As Integer = 0

        ConvertFileWordToHTML = Nothing
        Try


            doc = oWordApplic.Documents.Open(Direccion)


            Dim filename As Object = Direccion

            Dim Format As Object = Word.WdSaveFormat.wdFormatFilteredHTML

            vPos = InStr(vNameFile, ".", CompareMethod.Text)

            If vPos > 0 Then
                vNameFileConvert = Mid(vNameFile, 1, vPos - 1)
                'If vNameFileConvert.Length > 8 Then
                '    vNameFileConvert = Mid(vNameFileConvert, 1, 8)
                'End If
                vNameFileConvert += vTerminacion
            End If

            doc.SaveAs(vUbicicacion & "\" & vNameFileConvert, Format)
            ConvertFileWordToHTML = vUbicicacion & "\" & vNameFileConvert

            doc.Close()
            oWordApplic.Application.Quit()

            Return ConvertFileWordToHTML

        Catch ex As Exception
            doc.Close()
            oWordApplic.Application.Quit()
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub RadioBtnCheck()
        If RBtn_Hotmail.Checked = True Then
            lblAsunto.Text = "Hotmail Asunto:"
            lblClave.Text = "Hotmail Clave:"
            lblDe.Text = "Hotmail Correo:"
            'lblEjemploCorreo.Text = "heinergc@Hotmail.com"
            SMTPNAME = "smtp.live.com"
            'SMTPNAME = "localhost"
            'SMTPNAME = "mx1.hotmail.com"
            txtCorreoEnvia.Text = "@hotmail.com"
            SSL = True
        ElseIf RBtn_MS_Exchange.Checked = True Then
            lblAsunto.Text = "MS Exchange Asunto:"
            lblClave.Text = "MS Exchange Clave:"
            lblDe.Text = "Ms Exchange Correo:"
            'lblEjemploCorreo.Text = "hguido@uned.ac.cr"
            SMTPNAMEII = "uned-ac-cr.mail.protection.outlook.com"
            SMTPNAME = "uned-ac-cr.mail.protection.outlook.com"
            txtCorreoEnvia.Text = ""
            SSL = False
        ElseIf RBtnGmail.Checked = True Then
            lblAsunto.Text = "Gmail Asunto:"
            lblClave.Text = "Gmail Clave:"
            lblDe.Text = "Gmail Correo:"
            'lblEjemploCorreo.Text = "heinergc@Gmail.com"
            SMTPNAME = "smtp.gmail.com"
            txtCorreoEnvia.Text = "@gmail.com"
            SSL = True
        End If
        txtCorreoEnvia.Focus()
    End Sub

    Private Sub RBtn_MS_Exchange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtn_MS_Exchange.CheckedChanged
        RadioBtnCheck()
    End Sub

    Private Sub RBtn_Hotmail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtn_Hotmail.CheckedChanged
        RadioBtnCheck()
    End Sub

    Private Sub RBtnGmail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnGmail.CheckedChanged
        RadioBtnCheck()
    End Sub

    Private Sub BtnIr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIr.Click
        Ir_Web()
    End Sub

    Private Sub Ir_Web()
        If txtURL.Text <> "" Then
            WebBrowserEmail.Navigate(txtURL.Text.Trim)
        End If
    End Sub


    Private Sub ChkAddImg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAddImg.CheckedChanged
        HabilitaImg(ChkAddImg.Checked)
    End Sub

    Private Sub HabilitaImg(ByVal Valor As Boolean)
        GbImagenes.Visible = Valor
    End Sub



    Private Sub HabilitaCargaImgInicio(ByVal Valor As Boolean, ByVal ImgInicOFnal As Integer)
        Select Case ImgInicOFnal

            Case Is = 1
                'Img Inicial
                txtImgInicio.Enabled = Valor
                Pic_Inicio.Enabled = Valor
                BtnImgInic.Enabled = Valor

            Case Is = 2
                'Img Final 

                TxtImgFinal.Enabled = Valor
                Pic_Final.Enabled = Valor
                BtnImgFinal.Enabled = Valor

        End Select

    End Sub

    Private Sub chkImgFinal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        HabilitaCargaImgInicio(chkImgFinal.Checked, 2)
    End Sub

    Private Sub BtnImgInic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenDialogImagenes(1)
    End Sub

    Private Sub OpenDialogImagenes(ByVal InicialOrFinal As Integer)
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos de imagen(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|Todos los archivos (*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                Select Case InicialOrFinal
                    Case Is = 1
                        txtImgInicio.Text = .FileName
                        Pic_Inicio.Load(txtImgInicio.Text)
                    Case Is = 2
                        TxtImgFinal.Text = .FileName
                        Pic_Final.Load(TxtImgFinal.Text)
                End Select

            End If
        End With
    End Sub

    Private Sub BtnImgFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenDialogImagenes(2)
    End Sub

    Private Sub txtURL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtURL.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Ir_Web()
        End If
    End Sub

    Private Sub WebBrowserEmail_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowserEmail.DocumentCompleted
        'Dim MSDNpage As String = WebBrowserEmail.DocumentText
        'My.Computer.FileSystem.WriteAllText("C:\msdn1.html", MSDNpage, True)
        '' Get Body text and save as .txt file
        'Dim MSDNpage1 As String = WebBrowserEmail.Document.Body.InnerText
        'My.Computer.FileSystem.WriteAllText("C:\msdn2.txt", MSDNpage1, True)

    End Sub

    Private Sub WebBrowserEmail_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowserEmail.Navigated
        txtURL.Text = WebBrowserEmail.Url.ToString
        'Dim s As New System.Text.StringBuilder()
        's.Append("<div>Aqui puede empezar a digitar su correo.</div><div>&nbsp;</div>")
        's.Append("<div>From: [$from]</div>")
        's.Append("<div>To: [$to]</div>")
        's.Append("<div>Subject: [$subject]</div><div>&nbsp;</div>")
        's.Append("<div>If no sever address was specified, the email will be delivered to the recipient's server directly,")
        's.Append("However, if you don't have a static IP address, ")
        's.Append("many anti-spam filters will mark it as a junk-email.</div><div>&nbsp;</div>")
        's.Append("<div>If ""Digitial Signature"" was checked, please make sure you have the certificate for the sender address installed on ")
        's.Append("Local User Certificate Store.</div><div>&nbsp;</div>")
        's.Append("<div>If ""Encrypt"" was checked, please make sure you have the certificate for recipient address installed on the Local User Certificate Store.</div>")
        'm_htmlDoc.body.innerHTML = s.ToString()
    End Sub

    Private Function _EncodeAddress(ByVal v As String) As String
        v = v.Replace(">", "&gt;")
        v = v.Replace("<", "&lt;")
        _EncodeAddress = v
    End Function

    Private Sub BtnNOEnviados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNOEnviados.Click
        CrearArchivoTxT("Correos_NO_Enviados_" & TextHoja.Text & "_", Nothing, LbNoEnviados, 2)
    End Sub

    Function RellenarListview(ByVal dt As DataTable, ByVal lvwDatos As ListView, Optional ByVal ImgLista As ImageList = Nothing, Optional ByVal Progress As ToolStripProgressBar = Nothing) As Boolean
        Dim bolResultado As Boolean = True
        Dim lstElemento As ListViewItem
        Dim vConta As Integer
        Dim img As ImageList = ImgLista
        Try
            With lvwDatos
                .View = Windows.Forms.View.Details
                .FullRowSelect = True
                .MultiSelect = True
                '.StateImageList = ImgLista
                .SmallImageList = ImgLista
                .HideSelection = False
                .CheckBoxes = False
                .Items.Clear()
                .Columns.Clear()
                .GridLines = True
            End With
            'Inicializa la imagen ' se debe tomar en cuantas las imagenes y las columnas k agrega
            vConta = 7

            For Each col As DataColumn In dt.Columns
                vConta = vConta - 1
                lvwDatos.Columns.Add(col.ColumnName, col.ColumnName, Nothing, HorizontalAlignment.Left, vConta)
            Next

            If Not Progress Is Nothing Then
                Progress.Maximum = dt.Rows.Count
                Progress.Value = 0
            End If

            For Each row As DataRow In dt.Rows
                vConta = vConta + 1
                If Not Progress Is Nothing Then
                    Progress.Value = Progress.Value + 1
                End If

                lstElemento = New ListViewItem(row(0).ToString(), 7)

                'lstElemento.Text = row(0).ToString()
                'lstElemento.ImageKey = 4
                For intcontador As Integer = 1 To dt.Columns.Count - 1
                    lstElemento.SubItems.Add(row(intcontador).ToString())
                Next
                lvwDatos.Items.Add(lstElemento)
            Next
            lvwDatos.Sorting = SortOrder.Ascending
            lvwDatos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)


        Catch ex As System.Exception
            bolResultado = False
        End Try
        Return bolResultado
    End Function

    Private Sub TextHoja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextHoja.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            pIniciar()
            CargaListaCorreos()
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Function CrearTablaGuardar() As DataTable
        Dim miTabla As DataTable = New DataTable("TBGUARDAR")
        Dim miColumna As DataColumn
        CrearTablaGuardar = Nothing



        miColumna = New DataColumn("txtConocidoComo")

        With miColumna
            .DataType = System.Type.GetType("System.String")
            .MaxLength = 50
            .AllowDBNull = True
            miTabla.Columns.Add(miColumna)
        End With


        miColumna = New DataColumn("txtCorreoEnvia")

        With miColumna
            .DataType = System.Type.GetType("System.String")
            .MaxLength = 50
            miTabla.Columns.Add(miColumna)
        End With

        miColumna = New DataColumn("txtContrasena")

        With miColumna
            .DataType = System.Type.GetType("System.String")
            .MaxLength = 50
            miTabla.Columns.Add(miColumna)
        End With


        miColumna = New DataColumn("txtTituloCorreo")

        With miColumna
            .DataType = System.Type.GetType("System.String")
            .MaxLength = 80
            miTabla.Columns.Add(miColumna)
        End With

        miColumna = New DataColumn("txtURL")

        With miColumna
            .DataType = System.Type.GetType("System.String")
            .MaxLength = 100
            miTabla.Columns.Add(miColumna)
        End With


        miColumna = New DataColumn("Adjuntos")

        With miColumna
            .DataType = System.Type.GetType("System.String")
            .MaxLength = 5000
            miTabla.Columns.Add(miColumna)
        End With

        miColumna = New DataColumn("UbicaImgInic")

        With miColumna
            .DataType = System.Type.GetType("System.String")
            .MaxLength = 100
            miTabla.Columns.Add(miColumna)
        End With

        miColumna = New DataColumn("UbicaImgFinal")

        With miColumna
            .DataType = System.Type.GetType("System.String")
            .MaxLength = 100
            miTabla.Columns.Add(miColumna)
        End With


        CrearTablaGuardar = miTabla

        Return CrearTablaGuardar

    End Function

    Private Sub GuardarInfoCorreos(ByVal filename As String)
        Dim Dt As New DataTable
        Dim Fila As DataRow
        Dim i As Integer = 0
        Dim vAdjuntos As String = ""




        Try
            Dt = CrearTablaGuardar()
            Fila = Dt.NewRow
            Fila("txtConocidoComo") = txtConocidoComo.Text.Trim
            Fila("txtCorreoEnvia") = (txtCorreoEnvia.Text.Trim)
            Fila("txtContrasena") = (txtContrasena.Text.Trim)
            Fila("txtTituloCorreo") = txtTituloCorreo.Text.Trim
            Fila("txtURL") = txtURL.Text.Trim
            If m_arAttachment.Count > 0 Then
                For i = 0 To m_arAttachment.Count - 1
                    vAdjuntos += m_arAttachment(i) & ";"
                Next i
            End If
            If vAdjuntos.Length > 0 Then
                Fila("Adjuntos") = vAdjuntos
            Else
                Fila("Adjuntos") = ""
            End If

            If ChkImgInicio.Checked Then
                Fila("UbicaImgInic") = txtImgInicio.Text.ToString.Trim
            Else
                Fila("UbicaImgInic") = ""
            End If

            If chkImgFinal.Checked Then
                Fila("UbicaImgFinal") = TxtImgFinal.Text.ToString.Trim
            Else
                Fila("UbicaImgFinal") = ""
            End If

            Dt.Rows.Add(Fila)
            Dt.WriteXml(filename)

            MsgBox("Archivo guardado en la siguiente ubicación, " & filename, MsgBoxStyle.Information, Application.ProductName)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub OpenInfoCorreos(ByVal filename As String)
        Dim dt As New DataTable
        Dim ds As DataSet
        Dim vAdjuntos As String = ""
        Dim vArray_Attach() As String

        Try


            ds = New DataSet
            ds.ReadXml(filename)
            dt = ds.Tables(0)

            If dt.Rows.Count > 0 Then
                txtConocidoComo.Text = dt.Rows(0)("txtConocidoComo").ToString
                txtCorreoEnvia.Text = (dt.Rows(0)("txtCorreoEnvia").ToString)
                txtContrasena.Text = (dt.Rows(0)("txtContrasena").ToString)
                txtTituloCorreo.Text = dt.Rows(0)("txtTituloCorreo").ToString
                txtURL.Text = dt.Rows(0)("txtURL").ToString
                vAdjuntos = dt.Rows(0)("Adjuntos").ToString

                vArray_Attach = Split(vAdjuntos, ";")

                Dim nLen As Integer = vArray_Attach.Length
                Dim i As Integer = 0

                For i = 0 To nLen - 1
                    Dim fileNameOpen As String = vArray_Attach(i)
                    If fileNameOpen <> "" Then
                        m_arAttachment.Add(vArray_Attach(i))
                        Dim pos As Integer = fileNameOpen.LastIndexOf("\")
                        If pos <> -1 Then
                            fileNameOpen = fileNameOpen.Substring(pos + 1)
                        End If
                        textAttachments.Text += fileNameOpen.ToString
                        textAttachments.Text += ";"
                    End If
                Next

                If dt.Rows(0)("UbicaImgInic").ToString.Length > 0 Then
                    txtImgInicio.Text = dt.Rows(0)("UbicaImgInic").ToString.Trim
                    ChkImgInicio.Checked = True
                    Pic_Inicio.Load(txtImgInicio.Text)
                End If

                If dt.Rows(0)("UbicaImgFinal").ToString.Length > 0 Then
                    TxtImgFinal.Text = dt.Rows(0)("UbicaImgFinal").ToString.Trim
                    chkImgFinal.Checked = True
                    Pic_Final.Load(TxtImgFinal.Text)
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
    Private Function GetAttachment(ByVal par_Adjuntos As String) As ArrayList
        Dim vArray() As String
        GetAttachment = Nothing
        Dim vArrayList As New ArrayList

        vArray = Split(par_Adjuntos, ";")

        For Each Str As String In vArray
            GetAttachment.Add(Str)
        Next

    End Function

    Public Sub TiempoEnEspera(ByVal valor As Boolean)
        If valor = True Then
            T.Start()
            TimeWait = vMiliSegundos
        Else
            T.Stop()
        End If
    End Sub

    Private Sub T_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T.Tick
        Me.t_ShowTime()

    End Sub

    Private Sub Btn_AbrirInfoCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Function ConvertirImg(ByVal StrRuta As String, ByVal StrNameImg As String, ByVal vTerminacion As String) As String
        Dim StrImagen As String
        Dim inFile As FileStream
        Dim binaryData() As Byte

        ConvertirImg = ""

        'Compone la ruta de la imagen
        StrImagen = StrRuta & StrNameImg & vTerminacion
        StrImagen = Replace(StrImagen, "/", "\")
        StrImagen = Mid(StrImagen, 9, StrImagen.Length)
        ' Lee la imagen
        inFile = New System.IO.FileStream(StrImagen,
                                          System.IO.FileMode.Open,
                                          System.IO.FileAccess.Read)
        ReDim binaryData(inFile.Length)
        Dim bytesRead As Long = inFile.Read(binaryData,
                                               0,
                                            inFile.Length)
        inFile.Close()

        ' Convierte la imagen binaria a codificacion Base64.
        Dim base64String As String

        base64String = System.Convert.ToBase64String(binaryData,
                                                     0,
                                                    binaryData.Length)

        ' Devuelve el codigo para visualizar la imagen
        ConvertirImg = "data:image/jpg;base64," & base64String

        Return ConvertirImg
    End Function

    Private Function ConvertirImg64(ByVal StrRuta As String) As String
        Dim StrImagen As String
        Dim inFile As FileStream
        Dim binaryData() As Byte

        'Compone la ruta de la imagen
        StrImagen = StrRuta
        StrImagen = Replace(StrImagen, "/", "\")
        StrImagen = Mid(StrImagen, 9, StrImagen.Length)
        ' Lee la imagen
        inFile = New System.IO.FileStream(StrRuta,
                                          System.IO.FileMode.Open,
                                          System.IO.FileAccess.Read)
        ReDim binaryData(inFile.Length)
        Dim bytesRead As Long = inFile.Read(binaryData,
                                               0,
                                            inFile.Length)
        inFile.Close()

        ' Convierte la imagen binaria a codificacion Base64.
        Dim base64String As String

        base64String = System.Convert.ToBase64String(binaryData,
                                                     0,
                                                    binaryData.Length)

        ' Devuelve el codigo para visualizar la imagen


        Return "data:image/jpg;base64," & base64String
    End Function

    Private Sub BuscarImagen(ByVal Par_Direccion As String)
        Dim vHTML As HtmlDocument

        Dim vstrImg As String
        Dim vImgName As String
        Dim vPos As String
        Dim vEspacios As Integer = 5
        Dim vCarpeta As String = ""
        Dim vTerminacion As String = ""
        Dim vDirectorio As String = DirecciondeArchivo(Par_Direccion)
        Dim vImgBASE64 As String = ""
        Dim x As Integer = 0

        'vHTML2 = GetFileContents(WebBrowserEmail.Document.Body.InnerHtml)
        vHTML = WebBrowserEmail.Document

        If Not vHTML Is Nothing Then
            If vHTML.Images.Count > 0 Then
                For i As Integer = 0 To vHTML.Images.Count - 1
                    vstrImg = vHTML.Images.Item(i).OuterHtml.Substring(1)
                    vstrImg = Replace(vstrImg, ">", "")
                    vstrImg = vstrImg.Substring(0, vstrImg.Length - 1).Trim
                    vPos = InStrRev(vstrImg, "src", Len(vstrImg), CompareMethod.Text)
                    vImgName = Mid(vstrImg, vPos + vEspacios, Len(vstrImg))
                    vPos = 0
                    vPos = InStr(1, vImgName.ToString, ".", CompareMethod.Text)
                    vTerminacion = Mid(vImgName, vPos, 4)
                    vImgName = Mid(vImgName, 1, vPos - 1)

                    vPos = 0
                    vPos = InStr(1, vImgName.ToString, "_", CompareMethod.Text)
                    If vPos > 0 Then
                        vCarpeta = Mid(vImgName, 1, vPos - 1)
                        vImgName = Mid(vImgName, vPos + 1, vImgName.Length)
                        MsgBox(vDirectorio & "/" & vCarpeta & "/" & vImgName & vTerminacion)
                        vImgBASE64 = ConvertirImg(vDirectorio & "/" & vCarpeta & "/", vImgName, vTerminacion)
                    Else
                        vPos = InStrRev(vImgName.ToString, "\", vImgName.Length, CompareMethod.Text)
                        If vPos > 0 Then
                            vImgName = Mid(vImgName, vPos + 1, vImgName.Length)
                        Else
                            vPos = InStrRev(vImgName.ToString, "/", vImgName.Length, CompareMethod.Text)
                            If vPos Then

                                x = InStrRev(vImgName, "/", vPos - 1, CompareMethod.Text)
                                vCarpeta = Mid(vImgName, x + 1, vImgName.Length - vPos - 1)
                                vImgName = Mid(vImgName, vPos + 1, vImgName.Length)
                                vImgBASE64 = ConvertirImg(vDirectorio & "/" & vCarpeta & "/", vImgName, vTerminacion)
                            End If
                        End If
                    End If
                Next
            End If
        End If

    End Sub

    Public Function GetFileContents(ByVal FullPath As String,
        Optional ByRef ErrInfo As String = "") As String
        GetFileContents = ""
        Dim strContents As String
        Dim objReader As StreamReader
        Try
            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
            Return strContents
        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try
    End Function
    Public Function GetFileContents(ByVal vStream As Stream, Optional ByRef ErrInfo As String = "") As String
        GetFileContents = ""
        Dim strContents As String
        Dim objReader As StreamReader
        Try
            'WebBrowserEmail.DocumentStream
            objReader = New StreamReader(vStream)
            strContents = objReader.ReadToEnd()
            objReader.Close()
            Return strContents
        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try
    End Function

    Public Function ObtieneUbicMaquina(ByVal vUbicacion As String) As String
        Dim IsWeb As Boolean = False
        Dim vTipo As Integer = 0
        Dim Valor As String = ""
        ObtieneUbicMaquina = ""

        Valor = Mid(vUbicacion, 1, 4)


        Select Case Valor.ToString.ToLower
            Case Is = "file"
                ObtieneUbicMaquina = Mid(vUbicacion, 9, vUbicacion.Length)
            Case Is = "http"
                ObtieneUbicMaquina = vUbicacion
        End Select

    End Function

#Region "Initialize Fonts List"
    Protected Sub InitFonts()
        Dim arFonts() As String = {"Estilo de Fuente...",
                  "Allegro BT",
                  "Arial",
                  "Arial Baltic",
                  "Arial Black",
                  "Arial CE",
                  "Arial CYR",
                  "Arial Greek",
                  "Arial Narrow",
                  "Arial TUR",
                  "AvantGarde Bk BT",
                  "BankGothic Md BT",
                  "Basemic",
                  "Basemic Symbol",
                  "Basemic Times",
                  "Batang",
                  "BatangChe",
                  "Benguiat Bk BT",
                  "BernhardFashion BT",
                  "BernhardMod BT",
                  "Book Antiqua",
                  "Bookman Old Style",
                  "Bremen Bd BT",
                  "Century Gothic",
                  "Charlesworth",
                  "Comic Sans MS",
                  "CommonBullets",
                  "CopprplGoth Bd BT",
                  "Courier",
                  "Courier New",
                  "Courier New Baltic",
                  "Courier New CE",
                  "Courier New CYR",
                  "Courier New Greek",
                  "Courier New TUR",
                  "Dauphin",
                  "Dotum",
                  "DotumChe",
                  "Dungeon",
                  "English111 Vivace BT",
                  "Estrangelo Edessa",
                  "Fixedsys",
                  "Franklin Gothic Medium",
                  "Futura Lt BT",
                  "Futura Md BT",
                  "Futura XBlk BT",
                  "FuturaBlack BT",
                  "Garamond",
                  "Gautami",
                  "Georgia",
                  "GoudyHandtooled BT",
                  "GoudyOlSt BT",
                  "Gulim",
                  "GulimChe",
                  "Gungsuh",
                  "GungsuhChe",
                  "Haettenschweiler",
                  "Humanst521 BT",
                  "Impact",
                  "Kabel Bk BT",
                  "Kabel Ult BT",
                  "Kingsoft Phonetic Plain",
                  "Latha",
                  "Lithograph",
                  "LithographLight",
                  "Lucida Console",
                  "Lucida Sans Unicode",
                  "Mangal",
                  "Marlett",
                  "Microsoft Sans Serif",
                  "MingLiU",
                  "Modern",
                  "Monotype Corsiva",
                  "MS Gothic",
                  "MS Mincho",
                  "MS Outlook",
                  "MS PGothic",
                  "MS PMincho",
                  "MS Sans Serif",
                  "MS Serif",
                  "MS UI Gothic",
                  "MT Extra",
                  "MV Boli",
                  "Myriad Condensed Web",
                  "Myriad Web",
                  "OzHandicraft BT",
                  "Palatino Linotype",
                  "PMingLiU",
                  "PosterBodoni BT",
                  "Raavi",
                  "Roman",
                  "Script",
                  "Serifa BT",
                  "Serifa Th BT",
                  "Shruti",
                  "Small Fonts",
                  "Souvenir Lt BT",
                  "Staccato222 BT",
                  "Swiss911 XCm BT",
                  "Sylfaen",
                  "Symbol",
                  "System",
                  "Tahoma",
                  "Terminal",
                  "Times New Roman",
                  "Times New Roman Baltic",
                  "Times New Roman CE",
                  "Times New Roman CYR",
                  "Times New Roman Greek",
                  "Times New Roman TUR",
                  "Trebuchet MS",
                  "Tunga",
                  "TypoUpright BT",
                  "Verdana",
                  "VisualUI",
                  "Webdings",
                  "Wingdings",
                  "Wingdings 2",
                  "Wingdings 3",
                  "WP Arabic Sihafa",
                  "WP ArabicScript Sihafa",
                  "WP BoxDrawing",
                  "WP CyrillicA",
                  "WP CyrillicB",
                  "WP Greek Century",
                  "WP Greek Courier",
                  "WP Greek Helve",
                  "WP Hebrew David",
                  "WP IconicSymbolsA",
                  "WP IconicSymbolsB",
                  "WP Japanese",
                  "WP MathA",
                  "WP MathB",
                  "WP MathExtendedA",
                  "WP MathExtendedB",
                  "WP MultinationalA Courier",
                  "WP MultinationalA Helve",
                  "WP MultinationalA Roman",
                  "WP MultinationalB Courier",
                  "WP MultinationalB Helve",
                  "WP MultinationalB Roman",
                  "WP Phonetic",
                  "WP TypographicSymbols",
                  "WST_Czec",
                  "WST_Engl",
                  "WST_Fren",
                  "WST_Germ",
                  "WST_Ital",
                  "WST_Span",
                  "WST_Swed",
                  "ZapfEllipt BT",
                  "Zurich Ex BT"}

        Dim i As Integer
        Dim nCount As Integer = arFonts.Length
        For i = 0 To nCount - 1
            lstFont.Items.Add(arFonts(i))
        Next

        lstFont.SelectedIndex = 0
        lstSize.Items.Add("Tamaño de fuente ... ")
        For i = 1 To 7
            lstSize.Items.Add(i)
        Next
        lstSize.SelectedIndex = 0
    End Sub
#End Region

#Region "Botones de Edición de texto"




    Private Sub GuardarHTML()
        m_htmlDoc.execCommand("SaveAs", False, "Correo.html")
        WebBrowserEmail.Focus()
    End Sub






    Private Sub BtnJustifyNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        m_htmlDoc.execCommand("RemoveFormat", False, Nothing)
        m_htmlDoc.execCommand("JustifyNone", False, Nothing)
        WebBrowserEmail.Focus()
    End Sub
    Public Sub CrearHipervinculo(ByVal PaginaWeb As String)
        Dim vUrl As String = PaginaWeb

        If vUrl.ToString <> "" Then
            m_htmlDoc.execCommand("CreateLink", False, vUrl)
            WebBrowserEmail.Focus()
        Else
            MsgBox("Debe digitar la URL del hipervinculo para continuar...", MsgBoxStyle.Information, Application.ProductName)
        End If
    End Sub

#End Region

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btn_BorrarAdjuntos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtURL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtURL.TextChanged
        AucompletarCache(txtURL)
    End Sub
    Private Function CrearArchivoHTML(ByVal NameFile As String) As String
        Dim sRenglon As String = Nothing
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim ContenidoArchivo As String = Nothing
        ' Donde guardamos los paths de los archivos que vamos a estar utilizando ..
        Dim PathArchivo As String
        CrearArchivoHTML = ""
        'Tipo = 1  = Datatable 
        'Tipo = 2 = Lista 
        Dim i As Integer = 0

        Try




            If Directory.Exists(DirecciondeArchivo(NameFile)) = False Then ' si no existe la carpeta se crea
                Directory.CreateDirectory(DirecciondeArchivo(NameFile))
            End If

            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            PathArchivo = NameFile & Format(Today.Date, "ddMMyyyy") & ".htm" ' Se determina el nombre del archivo con la fecha actual

            'verificamos si existe el archivo

            If File.Exists(NombredeArchivo(PathArchivo)) Then
                strStreamW = File.Open(PathArchivo, FileMode.Open) 'Abrimos el archivo
            Else
                strStreamW = File.Create(PathArchivo) ' lo creamos
            End If

            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.UTF8) ' tipo de codificacion para escritura



            'strStreamWriter.Write(GetFileContents(WebBrowserEmail.DocumentStream))
            strStreamWriter.Write(WebBrowserEmail.Document.Body.InnerHtml)


            strStreamWriter.Close() ' cerramos
            MsgBox("El Archivo " & NameFile & Format(Today.Date, "ddMMyyyy") & ".htm" & " ha sido creado con éxito", MsgBoxStyle.Information, Application.ProductName)
            CrearArchivoHTML = PathArchivo
            Return CrearArchivoHTML

        Catch ex As Exception
            MsgBox("Error al Guardar la información en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
            strStreamWriter.Close() ' cerramos
        End Try
    End Function





    Private Sub Btn_Adelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Adelante.Click
        Dim returnValue As Boolean
        returnValue = WebBrowserEmail.GoForward
    End Sub

    Private Sub Btn_Atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Atras.Click
        Dim returnValue As Boolean
        returnValue = WebBrowserEmail.GoBack
    End Sub


    Private Sub pShowToptip()
        ' Create the ToolTip and associate with the Form container.
        Dim toolTipp As New ToolTip()

        ' Set up the delays for the ToolTip.
        With toolTipp
            .AutoPopDelay = 5000
            .InitialDelay = 1000
            .ReshowDelay = 500
            ' Force the ToolTip text to be displayed whether or not the form is active.
            .ShowAlways = True

            ' Set up the ToolTip text for the Button and Checkbox.
            .SetToolTip(Me.ChkImgInicio, "Si este check no está activo, no se guarda la información de la imagen inicial.")
            .SetToolTip(Me.chkImgFinal, "Si este check no está activo, no se guarda la información de la imagen final.")
            .SetToolTip(Me.ChkAddImg, "Agregar imagenes al inicio o al final del correo.")
            .SetToolTip(Me.RBtn_Hotmail, "Activa el envio de correos por el servidor de  Hotmail.")
            .SetToolTip(Me.RBtn_MS_Exchange, "Activa el envio de correos por el servidor de la UNED.")
            .SetToolTip(Me.RBtnGmail, "Activa el envio de correos por el servidor de GMAIL.")
            .SetToolTip(Me.txtCorreoEnvia, "Correo remitente.")
            .SetToolTip(Me.txtContrasena, "Contraseña del correo remitente.")
            .SetToolTip(Me.txtConocidoComo, "Nombre asociado con la dirección del correo electrónico, este campo puede ser vacio.")
            .SetToolTip(Me.txtTituloCorreo, "Asunto del correo.")
            .SetToolTip(Me.TextHoja, "Nombre de la hoja de excel, que cotiene los correos destinatarios")
            .SetToolTip(Me.txtdireccion, "Ubicación física de mi hoja electronica encargada de contener los correos electrónicos.")
            .SetToolTip(Me.txtURL, "Dirección física o Web, donde se ubica el contenido del correo.")
            .SetToolTip(Me.txtImgInicio, "Ubicación de la imagen al inicial del documento.")
            .SetToolTip(Me.TxtImgFinal, "Ubicación de la imagen al final del documento.")
            .SetToolTip(Me.IconBtnFolderOpen, "Abre un archivo de correo electrónico en formato XML, el mismo carga un Archivo Web en el contenido del correo.")
            .SetToolTip(Me.IconBtnAddLink, "Agregar un Hipervículo en el contenido.")
            .SetToolTip(Me.Btn_Adelante, "Ir a la página anterior.")
            .SetToolTip(Me.Btn_Atras, "Ir a la página siguiente.")
            .SetToolTip(Me.IconBtnClearAttachment, "Limpia los datos adjuntos")
            .SetToolTip(Me.Btn_InicEditor, "Limpia el contenido del correo.")
            .SetToolTip(Me.IconBtnAttachment, "Agrega datos adjuntos.")
            .SetToolTip(Me.btnB, "Negrita")
            .SetToolTip(Me.BtnBackColor, "Cambia el aspecto del texto, como si estuviera marcado por un marcador.")
            .SetToolTip(Me.btnC, "Color de fuente.")
            .SetToolTip(Me.BtncFileLp, "Guarda los correos depurados, en un archivo de texto.")
            .SetToolTip(Me.BtnCorreosInvalidos, "Guarda los correos Inválidos, en un archivo de texto.")
            .SetToolTip(Me.BtnCorresEnviados, "Guarda los correos Enviados, en un archivo de texto.")
            .SetToolTip(Me.IconBtnSendMail, "Envia el correo a los destinatarios.")
            .SetToolTip(Me.BtnExaminar, "Examina en la PC, archivos de excel para cargar correos electrónicos.")
            .SetToolTip(Me.BtnGuardaDuplicados, "Guarda los correos Duplicados, en un archivo de texto.")
            .SetToolTip(Me.IconBtnSave, "Guarda la información del correo para su reutilización, local.")
            .SetToolTip(Me.btnI, "Cursiva")
            .SetToolTip(Me.BtnImgFinal, "Examina en la PC, para obtener la imagen final.")
            .SetToolTip(Me.BtnImgInic, "Examina en la PC, para obtener la imagen Inicial.")
            .SetToolTip(Me.BtnIr, "Buscar la página web, escrita en la URL.")
            .SetToolTip(Me.BtnJustifyCenter, "Centrar el texto.")
            .SetToolTip(Me.BtnJustifyFull, "Justificar.")
            .SetToolTip(Me.BtnJustifyLeft, "Alinear texto a la izquierda.")
            .SetToolTip(Me.BtnRemoteFormat, "Borrar formatos.")
            .SetToolTip(Me.BtnJustifyRight, "Alinear texto a la derecha.")
            .SetToolTip(Me.BtnNOEnviados, "Guarda los correos NO enviados, en un archivo de texto.")
            .SetToolTip(Me.IconBtnNew, "Inicializa el toda la pantalla.")
            .SetToolTip(Me.BtnOpenUrl, "Abre un archivo web, que se carga en el contenido del correo.")
            .SetToolTip(Me.btnP, "Inserta una imagen en el contenido del correo.")
            .SetToolTip(Me.BtnCargar, "Carga correos según el archivo de excel y la hoja seleccionada.")
            .SetToolTip(Me.btnU, "Color de fuente.")
            .SetToolTip(Me.IconBtnInsertLine, "Inserta una línea horizontal.")

        End With


    End Sub

    Private Sub cboSheetBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSheetBooks.SelectedIndexChanged
        SelectTable()
    End Sub

    Public Sub SelectTable()

        Dim tablename = cboSheetBooks.SelectedItem.ToString()


        Dim _tabla As New DataTable
        _tabla.Clear()
        _tabla = ds.Tables(0)

        dtCorreos.Clear()

        dtCorreos = CrearTabla()

        If _tabla.Rows.Count > 0 Then
            For i = 0 To _tabla.Rows.Count - 1
                lblCorreosCargados.Text = i + 1
                AddFilasCorreos(_tabla.Rows(i)(0).ToString, "Estado:Sin Enviar")
            Next
        End If

        lblCorreosDuplicados.Text = LbDuplicados.Items.Count
        lblCorreosInvalidos.Text = lbCorreosInvalidos.Items.Count

        RellenarListview(dtCorreos, lvCorreos, Imgtree, Pb)

    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        Bold()
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        Italic()
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        Underline()
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        ColorTexto()
    End Sub

    Private Sub BtnBackColor_Click(sender As Object, e As EventArgs) Handles BtnBackColor.Click
        BackColorText()
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        AddPicture()
    End Sub
    Private Sub Bold()
        m_htmlDoc.execCommand("Bold", False, Nothing)
        WebBrowserEmail.Focus()
    End Sub
    Private Sub Italic()
        m_htmlDoc.execCommand("Italic", False, Nothing)
        WebBrowserEmail.Focus()
    End Sub
    Private Sub Underline()
        m_htmlDoc.execCommand("Underline", False, Nothing)
        WebBrowserEmail.Focus()
    End Sub
    Private Sub JustifyFull()
        m_htmlDoc.execCommand("JustifyFull", False, Nothing)
        WebBrowserEmail.Focus()
    End Sub

    Private Sub JustifyCenter()
        m_htmlDoc.execCommand("JustifyCenter", False, Nothing)
        WebBrowserEmail.Focus()
    End Sub

    Private Sub JustifyLeft()
        m_htmlDoc.execCommand("JustifyLeft", False, Nothing)
        WebBrowserEmail.Focus()
    End Sub

    Private Sub BtnJustifyFull_Click(sender As Object, e As EventArgs) Handles BtnJustifyFull.Click
        JustifyFull()
    End Sub

    Private Sub BtnJustifyCenter_Click(sender As Object, e As EventArgs) Handles BtnJustifyCenter.Click
        JustifyCenter()
    End Sub


    Private Sub InsertHorizontalRule()
        m_htmlDoc.execCommand("InsertHorizontalRule", False, Nothing)
    End Sub

    Private Sub BtnJustifyRight_Click(sender As Object, e As EventArgs) Handles BtnJustifyRight.Click
        JustifyRight()
    End Sub




    Private Sub Btn_InicEditor_Click(sender As Object, e As EventArgs) Handles Btn_InicEditor.Click
        Clean()
    End Sub

    Private Sub BtnJustifyLeft_Click(sender As Object, e As EventArgs) Handles BtnJustifyLeft.Click
        JustifyLeft()
    End Sub
    Private Sub lstFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFont.SelectedIndexChanged
        SelectFont()
    End Sub

    Private Sub lstSize_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstSize.SelectedIndexChanged
        SelectSizeFont()
    End Sub


    Private Sub ColorTexto()
        If colorDlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim v As String = String.Format("#{0:x2}{1:x2}{2:x2}", colorDlg.Color.R,
                 colorDlg.Color.G,
                 colorDlg.Color.B)
            m_htmlDoc.execCommand("ForeColor", False, v)
        End If
        WebBrowserEmail.Focus()
    End Sub

    Private Sub AddPicture()
        attachmentDlg.Reset()
        'gattachmentDlg.Multiselect = True
        attachmentDlg.CheckFileExists = True
        attachmentDlg.CheckPathExists = True
        attachmentDlg.Title = "Seleccionar archivos"
        attachmentDlg.Filter = "Archivos de imagen(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|Todos los archivos (*.*)|*.*"

        If (attachmentDlg.ShowDialog() <> Windows.Forms.DialogResult.OK) Then
            Exit Sub
        End If

        Dim attachments() As String = attachmentDlg.FileNames
        Dim nLen As Integer = attachments.Length
        Dim i As Integer = 0
        For i = 0 To nLen - 1
            Dim fileName As String = attachments(i)

            Dim file = ConvertirImg64(fileName)
            m_htmlDoc.execCommand("InsertImage", False, file)
            'm_htmlDoc.execCommand("InsertHorizontalRule", False, Nothing)
        Next
    End Sub

    Private Sub BackColorText()
        If colorDlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim v As String = String.Format("#{0:x2}{1:x2}{2:x2}", colorDlg.Color.R,
                 colorDlg.Color.G,
                 colorDlg.Color.B)
            m_htmlDoc.execCommand("BackColor", False, v)
        End If
        WebBrowserEmail.Focus()
    End Sub

    Private Sub JustifyRight()
        m_htmlDoc.execCommand("JustifyRight", False, Nothing)
        WebBrowserEmail.Focus()
    End Sub

    Private Sub AddLink()
        Dim f As New FrmHiperV
        f.ShowDialog()
        Dim vResultado As String = f.CboTipoCorreo.SelectedItem.ToString & f.txtHpv.Text
        CrearHipervinculo(vResultado)
    End Sub

    Private Sub Clean()
        txtURL.Clear()
        m_htmlDoc.write("")
        m_htmlDoc.close()

        m_htmlDoc = CType(WebBrowserEmail.Document.DomDocument, mshtml.IHTMLDocument2)
        m_htmlDoc.designMode = "on"
        'InitFonts()
        ''WebBrowserEmail.Navigate("about:blank")

        WebBrowserEmail.Focus()

    End Sub

    Private Sub SelectFont()
        Dim font As String = lstFont.Text
        lstFont.SelectedIndex = 0
        m_htmlDoc.execCommand("fontname", False, font)
        WebBrowserEmail.Focus()

    End Sub

    Private Sub SelectSizeFont()
        Dim size As String = lstSize.Text
        lstSize.SelectedIndex = 0
        m_htmlDoc.execCommand("fontsize", False, size)
        WebBrowserEmail.Focus()
    End Sub



    Private Sub ChkImgInicio_CheckedChanged(sender As Object, e As EventArgs) Handles ChkImgInicio.CheckedChanged
        HabilitaCargaImgInicio(ChkImgInicio.Checked, 1)
    End Sub

    Private Sub Restaurar_Click(sender As Object, e As EventArgs) Handles Restaurar.Click
        Me.WindowState = FormWindowState.Normal
        Maximizar.Visible = True
        Restaurar.Visible = False
    End Sub

    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        Me.WindowState = FormWindowState.Maximized
        Maximizar.Visible = False
        Restaurar.Visible = True
    End Sub

    Private Sub Maximizar_Click(sender As Object, e As EventArgs) Handles Maximizar.Click
        Me.WindowState = FormWindowState.Maximized
        Maximizar.Visible = False
        Restaurar.Visible = True
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Close()
    End Sub

    Private Sub IconBtnLoadMails_Click(sender As Object, e As EventArgs) Handles IconBtnLoadMails.Click
        pIniciar()
        'CargaListaCorreos()
        UploadMails()
    End Sub

    Private Sub lblHoja_Click(sender As Object, e As EventArgs) Handles lblHoja.Click

    End Sub

    Private Sub LbNoEnviados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbNoEnviados.SelectedIndexChanged

    End Sub

    Private Sub IconBtnLeft_Click(sender As Object, e As EventArgs) Handles IconBtnLeft.Click
        Dim returnValue As Boolean
        returnValue = WebBrowserEmail.GoBack
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconBtnRigth.Click
        Dim returnValue As Boolean
        returnValue = WebBrowserEmail.GoForward
    End Sub

    Private Sub IconBtnIr_Click(sender As Object, e As EventArgs) Handles IconBtnIr.Click
        Ir_Web()
    End Sub
    Public Sub OpenURL()

        Dim openFD As New OpenFileDialog()
        Dim vRepuesta As New MsgBoxResult
        Dim FileHTML As String = ""
        With openFD
            .Title = "Seleccionar archivos"
            If rBtn_HTML.Checked = True Then
                .Filter = "Páginas Web (*.htm;*.html;*.mht)|*.htm;*.html;*.mht"
            ElseIf rBtn_Word.Checked Then
                .Filter = "Microsoft Word(*.doc;*.docx)|*.doc;*.docx"
            End If
            ' "Archivos de imagen(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|Todos los archivos (*.*)|*.*";
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txtURL.Text = .FileName
                If txtURL.ToString.Length > 0 Then
                    If rBtn_HTML.Checked = True Then
                        WebBrowserEmail.Navigate(txtURL.Text)
                    ElseIf rBtn_Word.Checked Then
                        FileHTML = DirecciondeArchivo(txtURL.Text) & "\" & NombredeArchivo(txtURL.Text, True) & ".htm"
                        If File.Exists(FileHTML) Then
                            WebBrowserEmail.Navigate(FileHTML)
                        Else
                            vRepuesta = MsgBox("Se va a generar una copia de este archivo (" & NombredeArchivo(txtURL.Text) & ") de Microsoft Word, a Archivo WEB." & Chr(13) &
                                               "en la siguiente dirección : " & DirecciondeArchivo(txtURL.Text) & Chr(13) &
                                               "¿desea continuar ...?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Application.ProductName)
                            If vRepuesta = MsgBoxResult.Yes Then
                                WebBrowserEmail.Navigate(ConvertFileWordToHTML(txtURL.Text))
                            Else
                                txtURL.Text = ""
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
        End With
    End Sub

    Public Sub AttachmentFiles()
        attachmentDlg.Reset()
        attachmentDlg.Multiselect = True
        attachmentDlg.CheckFileExists = True
        attachmentDlg.CheckPathExists = True
        If attachmentDlg.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Dim attachments() As String = attachmentDlg.FileNames
        Dim nLen As Integer = attachments.Length
        Dim i As Integer = 0
        For i = 0 To nLen - 1
            m_arAttachment.Add(attachments(i))
            Dim fileName As String = attachments(i)
            Dim pos As Integer = fileName.LastIndexOf("\")
            If pos <> -1 Then
                fileName = fileName.Substring(pos + 1)
            End If
            textAttachments.Text += fileName.ToString
            textAttachments.Text += ";"
        Next

    End Sub

    Private Sub IconBtnAttachment_Click(sender As Object, e As EventArgs) Handles IconBtnAttachment.Click
        AttachmentFiles()
    End Sub

    Public Sub ClearAttachment()
        m_arAttachment.Clear()
        textAttachments.Text = ""
        WebBrowserEmail.Focus()
    End Sub

    Private Sub IconBtnClearAttachment_Click(sender As Object, e As EventArgs) Handles IconBtnClearAttachment.Click
        ClearAttachment()
    End Sub

    Public Sub OpenFileMailFolder()
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos de XML(*.Xml)|*.Xml"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                OpenInfoCorreos(.FileName)
                If txtURL.Text <> "" Then
                    Ir_Web()
                End If
            End If
        End With
    End Sub

    Private Sub IconBtnFolderOpen_Click(sender As Object, e As EventArgs) Handles IconBtnFolderOpen.Click
        OpenFileMailFolder()
    End Sub

    Public Sub New_Screen()


        pIniciar()

        txtCorreoEnvia.Clear()
        txtContrasena.Clear()
        txtConocidoComo.Clear()
        lvCorreos.Items.Clear()
        dtCorreos.Clear()
        txtdireccion.Clear()
        TextHoja.Clear()
        txtTituloCorreo.Clear()
        txtURL.Clear()
        m_arAttachment.Clear()
        textAttachments.Text = ""
        m_htmlDoc.write("")
        m_htmlDoc.close()
        chkImgFinal.Checked = False
        TxtImgFinal.Clear()
        ChkImgInicio.Checked = False
        txtImgInicio.Clear()
        Pic_Inicio.Image = Nothing
        Pic_Final.Image = Nothing
        ChkAddImg.Checked = False
        RadioBtnCheck()
    End Sub

    Private Sub IconBtnNew_Click(sender As Object, e As EventArgs) Handles IconBtnNew.Click
        New_Screen()
    End Sub

    Public Sub Save()
        Dim openFD As New SaveFileDialog()
        With openFD
            .Title = "Guardar archivos"
            .Filter = "Archivos XML (*.XML)|*.XML"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                'If txtURL.Text = "" Or txtURL.Text = "about:blank" Then
                txtURL.Text = CrearArchivoHTML(.FileName)
                'GuardarHTML()
                'End If
                GuardarInfoCorreos(.FileName)
            End If
        End With
    End Sub

    Private Sub IconBtnSave_Click(sender As Object, e As EventArgs) Handles IconBtnSave.Click
        Save()
    End Sub

    Public Sub SendMail()
        Dim Correo As String = ""
        Dim i As Integer = 0
        Dim conta As Integer = 0
        Dim vActivaDelay As Integer = 100
        Dim Ret As Long

        'FileAttach(0) = "E:\UNED\WebCorreos\imagenes\ProDesPro.jpg"


        If IsNetworkAlive(Ret) = 0 Then
            MsgBox("No existe conexion a internet" & vbNewLine + "Error enviando E-Mail." & vbNewLine & vbNewLine + "Por favor revise su conexión a internet" & vbNewLine + "e intentelo nuevamente.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        IniciarListas()
        Pb.Value = 0
        Pb.Maximum = dtCorreos.Rows.Count

        If dtCorreos.Rows.Count > 0 Then
            If Validacion() = True Then
                For i = 0 To dtCorreos.Rows.Count - 1
                    Correo = ""
                    Correo = dtCorreos.Rows(i)(0).ToString.Trim
                    lblCorreo.Text = ""
                    lblCorreo.Text = Correo.ToString.Trim
                    conta = conta + 1
                    lblEnviados.Text = conta
                    Application.DoEvents()
                    If conta = vActivaDelay Then
                        lbErrores.Items.Add("Esperando en los " & CStr(vActivaDelay) & " correos enviados" & Now)
                        Application.DoEvents()
                        vActivaDelay = vActivaDelay + 100
                        'TiempoEnEspera(True)
                        Thread.Sleep(vMiliSegundos)
                        'TiempoEnEspera(False)
                    End If
                    ' If RBtn_MS_Exchange.Checked = True Then
                    pEnviarCorreo(Correo.ToString.Trim, Nothing)
                    Pb.Value = Pb.Value + 1
                    ' End If
                Next
            End If
        Else
            MsgBox("Debe cargar una lista de correos para continuar con el envio", MsgBoxStyle.Information, Application.ProductName)
        End If
        'Catch ex As Exception
        '    txtError.Text = ex.Message & " " & Correo
        'End Try
    End Sub

    Private Sub IconBtnSendMail_Click(sender As Object, e As EventArgs) Handles IconBtnSendMail.Click
        SendMail()
    End Sub

    Private Sub IconBtnOpenURL_Click(sender As Object, e As EventArgs) Handles IconBtnOpenURL.Click
        OpenURL()
    End Sub


    ''' <summary>
    ''' Cuando se presiona el mouse activa el proceso de movimiento
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseDown
        'vai = True
        m = 1
        m_x = e.X
        m_y = e.Y
    End Sub
    ''' <summary>
    ''' Cuando deja de presionar el mouse desactiva el movimiento
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BarraTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseUp
        'vai = False
        m = 0
    End Sub
    ''' <summary>
    ''' Cuando el mouse está activado el formulario se mueve
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseMove
        'If vai = True Then
        '    Me.Location = Cursor.Position

        'End If

        If m = 1 Then
            Me.SetDesktopLocation(MousePosition.X - m_x, MousePosition.Y - m_y)
        End If
    End Sub

    Private Sub IconBtnAddLink_Click(sender As Object, e As EventArgs) Handles IconBtnAddLink.Click
        AddLink()
    End Sub

    Private Sub IconBtnInsertLine_Click(sender As Object, e As EventArgs) Handles IconBtnInsertLine.Click
        InsertHorizontalRule()
    End Sub
End Class