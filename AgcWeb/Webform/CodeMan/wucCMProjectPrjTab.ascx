
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucCMProjectPrjTab.ascx.cs" Inherits = "AGC.Webform.wucCMProjectPrjTab" %>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabwucCMProjectPrjTab" name="tabwucCMProjectPrjTab" style="width: 600px; padding: 1px; border:0px" class="table table-bordered table-hover">
<tr>
<td class="NameTD">
<asp:Label id="lblCmPrjId" name="lblCmPrjId" CssClass="col-form-label text-right" Width="90px" Text="CM工程Id" runat="server" />
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlCmPrjId" name="ddlCmPrjId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblTabId" name="lblTabId" CssClass="col-form-label text-right" Width="90px" Text="表ID" runat="server" />
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlTabId" name="ddlTabId" CssClass="form-control" Width="200px" runat="server" />
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