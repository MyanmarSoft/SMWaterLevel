<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Letterhead.ascx.cs" Inherits="SMWaterLevel.UserControls.Letterhead" %>
<div class="row">
    <div class="col-xs-12">
        <h2 class="page-header">
            <div class="row">
                <div class="col-sm-4">
                    <asp:Image ID="imgCompanyLogo" runat="server" ImageUrl="~/AdminLTE/dist/img/hantharwaddydynasty.png" />
                </div>
                <div class="col-sm-8">
                    <small class="pull-right">
                        <strong>
                            <asp:Literal ID="ltlCompanyName" runat="server">Hantharwaddy Dynasty Travel & Tours Co.,Ltd</asp:Literal></strong><br />
                        <asp:Literal ID="ltlCompanyPhone" runat="server">Phone: 01-378198, 0973080830, 09420082433</asp:Literal><br />
                        <asp:Literal ID="ltlCompanyEmail" runat="server">Email: info@hantharwaddydynasty.com</asp:Literal><br />
                        <asp:Literal ID="ltlCompanyAddress" runat="server">No.279 (1F), 40 Street, Between Bogyoke & Anawyahta Roads,<br />Kyauktadar Township, Yangon, Myanmar</asp:Literal>
                    </small>
                </div>
            </div>
        </h2>
    </div>
</div>
