<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucActionForward.ascx.cs"
    Inherits="AGC.Webform.wucActionForward" %>
<table id="tabwucActionForward" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td>
            <asp:Label ID="lblForwardName" runat="server" >ForwardÃû³Æ</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtForwardName" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblForwardPath" runat="server" >ForwardÂ·¾¶</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtForwardPath" runat="server" 
                Width="254px"></asp:TextBox></td>
    </tr>
</table>
