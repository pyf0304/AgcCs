<%@ Register TagPrefix="uc1" TagName="wucwf_Point" Src="wucwf_Point.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvwf_Point4Gv" Src="wucvwf_Point4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true" CodeBehind="wfmwf_Point_QUDI.aspx.cs" Inherits="AGC.Webform.wfmwf_Point_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>工作流结点表维护的维护</title>
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">工作流结点表维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabQuery" name="tabQuery" style="width: 70%;" class="table table-bordered table-hover table td table-sm">
                    <tr>
                        <td>
                            <asp:Label ID="lblPointIdq" name="lblPointIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="结点Id" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtPointIdq" name="txtPointIdq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblPointNameq" name="lblPointNameq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="结点名称" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtPointNameq" name="txtPointNameq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblPrjIdq" name="lblPrjIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="工程ID" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPrjIdq" name="ddlPrjIdq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblTabNameq" name="lblTabNameq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="表名" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtTabNameq" name="txtTabNameq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblTabKeyIdq" name="lblTabKeyIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="表关键字Id" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtTabKeyIdq" name="txtTabKeyIdq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
<asp:Label id="lblInUseq" name="lblInUseq" style="width:80px;" CssClass="col-form-label text-right" Width="90px" Text="使用?" runat="server" />
</td>
                        <td>
<asp:DropDownList id="ddlInUseq" name="ddlInUseq" CssClass="form-control" Width="200px" runat="server" />
</td>

                        <td>
<asp:Button id="btnQuery" CssClass="btn btn-outline-warning text-nowrap"  OnClick="btnQuery_Click" Text="查询" runat="server" />
</td>
<td>
<asp:Button id="btnExportExcel" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
</td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="table table-bordered table-hover">
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblwf_PointList" name="lblwf_PointList" CssClass="col-form-label text-info" Width="250px" Text="工作流结点表列表" runat="server" />
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
                        <asp:Button ID="btnCopyRecord" name="btnCopyRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnCopyRecord_Click" Text="复制记录" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:Button ID="btnSetInUse" name="btnSetInUse" CssClass="btn btn-outline-info text-nowrap" OnClick="btnSetInUse_Click" Text="设置使用" runat="server" />
                            <asp:Button ID="btnSetNotInUse" name="btnSetNotInUse" CssClass="btn btn-outline-info text-nowrap" OnClick="btnSetNotInUse_Click" Text="设置不用" runat="server" />
                        </div>
                    </li>
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:wucvwf_Point4Gv runat="server" ID="wucvwf_Point4Gv1"
                    OnGvUpdateClick="wucvwf_Point4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvwf_Point4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditwf_PointRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditwf_Point" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">工作流结点表编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelwf_PointEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelwf_PointEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:wucwf_Point ID="wucwf_Point1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
