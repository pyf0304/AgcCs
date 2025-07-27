<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucQryRegionFldsB.ascx.cs" Inherits="AGC.Webform.wucQryRegionFldsB" %>
<link rel="stylesheet" type="text/css" href="../../css/tz_base1.css" />
<table id="tabwucQryRegionFlds" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblRegionId" runat="server" CssClass="NameControl">区域Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtRegionId" runat="server" CssClass="ValueControl"></asp:TextBox>
            1</td>
        <td>
            <asp:CompareValidator ID="ComValid_RegionId" runat="server" CssClass="ErrMsg" ErrorMessage="请输入整型数值!" ControlToValidate="txtRegionId"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabFldId" runat="server" CssClass="NameControl">表字段ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabFldId" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_TabFldId" runat="server" CssClass="ErrMsg" ErrorMessage="请输入整型数值!" ControlToValidate="txtTabFldId"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCtlTypeId" runat="server" CssClass="NameControl">控件类型号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlCtlTypeId" runat="server" CssClass="ValueControl"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDS_TabId" runat="server" CssClass="NameControl">数据源表ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlDS_TabId" runat="server" CssClass="ValueControl"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblQueryOptionId" runat="server" CssClass="NameControl">查询方式Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlQueryOptionId" runat="server" CssClass="ValueControl"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDDLItemsOptionId" runat="server" CssClass="NameControl">下拉框列表选项ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlDDLItemsOptionId" runat="server" CssClass="ValueControl"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDS_SQLStr" runat="server" CssClass="NameControl">数据源SQL串</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDS_SQLStr" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDS_DataTextFieldId" runat="server" CssClass="NameControl">数据源文本字段Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlDS_DataTextFieldId" runat="server" CssClass="ValueControl"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDS_DataValueFieldId" runat="server" CssClass="NameControl">数据源值字段Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlDS_DataValueFieldId" runat="server" CssClass="ValueControl"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblItemsString" runat="server" CssClass="NameControl">列表项串</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtItemsString" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDS_CondStr" runat="server" CssClass="NameControl">数据源条件串</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDS_CondStr" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSeqNum" runat="server" CssClass="NameControl">字段序号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSeqNum" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_SeqNum" runat="server" CssClass="ErrMsg" ErrorMessage="请输入整型数值!" ControlToValidate="txtSeqNum"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserId" runat="server" CssClass="NameControl">用户ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUserId" runat="server" CssClass="ValueControl"></asp:DropDownList>
        </td>
        <td></td>
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
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUpdDate" runat="server" CssClass="NameControl">修改日期</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtUpdDate" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
