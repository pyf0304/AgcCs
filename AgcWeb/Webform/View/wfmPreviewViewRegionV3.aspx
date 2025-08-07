<%@ Page Language="c#" CodeBehind="wfmPreviewViewRegionV3.aspx.cs" AutoEventWireup="True"
    ValidateRequest="FALSE" Inherits="AGC.Webform.wfmPreviewViewRegionV3" %>

<%@ Register Src="~/Webform/CommonControl/wucQryRegion4Preview.ascx" TagPrefix="uc1" TagName="wucQryRegion4Preview" %>
<%@ Register Src="~/Webform/CommonControl/wucListRegion4Preview.ascx" TagPrefix="uc1" TagName="wucListRegion4Preview" %>
<%@ Register Src="~/Webform/CommonControl/wucFeatureRegionButton4Visible.ascx" TagPrefix="uc1" TagName="wucFeatureRegionButton4Visible" %>
<%@ Register Src="~/Webform/CommonControl/wucEditRegion4PreviewV2.ascx" TagPrefix="uc1" TagName="wucEditRegion4Preview" %>
<%@ Register Src="~/Webform/CommonControl/wucDetailRegion4Preview.ascx" TagPrefix="uc1" TagName="wucDetailRegion4Preview" %>
<%@ Register Src="~/Webform/CommonControl/wucExcelExportRegion4Preview.ascx" TagPrefix="uc1" TagName="wucExcelExportRegion4Preview" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>界面预览</title>
    
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
         <div class="panel panel-info mt-2">
        <div class="panel-body">
            <ul class="nav">
                <li class="nav-item">
                    <asp:Label ID="lblTitle" runat="server" Text="区域信息" Width="100px" CssClass="h6 text-warning"></asp:Label>
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_QueryRegion" Text="使用查询区" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_FeatureRegion" Text="使用功能区" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_ListRegion" Text="使用列表区" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_EditRegion" Text="使用编辑区" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_DetailRegion" Text="使用详细信息区" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_ExcelExportRegion" Text="使用导出区" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
            </ul>
        </div>
    </div>

        <div class="panel panel-info mt-2">
            <asp:Label ID="lblMsg" Style="z-index: 111; left: 278px; position: absolute; top: 21px"
                runat="server" CssClass="text-warning" Width="272px"></asp:Label>
        </div>
        <div class="panel panel-info mt-2">
            <div class="panel-body">
                <uc1:wucQryRegion4Preview runat="server" ID="wucQryRegion4Preview1" />
            </div>
        </div>
        <div class="panel panel-info mt-2">
            <div class="panel-body">
                <uc1:wucFeatureRegionButton4Visible runat="server" ID="wucFeatureRegionButton4Visible1" />
            </div>
        </div>
        <div class="panel panel-info mt-2">
            <div class="panel-body">
                <uc1:wucListRegion4Preview runat="server" ID="wucListRegion4Preview1" />
            </div>
        </div>
       <div style="width: 100%" >
            <uc1:wucEditRegion4Preview runat="server" ID="wucEditRegion4Preview1" />
    </div>
      <div style="width: 100%" >
            <uc1:wucDetailRegion4Preview runat="server" ID="wucDetailRegion4Preview1" />
    </div>

    <div style="width: 100%" >  
            <uc1:wucExcelExportRegion4Preview runat="server" ID="wucExcelExportRegion4Preview1" />
    </div>

    </form>
</body>
</html>
