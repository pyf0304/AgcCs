
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucViewStyle.ascx.cs" Inherits="AGC.Webform.wucViewStyleB" %>


<table id="tabwucViewStyle" style="width:600px; padding:1px;" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblViewId" runat="server" CssClass="col-form-label text-right">界面ID</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtViewId" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblTitleStyleId" runat="server" CssClass="col-form-label text-right">标题类型Id</asp:Label>
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlTitleStyleId" runat="server" class="form-control-sm"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblDgStyleId" runat="server" CssClass="col-form-label text-right">DG模式ID</asp:Label>
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlDgStyleId" runat="server" class="form-control-sm"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
</table>