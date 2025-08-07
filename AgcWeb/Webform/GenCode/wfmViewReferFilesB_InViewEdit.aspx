<%@ Register TagPrefix="uc1" TagName="wucViewReferFilesB" Src="wucViewReferFilesB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvViewReferFiles4Gv" Src="wucvViewReferFiles4Gv.ascx" %>


<%@ Page Title="界面引用文件维护的维护" Language="C#" MasterPageFile="~/Webform/MasterPage/mpViewEdit.Master" CodeBehind="wfmViewReferFilesB_InViewEdit.aspx.cs" ValidateRequest="false"
    AutoEventWireup="True" Inherits="AGC.Webform.wfmViewReferFilesB_InViewEdit" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div id="tabLayout" class="tab_layout"
        runat="server">
        <%-- 标题层 --%>

        <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px; visibility:hidden; display:none">
            <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">界面引用文件维护
            </asp:Label>
            <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                Width="347px"></asp:Label>
        </div>
        <%-- 查询层 --%>

        <div id="divQuery" style="margin: 10px; visibility:hidden; display:none">
            <table id="tabQuery" style="width: 70%;" class="table table-bordered table-hover table td">
                <tr>
                    <td>
                        <asp:Label ID="lblViewIdq" CssClass="col-form-label text-right" Width="90px" Text="界面Id" runat="server" />
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlViewIdq" CssClass="form-control" Width="200px" runat="server" />
                    </td>
                    <td>
                        <asp:Label ID="lblViewNameq" CssClass="col-form-label text-right" Width="90px" Text="界面名称" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtViewNameq" CssClass="form-control" Width="200px" runat="server" />
                    </td>
                    <td>
                        <asp:Label ID="lblPrjIdq" CssClass="col-form-label text-right" Width="90px" Text="工程ID" runat="server" />
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlPrjIdq" CssClass="form-control" Width="200px" runat="server" />
                    </td>
                    <td>
                        <asp:Label ID="lblReferFileIdq" CssClass="col-form-label text-right" Width="90px" Text="引用文件Id" runat="server" />
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlReferFileIdq" CssClass="form-control" Width="200px" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblIsTemplateq" CssClass="col-form-label text-right" Width="90px" Text="是否模板" runat="server" />
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlIsTemplateq" CssClass="form-control" Width="200px" runat="server" />
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
                    <asp:Label ID="lblViewReferFilesList" CssClass="col-form-label text-info" Width="250px" Text="界面引用文件列表" runat="server" />
                </li>
                <li class="nav-item ml-3">
                    <asp:Button ID="btnAddNewRecord" CssClass="btn btn-outline-info" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                </li>
                <li class="nav-item ml-3">
                    <asp:Button ID="btnUpdateRecord" CssClass="btn btn-outline-info" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                </li>
                <li class="nav-item ml-3">
<div class="btn-group" role="group" aria-label="Basic example">
<asp:Button id="btnSetInUse" CssClass="btn btn-outline-info" OnClick="btnSetInUse_Click" Text="设置在用" runat="server" />
<asp:Button id="btnSetNotInUse" CssClass="btn btn-outline-info" OnClick="btnSetNotInUse_Click" Text="设置不用" runat="server" />
</div>
</li>
                <li class="nav-item ml-3">
                    <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                </li>
                                <li class="nav-item ml-3">
                    <asp:Button ID="btnCopyFromTempplate" CssClass="btn btn-outline-info" OnClick="btnCopyFromTempplate_Click" Text="复制模板" runat="server" />
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
                    <asp:Button ID="btnCopyFromTempplate4AllView" CssClass="btn btn-outline-info" OnClick="btnCopyFromTempplate4AllView_Click" Visible="false" Text="为所有界面复制模板" runat="server" />
                </li>
            </ul>
        </div>
        <%-- 列表层 --%>
        <div id="divList" class="div_List mt-2" runat="server">
            <uc2:wucvViewReferFiles4Gv runat="server" ID="wucvViewReferFiles4Gv1"
                OnGvUpdateClick="wucvViewReferFiles4Gv1_GvUpdateClick"
                OnGvDeleteClick="wucvViewReferFiles4Gv1_GvDeleteClick" />
        </div>
        <%-- 编辑层 --%>
        <div id="tabEditViewReferFilesRegion" class="tab_Edit mt-2"
            runat="server">
            <div>
                <table style="width: 60%;" class="table table-bordered table-hover">
                    <tr>
                        <th style="text-align: left">
                            <asp:Label ID="lblEditViewReferFiles"  runat="server"
                                CssClass="col-form-label text-info">界面引用文件编辑区域</asp:Label>
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="208px" CssClass="col-form-label text-danger"></asp:Label>
                        </th>
                        <th style="text-align: right">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>

                            <asp:Button ID="btnCancelViewReferFilesEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelViewReferFilesEdit_Click"></asp:Button>
                        </th>
                    </tr>
                </table>
            </div>
            <div>
                <uc1:wucViewReferFilesB ID="wucViewReferFilesB1" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
