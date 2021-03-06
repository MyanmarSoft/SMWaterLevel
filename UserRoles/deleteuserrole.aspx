﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="deleteuserrole.aspx.cs" Inherits="SMWaterLevel.UserRoles.deleteuserrole" %>
<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Delete User Role | SMWaterLevel
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <asp:ScriptManager ID="scriptManagerUserProfile" runat="server">
        </asp:ScriptManager>
    <div class="content-wrapper">
        <section class="content-header">
            <h1>Delete User Role
        <small>Remove</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="default"><i class="fa fa-dashboard"></i>Dashboard</a></li>
                <li><a href="#">User Roles</a></li>
                <li><a href="#">User Role List</a></li>
                <li class="active">Delete User Role</li>
            </ol>
        </section>
        <section class="content">
            <div class="row">
                <div class="col-md-12">
                    <div class="box box-primary">
                        <div class="box-header with-border">
                            <h3 class="box-title">Delete User Role</h3>
                        </div>
                        <div class="box-body">
                            <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label>Are you sure you want to delete?</label>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="box-footer">
                            <asp:LinkButton ID="btnCancel" runat="server" CssClass="btn btn-default" OnClick="btnCancel_Click"><i class="fa fa-rotate-left (alias)"></i> Cancel</asp:LinkButton>
                            <asp:LinkButton ID="btnYes" runat="server" CssClass="btn btn-primary pull-right" OnClick="btnYes_Click"><i class="fa fa-save (alias)"></i> Yes</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <div class="clearfix"></div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="script" runat="server">
    <script src="../AdminLTE/plugins/jQuery/jquery-2.2.3.min.js"></script>
</asp:Content>
