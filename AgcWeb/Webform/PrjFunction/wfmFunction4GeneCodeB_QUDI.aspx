<%@ Register TagPrefix="uc1" TagName="wucFunction4GeneCodeB" Src="wucFunction4GeneCodeB.ascx" %>
<%@ Register Src="wucFunction4GC4BatchUpdate.ascx" TagPrefix="uc2" TagName="wucFunction4GC4BatchUpdate" %>
<%@ Register Src="~/Webform/PrjFunction/wucvFunction4GeneCode4Gv.ascx" TagPrefix="uc2" TagName="wucvFunction4GeneCode4Gv" %>


<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmFunction4GeneCodeB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmFunction4GeneCodeB_QUDI" ValidateRequest="false" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>函数4GeneCode维护的维护</title>
    <script src="../../scripts/jquery-3.0.0.min.js"></script>
    <script src="../../scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.js"></script>


    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
    <script src="../../js/tzDivOperate.js"></script>
    <style type="text/css">
        #divBatchUpdate {
            width: 830px;
            height: 300px;
            border: 2px solid grey;
            background-color: #DDDDDD;
            top: 150px;
            left: 100px;
            position: absolute;
        }

        #divBatchUpdate2 {
            width: 830px;
            height: 300px;
            border: 2px solid grey;
            background-color: #DDDDDD;
            /*top: 150px;
            left: 100px;*/
            /*position: absolute;*/
        }
    </style>
    <script>
        function ShowDiv4BatchUpdate() {
            Tz_ShowDiv('divBatchUpdate');
            SetPosition4DivBatchUpdate();
        }
        function SetPosition4DivBatchUpdate() {
            var divBatchUpdate = document.getElementById("divBatchUpdate");
            if (divBatchUpdate != null) {
                divBatchUpdate.style.left = "100px";
                divBatchUpdate.style.top = "150px";
                divBatchUpdate.style.position = "absolute";
            }
        }
        function HideDiv4BatchUpdate() {
            Tz_HideDiv('divBatchUpdate');
        }
        function ShowBatchUpdate() {
            $('#divBatchUpdate2').modal('show');
        }
        function TestShowModal() {
            $('#myModal').modal('show');
        }
        function mySubmit() {
            alert("提交");
        }
    </script>
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5">函数4GeneCode维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 95%">
                    <tr>

                        <td class="auto-style4">
                            <asp:Label ID="lblFuncId4GCq"
                                runat="server" CssClass="text-secondary">函数ID</asp:Label>
                        </td>
                        <td class="auto-style4">
                            <asp:TextBox ID="txtFuncId4GCq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td class="auto-style4">
                            <asp:Label ID="lblFuncNameq"
                                runat="server" CssClass="text-secondary">函数名</asp:Label>
                        </td>
                        <td class="auto-style4">
                            <asp:TextBox ID="txtFuncNameq"
                                runat="server" CssClass="TextBox_Defa" Width="200px">
                            </asp:TextBox>
                        </td>
                        <td class="auto-style5">
                            <asp:Label ID="Label1" runat="server" CssClass="col-form-label text-right">数据源</asp:Label>
                        </td>
                        <td class="auto-style6">
                            <asp:DropDownList ID="ddlSqlDsTypeIdq" Width="100px" runat="server" class="form-control-sm"></asp:DropDownList>
                        </td>
                        <td class="auto-style5">
                            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">代码类型</asp:Label>
                        </td>
                        <td class="auto-style6">
                            <asp:DropDownList ID="ddlFuncGCTypeIdq" Width="100px" runat="server" class="form-control-sm"></asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label9" runat="server" CssClass="col-form-label text-right">在用?</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlInUse" runat="server" class="form-control-sm"></asp:DropDownList>
                        </td>

                        <td colspan="2">
                            <div class="btn-group col-3" role="group" aria-label="Basic example">
                                <asp:Button ID="btnGoTop" runat="server" Text="移顶" OnClick="btnGoTop_Click" CssClass="btn btn-outline-info btn-sm" />
                                <asp:Button ID="btnUpMove" runat="server" OnClick="btnUpMove_Click" Text="上移" CssClass="btn btn-outline-info btn-sm ml-1" />
                                <asp:Button ID="btnDownMove" runat="server" OnClick="btnDownMove_Click" Text="下移" CssClass="btn btn-outline-info btn-sm ml-1" />
                                <asp:Button ID="btnGoBottum" runat="server" Text="移底" OnClick="btnGoBottum_Click" CssClass="btn btn-outline-info btn-sm ml-1" />
                                <asp:Button ID="btnReOrder" runat="server" OnClick="btnReOrder_Click" Text="重序" CssClass="btn btn-outline-info btn-sm ml-1" />

                            </div>
                        </td>
                        <td class="auto-style6">
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click"
                                runat="server" CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                        </td>
                        <td></td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblProgLangTypeIdq"
                                runat="server" CssClass="text-secondary">语言</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlProgLangTypeIdq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblCodeTypeIdq"
                                runat="server" CssClass="text-secondary">代码类型</asp:Label>
                        </td>
                        <td>
                            <div class="btn-group" role="group" aria-label="Basic example">
                                <asp:DropDownList ID="ddlProgLangTypeId4CodeTypeq"
                                    runat="server" CssClass="TextBox_Defa" AutoPostBack="True" Width="60px" OnSelectedIndexChanged="ddlProgLangTypeId4CodeType_q_SelectedIndexChanged">
                                </asp:DropDownList>
                                <asp:DropDownList ID="ddlCodeTypeIdq" Width="150px"
                                    runat="server" CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </div>
                        </td>
                        <td>
                            <asp:Label ID="lblFuncTypeID" runat="server" CssClass="col-form-label text-right">函数类型</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFuncTypeIDq" Width="100px" runat="server" class="form-control-sm"></asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label4" runat="server" CssClass="col-form-label text-right">功能样板?</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsTemplate" Width="100px" runat="server" class="form-control-sm"></asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label8" runat="server" CssClass="col-form-label text-right">函数样板?</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsFuncTemplate" runat="server" class="form-control-sm"></asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="Label7" runat="server" CssClass="col-form-label text-right">分析功能?</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsParseFeature" runat="server" class="form-control-sm"></asp:DropDownList>
                        </td>
                        <td>
                            <asp:Button ID="btnQuery"
                                Style="z-index: 116; width: 80px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                        <td>
                            <asp:CheckBox ID="chkDispFunctionCHName" CssClass="form-control-sm" Checked="false" Width="140px" runat="server" Text="显示函数中文名" />
                        </td>

                    </tr>

                </table>
            </div>
            <%-- 列表层 --%>

            <div id="divFunction" class="div_List mt-2"
                runat="server">
                <div id="tabGridFunction" style="width: 100%; height: 82px" class="msgtable">
                    <div>
                        <ul class="nav">

                            <li class="nav-item">
                                <asp:Label ID="lblFunction4GeneCodeList" runat="server"
                                    CssClass="h6" Width="150px">函数列表</asp:Label>
                            </li>
                            <li class="nav-item">
                                <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click"
                                    Width="44px" CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
                            </li>
                            <li class="nav-item ml-2">
                                <asp:Button ID="btnCloneNewRec4Gv" runat="server" OnClick="btnCloneNewRec4Gv_Click"
                                    Width="44px" CssClass="btn btn-outline-info btn-sm" Text="克隆"></asp:Button>
                            </li>
                            <li class="nav-item ml-2">
                                <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" runat="server"
                                    Width="44px" CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                            </li>
                            <li class="nav-item ml-2">
                                <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" runat="server"
                                    Width="44px" CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                                <%--                            <asp:Button ID="btnBatchUpdate" OnClick="btnBatchUpdate_Click" runat="server"
                                Width="58px" CssClass="auto-style3" Text="批量修改"></asp:Button>--%>
                            </li>
                            <li class="nav-item ml-2">
                                <input id="btnBatchUpdate" onclick="TestShowModal()" style="width: 90px;"
                                    class="btn btn-outline-info btn-sm" value="批量修改" />

                            </li>
                            <li class="nav-item ml-2">
                                <asp:Button ID="btnSetInUse" OnClick="btnSetInUse_Click" runat="server" CssClass="btn btn-outline-info btn-sm" Text="设置在用"></asp:Button>
                            </li>
                            <li class="nav-item ml-2">
                                <asp:Button ID="btnSetIsTemplate" OnClick="btnSetIsTemplate_Click" runat="server" CssClass="btn btn-outline-info btn-sm" Text="设置功能样板"></asp:Button>
                            </li>
                            <li class="nav-item ml-2">
                                <asp:Button ID="btnSetIsFuncTemplate" OnClick="btnSetIsFuncTemplate_Click" runat="server" CssClass="btn btn-outline-info btn-sm" Text="设置函数样板"></asp:Button>
                            </li>
                            <li class="nav-item ml-2">
                                <div class="btn-group" role="group" aria-label="Basic example">
                                    <asp:DropDownList ID="ddlFuncGCTypeId" Width="100px" runat="server" class="form-control-sm"></asp:DropDownList>
                                    <asp:Button ID="btnSetFuncGcType" runat="server"
                                        CssClass="btn btn-outline-info btn-sm" Text="设置代码类型" OnClick="btnSetFuncGcType_Click"></asp:Button>
                                </div>
                            </li>

                            <%-- <td class="NameTD">
                            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">数据源类型</asp:Label>
                        </li>--%>
                            <li class="nav-item ml-2">
                                <div class="btn-group" role="group" aria-label="Basic example">
                                    <asp:DropDownList ID="ddlSqlDsTypeId" Width="100px" runat="server" class="form-control-sm"></asp:DropDownList>
                                    <asp:Button ID="btnSetSqlDsTypeId" runat="server"
                                        Width="90px" CssClass="btn btn-outline-info btn-sm" Text="设置数据源" OnClick="btnSetSqlDsTypeId_Click"></asp:Button>
                                </div>
                            </li>

                            <li class="nav-item ml-2">
                                <asp:Button ID="btnFuncNameParseWord" CssClass="btn btn-outline-info btn-sm" runat="server" OnClick="btnFuncNameParseWord_Click" Text="函数名分词" />
                            </li>
                            <li class="nav-item ml-2">
                                <asp:Button ID="btnTotalWord" CssClass="btn btn-outline-info btn-sm" runat="server" OnClick="btnTotalWord_Click" Text="统计分词数" />
                            </li>
                            <li class="nav-item ml-2">
                                <asp:Button ID="btnParseFeatureId" CssClass="btn btn-outline-info btn-sm" runat="server" OnClick="btnParseFeatureId_Click" Text="分析功能" />
                            </li>
                            <li class="nav-item ml-2">
                                <asp:CheckBox ID="chkDispList4ParseWord" Text="为函数名分词显示列表" Checked="false" AutoPostBack="true" OnCheckedChanged="chkDispList4ParseWord_CheckedChanged" runat="server" />
                            </li>

                        </ul>
                    </div>
                    <div class="mt-1">
                        <ul class="nav">
                            <li class="nav-item">
                                <asp:Label ID="Label3" runat="server"
                                    CssClass="h6" Width="150px"></asp:Label>
                            </li>
                            <li class="nav-item">
                                <div class="btn-group" role="group" aria-label="Basic example">
                                    <asp:DropDownList ID="ddlFeatureId" runat="server" Width="200px" class="form-control-sm"></asp:DropDownList>
                                    <asp:Button ID="btnSetFeatureId" runat="server"
                                        CssClass="btn btn-outline-info btn-sm" Text="设置功能" OnClick="btnSetFeatureId_Click"></asp:Button>
                                </div>
                            </li>
                            <li class="nav-item">
                                <div class="btn-group col-3" role="group" aria-label="Basic example">
                                    <asp:DropDownList ID="ddlFuncId4Code" runat="server" Width="300px" class="form-control-sm"></asp:DropDownList>
                                    <asp:ImageButton ID="ibRefreshFuncId4Code" OnClick="ibRefreshFuncId4Code_Click" runat="server" ImageUrl="~/images/Refresh01.jpg" Height="22px" Width="22px" />
                                    <asp:Button ID="btnSetFuncId4Code" runat="server"
                                        CssClass="btn btn-outline-info btn-sm" Text="设置Code函数" OnClick="btnSetFuncId4Code_Click"></asp:Button>
                                </div>
                            </li>
                            <li class="nav-item ml-2">
                                <asp:Button ID="btnSetCodeTypeByLang" runat="server"
                                    CssClass="btn btn-outline-info btn-sm" Text="设置CodeType" OnClick="btnSetCodeTypeByLang_Click"></asp:Button>
                            </li>
                            <li class="nav-item ml-2">
                                <div class="btn-group col-3" role="group" aria-label="Basic example">
                                    <asp:TextBox ID="txtFuncName4New" runat="server" Width="200px"></asp:TextBox>
                                    <asp:Button ID="btnCopyAndCreateNewFuncName" runat="server"
                                        CssClass="btn btn-outline-info btn-sm" Text="复制并新建新函数名" OnClick="btnCopyAndCreateNewFuncName_Click"></asp:Button>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>

            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:wucvfunction4genecode4gv runat="server" id="wucvFunction4GeneCode4Gv1"
                    ongvupdateclick="wucvFunction4GeneCode4Gv1_GvUpdateClick"
                    ongvdeleteclick="wucvFunction4GeneCode4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditFunction4GeneCodeRegion" class="tab_Edit" runat="server">
                <div>
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditFunction4GeneCode" runat="server" Width="250px"
                                CssClass="h6">生成代码函数编辑区域</asp:Label>
                        </li>

                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelFunction4GeneCodeEdit"
                                runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelFunction4GeneCodeEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit2" runat="server" Width="208px" CssClass="text-warning"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:wucfunction4genecodeb id="wucFunction4GeneCodeB1" runat="server" />
                </div>
            </div>

        </div>
        <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content" style="width: 700px;">
                    <div class="modal-header">
                        <h4 class="modal-title" id="myModalLabel">批量修改</h4>
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>

                    </div>
                    <div class="modal-body">
                        <uc2:wucfunction4gc4batchupdate runat="server" id="wucFunction4GC4BatchUpdate1" />
                    </div>
                    <div class="modal-footer">
                        <asp:Label ID="lblMsgEdit" runat="server"
                            Width="208px" CssClass="text-warning"></asp:Label>
                        <button type="button" class="btn btn-default" data-dismiss="modal">关闭</button>
                        <asp:Button ID="btnClear" CssClass="btn btn-default"
                            runat="server" Width="100px" Text="清空" OnClick="btnClear_Click"></asp:Button>

                        <%--<button type="button" class="btn btn-primary" onclick="mySubmit()">提交更改</button>--%>
                        <asp:Button ID="btnOKBatchUpdate" CssClass="btn btn-primary" runat="server"
                            Width="120px" Text="确认批量修改" OnClick="btnOKBatchUpdate_Click"></asp:Button>
                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal -->
        </div>

        <div class="modal fade" id="divBatchUpdate2" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                        <h4 class="modal-title" id="myModalLabel">模态框（Modal）标题</h4>
                    </div>
                    <div class="modal-body">
                        <div>
                            <table style="width: 60%; height: 300px;" class="msgtable">
                                <tr>
                                    <th style="text-align: left">
                                        <asp:Label ID="Label5" runat="server"
                                            CssClass="h6">函数4GC批量修改</asp:Label>
                                        <asp:Label ID="Label6" runat="server"
                                            Width="208px" CssClass="text-warning"></asp:Label>
                                    </th>
                                    <th style="text-align: right">
                                        <asp:Button ID="Button1" runat="server"
                                            Width="100px" Text="确认批量修改" OnClick="btnOKBatchUpdate_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                    </th>
                                    <th style="text-align: right">
                                        <asp:Button ID="Button3"
                                            runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelFunction4GeneCodeEdit_Click"></asp:Button>
                                    </th>
                                    <th style="text-align: right">
                                        <asp:Button ID="Button4"
                                            runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="清空" OnClick="btnClear_Click"></asp:Button>
                                    </th>
                                </tr>
                            </table>
                        </div>
                        <div>
                            <uc2:wucfunction4gc4batchupdate runat="server" id="wucFunction4GC4BatchUpdate2" />
                        </div>

                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">关闭</button>
                        <button type="button" class="btn btn-primary" onclick="mySubmit()">提交更改</button>
                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal -->
        </div>

    </form>
</body>
</html>
