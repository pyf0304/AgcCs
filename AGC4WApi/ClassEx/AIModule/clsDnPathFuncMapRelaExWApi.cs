
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnPathFuncMapRelaExWApi
 表名:DnPathFuncMapRela(00050601)
 生成代码版本:2022.01.15.1
 生成日期:2022/01/15 20:51:41
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
 框架-层名:WA_访问扩展层(WA_AccessEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;
using System.Collections.Generic;
using com.taishsoft.json;
using Newtonsoft.Json.Linq; 

namespace AGC4WApi
{
public static class clsDnPathFuncMapRelaExWApi_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objDnPathFuncMapRelaENS">源对象</param>
 /// <returns>目标对象=>clsDnPathFuncMapRelaEN:objDnPathFuncMapRelaENT</returns>
 public static clsDnPathFuncMapRelaENEx CopyToEx(this clsDnPathFuncMapRelaEN objDnPathFuncMapRelaENS)
{
try
{
 clsDnPathFuncMapRelaENEx objDnPathFuncMapRelaENT = new clsDnPathFuncMapRelaENEx();
clsDnPathFuncMapRelaWApi.CopyTo(objDnPathFuncMapRelaENS, objDnPathFuncMapRelaENT);
 return objDnPathFuncMapRelaENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000068)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objDnPathFuncMapRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool EditRecordEx(this clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN)
{
try
{
objDnPathFuncMapRelaEN.sfUpdFldSetStr = objDnPathFuncMapRelaEN.getsfUpdFldSetStr();
bool bolResult = clsDnPathFuncMapRelaExWApi.EditRecordEx(objDnPathFuncMapRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathFuncMapRelaWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000006)编辑记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// Dn路径函数映射关系(DnPathFuncMapRela)
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public class clsDnPathFuncMapRelaExWApi
{
        private static readonly string mstrApiControllerName = "DnPathFuncMapRelaExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsDnPathFuncMapRelaEN> arrDnPathFuncMapRelaObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;

/// <summary>
/// 构造函数
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
/// </summary>
 public clsDnPathFuncMapRelaExWApi()
 {
 }

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_EditRecordEx)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool EditRecordEx(clsDnPathFuncMapRelaEN objDnPathFuncMapRelaEN)
{
if (string.IsNullOrEmpty(objDnPathFuncMapRelaEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDnPathFuncMapRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "EditRecordEx";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnPathFuncMapRelaEN>(objDnPathFuncMapRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

}
}