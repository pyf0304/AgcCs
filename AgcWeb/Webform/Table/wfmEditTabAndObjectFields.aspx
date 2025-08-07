<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="wfmEditTabAndObjectFields.aspx.cs"
    Inherits="AGC.Webform.wfmEditTabAndObjectFields" ValidateRequest="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Src="wucPrjTabFld.ascx" TagName="wucPrjTabFld" TagPrefix="uc2" %>

<%@ Register TagPrefix="uc3" TagName="wucPrjTab" Src="wucPrjTab.ascx" %>
<%@ Register TagPrefix="uc4" TagName="wucFieldTab" Src="~/Webform/Field/wucFieldTab.ascx" %>

<%@ Register Src="~/Webform/Table/wucReplaceFieldName.ascx" TagPrefix="uc1" TagName="wucReplaceFieldName" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>
<%@ Register TagPrefix="uc2" TagName="wucvPrjTabFld4Gv" Src="wucvPrjTabFld4Gv.ascx" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width,initial-scale=1,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no" />

    <meta name="renderer" content="webkit|ie-comp|ie-stand" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta http-equiv="Cache-Control" content="no-siteapp" />
    <meta name="keywords" content="scclui框架" />
    <meta name="description" content="工程表维护" />
    <title>表字段综合维护</title>
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script src="../../Scripts/bootstrap.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />

    <%--    <link href="../css/button.css" rel="stylesheet" type="text/css" />
    <link href="../css/LinkButton.css" rel="stylesheet" type="text/css" />
    <link href="../../css/tz_MenuButton/tz_sccl.css" rel="stylesheet" />--%>
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />

    <script src="../../js/agc.js" type="text/javascript"></script>
    <script src="../../js/tzPubFun.js" type="text/javascript"></script>
    <script src="../../js/PubFun/jsPubVar.js"></script>
    <script src="../../js/PubFun/tzInclude.js"></script>
    <script src="../../js/PubFun/TzCtrlCls.js"></script>
    <script src="../../js/PubFun/jsGetElement.js"></script>
    <script src="../../js/SysPara/jsDataTypeAbbrBL.js"></script>
    <script src="../../js/Table_Field/jsvFieldTab_Edit.js"></script>
    <script type="text/javascript">
        //主要处理字段类型下拉框选项改变时为字段长度和小数位数提供默认值
        var strTabIndexCurr = 1;
        var objDataTypeAbbrBL = new clsDataTypeAbbrBL();
        var divReplace = new TzDiv("divReplace");
        var ddlFldType = new TzSelect("ddlFldType");
        var ddlIsNull = new TzSelect("ddlIsNull");
        var ddlIsPrimaryKey = new TzSelect("ddlIsPrimaryKey");
        var hidDataTypeAbbrObjLstJsonStr = new TzHiddenField("hidDataTypeAbbrObjLstJsonStr");
        var arrDataTypeAbbrObjLst = new Array();
        function onEditTabProperty() {
            var btnEditTabProperty = document.getElementById("btnEditTabProperty");
            btnEditTabProperty.click();
        }
        function ShowTabHome() {

            //$('#txtTest').val('aaaaaaaa');
            //$('#lblTest')[0].innerHTML = 'msg';
            var btn = $('#a_Tab_PrjTabField');
            console.log(btn);
            btn.click();
            $('#a_Tab_PrjTabField').click();
            var strTabName4Show = '#myTab li:eq(' + strTabIndexCurr + ') a'
            $(strTabName4Show).tab('show');
            //            $('#myTab a[href="#ViewPrjTabField"]').tab('show')
        }

        //function GeneCodeBak(strCodeTypeId, strTabId, intApplicationTypeId) {
        //    //返回长度超过一定数量就不能返回了，怎么办？
        //    $.ajax({
        //        type: "post",
        //        datatype: "json",
        //        data: {
        //            strCodeTypeId= strCodeTypeId,
        //            strTabId= strTabId,
        //            strViewId= '',
        //            intApplicationTypeId=intApplicationTypeId
        //        },
        //        url: "wfmEditTabAndObjectFields.aspx/GeneCode",
        //        contentType: "application/json",
        //        success: function (result) {
        //            ShowCode(result.d);
        //        }
        //    });
        //}
        function GeneCode(strCodeTypeId, strTabId, strCmPrjId, intApplicationTypeId) {
            //返回长度超过一定数量就不能返回了，怎么办？
            console.log(strCodeTypeId, strTabId, strCmPrjId, intApplicationTypeId);

            $.ajax({
                type: "post",
                datatype: "json",
                data: '{"strCodeTypeId":"' + strCodeTypeId + '",' +
                    '"strTabId":"' + strTabId + '",' +
                    '"intApplicationTypeId":"' + intApplicationTypeId + '",' +
                    '"strCmPrjId":"' + strCmPrjId + '",' +
                    '"strViewId":""}',
                url: "wfmEditTabAndObjectFields.aspx/GeneCode",
                contentType: "application/json",
                success: function (result) {
                    ShowCode(result.d);
                }
            });
        }
        function GeneCode4Func(strCodeTypeId, strTabId, strFuncId, strCmPrjId, intApplicationTypeId) {
            //返回长度超过一定数量就不能返回了，怎么办？
            $.ajax({
                type: "post",
                datatype: "json",
                data: '{"strCodeTypeId":"' + strCodeTypeId + '",' +
                    '"strTabId":"' + strTabId + '",' +
                    '"strFuncId":"' + strFuncId + '",' +
                    '"strCmPrjId":"' + strCmPrjId + '",' +
                    '"intApplicationTypeId":"' + intApplicationTypeId + '",' +
                    '"strViewId":""}',
                url: "wfmEditTabAndObjectFields.aspx/GeneCode4Func",
                contentType: "application/json",
                success: function (result) {
                    ShowCode(result.d);
                }
            });
        }
        function ShowCode(strCode) {
            var txtCode = document.getElementById("txtCode");
            try {
                var objJSON = JSON.parse(strCode)
                txtCode.value = objJSON.Code;
                var txtClassName4GC = document.getElementById("txtClassName4GC");
                if (txtClassName4GC != null) {
                    txtClassName4GC.value = objJSON.ClassName;
                }
                if (txtFileName4GC != null) {
                    txtFileName4GC.value = objJSON.FileName;
                }
            }
            catch (e) {
                txtCode.value = strCode;
            }
            //$('#txtCode').val(strCode);
        }

        function getJsonObjLst() {
            var strJsonStr = hidDataTypeAbbrObjLstJsonStr.getValue();
            arrDataTypeAbbrObjLst = objDataTypeAbbrBL.getDataTypeAbbrObjLstByJSONStr(strJsonStr)
            //alert(arrDataTypeAbbrObjLst.length);
        }
        function ShowReplace() {
            divReplace.Show();
            //document.all.FunName.value = strFunName;// "enter";
            //document.all.hidMid.value = strMid;
            //document.forms[0].submit();
            //}
        }
        function ddlFldType_OnSelectIndexChange() {
            var strValue = ddlFldType.getSelectedValue();
            var strText = ddlFldType.getSelectedText();
            var intLen = arrDataTypeAbbrObjLst.length;
            var objDataTypeAbbr_Sel = null;
            for (var i = 0; i < intLen; i++) {
                var objDataTypeAbbr = arrDataTypeAbbrObjLst[i];
                if (objDataTypeAbbr.DataTypeId === strValue) {
                    //alert(objDataTypeAbbr.DataTypeId + objDataTypeAbbr.DataTypeName);
                    //return;
                    objDataTypeAbbr_Sel = objDataTypeAbbr;
                }
            }
            if (objDataTypeAbbr_Sel === null) return;
            var txtFldLength = new TzTextBox("txtFldLength");
            var txtFldPrecision = new TzTextBox("txtFldPrecision");
            txtFldLength.setText(objDataTypeAbbr_Sel.DefaFldLength);
            txtFldPrecision.setText(objDataTypeAbbr_Sel.DefaFldPrecision);
            ddlIsNull.SetSelectedItemByIndex(1);
            ddlIsPrimaryKey.SetSelectedItemByIndex(2);
            // alert(strText + strValue);
        }


    </script>
    <script type="text/javascript">
        //主要处理在输入好字段名和字段标题后显示相关字段名供选择
        var objvFieldTab_Edit = new vcvFieldTab_Edit();
        var tabAllPrjFieldTab = new TzTable("tabAllPrjFieldTab");
        var divButton = new TzDiv("divButton");
        function txtFldName_onblur() {
            getFieldTab();
        }
        //var pub_arrvFieldTabObjLst = null;
        function getFieldTab() {
            objvFieldTab_EditDelegate = new clsTableObjWS4ControllerDelegate();
            objvFieldTab_EditDelegate.GetRecordJSONObjLstCorrectFinished = function (returnObjectList, strClassName) {
                pub_vFieldTab_GetRecordJSONObjLstCorrectFinished(returnObjectList, strClassName);
            }
            objvFieldTab_Edit.btnGetJSONObjLst_Click();
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
            var intLen = tabAllPrjFieldTab.getLength();
            for (var i = intLen - 1; i > 0; i--) {
                tabAllPrjFieldTab.deleteRow(i);
            }
        }
        function pub_vFieldTab_GetRecordJSONObjLstCorrectFinished(returnObjectList, strClassName) {
            var arrvFieldTabObjLst = returnObjectList;
            if (arrvFieldTabObjLst === null) return;
            //var strInfo = String.format("共获取对象列表数：{0}", arrvFieldTabObjLst.length)
            ////显示信息框
            //myAlert(strInfo);
            //删除表的数据行
            DelTabDataRow();
            var intLen = arrvFieldTabObjLst.length;
            var arrFldNameCaption = new Array();
            for (var i = 0; i < intLen; i++) {
                var objvFieldTab = arrvFieldTabObjLst[i];
                var strFldNameCaption = String.format("{0}{1}{2}{3}",
                    objvFieldTab.FldName,
                    objvFieldTab.Caption,
                    objvFieldTab.DataTypeName,
                    objvFieldTab.FldLength);
                if (inArray(arrFldNameCaption, strFldNameCaption) === true) {
                    continue;
                }
                else {
                    arrFldNameCaption.push(strFldNameCaption);
                }
                var objTr = tabAllPrjFieldTab.insertRow();
                var objTd1 = objTr.insertCell();
                objTd1.setText(objvFieldTab.FldId);
                var objTd2 = objTr.insertCell();
                objTd2.setText(objvFieldTab.FldName);
                objTr.insertCell(objvFieldTab.Caption);
                objTr.insertCell(objvFieldTab.DataTypeName);
                objTr.insertCell(objvFieldTab.FldLength);
                objTr.insertCell(objvFieldTab.FldPrecision);
                objTr.insertCell(objvFieldTab.PrjName);
                var objTd_btn = objTr.insertCell();
                var input = document.createElement("input");
                input.id = String.format("btn{0}", objvFieldTab.FldId);
                input.type = "button";
                input.value = "插入字段";
                //var strOnClick = String.format("return InsertNewField('{0}');", objvFieldTab.FldId);
                //var strPara = String.format("'{0}'", objvFieldTab.FldId);
                input.onclick = function () {
                    InsertNewField(this);
                }
                //input.click = strOnClick;
                //input.attributes["onclick"] = strOnClick;
                console.log(input);
                var strButton = input.outerHTML;
                //strButton = String.format("<input type=\"input\" value=\"插入字段\" onclick=\"return InsertNewField('{0}');\" />", objvFieldTab.FldId);
                //                objTd_btn.setHTML(strButton)
                objTd_btn.appendChild(input);
                //  divButton.appendChild(input);
            }
        }
        var hidFldId = new TzHiddenField("hidFldId");
        var lbInsNewRec = new TzA("lbInsNewRec");
        function InsertNewField(thisButton) {
            console.log(thisButton);
            var strId = thisButton.id;
            hidFldId.setValue(strId);
            lbInsNewRec.click();
        }
        function InsertRow() {
            var strInfo = String.format("共获取对象列表数：{0}", pub_arrvFieldTabObjLst.length)
            //显示信息框
            myAlert(strInfo);
        }
        var btnOK = new TzButton("btnOK");
        function TestClickByJs() {
            btnOK.click();
        }
        var btnTestAddEvent1 = new TzButton("btnTestAddEvent1");
        var btnTestAddEvent2 = new TzButton("btnTestAddEvent2");
        function TestAddClick1() {
            var objButton2 = btnTestAddEvent2.getObj();
            objButton2.onclick = function () {
                TestAddClick2('111');
            }
        }
        function TestAddClick2(strPara) {
            alert("TestAddClick2();" + strPara);
        }
    </script>
    <script type="text/javascript">
        function GenControlCode() {
            var txtCode = getObjByTagAndId("textarea", "txtCode");
            if (txtCode != null) {
                txtCode.value = "";
            }
            var txtCode_Sim = getObjByTagAndId("textarea", "txtCode_Sim");
            if (txtCode_Sim != null) {
                txtCode_Sim.value = "";
            }
            var divCode = getObjByTagAndId("div", "divCode");
            CallServer("GenControlCode|1!", divCode);
        }
        function GenCtlControlCode() {
            var txtCode = getObjByTagAndId("textarea", "txtCode");
            if (txtCode != null) {
                txtCode.value = "";
            }
            var txtCode_Sim = getObjByTagAndId("textarea", "txtCode_Sim");
            if (txtCode_Sim != null) {
                txtCode_Sim.value = "";
            }
            var divCode = getObjByTagAndId("div", "divCode");
            CallServer("GenCtlControlCode|1!", divCode);
        }
        function ClearText(txtCode) {
            var txtCode = getObjByTagAndId("textarea", "txtCode");
            if (txtCode != null) {
                txtCode.value = "";
            }
            var txtCode_Sim = getObjByTagAndId("textarea", "txtCode_Sim");
            if (txtCode_Sim != null) {
                txtCode_Sim.value = "";
            }
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
    <style type="text/css">
        iframe {
            width: 100%;
            min-width: 1520px;
            height: 100%;
            min-height: 950px;
            border: none;
            background: none;
        }
        /*.myiframe {
            width: 100%;
            height: 100%;
            border: none;
            background: none;
        }*/
    </style>
    <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <ajaxToolkit:ToolkitScriptManager runat="Server" EnablePartialRendering="true" ID="ScriptManager1" />
        <div class="row" style="width: 100%; float: left">

            <ul class="nav">
                <li class="nav-item">
                    <h5>
                        <asp:Label ID="lblTabNameObjName" runat="server"></asp:Label></h5>
                    <asp:Label runat="server" Visible="false" ID="CurrentTab" />

                </li>
                <li class="nav-item ml-2">
                    <asp:LinkButton ID="lbEditTab" runat="server" Visible="false" CssClass="btn btn-outline-info btn-sm">编辑表</asp:LinkButton></li>
                <li class="nav-item  ml-2">
                    <asp:LinkButton ID="lbEditView" runat="server" Visible="false" CssClass="btn btn-outline-info btn-sm" OnClick="lbEditView_Click">编辑视图</asp:LinkButton></li>
                <li class="nav-item  ml-2">
                    <asp:LinkButton ID="lbEditInterface" runat="server" Visible="false"
                        CssClass="btn btn-outline-info btn-sm" OnClick="lbEditInterface_Click">编辑界面</asp:LinkButton></li>
                <li class="nav-item  ml-2">
                    <asp:Literal ID="litEditInterface" runat="server"></asp:Literal></li>
                <li class="nav-item  ml-4">
                    <asp:Button ID="btnReturnPrjTabList" runat="server" CssClass="btn btn-outline-warning btn-sm" OnClick="btnReturnPrjTabList_Click" ToolTip="返回[工程表列表]" Text="返回" />
                </li>
            </ul>


        </div>
        <div class="float-left w-100">
            <ul id="myTab" class="nav nav-tabs" role="tablist">
                <li class="<%=CurrTabClass(0) %>"><a class="<%=CurrTabAClass(0) %>" onclick="onEditTabProperty();" href="#ViewPrjTab" data-toggle="tab" role="tab">表属性</a></li>
                <li class="<%=CurrTabClass(1) %>"><a id="a_Tab_PrjTabField" class="<%=CurrTabAClass(1) %>" href="#View1PrjTabField" data-toggle="tab" role="tab">表字段</a> </li>
                <li class="<%=CurrTabClass(2) %>"><a class="<%=CurrTabAClass(2) %>" href="#Constraint" data-toggle="tab" role="tab">表相关约束</a>                     </li>
                <li class="<%=CurrTabClass(4) %>"><a class="<%=CurrTabAClass(4) %>" href="#TabFeatureFlds" data-toggle="tab" role="tab">表相关功能</a>                     </li>
                <li class="<%=CurrTabClass(5) %>"><a class="<%=CurrTabAClass(5) %>" href="#CheckConsistency" data-toggle="tab" role="tab">检查一致性</a>                     </li>
                <li class="<%=CurrTabClass(6) %>"><a class="<%=CurrTabAClass(6) %>" href="#TabFunctionProp" data-toggle="tab" role="tab">表函数属性</a>                     </li>
                <li class="<%=CurrTabClass(7) %>"><a class="<%=CurrTabAClass(7) %>" href="#ViewGeneCode" data-toggle="tab" role="tab">生成代码</a>                     </li>
                <li class="<%=CurrTabClass(8) %>"><a class="<%=CurrTabAClass(8) %>" href="#ViewGeneStoreProcedure4MSSQL" data-toggle="tab" role="tab">生成存储过程_MSSQL</a></li>
            </ul>
            <div class="tab-content">
                <div class="<%=CurrTabContentClass(0) %>" style="width: 100%" id="ViewPrjTab">
                    <div class="panel panel-default">
                        <table id="tabEditPrjTabRegion" runat="server" border="0" cellpadding="1" cellspacing="1"
                            style="z-index: 120; width: 750px;">
                            <tr runat="server">
                                <td runat="server" class="auto-style3">
                                    <div style="width: 830px; position: relative; height: 32px">
                                        <ul class="nav">
                                            <li class="nav-item">
                                                <asp:Label ID="lblEditPrjTab" runat="server" CssClass="h6" Width="250px"
                                                    Style="z-index: 104;">工程表编辑区域</asp:Label>
                                            </li>

                                            <li class="nav-item ml-3">
                                                <asp:Button ID="btnOKUpd4Tab" runat="server" CssClass="btn btn-outline-info btn-sm" Style="z-index: 106;"
                                                    Text="添加" OnClick="btnOKUpd4Tab_Click" />
                                            </li>
                                            <li class="nav-item ml-3">
                                                <asp:Label ID="lblMsgEdit" runat="server" CssClass="text-warning" Style="z-index: 105;"
                                                    Width="208px"></asp:Label>
                                            </li>
                                        </ul>
                                    </div>
                                </td>
                            </tr>
                            <tr runat="server">
                                <td runat="server" class="auto-style3">
                                    <uc3:wucPrjTab ID="wucPrjTab1" runat="server"></uc3:wucPrjTab>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div class="<%=CurrTabContentClass(1) %>" style="width: 100%" id="View1PrjTabField">
                    <div class="panel panel-default">
                        <div id="tabWhole" style="z-index: 110; left: 4px; width: 100%">

                            <nav class="navbar navbar-expand-lg navbar-light bg-light">
                                <ul class="nav">

                                    <li class="nav-item">
                                        <a class="navbar-brand" href="#" style="width: 80px;">表字段列表</a>
                                    </li>

                                    <li class="nav-item ml-2">
                                        <asp:Button ID="btnRefresh" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnRefresh_Click" Text="刷新" Width="50px"></asp:Button>
                                    </li>
                                </ul>
                                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                                    <span class="navbar-toggler-icon"></span>
                                </button>
                                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                                    <ul class="navbar-nav mr-auto">

                                        <li class="nav-item ml-4">
                                            <div class="btn-group float-right" role="group" aria-label="Basic example">
                                                <asp:TextBox ID="txtFldName_Replace" runat="server" CssClass="form-control-sm" Style="font-size: 15px; color: cornflowerblue;" Width="150px" ToolTip="输入字段名" placeholder="字段名"></asp:TextBox>
                                                <asp:Button ID="btnReplaceFldName" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnReplaceFldName_Click" Text="替换字段"></asp:Button>
                                            </div>
                                        </li>
                                        <li class="nav-item ml-2">
                                            <div class="btn-group float-right" role="group" aria-label="Basic example">

                                                <asp:TextBox ID="txtCaption_New" runat="server" CssClass="form-control-sm" Style="font-size: 15px; color: cornflowerblue;" Width="150px" ToolTip="输入字段标题-中文名" placeholder="字段标题-中文名"></asp:TextBox>
                                                <asp:Button ID="btnSetNewCaption" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetNewCaption_Click" Text="修改标题"></asp:Button>
                                            </div>
                                        </li>
                                        <li class="nav-item ml-2">
                                            <div class="btn-group float-right" role="group" aria-label="Basic example">
                                                <asp:DropDownList ID="ddlFieldTypeId_SetField" runat="server" CssClass="form-control-sm" TabIndex="102"></asp:DropDownList>
                                                <asp:Button ID="btnSetFieldTypeId" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetFieldTypeId_Click" Text="设置字段类型"></asp:Button>
                                            </div>
                                        </li>
                                        <li class="nav-item ml-2">
                                            <div class="btn-group float-right" role="group" aria-label="Basic example">
                                                <asp:DropDownList ID="ddlPrjTab_SetField" runat="server" CssClass="form-control-sm" TabIndex="102"></asp:DropDownList>
                                                <asp:Button ID="btnCopyToPrjTab" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnCopyToPrjTab_Click" Text="复制到表"></asp:Button>
                                            </div>
                                        </li>

                                        <li class="nav-item ml-2">
                                            <div class="btn-group float-right" role="group" aria-label="Basic example">

                                                <asp:TextBox ID="txtRecSeqNum" runat="server" ToolTip="移到序号" placeholder="移到序号" CssClass="form-control-sm" Style="color: cornflowerblue;" Width="60px">0</asp:TextBox>
                                                <asp:Button ID="lbMoveRecTo" runat="server" Width="50px" CssClass="btn btn-outline-info btn-sm" OnClick="lbMoveRecTo_Click" Text="确定"></asp:Button>
                                            </div>
                                        </li>

                                        <li class="nav-item dropdown  ml-2">
                                            <a class="nav-link dropdown-toggle btn-sm" href="#" id="navbarDropdown3" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">排序
                                            </a>
                                            <div class="dropdown-menu" aria-labelledby="navbarDropdown3">
                                                <asp:LinkButton ID="lbMoveToFirst" OnClick="lbMoveToFirst_Click" runat="server" Text="移到第一" class="dropdown-item btn btn-secondary btn-sm" />
                                                <asp:LinkButton ID="lbMoveToLast" OnClick="lbMoveToLast_Click" runat="server" Text="移到最底" class="dropdown-item btn btn-secondary btn-sm" />
                                                <asp:LinkButton ID="lbMoveUp" OnClick="lbMoveUp_Click" runat="server" Text="移到上一条" class="dropdown-item btn btn-secondary btn-sm" />
                                                <asp:LinkButton ID="lbMoveDown" OnClick="lbMoveDown_Click" runat="server" Text="移到下一条" class="dropdown-item btn btn-secondary btn-sm" />
                                                <asp:LinkButton ID="lbReOrder" OnClick="lbReOrder_Click" runat="server" Text="重序" class="dropdown-item btn-sm" />
                                            </div>
                                        </li>

                                        <li class="nav-item dropdown ml-2">
                                            <a class="nav-link dropdown-toggle btn-sm" href="#" id="navbarDropdown2" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">表字段操作
                                            </a>

                                            <div class="dropdown-menu" aria-labelledby="navbarDropdown2">
                                                <asp:LinkButton ID="btnSetTabFldProperty" runat="server" OnClick="btnSetProperty_Click" class="dropdown-item btn-sm" Text="设置表字段" />
                                                <asp:LinkButton ID="btnSetCanNull" runat="server" OnClick="btnSetCanNull_Click" class="dropdown-item btn-sm" Text="设置可空" />
                                                <asp:LinkButton ID="btnSetCanNotNull" runat="server" OnClick="btnSetCanNotNull_Click" class="dropdown-item btn-sm" Text="设置非空" />
                                                <asp:LinkButton ID="btnSetIsForExtendClass" runat="server" OnClick="btnSetIsForExtendClass_Click" class="dropdown-item btn-sm" Text="设置针对扩展类" />
                                                <asp:LinkButton ID="btnSetIsNotForExtendClass" runat="server" OnClick="btnSetIsNotForExtendClass_Click" class="dropdown-item btn-sm" Text="设置针对非扩展类" />
                                                <asp:LinkButton ID="lbSetIsSortFld" runat="server" OnClick="lbSetIsSortFld_Click" class="dropdown-item btn-sm" Text="设置排序字段" />
                                                <asp:LinkButton ID="lbSetIsNotSorFld" runat="server" OnClick="lbSetIsNotSorFld_Click" class="dropdown-item btn-sm" Text="设置非排序字段" />
                                                <asp:LinkButton ID="lbSetIsSynField" runat="server" OnClick="lbSetIsSynField_Click" class="dropdown-item btn-sm" Text="设置同步字段" />
                                                <asp:LinkButton ID="lbSetIsNotSynField" runat="server" OnClick="lbSetIsNotSynField_Click" class="dropdown-item btn-sm" Text="设置非同步字段" />
                                                <asp:LinkButton ID="btnAdd" runat="server" OnClick="btnAdd_Click" class="dropdown-item btn-sm" Text="添加表字段" />
                                                <asp:LinkButton ID="btnDelRec" runat="server" class="dropdown-item btn-sm" OnClick="btnDelRec_Click" Text="删除表字段" />
                                                <asp:LinkButton ID="Button1" runat="server" OnClick="btnSetFldProperty_Click" class="dropdown-item btn-sm" Text="设置字段属性" />
                                                <a id="lbReplace" href="javascript:ShowReplace()" class="dropdown-item btn-sm">替换字段</a>

                                                <asp:LinkButton ID="lbCheckField" runat="server" OnClick="lbCheckField_Click" class="dropdown-item btn-sm">检查字段</asp:LinkButton>
                                                <asp:LinkButton ID="lbCopyField" runat="server" OnClick="lbCopyField_Click" class="dropdown-item btn-sm">复制</asp:LinkButton>
                                            </div>
                                        </li>
                                        <li class="nav-item" style="display: none">
                                            <asp:Button ID="btnCheckConsistency" runat="server" OnClick="btnCheckConsistency_Click" Text="检查一致性" Width="90px"></asp:Button>
                                        </li>
                                        <li class="nav-item">
                                            <asp:Button ID="btnImportExtendFld" runat="server" OnClick="btnImportExtendFld_Click" Text="导入扩展字段" Width="90px"></asp:Button>
                                        </li>
                                        <li class="nav-item dropdown ml-2">
                                            <a class="nav-link dropdown-toggle btn-sm" href="#" id="navbarDropdown4" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">表视图操作
                                            </a>
                                            <div class="dropdown-menu" aria-labelledby="navbarDropdown4">
                                                <asp:LinkButton ID="btnSetFldOrderNum4View" runat="server" OnClick="btnSetFldOrderNum4View_Click" Text="为视图设置序号" class="dropdown-item btn-sm" />
                                                <asp:LinkButton ID="btnCreateView4Sql" runat="server" OnClick="btnCreateView4Sql_Click" Text="建立视图4Sql" class="dropdown-item btn-sm" />
                                                <asp:LinkButton ID="btnImportSqlViewFromSqlServer" runat="server" OnClick="btnImportSqlViewFromSqlServer_Click" Text="导入SQL视图" class="dropdown-item btn-sm" />
                                                <asp:LinkButton ID="btnAnalysis" runat="server" OnClick="btnAnalysis_Click" Text="分析字段" class="dropdown-item btn-sm" />
                                            </div>
                                        </li>
                                        <%--   <li class="nav-item dropdown ml-2">
                                            <a class="nav-link dropdown-toggle btn-sm" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">导出
                                            </a>
                                            <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                                                <asp:LinkButton ID="btnExportExcel" runat="server" OnClick="btnExportExcel_Click" Text="导出Exl" class="dropdown-item btn-sm" />
                                                <asp:LinkButton ID="btnSetExportExcel4User" runat="server" OnClick="btnSetExportExcel4User_Click" Text="设置导出字段" class="dropdown-item btn-sm" />
                                            </div>
                                        </li>--%>

                                        <li class="nav-item">
                                            <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"></asp:Label>
                                        </li>
                                    </ul>

                                </div>
                            </nav>
                            <div id="tabPrjTabFld" runat="server" style="width: 100%">
                                <div runat="server" style="width: 100%">
                                    <div style="float: left; width: 95%">

                                        <uc2:wucvPrjTabFld4Gv runat="server" ID="wucvPrjTabFld4Gv1"
                                            OnGvUpdateClick="wucvPrjTabFld4Gv1_GvUpdateClick"
                                            OnGvUpdateFieldClick="wucvPrjTabFld4Gv1_GvUpdateFieldClick"
                                            OnGvDeleteClick="wucvPrjTabFld4Gv1_GvDeleteClick" />


                                    </div>
                                    <div style="float: right; width: 5%; height: 80%" runat="server">
                                        <div style="width: 33px; position: relative; height: 136px; vertical-align: middle; margin-top: 100px">
                                            <asp:ImageButton ID="ibDown" runat="server" Height="28px" ImageUrl="~/pic/Down.JPG" OnClick="ibDown_Click" Style="z-index: 101; left: 0px; position: absolute; top: 48px" Width="24px"></asp:ImageButton>
                                            <asp:ImageButton ID="ibUp" runat="server" Height="28px" ImageUrl="~/pic/Up.JPG" OnClick="ibUp_Click" Style="z-index: 102; left: 0px; position: absolute; top: 8px" Width="24px"></asp:ImageButton>
                                            <asp:Button ID="btnReOrder" runat="server" Height="40px" OnClick="btnReOrder_Click" Style="z-index: 103; left: 0px; position: absolute; top: 88px" Text="重序" Width="30px"></asp:Button>
                                        </div>
                                    </div>
                                </div>
                                <div style="width: 100%; position: relative; height: 26px">
                                    <asp:Label ID="lblMsg4" runat="server" ForeColor="Red" Style="z-index: 102; left: 584px; position: absolute; top: 0px" Width="85px"></asp:Label>
                                </div>
                                <div style="width: 100%; float: left">
                                    <table style="width: 1087px; position: relative; height: 28px">
                                        <tr>
                                            <td>
                                                <asp:TextBox ID="txtFldName" runat="server" CssClass="form-control-sm" TabIndex="100" Width="144px" placeholder="字段名"></asp:TextBox>
                                                <ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" CompletionSetCount="20"
                                                    Enabled="True" MinimumPrefixLength="2" ServiceMethod="GetCompleteList" ServicePath="~/WebService/WS_FieldName.asmx"
                                                    TargetControlID="txtFldName" DelimiterCharacters="">
                                                </ajaxToolkit:AutoCompleteExtender>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtCaption" runat="server" CssClass="form-control-sm" TabIndex="101" Width="100px" ToolTip="输入字段标题-中文名" placeholder="字段标题-中文名"></asp:TextBox>
                                                <img alt="" src="../../pic/timg.jpg" style="width: 20px; height: 20px" onclick="txtFldName_onblur();" />
                                            </td>
                                            <td></td>
                                            <td>
                                                <asp:DropDownList ID="ddlFldType" runat="server" CssClass="form-control-sm" TabIndex="102"></asp:DropDownList>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtFldLength" runat="server" CssClass="form-control-sm" Width="66px" TabIndex="103" ToolTip="输入字段长度" placeholder="字段长度"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtFldPrecision" runat="server" CssClass="form-control-sm" TabIndex="103" Width="50px" placeholder="0,小数位数" ToolTip="输入小数位数"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="ddlIsNull" runat="server" CssClass="form-control-sm" Width="66px"></asp:DropDownList>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="ddlIsPrimaryKey" runat="server" CssClass="form-control-sm" ToolTip="是否为主键"></asp:DropDownList>
                                            </td>
                                            <td>
                                                <asp:LinkButton ID="lbInsNewRec" runat="server" OnClick="lbInsNewRec_Click" CssClass="btn btn-info btn-sm">插入新记录</asp:LinkButton>
                                            </td>
                                            <td>
                                                <asp:LinkButton ID="lbRefresh" runat="server" OnClick="lbRefresh_Click" CssClass="btn btn-info btn-sm">刷新自动输入列表</asp:LinkButton>
                                            </td>
                                        </tr>
                                    </table>
                                    <asp:Label ID="lblMsg4AddRecord" runat="server" CssClass="text-warning" Width="568px"></asp:Label>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFldLength"
                                        CssClass="text-warning" Enabled="False" ErrorMessage="字段长度不能为空!"></asp:RequiredFieldValidator>
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtFldLength"
                                        CssClass="text-warning" ErrorMessage="请输入整型值" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                </div>
                                <div style="width: 100%; float: left">
                                    <asp:Label ID="Label1" runat="server" Text="在其他工程中已经存在类似的字段，你可以挑选后直接插入！"></asp:Label>
                                    <br />
                                    <table id="tabAllPrjFieldTab" style="width: 100%;">
                                        <tr>
                                            <td>序号</td>
                                            <td>字段名</td>
                                            <td>标题</td>
                                            <td>类型</td>
                                            <td>长度</td>
                                            <td>小数位数</td>
                                            <td>项目</td>
                                            <td></td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                            <div id="tabEditPrjTabFld" runat="server" style="width: 100%; height: 83px" width="240">
                                <div style="width: 60%;">
                                    <ul class="nav">
                                        <li class="nav-item">
                                            <asp:Label ID="Label4" runat="server" CssClass="text-secondary" Width="300px" Style="z-index: 103; width: 300px;">表字段编辑</asp:Label>
                                        </li>

                                        <li class="nav-item ml-3">
                                            <asp:Button ID="btnOKEdit" runat="server" OnClick="btnOKEdit_Click"
                                                Text="确定修改" CssClass="btn btn-outline-info btn-sm" />
                                        </li>
                                        <li class="nav-item ml-3">
                                            <asp:LinkButton ID="lbDispTabFld2" runat="server" OnClick="lbDispTabFld2_Click"
                                                Style="z-index: 104;"
                                                CssClass="btn btn-outline-info btn-sm">显示表字段</asp:LinkButton>
                                        </li>
                                        <li class="nav-item ml-3">
                                            <asp:Label ID="lblMsgEdit3" runat="server" CssClass="text-warning" Width="345px"></asp:Label>
                                        </li>
                                    </ul>
                                </div>
                                <div runat="server" style="width: 100%; float: left">
                                    <uc2:wucPrjTabFld ID="wucPrjTabFld1" runat="server"></uc2:wucPrjTabFld>
                                </div>
                            </div>
                            <div id="tabFieldTab" runat="server" style="width: 100%">
                                <div runat="server" style="width: 100%">
                                    <table style="width: 100%;">
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label10" runat="server" Style="z-index: 103;">源工程字段列表</asp:Label>
                                            </td>
                                            <td></td>
                                            <td></td>
                                            <td colspan="2"></td>
                                            <td>
                                                <asp:LinkButton ID="lbDispTabFld" runat="server" OnClick="lbDispTabFld_Click">显示表字段</asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td></td>
                                            <td>
                                                <asp:Label ID="Label6" runat="server" CssClass="text-secondary" Font-Names="宋体"
                                                    Width="35px">相关表</asp:Label>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="ddlPrjTab" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPrjTab_SelectedIndexChanged"
                                                    Width="189px">
                                                </asp:DropDownList>
                                            </td>
                                            <td>
                                                <asp:Label ID="lblFldID" runat="server">字段名称</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtFldNameq" runat="server" class="form-control-sm" Style="" Width="109px"></asp:TextBox>
                                            </td>
                                            <td>
                                                <asp:Button ID="btnQuery" runat="server" OnClick="btnQuery_Click" Style="" Text="查询"
                                                    Width="77px" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td></td>
                                            <td colspan="4">
                                                <asp:Label ID="lblMsg1" runat="server" CssClass="text-warning" ForeColor="Red" Height="19px"
                                                    Style="z-index: 105; margin-bottom: 0px;" Width="105px"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Button ID="btnOkAdd" runat="server" OnClick="btnOkAdd_Click"
                                                    Text="确认添加" />
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <div runat="server" style="width: 100%; float: left">
                                    <asp:DataGrid ID="dgFieldTab4Sel" runat="server" AllowPaging="True" AllowSorting="True"
                                        AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
                                        BorderWidth="1px" CellPadding="1" CellSpacing="1" CssClass="table table-striped table-bordered table-condensed" OnItemCreated="dgFieldTab4Sel_ItemCreated"
                                        OnItemDataBound="dgFieldTab4Sel_ItemDataBound" OnPageIndexChanged="dgFieldTab4Sel_PageIndexChanged"
                                        OnSortCommand="dgFieldTab4Sel_SortCommand" Width="100%">
                                        <Columns>
                                            <asp:TemplateColumn HeaderText="选择">
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="ckb1" runat="server" />
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:BoundColumn DataField="FldId" HeaderText="字段编号" Visible="False"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="FldName" HeaderText="字段名称" SortExpression="FldName"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="Caption" HeaderText="标题"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="DataTypeName" HeaderText="字段类型" SortExpression="DataTypeName"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="FldLength" HeaderText="字段长度" SortExpression="FldLength"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="IsNull" HeaderText="是否为空" SortExpression="IsNull"></asp:BoundColumn>
                                        </Columns>
                                        <FooterStyle BackColor="White" ForeColor="#000066" />
                                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                        <ItemStyle ForeColor="#000066" />
                                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" Mode="NumericPages" />
                                        <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                    </asp:DataGrid>
                                </div>
                                <div id="divTabFld4Sel" style="width: 100%; float: left; height: 22px">
                                    <asp:Label ID="Label5" runat="server" Font-Names="宋体" Font-Size="Smaller"
                                        Style="z-index: 101; left: 0px; position: absolute; top: 0px" Width="56px">记录数：</asp:Label>
                                    <asp:TextBox ID="txtRecCount_PrjTabFld" runat="server" CssClass="form-control-sm" Font-Names="宋体"
                                        Font-Size="Smaller" ReadOnly="True" Style="z-index: 102; left: 64px; position: absolute; top: 0px"></asp:TextBox>
                                    <asp:CheckBox ID="chkSelAll" runat="server" AutoPostBack="True" CssClass="text-secondary"
                                        OnCheckedChanged="chkSelAll_CheckedChanged" Style="z-index: 103; left: 120px; position: absolute; top: 0px"
                                        Text="全选" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="<%=CurrTabContentClass(2) %>" id="Constraint">
                    <iframe id="myIframe1" src="wfmPrjConstraintB_QUDI.aspx?TabId=<%# vsTabId %>" name="content" class="myiframe" runat="server"></iframe>
                </div>

                <div class="<%=CurrTabContentClass(4) %>" id="TabFeatureFlds">
                    <iframe id="myIframe4" src="wfmTabFeatureFldsB_QUDI.aspx?TabId=<%# vsTabId %>" name="content" class="myiframe" runat="server"></iframe>
                </div>
                <div class="<%=CurrTabContentClass(5) %>" id="CheckConsistency">
                    <iframe id="myIframe3" src="wfmPrjTab_CheckConsistency.aspx?TabId=<%# vsTabId %>" name="content" class="myiframe" runat="server"></iframe>
                </div>
                <div class="<%=CurrTabContentClass(6) %>" id="TabFunctionProp">
                    <iframe id="myIframe6" src="wfmTabFunctionProp_QUDI.aspx?TabId=<%# vsTabId %>" name="content" class="myiframe" runat="server"></iframe>
                </div>
                <div class="<%=CurrTabContentClass(7) %>" id="ViewGeneCode">
                    <div class="panel panel-default">
                        <table style="width: 100%">
                            <tr>
                                <td>
                                    <div id="divBaseOperate" class="row" runat="server" style="width: 100%; height: 40px">
                                        <div class="col-2"><span class="h6">生成代码:</span></div>
                                        <div class="col-5">
                                            <asp:Label ID="lblErrMsg4AGC" runat="server" CssClass="text-warning" Width="849px"></asp:Label>
                                        </div>

                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div id="divCode" runat="server">
                                        <div id="divGeneCodeMenu" style="float: left; width: 30%">
                                            <uc1:wucTreeView runat="server" ID="wucTreeView1" OnafterSelect_Tz="wucTreeView1_afterSelect_Tz" />
                                            <%--<uc1:wucTreeView runat="server" ID="wucTreeView1" />--%>
                                        </div>
                                        <div id="divCodeIn" style="float: right; width: 70%">
                                            <table id="tabCode" border="1" style="width: 90%; height: 618px">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label3" runat="server" Font-Names="宋体" Font-Size="Smaller"
                                                            Width="144px">生成的逻辑层代码：</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txtClassName4GC" runat="server" Style="min-width: 200px;"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="txtFileName4GC" runat="server" Style="min-width: 200px;"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="3">

                                                        <%--                                                        <asp:Literal ID="litCode" runat="server"></asp:Literal>--%>
                                                        <textarea id="txtCode" style="width: 80%; height: 700px;" cols="20" rows="2"></textarea>
                                                    </td>
                                                </tr>
                                                <%--   <tr>
                                                    <td colspan="2">
                                                        <asp:TextBox ID="txtCode_Sim" runat="server" Height="250px" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                    </td>
                                                </tr>--%>
                                            </table>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div class="<%=CurrTabContentClass(8) %>" id="ViewGeneStoreProcedure4MSSQL">
                    <div class="panel panel-default">
                        <table style="width: 100%">
                            <tr>
                                <td class="style3">
                                    <asp:CheckBox ID="chkStoreProcedure_Add" runat="server" Style="left: -6px; top: 66px"
                                        Text="表存储过程--Add(添加)" /></td>
                                <td>
                                    <asp:Label ID="lblMsg_Add" runat="server" CssClass="text-warning" Width="422px"></asp:Label></td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <asp:CheckBox ID="chkStoreProcedure_Update" runat="server" Text="表存储过程--Update(修改)" /></td>
                                <td>
                                    <asp:Label ID="lblMsg_Update" runat="server" CssClass="text-warning" Width="424px"></asp:Label></td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <asp:CheckBox ID="chkStoreProcedure_Delete" runat="server" Text="表存储过程--Delete(删除)" /></td>
                                <td>
                                    <asp:Label ID="lblMsg_Delete" runat="server" CssClass="text-warning" Width="422px"></asp:Label></td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <asp:CheckBox ID="chkStoreProcedure_Select" runat="server" Style="left: -451px; top: 63px"
                                        Text="表存储过程--Select(查询)" /></td>
                                <td>
                                    <asp:Label ID="lblMsg_Select" runat="server" CssClass="text-warning" Width="422px"></asp:Label></td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <asp:CheckBox ID="chkStoreProcedure_SelectOne" runat="server" Style="left: -55px; top: 80px"
                                        Text="表存储过程--SelectOne(查询一条)" /></td>
                                <td>
                                    <asp:Label ID="lblMsg_SelectOne" runat="server" CssClass="text-warning" Width="422px"></asp:Label></td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <asp:CheckBox ID="chkStoreProcedure_SelectByCond" runat="server" Style="left: -6px; top: 47px"
                                        Text="表存储过程--SelectByCond(查询条件)" /></td>
                                <td>
                                    <asp:Label ID="lblMsg_SelectByCond" runat="server" CssClass="text-warning" Width="422px"></asp:Label></td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <asp:CheckBox ID="chkStoreProcedure_IsExist" runat="server" Text="表存储过程--IsExist(查询条件)" /></td>
                                <td>
                                    <asp:Label ID="lblMsg_IsExist" runat="server" CssClass="text-warning" Width="422px"></asp:Label></td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <asp:CheckBox ID="chkStoreProcedure_SelTop1ByCond" runat="server" Style="left: -114px; top: 225px"
                                        Text="表存储过程--SelTop1ByCond(查询Top)" /></td>
                                <td>
                                    <asp:Label ID="lblMsg_SelTop1ByCond" runat="server" CssClass="text-warning" Width="422px"></asp:Label></td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <asp:Button ID="btnGeneStoreProcedure" runat="server" OnClick="btnGeneStoreProcedure_Click"
                                        Text="生成存储过程" Width="150px" /></td>
                                <td>
                                    <asp:Button ID="btnGeneSPXmlPara" runat="server" OnClick="btnGeneSPXmlPara_Click"
                                        Text="生成存储过程XML参数" Width="200px" /><asp:Label ID="lblMsg4GeneStoreProcedure" runat="server" CssClass="text-warning" Width="276px"></asp:Label></td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:TextBox ID="txtCode4StoreProcedure" runat="server" Height="270px" TextMode="MultiLine"
                                        Width="100%"></asp:TextBox></td>
                                <td>
                                    <asp:Button ID="btnEditTabProperty" runat="server" Text="Button" OnClick="btnEditTabProperty_Click" Width="1px" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>


        <input type="hidden" name="FunName" />
        <input type="hidden" name="hidLangType" />
        <input type="hidden" name="hidDataBaseType" />
        <div id="divReplace" class="myDiv" style="position: absolute; display: none; visibility: hidden; left: 50px; top: 100px; height: 200px; width: 500px;">
            <table id="Table2" style="z-index: 107; width: 100%;" border="0">
                <tr>
                    <td style="text-align: right" colspan="2"></td>
                </tr>
                <tr>
                    <td style="text-align: right">
                        <asp:Label ID="Label14" Style="z-index: 102; left: 8px;"
                            runat="server" CssClass="NameLabel2">原字段名称</asp:Label></td>
                    <td style="text-align: left">
                        <asp:TextBox ID="txtSourceField" runat="server" CssClass="ValueLabel2" Width="200px"> </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px; text-align: right">
                        <asp:Label ID="Label20"
                            runat="server" CssClass="NameLabel2">目标字段名称</asp:Label></td>
                    <td class="auto-style2" style="text-align: left">
                        <asp:TextBox ID="txtTargetField" runat="server" CssClass="ValueLabel2" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="1"></td>
                    <td style="text-align: left">
                        <asp:Button ID="btnSumbitReplace" runat="server" Text="确认替换" OnClick="btnSumbitReplace_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:HiddenField ID="hidDataTypeAbbrObjLstJsonStr" runat="server" />
        <asp:HiddenField ID="hidFldId" runat="server" />
        <asp:HiddenField ID="hidTabId4ReleView" runat="server" />
        <asp:HiddenField ID="hidTabName4RelaTab" runat="server" />
        <asp:HiddenField ID="hidViewId" runat="server" />
        <script src="../../Scripts/bootstrap.min.js"></script>
        <asp:Literal ID="litTabIndex" runat="server"></asp:Literal>
        <script>
            getJsonObjLst();
            //ShowTabHome();
            //$('#myTab li:eq(1) a').tab('show');
        </script>
    </form>
</body>
</html>
