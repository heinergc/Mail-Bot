Public Class FrmHiperV

    Private Sub BtnAddHpv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddHpv.Click
        If txtHpv.Text <> "" Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmHiperV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CboTipoCorreo.SelectedIndex = 0
    End Sub
End Class