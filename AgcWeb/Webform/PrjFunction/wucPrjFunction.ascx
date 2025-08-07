<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucPrjFunction.ascx.cs"
    Inherits="AGC.Webform.wucPrjFunction" %>
<table id="tabwucPrjFunction" cellspacing="2" cellpadding="0" width="688" border="0"
    style="width: 688px; height: 463px">
    <tr>
        <td width="60" rowspan="1" style="width: 60px">
            <asp:Label ID="lblFuncId" runat="server"
                Width="56px">函数编号</asp:Label>
        </td>
        <td style="width: 193px">
            <asp:TextBox ID="txtFuncId" runat="server" Width="160px"></asp:TextBox></td>
        <td style="width: 113px">
            <asp:CheckBox ID="chkIsTemplate" runat="server" Text="是否模板函数" 
                ></asp:CheckBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td style="width: 60px" colspan="1" rowspan="1">
            <asp:Label ID="lblFuncName" runat="server"
                Width="55px">函数名称</asp:Label></td>
        <td style="width: 105px" colspan="3">
            
                <asp:TextBox ID="txtFuncName" runat="server" Width="624px"></asp:TextBox></font></td>
    </tr>
    <tr>
        <td style="width: 251px" colspan="2">
            <div style="width: 304px; position: relative; height: 23px">
                <asp:Label ID="lblReturnTypeID" runat="server"
                    Style="z-index: 101; left: 0px; position: absolute; top: 8px">返回类型</asp:Label>
                <asp:DropDownList ID="ddlReturnTypeID" runat="server" Width="223px" Style="z-index: 102;
                    left: 56px; position: absolute; top: 0px">
                </asp:DropDownList>
            </div>
        </td>
        <td style="width: 113px" colspan="2">
            <div style="width: 303px; position: relative; height: 23px">
                <asp:Label ID="lblFuncTypeID" runat="server"
                    Style="z-index: 101; left: 0px; position: absolute; top: 8px">函数类型</asp:Label>
                <asp:DropDownList ID="ddlFuncTypeID" runat="server" Width="222px" Style="z-index: 102;
                    left: 56px; position: absolute; top: 0px">
                </asp:DropDownList>
            </div>
        </td>
    </tr>
    <tr>
        <td style="width: 60px; height: 71px" valign="top">
            <asp:Label ID="lblMemo"  runat="server">功能说明</asp:Label>
        </td>
        <td style="height: 71px" colspan="4">
            <asp:TextBox ID="txtMemo" Width="784px" runat="server" Height="104px" TextMode="MultiLine"></asp:TextBox></td>
    </tr>
    <tr>
        <td style="width: 60px" valign="top" colspan="1" rowspan="1">
            <asp:Label ID="lblFuncCode" runat="server">函数代码</asp:Label></td>
        <td colspan="4">
            <asp:TextBox ID="txtFuncCode" runat="server" Width="784px" TextMode="MultiLine" Height="285px"></asp:TextBox></td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
    <tr>
        <td>
            <asp:Label ID="lblPrjId" runat="server">工程编号</asp:Label></td>
        <td>
            <asp:TextBox ID="txtPrjId" runat="server" Width="216px"></asp:TextBox></td>
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
    </tr>
</table>
