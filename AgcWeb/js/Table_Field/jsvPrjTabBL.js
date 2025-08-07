
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:jsvPrjTabBL
 表名:vPrjTab
 生成代码版本:2017.07.08.1
 生成日期:2017/07/11 06:31:17
 生成者:
 生成服务器IP:1011.251.68.133
 工程名称:AGC
 工程ID:0005
 模块中文名:字段、表维护
 模块英文名:Table_Field
 框架-层名:业务逻辑层
 编程语言:JavaScript
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.06.19.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
 == == == == == == == == == == == == 
 */
 /// <summary>
 /// v工程表(vPrjTab)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
 /// </summary>
 /// <reference path="../PubFun/tzDictionary.js" />
 /// <reference path="../PubFun/jsString.js" />
var VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中
include(VirtualRootPath + "/js/PubFun/tzDictionary.js");
include(VirtualRootPath + "/js/PubFun/jsString.js");
var clsvPrjTabBL = function()
{
 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
 /// </summary>
var itemXmlNode = "vPrjTabListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
 /// </summary>
var listXmlNode = "vPrjTabList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
 /// </summary>
var itemsXmlNode = "Items";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
 /// </summary>
var arrvPrjTabObjLst_Cache = new Array();
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicCode_JavaScript)
 /// </summary>
var intFindFailCount = 0;

 /// <summary>
 /// 把一个JSON串转化为一个对象
 /// 作者:
 /// 日期:20170711063117
 /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_getRecObjByJSONStr_JavaScript)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
this.getvPrjTabObjByJSONStr = function(strJSON)
{
var pobjvPrjTabEN = new clsvPrjTabEN();
if (strJSON == "")
{
return pobjvPrjTabEN;
}
try
{
pobjvPrjTabEN = JSON.parse(strJSON);
}
catch(objException)
{
return pobjvPrjTabEN;
}
return pobjvPrjTabEN;
}

 /// <summary>
 /// 把一个JSON串转化为一个对象列表
 /// 作者:
 /// 日期:20170711063117
 /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_getRecObjLstByJSONStr_JavaScript)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象列表</returns>
this.getvPrjTabObjLstByJSONStr = function(strJSON)
{
var arrvPrjTabObjLst = new Array();
if (strJSON == "")
{
return arrvPrjTabObjLst;
}
try
{
arrvPrjTabObjLst = JSON.parse(strJSON);
}
catch(objException)
{
return arrvPrjTabObjLst;
}
return arrvPrjTabObjLst;
}

 /// <summary>
 /// 把一个对象转化为一个JSON串
 /// 作者:
 /// 日期:20170711063117
 /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_getJSONStrByRecObj_JavaScript)
 /// </summary>
 /// <param name = "strJSON">需要转化的JSON串</param>
 /// <returns>返回一个生成的对象</returns>
this.getJSONStrByvPrjTabObj = function(pobjvPrjTabEN)
{
pobjvPrjTabEN.sf_UpdFldSetStr = pobjvPrjTabEN.getUpdFldString();
var strJson;
var jsonData;
try
{
strJson = JSON.stringify(pobjvPrjTabEN);
}
catch(objException)
{
myShowErrorMsg(objException.message);
}
return strJson;
}
}