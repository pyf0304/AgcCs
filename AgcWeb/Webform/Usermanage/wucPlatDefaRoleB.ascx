
<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucPlatDefaRoleB.ascx.cs" Inherits="AGC.Webform.wucPlatDefaRoleB" %>
<link rel="stylesheet" type="text/css" href="../../Webform/css/taishweb1.css"/>
<table id="tabwucPlatDefaRole" cellspacing="1" cellpadding="1" style="width: 600px;" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblIdSchool" runat="server" CssClass="col-form-label text-right">学校流水号</asp:Label>
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlIdSchool" runat="server" class="form-control-sm"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblPersonType" runat="server" CssClass="col-form-label text-right">人员类别</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtPersonType" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblPrjId" runat="server" CssClass="col-form-label text-right">工程Id</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtPrjId" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblRoleID" runat="server" CssClass="col-form-label text-right">角色ID</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtRoleID" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMemo" runat="server" CssClass="col-form-label text-right">备注</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
</table>