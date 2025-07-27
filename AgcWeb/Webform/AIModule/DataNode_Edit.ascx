<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DataNode_Edit.ascx.cs" Inherits="AGC.Webform.DataNode_Edit" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabEdit" style="width: 70%" class="table table-bordered table-hover table td table-sm">
    <tr id="trDataNodeId">
        <td class="text-right">
            <asp:Label ID="lblDataNodeId" name="lblDataNodeId" CssClass="col-form-label text-right" Width="90px" Text="数据结点Id" runat="server" />
        </td>
        <td class="text-left">
            <asp:TextBox ID="txtDataNodeId" name="txtDataNodeId" CssClass="form-control" Width="400px" runat="server" />
        </td>
    </tr>
    <tr id="trTabId">
        <td class="text-right">
            <asp:Label ID="lblTabId" name="lblTabId" CssClass="col-form-label text-right" Width="90px" Text="表" runat="server" />
        </td>
        <td class="text-left">
            <asp:DropDownList ID="ddlTabId" name="ddlTabId" CssClass="form-control" Width="400px" runat="server" />
        </td>
    </tr>
    <tr id="trFldId">
        <td class="text-right">
            <asp:Label ID="lblFldId" name="lblFldId" CssClass="col-form-label text-right" Width="90px" Text="字段" runat="server" />
        </td>
        <td class="text-left">
            <asp:DropDownList ID="ddlFldId" name="ddlFldId" CssClass="form-control" Width="400px" runat="server" />
        </td>
    </tr>
    <tr id="trDataNodeName">
        <td class="text-right">
            <asp:Label ID="lblDataNodeName" name="lblDataNodeName" CssClass="col-form-label text-right" Width="90px" Text="结点名" runat="server" />
        </td>
        <td class="text-left">
            <asp:TextBox ID="txtDataNodeName" name="txtDataNodeName" CssClass="form-control" Width="400px" runat="server" />
        </td>
    </tr>
    <tr id="trDataNodeTypeId">
        <td class="text-right">
            <asp:Label ID="lblDataNodeTypeId" name="lblDataNodeTypeId" CssClass="col-form-label text-right" Width="90px" Text="结点类型" runat="server" />
        </td>
        <td class="text-left">
            <asp:DropDownList ID="ddlDataNodeTypeId" name="ddlDataNodeTypeId" CssClass="form-control" Width="400px" runat="server" />
        </td>
    </tr>
    <tr id="trMemo">
        <td class="text-right">
            <asp:Label ID="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
        </td>
        <td class="text-left">
            <asp:TextBox ID="txtMemo" name="txtMemo" CssClass="form-control" Width="400px" runat="server" />
        </td>
    </tr>
</table>
