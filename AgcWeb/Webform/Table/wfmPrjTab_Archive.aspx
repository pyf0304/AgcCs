<%@ Register TagPrefix="uc1" TagName="wucPrjTab" Src="wucPrjTab.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmPrjTab_Archive.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmPrjTab_Archive" ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>表PrjTab的查询、修改、删除、添加记录</title>
    

    <script language="javascript" type="text/javascript">
<!--
function radioClick()
{
       if (document.Form1.RadioName !=null)
       {
           for (i=0; i<document.Form1.RadioName.length; i++)
           {
                 if (document.Form1.RadioName[i].checked == true)
                 {
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
                runat="server" Width="200px" CssClass="h5">表字段管理->项目表归档</asp:Label>
            <asp:Label ID="Label2" Style="z-index: 102; left: 232px; position: absolute; top: 8px"
                runat="server"  Width="42px" Font-Bold="True" CssClass="MemoStyle1">说明：</asp:Label>
            <asp:Label ID="Label1" Style="z-index: 101; left: 288px; position: absolute; top: 8px"
                runat="server"  Height="32px" Width="368px" CssClass="MemoStyle1">项目表主要用来维护管理项目相关的表，包括表的添加、删除、修改、查询等，以便开发者快速查询项目中相关表的信息。</asp:Label>
            <table id="tabHidden" style="z-index: 105; left: 920px; position: absolute; top: 400px"
                cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
                <tr>
                    <td>
                        <asp:Label ID="lblTabIdq" runat="server" Width="70px" 
                            >表编号</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtTabIdq" runat="server" Width="41px" ></asp:TextBox></td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
            <input id="RadioName" style="z-index: 106; left: 1048px; position: absolute; top: 264px"
                type="radio">
            <input id="rd" style="z-index: 107; left: 912px; width: 56px; position: absolute;
                top: 264px; height: 22px" type="hidden" size="4" runat="server">
            <asp:Label ID="lblPrjIdq" runat="server" Width="70px" 
                 Style="z-index: 108; left: 864px; position: absolute; top: 24px">工程编号</asp:Label>
            <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="96px"  Enabled="False"
                Style="z-index: 109; left: 944px; position: absolute; top: 16px">
            </asp:DropDownList>
            <table id="Table1" style="z-index: 112; left: 0px; width: 672px; position: absolute;
                top: 40px" cellspacing="0" cellpadding="0" width="672" border="0">
                <tr>
                    <td style="width: 415px" valign="top">
                        <table id="tabQuery" style="width: 720px" bordercolor="#000033" cellspacing="1"
                            cellpadding="1" width="720" border="2" runat="server">
                            <tr>
                                <td>
                                    <asp:Label ID="lblTabNameq" runat="server" Width="70px" CssClass="text-secondary" 
                                        >表名</asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtTabNameq" runat="server" Width="128px" ></asp:TextBox></td>
                                <td>
                                    <asp:Label ID="lblObjIdq" runat="server" Width="70px" CssClass="text-secondary" 
                                        >对象编号</asp:Label></td>
                                <td>
                                    <asp:DropDownList ID="ddlObjIdq" runat="server" Width="211px" >
                                    </asp:DropDownList></td>
                                <td>
                                    <asp:Label ID="lblTabStateIdq" runat="server" Width="70px" CssClass="text-secondary" 
                                        >
  表状态ID</asp:Label></td>
                                <td style="width: 101px">
                                    <asp:DropDownList ID="ddlTabStateIdq" runat="server" Width="97px" >
                                    </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblTabCnNameq" runat="server" Width="70px" CssClass="text-secondary" 
                                        >中文表名</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtTabCnNameq" runat="server" Width="128px" ></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Width="70px" CssClass="text-secondary" 
                                        >模块编号</asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlFuncModuleId" runat="server" Width="208px" >
                                    </asp:DropDownList>
                                </td>
                                <td colspan="2">
                                    <asp:Button ID="btnQuery" runat="server"  Text="查询" OnClick="btnQuery_Click"></asp:Button>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="6">
                                    <div style="width: 704px; position: relative; height: 18px">
                                        <asp:LinkButton ID="lbSetArchive" runat="server"
                                            Style="z-index: 101; left: 208px; position: absolute; top: 0px" OnClick="lbSetChecked_Click">设置表归档</asp:LinkButton>
                                        <asp:Label ID="lblMsg2" runat="server" Width="304px"  
                                             Style="z-index: 102; left: 296px; position: absolute; top: 0px" CssClass="text-warning"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="6">
                                    <asp:DataGrid ID="dgPrjTab" runat="server" Width="744px" Height="154px" Font-Names="宋体"
                                        Font-Size="Smaller" GridLines="None" CellPadding="0" BackColor="White" BorderWidth="1px"
                                        BorderStyle="Ridge" BorderColor="White" AllowPaging="True" AutoGenerateColumns="False"
                                        AllowSorting="True" PageSize="12" OnItemCreated="dgPrjTab_ItemCreated" OnItemDataBound="dgPrjTab_ItemDataBound" OnPageIndexChanged="dgPrjTab_PageIndexChanged" OnSortCommand="dgPrjTab_SortCommand">
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
                                            <asp:BoundColumn DataField="TabCnName" SortExpression="TabCnName" HeaderText="表中文名">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="ObjName" SortExpression="ObjName"
                                                HeaderText="对象编号"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="DataBaseName" SortExpression="DataBaseName" HeaderText="数据库名称">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="PrjName" HeaderText="工程编号"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="Memo" HeaderText="说明"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="IsChecked" SortExpression="IsChecked"
                                                HeaderText="审核"></asp:BoundColumn>
                                            <asp:TemplateColumn HeaderText="审核">
                                                <HeaderStyle Width="12px"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="chkIsChecked" runat="server">
                                                    </asp:CheckBox>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:BoundColumn Visible="False" DataField="IsArchive" SortExpression="IsArchive"
                                                HeaderText="归档"></asp:BoundColumn>
                                            <asp:TemplateColumn HeaderText="归档">
                                                <HeaderStyle Width="12px"></HeaderStyle>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="chkIsArchive" runat="server">
                                                    </asp:CheckBox>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                        </Columns>
                                        <PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6" Mode="NumericPages">
                                        </PagerStyle>
                                    </asp:DataGrid></td>
                            </tr>
                            <tr>
                                <td colspan="6">
                                    <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="宋体"
                                        Font-Size="Smaller">查询结果记录数：</asp:Label>
                                    <asp:TextBox ID="txtRecCount" runat="server" Width="111px"  Font-Names="宋体"
                                        Font-Size="Smaller" ReadOnly="True"></asp:TextBox></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </font>
    </form>
</body>
</html>
