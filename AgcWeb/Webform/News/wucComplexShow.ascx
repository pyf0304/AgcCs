<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucComplexShow.ascx.cs"
    Inherits="Webtaisoft.Web.wucComplexShow" %>

<link rel="stylesheet" href="../../Content/bootstrap.min.css">
<link rel="stylesheet" href="../../css/font-awesome.min.css">
<script src="../../Scripts/jquery-3.6.0.min.js"></script>
<script type="text/javascript" src="../../js/layui/layui.js"></script>
<script type="text/javascript" src="../../js/xadmin.js"></script>

<style type="text/css">
    .body {
        /*background-color: #e6e6e6;*/
    }

    a {
        color: #475059;
    }

    a {
        /* color: #337ab7; */
        text-decoration: none;
    }

    a {
        /* background-color: transparent; */
    }

    .rows {
        margin-top: 10px;
        margin-left: 10px;
        margin-right: 10px;
    }

    .panel-default {
        border: none;
        border-radius: 0px;
        margin-bottom: 0px;
        box-shadow: none;
        -webkit-box-shadow: none;
    }

        .panel-default > .panel-heading {
            color: #777;
            background-color: #e6e6e6;
            border-color: #e6e6e6;
            /*border-bottom: 1px solid;*/
            padding: 10px 10px;
        }

        .panel-default > .panel-body {
            padding: 10px;
            padding-bottom: 0px;
        }

            .panel-default > .panel-body ul {
                overflow: hidden;
                padding: 0;
                margin: 0px;
                margin-top: -5px;
            }

                .panel-default > .panel-body ul li {
                    line-height: 27px;
                    list-style-type: none;
                    white-space: nowrap;
                    text-overflow: ellipsis;
                }

                    .panel-default > .panel-body ul li .time {
                        color: #a1a1a1;
                        float: right;
                        padding-right: 5px;
                    }
