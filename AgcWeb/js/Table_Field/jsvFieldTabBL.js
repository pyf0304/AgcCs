
/*-- -- -- -- -- -- -- -- -- -- --
类名:jsvFieldTabBL
表名:vFieldTab
生成代码版本:2017.12.18.1
生成日期:2018/01/01 17:10:30
生成者:潘以锋
生成服务器IP:1011.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:业务逻辑层
编程语言:JavaScript
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
/// <summary>
/// vFieldTab(vFieldTab)
/// 数据源类型:SQL视图
/// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
/// </summary>
/// <reference path="../PubFun/tzDictionary.js" />
/// <reference path="../PubFun/jsString.js" />
var VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中
include(VirtualRootPath + "/js/PubFun/tzDictionary.js");
include(VirtualRootPath + "/js/PubFun/jsString.js");
var clsvFieldTabBL = function () {
    /// <summary>
    /// 单项的XML结点标签
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
    /// </summary>
    var itemXmlNode = "vFieldTabListItem";
    /// <summary>
    /// 列表的XML结点标签
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
    /// </summary>
    var listXmlNode = "vFieldTabList";
    /// <summary>
    /// 集合的XML结点标签
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
    /// </summary>
    var itemsXmlNode = "Items";
    /// <summary>
    /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
    /// </summary>
    var arrvFieldTabObjLst_Cache = new Array();
    /// <summary>
    /// 从缓存中查找失败的次数
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
    /// </summary>
    var intFindFailCount = 0;

    /// <summary>
    /// 把一个JSON串转化为一个对象
    /// 作者:潘以锋
    /// 日期:20180101171030
    /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_JavaScript_getRecObjByJSONStr)
    /// </summary>
    /// <param name = "strJSON">需要转化的JSON串</param>
    /// <returns>返回一个生成的对象</returns>
    this.GetObjByJSONStr = function (strJSON) {
        var pobjvFieldTabEN = new clsvFieldTabEN();
        if (strJSON === "") {
            return pobjvFieldTabEN;
        }
        try {
            pobjvFieldTabEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvFieldTabEN;
        }
        return pobjvFieldTabEN;
    };

    /// <summary>
    /// 把一个JSON串转化为一个对象列表
    /// 作者:潘以锋
    /// 日期:20180101171030
    /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_JavaScript_getObjLstByJSONStr)
    /// </summary>
    /// <param name = "strJSON">需要转化的JSON串</param>
    /// <returns>返回一个生成的对象列表</returns>
    this.GetObjLstByJSONStr = function (strJSON) {
        var arrvFieldTabObjLst = new Array();
        if (strJSON === "") {
            return arrvFieldTabObjLst;
        }
        try {
            arrvFieldTabObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvFieldTabObjLst;
        }
        return arrvFieldTabObjLst;
    };

    /// <summary>
    /// 把一个对象转化为一个JSON串
    /// 作者:潘以锋
    /// 日期:20180101171030
    /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_JavaScript_getJSONStrByRecObj)
    /// </summary>
    /// <param name = "strJSON">需要转化的JSON串</param>
    /// <returns>返回一个生成的对象</returns>
    this.GetJSONStrByObj = function (pobjvFieldTabEN) {
        pobjvFieldTabEN.sf_UpdFldSetStr = pobjvFieldTabEN.getUpdFldString();
        var strJson;
        var jsonData;
        try {
            strJson = JSON.stringify(pobjvFieldTabEN);
        }
        catch (objException) {
            myShowErrorMsg(objException.message);
        }
        return strJson;
    };
};