<%@ Register TagPrefix="uc1" TagName="wucViewStyleB" Src="wucViewStyle.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true" CodeBehind="wfmViewStyleB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmViewStyleB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>界面模式维护的维护</title>
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
      <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
      <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >界面模式维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td>
                            <asp:Label ID="lblTitleStyleIdq" 
                                runat="server" CssClass="text-secondary">标题类型Id</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTitleStyleIdq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblDgStyleIdq" 
                                runat="server" CssClass="text-secondary">DG模式ID</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlDgStyleIdq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblViewNameq" 
                                runat="server" CssClass="text-secondary">界面名称</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtViewNameq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblFuncModuleIdq" 
                                runat="server" CssClass="text-secondary">功能模块Id</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFuncModuleIdq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblMainTabNameq" Style="z-index: 116;"
                                runat="server" CssClass="text-secondary">MainTabName</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtMainTabNameq" Style="z-index: 117;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 119; width: 80px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>

            <div id="divList" class="div_List"
                runat="server">
                <table id="tabGridFunction" style="width: 100%; height: 32px" class="msgtable">
                    <tr>
                        <td>
                            <asp:Label ID="lblViewStyleList" runat="server" 
                                CssClass="h6" Width="250px">界面模式列表</asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" 
                                 CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click"  runat="server"
                                 CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click"  runat="server"
                                 CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" 
                                runat="server"  CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click" 
                                runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="设置导出字段"></asp:Button>
                        </td>
                    </tr>
                </table>
                <asp:GridView ID="gvViewStyle" Style="z-index: 120;" runat="server"
                    Width="100%" AutoGenerateColumns="False"
                    PageSize="10" AllowPaging="true"
                    AllowSorting="true"
                    OnSorting="gvViewStyle_Sorting"
                    OnPageIndexChanging="gvViewStyle_PageIndexChanging"
                    OnRowCreated="gvViewStyle_RowCreated"
                    OnRowCommand="gvViewStyle_RowCommand"
                    OnRowDeleting="gvViewStyle_RowDeleting"
                    OnRowUpdating="gvViewStyle_RowUpdating"
                    BackColor="White"
                    BorderColor="#E7E7FF"
                    BorderStyle="None"
                    BorderWidth="1px"
                    CellPadding="3"
                    GridLines="Horizontal"
                    Height="1px"
                    DataKeyNames="ViewId"
                    CssClass="table table-striped table-bordered table-condensed">
                    <Columns>
                        <asp:TemplateField HeaderText="全选">
                            <HeaderStyle Width="35px" />
                            <HeaderTemplate>
                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <a name="A_ViewStyle<%# Eval("ViewId").ToString().Trim() %>"></a>
                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="ViewId" SortExpression="ViewId" HeaderText="界面ID"></asp:BoundField>
                        <asp:BoundField DataField="TitleStyleId" SortExpression="TitleStyleId" HeaderText="标题类型Id"></asp:BoundField>
                        <asp:BoundField DataField="TitleStyleName" SortExpression="TitleStyleName" HeaderText="标题类型名"></asp:BoundField>
                        <asp:BoundField DataField="DgStyleId" SortExpression="DgStyleId" HeaderText="DG模式ID"></asp:BoundField>
                        <asp:BoundField DataField="DgStyleName" SortExpression="DgStyleName" HeaderText="DG模式名"></asp:BoundField>
                        <asp:BoundField DataField="ViewName" SortExpression="ViewName" HeaderText="界面名称"></asp:BoundField>
                        <asp:BoundField DataField="ViewTypeCode" SortExpression="ViewTypeCode" HeaderText="界面类型码"></asp:BoundField>
                        <asp:BoundField DataField="ViewTypeName" SortExpression="ViewTypeName" HeaderText="界面类型名称"></asp:BoundField>
                        <asp:BoundField DataField="ApplicationTypeId" SortExpression="ApplicationTypeId" HeaderText="应用程序类型ID"></asp:BoundField>
                        <asp:BoundField DataField="ApplicationTypeName" SortExpression="ApplicationTypeName" HeaderText="应用程序类型名称"></asp:BoundField>
                        <asp:BoundField DataField="FuncModuleAgcId" SortExpression="FuncModuleAgcId" HeaderText="功能模块Id"></asp:BoundField>
                        <asp:BoundField DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="功能模块名称"></asp:BoundField>
                        <asp:BoundField DataField="FuncModuleEnName" SortExpression="FuncModuleEnName" HeaderText="功能模块英文名称"></asp:BoundField>
                        <asp:BoundField DataField="DataBaseName" SortExpression="DataBaseName" HeaderText="数据库名"></asp:BoundField>
                        <asp:BoundField DataField="KeyForMainTab" SortExpression="KeyForMainTab" HeaderText="主表关键字"></asp:BoundField>
                        <asp:BoundField DataField="KeyForDetailTab" SortExpression="KeyForDetailTab" HeaderText="明细表关键字"></asp:BoundField>
                        <asp:BoundField DataField="IsNeedSort" SortExpression="IsNeedSort" HeaderText="是否需要排序"></asp:BoundField>
                        <asp:BoundField DataField="IsNeedTransCode" SortExpression="IsNeedTransCode" HeaderText="是否需要转换代码"></asp:BoundField>
                        <asp:BoundField DataField="UserId" SortExpression="UserId" HeaderText="用户ID"></asp:BoundField>
                        <asp:BoundField DataField="PrjId" SortExpression="PrjId" HeaderText="工程ID"></asp:BoundField>
                        <asp:BoundField DataField="PrjName" SortExpression="PrjName" HeaderText="工程名称"></asp:BoundField>
                        <asp:BoundField DataField="ViewFunction" SortExpression="ViewFunction" HeaderText="界面功能"></asp:BoundField>
                        <asp:BoundField DataField="ViewDetail" SortExpression="ViewDetail" HeaderText="界面说明"></asp:BoundField>
                        <asp:BoundField DataField="DefaMenuName" SortExpression="DefaMenuName" HeaderText="缺省菜单名"></asp:BoundField>
                        <asp:BoundField DataField="DetailTabId" SortExpression="DetailTabId" HeaderText="明细表ID"></asp:BoundField>
                        <asp:BoundField DataField="FileName" SortExpression="FileName" HeaderText="文件名"></asp:BoundField>
                        <asp:BoundField DataField="FilePath" SortExpression="FilePath" HeaderText="文件路径"></asp:BoundField>
                        <asp:BoundField DataField="MainTabId" SortExpression="MainTabId" HeaderText="主表ID"></asp:BoundField>
                        <asp:BoundField DataField="ViewCnName" SortExpression="ViewCnName" HeaderText="视图中文名"></asp:BoundField>
                        <asp:BoundField DataField="ViewGroupId" SortExpression="ViewGroupId" HeaderText="界面组ID"></asp:BoundField>
                        <asp:BoundField DataField="ViewGroupName" SortExpression="ViewGroupName" HeaderText="界面组名称"></asp:BoundField>
                        <asp:BoundField DataField="InSqlDsTypeId" SortExpression="InSqlDsTypeId" HeaderText="输入数据源类型"></asp:BoundField>
                        <asp:BoundField DataField="OutSqlDsTypeId" SortExpression="OutSqlDsTypeId" HeaderText="输出数据源类型"></asp:BoundField>
                        <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
                        <asp:BoundField DataField="GeneCodeDate" SortExpression="GeneCodeDate" HeaderText="生成代码日期"></asp:BoundField>
                        <asp:BoundField DataField="RegionNum" SortExpression="RegionNum" HeaderText="RegionNum"></asp:BoundField>
                        <asp:BoundField DataField="MainTabName" SortExpression="MainTabName" HeaderText="MainTabName"></asp:BoundField>
                        <asp:BoundField DataField="DetailTabName" SortExpression="DetailTabName" HeaderText="DetailTabName"></asp:BoundField>
                        <asp:BoundField DataField="MainTabKeyFld" SortExpression="MainTabKeyFld" HeaderText="MainTabKeyFld"></asp:BoundField>
                        <asp:BoundField DataField="DetailTabKeyFld" SortExpression="DetailTabKeyFld" HeaderText="DetailTabKeyFld"></asp:BoundField>
                        <asp:TemplateField HeaderText="修改">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="修改"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="删除">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <PagerTemplate>
                        <span class="text-secondary">共有记录:</span>
                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="36px">0</asp:Label>
                        <span style="background-color: #c0c0c0">
                            <div style="display: inline; width: 16px; height: 13px">
                            </div>
                        </span><span class="text-secondary">总页数:</span>
                        <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                        <div style="display: inline; width: 16px; height: 13px">
                        </div>
                        <span class="text-secondary">当前页:</span>
                        <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                        <div style="display: inline; width: 16px; height: 13px">
                        </div>
                        <asp:Button ID="btnPrevPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" Text="上一页"
                            CommandArgument="Prev" CommandName="Page" /><span style="font-family: Verdana">
                            </span>
                        <asp:Button ID="btnNextPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" Text="下一页"
                            CommandArgument="Next" CommandName="Page" />
                        到第
                        <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
                        <asp:Button ID="btnJumpPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" OnClick="btnJumpPage_Click"
                            Text="确定" Width="45px" CommandName="Page" />
                        <span class="text-secondary">页记录数:</span>
                        <asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="DropDown_DefaInPager"
                            Width="55px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                            <asp:ListItem>30</asp:ListItem>
                            <asp:ListItem>50</asp:ListItem>
                            <asp:ListItem>100</asp:ListItem>
                            <asp:ListItem>1000</asp:ListItem>
                        </asp:DropDownList>
                        <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                            ErrorMessage="错误!" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                    </PagerTemplate>
                    <FooterStyle CssClass="FooterStyle" />
                    <RowStyle CssClass="RowStyle" />
                    <EmptyDataRowStyle CssClass="EmptyDataRowStyle" />
                    <SelectedRowStyle CssClass="SelectedRowStyle" />
                    <PagerStyle CssClass="PagerStyle" />
                    <HeaderStyle CssClass="HeaderStyle" />
                    <EditRowStyle CssClass="EditRowStyle" />
                    <AlternatingRowStyle CssClass="AlternatingRowStyle" />
                </asp:GridView>
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditViewStyleRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditViewStyle"  runat="server"
                                    CssClass="h6">界面模式编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit"  runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                &nbsp;
                                <asp:Button ID="btnCancelViewStyleEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelViewStyleEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucViewStyleB id="wucViewStyleB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
