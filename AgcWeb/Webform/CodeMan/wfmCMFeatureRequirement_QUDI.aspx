<%@ Register TagPrefix="uc1" TagName="wucCMFeatureRequirement" Src="wucCMFeatureRequirement.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvCMFeatureRequirement4Gv" Src="wucvCMFeatureRequirement4Gv.ascx" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>
<%@ Register TagPrefix="uc2" TagName="wucvCMRequirement4Gv" Src="wucvCMRequirement4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmCMFeatureRequirement_QUDI.aspx.cs" Inherits="AGC.Webform.wfmCMFeatureRequirement_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>CM功能需求关系维护的维护</title>
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
    <script src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">CM功能需求关系维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabQuery" style="width: 70%;" class="table table-bordered table-hover table td table-sm">
                    <tr>
                        <td>
                            <asp:Label ID="lblCmPrjIdq" CssClass="form-control-sm text-right" Width="90px" Text="CM工程" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlCmPrjIdq" CssClass="form-control-sm" Width="200px" runat="server" OnSelectedIndexChanged="ddlCmPrjId_q_SelectedIndexChanged" AutoPostBack="true" />
                        </td>
                        <td>
                            <asp:Label ID="lblCmFeatureIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="功能Id" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlCmFeatureIdq" CssClass="form-control-sm" AutoPostBack="true" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblReqIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="需求Id" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlReqIdq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                            <td>
                            <asp:Label ID="lblFuncModuleAgcIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="模块" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFuncModuleAgcIdq" CssClass="form-control-sm" Width="200px" runat="server" />
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
                        <asp:Label ID="lblCMFeatureRequirementList" CssClass="col-form-label text-info" Width="250px" Text="CM功能需求关系列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnAddNewRecord_Click" Text="批量添加需求" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnUpdateRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:Button ID="btnGoTop" CssClass="btn btn-outline-info text-nowrap" OnClick="btnGoTop_Click" Text="移顶" runat="server" />
                            <asp:Button ID="btnUpMove" CssClass="btn btn-outline-info text-nowrap" OnClick="btnUpMove_Click" Text="上移" runat="server" />
                            <asp:Button ID="btnDownMove" CssClass="btn btn-outline-info text-nowrap" OnClick="btnDownMove_Click" Text="下移" runat="server" />
                            <asp:Button ID="btnGoBottum" CssClass="btn btn-outline-info text-nowrap" OnClick="btnGoBottum_Click" Text="移底" runat="server" />
                            <asp:Button ID="btnReOrder" CssClass="btn btn-outline-info text-nowrap" OnClick="btnReOrder_Click" Text="重序" runat="server" />
                        </div>
                    </li>
                </ul>
            </div>
            <div>
                <div id="divTree" class="float-left" style="width: 20%">
                    <div>
                        <%--  <ul class="nav">
                            <li class="nav-item">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="lblPrjIdq" name="lblPrjIdq" CssClass="form-control-sm text-right" Text="工程" runat="server" />
                                    <asp:DropDownList ID="ddlPrjIdq" name="ddlPrjIdq" CssClass="form-control-sm" Width="150px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged" />
                                </div>
                            </li>
                        </ul>--%>
                        <ul class="nav">

                            <li class="nav-item">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="lblUserIdq" name="lblUserIdq" CssClass="form-control-sm text-right" Text="用户" runat="server" />
                                    <asp:DropDownList ID="ddlUserIdq" name="ddlUserIdq" CssClass="form-control-sm" Width="70px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged" />
                                </div>
                            </li>

                            <li class="nav-item ml-1">
                                <asp:Button ID="btnRefresh"
                                    Style="z-index: 119; width: 50px;"
                                    runat="server"
                                    Text="刷新" CssClass="btn btn-outline-warning btn-sm"
                                    OnClick="btnRefresh_Click"></asp:Button>
                            </li>
                            <li class="nav-item ml-1">
                                <%--<asp:Button ID="btnAddCmClass" runat="server" OnClick="btnAddCmClass_Click"
                                    CssClass="btn btn-outline-info btn-sm" Text="添加类"></asp:Button>--%>
                            </li>
                        </ul>
                    </div>
                    <br />
                    <uc1:wucTreeView runat="server" ID="wucTreeView1" OnafterSelect_Tz="wucTreeView1_afterSelect_Tz" />
                </div>
                <div id="divMain" class="float-right" style="width: 80%">

                    <%-- 列表层 --%>
                    <div id="divList" class="div_List mt-2" style="width: 100%; min-height: 100px;" runat="server">
                        <div style="text-align: left">
                            <div class="float-left">
                                <asp:Label ID="lblLstTitle4CMFeatureRequirement" Style="z-index: 104;" Width="350px" runat="server"
                                    CssClass="h6 text-primary">功能需求关系列表</asp:Label>
                            </div>
                            <div class="float-right">
                                <asp:Button ID="btnDispCMFeatureRequirementLst" Style="z-index: 106;" runat="server"
                                    Text="隐藏功能需求关系列表" OnClick="btnDispCMFeatureRequirementLst_Click" CssClass="btn btn-outline-info"></asp:Button>
                            </div>
                        </div>
                        <div>
                            <uc2:wucvCMFeatureRequirement4Gv runat="server" ID="wucvCMFeatureRequirement4Gv1"
                                OnGvUpdateClick="wucvCMFeatureRequirement4Gv1_GvUpdateClick"
                                OnGvDeleteClick="wucvCMFeatureRequirement4Gv1_GvDeleteClick" />
                        </div>
                    </div>
                              <hr />
                    <div class="div_List mt-2">
                        <div style="text-align: left">
                            <div class="float-left">
                                <asp:Label ID="lblTitle4CMRequirementLst" Style="z-index: 104;" Width="200px" runat="server"
                                    CssClass="h6 text-primary">供选择的需求列表如下:</asp:Label>
                            </div>
                            <div class="float-right">
                                <asp:Button ID="btnOKUpd2" Style="z-index: 106;" runat="server"
                                    Text="添加" OnClick="btnOKUpd2_Click" CssClass="btn btn-outline-info"></asp:Button>
                            </div>
                        </div>
                        <div>
                            <uc2:wucvCMRequirement4Gv runat="server" ID="wucvCMRequirement4Gv1" />
                        </div>
                    </div>
                </div>
            </div>

            <%-- 编辑层 --%>
            <div id="tabEditCMFeatureRequirementRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditCMFeatureRequirement" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">CM功能需求关系编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelCMFeatureRequirementEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelCMFeatureRequirementEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:wucCMFeatureRequirement ID="wucCMFeatureRequirement1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
