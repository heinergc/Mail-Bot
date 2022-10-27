Option Explicit On
Imports Microsoft.Office.Interop.Outlook
Imports System
Imports WAplMsOutlook.clssGeneral

Public Class FrmMsOutlook

    Dim olMAPI As [NameSpace]
    'Public Const FOLDER_TO_OPEN = "Carpetas Personales"  '"Buzón: Heiner Guido Cambronero"   'Modify as appropriate "Carpetas Personales" '
    'Public Const FOLDER_TO_OPEN = "heinergc@hotmail.com"  '"Buzón: Heiner Guido Cambronero"   'Modify as appropriate "Carpetas Personales" '
    Public vParentName As String
    Public miTablaCorreos As DataTable
    Public FOLDER_TO_OPEN As String
    Public vSumar As Integer = 0

    Private Sub FrmMsOutlook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TreeVOutlook.Nodes.Clear()
        pShowToptip()
        pIniciaLabels()
        pCuentas()
        If CboCuentas.Text = "" Then
            MsgBox("No hay ninguna carpeta seleccionada para consultar, verrifique...", MsgBoxStyle.Information, "Revisión general")
        Else
            FOLDER_TO_OPEN = CboCuentas.Text
        End If
        'Main()
        'MsgBox(pGetCorreos("@"))
        pListaGlobal()
        miTablaCorreos = CreateTableCorreos()
    End Sub
    Private Sub pActualizarArbol()
        FOLDER_TO_OPEN = CboCuentas.Text
        Main()
    End Sub
    Private Sub pIniciaLabels()
        lblFrom.Text = ""
        lblName.Text = ""
        lblSuma.Text = ""
    End Sub

    Private Sub pCuentas()
        Dim i As Integer
        ' Create Outlook application.
        Dim oApp As Microsoft.Office.Interop.Outlook.Application = New Application()
        ' Get Mapi NameSpace and Logon.
        Dim oNS As Microsoft.Office.Interop.Outlook.NameSpace = oApp.GetNamespace("MAPI")
        'oNS.Logon("YourValidProfile", Missing.Value, False, True) ' TODO:

        For i = 1 To oNS.Folders.Count
            CboCuentas.Items.Add(oNS.Folders.Item(i).Name)

        Next
        CboCuentas.SelectedIndex = 0

    End Sub
    Private Sub pListaGlobal()
        Dim i As Integer
        ' Create Outlook application.
        Dim oApp As Microsoft.Office.Interop.Outlook.Application = New Application()
        ' Get Mapi NameSpace and Logon.
        Dim oNS As Microsoft.Office.Interop.Outlook.NameSpace = oApp.GetNamespace("MAPI")
        'oNS.Logon("YourValidProfile", Missing.Value, False, True) ' TODO:
        Dim TmpFolders As MAPIFolder

        TmpFolders = oNS.Folders(FOLDER_TO_OPEN)
        ' Get Global Address List.
        Dim oDLs As AddressLists = oNS.AddressLists

        If oNS.AddressLists.Count > 0 Then
            For i = 1 To oNS.AddressLists.Count
                CboListas.Items.Add(oDLs.Item(i).Name)
            Next
        End If

    End Sub


    Sub PrintFolderNames(ByVal tempfolder As MAPIFolder, ByVal pNodo As TreeNode, Optional ByVal NumFolder As String = "0", Optional ByVal CodigoNodoPadre As String = Nothing)
        Dim i As Integer
        Dim NuevoNodo As TreeNode
        'Dim Nodopadre As TreeNode
        Dim Separador As String = "-"


        Try

     
            If tempfolder.Folders.Count Then

                NuevoNodo = New TreeNode(tempfolder.Name)
                If CodigoNodoPadre = Nothing Then Separador = ""
                NuevoNodo.Tag = CodigoNodoPadre & Separador & NumFolder
                NuevoNodo.Name = tempfolder.Name


                If NuevoNodo.Tag <> "0" Then
                    NuevoNodo.Text = NuevoNodo.Text & " " & tempfolder.UnReadItemCount
                End If

                If pNodo Is Nothing Then
                    TreeVOutlook.Nodes.Add(NuevoNodo)
                Else
                    pNodo.Nodes.Add(NuevoNodo)
                End If

                For i = 1 To tempfolder.Folders.Count
                    ''Debug.Print(tempfolder.Folders(i).Name)
                    Call PrintFolderNames(tempfolder.Folders(i), NuevoNodo, i, NuevoNodo.Tag)

                Next i
            Else
                If CodigoNodoPadre = Nothing Then Separador = ""
                NuevoNodo = New TreeNode(tempfolder.Name)
                NuevoNodo.Tag = CodigoNodoPadre & Separador & NumFolder
                NuevoNodo.Name = tempfolder.Name
                pNodo.Nodes.Add(NuevoNodo)

            End If


            TreeVOutlook.ExpandAll()

        Catch ex As System.Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Private Function GetNumFolder(ByVal NombreCarpeta As String) As Integer

    '    GetNumFolder = 0

    '    Select Case LCase(Replace(NombreCarpeta, " ", ""))
    '        Case Is = "bandejadeentrada"
    '            GetNumFolder = OlDefaultFolders.olFolderInbox
    '        Case Is = "badejadesalida"
    '            GetNumFolder = OlDefaultFolders.olFolderOutbox
    '        Case Is = "elementosenviados"
    '            GetNumFolder = OlDefaultFolders.olFolderSentMail
    '        Case Is = "elementoseliminados"
    '            GetNumFolder = OlDefaultFolders.olFolderDeletedItems
    '        Case Else
    '            GetNumFolder = 6
    '    End Select
    '    Return GetNumFolder
    'End Function
    Private Function GetNumFolder(ByVal Num As Integer) As Integer

        GetNumFolder = 0
        Select Case Num
            Case Is = 1 ' Eliminados
                GetNumFolder = OlDefaultFolders.olFolderDeletedItems
            Case Is = 2 ' Entrada
                GetNumFolder = OlDefaultFolders.olFolderInbox
            Case Is = 3 ' salida 
                GetNumFolder = OlDefaultFolders.olFolderOutbox
            Case Is = 4 'Enviados
                GetNumFolder = OlDefaultFolders.olFolderSentMail
                'Case Else
                '    GetNumFolder = 6
        End Select
        Return GetNumFolder
    End Function
    Private Function GetLargoLimpio(ByVal Valor As String) As Integer
        Dim myArr() As String
        Dim i As Integer
        Dim Conta As Integer

        myArr = Split(Valor, "-")
        Conta = 0

        For Each i In myArr
            Conta = Conta + 1
        Next i

        Return Conta
    End Function
    Private Sub Main()

        olMAPI = GetObject("", "Outlook.Application").GetNamespace("MAPI")
        Call PrintFolderNames(olMAPI.Folders(FOLDER_TO_OPEN), Nothing, "0")

        olMAPI = Nothing
    End Sub
    Private Sub pGetEmails(ByVal NumCarpeta As String)
        Dim objOutlook As Application = Nothing
        Dim objMAPI As Microsoft.Office.Interop.Outlook.NameSpace
        Dim Item As Microsoft.Office.Interop.Outlook.MailItem
        Dim Attach As Microsoft.Office.Interop.Outlook.Attachment
        Dim TmpFolders As MAPIFolder

        Dim myArr() As String
        Dim i As Integer
        Dim Conta As Integer
        Dim CarpetaI As Integer = 0
        Dim SubCarpetaI As Integer = 0
        Dim SubCarpetaII As Integer = 0
        Dim SubCarpetaIII As Integer = 0
        Dim CarpetaV As Integer = 0

        Dim vCorreo As String = ""


        Dim vExistItems As Boolean = False

        Try

            vSumar = 0
            pb.Value = 0
            LBCorreos.Items.Clear()
            'Crear instancia de "Microsoft Outlook"
            If objOutlook Is Nothing Then
                objOutlook = CreateObject("Outlook.Application")
            End If


            'Iniciar sesión MAPI
            objMAPI = objOutlook.GetNamespace("MAPI")

            TmpFolders = objMAPI.Folders(FOLDER_TO_OPEN)



            myArr = Split(NumCarpeta, "-")
            Conta = 0

            For Each i In myArr
                Conta = Conta + 1
                Select Case Conta
                    Case Is = 2
                        'bandeja de Entrada , salida , Enviados , Eliminados 
                        CarpetaI = i 'GetNumFolder(i)
                    Case Is = 3
                        'Sub Carpetas de las anteriores 2 
                        SubCarpetaI = i
                    Case Is = 4
                        'Sub Carpetas de las anteriores 4 
                        SubCarpetaII = i
                    Case Is = 5
                        SubCarpetaIII = i
                End Select
            Next i


            Select Case Conta
                Case Is = 1
                    'Carpetas Personales
                Case Is = 2
                    'bandeja de Entrada , salida , Enviados , Eliminados 
                    With TmpFolders.Folders(CarpetaI) '6=olFolderInbox
                        'Recorrer los elementos de la carpeta
                        If .Items.Count > 0 Then
                            vExistItems = True
                        End If

                        pb.Maximum = .Items.Count
                        For i = 1 To .Items.Count
                            Try
                                pb.Value = pb.Value + 1
                                If TypeOf .Items(i) Is Microsoft.Office.Interop.Outlook.MailItem And Not .Items(i) Is Nothing Then
                                    Item = CType(.Items(i), Microsoft.Office.Interop.Outlook.MailItem)
                                    vSumar = vSumar + 1
                                    vCorreo = LCase(pDevuelveCorreo(Item.SenderEmailAddress.ToString))
                                    LBCorreos.Items.Add(UCase(Item.SenderName) & " <" & vCorreo & ">")
                                    lblFrom.Text = vCorreo
                                    lblName.Text = Item.SenderName
                                    lblSuma.Text = vSumar
                                    Call AddFilasCorreos(vCorreo, UCase(Item.SenderName))
                                    LBCorreos.Focus()
                                End If
                            Catch ex As System.Exception
                                LBControlErrores.Items.Add(ex.Message)
                            End Try
                        Next i
                    End With
                Case Is = 3
                    With TmpFolders.Folders(CarpetaI).Folders.Item(SubCarpetaI) '6=olFolderInbox
                        'Recorrer los elementos de la carpeta

                        If .Items.Count > 0 Then
                            vExistItems = True
                        End If

                        pb.Maximum = .Items.Count
                        For i = 1 To .Items.Count
                            Try
                                pb.Value = pb.Value + 1
                                If TypeOf .Items(i) Is Microsoft.Office.Interop.Outlook.MailItem And Not .Items(i) Is Nothing Then
                                    Item = CType(.Items(i), Microsoft.Office.Interop.Outlook.MailItem)
                                    vSumar = vSumar + 1
                                    vCorreo = LCase(pDevuelveCorreo(Item.SenderEmailAddress.ToString))
                                    LBCorreos.Items.Add(UCase(Item.SenderName) & " <" & vCorreo & ">")
                                    lblFrom.Text = vCorreo
                                    lblName.Text = Item.SenderName
                                    lblSuma.Text = vSumar
                                    Call AddFilasCorreos(vCorreo, UCase(Item.SenderName))
                                    LBCorreos.Focus()
                                End If
                            Catch ex As System.Exception
                                LBControlErrores.Items.Add(ex.Message)
                            End Try
                        Next i
                    End With
                    'Sub Carpetas de las anteriores 2 

                Case Is = 4
                    'Sub Carpetas de las anteriores 4 
                    With TmpFolders.Folders(CarpetaI).Folders.Item(SubCarpetaI).Folders.Item(SubCarpetaII) '6=olFolderInbox

                        If .Items.Count > 0 Then
                            vExistItems = True
                        End If
                        'Recorrer los elementos de la carpeta
                        pb.Maximum = .Items.Count
                        For i = 1 To .Items.Count

                            pb.Value = pb.Value + 1
                            Try
                                If TypeOf .Items(i) Is Microsoft.Office.Interop.Outlook.MailItem And Not .Items(i) Is Nothing Then
                                    'If i = 33 Then Stop
                                    Item = CType(.Items(i), Microsoft.Office.Interop.Outlook.MailItem)
                                    vSumar = vSumar + 1
                                    vCorreo = LCase(pDevuelveCorreo(Item.SenderEmailAddress.ToString))
                                    LBCorreos.Items.Add(UCase(Item.SenderName) & " <" & vCorreo & ">")
                                    lblFrom.Text = vCorreo
                                    lblName.Text = Item.SenderName
                                    lblSuma.Text = vSumar
                                    Call AddFilasCorreos(vCorreo, UCase(Item.SenderName))
                                    LBCorreos.Focus()
                                End If
                            Catch ex As System.Exception
                                LBControlErrores.Items.Add(ex.Message)
                            End Try
                        Next i
                    End With
                Case Is = 5
                    'Sub Carpetas de las anteriores 4
                    With TmpFolders.Folders(CarpetaI).Folders.Item(SubCarpetaI).Folders.Item(SubCarpetaII).Folders.Item(SubCarpetaIII)
                        If .Items.Count > 0 Then
                            vExistItems = True
                        End If
                        'Recorrer los elementos de la carpeta



                        pb.Maximum = .Items.Count
                        For i = 1 To .Items.Count
                            Try
                                pb.Value = pb.Value + 1
                                If TypeOf .Items(i) Is Microsoft.Office.Interop.Outlook.MailItem And Not .Items(i) Is Nothing Then
                                    Item = CType(.Items(i), Microsoft.Office.Interop.Outlook.MailItem)
                                    vSumar = vSumar + 1
                                    vCorreo = LCase(pDevuelveCorreo(Item.SenderEmailAddress.ToString))
                                    LBCorreos.Items.Add(UCase(Item.SenderName) & " <" & vCorreo & ">")
                                    lblFrom.Text = vCorreo
                                    lblName.Text = Item.SenderName
                                    lblSuma.Text = vSumar
                                    Call AddFilasCorreos(vCorreo, UCase(Item.SenderName))
                                    LBCorreos.Focus()
                                End If
                            Catch ex As System.Exception
                                LBControlErrores.Items.Add(ex.Message)
                            End Try
                        Next i
                    End With

            End Select


            If vExistItems = False Then
                MsgBox("No existen correos que se puedan verificar ", MsgBoxStyle.Information)
            End If


            'Iniciar sesión MAPI
            objMAPI = objOutlook.GetNamespace("MAPI")
            'Finalizar sesión MAPI
            objMAPI.Logoff()
            'olMAPI.Logoff()
            'Destruir referencias
            objOutlook = Nothing
            Item = Nothing
            Attach = Nothing
            objMAPI = Nothing
            'olMAPI = Nothing
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub




    Private Sub Correos(ByVal NumCarpeta As String)
        Dim objOutlook As Application = Nothing
        Dim objMAPI As Microsoft.Office.Interop.Outlook.NameSpace
        Dim Item As Microsoft.Office.Interop.Outlook.MailItem
        Dim Attach As Microsoft.Office.Interop.Outlook.Attachment


        Dim i As Integer = 1
        Dim vCorreo As String = ""
        Dim vSumar As Integer = 0
        Dim Carpeta As Integer = 0
        Dim SubCarpeta As Integer = 0
        Dim Define As Integer



        pb.Value = 0
        LBCorreos.Items.Clear()
        'Crear instancia de "Microsoft Outlook"
        If objOutlook Is Nothing Then
            objOutlook = CreateObject("Outlook.Application")
        End If

        'Iniciar sesión MAPI
        objMAPI = objOutlook.GetNamespace("MAPI")

        Define = Mid(NumCarpeta, 1, 1)


        If Define = 0 Then

            Carpeta = GetNumFolder(Me.txtNameFolder.Text)
            With objMAPI.GetDefaultFolder(Carpeta) '6=olFolderInbox
                'Recorrer los elementos de la carpeta
                pb.Maximum = .Items.Count
                For i = 1 To .Items.Count

                    pb.Value = pb.Value + 1
                    If TypeOf .Items(i) Is Microsoft.Office.Interop.Outlook.MailItem Then
                        Item = CType(.Items(i), Microsoft.Office.Interop.Outlook.MailItem)
                        vSumar = vSumar + 1
                        vCorreo = LCase(pDevuelveCorreo(Item.SenderEmailAddress.ToString))
                        LBCorreos.Items.Add(UCase(Item.SenderName) & " <" & vCorreo & ">")
                        Sb.Text = vCorreo
                        lblname.Text = Item.SenderName
                        lblSuma.Text = vSumar

                    End If
                Next i
            End With
        Else
            Carpeta = GetNumFolder(vParentName)
            SubCarpeta = Mid(NumCarpeta, 2, Len(NumCarpeta))
            'vParentName
            With objMAPI.GetDefaultFolder(Carpeta).Folders.Item(SubCarpeta).Folders.Item(1) '6=olFolderInbox
                'Recorrer los elementos de la carpeta
                pb.Maximum = .Items.Count
                For i = 1 To .Items.Count

                    pb.Value = pb.Value + 1
                    If TypeOf .Items(i) Is Microsoft.Office.Interop.Outlook.MailItem Then
                        Item = CType(.Items(i), Microsoft.Office.Interop.Outlook.MailItem)
                        vSumar = vSumar + 1
                        vCorreo = LCase(pDevuelveCorreo(Item.SenderEmailAddress.ToString))
                        LBCorreos.Items.Add(UCase(Item.SenderName) & " <" & vCorreo & ">")
                        Sb.Text = vCorreo
                        lblname.Text = Item.SenderName
                        lblSuma.Text = vSumar

                    End If
                Next i
            End With

        End If


        'Iniciar sesión MAPI
        objMAPI = objOutlook.GetNamespace("MAPI")
        'Finalizar sesión MAPI
        objMAPI.Logoff()
        'Destruir referencias
        objOutlook = Nothing
        Item = Nothing
        Attach = Nothing
        objMAPI = Nothing


    End Sub
    Function pDevuelveCorreo(ByVal info As String) As String
        Dim Correo As String = ""
        Dim vPos As Integer
        Dim vPosI As Integer = 0
        Dim Resulta As String = ""
        Dim i As Integer = 0

        vPos = InStr(info, "@", CompareMethod.Text)

        If vPos > 0 Then
            Correo = LCase(info)
        Else
            If Len(info) > 0 Then
                vPosI = InStr(info, "=", CompareMethod.Text)
                Correo = Mid(info, vPosI + 1, Len(info))
                If Len(Correo) > 0 Then
                    Do While vPosI > 0
                        vPosI = InStr(Correo, "=", CompareMethod.Text)
                        If vPosI = 0 Then Exit Do
                        Correo = Mid(Correo, vPosI + 1, Len(info))
                    Loop
                    Correo = Correo & "@uned.ac.cr"
                End If
            End If
        End If

        Return Correo

        'vPosI = Len("/O=UNED/OU=UNED.AC.CR/CN=USERS/CN=hguido")
        'Correo = (Mid(info, 34, Len(info)) & "@uned.ac.cr")
    End Function

    Private Sub TreeVOutlook_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeVOutlook.AfterSelect
        Dim n As New TreeNode
        Dim nparent As New TreeNode

        n = TreeVOutlook.SelectedNode

        If n.Parent Is Nothing Then
            txtNumFolder.Text = n.Tag
            txtNameFolder.Text = n.Name
        Else
            nparent = n.Parent
            vParentName = nparent.Name
            txtNumFolder.Text = n.Tag
            txtNameFolder.Text = n.Name
        End If

        ' ActualizarCheck(TreeVOutlook.SelectedNode)
        'ActualizarCheck(e.Node)
    End Sub
    Private Sub ActualizarCheck(ByVal node As TreeNode)
        Dim n As TreeNode
        Dim nParent As TreeNode
        n = node
        'For Each n In node.Nodes
        nParent = n.Parent
        If nParent Is Nothing Then
            txtNumFolder.Text = n.Tag
            txtNameFolder.Text = n.Name
        Else
            nParent = n.Parent
            vParentName = nParent.Name
            txtNumFolder.Text = txtNumFolder.Text & nParent.Tag & n.Tag
            txtNameFolder.Text = n.Name
            If n.Nodes.Count <> 0 Then
                ActualizarCheck(n)
            End If
        End If

        'Next n
    End Sub




    Private Sub TreeVOutlook_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeVOutlook.MouseClick
        'Dim n As TreeNode
        'n = TreeVOutlook.SelectedNode
        'MsgBox(n.Tag & " " & n.Name)
    End Sub

    Private Sub BtnCorreos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCorreos.Click
        If Me.txtNumFolder.Text <> "" Then
            Call pGetEmails(Me.txtNumFolder.Text)
            pAgrupar()
        Else
            MsgBox("Debe seleccionar una carpeta para continuar ... ", MsgBoxStyle.Information)
            TreeVOutlook.Focus()
        End If
    End Sub




    'Public Overloads Shared Sub PrintValues(ByVal myArr() As Integer)
    '    Dim i As Integer
    '    For Each i In myArr
    '        Console.Write(ControlChars.Tab + "{0}", i)
    '    Next i
    '    Console.WriteLine()
    'End Sub
    'Sub ListaMain()
    '    Dim i As Integer
    '    ' Create Outlook application.
    '    Dim oApp As Microsoft.Office.Interop.Outlook.Application = New Application()

    '    ' Get Mapi NameSpace and Logon.
    '    Dim oNS As Microsoft.Office.Interop.Outlook.NameSpace = oApp.GetNamespace("mapi")
    '    'oNS.Logon("YourValidProfile", Missing.Value, False, True) ' TODO:

    '    ' Get Global Address List.
    '    Dim oDLs As AddressLists = oNS.AddressLists

    '    If oNS.AddressLists.Count > 0 Then
    '        For i = 1 To oNS.AddressLists.Count
    '            CboListas.Items.Add(oDLs.Item(i).Name)
    '        Next
    '    End If

    '    Dim oGal As AddressList
    '    Dim TmpFolders As MAPIFolder
    '    TmpFolders = oNS.Folders(FOLDER_TO_OPEN)
    '    'TmpFolders = oGal.GetContactsFolder()

    '    'oGal2.OlAddressListType.olOutlookAddressList()
    '    'oGal2.AddressEntries.Add("Fax", "Contactos", "heinergc@hotmail.com")

    '    ' '' MsgBox(oGal.Name)


    '    'oGal.AddressEntries.Add(OlAddressListType.olOutlookAddressList, "HEINERGUIDO", Nothing)


    '    ' Get a specific distribution list.
    '    ' TODO: Rthat iseplace the distribution list with a distribution list  available to you.
    '    Dim sDL As String = "Contactos"
    '    Dim oEntries As AddressEntries = oGal.AddressEntries
    '    ' No filter available to AddressEntries
    '    Dim oDL As AddressEntry = oEntries.Item(sDL)




    '    'oEntries.Add("FAX", "HeinerII", Nothing)

    '    Console.WriteLine(oDL.Name)
    '    Console.WriteLine(oDL.Address)
    '    'Console.WriteLine(oDL.Manager)

    '    ' Get all of the members of the distribution list.
    '    oEntries = oDL.Members
    '    Dim oEntry As AddressEntry


    '    For i = 1 To oEntries.Count
    '        oEntry = oEntries.Item(i)
    '        MsgBox((oEntry.Name))

    '        ' Display the Details dialog box.
    '        'oDL.Details(Missing.Value)
    '    Next

    '    ' Log off.
    '    oNS.Logoff()

    '    ' Clean up.
    '    oApp = Nothing
    '    oNS = Nothing
    '    oDLs = Nothing
    '    oGal = Nothing
    '    oEntries = Nothing
    '    oEntry = Nothing
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCrearListas.Click
        'ListaMain()
        'AddAddressEntry()
        'MainII()
        'MainIV()

        If txtNombreLista.Text <> "" Then
            Ejecutar(miTablaCorreos)
        Else
            MsgBox("Nombre de lista invalidad", MsgBoxStyle.Information)
            txtNombreLista.Focus()
        End If
    End Sub
    'Public Sub AddAddressEntry(ByVal ListaName As String, ByVal vContacName As String, ByVal vConstaCorreo As String)
    '    Dim oApp As Microsoft.Office.Interop.Outlook.Application = New Application()
    '    Dim oNS As Microsoft.Office.Interop.Outlook.NameSpace = oApp.GetNamespace("mapi")
    '    Dim objAddressList As AddressList
    '    Dim objAddressEntry As AddressEntry
    '    'Dim colAddressentries As AddressEntries
    '    'Dim book As AddressLists

    '    Dim Entry As AddressEntry
    '    Dim oEntries As AddressEntries

    '    Entry = oNS.AddressLists(ListaName).AddressEntries
    '    Dim sDL As String = ListaName

    '    Dim oDL As AddressEntry = oEntries.Item(sDL)

    '    oEntries = oDL.Members

    '    Entry.Add(OlAddressListType.olCustomAddressList, vContacName.Trim, vConstaCorreo.Trim)

    '    For Each objAddressList In oNS.AddressLists
    '        If objAddressList.Name = ListaName.Trim Then
    '            objAddressEntry = objAddressList.AddressEntries.Add(OlAddressListType.olCustomAddressList, vContacName.Trim, vConstaCorreo.Trim)
    '            objAddressEntry.Update()
    '            Exit For
    '        End If
    '    Next
    'End Sub

    '    m_redMapiUtils = CreateObject("Redemption.MapiUtils")
    'Set OutlookAddressEntries = m_redMapiUtils.AddressLists("Global Address List").AddressEntries

    'For i= 1 to OutlookAddressEntries.Count
    '    Set OutlookEntry = OutlookAddressEntries.item(i)
    '    MsgBox OutlookEntry.Fields(&H3001001E).value
    'Next


    ' /* AddAddressEntry */
    'Public Sub AddAddressEntry(ByVal ListaName As String, ByVal vContacName As String, ByVal vConstaCorreo As String)
    '    Dim oApp As Microsoft.Office.Interop.Outlook.Application = New Application()
    '    Dim oNS As Microsoft.Office.Interop.Outlook.NameSpace = oApp.GetNamespace("mapi")
    '    Dim objAddressList As AddressList
    '    Dim objAddressEntry As AddressEntry
    '    'Dim colAddressentries As AddressEntries
    '    'Dim book As AddressLists
    '    For Each objAddressList In oNS.AddressLists
    '        If objAddressList.Name = ListaName.Trim Then
    '            objAddressEntry = objAddressList.AddressEntries.Add(OlAddressListType.olCustomAddressList, vContacName.Trim, vConstaCorreo.Trim)
    '            objAddressEntry.Update()
    '            Exit For
    '        End If
    '    Next
    'End Sub

    'Public Sub ToOutlookContact(ByVal m_Firstname As String, ByVal m_LastName As String, ByVal m_Address As String, ByVal m_City As String, ByVal m_Region As String, ByVal m_Code As String, ByVal m_Phone As String)
    '    Dim oApp As New Microsoft.Office.Interop.Outlook.Application
    '    Dim oNameSpace As Microsoft.Office.Interop.Outlook.NameSpace = oApp.GetNamespace("mapi")
    '    Dim oContactItem As Microsoft.Office.Interop.Outlook.ContactItem
    '    Dim olContactItem As New OlItemType
    '    oContactItem = oApp.CreateItem(olContactItem)
    '    With oContactItem
    '        .FirstName = m_Firstname
    '        .LastName = m_LastName
    '        .BusinessAddress = m_Address
    '        .BusinessAddressCity = m_City
    '        .BusinessAddressState = m_Region
    '        .BusinessAddressPostalCode = m_Code
    '        .BusinessTelephoneNumber = m_Phone
    '        .Save()
    '    End With
    '    oContactItem = Nothing
    '    oApp = Nothing
    'End Sub

    Sub MainII()
        ' Create an Outlook application.
        Dim oApp As Microsoft.Office.Interop.Outlook.Application = New Application()

        ' Get the MAPI namespace.
        Dim oNS As Microsoft.Office.Interop.Outlook.NameSpace = oApp.Session

        ' Get the AddressLists collection.
        Dim oALs As Microsoft.Office.Interop.Outlook.AddressLists = oNS.AddressLists
        Console.WriteLine(oALs.Count)

        ' Loop through the AddressLists collection.
        Dim i As Integer
        Dim oAL As Microsoft.Office.Interop.Outlook.AddressList
        For i = 1 To oALs.Count
            oAL = oALs.Item(i)
            MsgBox(oAL.Name)
        Next

        ' Clean up.
        oAL = Nothing
        oALs = Nothing
        oNS = Nothing
        oApp = Nothing
    End Sub

    Sub MainIII()
        ' Create an Outlook application.
        Dim oApp As Application = New Application()

        ' Get the MAPI namespace.
        Dim oNS As Microsoft.Office.Interop.Outlook.NameSpace = oApp.Session

        ' Get the Global Address List.
        Dim oALs As AddressLists = oNS.AddressLists
        Dim oGal As AddressList = oALs.Item(CboListas.Text)
        Console.WriteLine(oGal.Name)

        ' Get all the entries.
        Dim oEntries As AddressEntries = oGal.AddressEntries

        ' Get the first user.
        Dim oEntry As AddressEntry = oEntries.GetFirst()

        ' Output some common properties.
        MsgBox(oEntry.Name)
        MsgBox(oEntry.Address)
        ' MsgBox(oEntry.Manager)

        ' Get the users by name.
        ' TODO: Replace UserName with your recipient name.
        oEntry = oEntries.Item(0)


        ' Output some common properties.
        MsgBox(oEntry.Name)
        MsgBox(oEntry.Address)
        'MsgBox(oEntry.Manager)

        ' Get the users by index.
        oEntry = oEntries.Item(3)

        ' Output some common properties.
        MsgBox(oEntry.Name)
        MsgBox(oEntry.Address)
        'MsgBox(oEntry.Manager)
        oEntries.Add(" ", "Heiner", Nothing)
        ' Clean up.
        oApp = Nothing
        oNS = Nothing
        oALs = Nothing
        oGal = Nothing
        oEntries = Nothing
        oEntry = Nothing
    End Sub

    Sub MainIV()

        ' TODO: Replace My DL Name with a valid distribution list name.
        Dim sDLName As String = "pruebas"

        ' Create an Outlook application.
        Dim oApp As Application = New Application()

        ' Get the MAPI namespace.
        Dim oNS As Microsoft.Office.Interop.Outlook.NameSpace = oApp.Session

        ' Get the Global Address List.
        Dim oALs As AddressLists = oNS.AddressLists
        Dim oGal As AddressList = oALs.Item(CboListas.Text)
        Console.WriteLine(oGal.Name)

        ' Get a specific Distribution List.
        Dim oEntries As AddressEntries = oGal.AddressEntries
        ' Reference the Distribution List by name.
        Dim oDL As AddressEntry = oEntries.Item(sDLName)

        MsgBox(oDL.Name)
        MsgBox(oDL.Address)

        ' Get all the members of the Distribution List.
        oEntries = oDL.Members
        Dim oEntry As AddressEntry
        Dim i As Integer
        If Not oEntries Is Nothing Then
            If oEntries.Count > 0 Then
                For i = 1 To oEntries.Count
                    oEntry = oEntries.Item(i)
                    MsgBox(oEntry.Name)
                Next
            End If
        Else
            MsgBox("Nada")

        End If
        ' Clean up.
        oEntry = Nothing
        oEntries = Nothing
        oGal = Nothing
        oALs = Nothing
        oNS = Nothing
        oApp = Nothing
    End Sub
    Private Sub Ejecutar(ByVal dt As DataTable)
        Dim sDLName As String                'distribution list Item Name
        Dim str_tmp_sdlname As String = Nothing  'distribution list Item Name to compare with to see if it is a new one
        Dim intInsertTotals As Integer       'counter 
        Dim drow As DataRow
        Dim Department As String = txtNombreLista.Text.Trim

        ' Create an Outlook application.
        Dim oApp As Application = New Application()


        ' Get the MAPI namespace.
        Dim oNS As Microsoft.Office.Interop.Outlook.NameSpace = oApp.Session

        Try
            PnlProcesos.Visible = True
            pbar.Value = 0
            pbar.Maximum = dt.Rows.Count
            lblAccion.Text = "Inicia creación de lista."
            For Each drow In dt.Rows()
                Dim oCt As Microsoft.Office.Interop.Outlook.ContactItem = oApp.CreateItem(OlItemType.olContactItem)
                oCt.FullName = drow("Nombre")
                'oCt.FirstName = FirstName
                'oCt.LastName = LastName
                'oCt.Department = Department
                'oCt.FileAs = FileAs
                oCt.Email1Address = drow("Correo")
                'oCt.GovernmentIDNumber = GovernmentIDNumber
                oCt.MailingAddress = drow("Correo")
                'oCt.BusinessAddressCity = BusinessAddressCity
                'oCt.BusinessAddressPostalCode = BusinessAddressPostalCode
                'oCt.BusinessAddressStreet = BusinessAddressStreet
                'oCt.BusinessAddressState = BusinessAddressState
                'oCt.OfficeLocation = OfficeLocation
                'oCt.BusinessTelephoneNumber = BusinessTelephoneNumber
                'oCt.Subject = FirstName & " " & LastName & " " & Department
                'oCt.JobTitle = drow("Title") & " / " & drow("TitleFr")
                'oCt.Body = "RC Code:" & GovernmentIDNumber & vbNewLine & "User Type:" & Department
                oCt.Save()
                'Distribution List Name 
                lblAccion.Text = "Inicia creación de lista.."
                sDLName = Department
                Dim myMailItem As MailItem = oApp.CreateItem(OlItemType.olMailItem) 'Item to tag recipient to 
                Dim myFolder As MAPIFolder                                                  'Outlook namespace
                Dim myDistList As DistListItem                                              'Item for Distribution List Item
                Dim oRecipients As Recipients
                Dim TmpFolders As MAPIFolder
                'Item for recipient Item        
                'A new distribution list ?!
                If str_tmp_sdlname <> sDLName Then 'Yes it is - get the name sDLName and insert it

                    'objMAPI = objOutlook.GetNamespace("MAPI")

                    'TmpFolders = oNS.Folders(FOLDER_TO_OPEN)

                    'myFolder = TmpFolders.Folders(OlDefaultFolders.olFolderContacts)

                    myFolder = oNS.GetDefaultFolder(OlDefaultFolders.olFolderContacts)
                    myDistList = myFolder.Items.Add(OlItemType.olDistributionListItem)
                    myDistList.DLName = sDLName

                    lblAccion.Text = "Inicia creación de lista..."
                    Try
                        myDistList.Save()
                    Catch ex As System.Exception

                    End Try


                    oRecipients = myMailItem.Recipients                  'Resolve the current user just added by Email Address
                    oRecipients.Add(oCt.Email1Address.ToString) 'Add Contact Item as a recipient
                    oRecipients.ResolveAll()
                    If myDistList.MemberCount < 100 Then               'Add Recipient to distribution list if count less than 100
                        myDistList.AddMembers(oRecipients)             ' if count > 109 - it bombs
                        myDistList.Save()
                    Else                                        'Too many recipients in Distribution List Create a new one
                        myDistList = myFolder.Items.Add(OlItemType.olDistributionListItem)
                        myDistList.DLName = sDLName & intInsertTotals 'Unique Distribution List Item Name
                        myDistList.Save()
                        myDistList.AddMembers(oRecipients)            'Add Recipient to distribution list
                        myDistList.Save()
                    End If

                Else                                                                                 'No it is not a new Distribution List Item so just add Recipient to it 
                    oRecipients = myMailItem.Recipients                  'Resolve the current user just added by Email Address
                    oRecipients.Add(oCt.Email1Address.ToString) 'Add Contact Item as a recipient
                    oRecipients.ResolveAll()
                    lblAccion.Text = "Inicia creación de lista...."
                    If myDistList.MemberCount < 100 Then               'Add Recipient to distribution list is count less than 100
                        myDistList.AddMembers(oRecipients)             ' if count > 109 - it bombs
                        myDistList.Save()
                    Else                                        'Too many recipients in Distribution List Create a new one
                        myDistList = myFolder.Items.Add(OlItemType.olDistributionListItem)
                        myDistList.DLName = sDLName & intInsertTotals & "1" 'Unique Distribution List Item Name & "1"
                        myDistList.Save()
                        myDistList.AddMembers(oRecipients)      'Add Recipient to distribution list
                        myDistList.Save()
                    End If
                End If
                str_tmp_sdlname = sDLName                       'Set Temp Variable to current Distribution List Item for check
                oCt = Nothing                                                      'in next Iteration
                oRecipients = Nothing                                       'Empty Contact Item and Recipient Item
                intInsertTotals = intInsertTotals + 1 'Increment number of rows 
                lblAccion.Text = "Inicia creación de lista..." & intInsertTotals
                pbar.Value = pbar.Value + 1
            Next
            PnlProcesos.Visible = False
            MsgBox("Proceso finalizado con éxito...", MsgBoxStyle.Information, "Microsoft Oultook Extract Emails")
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            PnlProcesos.Visible = False
        End Try

    End Sub


    'Private Sub cmdAdd_Click()
    '    On Error Resume Next

    '    Dim sysPath As String, sSrv As String, sFN As String, sOpenSTR As String
    '    Dim adoCon As New ADODB.Connection
    '    Dim adoRS As New ADODB.Recordset

    '    sysPath = App.Path

    '    sSrv = "R01" 'SQL production Database


    '    sFN = "Assoc"

    '    strFolderPath = "Public Folders\All Public Folders\" & sFN

    '    arrFolders() = Split(strFolderPath, "\")
    '    objApp = CreateObject("Outlook.Application")
    '    objNS = objApp.GetNamespace("MAPI")
    '    objFolder = objNS.Folders.Item(arrFolders(0))

    '    If Not objFolder Is Nothing Then
    '        For I = 1 To UBound(arrFolders)
    '            colFolders = objFolder.Folders
    '            objFolder = Nothing
    '            objFolder = colFolders.Item(arrFolders(I))
    '            If arrFolders(I) = sFN Then
    '                objFolder.ShowAsOutlookAB = True

    '                objDL = objFolder.Items.Add(Outlook.OlItemType.olDistributionListItem)
    '                objDL.DLName = sFN
    '                objDL.Save()

    '                adoCon.ConnectionString = "driver={SQL Server};" & _
    '                               "server=" & sSrv & ";Trusted_Connection=Yes;database=RAS"
    '                If sFN = "Associates" Then
    '                    sOpenSTR = "'ASC'"
    '                Else
    '                    sOpenSTR = "'CR'"
    '                End If


    '                adoRS.Open("Exec RES_AddAssocOrCRS " & sOpenSTR, adoCon.ConnectionString, adOpenDynamic, adLockPessimistic)

    '                If Not (adoRS.BOF And adoRS.EOF) Then
    '                    adoRS.MoveFirst()
    '                    Do Until adoRS.EOF
    '                        objCI = objFolder.Items.Add(olContactItem)

    '                        With objCI
    '                            .FirstName = adoRS("Fname")
    '                            .LastName = adoRS("Lname")
    '                            .Email1Address = adoRS("Email_Address")
    '                            .Email1DisplayName = adoRS("Display_Name")
    '                            .SelectedMailingAddress = olHome
    '                            .Categories = sFN
    '                            .Save()
    '                        End With

    '                        myMailItem = objApp.CreateItem(Outlook.OlItemType.olMailItem)
    '                        oRecipients = myMailItem.Recipients 'Resolve the current user just added by Email Address
    '                        oRecipients.Add(objCI.Email1Address) 'Add Contact Item as a recipient
    '                        oRecipients.ResolveAll()

    '                        objDL.AddMembers(oRecipients) ' if count > 109 - it bombs
    '                        objDL.Display()

    '                        objCI = Nothing 'in next Iteration
    '                        oRecipients = Nothing 'Empty Contact Item and Recipient Item


    '                        adoRS.MoveNext()
    '                    Loop

    '                End If
    '            End If

    '            If objFolder Is Nothing Then
    '                Exit For
    '            End If
    '        Next I
    '    End If

    '    objDL = Nothing

    '    adoRS = Nothing
    '    Close(adoCon)
    '    adoCon = Nothing
    '    objFolder = Nothing
    '    colFolders = Nothing
    '    objNS = Nothing
    '    objApp = Nothing
    '    Unload(Me)
    'End Sub

    '  Private Sub cmdAdd_Click()
    'Dim Me As Object
    '      Dim oRecipients As Object
    '      Dim myMailItem As Object
    '      Dim olHome As Object
    '      Dim olContactItem As Object
    '      Dim objCI As Object
    '      Dim adLockPessimistic As Object
    '      Dim adOpenDynamic As Object
    '      Dim Outlook As Object
    '      Dim objDL As Object
    '      Dim colFolders As Object
    '      Dim I As Object
    '      Dim objFolder As Object
    '      Dim objNS As Object
    '      Dim objApp As Object
    '      Dim arrFolders As Object
    '      Dim strFolderPath As Object
    '      Dim ADODB As Object
    '      On Error Resume Next

    '      Dim sFN, sysPath, sSrv, sOpenSTR As String
    '      'UPGRADE_ISSUE: ADODB.Connection objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
    '      Dim adoCon As ADODB.Connection = New ADODB.Connection
    '      'UPGRADE_ISSUE: ADODB.Recordset objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
    '      Dim adoRS As ADODB.Recordset = New ADODB.Recordset

    '      sysPath = My.Application.Info.DirectoryPath

    '      sSrv = "R01" 'SQL production Database


    '      sFN = "Assoc"

    '      'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strFolderPath. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '      strFolderPath = "Public Folders\All Public Folders\" & sFN

    '      'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strFolderPath. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '      'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrFolders. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '      arrFolders = Split(strFolderPath, "\")
    '      objApp = CreateObject("Outlook.Application")
    '      'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objApp.GetNamespace. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '      objNS = objApp.GetNamespace("MAPI")
    '      'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objNS.Folders. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '      objFolder = objNS.Folders.Item(arrFolders(0))

    '      If Not objFolder Is Nothing Then
    '          For I = 1 To UBound(arrFolders)
    '              'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objFolder.Folders. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '              colFolders = objFolder.Folders
    '              'UPGRADE_NOTE: El objeto objFolder no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
    '              objFolder = Nothing
    '              'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto colFolders.Item. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '              objFolder = colFolders.Item(arrFolders(I))
    '              'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto arrFolders(I). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '              If arrFolders(I) = sFN Then
    '                  'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objFolder.ShowAsOutlookAB. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                  objFolder.ShowAsOutlookAB = True

    '                  'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Outlook.OlItemType. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                  'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objFolder.Items. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                  objDL = objFolder.Items.Add(Outlook.OlItemType.olDistributionListItem)
    '                  'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objDL.DLName. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                  objDL.DLName = sFN
    '                  'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objDL.Save. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                  objDL.Save()

    '                  'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto adoCon.ConnectionString. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                  adoCon.ConnectionString = "driver={SQL Server};" & "server=" & sSrv & ";Trusted_Connection=Yes;database=RAS"
    '                  If sFN = "Associates" Then
    '                      sOpenSTR = "'ASC'"
    '                  Else
    '                      sOpenSTR = "'CR'"
    '                  End If


    '                  'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto adoCon.ConnectionString. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                  'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto adoRS.Open. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                  adoRS.Open("Exec RES_AddAssocOrCRS " & sOpenSTR, adoCon.ConnectionString, adOpenDynamic, adLockPessimistic)

    '                  'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto adoRS.EOF. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                  'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto adoRS.BOF. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                  If Not (adoRS.BOF And adoRS.EOF) Then
    '                      'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto adoRS.MoveFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                      adoRS.MoveFirst()
    '                      'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto adoRS.EOF. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                      Do Until adoRS.EOF
    '                          'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objFolder.Items. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                          objCI = objFolder.Items.Add(olContactItem)

    '                          With objCI
    '                              'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objCI.FirstName. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                              'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto adoRS(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                              .FirstName = adoRS("Fname")
    '                              'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objCI.LastName. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                              'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto adoRS(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                              .LastName = adoRS("Lname")
    '                              'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objCI.Email1Address. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                              'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto adoRS(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                              .Email1Address = adoRS("Email_Address")
    '                              'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objCI.Email1DisplayName. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                              'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto adoRS(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                              .Email1DisplayName = adoRS("Display_Name")
    '                              'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objCI.SelectedMailingAddress. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                              'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto olHome. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                              .SelectedMailingAddress = olHome
    '                              'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objCI.Categories. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                              .Categories = sFN
    '                              'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objCI.Save. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                              .Save()
    '                          End With

    '                          'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Outlook.OlItemType. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                          'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objApp.CreateItem. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                          myMailItem = objApp.CreateItem(Outlook.OlItemType.olMailItem)
    '                          'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto myMailItem.Recipients. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                          oRecipients = myMailItem.Recipients 'Resolve the current user just added by Email Address
    '                          'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objCI.Email1Address. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                          'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto oRecipients.Add. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                          oRecipients.Add(objCI.Email1Address) 'Add Contact Item as a recipient
    '                          'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto oRecipients.ResolveAll. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                          oRecipients.ResolveAll()

    '                          'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objDL.AddMembers. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                          objDL.AddMembers(oRecipients) ' if count > 109 - it bombs
    '                          'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objDL.Display. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                          objDL.Display()

    '                          'UPGRADE_NOTE: El objeto objCI no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
    '                          objCI = Nothing 'in next Iteration
    '                          'UPGRADE_NOTE: El objeto oRecipients no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
    '                          oRecipients = Nothing 'Empty Contact Item and Recipient Item


    '                          'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto adoRS.MoveNext. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                          adoRS.MoveNext()
    '                      Loop

    '                  End If
    '              End If

    '              If objFolder Is Nothing Then
    '                  Exit For
    '              End If
    '          Next I
    '      End If

    '      'UPGRADE_NOTE: El objeto objDL no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
    '      objDL = Nothing

    '      'UPGRADE_NOTE: El objeto adoRS no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
    '      adoRS = Nothing
    '      'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto adoCon. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '      FileClose(CInt(adoCon))
    '      'UPGRADE_NOTE: El objeto adoCon no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
    '      adoCon = Nothing
    '      'UPGRADE_NOTE: El objeto objFolder no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
    '      objFolder = Nothing
    '      'UPGRADE_NOTE: El objeto colFolders no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
    '      colFolders = Nothing
    '      'UPGRADE_NOTE: El objeto objNS no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
    '      objNS = Nothing
    '      'UPGRADE_NOTE: El objeto objApp no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
    '      objApp = Nothing
    '      'UPGRADE_ISSUE: Me de descarga no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'

    '  End Sub

    Private Function CreateTable() As DataTable
        Dim dsTbl As DataTable = New DataTable("TABLE")
        Dim dr As DataRow

        dsTbl.Columns.Add("FullName", GetType(String))
        dsTbl.Columns.Add("MailingAddress", GetType(String))

        dr = dsTbl.NewRow
        dr("FullName") = "Heiner Guido Cambronero"
        dr("MailingAddress") = "hguido@uned.ac.cr"
        dsTbl.Rows.Add(dr)


        dr = dsTbl.NewRow
        dr("FullName") = "Diego Araya Garita"
        dr("MailingAddress") = "ldaraya@uned.ac.cr"
        dsTbl.Rows.Add(dr)

        Return dsTbl
    End Function

    Private Function CreateTableCorreos() As DataTable
        Dim miTabla As DataTable = New DataTable("TABLA")
        ' Dim miFila As DataRow
        Dim miColumna As DataColumn
        CreateTableCorreos = Nothing

        miColumna = New DataColumn("Nombre")

        With miColumna
            .DataType = System.Type.GetType("System.String")
            .MaxLength = 50
            '.AutoIncrement = True
            '.AutoIncrementSeed = 1 'Valor Inicial
            '.AutoIncrementStep = 2 'Incremento de 2 
            miTabla.Columns.Add(miColumna)
        End With

        miColumna = New DataColumn("Correo")

        With miColumna
            .DataType = System.Type.GetType("System.String")
            .Unique = True
            .MaxLength = 50
            .AllowDBNull = True
            miTabla.Columns.Add(miColumna)
            miTabla.PrimaryKey = New DataColumn() {miColumna}
        End With
        CreateTableCorreos = miTabla
        'Agregar Informacion 
        'Dim i As Integer

        'For i = 0 To 10
        '    miFila = miTabla.NewRow
        '    miFila("Correo") = "hguido@uned.ac.cr" & i
        '    miTabla.Rows.Add(miFila)
        'Next
        Return CreateTableCorreos

    End Function

    Public Sub AddFilasCorreos(ByVal Correo As String, ByVal Nombre As String)
        Try
            Dim miFila As DataRow
            'If Correo.Trim = "notifications+vvvq3x2p3lv@zyngamail.com" Then Exit Sub

            If IsValidEmail(Correo.Trim) Then
                miFila = miTablaCorreos.NewRow
                miFila("Nombre") = Nombre.Trim
                miFila("Correo") = Correo.Trim
                miTablaCorreos.Rows.Add(miFila)
            End If
        Catch ex As System.Exception

        End Try

    End Sub
    Function IsValidEmail(ByVal email As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(email, "^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")
    End Function

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        UpdateCuentas()
    End Sub
    Private Sub UpdateCuentas()
        TreeVOutlook.Nodes.Clear()
        pActualizarArbol()
        'MsgBox("La información ha sido actualizada eficientemente...", MsgBoxStyle.Information, "Procesos de Rutina")
    End Sub


    Private Sub pAgrupar()
        Dim dt As DataTable = miTablaCorreos
        RellenarListview(dt, lvGrupos, Imgtree)
        lblSuma.Text = ""
        lblSuma.Text = "Total Correos revisados: " & vSumar.ToString & " Total agrupados: " & lvGrupos.Items.Count
    End Sub

    Function RellenarListview(ByVal dt As DataTable, ByVal lvwDatos As ListView, Optional ByVal ImgLista As ImageList = Nothing) As Boolean
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

            For Each row As DataRow In dt.Rows
                vConta = vConta + 1
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

    Private Sub CreateMyListView()
        ' Create a new ListView control.
        Dim listView1 As New ListView()
        listView1.Bounds = New Rectangle(New Point(10, 10), New Size(300, 200))

        ' Set the view to show details.
        listView1.View = Windows.Forms.View.Details
        ' Allow the user to edit item text.
        listView1.LabelEdit = True
        ' Allow the user to rearrange columns.
        listView1.AllowColumnReorder = True
        ' Display check boxes.
        listView1.CheckBoxes = True
        ' Select the item and subitems when selection is made.
        listView1.FullRowSelect = True
        ' Display grid lines.
        listView1.GridLines = True
        ' Sort the items in the list in ascending order.
        listView1.Sorting = SortOrder.Ascending

        ' Create three items and three sets of subitems for each item.
        Dim item1 As New ListViewItem("item1", 0)
        ' Place a check mark next to the item.
        item1.Checked = True
        item1.SubItems.Add("1")
        item1.SubItems.Add("2")
        item1.SubItems.Add("3")
        Dim item2 As New ListViewItem("item2", 1)
        item2.SubItems.Add("4")
        item2.SubItems.Add("5")
        item2.SubItems.Add("6")
        Dim item3 As New ListViewItem("item3", 0)
        ' Place a check mark next to the item.
        item3.Checked = True
        item3.SubItems.Add("7")
        item3.SubItems.Add("8")
        item3.SubItems.Add("9")

        ' Create columns for the items and subitems.
        ' Width of -2 indicates auto-size.
        listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Left)
        listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left)
        listView1.Columns.Add("Column 3", -2, HorizontalAlignment.Left)
        listView1.Columns.Add("Column 4", -2, HorizontalAlignment.Center)

        'Add the items to the ListView.
        listView1.Items.AddRange(New ListViewItem() {item1, item2, item3})

        ' Create two ImageList objects.
        Dim imageListSmall As New ImageList()
        Dim imageListLarge As New ImageList()

        ' Initialize the ImageList objects with bitmaps.
        imageListSmall.Images.Add(Bitmap.FromFile("C:\MySmallImage1.bmp"))
        imageListSmall.Images.Add(Bitmap.FromFile("C:\MySmallImage2.bmp"))
        imageListLarge.Images.Add(Bitmap.FromFile("C:\MyLargeImage1.bmp"))
        imageListLarge.Images.Add(Bitmap.FromFile("C:\MyLargeImage2.bmp"))

        'Assign the ImageList objects to the ListView.
        listView1.LargeImageList = imageListLarge
        listView1.SmallImageList = imageListSmall

        ' Add the ListView to the control collection.
        Me.Controls.Add(listView1)
    End Sub 'CreateMyListView


    Private Sub BtnOrdenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    Private Sub CboCuentas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCuentas.SelectedIndexChanged
        UpdateCuentas()
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
            .SetToolTip(Me.TreeVOutlook, "Muestra todas las carpetas de Microsoft Outlook.")
            .SetToolTip(Me.BtnActualizar, "Refresca las carpetas de Microsoft Outlook, según la cuenta seleccionada.")
            .SetToolTip(Me.BtnCorreos, "Muestra todos los correos según la carpeta seleccionada.")
            .SetToolTip(Me.BtnCrearListas, "Crea los contactos y la lista de distribución de los mismos según lo sustraído de la carpeta seleccionada.")
            .SetToolTip(Me.BtnSalir, "Salir del programa.")
            .SetToolTip(Me.txtNameFolder, "Muestra la carpeta en selección.")
            .SetToolTip(Me.CboCuentas, "Muestra las cuentas que en MIcrosoft Outlook.")
            .SetToolTip(Me.CboListas, "Muestra la lista de contactos")
        End With


    End Sub
    Private Sub Inicializa()
        'txtNameFolder.Clear()
        txtNombreLista.Clear()
        'txtNumFolder.Clear()
        TreeVOutlook.Focus()
        LBCorreos.Items.Clear()
        lvGrupos.Items.Clear()
        lblFrom.Text = ""
        lblName.Text = ""
        lblNombre.Text = ""
        lblSuma.Text = ""
        miTablaCorreos.Rows.Clear()
    End Sub

    Private Sub BtnIniciaScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIniciaScreen.Click
        Inicializa()
    End Sub

    
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        'Dim foundRow As DataRow

        If Not lvGrupos.SelectedItems Is Nothing Then

            'Pregunta si lo quiere eliminar
            If MsgBox("Eliminar la información seleccionada...", vbQuestion + vbYesNo) = vbYes Then
                'Elimina el elemento seleccionado ( SelectedItem.Index )
                For i As Integer = lvGrupos.SelectedItems.Count - 1 To 0 Step -1

                    Dim S As String = lvGrupos.SelectedItems(i).SubItems(1).Text
                    miTablaCorreos.Rows.Find(S).Delete()
                    lvGrupos.SelectedItems(i).Remove()
                    'foundRow.Delete()
                    'If foundRow IsNot Nothing Then
                    '    MsgBox(foundRow(1).ToString())
                    'Else
                    '    MsgBox("A row with the primary key of " & S & " could not be found")
                    'End If

                    'miTablaCorreos.Rows(i).Delete()
                Next

            End If
        End If




        'If foundRow IsNot Nothing Then
        '    MsgBox(foundRow(1).ToString())
        'Else
        '    MsgBox("A row with the primary key of " & s & " could not be found")
        'End If



        pAgrupar()
    End Sub


End Class
