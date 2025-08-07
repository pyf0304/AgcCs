<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucActionFormType.ascx.cs"
    Inherits="AGC.Webform.wucActionFormType" %>
<table id="tabwucActionFormType" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td>
            <asp:Label ID="lblActionFormTypeId" runat="server" >ActionForm类型ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtActionFormTypeId" runat="server" 
                Width="454px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblActionFormTypeName" runat="server" >ActionForm类型名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtActionFormTypeName" runat="server" 
                Width="454px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblFormBeanClass" runat="server" >FormBean类名</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFormBeanClass" runat="server" 
                Width="454px"></asp:TextBox>
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
                Width="454px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
