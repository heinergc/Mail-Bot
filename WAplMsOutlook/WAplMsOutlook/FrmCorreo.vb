Imports WAplMsOutlook.RTFtoHTML
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop

Public Class FrmCorreo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r2h As New RTFtoHTML


        AddImage("E:\UNED\WAplMsOutlook\WAplMsOutlook\Imagenes\baner.jpg")


        r2h.rtf = rtbFoo.Rtf
        Rtxthtml.Text = r2h.html
        WebBrowser1.DocumentText = r2h.html
    End Sub

    Private Sub AddImage(ByVal filename As String)

        Dim img As Image = Image.FromFile(filename)
        Dim orgData = Clipboard.GetDataObject
        Clipboard.SetImage(img)
        Me.rtbFoo.Paste()

        Clipboard.SetDataObject(orgData)
    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim doc As New Word.Document
        Dim file As Object = "C:\Carpeta\Programa Desarrollo Profesional en Línea.docx"
        Dim Nothingobj As Object = System.Reflection.Missing.Value
        Dim wordApp As New ApplicationClass
        doc = wordApp.Documents.Open(file, Nothingobj, Nothingobj, Nothingobj, Nothingobj, Nothingobj, Nothingobj, Nothingobj, Nothingobj, Nothingobj, Nothingobj, Nothingobj)
        doc.ActiveWindow.Selection.WholeStory()
        doc.ActiveWindow.Selection.Copy()
        Dim data As IDataObject = Clipboard.GetDataObject()
        rtbFoo.Text = data.GetData(DataFormats.Text).ToString()
        doc.Close()

    End Sub
End Class