
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "PrjTab_Edit.ascx.cs" Inherits = "AGC.Webform.PrjTab_Edit" %>
<table id="tabEdit" style="width: 70%" class="table table-bordered table-hover table td table-sm">
<tr id="trTabName">
<td class="text-right">
<asp:Label id="lblTabId" name="lblTabId" CssClass="col-form-label text-right" Width="90px" Text="表ID" runat="server" />
</td>
<td class="text-left">
<asp:TextBox id="txtTabId" name="txtTabId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td class="text-right">
<asp:Label id="lblTabName" name="lblTabName" CssClass="col-form-label text-right" Width="90px" Text="表名" runat="server" />
</td>
<td class="text-left">
<asp:TextBox id="txtTabName" name="txtTabName" CssClass="form-control" Width="200px" runat="server" />
</td>
</tr>
<tr id="trSqlDsTypeId">
<td class="text-right">
<asp:Label id="lblTabCnName" name="lblTabCnName" CssClass="col-form-label text-right" Width="90px" Text="表中文名" runat="server" />
</td>
<td class="text-left">
<asp:TextBox id="txtTabCnName" name="txtTabCnName" CssClass="form-control" Width="200px" runat="server" />
</td>
<td class="text-right">
<asp:Label id="lblSqlDsTypeId" name="lblSqlDsTypeId" CssClass="col-form-label text-right" Width="90px" Text="数据源类型" runat="server" />
</td>
<td class="text-left">
<asp:DropDownList id="ddlSqlDsTypeId" name="ddlSqlDsTypeId" CssClass="form-control" Width="200px" runat="server" />
</td>
</tr>
<tr id="trTabNameB">
<td class="text-right">
<asp:Label id="lblTabStateId" name="lblTabStateId" CssClass="col-form-label text-right" Width="90px" Text="表状态ID" runat="server" />
</td>
<td class="text-left">
<asp:DropDownList id="ddlTabStateId" name="ddlTabStateId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td class="text-right">
<asp:Label id="lblTabNameB" name="lblTabNameB" CssClass="col-form-label text-right" Width="90px" Text="表名_后备" runat="server" />
</td>
<td class="text-left">
<asp:TextBox id="txtTabNameB" name="txtTabNameB" CssClass="form-control" Width="200px" runat="server" />
</td>
</tr>
<tr id="trDataBaseName">
<td class="text-right">
<asp:Label id="lblFuncModuleAgcId" name="lblFuncModuleAgcId" CssClass="col-form-label text-right" Width="90px" Text="功能模块" runat="server" />
</td>
<td class="text-left">
<asp:DropDownList id="ddlFuncModuleAgcId" name="ddlFuncModuleAgcId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td class="text-right">
<asp:Label id="lblDataBaseName" name="lblDataBaseName" CssClass="col-form-label text-right" Width="90px" Text="数据库名" runat="server" />
</td>
<td class="text-left">
<asp:TextBox id="txtDataBaseName" name="txtDataBaseName" CssClass="form-control" Width="200px" runat="server" />
</td>
</tr>
<tr id="trOwner">
<td class="text-right">
<asp:Label id="lblOwner" name="lblOwner" CssClass="col-form-label text-right" Width="90px" Text="拥有者" runat="server" />
</td>
<td class="text-left">
<asp:TextBox id="txtOwner" name="txtOwner" CssClass="form-control" Width="200px" runat="server" />
</td>
</tr>
<tr id="trMemo">
<td class="text-right">
<asp:Label id="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
</td>
<td class="text-left" ColSpan=3>
<asp:TextBox id="txtMemo" name="txtMemo" CssClass="form-control" Width="400px" runat="server" />
</td>
</tr>
</table>