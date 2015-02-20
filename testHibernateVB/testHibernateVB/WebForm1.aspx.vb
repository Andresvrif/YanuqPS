Imports NHibernate
Imports NHibernate.Cfg

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sessionFactory = New Configuration().Configure().BuildSessionFactory()
        Dim cSession = sessionFactory.OpenSession()

        Dim result = cSession.QueryOver(Of test)().Where(Function(x) x.nombre = "andres").SingleOrDefault
        Label1.Text = result.nombre
        cSession.Close()

    End Sub

End Class