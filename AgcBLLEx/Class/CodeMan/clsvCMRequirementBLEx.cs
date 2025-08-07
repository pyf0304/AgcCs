
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMRequirementBLEx
 表名:vCMRequirement(00050260)
 生成代码版本:2020.01.18.1
 生成日期:2020/01/19 09:54:35
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:代码管理
 模块英文名:CodeMan
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
public static class clsvCMRequirementBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvCMRequirementENS">源对象</param>
 /// <returns>目标对象=>clsvCMRequirementEN:objvCMRequirementENT</returns>
 public static clsvCMRequirementENEx CopyToEx(this clsvCMRequirementEN objvCMRequirementENS)
{
try
{
 clsvCMRequirementENEx objvCMRequirementENT = new clsvCMRequirementENEx();
clsvCMRequirementBL.vCMRequirementDA.CopyTo(objvCMRequirementENS, objvCMRequirementENT);
 return objvCMRequirementENT;
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
 /// <param name = "objvCMRequirementENS">源对象</param>
 /// <returns>目标对象=>clsvCMRequirementEN:objvCMRequirementENT</returns>
 public static clsvCMRequirementEN CopyTo(this clsvCMRequirementENEx objvCMRequirementENS)
{
try
{
 clsvCMRequirementEN objvCMRequirementENT = new clsvCMRequirementEN();
clsvCMRequirementBL.CopyTo(objvCMRequirementENS, objvCMRequirementENT);
 return objvCMRequirementENT;
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
 /// vCM需求(vCMRequirement)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvCMRequirementBLEx : clsvCMRequirementBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvCMRequirementDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvCMRequirementDAEx vCMRequirementDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvCMRequirementDAEx();
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
public static List<clsvCMRequirementENEx> GetObjExLst(string strCondition)
{
List <clsvCMRequirementEN> arrObjLst = clsvCMRequirementBL.GetObjLst(strCondition);
List <clsvCMRequirementENEx> arrObjExLst = new List<clsvCMRequirementENEx>();
foreach (clsvCMRequirementEN objInFor in arrObjLst)
{
clsvCMRequirementENEx objvCMRequirementENEx = new clsvCMRequirementENEx();
clsvCMRequirementBL.CopyTo(objInFor, objvCMRequirementENEx);
arrObjExLst.Add(objvCMRequirementENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strReqId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvCMRequirementENEx GetObjExByReqId(string strReqId)
{
clsvCMRequirementEN objvCMRequirementEN = clsvCMRequirementBL.GetObjByReqId(strReqId);
clsvCMRequirementENEx objvCMRequirementENEx = new clsvCMRequirementENEx();
clsvCMRequirementBL.CopyTo(objvCMRequirementEN, objvCMRequirementENEx);
return objvCMRequirementENEx;
}
}
}