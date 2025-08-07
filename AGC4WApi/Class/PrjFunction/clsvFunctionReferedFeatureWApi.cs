
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionReferedFeatureWApi
 表名:vFunctionReferedFeature(00050341)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:50:58
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsvFunctionReferedFeatureWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFeatureId(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFunctionReferedFeature.FeatureId);
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFunctionReferedFeature.FeatureId);
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFunctionReferedFeature.FeatureId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFeatureName(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convFunctionReferedFeature.FeatureName);
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFunctionReferedFeature.FeatureName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyWords">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetKeyWords(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strKeyWords, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convFunctionReferedFeature.KeyWords);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionGroupId">函数组Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFunctionGroupId(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFunctionGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionGroupId, convFunctionReferedFeature.FunctionGroupId);
clsCheckSql.CheckFieldLen(strFunctionGroupId, 4, convFunctionReferedFeature.FunctionGroupId);
clsCheckSql.CheckFieldForeignKey(strFunctionGroupId, 4, convFunctionReferedFeature.FunctionGroupId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionGroupName">函数组名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFunctionGroupName(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFunctionGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionGroupName, convFunctionReferedFeature.FunctionGroupName);
clsCheckSql.CheckFieldLen(strFunctionGroupName, 50, convFunctionReferedFeature.FunctionGroupName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeId">功能类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFeatureTypeId(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeId, convFunctionReferedFeature.FeatureTypeId);
clsCheckSql.CheckFieldLen(strFeatureTypeId, 2, convFunctionReferedFeature.FeatureTypeId);
clsCheckSql.CheckFieldForeignKey(strFeatureTypeId, 2, convFunctionReferedFeature.FeatureTypeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeName">功能类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFeatureTypeName(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convFunctionReferedFeature.FeatureTypeName);
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convFunctionReferedFeature.FeatureTypeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4GC">函数ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFuncId4GC(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4GC, convFunctionReferedFeature.FuncId4GC);
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, convFunctionReferedFeature.FuncId4GC);
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, convFunctionReferedFeature.FuncId4GC);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName">函数名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFuncName(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFuncName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncName, convFunctionReferedFeature.FuncName);
clsCheckSql.CheckFieldLen(strFuncName, 100, convFunctionReferedFeature.FuncName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncId4Invoked">被调用函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFuncId4Invoked(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFuncId4Invoked, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4Invoked, convFunctionReferedFeature.FuncId4Invoked);
clsCheckSql.CheckFieldLen(strFuncId4Invoked, 10, convFunctionReferedFeature.FuncId4Invoked);
clsCheckSql.CheckFieldForeignKey(strFuncId4Invoked, 10, convFunctionReferedFeature.FuncId4Invoked);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetUpdDate(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFunctionReferedFeature.UpdDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetUpdUser(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFunctionReferedFeature.UpdUser);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetMemo(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunctionReferedFeature.Memo);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionReferedFeatureEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncName4Invoked">FuncName4Invoked</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionReferedFeatureEN SetFuncName4Invoked(this clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN, string strFuncName4Invoked, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncName4Invoked, 100, convFunctionReferedFeature.FuncName4Invoked);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
 /// v功能相关函数(vFunctionReferedFeature)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFunctionReferedFeatureWApi
{
private static readonly string mstrApiControllerName = "vFunctionReferedFeatureApi";

 public clsvFunctionReferedFeatureWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionReferedFeatureEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN;
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
objvFunctionReferedFeatureEN = JsonConvert.DeserializeObject<clsvFunctionReferedFeatureEN>(strJson);
return objvFunctionReferedFeatureEN;
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
public static clsvFunctionReferedFeatureEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFunctionReferedFeatureEN objvFunctionReferedFeatureEN;
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
objvFunctionReferedFeatureEN = JsonConvert.DeserializeObject<clsvFunctionReferedFeatureEN>(strJson);
return objvFunctionReferedFeatureEN;
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
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionReferedFeatureEN> GetObjLst(string strWhereCond)
{
 List<clsvFunctionReferedFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionReferedFeatureEN>>(strJson);
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
public static List<clsvFunctionReferedFeatureEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvFunctionReferedFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionReferedFeatureEN>>(strJson);
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
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionReferedFeatureEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFunctionReferedFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionReferedFeatureEN>>(strJson);
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
public static List<clsvFunctionReferedFeatureEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFunctionReferedFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionReferedFeatureEN>>(strJson);
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
public static List<clsvFunctionReferedFeatureEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFunctionReferedFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionReferedFeatureEN>>(strJson);
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
public static List<clsvFunctionReferedFeatureEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFunctionReferedFeatureEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionReferedFeatureEN>>(strJson);
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
public static DataTable ToDataTable(List<clsvFunctionReferedFeatureEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFunctionReferedFeatureEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFunctionReferedFeatureEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFunctionReferedFeatureEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFunctionReferedFeatureEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFunctionReferedFeatureEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFunctionReferedFeatureEN._CurrTabName);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFunctionReferedFeatureEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFunctionReferedFeature.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convFunctionReferedFeature.FeatureId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionReferedFeature.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionReferedFeature.KeyWords, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionReferedFeature.FunctionGroupId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionReferedFeature.FunctionGroupName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionReferedFeature.FeatureTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionReferedFeature.FeatureTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionReferedFeature.FuncId4GC, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionReferedFeature.FuncName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionReferedFeature.FuncId4Invoked, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionReferedFeature.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionReferedFeature.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionReferedFeature.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionReferedFeature.FuncName4Invoked, Type.GetType("System.String"));
foreach (clsvFunctionReferedFeatureEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFunctionReferedFeature.mId] = objInFor[convFunctionReferedFeature.mId];
objDR[convFunctionReferedFeature.FeatureId] = objInFor[convFunctionReferedFeature.FeatureId];
objDR[convFunctionReferedFeature.FeatureName] = objInFor[convFunctionReferedFeature.FeatureName];
objDR[convFunctionReferedFeature.KeyWords] = objInFor[convFunctionReferedFeature.KeyWords];
objDR[convFunctionReferedFeature.FunctionGroupId] = objInFor[convFunctionReferedFeature.FunctionGroupId];
objDR[convFunctionReferedFeature.FunctionGroupName] = objInFor[convFunctionReferedFeature.FunctionGroupName];
objDR[convFunctionReferedFeature.FeatureTypeId] = objInFor[convFunctionReferedFeature.FeatureTypeId];
objDR[convFunctionReferedFeature.FeatureTypeName] = objInFor[convFunctionReferedFeature.FeatureTypeName];
objDR[convFunctionReferedFeature.FuncId4GC] = objInFor[convFunctionReferedFeature.FuncId4GC];
objDR[convFunctionReferedFeature.FuncName] = objInFor[convFunctionReferedFeature.FuncName];
objDR[convFunctionReferedFeature.FuncId4Invoked] = objInFor[convFunctionReferedFeature.FuncId4Invoked];
objDR[convFunctionReferedFeature.UpdDate] = objInFor[convFunctionReferedFeature.UpdDate];
objDR[convFunctionReferedFeature.UpdUser] = objInFor[convFunctionReferedFeature.UpdUser];
objDR[convFunctionReferedFeature.Memo] = objInFor[convFunctionReferedFeature.Memo];
objDR[convFunctionReferedFeature.FuncName4Invoked] = objInFor[convFunctionReferedFeature.FuncName4Invoked];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}