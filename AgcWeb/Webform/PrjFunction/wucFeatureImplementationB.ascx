<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFeatureImplementationB.ascx.cs" Inherits="AGC.Webform.wucFeatureImplementationB" %>

<table id="tabwucFeatureImplementation" style="width: 600px; padding: 1px;" border="0">
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
            <asp:Label ID="lblViewImplId" runat="server" CssClass="col-form-label text-right">界面实现Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlViewImplId" runat="server" class="form-control-sm"></asp:DropDownList>
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
