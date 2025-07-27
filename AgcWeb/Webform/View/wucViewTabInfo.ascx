<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewTabInfo.ascx.cs" Inherits="AGC.Webform.wucViewTabInfo"%>
<table id="tabwucViewTabInfo" cellSpacing="1" cellPadding="1" width="600" border="0">
	<tr>
		<td>
			<asp:Label id="lblViewId" runat="server">界面ID</asp:Label>
		</td>
		<td>
			<asp:DropDownList id="ddlViewId" runat="server" Width="152px"></asp:DropDownList>
		</td>
		<td>
		</td>
		<td></td>
	</tr>
	<tr>
		<td>
			<asp:Label id="lblDataBaseName" runat="server">数据库名</asp:Label>
		</td>
		<td>
			<asp:TextBox id="txtDataBaseName" runat="server"></asp:TextBox>
		</td>
		<td>
		</td>
		<td></td>
	</tr>
	<tr>
		<td>
			<asp:Label id="lblTabName" runat="server">表名</asp:Label>
		</td>
		<td>
			<asp:TextBox id="txtTabName" runat="server"></asp:TextBox>
		</td>
		<td>
		</td>
		<td></td>
	</tr>
</table>
