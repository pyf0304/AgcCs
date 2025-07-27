<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucCMFunction.ascx.cs" Inherits="AGC.Webform.wucCMFunction" %>

<table id="tabwucCMFunction" style="width: 840px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCMFunctionId" runat="server" CssClass="col-form-label text-right">函数Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCmFunctionId" runat="server" class="form-control-sm" Width="800px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFunctionName" runat="server" CssClass="col-form-label text-right">函数名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFunctionName" runat="server" class="form-control-sm" Width="800px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
     <tr>
        <td class="NameTD">
            <asp:Label ID="lblKeyWords" runat="server" CssClass="col-form-label text-right">关键字</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtKeyWords" runat="server" class="code" TextMode="MultiLine" Width="800px" Rows="5" placeholder="多个关键字之间用“;”分隔"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncComments" runat="server" CssClass="col-form-label text-right">函数注释</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncComments" runat="server" CssClass="pre code" TextMode="MultiLine" Width="800px" Rows="8"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">函数内容</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncContent" runat="server" CssClass="pre code" TextMode="MultiLine" Width="800px" Rows="20"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
       
    <tr id="trFunctionSignature" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblFunctionSignature" runat="server" CssClass="col-form-label text-right">函数签名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFunctionSignature" runat="server" class="form-control-sm" Width="800px"></asp:TextBox>
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
                <asp:TextBox ID="txtReturnTypeNameCustom" runat="server" class="form-control-sm" Width="800px" placeholder="用户定制返回类型名"></asp:TextBox>
            </div>
        </td>
        <td></td>
        <td></td>
    </tr>

    <%-- <tr id="trCodeTypeId" runat="server">
        <td class="NameTD">
            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">代码类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlCodeTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>--%>
   
    <tr id="trCmClassId" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblCMClassId" CssClass="col-form-label text-right" Width="90px" Text="类名" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlCmClassId" CssClass="form-control-sm" Width="200px" runat="server" />
        </td>
        <td></td>
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
