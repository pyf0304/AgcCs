
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFileResExcludePathBLEx
 表名:FileResExcludePath(00050588)
 生成代码版本:2021.06.20.1
 生成日期:2021/06/25 10:46:59
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:资源管理
 模块英文名:ResourceMan
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
public static class clsFileResExcludePathBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objFileResExcludePathENS">源对象</param>
 /// <returns>目标对象=>clsFileResExcludePathEN:objFileResExcludePathENT</returns>
 public static clsFileResExcludePathENEx CopyToEx(this clsFileResExcludePathEN objFileResExcludePathENS)
{
try
{
 clsFileResExcludePathENEx objFileResExcludePathENT = new clsFileResExcludePathENEx();
clsFileResExcludePathBL.FileResExcludePathDA.CopyTo(objFileResExcludePathENS, objFileResExcludePathENT);
 return objFileResExcludePathENT;
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
 /// <param name = "objFileResExcludePathENS">源对象</param>
 /// <returns>目标对象=>clsFileResExcludePathEN:objFileResExcludePathENT</returns>
 public static clsFileResExcludePathEN CopyTo(this clsFileResExcludePathENEx objFileResExcludePathENS)
{
try
{
 clsFileResExcludePathEN objFileResExcludePathENT = new clsFileResExcludePathEN();
clsFileResExcludePathBL.CopyTo(objFileResExcludePathENS, objFileResExcludePathENT);
 return objFileResExcludePathENT;
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
 /// 文件资源导入排除目录(FileResExcludePath)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsFileResExcludePathBLEx : clsFileResExcludePathBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsFileResExcludePathDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsFileResExcludePathDAEx FileResExcludePathDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsFileResExcludePathDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objFileResExcludePathENS">源对象</param>
 /// <returns>目标对象=>clsFileResExcludePathEN:objFileResExcludePathENT</returns>
 public static clsFileResExcludePathENEx CopyToEx(clsFileResExcludePathEN objFileResExcludePathENS)
{
try
{
 clsFileResExcludePathENEx objFileResExcludePathENT = new clsFileResExcludePathENEx();
clsFileResExcludePathBL.FileResExcludePathDA.CopyTo(objFileResExcludePathENS, objFileResExcludePathENT);
 return objFileResExcludePathENT;
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
public static List<clsFileResExcludePathENEx> GetObjExLst(string strCondition)
{
List <clsFileResExcludePathEN> arrObjLst = clsFileResExcludePathBL.GetObjLst(strCondition);
List <clsFileResExcludePathENEx> arrObjExLst = new List<clsFileResExcludePathENEx>();
foreach (clsFileResExcludePathEN objInFor in arrObjLst)
{
clsFileResExcludePathENEx objFileResExcludePathENEx = new clsFileResExcludePathENEx();
clsFileResExcludePathBL.CopyTo(objInFor, objFileResExcludePathENEx);
arrObjExLst.Add(objFileResExcludePathENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsFileResExcludePathENEx GetObjExBymId(long lngmId)
{
clsFileResExcludePathEN objFileResExcludePathEN = clsFileResExcludePathBL.GetObjBymId(lngmId);
clsFileResExcludePathENEx objFileResExcludePathENEx = new clsFileResExcludePathENEx();
clsFileResExcludePathBL.CopyTo(objFileResExcludePathEN, objFileResExcludePathENEx);
return objFileResExcludePathENEx;
}
}
}