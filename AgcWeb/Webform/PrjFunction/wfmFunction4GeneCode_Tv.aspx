<%@ Register TagPrefix="uc1" TagName="wucFunction4GeneCodeB" Src="wucFunction4GeneCodeB.ascx" %>
<%@ Register Src="wucFunction4GC4BatchUpdate.ascx" TagPrefix="uc2" TagName="wucFunction4GC4BatchUpdate" %>
<%@ Register Src="~/Webform/PrjFunction/wucvFunction4GeneCode4Gv.ascx" TagPrefix="uc2" TagName="wucvFunction4GeneCode4Gv" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmFunction4GeneCode_Tv.aspx.cs" Inherits="AGC.Webform.wfmFunction4GeneCode_Tv" ValidateRequest="false" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>函数4GeneCode维护</title>
    <%--      
    --%>
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
    <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
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

</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout" runat="server">
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
                            <asp:TextBox ID="txtFuncId4GCq" Width="150px"
                                runat="server" CssClass="form-control-sm">
                            </asp:TextBox>
                        </td>

                        <td class="auto-style4">
                            <asp:Label ID="lblFuncNameq"
                                runat="server" CssClass="text-secondary">函数名</asp:Label>
                        </td>
                        <td class="auto-style4">
                            <asp:TextBox ID="txtFuncNameq"
                                runat="server" CssClass="form-control-sm" Width="300px"></asp:TextBox>
                        </td>
                        <td class="auto-style5">
                            <asp:Label ID="Label1" runat="server" CssClass="col-form-label text-right">数据源</asp:Label>
                        </td>
                        <td class="auto-style6">
                            <asp:DropDownList ID="ddlSqlDsTypeIdq" Width="150px" runat="server" class="form-control-sm"></asp:DropDownList>
                        </td>
                        <td class="auto-style5">
                            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">函数生成类型</asp:Label>
                        </td>
                        <td class="auto-style6">
                            <asp:DropDownList ID="ddlFuncGCTypeIdq" Width="200px" runat="server" class="form-control-sm"></asp:DropDownList>
                        </td>
                        <td class="auto-style6">
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click"
                                runat="server" CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                        </td>
                    </tr>
                    <tr class="mt-2">

                        <td class="mt-1">
                            <asp:Label ID="lblProgLangTypeIdq"
                                runat="server" CssClass="text-secondary mt-1">语言</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlProgLangTypeIdq"
                                runat="server" CssClass="form-control-sm" Width="150px">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblCodeTypeIdq"
                                runat="server" CssClass="text-secondary">分层类型</asp:Label>
                        </td>
                        <td>
                            <div class="btn-group" role="group" aria-label="Basic example">
                                <asp:DropDownList ID="ddlProgLangTypeId4CodeTypeq"
                                    runat="server" CssClass="TextBox_Defa" AutoPostBack="True" Width="60px" OnSelectedIndexChanged="ddlProgLangTypeId4CodeType_q_SelectedIndexChanged">
                                </asp:DropDownList>
                                <asp:DropDownList ID="ddlCodeTypeIdq" Width="300px"
                                    runat="server" CssClass="form-control-sm">
                                </asp:DropDownList>
                            </div>
                        </td>
                        <td>
                            <asp:CheckBox ID="chkFeatureIdq" runat="server" CssClass="NameLabelRightAlign" Text="功能" Checked="true" />

                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFeatureIdq" Width="150px" runat="server" class="form-control-sm"></asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblFuncTypeID" runat="server" CssClass="col-form-label text-right">函数类型</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFuncTypeIDq" Width="200px" runat="server" class="form-control-sm"></asp:DropDownList>
                        </td>
                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 116; width: 80px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
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

                    </tr>

                </table>
            </div>
            <%-- 列表层 --%>

            <div id="divList" style="width: 100%;" class="div_List mt-2">
                <div id="divFunction" style="width: 100%; height: 82px" runat="server">
                    <div id="tabGridFunction" style="width: 100%; height: 82px">
                        <div>
                            <ul class="nav">

                                <li class="nav-item">
                                    <asp:Label ID="lblFunction4GeneCodeList" runat="server"
                                        CssClass="h6" Width="250px">函数4GeneCode列表</asp:Label>
                                </li>
                                <li class="nav-item ml-2">
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
                                    <div class="btn-group col-3" role="group" aria-label="Basic example">
                                        <asp:DropDownList ID="ddlFuncGCTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
                                        <asp:Button ID="btnSetFuncGcType" runat="server"
                                            CssClass="btn btn-outline-info btn-sm" Text="设置代码类型" OnClick="btnSetFuncGcType_Click"></asp:Button>
                                    </div>
                                </li>
                                <li class="nav-item ml-2">&nbsp;</li>
                                <%-- <td class="NameTD">
                            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">数据源类型</asp:Label>
                        </li>--%>
                                <li class="nav-item ml-2">
                                    <div class="btn-group col-3" role="group" aria-label="Basic example">
                                        <asp:DropDownList ID="ddlSqlDsTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
                                        <asp:Button ID="btnSetSqlDsTypeId" runat="server"
                                            Width="90px" CssClass="btn btn-outline-info btn-sm" Text="设置数据源" OnClick="btnSetSqlDsTypeId_Click"></asp:Button>
                                    </div>
                                </li>
                            </ul>
                        </div>
                        <div class="mt-1">
                            <ul class="nav">
                                <li class="nav-item">
                                    <asp:Label ID="Label3" runat="server"
                                        CssClass="h6" Width="250px"></asp:Label>
                                </li>
                                <li class="nav-item">
                                    <div class="btn-group col-3" role="group" aria-label="Basic example">
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
                <div class="row" style="width: 100%;">
                    <div style="width: 35%;" class="col-3">
                         <div>
                          <%--  <ul class="nav">
                            <li class="nav-item">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="lblPrjIdq" name="lblPrjIdq" CssClass="form-control-sm text-right" Text="工程" runat="server" />
                                    <asp:DropDownList ID="ddlPrjIdq" name="ddlPrjIdq" CssClass="form-control-sm" Width="150px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged" />
                                </div>
                            </li>
                        </ul>--%>
                        <ul class="nav">
                            <li class="nav-item">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="lblUserIdq" name="lblUserIdq" CssClass="form-control-sm text-right" Text="依赖" runat="server" />
                                    <asp:DropDownList ID="ddlDependsOn" CssClass="form-control-sm" Width="100px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDependsOn_SelectedIndexChanged" />
                                </div>
                            </li>
                            <li class="nav-item">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="Label4" CssClass="form-control-sm text-right" Text="分组" runat="server" />
                                    <asp:DropDownList ID="ddlGroupName" CssClass="form-control-sm" Width="100px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlGroupName_SelectedIndexChanged" />
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

                    <div style="width: 65%;" class="col-9">
                        <div id="divList4GC" style="width: 100%;" class="div_List mt-2" runat="server">
                            <uc2:wucvFunction4GeneCode4Gv runat="server" ID="wucvFunction4GeneCode4Gv1"
                                OnGvUpdateClick="wucvFunction4GeneCode4Gv1_GvUpdateClick"
                                OnGvDeleteClick="wucvFunction4GeneCode4Gv1_GvDeleteClick" />
                        </div>
                        <%-- 编辑层 --%>
                        <div id="tabEditFunction4GeneCodeRegion" style="width: 100%;" class="tab_Edit" runat="server">
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
                                        <asp:Label ID="lblMsgEdit" runat="server"
                                            Width="208px" CssClass="text-warning"></asp:Label>
                                    </li>
                                </ul>
                            </div>
                            <div>
                                <uc1:wucFunction4GeneCodeB ID="wucFunction4GeneCodeB1" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
