<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFunctionRelaB.ascx.cs" Inherits="AGC.Webform.wucFunctionRelaB" %>

<table id="tabwucFunctionRela" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncAId" runat="server" CssClass="col-form-label text-right">函数AId</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFuncAId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncBId" runat="server" CssClass="col-form-label text-right">函数BId</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFuncBId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFunctionRelaTypeId" runat="server" CssClass="col-form-label text-right">函数关系类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFunctionRelaTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
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
