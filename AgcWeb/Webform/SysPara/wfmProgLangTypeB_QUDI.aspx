<%@ Register TagPrefix="uc1" TagName="wucProgLangTypeB" Src="wucProgLangTypeB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvProgLangType4Gv" Src="wucvProgLangType4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmProgLangTypeB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmProgLangTypeB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>编程语言类型维护的维护</title>
    <link rel="stylesheet" type="text/css" href="../../css/tz_base1.css" />
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="PageTitleH1" Height="16px">编程语言类型维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="ErrMsg" Height="16px" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td>
                            <asp:Label ID="lblProgLangTypeIdq" 
                                runat="server" CssClass="NameLabel">编程语言类型Id</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtProgLangTypeIdq" Style="z-index: 105;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblProgLangTypeNameq" 
                                runat="server" CssClass="NameLabel">编程语言类型名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtProgLangTypeNameq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblCharEncodingIdq" 
                                runat="server" CssClass="NameLabel">字符编码</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlCharEncodingIdq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 113; width: 80px; height: 24px;"
                                runat="server"
                                Text="查询" CssClass="Button_Defa"
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
                            <asp:Label ID="lblProgLangTypeList" runat="server" Style="z-index: 105;"
                                CssClass="h6" Width="250px">编程语言类型列表</asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" Style="z-index: 106;"
                                Width="80px" CssClass="Button_Defa" Text="添加记录"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click"  runat="server"
                                Width="80px" CssClass="Button_Defa" Text="删除记录"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" Style="z-index: 105;" runat="server"
                                Width="80px" CssClass="Button_Defa" Text="修改记录"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" 
                                runat="server" Width="80px" CssClass="Button_Defa" Text="导出Excel"></asp:Button>
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List" runat="server">
                <uc2:wucvProgLangType4Gv runat="server" ID="wucvProgLangType4Gv1"
                    OnGvUpdateClick="wucvProgLangType4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvProgLangType4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditProgLangTypeRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditProgLangType"  runat="server"
                                    CssClass="h6">编程语言类型编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit" Style="z-index: 105;" runat="server"
                                    Width="208px" Height="16px" CssClass="ErrMsg"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                    Width="80px" Text="添加" OnClick="btnOKUpd_Click" CssClass="Button_Defa"></asp:Button>

                                <asp:Button ID="btnCancelProgLangTypeEdit" 
                                    runat="server" Width="100px" CssClass="Button_Defa" Text="取消编辑" OnClick="btnCancelProgLangTypeEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucProgLangTypeB ID="wucProgLangTypeB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
