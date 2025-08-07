<%@ Page Language="c#" CodeBehind="wfmActionFormPropertys_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.wfmActionFormPropertys_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucActionFormPropertys" Src="wucActionFormPropertys.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表ActionFormPropertys的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <table id="tabTitle" style="z-index: 101; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                        Font-Bold="True">ActionForm属性维护</asp:Label>
                    <asp:Label ID="Label1" runat="server"
                        Width="112px">ActionForm名称:</asp:Label>
                    <asp:Label ID="lblActionFormName" runat="server"
                        Width="112px">ActionForm名称:</asp:Label>
                </td>
            </tr>
        </table>
        <div id="divActionFormPropertys" style="z-index: 102; left: 8px; width: 912px; position: absolute; top: 35px; height: 32px"
            runat="server">
            <asp:Label ID="lblPropertyName_q" Style="z-index: 104; left: 24px; position: absolute; top: 8px"
                runat="server" Width="70px">
  属性名称</asp:Label>
            <asp:TextBox ID="txtPropertyName_q" Style="z-index: 105; left: 104px; position: absolute; top: 3px"
                runat="server" Width="128px" ></asp:TextBox>
            <asp:Label ID="lblJavaTypeId_q" Style="z-index: 107; left: 288px; position: absolute; top: 8px"
                runat="server" Width="70px">
  Java类型Id</asp:Label>
            <asp:DropDownList ID="ddlJavaTypeId_q" Style="z-index: 108; left: 392px; position: absolute; top: 5px"
                runat="server" Width="160px" Height="32px">
            </asp:DropDownList>
            <asp:Button ID="btnQuery" Style="z-index: 110; left: 616px; position: absolute; top: 4px"
                runat="server"  
                Text="查询"></asp:Button>
        </div>
        <table id="Table1" style="z-index: 105; left: 8px; position: absolute; top: 72px"
            cellspacing="0" cellpadding="0" width="300" border="0">
            <tr>
                <td>
                    <table id="tabActionFormPropertysDataGrid" style="width: 896px"
                        cellspacing="0" cellpadding="0" width="896" border="0" runat="server">
                        <tr>
                            <td>
                                <div style="display: inline; width: 888px; position: relative; height: 24px">
                                    <asp:Button ID="btnAddNewRec4Dg1" Style="z-index: 102; left: 200px; position: absolute; top: 0px"
                                        runat="server"   Text="添加"></asp:Button>
                                    <asp:Button ID="btnDelete4Dg" Style="z-index: 100; left: 288px; position: absolute; top: 0px"
                                        runat="server"   Text="删除"></asp:Button>
                                    <asp:Button ID="btnUpdate4Dg" Style="z-index: 101; left: 368px; position: absolute; top: 0px"
                                        runat="server"   Text="修改"></asp:Button>
                                    <asp:Button ID="btnExportExcel4Dg" Style="z-index: 103; left: 696px; position: absolute; top: 0px"
                                        runat="server"   Text="导出Excel"></asp:Button>
                                    <asp:Button ID="btnCopyRelaFldProp" Style="z-index: 104; left: 456px; position: absolute; top: 0px"
                                        runat="server"  Width="120px" Text="复制相关字段属性"></asp:Button>
                                    <asp:Button ID="Button2" Style="z-index: 105; left: 584px; position: absolute; top: 0px"
                                        runat="server"  Width="112px" Text="同步相关字段属性"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgActionFormPropertys" runat="server"
                                    Width="896px" AllowSorting="True" AllowPaging="True" AutoGenerateColumns="False"
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
                                        <asp:BoundColumn Visible="False" DataField="mId" SortExpression="mId" HeaderText="mId"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="ActionFormId" SortExpression="ActionFormId"
                                            HeaderText="ActionFormId"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PropertyName" SortExpression="PropertyName" HeaderText="属性名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="JavaTypeName" SortExpression="JavaTypeName" HeaderText="Java类型"></asp:BoundColumn>
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
                                <table id="tabActionFormPropertysJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                                    cellspacing="0" cellpadding="0" width="568"
                                    border="1" runat="server">
                                    <tr>
                                        <td>
                                            <font style="background-color: #c0c0c0">共有记录:</font>
                                                <asp:Label ID="lblActionFormPropertysRecCount" runat="server" ForeColor="#000066"
                                                    Width="46px">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">总页数:</font>
                                                <asp:Label ID="lblActionFormPropertysAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">当前页:
                                                        <asp:Label ID="lblActionFormPropertysCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <asp:Button ID="btnActionFormPropertysPrevPage" runat="server"
                                                        Width="50px" Text="上一页"></asp:Button>
                                                    <asp:Button ID="btnActionFormPropertysNextPage" runat="server"
                                                        Width="50px" Text="下一页"></asp:Button>到第
                                                        <asp:TextBox ID="txtActionFormPropertysJump2Page" runat="server"
                                                            Width="35px"></asp:TextBox>页
                                                        <asp:Button ID="btnActionFormPropertysJumpPage" runat="server"
                                                            Width="35px" Text="确定"></asp:Button>
                                                    <asp:CompareValidator ID="ActionFormPropertysCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                        Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtActionFormPropertysJump2Page"
                                                        ErrorMessage="错误！"></asp:CompareValidator></font></font></td>
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
                    <table id="tabEditActionFormPropertysRegion" style="width: 373px; height: 200px"
                        cellspacing="1" cellpadding="1" width="373" border="1">
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
                                <uc1:wucActionFormPropertys ID="wucActionFormPropertys1" runat="server"></uc1:wucActionFormPropertys>
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
