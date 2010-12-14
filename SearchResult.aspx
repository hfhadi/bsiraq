<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchResult.aspx.cs" Inherits="BSIraq.SearchResult" %>
<%@ Register src="controls/HouseList.ascx" tagname="HouseList" tagprefix="uc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
<uc1:HouseList ID="ctrlHouseList" runat="server" />
</asp:Content>
