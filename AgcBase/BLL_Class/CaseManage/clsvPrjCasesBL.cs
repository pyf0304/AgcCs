
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjCasesBL
 表名:vPrjCases(00050258)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用例管理(CaseManage)
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
public static class  clsvPrjCasesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjCasesEN GetObj(this K_CaseId_vPrjCases myKey)
{
clsvPrjCasesEN objvPrjCasesEN = clsvPrjCasesBL.vPrjCasesDA.GetObjByCaseId(myKey.Value);
return objvPrjCasesEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetCaseId(this clsvPrjCasesEN objvPrjCasesEN, string strCaseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId, 8, convPrjCases.CaseId);
}
objvPrjCasesEN.CaseId = strCaseId; //CaseId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.CaseId) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.CaseId, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.CaseId] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetCaseName(this clsvPrjCasesEN objvPrjCasesEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName, convPrjCases.CaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName, 20, convPrjCases.CaseName);
}
objvPrjCasesEN.CaseName = strCaseName; //CaseName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.CaseName) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.CaseName, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.CaseName] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetPrjId(this clsvPrjCasesEN objvPrjCasesEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjCases.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjCases.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjCases.PrjId);
}
objvPrjCasesEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.PrjId) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.PrjId, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.PrjId] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetPrjName(this clsvPrjCasesEN objvPrjCasesEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjCases.PrjName);
}
objvPrjCasesEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.PrjName) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.PrjName, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.PrjName] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetCaseContent(this clsvPrjCasesEN objvPrjCasesEN, string strCaseContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseContent, convPrjCases.CaseContent);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseContent, 1000, convPrjCases.CaseContent);
}
objvPrjCasesEN.CaseContent = strCaseContent; //CaseContent
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.CaseContent) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.CaseContent, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.CaseContent] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetCaseTypeId(this clsvPrjCasesEN objvPrjCasesEN, string strCaseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseTypeId, convPrjCases.CaseTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseTypeId, 4, convPrjCases.CaseTypeId);
}
objvPrjCasesEN.CaseTypeId = strCaseTypeId; //CaseTypeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.CaseTypeId) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.CaseTypeId, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.CaseTypeId] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetCaseTypeName(this clsvPrjCasesEN objvPrjCasesEN, string strCaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseTypeName, 30, convPrjCases.CaseTypeName);
}
objvPrjCasesEN.CaseTypeName = strCaseTypeName; //案例类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.CaseTypeName) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.CaseTypeName, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.CaseTypeName] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetImportLevelId(this clsvPrjCasesEN objvPrjCasesEN, string strImportLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImportLevelId, 4, convPrjCases.ImportLevelId);
}
objvPrjCasesEN.ImportLevelId = strImportLevelId; //重要程度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.ImportLevelId) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.ImportLevelId, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.ImportLevelId] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetUserId(this clsvPrjCasesEN objvPrjCasesEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convPrjCases.UserId);
}
objvPrjCasesEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.UserId) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.UserId, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.UserId] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetUpdDate(this clsvPrjCasesEN objvPrjCasesEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjCases.UpdDate);
}
objvPrjCasesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.UpdDate) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.UpdDate, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.UpdDate] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetImportLevelName(this clsvPrjCasesEN objvPrjCasesEN, string strImportLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImportLevelName, 20, convPrjCases.ImportLevelName);
}
objvPrjCasesEN.ImportLevelName = strImportLevelName; //重要程度名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.ImportLevelName) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.ImportLevelName, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.ImportLevelName] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjCasesEN SetMemo(this clsvPrjCasesEN objvPrjCasesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjCases.Memo);
}
objvPrjCasesEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjCasesEN.dicFldComparisonOp.ContainsKey(convPrjCases.Memo) == false)
{
objvPrjCasesEN.dicFldComparisonOp.Add(convPrjCases.Memo, strComparisonOp);
}
else
{
objvPrjCasesEN.dicFldComparisonOp[convPrjCases.Memo] = strComparisonOp;
}
}
return objvPrjCasesEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjCasesENS">源对象</param>
 /// <param name = "objvPrjCasesENT">目标对象</param>
 public static void CopyTo(this clsvPrjCasesEN objvPrjCasesENS, clsvPrjCasesEN objvPrjCasesENT)
{
try
{
objvPrjCasesENT.CaseId = objvPrjCasesENS.CaseId; //CaseId
objvPrjCasesENT.CaseName = objvPrjCasesENS.CaseName; //CaseName
objvPrjCasesENT.PrjId = objvPrjCasesENS.PrjId; //工程Id
objvPrjCasesENT.PrjName = objvPrjCasesENS.PrjName; //工程名称
objvPrjCasesENT.CaseContent = objvPrjCasesENS.CaseContent; //CaseContent
objvPrjCasesENT.CaseTypeId = objvPrjCasesENS.CaseTypeId; //CaseTypeId
objvPrjCasesENT.CaseTypeName = objvPrjCasesENS.CaseTypeName; //案例类型名
objvPrjCasesENT.ImportLevelId = objvPrjCasesENS.ImportLevelId; //重要程度Id
objvPrjCasesENT.UserId = objvPrjCasesENS.UserId; //用户Id
objvPrjCasesENT.UpdDate = objvPrjCasesENS.UpdDate; //修改日期
objvPrjCasesENT.ImportLevelName = objvPrjCasesENS.ImportLevelName; //重要程度名称
objvPrjCasesENT.Memo = objvPrjCasesENS.Memo; //说明
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
 /// <param name = "objvPrjCasesENS">源对象</param>
 /// <returns>目标对象=>clsvPrjCasesEN:objvPrjCasesENT</returns>
 public static clsvPrjCasesEN CopyTo(this clsvPrjCasesEN objvPrjCasesENS)
{
try
{
 clsvPrjCasesEN objvPrjCasesENT = new clsvPrjCasesEN()
{
CaseId = objvPrjCasesENS.CaseId, //CaseId
CaseName = objvPrjCasesENS.CaseName, //CaseName
PrjId = objvPrjCasesENS.PrjId, //工程Id
PrjName = objvPrjCasesENS.PrjName, //工程名称
CaseContent = objvPrjCasesENS.CaseContent, //CaseContent
CaseTypeId = objvPrjCasesENS.CaseTypeId, //CaseTypeId
CaseTypeName = objvPrjCasesENS.CaseTypeName, //案例类型名
ImportLevelId = objvPrjCasesENS.ImportLevelId, //重要程度Id
UserId = objvPrjCasesENS.UserId, //用户Id
UpdDate = objvPrjCasesENS.UpdDate, //修改日期
ImportLevelName = objvPrjCasesENS.ImportLevelName, //重要程度名称
Memo = objvPrjCasesENS.Memo, //说明
};
 return objvPrjCasesENT;
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
public static void CheckProperty4Condition(this clsvPrjCasesEN objvPrjCasesEN)
{
 clsvPrjCasesBL.vPrjCasesDA.CheckProperty4Condition(objvPrjCasesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjCasesEN objvPrjCasesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjCasesCond.IsUpdated(convPrjCases.CaseId) == true)
{
string strComparisonOpCaseId = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.CaseId, objvPrjCasesCond.CaseId, strComparisonOpCaseId);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.CaseName) == true)
{
string strComparisonOpCaseName = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.CaseName, objvPrjCasesCond.CaseName, strComparisonOpCaseName);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.PrjId, objvPrjCasesCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.PrjName) == true)
{
string strComparisonOpPrjName = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.PrjName, objvPrjCasesCond.PrjName, strComparisonOpPrjName);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.CaseContent) == true)
{
string strComparisonOpCaseContent = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.CaseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.CaseContent, objvPrjCasesCond.CaseContent, strComparisonOpCaseContent);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.CaseTypeId) == true)
{
string strComparisonOpCaseTypeId = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.CaseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.CaseTypeId, objvPrjCasesCond.CaseTypeId, strComparisonOpCaseTypeId);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.CaseTypeName) == true)
{
string strComparisonOpCaseTypeName = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.CaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.CaseTypeName, objvPrjCasesCond.CaseTypeName, strComparisonOpCaseTypeName);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.ImportLevelId) == true)
{
string strComparisonOpImportLevelId = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.ImportLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.ImportLevelId, objvPrjCasesCond.ImportLevelId, strComparisonOpImportLevelId);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.UserId) == true)
{
string strComparisonOpUserId = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.UserId, objvPrjCasesCond.UserId, strComparisonOpUserId);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.UpdDate, objvPrjCasesCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.ImportLevelName) == true)
{
string strComparisonOpImportLevelName = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.ImportLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.ImportLevelName, objvPrjCasesCond.ImportLevelName, strComparisonOpImportLevelName);
}
if (objvPrjCasesCond.IsUpdated(convPrjCases.Memo) == true)
{
string strComparisonOpMemo = objvPrjCasesCond.dicFldComparisonOp[convPrjCases.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjCases.Memo, objvPrjCasesCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjCases
{
public virtual bool UpdRelaTabDate(string strCaseId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程用例(vPrjCases)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjCasesBL
{
public static RelatedActions_vPrjCases relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjCasesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjCasesDA vPrjCasesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjCasesDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjCasesBL()
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
if (string.IsNullOrEmpty(clsvPrjCasesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjCasesEN._ConnectString);
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
public static DataTable GetDataTable_vPrjCases(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjCasesDA.GetDataTable_vPrjCases(strWhereCond);
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
objDT = vPrjCasesDA.GetDataTable(strWhereCond);
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
objDT = vPrjCasesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjCasesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjCasesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjCasesDA.GetDataTable_Top(objTopPara);
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
objDT = vPrjCasesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjCasesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjCasesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCaseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPrjCasesEN> GetObjLstByCaseIdLst(List<string> arrCaseIdLst)
{
List<clsvPrjCasesEN> arrObjLst = new List<clsvPrjCasesEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCaseIdLst, true);
 string strWhereCond = string.Format("CaseId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN();
try
{
objvPrjCasesEN.CaseId = objRow[convPrjCases.CaseId].ToString().Trim(); //CaseId
objvPrjCasesEN.CaseName = objRow[convPrjCases.CaseName].ToString().Trim(); //CaseName
objvPrjCasesEN.PrjId = objRow[convPrjCases.PrjId].ToString().Trim(); //工程Id
objvPrjCasesEN.PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(); //工程名称
objvPrjCasesEN.CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(); //CaseContent
objvPrjCasesEN.CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objvPrjCasesEN.CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名
objvPrjCasesEN.ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objvPrjCasesEN.UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(); //用户Id
objvPrjCasesEN.UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(); //修改日期
objvPrjCasesEN.ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称
objvPrjCasesEN.Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjCasesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCaseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjCasesEN> GetObjLstByCaseIdLstCache(List<string> arrCaseIdLst)
{
string strKey = string.Format("{0}", clsvPrjCasesEN._CurrTabName);
List<clsvPrjCasesEN> arrvPrjCasesObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjCasesEN> arrvPrjCasesObjLst_Sel =
arrvPrjCasesObjLstCache
.Where(x => arrCaseIdLst.Contains(x.CaseId));
return arrvPrjCasesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjCasesEN> GetObjLst(string strWhereCond)
{
List<clsvPrjCasesEN> arrObjLst = new List<clsvPrjCasesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN();
try
{
objvPrjCasesEN.CaseId = objRow[convPrjCases.CaseId].ToString().Trim(); //CaseId
objvPrjCasesEN.CaseName = objRow[convPrjCases.CaseName].ToString().Trim(); //CaseName
objvPrjCasesEN.PrjId = objRow[convPrjCases.PrjId].ToString().Trim(); //工程Id
objvPrjCasesEN.PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(); //工程名称
objvPrjCasesEN.CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(); //CaseContent
objvPrjCasesEN.CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objvPrjCasesEN.CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名
objvPrjCasesEN.ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objvPrjCasesEN.UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(); //用户Id
objvPrjCasesEN.UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(); //修改日期
objvPrjCasesEN.ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称
objvPrjCasesEN.Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjCasesEN);
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
public static List<clsvPrjCasesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjCasesEN> arrObjLst = new List<clsvPrjCasesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN();
try
{
objvPrjCasesEN.CaseId = objRow[convPrjCases.CaseId].ToString().Trim(); //CaseId
objvPrjCasesEN.CaseName = objRow[convPrjCases.CaseName].ToString().Trim(); //CaseName
objvPrjCasesEN.PrjId = objRow[convPrjCases.PrjId].ToString().Trim(); //工程Id
objvPrjCasesEN.PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(); //工程名称
objvPrjCasesEN.CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(); //CaseContent
objvPrjCasesEN.CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objvPrjCasesEN.CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名
objvPrjCasesEN.ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objvPrjCasesEN.UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(); //用户Id
objvPrjCasesEN.UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(); //修改日期
objvPrjCasesEN.ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称
objvPrjCasesEN.Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjCasesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjCasesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjCasesEN> GetSubObjLstCache(clsvPrjCasesEN objvPrjCasesCond)
{
List<clsvPrjCasesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjCasesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjCases._AttributeName)
{
if (objvPrjCasesCond.IsUpdated(strFldName) == false) continue;
if (objvPrjCasesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjCasesCond[strFldName].ToString());
}
else
{
if (objvPrjCasesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjCasesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjCasesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjCasesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjCasesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjCasesCond[strFldName]));
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
public static List<clsvPrjCasesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjCasesEN> arrObjLst = new List<clsvPrjCasesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN();
try
{
objvPrjCasesEN.CaseId = objRow[convPrjCases.CaseId].ToString().Trim(); //CaseId
objvPrjCasesEN.CaseName = objRow[convPrjCases.CaseName].ToString().Trim(); //CaseName
objvPrjCasesEN.PrjId = objRow[convPrjCases.PrjId].ToString().Trim(); //工程Id
objvPrjCasesEN.PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(); //工程名称
objvPrjCasesEN.CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(); //CaseContent
objvPrjCasesEN.CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objvPrjCasesEN.CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名
objvPrjCasesEN.ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objvPrjCasesEN.UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(); //用户Id
objvPrjCasesEN.UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(); //修改日期
objvPrjCasesEN.ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称
objvPrjCasesEN.Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjCasesEN);
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
public static List<clsvPrjCasesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjCasesEN> arrObjLst = new List<clsvPrjCasesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN();
try
{
objvPrjCasesEN.CaseId = objRow[convPrjCases.CaseId].ToString().Trim(); //CaseId
objvPrjCasesEN.CaseName = objRow[convPrjCases.CaseName].ToString().Trim(); //CaseName
objvPrjCasesEN.PrjId = objRow[convPrjCases.PrjId].ToString().Trim(); //工程Id
objvPrjCasesEN.PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(); //工程名称
objvPrjCasesEN.CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(); //CaseContent
objvPrjCasesEN.CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objvPrjCasesEN.CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名
objvPrjCasesEN.ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objvPrjCasesEN.UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(); //用户Id
objvPrjCasesEN.UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(); //修改日期
objvPrjCasesEN.ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称
objvPrjCasesEN.Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjCasesEN);
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
List<clsvPrjCasesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjCasesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjCasesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjCasesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjCasesEN> arrObjLst = new List<clsvPrjCasesEN>(); 
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
	clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN();
try
{
objvPrjCasesEN.CaseId = objRow[convPrjCases.CaseId].ToString().Trim(); //CaseId
objvPrjCasesEN.CaseName = objRow[convPrjCases.CaseName].ToString().Trim(); //CaseName
objvPrjCasesEN.PrjId = objRow[convPrjCases.PrjId].ToString().Trim(); //工程Id
objvPrjCasesEN.PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(); //工程名称
objvPrjCasesEN.CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(); //CaseContent
objvPrjCasesEN.CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objvPrjCasesEN.CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名
objvPrjCasesEN.ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objvPrjCasesEN.UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(); //用户Id
objvPrjCasesEN.UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(); //修改日期
objvPrjCasesEN.ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称
objvPrjCasesEN.Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjCasesEN);
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
public static List<clsvPrjCasesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjCasesEN> arrObjLst = new List<clsvPrjCasesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN();
try
{
objvPrjCasesEN.CaseId = objRow[convPrjCases.CaseId].ToString().Trim(); //CaseId
objvPrjCasesEN.CaseName = objRow[convPrjCases.CaseName].ToString().Trim(); //CaseName
objvPrjCasesEN.PrjId = objRow[convPrjCases.PrjId].ToString().Trim(); //工程Id
objvPrjCasesEN.PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(); //工程名称
objvPrjCasesEN.CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(); //CaseContent
objvPrjCasesEN.CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objvPrjCasesEN.CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名
objvPrjCasesEN.ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objvPrjCasesEN.UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(); //用户Id
objvPrjCasesEN.UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(); //修改日期
objvPrjCasesEN.ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称
objvPrjCasesEN.Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjCasesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjCasesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjCasesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjCasesEN> arrObjLst = new List<clsvPrjCasesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN();
try
{
objvPrjCasesEN.CaseId = objRow[convPrjCases.CaseId].ToString().Trim(); //CaseId
objvPrjCasesEN.CaseName = objRow[convPrjCases.CaseName].ToString().Trim(); //CaseName
objvPrjCasesEN.PrjId = objRow[convPrjCases.PrjId].ToString().Trim(); //工程Id
objvPrjCasesEN.PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(); //工程名称
objvPrjCasesEN.CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(); //CaseContent
objvPrjCasesEN.CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objvPrjCasesEN.CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名
objvPrjCasesEN.ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objvPrjCasesEN.UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(); //用户Id
objvPrjCasesEN.UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(); //修改日期
objvPrjCasesEN.ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称
objvPrjCasesEN.Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjCasesEN);
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
public static List<clsvPrjCasesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjCasesEN> arrObjLst = new List<clsvPrjCasesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN();
try
{
objvPrjCasesEN.CaseId = objRow[convPrjCases.CaseId].ToString().Trim(); //CaseId
objvPrjCasesEN.CaseName = objRow[convPrjCases.CaseName].ToString().Trim(); //CaseName
objvPrjCasesEN.PrjId = objRow[convPrjCases.PrjId].ToString().Trim(); //工程Id
objvPrjCasesEN.PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(); //工程名称
objvPrjCasesEN.CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(); //CaseContent
objvPrjCasesEN.CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objvPrjCasesEN.CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名
objvPrjCasesEN.ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objvPrjCasesEN.UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(); //用户Id
objvPrjCasesEN.UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(); //修改日期
objvPrjCasesEN.ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称
objvPrjCasesEN.Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjCasesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjCasesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjCasesEN> arrObjLst = new List<clsvPrjCasesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN();
try
{
objvPrjCasesEN.CaseId = objRow[convPrjCases.CaseId].ToString().Trim(); //CaseId
objvPrjCasesEN.CaseName = objRow[convPrjCases.CaseName].ToString().Trim(); //CaseName
objvPrjCasesEN.PrjId = objRow[convPrjCases.PrjId].ToString().Trim(); //工程Id
objvPrjCasesEN.PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(); //工程名称
objvPrjCasesEN.CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(); //CaseContent
objvPrjCasesEN.CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objvPrjCasesEN.CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名
objvPrjCasesEN.ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objvPrjCasesEN.UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(); //用户Id
objvPrjCasesEN.UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(); //修改日期
objvPrjCasesEN.ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称
objvPrjCasesEN.Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjCasesEN.CaseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjCasesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjCasesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjCases(ref clsvPrjCasesEN objvPrjCasesEN)
{
bool bolResult = vPrjCasesDA.GetvPrjCases(ref objvPrjCasesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCaseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjCasesEN GetObjByCaseId(string strCaseId)
{
if (strCaseId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCaseId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCaseId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCaseId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPrjCasesEN objvPrjCasesEN = vPrjCasesDA.GetObjByCaseId(strCaseId);
return objvPrjCasesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjCasesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjCasesEN objvPrjCasesEN = vPrjCasesDA.GetFirstObj(strWhereCond);
 return objvPrjCasesEN;
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
public static clsvPrjCasesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjCasesEN objvPrjCasesEN = vPrjCasesDA.GetObjByDataRow(objRow);
 return objvPrjCasesEN;
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
public static clsvPrjCasesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjCasesEN objvPrjCasesEN = vPrjCasesDA.GetObjByDataRow(objRow);
 return objvPrjCasesEN;
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
 /// <param name = "strCaseId">所给的关键字</param>
 /// <param name = "lstvPrjCasesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjCasesEN GetObjByCaseIdFromList(string strCaseId, List<clsvPrjCasesEN> lstvPrjCasesObjLst)
{
foreach (clsvPrjCasesEN objvPrjCasesEN in lstvPrjCasesObjLst)
{
if (objvPrjCasesEN.CaseId == strCaseId)
{
return objvPrjCasesEN;
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
 string strCaseId;
 try
 {
 strCaseId = new clsvPrjCasesDA().GetFirstID(strWhereCond);
 return strCaseId;
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
 arrList = vPrjCasesDA.GetID(strWhereCond);
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
bool bolIsExist = vPrjCasesDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCaseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCaseId)
{
if (string.IsNullOrEmpty(strCaseId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCaseId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPrjCasesDA.IsExist(strCaseId);
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
 bolIsExist = clsvPrjCasesDA.IsExistTable();
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
 bolIsExist = vPrjCasesDA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjCasesENS">源对象</param>
 /// <param name = "objvPrjCasesENT">目标对象</param>
 public static void CopyTo(clsvPrjCasesEN objvPrjCasesENS, clsvPrjCasesEN objvPrjCasesENT)
{
try
{
objvPrjCasesENT.CaseId = objvPrjCasesENS.CaseId; //CaseId
objvPrjCasesENT.CaseName = objvPrjCasesENS.CaseName; //CaseName
objvPrjCasesENT.PrjId = objvPrjCasesENS.PrjId; //工程Id
objvPrjCasesENT.PrjName = objvPrjCasesENS.PrjName; //工程名称
objvPrjCasesENT.CaseContent = objvPrjCasesENS.CaseContent; //CaseContent
objvPrjCasesENT.CaseTypeId = objvPrjCasesENS.CaseTypeId; //CaseTypeId
objvPrjCasesENT.CaseTypeName = objvPrjCasesENS.CaseTypeName; //案例类型名
objvPrjCasesENT.ImportLevelId = objvPrjCasesENS.ImportLevelId; //重要程度Id
objvPrjCasesENT.UserId = objvPrjCasesENS.UserId; //用户Id
objvPrjCasesENT.UpdDate = objvPrjCasesENS.UpdDate; //修改日期
objvPrjCasesENT.ImportLevelName = objvPrjCasesENS.ImportLevelName; //重要程度名称
objvPrjCasesENT.Memo = objvPrjCasesENS.Memo; //说明
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
 /// <param name = "objvPrjCasesEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjCasesEN objvPrjCasesEN)
{
try
{
objvPrjCasesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjCasesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjCases.CaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjCasesEN.CaseId = objvPrjCasesEN.CaseId; //CaseId
}
if (arrFldSet.Contains(convPrjCases.CaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjCasesEN.CaseName = objvPrjCasesEN.CaseName; //CaseName
}
if (arrFldSet.Contains(convPrjCases.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjCasesEN.PrjId = objvPrjCasesEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convPrjCases.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjCasesEN.PrjName = objvPrjCasesEN.PrjName == "[null]" ? null :  objvPrjCasesEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convPrjCases.CaseContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjCasesEN.CaseContent = objvPrjCasesEN.CaseContent; //CaseContent
}
if (arrFldSet.Contains(convPrjCases.CaseTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjCasesEN.CaseTypeId = objvPrjCasesEN.CaseTypeId; //CaseTypeId
}
if (arrFldSet.Contains(convPrjCases.CaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjCasesEN.CaseTypeName = objvPrjCasesEN.CaseTypeName == "[null]" ? null :  objvPrjCasesEN.CaseTypeName; //案例类型名
}
if (arrFldSet.Contains(convPrjCases.ImportLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjCasesEN.ImportLevelId = objvPrjCasesEN.ImportLevelId == "[null]" ? null :  objvPrjCasesEN.ImportLevelId; //重要程度Id
}
if (arrFldSet.Contains(convPrjCases.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjCasesEN.UserId = objvPrjCasesEN.UserId == "[null]" ? null :  objvPrjCasesEN.UserId; //用户Id
}
if (arrFldSet.Contains(convPrjCases.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjCasesEN.UpdDate = objvPrjCasesEN.UpdDate == "[null]" ? null :  objvPrjCasesEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPrjCases.ImportLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjCasesEN.ImportLevelName = objvPrjCasesEN.ImportLevelName == "[null]" ? null :  objvPrjCasesEN.ImportLevelName; //重要程度名称
}
if (arrFldSet.Contains(convPrjCases.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjCasesEN.Memo = objvPrjCasesEN.Memo == "[null]" ? null :  objvPrjCasesEN.Memo; //说明
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
 /// <param name = "objvPrjCasesEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjCasesEN objvPrjCasesEN)
{
try
{
if (objvPrjCasesEN.PrjName == "[null]") objvPrjCasesEN.PrjName = null; //工程名称
if (objvPrjCasesEN.CaseTypeName == "[null]") objvPrjCasesEN.CaseTypeName = null; //案例类型名
if (objvPrjCasesEN.ImportLevelId == "[null]") objvPrjCasesEN.ImportLevelId = null; //重要程度Id
if (objvPrjCasesEN.UserId == "[null]") objvPrjCasesEN.UserId = null; //用户Id
if (objvPrjCasesEN.UpdDate == "[null]") objvPrjCasesEN.UpdDate = null; //修改日期
if (objvPrjCasesEN.ImportLevelName == "[null]") objvPrjCasesEN.ImportLevelName = null; //重要程度名称
if (objvPrjCasesEN.Memo == "[null]") objvPrjCasesEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvPrjCasesEN objvPrjCasesEN)
{
 vPrjCasesDA.CheckProperty4Condition(objvPrjCasesEN);
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
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseTypeBL没有刷新缓存机制(clsCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsImportLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsImportLevelBL没有刷新缓存机制(clsImportLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjCasesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjCasesBL没有刷新缓存机制(clsPrjCasesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CaseId");
//if (arrvPrjCasesObjLstCache == null)
//{
//arrvPrjCasesObjLstCache = vPrjCasesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCaseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjCasesEN GetObjByCaseIdCache(string strCaseId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPrjCasesEN._CurrTabName);
List<clsvPrjCasesEN> arrvPrjCasesObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjCasesEN> arrvPrjCasesObjLst_Sel =
arrvPrjCasesObjLstCache
.Where(x=> x.CaseId == strCaseId 
);
if (arrvPrjCasesObjLst_Sel.Count() == 0)
{
   clsvPrjCasesEN obj = clsvPrjCasesBL.GetObjByCaseId(strCaseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPrjCasesObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjCasesEN> GetAllvPrjCasesObjLstCache()
{
//获取缓存中的对象列表
List<clsvPrjCasesEN> arrvPrjCasesObjLstCache = GetObjLstCache(); 
return arrvPrjCasesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjCasesEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPrjCasesEN._CurrTabName);
List<clsvPrjCasesEN> arrvPrjCasesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPrjCasesObjLstCache;
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
string strKey = string.Format("{0}", clsvPrjCasesEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvPrjCasesEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjCasesEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjCasesEN._RefreshTimeLst[clsvPrjCasesEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strCaseId)
{
if (strInFldName != convPrjCases.CaseId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjCases._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjCases._AttributeName));
throw new Exception(strMsg);
}
var objvPrjCases = clsvPrjCasesBL.GetObjByCaseIdCache(strCaseId);
if (objvPrjCases == null) return "";
return objvPrjCases[strOutFldName].ToString();
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
int intRecCount = clsvPrjCasesDA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjCasesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjCasesDA.GetRecCount();
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
int intRecCount = clsvPrjCasesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjCasesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjCasesEN objvPrjCasesCond)
{
List<clsvPrjCasesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjCasesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjCases._AttributeName)
{
if (objvPrjCasesCond.IsUpdated(strFldName) == false) continue;
if (objvPrjCasesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjCasesCond[strFldName].ToString());
}
else
{
if (objvPrjCasesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjCasesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjCasesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjCasesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjCasesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjCasesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjCasesCond[strFldName]));
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
 List<string> arrList = clsvPrjCasesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjCasesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjCasesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}