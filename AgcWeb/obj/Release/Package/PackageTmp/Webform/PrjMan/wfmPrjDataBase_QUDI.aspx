<%@ Register TagPrefix="uc1" TagName="wucPrjDataBase" Src="wucPrjDataBase.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmPrjDataBase_QUDI.aspx.cs"
    Inherits="AGC.Webform.wfmPrjDataBase_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>PrjDataBase的维护</title>
    

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
                <td>
                    <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="h5">PrjDataBase表的维护
                        </asp:Label>
                        <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                            Width="347px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <table style="width: 80%">
                        <tr>
                            <td style="text-align: right">
                                <asp:Label ID="lblPrjDataBaseNameq" runat="server" CssClass="text-secondary">项目数据库名</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtPrjDataBaseNameq" runat="server" Width="160px"
                                    CssClass="Textbox_Defa"></asp:TextBox>
                            </td>
                            <td style="text-align: right">
                                <asp:Label ID="lblDataBaseNameq" runat="server" Width="70px"
                                    CssClass="text-secondary">数据库名</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtDataBaseNameq"  runat="server" Width="160px"
                                    CssClass="Textbox_Defa"></asp:TextBox>
                            </td>

                            <td style="text-align: right">
                                <asp:Label ID="lblDatabaseOwnerq"  runat="server" CssClass="text-secondary">数据库拥有者</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtDatabaseOwnerq"  runat="server" Width="160px"
                                    CssClass="Textbox_Defa"></asp:TextBox>
                            </td>
                            <td style="text-align: right">
                                <asp:Label ID="lblDataBaseTypeIdq"  runat="server" CssClass="text-secondary">数据库类型ID</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlDataBaseTypeIdq"  runat="server" Width="160px"
                                    CssClass="Textbox_Defa">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right">
                                <asp:Label ID="lblDataBaseUserIdq" Style="z-index: 116;" runat="server" CssClass="text-secondary">数据库的用户ID</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtDataBaseUIdq" Style="z-index: 118;" runat="server" Width="160px"></asp:TextBox>
                            </td>
                            <td style="text-align: right">
                                <asp:Label ID="lblIpAddressq" Style="z-index: 119;" runat="server" Width="70px"
                                    CssClass="text-secondary">服务器</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtIpAddressq" Style="z-index: 120;" runat="server" Width="160px"
                                    CssClass="Textbox_Defa"></asp:TextBox>
                            </td>

                            <td style="text-align: right">
                                <asp:Label ID="lblUseStateId" runat="server" CssClass="col-form-label text-right">使用状态</asp:Label>
                            </td>
                            <td align="left">
                                <asp:DropDownList ID="ddlUseStateId" runat="server" class="form-control-sm" Width="160px">
                                </asp:DropDownList>
                            </td>
                            <td style="text-align: right">
                                <asp:Button ID="btnQuery" Style="z-index: 128;" runat="server"
                                    Text="查询" CssClass="btn btn-outline-warning btn-sm" OnClick="btnQuery_Click"></asp:Button>
                            </td>
                            <td align="left">
                                <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click"
                                    runat="server" CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabPrjDataBaseGridView" style="width: 100%" runat="server">
                        <tr>
                            <td>
                                <table style="width: 750px; height: 32px" id="tabGridFunction">
                                    <tr>
                                        <td class="style3">
                                            <asp:Label ID="lblPrjDataBaseList" runat="server" CssClass="h6">数据库对象列表</asp:Label>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click"
                                                CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnCloneTab" runat="server" OnClick="btnCloneTab_Click" Text="克隆"
                                                Width="45px" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click"
                                                runat="server" CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click"
                                                runat="server" CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnSetInUse"
                                                runat="server" CssClass="btn btn-outline-info btn-sm" Text="设置使用" OnClick="btnSetInUse_Click"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnSetNotInUse"
                                                runat="server" CssClass="btn btn-outline-info btn-sm" Text="设置不使用" OnClick="btnSetNotInUse_Click"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnRefreshBuffer" OnClick="btnRefreshBuffer_Click"
                                                runat="server" CssClass="btn btn-outline-info btn-sm" Text="刷新缓存"></asp:Button>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="gvPrjDataBase" Style="z-index: 129;" runat="server" Width="100%"
                                    AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True" OnSorting="gvPrjDataBase_Sorting"
                                    OnPageIndexChanging="gvPrjDataBase_PageIndexChanging" OnRowCreated="gvPrjDataBase_RowCreated"
                                    OnRowCommand="gvPrjDataBase_RowCommand" OnRowDeleting="gvPrjDataBase_RowDeleting"
                                    OnRowUpdating="gvPrjDataBase_RowUpdating" BackColor="White" BorderColor="#E7E7FF"
                                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="1px"
                                    DataKeyNames="PrjDataBaseId" CssClass="table table-striped table-bordered table-condensed">
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
                                        <asp:BoundField DataField="PrjDataBaseId" SortExpression="PrjDataBaseId" HeaderText="项目数据库Id"></asp:BoundField>
                                        <asp:BoundField DataField="PrjDataBaseName" SortExpression="PrjDataBaseName" HeaderText="项目数据库名"></asp:BoundField>
                                        <asp:BoundField DataField="DataBaseTypeName" SortExpression="DataBaseTypeName" HeaderText="数据库类型名"></asp:BoundField>
                                        <asp:BoundField DataField="IpAddress" SortExpression="IpAddress" HeaderText="服务器"></asp:BoundField>
                                        <asp:BoundField DataField="DataBaseName" SortExpression="DataBaseName" HeaderText="数据库名"></asp:BoundField>
                                        <asp:BoundField DataField="DatabaseOwner" SortExpression="DatabaseOwner" HeaderText="数据库拥有者"></asp:BoundField>
                                        <asp:BoundField DataField="DataBaseUserId" SortExpression="DataBaseUserId" HeaderText="数据库的用户ID"></asp:BoundField>
                                        <asp:BoundField DataField="TableSpace" SortExpression="TableSpace" Visible="false" HeaderText="表空间"></asp:BoundField>
                                        <asp:BoundField DataField="Sid" SortExpression="Sid" Visible="false" HeaderText="Sid"></asp:BoundField>
                                        <asp:BoundField DataField="UserId" SortExpression="UserId" Visible="false" HeaderText="用户ID"></asp:BoundField>
                                        <asp:BoundField DataField="UseStateName" SortExpression="UseStateName" HeaderText="使用状态"></asp:BoundField>
                                        <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
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
                                        <span class="text-secondary">页记录数:</span>
                                        <asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="DropDown_DefaInPager"
                                            Width="41px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                            <asp:ListItem>15</asp:ListItem>
                                            <asp:ListItem>20</asp:ListItem>
                                            <asp:ListItem>30</asp:ListItem>
                                            <asp:ListItem>50</asp:ListItem>
                                            <asp:ListItem>100</asp:ListItem>
                                            <asp:ListItem>1000</asp:ListItem>
                                            <asp:ListItem></asp:ListItem>
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
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditPrjDataBaseRegion" style="z-index: 129; width: 750px" cellspacing="1"
                        cellpadding="1" width="750" border="1" runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="lblEditPrjDataBase" runat="server" CssClass="h6">数据库对象编辑区域</asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblMsgEdit" runat="server" Width="208px" CssClass="text-warning"></asp:Label>
                            </td>
                            <td>
                                <asp:Button ID="btnOKUpd" runat="server" Text="添加"
                                    OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnCancelPrjDataBaseEdit" runat="server" Width="100px"
                                    CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelPrjDataBaseEdit_Click"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnTestConnect" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnTestConnect_Click"
                                    Text="测试连接" Width="131px" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <uc1:wucPrjDataBase ID="wucPrjDataBase1" runat="server" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
