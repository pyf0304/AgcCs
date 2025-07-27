
<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucExportExcel4UsersB.ascx.cs" Inherits="AGC.Webform.wucExportExcel4UsersB" %>
<link rel="stylesheet" type="text/css" href="../../css/taishweb2.css"/>
<table id="tabwucExportExcel4Users" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblIdExportExcel4Users" runat="server" CssClass="col-form-label text-right">流水号</asp:Label>
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlIdExportExcel4Users" runat="server" 
        class="form-control-sm" Width="400px"></asp:DropDownList>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblFieldName" runat="server" CssClass="col-form-label text-right">字段名</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtFieldName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblFieldCnName" runat="server" CssClass="col-form-label text-right">中文名称</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtFieldCnName" runat="server" class="form-control-sm" 
        Width="400px"></asp:TextBox>
</td>
<td>
</td>
</tr>
<tr>
<td colspan="2">
<asp:CheckBox id="chkIsExport" runat="server" Text="是否导出" CssClass="Check_Defa"></asp:CheckBox>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblOrderNum" runat="server" CssClass="col-form-label text-right">序号</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtOrderNum" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
</td>
<td>
<asp:CompareValidator id="ComValid_OrderNum" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="txtOrderNum" 
Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
</asp:CompareValidator>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMemo" runat="server" CssClass="col-form-label text-right">备注</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" runat="server" class="form-control-sm" Width="400px" 
        Height="54px" TextMode="MultiLine"></asp:TextBox>
</td>
<td>
</td>
</tr>
</table>