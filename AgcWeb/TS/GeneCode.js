function GeneCode(strCodeTypeId, strTabId) {
    //$.ajax({
    //    type: "post",
    //    datatype: "json",
    //    data: '{"strCodeTypeId": ' + strCodeTypeId + ',' +
    //        '"strTabId": ' + strTabId + ',' +
    //        '"strViewId":""}',
    //    url: "TestWucTreeView4GC.aspx/GeneCode",
    //    contentType: "application/json",
    //    success: function (result) {
    //        ShowCode(result.d);
    //    }
    //});
}
function ShowCode(strCode) {
    var txtCode = document.getElementById("txtCode");
    txtCode.innerHTML = strCode;
}
//# sourceMappingURL=GeneCode.js.map