<%@ Page Language="c#" CodeBehind="wfmUserViewGrant.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmUserViewGrant" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表Users的查询修改记录</title>
    
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
        <font face="宋体" id="FONT1" runat="server">
            <asp:Label ID="lblUserIdq" Style="z-index: 102; left: 8px; position: absolute; top: 48px"
                runat="server"   >用户编号</asp:Label>
            <asp:TextBox ID="txtUserIdq" Style="z-index: 103; left: 112px; position: absolute;
                top: 48px" runat="server"  Width="100px"></asp:TextBox>
            <asp:Label ID="lblUserNameq" Style="z-index: 104; left: 8px; position: absolute;
                top: 72px" runat="server"  
                >用户名</asp:Label>
            <asp:TextBox ID="txtUserNameq" Style="z-index: 105; left: 112px; position: absolute;
                top: 72px" runat="server"  Width="100px"></asp:TextBox>
            <asp:Label ID="lblDepartmentIdq" Style="z-index: 106; left: 8px; position: absolute;
                top: 96px" runat="server"  
                >部门</asp:Label>
            <asp:DropDownList ID="ddlDepartmentIdq" Style="z-index: 107; left: 112px; position: absolute;
                top: 96px" runat="server"  Width="100px">
            </asp:DropDownList>
            <asp:Label ID="lblUserStateIdq" Style="z-index: 108; left: 232px; position: absolute;
                top: 48px" runat="server"  
                >用户状态</asp:Label>
            <asp:DropDownList ID="ddlUserStateIdq" Style="z-index: 109; left: 336px; position: absolute;
                top: 48px" runat="server"  Width="100px">
            </asp:DropDownList>
            <asp:Label ID="lblPassWordq" Style="z-index: 110; left: 584px; position: absolute; top: 480px"
                runat="server"   
                Visible="False">PassWord</asp:Label>
            <asp:TextBox ID="txtPassWordq" Style="z-index: 111; left: 680px; position: absolute;
                top: 480px" runat="server"  Width="100px" Visible="False"></asp:TextBox>
            <asp:Label ID="lblMemoq" Style="z-index: 112; left: 584px; position: absolute; top: 504px"
                runat="server"   
                Visible="False">Memo</asp:Label>
            <asp:TextBox ID="txtMemoq" Style="z-index: 114; left: 680px; position: absolute;
                top: 504px" runat="server" Width="100px"  Visible="False"></asp:TextBox>
            <asp:Label ID="lblqxdjq" Style="z-index: 116; left: 584px; position: absolute; top: 528px"
                runat="server"   
                Visible="False">qxdj</asp:Label>
            <asp:TextBox ID="txtqxdjq" Style="z-index: 117; left: 680px; position: absolute;
                top: 528px" runat="server" Width="100px"  Visible="False"></asp:TextBox>
            <asp:Label ID="lblRoleIdq" Style="z-index: 118; left: 232px; position: absolute;
                top: 72px" runat="server"  
                >用户角色</asp:Label>
            <asp:DropDownList ID="ddlRoleIdq" Style="z-index: 119; left: 336px; position: absolute;
                top: 72px" runat="server" Width="100px" >
            </asp:DropDownList>
            <asp:Button ID="btnQuery" Style="z-index: 120; left: 336px; position: absolute; top: 96px"
                runat="server"  Text="查询"></asp:Button>
            <asp:DataGrid ID="dgUsers" Style="z-index: 121; left: 8px; position: absolute; top: 128px"
                runat="server" Width="463px" Height="154px" AutoGenerateColumns="False" PageSize="5"
                AllowPaging="True" Font-Names="宋体" >
                <Columns>
                    <asp:BoundColumn DataField="UserId" HeaderText="用户编号"></asp:BoundColumn>
                    <asp:BoundColumn DataField="UserName" HeaderText="用户名"></asp:BoundColumn>
                    <asp:BoundColumn DataField="DepartmentsDepartmentName" HeaderText="部门"></asp:BoundColumn>
                    <asp:BoundColumn DataField="UserStateUserStateName" HeaderText="用户状态"></asp:BoundColumn>
                    <asp:BoundColumn DataField="UserRoleRole" HeaderText="用户角色"></asp:BoundColumn>
                    <asp:ButtonColumn Text="选择" HeaderText="功能列" CommandName="Select"></asp:ButtonColumn>
                </Columns>
                <PagerStyle Mode="NumericPages"></PagerStyle>
            </asp:DataGrid>
            <asp:Label ID="lblRecCount" Style="z-index: 122; left: 16px; position: absolute;
                top: 296px" runat="server" Width="110px"  >查询结果记录数：</asp:Label>
            <asp:TextBox ID="txtRecCount" Style="z-index: 123; left: 144px; position: absolute;
                top: 288px" runat="server" Width="111px"  
                ReadOnly="True"></asp:TextBox>
            <table id="Table1" style="z-index: 126; left: 472px; position: absolute; top: 128px"
                cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
                <tr>
                    <td colspan="3">
                        <asp:DataGrid ID="dgViewInfo" runat="server"  Font-Names="宋体"
                            Height="154px" Width="384px" AutoGenerateColumns="False" PageSize="5" AllowPaging="True">
                            <Columns>
                                <asp:TemplateColumn HeaderText="选择">
                                    <HeaderStyle Width="20px"></HeaderStyle>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="Ckb1" runat="server"></asp:CheckBox>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:BoundColumn Visible="False" DataField="ViewId" HeaderText="编号"></asp:BoundColumn>
                                <asp:BoundColumn DataField="ViewName" HeaderText="名称">
                                    <HeaderStyle></HeaderStyle>
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="ViewTypeCode" HeaderText="界面类型代码">
                                    <HeaderStyle Width="50px"></HeaderStyle>
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="ViewFunction" HeaderText="界面功能"></asp:BoundColumn>
                            </Columns>
                            <PagerStyle Mode="NumericPages"></PagerStyle>
                        </asp:DataGrid></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server"  
                            Width="110px">查询结果记录数：</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtRecCount2" runat="server" 
                             Width="111px" ReadOnly="True"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="Btn_AddView" runat="server" Width="76px" Text="添加"></asp:Button></td>
                </tr>
            </table>
            <table id="TableShow" style="z-index: 128; left: 8px; position: absolute; top: 320px"
                cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
                <tr>
                    <td colspan="3">
                        <asp:DataGrid ID="dgUserViewGrant" runat="server"  Font-Names="宋体"
                            Height="154px" Width="456px" AutoGenerateColumns="False" PageSize="5" AllowPaging="True">
                            <Columns>
                                <asp:BoundColumn DataField="MId" HeaderText="编号"></asp:BoundColumn>
                                <asp:BoundColumn DataField="UsersXM" HeaderText="用户名称"></asp:BoundColumn>
                                <asp:BoundColumn DataField="ProjectsPrjName" HeaderText="项目名称"></asp:BoundColumn>
                                <asp:BoundColumn DataField="ViewInfoViewName" HeaderText="界面名称"></asp:BoundColumn>
                                <asp:BoundColumn DataField="Memo" HeaderText="备注"></asp:BoundColumn>
                                <asp:TemplateColumn HeaderText="功能列">
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
                        <asp:Label ID="Label1" runat="server"  
                            Width="110px">查询结果记录数：</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtRecCount1" runat="server" 
                             Width="111px" ReadOnly="True"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="Btn_Add" runat="server"  Text="添加界面"></asp:Button></td>
                </tr>
            </table>
        </font>
        <div style="display: inline; z-index: 131; left: 280px; width: 488px;
            color: #669966; line-height: normal; font-family: Verdana; position: absolute;
            top: 8px; height: 16px">
            <p>
                具有一定权限的用户为其他用户进行界面查看、操作方面的授权。</p>
        </div>
        <div style="display: inline; font-weight: bold; z-index: 132;
            left: 240px; width: 32px; color: #004040; font-family: Verdana; position: absolute;
            top: 8px; height: 16px">
            说明</div>
        <div style="display: inline; font-weight: bold; font-size: medium; z-index: 133;
            left: 8px; width: 216px; color: blue; font-family: Verdana; position: absolute;
            top: 8px; height: 24px">
            用户管理-&gt;用户界面授权</div>
    </form>
</body>
</html>
