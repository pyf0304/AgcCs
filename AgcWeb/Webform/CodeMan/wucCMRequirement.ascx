<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucCMRequirement.ascx.cs" Inherits="AGC.Webform.wucCMRequirement" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabwucCMRequirement" style="width: 600px; padding: 1px; border: 0px" class="table table-bordered table-hover">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblReqId" name="lblReqId" CssClass="col-form-label text-right" Width="90px" Text="需求Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtReqId" name="txtReqId" CssClass="form-control-sm" Width="350px" runat="server" />
        </td>
        <td></td>
        <td>
            <asp:CheckBox ID="chkIsFinished" name="chkIsFinished" CssClass="col-form-label" Width="350px" Text="是否完成" runat="server"></asp:CheckBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblRequirementName" name="lblRequirementName" CssClass="col-form-label text-right" Width="90px" Text="名称" runat="server" />
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtRequirementName" name="txtRequirementName" CssClass="form-control-sm" Width="800px" runat="server" />
        </td>
      
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblReqContent" name="lblReqContent" CssClass="col-form-label text-right" Width="90px" Text="内容" runat="server" />
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtReqContent" name="txtReqContent" CssClass="code" TextMode="MultiLine" Rows="15" Width="800px" runat="server" Height="277px" />
        </td>
       
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblRequirementTypeId" name="lblRequirementTypeId" CssClass="col-form-label text-right" Width="90px" Text="类型" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlRequirementTypeId" name="ddlRequirementTypeId" CssClass="form-control-sm" Width="350px" runat="server" />
        </td>
        <td>
            <asp:Label ID="lblFuncModuleAgcId" name="lblFuncModuleAgcId" CssClass="col-form-label text-right" Width="90px" Text="模块" runat="server" />
        </td>
        <td>
            <asp:DropDownList ID="ddlFuncModuleAgcId" name="ddlFuncModuleAgcId" CssClass="form-control-sm" Width="350px" runat="server" />
        </td>
    </tr>
  
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCmPrjId" name="lblCmPrjId" CssClass="col-form-label text-right" Width="90px" Text="CM工程" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlCmPrjId" name="ddlCmPrjId" CssClass="form-control-sm" Width="350px" runat="server" />
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
   <%--  <tr>
        <td class="NameTD">
            <asp:Label ID="lblUpReqId" name="lblUpReqId" CssClass="col-form-label text-right" Width="90px" Text="上级需求" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUpReqId" name="ddlUpReqId" CssClass="form-control-sm" Width="800px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>--%>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtMemo" name="txtMemo" CssClass="form-control-sm" Width="800px" runat="server" TextMode="MultiLine" />
        </td>
     
    </tr>
</table>
