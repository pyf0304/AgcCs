
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsConstraintFieldsWApi
 表名:ConstraintFields(00050334)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsConstraintFieldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetmId(this clsConstraintFieldsEN objConstraintFieldsEN, long lngmId, string strComparisonOp="")
	{
objConstraintFieldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.mId) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.mId, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.mId] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjConstraintId">约束表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetPrjConstraintId(this clsConstraintFieldsEN objConstraintFieldsEN, string strPrjConstraintId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjConstraintId, conConstraintFields.PrjConstraintId);
clsCheckSql.CheckFieldLen(strPrjConstraintId, 8, conConstraintFields.PrjConstraintId);
clsCheckSql.CheckFieldForeignKey(strPrjConstraintId, 8, conConstraintFields.PrjConstraintId);
objConstraintFieldsEN.PrjConstraintId = strPrjConstraintId; //约束表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.PrjConstraintId) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.PrjConstraintId, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.PrjConstraintId] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetTabId(this clsConstraintFieldsEN objConstraintFieldsEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conConstraintFields.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, conConstraintFields.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conConstraintFields.TabId);
objConstraintFieldsEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.TabId) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.TabId, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.TabId] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetFldId(this clsConstraintFieldsEN objConstraintFieldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, conConstraintFields.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, conConstraintFields.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conConstraintFields.FldId);
objConstraintFieldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.FldId) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.FldId, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.FldId] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMaxValue">最大值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetMaxValue(this clsConstraintFieldsEN objConstraintFieldsEN, string strMaxValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMaxValue, 50, conConstraintFields.MaxValue);
objConstraintFieldsEN.MaxValue = strMaxValue; //最大值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.MaxValue) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.MaxValue, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.MaxValue] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMinValue">最小值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetMinValue(this clsConstraintFieldsEN objConstraintFieldsEN, string strMinValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMinValue, 50, conConstraintFields.MinValue);
objConstraintFieldsEN.MinValue = strMinValue; //最小值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.MinValue) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.MinValue, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.MinValue] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strSortTypeId">排序类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetSortTypeId(this clsConstraintFieldsEN objConstraintFieldsEN, string strSortTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSortTypeId, conConstraintFields.SortTypeId);
clsCheckSql.CheckFieldLen(strSortTypeId, 2, conConstraintFields.SortTypeId);
clsCheckSql.CheckFieldForeignKey(strSortTypeId, 2, conConstraintFields.SortTypeId);
objConstraintFieldsEN.SortTypeId = strSortTypeId; //排序类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.SortTypeId) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.SortTypeId, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.SortTypeId] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetInUse(this clsConstraintFieldsEN objConstraintFieldsEN, bool bolInUse, string strComparisonOp="")
	{
objConstraintFieldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.InUse) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.InUse, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.InUse] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetOrderNum(this clsConstraintFieldsEN objConstraintFieldsEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conConstraintFields.OrderNum);
objConstraintFieldsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.OrderNum) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.OrderNum, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.OrderNum] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetPrjId(this clsConstraintFieldsEN objConstraintFieldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, conConstraintFields.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conConstraintFields.PrjId);
objConstraintFieldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.PrjId) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.PrjId, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.PrjId] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetUpdDate(this clsConstraintFieldsEN objConstraintFieldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conConstraintFields.UpdDate);
objConstraintFieldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.UpdDate) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.UpdDate, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.UpdDate] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetUpdUser(this clsConstraintFieldsEN objConstraintFieldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conConstraintFields.UpdUser);
objConstraintFieldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.UpdUser) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.UpdUser, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.UpdUser] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConstraintFieldsEN SetMemo(this clsConstraintFieldsEN objConstraintFieldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conConstraintFields.Memo);
objConstraintFieldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConstraintFieldsEN.dicFldComparisonOp.ContainsKey(conConstraintFields.Memo) == false)
{
objConstraintFieldsEN.dicFldComparisonOp.Add(conConstraintFields.Memo, strComparisonOp);
}
else
{
objConstraintFieldsEN.dicFldComparisonOp[conConstraintFields.Memo] = strComparisonOp;
}
}
return objConstraintFieldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsConstraintFieldsEN objConstraintFieldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.mId) == true)
{
string strComparisonOpmId = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conConstraintFields.mId, objConstraintFieldsCond.mId, strComparisonOpmId);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.PrjConstraintId) == true)
{
string strComparisonOpPrjConstraintId = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.PrjConstraintId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.PrjConstraintId, objConstraintFieldsCond.PrjConstraintId, strComparisonOpPrjConstraintId);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.TabId) == true)
{
string strComparisonOpTabId = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.TabId, objConstraintFieldsCond.TabId, strComparisonOpTabId);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.FldId) == true)
{
string strComparisonOpFldId = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.FldId, objConstraintFieldsCond.FldId, strComparisonOpFldId);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.MaxValue) == true)
{
string strComparisonOpMaxValue = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.MaxValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.MaxValue, objConstraintFieldsCond.MaxValue, strComparisonOpMaxValue);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.MinValue) == true)
{
string strComparisonOpMinValue = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.MinValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.MinValue, objConstraintFieldsCond.MinValue, strComparisonOpMinValue);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.SortTypeId) == true)
{
string strComparisonOpSortTypeId = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.SortTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.SortTypeId, objConstraintFieldsCond.SortTypeId, strComparisonOpSortTypeId);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.InUse) == true)
{
if (objConstraintFieldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conConstraintFields.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conConstraintFields.InUse);
}
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.OrderNum) == true)
{
string strComparisonOpOrderNum = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conConstraintFields.OrderNum, objConstraintFieldsCond.OrderNum, strComparisonOpOrderNum);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.PrjId) == true)
{
string strComparisonOpPrjId = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.PrjId, objConstraintFieldsCond.PrjId, strComparisonOpPrjId);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.UpdDate) == true)
{
string strComparisonOpUpdDate = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.UpdDate, objConstraintFieldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.UpdUser) == true)
{
string strComparisonOpUpdUser = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.UpdUser, objConstraintFieldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objConstraintFieldsCond.IsUpdated(conConstraintFields.Memo) == true)
{
string strComparisonOpMemo = objConstraintFieldsCond.dicFldComparisonOp[conConstraintFields.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConstraintFields.Memo, objConstraintFieldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsConstraintFieldsEN objConstraintFieldsEN)
{
 if (objConstraintFieldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objConstraintFieldsEN.sfUpdFldSetStr = objConstraintFieldsEN.getsfUpdFldSetStr();
clsConstraintFieldsWApi.CheckPropertyNew(objConstraintFieldsEN); 
bool bolResult = clsConstraintFieldsWApi.UpdateRecord(objConstraintFieldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsWApi.ReFreshCache(objConstraintFieldsEN.PrjId);
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
 /// 获取唯一性条件串--ConstraintFields(约束字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:Uni_ConstraintField
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsConstraintFieldsEN objConstraintFieldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objConstraintFieldsEN == null) return "";
if (objConstraintFieldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjConstraintId = '{0}'", objConstraintFieldsEN.PrjConstraintId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objConstraintFieldsEN.FldId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objConstraintFieldsEN.mId);
 sbCondition.AppendFormat(" and PrjConstraintId = '{0}'", objConstraintFieldsEN.PrjConstraintId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objConstraintFieldsEN.FldId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsConstraintFieldsEN objConstraintFieldsEN)
{
try
{
clsConstraintFieldsWApi.CheckPropertyNew(objConstraintFieldsEN); 
bool bolResult = clsConstraintFieldsWApi.AddNewRecord(objConstraintFieldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsWApi.ReFreshCache(objConstraintFieldsEN.PrjId);
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsConstraintFieldsEN objConstraintFieldsEN, string strWhereCond)
{
try
{
clsConstraintFieldsWApi.CheckPropertyNew(objConstraintFieldsEN); 
bool bolResult = clsConstraintFieldsWApi.UpdateWithCondition(objConstraintFieldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsWApi.ReFreshCache(objConstraintFieldsEN.PrjId);
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
 /// 约束字段(ConstraintFields)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsConstraintFieldsWApi
{
private static readonly string mstrApiControllerName = "ConstraintFieldsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsConstraintFieldsWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsConstraintFieldsEN objConstraintFieldsEN)
{
if (!Object.Equals(null, objConstraintFieldsEN.PrjConstraintId) && GetStrLen(objConstraintFieldsEN.PrjConstraintId) > 8)
{
 throw new Exception("字段[约束表Id]的长度不能超过8!");
}
if (!Object.Equals(null, objConstraintFieldsEN.TabId) && GetStrLen(objConstraintFieldsEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objConstraintFieldsEN.FldId) && GetStrLen(objConstraintFieldsEN.FldId) > 8)
{
 throw new Exception("字段[字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objConstraintFieldsEN.MaxValue) && GetStrLen(objConstraintFieldsEN.MaxValue) > 50)
{
 throw new Exception("字段[最大值]的长度不能超过50!");
}
if (!Object.Equals(null, objConstraintFieldsEN.MinValue) && GetStrLen(objConstraintFieldsEN.MinValue) > 50)
{
 throw new Exception("字段[最小值]的长度不能超过50!");
}
if (!Object.Equals(null, objConstraintFieldsEN.SortTypeId) && GetStrLen(objConstraintFieldsEN.SortTypeId) > 2)
{
 throw new Exception("字段[排序类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objConstraintFieldsEN.PrjId) && GetStrLen(objConstraintFieldsEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objConstraintFieldsEN.UpdDate) && GetStrLen(objConstraintFieldsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objConstraintFieldsEN.UpdUser) && GetStrLen(objConstraintFieldsEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objConstraintFieldsEN.Memo) && GetStrLen(objConstraintFieldsEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objConstraintFieldsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsConstraintFieldsEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsConstraintFieldsEN objConstraintFieldsEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objConstraintFieldsEN = JsonConvert.DeserializeObject<clsConstraintFieldsEN>(strJson);
return objConstraintFieldsEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsConstraintFieldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsConstraintFieldsEN objConstraintFieldsEN;
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
objConstraintFieldsEN = JsonConvert.DeserializeObject<clsConstraintFieldsEN>(strJson);
return objConstraintFieldsEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsConstraintFieldsEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsConstraintFieldsEN._CurrTabName, strPrjId);
List<clsConstraintFieldsEN> arrConstraintFieldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsConstraintFieldsEN> arrConstraintFieldsObjLst_Sel =
from objConstraintFieldsEN in arrConstraintFieldsObjLstCache
where objConstraintFieldsEN.mId == lngmId 
select objConstraintFieldsEN;
if (arrConstraintFieldsObjLst_Sel.Count() == 0)
{
   clsConstraintFieldsEN obj = clsConstraintFieldsWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrConstraintFieldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsConstraintFieldsEN> GetObjLst(string strWhereCond)
{
 List<clsConstraintFieldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsConstraintFieldsEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsConstraintFieldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsConstraintFieldsEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsConstraintFieldsEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsConstraintFieldsEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsConstraintFieldsEN._CurrTabName, strPrjId);
List<clsConstraintFieldsEN> arrConstraintFieldsObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsConstraintFieldsEN> arrConstraintFieldsObjLst_Sel =
from objConstraintFieldsEN in arrConstraintFieldsObjLstCache
where arrMId.Contains(objConstraintFieldsEN.mId)
select objConstraintFieldsEN;
return arrConstraintFieldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsConstraintFieldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsConstraintFieldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsConstraintFieldsEN>>(strJson);
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
public static List<clsConstraintFieldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsConstraintFieldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsConstraintFieldsEN>>(strJson);
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
public static List<clsConstraintFieldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsConstraintFieldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsConstraintFieldsEN>>(strJson);
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
public static List<clsConstraintFieldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsConstraintFieldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsConstraintFieldsEN>>(strJson);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
try
{
 clsConstraintFieldsEN objConstraintFieldsEN = clsConstraintFieldsWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsConstraintFieldsWApi.ReFreshCache(objConstraintFieldsEN.PrjId);
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
public static int DelConstraintFieldss(List<string> arrmId)
{
string strAction = "DelConstraintFieldss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsConstraintFieldsEN objConstraintFieldsEN = clsConstraintFieldsWApi.GetObjBymId(long.Parse(arrmId[0]));
clsConstraintFieldsWApi.ReFreshCache(objConstraintFieldsEN.PrjId);
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
public static int DelConstraintFieldssByCond(string strWhereCond)
{
string strAction = "DelConstraintFieldssByCond";
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
public static bool AddNewRecord(clsConstraintFieldsEN objConstraintFieldsEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsConstraintFieldsEN>(objConstraintFieldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsWApi.ReFreshCache(objConstraintFieldsEN.PrjId);
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsConstraintFieldsEN objConstraintFieldsEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsConstraintFieldsEN>(objConstraintFieldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConstraintFieldsWApi.ReFreshCache(objConstraintFieldsEN.PrjId);
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsConstraintFieldsEN objConstraintFieldsEN)
{
if (string.IsNullOrEmpty(objConstraintFieldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objConstraintFieldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsConstraintFieldsEN>(objConstraintFieldsEN);
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
 /// <param name = "objConstraintFieldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsConstraintFieldsEN objConstraintFieldsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objConstraintFieldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objConstraintFieldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objConstraintFieldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsConstraintFieldsEN>(objConstraintFieldsEN);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
 /// <param name = "objConstraintFieldsENS">源对象</param>
 /// <param name = "objConstraintFieldsENT">目标对象</param>
 public static void CopyTo(clsConstraintFieldsEN objConstraintFieldsENS, clsConstraintFieldsEN objConstraintFieldsENT)
{
try
{
objConstraintFieldsENT.mId = objConstraintFieldsENS.mId; //mId
objConstraintFieldsENT.PrjConstraintId = objConstraintFieldsENS.PrjConstraintId; //约束表Id
objConstraintFieldsENT.TabId = objConstraintFieldsENS.TabId; //表ID
objConstraintFieldsENT.FldId = objConstraintFieldsENS.FldId; //字段Id
objConstraintFieldsENT.MaxValue = objConstraintFieldsENS.MaxValue; //最大值
objConstraintFieldsENT.MinValue = objConstraintFieldsENS.MinValue; //最小值
objConstraintFieldsENT.SortTypeId = objConstraintFieldsENS.SortTypeId; //排序类型Id
objConstraintFieldsENT.InUse = objConstraintFieldsENS.InUse; //是否在用
objConstraintFieldsENT.OrderNum = objConstraintFieldsENS.OrderNum; //序号
objConstraintFieldsENT.PrjId = objConstraintFieldsENS.PrjId; //工程Id
objConstraintFieldsENT.UpdDate = objConstraintFieldsENS.UpdDate; //修改日期
objConstraintFieldsENT.UpdUser = objConstraintFieldsENS.UpdUser; //修改者
objConstraintFieldsENT.Memo = objConstraintFieldsENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsConstraintFieldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsConstraintFieldsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsConstraintFieldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsConstraintFieldsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsConstraintFieldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsConstraintFieldsEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId = "")
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsConstraintFieldsWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsConstraintFieldsWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsConstraintFieldsEN._CurrTabName, strPrjId);
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
if (clsConstraintFieldsWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsConstraintFieldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsConstraintFieldsWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsConstraintFieldsEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsConstraintFieldsWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsConstraintFieldsWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsConstraintFieldsEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsConstraintFieldsEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conConstraintFields.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsConstraintFieldsEN._CurrTabName, strPrjId);
List<clsConstraintFieldsEN> arrConstraintFieldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrConstraintFieldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsConstraintFieldsEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsConstraintFieldsEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsConstraintFieldsWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsConstraintFieldsWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsConstraintFieldsEN._CurrTabName, strPrjId);
List<clsConstraintFieldsEN> arrConstraintFieldsObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrConstraintFieldsObjLstCache = CacheHelper.Get<List<clsConstraintFieldsEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrConstraintFieldsObjLstCache = CacheHelper.Get<List<clsConstraintFieldsEN>>(strKey);
}
return arrConstraintFieldsObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsConstraintFieldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conConstraintFields.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conConstraintFields.PrjConstraintId, Type.GetType("System.String"));
objDT.Columns.Add(conConstraintFields.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conConstraintFields.FldId, Type.GetType("System.String"));
objDT.Columns.Add(conConstraintFields.MaxValue, Type.GetType("System.String"));
objDT.Columns.Add(conConstraintFields.MinValue, Type.GetType("System.String"));
objDT.Columns.Add(conConstraintFields.SortTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conConstraintFields.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conConstraintFields.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conConstraintFields.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conConstraintFields.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conConstraintFields.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conConstraintFields.Memo, Type.GetType("System.String"));
foreach (clsConstraintFieldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conConstraintFields.mId] = objInFor[conConstraintFields.mId];
objDR[conConstraintFields.PrjConstraintId] = objInFor[conConstraintFields.PrjConstraintId];
objDR[conConstraintFields.TabId] = objInFor[conConstraintFields.TabId];
objDR[conConstraintFields.FldId] = objInFor[conConstraintFields.FldId];
objDR[conConstraintFields.MaxValue] = objInFor[conConstraintFields.MaxValue];
objDR[conConstraintFields.MinValue] = objInFor[conConstraintFields.MinValue];
objDR[conConstraintFields.SortTypeId] = objInFor[conConstraintFields.SortTypeId];
objDR[conConstraintFields.InUse] = objInFor[conConstraintFields.InUse];
objDR[conConstraintFields.OrderNum] = objInFor[conConstraintFields.OrderNum];
objDR[conConstraintFields.PrjId] = objInFor[conConstraintFields.PrjId];
objDR[conConstraintFields.UpdDate] = objInFor[conConstraintFields.UpdDate];
objDR[conConstraintFields.UpdUser] = objInFor[conConstraintFields.UpdUser];
objDR[conConstraintFields.Memo] = objInFor[conConstraintFields.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 约束字段(ConstraintFields)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ConstraintFields : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
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
clsConstraintFieldsWApi.ReFreshThisCache(strPrjId);
}
}

}