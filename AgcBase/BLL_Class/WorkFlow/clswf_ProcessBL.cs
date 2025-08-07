
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clswf_ProcessBL
 表名:wf_Process(00050484)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class clswf_ProcessBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strProcessId">表关键字</param>
 /// <returns>表对象</returns>
public static clswf_ProcessEN GetObj(this K_ProcessId_wf_Process myKey)
{
clswf_ProcessEN objwf_ProcessEN = clswf_ProcessBL.wf_ProcessDA.GetObjByProcessId(myKey.Value);
return objwf_ProcessEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clswf_ProcessEN objwf_ProcessEN)
{
if (CheckUniqueness_ProcessName_PrjId(objwf_ProcessEN) == false)
{
var strMsg = string.Format("记录已经存在!过程名称 = [{0}],工程ID = [{1}]的数据已经存在!(in clswf_ProcessBL.AddNewRecord)", objwf_ProcessEN.ProcessName,objwf_ProcessEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objwf_ProcessEN.ProcessId) == true || clswf_ProcessBL.IsExist(objwf_ProcessEN.ProcessId) == true)
 {
     objwf_ProcessEN.ProcessId = clswf_ProcessBL.GetMaxStrId_S();
 }
bool bolResult = clswf_ProcessBL.wf_ProcessDA.AddNewRecordBySQL2(objwf_ProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_ProcessBL.ReFreshCache();

if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(objwf_ProcessEN.ProcessId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx(this clswf_ProcessEN objwf_ProcessEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键，不需要检查主键是否已经存在，在添加时，再获取 最大值作为主键
//if (clswf_ProcessBL.IsExist(objwf_ProcessEN.ProcessId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objwf_ProcessEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objwf_ProcessEN. CheckUniqueness_ProcessName_PrjId() == false)
{
strMsg = string.Format("(过程名称(ProcessName)=[{0}],工程ID(PrjId)=[{1}])已经存在，不能重复!", objwf_ProcessEN.ProcessName, objwf_ProcessEN.PrjId);
throw new Exception(strMsg);
}
//因为是字符型自增主键，所以在添加时，自动获取主键值。
 if (string.IsNullOrEmpty(objwf_ProcessEN.ProcessId) == true || clswf_ProcessBL.IsExist(objwf_ProcessEN.ProcessId) == true)
 {
     objwf_ProcessEN.ProcessId = clswf_ProcessBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objwf_ProcessEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clswf_ProcessEN objwf_ProcessEN)
{
if (CheckUniqueness_ProcessName_PrjId(objwf_ProcessEN) == false)
{
var strMsg = string.Format("记录已经存在!过程名称 = [{0}],工程ID = [{1}]的数据已经存在!(in clswf_ProcessBL.AddNewRecordWithMaxId)", objwf_ProcessEN.ProcessName,objwf_ProcessEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objwf_ProcessEN.ProcessId) == true || clswf_ProcessBL.IsExist(objwf_ProcessEN.ProcessId) == true)
 {
     objwf_ProcessEN.ProcessId = clswf_ProcessBL.GetMaxStrId_S();
 }
string strProcessId = clswf_ProcessBL.wf_ProcessDA.AddNewRecordBySQL2WithReturnKey(objwf_ProcessEN);
     objwf_ProcessEN.ProcessId = strProcessId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_ProcessBL.ReFreshCache();

if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(objwf_ProcessEN.ProcessId, "SetUpdDate");
}
return strProcessId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clswf_ProcessEN objwf_ProcessEN)
{
if (CheckUniqueness_ProcessName_PrjId(objwf_ProcessEN) == false)
{
var strMsg = string.Format("记录已经存在!过程名称 = [{0}],工程ID = [{1}]的数据已经存在!(in clswf_ProcessBL.AddNewRecordWithReturnKey)", objwf_ProcessEN.ProcessName,objwf_ProcessEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objwf_ProcessEN.ProcessId) == true || clswf_ProcessBL.IsExist(objwf_ProcessEN.ProcessId) == true)
 {
     objwf_ProcessEN.ProcessId = clswf_ProcessBL.GetMaxStrId_S();
 }
string strKey = clswf_ProcessBL.wf_ProcessDA.AddNewRecordBySQL2WithReturnKey(objwf_ProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_ProcessBL.ReFreshCache();

if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(objwf_ProcessEN.ProcessId, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_ProcessEN SetProcessId(this clswf_ProcessEN objwf_ProcessEN, string strProcessId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProcessId, 8, conwf_Process.ProcessId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProcessId, 8, conwf_Process.ProcessId);
}
objwf_ProcessEN.ProcessId = strProcessId; //过程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_ProcessEN.dicFldComparisonOp.ContainsKey(conwf_Process.ProcessId) == false)
{
objwf_ProcessEN.dicFldComparisonOp.Add(conwf_Process.ProcessId, strComparisonOp);
}
else
{
objwf_ProcessEN.dicFldComparisonOp[conwf_Process.ProcessId] = strComparisonOp;
}
}
return objwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_ProcessEN SetProcessName(this clswf_ProcessEN objwf_ProcessEN, string strProcessName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProcessName, conwf_Process.ProcessName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProcessName, 100, conwf_Process.ProcessName);
}
objwf_ProcessEN.ProcessName = strProcessName; //过程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_ProcessEN.dicFldComparisonOp.ContainsKey(conwf_Process.ProcessName) == false)
{
objwf_ProcessEN.dicFldComparisonOp.Add(conwf_Process.ProcessName, strComparisonOp);
}
else
{
objwf_ProcessEN.dicFldComparisonOp[conwf_Process.ProcessName] = strComparisonOp;
}
}
return objwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_ProcessEN SetPrjId(this clswf_ProcessEN objwf_ProcessEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conwf_Process.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conwf_Process.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conwf_Process.PrjId);
}
objwf_ProcessEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_ProcessEN.dicFldComparisonOp.ContainsKey(conwf_Process.PrjId) == false)
{
objwf_ProcessEN.dicFldComparisonOp.Add(conwf_Process.PrjId, strComparisonOp);
}
else
{
objwf_ProcessEN.dicFldComparisonOp[conwf_Process.PrjId] = strComparisonOp;
}
}
return objwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_ProcessEN SetEndPoint(this clswf_ProcessEN objwf_ProcessEN, string strEndPoint, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEndPoint, conwf_Process.EndPoint);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndPoint, 8, conwf_Process.EndPoint);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strEndPoint, 8, conwf_Process.EndPoint);
}
objwf_ProcessEN.EndPoint = strEndPoint; //终点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_ProcessEN.dicFldComparisonOp.ContainsKey(conwf_Process.EndPoint) == false)
{
objwf_ProcessEN.dicFldComparisonOp.Add(conwf_Process.EndPoint, strComparisonOp);
}
else
{
objwf_ProcessEN.dicFldComparisonOp[conwf_Process.EndPoint] = strComparisonOp;
}
}
return objwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_ProcessEN SetStartPoint(this clswf_ProcessEN objwf_ProcessEN, string strStartPoint, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStartPoint, conwf_Process.StartPoint);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStartPoint, 8, conwf_Process.StartPoint);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStartPoint, 8, conwf_Process.StartPoint);
}
objwf_ProcessEN.StartPoint = strStartPoint; //起点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_ProcessEN.dicFldComparisonOp.ContainsKey(conwf_Process.StartPoint) == false)
{
objwf_ProcessEN.dicFldComparisonOp.Add(conwf_Process.StartPoint, strComparisonOp);
}
else
{
objwf_ProcessEN.dicFldComparisonOp[conwf_Process.StartPoint] = strComparisonOp;
}
}
return objwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_ProcessEN SetWorkPage(this clswf_ProcessEN objwf_ProcessEN, string strWorkPage, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkPage, 500, conwf_Process.WorkPage);
}
objwf_ProcessEN.WorkPage = strWorkPage; //工作页面
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_ProcessEN.dicFldComparisonOp.ContainsKey(conwf_Process.WorkPage) == false)
{
objwf_ProcessEN.dicFldComparisonOp.Add(conwf_Process.WorkPage, strComparisonOp);
}
else
{
objwf_ProcessEN.dicFldComparisonOp[conwf_Process.WorkPage] = strComparisonOp;
}
}
return objwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_ProcessEN SetExamPhaseId(this clswf_ProcessEN objwf_ProcessEN, string strExamPhaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPhaseId, 2, conwf_Process.ExamPhaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamPhaseId, 2, conwf_Process.ExamPhaseId);
}
objwf_ProcessEN.ExamPhaseId = strExamPhaseId; //考核阶段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_ProcessEN.dicFldComparisonOp.ContainsKey(conwf_Process.ExamPhaseId) == false)
{
objwf_ProcessEN.dicFldComparisonOp.Add(conwf_Process.ExamPhaseId, strComparisonOp);
}
else
{
objwf_ProcessEN.dicFldComparisonOp[conwf_Process.ExamPhaseId] = strComparisonOp;
}
}
return objwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_ProcessEN SetDefaExamDepId(this clswf_ProcessEN objwf_ProcessEN, string strDefaExamDepId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaExamDepId, 6, conwf_Process.DefaExamDepId);
}
objwf_ProcessEN.DefaExamDepId = strDefaExamDepId; //默认考核部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_ProcessEN.dicFldComparisonOp.ContainsKey(conwf_Process.DefaExamDepId) == false)
{
objwf_ProcessEN.dicFldComparisonOp.Add(conwf_Process.DefaExamDepId, strComparisonOp);
}
else
{
objwf_ProcessEN.dicFldComparisonOp[conwf_Process.DefaExamDepId] = strComparisonOp;
}
}
return objwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_ProcessEN SetOrderNum(this clswf_ProcessEN objwf_ProcessEN, int intOrderNum, string strComparisonOp="")
	{
objwf_ProcessEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_ProcessEN.dicFldComparisonOp.ContainsKey(conwf_Process.OrderNum) == false)
{
objwf_ProcessEN.dicFldComparisonOp.Add(conwf_Process.OrderNum, strComparisonOp);
}
else
{
objwf_ProcessEN.dicFldComparisonOp[conwf_Process.OrderNum] = strComparisonOp;
}
}
return objwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_ProcessEN SetUpdDate(this clswf_ProcessEN objwf_ProcessEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conwf_Process.UpdDate);
}
objwf_ProcessEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_ProcessEN.dicFldComparisonOp.ContainsKey(conwf_Process.UpdDate) == false)
{
objwf_ProcessEN.dicFldComparisonOp.Add(conwf_Process.UpdDate, strComparisonOp);
}
else
{
objwf_ProcessEN.dicFldComparisonOp[conwf_Process.UpdDate] = strComparisonOp;
}
}
return objwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_ProcessEN SetUpdUser(this clswf_ProcessEN objwf_ProcessEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conwf_Process.UpdUser);
}
objwf_ProcessEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_ProcessEN.dicFldComparisonOp.ContainsKey(conwf_Process.UpdUser) == false)
{
objwf_ProcessEN.dicFldComparisonOp.Add(conwf_Process.UpdUser, strComparisonOp);
}
else
{
objwf_ProcessEN.dicFldComparisonOp[conwf_Process.UpdUser] = strComparisonOp;
}
}
return objwf_ProcessEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_ProcessEN SetMemo(this clswf_ProcessEN objwf_ProcessEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conwf_Process.Memo);
}
objwf_ProcessEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_ProcessEN.dicFldComparisonOp.ContainsKey(conwf_Process.Memo) == false)
{
objwf_ProcessEN.dicFldComparisonOp.Add(conwf_Process.Memo, strComparisonOp);
}
else
{
objwf_ProcessEN.dicFldComparisonOp[conwf_Process.Memo] = strComparisonOp;
}
}
return objwf_ProcessEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clswf_ProcessEN objwf_ProcessEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objwf_ProcessEN.CheckPropertyNew();
clswf_ProcessEN objwf_ProcessCond = new clswf_ProcessEN();
string strCondition = objwf_ProcessCond
.SetProcessId(objwf_ProcessEN.ProcessId, "<>")
.SetProcessName(objwf_ProcessEN.ProcessName, "=")
.SetPrjId(objwf_ProcessEN.PrjId, "=")
.GetCombineCondition();
objwf_ProcessEN._IsCheckProperty = true;
bool bolIsExist = clswf_ProcessBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ProcessName_PrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objwf_ProcessEN.Update();
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objwf_Process">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clswf_ProcessEN objwf_Process)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clswf_ProcessEN objwf_ProcessCond = new clswf_ProcessEN();
string strCondition = objwf_ProcessCond
.SetProcessName(objwf_Process.ProcessName, "=")
.SetPrjId(objwf_Process.PrjId, "=")
.GetCombineCondition();
objwf_Process._IsCheckProperty = true;
bool bolIsExist = clswf_ProcessBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objwf_Process.ProcessId = clswf_ProcessBL.GetFirstID_S(strCondition);
objwf_Process.UpdateWithCondition(strCondition);
}
else
{
objwf_Process.ProcessId = clswf_ProcessBL.GetMaxStrId_S();
objwf_Process.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clswf_ProcessEN objwf_ProcessEN)
{
 if (string.IsNullOrEmpty(objwf_ProcessEN.ProcessId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clswf_ProcessBL.wf_ProcessDA.UpdateBySql2(objwf_ProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_ProcessBL.ReFreshCache();

if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(objwf_ProcessEN.ProcessId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000083)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithTransaction)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clswf_ProcessEN objwf_ProcessEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objwf_ProcessEN.ProcessId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clswf_ProcessBL.wf_ProcessDA.UpdateBySql2(objwf_ProcessEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_ProcessBL.ReFreshCache();

if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(objwf_ProcessEN.ProcessId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000088)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clswf_ProcessEN objwf_ProcessEN, string strWhereCond)
{
try
{
bool bolResult = clswf_ProcessBL.wf_ProcessDA.UpdateBySqlWithCondition(objwf_ProcessEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_ProcessBL.ReFreshCache();

if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(objwf_ProcessEN.ProcessId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000089)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithConditionTransaction)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clswf_ProcessEN objwf_ProcessEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clswf_ProcessBL.wf_ProcessDA.UpdateBySqlWithConditionTransaction(objwf_ProcessEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_ProcessBL.ReFreshCache();

if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(objwf_ProcessEN.ProcessId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000090)根据条件修改记录出错!(带事务处理),{1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Delete)
 /// </summary>
 /// <param name = "strProcessId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clswf_ProcessEN objwf_ProcessEN)
{
try
{
int intRecNum = clswf_ProcessBL.wf_ProcessDA.DelRecord(objwf_ProcessEN.ProcessId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_ProcessBL.ReFreshCache();

if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(objwf_ProcessEN.ProcessId, "SetUpdDate");
}
return intRecNum;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000084)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objwf_ProcessENS">源对象</param>
 /// <param name = "objwf_ProcessENT">目标对象</param>
 public static void CopyTo(this clswf_ProcessEN objwf_ProcessENS, clswf_ProcessEN objwf_ProcessENT)
{
try
{
objwf_ProcessENT.ProcessId = objwf_ProcessENS.ProcessId; //过程ID
objwf_ProcessENT.ProcessName = objwf_ProcessENS.ProcessName; //过程名称
objwf_ProcessENT.PrjId = objwf_ProcessENS.PrjId; //工程ID
objwf_ProcessENT.EndPoint = objwf_ProcessENS.EndPoint; //终点
objwf_ProcessENT.StartPoint = objwf_ProcessENS.StartPoint; //起点
objwf_ProcessENT.WorkPage = objwf_ProcessENS.WorkPage; //工作页面
objwf_ProcessENT.ExamPhaseId = objwf_ProcessENS.ExamPhaseId; //考核阶段Id
objwf_ProcessENT.DefaExamDepId = objwf_ProcessENS.DefaExamDepId; //默认考核部门Id
objwf_ProcessENT.OrderNum = objwf_ProcessENS.OrderNum; //序号
objwf_ProcessENT.UpdDate = objwf_ProcessENS.UpdDate; //修改日期
objwf_ProcessENT.UpdUser = objwf_ProcessENS.UpdUser; //修改者
objwf_ProcessENT.Memo = objwf_ProcessENS.Memo; //说明
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objwf_ProcessENS">源对象</param>
 /// <returns>目标对象=>clswf_ProcessEN:objwf_ProcessENT</returns>
 public static clswf_ProcessEN CopyTo(this clswf_ProcessEN objwf_ProcessENS)
{
try
{
 clswf_ProcessEN objwf_ProcessENT = new clswf_ProcessEN()
{
ProcessId = objwf_ProcessENS.ProcessId, //过程ID
ProcessName = objwf_ProcessENS.ProcessName, //过程名称
PrjId = objwf_ProcessENS.PrjId, //工程ID
EndPoint = objwf_ProcessENS.EndPoint, //终点
StartPoint = objwf_ProcessENS.StartPoint, //起点
WorkPage = objwf_ProcessENS.WorkPage, //工作页面
ExamPhaseId = objwf_ProcessENS.ExamPhaseId, //考核阶段Id
DefaExamDepId = objwf_ProcessENS.DefaExamDepId, //默认考核部门Id
OrderNum = objwf_ProcessENS.OrderNum, //序号
UpdDate = objwf_ProcessENS.UpdDate, //修改日期
UpdUser = objwf_ProcessENS.UpdUser, //修改者
Memo = objwf_ProcessENS.Memo, //说明
};
 return objwf_ProcessENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(this clswf_ProcessEN objwf_ProcessEN)
{
 clswf_ProcessBL.wf_ProcessDA.CheckPropertyNew(objwf_ProcessEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clswf_ProcessEN objwf_ProcessEN)
{
 clswf_ProcessBL.wf_ProcessDA.CheckProperty4Condition(objwf_ProcessEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clswf_ProcessEN objwf_ProcessCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objwf_ProcessCond.IsUpdated(conwf_Process.ProcessId) == true)
{
string strComparisonOpProcessId = objwf_ProcessCond.dicFldComparisonOp[conwf_Process.ProcessId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Process.ProcessId, objwf_ProcessCond.ProcessId, strComparisonOpProcessId);
}
if (objwf_ProcessCond.IsUpdated(conwf_Process.ProcessName) == true)
{
string strComparisonOpProcessName = objwf_ProcessCond.dicFldComparisonOp[conwf_Process.ProcessName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Process.ProcessName, objwf_ProcessCond.ProcessName, strComparisonOpProcessName);
}
if (objwf_ProcessCond.IsUpdated(conwf_Process.PrjId) == true)
{
string strComparisonOpPrjId = objwf_ProcessCond.dicFldComparisonOp[conwf_Process.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Process.PrjId, objwf_ProcessCond.PrjId, strComparisonOpPrjId);
}
if (objwf_ProcessCond.IsUpdated(conwf_Process.EndPoint) == true)
{
string strComparisonOpEndPoint = objwf_ProcessCond.dicFldComparisonOp[conwf_Process.EndPoint];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Process.EndPoint, objwf_ProcessCond.EndPoint, strComparisonOpEndPoint);
}
if (objwf_ProcessCond.IsUpdated(conwf_Process.StartPoint) == true)
{
string strComparisonOpStartPoint = objwf_ProcessCond.dicFldComparisonOp[conwf_Process.StartPoint];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Process.StartPoint, objwf_ProcessCond.StartPoint, strComparisonOpStartPoint);
}
if (objwf_ProcessCond.IsUpdated(conwf_Process.WorkPage) == true)
{
string strComparisonOpWorkPage = objwf_ProcessCond.dicFldComparisonOp[conwf_Process.WorkPage];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Process.WorkPage, objwf_ProcessCond.WorkPage, strComparisonOpWorkPage);
}
if (objwf_ProcessCond.IsUpdated(conwf_Process.ExamPhaseId) == true)
{
string strComparisonOpExamPhaseId = objwf_ProcessCond.dicFldComparisonOp[conwf_Process.ExamPhaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Process.ExamPhaseId, objwf_ProcessCond.ExamPhaseId, strComparisonOpExamPhaseId);
}
if (objwf_ProcessCond.IsUpdated(conwf_Process.DefaExamDepId) == true)
{
string strComparisonOpDefaExamDepId = objwf_ProcessCond.dicFldComparisonOp[conwf_Process.DefaExamDepId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Process.DefaExamDepId, objwf_ProcessCond.DefaExamDepId, strComparisonOpDefaExamDepId);
}
if (objwf_ProcessCond.IsUpdated(conwf_Process.OrderNum) == true)
{
string strComparisonOpOrderNum = objwf_ProcessCond.dicFldComparisonOp[conwf_Process.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conwf_Process.OrderNum, objwf_ProcessCond.OrderNum, strComparisonOpOrderNum);
}
if (objwf_ProcessCond.IsUpdated(conwf_Process.UpdDate) == true)
{
string strComparisonOpUpdDate = objwf_ProcessCond.dicFldComparisonOp[conwf_Process.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Process.UpdDate, objwf_ProcessCond.UpdDate, strComparisonOpUpdDate);
}
if (objwf_ProcessCond.IsUpdated(conwf_Process.UpdUser) == true)
{
string strComparisonOpUpdUser = objwf_ProcessCond.dicFldComparisonOp[conwf_Process.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Process.UpdUser, objwf_ProcessCond.UpdUser, strComparisonOpUpdUser);
}
if (objwf_ProcessCond.IsUpdated(conwf_Process.Memo) == true)
{
string strComparisonOpMemo = objwf_ProcessCond.dicFldComparisonOp[conwf_Process.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_Process.Memo, objwf_ProcessCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--wf_Process(工作流过程), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objwf_ProcessEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness_ProcessName_PrjId(this clswf_ProcessEN objwf_ProcessEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objwf_ProcessEN == null) return true;
if (objwf_ProcessEN.ProcessId == null || objwf_ProcessEN.ProcessId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ProcessName = '{0}'", objwf_ProcessEN.ProcessName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objwf_ProcessEN.PrjId);
if (clswf_ProcessBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ProcessId !=  '{0}'", objwf_ProcessEN.ProcessId);
 sbCondition.AppendFormat(" and ProcessName = '{0}'", objwf_ProcessEN.ProcessName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objwf_ProcessEN.PrjId);
if (clswf_ProcessBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--wf_Process(工作流过程), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objwf_ProcessEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrProcessName_PrjId(this clswf_ProcessEN objwf_ProcessEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objwf_ProcessEN == null) return "";
if (objwf_ProcessEN.ProcessId == null || objwf_ProcessEN.ProcessId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ProcessName = '{0}'", objwf_ProcessEN.ProcessName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objwf_ProcessEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ProcessId !=  '{0}'", objwf_ProcessEN.ProcessId);
 sbCondition.AppendFormat(" and ProcessName = '{0}'", objwf_ProcessEN.ProcessName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objwf_ProcessEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_wf_Process
{
public virtual bool UpdRelaTabDate(string strProcessId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工作流过程(wf_Process)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clswf_ProcessBL
{
public static RelatedActions_wf_Process relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "wf_ProcessListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "wf_ProcessList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clswf_ProcessEN> arrwf_ProcessObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clswf_ProcessDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clswf_ProcessDA wf_ProcessDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clswf_ProcessDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clswf_ProcessBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clswf_ProcessEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clswf_ProcessEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = wf_ProcessDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = wf_ProcessDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = wf_ProcessDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_wf_Process(string strWhereCond)
{
DataTable objDT;
try
{
objDT = wf_ProcessDA.GetDataTable_wf_Process(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = wf_ProcessDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = wf_ProcessDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = wf_ProcessDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = wf_ProcessDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = wf_ProcessDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = wf_ProcessDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = wf_ProcessDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = wf_ProcessDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = wf_ProcessDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = wf_ProcessDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = wf_ProcessDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = wf_ProcessDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = wf_ProcessDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrProcessIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clswf_ProcessEN> GetObjLstByProcessIdLst(List<string> arrProcessIdLst)
{
List<clswf_ProcessEN> arrObjLst = new List<clswf_ProcessEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrProcessIdLst, true);
 string strWhereCond = string.Format("ProcessId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_ProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrProcessIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clswf_ProcessEN> GetObjLstByProcessIdLstCache(List<string> arrProcessIdLst)
{
string strKey = string.Format("{0}", clswf_ProcessEN._CurrTabName);
List<clswf_ProcessEN> arrwf_ProcessObjLstCache = GetObjLstCache();
IEnumerable <clswf_ProcessEN> arrwf_ProcessObjLst_Sel =
arrwf_ProcessObjLstCache
.Where(x => arrProcessIdLst.Contains(x.ProcessId));
return arrwf_ProcessObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_ProcessEN> GetObjLst(string strWhereCond)
{
List<clswf_ProcessEN> arrObjLst = new List<clswf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_ProcessEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_ProcessEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clswf_ProcessEN> arrObjLst = new List<clswf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_ProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objwf_ProcessCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clswf_ProcessEN> GetSubObjLstCache(clswf_ProcessEN objwf_ProcessCond)
{
List<clswf_ProcessEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clswf_ProcessEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conwf_Process.AttributeName)
{
if (objwf_ProcessCond.IsUpdated(strFldName) == false) continue;
if (objwf_ProcessCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_ProcessCond[strFldName].ToString());
}
else
{
if (objwf_ProcessCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objwf_ProcessCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_ProcessCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objwf_ProcessCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objwf_ProcessCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objwf_ProcessCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_ProcessEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clswf_ProcessEN> arrObjLst = new List<clswf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_ProcessEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_ProcessEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clswf_ProcessEN> arrObjLst = new List<clswf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_ProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clswf_ProcessEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clswf_ProcessEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_ProcessEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_ProcessEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clswf_ProcessEN> arrObjLst = new List<clswf_ProcessEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_ProcessEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_ProcessEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clswf_ProcessEN> arrObjLst = new List<clswf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_ProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clswf_ProcessEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clswf_ProcessEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clswf_ProcessEN> arrObjLst = new List<clswf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_ProcessEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_ProcessEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clswf_ProcessEN> arrObjLst = new List<clswf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_ProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clswf_ProcessEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clswf_ProcessEN objwf_ProcessCond, string strOrderBy)
{
List<clswf_ProcessEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clswf_ProcessEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conwf_Process.AttributeName)
{
if (objwf_ProcessCond.IsUpdated(strFldName) == false) continue;
if (objwf_ProcessCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_ProcessCond[strFldName].ToString());
}
else
{
if (objwf_ProcessCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objwf_ProcessCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_ProcessCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objwf_ProcessCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objwf_ProcessCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objwf_ProcessCond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLstSel = arrObjLstSel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLstSel = arrObjLstSel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLstSel = arrObjLstSel.Skip(intSkip).Take(intPageSize);
return arrObjLstSel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clswf_ProcessEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clswf_ProcessEN objwf_ProcessCond = JsonConvert.DeserializeObject<clswf_ProcessEN>(objPagerPara.whereCond);
if (objwf_ProcessCond.sfFldComparisonOp == null)
{
objwf_ProcessCond.dicFldComparisonOp = null;
}
else
{
objwf_ProcessCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objwf_ProcessCond.sfFldComparisonOp);
}
clswf_ProcessBL.SetUpdFlag(objwf_ProcessCond);
 try
{
CheckProperty4Condition(objwf_ProcessCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clswf_ProcessBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objwf_ProcessCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_ProcessEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_ProcessEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clswf_ProcessEN> arrObjLst = new List<clswf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_ProcessEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_ProcessEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clswf_ProcessEN> arrObjLst = new List<clswf_ProcessEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_ProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_ProcessEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clswf_ProcessEN> arrObjLst = new List<clswf_ProcessEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_ProcessEN.ProcessId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_ProcessEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objwf_ProcessEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getwf_Process(ref clswf_ProcessEN objwf_ProcessEN)
{
bool bolResult = wf_ProcessDA.Getwf_Process(ref objwf_ProcessEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strProcessId">表关键字</param>
 /// <returns>表对象</returns>
public static clswf_ProcessEN GetObjByProcessId(string strProcessId)
{
if (strProcessId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strProcessId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strProcessId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strProcessId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clswf_ProcessEN objwf_ProcessEN = wf_ProcessDA.GetObjByProcessId(strProcessId);
return objwf_ProcessEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clswf_ProcessEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clswf_ProcessEN objwf_ProcessEN = wf_ProcessDA.GetFirstObj(strWhereCond);
 return objwf_ProcessEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clswf_ProcessEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clswf_ProcessEN objwf_ProcessEN = wf_ProcessDA.GetObjByDataRow(objRow);
 return objwf_ProcessEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clswf_ProcessEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clswf_ProcessEN objwf_ProcessEN = wf_ProcessDA.GetObjByDataRow(objRow);
 return objwf_ProcessEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strProcessId">所给的关键字</param>
 /// <param name = "lstwf_ProcessObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clswf_ProcessEN GetObjByProcessIdFromList(string strProcessId, List<clswf_ProcessEN> lstwf_ProcessObjLst)
{
foreach (clswf_ProcessEN objwf_ProcessEN in lstwf_ProcessObjLst)
{
if (objwf_ProcessEN.ProcessId == strProcessId)
{
return objwf_ProcessEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxProcessId;
 try
 {
 strMaxProcessId = clswf_ProcessDA.GetMaxStrId();
 return strMaxProcessId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strProcessId;
 try
 {
 strProcessId = new clswf_ProcessDA().GetFirstID(strWhereCond);
 return strProcessId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = wf_ProcessDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = wf_ProcessDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strProcessId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strProcessId)
{
if (string.IsNullOrEmpty(strProcessId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strProcessId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = wf_ProcessDA.IsExist(strProcessId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clswf_ProcessDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = wf_ProcessDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 添加记录

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clswf_ProcessEN objwf_ProcessEN)
{
if (objwf_ProcessEN.CheckUniqueness_ProcessName_PrjId() == false)
{
var strMsg = string.Format("记录已经存在!过程名称 = [{0}],工程ID = [{1}]的数据已经存在!(in clswf_ProcessBL.AddNewRecordBySql2)", objwf_ProcessEN.ProcessName,objwf_ProcessEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objwf_ProcessEN.ProcessId) == true || clswf_ProcessBL.IsExist(objwf_ProcessEN.ProcessId) == true)
 {
     objwf_ProcessEN.ProcessId = clswf_ProcessBL.GetMaxStrId_S();
 }
bool bolResult = wf_ProcessDA.AddNewRecordBySQL2(objwf_ProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_ProcessBL.ReFreshCache();

if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(objwf_ProcessEN.ProcessId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clswf_ProcessEN objwf_ProcessEN)
{
if (objwf_ProcessEN.CheckUniqueness_ProcessName_PrjId() == false)
{
var strMsg = string.Format("记录已经存在!过程名称 = [{0}],工程ID = [{1}]的数据已经存在!(in clswf_ProcessBL.AddNewRecordBySql2WithReturnKey)", objwf_ProcessEN.ProcessName,objwf_ProcessEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objwf_ProcessEN.ProcessId) == true || clswf_ProcessBL.IsExist(objwf_ProcessEN.ProcessId) == true)
 {
     objwf_ProcessEN.ProcessId = clswf_ProcessBL.GetMaxStrId_S();
 }
string strKey = wf_ProcessDA.AddNewRecordBySQL2WithReturnKey(objwf_ProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_ProcessBL.ReFreshCache();

if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(objwf_ProcessEN.ProcessId, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000049)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,数据来源为代表实体对象的XML串
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、使用XML串来源来插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql_XML)
 /// </summary>
 /// <param name = "strwf_ProcessObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strwf_ProcessObjXml)
{
clswf_ProcessEN objwf_ProcessEN = GetObjFromXmlStr(strwf_ProcessObjXml);
try
{
bool bolResult = wf_ProcessDA.AddNewRecordBySQL2(objwf_ProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_ProcessBL.ReFreshCache();

if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(objwf_ProcessEN.ProcessId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000032)添加记录出错!(使用XML), {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 添加记录


 #region 修改记录

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Update)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clswf_ProcessEN objwf_ProcessEN)
{
try
{
bool bolResult = wf_ProcessDA.Update(objwf_ProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_ProcessBL.ReFreshCache();

if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(objwf_ProcessEN.ProcessId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000033)修改记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql2)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clswf_ProcessEN objwf_ProcessEN)
{
 if (string.IsNullOrEmpty(objwf_ProcessEN.ProcessId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = wf_ProcessDA.UpdateBySql2(objwf_ProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_ProcessBL.ReFreshCache();

if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(objwf_ProcessEN.ProcessId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000034)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql_XML)
 /// </summary>
 /// <param name = "strwf_ProcessObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strwf_ProcessObjXml)
{
clswf_ProcessEN objwf_ProcessEN = GetObjFromXmlStr(strwf_ProcessObjXml);
try
{
bool bolResult = wf_ProcessDA.UpdateBySql2(objwf_ProcessEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_ProcessBL.ReFreshCache();

if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(objwf_ProcessEN.ProcessId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000038)修改记录(UpdateBySql_XML)出错,{1}.!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 修改记录


 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
 /// </summary>
 /// <param name = "strProcessId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strProcessId)
{
try
{
 clswf_ProcessEN objwf_ProcessEN = clswf_ProcessBL.GetObjByProcessId(strProcessId);

if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(objwf_ProcessEN.ProcessId, "SetUpdDate");
}
if (objwf_ProcessEN != null)
{
int intRecNum = wf_ProcessDA.DelRecord(strProcessId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
            else
{
return 0;
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="strProcessId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strProcessId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clswf_ProcessDA.GetSpecSQLObj();
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
//删除与表:[wf_Process]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conwf_Process.ProcessId,
//strProcessId);
//        clswf_ProcessBL.Delwf_ProcesssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clswf_ProcessBL.DelRecord(strProcessId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clswf_ProcessBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strProcessId, clsStackTrace.GetCurrClassFunction());
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
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "strProcessId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strProcessId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(strProcessId, "UpdRelaTabDate");
}
bool bolResult = wf_ProcessDA.DelRecord(strProcessId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordBySP_S)
 /// </summary>
 /// <param name = "strProcessId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strProcessId) 
{
try
{
if (clswf_ProcessBL.relatedActions != null)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(strProcessId, "UpdRelaTabDate");
}
bool bolResult = wf_ProcessDA.DelRecordBySP(strProcessId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000041)通过存储过程删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrProcessIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delwf_Processs(List<string> arrProcessIdLst)
{
if (arrProcessIdLst.Count == 0) return 0;
try
{
if (clswf_ProcessBL.relatedActions != null)
{
foreach (var strProcessId in arrProcessIdLst)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(strProcessId, "UpdRelaTabDate");
}
}
int intDelRecNum = wf_ProcessDA.Delwf_Process(arrProcessIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intDelRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public static int Delwf_ProcesssByCond(string strWhereCond)
{
try
{
if (clswf_ProcessBL.relatedActions != null)
{
List<string> arrProcessId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strProcessId in arrProcessId)
{
clswf_ProcessBL.relatedActions.UpdRelaTabDate(strProcessId, "UpdRelaTabDate");
}
}
int intRecNum = wf_ProcessDA.Delwf_Process(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000043)删除带条件表记录出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
/// 这里仅仅是演示函数，使用时请复制到扩展类:[wf_Process]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strProcessId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strProcessId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clswf_ProcessDA.GetSpecSQLObj();
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
//删除与表:[wf_Process]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clswf_ProcessBL.DelRecord(strProcessId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clswf_ProcessBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strProcessId, clsStackTrace.GetCurrClassFunction());
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


 #endregion 删除记录


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objwf_ProcessENS">源对象</param>
 /// <param name = "objwf_ProcessENT">目标对象</param>
 public static void CopyTo(clswf_ProcessEN objwf_ProcessENS, clswf_ProcessEN objwf_ProcessENT)
{
try
{
objwf_ProcessENT.ProcessId = objwf_ProcessENS.ProcessId; //过程ID
objwf_ProcessENT.ProcessName = objwf_ProcessENS.ProcessName; //过程名称
objwf_ProcessENT.PrjId = objwf_ProcessENS.PrjId; //工程ID
objwf_ProcessENT.EndPoint = objwf_ProcessENS.EndPoint; //终点
objwf_ProcessENT.StartPoint = objwf_ProcessENS.StartPoint; //起点
objwf_ProcessENT.WorkPage = objwf_ProcessENS.WorkPage; //工作页面
objwf_ProcessENT.ExamPhaseId = objwf_ProcessENS.ExamPhaseId; //考核阶段Id
objwf_ProcessENT.DefaExamDepId = objwf_ProcessENS.DefaExamDepId; //默认考核部门Id
objwf_ProcessENT.OrderNum = objwf_ProcessENS.OrderNum; //序号
objwf_ProcessENT.UpdDate = objwf_ProcessENS.UpdDate; //修改日期
objwf_ProcessENT.UpdUser = objwf_ProcessENS.UpdUser; //修改者
objwf_ProcessENT.Memo = objwf_ProcessENS.Memo; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objwf_ProcessEN">源简化对象</param>
 public static void SetUpdFlag(clswf_ProcessEN objwf_ProcessEN)
{
try
{
objwf_ProcessEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objwf_ProcessEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conwf_Process.ProcessId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_ProcessEN.ProcessId = objwf_ProcessEN.ProcessId; //过程ID
}
if (arrFldSet.Contains(conwf_Process.ProcessName, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_ProcessEN.ProcessName = objwf_ProcessEN.ProcessName; //过程名称
}
if (arrFldSet.Contains(conwf_Process.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_ProcessEN.PrjId = objwf_ProcessEN.PrjId; //工程ID
}
if (arrFldSet.Contains(conwf_Process.EndPoint, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_ProcessEN.EndPoint = objwf_ProcessEN.EndPoint; //终点
}
if (arrFldSet.Contains(conwf_Process.StartPoint, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_ProcessEN.StartPoint = objwf_ProcessEN.StartPoint; //起点
}
if (arrFldSet.Contains(conwf_Process.WorkPage, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_ProcessEN.WorkPage = objwf_ProcessEN.WorkPage == "[null]" ? null :  objwf_ProcessEN.WorkPage; //工作页面
}
if (arrFldSet.Contains(conwf_Process.ExamPhaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_ProcessEN.ExamPhaseId = objwf_ProcessEN.ExamPhaseId == "[null]" ? null :  objwf_ProcessEN.ExamPhaseId; //考核阶段Id
}
if (arrFldSet.Contains(conwf_Process.DefaExamDepId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_ProcessEN.DefaExamDepId = objwf_ProcessEN.DefaExamDepId == "[null]" ? null :  objwf_ProcessEN.DefaExamDepId; //默认考核部门Id
}
if (arrFldSet.Contains(conwf_Process.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_ProcessEN.OrderNum = objwf_ProcessEN.OrderNum; //序号
}
if (arrFldSet.Contains(conwf_Process.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_ProcessEN.UpdDate = objwf_ProcessEN.UpdDate == "[null]" ? null :  objwf_ProcessEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conwf_Process.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_ProcessEN.UpdUser = objwf_ProcessEN.UpdUser == "[null]" ? null :  objwf_ProcessEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conwf_Process.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_ProcessEN.Memo = objwf_ProcessEN.Memo == "[null]" ? null :  objwf_ProcessEN.Memo; //说明
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objwf_ProcessEN">源简化对象</param>
 public static void AccessFldValueNull(clswf_ProcessEN objwf_ProcessEN)
{
try
{
if (objwf_ProcessEN.WorkPage == "[null]") objwf_ProcessEN.WorkPage = null; //工作页面
if (objwf_ProcessEN.ExamPhaseId == "[null]") objwf_ProcessEN.ExamPhaseId = null; //考核阶段Id
if (objwf_ProcessEN.DefaExamDepId == "[null]") objwf_ProcessEN.DefaExamDepId = null; //默认考核部门Id
if (objwf_ProcessEN.UpdDate == "[null]") objwf_ProcessEN.UpdDate = null; //修改日期
if (objwf_ProcessEN.UpdUser == "[null]") objwf_ProcessEN.UpdUser = null; //修改者
if (objwf_ProcessEN.Memo == "[null]") objwf_ProcessEN.Memo = null; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clswf_ProcessEN objwf_ProcessEN)
{
 wf_ProcessDA.CheckPropertyNew(objwf_ProcessEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clswf_ProcessEN objwf_ProcessEN)
{
 wf_ProcessDA.CheckProperty4Condition(objwf_ProcessEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_ProcessId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conwf_Process.ProcessId); 
List<clswf_ProcessEN> arrObjLst = clswf_ProcessBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN()
{
ProcessId = "0",
ProcessName = "选[工作流过程]..."
};
arrObjLst.Insert(0, objwf_ProcessEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conwf_Process.ProcessId;
objComboBox.DisplayMember = conwf_Process.ProcessName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdlProcessId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工作流过程]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conwf_Process.ProcessId); 
IEnumerable<clswf_ProcessEN> arrObjLst = clswf_ProcessBL.GetObjLst(strCondition);
objDDL.DataValueField = conwf_Process.ProcessId;
objDDL.DataTextField = conwf_Process.ProcessName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdlProcessIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工作流过程]...","0");
List<clswf_ProcessEN> arrwf_ProcessObjLst = GetAllwf_ProcessObjLstCache(); 
arrwf_ProcessObjLst = arrwf_ProcessObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conwf_Process.ProcessId;
objDDL.DataTextField = conwf_Process.ProcessName;
objDDL.DataSource = arrwf_ProcessObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clswf_ProcessBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_ProcessBL没有刷新缓存机制(clswf_ProcessBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ProcessId");
//if (arrwf_ProcessObjLstCache == null)
//{
//arrwf_ProcessObjLstCache = wf_ProcessDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strProcessId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clswf_ProcessEN GetObjByProcessIdCache(string strProcessId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clswf_ProcessEN._CurrTabName);
List<clswf_ProcessEN> arrwf_ProcessObjLstCache = GetObjLstCache();
IEnumerable <clswf_ProcessEN> arrwf_ProcessObjLst_Sel =
arrwf_ProcessObjLstCache
.Where(x=> x.ProcessId == strProcessId 
);
if (arrwf_ProcessObjLst_Sel.Count() == 0)
{
   clswf_ProcessEN obj = clswf_ProcessBL.GetObjByProcessId(strProcessId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrwf_ProcessObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strProcessId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetProcessNameByProcessIdCache(string strProcessId)
{
if (string.IsNullOrEmpty(strProcessId) == true) return "";
//获取缓存中的对象列表
clswf_ProcessEN objwf_Process = GetObjByProcessIdCache(strProcessId);
if (objwf_Process == null) return "";
return objwf_Process.ProcessName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strProcessId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByProcessIdCache(string strProcessId)
{
if (string.IsNullOrEmpty(strProcessId) == true) return "";
//获取缓存中的对象列表
clswf_ProcessEN objwf_Process = GetObjByProcessIdCache(strProcessId);
if (objwf_Process == null) return "";
return objwf_Process.ProcessName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clswf_ProcessEN> GetAllwf_ProcessObjLstCache()
{
//获取缓存中的对象列表
List<clswf_ProcessEN> arrwf_ProcessObjLstCache = GetObjLstCache(); 
return arrwf_ProcessObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clswf_ProcessEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clswf_ProcessEN._CurrTabName);
List<clswf_ProcessEN> arrwf_ProcessObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrwf_ProcessObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clswf_ProcessEN._CurrTabName);
CacheHelper.Remove(strKey);
}
else
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
}
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clswf_ProcessBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clswf_ProcessEN._CurrTabName);
CacheHelper.Remove(strKey);
clswf_ProcessBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--wf_Process(工作流过程)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objwf_ProcessEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrProcessName_PrjId(clswf_ProcessEN objwf_ProcessEN)
{
//检测记录是否存在
string strResult = wf_ProcessDA.GetUniCondStrProcessName_PrjId(objwf_ProcessEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstwf_ProcessObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clswf_ProcessEN> lstwf_ProcessObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstwf_ProcessObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstwf_ProcessObjLst">[clswf_ProcessEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clswf_ProcessEN> lstwf_ProcessObjLst, XmlWriter writer)
{
writer.WriteStartElement(clswf_ProcessBL.listXmlNode);
writer.WriteStartElement(clswf_ProcessBL.itemsXmlNode);
foreach (clswf_ProcessEN objwf_ProcessEN in lstwf_ProcessObjLst)
{
clswf_ProcessBL.SerializeXML(writer, objwf_ProcessEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objwf_ProcessEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clswf_ProcessEN objwf_ProcessEN)
{
writer.WriteStartElement(clswf_ProcessBL.itemXmlNode);
 
if (objwf_ProcessEN.ProcessId != null)
{
writer.WriteElementString(conwf_Process.ProcessId, objwf_ProcessEN.ProcessId.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_ProcessEN.ProcessName != null)
{
writer.WriteElementString(conwf_Process.ProcessName, objwf_ProcessEN.ProcessName.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_ProcessEN.PrjId != null)
{
writer.WriteElementString(conwf_Process.PrjId, objwf_ProcessEN.PrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_ProcessEN.EndPoint != null)
{
writer.WriteElementString(conwf_Process.EndPoint, objwf_ProcessEN.EndPoint.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_ProcessEN.StartPoint != null)
{
writer.WriteElementString(conwf_Process.StartPoint, objwf_ProcessEN.StartPoint.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_ProcessEN.WorkPage != null)
{
writer.WriteElementString(conwf_Process.WorkPage, objwf_ProcessEN.WorkPage.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_ProcessEN.ExamPhaseId != null)
{
writer.WriteElementString(conwf_Process.ExamPhaseId, objwf_ProcessEN.ExamPhaseId.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_ProcessEN.DefaExamDepId != null)
{
writer.WriteElementString(conwf_Process.DefaExamDepId, objwf_ProcessEN.DefaExamDepId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conwf_Process.OrderNum, objwf_ProcessEN.OrderNum.ToString());
 
if (objwf_ProcessEN.UpdDate != null)
{
writer.WriteElementString(conwf_Process.UpdDate, objwf_ProcessEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_ProcessEN.UpdUser != null)
{
writer.WriteElementString(conwf_Process.UpdUser, objwf_ProcessEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_ProcessEN.Memo != null)
{
writer.WriteElementString(conwf_Process.Memo, objwf_ProcessEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clswf_ProcessEN GetObjFromXml(System.Xml.XmlReader reader)
{
clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
reader.Read();
while (!(reader.Name == clswf_ProcessBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conwf_Process.ProcessId))
{
objwf_ProcessEN.ProcessId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_Process.ProcessName))
{
objwf_ProcessEN.ProcessName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_Process.PrjId))
{
objwf_ProcessEN.PrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_Process.EndPoint))
{
objwf_ProcessEN.EndPoint = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_Process.StartPoint))
{
objwf_ProcessEN.StartPoint = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_Process.WorkPage))
{
objwf_ProcessEN.WorkPage = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_Process.ExamPhaseId))
{
objwf_ProcessEN.ExamPhaseId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_Process.DefaExamDepId))
{
objwf_ProcessEN.DefaExamDepId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_Process.OrderNum))
{
objwf_ProcessEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conwf_Process.UpdDate))
{
objwf_ProcessEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_Process.UpdUser))
{
objwf_ProcessEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_Process.Memo))
{
objwf_ProcessEN.Memo = reader.ReadElementContentAsString();
}
}
return objwf_ProcessEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strwf_ProcessObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clswf_ProcessEN GetObjFromXmlStr(string strwf_ProcessObjXmlStr)
{
clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strwf_ProcessObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clswf_ProcessBL.itemXmlNode))
{
objwf_ProcessEN = GetObjFromXml(reader);
return objwf_ProcessEN;
}
}
return objwf_ProcessEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clswf_ProcessEN objwf_ProcessEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objwf_ProcessEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strProcessId)
{
if (strInFldName != conwf_Process.ProcessId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conwf_Process.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conwf_Process.AttributeName));
throw new Exception(strMsg);
}
var objwf_Process = clswf_ProcessBL.GetObjByProcessIdCache(strProcessId);
if (objwf_Process == null) return "";
return objwf_Process[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clswf_ProcessEN objwf_ProcessEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clswf_ProcessEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objwf_ProcessEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstwf_ProcessObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clswf_ProcessEN> lstwf_ProcessObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstwf_ProcessObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clswf_ProcessEN objwf_ProcessEN in lstwf_ProcessObjLst)
{
string strJSON_One = SerializeObjToJSON(objwf_ProcessEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clswf_ProcessDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clswf_ProcessDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clswf_ProcessDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clswf_ProcessDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objwf_ProcessCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clswf_ProcessEN objwf_ProcessCond)
{
List<clswf_ProcessEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clswf_ProcessEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conwf_Process.AttributeName)
{
if (objwf_ProcessCond.IsUpdated(strFldName) == false) continue;
if (objwf_ProcessCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_ProcessCond[strFldName].ToString());
}
else
{
if (objwf_ProcessCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objwf_ProcessCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_ProcessCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objwf_ProcessCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objwf_ProcessCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objwf_ProcessCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objwf_ProcessCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clswf_ProcessDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = wf_ProcessDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = wf_ProcessDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = wf_ProcessDA.SetFldValue(strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}


 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "fltValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clswf_ProcessDA.SetFldValue(clswf_ProcessEN._CurrTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "intValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = wf_ProcessDA.SetFldValue( strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = clswf_ProcessDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = clswf_ProcessDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clswf_ProcessDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}



 #endregion 表操作常用函数


 #region 表操作

 /// <summary>
 /// 功能:获取建立表的代码
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GenSQLCode4CreateTab)
 /// </summary>
 /// <returns>建立表的代码</returns>
public static string GetCode4CreateTable() 
{
 StringBuilder strCreateTabCode = new StringBuilder();
  strCreateTabCode.Append("CREATE table [dbo].[wf_Process] "); 
 strCreateTabCode.Append(" ( "); 
 // /**过程ID*/ 
 strCreateTabCode.Append(" ProcessId char(8) primary key, "); 
 // /**过程名称*/ 
 strCreateTabCode.Append(" ProcessName varchar(100) not Null, "); 
 // /**工程ID*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**终点*/ 
 strCreateTabCode.Append(" EndPoint char(8) not Null, "); 
 // /**起点*/ 
 strCreateTabCode.Append(" StartPoint char(8) not Null, "); 
 // /**工作页面*/ 
 strCreateTabCode.Append(" WorkPage varchar(500) Null, "); 
 // /**考核阶段Id*/ 
 strCreateTabCode.Append(" ExamPhaseId char(2) Null, "); 
 // /**默认考核部门Id*/ 
 strCreateTabCode.Append(" DefaExamDepId varchar(6) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 数据同步


 #endregion 数据同步


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：PrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strPrjId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strPrjId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conwf_Process.PrjId, strPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clswf_ProcessEN> arrwf_ProcessObjList = new clswf_ProcessDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clswf_ProcessEN objwf_Process in arrwf_ProcessObjList)
{
objwf_Process.OrderNum = intIndex;
UpdateBySql2(objwf_Process);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。根据分类字段：PrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strProcessId">所给的关键字</param>
/// <param name="strPrjId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strProcessId, string strPrjId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[ProcessId]，获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号，就退出；
//   3.1、如果是向下移动，判断当前序号是否“小于”当前表中的字段数，
//	   即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
//   3.2、如果是向上移动，就判断当前序号是否“大于”1，
//	   即不是第一条记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字ProcessId
//5、把当前关键字ProcessId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字ProcessId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevProcessId = "";    //上一条序号的关键字ProcessId
string strNextProcessId = "";    //下一条序号的关键字ProcessId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[ProcessId]，获取相应的序号[OrderNum]。

clswf_ProcessEN objwf_Process = clswf_ProcessBL.GetObjByProcessId(strProcessId);

intOrderNum = objwf_Process.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号，
//		3.1 如果是末端序号，就退出，

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conwf_Process.PrjId, strPrjId);
intTabRecNum = clswf_ProcessBL.GetRecCountByCond(clswf_ProcessEN._CurrTabName, strCondition);    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号，就退出；
//  3.2、如果是向上移动，就判断当前序号是否“大于”1，
//	     即不是第一条记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录，不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
//		    即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
//		    如果是向上移动，就判断当前序号是否“大于”1，
//		    即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
sbCondition.AppendFormat(" {0} = {1} ", conwf_Process.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conwf_Process.PrjId, strPrjId);
//4、获取上一个序号字段的关键字ProcessId
strPrevProcessId = clswf_ProcessBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevProcessId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字ProcessId所对应记录的序号减1
//6、把下(上)一个序号关键字ProcessId所对应的记录序号加1
clswf_ProcessBL.SetFldValue(clswf_ProcessEN._CurrTabName, conwf_Process.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conwf_Process.ProcessId, strProcessId));
clswf_ProcessBL.SetFldValue(clswf_ProcessEN._CurrTabName, conwf_Process.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conwf_Process.ProcessId, strPrevProcessId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号，就退出；
//   3.1、如果是向下移动，判断当前序号是否“小于”当前表中的字段数，
//	   即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录，不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字ProcessId
sbCondition.AppendFormat(" {0} = {1} ", conwf_Process.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conwf_Process.PrjId, strPrjId);

strNextProcessId = clswf_ProcessBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextProcessId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字ProcessId所对应记录的序号加1
//6、把下(上)一个序号关键字ProcessId所对应的记录序号减1
clswf_ProcessBL.SetFldValue(clswf_ProcessEN._CurrTabName, conwf_Process.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conwf_Process.ProcessId, strProcessId));
clswf_ProcessBL.SetFldValue(clswf_ProcessEN._CurrTabName, conwf_Process.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conwf_Process.ProcessId, strNextProcessId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错！错误:[{0}]({1})",
 	 	objException.Message,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：PrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId, string strPrjId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conwf_Process.ProcessId, strKeyList);
List<clswf_ProcessEN> arrwf_ProcessLst = GetObjLst(strCondition);
foreach (clswf_ProcessEN objwf_Process in arrwf_ProcessLst)
{
objwf_Process.OrderNum = objwf_Process.OrderNum + 10000;
UpdateBySql2(objwf_Process);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conwf_Process.PrjId, strPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clswf_ProcessEN> arrwf_ProcessObjList = new clswf_ProcessDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clswf_ProcessEN objwf_Process in arrwf_ProcessObjList)
{
objwf_Process.OrderNum = intIndex;
UpdateBySql2(objwf_Process);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：PrjId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strPrjId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId, string strPrjId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conwf_Process.ProcessId, strKeyList);
List<clswf_ProcessEN> arrwf_ProcessLst = GetObjLst(strCondition);
foreach (clswf_ProcessEN objwf_Process in arrwf_ProcessLst)
{
objwf_Process.OrderNum = objwf_Process.OrderNum - 10000;
UpdateBySql2(objwf_Process);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conwf_Process.PrjId, strPrjId);
 strCondition += string.Format(" order by OrderNum ");
List<clswf_ProcessEN> arrwf_ProcessObjList = new clswf_ProcessDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clswf_ProcessEN objwf_Process in arrwf_ProcessObjList)
{
objwf_Process.OrderNum = intIndex;
UpdateBySql2(objwf_Process);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 工作流过程(wf_Process)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4wf_Process : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_ProcessBL.ReFreshThisCache();
}
}

}