
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunction4GeneCode_SimExWApi
 表名:vFunction4GeneCode_Sim(00050605)
 生成代码版本:2022.03.03.1
 生成日期:2022/03/03 11:35:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class clsvFunction4GeneCode_SimExWApi_Static
{

// /// <summary>
// /// 把同一个类的对象,复制到另一个对象
// /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
// /// </summary>
// /// <param name = "objvFunction4GeneCode_SimENS">源对象</param>
// /// <returns>目标对象=>clsvFunction4GeneCode_SimEN:objvFunction4GeneCode_SimENT</returns>
// public static clsvFunction4GeneCode_SimENEx CopyToEx(this clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimENS)
//{
//try
//{
// clsvFunction4GeneCode_SimENEx objvFunction4GeneCode_SimENT = new clsvFunction4GeneCode_SimENEx();
//this.CopyTo(objvFunction4GeneCode_SimENS, objvFunction4GeneCode_SimENT);
// return objvFunction4GeneCode_SimENT;
//}
//catch (Exception objException)
//{
//string strMsg = string.Format("(errid:Watl000068)Copy表对象数据出错,{1}.({0})",
//clsStackTrace.GetCurrClassFunction(),
//objException.Message); 
//throw new Exception(strMsg); 
//}
//}
}
 /// <summary>
 /// v函数4GC_Sim(vFunction4GeneCode_Sim)
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public class clsvFunction4GeneCode_SimExWApi
{
        private static readonly string mstrApiControllerName = "vFunction4GeneCode_SimExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsvFunction4GeneCode_SimEN> arrvFunction4GeneCode_SimObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;

/// <summary>
/// 构造函数
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
/// </summary>
 public clsvFunction4GeneCode_SimExWApi()
 {
 }

 /// <summary>
 /// 修改记录
 /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_EditRecordEx)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool EditRecordEx(clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN)
{
if (string.IsNullOrEmpty(objvFunction4GeneCode_SimEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objvFunction4GeneCode_SimEN.FuncId4GC, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "EditRecordEx";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsvFunction4GeneCode_SimEN>(objvFunction4GeneCode_SimEN);
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