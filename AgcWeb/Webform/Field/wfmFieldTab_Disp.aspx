<%@ Page Language="c#" CodeBehind="wfmFieldTab_Disp.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmFieldTab_Disp" %>

<%@ Register TagPrefix="uc1" TagName="wucFieldTab" Src="wucFieldTab.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表FieldTab的查询、修改、删除、添加记录</title>
    
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
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Label ID="Label3" Style="z-index: 103; left: 2px; position: absolute; top: 8px"
            runat="server"  Width="284px" CssClass="h5">表字段管理->字段查看</asp:Label>
        <table id="Table2" style="z-index: 108; left: 4px; position: absolute; top: 35px"
            cellspacing="0" cellpadding="0" width="300" border="0">
            <tr>
                <td>
                    <table id="tabQuery" style="width: 398px; height: 264px" bordercolor="#330033" cellspacing="0"
                        cellpadding="0" border="0" runat="server">
                        <tr>
                            <td colspan="5" style="height: 65px">
                                <table id="Table1" style="width: 556px; height: 53px" cellspacing="1" cellpadding="1"
                                    width="656" border="0">
                                    <tr>
                                        <td style="width: 66px" align="left">
                                            <asp:Label ID="lblFldNameq" runat="server" CssClass="text-secondary">字段名称</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="txtFldNameq" runat="server" Width="192px"></asp:TextBox></td>
                                        <td>
                                            <asp:Label ID="lblFldTypeq" runat="server" CssClass="text-secondary">字段类型</asp:Label></td>
                                        <td style="width: 143px">
                                            <asp:DropDownList ID="ddlFldTypeq" runat="server" Width="154px">
                                            </asp:DropDownList></td>
                                        <td>
                                            <asp:Label ID="lblIsNullq" runat="server" CssClass="text-secondary">是否可空</asp:Label></td>
                                        <td>
                                            <asp:DropDownList ID="ddlIsNullq" runat="server" Width="70px">
                                            </asp:DropDownList></td>
                                        <td>
                                            <asp:Label ID="lblIsPrimaryKeyq" runat="server" CssClass="text-secondary">是否主键</asp:Label></td>
                                        <td>
                                            <asp:DropDownList ID="ddlIsPrimaryKeyq" runat="server" Width="84px">
                                            </asp:DropDownList></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 66px" align="left">
                                            <asp:Label ID="Label10" runat="server" Width="56px" CssClass="text-secondary">功能模块</asp:Label></td>
                                        <td style="width: 124px">
                                            <asp:DropDownList ID="ddlFuncModuleIdq" runat="server" Width="200px"
                                                AutoPostBack="True" OnSelectedIndexChanged="ddlFuncModuleId_q_SelectedIndexChanged">
                                            </asp:DropDownList></td>
                                        <td>
                                            <asp:Label ID="Label4" runat="server" CssClass="text-secondary">相关对象</asp:Label></td>
                                        <td style="width: 143px">
                                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                <ContentTemplate>
                                                    <asp:DropDownList ID="ddlObjIdq" runat="server" Width="152px">
                                                    </asp:DropDownList>
                                                </ContentTemplate>
                                                <Triggers>
                                                    <asp:AsyncPostBackTrigger ControlID="ddlFuncModuleIdq" EventName="SelectedIndexChanged" />
                                                </Triggers>
                                            </asp:UpdatePanel>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblFldStateIdq" runat="server" Width="56px" CssClass="text-secondary">字段状态</asp:Label></td>
                                        <td>
                                            <asp:DropDownList ID="ddlFldStateIdq" runat="server" Width="71px">
                                            </asp:DropDownList></td>
                                        <td colspan="2">
                                            <asp:Button ID="btnQuery" runat="server" Width="101px" Text="查询" CssClass="btn btn-outline-warning btn-sm" OnClick="btnQuery_Click"></asp:Button></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <div style="width: 764px; position: relative; height: 22px">
                                    <asp:Button ID="btnExportExcel" runat="server"  CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"
                                        Style="z-index: 100; left: 616px; position: absolute; top: 2px" OnClick="btnExportExcel_Click"></asp:Button>
                                    <asp:Label ID="Label1" Style="z-index: 101; left: 8px; position: absolute; top: 6px"
                                        runat="server"  CssClass="h6">表字段列表</asp:Label>
                                    <asp:Button ID="btnDetail" runat="server"   Text="详细信息"
                                        Style="z-index: 102; left: 506px; position: absolute; top: 4px" OnClick="btnDetail_Click" />
                                    <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 104; left: 209px; position: absolute; top: 3px"
                                        Width="232px"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4"></td>
                        </tr>
                        <tr>
                            <td colspan="4">

                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        &nbsp;<asp:GridView ID="gvFieldTab" runat="server" AllowPaging="True" AllowSorting="True"
                                            AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                                            BorderWidth="1px" CellPadding="3" CssClass="table table-striped table-bordered table-condensed" DataKeyNames="FldId" GridLines="Horizontal"
                                            Height="1px" OnPageIndexChanging="gvFieldTab_PageIndexChanging" OnRowCommand="gvFieldTab_RowCommand"
                                            OnRowCreated="gvFieldTab_RowCreated"
                                            OnSorting="gvFieldTab_Sorting" Style="z-index: 175; position: relative" Width="849px">
                                            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                            <Columns>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>
                                                        <asp:LinkButton ID="lbSelAll" runat="server" CommandName="lbSelAll" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                                                    </HeaderTemplate>
                                                    <HeaderStyle Width="35px" />
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chkCheckRec" runat="server" />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="FldId" HeaderText="字段ID" />
                                                <asp:BoundField DataField="FldName" HeaderText="字段名称" SortExpression="FldName">
                                                    <HeaderStyle Width="130px" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="FldBName_B" HeaderText="字段名称_后备" SortExpression="FldBName_B"
                                                    Visible="False">
                                                    <HeaderStyle Width="130px" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="FldName_G" HeaderText="字段名称_国标" SortExpression="FldName_G"
                                                    Visible="False">
                                                    <HeaderStyle Width="130px" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="Caption" HeaderText="标题名称" SortExpression="Caption">
                                                    <HeaderStyle Width="100px" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="DataTypeName" HeaderText="类型" SortExpression="DataTypeName">
                                                    <HeaderStyle  />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="FldLength" HeaderText="长度">
                                                    <HeaderStyle  />
                                                </asp:BoundField>
                                                <asp:CheckBoxField DataField="IsNull" HeaderText="可空" />
                                                <asp:CheckBoxField DataField="IsPrimaryKey" HeaderText="主键" SortExpression="IsPrimaryKey" />
                                                <asp:BoundField DataField="IsNationStandard" HeaderText="国标" Visible="False" />
                                                <asp:BoundField DataField="MaxValue" HeaderText="最大值" Visible="False" />
                                                <asp:BoundField DataField="MinValue" HeaderText="最小值" Visible="False" />
                                                <asp:BoundField DataField="DefaultValue" HeaderText="缺省值" Visible="False" />
                                                <asp:BoundField DataField="CodeTab" HeaderText="代码表" />
                                                <asp:BoundField DataField="CodeTabName" HeaderText="名称字段" Visible="False" />
                                                <asp:BoundField DataField="CodeTabCode" HeaderText="代码字段" Visible="False" />
                                                <asp:BoundField DataField="TabNum" HeaderText="表数" SortExpression="TabNum" />
                                                <asp:BoundField DataField="AppliedScope" HeaderText="适用范围" Visible="False" />
                                            </Columns>
                                            <PagerTemplate>
                                                <font style="background-color: #c0c0c0">共有记录:</font>
                                                <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                                    Width="46px">0</asp:Label>
                                                <span style="background-color: #c0c0c0">
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                </span><font style="background-color: #c0c0c0">总页数:</font>
                                                <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">当前页:
                                                    <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <asp:Button ID="btnPrevPage" runat="server" CommandArgument="Prev" CommandName="Page"
                                                        CssClass="btn btn-outline-warning btn-sm small" Text="上一页" Width="50px" /><span style="font-family: Verdana">
                                                        </span>
                                                    <asp:Button ID="btnNextPage" runat="server" CommandArgument="Next" CommandName="Page"
                                                        CssClass="btn btn-outline-warning btn-sm small" Text="下一页" Width="50px" />
                                                    到第
                                                    <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
                                                    <asp:Button ID="btnJumpPage" runat="server" CommandName="Page" CssClass="btn btn-outline-warning btn-sm small"
                                                        OnClick="btnJumpPage_Click" Text="确定" Width="35px" />
                                                    <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                                                        ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator></font>
                                            </PagerTemplate>
                                            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                            <AlternatingRowStyle BackColor="#F7F7F7" />
                                        </asp:GridView>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="btnQuery" EventName="Click" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="宋体"
                                    Font-Size="Smaller">查询结果记录数：</asp:Label>
                                <asp:TextBox ID="txtRecCount" runat="server" Width="111px" Font-Names="宋体"
                                    Font-Size="Smaller" ReadOnly="True"></asp:TextBox></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabLayout" style="width: 400px; height: 200px" bordercolor="#666666" cellspacing="0"
                        cellpadding="0" width="480" border="0" runat="server">
                        <tr>
                            <td style="height: 19px" valign="top">
                                <asp:Button ID="btnOKUpd" runat="server"   Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                <asp:Label ID="lblMsg" runat="server" Width="232px" CssClass="text-warning"></asp:Label></td>
                            <td style="height: 19px" valign="top">
                                <asp:LinkButton ID="lbDispFieldList" runat="server" OnClick="lbDispFieldList_Click">显示字段列表</asp:LinkButton></td>
                        </tr>
                        <tr>
                            <td valign="top" colspan="2">
                                <uc1:wucFieldTab ID="wucFieldTab1" runat="server"></uc1:wucFieldTab>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td></td>
            </tr>
        </table>
    </form>
</body>
</html>
