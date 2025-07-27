<%@ Register TagPrefix="uc1" TagName="wucSqlDataSynB" Src="wucSqlDataSynB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmSqlDataSynB_QUDI.aspx.cs" 
    Inherits="AGC.Webform.wfmSqlDataSynB_QUDI" EnableEventValidation ="false" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sql数据同步维护的维护</title>
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
    <script src="../../js/agc.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >Sql数据同步维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td>
                            <asp:Label ID="lblTabNameq" 
                                runat="server" CssClass="text-secondary">表名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtTabNameq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblTabTypeIdq" 
                                runat="server" CssClass="text-secondary">表类型Id</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTabTypeIdq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click" 
                                runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="设置导出字段"></asp:Button>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblSqlCommandTypeIdq" 
                                runat="server" CssClass="text-secondary">Sql命令类型Id</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlSqlCommandTypeIdq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
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
                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 116; Width: 80px; "
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" 
                                runat="server"  CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                    
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>

            <div id="divList" class="div_List"
                runat="server">
                <table id="tabGridFunction" style="width: 100%; height: 32px" class="msgtable">
                    <tr>
                        <td>
                            <asp:Label ID="lblSqlDataSynList" runat="server" 
                                CssClass="h6" Width="192px">Sql数据同步列表</asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click"  runat="server"
                                Width="50px" CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click"  runat="server"
                                Width="50px" CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnImportParaTab" OnClick="btnImportParaTab_Click"  runat="server"
                                Width="90px" CssClass="btn btn-outline-info btn-sm" Text="导入参数表"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnImportSqlDataFromSqlServer"  runat="server"
                                Width="121px" CssClass="btn btn-outline-info btn-sm" Text="导入数据从SQL库" OnClick="btnImportSqlDataFromSqlServer_Click"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnShowSqlData"  runat="server"
                                Width="100px" CssClass="btn btn-outline-info btn-sm" Text="显示Sql数据" OnClick="btnShowSqlData_Click"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnEditSynchField"  runat="server"
                                Width="110px" CssClass="btn btn-outline-info btn-sm" Text="编辑同步字段" OnClick="btnEditSynchField_Click"></asp:Button>
                        </td>
                          <td>
                            <asp:Button ID="btnSynData"  runat="server"
                                 CssClass="btn btn-outline-info btn-sm" Text="同步数据" OnClick="btnSynData_Click"></asp:Button>
                              
                        </td>
                        <td><asp:CheckBox ID="chkIsUpdate" runat="server" Text="是否修改相同标识记录" /></td>
                    </tr>
                </table>
                <asp:GridView ID="gvSqlDataSyn" Style="z-index: 117;" runat="server"
                    Width="100%" AutoGenerateColumns="False"
                    PageSize="10" AllowPaging="true"
                    AllowSorting="true"
                    OnSorting="gvSqlDataSyn_Sorting"
                    OnPageIndexChanging="gvSqlDataSyn_PageIndexChanging"
                    OnRowCreated="gvSqlDataSyn_RowCreated"
                    OnRowCommand="gvSqlDataSyn_RowCommand"
                    OnRowDeleting="gvSqlDataSyn_RowDeleting"
                    OnRowUpdating="gvSqlDataSyn_RowUpdating"
                    BackColor="White"
                    BorderColor="#E7E7FF"
                    BorderStyle="None"
                    BorderWidth="1px"
                    CellPadding="3"
                    GridLines="Horizontal"
                    Height="1px"
                    DataKeyNames="TabId"
                    CssClass="table table-striped table-bordered table-condensed">
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
                        <asp:BoundField DataField="TabId" SortExpression="TabId" HeaderText="表ID"></asp:BoundField>
                        <asp:BoundField DataField="TabName" SortExpression="TabName" HeaderText="表名"></asp:BoundField>
                        <asp:BoundField DataField="TabCnName" SortExpression="TabCnName" HeaderText="表中文名"></asp:BoundField>
                        <asp:BoundField DataField="SqlData" SortExpression="SqlData" HeaderText="Sql表数据" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="SqlCommandTypeId" SortExpression="SqlCommandTypeId" HeaderText="Sql命令类型Id" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="SqlCommandTypeName" SortExpression="SqlCommandTypeName" HeaderText="Sql命令类型名称"></asp:BoundField>
                        <asp:BoundField DataField="SqlCommandText" SortExpression="SqlCommandText" HeaderText="Sql命令内容"></asp:BoundField>
                        <asp:BoundField DataField="FieldNum" SortExpression="FieldNum" HeaderText="字段数"></asp:BoundField>
                        <asp:BoundField DataField="SqlDataRecNum" SortExpression="SqlDataRecNum" HeaderText="Sql数据记录数"></asp:BoundField>
                        <asp:BoundField DataField="TargetTabCondition" SortExpression="TargetTabCondition" HeaderText="目标表有效记录条件"></asp:BoundField>
                        <asp:BoundField DataField="TargetTabRecNum" SortExpression="TargetTabRecNum" HeaderText="目标表记录数"></asp:BoundField>
                        <asp:BoundField DataField="DataSynDate" SortExpression="DataSynDate" HeaderText="同步日期"></asp:BoundField>
                        <asp:BoundField DataField="TextResouce" SortExpression="TextResouce" HeaderText="文本来源" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="TextResourceTypeId" SortExpression="TextResourceTypeId" HeaderText="文本来源类型Id" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="TabTypeId" SortExpression="TabTypeId" HeaderText="表类型Id" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="PrimaryTypeName" SortExpression="PrimaryTypeName" HeaderText="主键类型"></asp:BoundField>
                        <asp:BoundField DataField="RecExclusiveWayName" SortExpression="RecExclusiveWayName" HeaderText="排他方式"></asp:BoundField>
                        <asp:BoundField DataField="TabTypeName" SortExpression="TabTypeName" HeaderText="表类型名"></asp:BoundField>
                        <asp:BoundField DataField="FuncModuleAgcId" SortExpression="FuncModuleAgcId" HeaderText="功能模块Id" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="功能模块名称"></asp:BoundField>
                        <asp:BoundField DataField="AnalysisDate" SortExpression="AnalysisDate" HeaderText="分析日期" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="PrjId" SortExpression="PrjId" HeaderText="工程ID" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="PrjName" SortExpression="PrjName" HeaderText="工程名称" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="UpdUserId" SortExpression="UpdUserId" HeaderText="修改用户Id" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="ErrMsg" SortExpression="ErrMsg" HeaderText="错误信息"></asp:BoundField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="修改"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <PagerTemplate>
                        <span class="text-secondary">共有记录:</span>
                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="46px">0</asp:Label>
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
                            ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
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
            <div id="tabEditSqlDataSynRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditSqlDataSyn"  runat="server"
                                    CssClass="h6">Sql数据同步编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit"  runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                &nbsp;
                                <asp:Button ID="btnCancelSqlDataSynEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelSqlDataSynEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucSqlDataSynB ID="wucSqlDataSynB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
