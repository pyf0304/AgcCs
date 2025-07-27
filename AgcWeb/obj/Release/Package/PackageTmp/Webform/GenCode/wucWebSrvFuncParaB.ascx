<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucWebSrvFuncParaB.ascx.cs" Inherits="AGC.Webform.wucWebSrvFuncParaB" %>

<table id="tabwucWebSrvFuncPara" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblWebSrvFuncParaId" runat="server" CssClass="col-form-label text-right">函数参数Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtWebSrvFuncParaId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblWebSrvFunctionId" runat="server" CssClass="col-form-label text-right">函数Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtWebSrvFunctionId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataTypeId" runat="server" CssClass="col-form-label text-right">数据类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlDataTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblParaName" runat="server" CssClass="col-form-label text-right">参数名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtParaName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblParaCnName" runat="server" CssClass="col-form-label text-right">参数中文名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtParaCnName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblParameterType" runat="server" CssClass="col-form-label text-right">参数类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtParameterType" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsByRef" runat="server" Text="是否引用型参数" CssClass="Check_Defa"></asp:CheckBox>
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
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
