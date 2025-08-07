
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncRegionFldsWApi
 表名:FuncRegionFlds(00050196)
 生成代码版本:2018.08.11.1
 生成日期:2018/08/12 00:10:57
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:区域管理
 模块英文名:RegionManage
 框架-层名:WebApi访问层(WebApiAccess)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2018.07.27.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;
using AGC.BusinessLogic;
using System.Collections.Generic;
using com.taishsoft.json;

namespace AGC4WApi
{
 /// <summary>
 /// 功能区域字段列表(FuncRegionFlds)
 /// (AutoGCLib.AutoGC6Cs_WApi:A_GenWebApiTransCode)
 /// </summary>
public class clsFuncRegionFldsWApi
{
private static string mstrApiControllerName = "FuncRegionFldsApi";
private static string mstrDir = "0";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.AutoGC6Cs_WApi:A_GenWebApiTransCode)
 /// </summary>
public static List<clsFuncRegionFldsEN> arrFuncRegionFldsObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.AutoGC6Cs_WApi:A_GenWebApiTransCode)
 /// </summary>
protected static int intFindFailCount = 0;

 public clsFuncRegionFldsWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_CheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFuncRegionFldsEN objFuncRegionFldsEN)
{
if (!Object.Equals(null, objFuncRegionFldsEN.ButtonName) && getStrLen(objFuncRegionFldsEN.ButtonName) > 30)
{
 throw new Exception("字段[按钮名称]的长度不能超过30!");
}
if (!Object.Equals(null, objFuncRegionFldsEN.Text) && getStrLen(objFuncRegionFldsEN.Text) > 30)
{
 throw new Exception("字段[文本]的长度不能超过30!");
}
if (!Object.Equals(null, objFuncRegionFldsEN.CtlTypeId) && getStrLen(objFuncRegionFldsEN.CtlTypeId) > 2)
{
 throw new Exception("字段[控件类型号]的长度不能超过2!");
}
if (!Object.Equals(null, objFuncRegionFldsEN.CssClass) && getStrLen(objFuncRegionFldsEN.CssClass) > 50)
{
 throw new Exception("字段[样式表]的长度不能超过50!");
}
if (!Object.Equals(null, objFuncRegionFldsEN.ImageUrl) && getStrLen(objFuncRegionFldsEN.ImageUrl) > 100)
{
 throw new Exception("字段[图片资源]的长度不能超过100!");
}
if (!Object.Equals(null, objFuncRegionFldsEN.UserId) && getStrLen(objFuncRegionFldsEN.UserId) > 18)
{
 throw new Exception("字段[用户ID]的长度不能超过18!");
}
if (!Object.Equals(null, objFuncRegionFldsEN.UpdDate) && getStrLen(objFuncRegionFldsEN.UpdDate) > 14)
{
 throw new Exception("字段[修改日期]的长度不能超过14!");
}
if (!Object.Equals(null, objFuncRegionFldsEN.Memo) && getStrLen(objFuncRegionFldsEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objFuncRegionFldsEN.IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncRegionFldsEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsFuncRegionFldsEN objFuncRegionFldsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
objFuncRegionFldsEN = clsJSON.GetObjFromJson<clsFuncRegionFldsEN>(strResult);
return objFuncRegionFldsEN;
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return objFuncRegionFldsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond)
{
string strAction = "GetFirstID_S";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
return strResult;
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "GetFirstID_S", "clsFuncRegionFldsWApi:GetFirstID_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsFuncRegionFldsEN GetFirstFuncRegionFlds_S(string strWhereCond)
{
string strAction = "GetFirstFuncRegionFlds_S";
string strErrMsg = string.Empty;
string strResult = "";
clsFuncRegionFldsEN objFuncRegionFldsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
objFuncRegionFldsEN = clsJSON.GetObjFromJson<clsFuncRegionFldsEN>(strResult);
return objFuncRegionFldsEN;
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "GetFirstObj_S", "clsFuncRegionFldsWApi:GetFirstObj_S", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//初始化列表缓存
string strWhereCond = string.Format("1 = 1 order by mId");
if (arrFuncRegionFldsObjLst_Cache == null)
{
arrFuncRegionFldsObjLst_Cache = clsFuncRegionFldsWApi.GetObjLst(strWhereCond);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFuncRegionFldsEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
InitListCache(); 
int intStart = 0;
int intEnd = arrFuncRegionFldsObjLst_Cache.Count - 1;
int intMid = 0;
clsFuncRegionFldsEN objFuncRegionFldsEN = null;
while (intEnd >= intStart)
{
intMid = (intStart + intEnd) / 2;
objFuncRegionFldsEN = arrFuncRegionFldsObjLst_Cache[intMid];
if (objFuncRegionFldsEN.mId == lngmId)
{
intFindFailCount = 0;
return objFuncRegionFldsEN;
}
else if (objFuncRegionFldsEN.mId.CompareTo(lngmId) > 0)
{
intEnd = intMid - 1;
}
else
{
intStart = intMid + 1;
}
}
intFindFailCount++;
// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
arrFuncRegionFldsObjLst_Cache = null;
if (intFindFailCount == 1) return GetObjBymId_Cache(lngmId);
string strErrMsgForGetObjById = string.Format("在FuncRegionFlds对象缓存列表中,找不到记录[mId = {0}][intFindFailCount = {1}](函数:{2})", lngmId, intFindFailCount, clsStackTrace.GetCurrFunction());
if (objFuncRegionFldsEN != null)
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objFuncRegionFldsEN.mId, intMid);
}
else
{
strErrMsgForGetObjById += string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
}
clsLog.LogErrorS2("clsFuncRegionFldsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncRegionFldsEN> GetObjLst(string strWhereCond)
{
 List<clsFuncRegionFldsEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
arrObjLst = clsJSON.GetObjLstFromJson<clsFuncRegionFldsEN>(strResult);
return arrObjLst;
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return arrObjLst;
}

public static List<clsFuncRegionFldsEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
 List<clsFuncRegionFldsEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
dictParam.Add("strOrderBy", strOrderBy);
dictParam.Add("intMinNum", intMinNum.ToString());
dictParam.Add("intMaxNum", intMaxNum.ToString());
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
arrObjLst = clsJSON.GetObjLstFromJson<clsFuncRegionFldsEN>(strResult);
return arrObjLst;
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "GetObjLstByRange", "clsFuncRegionFldsWApi:GetObjLstByRange", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字删除记录
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
try
{
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
int intResult  = int.Parse(strResult);
return intResult;
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "DelRecord", "clsFuncRegionFldsWApi:DelRecord", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelFuncRegionFldss(List<string> arrmId)
{
string strAction = "DelFuncRegionFldss";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
int intResult  = int.Parse(strResult);
return intResult;
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "DelFuncRegionFldss", "clsFuncRegionFldsWApi:DelFuncRegionFldss", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelFuncRegionFldssByCond(string strWhereCond)
{
string strAction = "funGetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
  int intRecCount =  int.Parse(strResult);
return intRecCount;
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "DelFuncRegionFldssByCond", "clsFuncRegionFldsWApi:DelFuncRegionFldssByCond", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_AddNewRecordBySql2)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecordByJSON(clsFuncRegionFldsEN objFuncRegionFldsEN)
{
string strAction = "AddNewRecordByJSON";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncRegionFldsEN>(objFuncRegionFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
bool bolResult = bool.Parse(strResult);
return bolResult;
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "AddNewRecordBySql2", "clsFuncRegionFldsWApi:AddNewRecordBySql2", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objFuncRegionFldsEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFuncRegionFldsEN objFuncRegionFldsEN)
{
FuncRegionFldsServiceSoapClient objFuncRegionFldsService = GetFuncRegionFldsServiceSoapClient();
try
{
string strKey = objFuncRegionFldsService.AddNewRecordBySql2WithReturnKey(objFuncRegionFldsEN);
return strKey;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "AddNewRecordBySql2WithReturnKey", "clsFuncRegionFldsWApi:AddNewRecordBySql2WithReturnKey", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_UpdateBySql2)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateBySql2(clsFuncRegionFldsEN objFuncRegionFldsEN)
{
string strAction = "UpdateByJSON";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncRegionFldsEN>(objFuncRegionFldsEN);
if (clsPubFun4WApi.Put(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
bool bolResult = bool.Parse(strResult);
return bolResult;
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "UpdateBySql2", "clsFuncRegionFldsWApi:UpdateBySql2", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_UpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objFuncRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFuncRegionFldsEN objFuncRegionFldsEN, string strWhereCond)
{
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncRegionFldsEN>(objFuncRegionFldsEN);
if (clsPubFun4WApi.Put(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
bool bolResult = bool.Parse(strResult);
return bolResult;
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错。WebApi地址:{0},函数名:{1}. 调用函数名:{2}.", 
     clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction), "UpdateWithCondition", "clsFuncRegionFldsWApi:UpdateWithCondition", objException.Message);
 strMsg += string.Format("出错信息:{0}",
      objException.Message);
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
bool bolIsExist = bool.Parse(strResult);
return bolIsExist;
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("lngmId", lngmId.ToString());
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
bool bolIsExist = bool.Parse(strResult);
return bolIsExist;
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.AutoGC6Cs_WApi:Gen_4WA_funGetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int funGetRecCountByCond(string strWhereCond)
{
string strAction = "funGetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strWhereCond", strWhereCond);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
return int.Parse(strResult);
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错。错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.AutoGCPubFuncV6:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int getStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}
}
}