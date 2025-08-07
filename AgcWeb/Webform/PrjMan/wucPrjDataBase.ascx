<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucPrjDataBase.ascx.cs"
    Inherits="AGC.Webform.wucPrjDataBase" %>


<table id="tabwucPrjDataBase"  border="0">
    <tr>
        <td class="style1">
            <asp:Label ID="lblPrjDataBaseId" runat="server" CssClass="col-form-label text-right">项目数据库Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrjDataBaseId" runat="server" class="form-control-sm" Width="160px"></asp:TextBox>
        </td>
        <td class="style2">
            <asp:Label ID="lblPrjDataBaseName" runat="server" CssClass="col-form-label text-right">项目数据库名</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrjDataBaseName" runat="server" class="form-control-sm" Width="160px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style1">
            <asp:Label ID="lblDataBaseTypeId" runat="server" CssClass="col-form-label text-right">数据库类型ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlDataBaseTypeId" runat="server" class="form-control-sm" Width="160px"
                OnSelectedIndexChanged="ddlDataBaseTypeId_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td class="style2">
            <asp:Label ID="lblDatabaseOwner" runat="server" CssClass="col-form-label text-right">数据库拥有者</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDatabaseOwner" runat="server" class="form-control-sm" Width="160px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style1">
            <asp:Label ID="lblDataBaseName" runat="server" CssClass="col-form-label text-right">数据库名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBaseName" runat="server" class="form-control-sm" Width="160px"></asp:TextBox>
        </td>
        <td class="style2">
            <asp:Label ID="lblIpAddress" runat="server" CssClass="col-form-label text-right">服务器</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtIpAddress" runat="server" class="form-control-sm" Width="160px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style1">
            <asp:Label ID="lblDataBaseUserId" runat="server" CssClass="col-form-label text-right">数据库的用户ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBaseUserId" runat="server" class="form-control-sm" Width="160px"></asp:TextBox>
        </td>
        <td class="style2">
            <asp:Label ID="lblDataBasePwd" runat="server" CssClass="col-form-label text-right">数据库的用户口令</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDataBasePwd" runat="server" class="form-control-sm" Width="160px" TextMode="Password"></asp:TextBox>
          <%--  <asp:HiddenField ID="hidDataBasePwd" runat="server" />--%>
        </td>
    </tr>
    <tr id="trOracle" runat="server">
        <td class="style1">
            <asp:Label ID="lblSid" runat="server" CssClass="col-form-label text-right">Sid</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSid" runat="server" class="form-control-sm" Width="160px"></asp:TextBox>
        </td>
        <td class="style2">
            <asp:Label ID="lblTableSpace" runat="server" CssClass="col-form-label text-right">表空间</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtTableSpace" runat="server" class="form-control-sm" Width="160px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style1">
            <asp:Label ID="lblDataBaseUserId0" runat="server" CssClass="col-form-label text-right">使用状态</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUseStateId" runat="server" class="form-control-sm" Width="160px">
            </asp:DropDownList>
        </td>
        <td class="style2">
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td class="style1">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Height="58px" TextMode="MultiLine"
                Width="483px"></asp:TextBox>
        </td>
    </tr>
</table>
