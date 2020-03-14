<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SMAccount.dashboard" %>
<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Dashboard | SMAccount
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <div class="content-wrapper">
       <section class="content-header">
      <h1>
        Dashboard
        <small>Control panel</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li class="active">Dashboard</li>
      </ol>
    </section>
        <section class="content">
             <div class="row">
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-maroon">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlBankAccount" runat="server"></asp:Literal></h3>
                            <p>Bank Accounts</p>
                        </div>
                        <div class="icon">
                           <i class="fa fa-university"></i>
                        </div>
                       <asp:Literal ID="ltlBankAccountView" runat="server"><a href="BankAccounts/bankaccountlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-purple">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlCashAccount" runat="server"></asp:Literal></h3>
                            <p>Cash Accounts</p>
                        </div>
                        <div class="icon">
                           <i class="fa fa-money"></i>
                        </div>
                        <asp:Literal ID="ltlCashAccountView" runat="server"><a href="CashAccounts/cashaccountlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-green">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlLaboratoryReport" runat="server"></asp:Literal></h3>
                            <p>Receipts</p>
                        </div>
                        <div class="icon">
                            <i class="fa fa-file-text-o"></i>
                        </div>
                         <asp:Literal ID="ltlLaboratoryReportView" runat="server"><a href="LaboratoryReports/laboratoryreportlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>
                         </div>
                </div>
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-red">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlMedicalReport" runat="server"></asp:Literal></h3>
                            <p>Payments</p>
                        </div>
                        <div class="icon">
                          <i class="fa fa-file-text"></i>
                        </div>
                         <asp:Literal ID="ltlMedicalReportView" runat="server"><a href="MedicalAssessments/medicalassessmentlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
            </div>
            <div class="row">
                 <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-light-blue">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlCustomer" runat="server"></asp:Literal></h3>
                            <p>Customer</p>
                        </div>
                        <div class="icon">
                            <i class="fa fa-users"></i>
                        </div>
                        <asp:Literal ID="ltlCustomerView" runat="server"><a href="/Customers/customerlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                 <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-navy">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlProject" runat="server"></asp:Literal></h3>
                            <p>Project</p>
                        </div>
                        <div class="icon">
                            <i class="fa fa-cubes"></i>
                        </div>
                        <asp:Literal ID="ltlProjectView" runat="server"><a href="Projects/projectlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-blue">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlSupplier" runat="server"></asp:Literal></h3>
                            <p>Supplier</p>
                        </div>
                        <div class="icon">
<i class="fa fa-industry"></i>                        
                        </div>
                     <asp:Literal ID="ltlSupplierView" runat="server"><a href="Suppliers/supplierlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                 <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-yellow">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlInventoryItem" runat="server"></asp:Literal></h3>
                            <p>Inventory Items</p>
                        </div>
                        <div class="icon">
                        <i class="fa fa-cube"></i>                        
                        </div>
                        <asp:Literal ID="ltlInventoryItemView" runat="server"><a href="InventoryItems/inventoryitemlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
               
                
            </div>
            <div class="row">
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-yellow">
                        <div class="inner">
                            <h3><asp:Literal ID="Literal1" runat="server"></asp:Literal></h3>
                            <p>Sale Order</p>
                        </div>
                        <div class="icon">
                        <i class="fa fa-shopping-basket"></i>                        
                        </div>
                        <asp:Literal ID="ltlInvoiceView" runat="server"><a href="Invoices/invoicelist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-green">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlInvoice" runat="server"></asp:Literal></h3>
                            <p>Sale Invoice</p>
                        </div>
                        <div class="icon">
                            <i class="fa fa-file"></i>
                        </div>
                        <asp:Literal ID="Literal4" runat="server"><a href="/Invoices/invoicelist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-red">
                        <div class="inner">
                            <h3><asp:Literal ID="Literal5" runat="server"></asp:Literal></h3>
                            <p>Sale Refund</p>
                        </div>
                        <div class="icon">
                            <i class="fa fa-reply"></i>
                        </div>
                        <asp:Literal ID="Literal6" runat="server"><a href="Patients/patientlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
             <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-purple">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlDoctor" runat="server"></asp:Literal></h3>
                            <p>Employee</p>
                        </div>
                        <div class="icon">
                        <i class="fa fa-user-md"></i>                        
                        </div>
                        <asp:Literal ID="ltlDoctorView" runat="server"><a href="Doctors/doctorlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-maroon">
                        <div class="inner">
                            <h3><asp:Literal ID="Literal2" runat="server"></asp:Literal></h3>
                            <p>Purchase Order</p>
                        </div>
                        <div class="icon">
<i class="fa fa-shopping-cart"></i>                        
                        </div>
                        <asp:Literal ID="Literal10" runat="server"><a href="Invoices/invoicelist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-purple">
                        <div class="inner">
                            <h3><asp:Literal ID="Literal11" runat="server"></asp:Literal></h3>
                            <p>Purchase Invoice</p>
                        </div>
                        <div class="icon">
                            <i class="fa fa-file"></i>
                        </div>
                        <asp:Literal ID="Literal12" runat="server"><a href="/PurchaseInvoices/purchaseinvoicelist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-navy">
                        <div class="inner">
                            <h3><asp:Literal ID="Literal13" runat="server"></asp:Literal></h3>
                            <p>Purchase Return</p>
                        </div>
                        <div class="icon">
                            <i class="fa fa-reply"></i>
                        </div>
                        <asp:Literal ID="Literal14" runat="server"><a href="Patients/patientlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-orange">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlInventoryLocation" runat="server"></asp:Literal></h3>
                            <p>Inventory Location</p>
                        </div>
                        <div class="icon">
                        <i class="fa fa-map-marker"></i>                        
                        </div>
                        <asp:Literal ID="ltlInventoryLocatioView" runat="server"><a href="Doctors/doctorlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
            </div>
             <div class="row">
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-olive">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlDepartment" runat="server"></asp:Literal></h3>
                            <p>Department</p>
                        </div>
                        <div class="icon">
                            <i class="fa fa-building"></i>
                        </div>
                        <asp:Literal ID="ltlDepartmentView" runat="server"><a href="Departments/departmentlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-light-blue">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlUserRole" runat="server"></asp:Literal></h3>
                            <p>User Role</p>
                        </div>
                        <div class="icon">
<i class="fa fa-cubes"></i>             </div>
                         <asp:Literal ID="ltlUserRoleView" runat="server"><a href="UserRoles/userrolelist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                <div class="col-lg-3 col-xs-6">
                  <div class="small-box bg-maroon">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlUser" runat="server"></asp:Literal></h3>
                            <p>Users</p>
                        </div>
                        <div class="icon">
                            <i class="ion ion-person-stalker"></i>
                        </div>
                        <asp:Literal ID="ltlUserProfileView" runat="server"><a href="MedicalReports/medicalreportlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-olive">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlReport" runat="server">View</asp:Literal></h3>
                            <p>Reports</p>
                        </div>
                        <div class="icon">
                            <i class="fa fa-bar-chart"></i>
                        </div>
                         <asp:Literal ID="ltlInvoiceReportView" runat="server"><a href="Reports/invoicereport.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
            </div>
        </section>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="script" runat="server">
        <script src="AdminLTE/dist/js/pages/dashboard.js"></script>
</asp:Content>
