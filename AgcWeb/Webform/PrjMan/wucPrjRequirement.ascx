<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucPrjRequirement.ascx.cs"
    Inherits="AGC.wucPrjRequirement" %>

<table id="tabwucPrjRequirement" cellspacing="1" cellpadding="1" width="384" border="0"
    style="width: 384px; height: 434px">
    <tr>
        <td class="NameTD" style="width: 108px">
            <asp:Label ID="lblReqId" runat="server"
                CssClass="col-form-label text-right">需求编号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtReqId" runat="server"
                class="form-control-sm" Width="160px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 108px">
            <asp:Label ID="lblRequirement" runat="server"
                CssClass="col-form-label text-right">需求名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtRequirement" runat="server"
                class="form-control-sm" Width="160px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 108px">
            <asp:Label ID="lblPrjId" runat="server"
                CssClass="col-form-label text-right">所属工程</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" runat="server"
                class="form-control-sm" Width="160px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 108px">
            <asp:Label ID="lblUpReqId" runat="server"
                CssClass="col-form-label text-right">父需求</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUpReqId" runat="server"
                class="form-control-sm" Width="160px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 108px; height: 17px">
            <asp:Label ID="lblReqTypeId" runat="server"
                CssClass="col-form-label text-right">需求</asp:Label>
        </td>
        <td class="ValueTD" style="height: 17px">
            <asp:DropDownList ID="ddlReqTypeId" runat="server"
                class="form-control-sm" Width="160px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 108px">
            <asp:Label ID="lblFuncModuleId" runat="server"
                CssClass="col-form-label text-right">功能模块</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFuncModuleId" runat="server"
                class="form-control-sm" Width="160px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 108px">
            <asp:Label ID="lblIsFinished" runat="server"
                CssClass="col-form-label text-right">是否已实现</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtIsFinished" runat="server"
                class="form-control-sm" Width="160px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 108px">
            <asp:Label ID="lblReqContent" runat="server"
                CssClass="col-form-label text-right">需求详细内容</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtReqContent" runat="server"
                class="form-control-sm" TextMode="MultiLine" Height="120px" Width="250px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 108px">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server"
                class="form-control-sm" TextMode="MultiLine" Height="122px" Width="250px"></asp:TextBox>
        </td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="0" runat="server">
    <tr>
        <td>
            
                <asp:Label ID="lblUserId" CssClass="col-form-label text-right"
                    runat="server">用户Id</asp:Label></font></td>
        <td id="TD1" runat="server">
            <asp:TextBox ID="txtUserId" class="form-control-sm"
                runat="server" Width="160px"></asp:TextBox></td>
    </tr>
</table>
