<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Sidebar.ascx.cs" Inherits="SMWaterLevel.UserControls.Sidebar" %>
<aside class="main-sidebar">
    <section class="sidebar">
       
        <ul class="sidebar-menu">
            <li class="header">MAIN NAVIGATION</li>
            <asp:Literal ID="ltlSideBar" runat="server"></asp:Literal>
            <li class="header">CONTACT US</li>
            <li class="treeview">
                <a href="/default.aspx">
                    <i class="fa fa-cube"></i><span>System</span>
                </a>
            </li>
            <li class="treeview">
                <a href="/default.aspx">
                    <i class="fa fa-question"></i><span>Help</span>
                </a>
            </li>

        </ul>
    </section>
</aside>
