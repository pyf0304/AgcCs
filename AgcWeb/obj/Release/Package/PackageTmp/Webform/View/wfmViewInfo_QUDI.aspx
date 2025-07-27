<%@ Register TagPrefix="uc1" TagName="wucViewInfo" Src="wucViewInfo.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvViewInfo4Gv" Src="~/Webform/View/wucvViewInfo4Gv.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmViewInfo_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmViewInfo_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表ViewInfo的查询、修改、删除、添加记录</title>

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
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true">
        </asp:ScriptManager>
        <div style="width: 100%">
               <ul class="nav">
            <li class="nav-item">
                    <asp:Label ID="Label3" Style="z-index: 103;" runat="server" CssClass="h5">项目界面管理->界面信息维护</asp:Label>
                </li>
                <li class="nav-item ml-2"></li>
                <li class="nav-item ml-2"></li>
                <li class="nav-item ml-2">
                    <asp:Label ID="Label6" runat="server" CssClass="text-info  font-weight-bold" Width="60px">CM项目</asp:Label>
                </li>

                <li class="nav-item">
                    <asp:DropDownList ID="ddlCmPrjIdq" runat="server" OnSelectedIndexChanged="ddlCmPrjId_q_SelectedIndexChanged" CssClass="text-danger  font-weight-bold" AutoPostBack="true" Width="150px"></asp:DropDownList>
                </li>

                <li class="nav-item ml-2">
                    <asp:Label ID="Label4" Style="z-index: 101;"
                        runat="server" Height="40px" CssClass="MemoStyle1">主要用户设计在项目中的界面。设置界面各种要素，包括：界面类型、功能、流程、相关表，以及主键等信息。</asp:Label>
                </li>
            </ul>
        </div>


        <table id="tabHidden" style="z-index: 102; width: 100%"
            cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
            <tr>
                <td>
                    <asp:Button ID="btnSetViewFld" runat="server" Width="88px" Text="设置界面字段"></asp:Button>
                </td>
                <td></td>
                <td style="width: 61px">
                    <asp:Label ID="lblUserIdq" runat="server">用户ID</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUserIdq" runat="server" Width="49px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblPrjIdq" runat="server">工程ID</asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="112px">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        &nbsp; &nbsp;
    <table id="Table1" style="z-index: 106; left: 8px; width: 100%; position: absolute; top: 40px; height: 659px"
        cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
            <td valign="top">
                <table id="tabQueryRegion" cellspacing="1" cellpadding="1" width="100%" border="2" runat="server">
                    <tr>
                        <td colspan="2" style="height: 64px">
                            <table id="tabQuery" style="height: 48px" bordercolor="#666666" cellspacing="1" cellpadding="1"
                                width="80%" border="2">
                                <tr>
                                    <td>
                                        <asp:Label ID="lblViewNameq" runat="server" Width="75px" CssClass="auto-style1">界面名称</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtViewNameq" runat="server" Width="180px"></asp:TextBox>
                                    </td>
                                    <td style="width: 62px">
                                        <asp:Label ID="lblApplicationTypeIdq" runat="server" Width="95px"
                                            CssClass="auto-style1">应用程序类型</asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlApplicationTypeIdq" runat="server" Width="126px"
                                            OnSelectedIndexChanged="ddlApplicationTypeId_q_SelectedIndexChanged" AutoPostBack="True">
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Width="65px" CssClass="auto-style1">功能模块</asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlFuncModuleIdq" runat="server" Width="170px">
                                        </asp:DropDownList>
                                    </td>
                                    <td class="style2">
                                        <asp:Button ID="btnExportExcel" runat="server"
                                            Text="导出Excel" CssClass="btn btn-outline-warning btn-sm" OnClick="btnExportExcel_Click"></asp:Button>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblMainTabNameq" runat="server" Width="75px" CssClass="auto-style1">界面表名</asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlMainTabIdq" runat="server">
                                        </asp:DropDownList>
                                    </td>
                                    <td style="width: 62px">
                                        <asp:Label ID="lblViewTypeCodeq" runat="server" Width="72px" CssClass="text-secondary">界面类型</asp:Label>
                                    </td>
                                    <td>
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="ddlViewTypeCodeq" runat="server" Width="125px">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                            <Triggers>
                                                <asp:AsyncPostBackTrigger ControlID="ddlApplicationTypeIdq" EventName="SelectedIndexChanged" />
                                            </Triggers>
                                        </asp:UpdatePanel>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblViewGroupIdq" runat="server" Width="66px" CssClass="auto-style1">界面组</asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlViewGroupIdq" runat="server" Width="168px">
                                        </asp:DropDownList>
                                    </td>
                                    <td class="style2">
                                        <asp:Button ID="btnQuery" runat="server" Text="查询" CssClass="btn btn-outline-warning btn-sm" OnClick="btnQuery_Click"></asp:Button>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <table>
                                <tr>
                                    <td class="style3">
                                        <asp:Label ID="Label2" runat="server" CssClass="h6" Width="200px">界面列表</asp:Label>

                                    </td>
                                    <td>
                                        <asp:Button ID="btnAddNewView" runat="server"
                                            Text="添加" CssClass="btn btn-outline-info btn-sm" OnClick="btnAddNewView_Click"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnClone" runat="server"
                                            Text="克隆" CssClass="btn btn-outline-info btn-sm" OnClick="btnClone_Click"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnUpdate" runat="server"
                                            Text="修改" CssClass="btn btn-outline-info btn-sm" OnClick="btnUpdate_Click"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnDelete" Style="z-index: 103;" runat="server"
                                            Text="删除" CssClass="btn btn-outline-info btn-sm" OnClick="btnDelete_Click"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnSetViewStyle" runat="server"
                                            Width="88px" CssClass="btn btn-outline-info btn-sm" Text="设置界面区域" OnClick="btnSetViewStyle_Click" Visible="False"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnEditViewField" runat="server"
                                            Width="10px" CssClass="btn btn-outline-info btn-sm" Text="编辑界面字段" Visible="False" OnClick="btnEditViewField_Click"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnEditViewAll" runat="server"
                                            Width="135px" Text="编辑界面区域属性" CssClass="btn btn-outline-info btn-sm" OnClick="btnEditViewAll_Click"
                                            Font-Bold="True" ToolTip="编辑界面各区域属性，并且生成界面代码。"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnDesignView" runat="server"
                                            Width="72px" Text="设计界面" CssClass="btn btn-outline-info btn-sm" Visible="False" OnClick="btnDesignView_Click"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnGeneCode" runat="server" Width="72px"
                                            Text="生成代码" CssClass="btn btn-outline-info btn-sm" OnClick="btnGeneCode_Click" Visible="False"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnEditRelaTab" runat="server"
                                            Width="72px" Text="编辑相关表" CssClass="btn btn-outline-info btn-sm" Visible="False" OnClick="btnEditRelaTab_Click"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnDelViewEx" runat="server"
                                            Width="72px" Text="扩展删除" CssClass="btn btn-outline-info btn-sm" Visible="False" OnClick="btnDelViewEx_Click"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnCheckRegion" runat="server" Width="72px"
                                            Text="检查区域" CssClass="btn btn-outline-info btn-sm" OnClick="btnCheckRegion_Click" Visible="false"></asp:Button>
                                    </td>
                                     <td>
                                        <asp:Button ID="btnCheckRegionFlds" runat="server" Width="94px"
                                            Text="检查区域控件" CssClass="btn btn-outline-info btn-sm" OnClick="btnCheckRegionFlds_Click" ></asp:Button>
