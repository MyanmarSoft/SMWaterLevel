﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="editinventorytransfer.aspx.cs" Inherits="SMAccount.InventoryTransfers.editinventorytransfer" %>
<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Edit Invoice | SMAccount
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <asp:ScriptManager ID="scriptManagerUser" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="updatePanelDomesticSales" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <div class="content-wrapper">
                <section class="content-header">
                    <h1>Modify Invoice
        <small>Create</small>
                    </h1>
                    <ol class="breadcrumb">
                        <li><a href="default"><i class="fa fa-dashboard"></i>Dashboard</a></li>
                        <li><a href="#">Invoices</a></li>
                        <li><a href="#">Invoice List</a></li>
                        <li class="active">Edit Invoice</li>
                    </ol>
                </section>
                <section class="content">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="box box-primary">
                                <div class="box-header with-border">
                                    <h3 class="box-title">Edit Invoice</h3>
                                </div>
                                class="box-body">
                                    <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                                    <div class="row">
                                        <div class="col-md-3">
                                            <div class="form-group">
                                                <label>Invoice ID</label>
                                                <asp:TextBox ID="txtInvoiceID" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-3">
                                            <div class="form-group">
                                                <label>Patient ID</label>
                                                <asp:TextBox ID="txtPatientID" runat="server" CssClass="form-control" placeholder="Enter PatientID" OnTextChanged="txtPatientID_TextChanged" AutoPostBack="true"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-3">
                                            <div class="form-group">
                                                <label>Patient Name</label>
                                                <asp:TextBox ID="txtPatientName" runat="server" CssClass="form-control" placeholder="Enter Patient Name"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-3">
                                            <div class="form-group">
                                                <label>Date</label>
                                                <div class="input-group date" id="invoicedate">
                                                    <div class="input-group-addon">
                                                        <i class="fa fa-calendar"></i>
                                                    </div>
                                                    <asp:TextBox ID="txtDate" runat="server" CssClass="form-control pull-right"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-3">
                                            <div class="form-group">
                                                <label>Doctor Name</label>
                                                <asp:DropDownList ID="ddlDoctorName" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlDoctorName_SelectedIndexChanged" AutoPostBack="true">
                                                </asp:DropDownList>  
                                              <%--<asp:TextBox ID="txtDoctorName" runat="server" CssClass="form-control" AutoPostBack="true"></asp:TextBox>--%>

                                            </div>
                                        </div>
                                        <div class="col-md-3">
                                            <div class="form-group">
                                                <label>Position</label>
                                                <asp:TextBox ID="txtPosition" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-3">
                                            <div class="form-group">
                                                <label>Payment Method</label>
                                                <asp:DropDownList ID="ddlPaymentMode" runat="server" CssClass="form-control">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-3">
                                            <div class="form-group">
                                                <b><asp:Literal ID="ltlPharmacy" runat="server" Text="Item Name"></asp:Literal></b>
                                                <asp:DropDownList ID="ddlPharmacy" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlPharmacy_SelectedIndexChanged" AutoPostBack="true">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                        <div class="col-md-2">
                                            <div class="form-group">
                                                 <b><asp:Literal ID="ltlUnitCostPharmacy" runat="server" Text="Unit Cost"></asp:Literal></b>
                                                <asp:TextBox ID="txtUnitCostOfPharmacyKyat" runat="server" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtUnitCostOfPharmacyKyat_TextChanged"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-1">
                                            <div class="form-group">
                                               <b><asp:Literal ID="ltlQtyPharmacy" runat="server" Text="Qty"></asp:Literal></b>
                                                <asp:TextBox ID="txtQtyOfPharmacy" runat="server" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtQtyOfPharmacy_TextChanged" Text="1"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-md-2">
                                            <div class="form-group">
                                               <b><asp:Literal ID="ltlAmountPharmacy" runat="server" Text="Amount"></asp:Literal></b>
                                                <asp:TextBox ID="txtAmountOfPharmacy" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                       <div class="box-footer">
                                    <%--<asp:LinkButton ID="btnEdit" runat="server" CssClass="btn btn-success  btn-flat"><i class="fa fa-pencil"></i> Edit</asp:LinkButton>
                                     <asp:LinkButton ID="btnDelete" runat="server" CssClass="btn btn-danger btn-flat"><i class="fa fa-times"></i> Delete</asp:LinkButton>--%>
                                </div>
                                    <div class="row">
                                        <div class="col-md-3">
                                            <div class="form-group">
                                                <label>Company</label>
                                                <asp:TextBox ID="txtCompany" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                 
                                    <div class="row table-responsive">
                                        <div class="col-md-12">
                                            <table class="table table-hover table-bordered table-striped">
                                                <tr>
                                                      <th>No</th>
                                                    <th>Description</th>
                                                     <th>Unit Cost</th>
                                                     <th>Qty</th>
                                                     <th>UnitType</th>
                                                    <th>Cost</th>
                                                    <th style="width:90px;"></th>
                                                </tr>
                                                <asp:UpdatePanel runat="server" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                        <asp:Repeater runat="server" ID="rptInvoice" OnItemCommand="rptInvoice_ItemCommand">
                                                            <ItemTemplate>
                                                                <tr>
                                                                      <td>
                                                                          <asp:Label ID="lbNo" Text="<%#Container.ItemIndex+1 %>" runat="server" />
                                                                          <asp:Label ID="ltlID" Text='<%# DataBinder.Eval(Container.DataItem, "ID") %>' runat="server" CommandArgument='<%# Eval("ID") %>'  Visible="false" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="lbDescription" Text='<%# DataBinder.Eval(Container.DataItem, "Description") %>' runat="server" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="lbUnitCostByKyat" Text='<%# DataBinder.Eval(Container.DataItem, "UnitCost") %>' runat="server" /></td>
                                                                    <td>
                                                                        <asp:Label ID="lbQty" Text='<%# DataBinder.Eval(Container.DataItem, "Qty") %>' runat="server" /></td>
                                                                    <td>
                                                                        <asp:Label ID="lbAmountCost" Text='<%# DataBinder.Eval(Container.DataItem, "AmountCost") %>' runat="server" />
                                                                    </td>
                                                                    <td>
                                                                        <asp:LinkButton ID="btnRemove" runat="server" CssClass="btn-sm btn-danger" CommandName="Remove" OnClientClick="javascript:if(!confirm('Delete this information? this will delete permanently'))return false;" CommandArgument='<%#Eval("ID") %>'> <i class="fa fa-times"></i></asp:LinkButton>
                                                                    </td>
                                                                </tr>
                                                            </ItemTemplate>
                                                            <FooterTemplate>
                                                            </FooterTemplate>
                                                        </asp:Repeater>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </table>
                                        </div>
                                    </div>
                                    <div class="row">
                                       
                                        <div class="col-md-3">
                                        </div>
                                        <div class="col-md-2">
                                            <div class="form-group">
                                             <label>Total :</label>
                                            </div>
                                            <div class="form-group">
                                             <label>Discount :</label>
                                            </div>
                                            <div class="form-group">
                                             <label>Net Total :</label>
                                            </div>
                                        </div>
                                        <div class="col-md-2">
                                            <div class="form-group">
                                                <asp:Literal ID="ltlTotalFeeOfKyat" runat="server"  Text="0"></asp:Literal>
                                            </div>
                                            <div class="form-group">
                                                <asp:TextBox ID="txtDiscountOfKyat" runat="server" CssClass="form-control" OnTextChanged="txtDiscountOfKyat_TextChanged" AutoPostBack="true"  Text="0"></asp:TextBox>
                                            </div>
                                            <div class="form-group">
                                               <asp:Literal ID="ltlNetTotalOfKyat" runat="server"  Text="0"></asp:Literal>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="box-footer">
                                    <asp:LinkButton ID="btnCancel" runat="server" CssClass="btn btn-default btn-flat" OnClick="btnCancel_Click"><i class="fa fa-rotate-left (alias)"></i> Cancel</asp:LinkButton>
                                    <asp:LinkButton ID="btnSave" runat="server" CssClass="btn btn-primary pull-right btn-flat" OnClick="btnSave_Click"><i class="fa fa-save (alias)"></i> Save</asp:LinkButton>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
                <div class="clearfix"></div>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="rptInvoice" />


            <asp:AsyncPostBackTrigger ControlID="txtPatientID" />
            <asp:AsyncPostBackTrigger ControlID="rdoUS" />
            <asp:AsyncPostBackTrigger ControlID="rdoKyat" />
            <asp:AsyncPostBackTrigger ControlID="ddlDoctorName" />
            <asp:AsyncPostBackTrigger ControlID="ddlPaymentMode" />
            <asp:AsyncPostBackTrigger ControlID="ddlPharmacy" />
            <asp:AsyncPostBackTrigger ControlID="ddlXRay" />
            <asp:AsyncPostBackTrigger ControlID="ddlAesthetic" />
            <asp:AsyncPostBackTrigger ControlID="ddlLabTest" />
            <asp:AsyncPostBackTrigger ControlID="ddlMedicalCheckup" />
            <asp:AsyncPostBackTrigger ControlID="ddlOther" />
            <asp:AsyncPostBackTrigger ControlID="txtUnitCostOfPharmacyKyat" />
            <asp:AsyncPostBackTrigger ControlID="txtUnitCostOfXRayKyat" />
            <asp:AsyncPostBackTrigger ControlID="txtUnitCostOfAestheticKyat" />
            <asp:AsyncPostBackTrigger ControlID="txtUnitCostOfLabTestKyat" />
            <asp:AsyncPostBackTrigger ControlID="txtUnitCostOfMedicalCheckupUS" />
            <asp:AsyncPostBackTrigger ControlID="txtUnitCostOfOtherKyat" />
            <asp:AsyncPostBackTrigger ControlID="txtUnitCostOfPharmacyUS" />
            <asp:AsyncPostBackTrigger ControlID="txtUnitCostOfXRayUS" />
            <asp:AsyncPostBackTrigger ControlID="txtUnitCostOfAestheticUS" />
            <asp:AsyncPostBackTrigger ControlID="txtUnitCostOfLabTestUS" />
            <asp:AsyncPostBackTrigger ControlID="txtUnitCostOfMedicalCheckupUS" />
            <asp:AsyncPostBackTrigger ControlID="txtUnitCostOfOtherUS" />
            <asp:AsyncPostBackTrigger ControlID="txtQtyOfPharmacy" />
            <asp:AsyncPostBackTrigger ControlID="txtQtyOfXRay" />
            <asp:AsyncPostBackTrigger ControlID="txtQtyOfAesthetic" />
            <asp:AsyncPostBackTrigger ControlID="txtQtyOfLabTest" />
            <asp:AsyncPostBackTrigger ControlID="txtQtyOfMedicalCheckup" />
            <asp:AsyncPostBackTrigger ControlID="txtQtyOfOther" />
            <asp:AsyncPostBackTrigger ControlID="txtConsultantationFeeKyat" />
            <asp:AsyncPostBackTrigger ControlID="txtSurgicalFeeKyat" />
            <asp:AsyncPostBackTrigger ControlID="txtConsultantationFeeUS" />
            <asp:AsyncPostBackTrigger ControlID="txtSurgicalFeeUS" />
            <asp:AsyncPostBackTrigger ControlID="rdoPayByKyat" />
            <asp:AsyncPostBackTrigger ControlID="rdoPayByUS" />
            <asp:AsyncPostBackTrigger ControlID="txtExchangeRate" />
            <asp:AsyncPostBackTrigger ControlID="txtAdminFeeOfKyat" />
            <asp:AsyncPostBackTrigger ControlID="txtDiscountOfKyat" />
            <asp:AsyncPostBackTrigger ControlID="txtAdminFeeOfUS" />
            <asp:AsyncPostBackTrigger ControlID="txtDiscountOfUS" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="script" runat="server">
    <script src="../AdminLTE/dist/js/jquery-ui.min.js"></script>
<script src="../AdminLTE/dist/js/jquery-2.1.1.js"></script>

     <script type="text/javascript">
         {
             $('.select2').select2()

             $('#datepicker').datepicker({
                 format: 'dd/MM/yyyy',
                 autoclose: true
             });

             $('#invoicedate').datepicker({
                 format: 'dd/MM/yyyy',
                 autoclose: true
             });
         }


    </script>
</asp:Content>
