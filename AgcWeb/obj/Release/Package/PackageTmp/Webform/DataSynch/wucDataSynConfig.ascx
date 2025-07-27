
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucDataSynConfig.ascx.cs" Inherits = "AGC.Webform.wucDataSynConfig" %>
<table id="tabwucDataSynConfig" name="tabwucDataSynConfig" style="width: 600px; padding: 1px; border:0px" class="table table-bordered table-hover">
<tr>
<td class="NameTD">
<asp:Label id="lblTabName" name="lblTabName" CssClass="col-form-label text-right" Width="90px" Text="表名" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtTabName" name="txtTabName" CssClass="form-control" Width="200px" runat="server" />
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
<asp:CheckBox  id="chkIsSynch" name="chkIsSynch" CssClass = "form-control"   Width = "200px"  Text = "是否同步"   runat="server" >
</asp:CheckBox>
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblSynCondition" name="lblSynCondition" CssClass="col-form-label text-right" Width="90px" Text="同步条件" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtSynCondition" name="txtSynCondition" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblSynCondition4Web" name="lblSynCondition4Web" CssClass="col-form-label text-right" Width="90px" Text="同步条件4Web" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtSynCondition4Web" name="txtSynCondition4Web" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblSynchCycle" name="lblSynchCycle" CssClass="col-form-label text-right" Width="90px" Text="同步周期" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtSynchCycle" name="txtSynchCycle" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblSynchDate" name="lblSynchDate" CssClass="col-form-label text-right" Width="90px" Text="同步日期" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtSynchDate" name="txtSynchDate" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblSynchTime" name="lblSynchTime" CssClass="col-form-label text-right" Width="90px" Text="同步时间" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtSynchTime" name="txtSynchTime" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblSenderUser" name="lblSenderUser" CssClass="col-form-label text-right" Width="90px" Text="发送邮件用户" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtSenderUser" name="txtSenderUser" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblSenderPwd" name="lblSenderPwd" CssClass="col-form-label text-right" Width="90px" Text="发送邮件口令" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtSenderPwd" name="txtSenderPwd" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblsmtp" name="lblsmtp" CssClass="col-form-label text-right" Width="90px" Text="发送邮件服务器" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtsmtp" name="txtsmtp" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblReceiver" name="lblReceiver" CssClass="col-form-label text-right" Width="90px" Text="接收者" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtReceiver" name="txtReceiver" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lbllastMailDate" name="lbllastMailDate" CssClass="col-form-label text-right" Width="90px" Text="最后发邮件日期" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtlastMailDate" name="txtlastMailDate" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lbllastExecuteDate" name="lbllastExecuteDate" CssClass="col-form-label text-right" Width="90px" Text="最后执行日期" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtlastExecuteDate" name="txtlastExecuteDate" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblSynchStartTime" name="lblSynchStartTime" CssClass="col-form-label text-right" Width="90px" Text="同步开始时间" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtSynchStartTime" name="txtSynchStartTime" CssClass="form-control" Width="200px" runat="server" />
</td>
<td>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblSynchEndTime" name="lblSynchEndTime" CssClass="col-form-label text-right" Width="90px" Text="同步结束时间" runat="server" />
</td>
<td class="ValueTD">
<asp:TextBox id="txtSynchEndTime" name="txtSynchEndTime" CssClass="form-control" Width="200px" runat="server" />
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