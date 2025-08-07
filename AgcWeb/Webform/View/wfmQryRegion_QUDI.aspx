<%@ Register TagPrefix="uc1" TagName="wucQryRegion" Src="wucQryRegion.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmQryRegion_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmQryRegion_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表QueryRegion的查询、修改、删除、添加记录</title>
    
      <script type="text/javascript" src="../../Scripts/jquery-3.4.1.min.js"></script>
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
        
            <table id="tabTitle" style="z-index: 102; left: 8px; position: absolute; top: 8px"
                cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
                <tr>
                    <td bgcolor="#ff6666">
                        <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                            Font-Bold="True">QueryRegion表的查询、修改、删除、添加</asp:Label>
                    </td>
                </tr>
            </table>
            <div id="divQryRegion" style="z-index: 119; left: 8px; width: 256px; position: absolute;
                top: 35px; height: 124px" runat="server">
                <asp:Label ID="lblRegionId_q" Style="z-index: 104; left: 10px; position: absolute;
                    top: 5px" runat="server" Width="70px" >
  区域Id</asp:Label>
                <asp:TextBox ID="txtRegionId_q" Style="z-index: 105; left: 85px; position: absolute;
                    top: 5px" runat="server" Width="70px" ></asp:TextBox>
                <asp:Label ID="lblColNum_q" Style="z-index: 107; left: 10px; position: absolute;
                    top: 33px" runat="server" Width="70px" >
  列数</asp:Label>
                <asp:TextBox ID="txtColNum_q" Style="z-index: 108; left: 85px; position: absolute;
                    top: 33px" runat="server" Width="70px" ></asp:TextBox>
                <asp:CheckBox ID="chkIsUseCtrl_q" Style="z-index: 110; left: 10px; position: absolute;
                    top: 61px" runat="server" Width="100px"  
                    Text="是否使用控件"></asp:CheckBox>
                <asp:Button ID="btnQuery" Style="z-index: 112; left: 10px; position: absolute; top: 89px"
                    runat="server"   
                    Text="查询"></asp:Button>
            </div>
            <table id="tabQryRegionDataGrid" style="z-index: 225; left: 8px;
                width: 552px; position: absolute; top: 169px" cellspacing="0" cellpadding="0"
                width="552" border="0" runat="server">
                <tr>
                    <td>
                        <div style="display: inline; width: 500px; position: relative; height: 24px">
                            <asp:Button ID="btnAddNewRec4Dg" Style="z-index: 106; left: 50px; position: absolute;
                                top: 0px" runat="server"   Text="添加"></asp:Button>
                            <asp:Button ID="btnDelete4Dg" Style="z-index: 104; left: 135px; position: absolute;
                                top: 0px" runat="server"   Text="删除"></asp:Button>
                            <asp:Button ID="btnUpdate4Dg" Style="z-index: 105; left: 220px; position: absolute;
                                top: 0px" runat="server"   Text="修改"></asp:Button>
                            <asp:Button ID="btnExportExcel4Dg" Style="z-index: 107; left: 305px; position: absolute;
                                top: 0px" runat="server"   Text="导出Excel"></asp:Button>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DataGrid ID="dgQryRegion" runat="server" Width="500px" AutoGenerateColumns="False"
                            PageSize="10" AllowPaging="true"  AllowSorting="true">
                            <Columns>
                                <asp:TemplateColumn HeaderText="选择">
                                    <HeaderStyle Width="15px"></HeaderStyle>
                                    <HeaderTemplate>
                                        <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server"
                                            >全选</asp:LinkButton>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:BoundColumn DataField="RegionId" SortExpression="RegionId" HeaderText="区域Id"></asp:BoundColumn>
                                <asp:BoundColumn DataField="ColNum" SortExpression="ColNum" HeaderText="列数"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsUseCtrl" SortExpression="IsUseCtrl" HeaderText="是否使用控件">
                                </asp:BoundColumn>
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
                        <table id="tabQryRegionJumpPage" style="width: 568px; font-family: Verdana;
                            height: 26px" cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                            <tr>
                                <td>
                                    <font style="background-color: #c0c0c0">共有记录:</font>
                                        <asp:Label ID="lblQryRegionRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <font style="background-color: #c0c0c0">总页数:</font>
                                        <asp:Label ID="lblQryRegionAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <font style="background-color: #c0c0c0">当前页:
                                            <asp:Label ID="lblQryRegionCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                            <asp:Button ID="btnQryRegionPrevPage" runat="server"  
                                                Width="50px" Text="上一页"></asp:Button>
                                            <asp:Button ID="btnQryRegionNextPage" runat="server"  
                                                Width="50px" Text="下一页"></asp:Button>
                                            到第
                                            <asp:TextBox ID="txtQryRegionJump2Page" runat="server"  
                                                Width="35px"></asp:TextBox>页
                                            <asp:Button ID="btnQryRegionJumpPage" runat="server"  
                                                Width="35px" Text="确定"></asp:Button>
                                            <asp:CompareValidator ID="QryRegionCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                ErrorMessage="错误！" ControlToValidate="txtQryRegionJump2Page" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <table id="tabEditQryRegionRegion" style="z-index: 227; left: 10px; width: 373px;
                position: absolute; top: 544px; height: 200px" cellspacing="1" cellpadding="1"
                width="373" border="1">
                <tr>
                    <td>
                        <div style="width: 360px; position: relative; height: 24px">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                                runat="server"   
                                Text="添加"></asp:Button>
                            <asp:Label ID="lblMsg" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                                runat="server" Width="208px" ></asp:Label>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <uc1:wucQryRegion id="wucQryRegion1" runat="server">
                        </uc1:wucQryRegion>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div style="width: 360px; position: relative; height: 24px">
                            <asp:Button ID="btnOKUpd2" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                                runat="server"   
                                Text="添加"></asp:Button>
                            <asp:Label ID="lblMsg2" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                                runat="server" Width="208px" ></asp:Label>
                        </div>
                    </td>
                </tr>
            </table>
        </font>
    </form>
</body>
</html>
