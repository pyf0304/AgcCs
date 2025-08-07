<%@ Register TagPrefix="uc1" TagName="wucFeatureFuncRelaB" Src="wucFeatureFuncRelaB.ascx" %>
<%@ Register Src="~/Webform/PrjFunction/wucvFeatureFuncRela4Gv.ascx" TagPrefix="uc3" TagName="wucvFeatureFuncRela4Gv" %>
<%@ Register Src="~/Webform/PrjFunction/wucvFunction4GeneCode4Gv.ascx" TagPrefix="uc2" TagName="wucvFunction4GeneCode4Gv" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmFeatureFuncRelaB_Tv.aspx.cs" Inherits="AGC.Webform.wfmFeatureFuncRelaB_Tv" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>功能函数关系维护的维护</title>
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />

    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
    <script>
        var bolIsDispTreeView = true;
        function DispTreeView() {
            var hidIsDispTreeView = document.getElementById("hidIsDispTreeView");
            if (hidIsDispTreeView == "true") {
                $("#divTree").show();
            }
            else {
                $("#divTree").hide();
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"      runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5">功能函数关系维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">

                <div class="row">

                    <div class="btn-group col-2" role="group" aria-label="Basic example">
                        <asp:Label ID="lblApplicationTypeIdq" 
                            runat="server" CssClass="text-secondary">应用</asp:Label>
                        <asp:DropDownList ID="ddlApplicationTypeIdq"
                            runat="server" CssClass="TextBox_Defa" AutoPostBack="True" OnSelectedIndexChanged="ddlApplicationTypeId_q_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                    <div class="btn-group col-3" role="group" aria-label="Basic example">
                        <asp:Label ID="lblProgLangTypeIdq" 
                            runat="server" CssClass="text-secondary">语言</asp:Label>

                        <asp:DropDownList ID="ddlProgLangTypeIdq" 
                            runat="server" CssClass="TextBox_Defa" AutoPostBack="True" OnSelectedIndexChanged="ddlProgLangTypeId_q_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                    <div class="btn-group col-3" role="group" aria-label="Basic example">

                        <asp:Label ID="lblCodeTypeIdq" 
                            runat="server" CssClass="text-secondary">分  层</asp:Label>
                        <asp:DropDownList ID="ddlCodeTypeIdq" runat="server" CssClass="TextBox_Defa">
                        </asp:DropDownList>
                    </div>

                </div>
                <div class="row mt-1">
                    <div class="btn-group col-2" role="group" aria-label="Basic example">

                        <asp:Label ID="lblFeatureTypeIdq" 
                            runat="server" CssClass="text-secondary">功能类型</asp:Label>

                        <asp:DropDownList ID="ddlFeatureTypeIdq" 
                            runat="server" CssClass="TextBox_Defa" AutoPostBack="True" OnSelectedIndexChanged="ddlFeatureTypeId_q_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                    <div class="btn-group col-3" role="group" aria-label="Basic example">

                        <asp:Label ID="lblFeatureIdq" 
                            runat="server" CssClass="text-secondary">功能</asp:Label>

                        <asp:DropDownList ID="ddlFeatureIdq"
                            runat="server" CssClass="TextBox_Defa">
                        </asp:DropDownList>
                    </div>

                   


                </div>
                <div class="row mt-1">

                    <div class="btn-group col-4" role="group" aria-label="Basic example">
                        <asp:Label ID="lblFuncId4Codeq" 
                            runat="server" CssClass="text-secondary">函数Id</asp:Label>

                        <asp:DropDownList ID="ddlFuncId4GCq" 
                            runat="server" CssClass="TextBox_Defa">
                        </asp:DropDownList>
                    </div>
                    <div class="btn-group col-2" role="group" aria-label="Basic example">

                        <asp:Label ID="lblFuncName4Codeq" Style="z-index: 116;"
                            runat="server" CssClass="text-secondary">函数GC</asp:Label>

                        <asp:TextBox ID="txtFuncName4GCq" Style="z-index: 117;"
                            runat="server" CssClass="TextBox_Defa"></asp:TextBox>
                    </div>
                     <div class="btn-group col-2" role="group" aria-label="Basic example">

                        <asp:Label ID="Label1" Style="z-index: 116;"
                            runat="server" CssClass="text-secondary">函数Code</asp:Label>

                        <asp:TextBox ID="txtFuncName4Codeq" Style="z-index: 117;"
                            runat="server" CssClass="TextBox_Defa"></asp:TextBox>
                    </div>
                    <div class="btn-group col-2" role="group" aria-label="Basic example">
                        <asp:Button ID="btnQuery" runat="server" Text="查询" CssClass="btn btn-outline-warning btn-sm" OnClick="btnQuery_Click"></asp:Button>
                        <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" runat="server" CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>

                    </div>
                </div>

            </div>
            <%-- 列表层 --%>

            <div id="divList" class="div_List mt-2"    runat="server">
                <div style="width: 100%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblFeatureFuncRelaList" runat="server"
                                CssClass="h6" Width="250px">功能函数关系列表</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" 
                                 CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click"  runat="server"
                                 CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" runat="server"
                                 CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <div class="btn-group col-2" role="group" aria-label="Basic example">
                                <asp:DropDownList ID="ddlFeatureId" runat="server" class="form-control-sm"></asp:DropDownList>

                                <asp:Button ID="btnConfirmBatchAddFunc" OnClick="btnConfirmBatchAddFunc_Click" runat="server"
                                    Width="99px" CssClass="btn btn-outline-info btn-sm ml-1" Text="确认批量添加"></asp:Button>
                     
                            </div>
                        </li>
                             <li class="nav-item ml-3">
                            <div class="btn-group col-2" role="group" aria-label="Basic example">
                                   <asp:DropDownList ID="ddlApplicationTypeId"
                            runat="server" CssClass="TextBox_Defa" >
                        </asp:DropDownList>

                                <asp:Button ID="btnCopyToNewAppId" OnClick="btnCopyToNewAppId_Click" runat="server"
                                    Width="99px" CssClass="btn btn-outline-info btn-sm ml-1" Text="复制到其他应用类型"></asp:Button>
    </div>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnReturn"
                                Style="z-index: 119; width: 80px;"
                                runat="server"
                                Text="返回" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnReturn_Click"></asp:Button>
                        </li>
                    </ul>
                </div>
                <div style="width: 100%;">
                    <div style="width: 30%;" id="divTree11" class="float-left">
                        <uc1:wucTreeView runat="server" ID="wucTreeView1" OnafterSelect_Tz="wucTreeView1_afterSelect_Tz" />
                    </div>

                    <div style="width: 70%;" class="float-right">
                      <%--  <div style="float: left;">

                            <uc3:wucvFeatureFuncRela4Gv runat="server" ID="wucvFeatureFuncRela4Gv1" />
                        </div>
                        <div style="float: right;">--%>

                            <uc2:wucvFunction4GeneCode4Gv runat="server" ID="wucvFunction4GeneCode4Gv1" />
                        <%--</div>--%>

                    </div>
                </div>
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditFeatureFuncRelaRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditFeatureFuncRela"  runat="server"
                                    CssClass="h6">功能函数关系编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit" runat="server"
                                    Width="208px" CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>

                                <asp:Button ID="btnCancelFeatureFuncRelaEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelFeatureFuncRelaEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucFeatureFuncRelaB ID="wucFeatureFuncRelaB1" runat="server" />
                </div>
            </div>
        </div>
        <asp:HiddenField ID="hidIsDispTreeView" runat="server" Value="true" />
        <script type="text/javascript">
            DispTreeView();
        </script>
    </form>
</body>
</html>
