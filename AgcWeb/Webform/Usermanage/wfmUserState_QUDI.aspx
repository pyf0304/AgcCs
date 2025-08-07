<%@ Page Language="c#" CodeBehind="wfmUserState_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.wfmUserState_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucUserState" Src="wucUserState.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>表UserState的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
        
            <asp:Label ID="Label3" Style="z-index: 112; left: 8px; position: absolute; top: 8px"
                runat="server" Font-Size="Larger" Font-Names="黑体"  Width="240px"
                ForeColor="Blue">通用用户管理->用户状态维护</asp:Label>
            <asp:Label ID="Label2" Style="z-index: 110; left: 264px; position: absolute; top: 8px"
                runat="server"  Width="42px"
                ForeColor="#004040" Font-Bold="True">说明：</asp:Label>
            <asp:Label ID="Label1" Style="z-index: 109; left: 312px; position: absolute; top: 8px"
                runat="server"  Height="32px" Width="368px"
                ForeColor="#004040">主要用来维护用户状态。</asp:Label>
            <asp:Label ID="lblUserStateIdq" Style="z-index: 102; left: 24px; position: absolute;
                top: 48px" runat="server"  >用户状态号</asp:Label>
            <asp:TextBox ID="txtUserStateIdq" Style="z-index: 103; left: 128px; position: absolute;
                top: 48px" runat="server" Width="100px" ></asp:TextBox>
            <asp:Label ID="lblUserStateNameq" Style="z-index: 104; left: 24px; position: absolute;
                top: 80px" runat="server"  >用户状态名称</asp:Label>
            <asp:TextBox ID="txtUserStateNameq" Style="z-index: 105; left: 128px; position: absolute;
                top: 80px" runat="server" Width="100px" ></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 108; left: 240px; position: absolute; top: 72px"
                runat="server"  Text="查询"></asp:Button>
        </font>
        <table id="Table1" style="z-index: 111; left: 8px; width: 456px; position: absolute;
            top: 112px; height: 441px" cellspacing="1" cellpadding="1" width="456" border="1">
            <tr>
                <td colspan="2" style="height: 165px" valign="top">
                    
                        <asp:DataGrid ID="dgUserState" runat="server" Width="463px" Height="154px" AutoGenerateColumns="False"
                            PageSize="5" AllowPaging="True" Font-Names="宋体" Font-Size="Smaller" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <Columns>
                                <asp:BoundColumn DataField="UserStateId" HeaderText="用户状态号">
                                    <HeaderStyle ></HeaderStyle>
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="UserStateName" HeaderText="用户状态名称">
                                    <HeaderStyle ></HeaderStyle>
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="Memo" HeaderText="备注"></asp:BoundColumn>
                                <asp:ButtonColumn Text="修改" CommandName="Update">
                                    <HeaderStyle Width="30px"></HeaderStyle>
                                </asp:ButtonColumn>
                                <asp:TemplateColumn>
                                    <HeaderStyle Width="30px"></HeaderStyle>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                            </Columns>
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center"></PagerStyle>
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <EditItemStyle BackColor="#7C6F57" />
                            <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <AlternatingItemStyle BackColor="White" />
                            <ItemStyle BackColor="#E3EAEB" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        </asp:DataGrid></font></td>
            </tr>
            <tr>
                <td style="width: 397px" valign="top">
                    <asp:Label ID="lblRecCount" runat="server" Width="104px"  Font-Names="宋体"
                        Font-Size="Smaller">查询结果记录数：</asp:Label>
                    <asp:TextBox ID="txtRecCount" runat="server" Width="111px"  Font-Names="宋体"
                        Font-Size="Smaller" ReadOnly="True"></asp:TextBox></td>
                <td valign="top">
                    <asp:Button ID="btnOKUpd" runat="server"   Text="添加"></asp:Button></td>
            </tr>
            <tr>
                <td style="width: 397px" valign="top">
                    <table id="tabLayout" style="width: 373px; height: 200px" cellspacing="1" cellpadding="1"
                        width="373" border="1">
                        <tr>
                            <td>
                                <uc1:wucUserState id="wucUserState1" runat="server">
                                </uc1:wucUserState></td>
                        </tr>
                    </table>
                </td>
                <td valign="top">
                    <asp:Label ID="lblMsg" runat="server" Height="27px" ></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
