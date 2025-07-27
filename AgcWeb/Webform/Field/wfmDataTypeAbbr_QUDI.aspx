<%@ Page Language="c#" CodeBehind="wfmDataTypeAbbr_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmDataTypeAbbr_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucDataTypeAbbr" Src="wucDataTypeAbbr.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>表DataTypeAbbr的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
            <table id="tabTitle" style="z-index: 102; left: 8px; position: absolute; top: 8px; background-color:#ff6666"
                cellspacing="1" cellpadding="1" width="100%" border="0">
                <tr>
                    <td style="background-color:#ff6666">
                        <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                            Font-Bold="True">DataTypeAbbr表的查询、修改、删除、添加</asp:Label>
                    </td>
                </tr>
            </table>
            <div id="divDataTypeAbbr" style="z-index: 119; left: 8px; width: 720px; position: absolute;
                top: 35px; height: 96px" runat="server">
                <table id="Table1" style="z-index: 119; left: 0px; width: 707px; position: absolute;
                    top: 0px; height: 88px" cellspacing="1" cellpadding="1" width="707" border="1">
                    <tr>
                        <td>
                            <asp:Label ID="lblDataTypeIdq" runat="server" Width="70px" CssClass="text-secondary" 
                               >
  数据类型ID</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtDataTypeIdq" runat="server" Width="70px" ></asp:TextBox></td>
                        <td>
                            <asp:Label ID="lblDataTypeNameq" runat="server" Width="70px" CssClass="text-secondary" 
                               >
  DataTypeName</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtDataTypeNameq" runat="server" Width="70px" ></asp:TextBox></td>
                        <td>
                            <asp:Label ID="lblDataCnNameq" runat="server" Width="112px" CssClass="text-secondary" 
                               >
  数据类型中文名称</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtDataCnNameq" runat="server" Width="70px" ></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblDataTypeAbbrq" runat="server"  CssClass="text-secondary" 
                               >
  数据类型缩写</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtDataTypeAbbrq" runat="server" Width="70px" ></asp:TextBox></td>
                        <td>
                            <asp:Label ID="lblNetSysTypeq" runat="server" Width="96px" CssClass="text-secondary" 
                               >
  NET系统类型</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtNetSysTypeq" runat="server" Width="70px" ></asp:TextBox></td>
                        <td>
                            <asp:Label ID="lblVbNetTypeq" runat="server" Width="70px" CssClass="text-secondary" 
                               >
  VBNET类型</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtVbNetTypeq" runat="server" Width="70px" ></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblCsTypeq" runat="server" Width="70px" 
                               >
  CS类型</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtCsTypeq" runat="server" Width="70px" ></asp:TextBox></td>
                        <td>
                            <asp:Label ID="lblJavaTypeq" runat="server" Width="70px" CssClass="text-secondary" 
                               >
  JAVA类型</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtJavaTypeq" runat="server" Width="70px" ></asp:TextBox></td>
                        <td>
                        </td>
                        <td>
                            <asp:Button ID="btnQuery" runat="server"   
                                Text="查询" OnClick="btnQuery_Click"></asp:Button></td>
                    </tr>
                </table>
            </div>
            <table id="tabDataTypeAbbrDataGrid" style="z-index: 225; left: 8px;
                width: 864px; position: absolute; top: 136px; height: 188px" cellspacing="0"
                cellpadding="0" width="864" border="0" runat="server">
                <tr>
                    <td>
                        <asp:DataGrid ID="dgDataTypeAbbr" runat="server" 
                            Height="108px" Width="832px" AllowSorting="True" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-striped table-bordered table-condensed" OnItemCommand="dgDataTypeAbbr_ItemCommand" OnItemCreated="dgDataTypeAbbr_ItemCreated" OnItemDataBound="dgDataTypeAbbr_ItemDataBound" OnPageIndexChanged="dgDataTypeAbbr_PageIndexChanged" OnSortCommand="dgDataTypeAbbr_SortCommand">
                            <Columns>
                                <asp:BoundColumn Visible="False" DataField="DataTypeId" SortExpression="DataTypeId"
                                    HeaderText="数据类型ID"></asp:BoundColumn>
                                <asp:BoundColumn DataField="DataTypeName" SortExpression="DataTypeName" HeaderText="类型名">
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="DataCnName" SortExpression="DataCnName" HeaderText="类型中文名">
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="DataTypeAbbr" SortExpression="DataTypeAbbr" HeaderText="类型缩写">
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="NetSysType" SortExpression="NetSysType" HeaderText="NET系统类型">
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="VbNetType" SortExpression="VbNetType" HeaderText="VBNET类型">
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="CsType" SortExpression="CsType" HeaderText="CS类型"></asp:BoundColumn>
                                <asp:BoundColumn DataField="JavaType" SortExpression="JavaType" HeaderText="JAVA类型">
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="OraDbType" HeaderText="Ora数据类型" SortExpression="OraDbType">
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="SqlParaType" HeaderText="Sql参数类型" SortExpression="SqlParaType">
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="IsNeedQuote" SortExpression="IsNeedQuote" HeaderText="需要引号">
                                </asp:BoundColumn>
                                <asp:BoundColumn Visible="False" DataField="Memo" SortExpression="Memo" HeaderText="说明">
                                </asp:BoundColumn>
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
                    <td style="width: 605px; background-color:Silver" >
                        <table id="tabDataTypeAbbrJumpPage" style="width: 568px; font-family: Verdana;
                            height: 26px" cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                            <tr>
                                <td>
                                    <font style="background-color: #c0c0c0">共有记录:</font>
                                        <asp:Label ID="lblDataTypeAbbrRecCount" runat="server" ForeColor="#000066" Width="46px">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <font style="background-color: #c0c0c0">总页数:</font>
                                        <asp:Label ID="lblDataTypeAbbrAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <font style="background-color: #c0c0c0">当前页:
                                            <asp:Label ID="lblDataTypeAbbrCurrentPage" runat="server" ForeColor="#000066">0</asp:Label></font>
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                            <asp:Button ID="btnDataTypeAbbrPrevPage" runat="server"  
                                                Width="50px" Text="上一页" OnClick="btnDataTypeAbbrPrevPage_Click"></asp:Button>
                                            <asp:Button ID="btnDataTypeAbbrNextPage" runat="server"  
                                                Width="50px" Text="下一页" OnClick="btnDataTypeAbbrNextPage_Click"></asp:Button>到第
                                            <asp:TextBox ID="txtDataTypeAbbrJump2Page" runat="server"  
                                                Width="35px"></asp:TextBox>页
                                            <asp:Button ID="btnDataTypeAbbrJumpPage" runat="server"  
                                                Width="35px" Text="确定" OnClick="btnDataTypeAbbrJumpPage_Click"></asp:Button>
                                            <asp:CompareValidator ID="DataTypeAbbrCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtDataTypeAbbrJump2Page"
                                                ErrorMessage="错误！"></asp:CompareValidator></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                <td style="height: 10px">
                    <div style="width: 652px; height: 34px; position: relative;">
                        &nbsp;
            <asp:Label ID="lblMsg"
                runat="server"  Width="216px" style="z-index: 102; left: 312px; position: absolute; top: 5px"></asp:Label>

            <asp:Button ID="btnOKUpd" Style="z-index: 101; left: 535px; top: 2px; position: absolute;"
                runat="server"   
                Text="添加" OnClick="btnOKUpd_Click"></asp:Button>

                    </div>
           
                </td></tr>
                <tr>
                <td>
                            <table id="tabLayout" style="z-index: 263; left: 8px; width: 373px;
                top: 416px; height: 200px" cellspacing="1" cellpadding="1" width="373" border="1">
                <tr>
                    <td style="width: 605px">
                        <uc1:wucDataTypeAbbr id="wucDataTypeAbbr1" runat="server">
                        </uc1:wucDataTypeAbbr></td>
                </tr>
            </table>
                 </td>
                </tr>
            </table>
    </form>
</body>
</html>
