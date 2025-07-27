
/*-- -- -- -- -- -- -- -- -- -- --
类名:jsvFieldTabWS
表名:vFieldTab
生成代码版本:2017.12.18.1
生成日期:2018/01/01 16:59:23
生成者:潘以锋
生成服务器IP:1011.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:Web服务转换层
编程语言:JavaScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

/// <summary>
/// vFieldTab(vFieldTab)
/// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode_JavaScript)
/// </summary>
/**
* Created by 潘以锋 on 2018年01月01日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
/// <reference path="../PubFun/tzDictionary.js" />
/// <reference path="../PubFun/tzResponseData.js" />
/// <reference path="../PubFun/tzStringFormat.js" />
/// <reference path="../PubFun/tzGetXmlHttp.js" />
/// <reference path="../PubFun/jsPubVar.js" />
var VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中
include(VirtualRootPath + "/js/PubFun/tzDictionary.js");
include(VirtualRootPath + "/js/PubFun/tzResponseData.js");
include(VirtualRootPath + "/js/PubFun/tzGetXmlHttp.js");
include(VirtualRootPath + "/js/PubFun/jsPubFun.js");
include(VirtualRootPath + "/js/PubFun/jsPubVar.js");
include(VirtualRootPath + "/js/Table_Field/jsvFieldTabEN.js");
var ResponseData;
var ReCallFunc = null;
var clsvFieldTabWS = function () {
    var Param;
    var NameSpace = "http://tempuri.org/";
    var MethodName = "";
    var WEB_SERVICE_URL = "";
    var soapAction = "";
    var objvFieldTabEN;
    this.init = function () {
        this.Param = new Dictionary();
        this.objvFieldTabEN = new clsvFieldTabEN();
        ResponseData = new tzResponseData();
    };
    this.init = function (strMethod, mapParam, pobjvFieldTabEN, pReCallFunc) {
        Param = new Dictionary();
        this.objvFieldTabEN = pobjvFieldTabEN;
        ReCallFunc = pReCallFunc;
        ResponseData = new tzResponseData();
        this.MethodName = strMethod;
        this.Param = mapParam;
        if (this.Param.length() === 0) {
            this.Param = new Dictionary();
        }
        this.WEB_SERVICE_URL = String.format("{0}/{1}/Table_Field/vFieldTabService.asmx", CurrIPAddressAndPort, CurrPrx);
    };

    /// <summary>
    /// 继承Runnable类必须实现的【run】函数
    /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_main_JavaScript)
    /// </summary>
    /// <returns></returns>
    this.main = function () {
        switch (this.MethodName) {
            case "GetJSONObjByFldID":
                ResponseData.what = 1;
                try {
                    this.GetJSONObjByFldID(this.Param);
                }
                catch (err) {
                    myShowErrorMsg(err.message);
                }
                break;
            case "GetJSONObjLst":
                ResponseData.what = 2;
                try {
                    this.GetJSONObjLst(this.Param);
                }
                catch (err) {
                    myShowErrorMsg(err.message);
                }
                break;
            case "AddNewRecordByJSON":
                ResponseData.what = 3;
                try {
                    this.AddNewRecordByJSON(this.Param, this.objvFieldTabEN);
                }
                catch (err) {
                    myShowErrorMsg(err.message);
                }
                break;
            case "UpdateRecordByJSON":
                ResponseData.what = 4;
                try {
                    this.UpdateRecordByJSON(this.Param, this.objvFieldTabEN);
                }
                catch (err) {
                    myShowErrorMsg(err.message);
                }
                break;
            case "DeleteRecord":
                ResponseData.what = 5;
                try {
                    this.DeleteRecord(this.Param);
                }
                catch (err) {
                    myShowErrorMsg(err.message);
                }
                break;
            case "GetFirstJSONObj":
                ResponseData.what = 6;
                try {
                    this.GetFirstJSONObj(this.Param);
                }
                catch (err) {
                    myShowErrorMsg(err.message);
                }
                break;
            case "IsExistRecord":
                ResponseData.what = 7;
                try {
                    this.IsExistRecord(this.Param);
                }
                catch (err) {
                    myShowErrorMsg(err.message);
                }
                break;
            case "GetMaxStrId":
                ResponseData.what = 8;
                try {
                    this.GetMaxStrId(this.Param);
                }
                catch (err) {
                    myShowErrorMsg(err.message);
                }
                break;
            case "GetMaxStrIdByPrefix":
                ResponseData.what = 9;
                try {
                    this.GetMaxStrIdByPrefix(this.Param);
                }
                catch (err) {
                    myShowErrorMsg(err.message);
                }
                break;
            case "GetTopJSONObjLst":
                ResponseData.what = 10;
                try {
                    this.GetTopJSONObjLst(this.Param);
                }
                catch (err) {
                    myShowErrorMsg(err.message);
                }
                break;
            case "GetJSONObjLstByPager":
                ResponseData.what = 11;
                try {
                    this.GetJSONObjLstByPager(this.Param);
                }
                catch (err) {
                    myShowErrorMsg(err.message);
                }
                break;
            case "funGetRecCountByCond":
                ResponseData.what = 12;
                try {
                    this.funGetRecCountByCond(this.Param);
                }
                catch (err) {
                    myShowErrorMsg(err.message);
                }
                break;
            default:
                break;
        }
    };

    /// <summary>
    /// 继承Runnable类必须实现的【run】函数
    /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_start_JavaScript)
    /// </summary>
    /// <returns></returns>
    this.start = function () {
    };

    /// <summary>
    /// 通用的调用WebService函数
    /// mapParam样例:strFldID = "01"
    /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_CallWebService_JavaScript)
    /// </summary>
    /// <param name = "MethodName">函数</param>
    /// <param name = "mapParam">参数列表</param>
    /// <returns>获取相应的记录的对象</returns>
    this.CallWebService = function (strFunctionName, dictPara, myURL) {
        var strPara;
        strPara = "";
        var myKeyss = dictPara.keys();
        var intLength = dictPara.length();
        for (var i = 0; i < intLength; i++) {
            var key = myKeyss[i];
            var value = dictPara.getItem(key);
            var strTemp = String.format("<{0}>{1}</{0}>", key, value);
            strPara = strPara + strTemp;
        }
        var data;
        data = '<?xml version="1.0" encoding="utf-8"?>';
        data = data + '<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">';
        data = data + '<soap:Body>';
        data = data + String.format('<{0} xmlns="http://tempuri.org/">', strFunctionName);
        data = data + strPara;
        data = data + String.format('</{0}>', strFunctionName);
        data = data + '</soap:Body>';
        data = data + '</soap:Envelope>';
        xmlhttp = getXmlHttp();
        var URL = myURL;//WEB_SERVICE_URL;//"http://localhost:2408/ExamLib/WebService/MyTest1Service.asmx";
        xmlhttp.open("POST", URL, true);
        xmlhttp.setRequestHeader("Content-Type", "text/xml; charset=gb2312");
        var strSOAPAction = String.format("http://tempuri.org/{0}", strFunctionName);
        xmlhttp.setRequestHeader("SOAPAction", strSOAPAction);
        xmlhttp.send(data);
        xmlhttp.onreadystatechange = function () {
            //HTTP 请求的状态.当一个 XMLHttpRequest 初次创建时，这个属性的值从 0 开始，直到接收到完整的 HTTP 响应，这个值增加到 4  
            if (xmlhttp.readyState === 4) {
                getReturnValue(strFunctionName);
            }
        };
    };

    /// <summary>
    /// 获取返回值函数
    /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_getReturnValue_JavaScript)
    /// </summary>
    /// <returns></returns>
    function getReturnValue(strFunctionName) {
        //alert(xmlhttp.readyState);
        ////5。接收响应数据
        ////判断对象的状态是交互完成
        //判断http的交互是否成功
        if (xmlhttp.status !== 200) {
            myShowErrorMsg("出错了!!!");
            return;
        }
        //使用responseXML的方式来接收XML数据对象的DOM对象
        var domObj = xmlhttp.responseXML;
        if (domObj) {
            //<message>123123123</message>
            //dom中利用getElementsByTagName可以根据标签名来获取元素节点，返回的是一个数组
            var strReturnTag = strFunctionName + "Result";
            var messageNodes = domObj.getElementsByTagName(strReturnTag);
            if (messageNodes.length > 0) {
                //获取message节点中的文本内容
                //message标签中的文本在dom中是message标签所对应的元素节点的字节点，firstChild可以获取到当前节点的第一个子节点
                //通过以下方式就可以获取到文本内容所对应的节点
                var textNode = messageNodes[0].firstChild;
                //对于文本节点来说，可以通过nodeValue的方式返回文本节点的文本内容
                var responseMessage = "";
                if (textNode === null) {
                    responseMessage = "";
                }
                else {
                    responseMessage = textNode.nodeValue;
                }
                ResponseData.errorId = 0;
                ResponseData.IsFinished = true;
                ResponseData.data = responseMessage;
                ReCallFunc();
                //alert(ResponseData.data);
                //将数据显示在页面上
                //通过dom的方式找到div标签所对应的元素节点
                //var divNode = document.getElementById("result");
                ////设置元素节点中的html内容
                //divNode.innerHTML = responseMessage;
            }
            else {
                ResponseData.IsFinished = true;
                ResponseData.errorId = 1;
                ResponseData.faultString = "XML数据格式错误";
                myShowErrorMsg("XML数据格式错误，原始文本内容为：" + xmlhttp.responseText);
                ReCallFunc();
            }
        }
        else {
            myShowErrorMsg("XML数据格式错误，原始文本内容为：" + xmlhttp.responseText);
        }
    }

    /// <summary>
    /// 根据关键字获取相应的记录的对象
    /// mapParam样例:strFldID = "01"
    ///调用样例:行1:clsvFieldTabWS objvFieldTabWS = new clsvFieldTabWS(mHandler, "GetJSONObjByFldID", values, null);
    ///调用样例:行2:Thread mThread = new Thread(objvFieldTabWS);
    ///调用样例:行3:mThread.start();
    /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetRecordJSONObjByKey_S_JavaScript)
    /// </summary>
    /// <param name = "mapParam">参数列表</param>
    /// <returns>获取相应的记录的对象</returns>
    this.GetJSONObjByFldID = function (mapParam) {
        var strMethodName = "GetJSONObjByFldID";
        try {
            this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);
        }
        catch (objException) {
            var strMsg = "在调用WebService函数时出错，错误信息：\(String(describing: objException.reason))";
            throw strMsg;
        }
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
    ///调用样例:行1:clsvFieldTabWS objvFieldTabWS = new clsvFieldTabWS(mHandler, "GetJSONObjLst", values, null);
    ///调用样例:行2:Thread mThread = new Thread(objvFieldTabWS);
    ///调用样例:行3:mThread.start();
    /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetRecordJSONObjLst_S_JavaScript)
    /// </summary>
    /// <param name = "mapParam">参数列表</param>
    /// <returns>获取的相应记录对象列表</returns>
    this.GetJSONObjLst = function (mapParam) {
        var strMethodName = "GetJSONObjLst";
        try {
            this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);
        }
        catch (objException) {
            var strMsg = "在调用WebService函数时出错，错误信息：\(String(describing: objException.reason))";
            throw strMsg;
        }
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
    ///调用样例:行1:clsvFieldTabWS objvFieldTabWS = new clsvFieldTabWS(mHandler, "GetTopJSONObjLst", values, null);
    ///调用样例:行2:Thread mThread = new Thread(objvFieldTabWS);
    ///调用样例:行3:mThread.start();
    /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetTopRecordJSONObjLst_S_JavaScript)
    /// </summary>
    /// <param name = "mapParam">参数列表</param>
    /// <returns>获取的相应记录对象列表</returns>
    this.GetTopJSONObjLst = function (mapParam) {
        var strMethodName = "GetTopJSONObjLst";
        try {
            this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);
        }
        catch (objException) {
            var strMsg = "在调用WebService函数时出错，错误信息：\(String(describing: objException.reason))";
            throw strMsg;
        }
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
    ///调用样例:行1:clsvFieldTabWS objvFieldTabWS = new clsvFieldTabWS(mHandler, "GetJSONObjLstByPager", values, null);
    ///调用样例:行2:Thread mThread = new Thread(objvFieldTabWS);
    ///调用样例:行3:mThread.start();
    /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetRecordJSONObjLstByPager_S_JavaScript)
    /// </summary>
    /// <param name = "mapParam">参数列表</param>
    /// <returns>获取的相应记录对象列表</returns>
    this.GetJSONObjLstByPager = function (mapParam) {
        var strMethodName = "GetJSONObjLstByPager";
        try {
            this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);
        }
        catch (objException) {
            var strMsg = "在调用WebService函数时出错，错误信息：\(String(describing: objException.reason))";
            throw strMsg;
        }
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
    ///调用样例:行1:clsvFieldTabWS objvFieldTabWS = new clsvFieldTabWS(mHandler, "GetJSONObjLst", values, null);
    ///调用样例:行2:Thread mThread = new Thread(objvFieldTabWS);
    ///调用样例:行3:mThread.start();
    /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetFirstObject_S_JavaScript)
    /// </summary>
    /// <param name = "mapParam">参数列表</param>
    /// <returns>获取的相应记录对象列表</returns>
    this.GetFirstJSONObj = function (mapParam) {
        var strMethodName = "GetFirstJSONObj";
        try {
            this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);
        }
        catch (objException) {
            var strMsg = "在调用WebService函数时出错，错误信息：\(String(describing: objException.reason))";
            throw strMsg;
        }
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// mapParam样例: mapParam.put("strWhereCond", "1 = 1");
    ///调用样例:行1:clsvFieldTabWS objvFieldTabWS = new clsvFieldTabWS(mHandler, "GetJSONObjLst", values, null);
    ///调用样例:行2:Thread mThread = new Thread(objvFieldTabWS);
    ///调用样例:行3:mThread.start();
    /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetMaxStrId_S_JavaScript)
    /// </summary>
    /// <param name = "mapParam">参数列表</param>
    /// <returns>获取的相应记录对象列表</returns>
    this.GetMaxStrId = function (mapParam) {
        var strMethodName = "vFieldTab_GetMaxStrId";
        try {
            this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);
        }
        catch (objException) {
            var strMsg = "在调用WebService函数时出错，错误信息：\(String(describing: objException.reason))";
            throw strMsg;
        }
    };

    /// <summary>
    /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
    /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetMaxStrIdByPrefix_S_JavaScript)
    /// </summary>
    /// <param name = "mapParam">参数列表</param>
    /// <returns>获取的相应记录对象列表</returns>
    this.GetMaxStrIdByPrefix = function (mapParam) {
        var strMethodName = "vFieldTab_GetMaxStrIdByPrefix";
        try {
            this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);
        }
        catch (objException) {
            var strMsg = "在调用WebService函数时出错，错误信息：\(String(describing: objException.reason))";
            throw strMsg;
        }
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// mapParam样例: mapParam.put("strWhereCond", "FldId = '01'");
    ///调用样例:行1:clsvFieldTabWS objvFieldTabWS = new clsvFieldTabWS(mHandler, "GetJSONObjLst", values, null);
    /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_IsExistRecord_S_JavaScript)
    /// </summary>
    /// <param name = "mapParam">参数列表</param>
    /// <returns>获取的相应记录对象列表</returns>
    this.IsExistRecord = function (mapParam) {
        var strMethodName = "vFieldTab_IsExistRecord";
        try {
            this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);
        }
        catch (objException) {
            var strMsg = "在调用WebService函数时出错，错误信息：\(String(describing: objException.reason))";
            throw strMsg;
        }
    };

    /// <summary>
    /// 获取某一条件的记录数
    /// mapParam样例: mapParam.put("strWhereCond", "FldId = '01'");
    ///调用样例:行1:clsvFieldTabWS objvFieldTabWS = new clsvFieldTabWS(mHandler, "GetJSONObjLst", values, null);
    /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_funGetRecCountByCond_JavaScript)
    /// </summary>
    /// <param name = "mapParam">参数列表</param>
    /// <returns>获取某一条件的记录数</returns>
    this.funGetRecCountByCond = function (mapParam) {
        var strMethodName = "vFieldTab_funGetRecCountByCond";
        try {
            this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);
        }
        catch (objException) {
            var strMsg = "在调用WebService函数时出错，错误信息：\(String(describing: objException.reason))";
            throw strMsg;
        }
    };
};