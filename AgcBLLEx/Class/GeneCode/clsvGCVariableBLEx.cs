
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvGCVariableBLEx
 表名:vGCVariable(00050561)
 生成代码版本:2021.11.08.01
 生成日期:2020/06/04 11:01:37
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
public static class clsvGCVariableBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvGCVariableENS">源对象</param>
 /// <returns>目标对象=>clsvGCVariableEN:objvGCVariableENT</returns>
 public static clsvGCVariableENEx CopyToEx(this clsvGCVariableEN objvGCVariableENS)
{
try
{
 clsvGCVariableENEx objvGCVariableENT = new clsvGCVariableENEx();
clsvGCVariableBL.vGCVariableDA.CopyTo(objvGCVariableENS, objvGCVariableENT);
 return objvGCVariableENT;
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
 /// <param name = "objvGCVariableENS">源对象</param>
 /// <returns>目标对象=>clsvGCVariableEN:objvGCVariableENT</returns>
 public static clsvGCVariableEN CopyTo(this clsvGCVariableENEx objvGCVariableENS)
{
try
{
 clsvGCVariableEN objvGCVariableENT = new clsvGCVariableEN();
clsvGCVariableBL.CopyTo(objvGCVariableENS, objvGCVariableENT);
 return objvGCVariableENT;
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
 /// vGCVariable(vGCVariable)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvGCVariableBLEx : clsvGCVariableBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvGCVariableDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvGCVariableDAEx vGCVariableDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvGCVariableDAEx();
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
public static List<clsvGCVariableENEx> GetObjExLst(string strCondition)
{
List <clsvGCVariableEN> arrObjLst = clsvGCVariableBL.GetObjLst(strCondition);
List <clsvGCVariableENEx> arrObjExLst = new List<clsvGCVariableENEx>();
foreach (clsvGCVariableEN objInFor in arrObjLst)
{
clsvGCVariableENEx objvGCVariableENEx = new clsvGCVariableENEx();
clsvGCVariableBL.CopyTo(objInFor, objvGCVariableENEx);
arrObjExLst.Add(objvGCVariableENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strVarId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvGCVariableENEx GetObjExByVarId(string strVarId)
{
clsvGCVariableEN objvGCVariableEN = clsvGCVariableBL.GetObjByVarId(strVarId);
clsvGCVariableENEx objvGCVariableENEx = new clsvGCVariableENEx();
clsvGCVariableBL.CopyTo(objvGCVariableEN, objvGCVariableENEx);
return objvGCVariableENEx;
}
}
}