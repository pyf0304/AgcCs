<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewShow.aspx.cs" Inherits="WebHtmlTest.WebForm.News.NewShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
     <link rel="stylesheet" type="text/css" href="../../css/news.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="r_content_m">
               <%-- <div class="l_content_m1">
                    <asp:Label ID="lblNewsName" runat="server" Text="信息详情"></asp:Label>
                </div>--%>
                <div class="l_content_m_5">

                    <div class="infor_title">

                        <asp:Label ID="lblNewsTitle" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="infor_date">
                        来源：<asp:Label ID="lblSource" runat="server" Text=""></asp:Label>

                        日期：<asp:Label ID="lblEditTime" runat="server" Text=""></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                        浏览次数：<asp:Label ID="lblViews" runat="server" Text=""></asp:Label>

                    </div>
                    <div class="infor_content">
                        <asp:Label ID="lblNewsContent" runat="server" Text=""></asp:Label>
                    </div>

                    <div style="height: 15px;">
                    </div>
                </div>
                <%--<div class="infor_news">
                    <div class="l_content_m_5_r_1">
                        <div class="b_title_txt">
                            相关资讯
                        </div>
                        <div class="b_title_more">
                            <a href="wfmNewsDetailList.aspx?ID=1">learn more>></a>
                        </div>
                    </div>
                    <div class="l_content_m_5_r_2">
                        <ul>
                            <asp:Repeater ID="rpTopNews" runat="server">
                                <ItemTemplate>
                                    <li><a href='NewShow.aspx?ID=1&IDNew=<%#Eval("Id_News") %>'>
                                        <%# Eval("NewsTitle") %></a></li>

                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                </div>--%>
            </div>
        </div>
    </form>
</body>
</html>
