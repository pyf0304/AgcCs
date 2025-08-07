
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnFuncMap_SimBL
 表名:vDnFuncMap_Sim(00050625)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:27:32
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
public static class  clsvDnFuncMap_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDnFuncMap_SimEN GetObj(this K_DnFuncMapId_vDnFuncMap_Sim myKey)
{
clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = clsvDnFuncMap_SimBL.vDnFuncMap_SimDA.GetObjByDnFuncMapId(myKey.Value);
return objvDnFuncMap_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetDnFuncMapId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, string strDnFuncMapId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDnFuncMapId, 8, convDnFuncMap_Sim.DnFuncMapId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDnFuncMapId, 8, convDnFuncMap_Sim.DnFuncMapId);
}
objvDnFuncMap_SimEN.DnFuncMapId = strDnFuncMapId; //函数映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.DnFuncMapId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.DnFuncMapId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.DnFuncMapId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetInDataNodeId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, long? lngInDataNodeId, string strComparisonOp="")
	{
objvDnFuncMap_SimEN.InDataNodeId = lngInDataNodeId; //In数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.InDataNodeId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.InDataNodeId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.InDataNodeId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetOutDataNodeId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, long? lngOutDataNodeId, string strComparisonOp="")
	{
objvDnFuncMap_SimEN.OutDataNodeId = lngOutDataNodeId; //Out数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.OutDataNodeId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.OutDataNodeId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.OutDataNodeId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetAssociationMappingId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, string strAssociationMappingId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAssociationMappingId, 2, convDnFuncMap_Sim.AssociationMappingId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAssociationMappingId, 2, convDnFuncMap_Sim.AssociationMappingId);
}
objvDnFuncMap_SimEN.AssociationMappingId = strAssociationMappingId; //关联关系映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.AssociationMappingId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.AssociationMappingId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.AssociationMappingId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetFuncMapModeId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, string strFuncMapModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncMapModeId, 2, convDnFuncMap_Sim.FuncMapModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncMapModeId, 2, convDnFuncMap_Sim.FuncMapModeId);
}
objvDnFuncMap_SimEN.FuncMapModeId = strFuncMapModeId; //函数映射模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.FuncMapModeId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.FuncMapModeId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.FuncMapModeId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetTabId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convDnFuncMap_Sim.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convDnFuncMap_Sim.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convDnFuncMap_Sim.TabId);
}
objvDnFuncMap_SimEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.TabId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.TabId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.TabId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetDnFunctionId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, string strDnFunctionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDnFunctionId, 8, convDnFuncMap_Sim.DnFunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDnFunctionId, 8, convDnFuncMap_Sim.DnFunctionId);
}
objvDnFuncMap_SimEN.DnFunctionId = strDnFunctionId; //DN函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.DnFunctionId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.DnFunctionId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.DnFunctionId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetPrjId(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convDnFuncMap_Sim.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convDnFuncMap_Sim.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDnFuncMap_Sim.PrjId);
}
objvDnFuncMap_SimEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.PrjId) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.PrjId, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.PrjId] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFuncMap_SimEN SetUsedTimes(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN, int? intUsedTimes, string strComparisonOp="")
	{
objvDnFuncMap_SimEN.UsedTimes = intUsedTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFuncMap_SimEN.dicFldComparisonOp.ContainsKey(convDnFuncMap_Sim.UsedTimes) == false)
{
objvDnFuncMap_SimEN.dicFldComparisonOp.Add(convDnFuncMap_Sim.UsedTimes, strComparisonOp);
}
else
{
objvDnFuncMap_SimEN.dicFldComparisonOp[convDnFuncMap_Sim.UsedTimes] = strComparisonOp;
}
}
return objvDnFuncMap_SimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimENS">源对象</param>
 /// <param name = "objvDnFuncMap_SimENT">目标对象</param>
 public static void CopyTo(this clsvDnFuncMap_SimEN objvDnFuncMap_SimENS, clsvDnFuncMap_SimEN objvDnFuncMap_SimENT)
{
try
{
objvDnFuncMap_SimENT.DnFuncMapId = objvDnFuncMap_SimENS.DnFuncMapId; //函数映射Id
objvDnFuncMap_SimENT.InDataNodeId = objvDnFuncMap_SimENS.InDataNodeId; //In数据结点Id
objvDnFuncMap_SimENT.OutDataNodeId = objvDnFuncMap_SimENS.OutDataNodeId; //Out数据结点Id
objvDnFuncMap_SimENT.AssociationMappingId = objvDnFuncMap_SimENS.AssociationMappingId; //关联关系映射Id
objvDnFuncMap_SimENT.FuncMapModeId = objvDnFuncMap_SimENS.FuncMapModeId; //函数映射模式Id
objvDnFuncMap_SimENT.TabId = objvDnFuncMap_SimENS.TabId; //表ID
objvDnFuncMap_SimENT.DnFunctionId = objvDnFuncMap_SimENS.DnFunctionId; //DN函数Id
objvDnFuncMap_SimENT.PrjId = objvDnFuncMap_SimENS.PrjId; //工程Id
objvDnFuncMap_SimENT.UsedTimes = objvDnFuncMap_SimENS.UsedTimes; //使用次数
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
 /// <param name = "objvDnFuncMap_SimENS">源对象</param>
 /// <returns>目标对象=>clsvDnFuncMap_SimEN:objvDnFuncMap_SimENT</returns>
 public static clsvDnFuncMap_SimEN CopyTo(this clsvDnFuncMap_SimEN objvDnFuncMap_SimENS)
{
try
{
 clsvDnFuncMap_SimEN objvDnFuncMap_SimENT = new clsvDnFuncMap_SimEN()
{
DnFuncMapId = objvDnFuncMap_SimENS.DnFuncMapId, //函数映射Id
InDataNodeId = objvDnFuncMap_SimENS.InDataNodeId, //In数据结点Id
OutDataNodeId = objvDnFuncMap_SimENS.OutDataNodeId, //Out数据结点Id
AssociationMappingId = objvDnFuncMap_SimENS.AssociationMappingId, //关联关系映射Id
FuncMapModeId = objvDnFuncMap_SimENS.FuncMapModeId, //函数映射模式Id
TabId = objvDnFuncMap_SimENS.TabId, //表ID
DnFunctionId = objvDnFuncMap_SimENS.DnFunctionId, //DN函数Id
PrjId = objvDnFuncMap_SimENS.PrjId, //工程Id
UsedTimes = objvDnFuncMap_SimENS.UsedTimes, //使用次数
};
 return objvDnFuncMap_SimENT;
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
public static void CheckProperty4Condition(this clsvDnFuncMap_SimEN objvDnFuncMap_SimEN)
{
 clsvDnFuncMap_SimBL.vDnFuncMap_SimDA.CheckProperty4Condition(objvDnFuncMap_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDnFuncMap_SimEN objvDnFuncMap_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.DnFuncMapId) == true)
{
string strComparisonOpDnFuncMapId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.DnFuncMapId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap_Sim.DnFuncMapId, objvDnFuncMap_SimCond.DnFuncMapId, strComparisonOpDnFuncMapId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.InDataNodeId) == true)
{
string strComparisonOpInDataNodeId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.InDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", convDnFuncMap_Sim.InDataNodeId, objvDnFuncMap_SimCond.InDataNodeId, strComparisonOpInDataNodeId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.OutDataNodeId) == true)
{
string strComparisonOpOutDataNodeId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.OutDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", convDnFuncMap_Sim.OutDataNodeId, objvDnFuncMap_SimCond.OutDataNodeId, strComparisonOpOutDataNodeId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.AssociationMappingId) == true)
{
string strComparisonOpAssociationMappingId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.AssociationMappingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap_Sim.AssociationMappingId, objvDnFuncMap_SimCond.AssociationMappingId, strComparisonOpAssociationMappingId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.FuncMapModeId) == true)
{
string strComparisonOpFuncMapModeId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.FuncMapModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap_Sim.FuncMapModeId, objvDnFuncMap_SimCond.FuncMapModeId, strComparisonOpFuncMapModeId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.TabId) == true)
{
string strComparisonOpTabId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap_Sim.TabId, objvDnFuncMap_SimCond.TabId, strComparisonOpTabId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.DnFunctionId) == true)
{
string strComparisonOpDnFunctionId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.DnFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap_Sim.DnFunctionId, objvDnFuncMap_SimCond.DnFunctionId, strComparisonOpDnFunctionId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.PrjId) == true)
{
string strComparisonOpPrjId = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFuncMap_Sim.PrjId, objvDnFuncMap_SimCond.PrjId, strComparisonOpPrjId);
}
if (objvDnFuncMap_SimCond.IsUpdated(convDnFuncMap_Sim.UsedTimes) == true)
{
string strComparisonOpUsedTimes = objvDnFuncMap_SimCond.dicFldComparisonOp[convDnFuncMap_Sim.UsedTimes];
strWhereCond += string.Format(" And {0} {2} {1}", convDnFuncMap_Sim.UsedTimes, objvDnFuncMap_SimCond.UsedTimes, strComparisonOpUsedTimes);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vDnFuncMap_Sim
{
public virtual bool UpdRelaTabDate(string strDnFuncMapId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v结点函数映射_Sim(vDnFuncMap_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvDnFuncMap_SimBL
{
public static RelatedActions_vDnFuncMap_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvDnFuncMap_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvDnFuncMap_SimDA vDnFuncMap_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvDnFuncMap_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvDnFuncMap_SimBL()
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
if (string.IsNullOrEmpty(clsvDnFuncMap_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDnFuncMap_SimEN._ConnectString);
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
public static DataTable GetDataTable_vDnFuncMap_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vDnFuncMap_SimDA.GetDataTable_vDnFuncMap_Sim(strWhereCond);
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
objDT = vDnFuncMap_SimDA.GetDataTable(strWhereCond);
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
objDT = vDnFuncMap_SimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vDnFuncMap_SimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vDnFuncMap_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vDnFuncMap_SimDA.GetDataTable_Top(objTopPara);
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
objDT = vDnFuncMap_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vDnFuncMap_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vDnFuncMap_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvDnFuncMap_SimEN> GetObjLstByDnFuncMapIdLst(List<string> arrDnFuncMapIdLst)
{
List<clsvDnFuncMap_SimEN> arrObjLst = new List<clsvDnFuncMap_SimEN>(); 
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
	clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN();
try
{
objvDnFuncMap_SimEN.DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMap_SimEN.InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMap_SimEN.OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMap_SimEN.AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMap_SimEN.FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMap_SimEN.TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID
objvDnFuncMap_SimEN.DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMap_SimEN.PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id
objvDnFuncMap_SimEN.UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMap_SimEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMap_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDnFuncMapIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvDnFuncMap_SimEN> GetObjLstByDnFuncMapIdLstCache(List<string> arrDnFuncMapIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvDnFuncMap_SimEN._CurrTabName, strPrjId);
List<clsvDnFuncMap_SimEN> arrvDnFuncMap_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFuncMap_SimEN> arrvDnFuncMap_SimObjLst_Sel =
arrvDnFuncMap_SimObjLstCache
.Where(x => arrDnFuncMapIdLst.Contains(x.DnFuncMapId));
return arrvDnFuncMap_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFuncMap_SimEN> GetObjLst(string strWhereCond)
{
List<clsvDnFuncMap_SimEN> arrObjLst = new List<clsvDnFuncMap_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN();
try
{
objvDnFuncMap_SimEN.DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMap_SimEN.InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMap_SimEN.OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMap_SimEN.AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMap_SimEN.FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMap_SimEN.TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID
objvDnFuncMap_SimEN.DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMap_SimEN.PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id
objvDnFuncMap_SimEN.UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMap_SimEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMap_SimEN);
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
public static List<clsvDnFuncMap_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvDnFuncMap_SimEN> arrObjLst = new List<clsvDnFuncMap_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN();
try
{
objvDnFuncMap_SimEN.DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMap_SimEN.InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMap_SimEN.OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMap_SimEN.AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMap_SimEN.FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMap_SimEN.TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID
objvDnFuncMap_SimEN.DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMap_SimEN.PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id
objvDnFuncMap_SimEN.UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMap_SimEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMap_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvDnFuncMap_SimEN> GetSubObjLstCache(clsvDnFuncMap_SimEN objvDnFuncMap_SimCond, string strPrjId)
{
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvDnFuncMap_SimBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvDnFuncMap_SimEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFuncMap_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDnFuncMap_Sim._AttributeName)
{
if (objvDnFuncMap_SimCond.IsUpdated(strFldName) == false) continue;
if (objvDnFuncMap_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDnFuncMap_SimCond[strFldName].ToString());
}
else
{
if (objvDnFuncMap_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDnFuncMap_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDnFuncMap_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDnFuncMap_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDnFuncMap_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDnFuncMap_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDnFuncMap_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDnFuncMap_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDnFuncMap_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDnFuncMap_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDnFuncMap_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDnFuncMap_SimCond[strFldName]));
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
public static List<clsvDnFuncMap_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvDnFuncMap_SimEN> arrObjLst = new List<clsvDnFuncMap_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN();
try
{
objvDnFuncMap_SimEN.DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMap_SimEN.InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMap_SimEN.OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMap_SimEN.AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMap_SimEN.FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMap_SimEN.TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID
objvDnFuncMap_SimEN.DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMap_SimEN.PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id
objvDnFuncMap_SimEN.UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMap_SimEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMap_SimEN);
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
public static List<clsvDnFuncMap_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvDnFuncMap_SimEN> arrObjLst = new List<clsvDnFuncMap_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN();
try
{
objvDnFuncMap_SimEN.DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMap_SimEN.InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMap_SimEN.OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMap_SimEN.AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMap_SimEN.FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMap_SimEN.TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID
objvDnFuncMap_SimEN.DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMap_SimEN.PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id
objvDnFuncMap_SimEN.UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMap_SimEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMap_SimEN);
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
List<clsvDnFuncMap_SimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvDnFuncMap_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFuncMap_SimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvDnFuncMap_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvDnFuncMap_SimEN> arrObjLst = new List<clsvDnFuncMap_SimEN>(); 
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
	clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN();
try
{
objvDnFuncMap_SimEN.DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMap_SimEN.InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMap_SimEN.OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMap_SimEN.AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMap_SimEN.FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMap_SimEN.TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID
objvDnFuncMap_SimEN.DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMap_SimEN.PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id
objvDnFuncMap_SimEN.UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMap_SimEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMap_SimEN);
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
public static List<clsvDnFuncMap_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvDnFuncMap_SimEN> arrObjLst = new List<clsvDnFuncMap_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN();
try
{
objvDnFuncMap_SimEN.DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMap_SimEN.InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMap_SimEN.OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMap_SimEN.AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMap_SimEN.FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMap_SimEN.TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID
objvDnFuncMap_SimEN.DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMap_SimEN.PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id
objvDnFuncMap_SimEN.UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMap_SimEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMap_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvDnFuncMap_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvDnFuncMap_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvDnFuncMap_SimEN> arrObjLst = new List<clsvDnFuncMap_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN();
try
{
objvDnFuncMap_SimEN.DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMap_SimEN.InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMap_SimEN.OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMap_SimEN.AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMap_SimEN.FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMap_SimEN.TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID
objvDnFuncMap_SimEN.DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMap_SimEN.PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id
objvDnFuncMap_SimEN.UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMap_SimEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMap_SimEN);
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
public static List<clsvDnFuncMap_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvDnFuncMap_SimEN> arrObjLst = new List<clsvDnFuncMap_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN();
try
{
objvDnFuncMap_SimEN.DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMap_SimEN.InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMap_SimEN.OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMap_SimEN.AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMap_SimEN.FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMap_SimEN.TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID
objvDnFuncMap_SimEN.DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMap_SimEN.PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id
objvDnFuncMap_SimEN.UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMap_SimEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMap_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFuncMap_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvDnFuncMap_SimEN> arrObjLst = new List<clsvDnFuncMap_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN();
try
{
objvDnFuncMap_SimEN.DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMap_SimEN.InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMap_SimEN.OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMap_SimEN.AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMap_SimEN.FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMap_SimEN.TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID
objvDnFuncMap_SimEN.DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMap_SimEN.PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id
objvDnFuncMap_SimEN.UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFuncMap_SimEN.DnFuncMapId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFuncMap_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvDnFuncMap_Sim(ref clsvDnFuncMap_SimEN objvDnFuncMap_SimEN)
{
bool bolResult = vDnFuncMap_SimDA.GetvDnFuncMap_Sim(ref objvDnFuncMap_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDnFuncMap_SimEN GetObjByDnFuncMapId(string strDnFuncMapId)
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
clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = vDnFuncMap_SimDA.GetObjByDnFuncMapId(strDnFuncMapId);
return objvDnFuncMap_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvDnFuncMap_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = vDnFuncMap_SimDA.GetFirstObj(strWhereCond);
 return objvDnFuncMap_SimEN;
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
public static clsvDnFuncMap_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = vDnFuncMap_SimDA.GetObjByDataRow(objRow);
 return objvDnFuncMap_SimEN;
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
public static clsvDnFuncMap_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = vDnFuncMap_SimDA.GetObjByDataRow(objRow);
 return objvDnFuncMap_SimEN;
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
 /// <param name = "lstvDnFuncMap_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDnFuncMap_SimEN GetObjByDnFuncMapIdFromList(string strDnFuncMapId, List<clsvDnFuncMap_SimEN> lstvDnFuncMap_SimObjLst)
{
foreach (clsvDnFuncMap_SimEN objvDnFuncMap_SimEN in lstvDnFuncMap_SimObjLst)
{
if (objvDnFuncMap_SimEN.DnFuncMapId == strDnFuncMapId)
{
return objvDnFuncMap_SimEN;
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
 strDnFuncMapId = new clsvDnFuncMap_SimDA().GetFirstID(strWhereCond);
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
 arrList = vDnFuncMap_SimDA.GetID(strWhereCond);
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
bool bolIsExist = vDnFuncMap_SimDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vDnFuncMap_SimDA.IsExist(strDnFuncMapId);
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
 bolIsExist = clsvDnFuncMap_SimDA.IsExistTable();
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
 bolIsExist = vDnFuncMap_SimDA.IsExistTable(strTabName);
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
 /// <param name = "objvDnFuncMap_SimENS">源对象</param>
 /// <param name = "objvDnFuncMap_SimENT">目标对象</param>
 public static void CopyTo(clsvDnFuncMap_SimEN objvDnFuncMap_SimENS, clsvDnFuncMap_SimEN objvDnFuncMap_SimENT)
{
try
{
objvDnFuncMap_SimENT.DnFuncMapId = objvDnFuncMap_SimENS.DnFuncMapId; //函数映射Id
objvDnFuncMap_SimENT.InDataNodeId = objvDnFuncMap_SimENS.InDataNodeId; //In数据结点Id
objvDnFuncMap_SimENT.OutDataNodeId = objvDnFuncMap_SimENS.OutDataNodeId; //Out数据结点Id
objvDnFuncMap_SimENT.AssociationMappingId = objvDnFuncMap_SimENS.AssociationMappingId; //关联关系映射Id
objvDnFuncMap_SimENT.FuncMapModeId = objvDnFuncMap_SimENS.FuncMapModeId; //函数映射模式Id
objvDnFuncMap_SimENT.TabId = objvDnFuncMap_SimENS.TabId; //表ID
objvDnFuncMap_SimENT.DnFunctionId = objvDnFuncMap_SimENS.DnFunctionId; //DN函数Id
objvDnFuncMap_SimENT.PrjId = objvDnFuncMap_SimENS.PrjId; //工程Id
objvDnFuncMap_SimENT.UsedTimes = objvDnFuncMap_SimENS.UsedTimes; //使用次数
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
 /// <param name = "objvDnFuncMap_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvDnFuncMap_SimEN objvDnFuncMap_SimEN)
{
try
{
objvDnFuncMap_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvDnFuncMap_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convDnFuncMap_Sim.DnFuncMapId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMap_SimEN.DnFuncMapId = objvDnFuncMap_SimEN.DnFuncMapId; //函数映射Id
}
if (arrFldSet.Contains(convDnFuncMap_Sim.InDataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMap_SimEN.InDataNodeId = objvDnFuncMap_SimEN.InDataNodeId; //In数据结点Id
}
if (arrFldSet.Contains(convDnFuncMap_Sim.OutDataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMap_SimEN.OutDataNodeId = objvDnFuncMap_SimEN.OutDataNodeId; //Out数据结点Id
}
if (arrFldSet.Contains(convDnFuncMap_Sim.AssociationMappingId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMap_SimEN.AssociationMappingId = objvDnFuncMap_SimEN.AssociationMappingId == "[null]" ? null :  objvDnFuncMap_SimEN.AssociationMappingId; //关联关系映射Id
}
if (arrFldSet.Contains(convDnFuncMap_Sim.FuncMapModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMap_SimEN.FuncMapModeId = objvDnFuncMap_SimEN.FuncMapModeId == "[null]" ? null :  objvDnFuncMap_SimEN.FuncMapModeId; //函数映射模式Id
}
if (arrFldSet.Contains(convDnFuncMap_Sim.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMap_SimEN.TabId = objvDnFuncMap_SimEN.TabId; //表ID
}
if (arrFldSet.Contains(convDnFuncMap_Sim.DnFunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMap_SimEN.DnFunctionId = objvDnFuncMap_SimEN.DnFunctionId == "[null]" ? null :  objvDnFuncMap_SimEN.DnFunctionId; //DN函数Id
}
if (arrFldSet.Contains(convDnFuncMap_Sim.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMap_SimEN.PrjId = objvDnFuncMap_SimEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convDnFuncMap_Sim.UsedTimes, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFuncMap_SimEN.UsedTimes = objvDnFuncMap_SimEN.UsedTimes; //使用次数
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
 /// <param name = "objvDnFuncMap_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvDnFuncMap_SimEN objvDnFuncMap_SimEN)
{
try
{
if (objvDnFuncMap_SimEN.AssociationMappingId == "[null]") objvDnFuncMap_SimEN.AssociationMappingId = null; //关联关系映射Id
if (objvDnFuncMap_SimEN.FuncMapModeId == "[null]") objvDnFuncMap_SimEN.FuncMapModeId = null; //函数映射模式Id
if (objvDnFuncMap_SimEN.DnFunctionId == "[null]") objvDnFuncMap_SimEN.DnFunctionId = null; //DN函数Id
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
public static void CheckProperty4Condition(clsvDnFuncMap_SimEN objvDnFuncMap_SimEN)
{
 vDnFuncMap_SimDA.CheckProperty4Condition(objvDnFuncMap_SimEN);
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DnFuncMapId");
//if (arrvDnFuncMap_SimObjLstCache == null)
//{
//arrvDnFuncMap_SimObjLstCache = vDnFuncMap_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDnFuncMapId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDnFuncMap_SimEN GetObjByDnFuncMapIdCache(string strDnFuncMapId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvDnFuncMap_SimEN._CurrTabName, strPrjId);
List<clsvDnFuncMap_SimEN> arrvDnFuncMap_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFuncMap_SimEN> arrvDnFuncMap_SimObjLst_Sel =
arrvDnFuncMap_SimObjLstCache
.Where(x=> x.DnFuncMapId == strDnFuncMapId 
);
if (arrvDnFuncMap_SimObjLst_Sel.Count() == 0)
{
   clsvDnFuncMap_SimEN obj = clsvDnFuncMap_SimBL.GetObjByDnFuncMapId(strDnFuncMapId);
   if (obj != null)
 {
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strDnFuncMapId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
 }
return null;
}
return arrvDnFuncMap_SimObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDnFuncMap_SimEN> GetAllvDnFuncMap_SimObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvDnFuncMap_SimEN> arrvDnFuncMap_SimObjLstCache = GetObjLstCache(strPrjId); 
return arrvDnFuncMap_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDnFuncMap_SimEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvDnFuncMap_SimEN._CurrTabName, strPrjId);
string strCondition = string.Format(clsvDnFuncMap_SimEN._WhereFormatBack, strPrjId);
List<clsvDnFuncMap_SimEN> arrvDnFuncMap_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvDnFuncMap_SimObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvDnFuncMap_SimEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvDnFuncMap_SimEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvDnFuncMap_SimEN._RefreshTimeLst.Count == 0) return "";
return clsvDnFuncMap_SimEN._RefreshTimeLst[clsvDnFuncMap_SimEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convDnFuncMap_Sim.DnFuncMapId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convDnFuncMap_Sim._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convDnFuncMap_Sim._AttributeName));
throw new Exception(strMsg);
}
var objvDnFuncMap_Sim = clsvDnFuncMap_SimBL.GetObjByDnFuncMapIdCache(strDnFuncMapId, strPrjId);
if (objvDnFuncMap_Sim == null) return "";
return objvDnFuncMap_Sim[strOutFldName].ToString();
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
int intRecCount = clsvDnFuncMap_SimDA.GetRecCount(strTabName);
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
int intRecCount = clsvDnFuncMap_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvDnFuncMap_SimDA.GetRecCount();
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
int intRecCount = clsvDnFuncMap_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvDnFuncMap_SimEN objvDnFuncMap_SimCond, string strPrjId)
{
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvDnFuncMap_SimBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvDnFuncMap_SimEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFuncMap_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDnFuncMap_Sim._AttributeName)
{
if (objvDnFuncMap_SimCond.IsUpdated(strFldName) == false) continue;
if (objvDnFuncMap_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDnFuncMap_SimCond[strFldName].ToString());
}
else
{
if (objvDnFuncMap_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDnFuncMap_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDnFuncMap_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDnFuncMap_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDnFuncMap_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDnFuncMap_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDnFuncMap_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDnFuncMap_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDnFuncMap_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDnFuncMap_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDnFuncMap_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDnFuncMap_SimCond[strFldName]));
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
 List<string> arrList = clsvDnFuncMap_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vDnFuncMap_SimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vDnFuncMap_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}