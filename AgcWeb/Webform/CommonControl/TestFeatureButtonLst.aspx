<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestFeatureButtonLst.aspx.cs" Inherits="AGC.Webform.CommonControl.TestFeatureButtonLst" %>

<%@ Register src="wucFeatureButtonLst.ascx" tagname="wucFeatureButtonLst" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:wucFeatureButtonLst ID="wucFeatureButtonLst1" runat="server" />
        </div>
    </form>
</body>
</html>
