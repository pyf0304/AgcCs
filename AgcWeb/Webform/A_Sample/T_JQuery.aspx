<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="T_JQuery.aspx.cs" Inherits="AGC.Webform.A_Sample.T_JQuery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
    <link href="../../css/VisualEffects.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script>
        function TFindDivAndNextElement() {
            $('#s1').html("s1");
            $('#div1').find('span[id^="s1"]').html("div1-s1");
            $('#div2').find('span[id^="s1"]').html("div2-s1");
        }
        function TFindDivAndNextElement_Js() {

            var Text11 = document.getElementById("Text1");
            console.log("Text1:", Text11);
            Text11.value = "new-Text1";
            try {
                var div0 = document.getElementById("div0");
                console.log("div0:", div0);
                var arrElement = div0.getElementsByTagName("span");
                console.log("arrElement:", arrElement);
                var div0_s1 = arrElement[0];
                console.log("div0_s1:", div0_s1);
                console.log("div0_s1.value:", div0_s1.innerText);

                div0_s1.innerText = "div0-s1";
                //div0_s1.innerHtml = "div0-s1-html";

                var t1 = document.getElementById("t1");
                console.log("t1:", t1);
                t1.value = "new-myT1";
                $('#s1').html("new-s1");
                var div1 = $('#div1');
                console.log(div1);
                var div1type = typeof div1;
                console.log(div1type);
                var div1_s1 = $('#div1').find('span[id^="s1"]');
                console.log("div1_s1:", div1_s1);
                var div1_s1type = typeof div1_s1;
                console.log(div1_s1type);
                
                $('#div1').find('span[id^="s1"]').html("div1-s1");
                $('#div2').find('span[id^="s1"]').html("div2-s1");
                //用于检查层不存在时的状态
                     var div4 = $('#div4');
                console.log("div4:", div4);
console.log("div4.len:", div4.length);

                var div4type = typeof div4;
                           console.log(div4type);
            }
            catch (e) {
                console.error(e);
                alert(e);
            }
        }
    </script>
</head>
<body>
    <h3>表单控件</h3>

    <form id="form1" runat="server">
        <span class="h4 text-info">可视化区域</span>
        <div id="div0" class="myBorder" style="width: 300px; height: 100px;">
            <span>div0</span>
            <br />
            <span>abc</span>
                <br />
            <span id="s1">s1</span>
                  <br />
            <input id="t1" type="text" />
                  <br />
            <input id="Text1" type="text" value="111" />
        </div>
        <div id="div1" class="myBorder" style="width: 300px; height: 100px;">
            <span>div1</span>
            <br />
            <span>abc</span>
                  <br />
            <span id="s1">s1</span>
        </div>

        <div id="div2" class="myBorder" style="width: 300px; height: 100px;">
            <span>div1</span>
            <br />
            <span>abc</span>
                  <br />
            <span id="s1">s1</span>
        </div>
        <input type="button" onclick="TFindDivAndNextElement()" value="测试查找Div下的元素"/>
        <input type="button" onclick="TFindDivAndNextElement_Js()" value="测试查找Div下的元素_Js" />

    </form>
</body>
</html>

