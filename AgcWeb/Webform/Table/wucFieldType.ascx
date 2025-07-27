
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucFieldType.ascx.cs" Inherits = "AGC.Webform.wucFieldType" %>
<table id="tabwucFieldType" name="tabwucFieldType" style="width: 600px; padding: 1px; border:0px" class="table table-bordered table-hover">
<tr>
<td class="NameTD">
<asp:Label id="lblFieldTypeId" name="lblFieldTypeId" CssClass="col-form-label text-right" Width="90px" Text="字段类型Id" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtFieldTypeId" name="txtFieldTypeId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblFieldTypeName" name="lblFieldTypeName" CssClass="col-form-label text-right" Width="90px" Text="字段类型名" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtFieldTypeName" name="txtFieldTypeName" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblFieldTypeENName" name="lblFieldTypeENName" CssClass="col-form-label text-right" Width="90px" Text="字段类型英文名" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtFieldTypeENName" name="txtFieldTypeENName" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblOrderNum" name="lblOrderNum" CssClass="col-form-label text-right" Width="90px" Text="序号" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtOrderNum" name="txtOrderNum" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
<asp:CompareValidator id="ComValid_OrderNum" name="ComValid_OrderNum" runat="server" CssClass="ErrMsg"
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
<asp:Label id="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" name="txtMemo" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
</table>