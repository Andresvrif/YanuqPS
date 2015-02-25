'VB doesn't has static class, so we use this function to get a Unique Instance from Stage
Public Class Stage
    Private Shared stageInstance
    Public Shared Function getInstance() As Stage
        If stageInstance Is Nothing Then
            stageInstance = New Stage()
        End If
        Return stageInstance
    End Function
End Class
