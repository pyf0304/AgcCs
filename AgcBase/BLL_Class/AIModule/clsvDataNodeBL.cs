
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDataNodeBL
 表名:vDataNode(00050569)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:26:49
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
public static class  clsvDataNodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngDataNodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDataNodeEN GetObj(this K_DataNodeId_vDataNode myKey)
{
clsvDataNodeEN objvDataNodeEN = clsvDataNodeBL.vDataNodeDA.GetObjByDataNodeId(myKey.Value);
return objvDataNodeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetDataNodeName(this clsvDataNodeEN objvDataNodeEN, string strDataNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataNodeName, 100, convDataNode.DataNodeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetTabId(this clsvDataNodeEN objvDataNodeEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convDataNode.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convDataNode.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convDataNode.TabId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetTabName(this clsvDataNodeEN objvDataNodeEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabName, convDataNode.TabName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convDataNode.TabName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetFldId(this clsvDataNodeEN objvDataNodeEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convDataNode.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convDataNode.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convDataNode.FldId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetFldName(this clsvDataNodeEN objvDataNodeEN, string strFldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldName, convDataNode.FldName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convDataNode.FldName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetDataNodeTypeId(this clsvDataNodeEN objvDataNodeEN, string strDataNodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataNodeTypeId, 2, convDataNode.DataNodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataNodeTypeId, 2, convDataNode.DataNodeTypeId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetDataNodeTypeName(this clsvDataNodeEN objvDataNodeEN, string strDataNodeTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataNodeTypeName, 50, convDataNode.DataNodeTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetSubGraphName(this clsvDataNodeEN objvDataNodeEN, string strSubGraphName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubGraphName, 50, convDataNode.SubGraphName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetPrjId(this clsvDataNodeEN objvDataNodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convDataNode.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convDataNode.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDataNode.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetUpdDate(this clsvDataNodeEN objvDataNodeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDataNode.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetUpdUser(this clsvDataNodeEN objvDataNodeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convDataNode.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNodeEN SetMemo(this clsvDataNodeEN objvDataNodeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDataNode.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvDataNodeENS">源对象</param>
 /// <param name = "objvDataNodeENT">目标对象</param>
 public static void CopyTo(this clsvDataNodeEN objvDataNodeENS, clsvDataNodeEN objvDataNodeENT)
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
 /// <param name = "objvDataNodeENS">源对象</param>
 /// <returns>目标对象=>clsvDataNodeEN:objvDataNodeENT</returns>
 public static clsvDataNodeEN CopyTo(this clsvDataNodeEN objvDataNodeENS)
{
try
{
 clsvDataNodeEN objvDataNodeENT = new clsvDataNodeEN()
{
DataNodeId = objvDataNodeENS.DataNodeId, //数据结点Id
DataNodeName = objvDataNodeENS.DataNodeName, //数据结点名
TabId = objvDataNodeENS.TabId, //表ID
TabName = objvDataNodeENS.TabName, //表名
FldId = objvDataNodeENS.FldId, //字段Id
FldName = objvDataNodeENS.FldName, //字段名
VersionNo = objvDataNodeENS.VersionNo, //版本号
DataNodeTypeId = objvDataNodeENS.DataNodeTypeId, //数据结点类型Id
DataNodeTypeName = objvDataNodeENS.DataNodeTypeName, //数据结点类型名
SubGraphName = objvDataNodeENS.SubGraphName, //子图名
PrjId = objvDataNodeENS.PrjId, //工程Id
UpdDate = objvDataNodeENS.UpdDate, //修改日期
UpdUser = objvDataNodeENS.UpdUser, //修改者
Memo = objvDataNodeENS.Memo, //说明
};
 return objvDataNodeENT;
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
public static void CheckProperty4Condition(this clsvDataNodeEN objvDataNodeEN)
{
 clsvDataNodeBL.vDataNodeDA.CheckProperty4Condition(objvDataNodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vDataNode
{
public virtual bool UpdRelaTabDate(long lngDataNodeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vDataNode(vDataNode)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvDataNodeBL
{
public static RelatedActions_vDataNode relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvDataNodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvDataNodeDA vDataNodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvDataNodeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvDataNodeBL()
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
if (string.IsNullOrEmpty(clsvDataNodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDataNodeEN._ConnectString);
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
public static DataTable GetDataTable_vDataNode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vDataNodeDA.GetDataTable_vDataNode(strWhereCond);
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
objDT = vDataNodeDA.GetDataTable(strWhereCond);
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
objDT = vDataNodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vDataNodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vDataNodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vDataNodeDA.GetDataTable_Top(objTopPara);
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
objDT = vDataNodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vDataNodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vDataNodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvDataNodeEN> GetObjLstByDataNodeIdLst(List<long> arrDataNodeIdLst)
{
List<clsvDataNodeEN> arrObjLst = new List<clsvDataNodeEN>(); 
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
	clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
try
{
objvDataNodeEN.DataNodeId = Int32.Parse(objRow[convDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNodeEN.DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(); //数据结点名
objvDataNodeEN.TabId = objRow[convDataNode.TabId].ToString().Trim(); //表ID
objvDataNodeEN.TabName = objRow[convDataNode.TabName].ToString().Trim(); //表名
objvDataNodeEN.FldId = objRow[convDataNode.FldId].ToString().Trim(); //字段Id
objvDataNodeEN.FldName = objRow[convDataNode.FldName].ToString().Trim(); //字段名
objvDataNodeEN.VersionNo = Int32.Parse(objRow[convDataNode.VersionNo].ToString().Trim()); //版本号
objvDataNodeEN.DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNodeEN.DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objvDataNodeEN.SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(); //子图名
objvDataNodeEN.PrjId = objRow[convDataNode.PrjId].ToString().Trim(); //工程Id
objvDataNodeEN.UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(); //修改日期
objvDataNodeEN.UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(); //修改者
objvDataNodeEN.Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDataNodeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvDataNodeEN> GetObjLstByDataNodeIdLstCache(List<long> arrDataNodeIdLst)
{
string strKey = string.Format("{0}", clsvDataNodeEN._CurrTabName);
List<clsvDataNodeEN> arrvDataNodeObjLstCache = GetObjLstCache();
IEnumerable <clsvDataNodeEN> arrvDataNodeObjLst_Sel =
arrvDataNodeObjLstCache
.Where(x => arrDataNodeIdLst.Contains(x.DataNodeId));
return arrvDataNodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataNodeEN> GetObjLst(string strWhereCond)
{
List<clsvDataNodeEN> arrObjLst = new List<clsvDataNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
try
{
objvDataNodeEN.DataNodeId = Int32.Parse(objRow[convDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNodeEN.DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(); //数据结点名
objvDataNodeEN.TabId = objRow[convDataNode.TabId].ToString().Trim(); //表ID
objvDataNodeEN.TabName = objRow[convDataNode.TabName].ToString().Trim(); //表名
objvDataNodeEN.FldId = objRow[convDataNode.FldId].ToString().Trim(); //字段Id
objvDataNodeEN.FldName = objRow[convDataNode.FldName].ToString().Trim(); //字段名
objvDataNodeEN.VersionNo = Int32.Parse(objRow[convDataNode.VersionNo].ToString().Trim()); //版本号
objvDataNodeEN.DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNodeEN.DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objvDataNodeEN.SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(); //子图名
objvDataNodeEN.PrjId = objRow[convDataNode.PrjId].ToString().Trim(); //工程Id
objvDataNodeEN.UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(); //修改日期
objvDataNodeEN.UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(); //修改者
objvDataNodeEN.Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNodeEN);
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
public static List<clsvDataNodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvDataNodeEN> arrObjLst = new List<clsvDataNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
try
{
objvDataNodeEN.DataNodeId = Int32.Parse(objRow[convDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNodeEN.DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(); //数据结点名
objvDataNodeEN.TabId = objRow[convDataNode.TabId].ToString().Trim(); //表ID
objvDataNodeEN.TabName = objRow[convDataNode.TabName].ToString().Trim(); //表名
objvDataNodeEN.FldId = objRow[convDataNode.FldId].ToString().Trim(); //字段Id
objvDataNodeEN.FldName = objRow[convDataNode.FldName].ToString().Trim(); //字段名
objvDataNodeEN.VersionNo = Int32.Parse(objRow[convDataNode.VersionNo].ToString().Trim()); //版本号
objvDataNodeEN.DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNodeEN.DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objvDataNodeEN.SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(); //子图名
objvDataNodeEN.PrjId = objRow[convDataNode.PrjId].ToString().Trim(); //工程Id
objvDataNodeEN.UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(); //修改日期
objvDataNodeEN.UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(); //修改者
objvDataNodeEN.Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvDataNodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvDataNodeEN> GetSubObjLstCache(clsvDataNodeEN objvDataNodeCond)
{
List<clsvDataNodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvDataNodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDataNode._AttributeName)
{
if (objvDataNodeCond.IsUpdated(strFldName) == false) continue;
if (objvDataNodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDataNodeCond[strFldName].ToString());
}
else
{
if (objvDataNodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDataNodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDataNodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDataNodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDataNodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDataNodeCond[strFldName]));
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
public static List<clsvDataNodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvDataNodeEN> arrObjLst = new List<clsvDataNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
try
{
objvDataNodeEN.DataNodeId = Int32.Parse(objRow[convDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNodeEN.DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(); //数据结点名
objvDataNodeEN.TabId = objRow[convDataNode.TabId].ToString().Trim(); //表ID
objvDataNodeEN.TabName = objRow[convDataNode.TabName].ToString().Trim(); //表名
objvDataNodeEN.FldId = objRow[convDataNode.FldId].ToString().Trim(); //字段Id
objvDataNodeEN.FldName = objRow[convDataNode.FldName].ToString().Trim(); //字段名
objvDataNodeEN.VersionNo = Int32.Parse(objRow[convDataNode.VersionNo].ToString().Trim()); //版本号
objvDataNodeEN.DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNodeEN.DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objvDataNodeEN.SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(); //子图名
objvDataNodeEN.PrjId = objRow[convDataNode.PrjId].ToString().Trim(); //工程Id
objvDataNodeEN.UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(); //修改日期
objvDataNodeEN.UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(); //修改者
objvDataNodeEN.Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNodeEN);
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
public static List<clsvDataNodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvDataNodeEN> arrObjLst = new List<clsvDataNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
try
{
objvDataNodeEN.DataNodeId = Int32.Parse(objRow[convDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNodeEN.DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(); //数据结点名
objvDataNodeEN.TabId = objRow[convDataNode.TabId].ToString().Trim(); //表ID
objvDataNodeEN.TabName = objRow[convDataNode.TabName].ToString().Trim(); //表名
objvDataNodeEN.FldId = objRow[convDataNode.FldId].ToString().Trim(); //字段Id
objvDataNodeEN.FldName = objRow[convDataNode.FldName].ToString().Trim(); //字段名
objvDataNodeEN.VersionNo = Int32.Parse(objRow[convDataNode.VersionNo].ToString().Trim()); //版本号
objvDataNodeEN.DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNodeEN.DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objvDataNodeEN.SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(); //子图名
objvDataNodeEN.PrjId = objRow[convDataNode.PrjId].ToString().Trim(); //工程Id
objvDataNodeEN.UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(); //修改日期
objvDataNodeEN.UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(); //修改者
objvDataNodeEN.Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNodeEN);
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
List<clsvDataNodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvDataNodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataNodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvDataNodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvDataNodeEN> arrObjLst = new List<clsvDataNodeEN>(); 
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
	clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
try
{
objvDataNodeEN.DataNodeId = Int32.Parse(objRow[convDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNodeEN.DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(); //数据结点名
objvDataNodeEN.TabId = objRow[convDataNode.TabId].ToString().Trim(); //表ID
objvDataNodeEN.TabName = objRow[convDataNode.TabName].ToString().Trim(); //表名
objvDataNodeEN.FldId = objRow[convDataNode.FldId].ToString().Trim(); //字段Id
objvDataNodeEN.FldName = objRow[convDataNode.FldName].ToString().Trim(); //字段名
objvDataNodeEN.VersionNo = Int32.Parse(objRow[convDataNode.VersionNo].ToString().Trim()); //版本号
objvDataNodeEN.DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNodeEN.DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objvDataNodeEN.SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(); //子图名
objvDataNodeEN.PrjId = objRow[convDataNode.PrjId].ToString().Trim(); //工程Id
objvDataNodeEN.UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(); //修改日期
objvDataNodeEN.UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(); //修改者
objvDataNodeEN.Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNodeEN);
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
public static List<clsvDataNodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvDataNodeEN> arrObjLst = new List<clsvDataNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
try
{
objvDataNodeEN.DataNodeId = Int32.Parse(objRow[convDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNodeEN.DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(); //数据结点名
objvDataNodeEN.TabId = objRow[convDataNode.TabId].ToString().Trim(); //表ID
objvDataNodeEN.TabName = objRow[convDataNode.TabName].ToString().Trim(); //表名
objvDataNodeEN.FldId = objRow[convDataNode.FldId].ToString().Trim(); //字段Id
objvDataNodeEN.FldName = objRow[convDataNode.FldName].ToString().Trim(); //字段名
objvDataNodeEN.VersionNo = Int32.Parse(objRow[convDataNode.VersionNo].ToString().Trim()); //版本号
objvDataNodeEN.DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNodeEN.DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objvDataNodeEN.SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(); //子图名
objvDataNodeEN.PrjId = objRow[convDataNode.PrjId].ToString().Trim(); //工程Id
objvDataNodeEN.UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(); //修改日期
objvDataNodeEN.UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(); //修改者
objvDataNodeEN.Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvDataNodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvDataNodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvDataNodeEN> arrObjLst = new List<clsvDataNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
try
{
objvDataNodeEN.DataNodeId = Int32.Parse(objRow[convDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNodeEN.DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(); //数据结点名
objvDataNodeEN.TabId = objRow[convDataNode.TabId].ToString().Trim(); //表ID
objvDataNodeEN.TabName = objRow[convDataNode.TabName].ToString().Trim(); //表名
objvDataNodeEN.FldId = objRow[convDataNode.FldId].ToString().Trim(); //字段Id
objvDataNodeEN.FldName = objRow[convDataNode.FldName].ToString().Trim(); //字段名
objvDataNodeEN.VersionNo = Int32.Parse(objRow[convDataNode.VersionNo].ToString().Trim()); //版本号
objvDataNodeEN.DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNodeEN.DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objvDataNodeEN.SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(); //子图名
objvDataNodeEN.PrjId = objRow[convDataNode.PrjId].ToString().Trim(); //工程Id
objvDataNodeEN.UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(); //修改日期
objvDataNodeEN.UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(); //修改者
objvDataNodeEN.Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNodeEN);
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
public static List<clsvDataNodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvDataNodeEN> arrObjLst = new List<clsvDataNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
try
{
objvDataNodeEN.DataNodeId = Int32.Parse(objRow[convDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNodeEN.DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(); //数据结点名
objvDataNodeEN.TabId = objRow[convDataNode.TabId].ToString().Trim(); //表ID
objvDataNodeEN.TabName = objRow[convDataNode.TabName].ToString().Trim(); //表名
objvDataNodeEN.FldId = objRow[convDataNode.FldId].ToString().Trim(); //字段Id
objvDataNodeEN.FldName = objRow[convDataNode.FldName].ToString().Trim(); //字段名
objvDataNodeEN.VersionNo = Int32.Parse(objRow[convDataNode.VersionNo].ToString().Trim()); //版本号
objvDataNodeEN.DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNodeEN.DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objvDataNodeEN.SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(); //子图名
objvDataNodeEN.PrjId = objRow[convDataNode.PrjId].ToString().Trim(); //工程Id
objvDataNodeEN.UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(); //修改日期
objvDataNodeEN.UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(); //修改者
objvDataNodeEN.Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataNodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvDataNodeEN> arrObjLst = new List<clsvDataNodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
try
{
objvDataNodeEN.DataNodeId = Int32.Parse(objRow[convDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNodeEN.DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(); //数据结点名
objvDataNodeEN.TabId = objRow[convDataNode.TabId].ToString().Trim(); //表ID
objvDataNodeEN.TabName = objRow[convDataNode.TabName].ToString().Trim(); //表名
objvDataNodeEN.FldId = objRow[convDataNode.FldId].ToString().Trim(); //字段Id
objvDataNodeEN.FldName = objRow[convDataNode.FldName].ToString().Trim(); //字段名
objvDataNodeEN.VersionNo = Int32.Parse(objRow[convDataNode.VersionNo].ToString().Trim()); //版本号
objvDataNodeEN.DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNodeEN.DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objvDataNodeEN.SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(); //子图名
objvDataNodeEN.PrjId = objRow[convDataNode.PrjId].ToString().Trim(); //工程Id
objvDataNodeEN.UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(); //修改日期
objvDataNodeEN.UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(); //修改者
objvDataNodeEN.Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDataNodeEN.DataNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDataNodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvDataNodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvDataNode(ref clsvDataNodeEN objvDataNodeEN)
{
bool bolResult = vDataNodeDA.GetvDataNode(ref objvDataNodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngDataNodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDataNodeEN GetObjByDataNodeId(long lngDataNodeId)
{
clsvDataNodeEN objvDataNodeEN = vDataNodeDA.GetObjByDataNodeId(lngDataNodeId);
return objvDataNodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvDataNodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvDataNodeEN objvDataNodeEN = vDataNodeDA.GetFirstObj(strWhereCond);
 return objvDataNodeEN;
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
public static clsvDataNodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvDataNodeEN objvDataNodeEN = vDataNodeDA.GetObjByDataRow(objRow);
 return objvDataNodeEN;
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
public static clsvDataNodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvDataNodeEN objvDataNodeEN = vDataNodeDA.GetObjByDataRow(objRow);
 return objvDataNodeEN;
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
 /// <param name = "lstvDataNodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDataNodeEN GetObjByDataNodeIdFromList(long lngDataNodeId, List<clsvDataNodeEN> lstvDataNodeObjLst)
{
foreach (clsvDataNodeEN objvDataNodeEN in lstvDataNodeObjLst)
{
if (objvDataNodeEN.DataNodeId == lngDataNodeId)
{
return objvDataNodeEN;
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
 lngDataNodeId = new clsvDataNodeDA().GetFirstID(strWhereCond);
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
 arrList = vDataNodeDA.GetID(strWhereCond);
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
bool bolIsExist = vDataNodeDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vDataNodeDA.IsExist(lngDataNodeId);
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
 bolIsExist = clsvDataNodeDA.IsExistTable();
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
 bolIsExist = vDataNodeDA.IsExistTable(strTabName);
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
 /// <param name = "objvDataNodeEN">源简化对象</param>
 public static void SetUpdFlag(clsvDataNodeEN objvDataNodeEN)
{
try
{
objvDataNodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvDataNodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convDataNode.DataNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNodeEN.DataNodeId = objvDataNodeEN.DataNodeId; //数据结点Id
}
if (arrFldSet.Contains(convDataNode.DataNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNodeEN.DataNodeName = objvDataNodeEN.DataNodeName == "[null]" ? null :  objvDataNodeEN.DataNodeName; //数据结点名
}
if (arrFldSet.Contains(convDataNode.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNodeEN.TabId = objvDataNodeEN.TabId; //表ID
}
if (arrFldSet.Contains(convDataNode.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNodeEN.TabName = objvDataNodeEN.TabName; //表名
}
if (arrFldSet.Contains(convDataNode.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNodeEN.FldId = objvDataNodeEN.FldId; //字段Id
}
if (arrFldSet.Contains(convDataNode.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNodeEN.FldName = objvDataNodeEN.FldName; //字段名
}
if (arrFldSet.Contains(convDataNode.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNodeEN.VersionNo = objvDataNodeEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convDataNode.DataNodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNodeEN.DataNodeTypeId = objvDataNodeEN.DataNodeTypeId == "[null]" ? null :  objvDataNodeEN.DataNodeTypeId; //数据结点类型Id
}
if (arrFldSet.Contains(convDataNode.DataNodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNodeEN.DataNodeTypeName = objvDataNodeEN.DataNodeTypeName == "[null]" ? null :  objvDataNodeEN.DataNodeTypeName; //数据结点类型名
}
if (arrFldSet.Contains(convDataNode.SubGraphName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNodeEN.SubGraphName = objvDataNodeEN.SubGraphName == "[null]" ? null :  objvDataNodeEN.SubGraphName; //子图名
}
if (arrFldSet.Contains(convDataNode.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNodeEN.PrjId = objvDataNodeEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convDataNode.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNodeEN.UpdDate = objvDataNodeEN.UpdDate == "[null]" ? null :  objvDataNodeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convDataNode.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNodeEN.UpdUser = objvDataNodeEN.UpdUser == "[null]" ? null :  objvDataNodeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convDataNode.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvDataNodeEN.Memo = objvDataNodeEN.Memo == "[null]" ? null :  objvDataNodeEN.Memo; //说明
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
 /// <param name = "objvDataNodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvDataNodeEN objvDataNodeEN)
{
try
{
if (objvDataNodeEN.DataNodeName == "[null]") objvDataNodeEN.DataNodeName = null; //数据结点名
if (objvDataNodeEN.DataNodeTypeId == "[null]") objvDataNodeEN.DataNodeTypeId = null; //数据结点类型Id
if (objvDataNodeEN.DataNodeTypeName == "[null]") objvDataNodeEN.DataNodeTypeName = null; //数据结点类型名
if (objvDataNodeEN.SubGraphName == "[null]") objvDataNodeEN.SubGraphName = null; //子图名
if (objvDataNodeEN.UpdDate == "[null]") objvDataNodeEN.UpdDate = null; //修改日期
if (objvDataNodeEN.UpdUser == "[null]") objvDataNodeEN.UpdUser = null; //修改者
if (objvDataNodeEN.Memo == "[null]") objvDataNodeEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvDataNodeEN objvDataNodeEN)
{
 vDataNodeDA.CheckProperty4Condition(objvDataNodeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_DataNodeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convDataNode.DataNodeId); 
List<clsvDataNodeEN> arrObjLst = clsvDataNodeBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_DataNodeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vDataNode]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convDataNode.DataNodeId); 
IEnumerable<clsvDataNodeEN> arrObjLst = clsvDataNodeBL.GetObjLst(strCondition);
objDDL.DataValueField = convDataNode.DataNodeId;
objDDL.DataTextField = convDataNode.DataNodeName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DataNodeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vDataNode]...","0");
List<clsvDataNodeEN> arrvDataNodeObjLst = GetAllvDataNodeObjLstCache(); 
objDDL.DataValueField = convDataNode.DataNodeId;
objDDL.DataTextField = convDataNode.DataNodeName;
objDDL.DataSource = arrvDataNodeObjLst;
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
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
if (clsDataNodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataNodeTypeBL没有刷新缓存机制(clsDataNodeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DataNodeId");
//if (arrvDataNodeObjLstCache == null)
//{
//arrvDataNodeObjLstCache = vDataNodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDataNodeEN GetObjByDataNodeIdCache(long lngDataNodeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvDataNodeEN._CurrTabName);
List<clsvDataNodeEN> arrvDataNodeObjLstCache = GetObjLstCache();
IEnumerable <clsvDataNodeEN> arrvDataNodeObjLst_Sel =
arrvDataNodeObjLstCache
.Where(x=> x.DataNodeId == lngDataNodeId 
);
if (arrvDataNodeObjLst_Sel.Count() == 0)
{
   clsvDataNodeEN obj = clsvDataNodeBL.GetObjByDataNodeId(lngDataNodeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvDataNodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDataNodeNameByDataNodeIdCache(long lngDataNodeId)
{
//获取缓存中的对象列表
clsvDataNodeEN objvDataNode = GetObjByDataNodeIdCache(lngDataNodeId);
if (objvDataNode == null) return "";
return objvDataNode.DataNodeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDataNodeIdCache(long lngDataNodeId)
{
//获取缓存中的对象列表
clsvDataNodeEN objvDataNode = GetObjByDataNodeIdCache(lngDataNodeId);
if (objvDataNode == null) return "";
return objvDataNode.DataNodeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDataNodeEN> GetAllvDataNodeObjLstCache()
{
//获取缓存中的对象列表
List<clsvDataNodeEN> arrvDataNodeObjLstCache = GetObjLstCache(); 
return arrvDataNodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDataNodeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvDataNodeEN._CurrTabName);
List<clsvDataNodeEN> arrvDataNodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvDataNodeObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvDataNodeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvDataNodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvDataNodeEN._RefreshTimeLst.Count == 0) return "";
return clsvDataNodeEN._RefreshTimeLst[clsvDataNodeEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngDataNodeId)
{
if (strInFldName != convDataNode.DataNodeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convDataNode._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convDataNode._AttributeName));
throw new Exception(strMsg);
}
var objvDataNode = clsvDataNodeBL.GetObjByDataNodeIdCache(lngDataNodeId);
if (objvDataNode == null) return "";
return objvDataNode[strOutFldName].ToString();
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
int intRecCount = clsvDataNodeDA.GetRecCount(strTabName);
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
int intRecCount = clsvDataNodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvDataNodeDA.GetRecCount();
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
int intRecCount = clsvDataNodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvDataNodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvDataNodeEN objvDataNodeCond)
{
List<clsvDataNodeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvDataNodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDataNode._AttributeName)
{
if (objvDataNodeCond.IsUpdated(strFldName) == false) continue;
if (objvDataNodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDataNodeCond[strFldName].ToString());
}
else
{
if (objvDataNodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDataNodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDataNodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDataNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDataNodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDataNodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDataNodeCond[strFldName]));
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
 List<string> arrList = clsvDataNodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vDataNodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vDataNodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}