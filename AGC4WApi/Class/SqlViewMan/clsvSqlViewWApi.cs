
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlViewWApi
 表名:vSqlView(00050250)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:17
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvSqlViewWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewId">Sql视图Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetSqlViewId(this clsvSqlViewEN objvSqlViewEN, string strSqlViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlViewId, 8, convSqlView.SqlViewId);
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, convSqlView.SqlViewId);
objvSqlViewEN.SqlViewId = strSqlViewId; //Sql视图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.SqlViewId) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.SqlViewId, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.SqlViewId] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewName">数据视图名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetSqlViewName(this clsvSqlViewEN objvSqlViewEN, string strSqlViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewName, convSqlView.SqlViewName);
clsCheckSql.CheckFieldLen(strSqlViewName, 100, convSqlView.SqlViewName);
objvSqlViewEN.SqlViewName = strSqlViewName; //数据视图名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.SqlViewName) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.SqlViewName, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.SqlViewName] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewCNName">Sql视图中文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetSqlViewCNName(this clsvSqlViewEN objvSqlViewEN, string strSqlViewCNName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlViewCNName, 200, convSqlView.SqlViewCNName);
objvSqlViewEN.SqlViewCNName = strSqlViewCNName; //Sql视图中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.SqlViewCNName) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.SqlViewCNName, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.SqlViewCNName] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewText">Sql视图文本内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetSqlViewText(this clsvSqlViewEN objvSqlViewEN, string strSqlViewText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlViewText, 8000, convSqlView.SqlViewText);
objvSqlViewEN.SqlViewText = strSqlViewText; //Sql视图文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.SqlViewText) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.SqlViewText, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.SqlViewText] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewText4Gene">Sql视图文本4生成</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetSqlViewText4Gene(this clsvSqlViewEN objvSqlViewEN, string strSqlViewText4Gene, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlViewText4Gene, 8000, convSqlView.SqlViewText4Gene);
objvSqlViewEN.SqlViewText4Gene = strSqlViewText4Gene; //Sql视图文本4生成
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.SqlViewText4Gene) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.SqlViewText4Gene, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.SqlViewText4Gene] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strTextResouce">文本来源</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetTextResouce(this clsvSqlViewEN objvSqlViewEN, string strTextResouce, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResouce, convSqlView.TextResouce);
clsCheckSql.CheckFieldLen(strTextResouce, 100, convSqlView.TextResouce);
objvSqlViewEN.TextResouce = strTextResouce; //文本来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.TextResouce) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.TextResouce, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.TextResouce] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strTextResourceTypeId">文本来源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetTextResourceTypeId(this clsvSqlViewEN objvSqlViewEN, string strTextResourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResourceTypeId, convSqlView.TextResourceTypeId);
clsCheckSql.CheckFieldLen(strTextResourceTypeId, 2, convSqlView.TextResourceTypeId);
clsCheckSql.CheckFieldForeignKey(strTextResourceTypeId, 2, convSqlView.TextResourceTypeId);
objvSqlViewEN.TextResourceTypeId = strTextResourceTypeId; //文本来源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.TextResourceTypeId) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.TextResourceTypeId, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.TextResourceTypeId] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strTextResourceTypeName">文本来源类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetTextResourceTypeName(this clsvSqlViewEN objvSqlViewEN, string strTextResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResourceTypeName, convSqlView.TextResourceTypeName);
clsCheckSql.CheckFieldLen(strTextResourceTypeName, 30, convSqlView.TextResourceTypeName);
objvSqlViewEN.TextResourceTypeName = strTextResourceTypeName; //文本来源类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.TextResourceTypeName) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.TextResourceTypeName, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.TextResourceTypeName] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabId">相关表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetRelaTabId(this clsvSqlViewEN objvSqlViewEN, string strRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRelaTabId, convSqlView.RelaTabId);
clsCheckSql.CheckFieldLen(strRelaTabId, 8, convSqlView.RelaTabId);
clsCheckSql.CheckFieldForeignKey(strRelaTabId, 8, convSqlView.RelaTabId);
objvSqlViewEN.RelaTabId = strRelaTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.RelaTabId) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.RelaTabId, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.RelaTabId] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabStateId">表状态ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetTabStateId(this clsvSqlViewEN objvSqlViewEN, string strTabStateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convSqlView.TabStateId);
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convSqlView.TabStateId);
objvSqlViewEN.TabStateId = strTabStateId; //表状态ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.TabStateId) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.TabStateId, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.TabStateId] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetFuncModuleAgcId(this clsvSqlViewEN objvSqlViewEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convSqlView.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convSqlView.FuncModuleAgcId);
objvSqlViewEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.FuncModuleAgcId) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.FuncModuleAgcId, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.FuncModuleAgcId] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum4Refer">引用序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetOrderNum4Refer(this clsvSqlViewEN objvSqlViewEN, int intOrderNum4Refer, string strComparisonOp="")
	{
objvSqlViewEN.OrderNum4Refer = intOrderNum4Refer; //引用序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.OrderNum4Refer) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.OrderNum4Refer, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.OrderNum4Refer] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strAnalysisDate">分析日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetAnalysisDate(this clsvSqlViewEN objvSqlViewEN, string strAnalysisDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnalysisDate, 20, convSqlView.AnalysisDate);
objvSqlViewEN.AnalysisDate = strAnalysisDate; //分析日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.AnalysisDate) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.AnalysisDate, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.AnalysisDate] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strGeneCodeDate">生成代码日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetGeneCodeDate(this clsvSqlViewEN objvSqlViewEN, string strGeneCodeDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convSqlView.GeneCodeDate);
objvSqlViewEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.GeneCodeDate) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.GeneCodeDate, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.GeneCodeDate] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strTopPercent">顶百分比</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetTopPercent(this clsvSqlViewEN objvSqlViewEN, string strTopPercent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTopPercent, 200, convSqlView.TopPercent);
objvSqlViewEN.TopPercent = strTopPercent; //顶百分比
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.TopPercent) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.TopPercent, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.TopPercent] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strDistinctFlag">Distinct标志</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetDistinctFlag(this clsvSqlViewEN objvSqlViewEN, string strDistinctFlag, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDistinctFlag, 100, convSqlView.DistinctFlag);
objvSqlViewEN.DistinctFlag = strDistinctFlag; //Distinct标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.DistinctFlag) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.DistinctFlag, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.DistinctFlag] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strWhereCondition">条件串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetWhereCondition(this clsvSqlViewEN objvSqlViewEN, string strWhereCondition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWhereCondition, 500, convSqlView.WhereCondition);
objvSqlViewEN.WhereCondition = strWhereCondition; //条件串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.WhereCondition) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.WhereCondition, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.WhereCondition] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strGroupBy">分组</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetGroupBy(this clsvSqlViewEN objvSqlViewEN, string strGroupBy, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGroupBy, 1000, convSqlView.GroupBy);
objvSqlViewEN.GroupBy = strGroupBy; //分组
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.GroupBy) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.GroupBy, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.GroupBy] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strHavingStr">分组过滤</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetHavingStr(this clsvSqlViewEN objvSqlViewEN, string strHavingStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHavingStr, 200, convSqlView.HavingStr);
objvSqlViewEN.HavingStr = strHavingStr; //分组过滤
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.HavingStr) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.HavingStr, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.HavingStr] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strOrderBy">排序</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetOrderBy(this clsvSqlViewEN objvSqlViewEN, string strOrderBy, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOrderBy, 100, convSqlView.OrderBy);
objvSqlViewEN.OrderBy = strOrderBy; //排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.OrderBy) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.OrderBy, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.OrderBy] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetErrMsg(this clsvSqlViewEN objvSqlViewEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, convSqlView.ErrMsg);
objvSqlViewEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.ErrMsg) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.ErrMsg, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.ErrMsg] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetPrjId(this clsvSqlViewEN objvSqlViewEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convSqlView.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convSqlView.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convSqlView.PrjId);
objvSqlViewEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.PrjId) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.PrjId, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.PrjId] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetPrjName(this clsvSqlViewEN objvSqlViewEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convSqlView.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convSqlView.PrjName);
objvSqlViewEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.PrjName) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.PrjName, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.PrjName] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetUpdDate(this clsvSqlViewEN objvSqlViewEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSqlView.UpdDate);
objvSqlViewEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.UpdDate) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.UpdDate, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.UpdDate] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetUpdUserId(this clsvSqlViewEN objvSqlViewEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSqlView.UpdUserId);
objvSqlViewEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.UpdUserId) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.UpdUserId, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.UpdUserId] = strComparisonOp;
}
}
return objvSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetMemo(this clsvSqlViewEN objvSqlViewEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSqlView.Memo);
objvSqlViewEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSqlViewEN.dicFldComparisonOp.ContainsKey(convSqlView.Memo) == false)
{
objvSqlViewEN.dicFldComparisonOp.Add(convSqlView.Memo, strComparisonOp);
}
else
{
objvSqlViewEN.dicFldComparisonOp[convSqlView.Memo] = strComparisonOp;
}
}
return objvSqlViewEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSqlViewEN objvSqlViewCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSqlViewCond.IsUpdated(convSqlView.SqlViewId) == true)
{
string strComparisonOpSqlViewId = objvSqlViewCond.dicFldComparisonOp[convSqlView.SqlViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.SqlViewId, objvSqlViewCond.SqlViewId, strComparisonOpSqlViewId);
}
if (objvSqlViewCond.IsUpdated(convSqlView.SqlViewName) == true)
{
string strComparisonOpSqlViewName = objvSqlViewCond.dicFldComparisonOp[convSqlView.SqlViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.SqlViewName, objvSqlViewCond.SqlViewName, strComparisonOpSqlViewName);
}
if (objvSqlViewCond.IsUpdated(convSqlView.SqlViewCNName) == true)
{
string strComparisonOpSqlViewCNName = objvSqlViewCond.dicFldComparisonOp[convSqlView.SqlViewCNName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.SqlViewCNName, objvSqlViewCond.SqlViewCNName, strComparisonOpSqlViewCNName);
}
if (objvSqlViewCond.IsUpdated(convSqlView.SqlViewText) == true)
{
string strComparisonOpSqlViewText = objvSqlViewCond.dicFldComparisonOp[convSqlView.SqlViewText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.SqlViewText, objvSqlViewCond.SqlViewText, strComparisonOpSqlViewText);
}
if (objvSqlViewCond.IsUpdated(convSqlView.SqlViewText4Gene) == true)
{
string strComparisonOpSqlViewText4Gene = objvSqlViewCond.dicFldComparisonOp[convSqlView.SqlViewText4Gene];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.SqlViewText4Gene, objvSqlViewCond.SqlViewText4Gene, strComparisonOpSqlViewText4Gene);
}
if (objvSqlViewCond.IsUpdated(convSqlView.TextResouce) == true)
{
string strComparisonOpTextResouce = objvSqlViewCond.dicFldComparisonOp[convSqlView.TextResouce];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.TextResouce, objvSqlViewCond.TextResouce, strComparisonOpTextResouce);
}
if (objvSqlViewCond.IsUpdated(convSqlView.TextResourceTypeId) == true)
{
string strComparisonOpTextResourceTypeId = objvSqlViewCond.dicFldComparisonOp[convSqlView.TextResourceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.TextResourceTypeId, objvSqlViewCond.TextResourceTypeId, strComparisonOpTextResourceTypeId);
}
if (objvSqlViewCond.IsUpdated(convSqlView.TextResourceTypeName) == true)
{
string strComparisonOpTextResourceTypeName = objvSqlViewCond.dicFldComparisonOp[convSqlView.TextResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.TextResourceTypeName, objvSqlViewCond.TextResourceTypeName, strComparisonOpTextResourceTypeName);
}
if (objvSqlViewCond.IsUpdated(convSqlView.RelaTabId) == true)
{
string strComparisonOpRelaTabId = objvSqlViewCond.dicFldComparisonOp[convSqlView.RelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.RelaTabId, objvSqlViewCond.RelaTabId, strComparisonOpRelaTabId);
}
if (objvSqlViewCond.IsUpdated(convSqlView.TabStateId) == true)
{
string strComparisonOpTabStateId = objvSqlViewCond.dicFldComparisonOp[convSqlView.TabStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.TabStateId, objvSqlViewCond.TabStateId, strComparisonOpTabStateId);
}
if (objvSqlViewCond.IsUpdated(convSqlView.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvSqlViewCond.dicFldComparisonOp[convSqlView.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.FuncModuleAgcId, objvSqlViewCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvSqlViewCond.IsUpdated(convSqlView.OrderNum4Refer) == true)
{
string strComparisonOpOrderNum4Refer = objvSqlViewCond.dicFldComparisonOp[convSqlView.OrderNum4Refer];
strWhereCond += string.Format(" And {0} {2} {1}", convSqlView.OrderNum4Refer, objvSqlViewCond.OrderNum4Refer, strComparisonOpOrderNum4Refer);
}
if (objvSqlViewCond.IsUpdated(convSqlView.AnalysisDate) == true)
{
string strComparisonOpAnalysisDate = objvSqlViewCond.dicFldComparisonOp[convSqlView.AnalysisDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.AnalysisDate, objvSqlViewCond.AnalysisDate, strComparisonOpAnalysisDate);
}
if (objvSqlViewCond.IsUpdated(convSqlView.GeneCodeDate) == true)
{
string strComparisonOpGeneCodeDate = objvSqlViewCond.dicFldComparisonOp[convSqlView.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.GeneCodeDate, objvSqlViewCond.GeneCodeDate, strComparisonOpGeneCodeDate);
}
if (objvSqlViewCond.IsUpdated(convSqlView.TopPercent) == true)
{
string strComparisonOpTopPercent = objvSqlViewCond.dicFldComparisonOp[convSqlView.TopPercent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.TopPercent, objvSqlViewCond.TopPercent, strComparisonOpTopPercent);
}
if (objvSqlViewCond.IsUpdated(convSqlView.DistinctFlag) == true)
{
string strComparisonOpDistinctFlag = objvSqlViewCond.dicFldComparisonOp[convSqlView.DistinctFlag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.DistinctFlag, objvSqlViewCond.DistinctFlag, strComparisonOpDistinctFlag);
}
if (objvSqlViewCond.IsUpdated(convSqlView.WhereCondition) == true)
{
string strComparisonOpWhereCondition = objvSqlViewCond.dicFldComparisonOp[convSqlView.WhereCondition];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.WhereCondition, objvSqlViewCond.WhereCondition, strComparisonOpWhereCondition);
}
if (objvSqlViewCond.IsUpdated(convSqlView.GroupBy) == true)
{
string strComparisonOpGroupBy = objvSqlViewCond.dicFldComparisonOp[convSqlView.GroupBy];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.GroupBy, objvSqlViewCond.GroupBy, strComparisonOpGroupBy);
}
if (objvSqlViewCond.IsUpdated(convSqlView.HavingStr) == true)
{
string strComparisonOpHavingStr = objvSqlViewCond.dicFldComparisonOp[convSqlView.HavingStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.HavingStr, objvSqlViewCond.HavingStr, strComparisonOpHavingStr);
}
if (objvSqlViewCond.IsUpdated(convSqlView.OrderBy) == true)
{
string strComparisonOpOrderBy = objvSqlViewCond.dicFldComparisonOp[convSqlView.OrderBy];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.OrderBy, objvSqlViewCond.OrderBy, strComparisonOpOrderBy);
}
if (objvSqlViewCond.IsUpdated(convSqlView.ErrMsg) == true)
{
string strComparisonOpErrMsg = objvSqlViewCond.dicFldComparisonOp[convSqlView.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.ErrMsg, objvSqlViewCond.ErrMsg, strComparisonOpErrMsg);
}
if (objvSqlViewCond.IsUpdated(convSqlView.PrjId) == true)
{
string strComparisonOpPrjId = objvSqlViewCond.dicFldComparisonOp[convSqlView.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.PrjId, objvSqlViewCond.PrjId, strComparisonOpPrjId);
}
if (objvSqlViewCond.IsUpdated(convSqlView.PrjName) == true)
{
string strComparisonOpPrjName = objvSqlViewCond.dicFldComparisonOp[convSqlView.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.PrjName, objvSqlViewCond.PrjName, strComparisonOpPrjName);
}
if (objvSqlViewCond.IsUpdated(convSqlView.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSqlViewCond.dicFldComparisonOp[convSqlView.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.UpdDate, objvSqlViewCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSqlViewCond.IsUpdated(convSqlView.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvSqlViewCond.dicFldComparisonOp[convSqlView.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.UpdUserId, objvSqlViewCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvSqlViewCond.IsUpdated(convSqlView.Memo) == true)
{
string strComparisonOpMemo = objvSqlViewCond.dicFldComparisonOp[convSqlView.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSqlView.Memo, objvSqlViewCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vSql视图(vSqlView)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSqlViewWApi
{
private static readonly string mstrApiControllerName = "vSqlViewApi";

 public clsvSqlViewWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_SqlViewId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vSql视图]...","0");
List<clsvSqlViewEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="SqlViewId";
objDDL.DataTextField="SqlViewName";
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

 /// <param name = "strPrjId"></param>
public static void BindCbo_SqlViewId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convSqlView.SqlViewId); 
List<clsvSqlViewEN> arrObjLst = clsvSqlViewWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN()
{
SqlViewId = "0",
SqlViewName = "选[vSql视图]..."
};
arrObjLstSel.Insert(0, objvSqlViewEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convSqlView.SqlViewId;
objComboBox.DisplayMember = convSqlView.SqlViewName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strSqlViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSqlViewEN GetObjBySqlViewId(string strSqlViewId)
{
if (strSqlViewId == "") return null;
string strAction = "GetObjBySqlViewId";
clsvSqlViewEN objvSqlViewEN;
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
objvSqlViewEN = JsonConvert.DeserializeObject<clsvSqlViewEN>(strJson);
return objvSqlViewEN;
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
public static clsvSqlViewEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvSqlViewEN objvSqlViewEN;
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
objvSqlViewEN = JsonConvert.DeserializeObject<clsvSqlViewEN>(strJson);
return objvSqlViewEN;
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
//该表没有使用Cache,不需要生成[GetSqlViewNameBySqlViewIdCache]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlViewEN> GetObjLst(string strWhereCond)
{
 List<clsvSqlViewEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewEN>>(strJson);
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
public static List<clsvSqlViewEN> GetObjLstBySqlViewIdLst(List<string> arrSqlViewId)
{
 List<clsvSqlViewEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewEN>>(strJson);
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
public static List<clsvSqlViewEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvSqlViewEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewEN>>(strJson);
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
public static List<clsvSqlViewEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvSqlViewEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewEN>>(strJson);
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
public static List<clsvSqlViewEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvSqlViewEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewEN>>(strJson);
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
public static List<clsvSqlViewEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvSqlViewEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSqlViewEN>>(strJson);
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
 /// <param name = "objvSqlViewENS">源对象</param>
 /// <param name = "objvSqlViewENT">目标对象</param>
 public static void CopyTo(clsvSqlViewEN objvSqlViewENS, clsvSqlViewEN objvSqlViewENT)
{
try
{
objvSqlViewENT.SqlViewId = objvSqlViewENS.SqlViewId; //Sql视图Id
objvSqlViewENT.SqlViewName = objvSqlViewENS.SqlViewName; //数据视图名称
objvSqlViewENT.SqlViewCNName = objvSqlViewENS.SqlViewCNName; //Sql视图中文名
objvSqlViewENT.SqlViewText = objvSqlViewENS.SqlViewText; //Sql视图文本内容
objvSqlViewENT.SqlViewText4Gene = objvSqlViewENS.SqlViewText4Gene; //Sql视图文本4生成
objvSqlViewENT.TextResouce = objvSqlViewENS.TextResouce; //文本来源
objvSqlViewENT.TextResourceTypeId = objvSqlViewENS.TextResourceTypeId; //文本来源类型Id
objvSqlViewENT.TextResourceTypeName = objvSqlViewENS.TextResourceTypeName; //文本来源类型名
objvSqlViewENT.RelaTabId = objvSqlViewENS.RelaTabId; //相关表Id
objvSqlViewENT.TabStateId = objvSqlViewENS.TabStateId; //表状态ID
objvSqlViewENT.FuncModuleAgcId = objvSqlViewENS.FuncModuleAgcId; //功能模块Id
objvSqlViewENT.OrderNum4Refer = objvSqlViewENS.OrderNum4Refer; //引用序号
objvSqlViewENT.AnalysisDate = objvSqlViewENS.AnalysisDate; //分析日期
objvSqlViewENT.GeneCodeDate = objvSqlViewENS.GeneCodeDate; //生成代码日期
objvSqlViewENT.TopPercent = objvSqlViewENS.TopPercent; //顶百分比
objvSqlViewENT.DistinctFlag = objvSqlViewENS.DistinctFlag; //Distinct标志
objvSqlViewENT.WhereCondition = objvSqlViewENS.WhereCondition; //条件串
objvSqlViewENT.GroupBy = objvSqlViewENS.GroupBy; //分组
objvSqlViewENT.HavingStr = objvSqlViewENS.HavingStr; //分组过滤
objvSqlViewENT.OrderBy = objvSqlViewENS.OrderBy; //排序
objvSqlViewENT.ErrMsg = objvSqlViewENS.ErrMsg; //错误信息
objvSqlViewENT.PrjId = objvSqlViewENS.PrjId; //工程Id
objvSqlViewENT.PrjName = objvSqlViewENS.PrjName; //工程名称
objvSqlViewENT.UpdDate = objvSqlViewENS.UpdDate; //修改日期
objvSqlViewENT.UpdUserId = objvSqlViewENS.UpdUserId; //修改用户Id
objvSqlViewENT.Memo = objvSqlViewENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvSqlViewEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvSqlViewEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvSqlViewEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvSqlViewEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvSqlViewEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvSqlViewEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId = "")
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvSqlViewWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvSqlViewWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvSqlViewEN._CurrTabName, strPrjId);
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
public static DataTable GetDataTableByObjLst(List<clsvSqlViewEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convSqlView.SqlViewId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.SqlViewName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.SqlViewCNName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.SqlViewText, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.SqlViewText4Gene, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.TextResouce, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.TextResourceTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.TextResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.RelaTabId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.TabStateId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.OrderNum4Refer, Type.GetType("System.Int32"));
objDT.Columns.Add(convSqlView.AnalysisDate, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.GeneCodeDate, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.TopPercent, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.DistinctFlag, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.WhereCondition, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.GroupBy, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.HavingStr, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.OrderBy, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convSqlView.Memo, Type.GetType("System.String"));
foreach (clsvSqlViewEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convSqlView.SqlViewId] = objInFor[convSqlView.SqlViewId];
objDR[convSqlView.SqlViewName] = objInFor[convSqlView.SqlViewName];
objDR[convSqlView.SqlViewCNName] = objInFor[convSqlView.SqlViewCNName];
objDR[convSqlView.SqlViewText] = objInFor[convSqlView.SqlViewText];
objDR[convSqlView.SqlViewText4Gene] = objInFor[convSqlView.SqlViewText4Gene];
objDR[convSqlView.TextResouce] = objInFor[convSqlView.TextResouce];
objDR[convSqlView.TextResourceTypeId] = objInFor[convSqlView.TextResourceTypeId];
objDR[convSqlView.TextResourceTypeName] = objInFor[convSqlView.TextResourceTypeName];
objDR[convSqlView.RelaTabId] = objInFor[convSqlView.RelaTabId];
objDR[convSqlView.TabStateId] = objInFor[convSqlView.TabStateId];
objDR[convSqlView.FuncModuleAgcId] = objInFor[convSqlView.FuncModuleAgcId];
objDR[convSqlView.OrderNum4Refer] = objInFor[convSqlView.OrderNum4Refer];
objDR[convSqlView.AnalysisDate] = objInFor[convSqlView.AnalysisDate];
objDR[convSqlView.GeneCodeDate] = objInFor[convSqlView.GeneCodeDate];
objDR[convSqlView.TopPercent] = objInFor[convSqlView.TopPercent];
objDR[convSqlView.DistinctFlag] = objInFor[convSqlView.DistinctFlag];
objDR[convSqlView.WhereCondition] = objInFor[convSqlView.WhereCondition];
objDR[convSqlView.GroupBy] = objInFor[convSqlView.GroupBy];
objDR[convSqlView.HavingStr] = objInFor[convSqlView.HavingStr];
objDR[convSqlView.OrderBy] = objInFor[convSqlView.OrderBy];
objDR[convSqlView.ErrMsg] = objInFor[convSqlView.ErrMsg];
objDR[convSqlView.PrjId] = objInFor[convSqlView.PrjId];
objDR[convSqlView.PrjName] = objInFor[convSqlView.PrjName];
objDR[convSqlView.UpdDate] = objInFor[convSqlView.UpdDate];
objDR[convSqlView.UpdUserId] = objInFor[convSqlView.UpdUserId];
objDR[convSqlView.Memo] = objInFor[convSqlView.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}