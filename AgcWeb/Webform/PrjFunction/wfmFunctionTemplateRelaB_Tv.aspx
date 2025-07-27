<%@ Register TagPrefix="uc1" TagName="wucFunctionTemplateRelaB" Src="wucFunctionTemplateRelaB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvFunctionTemplateRela4Gv" Src="~/Webform/PrjFunction/wucvFunctionTemplateRela4Gv.ascx" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>
<%@ Register Src="~/Webform/PrjFunction/wucvFunction4GeneCode4Gv.ascx" TagPrefix="uc2" TagName="wucvFunction4GeneCode4Gv" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmFunctionTemplateRelaB_Tv.aspx.cs" Inherits="AGC.Webform.wfmFunctionTemplateRelaB_Tv" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>函数与模板关系维护的维护</title>
       <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />
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
            <div>

                <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;" class="float-left">
                    <asp:Label ID="lblViewTitle" runat="server" CssClass="h5">函数与模板关系维护      </asp:Label>
                    <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                        Width="347px"></asp:Label>
                </div>
                <div class="float-right">
                    <asp:Button ID="btnReturn" runat="server" CssClass="btn btn-outline-warning btn-sm" Text="返回" OnClick="btnReturn_Click"></asp:Button>
                </div>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 90%">
                    <tr>

                        <td>
                            <asp:Label ID="lblFunctionTemplateIdq"
                                runat="server" CssClass="text-secondary">模板</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFunctionTemplateIdq"
                                runat="server" CssClass="TextBox_Defa" AutoPostBack="True" OnSelectedIndexChanged="ddlFunctionTemplateId_q_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>

                    
                        <td>
                            <asp:Label ID="lblCodeTypeIdq"
                                runat="server" CssClass="text-secondary">代码类型</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlProgLangTypeId4CodeTypeq"
                                runat="server" CssClass="TextBox_Defa" Width="80px" AutoPostBack="True" OnSelectedIndexChanged="ddlProgLangTypeId4CodeType_q_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:DropDownList ID="ddlCodeTypeIdq"
                                runat="server" CssClass="TextBox_Defa" OnSelectedIndexChanged="ddlCodeTypeId_q_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                            <td>
                            <asp:Label ID="lblProgLangTypeIdq"
                                runat="server" CssClass="text-secondary">函数语言</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlProgLangTypeIdq"
                                runat="server" CssClass="TextBox_Defa" >
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblFuncTypeID" runat="server" CssClass="col-form-label text-right">函数类型</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFuncTypeIDq" runat="server" class="form-control-sm"></asp:DropDownList>
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click"
                                runat="server" CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblCreateUserIdq"
                                runat="server" CssClass="text-secondary">建立用户</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCreateUserIdq"
                                runat="server" CssClass="TextBox_Defa"></asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblFuncId4GCq" Style="z-index: 116;"
                                runat="server" CssClass="text-secondary">GC函数</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFuncId4GCq" Style="z-index: 117;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblFuncNameq" Style="z-index: 119;"
                                runat="server" CssClass="text-secondary">代码函数名</asp:Label>
                        </td>
                        <td colspan="3">
                            <asp:TextBox ID="txtFuncNameq" Style="z-index: 120;"
                                runat="server" CssClass="TextBox_Defa" Width="400px"></asp:TextBox>
                        </td>
                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 122; width: 80px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                    </tr>
                    <tr>

                        <td>&nbsp;</td>
                        <td>&nbsp;</td>

                        <td>
                            <asp:Label ID="lblFuncId4GC_q0" Style="z-index: 116;"
                                runat="server" CssClass="text-secondary">GC函数名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFuncName_GC" Style="z-index: 120;"
                                runat="server" CssClass="TextBox_Defa" Width="400px"></asp:TextBox>
                        </td>

                        <td>    <asp:Label ID="Label2" Style="z-index: 116;"
                                runat="server" CssClass="text-secondary">区域类型</asp:Label>    :
                                </td>
                        <td ><asp:DropDownList ID="ddlRegionTypeIdq" runat="server" CssClass="TextBox_Defa"></asp:DropDownList></td>
                        <td colspan="3">&nbsp;</td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>

            <div id="divFunction" class="table table-bordered table-hover">
                <div id="tabGridFunction" style="width: 100%; height: 40px" class="msgtable">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblFunctionTemplateRelaList" runat="server"
                                CssClass="h6" Width="50px">列表</asp:Label>
                        </li>
                          <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecord" CssClass="btn btn-outline-info text-nowrap btn-sm" OnClick="btnAddNewRecord_Click" Text="批量添加函数" runat="server" />
                    </li>
                        <li class="nav-item ml-1">
                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click"
                                CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
                        </li>
                        <li class="nav-item ml-1">
                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" runat="server"
                                CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                        </li>
                        <li class="nav-item ml-1">
                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" runat="server"
                                CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                        </li>
                       

                        <li class="nav-item ml-1">
                            <div class="btn-group" role="group" aria-label="Basic example">
                                <asp:Button ID="btnGoTop" runat="server" Text="移顶" OnClick="btnGoTop_Click" CssClass="btn btn-outline-info btn-sm" />
                                <asp:Button ID="btnUpMove" runat="server" OnClick="btnUpMove_Click" Text="上移" CssClass="btn btn-outline-info btn-sm ml-1" />
                                <asp:Button ID="btnDownMove" runat="server" OnClick="btnDownMove_Click" Text="下移" CssClass="btn btn-outline-info btn-sm ml-1" />
                                <asp:Button ID="btnGoBottum" runat="server" Text="移底" OnClick="btnGoBottum_Click" CssClass="btn btn-outline-info btn-sm ml-1" />
                                <asp:Button ID="btnReOrder" runat="server" OnClick="btnReOrder_Click" Text="重序" CssClass="btn btn-outline-info btn-sm ml-1" />
                            </div>
                        </li>
                        <li class="nav-item ml-1">
                            <asp:Button ID="btnAddBatch" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnAddBatch_Click" Text="批量添加记录" Visible="false" Width="100px" />
                        </li>
                         <li class="nav-item ml-2">
                            <div class="btn-group" role="group" aria-label="Basic example">                                
                                <asp:DropDownList ID="ddlRegionTypeId" runat="server" CssClass="TextBox_Defa"></asp:DropDownList>
                                <asp:Button ID="btnSetRegionTypeId" runat="server"
                                    Text="设置区域类型" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetRegionTypeId_Click"></asp:Button>
                            </div>
                        </li>
                        <li class="nav-item ml-2">
                            <div class="btn-group" role="group" aria-label="Basic example">
                                <asp:DropDownList ID="ddlCodeTypeId" runat="server" CssClass="TextBox_Defa"></asp:DropDownList>
                                <asp:Button ID="btnCopyToNewCopyTypeId" OnClick="btnCopyToNewCopyTypeId_Click" runat="server"
                                     CssClass="btn btn-outline-info btn-sm" Text="复制到其他代码类型"></asp:Button>
                            </div>
                        </li>
                         <li class="nav-item ml-2">
                            <div class="btn-group" role="group" aria-label="Basic example">
                                <asp:DropDownList ID="ddlIsGeneCode" runat="server" CssClass="TextBox_Defa"></asp:DropDownList>
                                <asp:Button ID="btnSetIsGeneCode" OnClick="btnSetIsGeneCode_Click" runat="server"
                                     CssClass="btn btn-outline-info btn-sm" Text="设置是否生成"></asp:Button>
                            </div>
                        </li>
                    </ul>
                </div>

            </div>
            <%-- 列表层 --%>
            <div class="row" style="width: 100%;">
                <div style="width: 35%;" class="col-3">
                      <div>
                          <%--  <ul class="nav">
                            <li class="nav-item">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="lblPrjIdq" name="lblPrjIdq" CssClass="form-control-sm text-right" Text="工程" runat="server" />
                                    <asp:DropDownList ID="ddlPrjIdq" name="ddlPrjIdq" CssClass="form-control-sm" Width="150px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged" />
                                </div>
                            </li>
                        </ul>--%>
                        <ul class="nav">

                            <li class="nav-item">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="lblUserIdq" name="lblUserIdq" CssClass="form-control-sm text-right" Text="依赖" runat="server" />
                                    <asp:DropDownList ID="ddlDependsOn" CssClass="form-control-sm" Width="100px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDependsOn_SelectedIndexChanged" />
                                </div>
                            </li>
                                                        <li class="nav-item">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="Label1" CssClass="form-control-sm text-right" Text="分组" runat="server" />
                                    <asp:DropDownList ID="ddlGroupName" CssClass="form-control-sm" Width="100px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlGroupName_SelectedIndexChanged" />
                                </div>
                            </li>
                            <li class="nav-item ml-1">
                                <asp:Button ID="btnRefresh"
                                    Style="z-index: 119; width: 50px;"
                                    runat="server"
                                    Text="刷新" CssClass="btn btn-outline-warning btn-sm"
                                    OnClick="btnRefresh_Click"></asp:Button>
                            </li>
                            <li class="nav-item ml-1">
                                <%--<asp:Button ID="btnAddCmClass" runat="server" OnClick="btnAddCmClass_Click"
                                    CssClass="btn btn-outline-info btn-sm" Text="添加类"></asp:Button>--%>
                            </li>
                        </ul>
                    </div>
                    <br />
                    <uc1:wucTreeView runat="server" ID="wucTreeView1" OnafterSelect_Tz="wucTreeView1_afterSelect_Tz" />
                </div>

                <div id="divMain" style="width: 65%;" class="col-9">

                    <%-- 列表层 --%>
                    <div id="divList" class="div_List mt-2" runat="server">
                        <div style="text-align: left">
                            <div class="float-left">
                                <asp:Label ID="lblLstTitle4CMProjectPrjTab" Style="z-index: 104;" Width="350px" runat="server"
                                    CssClass="h6 text-primary">函数模板关系列表</asp:Label>
                            </div>
                            <div class="float-right">
                                <asp:Button ID="btnDispFuncTemplateRela" Style="z-index: 106;" runat="server"
                                    Text="隐藏函数模板关系列表" OnClick="btnDispFuncTemplateRela_Click" CssClass="btn btn-outline-info"></asp:Button>
                            </div>
                        </div>
                        <div>
                        <uc2:wucvFunctionTemplateRela4Gv runat="server" ID="wucvFunctionTemplateRela4Gv1"
                            OnGvUpdateClick="wucvFunctionTemplateRela4Gv1_GvUpdateClick"
                            OnGvDeleteClick="wucvFunctionTemplateRela4Gv1_GvDeleteClick" />
                            </div>
                    </div>
                        <hr />
                    <div style="width: 100%">
                        <div style="text-align: left">
                            <div class="float-left">
                                <asp:Label ID="lblLstTitle4PrjTab" Style="z-index: 104;" Width="200px" runat="server"
                                    CssClass="h6 text-primary">供选择的函数列表如下:</asp:Label>
                            </div>
                            <div class="float-right">
                                <asp:Button ID="btnOKUpd2" Style="z-index: 106;" runat="server"
                                    Text="添加" OnClick="btnOKUpd2_Click" CssClass="btn btn-outline-info"></asp:Button>
                            </div>

                        </div>
                        <div>
                            <uc2:wucvFunction4GeneCode4Gv runat="server" ID="wucvFunction4GeneCode4Gv1" />
                        </div>
                    </div>
                    <%-- 编辑层 --%>
                    <div id="tabEditFunctionTemplateRelaRegion" class="tab_Edit"
                        runat="server">
                        <div>
                            <ul class="nav">
                                <li class="nav-item">

                                    <asp:Label ID="lblEditFunctionTemplateRela" runat="server" Width="300px"
                                        CssClass="h6">函数与模板关系编辑区域</asp:Label>
                                </li>

                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnOKUpd" runat="server"
                                        Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                </li>

                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnCancelFunctionTemplateRelaEdit"
                                        runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelFunctionTemplateRelaEdit_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-3">
                                    <asp:Label ID="lblMsgEdit" runat="server"
                                        Width="208px" CssClass="text-warning"></asp:Label>
                                </li>
                            </ul>
                        </div>
                        <div>
                            <uc1:wucFunctionTemplateRelaB ID="wucFunctionTemplateRelaB1" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
