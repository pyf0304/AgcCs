
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnFuncMapBL
 表名:vDnFuncMap(00050554)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:27:30
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
public static class  clsvDnFuncMapBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDnFuncMapEN GetObj(this K_DnFuncMapId_vDnFuncMap myKey)
{
clsvDnFuncMapEN objvDnFuncMapEN = clsvDnFuncMapBL.vDnFuncMapDA.GetObjByDnFuncMapId(myKey.Value);
return objvDnFuncMapEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetDnFuncMapId(this clsvDnFuncMapEN objvDnFuncMapEN, string strDnFuncMapId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDnFuncMapId, 8, convDnFuncMap.DnFuncMapId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDnFuncMapId, 8, convDnFuncMap.DnFuncMapId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetInDataNodeId(this clsvDnFuncMapEN objvDnFuncMapEN, long? lngInDataNodeId, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetOutDataNodeId(this clsvDnFuncMapEN objvDnFuncMapEN, long? lngOutDataNodeId, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetAssociationMappingId(this clsvDnFuncMapEN objvDnFuncMapEN, string strAssociationMappingId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAssociationMappingId, 2, convDnFuncMap.AssociationMappingId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAssociationMappingId, 2, convDnFuncMap.AssociationMappingId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetAssociationMappingName(this clsvDnFuncMapEN objvDnFuncMapEN, string strAssociationMappingName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAssociationMappingName, 50, convDnFuncMap.AssociationMappingName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetFuncMapModeId(this clsvDnFuncMapEN objvDnFuncMapEN, string strFuncMapModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncMapModeId, 2, convDnFuncMap.FuncMapModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncMapModeId, 2, convDnFuncMap.FuncMapModeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetFuncMapModeName(this clsvDnFuncMapEN objvDnFuncMapEN, string strFuncMapModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncMapModeName, 50, convDnFuncMap.FuncMapModeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetTabId(this clsvDnFuncMapEN objvDnFuncMapEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convDnFuncMap.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convDnFuncMap.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convDnFuncMap.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetDnFunctionId(this clsvDnFuncMapEN objvDnFuncMapEN, string strDnFunctionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDnFunctionId, 8, convDnFuncMap.DnFunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDnFunctionId, 8, convDnFuncMap.DnFunctionId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetPrjId(this clsvDnFuncMapEN objvDnFuncMapEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convDnFuncMap.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convDnFuncMap.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDnFuncMap.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetUpdDate(this clsvDnFuncMapEN objvDnFuncMapEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDnFuncMap.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetUpdUser(this clsvDnFuncMapEN objvDnFuncMapEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convDnFuncMap.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetMemo(this clsvDnFuncMapEN objvDnFuncMapEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDnFuncMap.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetInDataNodeName(this clsvDnFuncMapEN objvDnFuncMapEN, string strInDataNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInDataNodeName, 100, convDnFuncMap.InDataNodeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMapEN SetOutDataNodeName(this clsvDnFuncMapEN objvDnFuncMapEN, string strOutDataNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOutDataNodeName, 100, convDnFuncMap.OutDataNodeName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvDnFuncMapENS">源对象</param>
 /// <param name = "objvDnFuncMapENT">目标对象</param>
 public static void CopyTo(this clsvDnFuncMapEN objvDnFuncMapENS, clsvDnFuncMapEN objvDnFuncMapENT)
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
 /// <param name = "objvDnFuncMapENS">源对象</param>
 /// <returns>目标对象=>clsvDnFuncMapEN:objvDnFuncMapENT</returns>
 public static clsvDnFuncMapEN CopyTo(this clsvDnFuncMapEN objvDnFuncMapENS)
{
try
{
 clsvDnFuncMapEN objvDnFuncMapENT = new clsvDnFuncMapEN()
{
DnFuncMapId = objvDnFuncMapENS.DnFuncMapId, //函数映射Id
InDataNodeId = objvDnFuncMapENS.InDataNodeId, //In数据结点Id
OutDataNodeId = objvDnFuncMapENS.OutDataNodeId, //Out数据结点Id
AssociationMappingId = objvDnFuncMapENS.AssociationMappingId, //关联关系映射Id
AssociationMappingName = objvDnFuncMapENS.AssociationMappingName, //关联关系映射名
FuncMapModeId = objvDnFuncMapENS.FuncMapModeId, //函数映射模式Id
FuncMapModeName = objvDnFuncMapENS.FuncMapModeName, //函数映射模式名
TabId = objvDnFuncMapENS.TabId, //表ID
DnFunctionId = objvDnFuncMapENS.DnFunctionId, //DN函数Id
PrjId = objvDnFuncMapENS.PrjId, //工程Id
UpdDate = objvDnFuncMapENS.UpdDate, //修改日期
UpdUser = objvDnFuncMapENS.UpdUser, //修改者
Memo = objvDnFuncMapENS.Memo, //说明
InDataNodeName = objvDnFuncMapENS.InDataNodeName, //In数据结点名
OutDataNodeName = objvDnFuncMapENS.OutDataNodeName, //Out数据结点名
};
 return objvDnFuncMapENT;
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
public static void CheckProperty4Condition(this clsvDnFuncMapEN objvDnFuncMapEN)
{
 clsvDnFuncMapBL.vDnFuncMapDA.CheckProperty4Condition(objvDnFuncMapEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vDnFuncMap
{
public virtual bool UpdRelaTabDate(string strDnFuncMapId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v结点函数映射(vDnFuncMap)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvDnFuncMapBL
{
public static RelatedActions_vDnFuncMap relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvDnFuncMapDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvDnFuncMapDA vDnFuncMapDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvDnFuncMapDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvDnFuncMapBL()
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
if (string.IsNullOrEmpty(clsvDnFuncMapEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDnFuncMapEN._ConnectString);
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
public static DataTable GetDataTable_vDnFuncMap(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vDnFuncMapDA.GetDataTable_vDnFuncMap(strWhereCond);
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
objDT = vDnFuncMapDA.GetDataTable(strWhereCond);
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
objDT = vDnFuncMapDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vDnFuncMapDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vDnFuncMapDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vDnFuncMapDA.GetDataTable_Top(objTopPara);
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
objDT = vDnFuncMapDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vDnFuncMapDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vDnFuncMapDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDnFuncMapIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvDnFuncMapEN> GetObjLstByDnFuncMapIdLst(List<string> arrDnFuncMapIdLst)
{
List<clsvDnFuncMapEN> arrObjLst = new List<clsvDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDnFuncMapIdLst, true);
 string strWhereCond = string.Format("DnFuncMapId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN();
try
{
objvDnFuncMapEN.DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMapEN.InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMapEN.OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMapEN.AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMapEN.AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFuncMapEN.FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMapEN.FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDnFuncMapEN.TabId = objRow[convDnFuncMap.TabId].ToString().Trim(); //表ID
objvDnFuncMapEN.DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMapEN.PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(); //工程Id
objvDnFuncMapEN.UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDnFuncMapEN.UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(); //修改者
objvDnFuncMapEN.Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(); //说明
objvDnFuncMapEN.InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDnFuncMapEN.OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMapEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDnFuncMapIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvDnFuncMapEN> GetObjLstByDnFuncMapIdLstCache(List<string> arrDnFuncMapIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvDnFuncMapEN._CurrTabName, strPrjId);
List<clsvDnFuncMapEN> arrvDnFuncMapObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFuncMapEN> arrvDnFuncMapObjLst_Sel =
arrvDnFuncMapObjLstCache
.Where(x => arrDnFuncMapIdLst.Contains(x.DnFuncMapId));
return arrvDnFuncMapObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFuncMapEN> GetObjLst(string strWhereCond)
{
List<clsvDnFuncMapEN> arrObjLst = new List<clsvDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN();
try
{
objvDnFuncMapEN.DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMapEN.InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMapEN.OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMapEN.AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMapEN.AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFuncMapEN.FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMapEN.FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDnFuncMapEN.TabId = objRow[convDnFuncMap.TabId].ToString().Trim(); //表ID
objvDnFuncMapEN.DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMapEN.PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(); //工程Id
objvDnFuncMapEN.UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDnFuncMapEN.UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(); //修改者
objvDnFuncMapEN.Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(); //说明
objvDnFuncMapEN.InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDnFuncMapEN.OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMapEN);
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
public static List<clsvDnFuncMapEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvDnFuncMapEN> arrObjLst = new List<clsvDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN();
try
{
objvDnFuncMapEN.DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMapEN.InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMapEN.OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMapEN.AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMapEN.AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFuncMapEN.FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMapEN.FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDnFuncMapEN.TabId = objRow[convDnFuncMap.TabId].ToString().Trim(); //表ID
objvDnFuncMapEN.DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMapEN.PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(); //工程Id
objvDnFuncMapEN.UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDnFuncMapEN.UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(); //修改者
objvDnFuncMapEN.Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(); //说明
objvDnFuncMapEN.InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDnFuncMapEN.OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMapEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvDnFuncMapCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvDnFuncMapEN> GetSubObjLstCache(clsvDnFuncMapEN objvDnFuncMapCond)
{
 string strPrjId = objvDnFuncMapCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvDnFuncMapBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvDnFuncMapEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFuncMapEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDnFuncMap._AttributeName)
{
if (objvDnFuncMapCond.IsUpdated(strFldName) == false) continue;
if (objvDnFuncMapCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDnFuncMapCond[strFldName].ToString());
}
else
{
if (objvDnFuncMapCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDnFuncMapCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDnFuncMapCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDnFuncMapCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDnFuncMapCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDnFuncMapCond[strFldName]));
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
public static List<clsvDnFuncMapEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvDnFuncMapEN> arrObjLst = new List<clsvDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN();
try
{
objvDnFuncMapEN.DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMapEN.InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMapEN.OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMapEN.AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMapEN.AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFuncMapEN.FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMapEN.FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDnFuncMapEN.TabId = objRow[convDnFuncMap.TabId].ToString().Trim(); //表ID
objvDnFuncMapEN.DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMapEN.PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(); //工程Id
objvDnFuncMapEN.UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDnFuncMapEN.UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(); //修改者
objvDnFuncMapEN.Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(); //说明
objvDnFuncMapEN.InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDnFuncMapEN.OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMapEN);
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
public static List<clsvDnFuncMapEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvDnFuncMapEN> arrObjLst = new List<clsvDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN();
try
{
objvDnFuncMapEN.DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMapEN.InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMapEN.OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMapEN.AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMapEN.AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFuncMapEN.FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMapEN.FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDnFuncMapEN.TabId = objRow[convDnFuncMap.TabId].ToString().Trim(); //表ID
objvDnFuncMapEN.DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMapEN.PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(); //工程Id
objvDnFuncMapEN.UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDnFuncMapEN.UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(); //修改者
objvDnFuncMapEN.Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(); //说明
objvDnFuncMapEN.InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDnFuncMapEN.OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMapEN);
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
List<clsvDnFuncMapEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvDnFuncMapEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFuncMapEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvDnFuncMapEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvDnFuncMapEN> arrObjLst = new List<clsvDnFuncMapEN>(); 
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
	clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN();
try
{
objvDnFuncMapEN.DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMapEN.InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMapEN.OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMapEN.AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMapEN.AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFuncMapEN.FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMapEN.FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDnFuncMapEN.TabId = objRow[convDnFuncMap.TabId].ToString().Trim(); //表ID
objvDnFuncMapEN.DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMapEN.PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(); //工程Id
objvDnFuncMapEN.UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDnFuncMapEN.UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(); //修改者
objvDnFuncMapEN.Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(); //说明
objvDnFuncMapEN.InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDnFuncMapEN.OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMapEN);
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
public static List<clsvDnFuncMapEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvDnFuncMapEN> arrObjLst = new List<clsvDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN();
try
{
objvDnFuncMapEN.DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMapEN.InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMapEN.OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMapEN.AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMapEN.AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFuncMapEN.FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMapEN.FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDnFuncMapEN.TabId = objRow[convDnFuncMap.TabId].ToString().Trim(); //表ID
objvDnFuncMapEN.DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMapEN.PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(); //工程Id
objvDnFuncMapEN.UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDnFuncMapEN.UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(); //修改者
objvDnFuncMapEN.Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(); //说明
objvDnFuncMapEN.InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDnFuncMapEN.OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMapEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvDnFuncMapEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvDnFuncMapEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvDnFuncMapEN> arrObjLst = new List<clsvDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN();
try
{
objvDnFuncMapEN.DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMapEN.InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMapEN.OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMapEN.AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMapEN.AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFuncMapEN.FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMapEN.FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDnFuncMapEN.TabId = objRow[convDnFuncMap.TabId].ToString().Trim(); //表ID
objvDnFuncMapEN.DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMapEN.PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(); //工程Id
objvDnFuncMapEN.UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDnFuncMapEN.UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(); //修改者
objvDnFuncMapEN.Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(); //说明
objvDnFuncMapEN.InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDnFuncMapEN.OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMapEN);
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
public static List<clsvDnFuncMapEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvDnFuncMapEN> arrObjLst = new List<clsvDnFuncMapEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN();
try
{
objvDnFuncMapEN.DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMapEN.InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMapEN.OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMapEN.AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMapEN.AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFuncMapEN.FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMapEN.FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDnFuncMapEN.TabId = objRow[convDnFuncMap.TabId].ToString().Trim(); //表ID
objvDnFuncMapEN.DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMapEN.PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(); //工程Id
objvDnFuncMapEN.UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDnFuncMapEN.UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(); //修改者
objvDnFuncMapEN.Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(); //说明
objvDnFuncMapEN.InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDnFuncMapEN.OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMapEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFuncMapEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvDnFuncMapEN> arrObjLst = new List<clsvDnFuncMapEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMapEN objvDnFuncMapEN = new clsvDnFuncMapEN();
try
{
objvDnFuncMapEN.DnFuncMapId = objRow[convDnFuncMap.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMapEN.InDataNodeId = objRow[convDnFuncMap.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMapEN.OutDataNodeId = objRow[convDnFuncMap.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMapEN.AssociationMappingId = objRow[convDnFuncMap.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMapEN.AssociationMappingName = objRow[convDnFuncMap.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFuncMap.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFuncMapEN.FuncMapModeId = objRow[convDnFuncMap.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMapEN.FuncMapModeName = objRow[convDnFuncMap.FuncMapModeName] == DBNull.Value ? null : objRow[convDnFuncMap.FuncMapModeName].ToString().Trim(); //函数映射模式名
objvDnFuncMapEN.TabId = objRow[convDnFuncMap.TabId].ToString().Trim(); //表ID
objvDnFuncMapEN.DnFunctionId = objRow[convDnFuncMap.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMapEN.PrjId = objRow[convDnFuncMap.PrjId].ToString().Trim(); //工程Id
objvDnFuncMapEN.UpdDate = objRow[convDnFuncMap.UpdDate] == DBNull.Value ? null : objRow[convDnFuncMap.UpdDate].ToString().Trim(); //修改日期
objvDnFuncMapEN.UpdUser = objRow[convDnFuncMap.UpdUser] == DBNull.Value ? null : objRow[convDnFuncMap.UpdUser].ToString().Trim(); //修改者
objvDnFuncMapEN.Memo = objRow[convDnFuncMap.Memo] == DBNull.Value ? null : objRow[convDnFuncMap.Memo].ToString().Trim(); //说明
objvDnFuncMapEN.InDataNodeName = objRow[convDnFuncMap.InDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.InDataNodeName].ToString().Trim(); //In数据结点名
objvDnFuncMapEN.OutDataNodeName = objRow[convDnFuncMap.OutDataNodeName] == DBNull.Value ? null : objRow[convDnFuncMap.OutDataNodeName].ToString().Trim(); //Out数据结点名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMapEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMapEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvDnFuncMapEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvDnFuncMap(ref clsvDnFuncMapEN objvDnFuncMapEN)
{
bool bolResult = vDnFuncMapDA.GetvDnFuncMap(ref objvDnFuncMapEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDnFuncMapEN GetObjByDnFuncMapId(string strDnFuncMapId)
{
if (strDnFuncMapId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDnFuncMapId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDnFuncMapId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDnFuncMapId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvDnFuncMapEN objvDnFuncMapEN = vDnFuncMapDA.GetObjByDnFuncMapId(strDnFuncMapId);
return objvDnFuncMapEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvDnFuncMapEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvDnFuncMapEN objvDnFuncMapEN = vDnFuncMapDA.GetFirstObj(strWhereCond);
 return objvDnFuncMapEN;
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
public static clsvDnFuncMapEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvDnFuncMapEN objvDnFuncMapEN = vDnFuncMapDA.GetObjByDataRow(objRow);
 return objvDnFuncMapEN;
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
public static clsvDnFuncMapEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvDnFuncMapEN objvDnFuncMapEN = vDnFuncMapDA.GetObjByDataRow(objRow);
 return objvDnFuncMapEN;
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
 /// <param name = "strDnFuncMapId">所给的关键字</param>
 /// <param name = "lstvDnFuncMapObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDnFuncMapEN GetObjByDnFuncMapIdFromList(string strDnFuncMapId, List<clsvDnFuncMapEN> lstvDnFuncMapObjLst)
{
foreach (clsvDnFuncMapEN objvDnFuncMapEN in lstvDnFuncMapObjLst)
{
if (objvDnFuncMapEN.DnFuncMapId == strDnFuncMapId)
{
return objvDnFuncMapEN;
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
 string strDnFuncMapId;
 try
 {
 strDnFuncMapId = new clsvDnFuncMapDA().GetFirstID(strWhereCond);
 return strDnFuncMapId;
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
 arrList = vDnFuncMapDA.GetID(strWhereCond);
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
bool bolIsExist = vDnFuncMapDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDnFuncMapId)
{
if (string.IsNullOrEmpty(strDnFuncMapId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDnFuncMapId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vDnFuncMapDA.IsExist(strDnFuncMapId);
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
 bolIsExist = clsvDnFuncMapDA.IsExistTable();
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
 bolIsExist = vDnFuncMapDA.IsExistTable(strTabName);
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
 /// <param name = "objvDnFuncMapEN">源简化对象</param>
 public static void SetUpdFlag(clsvDnFuncMapEN objvDnFuncMapEN)
{
try
{
objvDnFuncMapEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvDnFuncMapEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convDnFuncMap.DnFuncMapId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMapEN.DnFuncMapId = objvDnFuncMapEN.DnFuncMapId; //函数映射Id
}
if (arrFldSet.Contains(convDnFuncMap.InDataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMapEN.InDataNodeId = objvDnFuncMapEN.InDataNodeId; //In数据结点Id
}
if (arrFldSet.Contains(convDnFuncMap.OutDataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMapEN.OutDataNodeId = objvDnFuncMapEN.OutDataNodeId; //Out数据结点Id
}
if (arrFldSet.Contains(convDnFuncMap.AssociationMappingId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMapEN.AssociationMappingId = objvDnFuncMapEN.AssociationMappingId == "[null]" ? null :  objvDnFuncMapEN.AssociationMappingId; //关联关系映射Id
}
if (arrFldSet.Contains(convDnFuncMap.AssociationMappingName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMapEN.AssociationMappingName = objvDnFuncMapEN.AssociationMappingName == "[null]" ? null :  objvDnFuncMapEN.AssociationMappingName; //关联关系映射名
}
if (arrFldSet.Contains(convDnFuncMap.FuncMapModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMapEN.FuncMapModeId = objvDnFuncMapEN.FuncMapModeId == "[null]" ? null :  objvDnFuncMapEN.FuncMapModeId; //函数映射模式Id
}
if (arrFldSet.Contains(convDnFuncMap.FuncMapModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMapEN.FuncMapModeName = objvDnFuncMapEN.FuncMapModeName == "[null]" ? null :  objvDnFuncMapEN.FuncMapModeName; //函数映射模式名
}
if (arrFldSet.Contains(convDnFuncMap.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMapEN.TabId = objvDnFuncMapEN.TabId; //表ID
}
if (arrFldSet.Contains(convDnFuncMap.DnFunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMapEN.DnFunctionId = objvDnFuncMapEN.DnFunctionId == "[null]" ? null :  objvDnFuncMapEN.DnFunctionId; //DN函数Id
}
if (arrFldSet.Contains(convDnFuncMap.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMapEN.PrjId = objvDnFuncMapEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convDnFuncMap.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMapEN.UpdDate = objvDnFuncMapEN.UpdDate == "[null]" ? null :  objvDnFuncMapEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convDnFuncMap.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMapEN.UpdUser = objvDnFuncMapEN.UpdUser == "[null]" ? null :  objvDnFuncMapEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convDnFuncMap.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMapEN.Memo = objvDnFuncMapEN.Memo == "[null]" ? null :  objvDnFuncMapEN.Memo; //说明
}
if (arrFldSet.Contains(convDnFuncMap.InDataNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMapEN.InDataNodeName = objvDnFuncMapEN.InDataNodeName == "[null]" ? null :  objvDnFuncMapEN.InDataNodeName; //In数据结点名
}
if (arrFldSet.Contains(convDnFuncMap.OutDataNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMapEN.OutDataNodeName = objvDnFuncMapEN.OutDataNodeName == "[null]" ? null :  objvDnFuncMapEN.OutDataNodeName; //Out数据结点名
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
 /// <param name = "objvDnFuncMapEN">源简化对象</param>
 public static void AccessFldValueNull(clsvDnFuncMapEN objvDnFuncMapEN)
{
try
{
if (objvDnFuncMapEN.AssociationMappingId == "[null]") objvDnFuncMapEN.AssociationMappingId = null; //关联关系映射Id
if (objvDnFuncMapEN.AssociationMappingName == "[null]") objvDnFuncMapEN.AssociationMappingName = null; //关联关系映射名
if (objvDnFuncMapEN.FuncMapModeId == "[null]") objvDnFuncMapEN.FuncMapModeId = null; //函数映射模式Id
if (objvDnFuncMapEN.FuncMapModeName == "[null]") objvDnFuncMapEN.FuncMapModeName = null; //函数映射模式名
if (objvDnFuncMapEN.DnFunctionId == "[null]") objvDnFuncMapEN.DnFunctionId = null; //DN函数Id
if (objvDnFuncMapEN.UpdDate == "[null]") objvDnFuncMapEN.UpdDate = null; //修改日期
if (objvDnFuncMapEN.UpdUser == "[null]") objvDnFuncMapEN.UpdUser = null; //修改者
if (objvDnFuncMapEN.Memo == "[null]") objvDnFuncMapEN.Memo = null; //说明
if (objvDnFuncMapEN.InDataNodeName == "[null]") objvDnFuncMapEN.InDataNodeName = null; //In数据结点名
if (objvDnFuncMapEN.OutDataNodeName == "[null]") objvDnFuncMapEN.OutDataNodeName = null; //Out数据结点名
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
public static void CheckProperty4Condition(clsvDnFuncMapEN objvDnFuncMapEN)
{
 vDnFuncMapDA.CheckProperty4Condition(objvDnFuncMapEN);
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
if (clsCMProjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectBL没有刷新缓存机制(clsCMProjectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataNodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataNodeBL没有刷新缓存机制(clsDataNodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDnFuncMapBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDnFuncMapBL没有刷新缓存机制(clsDnFuncMapBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAssociationMappingBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAssociationMappingBL没有刷新缓存机制(clsAssociationMappingBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncMapModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncMapModeBL没有刷新缓存机制(clsFuncMapModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDnFunctionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDnFunctionBL没有刷新缓存机制(clsDnFunctionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DnFuncMapId");
//if (arrvDnFuncMapObjLstCache == null)
//{
//arrvDnFuncMapObjLstCache = vDnFuncMapDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDnFuncMapId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDnFuncMapEN GetObjByDnFuncMapIdCache(string strDnFuncMapId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvDnFuncMapEN._CurrTabName, strPrjId);
List<clsvDnFuncMapEN> arrvDnFuncMapObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFuncMapEN> arrvDnFuncMapObjLst_Sel =
arrvDnFuncMapObjLstCache
.Where(x=> x.DnFuncMapId == strDnFuncMapId 
);
if (arrvDnFuncMapObjLst_Sel.Count() == 0)
{
   clsvDnFuncMapEN obj = clsvDnFuncMapBL.GetObjByDnFuncMapId(strDnFuncMapId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strDnFuncMapId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvDnFuncMapObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDnFuncMapEN> GetAllvDnFuncMapObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvDnFuncMapEN> arrvDnFuncMapObjLstCache = GetObjLstCache(strPrjId); 
return arrvDnFuncMapObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDnFuncMapEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvDnFuncMapEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvDnFuncMapEN> arrvDnFuncMapObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvDnFuncMapObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvDnFuncMapEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvDnFuncMapEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvDnFuncMapEN._RefreshTimeLst.Count == 0) return "";
return clsvDnFuncMapEN._RefreshTimeLst[clsvDnFuncMapEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-07-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strDnFuncMapId, string strPrjId)
{
if (strInFldName != convDnFuncMap.DnFuncMapId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convDnFuncMap._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convDnFuncMap._AttributeName));
throw new Exception(strMsg);
}
var objvDnFuncMap = clsvDnFuncMapBL.GetObjByDnFuncMapIdCache(strDnFuncMapId, strPrjId);
if (objvDnFuncMap == null) return "";
return objvDnFuncMap[strOutFldName].ToString();
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
int intRecCount = clsvDnFuncMapDA.GetRecCount(strTabName);
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
int intRecCount = clsvDnFuncMapDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvDnFuncMapDA.GetRecCount();
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
int intRecCount = clsvDnFuncMapDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvDnFuncMapCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvDnFuncMapEN objvDnFuncMapCond)
{
 string strPrjId = objvDnFuncMapCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvDnFuncMapBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvDnFuncMapEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFuncMapEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDnFuncMap._AttributeName)
{
if (objvDnFuncMapCond.IsUpdated(strFldName) == false) continue;
if (objvDnFuncMapCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDnFuncMapCond[strFldName].ToString());
}
else
{
if (objvDnFuncMapCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDnFuncMapCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDnFuncMapCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDnFuncMapCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDnFuncMapCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDnFuncMapCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDnFuncMapCond[strFldName]));
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
 List<string> arrList = clsvDnFuncMapDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vDnFuncMapDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vDnFuncMapDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}