<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucCMUserProject.ascx.cs" Inherits="AGC.Webform.wucCMUserProject" %>
<table id="tabwucCMUserProject" name="tabwucCMUserProject" style="width: 600px; padding: 1px; border: 0px" class="table table-bordered table-hover">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserId" name="lblUserId" CssClass="col-form-label text-right" Width="90px" Text="用户Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUserId" name="ddlUserId" CssClass="form-control-sm" Width="600px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCmPrjId" name="lblCmPrjId" CssClass="col-form-label text-right" Width="90px" Text="CM工程Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlCmPrjId" name="ddlCmPrjId" CssClass="form-control-sm" Width="600px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblProjectPath" name="lblProjectPath" CssClass="col-form-label text-right" Width="90px" Text="工程路径" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtProjectPath" name="txtProjectPath" CssClass="form-control-sm" Width="600px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" name="txtMemo" CssClass="form-control-sm" Width="600px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
