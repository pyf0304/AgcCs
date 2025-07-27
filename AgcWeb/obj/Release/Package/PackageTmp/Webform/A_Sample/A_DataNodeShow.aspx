<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="A_DataNodeShow.aspx.cs" Inherits="AgcMvc3.Webform.A_Sample.TestDebug.A_DataNodeShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
    <link href="../../css/VisualEffects.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        .spanborder {
            background-color: #eee;
            border: 1px solid #888;
            border-radius: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">


        <div>
            <div id="divL1_01122310">
                <ul id="ul24015" class="nav">
                    <li class="nav-item" id="liSub_24015"></li>
                    <li class="nav-item ml-2 mr-2" id="li_Arraw_24015">
                        <div class="border-danger">
                            <span class="text-primary">1.表-AcademicJournals</span><br>
                            <span class="text-primary">==&gt;</span>
                            <button id="btnDelMap24015" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                        </div>
                    </li>
                    <li class="nav-item" id="liSub_01120929_01122311"><span class="text-primary"><span class="text-primary">AcademicJournals</span><br>
                        <span class="text-secondary">JournalName</span></span></li>
                </ul>
                <ul id="ul24026" class="nav">
                    <li class="nav-item" id="liSub_24026"></li>
                    <li class="nav-item ml-2 mr-2" id="li_Arraw_24026">
                        <div class="border-danger">
                            <span class="text-primary">2.表-AcademicJournals</span><br>
                            <span class="text-primary">==&gt;</span>
                            <button id="btnDelMap24026" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                        </div>
                    </li>
                    <li class="nav-item" id="liSub_Pa_01120929_01122312">
                        <ul id="ul01120929_01122312" class="nav">
                            <li class="nav-item" id="liSub_01120929_01122312"><span class="text-primary"><span class="text-primary">AcademicJournals</span><br>
                                <span class="text-secondary">JournalSubjectId</span></span></li>
                            <li class="nav-item ml-2 mr-2" id="li_Arraw_24029">
                                <div class="border-danger">
                                    <span class="text-primary">1.函数-equal</span><br>
                                    <span class="text-primary">==&gt;</span>
                                    <button id="btnDelMap24029" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                </div>
                            </li>
                            <li class="nav-item" id="liSub_Pa_01120930_01122312">
                                <ul id="ul01120930_01122312" class="nav">
                                    <li class="nav-item" id="liSub_01120930_01122312"></li>
                                    <li class="nav-item ml-2 mr-2" id="li_Arraw_24016">
                                        <div class="border-danger">
                                            <span class="text-primary">1.表-JournalSubject</span><br>
                                            <span class="text-primary">==&gt;</span>
                                            <button id="btnDelMap24016" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                        </div>
                                    </li>
                                    <li class="nav-item" id="liSub_01120930_01122313"><span class="text-primary"><span class="text-primary">JournalSubject</span><br>
                                        <span class="text-secondary">JournalSubjectName</span></span></li>
                                </ul>
                            </li>
                            <li class="nav-item" id="liSub_Pa_01120930_01122312">
                                <ul id="ul01120930_01122312" class="nav">
                                    <li class="nav-item" id="liSub_01120930_01122312"></li>
                                    <li class="nav-item ml-2 mr-2" id="li_Arraw_24020">
                                        <div class="border-danger">
                                            <span class="text-primary">2.表-JournalSubject</span><br>
                                            <span class="text-primary">==&gt;</span>
                                            <button id="btnDelMap24020" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                        </div>
                                    </li>
                                    <li class="nav-item" id="liSub_Pa_01120930_01122314">
                                        <ul id="ul01120930_01122314" class="nav">
                                            <li class="nav-item" id="liSub_01120930_01122314"><span class="text-primary"><span class="text-primary">JournalSubject</span><br>
                                                <span class="text-secondary">JournalSubjectCategoryId</span></span></li>
                                            <li class="nav-item ml-2 mr-2" id="li_Arraw_24022">
                                                <div class="border-danger">
                                                    <span class="text-primary">1.函数-equal</span><br>
                                                    <span class="text-primary">==&gt;</span>
                                                    <button id="btnDelMap24022" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                                </div>
                                            </li>
                                            <li class="nav-item" id="liSub_Pa_01120931_01122314">
                                                <ul id="ul01120931_01122314" class="nav">
                                                    <li class="nav-item" id="liSub_01120931_01122314"><span class="text-primary"><span class="text-primary">JournalSubjectCategory</span><br>
                                                        <span class="text-secondary">JournalSubjectCategoryId</span></span></li>
                                                    <li class="nav-item ml-2 mr-2" id="li_Arraw_24014">
                                                        <div class="border-danger">
                                                            <span class="text-primary">1.表-JournalSubjectCategory</span><br>
                                                            <span class="text-primary">==&gt;</span>
                                                            <button id="btnDelMap24014" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                                        </div>
                                                    </li>
                                                    <li class="nav-item" id="liSub_01120931_01122315"><span class="text-primary"><span class="text-primary">JournalSubjectCategory</span><br>
                                                        <span class="text-secondary">JournalSubjectCategoryName</span></span></li>
                                                </ul>
                                            </li>
                                        </ul>
                                    </li>
                                </ul>
                            </li>
                            <li class="nav-item" id="liSub_Pa_01120930_01122312">
                                <ul id="ul01120930_01122312" class="nav">
                                    <li class="nav-item" id="liSub_01120930_01122312"><span class="text-primary"><span class="text-primary">JournalSubject</span><br>
                                        <span class="text-secondary">JournalSubjectId</span></span></li>
                                    <li class="nav-item ml-2 mr-2" id="li_Arraw_24021">
                                        <div class="border-danger">
                                            <span class="text-primary">3.表-JournalSubject</span><br>
                                            <span class="text-primary">==&gt;</span>
                                            <button id="btnDelMap24021" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                        </div>
                                    </li>
                                    <li class="nav-item" id="liSub_01120930_01122317"><span class="text-primary"><span class="text-primary">JournalSubject</span><br>
                                        <span class="text-secondary">JournalSubjectCode</span></span></li>
                                </ul>
                            </li>
                        </ul>
                    </li>
                </ul>
                <ul id="ul24027" class="nav">
                    <li class="nav-item" id="liSub_24027"><span class="text-danger font-weight-bold text-g" style="display: inline-block;">JournalId</span></li>
                    <li class="nav-item ml-2 mr-2" id="li_Arraw_24027">
                        <div class="border-danger">
                            <span class="text-primary">3.表-AcademicJournals</span><br>
                            <span class="text-primary">==&gt;</span>
                            <button id="btnDelMap24027" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                        </div>
                    </li>
                    <li class="nav-item" id="liSub_Pa_01120929_01122314">
                        <ul id="ul01120929_01122314" class="nav">
                            <li class="nav-item" id="liSub_01120929_01122314"><span class="text-primary"><span class="text-primary">AcademicJournals</span><br>
                                <span class="text-secondary">JournalSubjectCategoryId</span></span></li>
                            <li class="nav-item ml-2 mr-2" id="li_Arraw_24028">
                                <div class="border-danger">
                                    <span class="text-primary">1.函数-equal</span><br>
                                    <span class="text-primary">==&gt;</span>
                                    <button id="btnDelMap24028" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                </div>
                            </li>
                            <li class="nav-item" id="liSub_Pa_01120931_01122314">
                                <ul id="ul01120931_01122314" class="nav">
                                    <li class="nav-item" id="liSub_01120931_01122314"><span class="text-primary"><span class="text-primary">JournalSubjectCategory</span><br>
                                        <span class="text-secondary">JournalSubjectCategoryId</span></span></li>
                                    <li class="nav-item ml-2 mr-2" id="li_Arraw_24014">
                                        <div class="border-danger">
                                            <span class="text-primary">1.表-JournalSubjectCategory</span><br>
                                            <span class="text-primary">==&gt;</span>
                                            <button id="btnDelMap24014" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                        </div>
                                    </li>
                                    <li class="nav-item" id="liSub_01120931_01122315"><span class="text-primary"><span class="text-primary">JournalSubjectCategory</span><br>
                                        <span class="text-secondary">JournalSubjectCategoryName</span></span></li>
                                </ul>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
        <span class="spanborder"><span>XzClg</span><br />
            <span>CollegeName</span></span>
        <br />
        <span class="label label-success"><span>XzClg</span><br />
            <span>CollegeName</span></span>
        <br />
        <div class="text-primary spanborder">
            <span class="text-primary"><span class="text-primary">XzClg</span><br />
                <span class="text-secondary">CollegeName</span></span>
        </div>
        <div class="border-danger" style="display: inline-block; background-color: #ccc;">
            <span class="text-primary"><span class="text-primary">XzClg</span><br />
                <span class="text-secondary">CollegeName</span></span>
        </div>

        <div>
            <ul>
                <li class="nav-item" id="liSub_24027"><span class="text-danger font-weight-bold text-g" style="display: inline-block;">JournalId</span></li>
                <li>
                    <ul id="ul24015" class="nav">
                        <li class="nav-item ml-2 mr-2" id="li_Arraw_24015">
                            <div class="border-danger">
                                <span class="text-primary">1.表-AcademicJournals</span><br>
                                <span class="text-primary">==&gt;</span>
                                <button id="btnDelMap24015" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                            </div>
                        </li>
                        <li class="nav-item" id="liSub_01120929_01122311"><span class="text-primary"><span class="text-primary">AcademicJournals</span><br>
                            <span class="text-secondary">JournalName</span></span></li>
                    </ul>
                    <ul id="ul24026" class="nav">
                        
                        <li class="nav-item ml-2 mr-2" id="li_Arraw_24026">
                            <div class="border-danger">
                                <span class="text-primary">2.表-AcademicJournals</span><br>
                                <span class="text-primary">==&gt;</span>
                                <button id="btnDelMap24026" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                            </div>
                        </li>
                        <li class="nav-item" id="liSub_Pa_01120929_01122312">
                            <ul id="ul01120929_01122312" class="nav">
                                <li class="nav-item" id="liSub_01120929_01122312"><span class="text-primary"><span class="text-primary">AcademicJournals</span><br>
                                    <span class="text-secondary">JournalSubjectId</span></span></li>
                                <li class="nav-item ml-2 mr-2" id="li_Arraw_24029">
                                    <div class="border-danger">
                                        <span class="text-primary">1.函数-equal</span><br>
                                        <span class="text-primary">==&gt;</span>
                                        <button id="btnDelMap24029" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                    </div>
                                </li>
                                <li class="nav-item" id="liSub_Pa_01120930_01122312">
                                    <ul id="ul01120930_01122312" class="nav">
                                        <li class="nav-item" id="liSub_01120930_01122312"></li>
                                        <li class="nav-item ml-2 mr-2" id="li_Arraw_24016">
                                            <div class="border-danger">
                                                <span class="text-primary">1.表-JournalSubject</span><br>
                                                <span class="text-primary">==&gt;</span>
                                                <button id="btnDelMap24016" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                            </div>
                                        </li>
                                        <li class="nav-item" id="liSub_01120930_01122313"><span class="text-primary"><span class="text-primary">JournalSubject</span><br>
                                            <span class="text-secondary">JournalSubjectName</span></span></li>
                                    </ul>
                                </li>
                                <li class="nav-item" id="liSub_Pa_01120930_01122312">
                                    <ul id="ul01120930_01122312" class="nav">
                                        <li class="nav-item" id="liSub_01120930_01122312"></li>
                                        <li class="nav-item ml-2 mr-2" id="li_Arraw_24020">
                                            <div class="border-danger">
                                                <span class="text-primary">2.表-JournalSubject</span><br>
                                                <span class="text-primary">==&gt;</span>
                                                <button id="btnDelMap24020" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                            </div>
                                        </li>
                                        <li class="nav-item" id="liSub_Pa_01120930_01122314">
                                            <ul id="ul01120930_01122314" class="nav">
                                                <li class="nav-item" id="liSub_01120930_01122314"><span class="text-primary"><span class="text-primary">JournalSubject</span><br>
                                                    <span class="text-secondary">JournalSubjectCategoryId</span></span></li>
                                                <li class="nav-item ml-2 mr-2" id="li_Arraw_24022">
                                                    <div class="border-danger">
                                                        <span class="text-primary">1.函数-equal</span><br>
                                                        <span class="text-primary">==&gt;</span>
                                                        <button id="btnDelMap24022" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                                    </div>
                                                </li>
                                                <li class="nav-item" id="liSub_Pa_01120931_01122314">
                                                    <ul id="ul01120931_01122314" class="nav">
                                                        <li class="nav-item" id="liSub_01120931_01122314"><span class="text-primary"><span class="text-primary">JournalSubjectCategory</span><br>
                                                            <span class="text-secondary">JournalSubjectCategoryId</span></span></li>
                                                        <li class="nav-item ml-2 mr-2" id="li_Arraw_24014">
                                                            <div class="border-danger">
                                                                <span class="text-primary">1.表-JournalSubjectCategory</span><br>
                                                                <span class="text-primary">==&gt;</span>
                                                                <button id="btnDelMap24014" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                                            </div>
                                                        </li>
                                                        <li class="nav-item" id="liSub_01120931_01122315"><span class="text-primary"><span class="text-primary">JournalSubjectCategory</span><br>
                                                            <span class="text-secondary">JournalSubjectCategoryName</span></span></li>
                                                    </ul>
                                                </li>
                                            </ul>
                                        </li>
                                    </ul>
                                </li>
                                <li class="nav-item" id="liSub_Pa_01120930_01122312">
                                    <ul id="ul01120930_01122312" class="nav">
                                        <li class="nav-item" id="liSub_01120930_01122312"><span class="text-primary"><span class="text-primary">JournalSubject</span><br>
                                            <span class="text-secondary">JournalSubjectId</span></span></li>
                                        <li class="nav-item ml-2 mr-2" id="li_Arraw_24021">
                                            <div class="border-danger">
                                                <span class="text-primary">3.表-JournalSubject</span><br>
                                                <span class="text-primary">==&gt;</span>
                                                <button id="btnDelMap24021" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                            </div>
                                        </li>
                                        <li class="nav-item" id="liSub_01120930_01122317"><span class="text-primary"><span class="text-primary">JournalSubject</span><br>
                                            <span class="text-secondary">JournalSubjectCode</span></span></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                    </ul>
                    <ul id="ul24027" class="nav">
                        <li class="nav-item" id="liSub_24027"><span class="text-danger font-weight-bold text-g" style="display: inline-block;">JournalId</span></li>
                        <li class="nav-item ml-2 mr-2" id="li_Arraw_24027">
                            <div class="border-danger">
                                <span class="text-primary">3.表-AcademicJournals</span><br>
                                <span class="text-primary">==&gt;</span>
                                <button id="btnDelMap24027" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                            </div>
                        </li>
                        <li class="nav-item" id="liSub_Pa_01120929_01122314">
                            <ul id="ul01120929_01122314" class="nav">
                                <li class="nav-item" id="liSub_01120929_01122314"><span class="text-primary"><span class="text-primary">AcademicJournals</span><br>
                                    <span class="text-secondary">JournalSubjectCategoryId</span></span></li>
                                <li class="nav-item ml-2 mr-2" id="li_Arraw_24028">
                                    <div class="border-danger">
                                        <span class="text-primary">1.函数-equal</span><br>
                                        <span class="text-primary">==&gt;</span>
                                        <button id="btnDelMap24028" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                    </div>
                                </li>
                                <li class="nav-item" id="liSub_Pa_01120931_01122314">
                                    <ul id="ul01120931_01122314" class="nav">
                                        <li class="nav-item" id="liSub_01120931_01122314"><span class="text-primary"><span class="text-primary">JournalSubjectCategory</span><br>
                                            <span class="text-secondary">JournalSubjectCategoryId</span></span></li>
                                        <li class="nav-item ml-2 mr-2" id="li_Arraw_24014">
                                            <div class="border-danger">
                                                <span class="text-primary">1.表-JournalSubjectCategory</span><br>
                                                <span class="text-primary">==&gt;</span>
                                                <button id="btnDelMap24014" class="btn btn-outline-info btn-sm text-nowrap ml-1" title="删除当前映射">删除</button>
                                            </div>
                                        </li>
                                        <li class="nav-item" id="liSub_01120931_01122315"><span class="text-primary"><span class="text-primary">JournalSubjectCategory</span><br>
                                            <span class="text-secondary">JournalSubjectCategoryName</span></span></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </li>
            </ul>

        </div>
    </form>
</body>
</html>
