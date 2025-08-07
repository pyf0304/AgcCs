<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucTabFeatureB.ascx.cs" Inherits="AGC.Webform.wucTabFeatureB" %>

<table id="tabwucTabFeature" style="width: 600px; padding: 1px; border: 0px">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabFeatureId" CssClass="text-secondary" Width="90px" Text="表功能Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabFeatureId" class="ValueControl" Width="200px"  runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabFeatureName" CssClass="text-secondary" Width="90px" Text="表功能名" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabFeatureName" class="ValueControl" Width="200px"  runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabId" CssClass="text-secondary" Width="90px" Text="表ID" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlTabId" Width="200px"  runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFeatureId" CssClass="text-secondary" Width="90px" Text="功能Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFeatureId" Width="200px"  runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncNameCs" CssClass="text-secondary" Width="90px" Text="函数名" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncNameCs" class="ValueControl" Width="200px"  runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
      <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncNameJs" CssClass="text-secondary" Width="90px" Text="函数名" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncNameJs" class="ValueControl" Width="200px"  runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblOrderNum" CssClass="text-secondary" Width="90px" Text="序号" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtOrderNum" class="ValueControl" Width="200px"  runat="server" />
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_OrderNum" runat="server" CssClass="text-warning"
                ErrorMessage="请输入整型数值!"
                ControlToValidate="txtOrderNum"
                Type="Integer"
                Operator="DataTypeCheck"
                EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
    <tr>
             <td></td>
        <td class="ValueTD">
            <asp:CheckBox ID="chkInUse" Width="200px"  Text="是否在用" runat="server"></asp:CheckBox>
        </td>
        <td class="ValueTD"></td>
        <td></td>
   
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" CssClass="text-secondary" Width="90px" Text="说明" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" class="ValueControl" Width="200px"  runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
