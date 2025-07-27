<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewTest.aspx.cs" Inherits="WebHtmlTest.WebForm.News.NewTest" %>

<%@ Register Src="wucComplexShow.ascx" TagName="wucComplexShow" TagPrefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>自动生成代码资讯</title>
    <%-- <link rel="Stylesheet" type="text/css" href="../../css/news.css" />
    <script src="../../js/jquery-1.3.2.js" language="javascript" type="text/javascript"></script>
    <script src="../../js/jquery.cycle.all.min.js" language="javascript" type="text/javascript"></script>
    <script src="../../js/js.js" type="text/javascript"></script>--%>

   
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:wucComplexShow ID="wucComplexShow1" runat="server" />
        </div>
    </form>
</body>
</html>
