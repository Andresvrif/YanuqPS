Public Class PoeticJuggler
    Inherits Juggler

    Private _poem As String

    Sub New(poem As String)
        MyBase.New()
        Me._poem = poem
    End Sub

    Sub New(beanBags As Integer, poem As String)
        MyBase.New(beanBags)
        Me._poem = poem
    End Sub

    Public Overrides Function perform() As String
        Dim msj As String
        msj = MyBase.perform()
        msj &= Me._poem
        Return msj
    End Function
End Class
