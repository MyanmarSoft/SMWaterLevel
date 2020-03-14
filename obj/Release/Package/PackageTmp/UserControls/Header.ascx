<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="SMAccount.UserControls.Header" %>
<header class="main-header">
    <a href="/signin.aspx" class="logo">
        <span class="logo-mini">
            SMA</span>
        <span class="logo-lg">
            SMAccount</span>
    </a>
    <nav class="navbar navbar-static-top">
        <a href="#" class="sidebar-toggle" data-toggle="offcanvas" role="button">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
        </a>
        <div class="navbar-custom-menu">
            <ul class="nav navbar-nav">
                <li class="dropdown notifications-menu">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                        <i class="fa fa-bell-o"></i>
                        <span class="label label-warning">10</span>
                    </a>
                    <ul class="dropdown-menu">
                        <li class="header">You have 10 notifications</li>
                        <li>
                            <ul class="menu">
                                <li>
                                    <a href="#">
                                        <i class="fa fa-users text-aqua"></i>5 new members joined today
                                    </a>
                                </li>
                                <li>
                                    <a href="#">
                                        <i class="fa fa-warning text-yellow"></i>Very long description here that may not fit into the
                      page and may cause design problems
                                    </a>
                                </li>
                                <li>
                                    <a href="#">
                                        <i class="fa fa-users text-red"></i>5 new members joined
                                    </a>
                                </li>
                                <li>
                                    <a href="#">
                                        <i class="fa fa-shopping-cart text-green"></i>25 sales made
                                    </a>
                                </li>
                                <li>
                                    <a href="#">
                                        <i class="fa fa-user text-red"></i>You changed your username
                                    </a>
                                </li>
                            </ul>
                        </li>
                        <li class="footer"><a href="#">View all</a></li>
                    </ul>
                </li>

                <li class="dropdown user user-menu">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                        <asp:Image ID="imgProfilePicture" runat="server" CssClass="user-image" alt="User Image" ImageUrl="~/AdminLTE/dist/img/userprofile.png" />
                        <span class="hidden-xs">
                            <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label></span>
                    </a>
                    <ul class="dropdown-menu">
                        <li class="user-header">
                            <asp:Image ID="imgProfileCirclePicture" runat="server" CssClass="img-circle" alt="User Image" ImageUrl="~/AdminLTE/dist/img/userprofile.png" />
                            <p>
                                <asp:Label ID="lblNameCircle" runat="server"></asp:Label>
                                <small>
                                    <asp:Label ID="lblRole" runat="server"></asp:Label></small>
                            </p>
                        </li>
                   <%--     <li class="user-body">
                            <div class="row">
                                <div class="col-xs-4 text-center">
                                    <a href="#">Followers</a>
                                </div>
                                <div class="col-xs-4 text-center">
                                    <a href="#">Sales</a>
                                </div>
                                <div class="col-xs-4 text-center">
                                    <a href="#">Friends</a>
                                </div>
                            </div>
                        </li>--%>
                        <li class="user-footer">
                            <div class="pull-left">
                                <asp:LinkButton ID="btnProfile" runat="server" CssClass="btn btn-warning btn-flat" OnClick="btnProfile_Click"><i class="glyphicon glyphicon-search"></i> User Profile</asp:LinkButton>
                            </div>
                            <div class="pull-right">
                                <asp:LinkButton ID="btnSignout" runat="server" CssClass="btn btn-danger btn-flat" OnClick="btnSignout_Click"><i class="glyphicon glyphicon-log-out"></i> Sign out</asp:LinkButton>
                            </div>
                        </li>
                    </ul>
                </li>
                <li>
            <a href="#" data-toggle="control-sidebar"><i class="fa fa-gears"></i></a>
          </li>
            </ul>
        </div>
    </nav>
</header>
