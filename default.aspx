<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SMWaterLevel.dashboard" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Dashboard | SMWaterLevel
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
                    <div class="small-box bg-yellow">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlRiver" runat="server"></asp:Literal></h3>
                            <p>Rivers</p>
                        </div>
                        <div class="icon">
                           <i class="fa fa-map-signs"></i>
                        </div>
                       <asp:Literal ID="ltlRiverView" runat="server"><a href="Rivers/riverlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                   
                  <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-green">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlWaterLevel" runat="server"></asp:Literal></h3>
                            <p>Water Level</p>
                        </div>
                        <div class="icon">
                           <i class="fa fa-area-chart"></i>
                        </div>
                       <asp:Literal ID="ltlWaterLevelView" runat="server"><a href="WaterLevels/waterlevellist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                 
                
                  
                 <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-red">
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
                  <div class="small-box bg-blue">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlUser" runat="server"></asp:Literal></h3>
                            <p>Users</p>
                        </div>
                        <div class="icon">
                            <i class="ion ion-person-stalker"></i>
                        </div>
                        <asp:Literal ID="ltlUserProfileView" runat="server"><a href="UserProfiles/userprofilelist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                 </div>
             <div class="row">
                <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-purple">
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
                    <div class="small-box bg-navy">
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
                  <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-yellow">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlWaterLevelDam" runat="server"></asp:Literal></h3>
                            <p>Water Level Dam</p>
                        </div>
                        <div class="icon">
                            <i class="fa fa-area-chart"></i>
                        </div>
                         <asp:Literal ID="ltlWaterLevelDamView" runat="server"><a href="WaterLevelsDam/waterlevellistdam.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
                 
                 <div class="col-lg-3 col-xs-6">
                    <div class="small-box bg-green">
                        <div class="inner">
                            <h3><asp:Literal ID="ltlDam" runat="server"></asp:Literal></h3>
                            <p>Dam</p>
                        </div>
                        <div class="icon">
                           <i class="fa fa-map-signs"></i>
                        </div>
                       <asp:Literal ID="ltlDamView" runat="server"><a href="Dams/damlist.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a></asp:Literal>

                    </div>
                </div>
            </div>
            </section>
           <%-- <%--<div class="row">
                  <div class="col-lg-12 col-xs-12">
                <div class="nav-tabs-custom">
            <!-- Tabs within a box -->
            <ul class="nav nav-tabs pull-right">
              <li class="active"><a href="#revenue-chart" data-toggle="tab">Area</a></li>
              <li><a href="#sales-chart" data-toggle="tab">Donut</a></li>
              <li class="pull-left header"><i class="fa fa-inbox"></i> Water Level</li>
            </ul>
            <div class="tab-content no-padding">
              <!-- Morris chart - Sales -->
              <div class="tab-pane active" id="revenue-chart" style="position: relative; height: 300px;">

                  <asp:Chart ID="chartWaterLevel" runat="server" Visible = "false" CssClass="chart">
        <Titles>
            <asp:Title ShadowOffset="3" Name="Items" />
        </Titles>
        <Legends>
            <asp:Legend Alignment="Center" Docking="Bottom" IsTextAutoFit="False" Name="Default" LegendStyle="Row" />
        </Legends>
        <Series>
            <asp:Series Name="Default" />
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1" BorderWidth="0" />
        </ChartAreas>
    </asp:Chart>
              </div>
              <div class="chart tab-pane" id="sales-chart" style="position: relative; height: 300px;"></div>
            </div>
                    </div>
          </div>
                
        
            </div>
        </section>--%>
        </div>
    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="script" runat="server">
<script src="AdminLTE/dist/js/pages/dashboard.js"></script>
</asp:Content>
