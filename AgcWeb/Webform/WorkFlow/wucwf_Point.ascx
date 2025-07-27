<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucwf_Point.ascx.cs" Inherits="AGC.Webform.wucwf_Point" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabwucwf_Point" name="tabwucwf_Point" style="width: 600px; padding: 1px; border: 0px" class="table table-bordered table-hover">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPointId" name="lblPointId" CssClass="col-form-label text-right" Width="90px" Text="结点Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPointId" name="txtPointId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPointName" name="lblPointName" CssClass="col-form-label text-right" Width="90px" Text="结点名称" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPointName" name="txtPointName" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" name="lblPrjId" CssClass="col-form-label text-right" Width="90px" Text="工程ID" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" name="ddlPrjId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabName" name="lblTabName" CssClass="col-form-label text-right" Width="90px" Text="表名" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabName" name="txtTabName" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabKeyId" name="lblTabKeyId" CssClass="col-form-label text-right" Width="90px" Text="表关键字Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabKeyId" name="txtTabKeyId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
   
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" name="txtMemo" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
