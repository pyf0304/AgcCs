<%@ Page Language="c#" CodeBehind="wfmSetModuleTabRela.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmSetModuleTabRela" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表FuncModule_Agc的查询、修改、删除、添加记录</title>
    
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

        <table id="tabTitle" style="z-index: 101; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Bold="True" ForeColor="White" Font-Names="宋体"
                        Font-Size="Small">表字段管理->设置模块表关系</asp:Label></td>
            </tr>
        </table>
        <table id="tabPrjTab4Sel" style="z-index: 104; left: 496px; width: 376px; position: absolute; top: 56px; height: 389px"
            bordercolor="#000033" cellspacing="1" cellpadding="1"
            width="376" border="4" runat="server">
            <tr>
                <td>
                    <asp:Label ID="lblTabNameq" runat="server"
                        Width="70px">表名</asp:Label></td>
                <td style="width: 94px">
                    <asp:TextBox ID="txtTabNameq" runat="server" Width="94px"></asp:TextBox></td>
                <td>
                    <asp:Label ID="lblTabCnNameq" runat="server"
                        Width="70px">中文表名</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtTabCnNameq" runat="server" Width="95px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblObjIdq" runat="server"
                        Width="70px">对象编号</asp:Label></td>
                <td colspan="2">
                    <asp:DropDownList ID="ddlObjIdq" runat="server" Width="175px">
                    </asp:DropDownList></td>
                <td>
                    <asp:Button ID="btnQuery_PrjTab" runat="server"  Width="69px" Text="查询" OnClick="btnQuery_PrjTab_Click"></asp:Button></td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:DataGrid ID="dgPrjTab4Sel" runat="server" Font-Names="宋体" Font-Size="Smaller"
                        Height="154px" Width="360px" AllowSorting="True" AllowPaging="True" AutoGenerateColumns="False"
                        GridLines="None" CellPadding="0" BackColor="White" BorderWidth="1px" BorderStyle="Ridge"
                        BorderColor="White" OnPageIndexChanged="dgPrjTab4Sel_PageIndexChanged">
                        <FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
                        <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
                        <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
                        <Columns>
                            <asp:TemplateColumn HeaderText="选择">
                                <HeaderStyle Width="20px"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:CheckBox ID="ckb1" runat="server"></asp:CheckBox>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn Visible="False" DataField="TabId" HeaderText="表编号"></asp:BoundColumn>
                            <asp:BoundColumn DataField="TabName" SortExpression="TabName" HeaderText="表名">
                                <HeaderStyle Font-Bold="True" ForeColor="White"></HeaderStyle>
                                <ItemStyle Font-Bold="True"></ItemStyle>
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="TabCnName" SortExpression="TabCnName" HeaderText="表中文名"></asp:BoundColumn>
                            <asp:BoundColumn DataField="PrjObjectsObjName" SortExpression="PrjObjectsObjName"
                                HeaderText="对象编号"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="DataBaseName" SortExpression="DataBaseName"
                                HeaderText="数据库名称"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="ProjectsPrjName" HeaderText="工程编号"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="Memo" HeaderText="说明"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="IsChecked" SortExpression="IsCheck" HeaderText="核实"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="IsArchive" SortExpression="IsArchive"
                                HeaderText="归档"></asp:BoundColumn>
                        </Columns>
                        <PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6" Mode="NumericPages"></PagerStyle>
                    </asp:DataGrid></td>
            </tr>
            <tr>
                <td colspan="4">
                    <div style="width: 334px; position: relative; height: 37px">
                        <asp:Label ID="Label1" Style="z-index: 101; left: 8px; position: absolute; top: 0px"
                            runat="server"  Width="53px">记录数：</asp:Label>
                        <asp:TextBox ID="txtRecCount4Sel" Style="z-index: 102; left: 64px; position: absolute; top: 0px"
                            runat="server"
                             ReadOnly="True"></asp:TextBox>
                        <asp:CheckBox ID="chkSelAll" Style="z-index: 103; left: 104px; position: absolute; top: 0px"
                            runat="server" Text="全选" AutoPostBack="True" OnCheckedChanged="chkSelAll_CheckedChanged"></asp:CheckBox>
                        <asp:Button ID="btnOKAdd" Style="z-index: 104; left: 160px; position: absolute; top: 0px"
                            runat="server"  Width="58px" Text="添加" OnClick="btnOKAdd_Click"></asp:Button>
                        <asp:Label ID="lblMsg" Style="z-index: 105; left: 224px; position: absolute; top: 0px"
                            runat="server" Width="109px"></asp:Label>
                    </div>
                </td>
            </tr>
        </table>
        <div id="divFuncModule" style="z-index: 102; left: 8px; width: 472px; position: absolute; top: 32px; height: 24px"
            runat="server">
            <asp:Label ID="lblFuncModuleNameq" Style="z-index: 104; left: 10px; position: absolute; top: 5px"
                runat="server"
                Width="88px">
  功能模块名称</asp:Label>
            <asp:TextBox ID="txtFuncModuleNameq" Style="z-index: 105; left: 112px; position: absolute; top: 0px"
                runat="server" Width="128px"></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 107; left: 264px; position: absolute; top: 0px"
                runat="server"  
                Text="查询" OnClick="btnQuery_Click"></asp:Button>
        </div>
        <table id="tabLayout" style="z-index: 105; left: 8px; width: 480px; position: absolute; top: 56px"
            cellspacing="0" cellpadding="0" width="480" border="0">
            <tr>
                <td valign="top">
                    <table id="tabFuncModuleDataGrid" style="width: 480px" cellspacing="0"
                        cellpadding="0" width="480" border="0" runat="server">
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgFuncModule" runat="server"
                                    Height="213px" Width="464px" AllowSorting="True" AllowPaging="True" AutoGenerateColumns="False"
                                    PageSize="15" CellPadding="4" ForeColor="#333333" GridLines="None" OnItemCommand="dgFuncModule_ItemCommand" OnItemCreated="dgFuncModule_ItemCreated" OnPageIndexChanged="dgFuncModule_PageIndexChanged" OnSelectedIndexChanged="dgFuncModule_SelectedIndexChanged" OnSortCommand="dgFuncModule_SortCommand">
                                    <Columns>
                                        <asp:BoundColumn DataField="FuncModuleAgcId" SortExpression="FuncModuleAgcId" HeaderText="功能模块Id"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="功能模块名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="TabNum" SortExpression="TabNum" HeaderText="相关表数"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewNum" SortExpression="ViewNum" HeaderText="相关界面数"></asp:BoundColumn>
                                        <asp:ButtonColumn Text="选择" CommandName="Select"></asp:ButtonColumn>
                                    </Columns>
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center"></PagerStyle>
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <EditItemStyle BackColor="#999999" />
                                    <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                                    <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td style="width: 605px" bgcolor="silver">
                                <table id="tabFuncModuleJumpPage" style="width: 464px; font-family: Verdana; height: 35px"
                                    cellspacing="0" cellpadding="0" width="464" border="1" runat="server">
                                    <tr>
                                        <td class="Label_DefaInPager">
                                            <font style="background-color: #c0c0c0">共有记录:</font>
                                            <asp:Label ID="lblFuncModuleRecCount" runat="server" ForeColor="#000066" Width="46px">0</asp:Label><font
                                                style="background-color: #c0c0c0">总页数:</font>
                                            <asp:Label ID="lblFuncModuleAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 8px; height: 13px">
                                            </div>
                                            <font style="background-color: #c0c0c0">当前页:
                                                        <asp:Label ID="lblFuncModuleCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 8px; height: 13px">
                                                </div>
                                                <asp:Button ID="btnFuncModulePrevPage" runat="server"
                                                     Text="上一页" OnClick="btnFuncModulePrevPage_Click"></asp:Button><asp:Button ID="btnFuncModuleNextPage" runat="server"
                                                        Width="50px" Text="下一页" OnClick="btnFuncModuleNextPage_Click"></asp:Button>到第
                                                        <asp:TextBox ID="txtFuncModuleJump2Page" runat="server"
                                                            Width="32px"></asp:TextBox>页
                                                        <asp:Button ID="btnFuncModuleJumpPage" runat="server"
                                                            Width="35px" Text="确定" OnClick="btnFuncModuleJumpPage_Click"></asp:Button><asp:CompareValidator ID="FuncModuleCompareValidator1"
                                                                runat="server" ForeColor="DarkOrange" Width="8px" Operator="DataTypeCheck" Type="Integer"
                                                                ControlToValidate="txtFuncModuleJump2Page" ErrorMessage="错误！"></asp:CompareValidator></font></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 605px"></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    <table id="tabPrjTab" style="width: 472px" cellspacing="0" cellpadding="0" width="472"
                        border="1" runat="server">
                        <tr>
                            <td colspan="2">
                                <div style="width: 472px; position: relative; height: 24px">
                                    <div id="divObjName" style="display: inline; z-index: 101; left: 8px; width: 240px; color: #009933; line-height: normal; font-family: Verdana; position: absolute; top: 8px; height: 16px"
                                        runat="server">
                                        <p>
                                            所选对象的所有字段信息
                                        </p>
                                    </div>
                                    <asp:LinkButton ID="lbDispObjList" Style="z-index: 102; left: 272px; position: absolute; top: 8px"
                                        runat="server"  OnClick="lbDispObjList_Click">显示对象列表</asp:LinkButton>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:DataGrid ID="dgPrjTab" runat="server"
                                    Height="210px" Width="472px" AllowSorting="True" AllowPaging="True" AutoGenerateColumns="False"
                                    CellPadding="3" BackColor="#DEBA84" BorderWidth="1px" BorderStyle="None" BorderColor="#DEBA84"
                                    CellSpacing="2" PageSize="15" OnItemCommand="dgPrjTab_ItemCommand" OnPageIndexChanged="dgPrjTab_PageIndexChanged">
                                    <FooterStyle ForeColor="#8C4510" BackColor="#F7DFB5"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#738A9C"></SelectedItemStyle>
                                    <ItemStyle ForeColor="#8C4510" BackColor="#FFF7E7"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#A55129"></HeaderStyle>
                                    <Columns>
                                        <asp:BoundColumn Visible="False" DataField="MId" HeaderText="编号"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="TabId" HeaderText="表编号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="TabName" SortExpression="TabName" HeaderText="表名">
                                            <HeaderStyle Font-Bold="True" ForeColor="White"></HeaderStyle>
                                            <ItemStyle Font-Bold="True"></ItemStyle>
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="TabCnName" SortExpression="TabCnName" HeaderText="表中文名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ObjName" SortExpression="ObjName" HeaderText="对象编号"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="DataBaseName" SortExpression="DataBaseName"
                                            HeaderText="数据库名称"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="PrjName" HeaderText="工程编号"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="Memo" HeaderText="说明"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="IsChecked" SortExpression="IsCheck" HeaderText="核实"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="IsArchive" SortExpression="IsArchive"
                                            HeaderText="归档"></asp:BoundColumn>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Center" ForeColor="#8C4510" Mode="NumericPages"></PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td>
                                <div style="display: inline; width: 120px; color: #009933; line-height: normal; font-family: Verdana; height: 16px">
                                    <p>
                                        所选对象的字段数：
                                    </p>
                                </div>
                                <asp:TextBox ID="txtRecCount4PrjTab" runat="server"
                                    Width="111px" ReadOnly="True"></asp:TextBox></td>
                            <td>
                                <asp:LinkButton ID="lbAddFld" runat="server" OnClick="lbAddFld_Click">添加字段</asp:LinkButton></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
