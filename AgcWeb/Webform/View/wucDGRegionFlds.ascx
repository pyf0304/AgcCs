<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucDGRegionFlds.ascx.cs"
    Inherits="AGC.Webform.wucDGRegionFlds" %>

<table id="tabwucDGRegionFlds" style="width: 400px; ">
    <tr>
        <td>
            <asp:Label ID="lblFldId1" runat="server" Width="100px">表字段</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlFldId1" runat="server" Width="300px"></asp:DropDownList>

        </td>
    </tr>

    <tr>
        <td>
            <asp:Label ID="Label1" runat="server">Out数据</asp:Label></td>
        <td>
            <asp:Label ID="lblDataNodeInfo" CssClass="text-warning" runat="server">数据结点信息</asp:Label>
            <asp:DropDownList ID="ddlDataNodeId" runat="server"
                Width="300px" AutoPostBack="True" OnSelectedIndexChanged="ddlDataNodeId_SelectedIndexChanged">
            </asp:DropDownList></td>
    </tr>

    <tr>
        <td>
            <asp:Label ID="Label2" runat="server">属性名</asp:Label></td>
        <td>
            <asp:TextBox ID="txtDataPropertyName" runat="server" Width="300px"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server">排序表达式</asp:Label></td>
        <td>
            <asp:TextBox ID="txtSortExpression" runat="server" Width="300px"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblColCaption" runat="server">列标题</asp:Label></td>
        <td>
            <asp:TextBox ID="txtColCaption" runat="server" Width="300px"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCtlTypeId" runat="server">控件类型</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlCtlTypeId" runat="server"
                Width="300px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDgFuncTypeId" runat="server">Dg功能类型</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlDgFuncTypeId" runat="server"
                Width="300px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="chkIsFuncFld" runat="server"
                Text="是否功能字段"></asp:CheckBox></td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="chkIsVisible" runat="server"
                Text="是否显示"></asp:CheckBox></td>

    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="chkIsNeedSort" runat="server"
                Text="是否需要排序"></asp:CheckBox></td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="chkIsTransToChkBox" runat="server"
                Text="是否转换成CheckBox"></asp:CheckBox></td>

    </tr>
    <tr>
        <td>
            <asp:Label ID="lblSeqNum" runat="server">序号</asp:Label></td>
        <td>
            <asp:TextBox ID="txtSeqNum" runat="server" Width="300px"></asp:TextBox><asp:CompareValidator ID="ComValid_SeqNum"
                runat="server" EnableClientScript="false" Operator="DataTypeCheck"
                Type="Integer" ControlToValidate="txtSeqNum" ErrorMessage="请输入整型数值!"></asp:CompareValidator></td>

    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server">说明</asp:Label></td>
        <td>

            <asp:TextBox ID="txtMemo" runat="server"
                Width="300px" Height="72px" TextMode="MultiLine"></asp:TextBox></td>
    </tr>
</table>

