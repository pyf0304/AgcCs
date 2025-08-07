<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucPrjFuncTemplateRelaB.ascx.cs" Inherits="AGC.Webform.wucPrjFuncTemplateRelaB" %>

<table id="tabwucPrjFuncTemplateRela" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" runat="server" CssClass="col-form-label text-right">工程ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCodeTypeId" runat="server" CssClass="col-form-label text-right">程序分层类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlCodeTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
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
            <asp:Label ID="lblFunctionTemplateId" runat="server" CssClass="col-form-label text-right">函数模板Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFunctionTemplateId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
  
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
