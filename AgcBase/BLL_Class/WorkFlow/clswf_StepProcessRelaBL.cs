
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clswf_StepProcessRelaBL
 表名:wf_StepProcessRela(00050493)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:19:11
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
public static class clswf_StepProcessRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngWorkFlowStepProcessRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clswf_StepProcessRelaEN GetObj(this K_WorkFlowStepProcessRelaId_wf_StepProcessRela myKey)
{
clswf_StepProcessRelaEN objwf_StepProcessRelaEN = clswf_StepProcessRelaBL.wf_StepProcessRelaDA.GetObjByWorkFlowStepProcessRelaId(myKey.Value);
return objwf_StepProcessRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
if (CheckUniqueness_WorkFlowId_WorkFlowStepProcessRelaId(objwf_StepProcessRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!工作流Id = [{0}],工作流与过程关系Id = [{1}]的数据已经存在!(in clswf_StepProcessRelaBL.AddNewRecord)", objwf_StepProcessRelaEN.WorkFlowId,objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clswf_StepProcessRelaBL.wf_StepProcessRelaDA.AddNewRecordBySQL2(objwf_StepProcessRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepProcessRelaBL.ReFreshCache();

if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objwf_StepProcessRelaEN.UpdUser);
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
public static bool AddRecordEx(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objwf_StepProcessRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objwf_StepProcessRelaEN. CheckUniqueness_WorkFlowId_WorkFlowStepProcessRelaId() == false)
{
strMsg = string.Format("(工作流Id(WorkFlowId)=[{0}],工作流与过程关系Id(WorkFlowStepProcessRelaId)=[{1}])已经存在，不能重复!", objwf_StepProcessRelaEN.WorkFlowId, objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objwf_StepProcessRelaEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
if (CheckUniqueness_WorkFlowId_WorkFlowStepProcessRelaId(objwf_StepProcessRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!工作流Id = [{0}],工作流与过程关系Id = [{1}]的数据已经存在!(in clswf_StepProcessRelaBL.AddNewRecordWithReturnKey)", objwf_StepProcessRelaEN.WorkFlowId,objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId);
throw new Exception(strMsg);
}
try
{
string strKey = clswf_StepProcessRelaBL.wf_StepProcessRelaDA.AddNewRecordBySQL2WithReturnKey(objwf_StepProcessRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepProcessRelaBL.ReFreshCache();

if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objwf_StepProcessRelaEN.UpdUser);
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
 /// <param name = "objwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_StepProcessRelaEN SetWorkFlowStepProcessRelaId(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN, long lngWorkFlowStepProcessRelaId, string strComparisonOp="")
	{
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = lngWorkFlowStepProcessRelaId; //工作流与过程关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepProcessRela.WorkFlowStepProcessRelaId) == false)
{
objwf_StepProcessRelaEN.dicFldComparisonOp.Add(conwf_StepProcessRela.WorkFlowStepProcessRelaId, strComparisonOp);
}
else
{
objwf_StepProcessRelaEN.dicFldComparisonOp[conwf_StepProcessRela.WorkFlowStepProcessRelaId] = strComparisonOp;
}
}
return objwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_StepProcessRelaEN SetWorkFlowId(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN, string strWorkFlowId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkFlowId, conwf_StepProcessRela.WorkFlowId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkFlowId, 4, conwf_StepProcessRela.WorkFlowId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWorkFlowId, 4, conwf_StepProcessRela.WorkFlowId);
}
objwf_StepProcessRelaEN.WorkFlowId = strWorkFlowId; //工作流Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepProcessRela.WorkFlowId) == false)
{
objwf_StepProcessRelaEN.dicFldComparisonOp.Add(conwf_StepProcessRela.WorkFlowId, strComparisonOp);
}
else
{
objwf_StepProcessRelaEN.dicFldComparisonOp[conwf_StepProcessRela.WorkFlowId] = strComparisonOp;
}
}
return objwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_StepProcessRelaEN SetProcessId(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN, string strProcessId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProcessId, conwf_StepProcessRela.ProcessId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProcessId, 8, conwf_StepProcessRela.ProcessId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProcessId, 8, conwf_StepProcessRela.ProcessId);
}
objwf_StepProcessRelaEN.ProcessId = strProcessId; //过程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepProcessRela.ProcessId) == false)
{
objwf_StepProcessRelaEN.dicFldComparisonOp.Add(conwf_StepProcessRela.ProcessId, strComparisonOp);
}
else
{
objwf_StepProcessRelaEN.dicFldComparisonOp[conwf_StepProcessRela.ProcessId] = strComparisonOp;
}
}
return objwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_StepProcessRelaEN SetOrderNum(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN, int intOrderNum, string strComparisonOp="")
	{
objwf_StepProcessRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepProcessRela.OrderNum) == false)
{
objwf_StepProcessRelaEN.dicFldComparisonOp.Add(conwf_StepProcessRela.OrderNum, strComparisonOp);
}
else
{
objwf_StepProcessRelaEN.dicFldComparisonOp[conwf_StepProcessRela.OrderNum] = strComparisonOp;
}
}
return objwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_StepProcessRelaEN SetRoleId(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN, string strRoleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRoleId, 8, conwf_StepProcessRela.RoleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, conwf_StepProcessRela.RoleId);
}
objwf_StepProcessRelaEN.RoleId = strRoleId; //角色ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepProcessRela.RoleId) == false)
{
objwf_StepProcessRelaEN.dicFldComparisonOp.Add(conwf_StepProcessRela.RoleId, strComparisonOp);
}
else
{
objwf_StepProcessRelaEN.dicFldComparisonOp[conwf_StepProcessRela.RoleId] = strComparisonOp;
}
}
return objwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_StepProcessRelaEN SetPageName(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN, string strPageName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageName, 100, conwf_StepProcessRela.PageName);
}
objwf_StepProcessRelaEN.PageName = strPageName; //页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepProcessRela.PageName) == false)
{
objwf_StepProcessRelaEN.dicFldComparisonOp.Add(conwf_StepProcessRela.PageName, strComparisonOp);
}
else
{
objwf_StepProcessRelaEN.dicFldComparisonOp[conwf_StepProcessRela.PageName] = strComparisonOp;
}
}
return objwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_StepProcessRelaEN SetDepartmentId(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 6, conwf_StepProcessRela.DepartmentId);
}
objwf_StepProcessRelaEN.DepartmentId = strDepartmentId; //部门ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepProcessRela.DepartmentId) == false)
{
objwf_StepProcessRelaEN.dicFldComparisonOp.Add(conwf_StepProcessRela.DepartmentId, strComparisonOp);
}
else
{
objwf_StepProcessRelaEN.dicFldComparisonOp[conwf_StepProcessRela.DepartmentId] = strComparisonOp;
}
}
return objwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_StepProcessRelaEN SetUpdDate(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conwf_StepProcessRela.UpdDate);
}
objwf_StepProcessRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepProcessRela.UpdDate) == false)
{
objwf_StepProcessRelaEN.dicFldComparisonOp.Add(conwf_StepProcessRela.UpdDate, strComparisonOp);
}
else
{
objwf_StepProcessRelaEN.dicFldComparisonOp[conwf_StepProcessRela.UpdDate] = strComparisonOp;
}
}
return objwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_StepProcessRelaEN SetUpdUser(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conwf_StepProcessRela.UpdUser);
}
objwf_StepProcessRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepProcessRela.UpdUser) == false)
{
objwf_StepProcessRelaEN.dicFldComparisonOp.Add(conwf_StepProcessRela.UpdUser, strComparisonOp);
}
else
{
objwf_StepProcessRelaEN.dicFldComparisonOp[conwf_StepProcessRela.UpdUser] = strComparisonOp;
}
}
return objwf_StepProcessRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_StepProcessRelaEN SetMemo(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conwf_StepProcessRela.Memo);
}
objwf_StepProcessRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepProcessRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepProcessRela.Memo) == false)
{
objwf_StepProcessRelaEN.dicFldComparisonOp.Add(conwf_StepProcessRela.Memo, strComparisonOp);
}
else
{
objwf_StepProcessRelaEN.dicFldComparisonOp[conwf_StepProcessRela.Memo] = strComparisonOp;
}
}
return objwf_StepProcessRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objwf_StepProcessRelaEN.CheckPropertyNew();
clswf_StepProcessRelaEN objwf_StepProcessRelaCond = new clswf_StepProcessRelaEN();
string strCondition = objwf_StepProcessRelaCond
.SetWorkFlowStepProcessRelaId(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, "<>")
.SetWorkFlowId(objwf_StepProcessRelaEN.WorkFlowId, "=")
.SetWorkFlowStepProcessRelaId(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, "=")
.GetCombineCondition();
objwf_StepProcessRelaEN._IsCheckProperty = true;
bool bolIsExist = clswf_StepProcessRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(WorkFlowId_WorkFlowStepProcessRelaId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objwf_StepProcessRelaEN.Update();
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
 /// <param name = "objwf_StepProcessRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clswf_StepProcessRelaEN objwf_StepProcessRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clswf_StepProcessRelaEN objwf_StepProcessRelaCond = new clswf_StepProcessRelaEN();
string strCondition = objwf_StepProcessRelaCond
.SetWorkFlowId(objwf_StepProcessRela.WorkFlowId, "=")
.SetWorkFlowStepProcessRelaId(objwf_StepProcessRela.WorkFlowStepProcessRelaId, "=")
.GetCombineCondition();
objwf_StepProcessRela._IsCheckProperty = true;
bool bolIsExist = clswf_StepProcessRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objwf_StepProcessRela.WorkFlowStepProcessRelaId = clswf_StepProcessRelaBL.GetFirstID_S(strCondition);
objwf_StepProcessRela.UpdateWithCondition(strCondition);
}
else
{
objwf_StepProcessRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
 if (objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clswf_StepProcessRelaBL.wf_StepProcessRelaDA.UpdateBySql2(objwf_StepProcessRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepProcessRelaBL.ReFreshCache();

if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objwf_StepProcessRelaEN.UpdUser);
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
 /// <param name = "objwf_StepProcessRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clswf_StepProcessRelaBL.wf_StepProcessRelaDA.UpdateBySql2(objwf_StepProcessRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepProcessRelaBL.ReFreshCache();

if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objwf_StepProcessRelaEN.UpdUser);
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
 /// <param name = "objwf_StepProcessRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN, string strWhereCond)
{
try
{
bool bolResult = clswf_StepProcessRelaBL.wf_StepProcessRelaDA.UpdateBySqlWithCondition(objwf_StepProcessRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepProcessRelaBL.ReFreshCache();

if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objwf_StepProcessRelaEN.UpdUser);
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
 /// <param name = "objwf_StepProcessRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clswf_StepProcessRelaBL.wf_StepProcessRelaDA.UpdateBySqlWithConditionTransaction(objwf_StepProcessRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepProcessRelaBL.ReFreshCache();

if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objwf_StepProcessRelaEN.UpdUser);
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
 /// <param name = "lngWorkFlowStepProcessRelaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
try
{
int intRecNum = clswf_StepProcessRelaBL.wf_StepProcessRelaDA.DelRecord(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepProcessRelaBL.ReFreshCache();

if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objwf_StepProcessRelaEN.UpdUser);
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
 /// <param name = "objwf_StepProcessRelaENS">源对象</param>
 /// <param name = "objwf_StepProcessRelaENT">目标对象</param>
 public static void CopyTo(this clswf_StepProcessRelaEN objwf_StepProcessRelaENS, clswf_StepProcessRelaEN objwf_StepProcessRelaENT)
{
try
{
objwf_StepProcessRelaENT.WorkFlowStepProcessRelaId = objwf_StepProcessRelaENS.WorkFlowStepProcessRelaId; //工作流与过程关系Id
objwf_StepProcessRelaENT.WorkFlowId = objwf_StepProcessRelaENS.WorkFlowId; //工作流Id
objwf_StepProcessRelaENT.ProcessId = objwf_StepProcessRelaENS.ProcessId; //过程ID
objwf_StepProcessRelaENT.OrderNum = objwf_StepProcessRelaENS.OrderNum; //序号
objwf_StepProcessRelaENT.RoleId = objwf_StepProcessRelaENS.RoleId; //角色ID
objwf_StepProcessRelaENT.PageName = objwf_StepProcessRelaENS.PageName; //页面名称
objwf_StepProcessRelaENT.DepartmentId = objwf_StepProcessRelaENS.DepartmentId; //部门ID
objwf_StepProcessRelaENT.UpdDate = objwf_StepProcessRelaENS.UpdDate; //修改日期
objwf_StepProcessRelaENT.UpdUser = objwf_StepProcessRelaENS.UpdUser; //修改者
objwf_StepProcessRelaENT.Memo = objwf_StepProcessRelaENS.Memo; //说明
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
 /// <param name = "objwf_StepProcessRelaENS">源对象</param>
 /// <returns>目标对象=>clswf_StepProcessRelaEN:objwf_StepProcessRelaENT</returns>
 public static clswf_StepProcessRelaEN CopyTo(this clswf_StepProcessRelaEN objwf_StepProcessRelaENS)
{
try
{
 clswf_StepProcessRelaEN objwf_StepProcessRelaENT = new clswf_StepProcessRelaEN()
{
WorkFlowStepProcessRelaId = objwf_StepProcessRelaENS.WorkFlowStepProcessRelaId, //工作流与过程关系Id
WorkFlowId = objwf_StepProcessRelaENS.WorkFlowId, //工作流Id
ProcessId = objwf_StepProcessRelaENS.ProcessId, //过程ID
OrderNum = objwf_StepProcessRelaENS.OrderNum, //序号
RoleId = objwf_StepProcessRelaENS.RoleId, //角色ID
PageName = objwf_StepProcessRelaENS.PageName, //页面名称
DepartmentId = objwf_StepProcessRelaENS.DepartmentId, //部门ID
UpdDate = objwf_StepProcessRelaENS.UpdDate, //修改日期
UpdUser = objwf_StepProcessRelaENS.UpdUser, //修改者
Memo = objwf_StepProcessRelaENS.Memo, //说明
};
 return objwf_StepProcessRelaENT;
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
public static void CheckPropertyNew(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
 clswf_StepProcessRelaBL.wf_StepProcessRelaDA.CheckPropertyNew(objwf_StepProcessRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
 clswf_StepProcessRelaBL.wf_StepProcessRelaDA.CheckProperty4Condition(objwf_StepProcessRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clswf_StepProcessRelaEN objwf_StepProcessRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objwf_StepProcessRelaCond.IsUpdated(conwf_StepProcessRela.WorkFlowStepProcessRelaId) == true)
{
string strComparisonOpWorkFlowStepProcessRelaId = objwf_StepProcessRelaCond.dicFldComparisonOp[conwf_StepProcessRela.WorkFlowStepProcessRelaId];
strWhereCond += string.Format(" And {0} {2} {1}", conwf_StepProcessRela.WorkFlowStepProcessRelaId, objwf_StepProcessRelaCond.WorkFlowStepProcessRelaId, strComparisonOpWorkFlowStepProcessRelaId);
}
if (objwf_StepProcessRelaCond.IsUpdated(conwf_StepProcessRela.WorkFlowId) == true)
{
string strComparisonOpWorkFlowId = objwf_StepProcessRelaCond.dicFldComparisonOp[conwf_StepProcessRela.WorkFlowId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepProcessRela.WorkFlowId, objwf_StepProcessRelaCond.WorkFlowId, strComparisonOpWorkFlowId);
}
if (objwf_StepProcessRelaCond.IsUpdated(conwf_StepProcessRela.ProcessId) == true)
{
string strComparisonOpProcessId = objwf_StepProcessRelaCond.dicFldComparisonOp[conwf_StepProcessRela.ProcessId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepProcessRela.ProcessId, objwf_StepProcessRelaCond.ProcessId, strComparisonOpProcessId);
}
if (objwf_StepProcessRelaCond.IsUpdated(conwf_StepProcessRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objwf_StepProcessRelaCond.dicFldComparisonOp[conwf_StepProcessRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conwf_StepProcessRela.OrderNum, objwf_StepProcessRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objwf_StepProcessRelaCond.IsUpdated(conwf_StepProcessRela.RoleId) == true)
{
string strComparisonOpRoleId = objwf_StepProcessRelaCond.dicFldComparisonOp[conwf_StepProcessRela.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepProcessRela.RoleId, objwf_StepProcessRelaCond.RoleId, strComparisonOpRoleId);
}
if (objwf_StepProcessRelaCond.IsUpdated(conwf_StepProcessRela.PageName) == true)
{
string strComparisonOpPageName = objwf_StepProcessRelaCond.dicFldComparisonOp[conwf_StepProcessRela.PageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepProcessRela.PageName, objwf_StepProcessRelaCond.PageName, strComparisonOpPageName);
}
if (objwf_StepProcessRelaCond.IsUpdated(conwf_StepProcessRela.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objwf_StepProcessRelaCond.dicFldComparisonOp[conwf_StepProcessRela.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepProcessRela.DepartmentId, objwf_StepProcessRelaCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objwf_StepProcessRelaCond.IsUpdated(conwf_StepProcessRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objwf_StepProcessRelaCond.dicFldComparisonOp[conwf_StepProcessRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepProcessRela.UpdDate, objwf_StepProcessRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objwf_StepProcessRelaCond.IsUpdated(conwf_StepProcessRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objwf_StepProcessRelaCond.dicFldComparisonOp[conwf_StepProcessRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepProcessRela.UpdUser, objwf_StepProcessRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objwf_StepProcessRelaCond.IsUpdated(conwf_StepProcessRela.Memo) == true)
{
string strComparisonOpMemo = objwf_StepProcessRelaCond.dicFldComparisonOp[conwf_StepProcessRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepProcessRela.Memo, objwf_StepProcessRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--wf_StepProcessRela(工作流与过程关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness_WorkFlowId_WorkFlowStepProcessRelaId(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objwf_StepProcessRelaEN == null) return true;
if (objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and WorkFlowId = '{0}'", objwf_StepProcessRelaEN.WorkFlowId);
 sbCondition.AppendFormat(" and WorkFlowStepProcessRelaId = '{0}'", objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId);
if (clswf_StepProcessRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("WorkFlowStepProcessRelaId !=  {0}", objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId);
 sbCondition.AppendFormat(" and WorkFlowId = '{0}'", objwf_StepProcessRelaEN.WorkFlowId);
 sbCondition.AppendFormat(" and WorkFlowStepProcessRelaId = '{0}'", objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId);
if (clswf_StepProcessRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 检查唯一性(Uniqueness)--wf_StepProcessRela(工作流与过程关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrWorkFlowId_WorkFlowStepProcessRelaId(this clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objwf_StepProcessRelaEN == null) return "";
if (objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and WorkFlowId = '{0}'", objwf_StepProcessRelaEN.WorkFlowId);
 sbCondition.AppendFormat(" and WorkFlowStepProcessRelaId = '{0}'", objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("WorkFlowStepProcessRelaId !=  {0}", objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId);
 sbCondition.AppendFormat(" and WorkFlowId = '{0}'", objwf_StepProcessRelaEN.WorkFlowId);
 sbCondition.AppendFormat(" and WorkFlowStepProcessRelaId = '{0}'", objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_wf_StepProcessRela
{
public virtual bool UpdRelaTabDate(long lngWorkFlowStepProcessRelaId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工作流与过程关系(wf_StepProcessRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clswf_StepProcessRelaBL
{
public static RelatedActions_wf_StepProcessRela relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "wf_StepProcessRelaListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "wf_StepProcessRelaList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clswf_StepProcessRelaEN> arrwf_StepProcessRelaObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clswf_StepProcessRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clswf_StepProcessRelaDA wf_StepProcessRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clswf_StepProcessRelaDA();
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
 public clswf_StepProcessRelaBL()
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
if (string.IsNullOrEmpty(clswf_StepProcessRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clswf_StepProcessRelaEN._ConnectString);
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
objDS = wf_StepProcessRelaDA.GetDataSet(strWhereCond);
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
objDS = wf_StepProcessRelaDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = wf_StepProcessRelaDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_wf_StepProcessRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = wf_StepProcessRelaDA.GetDataTable_wf_StepProcessRela(strWhereCond);
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
objDT = wf_StepProcessRelaDA.GetDataTable(strWhereCond);
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
objDT = wf_StepProcessRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = wf_StepProcessRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = wf_StepProcessRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = wf_StepProcessRelaDA.GetDataTable_Top(objTopPara);
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
objDT = wf_StepProcessRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = wf_StepProcessRelaDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = wf_StepProcessRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = wf_StepProcessRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = wf_StepProcessRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = wf_StepProcessRelaDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = wf_StepProcessRelaDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = wf_StepProcessRelaDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrWorkFlowStepProcessRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clswf_StepProcessRelaEN> GetObjLstByWorkFlowStepProcessRelaIdLst(List<long> arrWorkFlowStepProcessRelaIdLst)
{
List<clswf_StepProcessRelaEN> arrObjLst = new List<clswf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrWorkFlowStepProcessRelaIdLst);
 string strWhereCond = string.Format("WorkFlowStepProcessRelaId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepProcessRelaEN objwf_StepProcessRelaEN = new clswf_StepProcessRelaEN();
try
{
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[conwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objwf_StepProcessRelaEN.WorkFlowId = objRow[conwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepProcessRelaEN.ProcessId = objRow[conwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objwf_StepProcessRelaEN.OrderNum = objRow[conwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objwf_StepProcessRelaEN.RoleId = objRow[conwf_StepProcessRela.RoleId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objwf_StepProcessRelaEN.PageName = objRow[conwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[conwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objwf_StepProcessRelaEN.DepartmentId = objRow[conwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objwf_StepProcessRelaEN.UpdDate = objRow[conwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepProcessRelaEN.UpdUser = objRow[conwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objwf_StepProcessRelaEN.Memo = objRow[conwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[conwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepProcessRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrWorkFlowStepProcessRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clswf_StepProcessRelaEN> GetObjLstByWorkFlowStepProcessRelaIdLstCache(List<long> arrWorkFlowStepProcessRelaIdLst)
{
string strKey = string.Format("{0}", clswf_StepProcessRelaEN._CurrTabName);
List<clswf_StepProcessRelaEN> arrwf_StepProcessRelaObjLstCache = GetObjLstCache();
IEnumerable <clswf_StepProcessRelaEN> arrwf_StepProcessRelaObjLst_Sel =
arrwf_StepProcessRelaObjLstCache
.Where(x => arrWorkFlowStepProcessRelaIdLst.Contains(x.WorkFlowStepProcessRelaId));
return arrwf_StepProcessRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_StepProcessRelaEN> GetObjLst(string strWhereCond)
{
List<clswf_StepProcessRelaEN> arrObjLst = new List<clswf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepProcessRelaEN objwf_StepProcessRelaEN = new clswf_StepProcessRelaEN();
try
{
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[conwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objwf_StepProcessRelaEN.WorkFlowId = objRow[conwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepProcessRelaEN.ProcessId = objRow[conwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objwf_StepProcessRelaEN.OrderNum = objRow[conwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objwf_StepProcessRelaEN.RoleId = objRow[conwf_StepProcessRela.RoleId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objwf_StepProcessRelaEN.PageName = objRow[conwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[conwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objwf_StepProcessRelaEN.DepartmentId = objRow[conwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objwf_StepProcessRelaEN.UpdDate = objRow[conwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepProcessRelaEN.UpdUser = objRow[conwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objwf_StepProcessRelaEN.Memo = objRow[conwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[conwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepProcessRelaEN);
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
public static List<clswf_StepProcessRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clswf_StepProcessRelaEN> arrObjLst = new List<clswf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepProcessRelaEN objwf_StepProcessRelaEN = new clswf_StepProcessRelaEN();
try
{
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[conwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objwf_StepProcessRelaEN.WorkFlowId = objRow[conwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepProcessRelaEN.ProcessId = objRow[conwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objwf_StepProcessRelaEN.OrderNum = objRow[conwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objwf_StepProcessRelaEN.RoleId = objRow[conwf_StepProcessRela.RoleId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objwf_StepProcessRelaEN.PageName = objRow[conwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[conwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objwf_StepProcessRelaEN.DepartmentId = objRow[conwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objwf_StepProcessRelaEN.UpdDate = objRow[conwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepProcessRelaEN.UpdUser = objRow[conwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objwf_StepProcessRelaEN.Memo = objRow[conwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[conwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepProcessRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clswf_StepProcessRelaEN> GetSubObjLstCache(clswf_StepProcessRelaEN objwf_StepProcessRelaCond)
{
List<clswf_StepProcessRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clswf_StepProcessRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conwf_StepProcessRela.AttributeName)
{
if (objwf_StepProcessRelaCond.IsUpdated(strFldName) == false) continue;
if (objwf_StepProcessRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_StepProcessRelaCond[strFldName].ToString());
}
else
{
if (objwf_StepProcessRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objwf_StepProcessRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_StepProcessRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objwf_StepProcessRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objwf_StepProcessRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objwf_StepProcessRelaCond[strFldName]));
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
public static List<clswf_StepProcessRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clswf_StepProcessRelaEN> arrObjLst = new List<clswf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepProcessRelaEN objwf_StepProcessRelaEN = new clswf_StepProcessRelaEN();
try
{
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[conwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objwf_StepProcessRelaEN.WorkFlowId = objRow[conwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepProcessRelaEN.ProcessId = objRow[conwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objwf_StepProcessRelaEN.OrderNum = objRow[conwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objwf_StepProcessRelaEN.RoleId = objRow[conwf_StepProcessRela.RoleId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objwf_StepProcessRelaEN.PageName = objRow[conwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[conwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objwf_StepProcessRelaEN.DepartmentId = objRow[conwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objwf_StepProcessRelaEN.UpdDate = objRow[conwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepProcessRelaEN.UpdUser = objRow[conwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objwf_StepProcessRelaEN.Memo = objRow[conwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[conwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepProcessRelaEN);
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
public static List<clswf_StepProcessRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clswf_StepProcessRelaEN> arrObjLst = new List<clswf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepProcessRelaEN objwf_StepProcessRelaEN = new clswf_StepProcessRelaEN();
try
{
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[conwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objwf_StepProcessRelaEN.WorkFlowId = objRow[conwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepProcessRelaEN.ProcessId = objRow[conwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objwf_StepProcessRelaEN.OrderNum = objRow[conwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objwf_StepProcessRelaEN.RoleId = objRow[conwf_StepProcessRela.RoleId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objwf_StepProcessRelaEN.PageName = objRow[conwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[conwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objwf_StepProcessRelaEN.DepartmentId = objRow[conwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objwf_StepProcessRelaEN.UpdDate = objRow[conwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepProcessRelaEN.UpdUser = objRow[conwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objwf_StepProcessRelaEN.Memo = objRow[conwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[conwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepProcessRelaEN);
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
List<clswf_StepProcessRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clswf_StepProcessRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_StepProcessRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clswf_StepProcessRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clswf_StepProcessRelaEN> arrObjLst = new List<clswf_StepProcessRelaEN>(); 
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
	clswf_StepProcessRelaEN objwf_StepProcessRelaEN = new clswf_StepProcessRelaEN();
try
{
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[conwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objwf_StepProcessRelaEN.WorkFlowId = objRow[conwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepProcessRelaEN.ProcessId = objRow[conwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objwf_StepProcessRelaEN.OrderNum = objRow[conwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objwf_StepProcessRelaEN.RoleId = objRow[conwf_StepProcessRela.RoleId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objwf_StepProcessRelaEN.PageName = objRow[conwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[conwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objwf_StepProcessRelaEN.DepartmentId = objRow[conwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objwf_StepProcessRelaEN.UpdDate = objRow[conwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepProcessRelaEN.UpdUser = objRow[conwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objwf_StepProcessRelaEN.Memo = objRow[conwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[conwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepProcessRelaEN);
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
public static List<clswf_StepProcessRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clswf_StepProcessRelaEN> arrObjLst = new List<clswf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepProcessRelaEN objwf_StepProcessRelaEN = new clswf_StepProcessRelaEN();
try
{
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[conwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objwf_StepProcessRelaEN.WorkFlowId = objRow[conwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepProcessRelaEN.ProcessId = objRow[conwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objwf_StepProcessRelaEN.OrderNum = objRow[conwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objwf_StepProcessRelaEN.RoleId = objRow[conwf_StepProcessRela.RoleId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objwf_StepProcessRelaEN.PageName = objRow[conwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[conwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objwf_StepProcessRelaEN.DepartmentId = objRow[conwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objwf_StepProcessRelaEN.UpdDate = objRow[conwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepProcessRelaEN.UpdUser = objRow[conwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objwf_StepProcessRelaEN.Memo = objRow[conwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[conwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepProcessRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clswf_StepProcessRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clswf_StepProcessRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clswf_StepProcessRelaEN> arrObjLst = new List<clswf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepProcessRelaEN objwf_StepProcessRelaEN = new clswf_StepProcessRelaEN();
try
{
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[conwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objwf_StepProcessRelaEN.WorkFlowId = objRow[conwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepProcessRelaEN.ProcessId = objRow[conwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objwf_StepProcessRelaEN.OrderNum = objRow[conwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objwf_StepProcessRelaEN.RoleId = objRow[conwf_StepProcessRela.RoleId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objwf_StepProcessRelaEN.PageName = objRow[conwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[conwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objwf_StepProcessRelaEN.DepartmentId = objRow[conwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objwf_StepProcessRelaEN.UpdDate = objRow[conwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepProcessRelaEN.UpdUser = objRow[conwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objwf_StepProcessRelaEN.Memo = objRow[conwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[conwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepProcessRelaEN);
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
public static List<clswf_StepProcessRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clswf_StepProcessRelaEN> arrObjLst = new List<clswf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepProcessRelaEN objwf_StepProcessRelaEN = new clswf_StepProcessRelaEN();
try
{
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[conwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objwf_StepProcessRelaEN.WorkFlowId = objRow[conwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepProcessRelaEN.ProcessId = objRow[conwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objwf_StepProcessRelaEN.OrderNum = objRow[conwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objwf_StepProcessRelaEN.RoleId = objRow[conwf_StepProcessRela.RoleId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objwf_StepProcessRelaEN.PageName = objRow[conwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[conwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objwf_StepProcessRelaEN.DepartmentId = objRow[conwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objwf_StepProcessRelaEN.UpdDate = objRow[conwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepProcessRelaEN.UpdUser = objRow[conwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objwf_StepProcessRelaEN.Memo = objRow[conwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[conwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepProcessRelaEN);
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
public static IEnumerable<clswf_StepProcessRelaEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clswf_StepProcessRelaEN objwf_StepProcessRelaCond, string strOrderBy)
{
List<clswf_StepProcessRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clswf_StepProcessRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conwf_StepProcessRela.AttributeName)
{
if (objwf_StepProcessRelaCond.IsUpdated(strFldName) == false) continue;
if (objwf_StepProcessRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_StepProcessRelaCond[strFldName].ToString());
}
else
{
if (objwf_StepProcessRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objwf_StepProcessRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_StepProcessRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objwf_StepProcessRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objwf_StepProcessRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objwf_StepProcessRelaCond[strFldName]));
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
public static IEnumerable<clswf_StepProcessRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clswf_StepProcessRelaEN objwf_StepProcessRelaCond = JsonConvert.DeserializeObject<clswf_StepProcessRelaEN>(objPagerPara.whereCond);
if (objwf_StepProcessRelaCond.sfFldComparisonOp == null)
{
objwf_StepProcessRelaCond.dicFldComparisonOp = null;
}
else
{
objwf_StepProcessRelaCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objwf_StepProcessRelaCond.sfFldComparisonOp);
}
clswf_StepProcessRelaBL.SetUpdFlag(objwf_StepProcessRelaCond);
 try
{
CheckProperty4Condition(objwf_StepProcessRelaCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clswf_StepProcessRelaBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objwf_StepProcessRelaCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_StepProcessRelaEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clswf_StepProcessRelaEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clswf_StepProcessRelaEN> arrObjLst = new List<clswf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepProcessRelaEN objwf_StepProcessRelaEN = new clswf_StepProcessRelaEN();
try
{
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[conwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objwf_StepProcessRelaEN.WorkFlowId = objRow[conwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepProcessRelaEN.ProcessId = objRow[conwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objwf_StepProcessRelaEN.OrderNum = objRow[conwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objwf_StepProcessRelaEN.RoleId = objRow[conwf_StepProcessRela.RoleId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objwf_StepProcessRelaEN.PageName = objRow[conwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[conwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objwf_StepProcessRelaEN.DepartmentId = objRow[conwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objwf_StepProcessRelaEN.UpdDate = objRow[conwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepProcessRelaEN.UpdUser = objRow[conwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objwf_StepProcessRelaEN.Memo = objRow[conwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[conwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepProcessRelaEN);
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
public static List<clswf_StepProcessRelaEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clswf_StepProcessRelaEN> arrObjLst = new List<clswf_StepProcessRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepProcessRelaEN objwf_StepProcessRelaEN = new clswf_StepProcessRelaEN();
try
{
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[conwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objwf_StepProcessRelaEN.WorkFlowId = objRow[conwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepProcessRelaEN.ProcessId = objRow[conwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objwf_StepProcessRelaEN.OrderNum = objRow[conwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objwf_StepProcessRelaEN.RoleId = objRow[conwf_StepProcessRela.RoleId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objwf_StepProcessRelaEN.PageName = objRow[conwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[conwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objwf_StepProcessRelaEN.DepartmentId = objRow[conwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objwf_StepProcessRelaEN.UpdDate = objRow[conwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepProcessRelaEN.UpdUser = objRow[conwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objwf_StepProcessRelaEN.Memo = objRow[conwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[conwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepProcessRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_StepProcessRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clswf_StepProcessRelaEN> arrObjLst = new List<clswf_StepProcessRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepProcessRelaEN objwf_StepProcessRelaEN = new clswf_StepProcessRelaEN();
try
{
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = Int32.Parse(objRow[conwf_StepProcessRela.WorkFlowStepProcessRelaId].ToString().Trim()); //工作流与过程关系Id
objwf_StepProcessRelaEN.WorkFlowId = objRow[conwf_StepProcessRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepProcessRelaEN.ProcessId = objRow[conwf_StepProcessRela.ProcessId].ToString().Trim(); //过程ID
objwf_StepProcessRelaEN.OrderNum = objRow[conwf_StepProcessRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepProcessRela.OrderNum].ToString().Trim()); //序号
objwf_StepProcessRelaEN.RoleId = objRow[conwf_StepProcessRela.RoleId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.RoleId].ToString().Trim(); //角色ID
objwf_StepProcessRelaEN.PageName = objRow[conwf_StepProcessRela.PageName] == DBNull.Value ? null : objRow[conwf_StepProcessRela.PageName].ToString().Trim(); //页面名称
objwf_StepProcessRelaEN.DepartmentId = objRow[conwf_StepProcessRela.DepartmentId] == DBNull.Value ? null : objRow[conwf_StepProcessRela.DepartmentId].ToString().Trim(); //部门ID
objwf_StepProcessRelaEN.UpdDate = objRow[conwf_StepProcessRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepProcessRelaEN.UpdUser = objRow[conwf_StepProcessRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepProcessRela.UpdUser].ToString().Trim(); //修改者
objwf_StepProcessRelaEN.Memo = objRow[conwf_StepProcessRela.Memo] == DBNull.Value ? null : objRow[conwf_StepProcessRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepProcessRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getwf_StepProcessRela(ref clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
bool bolResult = wf_StepProcessRelaDA.Getwf_StepProcessRela(ref objwf_StepProcessRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngWorkFlowStepProcessRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clswf_StepProcessRelaEN GetObjByWorkFlowStepProcessRelaId(long lngWorkFlowStepProcessRelaId)
{
clswf_StepProcessRelaEN objwf_StepProcessRelaEN = wf_StepProcessRelaDA.GetObjByWorkFlowStepProcessRelaId(lngWorkFlowStepProcessRelaId);
return objwf_StepProcessRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clswf_StepProcessRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clswf_StepProcessRelaEN objwf_StepProcessRelaEN = wf_StepProcessRelaDA.GetFirstObj(strWhereCond);
 return objwf_StepProcessRelaEN;
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
public static clswf_StepProcessRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clswf_StepProcessRelaEN objwf_StepProcessRelaEN = wf_StepProcessRelaDA.GetObjByDataRow(objRow);
 return objwf_StepProcessRelaEN;
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
public static clswf_StepProcessRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clswf_StepProcessRelaEN objwf_StepProcessRelaEN = wf_StepProcessRelaDA.GetObjByDataRow(objRow);
 return objwf_StepProcessRelaEN;
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
 /// <param name = "lngWorkFlowStepProcessRelaId">所给的关键字</param>
 /// <param name = "lstwf_StepProcessRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clswf_StepProcessRelaEN GetObjByWorkFlowStepProcessRelaIdFromList(long lngWorkFlowStepProcessRelaId, List<clswf_StepProcessRelaEN> lstwf_StepProcessRelaObjLst)
{
foreach (clswf_StepProcessRelaEN objwf_StepProcessRelaEN in lstwf_StepProcessRelaObjLst)
{
if (objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId == lngWorkFlowStepProcessRelaId)
{
return objwf_StepProcessRelaEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond) 
{
 long lngWorkFlowStepProcessRelaId;
 try
 {
 lngWorkFlowStepProcessRelaId = new clswf_StepProcessRelaDA().GetFirstID(strWhereCond);
 return lngWorkFlowStepProcessRelaId;
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
 arrList = wf_StepProcessRelaDA.GetID(strWhereCond);
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
bool bolIsExist = wf_StepProcessRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngWorkFlowStepProcessRelaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngWorkFlowStepProcessRelaId)
{
//检测记录是否存在
bool bolIsExist = wf_StepProcessRelaDA.IsExist(lngWorkFlowStepProcessRelaId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngWorkFlowStepProcessRelaId">工作流与过程关系Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngWorkFlowStepProcessRelaId, string strOpUser)
{
clswf_StepProcessRelaEN objwf_StepProcessRelaEN = clswf_StepProcessRelaBL.GetObjByWorkFlowStepProcessRelaId(lngWorkFlowStepProcessRelaId);
objwf_StepProcessRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objwf_StepProcessRelaEN.UpdUser = strOpUser;
return clswf_StepProcessRelaBL.UpdateBySql2(objwf_StepProcessRelaEN);
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
 bolIsExist = clswf_StepProcessRelaDA.IsExistTable();
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
 bolIsExist = wf_StepProcessRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objwf_StepProcessRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
if (objwf_StepProcessRelaEN.CheckUniqueness_WorkFlowId_WorkFlowStepProcessRelaId() == false)
{
var strMsg = string.Format("记录已经存在!工作流Id = [{0}],工作流与过程关系Id = [{1}]的数据已经存在!(in clswf_StepProcessRelaBL.AddNewRecordBySql2)", objwf_StepProcessRelaEN.WorkFlowId,objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId);
throw new Exception(strMsg);
}
try
{
bool bolResult = wf_StepProcessRelaDA.AddNewRecordBySQL2(objwf_StepProcessRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepProcessRelaBL.ReFreshCache();

if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objwf_StepProcessRelaEN.UpdUser);
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
 /// <param name = "objwf_StepProcessRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
if (objwf_StepProcessRelaEN.CheckUniqueness_WorkFlowId_WorkFlowStepProcessRelaId() == false)
{
var strMsg = string.Format("记录已经存在!工作流Id = [{0}],工作流与过程关系Id = [{1}]的数据已经存在!(in clswf_StepProcessRelaBL.AddNewRecordBySql2WithReturnKey)", objwf_StepProcessRelaEN.WorkFlowId,objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId);
throw new Exception(strMsg);
}
try
{
string strKey = wf_StepProcessRelaDA.AddNewRecordBySQL2WithReturnKey(objwf_StepProcessRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepProcessRelaBL.ReFreshCache();

if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objwf_StepProcessRelaEN.UpdUser);
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
 /// <param name = "strwf_StepProcessRelaObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strwf_StepProcessRelaObjXml)
{
clswf_StepProcessRelaEN objwf_StepProcessRelaEN = GetObjFromXmlStr(strwf_StepProcessRelaObjXml);
try
{
bool bolResult = wf_StepProcessRelaDA.AddNewRecordBySQL2(objwf_StepProcessRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepProcessRelaBL.ReFreshCache();

if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objwf_StepProcessRelaEN.UpdUser);
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
 /// <param name = "objwf_StepProcessRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
try
{
bool bolResult = wf_StepProcessRelaDA.Update(objwf_StepProcessRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepProcessRelaBL.ReFreshCache();

if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objwf_StepProcessRelaEN.UpdUser);
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
 /// <param name = "objwf_StepProcessRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
 if (objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = wf_StepProcessRelaDA.UpdateBySql2(objwf_StepProcessRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepProcessRelaBL.ReFreshCache();

if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objwf_StepProcessRelaEN.UpdUser);
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
 /// <param name = "strwf_StepProcessRelaObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strwf_StepProcessRelaObjXml)
{
clswf_StepProcessRelaEN objwf_StepProcessRelaEN = GetObjFromXmlStr(strwf_StepProcessRelaObjXml);
try
{
bool bolResult = wf_StepProcessRelaDA.UpdateBySql2(objwf_StepProcessRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepProcessRelaBL.ReFreshCache();

if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objwf_StepProcessRelaEN.UpdUser);
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
 /// <param name = "lngWorkFlowStepProcessRelaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngWorkFlowStepProcessRelaId)
{
try
{
 clswf_StepProcessRelaEN objwf_StepProcessRelaEN = clswf_StepProcessRelaBL.GetObjByWorkFlowStepProcessRelaId(lngWorkFlowStepProcessRelaId);

if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId, objwf_StepProcessRelaEN.UpdUser);
}
if (objwf_StepProcessRelaEN != null)
{
int intRecNum = wf_StepProcessRelaDA.DelRecord(lngWorkFlowStepProcessRelaId);
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
/// <param name="lngWorkFlowStepProcessRelaId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngWorkFlowStepProcessRelaId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clswf_StepProcessRelaDA.GetSpecSQLObj();
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
//删除与表:[wf_StepProcessRela]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conwf_StepProcessRela.WorkFlowStepProcessRelaId,
//lngWorkFlowStepProcessRelaId);
//        clswf_StepProcessRelaBL.Delwf_StepProcessRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clswf_StepProcessRelaBL.DelRecord(lngWorkFlowStepProcessRelaId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clswf_StepProcessRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
objException.Message,
lngWorkFlowStepProcessRelaId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngWorkFlowStepProcessRelaId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngWorkFlowStepProcessRelaId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(lngWorkFlowStepProcessRelaId, "UpdRelaTabDate");
}
bool bolResult = wf_StepProcessRelaDA.DelRecord(lngWorkFlowStepProcessRelaId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "lngWorkFlowStepProcessRelaId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngWorkFlowStepProcessRelaId) 
{
try
{
if (clswf_StepProcessRelaBL.relatedActions != null)
{
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(lngWorkFlowStepProcessRelaId, "UpdRelaTabDate");
}
bool bolResult = wf_StepProcessRelaDA.DelRecordBySP(lngWorkFlowStepProcessRelaId);
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
 /// <param name = "arrWorkFlowStepProcessRelaIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delwf_StepProcessRelas(List<string> arrWorkFlowStepProcessRelaIdLst)
{
if (arrWorkFlowStepProcessRelaIdLst.Count == 0) return 0;
try
{
if (clswf_StepProcessRelaBL.relatedActions != null)
{
foreach (var strWorkFlowStepProcessRelaId in arrWorkFlowStepProcessRelaIdLst)
{
long lngWorkFlowStepProcessRelaId = long.Parse(strWorkFlowStepProcessRelaId);
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(lngWorkFlowStepProcessRelaId, "UpdRelaTabDate");
}
}
int intDelRecNum = wf_StepProcessRelaDA.Delwf_StepProcessRela(arrWorkFlowStepProcessRelaIdLst);
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
public static int Delwf_StepProcessRelasByCond(string strWhereCond)
{
try
{
if (clswf_StepProcessRelaBL.relatedActions != null)
{
List<string> arrWorkFlowStepProcessRelaId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strWorkFlowStepProcessRelaId in arrWorkFlowStepProcessRelaId)
{
long lngWorkFlowStepProcessRelaId = long.Parse(strWorkFlowStepProcessRelaId);
clswf_StepProcessRelaBL.relatedActions.UpdRelaTabDate(lngWorkFlowStepProcessRelaId, "UpdRelaTabDate");
}
}
int intRecNum = wf_StepProcessRelaDA.Delwf_StepProcessRela(strWhereCond);
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
/// 这里仅仅是演示函数，使用时请复制到扩展类:[wf_StepProcessRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngWorkFlowStepProcessRelaId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngWorkFlowStepProcessRelaId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clswf_StepProcessRelaDA.GetSpecSQLObj();
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
//删除与表:[wf_StepProcessRela]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clswf_StepProcessRelaBL.DelRecord(lngWorkFlowStepProcessRelaId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clswf_StepProcessRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
objException.Message,
lngWorkFlowStepProcessRelaId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objwf_StepProcessRelaENS">源对象</param>
 /// <param name = "objwf_StepProcessRelaENT">目标对象</param>
 public static void CopyTo(clswf_StepProcessRelaEN objwf_StepProcessRelaENS, clswf_StepProcessRelaEN objwf_StepProcessRelaENT)
{
try
{
objwf_StepProcessRelaENT.WorkFlowStepProcessRelaId = objwf_StepProcessRelaENS.WorkFlowStepProcessRelaId; //工作流与过程关系Id
objwf_StepProcessRelaENT.WorkFlowId = objwf_StepProcessRelaENS.WorkFlowId; //工作流Id
objwf_StepProcessRelaENT.ProcessId = objwf_StepProcessRelaENS.ProcessId; //过程ID
objwf_StepProcessRelaENT.OrderNum = objwf_StepProcessRelaENS.OrderNum; //序号
objwf_StepProcessRelaENT.RoleId = objwf_StepProcessRelaENS.RoleId; //角色ID
objwf_StepProcessRelaENT.PageName = objwf_StepProcessRelaENS.PageName; //页面名称
objwf_StepProcessRelaENT.DepartmentId = objwf_StepProcessRelaENS.DepartmentId; //部门ID
objwf_StepProcessRelaENT.UpdDate = objwf_StepProcessRelaENS.UpdDate; //修改日期
objwf_StepProcessRelaENT.UpdUser = objwf_StepProcessRelaENS.UpdUser; //修改者
objwf_StepProcessRelaENT.Memo = objwf_StepProcessRelaENS.Memo; //说明
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
 /// <param name = "objwf_StepProcessRelaEN">源简化对象</param>
 public static void SetUpdFlag(clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
try
{
objwf_StepProcessRelaEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objwf_StepProcessRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conwf_StepProcessRela.WorkFlowStepProcessRelaId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId; //工作流与过程关系Id
}
if (arrFldSet.Contains(conwf_StepProcessRela.WorkFlowId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepProcessRelaEN.WorkFlowId = objwf_StepProcessRelaEN.WorkFlowId; //工作流Id
}
if (arrFldSet.Contains(conwf_StepProcessRela.ProcessId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepProcessRelaEN.ProcessId = objwf_StepProcessRelaEN.ProcessId; //过程ID
}
if (arrFldSet.Contains(conwf_StepProcessRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepProcessRelaEN.OrderNum = objwf_StepProcessRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(conwf_StepProcessRela.RoleId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepProcessRelaEN.RoleId = objwf_StepProcessRelaEN.RoleId == "[null]" ? null :  objwf_StepProcessRelaEN.RoleId; //角色ID
}
if (arrFldSet.Contains(conwf_StepProcessRela.PageName, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepProcessRelaEN.PageName = objwf_StepProcessRelaEN.PageName == "[null]" ? null :  objwf_StepProcessRelaEN.PageName; //页面名称
}
if (arrFldSet.Contains(conwf_StepProcessRela.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepProcessRelaEN.DepartmentId = objwf_StepProcessRelaEN.DepartmentId == "[null]" ? null :  objwf_StepProcessRelaEN.DepartmentId; //部门ID
}
if (arrFldSet.Contains(conwf_StepProcessRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepProcessRelaEN.UpdDate = objwf_StepProcessRelaEN.UpdDate == "[null]" ? null :  objwf_StepProcessRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conwf_StepProcessRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepProcessRelaEN.UpdUser = objwf_StepProcessRelaEN.UpdUser == "[null]" ? null :  objwf_StepProcessRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conwf_StepProcessRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepProcessRelaEN.Memo = objwf_StepProcessRelaEN.Memo == "[null]" ? null :  objwf_StepProcessRelaEN.Memo; //说明
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
 /// <param name = "objwf_StepProcessRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
try
{
if (objwf_StepProcessRelaEN.RoleId == "[null]") objwf_StepProcessRelaEN.RoleId = null; //角色ID
if (objwf_StepProcessRelaEN.PageName == "[null]") objwf_StepProcessRelaEN.PageName = null; //页面名称
if (objwf_StepProcessRelaEN.DepartmentId == "[null]") objwf_StepProcessRelaEN.DepartmentId = null; //部门ID
if (objwf_StepProcessRelaEN.UpdDate == "[null]") objwf_StepProcessRelaEN.UpdDate = null; //修改日期
if (objwf_StepProcessRelaEN.UpdUser == "[null]") objwf_StepProcessRelaEN.UpdUser = null; //修改者
if (objwf_StepProcessRelaEN.Memo == "[null]") objwf_StepProcessRelaEN.Memo = null; //说明
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
public static void CheckPropertyNew(clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
 wf_StepProcessRelaDA.CheckPropertyNew(objwf_StepProcessRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
 wf_StepProcessRelaDA.CheckProperty4Condition(objwf_StepProcessRelaEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


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
if (clswf_StepProcessRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_StepProcessRelaBL没有刷新缓存机制(clswf_StepProcessRelaBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by WorkFlowStepProcessRelaId");
//if (arrwf_StepProcessRelaObjLstCache == null)
//{
//arrwf_StepProcessRelaObjLstCache = wf_StepProcessRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngWorkFlowStepProcessRelaId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clswf_StepProcessRelaEN GetObjByWorkFlowStepProcessRelaIdCache(long lngWorkFlowStepProcessRelaId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clswf_StepProcessRelaEN._CurrTabName);
List<clswf_StepProcessRelaEN> arrwf_StepProcessRelaObjLstCache = GetObjLstCache();
IEnumerable <clswf_StepProcessRelaEN> arrwf_StepProcessRelaObjLst_Sel =
arrwf_StepProcessRelaObjLstCache
.Where(x=> x.WorkFlowStepProcessRelaId == lngWorkFlowStepProcessRelaId 
);
if (arrwf_StepProcessRelaObjLst_Sel.Count() == 0)
{
   clswf_StepProcessRelaEN obj = clswf_StepProcessRelaBL.GetObjByWorkFlowStepProcessRelaId(lngWorkFlowStepProcessRelaId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrwf_StepProcessRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clswf_StepProcessRelaEN> GetAllwf_StepProcessRelaObjLstCache()
{
//获取缓存中的对象列表
List<clswf_StepProcessRelaEN> arrwf_StepProcessRelaObjLstCache = GetObjLstCache(); 
return arrwf_StepProcessRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clswf_StepProcessRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clswf_StepProcessRelaEN._CurrTabName);
List<clswf_StepProcessRelaEN> arrwf_StepProcessRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrwf_StepProcessRelaObjLstCache;
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
string strKey = string.Format("{0}", clswf_StepProcessRelaEN._CurrTabName);
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
if (clswf_StepProcessRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clswf_StepProcessRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clswf_StepProcessRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--wf_StepProcessRela(工作流与过程关系)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrWorkFlowId_WorkFlowStepProcessRelaId(clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
//检测记录是否存在
string strResult = wf_StepProcessRelaDA.GetUniCondStrWorkFlowId_WorkFlowStepProcessRelaId(objwf_StepProcessRelaEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstwf_StepProcessRelaObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clswf_StepProcessRelaEN> lstwf_StepProcessRelaObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstwf_StepProcessRelaObjLst, writer);
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
 /// <param name = "lstwf_StepProcessRelaObjLst">[clswf_StepProcessRelaEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clswf_StepProcessRelaEN> lstwf_StepProcessRelaObjLst, XmlWriter writer)
{
writer.WriteStartElement(clswf_StepProcessRelaBL.listXmlNode);
writer.WriteStartElement(clswf_StepProcessRelaBL.itemsXmlNode);
foreach (clswf_StepProcessRelaEN objwf_StepProcessRelaEN in lstwf_StepProcessRelaObjLst)
{
clswf_StepProcessRelaBL.SerializeXML(writer, objwf_StepProcessRelaEN);
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
 /// <param name = "objwf_StepProcessRelaEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
writer.WriteStartElement(clswf_StepProcessRelaBL.itemXmlNode);
 
writer.WriteElementString(conwf_StepProcessRela.WorkFlowStepProcessRelaId, objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId.ToString(CultureInfo.InvariantCulture));
 
if (objwf_StepProcessRelaEN.WorkFlowId != null)
{
writer.WriteElementString(conwf_StepProcessRela.WorkFlowId, objwf_StepProcessRelaEN.WorkFlowId.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_StepProcessRelaEN.ProcessId != null)
{
writer.WriteElementString(conwf_StepProcessRela.ProcessId, objwf_StepProcessRelaEN.ProcessId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conwf_StepProcessRela.OrderNum, objwf_StepProcessRelaEN.OrderNum.ToString());
 
if (objwf_StepProcessRelaEN.RoleId != null)
{
writer.WriteElementString(conwf_StepProcessRela.RoleId, objwf_StepProcessRelaEN.RoleId.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_StepProcessRelaEN.PageName != null)
{
writer.WriteElementString(conwf_StepProcessRela.PageName, objwf_StepProcessRelaEN.PageName.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_StepProcessRelaEN.DepartmentId != null)
{
writer.WriteElementString(conwf_StepProcessRela.DepartmentId, objwf_StepProcessRelaEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_StepProcessRelaEN.UpdDate != null)
{
writer.WriteElementString(conwf_StepProcessRela.UpdDate, objwf_StepProcessRelaEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_StepProcessRelaEN.UpdUser != null)
{
writer.WriteElementString(conwf_StepProcessRela.UpdUser, objwf_StepProcessRelaEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_StepProcessRelaEN.Memo != null)
{
writer.WriteElementString(conwf_StepProcessRela.Memo, objwf_StepProcessRelaEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clswf_StepProcessRelaEN GetObjFromXml(System.Xml.XmlReader reader)
{
clswf_StepProcessRelaEN objwf_StepProcessRelaEN = new clswf_StepProcessRelaEN();
reader.Read();
while (!(reader.Name == clswf_StepProcessRelaBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conwf_StepProcessRela.WorkFlowStepProcessRelaId))
{
objwf_StepProcessRelaEN.WorkFlowStepProcessRelaId = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(conwf_StepProcessRela.WorkFlowId))
{
objwf_StepProcessRelaEN.WorkFlowId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_StepProcessRela.ProcessId))
{
objwf_StepProcessRelaEN.ProcessId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_StepProcessRela.OrderNum))
{
objwf_StepProcessRelaEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(conwf_StepProcessRela.RoleId))
{
objwf_StepProcessRelaEN.RoleId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_StepProcessRela.PageName))
{
objwf_StepProcessRelaEN.PageName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_StepProcessRela.DepartmentId))
{
objwf_StepProcessRelaEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_StepProcessRela.UpdDate))
{
objwf_StepProcessRelaEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_StepProcessRela.UpdUser))
{
objwf_StepProcessRelaEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_StepProcessRela.Memo))
{
objwf_StepProcessRelaEN.Memo = reader.ReadElementContentAsString();
}
}
return objwf_StepProcessRelaEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strwf_StepProcessRelaObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clswf_StepProcessRelaEN GetObjFromXmlStr(string strwf_StepProcessRelaObjXmlStr)
{
clswf_StepProcessRelaEN objwf_StepProcessRelaEN = new clswf_StepProcessRelaEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strwf_StepProcessRelaObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clswf_StepProcessRelaBL.itemXmlNode))
{
objwf_StepProcessRelaEN = GetObjFromXml(reader);
return objwf_StepProcessRelaEN;
}
}
return objwf_StepProcessRelaEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objwf_StepProcessRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngWorkFlowStepProcessRelaId)
{
if (strInFldName != conwf_StepProcessRela.WorkFlowStepProcessRelaId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conwf_StepProcessRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conwf_StepProcessRela.AttributeName));
throw new Exception(strMsg);
}
var objwf_StepProcessRela = clswf_StepProcessRelaBL.GetObjByWorkFlowStepProcessRelaIdCache(lngWorkFlowStepProcessRelaId);
if (objwf_StepProcessRela == null) return "";
return objwf_StepProcessRela[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clswf_StepProcessRelaEN objwf_StepProcessRelaEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clswf_StepProcessRelaEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objwf_StepProcessRelaEN[strField]);
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
 /// <param name = "lstwf_StepProcessRelaObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clswf_StepProcessRelaEN> lstwf_StepProcessRelaObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstwf_StepProcessRelaObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clswf_StepProcessRelaEN objwf_StepProcessRelaEN in lstwf_StepProcessRelaObjLst)
{
string strJSON_One = SerializeObjToJSON(objwf_StepProcessRelaEN);
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
int intRecCount = clswf_StepProcessRelaDA.GetRecCount(strTabName);
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
int intRecCount = clswf_StepProcessRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clswf_StepProcessRelaDA.GetRecCount();
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
int intRecCount = clswf_StepProcessRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objwf_StepProcessRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clswf_StepProcessRelaEN objwf_StepProcessRelaCond)
{
List<clswf_StepProcessRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clswf_StepProcessRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conwf_StepProcessRela.AttributeName)
{
if (objwf_StepProcessRelaCond.IsUpdated(strFldName) == false) continue;
if (objwf_StepProcessRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_StepProcessRelaCond[strFldName].ToString());
}
else
{
if (objwf_StepProcessRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objwf_StepProcessRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_StepProcessRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objwf_StepProcessRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objwf_StepProcessRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objwf_StepProcessRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objwf_StepProcessRelaCond[strFldName]));
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
 List<string> arrList = clswf_StepProcessRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = wf_StepProcessRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = wf_StepProcessRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = wf_StepProcessRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clswf_StepProcessRelaDA.SetFldValue(clswf_StepProcessRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = wf_StepProcessRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clswf_StepProcessRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clswf_StepProcessRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clswf_StepProcessRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[wf_StepProcessRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**工作流与过程关系Id*/ 
 strCreateTabCode.Append(" WorkFlowStepProcessRelaId bigint primary key identity, "); 
 // /**工作流Id*/ 
 strCreateTabCode.Append(" WorkFlowId char(4) not Null, "); 
 // /**过程ID*/ 
 strCreateTabCode.Append(" ProcessId char(8) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**角色ID*/ 
 strCreateTabCode.Append(" RoleId char(8) Null, "); 
 // /**页面名称*/ 
 strCreateTabCode.Append(" PageName varchar(100) Null, "); 
 // /**部门ID*/ 
 strCreateTabCode.Append(" DepartmentId varchar(6) Null, "); 
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
/// 重新排序。根据分类字段：WorkFlowId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strWorkFlowId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strWorkFlowId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conwf_StepProcessRela.WorkFlowId, strWorkFlowId);
 strCondition += string.Format(" order by OrderNum ");
List<clswf_StepProcessRelaEN> arrwf_StepProcessRelaObjList = new clswf_StepProcessRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clswf_StepProcessRelaEN objwf_StepProcessRela in arrwf_StepProcessRelaObjList)
{
objwf_StepProcessRela.OrderNum = intIndex;
UpdateBySql2(objwf_StepProcessRela);
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
/// 调整所给关键字记录的序号。根据分类字段：WorkFlowId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngWorkFlowStepProcessRelaId">所给的关键字</param>
/// <param name="strWorkFlowId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngWorkFlowStepProcessRelaId, string strWorkFlowId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[WorkFlowStepProcessRelaId]，获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号，就退出；
//   3.1、如果是向下移动，判断当前序号是否“小于”当前表中的字段数，
//	   即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
//   3.2、如果是向上移动，就判断当前序号是否“大于”1，
//	   即不是第一条记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字WorkFlowStepProcessRelaId
//5、把当前关键字WorkFlowStepProcessRelaId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字WorkFlowStepProcessRelaId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevWorkFlowStepProcessRelaId = 0;    //上一条序号的关键字WorkFlowStepProcessRelaId
long lngNextWorkFlowStepProcessRelaId = 0;    //下一条序号的关键字WorkFlowStepProcessRelaId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[WorkFlowStepProcessRelaId]，获取相应的序号[OrderNum]。

clswf_StepProcessRelaEN objwf_StepProcessRela = clswf_StepProcessRelaBL.GetObjByWorkFlowStepProcessRelaId(lngWorkFlowStepProcessRelaId);

intOrderNum = objwf_StepProcessRela.OrderNum??0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号，
//		3.1 如果是末端序号，就退出，

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conwf_StepProcessRela.WorkFlowId, strWorkFlowId);
intTabRecNum = clswf_StepProcessRelaBL.GetRecCountByCond(clswf_StepProcessRelaEN._CurrTabName, strCondition);    //获取当前表的记录数
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
sbCondition.AppendFormat(" {0} = {1} ", conwf_StepProcessRela.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conwf_StepProcessRela.WorkFlowId, strWorkFlowId);
//4、获取上一个序号字段的关键字WorkFlowStepProcessRelaId
lngPrevWorkFlowStepProcessRelaId = clswf_StepProcessRelaBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevWorkFlowStepProcessRelaId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字WorkFlowStepProcessRelaId所对应记录的序号减1
//6、把下(上)一个序号关键字WorkFlowStepProcessRelaId所对应的记录序号加1
clswf_StepProcessRelaBL.SetFldValue(clswf_StepProcessRelaEN._CurrTabName, conwf_StepProcessRela.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conwf_StepProcessRela.WorkFlowStepProcessRelaId, lngWorkFlowStepProcessRelaId));
clswf_StepProcessRelaBL.SetFldValue(clswf_StepProcessRelaEN._CurrTabName, conwf_StepProcessRela.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conwf_StepProcessRela.WorkFlowStepProcessRelaId, lngPrevWorkFlowStepProcessRelaId));
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

//4、获取下一个序号字段的关键字WorkFlowStepProcessRelaId
sbCondition.AppendFormat(" {0} = {1} ", conwf_StepProcessRela.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conwf_StepProcessRela.WorkFlowId, strWorkFlowId);

lngNextWorkFlowStepProcessRelaId = clswf_StepProcessRelaBL.GetFirstID_S(sbCondition.ToString());
if (lngNextWorkFlowStepProcessRelaId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字WorkFlowStepProcessRelaId所对应记录的序号加1
//6、把下(上)一个序号关键字WorkFlowStepProcessRelaId所对应的记录序号减1
clswf_StepProcessRelaBL.SetFldValue(clswf_StepProcessRelaEN._CurrTabName, conwf_StepProcessRela.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conwf_StepProcessRela.WorkFlowStepProcessRelaId, lngWorkFlowStepProcessRelaId));
clswf_StepProcessRelaBL.SetFldValue(clswf_StepProcessRelaEN._CurrTabName, conwf_StepProcessRela.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conwf_StepProcessRela.WorkFlowStepProcessRelaId, lngNextWorkFlowStepProcessRelaId));
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：WorkFlowId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId, string strWorkFlowId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conwf_StepProcessRela.WorkFlowStepProcessRelaId, strKeyList);
List<clswf_StepProcessRelaEN> arrwf_StepProcessRelaLst = GetObjLst(strCondition);
foreach (clswf_StepProcessRelaEN objwf_StepProcessRela in arrwf_StepProcessRelaLst)
{
objwf_StepProcessRela.OrderNum = objwf_StepProcessRela.OrderNum + 10000;
UpdateBySql2(objwf_StepProcessRela);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conwf_StepProcessRela.WorkFlowId, strWorkFlowId);
 strCondition += string.Format(" order by OrderNum ");
List<clswf_StepProcessRelaEN> arrwf_StepProcessRelaObjList = new clswf_StepProcessRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clswf_StepProcessRelaEN objwf_StepProcessRela in arrwf_StepProcessRelaObjList)
{
objwf_StepProcessRela.OrderNum = intIndex;
UpdateBySql2(objwf_StepProcessRela);
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
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：WorkFlowId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strWorkFlowId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId, string strWorkFlowId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conwf_StepProcessRela.WorkFlowStepProcessRelaId, strKeyList);
List<clswf_StepProcessRelaEN> arrwf_StepProcessRelaLst = GetObjLst(strCondition);
foreach (clswf_StepProcessRelaEN objwf_StepProcessRela in arrwf_StepProcessRelaLst)
{
objwf_StepProcessRela.OrderNum = objwf_StepProcessRela.OrderNum - 10000;
UpdateBySql2(objwf_StepProcessRela);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conwf_StepProcessRela.WorkFlowId, strWorkFlowId);
 strCondition += string.Format(" order by OrderNum ");
List<clswf_StepProcessRelaEN> arrwf_StepProcessRelaObjList = new clswf_StepProcessRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clswf_StepProcessRelaEN objwf_StepProcessRela in arrwf_StepProcessRelaObjList)
{
objwf_StepProcessRela.OrderNum = intIndex;
UpdateBySql2(objwf_StepProcessRela);
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
 /// 工作流与过程关系(wf_StepProcessRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4wf_StepProcessRela : clsCommFun4BL
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
clswf_StepProcessRelaBL.ReFreshThisCache();
}
}

}