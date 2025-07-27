<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucDataGridStyle.ascx.cs"
    Inherits="AGC.Webform.wucDataGridStyle" %>
<table id="tabwucDataGridStyle" cellspacing="1" cellpadding="1" width="608" border="0"
    style="width: 608px; height: 312px">
    <tr>
        <td>
            <asp:Label ID="lblDgStyleId" runat="server" >DG模式ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDgStyleId" runat="server" ></asp:TextBox>
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
            <asp:Label ID="lblDgStyleName" runat="server" >DG模式名</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDgStyleName" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblRunat" runat="server" >运行在</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtRunat" runat="server" ></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblFontSize" runat="server" >字号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFontSize" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblFontName" runat="server" >字体</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFontName" runat="server" ></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkAllowPaging" runat="server" 
                Text="允许分页"></asp:CheckBox>
        </td>
        <td>
        </td>
        <td>
            <asp:Label ID="lblPageSize" runat="server" >页大小</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPageSize" runat="server" ></asp:TextBox></td>
        <td>
            <asp:CompareValidator ID="ComValid_PageSize" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtPageSize" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="false"></asp:CompareValidator></td>
    </tr>
    <tr>
        <td colspan="2" rowspan="1">
            <asp:CheckBox ID="chkAutoGenerateColumns" runat="server" 
                Text="自动生成列"></asp:CheckBox>
        </td>
        <td colspan="2" rowspan="1">
            <asp:CheckBox ID="chkAllowSorting" runat="server" 
                Text="允许排序"></asp:CheckBox>
        </td>
        <td>
            
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="chkIsJumpPage" runat="server" 
                Text="是否跳页"></asp:CheckBox></td>
        <td colspan="2">
        </td>
        <td>
            
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="chkIsRadio" runat="server" 
                Text="是否单选框"></asp:CheckBox>
        </td>
        <td colspan="2" rowspan="1">
            
                <asp:CheckBox ID="chkIsCheck" runat="server" 
                    Text="是否复选框"></asp:CheckBox>
        </td>
        <td>
            
        </td>
    </tr>
    <tr>
        <td colspan="2">
            
                <asp:CheckBox ID="chkIsHaveUpdBtn" runat="server" 
                    Text="是否有修改按钮"></asp:CheckBox></td>
        <td colspan="2">
            <asp:CheckBox ID="chkIsHaveDelBtn" runat="server" 
                Text="是否有删除按钮"></asp:CheckBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="chkIsHaveDetailBtn" runat="server" 
                Text="是否有详细按钮"></asp:CheckBox></td>
        <td colspan="2">
            <asp:CheckBox ID="chkIsInTab" runat="server" 
                Text="是否生成DG在表中"></asp:CheckBox></td>
        <td>
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
            <asp:Label ID="lblStyleLeft" runat="server" >StyleLeft</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtStyleLeft" runat="server" ></asp:TextBox></td>
        <td>
            <asp:CompareValidator ID="ComValid_StyleZindex" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtStyleZindex"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false"></asp:CompareValidator>
            <asp:CompareValidator ID="ComValid_StyleLeft" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtStyleLeft"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false"></asp:CompareValidator></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblStylePosition" runat="server" >StylePosition</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtStylePosition" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblStyleTop" runat="server" >StyleTop</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtStyleTop" runat="server" ></asp:TextBox></td>
        <td>
            <asp:CompareValidator ID="ComValid_StyleTop" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtStyleTop"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false"></asp:CompareValidator></td>
    </tr>
    <tr>
        <td style="height: 8px">
            <asp:Label ID="lblWidth" runat="server" >宽</asp:Label>
        </td>
        <td style="height: 8px">
            <asp:TextBox ID="txtWidth" runat="server" ></asp:TextBox>
        </td>
        <td style="height: 8px">
            <asp:Label ID="lblHeight" runat="server" >高度</asp:Label>
        </td>
        <td style="height: 8px">
            <asp:TextBox ID="txtHeight" runat="server" ></asp:TextBox></td>
        <td style="height: 8px">
            <asp:CompareValidator ID="ComValid_Width" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtWidth" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="false"></asp:CompareValidator>
            <asp:CompareValidator ID="ComValid_Height" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtHeight" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="false"></asp:CompareValidator></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblStyle" runat="server" >类型</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtStyle" runat="server" ></asp:TextBox>
        </td>
        <td colspan="2">
            <asp:CheckBox ID="chkIsDefault"  runat="server"
                Text="是否默认标题模式"></asp:CheckBox>
        </td>
        <td>
            
        </td>
    </tr>
</table>
