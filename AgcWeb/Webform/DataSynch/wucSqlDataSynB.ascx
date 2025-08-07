<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucSqlDataSynB.ascx.cs" Inherits="AGC.Webform.wucSqlDataSynB" %>

<table id="tabwucSqlDataSyn" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabId" runat="server" CssClass="col-form-label text-right">表ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabId" runat="server" class="form-control-sm" Width="600px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabName" runat="server" CssClass="col-form-label text-right">表名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabName" runat="server" class="form-control-sm" Width="600px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabCnName" runat="server" CssClass="col-form-label text-right">表中文名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabCnName" runat="server" class="form-control-sm" Width="600px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabEnName" runat="server" CssClass="col-form-label text-right">表英文详细名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabEnName" runat="server" class="form-control-sm" Width="600px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrimaryTypeId" runat="server" CssClass="col-form-label text-right">主键类型ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrimaryTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblRecExclusiveWayId" runat="server" CssClass="col-form-label text-right">记录排他方式Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlRecExclusiveWayId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSqlCommandTypeId" runat="server" CssClass="col-form-label text-right">Sql命令类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlSqlCommandTypeId" runat="server" class="form-control-sm" Width="600px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSqlCommandText" runat="server" CssClass="col-form-label text-right">Sql命令内容</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSqlCommandText" runat="server" class="form-control-sm" Width="600px" Height="45px" TextMode="MultiLine"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTargetTabCondition" runat="server" CssClass="col-form-label text-right" Width="120px">目标表有效记录条件</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTargetTabCondition" runat="server" class="form-control-sm" Width="600px" Height="45px" TextMode="MultiLine"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Height="34px" TextMode="MultiLine" Width="600px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr id="trSqlData" runat="server">
        <td class="NameTD">
            <asp:Label ID="lblSqlData" runat="server" CssClass="col-form-label text-right">Sql表数据</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSqlData" runat="server" class="form-control-sm" Height="52px" TextMode="MultiLine" Width="600px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTextResouce" runat="server" CssClass="col-form-label text-right">文本来源</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTextResouce" runat="server" class="form-control-sm" Width="600px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTextResourceTypeId" runat="server" CssClass="col-form-label text-right">文本来源类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlTextResourceTypeId" runat="server" class="form-control-sm" Width="600px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>


</table>
