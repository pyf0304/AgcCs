<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucTabState.ascx.cs"
    Inherits="AGC.Webform.wucTabState" %>

<table id="tabwucTabState" cellspacing="1" cellpadding="1" width="288" border="0"
    style="width: 288px; height: 212px">
    <tr>
        <td>
            <asp:Label ID="lblTabStateId" runat="server" >表状态ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtTabStateId" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblTabStateName" runat="server" >表状态名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtTabStateName" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >说明</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" 
                Width="208px" Height="152px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
