<%@ Register TagPrefix="uc1" TagName="wucDetailRegionFlds" Src="wucDetailRegionFlds.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmDetailRegionFlds_QUDI.aspx.cs" AutoEventWireup="True"
    ValidateRequest="false" Inherits="AGC.Webform.wfmDetailRegionFlds_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表EditRegionFlds的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <div id="divEditRegionFlds" style="z-index: 100; left: 8px; width: 640px; position: absolute;
            top: 35px; height: 34px" runat="server">
            <asp:Label ID="lblRegionIdq" Style="z-index: 101; left: 8px; position: absolute;
                top: 8px" runat="server" CssClass="text-secondary">
  区域</asp:Label>
            <asp:Button ID="btnQuery" Style="z-index: 102; left: 552px; position: absolute; top: 0px"
                runat="server"  Text="查询" Enabled="False" OnClick="btnQuery_Click"></asp:Button>
            <asp:Label ID="lblRegionName" Style="z-index: 103; left: 48px; position: absolute;
                top: 8px" runat="server" CssClass="ValueLabelH1"></asp:Label>
        </div>
        <asp:Label ID="lblMsg1" Style="z-index: 104; left: 184px; position: absolute; top: 16px"
            runat="server"  Width="248px" ForeColor="Red"></asp:Label>
        <table id="Table1" style="z-index: 102; left: 8px; position: absolute; top: 72px"
            cellspacing="0" cellpadding="0" width="300" border="0">
            <tr>
                <td>
                    <table id="tabEditRegionFldsDataGrid" style="font-size: x-small" cellspacing="0"
                        cellpadding="0" width="552" border="0" runat="server">
                        <tr>
                            <td>
                                <div style="width: 817px; position: relative; height: 32px">
                                    <asp:Button ID="btnDelete4Dg" Style="z-index: 100; left: 248px; position: absolute;
                                        top: 8px" runat="server"  Width="70px" Text="删除" OnClick="btnDelete4Dg_Click"></asp:Button>
                                    <asp:Button ID="btnUpdate4Dg" Style="z-index: 101; left: 320px; position: absolute;
                                        top: 8px" runat="server"  Width="70px" Text="修改" OnClick="btnUpdate4Dg_Click"></asp:Button>
                                    <asp:Button ID="btnExportExcel4Dg" Style="z-index: 103; left: 744px; position: absolute;
                                        top: 8px" runat="server"  Width="70px" Text="导出Excel" OnClick="btnExportExcel4Dg_Click"></asp:Button>
                                    <asp:Button ID="btnCopyFldFromRelaTab" Style="z-index: 104; left: 392px; position: absolute;
                                        top: 8px" runat="server" Width="160px" Text="从区域相关表中复制字段" OnClick="btnCopyFldFromRelaTab_Click"></asp:Button>
                                    <img style="z-index: 105; left: 0px; width: 776px; position: absolute; top: 0px;
                                        height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                    <asp:Label ID="Label3" Style="z-index: 106; left: 0px; position: absolute; top: 8px"
                                        runat="server"  Width="184px" CssClass="h6">详细信息区域字段列表</asp:Label>
                                    <asp:Button ID="btnUpMove" Style="z-index: 107; left: 624px; position: absolute;
                                        top: 8px" runat="server"  Text="上移"  OnClick="btnUpMove_Click"></asp:Button>
                                    <asp:Button ID="btnDownMove" Style="z-index: 109; left: 664px; position: absolute;
                                        top: 8px" runat="server"  Text="下移"  OnClick="btnDownMove_Click"></asp:Button>
                                    <asp:Button ID="btnReOrder" Style="z-index: 110; left: 704px; position: absolute;
                                        top: 8px" runat="server"  Text="重序"  OnClick="btnReOrder_Click"></asp:Button>
                                    <asp:Button ID="btnPreView" Style="z-index: 111; left: 560px; position: absolute;
                                        top: 8px" runat="server"  Text="预览"  OnClick="btnPreView_Click"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgEditRegionFlds" runat="server" Width="792px" AllowSorting="True"
                                    AllowPaging="True" AutoGenerateColumns="False" BorderColor="#E7E7FF" BorderStyle="None"
                                    BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal" OnItemCommand="dgEditRegionFlds_ItemCommand" OnItemCreated="dgEditRegionFlds_ItemCreated" OnPageIndexChanged="dgEditRegionFlds_PageIndexChanged" OnSortCommand="dgEditRegionFlds_SortCommand">
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
                                        <asp:BoundColumn Visible="False" DataField="mId" SortExpression="mId" HeaderText="mId">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="RegionId" SortExpression="RegionId" HeaderText="区域Id">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="TabFldId" SortExpression="TabFldId" HeaderText="表字段ID">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="SeqNum" SortExpression="SeqNum" HeaderText="序号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="TabName" SortExpression="TabName" HeaderText="表名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Caption" SortExpression="Caption" HeaderText="标题"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="InOutTypeName" SortExpression="InOutTypeName" HeaderText="OUT/IN">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="CtlTypeName" SortExpression="CtlTypeName" HeaderText="控件类型">
                                        </asp:BoundColumn>
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
                                <table id="tabEditRegionFldsJumpPage" style="width: 568px; font-family: Verdana;
                                    height: 26px" cellspacing="0" cellpadding="0" width="568" border="1" runat="server" class="Label_Defa">
                                    <tr>
                                        <td>
                                            <font style="background-color: #c0c0c0">共有记录:</font>
                                                <asp:Label ID="lblEditRegionFldsRecCount" runat="server" ForeColor="#000066" Width="46px">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">总页数:</font>
                                                <asp:Label ID="lblEditRegionFldsAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">当前页:
                                                    <asp:Label ID="lblEditRegionFldsCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <asp:Button ID="btnEditRegionFldsPrevPage" runat="server"  Width="50px"
                                                        Text="上一页" OnClick="btnEditRegionFldsPrevPage_Click"></asp:Button>
                                                    <asp:Button ID="btnEditRegionFldsNextPage" runat="server"  Width="50px"
                                                        Text="下一页" OnClick="btnEditRegionFldsNextPage_Click"></asp:Button>到第
                                                    <asp:TextBox ID="txtEditRegionFldsJump2Page" runat="server" Width="35px"></asp:TextBox>页
                                                    <asp:Button ID="btnEditRegionFldsJumpPage" runat="server"  Width="35px"
                                                        Text="确定" OnClick="btnEditRegionFldsJumpPage_Click"></asp:Button>
                                                    <asp:CompareValidator ID="EditRegionFldsCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                        Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtEditRegionFldsJump2Page"
                                                        ErrorMessage="错误！"></asp:CompareValidator></font></font></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                        </tr>
                    </table>
                    <table id="tabEditEditRegionFldsRegion" style="width: 373px" cellspacing="1" cellpadding="1"
                        width="373" border="1" runat="server">
                        <tr>
                            <td>
                                <div style="width: 777px; position: relative; height: 24px">
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 696px; position: absolute; top: 8px"
                                        runat="server"   Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                    <asp:Label ID="lblMsg" Style="z-index: 105; left: 480px; position: absolute; top: 16px"
                                        runat="server" Width="208px"></asp:Label>
                                    <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                        height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                    <asp:Label ID="Label1" Style="z-index: 109; left: 0px; position: absolute; top: 8px"
                                        runat="server"  Width="128px" CssClass="h6">编辑字段属性</asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucDetailRegionFlds ID="wucDetailRegionFlds1" runat="server"></uc1:wucDetailRegionFlds>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
           
            <tr>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabDetailRegionPreview" cellspacing="1" cellpadding="1" width="300" border="1"
                        runat="server">
                        <tr>
                            <td>
                                <div style="width: 808px; position: relative; height: 24px">
                                    <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                        height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                    <asp:Label ID="Label5" Style="z-index: 109; left: 8px; position: absolute; top: 8px"
                                        runat="server" CssClass="h6">详细信息区域预览</asp:Label>
                                </div>
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div id="divQryRegionPreview" style="width: 720px; position: relative; height: 100px"
                                    runat="server">
                                    <asp:PlaceHolder ID="phDetailRegion" runat="server"></asp:PlaceHolder>
                                </div>
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
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabCode" style="width: 816px; height: 551px" cellspacing="1" cellpadding="1"
                        width="816" border="1" runat="server">
                        <tr>
                            <td colspan="2">
                                <div style="width: 800px; position: relative; height: 32px">
                                    <asp:Label ID="lblCaption4GenCode" Style="z-index: 101; left: 8px; position: absolute;
                                        top: 8px" runat="server" Font-Names="宋体"  Font-Size="Smaller" Width="120px">生成的逻辑层代码：</asp:Label>
                                    <asp:LinkButton ID="lbDispTabList" Style="z-index: 102; left: 664px; position: absolute;
                                        top: 8px" runat="server">显示详细区域列表</asp:LinkButton>
                                    <asp:Label ID="Label6" Style="z-index: 103; left: 152px; position: absolute; top: 8px"
                                        runat="server"  >生成文件名：</asp:Label>
                                    <asp:TextBox ID="txtFileName4GenCode" Style="z-index: 104; left: 248px; position: absolute;
                                        top: 8px" runat="server"  Width="336px"></asp:TextBox>
                                    <asp:LinkButton ID="lbDownLoadFile" Style="z-index: 111; left: 600px; position: absolute;
                                        top: 8px" runat="server"  Width="56px">下载文件</asp:LinkButton>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                  <asp:Literal ID="litCode" runat="server"></asp:Literal>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <asp:Label ID="lblViewTile" runat="server" Style="z-index: 103; left: 8px; position: absolute;
            top: 8px" CssClass="h5">详细区域字段维护</asp:Label>
        <asp:LinkButton ID="btnGoBack" Style="z-index: 111; left: 776px; position: absolute;
            top: 16px" runat="server" Width="32px" Text="返回" OnClick="btnGoBack_Click"></asp:LinkButton>
    </form>
</body>
</html>
