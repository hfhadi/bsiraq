<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddHouse.aspx.cs" Inherits="BSIraq.AddHouse" %>
<%@ register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %> 





<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">

    <table>
        <tr>
            <td>Address:</td>
            <td><input /></td>
        </tr>
        <tr>
            <td>Area:</td>
            <td><input /></td>
        </tr>
        <tr>
            <td>Price:</td>
            <td><input /></td>
        </tr>
        <tr>
            <td>Upload Image:</td>
            <td><input type="file" /></td>
        </tr>
         <tr>
            <td>موقع البيت على الخريطه</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
               
               
               
               <cc1:GMap ID="gMap" runat="server" enableServerEvents="true"   Width="600px" Height="500px" 
                    onclick="gMap_Click"  />
               
               
              </td>
        </tr>
    </table>




</asp:Content>


