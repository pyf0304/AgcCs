var md_Operate = "null";
var md_DivName4Edit = "";
Array.prototype.contains = function (v) {
    var b = false;
    for (var i = 0; i < this.length; i++) {
        if (this[i] == v) {
            b = true;
            break;
        }
    }
    return b;
};
function ShowModal() {
    $('#MyTestDialog').modal('show');
}

function HideEditDialog() {
    //alert('complete');
    $(md_DivName4Edit).modal('hide');
}

function ShowEditDialog() {
    //alert('complete');
    $(md_DivName4Edit).modal('show');
}

function ShowHideEditDialog() {
    console.log('ShowHideEditDialog');
    console.log("md_Operate" + md_Operate);
    console.log("md_DivName4Edit" + md_DivName4Edit);
//    var arrOperateLst = ["Add", "Update", "SetFldValue"];
    var arrOperateLst = new Array( "Add", "Update", "SetFldValue");
    if (arrOperateLst.contains(md_Operate) === true) {
        ShowEditDialog();
    }
    else {
        HideEditDialog();
    }
}