<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <%--<link href="./Content/bootstrap.css" rel="stylesheet" />--%>
    <%--<link href="../css/VisualEffects.css" rel="stylesheet" />--%>
    <script type="text/javascript" src="./Scripts/bootstrap.min.js"></script>
    <link href="./Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <h3>表单控件</h3>
    <textarea></textarea>
    <span class="h4 text-info">可视化区域</span>
    <div>
        <div id="left1" class="float-left"></div>
        <div id="right1" class="float-right"></div>
    </div>
    <div class="myBorder" style="width: 300px; height: 100px;">
        <span>abc</span>
        <br />
        <span>ab1c<br />
            bbb</span>
    </div>
    <div>
        <ul id="ul00024243" class="nav">
            <li class="nav-item ml-2 mr-2" id="li_Arraw_00024243">
                <div class="border-danger NodeRelation">
                    <span class="text-primary">1.函数-equal</span><br>
                    <span class="text-primary">==&gt;</span>
                    <button id="btnDelMap00024243" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                </div>
            </li>
            <li class="nav-item" id="liSub_00050023_00050794"><span class="RelaTabNode"><a class="text-primary" title="单击可以编辑该表的函数映射.">DataTypeAbbr</a><br>
                <span class="text-danger">DataTypeId</span></span></li>
            <li class="nav-item" id="liSub_Pa_00050023_00050794">
                <ul id="ul00050023_00050794" class="nav">
                    <li class="nav-item ml-2 mr-2" id="li_Arraw_00024108">
                        <div class="border-danger NodeRelation">
                            <span class="text-primary">1.表-DataTypeAbbr</span><br>
                            <span class="text-primary">==&gt;</span>
                            <button id="btnDelMap00024108" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                        </div>
                    </li>
                    <li class="nav-item" id="liSub_00050023_00050238"></li>
                    <li class="nav-item" id="liSub_00050023_00050238"><span class="RelaTabNode"><a class="text-primary" title="单击可以编辑该表的函数映射.">DataTypeAbbr</a><br>
                        <span class="text-danger">DataTypeName</span></span></li>
                </ul>
            </li>
        </ul>
    </div>
    <table>
        <tr>
            <td class="SelectTd">111</td>
            <td class="border-danger">222</td>
            <td class="SelectTd" style="width: 100px;">333</td>
            <td class="danger border border-danger">444</td>
            <td class="border border-danger text-">444</td>
        </tr>
    </table>
    <input id="Checkbox1" type="checkbox" value="纯Html控件-Checkbox1" />
    <div id="form2" style="width: 800px">

        <div class="form-group">
            <label class="col-3">title-abc1111</label>
            <input type="text" class="form-control col-9" />
        </div>
        <div class="form-group">
            <label class="col-3">title-abc</label>
            <input type="text" class="form-control col-9" />
        </div>


    </div>

    <div>
        <ul class="list-unstyled">
            <li>aaa1</li>
            <li>aaa2</li>
            <li>aaa3</li>
        </ul>
    </div>
    <div>
        <ul class="list-group-horizontal">
            <li>aaa1</li>
            <li>aaa2</li>
            <li>aaa3</li>
        </ul>
    </div>
    <form id="form1">

        <h3>行内布局</h3>
        <div id="form3" style="width: 1000px" class="form-inline">

            <div class="form-group">
                <label>title-abc1111</label>
                <input type="text" class="form-control" />
            </div>
            <div class="form-group">
                <label>title-abc</label>
                <input type="text" class="form-control" />
                <input type="text" onclick="aa()" />

            </div>


        </div>
        <div style="width: 300px">
            <ul class="nav">
                <li class="nav-item ml-2">abc</li>
                <li class="nav-item ml-2">abc</li>
                <li class="nav-item ml-2">abc</li>
                <li class="nav-item ml-2">abc</li>
                <li class="nav-item ml-2">abc</li>
                <li class="nav-item ml-2">abc</li>
                <li class="nav-item ml-2">abc</li>
                <li class="nav-item ml-2">abc</li>
                <li class="nav-item ml-2">abc</li>
                <li class="nav-item ml-2">abc</li>
                <li class="nav-item ml-2">abc</li>
                <li class="nav-item ml-2">abc</li>
                <li class="nav-item ml-2">abc</li>
                <li class="nav-item ml-2">abc</li>
            </ul>
        </div>
        <div style="width: 400px" class="row">

            <div class="col-3">title-abc</div>
            <div class="col-9">content-abc</div>

            <div class="col-3">title-abc</div>
            <div class="col-9">content-abc</div>

            <div class="col-3">title-abc</div>
            <div class="col-9">content-abc</div>

            <div class="col-3">title-abc</div>
            <div class="col-9">content-abc</div>

            <div class="col-3">title-abc</div>
            <div class="col-9">content-abc</div>

            <div class="col-3">title-abc</div>
            <div class="col-9">content-abc</div>

            <div class="col-3">title-abc</div>
            <div class="col-9">content-abc</div>
        </div>


        <div>


            <table>
                <tr>
                    <td class="border-danger bg-danger">border-danger bg-danger</td>
                    <td style="border: double">aaa1</td>
                    <td class="bg-info">aaa2</td>
                    <td class="bg-light">bg-light</td>
                    <td class="bg-primary">bg-primary</td>
                    <td class="bg-transparent">bg-transparentaaa2</td>
                    <td class="bg-secondary">bg-secondary</td>
                    <td class="bg-success">bg-success</td>
                    <td class="bg-warning">bg-warning</td>
                    <td class="bg-danger">bg-danger</td>

                </tr>
            </table>

            <label class="text-primary">text-primary-上海</label>
            <br />
            <label class="text-primary small">text-primary-上海</label>
            <br />
            <b>
                <label class="text-primary b">text-primary-上海 b</label>
            </b>
            <br />

            <label class="text-primary font-weight-bold">text-primary  font-weight-bold -上海</label>
            <br />
            <label class="text-primary font-weight-bold text-g">text-primary  font-weight-bold -上海</label>
            <br />
            <label class="text-primary small font-weight-bold text-g">text-primary  font-weight-bold -上海</label>
            <br />

            <strong>
                <label class="" text="text-primary-上海">text-primary</label>
            </strong>
            <br />
            <label class="text-secondary">text-secondary-上海</label>
            <br />
            <strong>
                <label class="text-secondary">text-secondary-上海</label>
            </strong>
            <br />

            <label class="text-info">上海-text-info</label>
            <br />
            <strong>
                <label class="text-info">上海-text-info</label>
            </strong>
            <br />

            <label class="text-muted">上海-text-muted</label>
            <br />
            <label class="text-success">上海-text-success</label>
            <br />
            <label class="text-warning">上海-text-warning</label>
            <br />
            <label class="text-danger">text-danger</label>
            <br />
            <label class="text-black-50">text-black-50</label>
            <br />
            <label class="text-capitalize">text-capitalize</label>
            <br />
            <label class="text-dark">text-dark</label>
            <br />
            <label class="text-break">上海-text-break</label>
            <br />
            <label class="text-decoration-none">上海-text-decoration-none</label>
            <br />
            <label class="text-hide">上海-text-hide</label>
            <br />

            <label class="text-justify">上海-text-justify</label>
            <br />
            <label class="text-light">上海-text-light</label>
            <br />
            <label class="text-lowercase">上海ABC-text-lowercase</label>
            <br />
            <label class="text-monospace">上海-text-monospace</label>
            <br />
            <label class="text-reset">上海-text-reset</label>
            <br />
            <label class="text-truncate">上海-text-truncate</label>
            <br />
            <label class="text-uppercase">上海-text-uppercase</label>
            <br />
            <label class="text-white">上海-text-white</label>
            <br />
            <label class="text-white-50">上海-text-white-50</label>
            <br />
            <label class="text-black-50">上海text-black-50</label>
            <br />
            <label class="text-black-50">上海</label>
            <br />
            <label class="text-black-50 bg-dark">上海text-black-50 bg-dark</label>
            <br />
            <label class="text-black-50 bg-primary">上海text-black-50 bg-primary</label>
            <br />
            <label class="text-black-50 bg-secondary">上海text-black-50 bg-secondary</label>
            <br />
            <label class="text-black-50 bg-info">上海text-black-50 bg-info</label>
            <br />
            <label class="text-black-50 bg-success">上海text-black-50 bg-success</label>
            <br />
            <label class="text-black-50 bg-dark">上海text-black-50 bg-dark</label>
            <br />
            <label class="text-black-50 bg-transparent">上海text-black-50 bg-transparent</label>
            <br />
            <label class="text-black-50 bg-light">上海text-black-50 bg-light</label>
            <br />
            <label class="text-black-50 bg-warning">上海text-black-50 bg-warning</label>
            <br />
            <label class="text-black-50 bg-white">上海text-black-50 bg-white</label>
            <br />

            <label class="text-black-50">上海</label>
            <br />
            <label class="text-black-50">上海</label>
            <br />
            <button id="Button1" class="btn btn-outline-warning btn-sm">btn btn-outline-warning btn-sm</button>
            <br />
            <button id="Button2" class="btn btn-outline-warning btn-sm small">btn btn-outline-warning btn-sm</button>
            <br />

            <button id="Button3" class="btn btn-outline-info btn-sm">btn btn-outline-info btn-sm</button>
            <br />
            <button id="Button10" class="btn btn-outline-primary btn-sm">btn btn-outline-primary btn-sm</button>
            <br />
            <button id="Button4" class="btn btn-secondary btn-sm">btn btn-secondary btn-sm</button>
            <br />
            <button id="Button11" class="btn btn-outline-secondary btn-sm">btn btn-outline-secondary btn-sm</button>
            <br />
            <button id="Button5" class="btn btn-block btn-sm">btn btn-block btn-sm</button>
            <br />
            <button id="Button6" class="btn btn-dark btn-sm">btn btn-dark btn-sm</button>
            <br />
            <button id="Button7" class="btn btn-light btn-sm">btn btn-light btn-sm</button>
            <br />
            <button id="Button8" class="btn btn-toolbar btn-sm">btn btn-toolbar btn-sm</button>
            <br />
            <button id="Button9" class="btn btn-warning btn-sm">btn btn-warning btn-sm</button>
            <br />
            <button id="Button12" class="btn btn-warning btn-sm disabled">btn btn-warning btn-sm disabled</button>
            <br />

            <br />
            AAAAAA
            <table border="1" class="ml-4">
                <tr>
                    <td>11</td>
                    <td>22</td>
                    <td>33</td>
                </tr>
                <tr class="border-0">
                    <td class="border-0">44</td>
                    <td class="border-0">55</td>
                    <td class="border-0">66</td>
                </tr>
                <tr>
                    <td>77</td>
                    <td>88</td>
                    <td>99</td>
                </tr>
                <tr>
                    <td>AA</td>
                    <td>BB</td>
                    <td>CC</td>
                </tr>

            </table>
        </div>
        <button id="Button13" enabled="False">Button</button>
    </form>

</body>
</html>

