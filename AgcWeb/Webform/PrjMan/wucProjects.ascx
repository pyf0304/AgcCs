<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucProjects.ascx.cs" Inherits="AGC.Webform.wucProjects" %>

<table id="tabwucProjects" cellspacing="1" cellpadding="1" border="0" style="width: 663px">
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblPrjId" runat="server" CssClass="col-form-label text-right">工程ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrjId" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
                <td style="text-align:right">
            <asp:Label ID="lblPrjName" runat="server" CssClass="col-form-label text-right">工程名称</asp:Label>
        </td>
        <td style="width: 199px">
            <asp:TextBox ID="txtPrjName" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblPrjDomain" runat="server" CssClass="col-form-label text-right">域/包名</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtPrjDomain" runat="server" class="form-control-sm" Width="538px"></asp:TextBox>
        </td>
    </tr>
     <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="Label4" runat="server" CssClass="col-form-label text-right">Java包名</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtJavaPackageName" runat="server" class="form-control-sm" Width="538px"></asp:TextBox>
        </td>
    </tr>
       <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="Label5" runat="server" CssClass="col-form-label text-right">ISO工程名</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtIsoPrjName" runat="server" class="form-control-sm" Width="538px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblUpdDate" runat="server" CssClass="col-form-label text-right">软件架构</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlSoftStructureId" runat="server" 
                class="form-control-sm" Width="200px">
            </asp:DropDownList>
        </td>
                <td style="text-align:right">
            <asp:Label ID="lblUserId" runat="server" CssClass="col-form-label text-right">应用程序类型</asp:Label>
        </td>
        <td style="width: 199px">
            <asp:DropDownList ID="ddlApplicationTypeId" runat="server" 
                class="form-control-sm" Width="200px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblUserId0" runat="server" CssClass="col-form-label text-right">项目数据库</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjDataBaseId" runat="server" 
                class="form-control-sm" Width="200px" AutoPostBack="True" 
                onselectedindexchanged="ddlPrjDataBaseId_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
                <td style="text-align:right">
            &nbsp;</td>
        <td style="width: 199px">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblDataBaseTypeId" runat="server" CssClass="col-form-label text-right">数据库类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlDataBaseTypeId" runat="server" class="form-control-sm" 
                Width="200px" Enabled="False">
            </asp:DropDownList>
        </td>
                <td style="text-align:right">
            <asp:Label ID="lblIpAddress" runat="server" CssClass="col-form-label text-right">服务器</asp:Label>
        </td>
        <td style="width: 199px">
            <asp:TextBox ID="txtIpAddress" runat="server" class="form-control-sm" 
                Width="200px" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblPrjDataBaseName" runat="server" CssClass="col-form-label text-right">主数据库</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrjDataBaseName" runat="server" class="form-control-sm" 
                Width="200px" ReadOnly="True"></asp:TextBox>
        </td>
                <td style="text-align:right">
            <asp:Label ID="lblDatabaseOwner" runat="server" CssClass="col-form-label text-right">数据库拥有者</asp:Label>
        </td>
        <td style="width: 199px">
            <asp:TextBox ID="txtDatabaseOwner" runat="server" class="form-control-sm" 
                Width="200px" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblSid" runat="server" CssClass="col-form-label text-right">Sid</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSid" runat="server" class="form-control-sm" Width="200px" 
                ReadOnly="True"></asp:TextBox>
        </td>
                <td style="text-align:right">
            <asp:Label ID="lblTableSpace" runat="server" CssClass="col-form-label text-right">表空间</asp:Label>
        </td>
        <td style="width: 199px">
            <asp:TextBox ID="txtTableSpace" runat="server" class="form-control-sm" 
                Width="200px" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblDataBaseUserId" runat="server" CssClass="col-form-label text-right" Width="100px">数据库的用户ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBaseUserId" runat="server" class="form-control-sm" 
                Width="200px" ReadOnly="True"></asp:TextBox>
        </td>
                <td style="text-align:right">
            <asp:Label ID="lblDataBasePwd" runat="server" CssClass="col-form-label text-right" Width="110px">数据库的用户口令</asp:Label>
        </td>
        <td style="width: 199px">
            <asp:TextBox ID="txtDataBasePwd" runat="server" class="form-control-sm" 
                Width="200px" TextMode="Password" ReadOnly="True" AutoCompleteType="Disabled"  AUTOCOMPLETE="off"></asp:TextBox>
                          <asp:HiddenField ID="hidDataBasePwd" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="Label1" runat="server" CssClass="col-form-label text-right">虚拟目录</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtVirtualDirectory" runat="server" class="form-control-sm" Width="538px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="height: 26px; width: 100px;" align="right">
            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">工程根目录</asp:Label>
        </td>
        <td colspan="3" style="height: 26px">
            <asp:TextBox ID="txtPrjRootDirectory" runat="server" class="form-control-sm" Width="538px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="height: 26px; width: 100px;" align="right">
            <asp:Label ID="Label3" runat="server" CssClass="col-form-label text-right">是否关联数据库</asp:Label>
        </td>
        <td colspan="1" style="height: 26px">
            <asp:CheckBox ID="chkIsRelaDataBase" runat="server" />
        </td>
   
         <td class="style1" align="right">
            <asp:Label ID="lblDataBaseUserId0" runat="server" CssClass="col-form-label text-right">使用状态</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUseStateId" runat="server" class="form-control-sm" 
                Width="200px" 
               >
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="height: 26px; width: 100px;" align="right">
            <asp:Label ID="Label6" runat="server" CssClass="col-form-label text-right">是否支持Mvc</asp:Label>
        </td>
        <td colspan="1" style="height: 26px">
            <asp:CheckBox ID="chkIsSupportMvc" runat="server" />
        </td>
   
         <td class="style1" align="right">
             &nbsp;</td>
        <td class="ValueTD">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Width="536px" Height="50px"
                TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
