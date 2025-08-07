<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfmTestWccFieldGroup.aspx.cs" Inherits="AGC.Webform.wfmTestWccFieldGroup" %>

<%@ Register assembly="TzCommWebServerCtrlLib" namespace="TzCommWebServerCtrlLib" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/taishweb2.css" rel="stylesheet" type="text/css" />
    <link href="../css/LinkButton.css" rel="stylesheet" type="text/css" />
    <link href="../css/button.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:wccFieldGroup ID="wccFieldGroup3" Caption="AA" CtlTypeName="CheckBox" runat="server" 
            wccfg_CaptionCss="topTitle2" wccfg_LinkButtonCss="lkbtn" 
            wccfg_TextBoxCss="TextBox_Defa" />
  
        <asp:PlaceHolder ID="phQueryRegion" runat="server" ViewStateMode="Enabled"></asp:PlaceHolder>
  
    </div>
    </form>
</body>
</html>
