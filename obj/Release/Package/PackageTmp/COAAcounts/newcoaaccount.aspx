<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="newcoaaccount.aspx.cs" Inherits="SMAccount.COAAccounts.newcoaaccount" %>
<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    New COA Account | SMAccount
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <asp:ScriptManager ID="scriptManagerUserProfile" runat="server">
        </asp:ScriptManager>
    <div class="content-wrapper">
        <section class="content-header">
            <h1>New COA Account
        <small>Create</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="default"><i class="fa fa-dashboard"></i>Dashboard</a></li>
                <li><a href="#">COA Accounts</a></li>
                <li><a href="#">COA Account List</a></li>
                <li class="active">New COA Account</li>
            </ol>
        </section>
        <section class="content">
            <div class="row">
                <div class="col-md-12">
                    <div class="box box-primary">
                        <div class="box-header with-border">
                            <h3 class="box-title">Create COA Account</h3>
                        </div>
                        <div class="box-body">
                            <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                             <div class="row">
                                <div class="col-md-4">
                                     <div class="form-Account">
                                        <label>Account Category</label>
                                        <asp:DropDownList ID="ddlAccountCategory" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlAccountCategory_SelectedIndexChanged">
                                        </asp:DropDownList>                                    
                                     </div>
                                    <div class="form-Account">
                                        <label>Group</label>
                                         <asp:DropDownList ID="ddlParentGroup" runat="server" CssClass="form-control">
                                        </asp:DropDownList>        
                                    </div>
                                     <div class="form-Account">
                                        <label>Account Name</label>
                                        <asp:TextBox ID="txtAccountName" runat="server" CssClass="form-control" placeholder="Enter Account Name"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="box-footer">
                            <asp:LinkButton ID="btnCancel" runat="server" CssClass="btn btn-default" OnClick="btnCancel_Click"><i class="fa fa-rotate-left (alias)"></i> Cancel</asp:LinkButton>
                            <asp:LinkButton ID="btnSave" runat="server" CssClass="btn btn-primary pull-right" OnClick="btnSave_Click"><i class="fa fa-save (alias)"></i> Save</asp:LinkButton>
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

