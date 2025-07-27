<%@ Register TagPrefix="uc1" TagName="wucFeatureFieldTypeRelaB" Src="wucFeatureFieldTypeRelaB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvFeatureFieldTypeRela4Gv" Src="wucvFeatureFieldTypeRela4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmFeatureFieldTypeRelaB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmFeatureFieldTypeRelaB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>功能字段类型关系维护的维护</title>
    
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >功能字段类型关系维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table id="tabQuery" style="width: 80%;" class="msgtable">
                    <tr>
                        <td>
                            <asp:Label ID="lblFeatureIdq" CssClass="text-secondary" Width="58px" Text="功能" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFeatureIdq" Width="200px"  runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblFieldTypeIdq" CssClass="text-secondary" Width="90px" Text="字段类型Id" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFieldTypeIdq" Width="200px"  runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnQuery"  CssClass="btn btn-outline-warning btn-sm"  OnClick="btnQuery_Click" Text="查询" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="div_Funttion; width: 100%; height: 32px;" runat="server">
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblFeatureFieldTypeRelaList" CssClass="h6" Width="250px" Text="功能字段类型关系列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecord"  CssClass="btn btn-outline-info btn-sm" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnUpdateRecord"  CssClass="btn btn-outline-info btn-sm" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelRecord"  CssClass="btn btn-outline-info btn-sm" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnExportExcel"  CssClass="btn btn-outline-info btn-sm" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                    </li>
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List" runat="server">
                <uc2:wucvFeatureFieldTypeRela4Gv runat="server" ID="wucvFeatureFieldTypeRela4Gv1"
                    OnGvUpdateClick="wucvFeatureFieldTypeRela4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvFeatureFieldTypeRela4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditFeatureFieldTypeRelaRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditFeatureFieldTypeRela"  runat="server"
                                    CssClass="h6">功能字段类型关系编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit"  runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>

                                <asp:Button ID="btnCancelFeatureFieldTypeRelaEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelFeatureFieldTypeRelaEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucFeatureFieldTypeRelaB ID="wucFeatureFieldTypeRelaB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
