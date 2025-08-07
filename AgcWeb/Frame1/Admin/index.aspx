<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="FrameSet.Frame1.Admin.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width,initial-scale=1,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no" />
    <meta name="renderer" content="webkit|ie-comp|ie-stand"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>
    <meta http-equiv="Cache-Control" content="no-siteapp" />
    <meta name="keywords" content="scclui框架"/>
    <meta name="description" content="自动生成代码系统"/>
    <title>首页--自动生成代码系统</title>

    <link rel="stylesheet" href="common/css/sccl.css"/>
    <link rel="stylesheet" type="text/css" href="common/skin/qingxin/skin.css" id="layout-skin" />

    <script type="text/javascript">
        function ChangePassword() {
            var returnValue = window.open('../../Webform/UserManage/wfmChangePwd.aspx',
                '修改口令',
                'width=380px,height=220px,top=150px,left=350px,scrollbars=no,toolbar=no,menubar=no, scrollbars=no, resizable=no, location=no, status=no,titlebar=no,');
        }

       
        function SwitchPrj(strFunName, strMid) {
            //if (event.keyCode == 13) {
            //event.cancelBubble = true;
            //event.returnValue = false;
            document.all.FunName.value = strFunName;// "enter";
            document.all.hidMid.value = strMid;

            document.forms[0].submit();
            //}
        }
    </script>
      <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="layout-admin">
            <header class="layout-header">
                <span class="header-logo">自动生成代码系统</span>
                <a class="header-menu-btn" href="javascript:;"><i class="icon-font">&#xe600;</i></a>
                <ul class="header-bar">
                    <li class="header-bar-role"><a href="javascript:;">
                        <asp:Label ID="lblRoleName" runat="server" Text="超级管理员"></asp:Label></a></li>
                    <li class="header-bar-nav">
                        <a href="javascript:;">
                            <asp:Label ID="lblUserName" runat="server" Text="超级管理员"></asp:Label><i class="icon-font" style="margin-left: 5px;">&#xe60c;</i></a>
                        <ul class="header-dropdown-menu">
                            <li><a href="javascript:ChangePassword();">修改口令</a></li>
                            <li><a href="javascript:;">切换账户</a></li>
                            <li>
                                <asp:LinkButton ID="lbLogout" OnClick="lbLogout_Click" runat="server">退出</asp:LinkButton>
                            </li>
                        </ul>
                    </li>
                    <li class="header-bar-nav">
                        <a href="javascript:;">
                            <asp:Label ID="lblCurrProject" runat="server" Text="工程"></asp:Label>
                            <i class="icon-font" style="margin-left: 5px;">&#xe60c;</i></a>
                        <ul id="ulPrjList" class="header-dropdown-menu" runat="server">
                            <li><a href="./wfmSelectProject.aspx">切换项目</a></li>

                            <li><a href="javascript:;">退出</a></li>
                        </ul>
                    </li>
                      <li class="header-bar-nav">
                        <a href="javascript:;" title="功能"><asp:Label ID="Label1" runat="server" Text="功能"></asp:Label>
                            <i class="icon-font">&#xe60c;</i></a>
                        <ul class="header-dropdown-menu right dropdown-skin">
             
                            <li><a href="../../Webform/DownLoad/wfmDownLoadClsFile.aspx?ParentPage=FrameSet" >下载文档</a></li>
             

                        </ul>
                    </li>
                    <li class="header-bar-nav">
                        <a href="javascript:;" title="换肤"><i class="icon-font">&#xe608;</i></a>
                        <ul class="header-dropdown-menu right dropdown-skin">
                            <li><a href="javascript:;" data-val="qingxin" title="清新">清新</a></li>
                            <li><a href="javascript:;" data-val="blue" title="蓝色">蓝色</a></li>
                            <li><a href="javascript:;" data-val="molv" title="墨绿">墨绿</a></li>

                        </ul>
                    </li>
                </ul>
            </header>
            <!--<aside class="layout-side">
            <ul class="side-menu"></ul>
             </aside>-->
            <aside class="layout-side">
                <ul id="ulPARENT" class="side-menu" runat="server">
                    <%-- <li class="menu-header menu-item">主菜单</li>--%>


                    <%-- 下面的菜单文件可以动态生成 --%>
                    <%--<li class="menu-item">
                        <a href=""><i class="icon-font "></i><span>主菜单一</span><i class="icon-font icon-right"></i></a>
                        <ul class="menu-item-child" id="menu-child-3" style="display: none;">
                            <li>
                                <a href="test1.html">
                                    <i class="icon-font"></i>
                                    <span>子菜单1</span>
                                </a>
                            </li>
                            <li>
                                <a href="test2.html">
                                    <i class="icon-font"></i>
                                    <span>子菜单2</span>
                                </a>
                            </li>
                        </ul>
                    </li>
                    <li class="menu-item">
                        <a href="">
                            <i class="icon-font "></i>
                            <span>主菜单二</span><i class="icon-font icon-right"></i>
                        </a>
                        <ul class="menu-item-child" id="menu-child-6">
                            <li>
                                <a href="home3.html">
                                    <i class="icon-font"></i>
                                    <span>子菜单3</span>
                                </a>
                            </li>
                            <li>
                                <a href="home4.html">
                                    <i class="icon-font"></i>
                                    <span>子菜单5</span>
                                </a>
                            </li>
                        </ul>
                    </li>--%>

                    <%-- 多级菜单如用不上可暂时屏蔽掉 --%>
                    <%-- <li class="menu-header menu-item">多级菜单</li>
                    <li class="menu-item"><a href=""><i class="icon-font"></i><span>新功能</span></a></li>
                    <li class="menu-item"><a href=""><i class="icon-font "></i><span>多级</span><i class="icon-font icon-right"></i></a><ul class="menu-item-child" id="menu-child-10">
                        <li><a href=""><i class="icon-font"></i><span>一级</span></a></li>
                        <li><a href=""><i class="icon-font "></i><span>一级</span><i class="icon-font icon-right"></i></a><ul class="menu-item-child" id="menu-child-12">
                            <li><a href=""><i class="icon-font"></i><span>二级</span></a></li>
                            <li><a href=""><i class="icon-font "></i><span>二级</span><i class="icon-font icon-right"></i></a><ul class="menu-item-child" id="menu-child-14">
                                <li><a href=""><i class="icon-font"></i><span>三级</span></a></li>
                                <li><a href=""><i class="icon-font "></i><span>三级</span><i class="icon-font icon-right"></i></a><ul class="menu-item-child" id="menu-child-16">
                                    <li><a href=""><i class="icon-font"></i><span>四级</span></a></li>
                                    <li><a href=""><i class="icon-font"></i><span>四级</span></a></li>
                                </ul>
                                </li>
                            </ul>
                            </li>
                        </ul>
                        </li>
                    </ul>
                    </li>--%>
                </ul>
            </aside>

            <div class="layout-side-arrow">
                <div class="layout-side-arrow-icon"><i class="icon-font">&#xe60d;</i></div>
            </div>

            <section class="layout-main">
                <div class="layout-main-tab">
                    <button class="tab-btn btn-left"><i class="icon-font">&#xe60e;</i></button>
                    <nav class="tab-nav">
                        <div class="tab-nav-content">
                            <a href="javascript:;" class="content-tab active" data-id="home.aspx">首页</a>
                        </div>
                    </nav>
                    <button class="tab-btn btn-right"><i class="icon-font">&#xe60f;</i></button>
                </div>
                <div class="layout-main-body">
                    <iframe class="body-iframe" name="iframe0" style="width:100%; height:99%; border:none" src="home.aspx" data-id="home.aspx" seamless></iframe>
                </div>
            </section>
            <div class="layout-footer">Copyright Right © 2016-2017 设计制作：上海泰泽信息技术有限公司 </div>
        </div>

        <script src="../../Scripts/jquery-3.6.0.min.js"></script>
        <script type="text/javascript" src="common/js/sccl.js"></script>
        <script type="text/javascript" src="common/js/sccl-util.js"></script>
        <input type="hidden" name="FunName" />
        <input type="hidden" name="hidMid" />
    </form>
</body>
</html>
