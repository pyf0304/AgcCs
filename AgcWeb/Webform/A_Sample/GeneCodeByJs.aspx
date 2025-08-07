<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GeneCodeByJs.aspx.cs" Inherits="AGC.Webform.A_Sample.GeneCodeByJs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script type="text/javascript">
        　function GetHelloWorld() {
            $.ajax({
                type: "post",
                datatype: "json",
                url: "GeneCodeByJs.aspx/HelloWorld",
                contentType: "application/json",
                success: function (result) {
                    alert(result.d);
                }
            });
        }


        function GeneCode() {
            $.ajax({
                type: "post",
                datatype: "json",
                data: '{"strCodeTypeId": "0001",' + 
                        '"strTabId": "01160063",'+
                        '"strViewId":""}',
                url: "GeneCodeByJs.aspx/GeneCode",
                contentType: "application/json",
                success: function (result) {
                    ShowCode(result.d);
                }
            });
        }
        function ShowCode(strCode) {
            var objJSON = JSON.parse(strCode)
            //var txtCode = document.getElementById("txtCode");
            //txtCode.append(strCode); 
                  var txtCode = document.getElementById("txtCode");
            txtCode.value = objJSON.Code;
                  var txtCode = document.getElementById("divCode");
            divCode.innerHTML = objJSON.Code;

            //$('#txtCode').val(strCode);
//            txtCode.innerHTML = strCode;
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="btnTestInvokeByJs" type="button" value="调用后台ByJs" onclick="GetHelloWorld();" />
           <input id="btnGeneCodeByJs" type="button" value="生成代码ByJs" onclick="GeneCode();" />
            <textarea id="txtCode" style="width:80%; height:700px;" cols="20" rows="2"></textarea>  
                <asp:Literal ID="litCode" runat="server"></asp:Literal>
            <div id="divCode" style="width:80%; height:700px;border:solid 2px blue" ></div>
        </div>
        
    </form>
    
</body>
</html>
