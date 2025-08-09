
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataNodeWApi
 表名:DataNode(00050547)
 * 版本:2025.08.02.1(服务器:PYF-AI)
 日期:2025/08/10 01:34:08
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
public static class  clsDataNodeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "lngDataNodeId">数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetDataNodeId(this clsDataNodeEN objDataNodeEN, long lngDataNodeId, string strComparisonOp="")
	{
objDataNodeEN.DataNodeId = lngDataNodeId; //数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.DataNodeId) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.DataNodeId, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.DataNodeId] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataNodeName">数据结点名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetDataNodeName(this clsDataNodeEN objDataNodeEN, string strDataNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataNodeName, conDataNode.DataNodeName);
clsCheckSql.CheckFieldLen(strDataNodeName, 100, conDataNode.DataNodeName);
objDataNodeEN.DataNodeName = strDataNodeName; //数据结点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.DataNodeName) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.DataNodeName, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.DataNodeName] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetTabId(this clsDataNodeEN objDataNodeEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conDataNode.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, conDataNode.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conDataNode.TabId);
objDataNodeEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.TabId) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.TabId, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.TabId] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetFldId(this clsDataNodeEN objDataNodeEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, conDataNode.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, conDataNode.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conDataNode.FldId);
objDataNodeEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.FldId) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.FldId, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.FldId] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyFldLst">关键字段Id列表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetKeyFldLst(this clsDataNodeEN objDataNodeEN, string strKeyFldLst, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyFldLst, 100, conDataNode.KeyFldLst);
objDataNodeEN.KeyFldLst = strKeyFldLst; //关键字段Id列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.KeyFldLst) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.KeyFldLst, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.KeyFldLst] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intVersionNo">版本号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetVersionNo(this clsDataNodeEN objDataNodeEN, int intVersionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intVersionNo, conDataNode.VersionNo);
objDataNodeEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.VersionNo) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.VersionNo, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.VersionNo] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataNodeTypeId">数据结点类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetDataNodeTypeId(this clsDataNodeEN objDataNodeEN, string strDataNodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataNodeTypeId, conDataNode.DataNodeTypeId);
clsCheckSql.CheckFieldLen(strDataNodeTypeId, 2, conDataNode.DataNodeTypeId);
clsCheckSql.CheckFieldForeignKey(strDataNodeTypeId, 2, conDataNode.DataNodeTypeId);
objDataNodeEN.DataNodeTypeId = strDataNodeTypeId; //数据结点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.DataNodeTypeId) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.DataNodeTypeId, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.DataNodeTypeId] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intDepth">深度</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetDepth(this clsDataNodeEN objDataNodeEN, int intDepth, string strComparisonOp="")
	{
objDataNodeEN.Depth = intDepth; //深度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.Depth) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.Depth, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.Depth] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "lngPrevDataNodeId">前置数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetPrevDataNodeId(this clsDataNodeEN objDataNodeEN, long lngPrevDataNodeId, string strComparisonOp="")
	{
objDataNodeEN.PrevDataNodeId = lngPrevDataNodeId; //前置数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.PrevDataNodeId) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.PrevDataNodeId, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.PrevDataNodeId] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "lngNextDataNodeId">后继数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetNextDataNodeId(this clsDataNodeEN objDataNodeEN, long lngNextDataNodeId, string strComparisonOp="")
	{
objDataNodeEN.NextDataNodeId = lngNextDataNodeId; //后继数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.NextDataNodeId) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.NextDataNodeId, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.NextDataNodeId] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strSubGraphName">子图名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetSubGraphName(this clsDataNodeEN objDataNodeEN, string strSubGraphName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSubGraphName, 50, conDataNode.SubGraphName);
objDataNodeEN.SubGraphName = strSubGraphName; //子图名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.SubGraphName) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.SubGraphName, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.SubGraphName] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetErrMsg(this clsDataNodeEN objDataNodeEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conDataNode.ErrMsg);
objDataNodeEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.ErrMsg) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.ErrMsg, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.ErrMsg] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetPrjId(this clsDataNodeEN objDataNodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conDataNode.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conDataNode.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conDataNode.PrjId);
objDataNodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.PrjId) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.PrjId, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.PrjId] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "dblPosX">位置X</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetPosX(this clsDataNodeEN objDataNodeEN, double dblPosX, string strComparisonOp="")
	{
objDataNodeEN.PosX = dblPosX; //位置X
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.PosX) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.PosX, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.PosX] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "dblPosY">位置Y</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetPosY(this clsDataNodeEN objDataNodeEN, double dblPosY, string strComparisonOp="")
	{
objDataNodeEN.PosY = dblPosY; //位置Y
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.PosY) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.PosY, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.PosY] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intUsedTimes">使用次数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetUsedTimes(this clsDataNodeEN objDataNodeEN, int intUsedTimes, string strComparisonOp="")
	{
objDataNodeEN.UsedTimes = intUsedTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.UsedTimes) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.UsedTimes, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.UsedTimes] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetUpdDate(this clsDataNodeEN objDataNodeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conDataNode.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDataNode.UpdDate);
objDataNodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.UpdDate) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.UpdDate, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.UpdDate] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetUpdUser(this clsDataNodeEN objDataNodeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conDataNode.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDataNode.UpdUser);
objDataNodeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.UpdUser) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.UpdUser, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.UpdUser] = strComparisonOp;
}
}
return objDataNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeEN SetMemo(this clsDataNodeEN objDataNodeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDataNode.Memo);
objDataNodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeEN.dicFldComparisonOp.ContainsKey(conDataNode.Memo) == false)
{
objDataNodeEN.dicFldComparisonOp.Add(conDataNode.Memo, strComparisonOp);
}
else
{
objDataNodeEN.dicFldComparisonOp[conDataNode.Memo] = strComparisonOp;
}
}
return objDataNodeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDataNodeEN objDataNodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDataNodeCond.IsUpdated(conDataNode.DataNodeId) == true)
{
string strComparisonOpDataNodeId = objDataNodeCond.dicFldComparisonOp[conDataNode.DataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.DataNodeId, objDataNodeCond.DataNodeId, strComparisonOpDataNodeId);
}
if (objDataNodeCond.IsUpdated(conDataNode.DataNodeName) == true)
{
string strComparisonOpDataNodeName = objDataNodeCond.dicFldComparisonOp[conDataNode.DataNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.DataNodeName, objDataNodeCond.DataNodeName, strComparisonOpDataNodeName);
}
if (objDataNodeCond.IsUpdated(conDataNode.TabId) == true)
{
string strComparisonOpTabId = objDataNodeCond.dicFldComparisonOp[conDataNode.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.TabId, objDataNodeCond.TabId, strComparisonOpTabId);
}
if (objDataNodeCond.IsUpdated(conDataNode.FldId) == true)
{
string strComparisonOpFldId = objDataNodeCond.dicFldComparisonOp[conDataNode.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.FldId, objDataNodeCond.FldId, strComparisonOpFldId);
}
if (objDataNodeCond.IsUpdated(conDataNode.KeyFldLst) == true)
{
string strComparisonOpKeyFldLst = objDataNodeCond.dicFldComparisonOp[conDataNode.KeyFldLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.KeyFldLst, objDataNodeCond.KeyFldLst, strComparisonOpKeyFldLst);
}
if (objDataNodeCond.IsUpdated(conDataNode.VersionNo) == true)
{
string strComparisonOpVersionNo = objDataNodeCond.dicFldComparisonOp[conDataNode.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.VersionNo, objDataNodeCond.VersionNo, strComparisonOpVersionNo);
}
if (objDataNodeCond.IsUpdated(conDataNode.DataNodeTypeId) == true)
{
string strComparisonOpDataNodeTypeId = objDataNodeCond.dicFldComparisonOp[conDataNode.DataNodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.DataNodeTypeId, objDataNodeCond.DataNodeTypeId, strComparisonOpDataNodeTypeId);
}
if (objDataNodeCond.IsUpdated(conDataNode.Depth) == true)
{
string strComparisonOpDepth = objDataNodeCond.dicFldComparisonOp[conDataNode.Depth];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.Depth, objDataNodeCond.Depth, strComparisonOpDepth);
}
if (objDataNodeCond.IsUpdated(conDataNode.PrevDataNodeId) == true)
{
string strComparisonOpPrevDataNodeId = objDataNodeCond.dicFldComparisonOp[conDataNode.PrevDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.PrevDataNodeId, objDataNodeCond.PrevDataNodeId, strComparisonOpPrevDataNodeId);
}
if (objDataNodeCond.IsUpdated(conDataNode.NextDataNodeId) == true)
{
string strComparisonOpNextDataNodeId = objDataNodeCond.dicFldComparisonOp[conDataNode.NextDataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.NextDataNodeId, objDataNodeCond.NextDataNodeId, strComparisonOpNextDataNodeId);
}
if (objDataNodeCond.IsUpdated(conDataNode.SubGraphName) == true)
{
string strComparisonOpSubGraphName = objDataNodeCond.dicFldComparisonOp[conDataNode.SubGraphName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.SubGraphName, objDataNodeCond.SubGraphName, strComparisonOpSubGraphName);
}
if (objDataNodeCond.IsUpdated(conDataNode.ErrMsg) == true)
{
string strComparisonOpErrMsg = objDataNodeCond.dicFldComparisonOp[conDataNode.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.ErrMsg, objDataNodeCond.ErrMsg, strComparisonOpErrMsg);
}
if (objDataNodeCond.IsUpdated(conDataNode.PrjId) == true)
{
string strComparisonOpPrjId = objDataNodeCond.dicFldComparisonOp[conDataNode.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.PrjId, objDataNodeCond.PrjId, strComparisonOpPrjId);
}
if (objDataNodeCond.IsUpdated(conDataNode.PosX) == true)
{
string strComparisonOpPosX = objDataNodeCond.dicFldComparisonOp[conDataNode.PosX];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.PosX, objDataNodeCond.PosX, strComparisonOpPosX);
}
if (objDataNodeCond.IsUpdated(conDataNode.PosY) == true)
{
string strComparisonOpPosY = objDataNodeCond.dicFldComparisonOp[conDataNode.PosY];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.PosY, objDataNodeCond.PosY, strComparisonOpPosY);
}
if (objDataNodeCond.IsUpdated(conDataNode.UsedTimes) == true)
{
string strComparisonOpUsedTimes = objDataNodeCond.dicFldComparisonOp[conDataNode.UsedTimes];
strWhereCond += string.Format(" And {0} {2} {1}", conDataNode.UsedTimes, objDataNodeCond.UsedTimes, strComparisonOpUsedTimes);
}
if (objDataNodeCond.IsUpdated(conDataNode.UpdDate) == true)
{
string strComparisonOpUpdDate = objDataNodeCond.dicFldComparisonOp[conDataNode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.UpdDate, objDataNodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objDataNodeCond.IsUpdated(conDataNode.UpdUser) == true)
{
string strComparisonOpUpdUser = objDataNodeCond.dicFldComparisonOp[conDataNode.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.UpdUser, objDataNodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objDataNodeCond.IsUpdated(conDataNode.Memo) == true)
{
string strComparisonOpMemo = objDataNodeCond.dicFldComparisonOp[conDataNode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNode.Memo, objDataNodeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataNodeEN objDataNodeEN)
{
 if (objDataNodeEN.DataNodeId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDataNodeEN.sfUpdFldSetStr = objDataNodeEN.getsfUpdFldSetStr();
clsDataNodeWApi.CheckPropertyNew(objDataNodeEN); 
bool bolResult = clsDataNodeWApi.UpdateRecord(objDataNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeWApi.ReFreshCache(objDataNodeEN.PrjId);
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
 /// 获取唯一性条件串--DataNode(数据结点), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabId_FldId_KeyFldLst_VersionNo
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDataNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsDataNodeEN objDataNodeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDataNodeEN == null) return "";
if (objDataNodeEN.DataNodeId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objDataNodeEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objDataNodeEN.FldId);
 sbCondition.AppendFormat(" and KeyFldLst = '{0}'", objDataNodeEN.KeyFldLst);
 sbCondition.AppendFormat(" and VersionNo = '{0}'", objDataNodeEN.VersionNo);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DataNodeId !=  {0}", objDataNodeEN.DataNodeId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objDataNodeEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objDataNodeEN.FldId);
 sbCondition.AppendFormat(" and KeyFldLst = '{0}'", objDataNodeEN.KeyFldLst);
 sbCondition.AppendFormat(" and VersionNo = '{0}'", objDataNodeEN.VersionNo);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDataNodeEN objDataNodeEN)
{
try
{
clsDataNodeWApi.CheckPropertyNew(objDataNodeEN); 
bool bolResult = clsDataNodeWApi.AddNewRecord(objDataNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeWApi.ReFreshCache(objDataNodeEN.PrjId);
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objDataNodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataNodeEN objDataNodeEN, string strWhereCond)
{
try
{
clsDataNodeWApi.CheckPropertyNew(objDataNodeEN); 
bool bolResult = clsDataNodeWApi.UpdateWithCondition(objDataNodeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeWApi.ReFreshCache(objDataNodeEN.PrjId);
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
 /// 数据结点(DataNode)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDataNodeWApi
{
private static readonly string mstrApiControllerName = "DataNodeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsDataNodeWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据结点]...","0");
List<clsDataNodeEN> arrObjLst = GetObjLst("1=1");
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

 /// <param name = "strPrjId"></param>
public static void BindCbo_DataNodeId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDataNode.DataNodeId); 
List<clsDataNodeEN> arrObjLst = clsDataNodeWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsDataNodeEN objDataNodeEN = new clsDataNodeEN()
{
DataNodeId = 0,
DataNodeName = "选[数据结点]..."
};
arrObjLstSel.Insert(0, objDataNodeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conDataNode.DataNodeId;
objComboBox.DisplayMember = conDataNode.DataNodeName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDataNodeEN objDataNodeEN)
{
if (!Object.Equals(null, objDataNodeEN.DataNodeName) && GetStrLen(objDataNodeEN.DataNodeName) > 100)
{
 throw new Exception("字段[数据结点名]的长度不能超过100!");
}
if (!Object.Equals(null, objDataNodeEN.TabId) && GetStrLen(objDataNodeEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objDataNodeEN.FldId) && GetStrLen(objDataNodeEN.FldId) > 8)
{
 throw new Exception("字段[字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDataNodeEN.KeyFldLst) && GetStrLen(objDataNodeEN.KeyFldLst) > 100)
{
 throw new Exception("字段[关键字段Id列表]的长度不能超过100!");
}
if (!Object.Equals(null, objDataNodeEN.DataNodeTypeId) && GetStrLen(objDataNodeEN.DataNodeTypeId) > 2)
{
 throw new Exception("字段[数据结点类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objDataNodeEN.SubGraphName) && GetStrLen(objDataNodeEN.SubGraphName) > 50)
{
 throw new Exception("字段[子图名]的长度不能超过50!");
}
if (!Object.Equals(null, objDataNodeEN.ErrMsg) && GetStrLen(objDataNodeEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objDataNodeEN.PrjId) && GetStrLen(objDataNodeEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objDataNodeEN.UpdDate) && GetStrLen(objDataNodeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objDataNodeEN.UpdUser) && GetStrLen(objDataNodeEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objDataNodeEN.Memo) && GetStrLen(objDataNodeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objDataNodeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngDataNodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataNodeEN GetObjByDataNodeId(long lngDataNodeId)
{
if (lngDataNodeId == 0) return null;
string strAction = "GetObjByDataNodeId";
clsDataNodeEN objDataNodeEN;
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
objDataNodeEN = JsonConvert.DeserializeObject<clsDataNodeEN>(strJson);
return objDataNodeEN;
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
public static clsDataNodeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsDataNodeEN objDataNodeEN;
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
objDataNodeEN = JsonConvert.DeserializeObject<clsDataNodeEN>(strJson);
return objDataNodeEN;
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
public static clsDataNodeEN GetObjByDataNodeIdCache(long lngDataNodeId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsDataNodeEN._CurrTabName, strPrjId);
List<clsDataNodeEN> arrDataNodeObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDataNodeEN> arrDataNodeObjLst_Sel =
from objDataNodeEN in arrDataNodeObjLstCache
where objDataNodeEN.DataNodeId == lngDataNodeId 
select objDataNodeEN;
if (arrDataNodeObjLst_Sel.Count() == 0)
{
   clsDataNodeEN obj = clsDataNodeWApi.GetObjByDataNodeId(lngDataNodeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDataNodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDataNodeNameByDataNodeIdCache(long lngDataNodeId,string strPrjId)
{
//初始化列表缓存
List<clsDataNodeEN> arrDataNodeObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDataNodeEN> arrDataNodeObjLst_Sel1 =
from objDataNodeEN in arrDataNodeObjLstCache
where objDataNodeEN.DataNodeId == lngDataNodeId 
select objDataNodeEN;
List <clsDataNodeEN> arrDataNodeObjLst_Sel = new List<clsDataNodeEN>();
foreach (clsDataNodeEN obj in arrDataNodeObjLst_Sel1)
{
arrDataNodeObjLst_Sel.Add(obj);
}
if (arrDataNodeObjLst_Sel.Count > 0)
{
return arrDataNodeObjLst_Sel[0].DataNodeName;
}
string strErrMsgForGetObjById = string.Format("在DataNode对象缓存列表中,找不到记录[DataNodeId = {0}](函数:{1})", lngDataNodeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsDataNodeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDataNodeIdCache(long lngDataNodeId,string strPrjId)
{
//初始化列表缓存
List<clsDataNodeEN> arrDataNodeObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDataNodeEN> arrDataNodeObjLst_Sel1 =
from objDataNodeEN in arrDataNodeObjLstCache
where objDataNodeEN.DataNodeId == lngDataNodeId 
select objDataNodeEN;
List <clsDataNodeEN> arrDataNodeObjLst_Sel = new List<clsDataNodeEN>();
foreach (clsDataNodeEN obj in arrDataNodeObjLst_Sel1)
{
arrDataNodeObjLst_Sel.Add(obj);
}
if (arrDataNodeObjLst_Sel.Count > 0)
{
return arrDataNodeObjLst_Sel[0].DataNodeName;
}
string strErrMsgForGetObjById = string.Format("在DataNode对象缓存列表中,找不到记录的相关名称[DataNodeId = {0}](函数:{1})", lngDataNodeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsDataNodeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeEN> GetObjLst(string strWhereCond)
{
 List<clsDataNodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeEN>>(strJson);
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
public static List<clsDataNodeEN> GetObjLstByDataNodeIdLst(List<long> arrDataNodeId)
{
 List<clsDataNodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeEN>>(strJson);
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
public static IEnumerable<clsDataNodeEN> GetObjLstByDataNodeIdLstCache(List<long> arrDataNodeId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsDataNodeEN._CurrTabName, strPrjId);
List<clsDataNodeEN> arrDataNodeObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDataNodeEN> arrDataNodeObjLst_Sel =
from objDataNodeEN in arrDataNodeObjLstCache
where arrDataNodeId.Contains(objDataNodeEN.DataNodeId)
select objDataNodeEN;
return arrDataNodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDataNodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeEN>>(strJson);
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
public static List<clsDataNodeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDataNodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeEN>>(strJson);
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
public static List<clsDataNodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDataNodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeEN>>(strJson);
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
public static List<clsDataNodeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsDataNodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeEN>>(strJson);
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
public static int DelRecord(long lngDataNodeId)
{
string strAction = "DelRecord";
try
{
 clsDataNodeEN objDataNodeEN = clsDataNodeWApi.GetObjByDataNodeId(lngDataNodeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngDataNodeId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDataNodeWApi.ReFreshCache(objDataNodeEN.PrjId);
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
public static int DelDataNodes(List<string> arrDataNodeId)
{
string strAction = "DelDataNodes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDataNodeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsDataNodeEN objDataNodeEN = clsDataNodeWApi.GetObjByDataNodeId(long.Parse(arrDataNodeId[0]));
clsDataNodeWApi.ReFreshCache(objDataNodeEN.PrjId);
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
public static int DelDataNodesByCond(string strWhereCond)
{
string strAction = "DelDataNodesByCond";
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
public static bool AddNewRecord(clsDataNodeEN objDataNodeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataNodeEN>(objDataNodeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeWApi.ReFreshCache(objDataNodeEN.PrjId);
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objDataNodeEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsDataNodeEN objDataNodeEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataNodeEN>(objDataNodeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeWApi.ReFreshCache(objDataNodeEN.PrjId);
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsDataNodeEN objDataNodeEN)
{
if (string.IsNullOrEmpty(objDataNodeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDataNodeEN.DataNodeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataNodeEN>(objDataNodeEN);
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
 /// <param name = "objDataNodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDataNodeEN objDataNodeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDataNodeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDataNodeEN.DataNodeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDataNodeEN.DataNodeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataNodeEN>(objDataNodeEN);
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
 /// <param name = "objDataNodeENS">源对象</param>
 /// <param name = "objDataNodeENT">目标对象</param>
 public static void CopyTo(clsDataNodeEN objDataNodeENS, clsDataNodeEN objDataNodeENT)
{
try
{
objDataNodeENT.DataNodeId = objDataNodeENS.DataNodeId; //数据结点Id
objDataNodeENT.DataNodeName = objDataNodeENS.DataNodeName; //数据结点名
objDataNodeENT.TabId = objDataNodeENS.TabId; //表ID
objDataNodeENT.FldId = objDataNodeENS.FldId; //字段Id
objDataNodeENT.KeyFldLst = objDataNodeENS.KeyFldLst; //关键字段Id列表
objDataNodeENT.VersionNo = objDataNodeENS.VersionNo; //版本号
objDataNodeENT.DataNodeTypeId = objDataNodeENS.DataNodeTypeId; //数据结点类型Id
objDataNodeENT.Depth = objDataNodeENS.Depth; //深度
objDataNodeENT.PrevDataNodeId = objDataNodeENS.PrevDataNodeId; //前置数据结点Id
objDataNodeENT.NextDataNodeId = objDataNodeENS.NextDataNodeId; //后继数据结点Id
objDataNodeENT.SubGraphName = objDataNodeENS.SubGraphName; //子图名
objDataNodeENT.ErrMsg = objDataNodeENS.ErrMsg; //错误信息
objDataNodeENT.PrjId = objDataNodeENS.PrjId; //工程Id
objDataNodeENT.PosX = objDataNodeENS.PosX; //位置X
objDataNodeENT.PosY = objDataNodeENS.PosY; //位置Y
objDataNodeENT.UsedTimes = objDataNodeENS.UsedTimes; //使用次数
objDataNodeENT.UpdDate = objDataNodeENS.UpdDate; //修改日期
objDataNodeENT.UpdUser = objDataNodeENS.UpdUser; //修改者
objDataNodeENT.Memo = objDataNodeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsDataNodeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDataNodeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDataNodeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDataNodeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDataNodeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDataNodeEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsDataNodeWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsDataNodeWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsDataNodeEN._CurrTabName, strPrjId);
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
if (clsDataNodeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsDataNodeEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDataNodeWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataNodeEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsDataNodeWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsDataNodeWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsDataNodeEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsDataNodeEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conDataNode.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsDataNodeEN._CurrTabName, strPrjId);
List<clsDataNodeEN> arrDataNodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrDataNodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataNodeEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsDataNodeEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsDataNodeWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsDataNodeWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsDataNodeEN._CurrTabName, strPrjId);
List<clsDataNodeEN> arrDataNodeObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrDataNodeObjLstCache = CacheHelper.Get<List<clsDataNodeEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrDataNodeObjLstCache = CacheHelper.Get<List<clsDataNodeEN>>(strKey);
}
return arrDataNodeObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDataNodeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDataNode.DataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(conDataNode.DataNodeName, Type.GetType("System.String"));
objDT.Columns.Add(conDataNode.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conDataNode.FldId, Type.GetType("System.String"));
objDT.Columns.Add(conDataNode.KeyFldLst, Type.GetType("System.String"));
objDT.Columns.Add(conDataNode.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(conDataNode.DataNodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conDataNode.Depth, Type.GetType("System.Int32"));
objDT.Columns.Add(conDataNode.PrevDataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(conDataNode.NextDataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(conDataNode.SubGraphName, Type.GetType("System.String"));
objDT.Columns.Add(conDataNode.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conDataNode.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conDataNode.PosX, Type.GetType("System.Decimal"));
objDT.Columns.Add(conDataNode.PosY, Type.GetType("System.Decimal"));
objDT.Columns.Add(conDataNode.UsedTimes, Type.GetType("System.Int32"));
objDT.Columns.Add(conDataNode.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conDataNode.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conDataNode.Memo, Type.GetType("System.String"));
foreach (clsDataNodeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDataNode.DataNodeId] = objInFor[conDataNode.DataNodeId];
objDR[conDataNode.DataNodeName] = objInFor[conDataNode.DataNodeName];
objDR[conDataNode.TabId] = objInFor[conDataNode.TabId];
objDR[conDataNode.FldId] = objInFor[conDataNode.FldId];
objDR[conDataNode.KeyFldLst] = objInFor[conDataNode.KeyFldLst];
objDR[conDataNode.VersionNo] = objInFor[conDataNode.VersionNo];
objDR[conDataNode.DataNodeTypeId] = objInFor[conDataNode.DataNodeTypeId];
objDR[conDataNode.Depth] = objInFor[conDataNode.Depth];
objDR[conDataNode.PrevDataNodeId] = objInFor[conDataNode.PrevDataNodeId];
objDR[conDataNode.NextDataNodeId] = objInFor[conDataNode.NextDataNodeId];
objDR[conDataNode.SubGraphName] = objInFor[conDataNode.SubGraphName];
objDR[conDataNode.ErrMsg] = objInFor[conDataNode.ErrMsg];
objDR[conDataNode.PrjId] = objInFor[conDataNode.PrjId];
objDR[conDataNode.PosX] = objInFor[conDataNode.PosX];
objDR[conDataNode.PosY] = objInFor[conDataNode.PosY];
objDR[conDataNode.UsedTimes] = objInFor[conDataNode.UsedTimes];
objDR[conDataNode.UpdDate] = objInFor[conDataNode.UpdDate];
objDR[conDataNode.UpdUser] = objInFor[conDataNode.UpdUser];
objDR[conDataNode.Memo] = objInFor[conDataNode.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 数据结点(DataNode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4DataNode : clsCommFun4BLV2
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
clsDataNodeWApi.ReFreshThisCache(strPrjId);
}
}

}