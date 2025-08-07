<%@ Page Language="c#" CodeBehind="wfmUserPrjGrant_PrjMan.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmUserPrjGrant_PrjMan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>表Users的查询修改记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="Label4" Style="z-index: 101; left: 16px; position: absolute; top: 8px"
            runat="server" CssClass="h5" Width="240px" >工程用户管理—〉工程用户授权</asp:Label>
        <asp:Label ID="Label2" Style="z-index: 106; left: 16px; position: absolute; top: 40px"
            runat="server" CssClass="h6"  >工程名称：</asp:Label>
        <asp:Label ID="lblPrjName" Style="z-index: 105; left: 96px; position: absolute; top: 40px"
            runat="server" CssClass="RegionTitleH2" Width="176px" ></asp:Label>
        <table id="tabLayout" style="z-index: 100; left: 16px; position: absolute; top: 56px"
            cellspacing="1" cellpadding="1" width="300" border="0" runat="server">
            <tr>
                <td>
                    <table id="tabUserPrj" style="width: 736px" bordercolor="burlywood" cellspacing="1"
                        cellpadding="1" width="736" border="4" runat="server">
                        <tr>
                            <td colspan="3">
                                <div style="width: 720px; position: relative; height: 25px">
                                    <asp:Label ID="lblRegionViewTitle" Style="z-index: 100; left: 0px; position: absolute;
                                        top: 8px" runat="server" CssClass="h6" Width="96px" >工程用户列表</asp:Label>
                                    <asp:Label ID="lblRoleNew" Style="z-index: 101; left: 488px; position: absolute;
                                        top: 8px" runat="server"  ForeColor="Navy">用户新角色</asp:Label>
                                    <asp:DropDownList ID="ddlRoleId_New" Style="z-index: 102; left: 560px; position: absolute;
                                        top: 0px" runat="server" Width="128px" >
                                    </asp:DropDownList>
                                    <asp:Label ID="lblMsg2" Style="z-index: 107; left: 192px; position: absolute; top: 8px"
                                        runat="server" CssClass="text-warning"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:DataGrid ID="dgUserPrjGrant" runat="server" Width="720px" Height="154px" ForeColor="Black"
                                    Font-Names="宋体" AllowPaging="True" AutoGenerateColumns="False" BorderColor="Tan"
                                    BorderWidth="1px" BackColor="LightGoldenrodYellow" CellPadding="2" GridLines="None" OnItemCommand="dgUserPrjGrant_ItemCommand" OnItemCreated="dgUserPrjGrant_ItemCreated" OnPageIndexChanged="dgUserPrjGrant_PageIndexChanged">
                                    <FooterStyle BackColor="Tan"></FooterStyle>
                                    <SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
                                    <HeaderStyle Font-Bold="True" BackColor="Tan"></HeaderStyle>
                                    <Columns>
                                        <asp:BoundColumn Visible="False" DataField="mId" HeaderText="编号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserId" SortExpression="UserId" HeaderText="用户Id"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserName" SortExpression="UserName" HeaderText="用户名"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="PrjName" SortExpression="PrjName" HeaderText="项目名称">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="VisitedNum" SortExpression="VisitedNum" HeaderText="访问数">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="Memo" HeaderText="备注"></asp:BoundColumn>
                                        <asp:ButtonColumn Text="设置角色" HeaderText="功能列" CommandName="Update"></asp:ButtonColumn>
                                        <asp:TemplateColumn HeaderText="功能列">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <PagerStyle NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Center" ForeColor="DarkSlateBlue"
                                        BackColor="PaleGoldenrod"></PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td style="width: 1px">
                                <asp:Label ID="Label1" runat="server" Width="110px" >查询结果记录数：</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtRecCount1" runat="server" Width="111px"  ReadOnly="True"></asp:TextBox></td>
                            <td>
                                <asp:Button ID="Btn_AddNewUser" runat="server" Width="88px" Text="添加用户" OnClick="Btn_AddNewUser_Click"></asp:Button></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabUser" style="width: 720px" bordercolor="#996666" cellspacing="1" cellpadding="1"
                        width="720" border="4" runat="server">
                        <tr>
                            <td colspan="3" valign="top">
                                <div style="width: 689px; position: relative; height: 25px">
                                    <asp:Label ID="Label9" Style="z-index: 100; left: 0px; position: absolute; top: 8px"
                                        runat="server" CssClass="h6" Width="96px" >用户列表</asp:Label>
                                    <asp:Label ID="lblUserRole" Style="z-index: 101; left: 504px; position: absolute;
                                        top: 8px" runat="server"  ForeColor="Navy">用户角色</asp:Label>
                                    <asp:DropDownList ID="ddlUserRole" Style="z-index: 102; left: 560px; position: absolute;
                                        top: 0px" runat="server" Width="128px" >
                                    </asp:DropDownList>
                                    <asp:Label ID="lblMsg3" Style="z-index: 104; left: 176px; position: absolute; top: 8px"
                                        runat="server" CssClass="text-warning"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 745px" colspan="3">
                                <asp:DataGrid ID="dgUsers" runat="server" Width="720px" Font-Names="宋体" AllowPaging="True"
                                    AutoGenerateColumns="False" BorderColor="#E7E7FF" BorderWidth="1px" BackColor="White"
                                    CellPadding="3" GridLines="Horizontal" BorderStyle="None">
                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                    <Columns>
                                        <asp:TemplateColumn HeaderText="选项">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="ckb1" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="UserId" HeaderText="用户编号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserName" HeaderText="用户名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="DepartmentName" HeaderText="部门"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserStateName" HeaderText="用户状态"></asp:BoundColumn>
                                        <asp:ButtonColumn Visible="False" Text="选择" HeaderText="功能列" CommandName="Select"></asp:ButtonColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                    </PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td style="width: 975px">
                                <asp:Label ID="Label3" runat="server" Width="110px" >查询结果记录数：</asp:Label></td>
                            <td style="width: 982px">
                                <asp:TextBox ID="txtRecCount" runat="server" Width="111px"  ReadOnly="True"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                            <td style="width: 745px">
                                <asp:Button ID="btnAddUser" runat="server" Width="88px" Text="添加新用户" OnClick="btnAddUser_Click"></asp:Button></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <asp:Label ID="Label5" Style="z-index: 103; left: 416px; position: absolute; top: 16px"
            runat="server" CssClass="MemoStyle1" Width="329px">维护用户对工程的权限，设置某用户所赋予权限的工程。</asp:Label>
    </form>
</body>
</html>
