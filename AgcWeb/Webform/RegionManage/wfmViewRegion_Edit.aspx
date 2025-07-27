<%@ Register TagPrefix="uc1" TagName="ViewRegion" Src="~/Webform1/RegionManage/ViewRegion.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvViewRegion4Gv" Src="~/Webform1/RegionManage/wucvViewRegion4Gv.ascx" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>

<%@ Page Language="c#" AutoEventWireup="true" CodeBehind="wfmViewRegion_Edit.aspx.cs" Inherits="AGC.Webform.wfmViewRegion_Edit" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>界面区域维护的维护</title>
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="form-horizontal">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">界面区域维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <div>
                <div class="float-left" style="width: 230px; overflow: scroll">
                    <%-- 功能区 --%>

                    <div id="divFunction" class="table table-bordered table-hover">
                        <ul class="nav">
                        
  
                            <li class="nav-item ml-1">
                                <asp:Button ID="btnRename" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnRename_Click" Text="重命名" runat="server" />
                            </li>
                            <li class="nav-item ml-1">
                                <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                            </li>
                            <li class="nav-item ml-1">
                                <asp:Button ID="btnCopy" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnCopy_Click" Text="复制" runat="server" />
                            </li>

                        </ul>
                        <div id="divCopy" style="width: 230px" runat="server" visible="false">

                            <asp:Label ID="Label2" name="lblRegionTypeIdq" CssClass="col-form-label " Width="150px" Text="应用类型:" runat="server" />
                            <br />

                            <asp:DropDownList ID="ddlApplicationTypeId2" CssClass="form-control" Width="210px" runat="server" />
                            <br />

                            <asp:Label ID="Label3" name="lblRegionTypeIdq" CssClass="col-form-label" Width="150px" Text="新名称:" runat="server" />
                            <br />

                            <asp:TextBox ID="txtRegionName" Width="210px" CssClass="mb-1" runat="server"></asp:TextBox>
                            <br />
                            <asp:Button ID="btnConfirmCopy" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnConfirmCopy_Click" Text="确认复制" runat="server" />

                            <asp:Button ID="btnCloseDiv4Copy" runat="server" Text="取消" CssClass="btn btn-outline-info btn-sm text-nowrap"
                                OnClick="btnCloseDiv4Copy_Click" />
                        </div>
                          <div id="divRename" style="width: 230px" runat="server" visible="false">

                            <asp:Label ID="Label5" name="lblRegionTypeIdq" CssClass="col-form-label" Width="150px" Text="新名称:" runat="server" />
                            <br />

                            <asp:TextBox ID="txtNewRegionName" Width="210px" CssClass="mb-1" runat="server"></asp:TextBox>
                            <br />
                                     <asp:Label ID="Label4" name="lblRegionTypeIdq" CssClass="col-form-label" Width="150px" Text="新应用类型:" runat="server" />
                            <br />
                                                          <asp:DropDownList ID="ddlApplicationTypeId3" CssClass="form-control" Width="210px" runat="server" />

                            <br />
                            <asp:Button ID="btnConfirmRename" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnConfirmRename_Click" Text="确认重命名" runat="server" />

                            <asp:Button ID="btnCloseDiv4Rename" runat="server" Text="取消" CssClass="btn btn-outline-info btn-sm text-nowrap"
                                OnClick="btnCloseDiv4Rename_Click" />
                        </div>

                    </div>
                    <%-- 列表层 --%>
                    <div id="divList" class="div_List mt-2" runat="server">
                        <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:Label ID="Label1" name="lblRegionTypeIdq" CssClass="col-form-label text-right" Width="70px" Text="应用类型" runat="server" />

                            <asp:DropDownList ID="ddlApplicationTypeId" CssClass="form-control" Width="140px" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlApplicationTypeId_SelectedIndexChanged" />
                        </div>

                        <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:Label ID="lblRegionTypeIdq" name="lblRegionTypeIdq" CssClass="col-form-label text-right" Width="40px" Text="类型" runat="server" />
                            <asp:DropDownList ID="ddlRegionTypeIdq" name="ddlRegionTypeIdq" CssClass="form-control" Width="120px" runat="server" />
                            <asp:Button ID="btnQuery" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnQuery_Click" Text="查询" runat="server" />
                        </div>
                        <div>
                            <asp:CheckBox ID="chkIsShowModule" Text="显示模块" Checked="false" runat="server" AutoPostBack="True" OnCheckedChanged="chkIsShowModule_CheckedChanged" />
                        </div>
                        <uc1:wucTreeView runat="server" ID="wucTreeView1" OnafterSelect_Tz="wucTreeView1_afterSelect_Tz" />
                    </div>
                </div>
                <div>
                    <div>
                        <iframe id="iRegionEdit" style="width: 1460px; height: 4000px; overflow-y: hidden;" scrolling="auto" runat="server"></iframe>
                    </div>
                    <%-- 编辑层 --%>
                    <div id="tabEditViewRegionRegion" class="tab_Edit mt-2 float-left"
                        runat="server">
                        <div style="width: 60%;">
                            <ul class="nav">
                                <li class="nav-item">
                                    <asp:Label ID="lblEditViewRegion" Style="z-index: 104;" Width="200px" runat="server"
                                        CssClass="col-form-label text-info">界面区域编辑区域</asp:Label>
                                </li>
                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                        Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                                </li>
                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnCancelViewRegionEdit"
                                        runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelViewRegionEdit_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-3">
                                    <asp:Label ID="lblMsgEdit" runat="server"
                                        Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                                </li>
                            </ul>
                        </div>
                        <div>
                            <uc1:ViewRegion ID="ViewRegion1" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
