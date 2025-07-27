<%@ Register TagPrefix="uc1" TagName="ViewRegion" Src="~/Webform1/RegionManage/ViewRegion.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvViewRegion4Gv" Src="~/Webform1/RegionManage/wucvViewRegion4Gv.ascx" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>

<%@ Page Language="c#" AutoEventWireup="true" CodeBehind="wfmViewInfo_Edit.aspx.cs" Inherits="AGC.Webform.wfmViewInfo_Edit" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>界面设计</title>
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />
    <style>
        ul {
      list-style-type: none;
}
    </style>
</head>
<body>
    <form id="form1" runat="server" class="form-horizontal">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">界面设计
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <div>
                <div class="float-left" style="width: 230px; min-height: 500px; overflow: scroll">
                    <%-- 功能区 --%>

                    <div id="divFunction">
                        <div class="btn-group" role="group" aria-label="Basic example">

                            <asp:Button ID="btnAddNewRegion" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnAddNewRegion_Click" Text="新添" ToolTip="添新区域" runat="server" />
                            <asp:Button ID="btnAddRegion" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnAddRegion_Click" Text="添现有" ToolTip="添现有区域" runat="server" />
                            <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                            <asp:Button ID="btnRename" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnRename_Click" Text="重命名" runat="server" />
                            
                        </div>
                        <div id="divAddNewRegion" runat="server" visible="false">
                            <ul class="no">
                                <li>
                                    <asp:CheckBox ID="chkCopyReferFilesTemplate" runat="server" Text="复制界面引用文件"
                                        CssClass="Check_Defa"></asp:CheckBox>
                                </li>
                                <li>
                                    <asp:CheckBox ID="chkQueryRegion" runat="server" Text="查询区域" AutoPostBack="True"
                                        CssClass="Check_Defa"></asp:CheckBox>
                                </li>
                                <li>
                                    <asp:CheckBox ID="chkDGRegion" runat="server" Text="列表区域" AutoPostBack="True" CssClass="Check_Defa"></asp:CheckBox>
                                </li>
                                <li>
                                    <asp:CheckBox ID="chkEditRegion" runat="server" Text="编辑区域" AutoPostBack="True" CssClass="Check_Defa"></asp:CheckBox>
                                </li>
                                <li>
                                    <asp:CheckBox ID="chkExcelExportRegion" runat="server" Text="Excel导出区域" AutoPostBack="True"
                                        CssClass="Check_Defa"></asp:CheckBox>
                                </li>
                                <li>
                                    <asp:CheckBox ID="chkFeatureRegion" runat="server" Text="功能区域" AutoPostBack="True"
                                        CssClass="Check_Defa"></asp:CheckBox>
                                </li>
                                <li>
                                    <asp:CheckBox ID="chkDetailRegion" runat="server" Text="详细信息区域" AutoPostBack="True"
                                        CssClass="Check_Defa"></asp:CheckBox>

                                </li>
                                <li>
                                    <asp:CheckBox ID="chkTreeViewRegion" runat="server" Text="树区域" AutoPostBack="True"
                                        CssClass="Check_Defa"></asp:CheckBox>
                                </li>
                            </ul>

                            <asp:Button ID="btnStartGene" Style="z-index: 101;"
                                runat="server" Text="开始生成" CssClass="btn btn-outline-info btn-sm"
                                OnClick="btnStartGene_Click" ToolTip="生成界面区域，生成后编辑界面属性，同时生成界面代码"></asp:Button>
                            <asp:Button ID="btnCloseDiv" Style="z-index: 103;" runat="server" Text="取消" CssClass="btn btn-outline-info btn-sm"
                                OnClick="btnCloseDiv_Click"></asp:Button>

                        </div>
                        <div id="divAddRelaRegion" runat="server" visible="false">
                            <asp:ListBox ID="lstViewRegion" runat="server" Visible="False" Width="200px"></asp:ListBox>
                            <br />
                            <asp:Button ID="btnAddRelaRegion" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnAddRelaRegion_Click" Text="添加" runat="server" Visible="False" />
                                 <asp:Button ID="btnCloseDiv4RelaRegion" Style="z-index: 103;" runat="server" Text="取消" CssClass="btn btn-outline-info btn-sm"
                                OnClick="btnCloseDiv4RelaRegion_Click"></asp:Button>
                        </div>
                           <div id="divRename" style="width: 230px" runat="server" visible="false">

                            <asp:Label ID="Label5" name="lblRegionTypeIdq" CssClass="col-form-label" Width="150px" Text="新名称:" runat="server" />
                            <br />

                            <asp:TextBox ID="txtNewRegionName" Width="210px" CssClass="mb-1" runat="server"></asp:TextBox>
                            <br />
                            <asp:Button ID="btnConfirmRename" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnConfirmRename_Click" Text="确认重命名" runat="server" />

                            <asp:Button ID="btnCloseDiv4Rename" runat="server" Text="取消" CssClass="btn btn-outline-info btn-sm text-nowrap"
                                OnClick="btnCloseDiv4Rename_Click" />
                        </div>
                    </div>
                    <%-- 列表层 --%>
                    <div id="divList" class="div_List mt-2" runat="server">
                                                <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:Label ID="Label2" name="lblRegionTypeIdq" CssClass="col-form-label text-right" Width="70px" Text="CM项目" runat="server" />

                            <asp:DropDownList ID="ddlCmPrjIdq" CssClass="form-control" Width="140px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCmPrjId_q_SelectedIndexChanged"  />
                        </div>


                        <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:Label ID="Label1" name="lblRegionTypeIdq" CssClass="col-form-label text-right" Width="70px" Text="应用类型" runat="server" />

                            <asp:DropDownList ID="ddlApplicationTypeId" CssClass="form-control" Width="140px" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlApplicationTypeId_SelectedIndexChanged" />
                        </div>

                        <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:Label ID="lblRegionTypeIdq" name="lblRegionTypeIdq" CssClass="col-form-label text-right" Width="40px" Text="类型" runat="server" />
                            <asp:DropDownList ID="ddlRegionTypeIdq" name="ddlRegionTypeIdq" CssClass="form-control" Width="120px" runat="server" />
                            <asp:ImageButton ID="btnQuery" ImageUrl="~/images/001_37.png" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnQuery_Click" runat="server" />
                        </div>

                        <uc1:wucTreeView runat="server" ID="wucTreeView1" OnafterSelect_Tz="wucTreeView1_afterSelect_Tz" />
                    </div>
                </div>
                <div>
                    <div>
                        <iframe id="iRegionEdit" style="width: 1460px; height: 4000px; overflow-y: hidden;" scrolling="auto" runat="server"></iframe>
                    </div>
                   
                </div>
            </div>
        </div>
    </form>
</body>
</html>
