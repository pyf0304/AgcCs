
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabMainTypeBLEx
 表名:TabMainType(00050534)
 生成代码版本:2020.02.16.1
 生成日期:2020/02/18 04:57:50
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:系统参数
 模块英文名:SysPara
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
public static class clsTabMainTypeBLEx_Static
{

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
 /// </summary>
 /// <param name = "objTabMainTypeENS">源对象</param>
 /// <returns>目标对象=>clsTabMainTypeEN:objTabMainTypeENT</returns>
 public static clsTabMainTypeEN CopyTo(this clsTabMainTypeENEx objTabMainTypeENS)
{
try
{
 clsTabMainTypeEN objTabMainTypeENT = new clsTabMainTypeEN();
clsTabMainTypeBL.CopyTo(objTabMainTypeENS, objTabMainTypeENT);
 return objTabMainTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objTabMainTypeENS">源对象</param>
 /// <returns>目标对象=>clsTabMainTypeEN:objTabMainTypeENT</returns>
 public static clsTabMainTypeENEx CopyToEx(this clsTabMainTypeEN objTabMainTypeENS)
{
try
{
 clsTabMainTypeENEx objTabMainTypeENT = new clsTabMainTypeENEx();
clsTabMainTypeBL.TabMainTypeDA.CopyTo(objTabMainTypeENS, objTabMainTypeENT);
 return objTabMainTypeENT;
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
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objTabMainTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx2(this clsTabMainTypeEN objTabMainTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objTabMainTypeEN.CheckPropertyNew();
clsTabMainTypeEN objTabMainType_Cond = new clsTabMainTypeEN();
string strCondition = objTabMainType_Cond
.SetTabMainTypeId(objTabMainTypeEN.TabMainTypeId, "=")
.GetCombineCondition();
objTabMainTypeEN._IsCheckProperty = true;
bool bolIsExist = clsTabMainTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objTabMainTypeEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objTabMainType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx2(this clsTabMainTypeEN objTabMainType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsTabMainTypeEN objTabMainType_Cond = new clsTabMainTypeEN();
string strCondition = objTabMainType_Cond
.SetTabMainTypeId(objTabMainType.TabMainTypeId, "=")
.GetCombineCondition();
objTabMainType._IsCheckProperty = true;
bool bolIsExist = clsTabMainTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objTabMainType.TabMainTypeId = clsTabMainTypeBL.GetFirstID_S(strCondition);
objTabMainType.UpdateWithCondition(strCondition);
}
else
{
objTabMainType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx2(this clsTabMainTypeEN objTabMainTypeEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsTabMainTypeBL.IsExist(objTabMainTypeEN.TabMainTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:BlEx000004)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objTabMainTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objTabMainTypeEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:BlEx000003)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}
}
 /// <summary>
 /// TabMainType(TabMainType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsTabMainTypeBLEx : clsTabMainTypeBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsTabMainTypeDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsTabMainTypeDAEx TabMainTypeDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsTabMainTypeDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
/// </summary>
/// <param name="strTabMainTypeId">表关键字</param>
/// <returns></returns>
public new static bool DelRecordEx(string strTabMainTypeId)
{
clsSpecSQLforSql objSQL = null;
//获取连接对象
objSQL = clsTabMainTypeDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[TabMainType]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTabMainType.TabMainTypeId,
//strTabMainTypeId);
//        clsTabMainTypeBL.DelTabMainTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTabMainTypeBL.DelRecord(strTabMainTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTabMainTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
objException.Message,
strTabMainTypeId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strTabMainTypeId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsTabMainTypeENEx GetObjExByTabMainTypeId(string strTabMainTypeId)
{
clsTabMainTypeEN objTabMainTypeEN = clsTabMainTypeBL.GetObjByTabMainTypeId(strTabMainTypeId);
clsTabMainTypeENEx objTabMainTypeENEx = new clsTabMainTypeENEx();
clsTabMainTypeBL.CopyTo(objTabMainTypeEN, objTabMainTypeENEx);
return objTabMainTypeENEx;
}

 /// <summary>
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsTabMainTypeENEx> GetObjExLst(string strCondition)
{
List <clsTabMainTypeEN> arrObjLst = clsTabMainTypeBL.GetObjLst(strCondition);
List <clsTabMainTypeENEx> arrObjExLst = new List<clsTabMainTypeENEx>();
foreach (clsTabMainTypeEN objInFor in arrObjLst)
{
clsTabMainTypeENEx objTabMainTypeENEx = new clsTabMainTypeENEx();
clsTabMainTypeBL.CopyTo(objInFor, objTabMainTypeENEx);
arrObjExLst.Add(objTabMainTypeENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
 /// </summary>
 /// <param name = "objTabMainTypeENS">源对象</param>
 /// <returns>目标对象=>clsTabMainTypeEN:objTabMainTypeENT</returns>
 public static clsTabMainTypeENEx CopyToEx(clsTabMainTypeEN objTabMainTypeENS)
{
try
{
 clsTabMainTypeENEx objTabMainTypeENT = new clsTabMainTypeENEx();
clsTabMainTypeBL.TabMainTypeDA.CopyTo(objTabMainTypeENS, objTabMainTypeENT);
 return objTabMainTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
}