<%@ Page Language="c#" CodeBehind="wfmQueryOption_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmQueryOption_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucQueryOption" Src="wucQueryOption.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表QueryOption的查询、修改、删除、添加记录</title>
    
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
        
            <asp:Label ID="Label3" Style="z-index: 114; left: 8px; position: absolute; top: 8px"
                runat="server" Font-Size="Larger" Font-Names="黑体" Width="240px"
                ForeColor="Blue">项目界面管理->查询选项维护</asp:Label>
            <asp:Label ID="Label2" Style="z-index: 104; left: 272px; position: absolute; top: 8px"
                runat="server"  Width="42px"
                ForeColor="#004040" Font-Bold="True">说明：</asp:Label>
            <asp:Label ID="Label4" Style="z-index: 101; left: 328px; position: absolute; top: 8px"
                runat="server"  Height="32px" Width="464px"
                ForeColor="#004040">主要维护在界面的查询区域中，所涉及的查询方式，例如等值查询、模糊查询(即like "%")、范围查询等。</asp:Label>
            <table id="tabLayout" style="z-index: 111; left: 496px; width: 373px; position: absolute;
                top: 56px; height: 200px" cellspacing="1" cellpadding="1" width="373" border="4"
                bordercolor="#666633">
                <tr>
                    <td valign="top">
                        <asp:Button ID="btnOKUpd" runat="server"   Text="添加"></asp:Button>
                        <asp:Label ID="lblMsg" runat="server" Width="215px"></asp:Label></td>
                </tr>
                <tr>
                    <td valign="top">
                        <uc1:wucQueryOption id="wucQueryOption1" runat="server">
                        </uc1:wucQueryOption></td>
                </tr>
            </table>
            <table id="Table1" style="z-index: 115; left: 8px; position: absolute; top: 56px"
                bordercolor="#666666" cellspacing="1" cellpadding="1" width="300" border="4">
                <tr>
                    <td>
                        <asp:Label ID="lblQueryOptionId_q" runat="server"  
                            >关键字ID</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtQueryOptionId_q" runat="server" Width="100px" ></asp:TextBox></td>
                    <td>
                        <asp:Label ID="lblQueryOption_q" runat="server"  
                            >界面名称</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtQueryOption_q" runat="server" Width="100px" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                    </td>
                    <td colspan="2">
                        <asp:Button ID="btnQuery" runat="server"  Text="查询"></asp:Button></td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:DataGrid ID="dgQueryOption" runat="server" Width="463px" Height="154px" AutoGenerateColumns="False"
                            PageSize="5" AllowPaging="True" Font-Names="宋体" >
                            <Columns>
                                <asp:BoundColumn DataField="QueryOptionId" HeaderText="关键字ID"></asp:BoundColumn>
                                <asp:BoundColumn DataField="QueryOptionName" HeaderText="界面名称"></asp:BoundColumn>
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
                            >查询结果记录数：</asp:Label></td>
                    <td colspan="2">
                        <asp:TextBox ID="txtRecCount" runat="server" Width="111px"  Font-Names="宋体"
                             ReadOnly="True"></asp:TextBox></td>
                </tr>
            </table>
        </font>
    </form>
</body>
</html>
