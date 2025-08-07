<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucViewImplementationB.ascx.cs" Inherits="AGC.Webform.wucViewImplementationB" %>

<table id="tabwucViewImplementation" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblViewImplId" runat="server" CssClass="col-form-label text-right">界面实现Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtViewImplId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblViewImplName" runat="server" CssClass="col-form-label text-right">界面实现名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtViewImplName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblViewImplENName" runat="server" CssClass="col-form-label text-right">界面实现英文名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtViewImplENName" runat="server" class="form-control-sm"></asp:TextBox>
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
