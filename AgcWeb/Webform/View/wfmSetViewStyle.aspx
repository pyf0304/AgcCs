<%@ Register TagPrefix="uc1" TagName="wucViewInfo" Src="wucViewInfo.ascx" %>
<%@ Register TagPrefix="uc1" TagName="wucViewStyle" Src="wucViewStyle.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmSetViewStyle.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmSetViewStyle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表ViewInfo的查询、修改、删除、添加记录</title>
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>

    

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
       <div class="row">
           <div class="col-3">    <asp:Label ID="Label3"      runat="server" Width="280px" CssClass="h5">项目界面管理->设置界面模式</asp:Label></div>
           <div class="col-4">     <asp:Label ID="Label4"   runat="server" Width="464px" Height="32px" CssClass="MemoStyle1">主要用于设置在项目中的界面的相关模式。</asp:Label></div>
       </div>
    
   
        <table id="tabHidden" style="z-index: 106; left: 840px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" border="1" runat="server">
            <tr>
                <td></td>
                <td></td>
                <td style="width: 61px">
                    <asp:Label ID="lblUserIdq" runat="server" >用户ID</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUserIdq" runat="server" Width="49px" ></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblPrjIdq" runat="server">工程ID</asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="112px">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        &nbsp;
    <input id="rd" style="z-index: 109; left: 896px; width: 24px; position: absolute; top: 48px; height: 22px"
        type="hidden" size="1" name="rd" runat="server">

        <input style="display: none; z-index: 110; left: 8px; position: absolute; top: 8px"
            type="radio" checked name="RadioName">

        <table id="Table1" style="z-index: 112; left: 8px; width: 100%; position: absolute; top: 40px"
            cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr>
                <td valign="top">
                    <table id="tabQuery1" bordercolor="#666666" cellspacing="0" cellpadding="0" width="100%"
                        border="1" runat="server" style="width: 100%">
                        <tr>
                            <td colspan="2" style="height: 67px">
                                <table id="tabQuery" style="width: 744px; height: 48px" bordercolor="#666666" cellspacing="0"
                                    cellpadding="0" width="744" border="1">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblViewNameq" runat="server" Width="56px" CssClass="text-secondary">界面名称</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtViewNameq" runat="server" Width="112px"></asp:TextBox>
                                        </td>
                                        <td style="width: 62px">
                                            <asp:Label ID="Label2" runat="server" CssClass="text-secondary">应用类型</asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddlApplicationTypeId" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlApplicationTypeId_SelectedIndexChanged"
                                                Width="167px">
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label1" runat="server" Width="71px" CssClass="auto-style2">功能模块</asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddlFuncModuleIdq" runat="server" Width="104px">
                                            </asp:DropDownList>
                                        </td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblMainTabNameq" runat="server" Width="72px" CssClass="auto-style2">界面表名</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtMainTabNameq" runat="server" Width="112px"></asp:TextBox>
                                        </td>
                                        <td style="width: 62px">
                                            <asp:Label ID="lblViewTypeCodeq" runat="server" Width="83px" CssClass="auto-style2">界面类型码</asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddlViewTypeCodeq" runat="server" Width="165px">
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnQuery" runat="server" Text="查询" OnClick="btnQuery_Click" CssClass="btn btn-outline-warning btn-sm"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblMsg2" runat="server" ForeColor="Red" Width="159px" Height="13px"></asp:Label>
                                        </td>
                                        <td></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <div style="width: 840px; position: relative; height: 34px">
                                    <asp:Button ID="btnSetViewStyle" runat="server" Text="设置界面模式" OnClick="btnSetViewStyle_Click" CssClass="btn btn-outline-info btn-sm ml-4"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:GridView ID="gvViewStyle" runat="server" Width="100%"
                                    AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True"
                                    OnSorting="gvViewStyle_Sorting"
                                    OnPageIndexChanging="gvViewStyle_PageIndexChanging"
                                    OnItemCreated="gvViewStyle_ItemCreated"
                                    OnItemDataBound="gvViewStyle_ItemDataBound"
                                    BackColor="White"
                                    BorderColor="#E7E7FF"
                                    BorderStyle="None"
                                    BorderWidth="1px"
                                    CellPadding="3"
                                    GridLines="Horizontal"
                                    Height="1px"
                                    DataKeyNames="ViewId"
                                    CssClass="table table-striped table-bordered table-condensed">

                                    <Columns>
                                        <asp:TemplateField HeaderText="全选">
                                            <HeaderStyle Width="35px" />
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <a name="A_ViewStyle<%# Eval("ViewId").ToString().Trim() %>"></a>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField Visible="False" DataField="ViewId" HeaderText="界面ID"></asp:BoundField>

                                        <asp:BoundField DataField="ViewName" SortExpression="ViewName" HeaderText="界面名称"></asp:BoundField>
                                        <asp:BoundField DataField="ViewCnName" SortExpression="ViewCnName" HeaderText="中文名称"></asp:BoundField>
                                        <asp:BoundField DataField="ViewTypeName" SortExpression="ViewTypeName" HeaderText="界面类型码"></asp:BoundField>
                                        <asp:BoundField DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="功能模块"></asp:BoundField>
                                        <asp:BoundField Visible="False" DataField="DataBaseName" SortExpression="DataBaseName"
                                            HeaderText="数据库名"></asp:BoundField>
                                        <asp:BoundField DataField="MainTabName" SortExpression="MainTabName" HeaderText="界面主表"></asp:BoundField>
                                        <asp:BoundField DataField="DetailTabName" SortExpression="DetailTabName" HeaderText="明细表名"></asp:BoundField>
                                        <asp:BoundField Visible="False" DataField="KeyForMainTab" SortExpression="KeyForMainTab"
                                            HeaderText="主表关键字"></asp:BoundField>
                                        <asp:BoundField Visible="False" DataField="KeyForDetailTab" SortExpression="KeyForDetailTab"
                                            HeaderText="明细表关键字"></asp:BoundField>
                                        <asp:BoundField Visible="False" DataField="IsNeedSort" HeaderText="排序"></asp:BoundField>
                                        <asp:BoundField Visible="False" DataField="IsNeedTransCode" HeaderText="转换代码"></asp:BoundField>
                                        <asp:BoundField Visible="False" DataField="UserId" HeaderText="用户ID"></asp:BoundField>
                                        <asp:BoundField Visible="False" DataField="PrjName" HeaderText="工程ID"></asp:BoundField>
                                        <asp:BoundField Visible="False" DataField="ViewFunction" HeaderText="界面功能"></asp:BoundField>
                                        <asp:BoundField DataField="DgStyleName" SortExpression="DgStyleName" HeaderText="DG类型"></asp:BoundField>
                                        <asp:BoundField DataField="TitleStyleName" SortExpression="TitleStyleName" HeaderText="标题类型"></asp:BoundField>
                                        <asp:BoundField DataField="UpdDate" HeaderText="修改日期" SortExpression="UpdDate" />

                                    </Columns>
                                    <PagerTemplate>
                                        <span class="text-secondary">共有记录:</span>
                                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="36px">0</asp:Label>
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
                                            <asp:ListItem>20</asp:ListItem>
                                            <asp:ListItem>30</asp:ListItem>
                                            <asp:ListItem>50</asp:ListItem>
                                            <asp:ListItem>100</asp:ListItem>
                                            <asp:ListItem>1000</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                                            ErrorMessage="错误!" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                    </PagerTemplate>
                                    <FooterStyle CssClass="FooterStyle" />
                                    <RowStyle CssClass="RowStyle" />
                                    <EmptyDataRowStyle CssClass="EmptyDataRowStyle" />
                                    <SelectedRowStyle CssClass="SelectedRowStyle" />
                                    <PagerStyle CssClass="PagerStyle" />
                                    <HeaderStyle CssClass="HeaderStyle" />
                                    <EditRowStyle CssClass="EditRowStyle" />
                                    <AlternatingRowStyle CssClass="AlternatingRowStyle" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblRecCount" runat="server" Width="110px" Font-Names="宋体"
                                    Font-Size="Smaller">查询结果记录数：</asp:Label>
                            </td>
                            <td rowspan="1" class="auto-style1">
                                <asp:TextBox ID="txtRecCount" runat="server" Width="111px" Font-Names="宋体" Font-Size="Smaller"
                                    ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td valign="top">
                    <table id="tabLayout" style="width: 100%;" bordercolor="#666666" cellspacing="0"
                        cellpadding="0" border="1" runat="server">
                        <tr>
                            <td valign="top">
                                <asp:Button ID="btnOKUpd" runat="server" Text="确定设置" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                            </td>
                            <td valign="top">

                                <asp:Label ID="lblMsg" runat="server" Width="215px" Height="13px" CssClass="text-warning"></asp:Label>
                            </td>
                            <td valign="top">
                                <asp:LinkButton ID="lbDispViewList" runat="server" OnClick="lbDispViewList_Click">显示界面列表</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top" colspan="3">
                                <uc1:wucViewStyle ID="wucViewStyle1" runat="server"></uc1:wucViewStyle>
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
