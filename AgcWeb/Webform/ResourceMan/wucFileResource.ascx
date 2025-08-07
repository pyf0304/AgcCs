
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucFileResource.ascx.cs" Inherits = "AGC.Webform.wucFileResource" %>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabEdit" style="width: 70%" class="table table-bordered table-hover table td table-sm">
<tr>
<td>
<asp:Label id="lblFileDirName" name="lblFileDirName" CssClass="col-form-label text-right" Width="90px" Text="文件目录名" runat="server" />
</td>
<td>
<asp:TextBox id="txtFileDirName" name="txtFileDirName" CssClass="form-control" Width="150px" runat="server" />
</td>
<td>
<asp:Label id="lblFileName" name="lblFileName" CssClass="col-form-label text-right" Width="90px" Text="文件名" runat="server" />
</td>
<td>
<asp:TextBox id="txtFileName" name="txtFileName" CssClass="form-control" Width="150px" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label id="lblExtension" name="lblExtension" CssClass="col-form-label text-right" Width="90px" Text="扩展名" runat="server" />
</td>
<td>
<asp:TextBox id="txtExtension" name="txtExtension" CssClass="form-control" Width="150px" runat="server" />
</td>
<td>
<asp:Label id="lblFileLength" name="lblFileLength" CssClass="col-form-label text-right" Width="90px" Text="文件长度" runat="server" />
</td>
<td>
<asp:TextBox id="txtFileLength" name="txtFileLength" CssClass="form-control" Width="150px" runat="server" />
<asp:CompareValidator id="ComValid_FileLength" name="ComValid_FileLength" runat="server" CssClass="ErrMsg"
 ErrorMessage="请输入整型数值!"
 ControlToValidate="txtFileLength"
 Type="Integer"
 Operator="DataTypeCheck"
 EnableClientScript="false">
</asp:CompareValidator>
</td>
</tr>
<tr>
<td>
<asp:Label id="lblFileType" name="lblFileType" CssClass="col-form-label text-right" Width="90px" Text="文件类型" runat="server" />
</td>
<td>
<asp:TextBox id="txtFileType" name="txtFileType" CssClass="form-control" Width="150px" runat="server" />
</td>
<td>
<asp:Label id="lblCreationTime" name="lblCreationTime" CssClass="col-form-label text-right" Width="90px" Text="建立时间" runat="server" />
</td>
<td>
<asp:TextBox id="txtCreationTime" name="txtCreationTime" CssClass="form-control" Width="150px" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label id="lblLastWriteTime" name="lblLastWriteTime" CssClass="col-form-label text-right" Width="90px" Text="修改日期" runat="server" />
</td>
<td>
<asp:TextBox id="txtLastWriteTime" name="txtLastWriteTime" CssClass="form-control" Width="150px" runat="server" />
</td>
<td>
<asp:Label id="lblCheckDateTime" name="lblCheckDateTime" CssClass="col-form-label text-right" Width="90px" Text="CheckDateTime" runat="server" />
</td>
<td>
<asp:TextBox id="txtCheckDateTime" name="txtCheckDateTime" CssClass="form-control" Width="150px" runat="server" />
</td>
</tr>
<tr>
<td ColSpan=2>
<asp:CheckBox  id="chkInUse" name="chkInUse" CssClass = "form-control"   Width = "150px"  Text = "是否在用"   runat="server" >
</asp:CheckBox>
</td>
<td ColSpan=2>
<asp:CheckBox  id="chkIsExistFile" name="chkIsExistFile" CssClass = "form-control"   Width = "150px"  Text = "是否存在文件"   runat="server" >
</asp:CheckBox>
</td>
</tr>
<tr>
<td>
<asp:Label id="lblPrjId" name="lblPrjId" CssClass="col-form-label text-right" Width="90px" Text="工程ID" runat="server" />
</td>
<td>
<asp:DropDownList id="ddlPrjId" name="ddlPrjId" CssClass="form-control" Width="150px" runat="server" />
</td>
<td>
<asp:Label id="lblCmPrjId" name="lblCmPrjId" CssClass="col-form-label text-right" Width="90px" Text="CM工程Id" runat="server" />
</td>
<td>
<asp:DropDownList id="ddlCmPrjId" name="ddlCmPrjId" CssClass="form-control" Width="150px" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label id="lblIpAddress" name="lblIpAddress" CssClass="col-form-label text-right" Width="90px" Text="服务器" runat="server" />
</td>
<td>
<asp:TextBox id="txtIpAddress" name="txtIpAddress" CssClass="form-control" Width="150px" runat="server" />
</td>
<td>
<asp:Label id="lblIdFtpResource" name="lblIdFtpResource" CssClass="col-form-label text-right" Width="90px" Text="FTP资源流水号" runat="server" />
</td>
<td>
<asp:TextBox id="txtIdFtpResource" name="txtIdFtpResource" CssClass="form-control" Width="150px" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label id="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
</td>
<td>
<asp:TextBox id="txtMemo" name="txtMemo" CssClass="form-control" Width="150px" runat="server" />
</td>
</tr>
</table>