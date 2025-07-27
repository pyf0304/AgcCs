/*
 * 功能：一些公共的功能函数
 * 版本：2019-07-24-01
 * 作者：潘以锋
 * */
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.btnQuery4SelectFileId = "";
    function SetQuery4SelectFileId(strValue) {
        exports.btnQuery4SelectFileId = strValue;
    }
    exports.SetQuery4SelectFileId = SetQuery4SelectFileId;
    function btnQuery4SelectFileId_Click() {
        var hidbtnQueryClientID = getObjByTagAndId("input", "hidbtnQueryClientID");
        if (hidbtnQueryClientID !== null) {
            var btnQuery = getObjByTagAndId("input", hidbtnQueryClientID.value);
            if (btnQuery === null)
                return;
            btnQuery.click();
        }
    }
    exports.btnQuery4SelectFileId_Click = btnQuery4SelectFileId_Click;
    //在当前页面中，获取某名称开始的，某类型（type），某标签(TagName)的对象列表
    function GetObjectLstByTypeTagNameAndStartName(strType, strTagName, strStartName) {
        var objLst = document.getElementsByTagName(strTagName);
        var arrLst = GetArray(objLst);
        var arrFind = arrLst.filter(function (x) { return (x.name.indexOf(strStartName) > -1 && x.type == strType); });
        //var objTargetObjLst = new Array();
        //for (var i = 0; i < objLst.length; i++) {
        //    var objT = objLst[i];
        //    var strObjName = objT.name;
        //    if (strObjName.indexOf(strStartName) > -1) {
        //        if (objT.type === strType) {
        //            objTargetObjLst.push(objT);
        //        }
        //    }
        //}
        //    alert("0000" + objTargetObjLst.length);
        return arrFind;
    }
    exports.GetObjectLstByTypeTagNameAndStartName = GetObjectLstByTypeTagNameAndStartName;
    //在当前页面中，获取某名称开始的，某类型（type），某标签(TagName)的对象列表
    function GetObjectLstByTypeTagNameAndStartIdName(strType, strTagName, strStartIdName) {
        var objLst = document.getElementsByTagName(strTagName);
        var arrLst = GetArray(objLst);
        var arrFind = arrLst.filter(function (x) { return (x.id.indexOf(strStartIdName) > -1 && x.type == strType); });
        //if (arrFind.length > 0) return arrFind[0].value;
        //var objTargetObjLst = new Array();
        //for (var i = 0; i < objLst.length; i++) {
        //    var objT = objLst[i];
        //    var strObjId = objT.id;
        //    if (strObjId.indexOf(strStartIdName) > -1) {
        //        if (objT.type === strType) {
        //            objTargetObjLst.push(objT);
        //        }
        //    }
        //}
        //    alert("0000" + objTargetObjLst.length);
        return arrFind;
    }
    exports.GetObjectLstByTypeTagNameAndStartIdName = GetObjectLstByTypeTagNameAndStartIdName;
    //在当前页面中，获取某名称，某标签(TagName)的对象值
    function getValueByTagAndName(TagType, varName) {
        var ObjList = document.forms[0].getElementsByTagName(TagType);
        var arrLst = GetArray(ObjList);
        var arrFind = arrLst.filter(function (x) { return x.name.indexOf(varName); });
        if (arrFind.length > 0)
            return arrFind[0].value;
        return "";
    }
    exports.getValueByTagAndName = getValueByTagAndName;
    //在当前页面中，获取某名称，某标签(TagName)的对象值
    function getValueByTagAndName2(TagType, varName1, varName2) {
        var ObjList = document.forms[0].getElementsByTagName(TagType);
        var arrLst = GetArray(ObjList);
        var arrFind = arrLst.filter(function (x) { return x.name.indexOf(varName1) && x.name.indexOf(varName2); });
        if (arrFind.length > 0)
            return arrFind[0].value;
        //for (var i = 0; i < ObjList.length; i++) {
        //    var varObjName = ObjList[i].name;
        //    if (varObjName.indexOf(varName1) >= 0 && varObjName.indexOf(varName2) >= 0) {
        //        var varValue = ObjList[i].value;
        //        return varValue;
        //    }
        //}
        return "";
    }
    exports.getValueByTagAndName2 = getValueByTagAndName2;
    //在当前页面中，获取某名称，某标签(TagName)的对象值
    function getValueByObjListAndName(ObjList, varName) {
        //var ObjList = document.forms[0].getElementsByTagName(TagType);
        for (var i = 0; i < ObjList.length; i++) {
            var varObjName = ObjList[i].name;
            if (varObjName.indexOf(varName) >= 0) {
                var varValue = ObjList[i].value;
                return varValue;
            }
        }
        return "";
    }
    exports.getValueByObjListAndName = getValueByObjListAndName;
    function GetArray(arr) {
        var arrLst = new Array();
        for (var i = 0; i < arr.length; i++) {
            var chk = arr[i]; // as HTMLElement;
            arrLst.push(chk);
        }
        return arrLst;
    }
    //在当前页面中，获取某名称Id，某标签(TagName)的对象
    function getObjByTagAndId(TagType, varId) {
        var ObjList = document.forms[0].getElementsByTagName(TagType);
        var arrLst = GetArray(ObjList);
        var arrFind = arrLst.filter(function (x) { return x.id == varId; });
        if (arrFind.length > 0)
            return arrFind[0];
        return null;
        //for (var i = 0; i < ObjList.length; i++) {
        //    var varObjId = ObjList[i].id;
        //    if (varObjId.indexOf(varId) >= 0) {
        //        return ObjList[i];
        //    }
        //}
        //return null;
    }
    exports.getObjByTagAndId = getObjByTagAndId;
    function getObjByClassAndId(ClassName, varId) {
        var ObjList = document.getElementsByClassName(ClassName);
        var arrLst = GetArray(ObjList);
        var arrFind = arrLst.filter(function (x) { return x.id.indexOf(varId); });
        if (arrFind.length > 0)
            return arrFind[0];
        return null;
    }
    exports.getObjByClassAndId = getObjByClassAndId;
    function getObjLstByClass(ClassName) {
        var ObjList = document.getElementsByClassName(ClassName);
        return ObjList;
    }
    exports.getObjLstByClass = getObjLstByClass;
    //在当前页面中，获取某名称Id，某标签(TagName)的对象
    function getObjByTagAndId2(TagType, varId1, varId2) {
        var ObjList = document.forms[0].getElementsByTagName(TagType);
        var arrLst = GetArray(ObjList);
        var arrFind = arrLst.filter(function (x) { return x.id.indexOf(varId1) && x.id.indexOf(varId2); });
        if (arrFind.length > 0)
            return arrFind[0];
        return null;
    }
    exports.getObjByTagAndId2 = getObjByTagAndId2;
    //在当前页面中，在对象列表中获取某名称Id的对象名
    function getObjByObjListAndId(ObjList, varId) {
        //var ObjList = document.forms[0].getElementsByTagName(TagType);
        for (var i = 0; i < ObjList.length; i++) {
            var varObjId = ObjList[i].id;
            if (varObjId.indexOf(varId) >= 0) {
                return ObjList[i];
            }
        }
        return null;
    }
    exports.getObjByObjListAndId = getObjByObjListAndId;
    function IsContainByID(strOrigin, strSub) {
        var result = false;
        try {
            if (strOrigin !== "" && strSub !== "") {
                if (strOrigin.toString().indexOf(strSub) > -1) {
                    result = true;
                }
            }
        }
        catch (e) { }
        return result;
    }
    exports.IsContainByID = IsContainByID;
    function getOsInfo4Page() {
        var objBrowserInfo = getObjByTagAndId("input", "hidBrowserInfo");
        if (objBrowserInfo !== null) {
            objBrowserInfo.value = getBrowserInfo();
        }
    }
    exports.getOsInfo4Page = getOsInfo4Page;
    function getBrowserInfo() {
        var iMachineName;
        var OsObject = "";
        var OsVersion = "";
        var MachineName = "";
        var IsMobile = "";
        var BrowserInfo = "";
        var iLen = 0;
        var ii = -1;
        var strSS = "";
        var isSafari;
        var isFirefox;
        var isCamino;
        var iMobile;
        var iTouch;
        var isMozilla;
        if (navigator.userAgent.indexOf("MSIE") > 0) {
            OsObject = "MSIE";
            if (navigator.userAgent.indexOf("MSIE 6.0") > 0) {
                OsVersion = "6.0";
            }
            else if (navigator.userAgent.indexOf("MSIE 7.0") > 0) {
                OsVersion = "7.0";
            }
            else if (navigator.userAgent.indexOf("MSIE 8.0") > 0) {
                OsVersion = "8.0";
            }
            else if (navigator.userAgent.indexOf("MSIE 9.0") > 0) {
                OsVersion = "9.0";
            }
            else if (navigator.userAgent.indexOf("MSIE 10.0") > 0) {
                OsVersion = "10.0";
            }
            else if (navigator.userAgent.indexOf("MSIE 11.0") > 0) {
                OsVersion = "11.0";
            }
            else if (navigator.userAgent.indexOf("MSIE 12.0") > 0) {
                OsVersion = "12.0";
            }
            else {
                OsVersion = "other version";
            }
            //navigator.appVersion.match(/6./i) == "6." ? 'IE6' : 'other version';//：在已知是IE浏览器的情况下，可以通过此方法判断是否是IE6；
            //navigator.userAgent.indexOf("MSIE 6.0") > 0 ? 'IE7' : 'other version';//：同上；
            //navigator.appVersion.match(/7./i) == "7." ? 'IE7' : 'other version';//：在已知是IE浏览器的情况下，可以通过此方法判断是否是IE7；
            //navigator.userAgent.indexOf("MSIE 7.0") > 0 ? 'IE7' : 'other version';//：同上；
            //navigator.appVersion.match(/8./i) == "8." ? 'IE8' : 'other version';//：在已知是IE浏览器的情况下，可以通过此方法判断是否是IE8；
            //navigator.userAgent.indexOf("MSIE 8.0") > 0 ? 'IE8' : 'other version';//：同上。
            //OsObject = "MSIE" + navigator.appVersion;
        }
        else if (isSafari = navigator.userAgent.indexOf("Safari") > 0) {
            OsObject = "Safari";
            ii = navigator.userAgent.indexOf("Safari");
            iLen = navigator.userAgent.length;
            strSS = navigator.userAgent.substring(ii, iLen);
            OsVersion = strSS.substring(7, strSS.length);
        }
        else if (isFirefox = navigator.userAgent.indexOf("Firefox") > 0) {
            OsObject = "Firefox";
            ii = navigator.userAgent.indexOf("Firefox");
            iLen = navigator.userAgent.length;
            strSS = navigator.userAgent.substring(ii, iLen);
            OsVersion = strSS.substring(8, strSS.length);
        }
        else if (isCamino = navigator.userAgent.indexOf("Camino") > 0) {
            OsObject = "Camino";
            ii = navigator.userAgent.indexOf("Camino");
            iLen = navigator.userAgent.length;
            var strSS = navigator.userAgent.substring(ii, iLen);
            OsVersion = strSS.substring(7, strSS.length);
        }
        else if (isMozilla = navigator.userAgent.indexOf("Gecko/") > 0) {
            OsObject = "Gecko";
            ii = navigator.userAgent.indexOf("Gecko");
            iLen = navigator.userAgent.length;
            strSS = navigator.userAgent.substring(ii, iLen);
            OsVersion = strSS.substring(6, strSS.length);
        }
        if (iMachineName = navigator.userAgent.indexOf("iPhone") > 0) {
            MachineName = "iPhone";
        }
        else if (iMachineName = navigator.userAgent.indexOf("iPad") > 0) {
            MachineName = "iPad";
        }
        else if (iMachineName = navigator.userAgent.indexOf("Android") > 0) {
            MachineName = "Android";
        }
        else if (iMachineName = navigator.userAgent.indexOf("Android") > 0) {
            MachineName = "Android";
        }
        else if ((iMachineName = navigator.userAgent.indexOf("ARM") > 0) && (iTouch = navigator.userAgent.indexOf("Touch") > 0)) {
            MachineName = "Surface";
        }
        else {
            MachineName = "PC";
        }
        if (iMobile = navigator.userAgent.indexOf("Mobile") > 0) {
            IsMobile = "true";
        }
        else {
            IsMobile = "false";
        }
        BrowserInfo = OsObject + "|" + OsVersion + "|" + MachineName + "|" + IsMobile;
        return BrowserInfo;
    }
    exports.getBrowserInfo = getBrowserInfo;
    //关闭父窗口
    function ParentClose() {
        //   parent.window.opener = null;
        parent.window.close();
    }
    exports.ParentClose = ParentClose;
    //关闭当前窗口
    function WindowClose() {
        window.opener = null;
        window.close();
    }
    exports.WindowClose = WindowClose;
    function ShowSelectFileDiv(TextBox4SelectFile) {
        //strTextBox4SelectFile = TextBox4SelectFile;
        var hidFileName = getObjByTagAndId("input", "hidFileName");
        if (hidFileName === null)
            return;
        hidFileName.value = TextBox4SelectFile;
        var objDiv4SelectFile = getObjByTagAndId("div", "divSelectFile");
        if (objDiv4SelectFile === null)
            return;
        if (objDiv4SelectFile) {
            if (objDiv4SelectFile.style.display === 'block') {
                Tz_HideDiv4Element(objDiv4SelectFile);
            }
            else {
                Tz_ShowDiv4Element(objDiv4SelectFile);
            }
        }
        var divMsg = getObjByTagAndId("div", "divMsg");
        if (divMsg !== null) {
            var strType = "BindFileList";
            //CallServer("BindData|" + strType + "!none" , divMsg);
        }
        //alert(objDiv4SelectFile);
    }
    exports.ShowSelectFileDiv = ShowSelectFileDiv;
    function ShowSelectFileDiv2() {
        var objDiv4SelectFile = getObjByTagAndId("div", "divSelectFile");
        if (objDiv4SelectFile === null)
            return;
        if (objDiv4SelectFile) {
            //objDiv4SelectFile.style.float = "center";
            //objDiv4SelectFile.style.border = "1px";
            objDiv4SelectFile.style.display = 'block';
            objDiv4SelectFile.style.visibility = "visible"; //显示
        }
    }
    exports.ShowSelectFileDiv2 = ShowSelectFileDiv2;
    function SetShowSelectFileDiv(NewValue) {
        var hidFileName = getObjByTagAndId("input", "hidFileName");
        if (hidFileName === null)
            return;
        var strTextBox4SelectFile1 = hidFileName.value;
        var objTextBox4SelectFile = getObjByTagAndId("input", strTextBox4SelectFile1);
        if (objTextBox4SelectFile === null)
            return;
        objTextBox4SelectFile.value = NewValue;
    }
    exports.SetShowSelectFileDiv = SetShowSelectFileDiv;
    function Tz_ShowDiv(strDivName) {
        var objDiv = getObjByTagAndId("div", strDivName);
        if (objDiv === null)
            return;
        if (objDiv) {
            //objDiv4SelectFile.style.float = "center";
            //objDiv4SelectFile.style.border = "1px";
            objDiv.style.display = 'block';
            objDiv.style.visibility = "visible"; //显示
        }
        //alert(objDiv4SelectFile);
    }
    exports.Tz_ShowDiv = Tz_ShowDiv;
    function Tz_HideDiv(strDivName) {
        var objDiv = getObjByTagAndId("div", strDivName);
        if (objDiv === null)
            return;
        if (objDiv) {
            objDiv.style.display = 'none';
            objDiv.style.visibility = "hidden"; //隐藏        
        }
        //alert(objDiv4SelectFile);
    }
    exports.Tz_HideDiv = Tz_HideDiv;
    function Tz_ShowDiv4Element(objDiv) {
        //var objDiv = getObjByTagAndId("div", strDivName);
        if (objDiv === null)
            return;
        if (objDiv) {
            //objDiv4SelectFile.style.float = "center";
            //objDiv4SelectFile.style.border = "1px";
            objDiv.style.display = 'block';
            objDiv.style.visibility = "visible"; //显示
        }
        //alert(objDiv4SelectFile);
    }
    exports.Tz_ShowDiv4Element = Tz_ShowDiv4Element;
    function Tz_HideDiv4Element(objDiv) {
        //var objDiv = getObjByTagAndId("div", strDivName);
        if (objDiv === null)
            return;
        if (objDiv) {
            objDiv.style.display = 'none';
            objDiv.style.visibility = "hidden"; //隐藏        
        }
        //alert(objDiv4SelectFile);
    }
    exports.Tz_HideDiv4Element = Tz_HideDiv4Element;
    function ReceiveServerData(result, context) {
        if (result !== "") {
            context.innerHTML = result;
        }
    }
    exports.ReceiveServerData = ReceiveServerData;
    function OnlyShowDiv(divName4Disp, parentClassName, subClassName) {
        var ObjLst = getObjLstByClass(parentClassName);
        //var intCount;
        //intCount = ObjLst.length;
        for (var i = 0; i < ObjLst.length; i++) {
            var divCurr = ObjLst[i];
            var varObjId = divCurr.id;
            if (varObjId === divName4Disp) {
                var subDivLst = divCurr.getElementsByClassName(subClassName);
                for (var j = 0; j < subDivLst.length; j++) {
                    var divInFor = subDivLst[j];
                    Tz_ShowDiv4Element(divInFor);
                }
            }
            else {
                var subDivLst = divCurr.getElementsByClassName(subClassName);
                for (var j = 0; j < subDivLst.length; j++) {
                    var divInFor = subDivLst[j];
                    Tz_HideDiv4Element(divInFor);
                }
            }
        }
        //alert(intCount.toString());
        //Tz_HideDiv("a1");
    }
    exports.OnlyShowDiv = OnlyShowDiv;
    function myShowErrorMsg(strErrInfo) {
        var funCurrFunction = arguments.callee; //获取函数定义的全部内容
        var arrFuncName = Array();
        while (funCurrFunction !== null) {
            arrFuncName.push((funCurrFunction).name);
            //arrFuncName.push(funCurrFunction.toString());
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
                if (strTop !== "匿名") {
                    strPath = strPath + "->" + strTop + "()";
                }
            }
            if (arrFuncName.length === 0) {
                break;
            }
            strTop = arrFuncName.pop();
        }
        var strErrorMsg = "\u51FA\u9519\u4FE1\u606F:" + strErrInfo + " (\u9519\u8BEF\u6765\u81EA\u4E8E\u51FD\u6570\uFF1A" + strPath + ")";
        alert(strErrorMsg);
    }
    exports.myShowErrorMsg = myShowErrorMsg;
    function GetCurrClassFunc() {
        var funCurrFunction = arguments.callee; //获取函数定义的全部内容
        var arrFuncName = Array();
        while (funCurrFunction !== null) {
            arrFuncName.push((funCurrFunction).name);
            //arrFuncName.push(funCurrFunction.toString());
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
                if (strTop !== "匿名") {
                    strPath = strPath + "->" + strTop + "()";
                }
            }
            if (arrFuncName.length === 0) {
                break;
            }
            strTop = arrFuncName.pop();
        }
        return strPath;
    }
    exports.GetCurrClassFunc = GetCurrClassFunc;
    function GetStrLen(strTemp) {
        var len;
        //byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
        len = strTemp.length; //.characters.count; //will output as 3+3*2=9
        return len;
    }
    exports.GetStrLen = GetStrLen;
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
    exports.getVirtualRootPath_web = getVirtualRootPath_web;
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
    exports.getRootPath_web = getRootPath_web;
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
    exports.getHostAddress_web = getHostAddress_web;
    function LogError(objException) {
        //Log the error information to the Application Log
        var strLogMsg;
    }
    exports.LogError = LogError;
});
