<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucEditRegion.ascx.cs"
    Inherits="AGC.Webform.wucEditRegion" %>

<table id="tabwucEditRegion" cellspacing="1" cellpadding="1" width="600" border="0">
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
    <tr>
        <td>
            <asp:CheckBox ID="chkIsUseCtrl" runat="server"
                Text="是否使用控件" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
