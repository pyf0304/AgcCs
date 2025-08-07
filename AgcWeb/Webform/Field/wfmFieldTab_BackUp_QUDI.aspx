<%@ Register TagPrefix="uc1" TagName="wucFieldTab" Src="wucFieldTab.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmFieldTab_BackUp_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmFieldTab_BackUp_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>表FieldTab的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Label ID="Label3" Style="z-index: 103; left: 8px; position: absolute; top: 8px"
            runat="server" Font-Size="Larger" Font-Names="黑体"  Width="216px"
            ForeColor="Blue" CssClass="h5">表字段管理->字段备份维护</asp:Label>
        <asp:Label ID="Label2" Style="z-index: 102; left: 232px; position: absolute; top: 8px"
            runat="server" Width="42px" ForeColor="#004040" Font-Bold="True" CssClass="MemoStyle1">说明：</asp:Label>
        <asp:Label ID="Label1" Style="z-index: 101; left: 288px; position: absolute; top: 8px"
            runat="server" Height="32px" Width="368px" ForeColor="#004040" CssClass="MemoStyle1">主要用来把当前字段名备份到字段备份，以便记录该字段以前的名称，同时可以编辑修改字段信息。</asp:Label>
        <asp:Label ID="lblPrjIdq" runat="server" Style="z-index: 104;
            left: 896px; position: absolute; top: 16px">工程ID</asp:Label>
        <asp:DropDownList ID="ddlPrjIdq" runat="server"  Width="100px" Enabled="False"
            Style="z-index: 105; left: 968px; position: absolute; top: 16px">
        </asp:DropDownList>
        <asp:Label ID="lblAppliedScopeq" runat="server" Style="z-index: 106;
            left: 920px; position: absolute; top: 48px">适用范围</asp:Label>
        <asp:TextBox ID="txtAppliedScopeq" runat="server"  Width="100px" Style="z-index: 107;
            left: 904px; position: absolute; top: 72px"></asp:TextBox>
        <table id="Table2" style="z-index: 108; left: 0px; position: absolute; top: 40px"
            cellspacing="0" cellpadding="0" width="860" border="0" bordercolor="#ff3300">
            <tr>
                <td>
                    <table id="tabQuery" style="width: 862px" bordercolor="#0066ff" cellspacing="0" cellpadding="0"
                        border="0" runat="server">
                        <tr>
                            <td colspan="5">
                                    <table id="Table1" style="width: 704px; height: 46px" cellspacing="0" cellpadding="0" width="704" border="0">
                                        <tr>
                                            <td style="width: 107px" align="left" colspan="1" rowspan="1">
                                                <asp:Label ID="lblFldNameq" runat="server" CssClass="text-secondary">字段名称</asp:Label></td>
                                            <td>
                                                <asp:TextBox ID="txtFldNameq" runat="server" Width="184px" ></asp:TextBox></td>
                                            <td>
                                                <asp:Label ID="lblFldTypeq" runat="server" CssClass="text-secondary">字段类型</asp:Label></td>
                                            <td>
                                                <asp:DropDownList ID="ddlFldTypeq" runat="server" Width="138px" >
                                                </asp:DropDownList></td>
                                            <td>
                                                <asp:Label ID="lblIsNullq" runat="server" CssClass="text-secondary">是否可空</asp:Label></td>
                                            <td>
                                                <asp:DropDownList ID="ddlIsNullq" runat="server" Width="96px" >
                                                </asp:DropDownList></td>
                                            <td>
                                            </td>
                                            <td>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 107px" align="left">
                                                &nbsp;</td>
                                            <td style="width: 124px">
                                                &nbsp;</td>
                                            <td>
                                                <asp:Label ID="lblIsPrimaryKeyq" runat="server" CssClass="text-secondary">是否主键</asp:Label></td>
                                            <td>
                                                <asp:DropDownList ID="ddlIsPrimaryKeyq" runat="server" Width="136px" >
                                                </asp:DropDownList></td>
                                            <td>
                                                <asp:Label ID="lblFldStateIdq" runat="server" Width="70px" >
  字段状态</asp:Label></td>
                                            <td>
                                                <asp:DropDownList ID="ddlFldStateIdq" runat="server" Width="96px" >
                                                </asp:DropDownList></td>
                                            <td>
                                            </td>
                                            <td>
                                                <asp:Button ID="btnQuery" runat="server"  Text="查询" OnClick="btnQuery_Click"></asp:Button></td>
                                        </tr>
                                    </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <div style="width: 820px; position: relative; height: 34px; left: 0px; top: 0px;">
                                    <asp:Label ID="lblRelaTab" Style="z-index: 101; left: 10px; position: absolute; top: 13px"
                                        runat="server" Width="280px" >相关表：</asp:Label>
                                    <asp:LinkButton ID="lbAddNewFld" Style="z-index: 102; left: 370px; position: absolute;
                                        top: 13px" runat="server" OnClick="lbAddNewFld_Click">添加新字段</asp:LinkButton>
                                    <asp:LinkButton ID="lbBackUpFldInfo" Style="z-index: 103; left: 450px; position: absolute;
                                        top: 13px" runat="server">备份字段信息</asp:LinkButton>
                                    <asp:LinkButton ID="lbDelFld" Style="z-index: 104; left: 546px; position: absolute;
                                        top: 13px" runat="server" OnClick="lbDelFld_Click">删除字段</asp:LinkButton>
                                    <asp:LinkButton ID="lbSynchWithTab" Style="z-index: 106; left: 306px; position: absolute;
                                        top: 13px" runat="server" OnClick="lbSynchWithTab_Click">与表同步</asp:LinkButton>
                                    <asp:Label ID="lblMsg3" Style="z-index: 107; left: 602px; position: absolute; top: 13px"
                                        runat="server" Width="200px" ></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:DataGrid ID="dgFieldTab" runat="server" Width="860px" Height="224px" Font-Names="宋体"
                                    Font-Size="Smaller" CellPadding="0" BackColor="White" BorderWidth="2px" BorderStyle="Ridge"
                                    BorderColor="White" AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True"
                                    PageSize="12" OnItemCommand="dgFieldTab_ItemCommand" OnItemCreated="dgFieldTab_ItemCreated" OnItemDataBound="dgFieldTab_ItemDataBound" OnPageIndexChanged="dgFieldTab_PageIndexChanged" OnSortCommand="dgFieldTab_SortCommand">
                                    <FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
                                    <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#999966"></HeaderStyle>
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
                                        <asp:BoundColumn Visible="False" DataField="FldId" HeaderText="字段ID"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FldName" SortExpression="FldName" HeaderText="字段名称">
                                            <HeaderStyle Width="130px"></HeaderStyle>
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="FldName_B" SortExpression="FldName_B" HeaderText="字段名称_后备">
                                            <HeaderStyle Width="130px"></HeaderStyle>
                                        </asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="FldName_G" SortExpression="FldName_G"
                                            HeaderText="字段名称_国标">
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
                                        <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6" Mode="NumericPages">
                                    </PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        
                        <tr>
                            <td colspan="4">
                                <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="宋体"
                                    Font-Size="Smaller">查询结果记录数：</asp:Label>
                                <asp:TextBox ID="txtRecCount" runat="server" Width="111px"  Font-Names="宋体"
                                    Font-Size="Smaller" ReadOnly="True"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFldLength"
                                    ErrorMessage="字段长度不能为空!" CssClass="text-warning"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtFldLength"
                                    ErrorMessage="请输入整型值" Operator="DataTypeCheck" Type="Integer" CssClass="text-warning"></asp:CompareValidator></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabLayout" style="width: 480px; height: 200px" bordercolor="#666666" cellspacing="0"
                        cellpadding="0" width="480" border="0" runat="server">
                        <tr>
                            <td valign="top" style="height: 19px">
                                <asp:Button ID="btnOKUpd" runat="server"   Text="添加"></asp:Button>
                                <asp:Label ID="lblMsg" runat="server" Width="232px" ></asp:Label></td>
                            <td valign="top" style="height: 19px">
                                <asp:LinkButton ID="lbDispFieldList" runat="server">显示字段列表</asp:LinkButton></td>
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
