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
    var LandingPage = /** @class */ (function () {
        function LandingPage() {
            console.log("This message is comming from Landing Page!");
        }
        return LandingPage;
    }());
    exports.LandingPage = LandingPage;
    //requirejs(['jquery', 'clscommonfunc4web'], function ($, commfunc) {
    //    var Test1: string = commfunc.clsCommonFunc4Web.Test1();
    //    $("#Text1").text("This message is comming from Landing Page!" + Test1);
    //});  
    requirejs(['jquery'], function ($) {
        //var Test1: string = commfunc.clsCommonFunc4Web.Test1();
        var Test1 = "Test1";
        $("#Text1").text("This message is comming from Landing Page!" + Test1);
    });
    requirejs(['./PubFun/jsPubFun.js', 'jquery'], function (pubfun, $) {
        //var Test1: string = commfunc.clsCommonFunc4Web.Test1();
        var Test1 = pubfun.StringFormat("使用Test1{0}", "String.format的使用");
        console.log("String.format的使用");
        console.log(Test1);
        $("#Text1").text("This message is comming from Landing Page!" + Test1);
    });

});
