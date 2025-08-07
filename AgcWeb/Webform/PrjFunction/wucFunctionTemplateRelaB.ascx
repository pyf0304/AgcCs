<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFunctionTemplateRelaB.ascx.cs" Inherits="AGC.Webform.wucFunctionTemplateRelaB" %>

<table id="tabwucFunctionTemplateRela" style="width: 700px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFunctionTemplateId" runat="server" Width="60px" CssClass="col-form-label text-right">模板</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFunctionTemplateId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncId4GC" runat="server" CssClass="col-form-label text-right">函数</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFuncId4GC" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
   <tr>
        <td class="NameTD">
            <asp:Label ID="Label3" runat="server" CssClass="col-form-label text-right">序号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtOrderNum" runat="server" class="form-control-sm" Width="600px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" TextMode="MultiLine" Height="116px" Width="381px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
