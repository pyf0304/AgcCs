<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="wfmEditTab.aspx.cs"
    Inherits="AGC.Webform.wfmEditTab" ValidateRequest="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Src="wucPrjTabFld.ascx" TagName="wucPrjTabFld" TagPrefix="uc2" %>
<%@ Register TagPrefix="uc3" TagName="wucPrjTab" Src="wucPrjTab.ascx" %>
<%@ Register TagPrefix="uc4" TagName="wucFieldTab" Src="~/Webform/Field/wucFieldTab.ascx" %>
<%@ Register TagPrefix="uc5" TagName="wucPrjTabFld" Src="wucPrjTabFld.ascx" %>
<%@ Register Src="~/Webform/Table/wucReplaceFieldName.ascx" TagPrefix="uc1" TagName="wucReplaceFieldName" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>

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
    
    
    <link href="../css/AjaxControlToolkit.css" rel="stylesheet" type="text/css" />
    <link href="../css/button.css" rel="stylesheet" type="text/css" />
    <link href="../css/LinkButton.css" rel="stylesheet" type="text/css" />
    <link href="../../css/tz_MenuButton/tz_sccl.css" rel="stylesheet" />
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
        var objDataTypeAbbrBL = new clsDataTypeAbbrBL();
        var divReplace = new TzDiv("divReplace");
        var ddlFldType = new TzSelect("ddlFldType");
        var ddlIsNull = new TzSelect("ddlIsNull");
        var ddlIsPrimaryKey = new TzSelect("ddlIsPrimaryKey");

        var hidDataTypeAbbrObjLstJsonStr = new TzHiddenField("hidDataTypeAbbrObjLstJsonStr");
        var arrDataTypeAbbrObjLst = new Array();

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
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <script type="text/javascript">
            function PanelClick(sender, e) {
                // var Messages = $get('<%=Messages.ClientID%>');
                // Highlight(Messages);
            }
           
            var HighlightAnimations = {};
            function Highlight(el) {
                if (HighlightAnimations[el.uniqueID] == null) {
                    HighlightAnimations[el.uniqueID] = Sys.Extended.UI.Animation.createAnimation({
                        AnimationName: "color",
                        duration: 0.5,
                        property: "style",
                        propertyKey: "backgroundColor",
                        startValue: "#FFFF90",
                        endValue: "#FFFFFF"
                    }, el);
                }
                HighlightAnimations[el.uniqueID].stop();
                HighlightAnimations[el.uniqueID].play();
            }
           
        </script>
        <div style="width: 100%; float: left">
            <div style="width: 91%; float: left">
                <asp:Label ID="lblTabNameObjName" runat="server" CssClass="h5"></asp:Label>
                <asp:Label runat="server" Visible="false" ID="CurrentTab" />
                <asp:LinkButton ID="lbEditTab" runat="server" Visible="false" CssClass="btn btn-outline-info btn-sm">编辑表</asp:LinkButton>
                <asp:LinkButton ID="lbEditView" runat="server" Visible="false" CssClass="btn btn-outline-info btn-sm" OnClick="lbEditView_Click">编辑视图</asp:LinkButton>
                <asp:LinkButton ID="lbEditInterface" runat="server" Visible="false"
                    CssClass="btn btn-outline-info btn-sm" OnClick="lbEditInterface_Click">编辑界面</asp:LinkButton>
                <asp:Literal ID="litEditInterface" runat="server"></asp:Literal>
                <asp:HiddenField ID="hidTabId4ReleView" runat="server" />
                <asp:HiddenField ID="hidTabName4RelaTab" runat="server" />
                <asp:HiddenField ID="hidViewId" runat="server" />
                <br />
                <asp:Label runat="server" Visible="false" ID="Messages" />
            </div>
            <div style="width: 8%; float: right;">
                <asp:Button ID="btnReturnPrjTabList" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnReturnPrjTabList_Click"  ToolTip="返回[工程表列表]" Text="返回"  />
            </div>

        </div>
        <div style="width: 100%; float: left; left: 1px">

            <table id="tabEditPrjTabRegion" runat="server" border="0" cellpadding="1" cellspacing="1"
                style="z-index: 120; width: 750px;">
                <tr runat="server">
                    <td runat="server" class="auto-style3">
                        <div style="width: 730px; position: relative; height: 32px">
                            <asp:Label ID="lblEditPrjTab" runat="server" CssClass="h6"
                                Style="z-index: 104; left: 0px; position: relative; top: 4px">工程表编辑区域</asp:Label><asp:Label ID="lblMsgEdit" runat="server" CssClass="text-warning" Style="z-index: 105; left: 54px; position: relative; top: 8px"
                                    Width="208px"></asp:Label><asp:Button ID="btnOKUpd4Tab" runat="server" CssClass="btn btn-outline-info btn-sm" Style="z-index: 106; left: 68px; position: relative; top: 4px"
                                        Text="添加"  OnClick="btnOKUpd4Tab_Click" />
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
        
        <script src="../../Scripts/jquery-3.6.0.min.js"></script>
        <script type="text/javascript" src="../../js/tz_MenuButton/tz_sccl.js"></script>
        <script type="text/javascript" src="../../js/tz_MenuButton/tz_sccl-util.js"></script>
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
        <script>
            getJsonObjLst();
        </script>
    </form>
</body>
</html>
