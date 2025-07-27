<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucSqlViewRelaTabB.ascx.cs" Inherits="AGC.Webform.wucSqlViewRelaTabB" %>

<table id="tabwucSqlViewRelaTab" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSqlViewId" runat="server" CssClass="col-form-label text-right">Sql视图Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlSqlViewId" runat="server" class="form-control-sm" Width="400px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblRelaTabId" runat="server" CssClass="col-form-label text-right">相关表Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlRelaTabId" runat="server" class="form-control-sm" Width="400px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabAliases" runat="server" CssClass="col-form-label text-right">表别名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabAliases" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSvRelaTabTypeId" runat="server" CssClass="col-form-label text-right" Width="120px">Sql视图相关表类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlSvRelaTabTypeId" runat="server" class="form-control-sm" Width="400px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabRelationTypeId" runat="server" CssClass="col-form-label text-right">表关系类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlTabRelationTypeId" runat="server" class="form-control-sm" Width="400px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabRelationText" runat="server" CssClass="col-form-label text-right">表关系文本</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabRelationText" runat="server" class="form-control-sm" Rows="4" TextMode="MultiLine" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblOrderNum" runat="server" CssClass="col-form-label text-right">序号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtOrderNum" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_OrderNum" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="txtOrderNum"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Rows="4" TextMode="MultiLine" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
