<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="inventoryitemlist.aspx.cs" Inherits="SMAccount.InventoryItems.inventoryitemlist" %>

<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<%@ Register Src="../UserControls/Pager.ascx" TagName="Pager" TagPrefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Inventory Item List | SMAccount
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../AdminLTE/plugins/datatables/dataTables.bootstrap.css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Inventory Item List
        <small>View</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Dashboard</a></li>
                <li><a href="#"><i class="fa fa-cube"></i>Inventory Items</a></li>
                <li class="active">Inventory Item List</li>
            </ol>
        </section>
        <!-- Main content -->
        <section class="content">
            <div class="box-body">
                <div class="row">
                    <div class="col-xs-6">
                    </div>
                    <div class="col-xs-6">
                        <div class="btn-group pull-right">
                            <asp:LinkButton ID="btnNewInventoryItem" runat="server" CssClass="btn btn-primary btn-flat" OnClick="btnNewInventoryItem_Click"><i class="fa fa-plus"></i> New Inventory Item</asp:LinkButton>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="input-group">
                            <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control pull-right" placeholder="Search" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>
                            <div class="input-group-btn">
                                <asp:LinkButton ID="btnSearch" runat="server" CssClass="btn btn-default" OnClick="btnSearch_Click"><i class="fa fa-search"></i></asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row" style="margin-top: 20px">
                    <div class="col-xs-12">
                        <div class="box box-primary">
                            <div class="box-header">
                                <h3 class="box-title">Inventory Item List</h3>

<%--                                <div class="box-tools">
                                </div>--%>
                            </div>
                            <!-- /.box-header -->
                            <div class="box-body table-responsive">
                                <asp:Repeater ID="rptInventoryItemList" runat="server">
                                    <HeaderTemplate>
                                        <table class="table table-hover table-bordered table-striped">
                                            <tr>
                                                <th>
                                                    <asp:LinkButton ID="btnID" runat="server" CssClass="btn-flat" CommandName="ID">ID <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                <th>
                                                    <asp:LinkButton ID="btnItemCode" runat="server" CssClass="btn-flat" CommandName="ItemCode">Item Code <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                <th>
                                                    <asp:LinkButton ID="btnItemName" runat="server" CssClass="btn-flat" CommandName="ItemName">Item Name <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                 <th>
                                                    <asp:LinkButton ID="btnDescription" runat="server" CssClass="btn-flat" CommandName="Description">Description <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                <th>
                                                    <asp:LinkButton ID="btnUnitName" runat="server" CssClass="btn-flat" CommandName="UnitName">Unit Name <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                <th>
                                                    <asp:LinkButton ID="btnPurchasePrice" runat="server" CssClass="btn-flat" CommandName="PurchasePrice">Purchase Price <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                 <th>
                                                    <asp:LinkButton ID="btnSalePrice" runat="server" CssClass="btn-flat" CommandName="SalePrice">Sale Price <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                 <th>
                                                    <asp:LinkButton ID="btnQtyToReceive" runat="server" CssClass="btn-flat" CommandName="QtyToReceive">Qty To Receive <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                 <th>
                                                    <asp:LinkButton ID="btnQtyOnHand" runat="server" CssClass="btn-flat" CommandName="QtyOnHand">Qty On Hand <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                 <th>
                                                    <asp:LinkButton ID="btnQtyToDeliver" runat="server" CssClass="btn-flat" CommandName="QtyToDeliver">Qty To Deliver <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                 <th>
                                                    <asp:LinkButton ID="btnQtyToOwned" runat="server" CssClass="btn-flat" CommandName="QtyToOwned">Qty To Owned <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                 <th>
                                                    <asp:LinkButton ID="btnAverageCost" runat="server" CssClass="btn-flat" CommandName="AverageCost">Average Cost <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                 <th>
                                                    <asp:LinkButton ID="btnTotalCost" runat="server" CssClass="btn-flat" CommandName="TotalCost">Total Cost <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                <th>
                                                    <asp:LinkButton ID="btnStatus" runat="server" CssClass="btn-flat" CommandName="Status">Status <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                <th style="width: 150px">Action</th>
                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "ID")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "ItemCode")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "ItemName")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "Description")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "UnitName")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "PurchasePrice")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "SalePrice")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "QtyToReceive")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "QtyOnHand")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "QtyToDeliver")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "QtyOwned")%>
                                            </td>
                                             <td>
                                                <%# DataBinder.Eval(Container.DataItem, "AverageCost")%>
                                            </td>
                                             <td>
                                                <%# DataBinder.Eval(Container.DataItem, "TotalCost")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "Status")%>
                                            </td>
                                            <td>
                                                <a href="editinventoryItem.aspx?InventoryItemID=<%# (DataBinder.Eval(Container.DataItem, "ID"))%>" class="btn-sm btn-flat btn-primary"><i class="fa fa-pencil"></i>Edit</a>
                                                <a href="deleteinventoryItem.aspx?InventoryItemID=<%# (DataBinder.Eval(Container.DataItem, "ID"))%>" class="btn-sm btn-flat btn-danger"><i class="fa fa-trash"></i>Delete</a>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </table>
                                    </FooterTemplate>

                                </asp:Repeater>
                            </div>
                            <uc1:Pager ID="Pager1" runat="server" NumberOfPages="10" PageSize="10" ControlToBind="rptInventoryItemList" OnChange="Pager1_Change" />

                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="script" runat="server">
    <script src="../AdminLTE/plugins/jQuery/jquery-2.2.3.min.js"></script>
    <script src="../AdminLTE/plugins/datatables/jquery.dataTables.min.js"></script>
    <script src="../AdminLTE/plugins/datatables/dataTables.bootstrap.min.js"></script>
    <script src="../AdminLTE/dist/js/app.min.js"></script>
</asp:Content>
