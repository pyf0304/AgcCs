function include(path) {
    var a = document.createElement("script");
    a.type = "text/javascript";
    a.src = path;
    var head = document.getElementsByTagName("head")[0];
    if (IsExistPath(head, a) === false) {
        head.appendChild(a);
    }
}
function IsExistPath(head, a)
{
    var arrChildNodes = head.childNodes;
    var intLen = arrChildNodes.length;
    for(var i=0; i<intLen; i++)
    {
        var objNode = arrChildNodes[i];
        if (objNode.outerHTML === a.outerHTML)
        {
            return true;
        }
    }
    return false;
}