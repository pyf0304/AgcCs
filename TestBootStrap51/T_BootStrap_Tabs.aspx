<%@ Page Language="vb" AutoEventWireup="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <script src="Scripts/popper.min.js"></script>
    <script src="Scripts/jquery-3.6.3.min.js"></script>
    <script type="text/javascript" src="./Scripts/bootstrap.min.js"></script>
    <link href="./Content/bootstrap.min.css" rel="stylesheet" />
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
                /*width: 90px;*/
            }

                .nav-tabs li a .glyphicon-remove-sign:hover {
                    color: red;
                    cursor: pointer;
                }

                .nav-tabs li a i:first-child {
                    margin-right: 3px;
                }

            /*.nav-tabs .active a {
                border-top: solid 2px #3498db !important;
                background: #3498db !important;*/
                /*color: #fff !important;*/
                /*color:red;
            }*/
            .nav-tabs >li>a .active  {
                color:red;
            }
              .nav-tabs  .active  {
                   border-top: solid 2px #3498db !important;
                background: #3498db !important;
                color: #fff !important;
            }
           .tab-content  .active a  {
                color:blue;
                font-size:20px;
            }
                .active  {
                color:red;
            }
        .nav > li > a {
            position: relative;
            display: block;
            padding: 5px 10px;
        }
    </style>
</head>

<body>
    <ul class="nav nav-pills">
        <li class="nav-item">
            <a class="nav-link active" aria-current="page" href="#">Active</a>
        </li>
        <li class="nav-item">
            <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item">
            <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item">
            <a class="nav-link disabled" href="#" tabindex="-1" aria-disabled="true">Disabled</a>
        </li>
    </ul>

    <div class="container1" style="width:100%;">

        <ul class="nav nav-tabs" role="navigation">
            <li d="liPrjTab_U" class="nav-item">
                <a class="nav-link" href="#Main_tab1" data-toggle="tab" role="tab">表属性</a>
            </li>

            <li id="liPrjTabFldCRUD" class="nav-item">
                <a class="nav-link" href="#Main_tab2" data-toggle="tab" role="tab" title="维护表的字段信息" aria-selected="false">表字段</a>
            </li>
            <li id="liPrjConstraintCRUDV2" class="nav-item">
                <a class="nav-link" href="#Main_tab3" data-toggle="tab" role="tab" title="维护表的相关约束" aria-selected="false">相关约束</a>
            </li>
            <li id="liTabFeatureCRUD" class="nav-item">
                <a class="nav-link active" href="#Main_tab4" data-toggle="tab" role="tab" title="维护表的相关功能" aria-selected="true">相关功能</a>
            </li>
            <li id="liCheckConsistency" class="nav-item">
                <a class="nav-link" href="#Main_tab5" onclick="btn_EditTabClick('CheckConsistency', '0173')" data-toggle="tab" role="tab" title="检查表与Sql中表的一致性">检查一致性</a>
            </li>
            <li id="liTabFunctionPropCRUD" class="nav-item">
                <a class="nav-link" href="#Main_tab6" onclick="btn_EditTabClick('TabFunctionProp', '0173')" data-toggle="tab" role="tab" title="维护与表相关的生成函数的属性">表函数属性</a>
            </li>
            <li id="liTabFunctionPropCRUD2" class="nav-item">
                <a class="nav-link" href="#Main_tab7" onclick="btn_EditTabClick('DataNodeFuncMap', '0173')" data-toggle="tab" role="tab" title="维护与表相关的结点与其他表的结点的映射关系">表人工智能函数</a>
            </li>
            <li id="liGeneTabCode" class="nav-item">
                <a class="nav-link" href="#Main_tab8" onclick="btn_EditTabClick('GeneCode', '0173')" data-toggle="tab" role="tab" title="生成与表相关的代码">生成代码</a>
            </li>
            <li id="liPrjTabCRUD" class="nav-item"> <a class="nav-link" href="#Main_tab9" onclick="btn_EditTabClick('ReturnToPrjTabCURD', '0173')" data-toggle="tab" role="tab" title="返回表的维护列表">返回上级</a></li>
                <li class="nav-item  ml-3">
                <label id="lblViewTitle" name="lblViewTitle" class="h6">视图名:vDataNode_Sim(00050592)</label>
            </li>
            <li class="nav-item ml-1">
                <a id="aEditRelaTab"></a>
            </li>
               <li id="liAddNewView" class="nav-item ml-1">
                <a id="aAddNewView"></a>
            </li>
            
        </ul>
        <div class="tab-content">
            <div class="tab-pane " id="Main_tab1">
                 AAA<br />
                BBBMain_tab1
            </div>
            <div class="tab-pane" id="Main_tab2">
                AAA<br />
                BBB22
            </div>
            <div class="tab-pane" id="Main_tab3">
                 AAA<br />
                BBB33
            </div>
            <div class="tab-pane active" id="Main_tab4">
               AAA<br />
                BBB44
                <br />
                <a href="#">超链接</a>
            </div>
            <div class="tab-pane" id="Main_tab5">
                AAA<br />
                BBB55
            </div>

            <div class="tab-pane" id="Main_tab6">
         AAA<br />
                BBB66
            </div>
            <div class="tab-pane" id="Main_tab7">
              AAA<br />
                BBB77
            </div>
            <div class="tab-pane" id="Main_tab8">
       AAA<br />
                BBB88
            </div>
            <div class="tab-pane" id="Main_tab9">
            </div>
        </div>
    </div>
</body>
</html>
