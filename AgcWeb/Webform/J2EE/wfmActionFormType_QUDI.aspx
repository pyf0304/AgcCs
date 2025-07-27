<%@ Page Language="c#" CodeBehind="wfmActionFormType_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmActionFormType_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucActionFormType" Src="wucActionFormType.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表ActionFormType的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <table id="tabTitle" style="z-index: 101; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Bold="True" ForeColor="White" Font-Names="宋体"
                        Font-Size="Small">ActionFormType表的查询、修改、删除、添加</asp:Label></td>
            </tr>
        </table>
        <div id="divActionFormType" style="z-index: 102; left: 8px; width: 833px; position: absolute; top: 35px; height: 32px"
            runat="server">
            <asp:Label ID="lblActionFormTypeName_q" Style="z-index: 107; left: 8px; position: absolute; top: 0px"
                runat="server"
                Width="136px">
  ActionForm类型名称</asp:Label>
            <asp:TextBox ID="txtActionFormTypeName_q" Style="z-index: 108; left: 160px; position: absolute; top: 0px"
                runat="server" Width="192px"></asp:TextBox>
            <asp:Label ID="lblFormBeanClass_q" Style="z-index: 110; left: 360px; position: absolute; top: 8px"
                runat="server"
                Width="96px">
  FormBean类名</asp:Label>
            <asp:TextBox ID="txtFormBeanClass_q" Style="z-index: 111; left: 464px; position: absolute; top: 8px"
                runat="server" Width="288px"></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 113; left: 752px; position: absolute; top: 8px"
                runat="server"  
                Text="查询"></asp:Button>
        </div>
        <table id="Table1" style="z-index: 105; left: 8px; position: absolute; top: 72px"
            cellspacing="0" cellpadding="0" width="300" border="0">
            <tr>
                <td>
                    <table id="tabActionFormTypeDataGrid" style="width: 552px" cellspacing="0"
                        cellpadding="0" width="552" border="0" runat="server">
                        <tr>
                            <td>
                                <div style="display: inline; width: 500px; position: relative; height: 24px">
                                    <asp:Button ID="btnAddNewRec4Dg1" Style="z-index: 106; left: 50px; position: absolute; top: 0px"
                                        runat="server"   Text="添加"></asp:Button>
                                    <asp:Button ID="btnDelete4Dg" Style="z-index: 104; left: 135px; position: absolute; top: 0px"
                                        runat="server"   Text="删除"></asp:Button>
                                    <asp:Button ID="btnUpdate4Dg" Style="z-index: 105; left: 220px; position: absolute; top: 0px"
                                        runat="server"   Text="修改"></asp:Button>
                                    <asp:Button ID="btnExportExcel4Dg" Style="z-index: 107; left: 305px; position: absolute; top: 0px"
                                        runat="server"   Text="导出Excel"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgActionFormType" runat="server"
                                    Width="824px" GridLines="Horizontal" CellPadding="3" BackColor="White" BorderWidth="1px"
                                    BorderStyle="None" BorderColor="#E7E7FF" AllowSorting="True" AllowPaging="True"
                                    AutoGenerateColumns="False">
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
                                        <asp:BoundColumn DataField="ActionFormTypeId" SortExpression="ActionFormTypeId" HeaderText="ActionForm类型ID"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ActionFormTypeName" SortExpression="ActionFormTypeName"
                                            HeaderText="ActionForm类型名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FormBeanClass" SortExpression="FormBeanClass" HeaderText="FormBean类名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundColumn>
                                        <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
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
                                <table id="tabActionFormTypeJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                                    cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                    <tr>
                                        <td>
                                            <font style="background-color: #c0c0c0">共有记录:</font>
                                                <asp:Label ID="lblActionFormTypeRecCount" runat="server" ForeColor="#000066" Width="46px">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">总页数:</font>
                                                <asp:Label ID="lblActionFormTypeAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">当前页:
                                                        <asp:Label ID="lblActionFormTypeCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <asp:Button ID="btnActionFormTypePrevPage" runat="server"
                                                        Width="50px" Text="上一页"></asp:Button><asp:Button ID="btnActionFormTypeNextPage" runat="server"
                                                            Width="50px" Text="下一页"></asp:Button>到第
                                                        <asp:TextBox ID="txtActionFormTypeJump2Page" runat="server"
                                                            Width="35px"></asp:TextBox>页
                                                        <asp:Button ID="btnActionFormTypeJumpPage" runat="server"
                                                            Width="35px" Text="确定"></asp:Button><asp:CompareValidator ID="ActionFormTypeCompareValidator1"
                                                                runat="server" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"
                                                                ControlToValidate="txtActionFormTypeJump2Page" ErrorMessage="错误！"></asp:CompareValidator></font></font></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditActionFormTypeRegion" style="width: 373px; height: 200px" cellspacing="1"
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
                                <uc1:wucActionFormType ID="wucActionFormType1" runat="server"></uc1:wucActionFormType>
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
        </table>

    </form>
</body>
</html>
