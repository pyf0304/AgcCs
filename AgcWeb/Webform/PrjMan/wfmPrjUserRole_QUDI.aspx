<%@ Page Language="c#" CodeBehind="wfmPrjUserRole_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmPrjUserRole_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucPrjUserRole" Src="wucPrjUserRole.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>表UserRoles的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
  
            <asp:Label ID="lblTitle" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                runat="server" Width="208px"  Font-Names="黑体" Font-Size="Larger"
                ForeColor="Blue">系统设置->系统角色维护</asp:Label>
            <asp:Label ID="Label2" Style="z-index: 112; left: 232px; position: absolute; top: 8px"
                runat="server" ForeColor="#004040"  
                Width="42px" Font-Bold="True">说明：</asp:Label>
            <table id="tabLayout" style="z-index: 110; left: 448px; width: 373px; position: absolute;
                top: 48px; height: 232px" cellspacing="1" cellpadding="1" width="373" border="4"
                bordercolor="#996666">
                <tr>
                    <td valign="top">
                        <asp:Button ID="btnOKUpd" runat="server" Width="83px" Height="28px" Text="添加"></asp:Button>
                        <asp:Label ID="lblMsg" runat="server" Width="215px" Height="27px"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <uc1:wucPrjUserRole id="wucPrjUserRole1" runat="server">
                        </uc1:wucPrjUserRole></td>
                </tr>
            </table>
            <asp:Label ID="Label1" Style="z-index: 111; left: 272px; position: absolute; top: 8px"
                runat="server" Height="32px" Width="368px" ForeColor="#004040" 
                >角色对象主要用来根据用户的身份来定义用户的类型，从来确定他使用各种不同应用系统的权限。</asp:Label>
            <table id="Table1" style="z-index: 113; left: 8px; position: absolute; top: 48px"
                cellspacing="1" cellpadding="1" width="300" border="4" bordercolor="#666666">
                <tr>
                    <td>
                        <asp:Label ID="lblRoleIdq" runat="server"  
                            >角色ID</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtRoleIdq" runat="server" Width="83px" ></asp:TextBox></td>
                    <td>
                        <asp:Label ID="lblRoleq" runat="server" Width="56px" 
                            >角色名称</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtRoleq" runat="server" Width="100px" ></asp:TextBox></td>
                    <td>
                        <asp:Button ID="btnQuery" runat="server" Width="78px" Height="28px" Text="查询"></asp:Button></td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:DataGrid ID="dgUserRole" runat="server" Width="416px" Height="154px" AutoGenerateColumns="False"
                            AllowPaging="True" Font-Names="宋体" Font-Size="Smaller" BackColor="#CCCCFF">
                            <HeaderStyle BackColor="#FFFF99"></HeaderStyle>
                            <Columns>
                                <asp:BoundColumn DataField="RoleId" HeaderText="角色ID"></asp:BoundColumn>
                                <asp:BoundColumn DataField="RoleName" HeaderText="角色名称"></asp:BoundColumn>
                                <asp:BoundColumn DataField="Memo" HeaderText="备注"></asp:BoundColumn>
                                <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                <asp:TemplateColumn>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                            </Columns>
                            <PagerStyle Mode="NumericPages"></PagerStyle>
                        </asp:DataGrid></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="宋体"
                            Font-Size="Smaller">查询结果记录数：</asp:Label></td>
                    <td colspan="2">
                        <asp:TextBox ID="txtRecCount" runat="server" Width="111px"  Font-Names="宋体"
                            Font-Size="Smaller" ReadOnly="True"></asp:TextBox></td>
                    <td>
                    </td>
                </tr>
            </table>

    </form>
</body>
</html>
