
/*-- -- -- -- -- -- -- -- -- -- --
类名:spaRegionTypeCRUD
表名:RegionType(00050081)
生成代码版本:2020.05.01.1
生成日期:2020/05/03 10:49:20
生成者:
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:区域管理
模块英文名:RegionManage
框架-层名:WA_界面后台_JS(WA_ViewScriptCS_JS)
编程语言:JavaScript
== == == == == == == == == == == == 
*/
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../Js/L0_Entity/RegionManage/clsRegionTypeEN.js", "../../Js/L2_BLL/RegionManage/clsRegionTypeBL.js", "../../Js/L3_ForWApi/RegionManage/clsRegionTypeWApi.js", "clscommonfunc4web", "tzdictionary", "../../Js/PubFun/clsPager.js", "clsstacktrace", "../../Js/PubFun/clsOrderByData.js", "../../Js/PubFun/stuPagerPara.js", "../../Js/PubFun/clsDataColumn.js", "../../Js/PubFun/clsPubFun.js", "../../Js/PubFun/jsString.js", "../../Js/PubFun/clsCommonFunc4Web.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    var clsRegionTypeEN_js_1 = require("../../Js/L0_Entity/RegionManage/clsRegionTypeEN.js");
    var clsRegionTypeBL_js_1 = require("../../Js/L2_BLL/RegionManage/clsRegionTypeBL.js");
    var clsRegionTypeWApi_js_1 = require("../../Js/L3_ForWApi/RegionManage/clsRegionTypeWApi.js");
    var clsCommonFunc4Web_js_1 = require("clscommonfunc4web");
    var Dictionary_js_1 = require("tzdictionary");
    var clsPager_js_1 = require("../../Js/PubFun/clsPager.js");
    var clsStackTrace_js_1 = require("clsstacktrace");
    var clsOrderByData_js_1 = require("../../Js/PubFun/clsOrderByData.js");
    var stuPagerPara_js_1 = require("../../Js/PubFun/stuPagerPara.js");
    var clsDataColumn_js_1 = require("../../Js/PubFun/clsDataColumn.js");
    var clsPubFun_js_1 = require("../../Js/PubFun/clsPubFun.js");
    var jsString_js_1 = require("../../Js/PubFun/jsString.js");
    var arrSelectedKeys_js_1 = require("../../Js/PubFun/clsCommonFunc4Web.js");
    /* spaRegionTypeCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:GeneCode)
   */
    var spaRegionTypeCRUD = /** @class */ (function () {
        function spaRegionTypeCRUD() {
            this.mstrListDiv = "divDataLst";
            this.objPager = new clsPager_js_1.clsPager();
            /*
            * 每页记录数，在扩展类可以修改
           */
            this.RecCount = 0;
        }
        Object.defineProperty(spaRegionTypeCRUD.prototype, "PageSize", {
            get: function () { return 5; },
            enumerable: true,
            configurable: true
        });


        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddDPV_Edit)
        /// </summary>
        /// <returns></returns>
        spaRegionTypeCRUD.AddDPV_Edit = function (divName4Edit) {
            var strUrl = "./WA_RegionType_Edit.html";
            console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "html",
                    data: {},
                    success: function (data) {
                        console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                        $('#' + divName4Edit).html(data);
                        resolve(true);
                        //setTimeout(() => { clsEditObj_js_1.clsEditObj.BindTab(); }, 100);
                        //clsEditObj_js_1.clsEditObj.BindTab();
                    },
                    error: (e) => {
                        console.log(e);
                        reject(e);
                    }
                });
            });
        };

        /// <summary>
        /// 在当前界面的列表区添加分页区域
        /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddDPV_Pager)
        /// </summary>
        /// <returns></returns>
        spaRegionTypeCRUD.AddDPV_Pager = function (divName4Pager) {
            var strUrl = "../../Js/ShareView/_Pager.html";
            console.log("divName4Pager:(In AddDPV_Pager)" + divName4Pager);
            $.ajax({
                url: strUrl,
                method: "GET",
                dataType: "html",
                data: {},
                success: function (data) {
                    console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                    $('#' + divName4Pager).html(data);
                    //setTimeout(() => { clsPagerObj_js_1.clsPagerObj.BindTab(); }, 100);
                    //clsPagerObj_js_1.clsPagerObj.BindTab();
                },
                error: (e) => {
                    console.log(e);
                }
            });
        };

        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_Page_Load)
       */
        spaRegionTypeCRUD.prototype.Page_Load = async function () {
            // 在此处放置用户代码以初始化页面
            try {
                //建立缓存
                clsPubFun_js_1.clsPubFun.SetCommFun4BL();
                // 为查询区绑定下拉框
                this.BindDdl4QueryRegion();
                this.hidSortRegionTypeBy = "RegionTypeId Asc";
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_RegionType();
            }
            catch (e) {
                var strMsg = "页面启动不成功," + e + ".";
                alert(strMsg);
            }
        }


        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_Page_Load_Cache)
       */
        spaRegionTypeCRUD.prototype.Page_Load_Cache = async function () {
            // 在此处放置用户代码以初始化页面
            try {
                // 设置建立缓存
                clsPubFun_js_1.clsPubFun.SetCommFun4BL();
                // 为查询区绑定下拉框
                this.BindDdl4QueryRegion();
                this.hidSortRegionTypeBy = "RegionTypeId Asc";
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_RegionType_Cache();
            }
            catch (e) {
                var strMsg = "页面启动不成功," + e + ".";
                alert(strMsg);
            }
        }


        /* 函数功能:为编辑区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindDdl4EditRegion)
       */
        spaRegionTypeCRUD.prototype.BindDdl4EditRegion = async function () {
            // 在此处放置用户代码以初始化页面
        }


        /* 函数功能:为查询区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindDdl4QueryRegion)
       */
        spaRegionTypeCRUD.prototype.BindDdl4QueryRegion = async function () {
            // 在此处放置用户代码以初始化页面
        }


        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnQuery_Click)
       */
        spaRegionTypeCRUD.prototype.btnQuery_Click = async function (strListDiv) {
            var strWhereCond = this.CombineRegionTypeCondition();
            try {
                const responseRecCount = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    PageIndex: 1,
                    PageSize: this.PageSize,
                    WhereCond: strWhereCond,
                    OrderBy: this.hidSortRegionTypeBy
                };
                const responseObjLst = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.GetObjLstByPager(objPagerPara).then((jsonData) => {
                    var arrRegionTypeObjLst = jsonData;
                    this.BindTab_RegionType(this.mstrListDiv, arrRegionTypeObjLst);
                });
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "查询不成功," + e + ".";
                alert(strMsg);
            }
        }

        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnAddNewRecord_Click)
       */
        spaRegionTypeCRUD.prototype.btnAddNewRecord_Click = async function () {
            this.OpType = "Add";
            try {
                if (spaRegionTypeCRUD.bolIsLoadEditRegion == false)  //
                {
                    const responseBool = await spaRegionTypeCRUD.AddDPV_Edit(spaRegionTypeCRUD.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    ShowDialog('Add');
                    spaRegionTypeCRUD.bolIsLoadEditRegion = true;  //
                    const responseText = this.AddNewRecord();
                }
                else {
                    ShowDialog('Add');
                    const responseText = await this.AddNewRecord();
                }
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "添加新记录初始化不成功," + e + ".";
                alert(strMsg);
            }
        }

        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnAddNewRecordWithMaxId_Click)
       */
        spaRegionTypeCRUD.prototype.btnAddNewRecordWithMaxId_Click = async function () {
            this.OpType = "AddWithMaxId";
            try {
                const responseText = await this.AddNewRecordWithMaxId();
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "添加新记录初始化不成功," + e + ".";
                alert(strMsg);
            }
        }

        /*
         添加新记录
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnCopyRecord_Click)
        */
        spaRegionTypeCRUD.prototype.btnCopyRecord_Click = async function () {
            try {
                var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要克隆的记录！");
                    return "";
                }
                const responseText = await this.CopyRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_RegionType();
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "复制记录不成功," + e + ".";
                alert(strMsg);
            }
        }

        /* 在数据表里修改记录
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnUpdateRecordInTab_Click)
       */
        spaRegionTypeCRUD.prototype.btnUpdateRecordInTab_Click = function (strKeyId) {
            this.OpType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            this.UpdateRecord(strKeyId);
        }

        /* 
        在数据表里删除记录
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnDelRecordInTab_Click)
       */
        spaRegionTypeCRUD.prototype.btnDelRecordInTab_Click = async function (strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText = await this.DelRecord(strKeyId);
                const responseBindGv = await this.BindGv_RegionType();
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "删除记录不成功. " + e + ".";
                alert(strMsg);
            }
        }

        /* 
        在数据表里选择记录
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnSelectRecordInTab_Click)
       */
        spaRegionTypeCRUD.prototype.btnSelectRecordInTab_Click = async function (strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                this.SelectRecord(strKeyId);
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "选择记录不成功. " + e + ".";
                alert(strMsg);
            }
        }

        /* 
        在数据表里详细信息记录
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnDetailRecordInTab_Click)
       */
        spaRegionTypeCRUD.prototype.btnDetailRecordInTab_Click = async function (strKeyId) {
            this.OpType = "Detail";
            try {
                if (strKeyId == "") {
                    alert("请选择需要详细信息的记录！");
                    return "";
                }
                this.DetailRecord(strKeyId);
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "详细信息记录不成功. " + e + ".";
                alert(strMsg);
            }
        }

        /* 
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_DelRecord)
       */
        spaRegionTypeCRUD.prototype.DelRecord = async function (strRegionTypeId) {
            try {
                const responseText = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.DelRecord(strRegionTypeId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    var strInfo = "删除记录成功,共删除" + returnInt + "条记录!";
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = "删除记录不成功!";
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelRecord!");
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "删除记录不成功. " + e + ".";
                alert(strMsg);
            }
        }

        /* 
        根据关键字详细信息记录
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_DetailRecord)
         <param name = "sender">参数列表</param>
       */
        spaRegionTypeCRUD.prototype.DetailRecord = async function (strRegionTypeId) {
            this.btnOKUpd = "";
            this.btnCancel = "关闭";
            try {
                const responseText = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.GetObjByRegionTypeId(strRegionTypeId);
                var objRegionTypeEN = responseText;
                this.GetDataFromRegionTypeClass(objRegionTypeEN);
                console.log("完成DetailRecord!");
            }
            catch (e) {
                console.log(e);
                var strMsg = "根据关键字获取相应的记录的对象不成功," + e + ".";
                alert(strMsg);
            }
        }

        /* 
        根据关键字选择相应的记录
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_SelectRecord)
         <param name = "sender">参数列表</param>
       */
        spaRegionTypeCRUD.prototype.SelectRecord = async function (strRegionTypeId) {
            try {
                const responseText = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.GetObjByRegionTypeId(strRegionTypeId);
                var objRegionTypeEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web_js_1.clsCommonFunc4Web.Redirect("/Index/Main_RegionType");
            }
            catch (e) {
                console.log(e);
                var strMsg = "根据关键字获取相应的记录的对象不成功," + e + ".";
                alert(strMsg);
            }
        }

        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnUpdateRecord_Click)
       */
        spaRegionTypeCRUD.prototype.btnUpdateRecord_Click = async function () {
            this.OpType = "Update";
            var strKeyId = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId();
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            if (spaRegionTypeCRUD.bolIsLoadEditRegion == false)  //
            {
                const responseBool = await spaRegionTypeCRUD.AddDPV_Edit(spaRegionTypeCRUD.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                ShowDialog('Update');
                spaRegionTypeCRUD.bolIsLoadEditRegion = true;  //
                this.UpdateRecord(strKeyId);
            }
            else {
                ShowDialog('Update');
                this.UpdateRecord(strKeyId);
            }
        }

        /* 按标志恢复删除记录
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnUnDelRecordBySign_Click)
       */
        spaRegionTypeCRUD.prototype.btnUnDelRecordBySign_Click = async function () {
            try {
                var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要恢复删除的记录！");
                    return "";
                }
                const responseText = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.UnDelRecordBySign(arrKeyIds);
                var returnInt = responseText;
                if (returnInt > 0) {
                    var strInfo = "按标志恢复记录成功,共恢复了" + returnInt + "条记录!";
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = "按标志恢复记录不成功!";
                    //显示信息框
                    alert(strInfo);
                    return;
                }
                const responseText2 = await this.BindGv_RegionType();
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "按标志恢复记录不成功. " + e + ".";
                alert(strMsg);
            }
        }

        /* 按标志删除记录
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnDelRecordBySign_Click)
       */
        spaRegionTypeCRUD.prototype.btnDelRecordBySign_Click = async function () {
            try {
                var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要按标志删除的记录！");
                    return "";
                }
                const responseText = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.DelRecordBySign(arrKeyIds);
                var returnInt = responseText;
                if (returnInt > 0) {
                    var strInfo = "按标志删除记录成功,共删除" + returnInt + "条记录!";
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = "按标志删除记录不成功!";
                    //显示信息框
                    alert(strInfo);
                    return;
                }
                const responseText2 = await this.BindGv_RegionType();
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "按标志删除记录不成功. " + e + ".";
                alert(strMsg);
            }
        }

        /* 删除记录
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnDelRecord_Click)
       */
        spaRegionTypeCRUD.prototype.btnDelRecord_Click = async function () {
            try {
                var arrKeyIds = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText = await this.DelMultiRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_RegionType();
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "删除记录不成功. " + e + ".";
                alert(strMsg);
            }
        }











        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnExportExcel_Click)
       */
        spaRegionTypeCRUD.prototype.btnExportExcel_Click = async function () {
            var strWhereCond = " 1=1 ";
            try {
                const responseText = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.GetObjLst(strWhereCond).then((jsonData) => {
                    var arrRegionTypeObjLst = jsonData;
                    this.BindTab_RegionType(this.mstrListDiv, arrRegionTypeObjLst);
                });
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "导出Excel不成功," + e + ".";
                alert(strMsg);
            }
        }

        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_btnOKUpd_Click)
       */
        spaRegionTypeCRUD.prototype.btnOKUpd_Click = async function () {
            var strCommandText = this.btnOKUpd;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.OpType == "AddWithMaxId") {
                            const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                                var returnBool2 = jsonData;
                                if (returnBool2 == true) {
                                    HideDialog();
                                    this.BindGv_RegionType();
                                }
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.BindGv_RegionType();
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In spaRegionTypeCRUD.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_RegionType();
                            }
                        });
                        break;
                    default:
                        var strMsg = "strCommandText:" + strCommandText + "在switch中没有处理！(In btnOKUpd_Click())"
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                var strMsg = "(errid: WiTsCs0033)在保存记录时(" + strCommandText + ")时出错!请联系管理员!" + e + "";
                alert(strMsg);
            }
        }

        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        spaRegionTypeCRUD.prototype.CombineRegionTypeCondition = function () {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.RegionTypeId_q != "") {
                    strWhereCond += " And " + clsRegionTypeEN_js_1.clsRegionTypeEN.con_RegionTypeId + " like '% " + this.RegionTypeId_q + "%'";
                }
                if (this.RegionTypeName_q != "") {
                    strWhereCond += " And " + clsRegionTypeEN_js_1.clsRegionTypeEN.con_RegionTypeName + " like '% " + this.RegionTypeName_q + "%'";
                }
                if (this.RegionTypeENName_q != "") {
                    strWhereCond += " And " + clsRegionTypeEN_js_1.clsRegionTypeEN.con_RegionTypeENName + " like '% " + this.RegionTypeENName_q + "%'";
                }
                if (this.RegionTypeSimName_q != "") {
                    strWhereCond += " And " + clsRegionTypeEN_js_1.clsRegionTypeEN.con_RegionTypeSimName + " like '% " + this.RegionTypeSimName_q + "%'";
                }
            }
            catch (objException) {
                var strMsg = "(errid:WiTsCs0006)在组合查询条件(CombineRegionTypeCondition)时出错!请联系管理员!" + objException.message + "";
                throw strMsg;
            }
            return strWhereCond;
        }

        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        spaRegionTypeCRUD.prototype.CombineRegionTypeConditionObj = function () {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objRegionType_Cond = new clsRegionTypeEN_js_1.clsRegionTypeEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.RegionTypeId_q != "") {
                    strWhereCond += " And " + clsRegionTypeEN_js_1.clsRegionTypeEN.con_RegionTypeId + " like '% " + this.RegionTypeId_q + "%'";
                    objRegionType_Cond.SetCondFldValue(clsRegionTypeEN_js_1.clsRegionTypeEN.con_RegionTypeId, this.RegionTypeId_q, "like");
                }
                if (this.RegionTypeName_q != "") {
                    strWhereCond += " And " + clsRegionTypeEN_js_1.clsRegionTypeEN.con_RegionTypeName + " like '% " + this.RegionTypeName_q + "%'";
                    objRegionType_Cond.SetCondFldValue(clsRegionTypeEN_js_1.clsRegionTypeEN.con_RegionTypeName, this.RegionTypeName_q, "like");
                }
                if (this.RegionTypeENName_q != "") {
                    strWhereCond += " And " + clsRegionTypeEN_js_1.clsRegionTypeEN.con_RegionTypeENName + " like '% " + this.RegionTypeENName_q + "%'";
                    objRegionType_Cond.SetCondFldValue(clsRegionTypeEN_js_1.clsRegionTypeEN.con_RegionTypeENName, this.RegionTypeENName_q, "like");
                }
                if (this.RegionTypeSimName_q != "") {
                    strWhereCond += " And " + clsRegionTypeEN_js_1.clsRegionTypeEN.con_RegionTypeSimName + " like '% " + this.RegionTypeSimName_q + "%'";
                    objRegionType_Cond.SetCondFldValue(clsRegionTypeEN_js_1.clsRegionTypeEN.con_RegionTypeSimName, this.RegionTypeSimName_q, "like");
                }
            }
            catch (objException) {
                var strMsg = "(errid:WiTsCs0007)在组合查询条件对象(CombineRegionTypeConditionObj)时出错!请联系管理员!" + objException.message + "";
                throw strMsg;
            }
            return objRegionType_Cond;
        }

        /* 显示RegionType对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrRegionTypeObjLst">需要绑定的对象列表</param>
       */
        spaRegionTypeCRUD.prototype.BindTab_RegionType = function (divContainer, arrRegionTypeObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert("" + divContainer + "不存在！");
                return;
            }
            var arrDataColumn =
                [
                    {
                        FldName: "",
                        ColHeader: "",
                        Text: "",
                        ColumnType: "CheckBox",
                        OrderNum: 1,
                        FuncName: () => { }
                    },
                    {
                        FldName: "RegionTypeId",
                        ColHeader: "区域类型Id",
                        Text: "",
                        ColumnType: "Label",
                        OrderNum: 1,
                        FuncName: () => { }
                    },
                    {
                        FldName: "RegionTypeName",
                        ColHeader: "区域类型名称",
                        Text: "",
                        ColumnType: "Label",
                        OrderNum: 1,
                        FuncName: () => { }
                    },
                    {
                        FldName: "RegionTypeENName",
                        ColHeader: "区域类型英文名",
                        Text: "",
                        ColumnType: "Label",
                        OrderNum: 1,
                        FuncName: () => { }
                    },
                    {
                        FldName: "RegionTypeSimName",
                        ColHeader: "区域类型简名",
                        Text: "",
                        ColumnType: "Label",
                        OrderNum: 1,
                        FuncName: () => { }
                    },
                    {
                        FldName: "DefaWidth",
                        ColHeader: "缺省宽度",
                        Text: "",
                        ColumnType: "Label",
                        OrderNum: 1,
                        FuncName: () => { }
                    },
                    {
                        FldName: "RegionTypeOrderNum",
                        ColHeader: "区域类型序号",
                        Text: "",
                        ColumnType: "Label",
                        OrderNum: 1,
                        FuncName: () => { }
                    },
                    {
                        FldName: "Memo",
                        ColHeader: "说明",
                        Text: "",
                        ColumnType: "Label",
                        OrderNum: 1,
                        FuncName: () => { }
                    },
                    {
                        FldName: "",
                        ColHeader: "修改",
                        Text: "修改",
                        ColumnType: "Button",
                        OrderNum: 1,
                        FuncName: (strKeyId, strText) => {
                            var btn1 = document.createElement("button");
                            btn1.innerText = strText;
                            btn1.className = "btn btn-outline-info btn-sm";
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
                        FuncName: (strKeyId, strText) => {
                            var btn1 = document.createElement("button");
                            btn1.innerText = strText;
                            btn1.className = "btn btn-outline-info btn-sm";
                            btn1.setAttribute("onclick", "btnDelRecordInTab_Click('" + strKeyId + "');");
                            return btn1;
                        }
                    },
                ];
            clsCommonFunc4Web_js_1.clsCommonFunc4Web.BindTabV2(o, arrRegionTypeObjLst, arrDataColumn, "RegionTypeId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.PageSize = this.PageSize;
            this.objPager.ShowPager();
        }

        /* 函数功能:在数据 列表中跳转到某一页
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_IndexPage)
         <param name = "intPageIndex">页序号</param>
       */
        spaRegionTypeCRUD.prototype.IndexPage = function (intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.CurrPageIndex = intPageIndex;
            this.BindGv_RegionType();
        }

        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindGv)
       */
        spaRegionTypeCRUD.prototype.BindGv_RegionType = async function () {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombineRegionTypeCondition();
            var intCurrPageIndex = this.CurrPageIndex;//获取当前页
            var arrRegionTypeObjLst = [];
            try {
                const responseRecCount = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.GetRecCountByCond(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    PageIndex: intCurrPageIndex,
                    PageSize: this.PageSize,
                    WhereCond: strWhereCond,
                    OrderBy: this.hidSortRegionTypeBy
                };
                const responseObjLst = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.GetObjLstByPager(objPagerPara).then((jsonData) => {
                    arrRegionTypeObjLst = jsonData;
                });
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "绑定GridView不成功," + e + ".";
                alert(strMsg);
            }
            if (arrRegionTypeObjLst.length == 0) {
                var strMsg = "在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！";
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_RegionType(strListDiv, arrRegionTypeObjLst);
                console.log("完成BindGv_RegionType!");
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "绑定对象列表不成功.Error Massage:" + e + ".";
                alert(strMsg);
            }
        }

        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_BindGv_Cache)
       */
        spaRegionTypeCRUD.prototype.BindGv_RegionType_Cache = async function () {
            var strListDiv = this.mstrListDiv;
            var objRegionType_Cond = this.CombineRegionTypeConditionObj();
            var objRegionTypeEN_Sim = clsRegionTypeBL_js_1.clsRegionTypeBL.GetSimObjFromObj(objRegionType_Cond);
            console.log(objRegionTypeEN_Sim);
            var strWhereCond = JSON.stringify(objRegionTypeEN_Sim);
            var intCurrPageIndex = this.CurrPageIndex;//获取当前页
            var arrRegionTypeObjLst = [];
            try {
                this.RecCount = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.GetRecCountByCond_Cache(objRegionType_Cond);
                var objPagerPara = {
                    PageIndex: intCurrPageIndex,
                    PageSize: this.PageSize,
                    WhereCond: strWhereCond,
                    OrderBy: this.hidSortRegionTypeBy
                };
                var arrRegionTypeObjLst = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.GetObjLstByPager_Cache(objPagerPara);
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "绑定GridView不成功," + e + ".";
                alert(strMsg);
            }
            if (arrRegionTypeObjLst.length == 0) {
                var strMsg = "在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=RegionType)";
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_RegionType(strListDiv, arrRegionTypeObjLst);
                console.log("完成BindGv_RegionType!");
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "绑定对象列表不成功.Error Massage:" + e + ".";
                alert(strMsg);
            }
        }

        /* 函数功能:从界面列表中根据某一个字段排序
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_SortBy)
         <param name = "strSortByFld">排序的字段</param>
       */
        spaRegionTypeCRUD.prototype.SortBy = async function (strSortByFld) {
            if (this.hidSortRegionTypeBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortRegionTypeBy.indexOf("Asc") >= 0) {
                    this.hidSortRegionTypeBy = "" + strSortByFld + " Desc";
                }
                else {
                    this.hidSortRegionTypeBy = "" + strSortByFld + " Asc";
                }
            }
            else {
                this.hidSortRegionTypeBy = "" + strSortByFld + " Asc";
            }
            const responseBindGv = await this.BindGv_RegionType();
        }

        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_QueryLst)
       */
        spaRegionTypeCRUD.prototype.QueryRegionTypeLst = function (strListDiv) {
            var strWhereCond = this.CombineRegionTypeCondition();
            var intCurrPageIndex = this.CurrPageIndex;//获取当前页
            return new Promise((resolve, reject) => {
                try {
                    var objPagerPara = {
                        PageIndex: intCurrPageIndex,
                        PageSize: this.PageSize,
                        WhereCond: strWhereCond,
                        OrderBy: this.hidSortRegionTypeBy
                    };
                    const responseText = clsRegionTypeWApi_js_1.clsRegionTypeWApi.GetObjLstByPager(objPagerPara).then((jsonData) => {
                        var arrRegionTypeObjLst = jsonData;
                        this.BindTab_RegionType(strListDiv, arrRegionTypeObjLst);
                        console.log("完成QueryRegionTypeLst!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.log('catch(e)=');
                    console.log(e);
                    var strMsg = "查询对象列表不成功," + e + ".";
                    alert(strMsg);
                }
            });
        }

        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        spaRegionTypeCRUD.prototype.SetKeyReadOnly = function (bolReadonly) {
            $('#txtRegionTypeId').prop['ReadOnly'] = bolReadonly;
        }

        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_Clear)
        /// </summary>	
        spaRegionTypeCRUD.prototype.Clear = function () {
        }

        /* 获取当前表关键字值的最大值,再加1,避免重复
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetMaxStrId)
       */
        spaRegionTypeCRUD.prototype.GetMaxStrId = async function (strKeyCtrlName) {
            this.DivName = "divGetMaxStrId";
            try {
                const responseText = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.GetMaxStrId();
                var returnString = responseText.toString();
                if (returnString == "") {
                    var strInfo = "获取表RegionType的最大关键字为空，不成功，请检查!";
                    $('#lblResult49').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $(strKeyCtrlName).val(returnString);
                }
                else {
                    var strInfo = "获取表RegionType的最大关键字为：" + returnString + "!";
                    $('#lblResult49').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $(strKeyCtrlName).val(returnString);
                }
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "获取表关键字的最大值不成功," + e + ".";
                alert(strMsg);
            }
        }

        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecord)
       */
        spaRegionTypeCRUD.prototype.AddNewRecord = async function () {
            this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucRegionTypeB1.RegionTypeId = clsRegionTypeBL_js_1.clsRegionTypeBL.GetMaxStrId_S();
        }

        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordWithMaxId)
       */
        spaRegionTypeCRUD.prototype.AddNewRecordWithMaxId = function () {
            this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucRegionTypeB1.RegionTypeId = clsRegionTypeBL_js_1.clsRegionTypeBL.GetMaxStrId_S();
        }

        /* 复制记录
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_CopyRecord)
       */
        spaRegionTypeCRUD.prototype.CopyRecord = async function (arrRegionTypeId) {
            try {
                const responseText = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.GetObjLstByRegionTypeIdLst(arrRegionTypeId);
                console.log('responseText=');
                console.log(responseText);
                var intCount = 0;
                var arrRegionTypeObjLst = responseText;
                for (let objInFor of arrRegionTypeObjLst) {
                    const responseText2 = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.AddNewRecord(objInFor);
                    console.log('responseText2=');
                    console.log(responseText2);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        var strInfo = "克隆记录成功!";
                        intCount++;
                    }
                    else {
                        var strInfo = "克隆记录不成功!";
                        //显示信息框
                        alert(strInfo);
                    }
                }
                var strInfo = "共克隆了" + intCount + "条记录!";
                alert(strInfo);
                console.log('完成！');
            }
            catch (e) {
                var strMsg = "复制记录不成功," + e + ".";
                alert(strMsg);
            }
        }

        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_PutDataToClass)
         <param name = "pobjRegionTypeEN">数据传输的目的类对象</param>
       */
        spaRegionTypeCRUD.prototype.PutDataToRegionTypeClass = function (pobjRegionTypeEN) {
            pobjRegionTypeEN.RegionTypeId = this.RegionTypeId;// 区域类型Id
            pobjRegionTypeEN.RegionTypeName = this.RegionTypeName;// 区域类型名称
            pobjRegionTypeEN.RegionTypeENName = this.RegionTypeENName;// 区域类型英文名
            pobjRegionTypeEN.RegionTypeSimName = this.RegionTypeSimName;// 区域类型简名
            pobjRegionTypeEN.DefaWidth = this.DefaWidth;// 缺省宽度
            pobjRegionTypeEN.RegionTypeOrderNum = this.RegionTypeOrderNum;// 区域类型序号
            pobjRegionTypeEN.Memo = this.Memo;// 说明
        }


        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordSave)
       */
        spaRegionTypeCRUD.prototype.AddNewRecordSave = async function () {
            this.DivName = "divAddNewRecordSave";
            var objRegionTypeEN = new clsRegionTypeEN_js_1.clsRegionTypeEN();
            this.PutDataToRegionTypeClass(objRegionTypeEN);
            try {
                const responseText = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.IsExist(objRegionTypeEN.RegionTypeId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = "添加记录时，关键字：" + objRegionTypeEN.RegionTypeId + "已经存在！";
                    alert(strMsg);
                    return responseText;//一定要有一个返回值，否则会出错！
                }
                const responseText2 = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.AddNewRecord(objRegionTypeEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = "添加记录成功!";
                    $('#lblResult55').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = "添加记录不成功!";
                    $('#lblResult55').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    return false;//一定要有一个返回值，否则会出错！
                }
                return responseText2;//一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "添加记录不成功," + e + ".";
                alert(strMsg);
                return false;//一定要有一个返回值，否则会出错！
            }
            return true;//一定要有一个返回值，否则会出错！
        }

        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
        (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_AddNewRecordWithMaxIdSave)
       */
        spaRegionTypeCRUD.prototype.AddNewRecordWithMaxIdSave = async function () {
            this.DivName = "divAddNewRecordWithMaxIdSave";
            var objRegionTypeEN = new clsRegionTypeEN_js_1.clsRegionTypeEN();
            this.PutDataToRegionTypeClass(objRegionTypeEN);
            try {
                const responseText2 = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.AddNewRecordWithMaxId(objRegionTypeEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = "添加记录成功!";
                    $('#lblResult56').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = "添加记录不成功!";
                    $('#lblResult56').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2;//一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "添加记录不成功," + e + ".";
                alert(strMsg);
            }
            return true;//一定要有一个返回值，否则会出错！
        }

        /* 函数功能:把以该关键字的记录内容显示在界面上,
              在这里是把值传到表控件中
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_ShowData)
         <param name = "strRegionTypeId">表记录的关键字,显示该表关键字的内容</param>
       */
        spaRegionTypeCRUD.prototype.ShowData = async function (strRegionTypeId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objRegionTypeEN = new clsRegionTypeEN_js_1.clsRegionTypeEN();
            try {
                const responseText = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.IsExist(strRegionTypeId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = "关键字:[" + strRegionTypeId + "] 的记录不存在!";
                    //$('#lblResult1').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                }
            }
            catch (e) {
                var strMsg = "检查相应关键字的记录存在不成功, " + e + ".";
                alert(strMsg);
            }
            try {
                const responseText = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.GetObjByRegionTypeId(strRegionTypeId);
                objRegionTypeEN = responseText;
            }
            catch (e) {
                var strMsg = "根据关键字获取相应的记录的对象不成功," + e + ".";
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromRegionTypeClass(objRegionTypeEN);
        }

        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetDataFromClass)
         <param name = "pobjRegionTypeEN">表实体类对象</param>
       */
        spaRegionTypeCRUD.prototype.GetDataFromRegionTypeClass = function (pobjRegionTypeEN) {
            this.RegionTypeId = pobjRegionTypeEN.RegionTypeId;// 区域类型Id
            this.RegionTypeName = pobjRegionTypeEN.RegionTypeName;// 区域类型名称
            this.RegionTypeENName = pobjRegionTypeEN.RegionTypeENName;// 区域类型英文名
            this.RegionTypeSimName = pobjRegionTypeEN.RegionTypeSimName;// 区域类型简名
            this.DefaWidth = pobjRegionTypeEN.DefaWidth;// 缺省宽度
            this.RegionTypeOrderNum = pobjRegionTypeEN.RegionTypeOrderNum;// 区域类型序号
            this.Memo = pobjRegionTypeEN.Memo;// 说明
        }

        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        spaRegionTypeCRUD.prototype.UpdateRecord = async function (strRegionTypeId) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.KeyId = strRegionTypeId;
            try {
                const responseText = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.GetObjByRegionTypeId(strRegionTypeId);
                var objRegionTypeEN = responseText;
                this.GetDataFromRegionTypeClass(objRegionTypeEN);
                console.log("完成UpdateRecord!");
            }
            catch (e) {
                console.log(e);
                var strMsg = "根据关键字获取相应的记录的对象不成功," + e + ".";
                alert(strMsg);
            }
        }

        /* 修改记录
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_UpdateRecordSave)
       */
        spaRegionTypeCRUD.prototype.UpdateRecordSave = async function () {
            this.DivName = "divUpdateRecordSave";
            var objRegionTypeEN = new clsRegionTypeEN_js_1.clsRegionTypeEN();
            objRegionTypeEN.RegionTypeId = this.KeyId;
            this.PutDataToRegionTypeClass(objRegionTypeEN);
            objRegionTypeEN.sf_UpdFldSetStr = objRegionTypeEN.UpdFldString;//设置哪些字段被修改(脏字段)
            if (objRegionTypeEN.RegionTypeId == "" || objRegionTypeEN.RegionTypeId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.UpdateRecord(objRegionTypeEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                }
                return returnBool;
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "修改记录不成功," + e + ".";
                alert(strMsg);
            }
            return true;
        }

        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_DelMultiRecord)
       */
        spaRegionTypeCRUD.prototype.DelMultiRecord = async function (arrRegionTypeId) {
            try {
                const responseText = await clsRegionTypeWApi_js_1.clsRegionTypeWApi.DelRegionTypes(arrRegionTypeId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    var strInfo = "删除记录成功,共删除" + returnInt + "条记录!";
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = "删除记录不成功!";
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelMultiRecord!");
            }
            catch (e) {
                console.log('catch(e)=');
                console.log(e);
                var strMsg = "删除记录不成功. " + e + ".";
                alert(strMsg);
            }
        }

        /* 显示{0}对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_ShowTabObj)
         <param name = "divContainer">显示容器</param>
         <param name = "objRegionType">需要显示的对象</param>
       */
        spaRegionTypeCRUD.prototype.ShowRegionTypeObj = function (divContainer, objRegionType) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert("" + divContainer + "不存在！");
                return;
            }
            var sstrKeys = clsCommonFunc4Web_js_1.clsCommonFunc4Web.GetObjKeys(objRegionType);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objRegionType[strKey];
                var li = document.createElement("li");
                li.innerHTML = "" + strKey + ":" + strValue + "";
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }

        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetFirstKey)
         <param name = "pobjRegionTypeEN">表实体类对象</param>
        <returns>列表的第一个关键字值</returns>
       */
        spaRegionTypeCRUD.prototype.GetFirstKey = function () {
            if (arrSelectedKeys.length == 1) {
                return arrSelectedKeys[0];
            }
            else {
                alert("请选择一个关键字！目前选择了:" + arrSelectedKeys.length + "个关键字。");
                return "";
            }
        }

        /*
        演示Session 操作
          (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_Demo_Session)
        */
        spaRegionTypeCRUD.prototype.Demo_Session = async function () {
            try {
                //设置Session
                var strUserId = "TestUserId";
                await this.SetSession("UserId", strUserId);
                //获取Session
                var strUserId_Value1 = await this.GetSession("UserId");
                console.log('strUserId_Value1:' + strUserId_Value1);
                //获取Session方法2：直接读取页面中的hidUserId
                var strUserId_Value2 = this.hidUserId;
                console.log('strUserId_Value2:' + strUserId_Value2);
            }
            catch (e) {
                var strMsg = "演示Session不成功," + e + ".";
                alert(strMsg);
            }
        }

        /*
        设置Session
          (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_SetSession)
        <param name = "Key">关键字</param>
        <param name = "Value">值</param>
        */
        spaRegionTypeCRUD.prototype.SetSession = function (Key, Value) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl_Session_SetString,
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key,
                        Value: Value
                    },
                    success: function (data) {
                        var strKey = data.key;
                        var strValue = data.value;
                        console.log('strKey, strValue=' + strKey + strValue);
                    }
                });
            });
        }

        /*
        获取Session 关键字的值
          (AutoGCLib.WA_ViewScriptCS_JS4JavaScript:Gen_WApi_Js_GetSession)
        <param name = "Key">关键字</param>
         <return>值</return>
        */
        spaRegionTypeCRUD.prototype.GetSession = function (Key) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl_Session_GetString,
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key,
                    },
                    success: function (data) {
                        var strKey = data.key;
                        var strValue = data.value;
                        console.log('strKey, strValue=' + strKey + strValue);
                        resolve(data);
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = "网络错误！访问网络不成功！";
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        }
        /*
        * 设置取消按钮的标题
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "btnCancel", {
            set: function (value) {
                $("#btnCancel").html(value);
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 设置确定按钮的标题
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "btnOKUpd", {
            set: function (value) {
                $("#btnOKUpd").html(value);
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 获取按钮的标题
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "btnOKUpd", {
            get: function () {
                return $("#btnOKUpd").html();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 设置当前页序号
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "CurrPageIndex", {
            set: function (value) {
                $("#hidCurrPageIndex").val(value);
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 获取当前页序号
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "CurrPageIndex", {
            get: function () {
                return $("#hidCurrPageIndex").val();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 缺省宽度
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "DefaWidth", {
            set: function (value) {
                $("#txtDefaWidth").val(value);
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 缺省宽度
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "DefaWidth", {
            get: function () {
                return $("#txtDefaWidth").val();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 添加、修改用的层名
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "DivName", {
            set: function (value) {
                $("#hidDivName").val(value);
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "hidSortRegionTypeBy", {
            set: function (value) {
                $("#hidSortRegionTypeBy").val(value);
            },
            get: function () {
                return $("#hidSortRegionTypeBy").val();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 用户Id
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "hidUserId", {
            get: function () {
                return $("#hidUserId").val();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 设置关键字的值
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "KeyId", {
            set: function (value) {
                $("#hidKeyId").val(value);
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 设置关键字的值
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "KeyId", {
            get: function () {
                return $("#hidKeyId").val();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 说明
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "Memo", {
            set: function (value) {
                $("#txtMemo").val(value);
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 说明
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "Memo", {
            get: function () {
                return $("#txtMemo").val();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 设置操作类型：Add||Update||Detail
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "OpType", {
            set: function (value) {
                $("#hidOpType").val(value);
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 设置操作类型：Add||Update||Detail
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "OpType", {
            get: function () {
                return $("#hidOpType").val();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 区域类型英文名
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "RegionTypeENName", {
            set: function (value) {
                $("#txtRegionTypeENName").val(value);
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 区域类型英文名
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "RegionTypeENName", {
            get: function () {
                return $("#txtRegionTypeENName").val();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 区域类型英文名
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "RegionTypeENName_q", {
            get: function () {
                return $("#txtRegionTypeENName_q").val();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 区域类型Id
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "RegionTypeId", {
            set: function (value) {
                $("#txtRegionTypeId").val(value);
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 区域类型Id
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "RegionTypeId", {
            get: function () {
                return $("#txtRegionTypeId").val();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 区域类型Id
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "RegionTypeId_q", {
            get: function () {
                return $("#txtRegionTypeId_q").val();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 区域类型名称
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "RegionTypeName", {
            set: function (value) {
                $("#txtRegionTypeName").val(value);
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 区域类型名称
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "RegionTypeName", {
            get: function () {
                return $("#txtRegionTypeName").val();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 区域类型名称
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "RegionTypeName_q", {
            get: function () {
                return $("#txtRegionTypeName_q").val();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 区域类型序号
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "RegionTypeOrderNum", {
            set: function (value) {
                $("#txtRegionTypeOrderNum").val(value);
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 区域类型序号
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "RegionTypeOrderNum", {
            get: function () {
                return $("#txtRegionTypeOrderNum").val();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 区域类型简名
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "RegionTypeSimName", {
            set: function (value) {
                $("#txtRegionTypeSimName").val(value);
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 区域类型简名
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "RegionTypeSimName", {
            get: function () {
                return $("#txtRegionTypeSimName").val();
            },
            enumerable: true,
            configurable: true
        });
        /*
        * 区域类型简名
       */
        Object.defineProperty(spaRegionTypeCRUD.prototype, "RegionTypeSimName_q", {
            get: function () {
                return $("#txtRegionTypeSimName_q").val();
            },
            enumerable: true,
            configurable: true
        });
        spaRegionTypeCRUD.bolIsLoadEditRegion = false;  //
        spaRegionTypeCRUD.divName4Edit = "divEdit";  //
        return spaRegionTypeCRUD;
    }());
    exports.spaRegionTypeCRUD = spaRegionTypeCRUD;
});