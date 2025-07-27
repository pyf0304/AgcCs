
/*-- -- -- -- -- -- -- -- -- -- --
类名:jsvFieldTab_Edit
表名:vFieldTab
生成代码版本:2017.07.08.1
生成日期:2017/07/09 15:45:39
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
/// vFieldTab(vFieldTab)
/// (AutoGCLib.AutoGC6_Controller:A_GenController_JavaScript)
/// </summary>
/**
* Created by  on 2017年07月09日.
* 注意:该类必须与调用界面处于同一个包，否则调用不成功!
*/
var VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中
include(VirtualRootPath + "/js/PubFun/tzDictionary.js");
include(VirtualRootPath + "/js/PubFun/tzResponseData.js");
include(VirtualRootPath + "/js/PubFun/jsPubFun.js");
include(VirtualRootPath + "/js/PubFun/jsPubVar.js");
include(VirtualRootPath + "/js/PubFun/TzCtrlCls.js");

include(VirtualRootPath + "/js/Table_Field/jsvFieldTabEN.js");
include(VirtualRootPath + "/js/Table_Field/jsvFieldTabBL.js");
include(VirtualRootPath + "/js/Table_Field/jsvFieldTabWS4Controller.js");

var objvFieldTabEN;
var objvFieldTab_EditDelegate;
var vcvFieldTab_Edit = function () {

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
        objvFieldTabEN = new clsvFieldTabEN();
        this.init = function () {
        }
        this.main = function () {
            var objvFieldTabWS4Controller = new clsvFieldTabWS4Controller();
            objvFieldTabWS4Controller.init();
            objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();
            objTableObjWS4ControllerDelegate.IsExistRecordFinished = function (objResponseData, strClassName) {
                vFieldTab_IsExistRecordFinished(objResponseData, strClassName);
            }
            objTableObjWS4ControllerDelegate.IsExistRecordCorrectFinished = function (returnBool, strClassName) {
                vFieldTab_IsExistRecordCorrectFinished(returnBool, strClassName);
            }
            var strWhereCond = "FldId ='12'";
            objvFieldTabWS4Controller.IsExistRecord(strWhereCond);
        }
        //通过WebService执行IsExistRecord，返回的事件函数，可能需要处理执行错误。
        function vFieldTab_IsExistRecordFinished(objResponseData, strClassName) {
        }
        //通过WebService执行IsExistRecord，返回的事件函数，这是正确返回，不需要处理执行错误。
        function vFieldTab_IsExistRecordCorrectFinished(returnBool, strClassName) {
            switch (strClassName) {
                case "clsvFieldTabWS4Controller":
                    if (returnBool === false) {
                        var strInfo = "根据条件：‘FldId='12'’ 不存在!"
                        //显示信息框
                        myAlert(strInfo);
                    }
                    else {
                        var strInfo = "根据条件：‘FldId='12'’ 存在!"
                        //显示信息框
                        myAlert(strInfo);
                    }
                    break;
                case "clsvFieldTabWS4Controller2":
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
        var iobjGetFirstvFieldTabObj = new iclsGetFirstvFieldTabObj();
        iobjGetFirstvFieldTabObj.main();
    }
    var iclsGetFirstvFieldTabObj = function () {
        objvFieldTabEN = new clsvFieldTabEN();
        this.init = function () {
        }
        this.main = function () {
            var objvFieldTabWS4Controller = new clsvFieldTabWS4Controller();
            objvFieldTabWS4Controller.init();
            objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();
            objTableObjWS4ControllerDelegate.GetFirstRecordObjFinished = function (objResponseData, strClassName) {
                vFieldTab_GetFirstRecordObjFinished(objResponseData, strClassName);
            }
            objTableObjWS4ControllerDelegate.GetFirstRecordObjCorrectFinished = function (returnObject, strClassName) {
                vFieldTab_GetFirstRecordObjCorrectFinished(returnObject, strClassName);
            }
            var strWhereCond = " 1=1 ";
            objvFieldTabWS4Controller.GetFirstvFieldTab(strWhereCond);
        }
        //通过WebService执行GetFirstRecordObj，返回的事件函数，可能需要处理执行错误。
        function vFieldTab_GetFirstRecordObjFinished(objResponseData, strClassName) {
        }
        //通过WebService执行GetFirstRecordObj，返回的事件函数，这是正确返回，不需要处理执行错误。
        function vFieldTab_GetFirstRecordObjCorrectFinished(returnObject, strClassName) {
            objvFieldTabEN = returnObject;
            var strInfo = String.format("根据条件：‘1=1’ 获取第一个记录对象：{0}", objvFieldTabEN.FldId)
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
        var iobjAddRec = new iclsGetvFieldTabObjByFldID();
        iobjAddRec.main();
    }
    var iclsGetvFieldTabObjByFldID = function () {
        objvFieldTabEN = new clsvFieldTabEN();
        this.init = function () {
        }
        this.main = function () {
            var objvFieldTabWS4Controller = new clsvFieldTabWS4Controller();
            objvFieldTabWS4Controller.init();
            objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();
            objTableObjWS4ControllerDelegate.GetRecordObjByKeyFinished = function (objResponseData, strClassName) {
                vFieldTab_GetRecordObjByKeyFinished(objResponseData, strClassName);
            }
            objTableObjWS4ControllerDelegate.GetRecordObjByKeyCorrectFinished = function (returnObject, strClassName) {
                vFieldTab_GetRecordObjByKeyCorrectFinished(returnObject, strClassName);
            }
            var mstrFldID = "11111111";
            objvFieldTabWS4Controller.GetvFieldTabObjByFldID(mstrFldID);
        }
        //通过WebService执行GetRecordObjByKey，返回的事件函数，可能需要处理执行错误。
        function vFieldTab_GetRecordObjByKeyFinished(objResponseData, strClassName) {
        }
        //通过WebService执行GetRecordObjByKey，返回的事件函数，这是正确返回，不需要处理执行错误。
        function vFieldTab_GetRecordObjByKeyCorrectFinished(returnObject, strClassName) {
            objvFieldTabEN = returnObject;
            var strInfo = String.format("根据关键字’01‘ 获取对象：{0}", objvFieldTabEN.FldId);
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
    this.btnGetJSONObjLst_Click = function () {
        var iobjGetJSONObjLst = new iclsGetJSONObjLst();
        iobjGetJSONObjLst.main();
    }
    var iclsGetJSONObjLst = function () {
        objvFieldTabEN = new clsvFieldTabEN();
        this.init = function () {
        }
        this.main = function () {
            var objvFieldTabWS4Controller = new clsvFieldTabWS4Controller();
            objvFieldTabWS4Controller.init();
            objTableObjWS4ControllerDelegate = new clsTableObjWS4ControllerDelegate();
            objTableObjWS4ControllerDelegate.GetRecordJSONObjLstFinished = function (objResponseData, strClassName) {
                vFieldTab_GetRecordJSONObjLstFinished(objResponseData, strClassName);
            }
            objTableObjWS4ControllerDelegate.GetRecordJSONObjLstCorrectFinished = function (returnObjectList, strClassName) {
                vFieldTab_GetRecordJSONObjLstCorrectFinished(returnObjectList, strClassName);
            }
            var txtFldName = new TzTextBox("txtFldName");
            var txtCaption = new TzTextBox("txtCaption");
            var strFldName = txtFldName.getText();
            var strCaption = txtCaption.getText();

            var strWhereCond = "";
            if (strFldName !== "") {
                strWhereCond += String.format("FldName like '{0}%' ", strFldName);
            }
            if (strCaption !== "") {
                if (strWhereCond !== "")
                {
                    strWhereCond += " or "
                }
                strWhereCond += String.format(" Caption like '{0}%' ", strCaption);
            }
            if (strWhereCond === "") return;
            strWhereCond += "Order By FldName, Caption, DataTypeName, FldLength"
            strWhereCond += "[Exclude]or [/Exclude]";
            objvFieldTabWS4Controller.GetJSONObjLst(strWhereCond);
        }
        //通过WebService执行GetRecordObjLst，返回的事件函数，可能需要处理执行错误。
        function vFieldTab_GetRecordJSONObjLstFinished(objResponseData, strClassName) {
        }
        //通过WebService执行GetRecordObjLst，返回的事件函数，这是正确返回，不需要处理执行错误。
        function vFieldTab_GetRecordJSONObjLstCorrectFinished(returnObjectList, strClassName) {
            var arrvFieldTabObjLst = returnObjectList;
            //pub_arrvFieldTabObjLst = returnObjectList;
            objvFieldTab_EditDelegate.GetRecordJSONObjLstCorrectFinished(returnObjectList, strClassName);

            //var strInfo = String.format("共获取对象列表数：{0}", arrvFieldTabObjLst.length)
            ////显示信息框
            //myAlert(strInfo);
        };
    }
}