/*
 * 功能：为Web提供下拉框对象类
 * 版本：2019-08-03-01
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
    /// <summary>
    /// 下拉框对象类
    /// </summary>
    var clsTreeNode = /** @class */ (function () {
        /*
        /// <param name="strValue"></param>
        /// <param name="strText"></param>
        */
        function clsTreeNode(strValue, strText) {
            this.IsChild = 0;
            /// <summary>
            /// 值
            /// </summary>
            this.CategoryID = "";
            /// <summary>
            /// 文本
            /// </summary>
            this.CategoryName = "";
            this.CategoryID = strValue;
            this.CategoryName = strText;
        }
        Object.defineProperty(clsTreeNode, "con_Text", {
            /// <summary>
            /// 常量:"Text"
            /// </summary>
            get: function () { return "Text"; },
            enumerable: true,
            configurable: true
        });
        ; //文本
        Object.defineProperty(clsTreeNode, "con_Value", {
            /// <summary>
            /// 常量:"Value"
            /// </summary>
            get: function () { return "Value"; } //值
            ,
            enumerable: true,
            configurable: true
        });
        return clsTreeNode;
    }());
    exports.clsTreeNode = clsTreeNode;
});
