(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports",
            "../L3_ForWApi/SysPara/clsCodeTypeWApi.js",
            "../L2_BLL/SysPara/clsCommFun4WA4CodeType.js",
            "../L3_ForWApi/SysPara/clsProgLangTypeWApi.js",
            "../L2_BLL/SysPara/clsCommFun4WA4ProgLangType.js",
            "../L3_ForWApi/GeneCode/clsApplicationTypeWApi.js",
            "../L2_BLL/GeneCode/clsCommFun4WA4ApplicationType.js",
            "../L3_ForWApi/RegionManage/clsRegionTypeWApi.js",
            "../L2_BLL/RegionManage/clsCommFun4WA4RegionType.js",
            //"../L3_ForWApi/UserManage/clsUserIdentityWApi.js",
            //"../L2_BLL/UserManage/clsCommFun4WA4UserIdentity.js",
            "../L3_ForWApi/PrjInterface/clsSQLDSTypeWApi.js",
            "../L2_BLL/PrjInterface/clsCommFun4WA4SQLDSType.js",
            "../L3_ForWApi/SysPara/clsTabTypeWApi.js",
            "../L3_ForWApi/PrjManage/clsProjectsWApi.js",
            "../L3_ForWApi/Table_Field/clsTabStateWApi.js",
            "../L3_ForWApi/PrjManage/clsFuncModule_AgcWApi.js",
            "../L3_ForWApi/Table_Field/clsPrimaryTypeWApi.js",
            "../L3_ForWApi/Table_Field/clsPrjTabWApi.js",
            "../L3_ForWApi/SysPara/clsTabMainTypeWApi.js",
            "../L3_ForWApi/Table_Field/clsCacheModeWApi.js",
            "../L3_ForWApi/Table_Field/clsFieldTabWApi.js",
            "../L3_ForWApi/PrjInterface/clsViewTypeCodeTabWApi.js",
            "../L3_ForWApi/PrjInterface/clsDgFuncTypeWApi.js",
            "../L3_ForWApi/ViewControlManage/clsCtlTypeAbbrWApi.js",
            "../L3_ForWApi/SysPara/clsDataTypeAbbrWApi.js",
            "../L3_ForWApi/PrjInterface/clsViewInfoWApi.js"

        ], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    var clsCodeTypeWApi_js_1 = require("../L3_ForWApi/SysPara/clsCodeTypeWApi.js");
    var clsCommFun4WA4CodeType_js_1 = require("../L2_BLL/SysPara/clsCommFun4WA4CodeType.js");
    var clsProgLangTypeWApi_js_1 = require("../L3_ForWApi/SysPara/clsProgLangTypeWApi.js");
    var clsCommFun4WA4ProgLangType_js_1 = require("../L2_BLL/SysPara/clsCommFun4WA4ProgLangType.js");

    var clsApplicationTypeWApi_js_1 = require("../L3_ForWApi/GeneCode/clsApplicationTypeWApi.js");
    var clsCommFun4WA4ApplicationType_js_1 = require("../L2_BLL/GeneCode/clsCommFun4WA4ApplicationType.js");

    var clsRegionTypeWApi_js_1 = require("../L3_ForWApi/RegionManage/clsRegionTypeWApi.js");
    var clsCommFun4WA4RegionType_js_1 = require("../L2_BLL/RegionManage/clsCommFun4WA4RegionType.js");
    //var clsUserIdentityWApi_js_1 = require("../L3_ForWApi/UserManage/clsUserIdentityWApi.js");
    //var clsCommFun4WA4UserIdentity_js_1 = require("../L2_BLL/UserManage/clsCommFun4WA4UserIdentity.js");
    var clsSQLDSTypeWApi_js_1 = require("../L3_ForWApi/PrjInterface/clsSQLDSTypeWApi.js");
    var clsCommFun4WA4SQLDSType_js_1 = require("../L2_BLL/PrjInterface/clsCommFun4WA4SQLDSType.js");
    var clsTabTypeWApi_js_1 = require("../L3_ForWApi/SysPara/clsTabTypeWApi.js");
    var clsProjectsWApi_js_1 = require("../L3_ForWApi/PrjManage/clsProjectsWApi.js");
    var clsTabStateWApi_js_1 = require("../L3_ForWApi/Table_Field/clsTabStateWApi.js");
    var clsFuncModule_AgcWApi_js_1 = require("../L3_ForWApi/PrjManage/clsFuncModule_AgcWApi.js");

    var clsPrimaryTypeWApi_js_1 = require("../L3_ForWApi/Table_Field/clsPrimaryTypeWApi.js");

    var clsPrjTabWApi_js_1 = require("../L3_ForWApi/Table_Field/clsPrjTabWApi.js");
    var clsTabMainTypeWApi_js_1 = require("../L3_ForWApi/SysPara/clsTabMainTypeWApi.js");
    var clsCacheModeWApi_js_1 = require("../L3_ForWApi/Table_Field/clsCacheModeWApi.js");
    var clsFieldTabWApi_js_1 = require("../L3_ForWApi/Table_Field/clsFieldTabWApi.js");
    var clsViewTypeCodeTabWApi_js_1 = require("../L3_ForWApi/PrjInterface/clsViewTypeCodeTabWApi.js");
    var clsDgFuncTypeWApi_js_1 = require("../L3_ForWApi/PrjInterface/clsDgFuncTypeWApi.js");
    var clsCtlTypeAbbrWApi_js_1 = require("../L3_ForWApi/ViewControlManage/clsCtlTypeAbbrWApi.js");
    var clsDataTypeAbbrWApi_js_1 = require("../L3_ForWApi/SysPara/clsDataTypeAbbrWApi.js");
    var clsViewInfoWApi_js_1 = require("../L3_ForWApi/PrjInterface/clsViewInfoWApi.js");


    var clsPubFun = /** @class */ (function () {
        function clsPubFun() {
        }
        clsPubFun.SetCommFun4BL = function () {
            clsCodeTypeWApi_js_1.clsCodeTypeWApi.objCommFun4BL = new clsCommFun4WA4CodeType_js_1.clsCommFun4WA4CodeType();
            clsProgLangTypeWApi_js_1.clsProgLangTypeWApi.objCommFun4BL = new clsCommFun4WA4ProgLangType_js_1.clsCommFun4WA4ProgLangType();
            clsApplicationTypeWApi_js_1.clsApplicationTypeWApi.objCommFun4BL = new clsCommFun4WA4ApplicationType_js_1.clsCommFun4WA4ApplicationType();
            clsRegionTypeWApi_js_1.clsRegionTypeWApi.objCommFun4BL = new clsCommFun4WA4RegionType_js_1.clsCommFun4WA4RegionType();
            //clsUserIdentityWApi_js_1.clsUserIdentityWApi.objCommFun4BL = new clsCommFun4WA4UserIdentity_js_1.clsCommFun4WA4UserIdentity();
            clsSQLDSTypeWApi_js_1.clsSQLDSTypeWApi.objCommFun4BL = new clsCommFun4WA4SQLDSType_js_1.clsCommFun4WA4SQLDSType();
            clsTabTypeWApi_js_1.clsTabTypeWApi.SetCache();
            clsProjectsWApi_js_1.clsProjectsWApi.SetCache();
            clsTabStateWApi_js_1.clsTabStateWApi.SetCache();
            clsFuncModule_AgcWApi_js_1.clsFuncModule_AgcWApi.SetCache();
            clsPrimaryTypeWApi_js_1.clsPrimaryTypeWApi.SetCache();
            clsPrjTabWApi_js_1.clsPrjTabWApi.SetCache();
            clsTabMainTypeWApi_js_1.clsTabMainTypeWApi.SetCache();
            clsCacheModeWApi_js_1.clsCacheModeWApi.SetCache();
            clsFieldTabWApi_js_1.clsFieldTabWApi.SetCache();
            clsViewTypeCodeTabWApi_js_1.clsViewTypeCodeTabWApi.SetCache();
            clsDgFuncTypeWApi_js_1.clsDgFuncTypeWApi.SetCache();
            clsCtlTypeAbbrWApi_js_1.clsCtlTypeAbbrWApi.SetCache();
            clsDataTypeAbbrWApi_js_1.clsDataTypeAbbrWApi.SetCache();
clsViewInfoWApi_js_1.clsViewInfoWApi.SetCache();


        };
        return clsPubFun;
    }());
    exports.clsPubFun = clsPubFun;
});
