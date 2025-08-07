
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCVariableWApi
 表名:GCVariable(00050559)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:03
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsGCVariableWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarId">变量Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetVarId(this clsGCVariableEN objGCVariableEN, string strVarId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVarId, 8, conGCVariable.VarId);
clsCheckSql.CheckFieldForeignKey(strVarId, 8, conGCVariable.VarId);
objGCVariableEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.VarId) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.VarId, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.VarId] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarName">变量名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetVarName(this clsGCVariableEN objGCVariableEN, string strVarName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVarName, conGCVariable.VarName);
clsCheckSql.CheckFieldLen(strVarName, 50, conGCVariable.VarName);
objGCVariableEN.VarName = strVarName; //变量名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.VarName) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.VarName, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.VarName] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarExpression">变量表达式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetVarExpression(this clsGCVariableEN objGCVariableEN, string strVarExpression, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVarExpression, conGCVariable.VarExpression);
clsCheckSql.CheckFieldLen(strVarExpression, 150, conGCVariable.VarExpression);
objGCVariableEN.VarExpression = strVarExpression; //变量表达式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.VarExpression) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.VarExpression, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.VarExpression] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strFilePath">文件路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetFilePath(this clsGCVariableEN objGCVariableEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFilePath, 500, conGCVariable.FilePath);
objGCVariableEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.FilePath) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.FilePath, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.FilePath] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strInitValue">初始值</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetInitValue(this clsGCVariableEN objGCVariableEN, string strInitValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInitValue, 1000, conGCVariable.InitValue);
objGCVariableEN.InitValue = strInitValue; //初始值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.InitValue) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.InitValue, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.InitValue] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strVarTypeId">变量类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetVarTypeId(this clsGCVariableEN objGCVariableEN, string strVarTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVarTypeId, conGCVariable.VarTypeId);
clsCheckSql.CheckFieldLen(strVarTypeId, 4, conGCVariable.VarTypeId);
clsCheckSql.CheckFieldForeignKey(strVarTypeId, 4, conGCVariable.VarTypeId);
objGCVariableEN.VarTypeId = strVarTypeId; //变量类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.VarTypeId) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.VarTypeId, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.VarTypeId] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataTypeId">数据类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetDataTypeId(this clsGCVariableEN objGCVariableEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, conGCVariable.DataTypeId);
clsCheckSql.CheckFieldLen(strDataTypeId, 2, conGCVariable.DataTypeId);
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, conGCVariable.DataTypeId);
objGCVariableEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.DataTypeId) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.DataTypeId, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.DataTypeId] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strVariableType">变量类型</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetVariableType(this clsGCVariableEN objGCVariableEN, string strVariableType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVariableType, 100, conGCVariable.VariableType);
objGCVariableEN.VariableType = strVariableType; //变量类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.VariableType) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.VariableType, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.VariableType] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strVariableTypeFullName">变量类型全名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetVariableTypeFullName(this clsGCVariableEN objGCVariableEN, string strVariableTypeFullName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVariableTypeFullName, 500, conGCVariable.VariableTypeFullName);
objGCVariableEN.VariableTypeFullName = strVariableTypeFullName; //变量类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.VariableTypeFullName) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.VariableTypeFullName, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.VariableTypeFullName] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strClsName">类名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetClsName(this clsGCVariableEN objGCVariableEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClsName, 100, conGCVariable.ClsName);
objGCVariableEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.ClsName) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.ClsName, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.ClsName] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetUpdDate(this clsGCVariableEN objGCVariableEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conGCVariable.UpdDate);
objGCVariableEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.UpdDate) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.UpdDate, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.UpdDate] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetUpdUser(this clsGCVariableEN objGCVariableEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conGCVariable.UpdUser);
objGCVariableEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.UpdUser) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.UpdUser, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.UpdUser] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetMemo(this clsGCVariableEN objGCVariableEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conGCVariable.Memo);
objGCVariableEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.Memo) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.Memo, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.Memo] = strComparisonOp;
}
}
return objGCVariableEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGCVariableEN objGCVariableCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGCVariableCond.IsUpdated(conGCVariable.VarId) == true)
{
string strComparisonOpVarId = objGCVariableCond.dicFldComparisonOp[conGCVariable.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.VarId, objGCVariableCond.VarId, strComparisonOpVarId);
}
if (objGCVariableCond.IsUpdated(conGCVariable.VarName) == true)
{
string strComparisonOpVarName = objGCVariableCond.dicFldComparisonOp[conGCVariable.VarName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.VarName, objGCVariableCond.VarName, strComparisonOpVarName);
}
if (objGCVariableCond.IsUpdated(conGCVariable.VarExpression) == true)
{
string strComparisonOpVarExpression = objGCVariableCond.dicFldComparisonOp[conGCVariable.VarExpression];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.VarExpression, objGCVariableCond.VarExpression, strComparisonOpVarExpression);
}
if (objGCVariableCond.IsUpdated(conGCVariable.FilePath) == true)
{
string strComparisonOpFilePath = objGCVariableCond.dicFldComparisonOp[conGCVariable.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.FilePath, objGCVariableCond.FilePath, strComparisonOpFilePath);
}
if (objGCVariableCond.IsUpdated(conGCVariable.InitValue) == true)
{
string strComparisonOpInitValue = objGCVariableCond.dicFldComparisonOp[conGCVariable.InitValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.InitValue, objGCVariableCond.InitValue, strComparisonOpInitValue);
}
if (objGCVariableCond.IsUpdated(conGCVariable.VarTypeId) == true)
{
string strComparisonOpVarTypeId = objGCVariableCond.dicFldComparisonOp[conGCVariable.VarTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.VarTypeId, objGCVariableCond.VarTypeId, strComparisonOpVarTypeId);
}
if (objGCVariableCond.IsUpdated(conGCVariable.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objGCVariableCond.dicFldComparisonOp[conGCVariable.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.DataTypeId, objGCVariableCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objGCVariableCond.IsUpdated(conGCVariable.VariableType) == true)
{
string strComparisonOpVariableType = objGCVariableCond.dicFldComparisonOp[conGCVariable.VariableType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.VariableType, objGCVariableCond.VariableType, strComparisonOpVariableType);
}
if (objGCVariableCond.IsUpdated(conGCVariable.VariableTypeFullName) == true)
{
string strComparisonOpVariableTypeFullName = objGCVariableCond.dicFldComparisonOp[conGCVariable.VariableTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.VariableTypeFullName, objGCVariableCond.VariableTypeFullName, strComparisonOpVariableTypeFullName);
}
if (objGCVariableCond.IsUpdated(conGCVariable.ClsName) == true)
{
string strComparisonOpClsName = objGCVariableCond.dicFldComparisonOp[conGCVariable.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.ClsName, objGCVariableCond.ClsName, strComparisonOpClsName);
}
if (objGCVariableCond.IsUpdated(conGCVariable.UpdDate) == true)
{
string strComparisonOpUpdDate = objGCVariableCond.dicFldComparisonOp[conGCVariable.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.UpdDate, objGCVariableCond.UpdDate, strComparisonOpUpdDate);
}
if (objGCVariableCond.IsUpdated(conGCVariable.UpdUser) == true)
{
string strComparisonOpUpdUser = objGCVariableCond.dicFldComparisonOp[conGCVariable.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.UpdUser, objGCVariableCond.UpdUser, strComparisonOpUpdUser);
}
if (objGCVariableCond.IsUpdated(conGCVariable.Memo) == true)
{
string strComparisonOpMemo = objGCVariableCond.dicFldComparisonOp[conGCVariable.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.Memo, objGCVariableCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCVariableEN objGCVariableEN)
{
 if (string.IsNullOrEmpty(objGCVariableEN.VarId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objGCVariableEN.sfUpdFldSetStr = objGCVariableEN.getsfUpdFldSetStr();
clsGCVariableWApi.CheckPropertyNew(objGCVariableEN); 
bool bolResult = clsGCVariableWApi.UpdateRecord(objGCVariableEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableWApi.ReFreshCache();
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
 /// 获取唯一性条件串--GCVariable(GC变量), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:VarName_VarTypeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objGCVariableEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsGCVariableEN objGCVariableEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objGCVariableEN == null) return "";
if (objGCVariableEN.VarId == null || objGCVariableEN.VarId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and VarName = '{0}'", objGCVariableEN.VarName);
 sbCondition.AppendFormat(" and VarTypeId = '{0}'", objGCVariableEN.VarTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("VarId !=  '{0}'", objGCVariableEN.VarId);
 sbCondition.AppendFormat(" and VarName = '{0}'", objGCVariableEN.VarName);
 sbCondition.AppendFormat(" and VarTypeId = '{0}'", objGCVariableEN.VarTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGCVariableEN objGCVariableEN)
{
try
{
 if (string.IsNullOrEmpty(objGCVariableEN.VarId) == true || clsGCVariableWApi.IsExist(objGCVariableEN.VarId) == true)
 {
     objGCVariableEN.VarId = clsGCVariableWApi.GetMaxStrId();
 }
clsGCVariableWApi.CheckPropertyNew(objGCVariableEN); 
bool bolResult = clsGCVariableWApi.AddNewRecord(objGCVariableEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableWApi.ReFreshCache();
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
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsGCVariableEN objGCVariableEN)
{
try
{
clsGCVariableWApi.CheckPropertyNew(objGCVariableEN); 
string strVarId = clsGCVariableWApi.AddNewRecordWithMaxId(objGCVariableEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableWApi.ReFreshCache();
return strVarId;
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
 /// <param name = "objGCVariableEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCVariableEN objGCVariableEN, string strWhereCond)
{
try
{
clsGCVariableWApi.CheckPropertyNew(objGCVariableEN); 
bool bolResult = clsGCVariableWApi.UpdateWithCondition(objGCVariableEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableWApi.ReFreshCache();
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
 /// GC变量(GCVariable)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsGCVariableWApi
{
private static readonly string mstrApiControllerName = "GCVariableApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsGCVariableWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_VarId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[GC变量]...","0");
List<clsGCVariableEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="VarId";
objDDL.DataTextField="VarName";
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

public static void BindCbo_VarId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conGCVariable.VarId); 
List<clsGCVariableEN> arrObjLst = clsGCVariableWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsGCVariableEN objGCVariableEN = new clsGCVariableEN()
{
VarId = "0",
VarName = "选[GC变量]..."
};
arrObjLst.Insert(0, objGCVariableEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conGCVariable.VarId;
objComboBox.DisplayMember = conGCVariable.VarName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsGCVariableEN objGCVariableEN)
{
if (!Object.Equals(null, objGCVariableEN.VarId) && GetStrLen(objGCVariableEN.VarId) > 8)
{
 throw new Exception("字段[变量Id]的长度不能超过8!");
}
if (!Object.Equals(null, objGCVariableEN.VarName) && GetStrLen(objGCVariableEN.VarName) > 50)
{
 throw new Exception("字段[变量名]的长度不能超过50!");
}
if (!Object.Equals(null, objGCVariableEN.VarExpression) && GetStrLen(objGCVariableEN.VarExpression) > 150)
{
 throw new Exception("字段[变量表达式]的长度不能超过150!");
}
if (!Object.Equals(null, objGCVariableEN.FilePath) && GetStrLen(objGCVariableEN.FilePath) > 500)
{
 throw new Exception("字段[文件路径]的长度不能超过500!");
}
if (!Object.Equals(null, objGCVariableEN.InitValue) && GetStrLen(objGCVariableEN.InitValue) > 1000)
{
 throw new Exception("字段[初始值]的长度不能超过1000!");
}
if (!Object.Equals(null, objGCVariableEN.VarTypeId) && GetStrLen(objGCVariableEN.VarTypeId) > 4)
{
 throw new Exception("字段[变量类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objGCVariableEN.DataTypeId) && GetStrLen(objGCVariableEN.DataTypeId) > 2)
{
 throw new Exception("字段[数据类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objGCVariableEN.VariableType) && GetStrLen(objGCVariableEN.VariableType) > 100)
{
 throw new Exception("字段[变量类型]的长度不能超过100!");
}
if (!Object.Equals(null, objGCVariableEN.VariableTypeFullName) && GetStrLen(objGCVariableEN.VariableTypeFullName) > 500)
{
 throw new Exception("字段[变量类型全名]的长度不能超过500!");
}
if (!Object.Equals(null, objGCVariableEN.ClsName) && GetStrLen(objGCVariableEN.ClsName) > 100)
{
 throw new Exception("字段[类名]的长度不能超过100!");
}
if (!Object.Equals(null, objGCVariableEN.UpdDate) && GetStrLen(objGCVariableEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objGCVariableEN.UpdUser) && GetStrLen(objGCVariableEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objGCVariableEN.Memo) && GetStrLen(objGCVariableEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objGCVariableEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strVarId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCVariableEN GetObjByVarId(string strVarId)
{
if (strVarId == "") return null;
string strAction = "GetObjByVarId";
clsGCVariableEN objGCVariableEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strVarId"] = strVarId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objGCVariableEN = JsonConvert.DeserializeObject<clsGCVariableEN>(strJson);
return objGCVariableEN;
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
public static clsGCVariableEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsGCVariableEN objGCVariableEN;
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
objGCVariableEN = JsonConvert.DeserializeObject<clsGCVariableEN>(strJson);
return objGCVariableEN;
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
 /// <param name = "strVarId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCVariableEN GetObjByVarIdCache(string strVarId)
{
if (string.IsNullOrEmpty(strVarId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsGCVariableEN._CurrTabName);
List<clsGCVariableEN> arrGCVariableObjLstCache = GetObjLstCache();
IEnumerable <clsGCVariableEN> arrGCVariableObjLst_Sel =
from objGCVariableEN in arrGCVariableObjLstCache
where objGCVariableEN.VarId == strVarId 
select objGCVariableEN;
if (arrGCVariableObjLst_Sel.Count() == 0)
{
   clsGCVariableEN obj = clsGCVariableWApi.GetObjByVarId(strVarId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrGCVariableObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strVarId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetVarNameByVarIdCache(string strVarId)
{
if (string.IsNullOrEmpty(strVarId) == true) return "";
//初始化列表缓存
List<clsGCVariableEN> arrGCVariableObjLstCache = GetObjLstCache();
IEnumerable <clsGCVariableEN> arrGCVariableObjLst_Sel1 =
from objGCVariableEN in arrGCVariableObjLstCache
where objGCVariableEN.VarId == strVarId 
select objGCVariableEN;
List <clsGCVariableEN> arrGCVariableObjLst_Sel = new List<clsGCVariableEN>();
foreach (clsGCVariableEN obj in arrGCVariableObjLst_Sel1)
{
arrGCVariableObjLst_Sel.Add(obj);
}
if (arrGCVariableObjLst_Sel.Count > 0)
{
return arrGCVariableObjLst_Sel[0].VarName;
}
string strErrMsgForGetObjById = string.Format("在GCVariable对象缓存列表中,找不到记录[VarId = {0}](函数:{1})", strVarId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsGCVariableBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strVarId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByVarIdCache(string strVarId)
{
if (string.IsNullOrEmpty(strVarId) == true) return "";
//初始化列表缓存
List<clsGCVariableEN> arrGCVariableObjLstCache = GetObjLstCache();
IEnumerable <clsGCVariableEN> arrGCVariableObjLst_Sel1 =
from objGCVariableEN in arrGCVariableObjLstCache
where objGCVariableEN.VarId == strVarId 
select objGCVariableEN;
List <clsGCVariableEN> arrGCVariableObjLst_Sel = new List<clsGCVariableEN>();
foreach (clsGCVariableEN obj in arrGCVariableObjLst_Sel1)
{
arrGCVariableObjLst_Sel.Add(obj);
}
if (arrGCVariableObjLst_Sel.Count > 0)
{
return arrGCVariableObjLst_Sel[0].VarName;
}
string strErrMsgForGetObjById = string.Format("在GCVariable对象缓存列表中,找不到记录的相关名称[VarId = {0}](函数:{1})", strVarId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsGCVariableBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCVariableEN> GetObjLst(string strWhereCond)
{
 List<clsGCVariableEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGCVariableEN>>(strJson);
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
 /// <param name = "arrVarId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCVariableEN> GetObjLstByVarIdLst(List<string> arrVarId)
{
 List<clsGCVariableEN> arrObjLst; 
string strAction = "GetObjLstByVarIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrVarId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsGCVariableEN>>(strJson);
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
 /// <param name = "arrVarId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsGCVariableEN> GetObjLstByVarIdLstCache(List<string> arrVarId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsGCVariableEN._CurrTabName);
List<clsGCVariableEN> arrGCVariableObjLstCache = GetObjLstCache();
IEnumerable <clsGCVariableEN> arrGCVariableObjLst_Sel =
from objGCVariableEN in arrGCVariableObjLstCache
where arrVarId.Contains(objGCVariableEN.VarId)
select objGCVariableEN;
return arrGCVariableObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCVariableEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsGCVariableEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGCVariableEN>>(strJson);
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
public static List<clsGCVariableEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsGCVariableEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGCVariableEN>>(strJson);
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
public static List<clsGCVariableEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsGCVariableEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGCVariableEN>>(strJson);
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
public static List<clsGCVariableEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsGCVariableEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGCVariableEN>>(strJson);
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
public static int DelRecord(string strVarId)
{
string strAction = "DelRecord";
try
{
 clsGCVariableEN objGCVariableEN = clsGCVariableWApi.GetObjByVarId(strVarId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strVarId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsGCVariableWApi.ReFreshCache();
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
public static int DelGCVariables(List<string> arrVarId)
{
string strAction = "DelGCVariables";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrVarId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsGCVariableWApi.ReFreshCache();
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
public static int DelGCVariablesByCond(string strWhereCond)
{
string strAction = "DelGCVariablesByCond";
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
public static bool AddNewRecord(clsGCVariableEN objGCVariableEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGCVariableEN>(objGCVariableEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsGCVariableEN objGCVariableEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGCVariableEN>(objGCVariableEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableWApi.ReFreshCache();
var strVarId = (string)jobjReturn0["returnStr"];
return strVarId;
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
public static bool UpdateRecord(clsGCVariableEN objGCVariableEN)
{
if (string.IsNullOrEmpty(objGCVariableEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objGCVariableEN.VarId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGCVariableEN>(objGCVariableEN);
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
 /// <param name = "objGCVariableEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsGCVariableEN objGCVariableEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objGCVariableEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objGCVariableEN.VarId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objGCVariableEN.VarId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGCVariableEN>(objGCVariableEN);
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
public static bool IsExist(string strVarId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strVarId"] = strVarId
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
 /// <param name = "objGCVariableENS">源对象</param>
 /// <param name = "objGCVariableENT">目标对象</param>
 public static void CopyTo(clsGCVariableEN objGCVariableENS, clsGCVariableEN objGCVariableENT)
{
try
{
objGCVariableENT.VarId = objGCVariableENS.VarId; //变量Id
objGCVariableENT.VarName = objGCVariableENS.VarName; //变量名
objGCVariableENT.VarExpression = objGCVariableENS.VarExpression; //变量表达式
objGCVariableENT.FilePath = objGCVariableENS.FilePath; //文件路径
objGCVariableENT.InitValue = objGCVariableENS.InitValue; //初始值
objGCVariableENT.VarTypeId = objGCVariableENS.VarTypeId; //变量类型Id
objGCVariableENT.DataTypeId = objGCVariableENS.DataTypeId; //数据类型Id
objGCVariableENT.VariableType = objGCVariableENS.VariableType; //变量类型
objGCVariableENT.VariableTypeFullName = objGCVariableENS.VariableTypeFullName; //变量类型全名
objGCVariableENT.ClsName = objGCVariableENS.ClsName; //类名
objGCVariableENT.UpdDate = objGCVariableENS.UpdDate; //修改日期
objGCVariableENT.UpdUser = objGCVariableENS.UpdUser; //修改者
objGCVariableENT.Memo = objGCVariableENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsGCVariableEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsGCVariableEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsGCVariableEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsGCVariableEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsGCVariableEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsGCVariableEN._AttributeName)
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
string strKey = string.Format("{0}", clsGCVariableEN._CurrTabName);
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
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsGCVariableWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsGCVariableEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGCVariableWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCVariableEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsGCVariableEN._CurrTabName;
List<clsGCVariableEN> arrGCVariableObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrGCVariableObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsGCVariableEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conGCVariable.VarId, Type.GetType("System.String"));
objDT.Columns.Add(conGCVariable.VarName, Type.GetType("System.String"));
objDT.Columns.Add(conGCVariable.VarExpression, Type.GetType("System.String"));
objDT.Columns.Add(conGCVariable.FilePath, Type.GetType("System.String"));
objDT.Columns.Add(conGCVariable.InitValue, Type.GetType("System.String"));
objDT.Columns.Add(conGCVariable.VarTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conGCVariable.DataTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conGCVariable.VariableType, Type.GetType("System.String"));
objDT.Columns.Add(conGCVariable.VariableTypeFullName, Type.GetType("System.String"));
objDT.Columns.Add(conGCVariable.ClsName, Type.GetType("System.String"));
objDT.Columns.Add(conGCVariable.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conGCVariable.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conGCVariable.Memo, Type.GetType("System.String"));
foreach (clsGCVariableEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conGCVariable.VarId] = objInFor[conGCVariable.VarId];
objDR[conGCVariable.VarName] = objInFor[conGCVariable.VarName];
objDR[conGCVariable.VarExpression] = objInFor[conGCVariable.VarExpression];
objDR[conGCVariable.FilePath] = objInFor[conGCVariable.FilePath];
objDR[conGCVariable.InitValue] = objInFor[conGCVariable.InitValue];
objDR[conGCVariable.VarTypeId] = objInFor[conGCVariable.VarTypeId];
objDR[conGCVariable.DataTypeId] = objInFor[conGCVariable.DataTypeId];
objDR[conGCVariable.VariableType] = objInFor[conGCVariable.VariableType];
objDR[conGCVariable.VariableTypeFullName] = objInFor[conGCVariable.VariableTypeFullName];
objDR[conGCVariable.ClsName] = objInFor[conGCVariable.ClsName];
objDR[conGCVariable.UpdDate] = objInFor[conGCVariable.UpdDate];
objDR[conGCVariable.UpdUser] = objInFor[conGCVariable.UpdUser];
objDR[conGCVariable.Memo] = objInFor[conGCVariable.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// GC变量(GCVariable)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4GCVariable : clsCommFun4BL
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
clsGCVariableWApi.ReFreshThisCache();
}
}

}