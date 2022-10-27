Public Class LoginForm

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub BtnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConectar.Click
        If txtUserName.Text = "hguido" Then
            If txtPassword.Text = "uned" Then
                Dim F As New FrmPrincipal
                Me.Hide()
                F.ShowDialog()
                Me.Close()
            Else
                MsgBox("Contraseña Invalida", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Usuario Invalido", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = Keys.Return Then
            BtnConectar.Focus()
        End If
    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = Keys.Return Then
            txtPassword.Focus()
        End If
    End Sub

End Class
