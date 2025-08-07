<%@ Page Language="c#" CodeBehind="wfmViewGroupFlds_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmViewGroupFlds_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucViewGroupFlds" Src="wucViewGroupFlds.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表ViewGroupFlds的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <table id="tabTitle" style="z-index: 101; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Bold="True" ForeColor="White" Font-Names="宋体"
                        Font-Size="Small">界面组字段维护</asp:Label></td>
            </tr>
        </table>
        <div id="divViewGroupFlds" style="z-index: 102; left: 8px; width: 864px; position: absolute; top: 35px; height: 25px"
            runat="server">
            <asp:Label ID="lblViewGroupId_q" Style="z-index: 100; left: 8px; position: absolute; top: 0px"
                runat="server"
                Width="70px">
  界面组ID</asp:Label>
            <asp:Label ID="lblCtlTypeId_q" Style="z-index: 101; left: 272px; position: absolute; top: 5px"
                runat="server"
                Width="70px">
  控件类型号</asp:Label>
            <asp:DropDownList ID="ddlCtlTypeId_q" Style="z-index: 102; left: 344px; position: absolute; top: 2px"
                runat="server" Width="70px">
            </asp:DropDownList>
            <asp:Button ID="btnQuery" Style="z-index: 103; left: 424px; position: absolute; top: 0px"
                runat="server"  
                Text="查询"></asp:Button>
            <asp:Label ID="lblViewGroupName" Style="z-index: 105; left: 80px; position: absolute; top: 0px"
                runat="server"
                Width="70px"></asp:Label>
        </div>
        <table id="Table1" style="z-index: 105; left: 8px; position: absolute; top: 72px"
            cellspacing="0" cellpadding="0" width="300" border="0">
            <tr>
                <td>
                    <table id="tabViewInfo" style="width: 848px" bordercolor="#666666" cellspacing="1"
                        cellpadding="1" width="848" border="2" runat="server">
                        <tr>
                            <td colspan="2">
                                <div style="width: 828px; position: relative; height: 24px">
                                    <asp:Button ID="btnEditViewField" Style="z-index: 100; left: 512px; position: absolute; top: 0px"
                                        runat="server"  Width="88px" Text="编辑界面字段"></asp:Button>
                                    <asp:Button ID="btnDelete" Style="z-index: 103; left: 456px; position: absolute; top: 0px"
                                        runat="server"   Text="删除"></asp:Button>
                                    <asp:Button ID="btnUpdate" Style="z-index: 104; left: 392px; position: absolute; top: 0px"
                                        runat="server"   Text="修改" OnClick="btnOKUpd_Click"></asp:Button>
                                    <asp:Button ID="btnAddRelaJspView" Style="z-index: 105; left: 248px; position: absolute; top: 0px"
                                        runat="server"  Width="112px" Text="添加相关Jsp界面" OnClick="btnAddRelaJspView_Click"></asp:Button>
                                    <asp:Button ID="btnDesignView" Style="z-index: 107; left: 600px; position: absolute; top: 0px"
                                        runat="server"  Width="72px" Text="设计界面"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <div id="divJspRelaView" style="width: 841px; position: relative; height: 184px"
                                    runat="server">
                                    <asp:Button ID="btnStartGene" Style="z-index: 101; left: 584px; position: absolute; top: 152px"
                                        runat="server"   Text="开始生成" OnClick="btnStartGene_Click"></asp:Button>
                                    <table id="Table2" style="z-index: 102; left: 8px; width: 520px; position: absolute; top: 8px; height: 168px"
                                        cellspacing="0" cellpadding="0" width="520" border="0">
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#004040"
                                                    Width="56px" BorderColor="#004040">界面类型</asp:Label></td>
                                            <td></td>
                                            <td>
                                                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#004040"
                                                    Width="46px" BorderColor="#004040">文件名</asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="chkJsp_Add" runat="server"
                                                    Text="添加JSP界面" AutoPostBack="True" OnCheckedChanged="chkJsp_Add_CheckedChanged"></asp:CheckBox></td>
                                            <td></td>
                                            <td>
                                                <asp:TextBox ID="txtFileName_Add" runat="server"
                                                    Width="320px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="chkJsp_Update" runat="server"
                                                    Text="修改JSP界面" AutoPostBack="True" OnCheckedChanged="chkJsp_Update_CheckedChanged"></asp:CheckBox></td>
                                            <td></td>
                                            <td>
                                                <asp:TextBox ID="txtFileName_Update" runat="server"
                                                    Width="320px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="chkJsp_Query" runat="server"
                                                    Text="查询JSP界面" AutoPostBack="True" OnCheckedChanged="chkJsp_Query_CheckedChanged"></asp:CheckBox></td>
                                            <td></td>
                                            <td>
                                                <asp:TextBox ID="txtFileName_Query" runat="server"
                                                    Width="320px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="chkJsp_Detail" runat="server"
                                                    Text="详细信息JSP界面" AutoPostBack="True" OnCheckedChanged="chkJsp_Detail_CheckedChanged"></asp:CheckBox></td>
                                            <td></td>
                                            <td>
                                                <asp:TextBox ID="txtFileName_Detail" runat="server"
                                                    Width="320px"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:CheckBox ID="chkJsp_List" runat="server"
                                                    Text="列表JSP界面" AutoPostBack="True" OnCheckedChanged="chkJsp_List_CheckedChanged"></asp:CheckBox></td>
                                            <td></td>
                                            <td>
                                                <asp:TextBox ID="txtFileName_List" runat="server"
                                                    Width="320px"></asp:TextBox></td>
                                        </tr>
                                    </table>
                                    <asp:Button ID="btnCloseDiv" Style="z-index: 103; left: 760px; position: absolute; top: 8px"
                                        runat="server" Text="关闭"></asp:Button>
                                    <asp:Label ID="lblMsg2" Style="z-index: 105; left: 544px; position: absolute; top: 56px"
                                        runat="server" Width="283px" CssClass="text-warning"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:DataGrid ID="dgViewInfo" runat="server" Font-Names="宋体" Font-Size="Smaller"
                                    Height="270px" Width="840px" GridLines="Vertical" CellPadding="0" BackColor="White"
                                    BorderWidth="1px" BorderStyle="Ridge" BorderColor="White" AutoGenerateColumns="False"
                                    AllowSorting="True" CellSpacing="1">
                                    <FooterStyle HorizontalAlign="Left" ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
                                    <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
                                    <Columns>
                                        <asp:BoundColumn Visible="False" DataField="ViewId" HeaderText="界面ID"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="ApplicationTypeName" SortExpression="ApplicationTypeName"
                                            HeaderText="应用程序类型"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="ViewGroupName" SortExpression="ViewGroupName"
                                            HeaderText="界面组"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewName" SortExpression="ViewName" HeaderText="界面名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewCnName" SortExpression="ViewCnName" HeaderText="中文名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewTypeName" SortExpression="ViewTypeName" HeaderText="界面类型码"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="功能模块"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="MainTabName" SortExpression="MainTabName" HeaderText="界面主表"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="DetailTabName" SortExpression="DetailTabName" HeaderText="明细表名"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="KeyForMainTab" HeaderText="主表关键字"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="KeyForDetailTab" HeaderText="明细表关键字"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="ViewFunction" HeaderText="界面功能"></asp:BoundColumn>
                                        <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete2" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <PagerStyle NextPageText="&amp;lt;下一页&amp;gt;" PrevPageText="&amp;lt;上一页&amp;gt;"
                                        HorizontalAlign="Left" ForeColor="Black" BackColor="#C6C3C6"></PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabViewGroupFldsDataGrid" style="width: 552px" cellspacing="0"
                        cellpadding="0" width="552" border="0" runat="server">
                        <tr>
                            <td>
                                <div style="width: 800px; position: relative; height: 24px">
                                    <asp:Button ID="btnAddNewRec4Dg1" Style="z-index: 102; left: 50px; position: absolute; top: 0px"
                                        runat="server"   Text="添加" OnClick="btnAddNewRec4Dg_Click"></asp:Button>
                                    <asp:Button ID="btnDelete4Dg" Style="z-index: 100; left: 135px; position: absolute; top: 0px"
                                        runat="server"   Text="删除" OnClick="btnDelete4Dg_Click"></asp:Button>
                                    <asp:Button ID="btnUpdate4Dg" Style="z-index: 101; left: 220px; position: absolute; top: 0px"
                                        runat="server"   Text="修改" OnClick="btnUpdate4Dg_Click"></asp:Button>
                                    <asp:Button ID="btnExportExcel4Dg" Style="z-index: 103; left: 656px; position: absolute; top: 0px"
                                        runat="server"   Text="导出Excel"></asp:Button>
                                    <asp:Button ID="btnGoBack" Style="z-index: 105; left: 744px; position: absolute; top: 0px"
                                        runat="server"   Text="返回"></asp:Button>
                                    <asp:Button ID="btnCopyFldFromRelaTab" Style="z-index: 106; left: 344px; position: absolute; top: 0px"
                                        runat="server" Width="160px" Text="从区域相关表中复制字段" OnClick="btnCopyFldFromRelaTab_Click"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgViewGroupFlds" runat="server"
                                    Width="832px" GridLines="Horizontal" CellPadding="3" BackColor="White" BorderWidth="1px"
                                    BorderStyle="None" BorderColor="#E7E7FF" AutoGenerateColumns="False" AllowPaging="True"
                                    AllowSorting="True" OnItemCommand="dgViewGroupFlds_ItemCommand" OnItemCreated="dgViewGroupFlds_ItemCreated" OnPageIndexChanged="dgViewGroupFlds_PageIndexChanged" OnSortCommand="dgViewGroupFlds_SortCommand">
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
                                        <asp:BoundColumn Visible="False" DataField="mId" SortExpression="mId" HeaderText="mId"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="SeqNum" SortExpression="SeqNum" HeaderText="字段序号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="CtlTypeName" SortExpression="CtlTypeName" HeaderText="控件类型"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Ds_TabName" SortExpression="Ds_TabName" HeaderText="数据源表"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Ds_DataTextFieldName" SortExpression="Ds_DataTextFieldName"
                                            HeaderText="文本字段"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Ds_DataValueFieldName" SortExpression="Ds_DataValueFieldName"
                                            HeaderText="值字段"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Ds_SQLStr" SortExpression="Ds_SQLStr" HeaderText="数据源SQL串"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ItemsString" SortExpression="ItemsString" HeaderText="列表项串"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="DdlItemsOptionName" SortExpression="DdlItemsOptionName"
                                            HeaderText="下拉框列表选项"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Ds_CondStr" SortExpression="Ds_CondStr" HeaderText="数据源条件串"></asp:BoundColumn>
                                        <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td style="width: 605px" bgcolor="silver">
                                <table id="tabViewGroupFldsJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                                    cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                    <tr>
                                        <td>
                                            <font style="background-color: #c0c0c0">共有记录:</font>
                                                <asp:Label ID="lblViewGroupFldsRecCount" runat="server" ForeColor="#000066" Width="46px">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">总页数:</font>
                                                <asp:Label ID="lblViewGroupFldsAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">当前页:
                                                        <asp:Label ID="lblViewGroupFldsCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <asp:Button ID="btnViewGroupFldsPrevPage" runat="server"
                                                        Width="50px" Text="上一页"></asp:Button><asp:Button ID="btnViewGroupFldsNextPage" runat="server"
                                                            Width="50px" Text="下一页"></asp:Button>到第
                                                        <asp:TextBox ID="txtViewGroupFldsJump2Page" runat="server"
                                                            Width="35px"></asp:TextBox>页
                                                        <asp:Button ID="btnViewGroupFldsJumpPage" runat="server"
                                                            Width="35px" Text="确定"></asp:Button><asp:CompareValidator ID="ViewGroupFldsCompareValidator1"
                                                                runat="server" ForeColor="DarkOrange" ErrorMessage="错误！" ControlToValidate="txtViewGroupFldsJump2Page"
                                                                Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditViewGroupFldsRegion" style="width: 373px; height: 200px" cellspacing="1"
                        cellpadding="1" width="373" border="1">
                        <tr>
                            <td>
                                <div style="width: 575px; position: relative; left: 0px; top: 0px;">
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                                        runat="server"  
                                        Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                    <asp:Label ID="lblMsg" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                                        runat="server" Width="458px" CssClass="text-warning"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucViewGroupFlds ID="wucViewGroupFlds1" runat="server"></uc1:wucViewGroupFlds>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
        </table>

    </form>
</body>
</html>
