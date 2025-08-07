<%@ Register TagPrefix="uc1" TagName="wucConstraintFieldsB" Src="wucConstraintFieldsB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvConstraintFields4Gv" Src="wucvConstraintFields4Gv.ascx" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>


<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmConstraintFieldsB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmConstraintFieldsB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>约束字段维护的维护</title>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
 <%--   --%>
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

            <div style="position: relative; width: 648px; height: 27px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" Visible="true" >约束字段维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table id="tabQuery" style="width: 80%;" class="msgtable">
                    <tr>
                        <td>
                            <asp:Label ID="lblPrjConstraintIdq" CssClass="text-secondary" Width="90px" Text="约束" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPrjConstraintIdq" Width="200px"  runat="server" />
                        </td>


                        <td>
                            <asp:Label ID="lblSortTypeIdq" CssClass="text-secondary" Width="90px" Text="排序类型Id" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlSortTypeIdq" Width="200px"  runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnQuery"  CssClass="btn btn-outline-warning btn-sm"  OnClick="btnQuery_Click" Text="查询" runat="server" />
                        </td>
                    </tr>
                    <tr id="trHidden" runat="server">
                        <td>
                            <asp:Label ID="lblTabIdq" CssClass="text-secondary" Width="90px" Text="表ID" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTabIdq" Width="200px"  runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblFldIdq" CssClass="text-secondary" Width="90px" Text="字段ID" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFldIdq" Width="200px"  runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="div_Funttion" runat="server">
                  <ul class="nav">
                       <li class="nav-item">
                           
                            <asp:Label ID="lblConstraintFieldsList"  CssClass="h6" Width="250px" Text="约束字段列表" runat="server" />
                      </li>
                       <li class="nav-item ml-3">
                            <asp:Button ID="btnAddNewRecord"  CssClass="btn btn-outline-info btn-sm"  OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                      </li>
                       <li class="nav-item ml-3">
                            <asp:Button ID="btnUpdateRecord"  CssClass="btn btn-outline-info btn-sm"  OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                      </li>
                       <li class="nav-item ml-3">
                            <asp:Button ID="btnSetInUse"  CssClass="btn btn-outline-info btn-sm" OnClick="btnSetInUse_Click" Text="设置在用" runat="server" />
                      </li>
                       <li class="nav-item ml-3">
                            <asp:Button ID="btnSetNotInUse"  CssClass="btn btn-outline-info btn-sm" OnClick="btnSetNotInUse_Click" Text="设置不用" runat="server" />
                      </li>
                       <li class="nav-item ml-3">
                            <asp:Button ID="btnDelRecord"  CssClass="btn btn-outline-info btn-sm"  OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                      </li>
                       <li class="nav-item ml-3">
                            <asp:Button ID="btnExportExcel"  CssClass="btn btn-outline-info btn-sm"  OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                      </li>
                    </ul>
            </div>
            <%-- 列表层 --%>

            <div style="width: 100%">
                <div style="width: 20%; float: left">
                    <div>
                        <asp:Label ID="Label1" runat="server" CssClass="h7" Text="约束类型->约束名"></asp:Label>
                        <asp:Button ID="btnRefreshTv" runat="server" CssClass="btn btn-outline-warning btn-sm" Text="刷新" OnClick="btnRefreshTv_Click" />
                    </div>
                    <div>
                        <uc1:wucTreeView runat="server" ID="wucTreeView4Constraint" OnafterSelect_Tz="wucTreeView4Constraint_afterSelect_Tz" />
                    </div>
                </div>

                <div id="divList" class="div_List" style="width:80%; float:right;" runat="server">
                    <uc2:wucvConstraintFields4Gv runat="server" ID="wucvConstraintFields4Gv1"
                        OnGvUpdateClick="wucvConstraintFields4Gv1_GvUpdateClick"
                        OnGvDeleteClick="wucvConstraintFields4Gv1_GvDeleteClick" />
                </div>
            </div>



            <%-- 编辑层 --%>
            <div id="tabEditConstraintFieldsRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditConstraintFields"  runat="server"
                                    CssClass="h6">约束字段编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit"  runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>

                                <asp:Button ID="btnCancelConstraintFieldsEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelConstraintFieldsEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucConstraintFieldsB ID="wucConstraintFieldsB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
