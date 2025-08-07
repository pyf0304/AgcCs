<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewList.aspx.cs" Inherits="WebHtmlTest.WebForm.News.NewList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" type="text/css" href="../../css/news.css" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="r_content_m">
            <%--  <div class="l_content_m1">
                <asp:Label ID="lblNewsName" runat="server" Text="新闻列表"></asp:Label>
            </div>--%>
            <div class="l_content_m_4">
                <asp:Repeater ID="rpNewsNotIstop" runat="server">
                    <ItemTemplate>

                        <div class="second_news_list">
                            <ul>
                                <li><span><%#string.Format("{0:d}",Eval("EditTime")) %></span>
                                    <a class="news" href='NewShow.aspx?ID=<%# Eval("NewsTypeId") %>&IDNew=<%#Eval("Id_News") %>' target="_self"><%#Eval("NewsTitle") %></a></li>
                            </ul>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>


                <%-- 分页 --%>
                <div class="page">
                    <div class="pageEntry">
                        每页显示<asp:Label ID="Label4" runat="server" ForeColor="Red"
                            Style="font-weight: bold" Text="10"></asp:Label>条信息共有
                        <font color="red"><b><asp:Literal ID="ltRecordCount" runat="server">0</asp:Literal></b></font>
                        条记录 当前是第：<asp:Label ID="Labelye" runat="server" Font-Bold="True"
                            ForeColor="Red" Text="1"></asp:Label>/
                <asp:Label ID="lblPageCount" runat="server" Font-Bold="True"
                    ForeColor="Red">0</asp:Label>页
                    </div>

                    <div class="pageChange">
                        <asp:LinkButton ID="lbtn_One" runat="server" Text="首页" OnClick="lbtn_One_Click"></asp:LinkButton>
                        <asp:LinkButton ID="lbtn_Up" runat="server" Text="上一页" OnClick="lbtn_Up_Click"></asp:LinkButton>
                        <asp:LinkButton ID="lbtn_Next" runat="server" Text="下一页" OnClick="lbtn_Next_Click"></asp:LinkButton>
                        <asp:LinkButton ID="lbtn_End" runat="server" Text="尾页" OnClick="lbtn_End_Click"></asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
