
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucFeatureFieldTypeRelaB.ascx.cs" Inherits = "AGC.Webform.wucFeatureFieldTypeRelaB" %>
<link rel = "stylesheet" type = "text/css" href = "../../css/tz_base1.css"/>
<table id="tabwucFeatureFieldTypeRela" style="width: 600px; padding: 1px; border:0px">
<tr>
<td class="NameTD">
<asp:Label id="lblFeatureId" CssClass="text-secondary" Width="90px" Text="功能Id" runat="server" />
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlFeatureId" Width="200px"  runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblFieldTypeId" CssClass="text-secondary" Width="90px" Text="字段类型Id" runat="server" />
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlFieldTypeId" Width="200px"  runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMemo" CssClass="text-secondary" Width="90px" Text="说明" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" class="ValueControl" Width="200px"  runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
</table>