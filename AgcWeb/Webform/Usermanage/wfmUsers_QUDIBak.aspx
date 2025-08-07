<%@ Page Language="c#" CodeBehind="wfmUsers_QUDIBak.aspx.cs" AutoEventWireup="True" Inherits="AGC.wfmUsers_QUDIBak" ResponseEncoding="UTF-8" EnableEventValidation="false" %>

<%@ Register TagPrefix="uc1" TagName="wucUsers" Src="wucUsers.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表Users的查询、修改、删除、添加记录</title>
    <link href="../../css/tz_base1Bak.css" rel="stylesheet" type="text/css" />
   <script type="text/javascript" src="../../Scripts/jquery-3.4.1.min.js"></script>
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

        <asp:Label ID="lblTitle" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
            runat="server" ForeColor="#8080FF" Font-Size="Larger" Font-Names="黑体"
            Width="208px">管理用户权限->用户维护</asp:Label>
        <asp:Button ID="btnQuery" Style="z-index: 102; left: 344px; position: absolute; top: 128px"
            runat="server"  
            Text="查询" OnClick="btnQuery_Click"></asp:Button>
        <table id="tabLayout" style="z-index: 106; left: 472px; width: 373px; position: absolute; top: 32px; height: 200px"
            cellspacing="1" cellpadding="1" width="373" border="1">
            <tr>
                <td class="auto-style1">
                    <uc1:wucUsers ID="wucUsers1" runat="server"></uc1:wucUsers>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnOKUpd" runat="server"   Text="添加" OnClick="btnOKUpd_Click"></asp:Button><asp:Label
                        ID="lblMsg" runat="server" Height="27px" Width="215px"></asp:Label></td>
            </tr>
        </table>
        <table id="Table1" style="z-index: 107; left: 8px; width: 420px; position: absolute; top: 32px; height: 67px"
            cellspacing="1" cellpadding="1" width="420" border="1">
            <tr>
                <td>
                    <asp:Label ID="lblUserId_q" runat="server"
                        Width="65px">用户ID</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtUserId_q" runat="server"
                         Width="100px"></asp:TextBox></td>
                <td>
                    <asp:Label ID="lblName_q" runat="server"
                        Width="65px">用户名称</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtUserName_q" runat="server"
                         Width="100px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDepartmentId_q" runat="server"
                        Width="65px">部门号</asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddlDepartmentId_q" runat="server"
                         Width="100px">
                    </asp:DropDownList></td>
                <td>
                    <asp:Label ID="lblUserStateId_q" runat="server"
                        Width="65px">用户状态号</asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddlUserStateId_q" runat="server"
                         Width="100px">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblRoleId_q" runat="server"
                        Width="65px">用户角色</asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddlRoleId_q" runat="server"
                         Width="99px">
                    </asp:DropDownList></td>
                <td>
                    <asp:Label ID="lblQXDJ_q" runat="server"
                        Width="65px">权限等级</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtQXDJ_q" runat="server"
                         Width="100px"></asp:TextBox></td>
            </tr>
        </table>
        <table id="Table2" style="z-index: 108; left: 0px; position: absolute; top: 152px"
            cellspacing="1" cellpadding="1" width="300" border="1">
            <tr>
                <td>
                    <asp:DataGrid ID="dgUsers" runat="server" Font-Size="Smaller" Font-Names="宋体" Height="154px"
                        Width="463px" GridLines="Horizontal" CellPadding="3" BackColor="White" BorderWidth="1px"
                        BorderStyle="None" BorderColor="#E7E7FF" AllowPaging="True" AutoGenerateColumns="False" OnItemCommand="dgUsers_ItemCommand" OnItemCreated="dgUsers_ItemCreated" OnPageIndexChanged="dgUsers_PageIndexChanged">
                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                        <Columns>
                            <asp:BoundColumn DataField="UserId" HeaderText="用户ID"></asp:BoundColumn>
                            <asp:BoundColumn DataField="UserName" HeaderText="用户名称"></asp:BoundColumn>
                            <asp:BoundColumn DataField="DepartmentName" HeaderText="部门"></asp:BoundColumn>
                            <asp:BoundColumn DataField="UserStateName" HeaderText="用户状态"></asp:BoundColumn>
                            <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
                    </asp:DataGrid>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblRecCount" runat="server" Font-Size="Smaller" Font-Names="宋体" 
                        Width="110px">查询结果记录数：</asp:Label><asp:TextBox ID="txtRecCount" runat="server" Font-Size="Smaller"
                            Font-Names="宋体" Width="111px" ReadOnly="True"></asp:TextBox></td>
            </tr>
        </table>

    </form>
</body>
</html>
