<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucListViewRegionFlds.ascx.cs"
    Inherits="AGC.Webform.wucListViewRegionFlds" %>
<table id="tabwucListViewRegionFlds" cellspacing="1" cellpadding="1" width="600"
    border="0">
    <tr>
        <td>
            <asp:Label ID="lblTabFldId" runat="server" >表字段</asp:Label>
        </td>
        <td>
            <asp:Label ID="lblFldName" runat="server"></asp:Label>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblColCaption" runat="server" >列标题</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtColCaption" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblColIndex" runat="server" >列序号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtColIndex" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_ColIndex" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtColIndex" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="false"></asp:CompareValidator>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsNeedSort" runat="server"
                Text="是否需要排序"></asp:CheckBox>
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
            <asp:CheckBox ID="chkIsTransToChkBox" runat="server"
                Text="是否转换成CheckBox"></asp:CheckBox>
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
            <asp:CheckBox ID="chkIsVisible" runat="server"
                Text="是否显示"></asp:CheckBox>
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
            <asp:Label ID="lblMemo" runat="server" >说明</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
    <tr>
        <td>
        </td>
        <td>
            <asp:TextBox ID="txtTabFldId" runat="server"></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
