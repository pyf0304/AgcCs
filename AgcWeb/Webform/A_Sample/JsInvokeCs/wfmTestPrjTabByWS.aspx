<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="wfmTestPrjTabByWS.aspx.cs"
    Inherits="AGC.Webform.JsInvokeCs.wfmTestPrjTabByWS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <script src="../../js/PubFun/jsPubVar.js"></script>
    <script src="../../js/PubFun/jsPubFun.js"></script>
    <script src="../../js/PubFun/jsGetElement.js"></script>
    <script src="../../js/PubFun/TzCtrlCls.js"></script>
    <script src="../../js/PubFun/jsTableObjWS4ControllerDelegate.js"></script>
    <script src="../../js/Table_Field/jsvPrjTab_Edit.js"></script>

    <script>

        var objvPrjTab_Edit = new vcvPrjTab_Edit();
        var lblRecNo4AllPrjTab = new TzSpan("lblRecNo4AllPrjTab");
        var tabPrjTab = new TzTable("tabPrjTab");
        var divButton = new TzDiv("divButton");
        function txtTabName_onblur() {
            getPrjTab();
        }
        function txtTabName_onchange() {
            getPrjTab();
        }
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
            var intLen = tabPrjTab.getLength();
            for (var i = intLen - 1; i > 0; i--) {
                tabPrjTab.deleteRow(i);
            }
        }
        function setRecNo(intLen) {
            var strCondition = "";
            strCondition = objvPrjTab_Edit.Condition;
            var strMsg = String.format("<red>条件</red>:[{0}]所获取的记录数为:[{1}].", strCondition, intLen);
            lblRecNo4AllPrjTab.setinnerHTML(strMsg);
        }
        function pub_vPrjTab_GetTopRecordJSONObjLstCorrectFinished(returnObjectList, strClassName) {
            var arrvPrjTabObjLst = returnObjectList;
            if (arrvPrjTabObjLst === null) return;
            var strInfo = String.format("共获取对象列表数：{0}", arrvPrjTabObjLst.length)
            //显示信息框
            myAlert(strInfo);
            //删除表的数据行
            DelTabDataRow();
            var intLen = arrvPrjTabObjLst.length;
            setRecNo(intLen);
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
                var objTr = tabPrjTab.insertRow();
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
                input.value = "插入字段";
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
        function InsertNewField(thisButton) {
            console.log(thisButton);
            var strId = thisButton.id;
            hidTabId.setValue(strId);
            btnOK.click();
        }
        function InsertRow() {
            var strInfo = String.format("共获取对象列表数：{0}", pub_arrvPrjTabObjLst.length)
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
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div>
                <input type="text" onkeyup="KeyP(this);" />
                <input type="text" id="txt" />

              
            </div>
            <input id="Button1" type="button" value="获取表字段列表" onclick="return getPrjTab();" />
            <input id="btnInsertRow" type="button" value="插入表行" onclick="return InsertRow();" />
            <div>

                <asp:TextBox ID="txtTabName" onkeyup="KeyP_TabName(this);" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtTabCnName" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtTabCnName0" runat="server"></asp:TextBox>
                <input id="btnTestClickByJsFunc" type="button" value="测试通过Js函数来单击" onclick="return TestClickByJs();" />

                <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />

                <input id="btnTestAddEvent1" type="button" value="测试加Click事件" onclick="return TestAddClick1();" />
                <input id="btnTestAddEvent2" type="button" value="测试被加Click事件" />

                <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
                            <br />
                
                 <asp:Label ID="lblRecNo4AllPrjTab" runat="server" Text=""></asp:Label>
                            <br />
                <table id="tabPrjTab" style="width: 100%;">
                    <tr>
                        <td>表Id</td>
                        <td>表名</td>
                        <td>表中文名</td>
                        <td>字段数</td>
                        <td>表类型</td>
                        <td>工程</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
            <div id="divButton"></div>
        </div>
        <asp:HiddenField ID="hidTabId" runat="server" />
    </form>
</body>
</html>
