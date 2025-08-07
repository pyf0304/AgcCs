<%@ Register TagPrefix="uc1" TagName="wucEditRegionFlds" Src="wucEditRegionFlds.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmEditRegionFlds_QUDI.aspx.cs" ValidateRequest="false"
    AutoEventWireup="True" Inherits="AGC.Webform.wfmEditRegionFlds_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表EditRegionFlds的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
        
            <div id="divEditRegionFlds" style="z-index: 100; left: 8px; width: 776px; position: absolute;
                top: 35px; height: 64px" runat="server">
                <asp:Label ID="lblRegionIdq" Style="z-index: 100; left: 8px; position: absolute;
                    top: 8px" runat="server"  CssClass="text-secondary">  区域</asp:Label>
                <asp:Label ID="lblCtlTypeIdq" Style="z-index: 101; left: 224px; position: absolute;
                    top: 8px" runat="server" >  控件类型</asp:Label>
                <asp:DropDownList ID="ddlCtlTypeIdq" Style="z-index: 102; left: 288px; position: absolute;
                    top: 8px" runat="server"  Width="136px">
                </asp:DropDownList>
                <asp:Label ID="lblDdlItemsOptionIdq" Style="z-index: 103; left: 432px; position: absolute;
                    top: 8px" runat="server" >
  下拉框列表选项</asp:Label>
                <asp:DropDownList ID="ddlDdlItemsOptionIdq" Style="z-index: 104; left: 528px; position: absolute;
                    top: 8px" runat="server"  Width="144px">
                </asp:DropDownList>
                <asp:Button ID="btnQuery" Style="z-index: 105; left: 680px; position: absolute; top: 40px"
                    runat="server"    
                    Text="查询"></asp:Button>
                <asp:Label ID="lblRegionName" Style="z-index: 106; left: 48px; position: absolute;
                    top: 8px" runat="server" CssClass="ValueLabelH1"></asp:Label>
                <asp:DropDownList ID="ddlInOutTypeId" Style="z-index: 107; left: 288px; position: absolute;
                    top: 40px" runat="server" Width="136px">
                </asp:DropDownList>
                <asp:Label ID="Label1" Style="z-index: 108; left: 200px; position: absolute; top: 40px"
                    runat="server">输入输出类型</asp:Label>
            </div>
            <asp:Label ID="lblMsg1" Style="z-index: 104; left: 216px; position: absolute; top: 16px"
                runat="server"  Width="248px"
                ForeColor="Red"></asp:Label>
            <table id="Table1" style="z-index: 102; left: 8px; position: absolute; top: 104px"
                cellspacing="0" cellpadding="0" width="100%" border="0">
                <tr>
                    <td>
                        <table id="tabEditRegionFldsDataGrid" cellspacing="0" cellpadding="0" width="100%"
                            border="0" runat="server">
                            <tr>
                                <td>
                                    <div style="width: 839px; position: relative; height: 32px">
                                        <asp:Button ID="btnDelete4Dg" Style="z-index: 100; left: 192px; position: absolute;
                                            top: 8px" runat="server"   Text="删除" OnClick="btnDelete4Dg_Click"></asp:Button>
                                        <asp:Button ID="btnUpdate4Dg" Style="z-index: 101; left: 232px; position: absolute;
                                            top: 8px" runat="server"   Text="修改" OnClick="btnUpdate4Dg_Click"></asp:Button>
                                        <asp:Button ID="btnExportExcel4Dg" Style="z-index: 103; left: 768px; position: absolute;
                                            top: 8px" runat="server"  Width="70px" Text="导出Excel" OnClick="btnExportExcel4Dg_Click"></asp:Button>
                                        <asp:Button ID="btnCopyFldFromRelaTab" Style="z-index: 104; left: 272px; position: absolute;
                                            top: 8px" runat="server" Width="160px" Text="从区域相关表中复制字段" OnClick="btnCopyFldFromRelaTab_Click"></asp:Button>
                                        <img style="z-index: 106; left: 0px; width: 776px; position: absolute; top: 0px;
                                            height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                        <asp:Label ID="Label3" Style="z-index: 107; left: 8px; position: absolute; top: 8px"
                                            runat="server" CssClass="h6">编辑区域字段列表</asp:Label>
                                        <asp:Button ID="btnPreView" Style="z-index: 108; left: 440px; position: absolute;
                                            top: 8px" runat="server"   Text="预览" OnClick="btnPreView_Click"></asp:Button>
                                        <asp:Button ID="btnUpMove" Style="z-index: 109; left: 488px; position: absolute;
                                            top: 8px" runat="server"   Text="上移" OnClick="btnUpMove_Click"></asp:Button>
                                        <asp:Button ID="btnDownMove" Style="z-index: 110; left: 528px; position: absolute;
                                            top: 8px; right: 271px;" runat="server"   
                                            Text="下移" OnClick="btnDownMove_Click"></asp:Button>
                                        <asp:Button ID="btnReOrder" Style="z-index: 111; left: 696px; position: absolute;
                                            top: 8px" runat="server"   Text="重序" OnClick="btnReOrder_Click"></asp:Button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DataGrid ID="dgEditRegionFlds" runat="server"
                                        Width="100%" GridLines="Horizontal" CellPadding="3" BackColor="White" BorderWidth="1px"
                                        BorderStyle="None" BorderColor="#E7E7FF" AutoGenerateColumns="False" AllowPaging="True"
                                        AllowSorting="True" OnItemCommand="dgEditRegionFlds_ItemCommand" 
                                        OnItemCreated="dgEditRegionFlds_ItemCreated" 
                                        OnPageIndexChanged="dgEditRegionFlds_PageIndexChanged" 
                                        OnSortCommand="dgEditRegionFlds_SortCommand" PageSize="100">
                                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                        <Columns>
                                            <asp:TemplateColumn HeaderText="选择">
                                                <HeaderStyle Width="30px"></HeaderStyle>
                                                <HeaderTemplate>
                                                    <asp:LinkButton ID="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap text-white" 
                                                         CommandName="lbSelAll">全选</asp:LinkButton>
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
                                            <asp:BoundColumn DataField="TabName" SortExpression="TabName" HeaderText="表名" 
                                                Visible="False"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="Caption" SortExpression="Caption" HeaderText="标题"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="InOutTypeName" SortExpression="InOutTypeName" HeaderText="OUT/IN">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="CtlTypeName" SortExpression="CtlTypeName" HeaderText="控件类型">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="DdlItemsOptionName" SortExpression="DdlItemsOptionName"
                                                HeaderText="下拉列表选项"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="OUTTabName" SortExpression="OUTTabName"
                                                HeaderText="数据源表"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="Ds_DataValueFieldName" SortExpression="Ds_DataValueFieldName"
                                                HeaderText="值字段"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="Ds_DataTextFieldName" SortExpression="Ds_DataTextFieldId"
                                                HeaderText="文本字段"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="Ds_CondStr" SortExpression="Ds_CondStr" HeaderText="条件串">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="Ds_SQLStr" SortExpression="Ds_SQLStr"
                                                HeaderText="数据源SQL串"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="ItemsString" SortExpression="ItemsString"
                                                HeaderText="列表项串"></asp:BoundColumn>
                                                                                <asp:BoundColumn DataField="InUse" SortExpression="InUse" HeaderText="使用?">
                                    </asp:BoundColumn>

                                            <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                        </Columns>
                                        <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                        </PagerStyle>
                                    </asp:DataGrid></td>
                            </tr>
                            <tr>
                                <td style="width: 605px; height: 67px;" bgcolor="silver">
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
                                                        <asp:Button ID="btnEditRegionFldsPrevPage" runat="server"  
                                                            Width="50px" Text="上一页" OnClick="btnEditRegionFldsPrevPage_Click"></asp:Button><asp:Button ID="btnEditRegionFldsNextPage" runat="server"
                                                                  Width="50px" Text="下一页" OnClick="btnEditRegionFldsNextPage_Click"></asp:Button>到第
                                                        <asp:TextBox ID="txtEditRegionFldsJump2Page" runat="server"  
                                                            Width="35px"></asp:TextBox>页
                                                        <asp:Button ID="btnEditRegionFldsJumpPage" runat="server"  
                                                            Width="35px" Text="确定" OnClick="btnEditRegionFldsJumpPage_Click"></asp:Button><asp:CompareValidator ID="EditRegionFldsCompareValidator1"
                                                                runat="server" ForeColor="DarkOrange" ErrorMessage="错误！" ControlToValidate="txtEditRegionFldsJump2Page"
                                                                Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font></td>
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
                                    <div style="width: 776px; position: relative; height: 32px">
                                        <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 688px; position: absolute; top: 8px"
                                            runat="server"    
                                            Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                        <asp:Label ID="lblMsg" Style="z-index: 105; left: 472px; position: absolute; top: 16px"
                                            runat="server" Width="208px"></asp:Label>
                                        <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                            height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                        <asp:Label ID="Label4" Style="z-index: 109; left: 0px; position: absolute; top: 8px"
                                            runat="server"  Width="128px" CssClass="h6">编辑字段属性</asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <uc1:wuceditregionflds id="wucEditRegionFlds1" runat="server">
                                    </uc1:wuceditregionflds></td>
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
                        <table id="tabEditRegionPreview" cellspacing="1" cellpadding="1" width="300" border="1"
                            runat="server">
                            <tr>
                                <td>
                                    <div style="width: 808px; position: relative; height: 24px">
                                        <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                            height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                        <asp:Label ID="Label5" Style="z-index: 109; left: 8px; position: absolute; top: 8px"
                                            runat="server" CssClass="h6">编辑区域预览</asp:Label>
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
                                        <asp:PlaceHolder ID="phEditRegion" runat="server"></asp:PlaceHolder>
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
                                            top: 8px" runat="server"  Font-Names="宋体" Font-Size="Smaller" Width="120px">生成的逻辑层代码：</asp:Label>
                                        <asp:LinkButton ID="lbDispTabList" Style="z-index: 102; left: 664px; position: absolute;
                                            top: 8px" runat="server" OnClick="lbDispTabList_Click">显示编辑区域字段列表</asp:LinkButton>
                                        <asp:Label ID="Label6" Style="z-index: 103; left: 152px; position: absolute; top: 8px"
                                            runat="server"  >生成文件名：</asp:Label>
                                        <asp:TextBox ID="txtFileName4GenCode" Style="z-index: 104; left: 248px; position: absolute;
                                            top: 8px" runat="server"  Width="336px"></asp:TextBox>
                                        <asp:LinkButton ID="lbDownLoadFile" Style="z-index: 111; left: 600px; position: absolute;
                                            top: 8px" runat="server" 
                                            Width="56px" OnClick="lbDownLoadFile_Click">下载文件</asp:LinkButton>
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
        </font>
        <asp:Label ID="lblViewTile" runat="server" Font-Bold="True" Style="z-index: 103;
            left: 8px; position: absolute; top: 8px" CssClass="h5">编辑区域字段维护</asp:Label>
        <asp:LinkButton ID="btnGoBack" Style="z-index: 111; left: 784px; position: absolute;
            top: 8px" runat="server"   Text="返回" OnClick="btnGoBack_Click" >返回</asp:LinkButton>
    </form>
</body>
</html>
