
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjFunctionBL
 表名:vPrjFunction(00050259)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsvPrjFunctionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjFunctionEN GetObj(this K_FuncId_vPrjFunction myKey)
{
clsvPrjFunctionEN objvPrjFunctionEN = clsvPrjFunctionBL.vPrjFunctionDA.GetObjByFuncId(myKey.Value);
return objvPrjFunctionEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetFuncId(this clsvPrjFunctionEN objvPrjFunctionEN, string strFuncId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId, 10, convPrjFunction.FuncId);
}
objvPrjFunctionEN.FuncId = strFuncId; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.FuncId) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.FuncId, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.FuncId] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetFuncName(this clsvPrjFunctionEN objvPrjFunctionEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, convPrjFunction.FuncName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, convPrjFunction.FuncName);
}
objvPrjFunctionEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.FuncName) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.FuncName, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.FuncName] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetPrjId(this clsvPrjFunctionEN objvPrjFunctionEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjFunction.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjFunction.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjFunction.PrjId);
}
objvPrjFunctionEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.PrjId) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.PrjId, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.PrjId] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetReturnTypeId(this clsvPrjFunctionEN objvPrjFunctionEN, string strReturnTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReturnTypeId, convPrjFunction.ReturnTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReturnTypeId, 2, convPrjFunction.ReturnTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReturnTypeId, 2, convPrjFunction.ReturnTypeId);
}
objvPrjFunctionEN.ReturnTypeId = strReturnTypeId; //返回类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.ReturnTypeId) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.ReturnTypeId, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.ReturnTypeId] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetDataTypeName(this clsvPrjFunctionEN objvPrjFunctionEN, string strDataTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeName, 100, convPrjFunction.DataTypeName);
}
objvPrjFunctionEN.DataTypeName = strDataTypeName; //数据类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.DataTypeName) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.DataTypeName, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.DataTypeName] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetDataCnName(this clsvPrjFunctionEN objvPrjFunctionEN, string strDataCnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataCnName, 100, convPrjFunction.DataCnName);
}
objvPrjFunctionEN.DataCnName = strDataCnName; //数据类型中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.DataCnName) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.DataCnName, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.DataCnName] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetCsType(this clsvPrjFunctionEN objvPrjFunctionEN, string strCsType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCsType, 100, convPrjFunction.CsType);
}
objvPrjFunctionEN.CsType = strCsType; //CS类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.CsType) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.CsType, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.CsType] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetFuncTypeId(this clsvPrjFunctionEN objvPrjFunctionEN, string strFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeId, convPrjFunction.FuncTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, convPrjFunction.FuncTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, convPrjFunction.FuncTypeId);
}
objvPrjFunctionEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.FuncTypeId) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.FuncTypeId, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.FuncTypeId] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetFuncTypeName(this clsvPrjFunctionEN objvPrjFunctionEN, string strFuncTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeName, 20, convPrjFunction.FuncTypeName);
}
objvPrjFunctionEN.FuncTypeName = strFuncTypeName; //函数类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.FuncTypeName) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.FuncTypeName, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.FuncTypeName] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetIsTemplate(this clsvPrjFunctionEN objvPrjFunctionEN, bool bolIsTemplate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTemplate, convPrjFunction.IsTemplate);
objvPrjFunctionEN.IsTemplate = bolIsTemplate; //是否模板
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.IsTemplate) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.IsTemplate, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.IsTemplate] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetFuncCode(this clsvPrjFunctionEN objvPrjFunctionEN, string strFuncCode, string strComparisonOp="")
	{
objvPrjFunctionEN.FuncCode = strFuncCode; //函数代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.FuncCode) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.FuncCode, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.FuncCode] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetUserId(this clsvPrjFunctionEN objvPrjFunctionEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convPrjFunction.UserId);
}
objvPrjFunctionEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.UserId) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.UserId, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.UserId] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetUpdDate(this clsvPrjFunctionEN objvPrjFunctionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjFunction.UpdDate);
}
objvPrjFunctionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.UpdDate) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.UpdDate, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.UpdDate] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetUpdUser(this clsvPrjFunctionEN objvPrjFunctionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPrjFunction.UpdUser);
}
objvPrjFunctionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.UpdUser) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.UpdUser, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.UpdUser] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFunctionEN SetMemo(this clsvPrjFunctionEN objvPrjFunctionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjFunction.Memo);
}
objvPrjFunctionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFunctionEN.dicFldComparisonOp.ContainsKey(convPrjFunction.Memo) == false)
{
objvPrjFunctionEN.dicFldComparisonOp.Add(convPrjFunction.Memo, strComparisonOp);
}
else
{
objvPrjFunctionEN.dicFldComparisonOp[convPrjFunction.Memo] = strComparisonOp;
}
}
return objvPrjFunctionEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjFunctionENS">源对象</param>
 /// <param name = "objvPrjFunctionENT">目标对象</param>
 public static void CopyTo(this clsvPrjFunctionEN objvPrjFunctionENS, clsvPrjFunctionEN objvPrjFunctionENT)
{
try
{
objvPrjFunctionENT.FuncId = objvPrjFunctionENS.FuncId; //函数ID
objvPrjFunctionENT.FuncName = objvPrjFunctionENS.FuncName; //函数名
objvPrjFunctionENT.PrjId = objvPrjFunctionENS.PrjId; //工程Id
objvPrjFunctionENT.ReturnTypeId = objvPrjFunctionENS.ReturnTypeId; //返回类型ID
objvPrjFunctionENT.DataTypeName = objvPrjFunctionENS.DataTypeName; //数据类型名称
objvPrjFunctionENT.DataCnName = objvPrjFunctionENS.DataCnName; //数据类型中文名称
objvPrjFunctionENT.CsType = objvPrjFunctionENS.CsType; //CS类型
objvPrjFunctionENT.FuncTypeId = objvPrjFunctionENS.FuncTypeId; //函数类型Id
objvPrjFunctionENT.FuncTypeName = objvPrjFunctionENS.FuncTypeName; //函数类型名
objvPrjFunctionENT.IsTemplate = objvPrjFunctionENS.IsTemplate; //是否模板
objvPrjFunctionENT.FuncCode = objvPrjFunctionENS.FuncCode; //函数代码
objvPrjFunctionENT.UserId = objvPrjFunctionENS.UserId; //用户Id
objvPrjFunctionENT.UpdDate = objvPrjFunctionENS.UpdDate; //修改日期
objvPrjFunctionENT.UpdUser = objvPrjFunctionENS.UpdUser; //修改者
objvPrjFunctionENT.Memo = objvPrjFunctionENS.Memo; //说明
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
 /// <param name = "objvPrjFunctionENS">源对象</param>
 /// <returns>目标对象=>clsvPrjFunctionEN:objvPrjFunctionENT</returns>
 public static clsvPrjFunctionEN CopyTo(this clsvPrjFunctionEN objvPrjFunctionENS)
{
try
{
 clsvPrjFunctionEN objvPrjFunctionENT = new clsvPrjFunctionEN()
{
FuncId = objvPrjFunctionENS.FuncId, //函数ID
FuncName = objvPrjFunctionENS.FuncName, //函数名
PrjId = objvPrjFunctionENS.PrjId, //工程Id
ReturnTypeId = objvPrjFunctionENS.ReturnTypeId, //返回类型ID
DataTypeName = objvPrjFunctionENS.DataTypeName, //数据类型名称
DataCnName = objvPrjFunctionENS.DataCnName, //数据类型中文名称
CsType = objvPrjFunctionENS.CsType, //CS类型
FuncTypeId = objvPrjFunctionENS.FuncTypeId, //函数类型Id
FuncTypeName = objvPrjFunctionENS.FuncTypeName, //函数类型名
IsTemplate = objvPrjFunctionENS.IsTemplate, //是否模板
FuncCode = objvPrjFunctionENS.FuncCode, //函数代码
UserId = objvPrjFunctionENS.UserId, //用户Id
UpdDate = objvPrjFunctionENS.UpdDate, //修改日期
UpdUser = objvPrjFunctionENS.UpdUser, //修改者
Memo = objvPrjFunctionENS.Memo, //说明
};
 return objvPrjFunctionENT;
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
public static void CheckProperty4Condition(this clsvPrjFunctionEN objvPrjFunctionEN)
{
 clsvPrjFunctionBL.vPrjFunctionDA.CheckProperty4Condition(objvPrjFunctionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjFunctionEN objvPrjFunctionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.FuncId) == true)
{
string strComparisonOpFuncId = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.FuncId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.FuncId, objvPrjFunctionCond.FuncId, strComparisonOpFuncId);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.FuncName) == true)
{
string strComparisonOpFuncName = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.FuncName, objvPrjFunctionCond.FuncName, strComparisonOpFuncName);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.PrjId, objvPrjFunctionCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.ReturnTypeId) == true)
{
string strComparisonOpReturnTypeId = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.ReturnTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.ReturnTypeId, objvPrjFunctionCond.ReturnTypeId, strComparisonOpReturnTypeId);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.DataTypeName) == true)
{
string strComparisonOpDataTypeName = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.DataTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.DataTypeName, objvPrjFunctionCond.DataTypeName, strComparisonOpDataTypeName);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.DataCnName) == true)
{
string strComparisonOpDataCnName = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.DataCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.DataCnName, objvPrjFunctionCond.DataCnName, strComparisonOpDataCnName);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.CsType) == true)
{
string strComparisonOpCsType = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.CsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.CsType, objvPrjFunctionCond.CsType, strComparisonOpCsType);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.FuncTypeId, objvPrjFunctionCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.FuncTypeName) == true)
{
string strComparisonOpFuncTypeName = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.FuncTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.FuncTypeName, objvPrjFunctionCond.FuncTypeName, strComparisonOpFuncTypeName);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.IsTemplate) == true)
{
if (objvPrjFunctionCond.IsTemplate == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjFunction.IsTemplate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjFunction.IsTemplate);
}
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.UserId) == true)
{
string strComparisonOpUserId = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.UserId, objvPrjFunctionCond.UserId, strComparisonOpUserId);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.UpdDate, objvPrjFunctionCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.UpdUser, objvPrjFunctionCond.UpdUser, strComparisonOpUpdUser);
}
if (objvPrjFunctionCond.IsUpdated(convPrjFunction.Memo) == true)
{
string strComparisonOpMemo = objvPrjFunctionCond.dicFldComparisonOp[convPrjFunction.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFunction.Memo, objvPrjFunctionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjFunction
{
public virtual bool UpdRelaTabDate(string strFuncId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程函数(vPrjFunction)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjFunctionBL
{
public static RelatedActions_vPrjFunction relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjFunctionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjFunctionDA vPrjFunctionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjFunctionDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjFunctionBL()
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
if (string.IsNullOrEmpty(clsvPrjFunctionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjFunctionEN._ConnectString);
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
public static DataTable GetDataTable_vPrjFunction(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjFunctionDA.GetDataTable_vPrjFunction(strWhereCond);
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
objDT = vPrjFunctionDA.GetDataTable(strWhereCond);
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
objDT = vPrjFunctionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjFunctionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjFunctionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjFunctionDA.GetDataTable_Top(objTopPara);
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
objDT = vPrjFunctionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjFunctionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjFunctionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPrjFunctionEN> GetObjLstByFuncIdLst(List<string> arrFuncIdLst)
{
List<clsvPrjFunctionEN> arrObjLst = new List<clsvPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncIdLst, true);
 string strWhereCond = string.Format("FuncId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN();
try
{
objvPrjFunctionEN.FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(); //函数ID
objvPrjFunctionEN.FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(); //函数名
objvPrjFunctionEN.PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(); //工程Id
objvPrjFunctionEN.ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvPrjFunctionEN.DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjFunctionEN.DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称
objvPrjFunctionEN.CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(); //CS类型
objvPrjFunctionEN.FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objvPrjFunctionEN.FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名
objvPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objvPrjFunctionEN.FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(); //函数代码
objvPrjFunctionEN.UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(); //用户Id
objvPrjFunctionEN.UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(); //修改日期
objvPrjFunctionEN.UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(); //修改者
objvPrjFunctionEN.Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjFunctionEN> GetObjLstByFuncIdLstCache(List<string> arrFuncIdLst)
{
string strKey = string.Format("{0}", clsvPrjFunctionEN._CurrTabName);
List<clsvPrjFunctionEN> arrvPrjFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFunctionEN> arrvPrjFunctionObjLst_Sel =
arrvPrjFunctionObjLstCache
.Where(x => arrFuncIdLst.Contains(x.FuncId));
return arrvPrjFunctionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFunctionEN> GetObjLst(string strWhereCond)
{
List<clsvPrjFunctionEN> arrObjLst = new List<clsvPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN();
try
{
objvPrjFunctionEN.FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(); //函数ID
objvPrjFunctionEN.FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(); //函数名
objvPrjFunctionEN.PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(); //工程Id
objvPrjFunctionEN.ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvPrjFunctionEN.DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjFunctionEN.DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称
objvPrjFunctionEN.CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(); //CS类型
objvPrjFunctionEN.FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objvPrjFunctionEN.FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名
objvPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objvPrjFunctionEN.FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(); //函数代码
objvPrjFunctionEN.UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(); //用户Id
objvPrjFunctionEN.UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(); //修改日期
objvPrjFunctionEN.UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(); //修改者
objvPrjFunctionEN.Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFunctionEN);
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
public static List<clsvPrjFunctionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjFunctionEN> arrObjLst = new List<clsvPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN();
try
{
objvPrjFunctionEN.FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(); //函数ID
objvPrjFunctionEN.FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(); //函数名
objvPrjFunctionEN.PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(); //工程Id
objvPrjFunctionEN.ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvPrjFunctionEN.DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjFunctionEN.DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称
objvPrjFunctionEN.CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(); //CS类型
objvPrjFunctionEN.FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objvPrjFunctionEN.FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名
objvPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objvPrjFunctionEN.FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(); //函数代码
objvPrjFunctionEN.UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(); //用户Id
objvPrjFunctionEN.UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(); //修改日期
objvPrjFunctionEN.UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(); //修改者
objvPrjFunctionEN.Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjFunctionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjFunctionEN> GetSubObjLstCache(clsvPrjFunctionEN objvPrjFunctionCond)
{
List<clsvPrjFunctionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFunctionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjFunction._AttributeName)
{
if (objvPrjFunctionCond.IsUpdated(strFldName) == false) continue;
if (objvPrjFunctionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFunctionCond[strFldName].ToString());
}
else
{
if (objvPrjFunctionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjFunctionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFunctionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjFunctionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjFunctionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjFunctionCond[strFldName]));
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
public static List<clsvPrjFunctionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjFunctionEN> arrObjLst = new List<clsvPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN();
try
{
objvPrjFunctionEN.FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(); //函数ID
objvPrjFunctionEN.FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(); //函数名
objvPrjFunctionEN.PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(); //工程Id
objvPrjFunctionEN.ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvPrjFunctionEN.DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjFunctionEN.DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称
objvPrjFunctionEN.CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(); //CS类型
objvPrjFunctionEN.FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objvPrjFunctionEN.FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名
objvPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objvPrjFunctionEN.FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(); //函数代码
objvPrjFunctionEN.UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(); //用户Id
objvPrjFunctionEN.UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(); //修改日期
objvPrjFunctionEN.UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(); //修改者
objvPrjFunctionEN.Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFunctionEN);
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
public static List<clsvPrjFunctionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjFunctionEN> arrObjLst = new List<clsvPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN();
try
{
objvPrjFunctionEN.FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(); //函数ID
objvPrjFunctionEN.FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(); //函数名
objvPrjFunctionEN.PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(); //工程Id
objvPrjFunctionEN.ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvPrjFunctionEN.DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjFunctionEN.DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称
objvPrjFunctionEN.CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(); //CS类型
objvPrjFunctionEN.FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objvPrjFunctionEN.FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名
objvPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objvPrjFunctionEN.FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(); //函数代码
objvPrjFunctionEN.UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(); //用户Id
objvPrjFunctionEN.UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(); //修改日期
objvPrjFunctionEN.UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(); //修改者
objvPrjFunctionEN.Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFunctionEN);
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
List<clsvPrjFunctionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjFunctionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFunctionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjFunctionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjFunctionEN> arrObjLst = new List<clsvPrjFunctionEN>(); 
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
	clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN();
try
{
objvPrjFunctionEN.FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(); //函数ID
objvPrjFunctionEN.FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(); //函数名
objvPrjFunctionEN.PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(); //工程Id
objvPrjFunctionEN.ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvPrjFunctionEN.DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjFunctionEN.DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称
objvPrjFunctionEN.CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(); //CS类型
objvPrjFunctionEN.FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objvPrjFunctionEN.FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名
objvPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objvPrjFunctionEN.FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(); //函数代码
objvPrjFunctionEN.UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(); //用户Id
objvPrjFunctionEN.UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(); //修改日期
objvPrjFunctionEN.UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(); //修改者
objvPrjFunctionEN.Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFunctionEN);
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
public static List<clsvPrjFunctionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjFunctionEN> arrObjLst = new List<clsvPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN();
try
{
objvPrjFunctionEN.FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(); //函数ID
objvPrjFunctionEN.FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(); //函数名
objvPrjFunctionEN.PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(); //工程Id
objvPrjFunctionEN.ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvPrjFunctionEN.DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjFunctionEN.DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称
objvPrjFunctionEN.CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(); //CS类型
objvPrjFunctionEN.FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objvPrjFunctionEN.FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名
objvPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objvPrjFunctionEN.FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(); //函数代码
objvPrjFunctionEN.UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(); //用户Id
objvPrjFunctionEN.UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(); //修改日期
objvPrjFunctionEN.UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(); //修改者
objvPrjFunctionEN.Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjFunctionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjFunctionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjFunctionEN> arrObjLst = new List<clsvPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN();
try
{
objvPrjFunctionEN.FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(); //函数ID
objvPrjFunctionEN.FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(); //函数名
objvPrjFunctionEN.PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(); //工程Id
objvPrjFunctionEN.ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvPrjFunctionEN.DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjFunctionEN.DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称
objvPrjFunctionEN.CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(); //CS类型
objvPrjFunctionEN.FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objvPrjFunctionEN.FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名
objvPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objvPrjFunctionEN.FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(); //函数代码
objvPrjFunctionEN.UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(); //用户Id
objvPrjFunctionEN.UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(); //修改日期
objvPrjFunctionEN.UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(); //修改者
objvPrjFunctionEN.Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFunctionEN);
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
public static List<clsvPrjFunctionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjFunctionEN> arrObjLst = new List<clsvPrjFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN();
try
{
objvPrjFunctionEN.FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(); //函数ID
objvPrjFunctionEN.FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(); //函数名
objvPrjFunctionEN.PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(); //工程Id
objvPrjFunctionEN.ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvPrjFunctionEN.DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjFunctionEN.DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称
objvPrjFunctionEN.CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(); //CS类型
objvPrjFunctionEN.FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objvPrjFunctionEN.FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名
objvPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objvPrjFunctionEN.FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(); //函数代码
objvPrjFunctionEN.UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(); //用户Id
objvPrjFunctionEN.UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(); //修改日期
objvPrjFunctionEN.UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(); //修改者
objvPrjFunctionEN.Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFunctionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjFunctionEN> arrObjLst = new List<clsvPrjFunctionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN();
try
{
objvPrjFunctionEN.FuncId = objRow[convPrjFunction.FuncId].ToString().Trim(); //函数ID
objvPrjFunctionEN.FuncName = objRow[convPrjFunction.FuncName].ToString().Trim(); //函数名
objvPrjFunctionEN.PrjId = objRow[convPrjFunction.PrjId].ToString().Trim(); //工程Id
objvPrjFunctionEN.ReturnTypeId = objRow[convPrjFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objvPrjFunctionEN.DataTypeName = objRow[convPrjFunction.DataTypeName] == DBNull.Value ? null : objRow[convPrjFunction.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjFunctionEN.DataCnName = objRow[convPrjFunction.DataCnName] == DBNull.Value ? null : objRow[convPrjFunction.DataCnName].ToString().Trim(); //数据类型中文名称
objvPrjFunctionEN.CsType = objRow[convPrjFunction.CsType] == DBNull.Value ? null : objRow[convPrjFunction.CsType].ToString().Trim(); //CS类型
objvPrjFunctionEN.FuncTypeId = objRow[convPrjFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objvPrjFunctionEN.FuncTypeName = objRow[convPrjFunction.FuncTypeName] == DBNull.Value ? null : objRow[convPrjFunction.FuncTypeName].ToString().Trim(); //函数类型名
objvPrjFunctionEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convPrjFunction.IsTemplate].ToString().Trim()); //是否模板
objvPrjFunctionEN.FuncCode = objRow[convPrjFunction.FuncCode] == DBNull.Value ? null : objRow[convPrjFunction.FuncCode].ToString().Trim(); //函数代码
objvPrjFunctionEN.UserId = objRow[convPrjFunction.UserId] == DBNull.Value ? null : objRow[convPrjFunction.UserId].ToString().Trim(); //用户Id
objvPrjFunctionEN.UpdDate = objRow[convPrjFunction.UpdDate] == DBNull.Value ? null : objRow[convPrjFunction.UpdDate].ToString().Trim(); //修改日期
objvPrjFunctionEN.UpdUser = objRow[convPrjFunction.UpdUser] == DBNull.Value ? null : objRow[convPrjFunction.UpdUser].ToString().Trim(); //修改者
objvPrjFunctionEN.Memo = objRow[convPrjFunction.Memo] == DBNull.Value ? null : objRow[convPrjFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFunctionEN.FuncId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFunctionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjFunctionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjFunction(ref clsvPrjFunctionEN objvPrjFunctionEN)
{
bool bolResult = vPrjFunctionDA.GetvPrjFunction(ref objvPrjFunctionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjFunctionEN GetObjByFuncId(string strFuncId)
{
if (strFuncId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPrjFunctionEN objvPrjFunctionEN = vPrjFunctionDA.GetObjByFuncId(strFuncId);
return objvPrjFunctionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjFunctionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjFunctionEN objvPrjFunctionEN = vPrjFunctionDA.GetFirstObj(strWhereCond);
 return objvPrjFunctionEN;
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
public static clsvPrjFunctionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjFunctionEN objvPrjFunctionEN = vPrjFunctionDA.GetObjByDataRow(objRow);
 return objvPrjFunctionEN;
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
public static clsvPrjFunctionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjFunctionEN objvPrjFunctionEN = vPrjFunctionDA.GetObjByDataRow(objRow);
 return objvPrjFunctionEN;
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
 /// <param name = "strFuncId">所给的关键字</param>
 /// <param name = "lstvPrjFunctionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjFunctionEN GetObjByFuncIdFromList(string strFuncId, List<clsvPrjFunctionEN> lstvPrjFunctionObjLst)
{
foreach (clsvPrjFunctionEN objvPrjFunctionEN in lstvPrjFunctionObjLst)
{
if (objvPrjFunctionEN.FuncId == strFuncId)
{
return objvPrjFunctionEN;
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
 string strFuncId;
 try
 {
 strFuncId = new clsvPrjFunctionDA().GetFirstID(strWhereCond);
 return strFuncId;
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
 arrList = vPrjFunctionDA.GetID(strWhereCond);
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
bool bolIsExist = vPrjFunctionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncId)
{
if (string.IsNullOrEmpty(strFuncId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPrjFunctionDA.IsExist(strFuncId);
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
 bolIsExist = clsvPrjFunctionDA.IsExistTable();
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
 bolIsExist = vPrjFunctionDA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjFunctionENS">源对象</param>
 /// <param name = "objvPrjFunctionENT">目标对象</param>
 public static void CopyTo(clsvPrjFunctionEN objvPrjFunctionENS, clsvPrjFunctionEN objvPrjFunctionENT)
{
try
{
objvPrjFunctionENT.FuncId = objvPrjFunctionENS.FuncId; //函数ID
objvPrjFunctionENT.FuncName = objvPrjFunctionENS.FuncName; //函数名
objvPrjFunctionENT.PrjId = objvPrjFunctionENS.PrjId; //工程Id
objvPrjFunctionENT.ReturnTypeId = objvPrjFunctionENS.ReturnTypeId; //返回类型ID
objvPrjFunctionENT.DataTypeName = objvPrjFunctionENS.DataTypeName; //数据类型名称
objvPrjFunctionENT.DataCnName = objvPrjFunctionENS.DataCnName; //数据类型中文名称
objvPrjFunctionENT.CsType = objvPrjFunctionENS.CsType; //CS类型
objvPrjFunctionENT.FuncTypeId = objvPrjFunctionENS.FuncTypeId; //函数类型Id
objvPrjFunctionENT.FuncTypeName = objvPrjFunctionENS.FuncTypeName; //函数类型名
objvPrjFunctionENT.IsTemplate = objvPrjFunctionENS.IsTemplate; //是否模板
objvPrjFunctionENT.FuncCode = objvPrjFunctionENS.FuncCode; //函数代码
objvPrjFunctionENT.UserId = objvPrjFunctionENS.UserId; //用户Id
objvPrjFunctionENT.UpdDate = objvPrjFunctionENS.UpdDate; //修改日期
objvPrjFunctionENT.UpdUser = objvPrjFunctionENS.UpdUser; //修改者
objvPrjFunctionENT.Memo = objvPrjFunctionENS.Memo; //说明
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
 /// <param name = "objvPrjFunctionEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjFunctionEN objvPrjFunctionEN)
{
try
{
objvPrjFunctionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjFunctionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjFunction.FuncId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFunctionEN.FuncId = objvPrjFunctionEN.FuncId; //函数ID
}
if (arrFldSet.Contains(convPrjFunction.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFunctionEN.FuncName = objvPrjFunctionEN.FuncName; //函数名
}
if (arrFldSet.Contains(convPrjFunction.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFunctionEN.PrjId = objvPrjFunctionEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convPrjFunction.ReturnTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFunctionEN.ReturnTypeId = objvPrjFunctionEN.ReturnTypeId; //返回类型ID
}
if (arrFldSet.Contains(convPrjFunction.DataTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFunctionEN.DataTypeName = objvPrjFunctionEN.DataTypeName == "[null]" ? null :  objvPrjFunctionEN.DataTypeName; //数据类型名称
}
if (arrFldSet.Contains(convPrjFunction.DataCnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFunctionEN.DataCnName = objvPrjFunctionEN.DataCnName == "[null]" ? null :  objvPrjFunctionEN.DataCnName; //数据类型中文名称
}
if (arrFldSet.Contains(convPrjFunction.CsType, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFunctionEN.CsType = objvPrjFunctionEN.CsType == "[null]" ? null :  objvPrjFunctionEN.CsType; //CS类型
}
if (arrFldSet.Contains(convPrjFunction.FuncTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFunctionEN.FuncTypeId = objvPrjFunctionEN.FuncTypeId; //函数类型Id
}
if (arrFldSet.Contains(convPrjFunction.FuncTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFunctionEN.FuncTypeName = objvPrjFunctionEN.FuncTypeName == "[null]" ? null :  objvPrjFunctionEN.FuncTypeName; //函数类型名
}
if (arrFldSet.Contains(convPrjFunction.IsTemplate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFunctionEN.IsTemplate = objvPrjFunctionEN.IsTemplate; //是否模板
}
if (arrFldSet.Contains(convPrjFunction.FuncCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFunctionEN.FuncCode = objvPrjFunctionEN.FuncCode == "[null]" ? null :  objvPrjFunctionEN.FuncCode; //函数代码
}
if (arrFldSet.Contains(convPrjFunction.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFunctionEN.UserId = objvPrjFunctionEN.UserId == "[null]" ? null :  objvPrjFunctionEN.UserId; //用户Id
}
if (arrFldSet.Contains(convPrjFunction.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFunctionEN.UpdDate = objvPrjFunctionEN.UpdDate == "[null]" ? null :  objvPrjFunctionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPrjFunction.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFunctionEN.UpdUser = objvPrjFunctionEN.UpdUser == "[null]" ? null :  objvPrjFunctionEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convPrjFunction.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFunctionEN.Memo = objvPrjFunctionEN.Memo == "[null]" ? null :  objvPrjFunctionEN.Memo; //说明
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
 /// <param name = "objvPrjFunctionEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjFunctionEN objvPrjFunctionEN)
{
try
{
if (objvPrjFunctionEN.DataTypeName == "[null]") objvPrjFunctionEN.DataTypeName = null; //数据类型名称
if (objvPrjFunctionEN.DataCnName == "[null]") objvPrjFunctionEN.DataCnName = null; //数据类型中文名称
if (objvPrjFunctionEN.CsType == "[null]") objvPrjFunctionEN.CsType = null; //CS类型
if (objvPrjFunctionEN.FuncTypeName == "[null]") objvPrjFunctionEN.FuncTypeName = null; //函数类型名
if (objvPrjFunctionEN.FuncCode == "[null]") objvPrjFunctionEN.FuncCode = null; //函数代码
if (objvPrjFunctionEN.UserId == "[null]") objvPrjFunctionEN.UserId = null; //用户Id
if (objvPrjFunctionEN.UpdDate == "[null]") objvPrjFunctionEN.UpdDate = null; //修改日期
if (objvPrjFunctionEN.UpdUser == "[null]") objvPrjFunctionEN.UpdUser = null; //修改者
if (objvPrjFunctionEN.Memo == "[null]") objvPrjFunctionEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvPrjFunctionEN objvPrjFunctionEN)
{
 vPrjFunctionDA.CheckProperty4Condition(objvPrjFunctionEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_FuncId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convPrjFunction.FuncId); 
List<clsvPrjFunctionEN> arrObjLst = clsvPrjFunctionBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvPrjFunctionEN objvPrjFunctionEN = new clsvPrjFunctionEN()
{
FuncId = "0",
FuncName = "选[v工程函数]..."
};
arrObjLst.Insert(0, objvPrjFunctionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convPrjFunction.FuncId;
objComboBox.DisplayMember = convPrjFunction.FuncName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_FuncId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程函数]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convPrjFunction.FuncId); 
IEnumerable<clsvPrjFunctionEN> arrObjLst = clsvPrjFunctionBL.GetObjLst(strCondition);
objDDL.DataValueField = convPrjFunction.FuncId;
objDDL.DataTextField = convPrjFunction.FuncName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FuncIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v工程函数]...","0");
List<clsvPrjFunctionEN> arrvPrjFunctionObjLst = GetAllvPrjFunctionObjLstCache(); 
objDDL.DataValueField = convPrjFunction.FuncId;
objDDL.DataTextField = convPrjFunction.FuncName;
objDDL.DataSource = arrvPrjFunctionObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataTypeAbbrBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataTypeAbbrBL没有刷新缓存机制(clsDataTypeAbbrBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionTypeBL没有刷新缓存机制(clsFunctionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFunctionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFunctionBL没有刷新缓存机制(clsPrjFunctionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncId");
//if (arrvPrjFunctionObjLstCache == null)
//{
//arrvPrjFunctionObjLstCache = vPrjFunctionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjFunctionEN GetObjByFuncIdCache(string strFuncId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPrjFunctionEN._CurrTabName);
List<clsvPrjFunctionEN> arrvPrjFunctionObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFunctionEN> arrvPrjFunctionObjLst_Sel =
arrvPrjFunctionObjLstCache
.Where(x=> x.FuncId == strFuncId 
);
if (arrvPrjFunctionObjLst_Sel.Count() == 0)
{
   clsvPrjFunctionEN obj = clsvPrjFunctionBL.GetObjByFuncId(strFuncId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPrjFunctionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncNameByFuncIdCache(string strFuncId)
{
if (string.IsNullOrEmpty(strFuncId) == true) return "";
//获取缓存中的对象列表
clsvPrjFunctionEN objvPrjFunction = GetObjByFuncIdCache(strFuncId);
if (objvPrjFunction == null) return "";
return objvPrjFunction.FuncName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncIdCache(string strFuncId)
{
if (string.IsNullOrEmpty(strFuncId) == true) return "";
//获取缓存中的对象列表
clsvPrjFunctionEN objvPrjFunction = GetObjByFuncIdCache(strFuncId);
if (objvPrjFunction == null) return "";
return objvPrjFunction.FuncName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjFunctionEN> GetAllvPrjFunctionObjLstCache()
{
//获取缓存中的对象列表
List<clsvPrjFunctionEN> arrvPrjFunctionObjLstCache = GetObjLstCache(); 
return arrvPrjFunctionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjFunctionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPrjFunctionEN._CurrTabName);
List<clsvPrjFunctionEN> arrvPrjFunctionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPrjFunctionObjLstCache;
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
string strKey = string.Format("{0}", clsvPrjFunctionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvPrjFunctionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjFunctionEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjFunctionEN._RefreshTimeLst[clsvPrjFunctionEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strFuncId)
{
if (strInFldName != convPrjFunction.FuncId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjFunction._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjFunction._AttributeName));
throw new Exception(strMsg);
}
var objvPrjFunction = clsvPrjFunctionBL.GetObjByFuncIdCache(strFuncId);
if (objvPrjFunction == null) return "";
return objvPrjFunction[strOutFldName].ToString();
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
int intRecCount = clsvPrjFunctionDA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjFunctionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjFunctionDA.GetRecCount();
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
int intRecCount = clsvPrjFunctionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjFunctionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjFunctionEN objvPrjFunctionCond)
{
List<clsvPrjFunctionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFunctionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjFunction._AttributeName)
{
if (objvPrjFunctionCond.IsUpdated(strFldName) == false) continue;
if (objvPrjFunctionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFunctionCond[strFldName].ToString());
}
else
{
if (objvPrjFunctionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjFunctionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFunctionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjFunctionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjFunctionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjFunctionCond[strFldName]));
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
 List<string> arrList = clsvPrjFunctionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjFunctionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjFunctionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}