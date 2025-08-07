<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucJavaType.ascx.cs"
    Inherits="AGC.Webform.wucJavaType" %>
<table id="tabwucJavaType" cellspacing="1" cellpadding="1" width="344" border="0"
    style="width: 344px; height: 82px">
    <tr>
        <td>
            <asp:Label ID="lblJavaTypeId" runat="server" >Java类型Id</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtJavaTypeId" runat="server" 
                Width="248px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblJavaTypeName" runat="server" >Java类型名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtJavaTypeName" runat="server" 
                Width="248px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >说明</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" 
                Width="250px" Height="120px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
