
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabRelationTypeBLEx
 表名:PrjTabRelationType(00050607)
 生成代码版本:2022.03.19.1
 生成日期:2022/03/22 02:40:00
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class clsPrjTabRelationTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objPrjTabRelationTypeENS">源对象</param>
 /// <returns>目标对象=>clsPrjTabRelationTypeEN:objPrjTabRelationTypeENT</returns>
 public static clsPrjTabRelationTypeENEx CopyToEx(this clsPrjTabRelationTypeEN objPrjTabRelationTypeENS)
{
try
{
 clsPrjTabRelationTypeENEx objPrjTabRelationTypeENT = new clsPrjTabRelationTypeENEx();
clsPrjTabRelationTypeBL.PrjTabRelationTypeDA.CopyTo(objPrjTabRelationTypeENS, objPrjTabRelationTypeENT);
 return objPrjTabRelationTypeENT;
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
 /// <param name = "objPrjTabRelationTypeENS">源对象</param>
 /// <returns>目标对象=>clsPrjTabRelationTypeEN:objPrjTabRelationTypeENT</returns>
 public static clsPrjTabRelationTypeEN CopyTo(this clsPrjTabRelationTypeENEx objPrjTabRelationTypeENS)
{
try
{
 clsPrjTabRelationTypeEN objPrjTabRelationTypeENT = new clsPrjTabRelationTypeEN();
clsPrjTabRelationTypeBL.CopyTo(objPrjTabRelationTypeENS, objPrjTabRelationTypeENT);
 return objPrjTabRelationTypeENT;
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
 /// 工程表关系类型(PrjTabRelationType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsPrjTabRelationTypeBLEx : clsPrjTabRelationTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsPrjTabRelationTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsPrjTabRelationTypeDAEx PrjTabRelationTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsPrjTabRelationTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objPrjTabRelationTypeENS">源对象</param>
 /// <returns>目标对象=>clsPrjTabRelationTypeEN:objPrjTabRelationTypeENT</returns>
 public static clsPrjTabRelationTypeENEx CopyToEx(clsPrjTabRelationTypeEN objPrjTabRelationTypeENS)
{
try
{
 clsPrjTabRelationTypeENEx objPrjTabRelationTypeENT = new clsPrjTabRelationTypeENEx();
clsPrjTabRelationTypeBL.PrjTabRelationTypeDA.CopyTo(objPrjTabRelationTypeENS, objPrjTabRelationTypeENT);
 return objPrjTabRelationTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsPrjTabRelationTypeENEx> GetObjExLst(string strCondition)
{
List <clsPrjTabRelationTypeEN> arrObjLst = clsPrjTabRelationTypeBL.GetObjLst(strCondition);
List <clsPrjTabRelationTypeENEx> arrObjExLst = new List<clsPrjTabRelationTypeENEx>();
foreach (clsPrjTabRelationTypeEN objInFor in arrObjLst)
{
clsPrjTabRelationTypeENEx objPrjTabRelationTypeENEx = new clsPrjTabRelationTypeENEx();
clsPrjTabRelationTypeBL.CopyTo(objInFor, objPrjTabRelationTypeENEx);
arrObjExLst.Add(objPrjTabRelationTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strPrjTabRelaTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsPrjTabRelationTypeENEx GetObjExByPrjTabRelaTypeId(string strPrjTabRelaTypeId)
{
clsPrjTabRelationTypeEN objPrjTabRelationTypeEN = clsPrjTabRelationTypeBL.GetObjByPrjTabRelaTypeId(strPrjTabRelaTypeId);
clsPrjTabRelationTypeENEx objPrjTabRelationTypeENEx = new clsPrjTabRelationTypeENEx();
clsPrjTabRelationTypeBL.CopyTo(objPrjTabRelationTypeEN, objPrjTabRelationTypeENEx);
return objPrjTabRelationTypeENEx;
}
}
}