//模拟在JS中的string.format函数

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
//var a = "I Love {0}, and You Love {1},Where are {0}! {4}";
//alert(String.format(a, "You","Me")); 

//alert(a.format("You","Me"));

var btnQuery4SelectFileId = "";
function SetQuery4SelectFileId(strValue) {
    btnQuery4SelectFileId = strValue;
}
function btnQuery4SelectFileId_Click() {

    var hidbtnQueryClientID = getObjByTagAndId("input", "hidbtnQueryClientID");
    if (hidbtnQueryClientID !== "") {
        var btnQuery = getObjByTagAndId("input", hidbtnQueryClientID.value);
        if (btnQuery === null) return;
        btnQuery.click();
    }
}

//在当前页面中，获取某名称开始的，某类型（type），某标签(TagName)的对象列表
function GetObjectLstByTypeTagNameAndStartName(strType, strTagName, strStartName) {
    var objLst = document.getElementsByTagName(strTagName);
    var objTargetObjLst = new Array();
    for (var i = 0; i < objLst.length; i++) {
        var objT = objLst[i];
        var strObjName = objT.name;
        if (strObjName.indexOf(strStartName) > -1) {
            if (objT.type === strType) {
                objTargetObjLst.push(objT);
            }
        }
    }
    //    alert("0000" + objTargetObjLst.length);
    return objTargetObjLst;
}

//在当前页面中，获取某名称开始的，某类型（type），某标签(TagName)的对象列表
function GetObjectLstByTypeTagNameAndStartIdName(strType, strTagName, strStartIdName) {
    var objLst = document.getElementsByTagName(strTagName);
    var objTargetObjLst = new Array();
    for (var i = 0; i < objLst.length; i++) {
        var objT = objLst[i];
        var strObjId = objT.id;
        if (strObjId.indexOf(strStartIdName) > -1) {
            if (objT.type === strType) {
                objTargetObjLst.push(objT);
            }
        }
    }
    //    alert("0000" + objTargetObjLst.length);
    return objTargetObjLst;
}

//在当前页面中，获取某名称，某标签(TagName)的对象值
function getValueByTagAndName(TagType, varName) {
    var ObjList = document.forms[0].getElementsByTagName(TagType);

    for (var i = 0; i < ObjList.length; i++) {
        var varObjName = ObjList[i].name;
        if (varObjName.indexOf(varName) >= 0) {
            var varValue = ObjList[i].value;
            return varValue;
        }
    }
    return "";
}


//在当前页面中，获取某名称，某标签(TagName)的对象值
function getValueByTagAndName2(TagType, varName1, varName2) {
    var ObjList = document.forms[0].getElementsByTagName(TagType);

    for (var i = 0; i < ObjList.length; i++) {
        var varObjName = ObjList[i].name;
        if (varObjName.indexOf(varName1) >= 0 && varObjName.indexOf(varName2) >= 0) {
            var varValue = ObjList[i].value;
            return varValue;
        }
    }
    return "";
}

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
Array.prototype.indexOf = function (val) {
    for (var i = 0; i < this.length; i++) {
        if (this[i] == val) return i;
    }
    return -1;
};
Array.prototype.remove = function (val) {
    var index = this.indexOf(val);
    if (index > -1) {
        this.splice(index, 1);
    }
};
Array.prototype.contains1 = function (id) {
    var i = this.length;
    while (i--) {
        if (id.indexOf(this[i]) > -1) {
            return true;
        }
    }
    return false;
}
function GetArray(arr) {
    let arrLst = new Array();
    for (var i = 0; i < arr.length; i++) {
        var chk = arr[i];
        arrLst.push(chk);
    }
    return arrLst;
};
//在当前页面中，获取某名称Id，某标签(TagName)的对象
function getObjByTagAndId(TagType, varId) {
    var ObjList = document.forms[0].getElementsByTagName(TagType);
    var arrObj = GetArray(ObjList);
    arrObj = arrObj.filter(x => x.id.indexOf(varId) >= 0);
    if (arrObj.length > 0) return arrObj[0];

    return null;
}


//在当前页面中，获取某名称Id，某标签(TagName)的对象
function getObjByTagAndId2(TagType, varId1, varId2) {
    var ObjList = document.forms[0].getElementsByTagName(TagType);
    var arrObj = GetArray(ObjList);
    arrObj = arrObj.filter(x => x.id.indexOf(varId1) >= 0);
    arrObj = arrObj.filter(x => x.id.indexOf(varId2) >= 0);
    if (arrObj.length > 0) return arrObj[0];
    return null;
}
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

function warning_confirm(flag) {//flag 1 删除 0 修改
    var tableList = document.getElementsByTagName("TABLE");
    if (tableList.length > 0) {
        for (var i = 0; i < tableList.length; i++) {
            if (IsContainByID(tableList[i].id, "gv") || IsContainByID(tableList[i].id, "GridView")) {
                var inputList = tableList[i].getElementsByTagName("INPUT");
                for (var j = 0; j < inputList.length; j++) {
                    if (inputList[j].type === "checkbox") {
                        if (inputList[j].checked) {
                            if (flag) {
                                return confirm("您确认真的要删除吗？");
                            }
                            else {
                                return true;
                            }
                        }
                    }
                }
                alert("请至少选择一条记录后再进行操作！");
                return false;
            }
        }
    }
    else {
        alert("请选择后再进行操作！");
        return false;
    }
}

function IsContainByID(strOrigin, strSub) {
    var result = false;
    try {
        if (strOrigin !== "" && strSub !== "") {
            if (strOrigin.toString().indexOf(strSub) > -1) {
                result = true;
            }
        }
    }
    catch (e)
    { }
    return result;
}

