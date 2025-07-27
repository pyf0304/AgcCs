
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDepartmentInfoBL
 表名:vDepartmentInfo(00050305)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:29
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用户管理(UserManage)
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
public static class clsvDepartmentInfoBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDepartmentInfoEN GetObj(this K_DepartmentId_vDepartmentInfo myKey)
{
clsvDepartmentInfoEN objvDepartmentInfoEN = clsvDepartmentInfoBL.vDepartmentInfoDA.GetObjByDepartmentId(myKey.Value);
return objvDepartmentInfoEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetDepartmentId(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentId, 6, convDepartmentInfo.DepartmentId);
}
objvDepartmentInfoEN.DepartmentId = strDepartmentId; //部门ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.DepartmentId) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.DepartmentId, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.DepartmentId] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetDepartmentName(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDepartmentName, convDepartmentInfo.DepartmentName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentName, 30, convDepartmentInfo.DepartmentName);
}
objvDepartmentInfoEN.DepartmentName = strDepartmentName; //部门名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.DepartmentName) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.DepartmentName, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.DepartmentName] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetDepartmentAbbrName(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strDepartmentAbbrName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentAbbrName, 8, convDepartmentInfo.DepartmentAbbrName);
}
objvDepartmentInfoEN.DepartmentAbbrName = strDepartmentAbbrName; //部门简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.DepartmentAbbrName) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.DepartmentAbbrName, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.DepartmentAbbrName] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetDepartmentTypeId(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strDepartmentTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeId, 2, convDepartmentInfo.DepartmentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDepartmentTypeId, 2, convDepartmentInfo.DepartmentTypeId);
}
objvDepartmentInfoEN.DepartmentTypeId = strDepartmentTypeId; //部门类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.DepartmentTypeId) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.DepartmentTypeId, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.DepartmentTypeId] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetUpDepartmentId(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strUpDepartmentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpDepartmentId, 6, convDepartmentInfo.UpDepartmentId);
}
objvDepartmentInfoEN.UpDepartmentId = strUpDepartmentId; //上级部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.UpDepartmentId) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.UpDepartmentId, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.UpDepartmentId] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetDepartmentTypeName(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strDepartmentTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDepartmentTypeName, 50, convDepartmentInfo.DepartmentTypeName);
}
objvDepartmentInfoEN.DepartmentTypeName = strDepartmentTypeName; //部门类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.DepartmentTypeName) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.DepartmentTypeName, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.DepartmentTypeName] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetInUse(this clsvDepartmentInfoEN objvDepartmentInfoEN, bool bolInUse, string strComparisonOp="")
	{
objvDepartmentInfoEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.InUse) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.InUse, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.InUse] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetOrderNum(this clsvDepartmentInfoEN objvDepartmentInfoEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convDepartmentInfo.OrderNum);
objvDepartmentInfoEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.OrderNum) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.OrderNum, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.OrderNum] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetMemo(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDepartmentInfo.Memo);
}
objvDepartmentInfoEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.Memo) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.Memo, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.Memo] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetUpDepartmentName(this clsvDepartmentInfoEN objvDepartmentInfoEN, string strUpDepartmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpDepartmentName, 30, convDepartmentInfo.UpDepartmentName);
}
objvDepartmentInfoEN.UpDepartmentName = strUpDepartmentName; //上级部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.UpDepartmentName) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.UpDepartmentName, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.UpDepartmentName] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvDepartmentInfoEN SetUserNum(this clsvDepartmentInfoEN objvDepartmentInfoEN, int intUserNum, string strComparisonOp="")
	{
objvDepartmentInfoEN.UserNum = intUserNum; //UserNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDepartmentInfoEN.dicFldComparisonOp.ContainsKey(convDepartmentInfo.UserNum) == false)
{
objvDepartmentInfoEN.dicFldComparisonOp.Add(convDepartmentInfo.UserNum, strComparisonOp);
}
else
{
objvDepartmentInfoEN.dicFldComparisonOp[convDepartmentInfo.UserNum] = strComparisonOp;
}
}
return objvDepartmentInfoEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvDepartmentInfoENS">源对象</param>
 /// <param name = "objvDepartmentInfoENT">目标对象</param>
 public static void CopyTo(this clsvDepartmentInfoEN objvDepartmentInfoENS, clsvDepartmentInfoEN objvDepartmentInfoENT)
{
try
{
objvDepartmentInfoENT.DepartmentId = objvDepartmentInfoENS.DepartmentId; //部门ID
objvDepartmentInfoENT.DepartmentName = objvDepartmentInfoENS.DepartmentName; //部门名称
objvDepartmentInfoENT.DepartmentAbbrName = objvDepartmentInfoENS.DepartmentAbbrName; //部门简称
objvDepartmentInfoENT.DepartmentTypeId = objvDepartmentInfoENS.DepartmentTypeId; //部门类型Id
objvDepartmentInfoENT.UpDepartmentId = objvDepartmentInfoENS.UpDepartmentId; //上级部门Id
objvDepartmentInfoENT.DepartmentTypeName = objvDepartmentInfoENS.DepartmentTypeName; //部门类型
objvDepartmentInfoENT.InUse = objvDepartmentInfoENS.InUse; //是否在用
objvDepartmentInfoENT.OrderNum = objvDepartmentInfoENS.OrderNum; //序号
objvDepartmentInfoENT.Memo = objvDepartmentInfoENS.Memo; //说明
objvDepartmentInfoENT.UpDepartmentName = objvDepartmentInfoENS.UpDepartmentName; //上级部门名
objvDepartmentInfoENT.UserNum = objvDepartmentInfoENS.UserNum; //UserNum
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
 /// <param name = "objvDepartmentInfoENS">源对象</param>
 /// <returns>目标对象=>clsvDepartmentInfoEN:objvDepartmentInfoENT</returns>
 public static clsvDepartmentInfoEN CopyTo(this clsvDepartmentInfoEN objvDepartmentInfoENS)
{
try
{
 clsvDepartmentInfoEN objvDepartmentInfoENT = new clsvDepartmentInfoEN()
{
DepartmentId = objvDepartmentInfoENS.DepartmentId, //部门ID
DepartmentName = objvDepartmentInfoENS.DepartmentName, //部门名称
DepartmentAbbrName = objvDepartmentInfoENS.DepartmentAbbrName, //部门简称
DepartmentTypeId = objvDepartmentInfoENS.DepartmentTypeId, //部门类型Id
UpDepartmentId = objvDepartmentInfoENS.UpDepartmentId, //上级部门Id
DepartmentTypeName = objvDepartmentInfoENS.DepartmentTypeName, //部门类型
InUse = objvDepartmentInfoENS.InUse, //是否在用
OrderNum = objvDepartmentInfoENS.OrderNum, //序号
Memo = objvDepartmentInfoENS.Memo, //说明
UpDepartmentName = objvDepartmentInfoENS.UpDepartmentName, //上级部门名
UserNum = objvDepartmentInfoENS.UserNum, //UserNum
};
 return objvDepartmentInfoENT;
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
public static void CheckProperty4Condition(this clsvDepartmentInfoEN objvDepartmentInfoEN)
{
 clsvDepartmentInfoBL.vDepartmentInfoDA.CheckProperty4Condition(objvDepartmentInfoEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDepartmentInfoEN objvDepartmentInfoCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDepartmentInfoCond.IsUpdated(convDepartmentInfo.DepartmentId) == true)
{
string strComparisonOpDepartmentId = objvDepartmentInfoCond.dicFldComparisonOp[convDepartmentInfo.DepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.DepartmentId, objvDepartmentInfoCond.DepartmentId, strComparisonOpDepartmentId);
}
if (objvDepartmentInfoCond.IsUpdated(convDepartmentInfo.DepartmentName) == true)
{
string strComparisonOpDepartmentName = objvDepartmentInfoCond.dicFldComparisonOp[convDepartmentInfo.DepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.DepartmentName, objvDepartmentInfoCond.DepartmentName, strComparisonOpDepartmentName);
}
if (objvDepartmentInfoCond.IsUpdated(convDepartmentInfo.DepartmentAbbrName) == true)
{
string strComparisonOpDepartmentAbbrName = objvDepartmentInfoCond.dicFldComparisonOp[convDepartmentInfo.DepartmentAbbrName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.DepartmentAbbrName, objvDepartmentInfoCond.DepartmentAbbrName, strComparisonOpDepartmentAbbrName);
}
if (objvDepartmentInfoCond.IsUpdated(convDepartmentInfo.DepartmentTypeId) == true)
{
string strComparisonOpDepartmentTypeId = objvDepartmentInfoCond.dicFldComparisonOp[convDepartmentInfo.DepartmentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.DepartmentTypeId, objvDepartmentInfoCond.DepartmentTypeId, strComparisonOpDepartmentTypeId);
}
if (objvDepartmentInfoCond.IsUpdated(convDepartmentInfo.UpDepartmentId) == true)
{
string strComparisonOpUpDepartmentId = objvDepartmentInfoCond.dicFldComparisonOp[convDepartmentInfo.UpDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.UpDepartmentId, objvDepartmentInfoCond.UpDepartmentId, strComparisonOpUpDepartmentId);
}
if (objvDepartmentInfoCond.IsUpdated(convDepartmentInfo.DepartmentTypeName) == true)
{
string strComparisonOpDepartmentTypeName = objvDepartmentInfoCond.dicFldComparisonOp[convDepartmentInfo.DepartmentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.DepartmentTypeName, objvDepartmentInfoCond.DepartmentTypeName, strComparisonOpDepartmentTypeName);
}
if (objvDepartmentInfoCond.IsUpdated(convDepartmentInfo.InUse) == true)
{
if (objvDepartmentInfoCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convDepartmentInfo.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convDepartmentInfo.InUse);
}
}
if (objvDepartmentInfoCond.IsUpdated(convDepartmentInfo.OrderNum) == true)
{
string strComparisonOpOrderNum = objvDepartmentInfoCond.dicFldComparisonOp[convDepartmentInfo.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convDepartmentInfo.OrderNum, objvDepartmentInfoCond.OrderNum, strComparisonOpOrderNum);
}
if (objvDepartmentInfoCond.IsUpdated(convDepartmentInfo.Memo) == true)
{
string strComparisonOpMemo = objvDepartmentInfoCond.dicFldComparisonOp[convDepartmentInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.Memo, objvDepartmentInfoCond.Memo, strComparisonOpMemo);
}
if (objvDepartmentInfoCond.IsUpdated(convDepartmentInfo.UpDepartmentName) == true)
{
string strComparisonOpUpDepartmentName = objvDepartmentInfoCond.dicFldComparisonOp[convDepartmentInfo.UpDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDepartmentInfo.UpDepartmentName, objvDepartmentInfoCond.UpDepartmentName, strComparisonOpUpDepartmentName);
}
if (objvDepartmentInfoCond.IsUpdated(convDepartmentInfo.UserNum) == true)
{
string strComparisonOpUserNum = objvDepartmentInfoCond.dicFldComparisonOp[convDepartmentInfo.UserNum];
strWhereCond += string.Format(" And {0} {2} {1}", convDepartmentInfo.UserNum, objvDepartmentInfoCond.UserNum, strComparisonOpUserNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vDepartmentInfo
{
public virtual bool UpdRelaTabDate(string strDepartmentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v部门(vDepartmentInfo)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvDepartmentInfoBL
{
public static RelatedActions_vDepartmentInfo relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vDepartmentInfoListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vDepartmentInfoList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvDepartmentInfoEN> arrvDepartmentInfoObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvDepartmentInfoDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvDepartmentInfoDA vDepartmentInfoDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvDepartmentInfoDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvDepartmentInfoBL()
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
if (string.IsNullOrEmpty(clsvDepartmentInfoEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDepartmentInfoEN._ConnectString);
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
objDS = vDepartmentInfoDA.GetDataSet(strWhereCond);
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
objDS = vDepartmentInfoDA.GetDataSet_Top(intTopSize, strWhereCond);
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
objDS = vDepartmentInfoDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
public static DataTable GetDataTable_vDepartmentInfo(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vDepartmentInfoDA.GetDataTable_vDepartmentInfo(strWhereCond);
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
objDT = vDepartmentInfoDA.GetDataTable(strWhereCond);
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
objDT = vDepartmentInfoDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vDepartmentInfoDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vDepartmentInfoDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vDepartmentInfoDA.GetDataTable_Top(objTopPara);
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
objDT = vDepartmentInfoDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vDepartmentInfoDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
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
objDT = vDepartmentInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vDepartmentInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
objDT = vDepartmentInfoDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
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
objDT = vDepartmentInfoDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
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
objDT = vDepartmentInfoDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
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
objDT = vDepartmentInfoDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
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
 /// <param name = "arrDepartmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvDepartmentInfoEN> GetObjLstByDepartmentIdLst(List<string> arrDepartmentIdLst)
{
List<clsvDepartmentInfoEN> arrObjLst = new List<clsvDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDepartmentIdLst, true);
 string strWhereCond = string.Format("DepartmentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
try
{
objvDepartmentInfoEN.DepartmentId = objRow[convDepartmentInfo.DepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objvDepartmentInfoEN.DepartmentName = objRow[convDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objvDepartmentInfoEN.DepartmentAbbrName = objRow[convDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objvDepartmentInfoEN.DepartmentTypeId = objRow[convDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvDepartmentInfoEN.UpDepartmentId = objRow[convDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objvDepartmentInfoEN.DepartmentTypeName = objRow[convDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型
objvDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvDepartmentInfoEN.OrderNum = Int32.Parse(objRow[convDepartmentInfo.OrderNum].ToString().Trim()); //序号
objvDepartmentInfoEN.Memo = objRow[convDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convDepartmentInfo.Memo].ToString().Trim(); //说明
objvDepartmentInfoEN.UpDepartmentName = objRow[convDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门名
objvDepartmentInfoEN.UserNum = objRow[convDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDepartmentInfo.UserNum].ToString().Trim()); //UserNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDepartmentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDepartmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvDepartmentInfoEN> GetObjLstByDepartmentIdLstCache(List<string> arrDepartmentIdLst)
{
string strKey = string.Format("{0}", clsvDepartmentInfoEN._CurrTabName);
List<clsvDepartmentInfoEN> arrvDepartmentInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvDepartmentInfoEN> arrvDepartmentInfoObjLst_Sel =
arrvDepartmentInfoObjLstCache
.Where(x => arrDepartmentIdLst.Contains(x.DepartmentId));
return arrvDepartmentInfoObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDepartmentInfoEN> GetObjLst(string strWhereCond)
{
List<clsvDepartmentInfoEN> arrObjLst = new List<clsvDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
try
{
objvDepartmentInfoEN.DepartmentId = objRow[convDepartmentInfo.DepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objvDepartmentInfoEN.DepartmentName = objRow[convDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objvDepartmentInfoEN.DepartmentAbbrName = objRow[convDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objvDepartmentInfoEN.DepartmentTypeId = objRow[convDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvDepartmentInfoEN.UpDepartmentId = objRow[convDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objvDepartmentInfoEN.DepartmentTypeName = objRow[convDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型
objvDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvDepartmentInfoEN.OrderNum = Int32.Parse(objRow[convDepartmentInfo.OrderNum].ToString().Trim()); //序号
objvDepartmentInfoEN.Memo = objRow[convDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convDepartmentInfo.Memo].ToString().Trim(); //说明
objvDepartmentInfoEN.UpDepartmentName = objRow[convDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门名
objvDepartmentInfoEN.UserNum = objRow[convDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDepartmentInfo.UserNum].ToString().Trim()); //UserNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDepartmentInfoEN);
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
public static List<clsvDepartmentInfoEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvDepartmentInfoEN> arrObjLst = new List<clsvDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
try
{
objvDepartmentInfoEN.DepartmentId = objRow[convDepartmentInfo.DepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objvDepartmentInfoEN.DepartmentName = objRow[convDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objvDepartmentInfoEN.DepartmentAbbrName = objRow[convDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objvDepartmentInfoEN.DepartmentTypeId = objRow[convDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvDepartmentInfoEN.UpDepartmentId = objRow[convDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objvDepartmentInfoEN.DepartmentTypeName = objRow[convDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型
objvDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvDepartmentInfoEN.OrderNum = Int32.Parse(objRow[convDepartmentInfo.OrderNum].ToString().Trim()); //序号
objvDepartmentInfoEN.Memo = objRow[convDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convDepartmentInfo.Memo].ToString().Trim(); //说明
objvDepartmentInfoEN.UpDepartmentName = objRow[convDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门名
objvDepartmentInfoEN.UserNum = objRow[convDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDepartmentInfo.UserNum].ToString().Trim()); //UserNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDepartmentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvDepartmentInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvDepartmentInfoEN> GetSubObjLstCache(clsvDepartmentInfoEN objvDepartmentInfoCond)
{
List<clsvDepartmentInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvDepartmentInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDepartmentInfo.AttributeName)
{
if (objvDepartmentInfoCond.IsUpdated(strFldName) == false) continue;
if (objvDepartmentInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDepartmentInfoCond[strFldName].ToString());
}
else
{
if (objvDepartmentInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDepartmentInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDepartmentInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDepartmentInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDepartmentInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDepartmentInfoCond[strFldName]));
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
public static List<clsvDepartmentInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvDepartmentInfoEN> arrObjLst = new List<clsvDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
try
{
objvDepartmentInfoEN.DepartmentId = objRow[convDepartmentInfo.DepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objvDepartmentInfoEN.DepartmentName = objRow[convDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objvDepartmentInfoEN.DepartmentAbbrName = objRow[convDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objvDepartmentInfoEN.DepartmentTypeId = objRow[convDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvDepartmentInfoEN.UpDepartmentId = objRow[convDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objvDepartmentInfoEN.DepartmentTypeName = objRow[convDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型
objvDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvDepartmentInfoEN.OrderNum = Int32.Parse(objRow[convDepartmentInfo.OrderNum].ToString().Trim()); //序号
objvDepartmentInfoEN.Memo = objRow[convDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convDepartmentInfo.Memo].ToString().Trim(); //说明
objvDepartmentInfoEN.UpDepartmentName = objRow[convDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门名
objvDepartmentInfoEN.UserNum = objRow[convDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDepartmentInfo.UserNum].ToString().Trim()); //UserNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDepartmentInfoEN);
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
public static List<clsvDepartmentInfoEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvDepartmentInfoEN> arrObjLst = new List<clsvDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
try
{
objvDepartmentInfoEN.DepartmentId = objRow[convDepartmentInfo.DepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objvDepartmentInfoEN.DepartmentName = objRow[convDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objvDepartmentInfoEN.DepartmentAbbrName = objRow[convDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objvDepartmentInfoEN.DepartmentTypeId = objRow[convDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvDepartmentInfoEN.UpDepartmentId = objRow[convDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objvDepartmentInfoEN.DepartmentTypeName = objRow[convDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型
objvDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvDepartmentInfoEN.OrderNum = Int32.Parse(objRow[convDepartmentInfo.OrderNum].ToString().Trim()); //序号
objvDepartmentInfoEN.Memo = objRow[convDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convDepartmentInfo.Memo].ToString().Trim(); //说明
objvDepartmentInfoEN.UpDepartmentName = objRow[convDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门名
objvDepartmentInfoEN.UserNum = objRow[convDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDepartmentInfo.UserNum].ToString().Trim()); //UserNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDepartmentInfoEN);
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
List<clsvDepartmentInfoEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvDepartmentInfoEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDepartmentInfoEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvDepartmentInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvDepartmentInfoEN> arrObjLst = new List<clsvDepartmentInfoEN>(); 
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
	clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
try
{
objvDepartmentInfoEN.DepartmentId = objRow[convDepartmentInfo.DepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objvDepartmentInfoEN.DepartmentName = objRow[convDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objvDepartmentInfoEN.DepartmentAbbrName = objRow[convDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objvDepartmentInfoEN.DepartmentTypeId = objRow[convDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvDepartmentInfoEN.UpDepartmentId = objRow[convDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objvDepartmentInfoEN.DepartmentTypeName = objRow[convDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型
objvDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvDepartmentInfoEN.OrderNum = Int32.Parse(objRow[convDepartmentInfo.OrderNum].ToString().Trim()); //序号
objvDepartmentInfoEN.Memo = objRow[convDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convDepartmentInfo.Memo].ToString().Trim(); //说明
objvDepartmentInfoEN.UpDepartmentName = objRow[convDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门名
objvDepartmentInfoEN.UserNum = objRow[convDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDepartmentInfo.UserNum].ToString().Trim()); //UserNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDepartmentInfoEN);
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
public static List<clsvDepartmentInfoEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvDepartmentInfoEN> arrObjLst = new List<clsvDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
try
{
objvDepartmentInfoEN.DepartmentId = objRow[convDepartmentInfo.DepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objvDepartmentInfoEN.DepartmentName = objRow[convDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objvDepartmentInfoEN.DepartmentAbbrName = objRow[convDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objvDepartmentInfoEN.DepartmentTypeId = objRow[convDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvDepartmentInfoEN.UpDepartmentId = objRow[convDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objvDepartmentInfoEN.DepartmentTypeName = objRow[convDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型
objvDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvDepartmentInfoEN.OrderNum = Int32.Parse(objRow[convDepartmentInfo.OrderNum].ToString().Trim()); //序号
objvDepartmentInfoEN.Memo = objRow[convDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convDepartmentInfo.Memo].ToString().Trim(); //说明
objvDepartmentInfoEN.UpDepartmentName = objRow[convDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门名
objvDepartmentInfoEN.UserNum = objRow[convDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDepartmentInfo.UserNum].ToString().Trim()); //UserNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDepartmentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvDepartmentInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvDepartmentInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvDepartmentInfoEN> arrObjLst = new List<clsvDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
try
{
objvDepartmentInfoEN.DepartmentId = objRow[convDepartmentInfo.DepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objvDepartmentInfoEN.DepartmentName = objRow[convDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objvDepartmentInfoEN.DepartmentAbbrName = objRow[convDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objvDepartmentInfoEN.DepartmentTypeId = objRow[convDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvDepartmentInfoEN.UpDepartmentId = objRow[convDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objvDepartmentInfoEN.DepartmentTypeName = objRow[convDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型
objvDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvDepartmentInfoEN.OrderNum = Int32.Parse(objRow[convDepartmentInfo.OrderNum].ToString().Trim()); //序号
objvDepartmentInfoEN.Memo = objRow[convDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convDepartmentInfo.Memo].ToString().Trim(); //说明
objvDepartmentInfoEN.UpDepartmentName = objRow[convDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门名
objvDepartmentInfoEN.UserNum = objRow[convDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDepartmentInfo.UserNum].ToString().Trim()); //UserNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDepartmentInfoEN);
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
public static List<clsvDepartmentInfoEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvDepartmentInfoEN> arrObjLst = new List<clsvDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
try
{
objvDepartmentInfoEN.DepartmentId = objRow[convDepartmentInfo.DepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objvDepartmentInfoEN.DepartmentName = objRow[convDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objvDepartmentInfoEN.DepartmentAbbrName = objRow[convDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objvDepartmentInfoEN.DepartmentTypeId = objRow[convDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvDepartmentInfoEN.UpDepartmentId = objRow[convDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objvDepartmentInfoEN.DepartmentTypeName = objRow[convDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型
objvDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvDepartmentInfoEN.OrderNum = Int32.Parse(objRow[convDepartmentInfo.OrderNum].ToString().Trim()); //序号
objvDepartmentInfoEN.Memo = objRow[convDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convDepartmentInfo.Memo].ToString().Trim(); //说明
objvDepartmentInfoEN.UpDepartmentName = objRow[convDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门名
objvDepartmentInfoEN.UserNum = objRow[convDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDepartmentInfo.UserNum].ToString().Trim()); //UserNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDepartmentInfoEN);
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
public static IEnumerable<clsvDepartmentInfoEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvDepartmentInfoEN objvDepartmentInfoCond, string strOrderBy)
{
List<clsvDepartmentInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvDepartmentInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDepartmentInfo.AttributeName)
{
if (objvDepartmentInfoCond.IsUpdated(strFldName) == false) continue;
if (objvDepartmentInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDepartmentInfoCond[strFldName].ToString());
}
else
{
if (objvDepartmentInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDepartmentInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDepartmentInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDepartmentInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDepartmentInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDepartmentInfoCond[strFldName]));
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
public static IEnumerable<clsvDepartmentInfoEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvDepartmentInfoEN objvDepartmentInfoCond = JsonConvert.DeserializeObject<clsvDepartmentInfoEN>(objPagerPara.whereCond);
if (objvDepartmentInfoCond.sfFldComparisonOp == null)
{
objvDepartmentInfoCond.dicFldComparisonOp = null;
}
else
{
objvDepartmentInfoCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvDepartmentInfoCond.sfFldComparisonOp);
}
clsvDepartmentInfoBL.SetUpdFlag(objvDepartmentInfoCond);
 try
{
CheckProperty4Condition(objvDepartmentInfoCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvDepartmentInfoBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvDepartmentInfoCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDepartmentInfoEN> GetObjLstByRange(stuRangePara objRangePara)
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
public static List<clsvDepartmentInfoEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvDepartmentInfoEN> arrObjLst = new List<clsvDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
try
{
objvDepartmentInfoEN.DepartmentId = objRow[convDepartmentInfo.DepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objvDepartmentInfoEN.DepartmentName = objRow[convDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objvDepartmentInfoEN.DepartmentAbbrName = objRow[convDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objvDepartmentInfoEN.DepartmentTypeId = objRow[convDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvDepartmentInfoEN.UpDepartmentId = objRow[convDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objvDepartmentInfoEN.DepartmentTypeName = objRow[convDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型
objvDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvDepartmentInfoEN.OrderNum = Int32.Parse(objRow[convDepartmentInfo.OrderNum].ToString().Trim()); //序号
objvDepartmentInfoEN.Memo = objRow[convDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convDepartmentInfo.Memo].ToString().Trim(); //说明
objvDepartmentInfoEN.UpDepartmentName = objRow[convDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门名
objvDepartmentInfoEN.UserNum = objRow[convDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDepartmentInfo.UserNum].ToString().Trim()); //UserNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDepartmentInfoEN);
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
public static List<clsvDepartmentInfoEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvDepartmentInfoEN> arrObjLst = new List<clsvDepartmentInfoEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
try
{
objvDepartmentInfoEN.DepartmentId = objRow[convDepartmentInfo.DepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objvDepartmentInfoEN.DepartmentName = objRow[convDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objvDepartmentInfoEN.DepartmentAbbrName = objRow[convDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objvDepartmentInfoEN.DepartmentTypeId = objRow[convDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvDepartmentInfoEN.UpDepartmentId = objRow[convDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objvDepartmentInfoEN.DepartmentTypeName = objRow[convDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型
objvDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvDepartmentInfoEN.OrderNum = Int32.Parse(objRow[convDepartmentInfo.OrderNum].ToString().Trim()); //序号
objvDepartmentInfoEN.Memo = objRow[convDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convDepartmentInfo.Memo].ToString().Trim(); //说明
objvDepartmentInfoEN.UpDepartmentName = objRow[convDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门名
objvDepartmentInfoEN.UserNum = objRow[convDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDepartmentInfo.UserNum].ToString().Trim()); //UserNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDepartmentInfoEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDepartmentInfoEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvDepartmentInfoEN> arrObjLst = new List<clsvDepartmentInfoEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
try
{
objvDepartmentInfoEN.DepartmentId = objRow[convDepartmentInfo.DepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentId].ToString().Trim(); //部门ID
objvDepartmentInfoEN.DepartmentName = objRow[convDepartmentInfo.DepartmentName].ToString().Trim(); //部门名称
objvDepartmentInfoEN.DepartmentAbbrName = objRow[convDepartmentInfo.DepartmentAbbrName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentAbbrName].ToString().Trim(); //部门简称
objvDepartmentInfoEN.DepartmentTypeId = objRow[convDepartmentInfo.DepartmentTypeId] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeId].ToString().Trim(); //部门类型Id
objvDepartmentInfoEN.UpDepartmentId = objRow[convDepartmentInfo.UpDepartmentId] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentId].ToString().Trim(); //上级部门Id
objvDepartmentInfoEN.DepartmentTypeName = objRow[convDepartmentInfo.DepartmentTypeName] == DBNull.Value ? null : objRow[convDepartmentInfo.DepartmentTypeName].ToString().Trim(); //部门类型
objvDepartmentInfoEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convDepartmentInfo.InUse].ToString().Trim()); //是否在用
objvDepartmentInfoEN.OrderNum = Int32.Parse(objRow[convDepartmentInfo.OrderNum].ToString().Trim()); //序号
objvDepartmentInfoEN.Memo = objRow[convDepartmentInfo.Memo] == DBNull.Value ? null : objRow[convDepartmentInfo.Memo].ToString().Trim(); //说明
objvDepartmentInfoEN.UpDepartmentName = objRow[convDepartmentInfo.UpDepartmentName] == DBNull.Value ? null : objRow[convDepartmentInfo.UpDepartmentName].ToString().Trim(); //上级部门名
objvDepartmentInfoEN.UserNum = objRow[convDepartmentInfo.UserNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDepartmentInfo.UserNum].ToString().Trim()); //UserNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDepartmentInfoEN.DepartmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDepartmentInfoEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvDepartmentInfo(ref clsvDepartmentInfoEN objvDepartmentInfoEN)
{
bool bolResult = vDepartmentInfoDA.GetvDepartmentInfo(ref objvDepartmentInfoEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDepartmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDepartmentInfoEN GetObjByDepartmentId(string strDepartmentId)
{
if (strDepartmentId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDepartmentId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDepartmentId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDepartmentId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvDepartmentInfoEN objvDepartmentInfoEN = vDepartmentInfoDA.GetObjByDepartmentId(strDepartmentId);
return objvDepartmentInfoEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvDepartmentInfoEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvDepartmentInfoEN objvDepartmentInfoEN = vDepartmentInfoDA.GetFirstObj(strWhereCond);
 return objvDepartmentInfoEN;
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
public static clsvDepartmentInfoEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvDepartmentInfoEN objvDepartmentInfoEN = vDepartmentInfoDA.GetObjByDataRow(objRow);
 return objvDepartmentInfoEN;
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
public static clsvDepartmentInfoEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvDepartmentInfoEN objvDepartmentInfoEN = vDepartmentInfoDA.GetObjByDataRow(objRow);
 return objvDepartmentInfoEN;
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
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <param name = "lstvDepartmentInfoObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDepartmentInfoEN GetObjByDepartmentIdFromList(string strDepartmentId, List<clsvDepartmentInfoEN> lstvDepartmentInfoObjLst)
{
foreach (clsvDepartmentInfoEN objvDepartmentInfoEN in lstvDepartmentInfoObjLst)
{
if (objvDepartmentInfoEN.DepartmentId == strDepartmentId)
{
return objvDepartmentInfoEN;
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
 string strDepartmentId;
 try
 {
 strDepartmentId = new clsvDepartmentInfoDA().GetFirstID(strWhereCond);
 return strDepartmentId;
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
 arrList = vDepartmentInfoDA.GetID(strWhereCond);
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
bool bolIsExist = vDepartmentInfoDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDepartmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDepartmentId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vDepartmentInfoDA.IsExist(strDepartmentId);
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
 bolIsExist = clsvDepartmentInfoDA.IsExistTable();
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
 bolIsExist = vDepartmentInfoDA.IsExistTable(strTabName);
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
 /// <param name = "objvDepartmentInfoENS">源对象</param>
 /// <param name = "objvDepartmentInfoENT">目标对象</param>
 public static void CopyTo(clsvDepartmentInfoEN objvDepartmentInfoENS, clsvDepartmentInfoEN objvDepartmentInfoENT)
{
try
{
objvDepartmentInfoENT.DepartmentId = objvDepartmentInfoENS.DepartmentId; //部门ID
objvDepartmentInfoENT.DepartmentName = objvDepartmentInfoENS.DepartmentName; //部门名称
objvDepartmentInfoENT.DepartmentAbbrName = objvDepartmentInfoENS.DepartmentAbbrName; //部门简称
objvDepartmentInfoENT.DepartmentTypeId = objvDepartmentInfoENS.DepartmentTypeId; //部门类型Id
objvDepartmentInfoENT.UpDepartmentId = objvDepartmentInfoENS.UpDepartmentId; //上级部门Id
objvDepartmentInfoENT.DepartmentTypeName = objvDepartmentInfoENS.DepartmentTypeName; //部门类型
objvDepartmentInfoENT.InUse = objvDepartmentInfoENS.InUse; //是否在用
objvDepartmentInfoENT.OrderNum = objvDepartmentInfoENS.OrderNum; //序号
objvDepartmentInfoENT.Memo = objvDepartmentInfoENS.Memo; //说明
objvDepartmentInfoENT.UpDepartmentName = objvDepartmentInfoENS.UpDepartmentName; //上级部门名
objvDepartmentInfoENT.UserNum = objvDepartmentInfoENS.UserNum; //UserNum
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
 /// <param name = "objvDepartmentInfoEN">源简化对象</param>
 public static void SetUpdFlag(clsvDepartmentInfoEN objvDepartmentInfoEN)
{
try
{
objvDepartmentInfoEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvDepartmentInfoEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convDepartmentInfo.DepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDepartmentInfoEN.DepartmentId = objvDepartmentInfoEN.DepartmentId == "[null]" ? null :  objvDepartmentInfoEN.DepartmentId; //部门ID
}
if (arrFldSet.Contains(convDepartmentInfo.DepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDepartmentInfoEN.DepartmentName = objvDepartmentInfoEN.DepartmentName; //部门名称
}
if (arrFldSet.Contains(convDepartmentInfo.DepartmentAbbrName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDepartmentInfoEN.DepartmentAbbrName = objvDepartmentInfoEN.DepartmentAbbrName == "[null]" ? null :  objvDepartmentInfoEN.DepartmentAbbrName; //部门简称
}
if (arrFldSet.Contains(convDepartmentInfo.DepartmentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDepartmentInfoEN.DepartmentTypeId = objvDepartmentInfoEN.DepartmentTypeId == "[null]" ? null :  objvDepartmentInfoEN.DepartmentTypeId; //部门类型Id
}
if (arrFldSet.Contains(convDepartmentInfo.UpDepartmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDepartmentInfoEN.UpDepartmentId = objvDepartmentInfoEN.UpDepartmentId == "[null]" ? null :  objvDepartmentInfoEN.UpDepartmentId; //上级部门Id
}
if (arrFldSet.Contains(convDepartmentInfo.DepartmentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDepartmentInfoEN.DepartmentTypeName = objvDepartmentInfoEN.DepartmentTypeName == "[null]" ? null :  objvDepartmentInfoEN.DepartmentTypeName; //部门类型
}
if (arrFldSet.Contains(convDepartmentInfo.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvDepartmentInfoEN.InUse = objvDepartmentInfoEN.InUse; //是否在用
}
if (arrFldSet.Contains(convDepartmentInfo.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvDepartmentInfoEN.OrderNum = objvDepartmentInfoEN.OrderNum; //序号
}
if (arrFldSet.Contains(convDepartmentInfo.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvDepartmentInfoEN.Memo = objvDepartmentInfoEN.Memo == "[null]" ? null :  objvDepartmentInfoEN.Memo; //说明
}
if (arrFldSet.Contains(convDepartmentInfo.UpDepartmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDepartmentInfoEN.UpDepartmentName = objvDepartmentInfoEN.UpDepartmentName == "[null]" ? null :  objvDepartmentInfoEN.UpDepartmentName; //上级部门名
}
if (arrFldSet.Contains(convDepartmentInfo.UserNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvDepartmentInfoEN.UserNum = objvDepartmentInfoEN.UserNum; //UserNum
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
 /// <param name = "objvDepartmentInfoEN">源简化对象</param>
 public static void AccessFldValueNull(clsvDepartmentInfoEN objvDepartmentInfoEN)
{
try
{
if (objvDepartmentInfoEN.DepartmentId == "[null]") objvDepartmentInfoEN.DepartmentId = null; //部门ID
if (objvDepartmentInfoEN.DepartmentAbbrName == "[null]") objvDepartmentInfoEN.DepartmentAbbrName = null; //部门简称
if (objvDepartmentInfoEN.DepartmentTypeId == "[null]") objvDepartmentInfoEN.DepartmentTypeId = null; //部门类型Id
if (objvDepartmentInfoEN.UpDepartmentId == "[null]") objvDepartmentInfoEN.UpDepartmentId = null; //上级部门Id
if (objvDepartmentInfoEN.DepartmentTypeName == "[null]") objvDepartmentInfoEN.DepartmentTypeName = null; //部门类型
if (objvDepartmentInfoEN.Memo == "[null]") objvDepartmentInfoEN.Memo = null; //说明
if (objvDepartmentInfoEN.UpDepartmentName == "[null]") objvDepartmentInfoEN.UpDepartmentName = null; //上级部门名
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
public static void CheckProperty4Condition(clsvDepartmentInfoEN objvDepartmentInfoEN)
{
 vDepartmentInfoDA.CheckProperty4Condition(objvDepartmentInfoEN);
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
if (clsDepartmentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDepartmentInfoBL没有刷新缓存机制(clsDepartmentInfoBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDepartmentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDepartmentTypeBL没有刷新缓存机制(clsDepartmentTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DepartmentId");
//if (arrvDepartmentInfoObjLstCache == null)
//{
//arrvDepartmentInfoObjLstCache = vDepartmentInfoDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDepartmentId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDepartmentInfoEN GetObjByDepartmentIdCache(string strDepartmentId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvDepartmentInfoEN._CurrTabName);
List<clsvDepartmentInfoEN> arrvDepartmentInfoObjLstCache = GetObjLstCache();
IEnumerable <clsvDepartmentInfoEN> arrvDepartmentInfoObjLst_Sel =
arrvDepartmentInfoObjLstCache
.Where(x=> x.DepartmentId == strDepartmentId 
);
if (arrvDepartmentInfoObjLst_Sel.Count() == 0)
{
   clsvDepartmentInfoEN obj = clsvDepartmentInfoBL.GetObjByDepartmentId(strDepartmentId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvDepartmentInfoObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDepartmentInfoEN> GetAllvDepartmentInfoObjLstCache()
{
//获取缓存中的对象列表
List<clsvDepartmentInfoEN> arrvDepartmentInfoObjLstCache = GetObjLstCache(); 
return arrvDepartmentInfoObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDepartmentInfoEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvDepartmentInfoEN._CurrTabName);
List<clsvDepartmentInfoEN> arrvDepartmentInfoObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvDepartmentInfoObjLstCache;
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
string strKey = string.Format("{0}", clsvDepartmentInfoEN._CurrTabName);
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
 /// <param name = "lstvDepartmentInfoObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvDepartmentInfoEN> lstvDepartmentInfoObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvDepartmentInfoObjLst, writer);
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
 /// <param name = "lstvDepartmentInfoObjLst">[clsvDepartmentInfoEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvDepartmentInfoEN> lstvDepartmentInfoObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvDepartmentInfoBL.listXmlNode);
writer.WriteStartElement(clsvDepartmentInfoBL.itemsXmlNode);
foreach (clsvDepartmentInfoEN objvDepartmentInfoEN in lstvDepartmentInfoObjLst)
{
clsvDepartmentInfoBL.SerializeXML(writer, objvDepartmentInfoEN);
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
 /// <param name = "objvDepartmentInfoEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvDepartmentInfoEN objvDepartmentInfoEN)
{
writer.WriteStartElement(clsvDepartmentInfoBL.itemXmlNode);
 
if (objvDepartmentInfoEN.DepartmentId != null)
{
writer.WriteElementString(convDepartmentInfo.DepartmentId, objvDepartmentInfoEN.DepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvDepartmentInfoEN.DepartmentName != null)
{
writer.WriteElementString(convDepartmentInfo.DepartmentName, objvDepartmentInfoEN.DepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvDepartmentInfoEN.DepartmentAbbrName != null)
{
writer.WriteElementString(convDepartmentInfo.DepartmentAbbrName, objvDepartmentInfoEN.DepartmentAbbrName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvDepartmentInfoEN.DepartmentTypeId != null)
{
writer.WriteElementString(convDepartmentInfo.DepartmentTypeId, objvDepartmentInfoEN.DepartmentTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvDepartmentInfoEN.UpDepartmentId != null)
{
writer.WriteElementString(convDepartmentInfo.UpDepartmentId, objvDepartmentInfoEN.UpDepartmentId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvDepartmentInfoEN.DepartmentTypeName != null)
{
writer.WriteElementString(convDepartmentInfo.DepartmentTypeName, objvDepartmentInfoEN.DepartmentTypeName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convDepartmentInfo.InUse, objvDepartmentInfoEN.InUse.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(convDepartmentInfo.OrderNum, objvDepartmentInfoEN.OrderNum.ToString(CultureInfo.InvariantCulture));
 
if (objvDepartmentInfoEN.Memo != null)
{
writer.WriteElementString(convDepartmentInfo.Memo, objvDepartmentInfoEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objvDepartmentInfoEN.UpDepartmentName != null)
{
writer.WriteElementString(convDepartmentInfo.UpDepartmentName, objvDepartmentInfoEN.UpDepartmentName.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convDepartmentInfo.UserNum, objvDepartmentInfoEN.UserNum.ToString());
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
public static clsvDepartmentInfoEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
reader.Read();
while (!(reader.Name == clsvDepartmentInfoBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convDepartmentInfo.DepartmentId))
{
objvDepartmentInfoEN.DepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convDepartmentInfo.DepartmentName))
{
objvDepartmentInfoEN.DepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convDepartmentInfo.DepartmentAbbrName))
{
objvDepartmentInfoEN.DepartmentAbbrName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convDepartmentInfo.DepartmentTypeId))
{
objvDepartmentInfoEN.DepartmentTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convDepartmentInfo.UpDepartmentId))
{
objvDepartmentInfoEN.UpDepartmentId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convDepartmentInfo.DepartmentTypeName))
{
objvDepartmentInfoEN.DepartmentTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convDepartmentInfo.InUse))
{
objvDepartmentInfoEN.InUse = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convDepartmentInfo.OrderNum))
{
objvDepartmentInfoEN.OrderNum = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convDepartmentInfo.Memo))
{
objvDepartmentInfoEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convDepartmentInfo.UpDepartmentName))
{
objvDepartmentInfoEN.UpDepartmentName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convDepartmentInfo.UserNum))
{
objvDepartmentInfoEN.UserNum = reader.ReadElementContentAsInt();
}
}
return objvDepartmentInfoEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvDepartmentInfoObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvDepartmentInfoEN GetObjFromXmlStr(string strvDepartmentInfoObjXmlStr)
{
clsvDepartmentInfoEN objvDepartmentInfoEN = new clsvDepartmentInfoEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvDepartmentInfoObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvDepartmentInfoBL.itemXmlNode))
{
objvDepartmentInfoEN = GetObjFromXml(reader);
return objvDepartmentInfoEN;
}
}
return objvDepartmentInfoEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvDepartmentInfoEN objvDepartmentInfoEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvDepartmentInfoEN);
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
public static string Func(string strInFldName, string strOutFldName, string strDepartmentId)
{
if (strInFldName != convDepartmentInfo.DepartmentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convDepartmentInfo.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convDepartmentInfo.AttributeName));
throw new Exception(strMsg);
}
var objvDepartmentInfo = clsvDepartmentInfoBL.GetObjByDepartmentIdCache(strDepartmentId);
if (objvDepartmentInfo == null) return "";
return objvDepartmentInfo[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvDepartmentInfoEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvDepartmentInfoEN objvDepartmentInfoEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvDepartmentInfoEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvDepartmentInfoEN[strField]);
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
 /// <param name = "lstvDepartmentInfoObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvDepartmentInfoEN> lstvDepartmentInfoObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvDepartmentInfoObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvDepartmentInfoEN objvDepartmentInfoEN in lstvDepartmentInfoObjLst)
{
string strJSON_One = SerializeObjToJSON(objvDepartmentInfoEN);
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
int intRecCount = clsvDepartmentInfoDA.GetRecCount(strTabName);
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
int intRecCount = clsvDepartmentInfoDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvDepartmentInfoDA.GetRecCount();
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
int intRecCount = clsvDepartmentInfoDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvDepartmentInfoCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvDepartmentInfoEN objvDepartmentInfoCond)
{
List<clsvDepartmentInfoEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvDepartmentInfoEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDepartmentInfo.AttributeName)
{
if (objvDepartmentInfoCond.IsUpdated(strFldName) == false) continue;
if (objvDepartmentInfoCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDepartmentInfoCond[strFldName].ToString());
}
else
{
if (objvDepartmentInfoCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDepartmentInfoCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDepartmentInfoCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDepartmentInfoCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDepartmentInfoCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDepartmentInfoCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDepartmentInfoCond[strFldName]));
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
 List<string> arrList = clsvDepartmentInfoDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vDepartmentInfoDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vDepartmentInfoDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}