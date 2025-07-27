/*
 * 功能：用于获取顶部对象列表的参数结构
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
    var stuTopPara = /** @class */ (function () {
        function stuTopPara() {
            /// <summary>
            /// 顶部记录数
            /// </summary>    
            this.TopSize = 0;
            /// <summary>
            /// 条件串
            /// </summary>
            this.WhereCond = "";
            /// <summary>
            /// 排序表达式
            /// </summary>
            this.OrderBy = "";
            /// <summary>
            /// 排除的检查字符串列表
            /// </summary>
            this.Exclude = "";
            /// <summary>
            /// 是否检查SQL攻击
            /// </summary>
            this.IsCheckSQLAttack = "false";
        }
        stuTopPara.GetMapParam = function (objTopPara) {
            //List < string > arrLst = new List<string>(objTopPara.Exclude);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", objTopPara.WhereCond);
            mapParam.add("strOrderBy", objTopPara.OrderBy);
            mapParam.add("intTopSize", objTopPara.TopSize.toString());
            mapParam.add("arrExclude", objTopPara.Exclude);
            mapParam.add("bolIsCheckSQLAttack", objTopPara.IsCheckSQLAttack.toString());
            return mapParam;
            //var mapParam: Dictionary = new Dictionary()
            //{
            //    "strWhereCond" = objTopPara.WhereCond,
            //        "strOrderBy" = objTopPara.OrderBy,
            //        "intTopSize" = objTopPara.TopSize.toString(),
            //        ["arrExclude"] = clsArray.GetSqlInStrByArray(arrLst, false),
            //        ["bolIsCheckSQLAttack"] = objTopPara.IsCheckSQLAttack.ToString(),
            //    };
            //return dictParam;
        };
        return stuTopPara;
    }());
    exports.stuTopPara = stuTopPara;
});
