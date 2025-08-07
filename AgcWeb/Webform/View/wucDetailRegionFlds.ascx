<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucDetailRegionFlds.ascx.cs"
    Inherits="AGC.Webform.wucDetailRegionFlds" %>
<table id="tabwucEditRegionFlds" border="0" style="width: 400px; height: 168px">
    <tr>
        <td class="text-right" style="width: 100px;">
            <asp:Label ID="lblTabFldId" runat="server">字段</asp:Label>

        </td>
        <td>
                 <asp:DropDownList ID="ddlFldId" runat="server"
                Width="300px">
            </asp:DropDownList>
<%--            <asp:Label ID="lblFldName" Width="300px" runat="server"></asp:Label>--%>
        </td>

    </tr>
        <tr>
        <td>
            <asp:Label ID="Label1" runat="server">Out数据</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlDataNodeId" runat="server"
                Width="300px" AutoPostBack="True" OnSelectedIndexChanged="ddlDataNodeId_SelectedIndexChanged">
            </asp:DropDownList></td>
    </tr>
    
        <tr>
        <td>
            <asp:Label ID="Label5" runat="server">属性名</asp:Label></td>
        <td>
            <asp:TextBox ID="txtDataPropertyName" runat="server" Width="300px"></asp:TextBox></td>
    </tr>

    <tr>
        <td class="text-right">
            <asp:Label ID="Label2" runat="server" CssClass="col-form-label-sm">标签标题</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtLabelCaption" runat="server" CssClass="form-control-sm" Width="300px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="lblCtlTypeId" runat="server">控件类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlCtlTypeId" runat="server"
                Width="300px">
            </asp:DropDownList>
        </td>
    </tr>

    <tr>
        <td class="text-right">

            <asp:Label ID="Label3" runat="server" CssClass="col-form-label-sm">跨列</asp:Label></td>
        <td>
            <asp:TextBox ID="txtColSpan" runat="server" CssClass="form-control-sm" Width="300px"></asp:TextBox>

        </td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="Label4" runat="server" CssClass="col-form-label-sm">列宽</asp:Label></td>
        <td>
            <asp:TextBox ID="txtWidth" runat="server" CssClass="form-control-sm" Width="300px"></asp:TextBox></td>

    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="lblSeqNum" runat="server">字段序号</asp:Label></td>
        <td>
            <asp:TextBox ID="txtSeqNum" runat="server"
                Width="300px"></asp:TextBox></td>
        <td>
            <asp:CompareValidator ID="ComValid_SeqNum" runat="server"
                ErrorMessage="请输入整型数值!" ControlToValidate="txtSeqNum" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="false"></asp:CompareValidator></td>

    </tr>

    <tr>
        <td class="text-right">
            <asp:Label ID="lblMemo" runat="server">说明</asp:Label></td>
        <td colspan="1">
            <asp:TextBox ID="txtMemo" runat="server"
                Width="300px" Height="66px" TextMode="MultiLine"></asp:TextBox></td>
    </tr>

</table>
<asp:HiddenField ID="hidTabFldId" runat="server" />
