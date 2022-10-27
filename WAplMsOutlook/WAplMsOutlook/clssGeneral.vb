Public Class clssGeneral
    Public Shared Function pGetCorreos(ByVal Correo As String) As String
        pGetCorreos = Nothing
        If Correo = "@" Then
            pGetCorreos = ("hguido@uned.ac.cr")
        End If
        Return pGetCorreos
    End Function

End Class
