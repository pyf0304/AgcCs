<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucListViewRegion.ascx.cs"
    Inherits="AGC.Webform.wucListViewRegion" %>

<table id="tabwucListViewRegion" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td>
            <asp:Label ID="lblFontName" runat="server" CssClass="text-secondary" >字体</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFontName" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblFontSize" runat="server" CssClass="text-secondary" >字号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFontSize" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsCheck" runat="server"
                Text="是否复选框" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" CssClass="text-secondary" >说明</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblRegionId" runat="server" CssClass="text-secondary" >区域Id</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtRegionId" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblColNum" runat="server" CssClass="text-secondary" >列数</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtColNum" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_ColNum" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtColNum" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="false" CssClass="text-warning"></asp:CompareValidator>
        </td>
        <td>
        </td>
    </tr>
</table>
