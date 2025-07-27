<%@ Register TagPrefix="uc1" TagName="wucDNFunction" Src="wucDNFunction.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvDNFunction4Gv" Src="wucvDNFunction4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="DNFunction_QUDI.aspx.cs" Inherits="AGC.Webform.DNFunction_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>数据结点函数维护的维护</title>
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script type="text/javascript" src="../../Scripts/bootstrap.js"></script>
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>

</head>
<body>
    <form id="form1" runat="server" class="form-horizontal">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">数据结点函数维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabEdit" style="width: 70%" class="table table-bordered table-hover table td table-sm">
                    <tr>
                        <td class="text-left">
                            <asp:Label ID="lblDnFunctionIdq" name="lblDnFunctionIdq" CssClass="col-form-label text-right" Width="90px" Text="DN函数Id" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:TextBox ID="txtDnFunctionIdq" name="txtDnFunctionIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblDnFunctionNameq" name="lblDnFunctionNameq" CssClass="col-form-label text-right" Width="90px" Text="DN函数" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:TextBox ID="txtDnFunctionNameq" name="txtDnFunctionNameq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblAssociationMappingIdq" name="lblAssociationMappingIdq" CssClass="col-form-label text-right" Width="90px" Text="关联关系映射Id" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlAssociationMappingIdq" name="ddlAssociationMappingIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Button ID="btnQuery" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnQuery_Click" Text="查询" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td class="text-left">
                            <asp:Button ID="btnExportExcel" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="table table-bordered table-hover">
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblDNFunctionList" name="lblDNFunctionList" CssClass="col-form-label text-info" Width="250px" Text="数据结点函数列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecordWithMaxId" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnAddNewRecordWithMaxId_Click" Text="添加" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnCopyRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnCopyRecord_Click" Text="复制" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnUpdateRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                    </li>
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:wucvDNFunction4Gv runat="server" ID="wucvDNFunction4Gv1"
                    OnGvUpdateClick="wucvDNFunction4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvDNFunction4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditDNFunctionRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditDNFunction" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">数据结点函数编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelDNFunctionEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelDNFunctionEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:wucDNFunction ID="wucDNFunction1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
