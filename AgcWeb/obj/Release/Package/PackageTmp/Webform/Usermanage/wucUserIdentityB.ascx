
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucUserIdentityB.ascx.cs" Inherits = "AGC.Webform.wucUserIdentityB" %>
<link rel = "stylesheet" type = "text/css" href = "../../Webform/css/taishweb1.css"/>
<table id = "tabwucUserIdentity" style = "width:600px; padding:1px;" border = "0">
<tr>
<td class = "NameTD">
<asp:Label id = "lblIdentityID" runat = "server" CssClass = "NameControl">身份编号</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtIdentityID" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblIdentityDesc" runat = "server" CssClass = "NameControl">身份描述</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtIdentityDesc" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblMemo" runat = "server" CssClass = "NameControl">备注</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtMemo" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
</table>