Public Class Page2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblRes.Text = "Hello " + Session("sess")
        lblRes.Visible = True

        Dim captchaResponse = Request.Form("g-Recaptcha-Response")

        lblRes.Text = captchaResponse
        lblRes.Visible = True
    End Sub

End Class