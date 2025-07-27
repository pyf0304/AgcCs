//var clsPubFun4Web = function () {

function myBool(strBoolValue) {
    if (strBoolValue === "true") {
        return true;
    }
    if (strBoolValue === "True") {
        return true;
    }
    if (strBoolValue === "TRUE") {
        return true;
    }
    return false;
}
//提示信息
function myAlert(strInfo) {
    var funCurrFunction = arguments.callee;//获取函数定义的全部内容
    var arrFuncName = Array();
    while (funCurrFunction !== null) {
        arrFuncName.push(funCurrFunction.name);
        funCurrFunction = funCurrFunction.caller;
    }
    var strPath = "";
    var strTop = arrFuncName.pop();
    while (arrFuncName.length >= 0) {
        if (strTop === "") {
            strTop = "匿名";
        }
        if (strPath === "") {
            strPath = strTop + "()";
        }
        else {
            strPath = strPath + "->" + strTop + "()";
        }
        if (arrFuncName.length == 0) {
            break;
        }
        strTop = arrFuncName.pop();
    }
    var strAlertMsg = String.format("信息:{0}  (自于函数：{1})",
       strInfo, strPath);
    alert(strAlertMsg);

}
//显示错误信息
function myShowErrorMsg(strErrInfo) {
    var funCurrFunction = arguments.callee;//获取函数定义的全部内容
    var arrFuncName = Array();
    while (funCurrFunction !== null) {
        arrFuncName.push(funCurrFunction.name);
        funCurrFunction = funCurrFunction.caller;
    }
    var strPath = "";
    var strTop = arrFuncName.pop();
    while (arrFuncName.length >= 0) {
        if (strTop === "") {
            strTop = "匿名";
        }
        if (strPath === "") {
            strPath = strTop + "()";
        }
        else {
            strPath = strPath + "->" + strTop + "()";
        }
        if (arrFuncName.length == 0) {
            break;
        }
        strTop = arrFuncName.pop();
    }

    var strErrorMsg = String.format("出错信息:{0}   (错误来自于函数：{1})",
        strErrInfo, strPath);
    alert(strErrorMsg);
}
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

//获取当前函数名的样例
function fun_name(num) {
    var funCurrFunction = arguments.callee.toString();//获取函数定义的全部内容
    //var funcPath = arguments.callee.[[FunctionLocation]];
    var parentFunc = arguments.callee.caller.toString();
    var re = /function\s*(\w*)/i;
    var matches = re.exec(funCurrFunction);
    var strCurrFuncName = matches[1];
    var matches_Parent = re.exec(parentFunc);
    var strParentFuncName = matches_Parent[1];

    myAlert(strParentFuncName + ":" + strCurrFuncName);//获取函数定义的名称

}

function funGetFuncPath(num) {
    var funCurrFunction = arguments.callee;//获取函数定义的全部内容
    var arrFuncName = Array();
    while (funCurrFunction !== null) {
        arrFuncName.push(funCurrFunction.name);
        funCurrFunction = funCurrFunction.caller;
    }
    var strPath = "";
    var strTop = arrFuncName.pop();
    while (arrFuncName.length >= 0) {
        if (strPath === "") {
            strPath = strTop + "()";
        }
        else {
            strPath = strPath + "->" + strTop + "()";
        }
        if (arrFuncName.length == 0) {
            break;
        }
        strTop = arrFuncName.pop();
    }
    ////var funcPath = arguments.callee.[[FunctionLocation]];
    //var parentFunc = arguments.callee.caller.toString();
    //var re = /function\s*(\w*)/i;
    //var matches = re.exec(tmp);
    //var strCurrFuncName = matches[1];
    //var matches_Parent = re.exec(parentFunc);
    //var strParentFuncName = matches_Parent[1];

    myAlert("当前函数路径:" + strPath);//获取函数定义的名称

}
//}

String.format = function () {
    if (arguments.length === 0)
        return null;

    var str = arguments[0];
    for (var i = 1; i < arguments.length; i++) {
        var re = new RegExp('\\{' + (i - 1) + '\\}', 'gm');
        str = str.replace(re, arguments[i]);
    }
    return str;
}

function getStrLen(strTemp)//->Int 
{
    var len;
    //byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
    len = strTemp.length;//.characters.count; //will output as 3+3*2=9
    return len;
}


//在当前页面中，获取某名称Id，某标签(TagName)的对象
function getObjByTagAndId(TagType, varId) {
    var ObjList = document.forms[0].getElementsByTagName(TagType);

    for (var i = 0; i < ObjList.length; i++) {
        var varObjId = ObjList[i].id;
        if (varObjId.indexOf(varId) >= 0) {
            return ObjList[i];
        }
    }
    return null;
}

//在当前页面中，获取某名称Id，某标签(TagName)的对象
function getObjByTagAndId2(TagType, varId1, varId2) {
    var ObjList = document.forms[0].getElementsByTagName(TagType);

    for (var i = 0; i < ObjList.length; i++) {
        var varObjId = ObjList[i].id;
        if (varObjId.indexOf(varId1) >= 0 && varObjId.indexOf(varId2) >= 0) {
            return ObjList[i];
        }
    }
    return null;
}

function GetArray(arr) {
    let arrLst = new Array();
    for (var i = 0; i < arr.length; i++) {
        var chk = arr[i];
        arrLst.push(chk);
    }
    return arrLst;
};