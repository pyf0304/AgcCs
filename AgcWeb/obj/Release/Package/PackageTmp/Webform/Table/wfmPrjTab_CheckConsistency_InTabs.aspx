<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmPrjTab_CheckConsistency_InTabs.aspx.cs"
    Inherits="AGC.Webform.wfmPrjTab_CheckConsistency_InTabs" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width,initial-scale=1,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no" />
    <meta name="renderer" content="webkit|ie-comp|ie-stand" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta http-equiv="Cache-Control" content="no-siteapp" />
    <meta name="keywords" content="scclui框架" />
    <meta name="description" content="工程表维护" />

    <title>检查系统表与SQL表的一致性</title>
    
    <style type="text/css">
        .style1 {
            width: 85px;
        }
    </style>
    
    <link href="../../css/tz_MenuButton/tz_sccl.css" rel="stylesheet" />
    <script type="text/javascript">

        function OpenwfmSqlViewB_QUDI(strSqlViewId) {

            var url = window.location.href;
            //var caseid = document.all.ctl00_ContentPlaceHolder1_hidId_ClsRmTeachingCase.value; //  url.substring(url.indexOf('id=') + 3, url.length);
            window.open('../SqlViewMan/wfmSqlViewB_QUDI.aspx?SqlViewId=' + strSqlViewId + '', '', 'width=950px,height=800px,top=100px,left=150px,scrollbars=yes');
        }
    </script>
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
        <table id="tabLayout" style="z-index: 105; left: 0px; position: absolute; top: 0px"
            cellspacing="2" cellpadding="2" width="100%" border="0" runat="server">
            <tr>
                <td colspan="2">
                    <div id="divPrjTabFldOp" class="tz-layout-menu" runat="server" style="width: 100%; height: 40px">
                        <span class="menu-logo">表字段管理-->检查一致性:</span>
                        <a class="menu-menu-btn" href="javascript:;"><i class="icon-font">&#xe600;</i></a>
                        <ul class="menu-bar">

                            <li class="menu-bar-nav">
                                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Width="100px"></asp:Label>
                            </li>


                            <li class="menu-bar-nav">
                                <asp:Button ID="btnReCheckConSistency" runat="server" CssClass="btn btn-outline-info btn-sm" Text="检查一致性" Width="100px" OnClick="btnReCheckConSistency_Click" />
                            </li>
                            <li class="menu-bar-nav">
                                <asp:Button ID="btnCheckSqlView" runat="server"  CssClass="btn btn-outline-info btn-sm" Text="视图详细信息" Width="100px" OnClick="btnCheckSqlView_Click" />
                            </li>
                            <li class="menu-bar-nav">
                                <asp:Button ID="btnCreateView4Sql"  runat="server"  CssClass="btn btn-outline-info btn-sm" 
                                    Width="105px" Text="建立视图4Sql" OnClick="btnCreateView4Sql_Click"></asp:Button>
                            </li>
                            <li class="menu-bar-nav">
                                <asp:Button ID="btnImportSqlViewFromSqlServer"  runat="server"  CssClass="btn btn-outline-info btn-sm" 
                                    Width="100px" Text="导入SQL视图" OnClick="btnImportSqlViewFromSqlServer_Click"></asp:Button>
                            </li>
                            <li class="menu-bar-nav">
                                <asp:Button ID="btnAnalysis"  runat="server"  CssClass="btn btn-outline-info btn-sm" 
                                    Width="75px" Text="分析字段" OnClick="btnAnalysis_Click"></asp:Button>
                            </li>
