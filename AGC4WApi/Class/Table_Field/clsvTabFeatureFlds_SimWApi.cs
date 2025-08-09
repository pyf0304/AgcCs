
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFeatureFlds_SimWApi
 表名:vTabFeatureFlds_Sim(00050611)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:28
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
public static class  clsvTabFeatureFlds_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetmId(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, long lngmId, string strComparisonOp="")
	{
objvTabFeatureFlds_SimEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFlds_SimEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds_Sim.mId) == false)
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp.Add(convTabFeatureFlds_Sim.mId, strComparisonOp);
}
else
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp[convTabFeatureFlds_Sim.mId] = strComparisonOp;
}
}
return objvTabFeatureFlds_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabFeatureId">表功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetTabFeatureId(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, string strTabFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabFeatureId, convTabFeatureFlds_Sim.TabFeatureId);
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, convTabFeatureFlds_Sim.TabFeatureId);
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, convTabFeatureFlds_Sim.TabFeatureId);
objvTabFeatureFlds_SimEN.TabFeatureId = strTabFeatureId; //表功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFlds_SimEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds_Sim.TabFeatureId) == false)
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp.Add(convTabFeatureFlds_Sim.TabFeatureId, strComparisonOp);
}
else
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp[convTabFeatureFlds_Sim.TabFeatureId] = strComparisonOp;
}
}
return objvTabFeatureFlds_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetFldId(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convTabFeatureFlds_Sim.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convTabFeatureFlds_Sim.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convTabFeatureFlds_Sim.FldId);
objvTabFeatureFlds_SimEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFlds_SimEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds_Sim.FldId) == false)
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp.Add(convTabFeatureFlds_Sim.FldId, strComparisonOp);
}
else
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp[convTabFeatureFlds_Sim.FldId] = strComparisonOp;
}
}
return objvTabFeatureFlds_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsCurrTab">是否当前表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetIsCurrTab(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, bool bolIsCurrTab, string strComparisonOp="")
	{
objvTabFeatureFlds_SimEN.IsCurrTab = bolIsCurrTab; //是否当前表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFlds_SimEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds_Sim.IsCurrTab) == false)
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp.Add(convTabFeatureFlds_Sim.IsCurrTab, strComparisonOp);
}
else
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp[convTabFeatureFlds_Sim.IsCurrTab] = strComparisonOp;
}
}
return objvTabFeatureFlds_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetFieldTypeId(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convTabFeatureFlds_Sim.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convTabFeatureFlds_Sim.FieldTypeId);
objvTabFeatureFlds_SimEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFlds_SimEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds_Sim.FieldTypeId) == false)
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp.Add(convTabFeatureFlds_Sim.FieldTypeId, strComparisonOp);
}
else
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp[convTabFeatureFlds_Sim.FieldTypeId] = strComparisonOp;
}
}
return objvTabFeatureFlds_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strValueGivingModeId">给值方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetValueGivingModeId(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, string strValueGivingModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strValueGivingModeId, convTabFeatureFlds_Sim.ValueGivingModeId);
clsCheckSql.CheckFieldLen(strValueGivingModeId, 2, convTabFeatureFlds_Sim.ValueGivingModeId);
clsCheckSql.CheckFieldForeignKey(strValueGivingModeId, 2, convTabFeatureFlds_Sim.ValueGivingModeId);
objvTabFeatureFlds_SimEN.ValueGivingModeId = strValueGivingModeId; //给值方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFlds_SimEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds_Sim.ValueGivingModeId) == false)
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp.Add(convTabFeatureFlds_Sim.ValueGivingModeId, strComparisonOp);
}
else
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp[convTabFeatureFlds_Sim.ValueGivingModeId] = strComparisonOp;
}
}
return objvTabFeatureFlds_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strDefaultValue">缺省值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetDefaultValue(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, string strDefaultValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convTabFeatureFlds_Sim.DefaultValue);
objvTabFeatureFlds_SimEN.DefaultValue = strDefaultValue; //缺省值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFlds_SimEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds_Sim.DefaultValue) == false)
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp.Add(convTabFeatureFlds_Sim.DefaultValue, strComparisonOp);
}
else
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp[convTabFeatureFlds_Sim.DefaultValue] = strComparisonOp;
}
}
return objvTabFeatureFlds_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetOrderNum(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convTabFeatureFlds_Sim.OrderNum);
objvTabFeatureFlds_SimEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFlds_SimEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds_Sim.OrderNum) == false)
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp.Add(convTabFeatureFlds_Sim.OrderNum, strComparisonOp);
}
else
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp[convTabFeatureFlds_Sim.OrderNum] = strComparisonOp;
}
}
return objvTabFeatureFlds_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetInUse(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, bool bolInUse, string strComparisonOp="")
	{
objvTabFeatureFlds_SimEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFlds_SimEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds_Sim.InUse) == false)
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp.Add(convTabFeatureFlds_Sim.InUse, strComparisonOp);
}
else
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp[convTabFeatureFlds_Sim.InUse] = strComparisonOp;
}
}
return objvTabFeatureFlds_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetPrjId(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convTabFeatureFlds_Sim.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convTabFeatureFlds_Sim.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTabFeatureFlds_Sim.PrjId);
objvTabFeatureFlds_SimEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTabFeatureFlds_SimEN.dicFldComparisonOp.ContainsKey(convTabFeatureFlds_Sim.PrjId) == false)
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp.Add(convTabFeatureFlds_Sim.PrjId, strComparisonOp);
}
else
{
objvTabFeatureFlds_SimEN.dicFldComparisonOp[convTabFeatureFlds_Sim.PrjId] = strComparisonOp;
}
}
return objvTabFeatureFlds_SimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTabFeatureFlds_SimCond.IsUpdated(convTabFeatureFlds_Sim.mId) == true)
{
string strComparisonOpmId = objvTabFeatureFlds_SimCond.dicFldComparisonOp[convTabFeatureFlds_Sim.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convTabFeatureFlds_Sim.mId, objvTabFeatureFlds_SimCond.mId, strComparisonOpmId);
}
if (objvTabFeatureFlds_SimCond.IsUpdated(convTabFeatureFlds_Sim.TabFeatureId) == true)
{
string strComparisonOpTabFeatureId = objvTabFeatureFlds_SimCond.dicFldComparisonOp[convTabFeatureFlds_Sim.TabFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds_Sim.TabFeatureId, objvTabFeatureFlds_SimCond.TabFeatureId, strComparisonOpTabFeatureId);
}
if (objvTabFeatureFlds_SimCond.IsUpdated(convTabFeatureFlds_Sim.FldId) == true)
{
string strComparisonOpFldId = objvTabFeatureFlds_SimCond.dicFldComparisonOp[convTabFeatureFlds_Sim.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds_Sim.FldId, objvTabFeatureFlds_SimCond.FldId, strComparisonOpFldId);
}
if (objvTabFeatureFlds_SimCond.IsUpdated(convTabFeatureFlds_Sim.IsCurrTab) == true)
{
if (objvTabFeatureFlds_SimCond.IsCurrTab == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFeatureFlds_Sim.IsCurrTab);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFeatureFlds_Sim.IsCurrTab);
}
}
if (objvTabFeatureFlds_SimCond.IsUpdated(convTabFeatureFlds_Sim.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvTabFeatureFlds_SimCond.dicFldComparisonOp[convTabFeatureFlds_Sim.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds_Sim.FieldTypeId, objvTabFeatureFlds_SimCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvTabFeatureFlds_SimCond.IsUpdated(convTabFeatureFlds_Sim.ValueGivingModeId) == true)
{
string strComparisonOpValueGivingModeId = objvTabFeatureFlds_SimCond.dicFldComparisonOp[convTabFeatureFlds_Sim.ValueGivingModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds_Sim.ValueGivingModeId, objvTabFeatureFlds_SimCond.ValueGivingModeId, strComparisonOpValueGivingModeId);
}
if (objvTabFeatureFlds_SimCond.IsUpdated(convTabFeatureFlds_Sim.DefaultValue) == true)
{
string strComparisonOpDefaultValue = objvTabFeatureFlds_SimCond.dicFldComparisonOp[convTabFeatureFlds_Sim.DefaultValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds_Sim.DefaultValue, objvTabFeatureFlds_SimCond.DefaultValue, strComparisonOpDefaultValue);
}
if (objvTabFeatureFlds_SimCond.IsUpdated(convTabFeatureFlds_Sim.OrderNum) == true)
{
string strComparisonOpOrderNum = objvTabFeatureFlds_SimCond.dicFldComparisonOp[convTabFeatureFlds_Sim.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convTabFeatureFlds_Sim.OrderNum, objvTabFeatureFlds_SimCond.OrderNum, strComparisonOpOrderNum);
}
if (objvTabFeatureFlds_SimCond.IsUpdated(convTabFeatureFlds_Sim.InUse) == true)
{
if (objvTabFeatureFlds_SimCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTabFeatureFlds_Sim.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTabFeatureFlds_Sim.InUse);
}
}
if (objvTabFeatureFlds_SimCond.IsUpdated(convTabFeatureFlds_Sim.PrjId) == true)
{
string strComparisonOpPrjId = objvTabFeatureFlds_SimCond.dicFldComparisonOp[convTabFeatureFlds_Sim.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTabFeatureFlds_Sim.PrjId, objvTabFeatureFlds_SimCond.PrjId, strComparisonOpPrjId);
}
 return strWhereCond;
}

 /// <summary>
 /// 获取唯一性条件串--vTabFeatureFlds_Sim(v表功能字段_Sim), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabFeatureId_FldId_FieldTypeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvTabFeatureFlds_SimEN == null) return "";
