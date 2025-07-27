<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucINOUTType.ascx.cs"
    Inherits="AGC.Webform.wucINOUTType" %>

<table id="tabwucINOUTType" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td>
            <asp:Label ID="lblInOutTypeId" runat="server" >输入输出类型ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtInOutTypeId" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblInOutTypeName" runat="server" Width="110px" >输入输出类型名称</asp:Label></td>
        <td>
            <asp:TextBox ID="txtInOutTypeName" runat="server" ></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >说明</asp:Label>
        </td>
        <td colspan="3">
            <asp:TextBox ID="txtMemo" runat="server" Height="95px" TextMode="MultiLine" Width="467px" ></asp:TextBox>
        </td>
    </tr>
</table>
