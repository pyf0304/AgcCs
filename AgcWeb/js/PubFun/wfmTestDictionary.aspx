<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfmTestDictionary.aspx.cs" Inherits="ExamLibWeb.js.PubFun.wfmTestDictionary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="TestDictionary.js"></script>
    <script src="jsString.js"></script>
      <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
    <div>
    <input id="Button1" type="button" value="testDict" onclick="testDict();" />
        <input id="Button2" type="button" value="TestDataType" onclick="TestDataType();" />

    </div>
    </form>
</body>

</html>
