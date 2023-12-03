<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateTravelPlan.aspx.cs" Inherits="RideShare.CreateTravelPlan" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Seyahat Planı Oluştur</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label for="txtFrom">Nereden:</label>
        <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
        <br />
        <label for="txtTo">Nereye:</label>
        <asp:TextBox ID="txtTo" runat="server"></asp:TextBox>
        <br />
<%--        <label for="txtDateTime">Tarih ve Saat:</label>
        <asp:TextBox ID="txtDateTime" runat="server" TextMode="DateTime" CssClass="form-control"></asp:TextBox>
        <br />--%>
        <label for="txtDate">Tarih:</label>
        <asp:TextBox ID="txtDate" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <%--<label for="txtTripHour">Seyahat Saati:</label>
        <asp:TextBox ID="txtTripHour" runat="server" TextMode="Time"></asp:TextBox>
        <br />--%>
        <label for="txtTripHour">Seyahat Saati (HH:mm):</label>
        <asp:TextBox ID="txtTripHour" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <label for="txtDescription">Açıklama:</label>
        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <label for="txtSeatCount">Koltuk Sayısı:</label>
        <asp:TextBox ID="txtSeatCount" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <asp:Button ID="btnCreatePlan" runat="server" Text="Plan Oluştur" OnClick="btnCreatePlan_Click" />
    </div>
    </form>
</body>
</html>
