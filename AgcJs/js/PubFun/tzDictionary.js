/*
 * 功能：定义一个字典类
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
    var Dictionary = /** @class */ (function () {
        function Dictionary() {
            //var userInfo: { [index: string]: string } = {}
            this.elements = {};
        }
        //Length of Dictionary
        Dictionary.prototype.length = function () {
            var intCount = 0;
            for (var k in this.elements) {
                intCount++;
            }
            return intCount;
        };
        ;
        //Check whether the Dictionary is empty
        Dictionary.prototype.isEmpty = function () {
            return (this.length() < 1);
        };
        ;
        //remove all elements from the Dictionary
        Dictionary.prototype.removeAll = function () {
            this.elements = {}; //new  Array();
        };
        ;
        //get specify element of the dictionary
        Dictionary.prototype.element = function (index) {
            var rlt = "";
            if (index >= 0 && index < this.length()) {
                rlt = this.elements[index];
            }
            return rlt;
        };
        //check whether the Dictionary contains this key
        Dictionary.prototype.Exists = function (key) {
            var rlt = false;
            try {
                //for (let k in map) {
                //    egret.log(map[k]);
                //}
                //for (var i = 0, iLen = this.length(); i < iLen; i++) {
                //    if (this.elements[i].key == key) {
                //        rlt = true;
                //        break;
                //    }
                //}
                for (var k in this.elements) {
                    if (k == key) {
                        rlt = true;
                        break;
                    }
                }
            }
            catch (ex) {
            }
            return rlt;
        };
        ;
        //check whether the Dictionary contains this value
        Dictionary.prototype.containsValue = function (value) {
            var rlt = false;
            try {
                //for (let k in map) {
                //    egret.log(map[k]);
                //}
                for (var k in this.elements) {
                    if (this.elements[k] == value) {
                        rlt = true;
                        break;
                    }
                }
            }
            catch (ex) {
            }
            return rlt;
        };
        ;
        //remove this key from the Dictionary
        Dictionary.prototype.remove = function (key) {
            var rlt = false;
            try {
                //for (let k in map) {
                //    egret.log(map[k]);
                //}
                for (var k in this.elements) {
                    if (k === key) {
                        //this.elements.splice(k, 1);
                        delete this.elements[k];
                        rlt = true;
                        break;
                    }
                }
            }
            catch (ex) {
            }
            return rlt;
        };
        ;
        //add this key/value to the Dictionary,if key is exists,replace the value
        Dictionary.prototype.add = function (key, value) {
            this.remove(key);
            this.elements[key] = value;
        };
        ;
        //add this key/value to the Dictionary,if key is exists,append value
        Dictionary.prototype.set = function (key, value) {
            var arr = this.getItem(key);
            if (arr != null) {
                if (typeof (arr) == "object") {
                    //arr.unshift.apply(arr, value);
                    value = arr;
                }
                else {
                    var array = [];
                    array.push(arr);
                    array.unshift.apply(array, value);
                    value = array;
                }
                this.remove(key);
            }
            this.elements[key] = value;
        };
        //get value of the key
        Dictionary.prototype.getItem = function (key) {
            var rlt = "";
            try {
                //for (let k in map) {
                //    egret.log(map[k]);
                //}
                for (var k in this.elements) {
                    if (k == key) {
                        rlt = this.elements[k];
                        break;
                    }
                }
            }
            catch (ex) {
            }
            return rlt;
        };
        ;
        //get all keys of the dictionary
        Dictionary.prototype.keys = function () {
            var arr = [];
            //for (let k in map) {
            //    egret.log(map[k]);
            //}
            for (var k in this.elements) {
                arr.push(k);
            }
            return arr;
        };
        //get all values of the dictionary
        Dictionary.prototype.values = function () {
            var arr = [];
            //for (let k in map) {
            //    egret.log(map[k]);
            //}
            for (var k in this.elements) {
                arr.push(this.elements[k]);
            }
            return arr;
        };
        //get all values of the dictionary
        Dictionary.prototype.getParamText = function () {
            var strParamText = "";
            //for (let k in map) {
            //    egret.log(map[k]);
            //}
            for (var k in this.elements) {
                if (strParamText === "") {
                    strParamText = k + "=" + this.elements[k];
                }
                else {
                    strParamText += "&" + k + "=" + this.elements[k];
                }
            }
            return strParamText;
        };
        return Dictionary;
    }());
    exports.Dictionary = Dictionary;
});
