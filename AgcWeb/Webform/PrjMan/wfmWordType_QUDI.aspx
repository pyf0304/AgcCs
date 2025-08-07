<%@ Register TagPrefix="uc1" TagName="wucWordType" Src="wucWordType.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmWordType_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmWordType_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表WordType的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <table id="tabTitle" style="z-index: 102; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                        Font-Bold="True">工程管理->单词分类维护</asp:Label>
                </td>
            </tr>
        </table>
        <div id="divWordType" style="z-index: 119; left: 8px; width: 256px; position: absolute; top: 35px; height: 96px"
            runat="server">
            <asp:Label ID="lblWordTypeIdq" Style="z-index: 104; left: 10px; position: absolute; top: 5px"
                runat="server" Width="70px">
  单词分类ID</asp:Label>
            <asp:TextBox ID="txtWordTypeIdq" Style="z-index: 105; left: 85px; position: absolute; top: 5px"
                runat="server" Width="70px"></asp:TextBox>
            <asp:Label ID="lblWordTypeNameq" Style="z-index: 107; left: 10px; position: absolute; top: 33px"
                runat="server" Width="70px">
  单词分类名</asp:Label>
            <asp:TextBox ID="txtWordTypeNameq" Style="z-index: 108; left: 85px; position: absolute; top: 33px"
                runat="server" Width="70px"></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 110; left: 10px; position: absolute; top: 61px"
                runat="server"  
                Text="查询"></asp:Button>
        </div>
        <table id="tabWordTypeDataGrid" style="z-index: 225; left: 8px; width: 569px; position: absolute; top: 141px; height: 208px"
            cellspacing="0"
            cellpadding="0" width="569" border="0" runat="server">
            <tr>
                <td>
                    <asp:DataGrid ID="dgWordType" runat="server" Width="500px" Height="74px" AutoGenerateColumns="False"
                        PageSize="7" AllowPaging="true" AllowSorting="true">
                        <Columns>
                            <asp:BoundColumn DataField="WordTypeId" SortExpression="WordTypeId" HeaderText="单词分类ID"></asp:BoundColumn>
                            <asp:BoundColumn DataField="WordTypeName" SortExpression="WordTypeName" HeaderText="单词分类名"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundColumn>
                            <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <PagerStyle Mode="NumericPages"></PagerStyle>
                    </asp:DataGrid>
                </td>
            </tr>
            <tr>
                <td style="width: 605px" bgcolor="silver">
                    <table id="tabWordTypeJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                        cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                        <tr>
                            <td>
                                <font style="background-color: #c0c0c0">共有记录:</font>
                                    <asp:Label ID="lblWordTypeRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">总页数:</font>
                                    <asp:Label ID="lblWordTypeAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">当前页:
                                            <asp:Label ID="lblWordTypeCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnWordTypePrevPage" runat="server"
                                            Width="50px" Text="上一页"></asp:Button>
                                        <asp:Button ID="btnWordTypeNextPage" runat="server"
                                            Width="50px" Text="下一页"></asp:Button>
                                        到第
                                            <asp:TextBox ID="txtWordTypeJump2Page" runat="server"
                                                Width="35px"></asp:TextBox>页
                                            <asp:Button ID="btnWordTypeJumpPage" runat="server"
                                                Width="35px" Text="确定"></asp:Button>
                                        <asp:CompareValidator ID="WordTypeCompareValidator1" runat="server" ForeColor="DarkOrange"
                                            ErrorMessage="错误！" ControlToValidate="txtWordTypeJump2Page" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <table id="tabLayout" style="z-index: 223; left: 10px; width: 373px; position: absolute; top: 376px; height: 200px"
            cellspacing="1" cellpadding="1" width="373" border="1">
            <tr>
                <td>
                    <asp:Button ID="btnOKUpd" runat="server"  
                        Text="添加"></asp:Button></td>
                <td>
                    <asp:Label ID="lblMsg" runat="server" Width="232px"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2">
                    <uc1:wucWordType ID="wucWordType1" runat="server"></uc1:wucWordType>
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
