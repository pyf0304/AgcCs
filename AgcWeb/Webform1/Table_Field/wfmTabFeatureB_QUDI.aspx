<%@ Register TagPrefix="uc1" TagName="wucTabFeatureB" Src="wucTabFeatureB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvTabFeature4Gv" Src="wucvTabFeature4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmTabFeatureB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmTabFeatureB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>表功能维护的维护</title>
    <script src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
        <style type="text/css">
        body{
            font-size:0.875rem;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >表功能维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table id="tabQuery" style="width: 80%;" class="msgtable">
                    <tr>
                        <td>
                            <asp:Label ID="lblTabFeatureIdq" CssClass="text-secondary" Width="90px" Text="表功能Id" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtTabFeatureIdq" Width="200px"  runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblTabFeatureNameq" CssClass="text-secondary" Width="90px" Text="表功能名" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtTabFeatureNameq" Width="200px"  runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblTabIdq" CssClass="text-secondary" Width="90px" Text="表ID" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTabIdq" Width="200px"  runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblFeatureIdq" CssClass="text-secondary" Width="90px" Text="功能Id" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFeatureIdq" Width="200px"  runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnQuery"  CssClass="btn btn-outline-warning btn-sm"  OnClick="btnQuery_Click" Text="查询" runat="server" />
                        </td>
                        <td>
                                                    <asp:Button ID="btnExportExcel"  CssClass="btn btn-secondary Button_Defa"  OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />

                        </td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="div_Funttion" runat="server" style="width:40%;">
                <div style="width: 20%; float: left">
                    <asp:Label ID="lblTabFeatureList"  CssClass="h6" Width="250px" Text="表功能列表" runat="server" />

                </div>
                <div style="width: 80%; float: right">
                      <div class="btn-group" role="group" aria-label="Basic example" style="width:100%; float:left;">
                        <asp:Button ID="btnAddNewRecord"  CssClass="btn btn-secondary Button_Defa" Width="50px" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                        <asp:Button ID="btnUpdateRecord"  CssClass="btn btn-secondary Button_Defa" Width="50px" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                        <asp:Button ID="btnDelRecord"  CssClass="btn btn-secondary Button_Defa" Width="50px" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                        <asp:Button ID="btnSetInUse"  CssClass="btn btn-secondary Button_Defa" OnClick="btnSetInUse_Click" Text="设置在用" runat="server" />

                        <asp:Button ID="btnSetNotInUse"  CssClass="btn btn-secondary Button_Defa" OnClick="btnSetNotInUse_Click" Text="设置不用" runat="server" />

                    </div> 
                    <div class="btn-group" style="width:100%;  float:left; margin-top:5px;" role="group" aria-label="Basic example" >

                        <asp:Button ID="btnGoTop"  CssClass="btn btn-secondary Button_Defa" OnClick="btnGoTop_Click" Text="移顶" runat="server" />
                        <asp:Button ID="btnUpMove"  CssClass="btn btn-secondary Button_Defa" OnClick="btnUpMove_Click" Text="上移" runat="server" />
                        <asp:Button ID="btnDownMove"  CssClass="btn btn-secondary Button_Defa" OnClick="btnDownMove_Click" Text="下移" runat="server" />
                        <asp:Button ID="btnGoBottum"  CssClass="btn btn-secondary Button_Defa" OnClick="btnGoBottum_Click" Text="移底" runat="server" />
                        <asp:Button ID="btnReOrder"  CssClass="btn btn-secondary Button_Defa" OnClick="btnReOrder_Click" Text="重序" runat="server" />
                    </div>
                </div>

            </div>
        <%-- 列表层 --%>
        <div id="divList" class="div_List" runat="server">
            <uc2:wucvTabFeature4Gv runat="server" ID="wucvTabFeature4Gv1"
                OnGvUpdateClick="wucvTabFeature4Gv1_GvUpdateClick"
                OnGvDeleteClick="wucvTabFeature4Gv1_GvDeleteClick" />
        </div>
        <%-- 编辑层 --%>
        <div id="tabEditTabFeatureRegion" class="tab_Edit"
            runat="server">
            <div>
                <table style="width: 100%;" class="msgtable">
                    <tr>
                        <th style="text-align: left">
                            <asp:Label ID="lblEditTabFeature"  runat="server"
                                CssClass="h6">表功能编辑区域</asp:Label>
                            <asp:Label ID="lblMsgEdit"  runat="server"
                                Width="208px"  CssClass="text-warning"></asp:Label>
                        </th>
                        <th style="text-align: right">
                            <asp:Button ID="btnOKUpd"  runat="server"
                                 Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>

                            <asp:Button ID="btnCancelTabFeatureEdit" 
                                runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelTabFeatureEdit_Click"></asp:Button>
                        </th>
                    </tr>
                </table>
            </div>
            <div>
                <uc1:wucTabFeatureB ID="wucTabFeatureB1" runat="server" />
            </div>
        </div>
        </div>
    </form>
</body>
</html>
