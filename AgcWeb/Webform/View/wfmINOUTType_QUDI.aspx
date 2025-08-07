<%@ Register TagPrefix="uc1" TagName="wucINOUTType" Src="wucINOUTType.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmINOUTType_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmINOUTType_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>输入输出类型维护</title>
    
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
        
            <table id="tabTitle" style="z-index: 101; left: 8px; position: absolute; top: 8px"
                cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
                <tr>
                    <td bgcolor="#ff6666">
                        <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                            Font-Bold="True">输入输出类型维护</asp:Label>
                    </td>
                </tr>
            </table>
            <table id="Table1" style="z-index: 105; left: 2px; position: absolute; top: 37px"
                cellspacing="0" cellpadding="0" width="300" border="0">
                <tr>
                    <td>
                        <div id="divINOUTType" style="width: 709px; height: 31px" runat="server">
                            <asp:Label ID="lblInOutTypeIdq" Style="z-index: 104; left: 10px; position: absolute;
                                top: 5px" runat="server" Width="96px" CssClass="text-secondary">
  输入输出类型ID</asp:Label>
                            <asp:TextBox ID="txtInOutTypeIdq" Style="z-index: 105; left: 112px; position: absolute;
                                top: 0px" runat="server" Width="70px" ></asp:TextBox>
                            <asp:Label ID="lblInOutTypeNameq" Style="z-index: 107; left: 210px; position: absolute;
                                top: 0px" runat="server" Width="112px" CssClass="text-secondary">
  输入输出类型名称</asp:Label>
                            <asp:TextBox ID="txtInOutTypeNameq" Style="z-index: 108; left: 325px; position: absolute;
                                top: 0px" runat="server" Width="264px" ></asp:TextBox>
                            <asp:Button ID="btnQuery" Style="z-index: 110; left: 610px; position: absolute; top: 0px"
                                runat="server"  Text="查询" OnClick="btnQuery_Click"></asp:Button>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table id="tabINOUTTypeDataGrid" style="width: 552px" cellspacing="0" cellpadding="0"
                            width="552" border="0" runat="server">
                            <tr>
                                <td>
                                    <div style="width: 640px; position: relative; left: 0px; top: 0px;">
                                        <asp:Button ID="btnAddNewRec4Dg1" Style="z-index: 106; left: 277px; position: absolute;
                                            top: 0px" runat="server"   Text="添加" CssClass="table table-striped table-bordered table-condensed" OnClick="btnAddNewRec4Dg_Click">
                                        </asp:Button>
                                        <asp:Button ID="btnDelete4Dg" Style="z-index: 104; left: 362px; position: absolute;
                                            top: 0px" runat="server"   Text="删除" CssClass="table table-striped table-bordered table-condensed" OnClick="btnDelete4Dg_Click">
                                        </asp:Button>
                                        <asp:Button ID="btnUpdate4Dg" Style="z-index: 105; left: 447px; position: absolute;
                                            top: 0px" runat="server"   Text="修改" CssClass="table table-striped table-bordered table-condensed" OnClick="btnUpdate4Dg_Click">
                                        </asp:Button>
                                        <asp:Button ID="btnExportExcel4Dg" Style="z-index: 107; left: 532px; position: absolute;
                                            top: 0px" runat="server"   Text="导出Excel" CssClass="table table-striped table-bordered table-condensed" OnClick="btnExportExcel4Dg_Click">
                                        </asp:Button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DataGrid ID="dgINOUTType" runat="server" Width="695px" AllowSorting="True" AllowPaging="True"
                                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-striped table-bordered table-condensed" OnItemCommand="dgINOUTType_ItemCommand" OnItemCreated="dgINOUTType_ItemCreated" OnPageIndexChanged="dgINOUTType_PageIndexChanged" OnSortCommand="dgINOUTType_SortCommand">
                                        <Columns>
                                            <asp:TemplateColumn HeaderText="选择">
                                                <HeaderStyle Width="30px"></HeaderStyle>
                                                <HeaderTemplate>
                                                    <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:BoundColumn DataField="InOutTypeId" SortExpression="InOutTypeId" HeaderText="输入输出类型ID">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="InOutTypeName" SortExpression="InOutTypeName" HeaderText="输入输出类型名称">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundColumn>
                                            <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                            <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                        </Columns>
                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center"></PagerStyle>
                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <EditItemStyle BackColor="#999999" />
                                        <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                                        <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    </asp:DataGrid></td>
                            </tr>
                            <tr>
                                <td style="width: 605px" bgcolor="silver">
                                    <table id="tabINOUTTypeJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                                        cellspacing="0" cellpadding="0" width="568" border="1" runat="server" class="NameLabel">
                                        <tr>
                                            <td>
                                                <font style="background-color: #c0c0c0">共有记录:</font>
                                                    <asp:Label ID="lblINOUTTypeRecCount" runat="server" ForeColor="#000066" Width="46px">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <font style="background-color: #c0c0c0">总页数:</font>
                                                    <asp:Label ID="lblINOUTTypeAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <font style="background-color: #c0c0c0">当前页:
                                                        <asp:Label ID="lblINOUTTypeCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                        <div style="display: inline; width: 16px; height: 13px">
                                                        </div>
                                                        <asp:Button ID="btnINOUTTypePrevPage" runat="server"  Width="50px" Text="上一页" OnClick="btnINOUTTypePrevPage_Click">
                                                        </asp:Button>
                                                        <asp:Button ID="btnINOUTTypeNextPage" runat="server"  Width="50px" Text="下一页" OnClick="btnINOUTTypeNextPage_Click">
                                                        </asp:Button>到第
                                                        <asp:TextBox ID="txtINOUTTypeJump2Page" runat="server"  Width="35px"></asp:TextBox>页
                                                        <asp:Button ID="btnINOUTTypeJumpPage" runat="server"  Width="35px" Text="确定" OnClick="btnINOUTTypeJumpPage_Click">
                                                        </asp:Button>
                                                        <asp:CompareValidator ID="INOUTTypeCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                            Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtINOUTTypeJump2Page"
                                                            ErrorMessage="错误！"></asp:CompareValidator></font></font></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table id="tabEditINOUTTypeRegion" style="width: 373px" cellspacing="1"
                            cellpadding="1" width="373" border="1">
                            <tr>
                                <td>
                                    <div style="width: 360px; position: relative; height: 24px">
                                        <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                                            runat="server"   Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                        <asp:Label ID="lblMsg" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                                            runat="server" Width="208px" CssClass="text-warning"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <uc1:wucINOUTType ID="wucINOUTType1" runat="server"></uc1:wucINOUTType>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
            </table>
        </font>
    </form>
</body>
</html>
