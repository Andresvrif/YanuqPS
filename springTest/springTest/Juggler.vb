Public Class Juggler
    Implements Performer

    Private _beanBags As Integer = 3

    Sub New()
    End Sub

    Sub New(beanBags As Integer)
        _beanBags = beanBags
    End Sub

    Public Overridable Function perform() As String Implements Performer.perform
        Return "Juggling " & _beanBags & " BeanBags"
    End Function
End Class