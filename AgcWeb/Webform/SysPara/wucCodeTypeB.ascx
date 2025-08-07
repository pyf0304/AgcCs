<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucCodeTypeB.ascx.cs" Inherits="AGC.Webform.wucCodeTypeB" %>



<table id="tabwucCodeType" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCodeTypeId" runat="server" CssClass="col-form-label text-right">代码类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCodeTypeId" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCodeTypeName" runat="server" CssClass="col-form-label text-right">代码类型名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCodeTypeName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label3" runat="server" CssClass="col-form-label text-right">类型简称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCodeTypeSimName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">组名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtGroupName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblProgLangTypeId" runat="server" CssClass="col-form-label text-right">语言类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlProgLangTypeId" runat="server" class="form-control-sm" Width="400px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCodeTypeENName" runat="server" CssClass="col-form-label text-right">代码类型英文名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCodeTypeENName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFrontOrBack" runat="server" CssClass="col-form-label text-right">前台Or后台</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFrontOrBack" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label1" runat="server" CssClass="col-form-label text-right">类名格式</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtClassNameFormat" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsCSharp" runat="server" Text="是否CSharp语言" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsJava" runat="server" Text="是否Java语言" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsJavaScript" runat="server" Text="是否JavaScript语言" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsSilverLight" runat="server" Text="是否SilverLight语言" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsSwift" runat="server" Text="是否Swift语言" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsPubApp4WinWeb" runat="server" Text="是否应用后台" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsWeb" runat="server" Text="是否Web应用" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsAspMvc" runat="server" Text="是否AspMvc应用" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsWin" runat="server" Text="是否Win应用" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsMobileApp" runat="server" Text="是否移动终端应用" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblOrderNum" runat="server" CssClass="col-form-label text-right">序号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtOrderNum" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_OrderNum" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="txtOrderNum"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsDefaultOverride" runat="server" Text="是否默认覆盖" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsDirByTabName" runat="server" Text="是否用表名作为路径" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
