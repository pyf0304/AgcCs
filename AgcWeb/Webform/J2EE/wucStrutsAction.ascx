<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucStrutsAction.ascx.cs"
    Inherits="AGC.Webform.wucStrutsAction" %>
<table id="tabwucStrutsAction" cellspacing="1" cellpadding="1" width="576" border="0"
    style="width: 576px; height: 272px">
    <tr>
        <td>
            <asp:Label ID="lblActionId" runat="server" >ActionId</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtActionId" runat="server" 
                Width="481px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblActionName" runat="server" >Action名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtActionName" runat="server" 
                Width="481px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblActionParameter" runat="server" >Action参数</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtActionParameter" runat="server" 
                Width="481px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblActionPath" runat="server" >Action路径</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtActionPath" runat="server" 
                Width="481px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblActionScope" runat="server" >Action范围</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtActionScope" runat="server" 
                Width="481px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblActionType" runat="server" >Action类型</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtActionType" runat="server" 
                Width="481px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >说明</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" 
                Height="104px" Width="481px"></asp:TextBox>
        </td>
    </tr>
</table>
