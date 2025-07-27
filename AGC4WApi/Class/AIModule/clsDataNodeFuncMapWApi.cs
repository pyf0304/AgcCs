
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataNodeFuncMapWApi
 表名:DataNodeFuncMap(00050549)
 * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
 日期:2023/01/16 15:44:44
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
public static class clsDataNodeFuncMapWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnFuncMapId">函数映射Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataNodeFuncMapEN SetDnFuncMapId(this clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strDnFuncMapId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnFuncMapId, 8, conDataNodeFuncMap.DnFuncMapId);
clsCheckSql.CheckFieldForeignKey(strDnFuncMapId, 8, conDataNodeFuncMap.DnFuncMapId);
objDataNodeFuncMapEN.DnFuncMapId = strDnFuncMapId; //函数映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(conDataNodeFuncMap.DnFuncMapId) == false)
{
objDataNodeFuncMapEN.dicFldComparisonOp.Add(conDataNodeFuncMap.DnFuncMapId, strComparisonOp);
}
else
{
objDataNodeFuncMapEN.dicFldComparisonOp[conDataNodeFuncMap.DnFuncMapId] = strComparisonOp;
}
}
return objDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strInDataNodeId">In数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataNodeFuncMapEN SetInDataNodeId(this clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strInDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strInDataNodeId, conDataNodeFuncMap.InDataNodeId);
clsCheckSql.CheckFieldLen(strInDataNodeId, 8, conDataNodeFuncMap.InDataNodeId);
clsCheckSql.CheckFieldForeignKey(strInDataNodeId, 8, conDataNodeFuncMap.InDataNodeId);
objDataNodeFuncMapEN.InDataNodeId = strInDataNodeId; //In数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(conDataNodeFuncMap.InDataNodeId) == false)
{
objDataNodeFuncMapEN.dicFldComparisonOp.Add(conDataNodeFuncMap.InDataNodeId, strComparisonOp);
}
else
{
objDataNodeFuncMapEN.dicFldComparisonOp[conDataNodeFuncMap.InDataNodeId] = strComparisonOp;
}
}
return objDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutDataNodeId">Out数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataNodeFuncMapEN SetOutDataNodeId(this clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strOutDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOutDataNodeId, conDataNodeFuncMap.OutDataNodeId);
clsCheckSql.CheckFieldLen(strOutDataNodeId, 8, conDataNodeFuncMap.OutDataNodeId);
clsCheckSql.CheckFieldForeignKey(strOutDataNodeId, 8, conDataNodeFuncMap.OutDataNodeId);
objDataNodeFuncMapEN.OutDataNodeId = strOutDataNodeId; //Out数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(conDataNodeFuncMap.OutDataNodeId) == false)
{
objDataNodeFuncMapEN.dicFldComparisonOp.Add(conDataNodeFuncMap.OutDataNodeId, strComparisonOp);
}
else
{
objDataNodeFuncMapEN.dicFldComparisonOp[conDataNodeFuncMap.OutDataNodeId] = strComparisonOp;
}
}
return objDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strAssociationMappingId">关联关系映射Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataNodeFuncMapEN SetAssociationMappingId(this clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strAssociationMappingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAssociationMappingId, conDataNodeFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldLen(strAssociationMappingId, 2, conDataNodeFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldForeignKey(strAssociationMappingId, 2, conDataNodeFuncMap.AssociationMappingId);
objDataNodeFuncMapEN.AssociationMappingId = strAssociationMappingId; //关联关系映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(conDataNodeFuncMap.AssociationMappingId) == false)
{
objDataNodeFuncMapEN.dicFldComparisonOp.Add(conDataNodeFuncMap.AssociationMappingId, strComparisonOp);
}
else
{
objDataNodeFuncMapEN.dicFldComparisonOp[conDataNodeFuncMap.AssociationMappingId] = strComparisonOp;
}
}
return objDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncMapModeId">函数映射模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataNodeFuncMapEN SetFuncMapModeId(this clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strFuncMapModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncMapModeId, conDataNodeFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldLen(strFuncMapModeId, 2, conDataNodeFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldForeignKey(strFuncMapModeId, 2, conDataNodeFuncMap.FuncMapModeId);
objDataNodeFuncMapEN.FuncMapModeId = strFuncMapModeId; //函数映射模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(conDataNodeFuncMap.FuncMapModeId) == false)
{
objDataNodeFuncMapEN.dicFldComparisonOp.Add(conDataNodeFuncMap.FuncMapModeId, strComparisonOp);
}
else
{
objDataNodeFuncMapEN.dicFldComparisonOp[conDataNodeFuncMap.FuncMapModeId] = strComparisonOp;
}
}
return objDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataNodeFuncMapEN SetTabId(this clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, conDataNodeFuncMap.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conDataNodeFuncMap.TabId);
objDataNodeFuncMapEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(conDataNodeFuncMap.TabId) == false)
{
objDataNodeFuncMapEN.dicFldComparisonOp.Add(conDataNodeFuncMap.TabId, strComparisonOp);
}
else
{
objDataNodeFuncMapEN.dicFldComparisonOp[conDataNodeFuncMap.TabId] = strComparisonOp;
}
}
return objDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnFunctionId">DN函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataNodeFuncMapEN SetDnFunctionId(this clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strDnFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnFunctionId, 8, conDataNodeFuncMap.DnFunctionId);
clsCheckSql.CheckFieldForeignKey(strDnFunctionId, 8, conDataNodeFuncMap.DnFunctionId);
objDataNodeFuncMapEN.DnFunctionId = strDnFunctionId; //DN函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(conDataNodeFuncMap.DnFunctionId) == false)
{
objDataNodeFuncMapEN.dicFldComparisonOp.Add(conDataNodeFuncMap.DnFunctionId, strComparisonOp);
}
else
{
objDataNodeFuncMapEN.dicFldComparisonOp[conDataNodeFuncMap.DnFunctionId] = strComparisonOp;
}
}
return objDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataNodeFuncMapEN SetPrjId(this clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conDataNodeFuncMap.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conDataNodeFuncMap.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conDataNodeFuncMap.PrjId);
objDataNodeFuncMapEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(conDataNodeFuncMap.PrjId) == false)
{
objDataNodeFuncMapEN.dicFldComparisonOp.Add(conDataNodeFuncMap.PrjId, strComparisonOp);
}
else
{
objDataNodeFuncMapEN.dicFldComparisonOp[conDataNodeFuncMap.PrjId] = strComparisonOp;
}
}
return objDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">CM工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataNodeFuncMapEN SetCmPrjId(this clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, conDataNodeFuncMap.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, conDataNodeFuncMap.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, conDataNodeFuncMap.CmPrjId);
objDataNodeFuncMapEN.CmPrjId = strCmPrjId; //CM工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(conDataNodeFuncMap.CmPrjId) == false)
{
objDataNodeFuncMapEN.dicFldComparisonOp.Add(conDataNodeFuncMap.CmPrjId, strComparisonOp);
}
else
{
objDataNodeFuncMapEN.dicFldComparisonOp[conDataNodeFuncMap.CmPrjId] = strComparisonOp;
}
}
return objDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataNodeFuncMapEN SetUpdDate(this clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDataNodeFuncMap.UpdDate);
objDataNodeFuncMapEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(conDataNodeFuncMap.UpdDate) == false)
{
objDataNodeFuncMapEN.dicFldComparisonOp.Add(conDataNodeFuncMap.UpdDate, strComparisonOp);
}
else
{
objDataNodeFuncMapEN.dicFldComparisonOp[conDataNodeFuncMap.UpdDate] = strComparisonOp;
}
}
return objDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataNodeFuncMapEN SetUpdUser(this clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDataNodeFuncMap.UpdUser);
objDataNodeFuncMapEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(conDataNodeFuncMap.UpdUser) == false)
{
objDataNodeFuncMapEN.dicFldComparisonOp.Add(conDataNodeFuncMap.UpdUser, strComparisonOp);
}
else
{
objDataNodeFuncMapEN.dicFldComparisonOp[conDataNodeFuncMap.UpdUser] = strComparisonOp;
}
}
return objDataNodeFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsDataNodeFuncMapEN SetMemo(this clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDataNodeFuncMap.Memo);
objDataNodeFuncMapEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeFuncMapEN.dicFldComparisonOp.ContainsKey(conDataNodeFuncMap.Memo) == false)
{
objDataNodeFuncMapEN.dicFldComparisonOp.Add(conDataNodeFuncMap.Memo, strComparisonOp);
}
else
{
objDataNodeFuncMapEN.dicFldComparisonOp[conDataNodeFuncMap.Memo] = strComparisonOp;
}
}
return objDataNodeFuncMapEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDataNodeFuncMapEN objDataNodeFuncMap_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDataNodeFuncMap_Cond.IsUpdated(conDataNodeFuncMap.DnFuncMapId) == true)
{
string strComparisonOp_DnFuncMapId = objDataNodeFuncMap_Cond.dicFldComparisonOp[conDataNodeFuncMap.DnFuncMapId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeFuncMap.DnFuncMapId, objDataNodeFuncMap_Cond.DnFuncMapId, strComparisonOp_DnFuncMapId);
}
if (objDataNodeFuncMap_Cond.IsUpdated(conDataNodeFuncMap.InDataNodeId) == true)
{
string strComparisonOp_InDataNodeId = objDataNodeFuncMap_Cond.dicFldComparisonOp[conDataNodeFuncMap.InDataNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeFuncMap.InDataNodeId, objDataNodeFuncMap_Cond.InDataNodeId, strComparisonOp_InDataNodeId);
}
if (objDataNodeFuncMap_Cond.IsUpdated(conDataNodeFuncMap.OutDataNodeId) == true)
{
string strComparisonOp_OutDataNodeId = objDataNodeFuncMap_Cond.dicFldComparisonOp[conDataNodeFuncMap.OutDataNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeFuncMap.OutDataNodeId, objDataNodeFuncMap_Cond.OutDataNodeId, strComparisonOp_OutDataNodeId);
}
if (objDataNodeFuncMap_Cond.IsUpdated(conDataNodeFuncMap.AssociationMappingId) == true)
{
string strComparisonOp_AssociationMappingId = objDataNodeFuncMap_Cond.dicFldComparisonOp[conDataNodeFuncMap.AssociationMappingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeFuncMap.AssociationMappingId, objDataNodeFuncMap_Cond.AssociationMappingId, strComparisonOp_AssociationMappingId);
}
if (objDataNodeFuncMap_Cond.IsUpdated(conDataNodeFuncMap.FuncMapModeId) == true)
{
string strComparisonOp_FuncMapModeId = objDataNodeFuncMap_Cond.dicFldComparisonOp[conDataNodeFuncMap.FuncMapModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeFuncMap.FuncMapModeId, objDataNodeFuncMap_Cond.FuncMapModeId, strComparisonOp_FuncMapModeId);
}
if (objDataNodeFuncMap_Cond.IsUpdated(conDataNodeFuncMap.TabId) == true)
{
string strComparisonOp_TabId = objDataNodeFuncMap_Cond.dicFldComparisonOp[conDataNodeFuncMap.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeFuncMap.TabId, objDataNodeFuncMap_Cond.TabId, strComparisonOp_TabId);
}
if (objDataNodeFuncMap_Cond.IsUpdated(conDataNodeFuncMap.DnFunctionId) == true)
{
string strComparisonOp_DnFunctionId = objDataNodeFuncMap_Cond.dicFldComparisonOp[conDataNodeFuncMap.DnFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeFuncMap.DnFunctionId, objDataNodeFuncMap_Cond.DnFunctionId, strComparisonOp_DnFunctionId);
}
if (objDataNodeFuncMap_Cond.IsUpdated(conDataNodeFuncMap.PrjId) == true)
{
string strComparisonOp_PrjId = objDataNodeFuncMap_Cond.dicFldComparisonOp[conDataNodeFuncMap.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeFuncMap.PrjId, objDataNodeFuncMap_Cond.PrjId, strComparisonOp_PrjId);
}
if (objDataNodeFuncMap_Cond.IsUpdated(conDataNodeFuncMap.CmPrjId) == true)
{
string strComparisonOp_CmPrjId = objDataNodeFuncMap_Cond.dicFldComparisonOp[conDataNodeFuncMap.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeFuncMap.CmPrjId, objDataNodeFuncMap_Cond.CmPrjId, strComparisonOp_CmPrjId);
}
if (objDataNodeFuncMap_Cond.IsUpdated(conDataNodeFuncMap.UpdDate) == true)
{
string strComparisonOp_UpdDate = objDataNodeFuncMap_Cond.dicFldComparisonOp[conDataNodeFuncMap.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeFuncMap.UpdDate, objDataNodeFuncMap_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objDataNodeFuncMap_Cond.IsUpdated(conDataNodeFuncMap.UpdUser) == true)
{
string strComparisonOp_UpdUser = objDataNodeFuncMap_Cond.dicFldComparisonOp[conDataNodeFuncMap.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeFuncMap.UpdUser, objDataNodeFuncMap_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objDataNodeFuncMap_Cond.IsUpdated(conDataNodeFuncMap.Memo) == true)
{
string strComparisonOp_Memo = objDataNodeFuncMap_Cond.dicFldComparisonOp[conDataNodeFuncMap.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeFuncMap.Memo, objDataNodeFuncMap_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
 if (string.IsNullOrEmpty(objDataNodeFuncMapEN.DnFuncMapId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDataNodeFuncMapEN.sfUpdFldSetStr = objDataNodeFuncMapEN.getsfUpdFldSetStr();
clsDataNodeFuncMapWApi.CheckPropertyNew(objDataNodeFuncMapEN); 
bool bolResult = clsDataNodeFuncMapWApi.UpdateRecord(objDataNodeFuncMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeFuncMapWApi.ReFreshCache(objDataNodeFuncMapEN.CmPrjId);
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
 /// 检查唯一性(Uniqueness)--DataNodeFuncMap(结点函数映射), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_InDataNodeId_OutDataNodeId_CMPrjId(this clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDataNodeFuncMapEN == null) return "";
if (objDataNodeFuncMapEN.DnFuncMapId == null || objDataNodeFuncMapEN.DnFuncMapId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and InDataNodeId = '{0}'", objDataNodeFuncMapEN.InDataNodeId);
 sbCondition.AppendFormat(" and OutDataNodeId = '{0}'", objDataNodeFuncMapEN.OutDataNodeId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objDataNodeFuncMapEN.CmPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DnFuncMapId !=  '{0}'", objDataNodeFuncMapEN.DnFuncMapId);
 sbCondition.AppendFormat(" and InDataNodeId = '{0}'", objDataNodeFuncMapEN.InDataNodeId);
 sbCondition.AppendFormat(" and OutDataNodeId = '{0}'", objDataNodeFuncMapEN.OutDataNodeId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objDataNodeFuncMapEN.CmPrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDataNodeFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
try
{
 if (string.IsNullOrEmpty(objDataNodeFuncMapEN.DnFuncMapId) == true || clsDataNodeFuncMapWApi.IsExist(objDataNodeFuncMapEN.DnFuncMapId) == true)
 {
     objDataNodeFuncMapEN.DnFuncMapId = clsDataNodeFuncMapWApi.GetMaxStrId();
 }
clsDataNodeFuncMapWApi.CheckPropertyNew(objDataNodeFuncMapEN); 
bool bolResult = clsDataNodeFuncMapWApi.AddNewRecord(objDataNodeFuncMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeFuncMapWApi.ReFreshCache(objDataNodeFuncMapEN.CmPrjId);
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
 /// <param name = "objDataNodeFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
try
{
clsDataNodeFuncMapWApi.CheckPropertyNew(objDataNodeFuncMapEN); 
string strDnFuncMapId = clsDataNodeFuncMapWApi.AddNewRecordWithMaxId(objDataNodeFuncMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeFuncMapWApi.ReFreshCache(objDataNodeFuncMapEN.CmPrjId);
return strDnFuncMapId;
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
 /// <param name = "objDataNodeFuncMapEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strWhereCond)
{
try
{
clsDataNodeFuncMapWApi.CheckPropertyNew(objDataNodeFuncMapEN); 
bool bolResult = clsDataNodeFuncMapWApi.UpdateWithCondition(objDataNodeFuncMapEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeFuncMapWApi.ReFreshCache(objDataNodeFuncMapEN.CmPrjId);
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
 /// 结点函数映射(DataNodeFuncMap)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDataNodeFuncMapWApi
{
private static readonly string mstrApiControllerName = "DataNodeFuncMapApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsDataNodeFuncMapWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
if (!Object.Equals(null, objDataNodeFuncMapEN.DnFuncMapId) && GetStrLen(objDataNodeFuncMapEN.DnFuncMapId) > 8)
{
 throw new Exception("字段[函数映射Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDataNodeFuncMapEN.InDataNodeId) && GetStrLen(objDataNodeFuncMapEN.InDataNodeId) > 8)
{
 throw new Exception("字段[In数据结点Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDataNodeFuncMapEN.OutDataNodeId) && GetStrLen(objDataNodeFuncMapEN.OutDataNodeId) > 8)
{
 throw new Exception("字段[Out数据结点Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDataNodeFuncMapEN.AssociationMappingId) && GetStrLen(objDataNodeFuncMapEN.AssociationMappingId) > 2)
{
 throw new Exception("字段[关联关系映射Id]的长度不能超过2!");
}
if (!Object.Equals(null, objDataNodeFuncMapEN.FuncMapModeId) && GetStrLen(objDataNodeFuncMapEN.FuncMapModeId) > 2)
{
 throw new Exception("字段[函数映射模式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objDataNodeFuncMapEN.TabId) && GetStrLen(objDataNodeFuncMapEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objDataNodeFuncMapEN.DnFunctionId) && GetStrLen(objDataNodeFuncMapEN.DnFunctionId) > 8)
{
 throw new Exception("字段[DN函数Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDataNodeFuncMapEN.PrjId) && GetStrLen(objDataNodeFuncMapEN.PrjId) > 4)
{
 throw new Exception("字段[工程ID]的长度不能超过4!");
}
if (!Object.Equals(null, objDataNodeFuncMapEN.CmPrjId) && GetStrLen(objDataNodeFuncMapEN.CmPrjId) > 6)
{
 throw new Exception("字段[CM工程Id]的长度不能超过6!");
}
if (!Object.Equals(null, objDataNodeFuncMapEN.UpdDate) && GetStrLen(objDataNodeFuncMapEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objDataNodeFuncMapEN.UpdUser) && GetStrLen(objDataNodeFuncMapEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objDataNodeFuncMapEN.Memo) && GetStrLen(objDataNodeFuncMapEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objDataNodeFuncMapEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataNodeFuncMapEN GetObjByDnFuncMapId(string strDnFuncMapId)
{
string strAction = "GetObjByDnFuncMapId";
clsDataNodeFuncMapEN objDataNodeFuncMapEN;
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
objDataNodeFuncMapEN = JsonConvert.DeserializeObject<clsDataNodeFuncMapEN>(strJson);
return objDataNodeFuncMapEN;
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
public static clsDataNodeFuncMapEN GetObjByDnFuncMapId_WA_Cache(string strDnFuncMapId, string strCmPrjId)
{
string strAction = "GetObjByDnFuncMapId_Cache";
clsDataNodeFuncMapEN objDataNodeFuncMapEN;
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
objDataNodeFuncMapEN = JsonConvert.DeserializeObject<clsDataNodeFuncMapEN>(strJson);
return objDataNodeFuncMapEN;
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
public static clsDataNodeFuncMapEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsDataNodeFuncMapEN objDataNodeFuncMapEN;
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
objDataNodeFuncMapEN = JsonConvert.DeserializeObject<clsDataNodeFuncMapEN>(strJson);
return objDataNodeFuncMapEN;
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
public static clsDataNodeFuncMapEN GetObjByDnFuncMapId_Cache(string strDnFuncMapId, string strCmPrjId)
{
if (string.IsNullOrEmpty(strDnFuncMapId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsDataNodeFuncMapEN._CurrTabName, strCmPrjId);
List<clsDataNodeFuncMapEN> arrDataNodeFuncMapObjLst_Cache = GetObjLst_Cache(strCmPrjId);
IEnumerable <clsDataNodeFuncMapEN> arrDataNodeFuncMapObjLst_Sel =
from objDataNodeFuncMapEN in arrDataNodeFuncMapObjLst_Cache
where objDataNodeFuncMapEN.DnFuncMapId == strDnFuncMapId 
select objDataNodeFuncMapEN;
if (arrDataNodeFuncMapObjLst_Sel.Count() == 0)
{
   clsDataNodeFuncMapEN obj = clsDataNodeFuncMapWApi.GetObjByDnFuncMapId(strDnFuncMapId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDataNodeFuncMapObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeFuncMapEN> GetObjLst(string strWhereCond)
{
 List<clsDataNodeFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeFuncMapEN>>(strJson);
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
public static List<clsDataNodeFuncMapEN> GetObjLstByDnFuncMapIdLst(List<string> arrDnFuncMapId)
{
 List<clsDataNodeFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeFuncMapEN>>(strJson);
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
public static IEnumerable<clsDataNodeFuncMapEN> GetObjLstByDnFuncMapIdLst_Cache(List<string> arrDnFuncMapId, string strCmPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsDataNodeFuncMapEN._CurrTabName, strCmPrjId);
List<clsDataNodeFuncMapEN> arrDataNodeFuncMapObjLst_Cache = GetObjLst_Cache(strCmPrjId);
IEnumerable <clsDataNodeFuncMapEN> arrDataNodeFuncMapObjLst_Sel =
from objDataNodeFuncMapEN in arrDataNodeFuncMapObjLst_Cache
where arrDnFuncMapId.Contains(objDataNodeFuncMapEN.DnFuncMapId)
select objDataNodeFuncMapEN;
return arrDataNodeFuncMapObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "arrDnFuncMapId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeFuncMapEN> GetObjLstByDnFuncMapIdLst_WA_Cache(List<string> arrDnFuncMapId, string strCmPrjId)
{
 List<clsDataNodeFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeFuncMapEN>>(strJson);
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
public static List<clsDataNodeFuncMapEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDataNodeFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeFuncMapEN>>(strJson);
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
public static List<clsDataNodeFuncMapEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDataNodeFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeFuncMapEN>>(strJson);
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
public static List<clsDataNodeFuncMapEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDataNodeFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeFuncMapEN>>(strJson);
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
public static List<clsDataNodeFuncMapEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsDataNodeFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeFuncMapEN>>(strJson);
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
public static int DelRecord(string strDnFuncMapId)
{
string strAction = "DelRecord";
try
{
 clsDataNodeFuncMapEN objDataNodeFuncMapEN = clsDataNodeFuncMapWApi.GetObjByDnFuncMapId(strDnFuncMapId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strDnFuncMapId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDataNodeFuncMapWApi.ReFreshCache(objDataNodeFuncMapEN.CmPrjId);
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
public static int DelDataNodeFuncMaps(List<string> arrDnFuncMapId)
{
string strAction = "DelDataNodeFuncMaps";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDnFuncMapId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsDataNodeFuncMapEN objDataNodeFuncMapEN = clsDataNodeFuncMapWApi.GetObjByDnFuncMapId(arrDnFuncMapId[0]);
clsDataNodeFuncMapWApi.ReFreshCache(objDataNodeFuncMapEN.CmPrjId);
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
public static int DelDataNodeFuncMapsByCond(string strWhereCond)
{
string strAction = "DelDataNodeFuncMapsByCond";
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
public static bool AddNewRecord(clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataNodeFuncMapEN>(objDataNodeFuncMapEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeFuncMapWApi.ReFreshCache(objDataNodeFuncMapEN.CmPrjId);
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
public static string AddNewRecordWithMaxId(clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataNodeFuncMapEN>(objDataNodeFuncMapEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeFuncMapWApi.ReFreshCache(objDataNodeFuncMapEN.CmPrjId);
var strDnFuncMapId = (string)jobjReturn0["returnStr"];
return strDnFuncMapId;
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
public static bool UpdateRecord(clsDataNodeFuncMapEN objDataNodeFuncMapEN)
{
if (string.IsNullOrEmpty(objDataNodeFuncMapEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDataNodeFuncMapEN.DnFuncMapId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataNodeFuncMapEN>(objDataNodeFuncMapEN);
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
 /// <param name = "objDataNodeFuncMapEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDataNodeFuncMapEN objDataNodeFuncMapEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDataNodeFuncMapEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDataNodeFuncMapEN.DnFuncMapId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objDataNodeFuncMapEN.DnFuncMapId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataNodeFuncMapEN>(objDataNodeFuncMapEN);
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
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
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
 /// <param name = "objDataNodeFuncMapENS">源对象</param>
 /// <param name = "objDataNodeFuncMapENT">目标对象</param>
 public static void CopyTo(clsDataNodeFuncMapEN objDataNodeFuncMapENS, clsDataNodeFuncMapEN objDataNodeFuncMapENT)
{
try
{
objDataNodeFuncMapENT.DnFuncMapId = objDataNodeFuncMapENS.DnFuncMapId; //函数映射Id
objDataNodeFuncMapENT.InDataNodeId = objDataNodeFuncMapENS.InDataNodeId; //In数据结点Id
objDataNodeFuncMapENT.OutDataNodeId = objDataNodeFuncMapENS.OutDataNodeId; //Out数据结点Id
objDataNodeFuncMapENT.AssociationMappingId = objDataNodeFuncMapENS.AssociationMappingId; //关联关系映射Id
objDataNodeFuncMapENT.FuncMapModeId = objDataNodeFuncMapENS.FuncMapModeId; //函数映射模式Id
objDataNodeFuncMapENT.TabId = objDataNodeFuncMapENS.TabId; //表ID
objDataNodeFuncMapENT.DnFunctionId = objDataNodeFuncMapENS.DnFunctionId; //DN函数Id
objDataNodeFuncMapENT.PrjId = objDataNodeFuncMapENS.PrjId; //工程ID
objDataNodeFuncMapENT.CmPrjId = objDataNodeFuncMapENS.CmPrjId; //CM工程Id
objDataNodeFuncMapENT.UpdDate = objDataNodeFuncMapENS.UpdDate; //修改日期
objDataNodeFuncMapENT.UpdUser = objDataNodeFuncMapENS.UpdUser; //修改者
objDataNodeFuncMapENT.Memo = objDataNodeFuncMapENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsDataNodeFuncMapEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDataNodeFuncMapEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDataNodeFuncMapEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDataNodeFuncMapEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDataNodeFuncMapEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDataNodeFuncMapEN.AttributeName)
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
string strKey = string.Format("{0}_{1}", clsDataNodeFuncMapEN._CurrTabName, strCmPrjId);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCmPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsDataNodeFuncMapWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsDataNodeFuncMapEN._CurrTabName, strCmPrjId);
CacheHelper.Remove(strKey);
clsDataNodeFuncMapWApi.objCommFun4WApi.ReFreshCache(strCmPrjId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataNodeFuncMapEN> GetObjLst_Cache(string strCmPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsDataNodeFuncMapEN._CurrTabName, strCmPrjId);
List<clsDataNodeFuncMapEN> arrDataNodeFuncMapObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CmPrjId='{0}'", strCmPrjId)); });
return arrDataNodeFuncMapObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDataNodeFuncMapEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDataNodeFuncMap.DnFuncMapId, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeFuncMap.InDataNodeId, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeFuncMap.OutDataNodeId, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeFuncMap.AssociationMappingId, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeFuncMap.FuncMapModeId, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeFuncMap.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeFuncMap.DnFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeFuncMap.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeFuncMap.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeFuncMap.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeFuncMap.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeFuncMap.Memo, Type.GetType("System.String"));
foreach (clsDataNodeFuncMapEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDataNodeFuncMap.DnFuncMapId] = objInFor[conDataNodeFuncMap.DnFuncMapId];
objDR[conDataNodeFuncMap.InDataNodeId] = objInFor[conDataNodeFuncMap.InDataNodeId];
objDR[conDataNodeFuncMap.OutDataNodeId] = objInFor[conDataNodeFuncMap.OutDataNodeId];
objDR[conDataNodeFuncMap.AssociationMappingId] = objInFor[conDataNodeFuncMap.AssociationMappingId];
objDR[conDataNodeFuncMap.FuncMapModeId] = objInFor[conDataNodeFuncMap.FuncMapModeId];
objDR[conDataNodeFuncMap.TabId] = objInFor[conDataNodeFuncMap.TabId];
objDR[conDataNodeFuncMap.DnFunctionId] = objInFor[conDataNodeFuncMap.DnFunctionId];
objDR[conDataNodeFuncMap.PrjId] = objInFor[conDataNodeFuncMap.PrjId];
objDR[conDataNodeFuncMap.CmPrjId] = objInFor[conDataNodeFuncMap.CmPrjId];
objDR[conDataNodeFuncMap.UpdDate] = objInFor[conDataNodeFuncMap.UpdDate];
objDR[conDataNodeFuncMap.UpdUser] = objInFor[conDataNodeFuncMap.UpdUser];
objDR[conDataNodeFuncMap.Memo] = objInFor[conDataNodeFuncMap.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 结点函数映射(DataNodeFuncMap)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4DataNodeFuncMap : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCmPrjId)
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
clsDataNodeFuncMapWApi.ReFreshThisCache(strCmPrjId);
}
}

}