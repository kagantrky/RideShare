<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyTrips.aspx.cs" Inherits="RideShare.MyTrips" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvMyTrips" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-striped" DataKeyNames="PlanID" OnRowCommand="gvMyTrips_RowCommand">
        <Columns>
            <asp:BoundField DataField="WhereFrom" HeaderText="Nereden" />
            <asp:BoundField DataField="WhereTo" HeaderText="Nereye" />
            <asp:BoundField DataField="TripDate" HeaderText="Tarih" DataFormatString="{0:yyyy-MM-dd}" />
            <asp:BoundField DataField="TripHour" HeaderText="Saat" />
            <asp:BoundField DataField="Description" HeaderText="Açıklama" />
            <asp:BoundField DataField="Seats" HeaderText="Koltuk Sayısı" />
            <asp:TemplateField>
            <ItemTemplate>
                <asp:Button ID="btnDelete" runat="server" CommandName="DeleteTrip" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" Text="Sil" CssClass="btn btn-danger"/>
            </ItemTemplate>
        </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
