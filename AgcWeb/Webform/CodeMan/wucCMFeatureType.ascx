<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucCMFeatureType.ascx.cs" Inherits="AGC.Webform.wucCMFeatureType" %>

<table id="tabwucCMFeatureType" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCmFeatureTypeId" runat="server" CssClass="col-form-label text-right">功能类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCmFeatureTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFeatureTypeName" runat="server" CssClass="col-form-label text-right">功能类型名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFeatureTypeName" runat="server" class="form-control-sm"></asp:TextBox>
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
