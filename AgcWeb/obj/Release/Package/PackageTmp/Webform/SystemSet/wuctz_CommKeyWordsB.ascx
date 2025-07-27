<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wuctz_CommKeyWordsB.ascx.cs" Inherits="AGC.Webform.wuctz_CommKeyWordsB" %>

<table id="tabwuctz_CommKeyWords" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblKeyword" runat="server" CssClass="col-form-label text-right">关键字</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtKeyword" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTableName" runat="server" CssClass="col-form-label text-right">数据表名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTableName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTableKey" runat="server" CssClass="col-form-label text-right">数据表关键字值</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTableKey" runat="server" class="form-control-sm"></asp:TextBox>
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
