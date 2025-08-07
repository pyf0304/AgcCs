<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucActionFormPropertys.ascx.cs"
    Inherits="AGC.wucActionFormPropertys" %>
<table id="tabwucActionFormPropertys" cellspacing="1" cellpadding="1" width="360"
    border="0" style="width: 360px; height: 170px">
    <tr>
        <td>
            <asp:Label ID="lblPropertyName" runat="server" >属性名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPropertyName" runat="server" 
                Width="264px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblJavaTypeId" runat="server" >Java类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlJavaTypeId" runat="server" 
                Width="264px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >说明</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" 
                Width="264px" Height="112px" TextMode="MultiLine"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
