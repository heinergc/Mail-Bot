Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Public Class Cls_Correos



    Private _mailServer As String = String.Empty

    ''' <summary>
    ''' The starting function of console application.
    ''' </summary>
    ''' <remarks>Need to set the mail server details from console</remarks>
    Sub Main()

        Console.WriteLine("Welcome to Soyuj's Mail send application..")
        Console.WriteLine("Enter your Mail Server :: ")
        _mailServer = Console.ReadLine()

        EmbeddedImages()

        Console.WriteLine(ControlChars.CrLf & "Completed...")
        Console.ReadLine()

    End Sub

    ''' <summary>
    ''' Sends mail using SMTP client
    ''' </summary>
    ''' <param name="mail">The SMTP server (MailServer) as String</param>
    ''' <remarks>It can use the IP of Server also</remarks>
    Private Sub SendMail(ByVal mail As Mail.MailMessage)

        'send the message using SMTP client
        Dim smtp As New SmtpClient(_mailServer) 'mail Server IP or NAME 
        smtp.Credentials = CredentialCache.DefaultNetworkCredentials
        smtp.Send(mail)

    End Sub ' End SendMail

    ''' <summary>
    ''' Sets the content of MailMessage for default(plain text)
    ''' </summary>
    ''' <remarks>This is accessible by all Mail Clients</remarks>
    Public Sub SendPlainMail()

        'create the mail message
        Dim mail As New MailMessage("from@fromdomain.com", "to@todomain.com")

        'set the message content
        mail.Subject = "This is a plain text mail"
        mail.Body = "This is a sample body... for default Mail Clients.."

        'send the mail using SMTP Client
        Dim smtp As New SmtpClient("My Mail Server") 'mail Server IP or NAME 
        smtp.Send(mail)

    End Sub ' End SendPlainMail

    ''' <summary>
    ''' Sets the content of MailMessage for a Html body only
    ''' </summary>
    ''' <remarks>The Html body is created using standard html tags..</remarks>
    Public Sub SendHtmlMail()

        'create the mail message
        Dim mail As New MailMessage("from@fromdomain.com", "to@todomain.com")

        'set the message content
        mail.Subject = "This mail has Html Body.."
        mail.Body = "body with html<b>bold</b> <font color=#336699>blue</font>"
        mail.IsBodyHtml = True

        'send mail
        SendMail(mail)

    End Sub ' End SendHtmlMail

    ''' <summary>
    ''' Sets the MailMessage content with multiple body parts
    ''' (e.g a Html part and a PlainText part..)
    ''' </summary>
    ''' <remarks>Plain body is for Mail Clients, 
    ''' those don't support Html</remarks>
    Public Sub MultiPartMailBody()

        'create the mail message
        Dim mail As New MailMessage("from@fromdomain.com", "to@todomain.com")

        'set the message header
        mail.Subject = " This is a Multipart mail with hight Priority"
        mail.Priority = MailPriority.High

        'first we create the Plain Text part
        Dim plainView As AlternateView = AlternateView.CreateAlternateViewFromString( _
            "Plain text content, viewable by clients that don't support html", Nothing, "text/plain")

        mail.AlternateViews.Add(plainView)

        'then we create the Html part
        Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString("<b>bold text, viewable by mail clients that support html</b>", Nothing, "text/html")
        mail.AlternateViews.Add(htmlView)

        'send mail
        SendMail(mail)

    End Sub ' End MultiPartMailBody

    ''' <summary>
    ''' Set the MailMessage instance for multiple recipients with attachment
    ''' </summary>
    ''' <remarks>From address can be customized to show a Display Name</remarks>
    Public Sub MultipleRecipients()

        'create the mail message
        Dim mail As New MailMessage()

        'set the addresses
        '-----------------------------------
        'to specify a friendly 'from' name, we use a different display name
        mail.From = New MailAddress("from@fromdomain.com", "Display Name")

        'since the To, Cc, and Bcc properties are collections, to add multiple
        'addreses, we simply call .Add(...) multple times
        mail.To.Add("to@todomain.com")
        mail.To.Add("to2@to2domain.com")
        mail.CC.Add("cc1@cc1domain.com")
        mail.CC.Add("cc2@cc2domain.com")
        mail.Bcc.Add("bcc1@bcc1domain.com")
        mail.Bcc.Add("bcc2@bcc2domain.com")
        '-----------------------------------

        'set the mail content
        mail.Subject = "This is an email with attachment"
        mail.Body = "This is the body content of the email."

        'set the attachment
        mail.Attachments.Clear()
        Dim attachment1 As New Attachment("c:\attachment\image1.jpg")
        mail.Attachments.Add(attachment1)
        mail.Attachments.Add(New Attachment("c:\attachment\text1.txt"))

        'send mail
        SendMail(mail)

    End Sub ' End MultipleRecipients

    ''' <summary>
    ''' Embeds an image in a Html body of MailMessage
    ''' </summary>
    ''' <remarks>The standard image tag must be there in html body with 'cid' 
    ''' in src value</remarks>
    Public Sub EmbeddedImages()

        'create the mail message
        Dim mail As New MailMessage()

        'set the addresses
        mail.From = New MailAddress("from@fromdomain.com", " Display Name")
        mail.To.Add("to@todomain.com")

        'set the content
        mail.Subject = "This is an embedded image mail"

        'first we create the Plain Text part
        Dim palinBody As String = "Plain text content, viewable by those clients that don't support html"
        Dim plainView As AlternateView = AlternateView.CreateAlternateViewFromString(palinBody, Nothing, "text/plain")
        'then we create the Html part
        'to embed images, we need to use the prefix 'cid' in the img src value
        Dim htmlBody As String = "<b>Embedded image file.</b><DIV>&nbsp;</DIV>"
        htmlBody += "<img alt="""" hspace=0 src=""cid:uniqueId"" align=baseline border=0 >"
        htmlBody += "<DIV>&nbsp;</DIV><b>This is the end of Mail...</b>"
        Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(htmlBody, Nothing, "text/html")


        'create the AlternateView for embedded image
        Dim imageView As New AlternateView("c:\attachment\image1.jpg", MediaTypeNames.Image.Jpeg)
        imageView.ContentId = "uniqueId"
        imageView.TransferEncoding = TransferEncoding.Base64


        'add the views
        mail.AlternateViews.Add(plainView)
        mail.AlternateViews.Add(htmlView)
        mail.AlternateViews.Add(imageView)

        'send mail
        SendMail(mail)

    End Sub ' End EmbedImages


End Class
