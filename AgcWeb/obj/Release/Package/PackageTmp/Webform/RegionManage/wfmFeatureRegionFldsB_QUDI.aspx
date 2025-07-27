<%@ Register TagPrefix="uc1" TagName="wucFeatureRegionFldsB" Src="wucFeatureRegionFldsB.ascx" %>
<%@ Register Src="~/Webform/View/wucPrjFeature4Gv.ascx" TagPrefix="uc2" TagName="wucPrjFeature4Gv" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>
<%@ Register TagPrefix="uc2" TagName="wucvFeatureRegionFlds4Gv" Src="wucvFeatureRegionFlds4Gv.ascx" %>
<%@ Register Src="~/Webform/CommonControl/wucFeatureRegionButton4Visible.ascx" TagPrefix="uc1" TagName="wucFeatureRegionButton4Visible" %>
<%@ Register Src="~/Webform/CommonControl/wucFeatureButtonLst.ascx" TagPrefix="uc1" TagName="wucFeatureButtonLst" %>
<%@ Register TagPrefix="uc1" TagName="wucViewFeatureFlds" Src="wucViewFeatureFlds.ascx" %>


<%@ Page Title="功能区域字段列表维护" Language="C#" MasterPageFile="~/Webform/MasterPage/mpViewEdit.Master" AutoEventWireup="True" CodeBehind="wfmFeatureRegionFldsB_QUDI.aspx.cs"
    Inherits="AGC.Webform.wfmFeatureRegionFldsB_QUDI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">
        function GeneCode(strCodeTypeId, strTabId, intApplicationTypeId) {
            //返回长度超过一定数量就不能返回了，怎么办？
            $.ajax({
                type: "post",
                datatype: "json",
                data: '{"strCodeTypeId":"' + strCodeTypeId + '",' +
                    '"strTabId":"' + strTabId + '",' +
                    '"intApplicationTypeId":"' + intApplicationTypeId + '",' +
                    '"strViewId":""}',
                url: "wfmFeatureRegionFldsB_QUDI.aspx/GeneCode",
                contentType: "application/json",
                success: function (result) {
                    ShowCode(result.d);
                }
            });
        }
        function GeneCode4Func(strCodeTypeId, strViewId, strFuncId, intApplicationTypeId) {
            //返回长度超过一定数量就不能返回了，怎么办？
            $.ajax({
                type: "post",
                datatype: "json",
                data: '{"strCodeTypeId":"' + strCodeTypeId + '",' +
                    '"strTabId":"",' +
                    '"strFuncId":"' + strFuncId + '",' +
                    '"intApplicationTypeId":"' + intApplicationTypeId + '",' +
                    '"strViewId":"' + strViewId + '"}',
                url: "wfmFeatureRegionFldsB_QUDI.aspx/GeneCode4Func",
                contentType: "application/json",
                success: function (result) {
                    ShowCode(result.d);
                }
            });
        }

        function ShowCode(strCode) {
            var txtCode = document.getElementById("txtCode");
            var objJSON = JSON.parse(strCode)
            txtCode.value = objJSON.Code;
            var txtClassName4GC = document.getElementById("txtClassName4GC");
            if (txtClassName4GC != null) {
                txtClassName4GC.value = objJSON.ClassName;
            }
            if (txtFileName4GC != null) {
                txtFileName4GC.value = objJSON.FileName;
            }
            //$('#txtCode').val(strCode);
        }

    </script>

    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />
    <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
    <script type="text/javascript">
        var strOperate = "null";
        function ShowModal() {
            $('#divSetProperty').modal('show');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class=" mt-2">
        <ul class="nav">
            <li class="nav-item">
                <asp:Label ID="lblTitle" runat="server" Text="区域信息" Width="100px" CssClass="h6 text-warning"></asp:Label>
            </li>
                    <li class="nav-item ml-2">
                    <div class="btn-group" role="group" aria-label="Basic example">
                        <asp:Label ID="Label5" runat="server" Text="区域宽度:" CssClass="text-primary"></asp:Label>
                        <asp:TextBox ID="txtWidth" runat="server" Width="50px"></asp:TextBox>
                        <%--<asp:Label ID="Label4" runat="server" Text="每行列数:" CssClass="text-primary ml-3"></asp:Label>
                        <asp:TextBox ID="txtColNum" runat="server" Width="50px"></asp:TextBox>--%>
                        <asp:Button ID="btnSetColNum" runat="server"
                            Text="确定" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetColNum_Click"></asp:Button>
                    </div>
                </li>
            <li class="nav-item ml-2">
                <asp:CheckBox ID="chkInUse" Text="是否使用" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
            </li>
        </ul>

    </div>
    <div class="row mt-2" style="width: 100%">
        <div class="col-2">

            <div>

                <uc1:wucFeatureButtonLst runat="server" ID="wucFeatureButtonLst1" />
                <asp:DropDownList ID="ddlRegionTypeId" runat="server"></asp:DropDownList>

                <asp:Button ID="btnConfirmBatchAddFeature" OnClick="btnConfirmBatchAddFeature_Click" runat="server"
                    CssClass="btn btn-outline-primary btn-sm" Text="确认" ToolTip="确认添加功能"></asp:Button>
                <asp:HiddenField ID="hidSelCtrlId" runat="server" />

                <%-- <div class="col-2 ml-2">
                    <div class="btn-group " role="group" aria-label="Basic example">
                        <asp:Button ID="btnRefreshTv" runat="server" class="btn btn-outline-primary btn-sm" Text="刷新" OnClick="btnRefreshTv_Click" />
                    </div>--%>
            </div>

            <div class="row ml-2">
                <uc1:wucTreeView runat="server" ID="wucTreeView1" OnafterSelect_Tz="wucTreeView1_afterSelect_Tz" />
            </div>
        </div>
        <div id="tabLayout" class="col-7">
            <div id="trTitle" runat="server">
                <div id="divTitle" runat="server" style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                    <asp:Label ID="lblViewTitle" runat="server" CssClass="h5">功能区域字段列表维护
                    </asp:Label>
                </div>
            </div>

            <div>
                <div id="tabFeatureRegionFldsGridView" style="width: 100%" runat="server">
                    <div>
                        <ul class="nav">
                            <li class="nav-item">
                                <%--       <asp:Label ID="lblFeatureRegionFldsList" runat="server" CssClass="h6"
                                    Width="220px">功能区域字段列表</asp:Label>--%>
                            </li>

                            <li class="nav-item ml-2">
                                <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click"
                                    Width="45px" CssClass="btn btn-outline-primary btn-sm" Text="添加" Visible="false"></asp:Button>
                            </li>
                            <li class="nav-item ml-2">
                                <asp:Button ID="btnCopyRecord" CssClass="btn btn-outline-primary btn-sm" OnClick="btnCopyRecord_Click" Text="复制" runat="server" Width="45px" />
                            </li>
                            <li class="nav-item ml-2">
                                <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click"
                                    runat="server" Width="45px" CssClass="btn btn-outline-primary btn-sm" Text="删除"></asp:Button>
                            </li>
                            <li class="nav-item ml-2">

                                <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click"
                                    runat="server" Width="45px" CssClass="btn btn-outline-primary btn-sm" Text="修改"></asp:Button>
                            </li>
                            <li class="nav-item ml-2">
                                <div class="btn-group" role="group" aria-label="Basic example">
                                    <asp:Button ID="btnSetInUse" runat="server"
                                        Text="启用" OnClick="btnSetInUse_Click" CssClass="btn btn-outline-primary btn-sm"></asp:Button>

                                    <asp:Button ID="btnSetNotInUse" runat="server"
                                        Text="不用" OnClick="btnSetNotInUse_Click" CssClass="btn btn-outline-primary btn-sm"></asp:Button>
                                </div>

                            </li>
                            <li class="nav-item ml-2">
                                <div class="btn-group" role="group" aria-label="Basic example">
                                    <asp:TextBox ID="txtGroupName" runat="server" Width="80px"></asp:TextBox>
                                    <asp:Button ID="btnSetGroupName" runat="server"
                                        CssClass="btn btn-outline-primary btn-sm" Text="设置组名" OnClick="btnSetGroupName_Click"></asp:Button>
                                </div>
                            </li>
                            <li class="nav-item ml-2">
                                <asp:Button ID="btnCopyFldFromTemplate" runat="server"
                                    Text="复制模板" OnClick="btnCopyFldFromTemplate_Click" CssClass="btn btn-outline-primary btn-sm"></asp:Button>
                            </li>
                            <li class="nav-item ml-2">
                                <div class="btn-group" role="group" aria-label="Basic example">
                                    <asp:Button ID="btnGetTabFeature" runat="server"
                                        Text="获取表功能" OnClick="btnGetTabFeature_Click" CssClass="btn btn-outline-primary btn-sm"></asp:Button>
                                    <asp:Button ID="btnGeneTabFeature" runat="server"
                                        Text="生成表功能" OnClick="btnGeneTabFeature_Click" CssClass="btn btn-outline-primary btn-sm"></asp:Button>
                                </div>
                            </li>
                            <%--    <li class="nav-item ml-2">
                                <asp:Button ID="btnPreView" runat="server" Text="预览" CssClass="btn btn-outline-primary btn-sm"></asp:Button>
                            </li>--%>

                            <li class="nav-item ml-2">
                                <div class="btn-group" role="group" aria-label="Basic example">
                                    <asp:Button ID="btnGoFirstLine" runat="server"
                                        Text="首行" OnClick="btnGoFirstLine_Click" CssClass="btn btn-outline-primary btn-sm"></asp:Button>
                                    <asp:Button ID="btnUpMove" runat="server" Text="上移"
                                        OnClick="btnUpMove_Click" CssClass="btn btn-outline-primary btn-sm"></asp:Button>
                                    <asp:Button ID="btnDownMove" runat="server" Text="下移"
                                        OnClick="btnDownMove_Click" CssClass="btn btn-outline-primary btn-sm"></asp:Button>
                                    <asp:Button ID="btnGoLastLine" runat="server"
                                        Text="尾行" OnClick="btnGoLastLine_Click" CssClass="btn btn-outline-primary btn-sm"></asp:Button>
                                    <asp:Button ID="btnReOrder" runat="server" Text="重序"
                                        OnClick="btnReOrder_Click" CssClass="btn btn-outline-primary btn-sm"></asp:Button>
                                </div>
                            </li>
                            <li class="nav-item ml-2">
                                <%--   <td>
                                        <button class="btn btn-primary" data-toggle="modal" type="button" onclick="ShowModal()">js显示对话框</button>

                                    </td>--%>
                            </li>
                            <li class="nav-item ml-2">
                                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"></asp:Label>
                            </li>
                        </ul>
                    </div>
                    <div class="mt-2">
                        <div>
                            <asp:CheckBoxList ID="cblRegionTypeLst" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="cblRegionTypeLst_SelectedIndexChanged" AutoPostBack="True">
        <asp:ListItem Value="0001">查询区</asp:ListItem>
        <asp:ListItem Selected="True" Value="0008">功能区域</asp:ListItem>
        <asp:ListItem Value="0002">列表区域</asp:ListItem>
    </asp:CheckBoxList>
                            <uc1:wucFeatureRegionButton4Visible runat="server" ID="wucFeatureRegionButton4Visible1" OnselectedIndexChanged="wucFeatureRegionButton4Visible1_selectedIndexChanged"  />
                        </div>
                    </div>
                    <div class="mt-2" style="width: 100%">
                        <ul class="nav nav-tabs" role="navigation">
                            <li class="nav-item active"><a class="nav-link active" href="#tab1" data-toggle="tab" role="tab">列表区字段</a></li>
                            <li class="nav-item"><a class="nav-link" href="#tab2" data-toggle="tab" role="tab">生成代码</a>         </li>
                        </ul>
                        <div class="tab-content">
                            <div class="tab-pane active" id="tab1">
                                <div class="panel panel-default">
                                    <uc2:wucvFeatureRegionFlds4Gv runat="server" ID="wucvFeatureRegionFlds4Gv1"
                                        OnGvUpdateClick="wucvFeatureRegionFlds4Gv1_GvUpdateClick"
                                        OnGvDeleteClick="wucvFeatureRegionFlds4Gv1_GvDeleteClick" />
                                </div>
                            </div>
                            <div class="tab-pane" id="tab2">
                                <div class="panel panel-default">
                                    <div id="Table1" style="width: 100%; float: left;">
                                        <div style="width: 100%; float: left; min-height: 30px;">
                                            <asp:Panel ID="pnlCodeTypeLst" Style="width: 100%; left: 0px; text-align: left; min-height: 30px; line-height: 40px;" runat="server">
                                            </asp:Panel>
                                        </div>
                                        <div style="width: 100%" class="mt-4">
                                            <div id="divCodeRegion" style="width: 100%;" runat="server">
                                                <div id="divCode" style="width: 100%;" class="mt-2">
                                                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                                                    <textarea id="txtCode" style="width: 95%;" rows="25"></textarea>

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>


                </div>
            </div>

            <div>

                <table id="tabQuery" runat="server">
                    <tr>
                        <td>
                            <asp:Label ID="lblButtonNameq" runat="server" Width="90px"
                                CssClass="text-secondary">按钮名称</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtButtonNameq" runat="server" Width="100px"
                                CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblTextq" runat="server" Width="90px"
                                CssClass="text-secondary">文本内容</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtTextq" runat="server" Width="100px"
                                CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblCtlTypeIdq" runat="server" Width="90px"
                                CssClass="text-secondary">控件类型号</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlCtlTypeIdq" runat="server" Width="100px"
                                CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblCssClassq" runat="server" Width="90px"
                                CssClass="text-secondary">样式表</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCssClassq" runat="server" Width="100px"
                                CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnQuery" Style="z-index: 116;" runat="server"
                                Text="查询" CssClass="btn btn-outline-primary btn-sm" OnClick="btnQuery_Click"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click"
                                runat="server" CssClass="btn btn-outline-primary btn-sm" Text="导出Excel"></asp:Button>
                        </td>
                    </tr>
                </table>

            </div>
        </div>
        <div class="col-3">
            <table id="tabEditFeatureRegionFldsRegion" style="z-index: 117; width: 100%;" border="1">
                <tr>
                    <td>
                        <div>
                            <ul class="nav">
                                <li class="nav-item">
                                    <asp:Label ID="lblEditFeatureRegionFlds" Width="150px" runat="server" CssClass="h6">功能编辑</asp:Label>
                                </li>

                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnOKUpd" runat="server" Text="添加"
                                        OnClick="btnOKUpd_Click" CssClass="btn btn-outline-primary btn-sm"></asp:Button>
                                </li>

                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnCancelFeatureRegionFldsEdit" runat="server"
                                        Width="100px" CssClass="btn btn-outline-primary btn-sm" Text="取消编辑" OnClick="btnCancelFeatureRegionFldsEdit_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Label ID="lblMsgEdit" runat="server" CssClass="text-warning"></asp:Label>
                                </li>
                            </ul>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <uc1:wucFeatureRegionFldsB ID="wucFeatureRegionFldsB1" runat="server" />
                    </td>
                </tr>
            </table>
             <table id="tabEditViewFeatureFldsRegion" style="width: 420px" border="1">
                 <%--   <tr>
                        <td>
                            <ul class="nav">
                                <li class="nav-item">
                                    <asp:Label ID="Label4"
                                        runat="server" Width="128px" CssClass="h6">功能字段编辑</asp:Label>
                                </li>

                                <li class="nav-item ml-2">
                                    <asp:Button ID="Button1"
                                        runat="server" CssClass="btn btn-outline-info btn-sm" Width="80px" Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Button ID="Button2" runat="server"
                                        Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelFeatureRegionFldsEdit_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Label ID="lblMsg" CssClass="text-danger" runat="server" Width="208px"></asp:Label>
                                </li>
                            </ul>
                        </td>
                    </tr>--%>
                    <tr>
                        <td>
                            <uc1:wucViewFeatureFlds ID="wucViewFeatureFlds1" runat="server"></uc1:wucViewFeatureFlds>
                        </td>
                    </tr>
                </table>

        </div>
    </div>

    <!-- 模态弹出窗内容 -->
    <div class="modal fade" id="divSetProperty" tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">×</span><span class="sr-only">Close</span></button>
                    <h4 class="modal-title">设置字段值相关属性</h4>
                </div>
                <div class="modal-body">
                    <p>模态弹出窗主体内容</p>
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="设置的字段"></asp:Label></td>

                            <td>
                                <asp:DropDownList ID="ddlRelaFldId" runat="server"></asp:DropDownList></td>

                        </tr>
                        <tr>
                            <td class="NameTD">
                                <asp:Label ID="lblValueGivingModeId" CssClass="text-secondary" Width="90px" Text="给值方式Id" runat="server" />
                            </td>
                            <td class="ValueTD">
                                <asp:DropDownList ID="ddlValueGivingModeId" Width="200px" runat="server" />
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="NameTD">
                                <asp:Label ID="lblFuncName" CssClass="text-secondary" Width="90px" Text="函数名" runat="server" />
                            </td>
                            <td class="ValueTD">
                                <asp:TextBox ID="txtFuncName" class="ValueControl" Width="200px" runat="server" />
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="缺省值"></asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtDefaultValue" runat="server"></asp:TextBox>
                                <asp:RadioButtonList ID="rblBoolValue" runat="server" Visible="false"></asp:RadioButtonList>
                            </td>

                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblErrMsg" CssClass="text-warning" runat="server" Text=""></asp:Label></td>
                        </tr>
                    </table>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">关闭</button>
                    <%--<button type="button" class="btn btn-primary">保存</button>--%>
                    <asp:Button ID="btnSaveSet" runat="server" CssClass="btn btn-primary" Text="保存" OnClick="btnSaveSet_Click" />
                </div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="hidOperate" runat="server"></asp:HiddenField>
    <asp:HiddenField ID="hidCtrlId" runat="server" />
    <asp:Literal ID="litScript" runat="server"></asp:Literal>
    <script>
        function HideEditDialog() {
            //alert('complete');
            $('#divSetProperty').modal('hide');
        }

        function ShowEditDialog() {
            //alert('complete');
            $('#divSetProperty').modal('show');
        }
        function ShowHideEditDialog() {
            console.log('ShowHideEditDialog');
            //var strOperate = $('#hidOperate').val();
            console.log("strOperate" + strOperate);
            if (strOperate == "Add") {
                ShowEditDialog();
            }
            else if (strOperate == "Update") {
                ShowEditDialog();
            }
            else {
                HideEditDialog();
            }
        }
        ShowHideEditDialog();
    </script>
    <script>
        setTimeout(ReSelectFeature(), 1200);
    </script>
    <script>
        setTimeout(ReSelectCtrl(), 1000);
    </script>
</asp:Content>
