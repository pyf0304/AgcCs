
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucConstraintTypeB.ascx.cs" Inherits = "AGC.Webform.wucConstraintTypeB" %>
<link rel = "stylesheet" type = "text/css" href = "../../css/tz_base1.css"/>
<table id = "tabwucConstraintType" style = "width:600px; padding:1px;" border = "0">
<tr>
<td class = "NameTD">
<asp:Label id = "lblConstraintTypeId" runat = "server" CssClass = "NameControl">约束类型Id</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtConstraintTypeId" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblConstraintTypeName" runat = "server" CssClass = "NameControl">约束类型名</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtConstraintTypeName" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblConstraintTypeNameEN" runat = "server" CssClass = "NameControl">约束类型英文名</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtConstraintTypeNameEN" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td>
<asp:CheckBox id = "chkInUse" runat = "server" Text = "是否在用" CssClass = "Check_Defa"></asp:CheckBox>
</td>
<td>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblUpdDate" runat = "server" CssClass = "NameControl">修改日期</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtUpdDate" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblUpdUser" runat = "server" CssClass = "NameControl">修改者</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtUpdUser" runat = "server" CssClass = "ValueControl"></asp:TextBox>
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