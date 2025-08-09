
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjConstraintWApi
 表名:PrjConstraint(00050331)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:18
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
 框架-层名:WA_访问层(CS)(WA_Access,0045)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
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
/// <summary>
/// 静态类
/// </summary>
public static class  clsPrjConstraintWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjConstraintId">约束表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetPrjConstraintId(this clsPrjConstraintEN objPrjConstraintEN, string strPrjConstraintId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjConstraintId, 8, conPrjConstraint.PrjConstraintId);
clsCheckSql.CheckFieldForeignKey(strPrjConstraintId, 8, conPrjConstraint.PrjConstraintId);
objPrjConstraintEN.PrjConstraintId = strPrjConstraintId; //约束表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.PrjConstraintId) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.PrjConstraintId, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.PrjConstraintId] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strConstraintName">约束名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetConstraintName(this clsPrjConstraintEN objPrjConstraintEN, string strConstraintName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstraintName, conPrjConstraint.ConstraintName);
clsCheckSql.CheckFieldLen(strConstraintName, 100, conPrjConstraint.ConstraintName);
objPrjConstraintEN.ConstraintName = strConstraintName; //约束名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.ConstraintName) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.ConstraintName, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.ConstraintName] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetPrjId(this clsPrjConstraintEN objPrjConstraintEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conPrjConstraint.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conPrjConstraint.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conPrjConstraint.PrjId);
objPrjConstraintEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.PrjId) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.PrjId, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.PrjId] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetTabId(this clsPrjConstraintEN objPrjConstraintEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conPrjConstraint.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, conPrjConstraint.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conPrjConstraint.TabId);
objPrjConstraintEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.TabId) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.TabId, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.TabId] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strConstraintTypeId">约束类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetConstraintTypeId(this clsPrjConstraintEN objPrjConstraintEN, string strConstraintTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConstraintTypeId, conPrjConstraint.ConstraintTypeId);
clsCheckSql.CheckFieldLen(strConstraintTypeId, 2, conPrjConstraint.ConstraintTypeId);
clsCheckSql.CheckFieldForeignKey(strConstraintTypeId, 2, conPrjConstraint.ConstraintTypeId);
objPrjConstraintEN.ConstraintTypeId = strConstraintTypeId; //约束类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.ConstraintTypeId) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.ConstraintTypeId, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.ConstraintTypeId] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strConstraintDescription">约束说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetConstraintDescription(this clsPrjConstraintEN objPrjConstraintEN, string strConstraintDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strConstraintDescription, 500, conPrjConstraint.ConstraintDescription);
objPrjConstraintEN.ConstraintDescription = strConstraintDescription; //约束说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.ConstraintDescription) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.ConstraintDescription, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.ConstraintDescription] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strCreateUserId">建立用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetCreateUserId(this clsPrjConstraintEN objPrjConstraintEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, conPrjConstraint.CreateUserId);
clsCheckSql.CheckFieldLen(strCreateUserId, 18, conPrjConstraint.CreateUserId);
objPrjConstraintEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.CreateUserId) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.CreateUserId, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.CreateUserId] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNullable">是否可空</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetIsNullable(this clsPrjConstraintEN objPrjConstraintEN, bool bolIsNullable, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNullable, conPrjConstraint.IsNullable);
objPrjConstraintEN.IsNullable = bolIsNullable; //是否可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.IsNullable) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.IsNullable, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.IsNullable] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strCheckDate">检查日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetCheckDate(this clsPrjConstraintEN objPrjConstraintEN, string strCheckDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckDate, 20, conPrjConstraint.CheckDate);
objPrjConstraintEN.CheckDate = strCheckDate; //检查日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.CheckDate) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.CheckDate, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.CheckDate] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetErrMsg(this clsPrjConstraintEN objPrjConstraintEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conPrjConstraint.ErrMsg);
objPrjConstraintEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.ErrMsg) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.ErrMsg, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.ErrMsg] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetInUse(this clsPrjConstraintEN objPrjConstraintEN, bool bolInUse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolInUse, conPrjConstraint.InUse);
objPrjConstraintEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.InUse) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.InUse, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.InUse] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetUpdDate(this clsPrjConstraintEN objPrjConstraintEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPrjConstraint.UpdDate);
objPrjConstraintEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.UpdDate) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.UpdDate, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.UpdDate] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetUpdUser(this clsPrjConstraintEN objPrjConstraintEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conPrjConstraint.UpdUser);
objPrjConstraintEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.UpdUser) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.UpdUser, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.UpdUser] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjConstraintEN SetMemo(this clsPrjConstraintEN objPrjConstraintEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjConstraint.Memo);
objPrjConstraintEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjConstraintEN.dicFldComparisonOp.ContainsKey(conPrjConstraint.Memo) == false)
{
objPrjConstraintEN.dicFldComparisonOp.Add(conPrjConstraint.Memo, strComparisonOp);
}
else
{
objPrjConstraintEN.dicFldComparisonOp[conPrjConstraint.Memo] = strComparisonOp;
}
}
return objPrjConstraintEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjConstraintEN objPrjConstraintCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.PrjConstraintId) == true)
{
string strComparisonOpPrjConstraintId = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.PrjConstraintId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.PrjConstraintId, objPrjConstraintCond.PrjConstraintId, strComparisonOpPrjConstraintId);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.ConstraintName) == true)
{
string strComparisonOpConstraintName = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.ConstraintName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.ConstraintName, objPrjConstraintCond.ConstraintName, strComparisonOpConstraintName);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.PrjId) == true)
{
string strComparisonOpPrjId = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.PrjId, objPrjConstraintCond.PrjId, strComparisonOpPrjId);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.TabId) == true)
{
string strComparisonOpTabId = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.TabId, objPrjConstraintCond.TabId, strComparisonOpTabId);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.ConstraintTypeId) == true)
{
string strComparisonOpConstraintTypeId = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.ConstraintTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.ConstraintTypeId, objPrjConstraintCond.ConstraintTypeId, strComparisonOpConstraintTypeId);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.ConstraintDescription) == true)
{
string strComparisonOpConstraintDescription = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.ConstraintDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.ConstraintDescription, objPrjConstraintCond.ConstraintDescription, strComparisonOpConstraintDescription);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.CreateUserId, objPrjConstraintCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.IsNullable) == true)
{
if (objPrjConstraintCond.IsNullable == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjConstraint.IsNullable);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjConstraint.IsNullable);
}
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.CheckDate) == true)
{
string strComparisonOpCheckDate = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.CheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.CheckDate, objPrjConstraintCond.CheckDate, strComparisonOpCheckDate);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.ErrMsg) == true)
{
string strComparisonOpErrMsg = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.ErrMsg, objPrjConstraintCond.ErrMsg, strComparisonOpErrMsg);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.InUse) == true)
{
if (objPrjConstraintCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjConstraint.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjConstraint.InUse);
}
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.UpdDate) == true)
{
string strComparisonOpUpdDate = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.UpdDate, objPrjConstraintCond.UpdDate, strComparisonOpUpdDate);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.UpdUser) == true)
{
string strComparisonOpUpdUser = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.UpdUser, objPrjConstraintCond.UpdUser, strComparisonOpUpdUser);
}
if (objPrjConstraintCond.IsUpdated(conPrjConstraint.Memo) == true)
{
string strComparisonOpMemo = objPrjConstraintCond.dicFldComparisonOp[conPrjConstraint.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjConstraint.Memo, objPrjConstraintCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjConstraintEN objPrjConstraintEN)
{
 if (string.IsNullOrEmpty(objPrjConstraintEN.PrjConstraintId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objPrjConstraintEN.sfUpdFldSetStr = objPrjConstraintEN.getsfUpdFldSetStr();
clsPrjConstraintWApi.CheckPropertyNew(objPrjConstraintEN); 
bool bolResult = clsPrjConstraintWApi.UpdateRecord(objPrjConstraintEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintWApi.ReFreshCache(objPrjConstraintEN.PrjId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 获取唯一性条件串--PrjConstraint(约束), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ConstraintName_PrjId_TabId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjConstraintEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsPrjConstraintEN objPrjConstraintEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjConstraintEN == null) return "";
if (objPrjConstraintEN.PrjConstraintId == null || objPrjConstraintEN.PrjConstraintId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConstraintName = '{0}'", objPrjConstraintEN.ConstraintName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjConstraintEN.PrjId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjConstraintEN.TabId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PrjConstraintId !=  '{0}'", objPrjConstraintEN.PrjConstraintId);
 sbCondition.AppendFormat(" and ConstraintName = '{0}'", objPrjConstraintEN.ConstraintName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjConstraintEN.PrjId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjConstraintEN.TabId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjConstraintEN objPrjConstraintEN)
{
try
{
 if (string.IsNullOrEmpty(objPrjConstraintEN.PrjConstraintId) == true || clsPrjConstraintWApi.IsExist(objPrjConstraintEN.PrjConstraintId) == true)
 {
     objPrjConstraintEN.PrjConstraintId = clsPrjConstraintWApi.GetMaxStrId();
 }
clsPrjConstraintWApi.CheckPropertyNew(objPrjConstraintEN); 
bool bolResult = clsPrjConstraintWApi.AddNewRecord(objPrjConstraintEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintWApi.ReFreshCache(objPrjConstraintEN.PrjId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPrjConstraintEN objPrjConstraintEN)
{
try
{
clsPrjConstraintWApi.CheckPropertyNew(objPrjConstraintEN); 
string strPrjConstraintId = clsPrjConstraintWApi.AddNewRecordWithMaxId(objPrjConstraintEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintWApi.ReFreshCache(objPrjConstraintEN.PrjId);
return strPrjConstraintId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjConstraintEN objPrjConstraintEN, string strWhereCond)
{
try
{
clsPrjConstraintWApi.CheckPropertyNew(objPrjConstraintEN); 
bool bolResult = clsPrjConstraintWApi.UpdateWithCondition(objPrjConstraintEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintWApi.ReFreshCache(objPrjConstraintEN.PrjId);
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 约束(PrjConstraint)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsPrjConstraintWApi
{
private static readonly string mstrApiControllerName = "PrjConstraintApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsPrjConstraintWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PrjConstraintId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[约束]...","0");
List<clsPrjConstraintEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="PrjConstraintId";
objDDL.DataTextField="ConstraintName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_PrjConstraintId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPrjConstraint.PrjConstraintId); 
List<clsPrjConstraintEN> arrObjLst = clsPrjConstraintWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsPrjConstraintEN objPrjConstraintEN = new clsPrjConstraintEN()
{
PrjConstraintId = "0",
ConstraintName = "选[约束]..."
};
arrObjLstSel.Insert(0, objPrjConstraintEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conPrjConstraint.PrjConstraintId;
objComboBox.DisplayMember = conPrjConstraint.ConstraintName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsPrjConstraintEN objPrjConstraintEN)
{
if (!Object.Equals(null, objPrjConstraintEN.PrjConstraintId) && GetStrLen(objPrjConstraintEN.PrjConstraintId) > 8)
{
 throw new Exception("字段[约束表Id]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjConstraintEN.ConstraintName) && GetStrLen(objPrjConstraintEN.ConstraintName) > 100)
{
 throw new Exception("字段[约束名]的长度不能超过100!");
}
if (!Object.Equals(null, objPrjConstraintEN.PrjId) && GetStrLen(objPrjConstraintEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objPrjConstraintEN.TabId) && GetStrLen(objPrjConstraintEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjConstraintEN.ConstraintTypeId) && GetStrLen(objPrjConstraintEN.ConstraintTypeId) > 2)
{
 throw new Exception("字段[约束类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objPrjConstraintEN.ConstraintDescription) && GetStrLen(objPrjConstraintEN.ConstraintDescription) > 500)
{
 throw new Exception("字段[约束说明]的长度不能超过500!");
}
if (!Object.Equals(null, objPrjConstraintEN.CreateUserId) && GetStrLen(objPrjConstraintEN.CreateUserId) > 18)
{
 throw new Exception("字段[建立用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objPrjConstraintEN.CheckDate) && GetStrLen(objPrjConstraintEN.CheckDate) > 20)
{
 throw new Exception("字段[检查日期]的长度不能超过20!");
}
if (!Object.Equals(null, objPrjConstraintEN.ErrMsg) && GetStrLen(objPrjConstraintEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objPrjConstraintEN.UpdDate) && GetStrLen(objPrjConstraintEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objPrjConstraintEN.UpdUser) && GetStrLen(objPrjConstraintEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objPrjConstraintEN.Memo) && GetStrLen(objPrjConstraintEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objPrjConstraintEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjConstraintId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjConstraintEN GetObjByPrjConstraintId(string strPrjConstraintId)
{
if (strPrjConstraintId == "") return null;
string strAction = "GetObjByPrjConstraintId";
clsPrjConstraintEN objPrjConstraintEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPrjConstraintId"] = strPrjConstraintId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objPrjConstraintEN = JsonConvert.DeserializeObject<clsPrjConstraintEN>(strJson);
return objPrjConstraintEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
public static clsPrjConstraintEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsPrjConstraintEN objPrjConstraintEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objPrjConstraintEN = JsonConvert.DeserializeObject<clsPrjConstraintEN>(strJson);
return objPrjConstraintEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPrjConstraintId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjConstraintEN GetObjByPrjConstraintIdCache(string strPrjConstraintId)
{
if (string.IsNullOrEmpty(strPrjConstraintId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsPrjConstraintEN._CurrTabName, strPrjId);
List<clsPrjConstraintEN> arrPrjConstraintObjLstCache = GetObjLstCache();
IEnumerable <clsPrjConstraintEN> arrPrjConstraintObjLst_Sel =
from objPrjConstraintEN in arrPrjConstraintObjLstCache
where objPrjConstraintEN.PrjConstraintId == strPrjConstraintId 
select objPrjConstraintEN;
if (arrPrjConstraintObjLst_Sel.Count() == 0)
{
   clsPrjConstraintEN obj = clsPrjConstraintWApi.GetObjByPrjConstraintId(strPrjConstraintId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrPrjConstraintObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjConstraintId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetConstraintNameByPrjConstraintIdCache(string strPrjConstraintId)
{
if (string.IsNullOrEmpty(strPrjConstraintId) == true) return "";
//初始化列表缓存
List<clsPrjConstraintEN> arrPrjConstraintObjLstCache = GetObjLstCache();
IEnumerable <clsPrjConstraintEN> arrPrjConstraintObjLst_Sel1 =
from objPrjConstraintEN in arrPrjConstraintObjLstCache
where objPrjConstraintEN.PrjConstraintId == strPrjConstraintId 
select objPrjConstraintEN;
List <clsPrjConstraintEN> arrPrjConstraintObjLst_Sel = new List<clsPrjConstraintEN>();
foreach (clsPrjConstraintEN obj in arrPrjConstraintObjLst_Sel1)
{
arrPrjConstraintObjLst_Sel.Add(obj);
}
if (arrPrjConstraintObjLst_Sel.Count > 0)
{
return arrPrjConstraintObjLst_Sel[0].ConstraintName;
}
string strErrMsgForGetObjById = string.Format("在PrjConstraint对象缓存列表中,找不到记录[PrjConstraintId = {0}](函数:{1})", strPrjConstraintId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPrjConstraintBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjConstraintId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPrjConstraintIdCache(string strPrjConstraintId)
{
if (string.IsNullOrEmpty(strPrjConstraintId) == true) return "";
//初始化列表缓存
List<clsPrjConstraintEN> arrPrjConstraintObjLstCache = GetObjLstCache();
IEnumerable <clsPrjConstraintEN> arrPrjConstraintObjLst_Sel1 =
from objPrjConstraintEN in arrPrjConstraintObjLstCache
where objPrjConstraintEN.PrjConstraintId == strPrjConstraintId 
select objPrjConstraintEN;
List <clsPrjConstraintEN> arrPrjConstraintObjLst_Sel = new List<clsPrjConstraintEN>();
foreach (clsPrjConstraintEN obj in arrPrjConstraintObjLst_Sel1)
{
arrPrjConstraintObjLst_Sel.Add(obj);
}
if (arrPrjConstraintObjLst_Sel.Count > 0)
{
return arrPrjConstraintObjLst_Sel[0].ConstraintName;
}
string strErrMsgForGetObjById = string.Format("在PrjConstraint对象缓存列表中,找不到记录的相关名称[PrjConstraintId = {0}](函数:{1})", strPrjConstraintId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPrjConstraintBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjConstraintEN> GetObjLst(string strWhereCond)
{
 List<clsPrjConstraintEN> arrObjLst; 
string strAction = "GetObjLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjConstraintEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// <param name = "arrPrjConstraintId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjConstraintEN> GetObjLstByPrjConstraintIdLst(List<string> arrPrjConstraintId)
{
 List<clsPrjConstraintEN> arrObjLst; 
string strAction = "GetObjLstByPrjConstraintIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPrjConstraintId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjConstraintEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPrjConstraintId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsPrjConstraintEN> GetObjLstByPrjConstraintIdLstCache(List<string> arrPrjConstraintId, )
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsPrjConstraintEN._CurrTabName, strPrjId);
List<clsPrjConstraintEN> arrPrjConstraintObjLstCache = GetObjLstCache();
IEnumerable <clsPrjConstraintEN> arrPrjConstraintObjLst_Sel =
from objPrjConstraintEN in arrPrjConstraintObjLstCache
where arrPrjConstraintId.Contains(objPrjConstraintEN.PrjConstraintId)
select objPrjConstraintEN;
return arrPrjConstraintObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjConstraintEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsPrjConstraintEN> arrObjLst; 
string strAction = "GetTopObjLst";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjConstraintEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static List<clsPrjConstraintEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsPrjConstraintEN> arrObjLst; 
string strAction = "GetObjLstByRange";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjConstraintEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static List<clsPrjConstraintEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsPrjConstraintEN> arrObjLst; 
string strAction = "GetObjLstByPager";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjConstraintEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsPrjConstraintEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsPrjConstraintEN> arrObjLst; 
string strAction = "GetObjLstByPagerCache";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjConstraintEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strPrjConstraintId)
{
string strAction = "DelRecord";
try
{
 clsPrjConstraintEN objPrjConstraintEN = clsPrjConstraintWApi.GetObjByPrjConstraintId(strPrjConstraintId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strPrjConstraintId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsPrjConstraintWApi.ReFreshCache(objPrjConstraintEN.PrjId);
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelPrjConstraints(List<string> arrPrjConstraintId)
{
string strAction = "DelPrjConstraints";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPrjConstraintId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsPrjConstraintEN objPrjConstraintEN = clsPrjConstraintWApi.GetObjByPrjConstraintId(arrPrjConstraintId[0]);
clsPrjConstraintWApi.ReFreshCache(objPrjConstraintEN.PrjId);
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelPrjConstraintsByCond(string strWhereCond)
{
string strAction = "DelPrjConstraintsByCond";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsPrjConstraintEN objPrjConstraintEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjConstraintEN>(objPrjConstraintEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintWApi.ReFreshCache(objPrjConstraintEN.PrjId);
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsPrjConstraintEN objPrjConstraintEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjConstraintEN>(objPrjConstraintEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjConstraintWApi.ReFreshCache(objPrjConstraintEN.PrjId);
var strPrjConstraintId = (string)jobjReturn0["returnStr"];
return strPrjConstraintId;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsPrjConstraintEN objPrjConstraintEN)
{
if (string.IsNullOrEmpty(objPrjConstraintEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjConstraintEN.PrjConstraintId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjConstraintEN>(objPrjConstraintEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objPrjConstraintEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsPrjConstraintEN objPrjConstraintEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objPrjConstraintEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjConstraintEN.PrjConstraintId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjConstraintEN.PrjConstraintId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjConstraintEN>(objPrjConstraintEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static bool IsExist(string strPrjConstraintId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPrjConstraintId"] = strPrjConstraintId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn0["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase4Tab:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objPrjConstraintENS">源对象</param>
 /// <param name = "objPrjConstraintENT">目标对象</param>
 public static void CopyTo(clsPrjConstraintEN objPrjConstraintENS, clsPrjConstraintEN objPrjConstraintENT)
{
try
{
objPrjConstraintENT.PrjConstraintId = objPrjConstraintENS.PrjConstraintId; //约束表Id
objPrjConstraintENT.ConstraintName = objPrjConstraintENS.ConstraintName; //约束名
objPrjConstraintENT.PrjId = objPrjConstraintENS.PrjId; //工程Id
objPrjConstraintENT.TabId = objPrjConstraintENS.TabId; //表ID
objPrjConstraintENT.ConstraintTypeId = objPrjConstraintENS.ConstraintTypeId; //约束类型Id
objPrjConstraintENT.ConstraintDescription = objPrjConstraintENS.ConstraintDescription; //约束说明
objPrjConstraintENT.CreateUserId = objPrjConstraintENS.CreateUserId; //建立用户Id
objPrjConstraintENT.IsNullable = objPrjConstraintENS.IsNullable; //是否可空
objPrjConstraintENT.CheckDate = objPrjConstraintENS.CheckDate; //检查日期
objPrjConstraintENT.ErrMsg = objPrjConstraintENS.ErrMsg; //错误信息
objPrjConstraintENT.InUse = objPrjConstraintENS.InUse; //是否在用
objPrjConstraintENT.UpdDate = objPrjConstraintENS.UpdDate; //修改日期
objPrjConstraintENT.UpdUser = objPrjConstraintENS.UpdUser; //修改者
objPrjConstraintENT.Memo = objPrjConstraintENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsPrjConstraintEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsPrjConstraintEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsPrjConstraintEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsPrjConstraintEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsPrjConstraintEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsPrjConstraintEN._AttributeName)
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
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsPrjConstraintWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsPrjConstraintWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsPrjConstraintEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
}
else
{
strMsg0 = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg0);
}
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsPrjConstraintWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsPrjConstraintEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsPrjConstraintWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjConstraintEN> GetObjLstCache()
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsPrjConstraintWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsPrjConstraintWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsPrjConstraintEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsPrjConstraintEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conPrjConstraint.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsPrjConstraintEN._CurrTabName, strPrjId);
List<clsPrjConstraintEN> arrPrjConstraintObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrPrjConstraintObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjConstraintEN> GetObjLstCacheFromObjLst(List<clsPrjConstraintEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsPrjConstraintWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsPrjConstraintWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsPrjConstraintEN._CurrTabName, strPrjId);
List<clsPrjConstraintEN> arrPrjConstraintObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrPrjConstraintObjLstCache = CacheHelper.Get<List<clsPrjConstraintEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrPrjConstraintObjLstCache = CacheHelper.Get<List<clsPrjConstraintEN>>(strKey);
}
return arrPrjConstraintObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsPrjConstraintEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conPrjConstraint.PrjConstraintId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjConstraint.ConstraintName, Type.GetType("System.String"));
objDT.Columns.Add(conPrjConstraint.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjConstraint.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjConstraint.ConstraintTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjConstraint.ConstraintDescription, Type.GetType("System.String"));
objDT.Columns.Add(conPrjConstraint.CreateUserId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjConstraint.IsNullable, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjConstraint.CheckDate, Type.GetType("System.String"));
objDT.Columns.Add(conPrjConstraint.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conPrjConstraint.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjConstraint.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conPrjConstraint.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conPrjConstraint.Memo, Type.GetType("System.String"));
foreach (clsPrjConstraintEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conPrjConstraint.PrjConstraintId] = objInFor[conPrjConstraint.PrjConstraintId];
objDR[conPrjConstraint.ConstraintName] = objInFor[conPrjConstraint.ConstraintName];
objDR[conPrjConstraint.PrjId] = objInFor[conPrjConstraint.PrjId];
objDR[conPrjConstraint.TabId] = objInFor[conPrjConstraint.TabId];
objDR[conPrjConstraint.ConstraintTypeId] = objInFor[conPrjConstraint.ConstraintTypeId];
objDR[conPrjConstraint.ConstraintDescription] = objInFor[conPrjConstraint.ConstraintDescription];
objDR[conPrjConstraint.CreateUserId] = objInFor[conPrjConstraint.CreateUserId];
objDR[conPrjConstraint.IsNullable] = objInFor[conPrjConstraint.IsNullable];
objDR[conPrjConstraint.CheckDate] = objInFor[conPrjConstraint.CheckDate];
objDR[conPrjConstraint.ErrMsg] = objInFor[conPrjConstraint.ErrMsg];
objDR[conPrjConstraint.InUse] = objInFor[conPrjConstraint.InUse];
objDR[conPrjConstraint.UpdDate] = objInFor[conPrjConstraint.UpdDate];
objDR[conPrjConstraint.UpdUser] = objInFor[conPrjConstraint.UpdUser];
objDR[conPrjConstraint.Memo] = objInFor[conPrjConstraint.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 约束(PrjConstraint)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4PrjConstraint : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
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
clsPrjConstraintWApi.ReFreshThisCache();
}
}

}