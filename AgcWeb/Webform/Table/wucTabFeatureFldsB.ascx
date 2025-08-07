<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucTabFeatureFldsB.ascx.cs" Inherits="AGC.Webform.wucTabFeatureFldsB" %>

<table id="tabwucTabFeatureFlds" style="width: 600px; padding: 1px;" border="0">

   <%-- <tr id="trHidden" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblTabId" runat="server" CssClass="col-form-label text-right">表ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlTabId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>--%>
   <%-- <tr id="trTabFeatureId" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblFeatureId" runat="server" CssClass="col-form-label text-right">表功能</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlTabFeatureId" runat="server" class="form-control-sm" AutoPostBack="True" OnSelectedIndexChanged="ddlTabFeatureId_SelectedIndexChanged"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>--%>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFldId" runat="server" CssClass="col-form-label text-right">字段</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFldId" runat="server" class="form-control-sm" AutoPostBack="True" OnSelectedIndexChanged="ddlFldId_SelectedIndexChanged"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFieldTypeId" runat="server" CssClass="col-form-label text-right">字段类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFieldTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr id="trValueGivingModeId" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblValueGivingModeId" CssClass="text-secondary" Width="90px" Text="给值方式" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlValueGivingModeId" Width="200px"  runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlValueGivingModeId_SelectedIndexChanged" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr id="trFuncName" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblFuncName" CssClass="text-secondary" Width="90px" Text="函数名" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncName" class="ValueControl" Width="200px"  runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr id="trDefaultValue" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblDefaultValue" runat="server" CssClass="col-form-label text-right">DefaValue</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDefaultValue" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblOrderNum" runat="server" CssClass="col-form-label text-right">序号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtOrderNum" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_OrderNum" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="txtOrderNum"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td>
            <asp:CheckBox ID="chkInUse" runat="server" Text="是否在用" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>

        <td></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
