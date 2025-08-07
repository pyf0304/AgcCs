<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="T_BootStrap2.aspx.vb" Inherits="TestBootStrap51.T_BootStrap2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    
    <script src="Scripts/popper.min.js"></script>
    <script type="text/javascript" src="./Scripts/bootstrap.min.js"></script>
    <script src="./Scripts/bootstrap.bundle.min.js"></script>
    <link rel="canonical" href="https://v4.bootcss.com/docs/components/navbar/" />
    <link href="./Content/bootstrap.min.css" rel="stylesheet" />
    <link href="DataNode.css" rel="stylesheet" />
</head>

<body>
  
    <button type="button" class="btn btn-secondary" data-toggle="tooltip" data-placement="top" title="Tooltip on top">
  Tooltip on top
</button>
<button type="button" class="btn btn-secondary" data-toggle="tooltip" data-placement="right" title="Tooltip on right">
  Tooltip on right
</button>
<button type="button" class="btn btn-secondary" data-toggle="tooltip" data-placement="bottom" title="Tooltip on bottom">
  Tooltip on bottom
</button>
<button type="button" class="btn btn-secondary" data-toggle="tooltip" data-placement="left" title="Tooltip on left">
  Tooltip on left
</button>
  

    <input keyid="00005452" id="btnUpdate" type="button" name="" class="btn btn-outline-info btn-sm text-nowrap" value="修改" data-toggle="tooltip" data-placement="left" data-html="true" title="修改<br/>Id:btnUpdateRecord<br/>Update ==>PrjTabFld"/>

    <button keyid="00005452" id="btnUpdate1" type="button" name="" class="btn btn-outline-info btn-sm text-nowrap"  data-toggle="tooltip" data-placement="left" data-html="true" title="修改<br/>Id:btnUpdateRecord<br/>Update ==>PrjTabFld">
        修改
    </button>
    <button type="button" class="btn btn-secondary" data-toggle="tooltip" data-html="true" title="<em>Tooltip</em> <u>with</u> <b>HTML</b>">
  Tooltip with HTML
</button>
    <br />

    <!-- HTML to write -->
<a href="#" data-toggle="tooltip" title="Some tooltip text!">Hover over me-pyf</a>

<!-- Generated markup by the plugin -->
<div class="tooltip bs-tooltip-top" role="tooltip">
  <div class="arrow"></div>
  <div class="tooltip-inner">
    pyf-Some tooltip text!pyf
  </div>
