<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucCtlType.ascx.cs"
    Inherits="AGC.Webform.wucCtlTypeAbbr" %>
<table id="tabwucCtlTypeAbbr" cellspacing="1" cellpadding="1" width="376" border="0"
    style="width: 376px; height: 306px">
    <tr>
        <td>
            <asp:Label ID="lblCtlTypeId" runat="server" >控件类型ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtCtlTypeId" runat="server" Width="280px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCtlTypeName" runat="server" >类型名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtCtlTypeName" runat="server" Width="280px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCtlCnName" runat="server" >控件中文名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtCtlCnName" runat="server" Width="280px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCtlTypeAbbr" runat="server" >控件类型缩写</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtCtlTypeAbbr" runat="server" Width="280px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td valign="top">
            <asp:Label ID="lblMemo" runat="server" >备注</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" Width="280px" Height="192px"></asp:TextBox>
        </td>
    </tr>
</table>
