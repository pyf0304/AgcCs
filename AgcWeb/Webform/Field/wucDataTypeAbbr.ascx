<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucDataTypeAbbr.ascx.cs"
    Inherits="AGC.Webform.wucDataTypeAbbr" %>

<table id="tabwucDataTypeAbbr" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td>
            <asp:Label ID="lblDataTypeId" runat="server" CssClass="text-secondary" >数据类型ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDataTypeId" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDataTypeName" runat="server" CssClass="text-secondary" >DataTypeName</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDataTypeName" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDataCnName" runat="server" CssClass="text-secondary" >数据类型中文名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDataCnName" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDataTypeAbbr" runat="server" CssClass="text-secondary" >数据类型缩写</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDataTypeAbbr" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblNetSysType" runat="server" CssClass="text-secondary" >NET系统类型</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtNetSysType" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblVBNETType" runat="server" CssClass="text-secondary" >VBNET类型</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtVBNETType" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCSType" runat="server" CssClass="text-secondary" >CS类型</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtCSType" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblJavaType" runat="server" CssClass="text-secondary" >JAVA类型</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtJavaType" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" CssClass="text-secondary">Ora数据类型</asp:Label></td>
        <td>
            <asp:TextBox ID="txtOraDbType" runat="server"></asp:TextBox></td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" CssClass="text-secondary">Sql参数类型</asp:Label></td>
        <td>
            <asp:TextBox ID="txtSqlParaType" runat="server"></asp:TextBox></td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsNeedQuote" runat="server" 
                Text="是否需要引号" CssClass="text-secondary"></asp:CheckBox>
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
</table>
