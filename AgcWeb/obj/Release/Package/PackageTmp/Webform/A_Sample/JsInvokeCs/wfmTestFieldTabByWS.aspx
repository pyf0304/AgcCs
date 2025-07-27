<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfmTestFieldTabByWS.aspx.cs" Inherits="AGC.Webform.JsInvokeCs.wfmTestFieldTabByWS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
  
    <script src="../../js/PubFun/jsPubVar.js"></script>
    <script src="../../js/PubFun/jsPubFun.js"></script>
    <script src="../../js/PubFun/jsGetElement.js"></script>
    <script src="../../js/PubFun/TzCtrlCls.js"></script>
      <script src="../../js/Table_Field/jsvFieldTab_Edit.js"></script>
    <script>
     
        var objvFieldTab_Edit = new vcvFieldTab_Edit();
        var tabFieldTab = new TzTable("tabFieldTab");
        var divButton = new TzDiv("divButton");
        //var pub_arrvFieldTabObjLst = null;
        function getFieldTab()
        {
            objvFieldTab_EditDelegate = new clsTableObjWS4ControllerDelegate();
          
            objvFieldTab_EditDelegate.GetRecordJSONObjLstCorrectFinished = function (returnObjectList, strClassName) {
                pub_vFieldTab_GetRecordJSONObjLstCorrectFinished(returnObjectList, strClassName);
            }
            objvFieldTab_Edit.btnGetJSONObjLst_Click();          
        }
        function pub_vFieldTab_GetRecordJSONObjLstCorrectFinished(returnObjectList, strClassName)
        {
            var arrvFieldTabObjLst = returnObjectList;
            if (arrvFieldTabObjLst === null) return;
            //var strInfo = String.format("共获取对象列表数：{0}", arrvFieldTabObjLst.length)
            ////显示信息框
            //myAlert(strInfo);
            var intLen = arrvFieldTabObjLst.length;
            for (var i = 0; i < intLen; i++) {
                var objvFieldTab = arrvFieldTabObjLst[i];
                var objTr = tabFieldTab.insertRow();
                var objTd1 = objTr.insertCell();
                objTd1.setText(objvFieldTab.FldId);
                var objTd2 = objTr.insertCell();
                objTd2.setText(objvFieldTab.FldName);
                objTr.insertCell(objvFieldTab.Caption);
                objTr.insertCell(objvFieldTab.DataTypeName);
                objTr.insertCell(objvFieldTab.FldLength);
                objTr.insertCell(objvFieldTab.FldPrecision);
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
        function InsertNewField(thisButton)
        {
            console.log(thisButton);
            var strId = thisButton.id;
            hidFldId.setValue(strId);
            btnOK.click();
        }
        function InsertRow()
        {
            var strInfo = String.format("共获取对象列表数：{0}", pub_arrvFieldTabObjLst.length)
            //显示信息框
            myAlert(strInfo);  
           
        
        }
        var btnOK = new TzButton("btnOK");
        function TestClickByJs()
        {
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
        
        <input id="Button1" type="button" value="获取表字段列表" onclick="return getFieldTab();" />
        <input id="btnInsertRow" type="button" value="插入表行" onclick="return InsertRow();" />
        <div>
            <table id="tabFieldTab" style="width: 100%;">
            <tr>
                <td>序号</td>
                <td>字段名</td>
                <td>标题</td>
                <td>类型</td>
                <td>长度</td>
                <td>小数位数</td>
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
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
               <input id="btnTestClickByJsFunc" type="button" value="测试通过Js函数来单击" onclick="return TestClickByJs();" />
     
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click"  />
                
              <input id="btnTestAddEvent1" type="button" value="测试加Click事件" onclick="return TestAddClick1();" />
              <input id="btnTestAddEvent2" type="button" value="测试被加Click事件" />
     
            <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
        </div>
        <div id="divButton"></div>
    </div>
        <asp:HiddenField ID="hidFldId" runat="server" />
    </form>
</body>
</html>
