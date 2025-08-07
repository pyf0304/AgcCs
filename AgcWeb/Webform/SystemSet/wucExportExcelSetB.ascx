
<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucExportExcelSetB.ascx.cs" Inherits="AGC.Webform.wucExportExcelSetB" %>
<link rel="stylesheet" type="text/css" href="../../css/taishweb2.css"/>
<table id="tabwucExportExcelSet" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblIdExportExcel4Users" runat="server" CssClass="col-form-label text-right">流水号</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtIdExportExcel4Users" runat="server" class="form-control-sm" 
        Width="400px"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblViewName" runat="server" CssClass="col-form-label text-right">界面名称</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtViewName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblTabName" runat="server" CssClass="col-form-label text-right">表名</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtTabName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblUserID" runat="server" CssClass="col-form-label text-right">用户ID</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtUserID" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
</td>
</tr>
<tr>
<td colspan="2">
<asp:CheckBox id="chkIsDefaultUser" runat="server" Text="是否缺省用户" CssClass="Check_Defa"></asp:CheckBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblExportFileName" runat="server" CssClass="col-form-label text-right">导出文件名</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtExportFileName" runat="server" class="form-control-sm" 
        Width="400px"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMemo" runat="server" CssClass="col-form-label text-right">备注</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" runat="server" class="form-control-sm" Height="63px" 
        TextMode="MultiLine" Width="400px"></asp:TextBox>
</td>
</tr>
</table>