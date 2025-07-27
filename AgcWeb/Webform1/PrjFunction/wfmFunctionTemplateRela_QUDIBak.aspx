<%@ Register TagPrefix="uc1" TagName="wucFunctionTemplateRela" Src="wucFunctionTemplateRela.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvFunctionTemplateRela4Gv" Src="~/Webform/PrjFunction/wucvFunctionTemplateRela4Gv.ascx" %>


<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmFunctionTemplateRela_QUDIBak.aspx.cs" Inherits="AGC.Webform.wfmFunctionTemplateRela_QUDIBak" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>函数与模板关系维护的维护</title>
</head>
<body>
    <form id="form1" runat="server" class="form-horizontal">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>
            
            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">函数与模板关系维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabQuery" style="width: 70%;" class="table table-bordered table-hover table td table-sm">
                    <tr>
                        <td>
                            <asp:Label ID="lblFunctionTemplateIdq" name="lblFunctionTemplateIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="函数模板Id" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFunctionTemplateIdq" name="ddlFunctionTemplateIdq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblProgLangTypeIdq" name="lblProgLangTypeIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="编程语言类型Id" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlProgLangTypeIdq" name="ddlProgLangTypeIdq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblCreateUserIdq" name="lblCreateUserIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="建立用户Id" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtCreateUserIdq" name="txtCreateUserIdq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblFuncId4GCq" name="lblFuncId4GCq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="函数ID" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFuncId4GCq" name="ddlFuncId4GCq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblFuncNameq" name="lblFuncNameq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="函数名" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtFuncNameq" name="txtFuncNameq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnQuery" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnQuery_Click" Text="查询" runat="server" />
                        </td>
                    </tr>
                    <tr>
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
                        <asp:Label ID="lblFunctionTemplateRelaList" name="lblFunctionTemplateRelaList" CssClass="col-form-label text-info" Width="250px" Text="函数与模板关系列表" runat="server" />
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
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:wucvFunctionTemplateRela4Gv runat="server" id="wucvFunctionTemplateRela4Gv1"
                    OnGvUpdateClick="wucvFunctionTemplateRela4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvFunctionTemplateRela4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditFunctionTemplateRelaRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditFunctionTemplateRela" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">函数与模板关系编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelFunctionTemplateRelaEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelFunctionTemplateRelaEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:wucFunctionTemplateRela id="wucFunctionTemplateRela1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
