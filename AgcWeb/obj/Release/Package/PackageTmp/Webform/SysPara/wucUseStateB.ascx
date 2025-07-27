
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucUseStateB.ascx.cs" Inherits="AGC.Webform.wucUseStateB" %>

<table id="tabwucUseState" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblUseStateId" runat="server" CssClass="col-form-label text-right">使用状态Id</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtUseStateId" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblUseStateName" runat="server" CssClass="col-form-label text-right">使用状态名称</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtUseStateName" runat="server" class="form-control-sm"></asp:TextBox>
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