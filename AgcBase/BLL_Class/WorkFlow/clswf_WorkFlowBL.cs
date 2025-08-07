
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clswf_WorkFlowBL
 表名:wf_WorkFlow(00050482)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:19:17
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
public static class clswf_WorkFlowBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strWorkFlowId">表关键字</param>
 /// <returns>表对象</returns>
public static clswf_WorkFlowEN GetObj(this K_WorkFlowId_wf_WorkFlow myKey)
{
clswf_WorkFlowEN objwf_WorkFlowEN = clswf_WorkFlowBL.wf_WorkFlowDA.GetObjByWorkFlowId(myKey.Value);
return objwf_WorkFlowEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clswf_WorkFlowEN objwf_WorkFlowEN)
{
if (CheckUniqueness_WorkFlowName_PrjId(objwf_WorkFlowEN) == false)
{
var strMsg = string.Format("记录已经存在!工作流名称 = [{0}],工程ID = [{1}]的数据已经存在!(in clswf_WorkFlowBL.AddNewRecord)", objwf_WorkFlowEN.WorkFlowName,objwf_WorkFlowEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objwf_WorkFlowEN.WorkFlowId) == true || clswf_WorkFlowBL.IsExist(objwf_WorkFlowEN.WorkFlowId) == true)
 {
     objwf_WorkFlowEN.WorkFlowId = clswf_WorkFlowBL.GetMaxStrId_S();
 }
bool bolResult = clswf_WorkFlowBL.wf_WorkFlowDA.AddNewRecordBySQL2(objwf_WorkFlowEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_WorkFlowBL.ReFreshCache();

if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(objwf_WorkFlowEN.WorkFlowId, "SetUpdDate");
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
public static bool AddRecordEx(this clswf_WorkFlowEN objwf_WorkFlowEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键，不需要检查主键是否已经存在，在添加时，再获取 最大值作为主键
//if (clswf_WorkFlowBL.IsExist(objwf_WorkFlowEN.WorkFlowId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objwf_WorkFlowEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objwf_WorkFlowEN. CheckUniqueness_WorkFlowName_PrjId() == false)
{
strMsg = string.Format("(工作流名称(WorkFlowName)=[{0}],工程ID(PrjId)=[{1}])已经存在，不能重复!", objwf_WorkFlowEN.WorkFlowName, objwf_WorkFlowEN.PrjId);
throw new Exception(strMsg);
}
//因为是字符型自增主键，所以在添加时，自动获取主键值。
 if (string.IsNullOrEmpty(objwf_WorkFlowEN.WorkFlowId) == true || clswf_WorkFlowBL.IsExist(objwf_WorkFlowEN.WorkFlowId) == true)
 {
     objwf_WorkFlowEN.WorkFlowId = clswf_WorkFlowBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objwf_WorkFlowEN.AddNewRecord();
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
 /// <param name = "objwf_WorkFlowEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clswf_WorkFlowEN objwf_WorkFlowEN)
{
if (CheckUniqueness_WorkFlowName_PrjId(objwf_WorkFlowEN) == false)
{
var strMsg = string.Format("记录已经存在!工作流名称 = [{0}],工程ID = [{1}]的数据已经存在!(in clswf_WorkFlowBL.AddNewRecordWithMaxId)", objwf_WorkFlowEN.WorkFlowName,objwf_WorkFlowEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objwf_WorkFlowEN.WorkFlowId) == true || clswf_WorkFlowBL.IsExist(objwf_WorkFlowEN.WorkFlowId) == true)
 {
     objwf_WorkFlowEN.WorkFlowId = clswf_WorkFlowBL.GetMaxStrId_S();
 }
string strWorkFlowId = clswf_WorkFlowBL.wf_WorkFlowDA.AddNewRecordBySQL2WithReturnKey(objwf_WorkFlowEN);
     objwf_WorkFlowEN.WorkFlowId = strWorkFlowId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_WorkFlowBL.ReFreshCache();

if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(objwf_WorkFlowEN.WorkFlowId, "SetUpdDate");
}
return strWorkFlowId;
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
 /// <param name = "objwf_WorkFlowEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clswf_WorkFlowEN objwf_WorkFlowEN)
{
if (CheckUniqueness_WorkFlowName_PrjId(objwf_WorkFlowEN) == false)
{
var strMsg = string.Format("记录已经存在!工作流名称 = [{0}],工程ID = [{1}]的数据已经存在!(in clswf_WorkFlowBL.AddNewRecordWithReturnKey)", objwf_WorkFlowEN.WorkFlowName,objwf_WorkFlowEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objwf_WorkFlowEN.WorkFlowId) == true || clswf_WorkFlowBL.IsExist(objwf_WorkFlowEN.WorkFlowId) == true)
 {
     objwf_WorkFlowEN.WorkFlowId = clswf_WorkFlowBL.GetMaxStrId_S();
 }
string strKey = clswf_WorkFlowBL.wf_WorkFlowDA.AddNewRecordBySQL2WithReturnKey(objwf_WorkFlowEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_WorkFlowBL.ReFreshCache();

if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(objwf_WorkFlowEN.WorkFlowId, "SetUpdDate");
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
 /// <param name = "objwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_WorkFlowEN SetWorkFlowId(this clswf_WorkFlowEN objwf_WorkFlowEN, string strWorkFlowId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkFlowId, 4, conwf_WorkFlow.WorkFlowId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWorkFlowId, 4, conwf_WorkFlow.WorkFlowId);
}
objwf_WorkFlowEN.WorkFlowId = strWorkFlowId; //工作流Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(conwf_WorkFlow.WorkFlowId) == false)
{
objwf_WorkFlowEN.dicFldComparisonOp.Add(conwf_WorkFlow.WorkFlowId, strComparisonOp);
}
else
{
objwf_WorkFlowEN.dicFldComparisonOp[conwf_WorkFlow.WorkFlowId] = strComparisonOp;
}
}
return objwf_WorkFlowEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_WorkFlowEN SetWorkFlowName(this clswf_WorkFlowEN objwf_WorkFlowEN, string strWorkFlowName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkFlowName, conwf_WorkFlow.WorkFlowName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkFlowName, 50, conwf_WorkFlow.WorkFlowName);
}
objwf_WorkFlowEN.WorkFlowName = strWorkFlowName; //工作流名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(conwf_WorkFlow.WorkFlowName) == false)
{
objwf_WorkFlowEN.dicFldComparisonOp.Add(conwf_WorkFlow.WorkFlowName, strComparisonOp);
}
else
{
objwf_WorkFlowEN.dicFldComparisonOp[conwf_WorkFlow.WorkFlowName] = strComparisonOp;
}
}
return objwf_WorkFlowEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_WorkFlowEN SetWorkFlowNameSim(this clswf_WorkFlowEN objwf_WorkFlowEN, string strWorkFlowNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkFlowNameSim, 30, conwf_WorkFlow.WorkFlowNameSim);
}
objwf_WorkFlowEN.WorkFlowNameSim = strWorkFlowNameSim; //工作流简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(conwf_WorkFlow.WorkFlowNameSim) == false)
{
objwf_WorkFlowEN.dicFldComparisonOp.Add(conwf_WorkFlow.WorkFlowNameSim, strComparisonOp);
}
else
{
objwf_WorkFlowEN.dicFldComparisonOp[conwf_WorkFlow.WorkFlowNameSim] = strComparisonOp;
}
}
return objwf_WorkFlowEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_WorkFlowEN SetIsCurrentUse(this clswf_WorkFlowEN objwf_WorkFlowEN, bool bolIsCurrentUse, string strComparisonOp="")
	{
objwf_WorkFlowEN.IsCurrentUse = bolIsCurrentUse; //是否当前使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(conwf_WorkFlow.IsCurrentUse) == false)
{
objwf_WorkFlowEN.dicFldComparisonOp.Add(conwf_WorkFlow.IsCurrentUse, strComparisonOp);
}
else
{
objwf_WorkFlowEN.dicFldComparisonOp[conwf_WorkFlow.IsCurrentUse] = strComparisonOp;
}
}
return objwf_WorkFlowEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_WorkFlowEN SetPrjId(this clswf_WorkFlowEN objwf_WorkFlowEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conwf_WorkFlow.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conwf_WorkFlow.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conwf_WorkFlow.PrjId);
}
objwf_WorkFlowEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(conwf_WorkFlow.PrjId) == false)
{
objwf_WorkFlowEN.dicFldComparisonOp.Add(conwf_WorkFlow.PrjId, strComparisonOp);
}
else
{
objwf_WorkFlowEN.dicFldComparisonOp[conwf_WorkFlow.PrjId] = strComparisonOp;
}
}
return objwf_WorkFlowEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_WorkFlowEN SetUpdDate(this clswf_WorkFlowEN objwf_WorkFlowEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conwf_WorkFlow.UpdDate);
}
objwf_WorkFlowEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(conwf_WorkFlow.UpdDate) == false)
{
objwf_WorkFlowEN.dicFldComparisonOp.Add(conwf_WorkFlow.UpdDate, strComparisonOp);
}
else
{
objwf_WorkFlowEN.dicFldComparisonOp[conwf_WorkFlow.UpdDate] = strComparisonOp;
}
}
return objwf_WorkFlowEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_WorkFlowEN SetUpdUser(this clswf_WorkFlowEN objwf_WorkFlowEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conwf_WorkFlow.UpdUser);
}
objwf_WorkFlowEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(conwf_WorkFlow.UpdUser) == false)
{
objwf_WorkFlowEN.dicFldComparisonOp.Add(conwf_WorkFlow.UpdUser, strComparisonOp);
}
else
{
objwf_WorkFlowEN.dicFldComparisonOp[conwf_WorkFlow.UpdUser] = strComparisonOp;
}
}
return objwf_WorkFlowEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clswf_WorkFlowEN SetMemo(this clswf_WorkFlowEN objwf_WorkFlowEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conwf_WorkFlow.Memo);
}
objwf_WorkFlowEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objwf_WorkFlowEN.dicFldComparisonOp.ContainsKey(conwf_WorkFlow.Memo) == false)
{
objwf_WorkFlowEN.dicFldComparisonOp.Add(conwf_WorkFlow.Memo, strComparisonOp);
}
else
{
objwf_WorkFlowEN.dicFldComparisonOp[conwf_WorkFlow.Memo] = strComparisonOp;
}
}
return objwf_WorkFlowEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clswf_WorkFlowEN objwf_WorkFlowEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objwf_WorkFlowEN.CheckPropertyNew();
clswf_WorkFlowEN objwf_WorkFlowCond = new clswf_WorkFlowEN();
string strCondition = objwf_WorkFlowCond
.SetWorkFlowId(objwf_WorkFlowEN.WorkFlowId, "<>")
.SetWorkFlowName(objwf_WorkFlowEN.WorkFlowName, "=")
.SetPrjId(objwf_WorkFlowEN.PrjId, "=")
.GetCombineCondition();
objwf_WorkFlowEN._IsCheckProperty = true;
bool bolIsExist = clswf_WorkFlowBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(WorkFlowName_PrjId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objwf_WorkFlowEN.Update();
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
 /// <param name = "objwf_WorkFlow">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clswf_WorkFlowEN objwf_WorkFlow)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clswf_WorkFlowEN objwf_WorkFlowCond = new clswf_WorkFlowEN();
string strCondition = objwf_WorkFlowCond
.SetWorkFlowName(objwf_WorkFlow.WorkFlowName, "=")
.SetPrjId(objwf_WorkFlow.PrjId, "=")
.GetCombineCondition();
objwf_WorkFlow._IsCheckProperty = true;
bool bolIsExist = clswf_WorkFlowBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objwf_WorkFlow.WorkFlowId = clswf_WorkFlowBL.GetFirstID_S(strCondition);
objwf_WorkFlow.UpdateWithCondition(strCondition);
}
else
{
objwf_WorkFlow.WorkFlowId = clswf_WorkFlowBL.GetMaxStrId_S();
objwf_WorkFlow.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clswf_WorkFlowEN objwf_WorkFlowEN)
{
 if (string.IsNullOrEmpty(objwf_WorkFlowEN.WorkFlowId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clswf_WorkFlowBL.wf_WorkFlowDA.UpdateBySql2(objwf_WorkFlowEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_WorkFlowBL.ReFreshCache();

if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(objwf_WorkFlowEN.WorkFlowId, "SetUpdDate");
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
 /// <param name = "objwf_WorkFlowEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clswf_WorkFlowEN objwf_WorkFlowEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objwf_WorkFlowEN.WorkFlowId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clswf_WorkFlowBL.wf_WorkFlowDA.UpdateBySql2(objwf_WorkFlowEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_WorkFlowBL.ReFreshCache();

if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(objwf_WorkFlowEN.WorkFlowId, "SetUpdDate");
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
 /// <param name = "objwf_WorkFlowEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clswf_WorkFlowEN objwf_WorkFlowEN, string strWhereCond)
{
try
{
bool bolResult = clswf_WorkFlowBL.wf_WorkFlowDA.UpdateBySqlWithCondition(objwf_WorkFlowEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_WorkFlowBL.ReFreshCache();

if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(objwf_WorkFlowEN.WorkFlowId, "SetUpdDate");
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
 /// <param name = "objwf_WorkFlowEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clswf_WorkFlowEN objwf_WorkFlowEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clswf_WorkFlowBL.wf_WorkFlowDA.UpdateBySqlWithConditionTransaction(objwf_WorkFlowEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_WorkFlowBL.ReFreshCache();

if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(objwf_WorkFlowEN.WorkFlowId, "SetUpdDate");
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
 /// <param name = "strWorkFlowId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clswf_WorkFlowEN objwf_WorkFlowEN)
{
try
{
int intRecNum = clswf_WorkFlowBL.wf_WorkFlowDA.DelRecord(objwf_WorkFlowEN.WorkFlowId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_WorkFlowBL.ReFreshCache();

if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(objwf_WorkFlowEN.WorkFlowId, "SetUpdDate");
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
 /// <param name = "objwf_WorkFlowENS">源对象</param>
 /// <param name = "objwf_WorkFlowENT">目标对象</param>
 public static void CopyTo(this clswf_WorkFlowEN objwf_WorkFlowENS, clswf_WorkFlowEN objwf_WorkFlowENT)
{
try
{
objwf_WorkFlowENT.WorkFlowId = objwf_WorkFlowENS.WorkFlowId; //工作流Id
objwf_WorkFlowENT.WorkFlowName = objwf_WorkFlowENS.WorkFlowName; //工作流名称
objwf_WorkFlowENT.WorkFlowNameSim = objwf_WorkFlowENS.WorkFlowNameSim; //工作流简称
objwf_WorkFlowENT.IsCurrentUse = objwf_WorkFlowENS.IsCurrentUse; //是否当前使用
objwf_WorkFlowENT.PrjId = objwf_WorkFlowENS.PrjId; //工程ID
objwf_WorkFlowENT.UpdDate = objwf_WorkFlowENS.UpdDate; //修改日期
objwf_WorkFlowENT.UpdUser = objwf_WorkFlowENS.UpdUser; //修改者
objwf_WorkFlowENT.Memo = objwf_WorkFlowENS.Memo; //说明
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
 /// <param name = "objwf_WorkFlowENS">源对象</param>
 /// <returns>目标对象=>clswf_WorkFlowEN:objwf_WorkFlowENT</returns>
 public static clswf_WorkFlowEN CopyTo(this clswf_WorkFlowEN objwf_WorkFlowENS)
{
try
{
 clswf_WorkFlowEN objwf_WorkFlowENT = new clswf_WorkFlowEN()
{
WorkFlowId = objwf_WorkFlowENS.WorkFlowId, //工作流Id
WorkFlowName = objwf_WorkFlowENS.WorkFlowName, //工作流名称
WorkFlowNameSim = objwf_WorkFlowENS.WorkFlowNameSim, //工作流简称
IsCurrentUse = objwf_WorkFlowENS.IsCurrentUse, //是否当前使用
PrjId = objwf_WorkFlowENS.PrjId, //工程ID
UpdDate = objwf_WorkFlowENS.UpdDate, //修改日期
UpdUser = objwf_WorkFlowENS.UpdUser, //修改者
Memo = objwf_WorkFlowENS.Memo, //说明
};
 return objwf_WorkFlowENT;
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
public static void CheckPropertyNew(this clswf_WorkFlowEN objwf_WorkFlowEN)
{
 clswf_WorkFlowBL.wf_WorkFlowDA.CheckPropertyNew(objwf_WorkFlowEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clswf_WorkFlowEN objwf_WorkFlowEN)
{
 clswf_WorkFlowBL.wf_WorkFlowDA.CheckProperty4Condition(objwf_WorkFlowEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clswf_WorkFlowEN objwf_WorkFlowCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objwf_WorkFlowCond.IsUpdated(conwf_WorkFlow.WorkFlowId) == true)
{
string strComparisonOpWorkFlowId = objwf_WorkFlowCond.dicFldComparisonOp[conwf_WorkFlow.WorkFlowId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_WorkFlow.WorkFlowId, objwf_WorkFlowCond.WorkFlowId, strComparisonOpWorkFlowId);
}
if (objwf_WorkFlowCond.IsUpdated(conwf_WorkFlow.WorkFlowName) == true)
{
string strComparisonOpWorkFlowName = objwf_WorkFlowCond.dicFldComparisonOp[conwf_WorkFlow.WorkFlowName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_WorkFlow.WorkFlowName, objwf_WorkFlowCond.WorkFlowName, strComparisonOpWorkFlowName);
}
if (objwf_WorkFlowCond.IsUpdated(conwf_WorkFlow.WorkFlowNameSim) == true)
{
string strComparisonOpWorkFlowNameSim = objwf_WorkFlowCond.dicFldComparisonOp[conwf_WorkFlow.WorkFlowNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_WorkFlow.WorkFlowNameSim, objwf_WorkFlowCond.WorkFlowNameSim, strComparisonOpWorkFlowNameSim);
}
if (objwf_WorkFlowCond.IsUpdated(conwf_WorkFlow.IsCurrentUse) == true)
{
if (objwf_WorkFlowCond.IsCurrentUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conwf_WorkFlow.IsCurrentUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conwf_WorkFlow.IsCurrentUse);
}
}
if (objwf_WorkFlowCond.IsUpdated(conwf_WorkFlow.PrjId) == true)
{
string strComparisonOpPrjId = objwf_WorkFlowCond.dicFldComparisonOp[conwf_WorkFlow.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_WorkFlow.PrjId, objwf_WorkFlowCond.PrjId, strComparisonOpPrjId);
}
if (objwf_WorkFlowCond.IsUpdated(conwf_WorkFlow.UpdDate) == true)
{
string strComparisonOpUpdDate = objwf_WorkFlowCond.dicFldComparisonOp[conwf_WorkFlow.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_WorkFlow.UpdDate, objwf_WorkFlowCond.UpdDate, strComparisonOpUpdDate);
}
if (objwf_WorkFlowCond.IsUpdated(conwf_WorkFlow.UpdUser) == true)
{
string strComparisonOpUpdUser = objwf_WorkFlowCond.dicFldComparisonOp[conwf_WorkFlow.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_WorkFlow.UpdUser, objwf_WorkFlowCond.UpdUser, strComparisonOpUpdUser);
}
if (objwf_WorkFlowCond.IsUpdated(conwf_WorkFlow.Memo) == true)
{
string strComparisonOpMemo = objwf_WorkFlowCond.dicFldComparisonOp[conwf_WorkFlow.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conwf_WorkFlow.Memo, objwf_WorkFlowCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--wf_WorkFlow(工作流), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness_WorkFlowName_PrjId(this clswf_WorkFlowEN objwf_WorkFlowEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objwf_WorkFlowEN == null) return true;
if (objwf_WorkFlowEN.WorkFlowId == null || objwf_WorkFlowEN.WorkFlowId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and WorkFlowName = '{0}'", objwf_WorkFlowEN.WorkFlowName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objwf_WorkFlowEN.PrjId);
if (clswf_WorkFlowBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("WorkFlowId !=  '{0}'", objwf_WorkFlowEN.WorkFlowId);
 sbCondition.AppendFormat(" and WorkFlowName = '{0}'", objwf_WorkFlowEN.WorkFlowName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objwf_WorkFlowEN.PrjId);
if (clswf_WorkFlowBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 检查唯一性(Uniqueness)--wf_WorkFlow(工作流), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrWorkFlowName_PrjId(this clswf_WorkFlowEN objwf_WorkFlowEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objwf_WorkFlowEN == null) return "";
if (objwf_WorkFlowEN.WorkFlowId == null || objwf_WorkFlowEN.WorkFlowId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and WorkFlowName = '{0}'", objwf_WorkFlowEN.WorkFlowName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objwf_WorkFlowEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("WorkFlowId !=  '{0}'", objwf_WorkFlowEN.WorkFlowId);
 sbCondition.AppendFormat(" and WorkFlowName = '{0}'", objwf_WorkFlowEN.WorkFlowName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objwf_WorkFlowEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_wf_WorkFlow
{
public virtual bool UpdRelaTabDate(string strWorkFlowId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 工作流(wf_WorkFlow)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clswf_WorkFlowBL
{
public static RelatedActions_wf_WorkFlow relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "wf_WorkFlowListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "wf_WorkFlowList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clswf_WorkFlowEN> arrwf_WorkFlowObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clswf_WorkFlowDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clswf_WorkFlowDA wf_WorkFlowDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clswf_WorkFlowDA();
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
 public clswf_WorkFlowBL()
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
if (string.IsNullOrEmpty(clswf_WorkFlowEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clswf_WorkFlowEN._ConnectString);
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
objDS = wf_WorkFlowDA.GetDataSet(strWhereCond);
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
objDS = wf_WorkFlowDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = wf_WorkFlowDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_wf_WorkFlow(string strWhereCond)
{
DataTable objDT;
try
{
objDT = wf_WorkFlowDA.GetDataTable_wf_WorkFlow(strWhereCond);
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
objDT = wf_WorkFlowDA.GetDataTable(strWhereCond);
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
objDT = wf_WorkFlowDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = wf_WorkFlowDA.GetDataTable(strWhereCond, strTabName);
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
objDT = wf_WorkFlowDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = wf_WorkFlowDA.GetDataTable_Top(objTopPara);
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
objDT = wf_WorkFlowDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = wf_WorkFlowDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = wf_WorkFlowDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = wf_WorkFlowDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = wf_WorkFlowDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = wf_WorkFlowDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = wf_WorkFlowDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = wf_WorkFlowDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrWorkFlowIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clswf_WorkFlowEN> GetObjLstByWorkFlowIdLst(List<string> arrWorkFlowIdLst)
{
List<clswf_WorkFlowEN> arrObjLst = new List<clswf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrWorkFlowIdLst, true);
 string strWhereCond = string.Format("WorkFlowId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_WorkFlowEN objwf_WorkFlowEN = new clswf_WorkFlowEN();
try
{
objwf_WorkFlowEN.WorkFlowId = objRow[conwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objwf_WorkFlowEN.WorkFlowName = objRow[conwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objwf_WorkFlowEN.WorkFlowNameSim = objRow[conwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[conwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
objwf_WorkFlowEN.PrjId = objRow[conwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objwf_WorkFlowEN.UpdDate = objRow[conwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objwf_WorkFlowEN.UpdUser = objRow[conwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objwf_WorkFlowEN.Memo = objRow[conwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[conwf_WorkFlow.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_WorkFlowEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrWorkFlowIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clswf_WorkFlowEN> GetObjLstByWorkFlowIdLstCache(List<string> arrWorkFlowIdLst)
{
string strKey = string.Format("{0}", clswf_WorkFlowEN._CurrTabName);
List<clswf_WorkFlowEN> arrwf_WorkFlowObjLstCache = GetObjLstCache();
IEnumerable <clswf_WorkFlowEN> arrwf_WorkFlowObjLst_Sel =
arrwf_WorkFlowObjLstCache
.Where(x => arrWorkFlowIdLst.Contains(x.WorkFlowId));
return arrwf_WorkFlowObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_WorkFlowEN> GetObjLst(string strWhereCond)
{
List<clswf_WorkFlowEN> arrObjLst = new List<clswf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_WorkFlowEN objwf_WorkFlowEN = new clswf_WorkFlowEN();
try
{
objwf_WorkFlowEN.WorkFlowId = objRow[conwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objwf_WorkFlowEN.WorkFlowName = objRow[conwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objwf_WorkFlowEN.WorkFlowNameSim = objRow[conwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[conwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
objwf_WorkFlowEN.PrjId = objRow[conwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objwf_WorkFlowEN.UpdDate = objRow[conwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objwf_WorkFlowEN.UpdUser = objRow[conwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objwf_WorkFlowEN.Memo = objRow[conwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[conwf_WorkFlow.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_WorkFlowEN);
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
public static List<clswf_WorkFlowEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clswf_WorkFlowEN> arrObjLst = new List<clswf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_WorkFlowEN objwf_WorkFlowEN = new clswf_WorkFlowEN();
try
{
objwf_WorkFlowEN.WorkFlowId = objRow[conwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objwf_WorkFlowEN.WorkFlowName = objRow[conwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objwf_WorkFlowEN.WorkFlowNameSim = objRow[conwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[conwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
objwf_WorkFlowEN.PrjId = objRow[conwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objwf_WorkFlowEN.UpdDate = objRow[conwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objwf_WorkFlowEN.UpdUser = objRow[conwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objwf_WorkFlowEN.Memo = objRow[conwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[conwf_WorkFlow.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_WorkFlowEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objwf_WorkFlowCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clswf_WorkFlowEN> GetSubObjLstCache(clswf_WorkFlowEN objwf_WorkFlowCond)
{
List<clswf_WorkFlowEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clswf_WorkFlowEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conwf_WorkFlow.AttributeName)
{
if (objwf_WorkFlowCond.IsUpdated(strFldName) == false) continue;
if (objwf_WorkFlowCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_WorkFlowCond[strFldName].ToString());
}
else
{
if (objwf_WorkFlowCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objwf_WorkFlowCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_WorkFlowCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objwf_WorkFlowCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objwf_WorkFlowCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objwf_WorkFlowCond[strFldName]));
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
public static List<clswf_WorkFlowEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clswf_WorkFlowEN> arrObjLst = new List<clswf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_WorkFlowEN objwf_WorkFlowEN = new clswf_WorkFlowEN();
try
{
objwf_WorkFlowEN.WorkFlowId = objRow[conwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objwf_WorkFlowEN.WorkFlowName = objRow[conwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objwf_WorkFlowEN.WorkFlowNameSim = objRow[conwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[conwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
objwf_WorkFlowEN.PrjId = objRow[conwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objwf_WorkFlowEN.UpdDate = objRow[conwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objwf_WorkFlowEN.UpdUser = objRow[conwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objwf_WorkFlowEN.Memo = objRow[conwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[conwf_WorkFlow.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_WorkFlowEN);
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
public static List<clswf_WorkFlowEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clswf_WorkFlowEN> arrObjLst = new List<clswf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_WorkFlowEN objwf_WorkFlowEN = new clswf_WorkFlowEN();
try
{
objwf_WorkFlowEN.WorkFlowId = objRow[conwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objwf_WorkFlowEN.WorkFlowName = objRow[conwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objwf_WorkFlowEN.WorkFlowNameSim = objRow[conwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[conwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
objwf_WorkFlowEN.PrjId = objRow[conwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objwf_WorkFlowEN.UpdDate = objRow[conwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objwf_WorkFlowEN.UpdUser = objRow[conwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objwf_WorkFlowEN.Memo = objRow[conwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[conwf_WorkFlow.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_WorkFlowEN);
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
List<clswf_WorkFlowEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clswf_WorkFlowEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_WorkFlowEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clswf_WorkFlowEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clswf_WorkFlowEN> arrObjLst = new List<clswf_WorkFlowEN>(); 
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
	clswf_WorkFlowEN objwf_WorkFlowEN = new clswf_WorkFlowEN();
try
{
objwf_WorkFlowEN.WorkFlowId = objRow[conwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objwf_WorkFlowEN.WorkFlowName = objRow[conwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objwf_WorkFlowEN.WorkFlowNameSim = objRow[conwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[conwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
objwf_WorkFlowEN.PrjId = objRow[conwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objwf_WorkFlowEN.UpdDate = objRow[conwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objwf_WorkFlowEN.UpdUser = objRow[conwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objwf_WorkFlowEN.Memo = objRow[conwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[conwf_WorkFlow.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_WorkFlowEN);
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
public static List<clswf_WorkFlowEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clswf_WorkFlowEN> arrObjLst = new List<clswf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_WorkFlowEN objwf_WorkFlowEN = new clswf_WorkFlowEN();
try
{
objwf_WorkFlowEN.WorkFlowId = objRow[conwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objwf_WorkFlowEN.WorkFlowName = objRow[conwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objwf_WorkFlowEN.WorkFlowNameSim = objRow[conwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[conwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
objwf_WorkFlowEN.PrjId = objRow[conwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objwf_WorkFlowEN.UpdDate = objRow[conwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objwf_WorkFlowEN.UpdUser = objRow[conwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objwf_WorkFlowEN.Memo = objRow[conwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[conwf_WorkFlow.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_WorkFlowEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clswf_WorkFlowEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clswf_WorkFlowEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clswf_WorkFlowEN> arrObjLst = new List<clswf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_WorkFlowEN objwf_WorkFlowEN = new clswf_WorkFlowEN();
try
{
objwf_WorkFlowEN.WorkFlowId = objRow[conwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objwf_WorkFlowEN.WorkFlowName = objRow[conwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objwf_WorkFlowEN.WorkFlowNameSim = objRow[conwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[conwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
objwf_WorkFlowEN.PrjId = objRow[conwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objwf_WorkFlowEN.UpdDate = objRow[conwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objwf_WorkFlowEN.UpdUser = objRow[conwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objwf_WorkFlowEN.Memo = objRow[conwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[conwf_WorkFlow.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_WorkFlowEN);
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
public static List<clswf_WorkFlowEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clswf_WorkFlowEN> arrObjLst = new List<clswf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_WorkFlowEN objwf_WorkFlowEN = new clswf_WorkFlowEN();
try
{
objwf_WorkFlowEN.WorkFlowId = objRow[conwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objwf_WorkFlowEN.WorkFlowName = objRow[conwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objwf_WorkFlowEN.WorkFlowNameSim = objRow[conwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[conwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
objwf_WorkFlowEN.PrjId = objRow[conwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objwf_WorkFlowEN.UpdDate = objRow[conwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objwf_WorkFlowEN.UpdUser = objRow[conwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objwf_WorkFlowEN.Memo = objRow[conwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[conwf_WorkFlow.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_WorkFlowEN);
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
public static IEnumerable<clswf_WorkFlowEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clswf_WorkFlowEN objwf_WorkFlowCond, string strOrderBy)
{
List<clswf_WorkFlowEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clswf_WorkFlowEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conwf_WorkFlow.AttributeName)
{
if (objwf_WorkFlowCond.IsUpdated(strFldName) == false) continue;
if (objwf_WorkFlowCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_WorkFlowCond[strFldName].ToString());
}
else
{
if (objwf_WorkFlowCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objwf_WorkFlowCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_WorkFlowCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objwf_WorkFlowCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objwf_WorkFlowCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objwf_WorkFlowCond[strFldName]));
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
public static IEnumerable<clswf_WorkFlowEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clswf_WorkFlowEN objwf_WorkFlowCond = JsonConvert.DeserializeObject<clswf_WorkFlowEN>(objPagerPara.whereCond);
if (objwf_WorkFlowCond.sfFldComparisonOp == null)
{
objwf_WorkFlowCond.dicFldComparisonOp = null;
}
else
{
objwf_WorkFlowCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objwf_WorkFlowCond.sfFldComparisonOp);
}
clswf_WorkFlowBL.SetUpdFlag(objwf_WorkFlowCond);
 try
{
CheckProperty4Condition(objwf_WorkFlowCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clswf_WorkFlowBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objwf_WorkFlowCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_WorkFlowEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clswf_WorkFlowEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clswf_WorkFlowEN> arrObjLst = new List<clswf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_WorkFlowEN objwf_WorkFlowEN = new clswf_WorkFlowEN();
try
{
objwf_WorkFlowEN.WorkFlowId = objRow[conwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objwf_WorkFlowEN.WorkFlowName = objRow[conwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objwf_WorkFlowEN.WorkFlowNameSim = objRow[conwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[conwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
objwf_WorkFlowEN.PrjId = objRow[conwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objwf_WorkFlowEN.UpdDate = objRow[conwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objwf_WorkFlowEN.UpdUser = objRow[conwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objwf_WorkFlowEN.Memo = objRow[conwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[conwf_WorkFlow.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_WorkFlowEN);
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
public static List<clswf_WorkFlowEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clswf_WorkFlowEN> arrObjLst = new List<clswf_WorkFlowEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_WorkFlowEN objwf_WorkFlowEN = new clswf_WorkFlowEN();
try
{
objwf_WorkFlowEN.WorkFlowId = objRow[conwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objwf_WorkFlowEN.WorkFlowName = objRow[conwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objwf_WorkFlowEN.WorkFlowNameSim = objRow[conwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[conwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
objwf_WorkFlowEN.PrjId = objRow[conwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objwf_WorkFlowEN.UpdDate = objRow[conwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objwf_WorkFlowEN.UpdUser = objRow[conwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objwf_WorkFlowEN.Memo = objRow[conwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[conwf_WorkFlow.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_WorkFlowEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clswf_WorkFlowEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clswf_WorkFlowEN> arrObjLst = new List<clswf_WorkFlowEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_WorkFlowEN objwf_WorkFlowEN = new clswf_WorkFlowEN();
try
{
objwf_WorkFlowEN.WorkFlowId = objRow[conwf_WorkFlow.WorkFlowId].ToString().Trim(); //工作流Id
objwf_WorkFlowEN.WorkFlowName = objRow[conwf_WorkFlow.WorkFlowName].ToString().Trim(); //工作流名称
objwf_WorkFlowEN.WorkFlowNameSim = objRow[conwf_WorkFlow.WorkFlowNameSim] == DBNull.Value ? null : objRow[conwf_WorkFlow.WorkFlowNameSim].ToString().Trim(); //工作流简称
objwf_WorkFlowEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[conwf_WorkFlow.IsCurrentUse].ToString().Trim()); //是否当前使用
objwf_WorkFlowEN.PrjId = objRow[conwf_WorkFlow.PrjId].ToString().Trim(); //工程ID
objwf_WorkFlowEN.UpdDate = objRow[conwf_WorkFlow.UpdDate] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdDate].ToString().Trim(); //修改日期
objwf_WorkFlowEN.UpdUser = objRow[conwf_WorkFlow.UpdUser] == DBNull.Value ? null : objRow[conwf_WorkFlow.UpdUser].ToString().Trim(); //修改者
objwf_WorkFlowEN.Memo = objRow[conwf_WorkFlow.Memo] == DBNull.Value ? null : objRow[conwf_WorkFlow.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objwf_WorkFlowEN.WorkFlowId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objwf_WorkFlowEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getwf_WorkFlow(ref clswf_WorkFlowEN objwf_WorkFlowEN)
{
bool bolResult = wf_WorkFlowDA.Getwf_WorkFlow(ref objwf_WorkFlowEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strWorkFlowId">表关键字</param>
 /// <returns>表对象</returns>
public static clswf_WorkFlowEN GetObjByWorkFlowId(string strWorkFlowId)
{
if (strWorkFlowId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strWorkFlowId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strWorkFlowId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strWorkFlowId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clswf_WorkFlowEN objwf_WorkFlowEN = wf_WorkFlowDA.GetObjByWorkFlowId(strWorkFlowId);
return objwf_WorkFlowEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clswf_WorkFlowEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clswf_WorkFlowEN objwf_WorkFlowEN = wf_WorkFlowDA.GetFirstObj(strWhereCond);
 return objwf_WorkFlowEN;
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
public static clswf_WorkFlowEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clswf_WorkFlowEN objwf_WorkFlowEN = wf_WorkFlowDA.GetObjByDataRow(objRow);
 return objwf_WorkFlowEN;
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
public static clswf_WorkFlowEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clswf_WorkFlowEN objwf_WorkFlowEN = wf_WorkFlowDA.GetObjByDataRow(objRow);
 return objwf_WorkFlowEN;
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
 /// <param name = "strWorkFlowId">所给的关键字</param>
 /// <param name = "lstwf_WorkFlowObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clswf_WorkFlowEN GetObjByWorkFlowIdFromList(string strWorkFlowId, List<clswf_WorkFlowEN> lstwf_WorkFlowObjLst)
{
foreach (clswf_WorkFlowEN objwf_WorkFlowEN in lstwf_WorkFlowObjLst)
{
if (objwf_WorkFlowEN.WorkFlowId == strWorkFlowId)
{
return objwf_WorkFlowEN;
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
 string strMaxWorkFlowId;
 try
 {
 strMaxWorkFlowId = clswf_WorkFlowDA.GetMaxStrId();
 return strMaxWorkFlowId;
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
 string strWorkFlowId;
 try
 {
 strWorkFlowId = new clswf_WorkFlowDA().GetFirstID(strWhereCond);
 return strWorkFlowId;
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
 arrList = wf_WorkFlowDA.GetID(strWhereCond);
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
bool bolIsExist = wf_WorkFlowDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strWorkFlowId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strWorkFlowId)
{
if (string.IsNullOrEmpty(strWorkFlowId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strWorkFlowId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = wf_WorkFlowDA.IsExist(strWorkFlowId);
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
 bolIsExist = clswf_WorkFlowDA.IsExistTable();
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
 bolIsExist = wf_WorkFlowDA.IsExistTable(strTabName);
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
 /// <param name = "objwf_WorkFlowEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clswf_WorkFlowEN objwf_WorkFlowEN)
{
if (objwf_WorkFlowEN.CheckUniqueness_WorkFlowName_PrjId() == false)
{
var strMsg = string.Format("记录已经存在!工作流名称 = [{0}],工程ID = [{1}]的数据已经存在!(in clswf_WorkFlowBL.AddNewRecordBySql2)", objwf_WorkFlowEN.WorkFlowName,objwf_WorkFlowEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objwf_WorkFlowEN.WorkFlowId) == true || clswf_WorkFlowBL.IsExist(objwf_WorkFlowEN.WorkFlowId) == true)
 {
     objwf_WorkFlowEN.WorkFlowId = clswf_WorkFlowBL.GetMaxStrId_S();
 }
bool bolResult = wf_WorkFlowDA.AddNewRecordBySQL2(objwf_WorkFlowEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_WorkFlowBL.ReFreshCache();

if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(objwf_WorkFlowEN.WorkFlowId, "SetUpdDate");
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
 /// <param name = "objwf_WorkFlowEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clswf_WorkFlowEN objwf_WorkFlowEN)
{
if (objwf_WorkFlowEN.CheckUniqueness_WorkFlowName_PrjId() == false)
{
var strMsg = string.Format("记录已经存在!工作流名称 = [{0}],工程ID = [{1}]的数据已经存在!(in clswf_WorkFlowBL.AddNewRecordBySql2WithReturnKey)", objwf_WorkFlowEN.WorkFlowName,objwf_WorkFlowEN.PrjId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objwf_WorkFlowEN.WorkFlowId) == true || clswf_WorkFlowBL.IsExist(objwf_WorkFlowEN.WorkFlowId) == true)
 {
     objwf_WorkFlowEN.WorkFlowId = clswf_WorkFlowBL.GetMaxStrId_S();
 }
string strKey = wf_WorkFlowDA.AddNewRecordBySQL2WithReturnKey(objwf_WorkFlowEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_WorkFlowBL.ReFreshCache();

if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(objwf_WorkFlowEN.WorkFlowId, "SetUpdDate");
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
 /// <param name = "strwf_WorkFlowObjXml">代表实体对象的XML串</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql_XML(string strwf_WorkFlowObjXml)
{
clswf_WorkFlowEN objwf_WorkFlowEN = GetObjFromXmlStr(strwf_WorkFlowObjXml);
try
{
bool bolResult = wf_WorkFlowDA.AddNewRecordBySQL2(objwf_WorkFlowEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_WorkFlowBL.ReFreshCache();

if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(objwf_WorkFlowEN.WorkFlowId, "SetUpdDate");
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
 /// <param name = "objwf_WorkFlowEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clswf_WorkFlowEN objwf_WorkFlowEN)
{
try
{
bool bolResult = wf_WorkFlowDA.Update(objwf_WorkFlowEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_WorkFlowBL.ReFreshCache();

if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(objwf_WorkFlowEN.WorkFlowId, "SetUpdDate");
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
 /// <param name = "objwf_WorkFlowEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clswf_WorkFlowEN objwf_WorkFlowEN)
{
 if (string.IsNullOrEmpty(objwf_WorkFlowEN.WorkFlowId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = wf_WorkFlowDA.UpdateBySql2(objwf_WorkFlowEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_WorkFlowBL.ReFreshCache();

if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(objwf_WorkFlowEN.WorkFlowId, "SetUpdDate");
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
 /// <param name = "strwf_WorkFlowObjXml">需要修改的对象,用XML来表示</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql_XML(string strwf_WorkFlowObjXml)
{
clswf_WorkFlowEN objwf_WorkFlowEN = GetObjFromXmlStr(strwf_WorkFlowObjXml);
try
{
bool bolResult = wf_WorkFlowDA.UpdateBySql2(objwf_WorkFlowEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clswf_WorkFlowBL.ReFreshCache();

if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(objwf_WorkFlowEN.WorkFlowId, "SetUpdDate");
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
 /// <param name = "strWorkFlowId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strWorkFlowId)
{
try
{
 clswf_WorkFlowEN objwf_WorkFlowEN = clswf_WorkFlowBL.GetObjByWorkFlowId(strWorkFlowId);

if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(objwf_WorkFlowEN.WorkFlowId, "SetUpdDate");
}
if (objwf_WorkFlowEN != null)
{
int intRecNum = wf_WorkFlowDA.DelRecord(strWorkFlowId);
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
/// <param name="strWorkFlowId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strWorkFlowId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clswf_WorkFlowDA.GetSpecSQLObj();
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
//删除与表:[wf_WorkFlow]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conwf_WorkFlow.WorkFlowId,
//strWorkFlowId);
//        clswf_WorkFlowBL.Delwf_WorkFlowsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clswf_WorkFlowBL.DelRecord(strWorkFlowId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clswf_WorkFlowBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strWorkFlowId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strWorkFlowId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strWorkFlowId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(strWorkFlowId, "UpdRelaTabDate");
}
bool bolResult = wf_WorkFlowDA.DelRecord(strWorkFlowId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "strWorkFlowId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strWorkFlowId) 
{
try
{
if (clswf_WorkFlowBL.relatedActions != null)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(strWorkFlowId, "UpdRelaTabDate");
}
bool bolResult = wf_WorkFlowDA.DelRecordBySP(strWorkFlowId);
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
 /// <param name = "arrWorkFlowIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delwf_WorkFlows(List<string> arrWorkFlowIdLst)
{
if (arrWorkFlowIdLst.Count == 0) return 0;
try
{
if (clswf_WorkFlowBL.relatedActions != null)
{
foreach (var strWorkFlowId in arrWorkFlowIdLst)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(strWorkFlowId, "UpdRelaTabDate");
}
}
int intDelRecNum = wf_WorkFlowDA.Delwf_WorkFlow(arrWorkFlowIdLst);
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
public static int Delwf_WorkFlowsByCond(string strWhereCond)
{
try
{
if (clswf_WorkFlowBL.relatedActions != null)
{
List<string> arrWorkFlowId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strWorkFlowId in arrWorkFlowId)
{
clswf_WorkFlowBL.relatedActions.UpdRelaTabDate(strWorkFlowId, "UpdRelaTabDate");
}
}
int intRecNum = wf_WorkFlowDA.Delwf_WorkFlow(strWhereCond);
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
/// 这里仅仅是演示函数，使用时请复制到扩展类:[wf_WorkFlow]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strWorkFlowId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strWorkFlowId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clswf_WorkFlowDA.GetSpecSQLObj();
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
//删除与表:[wf_WorkFlow]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clswf_WorkFlowBL.DelRecord(strWorkFlowId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clswf_WorkFlowBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strWorkFlowId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objwf_WorkFlowENS">源对象</param>
 /// <param name = "objwf_WorkFlowENT">目标对象</param>
 public static void CopyTo(clswf_WorkFlowEN objwf_WorkFlowENS, clswf_WorkFlowEN objwf_WorkFlowENT)
{
try
{
objwf_WorkFlowENT.WorkFlowId = objwf_WorkFlowENS.WorkFlowId; //工作流Id
objwf_WorkFlowENT.WorkFlowName = objwf_WorkFlowENS.WorkFlowName; //工作流名称
objwf_WorkFlowENT.WorkFlowNameSim = objwf_WorkFlowENS.WorkFlowNameSim; //工作流简称
objwf_WorkFlowENT.IsCurrentUse = objwf_WorkFlowENS.IsCurrentUse; //是否当前使用
objwf_WorkFlowENT.PrjId = objwf_WorkFlowENS.PrjId; //工程ID
objwf_WorkFlowENT.UpdDate = objwf_WorkFlowENS.UpdDate; //修改日期
objwf_WorkFlowENT.UpdUser = objwf_WorkFlowENS.UpdUser; //修改者
objwf_WorkFlowENT.Memo = objwf_WorkFlowENS.Memo; //说明
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
 /// <param name = "objwf_WorkFlowEN">源简化对象</param>
 public static void SetUpdFlag(clswf_WorkFlowEN objwf_WorkFlowEN)
{
try
{
objwf_WorkFlowEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objwf_WorkFlowEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conwf_WorkFlow.WorkFlowId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_WorkFlowEN.WorkFlowId = objwf_WorkFlowEN.WorkFlowId; //工作流Id
}
if (arrFldSet.Contains(conwf_WorkFlow.WorkFlowName, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_WorkFlowEN.WorkFlowName = objwf_WorkFlowEN.WorkFlowName; //工作流名称
}
if (arrFldSet.Contains(conwf_WorkFlow.WorkFlowNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_WorkFlowEN.WorkFlowNameSim = objwf_WorkFlowEN.WorkFlowNameSim == "[null]" ? null :  objwf_WorkFlowEN.WorkFlowNameSim; //工作流简称
}
if (arrFldSet.Contains(conwf_WorkFlow.IsCurrentUse, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_WorkFlowEN.IsCurrentUse = objwf_WorkFlowEN.IsCurrentUse; //是否当前使用
}
if (arrFldSet.Contains(conwf_WorkFlow.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_WorkFlowEN.PrjId = objwf_WorkFlowEN.PrjId; //工程ID
}
if (arrFldSet.Contains(conwf_WorkFlow.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_WorkFlowEN.UpdDate = objwf_WorkFlowEN.UpdDate == "[null]" ? null :  objwf_WorkFlowEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conwf_WorkFlow.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_WorkFlowEN.UpdUser = objwf_WorkFlowEN.UpdUser == "[null]" ? null :  objwf_WorkFlowEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conwf_WorkFlow.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objwf_WorkFlowEN.Memo = objwf_WorkFlowEN.Memo == "[null]" ? null :  objwf_WorkFlowEN.Memo; //说明
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
 /// <param name = "objwf_WorkFlowEN">源简化对象</param>
 public static void AccessFldValueNull(clswf_WorkFlowEN objwf_WorkFlowEN)
{
try
{
if (objwf_WorkFlowEN.WorkFlowNameSim == "[null]") objwf_WorkFlowEN.WorkFlowNameSim = null; //工作流简称
if (objwf_WorkFlowEN.UpdDate == "[null]") objwf_WorkFlowEN.UpdDate = null; //修改日期
if (objwf_WorkFlowEN.UpdUser == "[null]") objwf_WorkFlowEN.UpdUser = null; //修改者
if (objwf_WorkFlowEN.Memo == "[null]") objwf_WorkFlowEN.Memo = null; //说明
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
public static void CheckPropertyNew(clswf_WorkFlowEN objwf_WorkFlowEN)
{
 wf_WorkFlowDA.CheckPropertyNew(objwf_WorkFlowEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clswf_WorkFlowEN objwf_WorkFlowEN)
{
 wf_WorkFlowDA.CheckProperty4Condition(objwf_WorkFlowEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_WorkFlowId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conwf_WorkFlow.WorkFlowId); 
List<clswf_WorkFlowEN> arrObjLst = clswf_WorkFlowBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clswf_WorkFlowEN objwf_WorkFlowEN = new clswf_WorkFlowEN()
{
WorkFlowId = "0",
WorkFlowName = "选[工作流]..."
};
arrObjLst.Insert(0, objwf_WorkFlowEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conwf_WorkFlow.WorkFlowId;
objComboBox.DisplayMember = conwf_WorkFlow.WorkFlowName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdlWorkFlowId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工作流]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conwf_WorkFlow.WorkFlowId); 
IEnumerable<clswf_WorkFlowEN> arrObjLst = clswf_WorkFlowBL.GetObjLst(strCondition);
objDDL.DataValueField = conwf_WorkFlow.WorkFlowId;
objDDL.DataTextField = conwf_WorkFlow.WorkFlowName;
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
public static void BindDdlWorkFlowIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工作流]...","0");
List<clswf_WorkFlowEN> arrwf_WorkFlowObjLst = GetAllwf_WorkFlowObjLstCache(); 
objDDL.DataValueField = conwf_WorkFlow.WorkFlowId;
objDDL.DataTextField = conwf_WorkFlow.WorkFlowName;
objDDL.DataSource = arrwf_WorkFlowObjLst;
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
if (clswf_WorkFlowBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_WorkFlowBL没有刷新缓存机制(clswf_WorkFlowBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by WorkFlowId");
//if (arrwf_WorkFlowObjLstCache == null)
//{
//arrwf_WorkFlowObjLstCache = wf_WorkFlowDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strWorkFlowId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clswf_WorkFlowEN GetObjByWorkFlowIdCache(string strWorkFlowId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clswf_WorkFlowEN._CurrTabName);
List<clswf_WorkFlowEN> arrwf_WorkFlowObjLstCache = GetObjLstCache();
IEnumerable <clswf_WorkFlowEN> arrwf_WorkFlowObjLst_Sel =
arrwf_WorkFlowObjLstCache
.Where(x=> x.WorkFlowId == strWorkFlowId 
);
if (arrwf_WorkFlowObjLst_Sel.Count() == 0)
{
   clswf_WorkFlowEN obj = clswf_WorkFlowBL.GetObjByWorkFlowId(strWorkFlowId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrwf_WorkFlowObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strWorkFlowId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetWorkFlowNameByWorkFlowIdCache(string strWorkFlowId)
{
if (string.IsNullOrEmpty(strWorkFlowId) == true) return "";
//获取缓存中的对象列表
clswf_WorkFlowEN objwf_WorkFlow = GetObjByWorkFlowIdCache(strWorkFlowId);
if (objwf_WorkFlow == null) return "";
return objwf_WorkFlow.WorkFlowName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strWorkFlowId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByWorkFlowIdCache(string strWorkFlowId)
{
if (string.IsNullOrEmpty(strWorkFlowId) == true) return "";
//获取缓存中的对象列表
clswf_WorkFlowEN objwf_WorkFlow = GetObjByWorkFlowIdCache(strWorkFlowId);
if (objwf_WorkFlow == null) return "";
return objwf_WorkFlow.WorkFlowName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clswf_WorkFlowEN> GetAllwf_WorkFlowObjLstCache()
{
//获取缓存中的对象列表
List<clswf_WorkFlowEN> arrwf_WorkFlowObjLstCache = GetObjLstCache(); 
return arrwf_WorkFlowObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clswf_WorkFlowEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clswf_WorkFlowEN._CurrTabName);
List<clswf_WorkFlowEN> arrwf_WorkFlowObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrwf_WorkFlowObjLstCache;
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
string strKey = string.Format("{0}", clswf_WorkFlowEN._CurrTabName);
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
if (clswf_WorkFlowBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clswf_WorkFlowEN._CurrTabName);
CacheHelper.Remove(strKey);
clswf_WorkFlowBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--wf_WorkFlow(工作流)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStrWorkFlowName_PrjId(clswf_WorkFlowEN objwf_WorkFlowEN)
{
//检测记录是否存在
string strResult = wf_WorkFlowDA.GetUniCondStrWorkFlowName_PrjId(objwf_WorkFlowEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstwf_WorkFlowObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clswf_WorkFlowEN> lstwf_WorkFlowObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstwf_WorkFlowObjLst, writer);
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
 /// <param name = "lstwf_WorkFlowObjLst">[clswf_WorkFlowEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clswf_WorkFlowEN> lstwf_WorkFlowObjLst, XmlWriter writer)
{
writer.WriteStartElement(clswf_WorkFlowBL.listXmlNode);
writer.WriteStartElement(clswf_WorkFlowBL.itemsXmlNode);
foreach (clswf_WorkFlowEN objwf_WorkFlowEN in lstwf_WorkFlowObjLst)
{
clswf_WorkFlowBL.SerializeXML(writer, objwf_WorkFlowEN);
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
 /// <param name = "objwf_WorkFlowEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clswf_WorkFlowEN objwf_WorkFlowEN)
{
writer.WriteStartElement(clswf_WorkFlowBL.itemXmlNode);
 
if (objwf_WorkFlowEN.WorkFlowId != null)
{
writer.WriteElementString(conwf_WorkFlow.WorkFlowId, objwf_WorkFlowEN.WorkFlowId.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_WorkFlowEN.WorkFlowName != null)
{
writer.WriteElementString(conwf_WorkFlow.WorkFlowName, objwf_WorkFlowEN.WorkFlowName.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_WorkFlowEN.WorkFlowNameSim != null)
{
writer.WriteElementString(conwf_WorkFlow.WorkFlowNameSim, objwf_WorkFlowEN.WorkFlowNameSim.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(conwf_WorkFlow.IsCurrentUse, objwf_WorkFlowEN.IsCurrentUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objwf_WorkFlowEN.PrjId != null)
{
writer.WriteElementString(conwf_WorkFlow.PrjId, objwf_WorkFlowEN.PrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_WorkFlowEN.UpdDate != null)
{
writer.WriteElementString(conwf_WorkFlow.UpdDate, objwf_WorkFlowEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_WorkFlowEN.UpdUser != null)
{
writer.WriteElementString(conwf_WorkFlow.UpdUser, objwf_WorkFlowEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objwf_WorkFlowEN.Memo != null)
{
writer.WriteElementString(conwf_WorkFlow.Memo, objwf_WorkFlowEN.Memo.ToString(CultureInfo.InvariantCulture));
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
public static clswf_WorkFlowEN GetObjFromXml(System.Xml.XmlReader reader)
{
clswf_WorkFlowEN objwf_WorkFlowEN = new clswf_WorkFlowEN();
reader.Read();
while (!(reader.Name == clswf_WorkFlowBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(conwf_WorkFlow.WorkFlowId))
{
objwf_WorkFlowEN.WorkFlowId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_WorkFlow.WorkFlowName))
{
objwf_WorkFlowEN.WorkFlowName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_WorkFlow.WorkFlowNameSim))
{
objwf_WorkFlowEN.WorkFlowNameSim = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_WorkFlow.IsCurrentUse))
{
objwf_WorkFlowEN.IsCurrentUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(conwf_WorkFlow.PrjId))
{
objwf_WorkFlowEN.PrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_WorkFlow.UpdDate))
{
objwf_WorkFlowEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_WorkFlow.UpdUser))
{
objwf_WorkFlowEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(conwf_WorkFlow.Memo))
{
objwf_WorkFlowEN.Memo = reader.ReadElementContentAsString();
}
}
return objwf_WorkFlowEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strwf_WorkFlowObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clswf_WorkFlowEN GetObjFromXmlStr(string strwf_WorkFlowObjXmlStr)
{
clswf_WorkFlowEN objwf_WorkFlowEN = new clswf_WorkFlowEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strwf_WorkFlowObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clswf_WorkFlowBL.itemXmlNode))
{
objwf_WorkFlowEN = GetObjFromXml(reader);
return objwf_WorkFlowEN;
}
}
return objwf_WorkFlowEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clswf_WorkFlowEN objwf_WorkFlowEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objwf_WorkFlowEN);
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
public static string Func(string strInFldName, string strOutFldName, string strWorkFlowId)
{
if (strInFldName != conwf_WorkFlow.WorkFlowId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conwf_WorkFlow.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conwf_WorkFlow.AttributeName));
throw new Exception(strMsg);
}
var objwf_WorkFlow = clswf_WorkFlowBL.GetObjByWorkFlowIdCache(strWorkFlowId);
if (objwf_WorkFlow == null) return "";
return objwf_WorkFlow[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objwf_WorkFlowEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clswf_WorkFlowEN objwf_WorkFlowEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clswf_WorkFlowEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objwf_WorkFlowEN[strField]);
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
 /// <param name = "lstwf_WorkFlowObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clswf_WorkFlowEN> lstwf_WorkFlowObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstwf_WorkFlowObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clswf_WorkFlowEN objwf_WorkFlowEN in lstwf_WorkFlowObjLst)
{
string strJSON_One = SerializeObjToJSON(objwf_WorkFlowEN);
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
int intRecCount = clswf_WorkFlowDA.GetRecCount(strTabName);
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
int intRecCount = clswf_WorkFlowDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clswf_WorkFlowDA.GetRecCount();
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
int intRecCount = clswf_WorkFlowDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objwf_WorkFlowCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clswf_WorkFlowEN objwf_WorkFlowCond)
{
List<clswf_WorkFlowEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clswf_WorkFlowEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conwf_WorkFlow.AttributeName)
{
if (objwf_WorkFlowCond.IsUpdated(strFldName) == false) continue;
if (objwf_WorkFlowCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_WorkFlowCond[strFldName].ToString());
}
else
{
if (objwf_WorkFlowCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objwf_WorkFlowCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objwf_WorkFlowCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objwf_WorkFlowCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objwf_WorkFlowCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objwf_WorkFlowCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objwf_WorkFlowCond[strFldName]));
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
 List<string> arrList = clswf_WorkFlowDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = wf_WorkFlowDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = wf_WorkFlowDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = wf_WorkFlowDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clswf_WorkFlowDA.SetFldValue(clswf_WorkFlowEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = wf_WorkFlowDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clswf_WorkFlowDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clswf_WorkFlowDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clswf_WorkFlowDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[wf_WorkFlow] "); 
 strCreateTabCode.Append(" ( "); 
 // /**工作流Id*/ 
 strCreateTabCode.Append(" WorkFlowId char(4) primary key, "); 
 // /**工作流名称*/ 
 strCreateTabCode.Append(" WorkFlowName varchar(50) not Null, "); 
 // /**工作流简称*/ 
 strCreateTabCode.Append(" WorkFlowNameSim varchar(30) Null, "); 
 // /**是否当前使用*/ 
 strCreateTabCode.Append(" IsCurrentUse bit Null, "); 
 // /**工程ID*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
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
}
 /// <summary>
 /// 工作流(wf_WorkFlow)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4wf_WorkFlow : clsCommFun4BL
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
clswf_WorkFlowBL.ReFreshThisCache();
}
}

}