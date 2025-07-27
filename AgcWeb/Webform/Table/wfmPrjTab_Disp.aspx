<%@ Page Language="c#" CodeBehind="wfmPrjTab_Disp.aspx.cs" AutoEventWireup="True" Inherits="AGC.Webform.wfmPrjTab_Disp"
    ValidateRequest="false" EnableEventValidation="false" ResponseEncoding="utf-8" %>

<%@ Register TagPrefix="uc1" TagName="wucPrjTab" Src="wucPrjTab.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表PrjTab的查询、修改、删除、添加记录</title>
    

    <script language="javascript" type="text/javascript">
<!--
    function radioClick() {
        if (document.Form1.RadioName != null) {
            for (i = 0; i < document.Form1.RadioName.length; i++) {
                if (document.Form1.RadioName[i].checked == true) {
                    document.Form1.rd.value = document.Form1.RadioName[i].value;
                }
            }
        }
    }
    //-->
    </script>
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
        <table style="width: 398px; z-index: 100; left: 4px; position: absolute; top: 4px;">
            <tr>
                <td>
                    <div style="width: 711px; height: 35px; position: relative;">
                        <asp:Label ID="Label3" Style="z-index: 102; left: 7px; position: absolute; top: 5px"
                            runat="server" Width="200px" CssClass="h5">表字段管理->项目表查看</asp:Label>
                        <asp:Label ID="Label1" Style="z-index: 101; left: 464px; position: absolute; top: 6px"
                            runat="server" Height="32px" Width="329px" CssClass="MemoStyle1">项目表主要用来查询项目相关的表，以便开发者快速了解项目中相关表及字段信息。</asp:Label>
                        <input id="RadioName" style="z-index: 104; left: 1048px; position: absolute; top: 264px"
                            type="radio" />
                        <input id="rd" style="z-index: 105; left: 912px; width: 56px; position: absolute; top: 264px; height: 22px"
                            type="hidden" size="4" runat="server" />
                        <asp:Label ID="lblMsg2" runat="server" Width="246px"  Style="z-index: 107; left: 214px; position: absolute; top: 4px"
                            CssClass="text-warning"></asp:Label>
                    </div>

                </td>
            </tr>
            <tr>
                <td>
                    <table id="Table2" style="width: 760px" cellspacing="1" cellpadding="1" width="760"
                        border="1">
                        <tr>
                            <td>
                                <asp:Label ID="lblTabNameq" runat="server"  CssClass="text-secondary">表名</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtTabNameq" runat="server" Width="109px"></asp:TextBox></td>
                            <td>
                                <asp:Label ID="Label5" runat="server"  CssClass="text-secondary">模块名</asp:Label></td>
                            <td style="width: 335px">
                                <asp:DropDownList ID="ddlFuncModuleId" runat="server" Width="295px">
                                </asp:DropDownList></td>
                            <td>
                                <asp:Label ID="lblTabStateIdq" runat="server"  CssClass="text-secondary">表状态</asp:Label></td>
                            <td style="width: 122px">
                                <asp:DropDownList ID="ddlTabStateIdq" runat="server" Width="85px" >
                                </asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td style="height: 20px">
                                <asp:Label ID="lblTabCnNameq" runat="server" Width="59px" CssClass="text-secondary">中文表名</asp:Label></td>
                            <td style="height: 20px">
                                <asp:TextBox ID="txtTabCnNameq" runat="server" Width="109px"></asp:TextBox></td>
                            <td style="height: 20px">&nbsp;</td>
                            <td style="width: 335px; height: 20px;">

                                &nbsp;</td>
                            <td style="height: 20px">
                                <asp:Label ID="Label6" runat="server" Width="65px" CssClass="text-secondary">数据源类型</asp:Label></td>
                            <td style="height: 20px; width: 122px;">
                                <asp:DropDownList ID="ddlSqlDsTypeId" runat="server" Width="85px">
                                </asp:DropDownList></td>
                            <td style="height: 20px">
                                <asp:Button ID="btnQuery" runat="server" Width="61px" Text="查询" OnClick="btnQuery_Click"></asp:Button></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="height: 21px">
                    <table id="tabQuery" style="width: 440px" bordercolor="#000033" cellspacing="1" cellpadding="1"
                        width="440" border="2" runat="server">
                        <tr>
                            <td style="width: 551px">
                                <div style="width: 753px; position: relative; height: 26px">
                                    <asp:LinkButton ID="lbDetail" runat="server" Style="z-index: 100; left: 208px; position: absolute; top: 8px"
                                        OnClick="lbDetail_Click">详细信息</asp:LinkButton>
                                    <asp:LinkButton ID="lbDispTabField" runat="server" Style="z-index: 101; left: 272px; position: absolute; top: 8px"
                                        OnClick="lbDispTabField_Click">查看表字段</asp:LinkButton>
                                    <asp:LinkButton ID="lbGeneLogicCode" runat="server" Width="128px" Style="z-index: 102; left: 352px; position: absolute; top: 8px"
                                        OnClick="lbGeneLogicCode_Click">生成通用逻辑层代码</asp:LinkButton>
                                    <asp:LinkButton ID="lbExportExcel" runat="server" Width="64px" Style="z-index: 104; left: 664px; position: absolute; top: 8px"
                                        OnClick="lbExportExcel_Click">导出Excel</asp:LinkButton>
                                    <asp:LinkButton ID="lbGeneLogicCodeEx" Style="z-index: 105; left: 488px; position: absolute; top: 8px"
                                        runat="server" Width="120px" OnClick="lbGeneLogicCodeEx_Click">生成通用扩展逻辑层</asp:LinkButton>
                                    <asp:Label ID="Label2" Style="z-index: 106; left: 8px; position: absolute; top: 8px"
                                        runat="server" CssClass="h5">项目表列表</asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 551px">

                                <asp:DataGrid ID="dgPrjTab" runat="server" Width="832px" Font-Names="宋体" Font-Size="Smaller"
                                    GridLines="None" CellPadding="0" BackColor="White" BorderWidth="1px" BorderStyle="Ridge"
                                    BorderColor="White" AllowPaging="True" AutoGenerateColumns="False" AllowSorting="True"
                                    PageSize="15" OnItemCommand="dgPrjTab_ItemCommand" OnItemCreated="dgPrjTab_ItemCreated" OnItemDataBound="dgPrjTab_ItemDataBound" OnPageIndexChanged="dgPrjTab_PageIndexChanged" OnSortCommand="dgPrjTab_SortCommand">
                                    <FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
                                    <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
                                    <Columns>
                                        <asp:TemplateColumn>
                                            <HeaderStyle Width="22px"></HeaderStyle>
                                            <ItemTemplate>
                                                <input onclick="radioClick()" type="radio" value='<%# DataBinder.Eval(Container.DataItem, "TabId")%>'
                                                    name="RadioName">
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn Visible="False" DataField="TabId" HeaderText="表编号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="TabName" SortExpression="TabName" HeaderText="表名">
                                            <HeaderStyle Font-Bold="True" ForeColor="White"></HeaderStyle>
                                            <ItemStyle Font-Bold="True"></ItemStyle>
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="TabCnName" SortExpression="TabCnName" HeaderText="表中文名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="功能模块"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FldNum" SortExpression="FldNum" HeaderText="字段数"></asp:BoundColumn>
                              
                                        <asp:BoundColumn Visible="False" DataField="PrjName" HeaderText="工程编号"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="Memo" HeaderText="说明"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsChecked" SortExpression="IsCheck" HeaderText="核实"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsArchive" SortExpression="IsArchive" HeaderText="归档"></asp:BoundColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6" Mode="NumericPages"></PagerStyle>
                                </asp:DataGrid>

                            </td>
                        </tr>
                        <tr>
                            <td style="height: 32px">
                                <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="宋体"
                                    Font-Size="Smaller">查询结果记录数：</asp:Label>
                                <asp:TextBox ID="txtRecCount" runat="server" Width="111px" Font-Names="宋体"
                                    Font-Size="Smaller" ReadOnly="True"></asp:TextBox></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="height: 21px">
                    <table id="tabCode" style="width: 800px; height: 520px" cellspacing="1" cellpadding="1"
                        width="800" border="1" runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Width="144px"  CssClass="h6">生成的逻辑层代码：</asp:Label></td>
                            <td>
                                <asp:LinkButton ID="lbDispTabList" runat="server" OnClick="lbDispTabList_Click">显示表名列表</asp:LinkButton></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                  <asp:Literal ID="litCode" runat="server"></asp:Literal>
                            </td>
                        </tr>
                    </table>
                    <br />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
