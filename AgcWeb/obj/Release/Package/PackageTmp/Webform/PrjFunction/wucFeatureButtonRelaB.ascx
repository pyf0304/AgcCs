<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFeatureButtonRelaB.ascx.cs" Inherits="AGC.Webform.wucFeatureButtonRelaB" %>

<table id="tabwucFeatureButtonRela" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblApplicationTypeId" runat="server" CssClass="col-form-label text-right">应用程序类型ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlApplicationTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_ApplicationTypeId" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="ddlApplicationTypeId"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFeatureId" runat="server" CssClass="col-form-label text-right">功能Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFeatureId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblButtonId" runat="server" CssClass="col-form-label text-right">按钮Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlButtonId" runat="server" class="form-control-sm"></asp:DropDownList>
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
