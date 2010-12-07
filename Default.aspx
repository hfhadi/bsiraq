<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<telerik:RadStyleSheetManager id="RadStyleSheetManager1" runat="server" />
</head>
<body>
    <form id="form1" runat="server">
	<telerik:RadScriptManager ID="RadScriptManager1" runat="server">
		<Scripts>
			<%--Needed for JavaScript IntelliSense in VS2010--%>
			<%--For VS2008 replace RadScriptManager with ScriptManager--%>
			<asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
			<asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
			<asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
		</Scripts>
	</telerik:RadScriptManager>
	<script type="text/javascript">
		//Put your JavaScript code here.
    </script>
	<telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
	</telerik:RadAjaxManager>
 
	<telerik:RadSkinManager ID="RadSkinManager1" Runat="server" Skin="Sitefinity">
	</telerik:RadSkinManager>
	<div>

	</div>
	<telerik:RadMenu ID="RadMenu1" Runat="server">
        <Items>
            <telerik:RadMenuItem runat="server" Text="Home">
            </telerik:RadMenuItem>
            <telerik:RadMenuItem runat="server" Text="Buyers">
                <Items>
                    <telerik:RadMenuItem runat="server" Text="Search for property">
                    </telerik:RadMenuItem>
                    <telerik:RadMenuItem runat="server" Text="Why buy on BSIRaq">
                    </telerik:RadMenuItem>
                    <telerik:RadMenuItem runat="server" Text="Steps to buy a property">
                    </telerik:RadMenuItem>
                    <telerik:RadMenuItem runat="server" Text="Offer to purchase and documents">
                    </telerik:RadMenuItem>
                    <telerik:RadMenuItem runat="server" Text="Your buyer account">
                    </telerik:RadMenuItem>
                </Items>
            </telerik:RadMenuItem>
            <telerik:RadMenuItem runat="server" Text="Sellers">
                <Items>
                    <telerik:RadMenuItem runat="server" Text="How it works?">
                    </telerik:RadMenuItem>
                    <telerik:RadMenuItem runat="server" Text="Why choose us?">
                    </telerik:RadMenuItem>
                    <telerik:RadMenuItem runat="server" Text="Fees and subscriptions">
                    </telerik:RadMenuItem>
                    <telerik:RadMenuItem runat="server" Text="Learn to sell your house">
                    </telerik:RadMenuItem>
                    <telerik:RadMenuItem runat="server" Text="Your seller account">
                    </telerik:RadMenuItem>
                </Items>
            </telerik:RadMenuItem>
        </Items>
    </telerik:RadMenu>
	</form>
</body>
</html>
