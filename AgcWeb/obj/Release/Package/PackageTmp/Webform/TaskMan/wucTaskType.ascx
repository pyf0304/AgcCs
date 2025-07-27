<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucTaskType.ascx.cs"
    Inherits="AGC.Webform.wucTaskType" %>

<table id="tabwucTaskType" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td>
            <asp:Label ID="lblTaskTypeId" runat="server" >任务类别ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtTaskTypeId" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblTaskTypeName" runat="server" >任务类别名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtTaskTypeName" runat="server" ></asp:TextBox>
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
            <asp:TextBox ID="txtMemo" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
