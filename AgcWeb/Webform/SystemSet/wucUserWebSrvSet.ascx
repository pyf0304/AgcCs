
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucUserWebSrvSet.ascx.cs" Inherits = "AGC.Webform.wucUserWebSrvSet" %>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabwucUserWebSrvSet" name="tabwucUserWebSrvSet" style="width: 600px; padding: 1px; border:0px" class="table table-bordered table-hover">
<tr>
<td class="NameTD">
<asp:Label id="lblUserId" name="lblUserId" CssClass="col-form-label text-right" Width="90px" Text="用户Id" runat="server" />
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlUserId" name="ddlUserId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMachineName" name="lblMachineName" CssClass="col-form-label text-right" Width="90px" Text="机器名" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtMachineName" name="txtMachineName" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblWebApiIPAndPort" name="lblWebApiIPAndPort" CssClass="col-form-label text-right" Width="90px" Text="WebApiIPAndPort" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtWebApiIPAndPort" name="txtWebApiIPAndPort" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblWebApiVirtualPath" name="lblWebApiVirtualPath" CssClass="col-form-label text-right" Width="90px" Text="WebApi虚拟路径" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtWebApiVirtualPath" name="txtWebApiVirtualPath" CssClass="form-control" Width="200px" runat="server" />
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
<asp:CheckBox  id="chkIsTemplate" name="chkIsTemplate" CssClass = "form-control"   Width = "200px"  Text = "是否模板"   runat="server" >
</asp:CheckBox>
</td>
<td>
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