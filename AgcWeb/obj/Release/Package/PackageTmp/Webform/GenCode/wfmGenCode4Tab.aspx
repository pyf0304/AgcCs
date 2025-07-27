<%@ Page Language="c#" CodeBehind="wfmGenCode4Tab.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmGenCode4Tab" ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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

</head>
<body>
    <form id="Form1" method="post" runat="server">

        <asp:Label ID="Label3" Style="z-index: 102; left: 8px; position: absolute; top: 8px"
            runat="server" CssClass="h5">生成C#代码->生成表相关代码</asp:Label>
        <asp:Label ID="Label1" Style="z-index: 101; left: 584px; position: absolute; top: 8px"
            runat="server" Height="32px" Width="274px" CssClass="MemoStyle1">主要用来生成与表相关的代码，包括：1、建表的SQL语句；2、生成通用逻辑层代码等。</asp:Label>
        <table id="tabHidden" style="z-index: 103; left: 920px; position: absolute; top: 400px"
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
        <input id="RadioName" style="z-index: 104; left: 1048px; position: absolute; top: 264px" type="radio" />
        <input id="rd" style="z-index: 105; left: 912px; width: 56px; position: absolute; top: 264px; height: 22px"
            type="hidden" size="4" runat="server" />
        <asp:Label ID="lblPrjIdq" runat="server" Width="70px"
            Style="z-index: 106; left: 864px; position: absolute; top: 24px">工程编号</asp:Label>
        <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="96px" Enabled="False"
            Style="z-index: 107; left: 944px; position: absolute; top: 16px">
        </asp:DropDownList>
        <table id="Table1" style="z-index: 108; left: 0px; width: 768px; position: absolute; top: 40px"
            cellspacing="0" cellpadding="0" width="768" border="0">
            <tr>
                <td style="width: 415px" valign="top">
                    <table id="tabQuery" style="width: 768px" bordercolor="#000033" cellspacing="1" cellpadding="1"
                        width="768" border="4" runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="lblTabNameq" runat="server" Width="70px">表名</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtTabNameq" runat="server" Width="144px"></asp:TextBox></td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblTabCnNameq" runat="server" Width="59px">中文表名</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtTabCnNameq" runat="server" Width="148px"></asp:TextBox></td>
                            <td>
                                <asp:Label ID="Label5" runat="server" Width="56px">模块编号</asp:Label></td>
                            <td>
                                <asp:DropDownList ID="ddlFuncModuleId" runat="server" Width="232px">
                                </asp:DropDownList></td>
                            <td>
                                <asp:Button ID="btnQuery" runat="server"  Text="查询" OnClick="btnQuery_Click"></asp:Button></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                            <td></td>
                        </tr>
                        <tr>
                            <td colspan="5"></td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <div style="width: 838px; position: relative; height: 31px">
                                    <asp:LinkButton ID="lbGeneNewTabInSQL" runat="server"
                                        Style="z-index: 100; left: 721px; position: absolute; top: 8px" OnClick="lbGeneNewTabInSQL_Click">在相关库生成新表</asp:LinkButton>
                                    <asp:LinkButton ID="lbGenCode4CreateTab" runat="server"
                                        Style="z-index: 101; left: 588px; position: absolute; top: 6px" OnClick="lbGenCode4CreateTab_Click">生成建表的SQL语句</asp:LinkButton>
                                    <asp:LinkButton ID="lbGeneLogicCode" runat="server" Width="128px"
                                        Style="z-index: 103; left: 117px; position: absolute; top: 9px" OnClick="lbGeneLogicCode_Click">生成通用逻辑层代码</asp:LinkButton>
                                    <asp:Label ID="Label2" Style="z-index: 104; left: 8px; position: absolute; top: 8px"
                                        runat="server" CssClass="h6">工程表列表</asp:Label>
                                    <asp:Button ID="btnGenGeneLogicCode_Oracle" runat="server"  OnClick="btnGenGeneLogicCode_Oracle_Click"
                                        Style="left: 375px; position: relative; top: 2px" Text="数据逻辑层_Ora" Width="100px" />
                                    <asp:Button ID="btnGenGeneLogicCodeEx_Oracle" runat="server"  OnClick="btnGenGeneLogicCodeEx_Oracle_Click"
                                        Style="left: 372px; position: relative; top: 3px" Text="逻辑层Ex_Ora" Width="100px" />
                                    <asp:Button ID="btnGenGeneExLogicCode" runat="server"  OnClick="btnGenGeneExLogicCode_Click"
                                        Style="left: 44px; position: relative; top: 2px" Text="数据逻辑层Ex" Width="100px" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5"></td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:DataGrid ID="dgPrjTab" runat="server" Width="848px" Font-Names="宋体" Font-Size="Smaller"
                                    GridLines="None" CellPadding="0" BackColor="White" BorderWidth="1px" BorderStyle="Ridge"
                                    BorderColor="White" AllowPaging="True" AutoGenerateColumns="False" AllowSorting="True"
                                    PageSize="15" OnItemCommand="dgPrjTab_ItemCommand" OnItemCreated="dgPrjTab_ItemCreated" OnPageIndexChanged="dgPrjTab_PageIndexChanged" OnSortCommand="dgPrjTab_SortCommand">
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
                                        <asp:BoundColumn DataField="ObjName" SortExpression="ObjName" HeaderText="对象编号"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="PrjName" HeaderText="工程编号"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="IsChecked" SortExpression="IsCheck" HeaderText="核实"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="IsArchive" SortExpression="IsArchive"
                                            HeaderText="归档"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="KeyFldName" SortExpression="KeyFldName" HeaderText="主键"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrimaryTypeName" SortExpression="PrimaryTypeName" HeaderText="主键类型"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="DataBaseName" SortExpression="DataBaseName" HeaderText="数据库名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Memo" HeaderText="说明"></asp:BoundColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6" Mode="NumericPages"></PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="宋体"
                                    Font-Size="Smaller">查询结果记录数：</asp:Label></td>
                            <td colspan="3">
                                <asp:TextBox ID="txtRecCount" runat="server" Width="111px" Font-Names="宋体"
                                    Font-Size="Smaller" ReadOnly="True"></asp:TextBox></td>
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
                </td>
                <td></td>
            </tr>
            <tr>
                <td style="width: 415px"></td>
                <td></td>
                <td></td>
            </tr>
        </table>
        <asp:Label ID="lblMsg2" runat="server" Width="336px" 
            Style="z-index: 109; left: 232px; position: absolute; top: 8px"
            CssClass="text-warning"></asp:Label>

    </form>
</body>
</html>
