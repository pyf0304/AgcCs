<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFunctionRelaTypeB.ascx.cs" Inherits="AGC.Webform.wucFunctionRelaTypeB" %>

<table id="tabwucFunctionRelaType" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFunctionRelaTypeId" runat="server" CssClass="col-form-label text-right">函数关系类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFunctionRelaTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFunctionRelaTypeName" runat="server" CssClass="col-form-label text-right">函数关系类型名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFunctionRelaTypeName" runat="server" class="form-control-sm"></asp:TextBox>
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
