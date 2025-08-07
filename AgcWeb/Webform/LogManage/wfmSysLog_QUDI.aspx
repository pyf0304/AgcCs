<%@ Register TagPrefix="uc1" TagName="wucSysLog" Src="wucSysLog.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmSysLog_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.wfmSysLog_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表SysLog的查询、修改、删除、添加记录</title>
    
</head>
<body background="../../pic/bg3.gif">
    <form id="Form1" method="post" runat="server">

        <table id="tabTitle" style="z-index: 102; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Bold="True" ForeColor="White" Font-Names="宋体"
                        Font-Size="Small">日志管理-->日志维护</asp:Label></td>
            </tr>
        </table>
        <asp:Button ID="btnDelete4Dg" Style="z-index: 260; left: 762px; position: absolute; top: 104px"
            runat="server"   Text="删除" OnClick="btnDelete4Dg_Click"></asp:Button>
        <div id="divSysLog" style="z-index: 119; left: 8px; width: 652px; position: absolute; top: 35px; height: 88px"
            runat="server">
            <asp:Label ID="lblUserIdq" Style="z-index: 104; left: 16px; position: absolute; top: 5px"
                runat="server">
  用户编号</asp:Label>
            <asp:TextBox ID="txtUserIdq" Style="z-index: 105; left: 72px; position: absolute; top: 0px"
                runat="server" ></asp:TextBox>
            <asp:Label ID="lblUserNameq" Style="z-index: 107; left: 16px; position: absolute; top: 33px"
                runat="server">
  用户姓名</asp:Label>
            <asp:TextBox ID="txtUserNameq" Style="z-index: 108; left: 72px; position: absolute; top: 33px"
                runat="server" ></asp:TextBox>
            <asp:Label ID="lblUserIpq" Style="z-index: 110; left: 29px; position: absolute; top: 61px"
                runat="server">
  用户IP</asp:Label>
            <asp:TextBox ID="txtUserIpq" Style="z-index: 111; left: 72px; position: absolute; top: 61px"
                runat="server" ></asp:TextBox>
            <asp:Label ID="lblOpDateq" Style="z-index: 113; left: 184px; position: absolute; top: 8px"
                runat="server">
  操作日期</asp:Label>
            <asp:TextBox ID="txtOpDateq" Style="z-index: 114; left: 240px; position: absolute; top: 8px"
                runat="server" Width="128px"></asp:TextBox>
            <asp:Label ID="lblOpTimeq" Style="z-index: 116; left: 184px; position: absolute; top: 32px"
                runat="server">
  操作时间</asp:Label>
            <asp:TextBox ID="txtOpTimeq" Style="z-index: 117; left: 240px; position: absolute; top: 32px"
                runat="server" Width="128px"></asp:TextBox>
            <asp:Label ID="lblOpTypeq" Style="z-index: 119; left: 184px; position: absolute; top: 56px"
                runat="server">
  操作类型</asp:Label>
            <asp:DropDownList ID="ddlOpTypeIdq" Style="z-index: 120; left: 240px; position: absolute; top: 56px"
                runat="server" Width="128px">
            </asp:DropDownList>
            <asp:Label ID="lblTableNameq" Style="z-index: 122; left: 413px; position: absolute; top: 8px"
                runat="server">
  数据表名</asp:Label>
            <asp:TextBox ID="txtTableNameq" Style="z-index: 123; left: 472px; position: absolute; top: 8px"
                runat="server" Width="128px"></asp:TextBox>
            <asp:Label ID="lblTableKeyq" Style="z-index: 125; left: 400px; position: absolute; top: 40px"
                runat="server">
  关键字段名</asp:Label>
            <asp:TextBox ID="txtTableKeyq" Style="z-index: 126; left: 472px; position: absolute; top: 40px"
                runat="server" Width="128px"></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 128; left: 659px; position: absolute; top: 64px"
                runat="server"  
                Text="查询" OnClick="btnQuery_Click"></asp:Button>
        </div>
        <table id="tabSysLogDataGrid" style="z-index: 225; left: 8px; width: 100%; position: absolute; top: 128px"
            cellspacing="0" cellpadding="0"
            width="100%" border="0" runat="server">
            <tr>
                <td>
                    <asp:DataGrid ID="dgSysLog" runat="server"
                        Width="100%" AllowSorting="True" AllowPaging="True" PageSize="100" AutoGenerateColumns="False"
                        BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White"
                        CellPadding="3" GridLines="Horizontal" OnItemCommand="dgSysLog_ItemCommand" OnItemCreated="dgSysLog_ItemCreated" OnPageIndexChanged="dgSysLog_PageIndexChanged" OnSortCommand="dgSysLog_SortCommand">
                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                        <Columns>
                            <asp:TemplateColumn HeaderText="选择">
                                <HeaderStyle Width="30px"></HeaderStyle>
                                <HeaderTemplate>
                                    <asp:LinkButton ID="lbSelAll" runat="server"
                                        CommandName="lbSelAll" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn Visible="False" DataField="mId" SortExpression="mId" HeaderText="编号">
                               
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="UserId" SortExpression="UserId" HeaderText="用户号">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="UserName" SortExpression="UserName" HeaderText="用户名">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="UserIp" SortExpression="UserIp" HeaderText="用户IP">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="OpDate" SortExpression="OpDate" HeaderText="操作日期">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="OpTime" SortExpression="OpTime" HeaderText="操作时间">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="OpTypeName" SortExpression="OpTypeName" HeaderText="操作类型">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="TableName" SortExpression="TableName" HeaderText="表名">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="TableKey" SortExpression="TableKey" HeaderText="关键字名">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="PrjName" SortExpression="PrjName" HeaderText="工程"></asp:BoundColumn>
                            <asp:BoundColumn DataField="OpContent" SortExpression="OpContent" HeaderText="操作内容">
                                <HeaderStyle Width="300px"></HeaderStyle>
                            </asp:BoundColumn>
                            <asp:ButtonColumn Visible="False" Text="修改" CommandName="Update"></asp:ButtonColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
                    </asp:DataGrid></td>
            </tr>
            <tr>
                <td style="width: 605px" bgcolor="silver">
                    <table id="tabSysLogJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                        cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                        <tr>
                            <td>
                                <font style="background-color: #c0c0c0">共有记录:</font>
                                    <asp:Label ID="lblSysLogRecCount" runat="server" ForeColor="#000066" Width="46px">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">总页数:</font>
                                    <asp:Label ID="lblSysLogAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">当前页:
                                            <asp:Label ID="lblSysLogCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnSysLogPrevPage" runat="server"
                                            Width="50px" Text="上一页"></asp:Button><asp:Button ID="btnSysLogNextPage" runat="server"
                                                Width="50px" Text="下一页"></asp:Button>到第
                                            <asp:TextBox ID="txtSysLogJump2Page" runat="server"
                                                Width="35px"></asp:TextBox>页
                                            <asp:Button ID="btnSysLogJumpPage" runat="server"
                                                Width="35px" Text="确定"></asp:Button><asp:CompareValidator ID="SysLogCompareValidator1"
                                                    runat="server" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"
                                                    ControlToValidate="txtSysLogJump2Page" ErrorMessage="错误！"></asp:CompareValidator></font></font></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <table id="tabEditSysLogRegion" style="z-index: 259; left: 10px; width: 373px; position: absolute; top: 800px; height: 200px"
            cellspacing="1" cellpadding="1" width="373" border="1"
            runat="server">
            <tr>
                <td>
                    <div style="width: 360px; position: relative; height: 24px">
                        <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                            runat="server"  
                            Text="添加"></asp:Button>
                        <asp:Label ID="lblMsg" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                            runat="server" Width="208px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <uc1:wucSysLog ID="wucSysLog1" runat="server"></uc1:wucSysLog>
                </td>
            </tr>
            <tr>
                <td>
                    <div style="width: 360px; position: relative; height: 24px">
                        <asp:Button ID="btnOKUpd2" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                            runat="server"  
                            Text="添加"></asp:Button>
                        <asp:Label ID="lblMsg2" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                            runat="server" Width="208px"></asp:Label>
                    </div>
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
