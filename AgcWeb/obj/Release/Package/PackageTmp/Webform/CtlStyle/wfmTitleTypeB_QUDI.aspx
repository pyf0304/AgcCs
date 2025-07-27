
<%@ Register TagPrefix = "uc1" TagName = "wucTitleTypeB" Src = "wucTitleTypeB.ascx" %>
<%@ Register TagPrefix = "uc2" TagName = "wucTitleType4Gv" Src = "wucTitleType4Gv.ascx" %>
<%@ Page language = "c#" AutoEventWireup = "True" CodeBehind = "wfmTitleTypeB_QUDI.aspx.cs" Inherits = "AGC.Webform.wfmTitleTypeB_QUDI" %>
<!DOCTYPE html>
<html xmlns = "http://www.w3.org/1999/xhtml">
<head runat = "server">
<meta http-equiv = "Content-Type" content = "text/html; charset = utf-8" />
<title>标题类型维护的维护</title>
<link rel = "stylesheet" type = "text/css" href = "../../css/tz_base1.css"/>
<script type = "text/javascript" src = "../../JS/tzPubFun.js"></script>
</head>
<body>
<form id = "form1" runat = "server">
<div id = "tabLayout" class = "tab_layout" 
runat = "server">
<%-- 标题层 --%>

<table id = "tabTitle" style = "z-index: 102; left: 8px; position: absolute; top: 1px" cellspacing = "1" 
cellpadding = "1" width = "100%" bgColor = "#ff6666" border = "0">
<tr>
<td bgColor = "#ff6666">
<asp:Label id = "lblViewTile" runat = "server" Font-Size = "Small" Font-Names = "宋体" ForeColor = "White" Font-Bold = "True">标题类型维护</asp:Label>
</td>
</tr>
</table>
<%-- 查询层 --%>

<div id = "divQuery" class = "div_query"> 
<table class = "msgtable" style = "width: 80%"> 
<tr>

<td>
<asp:Label id = "lblTitleTypeIdq" style = "z-index: 104;" 
runat = "server" CssClass = "NameLabel">标题类型ID</asp:Label>
</td>
<td>
<asp:TextBox id = "txtTitleTypeIdq" style = "z-index: 105; " 
runat = "server" CssClass = "TextBox_Defa">
</asp:TextBox>
</td>

<td>
<asp:Label id = "lblTitleTypeNameq" style = "z-index: 107;" 
runat = "server" CssClass = "NameLabel">标题类型</asp:Label>
</td>
<td>
<asp:TextBox id = "txtTitleTypeNameq" style = "z-index: 108; " 
runat = "server" CssClass = "TextBox_Defa">
</asp:TextBox>
</td>
</tr>
<tr>

<td>
<asp:Label id = "lblMemoq" style = "z-index: 110;" 
runat = "server" CssClass = "NameLabel">说明</asp:Label>
</td>
<td>
<asp:TextBox id = "txtMemoq" style = "z-index: 111; " 
runat = "server" CssClass = "TextBox_Defa">
</asp:TextBox>
</td>
<td>

<asp:Button id = "btnQuery" 
style = "z-index: 113; Width:80px; Height:24px;" 
runat = "server" 
Text = "查询" CssClass = "Button_Defa" 
OnClick = "btnQuery_Click" 
></asp:Button>
</td>
</tr>
</table>
</div>
<%-- 功能区 --%>

<div id = "divFunction" class = "div_Funttion" runat = "server">
<table id = "tabGridFunction" style = "width: 100%; height: 32px" class = "msgtable" >
<tr>
<td>
<asp:label id = "lblTitleTypeList" runat = "server" style = "z-index: 105; " 
CssClass = "h6" Width = "250px">标题类型列表</asp:label>
</td>
<td>
<asp:button id = "btnAddNewRec4Gv" runat = "server" OnClick = "btnAddNewRec4Gv_Click" style = "z-index: 106; "
Width = "80px" CssClass = "Button_Defa" Text = "添加记录"></asp:button>
</td>
<td>
<asp:button id = "btnDelete4Gv" OnClick = "btnDelete4Gv_Click" style = "z-index: 104; " runat = "server"
Width = "80px" CssClass = "Button_Defa" Text = "删除记录"></asp:button>
</td>
<td>
<asp:button id = "btnUpdate4Gv" OnClick = "btnUpdate4Gv_Click" style = "z-index: 105; " runat = "server"
Width = "80px" CssClass = "Button_Defa" Text = "修改记录"></asp:button>
</td>
<td>
<asp:button id = "btnExportExcel4Gv" OnClick = "btnExportExcel4Gv_Click" style = "z-index: 107; "
runat = "server" Width = "80px" CssClass = "Button_Defa" Text = "导出Excel"></asp:button>
</td>
</tr>
</table>
</div>
<%-- 列表层 --%>
<div id = "divList" class = "div_List" runat = "server">
<uc2:wucTitleType4Gv runat="server" id="wucTitleType4Gv1" 
OnGvUpdateClick = "wucTitleType4Gv1_GvUpdateClick" 
OnGvDeleteClick = "wucTitleType4Gv1_GvDeleteClick" /> 
</div>
<%-- 编辑层 --%>
<div id = "tabEditTitleTypeRegion" class = "tab_Edit" 
runat = "server">
<div>
<table style = "width: 100%;" class = "msgtable">
<tr>
<th style = "text-align: left">
<asp:label id = "lblEditTitleType" style = "z-index: 104; " runat = "server"
CssClass = "h6" >标题类型编辑区域</asp:label>
<asp:Label id = "lblMsgEdit" style = "z-index: 105; " runat = "server" 
Width = "208px" Height = "16px" CssClass = "ErrMsg" ></asp:Label>
</th>
<th style = "text-align: right">
<asp:Button id = "btnOKUpd" style = "z-index: 106; " runat = "server" 
Width = "80px" Text = "添加" OnClick = "btnOKUpd_Click" CssClass = "Button_Defa"></asp:Button>
 
<asp:Button id = "btnCancelTitleTypeEdit" style = "z-index: 107; "
runat = "server" Width = "100px" CssClass = "Button_Defa" Text = "取消编辑" OnClick = "btnCancelTitleTypeEdit_Click"></asp:Button>
</th>
</tr>
</table>
</div>
<div>
<uc1:wucTitleTypeB id = "wucTitleTypeB1" runat = "server" />
</div>
</div>
</div>
</form>
</body>
</html>