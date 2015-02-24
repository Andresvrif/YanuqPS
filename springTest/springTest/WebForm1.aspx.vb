Imports System
Imports Spring.Context
Imports Spring.Context.Support
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ctx As IApplicationContext = ContextRegistry.GetContext()
        Dim performer As Performer = ctx.GetObject("poeticDuke")
        Label1.Text = performer.perform
    End Sub

End Class