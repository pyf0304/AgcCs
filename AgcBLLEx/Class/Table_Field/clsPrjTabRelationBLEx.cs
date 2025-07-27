
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabRelationBLEx
 表名:PrjTabRelation(00050606)
 生成代码版本:2022.03.19.1
 生成日期:2022/03/22 02:39:54
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
public static class clsPrjTabRelationBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objPrjTabRelationENS">源对象</param>
 /// <returns>目标对象=>clsPrjTabRelationEN:objPrjTabRelationENT</returns>
 public static clsPrjTabRelationENEx CopyToEx(this clsPrjTabRelationEN objPrjTabRelationENS)
{
try
{
 clsPrjTabRelationENEx objPrjTabRelationENT = new clsPrjTabRelationENEx();
clsPrjTabRelationBL.PrjTabRelationDA.CopyTo(objPrjTabRelationENS, objPrjTabRelationENT);
 return objPrjTabRelationENT;
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
 /// <param name = "objPrjTabRelationENS">源对象</param>
 /// <returns>目标对象=>clsPrjTabRelationEN:objPrjTabRelationENT</returns>
 public static clsPrjTabRelationEN CopyTo(this clsPrjTabRelationENEx objPrjTabRelationENS)
{
try
{
 clsPrjTabRelationEN objPrjTabRelationENT = new clsPrjTabRelationEN();
clsPrjTabRelationBL.CopyTo(objPrjTabRelationENS, objPrjTabRelationENT);
 return objPrjTabRelationENT;
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
 /// 工程表关系(PrjTabRelation)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsPrjTabRelationBLEx : clsPrjTabRelationBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsPrjTabRelationDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsPrjTabRelationDAEx PrjTabRelationDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsPrjTabRelationDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objPrjTabRelationENS">源对象</param>
 /// <returns>目标对象=>clsPrjTabRelationEN:objPrjTabRelationENT</returns>
 public static clsPrjTabRelationENEx CopyToEx(clsPrjTabRelationEN objPrjTabRelationENS)
{
try
{
 clsPrjTabRelationENEx objPrjTabRelationENT = new clsPrjTabRelationENEx();
clsPrjTabRelationBL.PrjTabRelationDA.CopyTo(objPrjTabRelationENS, objPrjTabRelationENT);
 return objPrjTabRelationENT;
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
public static List<clsPrjTabRelationENEx> GetObjExLst(string strCondition)
{
List <clsPrjTabRelationEN> arrObjLst = clsPrjTabRelationBL.GetObjLst(strCondition);
List <clsPrjTabRelationENEx> arrObjExLst = new List<clsPrjTabRelationENEx>();
foreach (clsPrjTabRelationEN objInFor in arrObjLst)
{
clsPrjTabRelationENEx objPrjTabRelationENEx = new clsPrjTabRelationENEx();
clsPrjTabRelationBL.CopyTo(objInFor, objPrjTabRelationENEx);
arrObjExLst.Add(objPrjTabRelationENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strPrjRelationId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsPrjTabRelationENEx GetObjExByPrjRelationId(string strPrjRelationId)
{
clsPrjTabRelationEN objPrjTabRelationEN = clsPrjTabRelationBL.GetObjByPrjRelationId(strPrjRelationId);
clsPrjTabRelationENEx objPrjTabRelationENEx = new clsPrjTabRelationENEx();
clsPrjTabRelationBL.CopyTo(objPrjTabRelationEN, objPrjTabRelationENEx);
return objPrjTabRelationENEx;
}
}
}