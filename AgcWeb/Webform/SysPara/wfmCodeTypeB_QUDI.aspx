<%@ Register TagPrefix="uc1" TagName="wucCodeTypeB" Src="wucCodeTypeB.ascx" %>
<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmCodeTypeB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmCodeTypeB_QUDI" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>代码类型维护的维护</title>
    
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5">代码类型维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 90%">
                    <tr>

                        <td>
                            <asp:Label ID="lblCodeTypeIdq"
                                runat="server" CssClass="text-secondary">代码类型Id</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCodeTypeIdq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblCodeTypeNameq"
                                runat="server" CssClass="text-secondary">代码类型名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCodeTypeNameq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="Label1"
                                runat="server" CssClass="text-secondary">类型英文名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCodeTypeENNameq"
                                runat="server" CssClass="TextBox_Defa"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblCodeTypeENNameq" 
                                runat="server" CssClass="text-secondary">依赖于</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtDependsOnq"
                                runat="server" CssClass="TextBox_Defa"></asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblFrontOrBackq"
                                runat="server" CssClass="text-secondary">前台Or后台</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFrontOrBackq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblProgLangTypeIdq" 
                                runat="server" CssClass="text-secondary">语言</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlProgLangTypeIdq"
                                runat="server" CssClass="TextBox_Defa" AutoPostBack="True">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblIsCSharpq" Style="z-index: 116;"
                                runat="server" CssClass="text-secondary">分组</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlGroupNameq" Style="z-index: 117;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                       <%-- <td>
                            <asp:Label ID="lblIsJavaq" Style="z-index: 119;"
                                runat="server" CssClass="text-secondary">Java语言?</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsJavaq" Style="z-index: 120;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblIsJavaScriptq" Style="z-index: 122;"
                                runat="server" CssClass="text-secondary">JavaScript?</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsJavaScriptq" Style="z-index: 123;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblIsSilverLightq" Style="z-index: 125;"
                                runat="server" CssClass="text-secondary">SilverLight?</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsSilverLightq" Style="z-index: 126;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>--%>

                    </tr>
                    <tr>

                     <%--   <td>
                            <asp:Label ID="lblIsSwiftq" Style="z-index: 128;"
                                runat="server" CssClass="text-secondary">Swift语言?</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsSwiftq" Style="z-index: 129;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>--%>

                        <td>
                            <asp:Label ID="lblIsWebq" Style="z-index: 131;"
                                runat="server" CssClass="text-secondary">Web应用?</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsWebq" Style="z-index: 132;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblIsWinq" Style="z-index: 134;"
                                runat="server" CssClass="text-secondary">Win应用?</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsWinq" Style="z-index: 135;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblIsMobileAppq" Style="z-index: 137;"
                                runat="server" CssClass="text-secondary">移动终端应用?</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsMobileAppq" Style="z-index: 138;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 140; width: 80px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click"
                                runat="server" CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>

            <div id="divList" class="div_List"
                runat="server">
                <div id="tabGridFunction" style="width: 100%; height: 32px" class="msgtable">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblCodeTypeList" runat="server"
                                CssClass="h6" Width="250px">代码类型列表</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCloneNewRec4Gv" runat="server" OnClick="btnCloneNewRec4Gv_Click"
                                Width="44px" CssClass="btn btn-outline-info btn-sm" Text="克隆"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" runat="server" CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" runat="server" CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <div class="btn-group" role="group" aria-label="Basic example">
                                <asp:TextBox ID="txtGroupName"
                                    runat="server" CssClass="TextBox_Defa">
                                </asp:TextBox>

                                <asp:Button ID="btnSetGroupName" CssClass="btn btn-outline-info btn-sm" Width="70px" Text="设置组名" runat="server" OnClick="btnSetGroupName_Click" />
                            </div>
                        </li>
                        <li class="nav-item ml-3">
