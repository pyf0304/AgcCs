<%@ Register TagPrefix="uc1" TagName="wucFunction4CodeB" Src="wucFunction4CodeB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmFunction4Code_FuncGC.aspx.cs" Inherits="AGC.Webform.wfmFunction4Code_FuncGC" %>


<%@ Register Src="wucGC_Function4CodeV2.ascx" TagName="wucGC_Function4CodeV2" TagPrefix="uc3" %>
<%@ Register Src="~/Webform/PrjFunction/wucGF_Function4Code.ascx" TagPrefix="uc1" TagName="wucGF_Function4Code" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>函数名4Code维护的维护</title>

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
    <script>
        function ClearText(txtCode) {
            var txtCode = getObjByTagAndId("textarea", "txtCode");
            if (txtCode != null) {
                txtCode.value = "";
            }
        }
        function SetStyle4Full() {
            var divLeft = document.getElementById("divLeft");
            if (divLeft == null) return;
            //            divLeft.style = "width:60%; float:left";
            divLeft.style.width = "100%;";
            var divRight = document.getElementById("divRight");
            if (divRight == null) return;
            Tz_HideDiv("divRight");
            console.log("SetStyle4Full");
        }
        function SetStyle4Half() {
            var divLeft = document.getElementById("divLeft");
            if (divLeft == null) return;
            //            divLeft.style = "width:60%; float:left";
            divLeft.style.width = "55%";
            divLeft.style.float = "left";

            var divRight = document.getElementById("divRight");
            if (divRight == null) return;
            Tz_ShowDiv("divRight");
            console.log("SetStyle4Half");
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5">函数名4Code维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td class="float-right">
                            <asp:Label ID="lblFuncId4Codeq"
                                runat="server" CssClass="text-secondary">函数Id</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFuncId4Codeq"
                                runat="server" CssClass="text-secondary">
                            </asp:TextBox>
                        </td>

                        <td class="float-right">
                            <asp:Label ID="lblFuncName4Codeq"
                                runat="server" CssClass="text-secondary">函数名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFuncName4Codeq"
                                runat="server" Width="250px" CssClass="text-secondary">
                            </asp:TextBox>
                        </td>
                </table>
            </div>
            <%-- 列表层 --%>

            <div id="divList" class="div_List"
                runat="server">
                <div id="tabGridFunction" style="width: 100%; height: 32px" class="msgtable">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblFunction4CodeList" runat="server"
                                CssClass="h6" Width="150px">函数列表</asp:Label>
                        </li>
                        <li class="nav-item ml-2">
                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click"
                                CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
                        </li>
                        <li class="nav-item ml-2">
                            <asp:Button ID="btnCloneNewRec4Gv" runat="server" OnClick="btnCloneNewRec4Gv_Click"
                                CssClass="btn btn-outline-info btn-sm" Text="克隆"></asp:Button>
                        </li>
                        <li class="nav-item ml-2">
                            <asp:Button ID="btnCopyTemplateFunction" OnClick="btnCopyTemplateFunction_Click" runat="server"
                                CssClass="btn btn-outline-info btn-sm" Text="复制模板函数" Visible="False"></asp:Button>

                        </li>
                        <li class="nav-item ml-2">
                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" runat="server"
                                CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                        </li>
                        <li class="nav-item ml-2">
                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" runat="server"
                                CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                        </li>
                        <li class="nav-item ml-2">
                            <div class="btn-group " role="group" aria-label="Basic example">
                                <asp:DropDownList ID="ddlApplicationTypeId" runat="server" class="form-control-sm"></asp:DropDownList>

                                <asp:Button ID="btnApplicationTypeId" runat="server"
                                    CssClass="btn btn-outline-info btn-sm" Text="设置应用类型" OnClick="btnApplicationTypeId_Click"></asp:Button>
                            </div>
                        </li>
                        <li class="nav-item ml-2">
                            <div class="btn-group " role="group" aria-label="Basic example">
                                <asp:DropDownList ID="ddlFuncAccessModeId" runat="server" class="form-control-sm"></asp:DropDownList>

                                <asp:Button ID="btnFuncAccessModeId" runat="server"
                                    CssClass="btn btn-outline-info btn-sm" Text="设置函数访问方式" OnClick="btnFuncAccessModeId_Click"></asp:Button>
                            </div>
                        </li>
                        <li class="nav-item ml-2">
                            <asp:Button ID="btnSynchToFunction4GC" OnClick="btnSynchToFunction4GC_Click" runat="server"
                                CssClass="btn btn-outline-info btn-sm" Text="同步到函数4GC"></asp:Button>
                        </li>
                        <li class="nav-item ml-2">
                            <asp:Button ID="btnEditPara" OnClick="btnEditPara_Click" runat="server"
                                CssClass="btn btn-outline-info btn-sm" Text="编辑参数"></asp:Button>

                        </li>

                        <li class="nav-item ml-2">
                            <asp:Button ID="btnGeneFunction" OnClick="btnGeneFunction_Click" runat="server"
                                CssClass="btn btn-outline-info btn-sm" Text="生成相关函数" Visible="False"></asp:Button>

                        </li>
                        <li class="nav-item ml-2">
                            <asp:Button ID="btnGC_Function4Code" OnClick="btnGC_Function4Code_Click" runat="server"
                                CssClass="btn btn-outline-info btn-sm" Text="生成函数代码"></asp:Button>

                        </li>
                        <li class="nav-item ml-2">
                            <asp:Button ID="btnCalcFuncSignature" OnClick="btnCalcFuncSignature_Click" runat="server"
                                CssClass="btn btn-outline-info btn-sm" Text="计算函数签名" Visible="False"></asp:Button>

                        </li>
                    </ul>
                </div>
                <div class="row" style="width: 100%;">
                    <%--                    <div id="divLeft" style="width: 55%; float: left">--%>
                    <div id="divLeft" class="col-4" runat="server">
                        <uc1:wuctreeview runat="server" id="wucTreeView4PrjTab" onafterselect_tz="wucTreeView4PrjTab_afterSelect_Tz" />

                    </div>
                    <div id="divRight" class="col-8" runat="server" visible="false">
                        <div class="modal-content" style="width: 100%;">
                            <div class="modal-header">
                                <h4 class="modal-title" id="myModalLabel">生成函数代码</h4>
                                <%--<button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>--%>
                                <asp:Button ID="btnClose" runat="server" Text="关闭"
                                    OnClick="btnClose_Click" data-dismiss="modal" aria-hidden="true" CssClass="close btn btn-outline-info btn-sm"></asp:Button>
                            </div>
                            <div class="modal-body">

                                <div id="divGC_Function4Code" class="tab_Edit" runat="server" visible="false">
                                    <uc3:wucgc_function4codev2 id="wucGC_Function4CodeB1" runat="server" />
                                </div>
                                <div id="divGF_Function4Code" class="tab_Edit" runat="server" visible="false">
                                    <uc1:wucgf_function4code runat="server" id="wucGF_Function4Code1" onongffinished="wucGF_Function4Code1_onGFFinished" />
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditFunction4CodeRegion" class="tab_Edit"
                runat="server">
                <div>
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditFunction4Code" runat="server" Width="250px"
                                CssClass="h6">函数名4Code编辑区域</asp:Label>
                        </li>

                        <li class="nav-item ml-2">
                            <asp:Button ID="btnOKUpd" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </li>

                        <li class="nav-item ml-2">
                            <asp:Button ID="btnCancelFunction4CodeEdit"
                                runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelFunction4CodeEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-2">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="208px" CssClass="text-warning"></asp:Label>
                        </li>

                    </ul>
                </div>
                <div>
                    <uc1:wucfunction4codeb id="wucFunction4CodeB1" runat="server" />
                </div>
            </div>


        </div>
    </form>
</body>
</html>