</div>

    <h3>表单控件</h3>
    <p>
        <a class="btn btn-primary" data-toggle="collapse" href="#collapseExample" role="button" aria-expanded="false" aria-controls="collapseExample">Link with href
        </a>
        <button class="btn btn-primary" type="button" data-toggle="collapse" data-target="#collapseExample" aria-expanded="false" aria-controls="collapseExample">
            Button with data-target
        </button>
    </p>
    <div class="collapse" id="collapseExample">
        <div class="card card-body">
            Some placeholder content for the collapse component. This panel is hidden by default but revealed when the user activates the relevant trigger.
        </div>
    </div>
    <br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />

    <ul class="nav">
        <li class="nav-item">
            <div style="border: 2px solid">
                <span>aaa</span>
                <br />
                <span>bbb</span>

            </div>
        </li>
        <li class="nav-item">--   </li>
        <li class="nav-item">
            <div style="border: 1px dotted">
                <span>aaa</span>
                <br />
                <span>bbb</span>

            </div>
        </li>
    </ul>


    <ul id="ul00024243" class="nav">
        <li class="nav-item ml-2 mr-2" id="li_Arraw_00024243">
            <div class="border-danger NodeRelation"><span class="text-primary">1.函数-equal</span><br>
                <span class="text-primary">==&gt;</span>
                <button id="btnDelMap00024243" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></div>
        </li>
        <li class="nav-item" id="liSub_00050023_00050794">
            <div class="RelaTabNode"><a class="text-primary" title="单击可以编辑该表的函数映射.">DataTypeAbbr</a><br>
                <span class="text-danger">DataTypeId</span></div>

        </li>
        <li class="nav-item" id="liSub_Pa_00050023_00050794">
            <ul id="ul00050023_00050794" class="nav">
                <li class="nav-item ml-2 mr-2" id="li_Arraw_00024108">
                    <div class="border-danger NodeRelation"><span class="text-primary">1.表-DataTypeAbbr</span><br>
                        <span class="text-primary">==&gt;</span>
                        <button id="btnDelMap00024108" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></div>
                </li>
                <li class="nav-item" id="liSub_00050023_00050238"></li>
                <li class="nav-item" id="liSub_00050023_00050238">
                    <span class="RelaTabNode"><a class="text-primary" title="单击可以编辑该表的函数映射.">DataTypeAbbr</a><br>
                    <span class="text-danger">DataTypeName</span></span>

                </li>
            </ul>
        </li>
    </ul>



    <div>
        <div id="left1" class="float-left"></div>
        <div id="right1" class="float-right"></div>
    </div>
    <div>
        <a class="link-primary" onclick="btnSelectTabIdInTab_Click('00050329');">vFunctionGroupRela
        <br />
            v函数与组关系<br />
            主表:
        </a>
        <a class="link-info" onclick="btnSelectTabIdInTab_Click('00050329');">vFunctionGroupRela
        <br />
            v函数与组关系<br />
            主表:
        </a>
        <a class="link-secondary" onclick="btnSelectTabIdInTab_Click('00050329');">vFunctionGroupRela
        <br />
            v函数与组关系<br />
            主表:
        </a>
        <a class="link-success" title="This is the tooltip message." onclick="btnSelectTabIdInTab_Click('00050329');">vFunctionGroupRela
        <br />
            v函数与组关系1<br />
            主表:
        </a>
        <span title="This is the tooltip message.">tooltip</span>
    </div>
    <div class="myBorder" style="width: 300px; height: 100px;">
        <span>abc</span>
        <br />
        <span>ab1c<br />
            bbb</span>
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
        <ul class="list-unstyled" style="line-height: 18px;">
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
    <form id="form2" runat="server">
        <asp:CheckBox ID="CheckBox8" Text="Asp:CheckBox控件-CheckBox8" CssClass="form-control" Width="350px" runat="server" />

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
            <div class="form-group">
                <asp:CheckBox ID="CheckBox7" Text="上海师范大学教育学院" CssClass="form-control" Width="250px" runat="server" />
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

            <asp:CheckBox ID="CheckBox1" Text="上海师范大学教育学院" CssClass="form-control" Width="150px" runat="server" />
            <asp:CheckBox ID="CheckBox5" Text="AAA1" Checked="true" CssClass="form-control" runat="server" />
            <asp:CheckBox ID="CheckBox6" Text="AAA1" Checked="false" CssClass="form-control  border-danger" runat="server" />
            <asp:CheckBox ID="CheckBox4" Text="AAA2" CssClass="form-control  border-danger" runat="server" />
            <asp:CheckBox ID="CheckBox3" Text="AAA3" CssClass="form-check" runat="server" />
            <asp:CheckBox ID="CheckBox2" Text="BBB" CssClass="form-check  border-danger" runat="server" />
            <table>
                <tr>
                    <td class="border-danger bg-danger">border-danger bg-danger</td>
                    <td style="border: double">style="border: double"</td>
                    <td class="bg-transparent">bg-transparent</td>

                    <td class="bg-light">bg-light</td>
                    <td class="bg-primary">bg-primary</td>
                    <td class="bg-secondary">bg-secondary</td>
                    <td class="bg-success">bg-success</td>
                    <td class="bg-info">bg-info</td>
                    <td class="bg-warning">bg-warning</td>
                    <td class="bg-danger">bg-danger</td>
                </tr>
                <tr>


                    <td class="bg-danger bg-opacity-10">bg-danger bg-opacity-10</td>
                    <td class="bg-danger bg-opacity-25">bg-danger bg-opacity-25</td>
                    <td class="bg-danger bg-opacity-50">bg-danger bg-opacity-50</td>
                    <td class="bg-danger bg-opacity-75">bg-danger bg-opacity-75</td>
                    <td class="bg-danger bg-opacity-100">bg-danger bg-opacity-100</td>
                    <td class="bg-danger">bg-danger</td>


                </tr>
                <tr>


                    <td class="bg-warning bg-opacity-10">bg-warning bg-opacity-10</td>
                    <td class="bg-warning bg-opacity-25">bg-warning bg-opacity-25</td>
                    <td class="bg-warning bg-opacity-50">bg-warning bg-opacity-50</td>
                    <td class="bg-warning bg-opacity-75">bg-warning bg-opacity-75</td>
                    <td class="bg-warning bg-opacity-100">bg-warning bg-opacity-100</td>
                    <td class="bg-warning">bg-warning</td>


                </tr>
                <tr>
                    <td class="bg-primary bg-opacity-10">bg-primary bg-opacity-10</td>
                    <td class="bg-primary bg-opacity-25">bg-primary bg-opacity-25</td>
                    <td class="bg-primary bg-opacity-50">bg-primary bg-opacity-50</td>
                    <td class="bg-primary bg-opacity-75">bg-primary bg-opacity-75</td>
                    <td class="bg-primary bg-opacity-100">bg-primary bg-opacity-100</td>
                    <td class="bg-primary">bg-primary</td>

                </tr>
                <tr>
                    <td class="bg-secondary bg-opacity-10">bg-secondary bg-opacity-10</td>
                    <td class="bg-secondary bg-opacity-25">bg-secondary bg-opacity-25</td>
                    <td class="bg-secondary bg-opacity-50">bg-secondary bg-opacity-50</td>
                    <td class="bg-secondary bg-opacity-75">bg-secondary bg-opacity-75</td>
                    <td class="bg-secondary bg-opacity-100">bg-secondary bg-opacity-100</td>
                    <td class="bg-secondary">bg-secondary</td>

                </tr>
                <tr>
                    <td class="bg-info bg-opacity-10">bg-info bg-opacity-10</td>
                    <td class="bg-info bg-opacity-25">bg-info bg-opacity-25</td>
                    <td class="bg-info bg-opacity-50">bg-info bg-opacity-50</td>
                    <td class="bg-info bg-opacity-75">bg-info bg-opacity-75</td>
                    <td class="bg-info bg-opacity-100">bg-info bg-opacity-100</td>
                    <td class="bg-info">bg-info</td>

                </tr>
                <tr>
                    <td class="bg-gradient bg-opacity-10">bg-gradient bg-opacity-10</td>
                    <td class="bg-gradient bg-opacity-25">bg-gradient bg-opacity-25</td>
                    <td class="bg-gradient bg-opacity-50">bg-gradient bg-opacity-50</td>
                    <td class="bg-gradient bg-opacity-75">bg-gradient bg-opacity-75</td>
                    <td class="bg-gradient bg-opacity-100">bg-gradient bg-opacity-100</td>
                    <td class="bg-gradient">bg-gradient</td>

                </tr>
                <tr>
                    <td class="bg-white bg-opacity-10">bg-white bg-opacity-10</td>
                    <td class="bg-white bg-opacity-25">bg-white bg-opacity-25</td>
                    <td class="bg-white bg-opacity-50">bg-white bg-opacity-50</td>
                    <td class="bg-white bg-opacity-75">bg-white bg-opacity-75</td>
                    <td class="bg-white bg-opacity-100">bg-white bg-opacity-100</td>
                    <td class="bg-white">bg-white</td>

                </tr>
                <tr>
                    <td class="bg-success bg-opacity-10">bg-success bg-opacity-10</td>
                    <td class="bg-success bg-opacity-25">bg-success bg-opacity-25</td>
                    <td class="bg-success bg-opacity-50">bg-success bg-opacity-50</td>
                    <td class="bg-success bg-opacity-75">bg-success bg-opacity-75</td>
                    <td class="bg-success bg-opacity-100">bg-success bg-opacity-100</td>
                    <td class="bg-success">bg-success</td>

                </tr>
            </table>
            <asp:DropDownList ID="DropDownList1" runat="server" placeholder="DropDownList1">
            </asp:DropDownList>
            <asp:TextBox ID="TextBox1" CssClass="form-control  border-info" runat="server" placeholder="TextBox1"></asp:TextBox>
            <asp:TextBox ID="TextBox3" CssClass="form-control  border-danger" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox4" CssClass="form-control  border-dark" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox5" CssClass="form-control  border-primary" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" CssClass="form-check border-info" runat="server"></asp:TextBox>
            <asp:Label runat="server" CssClass="text-primary" Text="text-primary-上海"></asp:Label><br />
            <asp:Label runat="server" CssClass="text-primary small" Text="text-primary-上海"></asp:Label><br />
            <b>
                <asp:Label runat="server" CssClass="text-primary b" Text="text-primary-上海 b"></asp:Label></b><br />

            <asp:Label runat="server" CssClass="text-primary font-weight-bold" Text="text-primary  font-weight-bold -上海"></asp:Label><br />
            <asp:Label runat="server" CssClass="text-primary font-weight-bold text-g" Text="text-primary  font-weight-bold -上海"></asp:Label><br />
            <asp:Label runat="server" CssClass="text-primary small font-weight-bold text-g" Text="text-primary  font-weight-bold -上海"></asp:Label><br />

            <strong>
                <asp:Label runat="server" CssClass="text-primary" Text="text-primary-上海"></asp:Label></strong><br />
            <asp:Label runat="server" Text="text-secondary-上海" CssClass="text-secondary"></asp:Label><br />
            <strong>
                <asp:Label runat="server" Text="text-secondary-上海" CssClass="text-secondary"></asp:Label></strong><br />

            <asp:Label runat="server" Text="上海-text-info" CssClass="text-info"></asp:Label><br />
            <strong>
                <asp:Label runat="server" Text="上海-text-info" CssClass="text-info"></asp:Label></strong><br />

            <asp:Label runat="server" Text="上海-text-muted" CssClass="text-muted"></asp:Label><br />
            <asp:Label runat="server" Text="上海-text-success" CssClass="text-success"></asp:Label><br />
            <asp:Label runat="server" Text="上海-text-warning" CssClass="text-warning"></asp:Label><br />
            <asp:Label runat="server" Text="text-danger" CssClass="text-danger"></asp:Label><br />
            <asp:Label runat="server" Text="text-black-50" CssClass="text-black-50"></asp:Label><br />
            <asp:Label runat="server" Text="text-capitalize" CssClass="text-capitalize"></asp:Label><br />
            <asp:Label runat="server" Text="text-dark" CssClass="text-dark"></asp:Label><br />
            <asp:Label runat="server" Text="上海-text-break" CssClass="text-break"></asp:Label><br />
            <asp:Label runat="server" Text="上海-text-decoration-none" CssClass="text-decoration-none"></asp:Label><br />
            <asp:Label runat="server" Text="上海-text-hide" CssClass="text-hide"></asp:Label><br />

            <asp:Label runat="server" Text="上海-text-justify" CssClass="text-justify"></asp:Label><br />
            <asp:Label runat="server" Text="上海-text-light" CssClass="text-light"></asp:Label><br />
            <asp:Label runat="server" Text="上海ABC-text-lowercase" CssClass="text-lowercase"></asp:Label><br />
            <asp:Label runat="server" Text="上海-text-monospace" CssClass="text-monospace"></asp:Label><br />
            <asp:Label runat="server" Text="上海-text-reset" CssClass="text-reset"></asp:Label><br />
            <asp:Label runat="server" Text="上海-text-truncate" CssClass="text-truncate"></asp:Label><br />
            <asp:Label runat="server" Text="上海-text-uppercase" CssClass="text-uppercase"></asp:Label><br />
            <asp:Label runat="server" Text="上海-text-white" CssClass="text-white"></asp:Label><br />
            <asp:Label runat="server" Text="上海-text-white-50" CssClass="text-white-50"></asp:Label><br />
            <asp:Label runat="server" Text="上海text-black-50" CssClass="text-black-50"></asp:Label><br />
            <asp:Label runat="server" Text="上海" CssClass="text-black-50"></asp:Label><br />
            <asp:Label runat="server" Text="上海text-black-50 bg-dark" CssClass="text-black-50 bg-dark"></asp:Label><br />
            <asp:Label runat="server" Text="上海text-black-50 bg-primary" CssClass="text-black-50 bg-primary"></asp:Label><br />
            <asp:Label runat="server" Text="上海text-black-50 bg-secondary" CssClass="text-black-50 bg-secondary"></asp:Label><br />
            <asp:Label runat="server" Text="上海text-black-50 bg-info" CssClass="text-black-50 bg-info"></asp:Label><br />
            <asp:Label runat="server" Text="上海text-black-50 bg-success" CssClass="text-black-50 bg-success"></asp:Label><br />
            <asp:Label runat="server" Text="上海text-black-50 bg-dark" CssClass="text-black-50 bg-dark"></asp:Label><br />
            <asp:Label runat="server" Text="上海text-black-50 bg-transparent" CssClass="text-black-50 bg-transparent"></asp:Label><br />
            <asp:Label runat="server" Text="上海text-black-50 bg-light" CssClass="text-black-50 bg-light"></asp:Label><br />
            <asp:Label runat="server" Text="上海text-black-50 bg-warning" CssClass="text-black-50 bg-warning"></asp:Label><br />
            <asp:Label runat="server" Text="上海text-black-50 bg-white" CssClass="text-black-50 bg-white"></asp:Label><br />
            <asp:Label runat="server" Text="有色底-白字--上海text-white bg-success" CssClass="text-white bg-success"></asp:Label><br />
            <asp:Label runat="server" Text="有色字-白底--上海text-primary bg-white" CssClass="text-primary bg-white"></asp:Label><br />

            <asp:Label runat="server" Text="上海" CssClass="text-black-50"></asp:Label><br />
            <asp:Label runat="server" Text="上海" CssClass="text-black-50"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="btn btn-outline-warning btn-sm" CssClass="btn btn-outline-warning btn-sm" /><br />
            <asp:Button ID="Button2" runat="server" Text="btn btn-outline-warning btn-sm" CssClass="btn btn-outline-warning btn-sm small" />
            <br />

            <asp:Button ID="Button3" runat="server" Text="btn btn-outline-info btn-sm" CssClass="btn btn-outline-info btn-sm" /><br />
            <asp:Button ID="Button10" runat="server" Text="btn btn-outline-primary btn-sm" CssClass="btn btn-outline-primary btn-sm" /><br />
            <asp:Button ID="Button4" runat="server" Text="btn btn-secondary btn-sm" CssClass="btn btn-secondary btn-sm" /><br />
            <asp:Button ID="Button11" runat="server" Text="btn btn-outline-secondary btn-sm" CssClass="btn btn-outline-secondary btn-sm" /><br />
            <asp:Button ID="Button5" runat="server" Text="btn btn-block btn-sm" CssClass="btn btn-block btn-sm" /><br />
            <asp:Button ID="Button6" runat="server" Text="btn btn-dark btn-sm" CssClass="btn btn-dark btn-sm" /><br />
            <asp:Button ID="Button7" runat="server" Text="btn btn-light btn-sm" CssClass="btn btn-light btn-sm" /><br />
            <asp:Button ID="Button8" runat="server" Text="btn btn-toolbar btn-sm" CssClass="btn btn-toolbar btn-sm" /><br />
            <asp:Button ID="Button9" runat="server" Text="btn btn-warning btn-sm" CssClass="btn btn-warning btn-sm" /><br />
            <asp:Button ID="Button12" runat="server" Text="btn btn-warning btn-sm disabled" CssClass="btn btn-warning btn-sm disabled" /><br />

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
        <asp:Button ID="Button13" runat="server" Text="Button" Enabled="False" />
    </form>

</body>
</html>
