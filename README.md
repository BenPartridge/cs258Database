# cs258Database

<%@ Master Language="C#" AutoEventWireup="true" CodeFile="Site.master.cs" Inherits="SiteMaster" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <title><%: Page.Title %> - My ASP.NET Application</title>
    <asp:PlaceHolder runat="server">      
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
    <webopt:BundleReference runat="server" Path="~/Content/css" /> 
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <meta name="viewport" content="width=device-width" />
    <asp:ContentPlaceHolder runat="server" ID="HeadContent" />
</head>
<body>
    <form runat="server">
    <asp:ScriptManager runat="server">
        <Scripts>
            <%--To learn more about bundling scripts in ScriptManager see http://go.microsoft.com/fwlink/?LinkID=272931&clcid=0x409 --%>
            <%--Framework scripts--%>
            <asp:ScriptReference Name="MsAjaxBundle" />
            <asp:ScriptReference Name="jquery" />
            <asp:ScriptReference Name="jquery.ui.combined" />
            <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
            <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
            <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
            <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
            <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
            <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
            <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
            <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
            <asp:ScriptReference Name="WebFormsBundle" />
            <%--Site scripts--%>

        </Scripts>
    </asp:ScriptManager>
    <header>
        <div class="content-wrapper">
            <div class="float-left">
                <p class="site-title">
                    <a runat="server" href="~/">This is my logo</a></p>
            </div>
            <div class="float-right">
                <section id="login">
                    <asp:LoginView runat="server" ViewStateMode="Disabled">
                        <AnonymousTemplate>
                            <ul>
                                <li><a id="registerLink" runat="server" href="~/Account/Register">Sing UP</a></li>
                                <li><a id="loginLink" runat="server" href="~/Account/Login">Sign In</a></li>
                            </ul>
                        </AnonymousTemplate>
                        <LoggedInTemplate>
                            <p>
                                Hello, <a runat="server" class="username" href="~/Account/Manage" title="Manage your account">
                                    <asp:LoginName runat="server" CssClass="username" />
                                </a>!
                                <asp:LoginStatus runat="server" LogoutAction="Redirect" LogoutText="Log off" LogoutPageUrl="~/" />
                            </p>
                        </LoggedInTemplate>
                    </asp:LoginView>
                </section>
                <nav>
                    <ul id="menu">
                        <li><a runat="server" href="~/">Home Page</a></li>
                        <li><a runat="server" href="~/About">About Us</a></li>
                        <li><a runat="server" href="~/Contact">Contact Me</a></li>
                    </ul>
                </nav>
            </div>
        </div>
    </header>
    <div id="body">
        <asp:ContentPlaceHolder runat="server" ID="FeaturedContent" />
        <section class="content-wrapper main-content clear-fix">
            <asp:ContentPlaceHolder runat="server" ID="MainContent" />
        </section>
    </div>
    <footer>
        <div class="content-wrapper">
            <div class="float-left">
                <p>
                    &copy; <%: DateTime.Now.Year %> - My ASP.NET Application
                </p>
            </div>
        </div>
    </footer>
    </form>
</body>
</html>
