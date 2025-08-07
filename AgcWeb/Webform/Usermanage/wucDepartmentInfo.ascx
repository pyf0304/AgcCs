<%@ Control Language="C#" AutoEventWireup="true" Inherits="AGC.Webform.wucDepartmentInfo" CodeBehind="wucDepartmentInfo.ascx.cs" %>

<link href="../../css/taishweb2.css" rel="stylesheet" />
<table id="tabwucDepartmentInfo" cellspacing="1" cellpadding="1" border="0" style="width: 664px">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDepartmentId" runat="server" CssClass="col-form-label text-right">部门Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDepartmentId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblDepartmentName" runat="server" CssClass="col-form-label text-right">部门名</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDepartmentName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDepartmentAbbrName" runat="server" CssClass="col-form-label text-right">名称缩写</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDepartmentAbbrName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblOrderNum" runat="server" CssClass="col-form-label text-right">排序号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtOrderNum" runat="server" class="form-control-sm"></asp:TextBox>
            <asp:CompareValidator ID="ComValid_OrderNum" runat="server" CssClass="text-warning" ErrorMessage="请输入整型数值!" ControlToValidate="txtOrderNum"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUpDepartmentId" runat="server" CssClass="col-form-label text-right" >所属部门号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUpDepartmentId" runat="server" class="form-control-sm"
                Width="145px">
            </asp:DropDownList>
        </td>
        <td>
            <asp:Label ID="lblDepartmentTypeId" runat="server" CssClass="col-form-label text-right" Width="90px">部门类型ID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDepartmentTypeId" runat="server" class="form-control-sm"
                Width="146px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:CheckBox ID="chkInUse" runat="server" Text="是否使用"></asp:CheckBox>
        </td>
        <td class="ValueTD">&nbsp;</td>
        <td class="NameTD" colspan="2">&nbsp;</td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">备注</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Height="156px"
                TextMode="MultiLine" Width="500px"></asp:TextBox>
        </td>
    </tr>
</table>
