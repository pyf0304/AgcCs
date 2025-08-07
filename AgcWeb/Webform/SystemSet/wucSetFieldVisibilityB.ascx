<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucSetFieldVisibilityB.ascx.cs" Inherits="AGC.Webform.wucSetFieldVisibilityB" %>

<table id="tabwucSetFieldVisibility" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblIdSchool" runat="server" CssClass="col-form-label text-right">学校流水号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlIdSchool" runat="server" class="form-control-sm"></asp:DropDownList>
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
            <asp:Label ID="lblViewName" runat="server" CssClass="col-form-label text-right">界面名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtViewName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFieldName" runat="server" CssClass="col-form-label text-right">字段名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFieldName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCtrlType" runat="server" CssClass="col-form-label text-right">控件类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCtrlType" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsVisible" runat="server" Text="是否显示" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUpdDate" runat="server" CssClass="col-form-label text-right">修改日期</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtUpdDate" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUpdUserId" runat="server" CssClass="col-form-label text-right">修改用户Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtUpdUserId" runat="server" class="form-control-sm"></asp:TextBox>
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
