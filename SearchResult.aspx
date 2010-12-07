<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchResult.aspx.cs" Inherits="BSIraq.SearchResult" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">


    <asp:GridView ID="dataDump" runat="server">
    </asp:GridView>

<table width="700">
    <tr>
        <asp:Repeater ID="rptr" runat=server>
          <ItemTemplate>
            <tr>
                <td valign="top">
                    <img src="/housesImages/h<%# DataBinder.Eval(Container.DataItem, "ID") %>.bmp" />
                </td>
                <td valign="top">
                    
                    <b><%# DataBinder.Eval(Container.DataItem, "Title") %></b>
                    <br /><br />
                    <%# DataBinder.Eval(Container.DataItem, "Description") %>
                    <br /> <br />
                    Rooms: <%# DataBinder.Eval(Container.DataItem, "Rooms") %>
                    | Bathrooms: <%# DataBinder.Eval(Container.DataItem, "Bathrooms")%>
                </td>
                <td valign="top">
                    <font color="red">
                         <%# DataBinder.Eval(Container.DataItem, "Price") %>
                    </font>
                </td>
            </tr>
            <tr><td colspan=3><hr /></td></tr>
          </ItemTemplate>
        </asp:Repeater>
    </tr>
</table>

</asp:Content>
