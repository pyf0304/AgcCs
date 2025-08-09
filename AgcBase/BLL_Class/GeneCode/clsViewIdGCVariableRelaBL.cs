
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewIdGCVariableRelaBL
 表名:ViewIdGCVariableRela(00050631)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsViewIdGCVariableRelaBL_Static
{

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objViewIdGCVariableRelaEN.VarId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (string.IsNullOrEmpty(objViewIdGCVariableRelaEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewIdGCVariableRelaBL.IsExist(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewIdGCVariableRelaEN.VarId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsViewIdGCVariableRelaBL.ViewIdGCVariableRelaDA.AddNewRecordBySQL2(objViewIdGCVariableRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaBL.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);

if (clsViewIdGCVariableRelaBL.relatedActions != null)
{
clsViewIdGCVariableRelaBL.relatedActions.UpdRelaTabDate(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId, objViewIdGCVariableRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsViewIdGCVariableRelaBL.IsExist(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objViewIdGCVariableRelaEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objViewIdGCVariableRelaEN.AddNewRecord();
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
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objViewIdGCVariableRelaEN.VarId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewIdGCVariableRelaBL.IsExist(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewIdGCVariableRelaEN.VarId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsViewIdGCVariableRelaBL.ViewIdGCVariableRelaDA.AddNewRecordBySQL2WithReturnKey(objViewIdGCVariableRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaBL.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);

if (clsViewIdGCVariableRelaBL.relatedActions != null)
{
clsViewIdGCVariableRelaBL.relatedActions.UpdRelaTabDate(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId, objViewIdGCVariableRelaEN.UpdUser);
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
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetIsUseInRegion(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, bool bolIsUseInRegion, string strComparisonOp="")
	{
objViewIdGCVariableRelaEN.IsUseInRegion = bolIsUseInRegion; //是否在区域中使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.IsUseInRegion) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.IsUseInRegion, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.IsUseInRegion] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetVarId(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strVarId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarId, 8, conViewIdGCVariableRela.VarId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarId, 8, conViewIdGCVariableRela.VarId);
}
objViewIdGCVariableRelaEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.VarId) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.VarId, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.VarId] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetViewId(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, conViewIdGCVariableRela.ViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewId, 8, conViewIdGCVariableRela.ViewId);
}
objViewIdGCVariableRelaEN.ViewId = strViewId; //界面Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.ViewId) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.ViewId, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.ViewId] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetRetrievalMethodId(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strRetrievalMethodId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRetrievalMethodId, conViewIdGCVariableRela.RetrievalMethodId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRetrievalMethodId, 2, conViewIdGCVariableRela.RetrievalMethodId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRetrievalMethodId, 2, conViewIdGCVariableRela.RetrievalMethodId);
}
objViewIdGCVariableRelaEN.RetrievalMethodId = strRetrievalMethodId; //获取方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.RetrievalMethodId) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.RetrievalMethodId, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.RetrievalMethodId] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetRegionTypeNames(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strRegionTypeNames, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeNames, 100, conViewIdGCVariableRela.RegionTypeNames);
}
objViewIdGCVariableRelaEN.RegionTypeNames = strRegionTypeNames; //区域类型名s
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.RegionTypeNames) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.RegionTypeNames, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.RegionTypeNames] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetErrMsg(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conViewIdGCVariableRela.ErrMsg);
}
objViewIdGCVariableRelaEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.ErrMsg) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.ErrMsg, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.ErrMsg] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetPrjId(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewIdGCVariableRela.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewIdGCVariableRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewIdGCVariableRela.PrjId);
}
objViewIdGCVariableRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.PrjId) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.PrjId, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.PrjId] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetUpdUser(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conViewIdGCVariableRela.UpdUser);
}
objViewIdGCVariableRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.UpdUser) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.UpdUser, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.UpdUser] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetUpdDate(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewIdGCVariableRela.UpdDate);
}
objViewIdGCVariableRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.UpdDate) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.UpdDate, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.UpdDate] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewIdGCVariableRelaEN SetMemo(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewIdGCVariableRela.Memo);
}
objViewIdGCVariableRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewIdGCVariableRelaEN.dicFldComparisonOp.ContainsKey(conViewIdGCVariableRela.Memo) == false)
{
objViewIdGCVariableRelaEN.dicFldComparisonOp.Add(conViewIdGCVariableRela.Memo, strComparisonOp);
}
else
{
objViewIdGCVariableRelaEN.dicFldComparisonOp[conViewIdGCVariableRela.Memo] = strComparisonOp;
}
}
return objViewIdGCVariableRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objViewIdGCVariableRelaEN.CheckPropertyNew();
clsViewIdGCVariableRelaEN objViewIdGCVariableRelaCond = new clsViewIdGCVariableRelaEN();
string strCondition = objViewIdGCVariableRelaCond
.SetVarId(objViewIdGCVariableRelaEN.VarId, "=")
.GetCombineCondition();
objViewIdGCVariableRelaEN._IsCheckProperty = true;
bool bolIsExist = clsViewIdGCVariableRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objViewIdGCVariableRelaEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
 if (string.IsNullOrEmpty(objViewIdGCVariableRelaEN.VarId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewIdGCVariableRelaBL.ViewIdGCVariableRelaDA.UpdateBySql2(objViewIdGCVariableRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaBL.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);

if (clsViewIdGCVariableRelaBL.relatedActions != null)
{
clsViewIdGCVariableRelaBL.relatedActions.UpdRelaTabDate(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId, objViewIdGCVariableRelaEN.UpdUser);
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
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objViewIdGCVariableRelaEN.VarId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsViewIdGCVariableRelaBL.ViewIdGCVariableRelaDA.UpdateBySql2(objViewIdGCVariableRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaBL.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);

if (clsViewIdGCVariableRelaBL.relatedActions != null)
{
clsViewIdGCVariableRelaBL.relatedActions.UpdRelaTabDate(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId, objViewIdGCVariableRelaEN.UpdUser);
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
 /// <param name = "objViewIdGCVariableRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsViewIdGCVariableRelaBL.ViewIdGCVariableRelaDA.UpdateBySqlWithCondition(objViewIdGCVariableRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaBL.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);

if (clsViewIdGCVariableRelaBL.relatedActions != null)
{
clsViewIdGCVariableRelaBL.relatedActions.UpdRelaTabDate(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId, objViewIdGCVariableRelaEN.UpdUser);
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
 /// <param name = "objViewIdGCVariableRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsViewIdGCVariableRelaBL.ViewIdGCVariableRelaDA.UpdateBySqlWithConditionTransaction(objViewIdGCVariableRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaBL.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);

if (clsViewIdGCVariableRelaBL.relatedActions != null)
{
clsViewIdGCVariableRelaBL.relatedActions.UpdRelaTabDate(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId, objViewIdGCVariableRelaEN.UpdUser);
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
 /// <param name = "strVarId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
try
{
int intRecNum = clsViewIdGCVariableRelaBL.ViewIdGCVariableRelaDA.DelRecord(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaBL.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);

if (clsViewIdGCVariableRelaBL.relatedActions != null)
{
clsViewIdGCVariableRelaBL.relatedActions.UpdRelaTabDate(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId, objViewIdGCVariableRelaEN.UpdUser);
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
 /// <param name = "objViewIdGCVariableRelaENS">源对象</param>
 /// <param name = "objViewIdGCVariableRelaENT">目标对象</param>
 public static void CopyTo(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaENS, clsViewIdGCVariableRelaEN objViewIdGCVariableRelaENT)
{
try
{
objViewIdGCVariableRelaENT.IsUseInRegion = objViewIdGCVariableRelaENS.IsUseInRegion; //是否在区域中使用
objViewIdGCVariableRelaENT.VarId = objViewIdGCVariableRelaENS.VarId; //变量Id
objViewIdGCVariableRelaENT.ViewId = objViewIdGCVariableRelaENS.ViewId; //界面Id
objViewIdGCVariableRelaENT.RetrievalMethodId = objViewIdGCVariableRelaENS.RetrievalMethodId; //获取方式Id
objViewIdGCVariableRelaENT.RegionTypeNames = objViewIdGCVariableRelaENS.RegionTypeNames; //区域类型名s
objViewIdGCVariableRelaENT.ErrMsg = objViewIdGCVariableRelaENS.ErrMsg; //错误信息
objViewIdGCVariableRelaENT.PrjId = objViewIdGCVariableRelaENS.PrjId; //工程Id
objViewIdGCVariableRelaENT.UpdUser = objViewIdGCVariableRelaENS.UpdUser; //修改者
objViewIdGCVariableRelaENT.UpdDate = objViewIdGCVariableRelaENS.UpdDate; //修改日期
objViewIdGCVariableRelaENT.Memo = objViewIdGCVariableRelaENS.Memo; //说明
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
 /// <param name = "objViewIdGCVariableRelaENS">源对象</param>
 /// <returns>目标对象=>clsViewIdGCVariableRelaEN:objViewIdGCVariableRelaENT</returns>
 public static clsViewIdGCVariableRelaEN CopyTo(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaENS)
{
try
{
 clsViewIdGCVariableRelaEN objViewIdGCVariableRelaENT = new clsViewIdGCVariableRelaEN()
{
IsUseInRegion = objViewIdGCVariableRelaENS.IsUseInRegion, //是否在区域中使用
VarId = objViewIdGCVariableRelaENS.VarId, //变量Id
ViewId = objViewIdGCVariableRelaENS.ViewId, //界面Id
RetrievalMethodId = objViewIdGCVariableRelaENS.RetrievalMethodId, //获取方式Id
RegionTypeNames = objViewIdGCVariableRelaENS.RegionTypeNames, //区域类型名s
ErrMsg = objViewIdGCVariableRelaENS.ErrMsg, //错误信息
PrjId = objViewIdGCVariableRelaENS.PrjId, //工程Id
UpdUser = objViewIdGCVariableRelaENS.UpdUser, //修改者
UpdDate = objViewIdGCVariableRelaENS.UpdDate, //修改日期
Memo = objViewIdGCVariableRelaENS.Memo, //说明
};
 return objViewIdGCVariableRelaENT;
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
public static void CheckPropertyNew(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
 clsViewIdGCVariableRelaBL.ViewIdGCVariableRelaDA.CheckPropertyNew(objViewIdGCVariableRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
 clsViewIdGCVariableRelaBL.ViewIdGCVariableRelaDA.CheckProperty4Condition(objViewIdGCVariableRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewIdGCVariableRelaEN objViewIdGCVariableRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.IsUseInRegion) == true)
{
if (objViewIdGCVariableRelaCond.IsUseInRegion == true)
{
strWhereCond += string.Format(" And {0} = '1'", conViewIdGCVariableRela.IsUseInRegion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conViewIdGCVariableRela.IsUseInRegion);
}
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.VarId) == true)
{
string strComparisonOpVarId = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.VarId, objViewIdGCVariableRelaCond.VarId, strComparisonOpVarId);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.ViewId) == true)
{
string strComparisonOpViewId = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.ViewId, objViewIdGCVariableRelaCond.ViewId, strComparisonOpViewId);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.RetrievalMethodId) == true)
{
string strComparisonOpRetrievalMethodId = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.RetrievalMethodId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.RetrievalMethodId, objViewIdGCVariableRelaCond.RetrievalMethodId, strComparisonOpRetrievalMethodId);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.RegionTypeNames) == true)
{
string strComparisonOpRegionTypeNames = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.RegionTypeNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.RegionTypeNames, objViewIdGCVariableRelaCond.RegionTypeNames, strComparisonOpRegionTypeNames);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.ErrMsg) == true)
{
string strComparisonOpErrMsg = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.ErrMsg, objViewIdGCVariableRelaCond.ErrMsg, strComparisonOpErrMsg);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.PrjId) == true)
{
string strComparisonOpPrjId = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.PrjId, objViewIdGCVariableRelaCond.PrjId, strComparisonOpPrjId);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.UpdUser, objViewIdGCVariableRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.UpdDate, objViewIdGCVariableRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewIdGCVariableRelaCond.IsUpdated(conViewIdGCVariableRela.Memo) == true)
{
string strComparisonOpMemo = objViewIdGCVariableRelaCond.dicFldComparisonOp[conViewIdGCVariableRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewIdGCVariableRela.Memo, objViewIdGCVariableRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ViewIdGCVariableRela
{
public virtual bool UpdRelaTabDate(string strVarId,string strViewId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 界面变量关系(ViewIdGCVariableRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsViewIdGCVariableRelaBL
{
public static RelatedActions_ViewIdGCVariableRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsViewIdGCVariableRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsViewIdGCVariableRelaDA ViewIdGCVariableRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsViewIdGCVariableRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsViewIdGCVariableRelaBL()
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
if (string.IsNullOrEmpty(clsViewIdGCVariableRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewIdGCVariableRelaEN._ConnectString);
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
public static DataTable GetDataTable_ViewIdGCVariableRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ViewIdGCVariableRelaDA.GetDataTable_ViewIdGCVariableRela(strWhereCond);
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
objDT = ViewIdGCVariableRelaDA.GetDataTable(strWhereCond);
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
objDT = ViewIdGCVariableRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ViewIdGCVariableRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ViewIdGCVariableRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ViewIdGCVariableRelaDA.GetDataTable_Top(objTopPara);
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
objDT = ViewIdGCVariableRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ViewIdGCVariableRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ViewIdGCVariableRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// 把多个关键字段的值连接起来,用|连接(Join)--ViewIdGCVariableRela(界面变量关系)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_JoinByKeyLst)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">需要连接的对象</param>
 /// <returns></returns>
public static string JoinByKeyLst(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
//检测记录是否存在
string strResult = "";
strResult += objViewIdGCVariableRelaEN.VarId;
strResult += "|" + objViewIdGCVariableRelaEN.ViewId;
return strResult;
}
 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsViewIdGCVariableRelaEN> GetObjLstByKeyLstsCache(List<string> arrKeyLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsViewIdGCVariableRelaEN._CurrTabName, strPrjId);
List<clsViewIdGCVariableRelaEN> arrViewIdGCVariableRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewIdGCVariableRelaEN> arrViewIdGCVariableRelaObjLst_Sel =
arrViewIdGCVariableRelaObjLstCache
.Where(x => arrKeyLst.Contains(JoinByKeyLst(x)));
return arrViewIdGCVariableRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewIdGCVariableRelaEN> GetObjLst(string strWhereCond)
{
List<clsViewIdGCVariableRelaEN> arrObjLst = new List<clsViewIdGCVariableRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = new clsViewIdGCVariableRelaEN();
try
{
objViewIdGCVariableRelaEN.IsUseInRegion = clsEntityBase2.TransNullToBool_S(objRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()); //是否在区域中使用
objViewIdGCVariableRelaEN.VarId = objRow[conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id
objViewIdGCVariableRelaEN.ViewId = objRow[conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id
objViewIdGCVariableRelaEN.RetrievalMethodId = objRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id
objViewIdGCVariableRelaEN.RegionTypeNames = objRow[conViewIdGCVariableRela.RegionTypeNames] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s
objViewIdGCVariableRelaEN.ErrMsg = objRow[conViewIdGCVariableRela.ErrMsg] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息
objViewIdGCVariableRelaEN.PrjId = objRow[conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id
objViewIdGCVariableRelaEN.UpdUser = objRow[conViewIdGCVariableRela.UpdUser] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者
objViewIdGCVariableRelaEN.UpdDate = objRow[conViewIdGCVariableRela.UpdDate] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期
objViewIdGCVariableRelaEN.Memo = objRow[conViewIdGCVariableRela.Memo] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewIdGCVariableRelaEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewIdGCVariableRelaEN);
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
public static List<clsViewIdGCVariableRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsViewIdGCVariableRelaEN> arrObjLst = new List<clsViewIdGCVariableRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = new clsViewIdGCVariableRelaEN();
try
{
objViewIdGCVariableRelaEN.IsUseInRegion = clsEntityBase2.TransNullToBool_S(objRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()); //是否在区域中使用
objViewIdGCVariableRelaEN.VarId = objRow[conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id
objViewIdGCVariableRelaEN.ViewId = objRow[conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id
objViewIdGCVariableRelaEN.RetrievalMethodId = objRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id
objViewIdGCVariableRelaEN.RegionTypeNames = objRow[conViewIdGCVariableRela.RegionTypeNames] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s
objViewIdGCVariableRelaEN.ErrMsg = objRow[conViewIdGCVariableRela.ErrMsg] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息
objViewIdGCVariableRelaEN.PrjId = objRow[conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id
objViewIdGCVariableRelaEN.UpdUser = objRow[conViewIdGCVariableRela.UpdUser] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者
objViewIdGCVariableRelaEN.UpdDate = objRow[conViewIdGCVariableRela.UpdDate] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期
objViewIdGCVariableRelaEN.Memo = objRow[conViewIdGCVariableRela.Memo] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewIdGCVariableRelaEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewIdGCVariableRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsViewIdGCVariableRelaEN> GetSubObjLstCache(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaCond)
{
 string strPrjId = objViewIdGCVariableRelaCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsViewIdGCVariableRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsViewIdGCVariableRelaEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewIdGCVariableRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewIdGCVariableRela._AttributeName)
{
if (objViewIdGCVariableRelaCond.IsUpdated(strFldName) == false) continue;
if (objViewIdGCVariableRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewIdGCVariableRelaCond[strFldName].ToString());
}
else
{
if (objViewIdGCVariableRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewIdGCVariableRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewIdGCVariableRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewIdGCVariableRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewIdGCVariableRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewIdGCVariableRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewIdGCVariableRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewIdGCVariableRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewIdGCVariableRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewIdGCVariableRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewIdGCVariableRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewIdGCVariableRelaCond[strFldName]));
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
public static List<clsViewIdGCVariableRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsViewIdGCVariableRelaEN> arrObjLst = new List<clsViewIdGCVariableRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = new clsViewIdGCVariableRelaEN();
try
{
objViewIdGCVariableRelaEN.IsUseInRegion = clsEntityBase2.TransNullToBool_S(objRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()); //是否在区域中使用
objViewIdGCVariableRelaEN.VarId = objRow[conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id
objViewIdGCVariableRelaEN.ViewId = objRow[conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id
objViewIdGCVariableRelaEN.RetrievalMethodId = objRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id
objViewIdGCVariableRelaEN.RegionTypeNames = objRow[conViewIdGCVariableRela.RegionTypeNames] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s
objViewIdGCVariableRelaEN.ErrMsg = objRow[conViewIdGCVariableRela.ErrMsg] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息
objViewIdGCVariableRelaEN.PrjId = objRow[conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id
objViewIdGCVariableRelaEN.UpdUser = objRow[conViewIdGCVariableRela.UpdUser] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者
objViewIdGCVariableRelaEN.UpdDate = objRow[conViewIdGCVariableRela.UpdDate] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期
objViewIdGCVariableRelaEN.Memo = objRow[conViewIdGCVariableRela.Memo] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewIdGCVariableRelaEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewIdGCVariableRelaEN);
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
public static List<clsViewIdGCVariableRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsViewIdGCVariableRelaEN> arrObjLst = new List<clsViewIdGCVariableRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = new clsViewIdGCVariableRelaEN();
try
{
objViewIdGCVariableRelaEN.IsUseInRegion = clsEntityBase2.TransNullToBool_S(objRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()); //是否在区域中使用
objViewIdGCVariableRelaEN.VarId = objRow[conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id
objViewIdGCVariableRelaEN.ViewId = objRow[conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id
objViewIdGCVariableRelaEN.RetrievalMethodId = objRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id
objViewIdGCVariableRelaEN.RegionTypeNames = objRow[conViewIdGCVariableRela.RegionTypeNames] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s
objViewIdGCVariableRelaEN.ErrMsg = objRow[conViewIdGCVariableRela.ErrMsg] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息
objViewIdGCVariableRelaEN.PrjId = objRow[conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id
objViewIdGCVariableRelaEN.UpdUser = objRow[conViewIdGCVariableRela.UpdUser] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者
objViewIdGCVariableRelaEN.UpdDate = objRow[conViewIdGCVariableRela.UpdDate] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期
objViewIdGCVariableRelaEN.Memo = objRow[conViewIdGCVariableRela.Memo] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewIdGCVariableRelaEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewIdGCVariableRelaEN);
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
List<clsViewIdGCVariableRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsViewIdGCVariableRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewIdGCVariableRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsViewIdGCVariableRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsViewIdGCVariableRelaEN> arrObjLst = new List<clsViewIdGCVariableRelaEN>(); 
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
	clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = new clsViewIdGCVariableRelaEN();
try
{
objViewIdGCVariableRelaEN.IsUseInRegion = clsEntityBase2.TransNullToBool_S(objRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()); //是否在区域中使用
objViewIdGCVariableRelaEN.VarId = objRow[conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id
objViewIdGCVariableRelaEN.ViewId = objRow[conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id
objViewIdGCVariableRelaEN.RetrievalMethodId = objRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id
objViewIdGCVariableRelaEN.RegionTypeNames = objRow[conViewIdGCVariableRela.RegionTypeNames] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s
objViewIdGCVariableRelaEN.ErrMsg = objRow[conViewIdGCVariableRela.ErrMsg] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息
objViewIdGCVariableRelaEN.PrjId = objRow[conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id
objViewIdGCVariableRelaEN.UpdUser = objRow[conViewIdGCVariableRela.UpdUser] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者
objViewIdGCVariableRelaEN.UpdDate = objRow[conViewIdGCVariableRela.UpdDate] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期
objViewIdGCVariableRelaEN.Memo = objRow[conViewIdGCVariableRela.Memo] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewIdGCVariableRelaEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewIdGCVariableRelaEN);
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
public static List<clsViewIdGCVariableRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsViewIdGCVariableRelaEN> arrObjLst = new List<clsViewIdGCVariableRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = new clsViewIdGCVariableRelaEN();
try
{
objViewIdGCVariableRelaEN.IsUseInRegion = clsEntityBase2.TransNullToBool_S(objRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()); //是否在区域中使用
objViewIdGCVariableRelaEN.VarId = objRow[conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id
objViewIdGCVariableRelaEN.ViewId = objRow[conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id
objViewIdGCVariableRelaEN.RetrievalMethodId = objRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id
objViewIdGCVariableRelaEN.RegionTypeNames = objRow[conViewIdGCVariableRela.RegionTypeNames] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s
objViewIdGCVariableRelaEN.ErrMsg = objRow[conViewIdGCVariableRela.ErrMsg] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息
objViewIdGCVariableRelaEN.PrjId = objRow[conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id
objViewIdGCVariableRelaEN.UpdUser = objRow[conViewIdGCVariableRela.UpdUser] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者
objViewIdGCVariableRelaEN.UpdDate = objRow[conViewIdGCVariableRela.UpdDate] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期
objViewIdGCVariableRelaEN.Memo = objRow[conViewIdGCVariableRela.Memo] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewIdGCVariableRelaEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewIdGCVariableRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsViewIdGCVariableRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsViewIdGCVariableRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsViewIdGCVariableRelaEN> arrObjLst = new List<clsViewIdGCVariableRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = new clsViewIdGCVariableRelaEN();
try
{
objViewIdGCVariableRelaEN.IsUseInRegion = clsEntityBase2.TransNullToBool_S(objRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()); //是否在区域中使用
objViewIdGCVariableRelaEN.VarId = objRow[conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id
objViewIdGCVariableRelaEN.ViewId = objRow[conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id
objViewIdGCVariableRelaEN.RetrievalMethodId = objRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id
objViewIdGCVariableRelaEN.RegionTypeNames = objRow[conViewIdGCVariableRela.RegionTypeNames] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s
objViewIdGCVariableRelaEN.ErrMsg = objRow[conViewIdGCVariableRela.ErrMsg] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息
objViewIdGCVariableRelaEN.PrjId = objRow[conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id
objViewIdGCVariableRelaEN.UpdUser = objRow[conViewIdGCVariableRela.UpdUser] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者
objViewIdGCVariableRelaEN.UpdDate = objRow[conViewIdGCVariableRela.UpdDate] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期
objViewIdGCVariableRelaEN.Memo = objRow[conViewIdGCVariableRela.Memo] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewIdGCVariableRelaEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewIdGCVariableRelaEN);
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
public static List<clsViewIdGCVariableRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsViewIdGCVariableRelaEN> arrObjLst = new List<clsViewIdGCVariableRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = new clsViewIdGCVariableRelaEN();
try
{
objViewIdGCVariableRelaEN.IsUseInRegion = clsEntityBase2.TransNullToBool_S(objRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()); //是否在区域中使用
objViewIdGCVariableRelaEN.VarId = objRow[conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id
objViewIdGCVariableRelaEN.ViewId = objRow[conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id
objViewIdGCVariableRelaEN.RetrievalMethodId = objRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id
objViewIdGCVariableRelaEN.RegionTypeNames = objRow[conViewIdGCVariableRela.RegionTypeNames] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s
objViewIdGCVariableRelaEN.ErrMsg = objRow[conViewIdGCVariableRela.ErrMsg] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息
objViewIdGCVariableRelaEN.PrjId = objRow[conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id
objViewIdGCVariableRelaEN.UpdUser = objRow[conViewIdGCVariableRela.UpdUser] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者
objViewIdGCVariableRelaEN.UpdDate = objRow[conViewIdGCVariableRela.UpdDate] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期
objViewIdGCVariableRelaEN.Memo = objRow[conViewIdGCVariableRela.Memo] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewIdGCVariableRelaEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewIdGCVariableRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewIdGCVariableRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsViewIdGCVariableRelaEN> arrObjLst = new List<clsViewIdGCVariableRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = new clsViewIdGCVariableRelaEN();
try
{
objViewIdGCVariableRelaEN.IsUseInRegion = clsEntityBase2.TransNullToBool_S(objRow[conViewIdGCVariableRela.IsUseInRegion].ToString().Trim()); //是否在区域中使用
objViewIdGCVariableRelaEN.VarId = objRow[conViewIdGCVariableRela.VarId].ToString().Trim(); //变量Id
objViewIdGCVariableRelaEN.ViewId = objRow[conViewIdGCVariableRela.ViewId].ToString().Trim(); //界面Id
objViewIdGCVariableRelaEN.RetrievalMethodId = objRow[conViewIdGCVariableRela.RetrievalMethodId].ToString().Trim(); //获取方式Id
objViewIdGCVariableRelaEN.RegionTypeNames = objRow[conViewIdGCVariableRela.RegionTypeNames] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.RegionTypeNames].ToString().Trim(); //区域类型名s
objViewIdGCVariableRelaEN.ErrMsg = objRow[conViewIdGCVariableRela.ErrMsg] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.ErrMsg].ToString().Trim(); //错误信息
objViewIdGCVariableRelaEN.PrjId = objRow[conViewIdGCVariableRela.PrjId].ToString().Trim(); //工程Id
objViewIdGCVariableRelaEN.UpdUser = objRow[conViewIdGCVariableRela.UpdUser] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdUser].ToString().Trim(); //修改者
objViewIdGCVariableRelaEN.UpdDate = objRow[conViewIdGCVariableRela.UpdDate] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.UpdDate].ToString().Trim(); //修改日期
objViewIdGCVariableRelaEN.Memo = objRow[conViewIdGCVariableRela.Memo] == DBNull.Value ? null : objRow[conViewIdGCVariableRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objViewIdGCVariableRelaEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objViewIdGCVariableRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetViewIdGCVariableRela(ref clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
bool bolResult = ViewIdGCVariableRelaDA.GetViewIdGCVariableRela(ref objViewIdGCVariableRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strVarId">表关键字</param>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewIdGCVariableRelaEN GetObjByKeyLst(string strVarId,string strViewId)
{
if (strVarId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strVarId,strViewId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (strViewId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[strVarId,strViewId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strVarId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strVarId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strViewId) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strViewId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = ViewIdGCVariableRelaDA.GetObjByKeyLst(strVarId,strViewId);
return objViewIdGCVariableRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsViewIdGCVariableRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = ViewIdGCVariableRelaDA.GetFirstObj(strWhereCond);
 return objViewIdGCVariableRelaEN;
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
public static clsViewIdGCVariableRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = ViewIdGCVariableRelaDA.GetObjByDataRow(objRow);
 return objViewIdGCVariableRelaEN;
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
public static clsViewIdGCVariableRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = ViewIdGCVariableRelaDA.GetObjByDataRow(objRow);
 return objViewIdGCVariableRelaEN;
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
 /// <param name = "strVarId">表关键字</param>
 /// <param name = "strViewId">表关键字</param>
 /// <param name = "lstViewIdGCVariableRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewIdGCVariableRelaEN GetObjByKeyLstFromList(string strVarId,string strViewId, List<clsViewIdGCVariableRelaEN> lstViewIdGCVariableRelaObjLst)
{
foreach (clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN in lstViewIdGCVariableRelaObjLst)
{
if (objViewIdGCVariableRelaEN.VarId == strVarId 
 && objViewIdGCVariableRelaEN.ViewId == strViewId 
)
{
return objViewIdGCVariableRelaEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strVarId;
 try
 {
 strVarId = new clsViewIdGCVariableRelaDA().GetFirstID(strWhereCond);
 return strVarId;
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
 arrList = ViewIdGCVariableRelaDA.GetID(strWhereCond);
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
bool bolIsExist = ViewIdGCVariableRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strVarId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strVarId,string strViewId)
{
//检测记录是否存在
bool bolIsExist = ViewIdGCVariableRelaDA.IsExist(strVarId,strViewId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strVarId">变量Id</param>
/// <param name = "strViewId">界面Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strVarId , string strViewId, string strOpUser)
{
clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = clsViewIdGCVariableRelaBL.GetObjByKeyLst(strVarId,strViewId);
objViewIdGCVariableRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objViewIdGCVariableRelaEN.UpdUser = strOpUser;
return clsViewIdGCVariableRelaBL.UpdateBySql2(objViewIdGCVariableRelaEN);
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
 bolIsExist = clsViewIdGCVariableRelaDA.IsExistTable();
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
 bolIsExist = ViewIdGCVariableRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objViewIdGCVariableRelaEN.VarId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewIdGCVariableRelaBL.IsExist(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewIdGCVariableRelaEN.VarId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = ViewIdGCVariableRelaDA.AddNewRecordBySQL2(objViewIdGCVariableRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaBL.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);

if (clsViewIdGCVariableRelaBL.relatedActions != null)
{
clsViewIdGCVariableRelaBL.relatedActions.UpdRelaTabDate(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId, objViewIdGCVariableRelaEN.UpdUser);
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
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objViewIdGCVariableRelaEN.VarId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsViewIdGCVariableRelaBL.IsExist(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objViewIdGCVariableRelaEN.VarId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = ViewIdGCVariableRelaDA.AddNewRecordBySQL2WithReturnKey(objViewIdGCVariableRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaBL.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);

if (clsViewIdGCVariableRelaBL.relatedActions != null)
{
clsViewIdGCVariableRelaBL.relatedActions.UpdRelaTabDate(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId, objViewIdGCVariableRelaEN.UpdUser);
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
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
try
{
bool bolResult = ViewIdGCVariableRelaDA.Update(objViewIdGCVariableRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaBL.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);

if (clsViewIdGCVariableRelaBL.relatedActions != null)
{
clsViewIdGCVariableRelaBL.relatedActions.UpdRelaTabDate(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId, objViewIdGCVariableRelaEN.UpdUser);
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
 /// <param name = "objViewIdGCVariableRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
 if (string.IsNullOrEmpty(objViewIdGCVariableRelaEN.VarId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ViewIdGCVariableRelaDA.UpdateBySql2(objViewIdGCVariableRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewIdGCVariableRelaBL.ReFreshCache(objViewIdGCVariableRelaEN.PrjId);

if (clsViewIdGCVariableRelaBL.relatedActions != null)
{
clsViewIdGCVariableRelaBL.relatedActions.UpdRelaTabDate(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId, objViewIdGCVariableRelaEN.UpdUser);
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
 /// <param name = "strVarId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strVarId,string strViewId)
{
try
{
 clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = clsViewIdGCVariableRelaBL.GetObjByKeyLst(strVarId,strViewId);

if (clsViewIdGCVariableRelaBL.relatedActions != null)
{
clsViewIdGCVariableRelaBL.relatedActions.UpdRelaTabDate(objViewIdGCVariableRelaEN.VarId,objViewIdGCVariableRelaEN.ViewId, objViewIdGCVariableRelaEN.UpdUser);
}
if (objViewIdGCVariableRelaEN != null)
{
int intRecNum = ViewIdGCVariableRelaDA.DelRecord(strVarId,strViewId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewIdGCVariableRelaEN.PrjId);
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
/// <param name="strVarId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strVarId,string strViewId , string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
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
//删除与表:[ViewIdGCVariableRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conViewIdGCVariableRela.VarId,
//strVarId);
//        clsViewIdGCVariableRelaBL.DelViewIdGCVariableRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewIdGCVariableRelaBL.DelRecord(strVarId,strViewId, strPrjId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewIdGCVariableRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strVarId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strVarId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strVarId,string strViewId, string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsViewIdGCVariableRelaBL.relatedActions != null)
{
clsViewIdGCVariableRelaBL.relatedActions.UpdRelaTabDate(strVarId,strViewId, "UpdRelaTabDate");
}
bool bolResult = ViewIdGCVariableRelaDA.DelRecord(strVarId,strViewId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strPrjId);
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
 /// <param name = "arrVarIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count == 0) return 0;
try
{
string[] sstrKey;
string strVarId;
string strViewId;
if (clsViewIdGCVariableRelaBL.relatedActions != null)
{
foreach (var strKeyLst in arrKeyLsts)
{
sstrKey = strKeyLst.Split('|');
strVarId = sstrKey[0];
strViewId = sstrKey[1];
clsViewIdGCVariableRelaBL.relatedActions.UpdRelaTabDate(strVarId,strViewId, "UpdRelaTabDate");
}
}
sstrKey = arrKeyLsts[0].Split('|');
strVarId = sstrKey[0];
strViewId = sstrKey[1];
 clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN = clsViewIdGCVariableRelaBL.GetObjByKeyLst(strVarId,strViewId);
int intDelRecNum = ViewIdGCVariableRelaDA.DelRecKeyLsts(arrKeyLsts);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objViewIdGCVariableRelaEN.PrjId);
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
public static int DelViewIdGCVariableRelasByCond(string strWhereCond)
{
try
{
List<string> arrPrjId = GetFldValue(conViewIdGCVariableRela.PrjId, strWhereCond);
int intRecNum = ViewIdGCVariableRelaDA.DelViewIdGCVariableRela(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrPrjId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ViewIdGCVariableRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strVarId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strVarId,string strViewId, string strPrjId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsViewIdGCVariableRelaDA.GetSpecSQLObj();
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
//删除与表:[ViewIdGCVariableRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsViewIdGCVariableRelaBL.DelRecord(strVarId,strViewId, strPrjId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsViewIdGCVariableRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strVarId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objViewIdGCVariableRelaENS">源对象</param>
 /// <param name = "objViewIdGCVariableRelaENT">目标对象</param>
 public static void CopyTo(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaENS, clsViewIdGCVariableRelaEN objViewIdGCVariableRelaENT)
{
try
{
objViewIdGCVariableRelaENT.IsUseInRegion = objViewIdGCVariableRelaENS.IsUseInRegion; //是否在区域中使用
objViewIdGCVariableRelaENT.VarId = objViewIdGCVariableRelaENS.VarId; //变量Id
objViewIdGCVariableRelaENT.ViewId = objViewIdGCVariableRelaENS.ViewId; //界面Id
objViewIdGCVariableRelaENT.RetrievalMethodId = objViewIdGCVariableRelaENS.RetrievalMethodId; //获取方式Id
objViewIdGCVariableRelaENT.RegionTypeNames = objViewIdGCVariableRelaENS.RegionTypeNames; //区域类型名s
objViewIdGCVariableRelaENT.ErrMsg = objViewIdGCVariableRelaENS.ErrMsg; //错误信息
objViewIdGCVariableRelaENT.PrjId = objViewIdGCVariableRelaENS.PrjId; //工程Id
objViewIdGCVariableRelaENT.UpdUser = objViewIdGCVariableRelaENS.UpdUser; //修改者
objViewIdGCVariableRelaENT.UpdDate = objViewIdGCVariableRelaENS.UpdDate; //修改日期
objViewIdGCVariableRelaENT.Memo = objViewIdGCVariableRelaENS.Memo; //说明
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
 /// <param name = "objViewIdGCVariableRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
try
{
objViewIdGCVariableRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objViewIdGCVariableRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conViewIdGCVariableRela.IsUseInRegion, new clsStrCompareIgnoreCase())  ==  true)
{
objViewIdGCVariableRelaEN.IsUseInRegion = objViewIdGCVariableRelaEN.IsUseInRegion; //是否在区域中使用
}
if (arrFldSet.Contains(conViewIdGCVariableRela.VarId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewIdGCVariableRelaEN.VarId = objViewIdGCVariableRelaEN.VarId; //变量Id
}
if (arrFldSet.Contains(conViewIdGCVariableRela.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewIdGCVariableRelaEN.ViewId = objViewIdGCVariableRelaEN.ViewId; //界面Id
}
if (arrFldSet.Contains(conViewIdGCVariableRela.RetrievalMethodId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewIdGCVariableRelaEN.RetrievalMethodId = objViewIdGCVariableRelaEN.RetrievalMethodId; //获取方式Id
}
if (arrFldSet.Contains(conViewIdGCVariableRela.RegionTypeNames, new clsStrCompareIgnoreCase())  ==  true)
{
objViewIdGCVariableRelaEN.RegionTypeNames = objViewIdGCVariableRelaEN.RegionTypeNames == "[null]" ? null :  objViewIdGCVariableRelaEN.RegionTypeNames; //区域类型名s
}
if (arrFldSet.Contains(conViewIdGCVariableRela.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objViewIdGCVariableRelaEN.ErrMsg = objViewIdGCVariableRelaEN.ErrMsg == "[null]" ? null :  objViewIdGCVariableRelaEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(conViewIdGCVariableRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objViewIdGCVariableRelaEN.PrjId = objViewIdGCVariableRelaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(conViewIdGCVariableRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objViewIdGCVariableRelaEN.UpdUser = objViewIdGCVariableRelaEN.UpdUser == "[null]" ? null :  objViewIdGCVariableRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conViewIdGCVariableRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objViewIdGCVariableRelaEN.UpdDate = objViewIdGCVariableRelaEN.UpdDate == "[null]" ? null :  objViewIdGCVariableRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conViewIdGCVariableRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objViewIdGCVariableRelaEN.Memo = objViewIdGCVariableRelaEN.Memo == "[null]" ? null :  objViewIdGCVariableRelaEN.Memo; //说明
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
 /// <param name = "objViewIdGCVariableRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
try
{
if (objViewIdGCVariableRelaEN.RegionTypeNames == "[null]") objViewIdGCVariableRelaEN.RegionTypeNames = null; //区域类型名s
if (objViewIdGCVariableRelaEN.ErrMsg == "[null]") objViewIdGCVariableRelaEN.ErrMsg = null; //错误信息
if (objViewIdGCVariableRelaEN.UpdUser == "[null]") objViewIdGCVariableRelaEN.UpdUser = null; //修改者
if (objViewIdGCVariableRelaEN.UpdDate == "[null]") objViewIdGCVariableRelaEN.UpdDate = null; //修改日期
if (objViewIdGCVariableRelaEN.Memo == "[null]") objViewIdGCVariableRelaEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
 ViewIdGCVariableRelaDA.CheckPropertyNew(objViewIdGCVariableRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaEN)
{
 ViewIdGCVariableRelaDA.CheckProperty4Condition(objViewIdGCVariableRelaEN);
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
if (clsViewIdGCVariableRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewIdGCVariableRelaBL没有刷新缓存机制(clsViewIdGCVariableRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by VarId");
//if (arrViewIdGCVariableRelaObjLstCache == null)
//{
//arrViewIdGCVariableRelaObjLstCache = ViewIdGCVariableRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strVarId">表关键字</param>
 /// <param name = "strViewId">表关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewIdGCVariableRelaEN GetObjByKeyLstCache(string strVarId,string strViewId, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsViewIdGCVariableRelaEN._CurrTabName, strPrjId);
List<clsViewIdGCVariableRelaEN> arrViewIdGCVariableRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewIdGCVariableRelaEN> arrViewIdGCVariableRelaObjLst_Sel =
arrViewIdGCVariableRelaObjLstCache
.Where(x=> x.VarId == strVarId 
 && x.ViewId == strViewId 
);
if (arrViewIdGCVariableRelaObjLst_Sel.Count() == 0)
{
   clsViewIdGCVariableRelaEN obj = clsViewIdGCVariableRelaBL.GetObjByKeyLst(strVarId,strViewId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strVarId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrViewIdGCVariableRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewIdGCVariableRelaEN> GetAllViewIdGCVariableRelaObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsViewIdGCVariableRelaEN> arrViewIdGCVariableRelaObjLstCache = GetObjLstCache(strPrjId); 
return arrViewIdGCVariableRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewIdGCVariableRelaEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsViewIdGCVariableRelaEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsViewIdGCVariableRelaEN> arrViewIdGCVariableRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrViewIdGCVariableRelaObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsViewIdGCVariableRelaEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewIdGCVariableRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsViewIdGCVariableRelaEN._RefreshTimeLst.Count == 0) return "";
return clsViewIdGCVariableRelaEN._RefreshTimeLst[clsViewIdGCVariableRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewIdGCVariableRelaBL.ReFreshCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewIdGCVariableRelaBL.ReFreshCache)", strPrjId.Length);
throw new Exception (strMsg);
}
if (clsViewIdGCVariableRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewIdGCVariableRelaEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewIdGCVariableRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsViewIdGCVariableRelaBL.objCommFun4BL.ReFreshCache(strPrjId);
}
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-08-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strVarId,string strViewId, string strPrjId)
{
if (strInFldName != conViewIdGCVariableRela.VarId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conViewIdGCVariableRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conViewIdGCVariableRela._AttributeName));
throw new Exception(strMsg);
}
var objViewIdGCVariableRela = clsViewIdGCVariableRelaBL.GetObjByKeyLstCache(strVarId,strViewId, strPrjId);
if (objViewIdGCVariableRela == null) return "";
return objViewIdGCVariableRela[strOutFldName].ToString();
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
int intRecCount = clsViewIdGCVariableRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsViewIdGCVariableRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsViewIdGCVariableRelaDA.GetRecCount();
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
int intRecCount = clsViewIdGCVariableRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objViewIdGCVariableRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsViewIdGCVariableRelaEN objViewIdGCVariableRelaCond)
{
 string strPrjId = objViewIdGCVariableRelaCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsViewIdGCVariableRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsViewIdGCVariableRelaEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewIdGCVariableRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conViewIdGCVariableRela._AttributeName)
{
if (objViewIdGCVariableRelaCond.IsUpdated(strFldName) == false) continue;
if (objViewIdGCVariableRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewIdGCVariableRelaCond[strFldName].ToString());
}
else
{
if (objViewIdGCVariableRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objViewIdGCVariableRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objViewIdGCVariableRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objViewIdGCVariableRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objViewIdGCVariableRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objViewIdGCVariableRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objViewIdGCVariableRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objViewIdGCVariableRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objViewIdGCVariableRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objViewIdGCVariableRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objViewIdGCVariableRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objViewIdGCVariableRelaCond[strFldName]));
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
 List<string> arrList = clsViewIdGCVariableRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ViewIdGCVariableRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ViewIdGCVariableRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ViewIdGCVariableRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewIdGCVariableRelaDA.SetFldValue(clsViewIdGCVariableRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ViewIdGCVariableRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewIdGCVariableRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsViewIdGCVariableRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsViewIdGCVariableRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ViewIdGCVariableRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**是否在区域中使用*/ 
 strCreateTabCode.Append(" IsUseInRegion bit Null, "); 
 // /**变量Id*/ 
 strCreateTabCode.Append(" VarId char(8) primary key, "); 
 // /**界面Id*/ 
 strCreateTabCode.Append(" ViewId char(8) primary key, "); 
 // /**获取方式Id*/ 
 strCreateTabCode.Append(" RetrievalMethodId char(2) not Null, "); 
 // /**区域类型名s*/ 
 strCreateTabCode.Append(" RegionTypeNames varchar(100) Null, "); 
 // /**错误信息*/ 
 strCreateTabCode.Append(" ErrMsg varchar(2000) Null, "); 
 // /**工程Id*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**变量名*/ 
 strCreateTabCode.Append(" VarName varchar(50) Null, "); 
 // /**变量类型名*/ 
 strCreateTabCode.Append(" VarTypeName varchar(50) Null, "); 
 // /**获取方式名*/ 
 strCreateTabCode.Append(" RetrievalMethodName varchar(50) Null, "); 
 // /**界面名称*/ 
 strCreateTabCode.Append(" ViewName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 界面变量关系(ViewIdGCVariableRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ViewIdGCVariableRela : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
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
clsViewIdGCVariableRelaBL.ReFreshThisCache(strPrjId);
}
}

}