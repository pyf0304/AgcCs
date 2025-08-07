<%@ Register TagPrefix="uc1" TagName="wucViewRelaTab" Src="wucViewRelaTab.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvViewRelaTab4Gv" Src="wucvViewRelaTab4Gv.ascx" %>

<%@ Page Title="界面相关表维护" Language="C#" MasterPageFile="~/Webform/MasterPage/mpViewEdit.Master" CodeBehind="wfmViewRelaTab_QUDI.aspx.cs" ValidateRequest="false"
    AutoEventWireup="True" Inherits="AGC.Webform.wfmViewRelaTab_QUDI" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">





    <div id="tabLayout" class="tab_layout"
        runat="server">
        <%-- 标题层 --%>

        <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
            <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">界面相关表维护
            </asp:Label>
            <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                Width="347px"></asp:Label>
        </div>
        <%-- 查询层 --%>

        <div id="divQuery" style="margin: 10px;">
            <table id="tabQuery" style="width: 70%;" class="table table-bordered table-hover table td table-sm">
                <tr>
                    <td>
                        <asp:Label ID="lblViewIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="界面Id" runat="server" />
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlViewIdq" CssClass="form-control" Width="200px" runat="server" />
                    </td>
                    <td>
                        <asp:Label ID="lblViewNameq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="界面名称" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtViewNameq" CssClass="form-control" Width="200px" runat="server" />
                    </td>
                    <td>
                        <asp:Label ID="lblViewCnNameq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="视图中文名" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtViewCnNameq" CssClass="form-control" Width="200px" runat="server" />
                    </td>
                    <td>
                        <asp:Label ID="lblInOutTypeIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="INOUT类型ID" runat="server" />
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlInOutTypeIdq" CssClass="form-control" Width="200px" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblViewTabTypeIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="界面表类型码" runat="server" />
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlViewTabTypeIdq" CssClass="form-control" Width="200px" runat="server" />
                    </td>
                    <td>
                        <asp:Label ID="lblTabIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="表ID" runat="server" />
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlTabIdq" CssClass="form-control" Width="200px" runat="server" />
                    </td>
                    <td>
                        <asp:Label ID="lblTabFunctionq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="表功能说明" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtTabFunctionq" CssClass="form-control" Width="200px" runat="server" />
                    </td>
                    <td>
                        <asp:Button ID="btnQuery" CssClass="btn btn-outline-warning" class="btn btn-outline-warning" OnClick="btnQuery_Click" Text="查询" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnExportExcel" CssClass="btn btn-outline-warning" class="btn btn-outline-warning" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
        <%-- 功能区 --%>

        <div id="divFunction" class="table table-bordered table-hover">
            <ul class="nav">
                <li class="nav-item">
                    <asp:Label ID="lblViewRelaTabList" CssClass="col-form-label text-info" Width="250px" Text="界面相关表列表" runat="server" />
                </li>
                <li class="nav-item ml-3">
                    <asp:Button ID="btnAddNewRecord" CssClass="btn btn-outline-info" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                </li>
                <li class="nav-item ml-3">
                    <asp:Button ID="btnCopyRecord" CssClass="btn btn-outline-info" OnClick="btnCopyRecord_Click" Text="复制记录" runat="server" />
                </li>
                <li class="nav-item ml-3">
                    <asp:Button ID="btnUpdateRecord" CssClass="btn btn-outline-info" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                </li>
                <li class="nav-item ml-3">
                    <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                </li>
            </ul>
        </div>
        <%-- 列表层 --%>
        <div id="divList" class="div_List mt-2" runat="server">
            <uc2:wucvViewRelaTab4Gv runat="server" ID="wucvViewRelaTab4Gv1"
                OnGvUpdateClick="wucvViewRelaTab4Gv1_GvUpdateClick"
                OnGvDeleteClick="wucvViewRelaTab4Gv1_GvDeleteClick" />
        </div>
        <%-- 编辑层 --%>
        <div id="tabEditViewRelaTabRegion" class="tab_Edit mt-2"
            runat="server">
            <div style="width: 60%;">
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblEditViewRelaTab" Style="z-index: 104;" Width="200px" runat="server"
                            CssClass="col-form-label text-info">界面相关表编辑区域</asp:Label>
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                            Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnCancelViewRelaTabEdit"
                            runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelViewRelaTabEdit_Click"></asp:Button>
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Label ID="lblMsgEdit" runat="server"
                            Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                    </li>
                </ul>
            </div>
            <div>
                <uc1:wucViewRelaTab ID="wucViewRelaTab1" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
