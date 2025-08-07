
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucFunctionTemplateRela.ascx.cs" Inherits = "AGC.Webform.wucFunctionTemplateRela" %>
<table id="tabEdit" style="width: 70%; " class="table table-bordered table-hover table td table-sm">
<tr>
<td>
<asp:Label id="lblFunctionTemplateId" name="lblFunctionTemplateId" CssClass="col-form-label text-right" Width="90px" Text="函数模板Id" runat="server" />
</td>
<td>
<asp:DropDownList id="ddlFunctionTemplateId" name="ddlFunctionTemplateId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
<asp:Label id="lblFuncId4GC" name="lblFuncId4GC" CssClass="col-form-label text-right" Width="90px" Text="函数ID" runat="server" />
</td>
<td>
<asp:DropDownList id="ddlFuncId4GC" name="ddlFuncId4GC" CssClass="form-control" Width="200px" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label id="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
</td>
<td>
<asp:TextBox id="txtMemo" name="txtMemo" CssClass="form-control" Width="200px" runat="server" />
</td>
</tr>
</table>