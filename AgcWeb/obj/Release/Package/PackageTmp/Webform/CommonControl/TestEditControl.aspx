<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestEditControl.aspx.cs" Inherits="AGC.Webform.CommonControl.TestEditControl" %>

<%@ Register src="wucEditControl.ascx" tagname="wucEditControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:wucEditControl ID="wucEditControl1" runat="server" />
        </div>
    </form>
</body>
</html>
