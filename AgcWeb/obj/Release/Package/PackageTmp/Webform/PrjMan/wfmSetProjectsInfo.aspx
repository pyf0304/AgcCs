<%@ Page Language="c#" CodeBehind="wfmSetProjectsInfo.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmSetProjectsInfo" %>

<%@ Register TagPrefix="uc1" TagName="wucProjects" Src="wucProjects.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>表Projects的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
            <asp:Label ID="Label1" Style="z-index: 103; left: 8px; position: absolute; top: 8px"
                runat="server" Width="168px"  Font-Names="黑体" Font-Size="Larger"
                ForeColor="Blue">工程管理->工程维护</asp:Label>
            <asp:Label ID="Label2" Style="z-index: 102; left: 208px; position: absolute; top: 8px"
                runat="server" Width="42px" 
                ForeColor="#004040" Font-Bold="True">说明：</asp:Label>
            <asp:Label ID="Label3" Style="z-index: 101; left: 264px; position: absolute; top: 8px"
                runat="server" Width="368px"
                ForeColor="#004040">主要用来维护不同的项目，包括添加、删除、修改、查询</asp:Label>
            <table id="tabHidden" style="z-index: 104; left: 648px; position: absolute; top: 0px"
                cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
                <tr>
                    <td>
                        <asp:Label ID="lblUserIDq" runat="server" Width="100px" Height="10px" 
                            Font-Size="XX-Small">用户ID</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtUserIDq" runat="server" Width="100px" Height="10px" 
                            Font-Size="XX-Small"></asp:TextBox></td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
            <table id="Table1" style="z-index: 105; left: 8px; width: 688px; position: absolute;
                top: 32px; height: 64px" cellspacing="0" cellpadding="0" width="688" border="0">
                <tr>
                    <td>
                        <table id="tabQuery" style="width: 792px; height: 92px" cellspacing="1" cellpadding="1"
                            width="792" border="4" bordercolor="#330066" runat="server">
                            <tr>
                                <td>
                                    <asp:Label ID="lblPrjIdq" runat="server" 
                                        >工程ID</asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtPrjIdq" runat="server" 
                                         Width="100px"></asp:TextBox></td>
                                <td>
                                    <asp:Label ID="lblPrjNameq" runat="server" 
                                        >工程名称</asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtPrjNameq" runat="server" 
                                         Width="100px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblPrjDomainq" runat="server" 
                                        >工程域名</asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtPrjDomainq" runat="server" 
                                         Width="100px"></asp:TextBox></td>
                                <td>
                                    <asp:Label ID="lblPrjDataBaseNameq" runat="server" 
                                        >主数据库</asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtPrjDataBaseNameq" runat="server" 
                                         Width="100px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblDataBaseUserIdq" runat="server" 
                                         Width="96px">数据库的用户ID</asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtDataBaseUserIdq" runat="server" 
                                         Width="100px"></asp:TextBox></td>
                                <td colspan="2">
                                    <asp:Button ID="btnQuery" runat="server"  Width="78px" Text="查询" OnClick="btnQuery_Click">
                                    </asp:Button></td>
                            </tr>
                        </table>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table id="tabProjectsDg" cellspacing="1" cellpadding="1" width="300" border="1"
                            runat="server">
                            <tr>
                                <td colspan="2">
                                    <div style="width: 784px; position: relative; height: 17px">
                                        <asp:LinkButton ID="lbAddNewRec" Style="z-index: 100; left: 472px; position: absolute;
                                            top: 0px" runat="server" OnClick="lbAddNewRec_Click" >添加新记录</asp:LinkButton>
                                        <asp:LinkButton ID="lbExportForTeachCircs" Style="z-index: 101; left: 592px; position: absolute;
                                            top: 0px" runat="server" 
                                            Width="64px" OnClick="lbExportForTeachCircs_Click">导出Excel</asp:LinkButton>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:DataGrid ID="dgProjects" runat="server" Font-Size="Smaller" Font-Names="宋体"
                                        Height="154px" Width="792px" AutoGenerateColumns="False" AllowPaging="True"
                                        AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnItemCommand="dgProjects_ItemCommand" OnItemCreated="dgProjects_ItemCreated" OnPageIndexChanged="dgProjects_PageIndexChanged" OnSortCommand="dgProjects_SortCommand">
                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>
                                        <Columns>
                                            <asp:BoundColumn Visible="False" DataField="PrjId" HeaderText="工程ID"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="PrjName" SortExpression="PrjName" HeaderText="工程名称"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="PrjDomain" SortExpression="PrjDomain" HeaderText="工程域名">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="PrjDataBaseName" SortExpression="PrjDataBaseName" HeaderText="主数据库">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="DataBaseOwner" SortExpression="DataBaseOwner" HeaderText="库拥有者">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="IpAddress" SortExpression="IpAddress" HeaderText="服务器"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="DataBaseUserId" SortExpression="DataBaseUserId" HeaderText="数据库用户ID">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="DataBasePwd" HeaderText="数据库的用户口令"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="UsersUserName" HeaderText="用户ID"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="UpdDate" HeaderText="修改日期"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="Memo" HeaderText="备注"></asp:BoundColumn>
                                            <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                            <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                        </Columns>
                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center"></PagerStyle>
                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <EditItemStyle BackColor="#999999" />
                                        <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                                        <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    </asp:DataGrid></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblRecCount" runat="server" Font-Size="Smaller" Font-Names="宋体" 
                                        Width="110px">查询结果记录数：</asp:Label>
                                    <asp:TextBox ID="txtRecCount" runat="server" Font-Size="Smaller" Font-Names="宋体"
                                         Width="111px" ReadOnly="True"></asp:TextBox></td>
                                <td>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table id="tabLayout" style="width: 799px; height: 18px" cellspacing="1" cellpadding="1"
                            width="799" border="4" bordercolor="#666666" runat="server">
                            <tr>
                                <td valign="top">
                                    <div style="width: 784px; position: relative; height: 24px">
                                        <asp:LinkButton ID="lbDispPrjList" Style="z-index: 101; left: 464px; position: absolute;
                                            top: 0px" runat="server" OnClick="lbDispPrjList_Click" >显示工程列表</asp:LinkButton>
                                        <asp:Button ID="btnOKUpd" Style="z-index: 102; left: 144px; position: absolute; top: 0px"
                                            runat="server"  Width="83px" Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                        <asp:Label ID="lblMsg" Style="z-index: 103; left: 232px; position: absolute; top: 0px"
                                            runat="server"  Width="215px"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <uc1:wucprojects id="wucProjects1" runat="server">
                                    </uc1:wucprojects></td>
                            </tr>
                        </table>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
    </form>
</body>
</html>
