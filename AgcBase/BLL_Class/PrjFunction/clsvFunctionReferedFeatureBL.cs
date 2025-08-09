
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionReferedFeatureBL
 表名:vFunctionReferedFeature(00050341)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:35
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvFunctionReferedFeatureBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionReferedFeatureEN GetObj(this K_mId_vFunctionReferedFeature myKey)
{
clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN = clsvFunctionReferedFeatureBL.vFunctionReferedFeatureDA.GetObjBymId(myKey.Value);
return objvFunctionReferedFeatureEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetmId(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, long lngmId, string strComparisonOp="")
	{
objvFunctionReferedFeatureEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(convFunctionReferedFeature.mId) == false)
{
objvFunctionReferedFeatureEN.dicFldComparisonOp.Add(convFunctionReferedFeature.mId, strComparisonOp);
}
else
{
objvFunctionReferedFeatureEN.dicFldComparisonOp[convFunctionReferedFeature.mId] = strComparisonOp;
}
}
return objvFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFeatureId(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFunctionReferedFeature.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFunctionReferedFeature.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFunctionReferedFeature.FeatureId);
}
objvFunctionReferedFeatureEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(convFunctionReferedFeature.FeatureId) == false)
{
objvFunctionReferedFeatureEN.dicFldComparisonOp.Add(convFunctionReferedFeature.FeatureId, strComparisonOp);
}
else
{
objvFunctionReferedFeatureEN.dicFldComparisonOp[convFunctionReferedFeature.FeatureId] = strComparisonOp;
}
}
return objvFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFeatureName(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convFunctionReferedFeature.FeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFunctionReferedFeature.FeatureName);
}
objvFunctionReferedFeatureEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(convFunctionReferedFeature.FeatureName) == false)
{
objvFunctionReferedFeatureEN.dicFldComparisonOp.Add(convFunctionReferedFeature.FeatureName, strComparisonOp);
}
else
{
objvFunctionReferedFeatureEN.dicFldComparisonOp[convFunctionReferedFeature.FeatureName] = strComparisonOp;
}
}
return objvFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetKeyWords(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strKeyWords, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convFunctionReferedFeature.KeyWords);
}
objvFunctionReferedFeatureEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(convFunctionReferedFeature.KeyWords) == false)
{
objvFunctionReferedFeatureEN.dicFldComparisonOp.Add(convFunctionReferedFeature.KeyWords, strComparisonOp);
}
else
{
objvFunctionReferedFeatureEN.dicFldComparisonOp[convFunctionReferedFeature.KeyWords] = strComparisonOp;
}
}
return objvFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFunctionGroupId(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFunctionGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionGroupId, convFunctionReferedFeature.FunctionGroupId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionGroupId, 4, convFunctionReferedFeature.FunctionGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionGroupId, 4, convFunctionReferedFeature.FunctionGroupId);
}
objvFunctionReferedFeatureEN.FunctionGroupId = strFunctionGroupId; //函数组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(convFunctionReferedFeature.FunctionGroupId) == false)
{
objvFunctionReferedFeatureEN.dicFldComparisonOp.Add(convFunctionReferedFeature.FunctionGroupId, strComparisonOp);
}
else
{
objvFunctionReferedFeatureEN.dicFldComparisonOp[convFunctionReferedFeature.FunctionGroupId] = strComparisonOp;
}
}
return objvFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFunctionGroupName(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFunctionGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionGroupName, convFunctionReferedFeature.FunctionGroupName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionGroupName, 50, convFunctionReferedFeature.FunctionGroupName);
}
objvFunctionReferedFeatureEN.FunctionGroupName = strFunctionGroupName; //函数组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(convFunctionReferedFeature.FunctionGroupName) == false)
{
objvFunctionReferedFeatureEN.dicFldComparisonOp.Add(convFunctionReferedFeature.FunctionGroupName, strComparisonOp);
}
else
{
objvFunctionReferedFeatureEN.dicFldComparisonOp[convFunctionReferedFeature.FunctionGroupName] = strComparisonOp;
}
}
return objvFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFeatureTypeId(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeId, convFunctionReferedFeature.FeatureTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeId, 2, convFunctionReferedFeature.FeatureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureTypeId, 2, convFunctionReferedFeature.FeatureTypeId);
}
objvFunctionReferedFeatureEN.FeatureTypeId = strFeatureTypeId; //功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(convFunctionReferedFeature.FeatureTypeId) == false)
{
objvFunctionReferedFeatureEN.dicFldComparisonOp.Add(convFunctionReferedFeature.FeatureTypeId, strComparisonOp);
}
else
{
objvFunctionReferedFeatureEN.dicFldComparisonOp[convFunctionReferedFeature.FeatureTypeId] = strComparisonOp;
}
}
return objvFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFeatureTypeName(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convFunctionReferedFeature.FeatureTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convFunctionReferedFeature.FeatureTypeName);
}
objvFunctionReferedFeatureEN.FeatureTypeName = strFeatureTypeName; //功能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(convFunctionReferedFeature.FeatureTypeName) == false)
{
objvFunctionReferedFeatureEN.dicFldComparisonOp.Add(convFunctionReferedFeature.FeatureTypeName, strComparisonOp);
}
else
{
objvFunctionReferedFeatureEN.dicFldComparisonOp[convFunctionReferedFeature.FeatureTypeName] = strComparisonOp;
}
}
return objvFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFuncId4GC(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4GC, convFunctionReferedFeature.FuncId4GC);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convFunctionReferedFeature.FuncId4GC);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convFunctionReferedFeature.FuncId4GC);
}
objvFunctionReferedFeatureEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(convFunctionReferedFeature.FuncId4GC) == false)
{
objvFunctionReferedFeatureEN.dicFldComparisonOp.Add(convFunctionReferedFeature.FuncId4GC, strComparisonOp);
}
else
{
objvFunctionReferedFeatureEN.dicFldComparisonOp[convFunctionReferedFeature.FuncId4GC] = strComparisonOp;
}
}
return objvFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFuncName(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, convFunctionReferedFeature.FuncName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName, 100, convFunctionReferedFeature.FuncName);
}
objvFunctionReferedFeatureEN.FuncName = strFuncName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(convFunctionReferedFeature.FuncName) == false)
{
objvFunctionReferedFeatureEN.dicFldComparisonOp.Add(convFunctionReferedFeature.FuncName, strComparisonOp);
}
else
{
objvFunctionReferedFeatureEN.dicFldComparisonOp[convFunctionReferedFeature.FuncName] = strComparisonOp;
}
}
return objvFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFuncId4Invoked(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFuncId4Invoked, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4Invoked, convFunctionReferedFeature.FuncId4Invoked);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4Invoked, 10, convFunctionReferedFeature.FuncId4Invoked);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4Invoked, 10, convFunctionReferedFeature.FuncId4Invoked);
}
objvFunctionReferedFeatureEN.FuncId4Invoked = strFuncId4Invoked; //被调用函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(convFunctionReferedFeature.FuncId4Invoked) == false)
{
objvFunctionReferedFeatureEN.dicFldComparisonOp.Add(convFunctionReferedFeature.FuncId4Invoked, strComparisonOp);
}
else
{
objvFunctionReferedFeatureEN.dicFldComparisonOp[convFunctionReferedFeature.FuncId4Invoked] = strComparisonOp;
}
}
return objvFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetUpdDate(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFunctionReferedFeature.UpdDate);
}
objvFunctionReferedFeatureEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(convFunctionReferedFeature.UpdDate) == false)
{
objvFunctionReferedFeatureEN.dicFldComparisonOp.Add(convFunctionReferedFeature.UpdDate, strComparisonOp);
}
else
{
objvFunctionReferedFeatureEN.dicFldComparisonOp[convFunctionReferedFeature.UpdDate] = strComparisonOp;
}
}
return objvFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetUpdUser(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFunctionReferedFeature.UpdUser);
}
objvFunctionReferedFeatureEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(convFunctionReferedFeature.UpdUser) == false)
{
objvFunctionReferedFeatureEN.dicFldComparisonOp.Add(convFunctionReferedFeature.UpdUser, strComparisonOp);
}
else
{
objvFunctionReferedFeatureEN.dicFldComparisonOp[convFunctionReferedFeature.UpdUser] = strComparisonOp;
}
}
return objvFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetMemo(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunctionReferedFeature.Memo);
}
objvFunctionReferedFeatureEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(convFunctionReferedFeature.Memo) == false)
{
objvFunctionReferedFeatureEN.dicFldComparisonOp.Add(convFunctionReferedFeature.Memo, strComparisonOp);
}
else
{
objvFunctionReferedFeatureEN.dicFldComparisonOp[convFunctionReferedFeature.Memo] = strComparisonOp;
}
}
return objvFunctionReferedFeatureEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFuncName4Invoked(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFuncName4Invoked, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncName4Invoked, 100, convFunctionReferedFeature.FuncName4Invoked);
}
objvFunctionReferedFeatureEN.FuncName4Invoked = strFuncName4Invoked; //FuncName4Invoked
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionReferedFeatureEN.dicFldComparisonOp.ContainsKey(convFunctionReferedFeature.FuncName4Invoked) == false)
{
objvFunctionReferedFeatureEN.dicFldComparisonOp.Add(convFunctionReferedFeature.FuncName4Invoked, strComparisonOp);
}
else
{
objvFunctionReferedFeatureEN.dicFldComparisonOp[convFunctionReferedFeature.FuncName4Invoked] = strComparisonOp;
}
}
return objvFunctionReferedFeatureEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureENS">源对象</param>
 /// <param name = "objvFunctionReferedFeatureENT">目标对象</param>
 public static void CopyTo(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureENS, clsvFunctionReferedFeatureEN objvFunctionReferedFeatureENT)
{
try
{
objvFunctionReferedFeatureENT.mId = objvFunctionReferedFeatureENS.mId; //mId
objvFunctionReferedFeatureENT.FeatureId = objvFunctionReferedFeatureENS.FeatureId; //功能Id
objvFunctionReferedFeatureENT.FeatureName = objvFunctionReferedFeatureENS.FeatureName; //功能名称
objvFunctionReferedFeatureENT.KeyWords = objvFunctionReferedFeatureENS.KeyWords; //关键字
objvFunctionReferedFeatureENT.FunctionGroupId = objvFunctionReferedFeatureENS.FunctionGroupId; //函数组Id
objvFunctionReferedFeatureENT.FunctionGroupName = objvFunctionReferedFeatureENS.FunctionGroupName; //函数组名称
objvFunctionReferedFeatureENT.FeatureTypeId = objvFunctionReferedFeatureENS.FeatureTypeId; //功能类型Id
objvFunctionReferedFeatureENT.FeatureTypeName = objvFunctionReferedFeatureENS.FeatureTypeName; //功能类型名称
objvFunctionReferedFeatureENT.FuncId4GC = objvFunctionReferedFeatureENS.FuncId4GC; //函数ID
objvFunctionReferedFeatureENT.FuncName = objvFunctionReferedFeatureENS.FuncName; //函数名
objvFunctionReferedFeatureENT.FuncId4Invoked = objvFunctionReferedFeatureENS.FuncId4Invoked; //被调用函数
objvFunctionReferedFeatureENT.UpdDate = objvFunctionReferedFeatureENS.UpdDate; //修改日期
objvFunctionReferedFeatureENT.UpdUser = objvFunctionReferedFeatureENS.UpdUser; //修改者
objvFunctionReferedFeatureENT.Memo = objvFunctionReferedFeatureENS.Memo; //说明
objvFunctionReferedFeatureENT.FuncName4Invoked = objvFunctionReferedFeatureENS.FuncName4Invoked; //FuncName4Invoked
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
 /// <param name = "objvFunctionReferedFeatureENS">源对象</param>
 /// <returns>目标对象=>clsvFunctionReferedFeatureEN:objvFunctionReferedFeatureENT</returns>
 public static clsvFunctionReferedFeatureEN CopyTo(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureENS)
{
try
{
 clsvFunctionReferedFeatureEN objvFunctionReferedFeatureENT = new clsvFunctionReferedFeatureEN()
{
mId = objvFunctionReferedFeatureENS.mId, //mId
FeatureId = objvFunctionReferedFeatureENS.FeatureId, //功能Id
FeatureName = objvFunctionReferedFeatureENS.FeatureName, //功能名称
KeyWords = objvFunctionReferedFeatureENS.KeyWords, //关键字
FunctionGroupId = objvFunctionReferedFeatureENS.FunctionGroupId, //函数组Id
FunctionGroupName = objvFunctionReferedFeatureENS.FunctionGroupName, //函数组名称
FeatureTypeId = objvFunctionReferedFeatureENS.FeatureTypeId, //功能类型Id
FeatureTypeName = objvFunctionReferedFeatureENS.FeatureTypeName, //功能类型名称
FuncId4GC = objvFunctionReferedFeatureENS.FuncId4GC, //函数ID
FuncName = objvFunctionReferedFeatureENS.FuncName, //函数名
FuncId4Invoked = objvFunctionReferedFeatureENS.FuncId4Invoked, //被调用函数
UpdDate = objvFunctionReferedFeatureENS.UpdDate, //修改日期
UpdUser = objvFunctionReferedFeatureENS.UpdUser, //修改者
Memo = objvFunctionReferedFeatureENS.Memo, //说明
FuncName4Invoked = objvFunctionReferedFeatureENS.FuncName4Invoked, //FuncName4Invoked
};
 return objvFunctionReferedFeatureENT;
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
public static void CheckProperty4Condition(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN)
{
 clsvFunctionReferedFeatureBL.vFunctionReferedFeatureDA.CheckProperty4Condition(objvFunctionReferedFeatureEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunctionReferedFeatureCond.IsUpdated(convFunctionReferedFeature.mId) == true)
{
string strComparisonOpmId = objvFunctionReferedFeatureCond.dicFldComparisonOp[convFunctionReferedFeature.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFunctionReferedFeature.mId, objvFunctionReferedFeatureCond.mId, strComparisonOpmId);
}
if (objvFunctionReferedFeatureCond.IsUpdated(convFunctionReferedFeature.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFunctionReferedFeatureCond.dicFldComparisonOp[convFunctionReferedFeature.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionReferedFeature.FeatureId, objvFunctionReferedFeatureCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFunctionReferedFeatureCond.IsUpdated(convFunctionReferedFeature.FeatureName) == true)
{
string strComparisonOpFeatureName = objvFunctionReferedFeatureCond.dicFldComparisonOp[convFunctionReferedFeature.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionReferedFeature.FeatureName, objvFunctionReferedFeatureCond.FeatureName, strComparisonOpFeatureName);
}
if (objvFunctionReferedFeatureCond.IsUpdated(convFunctionReferedFeature.KeyWords) == true)
{
string strComparisonOpKeyWords = objvFunctionReferedFeatureCond.dicFldComparisonOp[convFunctionReferedFeature.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionReferedFeature.KeyWords, objvFunctionReferedFeatureCond.KeyWords, strComparisonOpKeyWords);
}
if (objvFunctionReferedFeatureCond.IsUpdated(convFunctionReferedFeature.FunctionGroupId) == true)
{
string strComparisonOpFunctionGroupId = objvFunctionReferedFeatureCond.dicFldComparisonOp[convFunctionReferedFeature.FunctionGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionReferedFeature.FunctionGroupId, objvFunctionReferedFeatureCond.FunctionGroupId, strComparisonOpFunctionGroupId);
}
if (objvFunctionReferedFeatureCond.IsUpdated(convFunctionReferedFeature.FunctionGroupName) == true)
{
string strComparisonOpFunctionGroupName = objvFunctionReferedFeatureCond.dicFldComparisonOp[convFunctionReferedFeature.FunctionGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionReferedFeature.FunctionGroupName, objvFunctionReferedFeatureCond.FunctionGroupName, strComparisonOpFunctionGroupName);
}
if (objvFunctionReferedFeatureCond.IsUpdated(convFunctionReferedFeature.FeatureTypeId) == true)
{
string strComparisonOpFeatureTypeId = objvFunctionReferedFeatureCond.dicFldComparisonOp[convFunctionReferedFeature.FeatureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionReferedFeature.FeatureTypeId, objvFunctionReferedFeatureCond.FeatureTypeId, strComparisonOpFeatureTypeId);
}
if (objvFunctionReferedFeatureCond.IsUpdated(convFunctionReferedFeature.FeatureTypeName) == true)
{
string strComparisonOpFeatureTypeName = objvFunctionReferedFeatureCond.dicFldComparisonOp[convFunctionReferedFeature.FeatureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionReferedFeature.FeatureTypeName, objvFunctionReferedFeatureCond.FeatureTypeName, strComparisonOpFeatureTypeName);
}
if (objvFunctionReferedFeatureCond.IsUpdated(convFunctionReferedFeature.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objvFunctionReferedFeatureCond.dicFldComparisonOp[convFunctionReferedFeature.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionReferedFeature.FuncId4GC, objvFunctionReferedFeatureCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objvFunctionReferedFeatureCond.IsUpdated(convFunctionReferedFeature.FuncName) == true)
{
string strComparisonOpFuncName = objvFunctionReferedFeatureCond.dicFldComparisonOp[convFunctionReferedFeature.FuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionReferedFeature.FuncName, objvFunctionReferedFeatureCond.FuncName, strComparisonOpFuncName);
}
if (objvFunctionReferedFeatureCond.IsUpdated(convFunctionReferedFeature.FuncId4Invoked) == true)
{
string strComparisonOpFuncId4Invoked = objvFunctionReferedFeatureCond.dicFldComparisonOp[convFunctionReferedFeature.FuncId4Invoked];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionReferedFeature.FuncId4Invoked, objvFunctionReferedFeatureCond.FuncId4Invoked, strComparisonOpFuncId4Invoked);
}
if (objvFunctionReferedFeatureCond.IsUpdated(convFunctionReferedFeature.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFunctionReferedFeatureCond.dicFldComparisonOp[convFunctionReferedFeature.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionReferedFeature.UpdDate, objvFunctionReferedFeatureCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFunctionReferedFeatureCond.IsUpdated(convFunctionReferedFeature.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFunctionReferedFeatureCond.dicFldComparisonOp[convFunctionReferedFeature.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionReferedFeature.UpdUser, objvFunctionReferedFeatureCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFunctionReferedFeatureCond.IsUpdated(convFunctionReferedFeature.Memo) == true)
{
string strComparisonOpMemo = objvFunctionReferedFeatureCond.dicFldComparisonOp[convFunctionReferedFeature.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionReferedFeature.Memo, objvFunctionReferedFeatureCond.Memo, strComparisonOpMemo);
}
if (objvFunctionReferedFeatureCond.IsUpdated(convFunctionReferedFeature.FuncName4Invoked) == true)
{
string strComparisonOpFuncName4Invoked = objvFunctionReferedFeatureCond.dicFldComparisonOp[convFunctionReferedFeature.FuncName4Invoked];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionReferedFeature.FuncName4Invoked, objvFunctionReferedFeatureCond.FuncName4Invoked, strComparisonOpFuncName4Invoked);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFunctionReferedFeature
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v功能相关函数(vFunctionReferedFeature)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFunctionReferedFeatureBL
{
public static RelatedActions_vFunctionReferedFeature relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFunctionReferedFeatureDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFunctionReferedFeatureDA vFunctionReferedFeatureDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFunctionReferedFeatureDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFunctionReferedFeatureBL()
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
if (string.IsNullOrEmpty(clsvFunctionReferedFeatureEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunctionReferedFeatureEN._ConnectString);
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
public static DataTable GetDataTable_vFunctionReferedFeature(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFunctionReferedFeatureDA.GetDataTable_vFunctionReferedFeature(strWhereCond);
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
objDT = vFunctionReferedFeatureDA.GetDataTable(strWhereCond);
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
objDT = vFunctionReferedFeatureDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFunctionReferedFeatureDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFunctionReferedFeatureDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFunctionReferedFeatureDA.GetDataTable_Top(objTopPara);
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
objDT = vFunctionReferedFeatureDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFunctionReferedFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFunctionReferedFeatureDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvFunctionReferedFeatureEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvFunctionReferedFeatureEN> arrObjLst = new List<clsvFunctionReferedFeatureEN>(); 
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
	clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN = new clsvFunctionReferedFeatureEN();
try
{
objvFunctionReferedFeatureEN.mId = Int32.Parse(objRow[convFunctionReferedFeature.mId].ToString().Trim()); //mId
objvFunctionReferedFeatureEN.FeatureId = objRow[convFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objvFunctionReferedFeatureEN.FeatureName = objRow[convFunctionReferedFeature.FeatureName].ToString().Trim(); //功能名称
objvFunctionReferedFeatureEN.KeyWords = objRow[convFunctionReferedFeature.KeyWords] == DBNull.Value ? null : objRow[convFunctionReferedFeature.KeyWords].ToString().Trim(); //关键字
objvFunctionReferedFeatureEN.FunctionGroupId = objRow[convFunctionReferedFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionReferedFeatureEN.FunctionGroupName = objRow[convFunctionReferedFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionReferedFeatureEN.FeatureTypeId = objRow[convFunctionReferedFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFunctionReferedFeatureEN.FeatureTypeName = objRow[convFunctionReferedFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunctionReferedFeatureEN.FuncId4GC = objRow[convFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionReferedFeatureEN.FuncName = objRow[convFunctionReferedFeature.FuncName].ToString().Trim(); //函数名
objvFunctionReferedFeatureEN.FuncId4Invoked = objRow[convFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objvFunctionReferedFeatureEN.UpdDate = objRow[convFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objvFunctionReferedFeatureEN.UpdUser = objRow[convFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objvFunctionReferedFeatureEN.Memo = objRow[convFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[convFunctionReferedFeature.Memo].ToString().Trim(); //说明
objvFunctionReferedFeatureEN.FuncName4Invoked = objRow[convFunctionReferedFeature.FuncName4Invoked] == DBNull.Value ? null : objRow[convFunctionReferedFeature.FuncName4Invoked].ToString().Trim(); //FuncName4Invoked
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionReferedFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFunctionReferedFeatureEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvFunctionReferedFeatureEN._CurrTabName);
List<clsvFunctionReferedFeatureEN> arrvFunctionReferedFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionReferedFeatureEN> arrvFunctionReferedFeatureObjLst_Sel =
arrvFunctionReferedFeatureObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvFunctionReferedFeatureObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionReferedFeatureEN> GetObjLst(string strWhereCond)
{
List<clsvFunctionReferedFeatureEN> arrObjLst = new List<clsvFunctionReferedFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN = new clsvFunctionReferedFeatureEN();
try
{
objvFunctionReferedFeatureEN.mId = Int32.Parse(objRow[convFunctionReferedFeature.mId].ToString().Trim()); //mId
objvFunctionReferedFeatureEN.FeatureId = objRow[convFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objvFunctionReferedFeatureEN.FeatureName = objRow[convFunctionReferedFeature.FeatureName].ToString().Trim(); //功能名称
objvFunctionReferedFeatureEN.KeyWords = objRow[convFunctionReferedFeature.KeyWords] == DBNull.Value ? null : objRow[convFunctionReferedFeature.KeyWords].ToString().Trim(); //关键字
objvFunctionReferedFeatureEN.FunctionGroupId = objRow[convFunctionReferedFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionReferedFeatureEN.FunctionGroupName = objRow[convFunctionReferedFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionReferedFeatureEN.FeatureTypeId = objRow[convFunctionReferedFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFunctionReferedFeatureEN.FeatureTypeName = objRow[convFunctionReferedFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunctionReferedFeatureEN.FuncId4GC = objRow[convFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionReferedFeatureEN.FuncName = objRow[convFunctionReferedFeature.FuncName].ToString().Trim(); //函数名
objvFunctionReferedFeatureEN.FuncId4Invoked = objRow[convFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objvFunctionReferedFeatureEN.UpdDate = objRow[convFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objvFunctionReferedFeatureEN.UpdUser = objRow[convFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objvFunctionReferedFeatureEN.Memo = objRow[convFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[convFunctionReferedFeature.Memo].ToString().Trim(); //说明
objvFunctionReferedFeatureEN.FuncName4Invoked = objRow[convFunctionReferedFeature.FuncName4Invoked] == DBNull.Value ? null : objRow[convFunctionReferedFeature.FuncName4Invoked].ToString().Trim(); //FuncName4Invoked
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionReferedFeatureEN);
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
public static List<clsvFunctionReferedFeatureEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFunctionReferedFeatureEN> arrObjLst = new List<clsvFunctionReferedFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN = new clsvFunctionReferedFeatureEN();
try
{
objvFunctionReferedFeatureEN.mId = Int32.Parse(objRow[convFunctionReferedFeature.mId].ToString().Trim()); //mId
objvFunctionReferedFeatureEN.FeatureId = objRow[convFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objvFunctionReferedFeatureEN.FeatureName = objRow[convFunctionReferedFeature.FeatureName].ToString().Trim(); //功能名称
objvFunctionReferedFeatureEN.KeyWords = objRow[convFunctionReferedFeature.KeyWords] == DBNull.Value ? null : objRow[convFunctionReferedFeature.KeyWords].ToString().Trim(); //关键字
objvFunctionReferedFeatureEN.FunctionGroupId = objRow[convFunctionReferedFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionReferedFeatureEN.FunctionGroupName = objRow[convFunctionReferedFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionReferedFeatureEN.FeatureTypeId = objRow[convFunctionReferedFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFunctionReferedFeatureEN.FeatureTypeName = objRow[convFunctionReferedFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunctionReferedFeatureEN.FuncId4GC = objRow[convFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionReferedFeatureEN.FuncName = objRow[convFunctionReferedFeature.FuncName].ToString().Trim(); //函数名
objvFunctionReferedFeatureEN.FuncId4Invoked = objRow[convFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objvFunctionReferedFeatureEN.UpdDate = objRow[convFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objvFunctionReferedFeatureEN.UpdUser = objRow[convFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objvFunctionReferedFeatureEN.Memo = objRow[convFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[convFunctionReferedFeature.Memo].ToString().Trim(); //说明
objvFunctionReferedFeatureEN.FuncName4Invoked = objRow[convFunctionReferedFeature.FuncName4Invoked] == DBNull.Value ? null : objRow[convFunctionReferedFeature.FuncName4Invoked].ToString().Trim(); //FuncName4Invoked
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionReferedFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFunctionReferedFeatureEN> GetSubObjLstCache(clsvFunctionReferedFeatureEN objvFunctionReferedFeatureCond)
{
List<clsvFunctionReferedFeatureEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionReferedFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunctionReferedFeature._AttributeName)
{
if (objvFunctionReferedFeatureCond.IsUpdated(strFldName) == false) continue;
if (objvFunctionReferedFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionReferedFeatureCond[strFldName].ToString());
}
else
{
if (objvFunctionReferedFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunctionReferedFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionReferedFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunctionReferedFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunctionReferedFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunctionReferedFeatureCond[strFldName]));
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
public static List<clsvFunctionReferedFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFunctionReferedFeatureEN> arrObjLst = new List<clsvFunctionReferedFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN = new clsvFunctionReferedFeatureEN();
try
{
objvFunctionReferedFeatureEN.mId = Int32.Parse(objRow[convFunctionReferedFeature.mId].ToString().Trim()); //mId
objvFunctionReferedFeatureEN.FeatureId = objRow[convFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objvFunctionReferedFeatureEN.FeatureName = objRow[convFunctionReferedFeature.FeatureName].ToString().Trim(); //功能名称
objvFunctionReferedFeatureEN.KeyWords = objRow[convFunctionReferedFeature.KeyWords] == DBNull.Value ? null : objRow[convFunctionReferedFeature.KeyWords].ToString().Trim(); //关键字
objvFunctionReferedFeatureEN.FunctionGroupId = objRow[convFunctionReferedFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionReferedFeatureEN.FunctionGroupName = objRow[convFunctionReferedFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionReferedFeatureEN.FeatureTypeId = objRow[convFunctionReferedFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFunctionReferedFeatureEN.FeatureTypeName = objRow[convFunctionReferedFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunctionReferedFeatureEN.FuncId4GC = objRow[convFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionReferedFeatureEN.FuncName = objRow[convFunctionReferedFeature.FuncName].ToString().Trim(); //函数名
objvFunctionReferedFeatureEN.FuncId4Invoked = objRow[convFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objvFunctionReferedFeatureEN.UpdDate = objRow[convFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objvFunctionReferedFeatureEN.UpdUser = objRow[convFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objvFunctionReferedFeatureEN.Memo = objRow[convFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[convFunctionReferedFeature.Memo].ToString().Trim(); //说明
objvFunctionReferedFeatureEN.FuncName4Invoked = objRow[convFunctionReferedFeature.FuncName4Invoked] == DBNull.Value ? null : objRow[convFunctionReferedFeature.FuncName4Invoked].ToString().Trim(); //FuncName4Invoked
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionReferedFeatureEN);
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
public static List<clsvFunctionReferedFeatureEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFunctionReferedFeatureEN> arrObjLst = new List<clsvFunctionReferedFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN = new clsvFunctionReferedFeatureEN();
try
{
objvFunctionReferedFeatureEN.mId = Int32.Parse(objRow[convFunctionReferedFeature.mId].ToString().Trim()); //mId
objvFunctionReferedFeatureEN.FeatureId = objRow[convFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objvFunctionReferedFeatureEN.FeatureName = objRow[convFunctionReferedFeature.FeatureName].ToString().Trim(); //功能名称
objvFunctionReferedFeatureEN.KeyWords = objRow[convFunctionReferedFeature.KeyWords] == DBNull.Value ? null : objRow[convFunctionReferedFeature.KeyWords].ToString().Trim(); //关键字
objvFunctionReferedFeatureEN.FunctionGroupId = objRow[convFunctionReferedFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionReferedFeatureEN.FunctionGroupName = objRow[convFunctionReferedFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionReferedFeatureEN.FeatureTypeId = objRow[convFunctionReferedFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFunctionReferedFeatureEN.FeatureTypeName = objRow[convFunctionReferedFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunctionReferedFeatureEN.FuncId4GC = objRow[convFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionReferedFeatureEN.FuncName = objRow[convFunctionReferedFeature.FuncName].ToString().Trim(); //函数名
objvFunctionReferedFeatureEN.FuncId4Invoked = objRow[convFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objvFunctionReferedFeatureEN.UpdDate = objRow[convFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objvFunctionReferedFeatureEN.UpdUser = objRow[convFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objvFunctionReferedFeatureEN.Memo = objRow[convFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[convFunctionReferedFeature.Memo].ToString().Trim(); //说明
objvFunctionReferedFeatureEN.FuncName4Invoked = objRow[convFunctionReferedFeature.FuncName4Invoked] == DBNull.Value ? null : objRow[convFunctionReferedFeature.FuncName4Invoked].ToString().Trim(); //FuncName4Invoked
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionReferedFeatureEN);
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
List<clsvFunctionReferedFeatureEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFunctionReferedFeatureEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionReferedFeatureEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFunctionReferedFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFunctionReferedFeatureEN> arrObjLst = new List<clsvFunctionReferedFeatureEN>(); 
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
	clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN = new clsvFunctionReferedFeatureEN();
try
{
objvFunctionReferedFeatureEN.mId = Int32.Parse(objRow[convFunctionReferedFeature.mId].ToString().Trim()); //mId
objvFunctionReferedFeatureEN.FeatureId = objRow[convFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objvFunctionReferedFeatureEN.FeatureName = objRow[convFunctionReferedFeature.FeatureName].ToString().Trim(); //功能名称
objvFunctionReferedFeatureEN.KeyWords = objRow[convFunctionReferedFeature.KeyWords] == DBNull.Value ? null : objRow[convFunctionReferedFeature.KeyWords].ToString().Trim(); //关键字
objvFunctionReferedFeatureEN.FunctionGroupId = objRow[convFunctionReferedFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionReferedFeatureEN.FunctionGroupName = objRow[convFunctionReferedFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionReferedFeatureEN.FeatureTypeId = objRow[convFunctionReferedFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFunctionReferedFeatureEN.FeatureTypeName = objRow[convFunctionReferedFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunctionReferedFeatureEN.FuncId4GC = objRow[convFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionReferedFeatureEN.FuncName = objRow[convFunctionReferedFeature.FuncName].ToString().Trim(); //函数名
objvFunctionReferedFeatureEN.FuncId4Invoked = objRow[convFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objvFunctionReferedFeatureEN.UpdDate = objRow[convFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objvFunctionReferedFeatureEN.UpdUser = objRow[convFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objvFunctionReferedFeatureEN.Memo = objRow[convFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[convFunctionReferedFeature.Memo].ToString().Trim(); //说明
objvFunctionReferedFeatureEN.FuncName4Invoked = objRow[convFunctionReferedFeature.FuncName4Invoked] == DBNull.Value ? null : objRow[convFunctionReferedFeature.FuncName4Invoked].ToString().Trim(); //FuncName4Invoked
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionReferedFeatureEN);
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
public static List<clsvFunctionReferedFeatureEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFunctionReferedFeatureEN> arrObjLst = new List<clsvFunctionReferedFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN = new clsvFunctionReferedFeatureEN();
try
{
objvFunctionReferedFeatureEN.mId = Int32.Parse(objRow[convFunctionReferedFeature.mId].ToString().Trim()); //mId
objvFunctionReferedFeatureEN.FeatureId = objRow[convFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objvFunctionReferedFeatureEN.FeatureName = objRow[convFunctionReferedFeature.FeatureName].ToString().Trim(); //功能名称
objvFunctionReferedFeatureEN.KeyWords = objRow[convFunctionReferedFeature.KeyWords] == DBNull.Value ? null : objRow[convFunctionReferedFeature.KeyWords].ToString().Trim(); //关键字
objvFunctionReferedFeatureEN.FunctionGroupId = objRow[convFunctionReferedFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionReferedFeatureEN.FunctionGroupName = objRow[convFunctionReferedFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionReferedFeatureEN.FeatureTypeId = objRow[convFunctionReferedFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFunctionReferedFeatureEN.FeatureTypeName = objRow[convFunctionReferedFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunctionReferedFeatureEN.FuncId4GC = objRow[convFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionReferedFeatureEN.FuncName = objRow[convFunctionReferedFeature.FuncName].ToString().Trim(); //函数名
objvFunctionReferedFeatureEN.FuncId4Invoked = objRow[convFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objvFunctionReferedFeatureEN.UpdDate = objRow[convFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objvFunctionReferedFeatureEN.UpdUser = objRow[convFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objvFunctionReferedFeatureEN.Memo = objRow[convFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[convFunctionReferedFeature.Memo].ToString().Trim(); //说明
objvFunctionReferedFeatureEN.FuncName4Invoked = objRow[convFunctionReferedFeature.FuncName4Invoked] == DBNull.Value ? null : objRow[convFunctionReferedFeature.FuncName4Invoked].ToString().Trim(); //FuncName4Invoked
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionReferedFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFunctionReferedFeatureEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFunctionReferedFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFunctionReferedFeatureEN> arrObjLst = new List<clsvFunctionReferedFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN = new clsvFunctionReferedFeatureEN();
try
{
objvFunctionReferedFeatureEN.mId = Int32.Parse(objRow[convFunctionReferedFeature.mId].ToString().Trim()); //mId
objvFunctionReferedFeatureEN.FeatureId = objRow[convFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objvFunctionReferedFeatureEN.FeatureName = objRow[convFunctionReferedFeature.FeatureName].ToString().Trim(); //功能名称
objvFunctionReferedFeatureEN.KeyWords = objRow[convFunctionReferedFeature.KeyWords] == DBNull.Value ? null : objRow[convFunctionReferedFeature.KeyWords].ToString().Trim(); //关键字
objvFunctionReferedFeatureEN.FunctionGroupId = objRow[convFunctionReferedFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionReferedFeatureEN.FunctionGroupName = objRow[convFunctionReferedFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionReferedFeatureEN.FeatureTypeId = objRow[convFunctionReferedFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFunctionReferedFeatureEN.FeatureTypeName = objRow[convFunctionReferedFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunctionReferedFeatureEN.FuncId4GC = objRow[convFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionReferedFeatureEN.FuncName = objRow[convFunctionReferedFeature.FuncName].ToString().Trim(); //函数名
objvFunctionReferedFeatureEN.FuncId4Invoked = objRow[convFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objvFunctionReferedFeatureEN.UpdDate = objRow[convFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objvFunctionReferedFeatureEN.UpdUser = objRow[convFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objvFunctionReferedFeatureEN.Memo = objRow[convFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[convFunctionReferedFeature.Memo].ToString().Trim(); //说明
objvFunctionReferedFeatureEN.FuncName4Invoked = objRow[convFunctionReferedFeature.FuncName4Invoked] == DBNull.Value ? null : objRow[convFunctionReferedFeature.FuncName4Invoked].ToString().Trim(); //FuncName4Invoked
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionReferedFeatureEN);
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
public static List<clsvFunctionReferedFeatureEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFunctionReferedFeatureEN> arrObjLst = new List<clsvFunctionReferedFeatureEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN = new clsvFunctionReferedFeatureEN();
try
{
objvFunctionReferedFeatureEN.mId = Int32.Parse(objRow[convFunctionReferedFeature.mId].ToString().Trim()); //mId
objvFunctionReferedFeatureEN.FeatureId = objRow[convFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objvFunctionReferedFeatureEN.FeatureName = objRow[convFunctionReferedFeature.FeatureName].ToString().Trim(); //功能名称
objvFunctionReferedFeatureEN.KeyWords = objRow[convFunctionReferedFeature.KeyWords] == DBNull.Value ? null : objRow[convFunctionReferedFeature.KeyWords].ToString().Trim(); //关键字
objvFunctionReferedFeatureEN.FunctionGroupId = objRow[convFunctionReferedFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionReferedFeatureEN.FunctionGroupName = objRow[convFunctionReferedFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionReferedFeatureEN.FeatureTypeId = objRow[convFunctionReferedFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFunctionReferedFeatureEN.FeatureTypeName = objRow[convFunctionReferedFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunctionReferedFeatureEN.FuncId4GC = objRow[convFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionReferedFeatureEN.FuncName = objRow[convFunctionReferedFeature.FuncName].ToString().Trim(); //函数名
objvFunctionReferedFeatureEN.FuncId4Invoked = objRow[convFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objvFunctionReferedFeatureEN.UpdDate = objRow[convFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objvFunctionReferedFeatureEN.UpdUser = objRow[convFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objvFunctionReferedFeatureEN.Memo = objRow[convFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[convFunctionReferedFeature.Memo].ToString().Trim(); //说明
objvFunctionReferedFeatureEN.FuncName4Invoked = objRow[convFunctionReferedFeature.FuncName4Invoked] == DBNull.Value ? null : objRow[convFunctionReferedFeature.FuncName4Invoked].ToString().Trim(); //FuncName4Invoked
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionReferedFeatureEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionReferedFeatureEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFunctionReferedFeatureEN> arrObjLst = new List<clsvFunctionReferedFeatureEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN = new clsvFunctionReferedFeatureEN();
try
{
objvFunctionReferedFeatureEN.mId = Int32.Parse(objRow[convFunctionReferedFeature.mId].ToString().Trim()); //mId
objvFunctionReferedFeatureEN.FeatureId = objRow[convFunctionReferedFeature.FeatureId].ToString().Trim(); //功能Id
objvFunctionReferedFeatureEN.FeatureName = objRow[convFunctionReferedFeature.FeatureName].ToString().Trim(); //功能名称
objvFunctionReferedFeatureEN.KeyWords = objRow[convFunctionReferedFeature.KeyWords] == DBNull.Value ? null : objRow[convFunctionReferedFeature.KeyWords].ToString().Trim(); //关键字
objvFunctionReferedFeatureEN.FunctionGroupId = objRow[convFunctionReferedFeature.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionReferedFeatureEN.FunctionGroupName = objRow[convFunctionReferedFeature.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionReferedFeatureEN.FeatureTypeId = objRow[convFunctionReferedFeature.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFunctionReferedFeatureEN.FeatureTypeName = objRow[convFunctionReferedFeature.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunctionReferedFeatureEN.FuncId4GC = objRow[convFunctionReferedFeature.FuncId4GC].ToString().Trim(); //函数ID
objvFunctionReferedFeatureEN.FuncName = objRow[convFunctionReferedFeature.FuncName].ToString().Trim(); //函数名
objvFunctionReferedFeatureEN.FuncId4Invoked = objRow[convFunctionReferedFeature.FuncId4Invoked].ToString().Trim(); //被调用函数
objvFunctionReferedFeatureEN.UpdDate = objRow[convFunctionReferedFeature.UpdDate] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdDate].ToString().Trim(); //修改日期
objvFunctionReferedFeatureEN.UpdUser = objRow[convFunctionReferedFeature.UpdUser] == DBNull.Value ? null : objRow[convFunctionReferedFeature.UpdUser].ToString().Trim(); //修改者
objvFunctionReferedFeatureEN.Memo = objRow[convFunctionReferedFeature.Memo] == DBNull.Value ? null : objRow[convFunctionReferedFeature.Memo].ToString().Trim(); //说明
objvFunctionReferedFeatureEN.FuncName4Invoked = objRow[convFunctionReferedFeature.FuncName4Invoked] == DBNull.Value ? null : objRow[convFunctionReferedFeature.FuncName4Invoked].ToString().Trim(); //FuncName4Invoked
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionReferedFeatureEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionReferedFeatureEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFunctionReferedFeature(ref clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN)
{
bool bolResult = vFunctionReferedFeatureDA.GetvFunctionReferedFeature(ref objvFunctionReferedFeatureEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionReferedFeatureEN GetObjBymId(long lngmId)
{
clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN = vFunctionReferedFeatureDA.GetObjBymId(lngmId);
return objvFunctionReferedFeatureEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFunctionReferedFeatureEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN = vFunctionReferedFeatureDA.GetFirstObj(strWhereCond);
 return objvFunctionReferedFeatureEN;
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
public static clsvFunctionReferedFeatureEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN = vFunctionReferedFeatureDA.GetObjByDataRow(objRow);
 return objvFunctionReferedFeatureEN;
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
public static clsvFunctionReferedFeatureEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN = vFunctionReferedFeatureDA.GetObjByDataRow(objRow);
 return objvFunctionReferedFeatureEN;
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
 /// <param name = "lstvFunctionReferedFeatureObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionReferedFeatureEN GetObjBymIdFromList(long lngmId, List<clsvFunctionReferedFeatureEN> lstvFunctionReferedFeatureObjLst)
{
foreach (clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN in lstvFunctionReferedFeatureObjLst)
{
if (objvFunctionReferedFeatureEN.mId == lngmId)
{
return objvFunctionReferedFeatureEN;
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
 lngmId = new clsvFunctionReferedFeatureDA().GetFirstID(strWhereCond);
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
 arrList = vFunctionReferedFeatureDA.GetID(strWhereCond);
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
bool bolIsExist = vFunctionReferedFeatureDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vFunctionReferedFeatureDA.IsExist(lngmId);
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
 bolIsExist = clsvFunctionReferedFeatureDA.IsExistTable();
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
 bolIsExist = vFunctionReferedFeatureDA.IsExistTable(strTabName);
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
 /// <param name = "objvFunctionReferedFeatureENS">源对象</param>
 /// <param name = "objvFunctionReferedFeatureENT">目标对象</param>
 public static void CopyTo(clsvFunctionReferedFeatureEN objvFunctionReferedFeatureENS, clsvFunctionReferedFeatureEN objvFunctionReferedFeatureENT)
{
try
{
objvFunctionReferedFeatureENT.mId = objvFunctionReferedFeatureENS.mId; //mId
objvFunctionReferedFeatureENT.FeatureId = objvFunctionReferedFeatureENS.FeatureId; //功能Id
objvFunctionReferedFeatureENT.FeatureName = objvFunctionReferedFeatureENS.FeatureName; //功能名称
objvFunctionReferedFeatureENT.KeyWords = objvFunctionReferedFeatureENS.KeyWords; //关键字
objvFunctionReferedFeatureENT.FunctionGroupId = objvFunctionReferedFeatureENS.FunctionGroupId; //函数组Id
objvFunctionReferedFeatureENT.FunctionGroupName = objvFunctionReferedFeatureENS.FunctionGroupName; //函数组名称
objvFunctionReferedFeatureENT.FeatureTypeId = objvFunctionReferedFeatureENS.FeatureTypeId; //功能类型Id
objvFunctionReferedFeatureENT.FeatureTypeName = objvFunctionReferedFeatureENS.FeatureTypeName; //功能类型名称
objvFunctionReferedFeatureENT.FuncId4GC = objvFunctionReferedFeatureENS.FuncId4GC; //函数ID
objvFunctionReferedFeatureENT.FuncName = objvFunctionReferedFeatureENS.FuncName; //函数名
objvFunctionReferedFeatureENT.FuncId4Invoked = objvFunctionReferedFeatureENS.FuncId4Invoked; //被调用函数
objvFunctionReferedFeatureENT.UpdDate = objvFunctionReferedFeatureENS.UpdDate; //修改日期
objvFunctionReferedFeatureENT.UpdUser = objvFunctionReferedFeatureENS.UpdUser; //修改者
objvFunctionReferedFeatureENT.Memo = objvFunctionReferedFeatureENS.Memo; //说明
objvFunctionReferedFeatureENT.FuncName4Invoked = objvFunctionReferedFeatureENS.FuncName4Invoked; //FuncName4Invoked
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
 /// <param name = "objvFunctionReferedFeatureEN">源简化对象</param>
 public static void SetUpdFlag(clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN)
{
try
{
objvFunctionReferedFeatureEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFunctionReferedFeatureEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFunctionReferedFeature.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionReferedFeatureEN.mId = objvFunctionReferedFeatureEN.mId; //mId
}
if (arrFldSet.Contains(convFunctionReferedFeature.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionReferedFeatureEN.FeatureId = objvFunctionReferedFeatureEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convFunctionReferedFeature.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionReferedFeatureEN.FeatureName = objvFunctionReferedFeatureEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convFunctionReferedFeature.KeyWords, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionReferedFeatureEN.KeyWords = objvFunctionReferedFeatureEN.KeyWords == "[null]" ? null :  objvFunctionReferedFeatureEN.KeyWords; //关键字
}
if (arrFldSet.Contains(convFunctionReferedFeature.FunctionGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionReferedFeatureEN.FunctionGroupId = objvFunctionReferedFeatureEN.FunctionGroupId; //函数组Id
}
if (arrFldSet.Contains(convFunctionReferedFeature.FunctionGroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionReferedFeatureEN.FunctionGroupName = objvFunctionReferedFeatureEN.FunctionGroupName; //函数组名称
}
if (arrFldSet.Contains(convFunctionReferedFeature.FeatureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionReferedFeatureEN.FeatureTypeId = objvFunctionReferedFeatureEN.FeatureTypeId; //功能类型Id
}
if (arrFldSet.Contains(convFunctionReferedFeature.FeatureTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionReferedFeatureEN.FeatureTypeName = objvFunctionReferedFeatureEN.FeatureTypeName; //功能类型名称
}
if (arrFldSet.Contains(convFunctionReferedFeature.FuncId4GC, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionReferedFeatureEN.FuncId4GC = objvFunctionReferedFeatureEN.FuncId4GC; //函数ID
}
if (arrFldSet.Contains(convFunctionReferedFeature.FuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionReferedFeatureEN.FuncName = objvFunctionReferedFeatureEN.FuncName; //函数名
}
if (arrFldSet.Contains(convFunctionReferedFeature.FuncId4Invoked, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionReferedFeatureEN.FuncId4Invoked = objvFunctionReferedFeatureEN.FuncId4Invoked; //被调用函数
}
if (arrFldSet.Contains(convFunctionReferedFeature.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionReferedFeatureEN.UpdDate = objvFunctionReferedFeatureEN.UpdDate == "[null]" ? null :  objvFunctionReferedFeatureEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFunctionReferedFeature.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionReferedFeatureEN.UpdUser = objvFunctionReferedFeatureEN.UpdUser == "[null]" ? null :  objvFunctionReferedFeatureEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFunctionReferedFeature.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionReferedFeatureEN.Memo = objvFunctionReferedFeatureEN.Memo == "[null]" ? null :  objvFunctionReferedFeatureEN.Memo; //说明
}
if (arrFldSet.Contains(convFunctionReferedFeature.FuncName4Invoked, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionReferedFeatureEN.FuncName4Invoked = objvFunctionReferedFeatureEN.FuncName4Invoked == "[null]" ? null :  objvFunctionReferedFeatureEN.FuncName4Invoked; //FuncName4Invoked
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
 /// <param name = "objvFunctionReferedFeatureEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN)
{
try
{
if (objvFunctionReferedFeatureEN.KeyWords == "[null]") objvFunctionReferedFeatureEN.KeyWords = null; //关键字
if (objvFunctionReferedFeatureEN.UpdDate == "[null]") objvFunctionReferedFeatureEN.UpdDate = null; //修改日期
if (objvFunctionReferedFeatureEN.UpdUser == "[null]") objvFunctionReferedFeatureEN.UpdUser = null; //修改者
if (objvFunctionReferedFeatureEN.Memo == "[null]") objvFunctionReferedFeatureEN.Memo = null; //说明
if (objvFunctionReferedFeatureEN.FuncName4Invoked == "[null]") objvFunctionReferedFeatureEN.FuncName4Invoked = null; //FuncName4Invoked
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
public static void CheckProperty4Condition(clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN)
{
 vFunctionReferedFeatureDA.CheckProperty4Condition(objvFunctionReferedFeatureEN);
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
if (clsFunction4GeneCodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunction4GeneCodeBL没有刷新缓存机制(clsFunction4GeneCodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionReferedFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionReferedFeatureBL没有刷新缓存机制(clsFunctionReferedFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRegionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRegionTypeBL没有刷新缓存机制(clsRegionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsInOutTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsInOutTypeBL没有刷新缓存机制(clsInOutTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureBL没有刷新缓存机制(clsPrjFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFeatureTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureTypeBL没有刷新缓存机制(clsPrjFeatureTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionGroupBL没有刷新缓存机制(clsFunctionGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvFunctionReferedFeatureObjLstCache == null)
//{
//arrvFunctionReferedFeatureObjLstCache = vFunctionReferedFeatureDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionReferedFeatureEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFunctionReferedFeatureEN._CurrTabName);
List<clsvFunctionReferedFeatureEN> arrvFunctionReferedFeatureObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionReferedFeatureEN> arrvFunctionReferedFeatureObjLst_Sel =
arrvFunctionReferedFeatureObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvFunctionReferedFeatureObjLst_Sel.Count() == 0)
{
   clsvFunctionReferedFeatureEN obj = clsvFunctionReferedFeatureBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFunctionReferedFeatureObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunctionReferedFeatureEN> GetAllvFunctionReferedFeatureObjLstCache()
{
//获取缓存中的对象列表
List<clsvFunctionReferedFeatureEN> arrvFunctionReferedFeatureObjLstCache = GetObjLstCache(); 
return arrvFunctionReferedFeatureObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunctionReferedFeatureEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFunctionReferedFeatureEN._CurrTabName);
List<clsvFunctionReferedFeatureEN> arrvFunctionReferedFeatureObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFunctionReferedFeatureObjLstCache;
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
string strKey = string.Format("{0}", clsvFunctionReferedFeatureEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFunctionReferedFeatureEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFunctionReferedFeatureEN._RefreshTimeLst.Count == 0) return "";
return clsvFunctionReferedFeatureEN._RefreshTimeLst[clsvFunctionReferedFeatureEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convFunctionReferedFeature.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFunctionReferedFeature._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFunctionReferedFeature._AttributeName));
throw new Exception(strMsg);
}
var objvFunctionReferedFeature = clsvFunctionReferedFeatureBL.GetObjBymIdCache(lngmId);
if (objvFunctionReferedFeature == null) return "";
return objvFunctionReferedFeature[strOutFldName].ToString();
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
int intRecCount = clsvFunctionReferedFeatureDA.GetRecCount(strTabName);
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
int intRecCount = clsvFunctionReferedFeatureDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFunctionReferedFeatureDA.GetRecCount();
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
int intRecCount = clsvFunctionReferedFeatureDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFunctionReferedFeatureEN objvFunctionReferedFeatureCond)
{
List<clsvFunctionReferedFeatureEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionReferedFeatureEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunctionReferedFeature._AttributeName)
{
if (objvFunctionReferedFeatureCond.IsUpdated(strFldName) == false) continue;
if (objvFunctionReferedFeatureCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionReferedFeatureCond[strFldName].ToString());
}
else
{
if (objvFunctionReferedFeatureCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunctionReferedFeatureCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionReferedFeatureCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunctionReferedFeatureCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunctionReferedFeatureCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunctionReferedFeatureCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunctionReferedFeatureCond[strFldName]));
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
 List<string> arrList = clsvFunctionReferedFeatureDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFunctionReferedFeatureDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFunctionReferedFeatureDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}