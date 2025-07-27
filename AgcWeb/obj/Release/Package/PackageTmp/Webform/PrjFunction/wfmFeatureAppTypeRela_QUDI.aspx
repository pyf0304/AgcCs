
<%@ Register TagPrefix = "uc1" TagName = "wucFeatureAppTypeRela" Src = "wucFeatureAppTypeRela.ascx" %>
<%@ Register TagPrefix = "uc2" TagName = "wucvFeatureAppTypeRela4Gv" Src = "wucvFeatureAppTypeRela4Gv.ascx" %>
<%@ Page language = "c#" AutoEventWireup = "True" CodeBehind = "wfmFeatureAppTypeRela_QUDI.aspx.cs" Inherits = "AGC.Webform.wfmFeatureAppTypeRela_QUDI" %>
<!DOCTYPE html>
<html xmlns = "http://www.w3.org/1999/xhtml">
<head runat = "server">
<meta http-equiv = "Content-Type" content = "text/html; charset = utf-8" />
<title>功能应用关系维护的维护</title>
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
<asp:Label ID = "lblViewTitle" runat = "server" CssClass = "col-form-label text-info" >功能应用关系维护
</asp:Label>
<asp:Label ID = "lblMsgList" runat = "server" CssClass = "text-danger"  Style = "
left: 54px; position: relative; top: 4px" Width = "347px"></asp:Label>
	</div>
<%-- 查询层 --%>

<div id = "divQuery" style = "margin: 10px;"> 
<table id="tabQuery" style="width: 70%; " class="table table-bordered table-hover table td">
<tr>
<td>
<asp:Label id="lblApplicationTypeIdq" CssClass="col-form-label text-right" Width="90px" Text="应用程序类型ID" runat="server" />
</td>
<td>
<asp:DropDownList id="ddlApplicationTypeIdq" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
<asp:Label id="lblFeatureIdq" CssClass="col-form-label text-right" Width="90px" Text="功能Id" runat="server" />
</td>
<td>
<asp:DropDownList id="ddlFeatureIdq" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
<asp:Label id="lblInUseq" CssClass="col-form-label text-right" Width="90px" Text="是否在用" runat="server" />
</td>
<td>
<asp:DropDownList id="ddlInUseq" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
<asp:Button id="btnQuery" style="z-index: 107;" CssClass="btn btn-outline-warning" OnClick="btnQuery_Click" Text="查询" runat="server" />
</td>
<td>
<asp:Button id="btnExportExcel" CssClass="btn btn-outline-warning" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
</td>
</tr>
</table>
</div>
<%-- 功能区 --%>

<div id="divFunction" class="table table-bordered table-hover">
<ul class="nav">
<li class="nav-item">
<asp:Label id="lblFeatureAppTypeRelaList" CssClass="col-form-label text-info" Width="250px" Text="功能应用关系列表" runat="server" />
</li>
<li class="nav-item ml-3">
<asp:Button id="btnAddNewRecord" CssClass="btn btn-outline-info" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
</li>
<li class="nav-item ml-3">
<asp:Button id="btnUpdateRecord" CssClass="btn btn-outline-info" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
</li>
<li class="nav-item ml-3">
<asp:Button id="btnDelRecord" CssClass="btn btn-outline-info" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
</li>
</ul>
</div>
<%-- 列表层 --%>
<div id = "divList" class = "div_List mt-2" runat = "server">
<uc2:wucvFeatureAppTypeRela4Gv runat="server" id="wucvFeatureAppTypeRela4Gv1" 
OnGvUpdateClick = "wucvFeatureAppTypeRela4Gv1_GvUpdateClick" 
OnGvDeleteClick = "wucvFeatureAppTypeRela4Gv1_GvDeleteClick" /> 
</div>
<%-- 编辑层 --%>
<div id = "tabEditFeatureAppTypeRelaRegion" class = "tab_Edit mt-2" 
runat = "server">
<div>
<table style = "width: 60%;" class = "table table-bordered table-hover">
<tr>
<th style = "text-align: left">
<asp:label id = "lblEditFeatureAppTypeRela" style = "z-index: 104; " runat = "server"
CssClass = "col-form-label text-info" >功能应用关系编辑区域</asp:label>
<asp:Label id = "lblMsgEdit"  runat = "server" 
Width = "208px"  CssClass = "col-form-label text-danger" ></asp:Label>
</th>
<th style = "text-align: right">
<asp:Button id = "btnOKUpd" style = "z-index: 106; " runat = "server" 
 Text = "添加" OnClick = "btnOKUpd_Click" CssClass = "btn btn-outline-info"></asp:Button>
 
<asp:Button id = "btnCancelFeatureAppTypeRelaEdit" 
runat = "server" CssClass = "btn btn-outline-info" Text = "取消编辑" OnClick = "btnCancelFeatureAppTypeRelaEdit_Click"></asp:Button>
</th>
</tr>
</table>
</div>
<div>
<uc1:wucFeatureAppTypeRela id = "wucFeatureAppTypeRela1" runat = "server" />
</div>
</div>
</div>
</form>
</body>
</html>