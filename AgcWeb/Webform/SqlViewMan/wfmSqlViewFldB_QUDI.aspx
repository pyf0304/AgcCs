<%@ Register TagPrefix="uc1" TagName="wucSqlViewFldB" Src="wucSqlViewFldB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmSqlViewFldB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmSqlViewFldB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sql视图字段维护的维护</title>
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >Sql视图字段维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td>
                            <asp:Label ID="lblSqlViewIdq" 
                                runat="server" CssClass="text-secondary">Sql视图Id</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlSqlViewIdq" 
                                runat="server" CssClass="TextBox_Defa" AutoPostBack="True" OnSelectedIndexChanged="ddlSqlViewId_q_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblRelaTabIdq" 
                                runat="server" CssClass="text-secondary">相关表Id</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlRelaTabIdq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblTabNameq" 
                                runat="server" CssClass="text-secondary">表名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtTabNameq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblFldNameq" 
                                runat="server" CssClass="text-secondary">字段名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFldNameq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 119; Width: 80px; "
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" 
                                runat="server"  CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                            <asp:Button ID="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click" 
                                runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="设置导出字段"></asp:Button>
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
                            <asp:Label ID="lblSqlViewFldList" runat="server" 
                                CssClass="h6" Width="250px">Sql视图字段列表</asp:Label>
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
                            <asp:Button ID="btnGoFirstLine"  runat="server" 
                                Text="首行" OnClick="btnGoFirstLine_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnUpMove"  runat="server"  Text="上移"
                                OnClick="btnUpMove_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnDownMove"  runat="server"  Text="下移"
                                OnClick="btnDownMove_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnGoLastLine"  runat="server" 
                                Text="尾行" OnClick="btnGoLastLine_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnReOrder"  runat="server"  Text="重序"
                                OnClick="btnReOrder_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </td>

                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <asp:GridView ID="gvSqlViewFld" Style="z-index: 120;" runat="server"
                    Width="100%" AutoGenerateColumns="False"
                    PageSize="10" AllowPaging="true"
                    AllowSorting="true"
                    OnSorting="gvSqlViewFld_Sorting"
                    OnPageIndexChanging="gvSqlViewFld_PageIndexChanging"
                    OnRowCreated="gvSqlViewFld_RowCreated"
                    OnRowCommand="gvSqlViewFld_RowCommand"
                    OnRowDeleting="gvSqlViewFld_RowDeleting"
                    OnRowUpdating="gvSqlViewFld_RowUpdating"
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
                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="序号"></asp:BoundField>
                        <asp:BoundField DataField="mId" SortExpression="mId" HeaderText="mId" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="RelaTabId" SortExpression="RelaTabId" HeaderText="相关表Id" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="TabName" SortExpression="TabName" HeaderText="表名"></asp:BoundField>
                        <asp:BoundField DataField="TabAliases" SortExpression="TabAliases" HeaderText="别名"></asp:BoundField>
                        <asp:BoundField DataField="TabCnName" SortExpression="TabCnName" HeaderText="表中文名"></asp:BoundField>
                        <asp:BoundField DataField="FldId" SortExpression="FldId" HeaderText="字段ID" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundField>
                        <asp:BoundField DataField="FldCnName" SortExpression="FldCnName" HeaderText="字段中文详名"></asp:BoundField>
                        <asp:BoundField DataField="FieldAliases" SortExpression="FieldAliases" HeaderText="字段别名"></asp:BoundField>
                        <asp:BoundField DataField="Filters" SortExpression="Filters" HeaderText="筛选器"></asp:BoundField>
                        <asp:BoundField DataField="PrjId" SortExpression="PrjId" HeaderText="工程ID" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="SqlViewId" SortExpression="SqlViewId" HeaderText="Sql视图Id" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="SqlViewName" SortExpression="SqlViewName" HeaderText="数据视图名称"></asp:BoundField>
                        <asp:BoundField DataField="SqlViewCNName" SortExpression="SqlViewCNName" HeaderText="Sql视图中文名"></asp:BoundField>
                        <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="UpdUserId" SortExpression="UpdUserId" HeaderText="修改用户Id" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明" Visible="false"></asp:BoundField>
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
            <div id="tabEditSqlViewFldRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditSqlViewFld"  runat="server"
                                    CssClass="h6">Sql视图字段编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit"  runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                &nbsp;
                                <asp:Button ID="btnCancelSqlViewFldEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelSqlViewFldEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucSqlViewFldB ID="wucSqlViewFldB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
