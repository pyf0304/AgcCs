
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCContainerTypeBLEx
 表名:GCContainerType(00050563)
 生成代码版本:2020.06.05.2
 生成日期:2020/06/09 01:07:17
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
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
public static class clsGCContainerTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objGCContainerTypeENS">源对象</param>
 /// <returns>目标对象=>clsGCContainerTypeEN:objGCContainerTypeENT</returns>
 public static clsGCContainerTypeENEx CopyToEx(this clsGCContainerTypeEN objGCContainerTypeENS)
{
try
{
 clsGCContainerTypeENEx objGCContainerTypeENT = new clsGCContainerTypeENEx();
clsGCContainerTypeBL.GCContainerTypeDA.CopyTo(objGCContainerTypeENS, objGCContainerTypeENT);
 return objGCContainerTypeENT;
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
 /// <param name = "objGCContainerTypeENS">源对象</param>
 /// <returns>目标对象=>clsGCContainerTypeEN:objGCContainerTypeENT</returns>
 public static clsGCContainerTypeEN CopyTo(this clsGCContainerTypeENEx objGCContainerTypeENS)
{
try
{
 clsGCContainerTypeEN objGCContainerTypeENT = new clsGCContainerTypeEN();
clsGCContainerTypeBL.CopyTo(objGCContainerTypeENS, objGCContainerTypeENT);
 return objGCContainerTypeENT;
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
 /// GC容器类型(GCContainerType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsGCContainerTypeBLEx : clsGCContainerTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsGCContainerTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsGCContainerTypeDAEx GCContainerTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsGCContainerTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objGCContainerTypeENS">源对象</param>
 /// <returns>目标对象=>clsGCContainerTypeEN:objGCContainerTypeENT</returns>
 public static clsGCContainerTypeENEx CopyToEx(clsGCContainerTypeEN objGCContainerTypeENS)
{
try
{
 clsGCContainerTypeENEx objGCContainerTypeENT = new clsGCContainerTypeENEx();
clsGCContainerTypeBL.GCContainerTypeDA.CopyTo(objGCContainerTypeENS, objGCContainerTypeENT);
 return objGCContainerTypeENT;
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
public static List<clsGCContainerTypeENEx> GetObjExLst(string strCondition)
{
List <clsGCContainerTypeEN> arrObjLst = clsGCContainerTypeBL.GetObjLst(strCondition);
List <clsGCContainerTypeENEx> arrObjExLst = new List<clsGCContainerTypeENEx>();
foreach (clsGCContainerTypeEN objInFor in arrObjLst)
{
clsGCContainerTypeENEx objGCContainerTypeENEx = new clsGCContainerTypeENEx();
clsGCContainerTypeBL.CopyTo(objInFor, objGCContainerTypeENEx);
arrObjExLst.Add(objGCContainerTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strContainerTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsGCContainerTypeENEx GetObjExByContainerTypeId(string strContainerTypeId)
{
clsGCContainerTypeEN objGCContainerTypeEN = clsGCContainerTypeBL.GetObjByContainerTypeId(strContainerTypeId);
clsGCContainerTypeENEx objGCContainerTypeENEx = new clsGCContainerTypeENEx();
clsGCContainerTypeBL.CopyTo(objGCContainerTypeEN, objGCContainerTypeENEx);
return objGCContainerTypeENEx;
}
}
}