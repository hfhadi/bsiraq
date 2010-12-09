<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Map.aspx.cs" Inherits="BSIraq.Map" Title="Untitled Page" %>
<%@ register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">

<div style="float:left">
 Hello World la la la what is up
 <cc1:GMap ID="GMap1" runat="server" Width="900px" Height="600px" 
         /> 
</div>

<asp:Button ID="Button1" runat="server" Text="Button" />
</asp:Content>
