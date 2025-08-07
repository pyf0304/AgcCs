<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucProgLevelTypeB.ascx.cs" Inherits="AGC.Webform.wucProgLevelTypeB" %>

<table id="tabwucProgLevelType" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblProgLevelTypeId" runat="server" CssClass="col-form-label text-right">程序分层类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtProgLevelTypeId" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblProgLevelTypeName" runat="server" CssClass="col-form-label text-right">程序分层类型名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtProgLevelTypeName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblProgLevelTypeENName" runat="server" CssClass="col-form-label text-right">程序分层类型英文名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtProgLevelTypeENName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrefix" runat="server" CssClass="col-form-label text-right">前缀</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrefix" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
   
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
