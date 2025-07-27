<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucPrjTab4Disp.ascx.cs" Inherits="AGC.Webform.wucPrjTab4Disp" %>
<style type="text/css">
    .myNameTD {
        text-align: right;
    }

    .myValueTD {
        text-align: left;
    }
</style>
<table id="tabwucPrjTab" border="0">
    <tr>
        <td class="myNameTD">
            <asp:Label ID="lblTabName" runat="server">表名*</asp:Label>
        </td>
        <td class="myValueTD">
            <asp:TextBox ID="txtTabName" runat="server" Width="236px"></asp:TextBox>
            <input id="btnQueryTab" type="button" value="查询表" class="btn btn-info btn-sm" onclick="return getPrjTab();" /></td>

    </tr>
    <tr>
        <td class="myNameTD">
            <asp:Label ID="Label1" runat="server">表中文名*</asp:Label>
        </td>
        <td class="myValueTD">
            <asp:TextBox ID="txtTabCnName" runat="server" Width="300px"></asp:TextBox>
        </td>

    </tr>

    <tr>
        <td class="myNameTD">
            <asp:Label ID="Label2" runat="server">数据源类型*</asp:Label>
        </td>
        <td class="myValueTD">
            <asp:DropDownList ID="ddlSqlDsTypeId" runat="server" Width="300px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="myNameTD">
            <asp:Label ID="lblRelaTabId4View" runat="server">视图相关主表名</asp:Label>
        </td>
        <td class="myValueTD">
            <asp:DropDownList ID="ddlRelaTabId4View" runat="server" Width="300px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="height: 24px" class="myNameTD">
            <asp:Label ID="lblFuncModuleId" runat="server">功能模块*</asp:Label>
        </td>
        <td class="myValueTD">
            <asp:DropDownList ID="ddlFuncModuleId" runat="server" Width="300px">
            </asp:DropDownList>
        </td>
    </tr>

    <tr>
        <td class="myNameTD">
            <asp:Label ID="lblTabStateId" runat="server">表状态*</asp:Label></td>
        <td class="myValueTD">
            <asp:DropDownList ID="ddlTabStateId" runat="server" Width="300px"
                CssClass="nice">
            </asp:DropDownList></td>

    </tr>
    <tr>
        <td class="myNameTD">

            <asp:Label ID="lblTabStateId0" runat="server">表类型</asp:Label></td>
        <td class="myValueTD">
            <asp:DropDownList ID="ddlTabTypeId" runat="server" Width="300px"
                CssClass="nice">
            </asp:DropDownList></td>

    </tr>


    <tr>
        <td class="myNameTD">
            <asp:Label ID="Label6" runat="server">Sql表相关？</asp:Label>
        </td>
        <td class="myValueTD">
            <asp:CheckBox ID="chkIsReleToSqlTab" runat="server" Text="该表是否与Sql表相关"
                CssClass="text-secondary"></asp:CheckBox></td>

    </tr>
    <tr>
        <td class="myNameTD">
            <asp:Label ID="Label7" runat="server">支持Cache？</asp:Label>
        </td>
        <td class="myValueTD">
            <asp:CheckBox ID="chkIsUseCache" runat="server" Text="该表是否支持Cache"
                CssClass="text-secondary"></asp:CheckBox></td>

    </tr>
    <tr>
        <td class="myNameTD">

            <asp:Label ID="Label8" runat="server">缓存分类字段</asp:Label></td>
        <td class="myValueTD">
            <asp:DropDownList ID="ddlCacheClassifyField" runat="server" Width="300px"
                CssClass="nice">
            </asp:DropDownList></td>

    </tr>
    <tr>
        <td class="myNameTD">
            <asp:Label ID="Label5" runat="server">父类</asp:Label>
        </td>
        <td colspan="1" class="myValueTD">
            <asp:TextBox ID="txtParentClass" runat="server" Width="300px" TextMode="SingleLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="myNameTD">
            <asp:Label ID="lblMemo" runat="server">说明</asp:Label>
        </td>
        <td colspan="1" class="myValueTD">
            <asp:TextBox ID="txtMemo" runat="server" Width="300px" TextMode="MultiLine" Height="49px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="myNameTD">
            <asp:Label ID="lblTabId" runat="server" CssClass="text-secondary">表编号</asp:Label>
        </td>
        <td colspan="1" class="myValueTD">
            <asp:TextBox ID="txtTabId" runat="server" Width="156" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataBaseName" runat="server" Width="148px">数据库名称(表空间)</asp:Label>
        </td>
        <td colspan="1" class="myValueTD">
            <asp:TextBox ID="txtDataBaseName" runat="server" Width="300px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="myNameTD" nowrap="nowrap">
            <asp:Label ID="Label4" runat="server">拥有者</asp:Label></td>
        <td class="myValueTD">
            <asp:TextBox ID="txtOwner" runat="server" Width="300px"></asp:TextBox></td>

    </tr>
    <tr>
        <td class="myNameTD" nowrap>
            <asp:Label ID="Label3" runat="server">教育部国标表</asp:Label>
        </td>
        <td class="myValueTD">
            <asp:CheckBox ID="chkIsNationStandard" runat="server" Text="该表是否是教育部国标表" CssClass="text-secondary"></asp:CheckBox></td>

    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="280" border="1" runat="server"
    style="width: 280px; height: 78px">
    <tr>
        <td>
            <asp:Label ID="lblPrjId" runat="server">工程编号</asp:Label></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblTabNameB" runat="server">表名_后备</asp:Label></td>
        <td>
            <asp:TextBox ID="txtTabNameB" runat="server" Width="156px" ReadOnly="True"></asp:TextBox></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsChecked" runat="server" Text="该表是否核实" Enabled="False"></asp:CheckBox></td>
        <td>
            <asp:CheckBox ID="chkIsArchive" runat="server" Text="该表是否存档" Enabled="False"></asp:CheckBox></td>
        <td></td>
    </tr>
</table>
