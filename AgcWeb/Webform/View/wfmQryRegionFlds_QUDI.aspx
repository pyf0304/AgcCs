<%@ Register TagPrefix="uc1" TagName="wucQryRegionFlds" Src="wucQryRegionFlds.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmQryRegionFlds_QUDI.aspx.cs" AutoEventWireup="True"
    ValidateRequest="false" Inherits="AGC.Webform.wfmQryRegionFlds_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表QryRegionFlds的查询、修改、删除、添加记录</title>
    
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
    <div id="divQryRegionFlds" style="z-index: 102; left: 8px; width: 792px; position: absolute;
        top: 35px; height: 32px" runat="server">
        <asp:Label ID="lblRegionIdq" Style="z-index: 101; left: 8px; position: absolute;
            top: 8px" runat="server" CssClass="text-secondary">
  区域</asp:Label>
        <asp:Label ID="lblCtlTypeIdq" Style="z-index: 102; left: 184px; position: absolute;
            top: 8px" runat="server">  控件类型</asp:Label>
        <asp:DropDownList ID="ddlCtlTypeIdq" Style="z-index: 103; left: 240px; position: absolute;
            top: 5px" runat="server" Width="104px">
        </asp:DropDownList>
        <asp:Label ID="lblDdlItemsOptionIdq" Style="z-index: 104; left: 352px; position: absolute;
            top: 8px" runat="server">
  下拉框列表选项</asp:Label>
        <asp:DropDownList ID="ddlDdlItemsOptionIdq" Style="z-index: 105; left: 448px; position: absolute;
            top: 5px" runat="server" Width="88px">
        </asp:DropDownList>
        <asp:Button ID="btnQuery" Style="z-index: 106; left: 704px; position: absolute; top: 8px"
            runat="server"  Text="查询" OnClick="btnQuery_Click">
        </asp:Button>
        <asp:Label ID="lblRegionName" Style="z-index: 107; left: 48px; position: absolute;
            top: 8px" runat="server" CssClass="ValueLabelH1"></asp:Label>
        <asp:Label ID="lblQueryOptionIdq" Style="z-index: 108; left: 536px; position: absolute;
            top: 8px" runat="server" Width="56px">查询方式</asp:Label>
        <asp:DropDownList ID="ddlQueryOptionIdq" Style="z-index: 109; left: 592px; position: absolute;
            top: 5px" runat="server" Width="104px">
        </asp:DropDownList>
    </div>
    <asp:Label ID="lblMsg1" Style="z-index: 111; left: 224px; position: absolute; top: 16px"
        runat="server" CssClass="text-warning" Width="328px"></asp:Label>
    <table id="Table1" style="z-index: 104; left: 8px; position: absolute; top: 88px"
        cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
            <td>
                <table id="tabQryRegionFldsDataGrid" style="font-size: x-small" cellspacing="0" cellpadding="0"
                    width="100%" border="0" runat="server">
                    <tr>
                        <td style="height: 31px">
                            <div style="width: 820px; position: relative; height: 32px">
                               
                                <asp:Button ID="btnDelete4Dg" Style="z-index: 100; left: 216px; position: absolute;
                                    top: 8px" runat="server"  Width="70px" Text="删除" OnClick="btnDelete4Dg_Click">
                                </asp:Button>
                                <asp:Button ID="btnUpdate4Dg" Style="z-index: 101; left: 288px; position: absolute;
                                    top: 8px" runat="server"  Width="70px" Text="修改" OnClick="btnUpdate4Dg_Click">
                                </asp:Button>
                                <asp:Button ID="btnExportExcel4Dg" Style="z-index: 103; left: 744px; position: absolute;
                                    top: 8px" runat="server"  Width="75px" Text="导出Excel" OnClick="btnExportExcel4Dg_Click">
                                </asp:Button>
                                <asp:Button ID="btnCopyFldFromRelaTab" Style="z-index: 104; left: 360px; position: absolute;
                                    top: 8px" runat="server" Width="160px" Text="从区域相关表中复制字段" OnClick="btnCopyFldFromRelaTab_Click">
                                </asp:Button>
                                <img style="z-index: 106; left: 0px; width: 776px; position: absolute; top: 0px;
                                    height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                <asp:Label ID="Label3" Style="z-index: 107; left: 0px; position: absolute; top: 8px"
                                    runat="server" CssClass="h6">查询区域字段列表</asp:Label>
                                <asp:Button ID="btnPreView" Style="z-index: 108; left: 520px; position: absolute;
                                    top: 8px" runat="server"   Text="预览" OnClick="btnPreView_Click">
                                </asp:Button>
                                <asp:Button ID="btnUpMove" Style="z-index: 109; left: 600px; position: absolute;
                                    top: 8px" runat="server"   Text="上移" OnClick="btnUpMove_Click">
                                </asp:Button>
                                <asp:Button ID="btnDownMove" Style="z-index: 110; left: 648px; position: absolute;
                                    top: 8px" runat="server"   Text="下移" OnClick="btnDownMove_Click">
                                </asp:Button>
                                <asp:Button ID="btnReOrder" Style="z-index: 111; left: 696px; position: absolute;
                                    top: 8px" runat="server"   Text="重序" OnClick="btnReOrder_Click">
                                </asp:Button>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DataGrid ID="dgQryRegionFlds" runat="server" Width="100%" AllowSorting="True"
                                AllowPaging="True" AutoGenerateColumns="False" BorderColor="#E7E7FF" BorderStyle="None"
                                BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal" OnItemCommand="dgQryRegionFlds_ItemCommand"
                                OnItemCreated="dgQryRegionFlds_ItemCreated" OnPageIndexChanged="dgQryRegionFlds_PageIndexChanged"
                                OnSortCommand="dgQryRegionFlds_SortCommand" PageSize="100">
                                <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                <Columns>
                                    <asp:TemplateColumn HeaderText="选择">
                                        <HeaderStyle Width="30px"></HeaderStyle>
                                        <HeaderTemplate>
                                            <asp:LinkButton ID="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap text-white" CommandName="lbSelAll">全选</asp:LinkButton>
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
                                    <asp:BoundColumn DataField="TabName" SortExpression="TabName" HeaderText="表名" Visible="False">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="Caption" SortExpression="Caption" HeaderText="标题"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="CtlTypeName" SortExpression="CtlTypeName" HeaderText="控件类型">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="DdlItemsOptionName" SortExpression="DdlItemsOptionName"
                                        HeaderText="下拉框列表选项ID"></asp:BoundColumn>
                                    <asp:BoundColumn Visible="False" DataField="OUTTabName" SortExpression="OUTTabName"
                                        HeaderText="数据源表"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="Ds_DataValueFieldName" SortExpression="Ds_DataValueFieldName"
                                        HeaderText="数据源值字段"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="Ds_DataTextFieldName" SortExpression="Ds_DataTextFieldId"
                                        HeaderText="数据源文本字段"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="QueryOptionName" SortExpression="QueryOptionName" HeaderText="查询方式">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="Ds_CondStr" SortExpression="Ds_CondStr" HeaderText="数据源条件串">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn Visible="False" DataField="Ds_SQLStr" SortExpression="Ds_SQLStr"
                                        HeaderText="数据源SQL串"></asp:BoundColumn>
                                    <asp:BoundColumn Visible="False" DataField="ItemsString" SortExpression="ItemsString"
                                        HeaderText="列表项串"></asp:BoundColumn>
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
                            <table id="tabQryRegionFldsJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                                cellspacing="0" cellpadding="0" width="568" border="1" runat="server" class="Label_Defa">
                                <tr>
                                    <td style="height: 30px">
                                        <span class="text-secondary">共有记录:</span>
                                        <asp:Label ID="lblQryRegionFldsRecCount" runat="server" ForeColor="#000066" Width="46px">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <span class="text-secondary">总页数:</span>
                                        <asp:Label ID="lblQryRegionFldsAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <span class="text-secondary">当前页:</span>
                                        <asp:Label ID="lblQryRegionFldsCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnQryRegionFldsPrevPage" runat="server" Width="50px" Text="上一页"
                                            OnClick="btnQryRegionFldsPrevPage_Click"></asp:Button>
                                        <asp:Button ID="btnQryRegionFldsNextPage" runat="server" Width="50px" Text="下一页"
                                            OnClick="btnQryRegionFldsNextPage_Click"></asp:Button>到第
                                        <asp:TextBox ID="txtQryRegionFldsJump2Page" runat="server" Width="35px"></asp:TextBox>页
                                        <asp:Button ID="btnQryRegionFldsJumpPage" runat="server" Width="35px" Text="确定" OnClick="btnQryRegionFldsJumpPage_Click">
                                        </asp:Button>
                                        <asp:CompareValidator ID="QryRegionFldsCompareValidator1" runat="server" ForeColor="DarkOrange"
                                            Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtQryRegionFldsJump2Page"
                                            ErrorMessage="错误！"></asp:CompareValidator>
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
                        </td>
                    </tr>
                </table>
                <table id="tabEditQryRegionFldsRegion" style="width: 373px" cellspacing="1" cellpadding="1"
                    width="373" border="1" runat="server">
                    <tr>
                        <td>
                            <div style="width: 808px; position: relative; height: 24px">
                                <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 720px; position: absolute; top: 0px"
                                    runat="server"   Text="添加" OnClick="btnOKUpd_Click">
                                </asp:Button>
                                <asp:Label ID="lblMsg" Style="z-index: 105; left: 496px; position: absolute; top: 8px"
                                    runat="server" Width="208px"></asp:Label>
                                <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                    height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                <asp:Label ID="Label1" Style="z-index: 109; left: 0px; position: absolute; top: 8px"
                                    runat="server" CssClass="h6">编辑字段属性</asp:Label>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <uc1:wucQryRegionFlds ID="wucQryRegionFlds1" runat="server"></uc1:wucQryRegionFlds>
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
                <table id="tabQryRegionPreview" cellspacing="1" cellpadding="1" width="300" border="1"
                    runat="server">
                    <tr>
                        <td>
                            <div style="width: 808px; position: relative; height: 24px">
                                <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                    height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                <asp:Label ID="Label4" Style="z-index: 109; left: 8px; position: absolute; top: 8px"
                                    runat="server" CssClass="h6">查询区域预览</asp:Label>
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
                                <asp:PlaceHolder ID="phQryRegion" runat="server"></asp:PlaceHolder>
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
                                    top: 8px" runat="server" OnClick="lbDispTabList_Click">显示查询区域字段列表</asp:LinkButton>
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
    <asp:Label ID="lblViewTile" runat="server" Font-Bold="True" Style="z-index: 110;
        left: 8px; position: absolute; top: 8px" CssClass="h5">查询区域字段维护</asp:Label>
    <asp:LinkButton ID="btnGoBack" Style="z-index: 111; left: 784px; position: absolute;
        top: 8px" runat="server"   Text="返回" OnClick="btnGoBack_Click"></asp:LinkButton>
    </form>
</body>
</html>
