<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RideShare._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Oturum açılmamışsa Butonlar Görünecek -->
<%--    <div id="initialButtons" runat="server" style="text-align: center; display: none;">
        <asp:Button ID="btnRegister" runat="server" Text="Kayıt Ol" OnClick="btnRegister_Click" CssClass="btn btn-primary" />
        <asp:Button ID="btnLogin" runat="server" Text="Giriş Yap" OnClick="btnLogin_Click" CssClass="btn btn-secondary" />
    </div>--%>

    <!-- Oturum açılmışsa İçerik Görünecek -->
<%--    <div id="mainContent" runat="server" style="display: none;">--%>
        <asp:TextBox ID="txtWhereFrom" runat="server" placeholder="Nereden"></asp:TextBox>
        <asp:TextBox ID="txtWhereTo" runat="server" placeholder="Nereye"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="Ara" OnClick="btnSearch_Click" />

        <asp:GridView ID="gvTripPlans" runat="server" AutoGenerateColumns="False" CssClass="table" OnRowCommand="gvTripPlans_RowCommand">
            <Columns>
                <asp:BoundField DataField="WhereFrom" HeaderText="Nereden" />
                <asp:BoundField DataField="WhereTo" HeaderText="Nereye" />
                <asp:BoundField DataField="TripDate" HeaderText="Tarih" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="TripHour" HeaderText="Saat" />
                <asp:BoundField DataField="Description" HeaderText="Açıklama" />
                <asp:BoundField DataField="Seats" HeaderText="Koltuk Sayısı" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnJoin" runat="server" CommandName="JoinTrip" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" Text="Katıl" CssClass="btn btn-primary"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    <!-- Güncel Seyahatler başlığı -->
    <h2>Güncel Seyahatler</h2>
    
    <!-- Güncel Seyahatler GridView -->
    <asp:GridView ID="gvCurrentTrips" runat="server" AutoGenerateColumns="False" CssClass="table" OnRowCommand="gvCurrentTrips_RowCommand" DataKeyNames="PlanID">
        <Columns>
            <asp:BoundField DataField="WhereFrom" HeaderText="Nereden" />
            <asp:BoundField DataField="WhereTo" HeaderText="Nereye" />
            <asp:BoundField DataField="TripDate" HeaderText="Tarih" DataFormatString="{0:dd/MM/yyyy}" />
            <asp:BoundField DataField="TripHour" HeaderText="Saat" />
            <asp:BoundField DataField="Description" HeaderText="Açıklama" />
            <asp:BoundField DataField="Seats" HeaderText="Koltuk Sayısı" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnJoin" runat="server" CommandName="JoinTrip" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" Text="Katıl" CssClass="btn btn-primary"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <%--</div>--%>

</asp:Content>

