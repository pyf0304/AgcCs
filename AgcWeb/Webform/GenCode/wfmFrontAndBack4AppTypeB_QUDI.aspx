<%@ Register TagPrefix="uc1" TagName="wucFrontAndBack4AppTypeB" Src="wucFrontAndBack4AppTypeB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvFrontAndBack4AppType4Gv" Src="wucvFrontAndBack4AppType4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmFrontAndBack4AppTypeB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmFrontAndBack4AppTypeB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>应用类型的前后台关系维护的维护</title>
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >应用类型的前后台关系维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td>
                            <asp:Label ID="lblAppTypeId4Frontq" 
                                runat="server" CssClass="text-secondary">应用类型Id4Front</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlAppTypeId4Frontq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblAppTypeId4Backq" 
                                runat="server" CssClass="text-secondary">应用类型Id4Back</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlAppTypeId4Backq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 110; width: 80px;"
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
                            <asp:Label ID="lblFrontAndBack4AppTypeList"  CssClass="h6" Width="250px" Text="应用类型的前后台关系列表" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnAddNewRec4Gv"  CssClass="btn btn-outline-info btn-sm"  OnClick="btnAddNewRec4Gv_Click" Text="添加" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnDelete4Gv"  CssClass="btn btn-outline-info btn-sm"  OnClick="btnDelete4Gv_Click" Text="删除" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnUpdate4Gv"  CssClass="btn btn-outline-info btn-sm"  OnClick="btnUpdate4Gv_Click" Text="修改" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv"  CssClass="btn btn-outline-info btn-sm"  OnClick="btnExportExcel4Gv_Click" Text="导出Excel" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List" runat="server">
                <uc2:wucvFrontAndBack4AppType4Gv runat="server" ID="wucvFrontAndBack4AppType4Gv1"
                    OnGvUpdateClick="wucvFrontAndBack4AppType4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvFrontAndBack4AppType4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditFrontAndBack4AppTypeRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditFrontAndBack4AppType"  runat="server"
                                    CssClass="h6">应用类型的前后台关系编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit"  runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>

                                <asp:Button ID="btnCancelFrontAndBack4AppTypeEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelFrontAndBack4AppTypeEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucFrontAndBack4AppTypeB ID="wucFrontAndBack4AppTypeB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
