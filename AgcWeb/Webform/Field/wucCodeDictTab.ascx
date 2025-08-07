<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucCodeDictTab.ascx.cs" Inherits="AGC.Webform.wucCodeDictTab" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabEdit" style="width: 70%" class="table table-bordered table-hover table td table-sm">
    <tr>
        <td>
            <asp:Label ID="lblCodeTabId" name="lblCodeTabId" CssClass="col-form-label text-right" Width="90px" Text="代码表Id" runat="server" />
        </td>
        <td>
            <asp:DropDownList ID="ddlCodeTabId" name="ddlCodeTabId" CssClass="form-control" Width="150px" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlCodeTabId_SelectedIndexChanged" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCodeTabCodeId" name="lblCodeTabCodeId" CssClass="col-form-label text-right" Width="90px" Text="代码Id" runat="server" />
        </td>
        <td>
            <asp:DropDownList ID="ddlCodeTabCodeId" CssClass="form-control" Width="150px" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCodeTabNameId" name="lblCodeTabNameId" CssClass="col-form-label text-right" Width="90px" Text="代码_名Id" runat="server" />
        </td>
        <td>
            <asp:DropDownList ID="ddlCodeTabNameId" CssClass="form-control" Width="150px" runat="server" />            
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
        </td>
        <td colspan="799">
            <asp:TextBox ID="txtMemo" name="txtMemo" CssClass="form-control" Width="150px" runat="server" />
        </td>
    </tr>
</table>
