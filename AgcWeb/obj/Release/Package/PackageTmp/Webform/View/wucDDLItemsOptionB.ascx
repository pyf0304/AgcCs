
<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucDDLItemsOptionB.ascx.cs" Inherits="AGC.Webform.wucDDLItemsOptionB" %>

<table id="tabwucDDLItemsOption" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblDdlItemsOptionId" runat="server" CssClass="col-form-label text-right">下拉框列表选项ID</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtDdlItemsOptionId" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblDdlItemsOptionName" runat="server" CssClass="col-form-label text-right">下拉框列表选项名</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtDdlItemsOptionName" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
</table>