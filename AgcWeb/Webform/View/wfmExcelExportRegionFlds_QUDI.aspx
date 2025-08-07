<%@ Page Language="c#" CodeBehind="wfmExcelExportRegionFlds_QUDI.aspx.cs" ValidateRequest="false"
    AutoEventWireup="True" Inherits="AGC.Webform.wfmExcelExportRegionFlds_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucExcelExportRegionFlds" Src="wucExcelExportRegionFlds.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表ExcelExportRegionFlds的查询、修改、删除、添加记录</title>
    
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
        
            <asp:Label ID="lblMsg1" Style="z-index: 104; left: 280px; position: absolute; top: 8px"
                runat="server" Width="248px"  
                ForeColor="Red"></asp:Label>
            <div id="divExcelExportRegionFlds" style="z-index: 102; left: 8px; width: 640px;
                position: absolute; top: 35px; height: 27px" runat="server">
                <asp:Label ID="lblColCaptionq" Style="z-index: 104; left: 10px; position: absolute;
                    top: 5px" runat="server"  >
  列标题</asp:Label>
                <asp:TextBox ID="txtColCaptionq" Style="z-index: 105; left: 61px; position: absolute;
                    top: 5px" runat="server" Width="95px" ></asp:TextBox>
                <asp:Button ID="btnQuery" Style="z-index: 107; left: 288px; position: absolute; top: 0px"
                    runat="server"    
                    Text="查询"></asp:Button>
            </div>
            <table id="Table1" style="z-index: 103; left: 8px; width: 100%; position: absolute;
                top: 64px" cellspacing="0" cellpadding="0" width="100%" border="0">
                <tr>
                    <td>
                        <table id="tabExcelExportRegionFldsDataGrid" style="width: 100%"
                            cellspacing="0" cellpadding="0" width="100%" border="0" runat="server">
                            <tr>
                                <td>
                                    <div style="width: 855px; position: relative; height: 32px">
                            
                                        <asp:Button ID="btnDelete4Dg" Style="z-index: 100; left: 264px; position: absolute;
                                            top: 8px" runat="server" Width="70px"  Text="删除" OnClick="btnDelete4Dg_Click"></asp:Button>
                                        <asp:Button ID="btnUpdate4Dg" Style="z-index: 101; left: 336px; position: absolute;
                                            top: 8px" runat="server" Width="70px"  Text="修改" OnClick="btnUpdate4Dg_Click"></asp:Button>
                                        <asp:Button ID="btnExportExcel4Dg" Style="z-index: 103; left: 784px; position: absolute;
                                            top: 8px" runat="server" Width="70px"  Text="导出Excel" OnClick="btnExportExcel4Dg_Click"></asp:Button>
                                        <asp:Button ID="btnCopyFldFromRelaTab" Style="z-index: 104; left: 408px; position: absolute;
                                            top: 8px" runat="server" Width="160px" Text="从区域相关表中复制字段" OnClick="btnCopyFldFromRelaTab_Click"></asp:Button>
                                        <asp:Label ID="Label3" Style="z-index: 105; left: 8px; position: absolute; top: 8px"
                                            runat="server" Width="192px"  CssClass="h6">Excel导出区域字段列表</asp:Label>
                                        <img style="z-index: 106; left: 0px; width: 776px; position: absolute; top: 0px;
                                            height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                        <asp:Button ID="btnUpMove" Style="z-index: 107; left: 656px; position: absolute;
                                            top: 8px" runat="server"   Text="上移" OnClick="btnUpMove_Click"></asp:Button>
                                        <asp:Button ID="btnDownMove" Style="z-index: 108; left: 696px; position: absolute;
                                            top: 8px" runat="server"   Text="下移" OnClick="btnDownMove_Click"></asp:Button>
                                        <asp:Button ID="btnReOrder" Style="z-index: 110; left: 744px; position: absolute;
                                            top: 8px" runat="server"   Text="重序" OnClick="btnReOrder_Click"></asp:Button>
                                        <asp:Button ID="btnPreView" Style="z-index: 111; left: 576px; position: absolute;
                                            top: 8px" runat="server"   Text="预览" OnClick="btnPreView_Click"></asp:Button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DataGrid ID="dgExcelExportRegionFlds" runat="server" Width="100%" 
                                         AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True"
                                        BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White"
                                        CellPadding="3" GridLines="Horizontal" 
                                        OnItemCommand="dgExcelExportRegionFlds_ItemCommand" 
                                        OnItemCreated="dgExcelExportRegionFlds_ItemCreated" 
                                        OnPageIndexChanged="dgExcelExportRegionFlds_PageIndexChanged" 
                                        OnSortCommand="dgExcelExportRegionFlds_SortCommand" PageSize="100">
                                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
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
                                            <asp:BoundColumn Visible="False" DataField="mId" SortExpression="mId" HeaderText="mId">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="SeqNum" SortExpression="SeqNum" HeaderText="序号"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="TabName" SortExpression="TabName" HeaderText="表名" 
                                                Visible="False"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="DataTypeId" SortExpression="DataTypeId" HeaderText="字段类型">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="FldLength" SortExpression="FldLength"
                                                HeaderText="字段长度"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="Caption" SortExpression="Caption" HeaderText="标题"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="ColCaption" SortExpression="ColCaption" HeaderText="列标题">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="IsNull" SortExpression="IsNull" HeaderText="是否可空">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="IsTabPrimary" SortExpression="IsTabPrimary"
                                                HeaderText="是否作为表中主键"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="SequenceNumber" SortExpression="SequenceNumber"
                                                HeaderText="顺序号"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="IsParentObj" SortExpression="IsParentObj"
                                                HeaderText="是否父对象"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="PrimaryTypeName" SortExpression="PrimaryTypeName"
                                                HeaderText="主键类型名"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="DataTypeName" SortExpression="DataTypeName" HeaderText="DataTypeName">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="RegionId" SortExpression="RegionId" HeaderText="区域Id">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="IsTabNullable" SortExpression="IsTabNullable" HeaderText="是否表中可空">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="TabFldId" SortExpression="TabFldId" HeaderText="表字段ID">
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
                                    </asp:DataGrid></td>
                            </tr>
                            <tr>
                                <td style="width: 605px" bgcolor="silver">
                                    <table id="tabExcelExportRegionFldsJumpPage" style="width: 568px;
                                        font-family: Verdana; height: 26px" cellspacing="0" cellpadding="0" width="568"
                                        border="1" runat="server" class="Label_Defa">
                                        <tr>
                                            <td>
                                                <font style="background-color: #c0c0c0">共有记录:</font>
                                                    <asp:Label ID="lblExcelExportRegionFldsRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <font style="background-color: #c0c0c0">总页数:</font>
                                                    <asp:Label ID="lblExcelExportRegionFldsAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <font style="background-color: #c0c0c0">当前页:
                                                        <asp:Label ID="lblExcelExportRegionFldsCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                        <div style="display: inline; width: 16px; height: 13px">
                                                        </div>
                                                        <asp:Button ID="btnExcelExportRegionFldsPrevPage" runat="server" Width="50px" 
                                                             Text="上一页" OnClick="btnExcelExportRegionFldsPrevPage_Click"></asp:Button><asp:Button ID="btnExcelExportRegionFldsNextPage"
                                                                runat="server" Width="50px"   Text="下一页" OnClick="btnExcelExportRegionFldsNextPage_Click"></asp:Button>到第
                                                        <asp:TextBox ID="txtExcelExportRegionFldsJump2Page" runat="server" Width="35px" 
                                                            ></asp:TextBox>页
                                                        <asp:Button ID="btnExcelExportRegionFldsJumpPage" runat="server" Width="35px" 
                                                             Text="确定" OnClick="btnExcelExportRegionFldsJumpPage_Click"></asp:Button><asp:CompareValidator ID="ExcelExportRegionFldsCompareValidator1"
                                                                runat="server" ForeColor="DarkOrange" ErrorMessage="错误！" ControlToValidate="txtExcelExportRegionFldsJump2Page"
                                                                Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font></td>
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
                        <table id="tabEditExcelExportRegionFldsRegion" style="width: 373px; height: 200px"
                            cellspacing="1" cellpadding="1" width="373" border="1" runat="server">
                            <tr>
                                <td>
                                    <div style="width: 776px; position: relative; height: 32px">
                                        <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 688px; position: absolute; top: 8px"
                                            runat="server"    
                                            Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                        <asp:Label ID="lblMsg" Style="z-index: 105; left: 472px; position: absolute; top: 16px"
                                            runat="server" Width="208px" Height="10px" ></asp:Label>
                                        <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                            height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                        <asp:Label ID="Label1" Style="z-index: 109; left: 0px; position: absolute; top: 8px"
                                            runat="server" Width="128px"  Font-Size="Small" 
                                            ForeColor="#004040" Font-Bold="True">编辑字段属性</asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <uc1:wucexcelexportregionflds id="wucExcelExportRegionFlds1" runat="server">
                                    </uc1:wucexcelexportregionflds></td>
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
                        <table id="tabExcelExportRegionPreview" cellspacing="1" cellpadding="1" width="300"
                            border="1" runat="server">
                            <tr>
                                <td>
                                    <div style="width: 808px; position: relative; height: 24px">
                                        <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                            height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                        <asp:Label ID="Label4" Style="z-index: 109; left: 8px; position: absolute; top: 8px"
                                            runat="server" CssClass="h6">Excel导出区域预览</asp:Label>
                                    </div>
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div id="divQryRegionPreview" style="width: 720px;"
                                        runat="server">
                                        <asp:PlaceHolder ID="phExcelExportRegion" runat="server"></asp:PlaceHolder>
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
                        <table id="tabCode" style="width: 834px; height: 551px" cellspacing="1" cellpadding="1"
                            width="834" border="1" runat="server">
                            <tr>
                                <td colspan="2">
                                    <div style="width: 826px; position: relative; height: 32px">
                                        <asp:Label ID="lblCaption4GenCode" Style="z-index: 101; left: 8px; position: absolute;
                                            top: 8px" runat="server" Width="120px"  Font-Size="Smaller" Font-Names="宋体">生成的逻辑层代码：</asp:Label>
                                        <asp:LinkButton ID="lbDispTabList" Style="z-index: 102; left: 664px; position: absolute;
                                            top: 8px" runat="server" OnClick="lbDispTabList_Click" >显示Excel导出字段列表</asp:LinkButton>
                                        <asp:Label ID="Label5" Style="z-index: 103; left: 152px; position: absolute; top: 8px"
                                            runat="server"   >生成文件名：</asp:Label>
                                        <asp:TextBox ID="txtFileName4GenCode" Style="z-index: 104; left: 248px; position: absolute;
                                            top: 8px" runat="server" Width="336px" ></asp:TextBox>
                                        <asp:LinkButton ID="lbDownLoadFile" Style="z-index: 111; left: 600px; position: absolute;
                                            top: 8px" runat="server" Width="56px"  OnClick="lbDownLoadFile_Click" >下载文件</asp:LinkButton>
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
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
            <asp:Label ID="lblViewTile" Style="z-index: 105; left: 8px; position: absolute; top: 8px"
                runat="server" CssClass="h5">Excel导出区域字段列表维护</asp:Label>
        </font>
        <asp:LinkButton ID="btnGoBack" Style="z-index: 111; left: 800px; position: absolute;
            top: 8px" runat="server"   Text="返回" OnClick="btnGoBack_Click"></asp:LinkButton>
    </form>
</body>
</html>
