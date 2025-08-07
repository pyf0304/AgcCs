
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucWebSrvFunctionsB.ascx.cs" Inherits = "AGC.Webform.wucWebSrvFunctionsB" %>
<link rel = "stylesheet" type = "text/css" href = "../../css/tz_base1.css"/>
<table id = "tabwucWebSrvFunctions" style = "width:600px; padding:1px;" border = "0">
<tr>
<td class = "NameTD">
<asp:Label id = "lblWebSrvFunctionId" runat = "server" CssClass = "NameControl">函数Id</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtWebSrvFunctionId" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblWebSrvClassId" runat = "server" CssClass = "NameControl">类Id</asp:Label>
</td>
<td class = "ValueTD">
<asp:DropDownList id = "ddlWebSrvClassId" runat = "server" CssClass = "ValueControl"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblFunctionName" runat = "server" CssClass = "NameControl">功能名称</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtFunctionName" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblGetCustomAttributes" runat = "server" CssClass = "NameControl">GetCustomAttributes</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtGetCustomAttributes" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
<asp:CompareValidator id = "ComValid_GetCustomAttributes" runat = "server" CssClass = "ErrMsg" ErrorMessage = "请输入整型数值!" ControlToValidate = "txtGetCustomAttributes" 
Type = "Integer" Operator = "DataTypeCheck" EnableClientScript = "false">
</asp:CompareValidator>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblFunctionSignature" runat = "server" CssClass = "NameControl">函数签名</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtFunctionSignature" runat = "server" CssClass = "ValueControl"></asp:TextBox>
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