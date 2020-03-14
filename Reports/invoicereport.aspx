<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="invoicereport.aspx.cs" Inherits="SMWaterLevel.Reports.invoicereport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<%@ Register Src="../UserControls/Pager.ascx" TagName="Pager" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Invoice Report | SMWaterLevel
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../AdminLTE/plugins/datatables/dataTables.bootstrap.css" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <asp:ScriptManager ID="scriptManagerInvoiceReport" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
            <div class="content-wrapper">
                <!-- Content Header (Page header) -->
                <section class="content-header">
                    <h1>Invoice Report
        <small>View</small>
                    </h1>
                    <ol class="breadcrumb">
                        <li><a href="#"><i class="fa fa-dashboard"></i>Dashboard</a></li>
                        <li><a href="#"><i class="ion ion-bag"></i>Reports</a></li>
                        <li class="active">Invoice Report</li>
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
                                    <asp:LinkButton ID="btnNewInvoice" runat="server" CssClass="btn btn-primary btn-flat" OnClick="btnNewInvoice_Click"><i class="fa fa-plus"></i> New Invoice</asp:LinkButton>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-3">
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
                            <div class="col-xs-3">
                                <div class="form-group">
                                    <label>To Date</label>
                                    <div class="input-group date" id="toDate">
                                        <div class="input-group-addon">
                                            <i class="fa fa-calendar"></i>
                                        </div>
                                        <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control pull-right"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-3">
                                <div class="form-group">
                                    <label>Patient ID</label>
                                    <asp:DropDownList ID="ddlPatientID" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-xs-3">
                                <div class="form-group">
                                    <label>Payment Method</label>
                                    <asp:DropDownList ID="ddlPaymentMode" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-xs-3">
                                <div class="form-group">
                                    <label>Company Name</label>
                                    <asp:DropDownList ID="ddlCompany" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-xs-3">
                                <div class="form-group">
                                    <label>Doctor Name</label>
                                    <asp:DropDownList ID="ddlDoctor" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                       
                        <div class="row">
                             <div class="col-md-6">
                                <div class="form-group">
                                    <asp:LinkButton ID="btnSearchInvoice" runat="server" CssClass="btn btn-primary btn-flat" OnClick="btnSearchInvoice_Click"><i class="fa fa-search"></i> Search Invoice</asp:LinkButton>
                                </div>
                            </div>
                             <div class="col-md-6">
                            <asp:CheckBox ID="ckbOtherReport" runat="server" Text="Other Report" Checked="false" OnCheckedChanged="ckbOtherReport_CheckedChanged"/>
                             </div>
                        </div>
                            <div class="row" style="margin-top: 20px">
                                <div class="col-xs-12">
                                    <div class="box box-primary">
                                        <div class="box-header">
                                            <h3 class="box-title">Invoice List</h3>
                                            <div class="box-tools">
                                            </div>
                                            <div class="box-body">
                                                <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                                                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="8.27in" ShowPrintButton="True">
                                                </rsweb:ReportViewer>
            </div>
            </div>
                                    </div>
                                </div>
                            </div>
                      
                    </div>
                </section>
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="script" runat="server">
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
