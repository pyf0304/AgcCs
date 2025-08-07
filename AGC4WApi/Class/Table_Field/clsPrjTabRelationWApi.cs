
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabRelationWApi
 表名:PrjTabRelation(00050606)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:22
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsPrjTabRelationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjRelationId">关系Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetPrjRelationId(this clsPrjTabRelationEN objPrjTabRelationEN, string strPrjRelationId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjRelationId, 8, conPrjTabRelation.PrjRelationId);
objPrjTabRelationEN.PrjRelationId = strPrjRelationId; //关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.PrjRelationId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.PrjRelationId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.PrjRelationId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelationName">关系名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetRelationName(this clsPrjTabRelationEN objPrjTabRelationEN, string strRelationName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRelationName, conPrjTabRelation.RelationName);
clsCheckSql.CheckFieldLen(strRelationName, 40, conPrjTabRelation.RelationName);
objPrjTabRelationEN.RelationName = strRelationName; //关系名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.RelationName) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.RelationName, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.RelationName] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetTabId(this clsPrjTabRelationEN objPrjTabRelationEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conPrjTabRelation.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, conPrjTabRelation.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conPrjTabRelation.TabId);
objPrjTabRelationEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.TabId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.TabId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.TabId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjTabRelaTypeId">表关系类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetPrjTabRelaTypeId(this clsPrjTabRelationEN objPrjTabRelationEN, string strPrjTabRelaTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjTabRelaTypeId, conPrjTabRelation.PrjTabRelaTypeId);
clsCheckSql.CheckFieldLen(strPrjTabRelaTypeId, 2, conPrjTabRelation.PrjTabRelaTypeId);
clsCheckSql.CheckFieldForeignKey(strPrjTabRelaTypeId, 2, conPrjTabRelation.PrjTabRelaTypeId);
objPrjTabRelationEN.PrjTabRelaTypeId = strPrjTabRelaTypeId; //表关系类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.PrjTabRelaTypeId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.PrjTabRelaTypeId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.PrjTabRelaTypeId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnPathId">DN路径Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetDnPathId(this clsPrjTabRelationEN objPrjTabRelationEN, string strDnPathId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnPathId, 8, conPrjTabRelation.DnPathId);
clsCheckSql.CheckFieldForeignKey(strDnPathId, 8, conPrjTabRelation.DnPathId);
objPrjTabRelationEN.DnPathId = strDnPathId; //DN路径Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.DnPathId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.DnPathId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.DnPathId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strRelationTabId">相关表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetRelationTabId(this clsPrjTabRelationEN objPrjTabRelationEN, string strRelationTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRelationTabId, conPrjTabRelation.RelationTabId);
clsCheckSql.CheckFieldLen(strRelationTabId, 8, conPrjTabRelation.RelationTabId);
clsCheckSql.CheckFieldForeignKey(strRelationTabId, 8, conPrjTabRelation.RelationTabId);
objPrjTabRelationEN.RelationTabId = strRelationTabId; //相关表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.RelationTabId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.RelationTabId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.RelationTabId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId4TabId">当前表的关系字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetFldId4TabId(this clsPrjTabRelationEN objPrjTabRelationEN, string strFldId4TabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId4TabId, conPrjTabRelation.FldId4TabId);
clsCheckSql.CheckFieldLen(strFldId4TabId, 8, conPrjTabRelation.FldId4TabId);
clsCheckSql.CheckFieldForeignKey(strFldId4TabId, 8, conPrjTabRelation.FldId4TabId);
objPrjTabRelationEN.FldId4TabId = strFldId4TabId; //当前表的关系字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.FldId4TabId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.FldId4TabId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.FldId4TabId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId4RelaTabId">关系表的关系字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetFldId4RelaTabId(this clsPrjTabRelationEN objPrjTabRelationEN, string strFldId4RelaTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId4RelaTabId, conPrjTabRelation.FldId4RelaTabId);
clsCheckSql.CheckFieldLen(strFldId4RelaTabId, 8, conPrjTabRelation.FldId4RelaTabId);
clsCheckSql.CheckFieldForeignKey(strFldId4RelaTabId, 8, conPrjTabRelation.FldId4RelaTabId);
objPrjTabRelationEN.FldId4RelaTabId = strFldId4RelaTabId; //关系表的关系字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.FldId4RelaTabId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.FldId4RelaTabId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.FldId4RelaTabId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strForeignKeyTabId">外键表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetForeignKeyTabId(this clsPrjTabRelationEN objPrjTabRelationEN, string strForeignKeyTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strForeignKeyTabId, 8, conPrjTabRelation.ForeignKeyTabId);
clsCheckSql.CheckFieldForeignKey(strForeignKeyTabId, 8, conPrjTabRelation.ForeignKeyTabId);
objPrjTabRelationEN.ForeignKeyTabId = strForeignKeyTabId; //外键表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.ForeignKeyTabId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.ForeignKeyTabId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.ForeignKeyTabId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strForeignKeyFldId">外键字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetForeignKeyFldId(this clsPrjTabRelationEN objPrjTabRelationEN, string strForeignKeyFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strForeignKeyFldId, 8, conPrjTabRelation.ForeignKeyFldId);
clsCheckSql.CheckFieldForeignKey(strForeignKeyFldId, 8, conPrjTabRelation.ForeignKeyFldId);
objPrjTabRelationEN.ForeignKeyFldId = strForeignKeyFldId; //外键字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.ForeignKeyFldId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.ForeignKeyFldId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.ForeignKeyFldId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsCheckCurrData">是否检查当前数据</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetIsCheckCurrData(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsCheckCurrData, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCheckCurrData, conPrjTabRelation.IsCheckCurrData);
objPrjTabRelationEN.IsCheckCurrData = bolIsCheckCurrData; //是否检查当前数据
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.IsCheckCurrData) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.IsCheckCurrData, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.IsCheckCurrData] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsCopyForceRela">IsCopyForceRela</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetIsCopyForceRela(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsCopyForceRela, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsCopyForceRela, conPrjTabRelation.IsCopyForceRela);
objPrjTabRelationEN.IsCopyForceRela = bolIsCopyForceRela; //IsCopyForceRela
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.IsCopyForceRela) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.IsCopyForceRela, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.IsCopyForceRela] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsUpdRelateFld">是否修改关系字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetIsUpdRelateFld(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsUpdRelateFld, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsUpdRelateFld, conPrjTabRelation.IsUpdRelateFld);
objPrjTabRelationEN.IsUpdRelateFld = bolIsUpdRelateFld; //是否修改关系字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.IsUpdRelateFld) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.IsUpdRelateFld, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.IsUpdRelateFld] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsUpdMainTabDate">是否修改主表日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetIsUpdMainTabDate(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsUpdMainTabDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsUpdMainTabDate, conPrjTabRelation.IsUpdMainTabDate);
objPrjTabRelationEN.IsUpdMainTabDate = bolIsUpdMainTabDate; //是否修改主表日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.IsUpdMainTabDate) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.IsUpdMainTabDate, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.IsUpdMainTabDate] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsRefreshMainTabCache">是否刷新主表缓存</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetIsRefreshMainTabCache(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsRefreshMainTabCache, string strComparisonOp="")
	{
objPrjTabRelationEN.IsRefreshMainTabCache = bolIsRefreshMainTabCache; //是否刷新主表缓存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.IsRefreshMainTabCache) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.IsRefreshMainTabCache, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.IsRefreshMainTabCache] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDelRelateRec">是否删除相关记录</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetIsDelRelateRec(this clsPrjTabRelationEN objPrjTabRelationEN, bool bolIsDelRelateRec, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDelRelateRec, conPrjTabRelation.IsDelRelateRec);
objPrjTabRelationEN.IsDelRelateRec = bolIsDelRelateRec; //是否删除相关记录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.IsDelRelateRec) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.IsDelRelateRec, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.IsDelRelateRec] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetPrjId(this clsPrjTabRelationEN objPrjTabRelationEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, conPrjTabRelation.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conPrjTabRelation.PrjId);
objPrjTabRelationEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.PrjId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.PrjId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.PrjId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetMemo(this clsPrjTabRelationEN objPrjTabRelationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjTabRelation.Memo);
objPrjTabRelationEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.Memo) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.Memo, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.Memo] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryKeyTabId">PrimaryKeyTabId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetPrimaryKeyTabId(this clsPrjTabRelationEN objPrjTabRelationEN, string strPrimaryKeyTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryKeyTabId, 8, conPrjTabRelation.PrimaryKeyTabId);
objPrjTabRelationEN.PrimaryKeyTabId = strPrimaryKeyTabId; //PrimaryKeyTabId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.PrimaryKeyTabId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.PrimaryKeyTabId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.PrimaryKeyTabId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryKeyFldId">PrimaryKeyFldId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabRelationEN SetPrimaryKeyFldId(this clsPrjTabRelationEN objPrjTabRelationEN, string strPrimaryKeyFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrimaryKeyFldId, 8, conPrjTabRelation.PrimaryKeyFldId);
objPrjTabRelationEN.PrimaryKeyFldId = strPrimaryKeyFldId; //PrimaryKeyFldId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabRelationEN.dicFldComparisonOp.ContainsKey(conPrjTabRelation.PrimaryKeyFldId) == false)
{
objPrjTabRelationEN.dicFldComparisonOp.Add(conPrjTabRelation.PrimaryKeyFldId, strComparisonOp);
}
else
{
objPrjTabRelationEN.dicFldComparisonOp[conPrjTabRelation.PrimaryKeyFldId] = strComparisonOp;
}
}
return objPrjTabRelationEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjTabRelationEN objPrjTabRelationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.PrjRelationId) == true)
{
string strComparisonOpPrjRelationId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.PrjRelationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.PrjRelationId, objPrjTabRelationCond.PrjRelationId, strComparisonOpPrjRelationId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.RelationName) == true)
{
string strComparisonOpRelationName = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.RelationName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.RelationName, objPrjTabRelationCond.RelationName, strComparisonOpRelationName);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.TabId) == true)
{
string strComparisonOpTabId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.TabId, objPrjTabRelationCond.TabId, strComparisonOpTabId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.PrjTabRelaTypeId) == true)
{
string strComparisonOpPrjTabRelaTypeId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.PrjTabRelaTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.PrjTabRelaTypeId, objPrjTabRelationCond.PrjTabRelaTypeId, strComparisonOpPrjTabRelaTypeId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.DnPathId) == true)
{
string strComparisonOpDnPathId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.DnPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.DnPathId, objPrjTabRelationCond.DnPathId, strComparisonOpDnPathId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.RelationTabId) == true)
{
string strComparisonOpRelationTabId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.RelationTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.RelationTabId, objPrjTabRelationCond.RelationTabId, strComparisonOpRelationTabId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.FldId4TabId) == true)
{
string strComparisonOpFldId4TabId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.FldId4TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.FldId4TabId, objPrjTabRelationCond.FldId4TabId, strComparisonOpFldId4TabId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.FldId4RelaTabId) == true)
{
string strComparisonOpFldId4RelaTabId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.FldId4RelaTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.FldId4RelaTabId, objPrjTabRelationCond.FldId4RelaTabId, strComparisonOpFldId4RelaTabId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.ForeignKeyTabId) == true)
{
string strComparisonOpForeignKeyTabId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.ForeignKeyTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.ForeignKeyTabId, objPrjTabRelationCond.ForeignKeyTabId, strComparisonOpForeignKeyTabId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.ForeignKeyFldId) == true)
{
string strComparisonOpForeignKeyFldId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.ForeignKeyFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.ForeignKeyFldId, objPrjTabRelationCond.ForeignKeyFldId, strComparisonOpForeignKeyFldId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.IsCheckCurrData) == true)
{
if (objPrjTabRelationCond.IsCheckCurrData == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabRelation.IsCheckCurrData);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabRelation.IsCheckCurrData);
}
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.IsCopyForceRela) == true)
{
if (objPrjTabRelationCond.IsCopyForceRela == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabRelation.IsCopyForceRela);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabRelation.IsCopyForceRela);
}
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.IsUpdRelateFld) == true)
{
if (objPrjTabRelationCond.IsUpdRelateFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabRelation.IsUpdRelateFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabRelation.IsUpdRelateFld);
}
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.IsUpdMainTabDate) == true)
{
if (objPrjTabRelationCond.IsUpdMainTabDate == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabRelation.IsUpdMainTabDate);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabRelation.IsUpdMainTabDate);
}
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.IsRefreshMainTabCache) == true)
{
if (objPrjTabRelationCond.IsRefreshMainTabCache == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabRelation.IsRefreshMainTabCache);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabRelation.IsRefreshMainTabCache);
}
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.IsDelRelateRec) == true)
{
if (objPrjTabRelationCond.IsDelRelateRec == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabRelation.IsDelRelateRec);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabRelation.IsDelRelateRec);
}
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.PrjId) == true)
{
string strComparisonOpPrjId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.PrjId, objPrjTabRelationCond.PrjId, strComparisonOpPrjId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.Memo) == true)
{
string strComparisonOpMemo = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.Memo, objPrjTabRelationCond.Memo, strComparisonOpMemo);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.PrimaryKeyTabId) == true)
{
string strComparisonOpPrimaryKeyTabId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.PrimaryKeyTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.PrimaryKeyTabId, objPrjTabRelationCond.PrimaryKeyTabId, strComparisonOpPrimaryKeyTabId);
}
if (objPrjTabRelationCond.IsUpdated(conPrjTabRelation.PrimaryKeyFldId) == true)
{
string strComparisonOpPrimaryKeyFldId = objPrjTabRelationCond.dicFldComparisonOp[conPrjTabRelation.PrimaryKeyFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabRelation.PrimaryKeyFldId, objPrjTabRelationCond.PrimaryKeyFldId, strComparisonOpPrimaryKeyFldId);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjTabRelationEN objPrjTabRelationEN)
{
 if (string.IsNullOrEmpty(objPrjTabRelationEN.PrjRelationId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objPrjTabRelationEN.sfUpdFldSetStr = objPrjTabRelationEN.getsfUpdFldSetStr();
clsPrjTabRelationWApi.CheckPropertyNew(objPrjTabRelationEN); 
bool bolResult = clsPrjTabRelationWApi.UpdateRecord(objPrjTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationWApi.ReFreshCache(objPrjTabRelationEN.PrjId);
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
 /// 获取唯一性条件串--PrjTabRelation(工程表关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabId_PrjTabRelaTypeId_RelationTabId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsPrjTabRelationEN objPrjTabRelationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjTabRelationEN == null) return "";
if (objPrjTabRelationEN.PrjRelationId == null || objPrjTabRelationEN.PrjRelationId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjTabRelationEN.TabId);
 sbCondition.AppendFormat(" and PrjTabRelaTypeId = '{0}'", objPrjTabRelationEN.PrjTabRelaTypeId);
 sbCondition.AppendFormat(" and RelationTabId = '{0}'", objPrjTabRelationEN.RelationTabId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PrjRelationId !=  '{0}'", objPrjTabRelationEN.PrjRelationId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjTabRelationEN.TabId);
 sbCondition.AppendFormat(" and PrjTabRelaTypeId = '{0}'", objPrjTabRelationEN.PrjTabRelaTypeId);
 sbCondition.AppendFormat(" and RelationTabId = '{0}'", objPrjTabRelationEN.RelationTabId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjTabRelationEN objPrjTabRelationEN)
{
try
{
 if (string.IsNullOrEmpty(objPrjTabRelationEN.PrjRelationId) == true || clsPrjTabRelationWApi.IsExist(objPrjTabRelationEN.PrjRelationId) == true)
 {
     objPrjTabRelationEN.PrjRelationId = clsPrjTabRelationWApi.GetMaxStrId();
 }
clsPrjTabRelationWApi.CheckPropertyNew(objPrjTabRelationEN); 
bool bolResult = clsPrjTabRelationWApi.AddNewRecord(objPrjTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationWApi.ReFreshCache(objPrjTabRelationEN.PrjId);
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
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPrjTabRelationEN objPrjTabRelationEN)
{
try
{
clsPrjTabRelationWApi.CheckPropertyNew(objPrjTabRelationEN); 
string strPrjRelationId = clsPrjTabRelationWApi.AddNewRecordWithMaxId(objPrjTabRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationWApi.ReFreshCache(objPrjTabRelationEN.PrjId);
return strPrjRelationId;
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
 /// <param name = "objPrjTabRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjTabRelationEN objPrjTabRelationEN, string strWhereCond)
{
try
{
clsPrjTabRelationWApi.CheckPropertyNew(objPrjTabRelationEN); 
bool bolResult = clsPrjTabRelationWApi.UpdateWithCondition(objPrjTabRelationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationWApi.ReFreshCache(objPrjTabRelationEN.PrjId);
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
 /// 工程表关系(PrjTabRelation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsPrjTabRelationWApi
{
private static readonly string mstrApiControllerName = "PrjTabRelationApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsPrjTabRelationWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PrjRelationId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[工程表关系]...","0");
List<clsPrjTabRelationEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="PrjRelationId";
objDDL.DataTextField="RelationName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsPrjTabRelationEN objPrjTabRelationEN)
{
if (!Object.Equals(null, objPrjTabRelationEN.PrjRelationId) && GetStrLen(objPrjTabRelationEN.PrjRelationId) > 8)
{
 throw new Exception("字段[关系Id]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabRelationEN.RelationName) && GetStrLen(objPrjTabRelationEN.RelationName) > 40)
{
 throw new Exception("字段[关系名]的长度不能超过40!");
}
if (!Object.Equals(null, objPrjTabRelationEN.TabId) && GetStrLen(objPrjTabRelationEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabRelationEN.PrjTabRelaTypeId) && GetStrLen(objPrjTabRelationEN.PrjTabRelaTypeId) > 2)
{
 throw new Exception("字段[表关系类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objPrjTabRelationEN.DnPathId) && GetStrLen(objPrjTabRelationEN.DnPathId) > 8)
{
 throw new Exception("字段[DN路径Id]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabRelationEN.RelationTabId) && GetStrLen(objPrjTabRelationEN.RelationTabId) > 8)
{
 throw new Exception("字段[相关表Id]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabRelationEN.FldId4TabId) && GetStrLen(objPrjTabRelationEN.FldId4TabId) > 8)
{
 throw new Exception("字段[当前表的关系字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabRelationEN.FldId4RelaTabId) && GetStrLen(objPrjTabRelationEN.FldId4RelaTabId) > 8)
{
 throw new Exception("字段[关系表的关系字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabRelationEN.ForeignKeyTabId) && GetStrLen(objPrjTabRelationEN.ForeignKeyTabId) > 8)
{
 throw new Exception("字段[外键表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabRelationEN.ForeignKeyFldId) && GetStrLen(objPrjTabRelationEN.ForeignKeyFldId) > 8)
{
 throw new Exception("字段[外键字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabRelationEN.PrjId) && GetStrLen(objPrjTabRelationEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objPrjTabRelationEN.Memo) && GetStrLen(objPrjTabRelationEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objPrjTabRelationEN.PrimaryKeyTabId) && GetStrLen(objPrjTabRelationEN.PrimaryKeyTabId) > 8)
{
 throw new Exception("字段[PrimaryKeyTabId]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabRelationEN.PrimaryKeyFldId) && GetStrLen(objPrjTabRelationEN.PrimaryKeyFldId) > 8)
{
 throw new Exception("字段[PrimaryKeyFldId]的长度不能超过8!");
}
 objPrjTabRelationEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjRelationId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjTabRelationEN GetObjByPrjRelationId(string strPrjRelationId)
{
if (strPrjRelationId == "") return null;
string strAction = "GetObjByPrjRelationId";
clsPrjTabRelationEN objPrjTabRelationEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPrjRelationId"] = strPrjRelationId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objPrjTabRelationEN = JsonConvert.DeserializeObject<clsPrjTabRelationEN>(strJson);
return objPrjTabRelationEN;
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
public static clsPrjTabRelationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsPrjTabRelationEN objPrjTabRelationEN;
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
objPrjTabRelationEN = JsonConvert.DeserializeObject<clsPrjTabRelationEN>(strJson);
return objPrjTabRelationEN;
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
 /// <param name = "strPrjRelationId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjTabRelationEN GetObjByPrjRelationIdCache(string strPrjRelationId,string strPrjId)
{
if (string.IsNullOrEmpty(strPrjRelationId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsPrjTabRelationEN._CurrTabName, strPrjId);
List<clsPrjTabRelationEN> arrPrjTabRelationObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabRelationEN> arrPrjTabRelationObjLst_Sel =
from objPrjTabRelationEN in arrPrjTabRelationObjLstCache
where objPrjTabRelationEN.PrjRelationId == strPrjRelationId 
select objPrjTabRelationEN;
if (arrPrjTabRelationObjLst_Sel.Count() == 0)
{
   clsPrjTabRelationEN obj = clsPrjTabRelationWApi.GetObjByPrjRelationId(strPrjRelationId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrPrjTabRelationObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjRelationId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRelationNameByPrjRelationIdCache(string strPrjRelationId,string strPrjId)
{
if (string.IsNullOrEmpty(strPrjRelationId) == true) return "";
//初始化列表缓存
List<clsPrjTabRelationEN> arrPrjTabRelationObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabRelationEN> arrPrjTabRelationObjLst_Sel1 =
from objPrjTabRelationEN in arrPrjTabRelationObjLstCache
where objPrjTabRelationEN.PrjRelationId == strPrjRelationId 
select objPrjTabRelationEN;
List <clsPrjTabRelationEN> arrPrjTabRelationObjLst_Sel = new List<clsPrjTabRelationEN>();
foreach (clsPrjTabRelationEN obj in arrPrjTabRelationObjLst_Sel1)
{
arrPrjTabRelationObjLst_Sel.Add(obj);
}
if (arrPrjTabRelationObjLst_Sel.Count > 0)
{
return arrPrjTabRelationObjLst_Sel[0].RelationName;
}
string strErrMsgForGetObjById = string.Format("在PrjTabRelation对象缓存列表中,找不到记录[PrjRelationId = {0}](函数:{1})", strPrjRelationId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPrjTabRelationBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPrjRelationId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPrjRelationIdCache(string strPrjRelationId,string strPrjId)
{
if (string.IsNullOrEmpty(strPrjRelationId) == true) return "";
//初始化列表缓存
List<clsPrjTabRelationEN> arrPrjTabRelationObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabRelationEN> arrPrjTabRelationObjLst_Sel1 =
from objPrjTabRelationEN in arrPrjTabRelationObjLstCache
where objPrjTabRelationEN.PrjRelationId == strPrjRelationId 
select objPrjTabRelationEN;
List <clsPrjTabRelationEN> arrPrjTabRelationObjLst_Sel = new List<clsPrjTabRelationEN>();
foreach (clsPrjTabRelationEN obj in arrPrjTabRelationObjLst_Sel1)
{
arrPrjTabRelationObjLst_Sel.Add(obj);
}
if (arrPrjTabRelationObjLst_Sel.Count > 0)
{
return arrPrjTabRelationObjLst_Sel[0].RelationName;
}
string strErrMsgForGetObjById = string.Format("在PrjTabRelation对象缓存列表中,找不到记录的相关名称[PrjRelationId = {0}](函数:{1})", strPrjRelationId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPrjTabRelationBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabRelationEN> GetObjLst(string strWhereCond)
{
 List<clsPrjTabRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabRelationEN>>(strJson);
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
 /// <param name = "arrPrjRelationId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabRelationEN> GetObjLstByPrjRelationIdLst(List<string> arrPrjRelationId)
{
 List<clsPrjTabRelationEN> arrObjLst; 
string strAction = "GetObjLstByPrjRelationIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPrjRelationId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabRelationEN>>(strJson);
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
 /// <param name = "arrPrjRelationId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsPrjTabRelationEN> GetObjLstByPrjRelationIdLstCache(List<string> arrPrjRelationId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsPrjTabRelationEN._CurrTabName, strPrjId);
List<clsPrjTabRelationEN> arrPrjTabRelationObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsPrjTabRelationEN> arrPrjTabRelationObjLst_Sel =
from objPrjTabRelationEN in arrPrjTabRelationObjLstCache
where arrPrjRelationId.Contains(objPrjTabRelationEN.PrjRelationId)
select objPrjTabRelationEN;
return arrPrjTabRelationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabRelationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsPrjTabRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabRelationEN>>(strJson);
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
public static List<clsPrjTabRelationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsPrjTabRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabRelationEN>>(strJson);
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
public static List<clsPrjTabRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsPrjTabRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabRelationEN>>(strJson);
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
public static List<clsPrjTabRelationEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsPrjTabRelationEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabRelationEN>>(strJson);
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
public static int DelRecord(string strPrjRelationId)
{
string strAction = "DelRecord";
try
{
 clsPrjTabRelationEN objPrjTabRelationEN = clsPrjTabRelationWApi.GetObjByPrjRelationId(strPrjRelationId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strPrjRelationId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsPrjTabRelationWApi.ReFreshCache(objPrjTabRelationEN.PrjId);
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
public static int DelPrjTabRelations(List<string> arrPrjRelationId)
{
string strAction = "DelPrjTabRelations";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPrjRelationId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsPrjTabRelationEN objPrjTabRelationEN = clsPrjTabRelationWApi.GetObjByPrjRelationId(arrPrjRelationId[0]);
clsPrjTabRelationWApi.ReFreshCache(objPrjTabRelationEN.PrjId);
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
public static int DelPrjTabRelationsByCond(string strWhereCond)
{
string strAction = "DelPrjTabRelationsByCond";
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
public static bool AddNewRecord(clsPrjTabRelationEN objPrjTabRelationEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjTabRelationEN>(objPrjTabRelationEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationWApi.ReFreshCache(objPrjTabRelationEN.PrjId);
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
public static string AddNewRecordWithMaxId(clsPrjTabRelationEN objPrjTabRelationEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjTabRelationEN>(objPrjTabRelationEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabRelationWApi.ReFreshCache(objPrjTabRelationEN.PrjId);
var strPrjRelationId = (string)jobjReturn0["returnStr"];
return strPrjRelationId;
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
public static bool UpdateRecord(clsPrjTabRelationEN objPrjTabRelationEN)
{
if (string.IsNullOrEmpty(objPrjTabRelationEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjTabRelationEN.PrjRelationId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjTabRelationEN>(objPrjTabRelationEN);
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
 /// <param name = "objPrjTabRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsPrjTabRelationEN objPrjTabRelationEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objPrjTabRelationEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjTabRelationEN.PrjRelationId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjTabRelationEN.PrjRelationId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjTabRelationEN>(objPrjTabRelationEN);
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
public static bool IsExist(string strPrjRelationId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strPrjRelationId"] = strPrjRelationId
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
 /// <param name = "objPrjTabRelationENS">源对象</param>
 /// <param name = "objPrjTabRelationENT">目标对象</param>
 public static void CopyTo(clsPrjTabRelationEN objPrjTabRelationENS, clsPrjTabRelationEN objPrjTabRelationENT)
{
try
{
objPrjTabRelationENT.PrjRelationId = objPrjTabRelationENS.PrjRelationId; //关系Id
objPrjTabRelationENT.RelationName = objPrjTabRelationENS.RelationName; //关系名
objPrjTabRelationENT.TabId = objPrjTabRelationENS.TabId; //表ID
objPrjTabRelationENT.PrjTabRelaTypeId = objPrjTabRelationENS.PrjTabRelaTypeId; //表关系类型Id
objPrjTabRelationENT.DnPathId = objPrjTabRelationENS.DnPathId; //DN路径Id
objPrjTabRelationENT.RelationTabId = objPrjTabRelationENS.RelationTabId; //相关表Id
objPrjTabRelationENT.FldId4TabId = objPrjTabRelationENS.FldId4TabId; //当前表的关系字段Id
objPrjTabRelationENT.FldId4RelaTabId = objPrjTabRelationENS.FldId4RelaTabId; //关系表的关系字段Id
objPrjTabRelationENT.ForeignKeyTabId = objPrjTabRelationENS.ForeignKeyTabId; //外键表ID
objPrjTabRelationENT.ForeignKeyFldId = objPrjTabRelationENS.ForeignKeyFldId; //外键字段Id
objPrjTabRelationENT.IsCheckCurrData = objPrjTabRelationENS.IsCheckCurrData; //是否检查当前数据
objPrjTabRelationENT.IsCopyForceRela = objPrjTabRelationENS.IsCopyForceRela; //IsCopyForceRela
objPrjTabRelationENT.IsUpdRelateFld = objPrjTabRelationENS.IsUpdRelateFld; //是否修改关系字段
objPrjTabRelationENT.IsUpdMainTabDate = objPrjTabRelationENS.IsUpdMainTabDate; //是否修改主表日期
objPrjTabRelationENT.IsRefreshMainTabCache = objPrjTabRelationENS.IsRefreshMainTabCache; //是否刷新主表缓存
objPrjTabRelationENT.IsDelRelateRec = objPrjTabRelationENS.IsDelRelateRec; //是否删除相关记录
objPrjTabRelationENT.PrjId = objPrjTabRelationENS.PrjId; //工程Id
objPrjTabRelationENT.Memo = objPrjTabRelationENS.Memo; //说明
objPrjTabRelationENT.PrimaryKeyTabId = objPrjTabRelationENS.PrimaryKeyTabId; //PrimaryKeyTabId
objPrjTabRelationENT.PrimaryKeyFldId = objPrjTabRelationENS.PrimaryKeyFldId; //PrimaryKeyFldId
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
public static DataTable ToDataTable(List<clsPrjTabRelationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsPrjTabRelationEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsPrjTabRelationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsPrjTabRelationEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsPrjTabRelationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsPrjTabRelationEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsPrjTabRelationWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsPrjTabRelationWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsPrjTabRelationEN._CurrTabName, strPrjId);
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
if (clsPrjTabRelationWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsPrjTabRelationEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsPrjTabRelationWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjTabRelationEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsPrjTabRelationWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsPrjTabRelationWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsPrjTabRelationEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsPrjTabRelationEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conPrjTabRelation.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsPrjTabRelationEN._CurrTabName, strPrjId);
List<clsPrjTabRelationEN> arrPrjTabRelationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrPrjTabRelationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjTabRelationEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsPrjTabRelationEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsPrjTabRelationWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsPrjTabRelationWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsPrjTabRelationEN._CurrTabName, strPrjId);
List<clsPrjTabRelationEN> arrPrjTabRelationObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrPrjTabRelationObjLstCache = CacheHelper.Get<List<clsPrjTabRelationEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrPrjTabRelationObjLstCache = CacheHelper.Get<List<clsPrjTabRelationEN>>(strKey);
}
return arrPrjTabRelationObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsPrjTabRelationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conPrjTabRelation.PrjRelationId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabRelation.RelationName, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabRelation.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabRelation.PrjTabRelaTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabRelation.DnPathId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabRelation.RelationTabId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabRelation.FldId4TabId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabRelation.FldId4RelaTabId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabRelation.ForeignKeyTabId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabRelation.ForeignKeyFldId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabRelation.IsCheckCurrData, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTabRelation.IsCopyForceRela, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTabRelation.IsUpdRelateFld, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTabRelation.IsUpdMainTabDate, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTabRelation.IsRefreshMainTabCache, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTabRelation.IsDelRelateRec, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTabRelation.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabRelation.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabRelation.PrimaryKeyTabId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabRelation.PrimaryKeyFldId, Type.GetType("System.String"));
foreach (clsPrjTabRelationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conPrjTabRelation.PrjRelationId] = objInFor[conPrjTabRelation.PrjRelationId];
objDR[conPrjTabRelation.RelationName] = objInFor[conPrjTabRelation.RelationName];
objDR[conPrjTabRelation.TabId] = objInFor[conPrjTabRelation.TabId];
objDR[conPrjTabRelation.PrjTabRelaTypeId] = objInFor[conPrjTabRelation.PrjTabRelaTypeId];
objDR[conPrjTabRelation.DnPathId] = objInFor[conPrjTabRelation.DnPathId];
objDR[conPrjTabRelation.RelationTabId] = objInFor[conPrjTabRelation.RelationTabId];
objDR[conPrjTabRelation.FldId4TabId] = objInFor[conPrjTabRelation.FldId4TabId];
objDR[conPrjTabRelation.FldId4RelaTabId] = objInFor[conPrjTabRelation.FldId4RelaTabId];
objDR[conPrjTabRelation.ForeignKeyTabId] = objInFor[conPrjTabRelation.ForeignKeyTabId];
objDR[conPrjTabRelation.ForeignKeyFldId] = objInFor[conPrjTabRelation.ForeignKeyFldId];
objDR[conPrjTabRelation.IsCheckCurrData] = objInFor[conPrjTabRelation.IsCheckCurrData];
objDR[conPrjTabRelation.IsCopyForceRela] = objInFor[conPrjTabRelation.IsCopyForceRela];
objDR[conPrjTabRelation.IsUpdRelateFld] = objInFor[conPrjTabRelation.IsUpdRelateFld];
objDR[conPrjTabRelation.IsUpdMainTabDate] = objInFor[conPrjTabRelation.IsUpdMainTabDate];
objDR[conPrjTabRelation.IsRefreshMainTabCache] = objInFor[conPrjTabRelation.IsRefreshMainTabCache];
objDR[conPrjTabRelation.IsDelRelateRec] = objInFor[conPrjTabRelation.IsDelRelateRec];
objDR[conPrjTabRelation.PrjId] = objInFor[conPrjTabRelation.PrjId];
objDR[conPrjTabRelation.Memo] = objInFor[conPrjTabRelation.Memo];
objDR[conPrjTabRelation.PrimaryKeyTabId] = objInFor[conPrjTabRelation.PrimaryKeyTabId];
objDR[conPrjTabRelation.PrimaryKeyFldId] = objInFor[conPrjTabRelation.PrimaryKeyFldId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 工程表关系(PrjTabRelation)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4PrjTabRelation : clsCommFun4BLV2
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
clsPrjTabRelationWApi.ReFreshThisCache(strPrjId);
}
}

}