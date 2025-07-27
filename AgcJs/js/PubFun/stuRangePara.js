/*
 * 功能：用于按范围获取对象列表的参数结构
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
    var stuRangePara = /** @class */ (function () {
        function stuRangePara() {
            /// <summary>
            /// 记录范围的最小记录号
            /// </summary>
            this.MinNum = 0;
            /// <summary>
            /// 记录范围的最大记录号
            /// </summary>
            this.MaxNum = 0;
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
        //public MinNum: Array<string> = new Array<string>();
        ///// <summary>
        ///// 是否检查SQL攻击
        ///// </summary>
        //public IsCheckSQLAttack: boolean = false;
        stuRangePara.GetMapParam = function (objRangePara) {
            //List < string > arrLst = new List<string>(objRangePara.MinNum);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", objRangePara.WhereCond);
            mapParam.add("strOrderBy", objRangePara.OrderBy);
            mapParam.add("intMaxNum", objRangePara.MaxNum.toString());
            mapParam.add("intMinNum", objRangePara.MinNum.toString());
            return mapParam;
            //var mapParam: Dictionary = new Dictionary()
            //{
            //    "strWhereCond" = objRangePara.WhereCond,
            //        "strOrderBy" = objRangePara.OrderBy,
            //        "intMaxNum" = objRangePara.MaxNum.toString(),
            //        ["arrMinNum"] = clsArray.GetSqlInStrByArray(arrLst, false),
            //        ["bolIsCheckSQLAttack"] = objRangePara.IsCheckSQLAttack.ToString(),
            //    };
            //return dictParam;
        };
        return stuRangePara;
    }());
    exports.stuRangePara = stuRangePara;
});
