﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="waterlevellistdam.aspx.cs" Inherits="SMWaterLevel.WaterLevelsDam.waterlevellistdam" %>
<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<%@ Register src="../UserControls/Pager.ascx" tagname="Pager" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    WaterLevel Dam List  | SMWaterLevel
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../AdminLTE/plugins/datatables/dataTables.bootstrap.css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <div class="content-wrapper">
        <!-- Content Header (Page header) -->
        <section class="content-header">
            <h1>WaterLevel Dam List 
        <small>View</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="#"><i class="fa fa-dashboard"></i>Dashboard</a></li>
                <li><a href="#"><i class="fa fa-users"></i>WaterLevels Dam</a></li>
                <li class="active">WaterLevel Dam List </li>
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
                            <asp:LinkButton ID="btnNew" runat="server" CssClass="btn btn-primary btn-flat" OnClick="btnNew_Click"><i class="fa fa-plus"></i> New WaterLevel Dam</asp:LinkButton>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="input-group">
                                        <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" placeholder="Search " OnTextChanged="txtSearch_TextChanged"></asp:TextBox>
                                        <div class="input-group-btn">
                                       <asp:LinkButton ID="btnSearch" runat="server" CssClass="btn btn-default" OnClick="btnSearch_Click"><i class="fa fa-search"></i></asp:LinkButton>
                                        </div>
                                    </div>
                        </div>
                    </div>
                <div class="row" style="margin-top: 20px">
                    <div class="col-md-12">
                        <div class="box box-primary">
                            <div class="box-header">
                                <h3 class="box-title">WaterLevel Dam List </h3>
                              <%--  <div class="box-tools">
                                </div>--%>
                            </div>
                            <!-- /.box-header -->
                            <div class="box-body table-responsive">
                                <asp:Repeater ID="rptWaterLevelListDam" runat="server">
                                    <HeaderTemplate>
                                        <table class="table table-hover table-bordered table-striped">
                                            <tr>
                                                <th>
                                                    <asp:LinkButton ID="btnID" runat="server" CssClass="btn-flat" CommandName="ID">ID <i class="fa fa-sort"></i></asp:LinkButton>
                                                    <th>
                                                        <asp:LinkButton ID="btnDamName" runat="server" CssClass="btn-flat" CommandName="DamName">Dam Name<i class="fa fa-sort"></i></asp:LinkButton></th>
                                                     <th>
                                                        <asp:LinkButton ID="btnLevelFeet" runat="server" CssClass="btn-flat" CommandName="WaterLevel">Water Level <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                     <th>
                                                        <asp:LinkButton ID="btnRemark" runat="server" CssClass="btn-flat" CommandName="Remark">Remark <i class="fa fa-sort"></i></asp:LinkButton></th> 
                                                    <th>
                                                        <asp:LinkButton ID="btnCreatedDate" runat="server" CssClass="btn-flat" CommandName="CreatedDate">Date <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                     <th>
                                                        <asp:LinkButton ID="btnCreatedTime" runat="server" CssClass="btn-flat" CommandName="CreatedTime">Time <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                           <th>
                                                        <asp:LinkButton ID="btnStatus" runat="server" CssClass="btn-flat" CommandName="Status">Status <i class="fa fa-sort"></i></asp:LinkButton></th>
                                                    <th style="width:150px">Action</th>
                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "ID")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "DamName")%>
                                            </td>
                                             <td>
                                                <%# DataBinder.Eval(Container.DataItem, "LevelFeet")%>
                                            </td>
                                             <td>
                                                <%# DataBinder.Eval(Container.DataItem, "Remark")%>
                                            </td>
                                               <td>
                                                <%# DataBinder.Eval(Container.DataItem, "CreatedDate", "{0:dd/MMM/yyyy}")%>
                                            </td>
                                              <td>
                                                <%# DataBinder.Eval(Container.DataItem, "CreatedTime")%>
                                            </td>
                                            <td>
                                                <%# DataBinder.Eval(Container.DataItem, "Status")%>
                                            </td>
                                            <td>
                                                <a href="editwaterleveldam.aspx?WaterLevelDamID=<%# (DataBinder.Eval(Container.DataItem, "ID"))%>" class="btn-sm btn-flat btn-primary"><i class="fa fa-pencil"></i> Edit</a>
                                                <a href="deletewaterleveldam.aspx?WaterLevelDamID=<%# (DataBinder.Eval(Container.DataItem, "ID"))%>" class="btn-sm btn-flat btn-danger"><i class="fa fa-trash"></i> Delete</a>
                                            </td>

                                        </tr>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </table>
                                    </FooterTemplate>

                                </asp:Repeater>
                            </div>
                           <uc1:Pager ID="Pager1" runat="server" NumberOfPages="10" PageSize="10" ControlToBind="rptWaterLevelListDam" OnChange="Pager1_Change"/>                                      
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
