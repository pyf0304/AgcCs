var clsTableObjWS4ControllerDelegate = function()
{
    //1:
    this.GetRecordJSONObjByKeyFinished = function (objResponseData, strClassName) { };
    this.GetRecordJSONObjByKeyCorrectFinished = function (strResult, strClassName) { };

    //2:
    this.GetRecordJSONObjLstFinished = function (objResponseData, strClassName) { };
    this.GetRecordJSONObjLstCorrectFinished = function (strResult, strClassName) { };

    //3:
    this.AddNewRecordByJSONFinished = function (objResponseData, strClassName) { };
    this.AddNewRecordByJSONCorrectFinished = function (strResult, strClassName) { };

    //4:
    this.UpdateRecordByJSONFinished = function (objResponseData, strClassName) { };
    this.UpdateRecordByJSONCorrectFinished = function (strResult, strClassName) { };

    //5:
    this.DeleteRecordFinished = function (objResponseData, strClassName) { };
    this.DeleteRecordCorrectFinished = function (strResult, strClassName) { };

    //6:
    this.GetFirstRecordJSONObjFinished = function (objResponseData, strClassName) { };
    this.GetFirstRecordJSONObjCorrectFinished = function (strResult, strClassName) { };

    //7:
    this.IsExistRecordFinished = function (objResponseData, strClassName) { };
    this.IsExistRecordCorrectFinished = function (strResult, strClassName) { };

    //8:
    this.GetMaxStrIdFinished = function (objResponseData, strClassName) { };
    this.GetMaxStrIdCorrectFinished = function (strResult, strClassName) { };

    //9
    this.GetMaxStrIdByPrefixFinished = function (objResponseData, strClassName) { };
    this.GetMaxStrIdByPrefixCorrectFinished = function (strResult, strClassName) { };

    //10:
    this.GetTopRecordJSONObjLstFinished = function (objResponseData, strClassName) { };
    this.GetTopRecordJSONObjLstCorrectFinished = function (strResult, strClassName) { };

    //11:
    this.GetRecordJSONObjLstByPagerFinished = function (objResponseData, strClassName) { };
    this.GetRecordJSONObjLstByPagerCorrectFinished = function (strResult, strClassName) { };

    //12:
    this.funGetRecCountByCondFinished = function (objResponseData, strClassName) { };
    this.funGetRecCountByCondCorrectFinished = function (intResult, strClassName) { };

    //50-60
    this.SelfDefFuncFinished = function (objResponseData, strClassName, strFunctionName) {
    }

    this.SelfDefFuncCorrectFinished = function (strResult, strClassName, strFunctionName) {
    }
}