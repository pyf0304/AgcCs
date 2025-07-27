<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFuncGCTypeB.ascx.cs" Inherits="AGC.Webform.wucFuncGCTypeB" %>

<table id="tabwucFuncGCType" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncGCTypeId" runat="server" CssClass="col-form-label text-right">函数生成代码类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncGCTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncGCTypeName" runat="server" CssClass="col-form-label text-right">函数生成代码类型名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncGCTypeName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncGCTypeENName" runat="server" CssClass="col-form-label text-right">函数生成代码类型英文名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncGCTypeENName" runat="server" class="form-control-sm"></asp:TextBox>
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
