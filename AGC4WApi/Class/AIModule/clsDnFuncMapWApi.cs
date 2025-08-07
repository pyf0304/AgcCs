
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnFuncMapWApi
 表名:DnFuncMap(00050549)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:17
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsDnFuncMapWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnFuncMapId">函数映射Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetDnFuncMapId(this clsDnFuncMapEN objDnFuncMapEN, string strDnFuncMapId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnFuncMapId, 8, conDnFuncMap.DnFuncMapId);
clsCheckSql.CheckFieldForeignKey(strDnFuncMapId, 8, conDnFuncMap.DnFuncMapId);
objDnFuncMapEN.DnFuncMapId = strDnFuncMapId; //函数映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.DnFuncMapId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.DnFuncMapId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.DnFuncMapId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "lngInDataNodeId">In数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetInDataNodeId(this clsDnFuncMapEN objDnFuncMapEN, long lngInDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngInDataNodeId, conDnFuncMap.InDataNodeId);
objDnFuncMapEN.InDataNodeId = lngInDataNodeId; //In数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.InDataNodeId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.InDataNodeId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.InDataNodeId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "lngOutDataNodeId">Out数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetOutDataNodeId(this clsDnFuncMapEN objDnFuncMapEN, long lngOutDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngOutDataNodeId, conDnFuncMap.OutDataNodeId);
objDnFuncMapEN.OutDataNodeId = lngOutDataNodeId; //Out数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.OutDataNodeId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.OutDataNodeId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.OutDataNodeId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strAssociationMappingId">关联关系映射Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetAssociationMappingId(this clsDnFuncMapEN objDnFuncMapEN, string strAssociationMappingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAssociationMappingId, conDnFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldLen(strAssociationMappingId, 2, conDnFuncMap.AssociationMappingId);
clsCheckSql.CheckFieldForeignKey(strAssociationMappingId, 2, conDnFuncMap.AssociationMappingId);
objDnFuncMapEN.AssociationMappingId = strAssociationMappingId; //关联关系映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.AssociationMappingId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.AssociationMappingId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.AssociationMappingId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncMapModeId">函数映射模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetFuncMapModeId(this clsDnFuncMapEN objDnFuncMapEN, string strFuncMapModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncMapModeId, conDnFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldLen(strFuncMapModeId, 2, conDnFuncMap.FuncMapModeId);
clsCheckSql.CheckFieldForeignKey(strFuncMapModeId, 2, conDnFuncMap.FuncMapModeId);
objDnFuncMapEN.FuncMapModeId = strFuncMapModeId; //函数映射模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.FuncMapModeId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.FuncMapModeId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.FuncMapModeId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetTabId(this clsDnFuncMapEN objDnFuncMapEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabId, 8, conDnFuncMap.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conDnFuncMap.TabId);
objDnFuncMapEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.TabId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.TabId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.TabId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnFunctionId">DN函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetDnFunctionId(this clsDnFuncMapEN objDnFuncMapEN, string strDnFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnFunctionId, 8, conDnFuncMap.DnFunctionId);
clsCheckSql.CheckFieldForeignKey(strDnFunctionId, 8, conDnFuncMap.DnFunctionId);
objDnFuncMapEN.DnFunctionId = strDnFunctionId; //DN函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.DnFunctionId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.DnFunctionId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.DnFunctionId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetErrMsg(this clsDnFuncMapEN objDnFuncMapEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conDnFuncMap.ErrMsg);
objDnFuncMapEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.ErrMsg) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.ErrMsg, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.ErrMsg] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetPrjId(this clsDnFuncMapEN objDnFuncMapEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conDnFuncMap.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conDnFuncMap.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conDnFuncMap.PrjId);
objDnFuncMapEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.PrjId) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.PrjId, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.PrjId] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "intUsedTimes">使用次数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetUsedTimes(this clsDnFuncMapEN objDnFuncMapEN, int intUsedTimes, string strComparisonOp="")
	{
objDnFuncMapEN.UsedTimes = intUsedTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.UsedTimes) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.UsedTimes, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.UsedTimes] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetUpdDate(this clsDnFuncMapEN objDnFuncMapEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDnFuncMap.UpdDate);
objDnFuncMapEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.UpdDate) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.UpdDate, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.UpdDate] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetUpdUser(this clsDnFuncMapEN objDnFuncMapEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDnFuncMap.UpdUser);
objDnFuncMapEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.UpdUser) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.UpdUser, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.UpdUser] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFuncMapEN SetMemo(this clsDnFuncMapEN objDnFuncMapEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDnFuncMap.Memo);
objDnFuncMapEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFuncMapEN.dicFldComparisonOp.ContainsKey(conDnFuncMap.Memo) == false)
{
objDnFuncMapEN.dicFldComparisonOp.Add(conDnFuncMap.Memo, strComparisonOp);
}
else
{
objDnFuncMapEN.dicFldComparisonOp[conDnFuncMap.Memo] = strComparisonOp;
}
}
return objDnFuncMapEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDnFuncMapEN objDnFuncMapCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.DnFuncMapId) == true)
{
string strComparisonOpDnFuncMapId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.DnFuncMapId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.DnFuncMapId, objDnFuncMapCond.DnFuncMapId, strComparisonOpDnFuncMapId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.InDataNodeId) == true)
{
string strComparisonOpInDataNodeId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.InDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDnFuncMap.InDataNodeId, objDnFuncMapCond.InDataNodeId, strComparisonOpInDataNodeId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.OutDataNodeId) == true)
{
string strComparisonOpOutDataNodeId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.OutDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDnFuncMap.OutDataNodeId, objDnFuncMapCond.OutDataNodeId, strComparisonOpOutDataNodeId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.AssociationMappingId) == true)
{
string strComparisonOpAssociationMappingId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.AssociationMappingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.AssociationMappingId, objDnFuncMapCond.AssociationMappingId, strComparisonOpAssociationMappingId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.FuncMapModeId) == true)
{
string strComparisonOpFuncMapModeId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.FuncMapModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.FuncMapModeId, objDnFuncMapCond.FuncMapModeId, strComparisonOpFuncMapModeId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.TabId) == true)
{
string strComparisonOpTabId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.TabId, objDnFuncMapCond.TabId, strComparisonOpTabId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.DnFunctionId) == true)
{
string strComparisonOpDnFunctionId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.DnFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.DnFunctionId, objDnFuncMapCond.DnFunctionId, strComparisonOpDnFunctionId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.ErrMsg) == true)
{
string strComparisonOpErrMsg = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.ErrMsg, objDnFuncMapCond.ErrMsg, strComparisonOpErrMsg);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.PrjId) == true)
{
string strComparisonOpPrjId = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.PrjId, objDnFuncMapCond.PrjId, strComparisonOpPrjId);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.UsedTimes) == true)
{
string strComparisonOpUsedTimes = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.UsedTimes];
strWhereCond += string.Format(" And {0} {2} {1}", conDnFuncMap.UsedTimes, objDnFuncMapCond.UsedTimes, strComparisonOpUsedTimes);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.UpdDate) == true)
{
string strComparisonOpUpdDate = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.UpdDate, objDnFuncMapCond.UpdDate, strComparisonOpUpdDate);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.UpdUser) == true)
{
string strComparisonOpUpdUser = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.UpdUser, objDnFuncMapCond.UpdUser, strComparisonOpUpdUser);
}
if (objDnFuncMapCond.IsUpdated(conDnFuncMap.Memo) == true)
{
string strComparisonOpMemo = objDnFuncMapCond.dicFldComparisonOp[conDnFuncMap.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFuncMap.Memo, objDnFuncMapCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDnFuncMapEN objDnFuncMapEN)
{
 if (string.IsNullOrEmpty(objDnFuncMapEN.DnFuncMapId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDnFuncMapEN.sfUpdFldSetStr = objDnFuncMapEN.getsfUpdFldSetStr();
clsDnFuncMapWApi.CheckPropertyNew(objDnFuncMapEN); 
bool bolResult = clsDnFuncMapWApi.UpdateRecord(objDnFuncMapEN);
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
 /// 获取唯一性条件串--DnFuncMap(结点函数映射), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:InDataNodeId_OutDataNodeId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDnFuncMapEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsDnFuncMapEN objDnFuncMapEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDnFuncMapEN == null) return "";
if (objDnFuncMapEN.DnFuncMapId == null || objDnFuncMapEN.DnFuncMapId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and InDataNodeId = '{0}'", objDnFuncMapEN.InDataNodeId);
 sbCondition.AppendFormat(" and OutDataNodeId = '{0}'", objDnFuncMapEN.OutDataNodeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DnFuncMapId !=  '{0}'", objDnFuncMapEN.DnFuncMapId);
 sbCondition.AppendFormat(" and InDataNodeId = '{0}'", objDnFuncMapEN.InDataNodeId);
 sbCondition.AppendFormat(" and OutDataNodeId = '{0}'", objDnFuncMapEN.OutDataNodeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDnFuncMapEN objDnFuncMapEN)
{
try
{
 if (string.IsNullOrEmpty(objDnFuncMapEN.DnFuncMapId) == true || clsDnFuncMapWApi.IsExist(objDnFuncMapEN.DnFuncMapId) == true)
 {
     objDnFuncMapEN.DnFuncMapId = clsDnFuncMapWApi.GetMaxStrId();
 }
clsDnFuncMapWApi.CheckPropertyNew(objDnFuncMapEN); 
bool bolResult = clsDnFuncMapWApi.AddNewRecord(objDnFuncMapEN);
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
 /// <param name = "objDnFuncMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDnFuncMapEN objDnFuncMapEN)
{
try
{
clsDnFuncMapWApi.CheckPropertyNew(objDnFuncMapEN); 
string strDnFuncMapId = clsDnFuncMapWApi.AddNewRecordWithMaxId(objDnFuncMapEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objDnFuncMapEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDnFuncMapEN objDnFuncMapEN, string strWhereCond)
{
try
{
clsDnFuncMapWApi.CheckPropertyNew(objDnFuncMapEN); 
bool bolResult = clsDnFuncMapWApi.UpdateWithCondition(objDnFuncMapEN, strWhereCond);
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
 /// 结点函数映射(DnFuncMap)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDnFuncMapWApi
{
private static readonly string mstrApiControllerName = "DnFuncMapApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsDnFuncMapWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDnFuncMapEN objDnFuncMapEN)
{
if (!Object.Equals(null, objDnFuncMapEN.DnFuncMapId) && GetStrLen(objDnFuncMapEN.DnFuncMapId) > 8)
{
 throw new Exception("字段[函数映射Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDnFuncMapEN.AssociationMappingId) && GetStrLen(objDnFuncMapEN.AssociationMappingId) > 2)
{
 throw new Exception("字段[关联关系映射Id]的长度不能超过2!");
}
if (!Object.Equals(null, objDnFuncMapEN.FuncMapModeId) && GetStrLen(objDnFuncMapEN.FuncMapModeId) > 2)
{
 throw new Exception("字段[函数映射模式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objDnFuncMapEN.TabId) && GetStrLen(objDnFuncMapEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objDnFuncMapEN.DnFunctionId) && GetStrLen(objDnFuncMapEN.DnFunctionId) > 8)
{
 throw new Exception("字段[DN函数Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDnFuncMapEN.ErrMsg) && GetStrLen(objDnFuncMapEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objDnFuncMapEN.PrjId) && GetStrLen(objDnFuncMapEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objDnFuncMapEN.UpdDate) && GetStrLen(objDnFuncMapEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objDnFuncMapEN.UpdUser) && GetStrLen(objDnFuncMapEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objDnFuncMapEN.Memo) && GetStrLen(objDnFuncMapEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objDnFuncMapEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDnFuncMapEN GetObjByDnFuncMapId(string strDnFuncMapId)
{
if (strDnFuncMapId == "") return null;
string strAction = "GetObjByDnFuncMapId";
clsDnFuncMapEN objDnFuncMapEN;
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
objDnFuncMapEN = JsonConvert.DeserializeObject<clsDnFuncMapEN>(strJson);
return objDnFuncMapEN;
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
public static clsDnFuncMapEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsDnFuncMapEN objDnFuncMapEN;
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
objDnFuncMapEN = JsonConvert.DeserializeObject<clsDnFuncMapEN>(strJson);
return objDnFuncMapEN;
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
public static List<clsDnFuncMapEN> GetObjLst(string strWhereCond)
{
 List<clsDnFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnFuncMapEN>>(strJson);
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
public static List<clsDnFuncMapEN> GetObjLstByDnFuncMapIdLst(List<string> arrDnFuncMapId)
{
 List<clsDnFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnFuncMapEN>>(strJson);
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
public static List<clsDnFuncMapEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDnFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnFuncMapEN>>(strJson);
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
public static List<clsDnFuncMapEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDnFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnFuncMapEN>>(strJson);
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
public static List<clsDnFuncMapEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDnFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnFuncMapEN>>(strJson);
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
public static List<clsDnFuncMapEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsDnFuncMapEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnFuncMapEN>>(strJson);
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
 clsDnFuncMapEN objDnFuncMapEN = clsDnFuncMapWApi.GetObjByDnFuncMapId(strDnFuncMapId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strDnFuncMapId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelDnFuncMaps(List<string> arrDnFuncMapId)
{
string strAction = "DelDnFuncMaps";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDnFuncMapId);
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
public static int DelDnFuncMapsByCond(string strWhereCond)
{
string strAction = "DelDnFuncMapsByCond";
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
public static bool AddNewRecord(clsDnFuncMapEN objDnFuncMapEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnFuncMapEN>(objDnFuncMapEN);
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
public static string AddNewRecordWithMaxId(clsDnFuncMapEN objDnFuncMapEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnFuncMapEN>(objDnFuncMapEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
public static bool UpdateRecord(clsDnFuncMapEN objDnFuncMapEN)
{
if (string.IsNullOrEmpty(objDnFuncMapEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDnFuncMapEN.DnFuncMapId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnFuncMapEN>(objDnFuncMapEN);
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
 /// <param name = "objDnFuncMapEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDnFuncMapEN objDnFuncMapEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDnFuncMapEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDnFuncMapEN.DnFuncMapId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDnFuncMapEN.DnFuncMapId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnFuncMapEN>(objDnFuncMapEN);
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
 /// <param name = "objDnFuncMapENS">源对象</param>
 /// <param name = "objDnFuncMapENT">目标对象</param>
 public static void CopyTo(clsDnFuncMapEN objDnFuncMapENS, clsDnFuncMapEN objDnFuncMapENT)
{
try
{
objDnFuncMapENT.DnFuncMapId = objDnFuncMapENS.DnFuncMapId; //函数映射Id
objDnFuncMapENT.InDataNodeId = objDnFuncMapENS.InDataNodeId; //In数据结点Id
objDnFuncMapENT.OutDataNodeId = objDnFuncMapENS.OutDataNodeId; //Out数据结点Id
objDnFuncMapENT.AssociationMappingId = objDnFuncMapENS.AssociationMappingId; //关联关系映射Id
objDnFuncMapENT.FuncMapModeId = objDnFuncMapENS.FuncMapModeId; //函数映射模式Id
objDnFuncMapENT.TabId = objDnFuncMapENS.TabId; //表ID
objDnFuncMapENT.DnFunctionId = objDnFuncMapENS.DnFunctionId; //DN函数Id
objDnFuncMapENT.ErrMsg = objDnFuncMapENS.ErrMsg; //错误信息
objDnFuncMapENT.PrjId = objDnFuncMapENS.PrjId; //工程Id
objDnFuncMapENT.UsedTimes = objDnFuncMapENS.UsedTimes; //使用次数
objDnFuncMapENT.UpdDate = objDnFuncMapENS.UpdDate; //修改日期
objDnFuncMapENT.UpdUser = objDnFuncMapENS.UpdUser; //修改者
objDnFuncMapENT.Memo = objDnFuncMapENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsDnFuncMapEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDnFuncMapEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDnFuncMapEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDnFuncMapEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDnFuncMapEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDnFuncMapEN._AttributeName)
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
public static void ReFreshThisCache()
{

string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsDnFuncMapEN._CurrTabName);
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
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsDnFuncMapWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDnFuncMapEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDnFuncMapWApi.objCommFun4WApi.ReFreshCache();
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
public static DataTable GetDataTableByObjLst(List<clsDnFuncMapEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDnFuncMap.DnFuncMapId, Type.GetType("System.String"));
objDT.Columns.Add(conDnFuncMap.InDataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(conDnFuncMap.OutDataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(conDnFuncMap.AssociationMappingId, Type.GetType("System.String"));
objDT.Columns.Add(conDnFuncMap.FuncMapModeId, Type.GetType("System.String"));
objDT.Columns.Add(conDnFuncMap.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conDnFuncMap.DnFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(conDnFuncMap.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conDnFuncMap.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conDnFuncMap.UsedTimes, Type.GetType("System.Int32"));
objDT.Columns.Add(conDnFuncMap.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conDnFuncMap.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conDnFuncMap.Memo, Type.GetType("System.String"));
foreach (clsDnFuncMapEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDnFuncMap.DnFuncMapId] = objInFor[conDnFuncMap.DnFuncMapId];
objDR[conDnFuncMap.InDataNodeId] = objInFor[conDnFuncMap.InDataNodeId];
objDR[conDnFuncMap.OutDataNodeId] = objInFor[conDnFuncMap.OutDataNodeId];
objDR[conDnFuncMap.AssociationMappingId] = objInFor[conDnFuncMap.AssociationMappingId];
objDR[conDnFuncMap.FuncMapModeId] = objInFor[conDnFuncMap.FuncMapModeId];
objDR[conDnFuncMap.TabId] = objInFor[conDnFuncMap.TabId];
objDR[conDnFuncMap.DnFunctionId] = objInFor[conDnFuncMap.DnFunctionId];
objDR[conDnFuncMap.ErrMsg] = objInFor[conDnFuncMap.ErrMsg];
objDR[conDnFuncMap.PrjId] = objInFor[conDnFuncMap.PrjId];
objDR[conDnFuncMap.UsedTimes] = objInFor[conDnFuncMap.UsedTimes];
objDR[conDnFuncMap.UpdDate] = objInFor[conDnFuncMap.UpdDate];
objDR[conDnFuncMap.UpdUser] = objInFor[conDnFuncMap.UpdUser];
objDR[conDnFuncMap.Memo] = objInFor[conDnFuncMap.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 结点函数映射(DnFuncMap)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4DnFuncMap : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
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
clsDnFuncMapWApi.ReFreshThisCache();
}
}

}