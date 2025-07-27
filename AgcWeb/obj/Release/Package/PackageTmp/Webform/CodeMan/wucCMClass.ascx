<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucCMClass.ascx.cs" Inherits="AGC.Webform.wucCMClass" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabwucCMClass" style="width: 600px; padding: 1px; border: 0px" class="table table-bordered table-hover">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCMClassId" name="lblCMClassId" CssClass="col-form-label text-right" Width="90px" Text="类Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCMClassId" name="txtCMClassId" CssClass="form-control-sm" Width="300px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblClassName" name="lblClassName" CssClass="col-form-label text-right" Width="90px" Text="类名" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtClassName" name="txtClassName" CssClass="form-control-sm" Width="300px" runat="server" />
        </td>
        <td>
            <asp:Label ID="lblNameSpace" name="lblNameSpace" CssClass="col-form-label text-right" Width="90px" Text="域名" runat="server" />
        </td>
        <td>
            <asp:TextBox ID="txtNameSpace" name="txtNameSpace" CssClass="form-control-sm" Width="300px" runat="server"  placeholder="无域名的类，用:No NameSpace" />
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblProgLangTypeId" name="lblProgLangTypeId" CssClass="col-form-label text-right" Width="90px" Text="编程语言" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlProgLangTypeId" name="ddlProgLangTypeId" CssClass="form-control-sm" Width="300px" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProgLangTypeId_SelectedIndexChanged" />
        </td>
        <td>
            <asp:Label ID="lblTabName" name="lblTabName" CssClass="col-form-label text-right" Width="90px" Text="表名" runat="server" />
        </td>
        <td>
            <asp:TextBox ID="txtTabName" name="txtTabName" CssClass="form-control-sm" Width="300px" runat="server" />
        </td>
    </tr>
     <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncModuleAgcId0" name="lblFuncModuleAgcId" CssClass="col-form-label text-right" Width="90px" Text="应用" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlApplicationTypeId" name="ddlFuncModuleAgcId" CssClass="form-control-sm" Width="300px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlApplicationTypeId_SelectedIndexChanged" />
        </td>
        <td>
            <asp:Label ID="lblCodeTypeId" name="lblCodeTypeId" CssClass="col-form-label text-right" Width="90px" Text="代码类型" runat="server" />
        </td>
        <td>
            <asp:DropDownList ID="ddlCodeTypeId" name="ddlCodeTypeId" CssClass="form-control-sm" Width="300px" runat="server" />
        </td>
    </tr>
     <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncModuleAgcId" name="lblFuncModuleAgcId" CssClass="col-form-label text-right" Width="90px" Text="模块" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFuncModuleAgcId" name="ddlFuncModuleAgcId" CssClass="form-control-sm" Width="300px" runat="server" />
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
     <tr>
        <td class="NameTD">
            <asp:Label ID="Label1" name="lblFilePath" CssClass="col-form-label text-right" Width="90px" Text="工程路径" runat="server" />
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtProjectPath" name="txtFilePath" CssClass="form-control-sm" Width="800px" runat="server" />
        </td>
  
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFilePath" name="lblFilePath" CssClass="col-form-label text-right" Width="90px" Text="文件路径" runat="server" />
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtFilePath" name="txtFilePath" CssClass="form-control-sm" Width="800px" runat="server" />
        </td>
  
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFileName" name="lblFileName" CssClass="col-form-label text-right" Width="90px" Text="文件名" runat="server" />
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtFileName" name="txtFileName" CssClass="form-control-sm" Width="800px" runat="server" />
        </td>
      
    </tr>
     
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFileText" name="lblFileText" CssClass="col-form-label text-right" Width="90px" Text="文件内容" runat="server" />
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtFileText" name="txtFileText" CssClass="pre code" TextMode="MultiLine" Rows="20" Width="800px" runat="server" />
        </td>
    </tr>
   
   
   <%-- <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserId" name="lblUserId" CssClass="col-form-label text-right" Width="90px" Text="用户ID" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUserId" name="ddlUserId" CssClass="form-control-sm" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" name="lblPrjId" CssClass="col-form-label text-right" Width="90px" Text="工程ID" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" name="ddlPrjId" CssClass="form-control-sm" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>--%>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="说明" runat="server" />
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtMemo" name="txtMemo" CssClass="form-control-sm" TextMode="MultiLine" Rows="5" Width="800px" runat="server" />
        </td>
        
    </tr>
</table>
