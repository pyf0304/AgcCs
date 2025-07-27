<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="TestMenu.aspx.cs" Inherits="Webform_Table2_TestMenu" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
     <cc1:Accordion ID="accPrjTab" runat="server">
     <Panes>
         <cc1:AccordionPane ID="AccordionPane1" runat="server" ContentCssClass="" 
             HeaderCssClass="">
             <Header>
             <a href="Test1.aspx" >AAA</a>
             </Header>
             <Content>
             <a href="Test1.aspx" >AAA1</a>
             <a href="Test1.aspx" >AAA2</a>
             </Content>
             </cc1:AccordionPane>
         <cc1:AccordionPane ID="AccordionPane2" runat="server" ContentCssClass="" 
             HeaderCssClass="">
             <Header>
             <a href="Test1.aspx" >AAA</a>
             </Header>
             <Content>
             <a href="Test1.aspx" >AAA1</a>
             <a href="Test1.aspx" >AAA2</a>
             </Content></cc1:AccordionPane>
             </Panes>
                </cc1:Accordion>
    </div>
    </form>
</body>
</html>
