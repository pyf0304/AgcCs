<%@ Page Language="c#" CodeBehind="wfmUserLinkRela_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.wfmUserLinkRela_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucUserLinkRela" Src="wucUserLinkRela.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>表UserLinkRela的查询、修改、删除、添加记录</title>

    

</head>
<body>
    <form id="Form1" method="post" runat="server">
        
        <table id="tbHide" style="z-index: 101; left: 47px; position: absolute; top: 882px"
            width="300" runat="server">
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                    
                        <asp:Label ID="lblLinkNameq" runat="server" Width="70px">
  连接名称</asp:Label></font></td>
                <td>
                    <asp:TextBox ID="txtLinkNameq" runat="server"  Width="70px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                    <asp:Label ID="lblSidq" runat="server" Width="70px">
  Sid</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtSidq" runat="server"  Width="70px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                    
                </td>
                <td>
                </td>
            </tr>
        </table>
        <asp:Label ID="lblViewTile" Style="z-index: 102; left: 13px; position: absolute;
            top: 10px" runat="server" Width="160px" CssClass="h5">UserLinkRela表的维护</asp:Label>
        &nbsp;
            <table id="Table2" style="z-index: 105; left: 2px; width: 896px; position: absolute;
                top: 27px" width="896">
                <tr>
                    <td>
                        <table id="tabUserLinkRelaTable" style="width: 823px" bordercolor="#3399ff" width="823"
                            border="4" runat="server">
                            <tr>
                                <td style="height: 50px">
                                    <div style="width: 806px; position: relative; height: 37px">
                                        <asp:Label ID="lblUserIdq" Style="z-index: 117; left: 17px; position: absolute;
                                            top: 8px" runat="server" >
  用户ID</asp:Label>
                                        <asp:TextBox ID="txtUserIdq" Style="z-index: 117; left: 75px; position: absolute;
                                            top: 7px" runat="server"  Width="70px"></asp:TextBox>
                                        <asp:Label ID="lblIpAddressq" Style="z-index: 117; left: 173px; position: absolute;
                                            top: 11px" runat="server" Width="70px">
  服务器</asp:Label>
                                        <asp:TextBox ID="txtIpAddressq" Style="z-index: 117; left: 240px; position: absolute;
                                            top: 8px" runat="server"  Width="92px"></asp:TextBox>
                                        <asp:Label ID="lblDataBaseTypeIdq" Style="z-index: 117; left: 361px; position: absolute;
                                            top: 10px" runat="server" Width="96px">
  数据库类型ID</asp:Label>
                                        <asp:DropDownList ID="ddlDataBaseTypeIdq" Style="z-index: 117; left: 475px; position: absolute;
                                            top: 7px" runat="server"  Width="98px">
                                        </asp:DropDownList>
                                        <asp:Button ID="btnQuery" Style="z-index: 117; left: 620px; position: absolute; top: 5px"
                                            runat="server"   Text="查询"></asp:Button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td style="height: 50px">
                                    <div style="width: 806px; position: relative; height: 37px">
                                        <asp:Button ID="btnAddNewRec4Dg1" Style="z-index: 102; left: 438px; position: absolute;
                                            top: 7px" runat="server"   Text="添加"></asp:Button>
                                        <asp:Button ID="btnUpdate4Dg" Style="z-index: 103; left: 528px; position: absolute;
                                            top: 7px" runat="server"   Text="修改"></asp:Button>
                                        <asp:Button ID="btnDelete4Dg" Style="z-index: 104; left: 619px; position: absolute;
                                            top: 7px" runat="server"   Text="删除"></asp:Button>
                                        <asp:Button ID="btnExportExcel4Dg" Style="z-index: 101; left: 712px; position: absolute;
                                            top: 6px" runat="server"   Text="导出Excel"></asp:Button>
                                        <asp:Label ID="lblRegionViewTitle" Style="z-index: 105; left: 10px; position: absolute;
                                            top: 8px" runat="server" Width="152px" CssClass="h6">用户链接类型列表：</asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td style="height: 39px" valign="top">
                                    <table id="tabUserLinkRelaDataGrid" style="width: 552px" cellspacing="0"
                                        cellpadding="0" width="552" border="0" runat="server">
                                        <tr>
                                            <td style="height: 8px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:DataGrid ID="dgUserLinkRela" Style="z-index: 138; left: 10px; top: 393px" runat="server"
                                                    Width="800px" AllowSorting="True" AllowPaging="True" AutoGenerateColumns="False"
                                                    BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White"
                                                    CellPadding="3" GridLines="Horizontal" UseAccessibleHeader="True">
                                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                                    <Columns>
                                                        <asp:TemplateColumn HeaderText="选择">
                                                            <HeaderStyle Width="30px"></HeaderStyle>
                                                            <HeaderTemplate>
                                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server">全选</asp:LinkButton>
                                                            </HeaderTemplate>
                                                            <ItemTemplate>
                                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                                            </ItemTemplate>
                                                        </asp:TemplateColumn>
                                                        <asp:BoundColumn DataField="UserId" SortExpression="UserId" HeaderText="用户ID"></asp:BoundColumn>
                                                        <asp:BoundColumn DataField="mID" SortExpression="mID" HeaderText="编号"></asp:BoundColumn>
                                                        <asp:BoundColumn DataField="DataBaseTypeId" SortExpression="DataBaseTypeId" HeaderText="数据库类型ID">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn DataField="IpAddress" SortExpression="IpAddress" HeaderText="服务器"></asp:BoundColumn>
                                                        <asp:BoundColumn DataField="DataBasePwd" SortExpression="DataBasePwd" HeaderText="数据库的用户口令">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn DataField="DataBaseUserId" SortExpression="DataBaseUserId" HeaderText="数据库的用户ID">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn DataField="DataBaseName" SortExpression="DataBaseName" HeaderText="数据库名">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn DataField="Sid" SortExpression="Sid" HeaderText="Sid"></asp:BoundColumn>
                                                        <asp:BoundColumn DataField="ConnectionString" SortExpression="ConnectionString" HeaderText="连接串">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn DataField="DataBaseTypeName" SortExpression="DataBaseTypeName" HeaderText="数据库类型名">
                                                        </asp:BoundColumn>
                                                        <asp:BoundColumn DataField="LinkName" SortExpression="LinkName" HeaderText="连接名称"></asp:BoundColumn>
                                                        <asp:BoundColumn DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundColumn>
                                                        <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                                        <asp:TemplateColumn>
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                                            </ItemTemplate>
                                                        </asp:TemplateColumn>
                                                    </Columns>
                                                    <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                                    </PagerStyle>
                                                </asp:DataGrid></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 605px" bgcolor="silver">
                                                <table id="tabUserLinkRelaJumpPage" style="width: 568px; font-family: Verdana;
                                                    height: 26px" cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                                    <tr>
                                                        <td>
                                                            <font style="background-color: #c0c0c0">共有记录:</font>
                                                                <asp:Label ID="lblUserLinkRelaRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                                                <div style="display: inline; width: 16px; height: 13px">
                                                                </div>
                                                                <font style="background-color: #c0c0c0">总页数:</font>
                                                                <asp:Label ID="lblUserLinkRelaAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                                <div style="display: inline; width: 16px; height: 13px">
                                                                </div>
                                                                <font style="background-color: #c0c0c0">当前页:
                                                                    <asp:Label ID="lblUserLinkRelaCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                                    <div style="display: inline; width: 16px; height: 13px">
                                                                    </div>
                                                                    <asp:Button ID="btnUserLinkRelaPrevPage" runat="server"  Width="50px"
                                                                        Text="上一页"></asp:Button><asp:Button ID="btnUserLinkRelaNextPage" runat="server" 
                                                                            Width="50px" Text="下一页"></asp:Button>到第
                                                                    <asp:TextBox ID="txtUserLinkRelaJump2Page" runat="server"  Width="35px"></asp:TextBox>页
                                                                    <asp:Button ID="btnUserLinkRelaJumpPage" runat="server"  Width="35px"
                                                                        Text="确定"></asp:Button><asp:CompareValidator ID="UserLinkRelaCompareValidator1" runat="server"
                                                                            ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtUserLinkRelaJump2Page"
                                                                            ErrorMessage="错误！"></asp:CompareValidator></font></font></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table id="tabEditUserLinkRela" style="border-left-color: #333300; border-bottom-color: #333300;
                            width: 816px; border-top-style: solid; border-top-color: #333300; border-right-style: solid;
                            border-left-style: solid; border-right-color: #333300; border-bottom-style: solid"
                            bordercolor="#333300" width="816" bgcolor="#ffffff" runat="server">
                            <tr>
                                <td style="height: 41px">
                                    <div style="width: 809px; position: relative; height: 33px">
                                        <asp:Label ID="Label1" Style="z-index: 101; left: 8px; position: absolute; top: 6px"
                                            runat="server" Width="205px">编辑数据库类型属性</asp:Label>
                                        <asp:Button ID="btnOKUpd" Style="z-index: 103; left: 544px; position: absolute; top: 4px"
                                            runat="server"   Text="添加"></asp:Button>
                                        <asp:LinkButton ID="lbDispObjList" Style="z-index: 104; left: 640px; position: absolute;
                                            top: 8px" runat="server" Width="121px">显示用户链接列表</asp:LinkButton>
                                    </div>
                                    <uc1:wucUserLinkRela ID="wucUserLinkRela1" runat="server"></uc1:wucUserLinkRela>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </font>
        <asp:Label ID="lblMsg" Style="z-index: 105; left: 256px; position: absolute; top: 8px"
            runat="server" Width="217px" CssClass="text-warning"></asp:Label>
    </form>
</body>
</html>
