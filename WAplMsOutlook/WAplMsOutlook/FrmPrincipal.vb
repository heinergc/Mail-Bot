Public Class FrmPrincipal

 


    Private Sub FrmPrincipal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Close()
    End Sub

    Private Sub BtnAdmExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdmExcel.Click
        Dim f As New FrmEnviaCorreos
        f.ShowDialog()
    End Sub

 
    Private Sub BtnAdmMSOutlook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdmMSOutlook.Click
        Dim f As New FrmMsOutlook
        f.ShowDialog()
    End Sub
End Class