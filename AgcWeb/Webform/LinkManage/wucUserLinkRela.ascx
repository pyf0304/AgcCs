<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucUserLinkRela.ascx.cs"
    Inherits="AGC.wucUserLinkRela" %>



<table id="tabwucUserLinkRela" cellspacing="1" cellpadding="1" width="831" border="0"
    style="height: 242px">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataBaseTypeId" CssClass="col-form-label text-right" 
                runat="server">数据库类型ID</asp:Label></td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlDataBaseTypeId" class="form-control-sm"
                 runat="server" Width="158px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataBaseName" CssClass="col-form-label text-right" 
                runat="server">数据库名</asp:Label></td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBaseName" class="form-control-sm" 
                runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataBaseUserId" CssClass="col-form-label text-right" 
                runat="server">数据库的用户ID</asp:Label></td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBaseUserId" class="form-control-sm"
                 runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataBasePwd" CssClass="col-form-label text-right" 
                runat="server">数据库的用户口令</asp:Label></td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBasePwd" class="form-control-sm" 
                runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblIpAddress" CssClass="col-form-label text-right" 
                runat="server">服务器</asp:Label></td>
        <td class="ValueTD">
            <asp:TextBox ID="txtIpAddress" class="form-control-sm" 
                runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSid" CssClass="col-form-label text-right" 
                runat="server">Sid</asp:Label></td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSid" class="form-control-sm" 
                runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblLinkName" CssClass="col-form-label text-right" 
                runat="server">连接名称</asp:Label></td>
        <td class="ValueTD">
            <asp:TextBox ID="txtLinkName" class="form-control-sm" 
                runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblConnectionString" CssClass="col-form-label text-right" 
                runat="server">连接串</asp:Label></td>
        <td class="ValueTD">
            <asp:TextBox ID="txtConnectionString" class="form-control-sm"
                 runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" CssClass="col-form-label text-right" 
                runat="server">说明</asp:Label></td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" class="form-control-sm" 
                runat="server"></asp:TextBox></td>
    </tr>
</table>
