
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlViewWApi
 表名:SqlView(00050245)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:26
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
public static class  clsSqlViewWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewId">Sql视图Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetSqlViewId(this clsSqlViewEN objSqlViewEN, string strSqlViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlViewId, 8, conSqlView.SqlViewId);
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, conSqlView.SqlViewId);
objSqlViewEN.SqlViewId = strSqlViewId; //Sql视图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.SqlViewId) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.SqlViewId, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.SqlViewId] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewText">Sql视图文本内容</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetSqlViewText(this clsSqlViewEN objSqlViewEN, string strSqlViewText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlViewText, 8000, conSqlView.SqlViewText);
objSqlViewEN.SqlViewText = strSqlViewText; //Sql视图文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.SqlViewText) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.SqlViewText, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.SqlViewText] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strSqlViewText4Gene">Sql视图文本4生成</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetSqlViewText4Gene(this clsSqlViewEN objSqlViewEN, string strSqlViewText4Gene, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSqlViewText4Gene, 8000, conSqlView.SqlViewText4Gene);
objSqlViewEN.SqlViewText4Gene = strSqlViewText4Gene; //Sql视图文本4生成
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.SqlViewText4Gene) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.SqlViewText4Gene, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.SqlViewText4Gene] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strTextResouce">文本来源</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetTextResouce(this clsSqlViewEN objSqlViewEN, string strTextResouce, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResouce, conSqlView.TextResouce);
clsCheckSql.CheckFieldLen(strTextResouce, 100, conSqlView.TextResouce);
objSqlViewEN.TextResouce = strTextResouce; //文本来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.TextResouce) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.TextResouce, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.TextResouce] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strTextResourceTypeId">文本来源类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetTextResourceTypeId(this clsSqlViewEN objSqlViewEN, string strTextResourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResourceTypeId, conSqlView.TextResourceTypeId);
clsCheckSql.CheckFieldLen(strTextResourceTypeId, 2, conSqlView.TextResourceTypeId);
clsCheckSql.CheckFieldForeignKey(strTextResourceTypeId, 2, conSqlView.TextResourceTypeId);
objSqlViewEN.TextResourceTypeId = strTextResourceTypeId; //文本来源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.TextResourceTypeId) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.TextResourceTypeId, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.TextResourceTypeId] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelaTabId">相关表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetRelaTabId(this clsSqlViewEN objSqlViewEN, string strRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRelaTabId, conSqlView.RelaTabId);
clsCheckSql.CheckFieldLen(strRelaTabId, 8, conSqlView.RelaTabId);
clsCheckSql.CheckFieldForeignKey(strRelaTabId, 8, conSqlView.RelaTabId);
objSqlViewEN.RelaTabId = strRelaTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.RelaTabId) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.RelaTabId, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.RelaTabId] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strAnalysisDate">分析日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetAnalysisDate(this clsSqlViewEN objSqlViewEN, string strAnalysisDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnalysisDate, 20, conSqlView.AnalysisDate);
objSqlViewEN.AnalysisDate = strAnalysisDate; //分析日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.AnalysisDate) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.AnalysisDate, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.AnalysisDate] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strGeneCodeDate">生成代码日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetGeneCodeDate(this clsSqlViewEN objSqlViewEN, string strGeneCodeDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, conSqlView.GeneCodeDate);
objSqlViewEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.GeneCodeDate) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.GeneCodeDate, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.GeneCodeDate] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strCreateDate">建立日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetCreateDate(this clsSqlViewEN objSqlViewEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conSqlView.CreateDate);
objSqlViewEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.CreateDate) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.CreateDate, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.CreateDate] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strTopPercent">顶百分比</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetTopPercent(this clsSqlViewEN objSqlViewEN, string strTopPercent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTopPercent, 200, conSqlView.TopPercent);
objSqlViewEN.TopPercent = strTopPercent; //顶百分比
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.TopPercent) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.TopPercent, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.TopPercent] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strDistinctFlag">Distinct标志</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetDistinctFlag(this clsSqlViewEN objSqlViewEN, string strDistinctFlag, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDistinctFlag, 100, conSqlView.DistinctFlag);
objSqlViewEN.DistinctFlag = strDistinctFlag; //Distinct标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.DistinctFlag) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.DistinctFlag, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.DistinctFlag] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strWhereCondition">条件串</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetWhereCondition(this clsSqlViewEN objSqlViewEN, string strWhereCondition, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWhereCondition, 500, conSqlView.WhereCondition);
objSqlViewEN.WhereCondition = strWhereCondition; //条件串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.WhereCondition) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.WhereCondition, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.WhereCondition] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strGroupBy">分组</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetGroupBy(this clsSqlViewEN objSqlViewEN, string strGroupBy, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGroupBy, 1000, conSqlView.GroupBy);
objSqlViewEN.GroupBy = strGroupBy; //分组
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.GroupBy) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.GroupBy, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.GroupBy] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strHavingStr">分组过滤</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetHavingStr(this clsSqlViewEN objSqlViewEN, string strHavingStr, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHavingStr, 200, conSqlView.HavingStr);
objSqlViewEN.HavingStr = strHavingStr; //分组过滤
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.HavingStr) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.HavingStr, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.HavingStr] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strOrderBy">排序</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetOrderBy(this clsSqlViewEN objSqlViewEN, string strOrderBy, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOrderBy, 100, conSqlView.OrderBy);
objSqlViewEN.OrderBy = strOrderBy; //排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.OrderBy) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.OrderBy, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.OrderBy] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetErrMsg(this clsSqlViewEN objSqlViewEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conSqlView.ErrMsg);
objSqlViewEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.ErrMsg) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.ErrMsg, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.ErrMsg] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetPrjId(this clsSqlViewEN objSqlViewEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conSqlView.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conSqlView.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conSqlView.PrjId);
objSqlViewEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.PrjId) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.PrjId, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.PrjId] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetUpdDate(this clsSqlViewEN objSqlViewEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSqlView.UpdDate);
objSqlViewEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.UpdDate) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.UpdDate, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.UpdDate] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetUpdUserId(this clsSqlViewEN objSqlViewEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSqlView.UpdUserId);
objSqlViewEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.UpdUserId) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.UpdUserId, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.UpdUserId] = strComparisonOp;
}
}
return objSqlViewEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSqlViewEN SetMemo(this clsSqlViewEN objSqlViewEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSqlView.Memo);
objSqlViewEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSqlViewEN.dicFldComparisonOp.ContainsKey(conSqlView.Memo) == false)
{
objSqlViewEN.dicFldComparisonOp.Add(conSqlView.Memo, strComparisonOp);
}
else
{
objSqlViewEN.dicFldComparisonOp[conSqlView.Memo] = strComparisonOp;
}
}
return objSqlViewEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSqlViewEN objSqlViewCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSqlViewCond.IsUpdated(conSqlView.SqlViewId) == true)
{
string strComparisonOpSqlViewId = objSqlViewCond.dicFldComparisonOp[conSqlView.SqlViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.SqlViewId, objSqlViewCond.SqlViewId, strComparisonOpSqlViewId);
}
if (objSqlViewCond.IsUpdated(conSqlView.SqlViewText) == true)
{
string strComparisonOpSqlViewText = objSqlViewCond.dicFldComparisonOp[conSqlView.SqlViewText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.SqlViewText, objSqlViewCond.SqlViewText, strComparisonOpSqlViewText);
}
if (objSqlViewCond.IsUpdated(conSqlView.SqlViewText4Gene) == true)
{
string strComparisonOpSqlViewText4Gene = objSqlViewCond.dicFldComparisonOp[conSqlView.SqlViewText4Gene];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.SqlViewText4Gene, objSqlViewCond.SqlViewText4Gene, strComparisonOpSqlViewText4Gene);
}
if (objSqlViewCond.IsUpdated(conSqlView.TextResouce) == true)
{
string strComparisonOpTextResouce = objSqlViewCond.dicFldComparisonOp[conSqlView.TextResouce];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.TextResouce, objSqlViewCond.TextResouce, strComparisonOpTextResouce);
}
if (objSqlViewCond.IsUpdated(conSqlView.TextResourceTypeId) == true)
{
string strComparisonOpTextResourceTypeId = objSqlViewCond.dicFldComparisonOp[conSqlView.TextResourceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.TextResourceTypeId, objSqlViewCond.TextResourceTypeId, strComparisonOpTextResourceTypeId);
}
if (objSqlViewCond.IsUpdated(conSqlView.RelaTabId) == true)
{
string strComparisonOpRelaTabId = objSqlViewCond.dicFldComparisonOp[conSqlView.RelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.RelaTabId, objSqlViewCond.RelaTabId, strComparisonOpRelaTabId);
}
if (objSqlViewCond.IsUpdated(conSqlView.AnalysisDate) == true)
{
string strComparisonOpAnalysisDate = objSqlViewCond.dicFldComparisonOp[conSqlView.AnalysisDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.AnalysisDate, objSqlViewCond.AnalysisDate, strComparisonOpAnalysisDate);
}
if (objSqlViewCond.IsUpdated(conSqlView.GeneCodeDate) == true)
{
string strComparisonOpGeneCodeDate = objSqlViewCond.dicFldComparisonOp[conSqlView.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.GeneCodeDate, objSqlViewCond.GeneCodeDate, strComparisonOpGeneCodeDate);
}
if (objSqlViewCond.IsUpdated(conSqlView.CreateDate) == true)
{
string strComparisonOpCreateDate = objSqlViewCond.dicFldComparisonOp[conSqlView.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.CreateDate, objSqlViewCond.CreateDate, strComparisonOpCreateDate);
}
if (objSqlViewCond.IsUpdated(conSqlView.TopPercent) == true)
{
string strComparisonOpTopPercent = objSqlViewCond.dicFldComparisonOp[conSqlView.TopPercent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.TopPercent, objSqlViewCond.TopPercent, strComparisonOpTopPercent);
}
if (objSqlViewCond.IsUpdated(conSqlView.DistinctFlag) == true)
{
string strComparisonOpDistinctFlag = objSqlViewCond.dicFldComparisonOp[conSqlView.DistinctFlag];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.DistinctFlag, objSqlViewCond.DistinctFlag, strComparisonOpDistinctFlag);
}
if (objSqlViewCond.IsUpdated(conSqlView.WhereCondition) == true)
{
string strComparisonOpWhereCondition = objSqlViewCond.dicFldComparisonOp[conSqlView.WhereCondition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.WhereCondition, objSqlViewCond.WhereCondition, strComparisonOpWhereCondition);
}
if (objSqlViewCond.IsUpdated(conSqlView.GroupBy) == true)
{
string strComparisonOpGroupBy = objSqlViewCond.dicFldComparisonOp[conSqlView.GroupBy];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.GroupBy, objSqlViewCond.GroupBy, strComparisonOpGroupBy);
}
if (objSqlViewCond.IsUpdated(conSqlView.HavingStr) == true)
{
string strComparisonOpHavingStr = objSqlViewCond.dicFldComparisonOp[conSqlView.HavingStr];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.HavingStr, objSqlViewCond.HavingStr, strComparisonOpHavingStr);
}
if (objSqlViewCond.IsUpdated(conSqlView.OrderBy) == true)
{
string strComparisonOpOrderBy = objSqlViewCond.dicFldComparisonOp[conSqlView.OrderBy];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.OrderBy, objSqlViewCond.OrderBy, strComparisonOpOrderBy);
}
if (objSqlViewCond.IsUpdated(conSqlView.ErrMsg) == true)
{
string strComparisonOpErrMsg = objSqlViewCond.dicFldComparisonOp[conSqlView.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.ErrMsg, objSqlViewCond.ErrMsg, strComparisonOpErrMsg);
}
if (objSqlViewCond.IsUpdated(conSqlView.PrjId) == true)
{
string strComparisonOpPrjId = objSqlViewCond.dicFldComparisonOp[conSqlView.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.PrjId, objSqlViewCond.PrjId, strComparisonOpPrjId);
}
if (objSqlViewCond.IsUpdated(conSqlView.UpdDate) == true)
{
string strComparisonOpUpdDate = objSqlViewCond.dicFldComparisonOp[conSqlView.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.UpdDate, objSqlViewCond.UpdDate, strComparisonOpUpdDate);
}
if (objSqlViewCond.IsUpdated(conSqlView.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objSqlViewCond.dicFldComparisonOp[conSqlView.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.UpdUserId, objSqlViewCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objSqlViewCond.IsUpdated(conSqlView.Memo) == true)
{
string strComparisonOpMemo = objSqlViewCond.dicFldComparisonOp[conSqlView.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSqlView.Memo, objSqlViewCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objSqlViewEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSqlViewEN objSqlViewEN)
{
 if (string.IsNullOrEmpty(objSqlViewEN.SqlViewId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objSqlViewEN.sfUpdFldSetStr = objSqlViewEN.getsfUpdFldSetStr();
clsSqlViewWApi.CheckPropertyNew(objSqlViewEN); 
bool bolResult = clsSqlViewWApi.UpdateRecord(objSqlViewEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 获取唯一性条件串--SqlView(Sql视图), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RelaTabId_PrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSqlViewEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsSqlViewEN objSqlViewEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSqlViewEN == null) return "";
if (objSqlViewEN.SqlViewId == null || objSqlViewEN.SqlViewId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewEN.RelaTabId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSqlViewEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SqlViewId !=  '{0}'", objSqlViewEN.SqlViewId);
 sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewEN.RelaTabId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSqlViewEN.PrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSqlViewEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSqlViewEN objSqlViewEN)
{
try
{
 if (string.IsNullOrEmpty(objSqlViewEN.SqlViewId) == true || clsSqlViewWApi.IsExist(objSqlViewEN.SqlViewId) == true)
 {
     objSqlViewEN.SqlViewId = clsSqlViewWApi.GetMaxStrId();
 }
clsSqlViewWApi.CheckPropertyNew(objSqlViewEN); 
bool bolResult = clsSqlViewWApi.AddNewRecord(objSqlViewEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objSqlViewEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSqlViewEN objSqlViewEN)
{
try
{
clsSqlViewWApi.CheckPropertyNew(objSqlViewEN); 
string strSqlViewId = clsSqlViewWApi.AddNewRecordWithMaxId(objSqlViewEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return strSqlViewId;
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
 /// <param name = "objSqlViewEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSqlViewEN objSqlViewEN, string strWhereCond)
{
try
{
clsSqlViewWApi.CheckPropertyNew(objSqlViewEN); 
bool bolResult = clsSqlViewWApi.UpdateWithCondition(objSqlViewEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// Sql视图(SqlView)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsSqlViewWApi
{
private static readonly string mstrApiControllerName = "SqlViewApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsSqlViewWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsSqlViewEN objSqlViewEN)
{
if (!Object.Equals(null, objSqlViewEN.SqlViewId) && GetStrLen(objSqlViewEN.SqlViewId) > 8)
{
 throw new Exception("字段[Sql视图Id]的长度不能超过8!");
}
if (!Object.Equals(null, objSqlViewEN.SqlViewText) && GetStrLen(objSqlViewEN.SqlViewText) > 8000)
{
 throw new Exception("字段[Sql视图文本内容]的长度不能超过8000!");
}
if (!Object.Equals(null, objSqlViewEN.SqlViewText4Gene) && GetStrLen(objSqlViewEN.SqlViewText4Gene) > 8000)
{
 throw new Exception("字段[Sql视图文本4生成]的长度不能超过8000!");
}
if (!Object.Equals(null, objSqlViewEN.TextResouce) && GetStrLen(objSqlViewEN.TextResouce) > 100)
{
 throw new Exception("字段[文本来源]的长度不能超过100!");
}
if (!Object.Equals(null, objSqlViewEN.TextResourceTypeId) && GetStrLen(objSqlViewEN.TextResourceTypeId) > 2)
{
 throw new Exception("字段[文本来源类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objSqlViewEN.RelaTabId) && GetStrLen(objSqlViewEN.RelaTabId) > 8)
{
 throw new Exception("字段[相关表Id]的长度不能超过8!");
}
if (!Object.Equals(null, objSqlViewEN.AnalysisDate) && GetStrLen(objSqlViewEN.AnalysisDate) > 20)
{
 throw new Exception("字段[分析日期]的长度不能超过20!");
}
if (!Object.Equals(null, objSqlViewEN.GeneCodeDate) && GetStrLen(objSqlViewEN.GeneCodeDate) > 20)
{
 throw new Exception("字段[生成代码日期]的长度不能超过20!");
}
if (!Object.Equals(null, objSqlViewEN.CreateDate) && GetStrLen(objSqlViewEN.CreateDate) > 20)
{
 throw new Exception("字段[建立日期]的长度不能超过20!");
}
if (!Object.Equals(null, objSqlViewEN.TopPercent) && GetStrLen(objSqlViewEN.TopPercent) > 200)
{
 throw new Exception("字段[顶百分比]的长度不能超过200!");
}
if (!Object.Equals(null, objSqlViewEN.DistinctFlag) && GetStrLen(objSqlViewEN.DistinctFlag) > 100)
{
 throw new Exception("字段[Distinct标志]的长度不能超过100!");
}
if (!Object.Equals(null, objSqlViewEN.WhereCondition) && GetStrLen(objSqlViewEN.WhereCondition) > 500)
{
 throw new Exception("字段[条件串]的长度不能超过500!");
}
if (!Object.Equals(null, objSqlViewEN.GroupBy) && GetStrLen(objSqlViewEN.GroupBy) > 1000)
{
 throw new Exception("字段[分组]的长度不能超过1000!");
}
if (!Object.Equals(null, objSqlViewEN.HavingStr) && GetStrLen(objSqlViewEN.HavingStr) > 200)
{
 throw new Exception("字段[分组过滤]的长度不能超过200!");
}
if (!Object.Equals(null, objSqlViewEN.OrderBy) && GetStrLen(objSqlViewEN.OrderBy) > 100)
{
 throw new Exception("字段[排序]的长度不能超过100!");
}
if (!Object.Equals(null, objSqlViewEN.ErrMsg) && GetStrLen(objSqlViewEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objSqlViewEN.PrjId) && GetStrLen(objSqlViewEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objSqlViewEN.UpdDate) && GetStrLen(objSqlViewEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objSqlViewEN.UpdUserId) && GetStrLen(objSqlViewEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objSqlViewEN.Memo) && GetStrLen(objSqlViewEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objSqlViewEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strSqlViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSqlViewEN GetObjBySqlViewId(string strSqlViewId)
{
if (strSqlViewId == "") return null;
string strAction = "GetObjBySqlViewId";
clsSqlViewEN objSqlViewEN;
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
objSqlViewEN = JsonConvert.DeserializeObject<clsSqlViewEN>(strJson);
return objSqlViewEN;
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
public static clsSqlViewEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsSqlViewEN objSqlViewEN;
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
objSqlViewEN = JsonConvert.DeserializeObject<clsSqlViewEN>(strJson);
return objSqlViewEN;
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
public static List<clsSqlViewEN> GetObjLst(string strWhereCond)
{
 List<clsSqlViewEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewEN>>(strJson);
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
public static List<clsSqlViewEN> GetObjLstBySqlViewIdLst(List<string> arrSqlViewId)
{
 List<clsSqlViewEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewEN>>(strJson);
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
public static List<clsSqlViewEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsSqlViewEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewEN>>(strJson);
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
public static List<clsSqlViewEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsSqlViewEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewEN>>(strJson);
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
public static List<clsSqlViewEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsSqlViewEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewEN>>(strJson);
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
public static List<clsSqlViewEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsSqlViewEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSqlViewEN>>(strJson);
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
public static int DelRecord(string strSqlViewId)
{
string strAction = "DelRecord";
try
{
 clsSqlViewEN objSqlViewEN = clsSqlViewWApi.GetObjBySqlViewId(strSqlViewId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strSqlViewId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelSqlViews(List<string> arrSqlViewId)
{
string strAction = "DelSqlViews";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrSqlViewId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelSqlViewsByCond(string strWhereCond)
{
string strAction = "DelSqlViewsByCond";
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
public static bool AddNewRecord(clsSqlViewEN objSqlViewEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlViewEN>(objSqlViewEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
public static string AddNewRecordWithMaxId(clsSqlViewEN objSqlViewEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlViewEN>(objSqlViewEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strSqlViewId = (string)jobjReturn0["returnStr"];
return strSqlViewId;
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
public static bool UpdateRecord(clsSqlViewEN objSqlViewEN)
{
if (string.IsNullOrEmpty(objSqlViewEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSqlViewEN.SqlViewId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlViewEN>(objSqlViewEN);
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
 /// <param name = "objSqlViewEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsSqlViewEN objSqlViewEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objSqlViewEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSqlViewEN.SqlViewId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objSqlViewEN.SqlViewId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSqlViewEN>(objSqlViewEN);
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
 /// <param name = "objSqlViewENS">源对象</param>
 /// <param name = "objSqlViewENT">目标对象</param>
 public static void CopyTo(clsSqlViewEN objSqlViewENS, clsSqlViewEN objSqlViewENT)
{
try
{
objSqlViewENT.SqlViewId = objSqlViewENS.SqlViewId; //Sql视图Id
objSqlViewENT.SqlViewText = objSqlViewENS.SqlViewText; //Sql视图文本内容
objSqlViewENT.SqlViewText4Gene = objSqlViewENS.SqlViewText4Gene; //Sql视图文本4生成
objSqlViewENT.TextResouce = objSqlViewENS.TextResouce; //文本来源
objSqlViewENT.TextResourceTypeId = objSqlViewENS.TextResourceTypeId; //文本来源类型Id
objSqlViewENT.RelaTabId = objSqlViewENS.RelaTabId; //相关表Id
objSqlViewENT.AnalysisDate = objSqlViewENS.AnalysisDate; //分析日期
objSqlViewENT.GeneCodeDate = objSqlViewENS.GeneCodeDate; //生成代码日期
objSqlViewENT.CreateDate = objSqlViewENS.CreateDate; //建立日期
objSqlViewENT.TopPercent = objSqlViewENS.TopPercent; //顶百分比
objSqlViewENT.DistinctFlag = objSqlViewENS.DistinctFlag; //Distinct标志
objSqlViewENT.WhereCondition = objSqlViewENS.WhereCondition; //条件串
objSqlViewENT.GroupBy = objSqlViewENS.GroupBy; //分组
objSqlViewENT.HavingStr = objSqlViewENS.HavingStr; //分组过滤
objSqlViewENT.OrderBy = objSqlViewENS.OrderBy; //排序
objSqlViewENT.ErrMsg = objSqlViewENS.ErrMsg; //错误信息
objSqlViewENT.PrjId = objSqlViewENS.PrjId; //工程Id
objSqlViewENT.UpdDate = objSqlViewENS.UpdDate; //修改日期
objSqlViewENT.UpdUserId = objSqlViewENS.UpdUserId; //修改用户Id
objSqlViewENT.Memo = objSqlViewENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsSqlViewEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsSqlViewEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsSqlViewEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsSqlViewEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsSqlViewEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsSqlViewEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsSqlViewWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsSqlViewWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsSqlViewEN._CurrTabName, strPrjId);
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
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsSqlViewWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsSqlViewEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsSqlViewWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
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
public static DataTable GetDataTableByObjLst(List<clsSqlViewEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conSqlView.SqlViewId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.SqlViewText, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.SqlViewText4Gene, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.TextResouce, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.TextResourceTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.RelaTabId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.AnalysisDate, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.GeneCodeDate, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.TopPercent, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.DistinctFlag, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.WhereCondition, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.GroupBy, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.HavingStr, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.OrderBy, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conSqlView.Memo, Type.GetType("System.String"));
foreach (clsSqlViewEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conSqlView.SqlViewId] = objInFor[conSqlView.SqlViewId];
objDR[conSqlView.SqlViewText] = objInFor[conSqlView.SqlViewText];
objDR[conSqlView.SqlViewText4Gene] = objInFor[conSqlView.SqlViewText4Gene];
objDR[conSqlView.TextResouce] = objInFor[conSqlView.TextResouce];
objDR[conSqlView.TextResourceTypeId] = objInFor[conSqlView.TextResourceTypeId];
objDR[conSqlView.RelaTabId] = objInFor[conSqlView.RelaTabId];
objDR[conSqlView.AnalysisDate] = objInFor[conSqlView.AnalysisDate];
objDR[conSqlView.GeneCodeDate] = objInFor[conSqlView.GeneCodeDate];
objDR[conSqlView.CreateDate] = objInFor[conSqlView.CreateDate];
objDR[conSqlView.TopPercent] = objInFor[conSqlView.TopPercent];
objDR[conSqlView.DistinctFlag] = objInFor[conSqlView.DistinctFlag];
objDR[conSqlView.WhereCondition] = objInFor[conSqlView.WhereCondition];
objDR[conSqlView.GroupBy] = objInFor[conSqlView.GroupBy];
objDR[conSqlView.HavingStr] = objInFor[conSqlView.HavingStr];
objDR[conSqlView.OrderBy] = objInFor[conSqlView.OrderBy];
objDR[conSqlView.ErrMsg] = objInFor[conSqlView.ErrMsg];
objDR[conSqlView.PrjId] = objInFor[conSqlView.PrjId];
objDR[conSqlView.UpdDate] = objInFor[conSqlView.UpdDate];
objDR[conSqlView.UpdUserId] = objInFor[conSqlView.UpdUserId];
objDR[conSqlView.Memo] = objInFor[conSqlView.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// Sql视图(SqlView)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4SqlView : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
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
clsSqlViewWApi.ReFreshThisCache(strPrjId);
}
}

}