<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucCMFuncPara.ascx.cs" Inherits="AGC.Webform.wucCMFuncPara" %>

<table id="tabwucFuncPara4Code" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCMFuncParaId" runat="server" CssClass="col-form-label text-right">参数Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCMFuncParaId" runat="server" Width="400px" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblParaName" runat="server" CssClass="col-form-label text-right">参数名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtParaName" runat="server" Width="400px" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblParaCnName" runat="server" CssClass="col-form-label text-right">参数中文名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtParaCnName" runat="server" Width="400px" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr id="trCMFunctionId" runat="server" visible="false">
        <td class="NameTD">
            <asp:Label ID="lblCMFunctionId" runat="server" CssClass="col-form-label text-right">函数Id4Code</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlCMFunctionId" runat="server" Width="400px" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataTypeId" runat="server" CssClass="col-form-label text-right">参数类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlDataTypeId" runat="server" Width="400px" AutoPostBack="true" class="form-control-sm" OnSelectedIndexChanged="ddlDataTypeId_SelectedIndexChanged"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr id="trParameterType" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblParameterType" runat="server" CssClass="col-form-label text-right">定制类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtParameterType" runat="server" Width="400px" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr id="trParameterTypeFullName" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblParameterTypeFullName" runat="server" CssClass="col-form-label text-right">定制类型全名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtParameterTypeFullName" runat="server" Width="400px" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="chkIsByRef" runat="server" Text="是否引用型参数" CssClass="Check_Defa"></asp:CheckBox>
        </td>        
        <td></td>
        <td></td>
    </tr>
   
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" Width="400px" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>

