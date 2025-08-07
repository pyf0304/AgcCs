
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsReferFileTypeBLEx
 表名:ReferFileType(00050473)
 生成代码版本:2019.05.17.1
 生成日期:2019/05/19 08:42:04
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码
 模块英文名:GeneCode
 框架-层名:业务逻辑扩展层(BusinessLogicEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
public static class clsReferFileTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objReferFileTypeENS">源对象</param>
 /// <returns>目标对象=>clsReferFileTypeEN:objReferFileTypeENT</returns>
 public static clsReferFileTypeENEx CopyToEx(this clsReferFileTypeEN objReferFileTypeENS)
{
try
{
 clsReferFileTypeENEx objReferFileTypeENT = new clsReferFileTypeENEx();
clsReferFileTypeBL.CopyTo(objReferFileTypeENS, objReferFileTypeENT);
 return objReferFileTypeENT;
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
 /// <param name = "objReferFileTypeENS">源对象</param>
 /// <returns>目标对象=>clsReferFileTypeEN:objReferFileTypeENT</returns>
 public static clsReferFileTypeEN CopyTo(this clsReferFileTypeENEx objReferFileTypeENS)
{
try
{
 clsReferFileTypeEN objReferFileTypeENT = new clsReferFileTypeEN();
clsReferFileTypeBL.CopyTo(objReferFileTypeENS, objReferFileTypeENT);
 return objReferFileTypeENT;
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
 /// 引用文件类型(ReferFileType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsReferFileTypeBLEx : clsReferFileTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsReferFileTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsReferFileTypeDAEx ReferFileTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsReferFileTypeDAEx();
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
public static List<clsReferFileTypeENEx> GetObjExLst(string strCondition)
{
List <clsReferFileTypeEN> arrObjLst = clsReferFileTypeBL.GetObjLst(strCondition);
List <clsReferFileTypeENEx> arrObjExLst = new List<clsReferFileTypeENEx>();
foreach (clsReferFileTypeEN objInFor in arrObjLst)
{
clsReferFileTypeENEx objReferFileTypeENEx = new clsReferFileTypeENEx();
clsReferFileTypeBL.CopyTo(objInFor, objReferFileTypeENEx);
arrObjExLst.Add(objReferFileTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strReferFileTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsReferFileTypeENEx GetObjExByReferFileTypeId(string strReferFileTypeId)
{
clsReferFileTypeEN objReferFileTypeEN = clsReferFileTypeBL.GetObjByReferFileTypeId(strReferFileTypeId);
clsReferFileTypeENEx objReferFileTypeENEx = new clsReferFileTypeENEx();
clsReferFileTypeBL.CopyTo(objReferFileTypeEN, objReferFileTypeENEx);
return objReferFileTypeENEx;
}
}
}