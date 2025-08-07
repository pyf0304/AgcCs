<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucCMFuncParaRela.ascx.cs" Inherits="AGC.Webform.wucCMFuncParaRela" %>

<table id="tabwucCMFuncParaRela" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncParaId4Code" runat="server" CssClass="col-form-label text-right">参数</asp:Label>
        </td>
        <td class="ValueTD">
                     <asp:DropDownList ID="ddlFuncParaId4Code" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncId4Code" runat="server" CssClass="col-form-label text-right">函数Id4Code</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFuncId4Code" runat="server" class="form-control-sm"></asp:DropDownList>
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

