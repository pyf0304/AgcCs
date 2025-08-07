<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucExportExcelSetB_Sim.ascx.cs"
    Inherits="AGC.Webform.wucExportExcelSetB_Sim" %>
<link href="../../css/taishweb2.css" rel="stylesheet" type="text/css" />
<table id="tabwucExportExcelSet" cellspacing="1" cellpadding="1" border="0" style="width: 619px">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblViewName" runat="server" Width="70px" CssClass="col-form-label text-right">界面名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:Label ID="txtViewName" runat="server" class="form-control-sm"></asp:Label>
        </td>
        <td class="NameTD">
            <asp:Label ID="lblTabName" runat="server" CssClass="col-form-label text-right">表名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:Label ID="txtTabName" runat="server" class="form-control-sm"></asp:Label>
        </td>
        <td class="NameTD">
            <asp:Label ID="lblUserID" runat="server" CssClass="col-form-label text-right">用户ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:Label ID="txtUserID" runat="server" class="form-control-sm"></asp:Label>
        </td>
        <td class="ValueTD">
            <asp:Label ID="lblIsDefaultUser" runat="server" class="form-control-sm"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblExportFileName" runat="server" CssClass="col-form-label text-right">导出文件名</asp:Label>
        </td>
        <td class="ValueTD" colspan="5">
            <asp:TextBox ID="txtExportFileName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td class="ValueTD">
            &nbsp;</td>
    </tr>
</table>
