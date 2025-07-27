<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucTabTypeB.ascx.cs" Inherits="AGC.Webform.wucTabTypeB" %>

<table id="tabwucTabType" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabTypeId" runat="server" CssClass="col-form-label text-right">表类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabTypeName" runat="server" CssClass="col-form-label text-right">表类型名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabTypeName" runat="server" class="form-control-sm"></asp:TextBox>
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
