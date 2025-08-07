<%@ Page Language="c#" CodeBehind="wfmFieldTab4RootFld.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmFieldTab4RootFld" EnableEventValidation="false" %>

<%@ Register TagPrefix="uc1" TagName="wucFieldTab" Src="wucFieldTab.ascx" %>
<%@ Register Src="~/Webform/Field/wucvFieldTab4RootFld4Gv.ascx" TagPrefix="uc1" TagName="wucvFieldTab4RootFld4Gv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表FieldTab的查询、修改、删除、添加记录</title>
    
    <link href="../css/button.css" rel="stylesheet" type="text/css" />
    <link href="../css/LinkButton.css" rel="stylesheet" type="text/css" />
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
    <form id="Form1" method="post" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true">
        </asp:ScriptManager>
        <asp:Label ID="Label3" Style="z-index: 102; left: 8px; position: absolute; top: 8px"
            runat="server" CssClass="h5" Width="260px">表字段管理->字段维护</asp:Label>
        <asp:Label ID="Label1" Style="z-index: 101; left: 228px; position: absolute; top: 8px"
            runat="server" CssClass="MemoStyle1" Width="638px">主要用来维护本工程中所有字段，字段名不能重复。</asp:Label>
        <table id="Table2" style="z-index: 107; left: 4px; position: absolute; top: 32px; border-color: #ff3300"
            cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr>
                <td>
                    <table id="tabQuery" style="width: 100%; border-color: #0066ff" cellspacing="0" cellpadding="0"
                        border="0" runat="server" width="100%">
                        <tr>
                            <td colspan="5">
                                <table id="Table3" cellspacing="0" cellpadding="0" width="300" border="0">
                                    <tr>
                                        <td>
                                            <table id="Table1" style="width: 800px" cellspacing="1" cellpadding="1" width="800"
                                                border="0">
                                                <tr>
                                                    <td colspan="6">
                                                        <div style="width: 832px; position: relative; height: 32px">
                                                            <asp:Label ID="Label7" Style="z-index: 101; left: 0px; position: absolute; top: 8px"
                                                                runat="server" CssClass="h6" Width="72px">基本查询</asp:Label>
                                                            <asp:Button ID="btnQuery" Style="z-index: 102; left: 632px; position: absolute; top: 4px"
                                                                runat="server"  Text="查询" OnClick="btnQuery_Click"
                                                                CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                                            <img style="z-index: 104; left: 0px; width: 832px; position: absolute; top: 0px; height: 4px"
                                                                height="4" alt="" src="../../pic/兰色直线1.gif" width="832" />
                                                            <asp:LinkButton ID="lbAdvanceQuery" Style="z-index: 108; left: 728px; position: absolute; top: 9px"
                                                                runat="server" OnClick="lbAdvanceQuery_Click">高级查询</asp:LinkButton>
                                                        </div>
                                                    </td>
                                                    <td style="width: 3px"></td>
                                                </tr>
                                                <tr>
                                                    <td align="left" colspan="6" rowspan="1">
                                                        <table style="width: 827px; height: 44px; position: relative; left: 0px; top: 0px;">
                                                            <tr>

                                                                <td></td>
                                                                <td>
                                                                    <asp:Label ID="Label10" runat="server" Width="66px" CssClass="auto-style1">功能模块</asp:Label>

                                                                </td>
                                                                <td>
                                                                    <asp:DropDownList ID="ddlFuncModuleIdq" runat="server" Width="216px" AutoPostBack="True"
                                                                        OnSelectedIndexChanged="ddlFuncModuleId_q_SelectedIndexChanged" Style="z-index: 101; left: 74px; top: 4px">
                                                                    </asp:DropDownList></td>
                                                                <td>
                                                                    <asp:Label ID="Label4" runat="server" Style="z-index: 102; left: 303px; top: 7px"
                                                                        CssClass="text-secondary">相关表</asp:Label>
                                                                </td>
                                                                <td>
                                                                    <asp:DropDownList ID="ddlTabIdq" runat="server" Width="168px" AutoPostBack="True"
                                                                        Style="z-index: 103; left: 373px; top: 5px">
                                                                    </asp:DropDownList></td>
                                                                 <td>
                                                        <asp:Label ID="Label5" runat="server" CssClass="text-secondary">根字段?</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlIsRootFld" runat="server">
                                                        </asp:DropDownList>
                                                    </td>
                                                                <td>
                                                                    <asp:Label ID="lblFldNameq" runat="server" Style="z-index: 104; left: 558px; top: 10px"
                                                                        CssClass="text-secondary">字段名称</asp:Label></td>
                                                                <td>
                                                                    <asp:TextBox ID="txtFldNameq" runat="server" Width="133px" Style="z-index: 105; left: 625px; top: 9px"></asp:TextBox></td>
                                                                <td>
                                                                    <asp:Label ID="Label11" runat="server" Style="z-index: 104; left: 558px; top: 10px"
                                                                        CssClass="text-secondary">字段标题</asp:Label></td>
                                                                <td>
                                                                    <asp:TextBox ID="txtCaptionq" runat="server" Width="133px" Style="z-index: 105; left: 625px; top: 9px"></asp:TextBox></td>


                                                                <td>
                                                                    <asp:LinkButton ID="lbImportExcelFld"  runat="server" OnClick="lbImportExcelFld_Click"
                                                                        CssClass="btn btn-outline-info btn-sm" Width="140px">导入Excel字段信息</asp:LinkButton>
                                                                </td>


                                                                <td>
                                                                    <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" runat="server"
                                                                         CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                                                                </td>


                                                            </tr>
                                                            <tr>
                                                                <td></td>
                                                                <td></td>
                                                                <td></td>
                                                                <td></td>
                                                                <td></td>
                                                                <td></td>
                                                                <td>&nbsp;</td>
                                                                <td>&nbsp;</td>
                                                                <td>&nbsp;</td>
                                                                <td>&nbsp;</td>
                                                                <td>&nbsp;</td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td></td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table id="tabAdvanceQuery" cellspacing="1" cellpadding="1" width="744" border="0"
                                                runat="server">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label2" Style="z-index: 100; left: 0px; top: 8px"
                                                            runat="server" CssClass="h6" Width="72px">高级查询</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:Button ID="btnQueryForAdvanced" Style="z-index: 101; left: 632px; top: 4px"
                                                            runat="server"   Text="高级查询" OnClick="btnQueryForAdvanced_Click"
                                                            CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                                    </td>

                                                    <td>
                                                        <asp:LinkButton ID="lbHideAdvanceQuery" Style="z-index: 108; left: 728px; top: 9px"
                                                            runat="server" OnClick="lbHideAdvanceQuery_Click" CssClass="btn btn-outline-info btn-sm">隐藏高级查询</asp:LinkButton>

                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblFldTypeq" runat="server" CssClass="text-secondary">字段类型</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlFldTypeq" runat="server" Width="138px">
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lblIsNullq" runat="server" CssClass="text-secondary">是否可空</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlIsNullq" runat="server" Width="96px">
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblIsPrimaryKeyq" runat="server" CssClass="text-secondary">是否主键</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlIsPrimaryKeyq" runat="server" Width="136px">
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lblFldStateIdq" runat="server" Width="70px" CssClass="text-secondary">
  字段状态</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList ID="ddlFldStateIdq" runat="server" Width="96px">
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td></td>
                                        <td></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">

                                <table style="width: 100%;">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label8"  runat="server" CssClass="h6">工程字段列表</asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblMsgList" runat="server" Style="z-index: 103;" Width="157px" CssClass="text-warning"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="lbCopyField" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="lbCopyField_Click"
                                                >复制字段</asp:LinkButton>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="lbAddNewFld"  runat="server" OnClick="lbAddNewFld_Click"
                                                CssClass="btn btn-outline-info btn-sm">添加新字段</asp:LinkButton>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="lbUpdate" runat="server" OnClick="lbUpdate_Click" 
                                                CssClass="btn btn-outline-info btn-sm">修改</asp:LinkButton>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="lbDelFld" Style="z-index: 103;" runat="server" OnClick="lbDelFld_Click"
                                                CssClass="btn btn-outline-info btn-sm">删除字段</asp:LinkButton>
                                        </td>

                                        <td>
                                            <asp:LinkButton ID="lbDelFieldTabEx"  runat="server" Visible="False"
                                                OnClick="lbDelFieldTabEx_Click" CssClass="btn btn-outline-info btn-sm">扩展删除</asp:LinkButton>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="lbCheckField" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="lbCheckField_Click"
                                                >检查字段</asp:LinkButton>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:LinkButton ID="lbRefreshUpdDate4RelaTab"  runat="server" OnClick="lbRefreshUpdDate4RelaTab_Click"
                                                CssClass="btn btn-outline-info btn-sm">刷新相关表的修改日期</asp:LinkButton>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="btnSetIsRootFld" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetIsRootFld_Click"
                                                >设置为根字段</asp:LinkButton>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddlFldId4Root" runat="server" Width="138px">
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="btnSetRootFld" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetRootFld_Click"
                                                >设置根字段</asp:LinkButton>
                                        </td>
                                         <td>
                                            <asp:LinkButton ID="lbAutoSetRootFld" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="lbAutoSetRootFld_Click"
                                                >自动设置根字段</asp:LinkButton>
                                        </td>

                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <uc1:wucvFieldTab4RootFld4Gv runat="server" ID="wucvFieldTab4RootFld4Gv1" />
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 21px" colspan="4">
                                <table style="width: 857px; position: relative; height: 24px">
                                    <tr>
                                        <td>


                                            <asp:TextBox ID="txtFldName" Style="z-index: 101; left: 32px; top: 0px"
                                                TabIndex="100" runat="server" Width="144px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtCaption" Style="z-index: 106; left: 176px; top: 0px"
                                                TabIndex="101" runat="server" Width="100px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddlFldType" Style="z-index: 102; left: 280px; top: 0px"
                                                TabIndex="102" runat="server" >
                                            </asp:DropDownList>
                                        </td>

                                        <td>
                                            <asp:TextBox ID="txtFldLength" Style="z-index: 104; left: 360px; top: 0px"
                                                TabIndex="103" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtFldPrecision" Style="z-index: 104; left: 360px; top: 0px"
                                                TabIndex="103" runat="server" Width="20px"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddlIsNull" Style="z-index: 103; left: 448px; top: 0px"
                                                TabIndex="104" runat="server" Width="46px">
                                            </asp:DropDownList>
                                        </td>

                                        <td>
                                            <asp:DropDownList ID="ddlIsPrimaryKey" Style="z-index: 107; left: 496px; top: 0px"
                                                TabIndex="105" runat="server" Width="54px">
                                            </asp:DropDownList>
                                        </td>
                                        <td>&nbsp;</td>

                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:LinkButton ID="lbInsNewRec" Style="z-index: 109; left: 784px; top: 8px"
                                                TabIndex="107" runat="server" Width="72px" OnClick="lbInsNewRec_Click">插入新记录</asp:LinkButton>
                                        </td>
                                    </tr>
                                </table>
                                <asp:Label ID="lblMsg4AddRecord" runat="server" CssClass="text-warning" Width="360px"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="字段长度不能为空!"
                                    ControlToValidate="txtFldLength" CssClass="text-warning"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="请输入整型值"
                                    ControlToValidate="txtFldLength" Type="Integer" Operator="DataTypeCheck" CssClass="text-warning"></asp:CompareValidator>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabLayout" style="width: 480px; height: 200px; border-color: #666666"
                        cellspacing="0" cellpadding="0" width="480" border="0" runat="server">
                        <tr>
                            <td style="height: 19px" valign="top">
                                <table style="width: 848px; position: relative; height: 27px">
                                    <tr>
                                        <td>
                                            <asp:LinkButton ID="lbDispFieldList" Style="z-index: 101; left: 760px; top: 8px"
                                                runat="server" Width="83px" OnClick="lbDispFieldList_Click">显示字段列表</asp:LinkButton></td>
                                        <td>
                                            <asp:Button ID="btnOKUpd" Style="z-index: 102; left: 672px; top: 3px"
                                                runat="server"   Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button></td>
                                        <td>
                                            <asp:Label ID="lblMsg" Style="z-index: 103; left: 432px; top: 7px"
                                                runat="server" Width="232px" CssClass="text-warning"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="Label9" Style="z-index: 104; left: 0px; top: 7px"
                                                runat="server" CssClass="h6" BorderColor="#004040">工程字段属性</asp:Label></td>
                                    </tr>
                                </table>
                            </td>
                            <td style="height: 19px" valign="top"></td>
                        </tr>
                        <tr>
                            <td valign="top" colspan="2">
                                <uc1:wucFieldTab ID="wucFieldTab1" runat="server"></uc1:wucFieldTab>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
