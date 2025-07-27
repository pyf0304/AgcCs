<%@ Register TagPrefix="uc1" TagName="wucTabFunctionProp" Src="wucTabFunctionProp.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvTabFunctionProp4Gv" Src="wucvTabFunctionProp4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmTabFunctionProp_QUDI.aspx.cs" Inherits="AGC.Webform.wfmTabFunctionProp_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>表函数属性维护的维护</title>
      
    <script src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
        <style type="text/css">
        body{
            font-size:0.875rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="form-horizontal">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">表函数属性维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabQuery" style="width: 70%;" class="table table-bordered table-hover table td table-sm">
                    <tr>
                        <td>
                            <asp:Label ID="lblFunctionTemplateIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="函数模板" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFunctionTemplateIdq" name="ddlFunctionTemplateIdq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblProgLangTypeIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="语言" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlProgLangTypeIdq" name="ddlProgLangTypeIdq" CssClass="form-control" Width="200px" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProgLangTypeId_q_SelectedIndexChanged" />
                        </td>
                        <td>
                            <asp:Label ID="lblCodeTypeIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="代码类型" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlCodeTypeIdq" name="ddlCodeTypeIdq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblTabIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="工程表" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTabIdq" name="ddlTabIdq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblFuncId4GCq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="函数" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFuncId4GCq" name="ddlFuncId4GCq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblMethodModifierIdq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="函数修饰语" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList id="ddlMethodModifierIdq" name="ddlMethodModifierIdq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnQuery" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnQuery_Click" Text="查询" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                        </td>
                        <td></td>
                        <td></td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="table table-bordered table-hover">
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblTabFunctionPropList" CssClass="col-form-label text-info" Width="250px" Text="表函数属性列表" runat="server" />
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
                    <li class="nav-item ml-3">
                        <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:DropDownList ID="ddlMethodModifierId_SetFldValue" name="ddlMethodModifierId_SetFldValue" class="form-control" Width="200px" runat="server" />
                            <asp:Button ID="btnSetMethodModifierId" CssClass="btn btn-outline-info text-nowrap" OnClick="btnSetMethodModifierId_Click" Text="设置函数修饰语Id" runat="server" />
                        </div>
                    </li>
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:wucvTabFunctionProp4Gv runat="server" ID="wucvTabFunctionProp4Gv1"
                    OnGvUpdateClick="wucvTabFunctionProp4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvTabFunctionProp4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditTabFunctionPropRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditTabFunctionProp" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">表函数属性编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelTabFunctionPropEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelTabFunctionPropEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:wucTabFunctionProp ID="wucTabFunctionProp1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
