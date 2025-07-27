<%@ Register TagPrefix="uc1" TagName="wucPrjProcess" Src="wucPrjProcess.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmPrjProcess_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmPrjProcess_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表PrjProcess的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <img style="z-index: 105; left: 8px; position: absolute; top: 8px" height="30" alt=""
            src="../../pic/兰色标题.gif" width="840" />
        <div style="display: inline; z-index: 106; left: 16px; width: 300px; color: #000066; position: absolute; top: 16px; height: 15px">
            PrjProcess表的查询、修改、删除、添加
        </div>
        <div id="divPrjProcess" style="z-index: 119; left: 8px; width: 600px; position: absolute; top: 35px; height: 32px"
            runat="server">
            <asp:Label ID="lblPrjProcessNameq" Style="z-index: 104; left: 10px; position: absolute; top: 5px"
                runat="server" >
  项目过程名称</asp:Label>
            <asp:TextBox ID="txtPrjProcessNameq" Style="z-index: 105; left: 112px; position: absolute; top: 8px"
                runat="server" Width="70px"></asp:TextBox>
            <asp:Label ID="lblPrjProcessTypeIdq" Style="z-index: 107; left: 192px; position: absolute; top: 8px"
                runat="server" Width="96px">
  项目过程分类ID</asp:Label>
            <asp:DropDownList ID="ddlPrjProcessTypeIdq" Style="z-index: 108; left: 304px; position: absolute; top: 8px"
                runat="server" Width="120px">
            </asp:DropDownList>
            <asp:Button ID="btnQuery" Style="z-index: 110; left: 440px; position: absolute; top: 8px"
                runat="server"  
                Text="查询"></asp:Button>
        </div>
        <table id="tabPrjProcessDataGrid" style="z-index: 225; left: 8px; width: 504px; position: absolute; top: 72px; height: 350px"
            cellspacing="0" cellpadding="0"
            width="504" border="0" runat="server">
            <tr>
                <td>
                    <asp:DataGrid ID="dgPrjProcess" runat="server" Width="496px" Height="257px" AutoGenerateColumns="False"
                        PageSize="7" AllowPaging="True" AllowSorting="True">
                        <Columns>
                            <asp:BoundColumn Visible="False" DataField="PrjProcessId" SortExpression="PrjProcessId"
                                HeaderText="项目过程ID"></asp:BoundColumn>
                            <asp:BoundColumn DataField="PrjProcessName" SortExpression="PrjProcessName" HeaderText="项目过程">
                                <HeaderStyle></HeaderStyle>
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="PrjProcessTypePrjProcessTypeName" SortExpression="PrjProcessTypeId"
                                HeaderText="过程分类">
                                <HeaderStyle></HeaderStyle>
                            </asp:BoundColumn>
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
                    <table id="tabPrjProcessJumpPage" style="width: 496px; font-family: Verdana; height: 26px"
                        cellspacing="0" cellpadding="0" width="496" border="1" runat="server">
                        <tr>
                            <td>
                                <font style="background-color: #c0c0c0">共有记录:</font>
                                    <asp:Label ID="lblPrjProcessRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                    <font style="background-color: #c0c0c0">总页数:</font>
                                    <asp:Label ID="lblPrjProcessAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                    <font style="background-color: #c0c0c0">当前页:
                                            <asp:Label ID="lblPrjProcessCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                        <asp:Button ID="btnPrjProcessPrevPage" runat="server"
                                            Width="50px" Text="上一页"></asp:Button>
                                        <asp:Button ID="btnPrjProcessNextPage" runat="server"
                                            Width="50px" Text="下一页"></asp:Button>
                                        到第
                                            <asp:TextBox ID="txtPrjProcessJump2Page" runat="server"
                                                Width="32px"></asp:TextBox>页
                                            <asp:Button ID="btnPrjProcessJumpPage" runat="server"
                                                Width="35px" Text="确定"></asp:Button>
                                        <asp:CompareValidator ID="PrjProcessCompareValidator1" runat="server" ForeColor="DarkOrange"
                                            ErrorMessage="错误！" ControlToValidate="txtPrjProcessJump2Page" Type="Integer"
                                            Operator="DataTypeCheck" ></asp:CompareValidator></font></font>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <table id="tabLayout" style="z-index: 223; left: 512px; width: 373px; position: absolute; top: 72px; height: 200px"
            cellspacing="1" cellpadding="1" width="373" border="1">
            <tr>
                <td>
                    <asp:Button ID="btnOKUpd" runat="server"  
                        Text="添加"></asp:Button>
                    <asp:Label ID="lblMsg" runat="server" Width="144px"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <uc1:wucPrjProcess ID="wucPrjProcess1" runat="server"></uc1:wucPrjProcess>
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
