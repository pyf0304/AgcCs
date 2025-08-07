<%@ Page Language="c#" CodeBehind="wfmDispUserMenu_EditTab.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmDispUserMenu_EditTab" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>ѡ���û���ɫ</title>
    
    <style type="text/css">
        .style1
        {
            width: 240px;
        }
    </style>
</head>
<body bgcolor="#dddddd">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <table style="width: 100%; height: 294px; position: absolute; top: 1px; left: 1px;"
        border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td align="right" >
            
                <asp:LinkButton ID="lbRefresh" runat="server" onclick="lbRefresh_Click">ˢ��</asp:LinkButton>
            
            </td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td valign="top" class="style1" >
                <cc1:Accordion ID="accPrjTab" runat="server">
                </cc1:Accordion>
            </td>
            <td >
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
