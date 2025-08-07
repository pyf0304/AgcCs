<%@ Register TagPrefix="uc1" TagName="wucCMFeature" Src="wucCMFeature.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvCMFeature4Gv" Src="wucvCMFeature4Gv.ascx" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>
<%@ Register Src="~/Webform/CodeMan/wucvCMFeature4DL.ascx" TagPrefix="uc1" TagName="wucvCMFeature4DL" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmCMFeature_Disp.aspx.cs" Inherits="AGC.Webform.wfmCMFeature_Disp" ValidateRequest="false" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>功能维护的维护</title>
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
    <script src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5">功能维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
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

                    <%-- 查询层 --%>

                    <div id="divQuery" class="div_query">
                        <table class="msgtable" style="width: 80%">
                            <tr>
                                <%-- <td>
                                    <asp:Label ID="Label1" Width="90px"
                                        runat="server" CssClass="form-control-sm text-right">应用类型</asp:Label>
                                </td>
                                <td class="ValueTD">
                                    <asp:DropDownList ID="ddlApplicationTypeIdq" Width="200px" runat="server" class="form-control-sm"></asp:DropDownList>
                                </td>--%>
                                <%-- <td>
                                    <asp:Label ID="lblCmFeatureIdq" Width="90px"
                                        runat="server" CssClass="form-control-sm text-right">功能Id</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtCmFeatureIdq"
                                        runat="server" CssClass="form-control-sm">
                                    </asp:TextBox>
                                </td>--%>
                                <td>
                                    <asp:Label ID="lblCmPrjIdq" CssClass="form-control-sm text-right" Width="90px" Text="CM工程" runat="server" />
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlCmPrjIdq" CssClass="form-control-sm" Width="100px" runat="server" />
                                </td>

                                <td>
                                    <asp:Label ID="lblFeatureNameq" Width="90px"
                                        runat="server" CssClass="form-control-sm text-right">名称</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtFeatureNameq" Width="145px"
                                        runat="server" CssClass="form-control-sm">
                                    </asp:TextBox>
                                </td>

                                <%--<td>
                                    <asp:Label ID="lblCmFeatureTypeIdq" Width="90px"
                                        runat="server" CssClass="form-control-sm text-right">类型</asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlCmFeatureTypeIdq"
                                        runat="server" CssClass="form-control-sm">
                                    </asp:DropDownList>
                                </td>--%>
                                <%--                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                --%>
                                <td>
                                    <asp:Label ID="lblCreateUserIdq" Width="90px"
                                        runat="server" CssClass="form-control-sm text-right">建立用户</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtCreateUserIdq" Width="60px"
                                        runat="server" CssClass="form-control-sm">
                                    </asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="lblKeyWordsq" Width="90px"
                                        runat="server" CssClass="form-control-sm text-right">关键字</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtKeyWordsq" Style="z-index: 123;"
                                        runat="server" CssClass="form-control-sm" Width="145px"></asp:TextBox>
                                </td>
                                <td>

                                    <asp:Button ID="btnQuery"
                                        Style="z-index: 116; width: 80px;"
                                        runat="server"
                                        Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                        OnClick="btnQuery_Click"></asp:Button>
                                </td>
                                <td>
                                    <asp:CheckBox ID="chkIsList" Checked="false" Width="100px" Text="按列表方式" runat="server" />
                                </td>
                            </tr>

                        </table>
                    </div>
                    <%-- 列表层 --%>

                    <div id="divList" class="div_List mt-2"
                        runat="server">
                        <div id="tabGridFunction" style="width: 100%; height: 32px" class="msgtable">
                            <ul class="nav">
                                <li class="nav-item">
                                    <asp:Label ID="lblCMFeatureList" runat="server"
                                        CssClass="h6" Width="250px">功能列表</asp:Label>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click"
                                        CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnCloneNewRec4Gv" runat="server" OnClick="btnCloneNewRec4Gv_Click"
                                        Width="44px" CssClass="btn btn-outline-info btn-sm" Text="克隆"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" runat="server"
                                        CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" runat="server"
                                        CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <div class="btn-group" role="group" aria-label="Basic example">
                                        <asp:DropDownList ID="ddlCmFeatureTypeId" CssClass="form-control-sm" Width="100px" runat="server" />
                                        <asp:Button ID="btnSetFeatureTypeId" OnClick="btnSetFeatureTypeId_Click" runat="server"
                                            CssClass="btn btn-outline-info btn-sm" Text="设置功能类型"></asp:Button>
                                    </div>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnSetInUse" OnClick="btnSetInUse_Click" runat="server"
                                        Width="100px" CssClass="btn btn-outline-info btn-sm" Text="设置是否使用"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <div class="btn-group" role="group" aria-label="Basic example">
                                        <asp:Button ID="btnGoTop" runat="server" Text="移顶" CssClass="btn btn-outline-info btn-sm" OnClick="btnGoTop_Click" />
                                        <asp:Button ID="btnUpMove" runat="server" Text="上移" OnClick="btnUpMove_Click" CssClass="btn btn-outline-info btn-sm ml-1" />
                                        <asp:Button ID="btnDownMove" runat="server" Text="下移" OnClick="btnDownMove_Click" CssClass="btn btn-outline-info btn-sm ml-1" />
                                        <asp:Button ID="btnGoBottum" runat="server" CssClass="btn btn-outline-info btn-sm ml-1" Text="移底" OnClick="btnGoBottum_Click" />
                                        <asp:Button ID="btnReOrder" runat="server" Text="重序" OnClick="btnReOrder_Click" CssClass="btn btn-outline-info btn-sm ml-1" />
                                    </div>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click"
                                        runat="server" CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                                </li>
                            </ul>
                        </div>

                        <%-- 列表层 --%>
                        <div id="div1" class="div_List mt-2" runat="server">
                            <uc2:wucvCMFeature4Gv runat="server" ID="wucvCMFeature4Gv1"
                                OnGvUpdateClick="wucvCMFeature4Gv1_GvUpdateClick"
                                OnGvDeleteClick="wucvCMFeature4Gv1_GvDeleteClick" />
                            <uc1:wucvCMFeature4DL runat="server" ID="wucvCMFeature4DL1"
                                OnDlEditParaClick="wucvCMFeature4DL1_DlEditParaClick"
                                OnDlCloneClick="wucvCMFeature4DL1_DlCloneClick"
                                OnDlUpdateClick="wucvCMFeature4DL1_DlUpdateClick"
                                OnDlDeleteClick="wucvCMFeature4DL1_DlDeleteClick" />
                        </div>
                    </div>

                    <%-- 编辑层 --%>
                    <div id="tabEditCMFeatureRegion" class="tab_Edit"
                        runat="server">
                        <div>
                            <ul class="nav">
                                <li class="nav-item">
                                    <asp:Label ID="lblEditCMFeature" runat="server" Width="250px"
                                        CssClass="h6">功能编辑区域</asp:Label>
                                </li>

                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnOKUpd" runat="server"
                                        Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                </li>
                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnCancelCMFeatureEdit"
                                        runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelCMFeatureEdit_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-3">
                                    <asp:Label ID="lblMsgEdit" runat="server"
                                        Width="208px" CssClass="text-warning"></asp:Label>
                                </li>
                            </ul>
                        </div>
                        <div>
                            <uc1:wucCMFeature ID="wucCMFeature1" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
