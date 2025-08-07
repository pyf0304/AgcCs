<%@ Register TagPrefix="uc1" TagName="wucTabState" Src="wucTabState.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmTabState_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmTabState_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表TabState的查询、修改、删除、添加记录</title>
    
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

        <img style="z-index: 105; left: 8px; position: absolute; top: 8px" height="30" alt=""
            src="../../pic/兰色标题.gif" width="840"/>
        <div style="display: inline; z-index: 106; left: 16px; width: 300px; color: #000066; position: absolute; top: 16px; height: 15px">
            TabState表的查询、修改、删除、添加
        </div>
        <div id="divTabState" style="z-index: 119; left: 8px; width: 600px; position: absolute; top: 35px; height: 27px"
            runat="server">
            <asp:Label ID="lblTabStateIdq" Style="z-index: 104; left: 10px; position: absolute; top: 5px"
                runat="server" Width="70px">
  表状态ID</asp:Label>
            <asp:TextBox ID="txtTabStateIdq" Style="z-index: 105; left: 85px; position: absolute; top: 5px"
                runat="server" Width="120px"></asp:TextBox>
            <asp:Label ID="lblTabStateNameq" Style="z-index: 107; left: 216px; position: absolute; top: 0px"
                runat="server" Width="70px">
  表状态名称</asp:Label>
            <asp:TextBox ID="txtTabStateNameq" Style="z-index: 108; left: 304px; position: absolute; top: 0px"
                runat="server" Width="152px"></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 110; left: 480px; position: absolute; top: 0px"
                runat="server"  
                Text="查询"></asp:Button>
        </div>
        <table id="tabTabStateDataGrid" style="z-index: 225; left: 8px; width: 568px; position: absolute; top: 64px; height: 256px"
            cellspacing="0" cellpadding="0"
            width="568" border="0" runat="server">
            <tr>
                <td>
                    <asp:DataGrid ID="dgTabState" runat="server" Width="552px" Height="196px" AutoGenerateColumns="False"
                        PageSize="7" AllowPaging="true" AllowSorting="true">
                        <Columns>
                            <asp:BoundColumn DataField="TabStateId" SortExpression="TabStateId" HeaderText="表状态ID"></asp:BoundColumn>
                            <asp:BoundColumn DataField="TabStateName" SortExpression="TabStateName" HeaderText="表状态名称"></asp:BoundColumn>
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
                    <table id="tabTabStateJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                        cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                        <tr>
                            <td>
                                <font style="background-color: #c0c0c0">共有记录:</font>
                                    <asp:Label ID="lblTabStateRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">总页数:</font>
                                    <asp:Label ID="lblTabStateAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">当前页:
                                            <asp:Label ID="lblTabStateCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnTabStatePrevPage" runat="server"
                                            Width="50px" Text="上一页"></asp:Button>
                                        <asp:Button ID="btnTabStateNextPage" runat="server"
                                            Width="50px" Text="下一页"></asp:Button>
                                        到第
                                            <asp:TextBox ID="txtTabStateJump2Page" runat="server"
                                                Width="35px"></asp:TextBox>页
                                            <asp:Button ID="btnTabStateJumpPage" runat="server"
                                                Width="35px" Text="确定"></asp:Button>
                                        <asp:CompareValidator ID="TabStateCompareValidator1" runat="server" ForeColor="DarkOrange"
                                            ErrorMessage="错误！" ControlToValidate="txtTabStateJump2Page" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <input id="rd" style="z-index: 109; left: 896px; width: 24px; position: absolute; top: 48px; height: 22px"
            type="hidden" size="1" name="rd" runat="server">
        <input style="display: none; z-index: 110; left: 8px; position: absolute; top: 8px"
            type="radio" checked name="RadioName">
        <table id="tabLayout" style="z-index: 223; left: 576px; width: 280px; position: absolute; top: 56px; height: 200px"
            cellspacing="1" cellpadding="1" width="280" border="1">
            <tr>
                <td>
                    <asp:Button ID="btnOKUpd" runat="server"  
                        Text="添加"></asp:Button>
                    <asp:Label ID="lblMsg" runat="server" Width="224px"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <uc1:wucTabState ID="wucTabState1" runat="server"></uc1:wucTabState>
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
