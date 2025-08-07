<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFunction4CodeB.ascx.cs" Inherits="AGC.Webform.wucFunction4CodeB" %>

<table id="tabwucFunction4Code" style="width: 840px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncId4Code" runat="server" CssClass="col-form-label text-right">函数Id4Code</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncId4Code" runat="server" class="form-control-sm" Width="600px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncName4Code" runat="server" CssClass="col-form-label text-right">函数名4Code</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncName4Code" runat="server" class="form-control-sm" Width="600px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncCHName4Code" runat="server" CssClass="col-form-label text-right">函数中文名4Code</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncCHName4Code" runat="server" class="form-control-sm" Width="600px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>

    <tr id="trApplicationTypeId" runat="server">
        <td class="NameTD">
            <asp:Label ID="Label1" runat="server" CssClass="col-form-label text-right">应用类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlApplicationTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblReturnTypeID" runat="server" CssClass="col-form-label text-right">返回类型ID</asp:Label>
        </td>
        <td class="ValueTD">
            <div class="btn-group" role="group" aria-label="Basic example">
                <asp:DropDownList ID="ddlReturnTypeID" runat="server" class="form-control-sm" AutoPostBack="true" OnSelectedIndexChanged="ddlReturnTypeID_SelectedIndexChanged"></asp:DropDownList>
                <asp:TextBox ID="txtReturnTypeNameCustom" runat="server" class="form-control-sm" Width="500px" placeholder="用户定制返回类型名"></asp:TextBox>
            </div>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr id="trFuncTypeID" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblFuncTypeID" runat="server" CssClass="col-form-label text-right">函数类型ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFuncTypeID" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
 
     <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabName" runat="server" CssClass="col-form-label text-right">表名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabName" runat="server" class="form-control-sm" TextMode="SingleLine" Width="600px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>

    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label3" runat="server" CssClass="col-form-label text-right">类名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtClassName" runat="server" class="form-control-sm" TextMode="SingleLine" Width="600px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>

    </tr>
    <tr id="trOrderNum" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblOrderNum" runat="server" CssClass="col-form-label text-right">序号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtOrderNum" runat="server" class="form-control-sm" Width="600px"></asp:TextBox>
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
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Height="69px" TextMode="MultiLine" Width="600px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
