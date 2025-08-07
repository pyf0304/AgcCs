<%@ Register TagPrefix="uc1" TagName="wucTabFeatureFldsB" Src="wucTabFeatureFldsB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvTabFeatureFlds4Gv" Src="wucvTabFeatureFlds4Gv.ascx" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>

<%@ Page Language="c#" AutoEventWireup="true" CodeBehind="wfmTabFeatureFldsB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmTabFeatureFldsB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>表功能字段维护的维护</title>
    <link href="../../Content/bootstrap.css" rel="stylesheet" />    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />      
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
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

            <%--<div style="position: relative; width: 648px; height: 10px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" Visible="false" >表功能字段维护
                </asp:Label>
               
            </div>--%>



            <%-- 列表层 --%>
            <div class="row mt-2" style="width: 100%">
                <div class="col-3">
                    <div class="row">
                        <div class="col-5">
                            <div class="btn-group " role="group" aria-label="Basic example">
                                <asp:Label ID="lblFeatureIdq" runat="server" CssClass="NameLabel text-nowrap" Text="功能" />
                                <asp:DropDownList ID="ddlFeatureIdq" runat="server" CssClass="ml-2" />
                            </div>
                        </div>
                        <div class="col-2 ml-2" >
                            <asp:Button ID="btnAddTabFeature" CssClass="btn btn-info btn-sm" OnClick="btnAddTabFeature_Click" Text="添加表功能" runat="server" />
                        </div>
                    </div>
                    <div class="row mt-2">
                        <div class="col-5">
                            <uc1:wucTreeView runat="server" ID="wucTreeView4TabFeature" OnafterSelect_Tz="wucTreeView4TabFeature_afterSelect_Tz" />
                        </div>
                        <div class="col-2 ml-2">
                            <div class="btn-group " role="group" aria-label="Basic example">
                                <asp:Button ID="btnRefreshTv" runat="server" class="btn btn-outline-warning btn-sm" Text="刷新" OnClick="btnRefreshTv_Click" />
                                <asp:Button ID="btnDeleteTabFeature" runat="server" class="btn btn-outline-warning btn-sm" Text="删除" OnClick="btnDeleteTabFeature_Click" />
                            </div>
                        </div>
                    </div>
                </div>
                <div id="div1" class="col-6" runat="server">
                    <div id="tabQuery" style="width: 100%;" class="msgtable">
                        <ul class="nav">


                            <li class="nav-item">
                                <div class="btn-group float-right" role="group" aria-label="Basic example">
                                    <asp:Label ID="lblFldIdq" CssClass="text-secondary" Text="字段" runat="server" />

                                    <asp:DropDownList ID="ddlFldIdq" Width="100px" runat="server" CssClass="ml-2" />
                                </div>
                            </li>
                            <li class="nav-item ml-3">
                                <div class="btn-group float-right" role="group" aria-label="Basic example">
                                    <asp:Label ID="lblFieldTypeIdq" CssClass="text-secondary" Text="字段类型" runat="server" />

                                    <asp:DropDownList ID="ddlFieldTypeIdq" Width="100px"  runat="server" CssClass="ml-2" />
                                </div>
                            </li>
                            <li class="nav-item ml-3">
                                <div class="btn-group float-right" role="group" aria-label="Basic example">
                                    <asp:Label ID="lblInUseq" CssClass="text-secondary"  Text="在用?" runat="server" />

                                    <asp:DropDownList ID="ddlInUseq" Width="50px" runat="server" CssClass="ml-2" />
                                </div>

                            </li>
                            <li class="nav-item ml-3">
                                <asp:Button ID="btnQuery" CssClass="btn btn-outline-info btn-sm" OnClick="btnQuery_Click" Text="查询" runat="server" />
                            </li>
                             <li class="nav-item ml-3">
                                 <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"                  Width="347px"></asp:Label>
                            </li>
                        </ul>
                        <%-- <tr id="trHidden" runat="server">
                        <td>
                            <asp:Label ID="lblTabIdq" CssClass="text-secondary" Width="90px" Text="表ID" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTabIdq" Width="200px"  runat="server" />
                        </td>
                    </tr>--%>
                    </div>
                    <div id="divFunction" class="div_Funttion" runat="server">

                        <div class="float-left">
                            <h6>
                                <asp:Label ID="lblTabFeatureFldsList" Text="表功能字段列表" runat="server" /></h6>
                        </div>
                        <div class="btn-group float-right" role="group" aria-label="Basic example">
                            <asp:Button ID="btnAddNewRecord"  CssClass="btn btn-outline-secondary btn-sm" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                            <asp:Button ID="btnCopyRecord"  CssClass="btn btn-outline-secondary btn-sm" OnClick="btnCopyRecord_Click" Text="复制记录" runat="server" />
                            <asp:Button ID="btnUpdateRecord"  CssClass="btn btn-outline-secondary btn-sm" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                            <asp:Button ID="btnDelRecord"  CssClass="btn btn-outline-secondary btn-sm" OnClick="btnDelRecord_Click" Text="删除" runat="server" />

                            <asp:Button ID="btnExportExcel"  CssClass="btn btn-outline-secondary btn-sm" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                        </div>

                    </div>
                    <div id="divList" class="div_List" style="width: 100%;" runat="server">
                        <uc2:wucvTabFeatureFlds4Gv runat="server" ID="wucvTabFeatureFlds4Gv1"
                            OnGvUpdateClick="wucvTabFeatureFlds4Gv1_GvUpdateClick"
                            OnGvDeleteClick="wucvTabFeatureFlds4Gv1_GvDeleteClick" />
                    </div>

                    <%-- 编辑层 --%>
                    <div id="tabEditTabFeatureFldsRegion" class="tab_Edit"
                        runat="server">
                        <div>
                            <table style="width: 100%;" class="msgtable">
                                <tr>
                                    <th style="text-align: left">
                                        <asp:Label ID="lblEditTabFeatureFlds"  runat="server"
                                            CssClass="h6">表功能字段编辑区域</asp:Label>
                                        <asp:Label ID="lblMsgEdit"  runat="server"
                                            Width="208px"  CssClass="text-warning"></asp:Label>
                                    </th>
                                    <th style="text-align: right">
                                        <asp:Button ID="btnOKUpd"  runat="server"
                                             Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>

                                        <asp:Button ID="btnCancelTabFeatureFldsEdit" 
                                            runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelTabFeatureFldsEdit_Click"></asp:Button>
                                    </th>
                                </tr>
                            </table>
                        </div>
                        <div>
                            <uc1:wucTabFeatureFldsB ID="wucTabFeatureFldsB1" runat="server" />
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
