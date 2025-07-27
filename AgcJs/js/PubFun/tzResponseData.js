/*
 * 功能：返回数据的结构
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
    var tzResponseData = /** @class */ (function () {
        function tzResponseData() {
            this.data = "";
            this.what = 0;
            this.IsFinished = false;
            this.faultString = "";
            this.errorId = 0;
            this.returnBool = false;
            this.returnString = "";
            this.returnObject = null;
            this.returnObjectList = new Array();
        }
        return tzResponseData;
    }());
    exports.tzResponseData = tzResponseData;
});
