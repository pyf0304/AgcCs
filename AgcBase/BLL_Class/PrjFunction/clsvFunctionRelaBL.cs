
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionRelaBL
 表名:vFunctionRela(00050321)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:22
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
public static class  clsvFunctionRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionRelaEN GetObj(this K_mId_vFunctionRela myKey)
{
clsvFunctionRelaEN objvFunctionRelaEN = clsvFunctionRelaBL.vFunctionRelaDA.GetObjBymId(myKey.Value);
return objvFunctionRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetFuncAId(this clsvFunctionRelaEN objvFunctionRelaEN, string strFuncAId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncAId, convFunctionRela.FuncAId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncAId, 10, convFunctionRela.FuncAId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncAId, 10, convFunctionRela.FuncAId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetFeatureName(this clsvFunctionRelaEN objvFunctionRelaEN, string strFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFunctionRela.FeatureName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetOrderNum(this clsvFunctionRelaEN objvFunctionRelaEN, int? intOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetOrder4FeatureNum(this clsvFunctionRelaEN objvFunctionRelaEN, int? intOrder4FeatureNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetFuncBId(this clsvFunctionRelaEN objvFunctionRelaEN, string strFuncBId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncBId, convFunctionRela.FuncBId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncBId, 10, convFunctionRela.FuncBId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncBId, 10, convFunctionRela.FuncBId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetFunctionRelaTypeId(this clsvFunctionRelaEN objvFunctionRelaEN, string strFunctionRelaTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionRelaTypeId, convFunctionRela.FunctionRelaTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionRelaTypeId, 2, convFunctionRela.FunctionRelaTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionRelaTypeId, 2, convFunctionRela.FunctionRelaTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetFunctionRelaTypeName(this clsvFunctionRelaEN objvFunctionRelaEN, string strFunctionRelaTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionRelaTypeName, 30, convFunctionRela.FunctionRelaTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetUpdDate(this clsvFunctionRelaEN objvFunctionRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFunctionRela.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetUpdUser(this clsvFunctionRelaEN objvFunctionRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFunctionRela.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetMemo(this clsvFunctionRelaEN objvFunctionRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunctionRela.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetFuncAName(this clsvFunctionRelaEN objvFunctionRelaEN, string strFuncAName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncAName, 100, convFunctionRela.FuncAName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetProgLangTypeIdA(this clsvFunctionRelaEN objvFunctionRelaEN, string strProgLangTypeIdA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeIdA, 2, convFunctionRela.ProgLangTypeIdA);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeIdA, 2, convFunctionRela.ProgLangTypeIdA);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetProgLangTypeNameA(this clsvFunctionRelaEN objvFunctionRelaEN, string strProgLangTypeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeNameA, 30, convFunctionRela.ProgLangTypeNameA);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetFuncBName(this clsvFunctionRelaEN objvFunctionRelaEN, string strFuncBName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncBName, 100, convFunctionRela.FuncBName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetProgLangTypeIdB(this clsvFunctionRelaEN objvFunctionRelaEN, string strProgLangTypeIdB, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeIdB, 2, convFunctionRela.ProgLangTypeIdB);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeIdB, 2, convFunctionRela.ProgLangTypeIdB);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionRelaEN SetProgLangTypeNameB(this clsvFunctionRelaEN objvFunctionRelaEN, string strProgLangTypeNameB, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeNameB, 30, convFunctionRela.ProgLangTypeNameB);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFunctionRelaENS">源对象</param>
 /// <param name = "objvFunctionRelaENT">目标对象</param>
 public static void CopyTo(this clsvFunctionRelaEN objvFunctionRelaENS, clsvFunctionRelaEN objvFunctionRelaENT)
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
 /// <param name = "objvFunctionRelaENS">源对象</param>
 /// <returns>目标对象=>clsvFunctionRelaEN:objvFunctionRelaENT</returns>
 public static clsvFunctionRelaEN CopyTo(this clsvFunctionRelaEN objvFunctionRelaENS)
{
try
{
 clsvFunctionRelaEN objvFunctionRelaENT = new clsvFunctionRelaEN()
{
mId = objvFunctionRelaENS.mId, //mId
FuncAId = objvFunctionRelaENS.FuncAId, //函数AId
FeatureName = objvFunctionRelaENS.FeatureName, //功能名称
OrderNum = objvFunctionRelaENS.OrderNum, //序号
Order4FeatureNum = objvFunctionRelaENS.Order4FeatureNum, //Order4FeatureNum
FuncBId = objvFunctionRelaENS.FuncBId, //函数BId
FunctionRelaTypeId = objvFunctionRelaENS.FunctionRelaTypeId, //函数关系类型Id
FunctionRelaTypeName = objvFunctionRelaENS.FunctionRelaTypeName, //函数关系类型名称
UpdDate = objvFunctionRelaENS.UpdDate, //修改日期
UpdUser = objvFunctionRelaENS.UpdUser, //修改者
Memo = objvFunctionRelaENS.Memo, //说明
FuncAName = objvFunctionRelaENS.FuncAName, //FuncAName
ProgLangTypeIdA = objvFunctionRelaENS.ProgLangTypeIdA, //ProgLangTypeIdA
ProgLangTypeNameA = objvFunctionRelaENS.ProgLangTypeNameA, //ProgLangTypeNameA
FuncBName = objvFunctionRelaENS.FuncBName, //FuncBName
ProgLangTypeIdB = objvFunctionRelaENS.ProgLangTypeIdB, //ProgLangTypeIdB
ProgLangTypeNameB = objvFunctionRelaENS.ProgLangTypeNameB, //ProgLangTypeNameB
};
 return objvFunctionRelaENT;
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
public static void CheckProperty4Condition(this clsvFunctionRelaEN objvFunctionRelaEN)
{
 clsvFunctionRelaBL.vFunctionRelaDA.CheckProperty4Condition(objvFunctionRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFunctionRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v函数与函数关系(vFunctionRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFunctionRelaBL
{
public static RelatedActions_vFunctionRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFunctionRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFunctionRelaDA vFunctionRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFunctionRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFunctionRelaBL()
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
if (string.IsNullOrEmpty(clsvFunctionRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunctionRelaEN._ConnectString);
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
public static DataTable GetDataTable_vFunctionRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFunctionRelaDA.GetDataTable_vFunctionRela(strWhereCond);
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
objDT = vFunctionRelaDA.GetDataTable(strWhereCond);
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
objDT = vFunctionRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFunctionRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFunctionRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFunctionRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vFunctionRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFunctionRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFunctionRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvFunctionRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvFunctionRelaEN> arrObjLst = new List<clsvFunctionRelaEN>(); 
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
	clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN();
try
{
objvFunctionRelaEN.mId = Int32.Parse(objRow[convFunctionRela.mId].ToString().Trim()); //mId
objvFunctionRelaEN.FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(); //函数AId
objvFunctionRelaEN.FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(); //功能名称
objvFunctionRelaEN.OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.OrderNum].ToString().Trim()); //序号
objvFunctionRelaEN.Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunctionRelaEN.FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(); //函数BId
objvFunctionRelaEN.FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objvFunctionRelaEN.FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objvFunctionRelaEN.UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionRelaEN.UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(); //修改者
objvFunctionRelaEN.Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(); //说明
objvFunctionRelaEN.FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(); //FuncAName
objvFunctionRelaEN.ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA
objvFunctionRelaEN.ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA
objvFunctionRelaEN.FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(); //FuncBName
objvFunctionRelaEN.ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB
objvFunctionRelaEN.ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFunctionRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvFunctionRelaEN._CurrTabName);
List<clsvFunctionRelaEN> arrvFunctionRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionRelaEN> arrvFunctionRelaObjLst_Sel =
arrvFunctionRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvFunctionRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionRelaEN> GetObjLst(string strWhereCond)
{
List<clsvFunctionRelaEN> arrObjLst = new List<clsvFunctionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN();
try
{
objvFunctionRelaEN.mId = Int32.Parse(objRow[convFunctionRela.mId].ToString().Trim()); //mId
objvFunctionRelaEN.FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(); //函数AId
objvFunctionRelaEN.FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(); //功能名称
objvFunctionRelaEN.OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.OrderNum].ToString().Trim()); //序号
objvFunctionRelaEN.Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunctionRelaEN.FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(); //函数BId
objvFunctionRelaEN.FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objvFunctionRelaEN.FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objvFunctionRelaEN.UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionRelaEN.UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(); //修改者
objvFunctionRelaEN.Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(); //说明
objvFunctionRelaEN.FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(); //FuncAName
objvFunctionRelaEN.ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA
objvFunctionRelaEN.ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA
objvFunctionRelaEN.FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(); //FuncBName
objvFunctionRelaEN.ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB
objvFunctionRelaEN.ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionRelaEN);
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
public static List<clsvFunctionRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFunctionRelaEN> arrObjLst = new List<clsvFunctionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN();
try
{
objvFunctionRelaEN.mId = Int32.Parse(objRow[convFunctionRela.mId].ToString().Trim()); //mId
objvFunctionRelaEN.FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(); //函数AId
objvFunctionRelaEN.FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(); //功能名称
objvFunctionRelaEN.OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.OrderNum].ToString().Trim()); //序号
objvFunctionRelaEN.Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunctionRelaEN.FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(); //函数BId
objvFunctionRelaEN.FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objvFunctionRelaEN.FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objvFunctionRelaEN.UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionRelaEN.UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(); //修改者
objvFunctionRelaEN.Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(); //说明
objvFunctionRelaEN.FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(); //FuncAName
objvFunctionRelaEN.ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA
objvFunctionRelaEN.ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA
objvFunctionRelaEN.FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(); //FuncBName
objvFunctionRelaEN.ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB
objvFunctionRelaEN.ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFunctionRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFunctionRelaEN> GetSubObjLstCache(clsvFunctionRelaEN objvFunctionRelaCond)
{
List<clsvFunctionRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunctionRela._AttributeName)
{
if (objvFunctionRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFunctionRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionRelaCond[strFldName].ToString());
}
else
{
if (objvFunctionRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunctionRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunctionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunctionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunctionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunctionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunctionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunctionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunctionRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunctionRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunctionRelaCond[strFldName]));
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
public static List<clsvFunctionRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFunctionRelaEN> arrObjLst = new List<clsvFunctionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN();
try
{
objvFunctionRelaEN.mId = Int32.Parse(objRow[convFunctionRela.mId].ToString().Trim()); //mId
objvFunctionRelaEN.FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(); //函数AId
objvFunctionRelaEN.FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(); //功能名称
objvFunctionRelaEN.OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.OrderNum].ToString().Trim()); //序号
objvFunctionRelaEN.Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunctionRelaEN.FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(); //函数BId
objvFunctionRelaEN.FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objvFunctionRelaEN.FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objvFunctionRelaEN.UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionRelaEN.UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(); //修改者
objvFunctionRelaEN.Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(); //说明
objvFunctionRelaEN.FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(); //FuncAName
objvFunctionRelaEN.ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA
objvFunctionRelaEN.ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA
objvFunctionRelaEN.FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(); //FuncBName
objvFunctionRelaEN.ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB
objvFunctionRelaEN.ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionRelaEN);
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
public static List<clsvFunctionRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFunctionRelaEN> arrObjLst = new List<clsvFunctionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN();
try
{
objvFunctionRelaEN.mId = Int32.Parse(objRow[convFunctionRela.mId].ToString().Trim()); //mId
objvFunctionRelaEN.FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(); //函数AId
objvFunctionRelaEN.FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(); //功能名称
objvFunctionRelaEN.OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.OrderNum].ToString().Trim()); //序号
objvFunctionRelaEN.Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunctionRelaEN.FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(); //函数BId
objvFunctionRelaEN.FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objvFunctionRelaEN.FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objvFunctionRelaEN.UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionRelaEN.UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(); //修改者
objvFunctionRelaEN.Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(); //说明
objvFunctionRelaEN.FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(); //FuncAName
objvFunctionRelaEN.ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA
objvFunctionRelaEN.ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA
objvFunctionRelaEN.FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(); //FuncBName
objvFunctionRelaEN.ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB
objvFunctionRelaEN.ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionRelaEN);
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
List<clsvFunctionRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFunctionRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFunctionRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFunctionRelaEN> arrObjLst = new List<clsvFunctionRelaEN>(); 
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
	clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN();
try
{
objvFunctionRelaEN.mId = Int32.Parse(objRow[convFunctionRela.mId].ToString().Trim()); //mId
objvFunctionRelaEN.FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(); //函数AId
objvFunctionRelaEN.FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(); //功能名称
objvFunctionRelaEN.OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.OrderNum].ToString().Trim()); //序号
objvFunctionRelaEN.Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunctionRelaEN.FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(); //函数BId
objvFunctionRelaEN.FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objvFunctionRelaEN.FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objvFunctionRelaEN.UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionRelaEN.UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(); //修改者
objvFunctionRelaEN.Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(); //说明
objvFunctionRelaEN.FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(); //FuncAName
objvFunctionRelaEN.ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA
objvFunctionRelaEN.ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA
objvFunctionRelaEN.FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(); //FuncBName
objvFunctionRelaEN.ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB
objvFunctionRelaEN.ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionRelaEN);
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
public static List<clsvFunctionRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFunctionRelaEN> arrObjLst = new List<clsvFunctionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN();
try
{
objvFunctionRelaEN.mId = Int32.Parse(objRow[convFunctionRela.mId].ToString().Trim()); //mId
objvFunctionRelaEN.FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(); //函数AId
objvFunctionRelaEN.FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(); //功能名称
objvFunctionRelaEN.OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.OrderNum].ToString().Trim()); //序号
objvFunctionRelaEN.Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunctionRelaEN.FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(); //函数BId
objvFunctionRelaEN.FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objvFunctionRelaEN.FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objvFunctionRelaEN.UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionRelaEN.UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(); //修改者
objvFunctionRelaEN.Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(); //说明
objvFunctionRelaEN.FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(); //FuncAName
objvFunctionRelaEN.ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA
objvFunctionRelaEN.ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA
objvFunctionRelaEN.FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(); //FuncBName
objvFunctionRelaEN.ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB
objvFunctionRelaEN.ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFunctionRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFunctionRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFunctionRelaEN> arrObjLst = new List<clsvFunctionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN();
try
{
objvFunctionRelaEN.mId = Int32.Parse(objRow[convFunctionRela.mId].ToString().Trim()); //mId
objvFunctionRelaEN.FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(); //函数AId
objvFunctionRelaEN.FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(); //功能名称
objvFunctionRelaEN.OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.OrderNum].ToString().Trim()); //序号
objvFunctionRelaEN.Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunctionRelaEN.FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(); //函数BId
objvFunctionRelaEN.FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objvFunctionRelaEN.FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objvFunctionRelaEN.UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionRelaEN.UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(); //修改者
objvFunctionRelaEN.Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(); //说明
objvFunctionRelaEN.FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(); //FuncAName
objvFunctionRelaEN.ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA
objvFunctionRelaEN.ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA
objvFunctionRelaEN.FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(); //FuncBName
objvFunctionRelaEN.ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB
objvFunctionRelaEN.ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionRelaEN);
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
public static List<clsvFunctionRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFunctionRelaEN> arrObjLst = new List<clsvFunctionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN();
try
{
objvFunctionRelaEN.mId = Int32.Parse(objRow[convFunctionRela.mId].ToString().Trim()); //mId
objvFunctionRelaEN.FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(); //函数AId
objvFunctionRelaEN.FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(); //功能名称
objvFunctionRelaEN.OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.OrderNum].ToString().Trim()); //序号
objvFunctionRelaEN.Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunctionRelaEN.FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(); //函数BId
objvFunctionRelaEN.FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objvFunctionRelaEN.FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objvFunctionRelaEN.UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionRelaEN.UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(); //修改者
objvFunctionRelaEN.Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(); //说明
objvFunctionRelaEN.FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(); //FuncAName
objvFunctionRelaEN.ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA
objvFunctionRelaEN.ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA
objvFunctionRelaEN.FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(); //FuncBName
objvFunctionRelaEN.ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB
objvFunctionRelaEN.ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFunctionRelaEN> arrObjLst = new List<clsvFunctionRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionRelaEN objvFunctionRelaEN = new clsvFunctionRelaEN();
try
{
objvFunctionRelaEN.mId = Int32.Parse(objRow[convFunctionRela.mId].ToString().Trim()); //mId
objvFunctionRelaEN.FuncAId = objRow[convFunctionRela.FuncAId].ToString().Trim(); //函数AId
objvFunctionRelaEN.FeatureName = objRow[convFunctionRela.FeatureName] == DBNull.Value ? null : objRow[convFunctionRela.FeatureName].ToString().Trim(); //功能名称
objvFunctionRelaEN.OrderNum = objRow[convFunctionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.OrderNum].ToString().Trim()); //序号
objvFunctionRelaEN.Order4FeatureNum = objRow[convFunctionRela.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunctionRela.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunctionRelaEN.FuncBId = objRow[convFunctionRela.FuncBId].ToString().Trim(); //函数BId
objvFunctionRelaEN.FunctionRelaTypeId = objRow[convFunctionRela.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objvFunctionRelaEN.FunctionRelaTypeName = objRow[convFunctionRela.FunctionRelaTypeName] == DBNull.Value ? null : objRow[convFunctionRela.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objvFunctionRelaEN.UpdDate = objRow[convFunctionRela.UpdDate] == DBNull.Value ? null : objRow[convFunctionRela.UpdDate].ToString().Trim(); //修改日期
objvFunctionRelaEN.UpdUser = objRow[convFunctionRela.UpdUser] == DBNull.Value ? null : objRow[convFunctionRela.UpdUser].ToString().Trim(); //修改者
objvFunctionRelaEN.Memo = objRow[convFunctionRela.Memo] == DBNull.Value ? null : objRow[convFunctionRela.Memo].ToString().Trim(); //说明
objvFunctionRelaEN.FuncAName = objRow[convFunctionRela.FuncAName] == DBNull.Value ? null : objRow[convFunctionRela.FuncAName].ToString().Trim(); //FuncAName
objvFunctionRelaEN.ProgLangTypeIdA = objRow[convFunctionRela.ProgLangTypeIdA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdA].ToString().Trim(); //ProgLangTypeIdA
objvFunctionRelaEN.ProgLangTypeNameA = objRow[convFunctionRela.ProgLangTypeNameA] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameA].ToString().Trim(); //ProgLangTypeNameA
objvFunctionRelaEN.FuncBName = objRow[convFunctionRela.FuncBName] == DBNull.Value ? null : objRow[convFunctionRela.FuncBName].ToString().Trim(); //FuncBName
objvFunctionRelaEN.ProgLangTypeIdB = objRow[convFunctionRela.ProgLangTypeIdB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeIdB].ToString().Trim(); //ProgLangTypeIdB
objvFunctionRelaEN.ProgLangTypeNameB = objRow[convFunctionRela.ProgLangTypeNameB] == DBNull.Value ? null : objRow[convFunctionRela.ProgLangTypeNameB].ToString().Trim(); //ProgLangTypeNameB
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFunctionRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFunctionRela(ref clsvFunctionRelaEN objvFunctionRelaEN)
{
bool bolResult = vFunctionRelaDA.GetvFunctionRela(ref objvFunctionRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionRelaEN GetObjBymId(long lngmId)
{
clsvFunctionRelaEN objvFunctionRelaEN = vFunctionRelaDA.GetObjBymId(lngmId);
return objvFunctionRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFunctionRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFunctionRelaEN objvFunctionRelaEN = vFunctionRelaDA.GetFirstObj(strWhereCond);
 return objvFunctionRelaEN;
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
public static clsvFunctionRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFunctionRelaEN objvFunctionRelaEN = vFunctionRelaDA.GetObjByDataRow(objRow);
 return objvFunctionRelaEN;
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
public static clsvFunctionRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFunctionRelaEN objvFunctionRelaEN = vFunctionRelaDA.GetObjByDataRow(objRow);
 return objvFunctionRelaEN;
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
 /// <param name = "lstvFunctionRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionRelaEN GetObjBymIdFromList(long lngmId, List<clsvFunctionRelaEN> lstvFunctionRelaObjLst)
{
foreach (clsvFunctionRelaEN objvFunctionRelaEN in lstvFunctionRelaObjLst)
{
if (objvFunctionRelaEN.mId == lngmId)
{
return objvFunctionRelaEN;
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
 lngmId = new clsvFunctionRelaDA().GetFirstID(strWhereCond);
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
 arrList = vFunctionRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vFunctionRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vFunctionRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvFunctionRelaDA.IsExistTable();
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
 bolIsExist = vFunctionRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvFunctionRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvFunctionRelaEN objvFunctionRelaEN)
{
try
{
objvFunctionRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFunctionRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFunctionRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.mId = objvFunctionRelaEN.mId; //mId
}
if (arrFldSet.Contains(convFunctionRela.FuncAId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.FuncAId = objvFunctionRelaEN.FuncAId; //函数AId
}
if (arrFldSet.Contains(convFunctionRela.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.FeatureName = objvFunctionRelaEN.FeatureName == "[null]" ? null :  objvFunctionRelaEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convFunctionRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.OrderNum = objvFunctionRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convFunctionRela.Order4FeatureNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.Order4FeatureNum = objvFunctionRelaEN.Order4FeatureNum; //Order4FeatureNum
}
if (arrFldSet.Contains(convFunctionRela.FuncBId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.FuncBId = objvFunctionRelaEN.FuncBId; //函数BId
}
if (arrFldSet.Contains(convFunctionRela.FunctionRelaTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.FunctionRelaTypeId = objvFunctionRelaEN.FunctionRelaTypeId; //函数关系类型Id
}
if (arrFldSet.Contains(convFunctionRela.FunctionRelaTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.FunctionRelaTypeName = objvFunctionRelaEN.FunctionRelaTypeName == "[null]" ? null :  objvFunctionRelaEN.FunctionRelaTypeName; //函数关系类型名称
}
if (arrFldSet.Contains(convFunctionRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.UpdDate = objvFunctionRelaEN.UpdDate == "[null]" ? null :  objvFunctionRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFunctionRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.UpdUser = objvFunctionRelaEN.UpdUser == "[null]" ? null :  objvFunctionRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFunctionRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.Memo = objvFunctionRelaEN.Memo == "[null]" ? null :  objvFunctionRelaEN.Memo; //说明
}
if (arrFldSet.Contains(convFunctionRela.FuncAName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.FuncAName = objvFunctionRelaEN.FuncAName == "[null]" ? null :  objvFunctionRelaEN.FuncAName; //FuncAName
}
if (arrFldSet.Contains(convFunctionRela.ProgLangTypeIdA, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.ProgLangTypeIdA = objvFunctionRelaEN.ProgLangTypeIdA == "[null]" ? null :  objvFunctionRelaEN.ProgLangTypeIdA; //ProgLangTypeIdA
}
if (arrFldSet.Contains(convFunctionRela.ProgLangTypeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.ProgLangTypeNameA = objvFunctionRelaEN.ProgLangTypeNameA == "[null]" ? null :  objvFunctionRelaEN.ProgLangTypeNameA; //ProgLangTypeNameA
}
if (arrFldSet.Contains(convFunctionRela.FuncBName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.FuncBName = objvFunctionRelaEN.FuncBName == "[null]" ? null :  objvFunctionRelaEN.FuncBName; //FuncBName
}
if (arrFldSet.Contains(convFunctionRela.ProgLangTypeIdB, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.ProgLangTypeIdB = objvFunctionRelaEN.ProgLangTypeIdB == "[null]" ? null :  objvFunctionRelaEN.ProgLangTypeIdB; //ProgLangTypeIdB
}
if (arrFldSet.Contains(convFunctionRela.ProgLangTypeNameB, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionRelaEN.ProgLangTypeNameB = objvFunctionRelaEN.ProgLangTypeNameB == "[null]" ? null :  objvFunctionRelaEN.ProgLangTypeNameB; //ProgLangTypeNameB
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
 /// <param name = "objvFunctionRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFunctionRelaEN objvFunctionRelaEN)
{
try
{
if (objvFunctionRelaEN.FeatureName == "[null]") objvFunctionRelaEN.FeatureName = null; //功能名称
if (objvFunctionRelaEN.FunctionRelaTypeName == "[null]") objvFunctionRelaEN.FunctionRelaTypeName = null; //函数关系类型名称
if (objvFunctionRelaEN.UpdDate == "[null]") objvFunctionRelaEN.UpdDate = null; //修改日期
if (objvFunctionRelaEN.UpdUser == "[null]") objvFunctionRelaEN.UpdUser = null; //修改者
if (objvFunctionRelaEN.Memo == "[null]") objvFunctionRelaEN.Memo = null; //说明
if (objvFunctionRelaEN.FuncAName == "[null]") objvFunctionRelaEN.FuncAName = null; //FuncAName
if (objvFunctionRelaEN.ProgLangTypeIdA == "[null]") objvFunctionRelaEN.ProgLangTypeIdA = null; //ProgLangTypeIdA
if (objvFunctionRelaEN.ProgLangTypeNameA == "[null]") objvFunctionRelaEN.ProgLangTypeNameA = null; //ProgLangTypeNameA
if (objvFunctionRelaEN.FuncBName == "[null]") objvFunctionRelaEN.FuncBName = null; //FuncBName
if (objvFunctionRelaEN.ProgLangTypeIdB == "[null]") objvFunctionRelaEN.ProgLangTypeIdB = null; //ProgLangTypeIdB
if (objvFunctionRelaEN.ProgLangTypeNameB == "[null]") objvFunctionRelaEN.ProgLangTypeNameB = null; //ProgLangTypeNameB
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
public static void CheckProperty4Condition(clsvFunctionRelaEN objvFunctionRelaEN)
{
 vFunctionRelaDA.CheckProperty4Condition(objvFunctionRelaEN);
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
if (clsFunctionRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionRelaBL没有刷新缓存机制(clsFunctionRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionRelaTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionRelaTypeBL没有刷新缓存机制(clsFunctionRelaTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSQLDSTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProgLangTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProgLangTypeBL没有刷新缓存机制(clsProgLangTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunction4GeneCodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunction4GeneCodeBL没有刷新缓存机制(clsFunction4GeneCodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunction4CodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunction4CodeBL没有刷新缓存机制(clsFunction4CodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncGCTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncGCTypeBL没有刷新缓存机制(clsFuncGCTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvFunctionRelaObjLstCache == null)
//{
//arrvFunctionRelaObjLstCache = vFunctionRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFunctionRelaEN._CurrTabName);
List<clsvFunctionRelaEN> arrvFunctionRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionRelaEN> arrvFunctionRelaObjLst_Sel =
arrvFunctionRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvFunctionRelaObjLst_Sel.Count() == 0)
{
   clsvFunctionRelaEN obj = clsvFunctionRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFunctionRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunctionRelaEN> GetAllvFunctionRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvFunctionRelaEN> arrvFunctionRelaObjLstCache = GetObjLstCache(); 
return arrvFunctionRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunctionRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFunctionRelaEN._CurrTabName);
List<clsvFunctionRelaEN> arrvFunctionRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFunctionRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvFunctionRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFunctionRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFunctionRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvFunctionRelaEN._RefreshTimeLst[clsvFunctionRelaEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convFunctionRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFunctionRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFunctionRela._AttributeName));
throw new Exception(strMsg);
}
var objvFunctionRela = clsvFunctionRelaBL.GetObjBymIdCache(lngmId);
if (objvFunctionRela == null) return "";
return objvFunctionRela[strOutFldName].ToString();
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
int intRecCount = clsvFunctionRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvFunctionRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFunctionRelaDA.GetRecCount();
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
int intRecCount = clsvFunctionRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFunctionRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFunctionRelaEN objvFunctionRelaCond)
{
List<clsvFunctionRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunctionRela._AttributeName)
{
if (objvFunctionRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFunctionRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionRelaCond[strFldName].ToString());
}
else
{
if (objvFunctionRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunctionRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunctionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunctionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunctionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunctionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunctionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunctionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunctionRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunctionRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunctionRelaCond[strFldName]));
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
 List<string> arrList = clsvFunctionRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFunctionRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFunctionRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}