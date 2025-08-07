<%@ Page Language="C#" AutoEventWireup="True" MasterPageFile="~/Webform/MasterPage/Main1.Master"
    CodeBehind="wfmRegister.aspx.cs" Inherits="AGC.Webform.wfmRegister" %>

<%@ Register Src="RegisterUser.ascx" TagName="RegisterUser" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <link href="../../css/news.css" rel="stylesheet" type="text/css" />
    <link href="../../css/menu.css" rel="stylesheet" type="text/css" />
    
    <div class="register">
        <legend>用户注册</legend>
        <div>
            <uc2:RegisterUser ID="RegisterUser1" runat="server" />
        </div>
    </div>
</asp:Content>

