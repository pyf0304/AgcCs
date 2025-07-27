
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvwf_PointBL
 表名:vwf_Point(00050496)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:20
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class clsvwf_PointBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPointId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvwf_PointEN GetObj(this K_PointId_vwf_Point myKey)
{
clsvwf_PointEN objvwf_PointEN = clsvwf_PointBL.vwf_PointDA.GetObjByPointId(myKey.Value);
return objvwf_PointEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_PointEN SetPointId(this clsvwf_PointEN objvwf_PointEN, string strPointId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPointId, 8, convwf_Point.PointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPointId, 8, convwf_Point.PointId);
}
objvwf_PointEN.PointId = strPointId; //结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_PointEN.dicFldComparisonOp.ContainsKey(convwf_Point.PointId) == false)
{
objvwf_PointEN.dicFldComparisonOp.Add(convwf_Point.PointId, strComparisonOp);
}
else
{
objvwf_PointEN.dicFldComparisonOp[convwf_Point.PointId] = strComparisonOp;
}
}
return objvwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_PointEN SetPointName(this clsvwf_PointEN objvwf_PointEN, string strPointName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPointName, convwf_Point.PointName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPointName, 100, convwf_Point.PointName);
}
objvwf_PointEN.PointName = strPointName; //结点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_PointEN.dicFldComparisonOp.ContainsKey(convwf_Point.PointName) == false)
{
objvwf_PointEN.dicFldComparisonOp.Add(convwf_Point.PointName, strComparisonOp);
}
else
{
objvwf_PointEN.dicFldComparisonOp[convwf_Point.PointName] = strComparisonOp;
}
}
return objvwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_PointEN SetPrjId(this clsvwf_PointEN objvwf_PointEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convwf_Point.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convwf_Point.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convwf_Point.PrjId);
}
objvwf_PointEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_PointEN.dicFldComparisonOp.ContainsKey(convwf_Point.PrjId) == false)
{
objvwf_PointEN.dicFldComparisonOp.Add(convwf_Point.PrjId, strComparisonOp);
}
else
{
objvwf_PointEN.dicFldComparisonOp[convwf_Point.PrjId] = strComparisonOp;
}
}
return objvwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_PointEN SetPrjName(this clsvwf_PointEN objvwf_PointEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convwf_Point.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convwf_Point.PrjName);
}
objvwf_PointEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_PointEN.dicFldComparisonOp.ContainsKey(convwf_Point.PrjName) == false)
{
objvwf_PointEN.dicFldComparisonOp.Add(convwf_Point.PrjName, strComparisonOp);
}
else
{
objvwf_PointEN.dicFldComparisonOp[convwf_Point.PrjName] = strComparisonOp;
}
}
return objvwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_PointEN SetTabName(this clsvwf_PointEN objvwf_PointEN, string strTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabName, 100, convwf_Point.TabName);
}
objvwf_PointEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_PointEN.dicFldComparisonOp.ContainsKey(convwf_Point.TabName) == false)
{
objvwf_PointEN.dicFldComparisonOp.Add(convwf_Point.TabName, strComparisonOp);
}
else
{
objvwf_PointEN.dicFldComparisonOp[convwf_Point.TabName] = strComparisonOp;
}
}
return objvwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_PointEN SetTabKeyId(this clsvwf_PointEN objvwf_PointEN, string strTabKeyId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabKeyId, 50, convwf_Point.TabKeyId);
}
objvwf_PointEN.TabKeyId = strTabKeyId; //表关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_PointEN.dicFldComparisonOp.ContainsKey(convwf_Point.TabKeyId) == false)
{
objvwf_PointEN.dicFldComparisonOp.Add(convwf_Point.TabKeyId, strComparisonOp);
}
else
{
objvwf_PointEN.dicFldComparisonOp[convwf_Point.TabKeyId] = strComparisonOp;
}
}
return objvwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_PointEN SetInUse(this clsvwf_PointEN objvwf_PointEN, bool bolInUse, string strComparisonOp="")
	{
objvwf_PointEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_PointEN.dicFldComparisonOp.ContainsKey(convwf_Point.InUse) == false)
{
objvwf_PointEN.dicFldComparisonOp.Add(convwf_Point.InUse, strComparisonOp);
}
else
{
objvwf_PointEN.dicFldComparisonOp[convwf_Point.InUse] = strComparisonOp;
}
}
return objvwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_PointEN SetUpdDate(this clsvwf_PointEN objvwf_PointEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convwf_Point.UpdDate);
}
objvwf_PointEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_PointEN.dicFldComparisonOp.ContainsKey(convwf_Point.UpdDate) == false)
{
objvwf_PointEN.dicFldComparisonOp.Add(convwf_Point.UpdDate, strComparisonOp);
}
else
{
objvwf_PointEN.dicFldComparisonOp[convwf_Point.UpdDate] = strComparisonOp;
}
}
return objvwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_PointEN SetUpdUser(this clsvwf_PointEN objvwf_PointEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convwf_Point.UpdUser);
}
objvwf_PointEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_PointEN.dicFldComparisonOp.ContainsKey(convwf_Point.UpdUser) == false)
{
objvwf_PointEN.dicFldComparisonOp.Add(convwf_Point.UpdUser, strComparisonOp);
}
else
{
objvwf_PointEN.dicFldComparisonOp[convwf_Point.UpdUser] = strComparisonOp;
}
}
return objvwf_PointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvwf_PointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvwf_PointEN SetMemo(this clsvwf_PointEN objvwf_PointEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convwf_Point.Memo);
}
objvwf_PointEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvwf_PointEN.dicFldComparisonOp.ContainsKey(convwf_Point.Memo) == false)
{
objvwf_PointEN.dicFldComparisonOp.Add(convwf_Point.Memo, strComparisonOp);
}
else
{
objvwf_PointEN.dicFldComparisonOp[convwf_Point.Memo] = strComparisonOp;
}
}
return objvwf_PointEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvwf_PointENS">源对象</param>
 /// <param name = "objvwf_PointENT">目标对象</param>
 public static void CopyTo(this clsvwf_PointEN objvwf_PointENS, clsvwf_PointEN objvwf_PointENT)
{
try
{
objvwf_PointENT.PointId = objvwf_PointENS.PointId; //结点Id
objvwf_PointENT.PointName = objvwf_PointENS.PointName; //结点名称
objvwf_PointENT.PrjId = objvwf_PointENS.PrjId; //工程ID
objvwf_PointENT.PrjName = objvwf_PointENS.PrjName; //工程名称
objvwf_PointENT.TabName = objvwf_PointENS.TabName; //表名
objvwf_PointENT.TabKeyId = objvwf_PointENS.TabKeyId; //表关键字Id
objvwf_PointENT.InUse = objvwf_PointENS.InUse; //是否在用
objvwf_PointENT.UpdDate = objvwf_PointENS.UpdDate; //修改日期
objvwf_PointENT.UpdUser = objvwf_PointENS.UpdUser; //修改者
objvwf_PointENT.Memo = objvwf_PointENS.Memo; //说明
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
 /// <param name = "objvwf_PointENS">源对象</param>
 /// <returns>目标对象=>clsvwf_PointEN:objvwf_PointENT</returns>
 public static clsvwf_PointEN CopyTo(this clsvwf_PointEN objvwf_PointENS)
{
try
{
 clsvwf_PointEN objvwf_PointENT = new clsvwf_PointEN()
{
PointId = objvwf_PointENS.PointId, //结点Id
PointName = objvwf_PointENS.PointName, //结点名称
PrjId = objvwf_PointENS.PrjId, //工程ID
PrjName = objvwf_PointENS.PrjName, //工程名称
TabName = objvwf_PointENS.TabName, //表名
TabKeyId = objvwf_PointENS.TabKeyId, //表关键字Id
InUse = objvwf_PointENS.InUse, //是否在用
UpdDate = objvwf_PointENS.UpdDate, //修改日期
UpdUser = objvwf_PointENS.UpdUser, //修改者
Memo = objvwf_PointENS.Memo, //说明
};
 return objvwf_PointENT;
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
public static void CheckProperty4Condition(this clsvwf_PointEN objvwf_PointEN)
{
 clsvwf_PointBL.vwf_PointDA.CheckProperty4Condition(objvwf_PointEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvwf_PointEN objvwf_PointCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvwf_PointCond.IsUpdated(convwf_Point.PointId) == true)
{
string strComparisonOpPointId = objvwf_PointCond.dicFldComparisonOp[convwf_Point.PointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Point.PointId, objvwf_PointCond.PointId, strComparisonOpPointId);
}
if (objvwf_PointCond.IsUpdated(convwf_Point.PointName) == true)
{
string strComparisonOpPointName = objvwf_PointCond.dicFldComparisonOp[convwf_Point.PointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Point.PointName, objvwf_PointCond.PointName, strComparisonOpPointName);
}
if (objvwf_PointCond.IsUpdated(convwf_Point.PrjId) == true)
{
string strComparisonOpPrjId = objvwf_PointCond.dicFldComparisonOp[convwf_Point.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Point.PrjId, objvwf_PointCond.PrjId, strComparisonOpPrjId);
}
if (objvwf_PointCond.IsUpdated(convwf_Point.PrjName) == true)
{
string strComparisonOpPrjName = objvwf_PointCond.dicFldComparisonOp[convwf_Point.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Point.PrjName, objvwf_PointCond.PrjName, strComparisonOpPrjName);
}
if (objvwf_PointCond.IsUpdated(convwf_Point.TabName) == true)
{
string strComparisonOpTabName = objvwf_PointCond.dicFldComparisonOp[convwf_Point.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Point.TabName, objvwf_PointCond.TabName, strComparisonOpTabName);
}
if (objvwf_PointCond.IsUpdated(convwf_Point.TabKeyId) == true)
{
string strComparisonOpTabKeyId = objvwf_PointCond.dicFldComparisonOp[convwf_Point.TabKeyId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Point.TabKeyId, objvwf_PointCond.TabKeyId, strComparisonOpTabKeyId);
}
if (objvwf_PointCond.IsUpdated(convwf_Point.InUse) == true)
{
if (objvwf_PointCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convwf_Point.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convwf_Point.InUse);
}
}
if (objvwf_PointCond.IsUpdated(convwf_Point.UpdDate) == true)
{
string strComparisonOpUpdDate = objvwf_PointCond.dicFldComparisonOp[convwf_Point.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Point.UpdDate, objvwf_PointCond.UpdDate, strComparisonOpUpdDate);
}
if (objvwf_PointCond.IsUpdated(convwf_Point.UpdUser) == true)
{
string strComparisonOpUpdUser = objvwf_PointCond.dicFldComparisonOp[convwf_Point.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Point.UpdUser, objvwf_PointCond.UpdUser, strComparisonOpUpdUser);
}
if (objvwf_PointCond.IsUpdated(convwf_Point.Memo) == true)
{
string strComparisonOpMemo = objvwf_PointCond.dicFldComparisonOp[convwf_Point.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convwf_Point.Memo, objvwf_PointCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vwf_Point
{
public virtual bool UpdRelaTabDate(string strPointId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工作流结点(vwf_Point)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvwf_PointBL
{
public static RelatedActions_vwf_Point relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vwf_PointListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vwf_PointList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvwf_PointEN> arrvwf_PointObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvwf_PointDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvwf_PointDA vwf_PointDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvwf_PointDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvwf_PointBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsvwf_PointEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvwf_PointEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = vwf_PointDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = vwf_PointDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = vwf_PointDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vwf_Point(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vwf_PointDA.GetDataTable_vwf_Point(strWhereCond);
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
objDT = vwf_PointDA.GetDataTable(strWhereCond);
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
objDT = vwf_PointDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vwf_PointDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vwf_PointDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vwf_PointDA.GetDataTable_Top(objTopPara);
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
objDT = vwf_PointDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vwf_PointDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = vwf_PointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vwf_PointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vwf_PointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vwf_PointDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vwf_PointDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vwf_PointDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
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
 /// <param name = "arrPointIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvwf_PointEN> GetObjLstByPointIdLst(List<string> arrPointIdLst)
{
List<clsvwf_PointEN> arrObjLst = new List<clsvwf_PointEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPointIdLst, true);
 string strWhereCond = string.Format("PointId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_PointEN objvwf_PointEN = new clsvwf_PointEN();
try
{
objvwf_PointEN.PointId = objRow[convwf_Point.PointId].ToString().Trim(); //结点Id
objvwf_PointEN.PointName = objRow[convwf_Point.PointName].ToString().Trim(); //结点名称
objvwf_PointEN.PrjId = objRow[convwf_Point.PrjId].ToString().Trim(); //工程ID
objvwf_PointEN.PrjName = objRow[convwf_Point.PrjName].ToString().Trim(); //工程名称
objvwf_PointEN.TabName = objRow[convwf_Point.TabName] == DBNull.Value ? null : objRow[convwf_Point.TabName].ToString().Trim(); //表名
objvwf_PointEN.TabKeyId = objRow[convwf_Point.TabKeyId] == DBNull.Value ? null : objRow[convwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_Point.InUse].ToString().Trim()); //是否在用
objvwf_PointEN.UpdDate = objRow[convwf_Point.UpdDate] == DBNull.Value ? null : objRow[convwf_Point.UpdDate].ToString().Trim(); //修改日期
objvwf_PointEN.UpdUser = objRow[convwf_Point.UpdUser] == DBNull.Value ? null : objRow[convwf_Point.UpdUser].ToString().Trim(); //修改者
objvwf_PointEN.Memo = objRow[convwf_Point.Memo] == DBNull.Value ? null : objRow[convwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_PointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPointIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvwf_PointEN> GetObjLstByPointIdLstCache(List<string> arrPointIdLst)
{
string strKey = string.Format("{0}", clsvwf_PointEN._CurrTabName);
List<clsvwf_PointEN> arrvwf_PointObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_PointEN> arrvwf_PointObjLst_Sel =
arrvwf_PointObjLstCache
.Where(x => arrPointIdLst.Contains(x.PointId));
return arrvwf_PointObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_PointEN> GetObjLst(string strWhereCond)
{
List<clsvwf_PointEN> arrObjLst = new List<clsvwf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_PointEN objvwf_PointEN = new clsvwf_PointEN();
try
{
objvwf_PointEN.PointId = objRow[convwf_Point.PointId].ToString().Trim(); //结点Id
objvwf_PointEN.PointName = objRow[convwf_Point.PointName].ToString().Trim(); //结点名称
objvwf_PointEN.PrjId = objRow[convwf_Point.PrjId].ToString().Trim(); //工程ID
objvwf_PointEN.PrjName = objRow[convwf_Point.PrjName].ToString().Trim(); //工程名称
objvwf_PointEN.TabName = objRow[convwf_Point.TabName] == DBNull.Value ? null : objRow[convwf_Point.TabName].ToString().Trim(); //表名
objvwf_PointEN.TabKeyId = objRow[convwf_Point.TabKeyId] == DBNull.Value ? null : objRow[convwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_Point.InUse].ToString().Trim()); //是否在用
objvwf_PointEN.UpdDate = objRow[convwf_Point.UpdDate] == DBNull.Value ? null : objRow[convwf_Point.UpdDate].ToString().Trim(); //修改日期
objvwf_PointEN.UpdUser = objRow[convwf_Point.UpdUser] == DBNull.Value ? null : objRow[convwf_Point.UpdUser].ToString().Trim(); //修改者
objvwf_PointEN.Memo = objRow[convwf_Point.Memo] == DBNull.Value ? null : objRow[convwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_PointEN);
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
public static List<clsvwf_PointEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvwf_PointEN> arrObjLst = new List<clsvwf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_PointEN objvwf_PointEN = new clsvwf_PointEN();
try
{
objvwf_PointEN.PointId = objRow[convwf_Point.PointId].ToString().Trim(); //结点Id
objvwf_PointEN.PointName = objRow[convwf_Point.PointName].ToString().Trim(); //结点名称
objvwf_PointEN.PrjId = objRow[convwf_Point.PrjId].ToString().Trim(); //工程ID
objvwf_PointEN.PrjName = objRow[convwf_Point.PrjName].ToString().Trim(); //工程名称
objvwf_PointEN.TabName = objRow[convwf_Point.TabName] == DBNull.Value ? null : objRow[convwf_Point.TabName].ToString().Trim(); //表名
objvwf_PointEN.TabKeyId = objRow[convwf_Point.TabKeyId] == DBNull.Value ? null : objRow[convwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_Point.InUse].ToString().Trim()); //是否在用
objvwf_PointEN.UpdDate = objRow[convwf_Point.UpdDate] == DBNull.Value ? null : objRow[convwf_Point.UpdDate].ToString().Trim(); //修改日期
objvwf_PointEN.UpdUser = objRow[convwf_Point.UpdUser] == DBNull.Value ? null : objRow[convwf_Point.UpdUser].ToString().Trim(); //修改者
objvwf_PointEN.Memo = objRow[convwf_Point.Memo] == DBNull.Value ? null : objRow[convwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_PointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvwf_PointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvwf_PointEN> GetSubObjLstCache(clsvwf_PointEN objvwf_PointCond)
{
List<clsvwf_PointEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_PointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convwf_Point.AttributeName)
{
if (objvwf_PointCond.IsUpdated(strFldName) == false) continue;
if (objvwf_PointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_PointCond[strFldName].ToString());
}
else
{
if (objvwf_PointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvwf_PointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_PointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvwf_PointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvwf_PointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvwf_PointCond[strFldName]));
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
public static List<clsvwf_PointEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvwf_PointEN> arrObjLst = new List<clsvwf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_PointEN objvwf_PointEN = new clsvwf_PointEN();
try
{
objvwf_PointEN.PointId = objRow[convwf_Point.PointId].ToString().Trim(); //结点Id
objvwf_PointEN.PointName = objRow[convwf_Point.PointName].ToString().Trim(); //结点名称
objvwf_PointEN.PrjId = objRow[convwf_Point.PrjId].ToString().Trim(); //工程ID
objvwf_PointEN.PrjName = objRow[convwf_Point.PrjName].ToString().Trim(); //工程名称
objvwf_PointEN.TabName = objRow[convwf_Point.TabName] == DBNull.Value ? null : objRow[convwf_Point.TabName].ToString().Trim(); //表名
objvwf_PointEN.TabKeyId = objRow[convwf_Point.TabKeyId] == DBNull.Value ? null : objRow[convwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_Point.InUse].ToString().Trim()); //是否在用
objvwf_PointEN.UpdDate = objRow[convwf_Point.UpdDate] == DBNull.Value ? null : objRow[convwf_Point.UpdDate].ToString().Trim(); //修改日期
objvwf_PointEN.UpdUser = objRow[convwf_Point.UpdUser] == DBNull.Value ? null : objRow[convwf_Point.UpdUser].ToString().Trim(); //修改者
objvwf_PointEN.Memo = objRow[convwf_Point.Memo] == DBNull.Value ? null : objRow[convwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_PointEN);
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
public static List<clsvwf_PointEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvwf_PointEN> arrObjLst = new List<clsvwf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_PointEN objvwf_PointEN = new clsvwf_PointEN();
try
{
objvwf_PointEN.PointId = objRow[convwf_Point.PointId].ToString().Trim(); //结点Id
objvwf_PointEN.PointName = objRow[convwf_Point.PointName].ToString().Trim(); //结点名称
objvwf_PointEN.PrjId = objRow[convwf_Point.PrjId].ToString().Trim(); //工程ID
objvwf_PointEN.PrjName = objRow[convwf_Point.PrjName].ToString().Trim(); //工程名称
objvwf_PointEN.TabName = objRow[convwf_Point.TabName] == DBNull.Value ? null : objRow[convwf_Point.TabName].ToString().Trim(); //表名
objvwf_PointEN.TabKeyId = objRow[convwf_Point.TabKeyId] == DBNull.Value ? null : objRow[convwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_Point.InUse].ToString().Trim()); //是否在用
objvwf_PointEN.UpdDate = objRow[convwf_Point.UpdDate] == DBNull.Value ? null : objRow[convwf_Point.UpdDate].ToString().Trim(); //修改日期
objvwf_PointEN.UpdUser = objRow[convwf_Point.UpdUser] == DBNull.Value ? null : objRow[convwf_Point.UpdUser].ToString().Trim(); //修改者
objvwf_PointEN.Memo = objRow[convwf_Point.Memo] == DBNull.Value ? null : objRow[convwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_PointEN);
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
List<clsvwf_PointEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvwf_PointEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_PointEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvwf_PointEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvwf_PointEN> arrObjLst = new List<clsvwf_PointEN>(); 
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
	clsvwf_PointEN objvwf_PointEN = new clsvwf_PointEN();
try
{
objvwf_PointEN.PointId = objRow[convwf_Point.PointId].ToString().Trim(); //结点Id
objvwf_PointEN.PointName = objRow[convwf_Point.PointName].ToString().Trim(); //结点名称
objvwf_PointEN.PrjId = objRow[convwf_Point.PrjId].ToString().Trim(); //工程ID
objvwf_PointEN.PrjName = objRow[convwf_Point.PrjName].ToString().Trim(); //工程名称
objvwf_PointEN.TabName = objRow[convwf_Point.TabName] == DBNull.Value ? null : objRow[convwf_Point.TabName].ToString().Trim(); //表名
objvwf_PointEN.TabKeyId = objRow[convwf_Point.TabKeyId] == DBNull.Value ? null : objRow[convwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_Point.InUse].ToString().Trim()); //是否在用
objvwf_PointEN.UpdDate = objRow[convwf_Point.UpdDate] == DBNull.Value ? null : objRow[convwf_Point.UpdDate].ToString().Trim(); //修改日期
objvwf_PointEN.UpdUser = objRow[convwf_Point.UpdUser] == DBNull.Value ? null : objRow[convwf_Point.UpdUser].ToString().Trim(); //修改者
objvwf_PointEN.Memo = objRow[convwf_Point.Memo] == DBNull.Value ? null : objRow[convwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_PointEN);
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
public static List<clsvwf_PointEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvwf_PointEN> arrObjLst = new List<clsvwf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_PointEN objvwf_PointEN = new clsvwf_PointEN();
try
{
objvwf_PointEN.PointId = objRow[convwf_Point.PointId].ToString().Trim(); //结点Id
objvwf_PointEN.PointName = objRow[convwf_Point.PointName].ToString().Trim(); //结点名称
objvwf_PointEN.PrjId = objRow[convwf_Point.PrjId].ToString().Trim(); //工程ID
objvwf_PointEN.PrjName = objRow[convwf_Point.PrjName].ToString().Trim(); //工程名称
objvwf_PointEN.TabName = objRow[convwf_Point.TabName] == DBNull.Value ? null : objRow[convwf_Point.TabName].ToString().Trim(); //表名
objvwf_PointEN.TabKeyId = objRow[convwf_Point.TabKeyId] == DBNull.Value ? null : objRow[convwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_Point.InUse].ToString().Trim()); //是否在用
objvwf_PointEN.UpdDate = objRow[convwf_Point.UpdDate] == DBNull.Value ? null : objRow[convwf_Point.UpdDate].ToString().Trim(); //修改日期
objvwf_PointEN.UpdUser = objRow[convwf_Point.UpdUser] == DBNull.Value ? null : objRow[convwf_Point.UpdUser].ToString().Trim(); //修改者
objvwf_PointEN.Memo = objRow[convwf_Point.Memo] == DBNull.Value ? null : objRow[convwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_PointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvwf_PointEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvwf_PointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvwf_PointEN> arrObjLst = new List<clsvwf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_PointEN objvwf_PointEN = new clsvwf_PointEN();
try
{
objvwf_PointEN.PointId = objRow[convwf_Point.PointId].ToString().Trim(); //结点Id
objvwf_PointEN.PointName = objRow[convwf_Point.PointName].ToString().Trim(); //结点名称
objvwf_PointEN.PrjId = objRow[convwf_Point.PrjId].ToString().Trim(); //工程ID
objvwf_PointEN.PrjName = objRow[convwf_Point.PrjName].ToString().Trim(); //工程名称
objvwf_PointEN.TabName = objRow[convwf_Point.TabName] == DBNull.Value ? null : objRow[convwf_Point.TabName].ToString().Trim(); //表名
objvwf_PointEN.TabKeyId = objRow[convwf_Point.TabKeyId] == DBNull.Value ? null : objRow[convwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_Point.InUse].ToString().Trim()); //是否在用
objvwf_PointEN.UpdDate = objRow[convwf_Point.UpdDate] == DBNull.Value ? null : objRow[convwf_Point.UpdDate].ToString().Trim(); //修改日期
objvwf_PointEN.UpdUser = objRow[convwf_Point.UpdUser] == DBNull.Value ? null : objRow[convwf_Point.UpdUser].ToString().Trim(); //修改者
objvwf_PointEN.Memo = objRow[convwf_Point.Memo] == DBNull.Value ? null : objRow[convwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_PointEN);
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
public static List<clsvwf_PointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvwf_PointEN> arrObjLst = new List<clsvwf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_PointEN objvwf_PointEN = new clsvwf_PointEN();
try
{
objvwf_PointEN.PointId = objRow[convwf_Point.PointId].ToString().Trim(); //结点Id
objvwf_PointEN.PointName = objRow[convwf_Point.PointName].ToString().Trim(); //结点名称
objvwf_PointEN.PrjId = objRow[convwf_Point.PrjId].ToString().Trim(); //工程ID
objvwf_PointEN.PrjName = objRow[convwf_Point.PrjName].ToString().Trim(); //工程名称
objvwf_PointEN.TabName = objRow[convwf_Point.TabName] == DBNull.Value ? null : objRow[convwf_Point.TabName].ToString().Trim(); //表名
objvwf_PointEN.TabKeyId = objRow[convwf_Point.TabKeyId] == DBNull.Value ? null : objRow[convwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_Point.InUse].ToString().Trim()); //是否在用
objvwf_PointEN.UpdDate = objRow[convwf_Point.UpdDate] == DBNull.Value ? null : objRow[convwf_Point.UpdDate].ToString().Trim(); //修改日期
objvwf_PointEN.UpdUser = objRow[convwf_Point.UpdUser] == DBNull.Value ? null : objRow[convwf_Point.UpdUser].ToString().Trim(); //修改者
objvwf_PointEN.Memo = objRow[convwf_Point.Memo] == DBNull.Value ? null : objRow[convwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_PointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsvwf_PointEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvwf_PointEN objvwf_PointCond, string strOrderBy)
{
List<clsvwf_PointEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_PointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convwf_Point.AttributeName)
{
if (objvwf_PointCond.IsUpdated(strFldName) == false) continue;
if (objvwf_PointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_PointCond[strFldName].ToString());
}
else
{
if (objvwf_PointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvwf_PointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_PointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvwf_PointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvwf_PointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvwf_PointCond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLstSel = arrObjLstSel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLstSel = arrObjLstSel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLstSel = arrObjLstSel.Skip(intSkip).Take(intPageSize);
return arrObjLstSel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsvwf_PointEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvwf_PointEN objvwf_PointCond = JsonConvert.DeserializeObject<clsvwf_PointEN>(objPagerPara.whereCond);
if (objvwf_PointCond.sfFldComparisonOp == null)
{
objvwf_PointCond.dicFldComparisonOp = null;
}
else
{
objvwf_PointCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvwf_PointCond.sfFldComparisonOp);
}
clsvwf_PointBL.SetUpdFlag(objvwf_PointCond);
 try
{
CheckProperty4Condition(objvwf_PointCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvwf_PointBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvwf_PointCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_PointEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_PointEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvwf_PointEN> arrObjLst = new List<clsvwf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_PointEN objvwf_PointEN = new clsvwf_PointEN();
try
{
objvwf_PointEN.PointId = objRow[convwf_Point.PointId].ToString().Trim(); //结点Id
objvwf_PointEN.PointName = objRow[convwf_Point.PointName].ToString().Trim(); //结点名称
objvwf_PointEN.PrjId = objRow[convwf_Point.PrjId].ToString().Trim(); //工程ID
objvwf_PointEN.PrjName = objRow[convwf_Point.PrjName].ToString().Trim(); //工程名称
objvwf_PointEN.TabName = objRow[convwf_Point.TabName] == DBNull.Value ? null : objRow[convwf_Point.TabName].ToString().Trim(); //表名
objvwf_PointEN.TabKeyId = objRow[convwf_Point.TabKeyId] == DBNull.Value ? null : objRow[convwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_Point.InUse].ToString().Trim()); //是否在用
objvwf_PointEN.UpdDate = objRow[convwf_Point.UpdDate] == DBNull.Value ? null : objRow[convwf_Point.UpdDate].ToString().Trim(); //修改日期
objvwf_PointEN.UpdUser = objRow[convwf_Point.UpdUser] == DBNull.Value ? null : objRow[convwf_Point.UpdUser].ToString().Trim(); //修改者
objvwf_PointEN.Memo = objRow[convwf_Point.Memo] == DBNull.Value ? null : objRow[convwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_PointEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_PointEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvwf_PointEN> arrObjLst = new List<clsvwf_PointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_PointEN objvwf_PointEN = new clsvwf_PointEN();
try
{
objvwf_PointEN.PointId = objRow[convwf_Point.PointId].ToString().Trim(); //结点Id
objvwf_PointEN.PointName = objRow[convwf_Point.PointName].ToString().Trim(); //结点名称
objvwf_PointEN.PrjId = objRow[convwf_Point.PrjId].ToString().Trim(); //工程ID
objvwf_PointEN.PrjName = objRow[convwf_Point.PrjName].ToString().Trim(); //工程名称
objvwf_PointEN.TabName = objRow[convwf_Point.TabName] == DBNull.Value ? null : objRow[convwf_Point.TabName].ToString().Trim(); //表名
objvwf_PointEN.TabKeyId = objRow[convwf_Point.TabKeyId] == DBNull.Value ? null : objRow[convwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_Point.InUse].ToString().Trim()); //是否在用
objvwf_PointEN.UpdDate = objRow[convwf_Point.UpdDate] == DBNull.Value ? null : objRow[convwf_Point.UpdDate].ToString().Trim(); //修改日期
objvwf_PointEN.UpdUser = objRow[convwf_Point.UpdUser] == DBNull.Value ? null : objRow[convwf_Point.UpdUser].ToString().Trim(); //修改者
objvwf_PointEN.Memo = objRow[convwf_Point.Memo] == DBNull.Value ? null : objRow[convwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_PointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvwf_PointEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvwf_PointEN> arrObjLst = new List<clsvwf_PointEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_PointEN objvwf_PointEN = new clsvwf_PointEN();
try
{
objvwf_PointEN.PointId = objRow[convwf_Point.PointId].ToString().Trim(); //结点Id
objvwf_PointEN.PointName = objRow[convwf_Point.PointName].ToString().Trim(); //结点名称
objvwf_PointEN.PrjId = objRow[convwf_Point.PrjId].ToString().Trim(); //工程ID
objvwf_PointEN.PrjName = objRow[convwf_Point.PrjName].ToString().Trim(); //工程名称
objvwf_PointEN.TabName = objRow[convwf_Point.TabName] == DBNull.Value ? null : objRow[convwf_Point.TabName].ToString().Trim(); //表名
objvwf_PointEN.TabKeyId = objRow[convwf_Point.TabKeyId] == DBNull.Value ? null : objRow[convwf_Point.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_PointEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convwf_Point.InUse].ToString().Trim()); //是否在用
objvwf_PointEN.UpdDate = objRow[convwf_Point.UpdDate] == DBNull.Value ? null : objRow[convwf_Point.UpdDate].ToString().Trim(); //修改日期
objvwf_PointEN.UpdUser = objRow[convwf_Point.UpdUser] == DBNull.Value ? null : objRow[convwf_Point.UpdUser].ToString().Trim(); //修改者
objvwf_PointEN.Memo = objRow[convwf_Point.Memo] == DBNull.Value ? null : objRow[convwf_Point.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvwf_PointEN.PointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvwf_PointEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvwf_PointEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvwf_Point(ref clsvwf_PointEN objvwf_PointEN)
{
bool bolResult = vwf_PointDA.Getvwf_Point(ref objvwf_PointEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPointId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvwf_PointEN GetObjByPointId(string strPointId)
{
if (strPointId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPointId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPointId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPointId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvwf_PointEN objvwf_PointEN = vwf_PointDA.GetObjByPointId(strPointId);
return objvwf_PointEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvwf_PointEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvwf_PointEN objvwf_PointEN = vwf_PointDA.GetFirstObj(strWhereCond);
 return objvwf_PointEN;
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
public static clsvwf_PointEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvwf_PointEN objvwf_PointEN = vwf_PointDA.GetObjByDataRow(objRow);
 return objvwf_PointEN;
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
public static clsvwf_PointEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvwf_PointEN objvwf_PointEN = vwf_PointDA.GetObjByDataRow(objRow);
 return objvwf_PointEN;
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
 /// <param name = "strPointId">所给的关键字</param>
 /// <param name = "lstvwf_PointObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvwf_PointEN GetObjByPointIdFromList(string strPointId, List<clsvwf_PointEN> lstvwf_PointObjLst)
{
foreach (clsvwf_PointEN objvwf_PointEN in lstvwf_PointObjLst)
{
if (objvwf_PointEN.PointId == strPointId)
{
return objvwf_PointEN;
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
 string strPointId;
 try
 {
 strPointId = new clsvwf_PointDA().GetFirstID(strWhereCond);
 return strPointId;
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
 arrList = vwf_PointDA.GetID(strWhereCond);
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
bool bolIsExist = vwf_PointDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPointId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPointId)
{
if (string.IsNullOrEmpty(strPointId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPointId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vwf_PointDA.IsExist(strPointId);
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
 bolIsExist = clsvwf_PointDA.IsExistTable();
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
 bolIsExist = vwf_PointDA.IsExistTable(strTabName);
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
 /// <param name = "objvwf_PointENS">源对象</param>
 /// <param name = "objvwf_PointENT">目标对象</param>
 public static void CopyTo(clsvwf_PointEN objvwf_PointENS, clsvwf_PointEN objvwf_PointENT)
{
try
{
objvwf_PointENT.PointId = objvwf_PointENS.PointId; //结点Id
objvwf_PointENT.PointName = objvwf_PointENS.PointName; //结点名称
objvwf_PointENT.PrjId = objvwf_PointENS.PrjId; //工程ID
objvwf_PointENT.PrjName = objvwf_PointENS.PrjName; //工程名称
objvwf_PointENT.TabName = objvwf_PointENS.TabName; //表名
objvwf_PointENT.TabKeyId = objvwf_PointENS.TabKeyId; //表关键字Id
objvwf_PointENT.InUse = objvwf_PointENS.InUse; //是否在用
objvwf_PointENT.UpdDate = objvwf_PointENS.UpdDate; //修改日期
objvwf_PointENT.UpdUser = objvwf_PointENS.UpdUser; //修改者
objvwf_PointENT.Memo = objvwf_PointENS.Memo; //说明
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
 /// <param name = "objvwf_PointEN">源简化对象</param>
 public static void SetUpdFlag(clsvwf_PointEN objvwf_PointEN)
{
try
{
objvwf_PointEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvwf_PointEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convwf_Point.PointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_PointEN.PointId = objvwf_PointEN.PointId; //结点Id
}
if (arrFldSet.Contains(convwf_Point.PointName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_PointEN.PointName = objvwf_PointEN.PointName; //结点名称
}
if (arrFldSet.Contains(convwf_Point.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_PointEN.PrjId = objvwf_PointEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convwf_Point.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_PointEN.PrjName = objvwf_PointEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convwf_Point.TabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_PointEN.TabName = objvwf_PointEN.TabName == "[null]" ? null :  objvwf_PointEN.TabName; //表名
}
if (arrFldSet.Contains(convwf_Point.TabKeyId, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_PointEN.TabKeyId = objvwf_PointEN.TabKeyId == "[null]" ? null :  objvwf_PointEN.TabKeyId; //表关键字Id
}
if (arrFldSet.Contains(convwf_Point.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_PointEN.InUse = objvwf_PointEN.InUse; //是否在用
}
if (arrFldSet.Contains(convwf_Point.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_PointEN.UpdDate = objvwf_PointEN.UpdDate == "[null]" ? null :  objvwf_PointEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convwf_Point.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_PointEN.UpdUser = objvwf_PointEN.UpdUser == "[null]" ? null :  objvwf_PointEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convwf_Point.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvwf_PointEN.Memo = objvwf_PointEN.Memo == "[null]" ? null :  objvwf_PointEN.Memo; //说明
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvwf_PointEN">源简化对象</param>
 public static void AccessFldValueNull(clsvwf_PointEN objvwf_PointEN)
{
try
{
if (objvwf_PointEN.TabName == "[null]") objvwf_PointEN.TabName = null; //表名
if (objvwf_PointEN.TabKeyId == "[null]") objvwf_PointEN.TabKeyId = null; //表关键字Id
if (objvwf_PointEN.UpdDate == "[null]") objvwf_PointEN.UpdDate = null; //修改日期
if (objvwf_PointEN.UpdUser == "[null]") objvwf_PointEN.UpdUser = null; //修改者
if (objvwf_PointEN.Memo == "[null]") objvwf_PointEN.Memo = null; //说明
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckProperty4Condition(clsvwf_PointEN objvwf_PointEN)
{
 vwf_PointDA.CheckProperty4Condition(objvwf_PointEN);
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
if (clswf_PointBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_PointBL没有刷新缓存机制(clswf_PointBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clswf_ProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clswf_ProjectsBL没有刷新缓存机制(clswf_ProjectsBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PointId");
//if (arrvwf_PointObjLstCache == null)
//{
//arrvwf_PointObjLstCache = vwf_PointDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPointId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvwf_PointEN GetObjByPointIdCache(string strPointId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvwf_PointEN._CurrTabName);
List<clsvwf_PointEN> arrvwf_PointObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_PointEN> arrvwf_PointObjLst_Sel =
arrvwf_PointObjLstCache
.Where(x=> x.PointId == strPointId 
);
if (arrvwf_PointObjLst_Sel.Count() == 0)
{
   clsvwf_PointEN obj = clsvwf_PointBL.GetObjByPointId(strPointId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvwf_PointObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvwf_PointEN> GetAllvwf_PointObjLstCache()
{
//获取缓存中的对象列表
List<clsvwf_PointEN> arrvwf_PointObjLstCache = GetObjLstCache(); 
return arrvwf_PointObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvwf_PointEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvwf_PointEN._CurrTabName);
List<clsvwf_PointEN> arrvwf_PointObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvwf_PointObjLstCache;
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
string strKey = string.Format("{0}", clsvwf_PointEN._CurrTabName);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvwf_PointObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvwf_PointEN> lstvwf_PointObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvwf_PointObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstvwf_PointObjLst">[clsvwf_PointEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvwf_PointEN> lstvwf_PointObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvwf_PointBL.listXmlNode);
writer.WriteStartElement(clsvwf_PointBL.itemsXmlNode);
foreach (clsvwf_PointEN objvwf_PointEN in lstvwf_PointObjLst)
{
clsvwf_PointBL.SerializeXML(writer, objvwf_PointEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objvwf_PointEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvwf_PointEN objvwf_PointEN)
{
writer.WriteStartElement(clsvwf_PointBL.itemXmlNode);
 
if (objvwf_PointEN.PointId != null)
{
writer.WriteElementString(convwf_Point.PointId, objvwf_PointEN.PointId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_PointEN.PointName != null)
{
writer.WriteElementString(convwf_Point.PointName, objvwf_PointEN.PointName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_PointEN.PrjId != null)
{
writer.WriteElementString(convwf_Point.PrjId, objvwf_PointEN.PrjId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_PointEN.PrjName != null)
{
writer.WriteElementString(convwf_Point.PrjName, objvwf_PointEN.PrjName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_PointEN.TabName != null)
{
writer.WriteElementString(convwf_Point.TabName, objvwf_PointEN.TabName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_PointEN.TabKeyId != null)
{
writer.WriteElementString(convwf_Point.TabKeyId, objvwf_PointEN.TabKeyId.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convwf_Point.InUse, objvwf_PointEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
if (objvwf_PointEN.UpdDate != null)
{
writer.WriteElementString(convwf_Point.UpdDate, objvwf_PointEN.UpdDate.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_PointEN.UpdUser != null)
{
writer.WriteElementString(convwf_Point.UpdUser, objvwf_PointEN.UpdUser.ToString(CultureInfo.InvariantCulture));
}
 
if (objvwf_PointEN.Memo != null)
{
writer.WriteElementString(convwf_Point.Memo, objvwf_PointEN.Memo.ToString(CultureInfo.InvariantCulture));
}
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsvwf_PointEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvwf_PointEN objvwf_PointEN = new clsvwf_PointEN();
reader.Read();
while (!(reader.Name == clsvwf_PointBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convwf_Point.PointId))
{
objvwf_PointEN.PointId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Point.PointName))
{
objvwf_PointEN.PointName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Point.PrjId))
{
objvwf_PointEN.PrjId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Point.PrjName))
{
objvwf_PointEN.PrjName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Point.TabName))
{
objvwf_PointEN.TabName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Point.TabKeyId))
{
objvwf_PointEN.TabKeyId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Point.InUse))
{
objvwf_PointEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convwf_Point.UpdDate))
{
objvwf_PointEN.UpdDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Point.UpdUser))
{
objvwf_PointEN.UpdUser = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convwf_Point.Memo))
{
objvwf_PointEN.Memo = reader.ReadElementContentAsString();
}
}
return objvwf_PointEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvwf_PointObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvwf_PointEN GetObjFromXmlStr(string strvwf_PointObjXmlStr)
{
clsvwf_PointEN objvwf_PointEN = new clsvwf_PointEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvwf_PointObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvwf_PointBL.itemXmlNode))
{
objvwf_PointEN = GetObjFromXml(reader);
return objvwf_PointEN;
}
}
return objvwf_PointEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvwf_PointEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvwf_PointEN objvwf_PointEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvwf_PointEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strPointId)
{
if (strInFldName != convwf_Point.PointId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convwf_Point.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convwf_Point.AttributeName));
throw new Exception(strMsg);
}
var objvwf_Point = clsvwf_PointBL.GetObjByPointIdCache(strPointId);
if (objvwf_Point == null) return "";
return objvwf_Point[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvwf_PointEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvwf_PointEN objvwf_PointEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvwf_PointEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvwf_PointEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstvwf_PointObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvwf_PointEN> lstvwf_PointObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvwf_PointObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvwf_PointEN objvwf_PointEN in lstvwf_PointObjLst)
{
string strJSON_One = SerializeObjToJSON(objvwf_PointEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


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
int intRecCount = clsvwf_PointDA.GetRecCount(strTabName);
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
int intRecCount = clsvwf_PointDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvwf_PointDA.GetRecCount();
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
int intRecCount = clsvwf_PointDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvwf_PointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvwf_PointEN objvwf_PointCond)
{
List<clsvwf_PointEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvwf_PointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convwf_Point.AttributeName)
{
if (objvwf_PointCond.IsUpdated(strFldName) == false) continue;
if (objvwf_PointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_PointCond[strFldName].ToString());
}
else
{
if (objvwf_PointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvwf_PointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvwf_PointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvwf_PointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvwf_PointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvwf_PointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvwf_PointCond[strFldName]));
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
 List<string> arrList = clsvwf_PointDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vwf_PointDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vwf_PointDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}