<%@ Page Language="c#" CodeBehind="wfmFieldTab_Archive.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmFieldTab_Archive" %>

<%@ Register TagPrefix="uc1" TagName="wucFieldTab" Src="wucFieldTab.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表FieldTab的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <asp:Label ID="Label3" Style="z-index: 103; left: 2px; position: absolute; top: 8px"
            runat="server" Font-Size="Larger" Font-Names="黑体"  Width="184px"
            ForeColor="Blue">表字段管理->字段归档</asp:Label>
        <asp:Label ID="Label2" Style="z-index: 102; left: 232px; position: absolute; top: 8px"
            runat="server" Width="42px"
            ForeColor="#004040" Font-Bold="True">说明：</asp:Label>
        <asp:Label ID="Label1" Style="z-index: 101; left: 288px; position: absolute; top: 8px"
            runat="server" Height="32px" Width="368px"
            ForeColor="#004040">该界面主要用来核实工程字段，如果被核实，将不能被编辑，即修改和删除。</asp:Label>
        <asp:Label ID="lblPrjIdq" runat="server"
            Style="z-index: 104; left: 896px; position: absolute; top: 16px">工程ID</asp:Label>
        <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="100px" Enabled="False"
            Style="z-index: 105; left: 968px; position: absolute; top: 16px">
        </asp:DropDownList>
        <asp:Label ID="lblAppliedScopeq" runat="server"
            Style="z-index: 106; left: 920px; position: absolute; top: 48px">适用范围</asp:Label>
        <asp:TextBox ID="txtAppliedScopeq" runat="server" Width="100px" Style="z-index: 107; left: 904px; position: absolute; top: 72px"></asp:TextBox>
        <table id="Table2" style="z-index: 108; left: 16px; position: absolute; top: 40px"
            cellspacing="0" cellpadding="0" width="300" border="0">
            <tr>
                <td>
                    <table id="tabQuery" style="width: 493px; height: 264px" bordercolor="#330033" cellspacing="0"
                        cellpadding="0" width="493" border="0" runat="server">
                        <tr>
                            <td colspan="5" style="height: 65px">
                                <table id="Table1" style="width: 832px; height: 40px" cellspacing="1" cellpadding="1"
                                    width="832" border="0">
                                    <tr>
                                        <td style="width: 107px" align="right">
                                            <asp:Label ID="lblFldNameq" runat="server">字段名称</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="txtFldNameq" runat="server" Width="144px"></asp:TextBox></td>
                                        <td>
                                            <asp:Label ID="lblFldTypeq" runat="server">字段类型</asp:Label></td>
                                        <td>
                                            <asp:DropDownList ID="ddlFldTypeq" runat="server" Width="111px">
                                            </asp:DropDownList></td>
                                        <td>
                                            <asp:Label ID="lblIsNullq" runat="server">是否可空</asp:Label></td>
                                        <td>
                                            <asp:DropDownList ID="ddlIsNullq" runat="server" Width="96px">
                                            </asp:DropDownList></td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 107px" align="right" colspan="1" rowspan="1">
                                            &nbsp;</td>
                                        <td style="width: 124px">
                                            &nbsp;</td>
                                        <td>
                                            <asp:Label ID="lblIsPrimaryKeyq" runat="server">是否主键</asp:Label></td>
                                        <td>
                                            <asp:DropDownList ID="ddlIsPrimaryKeyq" runat="server" Width="112px">
                                            </asp:DropDownList></td>
                                        <td>
                                            <asp:Label ID="lblFldStateIdq" runat="server" Width="54px">
  字段状态</asp:Label></td>
                                        <td>
                                            <asp:DropDownList ID="ddlFldStateIdq" runat="server" Width="96px">
                                            </asp:DropDownList></td>
                                        <td>
                                            <asp:Button ID="btnQuery" runat="server"  Text="查询"></asp:Button></td>
                                    </tr>
                                </table>
                            </td>
                            <td style="height: 65px"></td>
                        </tr>
                        <tr>
                            <td style="height: 16px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            </td>
                            <td style="height: 16px"></td>
                            <td style="height: 16px"></td>
                            <td style="height: 16px">
                                <asp:LinkButton ID="lbSetArchive" runat="server" OnClick="lbSetArchive_Click">设置归档</asp:LinkButton></td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:DataGrid ID="dgFieldTab" runat="server" Width="832px" Height="224px" Font-Names="宋体"
                                    Font-Size="Smaller" CellPadding="0" BackColor="White" BorderWidth="2px" BorderStyle="Ridge"
                                    BorderColor="White" AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True"
                                    PageSize="12" OnItemCreated="dgFieldTab_ItemCreated" OnItemDataBound="dgFieldTab_ItemDataBound" OnPageIndexChanged="dgFieldTab_PageIndexChanged" OnSortCommand="dgFieldTab_SortCommand">
                                    <FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
                                    <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#999966"></HeaderStyle>
                                    <Columns>
                                        <asp:TemplateColumn>
                                            <HeaderStyle Width="12px"></HeaderStyle>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn Visible="False" DataField="FldId" HeaderText="字段ID"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FldName" SortExpression="FldName" HeaderText="字段名称">
                                            <HeaderStyle Width="150px"></HeaderStyle>
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="FldName_B" SortExpression="FldName_B" HeaderText="字段名称_后备">
                                            <HeaderStyle Width="130px"></HeaderStyle>
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="Caption" SortExpression="Caption" HeaderText="标题名称">
                                            <HeaderStyle Width="100px"></HeaderStyle>
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="DataTypeName" SortExpression="DataTypeName" HeaderText="类型">
                                            <HeaderStyle ></HeaderStyle>
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="FldLength" HeaderText="长度">
                                            <HeaderStyle ></HeaderStyle>
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsNull" HeaderText="可空">
                                            <HeaderStyle Width="30px"></HeaderStyle>
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsPrimaryKey" HeaderText="主键"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsNationStandard" HeaderText="国标"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="MaxValue" HeaderText="最大值"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="MinValue" HeaderText="最小值"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="DefaultValue" HeaderText="缺省值"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="CodeTab" HeaderText="代码表"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="CodeTabName" HeaderText="名称字段"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="CodeTabCode" HeaderText="代码字段"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="AppliedScope" HeaderText="适用范围"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="IsChecked" SortExpression="IsChecked"
                                            HeaderText="审核"></asp:BoundColumn>
                                        <asp:TemplateColumn HeaderText="审核">
                                            <HeaderStyle Width="12px"></HeaderStyle>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkIsChecked" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn Visible="False" DataField="IsArchive" SortExpression="IsArchive"
                                            HeaderText="归档"></asp:BoundColumn>
                                        <asp:TemplateColumn HeaderText="归档">
                                            <HeaderStyle Width="12px"></HeaderStyle>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkIsArchive" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6" Mode="NumericPages"></PagerStyle>
                                </asp:DataGrid></td>
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
        </table>

    </form>
</body>
</html>
