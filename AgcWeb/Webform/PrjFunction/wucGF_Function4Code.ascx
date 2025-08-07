<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucGF_Function4Code.ascx.cs" Inherits="AGC.Webform.wucGF_Function4Code" %>

<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<div>
    <div style="width: 100%; float: left">
        <asp:Literal ID="litFuncName" runat="server"></asp:Literal>

    </div>
    <div style="width: 100%; float: left" class="mt-2">
        <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">函数操作模式</asp:Label>
        <asp:DropDownList ID="ddlFuncAccessModeId" runat="server" class="form-control-sm ml-3"></asp:DropDownList>
    </div>
    <div style="width: 100%; float: left" class="mt-2">
        <asp:Button ID="btnGeneFunction0" runat="server" Text="生成函数" CssClass="btn btn-outline-info btn-sm" OnClick="btnGeneFunction_Click" />
        <asp:Button ID="btnGeneFunction1" runat="server" Text="生成函数" CssClass="btn btn-outline-info btn-sm" OnClick="btnGeneFunction_Click" />
        <asp:Button ID="btnGeneFunction2" runat="server" Text="生成函数" CssClass="btn btn-outline-info btn-sm" OnClick="btnGeneFunction_Click" />
        <asp:Button ID="btnGeneFunction3" runat="server" Text="生成函数" CssClass="btn btn-outline-info btn-sm" OnClick="btnGeneFunction_Click" />
    </div>
 

</div>
