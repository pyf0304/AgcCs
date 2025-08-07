<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucCMProject.ascx.cs" Inherits="AGC.Webform.wucCMProject" %>
<table id="tabwucCMProject" name="tabwucCMProject" style="width: 600px; padding: 1px; border: 0px" class="table table-bordered table-hover">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCmPrjId" name="lblCmPrjId" CssClass="col-form-label text-right" Width="90px" Text="CM工程Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCmPrjId" name="txtCmPrjId" CssClass="form-control-sm" Width="600px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCmPrjName" name="lblCmPrjName" CssClass="col-form-label text-right" Width="90px" Text="CM工程名" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCmPrjName" name="txtCmPrjName" CssClass="form-control-sm" Width="600px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" name="lblPrjId" CssClass="col-form-label text-right" Width="90px" Text="工程" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" name="ddlPrjId" CssClass="form-control-sm" Width="600px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblApplicationTypeId" name="lblApplicationTypeId" CssClass="col-form-label text-right" Width="90px" Text="应用" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlApplicationTypeId" name="ddlApplicationTypeId" CssClass="form-control-sm" Width="600px" runat="server" />
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_ApplicationTypeId" name="ComValid_ApplicationTypeId" runat="server" CssClass="ErrMsg"
                ErrorMessage="请输入整型数值!"
                ControlToValidate="ddlApplicationTypeId"
                Type="Integer"
                Operator="DataTypeCheck"
                EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
       <tr>
        <td></td>
        <td>
            <asp:CheckBox ID="chkIsFstLcase" runat="server" Text="是否首字母小写" CssClass="Check_Defa"></asp:CheckBox>
        </td>

        <td></td>
        <td></td>
    </tr>
      <tr>
        <td class="NameTD">
            <asp:Label ID="lblProjectFileName" name="lblProjectFileName" CssClass="col-form-label text-right" Width="90px" Text="工程文件名" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtProjectFileName" name="txtProjectFileName" CssClass="form-control-sm" Width="600px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr id="trIsRefresh4RelaView">
        <td class="text-left" colspan="2">
            <asp:CheckBox ID="chkIsRefresh4RelaView" name="chkIsRefresh4RelaView" CssClass="form-control" Width="250px" Text="是否刷新相关视图" runat="server"></asp:CheckBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" name="txtMemo" CssClass="form-control-sm" Width="600px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
