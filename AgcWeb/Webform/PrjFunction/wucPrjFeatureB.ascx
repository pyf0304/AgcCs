<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucPrjFeatureB.ascx.cs" Inherits="AGC.Webform.wucPrjFeatureB" %>

   <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<table id="tabwucPrjFeature" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFeatureId" runat="server" CssClass="col-form-label text-right">功能Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFeatureId" runat="server" class="form-control-sm" Width="450px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFeatureName" runat="server" CssClass="col-form-label text-right">功能名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFeatureName" runat="server" class="form-control-sm" Height="52px" TextMode="MultiLine" Width="450px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDefaButtonName" runat="server" CssClass="col-form-label text-right">默认按钮名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDefaButtonName" runat="server" class="form-control-sm" Width="450px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblRegionTypeId" CssClass="col-form-label text-right" Width="90px" Text="区域类型" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlRegionTypeId" CssClass="form-control-sm" Width="450px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblInOutTypeId" CssClass="col-form-label text-right" Width="90px" Text="INOUT类型" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlInOutTypeId" CssClass="form-control-sm" Width="450px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblGroupName" CssClass="col-form-label text-right" Width="90px" Text="组名" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtGroupName" CssClass="form-control-sm" Width="450px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblKeyWords" runat="server" CssClass="col-form-label text-right">关键字</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtKeyWords" runat="server" class="form-control-sm" Height="41px" TextMode="MultiLine" Width="450px"></asp:TextBox>
            <br />
            <asp:Label ID="lblFunctionGroupId0" runat="server" CssClass="col-form-label text-right">多个关键字之间用逗号(“,”)分隔。</asp:Label>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblParentFeatureId" CssClass="col-form-label text-right" Text="父功能" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlParentFeatureId" CssClass="form-control-sm" Width="450px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFunctionGroupId" runat="server" CssClass="col-form-label text-right">函数组</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFunctionGroupId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFeatureTypeId" runat="server" CssClass="col-form-label text-right">功能类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFeatureTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFeatureTypeId0" runat="server" CssClass="col-form-label text-right">功能说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFeatureDescription" runat="server" class="form-control-sm" Height="145px" TextMode="MultiLine" Width="450px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>

    <tr>
        <td>
            <asp:CheckBox ID="chkInUse" runat="server" Text="是否在用" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCreateUserId" runat="server" CssClass="col-form-label text-right">建立用户Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCreateUserId" runat="server" class="form-control-sm"></asp:TextBox>
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
