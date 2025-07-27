
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucFuncModule_Agc.ascx.cs" Inherits = "AGC.Webform.wucFuncModule_Agc" %>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabEdit" style="width: 70%" class="table table-bordered table-hover table td table-sm">
<tr>
<td>
<asp:Label id="lblFuncModuleAgcId" name="lblFuncModuleAgcId" CssClass="col-form-label text-right" Width="90px" Text="功能模块Id" runat="server" />
</td>
<td>
<asp:TextBox id="txtFuncModuleAgcId" name="txtFuncModuleAgcId" CssClass="form-control" Width="400px" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label id="lblFuncModuleName" name="lblFuncModuleName" CssClass="col-form-label text-right" Width="90px" Text="功能模块名称" runat="server" />
</td>
<td>
<asp:TextBox id="txtFuncModuleName" name="txtFuncModuleName" CssClass="form-control" Width="400px" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label id="lblFuncModuleEnName" name="lblFuncModuleEnName" CssClass="col-form-label text-right" Width="90px" Text="功能模块英文名称" runat="server" />
</td>
<td>
<asp:TextBox id="txtFuncModuleEnName" name="txtFuncModuleEnName" CssClass="form-control" Width="400px" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label id="lblFuncModuleNameSim" name="lblFuncModuleNameSim" CssClass="col-form-label text-right" Width="90px" Text="功能模块简称" runat="server" />
</td>
<td>
<asp:TextBox id="txtFuncModuleNameSim" name="txtFuncModuleNameSim" CssClass="form-control" Width="400px" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label id="lblOrderNum" name="lblOrderNum" CssClass="col-form-label text-right" Width="90px" Text="序号" runat="server" />
</td>
<td>
<asp:TextBox id="txtOrderNum" name="txtOrderNum" CssClass="form-control" Width="400px" runat="server" />
<asp:CompareValidator id="ComValid_OrderNum" name="ComValid_OrderNum" runat="server" CssClass="ErrMsg"
 ErrorMessage="请输入整型数值!"
 ControlToValidate="txtOrderNum"
 Type="Integer"
 Operator="DataTypeCheck"
 EnableClientScript="false">
</asp:CompareValidator>
</td>
</tr>
<tr>
<td>
<asp:Label id="lblUseStateId" name="lblUseStateId" CssClass="col-form-label text-right" Width="90px" Text="使用状态Id" runat="server" />
</td>
<td>
<asp:DropDownList id="ddlUseStateId" name="ddlUseStateId" CssClass="form-control" Width="400px" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label id="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
</td>
<td>
<asp:TextBox id="txtMemo" name="txtMemo" CssClass="form-control" Width="400px" runat="server" />
</td>
</tr>
</table>