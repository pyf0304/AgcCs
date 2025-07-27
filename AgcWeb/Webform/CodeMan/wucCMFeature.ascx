<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucCMFeature.ascx.cs" Inherits="AGC.Webform.wucCMFeature" %>

<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<table id="tabwucPrjFeature" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="text-right">
            <asp:Label ID="lblCmFeatureId" runat="server" CssClass="col-form-label text-right">功能Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCmFeatureId" runat="server" class="form-control-sm" Width="800px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="lblFeatureName" runat="server" CssClass="col-form-label text-right">功能名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFeatureName" runat="server" class="form-control-sm" Width="800px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="lblKeyWords" runat="server" CssClass="col-form-label text-right">关键字</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtKeyWords" runat="server" class="form-control-sm" Width="800px" placeholder="多个关键字之间用“;”分隔"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>


    <tr>
        <td class="text-right">
            <asp:Label ID="lblCmFeatureTypeId" runat="server" CssClass="col-form-label text-right">功能类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlCmFeatureTypeId" runat="server" class="form-control-sm" Width="800px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="lblCmFeatureTypeId0" runat="server" CssClass="col-form-label text-right">功能说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFeatureDescription" runat="server" class="form-control-sm" Height="145px" TextMode="MultiLine" Width="800px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

    <tr>
        <td></td>
        <td>
            <asp:CheckBox ID="chkInUse" runat="server" Text="是否在用" CssClass="Check_Defa"></asp:CheckBox>
        </td>

        <td></td>
        <td></td>
    </tr>
    <%--<tr>
        <td class="NameTD">
            <asp:Label ID="lblCreateUserId" runat="server" CssClass="col-form-label text-right">建立用户Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCreateUserId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>--%>


    <tr>
        <td class="text-right">
            <asp:Label ID="lblFuncModuleAgcId" CssClass="col-form-label text-right" Width="90px" Text="模块" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFuncModuleAgcId" CssClass="form-control-sm" Width="800px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="lblCmPrjId" CssClass="col-form-label text-right" Width="90px" Text="CM工程" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlCmPrjId" CssClass="form-control-sm" Width="800px" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCmPrjId_SelectedIndexChanged"  />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="lblCmParentFeatureId" CssClass="col-form-label text-right" Text="父功能" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlCmParentFeatureId" CssClass="form-control-sm" Width="800px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
