<%@ Register TagPrefix="uc1" TagName="wucFuncModule" Src="wucFuncModule.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmFuncModule_QUDI.aspx.cs"
    Inherits="AGC.Webform.wfmFuncModule_QUDI" EnableEventValidation="false" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>FuncModule_Agc的维护</title>
    
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
                    <div style="position: relative; width: 794px; height: 37px; left: 0px; top: 0px;">
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="h5">FuncModule_Agc表的维护
                        </asp:Label>
                        <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105; left: 187px; position: relative; top: 4px"
                            Width="347px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <table style="width: 80%;">
                        <tr>
                            <td style="text-align: right">
                                <asp:Label ID="lblPrjIdq" runat="server" Width="36px" CssClass="text-secondary">工程</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="166px"
                                    CssClass="Textbox_Defa">
                                </asp:DropDownList>
                            </td>
                            <td style="text-align: right">
                                <asp:Label ID="lblFuncModuleNameq" runat="server" Width="88px"
                                    CssClass="text-secondary">功能模块名称</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtFuncModuleNameq" runat="server" Width="98px"
                                    CssClass="Textbox_Defa"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>

                            <td style="text-align: right">
                                <asp:Label ID="lblUseStateId" runat="server" CssClass="col-form-label text-right">使用状态</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlUseStateId" runat="server" class="form-control-sm" Width="160px">
                                </asp:DropDownList>
                            </td>
                            <td style="text-align: right">
                                <asp:Label ID="lblFuncModuleEnNameq" runat="server" Width="119px"
                                    CssClass="text-secondary">功能模块英文名</asp:Label>
                            </td>
                            <td align="left">
                                <asp:TextBox ID="txtFuncModuleEnNameq" runat="server" Width="161px"
                                    CssClass="Textbox_Defa"></asp:TextBox>
                            </td>
                            <td></td>
                            <td>
                                <asp:Button ID="btnQuery" Style="z-index: 113; left: 709px;" runat="server"
                                    Text="查询" CssClass="btn btn-outline-warning btn-sm" OnClick="btnQuery_Click"></asp:Button>
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
                    <table id="tabFuncModuleGridView" style="width: 100%" runat="server">
                        <tr>
                            <td>
                                <table style="width: 100%;">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblFuncModuleList" runat="server" CssClass="h6"
                                                Width="200px">功能模块列表</asp:Label>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click"
                                                CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
                                        </td>
                                        <td></td>
                                        <td>
                                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click"
                                                runat="server" CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                                        </td>
                                        <td></td>
                                        <td>
                                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click"
                                                runat="server" CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnGoTop" runat="server"
                                                Text="移顶" OnClick="btnGoTop_Click" CssClass="btn btn-outline-info btn-sm" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnUpMove" runat="server" OnClick="btnUpMove_Click"
                                                Text="上移" CssClass="btn btn-outline-info btn-sm" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnDownMove" runat="server" OnClick="btnDownMove_Click"
                                                Text="下移" CssClass="btn btn-outline-info btn-sm" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnGoBottum" runat="server"
                                                Text="移底" OnClick="btnGoBottum_Click" CssClass="btn btn-outline-info btn-sm" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnReOrder" runat="server" OnClick="btnReOrder_Click"
                                                Text="重序" CssClass="btn btn-outline-info btn-sm" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click"
                                                runat="server" CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                                        </td>
                                        <td></td>
                                        <td></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="gvFuncModule" Style="z-index: 114; position: relative;" runat="server"
                                    Width="100%" AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True"
                                    OnSorting="gvFuncModule_Sorting" OnPageIndexChanging="gvFuncModule_PageIndexChanging"
                                    OnRowCreated="gvFuncModule_RowCreated" OnRowCommand="gvFuncModule_RowCommand"
                                    OnRowDeleting="gvFuncModule_RowDeleting" OnRowUpdating="gvFuncModule_RowUpdating"
                                    BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
                                    CellPadding="3" GridLines="Horizontal" Height="1px" DataKeyNames="FuncModuleAgcId"
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
                                        <asp:BoundField DataField="FuncModuleAgcId" SortExpression="FuncModuleAgcId" HeaderText="功能模块Id"></asp:BoundField>
                                        <asp:BoundField DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="功能模块名称"></asp:BoundField>
                                        <asp:BoundField DataField="FuncModuleEnName" SortExpression="FuncModuleEnName" HeaderText="功能模块英文名称"></asp:BoundField>
                                        <asp:BoundField DataField="PrjName" SortExpression="PrjName" HeaderText="工程名称" Visible="false"></asp:BoundField>

                                        <asp:BoundField DataField="TabNum" SortExpression="TabNum" HeaderText="表数"></asp:BoundField>
                                        <asp:BoundField DataField="ViewNum" SortExpression="ViewNum" HeaderText="界面数"></asp:BoundField>
                                        <asp:BoundField DataField="UpdUser" SortExpression="UpdUser" HeaderText="修改用户"></asp:BoundField>
                                        <asp:BoundField DataField="UseStateName" SortExpression="UseStateName" HeaderText="使用状态"></asp:BoundField>
                                        <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明" Visible="False"></asp:BoundField>
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
                    <table id="tabEditFuncModuleRegion" style="z-index: 114; width: 750px" cellspacing="1"
                        cellpadding="1" width="750" border="1" runat="server">
                        <tr>
                            <td>
                                <div>
                                    <ul class="nav">
                                        <li class="nav-item">
                                            <asp:Label ID="lblEditFuncModule" runat="server" CssClass="h6">功能模块编辑区域</asp:Label>
                                        </li>


                                        <li class="nav-item ml-3">
                                            <asp:Button ID="btnOKUpd" runat="server" Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                        </li>

                                        <li class="nav-item ml-3">
                                            <asp:LinkButton ID="lbDispFuncModuleList" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="lbDispFuncModuleList_Click">显示功能模块列表</asp:LinkButton>
                                        </li>
                                        <li class="nav-item ml-3">
                                            <asp:Label ID="lblMsgEdit" runat="server" Width="208px" CssClass="text-warning"></asp:Label>
                                        </li>

                                    </ul>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucFuncModule ID="wucFuncModule1" runat="server"></uc1:wucFuncModule>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
