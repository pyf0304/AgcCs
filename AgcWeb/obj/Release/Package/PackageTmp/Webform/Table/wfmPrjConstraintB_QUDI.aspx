<%@ Register TagPrefix="uc1" TagName="wucPrjConstraintB" Src="wucPrjConstraintB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvConstraintFields4Gv" Src="wucvConstraintFields4Gv.ascx" %>
<%@ Register Src="~/Webform/Table/wucConstraintFields4DL.ascx" TagPrefix="uc1" TagName="wucConstraintFields4DL" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmPrjConstraintB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmPrjConstraintB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>约束表维护的维护</title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <%--    --%>
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5">约束表维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
           
                <div id="trHidden" class="row" runat="server">

                    <div class="btn-group col-3" role="group" aria-label="Basic example">
                        <asp:Label ID="lblTabIdq" CssClass="text-secondary" Width="90px" Text="表ID" runat="server" />


                        <asp:DropDownList ID="ddlTabIdq" Width="200px" runat="server" />
                    </div>

                    <div class="btn-group col-3" role="group" aria-label="Basic example">
                        <asp:Label ID="lblTabNameq" CssClass="text-secondary" Width="90px" Text="表名" runat="server" />
                        <asp:TextBox ID="txtTabNameq" Width="200px" runat="server" />

                    </div>
                </div>
            </div>

            <%-- 功能区 --%>

            <div id="divFunction" class="div_Funttion" runat="server">
                <ul class="nav">

                    <li class="nav-item">
                        <asp:Label ID="lblPrjConstraintList" CssClass="h6" Width="325px" Text="" runat="server" />
                    </li>

                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecord" CssClass="btn btn-outline-info btn-sm" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnUpdateRecord" CssClass="btn btn-outline-info btn-sm" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnSetInUse" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetInUse_Click" Text="设置在用" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnSetNotInUse" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetNotInUse_Click" Text="设置不用" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info btn-sm" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnExportExcel" CssClass="btn btn-outline-info btn-sm" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                    </li>

                </ul>
            </div>

            <div style="width: 100%" class="mt-2">
                <div style="width: 20%; float: left">
                    <div>
                        <asp:Label ID="Label1" runat="server" CssClass="h7" Text="约束类型->约束名"></asp:Label>
                        <asp:Button ID="btnRefreshTv" runat="server" CssClass="btn btn-outline-warning btn-sm" Text="刷新" OnClick="btnRefreshTv_Click" />
                    </div>
                    <div>
                        <uc1:wucTreeView runat="server" ID="wucTreeView4Constraint" OnafterSelect_Tz="wucTreeView4Constraint_afterSelect_Tz" />
                    </div>
                </div>
                <%-- 列表层 --%>
                <div style="width: 80%; float: right;">
                    <div id="divList" class="div_List" runat="server">
                        <asp:Label ID="lblListTitle" runat="server" CssClass="h6" Text="约束字段列表"></asp:Label><br />
                        <uc2:wucvConstraintFields4Gv runat="server" ID="wucvConstraintFields4Gv1"
                            OnGvUpdateClick="wucvConstraintFields4Gv1_GvUpdateClick"
                            OnGvDeleteClick="wucvConstraintFields4Gv1_GvDeleteClick" />
                    </div>


                    <%-- 编辑层 --%>
                    <div id="tabEditPrjConstraintRegion" class="tab_Edit" runat="server">
                        <div>
                            <ul class="nav">
                                <li class="nav-item">

                                    <asp:Label ID="lblEditPrjConstraint" runat="server" Width="250px"
                                        CssClass="h6">约束表编辑区域</asp:Label>
                                </li>

                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnOKUpd" runat="server"
                                        Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                </li>
                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnCancelPrjConstraintEdit"
                                        runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelPrjConstraintEdit_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-3">
                                    <asp:Label ID="lblMsgEdit" runat="server"
                                        Width="208px" CssClass="text-warning"></asp:Label>
                                </li>
                            </ul>
                        </div>
                        <div>
                            <uc1:wucConstraintFields4DL runat="server" ID="wucConstraintFields4DL1" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
