<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucwf_WorkFlow.ascx.cs" Inherits="AGC.Webform.wucwf_WorkFlow" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabwucwf_WorkFlow" name="tabwucwf_WorkFlow" style="width: 600px; padding: 1px; border: 0px" class="table table-bordered table-hover">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblWorkFlowId" name="lblWorkFlowId" CssClass="col-form-label text-right" Width="90px" Text="工作流Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtWorkFlowId" name="txtWorkFlowId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblWorkFlowName" name="lblWorkFlowName" CssClass="col-form-label text-right" Width="90px" Text="工作流名称" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtWorkFlowName" name="txtWorkFlowName" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblWorkFlowNameSim" name="lblWorkFlowNameSim" CssClass="col-form-label text-right" Width="90px" Text="工作流简称" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtWorkFlowNameSim" name="txtWorkFlowNameSim" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD"></td>
        <td class="ValueTD">
            <asp:CheckBox ID="chkIsCurrentUse" name="chkIsCurrentUse" CssClass="form-control" Width="200px" Text="是否当前使用" runat="server"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" name="lblPrjId" CssClass="col-form-label text-right" Width="90px" Text="工程ID" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" name="ddlPrjId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
  
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" name="txtMemo" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
