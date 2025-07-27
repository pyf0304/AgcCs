<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucLabelStyle.ascx.cs"
    Inherits="AGC.Webform.wucLabelStyle" %>
<table id="tabwucLabelStyle" cellspacing="1" cellpadding="1" width="368" border="0"
    style="width: 368px; height: 325px">
    <tr>
        <td>
            <asp:Label ID="lblLabelStyleId" runat="server" >模式ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtLabelStyleId" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblLabelStyleName" runat="server" >模式名</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtLabelStyleName" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblStyle" runat="server" >类型</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtStyle" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblRunat" runat="server" >运行在</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtRunat" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblFontSize" runat="server" >字体大小</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFontSize" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblFontName" runat="server" >字体名</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFontName" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblWidth" runat="server" >宽</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtWidth" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_Width" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtWidth" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="False"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblHeight" runat="server" >高</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtHeight" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_Height" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtHeight" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="False"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblStyleZindex" runat="server" >StyleZindex</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtStyleZindex" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_StyleZindex" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtStyleZindex"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="False"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblStyleLeft" runat="server" >StyleLeft</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtStyleLeft" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_StyleLeft" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtStyleLeft"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="False"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblStylePosition" runat="server" >StylePosition</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtStylePosition" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblStyleTop" runat="server" >StyleTop</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtStyleTop" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_StyleTop" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtStyleTop"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="False"></asp:CompareValidator>
        </td>
    </tr>
</table>
