<%@ Register TagPrefix="uc1" TagName="wucViewRegion" Src="wucViewRegion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="wucQryRegion" Src="wucQryRegion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="wucDispViewTab" Src="wucDispViewTab.ascx" %>
<%@ Register TagPrefix="uc1" TagName="wucListViewRegion" Src="wucListViewRegion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="wucEditRegion" Src="wucEditRegion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="wucDGRegion" Src="wucDGRegion.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmViewRegion_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmViewRegion_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>界面区域维护</title>
    
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
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
            <div id="divViewRegion" style="z-index: 101; left: 4px; width: 800px; position: absolute;
                top: 34px; height: 26px" runat="server">
                <asp:Button ID="btnQuery" Style="z-index: 107; left: 680px; position: absolute; top: 0px"
                    runat="server" Enabled="False" Text="查询" 
                      OnClick="btnQuery_Click"></asp:Button>
                <asp:Label ID="Label10" Style="z-index: 106; left: 8px; position: absolute; top: 4px"
                    runat="server" CssClass="text-secondary" BorderColor="#004040">界面名称：</asp:Label>
                <asp:Label ID="lblViewName" Style="z-index: 105; left: 88px; position: absolute;
                    top: 4px" runat="server" CssClass="ValueLabelH1" BorderColor="#004040">添加相关界面区域</asp:Label>
            </div>
            <asp:Label ID="lblErrMsg" Style="z-index: 104; left: 224px; position: absolute; top: 8px"
                runat="server"  Width="264px"
                CssClass="text-warning"></asp:Label>
            <table id="Table1" style="z-index: 102; left: 4px; width: 800px; position: absolute;
                top: 64px" cellspacing="4" cellpadding="0" width="800" border="1">
                <tr>
                    <td>
                        <table id="tabViewRegionDataGrid" style="width: 552px" cellspacing="0"
                            cellpadding="0" width="552" border="0" runat="server">
                            <tr>
                                <td>
                                    <div style="width: 841px; position: relative; height: 24px">
                                        <asp:Button ID="btnAddNewRec4Dg" Style="z-index: 103; left: 8px; position: absolute;
                                            top: 0px" runat="server" Text="添加新区域"   OnClick="btnAddNewRec4Dg_Click"></asp:Button>
                                        <asp:Button ID="btnDelete4Dg" Style="z-index: 100; left: 384px; position: absolute;
                                            top: 0px" runat="server" Text="删除区域"   OnClick="btnDelete4Dg_Click"></asp:Button>
                                        <asp:Button ID="btnUpdate4Dg" Style="z-index: 102; left: 208px; position: absolute;
                                            top: 0px" runat="server" Text="修改一般属性"  Width="88px" OnClick="btnUpdate4Dg_Click"></asp:Button>
                                        <asp:Button ID="btnExportExcel4Dg" Style="z-index: 104; left: 760px; position: absolute;
                                            top: 0px" runat="server" Text="导出Excel"   OnClick="btnExportExcel4Dg_Click"></asp:Button>
                                        <asp:Button ID="btnEditRegionFld" Style="z-index: 105; left: 528px; position: absolute;
                                            top: 0px" runat="server" Text="编辑区域字段"  Width="96px" OnClick="btnEditRegionFld_Click"></asp:Button>
                                        <asp:Button ID="btnAddRelaJspView" Style="z-index: 106; left: 88px; position: absolute;
                                            top: 0px" runat="server" Text="添加相关界面区域"  Width="112px" OnClick="btnAddRelaJspView_Click"></asp:Button>
                                        <asp:Button ID="btnUpdSpecialProperty" Style="z-index: 108; left: 296px; position: absolute;
                                            top: 0px" runat="server" Text="修改特殊属性"  Width="88px" OnClick="btnUpdSpecialProperty_Click"></asp:Button>
                                        <asp:Button ID="btnPreView" Style="z-index: 111; left: 472px; position: absolute;
                                            top: 0px" runat="server" Text="预览"   OnClick="btnPreView_Click"></asp:Button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div id="divViewRelaRegion" style="width: 841px; position: relative; height: 470px"
                                        runat="server">
                                        <asp:Button ID="btnStartGene" Style="z-index: 101; left: 544px; position: absolute;
                                            top: 32px" runat="server" Text="开始生成"   OnClick="btnStartGene_Click"></asp:Button>
                                        <table id="Table5" style="z-index: 102; left: 8px; width: 520px; position: absolute;
                                            top: 32px; height: 168px" cellspacing="0" cellpadding="0" width="520" border="0">
                                            <tr>
                                                <td class="NameTD">
                                                    <asp:Label ID="Label3" runat="server"  
                                                        Width="64px" BorderColor="#004040">区域类型</asp:Label></td>
                                                <td>
                                                </td>
                                                <td class="NameTd">
                                                    <asp:Label ID="Label2" runat="server"  
                                                         BorderColor="#004040" CssClass="RegionTitleH3">区域名称</asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:CheckBox ID="chkQueryRegion" runat="server" Text="查询区域"
                                                         AutoPostBack="True" CssClass="Check_Defa" OnCheckedChanged="chkQueryRegion_CheckedChanged"></asp:CheckBox></td>
                                                <td>
                                                </td>
                                                <td>
                                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                        <ContentTemplate>
                                                    <asp:TextBox ID="txtFileName_QueryRegion" runat="server" 
                                                        Width="320px"></asp:TextBox>
                                                        </ContentTemplate>
                                                        <Triggers>
                                                            <asp:AsyncPostBackTrigger ControlID="chkQueryRegion" EventName="CheckedChanged" />
                                                        </Triggers>
                                                    </asp:UpdatePanel>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:CheckBox ID="chkDGRegion" runat="server" Text="列表区域" 
                                                        AutoPostBack="True" CssClass="Check_Defa" OnCheckedChanged="chkDGRegion_CheckedChanged"></asp:CheckBox></td>
                                                <td>
                                                </td>
                                                <td>
                                                   <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                        <ContentTemplate>
                                                    <asp:TextBox ID="txtFileName_DGRegion" runat="server" 
                                                        Width="320px"></asp:TextBox>
                                                        </ContentTemplate>
                                                        <Triggers>
                                                            <asp:AsyncPostBackTrigger ControlID="chkDGRegion" EventName="CheckedChanged" />
                                                        </Triggers>
                                                    </asp:UpdatePanel>
                                                </td>
                                            </tr>
                                           <%-- <tr>
                                                <td>
                                                    <asp:CheckBox ID="chkListViewRegion" runat="server" Text="LV1列表区域"
                                                         AutoPostBack="True" CssClass="Check_Defa" OnCheckedChanged="chkListViewRegion_CheckedChanged"></asp:CheckBox></td>
                                                <td>
                                                </td>
                                                <td>
                                                    <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                                        <ContentTemplate>
                                                    <asp:TextBox ID="txtFileName_ListViewRegion" runat="server"
                                                         Width="320px"></asp:TextBox>
                                                        </ContentTemplate>
                                                        <Triggers>
                                                            <asp:AsyncPostBackTrigger ControlID="chkListViewRegion" EventName="CheckedChanged" />
                                                        </Triggers>
                                                    </asp:UpdatePanel>
                                                </td>
                                            </tr>--%>
                                            <tr>
                                                <td>
                                                    <asp:CheckBox ID="chkEditRegion" runat="server" Text="编辑区域"
                                                         AutoPostBack="True" CssClass="Check_Defa" OnCheckedChanged="chkEditRegion_CheckedChanged"></asp:CheckBox></td>
                                                <td>
                                                </td>
                                                <td>
                                                    <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                                        <ContentTemplate>
                                                    <asp:TextBox ID="txtFileName_EditRegion" runat="server" 
                                                        Width="320px"></asp:TextBox>
                                                        </ContentTemplate>
                                                        <Triggers>
                                                            <asp:AsyncPostBackTrigger ControlID="chkEditRegion" EventName="CheckedChanged" />
                                                        </Triggers>
                                                    </asp:UpdatePanel>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:CheckBox ID="chkExcelExportRegion" runat="server" Text="Excel导出区域"
                                                         AutoPostBack="True" CssClass="Check_Defa" OnCheckedChanged="chkExcelExportRegion_CheckedChanged"></asp:CheckBox></td>
                                                <td>
                                                </td>
                                                <td>
                                                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                                        <ContentTemplate>
                                                    <asp:TextBox ID="txtFileName_ExcelExportRegion" runat="server"
                                                         Width="320px"></asp:TextBox>
                                                        </ContentTemplate>
                                                        <Triggers>
                                                            <asp:AsyncPostBackTrigger ControlID="chkExcelExportRegion" EventName="CheckedChanged" />
                                                        </Triggers>
                                                    </asp:UpdatePanel>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:CheckBox ID="chkDetailRegion" runat="server" Text="详细信息区域"
                                                         AutoPostBack="True" CssClass="Check_Defa" OnCheckedChanged="chkDetailRegion_CheckedChanged"></asp:CheckBox></td>
                                                <td>
                                                </td>
                                                <td>
                                                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                                        <ContentTemplate>
                                                    <asp:TextBox ID="txtFileName_DetailRegion" runat="server" 
                                                        Width="320px"></asp:TextBox>
                                                        </ContentTemplate>
                                                        <Triggers>
                                                            <asp:AsyncPostBackTrigger ControlID="chkDetailRegion" EventName="CheckedChanged" />
                                                        </Triggers>
                                                    </asp:UpdatePanel>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:CheckBox ID="chkTreeViewRegion" runat="server" Text="树区域"
                                                         AutoPostBack="True" CssClass="Check_Defa" OnCheckedChanged="chkTreeViewRegion_CheckedChanged"></asp:CheckBox></td>
                                                <td>
                                                </td>
                                                <td>
                                                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                                        <ContentTemplate>
                                                    <asp:TextBox ID="txtFileName_TreeViewRegion" runat="server"
                                                         Width="320px"></asp:TextBox>
                                                        </ContentTemplate>
                                                        <Triggers>
                                                            <asp:AsyncPostBackTrigger ControlID="chkTreeViewRegion" EventName="CheckedChanged" />
                                                        </Triggers>
                                                    </asp:UpdatePanel>
                                                </td>
                                            </tr>
                                        </table>
                                        <asp:Button ID="btnCloseDiv" Style="z-index: 103; left: 640px; position: absolute;
                                            top: 32px" runat="server" Text="取消" OnClick="btnCloseDiv_Click" Width="76px"></asp:Button>
                                        <asp:Label ID="lblMsg2" Style="z-index: 104; left: 544px; position: absolute; top: 64px"
                                            runat="server" Width="200px" CssClass="text-warning"></asp:Label>
                                        <asp:Label ID="Label1" Style="z-index: 105; left: 8px; position: absolute; top: 8px"
                                            runat="server" Font-Names="幼圆"  Width="139px"
                                            CssClass="h6" BorderColor="#004040" Font-Bold="True" ForeColor="DarkGray">添加相关界面区域</asp:Label>
                                        <div style="z-index: 100; left: 152px; width: 584px; color:Yellow;
                                            position: absolute; top: 8px; height: 16px" class="MemoStyle1">
                                            在当前界面中添加相关区域，同时添加该区域的相关字段列表。</div>
                                        <img style="z-index: 106; left: 0px; width: 832px; position: absolute; top: 0px;
                                            height: 4px" height="4" alt="" src="../../pic/兰色直线1.gif" width="832"/>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DataGrid ID="dgViewRegion" runat="server" 
                                        Width="858px" BorderColor="#E7E7FF" GridLines="Horizontal" CellPadding="3" BackColor="White"
                                        BorderWidth="1px" BorderStyle="None" AutoGenerateColumns="False" AllowPaging="True"
                                        AllowSorting="True" CssClass="table table-striped table-bordered table-condensed" OnItemCommand="dgViewRegion_ItemCommand" OnItemCreated="dgViewRegion_ItemCreated" OnPageIndexChanged="dgViewRegion_PageIndexChanged" OnSortCommand="dgViewRegion_SortCommand">
                                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                        <Columns>
                                            <asp:TemplateColumn HeaderText="选择">
                                                <HeaderStyle ForeColor="White" Width="30px"></HeaderStyle>
                                                <HeaderTemplate>
                                                    <asp:LinkButton ID="lbSelAll" runat="server" 
                                                        CssClass="btn btn-link btn-sm text-nowrap text-white" CommandName="lbSelAll">全选</asp:LinkButton>
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:BoundColumn DataField="RegionId" SortExpression="RegionId" HeaderText="区域Id"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="RegionName" SortExpression="RegionName" HeaderText="区域名称">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="ViewName" SortExpression="ViewName" HeaderText="界面名称"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="RegionTypeName" SortExpression="RegionTypeId" HeaderText="区域类型">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="RegionFunction" SortExpression="RegionFunction" HeaderText="区域功能">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="OUTSqlDsTypeName" SortExpression="OUTSqlDsTypeName" HeaderText="数据源类型">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="OUTTabName" SortExpression="OUTTabName" HeaderText="表/视图名">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="Height" SortExpression="Height" HeaderText="高度"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="Width" SortExpression="Width" HeaderText="宽"></asp:BoundColumn>
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
                                <td style="width: 605px; background-color:Silver">
                                    <table id="tabViewRegionJumpPage" style="width: 568px; font-family: Verdana;
                                        height: 26px" cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                        <tr>
                                            <td>
                                                <span class="text-secondary">共有记录:</span>
                                                    <asp:Label ID="lblViewRegionRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <span class="text-secondary">总页数:</span>
                                                    <asp:Label ID="lblViewRegionAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <span class="text-secondary">当前页:</span>
                                                        <asp:Label ID="lblViewRegionCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                        <div style="display: inline; width: 16px; height: 13px">
                                                        </div>
                                                        <asp:Button ID="btnViewRegionPrevPage" runat="server" Text="上一页" 
                                                             Width="50px"></asp:Button><asp:Button ID="btnViewRegionNextPage" runat="server"
                                                                Text="下一页"   Width="50px"></asp:Button>到第
                                                        <asp:TextBox ID="txtViewRegionJump2Page" runat="server"  
                                                            Width="35px"></asp:TextBox>页
                                                        <asp:Button ID="btnViewRegionJumpPage" runat="server" Text="确定" 
                                                             Width="35px"></asp:Button><asp:CompareValidator ID="ViewRegionCompareValidator1"
                                                                runat="server" ForeColor="DarkOrange" ErrorMessage="错误！" ControlToValidate="txtViewRegionJump2Page"
                                                                Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table id="tabEditViewRegionRegion" style="width: 824px; height: 303px" cellspacing="0"
                            cellpadding="0" border="0" runat="server">
                            <tr>
                                <td>
                                    <div style="width: 832px; position: relative; height: 32px">
                                        <asp:Button ID="btnOKUpd" Style="z-index: 101; left: 624px; position: absolute; top: 8px"
                                            runat="server" Text="添加"  
                                            Width="121px" OnClick="btnOKUpd_Click"></asp:Button>
                                        <asp:Label ID="lblMsg" Style="z-index: 100; left: 440px; position: absolute; top: 8px"
                                            runat="server"  Width="176px" CssClass="text-warning"></asp:Label>
                                        <asp:Label ID="Label4" Style="z-index: 103; left: 0px; position: absolute; top: 8px"
                                            runat="server" Width="128px" CssClass="h6"
                                            BorderColor="#004040">编辑区域属性</asp:Label>
                                        <img style="z-index: 104; left: 0px; width: 832px; position: absolute; top: 0px;
                                            height: 4px" height="4" alt="" src="../../pic/兰色直线1.gif" width="832"/>
                                        <asp:Button ID="btnClear" Style="z-index: 105; left: 752px; position: absolute; top: 8px"
                                            runat="server" Text="取消"  
                                            Width="64px" OnClick="btnClear_Click"></asp:Button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <table id="tabViewRegion" cellspacing="0" cellpadding="0" width="300" border="0"
                                        runat="server">
                                        <tr>
                                            <td>
                                                <div style="width: 280px; position: relative; height: 25px">
                                                    <asp:Label ID="Label5" Style="z-index: 103; left: 0px; position: absolute; top: 8px"
                                                        runat="server" Width="128px" CssClass="RegionTitleH2"
                                                        BorderColor="#004040">区域一般属性</asp:Label>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <uc1:wucviewregion id="wucViewRegion1" runat="server">
                                                </uc1:wucviewregion></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <table id="tabQryRegion" cellspacing="0" cellpadding="0" width="300" border="0" runat="server">
                                        <tr>
                                            <td>
                                                <div style="width: 280px; position: relative; height: 25px">
                                                    <asp:Label ID="Label6" Style="z-index: 103; left: 0px; position: absolute; top: 8px"
                                                        runat="server" Width="128px" CssClass="RegionTitleH2"
                                                        BorderColor="#004040">查询区域特殊属性</asp:Label>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <uc1:wucqryregion id="wucQryRegion1" runat="server">
                                                </uc1:wucqryregion></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <table id="tabDGRegion" cellspacing="0" cellpadding="0" width="300" border="0" runat="server">
                                        <tr>
                                            <td>
                                                <div style="width: 280px; position: relative; height: 26px">
                                                    <asp:Label ID="Label7" Style="z-index: 103; left: 0px; position: absolute; top: 8px"
                                                        runat="server" Width="160px" CssClass="RegionTitleH2"
                                                        BorderColor="#004040">列表区域特殊属性</asp:Label>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <uc1:wucdgregion id="wucDGRegion1" runat="server">
                                                </uc1:wucdgregion></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <table id="tabEditRegion" cellspacing="0" cellpadding="0" width="300" border="0"
                                        runat="server">
                                        <tr>
                                            <td>
                                                <div style="width: 280px; position: relative; height: 25px">
                                                    <asp:Label ID="Label8" Style="z-index: 103; left: 0px; position: absolute; top: 8px"
                                                        runat="server" Width="128px" CssClass="RegionTitleH2"
                                                        BorderColor="#004040">编辑区域特殊属性</asp:Label>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <uc1:wuceditregion id="wucEditRegion1" runat="server">
                                                </uc1:wuceditregion></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <table id="tabListViewRegion" cellspacing="0" cellpadding="0" width="300" border="0"
                                        runat="server">
                                        <tr>
                                            <td>
                                                <div style="width: 280px; position: relative; height: 26px">
                                                    <asp:Label ID="Label9" Style="z-index: 103; left: 0px; position: absolute; top: 8px"
                                                        runat="server" Width="160px" CssClass="RegionTitleH2"
                                                        BorderColor="#004040">ListView区域特殊属性</asp:Label>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <uc1:wuclistviewregion id="wucListViewRegion1" runat="server">
                                                </uc1:wuclistviewregion></td>
                                        </tr>
                                    </table>
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
            <asp:Label ID="lblViewTile" Style="z-index: 103; left: 8px; position: absolute; top: 8px"
                runat="server" CssClass="h5" Font-Bold="True">界面区域维护</asp:Label>
        <asp:LinkButton ID="btnGoBack" Style="z-index: 109; left: 800px; position: absolute;
            top: 8px" runat="server" Text="返回"  OnClick="btnGoBack_Click">返回</asp:LinkButton>
    </form>
</body>
</html>
