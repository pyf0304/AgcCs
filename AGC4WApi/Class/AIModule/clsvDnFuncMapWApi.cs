
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnFuncMapWApi
 表名:vDnFuncMap(00050554)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:08:19
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
public static class  clsvDnFuncMapWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnFuncMapId">函数映射Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetDnFuncMapId(this clsvDnFuncMapEN objvDnFuncMapEN, string strDnFuncMapId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnFuncMapId, 8, convDnFuncMap.DnFuncMapId);
clsCheckSql.CheckFieldForeignKey(strDnFuncMapId, 8, convDnFuncMap.DnFuncMapId);
objvDnFuncMapEN.DnFuncMapId = strDnFuncMapId; //函数映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMapEN.dicFldComparisonOp.ContainsKey(convDnFuncMap.DnFuncMapId) == false)
{
objvDnFuncMapEN.dicFldComparisonOp.Add(convDnFuncMap.DnFuncMapId, strComparisonOp);
}
else
{
objvDnFuncMapEN.dicFldComparisonOp[convDnFuncMap.DnFuncMapId] = strComparisonOp;
}
}
return objvDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "lngInDataNodeId">In数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetInDataNodeId(this clsvDnFuncMapEN objvDnFuncMapEN, long lngInDataNodeId, string strComparisonOp="")
	{
objvDnFuncMapEN.InDataNodeId = lngInDataNodeId; //In数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMapEN.dicFldComparisonOp.ContainsKey(convDnFuncMap.InDataNodeId) == false)
{
objvDnFuncMapEN.dicFldComparisonOp.Add(convDnFuncMap.InDataNodeId, strComparisonOp);
}
else
{
objvDnFuncMapEN.dicFldComparisonOp[convDnFuncMap.InDataNodeId] = strComparisonOp;
}
}
return objvDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "lngOutDataNodeId">Out数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetOutDataNodeId(this clsvDnFuncMapEN objvDnFuncMapEN, long lngOutDataNodeId, string strComparisonOp="")
	{
objvDnFuncMapEN.OutDataNodeId = lngOutDataNodeId; //Out数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMapEN.dicFldComparisonOp.ContainsKey(convDnFuncMap.OutDataNodeId) == false)
{
objvDnFuncMapEN.dicFldComparisonOp.Add(convDnFuncMap.OutDataNodeId, strComparisonOp);
}
else
{
objvDnFuncMapEN.dicFldComparisonOp[convDnFuncMap.OutDataNodeId] = strComparisonOp;
}
}
return objvDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strAssociationMappingId">关联关系映射Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetAssociationMappingId(this clsvDnFuncMapEN objvDnFuncMapEN, string strAssociationMappingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAssociationMappingId, 2, convDnFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldForeignKey(strAssociationMappingId, 2, convDnFuncMap.AssociationMappingId);
objvDnFuncMapEN.AssociationMappingId = strAssociationMappingId; //关联关系映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMapEN.dicFldComparisonOp.ContainsKey(convDnFuncMap.AssociationMappingId) == false)
{
objvDnFuncMapEN.dicFldComparisonOp.Add(convDnFuncMap.AssociationMappingId, strComparisonOp);
}
else
{
objvDnFuncMapEN.dicFldComparisonOp[convDnFuncMap.AssociationMappingId] = strComparisonOp;
}
}
return objvDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strAssociationMappingName">关联关系映射名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetAssociationMappingName(this clsvDnFuncMapEN objvDnFuncMapEN, string strAssociationMappingName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAssociationMappingName, 50, convDnFuncMap.AssociationMappingName);
objvDnFuncMapEN.AssociationMappingName = strAssociationMappingName; //关联关系映射名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMapEN.dicFldComparisonOp.ContainsKey(convDnFuncMap.AssociationMappingName) == false)
{
objvDnFuncMapEN.dicFldComparisonOp.Add(convDnFuncMap.AssociationMappingName, strComparisonOp);
}
else
{
objvDnFuncMapEN.dicFldComparisonOp[convDnFuncMap.AssociationMappingName] = strComparisonOp;
}
}
return objvDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncMapModeId">函数映射模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetFuncMapModeId(this clsvDnFuncMapEN objvDnFuncMapEN, string strFuncMapModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncMapModeId, 2, convDnFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldForeignKey(strFuncMapModeId, 2, convDnFuncMap.FuncMapModeId);
objvDnFuncMapEN.FuncMapModeId = strFuncMapModeId; //函数映射模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMapEN.dicFldComparisonOp.ContainsKey(convDnFuncMap.FuncMapModeId) == false)
{
objvDnFuncMapEN.dicFldComparisonOp.Add(convDnFuncMap.FuncMapModeId, strComparisonOp);
}
else
{
objvDnFuncMapEN.dicFldComparisonOp[convDnFuncMap.FuncMapModeId] = strComparisonOp;
}
}
return objvDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncMapModeName">函数映射模式名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetFuncMapModeName(this clsvDnFuncMapEN objvDnFuncMapEN, string strFuncMapModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncMapModeName, 50, convDnFuncMap.FuncMapModeName);
objvDnFuncMapEN.FuncMapModeName = strFuncMapModeName; //函数映射模式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMapEN.dicFldComparisonOp.ContainsKey(convDnFuncMap.FuncMapModeName) == false)
{
objvDnFuncMapEN.dicFldComparisonOp.Add(convDnFuncMap.FuncMapModeName, strComparisonOp);
}
else
{
objvDnFuncMapEN.dicFldComparisonOp[convDnFuncMap.FuncMapModeName] = strComparisonOp;
}
}
return objvDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetTabId(this clsvDnFuncMapEN objvDnFuncMapEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convDnFuncMap.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convDnFuncMap.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convDnFuncMap.TabId);
objvDnFuncMapEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMapEN.dicFldComparisonOp.ContainsKey(convDnFuncMap.TabId) == false)
{
objvDnFuncMapEN.dicFldComparisonOp.Add(convDnFuncMap.TabId, strComparisonOp);
}
else
{
objvDnFuncMapEN.dicFldComparisonOp[convDnFuncMap.TabId] = strComparisonOp;
}
}
return objvDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnFunctionId">DN函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetDnFunctionId(this clsvDnFuncMapEN objvDnFuncMapEN, string strDnFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnFunctionId, 8, convDnFuncMap.DnFunctionId);
clsCheckSql.CheckFieldForeignKey(strDnFunctionId, 8, convDnFuncMap.DnFunctionId);
objvDnFuncMapEN.DnFunctionId = strDnFunctionId; //DN函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMapEN.dicFldComparisonOp.ContainsKey(convDnFuncMap.DnFunctionId) == false)
{
objvDnFuncMapEN.dicFldComparisonOp.Add(convDnFuncMap.DnFunctionId, strComparisonOp);
}
else
{
objvDnFuncMapEN.dicFldComparisonOp[convDnFuncMap.DnFunctionId] = strComparisonOp;
}
}
return objvDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetPrjId(this clsvDnFuncMapEN objvDnFuncMapEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convDnFuncMap.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convDnFuncMap.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDnFuncMap.PrjId);
objvDnFuncMapEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMapEN.dicFldComparisonOp.ContainsKey(convDnFuncMap.PrjId) == false)
{
objvDnFuncMapEN.dicFldComparisonOp.Add(convDnFuncMap.PrjId, strComparisonOp);
}
else
{
objvDnFuncMapEN.dicFldComparisonOp[convDnFuncMap.PrjId] = strComparisonOp;
}
}
return objvDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetUpdDate(this clsvDnFuncMapEN objvDnFuncMapEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDnFuncMap.UpdDate);
objvDnFuncMapEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMapEN.dicFldComparisonOp.ContainsKey(convDnFuncMap.UpdDate) == false)
{
objvDnFuncMapEN.dicFldComparisonOp.Add(convDnFuncMap.UpdDate, strComparisonOp);
}
else
{
objvDnFuncMapEN.dicFldComparisonOp[convDnFuncMap.UpdDate] = strComparisonOp;
}
}
return objvDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetUpdUser(this clsvDnFuncMapEN objvDnFuncMapEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convDnFuncMap.UpdUser);
objvDnFuncMapEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMapEN.dicFldComparisonOp.ContainsKey(convDnFuncMap.UpdUser) == false)
{
objvDnFuncMapEN.dicFldComparisonOp.Add(convDnFuncMap.UpdUser, strComparisonOp);
}
else
{
objvDnFuncMapEN.dicFldComparisonOp[convDnFuncMap.UpdUser] = strComparisonOp;
}
}
return objvDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetMemo(this clsvDnFuncMapEN objvDnFuncMapEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDnFuncMap.Memo);
objvDnFuncMapEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMapEN.dicFldComparisonOp.ContainsKey(convDnFuncMap.Memo) == false)
{
objvDnFuncMapEN.dicFldComparisonOp.Add(convDnFuncMap.Memo, strComparisonOp);
}
else
{
objvDnFuncMapEN.dicFldComparisonOp[convDnFuncMap.Memo] = strComparisonOp;
}
}
return objvDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strInDataNodeName">In数据结点名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetInDataNodeName(this clsvDnFuncMapEN objvDnFuncMapEN, string strInDataNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInDataNodeName, 100, convDnFuncMap.InDataNodeName);
objvDnFuncMapEN.InDataNodeName = strInDataNodeName; //In数据结点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMapEN.dicFldComparisonOp.ContainsKey(convDnFuncMap.InDataNodeName) == false)
{
objvDnFuncMapEN.dicFldComparisonOp.Add(convDnFuncMap.InDataNodeName, strComparisonOp);
}
else
{
objvDnFuncMapEN.dicFldComparisonOp[convDnFuncMap.InDataNodeName] = strComparisonOp;
}
}
return objvDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutDataNodeName">Out数据结点名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetOutDataNodeName(this clsvDnFuncMapEN objvDnFuncMapEN, string strOutDataNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutDataNodeName, 100, convDnFuncMap.OutDataNodeName);
objvDnFuncMapEN.OutDataNodeName = strOutDataNodeName; //Out数据结点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMapEN.dicFldComparisonOp.ContainsKey(convDnFuncMap.OutDataNodeName) == false)
{
objvDnFuncMapEN.dicFldComparisonOp.Add(convDnFuncMap.OutDataNodeName, strComparisonOp);
}
else
{
objvDnFuncMapEN.dicFldComparisonOp[convDnFuncMap.OutDataNodeName] = strComparisonOp;
}
}
return objvDnFuncMapEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDnFuncMapEN objvDnFuncMapCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDnFuncMapCond.IsUpdated(convDnFuncMap.DnFuncMapId) == true)
{
string strComparisonOpDnFuncMapId = objvDnFuncMapCond.dicFldComparisonOp[convDnFuncMap.DnFuncMapId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap.DnFuncMapId, objvDnFuncMapCond.DnFuncMapId, strComparisonOpDnFuncMapId);
}
if (objvDnFuncMapCond.IsUpdated(convDnFuncMap.InDataNodeId) == true)
{
string strComparisonOpInDataNodeId = objvDnFuncMapCond.dicFldComparisonOp[convDnFuncMap.InDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", convDnFuncMap.InDataNodeId, objvDnFuncMapCond.InDataNodeId, strComparisonOpInDataNodeId);
}
if (objvDnFuncMapCond.IsUpdated(convDnFuncMap.OutDataNodeId) == true)
{
string strComparisonOpOutDataNodeId = objvDnFuncMapCond.dicFldComparisonOp[convDnFuncMap.OutDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", convDnFuncMap.OutDataNodeId, objvDnFuncMapCond.OutDataNodeId, strComparisonOpOutDataNodeId);
}
if (objvDnFuncMapCond.IsUpdated(convDnFuncMap.AssociationMappingId) == true)
{
string strComparisonOpAssociationMappingId = objvDnFuncMapCond.dicFldComparisonOp[convDnFuncMap.AssociationMappingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap.AssociationMappingId, objvDnFuncMapCond.AssociationMappingId, strComparisonOpAssociationMappingId);
}
if (objvDnFuncMapCond.IsUpdated(convDnFuncMap.AssociationMappingName) == true)
{
string strComparisonOpAssociationMappingName = objvDnFuncMapCond.dicFldComparisonOp[convDnFuncMap.AssociationMappingName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap.AssociationMappingName, objvDnFuncMapCond.AssociationMappingName, strComparisonOpAssociationMappingName);
}
if (objvDnFuncMapCond.IsUpdated(convDnFuncMap.FuncMapModeId) == true)
{
string strComparisonOpFuncMapModeId = objvDnFuncMapCond.dicFldComparisonOp[convDnFuncMap.FuncMapModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap.FuncMapModeId, objvDnFuncMapCond.FuncMapModeId, strComparisonOpFuncMapModeId);
}
if (objvDnFuncMapCond.IsUpdated(convDnFuncMap.FuncMapModeName) == true)
{
string strComparisonOpFuncMapModeName = objvDnFuncMapCond.dicFldComparisonOp[convDnFuncMap.FuncMapModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap.FuncMapModeName, objvDnFuncMapCond.FuncMapModeName, strComparisonOpFuncMapModeName);
}
if (objvDnFuncMapCond.IsUpdated(convDnFuncMap.TabId) == true)
{
string strComparisonOpTabId = objvDnFuncMapCond.dicFldComparisonOp[convDnFuncMap.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap.TabId, objvDnFuncMapCond.TabId, strComparisonOpTabId);
}
if (objvDnFuncMapCond.IsUpdated(convDnFuncMap.DnFunctionId) == true)
{
string strComparisonOpDnFunctionId = objvDnFuncMapCond.dicFldComparisonOp[convDnFuncMap.DnFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap.DnFunctionId, objvDnFuncMapCond.DnFunctionId, strComparisonOpDnFunctionId);
}
if (objvDnFuncMapCond.IsUpdated(convDnFuncMap.PrjId) == true)
{
string strComparisonOpPrjId = objvDnFuncMapCond.dicFldComparisonOp[convDnFuncMap.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap.PrjId, objvDnFuncMapCond.PrjId, strComparisonOpPrjId);
}
if (objvDnFuncMapCond.IsUpdated(convDnFuncMap.UpdDate) == true)
{
string strComparisonOpUpdDate = objvDnFuncMapCond.dicFldComparisonOp[convDnFuncMap.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap.UpdDate, objvDnFuncMapCond.UpdDate, strComparisonOpUpdDate);
}
if (objvDnFuncMapCond.IsUpdated(convDnFuncMap.UpdUser) == true)
{
string strComparisonOpUpdUser = objvDnFuncMapCond.dicFldComparisonOp[convDnFuncMap.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap.UpdUser, objvDnFuncMapCond.UpdUser, strComparisonOpUpdUser);
}
if (objvDnFuncMapCond.IsUpdated(convDnFuncMap.Memo) == true)
{
string strComparisonOpMemo = objvDnFuncMapCond.dicFldComparisonOp[convDnFuncMap.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap.Memo, objvDnFuncMapCond.Memo, strComparisonOpMemo);
}
if (objvDnFuncMapCond.IsUpdated(convDnFuncMap.InDataNodeName) == true)
{
string strComparisonOpInDataNodeName = objvDnFuncMapCond.dicFldComparisonOp[convDnFuncMap.InDataNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap.InDataNodeName, objvDnFuncMapCond.InDataNodeName, strComparisonOpInDataNodeName);
}
if (objvDnFuncMapCond.IsUpdated(convDnFuncMap.OutDataNodeName) == true)
{
string strComparisonOpOutDataNodeName = objvDnFuncMapCond.dicFldComparisonOp[convDnFuncMap.OutDataNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap.OutDataNodeName, objvDnFuncMapCond.OutDataNodeName, strComparisonOpOutDataNodeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v结点函数映射(vDnFuncMap)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvDnFuncMapWApi
{
private static readonly string mstrApiControllerName = "vDnFuncMapApi";

 public clsvDnFuncMapWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDnFuncMapEN GetObjByDnFuncMapId(string strDnFuncMapId)
{
if (strDnFuncMapId == "") return null;
string strAction = "GetObjByDnFuncMapId";
clsvDnFuncMapEN objvDnFuncMapEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDnFuncMapId"] = strDnFuncMapId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvDnFuncMapEN = JsonConvert.DeserializeObject<clsvDnFuncMapEN>(strJson);
return objvDnFuncMapEN;
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
public static clsvDnFuncMapEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvDnFuncMapEN objvDnFuncMapEN;
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
objvDnFuncMapEN = JsonConvert.DeserializeObject<clsvDnFuncMapEN>(strJson);
return objvDnFuncMapEN;
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
 /// <param name = "strDnFuncMapId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDnFuncMapEN GetObjByDnFuncMapIdCache(string strDnFuncMapId)
{
if (string.IsNullOrEmpty(strDnFuncMapId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvDnFuncMapEN._CurrTabName, strPrjId);
List<clsvDnFuncMapEN> arrvDnFuncMapObjLstCache = GetObjLstCache();
IEnumerable <clsvDnFuncMapEN> arrvDnFuncMapObjLst_Sel =
from objvDnFuncMapEN in arrvDnFuncMapObjLstCache
where objvDnFuncMapEN.DnFuncMapId == strDnFuncMapId 
select objvDnFuncMapEN;
if (arrvDnFuncMapObjLst_Sel.Count() == 0)
{
   clsvDnFuncMapEN obj = clsvDnFuncMapWApi.GetObjByDnFuncMapId(strDnFuncMapId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvDnFuncMapObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFuncMapEN> GetObjLst(string strWhereCond)
{
 List<clsvDnFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFuncMapEN>>(strJson);
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
 /// <param name = "arrDnFuncMapId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFuncMapEN> GetObjLstByDnFuncMapIdLst(List<string> arrDnFuncMapId)
{
 List<clsvDnFuncMapEN> arrObjLst; 
string strAction = "GetObjLstByDnFuncMapIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDnFuncMapId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFuncMapEN>>(strJson);
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
 /// <param name = "arrDnFuncMapId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvDnFuncMapEN> GetObjLstByDnFuncMapIdLstCache(List<string> arrDnFuncMapId, )
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvDnFuncMapEN._CurrTabName, strPrjId);
List<clsvDnFuncMapEN> arrvDnFuncMapObjLstCache = GetObjLstCache();
IEnumerable <clsvDnFuncMapEN> arrvDnFuncMapObjLst_Sel =
from objvDnFuncMapEN in arrvDnFuncMapObjLstCache
where arrDnFuncMapId.Contains(objvDnFuncMapEN.DnFuncMapId)
select objvDnFuncMapEN;
return arrvDnFuncMapObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFuncMapEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvDnFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFuncMapEN>>(strJson);
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
public static List<clsvDnFuncMapEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvDnFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFuncMapEN>>(strJson);
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
public static List<clsvDnFuncMapEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvDnFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFuncMapEN>>(strJson);
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
public static List<clsvDnFuncMapEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvDnFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDnFuncMapEN>>(strJson);
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
public static bool IsExist(string strDnFuncMapId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDnFuncMapId"] = strDnFuncMapId
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
 /// <param name = "objvDnFuncMapENS">源对象</param>
 /// <param name = "objvDnFuncMapENT">目标对象</param>
 public static void CopyTo(clsvDnFuncMapEN objvDnFuncMapENS, clsvDnFuncMapEN objvDnFuncMapENT)
{
try
{
objvDnFuncMapENT.DnFuncMapId = objvDnFuncMapENS.DnFuncMapId; //函数映射Id
objvDnFuncMapENT.InDataNodeId = objvDnFuncMapENS.InDataNodeId; //In数据结点Id
objvDnFuncMapENT.OutDataNodeId = objvDnFuncMapENS.OutDataNodeId; //Out数据结点Id
objvDnFuncMapENT.AssociationMappingId = objvDnFuncMapENS.AssociationMappingId; //关联关系映射Id
objvDnFuncMapENT.AssociationMappingName = objvDnFuncMapENS.AssociationMappingName; //关联关系映射名
objvDnFuncMapENT.FuncMapModeId = objvDnFuncMapENS.FuncMapModeId; //函数映射模式Id
objvDnFuncMapENT.FuncMapModeName = objvDnFuncMapENS.FuncMapModeName; //函数映射模式名
objvDnFuncMapENT.TabId = objvDnFuncMapENS.TabId; //表ID
objvDnFuncMapENT.DnFunctionId = objvDnFuncMapENS.DnFunctionId; //DN函数Id
objvDnFuncMapENT.PrjId = objvDnFuncMapENS.PrjId; //工程Id
objvDnFuncMapENT.UpdDate = objvDnFuncMapENS.UpdDate; //修改日期
objvDnFuncMapENT.UpdUser = objvDnFuncMapENS.UpdUser; //修改者
objvDnFuncMapENT.Memo = objvDnFuncMapENS.Memo; //说明
objvDnFuncMapENT.InDataNodeName = objvDnFuncMapENS.InDataNodeName; //In数据结点名
objvDnFuncMapENT.OutDataNodeName = objvDnFuncMapENS.OutDataNodeName; //Out数据结点名
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
public static DataTable ToDataTable(List<clsvDnFuncMapEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvDnFuncMapEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvDnFuncMapEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvDnFuncMapEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvDnFuncMapEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvDnFuncMapEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvDnFuncMapWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvDnFuncMapWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvDnFuncMapEN._CurrTabName, strPrjId);
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
public static List<clsvDnFuncMapEN> GetObjLstCache()
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvDnFuncMapWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvDnFuncMapWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvDnFuncMapEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvDnFuncMapEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convDnFuncMap.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvDnFuncMapEN._CurrTabName, strPrjId);
List<clsvDnFuncMapEN> arrvDnFuncMapObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvDnFuncMapObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDnFuncMapEN> GetObjLstCacheFromObjLst(List<clsvDnFuncMapEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvDnFuncMapWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvDnFuncMapWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvDnFuncMapEN._CurrTabName, strPrjId);
List<clsvDnFuncMapEN> arrvDnFuncMapObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvDnFuncMapObjLstCache = CacheHelper.Get<List<clsvDnFuncMapEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvDnFuncMapObjLstCache = CacheHelper.Get<List<clsvDnFuncMapEN>>(strKey);
}
return arrvDnFuncMapObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvDnFuncMapEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convDnFuncMap.DnFuncMapId, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap.InDataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(convDnFuncMap.OutDataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(convDnFuncMap.AssociationMappingId, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap.AssociationMappingName, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap.FuncMapModeId, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap.FuncMapModeName, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap.DnFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap.InDataNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convDnFuncMap.OutDataNodeName, Type.GetType("System.String"));
foreach (clsvDnFuncMapEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convDnFuncMap.DnFuncMapId] = objInFor[convDnFuncMap.DnFuncMapId];
objDR[convDnFuncMap.InDataNodeId] = objInFor[convDnFuncMap.InDataNodeId];
objDR[convDnFuncMap.OutDataNodeId] = objInFor[convDnFuncMap.OutDataNodeId];
objDR[convDnFuncMap.AssociationMappingId] = objInFor[convDnFuncMap.AssociationMappingId];
objDR[convDnFuncMap.AssociationMappingName] = objInFor[convDnFuncMap.AssociationMappingName];
objDR[convDnFuncMap.FuncMapModeId] = objInFor[convDnFuncMap.FuncMapModeId];
objDR[convDnFuncMap.FuncMapModeName] = objInFor[convDnFuncMap.FuncMapModeName];
objDR[convDnFuncMap.TabId] = objInFor[convDnFuncMap.TabId];
objDR[convDnFuncMap.DnFunctionId] = objInFor[convDnFuncMap.DnFunctionId];
objDR[convDnFuncMap.PrjId] = objInFor[convDnFuncMap.PrjId];
objDR[convDnFuncMap.UpdDate] = objInFor[convDnFuncMap.UpdDate];
objDR[convDnFuncMap.UpdUser] = objInFor[convDnFuncMap.UpdUser];
objDR[convDnFuncMap.Memo] = objInFor[convDnFuncMap.Memo];
objDR[convDnFuncMap.InDataNodeName] = objInFor[convDnFuncMap.InDataNodeName];
objDR[convDnFuncMap.OutDataNodeName] = objInFor[convDnFuncMap.OutDataNodeName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}