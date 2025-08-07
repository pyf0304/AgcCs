<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucTitleStyle.ascx.cs"
    Inherits="AGC.Webform.wucTitleStyle" %>
<table id="tabwucTitleStyle" cellspacing="1" cellpadding="1" width="616" border="0"
    style="width: 616px; height: 187px">
    <tr>
        <td>
            <asp:Label ID="lblTitleStyleId" runat="server" 
                Width="72px">标题类型Id</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtTitleStyleId" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblTitleStyleName" runat="server" >标题类型名</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtTitleStyleName" runat="server" ></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblTitleTypeId" runat="server" >标题类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlTitleTypeId" runat="server" 
                Width="160px">
            </asp:DropDownList>
        </td>
        <td>
            <asp:Label ID="lblPrjId" runat="server" >工程ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrjId" runat="server" 
                ReadOnly="True"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblImgFile" runat="server" >图像文件</asp:Label>
        </td>
        <td colspan="3">
            <asp:TextBox ID="txtImgFile" runat="server" 
                Width="456px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblTabHeight" runat="server" >表格高度</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtTabHeight" runat="server" ></asp:TextBox>
            <asp:CompareValidator ID="ComValid_TabHeight" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtTabHeight"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false"></asp:CompareValidator>
        </td>
        <td>
            <asp:Label ID="lblTabWidth" runat="server" >表格宽度</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtTabWidth" runat="server" ></asp:TextBox>
            <asp:CompareValidator ID="ComValid_TabWidth" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtTabWidth" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="false"></asp:CompareValidator></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblBackColor" runat="server" >背景颜色</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtBackColor" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblForeColor" runat="server" >前景颜色</asp:Label>
        </td>
        <td>
            
                <asp:TextBox ID="txtForeColor" runat="server" ></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblFontSize" runat="server" >FontSize</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFontSize" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblFontName" runat="server" >FontName</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFontName" runat="server" ></asp:TextBox></td>
    </tr>
    <tr>
        <td colspan="2">
            
                <asp:CheckBox ID="chkIsDefault"  runat="server"
                    Text="是否默认标题模式"></asp:CheckBox></td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
