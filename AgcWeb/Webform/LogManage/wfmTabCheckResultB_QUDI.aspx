<%@ Register TagPrefix="uc1" TagName="wucTabCheckResultB" Src="wucTabCheckResultB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmTabCheckResultB_QUDI.aspx.cs"
    Inherits="AGC.Webform.wfmTabCheckResultB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表检查结果维护的维护</title>
    
    <%--    <link href="../css/button.css" rel="stylesheet" type="text/css" />
    <link href="../css/LinkButton.css" rel="stylesheet" type="text/css" />
    <link href="../../css/tz_MenuButton/tz_sccl.css" rel="stylesheet" />--%>
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
        <div id="Div1" class="tab_layout"
            runat="server">

            <%-- 标题层 --%>

            <div style="position: relative; width: 100%; height: 35px; left: 0px; top: 0px;">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" CssClass="h5" Width="212px">表检查结果维护                    </asp:Label>
                        </td>

                        <td>&nbsp;</td>
                        <td>

                            <asp:Label ID="lblMsgList" runat="server" CssClass="auto-style1"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>


            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="lblPrjIdq"  runat="server" Width="90px"
                                CssClass="text-secondary">工程</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="150px"
                                 CssClass="TextBox_Defa" AutoPostBack="True" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblPrjDataBaseIdq" 
                                runat="server" Width="90px" CssClass="text-secondary">项目数据库</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPrjDataBaseIdq" 
                                runat="server" Width="147px"  CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                        <td >
                            <asp:Label ID="Label6" runat="server" CssClass="NameLabelRightAlign" Width="70px">数据源类型</asp:Label>
                        </td>
                        <td >
                            <asp:DropDownList ID="ddlSqlDsTypeId" runat="server" Width="200px">
                            </asp:DropDownList>
                        </td>
                        <td >&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblErrorLevelIdq"  runat="server" Width="90px"
                                CssClass="text-secondary">错误等级Id</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlErrorLevelIdq"  runat="server" Width="150px"
                                 CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblTabIdq"  runat="server" Width="34px"
                                CssClass="text-secondary">表名</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTabIdq"  runat="server" Width="150px"
                                 CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblErrorMsgq"  runat="server" Width="66px"
                                CssClass="text-secondary">错误信息</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtErrorMsgq"  runat="server" Width="200px"
                                 CssClass="TextBox_Defa"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="btnQuery" Style="z-index: 116;" runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm" OnClick="btnQuery_Click"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" CssClass="NameLabelRightAlign" Width="71px">模块</asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:DropDownList ID="ddlFuncModuleId" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlFuncModuleId_SelectedIndexChanged"
                                Width="264px">
                            </asp:DropDownList>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="lblErrorMsg_q0"  runat="server"
                                Width="66px"
                                CssClass="text-secondary">错误类型</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTabCheckErrorTypeId" runat="server" Width="200px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" 
                                runat="server" CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                        </td>
                    </tr>
                </table>
            </div>

            <div id="divBaseOperate" class="tz-layout-menu" runat="server" style="width: 100%; height: 40px">
                <nav class="navbar navbar-expand-lg navbar-light bg-light">
                    <a class="navbar-brand" href="#" style="width: 150px;">表检查结果列表</a>
                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="navbarSupportedContent">
                        <ul class="navbar-nav mr-auto">

                            <li class="nav-item dropdown ml-2">
                                <a class="nav-link dropdown-toggle btn-sm" href="#" id="navbarDropdown1" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">检查表                            </a>
                                <div class="dropdown-menu" aria-labelledby="navbarDropdown1">

                                    <asp:LinkButton ID="lbInitCheckAllTabField" runat="server" class="dropdown-item btn btn-secondary btn-sm" Width="78px" OnClick="lbInitCheckAllTabField_Click">检查初始化</asp:LinkButton>
                                    <asp:LinkButton ID="lbCheckAllTabField" runat="server" class="dropdown-item btn btn-secondary btn-sm" OnClick="lbCheckAllTabField_Click"
                                        Width="100px">检查所有表字段</asp:LinkButton>
                                    <asp:LinkButton ID="lbCheckCheckedTabField" runat="server" class="dropdown-item btn btn-secondary btn-sm" Width="100px" OnClick="lbCheckCheckedTabField_Click">检查所选表字段</asp:LinkButton>
                                </div>
                            </li>
                            <li class="nav-item dropdown ml-2">
                                <asp:LinkButton ID="lbCheckConsistency" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="lbCheckConsistency_Click">检查一致性</asp:LinkButton>
                            </li>
                            <li class="nav-item dropdown ml-2">
                                <asp:LinkButton ID="btnEditObjectAndTabFields" runat="server"
                                    CssClass="btn btn-outline-info btn-sm" OnClick="btnEditObjectAndTabFields_Click" Text="表综合维护" Width="93px" />
                            </li>
                            <li class="nav-item dropdown ml-2">
                                <a class="nav-link dropdown-toggle btn-sm" href="#" id="navbarDropdown2" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">表操作</a>
                                <div class="dropdown-menu" aria-labelledby="navbarDropdown2">
                                    <asp:LinkButton ID="lbSetNullableBySQL" runat="server" class="dropdown-item btn btn-secondary btn-sm" OnClick="lbSetNullableBySQL_Click" Width="160px" Text="根据SQL设置表字段可空性"></asp:LinkButton>
                                    <asp:LinkButton ID="btnSetTabWaitConsider" class="dropdown-item btn btn-secondary btn-sm" OnClick="btnSetTabWaitConsider_Click" runat="server" Width="99px" Text="设置表待考虑"></asp:LinkButton>
                                </div>
                            </li>
                            <li class="nav-item dropdown ml-2">
                                <a class="nav-link dropdown-toggle btn-sm" href="#" id="navbarDropdown3" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">查询</a>
                                <div class="dropdown-menu" aria-labelledby="navbarDropdown3">
                                    <asp:LinkButton ID="btnQueryViewReferThisTab" class="dropdown-item btn btn-secondary btn-sm" runat="server" OnClick="btnQueryViewReferThisTab_Click" Text="查询引用该表的视图"></asp:LinkButton>
                                    <asp:LinkButton ID="btnQueryReferedTabAndView" class="dropdown-item btn btn-secondary btn-sm" runat="server" OnClick="btnQueryReferedTabAndView_Click"
                                        Text="查询被引用的表和视图"></asp:LinkButton>
                                </div>
                            </li>

                            <li class="menu-bar-nav ml-2">
                                <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click"
                                    runat="server" CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                            </li>


                            <li class="menu-bar-nav ml-2">
                                <asp:Button ID="btnCreateView4Sql" runat="server"
                                    Width="105px" CssClass="btn btn-outline-info btn-sm" Text="建立视图4Sql" OnClick="btnCreateView4Sql_Click"></asp:Button>
                            </li>
                            <li class="menu-bar-nav ml-2">
                                <asp:Button ID="btnSetOrderNum4Refer" runat="server"
                                    Width="100px" CssClass="btn btn-outline-info btn-sm" Text="设置引用序号" OnClick="btnSetOrderNum4Refer_Click"></asp:Button>
                            </li>

                        </ul>
                    </div>
                </nav>
            </div>

            <%-- 列表层 --%>

            <div id="divList" class="div_List mt-3" runat="server">


                <asp:GridView ID="gvTabCheckResult" Style="z-index: 117;" runat="server" Width="100%"
                    AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True" OnSorting="gvTabCheckResult_Sorting"
                    OnPageIndexChanging="gvTabCheckResult_PageIndexChanging" OnRowCreated="gvTabCheckResult_RowCreated"
                    OnRowCommand="gvTabCheckResult_RowCommand" OnRowDeleting="gvTabCheckResult_RowDeleting"
                    OnRowUpdating="gvTabCheckResult_RowUpdating" BackColor="White" BorderColor="#E7E7FF"
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="1px"
                    DataKeyNames="mId" CssClass="table table-striped table-bordered table-condensed" OnSelectedIndexChanged="gvTabCheckResult_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField HeaderText="全选">
                            <HeaderStyle Width="35px" />
                            <HeaderTemplate>
                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="mId" SortExpression="mId" HeaderText="mId" Visible="False"></asp:BoundField>
                        <asp:BoundField DataField="PrjId" SortExpression="PrjId" HeaderText="工程ID" Visible="False"></asp:BoundField>
                        <asp:BoundField DataField="FldId" SortExpression="FldId" HeaderText="字段ID" Visible="False"></asp:BoundField>
                        <asp:BoundField DataField="PrjName" SortExpression="PrjName" HeaderText="工程名称" Visible="False"></asp:BoundField>

                        <asp:BoundField DataField="PrjDataBaseName" SortExpression="PrjDataBaseName" HeaderText="数据库" Visible="False"></asp:BoundField>

                        <asp:BoundField DataField="OrderNum4Refer" SortExpression="OrderNum4Refer" HeaderText="引用序号"></asp:BoundField>

                        <asp:BoundField DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="模块"></asp:BoundField>
                        <asp:BoundField DataField="SqlDsTypeName" SortExpression="SqlDsTypeName" HeaderText="表类型"></asp:BoundField>
                        <asp:BoundField DataField="TabId" SortExpression="TabId" HeaderText="表ID" Visible="False"></asp:BoundField>
                        <asp:BoundField DataField="TabName" SortExpression="TabName" HeaderText="表名"></asp:BoundField>
                        <asp:BoundField DataField="TabCnName" SortExpression="TabCnName" HeaderText="表中文名" Visible="False"></asp:BoundField>
                        <asp:BoundField DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundField>
                        <asp:BoundField DataField="ErrorLevelId" SortExpression="ErrorLevelId" HeaderText="错误等级Id"
                            Visible="False"></asp:BoundField>
                        <asp:BoundField DataField="ErrorLevelName" SortExpression="ErrorLevelName" HeaderText="错误等级名"></asp:BoundField>
                        <asp:BoundField DataField="TabCheckErrorTypeName" SortExpression="TabCheckErrorTypeName" HeaderText="错误类型"></asp:BoundField>
                        <asp:BoundField DataField="errorMsg" SortExpression="errorMsg" HeaderText="错误信息"></asp:BoundField>
                        <asp:BoundField DataField="CheckDate" SortExpression="CheckDate" HeaderText="检查日期"></asp:BoundField>
                        <asp:BoundField DataField="CheckUser" SortExpression="CheckUser" HeaderText="检查人"
                            Visible="False"></asp:BoundField>
                        <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明" Visible="False"></asp:BoundField>
                    </Columns>
                    <PagerTemplate>
                        <span class="text-secondary">共有记录:</span>
                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                            Width="22px">0</asp:Label>
                        <span style="background-color: #c0c0c0">
                            <div style="display: inline; width: 16px;">
                            </div>
                        </span><span class="text-secondary">总页数:</span>
                        <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                        <div style="display: inline; width: 16px;">
                        </div>
                        <span class="text-secondary">当前页:</span>
                        <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                        <div style="display: inline; width: 16px;">
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
                            ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                    </PagerTemplate>
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                </asp:GridView>

            </div>
            <%-- 编辑层 --%>
            <div id="tabEditCodeTypeRegion" class="tab_Edit"
                runat="server">
                <table id="tabEditTabCheckResultRegion" style="z-index: 117; width: 100%" cellspacing="1"
                    cellpadding="1" width="100%" border="1" runat="server">
                    <tr>
                        <td>
                            <asp:Label ID="lblEditTabCheckResult"  runat="server" CssClass="h6">表检查结果编辑区域</asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblMsgEdit" runat="server" Width="208px"
                                CssClass="text-warning"></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="btnOKUpd"  runat="server" Text="添加"
                                OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnCancelTabCheckResultEdit"  runat="server"
                                Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelTabCheckResultEdit_Click"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4">
                            <uc1:wucTabCheckResultB ID="wucTabCheckResultB1" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <input type="hidden" name="FunName" />
        <input type="hidden" name="hidLangType" />
        <input type="hidden" name="hidDataBaseType" />
    </form>
</body>
</html>
