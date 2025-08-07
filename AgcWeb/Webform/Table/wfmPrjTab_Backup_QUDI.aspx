<%@ Page Language="c#" CodeBehind="wfmPrjTab_Backup_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmPrjTab_Backup_QUDI" ValidateRequest="false" %>

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

        <asp:Label ID="Label3" Style="z-index: 103; left: 8px; position: absolute; top: 8px"
            runat="server" Width="216px" CssClass="h5">表字段管理->项目表名备份</asp:Label>
        <asp:Label ID="Label2" Style="z-index: 102; left: 232px; position: absolute; top: 8px"
            runat="server" Width="42px"
            ForeColor="#004040" Font-Bold="True" CssClass="MemoStyle1">说明：</asp:Label>
        <asp:Label ID="Label1" Style="z-index: 101; left: 288px; position: absolute; top: 8px"
            runat="server" Height="32px" Width="368px" CssClass="MemoStyle1">项目表主要用来维护管理项目相关的表，包括表的添加、删除、修改、查询等，以便开发者快速查询项目中相关表的信息。</asp:Label>
        <table id="tabHidden" style="z-index: 104; left: 920px; position: absolute; top: 400px"
            cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
            <tr>
                <td>
                    <asp:Label ID="lblTabIdq" runat="server" Width="70px">表编号</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtTabIdq" runat="server" Width="41px"></asp:TextBox></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </table>
        <input id="RadioName" style="z-index: 105; left: 1048px; position: absolute; top: 264px"
            type="radio" />
        <input id="rd" style="z-index: 106; left: 912px; width: 56px; position: absolute; top: 264px; height: 22px"
            type="hidden" size="4" runat="server" />
        <asp:Label ID="lblPrjIdq" runat="server" Width="70px"
            Style="z-index: 107; left: 864px; position: absolute; top: 24px">工程编号</asp:Label>
        <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="96px" Enabled="False"
            Style="z-index: 108; left: 944px; position: absolute; top: 16px">
        </asp:DropDownList>
        <table id="Table1" style="z-index: 109; left: 4px; width: 768px; position: absolute; top: 41px; height: 475px"
            cellspacing="0" cellpadding="0" width="768" border="0">
            <tr>
                <td>
                    <table id="Table2" style="width: 680px; height: 24px" cellspacing="1" cellpadding="1" width="680" border="1">
                        <tr>
                            <td>
                                <asp:Label ID="lblTabNameq" runat="server" Width="32px" CssClass="text-secondary">表名</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtTabNameq" runat="server" Width="158px"></asp:TextBox></td>
                            <td>
                                <asp:Label ID="lblObjIdq" runat="server" Width="56px" CssClass="text-secondary">对象编号</asp:Label></td>
                            <td>
                                <asp:DropDownList ID="ddlObjIdq" runat="server" Width="295px">
                                </asp:DropDownList></td>
                            <td>
                                <asp:Label ID="lblTabStateIdq" runat="server" Width="70px" CssClass="text-secondary">
  表状态ID</asp:Label></td>
                            <td style="width: 122px">
                                <asp:DropDownList ID="ddlTabStateIdq" runat="server" Width="117px" >
                                </asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblTabCnNameq" runat="server" Width="52px" CssClass="text-secondary">中文表名</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtTabCnNameq" runat="server" Width="161px"></asp:TextBox></td>
                            <td>
                                <asp:Label ID="Label5" runat="server" Width="56px" CssClass="text-secondary">模块编号</asp:Label></td>
                            <td>
                                <asp:DropDownList ID="ddlFuncModuleId" runat="server" Width="294px">
                                </asp:DropDownList></td>
                            <td>
                                <asp:Button ID="btnQuery" runat="server" Width="63px" Text="查询" OnClick="btnQuery_Click"></asp:Button></td>
                            <td style="width: 122px"></td>
                        </tr>
                    </table>

                </td>
            </tr>
            <tr>
                <td style="width: 415px" valign="top">
                    <table id="tabQuery" style="width: 440px; height: 320px" bordercolor="#000033" cellspacing="1"
                        cellpadding="1" width="440" border="4" runat="server">
                        <tr>
                            <td colspan="5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:LinkButton ID="lbBackupTabName" runat="server" OnClick="lbBackupTabName_Click">表名备份</asp:LinkButton>&nbsp;
                                    <asp:LinkButton ID="lbGeneLogicCode" runat="server" Width="128px" OnClick="lbGeneLogicCode_Click">生成通用逻辑层代码</asp:LinkButton>&nbsp;
                                    <asp:Label ID="lblMsg2" runat="server" Width="448px"  CssClass="text-warning"></asp:Label></td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:DataGrid ID="dgPrjTab" runat="server" Width="744px" Font-Names="宋体"
                                    Font-Size="Smaller" GridLines="None" CellPadding="0" BackColor="White" BorderWidth="1px"
                                    BorderStyle="Ridge" BorderColor="White" AllowPaging="True" AutoGenerateColumns="False"
                                    AllowSorting="True" PageSize="15">
                                    <FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
                                    <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
                                    <Columns>
                                        <asp:TemplateColumn>
                                            <HeaderStyle Width="15px"></HeaderStyle>
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server">全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn Visible="False" DataField="TabId" HeaderText="表编号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="TabName" SortExpression="TabName" HeaderText="表名">
                                            <HeaderStyle Font-Bold="True" ForeColor="White"></HeaderStyle>
                                            <ItemStyle Font-Bold="True"></ItemStyle>
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="TabName_B" SortExpression="TabName_B" HeaderText="表名_后备"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="TabCnName" SortExpression="TabCnName" HeaderText="表中文名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ObjName" SortExpression="ObjName"
                                            HeaderText="对象编号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="DataBaseName" SortExpression="DataBaseName" HeaderText="数据库名称"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="PrjName" HeaderText="工程编号"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="Memo" HeaderText="说明"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsChecked" SortExpression="IsCheck" HeaderText="核实"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsArchive" SortExpression="IsArchive" HeaderText="归档"></asp:BoundColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6" Mode="NumericPages"></PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="宋体"
                                    Font-Size="Smaller">查询结果记录数：</asp:Label></td>
                            <td colspan="2">
                                <asp:TextBox ID="txtRecCount" runat="server" Width="111px" Font-Names="宋体"
                                    Font-Size="Smaller" ReadOnly="True"></asp:TextBox></td>
                            <td></td>
                        </tr>
                    </table>
                </td>
                <td valign="top"></td>
                <td></td>
            </tr>
            <tr>
                <td colspan="2" valign="top">
                    <table id="tabCode" style="width: 776px; height: 44px" cellspacing="1" cellpadding="1"
                        width="776" border="1" runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Width="144px"  Font-Names="宋体"
                                    Font-Size="Smaller">生成的逻辑层代码：</asp:Label></td>
                            <td>
                                <asp:LinkButton ID="lbDispTabList" runat="server" OnClick="lbDispTabList_Click">显示表名列表</asp:LinkButton></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                 <asp:Literal ID="litCode" runat="server"></asp:Literal>
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
            </tr>
            <tr>
                <td style="width: 415px"></td>
                <td></td>
                <td></td>
            </tr>
        </table>

    </form>
</body>
</html>
