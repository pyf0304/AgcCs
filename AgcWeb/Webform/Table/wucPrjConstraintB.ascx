<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucPrjConstraintB.ascx.cs" Inherits="AGC.Webform.wucPrjConstraintB" %>

<table id="tabwucPrjConstraint" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjConstraintId" runat="server" CssClass="col-form-label text-right">约束表Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrjConstraintId" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblConstraintName" runat="server" CssClass="col-form-label text-right">约束表名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtConstraintName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>

    <tr id="trHidden" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblTabId" runat="server" CssClass="col-form-label text-right">表ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlTabId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblConstraintTypeId" runat="server" CssClass="col-form-label text-right">约束类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlConstraintTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblConstraintDescription" runat="server" CssClass="col-form-label text-right">约束说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtConstraintDescription" runat="server" class="form-control-sm" Height="129px" TextMode="MultiLine" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblInUse" runat="server" CssClass="col-form-label text-right">是否在用</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlInUse" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Height="46px" TextMode="MultiLine" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
