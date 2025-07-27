<%@ Register TagPrefix="uc1" TagName="wucCMRequirement" Src="wucCMRequirement.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvCMRequirement4Gv" Src="wucvCMRequirement4Gv.ascx" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>
<%@ Register Src="~/Webform/CodeMan/wucvCMRequirement4DL.ascx" TagPrefix="uc1" TagName="wucvCMRequirement4DL" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmCMRequirement_Disp.aspx.cs" Inherits="AGC.Webform.wfmCMRequirement_Disp" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>项目需求维护的维护</title>
       <link href="../../tzMenuWuc/cssMenu1.css" rel="stylesheet" />
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
            <div>
                <div id="divTree" class="float-left" style="width: 20%">
                    <div>
                        <ul class="nav">
                            <li class="nav-item">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="lblPrjIdq" name="lblPrjIdq" CssClass="form-control-sm text-right" Text="工程" runat="server" />
                                    <asp:DropDownList ID="ddlPrjIdq" name="ddlPrjIdq" CssClass="form-control-sm" Width="150px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged" />
                                </div>
                            </li>
                        </ul>
                        <ul class="nav">

                            <li class="nav-item">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="lblUserIdq" name="lblUserIdq" CssClass="form-control-sm text-right" Text="用户" runat="server" />
                                    <asp:DropDownList ID="ddlUserIdq" name="ddlUserIdq" CssClass="form-control-sm" Width="70px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged" />
                                </div>
                            </li>
                           
                            <li class="nav-item ml-1">
                                <asp:Button ID="btnRefresh"
                                    Style="z-index: 119; width: 50px;"
                                    runat="server"
                                    Text="刷新" CssClass="btn btn-outline-warning btn-sm"
                                    OnClick="btnRefresh_Click"></asp:Button>
                            </li>
                            <li class="nav-item ml-1">
                                <%--<asp:Button ID="btnAddCmClass" runat="server" OnClick="btnAddCmClass_Click"
                                    CssClass="btn btn-outline-info btn-sm" Text="添加类"></asp:Button>--%>
                            </li>
                        </ul>
                    </div>
                    <br />
                    <uc1:wucTreeView runat="server" ID="wucTreeView1" OnafterSelect_Tz="wucTreeView1_afterSelect_Tz" />
                </div>
                <div id="divMain" class="float-right" style="width: 80%">
                    
                    <%-- 查询层 --%>

                    <div id="divQuery" style="margin: 10px;">
                        <table id="tabQuery" style="width: 70%;" class="table table-bordered table-hover table td table-sm">
                            <tr>
                                <td>
                                    <asp:Label ID="lblReqIdq"  CssClass="col-form-label text-right" Width="70px" Text="需求Id" runat="server" />
                                </td>
                                <td>
                                    <asp:TextBox ID="txtReqIdq" CssClass="form-control-sm" Width="100px" runat="server" />
                                </td>
                                <td>
                                    <asp:Label ID="lblRequirementNameq"  CssClass="col-form-label text-right" Width="70px" Text="名称" runat="server" />
                                </td>
                                <td>
                                    <asp:TextBox ID="txtRequirementNameq" CssClass="form-control-sm" Width="150px" runat="server" />
                                </td>

                                <td>
                                    <asp:Label ID="lblRequirementTypeIdq"  CssClass="col-form-label text-right" Width="70px" Text="类型" runat="server" />
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlRequirementTypeIdq" CssClass="form-control-sm" Width="100px" runat="server" />
                                </td>
                                <td>
                                    <asp:Label ID="lblIsFinishedq"  CssClass="col-form-label text-right" Width="70px" Text="完成?" runat="server" />
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlIsFinishedq" CssClass="form-control-sm" Width="100px" runat="server" />
                                </td>
                           
                                <td>
                                    <asp:Button ID="btnQuery" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnQuery_Click" Text="查询" runat="server" />
                                </td>
                                <td>
                                    <asp:Button ID="btnAddNewRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                                </td>
                                <%--   <td>
                                    <asp:Button ID="btnExportExcel" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                                </td>--%>
                            </tr>
                        </table>
                    </div>
                    <%-- 功能区 --%>

                  
                    <%-- 列表层 --%>
                    <div id="divList" class="div_List mt-1" runat="server">
                        <%--<uc2:wucvCMRequirement4Gv runat="server" ID="wucvCMRequirement4Gv1"
                            OnGvUpdateClick="wucvCMRequirement4Gv1_GvUpdateClick"
                            OnGvDeleteClick="wucvCMRequirement4Gv1_GvDeleteClick" />--%>
                            <uc1:wucvCMRequirement4DL runat="server" ID="wucvCMRequirement4DL1"
                                    OnDlEditParaClick="wucvCMRequirement4DL1_DlEditParaClick"
                                    OnDlCloneClick="wucvCMRequirement4DL1_DlCloneClick"
                                    OnDlUpdateClick="wucvCMRequirement4DL1_DlUpdateClick"
                                    OnDlDeleteClick="wucvCMRequirement4DL1_DlDeleteClick" />
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
            </div>
        </div>
    </form>
</body>
</html>
