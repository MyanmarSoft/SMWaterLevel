<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="editproject.aspx.cs" Inherits="SMAccount.Projects.editproject" %>
<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Edit Project | SMAccount
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <asp:ScriptManager ID="scriptManagerUserProfile" runat="server">
        </asp:ScriptManager>
    <div class="content-wrapper">
        <section class="content-header">
            <h1>Edit Project
        <small>Modify</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="default"><i class="fa fa-dashboard"></i>Dashboard</a></li>
                <li><a href="#">Projects</a></li>
                <li><a href="#">Project List</a></li>
                <li class="active">Edit Project</li>
            </ol>
        </section>
        <section class="content">
            <div class="row">
                <div class="col-md-12">
                    <div class="box box-primary">
                        <div class="box-header with-border">
                            <h3 class="box-title">Modify Project</h3>
                        </div>
                         <div class="box-body">
                            <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                             <div class="row">
                                <div class="col-md-4">
                                     <div class="form-group">
                                        <label>Project Name</label>
                                        <asp:TextBox ID="txtProjectName" runat="server" CssClass="form-control" placeholder="Enter Project Name"></asp:TextBox>
                                    </div>
                                     <div class="form-group">
                                        <label>Project Category</label>
                                        <asp:DropDownList ID="ddlProjectCategory" runat="server" CssClass="form-control">
                                        </asp:DropDownList>                                    
                                     </div>
                                     <div class="form-group">
                                        <label>Customer</label>
                                         <asp:DropDownList ID="ddlCustomer" runat="server" CssClass="form-control">
                                        </asp:DropDownList>        
                                    </div>
                                     <div class="form-group">
                                        <label>Project Status</label>
                                         <asp:DropDownList ID="ddlProjectStatus" runat="server" CssClass="form-control">
                                        </asp:DropDownList>        
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="box-footer">
                            <asp:LinkButton ID="btnCancel" runat="server" CssClass="btn btn-default" OnClick="btnCancel_Click"><i class="fa fa-rotate-left (alias)"></i> Cancel</asp:LinkButton>
                            <asp:LinkButton ID="btnEdit" runat="server" CssClass="btn btn-primary pull-right" OnClick="btnEdit_Click" ><i class="fa fa-pencil"></i> Edit</asp:LinkButton>
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


