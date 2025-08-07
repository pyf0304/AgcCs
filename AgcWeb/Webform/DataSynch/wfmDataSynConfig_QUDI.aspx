<%@ Register TagPrefix="uc1" TagName="wucDataSynConfig" Src="wucDataSynConfig.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucDataSynConfig4Gv" Src="wucDataSynConfig4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmDataSynConfig_QUDI.aspx.cs" Inherits="AGC.Webform.wfmDataSynConfig_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>同步配置维护的维护</title>
    
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
    <script src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="form-horizontal">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">同步配置维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabQuery" name="tabQuery" style="width: 70%;" class="table table-bordered table-hover table td table-sm">
                    <tr>
                        <td>
                            <asp:Label ID="lblTabNameq" name="lblTabNameq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="表名" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtTabNameq" name="txtTabNameq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblSynchCycleq" name="lblSynchCycleq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="同步周期" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtSynchCycleq" name="txtSynchCycleq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblSenderUserq" name="lblSenderUserq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="发送邮件用户" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtSenderUserq" name="txtSenderUserq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblReceiverq" name="lblReceiverq" Style="width: 80px;" CssClass="col-form-label text-right" Width="90px" Text="接收者" runat="server" />
                        </td>
                        <td>
                            <asp:TextBox ID="txtReceiverq" name="txtReceiverq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnQuery" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnQuery_Click" Text="查询" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="table table-bordered table-hover">
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblDataSynConfigList" name="lblDataSynConfigList" CssClass="col-form-label text-info" Width="250px" Text="同步配置列表" runat="server" />
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
                    <li class="nav-item ml-3">
                        <div class="btn-group" role="group" aria-label="Basic example">
                            <asp:Button ID="btnGoTop" CssClass="btn btn-outline-info text-nowrap" OnClick="btnGoTop_Click" Text="移顶" runat="server" />
                            <asp:Button ID="btnUpMove" CssClass="btn btn-outline-info text-nowrap" OnClick="btnUpMove_Click" Text="上移" runat="server" />
                            <asp:Button ID="btnDownMove" CssClass="btn btn-outline-info text-nowrap" OnClick="btnDownMove_Click" Text="下移" runat="server" />
                            <asp:Button ID="btnGoBottum" CssClass="btn btn-outline-info text-nowrap" OnClick="btnGoBottum_Click" Text="移底" runat="server" />
                            <asp:Button ID="btnReOrder" CssClass="btn btn-outline-info text-nowrap" OnClick="btnReOrder_Click" Text="重序" runat="server" />
                        </div>
                    </li>
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:wucDataSynConfig4Gv runat="server" ID="wucDataSynConfig4Gv1"
                    OnGvUpdateClick="wucDataSynConfig4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucDataSynConfig4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditDataSynConfigRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditDataSynConfig" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">同步配置编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelDataSynConfigEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelDataSynConfigEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:wucDataSynConfig ID="wucDataSynConfig1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
