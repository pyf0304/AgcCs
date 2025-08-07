<%@ Page Language="c#" CodeBehind="wfmFunctionType_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmFunctionType_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucFunctionType" Src="wucFunctionType.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表FunctionType的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <asp:Label ID="Label3" Style="z-index: 114; left: 8px; position: absolute; top: 8px"
            runat="server" Font-Size="Larger" Font-Names="黑体" Width="240px"
            ForeColor="Blue">工程函数管理->函数类型维护</asp:Label>
        <asp:Label ID="Label2" Style="z-index: 103; left: 256px; position: absolute; top: 8px"
            runat="server" Width="42px"
            ForeColor="#004040" Font-Bold="True">说明：</asp:Label>
        <asp:Label ID="Label4" Style="z-index: 101; left: 304px; position: absolute; top: 8px"
            runat="server" Height="32px" Width="464px"
            ForeColor="#004040">函数类型维护主要用来维护在程序设计过程所涉及函数的类型，包括：工程私有函数、公共函数、模板函数，从而说明函数的功能特点。</asp:Label>
        <table id="tabLayout" style="z-index: 111; left: 488px; width: 328px; position: absolute; top: 48px; height: 200px"
            cellspacing="1" cellpadding="1" width="328" border="4"
            bordercolor="#003333" bordercolordark="#666633">
            <tr>
                <td valign="top">
                    <asp:Button ID="btnOKUpd" runat="server"   Text="添加"></asp:Button>
                    <asp:Label ID="lblMsg" runat="server" Width="215px"></asp:Label></td>
            </tr>
            <tr>
                <td valign="top" colspan="" rowspan="">
                    <uc1:wucFunctionType ID="wucFunctionType1" runat="server"></uc1:wucFunctionType>
                </td>
            </tr>
        </table>
        <table id="tabQuery" style="z-index: 115; left: 8px; position: absolute; top: 48px"
            cellspacing="1" cellpadding="1" width="300" border="4" bordercolor="#666666">
            <tr>
                <td>
                    <asp:Label ID="lblFuncTypeIDq" runat="server" >函数类型ID</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtFuncTypeIDq" runat="server" Width="100px"></asp:TextBox></td>
                <td>
                    <asp:Label ID="lblFuncTypeNMq" runat="server" >函数类型名称</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtFuncTypeNMq" runat="server" Width="100px"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2"></td>
                <td colspan="2">
                    <asp:Button ID="btnQuery" runat="server"  Text="查询"></asp:Button></td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:DataGrid ID="dgFunctionType" runat="server" Width="463px" Height="154px" AutoGenerateColumns="False"
                        PageSize="5" AllowPaging="True" Font-Names="宋体" Font-Size="Smaller" BorderColor="White"
                        BorderStyle="Ridge" BorderWidth="2px" CellSpacing="1" BackColor="White" CellPadding="3"
                        GridLines="None">
                        <FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
                        <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
                        <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
                        <Columns>
                            <asp:BoundColumn Visible="False" DataField="FuncTypeId" HeaderText="函数类型ID"></asp:BoundColumn>
                            <asp:BoundColumn DataField="FuncTypeName" HeaderText="函数类型名称"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Memo" HeaderText="说明"></asp:BoundColumn>
                            <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
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
            </tr>
        </table>
    </form>
</body>
</html>
