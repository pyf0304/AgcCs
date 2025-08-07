<%@ Page Language="C#" AutoEventWireup="True" MasterPageFile="~/Webform/MasterPage/Main1.Master"
    CodeBehind="wfmRegisterBak20170407.aspx.cs" Inherits="AGC.Webform.wfmRegisterBak20170407" %>
<%@ Register Src="RegisterUser.ascx" TagName="RegisterUser" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../css/news.css" rel="stylesheet" type="text/css" />
        <link href="../../css/menu.css" rel="stylesheet" type="text/css" />
    
    <div class="center">
        <div class="main_div1">
            <div class="top1">
                <div class="top_left1">
                </div>
                <div class="top_center1">
                </div>
                <div class="top_right1">
                </div>
            </div>
            <div class="title1">
                <div class="title_left1">
                </div>
                <div class="title_center1">
                    <div class="title" style="margin-left:200px">
                        <asp:Label ID="Label1" runat="server" Text="用户注册"></asp:Label>
                    </div>
                </div>
                <div class="title_right1">
                </div>
            </div>
            <div class="content1">
                <div class="content_left1">
                </div>
                <div class="content_center1">

                    <uc2:RegisterUser ID="RegisterUser1" runat="server" />

                </div>
                <div class="content_right1">
                </div>
            </div>
            <div class="bottom1">
                <div class="bottom_left1">
                </div>
                <div class="bottom_center1">
                </div>
                <div class="bottom_right1">
                </div>
            </div>
        </div>
    </div>

</asp:Content>

