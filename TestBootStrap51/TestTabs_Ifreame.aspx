<%@ Page Language="C#" AutoEventWireup="true"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
        
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script>
        function ShowHome() {
            $('#myTab li:eq(0) a').tab('show');
        }
        function ShowContent(myIndex) {
            var content = document.getElementsByName("content")[0];
            var lis = document.querySelectorAll("#example3 li");
            var len = lis.length;
            var src = ["TestTabs_JS.aspx", "tab.html", "TestTabs3.aspx", "TestTabs2.aspx"]//将地址存入数组
            content.setAttribute("src", src[myIndex]);

            //ifr
            //$('#myTab li:eq(3) a').tab('show');
        }
    </script>
    <style>
        iframe {
            width: 100%;
            min-width:1020px;
            height: 100%;
            min-height:600px;
            border: none;
            background: none;

        }
         /*.myiframe {
            width: 100%;
            height: 100%;
            border: none;
            background: none;
        }*/
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <div class="container">
                <ul id="myTab" class="nav nav-tabs" role="tablist">
                    <li class="nav-item active"><a class="nav-link active" href="#tab1" onclick="ShowContent(0);" role="tab">查询区</a></li>

                    <li class="nav-item"><a class="nav-link" href="#tab2" onclick="ShowContent(1);" role="tab">功能区</a>                        </li>
                    <li class="nav-item"><a class="nav-link" href="#tab3" onclick="ShowContent(2);" role="tab">列表区</a>                     </li>
                    <li class="nav-item"><a class="nav-link" href="#tab4" onclick="ShowContent(3);" role="tab">编辑区</a></li>
                </ul>
                <iframe id="myIframe" src="TestTabs_JS.aspx" name="content" class="myiframe"></iframe>

            </div>

        </div>
        <script>

            $(function () {
                $('#myTab a:last').tab('show');//初始化显示哪个tab

                $('#myTab a').click(function (e) {
                    e.preventDefault();//阻止a链接的跳转行为
                    $(this).tab('show');//显示当前选中的链接及关联的content
                })
            })

            // 通过名称选取标签页

//      $('#myTab a[href="#profile"]').tab('show')  

//// 选取第一个标签页  

//      $('#myTab a:first').tab('show')   

//      // 选取最后一个标签页  

//      $('#myTab a:last').tab('show')    

//// 选取第三个标签页（从 0 开始索引）  

//      $('#myTab li:eq(2) a').tab('show')
        </script>
    </form>
</body>
</html>
