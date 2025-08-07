<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewInfo.ascx.cs"
    Inherits="AGC.Webform.wucViewInfo" %>

<%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>--%>
<table id="tabwucViewInfo" border="0"
    style="width: 100%; height: 431px; padding: 1px">
    <tr>
        <td colspan="4" style="width: 75px">

            <asp:Label ID="Label1" runat="server" Width="113px" CssClass="RegionTitleH2">界面基本信息:</asp:Label>

        </td>
    </tr>

    <tr>
        <td colspan="4" style="width: 75px">
            <img style="width: 700px; height: 3px" height="3" alt="" src="../../pic/兰色直线1.gif"
                width="768">
        </td>
    </tr>
    <tr>
        <td colspan="4" style="width: 75px">
            <asp:Label ID="lblMsg4Edit" runat="server" Width="696px" CssClass="text-warning">错误:</asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="4" style="width: 75px">
            <img style="width: 700px; height: 3px" height="3" alt="" src="../../pic/兰色直线1.gif"
                width="768">
        </td>
    </tr>
    <tr>
        <td colspan="2" style="width: 475px">
            <asp:Label ID="Label4" runat="server" CssClass="topContent2">请选择界面的相关主表:</asp:Label>
            <asp:DropDownList ID="ddlMainTabId" runat="server" Width="224px" OnSelectedIndexChanged="ddlMainTabId_SelectedIndexChanged"
                AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td>
            <asp:Label ID="lblViewId" runat="server" CssClass="text-secondary">界面ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtViewId" runat="server" Width="120px"></asp:TextBox>
        </td>

    </tr>
    <tr>
        <td style="width: 75px">

            <asp:Label ID="Label2" runat="server" CssClass="text-secondary">应用类型</asp:Label>


        </td>
        <td style="width: 123px">
            <asp:DropDownList ID="ddlApplicationTypeId" Width="224px" runat="server" AutoPostBack="True"
                OnSelectedIndexChanged="ddlApplicationTypeId_SelectedIndexChanged">
            </asp:DropDownList>
        </td>

    </tr>
    <tr id="trViewGroup" runat="server">
        <td style="width: 75px">
            <asp:Label ID="lblViewGroupId" runat="server" CssClass="text-secondary">界面组</asp:Label>
        </td>
        <td style="width: 123px">
            <asp:DropDownList ID="ddlViewGroupId" Width="224px" runat="server">
            </asp:DropDownList>
        </td>
        <td style="width: 59px">&nbsp;</td>
        <td style="width: 120px">&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 75px">
            <asp:Label ID="lblFuncModuleId" runat="server" CssClass="text-secondary">功能模块</asp:Label>
        </td>
        <td style="width: 123px">
            <asp:DropDownList ID="ddlFuncModuleId" runat="server" Width="224px">
            </asp:DropDownList>
        </td>
        <td style="width: 59px">&nbsp;</td>
        <td style="width: 120px">

            <asp:CheckBox ID="chkIsUseCache4List" runat="server" CssClass="text-secondary" Text="是否使用缓存列表" Width="208px" />

        </td>
    </tr>
    <tr>
        <td style="width: 75px">
            <asp:Label ID="lblViewName" runat="server" Style="left: 379px; top: 98px" CssClass="text-secondary">界面名称</asp:Label>
        </td>
        <td style="width: 123px">
            <asp:TextBox ID="txtViewName" runat="server" Width="224px" AutoPostBack="True" OnTextChanged="txtViewName_TextChanged"></asp:TextBox>
        </td>
        <td style="width: 59px">
            <asp:Label ID="lblFileName" runat="server" Style="z-index: 104; left: 420px; top: 7px"
                CssClass="text-secondary">文件名</asp:Label>
        </td>
        <td style="width: 120px">
            <asp:TextBox ID="txtFileName" Width="224px" runat="server" Style="z-index: 100; left: 484px; top: 2px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 75px">
            <asp:Label ID="lblViewCnName" runat="server" Style="left: 3px; top: 97px" CssClass="text-secondary">中文名称</asp:Label>
        </td>
        <td style="width: 123px">
            <asp:TextBox ID="txtViewCnName" Width="224px" runat="server" AutoPostBack="True"
                Style="left: 1px; top: 97px" OnTextChanged="txtViewCnName_TextChanged"></asp:TextBox>
        </td>
        <td style="width: 59px">
            <asp:Label ID="lblDefaMenuName" runat="server" Width="76px" Style="z-index: 101; left: 382px; top: 0px"
                CssClass="text-secondary">默认菜单名</asp:Label>
        </td>
        <td style="width: 120px">
            <asp:TextBox ID="txtDefaMenuName" Width="224px" runat="server" Style="z-index: 104; left: 479px; top: 0px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 75px">
            <asp:Label ID="lblFilePath" runat="server" CssClass="text-secondary">文件路径</asp:Label>
        </td>
        <td style="width: 123px">
            <asp:TextBox ID="txtFilePath" Width="224px" runat="server"></asp:TextBox>
        </td>
        <td style="width: 59px">

            <asp:Label ID="lblDefaMenuName0" runat="server" CssClass="text-secondary" Style="z-index: 101; left: 382px; top: 0px"
                Width="120px">设置导出字段?</asp:Label>

        </td>
        <td style="width: 120px">

            <asp:CheckBox ID="chkIsNeedSetExportFld" runat="server" CssClass="text-secondary" Text="是否需要设置导出字段" Width="208px" />

        </td>
    </tr>
    <tr>
        <td style="width: 75px" colspan="4">

            <asp:Label ID="Label3" Width="128px" runat="server" CssClass="RegionTitleH2">界面相关表信息:</asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 75px" colspan="4">
            <img style="width: 700px; height: 3px" height="3" alt="" src="../../pic/兰色直线1.gif"
                width="768">
        </td>
    </tr>
    <tr>
        <td style="width: 125px">
            <asp:Label ID="lblInSqlDsTypeId" runat="server" CssClass="text-secondary">输入类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlInSqlDsTypeId" runat="server" Width="224px" AutoPostBack="True"
                OnSelectedIndexChanged="ddlInSqlDsTypeId_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td>

            <asp:Label ID="lblInRelaTabId" runat="server" CssClass="text-secondary">输入数据源表</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlInRelaTabId" runat="server" Width="224px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="width: 125px">
            <asp:Label ID="lblOutSqlDsTypeId" runat="server" CssClass="text-secondary">输出类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlOutSqlDsTypeId" runat="server" Width="224px" AutoPostBack="True"
                OnSelectedIndexChanged="ddlOutSqlDsTypeId_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td>

            <asp:Label ID="lblOutRelaTabId" runat="server" CssClass="text-secondary">输出数据源表</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlOutRelaTabId" runat="server" Width="224px">
            </asp:DropDownList>
        </td>
    </tr>

    <tr>
        <td style="width: 125px">
            <asp:Label ID="lblOutSqlDsTypeId0" runat="server" CssClass="text-secondary">测试关键字Id</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtKeyId4Test" Width="224px" runat="server" AutoPostBack="True"
                Style="left: 1px; top: 97px" OnTextChanged="txtViewCnName_TextChanged"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblViewMasterId" name="lblViewMasterId" CssClass="col-form-label text-right" Width="90px" Text="界面母版" runat="server" />
        </td>
        <td>
            <asp:DropDownList ID="ddlViewMasterId" name="ddlViewMasterId" CssClass="form-control" Width="224px" runat="server" />
        </td>
    </tr>

    <tr>
        <td style="width: 125px">
            <asp:Label ID="Label6" runat="server" CssClass="text-secondary">CM工程</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlCmPrjId" runat="server" Width="224px" AutoPostBack="True"
                OnSelectedIndexChanged="ddlCmPrjId_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>

    <tr>
        <td colspan="4" style="width: 75px">

            <asp:Label ID="Label5" runat="server" Width="128px" CssClass="RegionTitleH2">界面功能及说明:</asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="4" style="width: 75px">
            <img style="width: 700px; height: 3px" height="3" alt="" src="../../pic/兰色直线1.gif"
                width="768">
        </td>
    </tr>
    <tr>
        <td style="width: 75px" valign="top">
            <asp:Label ID="lblViewFunction" runat="server" CssClass="text-secondary">界面功能</asp:Label>
        </td>
        <td colspan="3">
            <asp:TextBox ID="txtViewFunction" runat="server" Width="552px" Height="60px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 75px" valign="top">
            <asp:Label ID="lblViewDetail" runat="server" CssClass="text-secondary">界面说明</asp:Label>
        </td>
        <td colspan="3">
            <asp:TextBox ID="txtViewDetail" runat="server" Width="552px" Height="50px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" border="1" runat="server" style="width: 639px">
    <tr>
        <td>
            <asp:Label ID="lblUserId" runat="server" CssClass="text-secondary">用户ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>
        </td>
        <td style="width: 7px">
            <asp:Label ID="lblPrjId" runat="server" CssClass="text-secondary">工程ID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlPrjId" runat="server" Width="120px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDataBaseName" runat="server" CssClass="text-secondary">数据库名</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDataBaseName" runat="server" Width="120px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;
        </td>
        <td>
            <asp:CheckBox ID="chkIsNeedSort" runat="server" Text="DataGrid是否需要排序" Width="160px"
                CssClass="text-secondary"></asp:CheckBox>
        </td>
        <td style="width: 7px">&nbsp;
        </td>
        <td>
            <asp:CheckBox ID="chkIsNeedTransCode" runat="server" Width="208px" Text="DataGrid中是否需要转换代码"
                CssClass="text-secondary"></asp:CheckBox>
        </td>
    </tr>
    <tr style="visibility: hidden">
        <td></td>
        <td></td>
        <td align="left">
            <asp:Label ID="lblKeyForMainTab" runat="server" CssClass="text-secondary">主表关键字</asp:Label>
        </td>
        <td align="left">

            <asp:TextBox ID="txtKeyForMainTab" Width="224px" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr style="visibility: hidden">
        <td>
            <asp:Label ID="lblDetailTabName" runat="server" CssClass="text-secondary">明细表名</asp:Label>
        </td>
        <td style="width: 123px">
            <asp:DropDownList ID="ddlDetailTabId" runat="server" Width="224px">
            </asp:DropDownList>
        </td>
        <td align="left">
            <asp:Label ID="lblKeyForDetailTab" runat="server" CssClass="text-secondary">明细表关键字</asp:Label>
        </td>
        <td align="left">
            <asp:TextBox ID="txtKeyForDetailTab" Width="224px" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
<%--  </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="ddlApplicationTypeId" EventName="SelectedIndexChanged" />
        <asp:AsyncPostBackTrigger ControlID="ddlInSqlDsTypeId" EventName="SelectedIndexChanged" />
        <asp:AsyncPostBackTrigger ControlID="ddlOutSqlDsTypeId" EventName="SelectedIndexChanged" />
        <asp:AsyncPostBackTrigger ControlID="txtViewCnName" EventName="TextChanged" />
        <asp:AsyncPostBackTrigger ControlID="ddlMainTabId" EventName="SelectedIndexChanged" />
        <asp:AsyncPostBackTrigger ControlID="txtViewName" EventName="TextChanged" />
    </Triggers>
</asp:UpdatePanel>--%>
