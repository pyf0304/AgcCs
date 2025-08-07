
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDataNode_SimBL
 表名:vDataNode_Sim(00050592)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:26:51
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
public static class  clsvDataNode_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngDataNodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDataNode_SimEN GetObj(this K_DataNodeId_vDataNode_Sim myKey)
{
clsvDataNode_SimEN objvDataNode_SimEN = clsvDataNode_SimBL.vDataNode_SimDA.GetObjByDataNodeId(myKey.Value);
return objvDataNode_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetDataNodeId(this clsvDataNode_SimEN objvDataNode_SimEN, long lngDataNodeId, string strComparisonOp="")
	{
objvDataNode_SimEN.DataNodeId = lngDataNodeId; //数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.DataNodeId) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.DataNodeId, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.DataNodeId] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetDataNodeName(this clsvDataNode_SimEN objvDataNode_SimEN, string strDataNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataNodeName, 100, convDataNode_Sim.DataNodeName);
}
objvDataNode_SimEN.DataNodeName = strDataNodeName; //数据结点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.DataNodeName) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.DataNodeName, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.DataNodeName] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetTabId(this clsvDataNode_SimEN objvDataNode_SimEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convDataNode_Sim.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convDataNode_Sim.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convDataNode_Sim.TabId);
}
objvDataNode_SimEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.TabId) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.TabId, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.TabId] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetFldId(this clsvDataNode_SimEN objvDataNode_SimEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convDataNode_Sim.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convDataNode_Sim.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convDataNode_Sim.FldId);
}
objvDataNode_SimEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.FldId) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.FldId, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.FldId] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetKeyFldLst(this clsvDataNode_SimEN objvDataNode_SimEN, string strKeyFldLst, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyFldLst, 100, convDataNode_Sim.KeyFldLst);
}
objvDataNode_SimEN.KeyFldLst = strKeyFldLst; //关键字段Id列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.KeyFldLst) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.KeyFldLst, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.KeyFldLst] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetDataNodeTypeId(this clsvDataNode_SimEN objvDataNode_SimEN, string strDataNodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataNodeTypeId, convDataNode_Sim.DataNodeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataNodeTypeId, 2, convDataNode_Sim.DataNodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataNodeTypeId, 2, convDataNode_Sim.DataNodeTypeId);
}
objvDataNode_SimEN.DataNodeTypeId = strDataNodeTypeId; //数据结点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.DataNodeTypeId) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.DataNodeTypeId, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.DataNodeTypeId] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetVersionNo(this clsvDataNode_SimEN objvDataNode_SimEN, int? intVersionNo, string strComparisonOp="")
	{
objvDataNode_SimEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.VersionNo) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.VersionNo, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.VersionNo] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetPrjId(this clsvDataNode_SimEN objvDataNode_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convDataNode_Sim.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convDataNode_Sim.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDataNode_Sim.PrjId);
}
objvDataNode_SimEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.PrjId) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.PrjId, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.PrjId] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetPosX(this clsvDataNode_SimEN objvDataNode_SimEN, double? dblPosX, string strComparisonOp="")
	{
objvDataNode_SimEN.PosX = dblPosX; //位置X
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.PosX) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.PosX, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.PosX] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetPosY(this clsvDataNode_SimEN objvDataNode_SimEN, double? dblPosY, string strComparisonOp="")
	{
objvDataNode_SimEN.PosY = dblPosY; //位置Y
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.PosY) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.PosY, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.PosY] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetUsedTimes(this clsvDataNode_SimEN objvDataNode_SimEN, int? intUsedTimes, string strComparisonOp="")
	{
objvDataNode_SimEN.UsedTimes = intUsedTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.UsedTimes) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.UsedTimes, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.UsedTimes] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvDataNode_SimENS">源对象</param>
 /// <param name = "objvDataNode_SimENT">目标对象</param>
 public static void CopyTo(this clsvDataNode_SimEN objvDataNode_SimENS, clsvDataNode_SimEN objvDataNode_SimENT)
{
try
{
objvDataNode_SimENT.DataNodeId = objvDataNode_SimENS.DataNodeId; //数据结点Id
objvDataNode_SimENT.DataNodeName = objvDataNode_SimENS.DataNodeName; //数据结点名
objvDataNode_SimENT.TabId = objvDataNode_SimENS.TabId; //表ID
objvDataNode_SimENT.FldId = objvDataNode_SimENS.FldId; //字段Id
objvDataNode_SimENT.KeyFldLst = objvDataNode_SimENS.KeyFldLst; //关键字段Id列表
objvDataNode_SimENT.DataNodeTypeId = objvDataNode_SimENS.DataNodeTypeId; //数据结点类型Id
objvDataNode_SimENT.VersionNo = objvDataNode_SimENS.VersionNo; //版本号
objvDataNode_SimENT.PrjId = objvDataNode_SimENS.PrjId; //工程Id
objvDataNode_SimENT.PosX = objvDataNode_SimENS.PosX; //位置X
objvDataNode_SimENT.PosY = objvDataNode_SimENS.PosY; //位置Y
objvDataNode_SimENT.UsedTimes = objvDataNode_SimENS.UsedTimes; //使用次数
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
 /// <param name = "objvDataNode_SimENS">源对象</param>
 /// <returns>目标对象=>clsvDataNode_SimEN:objvDataNode_SimENT</returns>
 public static clsvDataNode_SimEN CopyTo(this clsvDataNode_SimEN objvDataNode_SimENS)
{
try
{
 clsvDataNode_SimEN objvDataNode_SimENT = new clsvDataNode_SimEN()
{
DataNodeId = objvDataNode_SimENS.DataNodeId, //数据结点Id
DataNodeName = objvDataNode_SimENS.DataNodeName, //数据结点名
TabId = objvDataNode_SimENS.TabId, //表ID
FldId = objvDataNode_SimENS.FldId, //字段Id
KeyFldLst = objvDataNode_SimENS.KeyFldLst, //关键字段Id列表
DataNodeTypeId = objvDataNode_SimENS.DataNodeTypeId, //数据结点类型Id
VersionNo = objvDataNode_SimENS.VersionNo, //版本号
PrjId = objvDataNode_SimENS.PrjId, //工程Id
PosX = objvDataNode_SimENS.PosX, //位置X
PosY = objvDataNode_SimENS.PosY, //位置Y
UsedTimes = objvDataNode_SimENS.UsedTimes, //使用次数
};
 return objvDataNode_SimENT;
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
public static void CheckProperty4Condition(this clsvDataNode_SimEN objvDataNode_SimEN)
{
 clsvDataNode_SimBL.vDataNode_SimDA.CheckProperty4Condition(objvDataNode_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDataNode_SimEN objvDataNode_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.DataNodeId) == true)
{
string strComparisonOpDataNodeId = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.DataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", convDataNode_Sim.DataNodeId, objvDataNode_SimCond.DataNodeId, strComparisonOpDataNodeId);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.DataNodeName) == true)
{
string strComparisonOpDataNodeName = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.DataNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode_Sim.DataNodeName, objvDataNode_SimCond.DataNodeName, strComparisonOpDataNodeName);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.TabId) == true)
{
string strComparisonOpTabId = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode_Sim.TabId, objvDataNode_SimCond.TabId, strComparisonOpTabId);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.FldId) == true)
{
string strComparisonOpFldId = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode_Sim.FldId, objvDataNode_SimCond.FldId, strComparisonOpFldId);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.KeyFldLst) == true)
{
string strComparisonOpKeyFldLst = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.KeyFldLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode_Sim.KeyFldLst, objvDataNode_SimCond.KeyFldLst, strComparisonOpKeyFldLst);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.DataNodeTypeId) == true)
{
string strComparisonOpDataNodeTypeId = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.DataNodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode_Sim.DataNodeTypeId, objvDataNode_SimCond.DataNodeTypeId, strComparisonOpDataNodeTypeId);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.VersionNo) == true)
{
string strComparisonOpVersionNo = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convDataNode_Sim.VersionNo, objvDataNode_SimCond.VersionNo, strComparisonOpVersionNo);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.PrjId) == true)
{
string strComparisonOpPrjId = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode_Sim.PrjId, objvDataNode_SimCond.PrjId, strComparisonOpPrjId);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.PosX) == true)
{
string strComparisonOpPosX = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.PosX];
strWhereCond += string.Format(" And {0} {2} {1}", convDataNode_Sim.PosX, objvDataNode_SimCond.PosX, strComparisonOpPosX);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.PosY) == true)
{
string strComparisonOpPosY = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.PosY];
strWhereCond += string.Format(" And {0} {2} {1}", convDataNode_Sim.PosY, objvDataNode_SimCond.PosY, strComparisonOpPosY);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.UsedTimes) == true)
{
string strComparisonOpUsedTimes = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.UsedTimes];
strWhereCond += string.Format(" And {0} {2} {1}", convDataNode_Sim.UsedTimes, objvDataNode_SimCond.UsedTimes, strComparisonOpUsedTimes);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vDataNode_Sim
{
public virtual bool UpdRelaTabDate(long lngDataNodeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vDataNode_Sim(vDataNode_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvDataNode_SimBL
{
public static RelatedActions_vDataNode_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvDataNode_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvDataNode_SimDA vDataNode_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvDataNode_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvDataNode_SimBL()
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
if (string.IsNullOrEmpty(clsvDataNode_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDataNode_SimEN._ConnectString);
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
public static DataTable GetDataTable_vDataNode_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vDataNode_SimDA.GetDataTable_vDataNode_Sim(strWhereCond);
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
objDT = vDataNode_SimDA.GetDataTable(strWhereCond);
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
objDT = vDataNode_SimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vDataNode_SimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vDataNode_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vDataNode_SimDA.GetDataTable_Top(objTopPara);
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
objDT = vDataNode_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vDataNode_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vDataNode_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDataNodeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvDataNode_SimEN> GetObjLstByDataNodeIdLst(List<long> arrDataNodeIdLst)
{
List<clsvDataNode_SimEN> arrObjLst = new List<clsvDataNode_SimEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDataNodeIdLst);
 string strWhereCond = string.Format("DataNodeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN();
try
{
objvDataNode_SimEN.DataNodeId = Int32.Parse(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNode_SimEN.DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名
objvDataNode_SimEN.TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(); //表ID
objvDataNode_SimEN.FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(); //字段Id
objvDataNode_SimEN.KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表
objvDataNode_SimEN.DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNode_SimEN.VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.VersionNo].ToString().Trim()); //版本号
objvDataNode_SimEN.PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(); //工程Id
objvDataNode_SimEN.PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosX].ToString().Trim()); //位置X
objvDataNode_SimEN.PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosY].ToString().Trim()); //位置Y
objvDataNode_SimEN.UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNode_SimEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNode_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDataNodeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvDataNode_SimEN> GetObjLstByDataNodeIdLstCache(List<long> arrDataNodeIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvDataNode_SimEN._CurrTabName, strPrjId);
List<clsvDataNode_SimEN> arrvDataNode_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDataNode_SimEN> arrvDataNode_SimObjLst_Sel =
arrvDataNode_SimObjLstCache
.Where(x => arrDataNodeIdLst.Contains(x.DataNodeId));
return arrvDataNode_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataNode_SimEN> GetObjLst(string strWhereCond)
{
List<clsvDataNode_SimEN> arrObjLst = new List<clsvDataNode_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN();
try
{
objvDataNode_SimEN.DataNodeId = Int32.Parse(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNode_SimEN.DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名
objvDataNode_SimEN.TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(); //表ID
objvDataNode_SimEN.FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(); //字段Id
objvDataNode_SimEN.KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表
objvDataNode_SimEN.DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNode_SimEN.VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.VersionNo].ToString().Trim()); //版本号
objvDataNode_SimEN.PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(); //工程Id
objvDataNode_SimEN.PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosX].ToString().Trim()); //位置X
objvDataNode_SimEN.PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosY].ToString().Trim()); //位置Y
objvDataNode_SimEN.UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNode_SimEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNode_SimEN);
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
public static List<clsvDataNode_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvDataNode_SimEN> arrObjLst = new List<clsvDataNode_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN();
try
{
objvDataNode_SimEN.DataNodeId = Int32.Parse(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNode_SimEN.DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名
objvDataNode_SimEN.TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(); //表ID
objvDataNode_SimEN.FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(); //字段Id
objvDataNode_SimEN.KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表
objvDataNode_SimEN.DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNode_SimEN.VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.VersionNo].ToString().Trim()); //版本号
objvDataNode_SimEN.PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(); //工程Id
objvDataNode_SimEN.PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosX].ToString().Trim()); //位置X
objvDataNode_SimEN.PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosY].ToString().Trim()); //位置Y
objvDataNode_SimEN.UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNode_SimEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNode_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvDataNode_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvDataNode_SimEN> GetSubObjLstCache(clsvDataNode_SimEN objvDataNode_SimCond)
{
 string strPrjId = objvDataNode_SimCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvDataNode_SimBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvDataNode_SimEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDataNode_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDataNode_Sim._AttributeName)
{
if (objvDataNode_SimCond.IsUpdated(strFldName) == false) continue;
if (objvDataNode_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDataNode_SimCond[strFldName].ToString());
}
else
{
if (objvDataNode_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDataNode_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDataNode_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDataNode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDataNode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDataNode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDataNode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDataNode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDataNode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDataNode_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDataNode_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDataNode_SimCond[strFldName]));
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
public static List<clsvDataNode_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvDataNode_SimEN> arrObjLst = new List<clsvDataNode_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN();
try
{
objvDataNode_SimEN.DataNodeId = Int32.Parse(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNode_SimEN.DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名
objvDataNode_SimEN.TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(); //表ID
objvDataNode_SimEN.FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(); //字段Id
objvDataNode_SimEN.KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表
objvDataNode_SimEN.DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNode_SimEN.VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.VersionNo].ToString().Trim()); //版本号
objvDataNode_SimEN.PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(); //工程Id
objvDataNode_SimEN.PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosX].ToString().Trim()); //位置X
objvDataNode_SimEN.PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosY].ToString().Trim()); //位置Y
objvDataNode_SimEN.UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNode_SimEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNode_SimEN);
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
public static List<clsvDataNode_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvDataNode_SimEN> arrObjLst = new List<clsvDataNode_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN();
try
{
objvDataNode_SimEN.DataNodeId = Int32.Parse(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNode_SimEN.DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名
objvDataNode_SimEN.TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(); //表ID
objvDataNode_SimEN.FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(); //字段Id
objvDataNode_SimEN.KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表
objvDataNode_SimEN.DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNode_SimEN.VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.VersionNo].ToString().Trim()); //版本号
objvDataNode_SimEN.PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(); //工程Id
objvDataNode_SimEN.PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosX].ToString().Trim()); //位置X
objvDataNode_SimEN.PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosY].ToString().Trim()); //位置Y
objvDataNode_SimEN.UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNode_SimEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNode_SimEN);
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
List<clsvDataNode_SimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvDataNode_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataNode_SimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvDataNode_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvDataNode_SimEN> arrObjLst = new List<clsvDataNode_SimEN>(); 
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
	clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN();
