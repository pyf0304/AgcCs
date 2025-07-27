<%@ Register TagPrefix="uc1" TagName="ViewRegion" Src="ViewRegion.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvViewRegion4Gv" Src="wucvViewRegion4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true" CodeBehind="wfmViewRegion_QUDI.aspx.cs" Inherits="AGC.Webform.wfmViewRegion_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>界面区域维护的维护</title>
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
</head>
<body>
    <form id="form1" runat="server" class="form-horizontal">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">界面区域维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabEdit" style="width: 70%" class="table table-bordered table-hover table td table-sm">
                    <tr>
                        <td class="text-left">
                            <asp:Label ID="lblRegionIdq" name="lblRegionIdq" CssClass="col-form-label text-right" Width="90px" Text="区域Id" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:TextBox ID="txtRegionIdq" name="txtRegionIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblRegionNameq" name="lblRegionNameq" CssClass="col-form-label text-right" Width="90px" Text="区域名称" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:TextBox ID="txtRegionNameq" name="txtRegionNameq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblRegionTypeIdq" name="lblRegionTypeIdq" CssClass="col-form-label text-right" Width="90px" Text="区域类型Id" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlRegionTypeIdq" name="ddlRegionTypeIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblContainerTypeIdq" name="lblContainerTypeIdq" CssClass="col-form-label text-right" Width="90px" Text="容器类型Id" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlContainerTypeIdq" name="ddlContainerTypeIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="text-left">
                            <asp:Label ID="lblPageDispModeIdq" name="lblPageDispModeIdq" CssClass="col-form-label text-right" Width="90px" Text="页面显示模式Id" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlPageDispModeIdq" name="ddlPageDispModeIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblInSqlDsTypeIdq" name="lblInSqlDsTypeIdq" CssClass="col-form-label text-right" Width="90px" Text="输入数据源类型" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlInSqlDsTypeIdq" name="ddlInSqlDsTypeIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblInRelaTabIdq" name="lblInRelaTabIdq" CssClass="col-form-label text-right" Width="90px" Text="In/Out类型" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlINOutTypeIdq" name="ddlInRelaTabIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            &nbsp;</td>
                        <td class="text-left">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="text-left">
                            <asp:Label ID="lblTabIdq" name="lblOutRelaTabIdq" CssClass="col-form-label text-right" Width="90px" Text="数据源表" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlTabIdq" name="ddlOutRelaTabIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Button ID="btnQuery" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnQuery_Click" Text="查询" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Button ID="btnExportExcel" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="table table-bordered table-hover">
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblViewRegionList" name="lblViewRegionList" CssClass="col-form-label text-info" Width="250px" Text="界面区域列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecordWithMaxId" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnAddNewRecordWithMaxId_Click" Text="添加-关键字自增" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnUpdateRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnSetTabId" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnSetTabId_Click" Text="设置数据表" runat="server" />
                    </li>
                      <li class="nav-item ml-3">
                        <asp:Button ID="btnSetDefaRegionName" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnSetDefaRegionName_Click" Text="设置默认区域名" runat="server" />
                    </li>
                       <li class="nav-item ml-3">
                        <asp:Button ID="btnSetFldCount" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetFldCount_Click" Text="设置字段数" runat="server" />
                    </li>
                          <li class="nav-item ml-3">
                        <asp:Button ID="btnSetFldCountInUse" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnSetFldCountInUse_Click" Text="设置可用字段数" runat="server" />
                    </li>
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:wucvViewRegion4Gv runat="server" ID="wucvViewRegion4Gv1"
                    OnGvUpdateClick="wucvViewRegion4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvViewRegion4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditViewRegionRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditViewRegion" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">界面区域编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelViewRegionEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelViewRegionEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:ViewRegion ID="ViewRegion1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
