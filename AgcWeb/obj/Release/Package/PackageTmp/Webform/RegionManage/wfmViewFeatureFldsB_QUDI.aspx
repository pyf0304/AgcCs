<%@ Register TagPrefix="uc1" TagName="wucViewFeatureFlds" Src="wucViewFeatureFlds.ascx" %>
<%@ Register Src="~/Webform/RegionManage/wucvViewFeatureFlds4Gv.ascx" TagPrefix="uc2" TagName="wucvViewFeatureFlds4Gv" %>

<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>

<%@ Page Title="表ViewFeatureFlds的查询、修改、删除、添加记录" Language="C#" MasterPageFile="~/Webform/MasterPage/mpViewEdit.Master" CodeBehind="wfmViewFeatureFldsB_QUDI.aspx.cs" ValidateRequest="false"
    AutoEventWireup="True" Inherits="AGC.Webform.wfmViewFeatureFldsB_QUDI" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mt-2" style="width: 100%">
        <div class="col-3">
            <div class="row">
                <div class="col-5">
                    <div class="btn-group " role="group" aria-label="Basic example">
                        <asp:Label ID="lblFeatureIdq" runat="server" CssClass="NameLabel text-nowrap" Text="功能" />
                        <asp:DropDownList ID="ddlFeatureIdq" runat="server" CssClass="ml-2" />
                    </div>
                </div>
                <div class="col-2 ml-2">
                    <%--                    <asp:Button ID="btnAddTabFeature" CssClass="btn btn-info btn-sm" OnClick="btnAddTabFeature_Click" Text="添加表功能" runat="server" />--%>
                </div>
            </div>
            <div class="row mt-2">
                <div class="col-5">
                    <uc1:wucTreeView runat="server" ID="wucTreeView4ViewFeature" OnafterSelect_Tz="wucTreeView4ViewFeature_afterSelect_Tz" />
                </div>
                <div class="col-2 ml-2">
                    <div class="btn-group " role="group" aria-label="Basic example">
                        <asp:Button ID="btnRefreshTv" runat="server" class="btn btn-outline-warning btn-sm" Text="刷新" OnClick="btnRefreshTv_Click" />
                        <asp:Button ID="btnDeleteTabFeature" runat="server" class="btn btn-outline-warning btn-sm" Text="删除" OnClick="btnDeleteTabFeature_Click" />
                    </div>
                </div>
            </div>
        </div>

        <div id="Table1" class="col-9" runat="server">
            <div>

                <table id="tabViewFeatureFldsDataGrid" cellspacing="0" cellpadding="0" width="100%"
                    border="0" runat="server">
                    <tr>
                        <td>
                            <ul class="nav">
                                <li class="nav-item">
                                    <asp:Label ID="Label3" runat="server" CssClass="h6" Width="200px">编辑区域字段列表</asp:Label>
                                </li>

                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnDelete4Dg" runat="server" CssClass="btn btn-outline-info btn-sm"
                                        Text="删除" OnClick="btnDelete4Dg_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnUpdate4Dg" runat="server" CssClass="btn btn-outline-info btn-sm"
                                        Text="修改" OnClick="btnUpdate4Dg_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnSetInUse" runat="server" CssClass="btn btn-outline-info btn-sm"
                                        Text="启用" OnClick="btnSetInUse_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnSetNotInUse" runat="server" CssClass="btn btn-outline-info btn-sm"
                                        Text="不用" OnClick="btnSetNotInUse_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnCopyFldFromRelaTab" runat="server" CssClass="btn btn-outline-info btn-sm" Text="复制表字段"
                                        OnClick="btnCopyFldFromRelaTab_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnPreView" runat="server" CssClass="btn btn-outline-info btn-sm" Text="预览"
                                        OnClick="btnPreView_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <div class="btn-group" role="group" aria-label="Basic example">
                                        <asp:Button ID="btnGoFirstLine" runat="server" CssClass="btn btn-outline-info btn-sm"
                                            Text="首行"
                                            OnClick="btnGoFirstLine_Click"></asp:Button>

                                        <asp:Button ID="btnUpMove" runat="server" CssClass="btn btn-outline-info btn-sm" Text="上移"
                                            OnClick="btnUpMove_Click"></asp:Button>

                                        <asp:Button ID="btnDownMove" runat="server" CssClass="btn btn-outline-info btn-sm" Text="下移"
                                            OnClick="btnDownMove_Click"></asp:Button>

                                        <asp:Button ID="btnGoLastLine" runat="server" CssClass="btn btn-outline-info btn-sm"
                                            Text="尾行"
                                            OnClick="btnGoLastLine_Click"></asp:Button>

                                        <asp:Button ID="btnReOrder" runat="server" CssClass="btn btn-outline-info btn-sm" Text="重序"
                                            OnClick="btnReOrder_Click"></asp:Button>
                                    </div>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:DropDownList ID="ddlFeatureId" CssClass="form-control-sm" runat="server"></asp:DropDownList>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:CheckBox ID="chkOnlyShowFldInUse" runat="server" CssClass="form-control-sm" Text="仅显使用字段" Width="120px" Checked="false" OnCheckedChanged="chkOnlyShowFldInUse_CheckedChanged" AutoPostBack="True" />
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Label ID="lblMsg1" runat="server" CssClass="text-danger" Width="248px" ForeColor="Red"></asp:Label>
                                </li>

                            </ul>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <%-- 列表层 --%>
                            <div id="divList" class="div_List" runat="server">
                                <uc2:wucvViewFeatureFlds4Gv runat="server" ID="wucvViewFeatureFlds4Gv1"
                                    OnGvUpdateClick="wucvViewFeatureFlds4Gv1_GvUpdateClick"
                                    OnGvDeleteClick="wucvViewFeatureFlds4Gv1_GvDeleteClick" />
                            </div>

                        </td>
                    </tr>
                    <tr>
                        <td></td>
                    </tr>
                </table>
                <table id="tabEditViewFeatureFldsRegion" style="width: 373px" cellspacing="1" cellpadding="1"
                    width="373" border="1" runat="server">
                    <tr>
                        <td>
                            <ul class="nav">
                                <li class="nav-item">
                                    <asp:Label ID="Label4"
                                        runat="server" Width="128px" CssClass="h6">编辑字段属性</asp:Label>
                                </li>

                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnOKUpd"
                                        runat="server" CssClass="btn btn-outline-info btn-sm" Width="80px" Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Button ID="btnCancelFeatureRegionFldsEdit" runat="server"
                                        Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelFeatureRegionFldsEdit_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-2">
                                    <asp:Label ID="lblMsg" CssClass="text-danger" runat="server" Width="208px"></asp:Label>
                                </li>


                            </ul>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <uc1:wucViewFeatureFlds ID="wucViewFeatureFlds1" runat="server"></uc1:wucViewFeatureFlds>
                        </td>
                    </tr>
                </table>

            </div>
            
            <div>

                <table id="tabEditRegionPreview" cellspacing="1" cellpadding="1" width="300" border="1"
                    runat="server">
                    <tr>
                        <td>
                            <div style="width: 808px; position: relative; height: 24px">
                                <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px; height: 2px"
                                    height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                <asp:Label ID="Label5" Style="z-index: 109; left: 8px; position: absolute; top: 8px"
                                    runat="server" CssClass="RegionTitleH1">编辑区域预览</asp:Label>
                            </div>
                        </td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <div id="divQryRegionPreview" style="width: 720px;" runat="server">
                                <asp:PlaceHolder ID="phEditRegion" runat="server"></asp:PlaceHolder>
                            </div>
                        </td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                </table>

            </div>

            <div>

                <table id="tabCode" style="width: 816px; height: 551px" cellspacing="1" cellpadding="1"
                    width="816" border="1" runat="server">
                    <tr>
                        <td colspan="2">
                            <div style="width: 800px; position: relative; height: 32px">
                                <asp:Label ID="lblCaption4GenCode" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                                    runat="server" Width="120px">生成的逻辑层代码：</asp:Label>
                                <asp:LinkButton ID="lbDispTabList" Style="z-index: 102; left: 664px; position: absolute; top: 8px"
                                    runat="server" OnClick="lbDispTabList_Click">显示编辑区域字段列表</asp:LinkButton>
                                <asp:Label ID="Label6" Style="z-index: 103; left: 152px; position: absolute; top: 8px"
                                    runat="server" Width="80px">生成文件名：</asp:Label>
                                <asp:TextBox ID="txtFileName4GenCode" Style="z-index: 104; left: 248px; position: absolute; top: 8px"
                                    runat="server" Width="336px"></asp:TextBox>
                                <asp:LinkButton ID="lbDownLoadFile" Style="z-index: 111; left: 600px; position: absolute; top: 8px"
                                    runat="server" Width="56px" OnClick="lbDownLoadFile_Click">下载文件</asp:LinkButton>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Literal ID="litCode" runat="server"></asp:Literal>
                        </td>
                    </tr>
                </table>

            </div>
        </div>
    </div>

</asp:Content>

