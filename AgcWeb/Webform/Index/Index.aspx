<%@ Page Title="自动生成代码2021版" Language="C#" MasterPageFile="~/Webform/MasterPage/Main1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AGC.Index" %>

<asp:Content ID="Content4Head" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../../css/news.css" rel="stylesheet" type="text/css" />
    <%--<link href="../../css/menu.css" rel="stylesheet" type="text/css" />--%>
    <link href="../../css/tz_base1.css" rel="stylesheet" />
    <style>
        /** {
            margin: 0;
            border: 0;
            padding: 0;
            font-size: 13pt;
        }

        #nav {
            height: 40px;
            width: 350px;
            border-top: #060 2px solid;
            margin-top: 100px;
            border-bottom: #060 2px solid;
            background-color: #690;
        }

            #nav ul {
                list-style: none;
                line-height: 40px;
                margin-left: 50px;
            }

            #nav li {
                display: block;
                float: left;
            }

            #nav a {
                display: block;
                color: #fff;
                text-decoration: none;
                padding: 0 20px;
            }

                #nav a:hover {
                    background-color: #060;
                }*/
        /** {
            margin: 0;
            border: 0;
            padding: 0;
            font-size: 13pt;
        }

        #nav {
            height: 40px;
            border-top: #060 2px solid;
            border-bottom: #060 2px solid;
            background-color: #690;
        }

            #nav ul {
                list-style: none;
                margin-left: 50px;
            }

            #nav li {
                display: inline;
                line-height: 40px;
            }

            #nav a {
                color: #fff;
                text-decoration: none;
                padding: 20px 20px;
            }

                #nav a:hover {
                    background-color: #060;
                }*/
    </style>

</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="login" style="width: 450px">
        <!-- <h3>自动生成代码2016版</h3> -->
        <div class="form">
            <label>帐号</label>
            <asp:TextBox ID="txtUid" TabIndex="1" runat="server"></asp:TextBox>

        </div>
        <div class="form">
            <label>密码</label>
            <asp:TextBox ID="txtPassWord" Style="z-index: 103;"
                TabIndex="2" runat="server" TextMode="Password" AutoCompleteType="Disabled" autocomplete="off"></asp:TextBox>

        </div>
        <div class="loginform1">
            <asp:Button ID="btnLogin" CssClass="loginbutton1" runat="server" Text="登&nbsp;&nbsp;&nbsp;&nbsp;录" OnClick="btnLogin_Click" />
        </div>
        <div class="btnMore">
            <a href="../UserManage/wfmRegister.aspx">注册</a>
            &nbsp;<a href="../DownLoad/wfmDownLoadClsFile.aspx?ParentPage=HomePage">文件下载</a>
            <a href="../News/NewTest.aspx" class="text-nowrap">公告知识查看</a>
            <a href="../Test/TestBrowserInfo.aspx" class="text-nowarp" style="width: 100px;">浏览器类型</a>

        </div>
    </div>

</asp:Content>
