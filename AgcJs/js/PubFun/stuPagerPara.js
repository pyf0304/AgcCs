/*
 * 功能：用于分页获取对象列表的参数结构
 * 版本：2019-07-24-01
 * 作者：潘以锋
 * */
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./tzDictionary.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    var tzDictionary_js_1 = require("./tzDictionary.js");
    var stuPagerPara = /** @class */ (function () {
        function stuPagerPara() {
            /// <summary>
            /// 每页记录数
            /// </summary>
            this.PageSize = 0;
            /// <summary>
            /// 页序号
            /// </summary>
            this.PageIndex = 0;
            /// <summary>
            /// 条件串
            /// </summary>
            this.WhereCond = "";
            /// <summary>
            /// 排序表达式
            /// </summary>
            this.OrderBy = "";
        }
        ///// <summary>
        ///// 排除的检查字符串列表
        ///// </summary>
        //public PageSize: Array<string> = new Array<string>();
        ///// <summary>
        ///// 是否检查SQL攻击
        ///// </summary>
        //public IsCheckSQLAttack: boolean = false;
        stuPagerPara.GetMapParam = function (objPagerPara) {
            //List < string > arrLst = new List<string>(objPagerPara.PageSize);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", objPagerPara.WhereCond);
            mapParam.add("strOrderBy", objPagerPara.OrderBy);
            mapParam.add("intPageIndex", objPagerPara.PageIndex.toString());
            mapParam.add("intPageSize", objPagerPara.PageSize.toString());
            return mapParam;
            //var mapParam: Dictionary = new Dictionary()
            //{
            //    "strWhereCond" = objPagerPara.WhereCond,
            //        "strOrderBy" = objPagerPara.OrderBy,
            //        "intPageIndex" = objPagerPara.PageIndex.toString(),
            //        ["arrPageSize"] = clsArray.GetSqlInStrByArray(arrLst, false),
            //        ["bolIsCheckSQLAttack"] = objPagerPara.IsCheckSQLAttack.ToString(),
            //    };
            //return dictParam;
        };
        return stuPagerPara;
    }());
    exports.stuPagerPara = stuPagerPara;
});
