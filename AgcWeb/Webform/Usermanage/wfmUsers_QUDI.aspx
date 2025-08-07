<%@ Register TagPrefix="uc1" TagName="wucUsers" Src="wucUsers.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvUsers4Gv" Src="wucvUsers4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmUsers_QUDI.aspx.cs" Inherits="AGC.Webform.wfmUsers_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>用于用户管理维护的维护</title>
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">用于用户管理维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabQuery" name="tabQuery" style="width: 70%;" class="table table-bordered table-hover table td table-sm">
                    <tr>
                        <td>
                            <asp:Label ID="lblUserIdq" name="lblUserIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="用户Id" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtUserIdq" name="txtUserIdq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblUserNameq" name="lblUserNameq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="用户名" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtUserNameq" name="txtUserNameq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblDepartmentIdq" name="lblDepartmentIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="部门ID" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlDepartmentIdq" name="ddlDepartmentIdq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblUserStateIdq" name="lblUserStateIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="用户状态号" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtUserStateIdq" name="txtUserStateIdq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblIdentityIDq" name="lblIdentityIDq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="身份编号" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIdentityIDq" name="ddlIdentityIDq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblIsGpUserq" name="lblIsGpUserq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="平台用户?" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsGpUserq" name="ddlIsGpUserq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblIsRegisterq" name="lblIsRegisterq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="注册?" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsRegisterq" name="ddlIsRegisterq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblIsAuditq" name="lblIsAuditq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="审核?" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsAuditq" name="ddlIsAuditq" CssClass="form-control-sm" Width="200px" runat="server" />
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
                        <asp:Label ID="lblUsersList" name="lblUsersList" CssClass="col-form-label text-info" Width="250px" Text="用于用户管理列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnCopyRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnCopyRecord_Click" Text="复制记录" runat="server" />
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
                <uc2:wucvUsers4Gv runat="server" ID="wucvUsers4Gv1"
                    OnGvUpdateClick="wucvUsers4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvUsers4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditUsersRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditUsers" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">用于用户管理编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelUsersEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelUsersEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:wucUsers ID="wucUsers1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
