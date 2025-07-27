<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="T_BootStrap.aspx.cs" Inherits="AGC.Webform.A_Sample.T_BootStrap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
    <link href="../../css/VisualEffects.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
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
    <form id="form1" runat="server">
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
    <div id="divFieldLst" class="div_List">
        <ul id="ulFieldTab">
            <li id="liL1_01120171"><span class="text-primary" style="display: inline-block;">CourseCode</span>
                <button id="btnCreateFunc01120171" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01120156"><span class="text-primary" style="display: inline-block;">CourseDescription</span>
                <button id="btnDelNode01120156" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前结点">删除</button>
                <button id="btnCreateFunc01120156" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01120172">
                <ul id="ul01120172" class="nav">
                    <li class="nav-item" id="liSub_01120172"><span class="text-primary" style="display: inline-block;">CourseId</span></li>
                    <li class="nav-item ml-2 mr-2" id="li_Arraw_01120172"><span class="text-primary"><span class="text-primary">表-cc_Course</span><br>
                        <span class="text-primary">==&gt;</span>
                        <button id="btnDelMap01120172" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                    <li class="nav-item" id="liSub_01120056_01120157"><span class="text-primary"><span class="text-primary">cc_Course</span><br>
                        <span class="text-secondary">CourseName</span></span></li>
                </ul>
            </li>
            <li id="liL1_01120157"><span class="text-primary" style="display: inline-block;">CourseName</span>
                <button id="btnDelNode01120157" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前结点">删除</button>
                <button id="btnCreateFunc01120157" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01120158">
                <ul id="ul01120158" class="nav">
                    <li class="nav-item" id="liSub_01120158"><span class="text-primary" style="display: inline-block;">CourseTypeID</span></li>
                    <li class="nav-item ml-2 mr-2" id="li_Arraw_01120158"><span class="text-primary"><span class="text-primary">函数-equal</span><br>
                        <span class="text-primary">==&gt;</span>
                        <button id="btnDelMap01120158" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                    <li class="nav-item" id="liSub_Pa_01120057_01120158">
                        <ul id="ul01120057_01120158" class="nav">
                            <li class="nav-item" id="liSub_01120057_01120158"><span class="text-primary"><span class="text-primary">cc_CourseType</span><br>
                                <span class="text-secondary">CourseTypeID</span></span></li>
                            <li class="nav-item ml-2 mr-2" id="li_Arraw_0112005701120158"><span class="text-primary"><span class="text-primary">表-cc_CourseType</span><br>
                                <span class="text-primary">==&gt;</span>
                                <button id="btnDelMap0112005701120158" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                            <li class="nav-item" id="liSub_01120057_01120175"><span class="text-primary"><span class="text-primary">cc_CourseType</span><br>
                                <span class="text-secondary">CourseTypeName</span></span></li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li id="liL1_01120046"><span class="text-primary" style="display: inline-block;">CreateDate</span>
                <button id="btnCreateFunc01120046" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01120159">
                <ul id="ul01120159" class="nav">
                    <li class="nav-item" id="liSub_01120159"><span class="text-primary" style="display: inline-block;">ExcellentTypeId</span></li>
                    <li class="nav-item ml-2 mr-2" id="li_Arraw_01120159"><span class="text-primary"><span class="text-primary">函数-equal</span><br>
                        <span class="text-primary">==&gt;</span>
                        <button id="btnDelMap01120159" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                    <li class="nav-item" id="liSub_Pa_01120062_01120159">
                        <ul id="ul01120062_01120159" class="nav">
                            <li class="nav-item" id="liSub_01120062_01120159"><span class="text-primary"><span class="text-primary">cc_ExcellentType</span><br>
                                <span class="text-secondary">ExcellentTypeId</span></span></li>
                            <li class="nav-item ml-2 mr-2" id="li_Arraw_0112006201120159"><span class="text-primary"><span class="text-primary">表-cc_ExcellentType</span><br>
                                <span class="text-primary">==&gt;</span>
                                <button id="btnDelMap0112006201120159" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                            <li class="nav-item" id="liSub_01120062_01120176"><span class="text-primary"><span class="text-primary">cc_ExcellentType</span><br>
                                <span class="text-secondary">ExcellentTypeName</span></span></li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li id="liL1_01120160"><span class="text-primary" style="display: inline-block;">ExcellentYear</span>
                <button id="btnCreateFunc01120160" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01120103"><span class="text-primary" style="display: inline-block;">id_School</span>
                <button id="btnDelNode01120103" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前结点">删除</button>
                <button id="btnCreateFunc01120103" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01120174">
                <ul id="ul01120174" class="nav">
                    <li class="nav-item" id="liSub_01120174"><span class="text-primary" style="display: inline-block;">id_XzCollege</span></li>
                    <li class="nav-item ml-2 mr-2" id="li_Arraw_01120174"><span class="text-primary"><span class="text-primary">函数-equal</span><br>
                        <span class="text-primary">==&gt;</span>
                        <button id="btnDelMap01120174" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                    <li class="nav-item" id="liSub_Pa_01120064_01120174">
                        <ul id="ul01120064_01120174" class="nav">
                            <li class="nav-item" id="liSub_01120064_01120174"><span class="text-primary"><span class="text-primary">XzClg</span><br>
                                <span class="text-secondary">id_XzCollege</span></span></li>
                            <li class="nav-item ml-2 mr-2" id="li_Arraw_0112006401120174"><span class="text-primary"><span class="text-primary">表-XzClg</span><br>
                                <span class="text-primary">==&gt;</span>
                                <button id="btnDelMap0112006401120174" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                            <li class="nav-item" id="liSub_01120064_01120177"><span class="text-primary"><span class="text-primary">XzClg</span><br>
                                <span class="text-secondary">CollegeName</span></span></li>
                        </ul>
                    </li>
                    <li class="nav-item" id="liSub_Pa_01120929_01122310">
                        <ul id="ul01120929_01122310" class="nav">
                            <li class="nav-item" id="liSub_01120929_01122310"><span class="text-primary"><span class="text-primary">AcademicJournals</span><br>
                                <span class="text-secondary">JournalId</span></span></li>
                            <li class="nav-item ml-2 mr-2" id="li_Arraw_0112092901122310"><span class="text-primary"><span class="text-primary">表-AcademicJournals</span><br>
                                <span class="text-primary">==&gt;</span>
                                <button id="btnDelMap0112092901122310" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                            <li class="nav-item" id="liSub_01120929_01122311"><span class="text-primary"><span class="text-primary">AcademicJournals</span><br>
                                <span class="text-secondary">JournalName</span></span></li>
                            <li class="nav-item" id="liSub_Pa_01120929_01122312">
                                <ul id="ul01120929_01122312" class="nav">
                                    <li class="nav-item" id="liSub_01120929_01122312"><span class="text-primary"><span class="text-primary">AcademicJournals</span><br>
                                        <span class="text-secondary">JournalSubjectId</span></span></li>
                                    <li class="nav-item ml-2 mr-2" id="li_Arraw_0112092901122312"><span class="text-primary"><span class="text-primary">函数-equal</span><br>
                                        <span class="text-primary">==&gt;</span>
                                        <button id="btnDelMap0112092901122312" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                                    <li class="nav-item" id="liSub_Pa_01120930_01122312">
                                        <ul id="ul01120930_01122312" class="nav">
                                            <li class="nav-item" id="liSub_01120930_01122312"><span class="text-primary"><span class="text-primary">JournalSubject</span><br>
                                                <span class="text-secondary">JournalSubjectId</span></span></li>
                                            <li class="nav-item ml-2 mr-2" id="li_Arraw_0112093001122312"><span class="text-primary"><span class="text-primary">表-JournalSubject</span><br>
                                                <span class="text-primary">==&gt;</span>
                                                <button id="btnDelMap0112093001122312" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                                            <li class="nav-item" id="liSub_01120930_01122313"><span class="text-primary"><span class="text-primary">JournalSubject</span><br>
                                                <span class="text-secondary">JournalSubjectName</span></span></li>
                                            <li class="nav-item" id="liSub_Pa_01120930_01122314">
                                                <ul id="ul01120930_01122314" class="nav">
                                                    <li class="nav-item" id="liSub_01120930_01122314"><span class="text-primary"><span class="text-primary">JournalSubject</span><br>
                                                        <span class="text-secondary">JournalSubjectCategoryId</span></span></li>
                                                    <li class="nav-item ml-2 mr-2" id="li_Arraw_0112093001122314"><span class="text-primary"><span class="text-primary">函数-equal</span><br>
                                                        <span class="text-primary">==&gt;</span>
                                                        <button id="btnDelMap0112093001122314" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                                                    <li class="nav-item" id="liSub_Pa_01120931_01122314">
                                                        <ul id="ul01120931_01122314" class="nav">
                                                            <li class="nav-item" id="liSub_01120931_01122314"><span class="text-primary"><span class="text-primary">JournalSubjectCategory</span><br>
                                                                <span class="text-secondary">JournalSubjectCategoryId</span></span></li>
                                                            <li class="nav-item ml-2 mr-2" id="li_Arraw_0112093101122314"><span class="text-primary"><span class="text-primary">表-JournalSubjectCategory</span><br>
                                                                <span class="text-primary">==&gt;</span>
                                                                <button id="btnDelMap0112093101122314" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                                                            <li class="nav-item" id="liSub_01120931_01122315"><span class="text-primary"><span class="text-primary">JournalSubjectCategory</span><br>
                                                                <span class="text-secondary">JournalSubjectCategoryName</span></span></li>
                                                        </ul>
                                                    </li>
                                                </ul>
                                            </li>
                                            <li class="nav-item" id="liSub_01120930_01122317"><span class="text-primary"><span class="text-primary">JournalSubject</span><br>
                                                <span class="text-secondary">JournalSubjectCode</span></span></li>
                                        </ul>
                                    </li>
                                    <li class="nav-item" id="liSub_Pa_01120056_01120039">
                                        <ul id="ul01120056_01120039" class="nav">
                                            <li class="nav-item" id="liSub_01120056_01120039"><span class="text-primary"><span class="text-primary">cc_Course</span><br>
                                                <span class="text-secondary">Memo</span></span></li>
                                            <li class="nav-item ml-2 mr-2" id="li_Arraw_0112005601120039"><span class="text-primary"><span class="text-primary">函数-equal</span><br>
                                                <span class="text-primary">==&gt;</span>
                                                <button id="btnDelMap0112005601120039" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                                            <li class="nav-item" id="liSub_01120056_01120157"><span class="text-primary"><span class="text-primary">cc_Course</span><br>
                                                <span class="text-secondary">CourseName</span></span></li>
                                        </ul>
                                    </li>
                                </ul>
                            </li>
                            <li class="nav-item" id="liSub_Pa_01120929_01122314">
                                <ul id="ul01120929_01122314" class="nav">
                                    <li class="nav-item" id="liSub_01120929_01122314"><span class="text-primary"><span class="text-primary">AcademicJournals</span><br>
                                        <span class="text-secondary">JournalSubjectCategoryId</span></span></li>
                                    <li class="nav-item ml-2 mr-2" id="li_Arraw_0112092901122314"><span class="text-primary"><span class="text-primary">函数-equal</span><br>
                                        <span class="text-primary">==&gt;</span>
                                        <button id="btnDelMap0112092901122314" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                                    <li class="nav-item" id="liSub_Pa_01120931_01122314">
                                        <ul id="ul01120931_01122314" class="nav">
                                            <li class="nav-item" id="liSub_01120931_01122314"><span class="text-primary"><span class="text-primary">JournalSubjectCategory</span><br>
                                                <span class="text-secondary">JournalSubjectCategoryId</span></span></li>
                                            <li class="nav-item ml-2 mr-2" id="li_Arraw_0112093101122314"><span class="text-primary"><span class="text-primary">表-JournalSubjectCategory</span><br>
                                                <span class="text-primary">==&gt;</span>
                                                <button id="btnDelMap0112093101122314" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                                            <li class="nav-item" id="liSub_01120931_01122315"><span class="text-primary"><span class="text-primary">JournalSubjectCategory</span><br>
                                                <span class="text-secondary">JournalSubjectCategoryName</span></span></li>
                                        </ul>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li id="liL1_01120173">
                <ul id="ul01120173" class="nav">
                    <li class="nav-item" id="liSub_01120173"><span class="text-primary" style="display: inline-block;">id_XzMajor</span></li>
                    <li class="nav-item ml-2 mr-2" id="li_Arraw_01120173"><span class="text-primary"><span class="text-primary">函数-equal</span><br>
                        <span class="text-primary">==&gt;</span>
                        <button id="btnDelMap01120173" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                    <li class="nav-item" id="liSub_Pa_01120065_01120173">
                        <ul id="ul01120065_01120173" class="nav">
                            <li class="nav-item" id="liSub_01120065_01120173"><span class="text-primary"><span class="text-primary">XzMajor</span><br>
                                <span class="text-secondary">id_XzMajor</span></span></li>
                            <li class="nav-item ml-2 mr-2" id="li_Arraw_0112006501120173"><span class="text-primary"><span class="text-primary">表-XzMajor</span><br>
                                <span class="text-primary">==&gt;</span>
                                <button id="btnDelMap0112006501120173" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                            <li class="nav-item" id="liSub_01120065_01120180"><span class="text-primary"><span class="text-primary">XzMajor</span><br>
                                <span class="text-secondary">MajorName</span></span></li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li id="liL1_01120161"><span class="text-primary" style="display: inline-block;">IsBuildingCourse</span>
                <button id="btnCreateFunc01120161" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01120162"><span class="text-primary" style="display: inline-block;">IsDoubleLanguageCourse</span>
                <button id="btnCreateFunc01120162" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01120163"><span class="text-primary" style="display: inline-block;">IsOpen</span>
                <button id="btnCreateFunc01120163" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01120164"><span class="text-primary" style="display: inline-block;">IsRecommendedCourse</span>
                <button id="btnCreateFunc01120164" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01120165"><span class="text-primary" style="display: inline-block;">IsSelfPropelledCourse</span>
                <button id="btnCreateFunc01120165" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01120039">
                <ul id="ul01120039" class="nav">
                    <li class="nav-item" id="liSub_01120039"><span class="text-primary" style="display: inline-block;">Memo</span></li>
                    <li class="nav-item ml-2 mr-2" id="li_Arraw_01120039"><span class="text-primary"><span class="text-primary">函数-equal</span><br>
                        <span class="text-primary">==&gt;</span>
                        <button id="btnDelMap01120039" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                    <li class="nav-item" id="liSub_01120056_01120157"><span class="text-primary"><span class="text-primary">cc_Course</span><br>
                        <span class="text-secondary">CourseName</span></span></li>
                </ul>
            </li>
            <li id="liL1_01120166"><span class="text-primary" style="display: inline-block;">OperationDate</span>
                <button id="btnCreateFunc01120166" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01120120"><span class="text-primary" style="display: inline-block;">OrderNum</span>
                <button id="btnCreateFunc01120120" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01120167"><span class="text-primary" style="display: inline-block;">OuterLink</span>
                <button id="btnCreateFunc01120167" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01121507">
                <ul id="ul01121507" class="nav">
                    <li class="nav-item" id="liSub_01121507"><span class="text-primary" style="display: inline-block;">ThemeId</span></li>
                    <li class="nav-item ml-2 mr-2" id="li_Arraw_01121507"><span class="text-primary"><span class="text-primary">函数-equal</span><br>
                        <span class="text-primary">==&gt;</span>
                        <button id="btnDelMap01121507" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                    <li class="nav-item" id="liSub_Pa_01120069_01121507">
                        <ul id="ul01120069_01121507" class="nav">
                            <li class="nav-item" id="liSub_01120069_01121507"><span class="text-primary"><span class="text-primary">cc_Themes</span><br>
                                <span class="text-secondary">ThemeId</span></span></li>
                            <li class="nav-item ml-2 mr-2" id="li_Arraw_0112006901121507"><span class="text-primary"><span class="text-primary">表-cc_Themes</span><br>
                                <span class="text-primary">==&gt;</span>
                                <button id="btnDelMap0112006901121507" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button></span></li>
                            <li class="nav-item" id="liSub_01120069_01121508"><span class="text-primary"><span class="text-primary">cc_Themes</span><br>
                                <span class="text-secondary">ThemeName</span></span></li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li id="liL1_01120032"><span class="text-primary" style="display: inline-block;">UpdDate</span>
                <button id="btnCreateFunc01120032" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01120169"><span class="text-primary" style="display: inline-block;">UpdUserId</span>
                <button id="btnCreateFunc01120169" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
            <li id="liL1_01120170"><span class="text-primary" style="display: inline-block;">ViewCount</span>
                <button id="btnCreateFunc01120170" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出函数">建立函数</button></li>
        </ul>
    </div>
    <div id="divFeatureLst" class="div_List">
        <div id="divTabFeatureLst0173" class="div_List">
            <div id="divTabFeature_00050382" class="row" style="width: 100%;">
                <div class="col-5">left--left
                    <ul id="ul00050382" class="list-unstyled">
                    <li class="nav-item" id="liFld_00050382"><span class="text-danger font-weight-bold text-g"><span class="text-primary">绑定下拉框22</span><br>
                        <span class="text-danger">Cs绑定函数:clsAppPageTypeBL.</span><br>
                        <span class="text-danger">Js绑定函数:clsAppPageTypeWApi.</span></span>
                        <button id="btnUpdateteTabFeature00050149" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="修改表功能">修改</button>
                        <button id="btnCreateFunc00050149" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出映射">建立映射</button>
                        <button id="btnCopyNode00050149" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出映射">复制结点</button>
                        <button id="btnEditComboBox00050149" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="编辑下拉框">编辑下拉框</button></li>
                    <li class="nav-item" id="liSub_00050149">
                        <ul id="ul944" class="nav">
                            <li class="nav-item" id="liSub_00050149_00051238"><span class="text-primary"><span class="text-primary">关键字段</span><br>
                                <span class="text-danger">AppPageTypeId</span></span></li>
                        </ul>
                        <ul id="ul945" class="nav">
                            <li class="nav-item" id="liSub_00050149_00051239"><span class="text-primary"><span class="text-primary">名称字段</span><br>
                                <span class="text-danger">AppPageTypeName</span></span></li>
                        </ul>
                        <ul id="ul3740" class="nav">
                            <li class="nav-item" id="liSub_00050149_00050153"><span class="text-primary"><span class="text-primary">条件字段</span><br>
                                <span class="text-danger">Memo</span></span></li>
                        </ul>
                    </li>
                </ul>
                </div>
                <div class="col-7 border-info" id="float11">right--right</div>
            </div>
            <hr>
            <div id="divTabFeature_00050382" class="row" style="width: 100%;">
                <div class="col-5">left--left<ul id="ul00050382" class="list-unstyled">
                    <li class="nav-item" id="liFld_00050382"><span class="text-danger font-weight-bold text-g"><span class="text-primary">AAA</span><br>
                        <span class="text-danger">Cs绑定函数:clsAppPageTypeBLEx.BindDdl_Cs</span><br>
                        <span class="text-danger">Js绑定函数:clsAppPageTypeExWApi.BindDdl_Js</span></span>
                        <button id="btnUpdateteTabFeature01700023" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="修改表功能">修改</button>
                        <button id="btnCreateFunc01700023" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出映射">建立映射</button>
                        <button id="btnCopyNode01700023" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="建立导出映射">复制结点</button>
                        <button id="btnEditComboBox01700023" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="编辑下拉框">编辑下拉框</button></li>
                    <li class="nav-item" id="liSub_01700023">
                        <ul id="ul3736" class="nav">
                            <li class="nav-item" id="liSub_01700023_00051238"><span class="text-primary"><span class="text-primary">关键字段</span><br>
                                <span class="text-danger">AppPageTypeId</span></span></li>
                        </ul>
                        <ul id="ul3738" class="nav">
                            <li class="nav-item" id="liSub_01700023_00051239"><span class="text-primary"><span class="text-primary">名称字段</span><br>
                                <span class="text-danger">AppPageTypeName</span></span></li>
                        </ul>
                        <ul id="ul3737" class="nav">
                            <li class="nav-item" id="liSub_01700023_00050153"><span class="text-primary"><span class="text-primary">条件字段</span><br>
                                <span class="text-danger">Memo</span></span></li>
                        </ul>
                        <ul id="ul3739" class="nav">
                            <li class="nav-item" id="liSub_01700023_00050205"><span class="text-primary"><span class="text-primary">排序字段</span><br>
                                <span class="text-danger">UpdDate</span></span></li>
                        </ul>
                    </li>
                </ul>
                </div>
                <div class="col-7" id="float22">right--right</div>
            </div>
            <hr>
        </div>

    </div>
</body>
</html>

