<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucTaskStatus.ascx.cs"
    Inherits="AGC.Webform.wucTaskStatus" %>

<table id="tabwucTaskStatus" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td>
            <asp:Label ID="lblStateId" runat="server" >×´Ì¬ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtStateId" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblTaskStateName" runat="server" >×´Ì¬Ãû³Æ</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtTaskStateName" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >ËµÃ÷</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
