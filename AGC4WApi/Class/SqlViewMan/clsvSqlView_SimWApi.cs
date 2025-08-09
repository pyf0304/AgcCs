
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlView_SimWApi
 表名:vSqlView_Sim(00050298)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:08:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
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
public static class  clsvSqlView_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewId">Sql视图Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetSqlViewId(this clsvSqlView_SimEN objvSqlView_SimEN, string strSqlViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlViewId, 8, convSqlView_Sim.SqlViewId);
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, convSqlView_Sim.SqlViewId);
objvSqlView_SimEN.SqlViewId = strSqlViewId; //Sql视图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.SqlViewId) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.SqlViewId, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.SqlViewId] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewName">数据视图名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetSqlViewName(this clsvSqlView_SimEN objvSqlView_SimEN, string strSqlViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewName, convSqlView_Sim.SqlViewName);
clsCheckSql.CheckFieldLen(strSqlViewName, 100, convSqlView_Sim.SqlViewName);
objvSqlView_SimEN.SqlViewName = strSqlViewName; //数据视图名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.SqlViewName) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.SqlViewName, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.SqlViewName] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewCNName">Sql视图中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetSqlViewCNName(this clsvSqlView_SimEN objvSqlView_SimEN, string strSqlViewCNName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlViewCNName, 200, convSqlView_Sim.SqlViewCNName);
objvSqlView_SimEN.SqlViewCNName = strSqlViewCNName; //Sql视图中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.SqlViewCNName) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.SqlViewCNName, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.SqlViewCNName] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewText">Sql视图文本内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetSqlViewText(this clsvSqlView_SimEN objvSqlView_SimEN, string strSqlViewText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlViewText, 8000, convSqlView_Sim.SqlViewText);
objvSqlView_SimEN.SqlViewText = strSqlViewText; //Sql视图文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.SqlViewText) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.SqlViewText, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.SqlViewText] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewText4Gene">Sql视图文本4生成</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetSqlViewText4Gene(this clsvSqlView_SimEN objvSqlView_SimEN, string strSqlViewText4Gene, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlViewText4Gene, 8000, convSqlView_Sim.SqlViewText4Gene);
objvSqlView_SimEN.SqlViewText4Gene = strSqlViewText4Gene; //Sql视图文本4生成
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.SqlViewText4Gene) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.SqlViewText4Gene, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.SqlViewText4Gene] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTextResouce">文本来源</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetTextResouce(this clsvSqlView_SimEN objvSqlView_SimEN, string strTextResouce, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResouce, convSqlView_Sim.TextResouce);
clsCheckSql.CheckFieldLen(strTextResouce, 100, convSqlView_Sim.TextResouce);
objvSqlView_SimEN.TextResouce = strTextResouce; //文本来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.TextResouce) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.TextResouce, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.TextResouce] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTextResourceTypeId">文本来源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetTextResourceTypeId(this clsvSqlView_SimEN objvSqlView_SimEN, string strTextResourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResourceTypeId, convSqlView_Sim.TextResourceTypeId);
clsCheckSql.CheckFieldLen(strTextResourceTypeId, 2, convSqlView_Sim.TextResourceTypeId);
clsCheckSql.CheckFieldForeignKey(strTextResourceTypeId, 2, convSqlView_Sim.TextResourceTypeId);
objvSqlView_SimEN.TextResourceTypeId = strTextResourceTypeId; //文本来源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.TextResourceTypeId) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.TextResourceTypeId, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.TextResourceTypeId] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTextResourceTypeName">文本来源类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetTextResourceTypeName(this clsvSqlView_SimEN objvSqlView_SimEN, string strTextResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTextResourceTypeName, 30, convSqlView_Sim.TextResourceTypeName);
objvSqlView_SimEN.TextResourceTypeName = strTextResourceTypeName; //文本来源类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.TextResourceTypeName) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.TextResourceTypeName, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.TextResourceTypeName] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabId">相关表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetRelaTabId(this clsvSqlView_SimEN objvSqlView_SimEN, string strRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRelaTabId, convSqlView_Sim.RelaTabId);
clsCheckSql.CheckFieldLen(strRelaTabId, 8, convSqlView_Sim.RelaTabId);
clsCheckSql.CheckFieldForeignKey(strRelaTabId, 8, convSqlView_Sim.RelaTabId);
objvSqlView_SimEN.RelaTabId = strRelaTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.RelaTabId) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.RelaTabId, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.RelaTabId] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateId">表状态ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetTabStateId(this clsvSqlView_SimEN objvSqlView_SimEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convSqlView_Sim.TabStateId);
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convSqlView_Sim.TabStateId);
objvSqlView_SimEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.TabStateId) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.TabStateId, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.TabStateId] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetFuncModuleAgcId(this clsvSqlView_SimEN objvSqlView_SimEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convSqlView_Sim.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convSqlView_Sim.FuncModuleAgcId);
objvSqlView_SimEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.FuncModuleAgcId) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.FuncModuleAgcId, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.FuncModuleAgcId] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strAnalysisDate">分析日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetAnalysisDate(this clsvSqlView_SimEN objvSqlView_SimEN, string strAnalysisDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnalysisDate, 20, convSqlView_Sim.AnalysisDate);
objvSqlView_SimEN.AnalysisDate = strAnalysisDate; //分析日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.AnalysisDate) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.AnalysisDate, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.AnalysisDate] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strGeneCodeDate">生成代码日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetGeneCodeDate(this clsvSqlView_SimEN objvSqlView_SimEN, string strGeneCodeDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convSqlView_Sim.GeneCodeDate);
objvSqlView_SimEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.GeneCodeDate) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.GeneCodeDate, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.GeneCodeDate] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTopPercent">顶百分比</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetTopPercent(this clsvSqlView_SimEN objvSqlView_SimEN, string strTopPercent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTopPercent, 200, convSqlView_Sim.TopPercent);
objvSqlView_SimEN.TopPercent = strTopPercent; //顶百分比
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.TopPercent) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.TopPercent, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.TopPercent] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strDistinctFlag">Distinct标志</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetDistinctFlag(this clsvSqlView_SimEN objvSqlView_SimEN, string strDistinctFlag, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDistinctFlag, 100, convSqlView_Sim.DistinctFlag);
objvSqlView_SimEN.DistinctFlag = strDistinctFlag; //Distinct标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.DistinctFlag) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.DistinctFlag, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.DistinctFlag] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strWhereCondition">条件串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetWhereCondition(this clsvSqlView_SimEN objvSqlView_SimEN, string strWhereCondition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWhereCondition, 500, convSqlView_Sim.WhereCondition);
objvSqlView_SimEN.WhereCondition = strWhereCondition; //条件串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.WhereCondition) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.WhereCondition, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.WhereCondition] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strGroupBy">分组</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetGroupBy(this clsvSqlView_SimEN objvSqlView_SimEN, string strGroupBy, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGroupBy, 1000, convSqlView_Sim.GroupBy);
objvSqlView_SimEN.GroupBy = strGroupBy; //分组
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.GroupBy) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.GroupBy, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.GroupBy] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strHavingStr">分组过滤</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetHavingStr(this clsvSqlView_SimEN objvSqlView_SimEN, string strHavingStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHavingStr, 200, convSqlView_Sim.HavingStr);
objvSqlView_SimEN.HavingStr = strHavingStr; //分组过滤
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.HavingStr) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.HavingStr, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.HavingStr] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strOrderBy">排序</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetOrderBy(this clsvSqlView_SimEN objvSqlView_SimEN, string strOrderBy, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOrderBy, 100, convSqlView_Sim.OrderBy);
objvSqlView_SimEN.OrderBy = strOrderBy; //排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.OrderBy) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.OrderBy, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.OrderBy] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetErrMsg(this clsvSqlView_SimEN objvSqlView_SimEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, convSqlView_Sim.ErrMsg);
objvSqlView_SimEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.ErrMsg) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.ErrMsg, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.ErrMsg] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum4Refer">引用序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetOrderNum4Refer(this clsvSqlView_SimEN objvSqlView_SimEN, int intOrderNum4Refer, string strComparisonOp="")
	{
objvSqlView_SimEN.OrderNum4Refer = intOrderNum4Refer; //引用序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.OrderNum4Refer) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.OrderNum4Refer, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.OrderNum4Refer] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetPrjId(this clsvSqlView_SimEN objvSqlView_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convSqlView_Sim.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convSqlView_Sim.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convSqlView_Sim.PrjId);
objvSqlView_SimEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.PrjId) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.PrjId, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.PrjId] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetPrjName(this clsvSqlView_SimEN objvSqlView_SimEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convSqlView_Sim.PrjName);
objvSqlView_SimEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.PrjName) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.PrjName, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.PrjName] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetUpdDate(this clsvSqlView_SimEN objvSqlView_SimEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSqlView_Sim.UpdDate);
objvSqlView_SimEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.UpdDate) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.UpdDate, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.UpdDate] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetUpdUserId(this clsvSqlView_SimEN objvSqlView_SimEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSqlView_Sim.UpdUserId);
objvSqlView_SimEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.UpdUserId) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.UpdUserId, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.UpdUserId] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetMemo(this clsvSqlView_SimEN objvSqlView_SimEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSqlView_Sim.Memo);
objvSqlView_SimEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlView_SimEN.dicFldComparisonOp.ContainsKey(convSqlView_Sim.Memo) == false)
{
objvSqlView_SimEN.dicFldComparisonOp.Add(convSqlView_Sim.Memo, strComparisonOp);
}
else
{
objvSqlView_SimEN.dicFldComparisonOp[convSqlView_Sim.Memo] = strComparisonOp;
}
}
return objvSqlView_SimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSqlView_SimEN objvSqlView_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.SqlViewId) == true)
{
string strComparisonOpSqlViewId = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.SqlViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.SqlViewId, objvSqlView_SimCond.SqlViewId, strComparisonOpSqlViewId);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.SqlViewName) == true)
{
string strComparisonOpSqlViewName = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.SqlViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.SqlViewName, objvSqlView_SimCond.SqlViewName, strComparisonOpSqlViewName);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.SqlViewCNName) == true)
{
string strComparisonOpSqlViewCNName = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.SqlViewCNName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.SqlViewCNName, objvSqlView_SimCond.SqlViewCNName, strComparisonOpSqlViewCNName);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.SqlViewText) == true)
{
string strComparisonOpSqlViewText = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.SqlViewText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.SqlViewText, objvSqlView_SimCond.SqlViewText, strComparisonOpSqlViewText);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.SqlViewText4Gene) == true)
{
string strComparisonOpSqlViewText4Gene = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.SqlViewText4Gene];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.SqlViewText4Gene, objvSqlView_SimCond.SqlViewText4Gene, strComparisonOpSqlViewText4Gene);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.TextResouce) == true)
{
string strComparisonOpTextResouce = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.TextResouce];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.TextResouce, objvSqlView_SimCond.TextResouce, strComparisonOpTextResouce);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.TextResourceTypeId) == true)
{
string strComparisonOpTextResourceTypeId = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.TextResourceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.TextResourceTypeId, objvSqlView_SimCond.TextResourceTypeId, strComparisonOpTextResourceTypeId);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.TextResourceTypeName) == true)
{
string strComparisonOpTextResourceTypeName = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.TextResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.TextResourceTypeName, objvSqlView_SimCond.TextResourceTypeName, strComparisonOpTextResourceTypeName);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.RelaTabId) == true)
{
string strComparisonOpRelaTabId = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.RelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.RelaTabId, objvSqlView_SimCond.RelaTabId, strComparisonOpRelaTabId);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.TabStateId) == true)
{
string strComparisonOpTabStateId = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.TabStateId, objvSqlView_SimCond.TabStateId, strComparisonOpTabStateId);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.FuncModuleAgcId, objvSqlView_SimCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.AnalysisDate) == true)
{
string strComparisonOpAnalysisDate = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.AnalysisDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.AnalysisDate, objvSqlView_SimCond.AnalysisDate, strComparisonOpAnalysisDate);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.GeneCodeDate) == true)
{
string strComparisonOpGeneCodeDate = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.GeneCodeDate, objvSqlView_SimCond.GeneCodeDate, strComparisonOpGeneCodeDate);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.TopPercent) == true)
{
string strComparisonOpTopPercent = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.TopPercent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.TopPercent, objvSqlView_SimCond.TopPercent, strComparisonOpTopPercent);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.DistinctFlag) == true)
{
string strComparisonOpDistinctFlag = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.DistinctFlag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.DistinctFlag, objvSqlView_SimCond.DistinctFlag, strComparisonOpDistinctFlag);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.WhereCondition) == true)
{
string strComparisonOpWhereCondition = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.WhereCondition];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.WhereCondition, objvSqlView_SimCond.WhereCondition, strComparisonOpWhereCondition);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.GroupBy) == true)
{
string strComparisonOpGroupBy = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.GroupBy];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.GroupBy, objvSqlView_SimCond.GroupBy, strComparisonOpGroupBy);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.HavingStr) == true)
{
string strComparisonOpHavingStr = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.HavingStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.HavingStr, objvSqlView_SimCond.HavingStr, strComparisonOpHavingStr);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.OrderBy) == true)
{
string strComparisonOpOrderBy = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.OrderBy];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.OrderBy, objvSqlView_SimCond.OrderBy, strComparisonOpOrderBy);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.ErrMsg) == true)
{
string strComparisonOpErrMsg = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.ErrMsg, objvSqlView_SimCond.ErrMsg, strComparisonOpErrMsg);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.OrderNum4Refer) == true)
{
string strComparisonOpOrderNum4Refer = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.OrderNum4Refer];
strWhereCond += string.Format(" And {0} {2} {1}", convSqlView_Sim.OrderNum4Refer, objvSqlView_SimCond.OrderNum4Refer, strComparisonOpOrderNum4Refer);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.PrjId) == true)
{
string strComparisonOpPrjId = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.PrjId, objvSqlView_SimCond.PrjId, strComparisonOpPrjId);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.PrjName) == true)
{
string strComparisonOpPrjName = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.PrjName, objvSqlView_SimCond.PrjName, strComparisonOpPrjName);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.UpdDate, objvSqlView_SimCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.UpdUserId, objvSqlView_SimCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvSqlView_SimCond.IsUpdated(convSqlView_Sim.Memo) == true)
{
string strComparisonOpMemo = objvSqlView_SimCond.dicFldComparisonOp[convSqlView_Sim.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView_Sim.Memo, objvSqlView_SimCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vSql视图_Sim(vSqlView_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSqlView_SimWApi
{
private static readonly string mstrApiControllerName = "vSqlView_SimApi";

 public clsvSqlView_SimWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strSqlViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSqlView_SimEN GetObjBySqlViewId(string strSqlViewId)
{
if (strSqlViewId == "") return null;
string strAction = "GetObjBySqlViewId";
clsvSqlView_SimEN objvSqlView_SimEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strSqlViewId"] = strSqlViewId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvSqlView_SimEN = JsonConvert.DeserializeObject<clsvSqlView_SimEN>(strJson);
return objvSqlView_SimEN;
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
public static clsvSqlView_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvSqlView_SimEN objvSqlView_SimEN;
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
objvSqlView_SimEN = JsonConvert.DeserializeObject<clsvSqlView_SimEN>(strJson);
return objvSqlView_SimEN;
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
 /// <param name = "strSqlViewId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSqlView_SimEN GetObjBySqlViewIdCache(string strSqlViewId,string strPrjId)
{
if (string.IsNullOrEmpty(strSqlViewId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvSqlView_SimEN._CurrTabName, strPrjId);
List<clsvSqlView_SimEN> arrvSqlView_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlView_SimEN> arrvSqlView_SimObjLst_Sel =
from objvSqlView_SimEN in arrvSqlView_SimObjLstCache
where objvSqlView_SimEN.SqlViewId == strSqlViewId 
select objvSqlView_SimEN;
if (arrvSqlView_SimObjLst_Sel.Count() == 0)
{
   clsvSqlView_SimEN obj = clsvSqlView_SimWApi.GetObjBySqlViewId(strSqlViewId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvSqlView_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlView_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvSqlView_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlView_SimEN>>(strJson);
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
 /// <param name = "arrSqlViewId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlView_SimEN> GetObjLstBySqlViewIdLst(List<string> arrSqlViewId)
{
 List<clsvSqlView_SimEN> arrObjLst; 
string strAction = "GetObjLstBySqlViewIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrSqlViewId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlView_SimEN>>(strJson);
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
 /// <param name = "arrSqlViewId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvSqlView_SimEN> GetObjLstBySqlViewIdLstCache(List<string> arrSqlViewId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvSqlView_SimEN._CurrTabName, strPrjId);
List<clsvSqlView_SimEN> arrvSqlView_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlView_SimEN> arrvSqlView_SimObjLst_Sel =
from objvSqlView_SimEN in arrvSqlView_SimObjLstCache
where arrSqlViewId.Contains(objvSqlView_SimEN.SqlViewId)
select objvSqlView_SimEN;
return arrvSqlView_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlView_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvSqlView_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlView_SimEN>>(strJson);
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
public static List<clsvSqlView_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvSqlView_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlView_SimEN>>(strJson);
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
public static List<clsvSqlView_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvSqlView_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlView_SimEN>>(strJson);
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
public static List<clsvSqlView_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvSqlView_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlView_SimEN>>(strJson);
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
public static bool IsExist(string strSqlViewId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strSqlViewId"] = strSqlViewId
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
 /// <param name = "objvSqlView_SimENS">源对象</param>
 /// <param name = "objvSqlView_SimENT">目标对象</param>
 public static void CopyTo(clsvSqlView_SimEN objvSqlView_SimENS, clsvSqlView_SimEN objvSqlView_SimENT)
{
try
{
objvSqlView_SimENT.SqlViewId = objvSqlView_SimENS.SqlViewId; //Sql视图Id
objvSqlView_SimENT.SqlViewName = objvSqlView_SimENS.SqlViewName; //数据视图名称
objvSqlView_SimENT.SqlViewCNName = objvSqlView_SimENS.SqlViewCNName; //Sql视图中文名
objvSqlView_SimENT.SqlViewText = objvSqlView_SimENS.SqlViewText; //Sql视图文本内容
objvSqlView_SimENT.SqlViewText4Gene = objvSqlView_SimENS.SqlViewText4Gene; //Sql视图文本4生成
objvSqlView_SimENT.TextResouce = objvSqlView_SimENS.TextResouce; //文本来源
objvSqlView_SimENT.TextResourceTypeId = objvSqlView_SimENS.TextResourceTypeId; //文本来源类型Id
objvSqlView_SimENT.TextResourceTypeName = objvSqlView_SimENS.TextResourceTypeName; //文本来源类型名
objvSqlView_SimENT.RelaTabId = objvSqlView_SimENS.RelaTabId; //相关表Id
objvSqlView_SimENT.TabStateId = objvSqlView_SimENS.TabStateId; //表状态ID
objvSqlView_SimENT.FuncModuleAgcId = objvSqlView_SimENS.FuncModuleAgcId; //功能模块Id
objvSqlView_SimENT.AnalysisDate = objvSqlView_SimENS.AnalysisDate; //分析日期
objvSqlView_SimENT.GeneCodeDate = objvSqlView_SimENS.GeneCodeDate; //生成代码日期
objvSqlView_SimENT.TopPercent = objvSqlView_SimENS.TopPercent; //顶百分比
objvSqlView_SimENT.DistinctFlag = objvSqlView_SimENS.DistinctFlag; //Distinct标志
objvSqlView_SimENT.WhereCondition = objvSqlView_SimENS.WhereCondition; //条件串
objvSqlView_SimENT.GroupBy = objvSqlView_SimENS.GroupBy; //分组
objvSqlView_SimENT.HavingStr = objvSqlView_SimENS.HavingStr; //分组过滤
objvSqlView_SimENT.OrderBy = objvSqlView_SimENS.OrderBy; //排序
objvSqlView_SimENT.ErrMsg = objvSqlView_SimENS.ErrMsg; //错误信息
objvSqlView_SimENT.OrderNum4Refer = objvSqlView_SimENS.OrderNum4Refer; //引用序号
objvSqlView_SimENT.PrjId = objvSqlView_SimENS.PrjId; //工程Id
objvSqlView_SimENT.PrjName = objvSqlView_SimENS.PrjName; //工程名称
objvSqlView_SimENT.UpdDate = objvSqlView_SimENS.UpdDate; //修改日期
objvSqlView_SimENT.UpdUserId = objvSqlView_SimENS.UpdUserId; //修改用户Id
objvSqlView_SimENT.Memo = objvSqlView_SimENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvSqlView_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvSqlView_SimEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvSqlView_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvSqlView_SimEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvSqlView_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvSqlView_SimEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvSqlView_SimWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvSqlView_SimWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvSqlView_SimEN._CurrTabName, strPrjId);
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
public static List<clsvSqlView_SimEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvSqlView_SimWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvSqlView_SimWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvSqlView_SimEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvSqlView_SimEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convSqlView_Sim.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvSqlView_SimEN._CurrTabName, strPrjId);
List<clsvSqlView_SimEN> arrvSqlView_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvSqlView_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSqlView_SimEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvSqlView_SimEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvSqlView_SimWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvSqlView_SimWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvSqlView_SimEN._CurrTabName, strPrjId);
List<clsvSqlView_SimEN> arrvSqlView_SimObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvSqlView_SimObjLstCache = CacheHelper.Get<List<clsvSqlView_SimEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvSqlView_SimObjLstCache = CacheHelper.Get<List<clsvSqlView_SimEN>>(strKey);
}
return arrvSqlView_SimObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvSqlView_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convSqlView_Sim.SqlViewId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.SqlViewName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.SqlViewCNName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.SqlViewText, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.SqlViewText4Gene, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.TextResouce, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.TextResourceTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.TextResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.RelaTabId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.TabStateId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.AnalysisDate, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.GeneCodeDate, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.TopPercent, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.DistinctFlag, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.WhereCondition, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.GroupBy, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.HavingStr, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.OrderBy, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.OrderNum4Refer, Type.GetType("System.Int32"));
objDT.Columns.Add(convSqlView_Sim.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView_Sim.Memo, Type.GetType("System.String"));
foreach (clsvSqlView_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convSqlView_Sim.SqlViewId] = objInFor[convSqlView_Sim.SqlViewId];
objDR[convSqlView_Sim.SqlViewName] = objInFor[convSqlView_Sim.SqlViewName];
objDR[convSqlView_Sim.SqlViewCNName] = objInFor[convSqlView_Sim.SqlViewCNName];
objDR[convSqlView_Sim.SqlViewText] = objInFor[convSqlView_Sim.SqlViewText];
objDR[convSqlView_Sim.SqlViewText4Gene] = objInFor[convSqlView_Sim.SqlViewText4Gene];
objDR[convSqlView_Sim.TextResouce] = objInFor[convSqlView_Sim.TextResouce];
objDR[convSqlView_Sim.TextResourceTypeId] = objInFor[convSqlView_Sim.TextResourceTypeId];
objDR[convSqlView_Sim.TextResourceTypeName] = objInFor[convSqlView_Sim.TextResourceTypeName];
objDR[convSqlView_Sim.RelaTabId] = objInFor[convSqlView_Sim.RelaTabId];
objDR[convSqlView_Sim.TabStateId] = objInFor[convSqlView_Sim.TabStateId];
objDR[convSqlView_Sim.FuncModuleAgcId] = objInFor[convSqlView_Sim.FuncModuleAgcId];
objDR[convSqlView_Sim.AnalysisDate] = objInFor[convSqlView_Sim.AnalysisDate];
objDR[convSqlView_Sim.GeneCodeDate] = objInFor[convSqlView_Sim.GeneCodeDate];
objDR[convSqlView_Sim.TopPercent] = objInFor[convSqlView_Sim.TopPercent];
objDR[convSqlView_Sim.DistinctFlag] = objInFor[convSqlView_Sim.DistinctFlag];
objDR[convSqlView_Sim.WhereCondition] = objInFor[convSqlView_Sim.WhereCondition];
objDR[convSqlView_Sim.GroupBy] = objInFor[convSqlView_Sim.GroupBy];
objDR[convSqlView_Sim.HavingStr] = objInFor[convSqlView_Sim.HavingStr];
objDR[convSqlView_Sim.OrderBy] = objInFor[convSqlView_Sim.OrderBy];
objDR[convSqlView_Sim.ErrMsg] = objInFor[convSqlView_Sim.ErrMsg];
objDR[convSqlView_Sim.OrderNum4Refer] = objInFor[convSqlView_Sim.OrderNum4Refer];
objDR[convSqlView_Sim.PrjId] = objInFor[convSqlView_Sim.PrjId];
objDR[convSqlView_Sim.PrjName] = objInFor[convSqlView_Sim.PrjName];
objDR[convSqlView_Sim.UpdDate] = objInFor[convSqlView_Sim.UpdDate];
objDR[convSqlView_Sim.UpdUserId] = objInFor[convSqlView_Sim.UpdUserId];
objDR[convSqlView_Sim.Memo] = objInFor[convSqlView_Sim.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}