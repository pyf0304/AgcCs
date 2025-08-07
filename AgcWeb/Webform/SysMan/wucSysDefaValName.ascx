<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucSysDefaValName.ascx.cs"
    Inherits="AGC.Webform.wucSysDefaValName" %>

<table id="tabwucSysDefaValName" cellspacing="1" cellpadding="1" width="256" border="0"
    style="width: 256px; height: 109px">
    <tr>
        <td class="NameTD" style="width: 103px">
            <asp:Label ID="lblDefaValNameId" runat="server">缺省值编号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDefaValNameId" runat="server"
                Width="160px" CssClass="ValueTD"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 103px">
            <asp:Label ID="lblPrjId" runat="server">项目名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrjIdSet" runat="server" ReadOnly="True" 
                 Width="160px" CssClass="ValueTD"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 103px">
            <asp:Label ID="lblDefaValName" runat="server">缺省值名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDefaValName" runat="server"
                Width="160px" CssClass="ValueTD"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 103px">
            <asp:Label ID="lblSysDefaValue" runat="server">系统缺省值</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtSysDefaValue" runat="server" Width="160px" 
                 CssClass="ValueTD"></asp:TextBox>
        </td>
    </tr>
</table>
<asp:DropDownList ID="ddlPrjId" runat="server" Width="72px" Visible="False">
</asp:DropDownList>
