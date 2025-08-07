
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucTabFunctionProp.ascx.cs" Inherits = "AGC.Webform.wucTabFunctionProp" %>
<table id="tabwucTabFunctionProp" style="width: 600px; padding: 1px; border:0px" class="table table-bordered table-hover">
<tr>
<td class="NameTD">
<asp:Label id="lblTabId" CssClass="col-form-label text-right" Width="90px" Text="表ID" runat="server" />
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
<asp:Label id="lblFunctionTemplateId" CssClass="col-form-label text-right" Width="90px" Text="函数模板Id" runat="server" />
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlFunctionTemplateId" name="ddlFunctionTemplateId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblCodeTypeId" CssClass="col-form-label text-right" Width="90px" Text="代码类型Id" runat="server" />
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlCodeTypeId" name="ddlCodeTypeId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblFuncId4GC" CssClass="col-form-label text-right" Width="90px" Text="函数ID" runat="server" />
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlFuncId4GC" name="ddlFuncId4GC" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMethodModifierId" CssClass="col-form-label text-right" Width="90px" Text="函数修饰语Id" runat="server" />
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlMethodModifierId" name="ddlMethodModifierId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
</td>
<td class="ValueTD">
<asp:CheckBox  id="chkIsForAllTemplate" name="chkIsForAllTemplate" CssClass = "form-control"   Width = "200px"  Text = "是否针对所有模板"   runat="server" >
</asp:CheckBox>
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