<%--                            <li class="menu-bar-nav">
                                <a href="javascript:;">
                                    <asp:Label ID="Label12"  CssClass="btn btn-outline-info btn-sm" runat="server" Text="视图操作"></asp:Label>
                                    <i class="icon-font" style="margin-left: 5px;">&#xe60c;</i></a>

                                <ul class="menu-dropdown-menu">
                                    
                                </ul>
                            </li>--%>
                            <li class="menu-bar-nav"></li>
                            <li class="menu-bar-nav"></li>
                            <li class="menu-bar-nav">
                                <asp:Label ID="Label11" Width="10px" runat="server" Font-Bold="False"  Text=""></asp:Label>

                            </li>


                        </ul>

                    </div>

                </td>
            </tr>
            <tr>

                <td style="width: 50%">
                    <div style="width: 100%; position: relative; left: 0px; top: 0px;" id="divGridFunction">

                        <table style="width: 100%">
                            <tr>
                                <td colspan="2">&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Label ID="lblPrjTabFldList" runat="server" CssClass="h6">代码系统中表字段列表</asp:Label></td>
                            </tr>
                            <tr>
                                <td class="style1">
                                    <asp:Button ID="btnSetFldProperty" runat="server" OnClick="btnSetFldProperty_Click"
                                        Text="设置字段属性"  Width="100px" CssClass="btn btn-outline-warning btn-sm" /></td>
                                <td style="width: 340px"></td>
                            </tr>
                            <tr>
                                <td class="style1">
                                    <asp:Button ID="btnAddNewField" runat="server" Width="100px" CssClass="btn btn-outline-warning btn-sm"
                                        Text="添加新字段" OnClick="btnAddNewField_Click"></asp:Button></td>
                                <td style="width: 340px">
                                    <asp:Label ID="Label3" runat="server" CssClass="MemoStyle1" Width="328px">把所选SQL数据字段添加到生成代码系统中。</asp:Label></td>
                            </tr>
                            <tr>
                                <td class="style1">
                                    <asp:Button ID="btnSynchFldInfoToAgc" runat="server" CssClass="btn btn-outline-warning btn-sm" Text="同步字段信息"
                                        Width="100px" OnClick="btnSynchFldInfoToAgc_Click" /></td>
                                <td style="width: 340px">
                                    <asp:Label ID="Label7" runat="server" CssClass="MemoStyle1" Width="350px">同步字段：把所选SQL数据表字段同步到系统表字段中。</asp:Label></td>
                            </tr>
                            <tr>
                                <td class="style1">
                                    <asp:Button ID="btnDelRec" runat="server" OnClick="btnDelRec_Click" Text="删除表字段" Width="100px" CssClass="btn btn-outline-warning btn-sm" /></td>
                                <td style="width: 340px">
                                    <asp:Label ID="Label8" runat="server" CssClass="MemoStyle1" Width="327px">删除：把所选代码系统中字段删除。</asp:Label></td>
                            </tr>
                        </table>
                    </div>

                </td>
                <td style="width: 50%">
                    <table style="width: 100%">
                        <tr>
                            <td colspan="2"></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="Label2" runat="server" CssClass="h6">SQL数据库表字段列表</asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 70px"></td>
                            <td style="width: 280px"></td>
                        </tr>
                        <tr>
                            <td style="width: 70px">
                                <asp:Button ID="btnAddFieldToSqlTable" runat="server" CssClass="btn btn-outline-warning btn-sm"
                                    OnClick="btnAddFieldToSqlTable_Click" Text="添加新字段"
                                    Width="100px" /></td>
                            <td style="width: 5px">
                                <asp:Label ID="Label4" runat="server" CssClass="MemoStyle1" Width="293px">把系统中字段添加到SQL数据表中。</asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 70px">
                                <asp:Button ID="btnSynchFldInfo" runat="server" CssClass="btn btn-outline-warning btn-sm" Text="同步字段信息"
                                    Width="100px" OnClick="btnSynchFldInfo_Click" /></td>
                            <td style="width: 5px">
                                <asp:Label ID="Label6" runat="server" CssClass="MemoStyle1" Width="293px">把系统中字段属性同步到SQL数据表中。</asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 70px">
                                <asp:Button ID="btnDelField_Sql" runat="server" OnClick="btnDelField_Sql_Click" Text="删除表字段"
                                    Width="100px" CssClass="btn btn-outline-warning btn-sm" /></td>
                            <td style="width: 5px">
                                <asp:Label ID="Label9" runat="server" CssClass="MemoStyle1" Width="327px">删除：把所选Sql字段删除。</asp:Label></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="vertical-align: top">
                    <asp:GridView ID="gvPrjTabFld_Agc" Style="z-index: 113; position: relative;" runat="server"
                        Width="100%" AutoGenerateColumns="False" AllowSorting="True"
                        OnSorting="gvPrjTabFld_Sorting" OnPageIndexChanging="gvPrjTabFld_PageIndexChanging"
                        OnRowCreated="gvPrjTabFld_RowCreated" OnRowCommand="gvPrjTabFld_RowCommand"
                        BackColor="White" BorderColor="#E7E7FF"
                        BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="1px"
                        DataKeyNames="mId" CssClass="table table-striped table-bordered table-condensed">
                        <Columns>
                            <asp:TemplateField HeaderText="全选">
                                <HeaderTemplate>
                                    <asp:LinkButton ID="lbSelAll" runat="server" CommandName="lbSelAll" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                                </HeaderTemplate>
                                <HeaderStyle Width="35px" />
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="mId" SortExpression="mId" HeaderText="mId" Visible="False"></asp:BoundField>
                            <asp:BoundField DataField="SequenceNumber" SortExpression="SequenceNumber" HeaderText="顺序号" Visible="False"></asp:BoundField>
                            <asp:BoundField DataField="TabName" SortExpression="TabName" HeaderText="表名" Visible="False"></asp:BoundField>
                            <asp:BoundField DataField="TabId" SortExpression="TabId" HeaderText="表ID" Visible="False"></asp:BoundField>
                            <asp:BoundField DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundField>
                            <asp:BoundField DataField="DataTypeName" SortExpression="DataTypeName" HeaderText="类型"></asp:BoundField>
                            <asp:BoundField DataField="FldLength" SortExpression="FldLength" HeaderText="长度"></asp:BoundField>
                            <asp:BoundField DataField="FldPrecision" SortExpression="FldPrecision" HeaderText="小数"></asp:BoundField>
                            <asp:BoundField DataField="IsTabNullable" SortExpression="IsTabNullable" HeaderText="可空"></asp:BoundField>
                            <asp:BoundField DataField="Caption" SortExpression="Caption" HeaderText="标题"></asp:BoundField>
                            <asp:BoundField DataField="FieldTypeName" HeaderText="字段类型" ></asp:BoundField>
                            <asp:BoundField DataField="FldId" SortExpression="FldId" HeaderText="字段ID" Visible="False"></asp:BoundField>
                            <asp:BoundField DataField="DefaultValue" SortExpression="DefaultValue" HeaderText="缺省值" Visible="False"></asp:BoundField>
                            <asp:BoundField HeaderText="结果" />
                        </Columns>
                        <PagerTemplate>
                            <span class="text-secondary">共有记录:</span>
                            <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                Width="46px">0</asp:Label>
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
                            <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                                ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                        </PagerTemplate>
                        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <AlternatingRowStyle BackColor="#F7F7F7" />
                        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    </asp:GridView>

                </td>
                <td style="vertical-align: top">
                    <asp:GridView ID="gvPrjTabFld_Sql" Style="z-index: 113; position: relative;" runat="server"
                        Width="100%" AutoGenerateColumns="False" AllowSorting="True"
                        OnSorting="gvPrjTabFld_Sql_Sorting" OnPageIndexChanging="gvPrjTabFld_Sql_PageIndexChanging"
                        OnRowCreated="gvPrjTabFld_Sql_RowCreated" OnRowCommand="gvPrjTabFld_Sql_RowCommand"
                        BackColor="White" BorderColor="#E7E7FF"
                        BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="1px"
                        DataKeyNames="Column_Name" CssClass="table table-striped table-bordered table-condensed">
                        <Columns>
                            <asp:TemplateField HeaderText="全选">
                                <HeaderTemplate>
                                    <asp:LinkButton ID="lbSelAll" runat="server" CommandName="lbSelAll" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                                </HeaderTemplate>
                                <HeaderStyle Width="35px" />
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkCheckRec" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Column_Name" HeaderText="字段名" SortExpression="Column_Name" />
                            <asp:BoundField DataField="Type_Name" HeaderText="类型" SortExpression="Type_Name" />
                            <asp:BoundField DataField="Length" HeaderText="长度" SortExpression="Length" />
                            <asp:BoundField DataField="scale" HeaderText="小数" SortExpression="scale" />
                            <asp:BoundField DataField="Is_Nullable" HeaderText="可空" SortExpression="Is_Nullable" />
                            <asp:BoundField HeaderText="检查结果" />
                        </Columns>
                        <PagerTemplate>
                            <span class="text-secondary">共有记录:</span>
                            <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                Width="46px">0</asp:Label>
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
                            <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                                ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                        </PagerTemplate>
                        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <AlternatingRowStyle BackColor="#F7F7F7" />
                        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />

                    </asp:GridView>

                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <div style="width: 614px; position: relative; height: 52px; left: 0px; top: 3px;" id="divNewTab" runat="server">
                        <asp:Label ID="lblMsg2" runat="server" CssClass="text-warning" Height="35px" Style="z-index: 105; left: 0px; position: relative; top: 0px">SQL数据库中不存在相应表：</asp:Label>
                        &nbsp;
                        <asp:Button ID="btnGenNewTabInSQL" runat="server" CssClass="btn btn-outline-info btn-sm" Style="z-index: 105; left: 197px; position: absolute; top: 4px"
                            Text="生成新表" Width="71px" OnClick="btnGenNewTabInSQL_Click" />
                        &nbsp;
                        <asp:Label ID="Label5" runat="server" CssClass="MemoStyle1" Height="25px" Style="z-index: 105; left: 82px; position: relative; top: 1px">在SQL数据库添加相关表。</asp:Label>
                        <br />
                        <asp:Button ID="btnCheckSqlView0" runat="server" CssClass="btn btn-outline-info btn-sm" Text="查看视图详细信息" Width="169px" OnClick="btnCheckSqlView_Click" />
                        <asp:Button ID="btnCreateView4Sql1"  runat="server"
                            Width="105px" CssClass="btn btn-outline-info btn-sm" Text="建立视图4Sql" OnClick="btnCreateView4Sql_Click"></asp:Button>

                    </div>
                </td>

            </tr>

        </table>

        <script src="../../Scripts/jquery-3.6.0.min.js"></script>
        <script type="text/javascript" src="../../js/tz_MenuButton/tz_sccl.js"></script>
        <script type="text/javascript" src="../../js/tz_MenuButton/tz_sccl-util.js"></script>
        <input type="hidden" name="FunName" />
        <input type="hidden" name="hidLangType" />
        <input type="hidden" name="hidDataBaseType" />
    </form>
</body>
</html>
