<%@ Page Language="c#" CodeBehind="wfmDGRegionFlds_QUDI.aspx.cs" ValidateRequest="false"
    AutoEventWireup="True" Inherits="AGC.Webform.wfmDGRegionFlds_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucDGRegionFlds" Src="wucDGRegionFlds.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表DGRegionFlds的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
    <div id="divDGRegionFlds" style="z-index: 100; left: 8px; width: 801px; position: absolute;
        top: 35px; height: 26px" runat="server">
        <asp:Label ID="lblRegionIdq" Style="z-index: 101; left: 10px; position: absolute;
            top: 4px" runat="server" CssClass="text-secondary">  区域:</asp:Label>
        <asp:Label ID="lblRegionName" Style="z-index: 102; left: 56px; position: absolute;
            top: 4px" runat="server" CssClass="ValueLabelH1" Width="168px">区域</asp:Label>
        <asp:Button ID="btnQuery" Style="z-index: 103; left: 720px; position: absolute; top: 0px"
            runat="server"   Enabled="False" Visible="False" Text="查询">
        </asp:Button>
    </div>
    <asp:Label ID="lblMsg1" Style="z-index: 104; left: 192px; position: absolute; top: 8px"
        runat="server"  Width="248px" ForeColor="Red"></asp:Label>
    <table id="Table1" style="z-index: 103; left: 8px; position: absolute; top: 64px"
        cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
            <td>
                <table id="tabDGRegionFldsDataGrid" style="width: 100%" cellspacing="0" cellpadding="0"
                    width="552" border="0" runat="server">
                    <tr>
                        <td>
                            <div style="width: 831px; position: relative; height: 40px">
                                <asp:Button ID="btnDelete4Dg" Style="z-index: 100; left: 248px; position: absolute;
                                    top: 8px" runat="server"  Width="70px" Text="删除" OnClick="btnDelete4Dg_Click">
                                </asp:Button>
                                <asp:Button ID="btnUpdate4Dg" Style="z-index: 101; left: 320px; position: absolute;
                                    top: 8px" runat="server"  Width="70px" Text="修改" OnClick="btnUpdate4Dg_Click">
                                </asp:Button>
                                <asp:Button ID="btnExportExcel4Dg" Style="z-index: 103; left: 760px; position: absolute;
                                    top: 8px" runat="server"  Width="70px" Text="导出Excel" OnClick="btnExportExcel4Dg_Click">
                                </asp:Button>
                                <asp:Button ID="btnCopyFldFromRelaTab" Style="z-index: 104; left: 392px; position: absolute;
                                    top: 8px" runat="server" Width="160px" Text="从区域相关表中复制字段" OnClick="btnCopyFldFromRelaTab_Click">
                                </asp:Button>
                                <img style="z-index: 106; left: 0px; width: 776px; position: absolute; top: 0px;
                                    height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                <asp:Label ID="Label3" Style="z-index: 107; left: 0px; position: absolute; top: 8px"
                                    runat="server" CssClass="h6"  Width="184px">列表区域字段列表</asp:Label>
                                <asp:Button ID="btnPreView" Style="z-index: 108; left: 560px; position: absolute;
                                    top: 8px" runat="server"   Text="预览" OnClick="btnPreView_Click">
                                </asp:Button>
                                <asp:Button ID="btnUpMove" Style="z-index: 109; left: 616px; position: absolute;
                                    top: 8px; right: 167px;" runat="server"   Text="上移"
                                    OnClick="btnUpMove_Click"></asp:Button>
                                <asp:Button ID="btnDownMove" Style="z-index: 110; left: 664px; position: absolute;
                                    top: 8px; right: 119px;" runat="server"   Text="下移"
                                    OnClick="btnDownMove_Click"></asp:Button>
                                <asp:Button ID="btnReOrder" Style="z-index: 111; left: 712px; position: absolute;
                                    top: 8px" runat="server"   Text="重序" OnClick="btnReOrder_Click">
                                </asp:Button>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DataGrid ID="dgDGRegionFlds" runat="server" Width="100%" BorderColor="#E7E7FF"
                                BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal"
                                AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True" OnItemCommand="dgDGRegionFlds_ItemCommand"
                                OnItemCreated="dgDGRegionFlds_ItemCreated" OnPageIndexChanged="dgDGRegionFlds_PageIndexChanged"
                                OnSortCommand="dgDGRegionFlds_SortCommand" PageSize="100">
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
                                    <asp:BoundColumn DataField="ColIndex" SortExpression="ColIndex" HeaderText="序号">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="TabName" SortExpression="TabName" HeaderText="表名" Visible="False">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="ColCaption" SortExpression="ColCaption" HeaderText="列标题">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="CtlTypeName" SortExpression="CtlTypeName" HeaderText="控件类型">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="IsNeedSort" SortExpression="IsNeedSort" HeaderText="排序?">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="IsTransToChkBox" SortExpression="IsTransToChkBox" HeaderText="换成CheckBox?">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="IsVisible" SortExpression="IsVisible" HeaderText="显示?">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="IsFuncFld" SortExpression="IsFuncFld" HeaderText="功能字段?">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="DgFuncTypeName" SortExpression="DgFuncTypeName" HeaderText="Dg功能类型">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="InUse" SortExpression="InUse" HeaderText="使用?">
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
                            </asp:DataGrid>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 605px" bgcolor="silver">
                            <table id="tabDGRegionFldsJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                                cellspacing="0" cellpadding="0" width="568" border="1" runat="server" class="NameLabel">
                                <tr>
                                    <td>
                                        <font style="background-color: #c0c0c0">共有记录:</font>
                                            <asp:Label ID="lblDGRegionFldsRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                            <font style="background-color: #c0c0c0">总页数:</font>
                                            <asp:Label ID="lblDGRegionFldsAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                            <font style="background-color: #c0c0c0">当前页:
                                                <asp:Label ID="lblDGRegionFldsCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <asp:Button ID="btnDGRegionFldsPrevPage" runat="server" Width="50px" Text="上一页" OnClick="btnDGRegionFldsPrevPage_Click">
                                                </asp:Button><asp:Button ID="btnDGRegionFldsNextPage" runat="server" Width="50px"
                                                    Text="下一页" OnClick="btnDGRegionFldsNextPage_Click"></asp:Button>到第
                                                <asp:TextBox ID="txtDGRegionFldsJump2Page" runat="server" Width="35px"></asp:TextBox>页
                                                <asp:Button ID="btnDGRegionFldsJumpPage" runat="server" Width="35px" Text="确定" OnClick="btnDGRegionFldsJumpPage_Click">
                                                </asp:Button><asp:CompareValidator ID="DGRegionFldsCompareValidator1" runat="server"
                                                    ForeColor="DarkOrange" ErrorMessage="错误！" ControlToValidate="txtDGRegionFldsJump2Page"
                                                    Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table id="tabEditDGRegionFldsRegion" style="width: 373px; height: 200px" cellspacing="1"
                    cellpadding="1" width="373" border="1" runat="server">
                    <tr>
                        <td>
                            <div style="width: 784px; position: relative; height: 28px">
                                <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 672px; position: absolute; top: 0px"
                                    runat="server"   Text="添加" OnClick="btnOKUpd_Click">
                                </asp:Button>
                                <asp:Label ID="lblMsg" Style="z-index: 105; left: 456px; position: absolute; top: 8px"
                                    runat="server" Width="208px" ForeColor="Red"></asp:Label>
                                <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                    height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                <asp:Label ID="Label1" Style="z-index: 109; left: 0px; position: absolute; top: 8px"
                                    runat="server" CssClass="h6"  Width="128px">编辑字段属性</asp:Label>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <uc1:wucDGRegionFlds ID="wucDGRegionFlds1" runat="server"></uc1:wucDGRegionFlds>
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
                <table id="tabTabFldList" cellspacing="0" cellpadding="0" width="300" border="0"
                    runat="server">
                    <tr>
                        <td>
                            <div style="width: 784px; position: relative; height: 232px">
                                <asp:Button ID="btnOKAddRec" Style="z-index: 101; left: 560px; position: absolute;
                                    top: 24px" runat="server"  Width="97px" Text="添加所选字段" OnClick="btnOKAddRec_Click">
                                </asp:Button>
                                <asp:Label ID="lblMsg2" Style="z-index: 102; left: 424px; position: absolute; top: 32px"
                                    runat="server"  Width="128px" ForeColor="Red"></asp:Label>
                                <asp:LinkButton ID="LinkButton1" Style="z-index: 103; left: 672px; position: absolute;
                                    top: 24px" runat="server" OnClick="LinkButton1_Click">显示区域字段列表</asp:LinkButton>
                                <asp:Label ID="Label15" Style="z-index: 104; left: 8px; position: absolute; top: 216px"
                                    runat="server" Font-Names="宋体"  Font-Size="Smaller">记录数：</asp:Label>
                                <asp:TextBox ID="txtRecCountForPrjTabFld" Style="z-index: 105; left: 64px; position: absolute;
                                    top: 208px" runat="server" Font-Names="宋体"  Width="96px" Font-Size="Smaller"
                                    ReadOnly="True"></asp:TextBox>
                                <asp:DataGrid ID="" Style="z-index: 106; left: 0px; position: absolute;
                                    top: 48px" runat="server" Font-Names="宋体" Height="154px" Width="768px" Font-Size="Smaller"
                                    BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White"
                                    CellPadding="3" GridLines="Horizontal" AutoGenerateColumns="False">
                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                    <Columns>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn Visible="False" DataField="MId" HeaderText="编号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="TabName" HeaderText="表名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FldName" HeaderText="字段名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Caption" SortExpression="Caption" HeaderText="字段标题">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="DataTypeName" SortExpression="DataTypeName" HeaderText="类型">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="FldLength" SortExpression="FldLength" HeaderText="长度">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsTabNullable" SortExpression="IsTabNullable" HeaderText="可空">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="FieldTypeName" HeaderText="字段类型"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrimaryTypeName" HeaderText="主关键字类型"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="Memo" HeaderText="说明"></asp:BoundColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                    </PagerStyle>
                                </asp:DataGrid>
                                <asp:Label ID="Label2" Style="z-index: 107; left: 0px; position: absolute; top: 8px"
                                    runat="server" CssClass="h6"  Width="128px">添加新字段</asp:Label>
                                <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                    height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                <asp:RadioButtonList ID="rblSQLDSType" Style="z-index: 109; left: 24px; position: absolute;
                                    top: 24px" runat="server" Width="352px" RepeatDirection="Horizontal" AutoPostBack="True"
                                    OnSelectedIndexChanged="rblSQLDSType_SelectedIndexChanged">
                                    <asp:ListItem Value="01">从输入数据源表添加字段</asp:ListItem>
                                    <asp:ListItem Value="02">从输出数据源表添加字段</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                    </tr>
                </table>
                <table id="tabDGRegionPreview" cellspacing="1" cellpadding="1" width="300" border="1"
                    runat="server">
                    <tr>
                        <td>
                            <div style="width: 808px; position: relative; height: 24px">
                                <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                    height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                <asp:Label ID="Label4" Style="z-index: 109; left: 8px; position: absolute; top: 8px"
                                    runat="server" CssClass="h6">列表区域预览</asp:Label>
                            </div>
                        </td>
                        <td>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div id="divQryRegionPreview" style="width: 720px;" runat="server">
                                <asp:PlaceHolder ID="phDataGrid1" runat="server"></asp:PlaceHolder>
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
                                    top: 8px" runat="server" Font-Names="宋体"  Width="120px" Font-Size="Smaller">生成的逻辑层代码：</asp:Label>
                                <asp:LinkButton ID="lbDispTabList" Style="z-index: 102; left: 664px; position: absolute;
                                    top: 8px" runat="server" OnClick="lbDispTabList_Click">显示列表区域字段列表</asp:LinkButton>
                                <asp:Label ID="Label5" Style="z-index: 103; left: 152px; position: absolute; top: 8px"
                                    runat="server"  >生成文件名：</asp:Label>
                                <asp:TextBox ID="txtFileName4GenCode" Style="z-index: 104; left: 248px; position: absolute;
                                    top: 8px" runat="server" Width="336px"></asp:TextBox>
                                <asp:LinkButton ID="lbDownLoadFile" Style="z-index: 111; left: 600px; position: absolute;
                                    top: 8px" runat="server"  Width="56px" OnClick="lbDownLoadFile_Click">下载文件</asp:LinkButton>
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
    <asp:Label ID="lblViewTile" runat="server" Style="z-index: 102; left: 8px; position: absolute;
        top: 8px" CssClass="h5">列表区域字段维护</asp:Label>
    <asp:LinkButton ID="btnGoBack" Style="z-index: 111; left: 784px; position: absolute;
        top: 8px" runat="server"   Text="返回" OnClick="btnGoBack_Click">返回</asp:LinkButton>
    </form>
</body>
</html>
