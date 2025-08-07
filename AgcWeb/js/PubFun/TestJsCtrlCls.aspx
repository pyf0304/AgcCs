<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestJsCtrlCls.aspx.cs" Inherits="ExamLibWeb.js.PubFun.TestJsCtrlCls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="jsPubVar.js"></script>
    <script src="jsPubFun.js"></script>
    <script src="tzInclude.js"></script>
    <script src="jsGetElement.js"></script>
    <script src="TzCtrlCls.js"></script>
    <script>
        var myText = new TzTextBox("txtName");
        var sltCollege = new TzSelect("sltCollege");
        var TestDiv = new TzDiv("TestDiv");
        var lblSpan = new TzSpan("lblSpan");

        function getSpanValue() {

            var myValue = lblSpan.getinnerText();
            alert(myValue);
        }
        function setSpanValue() {

            lblSpan.setinnerText("aaa");
            alert("设置完成！");
        }

        var txtMultiText = new TzTextArea("txtMultiText");
        function getMultiTextValue() {

            var myValue = txtMultiText.getText();
            alert(myValue);
        }
        function setMultiTextValue() {

            txtMultiText.setText("aaa");
            alert("设置完成！");
        }

        function getTextValue() {

            var myValue = myText.getText();
            alert(myValue);
        }
        function setTextValue() {

            myText.setText("aaa");
            alert("设置完成！");
        }
        function addItems() {
            sltCollege.RemoveAll();
            sltCollege.AddItems("01", "人文");
            sltCollege.AddItems("02", "数理");
            sltCollege.AddItems("03", "生环");
        }
        function getSelectedValue() {
            var strValue = sltCollege.getSelectedValue();
            alert(strValue);
        }
        function setSelectedValue() {
            var strValue = "03";
            sltCollege.SetSelectedItem(strValue);
        }
        function ShowDiv()
        {
            TestDiv.Show();
            TestDiv.setPos(200, 100);
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
        <div>
            测试Js控制类<br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <input id="btnGetTextValue" type="button" value="获取文本框值" onclick="return getTextValue();" />
            <input id="btnSetButton1" type="button" value="设置文本框值" onclick="return setTextValue();" />
            <br />
               <input id="btnShowDiv" type="button" value="显示层" onclick="return ShowDiv();" />
         
          
        </div>
          <div>
            测试多行文本框<br />
            <asp:TextBox ID="txtMultiText" TextMode="MultiLine" runat="server"></asp:TextBox>
            <input id="btnGetMultiTextValue" type="button" value="获取文本框值" onclick="return getMultiTextValue();" />
            <input id="btnSetMultiText" type="button" value="设置文本框值" onclick="return setMultiTextValue();" />
     
          
        </div>
          <div>
            测试Span(Label)框<br />
            <asp:Label ID="lblSpan"  runat="server">Span-AAA</asp:Label>
            <input id="btnGetSpanValue" type="button" value="获取Span框值" onclick="return getSpanValue();" />
            <input id="btnSetSpanText" type="button" value="设置Span框值" onclick="return setSpanValue();" />
     
          
        </div>
          <div id="TestDiv" style="background-color:aqua;height:200px; width:400px; position:absolute; top:300px">
                <select id="sltCollege" name="D1">
                    <option></option>
                </select>
                <input id="btnAddItem" type="button" value="添加项" onclick="addItems();" />
                <input id="btnGetSelectedValue" type="button" value="获取被选项的值" onclick="getSelectedValue();" />
                <input id="btnSetSelectedValue" type="button" value="设置被选项的值" onclick="setSelectedValue();" />
            </div>
    </form>
</body>
</html>
