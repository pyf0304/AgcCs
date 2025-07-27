<%@ Register TagPrefix="uc1" TagName="PrjTab_Edit" Src="PrjTab_Edit.ascx" %>
<%@ Register TagPrefix="uc2" TagName="PrjTab4Gv" Src="PrjTab4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true" CodeBehind="PrjTab_QUDI.aspx.cs" Inherits="AGC.Webform.PrjTab_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>工程表-维护的维护</title>
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">工程表-维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabEdit" style="width: 70%" class="table table-bordered table-hover table td table-sm">
                    <tr>
                        <td class="text-left">
                            <asp:Label ID="lblTabNameq" name="lblTabNameq" CssClass="col-form-label text-right" Width="90px" Text="表名" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:TextBox ID="txtTabNameq" name="txtTabNameq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblTabIdq" name="lblTabIdq" CssClass="col-form-label text-right" Width="90px" Text="表ID" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:TextBox ID="txtTabIdq" name="txtTabIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblSqlDsTypeIdq" name="lblSqlDsTypeIdq" CssClass="col-form-label text-right" Width="90px" Text="数据源类型" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlSqlDsTypeIdq" name="ddlSqlDsTypeIdq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblTabStateIdq" name="lblTabStateIdq" CssClass="col-form-label text-right" Width="90px" Text="表状态ID" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlTabStateIdq" name="ddlTabStateIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="text-left">
                            <asp:Label ID="lblFuncModuleAgcIdq" name="lblFuncModuleAgcIdq" CssClass="col-form-label text-right" Width="90px" Text="功能模块Id" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlFuncModuleAgcIdq" name="ddlFuncModuleAgcIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblTabTypeIdq" name="lblTabTypeIdq" CssClass="col-form-label text-right" Width="90px" Text="表类型Id" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlTabTypeIdq" name="ddlTabTypeIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblTabMainTypeIdq" name="lblTabMainTypeIdq" CssClass="col-form-label text-right" Width="90px" Text="表主类型Id" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlTabMainTypeIdq" name="ddlTabMainTypeIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Button ID="btnQuery" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnQuery_Click" Text="查询" runat="server" />
                        </td>
                    </tr>
                    <tr>
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
                        <asp:Label ID="lblPrjTabList" name="lblPrjTabList" CssClass="col-form-label text-info" Width="250px" Text="工程表列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnUpdateRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:DropDownList ID="ddlCacheModeId_SetFldValue" name="ddlCacheModeId_SetFldValue" class="form-control" Width="60px" runat="server" />
                            <asp:Button ID="btnSetCacheModeId" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnSetCacheModeId_Click" Text="设置缓存方式Id" runat="server" />
                        </div>
                    </li>
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:PrjTab4Gv runat="server" ID="PrjTab4Gv1"
                    OnGvUpdateClick="PrjTab4Gv1_GvUpdateClick"
                    OnGvDeleteClick="PrjTab4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditPrjTabRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditPrjTab" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">工程表编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelPrjTabEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelPrjTabEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:PrjTab_Edit ID="PrjTab_Edit1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
