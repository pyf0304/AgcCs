
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnPathWApi
 表名:DnPath(00050591)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:25
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
public static class  clsDnPathWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnPathId">DN路径Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetDnPathId(this clsDnPathEN objDnPathEN, string strDnPathId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnPathId, 8, conDnPath.DnPathId);
clsCheckSql.CheckFieldForeignKey(strDnPathId, 8, conDnPath.DnPathId);
objDnPathEN.DnPathId = strDnPathId; //DN路径Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.DnPathId) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.DnPathId, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.DnPathId] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnPathName">DN路径名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetDnPathName(this clsDnPathEN objDnPathEN, string strDnPathName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDnPathName, conDnPath.DnPathName);
clsCheckSql.CheckFieldLen(strDnPathName, 100, conDnPath.DnPathName);
objDnPathEN.DnPathName = strDnPathName; //DN路径名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.DnPathName) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.DnPathName, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.DnPathName] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "lngInDataNodeId">In数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetInDataNodeId(this clsDnPathEN objDnPathEN, long lngInDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngInDataNodeId, conDnPath.InDataNodeId);
objDnPathEN.InDataNodeId = lngInDataNodeId; //In数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.InDataNodeId) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.InDataNodeId, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.InDataNodeId] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "lngOutDataNodeId">Out数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetOutDataNodeId(this clsDnPathEN objDnPathEN, long lngOutDataNodeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngOutDataNodeId, conDnPath.OutDataNodeId);
objDnPathEN.OutDataNodeId = lngOutDataNodeId; //Out数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.OutDataNodeId) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.OutDataNodeId, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.OutDataNodeId] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnPathNodeLst">路径结点列表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetDnPathNodeLst(this clsDnPathEN objDnPathEN, string strDnPathNodeLst, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDnPathNodeLst, conDnPath.DnPathNodeLst);
clsCheckSql.CheckFieldLen(strDnPathNodeLst, 500, conDnPath.DnPathNodeLst);
objDnPathEN.DnPathNodeLst = strDnPathNodeLst; //路径结点列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.DnPathNodeLst) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.DnPathNodeLst, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.DnPathNodeLst] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnPathNodeLstV2">路径结点列表V2</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetDnPathNodeLstV2(this clsDnPathEN objDnPathEN, string strDnPathNodeLstV2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnPathNodeLstV2, 500, conDnPath.DnPathNodeLstV2);
objDnPathEN.DnPathNodeLstV2 = strDnPathNodeLstV2; //路径结点列表V2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.DnPathNodeLstV2) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.DnPathNodeLstV2, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.DnPathNodeLstV2] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strAssociationMappingId">关联关系映射Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetAssociationMappingId(this clsDnPathEN objDnPathEN, string strAssociationMappingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAssociationMappingId, conDnPath.AssociationMappingId);
clsCheckSql.CheckFieldLen(strAssociationMappingId, 2, conDnPath.AssociationMappingId);
clsCheckSql.CheckFieldForeignKey(strAssociationMappingId, 2, conDnPath.AssociationMappingId);
objDnPathEN.AssociationMappingId = strAssociationMappingId; //关联关系映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.AssociationMappingId) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.AssociationMappingId, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.AssociationMappingId] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsHasErr">是否有错</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetIsHasErr(this clsDnPathEN objDnPathEN, bool bolIsHasErr, string strComparisonOp="")
	{
objDnPathEN.IsHasErr = bolIsHasErr; //是否有错
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.IsHasErr) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.IsHasErr, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.IsHasErr] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "intEdgeNum">边数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetEdgeNum(this clsDnPathEN objDnPathEN, int intEdgeNum, string strComparisonOp="")
	{
objDnPathEN.EdgeNum = intEdgeNum; //边数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.EdgeNum) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.EdgeNum, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.EdgeNum] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetErrMsg(this clsDnPathEN objDnPathEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conDnPath.ErrMsg);
objDnPathEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.ErrMsg) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.ErrMsg, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.ErrMsg] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetInUse(this clsDnPathEN objDnPathEN, bool bolInUse, string strComparisonOp="")
	{
objDnPathEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.InUse) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.InUse, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.InUse] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsExistPath">是否存在路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetIsExistPath(this clsDnPathEN objDnPathEN, bool bolIsExistPath, string strComparisonOp="")
	{
objDnPathEN.IsExistPath = bolIsExistPath; //是否存在路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.IsExistPath) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.IsExistPath, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.IsExistPath] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetPrjId(this clsDnPathEN objDnPathEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conDnPath.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conDnPath.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conDnPath.PrjId);
objDnPathEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.PrjId) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.PrjId, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.PrjId] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetUpdDate(this clsDnPathEN objDnPathEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDnPath.UpdDate);
objDnPathEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.UpdDate) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.UpdDate, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.UpdDate] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetUpdUser(this clsDnPathEN objDnPathEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDnPath.UpdUser);
objDnPathEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.UpdUser) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.UpdUser, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.UpdUser] = strComparisonOp;
}
}
return objDnPathEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnPathEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnPathEN SetMemo(this clsDnPathEN objDnPathEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDnPath.Memo);
objDnPathEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnPathEN.dicFldComparisonOp.ContainsKey(conDnPath.Memo) == false)
{
objDnPathEN.dicFldComparisonOp.Add(conDnPath.Memo, strComparisonOp);
}
else
{
objDnPathEN.dicFldComparisonOp[conDnPath.Memo] = strComparisonOp;
}
}
return objDnPathEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDnPathEN objDnPathCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDnPathCond.IsUpdated(conDnPath.DnPathId) == true)
{
string strComparisonOpDnPathId = objDnPathCond.dicFldComparisonOp[conDnPath.DnPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.DnPathId, objDnPathCond.DnPathId, strComparisonOpDnPathId);
}
if (objDnPathCond.IsUpdated(conDnPath.DnPathName) == true)
{
string strComparisonOpDnPathName = objDnPathCond.dicFldComparisonOp[conDnPath.DnPathName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.DnPathName, objDnPathCond.DnPathName, strComparisonOpDnPathName);
}
if (objDnPathCond.IsUpdated(conDnPath.InDataNodeId) == true)
{
string strComparisonOpInDataNodeId = objDnPathCond.dicFldComparisonOp[conDnPath.InDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDnPath.InDataNodeId, objDnPathCond.InDataNodeId, strComparisonOpInDataNodeId);
}
if (objDnPathCond.IsUpdated(conDnPath.OutDataNodeId) == true)
{
string strComparisonOpOutDataNodeId = objDnPathCond.dicFldComparisonOp[conDnPath.OutDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDnPath.OutDataNodeId, objDnPathCond.OutDataNodeId, strComparisonOpOutDataNodeId);
}
if (objDnPathCond.IsUpdated(conDnPath.DnPathNodeLst) == true)
{
string strComparisonOpDnPathNodeLst = objDnPathCond.dicFldComparisonOp[conDnPath.DnPathNodeLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.DnPathNodeLst, objDnPathCond.DnPathNodeLst, strComparisonOpDnPathNodeLst);
}
if (objDnPathCond.IsUpdated(conDnPath.DnPathNodeLstV2) == true)
{
string strComparisonOpDnPathNodeLstV2 = objDnPathCond.dicFldComparisonOp[conDnPath.DnPathNodeLstV2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.DnPathNodeLstV2, objDnPathCond.DnPathNodeLstV2, strComparisonOpDnPathNodeLstV2);
}
if (objDnPathCond.IsUpdated(conDnPath.AssociationMappingId) == true)
{
string strComparisonOpAssociationMappingId = objDnPathCond.dicFldComparisonOp[conDnPath.AssociationMappingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.AssociationMappingId, objDnPathCond.AssociationMappingId, strComparisonOpAssociationMappingId);
}
if (objDnPathCond.IsUpdated(conDnPath.IsHasErr) == true)
{
if (objDnPathCond.IsHasErr == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDnPath.IsHasErr);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDnPath.IsHasErr);
}
}
if (objDnPathCond.IsUpdated(conDnPath.EdgeNum) == true)
{
string strComparisonOpEdgeNum = objDnPathCond.dicFldComparisonOp[conDnPath.EdgeNum];
strWhereCond += string.Format(" And {0} {2} {1}", conDnPath.EdgeNum, objDnPathCond.EdgeNum, strComparisonOpEdgeNum);
}
if (objDnPathCond.IsUpdated(conDnPath.ErrMsg) == true)
{
string strComparisonOpErrMsg = objDnPathCond.dicFldComparisonOp[conDnPath.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.ErrMsg, objDnPathCond.ErrMsg, strComparisonOpErrMsg);
}
if (objDnPathCond.IsUpdated(conDnPath.InUse) == true)
{
if (objDnPathCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDnPath.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDnPath.InUse);
}
}
if (objDnPathCond.IsUpdated(conDnPath.IsExistPath) == true)
{
if (objDnPathCond.IsExistPath == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDnPath.IsExistPath);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDnPath.IsExistPath);
}
}
if (objDnPathCond.IsUpdated(conDnPath.PrjId) == true)
{
string strComparisonOpPrjId = objDnPathCond.dicFldComparisonOp[conDnPath.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.PrjId, objDnPathCond.PrjId, strComparisonOpPrjId);
}
if (objDnPathCond.IsUpdated(conDnPath.UpdDate) == true)
{
string strComparisonOpUpdDate = objDnPathCond.dicFldComparisonOp[conDnPath.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.UpdDate, objDnPathCond.UpdDate, strComparisonOpUpdDate);
}
if (objDnPathCond.IsUpdated(conDnPath.UpdUser) == true)
{
string strComparisonOpUpdUser = objDnPathCond.dicFldComparisonOp[conDnPath.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.UpdUser, objDnPathCond.UpdUser, strComparisonOpUpdUser);
}
if (objDnPathCond.IsUpdated(conDnPath.Memo) == true)
{
string strComparisonOpMemo = objDnPathCond.dicFldComparisonOp[conDnPath.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnPath.Memo, objDnPathCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDnPathEN objDnPathEN)
{
 if (string.IsNullOrEmpty(objDnPathEN.DnPathId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDnPathEN.sfUpdFldSetStr = objDnPathEN.getsfUpdFldSetStr();
clsDnPathWApi.CheckPropertyNew(objDnPathEN); 
bool bolResult = clsDnPathWApi.UpdateRecord(objDnPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathWApi.ReFreshCache(objDnPathEN.PrjId);
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
 /// 获取唯一性条件串--DnPath(数据结点路径), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DnPathName_DnPathNodeLst
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDnPathEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsDnPathEN objDnPathEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDnPathEN == null) return "";
if (objDnPathEN.DnPathId == null || objDnPathEN.DnPathId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DnPathName = '{0}'", objDnPathEN.DnPathName);
 sbCondition.AppendFormat(" and DnPathNodeLst = '{0}'", objDnPathEN.DnPathNodeLst);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DnPathId !=  '{0}'", objDnPathEN.DnPathId);
 sbCondition.AppendFormat(" and DnPathName = '{0}'", objDnPathEN.DnPathName);
 sbCondition.AppendFormat(" and DnPathNodeLst = '{0}'", objDnPathEN.DnPathNodeLst);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDnPathEN objDnPathEN)
{
try
{
 if (string.IsNullOrEmpty(objDnPathEN.DnPathId) == true || clsDnPathWApi.IsExist(objDnPathEN.DnPathId) == true)
 {
     objDnPathEN.DnPathId = clsDnPathWApi.GetMaxStrId();
 }
clsDnPathWApi.CheckPropertyNew(objDnPathEN); 
bool bolResult = clsDnPathWApi.AddNewRecord(objDnPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathWApi.ReFreshCache(objDnPathEN.PrjId);
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
 /// <param name = "objDnPathEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDnPathEN objDnPathEN)
{
try
{
clsDnPathWApi.CheckPropertyNew(objDnPathEN); 
string strDnPathId = clsDnPathWApi.AddNewRecordWithMaxId(objDnPathEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathWApi.ReFreshCache(objDnPathEN.PrjId);
return strDnPathId;
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
 /// <param name = "objDnPathEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDnPathEN objDnPathEN, string strWhereCond)
{
try
{
clsDnPathWApi.CheckPropertyNew(objDnPathEN); 
bool bolResult = clsDnPathWApi.UpdateWithCondition(objDnPathEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathWApi.ReFreshCache(objDnPathEN.PrjId);
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
 /// 数据结点路径(DnPath)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDnPathWApi
{
private static readonly string mstrApiControllerName = "DnPathApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsDnPathWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DnPathId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据结点路径]...","0");
List<clsDnPathEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="DnPathId";
objDDL.DataTextField="DnPathName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDnPathEN objDnPathEN)
{
if (!Object.Equals(null, objDnPathEN.DnPathId) && GetStrLen(objDnPathEN.DnPathId) > 8)
{
 throw new Exception("字段[DN路径Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDnPathEN.DnPathName) && GetStrLen(objDnPathEN.DnPathName) > 100)
{
 throw new Exception("字段[DN路径名]的长度不能超过100!");
}
if (!Object.Equals(null, objDnPathEN.DnPathNodeLst) && GetStrLen(objDnPathEN.DnPathNodeLst) > 500)
{
 throw new Exception("字段[路径结点列表]的长度不能超过500!");
}
if (!Object.Equals(null, objDnPathEN.DnPathNodeLstV2) && GetStrLen(objDnPathEN.DnPathNodeLstV2) > 500)
{
 throw new Exception("字段[路径结点列表V2]的长度不能超过500!");
}
if (!Object.Equals(null, objDnPathEN.AssociationMappingId) && GetStrLen(objDnPathEN.AssociationMappingId) > 2)
{
 throw new Exception("字段[关联关系映射Id]的长度不能超过2!");
}
if (!Object.Equals(null, objDnPathEN.ErrMsg) && GetStrLen(objDnPathEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objDnPathEN.PrjId) && GetStrLen(objDnPathEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objDnPathEN.UpdDate) && GetStrLen(objDnPathEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objDnPathEN.UpdUser) && GetStrLen(objDnPathEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objDnPathEN.Memo) && GetStrLen(objDnPathEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objDnPathEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnPathId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDnPathEN GetObjByDnPathId(string strDnPathId)
{
if (strDnPathId == "") return null;
string strAction = "GetObjByDnPathId";
clsDnPathEN objDnPathEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDnPathId"] = strDnPathId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objDnPathEN = JsonConvert.DeserializeObject<clsDnPathEN>(strJson);
return objDnPathEN;
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
public static clsDnPathEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsDnPathEN objDnPathEN;
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
objDnPathEN = JsonConvert.DeserializeObject<clsDnPathEN>(strJson);
return objDnPathEN;
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
 /// <param name = "strDnPathId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDnPathEN GetObjByDnPathIdCache(string strDnPathId)
{
if (string.IsNullOrEmpty(strDnPathId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsDnPathEN._CurrTabName, strPrjId);
List<clsDnPathEN> arrDnPathObjLstCache = GetObjLstCache();
IEnumerable <clsDnPathEN> arrDnPathObjLst_Sel =
from objDnPathEN in arrDnPathObjLstCache
where objDnPathEN.DnPathId == strDnPathId 
select objDnPathEN;
if (arrDnPathObjLst_Sel.Count() == 0)
{
   clsDnPathEN obj = clsDnPathWApi.GetObjByDnPathId(strDnPathId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDnPathObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDnPathId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDnPathNameByDnPathIdCache(string strDnPathId)
{
if (string.IsNullOrEmpty(strDnPathId) == true) return "";
//初始化列表缓存
List<clsDnPathEN> arrDnPathObjLstCache = GetObjLstCache();
IEnumerable <clsDnPathEN> arrDnPathObjLst_Sel1 =
from objDnPathEN in arrDnPathObjLstCache
where objDnPathEN.DnPathId == strDnPathId 
select objDnPathEN;
List <clsDnPathEN> arrDnPathObjLst_Sel = new List<clsDnPathEN>();
foreach (clsDnPathEN obj in arrDnPathObjLst_Sel1)
{
arrDnPathObjLst_Sel.Add(obj);
}
if (arrDnPathObjLst_Sel.Count > 0)
{
return arrDnPathObjLst_Sel[0].DnPathName;
}
string strErrMsgForGetObjById = string.Format("在DnPath对象缓存列表中,找不到记录[DnPathId = {0}](函数:{1})", strDnPathId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsDnPathBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDnPathId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDnPathIdCache(string strDnPathId)
{
if (string.IsNullOrEmpty(strDnPathId) == true) return "";
//初始化列表缓存
List<clsDnPathEN> arrDnPathObjLstCache = GetObjLstCache();
IEnumerable <clsDnPathEN> arrDnPathObjLst_Sel1 =
from objDnPathEN in arrDnPathObjLstCache
where objDnPathEN.DnPathId == strDnPathId 
select objDnPathEN;
List <clsDnPathEN> arrDnPathObjLst_Sel = new List<clsDnPathEN>();
foreach (clsDnPathEN obj in arrDnPathObjLst_Sel1)
{
arrDnPathObjLst_Sel.Add(obj);
}
if (arrDnPathObjLst_Sel.Count > 0)
{
return arrDnPathObjLst_Sel[0].DnPathName;
}
string strErrMsgForGetObjById = string.Format("在DnPath对象缓存列表中,找不到记录的相关名称[DnPathId = {0}](函数:{1})", strDnPathId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsDnPathBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnPathEN> GetObjLst(string strWhereCond)
{
 List<clsDnPathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnPathEN>>(strJson);
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
 /// <param name = "arrDnPathId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnPathEN> GetObjLstByDnPathIdLst(List<string> arrDnPathId)
{
 List<clsDnPathEN> arrObjLst; 
string strAction = "GetObjLstByDnPathIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDnPathId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDnPathEN>>(strJson);
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
 /// <param name = "arrDnPathId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsDnPathEN> GetObjLstByDnPathIdLstCache(List<string> arrDnPathId, )
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsDnPathEN._CurrTabName, strPrjId);
List<clsDnPathEN> arrDnPathObjLstCache = GetObjLstCache();
IEnumerable <clsDnPathEN> arrDnPathObjLst_Sel =
from objDnPathEN in arrDnPathObjLstCache
where arrDnPathId.Contains(objDnPathEN.DnPathId)
select objDnPathEN;
return arrDnPathObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnPathEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDnPathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnPathEN>>(strJson);
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
public static List<clsDnPathEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDnPathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnPathEN>>(strJson);
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
public static List<clsDnPathEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDnPathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnPathEN>>(strJson);
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
public static List<clsDnPathEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsDnPathEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnPathEN>>(strJson);
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
public static int DelRecord(string strDnPathId)
{
string strAction = "DelRecord";
try
{
 clsDnPathEN objDnPathEN = clsDnPathWApi.GetObjByDnPathId(strDnPathId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strDnPathId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDnPathWApi.ReFreshCache(objDnPathEN.PrjId);
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
public static int DelDnPaths(List<string> arrDnPathId)
{
string strAction = "DelDnPaths";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDnPathId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsDnPathEN objDnPathEN = clsDnPathWApi.GetObjByDnPathId(arrDnPathId[0]);
clsDnPathWApi.ReFreshCache(objDnPathEN.PrjId);
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
public static int DelDnPathsByCond(string strWhereCond)
{
string strAction = "DelDnPathsByCond";
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
public static bool AddNewRecord(clsDnPathEN objDnPathEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnPathEN>(objDnPathEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathWApi.ReFreshCache(objDnPathEN.PrjId);
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
public static string AddNewRecordWithMaxId(clsDnPathEN objDnPathEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnPathEN>(objDnPathEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnPathWApi.ReFreshCache(objDnPathEN.PrjId);
var strDnPathId = (string)jobjReturn0["returnStr"];
return strDnPathId;
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
public static bool UpdateRecord(clsDnPathEN objDnPathEN)
{
if (string.IsNullOrEmpty(objDnPathEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDnPathEN.DnPathId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnPathEN>(objDnPathEN);
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
 /// <param name = "objDnPathEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDnPathEN objDnPathEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDnPathEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDnPathEN.DnPathId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDnPathEN.DnPathId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnPathEN>(objDnPathEN);
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
public static bool IsExist(string strDnPathId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDnPathId"] = strDnPathId
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
 /// <param name = "objDnPathENS">源对象</param>
 /// <param name = "objDnPathENT">目标对象</param>
 public static void CopyTo(clsDnPathEN objDnPathENS, clsDnPathEN objDnPathENT)
{
try
{
objDnPathENT.DnPathId = objDnPathENS.DnPathId; //DN路径Id
objDnPathENT.DnPathName = objDnPathENS.DnPathName; //DN路径名
objDnPathENT.InDataNodeId = objDnPathENS.InDataNodeId; //In数据结点Id
objDnPathENT.OutDataNodeId = objDnPathENS.OutDataNodeId; //Out数据结点Id
objDnPathENT.DnPathNodeLst = objDnPathENS.DnPathNodeLst; //路径结点列表
objDnPathENT.DnPathNodeLstV2 = objDnPathENS.DnPathNodeLstV2; //路径结点列表V2
objDnPathENT.AssociationMappingId = objDnPathENS.AssociationMappingId; //关联关系映射Id
objDnPathENT.IsHasErr = objDnPathENS.IsHasErr; //是否有错
objDnPathENT.EdgeNum = objDnPathENS.EdgeNum; //边数
objDnPathENT.ErrMsg = objDnPathENS.ErrMsg; //错误信息
objDnPathENT.InUse = objDnPathENS.InUse; //是否在用
objDnPathENT.IsExistPath = objDnPathENS.IsExistPath; //是否存在路径
objDnPathENT.PrjId = objDnPathENS.PrjId; //工程Id
objDnPathENT.UpdDate = objDnPathENS.UpdDate; //修改日期
objDnPathENT.UpdUser = objDnPathENS.UpdUser; //修改者
objDnPathENT.Memo = objDnPathENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsDnPathEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDnPathEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDnPathEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDnPathEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDnPathEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDnPathEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsDnPathWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsDnPathWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsDnPathEN._CurrTabName, strPrjId);
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
if (clsDnPathWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsDnPathEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDnPathWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDnPathEN> GetObjLstCache()
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsDnPathWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsDnPathWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsDnPathEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsDnPathEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conDnPath.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsDnPathEN._CurrTabName, strPrjId);
List<clsDnPathEN> arrDnPathObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrDnPathObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDnPathEN> GetObjLstCacheFromObjLst(List<clsDnPathEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsDnPathWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsDnPathWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsDnPathEN._CurrTabName, strPrjId);
List<clsDnPathEN> arrDnPathObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrDnPathObjLstCache = CacheHelper.Get<List<clsDnPathEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrDnPathObjLstCache = CacheHelper.Get<List<clsDnPathEN>>(strKey);
}
return arrDnPathObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDnPathEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDnPath.DnPathId, Type.GetType("System.String"));
objDT.Columns.Add(conDnPath.DnPathName, Type.GetType("System.String"));
objDT.Columns.Add(conDnPath.InDataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(conDnPath.OutDataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(conDnPath.DnPathNodeLst, Type.GetType("System.String"));
objDT.Columns.Add(conDnPath.DnPathNodeLstV2, Type.GetType("System.String"));
objDT.Columns.Add(conDnPath.AssociationMappingId, Type.GetType("System.String"));
objDT.Columns.Add(conDnPath.IsHasErr, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDnPath.EdgeNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conDnPath.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conDnPath.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDnPath.IsExistPath, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDnPath.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conDnPath.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conDnPath.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conDnPath.Memo, Type.GetType("System.String"));
foreach (clsDnPathEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDnPath.DnPathId] = objInFor[conDnPath.DnPathId];
objDR[conDnPath.DnPathName] = objInFor[conDnPath.DnPathName];
objDR[conDnPath.InDataNodeId] = objInFor[conDnPath.InDataNodeId];
objDR[conDnPath.OutDataNodeId] = objInFor[conDnPath.OutDataNodeId];
objDR[conDnPath.DnPathNodeLst] = objInFor[conDnPath.DnPathNodeLst];
objDR[conDnPath.DnPathNodeLstV2] = objInFor[conDnPath.DnPathNodeLstV2];
objDR[conDnPath.AssociationMappingId] = objInFor[conDnPath.AssociationMappingId];
objDR[conDnPath.IsHasErr] = objInFor[conDnPath.IsHasErr];
objDR[conDnPath.EdgeNum] = objInFor[conDnPath.EdgeNum];
objDR[conDnPath.ErrMsg] = objInFor[conDnPath.ErrMsg];
objDR[conDnPath.InUse] = objInFor[conDnPath.InUse];
objDR[conDnPath.IsExistPath] = objInFor[conDnPath.IsExistPath];
objDR[conDnPath.PrjId] = objInFor[conDnPath.PrjId];
objDR[conDnPath.UpdDate] = objInFor[conDnPath.UpdDate];
objDR[conDnPath.UpdUser] = objInFor[conDnPath.UpdUser];
objDR[conDnPath.Memo] = objInFor[conDnPath.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 数据结点路径(DnPath)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4DnPath : clsCommFun4BL
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
clsDnPathWApi.ReFreshThisCache();
}
}

}