<div class="btn-group" role="group" aria-label="Basic example">
<asp:DropDownList id="ddlSqlDsTypeId_SetFldValue" name="ddlSqlDsTypeId_SetFldValue" class="form-control" Width="200px" runat="server" />
<asp:Button id="btnSetSqlDsTypeId" CssClass="btn btn-outline-info text-nowrap" OnClick="btnSetSqlDsTypeId_Click" Text="设置数据源类型" runat="server" />
</div>
</li>
                        <li class="nav-item ml-3">
                            <div class="btn-group" role="group" aria-label="Basic example">
                                <asp:Button ID="btnGoTop" runat="server" Text="移顶"  OnClick="btnGoTop_Click" CssClass="btn btn-outline-info btn-sm" />
                                <asp:Button ID="btnUpMove" runat="server" OnClick="btnUpMove_Click" Text="上移"  CssClass="btn btn-outline-info btn-sm ml-1" />
                                <asp:Button ID="btnDownMove" runat="server" OnClick="btnDownMove_Click" Text="下移"  CssClass="btn btn-outline-info btn-sm ml-1" />
                                <asp:Button ID="btnGoBottum" runat="server" Text="移底"  OnClick="btnGoBottum_Click" CssClass="btn btn-outline-info btn-sm ml-1" />
                                <asp:Button ID="btnReOrder" runat="server" OnClick="btnReOrder_Click" Text="重序" CssClass="btn btn-outline-info btn-sm ml-1" />
                            </div>
                        </li>
                       
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnGeneCodeType"
                                Style="z-index: 140; width: 80px;"
                                runat="server"
                                Text="生成" CssClass="btn btn-outline-info btn-sm"
                                OnClick="btnGeneCodeType_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnSetClassNameFormat"
                                runat="server"
                                Text="自动设置类名格式" CssClass="btn btn-outline-info btn-sm"
                                OnClick="btnSetClassNameFormat_Click" Width="125px"></asp:Button>
                        </li>
                    </ul>
                </div>
                <asp:GridView ID="gvCodeType" Style="z-index: 141;" runat="server"
                    Width="100%" AutoGenerateColumns="False"
                    PageSize="10" AllowPaging="true"
                    AllowSorting="true"
                    OnSorting="gvCodeType_Sorting"
                    OnPageIndexChanging="gvCodeType_PageIndexChanging"
                    OnRowCreated="gvCodeType_RowCreated"
                    OnRowCommand="gvCodeType_RowCommand"
                    OnRowDeleting="gvCodeType_RowDeleting"
                    OnRowUpdating="gvCodeType_RowUpdating"
                    BackColor="White"
                    BorderColor="#E7E7FF"
                    BorderStyle="None"
                    BorderWidth="1px"
                    CellPadding="3"
                    GridLines="Horizontal"
                    Height="1px"
                    DataKeyNames="CodeTypeId"
                    CssClass="table table-striped table-bordered table-condensed" OnRowDataBound="gvCodeType_RowDataBound">
                    <Columns>
                        <asp:TemplateField HeaderText="全选">
                            <HeaderStyle Width="35px" />
                            <HeaderTemplate>
                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" Text="全选"></asp:LinkButton>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <a name="A_CodeType<%# Eval("CodeTypeId").ToString().Trim() %>"></a>
                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="序号"></asp:BoundField>
                        <asp:BoundField DataField="CodeTypeId" SortExpression="CodeTypeId" HeaderText="代码类型Id"></asp:BoundField>
                        <asp:BoundField DataField="CodeTypeName" SortExpression="CodeTypeName" HeaderText="代码类型(简称)"></asp:BoundField>
                        <asp:BoundField DataField="GroupName" SortExpression="GroupName" HeaderText="组名"></asp:BoundField>
                        <asp:BoundField DataField="ProgLangTypeName" SortExpression="ProgLangTypeName" HeaderText="语言"></asp:BoundField>
                        <asp:BoundField DataField="CodeTypeSimName" SortExpression="CodeTypeSimName" HeaderText="简称"></asp:BoundField>
                        <asp:BoundField DataField="CodeTypeENName" SortExpression="CodeTypeENName" HeaderText="代码类型英文名"></asp:BoundField>
                        <asp:BoundField DataField="DependsOn" SortExpression="DependsOn" HeaderText="依赖于"></asp:BoundField>
                        <asp:BoundField DataField="FrontOrBack" SortExpression="FrontOrBack" HeaderText="前台Or后台"></asp:BoundField>
                        <asp:BoundField DataField="SqlDsTypeName" SortExpression="SqlDsTypeName" HeaderText="Sql类型"></asp:BoundField>
                        <asp:BoundField DataField="ClassNameFormat" SortExpression="ClassNameFormat" HeaderText="类名格式"></asp:BoundField>

                        <asp:BoundField DataField="IsPubApp4WinWeb" SortExpression="IsPubApp4WinWeb" HeaderText="应用后台?"></asp:BoundField>
                        <asp:BoundField DataField="IsWeb" SortExpression="IsWeb" HeaderText="Web应用?"></asp:BoundField>
                        <asp:BoundField DataField="IsAspMvc" SortExpression="IsAspMvc" HeaderText="AspMvc应用?"></asp:BoundField>
                        <asp:BoundField DataField="IsWin" SortExpression="IsWin" HeaderText="Win应用?"></asp:BoundField>
                        <asp:BoundField DataField="IsMobileApp" SortExpression="IsMobileApp" HeaderText="移动终端应用?"></asp:BoundField>
                        <asp:BoundField DataField="IsDefaultOverride" SortExpression="IsDefaultOverride" HeaderText="默认覆盖?"></asp:BoundField>
                        <asp:BoundField DataField="IsDirByTabName" SortExpression="IsDirByTabName" HeaderText="表名作路径?"></asp:BoundField>
                        <asp:BoundField DataField="AppCount" SortExpression="AppCount" HeaderText="应用数"></asp:BoundField>
                        <asp:BoundField DataField="FuncCount" SortExpression="FuncCount" HeaderText="函数数"></asp:BoundField>


                        <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundField>
                        <asp:TemplateField HeaderText="修改">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="修改" CssClass="LinkButton_DefaInGv"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="删除">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除" CssClass="LinkButton_DefaInGv"></asp:LinkButton>
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
                            <asp:ListItem>15</asp:ListItem>
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
            <div id="tabEditCodeTypeRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditCodeType" runat="server"
                                    CssClass="h6">代码类型编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit" runat="server"
                                    Width="208px" CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd" runat="server"
                                    Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                &nbsp;
                                <asp:Button ID="btnCancelCodeTypeEdit"
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelCodeTypeEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucCodeTypeB ID="wucCodeTypeB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
