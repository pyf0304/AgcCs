<%@ Page Language="c#" CodeBehind="wfmSysDefaValName_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmSysDefaValName_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucSysDefaValName" Src="wucSysDefaValName.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>表SysDefaValName的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
      
            <asp:Label ID="Label1" Style="z-index: 103; left: 8px; position: absolute; top: 8px"
                runat="server" Font-Size="Larger" Font-Names="黑体"  Width="272px"
                ForeColor="Blue">系统设置->系统属性和缺省值维护</asp:Label>
            <asp:Label ID="Label2" Style="z-index: 105; left: 304px; position: absolute; top: 8px"
                runat="server"  Width="42px"
                ForeColor="#004040" Font-Bold="True">说明：</asp:Label>
            <asp:Label ID="Label3" Style="z-index: 101; left: 344px; position: absolute; top: 8px"
                runat="server"  Height="32px" Width="368px"
                ForeColor="#004040">系统属性和缺省值设置用来对该系统中的一些属性设置初始化值，在系统被调用时初始化系统</asp:Label>
            <table id="tabLayout" style="z-index: 100; left: 496px; width: 285px; position: absolute;
                top: 56px; height: 192px" cellspacing="1" cellpadding="1" width="285" border="4"
                bordercolor="#333366">
                <tr>
                    <td valign="top">
                        <asp:Button ID="btnOKUpd" runat="server"   Text="添加"></asp:Button>
                        <asp:Label ID="lblMsg" runat="server" Width="168px" ></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <uc1:wucSysDefaValName id="wucSysDefaValName1" runat="server">
                        </uc1:wucSysDefaValName></td>
                </tr>
            </table>
            <table id="Table1" style="z-index: 104; left: 16px; position: absolute; top: 56px"
                cellspacing="1" cellpadding="1" width="300" border="4" bordercolor="#333366">
                <tr>
                    <td>
                        <asp:Label ID="lblDefaValNameIdq" runat="server" Width="100px"  
                            >缺省值编号</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtDefaValNameIdq" runat="server" Width="100px"  
                            ></asp:TextBox></td>
                    <td>
                        <asp:Label ID="lblPrjIdq" runat="server" Width="100px"  
                            >项目名称</asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="100px"  
                            >
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDefaValNameq" runat="server" Width="100px"  
                            >缺省值名称</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtDefaValNameq" runat="server" Width="100px"  
                            ></asp:TextBox></td>
                    <td>
                        <asp:Label ID="lblSysDefaValueq" runat="server" Width="100px"  
                            >系统缺省值</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtSysDefaValueq" runat="server" Width="100px" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                    </td>
                    <td colspan="2">
                        <asp:Button ID="btnQuery" runat="server"  Text="查询"></asp:Button></td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:DataGrid ID="dgSysDefaValName" runat="server" Width="463px" Height="154px" AutoGenerateColumns="False"
                            PageSize="5" AllowPaging="True" Font-Names="宋体" Font-Size="Smaller">
                            <ItemStyle BackColor="Ivory"></ItemStyle>
                            <HeaderStyle BackColor="#CC99FF"></HeaderStyle>
                            <Columns>
                                <asp:BoundColumn DataField="DefaValNameId" HeaderText="缺省值编号"></asp:BoundColumn>
                                <asp:BoundColumn DataField="ProjectsPrjName" HeaderText="项目名称"></asp:BoundColumn>
                                <asp:BoundColumn DataField="DefaValName" HeaderText="缺省值名称"></asp:BoundColumn>
                                <asp:BoundColumn DataField="SysDefaValue" HeaderText="系统缺省值"></asp:BoundColumn>
                                <asp:ButtonColumn Text="修改" HeaderText="功能列" CommandName="Update"></asp:ButtonColumn>
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
                    <td colspan="2" style="width: 89px">
                        <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="宋体"
                            Font-Size="Smaller">查询结果记录数：</asp:Label></td>
                    <td colspan="2">
                        <asp:TextBox ID="txtRecCount" runat="server" Width="111px"  Font-Names="宋体"
                            Font-Size="Smaller" ReadOnly="True"></asp:TextBox></td>
                </tr>
            </table>
       
    </form>
</body>
</html>
