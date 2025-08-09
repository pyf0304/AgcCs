
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlView_SimBL
 表名:vSqlView_Sim(00050298)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:25
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
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
public static class  clsvSqlView_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSqlViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSqlView_SimEN GetObj(this K_SqlViewId_vSqlView_Sim myKey)
{
clsvSqlView_SimEN objvSqlView_SimEN = clsvSqlView_SimBL.vSqlView_SimDA.GetObjBySqlViewId(myKey.Value);
return objvSqlView_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetSqlViewId(this clsvSqlView_SimEN objvSqlView_SimEN, string strSqlViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewId, 8, convSqlView_Sim.SqlViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, convSqlView_Sim.SqlViewId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetSqlViewName(this clsvSqlView_SimEN objvSqlView_SimEN, string strSqlViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewName, convSqlView_Sim.SqlViewName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewName, 100, convSqlView_Sim.SqlViewName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetSqlViewCNName(this clsvSqlView_SimEN objvSqlView_SimEN, string strSqlViewCNName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewCNName, 200, convSqlView_Sim.SqlViewCNName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetSqlViewText(this clsvSqlView_SimEN objvSqlView_SimEN, string strSqlViewText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewText, 8000, convSqlView_Sim.SqlViewText);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetSqlViewText4Gene(this clsvSqlView_SimEN objvSqlView_SimEN, string strSqlViewText4Gene, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewText4Gene, 8000, convSqlView_Sim.SqlViewText4Gene);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetTextResouce(this clsvSqlView_SimEN objvSqlView_SimEN, string strTextResouce, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResouce, convSqlView_Sim.TextResouce);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextResouce, 100, convSqlView_Sim.TextResouce);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetTextResourceTypeId(this clsvSqlView_SimEN objvSqlView_SimEN, string strTextResourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResourceTypeId, convSqlView_Sim.TextResourceTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextResourceTypeId, 2, convSqlView_Sim.TextResourceTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextResourceTypeId, 2, convSqlView_Sim.TextResourceTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetTextResourceTypeName(this clsvSqlView_SimEN objvSqlView_SimEN, string strTextResourceTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextResourceTypeName, 30, convSqlView_Sim.TextResourceTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetRelaTabId(this clsvSqlView_SimEN objvSqlView_SimEN, string strRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRelaTabId, convSqlView_Sim.RelaTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabId, 8, convSqlView_Sim.RelaTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaTabId, 8, convSqlView_Sim.RelaTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetTabStateId(this clsvSqlView_SimEN objvSqlView_SimEN, string strTabStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convSqlView_Sim.TabStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convSqlView_Sim.TabStateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetFuncModuleAgcId(this clsvSqlView_SimEN objvSqlView_SimEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convSqlView_Sim.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convSqlView_Sim.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetAnalysisDate(this clsvSqlView_SimEN objvSqlView_SimEN, string strAnalysisDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnalysisDate, 20, convSqlView_Sim.AnalysisDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetGeneCodeDate(this clsvSqlView_SimEN objvSqlView_SimEN, string strGeneCodeDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convSqlView_Sim.GeneCodeDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetTopPercent(this clsvSqlView_SimEN objvSqlView_SimEN, string strTopPercent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopPercent, 200, convSqlView_Sim.TopPercent);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetDistinctFlag(this clsvSqlView_SimEN objvSqlView_SimEN, string strDistinctFlag, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDistinctFlag, 100, convSqlView_Sim.DistinctFlag);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetWhereCondition(this clsvSqlView_SimEN objvSqlView_SimEN, string strWhereCondition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWhereCondition, 500, convSqlView_Sim.WhereCondition);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetGroupBy(this clsvSqlView_SimEN objvSqlView_SimEN, string strGroupBy, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupBy, 1000, convSqlView_Sim.GroupBy);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetHavingStr(this clsvSqlView_SimEN objvSqlView_SimEN, string strHavingStr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHavingStr, 200, convSqlView_Sim.HavingStr);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetOrderBy(this clsvSqlView_SimEN objvSqlView_SimEN, string strOrderBy, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOrderBy, 100, convSqlView_Sim.OrderBy);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetErrMsg(this clsvSqlView_SimEN objvSqlView_SimEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, convSqlView_Sim.ErrMsg);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetOrderNum4Refer(this clsvSqlView_SimEN objvSqlView_SimEN, int? intOrderNum4Refer, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetPrjId(this clsvSqlView_SimEN objvSqlView_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convSqlView_Sim.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convSqlView_Sim.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convSqlView_Sim.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetPrjName(this clsvSqlView_SimEN objvSqlView_SimEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convSqlView_Sim.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetUpdDate(this clsvSqlView_SimEN objvSqlView_SimEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSqlView_Sim.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetUpdUserId(this clsvSqlView_SimEN objvSqlView_SimEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSqlView_Sim.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlView_SimEN SetMemo(this clsvSqlView_SimEN objvSqlView_SimEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSqlView_Sim.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSqlView_SimENS">源对象</param>
 /// <param name = "objvSqlView_SimENT">目标对象</param>
 public static void CopyTo(this clsvSqlView_SimEN objvSqlView_SimENS, clsvSqlView_SimEN objvSqlView_SimENT)
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
 /// <param name = "objvSqlView_SimENS">源对象</param>
 /// <returns>目标对象=>clsvSqlView_SimEN:objvSqlView_SimENT</returns>
 public static clsvSqlView_SimEN CopyTo(this clsvSqlView_SimEN objvSqlView_SimENS)
{
try
{
 clsvSqlView_SimEN objvSqlView_SimENT = new clsvSqlView_SimEN()
{
SqlViewId = objvSqlView_SimENS.SqlViewId, //Sql视图Id
SqlViewName = objvSqlView_SimENS.SqlViewName, //数据视图名称
SqlViewCNName = objvSqlView_SimENS.SqlViewCNName, //Sql视图中文名
SqlViewText = objvSqlView_SimENS.SqlViewText, //Sql视图文本内容
SqlViewText4Gene = objvSqlView_SimENS.SqlViewText4Gene, //Sql视图文本4生成
TextResouce = objvSqlView_SimENS.TextResouce, //文本来源
TextResourceTypeId = objvSqlView_SimENS.TextResourceTypeId, //文本来源类型Id
TextResourceTypeName = objvSqlView_SimENS.TextResourceTypeName, //文本来源类型名
RelaTabId = objvSqlView_SimENS.RelaTabId, //相关表Id
TabStateId = objvSqlView_SimENS.TabStateId, //表状态ID
FuncModuleAgcId = objvSqlView_SimENS.FuncModuleAgcId, //功能模块Id
AnalysisDate = objvSqlView_SimENS.AnalysisDate, //分析日期
GeneCodeDate = objvSqlView_SimENS.GeneCodeDate, //生成代码日期
TopPercent = objvSqlView_SimENS.TopPercent, //顶百分比
DistinctFlag = objvSqlView_SimENS.DistinctFlag, //Distinct标志
WhereCondition = objvSqlView_SimENS.WhereCondition, //条件串
GroupBy = objvSqlView_SimENS.GroupBy, //分组
HavingStr = objvSqlView_SimENS.HavingStr, //分组过滤
OrderBy = objvSqlView_SimENS.OrderBy, //排序
ErrMsg = objvSqlView_SimENS.ErrMsg, //错误信息
OrderNum4Refer = objvSqlView_SimENS.OrderNum4Refer, //引用序号
PrjId = objvSqlView_SimENS.PrjId, //工程Id
PrjName = objvSqlView_SimENS.PrjName, //工程名称
UpdDate = objvSqlView_SimENS.UpdDate, //修改日期
UpdUserId = objvSqlView_SimENS.UpdUserId, //修改用户Id
Memo = objvSqlView_SimENS.Memo, //说明
};
 return objvSqlView_SimENT;
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
public static void CheckProperty4Condition(this clsvSqlView_SimEN objvSqlView_SimEN)
{
 clsvSqlView_SimBL.vSqlView_SimDA.CheckProperty4Condition(objvSqlView_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSqlView_Sim
{
public virtual bool UpdRelaTabDate(string strSqlViewId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vSql视图_Sim(vSqlView_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSqlView_SimBL
{
public static RelatedActions_vSqlView_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSqlView_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSqlView_SimDA vSqlView_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSqlView_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSqlView_SimBL()
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
if (string.IsNullOrEmpty(clsvSqlView_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSqlView_SimEN._ConnectString);
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
public static DataTable GetDataTable_vSqlView_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSqlView_SimDA.GetDataTable_vSqlView_Sim(strWhereCond);
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
objDT = vSqlView_SimDA.GetDataTable(strWhereCond);
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
objDT = vSqlView_SimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSqlView_SimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSqlView_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSqlView_SimDA.GetDataTable_Top(objTopPara);
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
objDT = vSqlView_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSqlView_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSqlView_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSqlViewIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvSqlView_SimEN> GetObjLstBySqlViewIdLst(List<string> arrSqlViewIdLst)
{
List<clsvSqlView_SimEN> arrObjLst = new List<clsvSqlView_SimEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSqlViewIdLst, true);
 string strWhereCond = string.Format("SqlViewId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN();
try
{
objvSqlView_SimEN.SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlView_SimEN.SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlView_SimEN.SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlView_SimEN.SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlView_SimEN.SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlView_SimEN.TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源
objvSqlView_SimEN.TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlView_SimEN.TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlView_SimEN.RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id
objvSqlView_SimEN.TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID
objvSqlView_SimEN.FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlView_SimEN.AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期
objvSqlView_SimEN.GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlView_SimEN.TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比
objvSqlView_SimEN.DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlView_SimEN.WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串
objvSqlView_SimEN.GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(); //分组
objvSqlView_SimEN.HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤
objvSqlView_SimEN.OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(); //排序
objvSqlView_SimEN.ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息
objvSqlView_SimEN.OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlView_SimEN.PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(); //工程Id
objvSqlView_SimEN.PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(); //工程名称
objvSqlView_SimEN.UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期
objvSqlView_SimEN.UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlView_SimEN.Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlView_SimEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlView_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSqlViewIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSqlView_SimEN> GetObjLstBySqlViewIdLstCache(List<string> arrSqlViewIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvSqlView_SimEN._CurrTabName, strPrjId);
List<clsvSqlView_SimEN> arrvSqlView_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlView_SimEN> arrvSqlView_SimObjLst_Sel =
arrvSqlView_SimObjLstCache
.Where(x => arrSqlViewIdLst.Contains(x.SqlViewId));
return arrvSqlView_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlView_SimEN> GetObjLst(string strWhereCond)
{
List<clsvSqlView_SimEN> arrObjLst = new List<clsvSqlView_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN();
try
{
objvSqlView_SimEN.SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlView_SimEN.SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlView_SimEN.SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlView_SimEN.SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlView_SimEN.SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlView_SimEN.TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源
objvSqlView_SimEN.TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlView_SimEN.TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlView_SimEN.RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id
objvSqlView_SimEN.TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID
objvSqlView_SimEN.FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlView_SimEN.AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期
objvSqlView_SimEN.GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlView_SimEN.TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比
objvSqlView_SimEN.DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlView_SimEN.WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串
objvSqlView_SimEN.GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(); //分组
objvSqlView_SimEN.HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤
objvSqlView_SimEN.OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(); //排序
objvSqlView_SimEN.ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息
objvSqlView_SimEN.OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlView_SimEN.PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(); //工程Id
objvSqlView_SimEN.PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(); //工程名称
objvSqlView_SimEN.UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期
objvSqlView_SimEN.UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlView_SimEN.Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlView_SimEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlView_SimEN);
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
public static List<clsvSqlView_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSqlView_SimEN> arrObjLst = new List<clsvSqlView_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN();
try
{
objvSqlView_SimEN.SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlView_SimEN.SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlView_SimEN.SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlView_SimEN.SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlView_SimEN.SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlView_SimEN.TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源
objvSqlView_SimEN.TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlView_SimEN.TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlView_SimEN.RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id
objvSqlView_SimEN.TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID
objvSqlView_SimEN.FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlView_SimEN.AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期
objvSqlView_SimEN.GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlView_SimEN.TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比
objvSqlView_SimEN.DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlView_SimEN.WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串
objvSqlView_SimEN.GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(); //分组
objvSqlView_SimEN.HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤
objvSqlView_SimEN.OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(); //排序
objvSqlView_SimEN.ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息
objvSqlView_SimEN.OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlView_SimEN.PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(); //工程Id
objvSqlView_SimEN.PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(); //工程名称
objvSqlView_SimEN.UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期
objvSqlView_SimEN.UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlView_SimEN.Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlView_SimEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlView_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSqlView_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSqlView_SimEN> GetSubObjLstCache(clsvSqlView_SimEN objvSqlView_SimCond)
{
 string strPrjId = objvSqlView_SimCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvSqlView_SimBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvSqlView_SimEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlView_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSqlView_Sim._AttributeName)
{
if (objvSqlView_SimCond.IsUpdated(strFldName) == false) continue;
if (objvSqlView_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlView_SimCond[strFldName].ToString());
}
else
{
if (objvSqlView_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSqlView_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlView_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSqlView_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSqlView_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSqlView_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSqlView_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSqlView_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSqlView_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSqlView_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSqlView_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSqlView_SimCond[strFldName]));
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
public static List<clsvSqlView_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSqlView_SimEN> arrObjLst = new List<clsvSqlView_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN();
try
{
objvSqlView_SimEN.SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlView_SimEN.SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlView_SimEN.SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlView_SimEN.SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlView_SimEN.SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlView_SimEN.TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源
objvSqlView_SimEN.TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlView_SimEN.TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlView_SimEN.RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id
objvSqlView_SimEN.TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID
objvSqlView_SimEN.FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlView_SimEN.AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期
objvSqlView_SimEN.GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlView_SimEN.TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比
objvSqlView_SimEN.DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlView_SimEN.WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串
objvSqlView_SimEN.GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(); //分组
objvSqlView_SimEN.HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤
objvSqlView_SimEN.OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(); //排序
objvSqlView_SimEN.ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息
objvSqlView_SimEN.OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlView_SimEN.PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(); //工程Id
objvSqlView_SimEN.PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(); //工程名称
objvSqlView_SimEN.UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期
objvSqlView_SimEN.UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlView_SimEN.Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlView_SimEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlView_SimEN);
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
public static List<clsvSqlView_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSqlView_SimEN> arrObjLst = new List<clsvSqlView_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN();
try
{
objvSqlView_SimEN.SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlView_SimEN.SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlView_SimEN.SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlView_SimEN.SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlView_SimEN.SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlView_SimEN.TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源
objvSqlView_SimEN.TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlView_SimEN.TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlView_SimEN.RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id
objvSqlView_SimEN.TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID
objvSqlView_SimEN.FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlView_SimEN.AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期
objvSqlView_SimEN.GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlView_SimEN.TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比
objvSqlView_SimEN.DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlView_SimEN.WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串
objvSqlView_SimEN.GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(); //分组
objvSqlView_SimEN.HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤
objvSqlView_SimEN.OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(); //排序
objvSqlView_SimEN.ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息
objvSqlView_SimEN.OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlView_SimEN.PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(); //工程Id
objvSqlView_SimEN.PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(); //工程名称
objvSqlView_SimEN.UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期
objvSqlView_SimEN.UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlView_SimEN.Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlView_SimEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlView_SimEN);
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
List<clsvSqlView_SimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSqlView_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlView_SimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSqlView_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSqlView_SimEN> arrObjLst = new List<clsvSqlView_SimEN>(); 
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
	clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN();
try
{
objvSqlView_SimEN.SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlView_SimEN.SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlView_SimEN.SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlView_SimEN.SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlView_SimEN.SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlView_SimEN.TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源
objvSqlView_SimEN.TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlView_SimEN.TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlView_SimEN.RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id
objvSqlView_SimEN.TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID
objvSqlView_SimEN.FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlView_SimEN.AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期
objvSqlView_SimEN.GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlView_SimEN.TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比
objvSqlView_SimEN.DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlView_SimEN.WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串
objvSqlView_SimEN.GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(); //分组
objvSqlView_SimEN.HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤
objvSqlView_SimEN.OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(); //排序
objvSqlView_SimEN.ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息
objvSqlView_SimEN.OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlView_SimEN.PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(); //工程Id
objvSqlView_SimEN.PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(); //工程名称
objvSqlView_SimEN.UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期
objvSqlView_SimEN.UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlView_SimEN.Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlView_SimEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlView_SimEN);
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
public static List<clsvSqlView_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSqlView_SimEN> arrObjLst = new List<clsvSqlView_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN();
try
{
objvSqlView_SimEN.SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlView_SimEN.SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlView_SimEN.SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlView_SimEN.SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlView_SimEN.SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlView_SimEN.TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源
objvSqlView_SimEN.TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlView_SimEN.TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlView_SimEN.RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id
objvSqlView_SimEN.TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID
objvSqlView_SimEN.FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlView_SimEN.AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期
objvSqlView_SimEN.GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlView_SimEN.TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比
objvSqlView_SimEN.DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlView_SimEN.WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串
objvSqlView_SimEN.GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(); //分组
objvSqlView_SimEN.HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤
objvSqlView_SimEN.OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(); //排序
objvSqlView_SimEN.ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息
objvSqlView_SimEN.OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlView_SimEN.PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(); //工程Id
objvSqlView_SimEN.PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(); //工程名称
objvSqlView_SimEN.UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期
objvSqlView_SimEN.UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlView_SimEN.Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlView_SimEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlView_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSqlView_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSqlView_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSqlView_SimEN> arrObjLst = new List<clsvSqlView_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN();
try
{
objvSqlView_SimEN.SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlView_SimEN.SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlView_SimEN.SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlView_SimEN.SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlView_SimEN.SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlView_SimEN.TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源
objvSqlView_SimEN.TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlView_SimEN.TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlView_SimEN.RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id
objvSqlView_SimEN.TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID
objvSqlView_SimEN.FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlView_SimEN.AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期
objvSqlView_SimEN.GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlView_SimEN.TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比
objvSqlView_SimEN.DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlView_SimEN.WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串
objvSqlView_SimEN.GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(); //分组
objvSqlView_SimEN.HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤
objvSqlView_SimEN.OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(); //排序
objvSqlView_SimEN.ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息
objvSqlView_SimEN.OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlView_SimEN.PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(); //工程Id
objvSqlView_SimEN.PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(); //工程名称
objvSqlView_SimEN.UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期
objvSqlView_SimEN.UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlView_SimEN.Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlView_SimEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlView_SimEN);
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
public static List<clsvSqlView_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSqlView_SimEN> arrObjLst = new List<clsvSqlView_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN();
try
{
objvSqlView_SimEN.SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlView_SimEN.SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlView_SimEN.SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlView_SimEN.SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlView_SimEN.SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlView_SimEN.TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源
objvSqlView_SimEN.TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlView_SimEN.TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlView_SimEN.RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id
objvSqlView_SimEN.TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID
objvSqlView_SimEN.FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlView_SimEN.AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期
objvSqlView_SimEN.GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlView_SimEN.TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比
objvSqlView_SimEN.DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlView_SimEN.WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串
objvSqlView_SimEN.GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(); //分组
objvSqlView_SimEN.HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤
objvSqlView_SimEN.OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(); //排序
objvSqlView_SimEN.ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息
objvSqlView_SimEN.OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlView_SimEN.PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(); //工程Id
objvSqlView_SimEN.PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(); //工程名称
objvSqlView_SimEN.UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期
objvSqlView_SimEN.UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlView_SimEN.Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlView_SimEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlView_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlView_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSqlView_SimEN> arrObjLst = new List<clsvSqlView_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN();
try
{
objvSqlView_SimEN.SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlView_SimEN.SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlView_SimEN.SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlView_SimEN.SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlView_SimEN.SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlView_SimEN.TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源
objvSqlView_SimEN.TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlView_SimEN.TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlView_SimEN.RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id
objvSqlView_SimEN.TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID
objvSqlView_SimEN.FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlView_SimEN.AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期
objvSqlView_SimEN.GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlView_SimEN.TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比
objvSqlView_SimEN.DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlView_SimEN.WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串
objvSqlView_SimEN.GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(); //分组
objvSqlView_SimEN.HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤
objvSqlView_SimEN.OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(); //排序
objvSqlView_SimEN.ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息
objvSqlView_SimEN.OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlView_SimEN.PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(); //工程Id
objvSqlView_SimEN.PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(); //工程名称
objvSqlView_SimEN.UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期
objvSqlView_SimEN.UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlView_SimEN.Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlView_SimEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlView_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSqlView_Sim(ref clsvSqlView_SimEN objvSqlView_SimEN)
{
bool bolResult = vSqlView_SimDA.GetvSqlView_Sim(ref objvSqlView_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSqlViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSqlView_SimEN GetObjBySqlViewId(string strSqlViewId)
{
if (strSqlViewId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strSqlViewId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strSqlViewId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strSqlViewId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvSqlView_SimEN objvSqlView_SimEN = vSqlView_SimDA.GetObjBySqlViewId(strSqlViewId);
return objvSqlView_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSqlView_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSqlView_SimEN objvSqlView_SimEN = vSqlView_SimDA.GetFirstObj(strWhereCond);
 return objvSqlView_SimEN;
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
public static clsvSqlView_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSqlView_SimEN objvSqlView_SimEN = vSqlView_SimDA.GetObjByDataRow(objRow);
 return objvSqlView_SimEN;
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
public static clsvSqlView_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSqlView_SimEN objvSqlView_SimEN = vSqlView_SimDA.GetObjByDataRow(objRow);
 return objvSqlView_SimEN;
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
 /// <param name = "strSqlViewId">所给的关键字</param>
 /// <param name = "lstvSqlView_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSqlView_SimEN GetObjBySqlViewIdFromList(string strSqlViewId, List<clsvSqlView_SimEN> lstvSqlView_SimObjLst)
{
foreach (clsvSqlView_SimEN objvSqlView_SimEN in lstvSqlView_SimObjLst)
{
if (objvSqlView_SimEN.SqlViewId == strSqlViewId)
{
return objvSqlView_SimEN;
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
 string strSqlViewId;
 try
 {
 strSqlViewId = new clsvSqlView_SimDA().GetFirstID(strWhereCond);
 return strSqlViewId;
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
 arrList = vSqlView_SimDA.GetID(strWhereCond);
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
bool bolIsExist = vSqlView_SimDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strSqlViewId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strSqlViewId)
{
if (string.IsNullOrEmpty(strSqlViewId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strSqlViewId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vSqlView_SimDA.IsExist(strSqlViewId);
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
 bolIsExist = clsvSqlView_SimDA.IsExistTable();
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
 bolIsExist = vSqlView_SimDA.IsExistTable(strTabName);
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
 /// <param name = "objvSqlView_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvSqlView_SimEN objvSqlView_SimEN)
{
try
{
objvSqlView_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSqlView_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSqlView_Sim.SqlViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.SqlViewId = objvSqlView_SimEN.SqlViewId; //Sql视图Id
}
if (arrFldSet.Contains(convSqlView_Sim.SqlViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.SqlViewName = objvSqlView_SimEN.SqlViewName; //数据视图名称
}
if (arrFldSet.Contains(convSqlView_Sim.SqlViewCNName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.SqlViewCNName = objvSqlView_SimEN.SqlViewCNName == "[null]" ? null :  objvSqlView_SimEN.SqlViewCNName; //Sql视图中文名
}
if (arrFldSet.Contains(convSqlView_Sim.SqlViewText, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.SqlViewText = objvSqlView_SimEN.SqlViewText == "[null]" ? null :  objvSqlView_SimEN.SqlViewText; //Sql视图文本内容
}
if (arrFldSet.Contains(convSqlView_Sim.SqlViewText4Gene, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.SqlViewText4Gene = objvSqlView_SimEN.SqlViewText4Gene == "[null]" ? null :  objvSqlView_SimEN.SqlViewText4Gene; //Sql视图文本4生成
}
if (arrFldSet.Contains(convSqlView_Sim.TextResouce, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.TextResouce = objvSqlView_SimEN.TextResouce; //文本来源
}
if (arrFldSet.Contains(convSqlView_Sim.TextResourceTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.TextResourceTypeId = objvSqlView_SimEN.TextResourceTypeId; //文本来源类型Id
}
if (arrFldSet.Contains(convSqlView_Sim.TextResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.TextResourceTypeName = objvSqlView_SimEN.TextResourceTypeName == "[null]" ? null :  objvSqlView_SimEN.TextResourceTypeName; //文本来源类型名
}
if (arrFldSet.Contains(convSqlView_Sim.RelaTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.RelaTabId = objvSqlView_SimEN.RelaTabId; //相关表Id
}
if (arrFldSet.Contains(convSqlView_Sim.TabStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.TabStateId = objvSqlView_SimEN.TabStateId == "[null]" ? null :  objvSqlView_SimEN.TabStateId; //表状态ID
}
if (arrFldSet.Contains(convSqlView_Sim.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.FuncModuleAgcId = objvSqlView_SimEN.FuncModuleAgcId == "[null]" ? null :  objvSqlView_SimEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convSqlView_Sim.AnalysisDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.AnalysisDate = objvSqlView_SimEN.AnalysisDate == "[null]" ? null :  objvSqlView_SimEN.AnalysisDate; //分析日期
}
if (arrFldSet.Contains(convSqlView_Sim.GeneCodeDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.GeneCodeDate = objvSqlView_SimEN.GeneCodeDate == "[null]" ? null :  objvSqlView_SimEN.GeneCodeDate; //生成代码日期
}
if (arrFldSet.Contains(convSqlView_Sim.TopPercent, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.TopPercent = objvSqlView_SimEN.TopPercent == "[null]" ? null :  objvSqlView_SimEN.TopPercent; //顶百分比
}
if (arrFldSet.Contains(convSqlView_Sim.DistinctFlag, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.DistinctFlag = objvSqlView_SimEN.DistinctFlag == "[null]" ? null :  objvSqlView_SimEN.DistinctFlag; //Distinct标志
}
if (arrFldSet.Contains(convSqlView_Sim.WhereCondition, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.WhereCondition = objvSqlView_SimEN.WhereCondition == "[null]" ? null :  objvSqlView_SimEN.WhereCondition; //条件串
}
if (arrFldSet.Contains(convSqlView_Sim.GroupBy, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.GroupBy = objvSqlView_SimEN.GroupBy == "[null]" ? null :  objvSqlView_SimEN.GroupBy; //分组
}
if (arrFldSet.Contains(convSqlView_Sim.HavingStr, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.HavingStr = objvSqlView_SimEN.HavingStr == "[null]" ? null :  objvSqlView_SimEN.HavingStr; //分组过滤
}
if (arrFldSet.Contains(convSqlView_Sim.OrderBy, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.OrderBy = objvSqlView_SimEN.OrderBy == "[null]" ? null :  objvSqlView_SimEN.OrderBy; //排序
}
if (arrFldSet.Contains(convSqlView_Sim.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.ErrMsg = objvSqlView_SimEN.ErrMsg == "[null]" ? null :  objvSqlView_SimEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(convSqlView_Sim.OrderNum4Refer, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.OrderNum4Refer = objvSqlView_SimEN.OrderNum4Refer; //引用序号
}
if (arrFldSet.Contains(convSqlView_Sim.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.PrjId = objvSqlView_SimEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convSqlView_Sim.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.PrjName = objvSqlView_SimEN.PrjName == "[null]" ? null :  objvSqlView_SimEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convSqlView_Sim.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.UpdDate = objvSqlView_SimEN.UpdDate == "[null]" ? null :  objvSqlView_SimEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSqlView_Sim.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.UpdUserId = objvSqlView_SimEN.UpdUserId == "[null]" ? null :  objvSqlView_SimEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convSqlView_Sim.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlView_SimEN.Memo = objvSqlView_SimEN.Memo == "[null]" ? null :  objvSqlView_SimEN.Memo; //说明
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
 /// <param name = "objvSqlView_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSqlView_SimEN objvSqlView_SimEN)
{
try
{
if (objvSqlView_SimEN.SqlViewCNName == "[null]") objvSqlView_SimEN.SqlViewCNName = null; //Sql视图中文名
if (objvSqlView_SimEN.SqlViewText == "[null]") objvSqlView_SimEN.SqlViewText = null; //Sql视图文本内容
if (objvSqlView_SimEN.SqlViewText4Gene == "[null]") objvSqlView_SimEN.SqlViewText4Gene = null; //Sql视图文本4生成
if (objvSqlView_SimEN.TextResourceTypeName == "[null]") objvSqlView_SimEN.TextResourceTypeName = null; //文本来源类型名
if (objvSqlView_SimEN.TabStateId == "[null]") objvSqlView_SimEN.TabStateId = null; //表状态ID
if (objvSqlView_SimEN.FuncModuleAgcId == "[null]") objvSqlView_SimEN.FuncModuleAgcId = null; //功能模块Id
if (objvSqlView_SimEN.AnalysisDate == "[null]") objvSqlView_SimEN.AnalysisDate = null; //分析日期
if (objvSqlView_SimEN.GeneCodeDate == "[null]") objvSqlView_SimEN.GeneCodeDate = null; //生成代码日期
if (objvSqlView_SimEN.TopPercent == "[null]") objvSqlView_SimEN.TopPercent = null; //顶百分比
if (objvSqlView_SimEN.DistinctFlag == "[null]") objvSqlView_SimEN.DistinctFlag = null; //Distinct标志
if (objvSqlView_SimEN.WhereCondition == "[null]") objvSqlView_SimEN.WhereCondition = null; //条件串
if (objvSqlView_SimEN.GroupBy == "[null]") objvSqlView_SimEN.GroupBy = null; //分组
if (objvSqlView_SimEN.HavingStr == "[null]") objvSqlView_SimEN.HavingStr = null; //分组过滤
if (objvSqlView_SimEN.OrderBy == "[null]") objvSqlView_SimEN.OrderBy = null; //排序
if (objvSqlView_SimEN.ErrMsg == "[null]") objvSqlView_SimEN.ErrMsg = null; //错误信息
if (objvSqlView_SimEN.PrjName == "[null]") objvSqlView_SimEN.PrjName = null; //工程名称
if (objvSqlView_SimEN.UpdDate == "[null]") objvSqlView_SimEN.UpdDate = null; //修改日期
if (objvSqlView_SimEN.UpdUserId == "[null]") objvSqlView_SimEN.UpdUserId = null; //修改用户Id
if (objvSqlView_SimEN.Memo == "[null]") objvSqlView_SimEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvSqlView_SimEN objvSqlView_SimEN)
{
 vSqlView_SimDA.CheckProperty4Condition(objvSqlView_SimEN);
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
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSqlViewBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSqlViewBL没有刷新缓存机制(clsSqlViewBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTextResourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTextResourceTypeBL没有刷新缓存机制(clsTextResourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SqlViewId");
//if (arrvSqlView_SimObjLstCache == null)
//{
//arrvSqlView_SimObjLstCache = vSqlView_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSqlViewId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSqlView_SimEN GetObjBySqlViewIdCache(string strSqlViewId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvSqlView_SimEN._CurrTabName, strPrjId);
List<clsvSqlView_SimEN> arrvSqlView_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlView_SimEN> arrvSqlView_SimObjLst_Sel =
arrvSqlView_SimObjLstCache
.Where(x=> x.SqlViewId == strSqlViewId 
);
if (arrvSqlView_SimObjLst_Sel.Count() == 0)
{
   clsvSqlView_SimEN obj = clsvSqlView_SimBL.GetObjBySqlViewId(strSqlViewId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strSqlViewId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvSqlView_SimObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSqlView_SimEN> GetAllvSqlView_SimObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvSqlView_SimEN> arrvSqlView_SimObjLstCache = GetObjLstCache(strPrjId); 
return arrvSqlView_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSqlView_SimEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvSqlView_SimEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvSqlView_SimEN> arrvSqlView_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvSqlView_SimObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvSqlView_SimEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvSqlView_SimEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvSqlView_SimEN._RefreshTimeLst.Count == 0) return "";
return clsvSqlView_SimEN._RefreshTimeLst[clsvSqlView_SimEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strSqlViewId, string strPrjId)
{
if (strInFldName != convSqlView_Sim.SqlViewId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSqlView_Sim._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSqlView_Sim._AttributeName));
throw new Exception(strMsg);
}
var objvSqlView_Sim = clsvSqlView_SimBL.GetObjBySqlViewIdCache(strSqlViewId, strPrjId);
if (objvSqlView_Sim == null) return "";
return objvSqlView_Sim[strOutFldName].ToString();
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
int intRecCount = clsvSqlView_SimDA.GetRecCount(strTabName);
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
int intRecCount = clsvSqlView_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSqlView_SimDA.GetRecCount();
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
int intRecCount = clsvSqlView_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSqlView_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSqlView_SimEN objvSqlView_SimCond)
{
 string strPrjId = objvSqlView_SimCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvSqlView_SimBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvSqlView_SimEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlView_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSqlView_Sim._AttributeName)
{
if (objvSqlView_SimCond.IsUpdated(strFldName) == false) continue;
if (objvSqlView_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlView_SimCond[strFldName].ToString());
}
else
{
if (objvSqlView_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSqlView_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlView_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSqlView_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSqlView_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSqlView_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSqlView_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSqlView_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSqlView_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSqlView_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSqlView_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSqlView_SimCond[strFldName]));
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
 List<string> arrList = clsvSqlView_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSqlView_SimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSqlView_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}