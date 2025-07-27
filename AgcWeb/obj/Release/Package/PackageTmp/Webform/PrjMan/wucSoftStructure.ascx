<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucSoftStructure.ascx.cs" Inherits="AGC.Webform.wucSoftStructure" %>

<table id="tabwucSoftStructure" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblSoftStructureId" runat="server" CssClass="col-form-label text-right">架构ID</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtSoftStructureId" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblSoftStructureName" runat="server" CssClass="col-form-label text-right">架构名称</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtSoftStructureName" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblSoftStructureDesc" runat="server" CssClass="col-form-label text-right">架构描述</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtSoftStructureDesc" runat="server" class="form-control-sm"></asp:TextBox>
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