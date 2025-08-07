
/*-- -- -- -- -- -- -- -- -- -- --
类名:jsvPrjTabWS4Controller
表名:vPrjTab
生成代码版本:2017.12.18.1
生成日期:2018/01/01 17:02:09
生成者:潘以锋
生成服务器IP:1011.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:Web服务转换高层
编程语言:JavaScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/

/// <summary>
/// v工程表(vPrjTab)
/// (AutoGCLib.AutoGC6_Controller:A_GenTableObjWSController_JavaScript)
/// </summary>
/**
* Created by 潘以锋 on 2018年01月01日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
/// <reference path="jsvPrjTabWS.js" />
/// <reference path="../PubFun/jsPubFun.js" />
/// <reference path="../PubFun/jsTableObjWS4ControllerDelegate.js" />
/// <reference path="../PubFun/tzDictionary.js" />
/// <reference path="jsvPrjTabEN.js" />
/// <reference path="jsvPrjTabBL.js" />
var VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中
include(VirtualRootPath + "/js/PubFun/jsPubFun.js");
include(VirtualRootPath + "/js/PubFun/jsTableObjWS4ControllerDelegate.js");
include(VirtualRootPath + "/js/PubFun/tzDictionary.js");
include(VirtualRootPath + "/js/PubFun/jsPubVar.js");
include(VirtualRootPath + "/js/Table_Field/jsvPrjTabWS.js");
include(VirtualRootPath + "/js/Table_Field/jsvPrjTabEN.js");
include(VirtualRootPath + "/js/Table_Field/jsvPrjTabBL.js");
var objTableObjWS4ControllerDelegate;
var theTimer;
var ClassName;
var objvPrjTabBL;
var clsvPrjTabWS4Controller = function () {
    this.init = function () {
        ClassName = "clsvPrjTabWS4Controller";
        objvPrjTabBL = new clsvPrjTabBL();
    };
    this.init = function (strMethod, mapParam, pobjvPrjTabEN) {
        ClassName = "clsvPrjTabWS4Controller";
        objvPrjTabBL = new clsvPrjTabBL();
    };

    /// <summary>
    /// 根据条件在表中检查是否满足条件的记录
    /// (AutoGCLib.AutoGC6_Controller:Gen_4WS4Controller_JavaScript_IsExistRecord)
    /// </summary>
    /// <param name = "strWhereCond">检查存在的条件</param>
    /// <returns>存在返回true,不存在返回：false</returns>
    this.IsExistRecord = function (strWhereCond) {
        var values = new Dictionary();
        values.add("strWhereCond", strWhereCond);
        var pobjvPrjTabEN = new clsvPrjTabEN();
        var objvPrjTabWS = new clsvPrjTabWS();
        objvPrjTabWS.init("IsExistRecord", values, pobjvPrjTabEN, IsFinished4WebService);
        objvPrjTabWS.main();
        //theTimer = setInterval(function(){IsFinished4WebService()}, 1000);
    };

    /// <summary>
    /// 根据条件在表中检查是否满足条件的记录
    /// (AutoGCLib.AutoGC6_Controller:Gen_4WS4Controller_JavaScript_funGetRecCountByCond)
    /// </summary>
    /// <param name = "strWhereCond">检查存在的条件</param>
    /// <returns>存在返回true,不存在返回：false</returns>
    this.funGetRecCountByCond = function (strWhereCond) {
        var values = new Dictionary();
        values.add("strWhereCond", strWhereCond);
        var pobjvPrjTabEN = new clsvPrjTabEN();
        var objvPrjTabWS = new clsvPrjTabWS();
        objvPrjTabWS.init("funGetRecCountByCond", values, pobjvPrjTabEN, IsFinished4WebService);
        objvPrjTabWS.main();
        //theTimer = setInterval(function(){IsFinished4WebService()}, 1000);
    };

    /// <summary>
    /// 根据条件获取相应的第一条记录的对象
    /// (AutoGCLib.AutoGC6_Controller:Gen_4WS4Controller_JavaScript_GetFirstRecord)
    /// </summary>
    /// <param name = "strWhereCond">条件</strWhereCond>
    /// <returns>获取相应的记录的对象</returns>
    this.GetFirstvPrjTab = function (strWhereCond) {
        var values = new Dictionary();
        values.add("strWhereCond", strWhereCond);
        var pobjvPrjTabEN = new clsvPrjTabEN();
        var objvPrjTabWS = new clsvPrjTabWS();
        objvPrjTabWS.init("GetFirstJSONObj", values, pobjvPrjTabEN, IsFinished4WebService);
        objvPrjTabWS.main();
        //theTimer = setInterval(function(){IsFinished4WebService()}, 1000);
    };

    /// <summary>
    /// 根据关键字获取相应的记录的对象
    /// (AutoGCLib.AutoGC6_Controller:Gen_4WS4Controller_JavaScript_GetRecordObjByKey)
    /// </summary>
    /// <param name = "strTabId">关键字的值</param>
    /// <returns>根据关键字获取的对象</returns>
    this.GetObjByTabId = function (strTabId) {
        var values = new Dictionary();
        values.add("strTabId", strTabId);
        var pobjvPrjTabEN = new clsvPrjTabEN();
        var objvPrjTabWS = new clsvPrjTabWS();
        objvPrjTabWS.init("GetJSONObjByTabId", values, pobjvPrjTabEN, IsFinished4WebService);
        objvPrjTabWS.main();
        //theTimer = setInterval(function(){IsFinished4WebService()}, 1000);
    };

    /// <summary>
    /// 根据条件获取相应的记录对象列表
    /// (AutoGCLib.AutoGC6_Controller:Gen_4WS4Controller_JavaScript_GetJSONObjLst)
    /// </summary>
    /// <param name = "strWhereCond">条件</strWhereCond>
    /// <returns>获取相应的记录的对象</returns>
    this.GetJSONObjLst = function (strWhereCond) {
        var values = new Dictionary();
        values.add("strWhereCond", strWhereCond);
        var pobjvPrjTabEN = new clsvPrjTabEN();
        var objvPrjTabWS = new clsvPrjTabWS();
        objvPrjTabWS.init("GetJSONObjLst", values, pobjvPrjTabEN, IsFinished4WebService);
        objvPrjTabWS.main();
        //theTimer = setInterval(function(){IsFinished4WebService()}, 1000);
    };

    /// <summary>
    /// 根据条件获取顶部相应的记录对象列表
    /// (AutoGCLib.AutoGC6_Controller:Gen_4WS4Controller_JavaScript_GetTopJSONObjLst)
    /// </summary>
    /// <param name = "intTopSize">顶部记录数</strWhereCond>
    /// <param name = "strWhereCond">条件</strWhereCond>
    /// <returns>获取相应的记录的对象</returns>
    this.GetTopJSONObjLst = function (intTopSize, strWhereCond) {
        var values = new Dictionary();
        values.add("intTopSize", intTopSize);
        values.add("strWhereCond", strWhereCond);
        var pobjvPrjTabEN = new clsvPrjTabEN();
        var objvPrjTabWS = new clsvPrjTabWS();
        objvPrjTabWS.init("GetTopJSONObjLst", values, pobjvPrjTabEN, IsFinished4WebService);
        objvPrjTabWS.main();
        //theTimer = setInterval(function(){IsFinished4WebService()}, 1000);
    };

    /// <summary>
    /// 根据条件获取顶部相应的记录对象列表
    /// (AutoGCLib.AutoGC6_Controller:Gen_4WS4Controller_JavaScript_GetJSONObjLstByPager)
    /// </summary>
    /// <param name = "intPageIndex">页序号</param>
    /// <param name = "intPageSize">页记录数</param>
    /// <param name = "strWhereCond">条件</param>
    /// <param name = "strOrderBy">排序方式</param>
    /// <returns>获取相应的记录的对象</returns>
    this.GetJSONObjLstByPager = function (intPageIndex, intPageSize, strWhereCond, strOrderBy) {
        var values = new Dictionary();
        values.add("intPageIndex", intPageIndex);
        values.add("intPageSize", intPageSize);
        values.add("strWhereCond", strWhereCond);
        values.add("strOrderBy", strOrderBy);
        var pobjvPrjTabEN = new clsvPrjTabEN();
        var objvPrjTabWS = new clsvPrjTabWS();
        objvPrjTabWS.init("GetJSONObjLstByPager", values, pobjvPrjTabEN, IsFinished4WebService);
        objvPrjTabWS.main();
        //theTimer = setInterval(function(){IsFinished4WebService()}, 1000);
    };

    /// <summary>
    /// 调用WebService是否完成函数
    /// (AutoGCLib.AutoGC6_Controller:Gen_4WS4Controller_JavaScript_IsFinished4WebService)
    /// </summary>
    /// <returns>获取的调用WebService是否完成函数返回的数据</returns>
    function IsFinished4WebService() {
        var strInfo = "";
        if (ResponseData.IsFinished === true) {
            //clearInterval(theTimer);
            var objvPrjTabEN;
            var arrvPrjTabObjLst;
            var bolResult;
            var intResult;
            var strResult = ResponseData.data;
            switch (ResponseData.what) {
                case 1: //"GetObjByTabId":
                    if (ResponseData.errorId > 0) {
                        strInfo = String.format("获取对象不成功!调用GetObjByTabId函数出错。{0}", ResponseData.faultString);
                        myShowErrorMsg(strInfo);
                    }
                    else {
                        objvPrjTabEN = objvPrjTabBL.GetObjByJSONStr(strResult);
                        //objvPrjTabEN = JSON.parse(strResult);
                        ResponseData.returnObject = objvPrjTabEN;
                        objTableObjWS4ControllerDelegate.GetRecordJSONObjByKeyFinished(ResponseData, ClassName);
                        objTableObjWS4ControllerDelegate.GetRecordJSONObjByKeyCorrectFinished(objvPrjTabEN, ClassName);
                        return;
                    }
                    break;
                case 2: //"GetJSONObjLst":
                    if (ResponseData.errorId > 0) {
                        strInfo = String.format("获取对象列表不成功!调用GetJSONObjLst函数出错。{0}", ResponseData.faultString);
                        myShowErrorMsg(strInfo);
                    }
                    else {
                        arrvPrjTabObjLst = new Array();
                        arrvPrjTabObjLst = objvPrjTabBL.GetObjLstByJSONStr(strResult);
                        //arrvPrjTabObjLst = JSON.parse(strResult);
                        ResponseData.returnObjectList = arrvPrjTabObjLst;
                        objTableObjWS4ControllerDelegate.GetRecordJSONObjLstFinished(ResponseData, ClassName);
                        objTableObjWS4ControllerDelegate.GetRecordJSONObjLstCorrectFinished(arrvPrjTabObjLst, ClassName);
                        return;
                    }
                    break;
                case 3: //"AddNewRecord":
                    if (ResponseData.errorId > 0) {

                        strInfo = String.format("添加不成功，调用AddNewRecord函数出错。{0}", ResponseData.faultString);
                        myShowErrorMsg(strInfo);
                    }
                    else {
                        bolResult = myBool(strResult);
                        ResponseData.returnBool = bolResult;
                        objTableObjWS4ControllerDelegate.AddNewRecordByJSONFinished(ResponseData, "jsvPrjTabWS4Controller");
                        objTableObjWS4ControllerDelegate.AddNewRecordByJSONCorrectFinished(bolResult, "jsvPrjTabWS4Controller");
                        return;
                    }
                    break;
                case 4: //"UpdateRecord":
                    if (ResponseData.errorId > 0) {
                        strInfo = String.format("修改不成功!调用UpdateRecord函数出错。{0}", ResponseData.faultString);
                        myShowErrorMsg(strInfo);
                    }
                    else {
                        bolResult = myBool(strResult);
                        ResponseData.returnBool = bolResult;
                        objTableObjWS4ControllerDelegate.UpdateRecordByJSONFinished(ResponseData, ClassName);
                        objTableObjWS4ControllerDelegate.UpdateRecordByJSONCorrectFinished(bolResult, ClassName);
                        return;
                    }
                    break;
                case 5: //"DeleteRecord":
                    if (ResponseData.errorId > 0) {
                        strInfo = String.format("删除不成功!调用DeleteRecord函数出错。{0}", ResponseData.faultString);
                        myShowErrorMsg(strInfo);
                    }
                    else {
                        bolResult = myBool(strResult);
                        ResponseData.returnBool = bolResult;
                        objTableObjWS4ControllerDelegate.DeleteRecordFinished(ResponseData, ClassName);
                        objTableObjWS4ControllerDelegate.DeleteRecordCorrectFinished(bolResult, ClassName);
                        return;
                    }
                    break;
                case 6: //"GetFirstvPrjTab":
                    if (ResponseData.errorId > 0) {
                        strInfo = String.format("获取第一条记录不成功!调用GetFirstvPrjTab函数出错。{0}", ResponseData.faultString);
                        myShowErrorMsg(strInfo);
                    }
                    else {
                        objvPrjTabEN = objvPrjTabBL.GetObjByJSONStr(strResult);
                        //objvPrjTabEN = JSON.parse(strResult);
                        ResponseData.returnObject = objvPrjTabEN;
                        //通过WebService执行GetFirstRecordObj，返回的事件函数，可能需要处理执行错误。
                        objTableObjWS4ControllerDelegate.GetFirstRecordJSONObjFinished(ResponseData, ClassName);
                        //通过WebService执行GetFirstRecordObj，返回的事件函数，这是正确返回，不需要处理执行错误。
                        objTableObjWS4ControllerDelegate.GetFirstRecordJSONObjCorrectFinished(objvPrjTabEN, ClassName);
                        return;
                    }
                    break;
                case 7: //"IsExistRecord":
                    if (ResponseData.errorId > 0) {
                        strInfo = String.format("调用IsExistRecord函数出错。{0}", ResponseData.faultString);
                        myShowErrorMsg(strInfo);
                    }
                    else {
                        bolResult = myBool(strResult);
                        ResponseData.returnBool = bolResult;
                        objTableObjWS4ControllerDelegate.IsExistRecordFinished(ResponseData, ClassName);
                        objTableObjWS4ControllerDelegate.IsExistRecordCorrectFinished(bolResult, ClassName);
                        return;
                    }
                    break;
                case 8: //"GetMaxStrId":
                    if (ResponseData.errorId > 0) {
                        strInfo = String.format("调用GetMaxStrId函数出错。{0}", ResponseData.faultString);
                        myShowErrorMsg(strInfo);
                    }
                    else {
                        ResponseData.returnString = strResult;
                        objTableObjWS4ControllerDelegate.GetMaxStrIdFinished(ResponseData, ClassName);
                        objTableObjWS4ControllerDelegate.GetMaxStrIdCorrectFinished(strResult, ClassName);
                        return;
                    }
                    break;
                case 9: //"GetMaxStrIdByPrefix":
                    if (ResponseData.errorId > 0) {
                        strInfo = String.format("调用GetMaxStrIdByPrefix函数出错。{0}", ResponseData.faultString);
                        myShowErrorMsg(strInfo);
                    }
                    else {
                        ResponseData.returnString = strResult;
                        objTableObjWS4ControllerDelegate.GetMaxStrIdByPrefixFinished(ResponseData, ClassName);
                        objTableObjWS4ControllerDelegate.GetMaxStrIdByPrefixCorrectFinished(strResult, ClassName);
                        return;
                    }
                    break;
                case 10: //"GetTopJSONObjLst":
                    if (ResponseData.errorId > 0) {
                        strInfo = String.format("获取顶部对象列表不成功!调用GetJSONObjLst函数出错。{0}", ResponseData.faultString);
                        myShowErrorMsg(strInfo);
                    }
                    else {
                        arrvPrjTabObjLst = new Array();
                        arrvPrjTabObjLst = objvPrjTabBL.GetObjLstByJSONStr(strResult);
                        //arrvPrjTabObjLst = JSON.parse(strResult);
                        ResponseData.returnObjectList = arrvPrjTabObjLst;
                        objTableObjWS4ControllerDelegate.GetTopRecordJSONObjLstFinished(ResponseData, ClassName);
                        objTableObjWS4ControllerDelegate.GetTopRecordJSONObjLstCorrectFinished(arrvPrjTabObjLst, ClassName);
                        return;
                    }
                    break;
                case 11: //"GetJSONObjLstByPager":
                    if (ResponseData.errorId > 0) {
                        strInfo = String.format("获取分页对象列表不成功!调用GetJSONObjLstByPager函数出错。{0}", ResponseData.faultString);
                        myShowErrorMsg(strInfo);
                    }
                    else {
                        arrvPrjTabObjLst = new Array();
                        arrvPrjTabObjLst = objvPrjTabBL.GetObjLstByJSONStr(strResult);
                        //arrvPrjTabObjLst = JSON.parse(strResult);
                        ResponseData.returnObjectList = arrvPrjTabObjLst;
                        objTableObjWS4ControllerDelegate.GetRecordJSONObjLstByPagerFinished(ResponseData, ClassName);
                        objTableObjWS4ControllerDelegate.GetRecordJSONObjLstByPagerCorrectFinished(arrvPrjTabObjLst, ClassName);
                        return;
                    }
                    break;
                case 12: //"funGetRecCountByCond":
                    if (ResponseData.errorId > 0) {
                        strInfo = String.format("调用funGetRecCountByCond函数出错。{0}", ResponseData.faultString);
                        myShowErrorMsg(strInfo);
                    }
                    else {
                        intResult = parseInt(strResult);
                        ResponseData.returnBool = intResult;
                        objTableObjWS4ControllerDelegate.funGetRecCountByCondFinished(ResponseData, ClassName);
                        objTableObjWS4ControllerDelegate.funGetRecCountByCondCorrectFinished(intResult, ClassName);
                        return;
                    }
                    break;
                default:
                    break;
            }
            myAlert(strResult);
        }
    }
};