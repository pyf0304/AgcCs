<%@ Register TagPrefix="uc1" TagName="wucUserTabB" Src="wucUserTabB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmAuditRegisterUsers.aspx.cs" Inherits="AGC.Webform.wfmAuditRegisterUsers" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>审核注册用户</title>
    
    <script src="../../JS/tzPubFun.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 90%">
                    <tr>

                        <td>
                            <asp:Label ID="lblUserNameq" 
                                runat="server" CssClass="text-secondary">用户姓名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtUserNameq" 
                                runat="server" CssClass="TextBox_Defa" Width="120px"></asp:TextBox>
                        </td>



                        <td>
                            <asp:Label ID="lblIdentityIDq" 
                                runat="server" CssClass="text-secondary">用户身份</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIdentityIDq" 
                                runat="server" CssClass="TextBox_Defa" Width="120px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblIdentityID_q0" 
                                runat="server" CssClass="text-secondary">是否审核</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsAudit" 
                                runat="server" CssClass="TextBox_Defa" Width="50px">
                            </asp:DropDownList>
                        </td>
                        <td>

                            &nbsp;</td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblCategoryIDq" 
                                runat="server" CssClass="text-secondary">部门</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlDepartmentId" 
                                runat="server" CssClass="TextBox_Defa" Width="200px" >
                            </asp:DropDownList>
                        </td>
                     

                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 113; width: 80px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="6">
                            <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                                Width="347px"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                     
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>

            <div id="divList" class="div_List"
                runat="server">
                <table id="tabGridFunction" style="width: 100%; height: 32px" class="msgtable">
                    <tr>
                        <td style="width: 100%;">
                            <asp:Label ID="lblUserTabList" runat="server" 
                                CssClass="h6" Width="250px"></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="Button1" runat="server" 
                                 CssClass="btn btn-outline-info btn-sm" Text="审核" OnClick="Button1_Click"></asp:Button>
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
                        <%-- <td>
                            <asp:Button ID="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click" 
                                runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="设置导出字段"></asp:Button>
                        </td>--%>
                    </tr>
                </table>
                <asp:GridView ID="gvUserTab"  runat="server"
                    Width="100%" AutoGenerateColumns="False"
                    PageSize="10" AllowPaging="true"
                    AllowSorting="true"
                    OnSorting="gvUserTab_Sorting"
                    OnPageIndexChanging="gvUserTab_PageIndexChanging"
                    OnRowCreated="gvUserTab_RowCreated"
                    OnRowCommand="gvUserTab_RowCommand"
                    OnRowDeleting="gvUserTab_RowDeleting"
                    OnRowUpdating="gvUserTab_RowUpdating"
                    BackColor="White"
                    BorderColor="#E7E7FF"
                    BorderStyle="None"
                    BorderWidth="1px"
                    CellPadding="3"
                    GridLines="None"
                    Height="1px"
                    DataKeyNames="UserId"
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
                        <asp:BoundField DataField="UserId" SortExpression="UserId" HeaderText="登录名"></asp:BoundField>
                        <asp:BoundField DataField="UserName" SortExpression="UserName" HeaderText="用户姓名"></asp:BoundField>
                        <asp:BoundField DataField="Password" SortExpression="Password" HeaderText="口令"></asp:BoundField>
                        <asp:BoundField DataField="DepartmentName" SortExpression="DepartmentName" HeaderText="部门"></asp:BoundField>
         
                        <asp:BoundField DataField="IdentityDesc" SortExpression="IdentityDesc" HeaderText="用户身份"></asp:BoundField>
                        <asp:BoundField DataField="IsAudit" SortExpression="IsAudit" HeaderText="是否审核"></asp:BoundField>
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
                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="22px">0</asp:Label>
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
            <div id="tabEditUserTabRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditUserTab"  runat="server"
                                    CssClass="h6">UserTab编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit"  runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                &nbsp;
                                <asp:Button ID="btnCancelUserTabEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelUserTabEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucUserTabB ID="wucUserTabB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
