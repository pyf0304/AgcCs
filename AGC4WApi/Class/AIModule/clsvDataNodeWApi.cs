
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDataNodeWApi
 表名:vDataNode(00050569)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:40
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
public static class  clsvDataNodeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "lngDataNodeId">数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetDataNodeId(this clsvDataNodeEN objvDataNodeEN, long lngDataNodeId, string strComparisonOp="")
	{
objvDataNodeEN.DataNodeId = lngDataNodeId; //数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeEN.dicFldComparisonOp.ContainsKey(convDataNode.DataNodeId) == false)
{
objvDataNodeEN.dicFldComparisonOp.Add(convDataNode.DataNodeId, strComparisonOp);
}
else
{
objvDataNodeEN.dicFldComparisonOp[convDataNode.DataNodeId] = strComparisonOp;
}
}
return objvDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataNodeName">数据结点名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetDataNodeName(this clsvDataNodeEN objvDataNodeEN, string strDataNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataNodeName, 100, convDataNode.DataNodeName);
objvDataNodeEN.DataNodeName = strDataNodeName; //数据结点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeEN.dicFldComparisonOp.ContainsKey(convDataNode.DataNodeName) == false)
{
objvDataNodeEN.dicFldComparisonOp.Add(convDataNode.DataNodeName, strComparisonOp);
}
else
{
objvDataNodeEN.dicFldComparisonOp[convDataNode.DataNodeName] = strComparisonOp;
}
}
return objvDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetTabId(this clsvDataNodeEN objvDataNodeEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convDataNode.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convDataNode.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convDataNode.TabId);
objvDataNodeEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeEN.dicFldComparisonOp.ContainsKey(convDataNode.TabId) == false)
{
objvDataNodeEN.dicFldComparisonOp.Add(convDataNode.TabId, strComparisonOp);
}
else
{
objvDataNodeEN.dicFldComparisonOp[convDataNode.TabId] = strComparisonOp;
}
}
return objvDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetTabName(this clsvDataNodeEN objvDataNodeEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convDataNode.TabName);
clsCheckSql.CheckFieldLen(strTabName, 100, convDataNode.TabName);
objvDataNodeEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeEN.dicFldComparisonOp.ContainsKey(convDataNode.TabName) == false)
{
objvDataNodeEN.dicFldComparisonOp.Add(convDataNode.TabName, strComparisonOp);
}
else
{
objvDataNodeEN.dicFldComparisonOp[convDataNode.TabName] = strComparisonOp;
}
}
return objvDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetFldId(this clsvDataNodeEN objvDataNodeEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convDataNode.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convDataNode.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convDataNode.FldId);
objvDataNodeEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeEN.dicFldComparisonOp.ContainsKey(convDataNode.FldId) == false)
{
objvDataNodeEN.dicFldComparisonOp.Add(convDataNode.FldId, strComparisonOp);
}
else
{
objvDataNodeEN.dicFldComparisonOp[convDataNode.FldId] = strComparisonOp;
}
}
return objvDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetFldName(this clsvDataNodeEN objvDataNodeEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convDataNode.FldName);
clsCheckSql.CheckFieldLen(strFldName, 50, convDataNode.FldName);
objvDataNodeEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeEN.dicFldComparisonOp.ContainsKey(convDataNode.FldName) == false)
{
objvDataNodeEN.dicFldComparisonOp.Add(convDataNode.FldName, strComparisonOp);
}
else
{
objvDataNodeEN.dicFldComparisonOp[convDataNode.FldName] = strComparisonOp;
}
}
return objvDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intVersionNo">版本号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetVersionNo(this clsvDataNodeEN objvDataNodeEN, int intVersionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intVersionNo, convDataNode.VersionNo);
objvDataNodeEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeEN.dicFldComparisonOp.ContainsKey(convDataNode.VersionNo) == false)
{
objvDataNodeEN.dicFldComparisonOp.Add(convDataNode.VersionNo, strComparisonOp);
}
else
{
objvDataNodeEN.dicFldComparisonOp[convDataNode.VersionNo] = strComparisonOp;
}
}
return objvDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataNodeTypeId">数据结点类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetDataNodeTypeId(this clsvDataNodeEN objvDataNodeEN, string strDataNodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataNodeTypeId, 2, convDataNode.DataNodeTypeId);
clsCheckSql.CheckFieldForeignKey(strDataNodeTypeId, 2, convDataNode.DataNodeTypeId);
objvDataNodeEN.DataNodeTypeId = strDataNodeTypeId; //数据结点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeEN.dicFldComparisonOp.ContainsKey(convDataNode.DataNodeTypeId) == false)
{
objvDataNodeEN.dicFldComparisonOp.Add(convDataNode.DataNodeTypeId, strComparisonOp);
}
else
{
objvDataNodeEN.dicFldComparisonOp[convDataNode.DataNodeTypeId] = strComparisonOp;
}
}
return objvDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataNodeTypeName">数据结点类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetDataNodeTypeName(this clsvDataNodeEN objvDataNodeEN, string strDataNodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataNodeTypeName, 50, convDataNode.DataNodeTypeName);
objvDataNodeEN.DataNodeTypeName = strDataNodeTypeName; //数据结点类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeEN.dicFldComparisonOp.ContainsKey(convDataNode.DataNodeTypeName) == false)
{
objvDataNodeEN.dicFldComparisonOp.Add(convDataNode.DataNodeTypeName, strComparisonOp);
}
else
{
objvDataNodeEN.dicFldComparisonOp[convDataNode.DataNodeTypeName] = strComparisonOp;
}
}
return objvDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strSubGraphName">子图名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetSubGraphName(this clsvDataNodeEN objvDataNodeEN, string strSubGraphName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSubGraphName, 50, convDataNode.SubGraphName);
objvDataNodeEN.SubGraphName = strSubGraphName; //子图名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeEN.dicFldComparisonOp.ContainsKey(convDataNode.SubGraphName) == false)
{
objvDataNodeEN.dicFldComparisonOp.Add(convDataNode.SubGraphName, strComparisonOp);
}
else
{
objvDataNodeEN.dicFldComparisonOp[convDataNode.SubGraphName] = strComparisonOp;
}
}
return objvDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetPrjId(this clsvDataNodeEN objvDataNodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convDataNode.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convDataNode.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDataNode.PrjId);
objvDataNodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeEN.dicFldComparisonOp.ContainsKey(convDataNode.PrjId) == false)
{
objvDataNodeEN.dicFldComparisonOp.Add(convDataNode.PrjId, strComparisonOp);
}
else
{
objvDataNodeEN.dicFldComparisonOp[convDataNode.PrjId] = strComparisonOp;
}
}
return objvDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetUpdDate(this clsvDataNodeEN objvDataNodeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDataNode.UpdDate);
objvDataNodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeEN.dicFldComparisonOp.ContainsKey(convDataNode.UpdDate) == false)
{
objvDataNodeEN.dicFldComparisonOp.Add(convDataNode.UpdDate, strComparisonOp);
}
else
{
objvDataNodeEN.dicFldComparisonOp[convDataNode.UpdDate] = strComparisonOp;
}
}
return objvDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetUpdUser(this clsvDataNodeEN objvDataNodeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convDataNode.UpdUser);
objvDataNodeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeEN.dicFldComparisonOp.ContainsKey(convDataNode.UpdUser) == false)
{
objvDataNodeEN.dicFldComparisonOp.Add(convDataNode.UpdUser, strComparisonOp);
}
else
{
objvDataNodeEN.dicFldComparisonOp[convDataNode.UpdUser] = strComparisonOp;
}
}
return objvDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetMemo(this clsvDataNodeEN objvDataNodeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDataNode.Memo);
objvDataNodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNodeEN.dicFldComparisonOp.ContainsKey(convDataNode.Memo) == false)
{
objvDataNodeEN.dicFldComparisonOp.Add(convDataNode.Memo, strComparisonOp);
}
else
{
objvDataNodeEN.dicFldComparisonOp[convDataNode.Memo] = strComparisonOp;
}
}
return objvDataNodeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDataNodeEN objvDataNodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDataNodeCond.IsUpdated(convDataNode.DataNodeId) == true)
{
string strComparisonOpDataNodeId = objvDataNodeCond.dicFldComparisonOp[convDataNode.DataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", convDataNode.DataNodeId, objvDataNodeCond.DataNodeId, strComparisonOpDataNodeId);
}
if (objvDataNodeCond.IsUpdated(convDataNode.DataNodeName) == true)
{
string strComparisonOpDataNodeName = objvDataNodeCond.dicFldComparisonOp[convDataNode.DataNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode.DataNodeName, objvDataNodeCond.DataNodeName, strComparisonOpDataNodeName);
}
if (objvDataNodeCond.IsUpdated(convDataNode.TabId) == true)
{
string strComparisonOpTabId = objvDataNodeCond.dicFldComparisonOp[convDataNode.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode.TabId, objvDataNodeCond.TabId, strComparisonOpTabId);
}
if (objvDataNodeCond.IsUpdated(convDataNode.TabName) == true)
{
string strComparisonOpTabName = objvDataNodeCond.dicFldComparisonOp[convDataNode.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode.TabName, objvDataNodeCond.TabName, strComparisonOpTabName);
}
if (objvDataNodeCond.IsUpdated(convDataNode.FldId) == true)
{
string strComparisonOpFldId = objvDataNodeCond.dicFldComparisonOp[convDataNode.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode.FldId, objvDataNodeCond.FldId, strComparisonOpFldId);
}
if (objvDataNodeCond.IsUpdated(convDataNode.FldName) == true)
{
string strComparisonOpFldName = objvDataNodeCond.dicFldComparisonOp[convDataNode.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode.FldName, objvDataNodeCond.FldName, strComparisonOpFldName);
}
if (objvDataNodeCond.IsUpdated(convDataNode.VersionNo) == true)
{
string strComparisonOpVersionNo = objvDataNodeCond.dicFldComparisonOp[convDataNode.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convDataNode.VersionNo, objvDataNodeCond.VersionNo, strComparisonOpVersionNo);
}
if (objvDataNodeCond.IsUpdated(convDataNode.DataNodeTypeId) == true)
{
string strComparisonOpDataNodeTypeId = objvDataNodeCond.dicFldComparisonOp[convDataNode.DataNodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode.DataNodeTypeId, objvDataNodeCond.DataNodeTypeId, strComparisonOpDataNodeTypeId);
}
if (objvDataNodeCond.IsUpdated(convDataNode.DataNodeTypeName) == true)
{
string strComparisonOpDataNodeTypeName = objvDataNodeCond.dicFldComparisonOp[convDataNode.DataNodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode.DataNodeTypeName, objvDataNodeCond.DataNodeTypeName, strComparisonOpDataNodeTypeName);
}
if (objvDataNodeCond.IsUpdated(convDataNode.SubGraphName) == true)
{
string strComparisonOpSubGraphName = objvDataNodeCond.dicFldComparisonOp[convDataNode.SubGraphName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode.SubGraphName, objvDataNodeCond.SubGraphName, strComparisonOpSubGraphName);
}
if (objvDataNodeCond.IsUpdated(convDataNode.PrjId) == true)
{
string strComparisonOpPrjId = objvDataNodeCond.dicFldComparisonOp[convDataNode.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode.PrjId, objvDataNodeCond.PrjId, strComparisonOpPrjId);
}
if (objvDataNodeCond.IsUpdated(convDataNode.UpdDate) == true)
{
string strComparisonOpUpdDate = objvDataNodeCond.dicFldComparisonOp[convDataNode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode.UpdDate, objvDataNodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvDataNodeCond.IsUpdated(convDataNode.UpdUser) == true)
{
string strComparisonOpUpdUser = objvDataNodeCond.dicFldComparisonOp[convDataNode.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode.UpdUser, objvDataNodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objvDataNodeCond.IsUpdated(convDataNode.Memo) == true)
{
string strComparisonOpMemo = objvDataNodeCond.dicFldComparisonOp[convDataNode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode.Memo, objvDataNodeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vDataNode(vDataNode)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvDataNodeWApi
{
private static readonly string mstrApiControllerName = "vDataNodeApi";

 public clsvDataNodeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DataNodeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vDataNode]...","0");
List<clsvDataNodeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="DataNodeId";
objDDL.DataTextField="DataNodeName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_DataNodeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convDataNode.DataNodeId); 
List<clsvDataNodeEN> arrObjLst = clsvDataNodeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN()
{
DataNodeId = 0,
DataNodeName = "选[vDataNode]..."
};
arrObjLst.Insert(0, objvDataNodeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convDataNode.DataNodeId;
objComboBox.DisplayMember = convDataNode.DataNodeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngDataNodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDataNodeEN GetObjByDataNodeId(long lngDataNodeId)
{
if (lngDataNodeId == 0) return null;
string strAction = "GetObjByDataNodeId";
clsvDataNodeEN objvDataNodeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngDataNodeId"] = lngDataNodeId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvDataNodeEN = JsonConvert.DeserializeObject<clsvDataNodeEN>(strJson);
return objvDataNodeEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvDataNodeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvDataNodeEN objvDataNodeEN;
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
objvDataNodeEN = JsonConvert.DeserializeObject<clsvDataNodeEN>(strJson);
return objvDataNodeEN;
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
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDataNodeEN GetObjByDataNodeIdCache(long lngDataNodeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvDataNodeEN._CurrTabName);
List<clsvDataNodeEN> arrvDataNodeObjLstCache = GetObjLstCache();
IEnumerable <clsvDataNodeEN> arrvDataNodeObjLst_Sel =
from objvDataNodeEN in arrvDataNodeObjLstCache
where objvDataNodeEN.DataNodeId == lngDataNodeId 
select objvDataNodeEN;
if (arrvDataNodeObjLst_Sel.Count() == 0)
{
   clsvDataNodeEN obj = clsvDataNodeWApi.GetObjByDataNodeId(lngDataNodeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvDataNodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDataNodeNameByDataNodeIdCache(long lngDataNodeId)
{
//初始化列表缓存
List<clsvDataNodeEN> arrvDataNodeObjLstCache = GetObjLstCache();
IEnumerable <clsvDataNodeEN> arrvDataNodeObjLst_Sel1 =
from objvDataNodeEN in arrvDataNodeObjLstCache
where objvDataNodeEN.DataNodeId == lngDataNodeId 
select objvDataNodeEN;
List <clsvDataNodeEN> arrvDataNodeObjLst_Sel = new List<clsvDataNodeEN>();
foreach (clsvDataNodeEN obj in arrvDataNodeObjLst_Sel1)
{
arrvDataNodeObjLst_Sel.Add(obj);
}
if (arrvDataNodeObjLst_Sel.Count > 0)
{
return arrvDataNodeObjLst_Sel[0].DataNodeName;
}
string strErrMsgForGetObjById = string.Format("在vDataNode对象缓存列表中,找不到记录[DataNodeId = {0}](函数:{1})", lngDataNodeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvDataNodeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDataNodeIdCache(long lngDataNodeId)
{
//初始化列表缓存
List<clsvDataNodeEN> arrvDataNodeObjLstCache = GetObjLstCache();
IEnumerable <clsvDataNodeEN> arrvDataNodeObjLst_Sel1 =
from objvDataNodeEN in arrvDataNodeObjLstCache
where objvDataNodeEN.DataNodeId == lngDataNodeId 
select objvDataNodeEN;
List <clsvDataNodeEN> arrvDataNodeObjLst_Sel = new List<clsvDataNodeEN>();
foreach (clsvDataNodeEN obj in arrvDataNodeObjLst_Sel1)
{
arrvDataNodeObjLst_Sel.Add(obj);
}
if (arrvDataNodeObjLst_Sel.Count > 0)
{
return arrvDataNodeObjLst_Sel[0].DataNodeName;
}
string strErrMsgForGetObjById = string.Format("在vDataNode对象缓存列表中,找不到记录的相关名称[DataNodeId = {0}](函数:{1})", lngDataNodeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvDataNodeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataNodeEN> GetObjLst(string strWhereCond)
{
 List<clsvDataNodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNodeEN>>(strJson);
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
 /// <param name = "arrDataNodeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataNodeEN> GetObjLstByDataNodeIdLst(List<long> arrDataNodeId)
{
 List<clsvDataNodeEN> arrObjLst; 
string strAction = "GetObjLstByDataNodeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDataNodeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNodeEN>>(strJson);
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
 /// <param name = "arrDataNodeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvDataNodeEN> GetObjLstByDataNodeIdLstCache(List<long> arrDataNodeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvDataNodeEN._CurrTabName);
List<clsvDataNodeEN> arrvDataNodeObjLstCache = GetObjLstCache();
IEnumerable <clsvDataNodeEN> arrvDataNodeObjLst_Sel =
from objvDataNodeEN in arrvDataNodeObjLstCache
where arrDataNodeId.Contains(objvDataNodeEN.DataNodeId)
select objvDataNodeEN;
return arrvDataNodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataNodeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvDataNodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNodeEN>>(strJson);
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
public static List<clsvDataNodeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvDataNodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNodeEN>>(strJson);
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
public static List<clsvDataNodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvDataNodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNodeEN>>(strJson);
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
public static List<clsvDataNodeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvDataNodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNodeEN>>(strJson);
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
public static bool IsExist(long lngDataNodeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngDataNodeId"] = lngDataNodeId.ToString()
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
 /// <param name = "objvDataNodeENS">源对象</param>
 /// <param name = "objvDataNodeENT">目标对象</param>
 public static void CopyTo(clsvDataNodeEN objvDataNodeENS, clsvDataNodeEN objvDataNodeENT)
{
try
{
objvDataNodeENT.DataNodeId = objvDataNodeENS.DataNodeId; //数据结点Id
objvDataNodeENT.DataNodeName = objvDataNodeENS.DataNodeName; //数据结点名
objvDataNodeENT.TabId = objvDataNodeENS.TabId; //表ID
objvDataNodeENT.TabName = objvDataNodeENS.TabName; //表名
objvDataNodeENT.FldId = objvDataNodeENS.FldId; //字段Id
objvDataNodeENT.FldName = objvDataNodeENS.FldName; //字段名
objvDataNodeENT.VersionNo = objvDataNodeENS.VersionNo; //版本号
objvDataNodeENT.DataNodeTypeId = objvDataNodeENS.DataNodeTypeId; //数据结点类型Id
objvDataNodeENT.DataNodeTypeName = objvDataNodeENS.DataNodeTypeName; //数据结点类型名
objvDataNodeENT.SubGraphName = objvDataNodeENS.SubGraphName; //子图名
objvDataNodeENT.PrjId = objvDataNodeENS.PrjId; //工程Id
objvDataNodeENT.UpdDate = objvDataNodeENS.UpdDate; //修改日期
objvDataNodeENT.UpdUser = objvDataNodeENS.UpdUser; //修改者
objvDataNodeENT.Memo = objvDataNodeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvDataNodeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvDataNodeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvDataNodeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvDataNodeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvDataNodeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvDataNodeEN._AttributeName)
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
string strKey = string.Format("{0}", clsvDataNodeEN._CurrTabName);
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
public static List<clsvDataNodeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvDataNodeEN._CurrTabName;
List<clsvDataNodeEN> arrvDataNodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvDataNodeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvDataNodeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convDataNode.DataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(convDataNode.DataNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode.FldName, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convDataNode.DataNodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode.DataNodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode.SubGraphName, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode.Memo, Type.GetType("System.String"));
foreach (clsvDataNodeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convDataNode.DataNodeId] = objInFor[convDataNode.DataNodeId];
objDR[convDataNode.DataNodeName] = objInFor[convDataNode.DataNodeName];
objDR[convDataNode.TabId] = objInFor[convDataNode.TabId];
objDR[convDataNode.TabName] = objInFor[convDataNode.TabName];
objDR[convDataNode.FldId] = objInFor[convDataNode.FldId];
objDR[convDataNode.FldName] = objInFor[convDataNode.FldName];
objDR[convDataNode.VersionNo] = objInFor[convDataNode.VersionNo];
objDR[convDataNode.DataNodeTypeId] = objInFor[convDataNode.DataNodeTypeId];
objDR[convDataNode.DataNodeTypeName] = objInFor[convDataNode.DataNodeTypeName];
objDR[convDataNode.SubGraphName] = objInFor[convDataNode.SubGraphName];
objDR[convDataNode.PrjId] = objInFor[convDataNode.PrjId];
objDR[convDataNode.UpdDate] = objInFor[convDataNode.UpdDate];
objDR[convDataNode.UpdUser] = objInFor[convDataNode.UpdUser];
objDR[convDataNode.Memo] = objInFor[convDataNode.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}