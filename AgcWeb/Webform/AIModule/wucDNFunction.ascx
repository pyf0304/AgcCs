
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucDNFunction.ascx.cs" Inherits = "AGC.Webform.wucDNFunction" %>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabEdit" style="width: 70%" class="table table-bordered table-hover table td table-sm">
<tr id="trDnFunctionId">
<td class="text-right">
<asp:Label id="lblDnFunctionId" name="lblDnFunctionId" CssClass="col-form-label text-right" Width="90px" Text="DN函数Id" runat="server" />
</td>
<td class="text-left">
<asp:TextBox id="txtDnFunctionId" name="txtDnFunctionId" CssClass="form-control" Width="400px" runat="server" />
</td>
</tr>
<tr id="trDnFunctionName">
<td class="text-right">
<asp:Label id="lblDnFunctionName" name="lblDnFunctionName" CssClass="col-form-label text-right" Width="90px" Text="DN函数" runat="server" />
</td>
<td class="text-left">
<asp:TextBox id="txtDnFunctionName" name="txtDnFunctionName" CssClass="form-control" Width="400px" runat="server" />
</td>
</tr>
<tr id="trAssociationMappingId">
<td class="text-right">
<asp:Label id="lblAssociationMappingId" name="lblAssociationMappingId" CssClass="col-form-label text-right" Width="90px" Text="关系映射" runat="server" />
</td>
<td class="text-left">
<asp:DropDownList id="ddlAssociationMappingId" name="ddlAssociationMappingId" CssClass="form-control" Width="400px" runat="server" />
</td>
</tr>
<tr id="trMemo">
<td class="text-right">
<asp:Label id="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
</td>
<td class="text-left">
<asp:TextBox id="txtMemo" name="txtMemo" CssClass="form-control" Width="400px" runat="server" />
</td>
</tr>
</table>