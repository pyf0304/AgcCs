<%@ Page Language="c#" CodeBehind="wfmActionForward_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmActionForward_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucActionForward" Src="wucActionForward.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表ActionForward的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <table id="tabTitle" style="z-index: 101; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                        Font-Bold="True">ActionForward维护</asp:Label>
                    <asp:Label ID="lblActionId_q" runat="server" Width="56px"
                        ForeColor="#004040">
  ActionId：</asp:Label>
                    <asp:Label ID="lblActionName" runat="server"
                        Width="70px"></asp:Label>
                </td>
            </tr>
        </table>
        <div id="divActionForward" style="z-index: 102; left: 8px; width: 720px; position: absolute; top: 32px; height: 32px"
            runat="server">
            <asp:Label ID="lblForwardName_q" Style="z-index: 102; left: 8px; position: absolute; top: 8px"
                runat="server" Width="88px">
  Forward名称</asp:Label>
            <asp:TextBox ID="txtForwardName_q" Style="z-index: 103; left: 88px; position: absolute; top: 5px"
                runat="server" Width="96px"></asp:TextBox>
            <asp:Label ID="lblForwardPath_q" Style="z-index: 104; left: 216px; position: absolute; top: 8px"
                runat="server" >
  Forward路径</asp:Label>
            <asp:TextBox ID="txtForwardPath_q" Style="z-index: 105; left: 304px; position: absolute; top: 5px"
                runat="server" Width="176px"></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 106; left: 560px; position: absolute; top: 4px"
                runat="server"  
                Text="查询"></asp:Button>
        </div>
        <table id="Table1" style="z-index: 105; left: 8px; position: absolute; top: 72px"
            cellspacing="0" cellpadding="0" width="300" border="0">
            <tr>
                <td>
                    <table id="tabActionForwardDataGrid" style="width: 568px" cellspacing="0"
                        cellpadding="0" width="568" border="0" runat="server">
                        <tr>
                            <td style="width: 701px; height: 23px">
                                <div style="display: inline; width: 744px; position: relative; height: 24px">
                                    <asp:Button ID="btnAddNewRec4Dg1" Style="z-index: 102; left: 408px; position: absolute; top: 0px"
                                        runat="server"   Text="添加"></asp:Button>
                                    <asp:Button ID="btnDelete4Dg" Style="z-index: 100; left: 488px; position: absolute; top: 0px"
                                        runat="server"   Text="删除"></asp:Button>
                                    <asp:Button ID="btnUpdate4Dg" Style="z-index: 101; left: 568px; position: absolute; top: 0px"
                                        runat="server"   Text="修改"></asp:Button>
                                    <asp:Button ID="btnExportExcel4Dg" Style="z-index: 104; left: 648px; position: absolute; top: 0px"
                                        runat="server"   Text="导出Excel"></asp:Button>
                                    <asp:Button ID="btnGetRelaForward" Style="z-index: 105; left: 216px; position: absolute; top: 0px"
                                        runat="server"  Width="161px" Text="获取界面组相关Forward"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 701px">
                                <asp:DataGrid ID="dgActionForward" runat="server"
                                    Width="752px" AllowSorting="True" AllowPaging="True" AutoGenerateColumns="False"
                                    BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White"
                                    CellPadding="3" GridLines="Horizontal">
                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                    <Columns>
                                        <asp:TemplateColumn HeaderText="选择">
                                            <HeaderStyle Width="15px"></HeaderStyle>
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server">全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="ActionForwardId" SortExpression="ActionForwardId" HeaderText="ActionForwardId"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="ActionName" SortExpression="ActionName"
                                            HeaderText="ActionId"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ForwardName" SortExpression="ForwardName" HeaderText="Forward名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ForwardPath" SortExpression="ForwardPath" HeaderText="Forward路径"></asp:BoundColumn>
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
                            <td style="width: 701px" bgcolor="silver">
                                <table id="tabActionForwardJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                                    cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                    <tr>
                                        <td>
                                            <font style="background-color: #c0c0c0">共有记录:</font>
                                                <asp:Label ID="lblActionForwardRecCount" runat="server" ForeColor="#000066" Width="46px">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">总页数:</font>
                                                <asp:Label ID="lblActionForwardAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">当前页:
                                                        <asp:Label ID="lblActionForwardCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <asp:Button ID="btnActionForwardPrevPage" runat="server"
                                                        Width="50px" Text="上一页"></asp:Button>
                                                    <asp:Button ID="btnActionForwardNextPage" runat="server"
                                                        Width="50px" Text="下一页"></asp:Button>到第
                                                        <asp:TextBox ID="txtActionForwardJump2Page" runat="server"
                                                            Width="35px"></asp:TextBox>页
                                                        <asp:Button ID="btnActionForwardJumpPage" runat="server"
                                                            Width="35px" Text="确定"></asp:Button>
                                                    <asp:CompareValidator ID="ActionForwardCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                        Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtActionForwardJump2Page"
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
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditActionForwardRegion" style="width: 373px; height: 200px" cellspacing="1"
                        cellpadding="1" width="373" border="1">
                        <tr>
                            <td>
                                <div style="width: 360px; position: relative; height: 24px">
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                                        runat="server"  
                                        Text="添加"></asp:Button>
                                    <asp:Label ID="lblMsg" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                                        runat="server" Width="208px"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucActionForward ID="wucActionForward1" runat="server"></uc1:wucActionForward>
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
        </table>

    </form>
</body>
</html>
