<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucSelfDefDataTypeB.ascx.cs" Inherits="AGC.Webform.wucSelfDefDataTypeB" %>

<table id="tabwucSelfDefDataType" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSDDataTypeId" runat="server" CssClass="col-form-label text-right">自定义数据类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSDDataTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataTypeName" runat="server" CssClass="col-form-label text-right">数据类型名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataTypeName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsObject" runat="server" Text="是否对象" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDefaVarName" runat="server" CssClass="col-form-label text-right">默认变量名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDefaVarName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataCnName" runat="server" CssClass="col-form-label text-right">数据类型中文名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataCnName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataTypeAbbr" runat="server" CssClass="col-form-label text-right">数据类型缩写</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataTypeAbbr" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblVBNETType" runat="server" CssClass="col-form-label text-right">VBNET类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtVBNETType" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCSType" runat="server" CssClass="col-form-label text-right">CS类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCSType" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblJavaType" runat="server" CssClass="col-form-label text-right">JAVA类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtJavaType" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblJavaObjType" runat="server" CssClass="col-form-label text-right">JAVA对象类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtJavaObjType" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSwiftType" runat="server" CssClass="col-form-label text-right">SwiftType</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSwiftType" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblOraDbType" runat="server" CssClass="col-form-label text-right">Ora数据类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtOraDbType" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSqlParaType" runat="server" CssClass="col-form-label text-right">SQL参数类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSqlParaType" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMySqlType" runat="server" CssClass="col-form-label text-right">MySqlType</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMySqlType" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" runat="server" CssClass="col-form-label text-right">工程ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
