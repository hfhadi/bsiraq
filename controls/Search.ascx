<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Search.ascx.cs" Inherits="BSIraq.controls.Search" %>
<table>
    <tr>
        <td>Province</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Text="Baghdad" />
                <asp:ListItem Text="Karbala" />
            </asp:DropDownList>
        </td>
        <td>Price&nbsp;Range</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Text="1-10" />
                <asp:ListItem Text="10-100" />
                <asp:ListItem Text="100-1000" />
            </asp:DropDownList>
        </td>
        <td>Rooms</td>
        <td>
            <asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem Text="1" />
                <asp:ListItem Text="1+" />
                <asp:ListItem Text="2" />
                <asp:ListItem Text="2+" />
                <asp:ListItem Text="3" />
                <asp:ListItem Text="3+" />
                <asp:ListItem Text="4" />
                <asp:ListItem Text="4+" />
            </asp:DropDownList>
        </td>
        <td colspan=2>
            <asp:Button ID="Button1" runat="server" Text="Search" onclick="btnSearch" />
        </td>
    </tr>
    
</table>