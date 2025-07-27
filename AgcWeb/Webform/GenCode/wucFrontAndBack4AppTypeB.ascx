<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFrontAndBack4AppTypeB.ascx.cs" Inherits="AGC.Webform.wucFrontAndBack4AppTypeB" %>

<table id="tabwucFrontAndBack4AppType" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblAppTypeId4Front" runat="server" CssClass="col-form-label text-right">应用类型Id4Front</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlAppTypeId4Front" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_AppTypeId4Front" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="ddlAppTypeId4Front"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblAppTypeId4Back" runat="server" CssClass="col-form-label text-right">应用类型Id4Back</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlAppTypeId4Back" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_AppTypeId4Back" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="ddlAppTypeId4Back"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
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