if (objvTabFeatureFlds_SimEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabFeatureId = '{0}'", objvTabFeatureFlds_SimEN.TabFeatureId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objvTabFeatureFlds_SimEN.FldId);
 sbCondition.AppendFormat(" and FieldTypeId = '{0}'", objvTabFeatureFlds_SimEN.FieldTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvTabFeatureFlds_SimEN.mId);
 sbCondition.AppendFormat(" and TabFeatureId = '{0}'", objvTabFeatureFlds_SimEN.TabFeatureId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objvTabFeatureFlds_SimEN.FldId);
 sbCondition.AppendFormat(" and FieldTypeId = '{0}'", objvTabFeatureFlds_SimEN.FieldTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// v表功能字段_Sim(vTabFeatureFlds_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTabFeatureFlds_SimWApi
{
private static readonly string mstrApiControllerName = "vTabFeatureFlds_SimApi";

 public clsvTabFeatureFlds_SimWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFeatureFlds_SimEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN;
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
objvTabFeatureFlds_SimEN = JsonConvert.DeserializeObject<clsvTabFeatureFlds_SimEN>(strJson);
return objvTabFeatureFlds_SimEN;
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
public static clsvTabFeatureFlds_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN;
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
objvTabFeatureFlds_SimEN = JsonConvert.DeserializeObject<clsvTabFeatureFlds_SimEN>(strJson);
return objvTabFeatureFlds_SimEN;
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
public static clsvTabFeatureFlds_SimEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTabFeatureFlds_SimEN._CurrTabName);
List<clsvTabFeatureFlds_SimEN> arrvTabFeatureFlds_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvTabFeatureFlds_SimEN> arrvTabFeatureFlds_SimObjLst_Sel =
from objvTabFeatureFlds_SimEN in arrvTabFeatureFlds_SimObjLstCache
where objvTabFeatureFlds_SimEN.mId == lngmId 
select objvTabFeatureFlds_SimEN;
if (arrvTabFeatureFlds_SimObjLst_Sel.Count() == 0)
{
   clsvTabFeatureFlds_SimEN obj = clsvTabFeatureFlds_SimWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTabFeatureFlds_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureFlds_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvTabFeatureFlds_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureFlds_SimEN>>(strJson);
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
public static List<clsvTabFeatureFlds_SimEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvTabFeatureFlds_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureFlds_SimEN>>(strJson);
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
public static IEnumerable<clsvTabFeatureFlds_SimEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTabFeatureFlds_SimEN._CurrTabName);
List<clsvTabFeatureFlds_SimEN> arrvTabFeatureFlds_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvTabFeatureFlds_SimEN> arrvTabFeatureFlds_SimObjLst_Sel =
from objvTabFeatureFlds_SimEN in arrvTabFeatureFlds_SimObjLstCache
where arrMId.Contains(objvTabFeatureFlds_SimEN.mId)
select objvTabFeatureFlds_SimEN;
return arrvTabFeatureFlds_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureFlds_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTabFeatureFlds_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureFlds_SimEN>>(strJson);
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
public static List<clsvTabFeatureFlds_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTabFeatureFlds_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureFlds_SimEN>>(strJson);
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
public static List<clsvTabFeatureFlds_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTabFeatureFlds_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureFlds_SimEN>>(strJson);
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
public static List<clsvTabFeatureFlds_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvTabFeatureFlds_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTabFeatureFlds_SimEN>>(strJson);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimENS">源对象</param>
 /// <param name = "objvTabFeatureFlds_SimENT">目标对象</param>
 public static void CopyTo(clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimENS, clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimENT)
{
try
{
objvTabFeatureFlds_SimENT.mId = objvTabFeatureFlds_SimENS.mId; //mId
objvTabFeatureFlds_SimENT.TabFeatureId = objvTabFeatureFlds_SimENS.TabFeatureId; //表功能Id
objvTabFeatureFlds_SimENT.FldId = objvTabFeatureFlds_SimENS.FldId; //字段Id
objvTabFeatureFlds_SimENT.IsCurrTab = objvTabFeatureFlds_SimENS.IsCurrTab; //是否当前表
objvTabFeatureFlds_SimENT.FieldTypeId = objvTabFeatureFlds_SimENS.FieldTypeId; //字段类型Id
objvTabFeatureFlds_SimENT.ValueGivingModeId = objvTabFeatureFlds_SimENS.ValueGivingModeId; //给值方式Id
objvTabFeatureFlds_SimENT.DefaultValue = objvTabFeatureFlds_SimENS.DefaultValue; //缺省值
objvTabFeatureFlds_SimENT.OrderNum = objvTabFeatureFlds_SimENS.OrderNum; //序号
objvTabFeatureFlds_SimENT.InUse = objvTabFeatureFlds_SimENS.InUse; //是否在用
objvTabFeatureFlds_SimENT.PrjId = objvTabFeatureFlds_SimENS.PrjId; //工程Id
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
public static DataTable ToDataTable(List<clsvTabFeatureFlds_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTabFeatureFlds_SimEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTabFeatureFlds_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTabFeatureFlds_SimEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTabFeatureFlds_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTabFeatureFlds_SimEN._AttributeName)
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
public static void ReFreshThisCache()
{

string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvTabFeatureFlds_SimEN._CurrTabName);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFeatureFlds_SimEN> GetObjLstCache(string strPrjId)
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvTabFeatureFlds_SimEN._CurrTabName;
List<clsvTabFeatureFlds_SimEN> arrvTabFeatureFlds_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvTabFeatureFlds_SimObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTabFeatureFlds_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTabFeatureFlds_Sim.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convTabFeatureFlds_Sim.TabFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds_Sim.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds_Sim.IsCurrTab, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFeatureFlds_Sim.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds_Sim.ValueGivingModeId, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds_Sim.DefaultValue, Type.GetType("System.String"));
objDT.Columns.Add(convTabFeatureFlds_Sim.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convTabFeatureFlds_Sim.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTabFeatureFlds_Sim.PrjId, Type.GetType("System.String"));
foreach (clsvTabFeatureFlds_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTabFeatureFlds_Sim.mId] = objInFor[convTabFeatureFlds_Sim.mId];
objDR[convTabFeatureFlds_Sim.TabFeatureId] = objInFor[convTabFeatureFlds_Sim.TabFeatureId];
objDR[convTabFeatureFlds_Sim.FldId] = objInFor[convTabFeatureFlds_Sim.FldId];
objDR[convTabFeatureFlds_Sim.IsCurrTab] = objInFor[convTabFeatureFlds_Sim.IsCurrTab];
objDR[convTabFeatureFlds_Sim.FieldTypeId] = objInFor[convTabFeatureFlds_Sim.FieldTypeId];
objDR[convTabFeatureFlds_Sim.ValueGivingModeId] = objInFor[convTabFeatureFlds_Sim.ValueGivingModeId];
objDR[convTabFeatureFlds_Sim.DefaultValue] = objInFor[convTabFeatureFlds_Sim.DefaultValue];
objDR[convTabFeatureFlds_Sim.OrderNum] = objInFor[convTabFeatureFlds_Sim.OrderNum];
objDR[convTabFeatureFlds_Sim.InUse] = objInFor[convTabFeatureFlds_Sim.InUse];
objDR[convTabFeatureFlds_Sim.PrjId] = objInFor[convTabFeatureFlds_Sim.PrjId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}