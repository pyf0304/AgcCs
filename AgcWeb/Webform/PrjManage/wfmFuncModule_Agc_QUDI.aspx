
<%@ Register TagPrefix = "uc1" TagName = "wucFuncModule_Agc" Src = "wucFuncModule_Agc.ascx" %>
<%@ Register TagPrefix = "uc2" TagName = "wucvFuncModule_Agc4Gv" Src = "wucvFuncModule_Agc4Gv.ascx" %>
<%@ Page language = "c#" AutoEventWireup = "True" CodeBehind = "wfmFuncModule_Agc_QUDI.aspx.cs" Inherits = "AGC.Webform.wfmFuncModule_Agc_QUDI" %>
<!DOCTYPE html>
<html xmlns = "http://www.w3.org/1999/xhtml">
<head runat = "server">
<meta http-equiv = "Content-Type" content = "text/html; charset = utf-8" />
<title>功能模块_Agc维护的维护</title>
<script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
<script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<script type="text/javascript" src="../../JS/tzPubFun.js"></script>
</head>
<body>
<form id = "form1" runat = "server" class="form-horizontal">
<div id = "tabLayout" class = "tab_layout" 
runat = "server">
<%-- 标题层 --%>

<div style = "position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
<asp:Label ID = "lblViewTitle" runat = "server" CssClass = "col-form-label text-info" >功能模块_Agc维护
</asp:Label>
<asp:Label ID = "lblMsgList" runat = "server" CssClass = "text-danger"  Style = "
left: 54px; position: relative; top: 4px" Width = "347px"></asp:Label>
	</div>
<%-- 查询层 --%>

<div id = "divQuery" style = "margin: 10px;"> 
<table id="tabQuery" style="width: 70%" class="table table-bordered table-hover table td table-sm">
<tr>
<td>
<asp:Label id="lblFuncModuleAgcIdq" name="lblFuncModuleAgcIdq" CssClass="col-form-label text-right" Width="90px" Text="功能模块Id" runat="server" />
</td>
<td>
<asp:TextBox id="txtFuncModuleAgcIdq" name="txtFuncModuleAgcIdq" CssClass="form-control" Width="120px" runat="server" />
</td>
<td>
<asp:Label id="lblFuncModuleNameq" name="lblFuncModuleNameq" CssClass="col-form-label text-right" Width="90px" Text="功能模块名称" runat="server" />
</td>
<td>
<asp:TextBox id="txtFuncModuleNameq" name="txtFuncModuleNameq" CssClass="form-control" Width="120px" runat="server" />
</td>
<td>
<asp:Label id="lblFuncModuleEnNameq" name="lblFuncModuleEnNameq" CssClass="col-form-label text-right" Width="90px" Text="功能模块英文名称" runat="server" />
</td>
<td>
<asp:TextBox id="txtFuncModuleEnNameq" name="txtFuncModuleEnNameq" CssClass="form-control" Width="120px" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label id="lblUseStateIdq" name="lblUseStateIdq" CssClass="col-form-label text-right" Width="90px" Text="使用状态Id" runat="server" />
</td>
<td>
<asp:DropDownList id="ddlUseStateIdq" name="ddlUseStateIdq" CssClass="form-control" Width="120px" runat="server" />
</td>
<td>
<asp:Button id="btnQuery" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnQuery_Click" Text="查询" runat="server" />
</td>
<td>
<asp:Button id="btnExportExcel" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
</td>
</tr>
</table>
</div>
<%-- 功能区 --%>

<div id="divFunction" class="table table-bordered table-hover">
<ul class="nav">
<li class="nav-item">
<asp:Label id="lblFuncModule_AgcList" name="lblFuncModule_AgcList" CssClass="col-form-label text-info" Width="250px" Text="功能模块_Agc列表" runat="server" />
</li>
<li class="nav-item ml-3">
<asp:Button id="btnAddNewRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
</li>
<li class="nav-item ml-3">
<asp:Button id="btnUpdateRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
</li>
<li class="nav-item ml-3">
<asp:Button id="btnDelRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
</li>
</ul>
</div>
<%-- 列表层 --%>
<div id = "divList" class = "div_List mt-2" runat = "server">
<uc2:wucvFuncModule_Agc4Gv runat="server" id="wucvFuncModule_Agc4Gv1" 
OnGvUpdateClick = "wucvFuncModule_Agc4Gv1_GvUpdateClick" 
OnGvDeleteClick = "wucvFuncModule_Agc4Gv1_GvDeleteClick" /> 
</div>
<%-- 编辑层 --%>
<div id = "tabEditFuncModule_AgcRegion" class = "tab_Edit mt-2" 
runat = "server">
<div style = "width: 60%;">
<ul class="nav">
<li class="nav-item">
<asp:label id = "lblEditFuncModule_Agc" style = "z-index: 104; "  Width="200px" runat = "server"
CssClass = "col-form-label text-info" >功能模块_Agc编辑区域</asp:label>
</li>
<li class="nav-item ml-3">
<asp:Button id = "btnOKUpd" style = "z-index: 106; " runat = "server" 
 Text = "添加" OnClick = "btnOKUpd_Click" CssClass = "btn btn-outline-info"></asp:Button>
 </li>
<li class="nav-item ml-3">
<asp:Button id = "btnCancelFuncModule_AgcEdit" 
runat = "server" CssClass = "btn btn-outline-info" Text = "取消编辑" OnClick = "btnCancelFuncModule_AgcEdit_Click"></asp:Button>
 </li>
<li class="nav-item ml-3">
<asp:Label id = "lblMsgEdit"  runat = "server" 
Width = "420px"  CssClass = "col-form-label text-danger" ></asp:Label>
 </li>
</ul>
</div>
<div>
<uc1:wucFuncModule_Agc id = "wucFuncModule_Agc1" runat = "server" />
</div>
</div>
</div>
</form>
</body>
</html>