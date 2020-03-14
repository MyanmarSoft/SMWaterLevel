<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="editriver.aspx.cs" Inherits="SMWaterLevel.Rivers.editriver" %>
<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Edit River | SMWaterLevel
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <asp:ScriptManager ID="scriptManagerUserProfile" runat="server">
        </asp:ScriptManager>
    <div class="content-wrapper">
        <section class="content-header">
            <h1>Edit River
        <small>Modify</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="default"><i class="fa fa-dashboard"></i>Dashboard</a></li>
                <li><a href="#">Rivers</a></li>
                <li><a href="#">River List</a></li>
                <li class="active">Edit River</li>
            </ol>
        </section>
        <section class="content">
            <div class="row">
                <div class="col-md-12">
                    <div class="box box-primary">
                        <div class="box-header with-border">
                            <h3 class="box-title">Edit River</h3>
                        </div>
                        <div class="box-body">
                            <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                             <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label>River Name</label>
                                        <asp:TextBox ID="txtRiverName" runat="server" CssClass="form-control" placeholder="Enter River Name"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Latitude</label>
                                        <asp:TextBox ID="txtLatitude" runat="server" CssClass="form-control" placeholder="Enter Latitude"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Longitude</label>
                                        <asp:TextBox ID="txtLongitude" runat="server" CssClass="form-control" placeholder="Enter Longtitude"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Description</label>
                                        <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control" placeholder="Enter Description" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                    </div>
                                    <div class="btn-group">
                                        <asp:LinkButton ID="btnViewMap" runat="server" CssClass="btn btn-primary btn-flat" OnClick="btnViewMap_Click"><i class="fa fa-search"></i> View Map</asp:LinkButton>
                                    </div>
                                </div>
                                <div class="col-md-8">
                                    <div class="form-group">
                                        <asp:Literal ID="ltlViewMap" runat="server"></asp:Literal>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="box-footer">
                            <asp:LinkButton ID="btnCancel" runat="server" CssClass="btn btn-default btn-flat" OnClick="btnCancel_Click"><i class="fa fa-rotate-left (alias)"></i> Cancel</asp:LinkButton>
                            <asp:LinkButton ID="btnEdit" runat="server" CssClass="btn btn-primary btn-flat pull-right" OnClick="btnEdit_Click" ><i class="fa fa-pencil"></i> Edit</asp:LinkButton>
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
