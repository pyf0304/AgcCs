<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucCharEncodingB.ascx.cs" Inherits="AGC.Webform.wucCharEncodingB" %>

<table id="tabwucCharEncoding" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCharEncodingId" runat="server" CssClass="col-form-label text-right">×Ö·û±àÂë</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCharEncodingId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCharEncodingName" runat="server" CssClass="col-form-label text-right">×Ö·û±àÂëÃû³Æ</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCharEncodingName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsDefault" runat="server" Text="ÊÇ·ñÄ¬ÈÏ" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">ËµÃ÷</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
