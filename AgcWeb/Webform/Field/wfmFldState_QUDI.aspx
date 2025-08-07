<%@ Register TagPrefix="uc1" TagName="wucFldState" Src="wucFldState.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmFldState_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmFldState_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表FldState的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <img style="z-index: 105; left: 8px; position: absolute; top: 8px" height="30" alt=""
            src="../../pic/兰色标题.gif" width="840" />
        <div style="display: inline; z-index: 106; left: 16px; width: 300px; color: #000066; position: absolute; top: 16px; height: 15px">
            FldState表的查询、修改、删除、添加
        </div>
        <div id="divFldState" style="z-index: 119; left: 8px; width: 608px; position: absolute; top: 35px; height: 32px"
            runat="server">
            <asp:Label ID="lblFldStateIdq" Style="z-index: 104; left: 10px; position: absolute; top: 5px"
                runat="server" Width="70px">
  字段状态Id</asp:Label>
            <asp:TextBox ID="txtFldStateIdq" Style="z-index: 105; left: 85px; position: absolute; top: 5px"
                runat="server" Width="70px"></asp:TextBox>
            <asp:Label ID="lblFldStateNameq" Style="z-index: 107; left: 224px; position: absolute; top: 8px"
                runat="server" Width="70px">
  字段状态名</asp:Label>
            <asp:TextBox ID="txtFldStateNameq" Style="z-index: 108; left: 312px; position: absolute; top: 8px"
                runat="server" Width="128px"></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 113; left: 464px; position: absolute; top: 8px"
                runat="server"  
                Text="查询"></asp:Button>
        </div>
        <table id="tabFldStateDataGrid" style="z-index: 225; left: 8px; width: 552px; position: absolute; top: 80px; height: 350px"
            cellspacing="0" cellpadding="0"
            width="552" border="0" runat="server">
            <tr>
                <td>
                    <asp:DataGrid ID="dgFldState" runat="server" Width="600px" Height="300px" AutoGenerateColumns="False"
                        PageSize="7" AllowPaging="true" AllowSorting="true">
                        <Columns>
                            <asp:BoundColumn DataField="FldStateId" SortExpression="FldStateId" HeaderText="字段状态Id"></asp:BoundColumn>
                            <asp:BoundColumn DataField="FldStateName" SortExpression="FldStateName" HeaderText="字段状态名"></asp:BoundColumn>
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
                    <table id="tabFldStateJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                        cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                        <tr>
                            <td>
                                <font style="background-color: #c0c0c0">共有记录:</font>
                                    <asp:Label ID="lblFldStateRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">总页数:</font>
                                    <asp:Label ID="lblFldStateAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">当前页:
                                            <asp:Label ID="lblFldStateCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnFldStatePrevPage" runat="server"
                                            Width="50px" Text="上一页"></asp:Button>
                                        <asp:Button ID="btnFldStateNextPage" runat="server"
                                            Width="50px" Text="下一页"></asp:Button>
                                        到第
                                            <asp:TextBox ID="txtFldStateJump2Page" runat="server"
                                                Width="35px"></asp:TextBox>页
                                            <asp:Button ID="btnFldStateJumpPage" runat="server"
                                                Width="35px" Text="确定"></asp:Button>
                                        <asp:CompareValidator ID="FldStateCompareValidator1" runat="server" ForeColor="DarkOrange"
                                            ErrorMessage="错误！" ControlToValidate="txtFldStateJump2Page" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font>
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
        <table id="tabLayout" style="z-index: 229; left: 608px; width: 373px; position: absolute; top: 80px; height: 200px"
            cellspacing="1" cellpadding="1" width="373" border="1">
            <tr>
                <td>
                    <asp:Button ID="btnOKUpd" runat="server"  
                        Text="添加"></asp:Button>
                    <asp:Label ID="lblMsg" runat="server" Width="70px"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <uc1:wucFldState ID="wucFldState1" runat="server"></uc1:wucFldState>
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
