
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucFeatureAppTypeRela.ascx.cs" Inherits = "AGC.Webform.wucFeatureAppTypeRela" %>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabwucFeatureAppTypeRela" style="width: 600px; padding: 1px; border:0px" class="table table-bordered table-hover">
<tr>
<td class="NameTD">
<asp:Label id="lblApplicationTypeId" CssClass="col-form-label text-right" Width="90px" Text="应用程序类型ID" runat="server" />
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlApplicationTypeId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
<asp:CompareValidator id="ComValid_ApplicationTypeId" runat="server" CssClass="ErrMsg"
 ErrorMessage="请输入整型数值!"
 ControlToValidate="ddlApplicationTypeId"
 Type="Integer"
 Operator="DataTypeCheck"
 EnableClientScript="false">
</asp:CompareValidator>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblFeatureId" CssClass="col-form-label text-right" Width="90px" Text="功能Id" runat="server" />
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlFeatureId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblOrderNum" CssClass="col-form-label text-right" Width="90px" Text="序号" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtOrderNum" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
<asp:CompareValidator id="ComValid_OrderNum" runat="server" CssClass="ErrMsg"
 ErrorMessage="请输入整型数值!"
 ControlToValidate="txtOrderNum"
 Type="Integer"
 Operator="DataTypeCheck"
 EnableClientScript="false">
</asp:CompareValidator>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
</td>
<td class="ValueTD">
<asp:CheckBox  id="chkInUse" CssClass = "form-control"   Width = "200px"  Text = "是否在用"   runat="server" >
</asp:CheckBox>
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
</table>