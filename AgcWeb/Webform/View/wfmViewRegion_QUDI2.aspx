<%@ Register TagPrefix="uc1" TagName="wucViewRegion" Src="wucViewRegion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="wucDispViewTab" Src="wucDispViewTab.ascx" %>

<%@ Page Title="界面区域维护" Language="c#" MasterPageFile="~/Webform/MasterPage/mpViewEdit.Master" CodeBehind="wfmViewRegion_QUDI2.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmViewRegion_QUDI2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

    <div id="Table1" style="width: 100%;">
        <div>
            <asp:Label ID="lblErrMsg"
                runat="server" Width="252px" CssClass="text-warning"></asp:Label>
        </div>
        <div>

            <div id="tabViewRegionDataGrid" style="width: 100%" runat="server">

                <div>
                    <table>
                        <tr>
                            <td>
                                <asp:Button ID="btnAddNewRec4Dg1" Style="z-index: 103;" runat="server" Text="添加新区域" CssClass="btn btn-outline-info btn-sm"
                                    OnClick="btnAddNewRec4Dg_Click"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnAddRelaJspView" runat="server" Text="添加相关界面区域" CssClass="btn btn-outline-info btn-sm" OnClick="btnAddRelaJspView_Click"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnUpdate4Dg" runat="server"
                                    Text="修改" CssClass="btn btn-outline-info btn-sm" OnClick="btnUpdate4Dg_Click"></asp:Button>
                            </td>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="btnDelete4Dg" runat="server" Text="删除区域" CssClass="btn btn-outline-info btn-sm" OnClick="btnDelete4Dg_Click"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnSetInUse" runat="server"
                                    Text="启用" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetInUse_Click"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnSetNotInUse" runat="server"
                                    Text="不用" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetNotInUse_Click"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnPreView" runat="server" Text="预览" CssClass="btn btn-outline-info btn-sm"
                                    OnClick="btnPreView_Click"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnSetClassName" runat="server" Text="自动设置类名" CssClass="btn btn-outline-info btn-sm"
                                    OnClick="btnSetClassName_Click"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnSetClassName4AllView" runat="server" Text="为所有界面设置类名" CssClass="btn btn-outline-info btn-sm"
                                    OnClick="btnSetClassName4AllView_Click" Visible="False"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnExportExcel4Dg" runat="server"
                                    Text="导出Excel" CssClass="btn btn-outline-warning btn-sm" OnClick="btnExportExcel4Dg_Click"></asp:Button>

                            </td>
                        </tr>
                    </table>
                </div>



                <div id="divViewRelaRegion" style="width: 90%; position: relative; height: 310px"
                    runat="server">
                    <asp:Button ID="btnStartGene" Style="z-index: 101; left: 544px; position: absolute; top: 32px"
                        runat="server" Text="开始生成" CssClass="btn btn-outline-info btn-sm"
                        OnClick="btnStartGene_Click" ToolTip="生成界面区域，生成后编辑界面属性，同时生成界面代码"></asp:Button>
                    <table id="Table5" style="z-index: 102; left: 8px; width: 520px; position: absolute; top: 32px; height: 188px" border="0">
                        <tr>
                            <td class="NameTD">
                                <asp:Label ID="Label3" runat="server" Width="64px" BorderColor="#004040">区域类型</asp:Label>
                            </td>
                            <td></td>
                            <td class="NameTd">
                                <asp:Label ID="Label2" runat="server" BorderColor="#004040"
                                    CssClass="RegionTitleH3">区域名称</asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:CheckBox ID="chkCopyReferFilesTemplate" runat="server" Text="复制界面引用文件"
                                    CssClass="Check_Defa"></asp:CheckBox>
                            </td>
                            <td></td>
                        </tr>

                        <tr>
                            <td>
                                <asp:CheckBox ID="chkQueryRegion" runat="server" Text="查询区域" AutoPostBack="True"
                                    CssClass="Check_Defa" OnCheckedChanged="chkQueryRegion_CheckedChanged"></asp:CheckBox>
                            </td>
                            <td></td>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox ID="txtFileName_QueryRegion" runat="server" Width="320px"></asp:TextBox>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="chkQueryRegion" EventName="CheckedChanged" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr id="trDGRegion" runat="server">
                            <td>
                                <asp:CheckBox ID="chkDGRegion" runat="server" Text="列表区域" AutoPostBack="True" CssClass="Check_Defa"
                                    OnCheckedChanged="chkDGRegion_CheckedChanged"></asp:CheckBox>
                            </td>
                            <td></td>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox ID="txtFileName_DGRegion" runat="server" Width="320px"></asp:TextBox>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="chkDGRegion" EventName="CheckedChanged" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </td>
                        </tr>

                        <tr>
                            <td>
                                <asp:CheckBox ID="chkEditRegion" runat="server" Text="编辑区域" AutoPostBack="True" CssClass="Check_Defa"
                                    OnCheckedChanged="chkEditRegion_CheckedChanged"></asp:CheckBox>
                            </td>
                            <td></td>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox ID="txtFileName_EditRegion" runat="server" Width="320px"></asp:TextBox>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="chkEditRegion" EventName="CheckedChanged" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="chkExcelExportRegion" runat="server" Text="Excel导出区域" AutoPostBack="True"
                                    CssClass="Check_Defa" OnCheckedChanged="chkExcelExportRegion_CheckedChanged"></asp:CheckBox>
                            </td>
                            <td></td>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox ID="txtFileName_ExcelExportRegion" runat="server" Width="320px"></asp:TextBox>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="chkExcelExportRegion" EventName="CheckedChanged" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:CheckBox ID="chkFeatureRegion" runat="server" Text="功能区域" AutoPostBack="True"
                                    CssClass="Check_Defa" OnCheckedChanged="chkFeatureRegion_CheckedChanged"></asp:CheckBox>
                            </td>
                            <td></td>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox ID="txtFileName_FeatureRegion" runat="server" Width="320px"></asp:TextBox>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="chkFeatureRegion" EventName="CheckedChanged" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr id="trDetailRegion" runat="server">
                            <td>
                                <asp:CheckBox ID="chkDetailRegion" runat="server" Text="详细信息区域" AutoPostBack="True"
                                    CssClass="Check_Defa" OnCheckedChanged="chkDetailRegion_CheckedChanged"></asp:CheckBox>
                            </td>
                            <td></td>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox ID="txtFileName_DetailRegion" runat="server" Width="320px"></asp:TextBox>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="chkDetailRegion" EventName="CheckedChanged" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr id="trTreeViewRegion" runat="server">
                            <td>
                                <asp:CheckBox ID="chkTreeViewRegion" runat="server" Text="树区域" AutoPostBack="True"
                                    CssClass="Check_Defa" OnCheckedChanged="chkTreeViewRegion_CheckedChanged"></asp:CheckBox>
                            </td>
                            <td></td>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox ID="txtFileName_TreeViewRegion" runat="server" Width="320px"></asp:TextBox>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="chkTreeViewRegion" EventName="CheckedChanged" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="btnCloseDiv" Style="z-index: 103; left: 633px; position: absolute; top: 32px; right: 168px;"
                        runat="server" Text="取消" CssClass="btn btn-outline-info btn-sm"
                        OnClick="btnCloseDiv_Click"></asp:Button>
                    <asp:Label ID="lblMsg2" Style="z-index: 104; left: 544px; position: absolute; top: 64px"
                        runat="server" Width="200px" CssClass="text-warning"></asp:Label>
                    <asp:Label ID="Label1" Style="z-index: 105; left: 8px; position: absolute; top: 8px"
                        runat="server" Font-Names="幼圆" Width="139px" CssClass="h6"
                        BorderColor="#004040" Font-Bold="True" ForeColor="DarkGray">添加相关界面区域</asp:Label>
                    <div style="z-index: 100; left: 152px; width: 584px; color: Yellow; position: absolute; top: 8px; height: 26px"
                        class="MemoStyle1">
                        在当前界面中添加相关区域，同时添加该区域的相关字段列表。
                    </div>
                    <img style="z-index: 106; left: 0px; width: 832px; position: absolute; top: 0px; height: 4px"
                        height="4" alt="" src="../../pic/兰色直线1.gif" width="832" />
                    <asp:Button ID="btnEditViewRegion" Style="z-index: 101; left: 684px; position: absolute; top: 32px"
                        runat="server" Text="编辑界面区域属性" Width="130px" CssClass="btn btn-outline-info btn-sm"
                        OnClick="btnEditViewRegion_Click" ToolTip="编辑界面各区域属性，并且生成界面代码。"></asp:Button>
                </div>

                <div>
                    <asp:DataGrid ID="dgViewRegion" runat="server" Width="100%" BorderColor="#E7E7FF"
                        GridLines="Horizontal" CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="None"
                        AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True" CssClass="table table-striped table-bordered table-condensed"
                        OnItemCommand="dgViewRegion_ItemCommand" OnItemCreated="dgViewRegion_ItemCreated"
                        OnPageIndexChanged="dgViewRegion_PageIndexChanged" OnSortCommand="dgViewRegion_SortCommand" DataKeyField="RegionId">
                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                        <Columns>
                            <asp:TemplateColumn HeaderText="选择">
                                <HeaderStyle ForeColor="White" Width="30px"></HeaderStyle>
                                <HeaderTemplate>
                                    <asp:LinkButton ID="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap text-white" CommandName="lbSelAll">全选</asp:LinkButton>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="RegionId" SortExpression="RegionId" HeaderText="区域Id"></asp:BoundColumn>
                            <asp:BoundColumn DataField="RegionName" SortExpression="RegionName" HeaderText="区域名称"></asp:BoundColumn>
                            <asp:BoundColumn DataField="RegionTypeName" SortExpression="RegionTypeName" HeaderText="区域类型"></asp:BoundColumn>
                            <asp:BoundColumn DataField="ClassName" SortExpression="ClassName" HeaderText="类名"></asp:BoundColumn>
                            <%--<asp:BoundColumn DataField="RegionFunction" SortExpression="RegionFunction" HeaderText="区域功能" Visible="false"></asp:BoundColumn>--%>
                            <asp:BoundColumn DataField="InOutTypeName" SortExpression="InOutTypeName" HeaderText="InOut类型"></asp:BoundColumn>
                            <asp:BoundColumn DataField="TabName" SortExpression="TabName" HeaderText="数据表"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Height" SortExpression="Height" HeaderText="高度"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Width" SortExpression="Width" HeaderText="宽"></asp:BoundColumn>
                            <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
                    </asp:DataGrid>
                </div>

                <div style="width: 80%; background-color: Silver">
                    <table id="tabViewRegionJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                        cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
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
                                <asp:Button ID="btnViewRegionPrevPage" runat="server" Text="上一页" Width="50px"></asp:Button><asp:Button ID="btnViewRegionNextPage" runat="server" Text="下一页"
                                    Width="50px"></asp:Button>到第
                                        <asp:TextBox ID="txtViewRegionJump2Page" runat="server" Width="35px"></asp:TextBox>页
                                        <asp:Button ID="btnViewRegionJumpPage" runat="server" Text="确定" Width="35px"></asp:Button><asp:CompareValidator ID="ViewRegionCompareValidator1" runat="server"
                                            ForeColor="DarkOrange" ErrorMessage="错误！" ControlToValidate="txtViewRegionJump2Page"
                                            Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator>
                            </td>
                        </tr>
                    </table>
                </div>

            </div>
        </div>
        <div>

            <div id="tabEditViewRegionRegion" style="width: 824px; height: 303px" cellspacing="0"
                cellpadding="0" border="0" runat="server">

                <div style="width: 832px; position: relative; height: 32px">
                    <asp:Button ID="btnOKUpd" Style="z-index: 101; left: 624px; position: absolute; top: 8px"
                        runat="server" Text="添加" Width="121px" OnClick="btnOKUpd_Click"></asp:Button>
                    <asp:Label ID="lblMsg" Style="z-index: 100; left: 440px; position: absolute; top: 8px"
                        runat="server" Width="176px" CssClass="text-warning"></asp:Label>
                    <asp:Label ID="Label4" Style="z-index: 103; left: 0px; position: absolute; top: 8px"
                        runat="server" Width="128px" CssClass="h6" BorderColor="#004040">编辑区域属性</asp:Label>
                    <img style="z-index: 104; left: 0px; width: 832px; position: absolute; top: 0px; height: 4px"
                        height="4" alt="" src="../../pic/兰色直线1.gif" width="832" />
                    <asp:Button ID="btnClear" Style="z-index: 105; left: 752px; position: absolute; top: 8px"
                        runat="server" Text="取消" Width="64px" OnClick="btnClear_Click"></asp:Button>
                </div>



                <div id="tabViewRegion" cellspacing="0" cellpadding="0" width="300" border="0" runat="server">

                    <div style="width: 280px; position: relative; height: 25px">
                        <asp:Label ID="Label5" Style="z-index: 103; left: 0px; position: absolute; top: 8px"
                            runat="server" Width="128px" CssClass="RegionTitleH2" BorderColor="#004040">区域一般属性</asp:Label>
                    </div>
                    <div>
                        <uc1:wucViewRegion ID="wucViewRegion1" runat="server"></uc1:wucViewRegion>
                    </div>

                </div>

            </div>

        </div>
    </div>
</asp:Content>
