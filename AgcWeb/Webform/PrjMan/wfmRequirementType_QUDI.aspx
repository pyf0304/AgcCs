<%@ Register TagPrefix="uc1" TagName="wucRequirementType" Src="wucRequirementType.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmRequirementType_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmRequirementType_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表RequirementType的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <table id="tabHidden" style="z-index: 116; left: 552px; position: absolute; top: 0px"
            cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
            <tr>
                <td>
                    <asp:Label ID="lblMemo_q" runat="server" Width="32px" Height="10px" Font-Size="XX-Small">备注</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtMemo_q" runat="server" Width="100px" Height="10px" Font-Size="XX-Small"></asp:TextBox></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </table>
        <asp:Label ID="Label1" Style="z-index: 115; left: 8px; position: absolute; top: 8px"
            runat="server" Font-Size="Larger" Font-Names="黑体"  Width="240px"
            ForeColor="Blue">项目功能管理->功能类型维护</asp:Label>
        <asp:Label ID="Label2" Style="z-index: 110; left: 256px; position: absolute; top: 8px"
            runat="server" Width="42px"
            ForeColor="#004040" Font-Bold="True">说明：</asp:Label>
        <asp:Label ID="Label3" Style="z-index: 102; left: 304px; position: absolute; top: 8px"
            runat="server" Width="208px"
            ForeColor="#004040">主要维护项目的功能类型。</asp:Label>
        <table id="tabLayout" style="z-index: 112; left: 488px; width: 280px; position: absolute; top: 40px; height: 200px"
            cellspacing="1" cellpadding="1" width="280" border="4"
            bordercolor="#666666">
            <tr>
                <td valign="top">
                    <asp:Button ID="btnOKUpd" runat="server"   Text="添加"></asp:Button>
                    <asp:Label ID="lblMsg" runat="server" Width="215px"></asp:Label></td>
            </tr>
            <tr>
                <td valign="top">
                    <uc1:wucRequirementType ID="wucRequirementType1" runat="server"></uc1:wucRequirementType>
                </td>
            </tr>
        </table>
        <table id="Table1" style="z-index: 117; left: 0px; position: absolute; top: 40px"
            cellspacing="1" cellpadding="1" width="300" border="4" bordercolor="#003333">
            <tr>
                <td>
                    <asp:Label ID="lblRequirementTypeId_q" runat="server" Width="104px">功能需求类型编号</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtRequirementTypeId_q" runat="server" Width="100px"></asp:TextBox></td>
                <td>
                    <asp:Label ID="lblRequirementType_q" runat="server" Width="90px">功能需求类型</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtRequirementType_q" runat="server" Width="100px"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2"></td>
                <td colspan="2">
                    <asp:Button ID="btnQuery" runat="server"  Text="查询"></asp:Button></td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:DataGrid ID="dgRequirementType" runat="server" Width="463px" Height="154px"
                        AutoGenerateColumns="False" PageSize="5" AllowPaging="True" Font-Names="宋体" Font-Size="Smaller"
                        BackColor="#DADADA">
                        <HeaderStyle BackColor="#3366FF"></HeaderStyle>
                        <Columns>
                            <asp:BoundColumn DataField="RequirementTypeId" HeaderText="功能需求类型编号"></asp:BoundColumn>
                            <asp:BoundColumn DataField="RequirementType" HeaderText="功能需求类型"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Memo" HeaderText="备注"></asp:BoundColumn>
                            <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <PagerStyle Mode="NumericPages"></PagerStyle>
                    </asp:DataGrid></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblRecCount" runat="server" Width="110px" >查询结果记录数：</asp:Label></td>
                <td colspan="2">
                    <asp:TextBox ID="txtRecCount" runat="server" Width="111px"
                        ReadOnly="True"></asp:TextBox></td>
            </tr>
        </table>

    </form>
</body>
</html>
