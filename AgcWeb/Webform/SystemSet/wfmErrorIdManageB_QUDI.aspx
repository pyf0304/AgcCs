<%@ Register TagPrefix="uc1" TagName="wucErrorIdManageB" Src="wucErrorIdManageB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmErrorIdManageB_QUDI.aspx.cs" 
    Inherits="AGC.Webform.wfmErrorIdManageB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>错误Id管理维护的维护</title>
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >错误Id管理维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td>
                            <asp:Label ID="lblErrIDq" 
                                runat="server" CssClass="text-secondary">错误Id</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtErrIDq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                    

                        <td>
                            <asp:Label ID="lblCodeTypeIdq" 
                                runat="server" CssClass="text-secondary">程序分层类型</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlCodeTypeIdq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblPrefixq" 
                                runat="server" CssClass="text-secondary">前缀</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPrefixq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                            <td>
                                &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblFunctionNameq" Style="z-index: 119;"
                                runat="server" CssClass="text-secondary">功能名称</asp:Label>
                        </td>
                        <td colspan="3">
                            <asp:TextBox ID="txtFunctionNameq" Style="z-index: 120;"
                                runat="server" CssClass="TextBox_Defa" Width="434px"></asp:TextBox>
                        </td>

                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 122; width: 80px;"
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
                            <asp:Label ID="lblErrorIdManageList" runat="server" 
                                CssClass="h6" Width="250px">错误Id管理列表</asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" 
                                Width="58px" CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
                        </td>
                           <td>
                            <asp:Button ID="btnRefAddNewRec4Gv" runat="server" OnClick="btnRefAddNewRec4Gv_Click" 
                                Width="92px" CssClass="btn btn-outline-info btn-sm" Text="参考并添加"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click"  runat="server"
                                CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click"  runat="server"
                                Width="65px" CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" 
                                runat="server" Width="89px" CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click" 
                                runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="设置导出字段"></asp:Button>
                        </td>
                    </tr>
                </table>
                <asp:GridView ID="gvErrorIdManage" Style="z-index: 123;" runat="server"
                    Width="100%" AutoGenerateColumns="False"
                    PageSize="10" AllowPaging="true"
                    AllowSorting="true"
                    OnSorting="gvErrorIdManage_Sorting"
                    OnPageIndexChanging="gvErrorIdManage_PageIndexChanging"
                    OnRowCreated="gvErrorIdManage_RowCreated"
                    OnRowCommand="gvErrorIdManage_RowCommand"
                    OnRowDeleting="gvErrorIdManage_RowDeleting"
                    OnRowUpdating="gvErrorIdManage_RowUpdating"
                    BackColor="White"
                    BorderColor="#E7E7FF"
                    BorderStyle="None"
                    BorderWidth="1px"
                    CellPadding="3"
                    GridLines="Horizontal"
                    Height="1px"
                    DataKeyNames="mId"
                    CssClass="table table-striped table-bordered table-condensed">
                    <Columns>
                        <asp:TemplateField HeaderText="全选">
                            <HeaderStyle Width="35px" />
                            <HeaderTemplate>
                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <a name="A_ErrorIdManage<%# Eval("mId").ToString().Trim() %>"></a>
                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="mId" SortExpression="mId" HeaderText="mId"></asp:BoundField>
                        <asp:BoundField DataField="ErrID" SortExpression="ErrID" HeaderText="错误Id"></asp:BoundField>
                        <asp:BoundField DataField="CodeTypeId" SortExpression="CodeTypeId" HeaderText="程序分层类型" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="CodeTypeName" SortExpression="CodeTypeName" HeaderText="分层类型"></asp:BoundField>
                        <asp:BoundField DataField="CodeTypeENName" SortExpression="CodeTypeENName" HeaderText="程序分层类型英文名称"  Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="Prefix" SortExpression="Prefix" HeaderText="前缀"  Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="FunctionName" SortExpression="FunctionName" HeaderText="功能名称"></asp:BoundField>
                        <asp:BoundField DataField="Explanation" SortExpression="Explanation" HeaderText="详细说明"></asp:BoundField>
                        <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
                        <asp:BoundField DataField="UpdUserId" SortExpression="UpdUserId" HeaderText="修改用户Id"></asp:BoundField>
                        <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="备注"  Visible="false"></asp:BoundField>
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
            <div id="tabEditErrorIdManageRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditErrorIdManage"  runat="server"
                                    CssClass="h6">错误Id管理编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit"  runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                &nbsp;
                                <asp:Button ID="btnCancelErrorIdManageEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelErrorIdManageEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucErrorIdManageB ID="wucErrorIdManageB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
