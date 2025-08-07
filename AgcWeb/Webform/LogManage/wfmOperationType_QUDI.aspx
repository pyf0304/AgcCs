<%@ Register TagPrefix="uc1" TagName="wucOperationType" Src="wucOperationType.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmOperationType_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.wfmOperationType_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表OperationType的查询、修改、删除、添加记录</title>
    
</head>
<body background="../../pic/bg3.gif">
    <form id="Form1" method="post" runat="server">

        <table id="tabTitle" style="z-index: 102; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                        Font-Bold="True">日志管理-->操作类型维护</asp:Label>
                </td>
            </tr>
        </table>
        <div id="divOperationType" style="z-index: 119; left: 8px; width: 593px; position: absolute; top: 35px; height: 24px"
            runat="server">
            <asp:Label ID="lblOperationTypeq" Style="z-index: 104; left: 24px; position: absolute; top: 4px"
                runat="server">
  操作类型Id</asp:Label>
            <asp:TextBox ID="txtOperationTypeq" Style="z-index: 105; left: 96px; position: absolute; top: 1px"
                runat="server" Width="128px"></asp:TextBox>
            <asp:Label ID="lblOperationTypeNameq" Style="z-index: 107; left: 272px; position: absolute; top: 4px"
                runat="server" >
  操作类型名称</asp:Label>
            <asp:TextBox ID="txtOperationTypeNameq" Style="z-index: 108; left: 352px; position: absolute; top: 1px"
                runat="server" Width="152px"></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 113; left: 512px; position: absolute; top: 0px"
                runat="server" Width="56px" 
                Text="查询"></asp:Button>
        </div>
        <table id="tabOperationTypeDataGrid" style="z-index: 225; left: 8px; width: 552px; position: absolute; top: 64px"
            cellspacing="0" cellpadding="0"
            width="552" border="0" runat="server">
            <tr>
                <td>
                    <asp:DataGrid ID="dgOperationType" runat="server" Width="632px" AutoGenerateColumns="False"
                        PageSize="7" AllowPaging="True" AllowSorting="True"
                        BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White"
                        CellPadding="3" GridLines="Horizontal">
                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                        <Columns>
                            <asp:BoundColumn DataField="OpTypeId" SortExpression="OpTypeId" HeaderText="操作类型编号"></asp:BoundColumn>
                            <asp:BoundColumn DataField="OpTypeName" SortExpression="OpTypeName" HeaderText="操作类型名称"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Memo" SortExpression="Memo" HeaderText="备注"></asp:BoundColumn>
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
                <td style="width: 605px" bgcolor="silver">
                    <table id="tabOperationTypeJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                        cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                        <tr>
                            <td>
                                <font style="background-color: #c0c0c0">共有记录:</font>
                                    <asp:Label ID="lblOperationTypeRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">总页数:</font>
                                    <asp:Label ID="lblOperationTypeAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">当前页:
                                            <asp:Label ID="lblOperationTypeCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnOperationTypePrevPage" runat="server"
                                            Width="50px" Text="上一页"></asp:Button>
                                        <asp:Button ID="btnOperationTypeNextPage" runat="server"
                                            Width="50px" Text="下一页"></asp:Button>
                                        到第
                                            <asp:TextBox ID="txtOperationTypeJump2Page" runat="server"
                                                Width="35px"></asp:TextBox>页
                                            <asp:Button ID="btnOperationTypeJumpPage" runat="server"
                                                Width="35px" Text="确定"></asp:Button>
                                        <asp:CompareValidator ID="OperationTypeCompareValidator1" runat="server" ForeColor="DarkOrange"
                                            ErrorMessage="错误！" ControlToValidate="txtOperationTypeJump2Page" Type="Integer"
                                            Operator="DataTypeCheck"></asp:CompareValidator></font></font>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <table id="tabEditOperationTypeRegion" style="z-index: 229; left: 10px; width: 373px; position: absolute; top: 288px; height: 128px"
            cellspacing="1" cellpadding="1"
            width="373" border="1">
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
                    <uc1:wucOperationType ID="wucOperationType1" runat="server"></uc1:wucOperationType>
                </td>
            </tr>
            <tr>
                <td></td>
            </tr>
        </table>

    </form>
</body>
</html>
