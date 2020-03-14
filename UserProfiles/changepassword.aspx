<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="changepassword.aspx.cs" Inherits="SMWaterLevel.app.changepassword" %>

<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Change Password | SMWaterLevel
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <div class="content-wrapper">
        <section class="content-header">
            <h1>Change Password
            <small>Create</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="homepage.aspx"><i class="fa fa-dashboard"></i>Home</a></li>
                <li class="active">User Profiles</li>
                <li class="active">Change Password</li>
            </ol>
        </section>
        <section class="content">
            <div class="row">
                <div class="col-md-12">
                    <div class="box box-primary">
                        <div class="box-header with-border">
                            <h3 class="box-title">Change Password</h3>
                        </div>
                        <div class="box-body">
                            <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label>Username</label>
                                        <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter Username"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Current Password</label>
                                        <asp:TextBox ID="txtCurrentPassword" runat="server" CssClass="form-control" placeholder="Enter Current Password" TextMode="Password"></asp:TextBox>
                                    </div>
                                     <div class="form-group">
                                        <label>New Password</label>
                                        <asp:TextBox ID="txtNewPassword" runat="server" CssClass="form-control" placeholder="Enter New Password" TextMode="Password"></asp:TextBox>
                                    </div>
                                      <div class="form-group">
                                        <label>Confirm Password</label>
                                        <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="form-control" placeholder="Enter Confirm Password" TextMode="Password"></asp:TextBox>
                                    </div>
                                    
                                </div>
                            </div>
                        </div>
                 <div class="box-footer">
                            <asp:LinkButton ID="btnCancel" runat="server" CssClass="btn btn-default" OnClick="btnCancel_Click1"><i class="fa fa-rotate-left (alias)"></i> Cancel</asp:LinkButton>
                            <asp:LinkButton ID="btnChangePassword" runat="server" CssClass="btn btn-primary" OnClick="btnChangePassword_Click" ><i class="fa fa-lock"></i> Change Password</asp:LinkButton>
                        </div>
                       </div>
                </div>
                </div>
        </section> 
    </div>
        <div class="clearfix"></div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="script" runat="server">
    <script src="../AdminLTE/plugins/jQuery/jquery-2.2.3.min.js"></script>
</asp:Content>
