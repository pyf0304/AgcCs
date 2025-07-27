<%@ Register TagPrefix="uc1" TagName="DnFuncMap_Edit" Src="DnFuncMap_Edit.ascx" %>
<%@ Register TagPrefix="uc2" TagName="vDnFuncMap4Gv" Src="vDnFuncMap4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="DnFuncMap_QUDI.aspx.cs" Inherits="AGC.Webform.DnFuncMap_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>数据结点函数映射维护的维护</title>
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">数据结点函数映射维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabEdit" style="width: 70%" class="table table-bordered table-hover table td table-sm">
                    <tr>
                                 <td style="text-align: right;">
                        <asp:Label ID="Label2" runat="server" CssClass="text-info  font-weight-bold " Width="70px">CM项目</asp:Label>
                    </td>
                    <td >
                        <asp:DropDownList ID="ddlCmPrjIdq" runat="server" CssClass="text-danger  font-weight-bold" OnSelectedIndexChanged="ddlCmPrjId_q_SelectedIndexChanged" AutoPostBack="true" Width="120px">                        </asp:DropDownList>
                        
                    </td>
                        <td class="text-left">
                            <asp:Label ID="lblInDataNodeIdq" name="lblInDataNodeIdq" CssClass="col-form-label text-right" Width="90px" Text="In结点" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlInDataNodeIdq" name="ddlInDataNodeIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblOutDataNodeIdq" name="lblOutDataNodeIdq" CssClass="col-form-label text-right" Width="90px" Text="Out结点" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlOutDataNodeIdq" name="ddlOutDataNodeIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblAssociationMappingIdq" name="lblAssociationMappingIdq" CssClass="col-form-label text-right" Width="90px" Text="关联映射" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlAssociationMappingIdq" name="ddlAssociationMappingIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblFuncMapModeIdq" name="lblFuncMapModeIdq" CssClass="col-form-label text-right" Width="90px" Text="映射模式" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlFuncMapModeIdq" name="ddlFuncMapModeIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="text-left">
                            <asp:Label ID="lblTabIdq" name="lblTabIdq" CssClass="col-form-label text-right" Width="90px" Text="表" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlTabIdq" name="ddlTabIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblDnFunctionIdq" name="lblDnFunctionIdq" CssClass="col-form-label text-right" Width="90px" Text="DN函数" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlDnFunctionIdq" name="ddlDnFunctionIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
<asp:Button id="btnQuery" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnQuery_Click" Text="查询" runat="server" />
</td>
<td class="text-left">
<asp:Button id="btnExportExcel" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
</td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="table  table-hover">
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblDnFuncMapList" name="lblDnFuncMapList" CssClass="col-form-label text-info" Width="250px" Text="数据结点函数映射列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnCopyRecord" CssClass="btn btn-outline-info btn-sm" OnClick="btnCopyRecord_Click" Text="复制记录" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnUpdateRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                    </li>
                         <li class="nav-item ml-3">
                        <asp:Button ID="btnCheckGraphRing" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnCheckGraphRing_Click" Text="检查是否有环" runat="server" />
                            <asp:DropDownList ID="ddlDataNodeLst" name="ddlTabIdq" CssClass="form-control" Width="120px" runat="server" />
                    
                         </li>
                         <li class="nav-item ml-3">
                        <asp:Button ID="btnDepthFirstSearch" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnDepthFirstSearch_Click" Text="深度遍历" runat="server" />
                    
                         </li>
                         <li class="nav-item ml-3">
                        <asp:Button ID="btnGetRingLst" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnGetRingLst_Click" Text="获取环列表" runat="server" />
                    
                         </li>
                       <li class="nav-item ml-3">
                          <div class="btn-group" role="group" aria-label="Basic example">
                      <asp:Button ID="btnCopyTo" CssClass="btn btn-outline-info text-nowrap" OnClick="btnCopyTo_Click" Text="复制到" runat="server" />
                            <asp:DropDownList ID="ddlCmPrjId_Copy" CssClass="form-control-sm" Width="150px" runat="server" />
                                 </div>
                                            
                    </li>
                    
                    <%--         <li class="nav-item ml-3">
                        <asp:Button ID="btnSetStartNode" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnSetStartNode_Click" Text="设置开始结点" runat="server" />
                    </li>
                        <li class="nav-item ml-3">
                        <asp:Button ID="btnSetEndNode" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnSetEndNode_Click" Text="设置结束结点" runat="server" />
                    </li>--%>

                        </ul>

            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:vDnFuncMap4Gv runat="server" id="vDnFuncMap4Gv1"
                    OnGvUpdateClick="vDnFuncMap4Gv1_GvUpdateClick"
                    OnGvDeleteClick="vDnFuncMap4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditDnFuncMapRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditDnFuncMap" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">数据结点函数映射编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelDnFuncMapEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelDnFuncMapEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:DnFuncMap_Edit id="DnFuncMap_Edit1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
