
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProgLangTypeBL
 表名:vProgLangType(00050405)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:24
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsvProgLangTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strProgLangTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvProgLangTypeEN GetObj(this K_ProgLangTypeId_vProgLangType myKey)
{
clsvProgLangTypeEN objvProgLangTypeEN = clsvProgLangTypeBL.vProgLangTypeDA.GetObjByProgLangTypeId(myKey.Value);
return objvProgLangTypeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetProgLangTypeId(this clsvProgLangTypeEN objvProgLangTypeEN, string strProgLangTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convProgLangType.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convProgLangType.ProgLangTypeId);
}
objvProgLangTypeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.ProgLangTypeId) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.ProgLangTypeId, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.ProgLangTypeId] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetProgLangTypeName(this clsvProgLangTypeEN objvProgLangTypeEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convProgLangType.ProgLangTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convProgLangType.ProgLangTypeName);
}
objvProgLangTypeEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.ProgLangTypeName) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.ProgLangTypeName, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.ProgLangTypeName] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetProgLangTypeENName(this clsvProgLangTypeEN objvProgLangTypeEN, string strProgLangTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeENName, 50, convProgLangType.ProgLangTypeENName);
}
objvProgLangTypeEN.ProgLangTypeENName = strProgLangTypeENName; //编程语言类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.ProgLangTypeENName) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.ProgLangTypeENName, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.ProgLangTypeENName] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetCharEncodingId(this clsvProgLangTypeEN objvProgLangTypeEN, string strCharEncodingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCharEncodingId, convProgLangType.CharEncodingId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCharEncodingId, 20, convProgLangType.CharEncodingId);
}
objvProgLangTypeEN.CharEncodingId = strCharEncodingId; //字符编码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.CharEncodingId) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.CharEncodingId, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.CharEncodingId] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetCharEncodingName(this clsvProgLangTypeEN objvProgLangTypeEN, string strCharEncodingName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCharEncodingName, convProgLangType.CharEncodingName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCharEncodingName, 100, convProgLangType.CharEncodingName);
}
objvProgLangTypeEN.CharEncodingName = strCharEncodingName; //字符编码名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.CharEncodingName) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.CharEncodingName, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.CharEncodingName] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetIsVisible(this clsvProgLangTypeEN objvProgLangTypeEN, bool bolIsVisible, string strComparisonOp="")
	{
objvProgLangTypeEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.IsVisible) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.IsVisible, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.IsVisible] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetOrderNum(this clsvProgLangTypeEN objvProgLangTypeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convProgLangType.OrderNum);
objvProgLangTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.OrderNum) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.OrderNum, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.OrderNum] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetUpdDate(this clsvProgLangTypeEN objvProgLangTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convProgLangType.UpdDate);
}
objvProgLangTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.UpdDate) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.UpdDate, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.UpdDate] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetUpdUserId(this clsvProgLangTypeEN objvProgLangTypeEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convProgLangType.UpdUserId);
}
objvProgLangTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.UpdUserId) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.UpdUserId, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.UpdUserId] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetMemo(this clsvProgLangTypeEN objvProgLangTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convProgLangType.Memo);
}
objvProgLangTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.Memo) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.Memo, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.Memo] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvProgLangTypeENS">源对象</param>
 /// <param name = "objvProgLangTypeENT">目标对象</param>
 public static void CopyTo(this clsvProgLangTypeEN objvProgLangTypeENS, clsvProgLangTypeEN objvProgLangTypeENT)
{
try
{
objvProgLangTypeENT.ProgLangTypeId = objvProgLangTypeENS.ProgLangTypeId; //编程语言类型Id
objvProgLangTypeENT.ProgLangTypeName = objvProgLangTypeENS.ProgLangTypeName; //编程语言类型名
objvProgLangTypeENT.ProgLangTypeENName = objvProgLangTypeENS.ProgLangTypeENName; //编程语言类型英文名
objvProgLangTypeENT.CharEncodingId = objvProgLangTypeENS.CharEncodingId; //字符编码
objvProgLangTypeENT.CharEncodingName = objvProgLangTypeENS.CharEncodingName; //字符编码名称
objvProgLangTypeENT.IsVisible = objvProgLangTypeENS.IsVisible; //是否显示
objvProgLangTypeENT.OrderNum = objvProgLangTypeENS.OrderNum; //序号
objvProgLangTypeENT.UpdDate = objvProgLangTypeENS.UpdDate; //修改日期
objvProgLangTypeENT.UpdUserId = objvProgLangTypeENS.UpdUserId; //修改用户Id
objvProgLangTypeENT.Memo = objvProgLangTypeENS.Memo; //说明
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
 /// <param name = "objvProgLangTypeENS">源对象</param>
 /// <returns>目标对象=>clsvProgLangTypeEN:objvProgLangTypeENT</returns>
 public static clsvProgLangTypeEN CopyTo(this clsvProgLangTypeEN objvProgLangTypeENS)
{
try
{
 clsvProgLangTypeEN objvProgLangTypeENT = new clsvProgLangTypeEN()
{
ProgLangTypeId = objvProgLangTypeENS.ProgLangTypeId, //编程语言类型Id
ProgLangTypeName = objvProgLangTypeENS.ProgLangTypeName, //编程语言类型名
ProgLangTypeENName = objvProgLangTypeENS.ProgLangTypeENName, //编程语言类型英文名
CharEncodingId = objvProgLangTypeENS.CharEncodingId, //字符编码
CharEncodingName = objvProgLangTypeENS.CharEncodingName, //字符编码名称
IsVisible = objvProgLangTypeENS.IsVisible, //是否显示
OrderNum = objvProgLangTypeENS.OrderNum, //序号
UpdDate = objvProgLangTypeENS.UpdDate, //修改日期
UpdUserId = objvProgLangTypeENS.UpdUserId, //修改用户Id
Memo = objvProgLangTypeENS.Memo, //说明
};
 return objvProgLangTypeENT;
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
public static void CheckProperty4Condition(this clsvProgLangTypeEN objvProgLangTypeEN)
{
 clsvProgLangTypeBL.vProgLangTypeDA.CheckProperty4Condition(objvProgLangTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvProgLangTypeEN objvProgLangTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvProgLangTypeCond.IsUpdated(convProgLangType.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.ProgLangTypeId, objvProgLangTypeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.ProgLangTypeName, objvProgLangTypeCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.ProgLangTypeENName) == true)
{
string strComparisonOpProgLangTypeENName = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.ProgLangTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.ProgLangTypeENName, objvProgLangTypeCond.ProgLangTypeENName, strComparisonOpProgLangTypeENName);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.CharEncodingId) == true)
{
string strComparisonOpCharEncodingId = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.CharEncodingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.CharEncodingId, objvProgLangTypeCond.CharEncodingId, strComparisonOpCharEncodingId);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.CharEncodingName) == true)
{
string strComparisonOpCharEncodingName = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.CharEncodingName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.CharEncodingName, objvProgLangTypeCond.CharEncodingName, strComparisonOpCharEncodingName);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.IsVisible) == true)
{
if (objvProgLangTypeCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convProgLangType.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convProgLangType.IsVisible);
}
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.OrderNum) == true)
{
string strComparisonOpOrderNum = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convProgLangType.OrderNum, objvProgLangTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.UpdDate) == true)
{
string strComparisonOpUpdDate = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.UpdDate, objvProgLangTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.UpdUserId, objvProgLangTypeCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.Memo) == true)
{
string strComparisonOpMemo = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.Memo, objvProgLangTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vProgLangType
{
public virtual bool UpdRelaTabDate(string strProgLangTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumvProgLangType
{
 /// <summary>
 /// AA0
 /// </summary>
public const string AA0_00 = "00";
 /// <summary>
 /// CSharp
 /// </summary>
public const string CSharp_01 = "01";
 /// <summary>
 /// JAVA
 /// </summary>
public const string JAVA_02 = "02";
 /// <summary>
 /// Swift
 /// </summary>
public const string Swift_03 = "03";
 /// <summary>
 /// JavaScript
 /// </summary>
public const string JavaScript_04 = "04";
 /// <summary>
 /// SilverLight
 /// </summary>
public const string SilverLight_05 = "05";
 /// <summary>
 /// VB
 /// </summary>
public const string VB_06 = "06";
 /// <summary>
 /// Swift3
 /// </summary>
public const string Swift3_07 = "07";
 /// <summary>
 /// Swift4
 /// </summary>
public const string Swift4_08 = "08";
 /// <summary>
 /// TypeScript
 /// </summary>
public const string TypeScript_09 = "09";
 /// <summary>
 /// Html
 /// </summary>
public const string Html_10 = "10";
}
 /// <summary>
 /// v编程语言类型(vProgLangType)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvProgLangTypeBL
{
public static RelatedActions_vProgLangType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvProgLangTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvProgLangTypeDA vProgLangTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvProgLangTypeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvProgLangTypeBL()
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
if (string.IsNullOrEmpty(clsvProgLangTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvProgLangTypeEN._ConnectString);
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
public static DataTable GetDataTable_vProgLangType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vProgLangTypeDA.GetDataTable_vProgLangType(strWhereCond);
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
objDT = vProgLangTypeDA.GetDataTable(strWhereCond);
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
objDT = vProgLangTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vProgLangTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vProgLangTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vProgLangTypeDA.GetDataTable_Top(objTopPara);
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
objDT = vProgLangTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vProgLangTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vProgLangTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrProgLangTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvProgLangTypeEN> GetObjLstByProgLangTypeIdLst(List<string> arrProgLangTypeIdLst)
{
List<clsvProgLangTypeEN> arrObjLst = new List<clsvProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrProgLangTypeIdLst, true);
 string strWhereCond = string.Format("ProgLangTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
objvProgLangTypeEN.ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvProgLangTypeEN.ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvProgLangTypeEN.ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvProgLangTypeEN.CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objvProgLangTypeEN.CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称
objvProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convProgLangType.IsVisible].ToString().Trim()); //是否显示
objvProgLangTypeEN.OrderNum = Int32.Parse(objRow[convProgLangType.OrderNum].ToString().Trim()); //序号
objvProgLangTypeEN.UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(); //修改日期
objvProgLangTypeEN.UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objvProgLangTypeEN.Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProgLangTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrProgLangTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvProgLangTypeEN> GetObjLstByProgLangTypeIdLstCache(List<string> arrProgLangTypeIdLst)
{
string strKey = string.Format("{0}", clsvProgLangTypeEN._CurrTabName);
List<clsvProgLangTypeEN> arrvProgLangTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvProgLangTypeEN> arrvProgLangTypeObjLst_Sel =
arrvProgLangTypeObjLstCache
.Where(x => arrProgLangTypeIdLst.Contains(x.ProgLangTypeId));
return arrvProgLangTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProgLangTypeEN> GetObjLst(string strWhereCond)
{
List<clsvProgLangTypeEN> arrObjLst = new List<clsvProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
objvProgLangTypeEN.ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvProgLangTypeEN.ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvProgLangTypeEN.ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvProgLangTypeEN.CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objvProgLangTypeEN.CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称
objvProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convProgLangType.IsVisible].ToString().Trim()); //是否显示
objvProgLangTypeEN.OrderNum = Int32.Parse(objRow[convProgLangType.OrderNum].ToString().Trim()); //序号
objvProgLangTypeEN.UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(); //修改日期
objvProgLangTypeEN.UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objvProgLangTypeEN.Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProgLangTypeEN);
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
public static List<clsvProgLangTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvProgLangTypeEN> arrObjLst = new List<clsvProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
objvProgLangTypeEN.ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvProgLangTypeEN.ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvProgLangTypeEN.ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvProgLangTypeEN.CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objvProgLangTypeEN.CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称
objvProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convProgLangType.IsVisible].ToString().Trim()); //是否显示
objvProgLangTypeEN.OrderNum = Int32.Parse(objRow[convProgLangType.OrderNum].ToString().Trim()); //序号
objvProgLangTypeEN.UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(); //修改日期
objvProgLangTypeEN.UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objvProgLangTypeEN.Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProgLangTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvProgLangTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvProgLangTypeEN> GetSubObjLstCache(clsvProgLangTypeEN objvProgLangTypeCond)
{
List<clsvProgLangTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvProgLangTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convProgLangType._AttributeName)
{
if (objvProgLangTypeCond.IsUpdated(strFldName) == false) continue;
if (objvProgLangTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvProgLangTypeCond[strFldName].ToString());
}
else
{
if (objvProgLangTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvProgLangTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvProgLangTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvProgLangTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvProgLangTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvProgLangTypeCond[strFldName]));
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
public static List<clsvProgLangTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvProgLangTypeEN> arrObjLst = new List<clsvProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
objvProgLangTypeEN.ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvProgLangTypeEN.ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvProgLangTypeEN.ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvProgLangTypeEN.CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objvProgLangTypeEN.CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称
objvProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convProgLangType.IsVisible].ToString().Trim()); //是否显示
objvProgLangTypeEN.OrderNum = Int32.Parse(objRow[convProgLangType.OrderNum].ToString().Trim()); //序号
objvProgLangTypeEN.UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(); //修改日期
objvProgLangTypeEN.UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objvProgLangTypeEN.Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProgLangTypeEN);
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
public static List<clsvProgLangTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvProgLangTypeEN> arrObjLst = new List<clsvProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
objvProgLangTypeEN.ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvProgLangTypeEN.ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvProgLangTypeEN.ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvProgLangTypeEN.CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objvProgLangTypeEN.CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称
objvProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convProgLangType.IsVisible].ToString().Trim()); //是否显示
objvProgLangTypeEN.OrderNum = Int32.Parse(objRow[convProgLangType.OrderNum].ToString().Trim()); //序号
objvProgLangTypeEN.UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(); //修改日期
objvProgLangTypeEN.UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objvProgLangTypeEN.Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProgLangTypeEN);
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
List<clsvProgLangTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvProgLangTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProgLangTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvProgLangTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvProgLangTypeEN> arrObjLst = new List<clsvProgLangTypeEN>(); 
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
	clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
