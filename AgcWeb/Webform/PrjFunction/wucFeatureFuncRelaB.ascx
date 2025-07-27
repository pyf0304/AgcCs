<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFeatureFuncRelaB.ascx.cs" Inherits="AGC.Webform.wucFeatureFuncRelaB" %>

<table id="tabwucFeatureFuncRela" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label1" runat="server" CssClass="col-form-label text-right">应用类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlApplicationTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFeatureId" runat="server" CssClass="col-form-label text-right">功能Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFeatureId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">函数4GC</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFuncId4GC" runat="server" class="form-control-sm"></asp:DropDownList>
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
