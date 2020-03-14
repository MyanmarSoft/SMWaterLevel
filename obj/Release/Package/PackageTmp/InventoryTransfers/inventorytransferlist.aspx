<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="inventorytransferlist.aspx.cs" Inherits="SMAccount.InventoryTransfers.inventorytransferlist" %>

<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<%@ Register src="../UserControls/Pager.ascx" tagname="Pager" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Invoice List | SMAccount
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../AdminLTE/plugins/datatables/dataTables.bootstrap.css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>Invoice List
        <small>View</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Dashboard</a></li>
                <li><a href="#"><i class="ion ion-bag"></i>Invoices</a></li>
                <li class="active">Invoice List</li>
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
                            <asp:LinkButton ID="btnNewInvoice" runat="server" CssClass="btn btn-primary btn-flat" OnClick="btnNewInvoice_Click"><i class="fa fa-plus"></i> New Inventory Transfer</asp:LinkButton>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <label>Invoice No</label>
                        <div class="input-group">
                            <asp:TextBox ID="txtInvoiceNo" runat="server" class="form-control pull-right" OnTextChanged="txtInvoiceNo_TextChanged" AutoPostBack="true"></asp:TextBox>
                            <div class="input-group-btn">
                                <asp:LinkButton ID="btnSearch" runat="server" CssClass="btn btn-default" OnClick="btnSearch_Click"><i class="fa fa-search"></i></asp:LinkButton>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3">
                                            <div class="form-group">
                                                <label>From Date</label>
                                                <div class="input-group date" id="fromDate">
                                                    <div class="input-group-addon">
                                                        <i class="fa fa-calendar"></i>
                                                    </div>
                                                    <asp:TextBox ID="txtFromDate" runat="server" CssClass="form-control pull-right"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                     <div class="col-md-5">
                                            <div class="form-group">
                                                <label>To Date</label>
                                                <div class="input-group date" id="toDate">
                                                    <div class="input-group-addon">
                                                        <i class="fa fa-calendar"></i>
                                                    </div>
                                                    <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control pull-right"></asp:TextBox>
                                                <div class="input-group-btn">
                                <asp:LinkButton ID="btnSearchInvoiceDate" runat="server" CssClass="btn btn-primary btn-flat" OnClick="btnSearchInvoiceDate_Click"><i class="fa fa-search"></i></asp:LinkButton>
                            </div>
                                                </div>
                                            </div>
                                        </div>
                   
                </div>
                <div class="row" style="margin-top: 20px">
                    <div class="col-xs-12">
                        <div class="box box-primary">
                            <div class="box-header">
                                <h3 class="box-title">Invoice List</h3>
                                <div class="box-tools">
                                </div>
                            </div>
                            <div class="box-body table-responsive">
                              <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>

                                <asp:Repeater ID="rptInvoiceList" runat="server" OnItemCommand="rptInvoiceList_ItemCommand">
                                    <HeaderTemplate>
                                        <table class="table table-hover table-bordered table-striped">
                                            <tr>
                                                 <th>
                                                    <asp:LinkButton ID="btnInventoryTransferNo" runat="server" CssClass="btn-flat" CommandName="InventoryTransferNo">Inventory Transfer No <i class="fa fa-sort"></i></asp:LinkButton></th>
                                            
                                                 <th>
                                                    <asp:LinkButton ID="btnFromInventoryLocation" runat="server" CssClass="btn-flat" CommandName="FromInventoryLocation">From <i class="fa fa-sort"></i></asp:LinkButton></th>
                                       
                                                 <th>
                                                     <asp:LinkButton ID="btnToInventoryLocation" runat="server" CssClass="btn-flat" CommandName="ToInventoryLocation">To <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                <th>
                                                    <asp:LinkButton ID="btnNetTotal" runat="server" CssClass="btn-flat" CommandName="NetTotal">Net Total<i class="fa fa-sort"></i></asp:LinkButton></th>
                                                 <th>
                                                    <asp:LinkButton ID="btnInventoryTransferDate" runat="server" CssClass="btn-flat" CommandName="InvoiceDate">Inventory Transfer Date <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                <th>
                                                    <asp:LinkButton ID="btnStatus" runat="server" CssClass="btn-flat" CommandName="Status">Status <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                <th style="width: 250px">Action</th>
                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "InventoryTransferNo")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "FromInventoryLocationName")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "ToInventoryLocationName")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "NetTotal")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "InventoryTransferDate","{0:dd/MM/yyyy}")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "Status")%>
                                            </td>
                                            <td>
                                                <a href="editinvoice.aspx?InvoiceNo=<%# (DataBinder.Eval(Container.DataItem, "InventoryTransferNo"))%>" class="btn-sm btn-flat btn-primary"><i class="fa fa-pencil"></i> Edit</a>
                                                <a href="deleteinvoice.aspx?InvoiceNo=<%# (DataBinder.Eval(Container.DataItem, "InventoryTransferNo"))%>" class="btn-sm btn-flat btn-danger"><i class="fa fa-trash"></i> Delete</a>
                                                <a href="viewinvoice.aspx?InvoiceNo=<%# (DataBinder.Eval(Container.DataItem, "InventoryTransferNo"))%>" class="btn-sm btn-flat btn-warning"><i class="fa fa-search"></i> View</a>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </table>
                                    </FooterTemplate>
                                </asp:Repeater>
                            </div>
                           
                              <uc1:Pager ID="Pager1" runat="server" NumberOfPages="10" PageSize="10" ControlToBind="rptInvoiceList" OnChange="Pager1_Change"/>                                      
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="script" runat="server">
    <script type="text/javascript">
        {
            $('.select2').select2()

            $('#fromDate').datepicker({
                format: 'dd/MM/yyyy',
                autoclose: true
            });
            $('#toDate').datepicker({
                format: 'dd/MM/yyyy',
                autoclose: true
            });
        }

    </script>
    <script src="../AdminLTE/bower_components/jQuery/jquery-2.2.3.min.js"></script>
    <script src="../AdminLTE/bower_components/datatables/jquery.dataTables.min.js"></script>
    <script src="../AdminLTE/bower_components/datatables/dataTables.bootstrap.min.js"></script>
    <script src="../AdminLTE/dist/js/app.min.js"></script>

</asp:Content>
