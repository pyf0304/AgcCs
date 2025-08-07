
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucPrjFunctionB.ascx.cs" Inherits = "AGC.Webform.wucPrjFunctionB" %>
<link rel = "stylesheet" type = "text/css" href = "../../css/tz_base1.css"/>
<table id = "tabwucPrjFunction" style = "width:600px; padding:1px;" border = "0">
<tr>
<td class = "NameTD">
<asp:Label id = "lblFuncId" runat = "server" CssClass = "NameControl">函数ID</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtFuncId" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblFuncName" runat = "server" CssClass = "NameControl">函数名</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtFuncName" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblPrjId" runat = "server" CssClass = "NameControl">工程ID</asp:Label>
</td>
<td class = "ValueTD">
<asp:DropDownList id = "ddlPrjId" runat = "server" CssClass = "ValueControl"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblReturnTypeID" runat = "server" CssClass = "NameControl">返回类型ID</asp:Label>
</td>
<td class = "ValueTD">
<asp:DropDownList id = "ddlReturnTypeID" runat = "server" CssClass = "ValueControl"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblFuncTypeID" runat = "server" CssClass = "NameControl">函数类型ID</asp:Label>
</td>
<td class = "ValueTD">
<asp:DropDownList id = "ddlFuncTypeID" runat = "server" CssClass = "ValueControl"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td>
<asp:CheckBox id = "chkIsTemplate" runat = "server" Text = "是否模板" CssClass = "Check_Defa"></asp:CheckBox>
</td>
<td>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblFuncCode" runat = "server" CssClass = "NameControl">函数代码</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtFuncCode" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblUserId" runat = "server" CssClass = "NameControl">用户ID</asp:Label>
</td>
<td class = "ValueTD">
<asp:DropDownList id = "ddlUserId" runat = "server" CssClass = "ValueControl"></asp:DropDownList>
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