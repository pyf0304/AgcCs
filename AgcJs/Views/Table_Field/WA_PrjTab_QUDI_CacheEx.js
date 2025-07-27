
/*-- -- -- -- -- -- -- -- -- -- --
类名:WA_PrjTab_QUDI_CacheEx
表名:PrjTab(00050009)
生成代码版本:2020.04.24.1
生成日期:2020/04/29 17:30:02
生成者:
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:WA_界面后台Ex_JS(WA_ViewScriptCSEx_JS)
编程语言:JavaScript
== == == == == == == == == == == == 
*/
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] }
                instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./WA_PrjTab_QUDI_Cache.js", "../../Js/L0_Entity/Table_Field/clsCacheModeEN.js",
            "../../Js/L3_ForWApi/Table_Field/clsCacheModeWApi.js",
            "clscommonfunc4web", "../../Js/PubFun/clsPubFun.js", "clscommsession"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    var WA_PrjTab_QUDI_Cache_js_1 = require("./WA_PrjTab_QUDI_Cache.js");
    var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
    var clsCommSession_js_1 = require("clscommsession");
    var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
    var clsCacheModeEN_js_1 = require("../../Js/L0_Entity/Table_Field/clsCacheModeEN.js");
    var clsCacheModeWApi_js_1 = require("../../Js/L3_ForWApi/Table_Field/clsCacheModeWApi.js");
    /* WA_PrjTab_QUDI_CacheEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_JS4JavaScript:GeneCode)
   */
    var WA_PrjTab_QUDI_CacheEx = /** @class */ (function (_super) {
        __extends(WA_PrjTab_QUDI_CacheEx, _super);
        function WA_PrjTab_QUDI_CacheEx() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        Object.defineProperty(WA_PrjTab_QUDI_CacheEx.prototype, "PageSize", {
            get: function () { return 10; },
            enumerable: true,
            configurable: true
        });
        WA_PrjTab_QUDI_CacheEx.prototype.GetQueryValue = function () {
            var url = location.search; //获取url中"?"符后的字串
            var theRequest = new Object();
            if (url.indexOf("?") != -1) {
                var str = url.substr(1);
                var strs = str.split("&");
                for (var i = 0; i < strs.length; i++) {
                    theRequest[strs[i].split("=")[0]] = unescape(strs[i].split("=")[1]);
                }
            }
            if (theRequest.hasOwnProperty('UserId') === true) {
                var strUserId = theRequest.UserId;
                clsCommSession_js_1.clsCommSession.UserId = strUserId;
            }
            if (theRequest.hasOwnProperty('CurrPrjId') === true) {
                var strCurrPrjId = theRequest.CurrPrjId;
                clsCommSession_js_1.clsCommSession.CurrPrjId = strCurrPrjId;
            }
            if (theRequest.hasOwnProperty('CurrSelPrjId') === true) {
                var strCurrSelPrjId = theRequest.CurrSelPrjId;
                clsCommSession_js_1.clsCommSession.CurrSelPrjId = strCurrSelPrjId;
            }
            if (theRequest.hasOwnProperty('CurrUserRoleId') === true) {
                var strCurrUserRoleId = theRequest.CurrUserRoleId;
                clsCommSession_js_1.clsCommSession.CurrUserRoleId = strCurrUserRoleId;
            }
            if (theRequest.hasOwnProperty('CurrPrjDataBaseId') === true) {
                var strCurrPrjDataBaseId = theRequest.CurrPrjDataBaseId;
                clsCommSession_js_1.clsCommSession.CurrPrjDataBaseId = strCurrPrjDataBaseId;
            }
            console.log(clsCommSession_js_1.clsCommSession.UserId);
            console.log(clsCommSession_js_1.clsCommSession.CurrPrjId);
            console.log(clsCommSession_js_1.clsCommSession.CurrSelPrjId);
            console.log(clsCommSession_js_1.clsCommSession.CurrUserRoleId);
            console.log(clsCommSession_js_1.clsCommSession.CurrPrjDataBaseId);
            return theRequest;

            //var strUserId = 
        }

        /* 函数功能:页面导入,当页面开始运行时所发生的事件
 (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_Page_Load_Cache)
*/
        WA_PrjTab_QUDI_CacheEx.prototype.Page_Load_Cache = async function () {
            // 在此处放置用户代码以初始化页面
            try {
                var theRequest = this.GetQueryValue();
                WA_PrjTab_QUDI_Cache_js_1.WA_PrjTab_QUDI_Cache.strPrjId_Cache = clsCommSession_js_1.clsCommSession.CurrSelPrjId;

                console.log(theRequest);
                // 设置建立缓存
                clsPubFun_js_1.clsPubFun.SetCommFun4BL();
                // 为查询区绑定下拉框
                this.BindDdl4QueryRegion();
                var objCacheMode_Cond = new clsCacheModeEN_js_1.clsCacheModeEN();//编辑区域
                const ddlCacheModeId = await clsCacheModeWApi_js_1.clsCacheModeWApi.BindDdl_CacheModeId_Cache("ddlCacheModeId_SetFldValue", objCacheMode_Cond);//编辑区域

                this.hidSortvPrjTabBy = "TabId Asc";
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vPrjTab_Cache();
            }
            catch (e) {
                var strMsg = "页面启动不成功," + e + ".";
                alert(strMsg);
            }
        }


        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_JS4JavaScript:Gen_WApi_JS_btn_Click)
        */
        WA_PrjTab_QUDI_CacheEx.btn_Click = function (strCommandName, strKeyId) {
            var objPage = new WA_PrjTab_QUDI_CacheEx();
            switch (strCommandName) {
                case "Query":    //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId":    //添加记录使用最大关键字
                    ShowDialog('AddWithMaxId');
                    objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord":            //添加记录
                case "Create":            //添加记录
                    objPage.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord":            //修改记录
                case "Update":            //修改记录
                    var strKeyId = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId();
                    if (strKeyId == "") {
                        alert("请选择需要修改的记录！");
                        return;
                    }
                    objPage.btnUpdateRecord_Click();
                    break;
                case "CopyRecord":            //复制记录
                case "Clone":            //复制记录
                    var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord":            //删除记录
                case "Delete":            //删除记录
                    var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordBySign":            //按标志删除记录
                    var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign":            //按标志恢复删除记录
                    var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop":            //置顶记录
                    var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    objPage.btnGoTop_Click();
                    break;
                case "GoBottum":            //移底记录
                    var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    objPage.btnGoBottum_Click();
                    break;
                case "UpMove":            //上移记录
                    var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    objPage.btnUpMove_Click();
                    break;
                case "DownMove":            //下移记录
                    var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要下移的记录！");
                        return;
                    }
                    objPage.btnDownMove_Click();
                    break;
                case "ReOrder":            //重序记录
                    objPage.btnReOrder_Click();
                    break;
                default:
                    var strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel":            //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
        WA_PrjTab_QUDI_CacheEx.strPrjId_Cache = "strPrjId1";
        return WA_PrjTab_QUDI_CacheEx;
    }(WA_PrjTab_QUDI_Cache_js_1.WA_PrjTab_QUDI_Cache));
    exports.WA_PrjTab_QUDI_CacheEx = WA_PrjTab_QUDI_CacheEx;
});