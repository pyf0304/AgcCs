<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucExcelExportRegionFlds.ascx.cs"
    Inherits="AGC.Webform.wucExcelExportRegionFlds" %>
<link href="../../Content/bootstrap.css" rel="stylesheet" />
<table id="tabwucExcelExportRegionFlds" style="width: 400px; height: 104px">
    <tr>
        <td class="text-right">
            <asp:Label ID="lblTabFldId" CssClass="mr-1"  Width="90px" runat="server">表字段</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlFldId" runat="server"
                Width="300px">
            </asp:DropDownList>
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
            <asp:Label ID="Label2" runat="server">属性名</asp:Label></td>
        <td>
            <asp:TextBox ID="txtDataPropertyName" runat="server" Width="300px"></asp:TextBox></td>
    </tr>

   
    <tr>
        <td class="text-right">
            <asp:Label ID="lblColCaption" CssClass="mr-1"  runat="server">列标题</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtColCaption" Width="300px" runat="server"></asp:TextBox>
        </td>

    </tr>
     <tr>
        <td class="text-right">
            <asp:Label ID="lblSeqNum" CssClass="mr-1"  runat="server">列序号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtSeqNum" Width="300px" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_SeqNum" runat="server"
                ErrorMessage="请输入整型数值!" ControlToValidate="txtSeqNum" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="false"></asp:CompareValidator></td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="lblMemo" CssClass="mr-1" runat="server">说明</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server"
                Width="300px" Height="120px" TextMode="MultiLine"></asp:TextBox>
        </td>

    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
    <tr>
        <td></td>
        <td>
            <asp:TextBox ID="txtTabFldId" runat="server"></asp:TextBox></td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
    </tr>
</table>
