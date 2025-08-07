<%@ Register TagPrefix="uc1" TagName="wucReferFilesB" Src="wucReferFilesB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvReferFiles4Gv" Src="wucvReferFiles4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true" CodeBehind="wfmReferFilesB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmReferFilesB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>引用文件维护的维护</title>
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
</head>
<body>
    <form id="form1" runat="server" class="form-horizontal">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">引用文件维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabQuery" style="width: 70%;" class="table table-bordered table-hover table td">
                    <tr>
                        <td>
                            <asp:Label ID="lblFileNameq" CssClass="col-form-label text-right" Width="90px" Text="文件名" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtFileNameq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblVersionq" CssClass="col-form-label text-right" Width="90px" Text="版本" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtVersionq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblFilePathq" CssClass="col-form-label text-right" Width="90px" Text="文件路径" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtFilePathq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblUpdUserIdq" CssClass="col-form-label text-right" Width="90px" Text="修改用户Id" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtUpdUserIdq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:CheckBox ID="chkIsNeedDownLoadq" CssClass="form-control" Width="200px" Text="是否需要下载" runat="server"></asp:CheckBox>
                        </td>
                        <td>
                            <asp:Button ID="btnQuery"  CssClass="btn btn-outline-warning" OnClick="btnQuery_Click" Text="查询" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel" CssClass="btn btn-outline-warning" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="table table-bordered table-hover">
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblReferFilesList" CssClass="col-form-label text-info" Width="250px" Text="引用文件列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecord" CssClass="btn btn-outline-info" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnCopyRecord" CssClass="btn btn-outline-info" OnClick="btnCopyRecord_Click" Text="复制记录" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnUpdateRecord" CssClass="btn btn-outline-info" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:Button ID="btnGoTop" CssClass="btn btn-outline-info" OnClick="btnGoTop_Click" Text="移顶" runat="server" />
                            <asp:Button ID="btnUpMove" CssClass="btn btn-outline-info" OnClick="btnUpMove_Click" Text="上移" runat="server" />
                            <asp:Button ID="btnDownMove" CssClass="btn btn-outline-info" OnClick="btnDownMove_Click" Text="下移" runat="server" />
                            <asp:Button ID="btnGoBottum" CssClass="btn btn-outline-info" OnClick="btnGoBottum_Click" Text="移底" runat="server" />
                            <asp:Button ID="btnReOrder" CssClass="btn btn-outline-info" OnClick="btnReOrder_Click" Text="重序" runat="server" />
                        </div>
                    </li>
                    <li class="nav-item ml-3">
                        <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:Button ID="btnSetInUse" CssClass="btn btn-outline-info" OnClick="btnSetInUse_Click" Text="设置是否在用" runat="server" />
                            <asp:Button ID="btnSetNotInUse" CssClass="btn btn-outline-info" OnClick="btnSetNotInUse_Click" Text="设置是否在用" runat="server" />
                        </div>
                    </li>
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:wucvReferFiles4Gv runat="server" ID="wucvReferFiles4Gv1"
                    OnGvUpdateClick="wucvReferFiles4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvReferFiles4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditReferFilesRegion" class="tab_Edit mt-2"
                runat="server">
                <div>
                    <table style="width: 60%;" class="table table-bordered table-hover">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditReferFiles"  runat="server"
                                    CssClass="col-form-label text-info">引用文件编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit" runat="server"
                                    Width="208px" CssClass="col-form-label text-danger"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                    Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>

                                <asp:Button ID="btnCancelReferFilesEdit"
                                    runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelReferFilesEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucReferFilesB ID="wucReferFilesB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
