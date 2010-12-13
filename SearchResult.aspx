<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchResult.aspx.cs" Inherits="BSIraq.SearchResult" %>
<%@ Register src="controls/HouseList.ascx" tagname="HouseList" tagprefix="uc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">


<<<<<<< HEAD


    <uc1:HouseList ID="ctrlHouseList" runat="server" />



=======
    
    
    
<table width="700">
    <tr>
        <asp:Repeater ID="rptr" runat="server">
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
                    | Bathrooms: <%# DataBinder.Eval(Container.DataItem, "Bathrooms")%><br />
                    City:<%# DataBinder.Eval(Container.DataItem, "City")%>
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
>>>>>>> 1d617138f88b6695e971d22c747daeacf8f33682

</asp:Content>
