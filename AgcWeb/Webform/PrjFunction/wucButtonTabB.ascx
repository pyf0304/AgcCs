<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucButtonTabB.ascx.cs" Inherits="AGC.Webform.wucButtonTabB" %>
<link rel="stylesheet" type="text/css" href="../../css/tz_base1.css" />
<table id="tabwucButtonTab" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblButtonId" runat="server" CssClass="NameControl">按钮Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtButtonId" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblButtonName" runat="server" CssClass="NameControl">按钮名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtButtonName" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblText" runat="server" CssClass="NameControl">文本</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtText" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblHeight" runat="server" CssClass="NameControl">高度</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtHeight" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_Height" runat="server" CssClass="ErrMsg" ErrorMessage="请输入整型数值!" ControlToValidate="txtHeight"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblWidth" runat="server" CssClass="NameControl">宽</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtWidth" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_Width" runat="server" CssClass="ErrMsg" ErrorMessage="请输入整型数值!" ControlToValidate="txtWidth"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCssClass" runat="server" CssClass="NameControl">样式表</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCssClass" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblImageUrl" runat="server" CssClass="NameControl">图片资源</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtImageUrl" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkInUse" runat="server" Text="是否在用" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblOrderNum" runat="server" CssClass="NameControl">序号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtOrderNum" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_OrderNum" runat="server" CssClass="ErrMsg" ErrorMessage="请输入整型数值!" ControlToValidate="txtOrderNum"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
   
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="NameControl">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
