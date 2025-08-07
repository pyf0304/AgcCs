<%@ Register TagPrefix="uc1" TagName="wucQryRegionFldsB" Src="wucQryRegionFldsB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvQryRegionFlds4Gv" Src="wucvQryRegionFlds4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true" CodeBehind="wfmQryRegionFldsB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmQryRegionFldsB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>查询区域字段列表维护的维护</title>
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
      <script type="text/javascript" src="../../Scripts/jquery-3.4.1.min.js"></script>
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >查询区域字段列表维护
                </asp:Label>
                <asp:Label ID="lblMsg_List" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td>
                            <asp:Label ID="lblFldID_q" 
                                runat="server" CssClass="text-secondary">字段</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFldID_q" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblFldName_q" 
                                runat="server" CssClass="text-secondary">字段名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFldName_q" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblCaption_q" 
                                runat="server" CssClass="text-secondary">标题</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCaption_q" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblDataTypeId_q" 
                                runat="server" CssClass="text-secondary">数据类型</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlDataTypeId_q" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblViewId_q" Style="z-index: 116;"
                                runat="server" CssClass="text-secondary">界面</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlViewId_q" Style="z-index: 117;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblCtlTypeId_q" Style="z-index: 119;"
                                runat="server" CssClass="text-secondary">控件类型</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlCtlTypeId_q" Style="z-index: 120;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblDS_TabId_q" Style="z-index: 122;"
                                runat="server" CssClass="text-secondary">数据源表</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlDS_TabId_q" Style="z-index: 123;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblQueryOptionId_q" Style="z-index: 125;"
                                runat="server" CssClass="text-secondary">查询方式</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlQueryOptionId_q" Style="z-index: 126;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                  
                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 128; width: 80px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="div_Funttion" runat="server">
                <table id="tabGridFunction" style="width: 100%; height: 32px" class="msgtable">
                    <tr>
                        <td>
                            <asp:Label ID="lblQryRegionFldsList" runat="server" 
                                CssClass="h6" Width="250px">查询区域字段列表列表</asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" 
                                 CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click"  runat="server"
                                 CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click"  runat="server"
                                 CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" 
                                runat="server"  CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List" runat="server">
                <uc2:wucvQryRegionFlds4Gv runat="server" ID="wucvQryRegionFlds4Gv1"
                    OnGvUpdateClick="wucvQryRegionFlds4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvQryRegionFlds4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditQryRegionFldsRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditQryRegionFlds"  runat="server"
                                    CssClass="h6">查询区域字段列表编辑区域</asp:Label>
                                <asp:Label ID="lblMsg_Edit"  runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                &nbsp;
                                <asp:Button ID="btnCancelQryRegionFldsEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelQryRegionFldsEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucQryRegionFldsB ID="wucQryRegionFldsB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
