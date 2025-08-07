<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucViewReferFilesB.ascx.cs" Inherits="AGC.Webform.wucViewReferFilesB" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabwucViewReferFiles" style="width: 600px; padding: 1px; border: 0px" class="table table-bordered table-hover">
    <tr>
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
            <asp:Label ID="lblCodeTypeId" CssClass="col-form-label text-right" Width="90px" Text="代码类型Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlCodeTypeId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblReferFileId" CssClass="col-form-label text-right" Width="90px" Text="引用文件Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlReferFileId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD"></td>
        <td class="ValueTD">
            <asp:CheckBox ID="chkInUse" CssClass="form-control" Width="200px" Text="是否在用" runat="server"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblOrderNum" CssClass="col-form-label text-right" Width="90px" Text="序号" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtOrderNum" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_OrderNum" runat="server" CssClass="ErrMsg"
                ErrorMessage="请输入整型数值!"
                ControlToValidate="txtOrderNum"
                Type="Integer"
                Operator="DataTypeCheck"
                EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD"></td>
        <td class="ValueTD">
            <asp:CheckBox ID="chkIsTemplate" CssClass="form-control" Width="200px" Text="是否模板" runat="server"></asp:CheckBox>
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
