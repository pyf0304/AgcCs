<%@ Page Language="c#" CodeBehind="wfmFieldTab_U.aspx.cs" AutoEventWireup="True" Inherits="AGC.Webform.wfmFieldTab_U" %>

<%@ Register TagPrefix="uc1" TagName="wucFieldTab" Src="wucFieldTab.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表FieldTab的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true">
        </asp:ScriptManager>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label3" Style="z-index: 103; left: 2px; top: 8px"
                        runat="server" Font-Size="Larger" Font-Names="黑体" Width="244px"
                        ForeColor="Blue" CssClass="PageRegionH1">表字段管理->字段修改</asp:Label></td>
                <td>
                    <asp:Label ID="lblPrjIdq" runat="server" Style="z-index: 104; left: 896px; top: 16px">工程ID</asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="100px" Enabled="False"
                        Style="z-index: 105; left: 968px; top: 16px">
                    </asp:DropDownList></td>
                <td>
                    <asp:Label ID="lblAppliedScopeq" runat="server" Style="z-index: 106; left: 920px; top: 48px"
                        CssClass="text-secondary">适用范围</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtAppliedScopeq" runat="server" Width="100px" Style="z-index: 107; left: 904px; top: 72px"></asp:TextBox></td>

            </tr>
        </table>
               

        <table id="tabLayout" style="z-index: 109; left: 8px; width: 368px; position: absolute; top: 48px; height: 200px"
            bordercolor="#666666" cellspacing="0" cellpadding="0"
            width="368" border="0" runat="server">
            <tr>
                <td style="height: 219px" valign="top" rowspan="3">
                    <uc1:wucFieldTab ID="wucFieldTab1" runat="server"></uc1:wucFieldTab>
                </td>
                <td style="height: 8px" valign="top">
                    <asp:LinkButton ID="lbReturn" runat="server" OnClick="lbReturn_Click">关闭</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td valign="top" style="height: 16px">
                    <asp:Button ID="btnOKUpd" runat="server"   Text="添加" OnClick="btnOKUpd_Click"></asp:Button></td>
            </tr>
            <tr>
                <td valign="top">
                    <asp:Label ID="lblMsg" runat="server" Width="184px" CssClass="text-warning"></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
