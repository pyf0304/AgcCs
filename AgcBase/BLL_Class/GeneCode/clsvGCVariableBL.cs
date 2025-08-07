
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvGCVariableBL
 表名:vGCVariable(00050561)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:49
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvGCVariableBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strVarId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvGCVariableEN GetObj(this K_VarId_vGCVariable myKey)
{
clsvGCVariableEN objvGCVariableEN = clsvGCVariableBL.vGCVariableDA.GetObjByVarId(myKey.Value);
return objvGCVariableEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetVarId(this clsvGCVariableEN objvGCVariableEN, string strVarId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarId, 8, convGCVariable.VarId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarId, 8, convGCVariable.VarId);
}
objvGCVariableEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.VarId) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.VarId, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.VarId] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetVarName(this clsvGCVariableEN objvGCVariableEN, string strVarName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarName, 50, convGCVariable.VarName);
}
objvGCVariableEN.VarName = strVarName; //变量名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.VarName) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.VarName, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.VarName] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetVarExpression(this clsvGCVariableEN objvGCVariableEN, string strVarExpression, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarExpression, 150, convGCVariable.VarExpression);
}
objvGCVariableEN.VarExpression = strVarExpression; //变量表达式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.VarExpression) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.VarExpression, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.VarExpression] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetInitValue(this clsvGCVariableEN objvGCVariableEN, string strInitValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInitValue, 1000, convGCVariable.InitValue);
}
objvGCVariableEN.InitValue = strInitValue; //初始值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.InitValue) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.InitValue, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.InitValue] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetVarTypeId(this clsvGCVariableEN objvGCVariableEN, string strVarTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarTypeId, 4, convGCVariable.VarTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarTypeId, 4, convGCVariable.VarTypeId);
}
objvGCVariableEN.VarTypeId = strVarTypeId; //变量类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.VarTypeId) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.VarTypeId, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.VarTypeId] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetVarTypeName(this clsvGCVariableEN objvGCVariableEN, string strVarTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarTypeName, 50, convGCVariable.VarTypeName);
}
objvGCVariableEN.VarTypeName = strVarTypeName; //变量类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.VarTypeName) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.VarTypeName, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.VarTypeName] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetPrjId(this clsvGCVariableEN objvGCVariableEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convGCVariable.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convGCVariable.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convGCVariable.PrjId);
}
objvGCVariableEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.PrjId) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.PrjId, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.PrjId] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetUpdDate(this clsvGCVariableEN objvGCVariableEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convGCVariable.UpdDate);
}
objvGCVariableEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.UpdDate) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.UpdDate, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.UpdDate] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetUpdUser(this clsvGCVariableEN objvGCVariableEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convGCVariable.UpdUser);
}
objvGCVariableEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.UpdUser) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.UpdUser, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.UpdUser] = strComparisonOp;
}
}
return objvGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvGCVariableEN SetMemo(this clsvGCVariableEN objvGCVariableEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convGCVariable.Memo);
}
objvGCVariableEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvGCVariableEN.dicFldComparisonOp.ContainsKey(convGCVariable.Memo) == false)
{
objvGCVariableEN.dicFldComparisonOp.Add(convGCVariable.Memo, strComparisonOp);
}
else
{
objvGCVariableEN.dicFldComparisonOp[convGCVariable.Memo] = strComparisonOp;
}
}
return objvGCVariableEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvGCVariableENS">源对象</param>
 /// <param name = "objvGCVariableENT">目标对象</param>
 public static void CopyTo(this clsvGCVariableEN objvGCVariableENS, clsvGCVariableEN objvGCVariableENT)
{
try
{
objvGCVariableENT.VarId = objvGCVariableENS.VarId; //变量Id
objvGCVariableENT.VarName = objvGCVariableENS.VarName; //变量名
objvGCVariableENT.VarExpression = objvGCVariableENS.VarExpression; //变量表达式
objvGCVariableENT.InitValue = objvGCVariableENS.InitValue; //初始值
objvGCVariableENT.VarTypeId = objvGCVariableENS.VarTypeId; //变量类型Id
objvGCVariableENT.VarTypeName = objvGCVariableENS.VarTypeName; //变量类型名
objvGCVariableENT.PrjId = objvGCVariableENS.PrjId; //工程Id
objvGCVariableENT.UpdDate = objvGCVariableENS.UpdDate; //修改日期
objvGCVariableENT.UpdUser = objvGCVariableENS.UpdUser; //修改者
objvGCVariableENT.Memo = objvGCVariableENS.Memo; //说明
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
 /// <param name = "objvGCVariableENS">源对象</param>
 /// <returns>目标对象=>clsvGCVariableEN:objvGCVariableENT</returns>
 public static clsvGCVariableEN CopyTo(this clsvGCVariableEN objvGCVariableENS)
{
try
{
 clsvGCVariableEN objvGCVariableENT = new clsvGCVariableEN()
{
VarId = objvGCVariableENS.VarId, //变量Id
VarName = objvGCVariableENS.VarName, //变量名
VarExpression = objvGCVariableENS.VarExpression, //变量表达式
InitValue = objvGCVariableENS.InitValue, //初始值
VarTypeId = objvGCVariableENS.VarTypeId, //变量类型Id
VarTypeName = objvGCVariableENS.VarTypeName, //变量类型名
PrjId = objvGCVariableENS.PrjId, //工程Id
UpdDate = objvGCVariableENS.UpdDate, //修改日期
UpdUser = objvGCVariableENS.UpdUser, //修改者
Memo = objvGCVariableENS.Memo, //说明
};
 return objvGCVariableENT;
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
public static void CheckProperty4Condition(this clsvGCVariableEN objvGCVariableEN)
{
 clsvGCVariableBL.vGCVariableDA.CheckProperty4Condition(objvGCVariableEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvGCVariableEN objvGCVariableCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvGCVariableCond.IsUpdated(convGCVariable.VarId) == true)
{
string strComparisonOpVarId = objvGCVariableCond.dicFldComparisonOp[convGCVariable.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.VarId, objvGCVariableCond.VarId, strComparisonOpVarId);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.VarName) == true)
{
string strComparisonOpVarName = objvGCVariableCond.dicFldComparisonOp[convGCVariable.VarName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.VarName, objvGCVariableCond.VarName, strComparisonOpVarName);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.VarExpression) == true)
{
string strComparisonOpVarExpression = objvGCVariableCond.dicFldComparisonOp[convGCVariable.VarExpression];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.VarExpression, objvGCVariableCond.VarExpression, strComparisonOpVarExpression);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.InitValue) == true)
{
string strComparisonOpInitValue = objvGCVariableCond.dicFldComparisonOp[convGCVariable.InitValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.InitValue, objvGCVariableCond.InitValue, strComparisonOpInitValue);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.VarTypeId) == true)
{
string strComparisonOpVarTypeId = objvGCVariableCond.dicFldComparisonOp[convGCVariable.VarTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.VarTypeId, objvGCVariableCond.VarTypeId, strComparisonOpVarTypeId);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.VarTypeName) == true)
{
string strComparisonOpVarTypeName = objvGCVariableCond.dicFldComparisonOp[convGCVariable.VarTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.VarTypeName, objvGCVariableCond.VarTypeName, strComparisonOpVarTypeName);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.PrjId) == true)
{
string strComparisonOpPrjId = objvGCVariableCond.dicFldComparisonOp[convGCVariable.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.PrjId, objvGCVariableCond.PrjId, strComparisonOpPrjId);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.UpdDate) == true)
{
string strComparisonOpUpdDate = objvGCVariableCond.dicFldComparisonOp[convGCVariable.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.UpdDate, objvGCVariableCond.UpdDate, strComparisonOpUpdDate);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.UpdUser) == true)
{
string strComparisonOpUpdUser = objvGCVariableCond.dicFldComparisonOp[convGCVariable.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.UpdUser, objvGCVariableCond.UpdUser, strComparisonOpUpdUser);
}
if (objvGCVariableCond.IsUpdated(convGCVariable.Memo) == true)
{
string strComparisonOpMemo = objvGCVariableCond.dicFldComparisonOp[convGCVariable.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convGCVariable.Memo, objvGCVariableCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vGCVariable
{
public virtual bool UpdRelaTabDate(string strVarId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vGCVariable(vGCVariable)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvGCVariableBL
{
public static RelatedActions_vGCVariable relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvGCVariableDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvGCVariableDA vGCVariableDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvGCVariableDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvGCVariableBL()
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
if (string.IsNullOrEmpty(clsvGCVariableEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvGCVariableEN._ConnectString);
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
public static DataTable GetDataTable_vGCVariable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vGCVariableDA.GetDataTable_vGCVariable(strWhereCond);
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
objDT = vGCVariableDA.GetDataTable(strWhereCond);
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
objDT = vGCVariableDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vGCVariableDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vGCVariableDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vGCVariableDA.GetDataTable_Top(objTopPara);
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
objDT = vGCVariableDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vGCVariableDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vGCVariableDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrVarIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvGCVariableEN> GetObjLstByVarIdLst(List<string> arrVarIdLst)
{
List<clsvGCVariableEN> arrObjLst = new List<clsvGCVariableEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrVarIdLst, true);
 string strWhereCond = string.Format("VarId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN();
try
{
objvGCVariableEN.VarId = objRow[convGCVariable.VarId].ToString().Trim(); //变量Id
objvGCVariableEN.VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(); //变量名
objvGCVariableEN.VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(); //变量表达式
objvGCVariableEN.InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(); //初始值
objvGCVariableEN.VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objvGCVariableEN.VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(); //变量类型名
objvGCVariableEN.PrjId = objRow[convGCVariable.PrjId].ToString().Trim(); //工程Id
objvGCVariableEN.UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(); //修改日期
objvGCVariableEN.UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(); //修改者
objvGCVariableEN.Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGCVariableEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrVarIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvGCVariableEN> GetObjLstByVarIdLstCache(List<string> arrVarIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvGCVariableEN._CurrTabName, strPrjId);
List<clsvGCVariableEN> arrvGCVariableObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvGCVariableEN> arrvGCVariableObjLst_Sel =
arrvGCVariableObjLstCache
.Where(x => arrVarIdLst.Contains(x.VarId));
return arrvGCVariableObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvGCVariableEN> GetObjLst(string strWhereCond)
{
List<clsvGCVariableEN> arrObjLst = new List<clsvGCVariableEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN();
try
{
objvGCVariableEN.VarId = objRow[convGCVariable.VarId].ToString().Trim(); //变量Id
objvGCVariableEN.VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(); //变量名
objvGCVariableEN.VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(); //变量表达式
objvGCVariableEN.InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(); //初始值
objvGCVariableEN.VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objvGCVariableEN.VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(); //变量类型名
objvGCVariableEN.PrjId = objRow[convGCVariable.PrjId].ToString().Trim(); //工程Id
objvGCVariableEN.UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(); //修改日期
objvGCVariableEN.UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(); //修改者
objvGCVariableEN.Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGCVariableEN);
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
public static List<clsvGCVariableEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvGCVariableEN> arrObjLst = new List<clsvGCVariableEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN();
try
{
objvGCVariableEN.VarId = objRow[convGCVariable.VarId].ToString().Trim(); //变量Id
objvGCVariableEN.VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(); //变量名
objvGCVariableEN.VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(); //变量表达式
objvGCVariableEN.InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(); //初始值
objvGCVariableEN.VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objvGCVariableEN.VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(); //变量类型名
objvGCVariableEN.PrjId = objRow[convGCVariable.PrjId].ToString().Trim(); //工程Id
objvGCVariableEN.UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(); //修改日期
objvGCVariableEN.UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(); //修改者
objvGCVariableEN.Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGCVariableEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvGCVariableCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvGCVariableEN> GetSubObjLstCache(clsvGCVariableEN objvGCVariableCond)
{
 string strPrjId = objvGCVariableCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvGCVariableBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvGCVariableEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvGCVariableEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convGCVariable._AttributeName)
{
if (objvGCVariableCond.IsUpdated(strFldName) == false) continue;
if (objvGCVariableCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvGCVariableCond[strFldName].ToString());
}
else
{
if (objvGCVariableCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvGCVariableCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvGCVariableCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvGCVariableCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvGCVariableCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvGCVariableCond[strFldName]));
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
public static List<clsvGCVariableEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvGCVariableEN> arrObjLst = new List<clsvGCVariableEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN();
try
{
objvGCVariableEN.VarId = objRow[convGCVariable.VarId].ToString().Trim(); //变量Id
objvGCVariableEN.VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(); //变量名
objvGCVariableEN.VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(); //变量表达式
objvGCVariableEN.InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(); //初始值
objvGCVariableEN.VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objvGCVariableEN.VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(); //变量类型名
objvGCVariableEN.PrjId = objRow[convGCVariable.PrjId].ToString().Trim(); //工程Id
objvGCVariableEN.UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(); //修改日期
objvGCVariableEN.UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(); //修改者
objvGCVariableEN.Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGCVariableEN);
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
public static List<clsvGCVariableEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvGCVariableEN> arrObjLst = new List<clsvGCVariableEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN();
try
{
objvGCVariableEN.VarId = objRow[convGCVariable.VarId].ToString().Trim(); //变量Id
objvGCVariableEN.VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(); //变量名
objvGCVariableEN.VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(); //变量表达式
objvGCVariableEN.InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(); //初始值
objvGCVariableEN.VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objvGCVariableEN.VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(); //变量类型名
objvGCVariableEN.PrjId = objRow[convGCVariable.PrjId].ToString().Trim(); //工程Id
objvGCVariableEN.UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(); //修改日期
objvGCVariableEN.UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(); //修改者
objvGCVariableEN.Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGCVariableEN);
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
List<clsvGCVariableEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvGCVariableEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvGCVariableEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvGCVariableEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvGCVariableEN> arrObjLst = new List<clsvGCVariableEN>(); 
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
	clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN();
try
{
objvGCVariableEN.VarId = objRow[convGCVariable.VarId].ToString().Trim(); //变量Id
objvGCVariableEN.VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(); //变量名
objvGCVariableEN.VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(); //变量表达式
objvGCVariableEN.InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(); //初始值
objvGCVariableEN.VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objvGCVariableEN.VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(); //变量类型名
objvGCVariableEN.PrjId = objRow[convGCVariable.PrjId].ToString().Trim(); //工程Id
objvGCVariableEN.UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(); //修改日期
objvGCVariableEN.UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(); //修改者
objvGCVariableEN.Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGCVariableEN);
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
public static List<clsvGCVariableEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvGCVariableEN> arrObjLst = new List<clsvGCVariableEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN();
try
{
objvGCVariableEN.VarId = objRow[convGCVariable.VarId].ToString().Trim(); //变量Id
objvGCVariableEN.VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(); //变量名
objvGCVariableEN.VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(); //变量表达式
objvGCVariableEN.InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(); //初始值
objvGCVariableEN.VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objvGCVariableEN.VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(); //变量类型名
objvGCVariableEN.PrjId = objRow[convGCVariable.PrjId].ToString().Trim(); //工程Id
objvGCVariableEN.UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(); //修改日期
objvGCVariableEN.UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(); //修改者
objvGCVariableEN.Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGCVariableEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvGCVariableEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvGCVariableEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvGCVariableEN> arrObjLst = new List<clsvGCVariableEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN();
try
{
objvGCVariableEN.VarId = objRow[convGCVariable.VarId].ToString().Trim(); //变量Id
objvGCVariableEN.VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(); //变量名
objvGCVariableEN.VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(); //变量表达式
objvGCVariableEN.InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(); //初始值
objvGCVariableEN.VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objvGCVariableEN.VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(); //变量类型名
objvGCVariableEN.PrjId = objRow[convGCVariable.PrjId].ToString().Trim(); //工程Id
objvGCVariableEN.UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(); //修改日期
objvGCVariableEN.UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(); //修改者
objvGCVariableEN.Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGCVariableEN);
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
public static List<clsvGCVariableEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvGCVariableEN> arrObjLst = new List<clsvGCVariableEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN();
try
{
objvGCVariableEN.VarId = objRow[convGCVariable.VarId].ToString().Trim(); //变量Id
objvGCVariableEN.VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(); //变量名
objvGCVariableEN.VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(); //变量表达式
objvGCVariableEN.InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(); //初始值
objvGCVariableEN.VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objvGCVariableEN.VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(); //变量类型名
objvGCVariableEN.PrjId = objRow[convGCVariable.PrjId].ToString().Trim(); //工程Id
objvGCVariableEN.UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(); //修改日期
objvGCVariableEN.UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(); //修改者
objvGCVariableEN.Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGCVariableEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvGCVariableEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvGCVariableEN> arrObjLst = new List<clsvGCVariableEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvGCVariableEN objvGCVariableEN = new clsvGCVariableEN();
try
{
objvGCVariableEN.VarId = objRow[convGCVariable.VarId].ToString().Trim(); //变量Id
objvGCVariableEN.VarName = objRow[convGCVariable.VarName] == DBNull.Value ? null : objRow[convGCVariable.VarName].ToString().Trim(); //变量名
objvGCVariableEN.VarExpression = objRow[convGCVariable.VarExpression] == DBNull.Value ? null : objRow[convGCVariable.VarExpression].ToString().Trim(); //变量表达式
objvGCVariableEN.InitValue = objRow[convGCVariable.InitValue] == DBNull.Value ? null : objRow[convGCVariable.InitValue].ToString().Trim(); //初始值
objvGCVariableEN.VarTypeId = objRow[convGCVariable.VarTypeId] == DBNull.Value ? null : objRow[convGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objvGCVariableEN.VarTypeName = objRow[convGCVariable.VarTypeName] == DBNull.Value ? null : objRow[convGCVariable.VarTypeName].ToString().Trim(); //变量类型名
objvGCVariableEN.PrjId = objRow[convGCVariable.PrjId].ToString().Trim(); //工程Id
objvGCVariableEN.UpdDate = objRow[convGCVariable.UpdDate] == DBNull.Value ? null : objRow[convGCVariable.UpdDate].ToString().Trim(); //修改日期
objvGCVariableEN.UpdUser = objRow[convGCVariable.UpdUser] == DBNull.Value ? null : objRow[convGCVariable.UpdUser].ToString().Trim(); //修改者
objvGCVariableEN.Memo = objRow[convGCVariable.Memo] == DBNull.Value ? null : objRow[convGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvGCVariableEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvGCVariableEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvGCVariable(ref clsvGCVariableEN objvGCVariableEN)
{
bool bolResult = vGCVariableDA.GetvGCVariable(ref objvGCVariableEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strVarId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvGCVariableEN GetObjByVarId(string strVarId)
{
if (strVarId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strVarId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strVarId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strVarId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvGCVariableEN objvGCVariableEN = vGCVariableDA.GetObjByVarId(strVarId);
return objvGCVariableEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvGCVariableEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvGCVariableEN objvGCVariableEN = vGCVariableDA.GetFirstObj(strWhereCond);
 return objvGCVariableEN;
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
public static clsvGCVariableEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvGCVariableEN objvGCVariableEN = vGCVariableDA.GetObjByDataRow(objRow);
 return objvGCVariableEN;
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
public static clsvGCVariableEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvGCVariableEN objvGCVariableEN = vGCVariableDA.GetObjByDataRow(objRow);
 return objvGCVariableEN;
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
 /// <param name = "strVarId">所给的关键字</param>
 /// <param name = "lstvGCVariableObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvGCVariableEN GetObjByVarIdFromList(string strVarId, List<clsvGCVariableEN> lstvGCVariableObjLst)
{
foreach (clsvGCVariableEN objvGCVariableEN in lstvGCVariableObjLst)
{
if (objvGCVariableEN.VarId == strVarId)
{
return objvGCVariableEN;
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
 string strMaxVarId;
 try
 {
 strMaxVarId = clsvGCVariableDA.GetMaxStrId();
 return strMaxVarId;
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
 string strVarId;
 try
 {
 strVarId = new clsvGCVariableDA().GetFirstID(strWhereCond);
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
 arrList = vGCVariableDA.GetID(strWhereCond);
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
bool bolIsExist = vGCVariableDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strVarId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strVarId)
{
if (string.IsNullOrEmpty(strVarId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strVarId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vGCVariableDA.IsExist(strVarId);
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
 bolIsExist = clsvGCVariableDA.IsExistTable();
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
 bolIsExist = vGCVariableDA.IsExistTable(strTabName);
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
 /// <param name = "objvGCVariableENS">源对象</param>
 /// <param name = "objvGCVariableENT">目标对象</param>
 public static void CopyTo(clsvGCVariableEN objvGCVariableENS, clsvGCVariableEN objvGCVariableENT)
{
try
{
objvGCVariableENT.VarId = objvGCVariableENS.VarId; //变量Id
objvGCVariableENT.VarName = objvGCVariableENS.VarName; //变量名
objvGCVariableENT.VarExpression = objvGCVariableENS.VarExpression; //变量表达式
objvGCVariableENT.InitValue = objvGCVariableENS.InitValue; //初始值
objvGCVariableENT.VarTypeId = objvGCVariableENS.VarTypeId; //变量类型Id
objvGCVariableENT.VarTypeName = objvGCVariableENS.VarTypeName; //变量类型名
objvGCVariableENT.PrjId = objvGCVariableENS.PrjId; //工程Id
objvGCVariableENT.UpdDate = objvGCVariableENS.UpdDate; //修改日期
objvGCVariableENT.UpdUser = objvGCVariableENS.UpdUser; //修改者
objvGCVariableENT.Memo = objvGCVariableENS.Memo; //说明
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
 /// <param name = "objvGCVariableEN">源简化对象</param>
 public static void SetUpdFlag(clsvGCVariableEN objvGCVariableEN)
{
try
{
objvGCVariableEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvGCVariableEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convGCVariable.VarId, new clsStrCompareIgnoreCase())  ==  true)
{
objvGCVariableEN.VarId = objvGCVariableEN.VarId; //变量Id
}
if (arrFldSet.Contains(convGCVariable.VarName, new clsStrCompareIgnoreCase())  ==  true)
{
objvGCVariableEN.VarName = objvGCVariableEN.VarName == "[null]" ? null :  objvGCVariableEN.VarName; //变量名
}
if (arrFldSet.Contains(convGCVariable.VarExpression, new clsStrCompareIgnoreCase())  ==  true)
{
objvGCVariableEN.VarExpression = objvGCVariableEN.VarExpression == "[null]" ? null :  objvGCVariableEN.VarExpression; //变量表达式
}
if (arrFldSet.Contains(convGCVariable.InitValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvGCVariableEN.InitValue = objvGCVariableEN.InitValue == "[null]" ? null :  objvGCVariableEN.InitValue; //初始值
}
if (arrFldSet.Contains(convGCVariable.VarTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvGCVariableEN.VarTypeId = objvGCVariableEN.VarTypeId == "[null]" ? null :  objvGCVariableEN.VarTypeId; //变量类型Id
}
if (arrFldSet.Contains(convGCVariable.VarTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvGCVariableEN.VarTypeName = objvGCVariableEN.VarTypeName == "[null]" ? null :  objvGCVariableEN.VarTypeName; //变量类型名
}
if (arrFldSet.Contains(convGCVariable.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvGCVariableEN.PrjId = objvGCVariableEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convGCVariable.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvGCVariableEN.UpdDate = objvGCVariableEN.UpdDate == "[null]" ? null :  objvGCVariableEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convGCVariable.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvGCVariableEN.UpdUser = objvGCVariableEN.UpdUser == "[null]" ? null :  objvGCVariableEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convGCVariable.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvGCVariableEN.Memo = objvGCVariableEN.Memo == "[null]" ? null :  objvGCVariableEN.Memo; //说明
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
 /// <param name = "objvGCVariableEN">源简化对象</param>
 public static void AccessFldValueNull(clsvGCVariableEN objvGCVariableEN)
{
try
{
if (objvGCVariableEN.VarName == "[null]") objvGCVariableEN.VarName = null; //变量名
if (objvGCVariableEN.VarExpression == "[null]") objvGCVariableEN.VarExpression = null; //变量表达式
if (objvGCVariableEN.InitValue == "[null]") objvGCVariableEN.InitValue = null; //初始值
if (objvGCVariableEN.VarTypeId == "[null]") objvGCVariableEN.VarTypeId = null; //变量类型Id
if (objvGCVariableEN.VarTypeName == "[null]") objvGCVariableEN.VarTypeName = null; //变量类型名
if (objvGCVariableEN.UpdDate == "[null]") objvGCVariableEN.UpdDate = null; //修改日期
if (objvGCVariableEN.UpdUser == "[null]") objvGCVariableEN.UpdUser = null; //修改者
if (objvGCVariableEN.Memo == "[null]") objvGCVariableEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvGCVariableEN objvGCVariableEN)
{
 vGCVariableDA.CheckProperty4Condition(objvGCVariableEN);
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
if (clsGCVariableBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGCVariableBL没有刷新缓存机制(clsGCVariableBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsGCVariableTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGCVariableTypeBL没有刷新缓存机制(clsGCVariableTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by VarId");
//if (arrvGCVariableObjLstCache == null)
//{
//arrvGCVariableObjLstCache = vGCVariableDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strVarId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvGCVariableEN GetObjByVarIdCache(string strVarId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvGCVariableEN._CurrTabName, strPrjId);
List<clsvGCVariableEN> arrvGCVariableObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvGCVariableEN> arrvGCVariableObjLst_Sel =
arrvGCVariableObjLstCache
.Where(x=> x.VarId == strVarId 
);
if (arrvGCVariableObjLst_Sel.Count() == 0)
{
   clsvGCVariableEN obj = clsvGCVariableBL.GetObjByVarId(strVarId);
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
return arrvGCVariableObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvGCVariableEN> GetAllvGCVariableObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvGCVariableEN> arrvGCVariableObjLstCache = GetObjLstCache(strPrjId); 
return arrvGCVariableObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvGCVariableEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvGCVariableEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvGCVariableEN> arrvGCVariableObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvGCVariableObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvGCVariableEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvGCVariableEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvGCVariableEN._RefreshTimeLst.Count == 0) return "";
return clsvGCVariableEN._RefreshTimeLst[clsvGCVariableEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strVarId, string strPrjId)
{
if (strInFldName != convGCVariable.VarId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convGCVariable._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convGCVariable._AttributeName));
throw new Exception(strMsg);
}
var objvGCVariable = clsvGCVariableBL.GetObjByVarIdCache(strVarId, strPrjId);
if (objvGCVariable == null) return "";
return objvGCVariable[strOutFldName].ToString();
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
int intRecCount = clsvGCVariableDA.GetRecCount(strTabName);
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
int intRecCount = clsvGCVariableDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvGCVariableDA.GetRecCount();
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
int intRecCount = clsvGCVariableDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvGCVariableCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvGCVariableEN objvGCVariableCond)
{
 string strPrjId = objvGCVariableCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvGCVariableBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvGCVariableEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvGCVariableEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convGCVariable._AttributeName)
{
if (objvGCVariableCond.IsUpdated(strFldName) == false) continue;
if (objvGCVariableCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvGCVariableCond[strFldName].ToString());
}
else
{
if (objvGCVariableCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvGCVariableCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvGCVariableCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvGCVariableCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvGCVariableCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvGCVariableCond[strFldName]));
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
 List<string> arrList = clsvGCVariableDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vGCVariableDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vGCVariableDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}