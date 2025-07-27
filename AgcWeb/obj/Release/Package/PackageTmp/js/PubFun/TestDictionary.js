/// <reference path="tzDictionary.js" />
/// <reference path="tzResponseData.js" />

include("tzDictionary.js")
include("tzResponseData.js")
function testDict() {
    var aa = new tzResponseData();
    aa.errorid = 0;
    alert(aa.errorid);
    var myDict = new Dictionary();
    myDict.add("aa", 33);
    myDict.add("bb", "44");
    var myKeyss = myDict.keys();
    var intLength = myDict.length();
    for (var i = 0 ; i < intLength; i++) {
        var myKey = myKeyss[i];
        var ss = myDict.getItem(myKey);
        alert(ss);
    }
    //alert(myDict.getItem("aa") + myDict.length());
    //alert(myDict.getItem("bb"));
}



function include(path) {
    var a = document.createElement("script");
    a.type = "text/javascript";
    a.src = path;
    var head = document.getElementsByTagName("head")[0];

    if (IsExistPath(head, a) === false) {
        head.appendChild(a);
    }
}
function IsExistPath(head, a) {
    var arrChildNodes = head.childNodes;
    var intLen = arrChildNodes.length;
    for (var i = 0; i < intLen; i++) {
        var objNode = arrChildNodes[i];
        if (objNode.outerHTML === a.outerHTML) {
            return true;
        }
    }
    return false;
}