<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewDgFld.ascx.cs"
    Inherits="AGC.Webform.wucViewDgFld" %>
<table id="tabwucViewFldInfo" cellspacing="1" cellpadding="1" width="344" border="0"
    style="width: 344px; height: 279px">
    <tr>
        <td>
            <asp:Label ID="lblFldID" runat="server">字段ID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlFldID" runat="server" Width="160px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblTabId" runat="server">表</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlTabId" runat="server" Width="160px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCtlTypeId" runat="server">控件类型号</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlCtlTypeId" runat="server" Width="160px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDDLItemsOption" runat="server">下拉框列表项来源选项</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDDLItemsOption" runat="server" Width="160px" AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblItemsString" runat="server">列表项串</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtItemsString" runat="server"></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsTabName" runat="server">数据源表名</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDsTabName" runat="server" Width="160px" AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsDataValueField" runat="server">数据源Value字段名</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDsDataValueField" runat="server" Width="160px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsDataTextField" runat="server">数据源Text字段名</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDsDataTextField" runat="server" Width="160px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsCondStr" runat="server">数据源条件串</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDsCondStr" runat="server"></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsSqlStr" runat="server">数据源SQL串</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDsSqlStr" runat="server"></asp:TextBox>
        </td>
        <td>
            
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsCtlField" runat="server" Text="是否作为控件字段"></asp:CheckBox>
        </td>
        <td>
            <asp:CheckBox ID="chkIsDataGrid" runat="server" Text="是否作为DataGrid字段"></asp:CheckBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsNeedSort" runat="server" Text="是否需要排序"></asp:CheckBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsQuery" runat="server" Text="是否作为查询字段"></asp:CheckBox>
        </td>
        <td>
            <asp:Label ID="lblQueryOption" runat="server">查询方式</asp:Label>
            <asp:DropDownList ID="ddlQueryOption" runat="server" Width="112px">
            </asp:DropDownList></td>
        <td>
        </td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
    <tr>
        <td>
            <asp:Label ID="lblUpdTime" runat="server">生成日期</asp:Label></td>
        <td>
            <asp:TextBox ID="txtUpdTime" runat="server"></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblUserId" runat="server">用户名</asp:Label></td>
        <td>
            <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblViewId" runat="server">界面ID</asp:Label></td>
        <td>
            
                <asp:DropDownList ID="ddlViewId" runat="server">
                </asp:DropDownList></font></td>
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
<p>
</p>
<p>
    &nbsp;</p>
