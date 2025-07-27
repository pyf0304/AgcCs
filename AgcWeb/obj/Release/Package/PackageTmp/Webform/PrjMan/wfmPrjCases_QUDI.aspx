<%@ Page Language="c#" CodeBehind="wfmPrjCases_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmPrjCases_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucPrjCases" Src="wucPrjCases.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>表PrjCases的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

            <asp:Label ID="Label3" Style="z-index: 104; left: 8px; position: absolute; top: 8px"
                runat="server" Font-Size="Larger" Font-Names="黑体"  Width="208px"
                ForeColor="Blue">工程用例管理->用例维护</asp:Label>
            <asp:Label ID="Label2" Style="z-index: 102; left: 232px; position: absolute; top: 8px"
                runat="server"  Width="42px"
                ForeColor="#004040" Font-Bold="True">说明：</asp:Label>
            <asp:Label ID="Label1" Style="z-index: 101; left: 272px; position: absolute; top: 8px"
                runat="server"  Height="32px" Width="368px"
                ForeColor="#004040">角色对象主要用来根据用户的身份来定义用户的类型，从来确定他使用各种不同应用系统的权限。</asp:Label>
            <table id="tabLayout" style="z-index: 103; left: 528px; width: 373px; position: absolute;
                top: 40px; height: 200px" cellspacing="1" cellpadding="1" width="373" border="4"
                bordercolor="#666666">
                <tr>
                    <td valign="top">
                        <asp:Button ID="btnOKUpd" runat="server" Width="83px"  Text="添加"></asp:Button>
                        <asp:Label ID="lblMsg" runat="server" Width="215px" ></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <uc1:wucPrjCases id="wucPrjCases1" runat="server">
                        </uc1:wucPrjCases></td>
                </tr>
            </table>
            <table id="tabHidden" style="z-index: 105; left: 560px; width: 374px; position: absolute;
                top: 296px; height: 57px" cellspacing="1" cellpadding="1" width="374" border="1"
                runat="server">
                <tr>
                    <td>
                        <asp:Label ID="lblUpdDateq" runat="server" Width="56px" 
                            >修改日期</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtUpdDateq" runat="server" Width="33px" ></asp:TextBox></td>
                    <td>
                        <asp:Label ID="lblMemoq" runat="server" Width="30px" 
                            >说明</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtMemoq" runat="server" Width="30px" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCaseContentq" runat="server"   
                            >用例详细内容</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtCaseContentq" runat="server" Width="29px" ></asp:TextBox></td>
                    <td>
                        <asp:Label ID="lblCaseIdq" runat="server" Width="56px"  
                            >用例编号</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtCaseIdq" runat="server" Width="28px" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblUserIdq" runat="server"   
                            >用户号</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtUserIdq" runat="server" Width="100px" ></asp:TextBox></td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
            <table id="Table1" style="z-index: 106; left: 8px; width: 520px; position: absolute;
                top: 40px; height: 422px" cellspacing="1" cellpadding="1" width="520" border="4"
                bordercolor="#000066">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblPrjIdq" runat="server"   
                            >工程号</asp:Label>
                        <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="112px"  Enabled="False">
                        </asp:DropDownList></td>
                    <td>
                        <asp:Label ID="lblCaseTypeIdq" runat="server" Width="56px"  
                            >用例类型</asp:Label>
                        <asp:DropDownList ID="ddlCaseTypeIdq" runat="server" Width="112px" >
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblCaseNameq" runat="server" Width="56px"  
                            >用例名称</asp:Label>
                        <asp:TextBox ID="txtCaseNameq" runat="server" Width="100px" ></asp:TextBox></td>
                    <td>
                        <asp:Button ID="btnQuery" runat="server" Width="78px" Height="28px" Text="查询"></asp:Button></td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:DataGrid ID="dgPrjCases" runat="server" Width="504px" Height="154px" Font-Names="宋体"
                            Font-Size="Smaller" BackColor="#999966" AllowPaging="True" AutoGenerateColumns="False"
                            PageSize="15" AllowSorting="True">
                            <HeaderStyle BackColor="#66CCFF"></HeaderStyle>
                            <Columns>
                                <asp:BoundColumn Visible="False" DataField="CaseId" HeaderText="用例编号"></asp:BoundColumn>
                                <asp:BoundColumn DataField="CaseName" SortExpression="CaseName" HeaderText="用例名称"></asp:BoundColumn>
                                <asp:BoundColumn Visible="False" DataField="PrjName" HeaderText="工程号"></asp:BoundColumn>
                                <asp:BoundColumn DataField="CaseContent" SortExpression="CaseContent" HeaderText="用例详细内容">
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="CaseTypeName" SortExpression="CaseTypeName" HeaderText="用例类型">
                                </asp:BoundColumn>
                                <asp:BoundColumn Visible="False" DataField="UserId" HeaderText="用户号"></asp:BoundColumn>
                                <asp:BoundColumn DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundColumn>
                                <asp:BoundColumn Visible="False" DataField="Memo" HeaderText="说明"></asp:BoundColumn>
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
                </tr>
            </table>
            <asp:Image ID="imgSplit" Style="z-index: 107; left: 528px; position: absolute; top: 24px"
                runat="server" Width="4px" Height="480px" ImageUrl="../pic/newbtm8.jpg"></asp:Image>

    </form>
</body>
</html>
