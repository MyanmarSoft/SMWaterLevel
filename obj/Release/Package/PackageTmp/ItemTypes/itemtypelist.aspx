﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="itemtypelist.aspx.cs" Inherits="SMAccount.ItemTypes.itemtypelist" %>

<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Item Type List| SMAccount
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../AdminLTE/plugins/datatables/dataTables.bootstrap.css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Item Type List
        <small>View</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Dashboard</a></li>
                <li><a href="#"><i class="fa fa-cube"></i>ItemTypes</a></li>
                <li class="active">Item Type List</li>
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
                            <asp:LinkButton ID="btnNewItemType" runat="server" CssClass="btn btn-primary btn-flat" OnClick="btnNewItemType_Click"><i class="fa fa-plus"></i> New Item Type</asp:LinkButton>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <label>Item Name</label>
                        <div class="input-group">
                            <asp:TextBox ID="txtSearch" runat="server" class="form-control pull-right" placeholder="Search"></asp:TextBox>
                            <div class="input-group-btn">
                                <asp:LinkButton ID="btnSearch" runat="server" CssClass="btn btn-default"><i class="fa fa-search"></i></asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row" style="margin-top: 20px">
                    <div class="col-xs-12">
                        <div class="box box-primary">
                            <div class="box-header">
                                <h3 class="box-title">Item  Type List</h3>
                                <div class="box-tools">
                                </div>
                            </div>
                            <!-- /.box-header -->
                            <div class="box-body table-responsive">
                                <asp:Repeater ID="rptItemTypeList" runat="server" OnItemCommand="rptItemTypeList_ItemCommand">
                                    <HeaderTemplate>
                                        <table class="table table-hover table-bordered table-striped">
                                            <tr>
                                                <th>
                                                    <asp:LinkButton ID="btnID" runat="server" CssClass="btn-flat" CommandName="ID">ID <i class="fa fa-sort"></i></asp:LinkButton>
                                                    <th>
                                                        <asp:LinkButton ID="btnItemTypeName" runat="server" CssClass="btn-flat" CommandName="ItemTypeName">Item Type Name <i class="fa fa-sort"></i></asp:LinkButton></th>
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
                                                <%# DataBinder.Eval(Container.DataItem, "ItemTypeName")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "Status")%>
                                            </td>
                                            <td>
                                                <a href="edititemtype.aspx?ItemTypeID=<%# (DataBinder.Eval(Container.DataItem, "ID"))%>" class="btn-sm btn-flat btn-primary"><i class="fa fa-pencil"></i>Edit</a>
                                                <a href="deleteitemtype.aspx?ItemTypeID=<%# (DataBinder.Eval(Container.DataItem, "ID"))%>" class="btn-sm btn-flat btn-danger"><i class="fa fa-trash"></i>Delete</a>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </table>
                                    </FooterTemplate>

                                </asp:Repeater>
                            </div>
                            <div class="box-footer clearfix">
                                <ul class="pagination pagination-sm no-margin pull-right">
                                    <asp:Repeater ID="rptPaging" runat="server" OnItemCommand="rptPaging_ItemCommand">
                                        <ItemTemplate>
                                            <li>
                                                <asp:LinkButton ID="btnPage"
                                                    CommandName="Page" CommandArgument="<%# Container.DataItem %>"
                                                    runat="server"><%# Container.DataItem %>
                                                </asp:LinkButton></li>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </ul>
                            </div>
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
