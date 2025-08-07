<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucTextResourceTypeB.ascx.cs" Inherits="AGC.Webform.wucTextResourceTypeB" %>

<table id="tabwucTextResourceType" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTextResourceTypeId" runat="server" CssClass="col-form-label text-right">文本来源类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTextResourceTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTextResourceTypeName" runat="server" CssClass="col-form-label text-right">文本来源类型名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTextResourceTypeName" runat="server" class="form-control-sm"></asp:TextBox>
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
