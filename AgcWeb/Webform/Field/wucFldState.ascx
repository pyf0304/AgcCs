<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucFldState.ascx.cs"
    Inherits="AGC.Webform.wucFldState" %>
<table id="tabwucFldState" cellspacing="1" cellpadding="1" width="312" border="0"
    style="width: 312px; height: 228px">
    <tr>
        <td>
            <asp:Label ID="lblFldStateId" runat="server" >×Ö¶Î×´Ì¬Id</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFldStateId" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblFldStateName" runat="server" >×Ö¶Î×´Ì¬Ãû</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFldStateName" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >ËµÃ÷</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" 
                Width="233px" Height="168px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
