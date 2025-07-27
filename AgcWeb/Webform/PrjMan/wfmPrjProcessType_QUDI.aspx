<%@ Register TagPrefix="uc1" TagName="wucPrjProcessType" Src="wucPrjProcessType.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmPrjProcessType_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmPrjProcessType_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表PrjProcessType的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <img style="z-index: 105; left: 8px; position: absolute; top: 8px" height="30" alt=""
            src="../../pic/兰色标题.gif" width="840" />
        <div style="display: inline; z-index: 106; left: 16px; width: 300px; color: #000066; position: absolute; top: 16px; height: 15px">
            PrjProcessType表的查询、修改、删除、添加
        </div>
        <div id="divPrjProcessType" style="z-index: 119; left: 8px; width: 584px; position: absolute; top: 35px; height: 24px"
            runat="server">
            <asp:Label ID="lblPrjProcessTypeIdq" Style="z-index: 104; left: 10px; position: absolute; top: 5px"
                runat="server" Width="96px">
  项目过程分类ID</asp:Label>
            <asp:TextBox ID="txtPrjProcessTypeIdq" Style="z-index: 105; left: 128px; position: absolute; top: 0px"
                runat="server" ></asp:TextBox>
            <asp:Label ID="lblPrjProcessTypeNameq" Style="z-index: 107; left: 216px; position: absolute; top: 0px"
                runat="server" Width="120px">
  项目过程分类名</asp:Label>
            <asp:TextBox ID="txtPrjProcessTypeNameq" Style="z-index: 108; left: 360px; position: absolute; top: 0px"
                runat="server" Width="104px"></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 110; left: 472px; position: absolute; top: 0px"
                runat="server"  
                Text="查询"></asp:Button>
        </div>
        <table id="tabPrjProcessTypeDataGrid" style="z-index: 225; left: 8px; width: 520px; position: absolute; top: 72px; height: 244px"
            cellspacing="0" cellpadding="0"
            width="520" border="0" runat="server">
            <tr>
                <td>
                    <asp:DataGrid ID="dgPrjProcessType" runat="server" Width="520px" Height="192px" AutoGenerateColumns="False"
                        PageSize="7" AllowPaging="True" AllowSorting="True">
                        <Columns>
                            <asp:BoundColumn DataField="PrjProcessTypeId" SortExpression="PrjProcessTypeId" HeaderText="过程分类ID"></asp:BoundColumn>
                            <asp:BoundColumn DataField="PrjProcessTypeName" SortExpression="PrjProcessTypeName"
                                HeaderText="过程分类名"></asp:BoundColumn>
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
                    <table id="tabPrjProcessTypeJumpPage" style="width: 528px; font-family: Verdana; height: 26px"
                        cellspacing="0" cellpadding="0" width="528" border="1" runat="server">
                        <tr>
                            <td>
                                <font style="background-color: #c0c0c0">共有记录:</font>
                                    <asp:Label ID="lblPrjProcessTypeRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">总页数:</font>
                                    <asp:Label ID="lblPrjProcessTypeAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">当前页:
                                            <asp:Label ID="lblPrjProcessTypeCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnPrjProcessTypePrevPage" runat="server"
                                            Width="50px" Text="上一页"></asp:Button>
                                        <asp:Button ID="btnPrjProcessTypeNextPage" runat="server"
                                            Width="50px" Text="下一页"></asp:Button>
                                        到第
                                            <asp:TextBox ID="txtPrjProcessTypeJump2Page" runat="server"
                                                Width="35px"></asp:TextBox>页
                                            <asp:Button ID="btnPrjProcessTypeJumpPage" runat="server"
                                                Width="35px" Text="确定"></asp:Button>
                                        <asp:CompareValidator ID="PrjProcessTypeCompareValidator1" runat="server" ForeColor="DarkOrange"
                                            ErrorMessage="错误！" ControlToValidate="txtPrjProcessTypeJump2Page" Type="Integer"
                                            Operator="DataTypeCheck"></asp:CompareValidator></font></font>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <table id="tabLayout" style="z-index: 223; left: 536px; width: 373px; position: absolute; top: 64px; height: 200px"
            cellspacing="1" cellpadding="1" width="373" border="1">
            <tr>
                <td>
                    <asp:Button ID="btnOKUpd" runat="server"  
                        Text="添加"></asp:Button>
                    <asp:Label ID="lblMsg" runat="server" Width="184px"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <uc1:wucPrjProcessType ID="wucPrjProcessType1" runat="server"></uc1:wucPrjProcessType>
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
