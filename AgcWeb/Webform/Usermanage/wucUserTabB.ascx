<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucUserTabB.ascx.cs" Inherits="AGC.Webform.wucUserTabB" %>
<link rel="stylesheet" type="text/css" href="../Css/Images/taize_1.css" />
<table id="tabwucUserTab" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblIdUser" runat="server" CssClass="col-form-label text-right">IdUser</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtIdUser" runat="server" class="form-control-sm" Width="200px" Enabled="false"></asp:TextBox>
        </td>
    </tr>
  
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserID" runat="server" CssClass="col-form-label text-right">登录名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtUserID" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserName" runat="server" CssClass="col-form-label text-right">用户姓名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtUserName" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserPwd" runat="server" CssClass="col-form-label text-right">口令</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtUserPwd" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblIdentityID" runat="server" CssClass="col-form-label text-right">用户身份</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlIdentityID" runat="server" class="form-control-sm" Width="200px"></asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDepartmentId" runat="server" CssClass="col-form-label text-right">学院</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlDepartmentId" runat="server" class="form-control-sm" Width="200px"></asp:DropDownList>
        </td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblActive" runat="server" CssClass="col-form-label text-right">Active</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtActive" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
           
        </td>
        <td>
             <asp:CheckBox ID="chkAudit" runat="server" Text="是否审核" CssClass="Check_Defa"></asp:CheckBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblAuditUser" runat="server" CssClass="col-form-label text-right">审核人</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtAuditUser" runat="server" class="form-control-sm" Width="200px"  Enabled="false"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblRegisterDate" runat="server" CssClass="col-form-label text-right">创建时间</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtRegisterDate" runat="server" class="form-control-sm" Width="200px"  Enabled="false"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblAuditDate" runat="server" CssClass="col-form-label text-right">更新时间</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtAuditDate" runat="server" class="form-control-sm" Width="200px"  Enabled="false"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">备注</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Width="350px" Height="75px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
