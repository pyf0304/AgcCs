
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab_Sim2BL
 表名:vFieldTab_Sim2(00050608)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:18
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
public static class  clsvFieldTab_Sim2BL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTab_Sim2EN GetObj(this K_FldId_vFieldTab_Sim2 myKey)
{
clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = clsvFieldTab_Sim2BL.vFieldTab_Sim2DA.GetObjByFldId(myKey.Value);
return objvFieldTab_Sim2EN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetFldId(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, string strFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convFieldTab_Sim2.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convFieldTab_Sim2.FldId);
}
objvFieldTab_Sim2EN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.FldId) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.FldId, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.FldId] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetDataTypeId(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, convFieldTab_Sim2.DataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, convFieldTab_Sim2.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, convFieldTab_Sim2.DataTypeId);
}
objvFieldTab_Sim2EN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.DataTypeId) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.DataTypeId, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.DataTypeId] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetFldName(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convFieldTab_Sim2.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convFieldTab_Sim2.FldName);
}
objvFieldTab_Sim2EN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.FldName) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.FldName, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.FldName] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetCaption(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, string strCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaption, convFieldTab_Sim2.Caption);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaption, 200, convFieldTab_Sim2.Caption);
}
objvFieldTab_Sim2EN.Caption = strCaption; //标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.Caption) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.Caption, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.Caption] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetFldLength(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, int intFldLength, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intFldLength, convFieldTab_Sim2.FldLength);
objvFieldTab_Sim2EN.FldLength = intFldLength; //字段长度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.FldLength) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.FldLength, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.FldLength] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetFldPrecision(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, int? intFldPrecision, string strComparisonOp="")
	{
objvFieldTab_Sim2EN.FldPrecision = intFldPrecision; //精确度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.FldPrecision) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.FldPrecision, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.FldPrecision] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetPrjId(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convFieldTab_Sim2.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFieldTab_Sim2.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFieldTab_Sim2.PrjId);
}
objvFieldTab_Sim2EN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.PrjId) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.PrjId, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.PrjId] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetFieldTypeId(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, string strFieldTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convFieldTab_Sim2.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convFieldTab_Sim2.FieldTypeId);
}
objvFieldTab_Sim2EN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.FieldTypeId) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.FieldTypeId, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.FieldTypeId] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab_Sim2EN SetHomologousFldId(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN, string strHomologousFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHomologousFldId, 8, convFieldTab_Sim2.HomologousFldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strHomologousFldId, 8, convFieldTab_Sim2.HomologousFldId);
}
objvFieldTab_Sim2EN.HomologousFldId = strHomologousFldId; //同源字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab_Sim2EN.dicFldComparisonOp.ContainsKey(convFieldTab_Sim2.HomologousFldId) == false)
{
objvFieldTab_Sim2EN.dicFldComparisonOp.Add(convFieldTab_Sim2.HomologousFldId, strComparisonOp);
}
else
{
objvFieldTab_Sim2EN.dicFldComparisonOp[convFieldTab_Sim2.HomologousFldId] = strComparisonOp;
}
}
return objvFieldTab_Sim2EN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2ENS">源对象</param>
 /// <param name = "objvFieldTab_Sim2ENT">目标对象</param>
 public static void CopyTo(this clsvFieldTab_Sim2EN objvFieldTab_Sim2ENS, clsvFieldTab_Sim2EN objvFieldTab_Sim2ENT)
{
try
{
objvFieldTab_Sim2ENT.FldId = objvFieldTab_Sim2ENS.FldId; //字段Id
objvFieldTab_Sim2ENT.DataTypeId = objvFieldTab_Sim2ENS.DataTypeId; //数据类型Id
objvFieldTab_Sim2ENT.FldName = objvFieldTab_Sim2ENS.FldName; //字段名
objvFieldTab_Sim2ENT.Caption = objvFieldTab_Sim2ENS.Caption; //标题
objvFieldTab_Sim2ENT.FldLength = objvFieldTab_Sim2ENS.FldLength; //字段长度
objvFieldTab_Sim2ENT.FldPrecision = objvFieldTab_Sim2ENS.FldPrecision; //精确度
objvFieldTab_Sim2ENT.PrjId = objvFieldTab_Sim2ENS.PrjId; //工程Id
objvFieldTab_Sim2ENT.FieldTypeId = objvFieldTab_Sim2ENS.FieldTypeId; //字段类型Id
objvFieldTab_Sim2ENT.HomologousFldId = objvFieldTab_Sim2ENS.HomologousFldId; //同源字段Id
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
 /// <param name = "objvFieldTab_Sim2ENS">源对象</param>
 /// <returns>目标对象=>clsvFieldTab_Sim2EN:objvFieldTab_Sim2ENT</returns>
 public static clsvFieldTab_Sim2EN CopyTo(this clsvFieldTab_Sim2EN objvFieldTab_Sim2ENS)
{
try
{
 clsvFieldTab_Sim2EN objvFieldTab_Sim2ENT = new clsvFieldTab_Sim2EN()
{
FldId = objvFieldTab_Sim2ENS.FldId, //字段Id
DataTypeId = objvFieldTab_Sim2ENS.DataTypeId, //数据类型Id
FldName = objvFieldTab_Sim2ENS.FldName, //字段名
Caption = objvFieldTab_Sim2ENS.Caption, //标题
FldLength = objvFieldTab_Sim2ENS.FldLength, //字段长度
FldPrecision = objvFieldTab_Sim2ENS.FldPrecision, //精确度
PrjId = objvFieldTab_Sim2ENS.PrjId, //工程Id
FieldTypeId = objvFieldTab_Sim2ENS.FieldTypeId, //字段类型Id
HomologousFldId = objvFieldTab_Sim2ENS.HomologousFldId, //同源字段Id
};
 return objvFieldTab_Sim2ENT;
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
public static void CheckProperty4Condition(this clsvFieldTab_Sim2EN objvFieldTab_Sim2EN)
{
 clsvFieldTab_Sim2BL.vFieldTab_Sim2DA.CheckProperty4Condition(objvFieldTab_Sim2EN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFieldTab_Sim2EN objvFieldTab_Sim2Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.FldId) == true)
{
string strComparisonOpFldId = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim2.FldId, objvFieldTab_Sim2Cond.FldId, strComparisonOpFldId);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim2.DataTypeId, objvFieldTab_Sim2Cond.DataTypeId, strComparisonOpDataTypeId);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.FldName) == true)
{
string strComparisonOpFldName = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim2.FldName, objvFieldTab_Sim2Cond.FldName, strComparisonOpFldName);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.Caption) == true)
{
string strComparisonOpCaption = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.Caption];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim2.Caption, objvFieldTab_Sim2Cond.Caption, strComparisonOpCaption);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.FldLength) == true)
{
string strComparisonOpFldLength = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.FldLength];
strWhereCond += string.Format(" And {0} {2} {1}", convFieldTab_Sim2.FldLength, objvFieldTab_Sim2Cond.FldLength, strComparisonOpFldLength);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.FldPrecision) == true)
{
string strComparisonOpFldPrecision = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.FldPrecision];
strWhereCond += string.Format(" And {0} {2} {1}", convFieldTab_Sim2.FldPrecision, objvFieldTab_Sim2Cond.FldPrecision, strComparisonOpFldPrecision);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.PrjId) == true)
{
string strComparisonOpPrjId = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim2.PrjId, objvFieldTab_Sim2Cond.PrjId, strComparisonOpPrjId);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim2.FieldTypeId, objvFieldTab_Sim2Cond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvFieldTab_Sim2Cond.IsUpdated(convFieldTab_Sim2.HomologousFldId) == true)
{
string strComparisonOpHomologousFldId = objvFieldTab_Sim2Cond.dicFldComparisonOp[convFieldTab_Sim2.HomologousFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab_Sim2.HomologousFldId, objvFieldTab_Sim2Cond.HomologousFldId, strComparisonOpHomologousFldId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFieldTab_Sim2
{
public virtual bool UpdRelaTabDate(string strFldId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vFieldTab_Sim2(vFieldTab_Sim2)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFieldTab_Sim2BL
{
public static RelatedActions_vFieldTab_Sim2 relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFieldTab_Sim2DA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFieldTab_Sim2DA vFieldTab_Sim2DA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFieldTab_Sim2DA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFieldTab_Sim2BL()
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
if (string.IsNullOrEmpty(clsvFieldTab_Sim2EN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFieldTab_Sim2EN._ConnectString);
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
public static DataTable GetDataTable_vFieldTab_Sim2(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFieldTab_Sim2DA.GetDataTable_vFieldTab_Sim2(strWhereCond);
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
objDT = vFieldTab_Sim2DA.GetDataTable(strWhereCond);
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
objDT = vFieldTab_Sim2DA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFieldTab_Sim2DA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFieldTab_Sim2DA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFieldTab_Sim2DA.GetDataTable_Top(objTopPara);
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
objDT = vFieldTab_Sim2DA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFieldTab_Sim2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFieldTab_Sim2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFldIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFieldTab_Sim2EN> GetObjLstByFldIdLst(List<string> arrFldIdLst)
{
List<clsvFieldTab_Sim2EN> arrObjLst = new List<clsvFieldTab_Sim2EN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFldIdLst, true);
 string strWhereCond = string.Format("FldId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN();
try
{
objvFieldTab_Sim2EN.FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id
objvFieldTab_Sim2EN.DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab_Sim2EN.FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(); //字段名
objvFieldTab_Sim2EN.Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(); //标题
objvFieldTab_Sim2EN.FldLength = Int32.Parse(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度
objvFieldTab_Sim2EN.FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度
objvFieldTab_Sim2EN.PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id
objvFieldTab_Sim2EN.FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTab_Sim2EN.HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab_Sim2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab_Sim2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFldIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFieldTab_Sim2EN> GetObjLstByFldIdLstCache(List<string> arrFldIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvFieldTab_Sim2EN._CurrTabName, strPrjId);
List<clsvFieldTab_Sim2EN> arrvFieldTab_Sim2ObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab_Sim2EN> arrvFieldTab_Sim2ObjLst_Sel =
arrvFieldTab_Sim2ObjLstCache
.Where(x => arrFldIdLst.Contains(x.FldId));
return arrvFieldTab_Sim2ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab_Sim2EN> GetObjLst(string strWhereCond)
{
List<clsvFieldTab_Sim2EN> arrObjLst = new List<clsvFieldTab_Sim2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN();
try
{
objvFieldTab_Sim2EN.FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id
objvFieldTab_Sim2EN.DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab_Sim2EN.FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(); //字段名
objvFieldTab_Sim2EN.Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(); //标题
objvFieldTab_Sim2EN.FldLength = Int32.Parse(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度
objvFieldTab_Sim2EN.FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度
objvFieldTab_Sim2EN.PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id
objvFieldTab_Sim2EN.FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTab_Sim2EN.HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab_Sim2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab_Sim2EN);
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
public static List<clsvFieldTab_Sim2EN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFieldTab_Sim2EN> arrObjLst = new List<clsvFieldTab_Sim2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN();
try
{
objvFieldTab_Sim2EN.FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id
objvFieldTab_Sim2EN.DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab_Sim2EN.FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(); //字段名
objvFieldTab_Sim2EN.Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(); //标题
objvFieldTab_Sim2EN.FldLength = Int32.Parse(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度
objvFieldTab_Sim2EN.FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度
objvFieldTab_Sim2EN.PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id
objvFieldTab_Sim2EN.FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTab_Sim2EN.HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab_Sim2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab_Sim2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFieldTab_Sim2EN> GetSubObjLstCache(clsvFieldTab_Sim2EN objvFieldTab_Sim2Cond)
{
 string strPrjId = objvFieldTab_Sim2Cond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvFieldTab_Sim2BL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvFieldTab_Sim2EN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab_Sim2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFieldTab_Sim2._AttributeName)
{
if (objvFieldTab_Sim2Cond.IsUpdated(strFldName) == false) continue;
if (objvFieldTab_Sim2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab_Sim2Cond[strFldName].ToString());
}
else
{
if (objvFieldTab_Sim2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFieldTab_Sim2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab_Sim2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFieldTab_Sim2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFieldTab_Sim2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFieldTab_Sim2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFieldTab_Sim2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFieldTab_Sim2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFieldTab_Sim2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFieldTab_Sim2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFieldTab_Sim2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFieldTab_Sim2Cond[strFldName]));
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
public static List<clsvFieldTab_Sim2EN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFieldTab_Sim2EN> arrObjLst = new List<clsvFieldTab_Sim2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN();
try
{
objvFieldTab_Sim2EN.FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id
objvFieldTab_Sim2EN.DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab_Sim2EN.FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(); //字段名
objvFieldTab_Sim2EN.Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(); //标题
objvFieldTab_Sim2EN.FldLength = Int32.Parse(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度
objvFieldTab_Sim2EN.FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度
objvFieldTab_Sim2EN.PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id
objvFieldTab_Sim2EN.FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTab_Sim2EN.HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab_Sim2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab_Sim2EN);
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
public static List<clsvFieldTab_Sim2EN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFieldTab_Sim2EN> arrObjLst = new List<clsvFieldTab_Sim2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN();
try
{
objvFieldTab_Sim2EN.FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id
objvFieldTab_Sim2EN.DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab_Sim2EN.FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(); //字段名
objvFieldTab_Sim2EN.Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(); //标题
objvFieldTab_Sim2EN.FldLength = Int32.Parse(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度
objvFieldTab_Sim2EN.FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度
objvFieldTab_Sim2EN.PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id
objvFieldTab_Sim2EN.FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTab_Sim2EN.HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab_Sim2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab_Sim2EN);
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
List<clsvFieldTab_Sim2EN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFieldTab_Sim2EN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab_Sim2EN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFieldTab_Sim2EN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFieldTab_Sim2EN> arrObjLst = new List<clsvFieldTab_Sim2EN>(); 
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
	clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN();
try
{
objvFieldTab_Sim2EN.FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id
objvFieldTab_Sim2EN.DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab_Sim2EN.FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(); //字段名
objvFieldTab_Sim2EN.Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(); //标题
objvFieldTab_Sim2EN.FldLength = Int32.Parse(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度
objvFieldTab_Sim2EN.FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度
objvFieldTab_Sim2EN.PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id
objvFieldTab_Sim2EN.FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTab_Sim2EN.HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab_Sim2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab_Sim2EN);
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
public static List<clsvFieldTab_Sim2EN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFieldTab_Sim2EN> arrObjLst = new List<clsvFieldTab_Sim2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN();
try
{
objvFieldTab_Sim2EN.FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id
objvFieldTab_Sim2EN.DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab_Sim2EN.FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(); //字段名
objvFieldTab_Sim2EN.Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(); //标题
objvFieldTab_Sim2EN.FldLength = Int32.Parse(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度
objvFieldTab_Sim2EN.FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度
objvFieldTab_Sim2EN.PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id
objvFieldTab_Sim2EN.FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTab_Sim2EN.HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab_Sim2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab_Sim2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFieldTab_Sim2EN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFieldTab_Sim2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFieldTab_Sim2EN> arrObjLst = new List<clsvFieldTab_Sim2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN();
try
{
objvFieldTab_Sim2EN.FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id
objvFieldTab_Sim2EN.DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab_Sim2EN.FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(); //字段名
objvFieldTab_Sim2EN.Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(); //标题
objvFieldTab_Sim2EN.FldLength = Int32.Parse(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度
objvFieldTab_Sim2EN.FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度
objvFieldTab_Sim2EN.PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id
objvFieldTab_Sim2EN.FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTab_Sim2EN.HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab_Sim2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab_Sim2EN);
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
public static List<clsvFieldTab_Sim2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFieldTab_Sim2EN> arrObjLst = new List<clsvFieldTab_Sim2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN();
try
{
objvFieldTab_Sim2EN.FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id
objvFieldTab_Sim2EN.DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab_Sim2EN.FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(); //字段名
objvFieldTab_Sim2EN.Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(); //标题
objvFieldTab_Sim2EN.FldLength = Int32.Parse(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度
objvFieldTab_Sim2EN.FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度
objvFieldTab_Sim2EN.PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id
objvFieldTab_Sim2EN.FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTab_Sim2EN.HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab_Sim2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab_Sim2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab_Sim2EN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFieldTab_Sim2EN> arrObjLst = new List<clsvFieldTab_Sim2EN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = new clsvFieldTab_Sim2EN();
try
{
objvFieldTab_Sim2EN.FldId = objRow[convFieldTab_Sim2.FldId].ToString().Trim(); //字段Id
objvFieldTab_Sim2EN.DataTypeId = objRow[convFieldTab_Sim2.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab_Sim2EN.FldName = objRow[convFieldTab_Sim2.FldName].ToString().Trim(); //字段名
objvFieldTab_Sim2EN.Caption = objRow[convFieldTab_Sim2.Caption].ToString().Trim(); //标题
objvFieldTab_Sim2EN.FldLength = Int32.Parse(objRow[convFieldTab_Sim2.FldLength].ToString().Trim()); //字段长度
objvFieldTab_Sim2EN.FldPrecision = objRow[convFieldTab_Sim2.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab_Sim2.FldPrecision].ToString().Trim()); //精确度
objvFieldTab_Sim2EN.PrjId = objRow[convFieldTab_Sim2.PrjId].ToString().Trim(); //工程Id
objvFieldTab_Sim2EN.FieldTypeId = objRow[convFieldTab_Sim2.FieldTypeId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.FieldTypeId].ToString().Trim(); //字段类型Id
objvFieldTab_Sim2EN.HomologousFldId = objRow[convFieldTab_Sim2.HomologousFldId] == DBNull.Value ? null : objRow[convFieldTab_Sim2.HomologousFldId].ToString().Trim(); //同源字段Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab_Sim2EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab_Sim2EN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2EN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFieldTab_Sim2(ref clsvFieldTab_Sim2EN objvFieldTab_Sim2EN)
{
bool bolResult = vFieldTab_Sim2DA.GetvFieldTab_Sim2(ref objvFieldTab_Sim2EN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTab_Sim2EN GetObjByFldId(string strFldId)
{
if (strFldId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFldId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFldId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFldId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = vFieldTab_Sim2DA.GetObjByFldId(strFldId);
return objvFieldTab_Sim2EN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFieldTab_Sim2EN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = vFieldTab_Sim2DA.GetFirstObj(strWhereCond);
 return objvFieldTab_Sim2EN;
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
public static clsvFieldTab_Sim2EN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = vFieldTab_Sim2DA.GetObjByDataRow(objRow);
 return objvFieldTab_Sim2EN;
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
public static clsvFieldTab_Sim2EN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFieldTab_Sim2EN objvFieldTab_Sim2EN = vFieldTab_Sim2DA.GetObjByDataRow(objRow);
 return objvFieldTab_Sim2EN;
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
 /// <param name = "strFldId">所给的关键字</param>
 /// <param name = "lstvFieldTab_Sim2ObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFieldTab_Sim2EN GetObjByFldIdFromList(string strFldId, List<clsvFieldTab_Sim2EN> lstvFieldTab_Sim2ObjLst)
{
foreach (clsvFieldTab_Sim2EN objvFieldTab_Sim2EN in lstvFieldTab_Sim2ObjLst)
{
if (objvFieldTab_Sim2EN.FldId == strFldId)
{
return objvFieldTab_Sim2EN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrIdByPrefix_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix_S(string strPrefix) 
{
if (string.IsNullOrEmpty(strPrefix) == true)
{
var strMsg = string.Format("前缀不能为空.(from {0})",
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
 string strMaxFldId;
 try
 {
 strMaxFldId = new clsvFieldTab_Sim2DA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxFldId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000025)根据前缀获取最大关键字值出错, {1}.(from {0})",
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
 string strFldId;
 try
 {
 strFldId = new clsvFieldTab_Sim2DA().GetFirstID(strWhereCond);
 return strFldId;
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
 arrList = vFieldTab_Sim2DA.GetID(strWhereCond);
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
bool bolIsExist = vFieldTab_Sim2DA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFldId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFldId)
{
if (string.IsNullOrEmpty(strFldId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFldId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vFieldTab_Sim2DA.IsExist(strFldId);
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
 bolIsExist = clsvFieldTab_Sim2DA.IsExistTable();
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
 bolIsExist = vFieldTab_Sim2DA.IsExistTable(strTabName);
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
 /// <param name = "objvFieldTab_Sim2ENS">源对象</param>
 /// <param name = "objvFieldTab_Sim2ENT">目标对象</param>
 public static void CopyTo(clsvFieldTab_Sim2EN objvFieldTab_Sim2ENS, clsvFieldTab_Sim2EN objvFieldTab_Sim2ENT)
{
try
{
objvFieldTab_Sim2ENT.FldId = objvFieldTab_Sim2ENS.FldId; //字段Id
objvFieldTab_Sim2ENT.DataTypeId = objvFieldTab_Sim2ENS.DataTypeId; //数据类型Id
objvFieldTab_Sim2ENT.FldName = objvFieldTab_Sim2ENS.FldName; //字段名
objvFieldTab_Sim2ENT.Caption = objvFieldTab_Sim2ENS.Caption; //标题
objvFieldTab_Sim2ENT.FldLength = objvFieldTab_Sim2ENS.FldLength; //字段长度
objvFieldTab_Sim2ENT.FldPrecision = objvFieldTab_Sim2ENS.FldPrecision; //精确度
objvFieldTab_Sim2ENT.PrjId = objvFieldTab_Sim2ENS.PrjId; //工程Id
objvFieldTab_Sim2ENT.FieldTypeId = objvFieldTab_Sim2ENS.FieldTypeId; //字段类型Id
objvFieldTab_Sim2ENT.HomologousFldId = objvFieldTab_Sim2ENS.HomologousFldId; //同源字段Id
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
 /// <param name = "objvFieldTab_Sim2EN">源简化对象</param>
 public static void SetUpdFlag(clsvFieldTab_Sim2EN objvFieldTab_Sim2EN)
{
try
{
objvFieldTab_Sim2EN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFieldTab_Sim2EN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFieldTab_Sim2.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab_Sim2EN.FldId = objvFieldTab_Sim2EN.FldId; //字段Id
}
if (arrFldSet.Contains(convFieldTab_Sim2.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab_Sim2EN.DataTypeId = objvFieldTab_Sim2EN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(convFieldTab_Sim2.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab_Sim2EN.FldName = objvFieldTab_Sim2EN.FldName; //字段名
}
if (arrFldSet.Contains(convFieldTab_Sim2.Caption, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab_Sim2EN.Caption = objvFieldTab_Sim2EN.Caption; //标题
}
if (arrFldSet.Contains(convFieldTab_Sim2.FldLength, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab_Sim2EN.FldLength = objvFieldTab_Sim2EN.FldLength; //字段长度
}
if (arrFldSet.Contains(convFieldTab_Sim2.FldPrecision, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab_Sim2EN.FldPrecision = objvFieldTab_Sim2EN.FldPrecision; //精确度
}
if (arrFldSet.Contains(convFieldTab_Sim2.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab_Sim2EN.PrjId = objvFieldTab_Sim2EN.PrjId; //工程Id
}
if (arrFldSet.Contains(convFieldTab_Sim2.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab_Sim2EN.FieldTypeId = objvFieldTab_Sim2EN.FieldTypeId == "[null]" ? null :  objvFieldTab_Sim2EN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(convFieldTab_Sim2.HomologousFldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab_Sim2EN.HomologousFldId = objvFieldTab_Sim2EN.HomologousFldId == "[null]" ? null :  objvFieldTab_Sim2EN.HomologousFldId; //同源字段Id
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
 /// <param name = "objvFieldTab_Sim2EN">源简化对象</param>
 public static void AccessFldValueNull(clsvFieldTab_Sim2EN objvFieldTab_Sim2EN)
{
try
{
if (objvFieldTab_Sim2EN.FieldTypeId == "[null]") objvFieldTab_Sim2EN.FieldTypeId = null; //字段类型Id
if (objvFieldTab_Sim2EN.HomologousFldId == "[null]") objvFieldTab_Sim2EN.HomologousFldId = null; //同源字段Id
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
public static void CheckProperty4Condition(clsvFieldTab_Sim2EN objvFieldTab_Sim2EN)
{
 vFieldTab_Sim2DA.CheckProperty4Condition(objvFieldTab_Sim2EN);
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
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FldId");
//if (arrvFieldTab_Sim2ObjLstCache == null)
//{
//arrvFieldTab_Sim2ObjLstCache = vFieldTab_Sim2DA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFldId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFieldTab_Sim2EN GetObjByFldIdCache(string strFldId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFieldTab_Sim2EN._CurrTabName, strPrjId);
List<clsvFieldTab_Sim2EN> arrvFieldTab_Sim2ObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab_Sim2EN> arrvFieldTab_Sim2ObjLst_Sel =
arrvFieldTab_Sim2ObjLstCache
.Where(x=> x.FldId == strFldId 
);
if (arrvFieldTab_Sim2ObjLst_Sel.Count() == 0)
{
   clsvFieldTab_Sim2EN obj = clsvFieldTab_Sim2BL.GetObjByFldId(strFldId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strFldId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvFieldTab_Sim2ObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTab_Sim2EN> GetAllvFieldTab_Sim2ObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvFieldTab_Sim2EN> arrvFieldTab_Sim2ObjLstCache = GetObjLstCache(strPrjId); 
return arrvFieldTab_Sim2ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTab_Sim2EN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFieldTab_Sim2EN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvFieldTab_Sim2EN> arrvFieldTab_Sim2ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvFieldTab_Sim2ObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvFieldTab_Sim2EN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvFieldTab_Sim2EN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFieldTab_Sim2EN._RefreshTimeLst.Count == 0) return "";
return clsvFieldTab_Sim2EN._RefreshTimeLst[clsvFieldTab_Sim2EN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strFldId, string strPrjId)
{
if (strInFldName != convFieldTab_Sim2.FldId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFieldTab_Sim2._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFieldTab_Sim2._AttributeName));
throw new Exception(strMsg);
}
var objvFieldTab_Sim2 = clsvFieldTab_Sim2BL.GetObjByFldIdCache(strFldId, strPrjId);
if (objvFieldTab_Sim2 == null) return "";
return objvFieldTab_Sim2[strOutFldName].ToString();
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
int intRecCount = clsvFieldTab_Sim2DA.GetRecCount(strTabName);
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
int intRecCount = clsvFieldTab_Sim2DA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFieldTab_Sim2DA.GetRecCount();
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
int intRecCount = clsvFieldTab_Sim2DA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFieldTab_Sim2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFieldTab_Sim2EN objvFieldTab_Sim2Cond)
{
 string strPrjId = objvFieldTab_Sim2Cond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvFieldTab_Sim2BL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvFieldTab_Sim2EN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab_Sim2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFieldTab_Sim2._AttributeName)
{
if (objvFieldTab_Sim2Cond.IsUpdated(strFldName) == false) continue;
if (objvFieldTab_Sim2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab_Sim2Cond[strFldName].ToString());
}
else
{
if (objvFieldTab_Sim2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFieldTab_Sim2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab_Sim2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFieldTab_Sim2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFieldTab_Sim2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFieldTab_Sim2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFieldTab_Sim2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFieldTab_Sim2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFieldTab_Sim2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFieldTab_Sim2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFieldTab_Sim2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFieldTab_Sim2Cond[strFldName]));
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
 List<string> arrList = clsvFieldTab_Sim2DA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFieldTab_Sim2DA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFieldTab_Sim2DA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}