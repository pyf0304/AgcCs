<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucConstraintFieldsB.ascx.cs" Inherits="AGC.Webform.wucConstraintFieldsB" %>

<table id="tabwucConstraintFields" style="width: 600px; padding: 1px;" border="0">
    <tr id="trHidden" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblPrjConstraintId" runat="server" CssClass="col-form-label text-right">约束表Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjConstraintId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFldId" runat="server" CssClass="col-form-label text-right">字段Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFldId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSortTypeId" runat="server" CssClass="col-form-label text-right">排序类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlSortTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMaxValue" runat="server" CssClass="col-form-label text-right">最大值</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMaxValue" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMinValue" runat="server" CssClass="col-form-label text-right">最小值</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMinValue" runat="server" class="form-control-sm"></asp:TextBox>
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
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
