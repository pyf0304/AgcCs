<%@ Register TagPrefix="uc1" TagName="wucPrjFeatureB" Src="wucPrjFeatureB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvPrjFeature4Gv" Src="wucvPrjFeature4Gv.ascx" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmPrjFeatureB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmPrjFeatureB_QUDI" ValidateRequest="false" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>功能维护的维护</title>
        <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
    <script src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
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
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>
                        <td>
                            <asp:Label ID="Label1"
                                runat="server" CssClass="text-secondary">应用类型</asp:Label>
                        </td>
                        <td class="ValueTD">
                            <asp:DropDownList ID="ddlApplicationTypeIdq" runat="server" class="form-control-sm"></asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblFeatureIdq"
                                runat="server" CssClass="text-secondary">功能Id</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFeatureIdq"
                                runat="server" CssClass="form-control-sm">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblFeatureNameq"
                                runat="server" CssClass="text-secondary">功能名称</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFeatureNameq"
                                runat="server" CssClass="form-control-sm">
                            </asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblFunctionGroupIdq" Style="z-index: 116;"
                                runat="server" CssClass="text-secondary">函数组</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFunctionGroupIdq" Style="z-index: 117;"
                                runat="server" CssClass="form-control-sm">
                            </asp:DropDownList>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblFeatureTypeIdq"
                                runat="server" CssClass="text-secondary">功能类型</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFeatureTypeIdq"
                                runat="server" CssClass="form-control-sm">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblCreateUserIdq"
                                runat="server" CssClass="text-secondary">建立用户Id</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCreateUserIdq"
                                runat="server" CssClass="form-control-sm">
                            </asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblKeyWordsq" Style="z-index: 122;"
                                runat="server" CssClass="text-secondary">关键字</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtKeyWordsq" Style="z-index: 123;"
                                runat="server" CssClass="form-control-sm" Width="245px"></asp:TextBox>
                        </td>
                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 116; width: 80px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                    </tr>

                </table>
            </div>
            <%-- 列表层 --%>

            <div id="divFunction" runat="server">
                <div id="tabGridFunction" style="width: 100%; height: 32px" class="msgtable">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblPrjFeatureList" runat="server"
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
                                <asp:DropDownList ID="ddlRegionTypeId" CssClass="form-control-sm" Width="100px" runat="server" />
                                <asp:Button ID="btnSetRegionTypeId" OnClick="btnSetRegionTypeId_Click" runat="server"
                                    CssClass="btn btn-outline-info btn-sm" Text="设置区域类型"></asp:Button>
                            </div>
                        </li>
                        <li class="nav-item ml-2">
                            <asp:Button ID="btnSetIsNeedField" OnClick="btnSetIsNeedField_Click" runat="server"
                                Width="100px" CssClass="btn btn-outline-info btn-sm" Text="设置需要字段"></asp:Button>
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


            </div>
            <%-- 列表层 --%>
            <div class="row" style="width: 100%;">
                <div class="col-2">                 
                    <uc1:wucTreeView runat="server" ID="wucTreeView1" OnafterSelect_Tz="wucTreeView1_afterSelect_Tz" />
                </div>

                <div class="col-10">
                    <%-- 列表层 --%>
                    <div id="divList" class="div_List mt-2" runat="server">
                        <uc2:wucvPrjFeature4Gv runat="server" ID="wucvPrjFeature4Gv1"
                            OnGvUpdateClick="wucvPrjFeature4Gv1_GvUpdateClick"
                            OnGvDeleteClick="wucvPrjFeature4Gv1_GvDeleteClick" />
                    </div>
                    <%-- 编辑层 --%>
                    <div id="tabEditPrjFeatureRegion" class="tab_Edit"
                        runat="server">
                        <div>
                            <table style="width: 60%;" class="msgtable">
                                <tr>
                                    <th style="text-align: left">
                                        <asp:Label ID="lblEditPrjFeature" runat="server"
                                            CssClass="h6">功能编辑区域</asp:Label>
                                        <asp:Label ID="lblMsgEdit" runat="server"
                                            Width="208px" CssClass="text-warning"></asp:Label>
                                    </th>
                                    <th style="text-align: right">
                                        <asp:Button ID="btnOKUpd" runat="server"
                                            Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>

                                        <asp:Button ID="btnCancelPrjFeatureEdit"
                                            runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelPrjFeatureEdit_Click"></asp:Button>
                                    </th>
                                </tr>
                            </table>
                        </div>
                        <div>
                            <uc1:wucPrjFeatureB ID="wucPrjFeatureB1" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
