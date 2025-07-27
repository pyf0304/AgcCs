
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucUsers.ascx.cs" Inherits = "AGC.Webform.wucUsers" %>
<table id="tabwucUsers" name="tabwucUsers" style="width: 600px; padding: 1px; border:0px" class="table table-bordered table-hover">
<tr>
<td class="NameTD">
<asp:Label id="lblUserId" name="lblUserId" CssClass="col-form-label text-right" Width="90px" Text="用户ID" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtUserId" name="txtUserId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblUserName" name="lblUserName" CssClass="col-form-label text-right" Width="90px" Text="用户名" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtUserName" name="txtUserName" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblUserStateId" name="lblUserStateId" CssClass="col-form-label text-right" Width="90px" Text="用户状态号" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtUserStateId" name="txtUserStateId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblDepartmentId" name="lblDepartmentId" CssClass="col-form-label text-right" Width="90px" Text="部门ID" runat="server" />
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlDepartmentId" name="ddlDepartmentId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblQXDJ" name="lblQXDJ" CssClass="col-form-label text-right" Width="90px" Text="权限等级" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtQXDJ" name="txtQXDJ" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
<asp:CompareValidator id="ComValid_QXDJ" name="ComValid_QXDJ" runat="server" CssClass="ErrMsg"
 ErrorMessage="请输入整型数值!"
 ControlToValidate="txtQXDJ"
 Type="Integer"
 Operator="DataTypeCheck"
 EnableClientScript="false">
</asp:CompareValidator>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblEffectiveDate" name="lblEffectiveDate" CssClass="col-form-label text-right" Width="90px" Text="EffectiveDate" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtEffectiveDate" name="txtEffectiveDate" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblEffitiveBeginDate" name="lblEffitiveBeginDate" CssClass="col-form-label text-right" Width="90px" Text="EffitiveBeginDate" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtEffitiveBeginDate" name="txtEffitiveBeginDate" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblEffitiveEndDate" name="lblEffitiveEndDate" CssClass="col-form-label text-right" Width="90px" Text="EffitiveEndDate" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtEffitiveEndDate" name="txtEffitiveEndDate" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblPassword" name="lblPassword" CssClass="col-form-label text-right" Width="90px" Text="口令" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtPassword" name="txtPassword" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblRoleId" name="lblRoleId" CssClass="col-form-label text-right" Width="90px" Text="角色ID" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtRoleId" name="txtRoleId" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblIdentityID" name="lblIdentityID" CssClass="col-form-label text-right" Width="90px" Text="身份编号" runat="server" />
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlIdentityID" name="ddlIdentityID" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblEmail" name="lblEmail" CssClass="col-form-label text-right" Width="90px" Text="电子邮箱" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtEmail" name="txtEmail" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
</td>
<td class="ValueTD">
<asp:CheckBox  id="chkIsGpUser" name="chkIsGpUser" CssClass = "form-control"   Width = "200px"  Text = "是否平台用户"   runat="server" >
</asp:CheckBox>
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblRegisterPassword" name="lblRegisterPassword" CssClass="col-form-label text-right" Width="90px" Text="注册密码" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtRegisterPassword" name="txtRegisterPassword" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
</td>
<td class="ValueTD">
<asp:CheckBox  id="chkIsRegister" name="chkIsRegister" CssClass = "form-control"   Width = "200px"  Text = "是否注册"   runat="server" >
</asp:CheckBox>
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblRegisterDate" name="lblRegisterDate" CssClass="col-form-label text-right" Width="90px" Text="注册日期" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtRegisterDate" name="txtRegisterDate" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
</td>
<td class="ValueTD">
<asp:CheckBox  id="chkIsAudit" name="chkIsAudit" CssClass = "form-control"   Width = "200px"  Text = "是否审核"   runat="server" >
</asp:CheckBox>
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblAuditUser" name="lblAuditUser" CssClass="col-form-label text-right" Width="90px" Text="审核人" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtAuditUser" name="txtAuditUser" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblAuditDate" name="lblAuditDate" CssClass="col-form-label text-right" Width="90px" Text="审核日期" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtAuditDate" name="txtAuditDate" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" name="txtMemo" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
</table>