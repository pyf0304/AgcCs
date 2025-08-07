
/*-- -- -- -- -- -- -- -- -- -- --
类名:jsvPrjTab_Edit
表名:vPrjTab
生成代码版本:2017.07.08.1
生成日期:2017/07/10 16:45:56
生成者:
生成服务器IP:1011.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:App界面层
编程语言:JavaScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.06.19.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/

/// <summary>
/// v工程表(vPrjTab)
/// (AutoGCLib.AutoGC6_Controller:A_GenController_JavaScript)
/// </summary>
/**
* Created by  on 2017年07月10日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
var VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中
include(VirtualRootPath + "/js/PubFun/tzDictionary.js");
include(VirtualRootPath + "/js/PubFun/tzResponseData.js");
include(VirtualRootPath + "/js/PubFun/jsPubFun.js");
include(VirtualRootPath + "/js/PubFun/jsPubVar.js");
include(VirtualRootPath + "/js/Table_Field/jsvPrjTabEN.js");
include(VirtualRootPath + "/js/Table_Field/jsvPrjTabBL.js");
include(VirtualRootPath + "/js/Table_Field/jsvPrjTabWS4Controller.js");
var objvPrjTabEN;
var objvPrjTab_EditDelegate = null;
var vcvPrjTab_Edit = function () {
    this.Condition = "";
    /// <summary>
    /// 检查相应关键字的记录是否存在
    /// (AutoGCLib.AutoGC6_Controller:Gen_Controller_JavaScript_btnIsExistRecord_Click)
    /// </summary>
    /// <param name = "sender">发送者</param>
    /// <returns>返回是否存在</returns>
    this.btnIsExistRecord_Click = function () {
        var iobjIsExistRecord = new iclsIsExistRecord();
        iobjIsExistRecord.main();
    }
    var iclsIsExistRecord = function () {
        objvPrjTabEN = new clsvPrjTabEN();
        this.init = function () {
        }
        this.main = function () {
            var objvPrjTabWS4Controller = new clsvPrjTabWS4Controller();
            objvPrjTabWS4Controller.init();
            objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();
            objTableObjWS4ControllerDelegate.IsExistRecordFinished = function (objResponseData, strClassName) {
                vPrjTab_IsExistRecordFinished(objResponseData, strClassName);
            }
            objTableObjWS4ControllerDelegate.IsExistRecordCorrectFinished = function (returnBool, strClassName) {
                vPrjTab_IsExistRecordCorrectFinished(returnBool, strClassName);
            }
            var strWhereCond = "TabId ='12'";
            objvPrjTabWS4Controller.IsExistRecord(strWhereCond);
        }
        //通过WebService执行IsExistRecord，返回的事件函数，可能需要处理执行错误。
        function vPrjTab_IsExistRecordFinished(objResponseData, strClassName) {
        }
        //通过WebService执行IsExistRecord，返回的事件函数，这是正确返回，不需要处理执行错误。
        function vPrjTab_IsExistRecordCorrectFinished(returnBool, strClassName) {
            var strInfo;
            switch (strClassName) {
                case "clsvPrjTabWS4Controller":
                    if (returnBool === false) {
                        strInfo = "根据条件：‘TabId='12'’ 不存在!"
                        //显示信息框
                        myAlert(strInfo);
                    }
                    else {
                        strInfo = "根据条件：‘TabId='12'’ 存在!"
                        //显示信息框
                        myAlert(strInfo);
                    }
                    break;
                case "clsvPrjTabWS4Controller2":
                    break;
                default:
                    break;
            }
        }
    }

    /// <summary>
    /// 根据条件获取相应的第一条记录的对象
    /// (AutoGCLib.AutoGC6_Controller:Gen_Controller_JavaScript_btnGetFirstRecord_Click)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    this.btnGetFirstRecord_Click = function () {
        var iobjGetFirstvPrjTabObj = new iclsGetFirstvPrjTabObj();
        iobjGetFirstvPrjTabObj.main();
    }
    var iclsGetFirstvPrjTabObj = function () {
        objvPrjTabEN = new clsvPrjTabEN();
        this.init = function () {
        }
        this.main = function () {
            var objvPrjTabWS4Controller = new clsvPrjTabWS4Controller();
            objvPrjTabWS4Controller.init();
            objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();
            objTableObjWS4ControllerDelegate.GetFirstRecordObjFinished = function (objResponseData, strClassName) {
                vPrjTab_GetFirstRecordObjFinished(objResponseData, strClassName);
            }
            objTableObjWS4ControllerDelegate.GetFirstRecordObjCorrectFinished = function (returnObject, strClassName) {
                vPrjTab_GetFirstRecordObjCorrectFinished(returnObject, strClassName);
            }
            var strWhereCond = " 1=1 ";
            objvPrjTabWS4Controller.GetFirstvPrjTab(strWhereCond);
        }
        //通过WebService执行GetFirstRecordObj，返回的事件函数，可能需要处理执行错误。
        function vPrjTab_GetFirstRecordObjFinished(objResponseData, strClassName) {
        }
        //通过WebService执行GetFirstRecordObj，返回的事件函数，这是正确返回，不需要处理执行错误。
        function vPrjTab_GetFirstRecordObjCorrectFinished(returnObject, strClassName) {
            objvPrjTabEN = returnObject;
            var strInfo = String.format("根据条件：‘1=1’ 获取第一个记录对象：{0}", objvPrjTabEN.TabId)
            //显示信息框
            myAlert(strInfo);
        };
    }

    /// <summary>
    /// 根据关键字获取相应的记录的对象
    /// (AutoGCLib.AutoGC6_Controller:Gen_Controller_JavaScript_btnGetRecObjByKey_Click)
    /// </summary>
    /// <param name = "sender">参数列表</param>
    /// <returns></returns>
    this.btnGetRecObjByKey_Click = function () {
        var iobjAddRec = new iclsGetvPrjTabObjByTabId();
        iobjAddRec.main();
    }
    var iclsGetvPrjTabObjByTabId = function () {
        objvPrjTabEN = new clsvPrjTabEN();
        this.init = function () {
        }
        this.main = function () {
            var objvPrjTabWS4Controller = new clsvPrjTabWS4Controller();
            objvPrjTabWS4Controller.init();
            objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();
            objTableObjWS4ControllerDelegate.GetRecordObjByKeyFinished = function (objResponseData, strClassName) {
                vPrjTab_GetRecordObjByKeyFinished(objResponseData, strClassName);
            }
            objTableObjWS4ControllerDelegate.GetRecordObjByKeyCorrectFinished = function (returnObject, strClassName) {
                vPrjTab_GetRecordObjByKeyCorrectFinished(returnObject, strClassName);
            }
            var mstrTabId = "11111111";
            objvPrjTabWS4Controller.GetvPrjTabObjByTabId(mstrTabId);
        }
        //通过WebService执行GetRecordObjByKey，返回的事件函数，可能需要处理执行错误。
        function vPrjTab_GetRecordObjByKeyFinished(objResponseData, strClassName) {
        }
        //通过WebService执行GetRecordObjByKey，返回的事件函数，这是正确返回，不需要处理执行错误。
        function vPrjTab_GetRecordObjByKeyCorrectFinished(returnObject, strClassName) {
            objvPrjTabEN = returnObject;
            var strInfo = String.format("根据关键字’01‘ 获取对象：{0}", objvPrjTabEN.TabId);
            //显示信息框
            myAlert(strInfo);
        };
    }

    /// <summary>
    /// 根据条件获取相应的记录对象的列表
    /// (AutoGCLib.AutoGC6_Controller:Gen_Controller_JavaScript_btnGetRecObjLst_Click)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    this.btnGetvPrjTabObjLst_ClickBak = function () {
        var iobjGetvPrjTabObjLst = new iclsGetvPrjTabObjLst();
        iobjGetvPrjTabObjLst.main();
    }
    var iclsGetvPrjTabObjLst = function () {
        objvPrjTabEN = new clsvPrjTabEN();
        this.init = function () {
        }
        this.main = function () {
            var objvPrjTabWS4Controller = new clsvPrjTabWS4Controller();
            objvPrjTabWS4Controller.init();
            objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();
            objTableObjWS4ControllerDelegate.GetRecordJSONObjLstFinished = function (objResponseData, strClassName) {
                vPrjTab_GetRecordJSONObjLstFinished(objResponseData, strClassName);
            }
            objTableObjWS4ControllerDelegate.GetRecordJSONObjLstCorrectFinished = function (returnObjectList, strClassName) {
                vPrjTab_GetRecordJSONObjLstCorrectFinished(returnObjectList, strClassName);
            }
            var txtTabName = new TzTextBox("txtTabName");
            var txtTabCnName = new TzTextBox("txtTabCnName");
            var strTabName = txtTabName.getText();
            var strTabCnName = txtTabCnName.getText();

            var strWhereCond = "";
            if (strTabName !== "") {
                strWhereCond += String.format("TabName like '{0}%' ", strTabName);
            }
            if (strTabCnName !== "") {
                if (strWhereCond !== "") {
                    strWhereCond += " or "
                }
                strWhereCond += String.format(" TabCnName like '{0}%' ", strTabCnName);
            }
            if (strWhereCond === "") return;
            this.Condition = strWhereCond;
            strWhereCond += "Order By TabName, TabCnName, FldNum Desc"
       
            strWhereCond += "[Exclude]or [/Exclude]";
       
            objvPrjTabWS4Controller.GetvPrjTabObjLst(strWhereCond);
        }
        //通过WebService执行GetRecordObjLst，返回的事件函数，可能需要处理执行错误。
        function vPrjTab_GetRecordJSONObjLstFinished(objResponseData, strClassName) {
        }
        //通过WebService执行GetRecordObjLst，返回的事件函数，这是正确返回，不需要处理执行错误。
        function vPrjTab_GetRecordJSONObjLstCorrectFinished(returnObjectList, strClassName) {
            var arrvPrjTabObjLst = returnObjectList;
            objvPrjTab_EditDelegate.GetRecordJSONObjLstCorrectFinished(returnObjectList, strClassName);

            //var strInfo = String.format("共获取对象列表数：{0}", arrvPrjTabObjLst.length)
            ////显示信息框
            //myAlert(strInfo);
        };
    }


    /// <summary>
    /// 根据条件获取相应的记录对象的列表
    /// (AutoGCLib.AutoGC6_Controller:Gen_Controller_JavaScript_btnGetRecObjLst_Click)
    /// </summary>
    /// <param name = "sender">事件发送者</param>
    /// <returns></returns>
    this.btnGetTopJSONObjLst_Click = function () {
        var iobjGetTopJSONObjLst = new iclsGetTopJSONObjLst();
        iobjGetTopJSONObjLst.main();
        this.Condition = iobjGetTopJSONObjLst.Condition;
    }
    var iclsGetTopJSONObjLst = function () {
        this.Condition = "";
        objvPrjTabEN = new clsvPrjTabEN();
        this.init = function () {
        }
        this.main = function () {
            var objvPrjTabWS4Controller = new clsvPrjTabWS4Controller();
            objvPrjTabWS4Controller.init();
            objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();
            objTableObjWS4ControllerDelegate.GetTopRecordObjLstFinished = function (objResponseData, strClassName) {
                vPrjTab_GetTopRecordObjLstFinished(objResponseData, strClassName);
            }
            objTableObjWS4ControllerDelegate.GetTopRecordJSONObjLstCorrectFinished = function (returnObjectList, strClassName) {
                vPrjTab_GetTopRecordJSONObjLstCorrectFinished(returnObjectList, strClassName);
            }
            var txtTabName = new TzTextBox("txtTabName");
            var txtTabCnName = new TzTextBox("txtTabCnName");
            var strTabName = txtTabName.getText();
            var strTabCnName = txtTabCnName.getText();

            var strWhereCond = "";
            if (strTabName !== "" && strTabName.length>=2) {
                strWhereCond += String.format("TabName like '{0}%' ", strTabName);
            }
            if (strTabCnName !== "" && strTabCnName.length >= 1) {
                if (strWhereCond !== "") {
                    strWhereCond += " and "
                }
                strWhereCond += String.format(" TabCnName like '{0}%' ", strTabCnName);
            }
            if (strWhereCond === "") return;
            this.Condition = strWhereCond;
            strWhereCond += "Order By TabName, TabCnName, FldNum Desc"
       
            strWhereCond += "[Exclude]or [/Exclude]";

            objvPrjTabWS4Controller.GetTopJSONObjLst(100, strWhereCond);
        }
        //通过WebService执行GetRecordObjLst，返回的事件函数，可能需要处理执行错误。
        function vPrjTab_GetTopRecordObjLstFinished(objResponseData, strClassName) {
        }
        //通过WebService执行GetRecordObjLst，返回的事件函数，这是正确返回，不需要处理执行错误。
        function vPrjTab_GetTopRecordJSONObjLstCorrectFinished(returnObjectList, strClassName) {
            var arrvPrjTabObjLst = returnObjectList;
            objvPrjTab_EditDelegate.GetTopRecordJSONObjLstCorrectFinished(returnObjectList, strClassName);

            //var strInfo = String.format("共获取对象列表数：{0}", arrvPrjTabObjLst.length)
            ////显示信息框
            //myAlert(strInfo);
        };
    }
}