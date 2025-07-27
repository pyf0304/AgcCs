var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "clscommonfunc4web", "clscboobject"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
    var clsCboObject_js_1 = require("clscboobject");
    //declare function GetObjLstFromParent(): Array<clsFldComparisonObj>;
    /// <summary>
    /// 下拉框对象类
    /// </summary>
    var clsFldComparisonObj = /** @class */ (function () {
        /*
        /// <param name="strFldValue"></param>
        /// <param name="strFldName"></param>
        */
        function clsFldComparisonObj(strFldName, strComparisonOperator, strFldValue) {
            /// <summary>
            /// 字段值
            /// </summary>
            this.FldValue = "";
            /// <summary>
            /// 字段名
            /// </summary>
            this.FldName = "";
            /// <summary>
            /// 比较操作符
            /// </summary>
            this.ComparisonOperator = "";
            this.FldValue = strFldValue;
            this.FldName = strFldName;
            this.ComparisonOperator = strComparisonOperator;
        }
        Object.defineProperty(clsFldComparisonObj, "con_FldName", {
            /// <summary>
            /// 常量:"FldName"
            /// </summary>
            get: function () { return "FldName"; },
            enumerable: true,
            configurable: true
        });
        ; //文本
        Object.defineProperty(clsFldComparisonObj, "con_ComparisonOperator", {
            /// <summary>
            /// 常量:"ComparisonOperator"
            /// </summary>
            get: function () { return "ComparisonOperator"; } //值
            ,
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsFldComparisonObj, "con_FldValue", {
            /// <summary>
            /// 常量:"FldValue"
            /// </summary>
            get: function () { return "FldValue"; } //值
            ,
            enumerable: true,
            configurable: true
        });
        clsFldComparisonObj.GetLocalObjLst = function () {
            var strFldComparisonObjLst = $("#hidFldComparisonObjLst").val();
            if (strFldComparisonObjLst == null || strFldComparisonObjLst == "") {
                return new Array();
            }
            var arrFldComparisonObj = JSON.parse(strFldComparisonObjLst);
            console.log("当前记录数:" + arrFldComparisonObj.length + ".(In clsFldComparisonObj.GetLocalObjLst)");
            return arrFldComparisonObj;
        };
        ;
        clsFldComparisonObj.SetLocalObjLst = function () {
            var strFldComparisonObjLst = JSON.stringify(clsFldComparisonObj.arrFldComparisonObj);
            $("#hidFldComparisonObjLst").val(strFldComparisonObjLst);
            console.log("当前记录数:" + clsFldComparisonObj.arrFldComparisonObj.length + ".(In clsFldComparisonObj.SetLocalObjLst)");
        };
        ;
        clsFldComparisonObj.BindTab = function () {
            //if (clsFldComparisonObj.arrFldComparisonObj.length == 0) {
            clsFldComparisonObj.arrFldComparisonObj = clsFldComparisonObj.GetLocalObjLst();
            //}
            clsFldComparisonObj.BindTab_FldComparisonObj("divList4FldComparisonObj", clsFldComparisonObj.arrFldComparisonObj);
        };
        /// <summary>
        /// 显示FldComparisonObj对象的所有属性值
        /// (AutoGCLib.WA_ViewUTScriptCS_TS4TypeScript:Gen_WApi_Ts_UT_BindTab)
        /// </summary>
        /// <param name = "divContainer">显示容器</param>
        /// <param name = "arrFldComparisonObjObjLst">需要绑定的对象列表</param>
        /// <returns></returns>
        clsFldComparisonObj.BindTab_FldComparisonObj = function (divContainer, arrFldComparisonObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(divContainer + "不存在！");
                return;
            }
            var sstrFldName = new Array();
            var sstrColHeader = new Array();
            sstrFldName.push(clsFldComparisonObj.con_FldName);
            sstrColHeader.push("字段名");
            sstrFldName.push(clsFldComparisonObj.con_ComparisonOperator);
            sstrColHeader.push("操作符");
            sstrFldName.push(clsFldComparisonObj.con_FldValue);
            sstrColHeader.push("字段值");
            var arrDataColumn = [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "",
                    ColumnType: "CheckBox",
                    OrderNum: 1,
                    FuncName: function () { }
                },
                {
                    FldName: clsFldComparisonObj.con_FldName,
                    ColHeader: "字段名",
                    Text: "",
                    ColumnType: "Label",
                    OrderNum: 1,
                    FuncName: function () { }
                },
                {
                    FldName: clsFldComparisonObj.con_ComparisonOperator,
                    ColHeader: "操作符",
                    Text: "",
                    ColumnType: "Label",
                    OrderNum: 1,
                    FuncName: function () { }
                },
                {
                    FldName: clsFldComparisonObj.con_FldValue,
                    ColHeader: "操作符",
                    Text: "",
                    ColumnType: "Label",
                    OrderNum: 1,
                    FuncName: function () { }
                },
                {
                    FldName: "",
                    ColHeader: "修改",
                    Text: "修改",
                    ColumnType: "Button",
                    OrderNum: 1,
                    FuncName: function (strKeyId, strText) {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", "btnUpdateRecordInTab_Click('" + strKeyId + "');");
                        return btn1;
                    }
                },
                {
                    FldName: "",
                    ColHeader: "删除",
                    Text: "删除",
                    ColumnType: "Button",
                    OrderNum: 1,
                    FuncName: function (strKeyId, strText) {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", "btnDelRecordInTab_Click('" + strKeyId + "');");
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTabV2(o, arrFldComparisonObjLst, arrDataColumn, clsFldComparisonObj.con_FldName);
        };
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        clsFldComparisonObj.BindDdl_FldName = function (strDdlName, arrFldNameLst) {
            var objDdl = document.getElementById(strDdlName);
            if (objDdl == null) {
                var strMsg = "下拉框：" + strDdlName + "不存在！";
                alert(strMsg);
                throw (strMsg);
            }
            //为数据源于表的下拉框设置内容
            console.log("开始：BindDdl_FldName");
            var arrCboObject = arrFldNameLst.map(function (x) { return new clsCboObject_js_1.clsCboObject(x, x); });
            clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrCboObject, clsCboObject_js_1.clsCboObject.con_Text, clsCboObject_js_1.clsCboObject.con_Value, "字段名");
        };
        clsFldComparisonObj.BindDdl_ComparisonOperator = function (strDdlName) {
            var objDdl = document.getElementById(strDdlName);
            if (objDdl == null) {
                var strMsg = "下拉框:" + strDdlName + "不存在！";
                alert(strMsg);
                throw (strMsg);
            }
            //为数据源于表的下拉框设置内容
            console.log("开始：BindDdl_FldName");
            var arrComparisonOperatorLst = new Array("=", "!=", "like", ">=", ">", "<=", "<");
            var arrCboObject = arrComparisonOperatorLst.map(function (x) { return new clsCboObject_js_1.clsCboObject(x, x); });
            clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrCboObject, clsCboObject_js_1.clsCboObject.con_Text, clsCboObject_js_1.clsCboObject.con_Value, "字段名");
        };
        clsFldComparisonObj.AddNewRecordSave = function () {
            //this.DivName = "divAddNewRecordSave";
            var objFldComparisonObj = new clsFldComparisonObj(clsFldComparisonObj.FldName4Ctl, clsFldComparisonObj.ComparisonOperator4Ctl, clsFldComparisonObj.FldValue4Ctl);
            try {
                var responseText = clsFldComparisonObj.IsExist(objFldComparisonObj.FldName);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = "添加记录时，字段名：" + objFldComparisonObj.FldName + "已经存在!";
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                clsFldComparisonObj.arrFldComparisonObj.push(objFldComparisonObj);
                clsFldComparisonObj.SetLocalObjLst();
                clsFldComparisonObj.BindTab();
                return true; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "添加记录不成功," + e + ".";
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        };
        /// <summary>
        /// 根据关键字判断是否存在记录, 从本地缓存中判断.
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
        /// </summary>
        /// <param name = "strFldName">所给的关键字</param>
        /// <returns>对象</returns>
        clsFldComparisonObj.IsExist = function (strFldName) {
            try {
                var arrFldComparisonObj_Sel = clsFldComparisonObj.arrFldComparisonObj.filter(function (x) { return x.FldName == strFldName; });
                var objFldComparisonObj;
                if (arrFldComparisonObj_Sel.length > 0) {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (e) {
                var strMsg = "根据关键字:[" + strFldName + "]判断是否存在不成功!";
                alert(strMsg);
            }
            return false;
        };
        ;
        /*
    在数据表里删除记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
    */
        clsFldComparisonObj.btnDelRecordInTab_Click = function (strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var index = clsFldComparisonObj.arrFldComparisonObj.findIndex(function (x) { return x.FldName == strKeyId; });
                if (index > -1) {
                    clsFldComparisonObj.arrFldComparisonObj.splice(index, 1);
                    clsFldComparisonObj.SetLocalObjLst();
                }
                var responseText2 = this.BindTab();
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "删除记录不成功. " + e + ".";
                alert(strMsg);
            }
        };
        /* 在数据表里修改记录
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
    */
        clsFldComparisonObj.btnUpdateRecordInTab_Click = function (strKeyId) {
            //this.OpType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            clsFldComparisonObj.UpdateRecord(strKeyId);
        };
        /* 根据关键字获取相应的记录的对象
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
     <param name = "sender">参数列表</param>
    */
        clsFldComparisonObj.UpdateRecord = function (strFldName) {
            clsFldComparisonObj.btnOKUpd = "确认修改";
            clsFldComparisonObj.btnCancel = "取消修改";
            clsFldComparisonObj.KeyId = strFldName;
            try {
                var objFldComparisonObj = clsFldComparisonObj.GetObjByFldName_Cache(strFldName);
                clsFldComparisonObj.GetDataFromFldComparisonObjClass(objFldComparisonObj);
                console.log("完成UpdateRecord!");
            }
            catch (e) {
                console.log(e);
                var strMsg = "根据关键字获取相应的记录的对象不成功," + e + ".";
                alert(strMsg);
            }
        };
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
    
    */
        clsFldComparisonObj.btnOKUpd_Click = function () {
            return __awaiter(this, void 0, void 0, function () {
                var returnBool, strCommandText, strMsg, strMsg;
                return __generator(this, function (_a) {
                    strCommandText = clsFldComparisonObj.btnOKUpd;
                    try {
                        switch (strCommandText) {
                            case "添加":
                                //const responseText1 = clsFldComparisonObj.AddNewRecord();
                                break;
                            case "确认添加":
                                //这是一个单表的插入的代码,由于逻辑层太简单,
                                //就把逻辑层合并到控制层,
                                //FldComparisonObj.clsFldComparisonObj.AddNewRecordSave();
                                returnBool = clsFldComparisonObj.AddNewRecordSave();
                                break;
                            case "确认修改":
                                //这是一个单表的修改的代码,由于逻辑层太简单,
                                returnBool = clsFldComparisonObj.UpdateRecordSave();
                                if (returnBool == true) {
                                    HideDialog_FC();
                                    //clsFldComparisonObj.BindGv_vUsers();
                                }
                                break;
                            default:
                                strMsg = "strCommandText:" + strCommandText + "在switch中没有处理(In btnOKUpd_Click())";
                                alert(strMsg);
                                break;
                        }
                    }
                    catch (e) {
                        strMsg = "(errid: WiTsCs0033)在保存记录时(" + strCommandText + ")时出错!请联系管理员!" + e;
                        alert(strMsg);
                    }
                    return [2 /*return*/];
                });
            });
        };
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存中获取.
        /// </summary>
        /// <param name = "strFldName">所给的关键字</param>
        /// <returns>对象</returns>
        clsFldComparisonObj.GetObjByFldName_Cache = function (strFldName) {
            var arrFldComparisonObjObjLst_Cache = clsFldComparisonObj.arrFldComparisonObj;
            var obj = new clsFldComparisonObj("", "", "");
            try {
                var arrFldComparisonObj_Sel = arrFldComparisonObjObjLst_Cache.filter(function (x) { return x.FldName == strFldName; });
                var objFldComparisonObj;
                if (arrFldComparisonObj_Sel.length > 0) {
                    objFldComparisonObj = arrFldComparisonObj_Sel[0];
                    return objFldComparisonObj;
                }
                else {
                    return obj;
                }
            }
            catch (e) {
                var strMsg = "根据关键字:[" + strFldName + "]获取相应的对象不成功!";
                alert(strMsg);
            }
            return obj;
        };
        ;
        /* 函数功能:把类对象的属性内容显示到界面上
     <param name = "pobjFldComparisonObj">表实体类对象</param>
    */
        clsFldComparisonObj.GetDataFromFldComparisonObjClass = function (pobjFldComparisonObj) {
            clsFldComparisonObj.FldName4Ctl = pobjFldComparisonObj.FldName; // 学院
            clsFldComparisonObj.ComparisonOperator4Ctl = pobjFldComparisonObj.ComparisonOperator; // 学院名称
            clsFldComparisonObj.FldValue4Ctl = pobjFldComparisonObj.FldValue; // 排序
        };
        /* 修改记录
            */
        clsFldComparisonObj.UpdateRecordSave = function () {
            //this.DivName = "divUpdateRecordSave";
            var objFldComparisonObj = new clsFldComparisonObj("", "", "");
            objFldComparisonObj.FldName = clsFldComparisonObj.KeyId;
            clsFldComparisonObj.PutDataToFldComparisonObjClass(objFldComparisonObj);
            if (objFldComparisonObj.FldName == "" || objFldComparisonObj.FldName == undefined) {
                throw "关键字不能为空!";
            }
            var objFldComparisonObj_Lib = this.GetObjByFldName_Cache(clsFldComparisonObj.KeyId);
            if (objFldComparisonObj_Lib.FldName == "") {
                var strInfo = "字段名:[" + clsFldComparisonObj.KeyId + "]在缓存中不存在!";
                //显示信息框
                alert(strInfo);
                return false;
            }
            objFldComparisonObj_Lib.ComparisonOperator = objFldComparisonObj.ComparisonOperator;
            objFldComparisonObj_Lib.FldValue = objFldComparisonObj.FldValue;
            clsFldComparisonObj.SetLocalObjLst();
            var strInfo = "修改记录成功!";
            //显示信息框
            alert(strInfo);
            this.BindTab();
            return true;
        };
        /* 函数功能:把界面上的属性数据传到类对象中
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
      <param name = "pobjFldComparisonObj">数据传输的目的类对象</param>
    */
        clsFldComparisonObj.PutDataToFldComparisonObjClass = function (pobjFldComparisonObj) {
            pobjFldComparisonObj.FldName = clsFldComparisonObj.FldName4Ctl; // 用户ID
            pobjFldComparisonObj.FldValue = clsFldComparisonObj.FldValue4Ctl; // 用户名
            pobjFldComparisonObj.ComparisonOperator = clsFldComparisonObj.ComparisonOperator4Ctl; // 用户状态号
        };
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        clsFldComparisonObj.SetKeyReadOnly = function (bolReadonly) {
            $('#ddlFldName').prop['ReadOnly'] = bolReadonly;
        };
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// </summary>	
        clsFldComparisonObj.Clear = function () {
            clsFldComparisonObj.FldName4Ctl = "";
            clsFldComparisonObj.FldValue4Ctl = "";
            clsFldComparisonObj.ComparisonOperator4Ctl = "";
        };
        /* 为插入记录做准备工作
    */
        clsFldComparisonObj.AddNewRecord = function () {
            clsFldComparisonObj.SetKeyReadOnly(false);
            clsFldComparisonObj.btnOKUpd = "确认添加";
            clsFldComparisonObj.btnCancel = "取消添加";
            clsFldComparisonObj.Clear();
            //wucUsersB1.UserId = clsUsersBL.GetMaxStrId_S();
        };
        /* 添加新记录
    */
        clsFldComparisonObj.btnAddNewRecord_Click = function () {
            clsFldComparisonObj.OpType = "Add";
            try {
                console.log("clsFldComparisonObj.arrFldNameLst:(In clsFldComparisonObj)");
                if (clsFldComparisonObj.arrFldNameLst == null) {
                    var hidFldNameLst = document.getElementById("hidFldNameLst");
                    var strFldNameLst = hidFldNameLst.value;
                    clsFldComparisonObj.arrFldNameLst = strFldNameLst.split(",");             
                }
                console.log(clsFldComparisonObj.arrFldNameLst);
                clsFldComparisonObj.BindDdl_ComparisonOperator("ddlComparisonOperator");
                clsFldComparisonObj.BindDdl_FldName("ddlFldName", clsFldComparisonObj.arrFldNameLst);
                var responseText = clsFldComparisonObj.AddNewRecord();
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "添加新记录初始化不成功," + e + ".";
                alert(strMsg);
            }
        };
        Object.defineProperty(clsFldComparisonObj, "FldName4Ctl", {
            /*
            * 用户状态号
           */
            get: function () {
                return $("#ddlFldName").val();
            },
            /*
           * 用户状态号
          */
            set: function (value) {
                if (value == "")
                    return;
                $("#ddlFldName").val(value);
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsFldComparisonObj, "FldValue4Ctl", {
            /*
          * 用户名
         */
            get: function () {
                return $("#txtFldValue").val();
            },
            /*
          * 用户名
         */
            set: function (value) {
                $("#txtFldValue").val(value);
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsFldComparisonObj, "ComparisonOperator4Ctl", {
            /*
            * 用户状态号
           */
            get: function () {
                return $("#ddlComparisonOperator").val();
            },
            /*
        * 用户状态号
        */
            set: function (value) {
                if (value == "")
                    return;
                $("#ddlComparisonOperator").val(value);
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsFldComparisonObj, "btnCancel", {
            /*
        * 设置取消按钮的标题
        */
            set: function (value) {
                $("#btnCancel").html(value);
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsFldComparisonObj, "btnOKUpd", {
            /*
            * 获取按钮的标题
           */
            get: function () {
                return $("#btnOKUpd_FC").html();
            },
            /*
            * 设置确定按钮的标题
           */
            set: function (value) {
                $("#btnOKUpd_FC").html(value);
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsFldComparisonObj, "KeyId", {
            /*
            * 设置关键字的值
           */
            get: function () {
                return $("#hidKeyId_FC").val();
            },
            /*
         * 设置关键字的值
        */
            set: function (value) {
                $("#hidKeyId_FC").val(value);
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(clsFldComparisonObj, "OpType", {
            /*
        * 设置操作类型：Add||Update||Detail
        */
            set: function (value) {
                $("#hidOpType_FC").val(value);
            },
            enumerable: true,
            configurable: true
        });
        clsFldComparisonObj.arrFldComparisonObj = new Array();
        return clsFldComparisonObj;
    }());
    exports.clsFldComparisonObj = clsFldComparisonObj;
});
