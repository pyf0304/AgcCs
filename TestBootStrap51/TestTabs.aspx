<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>


    <link rel="stylesheet" href="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://cdn.staticfile.org/jquery/2.1.1/jquery.min.js"></script>
    <script src="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style>
        .nav-tabs {
            background: #FFFFFF;
            border-bottom: 3px #3498db solid;
        }


            .nav-tabs li a {
                /*line-height:2;*/
                border: 1px #ddd solid;
                margin-right: -1px;
                color: #999;
                border-radius: 0;
                width: 90px;
            }

                .nav-tabs li a .glyphicon-remove-sign:hover {
                    color: red;
                    cursor: pointer;
                }

                .nav-tabs li a i:first-child {
                    margin-right: 3px;
                }

            .nav-tabs .active a {
                border-top: solid 2px #3498db !important;
                background: #3498db !important;
                color: #fff !important;
            }

        .nav > li > a {
            position: relative;
            display: block;
            padding: 5px 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="tabbable" style="float: left; width: 100%">
                <ul class="nav nav-tabs">
                    <li class="active"><a href="#tab1" data-toggle="tab">查询区</a></li>
                    <li><a href="#tab2" data-toggle="tab">功能区</a></li>
                    <li><a href="#tab3" data-toggle="tab">列表区</a></li>
                    <li><a href="#tab4" data-toggle="tab">编辑区</a></li>
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
    </form>
</body>
</html>
