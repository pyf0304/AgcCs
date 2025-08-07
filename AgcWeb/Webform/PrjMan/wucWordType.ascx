<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucWordType.ascx.cs"
    Inherits="AGC.Webform.wucWordType" %>
<table id="tabwucWordType" cellspacing="1" cellpadding="1" width="312" border="0"
    style="width: 312px; height: 82px">
    <tr>
        <td>
            <asp:Label ID="lblWordTypeId" runat="server" >单词分类ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtWordTypeId" runat="server" 
                Width="209px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblWordTypeName" runat="server" >单词分类名</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtWordTypeName" runat="server" 
                Width="208px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >说明</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" 
                Width="229px" Height="128px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
