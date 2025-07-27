function SubmitKeyClick(strButtonName)
{ 
    if(event.keyCode==13)
    {
        event.keyCode = 9;
        event.returnValue = false;
        alert("enter");
    //    var el = window.event.srcElement
    //    var txtPassWord = getObjByTagAndId("input", "txtPassWord");
    //    var txtUid = getObjByTagAndId("input", "txtUid");

    //    if( el.id== txtPassWord.id  || el.id== txtUid.id ){
        var objButtonName = getObjByTagAndId("input", strButtonName);

    objButtonName.click();

    return false;

    }
    //}
}