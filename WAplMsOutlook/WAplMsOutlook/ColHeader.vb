' The ColHeader class is a ColumnHeader object with an 
' added property for determining an ascending or descending sort.
' True specifies an ascending order, false specifies a descending order.
Public Class ColHeader
    Inherits ColumnHeader
    Public ascending As Boolean

    Public Sub New(ByVal [text] As String, ByVal width As Integer, ByVal align As HorizontalAlignment, ByVal asc As Boolean, ByVal ImgList As ImageList, ByVal Img As Integer)
        Me.Text = [text]
        Me.Width = width
        Me.TextAlign = align
        Me.ascending = asc
        Me.ImageKey = Img
        ''Me.ImageList = ImgList
    End Sub
End Class
