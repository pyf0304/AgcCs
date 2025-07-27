<%@ Register TagPrefix="uc1" TagName="wucNewsB" Src="wucNewsB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmNewsB_QUDI.aspx.cs"
    Inherits="CompanyPage.Webform.wfmNewsB_QUDI" ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>资讯表维护</title>
    <%--<link rel="stylesheet" type="text/css" href="../../css/Images/style.css" />--%>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Content/bootstrap-grid.css" rel="stylesheet" />
    <%--    <script type="text/javascript" src="../../Js/jquery-1.3.2.min.js"></script>
    <script type="text/javascript" src="../../Js/cursorfocus.js"></script>--%>
    <script type="text/javascript" language="javascript" src="../../Js/My97DatePicker/WdatePicker.js">

    </script>
    <style type="text/css">
        .style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navigation" id="navigation1" runat="server">
            <span class="back" id="back" runat="server">
                <asp:LinkButton ID="btnCancelNewsEdit" runat="server" OnClick="btnCancelNewsEdit_Click"
                    Text="返回列表"></asp:LinkButton></span>

            <%--   <span class="tool" id="tool" runat="server">
                        <asp:LinkButton ID="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click"
                            runat="server" Text="设置导出字段"></asp:LinkButton></span>--%>

            <%--<span class="export" id="export"
                                runat="server">
                                <asp:LinkButton ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" runat="server"
                                    Text="导出Excel"></asp:LinkButton></span> <span class="edit" id="edit" runat="server">
                                        <asp:LinkButton ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" runat="server" Text="修改记录"></asp:LinkButton></span>
            <span class="delete" id="delete" runat="server">
                <asp:LinkButton ID="btnDelete4Gv" runat="server" OnClick="btnDelete4Gv_Click" Text="删除记录"></asp:LinkButton></span>
            <span class="add" id="add" runat="server">
                <asp:LinkButton ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click"
                    Text="添加记录"></asp:LinkButton></span> --%>
            
            自动生成代码》信息管理
        </div>
        <div class="spClear">
        </div>
        <table id="tabLayout" cellspacing="2" cellpadding="2" width="100%" border="0" runat="server">
            <tr id="trSelect" runat="server">
                <td>
                    <table border="0" cellspacing="0" cellpadding="0" class="table table-bordered table-hover table td" style="width: 70%;">
                        <tr>
                            <td>
                                <asp:Label ID="lblNewsTitleq" Style="z-index: 104;" runat="server" Width="80px"
                                    CssClass="NameLabel">标题</asp:Label>
                            </td>
                            <td class="style1">
                                <asp:TextBox ID="txtNewsTitleq" Style="z-index: 105;" runat="server" Width="200px"
                                    CssClass="form-control">
                                </asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="lblNewsTypeIdq" Style="z-index: 107;" runat="server" Width="80px"
                                    CssClass="NameLabel">类型</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlNewsTypeIdq" Style="z-index: 108;" runat="server" Width="100px"
                                    CssClass="form-control">
                                </asp:DropDownList>
                            </td>
                      
                            <td>
                                <asp:Label ID="lblEditPeopleq" Style="z-index: 110;" runat="server" Width="80px"
                                    CssClass="NameLabel">编辑人员</asp:Label>
                            </td>
                            <td class="style1">
                                <asp:TextBox ID="txtEditPeopleq" Style="z-index: 111;" runat="server" Width="80px"
                                    CssClass="form-control">
                                </asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="lblEditTimeq" Style="z-index: 113;" runat="server" Width="80px" CssClass="NameLabel">编辑时间</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtEditTimeq" Style="z-index: 114;" runat="server" Width="100px"
                                    CssClass="form-control" onfocus="new WdatePicker(this,'%Y-%M-%D',true,'whyGreen')"></asp:TextBox>
                            </td>
                        
                            <td align="right">
                                <asp:Button ID="btnQuery" Style="z-index: 116;" runat="server"
                                    Text="查询" CssClass="btn btn-outline-warning" OnClick="btnQuery_Click"></asp:Button>
                            </td>
                                <td colspan="3">
                                <asp:Label ID="lblMsgList" runat="server" CssClass="ErrMsg"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td><%-- 功能区 --%>

                    <div id="divFunction" class="table table-bordered table-hover">
                        <ul class="nav" style="float: right;">
                            <%--<li class="nav-item">
                                <asp:Label ID="lblcss_TemplateStyleList" CssClass="col-form-label text-info" Width="100%" Text="列表" runat="server" />
                            </li>--%>
                            <li class="nav-item ml-3">
                                <asp:Button ID="btnAddNewRec4Gv" CssClass="btn btn-outline-info" OnClick="btnAddNewRec4Gv_Click" Text="添加" runat="server" />
                            </li>
                            <li class="nav-item ml-3">
                                <asp:Button ID="btnUpdate4Gv" CssClass="btn btn-outline-info" OnClick="btnUpdate4Gv_Click" Text="修改" runat="server" />
                            </li>
                            <li class="nav-item ml-3">
                                <asp:Button ID="btnDelete4Gv" CssClass="btn btn-outline-info" OnClick="btnDelete4Gv_Click" Text="删除" runat="server" />
                            </li>
                        </ul>
                    </div>
                </td>
            </tr>
            <tr id="trShow" runat="server">
                <td>
                    <table id="tabNewsGridView" style="width: 100%" runat="server">

                        <tr>
                            <td>
                                <asp:GridView ID="gvNews" Style="z-index: 117;" runat="server" Width="100%" AutoGenerateColumns="False"
                                    PageSize="10" AllowPaging="true" AllowSorting="true" OnSorting="gvNews_Sorting"
                                    OnPageIndexChanging="gvNews_PageIndexChanging" OnRowCreated="gvNews_RowCreated"
                                    OnRowCommand="gvNews_RowCommand" OnRowDeleting="gvNews_RowDeleting" OnRowUpdating="gvNews_RowUpdating"
                                    BackColor="White" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="None"
                                    Height="1px" DataKeyNames="Id_News" CssClass="table table-bordered table-hover table-striped">
                                    <Columns>
                                        <asp:TemplateField HeaderText="全选">
                                            <HeaderStyle Width="50px" />
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="DgSelAll">全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="NewsTitle" SortExpression="NewsTitle" HeaderText="标题"></asp:BoundField>
                                        <asp:BoundField DataField="NewsTypeName" SortExpression="NewsTypeName" HeaderText="资讯类型"></asp:BoundField>
                                        <asp:BoundField DataField="EditPeople" SortExpression="EditPeople" HeaderText="编辑人"></asp:BoundField>
                                        <asp:BoundField DataField="EditTime" SortExpression="EditTime" HeaderText="编辑时间"></asp:BoundField>
                                        <asp:BoundField DataField="Source" SortExpression="Source" HeaderText="来源"></asp:BoundField>
                                        <asp:BoundField DataField="Views" SortExpression="Views" HeaderText="浏览量"></asp:BoundField>
                                        <asp:TemplateField HeaderText="是否置顶" SortExpression="IsTop">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="ibtnTop" CommandName="ibtnTop" CommandArgument='<%# Eval("Id_News") %>'
                                                    runat="server" ImageUrl='<%# Convert.ToBoolean(Eval("IsTop")) == true ? "../../css/Images/ico-1.png" : "../../css/Images/ico-1_.png"%>'
                                                    ToolTip='<%# Convert.ToBoolean(Eval("IsTop")) == true ? "取消置顶" : "设置置顶"%>' />
                                            </ItemTemplate>
                                        </asp:TemplateField>
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
                                        <span class="text-info col-form-label-sm">共有记录:</span>
                                        <asp:Label ID="lblRecCount" runat="server" CssClass="text-info col-form-label-sm" ForeColor="#000066" Width="36px">0</asp:Label>
                                        <span class="text-info col-form-label-sm">
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                        </span><span class="text-info col-form-label-sm">总页数:</span>
                                        <asp:Label ID="lblAllPages" runat="server" CssClass="text-info col-form-label-sm" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <span class="text-info col-form-label-sm">当前页:</span>
                                        <asp:Label ID="lblCurrentPage" runat="server" CssClass="text-info col-form-label-sm" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnPrevPage" runat="server" CssClass="btn btn-info btn-sm" Text="上一页"
                                            CommandArgument="Prev" CommandName="PrevPage" /><span style="font-family: Verdana">
                                            </span>
                                        <asp:Button ID="btnNextPage" runat="server" CssClass="btn btn-info btn-sm" Text="下一页"
                                            CommandArgument="Next" CommandName="NextPage" />
                                        <span class="text-info col-form-label-sm">到第</span>
                                        <asp:TextBox ID="txtJump2Page" runat="server" CssClass="form-control-sm" Width="35px"></asp:TextBox>
                                        <span class="text-info col-form-label-sm">页</span>
                                        <asp:Button ID="btnJumpPage" runat="server" CssClass="btn btn-info btn-sm" OnClick="btnJumpPage_Click"
                                            Text="确定" CommandName="Page" />
                                        <span class="text-info col-form-label-sm">页记录数:</span>
                                        <asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="btn btn-outline-info btn-sm"
                                            Width="70px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
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
                                            ErrorMessage="错误!" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                    </PagerTemplate>
                                    <FooterStyle CssClass="" />
                                    <RowStyle CssClass="" />
                                    <EmptyDataRowStyle CssClass="" />
                                    <SelectedRowStyle CssClass="" />
                                    <PagerStyle CssClass=" alert-dark text-right" />
                                    <HeaderStyle CssClass=" alert-dark text-left " />
                                    <EditRowStyle CssClass="" />
                                    <AlternatingRowStyle CssClass="" />
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr id="trEdit" runat="server">
                <td style="width: 100%;">
                    <uc1:wucNewsB ID="wucNewsB1" runat="server" />
                    <div style="text-align: center;">
                        <asp:Button ID="btnOKUpd" runat="server" Text="添加" OnClick="btnOKUpd_Click"
                            CssClass="btn btn-outline-info"></asp:Button>
                        &nbsp;
                    <input name="重置" type="reset" class="btn btn-outline-info" value="重置" />
                    </div>
                    <div style="margin-top: 10px; text-align: center;">
                        <asp:Label ID="lblMsgEdit" Style="z-index: 105;" runat="server" Height="16px" CssClass="ErrMsg"></asp:Label>
                    </div>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
