<%@ Register TagPrefix="uc1" TagName="wucPrjTab" Src="wucPrjTab.ascx" %>
<%@ Register Src="~/Webform/SystemSet/wucSetFieldVisibilityB_QU.ascx" TagPrefix="uc1" TagName="wucSetFieldVisibilityB_QU" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>
<%@ Register TagPrefix="uc2" TagName="wucvPrjTab4Gv" Src="~/Webform/Table/wucvPrjTab4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmPrjTab_QUDI3.aspx.cs"
    Inherits="AGC.Webform.wfmPrjTab_QUDI3" ValidateRequest="false" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width,initial-scale=1,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no" />
    <meta name="renderer" content="webkit|ie-comp|ie-stand" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta http-equiv="Cache-Control" content="no-siteapp" />
    <meta name="keywords" content="scclui框架" />
    <meta name="description" content="工程表维护" />

    <title>工程表维护</title>
    <script src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />

    <%--    <link href="../../css/button.css" rel="stylesheet" type="text/css" />
    <link href="../../css/LinkButton.css" rel="stylesheet" type="text/css" />--%>
    <%--<link href="../../css/tz_MenuButton/tz_sccl.css" rel="stylesheet" />--%>
    <script src="../../js/tzPubFun.js" type="text/javascript"></script>
    <script src="../../js/PubFun/jsPubVar.js"></script>
    <script src="../../js/PubFun/jsPubFun.js"></script>
    <script src="../../js/PubFun/jsGetElement.js"></script>
    <script src="../../js/PubFun/TzCtrlCls.js"></script>
    <script src="../../js/PubFun/jsTableObjWS4ControllerDelegate.js"></script>
    <script src="../../js/Table_Field/jsvPrjTab_Edit.js"></script>
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />

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
                url: "wfmPrjTab_QUDI3.aspx/GeneCode",
                contentType: "application/json",
                success: function (result) {
                    ShowCode(result.d);
                }
            });
        }
                 function GeneCode4Func(strCodeTypeId, strTabId, strFuncId, intApplicationTypeId) {
            //返回长度超过一定数量就不能返回了，怎么办？
            $.ajax({
                type: "post",
                datatype: "json",
                data: '{"strCodeTypeId":"' + strCodeTypeId + '",' +
                    '"strTabId":"' + strTabId + '",' +
                    '"strFuncId":"' + strFuncId + '",' +
                    '"intApplicationTypeId":"' + intApplicationTypeId + '",' +
                    '"strViewId":""}',
                url: "wfmPrjTab_QUDI3.aspx/GeneCode4Func",
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
    <script type="text/javascript">


        function ChangeLangType(strFunName, strLangType) {
            //if (event.keyCode == 13) {
            //event.cancelBubble = true;
            //event.returnValue = false;
            var lblLangTypeName = getObjByTagAndId("span", "lblLangTypeName");
            if (lblLangTypeName != null) {
                lblLangTypeName.innerHTML = strLangType;
            }
            else {
                alert("找不到lblLangTypeName");
            }
            document.all.FunName.value = strFunName;// "enter";
            document.all.hidLangType.value = strLangType;

            document.forms[0].submit();
            //}
        }
        function ChangeDataBaseType(strFunName, strDataBaseType) {
            //if (event.keyCode == 13) {
            //event.cancelBubble = true;
            //event.returnValue = false;
            document.all.FunName.value = strFunName;// "enter";
            document.all.hidDataBaseType.value = strDataBaseType;

            document.forms[0].submit();
            //}
        }
    </script>
    <script type="text/javascript">
        //自动复制表记录
        var objvPrjTab_Edit = new vcvPrjTab_Edit();

        var tabAllPrjTab = new TzTable("tabAllPrjTab");
        var lblRecNo4AllPrjTab = new TzSpan("lblRecNo4AllPrjTab");
        var strLastTabName = "";
        var strLastTabCnName = "";
        function KeyP_TabName(v) {
            //            document.getElementById("txt").value = v.value;
            var strCurrTabName = v.value;
            if (strCurrTabName !== strLastTabName) {
                getPrjTab();
                strLastTabName = strCurrTabName;
            }
        }
        function KeyP_TabCnName(v) {
            //            document.getElementById("txt").value = v.value;
            var strCurrTabCnName = v.value;
            if (strCurrTabCnName !== strLastTabCnName) {
                getPrjTab();
                strLastTabCnName = strCurrTabCnName;
            }
        }

        //var pub_arrvPrjTabObjLst = null;
        function getPrjTab() {
            objvPrjTab_EditDelegate = new clsTableObjWS4ControllerDelegate();

            objvPrjTab_EditDelegate.GetTopRecordJSONObjLstCorrectFinished = function (returnObjectList, strClassName) {
                pub_vPrjTab_GetTopRecordJSONObjLstCorrectFinished(returnObjectList, strClassName);
            }
            objvPrjTab_Edit.btnGetTopJSONObjLst_Click();
        }
        var inArray = function (arr, item) {
            for (var i = 0; i < arr.length; i++) {
                if (arr[i] == item) {
                    return true;
                }
            }
            return false;
        };
        function DelTabDataRow() {
            var intLen = tabAllPrjTab.getLength();
            for (var i = intLen - 1; i > 0; i--) {
                tabAllPrjTab.deleteRow(i);
            }
        }
        function setRecNo(intLen) {
            var strCondition = "";
            strCondition = objvPrjTab_Edit.Condition;
            var strMsg = String.format("<span color='red'>条件:</span>[{0}]所获取的记录数为:[{1}].", strCondition, intLen);
            lblRecNo4AllPrjTab.setinnerHTML(strMsg);
        }
        function pub_vPrjTab_GetTopRecordJSONObjLstCorrectFinished(returnObjectList, strClassName) {
            var arrvPrjTabObjLst = returnObjectList;
            if (arrvPrjTabObjLst === null) return;
            //var strInfo = String.format("共获取对象列表数：{0}", arrvPrjTabObjLst.length)
            ////显示信息框
            //myAlert(strInfo);
            //删除表的数据行
            DelTabDataRow();
            var intLen = arrvPrjTabObjLst.length;
            setRecNo(intLen);//设置记录数
            var arrTabNameSqlDsTypeName = new Array();
            for (var i = 0; i < intLen; i++) {
                var objvPrjTab = arrvPrjTabObjLst[i];
                var strTabNameSqlDsTypeName = String.format("{0}{1}{2}{3}",
                    objvPrjTab.TabName,
                    objvPrjTab.TabCnName,
                    objvPrjTab.SqlDsTypeName,
                    objvPrjTab.FldNum);
                if (inArray(arrTabNameSqlDsTypeName, strTabNameSqlDsTypeName) === true) {
                    continue;
                }
                var objTr = tabAllPrjTab.insertRow();
                var objTd1 = objTr.insertCell();
                objTd1.setText(objvPrjTab.TabId);
                var objTd2 = objTr.insertCell();
                objTd2.setText(objvPrjTab.TabName);
                objTr.insertCell(objvPrjTab.TabCnName);
                objTr.insertCell(objvPrjTab.FldNum);
                objTr.insertCell(objvPrjTab.SqlDsTypeName);
                objTr.insertCell(objvPrjTab.PrjName);
                var objTd_btn = objTr.insertCell();
                var input = document.createElement("input");
                input.id = String.format("btn{0}", objvPrjTab.TabId);
                input.type = "button";
                input.value = "复制表";
                //var strOnClick = String.format("return InsertNewField('{0}');", objvPrjTab.TabId);
                //var strPara = String.format("'{0}'", objvPrjTab.TabId);
                input.onclick = function () {
                    InsertNewField(this);
                }
                //input.click = strOnClick;

                //input.attributes["onclick"] = strOnClick;
                console.log(input);
                var strButton = input.outerHTML;
                //strButton = String.format("<input type=\"input\" value=\"插入字段\" onclick=\"return InsertNewField('{0}');\" />", objvPrjTab.TabId);
                //                objTd_btn.setHTML(strButton)
                objTd_btn.appendChild(input);
                //  divButton.appendChild(input);
            }
        }
        var hidTabId = new TzHiddenField("hidTabId");
        var btnCopyPrjTab = new TzButton("btnCopyPrjTab");
        function InsertNewField(thisButton) {
            console.log(thisButton);
            var strId = thisButton.id;
            hidTabId.setValue(strId);
            btnCopyPrjTab.click();
        }
    </script>
    <style type="text/css">
        #btnSetFieldLst4Show {
            width: 100px;
        }
    </style>
    <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true">
        </asp:ScriptManager>
        <%-- 标题层 --%>
        <div style="position: relative; width: 100%; height: 35px; left: 0px; top: 0px;">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" Width="242px">表字段管理->项目表维护                    </asp:Label>
                    </td>
                     <td style="text-align: right;">
                        <asp:Label ID="Label1" runat="server" CssClass="text-info  font-weight-bold " Width="70px">CM项目</asp:Label>
                    </td>
                    <td >
                        <asp:DropDownList ID="ddlCmPrjIdq" runat="server" CssClass="text-danger  font-weight-bold" OnSelectedIndexChanged="ddlCmPrjId_q_SelectedIndexChanged" AutoPostBack="true" Width="150px">                        </asp:DropDownList>
                        
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"
                            Width="263px"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>


        <%-- 查询层 --%>

        <div id="divQuery" class="div_query">
            <table id="tabQueryCondition" border="0" style="width: 848px; padding: 2px;"
                width="848" runat="server">
                <tr>
                    <td style="text-align: right;">
                        <asp:Label ID="lblTabNameq" runat="server" CssClass="text-secondary " Width="54px">表名</asp:Label>
                    </td>
                    <td >
                        <asp:TextBox ID="txtTabNameq" runat="server" Width="260px"></asp:TextBox>
                    </td>
                    

                    <td style="text-align: right;">
                        <asp:CheckBox ID="chkFuncModuleIdq" runat="server" CssClass="NameLabelRightAlign" Text="模块" Checked="true" />
                    </td>
                    <td >
                        <asp:DropDownList ID="ddlFuncModuleId" runat="server"
                            Width="100px">
                        </asp:DropDownList>
                    </td>
                    <td ></td>
                    <td >
                        <asp:Button ID="btnSetFuncModule" runat="server" Width="71px" Text="设置模块"
                            OnClick="btnSetFuncModule_Click" CssClass="btn btn-outline-warning btn-sm"></asp:Button>
                    </td>
                    <td ></td>
                    <td style="width: 118px; text-align: right">
                        <asp:CheckBox ID="chkTabStateIdq" runat="server" CssClass="NameLabelRightAlign" Text="表状态" Checked="true" />
                    </td>
                    <td >
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="ddlTabStateIdq" runat="server" Width="100px">
                                </asp:DropDownList>
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="ddlFuncModuleId" EventName="SelectedIndexChanged" />
                            </Triggers>
                        </asp:UpdatePanel>
                    </td>

                    <td style="text-align: right">
                        <asp:Button ID="btnSetTabState" runat="server" Width="71px" Text="设置状态" CssClass="btn btn-outline-warning btn-sm" OnClick="btnSetTabState_Click"></asp:Button>
                    </td>
                    <%--<td >&nbsp;</td>--%>

                       <td style="text-align: right;">
                        <asp:CheckBox ID="chkTabMainTypeIdq" runat="server" CssClass="NameLabelRightAlign" Text="表主类型" Checked="true" />
                    </td>
                    <td >
                        <asp:DropDownList ID="ddlTabMainTypeId" runat="server"
                            Width="100px">
                        </asp:DropDownList>
                    </td>

                    <td style="text-align: right;">
                        <asp:CheckBox ID="chkTabTypeIdq" runat="server" CssClass="NameLabelRightAlign" Text="表类型" Checked="true" />
                    </td>
                    <td >
                        <asp:DropDownList ID="ddlTabTypeId" runat="server"
                            Width="100px">
                        </asp:DropDownList>
                    </td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSetTabTypeId" runat="server" Width="71px" Text="设置类型"
                            OnClick="btnSetTabTypeId_Click" CssClass="btn btn-outline-warning btn-sm"></asp:Button>
                    </td>

                     <td >
                        <asp:Label ID="Label3" runat="server" CssClass="NameLabelRightAlign" Width="46px">主键类型</asp:Label>
                    </td>
                    <td >
                        <asp:DropDownList ID="ddlPrimaryTypeIdq" runat="server" Width="100px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkShowPureClass" runat="server" Text="显示纯粹类" ToolTip="显示与数据库不相关的纯粹类" Width="100px" />
                    </td>
                        <td>
                        <asp:CheckBox ID="chkOnlyShowNotIsReleToSqlTab" runat="server" Text="仅显示Sql无关表" ToolTip="仅仅显示与数据库不相关的表" Width="110px" />
                    </td>
                </tr>
                <tr id="trAdvanceQuery">
                    <td style="text-align: right">
                        <asp:Label ID="lblTabCnNameq" runat="server" CssClass="NameLabelRightAlign" Width="52px">中文名</asp:Label>
                    </td>
                    <td >
                        <asp:TextBox ID="txtTabCnNameq" runat="server" Width="260px"></asp:TextBox>
                    </td>
                    <td >
                        <asp:Label ID="Label6" runat="server" CssClass="NameLabelRightAlign" Width="46px">数据源</asp:Label>
                    </td>
                    <td >
                        <asp:DropDownList ID="ddlSqlDsTypeId" runat="server" Width="100px">
                        </asp:DropDownList>
                    </td>
                    <td ></td>
                    <td style="width: 118px; height: 15px">&nbsp;</td>
                    <td >&nbsp;</td>
                    <td >
                        <asp:Label ID="Label8" runat="server" CssClass="NameLabelRightAlign" Width="81px">使用Cache?</asp:Label>
                    </td>
                    <td >
                        <asp:DropDownList ID="ddlIsUseCache" runat="server"
                            Width="100px">
                        </asp:DropDownList>
                    </td>
                        <td >&nbsp;</td>
                      <td >
                        <asp:Label ID="Label2" runat="server" CssClass="NameLabelRightAlign" Width="81px">Cache类型</asp:Label>
                    </td>
                    <td >
                        <asp:DropDownList ID="ddlCacheModeIdq" runat="server"
                            Width="80px">
                        </asp:DropDownList>
                    </td>
                    <td >
                        <asp:Label ID="lblIncludeFieldNameq" runat="server" Width="69px">包含字段</asp:Label>
                    </td>

                    <td colspan="2">
                        <asp:TextBox ID="txtIncludeFieldName" runat="server" Width="120px" ToolTip="若要模糊查询请以%结尾！"></asp:TextBox>
                    </td>
                    <td colspan="2">
                        <asp:CheckBox ID="chkDispAllErrMsg" runat="server" Width="120px"
                            AutoPostBack="True" OnCheckedChanged="chkDispAllErrMsg_CheckedChanged"
                            Text="显示所有错误" />
                    </td>
                                <td>
                        <asp:CheckBox ID="chkDispProbableErrTab" runat="server" Width="133px"
                            AutoPostBack="True" OnCheckedChanged="chkDispProbableErrTab_CheckedChanged"
                            Text="显示逻辑错误表" />
                    </td>
                    <td>
                        <asp:Button ID="btnQuery" runat="server" OnClick="btnQuery_Click" CssClass="btn btn-outline-warning btn-sm" Text="查询" Width="63px" />
                    </td>
                    <td>
                        <input id="btnSetFieldLst4Show" type="button" style="width: 110px" class="btn btn-outline-warning btn-sm" value="设置显示字段" onclick="Tz_ShowDiv('divSetFieldVisibilityB_QU');" /></td>
                     <td>
                        <asp:Label ID="lblReferedTabName" runat="server" CssClass="NameLabelRightAlign"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>

        <div id="divBaseOperate" runat="server">
            <nav class="navbar navbar-expand-lg navbar-light bg-light">
                <a class="navbar-brand" href="#" style="width: 150px;">基本操作:</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav mr-auto">
                     <%--   <li class="nav-item dropdown ml-2">
                            <a class="nav-link dropdown-toggle btn-sm" href="#" id="navbarDropdown1" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">DotNet
                            </a>
                            <div class="dropdown-menu" aria-labelledby="navbarDropdown1">

                                <a href="javascript:ChangeLangType('ChangeLangType', 'DotNet');" class="dropdown-item btn btn-secondary btn-sm">DotNet</a>
                                <a href="javascript:ChangeLangType('ChangeLangType', 'Java');" class="dropdown-item btn btn-secondary btn-sm">Java</a>
                                <a href="javascript:ChangeLangType('ChangeLangType', 'Swift');" class="dropdown-item btn btn-secondary btn-sm">Swift</a>
                                <a href="javascript:ChangeLangType('ChangeLangType', 'Swift3');" class="dropdown-item btn btn-secondary btn-sm">Swift3</a>
                                <a href="javascript:ChangeLangType('ChangeLangType', 'Swift4');" class="dropdown-item btn btn-secondary btn-sm">Swift4</a>
                                <a href="javascript:ChangeLangType('ChangeLangType', 'JavaScript');" class="dropdown-item btn btn-secondary btn-sm">JavaScript</a>
                                <a href="javascript:ChangeLangType('ChangeLangType', 'SilverLight');" class="dropdown-item btn btn-secondary btn-sm">SilverLight</a>

                            </div>
                        </li>--%>
                <%--        <li class="nav-item dropdown ml-2">

                            <a class="nav-link dropdown-toggle btn-sm" href="#" id="navbarDropdown2" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Ms Sql
                            </a>
                            <div class="dropdown-menu" aria-labelledby="navbarDropdown2">
                                <a href="javascript:ChangeDataBaseType('ChangeDataBaseType', 'Ms Sql');" class="dropdown-item btn btn-secondary btn-sm">Ms Sql</a>
                                <a href="javascript:ChangeDataBaseType('ChangeDataBaseType', 'Oracle');" class="dropdown-item btn btn-secondary btn-sm">Oracle</a>
                                <a href="javascript:ChangeDataBaseType('ChangeDataBaseType', 'MySql');" class="dropdown-item btn btn-secondary btn-sm">MySql</a>
                            </div>
                        </li>--%>
                        <li class="nav-item dropdown ml-2" style="visibility: collapse; display: none;">

                            <a class="nav-link dropdown-toggle btn-sm" href="#" id="navbarDropdown3" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">生成代码
                            </a>
                            <%--   <div class="dropdown-menu" aria-labelledby="navbarDropdown3">
                                <asp:LinkButton ID="lbGeneEntityLayer" runat="server" OnClick="lbGeneEntityLayer_Click" Text="实体层" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbGeneCondEntityLayer" runat="server" OnClick="lbGeneCondEntityLayer_Click" Text="条件实体层" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbGeneDALCode" runat="server" OnClick="lbGeneDALCode_Click" Width="85px" CssClass="btn btn-outline-info btn-sm" Text="数据处理层" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbGeneDALExCode" runat="server" OnClick="lbGeneDALExCode_Click" Width="85px" CssClass="btn btn-outline-info btn-sm" Text="数据处理扩展层" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbGeneBusinessLogicCode" runat="server" OnClick="lbGeneBusinessLogicCode_Click" Text="业务逻辑层" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbGeneBusinessLogicExCode" runat="server" OnClick="lbGeneBusinessLogicExCode_Click" Text="业务逻辑扩展层" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbGeneCommFun4BL" runat="server" OnClick="lbGeneCommFun4BL_Click" Text="逻辑层公共函数" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbGeneWebServiceCode" runat="server" OnClick="lbGeneWebServiceCode_Click" Text="WEB服务层" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbGeneWebServiceTransCode" runat="server" OnClick="lbGeneWebServiceTransCode_Click" Text="WEB服务转换层" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbGeneControllerInvokeWS" runat="server" OnClick="lbGeneControllerInvokeWS_Click"  class="dropdown-item btn btn-secondary btn-sm" Text="控制层(调Web服务转换)" Width="160px"></asp:LinkButton>
                                <asp:LinkButton ID="lbGeneController" runat="server" OnClick="lbGeneController_Click" Text="控制层" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbGeneController4UnitTest" runat="server" OnClick="lbGeneController4UnitTest_Click" Text="控制层4调试" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbGeneDict_PageName_Dir" runat="server" OnClick="lbGeneDict_PageName_Dir_Click" Text="页面目录字典" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                            </div>--%>
                        </li>
                        <li class="menu-bar-nav">
                            <asp:Button ID="btnCheckTabFlds" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnCheckTabFlds_Click" Text="检查表字段" Width="93px" />
                        </li>
                    
                        <li class="nav-item  dropdown ml-2">
                            <a class="nav-link dropdown-toggle btn-sm" href="#" id="navbarDropdown4" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">表操作
                            </a>
                            <div class="dropdown-menu" aria-labelledby="navbarDropdown4">

                                <asp:LinkButton ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" Text="添加" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="btnCloneTab" runat="server" OnClick="btnCloneTab_Click" Text="克隆" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" runat="server" Text="修改" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" runat="server" Text="删除" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbSetKeyFldId" OnClick="lbSetKeyFldId_Click" runat="server" Text="获取表关键字" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbSetIsUseCache" OnClick="lbSetIsUseCache_Click" runat="server" Text="设置使用Cache" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbSetIsNotUseCache" OnClick="lbSetIsNotUseCache_Click" runat="server" Text="设置不使用Cache" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>

                                <asp:LinkButton ID="btnQueryViewReferThisTab" runat="server" OnClick="btnQueryViewReferThisTab_Click" Text="查询引用该表的视图" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="btnQueryReferedTabAndView" runat="server" OnClick="btnQueryReferedTabAndView_Click" Text="查询被引用的表和视图" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                            </div>
                        </li>
                        <%-- <li class="ChildDiv2">
                        <asp:Button ID="lbAddField" runat="server" OnClick="lbAddField_Click" CssClass="btn btn-outline-info btn-sm"
                            Width="73px" Text="维护表字段"></asp:Button>
                    </li>--%>

                        <li class="nav-item  dropdown ml-2">

                            <a class="nav-link dropdown-toggle btn-sm" href="#" id="navbarDropdown5" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">高级操作
                            </a>
                            <div class="dropdown-menu" aria-labelledby="navbarDropdown5">
                                <asp:LinkButton ID="lbDelPrjTabEx" runat="server" OnClick="lbDelPrjTabEx_Click" Visible="False" Text="扩展删除" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbSetSameModuleByObj" runat="server" OnClick="lbSetSameModuleForViewRelaTab_Click" Width="111px" Text="设置视图相关表同模块" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="btnEditEx" runat="server" OnClick="btnEditEx_Click" Text="高级维护" Width="81px" class="dropdown-item btn btn-secondary btn-sm" />
                                <asp:LinkButton ID="lbGeneStoreProcedure" runat="server" OnClick="lbGeneStoreProcedure_Click" Width="89px" Text="生成存储过程" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="lbIsDetailList" runat="server" OnClick="lbIsDetailList_Click" Text="简约列表" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" runat="server" Text="导出Excel" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="btnSetDefaMainTab4View" OnClick="btnSetDefaMainTab4View_Click" runat="server" Width="134px" Text="为视图设置默认主表" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>
                                <asp:LinkButton ID="btnSetDefaKeyFld" runat="server" Width="134px" Text="为视图设置默认主键" OnClick="btnSetDefaKeyFld_Click" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>

                                <asp:LinkButton ID="btnSetFldOrderNum4View" runat="server" Width="134px" Text="为视图设置字段序号" OnClick="btnSetFldOrderNum4View_Click" class="dropdown-item btn btn-secondary btn-sm"></asp:LinkButton>

                            </div>
                        </li>
                        <li class="nav-item ml-2">
                            <asp:Button ID="lbCheckConsistency" runat="server" OnClick="lbCheckConsistency_Click" CssClass="btn btn-outline-info btn-sm" Text="检查一致性"></asp:Button>
                        </li>
                        <li class="nav-item ml-2">
                            <asp:Button ID="lbCheckAllTabField" runat="server" OnClick="lbCheckAllTabField_Click" CssClass="btn btn-outline-info btn-sm" Width="100px" Text="检查所有表字段" Visible="false"></asp:Button>
                        </li>
                        <li class="nav-item ml-2">
                            <asp:Button ID="lbCheckCheckedTabField" runat="server" CssClass="btn btn-outline-info btn-sm" Width="90px" OnClick="lbCheckCheckedTabField_Click" Text="检查所选表"></asp:Button>
                        </li>
                        <li class="nav-item ml-2">
                            <asp:Button ID="btnAddTabFeature" runat="server" CssClass="btn btn-outline-info btn-sm" Width="90px" OnClick="btnAddTabFeature_Click" Text="添加表功能"></asp:Button>
                        </li>
                            <li class="nav-item ml-2">
                            <asp:Button ID="btnGenTabRecNum" runat="server" CssClass="btn btn-outline-info btn-sm" Width="90px" OnClick="btnGenTabRecNum_Click" Text="获取记录数"></asp:Button>
                        </li>
                             <li class="nav-item ml-2">
                            <asp:Button ID="btnGenTabTestKeyValue" runat="server" CssClass="btn btn-outline-info btn-sm" Width="90px" OnClick="btnGenTabTestKeyValue_Click" Text="获取测试关键字"></asp:Button>
                        </li>
                            <li class="nav-item ml-2">
                            <asp:Button ID="btnSetViewTabCnName" runat="server" CssClass="btn btn-outline-info btn-sm" Width="161px" OnClick="btnSetViewTabCnName_Click" Text="设置视图表的中文名"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
<div class="btn-group" role="group" aria-label="Basic example">
<asp:DropDownList id="ddlCacheModeId_SetFldValue" name="ddlCacheModeId_SetFldValue" class="form-control" Width="200px" runat="server" />
<asp:Button id="btnSetCacheModeId" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnSetCacheModeId_Click" Text="设置缓存方式Id" runat="server" />
</div>
</li>
                                         <li class="nav-item ml-3">
<div class="btn-group" role="group" aria-label="Basic example">
<asp:Button id="btnSetIsFresh4RelaView" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnSetIsFresh4RelaView_Click" Text="设置刷新相关视图" runat="server" />
</div>
</li>
                                <li class="nav-item ml-2">
                                     <asp:CheckBox ID="chkDispTabCnName" runat="server" Width="133px"
                            AutoPostBack="True" OnCheckedChanged="chkDispTabCnName_CheckedChanged"
                            Text="显示表中文表" />
                                    </li>
                            <li class="nav-item ml-2">
                            <asp:Button ID="btnEditTabFields" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnEditObjectAndTabFields_Click" Text="综合维护" Width="73px" />
                        </li>
                    </ul>
                </div>
            </nav>
        </div>
        <%-- 列表层 --%>

        <div id="divList" class="div_List" runat="server">
            <uc2:wucvPrjTab4Gv runat="server" ID="wucvPrjTab4Gv1"
                OnGvEditTabFieldsClick="wucvPrjTab4Gv1_GvEditTabFieldsClick" />
        </div>
        <%-- <asp:BoundField DataField="IsNeedGeneIndexer" SortExpression="IsNeedGeneIndexer" HeaderText="生成索引器?"></asp:BoundField>--%>
        <div id="tabEditPrjTabRegion" class="tab_Edit" style="width: 100%"
            runat="server">

            <div style="width: 100%">
                <table style="width: 730px; position: relative; height: 32px">
                    <tr>
                        <td>
                            <asp:Label ID="lblEditPrjTab"
                                runat="server" CssClass="h6">工程表编辑</asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblMsgEdit"
                                runat="server" Width="208px" CssClass="text-warning"></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="btnOKUpd"
                                runat="server" Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="lbDispPrjTabList" Text="显示工程表列表" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="lbDispPrjTabList_Click"                                ></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnCopyPrjTab" runat="server" Visible="false" Width="1px" CssClass="btn btn-outline-info btn-sm" Text="复制工程表" OnClick="btnCopyPrjTab_Click" ForeColor="White"></asp:Button>

                        </td>
                    </tr>
                </table>

            </div>
            <div style="width: 100%">
                <div style="width: 40%; float: left">
                    <uc1:wucPrjTab ID="wucPrjTab1" runat="server"></uc1:wucPrjTab>
                </div>
                <div style="width: 60%; float: right">
                    <asp:Label ID="lblRecNo4AllPrjTab" runat="server" Text=""></asp:Label>
                    <br />
                    <table id="tabAllPrjTab" style="width: 100%">
                        <tr>

                            <td>表Id</td>
                            <td>表名</td>
                            <td>表中文名</td>
                            <td>字段数</td>
                            <td>表类型</td>
                            <td>工程</td>
                        </tr>
                    </table>
                </div>
            </div>

        </div>
        <div id="divCode" runat="server">
            <div id="divTabList" class="div_List" style="float: left; width: 20%">
                <asp:Label ID="lblTabLst" runat="server" Text="所有表" CssClass="h4"></asp:Label>
                <br />
                <uc1:wucTreeView runat="server" ID="wucTreeView4PrjTab" OnafterSelect_Tz="wucTreeView4PrjTab_afterSelect_Tz" />

            </div>
            <div id="divGeneCodeMenu" style="float: left; width: 25%">
                <%-- <uc1:wucTreeView runat="server" ID="wucTreeView1" OnafterSelect_Tz="wucTreeView1_afterSelect_Tz" />--%>
                <asp:Label ID="Label5" runat="server" Text="生成代码" CssClass="h4"></asp:Label>
                <br />
                <uc1:wucTreeView runat="server" ID="wucTreeView1" />
                <div style="width: 300px">

                    <asp:Label ID="Label7" runat="server" Text="App页面类型:"></asp:Label>
                    <asp:DropDownList ID="ddlAppPageTypeId" runat="server" OnSelectedIndexChanged="ddlAppPageTypeId_SelectedIndexChanged"></asp:DropDownList>

                </div>
            </div>
            <div id="divCodeIn" style="float: right; width: 55%">
                <table id="tabCode" border="1" style="width: 90%; height: 618px">
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Font-Names="宋体" Font-Size="Smaller"
                                Width="144px">生成的逻辑层代码：</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtClassName4GC" runat="server" Style="min-width: 200px;"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFileName4GC" runat="server" Style="min-width: 200px;"></asp:TextBox>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbDispTabList" runat="server" Width="150px" CssClass="btn btn-outline-info btn-sm" OnClick="lbDispTabList_Click">显示表名列表</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4">
                            <%--<asp:Literal ID="litCode" runat="server"></asp:Literal>--%>
                            <textarea id="txtCode" style="width: 90%; height: 700px;" rows="2"></textarea>

                        </td>
                    </tr>
                    <tr>
                        <td colspan="4">
                            &nbsp;</td>
                    </tr>
                </table>

            </div>
        </div>
        <div id="divSetFieldVisibilityB_QU" style="visibility: hidden; background-color: gray; z-index: 2000; position: absolute; left: 100px; top: 150px">

            <uc1:wucSetFieldVisibilityB_QU runat="server" ID="wucSetFieldVisibilityB_QU1"
                OnmyClickGetFldLstFromGridView="wucSetFieldVisibilityB_QU1_myClickGetFldLstFromGridView"
                OnmyClickSubmitSet="wucSetFieldVisibilityB_QU1_myClickSubmitSet" />

        </div>

        <%--<script type="text/javascript" src="../../Frame1/Admin/common/lib/jquery-1.9.0.min.js"></script>--%>
        

        <script src="../../Scripts/bootstrap.min.js"></script>
        <script type="text/javascript" src="../../js/tz_MenuButton/tz_sccl.js"></script>
        <script type="text/javascript" src="../../js/tz_MenuButton/tz_sccl-util.js"></script>
        <input type="hidden" name="FunName" />
        <input type="hidden" name="hidLangType" />
        <input type="hidden" name="hidDataBaseType" />
        <asp:HiddenField ID="hidTabId" runat="server" />
    </form>
</body>
</html>
