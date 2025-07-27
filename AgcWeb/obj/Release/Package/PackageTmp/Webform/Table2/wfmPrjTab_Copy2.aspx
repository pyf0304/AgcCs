<%@ Page Language="c#" CodeBehind="wfmPrjTab_Copy2.aspx.cs" AutoEventWireup="True" Inherits="AGC.Webform.wfmPrjTab_Copy2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表PrjTab的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <table id="tabTitle" style="z-index: 101; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Bold="True" ForeColor="White" Font-Names="宋体"
                        Font-Size="Small">工程表的复制</asp:Label>
                </td>
            </tr>
        </table>
        <table style="z-index: 104; left: 10px; width: 830px; position: absolute; top: 35px">
            <tr>
                <td style="width: 826px">
                    <div id="divPrjTab" style="width: 821px; height: 78px" runat="server">
                        <asp:Label ID="lblTabIdq" Style="z-index: 100; left: 10px; position: absolute; top: 10px"
                            runat="server" Width="32px" CssClass="text-secondary">
  表ID</asp:Label>
                        <asp:TextBox ID="txtTabIdq" Style="z-index: 101; left: 85px; position: absolute; top: 5px"
                            runat="server" Width="120px"></asp:TextBox>
                        <asp:Label ID="lblTabNameq" Style="z-index: 102; left: 260px; position: absolute; top: 10px"
                            runat="server" Width="32px" CssClass="text-secondary">
  表名</asp:Label>
                        <asp:TextBox ID="txtTabNameq" Style="z-index: 103; left: 344px; position: absolute; top: 5px"
                            runat="server" Width="144px"></asp:TextBox>
                        <asp:Label ID="lblTabCnNameq" Style="z-index: 104; left: 511px; position: absolute; top: 10px"
                            runat="server" Width="70px" CssClass="text-secondary">
  表中文名</asp:Label>
                        <asp:TextBox ID="txtTabCnNameq" Style="z-index: 105; left: 595px; position: absolute; top: 5px"
                            runat="server" Width="130px"></asp:TextBox>
                        <asp:Label ID="lblPrjIdq" Style="z-index: 106; left: 8px; position: absolute; top: 32px"
                            runat="server" Width="47px" CssClass="text-secondary">
  源工程</asp:Label>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="ddlPrjIdq" Style="z-index: 108; left: 84px; position: absolute; top: 32px"
                                    runat="server" Width="128px" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                                <asp:Label ID="Label5" Style="z-index: 114; left: 260px; position: absolute; top: 39px"
                                    runat="server" Width="56px" CssClass="text-secondary">模块编号</asp:Label>
                                <asp:DropDownList ID="ddlFuncModuleId" Style="z-index: 115; left: 343px; position: absolute; top: 33px"
                                    runat="server" Width="387px">
                                </asp:DropDownList>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <asp:Label ID="lblDataBaseNameq" Style="z-index: 107; left: 10px; position: absolute; top: 65px"
                            runat="server" Width="70px" CssClass="text-secondary">数据库名</asp:Label>
                        <asp:TextBox ID="txtDataBaseNameq" Style="z-index: 108; left: 84px; position: absolute; top: 62px"
                            runat="server" Width="152px"></asp:TextBox>
                        &nbsp;&nbsp;
                                <asp:Button ID="btnQuery" Style="z-index: 111; left: 503px; position: absolute; top: 65px"
                                    runat="server"  Text="查询" OnClick="btnQuery_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                    </div>
                </td>
            </tr>
            <tr>
                <td style="width: 826px"></td>
            </tr>
            <tr>
                <td style="width: 826px">
                    <div id="divGvPrjTab" style="width: 821px;" runat="server">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <div style="width: 785px; position: relative; height: 34px; left: 0px; top: 0px;">
                                    &nbsp;
                                <asp:Button ID="btnCopyPrjTab" Style="z-index: 105; left: 611px; position: absolute; top: 7px"
                                    runat="server"  Text="复制工程表" CssClass="btn btn-outline-info btn-sm" OnClick="btnCopyPrjTab_Click"></asp:Button>
                                    <asp:Button ID="btnExportExcel4Dg" Style="z-index: 107; left: 696px; position: absolute; top: 7px"
                                        runat="server"  Text="导出Excel" CssClass="btn btn-outline-info btn-sm" OnClick="btnExportExcel4Dg_Click"></asp:Button>
                                    <asp:Label ID="lblMsg" Style="z-index: 110; left: 225px; position: absolute; top: 8px"
                                        runat="server" Width="292px" CssClass="text-warning"></asp:Label>
                                    <asp:Label ID="lblPrjTabList" runat="server" CssClass="h6"
                                        Style="z-index: 111; left: 7px; position: absolute; top: 9px" Width="106px">工程表列表</asp:Label>
                                </div>
                                <asp:GridView ID="gvPrjTab" runat="server" AllowPaging="True" AllowSorting="True"
                                    AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                                    BorderWidth="1px" CellPadding="3" CssClass="table table-striped table-bordered table-condensed" DataKeyNames="TabId" GridLines="Horizontal" OnPageIndexChanging="gvPrjTab_PageIndexChanging" OnRowCommand="gvPrjTab_RowCommand"
                                    OnRowCreated="gvPrjTab_RowCreated" OnSorting="gvPrjTab_Sorting" Width="815px">
                                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
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
                                        <asp:BoundField DataField="TabId" HeaderText="表ID" SortExpression="TabId" />
                                        <asp:BoundField DataField="TabName" HeaderText="表名" SortExpression="TabName" />
                                        <asp:BoundField DataField="TabCnName" HeaderText="表中文名" SortExpression="TabCnName" />
                                        <asp:BoundField DataField="PrjName" HeaderText="工程名称" SortExpression="PrjName" />
                                        <asp:BoundField DataField="DataBaseName" HeaderText="数据库名" SortExpression="DataBaseName"
                                            Visible="False" />
                                        <asp:BoundField DataField="TabStateName" HeaderText="表状态名称" SortExpression="TabStateName"
                                            Visible="False" />
                                        <asp:BoundField DataField="Memo" HeaderText="说明" SortExpression="Memo" Visible="False" />
                                    </Columns>
                                    <PagerTemplate>
                                        <font style="background-color: #c0c0c0">共有记录:</font>
                                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                            Width="46px">0</asp:Label>
                                        <span style="background-color: #c0c0c0">
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                        </span><font style="background-color: #c0c0c0">总页数:</font>
                                        <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <font style="background-color: #c0c0c0">当前页:
                                        <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnPrevPage" runat="server" CommandArgument="Prev" CommandName="Page"
                                            CssClass="btn btn-outline-warning btn-sm small" Text="上一页" Width="50px" /><span style="font-family: Verdana">
                                            </span>
                                        <asp:Button ID="btnNextPage" runat="server" CommandArgument="Next" CommandName="Page"
                                            CssClass="btn btn-outline-warning btn-sm small" Text="下一页" Width="50px" />
                                        到第
                                        <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
                                        <asp:Button ID="btnJumpPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" OnClick="btnJumpPage_Click" Text="确定" Width="35px" />
                                        <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                                            ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator></font>
                                        <asp:Button ID="Button1" runat="server" Text="Button" />
                                    </PagerTemplate>
                                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <AlternatingRowStyle BackColor="#F7F7F7" />
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
