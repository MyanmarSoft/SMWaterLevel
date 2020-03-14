<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Pager.ascx.cs" Inherits="SMWaterLevel.UserControls.Pager" %>
<div class="box-footer clearfix">
        <ul class="pagination pagination-sm no-margin pull-right">
            <li>
                <asp:LinkButton ID="LinkButtonPrevious" runat="server" Text="&laquo;" onclick="LinkButtonPrevious_Click"/>
            </li>
            <asp:Repeater ID="RepeaterNumbers" runat="server">
                <ItemTemplate>
                    <li>
                        <asp:LinkButton ID="LinkButtonNumber" runat="server" Enabled="<%#!IsCurrentPage((int)Container.DataItem) %>"
                            CssClass="<%#GetCssForCurrent((int)Container.DataItem)%> " Text="<%#(int)Container.DataItem%>"
                            OnClick="LinkButtonNumber_Click" /></li>
                </ItemTemplate>
            </asp:Repeater>
            <li>
                <asp:LinkButton ID="LinkButtonNext" runat="server" Text="&raquo;" 
                    onclick="LinkButtonNext_Click"/>
            </li>
        </ul>
</div>

