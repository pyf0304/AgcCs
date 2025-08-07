
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucTitleTypeB.ascx.cs" Inherits = "AGC.Webform.wucTitleTypeB" %>
<link rel = "stylesheet" type = "text/css" href = "../../css/tz_base1.css"/>
<table id = "tabwucTitleType" style = "width:600px; padding:1px;" border = "0">
<tr>
<td class = "NameTD">
<asp:Label id = "lblTitleTypeId" runat = "server" CssClass = "NameControl">标题类型ID</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtTitleTypeId" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblTitleTypeName" runat = "server" CssClass = "NameControl">标题类型</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtTitleTypeName" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblMemo" runat = "server" CssClass = "NameControl">说明</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtMemo" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
</table>