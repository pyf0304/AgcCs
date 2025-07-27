<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucTabRelationTypeB.ascx.cs" Inherits="AGC.Webform.wucTabRelationTypeB" %>

<table id="tabwucTabRelationType" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabRelationTypeId" runat="server" CssClass="col-form-label text-right">表关系类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabRelationTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabRelationTypeName" runat="server" CssClass="col-form-label text-right">表关系类型名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabRelationTypeName" runat="server" class="form-control-sm"></asp:TextBox>
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
