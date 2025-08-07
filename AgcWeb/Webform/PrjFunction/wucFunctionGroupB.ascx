<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFunctionGroupB.ascx.cs" Inherits="AGC.Webform.wucFunctionGroupB" %>

<table id="tabwucFunctionGroup" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFunctionGroupId" runat="server" CssClass="col-form-label text-right">函数组Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFunctionGroupId" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFunctionGroupName" runat="server" CssClass="col-form-label text-right">函数组名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFunctionGroupName" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblProgLangTypeId" runat="server" CssClass="col-form-label text-right">编程语言类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlProgLangTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCreateUserId" runat="server" CssClass="col-form-label text-right">建立用户Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCreateUserId" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
