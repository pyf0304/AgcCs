<%@ Register TagPrefix="uc1" TagName="wucFileResource" Src="wucFileResource.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvFileResource4Gv" Src="wucvFileResource4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true" CodeBehind="wfmFileResourceB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmFileResourceB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>文件资源-维护的维护</title>
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">文件资源-维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabQuery" style="width: 70%" class="table table-bordered table-hover table td table-sm">
                    <tr>
                        <td>
                            <asp:Label ID="lblFileDirNameq" name="lblFileDirNameq" CssClass="col-form-label text-right" Width="90px" Text="文件目录名" runat="server" />
                        </td>
                        <td colspan="3">
                            <asp:TextBox ID="txtFileDirNameq" name="txtFileDirNameq" CssClass="form-control" Width="300px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblFileNameq" name="lblFileNameq" CssClass="col-form-label text-right" Width="90px" Text="文件名" runat="server" />
                        </td>
                        <td colspan="3">
                            <asp:TextBox ID="txtFileNameq" name="txtFileNameq" CssClass="form-control" Width="300px" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblExtensionq" name="lblExtensionq" CssClass="col-form-label text-right" Width="90px" Text="扩展名" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlExtensionq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblCmPrjIdq" name="lblCmPrjIdq" CssClass="col-form-label text-right" Width="90px" Text="CM工程" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlCmPrjIdq" name="ddlCmPrjIdq" CssClass="form-control" Width="180px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCmPrjId_q_SelectedIndexChanged" />
                        </td>
                        <td>
                            <asp:Label ID="lblIsGeneCodeq" name="lblIsGeneCodeq" CssClass="col-form-label text-right" Width="90px" Text="生成代码?" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsGeneCodeq" name="ddlIsGeneCodeq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                           <td>
                            <asp:Label ID="Label2" name="lblIsCanDelq" CssClass="col-form-label text-right" Width="60px" Text="本项目?" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsCurrPrjq" name="ddlIsCurrPrjq" CssClass="form-control" Width="90px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblIsCanDelq" name="lblIsCanDelq" CssClass="col-form-label text-right" Width="60px" Text="可删除?" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsCanDelq" name="ddlIsCanDelq" CssClass="form-control" Width="90px" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblTabIdq" name="lblTabIdq" CssClass="col-form-label text-right" Width="90px" Text="数据表" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTabIdq" name="ddlTabIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                     
                        <td>
                            <asp:Label ID="lblFuncModuleAgcIdq" name="lblFuncModuleAgcIdq" CssClass="col-form-label text-right" Width="90px" Text="功能模块" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFuncModuleAgcIdq" name="ddlFuncModuleAgcIdq" CssClass="form-control" Width="180px" runat="server" />
                        </td>
                           <td>
                            <asp:Label ID="lblTabStateIdq" name="lblTabStateIdq" CssClass="col-form-label text-right" Width="90px" Text="表状态" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTabStateIdq" name="ddlTabStateIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <%--   <td>
                            <asp:Label ID="Label3" name="lblTabStateIdq" CssClass="col-form-label text-right" Width="90px" Text="机器名" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlMachineNameq" name="ddlMachineNameq" CssClass="form-control" Width="120px" runat="server" />
                        </td>--%>

                        <td>
                            <asp:CheckBox ID="chkUnUpdateFile" runat="server" Text="未修改文件" />
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
            <div>
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="Label1" CssClass="text-right text-primary font-weight-bold" Width="120px" Text="项目所在目录：" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Label ID="lblUserPath" CssClass="text-left text-danger" Text="用户路径" runat="server" />
                    </li>
                </ul>
            </div>
            <div id="divFunction" class="table table-bordered table-hover">
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblFileResourceList" name="lblFileResourceList" CssClass="col-form-label text-info" Width="250px" Text="文件资源列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnUpdateRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAnalysisFileByGenerateCode" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnAnalysisFileByGenerateCode_Click" Text="针对生成代码分析文件" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelFileFromCmPrjId" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnDelFileFromCmPrjId_Click" Text="排除出本CM项目" runat="server" />
                    </li>
                         <li class="nav-item ml-3">
                        <asp:Button ID="btnSetCanDelete" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnSetCanDelete_Click" Text="设置成可以删除" runat="server" />
                    </li>
                        <li class="nav-item ml-3">
                        <asp:Button ID="btnSetCanNotDelete" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnSetCanNotDelete_Click" Text="设置成不可以删除" runat="server" />
                    </li>
                    <%--<li class="nav-item ml-3">
                        <asp:Button ID="Button1" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnDelFileFromCmPrjId_Click" Text="排除出本CM项目" runat="server" />
                    </li>--%>
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:wucvFileResource4Gv runat="server" id="wucvFileResource4Gv1"
                    OnGvUpdateClick="wucvFileResource4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvFileResource4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditFileResourceRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditFileResource" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">文件资源编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelFileResourceEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelFileResourceEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:wucFileResource id="wucFileResource1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
