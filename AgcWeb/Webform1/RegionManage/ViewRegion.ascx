<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="ViewRegion.ascx.cs" Inherits="AGC.Webform.ViewRegion" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabEdit" style="width: 70%" class="table table-bordered table-hover table td table-sm">
    <tr id="trRegionName">
        <td class="text-right">
            <asp:Label ID="lblRegionId" name="lblRegionId" CssClass="col-form-label text-right" Width="90px" Text="区域Id" runat="server" />
        </td>
        <td class="text-left">
            <asp:TextBox ID="txtRegionId" name="txtRegionId" CssClass="form-control" Width="150px" runat="server" />
        </td>
        <td class="text-right">
            <asp:Label ID="lblRegionName" name="lblRegionName" CssClass="col-form-label text-right" Width="90px" Text="区域名称" runat="server" />
        </td>
        <td class="text-left">
            <asp:TextBox ID="txtRegionName" name="txtRegionName" CssClass="form-control" Width="150px" runat="server" />
        </td>
    </tr>
    <tr id="trRegionTypeId">
        <td class="text-right">
            <asp:Label ID="lblApplicationTypeId" name="lblApplicationTypeId" CssClass="col-form-label text-right" Width="90px" Text="应用类型" runat="server" />
        </td>
        <td class="text-left">
            <asp:DropDownList ID="ddlApplicationTypeId" name="ddlApplicationTypeId" CssClass="form-control" Width="150px" runat="server" />
        </td>
        <td class="text-right">
            <asp:Label ID="lblRegionTypeId" name="lblRegionTypeId" CssClass="col-form-label text-right" Width="90px" Text="区域类型" runat="server" />
        </td>
        <td class="text-left">
            <asp:DropDownList ID="ddlRegionTypeId" name="ddlRegionTypeId" CssClass="form-control" Width="150px" runat="server" />
        </td>
    </tr>
    <tr id="trRegionFunction">
        <td class="text-right">
            <asp:Label ID="lblRegionFunction" name="lblRegionFunction" CssClass="col-form-label text-right" Width="90px" Text="区域功能" runat="server" />
        </td>
        <td class="text-left" colspan="3">
            <asp:TextBox ID="txtRegionFunction" name="txtRegionFunction" CssClass="form-control" Width="400px" runat="server" />
        </td>
    </tr>
    <tr id="trClassName">
        <td class="text-right">
            <asp:Label ID="lblClassName" name="lblClassName" CssClass="col-form-label text-right" Width="90px" Text="类名" runat="server" />
        </td>
        <td class="text-left" colspan="3">
            <asp:TextBox ID="txtClassName" name="txtClassName" CssClass="form-control" Width="400px" runat="server" />
        </td>
    </tr>
    <tr id="trFileName">
        <td class="text-right">
            <asp:Label ID="lblFileName" name="lblFileName" CssClass="col-form-label text-right" Width="90px" Text="文件名" runat="server" />
        </td>
        <td class="text-left" colspan="3">
            <asp:TextBox ID="txtFileName" name="txtFileName" CssClass="form-control" Width="400px" runat="server" />
        </td>
    </tr>
    <tr id="trColNum">
        <td class="text-right">
            <asp:Label ID="lblWidth" name="lblWidth" CssClass="col-form-label text-right" Width="90px" Text="宽" runat="server" />
        </td>
        <td class="text-left">
            <asp:TextBox ID="txtWidth" name="txtWidth" CssClass="form-control" Width="150px" runat="server" />
            <asp:CompareValidator ID="ComValid_Width" name="ComValid_Width" runat="server" CssClass="ErrMsg"
                ErrorMessage="请输入整型数值!"
                ControlToValidate="txtWidth"
                Type="Integer"
                Operator="DataTypeCheck"
                EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td class="text-right">
            <asp:Label ID="lblColNum" name="lblColNum" CssClass="col-form-label text-right" Width="90px" Text="列数" runat="server" />
        </td>
        <td class="text-left">
            <asp:TextBox ID="txtColNum" name="txtColNum" CssClass="form-control" Width="150px" runat="server" />
            <asp:CompareValidator ID="ComValid_ColNum" name="ComValid_ColNum" runat="server" CssClass="ErrMsg"
                ErrorMessage="请输入整型数值!"
                ControlToValidate="txtColNum"
                Type="Integer"
                Operator="DataTypeCheck"
                EnableClientScript="false">
            </asp:CompareValidator>
        </td>
    </tr>
    <tr id="trPageDispModeId">
        <td class="text-right">
            <asp:Label ID="lblContainerTypeId" name="lblContainerTypeId" CssClass="col-form-label text-right" Width="90px" Text="容器类型" runat="server" />
        </td>
        <td class="text-left">
            <asp:DropDownList ID="ddlContainerTypeId" name="ddlContainerTypeId" CssClass="form-control" Width="150px" runat="server" />
        </td>
        <td class="text-right">
            <asp:Label ID="lblPageDispModeId" name="lblPageDispModeId" CssClass="col-form-label text-right" Width="90px" Text="显示模式" runat="server" />
        </td>
        <td class="text-left">
            <asp:DropDownList ID="ddlPageDispModeId" name="ddlPageDispModeId" CssClass="form-control" Width="150px" runat="server" />
        </td>
    </tr>
    <tr id="trInRelaTabId">
        <td class="text-right">
            <asp:Label ID="lblInSqlDsTypeId" name="lblInSqlDsTypeId" CssClass="col-form-label text-right" Width="90px" Text="IN/Out类型" runat="server" />
        </td>
        <td class="text-left">
            <asp:DropDownList ID="ddlInOutTypeId" name="ddlInSqlDsTypeId" CssClass="form-control" Width="150px" runat="server" />
        </td>
        <td class="text-right">
            <asp:Label ID="lblInRelaTabId" name="lblInRelaTabId" CssClass="col-form-label text-right" Width="90px" Text="数据表" runat="server" />
        </td>
        <td class="text-left">
            <asp:DropDownList ID="ddlTabId" name="ddlInRelaTabId" CssClass="form-control" Width="150px" runat="server" />
        </td>
    </tr>
    <tr id="trOutRelaTabId">
        <td class="text-right">
            &nbsp;</td>
        <td class="text-left">
            &nbsp;</td>
        <td class="text-right">
            &nbsp;</td>
        <td class="text-left">
            &nbsp;</td>
    </tr>
    <tr id="trMemo">
        <td class="text-right">
            <asp:Label ID="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
        </td>
        <td class="text-left" colspan="3">
            <asp:TextBox ID="txtMemo" name="txtMemo" CssClass="form-control" Width="400px" runat="server" />
        </td>
    </tr>
</table>
