<%@ Register TagPrefix="uc1" TagName="wucFeatureRegionB" Src="wucFeatureRegionB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmFeatureRegionB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmFeatureRegionB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>功能区域信息维护的维护</title>
    
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
    <form id="form1" runat="server">
        <table id="tabLayout" style="z-index: 105; left: 0px; position: absolute; top: 0px" cellspacing="2"
            cellpadding="2" width="100%" border="0" runat="server">
            <tr>
                <td>

                    <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >功能区域信息维护
                        </asp:Label>
                        <asp:Label ID="lblMsg_List" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                            Width="347px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>

                    <table>
                        <tr>

                            <td>
                                <asp:Label ID="lblRegionId_q" 
                                    runat="server" Width="90px" CssClass="text-secondary">区域Id</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtRegionId_q" 
                                    runat="server" Width="100px"  CssClass="TextBox_Defa">
                                </asp:TextBox>
                            </td>

                            <td>
                                <asp:Label ID="lblButtonStyleId_q" 
                                    runat="server" Width="90px" CssClass="text-secondary">按钮样式Id</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlButtonStyleId_q" 
                                    runat="server" Width="100px"  CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>

                                <asp:Button ID="btnQuery"
                                    
                                    runat="server"
                                     
                                    Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                    OnClick="btnQuery_Click"></asp:Button>
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

                    <table id="tabFeatureRegionGridView" style="width: 100%"
                        runat="server">
                        <tr>
                            <td>
                                <table style="width: 100%; height: 32px" id="tabGridFunction">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblFeatureRegionList" runat="server" 
                                                CssClass="h6" Width="250px">功能区域信息列表</asp:Label>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" 
                                                 CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click"  runat="server"
                                                 CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click"  runat="server"
                                                 CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" 
                                                runat="server"  CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="gvFeatureRegion"  runat="server"
                                    Width="100%" AutoGenerateColumns="False"
                                    PageSize="10" AllowPaging="true"
                                    AllowSorting="true"
                                    OnSorting="gvFeatureRegion_Sorting"
                                    OnPageIndexChanging="gvFeatureRegion_PageIndexChanging"
                                    OnRowCreated="gvFeatureRegion_RowCreated"
                                    OnRowCommand="gvFeatureRegion_RowCommand"
                                    OnRowDeleting="gvFeatureRegion_RowDeleting"
                                    OnRowUpdating="gvFeatureRegion_RowUpdating"
                                    BackColor="White"
                                    BorderColor="#E7E7FF"
                                    BorderStyle="None"
                                    BorderWidth="1px"
                                    CellPadding="3"
                                    GridLines="Horizontal"
                                    Height="1px"
                                    DataKeyNames="RegionId"
                                    CssClass="table table-striped table-bordered table-condensed">
                                    <Columns>
                                        <asp:TemplateField HeaderText="全选">
                                            <HeaderStyle Width="35px" />
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="RegionId" SortExpression="RegionId" HeaderText="区域Id"></asp:BoundField>
                                        <asp:BoundField DataField="RegionName" SortExpression="RegionName" HeaderText="区域名称"></asp:BoundField>
                                        <asp:BoundField DataField="RegionTypeId" SortExpression="RegionTypeId" HeaderText="区域类型Id"></asp:BoundField>
                                        <asp:BoundField DataField="RegionTypeName" SortExpression="RegionTypeName" HeaderText="区域类型名称"></asp:BoundField>
                                        <asp:BoundField DataField="ButtonStyleId" SortExpression="ButtonStyleId" HeaderText="按钮样式Id"></asp:BoundField>
                                        <asp:BoundField DataField="ButtonStyleName" SortExpression="ButtonStyleName" HeaderText="ButtonStyleName"></asp:BoundField>
                                        <asp:BoundField DataField="ViewId" SortExpression="ViewId" HeaderText="界面ID"></asp:BoundField>
                                        <asp:BoundField DataField="ViewName" SortExpression="ViewName" HeaderText="界面名称"></asp:BoundField>
                                        <asp:BoundField DataField="ViewCnName" SortExpression="ViewCnName" HeaderText="视图中文名"></asp:BoundField>
                                        <asp:BoundField DataField="RegionFunction" SortExpression="RegionFunction" HeaderText="区域功能"></asp:BoundField>
                                        <asp:BoundField DataField="CssClass" SortExpression="CssClass" HeaderText="样式表"></asp:BoundField>
                                        <asp:BoundField DataField="Style_Top" SortExpression="Style_Top" HeaderText="Style_Top"></asp:BoundField>
                                        <asp:BoundField DataField="Style_Position" SortExpression="Style_Position" HeaderText="Style_Position"></asp:BoundField>
                                        <asp:BoundField DataField="Style_Left" SortExpression="Style_Left" HeaderText="Style_Left"></asp:BoundField>
                                        <asp:BoundField DataField="Style_Zindex" SortExpression="Style_Zindex" HeaderText="Style_Zindex"></asp:BoundField>
                                        <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="修改"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <PagerTemplate>
                                        <span class="text-secondary">共有记录:</span>
                                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="46px">0</asp:Label>
                                        <span style="background-color: #c0c0c0">
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                        </span><span class="text-secondary">总页数:</span>
                                        <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <span class="text-secondary">当前页:</span>
                                        <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnPrevPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" Text="上一页"
                                            CommandArgument="Prev" CommandName="Page" /><span style="font-family: Verdana">
                                            </span>
                                        <asp:Button ID="btnNextPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" Text="下一页"
                                            CommandArgument="Next" CommandName="Page" />
                                        到第
                                        <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
                                        <asp:Button ID="btnJumpPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" OnClick="btnJumpPage_Click"
                                            Text="确定" Width="45px" CommandName="Page" />
                                        <span class="text-secondary">页记录数:</span>
                                        <asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="DropDown_DefaInPager"
                                            Width="55px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
<asp:ListItem>15</asp:ListItem>
                                            <asp:ListItem>20</asp:ListItem>
                                            <asp:ListItem>30</asp:ListItem>
                                            <asp:ListItem>50</asp:ListItem>
                                            <asp:ListItem>100</asp:ListItem>
                                            <asp:ListItem>1000</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                                            ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                    </PagerTemplate>
                                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <AlternatingRowStyle BackColor="#F7F7F7" />
                                </asp:GridView>
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
                    <table id="tabEditFeatureRegionRegion" style="z-index: 111; width: 100%"
                        cellspacing="1" cellpadding="1" width="100%" border="1" runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="lblEditFeatureRegion"  runat="server"
                                    CssClass="h6">功能区域信息编辑区域</asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblMsg_Edit"  runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </td>
                            <td>
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnCancelFeatureRegionEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelFeatureRegionEdit_Click"></asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <uc1:wucFeatureRegionB ID="wucFeatureRegionB1" runat="server" />
                            </td>
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
