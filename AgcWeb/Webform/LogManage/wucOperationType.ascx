<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucOperationType.ascx.cs"
    Inherits="AGC.wucOperationType" %>
<table id="tabwucOperationType" cellspacing="1" cellpadding="1" width="480" border="0"
    style="width: 480px; height: 55px">
    <tr>
        <td>
            <asp:Label ID="lblOpType" runat="server" >操作类型Id</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtOpTypeId" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblOpTypeName" runat="server" >操作类型名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtOpTypeName" runat="server" ></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >备注</asp:Label>
        </td>
        <td colspan="3">
            <asp:TextBox ID="txtMemo" runat="server" 
                Width="400px" Height="104px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
