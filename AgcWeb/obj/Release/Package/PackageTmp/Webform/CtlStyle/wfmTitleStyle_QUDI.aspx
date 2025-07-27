<%@ Page Language="c#" CodeBehind="wfmTitleStyle_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmTitleStyle_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucTitleStyle" Src="wucTitleStyle.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表TitleStyle的查询、修改、删除、添加记录</title>

    
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
        <div id="tabTitle" class="mt-2" style="width: 100%; float: left">
            <asp:Label ID="lblViewTile" runat="server" CssClass="h5" Font-Bold="True">控件模式->标题模式维护</asp:Label>

        </div>
        <div id="divTitleStyle" class="mt-2 float-left" style="width:100%" runat="server">
            <table id="Table1" cellspacing="1" cellpadding="1" width="560" border="0">
                <tr>
                    <td>
                        <asp:Label ID="lblTitleStyleNameq" runat="server" Width="70px">
  标题类型名</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtTitleStyleNameq" runat="server" Width="117px"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="lblTitleTypeIdq" runat="server" Width="60px">标题类型</asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlTitleTypeIdq" runat="server" Width="162px"></asp:DropDownList></td>
                    <td>
                        <asp:Button ID="btnQuery" runat="server" Text="查询" OnClick="btnQuery_Click" CssClass="btn btn-outline-warning btn-sm"></asp:Button></td>
                    <td>
                        <asp:DropDownList ID="ddlPrjId" runat="server" Width="136px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="btnCopyTitleStyle" runat="server" Width="104px" Text="复制标题模式" OnClick="btnCopyTitleStyle_Click" CssClass="btn btn-outline-warning btn-sm"></asp:Button>
                    </td>
                </tr>
            </table>

        </div>
        <table id="tabTitleStyleDataGrid" class="float-left mt-2" style="z-index: 225; width: 100%;"  width="832" border="0" runat="server">
            <tr>
                <td>
                    <asp:DataGrid ID="dgTitleStyle" runat="server" Width="824px" Height="106px" AutoGenerateColumns="False"
                        PageSize="5" AllowPaging="True" AllowSorting="True" BorderColor="#E7E7FF" BorderStyle="None"
                        BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal" OnItemCommand="dgTitleStyle_ItemCommand"
                        OnItemCreated="dgTitleStyle_ItemCreated" OnPageIndexChanged="dgTitleStyle_PageIndexChanged"
                        OnSortCommand="dgTitleStyle_SortCommand">
                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                        <Columns>
                            <asp:BoundColumn Visible="False" DataField="TitleStyleId" SortExpression="TitleStyleId"
                                HeaderText="标题类型Id"></asp:BoundColumn>
                            <asp:BoundColumn DataField="TitleStyleName" SortExpression="TitleStyleName" HeaderText="标题类型名"></asp:BoundColumn>
                            <asp:BoundColumn DataField="TitleTypeName" SortExpression="TitleTypeName" HeaderText="标题类型"></asp:BoundColumn>
                            <asp:BoundColumn DataField="ImgFile" SortExpression="ImgFile" HeaderText="图像文件"></asp:BoundColumn>
                            <asp:BoundColumn DataField="TabHeight" SortExpression="TabHeight" HeaderText="高度"></asp:BoundColumn>
                            <asp:BoundColumn DataField="TabWidth" SortExpression="TabWidth" HeaderText="宽度"></asp:BoundColumn>
                            <asp:BoundColumn DataField="BackColor" SortExpression="BackColor" HeaderText="背景色"></asp:BoundColumn>
                            <asp:BoundColumn DataField="ForeColor" SortExpression="ForeColor" HeaderText="前景色"></asp:BoundColumn>
                            <asp:BoundColumn DataField="FontSize" SortExpression="FontSize" HeaderText="字号"></asp:BoundColumn>
                            <asp:BoundColumn DataField="FontName" SortExpression="FontName" HeaderText="字体"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="PrjName" SortExpression="PrjName" HeaderText="工程ID"></asp:BoundColumn>
                            <asp:BoundColumn DataField="IsDefault" SortExpression="IsDefault" HeaderText="默认"></asp:BoundColumn>
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
                    <table id="tabTitleStyleJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                        cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                        <tr>
                            <td>
                                <font style="background-color: #c0c0c0">共有记录:</font>
                                <asp:Label ID="lblTitleStyleRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                <div style="display: inline; width: 16px; height: 13px">
                                </div>
                                <font style="background-color: #c0c0c0">总页数:</font>
                                <asp:Label ID="lblTitleStyleAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                <div style="display: inline; width: 16px; height: 13px">
                                </div>
                                <font style="background-color: #c0c0c0">当前页:
                                        <asp:Label ID="lblTitleStyleCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <asp:Button ID="btnTitleStylePrevPage" runat="server" Width="50px"
                                        Text="上一页" OnClick="btnTitleStylePrevPage_Click"></asp:Button>
                                    <asp:Button ID="btnTitleStyleNextPage" runat="server" Width="50px"
                                        Text="下一页" OnClick="btnTitleStyleNextPage_Click"></asp:Button>
                                    到第
                                        <asp:TextBox ID="txtTitleStyleJump2Page" runat="server" Width="35px"></asp:TextBox>页
                                        <asp:Button ID="btnTitleStyleJumpPage" runat="server" Width="35px"
                                            Text="确定" OnClick="btnTitleStyleJumpPage_Click"></asp:Button>
                                    <asp:CompareValidator ID="TitleStyleCompareValidator1" runat="server" ForeColor="DarkOrange"
                                        ErrorMessage="错误！" ControlToValidate="txtTitleStyleJump2Page" Type="Integer"
                                        Operator="DataTypeCheck"></asp:CompareValidator></font>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <div id="tabLayout" class="float-left mt-2">
            <table>
                <tr>
                    <td valign="top" colspan="1" rowspan="1">
                        <asp:Button ID="btnOKUpd" runat="server" Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button></td>
                    <td valign="top" style="width: 291px">
                        <asp:Label ID="lblMsg" runat="server" Width="70px"></asp:Label></td>
                </tr>
                <tr>
                    <td valign="top" colspan="2" rowspan="1">
                        <uc1:wucTitleStyle ID="wucTitleStyle1" runat="server"></uc1:wucTitleStyle>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
