<%@ Page Language="c#" CodeBehind="wfmFrameTop_EditTab.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.wfmFrameTop_EditTab" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>wfmFrameTop</title>
    
    <style type="text/css">
        .style1
        {
            width: 60px;
        }
        .style2
        {
            width: 60px;
            height: 36px;
        }
        .style3
        {
            height: 36px;
        }
        .style4
        {
            width: 95px;
        }
        .style5
        {
            height: 36px;
            width: 95px;
        }
        .style6
        {
        }
        .style7
        {
            height: 36px;
            width: 780px;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:Label ID="lblPrjDataBaseName" Style="z-index: 114; left: 438px; position: absolute;
        top: 64px" runat="server" ForeColor="#004040" Width="104px" Font-Bold="True">Label</asp:Label>
    <asp:Label ID="Label10" Style="z-index: 113; left: 328px; position: absolute; top: 64px"
        runat="server" CssClass="h6">当前主数据库：</asp:Label>
    <table id="Table1" style="z-index: 105; left: 1px; width: 1000px; position: absolute;
        top: 1px; height: 114px;" cellspacing="0" cellpadding="0" border="0">
        <tr>
            <td colspan="2" style="width: 1000px; height: 92px; background-image: url(../../pic/zdscdm_top.jpg);">
                <div style="width: 994px; position: relative; height: 92px; left: 0px; top: 0px;">
                    <asp:Label ID="hlReturnPrjList" runat="server" Style="z-index: 103; left: 233px;
                        position: absolute; top: 36px; cursor: pointer" Target="_blank" CssClass="h5">表综合维护</asp:Label>
                    <asp:ImageButton ID="ibHelp" runat="server" ImageUrl="~/pic/help.gif" OnClick="ImageButton1_Click"
                        Style="z-index: 105; left: 727px; position: absolute; top: 64px" />
                    <%-- <asp:HyperLink ID="HyperLink1" Style="z-index: 100; left: 564px; position: absolute;
                            top: 17px"  runat="server" NavigateUrl="index.aspx" Target="_parent">退出</asp:HyperLink>--%>
                    <table style="width: 105%; height: 85px;">
                        <tr>
                            <td class="style1">
                                &nbsp;
                            </td>
                            <td class="style4">
                                &nbsp;
                            </td>
                            <td class="style6" colspan="2" align="center">
                                <asp:Menu ID="Menu3" runat="server" Orientation="Horizontal" Width="617px" BackColor="#B5C7DE"
                                    DynamicHorizontalOffset="2" ForeColor="#284E98" StaticSubMenuIndent="10px" CssClass="MyMenu Menu_Main"
                                    DynamicVerticalOffset="1" Font-Size="13px">
                                    <Items>
                                        <asp:MenuItem Text="对象维护" Value="Object">
                                            <asp:MenuItem Text="添加对象" Value="添加对象" NavigateUrl="~/Webform/Table2/wfmPrjObjects_Add.aspx"
                                                Target="main"></asp:MenuItem>
                                            <asp:MenuItem Text="浏览对象" Value="浏览对象" NavigateUrl="~/Webform/Table2/wfmPrjObjects_QUDI_Sim.aspx"
                                                Target="main"></asp:MenuItem>
                                        </asp:MenuItem>
                                        <asp:MenuItem Text="表维护" Value="Table">
                                            <asp:MenuItem Text="新建表" Value="新建表" NavigateUrl="~\Webform\Table2\wfmPrjTab_Add.aspx"
                                                Target="main"></asp:MenuItem>
                                            <asp:MenuItem Text="浏览表" Value="浏览表" NavigateUrl="~/Webform/Table2/wfmPrjTab_QUDI_Sim.aspx"
                                                Target="main"></asp:MenuItem>
                                        </asp:MenuItem>
                                        <asp:MenuItem Text="复制表" Value="ObjField" NavigateUrl="~\Webform\Table2\wfmPrjTab_Copy2.aspx"
                                            Target="main"></asp:MenuItem>
                                        <asp:MenuItem Text="导入数据表" Value="TabField">
                                            <asp:MenuItem Text="导入表" Value="导入表" NavigateUrl="~/Webform/Table2/wfmImportDataBaseFromSQL2.aspx?SqlDsTypeId=01"
                                                Target="main"></asp:MenuItem>
                                            <asp:MenuItem Text="导入视图" Value="导入视图" NavigateUrl="~/Webform/Table2/wfmImportDataBaseFromSQL2.aspx?SqlDsTypeId=02"
                                                Target="main"></asp:MenuItem>
                                        </asp:MenuItem>
                                    </Items>
                                    <StaticSelectedStyle BackColor="#CC66FF" />
                                    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                    <DynamicHoverStyle BackColor="#284E98" ForeColor="#0066FF" CssClass="Menu_Sub" />
                                    <DynamicMenuStyle BackColor="#B5C7DE" CssClass="MyMenu Menu_Sub" />
                                    <DynamicSelectedStyle BackColor="#507CD1" />
                                    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" CssClass="Menu_Sub" />
                                    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                                </asp:Menu>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;
                            </td>
                            <td class="style5">
                                &nbsp;
                            </td>
                            <td class="style7">
                                &nbsp;
                            </td>
                            <td class="style3">
                            </td>
                        </tr>
                        <tr>
                            <td class="style1">
                                &nbsp;
                            </td>
                            <td class="style4">
                                &nbsp;
                                <asp:Label ID="lblUserName"  runat="server" Width="64px" Font-Bold="True"
                                    CssClass="RegionTitleH2">Label</asp:Label>
                            </td>
                            <td class="style6">
                                &nbsp;<asp:Label ID="lblCurrPrjName"  runat="server" Width="144px"
                                    Font-Bold="True" CssClass="RegionTitleH2">Label</asp:Label>
                            </td>
                            <td>
                                <asp:LinkButton ID="lbLogOff"  runat="server" Width="42px" Height="16"
                                    OnClick="lbLogOff_Click"></asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td style="width: 220px">
                <asp:Label ID="Label1"  runat="server" Width="200px" Font-Bold="True"
                    CssClass="RegionTitleH2"></asp:Label>
            </td>
            <td valign="top" align="left" style="width: 700px">
                &nbsp;
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