try
{
objvDataNode_SimEN.DataNodeId = Int32.Parse(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNode_SimEN.DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名
objvDataNode_SimEN.TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(); //表ID
objvDataNode_SimEN.FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(); //字段Id
objvDataNode_SimEN.KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表
objvDataNode_SimEN.DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNode_SimEN.VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.VersionNo].ToString().Trim()); //版本号
objvDataNode_SimEN.PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(); //工程Id
objvDataNode_SimEN.PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosX].ToString().Trim()); //位置X
objvDataNode_SimEN.PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosY].ToString().Trim()); //位置Y
objvDataNode_SimEN.UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNode_SimEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNode_SimEN);
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
public static List<clsvDataNode_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvDataNode_SimEN> arrObjLst = new List<clsvDataNode_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN();
try
{
objvDataNode_SimEN.DataNodeId = Int32.Parse(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNode_SimEN.DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名
objvDataNode_SimEN.TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(); //表ID
objvDataNode_SimEN.FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(); //字段Id
objvDataNode_SimEN.KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表
objvDataNode_SimEN.DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNode_SimEN.VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.VersionNo].ToString().Trim()); //版本号
objvDataNode_SimEN.PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(); //工程Id
objvDataNode_SimEN.PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosX].ToString().Trim()); //位置X
objvDataNode_SimEN.PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosY].ToString().Trim()); //位置Y
objvDataNode_SimEN.UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNode_SimEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNode_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvDataNode_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvDataNode_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvDataNode_SimEN> arrObjLst = new List<clsvDataNode_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN();
try
{
objvDataNode_SimEN.DataNodeId = Int32.Parse(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNode_SimEN.DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名
objvDataNode_SimEN.TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(); //表ID
objvDataNode_SimEN.FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(); //字段Id
objvDataNode_SimEN.KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表
objvDataNode_SimEN.DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNode_SimEN.VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.VersionNo].ToString().Trim()); //版本号
objvDataNode_SimEN.PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(); //工程Id
objvDataNode_SimEN.PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosX].ToString().Trim()); //位置X
objvDataNode_SimEN.PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosY].ToString().Trim()); //位置Y
objvDataNode_SimEN.UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNode_SimEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNode_SimEN);
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
public static List<clsvDataNode_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvDataNode_SimEN> arrObjLst = new List<clsvDataNode_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN();
try
{
objvDataNode_SimEN.DataNodeId = Int32.Parse(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNode_SimEN.DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名
objvDataNode_SimEN.TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(); //表ID
objvDataNode_SimEN.FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(); //字段Id
objvDataNode_SimEN.KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表
objvDataNode_SimEN.DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNode_SimEN.VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.VersionNo].ToString().Trim()); //版本号
objvDataNode_SimEN.PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(); //工程Id
objvDataNode_SimEN.PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosX].ToString().Trim()); //位置X
objvDataNode_SimEN.PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosY].ToString().Trim()); //位置Y
objvDataNode_SimEN.UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNode_SimEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNode_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataNode_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvDataNode_SimEN> arrObjLst = new List<clsvDataNode_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN();
try
{
objvDataNode_SimEN.DataNodeId = Int32.Parse(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNode_SimEN.DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名
objvDataNode_SimEN.TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(); //表ID
objvDataNode_SimEN.FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(); //字段Id
objvDataNode_SimEN.KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表
objvDataNode_SimEN.DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNode_SimEN.VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.VersionNo].ToString().Trim()); //版本号
objvDataNode_SimEN.PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(); //工程Id
objvDataNode_SimEN.PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosX].ToString().Trim()); //位置X
objvDataNode_SimEN.PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosY].ToString().Trim()); //位置Y
objvDataNode_SimEN.UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNode_SimEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNode_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvDataNode_Sim(ref clsvDataNode_SimEN objvDataNode_SimEN)
{
bool bolResult = vDataNode_SimDA.GetvDataNode_Sim(ref objvDataNode_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngDataNodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDataNode_SimEN GetObjByDataNodeId(long lngDataNodeId)
{
clsvDataNode_SimEN objvDataNode_SimEN = vDataNode_SimDA.GetObjByDataNodeId(lngDataNodeId);
return objvDataNode_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvDataNode_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvDataNode_SimEN objvDataNode_SimEN = vDataNode_SimDA.GetFirstObj(strWhereCond);
 return objvDataNode_SimEN;
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
public static clsvDataNode_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvDataNode_SimEN objvDataNode_SimEN = vDataNode_SimDA.GetObjByDataRow(objRow);
 return objvDataNode_SimEN;
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
public static clsvDataNode_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvDataNode_SimEN objvDataNode_SimEN = vDataNode_SimDA.GetObjByDataRow(objRow);
 return objvDataNode_SimEN;
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
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <param name = "lstvDataNode_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDataNode_SimEN GetObjByDataNodeIdFromList(long lngDataNodeId, List<clsvDataNode_SimEN> lstvDataNode_SimObjLst)
{
foreach (clsvDataNode_SimEN objvDataNode_SimEN in lstvDataNode_SimObjLst)
{
if (objvDataNode_SimEN.DataNodeId == lngDataNodeId)
{
return objvDataNode_SimEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngDataNodeId;
 try
 {
 lngDataNodeId = new clsvDataNode_SimDA().GetFirstID(strWhereCond);
 return lngDataNodeId;
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
 arrList = vDataNode_SimDA.GetID(strWhereCond);
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
bool bolIsExist = vDataNode_SimDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngDataNodeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngDataNodeId)
{
//检测记录是否存在
bool bolIsExist = vDataNode_SimDA.IsExist(lngDataNodeId);
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
 bolIsExist = clsvDataNode_SimDA.IsExistTable();
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
 bolIsExist = vDataNode_SimDA.IsExistTable(strTabName);
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
 /// <param name = "objvDataNode_SimENS">源对象</param>
 /// <param name = "objvDataNode_SimENT">目标对象</param>
 public static void CopyTo(clsvDataNode_SimEN objvDataNode_SimENS, clsvDataNode_SimEN objvDataNode_SimENT)
{
try
{
objvDataNode_SimENT.DataNodeId = objvDataNode_SimENS.DataNodeId; //数据结点Id
objvDataNode_SimENT.DataNodeName = objvDataNode_SimENS.DataNodeName; //数据结点名
objvDataNode_SimENT.TabId = objvDataNode_SimENS.TabId; //表ID
objvDataNode_SimENT.FldId = objvDataNode_SimENS.FldId; //字段Id
objvDataNode_SimENT.KeyFldLst = objvDataNode_SimENS.KeyFldLst; //关键字段Id列表
objvDataNode_SimENT.DataNodeTypeId = objvDataNode_SimENS.DataNodeTypeId; //数据结点类型Id
objvDataNode_SimENT.VersionNo = objvDataNode_SimENS.VersionNo; //版本号
objvDataNode_SimENT.PrjId = objvDataNode_SimENS.PrjId; //工程Id
objvDataNode_SimENT.PosX = objvDataNode_SimENS.PosX; //位置X
objvDataNode_SimENT.PosY = objvDataNode_SimENS.PosY; //位置Y
objvDataNode_SimENT.UsedTimes = objvDataNode_SimENS.UsedTimes; //使用次数
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
 /// <param name = "objvDataNode_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvDataNode_SimEN objvDataNode_SimEN)
{
try
{
objvDataNode_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvDataNode_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convDataNode_Sim.DataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNode_SimEN.DataNodeId = objvDataNode_SimEN.DataNodeId; //数据结点Id
}
if (arrFldSet.Contains(convDataNode_Sim.DataNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNode_SimEN.DataNodeName = objvDataNode_SimEN.DataNodeName == "[null]" ? null :  objvDataNode_SimEN.DataNodeName; //数据结点名
}
if (arrFldSet.Contains(convDataNode_Sim.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNode_SimEN.TabId = objvDataNode_SimEN.TabId; //表ID
}
if (arrFldSet.Contains(convDataNode_Sim.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNode_SimEN.FldId = objvDataNode_SimEN.FldId; //字段Id
}
if (arrFldSet.Contains(convDataNode_Sim.KeyFldLst, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNode_SimEN.KeyFldLst = objvDataNode_SimEN.KeyFldLst == "[null]" ? null :  objvDataNode_SimEN.KeyFldLst; //关键字段Id列表
}
if (arrFldSet.Contains(convDataNode_Sim.DataNodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNode_SimEN.DataNodeTypeId = objvDataNode_SimEN.DataNodeTypeId; //数据结点类型Id
}
if (arrFldSet.Contains(convDataNode_Sim.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNode_SimEN.VersionNo = objvDataNode_SimEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convDataNode_Sim.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNode_SimEN.PrjId = objvDataNode_SimEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convDataNode_Sim.PosX, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNode_SimEN.PosX = objvDataNode_SimEN.PosX; //位置X
}
if (arrFldSet.Contains(convDataNode_Sim.PosY, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNode_SimEN.PosY = objvDataNode_SimEN.PosY; //位置Y
}
if (arrFldSet.Contains(convDataNode_Sim.UsedTimes, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNode_SimEN.UsedTimes = objvDataNode_SimEN.UsedTimes; //使用次数
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
 /// <param name = "objvDataNode_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvDataNode_SimEN objvDataNode_SimEN)
{
try
{
if (objvDataNode_SimEN.DataNodeName == "[null]") objvDataNode_SimEN.DataNodeName = null; //数据结点名
if (objvDataNode_SimEN.KeyFldLst == "[null]") objvDataNode_SimEN.KeyFldLst = null; //关键字段Id列表
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
public static void CheckProperty4Condition(clsvDataNode_SimEN objvDataNode_SimEN)
{
 vDataNode_SimDA.CheckProperty4Condition(objvDataNode_SimEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DataNodeIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vDataNode_Sim]...","0");
List<clsvDataNode_SimEN> arrvDataNode_SimObjLst = GetAllvDataNode_SimObjLstCache(strPrjId); 
objDDL.DataValueField = convDataNode_Sim.DataNodeId;
objDDL.DataTextField = convDataNode_Sim.DataNodeName;
objDDL.DataSource = arrvDataNode_SimObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsDataNodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataNodeBL没有刷新缓存机制(clsDataNodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DataNodeId");
//if (arrvDataNode_SimObjLstCache == null)
//{
//arrvDataNode_SimObjLstCache = vDataNode_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDataNode_SimEN GetObjByDataNodeIdCache(long lngDataNodeId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvDataNode_SimEN._CurrTabName, strPrjId);
List<clsvDataNode_SimEN> arrvDataNode_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDataNode_SimEN> arrvDataNode_SimObjLst_Sel =
arrvDataNode_SimObjLstCache
.Where(x=> x.DataNodeId == lngDataNodeId 
);
if (arrvDataNode_SimObjLst_Sel.Count() == 0)
{
   clsvDataNode_SimEN obj = clsvDataNode_SimBL.GetObjByDataNodeId(lngDataNodeId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngDataNodeId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvDataNode_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDataNodeNameByDataNodeIdCache(long lngDataNodeId, string strPrjId)
{
//获取缓存中的对象列表
clsvDataNode_SimEN objvDataNode_Sim = GetObjByDataNodeIdCache(lngDataNodeId, strPrjId);
if (objvDataNode_Sim == null) return "";
return objvDataNode_Sim.DataNodeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDataNodeIdCache(long lngDataNodeId, string strPrjId)
{
//获取缓存中的对象列表
clsvDataNode_SimEN objvDataNode_Sim = GetObjByDataNodeIdCache(lngDataNodeId, strPrjId);
if (objvDataNode_Sim == null) return "";
return objvDataNode_Sim.DataNodeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDataNode_SimEN> GetAllvDataNode_SimObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvDataNode_SimEN> arrvDataNode_SimObjLstCache = GetObjLstCache(strPrjId); 
return arrvDataNode_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDataNode_SimEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvDataNode_SimEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvDataNode_SimEN> arrvDataNode_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvDataNode_SimObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvDataNode_SimEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvDataNode_SimEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvDataNode_SimEN._RefreshTimeLst.Count == 0) return "";
return clsvDataNode_SimEN._RefreshTimeLst[clsvDataNode_SimEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, long lngDataNodeId, string strPrjId)
{
if (strInFldName != convDataNode_Sim.DataNodeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convDataNode_Sim._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convDataNode_Sim._AttributeName));
throw new Exception(strMsg);
}
var objvDataNode_Sim = clsvDataNode_SimBL.GetObjByDataNodeIdCache(lngDataNodeId, strPrjId);
if (objvDataNode_Sim == null) return "";
return objvDataNode_Sim[strOutFldName].ToString();
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
int intRecCount = clsvDataNode_SimDA.GetRecCount(strTabName);
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
int intRecCount = clsvDataNode_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvDataNode_SimDA.GetRecCount();
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
int intRecCount = clsvDataNode_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvDataNode_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvDataNode_SimEN objvDataNode_SimCond)
{
 string strPrjId = objvDataNode_SimCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvDataNode_SimBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvDataNode_SimEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDataNode_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDataNode_Sim._AttributeName)
{
if (objvDataNode_SimCond.IsUpdated(strFldName) == false) continue;
if (objvDataNode_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDataNode_SimCond[strFldName].ToString());
}
else
{
if (objvDataNode_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDataNode_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDataNode_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDataNode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDataNode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDataNode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDataNode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDataNode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDataNode_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDataNode_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDataNode_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDataNode_SimCond[strFldName]));
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
 List<string> arrList = clsvDataNode_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vDataNode_SimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vDataNode_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}