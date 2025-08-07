<%@ Page Language="c#" CodeBehind="wfmViewGroup_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmViewGroup_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucViewGroup" Src="wucViewGroup.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>界面组维护</title>
    

    <script type="text/javascript" language="javascript">
<!--
    function radioClick() {
        if (document.Form1.RadioName != null) {
            for (i = 0; i < document.Form1.RadioName.length; i++) {
                if (document.Form1.RadioName[i].checked == true) {
                    document.Form1.rd.value = document.Form1.RadioName[i].value;
                }
            }
        }
    }
//-->
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
    <form id="Form1" method="post" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div id="divViewGroup" style="z-index: 104; left: 8px; width: 696px; position: absolute; top: 35px; height: 56px"
            runat="server">
            <asp:Label ID="lblViewGroupNameq" Style="z-index: 107; left: 8px; position: absolute; top: 8px"
                runat="server" Width="70px" CssClass="text-secondary">界面组名称</asp:Label>
            <asp:TextBox ID="txtViewGroupNameq" Style="z-index: 108; left: 88px; position: absolute; top: 5px"
                runat="server" Width="120px"></asp:TextBox>
            <asp:Label ID="lblPrjDomainq" Style="z-index: 122; left: 216px; position: absolute; top: 8px"
                runat="server"  CssClass="text-secondary">域/包名</asp:Label>
            <asp:TextBox ID="txtPrjDomainq" Style="z-index: 123; left: 272px; position: absolute; top: 5px"
                runat="server" Width="304px"></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 125; left: 600px; position: absolute; top: 32px"
                runat="server"  Text="查询" OnClick="btnQuery_Click"></asp:Button>
            <asp:Label ID="lblTableNameForProgq" Style="z-index: 126; left: 8px; position: absolute; top: 32px"
                runat="server" Width="70px" CssClass="text-secondary">编程用表名</asp:Label>
            <asp:TextBox ID="txtTableNameForProgq" Style="z-index: 127; left: 88px; position: absolute; top: 32px"
                runat="server" Width="488px"></asp:TextBox>
        </div>
        <input id="rd" style="z-index: 102; left: 896px; width: 24px; position: absolute; top: 48px; height: 22px"
            type="hidden" size="1" name="rd" runat="server">
        <input style="display: none; z-index: 103; left: 8px; position: absolute; top: 8px"
            type="radio" checked name="RadioName">
        <table id="Table1" style="z-index: 107; left: 8px; position: absolute; top: 96px"
            cellspacing="0" cellpadding="0" width="300" border="0">
            <tr>
                <td>
                    <table id="tabViewGroupDataGrid" style="width: 552px" cellspacing="0" cellpadding="0"
                        width="552" border="0" runat="server">
                        <tr>
                            <td style="height: 12px">
                                <div style="width: 832px; position: relative; height: 34px">
                                    <asp:Button ID="btnAddNewRec4Dg1" Style="z-index: 101; left: 128px; position: absolute; top: 0px"
                                        runat="server"  Width="72px" Text="添加" OnClick="btnAddNewRec4Dg_Click"></asp:Button>
                                    <asp:Button ID="btnExportExcel4Dg" Style="z-index: 102; left: 744px; position: absolute; top: 0px"
                                        runat="server"   Text="导出Excel" OnClick="btnExportExcel4Dg_Click"></asp:Button>
                                    <asp:Button ID="btnEditViewGroupFlds" Style="z-index: 103; left: 208px; position: absolute; top: 0px"
                                        runat="server"  Width="152px" Text="编辑界面组相关信息" OnClick="btnEditViewGroupFlds_Click"></asp:Button>
                                    <asp:Button ID="btnEditStrutsAction" Style="z-index: 104; left: 504px; position: absolute; top: 0px"
                                        runat="server"  Width="152px" Text="编辑StrutsAction" OnClick="btnEditStrutsAction_Click"></asp:Button>
                                    <asp:Button ID="btnEditActionForm" Style="z-index: 105; left: 360px; position: absolute; top: 0px"
                                        runat="server"  Width="120px" Text="编辑ActionForm" OnClick="btnEditActionForm_Click"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgViewGroup" runat="server" Width="816px" AllowSorting="True" AllowPaging="True"
                                    AutoGenerateColumns="False" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
                                    BackColor="White" CellPadding="3" GridLines="Horizontal" CssClass="table table-striped table-bordered table-condensed" OnItemCommand="dgViewGroup_ItemCommand" OnItemCreated="dgViewGroup_ItemCreated" OnPageIndexChanged="dgViewGroup_PageIndexChanged" OnSortCommand="dgViewGroup_SortCommand">
                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                    <Columns>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <input onclick="radioClick()" type="radio" value='<%# DataBinder.Eval(Container.DataItem, "ViewGroupId")%>'
                                                    name="RadioName">
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="ViewGroupId" SortExpression="ViewGroupId" HeaderText="界面组ID"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewGroupName" SortExpression="ViewGroupName" HeaderText="界面组名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="INTabName" SortExpression="INTabName" HeaderText="输入数据源表"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="INSqlDsTypeName" SortExpression="INSqlDsTypeName" HeaderText="输入数据源类型"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="OUTSqlDsTypeName" SortExpression="OUTSqlDsTypeName" HeaderText="输出数据源类型"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="OUTTabName" SortExpression="OUTTabName" HeaderText="输出数据源表"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrjDomain" SortExpression="PrjDomain" HeaderText="域/包名"></asp:BoundColumn>
                                        <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td style="width: 605px" bgcolor="silver">
                                <table id="tabViewGroupJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                                    cellspacing="0" cellpadding="0" width="568" border="1" runat="server" class="NameLabel">
                                    <tr>
                                        <td style="width: 566px">
                                            <font style="background-color: #c0c0c0">共有记录:</font>
                                            <asp:Label ID="lblViewGroupRecCount" runat="server" ForeColor="#000066" Width="46px">0</asp:Label>
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                            <font style="background-color: #c0c0c0">总页数:</font>
                                            <asp:Label ID="lblViewGroupAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                            <font style="background-color: #c0c0c0">当前页:
                                                    <asp:Label ID="lblViewGroupCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <asp:Button ID="btnViewGroupPrevPage" runat="server" Width="50px" Text="上一页" OnClick="btnViewGroupPrevPage_Click"></asp:Button>
                                                <asp:Button ID="btnViewGroupNextPage" runat="server" Width="50px" Text="下一页" OnClick="btnViewGroupNextPage_Click"></asp:Button>到第
                                                    <asp:TextBox ID="txtViewGroupJump2Page" runat="server" Width="35px"></asp:TextBox>页
                                                    <asp:Button ID="btnViewGroupJumpPage" runat="server" Width="35px" Text="确定" OnClick="btnViewGroupJumpPage_Click"></asp:Button>
                                                <asp:CompareValidator ID="ViewGroupCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                    Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtViewGroupJump2Page"
                                                    ErrorMessage="错误！"></asp:CompareValidator></font></font></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditViewGroupRegion" style="width: 373px; height: 200px" cellspacing="1"
                        cellpadding="1" width="373" border="1">
                        <tr>
                            <td>
                                <div style="width: 360px; position: relative; height: 24px">
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                                        runat="server"   Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                    <asp:Label ID="lblMsg" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                                        runat="server" Width="208px" CssClass="text-warning"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucViewGroup ID="wucViewGroup1" runat="server"></uc1:wucViewGroup>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </table>
        <asp:Label ID="lblViewTile" runat="server" Font-Bold="True" Style="z-index: 106; left: 8px; position: absolute; top: 8px"
            CssClass="h5">界面组维护</asp:Label>
    </form>
</body>
</html>
