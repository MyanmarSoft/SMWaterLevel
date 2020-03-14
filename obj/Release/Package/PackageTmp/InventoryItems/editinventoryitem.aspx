<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="editinventoryitem.aspx.cs" Inherits="SMAccount.InventoryItems.editinventoryitem" %>
<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Edit Inventory Item | SMAccount
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <asp:ScriptManager ID="scriptManagerUserProfile" runat="server">
        </asp:ScriptManager>
    <div class="content-wrapper">
        <section class="content-header">
            <h1>Edit Inventory Item
        <small>Modify</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="default"><i class="fa fa-dashboard"></i>Dashboard</a></li>
                <li><a href="#">InventoryItems</a></li>
                <li><a href="#">Inventory Item List</a></li>
                <li class="active">Edit Inventory Item</li>
            </ol>
        </section>
        <section class="content">
            <div class="row">
                <div class="col-md-12">
                    <div class="box box-primary">
                        <div class="box-header with-border">
                            <h3 class="box-title">Modify Inventory Item</h3>
                        </div>
                         <div class="box-body">
                            <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                             <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label>Item Code</label>
                                        <asp:TextBox ID="txtItemCode" runat="server" CssClass="form-control" placeholder="Enter Item Code"></asp:TextBox>
                                    </div>
                                     <div class="form-group">
                                        <label>Item Name</label>
                                        <asp:TextBox ID="txtItemName" runat="server" CssClass="form-control" placeholder="Enter Item Name"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Unit Name</label>
                                        <asp:DropDownList ID="ddlUnitName" runat="server" CssClass="form-control select2">
                                        </asp:DropDownList>                                        
                                    </div>
                                    <div class="form-group">
                                        <label>Purchase Price</label>
                                        <asp:TextBox ID="txtPurchasePrice" runat="server" CssClass="form-control" placeholder="Enter Purchase Price"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Sale Price</label>
                                        <asp:TextBox ID="txtSalePrice" runat="server" CssClass="form-control" placeholder="Enter Sale Price"></asp:TextBox>
                                    </div>
                                     <div class="form-group">
                                        <label>Description</label>
                                        <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control" placeholder="Enter Description" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Income Account Name</label>
                                        <asp:DropDownList ID="ddlIncomeAccount" runat="server" CssClass="form-control select2">
                                        </asp:DropDownList>                                        
                                    </div>
                                     <div class="form-group">
                                        <label>Expense Account Name</label>
                                        <asp:DropDownList ID="ddlExpenseAccount" runat="server" CssClass="form-control select2">
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


