
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clswf_StepPointRelaBL
 表名:wf_StepPointRela(00050486)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:10
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clswf_StepPointRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngWorkFlowStepPointRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clswf_StepPointRelaEN GetObj(this K_WorkFlowStepPointRelaId_wf_StepPointRela myKey)
{
clswf_StepPointRelaEN objwf_StepPointRelaEN = clswf_StepPointRelaBL.wf_StepPointRelaDA.GetObjByWorkFlowStepPointRelaId(myKey.Value);
return objwf_StepPointRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clswf_StepPointRelaEN objwf_StepPointRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objwf_StepPointRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!工作流Id = [{0}],结点Id = [{1}]的数据已经存在!(in clswf_StepPointRelaBL.AddNewRecord)", objwf_StepPointRelaEN.WorkFlowId,objwf_StepPointRelaEN.PointId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clswf_StepPointRelaBL.wf_StepPointRelaDA.AddNewRecordBySQL2(objwf_StepPointRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaBL.ReFreshCache();

if (clswf_StepPointRelaBL.relatedActions != null)
{
clswf_StepPointRelaBL.relatedActions.UpdRelaTabDate(objwf_StepPointRelaEN.WorkFlowStepPointRelaId, "SetUpdDate");
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
public static bool AddRecordEx(this clswf_StepPointRelaEN objwf_StepPointRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objwf_StepPointRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objwf_StepPointRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(工作流Id(WorkFlowId)=[{0}],结点Id(PointId)=[{1}])已经存在,不能重复!", objwf_StepPointRelaEN.WorkFlowId, objwf_StepPointRelaEN.PointId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objwf_StepPointRelaEN.AddNewRecord();
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
 /// <param name = "objwf_StepPointRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clswf_StepPointRelaEN objwf_StepPointRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objwf_StepPointRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!工作流Id = [{0}],结点Id = [{1}]的数据已经存在!(in clswf_StepPointRelaBL.AddNewRecordWithReturnKey)", objwf_StepPointRelaEN.WorkFlowId,objwf_StepPointRelaEN.PointId);
throw new Exception(strMsg);
}
try
{
string strKey = clswf_StepPointRelaBL.wf_StepPointRelaDA.AddNewRecordBySQL2WithReturnKey(objwf_StepPointRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaBL.ReFreshCache();

if (clswf_StepPointRelaBL.relatedActions != null)
{
clswf_StepPointRelaBL.relatedActions.UpdRelaTabDate(objwf_StepPointRelaEN.WorkFlowStepPointRelaId, "SetUpdDate");
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetWorkFlowStepPointRelaId(this clswf_StepPointRelaEN objwf_StepPointRelaEN, long lngWorkFlowStepPointRelaId, string strComparisonOp="")
	{
objwf_StepPointRelaEN.WorkFlowStepPointRelaId = lngWorkFlowStepPointRelaId; //工作流与结点关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.WorkFlowStepPointRelaId) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.WorkFlowStepPointRelaId, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.WorkFlowStepPointRelaId] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetWorkFlowId(this clswf_StepPointRelaEN objwf_StepPointRelaEN, string strWorkFlowId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkFlowId, conwf_StepPointRela.WorkFlowId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkFlowId, 4, conwf_StepPointRela.WorkFlowId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWorkFlowId, 4, conwf_StepPointRela.WorkFlowId);
}
objwf_StepPointRelaEN.WorkFlowId = strWorkFlowId; //工作流Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.WorkFlowId) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.WorkFlowId, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.WorkFlowId] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetPointId(this clswf_StepPointRelaEN objwf_StepPointRelaEN, string strPointId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointId, conwf_StepPointRela.PointId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPointId, 8, conwf_StepPointRela.PointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPointId, 8, conwf_StepPointRela.PointId);
}
objwf_StepPointRelaEN.PointId = strPointId; //结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.PointId) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.PointId, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.PointId] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetPointTypeId(this clswf_StepPointRelaEN objwf_StepPointRelaEN, string strPointTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointTypeId, conwf_StepPointRela.PointTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPointTypeId, 2, conwf_StepPointRela.PointTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPointTypeId, 2, conwf_StepPointRela.PointTypeId);
}
objwf_StepPointRelaEN.PointTypeId = strPointTypeId; //工作流结点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.PointTypeId) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.PointTypeId, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.PointTypeId] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetLevelNo(this clswf_StepPointRelaEN objwf_StepPointRelaEN, int? intLevelNo, string strComparisonOp="")
	{
objwf_StepPointRelaEN.LevelNo = intLevelNo; //层序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.LevelNo) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.LevelNo, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.LevelNo] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetInDegree(this clswf_StepPointRelaEN objwf_StepPointRelaEN, int? intInDegree, string strComparisonOp="")
	{
objwf_StepPointRelaEN.InDegree = intInDegree; //入度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.InDegree) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.InDegree, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.InDegree] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetOutDegree(this clswf_StepPointRelaEN objwf_StepPointRelaEN, int? intOutDegree, string strComparisonOp="")
	{
objwf_StepPointRelaEN.OutDegree = intOutDegree; //出度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.OutDegree) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.OutDegree, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.OutDegree] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetOrderNum(this clswf_StepPointRelaEN objwf_StepPointRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objwf_StepPointRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.OrderNum) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.OrderNum, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.OrderNum] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetUpdDate(this clswf_StepPointRelaEN objwf_StepPointRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conwf_StepPointRela.UpdDate);
}
objwf_StepPointRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.UpdDate) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.UpdDate, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.UpdDate] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetUpdUser(this clswf_StepPointRelaEN objwf_StepPointRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conwf_StepPointRela.UpdUser);
}
objwf_StepPointRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.UpdUser) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.UpdUser, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.UpdUser] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clswf_StepPointRelaEN SetMemo(this clswf_StepPointRelaEN objwf_StepPointRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conwf_StepPointRela.Memo);
}
objwf_StepPointRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_StepPointRelaEN.dicFldComparisonOp.ContainsKey(conwf_StepPointRela.Memo) == false)
{
objwf_StepPointRelaEN.dicFldComparisonOp.Add(conwf_StepPointRela.Memo, strComparisonOp);
}
else
{
objwf_StepPointRelaEN.dicFldComparisonOp[conwf_StepPointRela.Memo] = strComparisonOp;
}
}
return objwf_StepPointRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objwf_StepPointRelaEN.CheckPropertyNew();
clswf_StepPointRelaEN objwf_StepPointRelaCond = new clswf_StepPointRelaEN();
string strCondition = objwf_StepPointRelaCond
.SetWorkFlowStepPointRelaId(objwf_StepPointRelaEN.WorkFlowStepPointRelaId, "<>")
.SetWorkFlowId(objwf_StepPointRelaEN.WorkFlowId, "=")
.SetPointId(objwf_StepPointRelaEN.PointId, "=")
.GetCombineCondition();
objwf_StepPointRelaEN._IsCheckProperty = true;
bool bolIsExist = clswf_StepPointRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(WorkFlowId_PointId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objwf_StepPointRelaEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objwf_StepPointRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clswf_StepPointRelaEN objwf_StepPointRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clswf_StepPointRelaEN objwf_StepPointRelaCond = new clswf_StepPointRelaEN();
string strCondition = objwf_StepPointRelaCond
.SetWorkFlowId(objwf_StepPointRela.WorkFlowId, "=")
.SetPointId(objwf_StepPointRela.PointId, "=")
.GetCombineCondition();
objwf_StepPointRela._IsCheckProperty = true;
bool bolIsExist = clswf_StepPointRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objwf_StepPointRela.WorkFlowStepPointRelaId = clswf_StepPointRelaBL.GetFirstID_S(strCondition);
objwf_StepPointRela.UpdateWithCondition(strCondition);
}
else
{
objwf_StepPointRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
 if (objwf_StepPointRelaEN.WorkFlowStepPointRelaId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clswf_StepPointRelaBL.wf_StepPointRelaDA.UpdateBySql2(objwf_StepPointRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaBL.ReFreshCache();

if (clswf_StepPointRelaBL.relatedActions != null)
{
clswf_StepPointRelaBL.relatedActions.UpdRelaTabDate(objwf_StepPointRelaEN.WorkFlowStepPointRelaId, "SetUpdDate");
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
 /// <param name = "objwf_StepPointRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clswf_StepPointRelaEN objwf_StepPointRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objwf_StepPointRelaEN.WorkFlowStepPointRelaId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clswf_StepPointRelaBL.wf_StepPointRelaDA.UpdateBySql2(objwf_StepPointRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaBL.ReFreshCache();

if (clswf_StepPointRelaBL.relatedActions != null)
{
clswf_StepPointRelaBL.relatedActions.UpdRelaTabDate(objwf_StepPointRelaEN.WorkFlowStepPointRelaId, "SetUpdDate");
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
 /// <param name = "objwf_StepPointRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clswf_StepPointRelaEN objwf_StepPointRelaEN, string strWhereCond)
{
try
{
bool bolResult = clswf_StepPointRelaBL.wf_StepPointRelaDA.UpdateBySqlWithCondition(objwf_StepPointRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaBL.ReFreshCache();

if (clswf_StepPointRelaBL.relatedActions != null)
{
clswf_StepPointRelaBL.relatedActions.UpdRelaTabDate(objwf_StepPointRelaEN.WorkFlowStepPointRelaId, "SetUpdDate");
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
 /// <param name = "objwf_StepPointRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clswf_StepPointRelaEN objwf_StepPointRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clswf_StepPointRelaBL.wf_StepPointRelaDA.UpdateBySqlWithConditionTransaction(objwf_StepPointRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaBL.ReFreshCache();

if (clswf_StepPointRelaBL.relatedActions != null)
{
clswf_StepPointRelaBL.relatedActions.UpdRelaTabDate(objwf_StepPointRelaEN.WorkFlowStepPointRelaId, "SetUpdDate");
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
 /// <param name = "lngWorkFlowStepPointRelaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
try
{
int intRecNum = clswf_StepPointRelaBL.wf_StepPointRelaDA.DelRecord(objwf_StepPointRelaEN.WorkFlowStepPointRelaId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaBL.ReFreshCache();

if (clswf_StepPointRelaBL.relatedActions != null)
{
clswf_StepPointRelaBL.relatedActions.UpdRelaTabDate(objwf_StepPointRelaEN.WorkFlowStepPointRelaId, "SetUpdDate");
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
 /// <param name = "objwf_StepPointRelaENS">源对象</param>
 /// <param name = "objwf_StepPointRelaENT">目标对象</param>
 public static void CopyTo(this clswf_StepPointRelaEN objwf_StepPointRelaENS, clswf_StepPointRelaEN objwf_StepPointRelaENT)
{
try
{
objwf_StepPointRelaENT.WorkFlowStepPointRelaId = objwf_StepPointRelaENS.WorkFlowStepPointRelaId; //工作流与结点关系Id
objwf_StepPointRelaENT.WorkFlowId = objwf_StepPointRelaENS.WorkFlowId; //工作流Id
objwf_StepPointRelaENT.PointId = objwf_StepPointRelaENS.PointId; //结点Id
objwf_StepPointRelaENT.PointTypeId = objwf_StepPointRelaENS.PointTypeId; //工作流结点类型Id
objwf_StepPointRelaENT.LevelNo = objwf_StepPointRelaENS.LevelNo; //层序号
objwf_StepPointRelaENT.InDegree = objwf_StepPointRelaENS.InDegree; //入度
objwf_StepPointRelaENT.OutDegree = objwf_StepPointRelaENS.OutDegree; //出度
objwf_StepPointRelaENT.OrderNum = objwf_StepPointRelaENS.OrderNum; //序号
objwf_StepPointRelaENT.UpdDate = objwf_StepPointRelaENS.UpdDate; //修改日期
objwf_StepPointRelaENT.UpdUser = objwf_StepPointRelaENS.UpdUser; //修改者
objwf_StepPointRelaENT.Memo = objwf_StepPointRelaENS.Memo; //说明
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
 /// <param name = "objwf_StepPointRelaENS">源对象</param>
 /// <returns>目标对象=>clswf_StepPointRelaEN:objwf_StepPointRelaENT</returns>
 public static clswf_StepPointRelaEN CopyTo(this clswf_StepPointRelaEN objwf_StepPointRelaENS)
{
try
{
 clswf_StepPointRelaEN objwf_StepPointRelaENT = new clswf_StepPointRelaEN()
{
WorkFlowStepPointRelaId = objwf_StepPointRelaENS.WorkFlowStepPointRelaId, //工作流与结点关系Id
WorkFlowId = objwf_StepPointRelaENS.WorkFlowId, //工作流Id
PointId = objwf_StepPointRelaENS.PointId, //结点Id
PointTypeId = objwf_StepPointRelaENS.PointTypeId, //工作流结点类型Id
LevelNo = objwf_StepPointRelaENS.LevelNo, //层序号
InDegree = objwf_StepPointRelaENS.InDegree, //入度
OutDegree = objwf_StepPointRelaENS.OutDegree, //出度
OrderNum = objwf_StepPointRelaENS.OrderNum, //序号
UpdDate = objwf_StepPointRelaENS.UpdDate, //修改日期
UpdUser = objwf_StepPointRelaENS.UpdUser, //修改者
Memo = objwf_StepPointRelaENS.Memo, //说明
};
 return objwf_StepPointRelaENT;
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
public static void CheckPropertyNew(this clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
 clswf_StepPointRelaBL.wf_StepPointRelaDA.CheckPropertyNew(objwf_StepPointRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
 clswf_StepPointRelaBL.wf_StepPointRelaDA.CheckProperty4Condition(objwf_StepPointRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clswf_StepPointRelaEN objwf_StepPointRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.WorkFlowStepPointRelaId) == true)
{
string strComparisonOpWorkFlowStepPointRelaId = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.WorkFlowStepPointRelaId];
strWhereCond += string.Format(" And {0} {2} {1}", conwf_StepPointRela.WorkFlowStepPointRelaId, objwf_StepPointRelaCond.WorkFlowStepPointRelaId, strComparisonOpWorkFlowStepPointRelaId);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.WorkFlowId) == true)
{
string strComparisonOpWorkFlowId = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.WorkFlowId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepPointRela.WorkFlowId, objwf_StepPointRelaCond.WorkFlowId, strComparisonOpWorkFlowId);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.PointId) == true)
{
string strComparisonOpPointId = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.PointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepPointRela.PointId, objwf_StepPointRelaCond.PointId, strComparisonOpPointId);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.PointTypeId) == true)
{
string strComparisonOpPointTypeId = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.PointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepPointRela.PointTypeId, objwf_StepPointRelaCond.PointTypeId, strComparisonOpPointTypeId);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.LevelNo) == true)
{
string strComparisonOpLevelNo = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.LevelNo];
strWhereCond += string.Format(" And {0} {2} {1}", conwf_StepPointRela.LevelNo, objwf_StepPointRelaCond.LevelNo, strComparisonOpLevelNo);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.InDegree) == true)
{
string strComparisonOpInDegree = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.InDegree];
strWhereCond += string.Format(" And {0} {2} {1}", conwf_StepPointRela.InDegree, objwf_StepPointRelaCond.InDegree, strComparisonOpInDegree);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.OutDegree) == true)
{
string strComparisonOpOutDegree = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.OutDegree];
strWhereCond += string.Format(" And {0} {2} {1}", conwf_StepPointRela.OutDegree, objwf_StepPointRelaCond.OutDegree, strComparisonOpOutDegree);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conwf_StepPointRela.OrderNum, objwf_StepPointRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepPointRela.UpdDate, objwf_StepPointRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepPointRela.UpdUser, objwf_StepPointRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objwf_StepPointRelaCond.IsUpdated(conwf_StepPointRela.Memo) == true)
{
string strComparisonOpMemo = objwf_StepPointRelaCond.dicFldComparisonOp[conwf_StepPointRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_StepPointRela.Memo, objwf_StepPointRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--wf_StepPointRela(工作流与结点关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:WorkFlowId_PointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objwf_StepPointRelaEN == null) return true;
if (objwf_StepPointRelaEN.WorkFlowStepPointRelaId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and WorkFlowId = '{0}'", objwf_StepPointRelaEN.WorkFlowId);
 sbCondition.AppendFormat(" and PointId = '{0}'", objwf_StepPointRelaEN.PointId);
if (clswf_StepPointRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("WorkFlowStepPointRelaId !=  {0}", objwf_StepPointRelaEN.WorkFlowStepPointRelaId);
 sbCondition.AppendFormat(" and WorkFlowId = '{0}'", objwf_StepPointRelaEN.WorkFlowId);
 sbCondition.AppendFormat(" and PointId = '{0}'", objwf_StepPointRelaEN.PointId);
if (clswf_StepPointRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--wf_StepPointRela(工作流与结点关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:WorkFlowId_PointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objwf_StepPointRelaEN == null) return "";
if (objwf_StepPointRelaEN.WorkFlowStepPointRelaId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and WorkFlowId = '{0}'", objwf_StepPointRelaEN.WorkFlowId);
 sbCondition.AppendFormat(" and PointId = '{0}'", objwf_StepPointRelaEN.PointId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("WorkFlowStepPointRelaId !=  {0}", objwf_StepPointRelaEN.WorkFlowStepPointRelaId);
 sbCondition.AppendFormat(" and WorkFlowId = '{0}'", objwf_StepPointRelaEN.WorkFlowId);
 sbCondition.AppendFormat(" and PointId = '{0}'", objwf_StepPointRelaEN.PointId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_wf_StepPointRela
{
public virtual bool UpdRelaTabDate(long lngWorkFlowStepPointRelaId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工作流与结点关系(wf_StepPointRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clswf_StepPointRelaBL
{
public static RelatedActions_wf_StepPointRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clswf_StepPointRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clswf_StepPointRelaDA wf_StepPointRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clswf_StepPointRelaDA();
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
 public clswf_StepPointRelaBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
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
if (string.IsNullOrEmpty(clswf_StepPointRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clswf_StepPointRelaEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_wf_StepPointRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = wf_StepPointRelaDA.GetDataTable_wf_StepPointRela(strWhereCond);
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
objDT = wf_StepPointRelaDA.GetDataTable(strWhereCond);
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
objDT = wf_StepPointRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = wf_StepPointRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = wf_StepPointRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = wf_StepPointRelaDA.GetDataTable_Top(objTopPara);
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
objDT = wf_StepPointRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = wf_StepPointRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = wf_StepPointRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrWorkFlowStepPointRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clswf_StepPointRelaEN> GetObjLstByWorkFlowStepPointRelaIdLst(List<long> arrWorkFlowStepPointRelaIdLst)
{
List<clswf_StepPointRelaEN> arrObjLst = new List<clswf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrWorkFlowStepPointRelaIdLst);
 string strWhereCond = string.Format("WorkFlowStepPointRelaId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepPointRelaEN objwf_StepPointRelaEN = new clswf_StepPointRelaEN();
try
{
objwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[conwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objwf_StepPointRelaEN.WorkFlowId = objRow[conwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepPointRelaEN.PointId = objRow[conwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objwf_StepPointRelaEN.PointTypeId = objRow[conwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objwf_StepPointRelaEN.LevelNo = objRow[conwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objwf_StepPointRelaEN.InDegree = objRow[conwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.InDegree].ToString().Trim()); //入度
objwf_StepPointRelaEN.OutDegree = objRow[conwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objwf_StepPointRelaEN.OrderNum = objRow[conwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objwf_StepPointRelaEN.UpdDate = objRow[conwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepPointRelaEN.UpdUser = objRow[conwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objwf_StepPointRelaEN.Memo = objRow[conwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[conwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepPointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrWorkFlowStepPointRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clswf_StepPointRelaEN> GetObjLstByWorkFlowStepPointRelaIdLstCache(List<long> arrWorkFlowStepPointRelaIdLst)
{
string strKey = string.Format("{0}", clswf_StepPointRelaEN._CurrTabName);
List<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLstCache = GetObjLstCache();
IEnumerable <clswf_StepPointRelaEN> arrwf_StepPointRelaObjLst_Sel =
arrwf_StepPointRelaObjLstCache
.Where(x => arrWorkFlowStepPointRelaIdLst.Contains(x.WorkFlowStepPointRelaId));
return arrwf_StepPointRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_StepPointRelaEN> GetObjLst(string strWhereCond)
{
List<clswf_StepPointRelaEN> arrObjLst = new List<clswf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepPointRelaEN objwf_StepPointRelaEN = new clswf_StepPointRelaEN();
try
{
objwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[conwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objwf_StepPointRelaEN.WorkFlowId = objRow[conwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepPointRelaEN.PointId = objRow[conwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objwf_StepPointRelaEN.PointTypeId = objRow[conwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objwf_StepPointRelaEN.LevelNo = objRow[conwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objwf_StepPointRelaEN.InDegree = objRow[conwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.InDegree].ToString().Trim()); //入度
objwf_StepPointRelaEN.OutDegree = objRow[conwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objwf_StepPointRelaEN.OrderNum = objRow[conwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objwf_StepPointRelaEN.UpdDate = objRow[conwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepPointRelaEN.UpdUser = objRow[conwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objwf_StepPointRelaEN.Memo = objRow[conwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[conwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepPointRelaEN);
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
public static List<clswf_StepPointRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clswf_StepPointRelaEN> arrObjLst = new List<clswf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepPointRelaEN objwf_StepPointRelaEN = new clswf_StepPointRelaEN();
try
{
objwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[conwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objwf_StepPointRelaEN.WorkFlowId = objRow[conwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepPointRelaEN.PointId = objRow[conwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objwf_StepPointRelaEN.PointTypeId = objRow[conwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objwf_StepPointRelaEN.LevelNo = objRow[conwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objwf_StepPointRelaEN.InDegree = objRow[conwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.InDegree].ToString().Trim()); //入度
objwf_StepPointRelaEN.OutDegree = objRow[conwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objwf_StepPointRelaEN.OrderNum = objRow[conwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objwf_StepPointRelaEN.UpdDate = objRow[conwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepPointRelaEN.UpdUser = objRow[conwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objwf_StepPointRelaEN.Memo = objRow[conwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[conwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepPointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objwf_StepPointRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clswf_StepPointRelaEN> GetSubObjLstCache(clswf_StepPointRelaEN objwf_StepPointRelaCond)
{
List<clswf_StepPointRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clswf_StepPointRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conwf_StepPointRela._AttributeName)
{
if (objwf_StepPointRelaCond.IsUpdated(strFldName) == false) continue;
if (objwf_StepPointRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_StepPointRelaCond[strFldName].ToString());
}
else
{
if (objwf_StepPointRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objwf_StepPointRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_StepPointRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objwf_StepPointRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objwf_StepPointRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objwf_StepPointRelaCond[strFldName]));
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
public static List<clswf_StepPointRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clswf_StepPointRelaEN> arrObjLst = new List<clswf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepPointRelaEN objwf_StepPointRelaEN = new clswf_StepPointRelaEN();
try
{
objwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[conwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objwf_StepPointRelaEN.WorkFlowId = objRow[conwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepPointRelaEN.PointId = objRow[conwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objwf_StepPointRelaEN.PointTypeId = objRow[conwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objwf_StepPointRelaEN.LevelNo = objRow[conwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objwf_StepPointRelaEN.InDegree = objRow[conwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.InDegree].ToString().Trim()); //入度
objwf_StepPointRelaEN.OutDegree = objRow[conwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objwf_StepPointRelaEN.OrderNum = objRow[conwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objwf_StepPointRelaEN.UpdDate = objRow[conwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepPointRelaEN.UpdUser = objRow[conwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objwf_StepPointRelaEN.Memo = objRow[conwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[conwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepPointRelaEN);
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
public static List<clswf_StepPointRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clswf_StepPointRelaEN> arrObjLst = new List<clswf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepPointRelaEN objwf_StepPointRelaEN = new clswf_StepPointRelaEN();
try
{
objwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[conwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objwf_StepPointRelaEN.WorkFlowId = objRow[conwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepPointRelaEN.PointId = objRow[conwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objwf_StepPointRelaEN.PointTypeId = objRow[conwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objwf_StepPointRelaEN.LevelNo = objRow[conwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objwf_StepPointRelaEN.InDegree = objRow[conwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.InDegree].ToString().Trim()); //入度
objwf_StepPointRelaEN.OutDegree = objRow[conwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objwf_StepPointRelaEN.OrderNum = objRow[conwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objwf_StepPointRelaEN.UpdDate = objRow[conwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepPointRelaEN.UpdUser = objRow[conwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objwf_StepPointRelaEN.Memo = objRow[conwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[conwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepPointRelaEN);
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
List<clswf_StepPointRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clswf_StepPointRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_StepPointRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clswf_StepPointRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clswf_StepPointRelaEN> arrObjLst = new List<clswf_StepPointRelaEN>(); 
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
	clswf_StepPointRelaEN objwf_StepPointRelaEN = new clswf_StepPointRelaEN();
try
{
objwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[conwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objwf_StepPointRelaEN.WorkFlowId = objRow[conwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepPointRelaEN.PointId = objRow[conwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objwf_StepPointRelaEN.PointTypeId = objRow[conwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objwf_StepPointRelaEN.LevelNo = objRow[conwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objwf_StepPointRelaEN.InDegree = objRow[conwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.InDegree].ToString().Trim()); //入度
objwf_StepPointRelaEN.OutDegree = objRow[conwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objwf_StepPointRelaEN.OrderNum = objRow[conwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objwf_StepPointRelaEN.UpdDate = objRow[conwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepPointRelaEN.UpdUser = objRow[conwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objwf_StepPointRelaEN.Memo = objRow[conwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[conwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepPointRelaEN);
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
public static List<clswf_StepPointRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clswf_StepPointRelaEN> arrObjLst = new List<clswf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepPointRelaEN objwf_StepPointRelaEN = new clswf_StepPointRelaEN();
try
{
objwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[conwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objwf_StepPointRelaEN.WorkFlowId = objRow[conwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepPointRelaEN.PointId = objRow[conwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objwf_StepPointRelaEN.PointTypeId = objRow[conwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objwf_StepPointRelaEN.LevelNo = objRow[conwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objwf_StepPointRelaEN.InDegree = objRow[conwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.InDegree].ToString().Trim()); //入度
objwf_StepPointRelaEN.OutDegree = objRow[conwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objwf_StepPointRelaEN.OrderNum = objRow[conwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objwf_StepPointRelaEN.UpdDate = objRow[conwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepPointRelaEN.UpdUser = objRow[conwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objwf_StepPointRelaEN.Memo = objRow[conwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[conwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepPointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clswf_StepPointRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clswf_StepPointRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clswf_StepPointRelaEN> arrObjLst = new List<clswf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepPointRelaEN objwf_StepPointRelaEN = new clswf_StepPointRelaEN();
try
{
objwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[conwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objwf_StepPointRelaEN.WorkFlowId = objRow[conwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepPointRelaEN.PointId = objRow[conwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objwf_StepPointRelaEN.PointTypeId = objRow[conwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objwf_StepPointRelaEN.LevelNo = objRow[conwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objwf_StepPointRelaEN.InDegree = objRow[conwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.InDegree].ToString().Trim()); //入度
objwf_StepPointRelaEN.OutDegree = objRow[conwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objwf_StepPointRelaEN.OrderNum = objRow[conwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objwf_StepPointRelaEN.UpdDate = objRow[conwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepPointRelaEN.UpdUser = objRow[conwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objwf_StepPointRelaEN.Memo = objRow[conwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[conwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepPointRelaEN);
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
public static List<clswf_StepPointRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clswf_StepPointRelaEN> arrObjLst = new List<clswf_StepPointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepPointRelaEN objwf_StepPointRelaEN = new clswf_StepPointRelaEN();
try
{
objwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[conwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objwf_StepPointRelaEN.WorkFlowId = objRow[conwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepPointRelaEN.PointId = objRow[conwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objwf_StepPointRelaEN.PointTypeId = objRow[conwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objwf_StepPointRelaEN.LevelNo = objRow[conwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objwf_StepPointRelaEN.InDegree = objRow[conwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.InDegree].ToString().Trim()); //入度
objwf_StepPointRelaEN.OutDegree = objRow[conwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objwf_StepPointRelaEN.OrderNum = objRow[conwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objwf_StepPointRelaEN.UpdDate = objRow[conwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepPointRelaEN.UpdUser = objRow[conwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objwf_StepPointRelaEN.Memo = objRow[conwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[conwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepPointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_StepPointRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clswf_StepPointRelaEN> arrObjLst = new List<clswf_StepPointRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_StepPointRelaEN objwf_StepPointRelaEN = new clswf_StepPointRelaEN();
try
{
objwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[conwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objwf_StepPointRelaEN.WorkFlowId = objRow[conwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objwf_StepPointRelaEN.PointId = objRow[conwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objwf_StepPointRelaEN.PointTypeId = objRow[conwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objwf_StepPointRelaEN.LevelNo = objRow[conwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objwf_StepPointRelaEN.InDegree = objRow[conwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.InDegree].ToString().Trim()); //入度
objwf_StepPointRelaEN.OutDegree = objRow[conwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objwf_StepPointRelaEN.OrderNum = objRow[conwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objwf_StepPointRelaEN.UpdDate = objRow[conwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objwf_StepPointRelaEN.UpdUser = objRow[conwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[conwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objwf_StepPointRelaEN.Memo = objRow[conwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[conwf_StepPointRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_StepPointRelaEN.WorkFlowStepPointRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_StepPointRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getwf_StepPointRela(ref clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
bool bolResult = wf_StepPointRelaDA.Getwf_StepPointRela(ref objwf_StepPointRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngWorkFlowStepPointRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clswf_StepPointRelaEN GetObjByWorkFlowStepPointRelaId(long lngWorkFlowStepPointRelaId)
{
clswf_StepPointRelaEN objwf_StepPointRelaEN = wf_StepPointRelaDA.GetObjByWorkFlowStepPointRelaId(lngWorkFlowStepPointRelaId);
return objwf_StepPointRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clswf_StepPointRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clswf_StepPointRelaEN objwf_StepPointRelaEN = wf_StepPointRelaDA.GetFirstObj(strWhereCond);
 return objwf_StepPointRelaEN;
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
public static clswf_StepPointRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clswf_StepPointRelaEN objwf_StepPointRelaEN = wf_StepPointRelaDA.GetObjByDataRow(objRow);
 return objwf_StepPointRelaEN;
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
public static clswf_StepPointRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clswf_StepPointRelaEN objwf_StepPointRelaEN = wf_StepPointRelaDA.GetObjByDataRow(objRow);
 return objwf_StepPointRelaEN;
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
 /// <param name = "lngWorkFlowStepPointRelaId">所给的关键字</param>
 /// <param name = "lstwf_StepPointRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clswf_StepPointRelaEN GetObjByWorkFlowStepPointRelaIdFromList(long lngWorkFlowStepPointRelaId, List<clswf_StepPointRelaEN> lstwf_StepPointRelaObjLst)
{
foreach (clswf_StepPointRelaEN objwf_StepPointRelaEN in lstwf_StepPointRelaObjLst)
{
if (objwf_StepPointRelaEN.WorkFlowStepPointRelaId == lngWorkFlowStepPointRelaId)
{
return objwf_StepPointRelaEN;
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
 long lngWorkFlowStepPointRelaId;
 try
 {
 lngWorkFlowStepPointRelaId = new clswf_StepPointRelaDA().GetFirstID(strWhereCond);
 return lngWorkFlowStepPointRelaId;
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
 arrList = wf_StepPointRelaDA.GetID(strWhereCond);
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
bool bolIsExist = wf_StepPointRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngWorkFlowStepPointRelaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngWorkFlowStepPointRelaId)
{
//检测记录是否存在
bool bolIsExist = wf_StepPointRelaDA.IsExist(lngWorkFlowStepPointRelaId);
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
 bolIsExist = clswf_StepPointRelaDA.IsExistTable();
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
 bolIsExist = wf_StepPointRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objwf_StepPointRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clswf_StepPointRelaEN objwf_StepPointRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objwf_StepPointRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工作流Id = [{0}],结点Id = [{1}]的数据已经存在!(in clswf_StepPointRelaBL.AddNewRecordBySql2)", objwf_StepPointRelaEN.WorkFlowId,objwf_StepPointRelaEN.PointId);
throw new Exception(strMsg);
}
try
{
bool bolResult = wf_StepPointRelaDA.AddNewRecordBySQL2(objwf_StepPointRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaBL.ReFreshCache();

if (clswf_StepPointRelaBL.relatedActions != null)
{
clswf_StepPointRelaBL.relatedActions.UpdRelaTabDate(objwf_StepPointRelaEN.WorkFlowStepPointRelaId, "SetUpdDate");
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
 /// <param name = "objwf_StepPointRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clswf_StepPointRelaEN objwf_StepPointRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objwf_StepPointRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!工作流Id = [{0}],结点Id = [{1}]的数据已经存在!(in clswf_StepPointRelaBL.AddNewRecordBySql2WithReturnKey)", objwf_StepPointRelaEN.WorkFlowId,objwf_StepPointRelaEN.PointId);
throw new Exception(strMsg);
}
try
{
string strKey = wf_StepPointRelaDA.AddNewRecordBySQL2WithReturnKey(objwf_StepPointRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaBL.ReFreshCache();

if (clswf_StepPointRelaBL.relatedActions != null)
{
clswf_StepPointRelaBL.relatedActions.UpdRelaTabDate(objwf_StepPointRelaEN.WorkFlowStepPointRelaId, "SetUpdDate");
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


 #endregion 添加记录


 #region 修改记录

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Update)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
try
{
bool bolResult = wf_StepPointRelaDA.Update(objwf_StepPointRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaBL.ReFreshCache();

if (clswf_StepPointRelaBL.relatedActions != null)
{
clswf_StepPointRelaBL.relatedActions.UpdRelaTabDate(objwf_StepPointRelaEN.WorkFlowStepPointRelaId, "SetUpdDate");
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
 /// <param name = "objwf_StepPointRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
 if (objwf_StepPointRelaEN.WorkFlowStepPointRelaId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = wf_StepPointRelaDA.UpdateBySql2(objwf_StepPointRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_StepPointRelaBL.ReFreshCache();

if (clswf_StepPointRelaBL.relatedActions != null)
{
clswf_StepPointRelaBL.relatedActions.UpdRelaTabDate(objwf_StepPointRelaEN.WorkFlowStepPointRelaId, "SetUpdDate");
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


 #endregion 修改记录


 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
 /// </summary>
 /// <param name = "lngWorkFlowStepPointRelaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngWorkFlowStepPointRelaId)
{
try
{
 clswf_StepPointRelaEN objwf_StepPointRelaEN = clswf_StepPointRelaBL.GetObjByWorkFlowStepPointRelaId(lngWorkFlowStepPointRelaId);

if (clswf_StepPointRelaBL.relatedActions != null)
{
clswf_StepPointRelaBL.relatedActions.UpdRelaTabDate(objwf_StepPointRelaEN.WorkFlowStepPointRelaId, "SetUpdDate");
}
if (objwf_StepPointRelaEN != null)
{
int intRecNum = wf_StepPointRelaDA.DelRecord(lngWorkFlowStepPointRelaId);
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
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="lngWorkFlowStepPointRelaId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngWorkFlowStepPointRelaId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clswf_StepPointRelaDA.GetSpecSQLObj();
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
//删除与表:[wf_StepPointRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conwf_StepPointRela.WorkFlowStepPointRelaId,
//lngWorkFlowStepPointRelaId);
//        clswf_StepPointRelaBL.Delwf_StepPointRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clswf_StepPointRelaBL.DelRecord(lngWorkFlowStepPointRelaId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clswf_StepPointRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngWorkFlowStepPointRelaId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngWorkFlowStepPointRelaId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngWorkFlowStepPointRelaId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clswf_StepPointRelaBL.relatedActions != null)
{
clswf_StepPointRelaBL.relatedActions.UpdRelaTabDate(lngWorkFlowStepPointRelaId, "UpdRelaTabDate");
}
bool bolResult = wf_StepPointRelaDA.DelRecord(lngWorkFlowStepPointRelaId,objSqlConnection,objSqlTransaction);
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
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrWorkFlowStepPointRelaIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delwf_StepPointRelas(List<string> arrWorkFlowStepPointRelaIdLst)
{
if (arrWorkFlowStepPointRelaIdLst.Count == 0) return 0;
try
{
if (clswf_StepPointRelaBL.relatedActions != null)
{
foreach (var strWorkFlowStepPointRelaId in arrWorkFlowStepPointRelaIdLst)
{
long lngWorkFlowStepPointRelaId = long.Parse(strWorkFlowStepPointRelaId);
clswf_StepPointRelaBL.relatedActions.UpdRelaTabDate(lngWorkFlowStepPointRelaId, "UpdRelaTabDate");
}
}
int intDelRecNum = wf_StepPointRelaDA.Delwf_StepPointRela(arrWorkFlowStepPointRelaIdLst);
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
public static int Delwf_StepPointRelasByCond(string strWhereCond)
{
try
{
if (clswf_StepPointRelaBL.relatedActions != null)
{
List<string> arrWorkFlowStepPointRelaId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strWorkFlowStepPointRelaId in arrWorkFlowStepPointRelaId)
{
long lngWorkFlowStepPointRelaId = long.Parse(strWorkFlowStepPointRelaId);
clswf_StepPointRelaBL.relatedActions.UpdRelaTabDate(lngWorkFlowStepPointRelaId, "UpdRelaTabDate");
}
}
int intRecNum = wf_StepPointRelaDA.Delwf_StepPointRela(strWhereCond);
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
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[wf_StepPointRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngWorkFlowStepPointRelaId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngWorkFlowStepPointRelaId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clswf_StepPointRelaDA.GetSpecSQLObj();
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
//删除与表:[wf_StepPointRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clswf_StepPointRelaBL.DelRecord(lngWorkFlowStepPointRelaId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clswf_StepPointRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngWorkFlowStepPointRelaId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objwf_StepPointRelaENS">源对象</param>
 /// <param name = "objwf_StepPointRelaENT">目标对象</param>
 public static void CopyTo(clswf_StepPointRelaEN objwf_StepPointRelaENS, clswf_StepPointRelaEN objwf_StepPointRelaENT)
{
try
{
objwf_StepPointRelaENT.WorkFlowStepPointRelaId = objwf_StepPointRelaENS.WorkFlowStepPointRelaId; //工作流与结点关系Id
objwf_StepPointRelaENT.WorkFlowId = objwf_StepPointRelaENS.WorkFlowId; //工作流Id
objwf_StepPointRelaENT.PointId = objwf_StepPointRelaENS.PointId; //结点Id
objwf_StepPointRelaENT.PointTypeId = objwf_StepPointRelaENS.PointTypeId; //工作流结点类型Id
objwf_StepPointRelaENT.LevelNo = objwf_StepPointRelaENS.LevelNo; //层序号
objwf_StepPointRelaENT.InDegree = objwf_StepPointRelaENS.InDegree; //入度
objwf_StepPointRelaENT.OutDegree = objwf_StepPointRelaENS.OutDegree; //出度
objwf_StepPointRelaENT.OrderNum = objwf_StepPointRelaENS.OrderNum; //序号
objwf_StepPointRelaENT.UpdDate = objwf_StepPointRelaENS.UpdDate; //修改日期
objwf_StepPointRelaENT.UpdUser = objwf_StepPointRelaENS.UpdUser; //修改者
objwf_StepPointRelaENT.Memo = objwf_StepPointRelaENS.Memo; //说明
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
 /// <param name = "objwf_StepPointRelaEN">源简化对象</param>
 public static void SetUpdFlag(clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
try
{
objwf_StepPointRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objwf_StepPointRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conwf_StepPointRela.WorkFlowStepPointRelaId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepPointRelaEN.WorkFlowStepPointRelaId = objwf_StepPointRelaEN.WorkFlowStepPointRelaId; //工作流与结点关系Id
}
if (arrFldSet.Contains(conwf_StepPointRela.WorkFlowId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepPointRelaEN.WorkFlowId = objwf_StepPointRelaEN.WorkFlowId; //工作流Id
}
if (arrFldSet.Contains(conwf_StepPointRela.PointId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepPointRelaEN.PointId = objwf_StepPointRelaEN.PointId; //结点Id
}
if (arrFldSet.Contains(conwf_StepPointRela.PointTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepPointRelaEN.PointTypeId = objwf_StepPointRelaEN.PointTypeId; //工作流结点类型Id
}
if (arrFldSet.Contains(conwf_StepPointRela.LevelNo, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepPointRelaEN.LevelNo = objwf_StepPointRelaEN.LevelNo; //层序号
}
if (arrFldSet.Contains(conwf_StepPointRela.InDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepPointRelaEN.InDegree = objwf_StepPointRelaEN.InDegree; //入度
}
if (arrFldSet.Contains(conwf_StepPointRela.OutDegree, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepPointRelaEN.OutDegree = objwf_StepPointRelaEN.OutDegree; //出度
}
if (arrFldSet.Contains(conwf_StepPointRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepPointRelaEN.OrderNum = objwf_StepPointRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(conwf_StepPointRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepPointRelaEN.UpdDate = objwf_StepPointRelaEN.UpdDate == "[null]" ? null :  objwf_StepPointRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conwf_StepPointRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepPointRelaEN.UpdUser = objwf_StepPointRelaEN.UpdUser == "[null]" ? null :  objwf_StepPointRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conwf_StepPointRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_StepPointRelaEN.Memo = objwf_StepPointRelaEN.Memo == "[null]" ? null :  objwf_StepPointRelaEN.Memo; //说明
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
try
{
if (objwf_StepPointRelaEN.UpdDate == "[null]") objwf_StepPointRelaEN.UpdDate = null; //修改日期
if (objwf_StepPointRelaEN.UpdUser == "[null]") objwf_StepPointRelaEN.UpdUser = null; //修改者
if (objwf_StepPointRelaEN.Memo == "[null]") objwf_StepPointRelaEN.Memo = null; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckPropertyNew(clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
 wf_StepPointRelaDA.CheckPropertyNew(objwf_StepPointRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
 wf_StepPointRelaDA.CheckProperty4Condition(objwf_StepPointRelaEN);
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
if (clswf_StepPointRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_StepPointRelaBL没有刷新缓存机制(clswf_StepPointRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by WorkFlowStepPointRelaId");
//if (arrwf_StepPointRelaObjLstCache == null)
//{
//arrwf_StepPointRelaObjLstCache = wf_StepPointRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngWorkFlowStepPointRelaId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clswf_StepPointRelaEN GetObjByWorkFlowStepPointRelaIdCache(long lngWorkFlowStepPointRelaId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clswf_StepPointRelaEN._CurrTabName);
List<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLstCache = GetObjLstCache();
IEnumerable <clswf_StepPointRelaEN> arrwf_StepPointRelaObjLst_Sel =
arrwf_StepPointRelaObjLstCache
.Where(x=> x.WorkFlowStepPointRelaId == lngWorkFlowStepPointRelaId 
);
if (arrwf_StepPointRelaObjLst_Sel.Count() == 0)
{
   clswf_StepPointRelaEN obj = clswf_StepPointRelaBL.GetObjByWorkFlowStepPointRelaId(lngWorkFlowStepPointRelaId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrwf_StepPointRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clswf_StepPointRelaEN> GetAllwf_StepPointRelaObjLstCache()
{
//获取缓存中的对象列表
List<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLstCache = GetObjLstCache(); 
return arrwf_StepPointRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clswf_StepPointRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clswf_StepPointRelaEN._CurrTabName);
List<clswf_StepPointRelaEN> arrwf_StepPointRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrwf_StepPointRelaObjLstCache;
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
string strKey = string.Format("{0}", clswf_StepPointRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clswf_StepPointRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clswf_StepPointRelaEN._RefreshTimeLst.Count == 0) return "";
return clswf_StepPointRelaEN._RefreshTimeLst[clswf_StepPointRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clswf_StepPointRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clswf_StepPointRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clswf_StepPointRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clswf_StepPointRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--wf_StepPointRela(工作流与结点关系)
 /// 唯一性条件:WorkFlowId_PointId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objwf_StepPointRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clswf_StepPointRelaEN objwf_StepPointRelaEN)
{
//检测记录是否存在
string strResult = wf_StepPointRelaDA.GetUniCondStr(objwf_StepPointRelaEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-07-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngWorkFlowStepPointRelaId)
{
if (strInFldName != conwf_StepPointRela.WorkFlowStepPointRelaId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conwf_StepPointRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conwf_StepPointRela._AttributeName));
throw new Exception(strMsg);
}
var objwf_StepPointRela = clswf_StepPointRelaBL.GetObjByWorkFlowStepPointRelaIdCache(lngWorkFlowStepPointRelaId);
if (objwf_StepPointRela == null) return "";
return objwf_StepPointRela[strOutFldName].ToString();
}


 #region 有关JSON操作


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
int intRecCount = clswf_StepPointRelaDA.GetRecCount(strTabName);
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
int intRecCount = clswf_StepPointRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clswf_StepPointRelaDA.GetRecCount();
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
int intRecCount = clswf_StepPointRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objwf_StepPointRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clswf_StepPointRelaEN objwf_StepPointRelaCond)
{
List<clswf_StepPointRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clswf_StepPointRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conwf_StepPointRela._AttributeName)
{
if (objwf_StepPointRelaCond.IsUpdated(strFldName) == false) continue;
if (objwf_StepPointRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_StepPointRelaCond[strFldName].ToString());
}
else
{
if (objwf_StepPointRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objwf_StepPointRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_StepPointRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objwf_StepPointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objwf_StepPointRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objwf_StepPointRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objwf_StepPointRelaCond[strFldName]));
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
 List<string> arrList = clswf_StepPointRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = wf_StepPointRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = wf_StepPointRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = wf_StepPointRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clswf_StepPointRelaDA.SetFldValue(clswf_StepPointRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = wf_StepPointRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clswf_StepPointRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clswf_StepPointRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clswf_StepPointRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[wf_StepPointRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**工作流与结点关系Id*/ 
 strCreateTabCode.Append(" WorkFlowStepPointRelaId bigint primary key identity, "); 
 // /**工作流Id*/ 
 strCreateTabCode.Append(" WorkFlowId char(4) not Null, "); 
 // /**结点Id*/ 
 strCreateTabCode.Append(" PointId char(8) not Null, "); 
 // /**工作流结点类型Id*/ 
 strCreateTabCode.Append(" PointTypeId char(2) not Null, "); 
 // /**层序号*/ 
 strCreateTabCode.Append(" LevelNo int Null, "); 
 // /**入度*/ 
 strCreateTabCode.Append(" InDegree int Null, "); 
 // /**出度*/ 
 strCreateTabCode.Append(" OutDegree int Null, "); 
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
strCondition += string.Format(" And {0} = '{1}' ", conwf_StepPointRela.WorkFlowId, strWorkFlowId);
 strCondition += string.Format(" order by OrderNum ");
List<clswf_StepPointRelaEN> arrwf_StepPointRelaObjList = new clswf_StepPointRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clswf_StepPointRelaEN objwf_StepPointRela in arrwf_StepPointRelaObjList)
{
objwf_StepPointRela.OrderNum = intIndex;
UpdateBySql2(objwf_StepPointRela);
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
/// <param name="lngWorkFlowStepPointRelaId">所给的关键字</param>
/// <param name="strWorkFlowId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngWorkFlowStepPointRelaId ,string strWorkFlowId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[WorkFlowStepPointRelaId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字WorkFlowStepPointRelaId
//5、把当前关键字WorkFlowStepPointRelaId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字WorkFlowStepPointRelaId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevWorkFlowStepPointRelaId = 0;    //上一条序号的关键字WorkFlowStepPointRelaId
long lngNextWorkFlowStepPointRelaId = 0;    //下一条序号的关键字WorkFlowStepPointRelaId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[WorkFlowStepPointRelaId],获取相应的序号[OrderNum]。

clswf_StepPointRelaEN objwf_StepPointRela = clswf_StepPointRelaBL.GetObjByWorkFlowStepPointRelaId(lngWorkFlowStepPointRelaId);

intOrderNum = objwf_StepPointRela.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conwf_StepPointRela.WorkFlowId, strWorkFlowId);
intTabRecNum = clswf_StepPointRelaBL.GetRecCountByCond(clswf_StepPointRelaEN._CurrTabName, strCondition);    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
sbCondition.AppendFormat(" {0} = {1} ", conwf_StepPointRela.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conwf_StepPointRela.WorkFlowId, strWorkFlowId);
//4、获取上一个序号字段的关键字WorkFlowStepPointRelaId
lngPrevWorkFlowStepPointRelaId = clswf_StepPointRelaBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevWorkFlowStepPointRelaId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字WorkFlowStepPointRelaId所对应记录的序号减1
//6、把下(上)一个序号关键字WorkFlowStepPointRelaId所对应的记录序号加1
clswf_StepPointRelaBL.SetFldValue(clswf_StepPointRelaEN._CurrTabName, conwf_StepPointRela.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conwf_StepPointRela.WorkFlowStepPointRelaId, lngWorkFlowStepPointRelaId));
clswf_StepPointRelaBL.SetFldValue(clswf_StepPointRelaEN._CurrTabName, conwf_StepPointRela.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conwf_StepPointRela.WorkFlowStepPointRelaId, lngPrevWorkFlowStepPointRelaId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字WorkFlowStepPointRelaId
sbCondition.AppendFormat(" {0} = {1} ", conwf_StepPointRela.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conwf_StepPointRela.WorkFlowId, strWorkFlowId);

lngNextWorkFlowStepPointRelaId = clswf_StepPointRelaBL.GetFirstID_S(sbCondition.ToString());
if (lngNextWorkFlowStepPointRelaId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字WorkFlowStepPointRelaId所对应记录的序号加1
//6、把下(上)一个序号关键字WorkFlowStepPointRelaId所对应的记录序号减1
clswf_StepPointRelaBL.SetFldValue(clswf_StepPointRelaEN._CurrTabName, conwf_StepPointRela.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conwf_StepPointRela.WorkFlowStepPointRelaId, lngWorkFlowStepPointRelaId));
clswf_StepPointRelaBL.SetFldValue(clswf_StepPointRelaEN._CurrTabName, conwf_StepPointRela.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conwf_StepPointRela.WorkFlowStepPointRelaId, lngNextWorkFlowStepPointRelaId));
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
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
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
public static bool GoBottom(List<long> arrKeyId ,string strWorkFlowId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conwf_StepPointRela.WorkFlowStepPointRelaId, strKeyList);
List<clswf_StepPointRelaEN> arrwf_StepPointRelaLst = GetObjLst(strCondition);
foreach (clswf_StepPointRelaEN objwf_StepPointRela in arrwf_StepPointRelaLst)
{
objwf_StepPointRela.OrderNum = objwf_StepPointRela.OrderNum + 10000;
UpdateBySql2(objwf_StepPointRela);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conwf_StepPointRela.WorkFlowId, strWorkFlowId);
 strCondition += string.Format(" order by OrderNum ");
List<clswf_StepPointRelaEN> arrwf_StepPointRelaObjList = new clswf_StepPointRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clswf_StepPointRelaEN objwf_StepPointRela in arrwf_StepPointRelaObjList)
{
objwf_StepPointRela.OrderNum = intIndex;
UpdateBySql2(objwf_StepPointRela);
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
public static bool GoTop(List<long> arrKeyId ,string strWorkFlowId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conwf_StepPointRela.WorkFlowStepPointRelaId, strKeyList);
List<clswf_StepPointRelaEN> arrwf_StepPointRelaLst = GetObjLst(strCondition);
foreach (clswf_StepPointRelaEN objwf_StepPointRela in arrwf_StepPointRelaLst)
{
objwf_StepPointRela.OrderNum = objwf_StepPointRela.OrderNum - 10000;
UpdateBySql2(objwf_StepPointRela);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conwf_StepPointRela.WorkFlowId, strWorkFlowId);
 strCondition += string.Format(" order by OrderNum ");
List<clswf_StepPointRelaEN> arrwf_StepPointRelaObjList = new clswf_StepPointRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clswf_StepPointRelaEN objwf_StepPointRela in arrwf_StepPointRelaObjList)
{
objwf_StepPointRela.OrderNum = intIndex;
UpdateBySql2(objwf_StepPointRela);
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
 /// 工作流与结点关系(wf_StepPointRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4wf_StepPointRela : clsCommFun4BL
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
clswf_StepPointRelaBL.ReFreshThisCache();
}
}

}