<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucActionForm.ascx.cs"
    Inherits="AGC.Webform.wucActionForm" %>
<table id="tabwucActionForm" cellspacing="1" cellpadding="1" width="664" border="0"
    style="width: 664px; height: 191px">
    <tr>
        <td style="width: 142px">
            <asp:Label ID="lblActionFormId" runat="server" >ActionFormId</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtActionFormId" runat="server" 
                Width="550px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 142px">
            <asp:Label ID="lblActionFormName" runat="server" >ActionForm名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtActionFormName" runat="server" 
                Width="550px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 142px">
            <asp:Label ID="lblActionFormTypeId" runat="server" >ActionForm类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlActionFormTypeId" runat="server" 
                Width="550px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="width: 142px">
            <asp:Label ID="lblMemo" runat="server" >说明</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" 
                Width="550px" Height="88px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
