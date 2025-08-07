<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestTabs3.aspx.cs" Inherits="AGC.Webform.A_Samples.TestTabs3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>

    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />

    <style>
        .myRed {
            color: red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <asp:Label ID="lblTest" CssClass="<% =TabClass() %>" runat="server">TabClass</asp:Label>
            <asp:Label ID="Label10" CssClass="<%=TabClass() %>" runat="server">TabClass</asp:Label>
            <asp:Label ID="Label9" CssClass="myRed" runat="server"><%=TabClass %>TabClass</asp:Label>
            <div class="container">
                <ul class="nav nav-tabs" role="navigation">
                    <li class="<%=CurrTabClass(0) %>"><a class="nav-link active" href="#tab1" data-toggle="tab" role="tab">查询区</a></li>

                    <%--<li id="li1" runat="server" class="nav-item active"><a class="nav-link active" href="#tab1" data-toggle="tab" role="tab">查询区</a></li>
                    --%>
                    <li class="<%=CurrTabClass(1) %>"><a class="nav-link" href="#tab2" data-toggle="tab" role="tab">功能区</a>                        </li>
                    <li class="<%=CurrTabClass(2) %>"><a class="nav-link" href="#tab3" data-toggle="tab" role="tab">列表区</a>                     </li>
                    <li class="<%=CurrTabClass(3) %>"><a class="nav-link" href="#tab4" data-toggle="tab" role="tab">编辑区</a></li>
                </ul>
                <div class="tab-content">
                    <div class="tab-pane active" id="tab1">
                        <div class="panel panel-default">
                            <asp:Label ID="Label1" runat="server" Text="查询区"></asp:Label>
                            <asp:Label ID="Label2" runat="server" Text="查询区"></asp:Label>
                        </div>
                    </div>
                    <div class="tab-pane" id="tab2">

                        <div class="panel panel-default">
                            <asp:Label ID="Label3" runat="server" Text="功能区"></asp:Label>
                            <asp:Label ID="Label4" runat="server" Text="功能区"></asp:Label>

                        </div>
                    </div>
                    <div class="tab-pane" id="tab3">

                        <div class="panel panel-default">
                            <asp:Label ID="Label5" runat="server" Text="列表区"></asp:Label>
                            <asp:Label ID="Label6" runat="server" Text="列表区"></asp:Label>

                        </div>
                    </div>
                    <div class="tab-pane" id="tab4">

                        <div class="panel panel-default">
                            <asp:Label ID="Label7" runat="server" Text="编辑区"></asp:Label>
                            <asp:Label ID="Label8" runat="server" Text="编辑区"></asp:Label>

                        </div>
                    </div>
                </div>
            </div>

        </div>
         <div class="container">
                <ul class="nav nav-tabs" role="navigation">
                    <li class="nav-item active"><a class="nav-link active" href="#tab11" data-toggle="tab" role="tab">查询区</a></li>

                    <%--<li id="li1" runat="server" class="nav-item active"><a class="nav-link active" href="#tab1" data-toggle="tab" role="tab">查询区</a></li>
                    --%>
                    <li class="nav-item"><a class="nav-link" href="#tab22" data-toggle="tab" role="tab">功能区</a>                        </li>
                    <li class="nav-item"><a class="nav-link" href="#tab33" data-toggle="tab" role="tab">列表区</a>                     </li>
                    <li class="nav-item"><a class="nav-link" href="#tab44" data-toggle="tab" role="tab">编辑区</a></li>
                </ul>
                <div class="tab-content">
                    <div class="tab-pane active" id="tab11">
                        <div class="panel panel-default">
                            <asp:Label ID="Label11" runat="server" Text="查询区"></asp:Label>
                            <asp:Label ID="Label12" runat="server" Text="查询区"></asp:Label>
                        </div>
                    </div>
                    <div class="tab-pane" id="tab22">

                        <div class="panel panel-default">
                            <asp:Label ID="Label13" runat="server" Text="功能区"></asp:Label>
                            <asp:Label ID="Label14" runat="server" Text="功能区"></asp:Label>

                        </div>
                    </div>
                    <div class="tab-pane" id="tab33">

                        <div class="panel panel-default">
                            <asp:Label ID="Label15" runat="server" Text="列表区"></asp:Label>
                            <asp:Label ID="Label16" runat="server" Text="列表区"></asp:Label>

                        </div>
                    </div>
                    <div class="tab-pane" id="tab44">

                        <div class="panel panel-default">
                            <asp:Label ID="Label17" runat="server" Text="编辑区"></asp:Label>
                            <asp:Label ID="Label18" runat="server" Text="编辑区"></asp:Label>

                        </div>
                    </div>
                </div>
            </div>

        <div>
            <nav class="navbar navbar-default navbar-fixed-top" role="navigation">
                <div class="container-fluid">
                    <div class="navbar-header">
                        <a class="navbar-brand" href="#">菜鸟教程</a>
                    </div>
                    <div>
                        <ul class="nav navbar-nav">
                            <li class="active"><a href="#">iOS</a></li>
                            <li><a href="#">SVN</a></li>
                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Java <b class="caret"></b>
                                </a>
                                <ul class="dropdown-menu">
                                    <li><a href="#">jmeter</a></li>
                                    <li><a href="#">EJB</a></li>
                                    <li><a href="#">Jasper Report</a></li>
                                    <li class="divider"></li>
                                    <li><a href="#">分离的链接</a></li>
                                    <li class="divider"></li>
                                    <li><a href="#">另一个分离的链接</a></li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </div>
    </form>
</body>
</html>
