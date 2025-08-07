
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvwf_WorkFlowBLEx
 表名:vwf_WorkFlow(00050490)
 生成代码版本:2019.10.18.1
 生成日期:2019/10/20 01:31:18
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理
 模块英文名:WorkFlow
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
public static class clsvwf_WorkFlowBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objvwf_WorkFlowENS">源对象</param>
 /// <returns>目标对象=>clsvwf_WorkFlowEN:objvwf_WorkFlowENT</returns>
 public static clsvwf_WorkFlowENEx CopyToEx(this clsvwf_WorkFlowEN objvwf_WorkFlowENS)
{
try
{
 clsvwf_WorkFlowENEx objvwf_WorkFlowENT = new clsvwf_WorkFlowENEx();
clsvwf_WorkFlowBL.CopyTo(objvwf_WorkFlowENS, objvwf_WorkFlowENT);
 return objvwf_WorkFlowENT;
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
 /// <param name = "objvwf_WorkFlowENS">源对象</param>
 /// <returns>目标对象=>clsvwf_WorkFlowEN:objvwf_WorkFlowENT</returns>
 public static clsvwf_WorkFlowEN CopyTo(this clsvwf_WorkFlowENEx objvwf_WorkFlowENS)
{
try
{
 clsvwf_WorkFlowEN objvwf_WorkFlowENT = new clsvwf_WorkFlowEN();
clsvwf_WorkFlowBL.CopyTo(objvwf_WorkFlowENS, objvwf_WorkFlowENT);
 return objvwf_WorkFlowENT;
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
 /// v工作流(vwf_WorkFlow)
 /// 数据源类型:SQL视图
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsvwf_WorkFlowBLEx : clsvwf_WorkFlowBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsvwf_WorkFlowDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsvwf_WorkFlowDAEx vwf_WorkFlowDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsvwf_WorkFlowDAEx();
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
public static List<clsvwf_WorkFlowENEx> GetObjExLst(string strCondition)
{
List <clsvwf_WorkFlowEN> arrObjLst = clsvwf_WorkFlowBL.GetObjLst(strCondition);
List <clsvwf_WorkFlowENEx> arrObjExLst = new List<clsvwf_WorkFlowENEx>();
foreach (clsvwf_WorkFlowEN objInFor in arrObjLst)
{
clsvwf_WorkFlowENEx objvwf_WorkFlowENEx = new clsvwf_WorkFlowENEx();
clsvwf_WorkFlowBL.CopyTo(objInFor, objvwf_WorkFlowENEx);
arrObjExLst.Add(objvwf_WorkFlowENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strWorkFlowId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsvwf_WorkFlowENEx GetObjExByWorkFlowId(string strWorkFlowId)
{
clsvwf_WorkFlowEN objvwf_WorkFlowEN = clsvwf_WorkFlowBL.GetObjByWorkFlowId(strWorkFlowId);
clsvwf_WorkFlowENEx objvwf_WorkFlowENEx = new clsvwf_WorkFlowENEx();
clsvwf_WorkFlowBL.CopyTo(objvwf_WorkFlowEN, objvwf_WorkFlowENEx);
return objvwf_WorkFlowENEx;
}
}
}