function GetArray(arr) {
    let arrLst = new Array();
    for (var i = 0; i < arr.length; i++) {
        var chk = arr[i];
        arrLst.push(chk);
    }
    return arrLst;
};
function MultipleSelectGvCheck(strCtrlId) {
    var objLst = document.getElementsByTagName("span");
    let arrElement = GetArray(objLst);
    var spn1;
    let arrFind = arrElement.filter(x => x.attributes["ctrlid"] != null && x.attributes["ctrlid"].nodeValue == strCtrlId);
    if (arrFind.length >= 1) {
        spn1 = arrFind[0];
        if (spn1.children.length > 0) {
            var chk1 = spn1.children[0];
            if (chk1.type == "checkbox") {
                if (chk1.checked == true) {
                    chk1.checked = false;
                    return false;
                }
                else {
                    chk1.checked = true;
                    return true;
                }
            }
        }
        console.log(spn1);
    }

}

function SingleSelectGvCheck(strCtrlId, strDivId) {
    var objLst = document.getElementsByTagName("span");
    let arrElement = GetArray(objLst);
    var spn1;
    SetAllNotCheckedItems4Gv(strDivId);
    let arrFind = arrElement.filter(x => x.attributes["ctrlid"] != null && x.attributes["ctrlid"].nodeValue == strCtrlId);
    if (arrFind.length >= 1) {
        spn1 = arrFind[0];
        if (spn1.children.length > 0) {
            var chk1 = spn1.children[0];
            if (chk1.type == "checkbox") {
                if (chk1.checked == true) {
                    chk1.checked = false;
                    return false;
                }
                else {
                    chk1.checked = true;
                    return true;
                }
            }
        }
        console.log(spn1);
    }

}


Array.prototype.contains = function (obj) {
    var i = this.length;
    while (i--) {
        if (this[i] === obj) {
            return true;
        }
    }
    return false;
}

function GetCheckedItems4Gv(strDivId) {

    var arrTable0 = document.getElementsByTagName("table");
    var arrTable = GetArray(arrTable0);
    arrTable = arrTable.filter(x => x.id.indexOf(strDivId) > -1);
    if (arrTable.length == 0) {
        alert('在当前界面中没有找到Div:' + strDivId + ", (In GetCheckedItems4Gv of tzGridView.js)");
        return;
    }
    var tabContainer = arrTable[0];
    console.log(tabContainer);

    var arrInput0 = tabContainer.getElementsByTagName("input");
    let arrInput = GetArray(arrInput0);
    arrInput = arrInput.filter(x => x.type == "checkbox");
    arrInput = arrInput.filter(x => x.checked == true);
    if (arrInput.length == 0) return null;
    var arrSpan = arrInput.map(x => x.parentNode);
    //arrSpan = arrSpan.filter(x=>x.);
    var arrCtrlId = arrSpan.map(x => x.attributes["ctrlid"].nodeValue);
    console.log(arrCtrlId);
    return arrCtrlId;
}

function SetAllNotCheckedItems4Gv(strDivId) {

    var arrTable0 = document.getElementsByTagName("table");
    var arrTable = GetArray(arrTable0);
    arrTable = arrTable.filter(x => x.id.indexOf(strDivId) > -1);
    if (arrTable.length == 0) {
       
        alert('在当前界面中没有找到Div:' + strDivId + ", (In SetAllNotCheckedItems4Gv of tzGridView.js)");
        return;
    }
    var tabContainer = arrTable[0];
    console.log(tabContainer);

    var arrInput0 = tabContainer.getElementsByTagName("input");
    let arrInput = GetArray(arrInput0);
    arrInput = arrInput.filter(x => x.type == "checkbox");
    arrInput = arrInput.filter(x => x.checked == true);
    if (arrInput.length == 0) return null;
    arrInput.forEach(x=>x.checked = false);
}