function getOsInfo4Page() {
    var objBrowserInfo = getObjByTagAndId("input", "hidBrowserInfo");
    if (objBrowserInfo !== null) {
        objBrowserInfo.value = getBrowserInfo();
    }
}
function getBrowserInfo() {
    var OsObject = "";
    var OsVersion = "";
    var MachineName = "";
    var IsMobile = "";
    var BrowserInfo = "";
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
        var ii = navigator.userAgent.indexOf("Safari");
        var iLen = navigator.userAgent.length;
        var strSS = navigator.userAgent.substring(ii, iLen);
        OsVersion = strSS.substring(7, strSS.length);
    }
    else if (isFirefox = navigator.userAgent.indexOf("Firefox") > 0) {
        OsObject = "Firefox";
        var ii = navigator.userAgent.indexOf("Firefox");
        var iLen = navigator.userAgent.length;
        var strSS = navigator.userAgent.substring(ii, iLen);
        OsVersion = strSS.substring(8, strSS.length);
    }
    else if (isCamino = navigator.userAgent.indexOf("Camino") > 0) {
        OsObject = "Camino";
        var ii = navigator.userAgent.indexOf("Camino");
        var iLen = navigator.userAgent.length;
        var strSS = navigator.userAgent.substring(ii, iLen);
        OsVersion = strSS.substring(7, strSS.length);
    }
    else if (isMozilla = navigator.userAgent.indexOf("Gecko/") > 0) {
        OsObject = "Gecko";
        var ii = navigator.userAgent.indexOf("Gecko");
        var iLen = navigator.userAgent.length;
        var strSS = navigator.userAgent.substring(ii, iLen);
        OsVersion = strSS.substring(6, strSS.length);
    }
    if (iMahineName = navigator.userAgent.indexOf("iPhone") > 0) {
        MachineName = "iPhone";
    }
    else if (iMahineName = navigator.userAgent.indexOf("iPad") > 0) {
        MachineName = "iPad";
    }
    else if (iMahineName = navigator.userAgent.indexOf("Android") > 0) {
        MachineName = "Android";
    }
    else if (iMahineName = navigator.userAgent.indexOf("Android") > 0) {
        MachineName = "Android";
    }
    else if ((iMahineName = navigator.userAgent.indexOf("ARM") > 0) && (iTouch = navigator.userAgent.indexOf("Touch") > 0)) {
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

//关闭父窗口
function ParentClose() {
 //   parent.window.opener = null;
    parent.window.close();
}

//关闭当前窗口
function WindowClose() {
    window.opener = null;
    window.close();
}

function ShowSelectFileDiv(TextBox4SelectFile) {
    //strTextBox4SelectFile = TextBox4SelectFile;
    var hidFileName = getObjByTagAndId("input", "hidFileName");
    if (hidFileName == null) return;
    hidFileName.value = TextBox4SelectFile;
    var objDiv4SelectFile = getObjByTagAndId("div", "divSelectFile");
    if (objDiv4SelectFile == null) return;

    if (objDiv4SelectFile) {
        if (objDiv4SelectFile.style.display == 'block') {
            objDiv4SelectFile.style.display = 'none';
            objDiv4SelectFile.style.visibility = "hidden";//隐藏
        } else {
            //objDiv4SelectFile.style.float = "center";
            //objDiv4SelectFile.style.border = "1px";
            objDiv4SelectFile.style.display = 'block';
            objDiv4SelectFile.style.visibility = "visible";//显示

        }
    }
    var divMsg = getObjByTagAndId("div", "divMsg");
    if (divMsg != null) {
        var strType = "BindFileList";
        //CallServer("BindData|" + strType + "!none" , divMsg);
    }
    //alert(objDiv4SelectFile);
}



function ShowSelectFileDiv2() {
    var objDiv4SelectFile = getObjByTagAndId("div", "divSelectFile");
    if (objDiv4SelectFile == null) return;

    if (objDiv4SelectFile) {

        //objDiv4SelectFile.style.float = "center";
        //objDiv4SelectFile.style.border = "1px";
        objDiv4SelectFile.style.display = 'block';
        objDiv4SelectFile.style.visibility = "visible";//显示

        
    }
}



function SetShowSelectFileDiv(NewValue) {
    var hidFileName = getObjByTagAndId("input", "hidFileName");
    if (hidFileName === null) return;
    var strTextBox4SelectFile1 = hidFileName.value;
    var objTextBox4SelectFile = getObjByTagAndId("input", strTextBox4SelectFile1);
    if (objTextBox4SelectFile === null) return;

    objTextBox4SelectFile.value = NewValue;
}


function Tz_ShowDiv(strDivName) {
 
    var objDiv = getObjByTagAndId("div", strDivName);
    if (objDiv === null) return;

    if (objDiv) {
      
            //objDiv4SelectFile.style.float = "center";
            //objDiv4SelectFile.style.border = "1px";
        objDiv.style.display = 'block';
        objDiv.style.visibility = "visible";//显示

      
    }
    //alert(objDiv4SelectFile);
}

function Tz_HideDiv(strDivName) {
  
    var objDiv = getObjByTagAndId("div", strDivName);
    if (objDiv === null) return;
    if (objDiv) {
        objDiv.style.display = 'none';
        objDiv.style.visibility = "hidden";//隐藏        
    }
    //alert(objDiv4SelectFile);
}


function ReceiveServerData(result, context) {
    if (result !== "") {
        context.innerHTML = result;
    }
}



function EditRecord(divClientId, strKeyId) {
    
    var divEditRegion = getObjByTagAndId("div", divClientId); 
    var strType = "EditTeachingTimeDistribution";
    CallServer("EditRecord|" + strType + "!" + strKeyId, divEditRegion);

}