</style>
<div class="body">
    <div class="rows" style="overflow: hidden;">
        <div style="float: left; width: 33.8%; margin-right: 0.8%;">
            <div style="height: 240px; border: 1px solid #e6e6e6; background-color: #fff;">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <i class="fa fa-send fa-lg" style="padding-right: 5px;"></i>WebForm
                    <div style="float: right;"><a href="#" onclick="x_admin_show('WebForm列表','NewList.aspx?ID=1',1000,600)">MORE...</a></div>
                      
                    </div>
                    <div class="panel-body">
                        <ul>
                            <asp:Repeater ID="rpWebForm" runat="server">
                                <ItemTemplate>
                                    <li>
                                        <a class="news" href="#" onclick="x_admin_show('<%#Eval("NewsTitle") %>','NewShow.aspx?ID=1&IDNew=<%#Eval("Id_News") %>',1200,700)">
                                            <%#Eval("NewsTitle") %></a>
                                        <span class="time">[<%#string.Format("{0:d}",Eval("EditTime")) %>]</span>
                                    </li>
                                   
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div style="float: left; width: 34.6%; margin-right: 0.8%;">
            <div style="height: 240px; border: 1px solid #e6e6e6; background-color: #fff;">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <i class="fa fa-rss fa-lg" style="padding-right: 5px;"></i>MVC
                         <div style="float: right;"><a href="#" onclick="x_admin_show('MVC列表','NewList.aspx?ID=2',1000,600)">MORE...</a></div>
                    </div>
                    <div class="panel-body">
                        <ul>
                            <asp:Repeater ID="rpMVC" runat="server">
                                <ItemTemplate>
                                    <li>
                                        <a class="news" href="#" onclick="x_admin_show('<%#Eval("NewsTitle") %>','NewShow.aspx?ID=2&IDNew=<%#Eval("Id_News") %>',1200,700)"><%#Eval("NewsTitle") %></a>
                                        <span class="time">[<%#string.Format("{0:d}",Eval("EditTime")) %>]</span>
                                    </li>
                                </ItemTemplate>

                            </asp:Repeater>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div style="float: right; width: 30%;">
            <div style="height: 240px; border: 1px solid #e6e6e6; background-color: #fff;">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <i class="fa fa-thumbs-o-up fa-lg" style="padding-right: 5px;"></i>Core
                         <div style="float: right;"><a href="#" onclick="x_admin_show('Core列表','NewList.aspx?ID=3',1000,600)">MORE...</a></div>
                    </div>
                    <div class="panel-body">
                        <ul>
                            <asp:Repeater ID="rpCore" runat="server">
                                <ItemTemplate>
                                    <li>
                                        <a class="news" href="#" onclick="x_admin_show('<%#Eval("NewsTitle") %>','NewShow.aspx?ID=3&IDNew=<%#Eval("Id_News") %>',1200,700)"><%#Eval("NewsTitle") %></a>
                                        <span class="time">[<%#string.Format("{0:d}",Eval("EditTime")) %>]</span>
                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="rows" style="overflow: hidden;">
        <div style="float: left; width: 33.8%; margin-right: 0.8%;">
            <div style="height: 240px; border: 1px solid #e6e6e6; background-color: #fff;">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <i class="fa fa-send fa-lg" style="padding-right: 5px;"></i>Android
                    <div style="float: right;"><a href="#" onclick="x_admin_show('Android列表','NewList.aspx?ID=4',1000,600)">MORE...</a></div>
                    </div>
                    <div class="panel-body">
                        <ul>
                            <asp:Repeater ID="rpAndroid" runat="server">
                                <ItemTemplate>
                                    <li>
                                        <a class="news" href="#" onclick="x_admin_show('<%#Eval("NewsTitle") %>','NewShow.aspx?ID=4&IDNew=<%#Eval("Id_News") %>',1200,700)"><%#Eval("NewsTitle") %></a>
                                        <span class="time">[<%#string.Format("{0:d}",Eval("EditTime")) %>]</span>
                                    </li>
                                </ItemTemplate>

                            </asp:Repeater>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div style="float: left; width: 34.6%; margin-right: 0.8%;">
            <div style="height: 240px; border: 1px solid #e6e6e6; background-color: #fff;">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <i class="fa fa-rss fa-lg" style="padding-right: 5px;"></i>ios
                         <div style="float: right;"><a href="#" onclick="x_admin_show('ios列表','NewList.aspx?ID=5',1000,600)">MORE...</a></div>
                    </div>
                    <div class="panel-body">
                        <ul>
                            <asp:Repeater ID="rpIos" runat="server">
                                <ItemTemplate>
                                    <li>
                                        <a class="news" href="#" onclick="x_admin_show('<%#Eval("NewsTitle") %>','NewShow.aspx?ID=5&IDNew=<%#Eval("Id_News") %>',1200,700)"><%#Eval("NewsTitle") %></a>
                                        <span class="time">[<%#string.Format("{0:d}",Eval("EditTime")) %>]</span>
                                    </li>
                                </ItemTemplate>

                            </asp:Repeater>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

        <div style="float: right; width: 30%;">
            <div style="height: 240px; border: 1px solid #e6e6e6; background-color: #fff;">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <i class="fa fa-thumbs-o-up fa-lg" style="padding-right: 5px;"></i>WebService
                         <div style="float: right;"><a href="#" onclick="x_admin_show('WebService列表','NewList.aspx?ID=6',1000,600)">MORE...</a></div>
                    </div>
                    <div class="panel-body">
                        <ul>
                            <asp:Repeater ID="rpWebService" runat="server">
                                <ItemTemplate>
                                    <li>
                                        <a class="news" href="#" onclick="x_admin_show('<%#Eval("NewsTitle") %>','NewShow.aspx?ID=6&IDNew=<%#Eval("Id_News") %>',1200,700)"><%#Eval("NewsTitle") %></a>
                                        <span class="time">[<%#string.Format("{0:d}",Eval("EditTime")) %>]</span>
                                    </li>
                                </ItemTemplate>

                            </asp:Repeater>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="rows" style="overflow: hidden;">
        <div style="float: left; width: 33.8%; margin-right: 0.8%;">
            <div style="height: 240px; border: 1px solid #e6e6e6; background-color: #fff;">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <i class="fa fa-send fa-lg" style="padding-right: 5px;"></i>javascript
                    <div style="float: right;"><a href="#" onclick="x_admin_show('javascript列表','NewList.aspx?ID=7',1000,600)">MORE...</a></div>
                    </div>
                    <div class="panel-body">
                        <ul>
                            <asp:Repeater ID="rpjavascript" runat="server">
                                <ItemTemplate>
                                    <li>
                                        <a class="news" href="#" onclick="x_admin_show('<%#Eval("NewsTitle") %>','NewShow.aspx?ID=7&IDNew=<%#Eval("Id_News") %>',1200,700)"><%#Eval("NewsTitle") %></a>
                                        <span class="time">[<%#string.Format("{0:d}",Eval("EditTime")) %>]</span>
                                    </li>
                                </ItemTemplate>

                            </asp:Repeater>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div style="float: left; width: 34.6%; margin-right: 0.8%;">
            <div style="height: 240px; border: 1px solid #e6e6e6; background-color: #fff;">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <i class="fa fa-rss fa-lg" style="padding-right: 5px;"></i>typescript
                         <div style="float: right;"><a href="#" onclick="x_admin_show('typescript列表','NewList.aspx?ID=8',1000,600)">MORE...</a></div>
                    </div>
                    <div class="panel-body">
                        <ul>
                            <asp:Repeater ID="rptypescript" runat="server">
                                <ItemTemplate>
                                    <li>
                                        <a class="news" href="#" onclick="x_admin_show('<%#Eval("NewsTitle") %>','NewShow.aspx?ID=8&IDNew=<%#Eval("Id_News") %>',1200,700)"><%#Eval("NewsTitle") %></a>
                                        <span class="time">[<%#string.Format("{0:d}",Eval("EditTime")) %>]</span>
                                    </li>
                                </ItemTemplate>

                            </asp:Repeater>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

        <div style="float: right; width: 30%;">
            <div style="height: 240px; border: 1px solid #e6e6e6; background-color: #fff;">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <i class="fa fa-thumbs-o-up fa-lg" style="padding-right: 5px;"></i>WebApi
                         <div style="float: right;"><a href="#" onclick="x_admin_show('WebApi列表','NewList.aspx?ID=9',1000,600)">MORE...</a></div>
                    </div>
                    <div class="panel-body">
                        <ul>
                            <asp:Repeater ID="rpWebApi" runat="server">
                                <ItemTemplate>
                                    <li>
                                        <a class="news" href="#" onclick="x_admin_show('<%#Eval("NewsTitle") %>','NewShow.aspx?ID=9&IDNew=<%#Eval("Id_News") %>',1200,700)"><%#Eval("NewsTitle") %></a>
                                        <span class="time">[<%#string.Format("{0:d}",Eval("EditTime")) %>]</span>
                                    </li>
                                </ItemTemplate>

                            </asp:Repeater>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

</div>





