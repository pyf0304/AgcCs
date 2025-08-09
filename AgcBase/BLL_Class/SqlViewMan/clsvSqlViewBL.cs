
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlViewBL
 表名:vSqlView(00050250)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:21
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
public static class  clsvSqlViewBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSqlViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSqlViewEN GetObj(this K_SqlViewId_vSqlView myKey)
{
clsvSqlViewEN objvSqlViewEN = clsvSqlViewBL.vSqlViewDA.GetObjBySqlViewId(myKey.Value);
return objvSqlViewEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetSqlViewId(this clsvSqlViewEN objvSqlViewEN, string strSqlViewId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewId, 8, convSqlView.SqlViewId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSqlViewId, 8, convSqlView.SqlViewId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetSqlViewName(this clsvSqlViewEN objvSqlViewEN, string strSqlViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSqlViewName, convSqlView.SqlViewName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewName, 100, convSqlView.SqlViewName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetSqlViewCNName(this clsvSqlViewEN objvSqlViewEN, string strSqlViewCNName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewCNName, 200, convSqlView.SqlViewCNName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetSqlViewText(this clsvSqlViewEN objvSqlViewEN, string strSqlViewText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewText, 8000, convSqlView.SqlViewText);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetSqlViewText4Gene(this clsvSqlViewEN objvSqlViewEN, string strSqlViewText4Gene, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSqlViewText4Gene, 8000, convSqlView.SqlViewText4Gene);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetTextResouce(this clsvSqlViewEN objvSqlViewEN, string strTextResouce, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResouce, convSqlView.TextResouce);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextResouce, 100, convSqlView.TextResouce);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetTextResourceTypeId(this clsvSqlViewEN objvSqlViewEN, string strTextResourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResourceTypeId, convSqlView.TextResourceTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextResourceTypeId, 2, convSqlView.TextResourceTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextResourceTypeId, 2, convSqlView.TextResourceTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetTextResourceTypeName(this clsvSqlViewEN objvSqlViewEN, string strTextResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextResourceTypeName, convSqlView.TextResourceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextResourceTypeName, 30, convSqlView.TextResourceTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetRelaTabId(this clsvSqlViewEN objvSqlViewEN, string strRelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRelaTabId, convSqlView.RelaTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTabId, 8, convSqlView.RelaTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaTabId, 8, convSqlView.RelaTabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetTabStateId(this clsvSqlViewEN objvSqlViewEN, string strTabStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabStateId, 2, convSqlView.TabStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabStateId, 2, convSqlView.TabStateId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetFuncModuleAgcId(this clsvSqlViewEN objvSqlViewEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convSqlView.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convSqlView.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetOrderNum4Refer(this clsvSqlViewEN objvSqlViewEN, int? intOrderNum4Refer, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetAnalysisDate(this clsvSqlViewEN objvSqlViewEN, string strAnalysisDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnalysisDate, 20, convSqlView.AnalysisDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetGeneCodeDate(this clsvSqlViewEN objvSqlViewEN, string strGeneCodeDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convSqlView.GeneCodeDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetTopPercent(this clsvSqlViewEN objvSqlViewEN, string strTopPercent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopPercent, 200, convSqlView.TopPercent);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetDistinctFlag(this clsvSqlViewEN objvSqlViewEN, string strDistinctFlag, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDistinctFlag, 100, convSqlView.DistinctFlag);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetWhereCondition(this clsvSqlViewEN objvSqlViewEN, string strWhereCondition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWhereCondition, 500, convSqlView.WhereCondition);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetGroupBy(this clsvSqlViewEN objvSqlViewEN, string strGroupBy, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupBy, 1000, convSqlView.GroupBy);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetHavingStr(this clsvSqlViewEN objvSqlViewEN, string strHavingStr, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHavingStr, 200, convSqlView.HavingStr);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetOrderBy(this clsvSqlViewEN objvSqlViewEN, string strOrderBy, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOrderBy, 100, convSqlView.OrderBy);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetErrMsg(this clsvSqlViewEN objvSqlViewEN, string strErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, convSqlView.ErrMsg);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetPrjId(this clsvSqlViewEN objvSqlViewEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convSqlView.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convSqlView.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convSqlView.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetPrjName(this clsvSqlViewEN objvSqlViewEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convSqlView.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convSqlView.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetUpdDate(this clsvSqlViewEN objvSqlViewEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSqlView.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetUpdUserId(this clsvSqlViewEN objvSqlViewEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSqlView.UpdUserId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSqlViewEN SetMemo(this clsvSqlViewEN objvSqlViewEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSqlView.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSqlViewENS">源对象</param>
 /// <param name = "objvSqlViewENT">目标对象</param>
 public static void CopyTo(this clsvSqlViewEN objvSqlViewENS, clsvSqlViewEN objvSqlViewENT)
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
 /// <param name = "objvSqlViewENS">源对象</param>
 /// <returns>目标对象=>clsvSqlViewEN:objvSqlViewENT</returns>
 public static clsvSqlViewEN CopyTo(this clsvSqlViewEN objvSqlViewENS)
{
try
{
 clsvSqlViewEN objvSqlViewENT = new clsvSqlViewEN()
{
SqlViewId = objvSqlViewENS.SqlViewId, //Sql视图Id
SqlViewName = objvSqlViewENS.SqlViewName, //数据视图名称
SqlViewCNName = objvSqlViewENS.SqlViewCNName, //Sql视图中文名
SqlViewText = objvSqlViewENS.SqlViewText, //Sql视图文本内容
SqlViewText4Gene = objvSqlViewENS.SqlViewText4Gene, //Sql视图文本4生成
TextResouce = objvSqlViewENS.TextResouce, //文本来源
TextResourceTypeId = objvSqlViewENS.TextResourceTypeId, //文本来源类型Id
TextResourceTypeName = objvSqlViewENS.TextResourceTypeName, //文本来源类型名
RelaTabId = objvSqlViewENS.RelaTabId, //相关表Id
TabStateId = objvSqlViewENS.TabStateId, //表状态ID
FuncModuleAgcId = objvSqlViewENS.FuncModuleAgcId, //功能模块Id
OrderNum4Refer = objvSqlViewENS.OrderNum4Refer, //引用序号
AnalysisDate = objvSqlViewENS.AnalysisDate, //分析日期
GeneCodeDate = objvSqlViewENS.GeneCodeDate, //生成代码日期
TopPercent = objvSqlViewENS.TopPercent, //顶百分比
DistinctFlag = objvSqlViewENS.DistinctFlag, //Distinct标志
WhereCondition = objvSqlViewENS.WhereCondition, //条件串
GroupBy = objvSqlViewENS.GroupBy, //分组
HavingStr = objvSqlViewENS.HavingStr, //分组过滤
OrderBy = objvSqlViewENS.OrderBy, //排序
ErrMsg = objvSqlViewENS.ErrMsg, //错误信息
PrjId = objvSqlViewENS.PrjId, //工程Id
PrjName = objvSqlViewENS.PrjName, //工程名称
UpdDate = objvSqlViewENS.UpdDate, //修改日期
UpdUserId = objvSqlViewENS.UpdUserId, //修改用户Id
Memo = objvSqlViewENS.Memo, //说明
};
 return objvSqlViewENT;
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
public static void CheckProperty4Condition(this clsvSqlViewEN objvSqlViewEN)
{
 clsvSqlViewBL.vSqlViewDA.CheckProperty4Condition(objvSqlViewEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSqlView
{
public virtual bool UpdRelaTabDate(string strSqlViewId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vSql视图(vSqlView)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSqlViewBL
{
public static RelatedActions_vSqlView relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSqlViewDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSqlViewDA vSqlViewDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSqlViewDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSqlViewBL()
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
if (string.IsNullOrEmpty(clsvSqlViewEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSqlViewEN._ConnectString);
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
public static DataTable GetDataTable_vSqlView(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSqlViewDA.GetDataTable_vSqlView(strWhereCond);
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
objDT = vSqlViewDA.GetDataTable(strWhereCond);
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
objDT = vSqlViewDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSqlViewDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSqlViewDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSqlViewDA.GetDataTable_Top(objTopPara);
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
objDT = vSqlViewDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSqlViewDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSqlViewDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvSqlViewEN> GetObjLstBySqlViewIdLst(List<string> arrSqlViewIdLst)
{
List<clsvSqlViewEN> arrObjLst = new List<clsvSqlViewEN>(); 
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
	clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN();
try
{
objvSqlViewEN.SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewEN.SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewEN.SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewEN.SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlViewEN.SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlViewEN.TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(); //文本来源
objvSqlViewEN.TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlViewEN.TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlViewEN.RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewEN.TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(); //表状态ID
objvSqlViewEN.FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlViewEN.OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlViewEN.AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(); //分析日期
objvSqlViewEN.GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlViewEN.TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(); //顶百分比
objvSqlViewEN.DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlViewEN.WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(); //条件串
objvSqlViewEN.GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(); //分组
objvSqlViewEN.HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(); //分组过滤
objvSqlViewEN.OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(); //排序
objvSqlViewEN.ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(); //错误信息
objvSqlViewEN.PrjId = objRow[convSqlView.PrjId].ToString().Trim(); //工程Id
objvSqlViewEN.PrjName = objRow[convSqlView.PrjName].ToString().Trim(); //工程名称
objvSqlViewEN.UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(); //修改日期
objvSqlViewEN.UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewEN.Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSqlViewIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSqlViewEN> GetObjLstBySqlViewIdLstCache(List<string> arrSqlViewIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvSqlViewEN._CurrTabName, strPrjId);
List<clsvSqlViewEN> arrvSqlViewObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlViewEN> arrvSqlViewObjLst_Sel =
arrvSqlViewObjLstCache
.Where(x => arrSqlViewIdLst.Contains(x.SqlViewId));
return arrvSqlViewObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlViewEN> GetObjLst(string strWhereCond)
{
List<clsvSqlViewEN> arrObjLst = new List<clsvSqlViewEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN();
try
{
objvSqlViewEN.SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewEN.SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewEN.SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewEN.SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlViewEN.SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlViewEN.TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(); //文本来源
objvSqlViewEN.TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlViewEN.TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlViewEN.RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewEN.TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(); //表状态ID
objvSqlViewEN.FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlViewEN.OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlViewEN.AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(); //分析日期
objvSqlViewEN.GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlViewEN.TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(); //顶百分比
objvSqlViewEN.DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlViewEN.WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(); //条件串
objvSqlViewEN.GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(); //分组
objvSqlViewEN.HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(); //分组过滤
objvSqlViewEN.OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(); //排序
objvSqlViewEN.ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(); //错误信息
objvSqlViewEN.PrjId = objRow[convSqlView.PrjId].ToString().Trim(); //工程Id
objvSqlViewEN.PrjName = objRow[convSqlView.PrjName].ToString().Trim(); //工程名称
objvSqlViewEN.UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(); //修改日期
objvSqlViewEN.UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewEN.Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewEN);
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
public static List<clsvSqlViewEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSqlViewEN> arrObjLst = new List<clsvSqlViewEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN();
try
{
objvSqlViewEN.SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewEN.SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewEN.SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewEN.SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlViewEN.SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlViewEN.TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(); //文本来源
objvSqlViewEN.TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlViewEN.TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlViewEN.RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewEN.TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(); //表状态ID
objvSqlViewEN.FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlViewEN.OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlViewEN.AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(); //分析日期
objvSqlViewEN.GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlViewEN.TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(); //顶百分比
objvSqlViewEN.DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlViewEN.WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(); //条件串
objvSqlViewEN.GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(); //分组
objvSqlViewEN.HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(); //分组过滤
objvSqlViewEN.OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(); //排序
objvSqlViewEN.ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(); //错误信息
objvSqlViewEN.PrjId = objRow[convSqlView.PrjId].ToString().Trim(); //工程Id
objvSqlViewEN.PrjName = objRow[convSqlView.PrjName].ToString().Trim(); //工程名称
objvSqlViewEN.UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(); //修改日期
objvSqlViewEN.UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewEN.Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSqlViewCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSqlViewEN> GetSubObjLstCache(clsvSqlViewEN objvSqlViewCond)
{
 string strPrjId = objvSqlViewCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvSqlViewBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvSqlViewEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlViewEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSqlView._AttributeName)
{
if (objvSqlViewCond.IsUpdated(strFldName) == false) continue;
if (objvSqlViewCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlViewCond[strFldName].ToString());
}
else
{
if (objvSqlViewCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSqlViewCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlViewCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSqlViewCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSqlViewCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSqlViewCond[strFldName]));
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
public static List<clsvSqlViewEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSqlViewEN> arrObjLst = new List<clsvSqlViewEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN();
try
{
objvSqlViewEN.SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewEN.SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewEN.SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewEN.SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlViewEN.SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlViewEN.TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(); //文本来源
objvSqlViewEN.TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlViewEN.TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlViewEN.RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewEN.TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(); //表状态ID
objvSqlViewEN.FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlViewEN.OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlViewEN.AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(); //分析日期
objvSqlViewEN.GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlViewEN.TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(); //顶百分比
objvSqlViewEN.DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlViewEN.WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(); //条件串
objvSqlViewEN.GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(); //分组
objvSqlViewEN.HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(); //分组过滤
objvSqlViewEN.OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(); //排序
objvSqlViewEN.ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(); //错误信息
objvSqlViewEN.PrjId = objRow[convSqlView.PrjId].ToString().Trim(); //工程Id
objvSqlViewEN.PrjName = objRow[convSqlView.PrjName].ToString().Trim(); //工程名称
objvSqlViewEN.UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(); //修改日期
objvSqlViewEN.UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewEN.Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewEN);
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
public static List<clsvSqlViewEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSqlViewEN> arrObjLst = new List<clsvSqlViewEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN();
try
{
objvSqlViewEN.SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewEN.SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewEN.SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewEN.SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlViewEN.SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlViewEN.TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(); //文本来源
objvSqlViewEN.TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlViewEN.TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlViewEN.RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewEN.TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(); //表状态ID
objvSqlViewEN.FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlViewEN.OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlViewEN.AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(); //分析日期
objvSqlViewEN.GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlViewEN.TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(); //顶百分比
objvSqlViewEN.DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlViewEN.WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(); //条件串
objvSqlViewEN.GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(); //分组
objvSqlViewEN.HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(); //分组过滤
objvSqlViewEN.OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(); //排序
objvSqlViewEN.ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(); //错误信息
objvSqlViewEN.PrjId = objRow[convSqlView.PrjId].ToString().Trim(); //工程Id
objvSqlViewEN.PrjName = objRow[convSqlView.PrjName].ToString().Trim(); //工程名称
objvSqlViewEN.UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(); //修改日期
objvSqlViewEN.UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewEN.Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewEN);
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
List<clsvSqlViewEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSqlViewEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlViewEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSqlViewEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSqlViewEN> arrObjLst = new List<clsvSqlViewEN>(); 
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
	clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN();
try
{
objvSqlViewEN.SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewEN.SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewEN.SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewEN.SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlViewEN.SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlViewEN.TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(); //文本来源
objvSqlViewEN.TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlViewEN.TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlViewEN.RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewEN.TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(); //表状态ID
objvSqlViewEN.FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlViewEN.OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlViewEN.AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(); //分析日期
objvSqlViewEN.GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlViewEN.TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(); //顶百分比
objvSqlViewEN.DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlViewEN.WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(); //条件串
objvSqlViewEN.GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(); //分组
objvSqlViewEN.HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(); //分组过滤
objvSqlViewEN.OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(); //排序
objvSqlViewEN.ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(); //错误信息
objvSqlViewEN.PrjId = objRow[convSqlView.PrjId].ToString().Trim(); //工程Id
objvSqlViewEN.PrjName = objRow[convSqlView.PrjName].ToString().Trim(); //工程名称
objvSqlViewEN.UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(); //修改日期
objvSqlViewEN.UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewEN.Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewEN);
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
public static List<clsvSqlViewEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSqlViewEN> arrObjLst = new List<clsvSqlViewEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN();
try
{
objvSqlViewEN.SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewEN.SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewEN.SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewEN.SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlViewEN.SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlViewEN.TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(); //文本来源
objvSqlViewEN.TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlViewEN.TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlViewEN.RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewEN.TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(); //表状态ID
objvSqlViewEN.FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlViewEN.OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlViewEN.AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(); //分析日期
objvSqlViewEN.GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlViewEN.TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(); //顶百分比
objvSqlViewEN.DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlViewEN.WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(); //条件串
objvSqlViewEN.GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(); //分组
objvSqlViewEN.HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(); //分组过滤
objvSqlViewEN.OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(); //排序
objvSqlViewEN.ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(); //错误信息
objvSqlViewEN.PrjId = objRow[convSqlView.PrjId].ToString().Trim(); //工程Id
objvSqlViewEN.PrjName = objRow[convSqlView.PrjName].ToString().Trim(); //工程名称
objvSqlViewEN.UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(); //修改日期
objvSqlViewEN.UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewEN.Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSqlViewEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSqlViewEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSqlViewEN> arrObjLst = new List<clsvSqlViewEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN();
try
{
objvSqlViewEN.SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewEN.SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewEN.SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewEN.SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlViewEN.SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlViewEN.TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(); //文本来源
objvSqlViewEN.TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlViewEN.TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlViewEN.RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewEN.TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(); //表状态ID
objvSqlViewEN.FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlViewEN.OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlViewEN.AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(); //分析日期
objvSqlViewEN.GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlViewEN.TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(); //顶百分比
objvSqlViewEN.DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlViewEN.WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(); //条件串
objvSqlViewEN.GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(); //分组
objvSqlViewEN.HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(); //分组过滤
objvSqlViewEN.OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(); //排序
objvSqlViewEN.ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(); //错误信息
objvSqlViewEN.PrjId = objRow[convSqlView.PrjId].ToString().Trim(); //工程Id
objvSqlViewEN.PrjName = objRow[convSqlView.PrjName].ToString().Trim(); //工程名称
objvSqlViewEN.UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(); //修改日期
objvSqlViewEN.UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewEN.Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewEN);
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
public static List<clsvSqlViewEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSqlViewEN> arrObjLst = new List<clsvSqlViewEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN();
try
{
objvSqlViewEN.SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewEN.SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewEN.SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewEN.SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlViewEN.SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlViewEN.TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(); //文本来源
objvSqlViewEN.TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlViewEN.TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlViewEN.RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewEN.TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(); //表状态ID
objvSqlViewEN.FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlViewEN.OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlViewEN.AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(); //分析日期
objvSqlViewEN.GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlViewEN.TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(); //顶百分比
objvSqlViewEN.DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlViewEN.WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(); //条件串
objvSqlViewEN.GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(); //分组
objvSqlViewEN.HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(); //分组过滤
objvSqlViewEN.OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(); //排序
objvSqlViewEN.ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(); //错误信息
objvSqlViewEN.PrjId = objRow[convSqlView.PrjId].ToString().Trim(); //工程Id
objvSqlViewEN.PrjName = objRow[convSqlView.PrjName].ToString().Trim(); //工程名称
objvSqlViewEN.UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(); //修改日期
objvSqlViewEN.UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewEN.Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSqlViewEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSqlViewEN> arrObjLst = new List<clsvSqlViewEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN();
try
{
objvSqlViewEN.SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewEN.SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewEN.SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewEN.SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlViewEN.SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlViewEN.TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(); //文本来源
objvSqlViewEN.TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlViewEN.TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlViewEN.RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewEN.TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(); //表状态ID
objvSqlViewEN.FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlViewEN.OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlViewEN.AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(); //分析日期
objvSqlViewEN.GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlViewEN.TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(); //顶百分比
objvSqlViewEN.DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlViewEN.WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(); //条件串
objvSqlViewEN.GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(); //分组
objvSqlViewEN.HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(); //分组过滤
objvSqlViewEN.OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(); //排序
objvSqlViewEN.ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(); //错误信息
objvSqlViewEN.PrjId = objRow[convSqlView.PrjId].ToString().Trim(); //工程Id
objvSqlViewEN.PrjName = objRow[convSqlView.PrjName].ToString().Trim(); //工程名称
objvSqlViewEN.UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(); //修改日期
objvSqlViewEN.UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewEN.Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSqlViewEN.SqlViewId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSqlViewEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSqlViewEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSqlView(ref clsvSqlViewEN objvSqlViewEN)
{
bool bolResult = vSqlViewDA.GetvSqlView(ref objvSqlViewEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSqlViewId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSqlViewEN GetObjBySqlViewId(string strSqlViewId)
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
clsvSqlViewEN objvSqlViewEN = vSqlViewDA.GetObjBySqlViewId(strSqlViewId);
return objvSqlViewEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSqlViewEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSqlViewEN objvSqlViewEN = vSqlViewDA.GetFirstObj(strWhereCond);
 return objvSqlViewEN;
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
public static clsvSqlViewEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSqlViewEN objvSqlViewEN = vSqlViewDA.GetObjByDataRow(objRow);
 return objvSqlViewEN;
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
public static clsvSqlViewEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSqlViewEN objvSqlViewEN = vSqlViewDA.GetObjByDataRow(objRow);
 return objvSqlViewEN;
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
 /// <param name = "lstvSqlViewObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSqlViewEN GetObjBySqlViewIdFromList(string strSqlViewId, List<clsvSqlViewEN> lstvSqlViewObjLst)
{
foreach (clsvSqlViewEN objvSqlViewEN in lstvSqlViewObjLst)
{
if (objvSqlViewEN.SqlViewId == strSqlViewId)
{
return objvSqlViewEN;
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
 strSqlViewId = new clsvSqlViewDA().GetFirstID(strWhereCond);
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
 arrList = vSqlViewDA.GetID(strWhereCond);
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
bool bolIsExist = vSqlViewDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vSqlViewDA.IsExist(strSqlViewId);
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
 bolIsExist = clsvSqlViewDA.IsExistTable();
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
 bolIsExist = vSqlViewDA.IsExistTable(strTabName);
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
 /// <param name = "objvSqlViewEN">源简化对象</param>
 public static void SetUpdFlag(clsvSqlViewEN objvSqlViewEN)
{
try
{
objvSqlViewEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSqlViewEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSqlView.SqlViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.SqlViewId = objvSqlViewEN.SqlViewId; //Sql视图Id
}
if (arrFldSet.Contains(convSqlView.SqlViewName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.SqlViewName = objvSqlViewEN.SqlViewName; //数据视图名称
}
if (arrFldSet.Contains(convSqlView.SqlViewCNName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.SqlViewCNName = objvSqlViewEN.SqlViewCNName == "[null]" ? null :  objvSqlViewEN.SqlViewCNName; //Sql视图中文名
}
if (arrFldSet.Contains(convSqlView.SqlViewText, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.SqlViewText = objvSqlViewEN.SqlViewText == "[null]" ? null :  objvSqlViewEN.SqlViewText; //Sql视图文本内容
}
if (arrFldSet.Contains(convSqlView.SqlViewText4Gene, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.SqlViewText4Gene = objvSqlViewEN.SqlViewText4Gene == "[null]" ? null :  objvSqlViewEN.SqlViewText4Gene; //Sql视图文本4生成
}
if (arrFldSet.Contains(convSqlView.TextResouce, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.TextResouce = objvSqlViewEN.TextResouce; //文本来源
}
if (arrFldSet.Contains(convSqlView.TextResourceTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.TextResourceTypeId = objvSqlViewEN.TextResourceTypeId; //文本来源类型Id
}
if (arrFldSet.Contains(convSqlView.TextResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.TextResourceTypeName = objvSqlViewEN.TextResourceTypeName; //文本来源类型名
}
if (arrFldSet.Contains(convSqlView.RelaTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.RelaTabId = objvSqlViewEN.RelaTabId; //相关表Id
}
if (arrFldSet.Contains(convSqlView.TabStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.TabStateId = objvSqlViewEN.TabStateId == "[null]" ? null :  objvSqlViewEN.TabStateId; //表状态ID
}
if (arrFldSet.Contains(convSqlView.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.FuncModuleAgcId = objvSqlViewEN.FuncModuleAgcId == "[null]" ? null :  objvSqlViewEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convSqlView.OrderNum4Refer, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.OrderNum4Refer = objvSqlViewEN.OrderNum4Refer; //引用序号
}
if (arrFldSet.Contains(convSqlView.AnalysisDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.AnalysisDate = objvSqlViewEN.AnalysisDate == "[null]" ? null :  objvSqlViewEN.AnalysisDate; //分析日期
}
if (arrFldSet.Contains(convSqlView.GeneCodeDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.GeneCodeDate = objvSqlViewEN.GeneCodeDate == "[null]" ? null :  objvSqlViewEN.GeneCodeDate; //生成代码日期
}
if (arrFldSet.Contains(convSqlView.TopPercent, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.TopPercent = objvSqlViewEN.TopPercent == "[null]" ? null :  objvSqlViewEN.TopPercent; //顶百分比
}
if (arrFldSet.Contains(convSqlView.DistinctFlag, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.DistinctFlag = objvSqlViewEN.DistinctFlag == "[null]" ? null :  objvSqlViewEN.DistinctFlag; //Distinct标志
}
if (arrFldSet.Contains(convSqlView.WhereCondition, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.WhereCondition = objvSqlViewEN.WhereCondition == "[null]" ? null :  objvSqlViewEN.WhereCondition; //条件串
}
if (arrFldSet.Contains(convSqlView.GroupBy, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.GroupBy = objvSqlViewEN.GroupBy == "[null]" ? null :  objvSqlViewEN.GroupBy; //分组
}
if (arrFldSet.Contains(convSqlView.HavingStr, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.HavingStr = objvSqlViewEN.HavingStr == "[null]" ? null :  objvSqlViewEN.HavingStr; //分组过滤
}
if (arrFldSet.Contains(convSqlView.OrderBy, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.OrderBy = objvSqlViewEN.OrderBy == "[null]" ? null :  objvSqlViewEN.OrderBy; //排序
}
if (arrFldSet.Contains(convSqlView.ErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.ErrMsg = objvSqlViewEN.ErrMsg == "[null]" ? null :  objvSqlViewEN.ErrMsg; //错误信息
}
if (arrFldSet.Contains(convSqlView.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.PrjId = objvSqlViewEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convSqlView.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.PrjName = objvSqlViewEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convSqlView.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.UpdDate = objvSqlViewEN.UpdDate == "[null]" ? null :  objvSqlViewEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSqlView.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.UpdUserId = objvSqlViewEN.UpdUserId == "[null]" ? null :  objvSqlViewEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convSqlView.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSqlViewEN.Memo = objvSqlViewEN.Memo == "[null]" ? null :  objvSqlViewEN.Memo; //说明
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
 /// <param name = "objvSqlViewEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSqlViewEN objvSqlViewEN)
{
try
{
if (objvSqlViewEN.SqlViewCNName == "[null]") objvSqlViewEN.SqlViewCNName = null; //Sql视图中文名
if (objvSqlViewEN.SqlViewText == "[null]") objvSqlViewEN.SqlViewText = null; //Sql视图文本内容
if (objvSqlViewEN.SqlViewText4Gene == "[null]") objvSqlViewEN.SqlViewText4Gene = null; //Sql视图文本4生成
if (objvSqlViewEN.TabStateId == "[null]") objvSqlViewEN.TabStateId = null; //表状态ID
if (objvSqlViewEN.FuncModuleAgcId == "[null]") objvSqlViewEN.FuncModuleAgcId = null; //功能模块Id
if (objvSqlViewEN.AnalysisDate == "[null]") objvSqlViewEN.AnalysisDate = null; //分析日期
if (objvSqlViewEN.GeneCodeDate == "[null]") objvSqlViewEN.GeneCodeDate = null; //生成代码日期
if (objvSqlViewEN.TopPercent == "[null]") objvSqlViewEN.TopPercent = null; //顶百分比
if (objvSqlViewEN.DistinctFlag == "[null]") objvSqlViewEN.DistinctFlag = null; //Distinct标志
if (objvSqlViewEN.WhereCondition == "[null]") objvSqlViewEN.WhereCondition = null; //条件串
if (objvSqlViewEN.GroupBy == "[null]") objvSqlViewEN.GroupBy = null; //分组
if (objvSqlViewEN.HavingStr == "[null]") objvSqlViewEN.HavingStr = null; //分组过滤
if (objvSqlViewEN.OrderBy == "[null]") objvSqlViewEN.OrderBy = null; //排序
if (objvSqlViewEN.ErrMsg == "[null]") objvSqlViewEN.ErrMsg = null; //错误信息
if (objvSqlViewEN.UpdDate == "[null]") objvSqlViewEN.UpdDate = null; //修改日期
if (objvSqlViewEN.UpdUserId == "[null]") objvSqlViewEN.UpdUserId = null; //修改用户Id
if (objvSqlViewEN.Memo == "[null]") objvSqlViewEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvSqlViewEN objvSqlViewEN)
{
 vSqlViewDA.CheckProperty4Condition(objvSqlViewEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_SqlViewId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convSqlView.SqlViewId); 
List<clsvSqlViewEN> arrObjLst = clsvSqlViewBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindDdl_SqlViewId(System.Web.UI.WebControls.DropDownList objDDL , string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vSql视图]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convSqlView.SqlViewId); 
IEnumerable<clsvSqlViewEN> arrObjLst = clsvSqlViewBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
objDDL.DataValueField = convSqlView.SqlViewId;
objDDL.DataTextField = convSqlView.SqlViewName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_SqlViewIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vSql视图]...","0");
List<clsvSqlViewEN> arrvSqlViewObjLst = GetAllvSqlViewObjLstCache(strPrjId); 
objDDL.DataValueField = convSqlView.SqlViewId;
objDDL.DataTextField = convSqlView.SqlViewName;
objDDL.DataSource = arrvSqlViewObjLst;
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
//if (arrvSqlViewObjLstCache == null)
//{
//arrvSqlViewObjLstCache = vSqlViewDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSqlViewId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSqlViewEN GetObjBySqlViewIdCache(string strSqlViewId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvSqlViewEN._CurrTabName, strPrjId);
List<clsvSqlViewEN> arrvSqlViewObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlViewEN> arrvSqlViewObjLst_Sel =
arrvSqlViewObjLstCache
.Where(x=> x.SqlViewId == strSqlViewId 
);
if (arrvSqlViewObjLst_Sel.Count() == 0)
{
   clsvSqlViewEN obj = clsvSqlViewBL.GetObjBySqlViewId(strSqlViewId);
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
return arrvSqlViewObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSqlViewId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSqlViewNameBySqlViewIdCache(string strSqlViewId, string strPrjId)
{
if (string.IsNullOrEmpty(strSqlViewId) == true) return "";
//获取缓存中的对象列表
clsvSqlViewEN objvSqlView = GetObjBySqlViewIdCache(strSqlViewId, strPrjId);
if (objvSqlView == null) return "";
return objvSqlView.SqlViewName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSqlViewId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBySqlViewIdCache(string strSqlViewId, string strPrjId)
{
if (string.IsNullOrEmpty(strSqlViewId) == true) return "";
//获取缓存中的对象列表
clsvSqlViewEN objvSqlView = GetObjBySqlViewIdCache(strSqlViewId, strPrjId);
if (objvSqlView == null) return "";
return objvSqlView.SqlViewName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSqlViewEN> GetAllvSqlViewObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvSqlViewEN> arrvSqlViewObjLstCache = GetObjLstCache(strPrjId); 
return arrvSqlViewObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSqlViewEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvSqlViewEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvSqlViewEN> arrvSqlViewObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvSqlViewObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvSqlViewEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvSqlViewEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvSqlViewEN._RefreshTimeLst.Count == 0) return "";
return clsvSqlViewEN._RefreshTimeLst[clsvSqlViewEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convSqlView.SqlViewId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSqlView._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSqlView._AttributeName));
throw new Exception(strMsg);
}
var objvSqlView = clsvSqlViewBL.GetObjBySqlViewIdCache(strSqlViewId, strPrjId);
if (objvSqlView == null) return "";
return objvSqlView[strOutFldName].ToString();
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
int intRecCount = clsvSqlViewDA.GetRecCount(strTabName);
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
int intRecCount = clsvSqlViewDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSqlViewDA.GetRecCount();
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
int intRecCount = clsvSqlViewDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSqlViewCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSqlViewEN objvSqlViewCond)
{
 string strPrjId = objvSqlViewCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvSqlViewBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvSqlViewEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvSqlViewEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSqlView._AttributeName)
{
if (objvSqlViewCond.IsUpdated(strFldName) == false) continue;
if (objvSqlViewCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlViewCond[strFldName].ToString());
}
else
{
if (objvSqlViewCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSqlViewCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSqlViewCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSqlViewCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSqlViewCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSqlViewCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSqlViewCond[strFldName]));
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
 List<string> arrList = clsvSqlViewDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSqlViewDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSqlViewDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}