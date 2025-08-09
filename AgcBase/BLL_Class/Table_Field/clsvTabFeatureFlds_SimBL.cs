
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFeatureFlds_SimBL
 表名:vTabFeatureFlds_Sim(00050611)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvTabFeatureFlds_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFeatureFlds_SimEN GetObj(this K_mId_vTabFeatureFlds_Sim myKey)
{
clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN = clsvTabFeatureFlds_SimBL.vTabFeatureFlds_SimDA.GetObjBymId(myKey.Value);
return objvTabFeatureFlds_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetTabFeatureId(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, string strTabFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabFeatureId, convTabFeatureFlds_Sim.TabFeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabFeatureId, 8, convTabFeatureFlds_Sim.TabFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabFeatureId, 8, convTabFeatureFlds_Sim.TabFeatureId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetFldId(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convTabFeatureFlds_Sim.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convTabFeatureFlds_Sim.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convTabFeatureFlds_Sim.FldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetFieldTypeId(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, string strFieldTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convTabFeatureFlds_Sim.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convTabFeatureFlds_Sim.FieldTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetValueGivingModeId(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, string strValueGivingModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strValueGivingModeId, convTabFeatureFlds_Sim.ValueGivingModeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strValueGivingModeId, 2, convTabFeatureFlds_Sim.ValueGivingModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strValueGivingModeId, 2, convTabFeatureFlds_Sim.ValueGivingModeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetDefaultValue(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, string strDefaultValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaultValue, 50, convTabFeatureFlds_Sim.DefaultValue);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTabFeatureFlds_SimEN SetPrjId(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convTabFeatureFlds_Sim.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convTabFeatureFlds_Sim.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convTabFeatureFlds_Sim.PrjId);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimENS">源对象</param>
 /// <param name = "objvTabFeatureFlds_SimENT">目标对象</param>
 public static void CopyTo(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimENS, clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimENT)
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
 /// <param name = "objvTabFeatureFlds_SimENS">源对象</param>
 /// <returns>目标对象=>clsvTabFeatureFlds_SimEN:objvTabFeatureFlds_SimENT</returns>
 public static clsvTabFeatureFlds_SimEN CopyTo(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimENS)
{
try
{
 clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimENT = new clsvTabFeatureFlds_SimEN()
{
mId = objvTabFeatureFlds_SimENS.mId, //mId
TabFeatureId = objvTabFeatureFlds_SimENS.TabFeatureId, //表功能Id
FldId = objvTabFeatureFlds_SimENS.FldId, //字段Id
IsCurrTab = objvTabFeatureFlds_SimENS.IsCurrTab, //是否当前表
FieldTypeId = objvTabFeatureFlds_SimENS.FieldTypeId, //字段类型Id
ValueGivingModeId = objvTabFeatureFlds_SimENS.ValueGivingModeId, //给值方式Id
DefaultValue = objvTabFeatureFlds_SimENS.DefaultValue, //缺省值
OrderNum = objvTabFeatureFlds_SimENS.OrderNum, //序号
InUse = objvTabFeatureFlds_SimENS.InUse, //是否在用
PrjId = objvTabFeatureFlds_SimENS.PrjId, //工程Id
};
 return objvTabFeatureFlds_SimENT;
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN)
{
 clsvTabFeatureFlds_SimBL.vTabFeatureFlds_SimDA.CheckProperty4Condition(objvTabFeatureFlds_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// 检查唯一性(Uniqueness)--vTabFeatureFlds_Sim(v表功能字段_Sim), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TabFeatureId_FldId_FieldTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvTabFeatureFlds_SimEN == null) return true;
if (objvTabFeatureFlds_SimEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabFeatureId = '{0}'", objvTabFeatureFlds_SimEN.TabFeatureId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objvTabFeatureFlds_SimEN.FldId);
 if (objvTabFeatureFlds_SimEN.FieldTypeId == null)
{
 sbCondition.AppendFormat(" and FieldTypeId is null", objvTabFeatureFlds_SimEN.FieldTypeId);
}
else
{
 sbCondition.AppendFormat(" and FieldTypeId = '{0}'", objvTabFeatureFlds_SimEN.FieldTypeId);
}
if (clsvTabFeatureFlds_SimBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvTabFeatureFlds_SimEN.mId);
 sbCondition.AppendFormat(" and TabFeatureId = '{0}'", objvTabFeatureFlds_SimEN.TabFeatureId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objvTabFeatureFlds_SimEN.FldId);
 sbCondition.AppendFormat(" and FieldTypeId = '{0}'", objvTabFeatureFlds_SimEN.FieldTypeId);
if (clsvTabFeatureFlds_SimBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vTabFeatureFlds_Sim(v表功能字段_Sim), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabFeatureId_FldId_FieldTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvTabFeatureFlds_SimEN == null) return "";
if (objvTabFeatureFlds_SimEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabFeatureId = '{0}'", objvTabFeatureFlds_SimEN.TabFeatureId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objvTabFeatureFlds_SimEN.FldId);
 if (objvTabFeatureFlds_SimEN.FieldTypeId == null)
{
 sbCondition.AppendFormat(" and FieldTypeId is null", objvTabFeatureFlds_SimEN.FieldTypeId);
}
else
{
 sbCondition.AppendFormat(" and FieldTypeId = '{0}'", objvTabFeatureFlds_SimEN.FieldTypeId);
}
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTabFeatureFlds_Sim
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v表功能字段_Sim(vTabFeatureFlds_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTabFeatureFlds_SimBL
{
public static RelatedActions_vTabFeatureFlds_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTabFeatureFlds_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTabFeatureFlds_SimDA vTabFeatureFlds_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTabFeatureFlds_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTabFeatureFlds_SimBL()
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
if (string.IsNullOrEmpty(clsvTabFeatureFlds_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTabFeatureFlds_SimEN._ConnectString);
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
public static DataTable GetDataTable_vTabFeatureFlds_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTabFeatureFlds_SimDA.GetDataTable_vTabFeatureFlds_Sim(strWhereCond);
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
objDT = vTabFeatureFlds_SimDA.GetDataTable(strWhereCond);
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
objDT = vTabFeatureFlds_SimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTabFeatureFlds_SimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTabFeatureFlds_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTabFeatureFlds_SimDA.GetDataTable_Top(objTopPara);
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
objDT = vTabFeatureFlds_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTabFeatureFlds_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTabFeatureFlds_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTabFeatureFlds_SimEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvTabFeatureFlds_SimEN> arrObjLst = new List<clsvTabFeatureFlds_SimEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN = new clsvTabFeatureFlds_SimEN();
try
{
objvTabFeatureFlds_SimEN.mId = Int32.Parse(objRow[convTabFeatureFlds_Sim.mId].ToString().Trim()); //mId
objvTabFeatureFlds_SimEN.TabFeatureId = objRow[convTabFeatureFlds_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFlds_SimEN.FldId = objRow[convTabFeatureFlds_Sim.FldId].ToString().Trim(); //字段Id
objvTabFeatureFlds_SimEN.IsCurrTab = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.IsCurrTab].ToString().Trim()); //是否当前表
objvTabFeatureFlds_SimEN.FieldTypeId = objRow[convTabFeatureFlds_Sim.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFlds_SimEN.ValueGivingModeId = objRow[convTabFeatureFlds_Sim.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFlds_SimEN.DefaultValue = objRow[convTabFeatureFlds_Sim.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFlds_SimEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeatureFlds_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeatureFlds_SimEN.PrjId = objRow[convTabFeatureFlds_Sim.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFlds_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFlds_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTabFeatureFlds_SimEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvTabFeatureFlds_SimEN._CurrTabName);
List<clsvTabFeatureFlds_SimEN> arrvTabFeatureFlds_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvTabFeatureFlds_SimEN> arrvTabFeatureFlds_SimObjLst_Sel =
arrvTabFeatureFlds_SimObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvTabFeatureFlds_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureFlds_SimEN> GetObjLst(string strWhereCond)
{
List<clsvTabFeatureFlds_SimEN> arrObjLst = new List<clsvTabFeatureFlds_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN = new clsvTabFeatureFlds_SimEN();
try
{
objvTabFeatureFlds_SimEN.mId = Int32.Parse(objRow[convTabFeatureFlds_Sim.mId].ToString().Trim()); //mId
objvTabFeatureFlds_SimEN.TabFeatureId = objRow[convTabFeatureFlds_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFlds_SimEN.FldId = objRow[convTabFeatureFlds_Sim.FldId].ToString().Trim(); //字段Id
objvTabFeatureFlds_SimEN.IsCurrTab = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.IsCurrTab].ToString().Trim()); //是否当前表
objvTabFeatureFlds_SimEN.FieldTypeId = objRow[convTabFeatureFlds_Sim.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFlds_SimEN.ValueGivingModeId = objRow[convTabFeatureFlds_Sim.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFlds_SimEN.DefaultValue = objRow[convTabFeatureFlds_Sim.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFlds_SimEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeatureFlds_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeatureFlds_SimEN.PrjId = objRow[convTabFeatureFlds_Sim.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFlds_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFlds_SimEN);
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
public static List<clsvTabFeatureFlds_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTabFeatureFlds_SimEN> arrObjLst = new List<clsvTabFeatureFlds_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN = new clsvTabFeatureFlds_SimEN();
try
{
objvTabFeatureFlds_SimEN.mId = Int32.Parse(objRow[convTabFeatureFlds_Sim.mId].ToString().Trim()); //mId
objvTabFeatureFlds_SimEN.TabFeatureId = objRow[convTabFeatureFlds_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFlds_SimEN.FldId = objRow[convTabFeatureFlds_Sim.FldId].ToString().Trim(); //字段Id
objvTabFeatureFlds_SimEN.IsCurrTab = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.IsCurrTab].ToString().Trim()); //是否当前表
objvTabFeatureFlds_SimEN.FieldTypeId = objRow[convTabFeatureFlds_Sim.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFlds_SimEN.ValueGivingModeId = objRow[convTabFeatureFlds_Sim.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFlds_SimEN.DefaultValue = objRow[convTabFeatureFlds_Sim.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFlds_SimEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeatureFlds_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeatureFlds_SimEN.PrjId = objRow[convTabFeatureFlds_Sim.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFlds_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFlds_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTabFeatureFlds_SimEN> GetSubObjLstCache(clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimCond)
{
List<clsvTabFeatureFlds_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTabFeatureFlds_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabFeatureFlds_Sim._AttributeName)
{
if (objvTabFeatureFlds_SimCond.IsUpdated(strFldName) == false) continue;
if (objvTabFeatureFlds_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeatureFlds_SimCond[strFldName].ToString());
}
else
{
if (objvTabFeatureFlds_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabFeatureFlds_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeatureFlds_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabFeatureFlds_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabFeatureFlds_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabFeatureFlds_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabFeatureFlds_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabFeatureFlds_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabFeatureFlds_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabFeatureFlds_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabFeatureFlds_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabFeatureFlds_SimCond[strFldName]));
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
public static List<clsvTabFeatureFlds_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTabFeatureFlds_SimEN> arrObjLst = new List<clsvTabFeatureFlds_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN = new clsvTabFeatureFlds_SimEN();
try
{
objvTabFeatureFlds_SimEN.mId = Int32.Parse(objRow[convTabFeatureFlds_Sim.mId].ToString().Trim()); //mId
objvTabFeatureFlds_SimEN.TabFeatureId = objRow[convTabFeatureFlds_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFlds_SimEN.FldId = objRow[convTabFeatureFlds_Sim.FldId].ToString().Trim(); //字段Id
objvTabFeatureFlds_SimEN.IsCurrTab = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.IsCurrTab].ToString().Trim()); //是否当前表
objvTabFeatureFlds_SimEN.FieldTypeId = objRow[convTabFeatureFlds_Sim.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFlds_SimEN.ValueGivingModeId = objRow[convTabFeatureFlds_Sim.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFlds_SimEN.DefaultValue = objRow[convTabFeatureFlds_Sim.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFlds_SimEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeatureFlds_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeatureFlds_SimEN.PrjId = objRow[convTabFeatureFlds_Sim.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFlds_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFlds_SimEN);
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
public static List<clsvTabFeatureFlds_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTabFeatureFlds_SimEN> arrObjLst = new List<clsvTabFeatureFlds_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN = new clsvTabFeatureFlds_SimEN();
try
{
objvTabFeatureFlds_SimEN.mId = Int32.Parse(objRow[convTabFeatureFlds_Sim.mId].ToString().Trim()); //mId
objvTabFeatureFlds_SimEN.TabFeatureId = objRow[convTabFeatureFlds_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFlds_SimEN.FldId = objRow[convTabFeatureFlds_Sim.FldId].ToString().Trim(); //字段Id
objvTabFeatureFlds_SimEN.IsCurrTab = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.IsCurrTab].ToString().Trim()); //是否当前表
objvTabFeatureFlds_SimEN.FieldTypeId = objRow[convTabFeatureFlds_Sim.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFlds_SimEN.ValueGivingModeId = objRow[convTabFeatureFlds_Sim.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFlds_SimEN.DefaultValue = objRow[convTabFeatureFlds_Sim.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFlds_SimEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeatureFlds_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeatureFlds_SimEN.PrjId = objRow[convTabFeatureFlds_Sim.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFlds_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFlds_SimEN);
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
List<clsvTabFeatureFlds_SimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTabFeatureFlds_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureFlds_SimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTabFeatureFlds_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTabFeatureFlds_SimEN> arrObjLst = new List<clsvTabFeatureFlds_SimEN>(); 
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
	clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN = new clsvTabFeatureFlds_SimEN();
try
{
objvTabFeatureFlds_SimEN.mId = Int32.Parse(objRow[convTabFeatureFlds_Sim.mId].ToString().Trim()); //mId
objvTabFeatureFlds_SimEN.TabFeatureId = objRow[convTabFeatureFlds_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFlds_SimEN.FldId = objRow[convTabFeatureFlds_Sim.FldId].ToString().Trim(); //字段Id
objvTabFeatureFlds_SimEN.IsCurrTab = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.IsCurrTab].ToString().Trim()); //是否当前表
objvTabFeatureFlds_SimEN.FieldTypeId = objRow[convTabFeatureFlds_Sim.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFlds_SimEN.ValueGivingModeId = objRow[convTabFeatureFlds_Sim.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFlds_SimEN.DefaultValue = objRow[convTabFeatureFlds_Sim.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFlds_SimEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeatureFlds_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeatureFlds_SimEN.PrjId = objRow[convTabFeatureFlds_Sim.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFlds_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFlds_SimEN);
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
public static List<clsvTabFeatureFlds_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTabFeatureFlds_SimEN> arrObjLst = new List<clsvTabFeatureFlds_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN = new clsvTabFeatureFlds_SimEN();
try
{
objvTabFeatureFlds_SimEN.mId = Int32.Parse(objRow[convTabFeatureFlds_Sim.mId].ToString().Trim()); //mId
objvTabFeatureFlds_SimEN.TabFeatureId = objRow[convTabFeatureFlds_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFlds_SimEN.FldId = objRow[convTabFeatureFlds_Sim.FldId].ToString().Trim(); //字段Id
objvTabFeatureFlds_SimEN.IsCurrTab = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.IsCurrTab].ToString().Trim()); //是否当前表
objvTabFeatureFlds_SimEN.FieldTypeId = objRow[convTabFeatureFlds_Sim.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFlds_SimEN.ValueGivingModeId = objRow[convTabFeatureFlds_Sim.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFlds_SimEN.DefaultValue = objRow[convTabFeatureFlds_Sim.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFlds_SimEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeatureFlds_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeatureFlds_SimEN.PrjId = objRow[convTabFeatureFlds_Sim.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFlds_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFlds_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTabFeatureFlds_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTabFeatureFlds_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTabFeatureFlds_SimEN> arrObjLst = new List<clsvTabFeatureFlds_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN = new clsvTabFeatureFlds_SimEN();
try
{
objvTabFeatureFlds_SimEN.mId = Int32.Parse(objRow[convTabFeatureFlds_Sim.mId].ToString().Trim()); //mId
objvTabFeatureFlds_SimEN.TabFeatureId = objRow[convTabFeatureFlds_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFlds_SimEN.FldId = objRow[convTabFeatureFlds_Sim.FldId].ToString().Trim(); //字段Id
objvTabFeatureFlds_SimEN.IsCurrTab = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.IsCurrTab].ToString().Trim()); //是否当前表
objvTabFeatureFlds_SimEN.FieldTypeId = objRow[convTabFeatureFlds_Sim.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFlds_SimEN.ValueGivingModeId = objRow[convTabFeatureFlds_Sim.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFlds_SimEN.DefaultValue = objRow[convTabFeatureFlds_Sim.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFlds_SimEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeatureFlds_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeatureFlds_SimEN.PrjId = objRow[convTabFeatureFlds_Sim.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFlds_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFlds_SimEN);
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
public static List<clsvTabFeatureFlds_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTabFeatureFlds_SimEN> arrObjLst = new List<clsvTabFeatureFlds_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN = new clsvTabFeatureFlds_SimEN();
try
{
objvTabFeatureFlds_SimEN.mId = Int32.Parse(objRow[convTabFeatureFlds_Sim.mId].ToString().Trim()); //mId
objvTabFeatureFlds_SimEN.TabFeatureId = objRow[convTabFeatureFlds_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFlds_SimEN.FldId = objRow[convTabFeatureFlds_Sim.FldId].ToString().Trim(); //字段Id
objvTabFeatureFlds_SimEN.IsCurrTab = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.IsCurrTab].ToString().Trim()); //是否当前表
objvTabFeatureFlds_SimEN.FieldTypeId = objRow[convTabFeatureFlds_Sim.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFlds_SimEN.ValueGivingModeId = objRow[convTabFeatureFlds_Sim.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFlds_SimEN.DefaultValue = objRow[convTabFeatureFlds_Sim.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFlds_SimEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeatureFlds_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeatureFlds_SimEN.PrjId = objRow[convTabFeatureFlds_Sim.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFlds_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFlds_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTabFeatureFlds_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTabFeatureFlds_SimEN> arrObjLst = new List<clsvTabFeatureFlds_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN = new clsvTabFeatureFlds_SimEN();
try
{
objvTabFeatureFlds_SimEN.mId = Int32.Parse(objRow[convTabFeatureFlds_Sim.mId].ToString().Trim()); //mId
objvTabFeatureFlds_SimEN.TabFeatureId = objRow[convTabFeatureFlds_Sim.TabFeatureId].ToString().Trim(); //表功能Id
objvTabFeatureFlds_SimEN.FldId = objRow[convTabFeatureFlds_Sim.FldId].ToString().Trim(); //字段Id
objvTabFeatureFlds_SimEN.IsCurrTab = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.IsCurrTab].ToString().Trim()); //是否当前表
objvTabFeatureFlds_SimEN.FieldTypeId = objRow[convTabFeatureFlds_Sim.FieldTypeId] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvTabFeatureFlds_SimEN.ValueGivingModeId = objRow[convTabFeatureFlds_Sim.ValueGivingModeId].ToString().Trim(); //给值方式Id
objvTabFeatureFlds_SimEN.DefaultValue = objRow[convTabFeatureFlds_Sim.DefaultValue] == DBNull.Value ? null : objRow[convTabFeatureFlds_Sim.DefaultValue].ToString().Trim(); //缺省值
objvTabFeatureFlds_SimEN.OrderNum = Int32.Parse(objRow[convTabFeatureFlds_Sim.OrderNum].ToString().Trim()); //序号
objvTabFeatureFlds_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convTabFeatureFlds_Sim.InUse].ToString().Trim()); //是否在用
objvTabFeatureFlds_SimEN.PrjId = objRow[convTabFeatureFlds_Sim.PrjId].ToString().Trim(); //工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTabFeatureFlds_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTabFeatureFlds_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTabFeatureFlds_Sim(ref clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN)
{
bool bolResult = vTabFeatureFlds_SimDA.GetvTabFeatureFlds_Sim(ref objvTabFeatureFlds_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTabFeatureFlds_SimEN GetObjBymId(long lngmId)
{
clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN = vTabFeatureFlds_SimDA.GetObjBymId(lngmId);
return objvTabFeatureFlds_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTabFeatureFlds_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN = vTabFeatureFlds_SimDA.GetFirstObj(strWhereCond);
 return objvTabFeatureFlds_SimEN;
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
public static clsvTabFeatureFlds_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN = vTabFeatureFlds_SimDA.GetObjByDataRow(objRow);
 return objvTabFeatureFlds_SimEN;
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
public static clsvTabFeatureFlds_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN = vTabFeatureFlds_SimDA.GetObjByDataRow(objRow);
 return objvTabFeatureFlds_SimEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvTabFeatureFlds_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabFeatureFlds_SimEN GetObjBymIdFromList(long lngmId, List<clsvTabFeatureFlds_SimEN> lstvTabFeatureFlds_SimObjLst)
{
foreach (clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN in lstvTabFeatureFlds_SimObjLst)
{
if (objvTabFeatureFlds_SimEN.mId == lngmId)
{
return objvTabFeatureFlds_SimEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvTabFeatureFlds_SimDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vTabFeatureFlds_SimDA.GetID(strWhereCond);
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
bool bolIsExist = vTabFeatureFlds_SimDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vTabFeatureFlds_SimDA.IsExist(lngmId);
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
 bolIsExist = clsvTabFeatureFlds_SimDA.IsExistTable();
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
 bolIsExist = vTabFeatureFlds_SimDA.IsExistTable(strTabName);
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


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
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
 /// <param name = "objvTabFeatureFlds_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN)
{
try
{
objvTabFeatureFlds_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTabFeatureFlds_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTabFeatureFlds_Sim.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFlds_SimEN.mId = objvTabFeatureFlds_SimEN.mId; //mId
}
if (arrFldSet.Contains(convTabFeatureFlds_Sim.TabFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFlds_SimEN.TabFeatureId = objvTabFeatureFlds_SimEN.TabFeatureId; //表功能Id
}
if (arrFldSet.Contains(convTabFeatureFlds_Sim.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFlds_SimEN.FldId = objvTabFeatureFlds_SimEN.FldId; //字段Id
}
if (arrFldSet.Contains(convTabFeatureFlds_Sim.IsCurrTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFlds_SimEN.IsCurrTab = objvTabFeatureFlds_SimEN.IsCurrTab; //是否当前表
}
if (arrFldSet.Contains(convTabFeatureFlds_Sim.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFlds_SimEN.FieldTypeId = objvTabFeatureFlds_SimEN.FieldTypeId == "[null]" ? null :  objvTabFeatureFlds_SimEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(convTabFeatureFlds_Sim.ValueGivingModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFlds_SimEN.ValueGivingModeId = objvTabFeatureFlds_SimEN.ValueGivingModeId; //给值方式Id
}
if (arrFldSet.Contains(convTabFeatureFlds_Sim.DefaultValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFlds_SimEN.DefaultValue = objvTabFeatureFlds_SimEN.DefaultValue == "[null]" ? null :  objvTabFeatureFlds_SimEN.DefaultValue; //缺省值
}
if (arrFldSet.Contains(convTabFeatureFlds_Sim.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFlds_SimEN.OrderNum = objvTabFeatureFlds_SimEN.OrderNum; //序号
}
if (arrFldSet.Contains(convTabFeatureFlds_Sim.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFlds_SimEN.InUse = objvTabFeatureFlds_SimEN.InUse; //是否在用
}
if (arrFldSet.Contains(convTabFeatureFlds_Sim.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTabFeatureFlds_SimEN.PrjId = objvTabFeatureFlds_SimEN.PrjId; //工程Id
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
 /// <param name = "objvTabFeatureFlds_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN)
{
try
{
if (objvTabFeatureFlds_SimEN.FieldTypeId == "[null]") objvTabFeatureFlds_SimEN.FieldTypeId = null; //字段类型Id
if (objvTabFeatureFlds_SimEN.DefaultValue == "[null]") objvTabFeatureFlds_SimEN.DefaultValue = null; //缺省值
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN)
{
 vTabFeatureFlds_SimDA.CheckProperty4Condition(objvTabFeatureFlds_SimEN);
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
if (clsTabFeatureFldsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTabFeatureFldsBL没有刷新缓存机制(clsTabFeatureFldsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvTabFeatureFlds_SimObjLstCache == null)
//{
//arrvTabFeatureFlds_SimObjLstCache = vTabFeatureFlds_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTabFeatureFlds_SimEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvTabFeatureFlds_SimEN._CurrTabName);
List<clsvTabFeatureFlds_SimEN> arrvTabFeatureFlds_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvTabFeatureFlds_SimEN> arrvTabFeatureFlds_SimObjLst_Sel =
arrvTabFeatureFlds_SimObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvTabFeatureFlds_SimObjLst_Sel.Count() == 0)
{
   clsvTabFeatureFlds_SimEN obj = clsvTabFeatureFlds_SimBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvTabFeatureFlds_SimObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFeatureFlds_SimEN> GetAllvTabFeatureFlds_SimObjLstCache()
{
//获取缓存中的对象列表
List<clsvTabFeatureFlds_SimEN> arrvTabFeatureFlds_SimObjLstCache = GetObjLstCache(); 
return arrvTabFeatureFlds_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTabFeatureFlds_SimEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvTabFeatureFlds_SimEN._CurrTabName);
List<clsvTabFeatureFlds_SimEN> arrvTabFeatureFlds_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTabFeatureFlds_SimObjLstCache;
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
string strKey = string.Format("{0}", clsvTabFeatureFlds_SimEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvTabFeatureFlds_SimEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvTabFeatureFlds_SimEN._RefreshTimeLst.Count == 0) return "";
return clsvTabFeatureFlds_SimEN._RefreshTimeLst[clsvTabFeatureFlds_SimEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vTabFeatureFlds_Sim(v表功能字段_Sim)
 /// 唯一性条件:TabFeatureId_FldId_FieldTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimEN)
{
//检测记录是否存在
string strResult = vTabFeatureFlds_SimDA.GetUniCondStr(objvTabFeatureFlds_SimEN);
return strResult;
}


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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convTabFeatureFlds_Sim.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTabFeatureFlds_Sim._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTabFeatureFlds_Sim._AttributeName));
throw new Exception(strMsg);
}
var objvTabFeatureFlds_Sim = clsvTabFeatureFlds_SimBL.GetObjBymIdCache(lngmId);
if (objvTabFeatureFlds_Sim == null) return "";
return objvTabFeatureFlds_Sim[strOutFldName].ToString();
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
int intRecCount = clsvTabFeatureFlds_SimDA.GetRecCount(strTabName);
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
int intRecCount = clsvTabFeatureFlds_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTabFeatureFlds_SimDA.GetRecCount();
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
int intRecCount = clsvTabFeatureFlds_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTabFeatureFlds_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTabFeatureFlds_SimEN objvTabFeatureFlds_SimCond)
{
List<clsvTabFeatureFlds_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvTabFeatureFlds_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTabFeatureFlds_Sim._AttributeName)
{
if (objvTabFeatureFlds_SimCond.IsUpdated(strFldName) == false) continue;
if (objvTabFeatureFlds_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeatureFlds_SimCond[strFldName].ToString());
}
else
{
if (objvTabFeatureFlds_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTabFeatureFlds_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTabFeatureFlds_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTabFeatureFlds_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTabFeatureFlds_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTabFeatureFlds_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTabFeatureFlds_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTabFeatureFlds_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTabFeatureFlds_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTabFeatureFlds_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTabFeatureFlds_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTabFeatureFlds_SimCond[strFldName]));
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
 List<string> arrList = clsvTabFeatureFlds_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTabFeatureFlds_SimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTabFeatureFlds_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}