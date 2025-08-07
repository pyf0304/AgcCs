<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewDgInfo.ascx.cs"
    Inherits="AGC.Webform.wucViewDgInfo" %>
<table id="tabwucViewDgInfo" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td>
            <asp:Label ID="lblViewDgID" runat="server" >界面DgId</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtViewDgID" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblViewDgName" runat="server" >界面Dg名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtViewDgName" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblViewId" runat="server" >界面ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtViewId" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblSqlDsTypeId" runat="server" >数据源类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlSqlDsTypeId" runat="server" 
                Width="152px" AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblSqlDsId" runat="server" >数据源表/视图Id</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlSqlDsId" runat="server" 
                Width="159px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDgStyleId" runat="server" >DG模式ID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDgStyleId" runat="server" 
                Width="159px">
            </asp:DropDownList>
        </td>
        <td>
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
                EnableClientScript="false"></asp:CompareValidator>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblHeight" runat="server" >高度</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtHeight" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_Height" runat="server" 
                ErrorMessage="请输入整型数值!" ControlToValidate="txtHeight" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="false"></asp:CompareValidator>
        </td>
        <td>
        </td>
    </tr>
</table>
