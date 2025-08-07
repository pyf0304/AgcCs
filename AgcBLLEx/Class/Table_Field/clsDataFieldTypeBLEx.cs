
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataFieldTypeBLEx
 表名:DataFieldType(00050596)
 生成代码版本:2021.10.24.1
 生成日期:2021/10/27 15:41:11
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护
 模块英文名:Table_Field
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
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
public static class clsDataFieldTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objDataFieldTypeENS">源对象</param>
 /// <returns>目标对象=>clsDataFieldTypeEN:objDataFieldTypeENT</returns>
 public static clsDataFieldTypeENEx CopyToEx(this clsDataFieldTypeEN objDataFieldTypeENS)
{
try
{
 clsDataFieldTypeENEx objDataFieldTypeENT = new clsDataFieldTypeENEx();
clsDataFieldTypeBL.DataFieldTypeDA.CopyTo(objDataFieldTypeENS, objDataFieldTypeENT);
 return objDataFieldTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objDataFieldTypeENS">源对象</param>
 /// <returns>目标对象=>clsDataFieldTypeEN:objDataFieldTypeENT</returns>
 public static clsDataFieldTypeEN CopyTo(this clsDataFieldTypeENEx objDataFieldTypeENS)
{
try
{
 clsDataFieldTypeEN objDataFieldTypeENT = new clsDataFieldTypeEN();
clsDataFieldTypeBL.CopyTo(objDataFieldTypeENS, objDataFieldTypeENT);
 return objDataFieldTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 数据字段类型(DataFieldType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsDataFieldTypeBLEx : clsDataFieldTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsDataFieldTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsDataFieldTypeDAEx DataFieldTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsDataFieldTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objDataFieldTypeENS">源对象</param>
 /// <returns>目标对象=>clsDataFieldTypeEN:objDataFieldTypeENT</returns>
 public static clsDataFieldTypeENEx CopyToEx(clsDataFieldTypeEN objDataFieldTypeENS)
{
try
{
 clsDataFieldTypeENEx objDataFieldTypeENT = new clsDataFieldTypeENEx();
clsDataFieldTypeBL.DataFieldTypeDA.CopyTo(objDataFieldTypeENS, objDataFieldTypeENT);
 return objDataFieldTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
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
public static List<clsDataFieldTypeENEx> GetObjExLst(string strCondition)
{
List <clsDataFieldTypeEN> arrObjLst = clsDataFieldTypeBL.GetObjLst(strCondition);
List <clsDataFieldTypeENEx> arrObjExLst = new List<clsDataFieldTypeENEx>();
foreach (clsDataFieldTypeEN objInFor in arrObjLst)
{
clsDataFieldTypeENEx objDataFieldTypeENEx = new clsDataFieldTypeENEx();
clsDataFieldTypeBL.CopyTo(objInFor, objDataFieldTypeENEx);
arrObjExLst.Add(objDataFieldTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strDataFieldTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsDataFieldTypeENEx GetObjExByDataFieldTypeId(string strDataFieldTypeId)
{
clsDataFieldTypeEN objDataFieldTypeEN = clsDataFieldTypeBL.GetObjByDataFieldTypeId(strDataFieldTypeId);
clsDataFieldTypeENEx objDataFieldTypeENEx = new clsDataFieldTypeENEx();
clsDataFieldTypeBL.CopyTo(objDataFieldTypeEN, objDataFieldTypeENEx);
return objDataFieldTypeENEx;
}
}
}