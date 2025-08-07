<%@ Page Language="c#" CodeBehind="wfmUserPrjGrant.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmUserPrjGrant" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>表Users的查询修改记录</title>
    
   
</head>
<body>
    <form id="Form1" method="post" runat="server">
        
            <asp:Label ID="Label4" Style="z-index: 101; left: 16px; position: absolute; top: 8px"
                runat="server"  Width="208px" CssClass="h5">用户管理—〉用户工程授权</asp:Label>
            <asp:Label ID="lblMsg2" Style="z-index: 104; left: 240px; position: absolute; top: 8px"
                runat="server" CssClass="text-warning"></asp:Label>
        </font>
        <table id="tabLayout" style="z-index: 100; left: 8px; position: absolute; top: 40px"
            cellspacing="1" cellpadding="1" width="300" border="0" runat="server">
            <tr>
                <td>
                    
                        <table id="tabUsers" bordercolor="#996666" cellspacing="1" cellpadding="1" width="300"
                            border="4" runat="server">
                            <tr>
                                <td>
                                    <table id="Table1" style="width: 688px; height: 64px" cellspacing="1" cellpadding="1"
                                        width="688" border="0">
                                        <tr>
                                            <td style="width: 57px">
                                                
                                                    <asp:Label ID="lblUserIdq" runat="server" 
                                                         Width="39px">用户号</asp:Label></font></td>
                                            <td>
                                                <asp:TextBox ID="txtUserIdq" runat="server"  Width="152px"></asp:TextBox></td>
                                            <td>
                                                <asp:Label ID="lblUserNameq" runat="server" 
                                                     >用户名</asp:Label></td>
                                            <td>
                                                <asp:TextBox ID="txtUserNameq" runat="server"  Width="128px"></asp:TextBox></td>
                                            <td>
                                                <asp:Label ID="lblRoleIdq" runat="server" 
                                                     Width="54px">用户角色</asp:Label></td>
                                            <td>
                                                <asp:DropDownList ID="ddlRoleIdq" runat="server"  Width="128px">
                                                </asp:DropDownList></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 57px">
                                                <asp:Label ID="lblDepartmentIdq" runat="server" 
                                                     Width="30px">部门</asp:Label></td>
                                            <td>
                                                <asp:DropDownList ID="ddlDepartmentIdq" runat="server"  Width="152px">
                                                </asp:DropDownList></td>
                                            <td>
                                                <asp:Label ID="lblUserStateIdq" runat="server" 
                                                     Width="54px">用户状态</asp:Label></td>
                                            <td>
                                                <asp:DropDownList ID="ddlUserStateIdq" runat="server"  Width="128px">
                                                </asp:DropDownList></td>
                                            <td>
                                                <asp:Button ID="btnQuery" runat="server"   Text="查询" OnClick="btnQuery_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button></td>
                                            <td>
                                                
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    
                                        <asp:DataGrid ID="dgUsers" runat="server"  Font-Names="宋体" Height="154px"
                                            Width="792px" GridLines="Horizontal" CellPadding="3" BackColor="White" BorderWidth="1px"
                                            BorderStyle="None" BorderColor="#E7E7FF" AutoGenerateColumns="False" AllowPaging="True" OnItemCommand="dgUsers_ItemCommand" OnItemCreated="dgUsers_ItemCreated" OnPageIndexChanged="dgUsers_PageIndexChanged">
                                            <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                            <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                            <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                            <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                            <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                            <Columns>
                                                <asp:BoundColumn DataField="UserId" HeaderText="用户编号"></asp:BoundColumn>
                                                <asp:BoundColumn DataField="UserName" HeaderText="用户名"></asp:BoundColumn>
                                                <asp:BoundColumn DataField="DepartmentName" HeaderText="部门"></asp:BoundColumn>
                                                <asp:BoundColumn DataField="UserStateName" HeaderText="用户状态"></asp:BoundColumn>
                                                <asp:ButtonColumn Text="选择" HeaderText="功能列" CommandName="Select"></asp:ButtonColumn>
                                            </Columns>
                                            <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                            </PagerStyle>
                                        </asp:DataGrid></font></td>
                            </tr>
                            <tr>
                                <td>
                                    
                                        <asp:Label ID="lblRecCount" runat="server" 
                                             Width="110px">查询结果记录数：</asp:Label><asp:TextBox ID="txtRecCount" runat="server"
                                                  Width="111px" ReadOnly="True"></asp:TextBox></font></td>
                            </tr>
                        </table>
                    </font>
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
                                            runat="server" Width="296px" CssClass="h6">Label</asp:Label>
                                        <asp:LinkButton ID="lbDispUserList" Style="z-index: 101; left: 672px; position: absolute;
                                            top: 8px" runat="server"  
                                            Width="88px" OnClick="lbDispUserList_Click">显示用户列表</asp:LinkButton>
                                        <asp:Label ID="Label6" Style="z-index: 103; left: 384px; position: absolute; top: 8px"
                                            runat="server"  ForeColor="Navy">用户新角色</asp:Label>
                                        <asp:DropDownList ID="ddlRoleId_New" Style="z-index: 104; left: 456px; position: absolute;
                                            top: 8px" runat="server" Width="128px" >
                                        </asp:DropDownList>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <asp:DataGrid ID="dgUserPrjGrant" runat="server"  Font-Names="宋体"
                                        Height="154px" Width="792px" GridLines="None" CellPadding="2" BackColor="LightGoldenrodYellow"
                                        BorderWidth="1px" BorderColor="Tan" AutoGenerateColumns="False" AllowPaging="True"
                                        ForeColor="Black" OnItemCommand="dgUserPrjGrant_ItemCommand" OnItemCreated="dgUserPrjGrant_ItemCreated" OnPageIndexChanged="dgUserPrjGrant_PageIndexChanged">
                                        <FooterStyle BackColor="Tan"></FooterStyle>
                                        <SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
                                        <AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
                                        <HeaderStyle Font-Bold="True" BackColor="Tan"></HeaderStyle>
                                        <Columns>
                                            <asp:BoundColumn Visible="False" DataField="mId" HeaderText="编号"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="UserName" SortExpression="UserName" HeaderText="用户名"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="PrjName" SortExpression="PrjName" HeaderText="项目名称"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="RoleName" SortExpression="RoleName" HeaderText="角色"></asp:BoundColumn>
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
                                <td>
                                    <asp:Label ID="Label1" runat="server"  
                                        Width="110px">查询结果记录数：</asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtRecCount1" runat="server" 
                                         Width="111px" ReadOnly="True"></asp:TextBox></td>
                                <td>
                                    <asp:Button ID="Btn_AddNewPrj" runat="server" Width="88px" Text="添加项目" OnClick="Btn_AddNewPrj_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button></td>
                            </tr>
                        </table>
                    </font>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabProjects" bordercolor="#000099" cellspacing="1" cellpadding="1" width="100%"
                        border="4" runat="server">
                        <tr>
                            <td colspan="3" style="height: 36px" valign="top" align="left">
                                <table>
                                    <tr>
                                        <td>    <asp:Label ID="Label3" Style="z-index: 103; "
                                        runat="server" CssClass="h6" Width="200px">工程列表如下：</asp:Label>

                                        </td>
                                        <td>   <asp:Label ID="lblRoleId_e0" Style="z-index: 101; " runat="server"  
                                        Width="54px" ForeColor="Navy">工程名称</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="txtPrjName" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                    
                                    <asp:Button ID="btnQueryPrj" runat="server" Width="88px" Text="查询" OnClick="btnQueryPrj_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                    </font>
                                        </td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>   <asp:Label ID="lblMsg1" Style="z-index: 104; "
                                        runat="server" CssClass="text-warning"></asp:Label></td>
                                        <td></td>
                                        <td style="text-align:right">   <asp:Label ID="lblRoleId_e" Style="z-index: 101; " runat="server"  
                                        Width="54px" ForeColor="Navy">用户角色</asp:Label></td>
                                        <td>  <asp:DropDownList ID="ddlRoleId_e" Style="z-index: 102; " runat="server"  Width="128px">
                                    </asp:DropDownList></td>
                                        <td></td>
                                    </tr>
                                </table>
                              
                            </td>
                        </tr>
                        <tr>
                            <td valign="top" colspan="3" align="left">
                                <asp:DataGrid ID="dgProjects" runat="server"  Font-Names="宋体"
                                    Height="154px" Width="792px" CellPadding="4" BackColor="White" BorderWidth="1px"
                                    BorderStyle="None" BorderColor="#3366CC" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanged="dgProjects_PageIndexChanged">
                                    <FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
                                    <ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
                                    <Columns>
                                        <asp:TemplateColumn HeaderText="选项">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="Ckb1" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="PrjId" HeaderText="编号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrjName" HeaderText="项目名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrjDomain" HeaderText="所属领域"></asp:BoundColumn>
                                  <%--      <asp:BoundColumn DataField="PrjDataBaseName" HeaderText="主数据库"></asp:BoundColumn>--%>
                                        <asp:BoundColumn DataField="UpdDate" HeaderText="更新时间"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="Memo" HeaderText="备注"></asp:BoundColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Left" ForeColor="#003399" BackColor="#99CCCC" NextPageText="下一页" PrevPageText="上一页">
                                    </PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td style="width: 39px">
                                <asp:Label ID="Label2" runat="server"  
                                    Width="110px">查询结果记录数：</asp:Label></td>
                            <td style="width: 87px">
                                
                                    <asp:TextBox ID="txtRecCount2" runat="server" 
                                         Width="111px" ReadOnly="True"></asp:TextBox></font></td>
                            <td>
                                
                                    <asp:Button ID="Btn_AddPrj" runat="server"  Text="添加新项目" OnClick="Btn_AddPrj_Click"></asp:Button></font></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <asp:Label ID="Label5" Style="z-index: 103; left: 504px; position: absolute; top: 8px"
            runat="server" Width="312px" CssClass="MemoStyle1">维护用户对工程的权限，设置某用户所赋予权限的工程。</asp:Label>
    </form>
</body>
</html>
