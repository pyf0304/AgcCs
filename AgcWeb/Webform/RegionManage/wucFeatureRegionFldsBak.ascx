
<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFeatureRegionFldsBak.ascx.cs" Inherits="AGC.Webform.wucFeatureRegionFldsBak" %>
<link rel="stylesheet" type="text/css" href="../../css/tz_base1Bak.css"/>
<table id="tabwucFeatureRegionFlds" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblRegionId" runat="server" CssClass="col-form-label text-right">区域Id</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtRegionId" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
<asp:CompareValidator id="ComValid_RegionId" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="txtRegionId" 
Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
</asp:CompareValidator>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblButtonName" runat="server" CssClass="col-form-label text-right">按钮名称</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtButtonName" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblText" runat="server" CssClass="col-form-label text-right">文本内容</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtText" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblCtlTypeId" runat="server" CssClass="col-form-label text-right">控件类型号</asp:Label>
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlCtlTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblHeight" runat="server" CssClass="col-form-label text-right">高度</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtHeight" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
<asp:CompareValidator id="ComValid_Height" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="txtHeight" 
Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
</asp:CompareValidator>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblWidth" runat="server" CssClass="col-form-label text-right">宽</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtWidth" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
<asp:CompareValidator id="ComValid_Width" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="txtWidth" 
Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
</asp:CompareValidator>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblSeqNum" runat="server" CssClass="col-form-label text-right">字段序号</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtSeqNum" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
<asp:CompareValidator id="ComValid_SeqNum" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="txtSeqNum" 
Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
</asp:CompareValidator>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblCssClass" runat="server" CssClass="col-form-label text-right">样式表</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtCssClass" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblImageUrl" runat="server" CssClass="col-form-label text-right">图片资源</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtImageUrl" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
</table>