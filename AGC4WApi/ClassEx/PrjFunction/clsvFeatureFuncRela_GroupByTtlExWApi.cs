
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureFuncRela_GroupByTtlExWApi
 表名:vFeatureFuncRela_GroupByTtl(00050537)
 生成代码版本:2020.05.28.1
 生成日期:2020/05/28 17:10:35
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:函数管理
 模块英文名:PrjFunction
 框架-层名:WA_访问扩展层(WA_AccessEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
public static class clsvFeatureFuncRela_GroupByTtlExWApi_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvFeatureFuncRela_GroupByTtlENS">源对象</param>
 /// <returns>目标对象=>clsvFeatureFuncRela_GroupByTtlEN:objvFeatureFuncRela_GroupByTtlENT</returns>
 public static clsvFeatureFuncRela_GroupByTtlENEx CopyToEx(this clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlENS)
{
try
{
 clsvFeatureFuncRela_GroupByTtlENEx objvFeatureFuncRela_GroupByTtlENT = new clsvFeatureFuncRela_GroupByTtlENEx();
clsvFeatureFuncRela_GroupByTtlWApi.CopyTo(objvFeatureFuncRela_GroupByTtlENS, objvFeatureFuncRela_GroupByTtlENT);
 return objvFeatureFuncRela_GroupByTtlENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// v功能函数关系_分类汇总(vFeatureFuncRela_GroupByTtl)
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureFuncRela_GroupByTtlExWApi
{
private static readonly string mstrApiControllerName = "vFeatureFuncRela_GroupByTtlExApi";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public static List<clsvFeatureFuncRela_GroupByTtlEN> arrvFeatureFuncRela_GroupByTtlObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;

/// <summary>
/// 构造函数
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
/// </summary>
 public clsvFeatureFuncRela_GroupByTtlExWApi()
 {
 }

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_EditRecordEx)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool EditRecordEx(clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN)
{
if (string.IsNullOrEmpty(objvFeatureFuncRela_GroupByTtlEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objvFeatureFuncRela_GroupByTtlEN.FeatureId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "EditRecordEx";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsvFeatureFuncRela_GroupByTtlEN>(objvFeatureFuncRela_GroupByTtlEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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