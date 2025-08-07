<%@ Page Language="c#" CodeBehind="wfmProjects_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.wfmProjects_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucProjects" Src="wucProjects.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>表Projects的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
        
            <asp:Label ID="Label3" Style="z-index: 116; left: 8px; position: absolute; top: 8px"
                runat="server" Font-Size="Larger" Font-Names="黑体"  Width="208px"
                ForeColor="Blue">通用用户管理->工程维护</asp:Label>
            <asp:Label ID="Label2" Style="z-index: 110; left: 232px; position: absolute; top: 8px"
                runat="server"  Width="42px"
                ForeColor="#004040" Font-Bold="True">说明：</asp:Label>
            <asp:Label ID="Label1" Style="z-index: 109; left: 272px; position: absolute; top: 8px"
                runat="server"  Height="32px" Width="368px"
                ForeColor="#004040">主要用来维护需要管理的工程。</asp:Label>
            <asp:Label ID="lblPrjIdq" Style="z-index: 102; left: 32px; position: absolute; top: 48px"
                runat="server" Width="56px" >工程号</asp:Label>
            <asp:TextBox ID="txtPrjIdq" Style="z-index: 103; left: 136px; position: absolute;
                top: 48px" runat="server" Width="100px" ></asp:TextBox>
            <asp:Label ID="lblPrjNameq" Style="z-index: 104; left: 32px; position: absolute;
                top: 80px" runat="server" Width="64px" >工程名称</asp:Label>
            <asp:TextBox ID="txtPrjNameq" Style="z-index: 105; left: 136px; position: absolute;
                top: 80px" runat="server" Width="100px" ></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 108; left: 248px; position: absolute; top: 80px"
                runat="server"  Text="查询"></asp:Button>
        </font>
        <table id="Table1" style="z-index: 115; left: 8px; position: absolute; top: 120px"
            cellspacing="1" cellpadding="1" width="300" border="1">
            <tr>
                <td valign="top" colspan="2">
                    
                        <asp:DataGrid ID="dgProjects" runat="server" Width="463px" Height="154px" AutoGenerateColumns="False"
                            PageSize="5" AllowPaging="True" Font-Names="宋体" Font-Size="Smaller">
                            <Columns>
                                <asp:BoundColumn DataField="PrjId" HeaderText="工程号"></asp:BoundColumn>
                                <asp:BoundColumn DataField="PrjName" HeaderText="工程名称"></asp:BoundColumn>
                                <asp:BoundColumn DataField="Memo" HeaderText="备注"></asp:BoundColumn>
                                <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                <asp:TemplateColumn>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                            </Columns>
                            <PagerStyle Mode="NumericPages"></PagerStyle>
                        </asp:DataGrid></font></td>
            </tr>
            <tr>
                <td style="width: 399px" valign="top">
                    <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="宋体"
                        Font-Size="Smaller">查询结果记录数：</asp:Label>
                    <asp:TextBox ID="txtRecCount" runat="server" Width="111px"  Font-Names="宋体"
                        Font-Size="Smaller" ReadOnly="True"></asp:TextBox></td>
                <td valign="top">
                    <asp:Button ID="btnOKUpd" runat="server"   Text="添加"></asp:Button></td>
            </tr>
            <tr>
                <td style="width: 399px" valign="top">
                    <table id="tabLayout" style="width: 373px; height: 200px" cellspacing="1" cellpadding="1"
                        width="373" border="1">
                        <tr>
                            <td>
                                <uc1:wucProjects id="wucProjects1" runat="server">
                                </uc1:wucProjects></td>
                        </tr>
                    </table>
                </td>
                <td valign="top">
                    <asp:Label ID="lblMsg" runat="server" Width="88px" Height="27px"></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
