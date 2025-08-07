
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucProgLangTypeB.ascx.cs" Inherits = "AGC.Webform.wucProgLangTypeB" %>
<link rel = "stylesheet" type = "text/css" href = "../../css/tz_base1.css"/>
<table id = "tabwucProgLangType" style = "width:600px; padding:1px;" border = "0">
<tr>
<td class = "NameTD">
<asp:Label id = "lblProgLangTypeId" runat = "server" CssClass = "NameControl">编程语言类型Id</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtProgLangTypeId" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblProgLangTypeName" runat = "server" CssClass = "NameControl">编程语言类型名</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtProgLangTypeName" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblProgLangTypeENName" runat = "server" CssClass = "NameControl">编程语言类型英文名</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtProgLangTypeENName" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblCharEncodingId" runat = "server" CssClass = "NameControl">字符编码</asp:Label>
</td>
<td class = "ValueTD">
<asp:DropDownList id = "ddlCharEncodingId" runat = "server" CssClass = "ValueControl"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td>
<asp:CheckBox id = "chkIsVisible" runat = "server" Text = "是否显示" CssClass = "Check_Defa"></asp:CheckBox>
</td>
<td>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblOrderNum" runat = "server" CssClass = "NameControl">序号</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtOrderNum" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
<asp:CompareValidator id = "ComValid_OrderNum" runat = "server" CssClass = "ErrMsg" ErrorMessage = "请输入整型数值!" ControlToValidate = "txtOrderNum" 
Type = "Integer" Operator = "DataTypeCheck" EnableClientScript = "false">
</asp:CompareValidator>
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
<asp:Label id = "lblUpdUserId" runat = "server" CssClass = "NameControl">修改用户Id</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtUpdUserId" runat = "server" CssClass = "ValueControl"></asp:TextBox>
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