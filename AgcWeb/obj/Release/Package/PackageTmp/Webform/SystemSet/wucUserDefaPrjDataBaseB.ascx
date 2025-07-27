<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucUserDefaPrjDataBaseB.ascx.cs" Inherits="AGC.Webform.wucUserDefaPrjDataBaseB" %>

<table id="tabwucUserDefaPrjDataBase" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" runat="server" CssClass="col-form-label text-right">工程ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserId" runat="server" CssClass="col-form-label text-right">用户ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUserId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjDataBaseId" runat="server" CssClass="col-form-label text-right">项目数据库Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjDataBaseId" runat="server" class="form-control-sm"></asp:DropDownList>
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
