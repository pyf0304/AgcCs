
<%@ Control Language = "C#" AutoEventWireup = "true" CodeBehind = "wucwf_Point.ascx.cs" Inherits = "AGC.Webform.wucwf_Point" %>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabwucwf_Point" name="tabwucwf_Point" style="width: 600px; padding: 1px; border:0px" class="table table-bordered table-hover">
<tr>
<td class="NameTD">
<asp:Label id="lblPointId" name="lblPointId" CssClass="col-form-label text-right" Width="90px" Text="结点Id" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtPointId" name="txtPointId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblPointName" name="lblPointName" CssClass="col-form-label text-right" Width="90px" Text="结点名称" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtPointName" name="txtPointName" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblPrjId" name="lblPrjId" CssClass="col-form-label text-right" Width="90px" Text="工程ID" runat="server" />
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlPrjId" name="ddlPrjId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblTabName" name="lblTabName" CssClass="col-form-label text-right" Width="90px" Text="表名" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtTabName" name="txtTabName" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblTabKeyId" name="lblTabKeyId" CssClass="col-form-label text-right" Width="90px" Text="表关键字Id" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtTabKeyId" name="txtTabKeyId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblUpdDate" name="lblUpdDate" CssClass="col-form-label text-right" Width="90px" Text="修改日期" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtUpdDate" name="txtUpdDate" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblUpdUser" name="lblUpdUser" CssClass="col-form-label text-right" Width="90px" Text="修改者" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtUpdUser" name="txtUpdUser" CssClass="form-control" Width="200px" runat="server" />
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