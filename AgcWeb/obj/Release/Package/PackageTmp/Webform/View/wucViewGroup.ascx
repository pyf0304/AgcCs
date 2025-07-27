<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewGroup.ascx.cs"
    Inherits="AGC.Webform.wucViewGroup" %>

<table id="tabwucViewGroup" cellspacing="1" cellpadding="1" width="712" border="0"
    style="width: 712px">
    <tr>
        <td style="width: 125px">
            <asp:Label ID="lblViewGroupName" runat="server" CssClass="text-secondary" >界面组名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtViewGroupName" runat="server" 
                Width="272px"></asp:TextBox>
        </td>
        <td>
            
                <asp:Label ID="lblViewGroupId" runat="server" CssClass="text-secondary" >界面组ID</asp:Label></font>
        </td>
        <td style="width: 210px">
            
                <asp:TextBox ID="txtViewGroupId" runat="server" 
                    Width="198px"></asp:TextBox></font></td>
    </tr>
    <tr>
        <td style="width: 125px">
            <asp:Label ID="lblPrjDomain" runat="server" CssClass="text-secondary" >域/包名</asp:Label>
        </td>
        <td colspan="3">
            
                <asp:TextBox ID="txtPrjDomain" runat="server" 
                    Width="568px"></asp:TextBox></font>
        </td>
    </tr>
    <tr>
        <td style="width: 125px">
            <asp:Label ID="lblActionPath" runat="server" CssClass="text-secondary">Action路径</asp:Label></td>
        <td colspan="3">
            <asp:TextBox ID="txtActionPath" runat="server"
                Width="568px"></asp:TextBox></td>
    </tr>
    <tr>
        <td style="width: 125px">
            <asp:Label ID="lblOutSqlDsTypeId" runat="server" CssClass="text-secondary" >输出数据源类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlOutSqlDsTypeId" runat="server" 
                Width="264px" AutoPostBack="True" OnSelectedIndexChanged="ddlOutSqlDsTypeId_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td>
            
                <asp:Label ID="lblOutRelaTabId" runat="server" CssClass="text-secondary"  >输出数据源表</asp:Label></font>
        </td>
        <td style="width: 210px">
            
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                <asp:DropDownList ID="ddlOutRelaTabId" runat="server"
                    Width="200px">
                </asp:DropDownList>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlOutSqlDsTypeId" EventName="SelectedIndexChanged" />
                    </Triggers>
                </asp:UpdatePanel>
            </font></td>
    </tr>
    <tr>
        <td style="width: 125px">
            <asp:Label ID="lblInSqlDsTypeId" runat="server" CssClass="text-secondary" >输入数据源类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlInSqlDsTypeId" runat="server" 
                Width="264px" AutoPostBack="True" OnSelectedIndexChanged="ddlInSqlDsTypeId_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td>
            
                <asp:Label ID="lblInRelaTabId" runat="server" CssClass="text-secondary" >输入数据源表</asp:Label></font>
        </td>
        <td style="width: 210px">
            
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                <asp:DropDownList ID="ddlInRelaTabId" runat="server"
                    Width="200px">
                </asp:DropDownList>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="ddlInSqlDsTypeId" EventName="SelectedIndexChanged" />
                    </Triggers>
                </asp:UpdatePanel>
            </font></td>
    </tr>
    <tr>
        <td style="width: 125px">
            <asp:Label ID="lblTableNameForProg" runat="server"
                CssClass="col-form-label text-right">编程用表名</asp:Label></td>
        <td>
            <asp:TextBox ID="txtTableNameForProg" runat="server"
                class="form-control-sm" Width="264px"></asp:TextBox></td>
        <td colspan="2">
            
                <asp:Label ID="Label1"  runat="server" CssClass="MemoStyle1">用于生成代码时界面的名称</asp:Label></font></td>
    </tr>
    <tr>
        <td style="width: 125px; height: 24px">
            <asp:Label ID="lblMemo" runat="server" CssClass="text-secondary" >说明</asp:Label>
        </td>
        <td style="height: 24px" colspan="3">
            
                <asp:TextBox ID="txtMemo" runat="server" 
                    Width="568px" Height="64px"></asp:TextBox></font></td>
    </tr>
</table>
