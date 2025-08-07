/// <reference path="jsPubFun.js" />
//var clsPubVar4Web = function()
//{
function include(path) {
    var a = document.createElement("script");
    a.type = "text/javascript";
    a.src = path;
    var head = document.getElementsByTagName("head")[0];

    if (IsExistPath(head, a) === false) {
        head.appendChild(a);
    }
}
function IsExistPath(head, a) {
    var arrChildNodes = head.childNodes;
    var intLen = arrChildNodes.length;
    for (var i = 0; i < intLen; i++) {
        var objNode = arrChildNodes[i];
        if (objNode.outerHTML === a.outerHTML) {
            return true;
        }
    }
    return false;
}
var VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中

include(VirtualRootPath + "/js/PubFun/jsPubFun.js");
//var CurrIPAddressAndPort = "http://Localhost:2408";
var CurrIPAddressAndPort = getHostAddress_web();// "http://Localhost:2408";

var CurrPrx = VirtualRootPath + "/WebService";
//"http://localhost:2408/ExamLib/WebService/MyTest1Service.asmx";

var ResponseData;//: tzResponseData 用于记录返回数据 
//}


//获取不带“Http的”根目录
function getVirtualRootPath_web() {
    //获取当前网址，如： http://localhost:8083/uimcardprj/share/meun.jsp
    //var curWwwPath = window.document.location.href;
    //获取主机地址之后的目录，如： uimcardprj/share/meun.jsp
    var pathName = window.document.location.pathname;
    //var pos = curWwwPath.indexOf(pathName);
    //获取主机地址，如： http://localhost:8083
    //var localhostPath = curWwwPath.substring(0, pos);
    //获取带"/"的项目名，如：/uimcardprj
    var projectName = pathName.substring(0, pathName.substr(1).indexOf('/') + 1);
    return (projectName);
}

//获取带“Http的”根目录
function getRootPath_web() {
    //获取当前网址，如： http://localhost:8083/uimcardprj/share/meun.jsp
    var curWwwPath = window.document.location.href;
    //获取主机地址之后的目录，如： uimcardprj/share/meun.jsp
    var pathName = window.document.location.pathname;
    var pos = curWwwPath.indexOf(pathName);
    //获取主机地址，如： http://localhost:8083
    var localhostPath = curWwwPath.substring(0, pos);
    //获取带"/"的项目名，如：/uimcardprj
    var projectName = pathName.substring(0, pathName.substr(1).indexOf('/') + 1);
    return (localhostPath + projectName);
}


//获取带“Http的”主机地址.例如
function getHostAddress_web() {
    //获取当前网址，如： http://localhost:8083/uimcardprj/share/meun.jsp
    var curWwwPath = window.document.location.href;
    //获取主机地址之后的目录，如： uimcardprj/share/meun.jsp
    var pathName = window.document.location.pathname;
    var pos = curWwwPath.indexOf(pathName);
    //获取主机地址，如： http://localhost:8083
    var localhostPath = curWwwPath.substring(0, pos);
    //获取带"/"的项目名，如：/uimcardprj
    //var projectName = pathName.substring(0, pathName.substr(1).indexOf('/') + 1);
    return (localhostPath);
}