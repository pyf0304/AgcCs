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
    /// 所有Session变量的定义(clsCommSession)
    /// </summary>
    var clsCommSession = /** @class */ (function () {
        /// <summary>
        /// 构造函数
        /// </summary>
        function clsCommSession() {
        }
        Object.defineProperty(clsCommSession, "UserId", {
            /// <summary>
            /// 用户Id
            /// </summary>
            get: function () {
                var strKey = "UserId";
                if (localStorage.hasOwnProperty(strKey)) {
                    var strUserId = localStorage.getItem(strKey);
                    return strUserId;
                }
                return "";
            },
            /// <summary>
            /// 用户Id
            /// </summary>
            set: function (value) {
                var strKey = "UserId";
                localStorage.setItem(strKey, value);
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsCommSession, "CurrPrjId", {
            /// <summary>
            /// 当前工程Id
            /// </summary>
            get: function () {
                var strKey = "CurrPrjId";
                if (localStorage.hasOwnProperty(strKey)) {
                    var strCurrPrjId = localStorage.getItem(strKey);
                    return strCurrPrjId;
                }
                return "";
            },
            /// <summary>
            /// 当前工程Id
            /// </summary>
            set: function (value) {
                var strKey = "CurrPrjId";
                localStorage.setItem(strKey, value);
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsCommSession, "CurrSelPrj", {
            /// <summary>
            /// 当前工程Id
            /// </summary>
            get: function () {
                var strKey = "CurrSelPrj";
                if (localStorage.hasOwnProperty(strKey)) {
                    var strCurrSelPrj = localStorage.getItem(strKey);
                    return strCurrSelPrj;
                }
                return "";
            },
            /// <summary>
            /// 当前工程Id
            /// </summary>
            set: function (value) {
                var strKey = "CurrSelPrj";
                localStorage.setItem(strKey, value);
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsCommSession, "CurrPrjDataBaseId", {
            /// <summary>
            /// 当前工程数据库Id
            /// </summary>
            get: function () {
                var strKey = "CurrPrjDataBaseId";
                if (localStorage.hasOwnProperty(strKey)) {
                    var strCurrPrjDataBaseId = localStorage.getItem(strKey);
                    return strCurrPrjDataBaseId;
                }
                return "";
            },
            /// <summary>
            /// 当前工程数据库Id
            /// </summary>
            set: function (value) {
                var strKey = "CurrPrjDataBaseId";
                localStorage.setItem(strKey, value);
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        Object.defineProperty(clsCommSession, "CurrUserRoleId", {
            /// <summary>
            /// 当前用户角色Id
            /// </summary>
            get: function () {
                var strKey = "CurrUserRoleId";
                if (localStorage.hasOwnProperty(strKey)) {
                    var strCurrUserRoleId = localStorage.getItem(strKey);
                    return strCurrUserRoleId;
                }
                return "";
            },
            /// <summary>
            /// 当前用户角色Id
            /// </summary>
            set: function (value) {
                var strKey = "CurrUserRoleId";
                localStorage.setItem(strKey, value);
            },
            enumerable: true,
            configurable: true
        });
        ;
        ;
        return clsCommSession;
    }());
    exports.clsCommSession = clsCommSession;
    ;
});
