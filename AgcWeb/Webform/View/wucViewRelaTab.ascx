<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucViewRelaTab.ascx.cs" Inherits="AGC.Webform.wucViewRelaTab" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabwucViewRelaTab" style="width: 600px; padding: 1px; border: 0px" class="table table-bordered table-hover">
    <tr id="trViewId" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblViewId" CssClass="col-form-label text-right" Width="90px" Text="界面Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlViewId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblRegionId" CssClass="col-form-label text-right" Width="90px" Text="区域" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlRegionId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_RegionId" runat="server" CssClass="ErrMsg"
                ErrorMessage="请输入整型数值!"
                ControlToValidate="ddlRegionId"
                Type="Integer"
                Operator="DataTypeCheck"
                EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblInOutTypeId" CssClass="col-form-label text-right" Width="90px" Text="INOUT类型" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlInOutTypeId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblViewTabTypeId" CssClass="col-form-label text-right" Width="90px" Text="界面表类型" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlViewTabTypeId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabId" CssClass="col-form-label text-right" Width="90px" Text="表" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlTabId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabFunction" CssClass="col-form-label text-right" Width="90px" Text="表功能说明" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabFunction" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
