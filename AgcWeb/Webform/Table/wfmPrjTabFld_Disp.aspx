<%@ Page Language="c#" CodeBehind="wfmPrjTabFld_Disp.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmPrjTabFld_Disp" %>

<%@ Register TagPrefix="uc1" TagName="wucPrjTabFld" Src="wucPrjTabFld.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表PrjTabFld的查询、修改、删除、添加记录</title>
    

    <script language="javascript" type="text/javascript">
		<!--
    function radioClick() {
        if (document.Form1.RadioName != null) {
            for (i = 0; i < document.Form1.RadioName.length; i++) {
                if (document.Form1.RadioName[i].checked == true) {
                    document.Form1.rd.value = document.Form1.RadioName[i].value;
                    //document.getElementById("TextBox1").value = document.Form1.rd.value;
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
        &nbsp;
        <input id="rd" type="hidden" runat="server" style="z-index: 108; left: 928px; width: 16px; position: absolute; top: 96px; height: 22px"
            size="1">
        <input style="display: none; z-index: 109; left: 944px; position: absolute; top: 88px"
            type="radio" name="RadioName">
        <table id="TabLayout" style="z-index: 110; left: 4px; width: 564px; position: absolute; top: 2px">
            <tr>
                <td>
                    <div style="left: 0px; width: 791px; position: relative; top: 0px; height: 53px">
                        <asp:Label ID="Label3" Style="z-index: 100; left: 5px; position: absolute; top: 6px"
                            runat="server" Width="200px" CssClass="h5">表字段管理->查看表字段</asp:Label>
                        <asp:Label ID="lblCurrTabName" Style="z-index: 101; left: 9px; position: absolute; top: 35px"
                            runat="server" Width="440px" Font-Bold="True" CssClass="RegionTitleH2">Label</asp:Label>
                        <asp:LinkButton ID="lbReturn" Style="z-index: 102; left: 493px; position: absolute; top: 34px"
                            runat="server" Width="32px" OnClick="lbReturn_Click">返回</asp:LinkButton>
                        <asp:Label ID="Label4" Style="z-index: 103; left: 329px; position: absolute; top: 7px"
                            runat="server" Width="464px" CssClass="MemoStyle1">项目表主要用来维护管理项目相关的表，该界面主要查看项目表中的字段。</asp:Label>
                    </div>
                </td>
                <td></td>
                <td style="width: 3px"></td>
            </tr>
            <tr>
                <td>
                    <table id="Table1" style="width: 672px; height: 59px" cellspacing="1" cellpadding="1"
                        width="672" border="1">
                        <tr>
                            <td style="width: 108px; height: 18px">
                                <asp:Label ID="lblTabIdq" runat="server" CssClass="text-secondary">表名</asp:Label></td>
                            <td style="height: 18px">
                                <asp:DropDownList ID="ddlTabIdq" runat="server" Width="208px" Enabled="False">
                                </asp:DropDownList></td>
                            <td style="height: 18px">
                                <asp:Label ID="Label1" runat="server"  CssClass="text-secondary">是否主关键字</asp:Label></td>
                            <td style="height: 18px; width: 205px;">
                                <asp:DropDownList ID="ddlIsPrimaryq" runat="server" Width="171px">
                                </asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td style="width: 108px">
                                <asp:Label ID="lblPrimaryTypeIdq" runat="server"  CssClass="text-secondary">主关键字类型</asp:Label></td>
                            <td>
                                <asp:DropDownList ID="ddlPrimaryTypeIdq" runat="server" Width="208px">
                                </asp:DropDownList></td>
                            <td></td>
                            <td style="width: 205px">
                                <asp:Button ID="btnQuery" runat="server" Width="78px" Text="查询" OnClick="btnQuery_Click"></asp:Button></td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td style="width: 3px"></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td style="width: 3px"></td>
            </tr>
            <tr>
                <td>
                    <table id="Table2" cellspacing="0" cellpadding="0" width="300" border="0">
                        <tr>
                            <td colspan="2">
                                <div style="width: 680px; position: relative; height: 32px">
                                    <asp:Button ID="btnExportExcel" Style="z-index: 106; left: 592px; position: absolute; top: 8px"
                                        runat="server"   Text="导出Excel" OnClick="btnExportExcel_Click"></asp:Button>
                                    <asp:Label ID="Label2" Style="z-index: 107; left: 8px; position: absolute; top: 8px"
                                        runat="server" CssClass="h6">表字段列表</asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2"></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:DataGrid ID="dgPrjTabFld1" runat="server" Width="784px" Height="154px" Font-Names="宋体"
                                    Font-Size="Smaller" AllowPaging="True" PageSize="15" AutoGenerateColumns="False"
                                    AllowSorting="True" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
                                    BackColor="White" CellPadding="3" GridLines="Horizontal"
                                    OnItemCreated="dgPrjTabFld_ItemCreated"
                                    OnItemDataBound="dgPrjTabFld_ItemDataBound"
                                    OnPageIndexChanged="dgPrjTabFld_PageIndexChanged"
                                    OnSortCommand="dgPrjTabFld_SortCommand">
                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                    <Columns>
                                        <asp:TemplateColumn>
                                            <HeaderTemplate>
                                                选择
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <input type="radio" onclick="radioClick()" name="RadioName" value='<%# DataBinder.Eval(Container.DataItem, "MId")%>'>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="SequenceNumber" SortExpression="SequenceNumber" HeaderText="序号"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="MId" HeaderText="编号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Caption" SortExpression="Caption" HeaderText="字段标题"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="DataTypeName" SortExpression="DataTypeName" HeaderText="类型"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FldLength" SortExpression="FldLength" HeaderText="长度"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsTabNullable" SortExpression="IsTabNullable" HeaderText="可空"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FieldTypeName" HeaderText="字段类型"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrimaryTypeName" SortExpression="PrimaryTypeName" HeaderText="主关键字类型"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsTabForeignKey" SortExpression="IsTabForeignKey" HeaderText="外键"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsParentObj" SortExpression="IsParentObj" HeaderText="父对象ID"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="Memo" HeaderText="说明"></asp:BoundColumn>
                                        <asp:ButtonColumn Visible="False" Text="修改" HeaderText="功能列" CommandName="Update"></asp:ButtonColumn>
                                        <asp:TemplateColumn Visible="False" HeaderText="功能列">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="ForeignTabName" SortExpression="ForeignTabName" HeaderText="外键表"></asp:BoundColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblRecCount" runat="server" Width="110px" Font-Names="宋体"
                                    Font-Size="Smaller">查询结果记录数：</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtRecCount" runat="server" Width="111px" Font-Names="宋体"
                                    Font-Size="Smaller" ReadOnly="True"></asp:TextBox>
                                <asp:Label ID="lblMsg2" runat="server" Width="85px" ForeColor="Red" CssClass="text-warning"></asp:Label></td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td style="width: 3px"></td>
            </tr>
        </table>
    </form>
</body>
</html>
