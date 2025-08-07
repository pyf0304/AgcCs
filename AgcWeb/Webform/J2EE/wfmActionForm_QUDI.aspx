<%@ Page Language="c#" CodeBehind="wfmActionForm_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmActionForm_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucActionForm" Src="wucActionForm.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>表ActionForm的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

            <table id="tabTitle" style="z-index: 101; left: 8px; position: absolute; top: 8px"
                cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
                <tr>
                    <td bgcolor="#ff6666">
                        <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                            Font-Bold="True">ActionForm维护</asp:Label>
                        <asp:Label ID="lblViewGroupId_q" runat="server" Width="70px" >
  界面组：</asp:Label>
                        <asp:Label ID="lblViewGroupName" runat="server" Width="70px">界面组： </asp:Label>
                    </td>
                </tr>
            </table>
            <div id="divActionForm" style="z-index: 102; left: 8px; width: 713px; position: absolute;
                top: 35px; height: 32px" runat="server">
                <asp:Label ID="lblActionFormName_q" Style="z-index: 100; left: 10px; position: absolute;
                    top: 5px" runat="server" Width="104px" >
  ActionForm名称</asp:Label>
                <asp:TextBox ID="txtActionFormName_q" Style="z-index: 101; left: 120px; position: absolute;
                    top: 0px" runat="server" Width="192px" ></asp:TextBox>
                <asp:Button ID="btnQuery" Style="z-index: 106; left: 640px; position: absolute; top: 0px"
                    runat="server" Width="64px" Text="查询"></asp:Button>
                <asp:Label ID="lblActionFormTypeId_q" Style="z-index: 107; left: 320px; position: absolute;
                    top: 8px" runat="server" Width="104px">ActionForm类型</asp:Label>
                <asp:DropDownList ID="ddlActionFormTypeId_q" Style="z-index: 108; left: 432px; position: absolute;
                    top: 8px" runat="server"  Width="192px">
                </asp:DropDownList>
            </div>
            <table id="Table1" style="z-index: 105; left: 8px; position: absolute; top: 80px"
                cellspacing="0" cellpadding="0" width="300" border="0">
                <tr>
                    <td>
                        <table id="tabActionFormDataGrid" style="width: 552px" cellspacing="0"
                            cellpadding="0" width="552" border="0" runat="server">
                            <tr>
                                <td style="height: 16px">
                                    <div style="display: inline; width: 696px; position: relative; height: 24px">
                                        <asp:Button ID="btnAddNewRec4Dg1" Style="z-index: 103; left: 50px; position: absolute;
                                            top: 0px" runat="server"   Text="添加"></asp:Button>
                                        <asp:Button ID="btnDelete4Dg" Style="z-index: 100; left: 135px; position: absolute;
                                            top: 0px" runat="server"   Text="删除"></asp:Button>
                                        <asp:Button ID="btnUpdate4Dg" Style="z-index: 102; left: 220px; position: absolute;
                                            top: 0px" runat="server"   Text="修改" OnClick="btnUpdate4Dg_Click"></asp:Button>
                                        <asp:Button ID="btnExportExcel4Dg" Style="z-index: 104; left: 552px; position: absolute;
                                            top: 0px" runat="server"   Text="导出Excel"></asp:Button>
                                        <asp:Button ID="btnEditActionFormProperty" Style="z-index: 105; left: 328px; position: absolute;
                                            top: 0px" runat="server"  Width="136px" Text="编辑ActionForm属性"></asp:Button>
                                        <asp:Button ID="btnGoBack" Style="z-index: 106; left: 632px; position: absolute;
                                            top: 0px" runat="server"   Text="返回"></asp:Button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DataGrid ID="dgActionForm" runat="server" Width="704px" AllowSorting="True"
                                        AllowPaging="True" AutoGenerateColumns="False" BorderColor="#E7E7FF" BorderStyle="None"
                                        BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal">
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
                                            <asp:BoundColumn DataField="ActionFormId" SortExpression="ActionFormId" HeaderText="ActionFormId">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="ActionFormName" SortExpression="ActionFormName" HeaderText="ActionForm名称">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="ViewGroupName" SortExpression="ViewGroupName"
                                                HeaderText="界面组ID"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="ActionFormTypeName" SortExpression="ActionFormTypeName"
                                                HeaderText="ActionForm类型名称"></asp:BoundColumn>
                                            <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                            <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                        </Columns>
                                        <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                        </PagerStyle>
                                    </asp:DataGrid></td>
                            </tr>
                            <tr>
                                <td style="width: 605px" bgcolor="silver">
                                    <table id="tabActionFormJumpPage" style="width: 568px; font-family: Verdana;
                                        height: 26px" cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                        <tr>
                                            <td>
                                                <font style="background-color: #c0c0c0">共有记录:</font>
                                                    <asp:Label ID="lblActionFormRecCount" runat="server" ForeColor="#000066" Width="46px">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <font style="background-color: #c0c0c0">总页数:</font>
                                                    <asp:Label ID="lblActionFormAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <font style="background-color: #c0c0c0">当前页:
                                                        <asp:Label ID="lblActionFormCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                        <div style="display: inline; width: 16px; height: 13px">
                                                        </div>
                                                        <asp:Button ID="btnActionFormPrevPage" runat="server"  Width="50px"
                                                            Text="上一页"></asp:Button>
                                                        <asp:Button ID="btnActionFormNextPage" runat="server"  Width="50px"
                                                            Text="下一页"></asp:Button>到第
                                                        <asp:TextBox ID="txtActionFormJump2Page" runat="server"  Width="35px"></asp:TextBox>页
                                                        <asp:Button ID="btnActionFormJumpPage" runat="server"  Width="35px"
                                                            Text="确定"></asp:Button>
                                                        <asp:CompareValidator ID="ActionFormCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                            Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtActionFormJump2Page"
                                                            ErrorMessage="错误！"></asp:CompareValidator></font></font></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table id="tabEditActionFormRegion" style="width: 373px; height: 200px" cellspacing="1"
                            cellpadding="1" width="373" border="1">
                            <tr>
                                <td>
                                    <div style="width: 360px; position: relative; height: 24px">
                                        <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                                            runat="server"   Text="添加"></asp:Button>
                                        <asp:Label ID="lblMsg" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                                            runat="server" Width="208px"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <uc1:wucActionForm ID="wucActionForm1" runat="server"></uc1:wucActionForm>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>

    </form>
</body>
</html>
