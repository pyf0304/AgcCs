
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabFeatureFldsWApi
 表名:TabFeatureFlds(00050455)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:23
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
public static class  clsTabFeatureFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureFldsEN SetmId(this clsTabFeatureFldsEN objTabFeatureFldsEN, long lngmId, string strComparisonOp="")
	{
objTabFeatureFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(conTabFeatureFlds.mId) == false)
{
objTabFeatureFldsEN.dicFldComparisonOp.Add(conTabFeatureFlds.mId, strComparisonOp);
}
else
{
objTabFeatureFldsEN.dicFldComparisonOp[conTabFeatureFlds.mId] = strComparisonOp;
}
}
return objTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureId">表功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureFldsEN SetTabFeatureId(this clsTabFeatureFldsEN objTabFeatureFldsEN, string strTabFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, conTabFeatureFlds.TabFeatureId);
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, conTabFeatureFlds.TabFeatureId);
objTabFeatureFldsEN.TabFeatureId = strTabFeatureId; //表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(conTabFeatureFlds.TabFeatureId) == false)
{
objTabFeatureFldsEN.dicFldComparisonOp.Add(conTabFeatureFlds.TabFeatureId, strComparisonOp);
}
else
{
objTabFeatureFldsEN.dicFldComparisonOp[conTabFeatureFlds.TabFeatureId] = strComparisonOp;
}
}
return objTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureFldsEN SetFldId(this clsTabFeatureFldsEN objTabFeatureFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, conTabFeatureFlds.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conTabFeatureFlds.FldId);
objTabFeatureFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(conTabFeatureFlds.FldId) == false)
{
objTabFeatureFldsEN.dicFldComparisonOp.Add(conTabFeatureFlds.FldId, strComparisonOp);
}
else
{
objTabFeatureFldsEN.dicFldComparisonOp[conTabFeatureFlds.FldId] = strComparisonOp;
}
}
return objTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsCurrTab">是否当前表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureFldsEN SetIsCurrTab(this clsTabFeatureFldsEN objTabFeatureFldsEN, bool bolIsCurrTab, string strComparisonOp="")
	{
objTabFeatureFldsEN.IsCurrTab = bolIsCurrTab; //是否当前表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(conTabFeatureFlds.IsCurrTab) == false)
{
objTabFeatureFldsEN.dicFldComparisonOp.Add(conTabFeatureFlds.IsCurrTab, strComparisonOp);
}
else
{
objTabFeatureFldsEN.dicFldComparisonOp[conTabFeatureFlds.IsCurrTab] = strComparisonOp;
}
}
return objTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureFldsEN SetFieldTypeId(this clsTabFeatureFldsEN objTabFeatureFldsEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldTypeId, conTabFeatureFlds.FieldTypeId);
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, conTabFeatureFlds.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, conTabFeatureFlds.FieldTypeId);
objTabFeatureFldsEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(conTabFeatureFlds.FieldTypeId) == false)
{
objTabFeatureFldsEN.dicFldComparisonOp.Add(conTabFeatureFlds.FieldTypeId, strComparisonOp);
}
else
{
objTabFeatureFldsEN.dicFldComparisonOp[conTabFeatureFlds.FieldTypeId] = strComparisonOp;
}
}
return objTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureFldsEN SetFuncName(this clsTabFeatureFldsEN objTabFeatureFldsEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncName, 100, conTabFeatureFlds.FuncName);
objTabFeatureFldsEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(conTabFeatureFlds.FuncName) == false)
{
objTabFeatureFldsEN.dicFldComparisonOp.Add(conTabFeatureFlds.FuncName, strComparisonOp);
}
else
{
objTabFeatureFldsEN.dicFldComparisonOp[conTabFeatureFlds.FuncName] = strComparisonOp;
}
}
return objTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strValueGivingModeId">给值方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureFldsEN SetValueGivingModeId(this clsTabFeatureFldsEN objTabFeatureFldsEN, string strValueGivingModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strValueGivingModeId, 2, conTabFeatureFlds.ValueGivingModeId);
clsCheckSql.CheckFieldForeignKey(strValueGivingModeId, 2, conTabFeatureFlds.ValueGivingModeId);
objTabFeatureFldsEN.ValueGivingModeId = strValueGivingModeId; //给值方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(conTabFeatureFlds.ValueGivingModeId) == false)
{
objTabFeatureFldsEN.dicFldComparisonOp.Add(conTabFeatureFlds.ValueGivingModeId, strComparisonOp);
}
else
{
objTabFeatureFldsEN.dicFldComparisonOp[conTabFeatureFlds.ValueGivingModeId] = strComparisonOp;
}
}
return objTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureFldsEN SetDefaultValue(this clsTabFeatureFldsEN objTabFeatureFldsEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, conTabFeatureFlds.DefaultValue);
objTabFeatureFldsEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(conTabFeatureFlds.DefaultValue) == false)
{
objTabFeatureFldsEN.dicFldComparisonOp.Add(conTabFeatureFlds.DefaultValue, strComparisonOp);
}
else
{
objTabFeatureFldsEN.dicFldComparisonOp[conTabFeatureFlds.DefaultValue] = strComparisonOp;
}
}
return objTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureFldsEN SetPrjId(this clsTabFeatureFldsEN objTabFeatureFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conTabFeatureFlds.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conTabFeatureFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conTabFeatureFlds.PrjId);
objTabFeatureFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(conTabFeatureFlds.PrjId) == false)
{
objTabFeatureFldsEN.dicFldComparisonOp.Add(conTabFeatureFlds.PrjId, strComparisonOp);
}
else
{
objTabFeatureFldsEN.dicFldComparisonOp[conTabFeatureFlds.PrjId] = strComparisonOp;
}
}
return objTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureFldsEN SetOrderNum(this clsTabFeatureFldsEN objTabFeatureFldsEN, int intOrderNum, string strComparisonOp="")
	{
objTabFeatureFldsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(conTabFeatureFlds.OrderNum) == false)
{
objTabFeatureFldsEN.dicFldComparisonOp.Add(conTabFeatureFlds.OrderNum, strComparisonOp);
}
else
{
objTabFeatureFldsEN.dicFldComparisonOp[conTabFeatureFlds.OrderNum] = strComparisonOp;
}
}
return objTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureFldsEN SetInUse(this clsTabFeatureFldsEN objTabFeatureFldsEN, bool bolInUse, string strComparisonOp="")
	{
objTabFeatureFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(conTabFeatureFlds.InUse) == false)
{
objTabFeatureFldsEN.dicFldComparisonOp.Add(conTabFeatureFlds.InUse, strComparisonOp);
}
else
{
objTabFeatureFldsEN.dicFldComparisonOp[conTabFeatureFlds.InUse] = strComparisonOp;
}
}
return objTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureFldsEN SetUpdUser(this clsTabFeatureFldsEN objTabFeatureFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conTabFeatureFlds.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conTabFeatureFlds.UpdUser);
objTabFeatureFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(conTabFeatureFlds.UpdUser) == false)
{
objTabFeatureFldsEN.dicFldComparisonOp.Add(conTabFeatureFlds.UpdUser, strComparisonOp);
}
else
{
objTabFeatureFldsEN.dicFldComparisonOp[conTabFeatureFlds.UpdUser] = strComparisonOp;
}
}
return objTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureFldsEN SetUpdDate(this clsTabFeatureFldsEN objTabFeatureFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTabFeatureFlds.UpdDate);
objTabFeatureFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(conTabFeatureFlds.UpdDate) == false)
{
objTabFeatureFldsEN.dicFldComparisonOp.Add(conTabFeatureFlds.UpdDate, strComparisonOp);
}
else
{
objTabFeatureFldsEN.dicFldComparisonOp[conTabFeatureFlds.UpdDate] = strComparisonOp;
}
}
return objTabFeatureFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTabFeatureFldsEN SetMemo(this clsTabFeatureFldsEN objTabFeatureFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTabFeatureFlds.Memo);
objTabFeatureFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTabFeatureFldsEN.dicFldComparisonOp.ContainsKey(conTabFeatureFlds.Memo) == false)
{
objTabFeatureFldsEN.dicFldComparisonOp.Add(conTabFeatureFlds.Memo, strComparisonOp);
}
else
{
objTabFeatureFldsEN.dicFldComparisonOp[conTabFeatureFlds.Memo] = strComparisonOp;
}
}
return objTabFeatureFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTabFeatureFldsEN objTabFeatureFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTabFeatureFldsCond.IsUpdated(conTabFeatureFlds.mId) == true)
{
string strComparisonOpmId = objTabFeatureFldsCond.dicFldComparisonOp[conTabFeatureFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFeatureFlds.mId, objTabFeatureFldsCond.mId, strComparisonOpmId);
}
if (objTabFeatureFldsCond.IsUpdated(conTabFeatureFlds.TabFeatureId) == true)
{
string strComparisonOpTabFeatureId = objTabFeatureFldsCond.dicFldComparisonOp[conTabFeatureFlds.TabFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeatureFlds.TabFeatureId, objTabFeatureFldsCond.TabFeatureId, strComparisonOpTabFeatureId);
}
if (objTabFeatureFldsCond.IsUpdated(conTabFeatureFlds.FldId) == true)
{
string strComparisonOpFldId = objTabFeatureFldsCond.dicFldComparisonOp[conTabFeatureFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeatureFlds.FldId, objTabFeatureFldsCond.FldId, strComparisonOpFldId);
}
if (objTabFeatureFldsCond.IsUpdated(conTabFeatureFlds.IsCurrTab) == true)
{
if (objTabFeatureFldsCond.IsCurrTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeatureFlds.IsCurrTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeatureFlds.IsCurrTab);
}
}
if (objTabFeatureFldsCond.IsUpdated(conTabFeatureFlds.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objTabFeatureFldsCond.dicFldComparisonOp[conTabFeatureFlds.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeatureFlds.FieldTypeId, objTabFeatureFldsCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objTabFeatureFldsCond.IsUpdated(conTabFeatureFlds.FuncName) == true)
{
string strComparisonOpFuncName = objTabFeatureFldsCond.dicFldComparisonOp[conTabFeatureFlds.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeatureFlds.FuncName, objTabFeatureFldsCond.FuncName, strComparisonOpFuncName);
}
if (objTabFeatureFldsCond.IsUpdated(conTabFeatureFlds.ValueGivingModeId) == true)
{
string strComparisonOpValueGivingModeId = objTabFeatureFldsCond.dicFldComparisonOp[conTabFeatureFlds.ValueGivingModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeatureFlds.ValueGivingModeId, objTabFeatureFldsCond.ValueGivingModeId, strComparisonOpValueGivingModeId);
}
if (objTabFeatureFldsCond.IsUpdated(conTabFeatureFlds.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objTabFeatureFldsCond.dicFldComparisonOp[conTabFeatureFlds.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeatureFlds.DefaultValue, objTabFeatureFldsCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objTabFeatureFldsCond.IsUpdated(conTabFeatureFlds.PrjId) == true)
{
string strComparisonOpPrjId = objTabFeatureFldsCond.dicFldComparisonOp[conTabFeatureFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeatureFlds.PrjId, objTabFeatureFldsCond.PrjId, strComparisonOpPrjId);
}
if (objTabFeatureFldsCond.IsUpdated(conTabFeatureFlds.OrderNum) == true)
{
string strComparisonOpOrderNum = objTabFeatureFldsCond.dicFldComparisonOp[conTabFeatureFlds.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conTabFeatureFlds.OrderNum, objTabFeatureFldsCond.OrderNum, strComparisonOpOrderNum);
}
if (objTabFeatureFldsCond.IsUpdated(conTabFeatureFlds.InUse) == true)
{
if (objTabFeatureFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTabFeatureFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTabFeatureFlds.InUse);
}
}
if (objTabFeatureFldsCond.IsUpdated(conTabFeatureFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objTabFeatureFldsCond.dicFldComparisonOp[conTabFeatureFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeatureFlds.UpdUser, objTabFeatureFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objTabFeatureFldsCond.IsUpdated(conTabFeatureFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objTabFeatureFldsCond.dicFldComparisonOp[conTabFeatureFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeatureFlds.UpdDate, objTabFeatureFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objTabFeatureFldsCond.IsUpdated(conTabFeatureFlds.Memo) == true)
{
string strComparisonOpMemo = objTabFeatureFldsCond.dicFldComparisonOp[conTabFeatureFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTabFeatureFlds.Memo, objTabFeatureFldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTabFeatureFldsEN objTabFeatureFldsEN)
{
 if (objTabFeatureFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objTabFeatureFldsEN.sfUpdFldSetStr = objTabFeatureFldsEN.getsfUpdFldSetStr();
clsTabFeatureFldsWApi.CheckPropertyNew(objTabFeatureFldsEN); 
bool bolResult = clsTabFeatureFldsWApi.UpdateRecord(objTabFeatureFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureFldsWApi.ReFreshCache(objTabFeatureFldsEN.PrjId);
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
 /// 获取唯一性条件串--TabFeatureFlds(表功能字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabFeatureId_FieldTypeId_FldId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsTabFeatureFldsEN objTabFeatureFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objTabFeatureFldsEN == null) return "";
if (objTabFeatureFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabFeatureId = '{0}'", objTabFeatureFldsEN.TabFeatureId);
 sbCondition.AppendFormat(" and FieldTypeId = '{0}'", objTabFeatureFldsEN.FieldTypeId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objTabFeatureFldsEN.FldId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objTabFeatureFldsEN.mId);
 sbCondition.AppendFormat(" and TabFeatureId = '{0}'", objTabFeatureFldsEN.TabFeatureId);
 sbCondition.AppendFormat(" and FieldTypeId = '{0}'", objTabFeatureFldsEN.FieldTypeId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objTabFeatureFldsEN.FldId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTabFeatureFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTabFeatureFldsEN objTabFeatureFldsEN)
{
try
{
clsTabFeatureFldsWApi.CheckPropertyNew(objTabFeatureFldsEN); 
bool bolResult = clsTabFeatureFldsWApi.AddNewRecord(objTabFeatureFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureFldsWApi.ReFreshCache(objTabFeatureFldsEN.PrjId);
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
 /// <param name = "objTabFeatureFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTabFeatureFldsEN objTabFeatureFldsEN, string strWhereCond)
{
try
{
clsTabFeatureFldsWApi.CheckPropertyNew(objTabFeatureFldsEN); 
bool bolResult = clsTabFeatureFldsWApi.UpdateWithCondition(objTabFeatureFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureFldsWApi.ReFreshCache(objTabFeatureFldsEN.PrjId);
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
 /// 表功能字段(TabFeatureFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsTabFeatureFldsWApi
{
private static readonly string mstrApiControllerName = "TabFeatureFldsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsTabFeatureFldsWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsTabFeatureFldsEN objTabFeatureFldsEN)
{
if (!Object.Equals(null, objTabFeatureFldsEN.TabFeatureId) && GetStrLen(objTabFeatureFldsEN.TabFeatureId) > 8)
{
 throw new Exception("字段[表功能Id]的长度不能超过8!");
}
if (!Object.Equals(null, objTabFeatureFldsEN.FldId) && GetStrLen(objTabFeatureFldsEN.FldId) > 8)
{
 throw new Exception("字段[字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objTabFeatureFldsEN.FieldTypeId) && GetStrLen(objTabFeatureFldsEN.FieldTypeId) > 2)
{
 throw new Exception("字段[字段类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objTabFeatureFldsEN.FuncName) && GetStrLen(objTabFeatureFldsEN.FuncName) > 100)
{
 throw new Exception("字段[函数名]的长度不能超过100!");
}
if (!Object.Equals(null, objTabFeatureFldsEN.ValueGivingModeId) && GetStrLen(objTabFeatureFldsEN.ValueGivingModeId) > 2)
{
 throw new Exception("字段[给值方式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objTabFeatureFldsEN.DefaultValue) && GetStrLen(objTabFeatureFldsEN.DefaultValue) > 50)
{
 throw new Exception("字段[缺省值]的长度不能超过50!");
}
if (!Object.Equals(null, objTabFeatureFldsEN.PrjId) && GetStrLen(objTabFeatureFldsEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objTabFeatureFldsEN.UpdUser) && GetStrLen(objTabFeatureFldsEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objTabFeatureFldsEN.UpdDate) && GetStrLen(objTabFeatureFldsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objTabFeatureFldsEN.Memo) && GetStrLen(objTabFeatureFldsEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objTabFeatureFldsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTabFeatureFldsEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsTabFeatureFldsEN objTabFeatureFldsEN;
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
objTabFeatureFldsEN = JsonConvert.DeserializeObject<clsTabFeatureFldsEN>(strJson);
return objTabFeatureFldsEN;
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
public static clsTabFeatureFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsTabFeatureFldsEN objTabFeatureFldsEN;
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
objTabFeatureFldsEN = JsonConvert.DeserializeObject<clsTabFeatureFldsEN>(strJson);
return objTabFeatureFldsEN;
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
public static clsTabFeatureFldsEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsTabFeatureFldsEN._CurrTabName, strPrjId);
List<clsTabFeatureFldsEN> arrTabFeatureFldsObjLstCache = GetObjLstCache();
IEnumerable <clsTabFeatureFldsEN> arrTabFeatureFldsObjLst_Sel =
from objTabFeatureFldsEN in arrTabFeatureFldsObjLstCache
where objTabFeatureFldsEN.mId == lngmId 
select objTabFeatureFldsEN;
if (arrTabFeatureFldsObjLst_Sel.Count() == 0)
{
   clsTabFeatureFldsEN obj = clsTabFeatureFldsWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrTabFeatureFldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFeatureFldsEN> GetObjLst(string strWhereCond)
{
 List<clsTabFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFeatureFldsEN>>(strJson);
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
public static List<clsTabFeatureFldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsTabFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFeatureFldsEN>>(strJson);
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
public static IEnumerable<clsTabFeatureFldsEN> GetObjLstByMIdLstCache(List<long> arrMId, )
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsTabFeatureFldsEN._CurrTabName, strPrjId);
List<clsTabFeatureFldsEN> arrTabFeatureFldsObjLstCache = GetObjLstCache();
IEnumerable <clsTabFeatureFldsEN> arrTabFeatureFldsObjLst_Sel =
from objTabFeatureFldsEN in arrTabFeatureFldsObjLstCache
where arrMId.Contains(objTabFeatureFldsEN.mId)
select objTabFeatureFldsEN;
return arrTabFeatureFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTabFeatureFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsTabFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFeatureFldsEN>>(strJson);
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
public static List<clsTabFeatureFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsTabFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFeatureFldsEN>>(strJson);
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
public static List<clsTabFeatureFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsTabFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFeatureFldsEN>>(strJson);
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
public static List<clsTabFeatureFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsTabFeatureFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTabFeatureFldsEN>>(strJson);
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
 clsTabFeatureFldsEN objTabFeatureFldsEN = clsTabFeatureFldsWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsTabFeatureFldsWApi.ReFreshCache(objTabFeatureFldsEN.PrjId);
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
public static int DelTabFeatureFldss(List<string> arrmId)
{
string strAction = "DelTabFeatureFldss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsTabFeatureFldsEN objTabFeatureFldsEN = clsTabFeatureFldsWApi.GetObjBymId(long.Parse(arrmId[0]));
clsTabFeatureFldsWApi.ReFreshCache(objTabFeatureFldsEN.PrjId);
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
public static int DelTabFeatureFldssByCond(string strWhereCond)
{
string strAction = "DelTabFeatureFldssByCond";
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
public static bool AddNewRecord(clsTabFeatureFldsEN objTabFeatureFldsEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabFeatureFldsEN>(objTabFeatureFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureFldsWApi.ReFreshCache(objTabFeatureFldsEN.PrjId);
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
 /// <param name = "objTabFeatureFldsEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsTabFeatureFldsEN objTabFeatureFldsEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabFeatureFldsEN>(objTabFeatureFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTabFeatureFldsWApi.ReFreshCache(objTabFeatureFldsEN.PrjId);
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
public static bool UpdateRecord(clsTabFeatureFldsEN objTabFeatureFldsEN)
{
if (string.IsNullOrEmpty(objTabFeatureFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabFeatureFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabFeatureFldsEN>(objTabFeatureFldsEN);
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
 /// <param name = "objTabFeatureFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsTabFeatureFldsEN objTabFeatureFldsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objTabFeatureFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabFeatureFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objTabFeatureFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTabFeatureFldsEN>(objTabFeatureFldsEN);
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
 /// <param name = "objTabFeatureFldsENS">源对象</param>
 /// <param name = "objTabFeatureFldsENT">目标对象</param>
 public static void CopyTo(clsTabFeatureFldsEN objTabFeatureFldsENS, clsTabFeatureFldsEN objTabFeatureFldsENT)
{
try
{
objTabFeatureFldsENT.mId = objTabFeatureFldsENS.mId; //mId
objTabFeatureFldsENT.TabFeatureId = objTabFeatureFldsENS.TabFeatureId; //表功能Id
objTabFeatureFldsENT.FldId = objTabFeatureFldsENS.FldId; //字段Id
objTabFeatureFldsENT.IsCurrTab = objTabFeatureFldsENS.IsCurrTab; //是否当前表
objTabFeatureFldsENT.FieldTypeId = objTabFeatureFldsENS.FieldTypeId; //字段类型Id
objTabFeatureFldsENT.FuncName = objTabFeatureFldsENS.FuncName; //函数名
objTabFeatureFldsENT.ValueGivingModeId = objTabFeatureFldsENS.ValueGivingModeId; //给值方式Id
objTabFeatureFldsENT.DefaultValue = objTabFeatureFldsENS.DefaultValue; //缺省值
objTabFeatureFldsENT.PrjId = objTabFeatureFldsENS.PrjId; //工程Id
objTabFeatureFldsENT.OrderNum = objTabFeatureFldsENS.OrderNum; //序号
objTabFeatureFldsENT.InUse = objTabFeatureFldsENS.InUse; //是否在用
objTabFeatureFldsENT.UpdUser = objTabFeatureFldsENS.UpdUser; //修改者
objTabFeatureFldsENT.UpdDate = objTabFeatureFldsENS.UpdDate; //修改日期
objTabFeatureFldsENT.Memo = objTabFeatureFldsENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsTabFeatureFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsTabFeatureFldsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsTabFeatureFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsTabFeatureFldsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsTabFeatureFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsTabFeatureFldsEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsTabFeatureFldsWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsTabFeatureFldsWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsTabFeatureFldsEN._CurrTabName, strPrjId);
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
if (clsTabFeatureFldsWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsTabFeatureFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsTabFeatureFldsWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabFeatureFldsEN> GetObjLstCache()
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsTabFeatureFldsWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsTabFeatureFldsWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsTabFeatureFldsEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsTabFeatureFldsEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conTabFeatureFlds.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsTabFeatureFldsEN._CurrTabName, strPrjId);
List<clsTabFeatureFldsEN> arrTabFeatureFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrTabFeatureFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTabFeatureFldsEN> GetObjLstCacheFromObjLst(List<clsTabFeatureFldsEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsTabFeatureFldsWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsTabFeatureFldsWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsTabFeatureFldsEN._CurrTabName, strPrjId);
List<clsTabFeatureFldsEN> arrTabFeatureFldsObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrTabFeatureFldsObjLstCache = CacheHelper.Get<List<clsTabFeatureFldsEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrTabFeatureFldsObjLstCache = CacheHelper.Get<List<clsTabFeatureFldsEN>>(strKey);
}
return arrTabFeatureFldsObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsTabFeatureFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conTabFeatureFlds.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conTabFeatureFlds.TabFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeatureFlds.FldId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeatureFlds.IsCurrTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFeatureFlds.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeatureFlds.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeatureFlds.ValueGivingModeId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeatureFlds.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeatureFlds.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeatureFlds.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conTabFeatureFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conTabFeatureFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeatureFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conTabFeatureFlds.Memo, Type.GetType("System.String"));
foreach (clsTabFeatureFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conTabFeatureFlds.mId] = objInFor[conTabFeatureFlds.mId];
objDR[conTabFeatureFlds.TabFeatureId] = objInFor[conTabFeatureFlds.TabFeatureId];
objDR[conTabFeatureFlds.FldId] = objInFor[conTabFeatureFlds.FldId];
objDR[conTabFeatureFlds.IsCurrTab] = objInFor[conTabFeatureFlds.IsCurrTab];
objDR[conTabFeatureFlds.FieldTypeId] = objInFor[conTabFeatureFlds.FieldTypeId];
objDR[conTabFeatureFlds.FuncName] = objInFor[conTabFeatureFlds.FuncName];
objDR[conTabFeatureFlds.ValueGivingModeId] = objInFor[conTabFeatureFlds.ValueGivingModeId];
objDR[conTabFeatureFlds.DefaultValue] = objInFor[conTabFeatureFlds.DefaultValue];
objDR[conTabFeatureFlds.PrjId] = objInFor[conTabFeatureFlds.PrjId];
objDR[conTabFeatureFlds.OrderNum] = objInFor[conTabFeatureFlds.OrderNum];
objDR[conTabFeatureFlds.InUse] = objInFor[conTabFeatureFlds.InUse];
objDR[conTabFeatureFlds.UpdUser] = objInFor[conTabFeatureFlds.UpdUser];
objDR[conTabFeatureFlds.UpdDate] = objInFor[conTabFeatureFlds.UpdDate];
objDR[conTabFeatureFlds.Memo] = objInFor[conTabFeatureFlds.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 表功能字段(TabFeatureFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4TabFeatureFlds : clsCommFun4BL
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
clsTabFeatureFldsWApi.ReFreshThisCache();
}
}

}