<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPanel.aspx.cs" Inherits="AgcMvc3.Webform.A_Sample.TestPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script>
        function GetArray(arr) {
            let arrLst = new Array();
            for (var i = 0; i < arr.length; i++) {
                var chk = arr[i];
                arrLst.push(chk);
            }
            return arrLst;
        };
        function btn_Click() {
            var objLst = document.getElementsByTagName("span");
            let arrElement = GetArray(objLst);
            var strAttrs = "";
            arrElement.forEach(x => strAttrs += x.attributes["ctrlid"]);
            console.log(strAttrs);
            var strCtrlId = "caa1";
            var int1 = 25;
            var str1 = int1.toString();
            console.log(str1);
            let arrFind1 = arrElement.filter(x => x.id == 'sp01');
            console.log(arrFind1);
            var obj1 = arrFind1[0];
            console.log(obj1.attributes["ctrlid"]);
            console.log(obj1.attributes);

            let arrFind = arrElement.filter(x => x.attributes["ctrlid"] != null && x.attributes["ctrlid"].nodeValue == strCtrlId);
            console.log(arrFind);
            alert(strCtrlId + arrFind.length.toString());

            alert("btn_Click");

        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="panel1" runat="server"></asp:Panel>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <span id="sp01" ctrlid="caa1">aaa</span>
            <span id="sp02" ctrlid="caa2">aaa</span>
        </div>
    </form>
</body>
</html>

