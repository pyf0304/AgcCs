<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DispCode.aspx.cs" Inherits="AGC.Webform.A_Sample.DispCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script>
        function f1(event) {
            event = window.event || event;
            console.log("event:", event);
             var thisChk = event.target;
            var c3 = document.createElement("pre");
            c3.id = "c3";
            c3.innerText = "111";

//             var newNode = document.createElement("span");
//newNode.innerHTML = strHtml;
//var ddd = document.getElementById("iframe_script");
thisChk.parentNode.insertBefore(c3, thisChk);

        }
    </script>
    <style type="text/css">
        #TextArea1 {
            height: 216px;
            width: 301px;
        }
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnGeneCode" runat="server" Text="生成代码" OnClick="btnGeneCode_Click" />

            <asp:Literal ID="litCode" runat="server"></asp:Literal>

            <textarea id="txtCod1e" style="width:800px; height:600px;">
                <!DOCTYPE html>
                <div id="aa">aaa</div>
            </textarea>
            <textarea id="txtCod2e" style="width:800px; overflow-y:hidden; overflow-x:hidden " onclick="">
                <!DOCTYPE html>
                <div id="aa">aaa</div>
            </textarea>
            
            <code id="c1" onclick="f1()">
                 aaa
                var aa = d+c;

            </code>
               <pre id="c2" onclick="f1()">
                 aaa
                var aa = d+c;

            </pre>
        </div>

    </form>
</body>
</html>
