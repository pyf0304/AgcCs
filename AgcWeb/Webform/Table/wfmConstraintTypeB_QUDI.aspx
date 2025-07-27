<%@ Register TagPrefix="uc1" TagName="wucConstraintTypeB" Src="wucConstraintTypeB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucConstraintType4Gv" Src="wucConstraintType4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmConstraintTypeB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmConstraintTypeB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>约束类型维护的维护</title>
    <link rel="stylesheet" type="text/css" href="../../css/tz_base1.css" />
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >约束类型维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table id="tabQuery" style="width: 80%;" class="msgtable">
                    <tr>
                        <td>
                            <asp:Label ID="lblConstraintTypeIdq" CssClass="text-secondary" Width="90px" Text="约束类型Id" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtConstraintTypeIdq" Width="200px"  runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblConstraintTypeNameq" CssClass="text-secondary" Width="90px" Text="约束类型名" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtConstraintTypeNameq" Width="200px"  runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblConstraintTypeNameENq" CssClass="text-secondary" Width="90px" Text="约束类型英文名" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtConstraintTypeNameENq" Width="200px"  runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnQuery"  CssClass="btn btn-outline-warning btn-sm"  OnClick="btnQuery_Click" Text="查询" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="div_Funttion" runat="server">
                <table id="tabGridFunction" style="width: 100%; height: 32px;" class="msgtable">
                    <tr>
                        <td>
                            <asp:Label ID="lblConstraintTypeList"  CssClass="h6" Width="250px" Text="约束类型列表" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnAddNewRecord"  CssClass="btn btn-outline-info btn-sm"  OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnCopyRecord"  CssClass="btn btn-outline-info btn-sm" OnClick="btnCopyRecord_Click" Text="复制记录" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnUpdateRecord"  CssClass="btn btn-outline-info btn-sm"  OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnDelRecord"  CssClass="btn btn-outline-info btn-sm"  OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel"  CssClass="btn btn-outline-info btn-sm"  OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List" runat="server">
                <uc2:wucConstraintType4Gv runat="server" ID="wucConstraintType4Gv1"
                    OnGvUpdateClick="wucConstraintType4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucConstraintType4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditConstraintTypeRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditConstraintType"  runat="server"
                                    CssClass="h6">约束类型编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit"  runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>

                                <asp:Button ID="btnCancelConstraintTypeEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelConstraintTypeEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucConstraintTypeB ID="wucConstraintTypeB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
