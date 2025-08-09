
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionRelaWApi
 表名:vFunctionRela(00050321)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:30
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvFunctionRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetmId(this clsvFunctionRelaEN objvFunctionRelaEN, long lngmId, string strComparisonOp="")
	{
objvFunctionRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.mId) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.mId, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.mId] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncAId">函数AId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetFuncAId(this clsvFunctionRelaEN objvFunctionRelaEN, string strFuncAId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncAId, convFunctionRela.FuncAId);
clsCheckSql.CheckFieldLen(strFuncAId, 10, convFunctionRela.FuncAId);
clsCheckSql.CheckFieldForeignKey(strFuncAId, 10, convFunctionRela.FuncAId);
objvFunctionRelaEN.FuncAId = strFuncAId; //函数AId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.FuncAId) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.FuncAId, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.FuncAId] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureName">功能名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetFeatureName(this clsvFunctionRelaEN objvFunctionRelaEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFunctionRela.FeatureName);
objvFunctionRelaEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.FeatureName) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.FeatureName, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.FeatureName] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetOrderNum(this clsvFunctionRelaEN objvFunctionRelaEN, int intOrderNum, string strComparisonOp="")
	{
objvFunctionRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.OrderNum) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.OrderNum, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.OrderNum] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrder4FeatureNum">Order4FeatureNum</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetOrder4FeatureNum(this clsvFunctionRelaEN objvFunctionRelaEN, int intOrder4FeatureNum, string strComparisonOp="")
	{
objvFunctionRelaEN.Order4FeatureNum = intOrder4FeatureNum; //Order4FeatureNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.Order4FeatureNum) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.Order4FeatureNum, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.Order4FeatureNum] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncBId">函数BId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetFuncBId(this clsvFunctionRelaEN objvFunctionRelaEN, string strFuncBId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncBId, convFunctionRela.FuncBId);
clsCheckSql.CheckFieldLen(strFuncBId, 10, convFunctionRela.FuncBId);
clsCheckSql.CheckFieldForeignKey(strFuncBId, 10, convFunctionRela.FuncBId);
objvFunctionRelaEN.FuncBId = strFuncBId; //函数BId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.FuncBId) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.FuncBId, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.FuncBId] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionRelaTypeId">函数关系类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetFunctionRelaTypeId(this clsvFunctionRelaEN objvFunctionRelaEN, string strFunctionRelaTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionRelaTypeId, convFunctionRela.FunctionRelaTypeId);
clsCheckSql.CheckFieldLen(strFunctionRelaTypeId, 2, convFunctionRela.FunctionRelaTypeId);
clsCheckSql.CheckFieldForeignKey(strFunctionRelaTypeId, 2, convFunctionRela.FunctionRelaTypeId);
objvFunctionRelaEN.FunctionRelaTypeId = strFunctionRelaTypeId; //函数关系类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.FunctionRelaTypeId) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.FunctionRelaTypeId, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.FunctionRelaTypeId] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionRelaTypeName">函数关系类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetFunctionRelaTypeName(this clsvFunctionRelaEN objvFunctionRelaEN, string strFunctionRelaTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionRelaTypeName, 30, convFunctionRela.FunctionRelaTypeName);
objvFunctionRelaEN.FunctionRelaTypeName = strFunctionRelaTypeName; //函数关系类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.FunctionRelaTypeName) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.FunctionRelaTypeName, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.FunctionRelaTypeName] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetUpdDate(this clsvFunctionRelaEN objvFunctionRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFunctionRela.UpdDate);
objvFunctionRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.UpdDate) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.UpdDate, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.UpdDate] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetUpdUser(this clsvFunctionRelaEN objvFunctionRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFunctionRela.UpdUser);
objvFunctionRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.UpdUser) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.UpdUser, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.UpdUser] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetMemo(this clsvFunctionRelaEN objvFunctionRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunctionRela.Memo);
objvFunctionRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.Memo) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.Memo, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.Memo] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncAName">FuncAName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetFuncAName(this clsvFunctionRelaEN objvFunctionRelaEN, string strFuncAName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncAName, 100, convFunctionRela.FuncAName);
objvFunctionRelaEN.FuncAName = strFuncAName; //FuncAName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.FuncAName) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.FuncAName, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.FuncAName] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeIdA">ProgLangTypeIdA</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetProgLangTypeIdA(this clsvFunctionRelaEN objvFunctionRelaEN, string strProgLangTypeIdA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeIdA, 2, convFunctionRela.ProgLangTypeIdA);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeIdA, 2, convFunctionRela.ProgLangTypeIdA);
objvFunctionRelaEN.ProgLangTypeIdA = strProgLangTypeIdA; //ProgLangTypeIdA
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.ProgLangTypeIdA) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.ProgLangTypeIdA, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.ProgLangTypeIdA] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeNameA">ProgLangTypeNameA</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetProgLangTypeNameA(this clsvFunctionRelaEN objvFunctionRelaEN, string strProgLangTypeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeNameA, 30, convFunctionRela.ProgLangTypeNameA);
objvFunctionRelaEN.ProgLangTypeNameA = strProgLangTypeNameA; //ProgLangTypeNameA
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.ProgLangTypeNameA) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.ProgLangTypeNameA, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.ProgLangTypeNameA] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncBName">FuncBName</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetFuncBName(this clsvFunctionRelaEN objvFunctionRelaEN, string strFuncBName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncBName, 100, convFunctionRela.FuncBName);
objvFunctionRelaEN.FuncBName = strFuncBName; //FuncBName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.FuncBName) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.FuncBName, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.FuncBName] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeIdB">ProgLangTypeIdB</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetProgLangTypeIdB(this clsvFunctionRelaEN objvFunctionRelaEN, string strProgLangTypeIdB, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeIdB, 2, convFunctionRela.ProgLangTypeIdB);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeIdB, 2, convFunctionRela.ProgLangTypeIdB);
objvFunctionRelaEN.ProgLangTypeIdB = strProgLangTypeIdB; //ProgLangTypeIdB
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.ProgLangTypeIdB) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.ProgLangTypeIdB, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.ProgLangTypeIdB] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeNameB">ProgLangTypeNameB</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetProgLangTypeNameB(this clsvFunctionRelaEN objvFunctionRelaEN, string strProgLangTypeNameB, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeNameB, 30, convFunctionRela.ProgLangTypeNameB);
objvFunctionRelaEN.ProgLangTypeNameB = strProgLangTypeNameB; //ProgLangTypeNameB
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionRelaEN.dicFldComparisonOp.ContainsKey(convFunctionRela.ProgLangTypeNameB) == false)
{
objvFunctionRelaEN.dicFldComparisonOp.Add(convFunctionRela.ProgLangTypeNameB, strComparisonOp);
}
else
{
objvFunctionRelaEN.dicFldComparisonOp[convFunctionRela.ProgLangTypeNameB] = strComparisonOp;
}
}
return objvFunctionRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunctionRelaEN objvFunctionRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.mId) == true)
{
string strComparisonOpmId = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFunctionRela.mId, objvFunctionRelaCond.mId, strComparisonOpmId);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.FuncAId) == true)
{
string strComparisonOpFuncAId = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.FuncAId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionRela.FuncAId, objvFunctionRelaCond.FuncAId, strComparisonOpFuncAId);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.FeatureName) == true)
{
string strComparisonOpFeatureName = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionRela.FeatureName, objvFunctionRelaCond.FeatureName, strComparisonOpFeatureName);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFunctionRela.OrderNum, objvFunctionRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.Order4FeatureNum) == true)
{
string strComparisonOpOrder4FeatureNum = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.Order4FeatureNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFunctionRela.Order4FeatureNum, objvFunctionRelaCond.Order4FeatureNum, strComparisonOpOrder4FeatureNum);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.FuncBId) == true)
{
string strComparisonOpFuncBId = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.FuncBId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionRela.FuncBId, objvFunctionRelaCond.FuncBId, strComparisonOpFuncBId);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.FunctionRelaTypeId) == true)
{
string strComparisonOpFunctionRelaTypeId = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.FunctionRelaTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionRela.FunctionRelaTypeId, objvFunctionRelaCond.FunctionRelaTypeId, strComparisonOpFunctionRelaTypeId);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.FunctionRelaTypeName) == true)
{
string strComparisonOpFunctionRelaTypeName = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.FunctionRelaTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionRela.FunctionRelaTypeName, objvFunctionRelaCond.FunctionRelaTypeName, strComparisonOpFunctionRelaTypeName);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionRela.UpdDate, objvFunctionRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionRela.UpdUser, objvFunctionRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.Memo) == true)
{
string strComparisonOpMemo = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionRela.Memo, objvFunctionRelaCond.Memo, strComparisonOpMemo);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.FuncAName) == true)
{
string strComparisonOpFuncAName = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.FuncAName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionRela.FuncAName, objvFunctionRelaCond.FuncAName, strComparisonOpFuncAName);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.ProgLangTypeIdA) == true)
{
string strComparisonOpProgLangTypeIdA = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.ProgLangTypeIdA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionRela.ProgLangTypeIdA, objvFunctionRelaCond.ProgLangTypeIdA, strComparisonOpProgLangTypeIdA);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.ProgLangTypeNameA) == true)
{
string strComparisonOpProgLangTypeNameA = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.ProgLangTypeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionRela.ProgLangTypeNameA, objvFunctionRelaCond.ProgLangTypeNameA, strComparisonOpProgLangTypeNameA);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.FuncBName) == true)
{
string strComparisonOpFuncBName = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.FuncBName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionRela.FuncBName, objvFunctionRelaCond.FuncBName, strComparisonOpFuncBName);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.ProgLangTypeIdB) == true)
{
string strComparisonOpProgLangTypeIdB = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.ProgLangTypeIdB];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionRela.ProgLangTypeIdB, objvFunctionRelaCond.ProgLangTypeIdB, strComparisonOpProgLangTypeIdB);
}
if (objvFunctionRelaCond.IsUpdated(convFunctionRela.ProgLangTypeNameB) == true)
{
string strComparisonOpProgLangTypeNameB = objvFunctionRelaCond.dicFldComparisonOp[convFunctionRela.ProgLangTypeNameB];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionRela.ProgLangTypeNameB, objvFunctionRelaCond.ProgLangTypeNameB, strComparisonOpProgLangTypeNameB);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v函数与函数关系(vFunctionRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvFunctionRelaWApi
{
private static readonly string mstrApiControllerName = "vFunctionRelaApi";

 public clsvFunctionRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvFunctionRelaEN objvFunctionRelaEN;
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
objvFunctionRelaEN = JsonConvert.DeserializeObject<clsvFunctionRelaEN>(strJson);
return objvFunctionRelaEN;
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
public static clsvFunctionRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvFunctionRelaEN objvFunctionRelaEN;
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
objvFunctionRelaEN = JsonConvert.DeserializeObject<clsvFunctionRelaEN>(strJson);
return objvFunctionRelaEN;
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
public static clsvFunctionRelaEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunctionRelaEN._CurrTabName);
List<clsvFunctionRelaEN> arrvFunctionRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionRelaEN> arrvFunctionRelaObjLst_Sel =
from objvFunctionRelaEN in arrvFunctionRelaObjLstCache
where objvFunctionRelaEN.mId == lngmId 
select objvFunctionRelaEN;
if (arrvFunctionRelaObjLst_Sel.Count() == 0)
{
   clsvFunctionRelaEN obj = clsvFunctionRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvFunctionRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvFunctionRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionRelaEN>>(strJson);
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
public static List<clsvFunctionRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvFunctionRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionRelaEN>>(strJson);
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
public static IEnumerable<clsvFunctionRelaEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvFunctionRelaEN._CurrTabName);
List<clsvFunctionRelaEN> arrvFunctionRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionRelaEN> arrvFunctionRelaObjLst_Sel =
from objvFunctionRelaEN in arrvFunctionRelaObjLstCache
where arrMId.Contains(objvFunctionRelaEN.mId)
select objvFunctionRelaEN;
return arrvFunctionRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvFunctionRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionRelaEN>>(strJson);
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
public static List<clsvFunctionRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvFunctionRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionRelaEN>>(strJson);
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
public static List<clsvFunctionRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvFunctionRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionRelaEN>>(strJson);
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
public static List<clsvFunctionRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvFunctionRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvFunctionRelaEN>>(strJson);
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
 /// <param name = "objvFunctionRelaENS">源对象</param>
 /// <param name = "objvFunctionRelaENT">目标对象</param>
 public static void CopyTo(clsvFunctionRelaEN objvFunctionRelaENS, clsvFunctionRelaEN objvFunctionRelaENT)
{
try
{
objvFunctionRelaENT.mId = objvFunctionRelaENS.mId; //mId
objvFunctionRelaENT.FuncAId = objvFunctionRelaENS.FuncAId; //函数AId
objvFunctionRelaENT.FeatureName = objvFunctionRelaENS.FeatureName; //功能名称
objvFunctionRelaENT.OrderNum = objvFunctionRelaENS.OrderNum; //序号
objvFunctionRelaENT.Order4FeatureNum = objvFunctionRelaENS.Order4FeatureNum; //Order4FeatureNum
objvFunctionRelaENT.FuncBId = objvFunctionRelaENS.FuncBId; //函数BId
objvFunctionRelaENT.FunctionRelaTypeId = objvFunctionRelaENS.FunctionRelaTypeId; //函数关系类型Id
objvFunctionRelaENT.FunctionRelaTypeName = objvFunctionRelaENS.FunctionRelaTypeName; //函数关系类型名称
objvFunctionRelaENT.UpdDate = objvFunctionRelaENS.UpdDate; //修改日期
objvFunctionRelaENT.UpdUser = objvFunctionRelaENS.UpdUser; //修改者
objvFunctionRelaENT.Memo = objvFunctionRelaENS.Memo; //说明
objvFunctionRelaENT.FuncAName = objvFunctionRelaENS.FuncAName; //FuncAName
objvFunctionRelaENT.ProgLangTypeIdA = objvFunctionRelaENS.ProgLangTypeIdA; //ProgLangTypeIdA
objvFunctionRelaENT.ProgLangTypeNameA = objvFunctionRelaENS.ProgLangTypeNameA; //ProgLangTypeNameA
objvFunctionRelaENT.FuncBName = objvFunctionRelaENS.FuncBName; //FuncBName
objvFunctionRelaENT.ProgLangTypeIdB = objvFunctionRelaENS.ProgLangTypeIdB; //ProgLangTypeIdB
objvFunctionRelaENT.ProgLangTypeNameB = objvFunctionRelaENS.ProgLangTypeNameB; //ProgLangTypeNameB
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
public static DataTable ToDataTable(List<clsvFunctionRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvFunctionRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvFunctionRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvFunctionRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvFunctionRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvFunctionRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvFunctionRelaEN._CurrTabName);
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
public static List<clsvFunctionRelaEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvFunctionRelaEN._CurrTabName;
List<clsvFunctionRelaEN> arrvFunctionRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvFunctionRelaObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvFunctionRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convFunctionRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convFunctionRela.FuncAId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionRela.FeatureName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFunctionRela.Order4FeatureNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convFunctionRela.FuncBId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionRela.FunctionRelaTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionRela.FunctionRelaTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionRela.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionRela.FuncAName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionRela.ProgLangTypeIdA, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionRela.ProgLangTypeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionRela.FuncBName, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionRela.ProgLangTypeIdB, Type.GetType("System.String"));
objDT.Columns.Add(convFunctionRela.ProgLangTypeNameB, Type.GetType("System.String"));
foreach (clsvFunctionRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convFunctionRela.mId] = objInFor[convFunctionRela.mId];
objDR[convFunctionRela.FuncAId] = objInFor[convFunctionRela.FuncAId];
objDR[convFunctionRela.FeatureName] = objInFor[convFunctionRela.FeatureName];
objDR[convFunctionRela.OrderNum] = objInFor[convFunctionRela.OrderNum];
objDR[convFunctionRela.Order4FeatureNum] = objInFor[convFunctionRela.Order4FeatureNum];
objDR[convFunctionRela.FuncBId] = objInFor[convFunctionRela.FuncBId];
objDR[convFunctionRela.FunctionRelaTypeId] = objInFor[convFunctionRela.FunctionRelaTypeId];
objDR[convFunctionRela.FunctionRelaTypeName] = objInFor[convFunctionRela.FunctionRelaTypeName];
objDR[convFunctionRela.UpdDate] = objInFor[convFunctionRela.UpdDate];
objDR[convFunctionRela.UpdUser] = objInFor[convFunctionRela.UpdUser];
objDR[convFunctionRela.Memo] = objInFor[convFunctionRela.Memo];
objDR[convFunctionRela.FuncAName] = objInFor[convFunctionRela.FuncAName];
objDR[convFunctionRela.ProgLangTypeIdA] = objInFor[convFunctionRela.ProgLangTypeIdA];
objDR[convFunctionRela.ProgLangTypeNameA] = objInFor[convFunctionRela.ProgLangTypeNameA];
objDR[convFunctionRela.FuncBName] = objInFor[convFunctionRela.FuncBName];
objDR[convFunctionRela.ProgLangTypeIdB] = objInFor[convFunctionRela.ProgLangTypeIdB];
objDR[convFunctionRela.ProgLangTypeNameB] = objInFor[convFunctionRela.ProgLangTypeNameB];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}