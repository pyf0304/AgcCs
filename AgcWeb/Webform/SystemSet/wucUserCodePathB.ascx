<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucUserCodePathB.ascx.cs" Inherits="AGC.Webform.wucUserCodePathB" %>


<table id="tabwucUserCodePath" style="width: 796px; padding: 1px;" border="0">
   
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserCodePrjMainPathId" runat="server" CssClass="col-form-label text-right">用户生成项目主路径</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUserCodePrjMainPathId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCodeTypeId" runat="server" CssClass="col-form-label text-right">代码类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlCodeTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
   
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCodePath" runat="server" CssClass="col-form-label text-right">代码路径</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCodePath" runat="server" class="form-control-sm" Height="49px" TextMode="MultiLine" Width="500px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCodePathBackup" runat="server" CssClass="col-form-label text-right">备份代码路径</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCodePathBackup" runat="server" class="form-control-sm" Height="41px" TextMode="MultiLine" Width="500px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="chkIsTemplate" runat="server" Text="是否模板" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
    </tr>
  
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Height="41px" TextMode="MultiLine" Width="500px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
