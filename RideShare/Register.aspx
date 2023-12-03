<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RideShare.Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kullanıcı Kaydı</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label for="txtFirstName">Ad:</label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br />
        <label for="txtLastName">Soyad:</label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        <label for="txtEmail">E-posta:</label>
        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
        <br />
        <label for="txtPassword">Şifre:</label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="btnRegister" runat="server" Text="Kayıt Ol" OnClick="btnRegister_Click" />
    </div>
    </form>
</body>
</html>
