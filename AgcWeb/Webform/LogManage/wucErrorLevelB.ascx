
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucErrorLevelB.ascx.cs" Inherits="AGC.Webform.wucErrorLevelB" %>

<table id="tabwucErrorLevel" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblErrorLevelId" runat="server" CssClass="col-form-label text-right">错误等级Id</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtErrorLevelId" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblErrorLevelName" runat="server" CssClass="col-form-label text-right">错误等级名</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtErrorLevelName" runat="server" class="form-control-sm"></asp:TextBox>
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