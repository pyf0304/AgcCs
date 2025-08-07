<%@ Page Title="" Language="C#" MasterPageFile="~/Webform/Table2/EditTable.master" AutoEventWireup="True" CodeBehind="Test1.aspx.cs" Inherits="Webform_Table2_Test1" %>

<%@ Register src="../Table/wucPrjTab.ascx" tagname="wucPrjTab" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
     <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <uc1:wucPrjTab ID="wucPrjTab1" runat="server" />
</asp:Content>