</td>
                                    <td>    
                    <asp:DropDownList ID="ddlCmPrjId_Set" runat="server" CssClass="text-danger  font-weight-bold" Width="120px"></asp:DropDownList>
                </td>
                                    <td>
                                        <asp:Button ID="btnSetCmPrjId" runat="server" Width="94px"
                                            Text="设置CM工程" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetCmPrjId_Click" ></asp:Button>
</td>

                                                                    <td>
                                        <asp:Button ID="btnAutoGetPath4RegionFlds" runat="server" Width="197px"
                                            Text="为区域字段自动获取路径" CssClass="btn btn-outline-info btn-sm" OnClick="btnAutoGetPath4RegionFlds_Click" ></asp:Button>
</td>
                                    
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <%-- 列表层 --%>
                            <div id="divList" class="div_List" runat="server">
                                <uc2:wucvViewInfo4Gv runat="server" ID="wucvViewInfo4Gv1"
                                    OnGvEditViewRegionClick="wucvViewInfo4Gv1_GvEditViewRegionClick"
                                    OnGvAddViewRegionClick="wucvViewInfo4Gv1_GvAddViewRegionClick" />
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblRecCount" runat="server" Width="110px" Font-Names="宋体"
                                Font-Size="Smaller">查询结果记录数：</asp:Label>
                        </td>
                        <td rowspan="1" class="style1">
                            <asp:TextBox ID="txtRecCount" runat="server" Width="111px" Font-Names="宋体"
                                Font-Size="Smaller" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td valign="top">
                <table id="tabEditRegion" style="width: 592px; height: 200px"
                    cellspacing="1"
                    cellpadding="1" width="592" border="4" runat="server">
                    <tr>
                        <td valign="top">
                            <div style="width: 808px; position: relative; height: 28px">
                                <img style="z-index: 101; left: 0px; width: 776px; position: absolute; top: 0px; height: 2px"
                                    height="2" alt="" src="../../pic/兰色直线1.gif" width="776">
                                <asp:Label ID="Label5" Style="z-index: 102; left: 0px; position: absolute; top: 8px"
                                    runat="server" CssClass="h6">编辑界面属性</asp:Label>
                                <asp:Button ID="btnOKUpd" runat="server" Width="72px" Text="添加" Style="z-index: 103; left: 608px; position: absolute; top: 0px"
                                    OnClick="btnOKUpd_Click"></asp:Button>
                                <asp:Label ID="lblMsg" runat="server" Width="215px" Height="13px" Style="z-index: 104; left: 384px; position: absolute; top: 8px"
                                    CssClass="text-warning"></asp:Label>
                                <asp:LinkButton ID="lbDispViewList" runat="server" Style="z-index: 105; left: 704px; position: absolute; top: 8px"
                                    OnClick="lbDispViewList_Click">显示界面列表</asp:LinkButton>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" colspan="2">
                            <uc1:wucViewInfo ID="wucViewInfo1" runat="server"></uc1:wucViewInfo>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td></td>
        </tr>
    </table>
        <asp:Label ID="lblMsgList" runat="server" Height="13px" Width="128px" Style="z-index: 107; left: 232px; position: absolute; top: 8px"
            CssClass="text-warning"></asp:Label>
    </form>
</body>
</html>
