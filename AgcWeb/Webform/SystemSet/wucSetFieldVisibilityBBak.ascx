
<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucSetFieldVisibilityBBak.ascx.cs" Inherits="AGC.Webform.wucSetFieldVisibilityBBak" %>

<link href="../../css/taishweb2.css" rel="stylesheet" type="text/css" />
<table id="tabwucSetFieldVisibility" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblIdSchool" runat="server" CssClass="col-form-label text-right">学校</asp:Label>
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlIdSchool" Width="400px" runat="server" class="form-control-sm"></asp:DropDownList>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblViewName" runat="server" CssClass="col-form-label text-right">界面名称</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtViewName" Width="400px" runat="server" class="form-control-sm"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblFieldName" runat="server" CssClass="col-form-label text-right">字段名</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtFieldName" Width="400px" runat="server" class="form-control-sm"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblCtrlType" runat="server" CssClass="col-form-label text-right">控件类型</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtCtrlType" Width="400px" runat="server" class="form-control-sm"></asp:TextBox>
</td>
</tr>
<tr>
<td colspan="2">
<asp:CheckBox id="chkIsVisible" runat="server" Text="是否显示" CssClass="Check_Defa"></asp:CheckBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMemo" runat="server" CssClass="col-form-label text-right">备注</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" Width="400px" runat="server" class="form-control-sm"></asp:TextBox>
</td>
</tr>
</table>