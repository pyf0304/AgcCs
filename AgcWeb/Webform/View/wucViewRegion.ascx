<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewRegion.ascx.cs"
    Inherits="AGC.Webform.wucViewRegion" %>

<table id="tabwucViewRegion" cellspacing="1" cellpadding="1" width="584" border="0"
    style="width: 584px; height: 327px">
    <tr>
        <td style="width: 102px" class="NameTD">
            <asp:Label ID="lblRegionName" runat="server"
                CssClass="col-form-label text-right">区域名称</asp:Label></td>
        <td style="width: 179px">
            <asp:TextBox ID="txtRegionName" runat="server"
                Width="160px" CssClass="ValueTD"></asp:TextBox></td>
        <td style="width: 89px"></td>
        <td></td>
    </tr>
    <tr>
        <td style="width: 102px" class="NameTD">
            <asp:Label ID="lblRegionTypeId" runat="server"
                CssClass="col-form-label text-right">区域类型</asp:Label></td>
        <td style="width: 179px">
            <asp:DropDownList ID="ddlRegionTypeId" runat="server"
                Width="160px" CssClass="ValueTD">
            </asp:DropDownList></td>
        <td colspan="2" rowspan="1">

            <asp:CheckBox ID="chkIsUseCtrl" runat="server"
                Text="是否使用控件" CssClass="ValueTD"></asp:CheckBox></td>
    </tr>
    <tr>
        <td style="width: 102px" class="NameTD">

            <asp:Label ID="lblRegionFunction" runat="server"
                CssClass="col-form-label text-right">区域功能</asp:Label></td>
        <td colspan="3">

            <asp:TextBox ID="txtRegionFunction" runat="server"
                Width="432px" TextMode="MultiLine" Height="40px" CssClass="ValueTD"></asp:TextBox></td>
    </tr>
   
    <tr>
        <td style="width: 102px" class="NameTD">
            <asp:Label ID="Label1" runat="server" CssClass="col-form-label text-right">In/Out类型</asp:Label></td>
        <td style="width: 179px">
            <asp:DropDownList ID="ddlInOutTypeId" runat="server"
                Width="160px" AutoPostBack="True" CssClass="ValueTD"
                OnSelectedIndexChanged="ddlInSqlDsTypeId_SelectedIndexChanged1">
            </asp:DropDownList></td>
        <td class="NameTD" style="width: 89px">
            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">数据表</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlTabId" runat="server"
                Width="160px" CssClass="ValueTD">
            </asp:DropDownList></td>
    </tr>
     <tr>
        <td style="width: 102px" class="NameTD">

            &nbsp;</td>
        <td style="width: 179px">
            &nbsp;</td>
        <td class="NameTD" style="width: 89px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 102px" class="NameTD">
            <asp:Label ID="lblColNum" runat="server"
                CssClass="col-form-label text-right">列　　数</asp:Label></td>
        <td style="width: 179px">
            <asp:TextBox ID="txtColNum" runat="server"
                Width="160px" CssClass="ValueTD"></asp:TextBox><asp:CompareValidator ID="ComValid_ColNum"
                    runat="server" ErrorMessage="请输入整型数值!"
                    ControlToValidate="txtColNum" Type="Integer" Operator="DataTypeCheck" EnableClientScript="false" CssClass="text-warning"></asp:CompareValidator></td>
        <td style="width: 89px"></td>
        <td></td>
    </tr>
    <tr>
        <td style="width: 102px" class="NameTD">
            <asp:Label ID="lblHeight" runat="server"
                CssClass="col-form-label text-right">区域高度</asp:Label></td>
        <td style="width: 179px">
            <asp:TextBox ID="txtHeight" runat="server"
                Width="160px" CssClass="ValueTD"></asp:TextBox><asp:CompareValidator ID="ComValid_Height"
                    runat="server" ErrorMessage="请输入整型数值!"
                    ControlToValidate="txtHeight" Type="Integer" Operator="DataTypeCheck" EnableClientScript="false" CssClass="text-warning"></asp:CompareValidator></td>
        <td class="NameTD" style="width: 89px">
            <asp:Label ID="lblWidth" runat="server"
                CssClass="col-form-label text-right">区域宽度</asp:Label></td>
        <td>
            <asp:TextBox ID="txtWidth" runat="server"
                Width="160px" CssClass="ValueTD"></asp:TextBox><asp:CompareValidator ID="ComValid_Width"
                    runat="server" ErrorMessage="请输入整型数值!"
                    ControlToValidate="txtWidth" Type="Integer" Operator="DataTypeCheck" EnableClientScript="false" CssClass="text-warning"></asp:CompareValidator></td>
    </tr>
    <tr>
        <td style="width: 102px" class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说　　明</asp:Label></td>
        <td colspan="3">

            <asp:TextBox ID="txtMemo" runat="server"
                Width="431px" Height="48px" CssClass="ValueTD"></asp:TextBox></td>
    </tr>
    <tr>
        <td style="width: 102px"></td>
        <td style="width: 179px"></td>
        <td style="width: 89px"></td>
        <td></td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
    <tr>
        <td>
            <asp:Label ID="lblViewId" runat="server">界面ID</asp:Label></td>
        <td>

            <asp:DropDownList ID="ddlViewId" runat="server"
                Width="158px">
            </asp:DropDownList>

        </td>
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
