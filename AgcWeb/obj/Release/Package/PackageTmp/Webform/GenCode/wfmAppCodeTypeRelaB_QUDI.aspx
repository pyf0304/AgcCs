<%@ Register TagPrefix="uc1" TagName="wucAppCodeTypeRelaB" Src="wucAppCodeTypeRelaB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvAppCodeTypeRela4Gv" Src="wucvAppCodeTypeRela4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmAppCodeTypeRelaB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmAppCodeTypeRelaB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>应用程序代码类型关系维护的维护</title>
    
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
        <div id="tabLayout" class="tab_layout" runat="server">
            <%-- 标题层 --%>
            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5">应用程序代码类型关系维护</asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105; left: 54px; position: relative; top: 4px" Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td>
                            <asp:Label ID="lblApplicationTypeIdq"
                                runat="server" CssClass="text-secondary">应用</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlApplicationTypeIdq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblProgLangTypeIdq"
                                runat="server" CssClass="text-secondary">语言</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlProgLangTypeIdq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="Label1"
                                runat="server" CssClass="text-secondary">语言4代码类型</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlProgLangTypeId4CodeType"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblCodeTypeIdq"
                                runat="server" CssClass="text-secondary">代码类型</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlCodeTypeIdq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblCodeTypeENNameq"
                                runat="server" CssClass="text-secondary">依赖于</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlDependsOnq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblFrontOrBackq"
                                runat="server" CssClass="text-secondary">前台Or后台</asp:Label>
                        </td>
                        <td>

                                 <asp:DropDownList ID="ddlFrontOrBackq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblIsVisibleq"
                                runat="server" CssClass="text-secondary">是否显示</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsVisibleq"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 116; width: 80px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" CssClass="btn btn-outline-warning btn-sm" OnClick="btnExportExcel4Gv_Click" Text="导出Excel" runat="server" />

                        </td>


                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="div_Funttion mt-2" runat="server">
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblAppCodeTypeRelaList" CssClass="h6" Width="250px" Text="应用程序代码类型关系列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRec4Gv" CssClass="btn btn-outline-info btn-sm" Width="50px" OnClick="btnAddNewRec4Gv_Click" Text="添加" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:Button ID="btnCopyTo" CssClass="btn btn-outline-info btn-sm" OnClick="btnCopyTo_Click" Text="复制到..." runat="server" />

                            <asp:DropDownList ID="ddlApplicationTypeId"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </div>
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelete4Gv" CssClass="btn btn-outline-info btn-sm" Width="50px" OnClick="btnDelete4Gv_Click" Text="删除" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnUpdate4Gv" CssClass="btn btn-outline-info btn-sm" Width="50px" OnClick="btnUpdate4Gv_Click" Text="修改" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:TextBox ID="txtGroupName"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>

                            <asp:Button ID="btnSetGroupName" CssClass="btn btn-outline-info btn-sm" Width="70px" Text="设置组名" runat="server" OnClick="btnSetGroupName_Click" />
                        </div>
                    </li>
                    <li class="nav-item ml-3">
                        <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:Button ID="btnGoTop" runat="server" Text="移顶" OnClick="btnGoTop_Click" CssClass="btn btn-outline-info btn-sm" />
                            <asp:Button ID="btnUpMove" runat="server" OnClick="btnUpMove_Click" Text="上移" CssClass="btn btn-outline-info btn-sm ml-1" />
                            <asp:Button ID="btnDownMove" runat="server" OnClick="btnDownMove_Click" Text="下移" CssClass="btn btn-outline-info btn-sm ml-1" />
                            <asp:Button ID="btnGoBottum" runat="server" Text="移底" OnClick="btnGoBottum_Click" CssClass="btn btn-outline-info btn-sm ml-1" />
                            <asp:Button ID="btnReOrder" runat="server" OnClick="btnReOrder_Click" Text="重序" CssClass="btn btn-outline-info btn-sm ml-1" />

                        </div>
                    </li>

                    <li class="nav-item ml-3">
                        <asp:Button ID="btnGeneCodeType"
                            Style="z-index: 140; width: 80px;"
                            runat="server"
                            Text="生成" CssClass="btn btn-outline-info btn-sm"
                            OnClick="btnGeneCodeType_Click"></asp:Button>
                    </li>
                </ul>

            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:wucvAppCodeTypeRela4Gv runat="server" ID="wucvAppCodeTypeRela4Gv1"
                    OnGvUpdateClick="wucvAppCodeTypeRela4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvAppCodeTypeRela4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditAppCodeTypeRelaRegion" class="tab_Edit mt-3" runat="server">

                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditAppCodeTypeRela" Width="250px" runat="server"
                                CssClass="h6">应用程序代码类型关系编辑区域</asp:Label>
                        </li>
                    
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelAppCodeTypeRelaEdit" runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelAppCodeTypeRelaEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="208px" CssClass="text-warning"></asp:Label>
                        </li>
                    </ul>

                </div>

                <div class="mt-3">
                    <uc1:wucAppCodeTypeRelaB ID="wucAppCodeTypeRelaB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
