<%@ Register TagPrefix="uc1" TagName="wucButtonTabB" Src="wucButtonTabB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucButtonTab4Gv" Src="wucButtonTab4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true" CodeBehind="wfmButtonTabB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmButtonTabB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>ButtonTab维护的维护</title>
    <link rel="stylesheet" type="text/css" href="../../css/tz_base1.css" />
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
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
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5">ButtonTab维护 </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105; left: 54px; position: relative; top: 4px" Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td>
                            <asp:Label ID="lblButtonIdq"
                                runat="server" CssClass="NameLabel">按钮Id</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtButtonIdq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblButtonNameq"
                                runat="server" CssClass="NameLabel">按钮名称</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtButtonNameq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblTextq" 
                                runat="server" CssClass="NameLabel">文本</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtTextq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblCssClassq"
                                runat="server" CssClass="NameLabel">样式表</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCssClassq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 116; width: 80px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="div_Funttion" runat="server">
                <table id="tabGridFunction" style="width: 100%; height: 32px;" class="msgtable">
                    <tr>
                        <td>
                            <asp:Label ID="lblButtonTabList" CssClass="h6" Width="250px" Text="按钮表列表" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnAddNewRec4Gv" CssClass="btn btn-outline-info btn-sm" OnClick="btnAddNewRec4Gv_Click" Text="添加" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnDelete4Gv" CssClass="btn btn-outline-info btn-sm" OnClick="btnDelete4Gv_Click" Text="删除" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnUpdate4Gv" CssClass="btn btn-outline-info btn-sm" OnClick="btnUpdate4Gv_Click" Text="修改" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnGoTop" CssClass="btn btn-outline-info btn-sm"  OnClick="btnGoTop_Click" Text="移顶" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnUpMove" CssClass="btn btn-outline-info btn-sm"  OnClick="btnUpMove_Click" Text="上移" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnDownMove" CssClass="btn btn-outline-info btn-sm"  OnClick="btnDownMove_Click" Text="下移" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnGoBottum" CssClass="btn btn-outline-info btn-sm"  OnClick="btnGoBottum_Click" Text="移底" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnReOrder" CssClass="btn btn-outline-info btn-sm"  OnClick="btnReOrder_Click" Text="重序" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" CssClass="btn btn-outline-info btn-sm" OnClick="btnExportExcel4Gv_Click" Text="导出Excel" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List" runat="server">
                <uc2:wucButtonTab4Gv runat="server" ID="wucButtonTab4Gv1"
                    OnGvUpdateClick="wucButtonTab4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucButtonTab4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditButtonTabRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditButtonTab" runat="server"
                                    CssClass="h6">按钮表编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit" runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                    Width="80px" Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                &nbsp;
                                <asp:Button ID="btnCancelButtonTabEdit"
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelButtonTabEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucButtonTabB ID="wucButtonTabB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
