Imports System
Imports Spring.Context
Imports Spring.Context.Support

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ctx As IApplicationContext = ContextRegistry.GetContext()
        'We call the same Object, but isn't 
        Dim performer As Performer = ctx.GetObject("poeticDuke")
        Dim performer2 As Performer = ctx.GetObject("poeticDuke")

        'Singleton Pattern, because use a Unique Instance (in XML use factory-method to get a UniqueInstance)
        Dim a As Stage = ctx.GetObject("theStage")
        Dim b As Stage = ctx.GetObject("theStage")

        'They will be different Objects
        Dim c As ticket = ctx.GetObject("ticket")
        Dim d As ticket = ctx.GetObject("ticket")

        Label1.Text = performer.perform
        Label2.Text = a Is b
        Label3.Text = performer Is performer2
        Label4.Text = c Is d
    End Sub

End Class