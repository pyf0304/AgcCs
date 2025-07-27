
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "DnFuncMap_Edit.ascx.cs" Inherits = "AGC.Webform.DnFuncMap_Edit" %>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabEdit" style="width: 70%" class="table table-bordered table-hover table td table-sm">
<tr id="trInDataNodeId">
<td class="text-right">
<asp:Label id="lblInDataNodeId" name="lblInDataNodeId" CssClass="col-form-label text-right" Width="90px" Text="In数据结点" runat="server" />
</td>
<td class="text-left">
<asp:DropDownList id="ddlInDataNodeId" name="ddlInDataNodeId" CssClass="form-control" Width="400px" runat="server" />
</td>
</tr>
<tr id="trOutDataNodeId">
<td class="text-right">
<asp:Label id="lblOutDataNodeId" name="lblOutDataNodeId" CssClass="col-form-label text-right" Width="90px" Text="Out数据结点" runat="server" />
</td>
<td class="text-left">
<asp:DropDownList id="ddlOutDataNodeId" name="ddlOutDataNodeId" CssClass="form-control" Width="400px" runat="server" />
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
<tr id="trFuncMapModeId">
<td class="text-right">
<asp:Label id="lblFuncMapModeId" name="lblFuncMapModeId" CssClass="col-form-label text-right" Width="90px" Text="映射模式" runat="server" />
</td>
<td class="text-left">
<asp:DropDownList id="ddlFuncMapModeId" name="ddlFuncMapModeId" CssClass="form-control" Width="400px" runat="server" />
</td>
</tr>
<tr id="trTabId">
<td class="text-right">
<asp:Label id="lblTabId" name="lblTabId" CssClass="col-form-label text-right" Width="90px" Text="表" runat="server" />
</td>
<td class="text-left">
<asp:DropDownList id="ddlTabId" name="ddlTabId" CssClass="form-control" Width="400px" runat="server" />
</td>
</tr>
<tr id="trDnFunctionId">
<td class="text-right">
<asp:Label id="lblDnFunctionId" name="lblDnFunctionId" CssClass="col-form-label text-right" Width="90px" Text="DN函数" runat="server" />
</td>
<td class="text-left">
<asp:DropDownList id="ddlDnFunctionId" name="ddlDnFunctionId" CssClass="form-control" Width="400px" runat="server" />
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