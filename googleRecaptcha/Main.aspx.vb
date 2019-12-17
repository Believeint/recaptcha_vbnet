Imports System.Net
Imports Newtonsoft.Json
Imports Recaptcha

Public Class Main
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub




    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs)

        Dim captchaResponse = Request.Form("g-recaptcha-response")

        Dim result As ReCaptchaValidationResult = ReCaptchaValidator.IsValid(captchaResponse)
        Dim list As List(Of String) = New List(Of String)

        If Not result.Success Then
            lblResult.Text = "Falha!"
            lblResult.Visible = True
            For Each err As String In result.ErrorCodes
                list.Add(New String(err))
            Next
        Else
            lblResult.Text = "Sucesso!"
            lblResult.Visible = True
        End If



    End Sub
End Class