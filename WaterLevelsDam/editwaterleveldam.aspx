<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="editwaterleveldam.aspx.cs" Inherits="SMWaterLevel.WaterLevelsDam.editwaterleveldam" %>
<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Edit WaterLevel Dam | SMWaterLevel
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <asp:ScriptManager ID="scriptManagerUserProfile" runat="server">
        </asp:ScriptManager>
    <div class="content-wrapper">
        <section class="content-header">
            <h1>Edit WaterLevel Dam
        <small>Modify</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="default"><i class="fa fa-dashboard"></i>Dashboard</a></li>
                <li><a href="#">WaterLevels </a></li>
                <li><a href="#">WaterLevel Dam List</a></li>
                <li class="active">Edit WaterLevel Dam</li>
            </ol>
        </section>
        <section class="content">
            <div class="row">
                <div class="col-md-12">
                    <div class="box box-primary">
                        <div class="box-header with-border">
                            <h3 class="box-title">Edit WaterLevel Dam</h3>
                        </div>
                        <div class="box-body">
                            <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                             <div class="row">
                                <div class="col-md-4">
                                      <div class="form-group">
                                        <label>Dam Name</label>
                                        <asp:DropDownList ID="ddlDamName" runat="server" CssClass="form-control select2" Style="width: 100%;">
                                        </asp:DropDownList>                                    
                                     </div>
                                    <div class="form-group">
                                        <label>Water Level Feet</label>
                                        <asp:TextBox ID="txtWaterLevelFeet" runat="server" CssClass="form-control" placeholder="Enter WaterLevel Name"></asp:TextBox>
                                    </div>
                                       <div class="form-group">
                                        <label>Remark</label>
                                        <asp:TextBox ID="txtRemark" runat="server" CssClass="form-control" placeholder="Enter Address" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Date</label>
                                        <div class="input-group date" id="CreateDate">
                                            <div class="input-group-addon">
                                                <i class="fa fa-calendar"></i>
                                            </div>
                                            <asp:TextBox ID="txtDate" runat="server" CssClass="form-control pull-right"></asp:TextBox>
                                        </div>
                                    </div>
                                     <div class="bootstrap-timepicker">
                <div class="form-group">
                  <label>Time</label>
                  <div class="input-group">
                       <div class="input-group-addon">
                      <i class="fa fa-clock-o"></i>
                    </div>
                   <asp:TextBox ID="txtTime" runat="server" CssClass="form-control pull-right timepicker" TextMode="DateTime"></asp:TextBox>
                  </div>
                </div>
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
     <script type="text/javascript">
         {
             $('.select2').select2()

             $('#CreateDate').datepicker({
                 format: 'dd/M/yyyy',
                 autoclose: true
             })

           
             $('.timepicker').timepicker({
                 showInputs: false
             })
         }
         </script>
</asp:Content>
