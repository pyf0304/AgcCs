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
    /// <summary>
    /// 针对业务逻辑层的一些公共函数类，必须经继承后才能使用。
    /// </summary>
    var clsCommFun4BLV2 = /** @class */ (function () {
        function clsCommFun4BLV2() {
        }
        return clsCommFun4BLV2;
    }());
    exports.clsCommFun4BLV2 = clsCommFun4BLV2;
});
