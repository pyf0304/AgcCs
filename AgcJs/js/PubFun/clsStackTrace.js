/*
 * 功能：用于跟踪的功能函数
 * 版本：2019-07-24-01
 * 作者：潘以锋
 * */
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    var clsStackTrace = /** @class */ (function () {
        function clsStackTrace() {
        }
        clsStackTrace.GetCurrClassFunction = function () {
            var result = '未知';
            return result;
        };
        clsStackTrace.GetCurrClassFunctionByLevel = function (intLevel) {
            var result = "未知:" + intLevel;
            return result;
        };
        return clsStackTrace;
    }());
    exports.clsStackTrace = clsStackTrace;
});
