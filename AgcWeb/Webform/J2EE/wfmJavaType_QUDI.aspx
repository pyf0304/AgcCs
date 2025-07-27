<%@ Register TagPrefix="uc1" TagName="wucJavaType" Src="wucJavaType.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmJavaType_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmJavaType_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表JavaType的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <table id="tabTitle" style="z-index: 101; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                        Font-Bold="True">Java类型维护</asp:Label>
                </td>
            </tr>
        </table>
        <div id="divJavaType" style="z-index: 102; left: 8px; width: 640px; position: absolute; top: 35px; height: 25px"
            runat="server">
            <asp:Label ID="lblJavaTypeIdq" Style="z-index: 104; left: 10px; position: absolute; top: 5px"
                runat="server" Width="70px">
  Java类型Id</asp:Label>
            <asp:TextBox ID="txtJavaTypeIdq" Style="z-index: 105; left: 85px; position: absolute; top: 2px"
                runat="server" Width="112px"></asp:TextBox>
            <asp:Label ID="lblJavaTypeNameq" Style="z-index: 107; left: 208px; position: absolute; top: 5px"
                runat="server" Width="88px">
  Java类型名称</asp:Label>
            <asp:TextBox ID="txtJavaTypeNameq" Style="z-index: 108; left: 312px; position: absolute; top: 2px"
                runat="server" Width="176px"></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 110; left: 512px; position: absolute; top: 1px"
                runat="server"  
                Text="查询"></asp:Button>
        </div>
        <table id="Table1" style="z-index: 105; left: 8px; position: absolute; top: 72px"
            cellspacing="0" cellpadding="0" width="300" border="0">
            <tr>
                <td>
                    <table id="tabJavaTypeDataGrid" style="width: 441px" cellspacing="0"
                        cellpadding="0" width="441" border="0" runat="server">
                        <tr>
                            <td style="height: 16px">
                                <div style="display: inline; width: 500px; position: relative; height: 24px">
                                    <asp:Button ID="btnAddNewRec4Dg1" Style="z-index: 106; left: 50px; position: absolute; top: 0px"
                                        runat="server"   Text="添加"></asp:Button>
                                    <asp:Button ID="btnDelete4Dg" Style="z-index: 104; left: 135px; position: absolute; top: 0px"
                                        runat="server"   Text="删除" OnClick="btnDelete4Dg_Click1"></asp:Button>
                                    <asp:Button ID="btnUpdate4Dg" Style="z-index: 105; left: 220px; position: absolute; top: 0px"
                                        runat="server"   Text="修改"></asp:Button>
                                    <asp:Button ID="btnExportExcel4Dg" Style="z-index: 107; left: 305px; position: absolute; top: 0px"
                                        runat="server"   Text="导出Excel" OnClick="btnExportExcel4Dg_Click1"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgJavaType" runat="server" Width="552px" AutoGenerateColumns="False"
                                    AllowPaging="True" AllowSorting="True"
                                    BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White"
                                    CellPadding="3" GridLines="Horizontal">
                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                    <Columns>
                                        <asp:TemplateColumn HeaderText="选择">
                                            <HeaderStyle Width="15px"></HeaderStyle>
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server">全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="JavaTypeId" SortExpression="JavaTypeId" HeaderText="Java类型Id"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="JavaTypeName" SortExpression="JavaTypeName" HeaderText="Java类型名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundColumn>
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
                                <table id="tabJavaTypeJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                                    cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                    <tr>
                                        <td>
                                            <font style="background-color: #c0c0c0">共有记录:</font>
                                                <asp:Label ID="lblJavaTypeRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">总页数:</font>
                                                <asp:Label ID="lblJavaTypeAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">当前页:
                                                        <asp:Label ID="lblJavaTypeCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <asp:Button ID="btnJavaTypePrevPage" runat="server"
                                                        Width="50px" Text="上一页"></asp:Button>
                                                    <asp:Button ID="btnJavaTypeNextPage" runat="server"
                                                        Width="50px" Text="下一页"></asp:Button>
                                                    到第
                                                        <asp:TextBox ID="txtJavaTypeJump2Page" runat="server"
                                                            Width="35px"></asp:TextBox>页
                                                        <asp:Button ID="btnJavaTypeJumpPage" runat="server"
                                                            Width="35px" Text="确定"></asp:Button>
                                                    <asp:CompareValidator ID="JavaTypeCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                        ErrorMessage="错误！" ControlToValidate="txtJavaTypeJump2Page" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditJavaTypeRegion" style="width: 373px; height: 200px" cellspacing="1"
                        cellpadding="1" width="373" border="1">
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
                                <uc1:wucJavaType ID="wucJavaType1" runat="server"></uc1:wucJavaType>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
