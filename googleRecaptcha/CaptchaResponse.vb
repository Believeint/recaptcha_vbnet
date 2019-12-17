Imports System.Linq
Imports System.Web
Imports Newtonsoft.Json
Imports System
Imports System.Collections.Generic

Public Class CaptchaResponse
    <JsonProperty("success")>
    Public Property Success As Boolean
    <JsonProperty("error-codes")>
    Public Property ErrorMessage As List(Of String)
End Class
