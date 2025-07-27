<%@ Page Language="c#" CodeBehind="wfmPrjFunction_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmPrjFunction_QUDI" ValidateRequest="false" EnableEventValidation="false" ResponseEncoding="utf-8" %>

<%@ Register TagPrefix="uc1" TagName="wucPrjFunction" Src="wucPrjFunction.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表PrjFunction的查询、修改、删除、添加记录</title>
    
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

        <asp:Label ID="Label3" Style="z-index: 102; left: 8px; position: absolute; top: 8px"            runat="server" CssClass="h5">工程函数管理->工程函数维护</asp:Label>
        <table id="tabHidden" style="z-index: 103; left: 896px; position: absolute; top: 0px"            cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
            <tr>
                <td>
                    <asp:Label ID="lblFuncIdq" runat="server" Width="70px">函数编号</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtFuncIdq" runat="server" Width="100px"></asp:TextBox></td>
                <td></td>
                <td></td>
            </tr>
        </table>
        <asp:Label ID="Label4" Style="z-index: 101; left: 496px; position: absolute; top: 8px"
            runat="server" Width="353px" Height="42px" CssClass="MemoStyle1">工程函数维护主要用来维护在程序设计过程所涉及的函数以及他们的功能、步骤、代码，对编码者有一定的借鉴作用。</asp:Label>
        <table id="tabLayout" style="z-index: 104; left: 0px; width: 192px; position: absolute; top: 40px; height: 120px"
            cellspacing="0" cellpadding="0" width="300" border="0"
            runat="server">
            <tr>
                <td>
                    <table id="tabQuery" style="width: 408px; height: 294px" bordercolor="#333333" cellspacing="1"
                        cellpadding="1" width="408" border="1" runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="lblFuncNameq" runat="server" Width="70px">函数名称</asp:Label>
                                <asp:TextBox ID="txtFuncName" runat="server"
                                    Width="136px"></asp:TextBox></td>
                            <td>
                                <asp:Label ID="lblReturnTypeIDq" runat="server" Width="70px">返回值类型</asp:Label><asp:DropDownList ID="ddlReturnTypeIDq" runat="server"
                                    Width="192px">
                                </asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblFuncTypeIDq" runat="server" Width="70px">函数类型</asp:Label><asp:DropDownList ID="ddlFuncTypeIDq" runat="server"
                                    Width="144px">
                                </asp:DropDownList></td>
                            <td>
                                <asp:Label ID="lblIsTemplateq" runat="server" >是否模板函数</asp:Label><asp:TextBox ID="txtIsTemplateq" runat="server"
                                    Width="176px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblPrjIdq" runat="server" Width="70px">工程编号</asp:Label><asp:TextBox ID="txtPrjIdq" runat="server" Width="136px"
                                    Enabled="False"></asp:TextBox></td>
                            <td>
                                <asp:Button ID="btnQuery" runat="server" CssClass="btn btn-outline-info btn-sm" Text="查询"></asp:Button></td>
                        </tr>
                        <tr>
                            <td colspan="2"></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <div style="width: 808px; position: relative; height: 35px">
                                    <asp:LinkButton ID="lbAddNewFunction" Style="z-index: 101; left: 536px; position: absolute; top: 8px"
                                        runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="lbAddNewFunction_Click">添加新函数</asp:LinkButton>
                                    <asp:Label ID="Label1" Style="z-index: 102; left: 8px; position: absolute; top: 8px"
                                        runat="server" CssClass="h6">工程函数列表</asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2"></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:DataGrid ID="dgPrjFunction" runat="server" Width="824px" Height="154px" Font-Names="宋体"
                                    Font-Size="Smaller" AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True"
                                    PageSize="15" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White"
                                    CellPadding="3" GridLines="Horizontal">
                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                    <Columns>
                                        <asp:BoundColumn Visible="False" DataField="FuncId" HeaderText="函数编号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FuncName" SortExpression="FuncName" HeaderText="函数名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="RegionTypeName" SortExpression="RegionTypeName"
                                            HeaderText="返回值类型"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FuncTypeName" SortExpression="FuncTypeName"
                                            HeaderText="函数类型"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsTemplate" SortExpression="IsTemplate" HeaderText="是否模板函数"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="PrjId" HeaderText="工程编号"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="FuncCode" HeaderText="函数代码"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="Memo" HeaderText="说明"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserId" SortExpression="UserId" HeaderText="建立者"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundColumn>
                                        <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
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
                                    Font-Size="Smaller" ReadOnly="True"></asp:TextBox></td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td style="width: 1px"></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td style="width: 1px"></td>
            </tr>
            <tr>
                <td>
                    <table id="tabEdit" style="width: 816px; height: 85px" bordercolor="#666666" cellspacing="0"
                        cellpadding="0" width="816" border="1" runat="server">
                        <tr>
                            <td valign="top">
                                <div style="width: 824px; position: relative; height: 32px">
                                    <asp:Button ID="btnOKUpd" Style="z-index: 100; left: 616px; position: absolute; top: 8px"
                                        runat="server"   Text="添加"></asp:Button>
                                    <asp:Label ID="lblMsg" Style="z-index: 101; left: 312px; position: absolute; top: 16px"
                                        runat="server" Width="144px" CssClass="text-warning"></asp:Label>
                                    <asp:LinkButton ID="lbDispFieldList" Style="z-index: 103; left: 704px; position: absolute; top: 16px"
                                        runat="server">显示字段列表</asp:LinkButton>
                                    <asp:Label ID="Label2" Style="z-index: 104; left: 8px; position: absolute; top: 8px"
                                        runat="server" CssClass="h6">工程函数编辑</asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <uc1:wucPrjFunction ID="wucPrjFunction1" runat="server"></uc1:wucPrjFunction>
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td style="width: 1px"></td>
            </tr>
        </table>
        <asp:Label ID="lblMsg2" runat="server" Width="232px"
            Style="z-index: 105; left: 240px; position: absolute; top: 8px"
            CssClass="text-warning"></asp:Label>
    </form>
</body>
</html>
