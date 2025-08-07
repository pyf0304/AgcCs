<%@ Register TagPrefix="uc1" TagName="wucCMFunction" Src="wucCMFunction.ascx" %>
<%@ Register TagPrefix="uc3" TagName="wucCMClass" Src="wucCMClass.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmCMFunction_Disp.aspx.cs" Inherits="AGC.Webform.wfmCMFunction_Disp" ValidateRequest="false" %>

<%@ Register Src="wucvCMFunction4GV.ascx" TagName="wucvCMFunction4GV" TagPrefix="uc2" %>
<%--<%@ Register Src="~/Webform/CodeMan/wucvCMFunction4GV.ascx" TagPrefix="uc1" TagName="wucvCMFunction4GV" %>--%>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>
<%@ Register Src="~/Webform/CodeMan/wucvCMFunction4DL.ascx" TagPrefix="uc1" TagName="wucvCMFunction4DL" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>函数名4Code维护的维护</title>
    
    <link href="../../tzMenuWuc/cssMenu1.css" rel="stylesheet" />
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5 font-weight-bold">函数查看
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <div>
                <div id="divTree" class="float-left" style="width: 20%">
                    <div>
                        <ul class="nav">
                            <li class="nav-item">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="lblPrjIdq" name="lblPrjIdq" CssClass="form-control-sm text-right" Text="工程" runat="server" />
                                    <asp:DropDownList ID="ddlPrjIdq" name="ddlPrjIdq" CssClass="form-control-sm" Width="150px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged" />
                                </div>
                            </li>
                        </ul>
                        <ul class="nav">

                            <li class="nav-item">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="lblUserIdq" name="lblUserIdq" CssClass="form-control-sm text-right" Text="用户" runat="server" />
                                    <asp:DropDownList ID="ddlUserIdq" name="ddlUserIdq" CssClass="form-control-sm" Width="70px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged" />
                                </div>
                            </li>
                            <li class="nav-item ml-1">
                                <asp:CheckBox ID="chkDispNoFunctionClass" runat="server" Checked="false" Text="显示无函数类" AutoPostBack="true" OnCheckedChanged="chkDispNoFunctionClass_CheckedChanged" />

                            </li>
                            <li class="nav-item ml-1">
                                <asp:Button ID="btnRefresh"
                                    Style="z-index: 119; width: 50px;"
                                    runat="server"
                                    Text="刷新" CssClass="btn btn-outline-warning btn-sm"
                                    OnClick="btnRefresh_Click"></asp:Button>
                            </li>
                            <li class="nav-item ml-1">
                                <asp:Button ID="btnAddCmClass" runat="server" OnClick="btnAddCmClass_Click"
                                    CssClass="btn btn-outline-info btn-sm" Text="添加类"></asp:Button>
                            </li>
                        </ul>
                    </div>
                    <br />
                    <uc1:wucTreeView runat="server" ID="wucTreeView1" OnafterSelect_Tz="wucTreeView1_afterSelect_Tz" />
                </div>
                <div id="divMain" class="float-right" style="width: 80%">

                    <%-- 查询层 --%>

                    <div id="divQuery" class="div_query">
                        <ul class="nav">

                            <li class="nav-item">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="lblProgLangTypeIdq" name="lblProgLangTypeIdq" CssClass="col-form-label text-right" Text="语言" runat="server" />

                                    <asp:DropDownList ID="ddlProgLangTypeIdq" name="ddlProgLangTypeIdq" CssClass="form-control-sm" Width="100px" runat="server" />
                                </div>
                            </li>
                            <li class="nav-item ml-3">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="lblCmFunctionIdq"
                                        runat="server" CssClass="text-secondary">函数Id</asp:Label>

                                    <asp:TextBox ID="txtCmFunctionIdq"
                                        runat="server" CssClass="form-control-sm" Width="142px">
                                    </asp:TextBox>
                                </div>
                            </li>
                           
                            <li class="nav-item ml-2">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="lblFunctionNameq"
                                        runat="server" CssClass="text-secondary">函数名</asp:Label>

                                    <asp:TextBox ID="txtFunctionNameq"
                                        runat="server" Width="200px" CssClass="form-control-sm">
                                    </asp:TextBox>
                                </div>
                            </li>
                             <li class="nav-item ml-2">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="Label4"
                                        runat="server" CssClass="text-secondary">关键字</asp:Label>


                                    <asp:DropDownList ID="ddlKeyWord" runat="server" class="form-control-sm"></asp:DropDownList>
                                </div>
                            </li>

                        </ul>
                        <ul class="nav mt-2">

                            <li class="nav-item">

                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="Label1"
                                        runat="server" CssClass="text-secondary">内容</asp:Label>

                                    <asp:TextBox ID="txtFuncContentq"
                                        runat="server" Width="300px" CssClass="form-control-sm">
                                    </asp:TextBox>
                                </div>
                            </li>
                            <li class="nav-item ml-2">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="Label2"
                                        runat="server" CssClass="text-secondary">注&nbsp;&nbsp;&nbsp;释</asp:Label>

                                    <asp:TextBox ID="txtFuncCommentsq" runat="server" Width="380px" CssClass="form-control-sm">
                                    </asp:TextBox>
                                </div>
                            </li>
                            <li class="nav-item ml-1">
                                <div class="btn-group " role="group" aria-label="Basic example">
                                    <asp:Label ID="lblApplicationTypeIdq"
                                        runat="server" CssClass="text-secondary">应用</asp:Label>

                                    <asp:DropDownList ID="ddlApplicationTypeIdq" runat="server" class="form-control-sm"></asp:DropDownList>
                                </div>
                            </li>
                            <li class="nav-item ml-1">

                                <asp:Button ID="btnQuery"
                                    Style="z-index: 119; width: 60px;"
                                    runat="server"
                                    Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                    OnClick="btnQuery_Click"></asp:Button>
                            </li>
                            <li class="nav-item ml-1">
                                <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click"
                                    runat="server" CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                            </li>
                            <li class="nav-item ml-1"></li>


                        </ul>
                    </div>
                    <%-- 列表层 --%>

                    <div id="divList" class="div_List mt-3"
                        runat="server">
                        <div id="tabGridFunction" style="width: 100%; height: 32px" class="msgtable">
                            <ul class="nav">
                                <li class="nav-item">
                                    <asp:Label ID="lblCMFunctionList" runat="server"
                                        CssClass="h6" Width="250px">函数列表</asp:Label>
                                </li>
                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click"
                                        CssClass="btn btn-outline-info btn-sm" Text="添加函数"></asp:Button>
                                </li>
                                <%-- <li class="nav-item ml-3">
                                    <asp:Button ID="btnCloneNewRec4Gv" runat="server" OnClick="btnCloneNewRec4Gv_Click"
                                        CssClass="btn btn-outline-info btn-sm" Text="克隆"></asp:Button>
                                </li>

                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" runat="server"
                                        CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                                </li>
                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" runat="server"
                                        CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                                </li>


                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnEditPara" OnClick="btnEditPara_Click" runat="server"
                                        CssClass="btn btn-outline-info btn-sm" Text="编辑参数"></asp:Button>
                                </li>--%>
                            </ul>
                        </div>
                        <div style="width: 100%;">
                            <%--                    <div id="divLeft" style="width: 55%; float: left">--%>
                            <div id="divLeft" style="width: 100%" runat="server">
                                <%--<uc2:wucvCMFunction4GV ID="wucCMFunction4GV1" runat="server" />--%>
                                <uc1:wucvCMFunction4DL runat="server" ID="wucvCMFunction4DL1"
                                    OnDlEditParaClick="wucvCMFunction4DL1_DlEditParaClick"
                                    OnDlCloneClick="wucvCMFunction4DL1_DlCloneClick"
                                    OnDlUpdateClick="wucvCMFunction4DL1_DlUpdateClick"
                                    OnDlDeleteClick="wucvCMFunction4DL1_DlDeleteClick" />
                            </div>

                        </div>
                    </div>
                    <%-- 编辑层 --%>
                    <div id="tabEditCMFunctionRegion" class="tab_Edit"
                        runat="server">
                        <div>
                            <ul class="nav">
                                <li class="nav-item">
                                    <asp:Label ID="lblEditCMFunction" runat="server" Width="250px"
                                        CssClass="h6">函数名4Code编辑区域</asp:Label>
                                </li>

                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnOKUpd" runat="server"
                                        Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                </li>

                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnCancelCMFunctionEdit"
                                        runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelCMFunctionEdit_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-3">
                                    <asp:Label ID="lblMsgEdit" runat="server"
                                        Width="208px" CssClass="text-warning"></asp:Label>
                                </li>

                            </ul>
                        </div>
                        <div>
                            <uc1:wucCMFunction ID="wucCMFunctionB1" runat="server" />
                        </div>
                    </div>
                    <%-- 编辑层 --%>
                    <div id="tabEditCMClassRegion" class="tab_Edit mt-2"
                        runat="server">
                        <div style="width: 60%;">
                            <ul class="nav">
                                <li class="nav-item">
                                    <asp:Label ID="lblEditCMClass" Style="z-index: 104;" Width="200px" runat="server"
                                        CssClass="col-form-label text-info">CM类编辑区域</asp:Label>
                                </li>
                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnOkUpd4Class" Style="z-index: 106;" runat="server"
                                        Text="添加" OnClick="btnOkUpd4Class_Click" CssClass="btn btn-outline-info"></asp:Button>
                                </li>
                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnCancelCMClassEdit"
                                        runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelCMClassEdit_Click"></asp:Button>
                                </li>
                                <li class="nav-item ml-3">
                                    <asp:Label ID="Label3" runat="server"
                                        Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                                </li>
                            </ul>
                        </div>
                        <div>
                            <uc3:wucCMClass ID="wucCMClass1" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>


