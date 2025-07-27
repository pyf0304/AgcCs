<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucPrjFileState.ascx.cs" Inherits="AGC.Webform.wucPrjFileState" %>
<table id="tabwucPrjFileState" style="width: 600px; padding: 1px; border: 0px" class="table table-bordered table-hover">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjFileStateId" CssClass="col-form-label text-right" Width="112px" Text="工程文件状态Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrjFileStateId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjFileStateName" CssClass="col-form-label text-right" Width="116px" Text="工程文件状态名" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrjFileStateName" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjFileStateENName" CssClass="col-form-label text-right" Width="145px" Text="工程文件状态英文名" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrjFileStateENName" CssClass="form-control" Width="200px" runat="server" />
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
            <asp:CompareValidator ID="ComValid_OrderNum" name="ComValid_OrderNum" runat="server" CssClass="ErrMsg"
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
