
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvErrorIdManageWApi
 表名:verrorIdManage(00050302)
 生成代码版本:2021.07.30.2
 生成日期:2021/07/30 16:30:15
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置
 模块英文名:SystemSet
 框架-层名:WA_访问层(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; 
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using AGC.Entity;

namespace AGC4WApi
{
public static class clsvErrorIdManageWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objverrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetmId(this clsvErrorIdManageEN objverrorIdManageEN, long lngmId, string strComparisonOp="")
	{
objverrorIdManageEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objverrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.mId) == false)
{
objverrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.mId, strComparisonOp);
}
else
{
objverrorIdManageEN.dicFldComparisonOp[convErrorIdManage.mId] = strComparisonOp;
}
}
return objverrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objverrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetErrID(this clsvErrorIdManageEN objverrorIdManageEN, string strErrID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strErrID, convErrorIdManage.ErrID);
clsCheckSql.CheckFieldLen(strErrID, 10, convErrorIdManage.ErrID);
clsCheckSql.CheckFieldForeignKey(strErrID, 10, convErrorIdManage.ErrID);
objverrorIdManageEN.ErrID = strErrID; //错误Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objverrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.ErrID) == false)
{
objverrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.ErrID, strComparisonOp);
}
else
{
objverrorIdManageEN.dicFldComparisonOp[convErrorIdManage.ErrID] = strComparisonOp;
}
}
return objverrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objverrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetProgLevelTypeId(this clsvErrorIdManageEN objverrorIdManageEN, string strProgLevelTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLevelTypeId, convErrorIdManage.ProgLevelTypeId);
clsCheckSql.CheckFieldLen(strProgLevelTypeId, 2, convErrorIdManage.ProgLevelTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLevelTypeId, 2, convErrorIdManage.ProgLevelTypeId);
objverrorIdManageEN.ProgLevelTypeId = strProgLevelTypeId; //程序分层类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objverrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.ProgLevelTypeId) == false)
{
objverrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.ProgLevelTypeId, strComparisonOp);
}
else
{
objverrorIdManageEN.dicFldComparisonOp[convErrorIdManage.ProgLevelTypeId] = strComparisonOp;
}
}
return objverrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objverrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetProgLevelTypeName(this clsvErrorIdManageEN objverrorIdManageEN, string strProgLevelTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLevelTypeName, convErrorIdManage.ProgLevelTypeName);
clsCheckSql.CheckFieldLen(strProgLevelTypeName, 30, convErrorIdManage.ProgLevelTypeName);
objverrorIdManageEN.ProgLevelTypeName = strProgLevelTypeName; //程序分层类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objverrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.ProgLevelTypeName) == false)
{
objverrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.ProgLevelTypeName, strComparisonOp);
}
else
{
objverrorIdManageEN.dicFldComparisonOp[convErrorIdManage.ProgLevelTypeName] = strComparisonOp;
}
}
return objverrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objverrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetProgLevelTypeENName(this clsvErrorIdManageEN objverrorIdManageEN, string strProgLevelTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLevelTypeENName, 30, convErrorIdManage.ProgLevelTypeENName);
objverrorIdManageEN.ProgLevelTypeENName = strProgLevelTypeENName; //程序分层类型英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objverrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.ProgLevelTypeENName) == false)
{
objverrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.ProgLevelTypeENName, strComparisonOp);
}
else
{
objverrorIdManageEN.dicFldComparisonOp[convErrorIdManage.ProgLevelTypeENName] = strComparisonOp;
}
}
return objverrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objverrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetPrefix(this clsvErrorIdManageEN objverrorIdManageEN, string strPrefix, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrefix, 10, convErrorIdManage.Prefix);
objverrorIdManageEN.Prefix = strPrefix; //前缀
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objverrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.Prefix) == false)
{
objverrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.Prefix, strComparisonOp);
}
else
{
objverrorIdManageEN.dicFldComparisonOp[convErrorIdManage.Prefix] = strComparisonOp;
}
}
return objverrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objverrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetCodeTypeId(this clsvErrorIdManageEN objverrorIdManageEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convErrorIdManage.CodeTypeId);
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convErrorIdManage.CodeTypeId);
objverrorIdManageEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objverrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.CodeTypeId) == false)
{
objverrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.CodeTypeId, strComparisonOp);
}
else
{
objverrorIdManageEN.dicFldComparisonOp[convErrorIdManage.CodeTypeId] = strComparisonOp;
}
}
return objverrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objverrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetCodeTypeName(this clsvErrorIdManageEN objverrorIdManageEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convErrorIdManage.CodeTypeName);
objverrorIdManageEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objverrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.CodeTypeName) == false)
{
objverrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.CodeTypeName, strComparisonOp);
}
else
{
objverrorIdManageEN.dicFldComparisonOp[convErrorIdManage.CodeTypeName] = strComparisonOp;
}
}
return objverrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objverrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetCodeTypeENName(this clsvErrorIdManageEN objverrorIdManageEN, string strCodeTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convErrorIdManage.CodeTypeENName);
objverrorIdManageEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objverrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.CodeTypeENName) == false)
{
objverrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.CodeTypeENName, strComparisonOp);
}
else
{
objverrorIdManageEN.dicFldComparisonOp[convErrorIdManage.CodeTypeENName] = strComparisonOp;
}
}
return objverrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objverrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetFunctionName(this clsvErrorIdManageEN objverrorIdManageEN, string strFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionName, 200, convErrorIdManage.FunctionName);
objverrorIdManageEN.FunctionName = strFunctionName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objverrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.FunctionName) == false)
{
objverrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.FunctionName, strComparisonOp);
}
else
{
objverrorIdManageEN.dicFldComparisonOp[convErrorIdManage.FunctionName] = strComparisonOp;
}
}
return objverrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objverrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetExplanation(this clsvErrorIdManageEN objverrorIdManageEN, string strExplanation, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExplanation, 1000, convErrorIdManage.Explanation);
objverrorIdManageEN.Explanation = strExplanation; //详细说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objverrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.Explanation) == false)
{
objverrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.Explanation, strComparisonOp);
}
else
{
objverrorIdManageEN.dicFldComparisonOp[convErrorIdManage.Explanation] = strComparisonOp;
}
}
return objverrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objverrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetUpdDate(this clsvErrorIdManageEN objverrorIdManageEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convErrorIdManage.UpdDate);
objverrorIdManageEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objverrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.UpdDate) == false)
{
objverrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.UpdDate, strComparisonOp);
}
else
{
objverrorIdManageEN.dicFldComparisonOp[convErrorIdManage.UpdDate] = strComparisonOp;
}
}
return objverrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objverrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetUpdUserId(this clsvErrorIdManageEN objverrorIdManageEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convErrorIdManage.UpdUserId);
objverrorIdManageEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objverrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.UpdUserId) == false)
{
objverrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.UpdUserId, strComparisonOp);
}
else
{
objverrorIdManageEN.dicFldComparisonOp[convErrorIdManage.UpdUserId] = strComparisonOp;
}
}
return objverrorIdManageEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objverrorIdManageEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvErrorIdManageEN SetMemo(this clsvErrorIdManageEN objverrorIdManageEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convErrorIdManage.Memo);
objverrorIdManageEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objverrorIdManageEN.dicFldComparisonOp.ContainsKey(convErrorIdManage.Memo) == false)
{
objverrorIdManageEN.dicFldComparisonOp.Add(convErrorIdManage.Memo, strComparisonOp);
}
else
{
objverrorIdManageEN.dicFldComparisonOp[convErrorIdManage.Memo] = strComparisonOp;
}
}
return objverrorIdManageEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvErrorIdManageEN objverrorIdManage_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objverrorIdManage_Cond.IsUpdated(convErrorIdManage.mId) == true)
{
string strComparisonOp_mId = objverrorIdManage_Cond.dicFldComparisonOp[convErrorIdManage.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convErrorIdManage.mId, objverrorIdManage_Cond.mId, strComparisonOp_mId);
}
if (objverrorIdManage_Cond.IsUpdated(convErrorIdManage.ErrID) == true)
{
string strComparisonOp_ErrID = objverrorIdManage_Cond.dicFldComparisonOp[convErrorIdManage.ErrID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.ErrID, objverrorIdManage_Cond.ErrID, strComparisonOp_ErrID);
}
if (objverrorIdManage_Cond.IsUpdated(convErrorIdManage.ProgLevelTypeId) == true)
{
string strComparisonOp_ProgLevelTypeId = objverrorIdManage_Cond.dicFldComparisonOp[convErrorIdManage.ProgLevelTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.ProgLevelTypeId, objverrorIdManage_Cond.ProgLevelTypeId, strComparisonOp_ProgLevelTypeId);
}
if (objverrorIdManage_Cond.IsUpdated(convErrorIdManage.ProgLevelTypeName) == true)
{
string strComparisonOp_ProgLevelTypeName = objverrorIdManage_Cond.dicFldComparisonOp[convErrorIdManage.ProgLevelTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.ProgLevelTypeName, objverrorIdManage_Cond.ProgLevelTypeName, strComparisonOp_ProgLevelTypeName);
}
if (objverrorIdManage_Cond.IsUpdated(convErrorIdManage.ProgLevelTypeENName) == true)
{
string strComparisonOp_ProgLevelTypeENName = objverrorIdManage_Cond.dicFldComparisonOp[convErrorIdManage.ProgLevelTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.ProgLevelTypeENName, objverrorIdManage_Cond.ProgLevelTypeENName, strComparisonOp_ProgLevelTypeENName);
}
if (objverrorIdManage_Cond.IsUpdated(convErrorIdManage.Prefix) == true)
{
string strComparisonOp_Prefix = objverrorIdManage_Cond.dicFldComparisonOp[convErrorIdManage.Prefix];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.Prefix, objverrorIdManage_Cond.Prefix, strComparisonOp_Prefix);
}
if (objverrorIdManage_Cond.IsUpdated(convErrorIdManage.CodeTypeId) == true)
{
string strComparisonOp_CodeTypeId = objverrorIdManage_Cond.dicFldComparisonOp[convErrorIdManage.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.CodeTypeId, objverrorIdManage_Cond.CodeTypeId, strComparisonOp_CodeTypeId);
}
if (objverrorIdManage_Cond.IsUpdated(convErrorIdManage.CodeTypeName) == true)
{
string strComparisonOp_CodeTypeName = objverrorIdManage_Cond.dicFldComparisonOp[convErrorIdManage.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.CodeTypeName, objverrorIdManage_Cond.CodeTypeName, strComparisonOp_CodeTypeName);
}
if (objverrorIdManage_Cond.IsUpdated(convErrorIdManage.CodeTypeENName) == true)
{
string strComparisonOp_CodeTypeENName = objverrorIdManage_Cond.dicFldComparisonOp[convErrorIdManage.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.CodeTypeENName, objverrorIdManage_Cond.CodeTypeENName, strComparisonOp_CodeTypeENName);
}
if (objverrorIdManage_Cond.IsUpdated(convErrorIdManage.FunctionName) == true)
{
string strComparisonOp_FunctionName = objverrorIdManage_Cond.dicFldComparisonOp[convErrorIdManage.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.FunctionName, objverrorIdManage_Cond.FunctionName, strComparisonOp_FunctionName);
}
if (objverrorIdManage_Cond.IsUpdated(convErrorIdManage.Explanation) == true)
{
string strComparisonOp_Explanation = objverrorIdManage_Cond.dicFldComparisonOp[convErrorIdManage.Explanation];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.Explanation, objverrorIdManage_Cond.Explanation, strComparisonOp_Explanation);
}
if (objverrorIdManage_Cond.IsUpdated(convErrorIdManage.UpdDate) == true)
{
string strComparisonOp_UpdDate = objverrorIdManage_Cond.dicFldComparisonOp[convErrorIdManage.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.UpdDate, objverrorIdManage_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objverrorIdManage_Cond.IsUpdated(convErrorIdManage.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objverrorIdManage_Cond.dicFldComparisonOp[convErrorIdManage.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.UpdUserId, objverrorIdManage_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objverrorIdManage_Cond.IsUpdated(convErrorIdManage.Memo) == true)
{
string strComparisonOp_Memo = objverrorIdManage_Cond.dicFldComparisonOp[convErrorIdManage.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convErrorIdManage.Memo, objverrorIdManage_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v错误Id管理(verrorIdManage)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvErrorIdManageWApi
{
private static readonly string mstrApiControllerName = "verrorIdManageApi";

 public clsvErrorIdManageWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvErrorIdManageEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvErrorIdManageEN objverrorIdManageEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objverrorIdManageEN = JsonConvert.DeserializeObject<clsvErrorIdManageEN>((string)jobjReturn["returnObj"]);
return objverrorIdManageEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvErrorIdManageEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvErrorIdManageEN objverrorIdManageEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objverrorIdManageEN = JsonConvert.DeserializeObject<clsvErrorIdManageEN>((string)jobjReturn["returnObj"]);
return objverrorIdManageEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn["returnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvErrorIdManageEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvErrorIdManageEN objverrorIdManageEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objverrorIdManageEN = JsonConvert.DeserializeObject<clsvErrorIdManageEN>((string)jobjReturn["returnObj"]);
return objverrorIdManageEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvErrorIdManageEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvErrorIdManageEN._CurrTabName);
List<clsvErrorIdManageEN> arrverrorIdManageObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvErrorIdManageEN> arrverrorIdManageObjLst_Sel =
from objverrorIdManageEN in arrverrorIdManageObjLst_Cache
where objverrorIdManageEN.mId == lngmId
select objverrorIdManageEN;
if (arrverrorIdManageObjLst_Sel.Count() == 0)
{
   clsvErrorIdManageEN obj = clsvErrorIdManageWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrverrorIdManageObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvErrorIdManageEN> GetObjLst(string strWhereCond)
{
 List<clsvErrorIdManageEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvErrorIdManageEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvErrorIdManageEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvErrorIdManageEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvErrorIdManageEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvErrorIdManageEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvErrorIdManageEN._CurrTabName);
List<clsvErrorIdManageEN> arrverrorIdManageObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvErrorIdManageEN> arrverrorIdManageObjLst_Sel =
from objverrorIdManageEN in arrverrorIdManageObjLst_Cache
where arrMId.Contains(objverrorIdManageEN.mId)
select objverrorIdManageEN;
return arrverrorIdManageObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvErrorIdManageEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvErrorIdManageEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvErrorIdManageEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvErrorIdManageEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvErrorIdManageEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvErrorIdManageEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvErrorIdManageEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvErrorIdManageEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvErrorIdManageEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvErrorIdManageEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvErrorIdManageEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvErrorIdManageEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvErrorIdManageEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvErrorIdManageEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvErrorIdManageEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objverrorIdManageENS">源对象</param>
 /// <param name = "objverrorIdManageENT">目标对象</param>
 public static void CopyTo(clsvErrorIdManageEN objverrorIdManageENS, clsvErrorIdManageEN objverrorIdManageENT)
{
try
{
objverrorIdManageENT.mId = objverrorIdManageENS.mId; //mId
objverrorIdManageENT.ErrID = objverrorIdManageENS.ErrID; //错误Id
objverrorIdManageENT.ProgLevelTypeId = objverrorIdManageENS.ProgLevelTypeId; //程序分层类型Id
objverrorIdManageENT.ProgLevelTypeName = objverrorIdManageENS.ProgLevelTypeName; //程序分层类型名称
objverrorIdManageENT.ProgLevelTypeENName = objverrorIdManageENS.ProgLevelTypeENName; //程序分层类型英文名称
objverrorIdManageENT.Prefix = objverrorIdManageENS.Prefix; //前缀
objverrorIdManageENT.CodeTypeId = objverrorIdManageENS.CodeTypeId; //代码类型Id
objverrorIdManageENT.CodeTypeName = objverrorIdManageENS.CodeTypeName; //代码类型名
objverrorIdManageENT.CodeTypeENName = objverrorIdManageENS.CodeTypeENName; //代码类型英文名
objverrorIdManageENT.FunctionName = objverrorIdManageENS.FunctionName; //功能名称
objverrorIdManageENT.Explanation = objverrorIdManageENS.Explanation; //详细说明
objverrorIdManageENT.UpdDate = objverrorIdManageENS.UpdDate; //修改日期
objverrorIdManageENT.UpdUserId = objverrorIdManageENS.UpdUserId; //修改用户Id
objverrorIdManageENT.Memo = objverrorIdManageENS.Memo; //说明
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsvErrorIdManageEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvErrorIdManageEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvErrorIdManageEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvErrorIdManageEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvErrorIdManageEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvErrorIdManageEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsCodeTypeWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsCodeTypeWApi没有刷新缓存机制(clsCodeTypeWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsErrorIdManageWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsErrorIdManageWApi没有刷新缓存机制(clsErrorIdManageWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrverrorIdManageObjLst_Cache == null)
//{
//arrverrorIdManageObjLst_Cache = await clsvErrorIdManageWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvErrorIdManageEN._CurrTabName);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvErrorIdManageEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvErrorIdManageEN._CurrTabName);
List<clsvErrorIdManageEN> arrverrorIdManageObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrverrorIdManageObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvErrorIdManageEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convErrorIdManage.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convErrorIdManage.ErrID, Type.GetType("System.String"));
objDT.Columns.Add(convErrorIdManage.ProgLevelTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convErrorIdManage.ProgLevelTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convErrorIdManage.ProgLevelTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convErrorIdManage.Prefix, Type.GetType("System.String"));
objDT.Columns.Add(convErrorIdManage.CodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convErrorIdManage.CodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convErrorIdManage.CodeTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convErrorIdManage.FunctionName, Type.GetType("System.String"));
objDT.Columns.Add(convErrorIdManage.Explanation, Type.GetType("System.String"));
objDT.Columns.Add(convErrorIdManage.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convErrorIdManage.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convErrorIdManage.Memo, Type.GetType("System.String"));
foreach (clsvErrorIdManageEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convErrorIdManage.mId] = objInFor[convErrorIdManage.mId];
objDR[convErrorIdManage.ErrID] = objInFor[convErrorIdManage.ErrID];
objDR[convErrorIdManage.ProgLevelTypeId] = objInFor[convErrorIdManage.ProgLevelTypeId];
objDR[convErrorIdManage.ProgLevelTypeName] = objInFor[convErrorIdManage.ProgLevelTypeName];
objDR[convErrorIdManage.ProgLevelTypeENName] = objInFor[convErrorIdManage.ProgLevelTypeENName];
objDR[convErrorIdManage.Prefix] = objInFor[convErrorIdManage.Prefix];
objDR[convErrorIdManage.CodeTypeId] = objInFor[convErrorIdManage.CodeTypeId];
objDR[convErrorIdManage.CodeTypeName] = objInFor[convErrorIdManage.CodeTypeName];
objDR[convErrorIdManage.CodeTypeENName] = objInFor[convErrorIdManage.CodeTypeENName];
objDR[convErrorIdManage.FunctionName] = objInFor[convErrorIdManage.FunctionName];
objDR[convErrorIdManage.Explanation] = objInFor[convErrorIdManage.Explanation];
objDR[convErrorIdManage.UpdDate] = objInFor[convErrorIdManage.UpdDate];
objDR[convErrorIdManage.UpdUserId] = objInFor[convErrorIdManage.UpdUserId];
objDR[convErrorIdManage.Memo] = objInFor[convErrorIdManage.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}