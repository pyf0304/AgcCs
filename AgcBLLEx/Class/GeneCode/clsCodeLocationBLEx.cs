
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeLocationBLEx
 表名:CodeLocation(00050438)
 生成代码版本:2020.01.02.1
 生成日期:2020/01/02 16:05:21
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
public static class clsCodeLocationBLEx_Static
{

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx2(this clsCodeLocationEN objCodeLocationEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsCodeLocationBL.IsExist(objCodeLocationEN.CodeLocId))	//判断是否有相同的关键字
{
strMsg = "(errid:BlEx000004)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objCodeLocationEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objCodeLocationEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:BlEx000003)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCodeLocationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx2(this clsCodeLocationEN objCodeLocationEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCodeLocationEN.CheckPropertyNew();
//4、把数据实体层的数据存贮到数据库中
objCodeLocationEN.Update();
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
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_EditRecordEx)
 /// </summary>
 /// <param name = "objCodeLocation">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx2(this clsCodeLocationEN objCodeLocation)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCodeLocationEN objCodeLocation_Cond = new clsCodeLocationEN();
string strCondition = objCodeLocation_Cond
.SetCodeLocId(objCodeLocation.CodeLocId, "=")
.GetCombineCondition();
objCodeLocation._IsCheckProperty = true;
bool bolIsExist = clsCodeLocationBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCodeLocation.CodeLocId = clsCodeLocationBL.GetFirstID_S(strCondition);
objCodeLocation.UpdateWithCondition(strCondition);
}
else
{
objCodeLocation.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objCodeLocationENS">源对象</param>
 /// <returns>目标对象=>clsCodeLocationEN:objCodeLocationENT</returns>
 public static clsCodeLocationENEx CopyToEx(this clsCodeLocationEN objCodeLocationENS)
{
try
{
 clsCodeLocationENEx objCodeLocationENT = new clsCodeLocationENEx();
clsCodeLocationBL.CodeLocationDA.CopyTo(objCodeLocationENS, objCodeLocationENT);
 return objCodeLocationENT;
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
 /// <param name = "objCodeLocationENS">源对象</param>
 /// <returns>目标对象=>clsCodeLocationEN:objCodeLocationENT</returns>
 public static clsCodeLocationEN CopyTo(this clsCodeLocationENEx objCodeLocationENS)
{
try
{
 clsCodeLocationEN objCodeLocationENT = new clsCodeLocationEN();
clsCodeLocationBL.CopyTo(objCodeLocationENS, objCodeLocationENT);
 return objCodeLocationENT;
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
 /// 代码位置(CodeLocation)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsCodeLocationBLEx : clsCodeLocationBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsCodeLocationDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsCodeLocationDAEx CodeLocationDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsCodeLocationDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
/// </summary>
/// <param name="strCodeLocId">表关键字</param>
/// <returns></returns>
public new static bool DelRecordEx(string strCodeLocId)
{
clsSpecSQLforSql objSQL = null;
//获取连接对象
objSQL = clsCodeLocationDA.GetSpecSQLObj();
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
//删除与表:[CodeLocation]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCodeLocation.CodeLocId,
//strCodeLocId);
//        clsCodeLocationBL.DelCodeLocationsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCodeLocationBL.DelRecord(strCodeLocId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCodeLocationBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
objException.Message,
strCodeLocId, clsStackTrace.GetCurrClassFunction());
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
 /// 根据条件获取扩展对象列表
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回扩展对象列表</returns>
public static List<clsCodeLocationENEx> GetObjExLst(string strCondition)
{
List <clsCodeLocationEN> arrObjLst = clsCodeLocationBL.GetObjLst(strCondition);
List <clsCodeLocationENEx> arrObjExLst = new List<clsCodeLocationENEx>();
foreach (clsCodeLocationEN objInFor in arrObjLst)
{
clsCodeLocationENEx objCodeLocationENEx = new clsCodeLocationENEx();
clsCodeLocationBL.CopyTo(objInFor, objCodeLocationENEx);
arrObjExLst.Add(objCodeLocationENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strCodeLocId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsCodeLocationENEx GetObjExByCodeLocId(string strCodeLocId)
{
clsCodeLocationEN objCodeLocationEN = clsCodeLocationBL.GetObjByCodeLocId(strCodeLocId);
clsCodeLocationENEx objCodeLocationENEx = new clsCodeLocationENEx();
clsCodeLocationBL.CopyTo(objCodeLocationEN, objCodeLocationENEx);
return objCodeLocationENEx;
}
}
}