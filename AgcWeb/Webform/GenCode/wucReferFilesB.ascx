<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucReferFilesB.ascx.cs" Inherits="AGC.Webform.wucReferFilesB" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabwucReferFiles" style="width: 600px; padding: 1px; border: 0px" class="table table-bordered table-hover">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblReferFileId" CssClass="col-form-label text-right" Width="90px" Text="引用文件Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtReferFileId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFileName" CssClass="col-form-label text-right" Width="90px" Text="文件名" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFileName" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFilePath" CssClass="col-form-label text-right" Width="90px" Text="文件路径" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFilePath" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD"></td>
        <td class="ValueTD">
            <asp:CheckBox ID="chkIsNeedDownLoad" CssClass="form-control" Width="200px" Text="是否需要下载" runat="server"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblVersion" CssClass="col-form-label text-right" Width="90px" Text="版本" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtVersion" CssClass="form-control" Width="200px" runat="server" />
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
