<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucSqlCommandTypeB.ascx.cs" Inherits="AGC.Webform.wucSqlCommandTypeB" %>

<table id="tabwucSqlCommandType" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSqlCommandTypeId" runat="server" CssClass="col-form-label text-right">Sql命令类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSqlCommandTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSqlCommandTypeName" runat="server" CssClass="col-form-label text-right">Sql命令类型名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSqlCommandTypeName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
