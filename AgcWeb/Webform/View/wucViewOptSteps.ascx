<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewOptSteps.ascx.cs"
    Inherits="AGC.Webform.wucViewOptSteps" %>

<table id="tabwucViewOptSteps" cellspacing="0" cellpadding="0" border="0"
    style="width: 705px; font-family: Verdana; height: 147px">
    <tr valign="top">
        <td style="height: 32px">
            <asp:Label ID="lblViewId" runat="server" CssClass="text-secondary">界面ID</asp:Label>
        </td>
        <td style="height: 32px">
            <asp:DropDownList ID="ddlViewId" runat="server" Width="152px" 
                 Enabled="False">
            </asp:DropDownList>
        </td>
        <td style="height: 32px">
        </td>
        <td style="height: 32px">
        </td>
    </tr>
    <tr valign="top">
        <td style="height: 31px">
            <asp:Label ID="lblStepIndex" runat="server" CssClass="text-secondary">流程序号</asp:Label>
        </td>
        <td style="height: 31px">
            <asp:TextBox ID="txtStepIndex" runat="server"
                ReadOnly="True"></asp:TextBox>
            <asp:CompareValidator ID="ComValid_StepIndex" runat="server" ErrorMessage="请输入整型数值!"
                ControlToValidate="txtStepIndex" Type="Integer" Operator="DataTypeCheck" EnableClientScript="False"
                  CssClass="text-warning"></asp:CompareValidator>
        </td>
        <td style="height: 31px">
            <asp:Label ID="lblStepName" runat="server" CssClass="text-secondary">流程名称</asp:Label></td>
        <td style="height: 31px">
            <asp:TextBox ID="txtStepName" runat="server" Width="220px"></asp:TextBox></td>
    </tr>
    <tr valign="top">
        <td>
            <asp:Label ID="lblStepDetail" runat="server" CssClass="text-secondary">流程详细说明</asp:Label>
        </td>
        <td colspan="3">
            <asp:TextBox ID="txtStepDetail" runat="server" Width="606px" Height="123px" 
                 TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
