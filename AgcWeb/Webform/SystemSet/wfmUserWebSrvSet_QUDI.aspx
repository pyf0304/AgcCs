<%@ Register TagPrefix="uc1" TagName="wucUserWebSrvSet" Src="wucUserWebSrvSet.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucUserWebSrvSet4Gv" Src="wucUserWebSrvSet4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmUserWebSrvSet_QUDI.aspx.cs" Inherits="AGC.Webform.wfmUserWebSrvSet_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>用户WebSrv设置维护的维护</title>
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">用户WebSrv设置维护
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
                            <asp:DropDownList ID="ddlUserIdq" name="ddlUserIdq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblWebApiIPAndPortq" name="lblWebApiIPAndPortq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="WebApiIPAndPort" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtWebApiIPAndPortq" name="txtWebApiIPAndPortq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblWebApiVirtualPathq" name="lblWebApiVirtualPathq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="WebApi虚拟路径" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtWebApiVirtualPathq" name="txtWebApiVirtualPathq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblIsTemplateq" name="lblIsTemplateq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="是否模板" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsTemplateq" name="ddlIsTemplateq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                    </tr>
                    <tr>
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
                        <asp:Label ID="lblUserWebSrvSetList" name="lblUserWebSrvSetList" CssClass="col-form-label text-info" Width="250px" Text="用户WebSrv设置列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
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
                <uc2:wucUserWebSrvSet4Gv runat="server" id="wucUserWebSrvSet4Gv1"
                    OnGvUpdateClick="wucUserWebSrvSet4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucUserWebSrvSet4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditUserWebSrvSetRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditUserWebSrvSet" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">用户WebSrv设置编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelUserWebSrvSetEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelUserWebSrvSetEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:wucUserWebSrvSet id="wucUserWebSrvSet1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
