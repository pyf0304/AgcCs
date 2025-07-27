<%@ Page Language="c#" CodeBehind="wfmViewStyle_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmViewStyle_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucViewStyle" Src="wucViewStyle.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表ViewStyle的查询、修改、删除、添加记录</title>
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
                            Font-Bold="True">ViewStyle表的查询、修改、删除、添加</asp:Label>
                    </td>
                </tr>
            </table>
            <asp:Label ID="lblViewIdq" Style="z-index: 102; left: 10px; position: absolute;
                top: 35px" runat="server" Width="70px" >
  界面ID</asp:Label>
            <asp:TextBox ID="txtViewIdq" Style="z-index: 103; left: 85px; position: absolute;
                top: 35px" runat="server" Width="70px" ></asp:TextBox>
            <asp:Label ID="lblTitleStyleIdq" Style="z-index: 104; left: 10px; position: absolute;
                top: 60px" runat="server" Width="70px" >
  标题类型Id</asp:Label>
            <asp:DropDownList ID="ddlTitleStyleIdq" Style="z-index: 105; left: 85px; position: absolute;
                top: 60px" runat="server" Width="70px" >
            </asp:DropDownList>
            <asp:Label ID="lblDgStyleIdq" Style="z-index: 106; left: 10px; position: absolute;
                top: 85px" runat="server" Width="70px" >
  DgStyleId</asp:Label>
            <asp:DropDownList ID="ddlDgStyleIdq" Style="z-index: 107; left: 85px; position: absolute;
                top: 85px" runat="server" Width="70px" >
            </asp:DropDownList>
            <asp:Button ID="btnQuery" Style="z-index: 108; left: 10px; position: absolute; top: 110px"
                runat="server"   
                Text="查询"></asp:Button>
            <table id="tabRoomDataGrid" style="z-index: 112; left: 8px; width: 552px;
                position: absolute; top: 136px; height: 315px" cellspacing="0" cellpadding="0"
                width="552" border="0" runat="server">
                <tr>
                    <td>
                        <asp:DataGrid ID="dgViewStyle" runat="server" Width="500px" Height="300px" AutoGenerateColumns="False"
                            PageSize="7" AllowPaging="true"  AllowSorting="true">
                            <Columns>
                                <asp:BoundColumn DataField="ViewId" SortExpression="ViewId" HeaderText="界面ID"></asp:BoundColumn>
                                <asp:BoundColumn DataField="TitleStyleTitleStyleName" SortExpression="TitleStyleId"
                                    HeaderText="标题类型Id"></asp:BoundColumn>
                                <asp:BoundColumn DataField="DataGridStyleDgStyleName" SortExpression="DgStyleId"
                                    HeaderText="DgStyleId"></asp:BoundColumn>
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
                        <table id="tabViewStyleJumpPage" style="width: 568px; font-family: Verdana;
                            height: 26px" cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                            <tr>
                                <td>
                                    <font style="background-color: #c0c0c0">共有记录:</font>
                                        <asp:Label ID="lblViewStyleRecCount" runat="server" ForeColor="#000066" Width="46px">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <font style="background-color: #c0c0c0">总页数:</font>
                                        <asp:Label ID="lblViewStyleAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <font style="background-color: #c0c0c0">当前页:
                                            <asp:Label ID="lblViewStyleCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                            <asp:Button ID="btnViewStylePrevPage" runat="server"  
                                                Width="50px" Text="上一页"></asp:Button>
                                            <asp:Button ID="btnViewStyleNextPage" runat="server"  
                                                Width="50px" Text="下一页"></asp:Button>到第
                                            <asp:TextBox ID="txtViewStyleJump2Page" runat="server"  
                                                Width="35px"></asp:TextBox>页
                                            <asp:Button ID="btnViewStyleJumpPage" runat="server"  
                                                Width="35px" Text="确定"></asp:Button>
                                            <asp:CompareValidator ID="ViewStyleCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtViewStyleJump2Page"
                                                ErrorMessage="错误！"></asp:CompareValidator></font></font></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <table id="tabLayout" style="z-index: 109; left: 592px; width: 373px; position: absolute;
                top: 152px; height: 200px" cellspacing="1" cellpadding="1" width="373" border="1">
                <tr>
                    <td>
                        <uc1:wucViewStyle id="wucViewStyle1" runat="server">
                        </uc1:wucViewStyle></td>
                </tr>
            </table>
            <asp:Button ID="btnOKUpd" Style="z-index: 110; left: 592px; position: absolute; top: 104px"
                runat="server"   
                Text="添加"></asp:Button>
            <asp:Label ID="lblMsg" Style="z-index: 111; left: 680px; position: absolute; top: 120px"
                runat="server" Width="70px" ></asp:Label>
        </font>
    </form>
</body>
</html>
