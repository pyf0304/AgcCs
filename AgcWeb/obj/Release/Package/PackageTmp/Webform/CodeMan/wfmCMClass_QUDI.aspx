<%@ Register TagPrefix="uc1" TagName="wucCMClass" Src="wucCMClass.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvCMClass4Gv" Src="wucvCMClass4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmCMClass_QUDI.aspx.cs" Inherits="AGC.Webform.wfmCMClass_QUDI" ValidateRequest="false" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>CM类维护的维护</title>
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
</head>
<body>
    <form id="form1" runat="server" class="form-horizontal">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">CM类维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabQuery" style="width: 70%;" class="table table-bordered table-hover table td table-sm">
                    <tr>
                        <td>
                            <asp:Label ID="lblProgLangTypeIdq" name="lblProgLangTypeIdq" Style="width: 50px;" CssClass="col-form-label text-right" Width="90px" Text="语言" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlProgLangTypeIdq" name="ddlProgLangTypeIdq" CssClass="form-control-sm" Width="100px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblPrjIdq" name="lblPrjIdq" Style="width: 50px;" CssClass="col-form-label text-right" Width="90px" Text="工程" runat="server" />
                        </td>
                        <td>
                            <div class="btn-group " role="group" aria-label="Basic example">
                                <asp:DropDownList ID="ddlPrjIdq" name="ddlPrjIdq" CssClass="form-control-sm" Width="150px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged" />
                                <asp:DropDownList ID="ddlFuncModuleAgcIdq" name="ddlFuncModuleAgcIdq" CssClass="form-control-sm" Width="150px" runat="server" />
                            </div>
                        </td>
                        <td>
                            <asp:Label ID="lblCodeTypeIdq" name="lblCodeTypeIdq" Style="width: 70px;" CssClass="col-form-label text-right" Width="90px" Text="代码类型" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlCodeTypeIdq" name="ddlCodeTypeIdq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblUserIdq" name="lblUserIdq" Style="width: 50px;" CssClass="col-form-label text-right" Width="90px" Text="用户" runat="server" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlUserIdq" name="ddlUserIdq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                       <td>
                            <asp:Label ID="lblNameSpaceq" name="lblNameSpaceq" Style="width: 50px;" CssClass="col-form-label text-right" Width="90px" Text="域名" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtNameSpaceq" name="txtNameSpaceq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                    
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblCmClassIdq" name="lblCmClassIdq" Style="width: 50px;" CssClass="col-form-label text-right" Width="90px" Text="类Id" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtCmClassIdq" name="txtCmClassIdq" CssClass="form-control-sm" Width="100px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblClassNameq" name="lblClassNameq" Style="width: 50px;" CssClass="col-form-label text-right" Width="90px" Text="类名" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtClassNameq" name="txtClassNameq" CssClass="form-control-sm" Width="300px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblTabNameq" name="lblTabNameq" Style="width: 50px;" CssClass="col-form-label text-right" Width="90px" Text="表名" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtTabNameq" name="txtTabNameq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                       
                  
                        <td>
                            <asp:Label ID="lblFileNameq" name="lblFileNameq" Style="width: 50px;" CssClass="col-form-label text-right" Width="90px" Text="文件名" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtFileNameq" name="txtFileNameq" CssClass="form-control-sm" Width="200px" runat="server" />
                        </td>
                      
                        <td colspan="2">
                             <div class="btn-group " role="group" aria-label="Basic example">
                            <asp:Button ID="btnQuery" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnQuery_Click" Text="查询" runat="server" />
                                 <asp:CheckBox ID="chkIsShowDetail" Checked="false" CssClass="form-control-sm" Text="详细信息" runat="server" />
                                 <asp:Button ID="btnExportExcel" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                                 </div>
                        </td>
                        
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="table table-bordered table-hover">
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblCMClassList" name="lblCMClassList" CssClass="col-form-label text-info" Width="250px" Text="CM类列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnUpdateRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info text-nowrap" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                    </li>
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:wucvCMClass4Gv runat="server" ID="wucvCMClass4Gv1"
                    OnGvUpdateClick="wucvCMClass4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvCMClass4Gv1_GvDeleteClick" />
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
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelCMClassEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelCMClassEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:wucCMClass ID="wucCMClass1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
