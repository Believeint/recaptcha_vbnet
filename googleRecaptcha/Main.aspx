<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Main.aspx.vb" Inherits="googleRecaptcha.Main" %>
<%@ Register TagPrefix="recaptcha" Namespace="Recaptcha" Assembly="Recaptcha" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Google Recaptcha</title>
    <script  src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <script src='https://www.google.com/recaptcha/api.js' async defer></script>
   
</head>
<body>

    <form id="form1" runat="server"> 
        

        <asp:Label runat="server" Text="Nome" />
        <asp:TextBox runat="server" ID="txtNome" />
        
        <div class="g-recaptcha" data-sitekey="6LflOcgUAAAAALFePPgAEOjjnKabQeAapMqCnCd7"></div>   
        <asp:Button runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <asp:Label runat="server" Visible="false" ID="lblResult"/>

     
     
      
    </form>
</body>
</html>
