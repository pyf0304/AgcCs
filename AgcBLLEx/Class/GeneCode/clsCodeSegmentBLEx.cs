
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeSegmentBLEx
 表名:CodeSegment(00050436)
 生成代码版本:2020.01.02.1
 生成日期:2020/01/02 16:05:55
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
public static class clsCodeSegmentBLEx_Static
{

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx2(this clsCodeSegmentEN objCodeSegmentEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsCodeSegmentBL.IsExist(objCodeSegmentEN.CodeSegmentId))	//判断是否有相同的关键字
{
strMsg = "(errid:BlEx000004)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objCodeSegmentEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objCodeSegmentEN.AddNewRecord();
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
 /// <param name = "objCodeSegmentEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx2(this clsCodeSegmentEN objCodeSegmentEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCodeSegmentEN.CheckPropertyNew();
//4、把数据实体层的数据存贮到数据库中
objCodeSegmentEN.Update();
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
 /// <param name = "objCodeSegment">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx2(this clsCodeSegmentEN objCodeSegment)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCodeSegmentEN objCodeSegment_Cond = new clsCodeSegmentEN();
string strCondition = objCodeSegment_Cond
.SetCodeSegmentId(objCodeSegment.CodeSegmentId, "=")
.GetCombineCondition();
objCodeSegment._IsCheckProperty = true;
bool bolIsExist = clsCodeSegmentBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCodeSegment.CodeSegmentId = clsCodeSegmentBL.GetFirstID_S(strCondition);
objCodeSegment.UpdateWithCondition(strCondition);
}
else
{
objCodeSegment.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
 /// </summary>
 /// <param name = "objCodeSegmentENS">源对象</param>
 /// <returns>目标对象=>clsCodeSegmentEN:objCodeSegmentENT</returns>
 public static clsCodeSegmentENEx CopyToEx(this clsCodeSegmentEN objCodeSegmentENS)
{
try
{
 clsCodeSegmentENEx objCodeSegmentENT = new clsCodeSegmentENEx();
clsCodeSegmentBL.CodeSegmentDA.CopyTo(objCodeSegmentENS, objCodeSegmentENT);
 return objCodeSegmentENT;
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
 /// <param name = "objCodeSegmentENS">源对象</param>
 /// <returns>目标对象=>clsCodeSegmentEN:objCodeSegmentENT</returns>
 public static clsCodeSegmentEN CopyTo(this clsCodeSegmentENEx objCodeSegmentENS)
{
try
{
 clsCodeSegmentEN objCodeSegmentENT = new clsCodeSegmentEN();
clsCodeSegmentBL.CopyTo(objCodeSegmentENS, objCodeSegmentENT);
 return objCodeSegmentENT;
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
 /// 代码段(CodeSegment)
 /// 数据源类型:SQL表
 /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
 /// </summary>
public partial class clsCodeSegmentBLEx : clsCodeSegmentBL
{

 /// <summary>
/// 单例模式:访问数据访问扩展层的单例模式
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
/// </summary>
private static clsCodeSegmentDAEx uniqueInstanceEx = null;
/// <summary>
/// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
/// </summary>
private static clsCodeSegmentDAEx CodeSegmentDAEx
{
    get
{
if (uniqueInstanceEx == null)
{
uniqueInstanceEx = new clsCodeSegmentDAEx();
}
return uniqueInstanceEx;
}
}

 /// <summary>
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
/// </summary>
/// <param name="strCodeSegmentId">表关键字</param>
/// <returns></returns>
public new static bool DelRecordEx(string strCodeSegmentId)
{
clsSpecSQLforSql objSQL = null;
//获取连接对象
objSQL = clsCodeSegmentDA.GetSpecSQLObj();
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
//删除与表:[CodeSegment]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCodeSegment.CodeSegmentId,
//strCodeSegmentId);
//        clsCodeSegmentBL.DelCodeSegmentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCodeSegmentBL.DelRecord(strCodeSegmentId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCodeSegmentBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
objException.Message,
strCodeSegmentId, clsStackTrace.GetCurrClassFunction());
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
public static List<clsCodeSegmentENEx> GetObjExLst(string strCondition)
{
List <clsCodeSegmentEN> arrObjLst = clsCodeSegmentBL.GetObjLst(strCondition);
List <clsCodeSegmentENEx> arrObjExLst = new List<clsCodeSegmentENEx>();
foreach (clsCodeSegmentEN objInFor in arrObjLst)
{
clsCodeSegmentENEx objCodeSegmentENEx = new clsCodeSegmentENEx();
clsCodeSegmentBL.CopyTo(objInFor, objCodeSegmentENEx);
arrObjExLst.Add(objCodeSegmentENEx);
}
return arrObjExLst;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用扩展对象的形式表示.
 /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
 /// </summary>
 /// <param name = "strCodeSegmentId">表关键字</param>
 /// <returns>表扩展对象</returns>
public static clsCodeSegmentENEx GetObjExByCodeSegmentId(string strCodeSegmentId)
{
clsCodeSegmentEN objCodeSegmentEN = clsCodeSegmentBL.GetObjByCodeSegmentId(strCodeSegmentId);
clsCodeSegmentENEx objCodeSegmentENEx = new clsCodeSegmentENEx();
clsCodeSegmentBL.CopyTo(objCodeSegmentEN, objCodeSegmentENEx);
return objCodeSegmentENEx;
}
}
}