<%@ Page Language="c#" CodeBehind="wfmUserDefaValue_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmUserDefaValue_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucUserDefaValue" Src="wucUserDefaValue.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>表UserDefaValue的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
        
            <asp:Label ID="Label1" Style="z-index: 112; left: 16px; position: absolute; top: 16px"
                runat="server" Font-Size="Larger" Font-Names="黑体"  Width="272px"
                ForeColor="Blue">系统设置->户用自定义系统值</asp:Label>
            <asp:Label ID="Label2" Style="z-index: 113; left: 304px; position: absolute; top: 16px"
                runat="server"  Width="42px"
                ForeColor="#004040" Font-Bold="True">说明：</asp:Label>
            <asp:Label ID="Label3" Style="z-index: 101; left: 360px; position: absolute; top: 16px"
                runat="server"  Width="368px"
                ForeColor="#004040">用户自定义一些系统初始化时的默认值，以方便使用</asp:Label>
            <asp:Label ID="lblMIdq" Style="z-index: 102; left: 616px; position: absolute; top: 360px"
                runat="server" Width="32px"  Visible="False" 
                >编号</asp:Label>
            <asp:TextBox ID="txtMIdq" Style="z-index: 103; left: 744px; position: absolute;
                top: 360px" runat="server" Width="100px"  Visible="False"></asp:TextBox>
            <asp:Label ID="lblDefaValNameIdq" Style="z-index: 104; left: 616px; position: absolute;
                top: 384px" runat="server" Width="72px"  Visible="False" 
                >缺省值编号</asp:Label>
            <asp:TextBox ID="txtDefaValNameIdq" Style="z-index: 105; left: 744px; position: absolute;
                top: 384px" runat="server" Width="100px"  Visible="False"></asp:TextBox>
            <asp:Label ID="lblUserIdq" Style="z-index: 106; left: 616px; position: absolute;
                top: 416px" runat="server"   Visible="False" 
                >用户名</asp:Label>
            <asp:TextBox ID="txtUserIdq" Style="z-index: 107; left: 744px; position: absolute;
                top: 408px" runat="server" Width="100px"  Visible="False"></asp:TextBox>
            <asp:Label ID="lblUserDefaValueq" Style="z-index: 108; left: 616px; position: absolute;
                top: 440px" runat="server" Width="96px"  Visible="False" 
                >用户定义缺省值</asp:Label>
            <asp:TextBox ID="txtUserDefaValueq" Style="z-index: 109; left: 744px; position: absolute;
                top: 432px" runat="server" Width="100px"  Visible="False"></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 110; left: 888px; position: absolute; top: 432px"
                runat="server" Width="78px" Height="28px" Text="查询" Visible="False"></asp:Button>
            <table id="tabLayout" style="z-index: 111; left: 512px; width: 298px; position: absolute;
                top: 56px; height: 256px" cellspacing="1" cellpadding="1" width="298" border="4"
                bordercolor="#333366">
                <tr>
                    <td valign="top">
                        <asp:Button ID="btnOKUpd" runat="server" Width="83px"  Text="修  改"></asp:Button>
                        <asp:Label ID="lblMsg" runat="server" Width="184px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td valign="top">
                        <uc1:wucUserDefaValue id="wucUserDefaValue1" runat="server">
                        </uc1:wucUserDefaValue></td>
                </tr>
            </table>
            <table id="Table1" style="z-index: 114; left: 8px; width: 480px; position: absolute;
                top: 56px; height: 240px" cellspacing="1" cellpadding="1" width="480" border="4"
                bordercolor="#333366">
                <tr>
                    <td colspan="3">
                        <asp:DataGrid ID="dgUserDefaValue" runat="server" Font-Size="Smaller" Font-Names="宋体"
                            Height="154px" Width="480px" AllowPaging="True" AutoGenerateColumns="False">
                            <ItemStyle BackColor="Ivory"></ItemStyle>
                            <HeaderStyle BackColor="#CC99FF"></HeaderStyle>
                            <Columns>
                                <asp:BoundColumn DataField="DefaValNameId" HeaderText="缺省值编号"></asp:BoundColumn>
                                <asp:BoundColumn DataField="DefaValName" HeaderText="系统缺省值名称"></asp:BoundColumn>
                                <asp:BoundColumn DataField="SysDefaValue" HeaderText="系统缺省值"></asp:BoundColumn>
                                <asp:BoundColumn DataField="UserDefaValue" HeaderText="用户定义缺省值"></asp:BoundColumn>
                                <asp:BoundColumn DataField="Memo" HeaderText="说明"></asp:BoundColumn>
                                <asp:ButtonColumn Text="修改" HeaderText="功能列" CommandName="Update"></asp:ButtonColumn>
                                <asp:TemplateColumn HeaderText="功能列" FooterText="如果用户缺省值为空删除无效">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                            </Columns>
                            <PagerStyle Mode="NumericPages"></PagerStyle>
                        </asp:DataGrid></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="宋体"
                            Font-Size="Smaller">查询结果记录数：</asp:Label></td>
                    <td colspan="2">
                        <asp:TextBox ID="txtRecCount" runat="server" Width="111px"  Font-Names="宋体"
                            Font-Size="Smaller" ReadOnly="True"></asp:TextBox></td>
                </tr>
            </table>
        </font>
    </form>
</body>
</html>
