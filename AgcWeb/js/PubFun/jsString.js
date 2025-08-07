function TestDataType() {
    var gettype = Object.prototype.toString
    console.log(gettype.call('aaaa'));// 输出      [object String]
    console.log(gettype.call(2222));// 输出      [object Number]
    console.log(gettype.call(true));//   输出      [object Boolean]
    console.log(gettype.call(undefined));// 输出      [object Undefined]
    console.log(gettype.call(null));//             输出   [object Null]
    console.log(gettype.call({}));//              输出   [object Object]
    console.log(gettype.call([]));//                 输出   [object Array]
    console.log(gettype.call(function () { }));//    输出   [object Function]
    console.log(utility.isNumber(22));
    console.log(utility.isNumber("AA"));

}

var gettype = Object.prototype.toString
var tzDataType = {
    isObj: function (o) {
        return gettype.call(o) == "[object Object]";
    },
    isArray: function (o) {
        return gettype.call(o) == "[object Array]";
    },
    isNULL: function (o) {
        return gettype.call(o) == "[object Null]";
    },
    isDocument: function () {
        return gettype.call(o) == "[object Document]" || "[object HTMLDocument]";
    },
    isNumber: function (o) {
        return gettype.call(o) == "[object Number]";
    },
    isString: function (o) {
        return gettype.call(o) == "[object String]";
    },
    isBoolean: function (o) {
        return gettype.call(o) == "[object Boolean]";
    }
    //         ........
}