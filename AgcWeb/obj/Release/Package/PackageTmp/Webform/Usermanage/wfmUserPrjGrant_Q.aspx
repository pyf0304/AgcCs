<%@ Page Language="c#" CodeBehind="wfmUserPrjGrant_Q.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmUserPrjGrant_Q" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表Users的查询修改记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <asp:Label ID="Label4" Style="z-index: 101; left: 16px; position: absolute; top: 8px"
            runat="server"  CssClass="h5">用户管理-->用户工程授权查询</asp:Label>
        <asp:Label ID="lblMsg2" Style="z-index: 104; left: 248px; position: absolute; top: 8px"
            runat="server" CssClass="text-warning" Width="248px"></asp:Label>

        <table id="tabLayout" style="z-index: 100; left: 8px; position: absolute; top: 32px"
            cellspacing="1" cellpadding="1" width="300" border="0" runat="server">
            <tr>
                <td>
                    <table id="Table1" style="width: 664px; height: 53px" cellspacing="1" cellpadding="1"
                        width="664" border="0">
                        <tr>
                            <td style="width: 57px">

                                <asp:Label ID="lblUserIdq" runat="server" Width="39px">用户号</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtUserIdq" runat="server" Width="152px"></asp:TextBox></td>
                            <td>
                                <asp:Label ID="lblRoleIdq" runat="server" Width="54px">用户角色</asp:Label></td>
                            <td>
                                <asp:DropDownList ID="ddlRoleIdq" runat="server" Width="168px">
                                </asp:DropDownList></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td style="width: 57px">
                                <asp:Label ID="lblUserNameq" runat="server" >用户名</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtUserNameq" runat="server" Width="152px"></asp:TextBox></td>
                            <td>
                                <asp:Label ID="lblPrjIdq" runat="server" Width="56px">项目名称</asp:Label></td>
                            <td>
                                <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="168px">
                                </asp:DropDownList></td>
                            <td></td>
                            <td></td>
                            <td>
                                <asp:Button ID="btnQuery" runat="server"  Text="查询" OnClick="btnQuery_Click"></asp:Button></td>
                        </tr>
                    </table>

                </td>
            </tr>
            <tr>
                <td>

                    <table id="tabUserPrj" style="height: 32px" bordercolor="burlywood" cellspacing="1"
                        cellpadding="1" width="300" border="4" runat="server">
                        <tr>
                            <td colspan="3">
                                <div style="width: 792px; position: relative; height: 26px">
                                    <asp:Label ID="lblUserName" Style="z-index: 100; left: 0px; position: absolute; top: 8px"
                                        runat="server" CssClass="h6">用户工程授权列表</asp:Label>
                                    <asp:Label ID="Label6" Style="z-index: 103; left: 384px; position: absolute; top: 8px"
                                        runat="server" ForeColor="Navy">用户新角色</asp:Label>
                                    <asp:DropDownList ID="ddlRoleId_New" Style="z-index: 104; left: 456px; position: absolute; top: 4px"
                                        runat="server" Width="128px">
                                    </asp:DropDownList>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:DataGrid ID="dgUserPrjGrant" runat="server" Font-Names="宋体" Height="154px" Width="816px"
                                    GridLines="Horizontal" CellPadding="3" BackColor="White" BorderWidth="1px" BorderColor="#E7E7FF"
                                    AutoGenerateColumns="False" AllowPaging="True" BorderStyle="None" PageSize="15"
                                    AllowSorting="True" OnItemCommand="dgUserPrjGrant_ItemCommand">
                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                    <Columns>
                                        <asp:BoundColumn Visible="False" DataField="mId" HeaderText="编号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserName" SortExpression="UserName" HeaderText="用户名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrjName" SortExpression="PrjName" HeaderText="项目名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="RoleName" SortExpression="RoleName" HeaderText="角色"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="VisitedNum" SortExpression="VisitedNum" HeaderText="访问数"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Memo" HeaderText="备注"></asp:BoundColumn>
                                        <asp:ButtonColumn Text="设置角色" HeaderText="功能列" CommandName="Update"></asp:ButtonColumn>
                                        <asp:TemplateColumn HeaderText="功能列">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <PagerStyle NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="#4A3C8C"
                                        BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server"  Width="110px">查询结果记录数：</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtRecCount1" runat="server" Width="111px" ReadOnly="True"></asp:TextBox></td>
                            <td></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td></td>
            </tr>
        </table>
        <asp:Label ID="Label5" Style="z-index: 103; left: 504px; position: absolute; top: 8px"
            runat="server" Width="312px" CssClass="MemoStyle1">查询用户对工程的权限。</asp:Label>
    </form>
</body>
</html>
