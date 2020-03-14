<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="newcustomer.aspx.cs" Inherits="SMWaterLevel.Customers.newcustomer" %>
<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    New Customer | SMWaterLevel
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <asp:ScriptManager ID="scriptManagerUserProfile" runat="server">
        </asp:ScriptManager>
    <div class="content-wrapper">
        <section class="content-header">
            <h1>New Customer
        <small>Create</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="default"><i class="fa fa-dashboard"></i>Dashboard</a></li>
                <li><a href="#">Customers</a></li>
                <li><a href="#">Customer List</a></li>
                <li class="active">New Customer</li>
            </ol>
        </section>
        <section class="content">
            <div class="row">
                <div class="col-md-12">
                    <div class="box box-primary">
                        <div class="box-header with-border">
                            <h3 class="box-title">Create Customer</h3>
                        </div>
                        <div class="box-body">
                            <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label>Customer Name</label>
                                        <asp:TextBox ID="txtCustomerName" runat="server" CssClass="form-control" placeholder="Enter Customer Name"></asp:TextBox>
                                    </div>
                                     <div class="form-group">
                                        <label>Phone</label>
                                        <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" placeholder="Enter Phone"></asp:TextBox>
                                    </div>
                                       <div class="form-group">
                                        <label>Address</label>
                                        <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" placeholder="Enter Address" TextMode="MultiLine"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <asp:Image ID="imgCustomer" runat="server" CssClass="profile-user-img img-responsive img-thumbnail" ImageUrl="~/AdminLTE/dist/img/default.png" />
                                    </div>
                                    <div class="form-group">
                                        <asp:FileUpload ID="FileUploadCustomerImage" runat="server" />
                                    </div>
                                    <div class="form-group">
                                        <asp:Button ID="btnUpload" runat="server" Text="Upload" CssClass="btn btn-primary btn-flat" OnClick="btnUpload_Click" />
                                        <asp:Literal ID="ltlImagePath" runat="server"></asp:Literal>
                                    </div>
                                    </div>
                            </div>
                        </div>
                        <div class="box-footer">
                            <asp:LinkButton ID="btnCancel" runat="server" CssClass="btn btn-default btn-flat" OnClick="btnCancel_Click" ><i class="fa fa-rotate-left (alias)"></i> Cancel</asp:LinkButton>
                            <asp:LinkButton ID="btnSave" runat="server" CssClass="btn btn-primary btn-flat pull-right" OnClick="btnSave_Click" ><i class="fa fa-save (alias)"></i> Save</asp:LinkButton>
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

