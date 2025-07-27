<%@ Register TagPrefix="uc1" TagName="wucwf_WorkFlow" Src="wucwf_WorkFlow.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvwf_WorkFlow4Gv" Src="wucvwf_WorkFlow4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true" CodeBehind="wfmwf_WorkFlow_QUDI.aspx.cs" Inherits="AGC.Webform.wfmwf_WorkFlow_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>工作流维护的维护</title>
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">工作流维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabQuery" name="tabQuery" style="width: 70%;" class="table table-bordered table-hover table td table-sm">
                    <tr>
                        <td>
                            <asp:Label ID="lblWorkFlowIdq" name="lblWorkFlowIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="工作流Id" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtWorkFlowIdq" name="txtWorkFlowIdq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblWorkFlowNameq" name="lblWorkFlowNameq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="工作流名称" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtWorkFlowNameq" name="txtWorkFlowNameq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblPrjIdq" name="lblPrjIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="工程ID" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPrjIdq" name="ddlPrjIdq" CssClass="form-control" Width="200px" runat="server" />
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
                        <asp:Label ID="lblwf_WorkFlowList" name="lblwf_WorkFlowList" CssClass="col-form-label text-info" Width="250px" Text="工作流列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecord" name="btnAddNewRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnUpdateRecord" name="btnUpdateRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelRecord" name="btnDelRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnCopyRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnCopyRecord_Click" Text="复制记录" runat="server" />
                    </li>

                                           <li class="nav-item ml-3">
                    <asp:Button ID="btnDispWorkFlow" runat="server"  CssClass="btn btn-outline-info text-nowrap"  Text="显示工作流" OnClick="btnDispWorkFlow_Click" />
                    
                </li> 
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:wucvwf_WorkFlow4Gv runat="server" ID="wucvwf_WorkFlow4Gv1"
                    OnGvUpdateClick="wucvwf_WorkFlow4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvwf_WorkFlow4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditwf_WorkFlowRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditwf_WorkFlow" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">工作流编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelwf_WorkFlowEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelwf_WorkFlowEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:wucwf_WorkFlow ID="wucwf_WorkFlow1" runat="server" />
                </div>
            </div>
            <div style="width:100%; float:left">
                <asp:Panel ID="Panel1" runat="server">                    </asp:Panel>
            </div>
        </div>
    </form>
</body>
</html>
