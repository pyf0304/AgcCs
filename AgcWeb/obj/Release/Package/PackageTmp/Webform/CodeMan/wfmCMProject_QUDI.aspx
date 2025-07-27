<%@ Register TagPrefix="uc1" TagName="wucCMProject" Src="wucCMProject.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvCMProject4Gv" Src="wucvCMProject4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmCMProject_QUDI.aspx.cs" Inherits="AGC.Webform.wfmCMProject_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>CM项目维护的维护</title>
    <link href="../../tzMenuWuc/cssMenu1.css" rel="stylesheet" />
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
    <form id="form1" runat="server" class="form-horizontal">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">CM项目维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabQuery" name="tabQuery" style="width: 70%;" class="table table-bordered table-hover table td table-sm">
                    <tr>
                        <td>
                            <asp:Label ID="lblCmPrjIdq" name="lblCmPrjIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="工程ID" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtCmPrjIdq" name="txtCmPrjIdq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblCmPrjNameq" name="lblCmPrjNameq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="CM工程名" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtCmPrjNameq" name="txtCmPrjNameq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblPrjIdq" name="lblPrjIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="工程" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPrjIdq" name="ddlPrjIdq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblApplicationTypeIdq" name="lblApplicationTypeIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="应用" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlApplicationTypeIdq" name="ddlApplicationTypeIdq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                    
                        <td>
                            <asp:Button ID="btnQuery" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnQuery_Click" Text="查询" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="table table-bordered table-hover">
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblCMProjectList" name="lblCMProjectList" CssClass="col-form-label text-info" Width="250px" Text="CM项目列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
<asp:Button id="btnCopyRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnCopyRecord_Click" Text="复制记录" runat="server" />
</li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnUpdateRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                    </li>
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:wucvCMProject4Gv runat="server" id="wucvCMProject4Gv1"
                    OnGvUpdateClick="wucvCMProject4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvCMProject4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditCMProjectRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditCMProject" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">CM项目编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelCMProjectEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelCMProjectEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:wucCMProject id="wucCMProject1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
