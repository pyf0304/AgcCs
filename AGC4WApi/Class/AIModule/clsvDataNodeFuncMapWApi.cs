
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDataNodeFuncMapWApi
 表名:vDataNodeFuncMap(00050554)
 * 版本:2023.01.09.1(服务器:WIN-SRV103-116)
 日期:2023/01/09 22:49:42
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
 框架-层名:WA_访问层(CS)(WA_Access)
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
public static class clsvDataNodeFuncMapWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnFuncMapId">函数映射Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetDnFuncMapId(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strDnFuncMapId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnFuncMapId, 8, convDataNodeFuncMap.DnFuncMapId);
clsCheckSql.CheckFieldForeignKey(strDnFuncMapId, 8, convDataNodeFuncMap.DnFuncMapId);
objvDataNodeFuncMapEN.DnFuncMapId = strDnFuncMapId; //函数映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.DnFuncMapId) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.DnFuncMapId, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.DnFuncMapId] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strInDataNodeId">In数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetInDataNodeId(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strInDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInDataNodeId, 8, convDataNodeFuncMap.InDataNodeId);
clsCheckSql.CheckFieldForeignKey(strInDataNodeId, 8, convDataNodeFuncMap.InDataNodeId);
objvDataNodeFuncMapEN.InDataNodeId = strInDataNodeId; //In数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.InDataNodeId) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.InDataNodeId, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.InDataNodeId] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutDataNodeId">Out数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetOutDataNodeId(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strOutDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutDataNodeId, 8, convDataNodeFuncMap.OutDataNodeId);
clsCheckSql.CheckFieldForeignKey(strOutDataNodeId, 8, convDataNodeFuncMap.OutDataNodeId);
objvDataNodeFuncMapEN.OutDataNodeId = strOutDataNodeId; //Out数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.OutDataNodeId) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.OutDataNodeId, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.OutDataNodeId] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strAssociationMappingId">关联关系映射Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetAssociationMappingId(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strAssociationMappingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAssociationMappingId, 2, convDataNodeFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldForeignKey(strAssociationMappingId, 2, convDataNodeFuncMap.AssociationMappingId);
objvDataNodeFuncMapEN.AssociationMappingId = strAssociationMappingId; //关联关系映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.AssociationMappingId) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.AssociationMappingId, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.AssociationMappingId] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strAssociationMappingName">关联关系映射名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetAssociationMappingName(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strAssociationMappingName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAssociationMappingName, 50, convDataNodeFuncMap.AssociationMappingName);
objvDataNodeFuncMapEN.AssociationMappingName = strAssociationMappingName; //关联关系映射名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.AssociationMappingName) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.AssociationMappingName, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.AssociationMappingName] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncMapModeId">函数映射模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetFuncMapModeId(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strFuncMapModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncMapModeId, 2, convDataNodeFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldForeignKey(strFuncMapModeId, 2, convDataNodeFuncMap.FuncMapModeId);
objvDataNodeFuncMapEN.FuncMapModeId = strFuncMapModeId; //函数映射模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.FuncMapModeId) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.FuncMapModeId, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.FuncMapModeId] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncMapModeName">函数映射模式名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetFuncMapModeName(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strFuncMapModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncMapModeName, 50, convDataNodeFuncMap.FuncMapModeName);
objvDataNodeFuncMapEN.FuncMapModeName = strFuncMapModeName; //函数映射模式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.FuncMapModeName) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.FuncMapModeName, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.FuncMapModeName] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetTabId(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convDataNodeFuncMap.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convDataNodeFuncMap.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convDataNodeFuncMap.TabId);
objvDataNodeFuncMapEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.TabId) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.TabId, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.TabId] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnFunctionId">DN函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetDnFunctionId(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strDnFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnFunctionId, 8, convDataNodeFuncMap.DnFunctionId);
clsCheckSql.CheckFieldForeignKey(strDnFunctionId, 8, convDataNodeFuncMap.DnFunctionId);
objvDataNodeFuncMapEN.DnFunctionId = strDnFunctionId; //DN函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.DnFunctionId) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.DnFunctionId, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.DnFunctionId] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetPrjId(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convDataNodeFuncMap.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convDataNodeFuncMap.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDataNodeFuncMap.PrjId);
objvDataNodeFuncMapEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.PrjId) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.PrjId, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.PrjId] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">CM工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetCmPrjId(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convDataNodeFuncMap.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convDataNodeFuncMap.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convDataNodeFuncMap.CmPrjId);
objvDataNodeFuncMapEN.CmPrjId = strCmPrjId; //CM工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.CmPrjId) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.CmPrjId, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.CmPrjId] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjName">CM工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetCmPrjName(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strCmPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convDataNodeFuncMap.CmPrjName);
objvDataNodeFuncMapEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.CmPrjName) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.CmPrjName, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.CmPrjName] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetUpdDate(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDataNodeFuncMap.UpdDate);
objvDataNodeFuncMapEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.UpdDate) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.UpdDate, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.UpdDate] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetUpdUser(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convDataNodeFuncMap.UpdUser);
objvDataNodeFuncMapEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.UpdUser) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.UpdUser, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.UpdUser] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetMemo(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDataNodeFuncMap.Memo);
objvDataNodeFuncMapEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.Memo) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.Memo, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.Memo] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strInDataNodeName">In数据结点名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetInDataNodeName(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strInDataNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInDataNodeName, 100, convDataNodeFuncMap.InDataNodeName);
objvDataNodeFuncMapEN.InDataNodeName = strInDataNodeName; //In数据结点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.InDataNodeName) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.InDataNodeName, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.InDataNodeName] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutDataNodeName">Out数据结点名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDataNodeFuncMapEN SetOutDataNodeName(this clsvDataNodeFuncMapEN objvDataNodeFuncMapEN, string strOutDataNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutDataNodeName, 50, convDataNodeFuncMap.OutDataNodeName);
objvDataNodeFuncMapEN.OutDataNodeName = strOutDataNodeName; //Out数据结点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(convDataNodeFuncMap.OutDataNodeName) == false)
{
objvDataNodeFuncMapEN.dicFldComparisonOp.Add(convDataNodeFuncMap.OutDataNodeName, strComparisonOp);
}
else
{
objvDataNodeFuncMapEN.dicFldComparisonOp[convDataNodeFuncMap.OutDataNodeName] = strComparisonOp;
}
}
return objvDataNodeFuncMapEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDataNodeFuncMapEN objvDataNodeFuncMap_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.DnFuncMapId) == true)
{
string strComparisonOp_DnFuncMapId = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.DnFuncMapId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.DnFuncMapId, objvDataNodeFuncMap_Cond.DnFuncMapId, strComparisonOp_DnFuncMapId);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.InDataNodeId) == true)
{
string strComparisonOp_InDataNodeId = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.InDataNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.InDataNodeId, objvDataNodeFuncMap_Cond.InDataNodeId, strComparisonOp_InDataNodeId);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.OutDataNodeId) == true)
{
string strComparisonOp_OutDataNodeId = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.OutDataNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.OutDataNodeId, objvDataNodeFuncMap_Cond.OutDataNodeId, strComparisonOp_OutDataNodeId);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.AssociationMappingId) == true)
{
string strComparisonOp_AssociationMappingId = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.AssociationMappingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.AssociationMappingId, objvDataNodeFuncMap_Cond.AssociationMappingId, strComparisonOp_AssociationMappingId);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.AssociationMappingName) == true)
{
string strComparisonOp_AssociationMappingName = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.AssociationMappingName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.AssociationMappingName, objvDataNodeFuncMap_Cond.AssociationMappingName, strComparisonOp_AssociationMappingName);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.FuncMapModeId) == true)
{
string strComparisonOp_FuncMapModeId = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.FuncMapModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.FuncMapModeId, objvDataNodeFuncMap_Cond.FuncMapModeId, strComparisonOp_FuncMapModeId);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.FuncMapModeName) == true)
{
string strComparisonOp_FuncMapModeName = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.FuncMapModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.FuncMapModeName, objvDataNodeFuncMap_Cond.FuncMapModeName, strComparisonOp_FuncMapModeName);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.TabId) == true)
{
string strComparisonOp_TabId = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.TabId, objvDataNodeFuncMap_Cond.TabId, strComparisonOp_TabId);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.DnFunctionId) == true)
{
string strComparisonOp_DnFunctionId = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.DnFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.DnFunctionId, objvDataNodeFuncMap_Cond.DnFunctionId, strComparisonOp_DnFunctionId);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.PrjId) == true)
{
string strComparisonOp_PrjId = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.PrjId, objvDataNodeFuncMap_Cond.PrjId, strComparisonOp_PrjId);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.CmPrjId) == true)
{
string strComparisonOp_CmPrjId = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.CmPrjId, objvDataNodeFuncMap_Cond.CmPrjId, strComparisonOp_CmPrjId);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.CmPrjName) == true)
{
string strComparisonOp_CmPrjName = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.CmPrjName, objvDataNodeFuncMap_Cond.CmPrjName, strComparisonOp_CmPrjName);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.UpdDate, objvDataNodeFuncMap_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.UpdUser, objvDataNodeFuncMap_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.Memo) == true)
{
string strComparisonOp_Memo = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.Memo, objvDataNodeFuncMap_Cond.Memo, strComparisonOp_Memo);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.InDataNodeName) == true)
{
string strComparisonOp_InDataNodeName = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.InDataNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.InDataNodeName, objvDataNodeFuncMap_Cond.InDataNodeName, strComparisonOp_InDataNodeName);
}
if (objvDataNodeFuncMap_Cond.IsUpdated(convDataNodeFuncMap.OutDataNodeName) == true)
{
string strComparisonOp_OutDataNodeName = objvDataNodeFuncMap_Cond.dicFldComparisonOp[convDataNodeFuncMap.OutDataNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNodeFuncMap.OutDataNodeName, objvDataNodeFuncMap_Cond.OutDataNodeName, strComparisonOp_OutDataNodeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v结点函数映射(vDataNodeFuncMap)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvDataNodeFuncMapWApi
{
private static readonly string mstrApiControllerName = "vDataNodeFuncMapApi";

 public clsvDataNodeFuncMapWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDataNodeFuncMapEN GetObjByDnFuncMapId(string strDnFuncMapId)
{
string strAction = "GetObjByDnFuncMapId";
clsvDataNodeFuncMapEN objvDataNodeFuncMapEN;
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
objvDataNodeFuncMapEN = JsonConvert.DeserializeObject<clsvDataNodeFuncMapEN>(strJson);
return objvDataNodeFuncMapEN;
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
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDataNodeFuncMapEN GetObjByDnFuncMapId_WA_Cache(string strDnFuncMapId, string strCmPrjId)
{
string strAction = "GetObjByDnFuncMapId_Cache";
clsvDataNodeFuncMapEN objvDataNodeFuncMapEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["DnFuncMapId"] = strDnFuncMapId,
["CmPrjId"] = strCmPrjId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvDataNodeFuncMapEN = JsonConvert.DeserializeObject<clsvDataNodeFuncMapEN>(strJson);
return objvDataNodeFuncMapEN;
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
public static clsvDataNodeFuncMapEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvDataNodeFuncMapEN objvDataNodeFuncMapEN;
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
objvDataNodeFuncMapEN = JsonConvert.DeserializeObject<clsvDataNodeFuncMapEN>(strJson);
return objvDataNodeFuncMapEN;
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strDnFuncMapId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDataNodeFuncMapEN GetObjByDnFuncMapId_Cache(string strDnFuncMapId, string strCmPrjId)
{
if (string.IsNullOrEmpty(strDnFuncMapId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvDataNodeFuncMapEN._CurrTabName, strCmPrjId);
List<clsvDataNodeFuncMapEN> arrvDataNodeFuncMapObjLst_Cache = GetObjLst_Cache(strCmPrjId);
IEnumerable <clsvDataNodeFuncMapEN> arrvDataNodeFuncMapObjLst_Sel =
from objvDataNodeFuncMapEN in arrvDataNodeFuncMapObjLst_Cache
where objvDataNodeFuncMapEN.DnFuncMapId == strDnFuncMapId 
select objvDataNodeFuncMapEN;
if (arrvDataNodeFuncMapObjLst_Sel.Count() == 0)
{
   clsvDataNodeFuncMapEN obj = clsvDataNodeFuncMapWApi.GetObjByDnFuncMapId(strDnFuncMapId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvDataNodeFuncMapObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataNodeFuncMapEN> GetObjLst(string strWhereCond)
{
 List<clsvDataNodeFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNodeFuncMapEN>>(strJson);
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
public static List<clsvDataNodeFuncMapEN> GetObjLstByDnFuncMapIdLst(List<string> arrDnFuncMapId)
{
 List<clsvDataNodeFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNodeFuncMapEN>>(strJson);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "arrDnFuncMapId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvDataNodeFuncMapEN> GetObjLstByDnFuncMapIdLst_Cache(List<string> arrDnFuncMapId, string strCmPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvDataNodeFuncMapEN._CurrTabName, strCmPrjId);
List<clsvDataNodeFuncMapEN> arrvDataNodeFuncMapObjLst_Cache = GetObjLst_Cache(strCmPrjId);
IEnumerable <clsvDataNodeFuncMapEN> arrvDataNodeFuncMapObjLst_Sel =
from objvDataNodeFuncMapEN in arrvDataNodeFuncMapObjLst_Cache
where arrDnFuncMapId.Contains(objvDataNodeFuncMapEN.DnFuncMapId)
select objvDataNodeFuncMapEN;
return arrvDataNodeFuncMapObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "arrDnFuncMapId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataNodeFuncMapEN> GetObjLstByDnFuncMapIdLst_WA_Cache(List<string> arrDnFuncMapId, string strCmPrjId)
{
 List<clsvDataNodeFuncMapEN> arrObjLst; 
string strAction = "GetObjLstByDnFuncMapIdLst_Cache";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CmPrjId"] = strCmPrjId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDnFuncMapId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNodeFuncMapEN>>(strJson);
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
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataNodeFuncMapEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvDataNodeFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNodeFuncMapEN>>(strJson);
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
public static List<clsvDataNodeFuncMapEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvDataNodeFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNodeFuncMapEN>>(strJson);
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
public static List<clsvDataNodeFuncMapEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvDataNodeFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNodeFuncMapEN>>(strJson);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvDataNodeFuncMapEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvDataNodeFuncMapEN> arrObjLst; 
string strAction = "GetObjLstByPager_Cache";
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNodeFuncMapEN>>(strJson);
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
 /// <param name = "objvDataNodeFuncMapENS">源对象</param>
 /// <param name = "objvDataNodeFuncMapENT">目标对象</param>
 public static void CopyTo(clsvDataNodeFuncMapEN objvDataNodeFuncMapENS, clsvDataNodeFuncMapEN objvDataNodeFuncMapENT)
{
try
{
objvDataNodeFuncMapENT.DnFuncMapId = objvDataNodeFuncMapENS.DnFuncMapId; //函数映射Id
objvDataNodeFuncMapENT.InDataNodeId = objvDataNodeFuncMapENS.InDataNodeId; //In数据结点Id
objvDataNodeFuncMapENT.OutDataNodeId = objvDataNodeFuncMapENS.OutDataNodeId; //Out数据结点Id
objvDataNodeFuncMapENT.AssociationMappingId = objvDataNodeFuncMapENS.AssociationMappingId; //关联关系映射Id
objvDataNodeFuncMapENT.AssociationMappingName = objvDataNodeFuncMapENS.AssociationMappingName; //关联关系映射名
objvDataNodeFuncMapENT.FuncMapModeId = objvDataNodeFuncMapENS.FuncMapModeId; //函数映射模式Id
objvDataNodeFuncMapENT.FuncMapModeName = objvDataNodeFuncMapENS.FuncMapModeName; //函数映射模式名
objvDataNodeFuncMapENT.TabId = objvDataNodeFuncMapENS.TabId; //表ID
objvDataNodeFuncMapENT.DnFunctionId = objvDataNodeFuncMapENS.DnFunctionId; //DN函数Id
objvDataNodeFuncMapENT.PrjId = objvDataNodeFuncMapENS.PrjId; //工程ID
objvDataNodeFuncMapENT.CmPrjId = objvDataNodeFuncMapENS.CmPrjId; //CM工程Id
objvDataNodeFuncMapENT.CmPrjName = objvDataNodeFuncMapENS.CmPrjName; //CM工程名
objvDataNodeFuncMapENT.UpdDate = objvDataNodeFuncMapENS.UpdDate; //修改日期
objvDataNodeFuncMapENT.UpdUser = objvDataNodeFuncMapENS.UpdUser; //修改者
objvDataNodeFuncMapENT.Memo = objvDataNodeFuncMapENS.Memo; //说明
objvDataNodeFuncMapENT.InDataNodeName = objvDataNodeFuncMapENS.InDataNodeName; //In数据结点名
objvDataNodeFuncMapENT.OutDataNodeName = objvDataNodeFuncMapENS.OutDataNodeName; //Out数据结点名
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
public static DataTable ToDataTable(List<clsvDataNodeFuncMapEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvDataNodeFuncMapEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvDataNodeFuncMapEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvDataNodeFuncMapEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvDataNodeFuncMapEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvDataNodeFuncMapEN.AttributeName)
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
public static void ReFreshThisCache(string strCmPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvDataNodeFuncMapEN._CurrTabName, strCmPrjId);
CacheHelper.Remove(strKey);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDataNodeFuncMapEN> GetObjLst_Cache(string strCmPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvDataNodeFuncMapEN._CurrTabName, strCmPrjId);
List<clsvDataNodeFuncMapEN> arrvDataNodeFuncMapObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CmPrjId='{0}'", strCmPrjId)); });
return arrvDataNodeFuncMapObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvDataNodeFuncMapEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convDataNodeFuncMap.DnFuncMapId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.InDataNodeId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.OutDataNodeId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.AssociationMappingId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.AssociationMappingName, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.FuncMapModeId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.FuncMapModeName, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.DnFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.CmPrjName, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.InDataNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convDataNodeFuncMap.OutDataNodeName, Type.GetType("System.String"));
foreach (clsvDataNodeFuncMapEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convDataNodeFuncMap.DnFuncMapId] = objInFor[convDataNodeFuncMap.DnFuncMapId];
objDR[convDataNodeFuncMap.InDataNodeId] = objInFor[convDataNodeFuncMap.InDataNodeId];
objDR[convDataNodeFuncMap.OutDataNodeId] = objInFor[convDataNodeFuncMap.OutDataNodeId];
objDR[convDataNodeFuncMap.AssociationMappingId] = objInFor[convDataNodeFuncMap.AssociationMappingId];
objDR[convDataNodeFuncMap.AssociationMappingName] = objInFor[convDataNodeFuncMap.AssociationMappingName];
objDR[convDataNodeFuncMap.FuncMapModeId] = objInFor[convDataNodeFuncMap.FuncMapModeId];
objDR[convDataNodeFuncMap.FuncMapModeName] = objInFor[convDataNodeFuncMap.FuncMapModeName];
objDR[convDataNodeFuncMap.TabId] = objInFor[convDataNodeFuncMap.TabId];
objDR[convDataNodeFuncMap.DnFunctionId] = objInFor[convDataNodeFuncMap.DnFunctionId];
objDR[convDataNodeFuncMap.PrjId] = objInFor[convDataNodeFuncMap.PrjId];
objDR[convDataNodeFuncMap.CmPrjId] = objInFor[convDataNodeFuncMap.CmPrjId];
objDR[convDataNodeFuncMap.CmPrjName] = objInFor[convDataNodeFuncMap.CmPrjName];
objDR[convDataNodeFuncMap.UpdDate] = objInFor[convDataNodeFuncMap.UpdDate];
objDR[convDataNodeFuncMap.UpdUser] = objInFor[convDataNodeFuncMap.UpdUser];
objDR[convDataNodeFuncMap.Memo] = objInFor[convDataNodeFuncMap.Memo];
objDR[convDataNodeFuncMap.InDataNodeName] = objInFor[convDataNodeFuncMap.InDataNodeName];
objDR[convDataNodeFuncMap.OutDataNodeName] = objInFor[convDataNodeFuncMap.OutDataNodeName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}