objvProgLangTypeEN.ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvProgLangTypeEN.ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvProgLangTypeEN.ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvProgLangTypeEN.CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objvProgLangTypeEN.CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称
objvProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convProgLangType.IsVisible].ToString().Trim()); //是否显示
objvProgLangTypeEN.OrderNum = Int32.Parse(objRow[convProgLangType.OrderNum].ToString().Trim()); //序号
objvProgLangTypeEN.UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(); //修改日期
objvProgLangTypeEN.UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objvProgLangTypeEN.Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProgLangTypeEN);
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
public static List<clsvProgLangTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvProgLangTypeEN> arrObjLst = new List<clsvProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
objvProgLangTypeEN.ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvProgLangTypeEN.ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvProgLangTypeEN.ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvProgLangTypeEN.CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objvProgLangTypeEN.CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称
objvProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convProgLangType.IsVisible].ToString().Trim()); //是否显示
objvProgLangTypeEN.OrderNum = Int32.Parse(objRow[convProgLangType.OrderNum].ToString().Trim()); //序号
objvProgLangTypeEN.UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(); //修改日期
objvProgLangTypeEN.UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objvProgLangTypeEN.Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProgLangTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvProgLangTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvProgLangTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvProgLangTypeEN> arrObjLst = new List<clsvProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
objvProgLangTypeEN.ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvProgLangTypeEN.ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvProgLangTypeEN.ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvProgLangTypeEN.CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objvProgLangTypeEN.CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称
objvProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convProgLangType.IsVisible].ToString().Trim()); //是否显示
objvProgLangTypeEN.OrderNum = Int32.Parse(objRow[convProgLangType.OrderNum].ToString().Trim()); //序号
objvProgLangTypeEN.UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(); //修改日期
objvProgLangTypeEN.UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objvProgLangTypeEN.Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProgLangTypeEN);
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
public static List<clsvProgLangTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvProgLangTypeEN> arrObjLst = new List<clsvProgLangTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
objvProgLangTypeEN.ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvProgLangTypeEN.ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvProgLangTypeEN.ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvProgLangTypeEN.CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objvProgLangTypeEN.CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称
objvProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convProgLangType.IsVisible].ToString().Trim()); //是否显示
objvProgLangTypeEN.OrderNum = Int32.Parse(objRow[convProgLangType.OrderNum].ToString().Trim()); //序号
objvProgLangTypeEN.UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(); //修改日期
objvProgLangTypeEN.UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objvProgLangTypeEN.Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProgLangTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProgLangTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvProgLangTypeEN> arrObjLst = new List<clsvProgLangTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN();
try
{
objvProgLangTypeEN.ProgLangTypeId = objRow[convProgLangType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvProgLangTypeEN.ProgLangTypeName = objRow[convProgLangType.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvProgLangTypeEN.ProgLangTypeENName = objRow[convProgLangType.ProgLangTypeENName] == DBNull.Value ? null : objRow[convProgLangType.ProgLangTypeENName].ToString().Trim(); //编程语言类型英文名
objvProgLangTypeEN.CharEncodingId = objRow[convProgLangType.CharEncodingId].ToString().Trim(); //字符编码
objvProgLangTypeEN.CharEncodingName = objRow[convProgLangType.CharEncodingName].ToString().Trim(); //字符编码名称
objvProgLangTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convProgLangType.IsVisible].ToString().Trim()); //是否显示
objvProgLangTypeEN.OrderNum = Int32.Parse(objRow[convProgLangType.OrderNum].ToString().Trim()); //序号
objvProgLangTypeEN.UpdDate = objRow[convProgLangType.UpdDate] == DBNull.Value ? null : objRow[convProgLangType.UpdDate].ToString().Trim(); //修改日期
objvProgLangTypeEN.UpdUserId = objRow[convProgLangType.UpdUserId] == DBNull.Value ? null : objRow[convProgLangType.UpdUserId].ToString().Trim(); //修改用户Id
objvProgLangTypeEN.Memo = objRow[convProgLangType.Memo] == DBNull.Value ? null : objRow[convProgLangType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProgLangTypeEN.ProgLangTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProgLangTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvProgLangType(ref clsvProgLangTypeEN objvProgLangTypeEN)
{
bool bolResult = vProgLangTypeDA.GetvProgLangType(ref objvProgLangTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strProgLangTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvProgLangTypeEN GetObjByProgLangTypeId(string strProgLangTypeId)
{
if (strProgLangTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strProgLangTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strProgLangTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strProgLangTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvProgLangTypeEN objvProgLangTypeEN = vProgLangTypeDA.GetObjByProgLangTypeId(strProgLangTypeId);
return objvProgLangTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvProgLangTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvProgLangTypeEN objvProgLangTypeEN = vProgLangTypeDA.GetFirstObj(strWhereCond);
 return objvProgLangTypeEN;
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
public static clsvProgLangTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvProgLangTypeEN objvProgLangTypeEN = vProgLangTypeDA.GetObjByDataRow(objRow);
 return objvProgLangTypeEN;
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
public static clsvProgLangTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvProgLangTypeEN objvProgLangTypeEN = vProgLangTypeDA.GetObjByDataRow(objRow);
 return objvProgLangTypeEN;
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
 /// <param name = "strProgLangTypeId">所给的关键字</param>
 /// <param name = "lstvProgLangTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvProgLangTypeEN GetObjByProgLangTypeIdFromList(string strProgLangTypeId, List<clsvProgLangTypeEN> lstvProgLangTypeObjLst)
{
foreach (clsvProgLangTypeEN objvProgLangTypeEN in lstvProgLangTypeObjLst)
{
if (objvProgLangTypeEN.ProgLangTypeId == strProgLangTypeId)
{
return objvProgLangTypeEN;
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
 string strProgLangTypeId;
 try
 {
 strProgLangTypeId = new clsvProgLangTypeDA().GetFirstID(strWhereCond);
 return strProgLangTypeId;
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
 arrList = vProgLangTypeDA.GetID(strWhereCond);
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
bool bolIsExist = vProgLangTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strProgLangTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strProgLangTypeId)
{
if (string.IsNullOrEmpty(strProgLangTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strProgLangTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vProgLangTypeDA.IsExist(strProgLangTypeId);
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
 bolIsExist = clsvProgLangTypeDA.IsExistTable();
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
 bolIsExist = vProgLangTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objvProgLangTypeENS">源对象</param>
 /// <param name = "objvProgLangTypeENT">目标对象</param>
 public static void CopyTo(clsvProgLangTypeEN objvProgLangTypeENS, clsvProgLangTypeEN objvProgLangTypeENT)
{
try
{
objvProgLangTypeENT.ProgLangTypeId = objvProgLangTypeENS.ProgLangTypeId; //编程语言类型Id
objvProgLangTypeENT.ProgLangTypeName = objvProgLangTypeENS.ProgLangTypeName; //编程语言类型名
objvProgLangTypeENT.ProgLangTypeENName = objvProgLangTypeENS.ProgLangTypeENName; //编程语言类型英文名
objvProgLangTypeENT.CharEncodingId = objvProgLangTypeENS.CharEncodingId; //字符编码
objvProgLangTypeENT.CharEncodingName = objvProgLangTypeENS.CharEncodingName; //字符编码名称
objvProgLangTypeENT.IsVisible = objvProgLangTypeENS.IsVisible; //是否显示
objvProgLangTypeENT.OrderNum = objvProgLangTypeENS.OrderNum; //序号
objvProgLangTypeENT.UpdDate = objvProgLangTypeENS.UpdDate; //修改日期
objvProgLangTypeENT.UpdUserId = objvProgLangTypeENS.UpdUserId; //修改用户Id
objvProgLangTypeENT.Memo = objvProgLangTypeENS.Memo; //说明
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
 /// <param name = "objvProgLangTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsvProgLangTypeEN objvProgLangTypeEN)
{
try
{
objvProgLangTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvProgLangTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convProgLangType.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvProgLangTypeEN.ProgLangTypeId = objvProgLangTypeEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convProgLangType.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvProgLangTypeEN.ProgLangTypeName = objvProgLangTypeEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(convProgLangType.ProgLangTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvProgLangTypeEN.ProgLangTypeENName = objvProgLangTypeEN.ProgLangTypeENName == "[null]" ? null :  objvProgLangTypeEN.ProgLangTypeENName; //编程语言类型英文名
}
if (arrFldSet.Contains(convProgLangType.CharEncodingId, new clsStrCompareIgnoreCase())  ==  true)
{
objvProgLangTypeEN.CharEncodingId = objvProgLangTypeEN.CharEncodingId; //字符编码
}
if (arrFldSet.Contains(convProgLangType.CharEncodingName, new clsStrCompareIgnoreCase())  ==  true)
{
objvProgLangTypeEN.CharEncodingName = objvProgLangTypeEN.CharEncodingName; //字符编码名称
}
if (arrFldSet.Contains(convProgLangType.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvProgLangTypeEN.IsVisible = objvProgLangTypeEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convProgLangType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvProgLangTypeEN.OrderNum = objvProgLangTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(convProgLangType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvProgLangTypeEN.UpdDate = objvProgLangTypeEN.UpdDate == "[null]" ? null :  objvProgLangTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convProgLangType.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvProgLangTypeEN.UpdUserId = objvProgLangTypeEN.UpdUserId == "[null]" ? null :  objvProgLangTypeEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convProgLangType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvProgLangTypeEN.Memo = objvProgLangTypeEN.Memo == "[null]" ? null :  objvProgLangTypeEN.Memo; //说明
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
 /// <param name = "objvProgLangTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvProgLangTypeEN objvProgLangTypeEN)
{
try
{
if (objvProgLangTypeEN.ProgLangTypeENName == "[null]") objvProgLangTypeEN.ProgLangTypeENName = null; //编程语言类型英文名
if (objvProgLangTypeEN.UpdDate == "[null]") objvProgLangTypeEN.UpdDate = null; //修改日期
if (objvProgLangTypeEN.UpdUserId == "[null]") objvProgLangTypeEN.UpdUserId = null; //修改用户Id
if (objvProgLangTypeEN.Memo == "[null]") objvProgLangTypeEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvProgLangTypeEN objvProgLangTypeEN)
{
 vProgLangTypeDA.CheckProperty4Condition(objvProgLangTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_ProgLangTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convProgLangType.ProgLangTypeId); 
List<clsvProgLangTypeEN> arrObjLst = clsvProgLangTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN()
{
ProgLangTypeId = "0",
ProgLangTypeName = "选[v编程语言类型]..."
};
arrObjLst.Insert(0, objvProgLangTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convProgLangType.ProgLangTypeId;
objComboBox.DisplayMember = convProgLangType.ProgLangTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_ProgLangTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v编程语言类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convProgLangType.ProgLangTypeId); 
IEnumerable<clsvProgLangTypeEN> arrObjLst = clsvProgLangTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = convProgLangType.ProgLangTypeId;
objDDL.DataTextField = convProgLangType.ProgLangTypeName;
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
public static void BindDdl_ProgLangTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v编程语言类型]...","0");
List<clsvProgLangTypeEN> arrvProgLangTypeObjLst = GetAllvProgLangTypeObjLstCache(); 
objDDL.DataValueField = convProgLangType.ProgLangTypeId;
objDDL.DataTextField = convProgLangType.ProgLangTypeName;
objDDL.DataSource = arrvProgLangTypeObjLst;
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
if (clsCharEncodingBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCharEncodingBL没有刷新缓存机制(clsCharEncodingBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProgLangTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProgLangTypeBL没有刷新缓存机制(clsProgLangTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ProgLangTypeId");
//if (arrvProgLangTypeObjLstCache == null)
//{
//arrvProgLangTypeObjLstCache = vProgLangTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strProgLangTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvProgLangTypeEN GetObjByProgLangTypeIdCache(string strProgLangTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvProgLangTypeEN._CurrTabName);
List<clsvProgLangTypeEN> arrvProgLangTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvProgLangTypeEN> arrvProgLangTypeObjLst_Sel =
arrvProgLangTypeObjLstCache
.Where(x=> x.ProgLangTypeId == strProgLangTypeId 
);
if (arrvProgLangTypeObjLst_Sel.Count() == 0)
{
   clsvProgLangTypeEN obj = clsvProgLangTypeBL.GetObjByProgLangTypeId(strProgLangTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvProgLangTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strProgLangTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetProgLangTypeNameByProgLangTypeIdCache(string strProgLangTypeId)
{
if (string.IsNullOrEmpty(strProgLangTypeId) == true) return "";
//获取缓存中的对象列表
clsvProgLangTypeEN objvProgLangType = GetObjByProgLangTypeIdCache(strProgLangTypeId);
if (objvProgLangType == null) return "";
return objvProgLangType.ProgLangTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strProgLangTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByProgLangTypeIdCache(string strProgLangTypeId)
{
if (string.IsNullOrEmpty(strProgLangTypeId) == true) return "";
//获取缓存中的对象列表
clsvProgLangTypeEN objvProgLangType = GetObjByProgLangTypeIdCache(strProgLangTypeId);
if (objvProgLangType == null) return "";
return objvProgLangType.ProgLangTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvProgLangTypeEN> GetAllvProgLangTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsvProgLangTypeEN> arrvProgLangTypeObjLstCache = GetObjLstCache(); 
return arrvProgLangTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvProgLangTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvProgLangTypeEN._CurrTabName);
List<clsvProgLangTypeEN> arrvProgLangTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvProgLangTypeObjLstCache;
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
string strKey = string.Format("{0}", clsvProgLangTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvProgLangTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvProgLangTypeEN._RefreshTimeLst.Count == 0) return "";
return clsvProgLangTypeEN._RefreshTimeLst[clsvProgLangTypeEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strProgLangTypeId)
{
if (strInFldName != convProgLangType.ProgLangTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convProgLangType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convProgLangType._AttributeName));
throw new Exception(strMsg);
}
var objvProgLangType = clsvProgLangTypeBL.GetObjByProgLangTypeIdCache(strProgLangTypeId);
if (objvProgLangType == null) return "";
return objvProgLangType[strOutFldName].ToString();
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
int intRecCount = clsvProgLangTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsvProgLangTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvProgLangTypeDA.GetRecCount();
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
int intRecCount = clsvProgLangTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvProgLangTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvProgLangTypeEN objvProgLangTypeCond)
{
List<clsvProgLangTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvProgLangTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convProgLangType._AttributeName)
{
if (objvProgLangTypeCond.IsUpdated(strFldName) == false) continue;
if (objvProgLangTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvProgLangTypeCond[strFldName].ToString());
}
else
{
if (objvProgLangTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvProgLangTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvProgLangTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvProgLangTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvProgLangTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvProgLangTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvProgLangTypeCond[strFldName]));
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
 List<string> arrList = clsvProgLangTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vProgLangTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vProgLangTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}