<%@ Register TagPrefix="uc1" TagName="wucCMRequirement" Src="wucCMRequirement.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvCMRequirement4Gv" Src="wucvCMRequirement4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmCMRequirement_QUDI.aspx.cs" Inherits="AGC.Webform.wfmCMRequirement_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>项目需求维护的维护</title>
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">项目需求维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabQuery" style="width: 70%;" class="table table-bordered table-hover table td table-sm">
                    <tr>
                        <td>
                            <asp:Label ID="lblReqIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="需求Id" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtReqIdq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblRequirementNameq"  Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="名称" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtRequirementNameq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                       
                        <td>
                            <asp:Label ID="lblRequirementTypeIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="类型" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlRequirementTypeIdq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblIsFinishedq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="完成?" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsFinishedq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        
                       
                        <td>
                            <asp:Label ID="lblCmPrjIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="CM工程" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlCmPrjIdq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                         <td>
                            <asp:Label ID="lblFuncModuleAgcIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="模块" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFuncModuleAgcIdq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                       
                         <td>
                            <asp:Label ID="lblPrjIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="工程" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPrjIdq" CssClass="form-control-sm" Width="200px" runat="server" />
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
                        <asp:Label ID="lblCMRequirementList" CssClass="col-form-label text-info" Width="250px" Text="项目需求列表" runat="server" />
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
                    <li class="nav-item ml-3">
                        <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:DropDownList ID="ddlRequirementTypeId_SetFldValue" class="form-control-sm" Width="200px" runat="server" />
                            <asp:Button ID="btnSetRequirementTypeId" CssClass="btn btn-outline-info text-nowrap" OnClick="btnSetRequirementTypeId_Click" Text="设置需求类型Id" runat="server" />
                        </div>
                    </li>
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:wucvCMRequirement4Gv runat="server" ID="wucvCMRequirement4Gv1"
                    OnGvUpdateClick="wucvCMRequirement4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvCMRequirement4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditCMRequirementRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditCMRequirement" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">项目需求编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelCMRequirementEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelCMRequirementEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:wucCMRequirement ID="wucCMRequirement1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
