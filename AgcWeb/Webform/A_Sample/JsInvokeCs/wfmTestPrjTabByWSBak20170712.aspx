<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="wfmTestPrjTabByWSBak20170712.aspx.cs"
    Inherits="AGC.Webform.JsInvokeCs.wfmTestPrjTabByWSBak20170712" %>

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
        var tabPrjTab = new TzTable("tabPrjTab");
        var divButton = new TzDiv("divButton");
        function txtTabName_onblur() {
            getPrjTab();
        }
        function txtTabName_onchange() {
            getPrjTab();
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
        function pub_vPrjTab_GetTopRecordJSONObjLstCorrectFinished(returnObjectList, strClassName) {
            var arrvPrjTabObjLst = returnObjectList;
            if (arrvPrjTabObjLst === null) return;
            var strInfo = String.format("共获取对象列表数：{0}", arrvPrjTabObjLst.length)
            //显示信息框
            myAlert(strInfo);
            //删除表的数据行
            DelTabDataRow();
            var intLen = arrvPrjTabObjLst.length;
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
            <div id="test1">
                <b>测试onpropertychange事件和onchange事件一起用时： </b>
                <br/>
                <font color="red">测试结果：onpropertychange事件在用键盘每改变一下文本框的值或用js改变其值便会触发一下，而onchange只有在用键盘改变其值，然后在失去焦点后才触发，用js改变其值不触发 </font>
                <br/>
                <input name="haha1" type="text" onpropertychange="alert('触发了onpropertychange事件！')" onchange="alert('触发了onchange事件！')" size="30">
                <input name="testbutton1" value="通过js改变文本框中的值" type="button" onclick="document.getElementById('haha1').value = 'js改变文本框后的值'">
                <br/>
                <br/>
                <br/>
            </div>
            <div id="test2">
                <b>测试只有onblur和onchange事件时： </b>
                <br/>
                <span color="red">测试结果：onchange先触发，onblur后触发 </span>
                <br/>
                <input name="haha2" type="text" onblur="alert('触发了onblur事件！')" onchange="alert('触发了onchange事件！')" size="30"/>
                <input name="testbutton2" value="通过js改变文本框中的值" type="button" onclick="document.getElementById('haha2').value = 'js改变文本框后的值'"/>
                <br/>
            </div>
            <br/>
            <br/>
            <br/>


            <div id="test3">
                <b>测试当onblur和onpropertychange事件一起用时： </b>
                <br/>
                <font color="red">测试结果：onblur好象出了问题，只要用键盘在文本框中随便输入一个值，便会触发它。可能是onpropertychange把它惹毛了。。。^-^ </font>
                <br/>
                <input name="haha3" type="text" onblur="alert('触发了onblur事件！')" onpropertychange="alert('触发了onpropertychange事件！')" size="30">
                <input name="testbutton3" value="通过js改变文本框中的值" type="button" onclick="document.getElementById('haha3').value = 'js改变文本框后的值'">
                <br/>
            </div>
            <br/>
            <br/>
            <br/>
            <div id="test4">
                <b>测试有onblur、onpropertychange事件和onchange事件一起用时： </b>
                <br/>
                <font color="red">测试结果：onblur在和onpropertychange一起用时的问题仍然存在 </font>
                <br/>
                <input name="haha4" type="text" onblur="alert('触发了onblur事件！')" onpropertychange="alert('触发了onpropertychange事件！')" onchange="alert('触发了 onchange事件！')"   size="30">
                <input name="testbutton4" value="通过js改变文本框中的值" type="button" onclick="document.getElementById('haha4').value = 'js改变文本框后的值'">
                <br/>
            </div>
            <div>
                <input type="text" onkeyup="KeyP(this);" /> <input type="text" id="txt" /> 

<script> 

    function KeyP(v){ 

        document.getElementById("txt").value = v.value; 

    } 

</script>
            </div>
            <input id="Button1" type="button" value="获取表字段列表" onclick="return getPrjTab();" />
            <input id="btnInsertRow" type="button" value="插入表行" onclick="return InsertRow();" />
            <div>

                <asp:TextBox ID="txtTabName" onkeyup="KeyP(this);"  runat="server"></asp:TextBox>
                <asp:TextBox ID="txtTabCnName" onkeyup="KeyP(this);" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtTabCnName0" runat="server"></asp:TextBox>
                <input id="btnTestClickByJsFunc" type="button" value="测试通过Js函数来单击" onclick="return TestClickByJs();" />

                <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />

                <input id="btnTestAddEvent1" type="button" value="测试加Click事件" onclick="return TestAddClick1();" />
                <input id="btnTestAddEvent2" type="button" value="测试被加Click事件" />

                <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
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
