
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionTemplateRela_SimBLEx
 表名:vFunctionTemplateRela_Sim(00050604)
 生成代码版本:2022.01.17.1
 生成日期:2022/01/23 20:58:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
 框架-层名:业务逻辑扩展层(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;

using com.taishsoft.comm_db_obj;
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
public static class clsvFunctionTemplateRela_SimBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimENS">源对象</param>
 /// <returns>目标对象=>clsvFunctionTemplateRela_SimEN:objvFunctionTemplateRela_SimENT</returns>
 public static clsvFunctionTemplateRela_SimENEx CopyToEx(this clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimENS)
{
try
{
 clsvFunctionTemplateRela_SimENEx objvFunctionTemplateRela_SimENT = new clsvFunctionTemplateRela_SimENEx();
clsvFunctionTemplateRela_SimBL.vFunctionTemplateRela_SimDA.CopyTo(objvFunctionTemplateRela_SimENS, objvFunctionTemplateRela_SimENT);
 return objvFunctionTemplateRela_SimENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objvFunctionTemplateRela_SimENS">源对象</param>
 /// <returns>目标对象=>clsvFunctionTemplateRela_SimEN:objvFunctionTemplateRela_SimENT</returns>
 public static clsvFunctionTemplateRela_SimEN CopyTo(this clsvFunctionTemplateRela_SimENEx objvFunctionTemplateRela_SimENS)
{
try
{
 clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimENT = new clsvFunctionTemplateRela_SimEN();
clsvFunctionTemplateRela_SimBL.CopyTo(objvFunctionTemplateRela_SimENS, objvFunctionTemplateRela_SimENT);
 return objvFunctionTemplateRela_SimENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// vFunctionTemplateRela_Sim(vFunctionTemplateRela_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvFunctionTemplateRela_SimBLEx : clsvFunctionTemplateRela_SimBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvFunctionTemplateRela_SimDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvFunctionTemplateRela_SimDAEx vFunctionTemplateRela_SimDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvFunctionTemplateRela_SimDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsvFunctionTemplateRela_SimENEx> GetObjExLst(string strCondition)
{
List <clsvFunctionTemplateRela_SimEN> arrObjLst = clsvFunctionTemplateRela_SimBL.GetObjLst(strCondition);
List <clsvFunctionTemplateRela_SimENEx> arrObjExLst = new List<clsvFunctionTemplateRela_SimENEx>();
foreach (clsvFunctionTemplateRela_SimEN objInFor in arrObjLst)
{
clsvFunctionTemplateRela_SimENEx objvFunctionTemplateRela_SimENEx = new clsvFunctionTemplateRela_SimENEx();
clsvFunctionTemplateRela_SimBL.CopyTo(objInFor, objvFunctionTemplateRela_SimENEx);
arrObjExLst.Add(objvFunctionTemplateRela_SimENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strFunctionTemplateId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvFunctionTemplateRela_SimENEx GetObjExByFunctionTemplateId(string strFunctionTemplateId,string strFuncId4GC)
{
clsvFunctionTemplateRela_SimEN objvFunctionTemplateRela_SimEN = clsvFunctionTemplateRela_SimBL.GetObjByKeyLst(strFunctionTemplateId,strFuncId4GC);
clsvFunctionTemplateRela_SimENEx objvFunctionTemplateRela_SimENEx = new clsvFunctionTemplateRela_SimENEx();
clsvFunctionTemplateRela_SimBL.CopyTo(objvFunctionTemplateRela_SimEN, objvFunctionTemplateRela_SimENEx);
return objvFunctionTemplateRela_SimENEx;
}
}
}