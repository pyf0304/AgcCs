<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="T_JsJSON1.aspx.cs" Inherits="AgcMvc3.Webform.A_Sample.T_JsJSON1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script>
        function T_ParseJSON() {
            var hidJsonStr = document.getElementById("hidJsonStr");
            var strJsonStr = hidJsonStr.value;
            console.log("strJsonStr", strJsonStr);
            try {
                var jsnObj = jQuery.parseJSON(strJsonStr);
                console.log("jsnObj", jsnObj);
            }
            catch (e) {
                console.log(e);
            }
            try {
                var jsnObj2 = JSON.parse(strJsonStr);
                console.log("jsnObj2", jsnObj2);
            }
            catch (e) {
                console.log(e);
            }
        }
          function T_ParseJSON2() {
            var hidJsonStr = document.getElementById("hidJsonStr");
            var strJsonStr = hidJsonStr.value;
              console.log("strJsonStr", strJsonStr);
              var arrStr = strJsonStr.split(',');
            try {
                var jsnObj = [arrStr];
                console.log("jsnObj", jsnObj);
            }
            catch (e) {
                console.log(e);
            }
            
        }
        function T_ParseJSONArr() {
            var hidJsonStr = document.getElementById("hidJsonStr");
            var strJsonStr = hidJsonStr.value;
              console.log("strJsonStr", strJsonStr);
      
            try {
                var arrJson =JSON.parse(strJsonStr);;
                console.log("arrJson", arrJson);
            }
            catch (e) {
                console.log(e);
            }
            
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField ID="hidJsonStr" runat="server" />
        <div>
            <asp:Button ID="btnInVokeParseJson" runat="server" Text="分析JSON串" OnClick="btnInVokeParseJson_Click" />
        </div>
    </form>
</body>
</html>
