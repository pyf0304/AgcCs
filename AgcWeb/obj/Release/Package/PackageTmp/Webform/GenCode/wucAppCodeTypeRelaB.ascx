<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucAppCodeTypeRelaB.ascx.cs" Inherits="AGC.Webform.wucAppCodeTypeRelaB" %>

<table id="tabwucAppCodeTypeRela" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblApplicationTypeId" runat="server" CssClass="col-form-label text-right">应用程序类型ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlApplicationTypeId" runat="server" class="form-control-sm" AutoPostBack="True" OnSelectedIndexChanged="ddlApplicationTypeId_SelectedIndexChanged"></asp:DropDownList>
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
            <asp:Label ID="lblCodeTypeId" runat="server" CssClass="col-form-label text-right">代码类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlCodeTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
     
          <tr>
        <td class="NameTD">
            <asp:Label ID="Label3" runat="server" CssClass="col-form-label text-right">表类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlTabMainTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsVisible" runat="server" Text="是否显示" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
      <tr>
        <td>
            <asp:CheckBox ID="chkIsInGroupGeneCode" runat="server" Text="组生成代码?" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
   <%--  <tr>
        <td class="NameTD">
            <asp:Label ID="Label1" runat="server" CssClass="col-form-label text-right">组名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtGroupName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td>

        </td>
        <td></td>
    </tr>--%>
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
