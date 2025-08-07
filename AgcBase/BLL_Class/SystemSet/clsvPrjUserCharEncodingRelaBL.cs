
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjUserCharEncodingRelaBL
 表名:vPrjUserCharEncodingRela(00050265)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsvPrjUserCharEncodingRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjUserCharEncodingRelaEN GetObj(this K_mId_vPrjUserCharEncodingRela myKey)
{
clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN = clsvPrjUserCharEncodingRelaBL.vPrjUserCharEncodingRelaDA.GetObjBymId(myKey.Value);
return objvPrjUserCharEncodingRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetmId(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, long lngmId, string strComparisonOp="")
	{
objvPrjUserCharEncodingRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.ContainsKey(convPrjUserCharEncodingRela.mId) == false)
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.Add(convPrjUserCharEncodingRela.mId, strComparisonOp);
}
else
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp[convPrjUserCharEncodingRela.mId] = strComparisonOp;
}
}
return objvPrjUserCharEncodingRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetPrjId(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjUserCharEncodingRela.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjUserCharEncodingRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjUserCharEncodingRela.PrjId);
}
objvPrjUserCharEncodingRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.ContainsKey(convPrjUserCharEncodingRela.PrjId) == false)
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.Add(convPrjUserCharEncodingRela.PrjId, strComparisonOp);
}
else
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp[convPrjUserCharEncodingRela.PrjId] = strComparisonOp;
}
}
return objvPrjUserCharEncodingRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetPrjName(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convPrjUserCharEncodingRela.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjUserCharEncodingRela.PrjName);
}
objvPrjUserCharEncodingRelaEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.ContainsKey(convPrjUserCharEncodingRela.PrjName) == false)
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.Add(convPrjUserCharEncodingRela.PrjName, strComparisonOp);
}
else
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp[convPrjUserCharEncodingRela.PrjName] = strComparisonOp;
}
}
return objvPrjUserCharEncodingRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetUserId(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convPrjUserCharEncodingRela.UserId);
}
objvPrjUserCharEncodingRelaEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.ContainsKey(convPrjUserCharEncodingRela.UserId) == false)
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.Add(convPrjUserCharEncodingRela.UserId, strComparisonOp);
}
else
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp[convPrjUserCharEncodingRela.UserId] = strComparisonOp;
}
}
return objvPrjUserCharEncodingRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetUserName(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convPrjUserCharEncodingRela.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convPrjUserCharEncodingRela.UserName);
}
objvPrjUserCharEncodingRelaEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.ContainsKey(convPrjUserCharEncodingRela.UserName) == false)
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.Add(convPrjUserCharEncodingRela.UserName, strComparisonOp);
}
else
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp[convPrjUserCharEncodingRela.UserName] = strComparisonOp;
}
}
return objvPrjUserCharEncodingRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetCharEncodingId(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strCharEncodingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCharEncodingId, convPrjUserCharEncodingRela.CharEncodingId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCharEncodingId, 20, convPrjUserCharEncodingRela.CharEncodingId);
}
objvPrjUserCharEncodingRelaEN.CharEncodingId = strCharEncodingId; //字符编码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.ContainsKey(convPrjUserCharEncodingRela.CharEncodingId) == false)
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.Add(convPrjUserCharEncodingRela.CharEncodingId, strComparisonOp);
}
else
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp[convPrjUserCharEncodingRela.CharEncodingId] = strComparisonOp;
}
}
return objvPrjUserCharEncodingRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetCharEncodingName(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strCharEncodingName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCharEncodingName, convPrjUserCharEncodingRela.CharEncodingName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCharEncodingName, 100, convPrjUserCharEncodingRela.CharEncodingName);
}
objvPrjUserCharEncodingRelaEN.CharEncodingName = strCharEncodingName; //字符编码名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.ContainsKey(convPrjUserCharEncodingRela.CharEncodingName) == false)
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.Add(convPrjUserCharEncodingRela.CharEncodingName, strComparisonOp);
}
else
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp[convPrjUserCharEncodingRela.CharEncodingName] = strComparisonOp;
}
}
return objvPrjUserCharEncodingRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetUpdUserId(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convPrjUserCharEncodingRela.UpdUserId);
}
objvPrjUserCharEncodingRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.ContainsKey(convPrjUserCharEncodingRela.UpdUserId) == false)
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.Add(convPrjUserCharEncodingRela.UpdUserId, strComparisonOp);
}
else
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp[convPrjUserCharEncodingRela.UpdUserId] = strComparisonOp;
}
}
return objvPrjUserCharEncodingRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetUpdDate(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjUserCharEncodingRela.UpdDate);
}
objvPrjUserCharEncodingRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.ContainsKey(convPrjUserCharEncodingRela.UpdDate) == false)
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.Add(convPrjUserCharEncodingRela.UpdDate, strComparisonOp);
}
else
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp[convPrjUserCharEncodingRela.UpdDate] = strComparisonOp;
}
}
return objvPrjUserCharEncodingRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetMemo(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjUserCharEncodingRela.Memo);
}
objvPrjUserCharEncodingRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.ContainsKey(convPrjUserCharEncodingRela.Memo) == false)
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp.Add(convPrjUserCharEncodingRela.Memo, strComparisonOp);
}
else
{
objvPrjUserCharEncodingRelaEN.dicFldComparisonOp[convPrjUserCharEncodingRela.Memo] = strComparisonOp;
}
}
return objvPrjUserCharEncodingRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaENS">源对象</param>
 /// <param name = "objvPrjUserCharEncodingRelaENT">目标对象</param>
 public static void CopyTo(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaENS, clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaENT)
{
try
{
objvPrjUserCharEncodingRelaENT.mId = objvPrjUserCharEncodingRelaENS.mId; //mId
objvPrjUserCharEncodingRelaENT.PrjId = objvPrjUserCharEncodingRelaENS.PrjId; //工程Id
objvPrjUserCharEncodingRelaENT.PrjName = objvPrjUserCharEncodingRelaENS.PrjName; //工程名称
objvPrjUserCharEncodingRelaENT.UserId = objvPrjUserCharEncodingRelaENS.UserId; //用户Id
objvPrjUserCharEncodingRelaENT.UserName = objvPrjUserCharEncodingRelaENS.UserName; //用户名
objvPrjUserCharEncodingRelaENT.CharEncodingId = objvPrjUserCharEncodingRelaENS.CharEncodingId; //字符编码
objvPrjUserCharEncodingRelaENT.CharEncodingName = objvPrjUserCharEncodingRelaENS.CharEncodingName; //字符编码名称
objvPrjUserCharEncodingRelaENT.UpdUserId = objvPrjUserCharEncodingRelaENS.UpdUserId; //修改用户Id
objvPrjUserCharEncodingRelaENT.UpdDate = objvPrjUserCharEncodingRelaENS.UpdDate; //修改日期
objvPrjUserCharEncodingRelaENT.Memo = objvPrjUserCharEncodingRelaENS.Memo; //说明
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
 /// <param name = "objvPrjUserCharEncodingRelaENS">源对象</param>
 /// <returns>目标对象=>clsvPrjUserCharEncodingRelaEN:objvPrjUserCharEncodingRelaENT</returns>
 public static clsvPrjUserCharEncodingRelaEN CopyTo(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaENS)
{
try
{
 clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaENT = new clsvPrjUserCharEncodingRelaEN()
{
mId = objvPrjUserCharEncodingRelaENS.mId, //mId
PrjId = objvPrjUserCharEncodingRelaENS.PrjId, //工程Id
PrjName = objvPrjUserCharEncodingRelaENS.PrjName, //工程名称
UserId = objvPrjUserCharEncodingRelaENS.UserId, //用户Id
UserName = objvPrjUserCharEncodingRelaENS.UserName, //用户名
CharEncodingId = objvPrjUserCharEncodingRelaENS.CharEncodingId, //字符编码
CharEncodingName = objvPrjUserCharEncodingRelaENS.CharEncodingName, //字符编码名称
UpdUserId = objvPrjUserCharEncodingRelaENS.UpdUserId, //修改用户Id
UpdDate = objvPrjUserCharEncodingRelaENS.UpdDate, //修改日期
Memo = objvPrjUserCharEncodingRelaENS.Memo, //说明
};
 return objvPrjUserCharEncodingRelaENT;
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
public static void CheckProperty4Condition(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN)
{
 clsvPrjUserCharEncodingRelaBL.vPrjUserCharEncodingRelaDA.CheckProperty4Condition(objvPrjUserCharEncodingRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjUserCharEncodingRelaCond.IsUpdated(convPrjUserCharEncodingRela.mId) == true)
{
string strComparisonOpmId = objvPrjUserCharEncodingRelaCond.dicFldComparisonOp[convPrjUserCharEncodingRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjUserCharEncodingRela.mId, objvPrjUserCharEncodingRelaCond.mId, strComparisonOpmId);
}
if (objvPrjUserCharEncodingRelaCond.IsUpdated(convPrjUserCharEncodingRela.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjUserCharEncodingRelaCond.dicFldComparisonOp[convPrjUserCharEncodingRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjUserCharEncodingRela.PrjId, objvPrjUserCharEncodingRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjUserCharEncodingRelaCond.IsUpdated(convPrjUserCharEncodingRela.PrjName) == true)
{
string strComparisonOpPrjName = objvPrjUserCharEncodingRelaCond.dicFldComparisonOp[convPrjUserCharEncodingRela.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjUserCharEncodingRela.PrjName, objvPrjUserCharEncodingRelaCond.PrjName, strComparisonOpPrjName);
}
if (objvPrjUserCharEncodingRelaCond.IsUpdated(convPrjUserCharEncodingRela.UserId) == true)
{
string strComparisonOpUserId = objvPrjUserCharEncodingRelaCond.dicFldComparisonOp[convPrjUserCharEncodingRela.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjUserCharEncodingRela.UserId, objvPrjUserCharEncodingRelaCond.UserId, strComparisonOpUserId);
}
if (objvPrjUserCharEncodingRelaCond.IsUpdated(convPrjUserCharEncodingRela.UserName) == true)
{
string strComparisonOpUserName = objvPrjUserCharEncodingRelaCond.dicFldComparisonOp[convPrjUserCharEncodingRela.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjUserCharEncodingRela.UserName, objvPrjUserCharEncodingRelaCond.UserName, strComparisonOpUserName);
}
if (objvPrjUserCharEncodingRelaCond.IsUpdated(convPrjUserCharEncodingRela.CharEncodingId) == true)
{
string strComparisonOpCharEncodingId = objvPrjUserCharEncodingRelaCond.dicFldComparisonOp[convPrjUserCharEncodingRela.CharEncodingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjUserCharEncodingRela.CharEncodingId, objvPrjUserCharEncodingRelaCond.CharEncodingId, strComparisonOpCharEncodingId);
}
if (objvPrjUserCharEncodingRelaCond.IsUpdated(convPrjUserCharEncodingRela.CharEncodingName) == true)
{
string strComparisonOpCharEncodingName = objvPrjUserCharEncodingRelaCond.dicFldComparisonOp[convPrjUserCharEncodingRela.CharEncodingName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjUserCharEncodingRela.CharEncodingName, objvPrjUserCharEncodingRelaCond.CharEncodingName, strComparisonOpCharEncodingName);
}
if (objvPrjUserCharEncodingRelaCond.IsUpdated(convPrjUserCharEncodingRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvPrjUserCharEncodingRelaCond.dicFldComparisonOp[convPrjUserCharEncodingRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjUserCharEncodingRela.UpdUserId, objvPrjUserCharEncodingRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvPrjUserCharEncodingRelaCond.IsUpdated(convPrjUserCharEncodingRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPrjUserCharEncodingRelaCond.dicFldComparisonOp[convPrjUserCharEncodingRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjUserCharEncodingRela.UpdDate, objvPrjUserCharEncodingRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPrjUserCharEncodingRelaCond.IsUpdated(convPrjUserCharEncodingRela.Memo) == true)
{
string strComparisonOpMemo = objvPrjUserCharEncodingRelaCond.dicFldComparisonOp[convPrjUserCharEncodingRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjUserCharEncodingRela.Memo, objvPrjUserCharEncodingRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjUserCharEncodingRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v项目用户字符编码关系(vPrjUserCharEncodingRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjUserCharEncodingRelaBL
{
public static RelatedActions_vPrjUserCharEncodingRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjUserCharEncodingRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjUserCharEncodingRelaDA vPrjUserCharEncodingRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjUserCharEncodingRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjUserCharEncodingRelaBL()
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
if (string.IsNullOrEmpty(clsvPrjUserCharEncodingRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjUserCharEncodingRelaEN._ConnectString);
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
public static DataTable GetDataTable_vPrjUserCharEncodingRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjUserCharEncodingRelaDA.GetDataTable_vPrjUserCharEncodingRela(strWhereCond);
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
objDT = vPrjUserCharEncodingRelaDA.GetDataTable(strWhereCond);
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
objDT = vPrjUserCharEncodingRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjUserCharEncodingRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjUserCharEncodingRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjUserCharEncodingRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vPrjUserCharEncodingRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjUserCharEncodingRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjUserCharEncodingRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvPrjUserCharEncodingRelaEN> arrObjLst = new List<clsvPrjUserCharEncodingRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN = new clsvPrjUserCharEncodingRelaEN();
try
{
objvPrjUserCharEncodingRelaEN.mId = Int32.Parse(objRow[convPrjUserCharEncodingRela.mId].ToString().Trim()); //mId
objvPrjUserCharEncodingRelaEN.PrjId = objRow[convPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id
objvPrjUserCharEncodingRelaEN.PrjName = objRow[convPrjUserCharEncodingRela.PrjName].ToString().Trim(); //工程名称
objvPrjUserCharEncodingRelaEN.UserId = objRow[convPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id
objvPrjUserCharEncodingRelaEN.UserName = objRow[convPrjUserCharEncodingRela.UserName].ToString().Trim(); //用户名
objvPrjUserCharEncodingRelaEN.CharEncodingId = objRow[convPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码
objvPrjUserCharEncodingRelaEN.CharEncodingName = objRow[convPrjUserCharEncodingRela.CharEncodingName].ToString().Trim(); //字符编码名称
objvPrjUserCharEncodingRelaEN.UpdUserId = objRow[convPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjUserCharEncodingRelaEN.UpdDate = objRow[convPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期
objvPrjUserCharEncodingRelaEN.Memo = objRow[convPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjUserCharEncodingRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjUserCharEncodingRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjUserCharEncodingRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvPrjUserCharEncodingRelaEN._CurrTabName);
List<clsvPrjUserCharEncodingRelaEN> arrvPrjUserCharEncodingRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjUserCharEncodingRelaEN> arrvPrjUserCharEncodingRelaObjLst_Sel =
arrvPrjUserCharEncodingRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvPrjUserCharEncodingRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLst(string strWhereCond)
{
List<clsvPrjUserCharEncodingRelaEN> arrObjLst = new List<clsvPrjUserCharEncodingRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN = new clsvPrjUserCharEncodingRelaEN();
try
{
objvPrjUserCharEncodingRelaEN.mId = Int32.Parse(objRow[convPrjUserCharEncodingRela.mId].ToString().Trim()); //mId
objvPrjUserCharEncodingRelaEN.PrjId = objRow[convPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id
objvPrjUserCharEncodingRelaEN.PrjName = objRow[convPrjUserCharEncodingRela.PrjName].ToString().Trim(); //工程名称
objvPrjUserCharEncodingRelaEN.UserId = objRow[convPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id
objvPrjUserCharEncodingRelaEN.UserName = objRow[convPrjUserCharEncodingRela.UserName].ToString().Trim(); //用户名
objvPrjUserCharEncodingRelaEN.CharEncodingId = objRow[convPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码
objvPrjUserCharEncodingRelaEN.CharEncodingName = objRow[convPrjUserCharEncodingRela.CharEncodingName].ToString().Trim(); //字符编码名称
objvPrjUserCharEncodingRelaEN.UpdUserId = objRow[convPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjUserCharEncodingRelaEN.UpdDate = objRow[convPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期
objvPrjUserCharEncodingRelaEN.Memo = objRow[convPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjUserCharEncodingRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjUserCharEncodingRelaEN);
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
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjUserCharEncodingRelaEN> arrObjLst = new List<clsvPrjUserCharEncodingRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN = new clsvPrjUserCharEncodingRelaEN();
try
{
objvPrjUserCharEncodingRelaEN.mId = Int32.Parse(objRow[convPrjUserCharEncodingRela.mId].ToString().Trim()); //mId
objvPrjUserCharEncodingRelaEN.PrjId = objRow[convPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id
objvPrjUserCharEncodingRelaEN.PrjName = objRow[convPrjUserCharEncodingRela.PrjName].ToString().Trim(); //工程名称
objvPrjUserCharEncodingRelaEN.UserId = objRow[convPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id
objvPrjUserCharEncodingRelaEN.UserName = objRow[convPrjUserCharEncodingRela.UserName].ToString().Trim(); //用户名
objvPrjUserCharEncodingRelaEN.CharEncodingId = objRow[convPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码
objvPrjUserCharEncodingRelaEN.CharEncodingName = objRow[convPrjUserCharEncodingRela.CharEncodingName].ToString().Trim(); //字符编码名称
objvPrjUserCharEncodingRelaEN.UpdUserId = objRow[convPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjUserCharEncodingRelaEN.UpdDate = objRow[convPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期
objvPrjUserCharEncodingRelaEN.Memo = objRow[convPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjUserCharEncodingRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjUserCharEncodingRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjUserCharEncodingRelaEN> GetSubObjLstCache(clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaCond)
{
List<clsvPrjUserCharEncodingRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjUserCharEncodingRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjUserCharEncodingRela._AttributeName)
{
if (objvPrjUserCharEncodingRelaCond.IsUpdated(strFldName) == false) continue;
if (objvPrjUserCharEncodingRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjUserCharEncodingRelaCond[strFldName].ToString());
}
else
{
if (objvPrjUserCharEncodingRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjUserCharEncodingRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjUserCharEncodingRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjUserCharEncodingRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjUserCharEncodingRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjUserCharEncodingRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjUserCharEncodingRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjUserCharEncodingRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjUserCharEncodingRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjUserCharEncodingRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjUserCharEncodingRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjUserCharEncodingRelaCond[strFldName]));
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
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjUserCharEncodingRelaEN> arrObjLst = new List<clsvPrjUserCharEncodingRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN = new clsvPrjUserCharEncodingRelaEN();
try
{
objvPrjUserCharEncodingRelaEN.mId = Int32.Parse(objRow[convPrjUserCharEncodingRela.mId].ToString().Trim()); //mId
objvPrjUserCharEncodingRelaEN.PrjId = objRow[convPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id
objvPrjUserCharEncodingRelaEN.PrjName = objRow[convPrjUserCharEncodingRela.PrjName].ToString().Trim(); //工程名称
objvPrjUserCharEncodingRelaEN.UserId = objRow[convPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id
objvPrjUserCharEncodingRelaEN.UserName = objRow[convPrjUserCharEncodingRela.UserName].ToString().Trim(); //用户名
objvPrjUserCharEncodingRelaEN.CharEncodingId = objRow[convPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码
objvPrjUserCharEncodingRelaEN.CharEncodingName = objRow[convPrjUserCharEncodingRela.CharEncodingName].ToString().Trim(); //字符编码名称
objvPrjUserCharEncodingRelaEN.UpdUserId = objRow[convPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjUserCharEncodingRelaEN.UpdDate = objRow[convPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期
objvPrjUserCharEncodingRelaEN.Memo = objRow[convPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjUserCharEncodingRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjUserCharEncodingRelaEN);
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
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjUserCharEncodingRelaEN> arrObjLst = new List<clsvPrjUserCharEncodingRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN = new clsvPrjUserCharEncodingRelaEN();
try
{
objvPrjUserCharEncodingRelaEN.mId = Int32.Parse(objRow[convPrjUserCharEncodingRela.mId].ToString().Trim()); //mId
objvPrjUserCharEncodingRelaEN.PrjId = objRow[convPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id
objvPrjUserCharEncodingRelaEN.PrjName = objRow[convPrjUserCharEncodingRela.PrjName].ToString().Trim(); //工程名称
objvPrjUserCharEncodingRelaEN.UserId = objRow[convPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id
objvPrjUserCharEncodingRelaEN.UserName = objRow[convPrjUserCharEncodingRela.UserName].ToString().Trim(); //用户名
objvPrjUserCharEncodingRelaEN.CharEncodingId = objRow[convPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码
objvPrjUserCharEncodingRelaEN.CharEncodingName = objRow[convPrjUserCharEncodingRela.CharEncodingName].ToString().Trim(); //字符编码名称
objvPrjUserCharEncodingRelaEN.UpdUserId = objRow[convPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjUserCharEncodingRelaEN.UpdDate = objRow[convPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期
objvPrjUserCharEncodingRelaEN.Memo = objRow[convPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjUserCharEncodingRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjUserCharEncodingRelaEN);
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
List<clsvPrjUserCharEncodingRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjUserCharEncodingRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjUserCharEncodingRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjUserCharEncodingRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjUserCharEncodingRelaEN> arrObjLst = new List<clsvPrjUserCharEncodingRelaEN>(); 
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
	clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN = new clsvPrjUserCharEncodingRelaEN();
try
{
objvPrjUserCharEncodingRelaEN.mId = Int32.Parse(objRow[convPrjUserCharEncodingRela.mId].ToString().Trim()); //mId
objvPrjUserCharEncodingRelaEN.PrjId = objRow[convPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id
objvPrjUserCharEncodingRelaEN.PrjName = objRow[convPrjUserCharEncodingRela.PrjName].ToString().Trim(); //工程名称
objvPrjUserCharEncodingRelaEN.UserId = objRow[convPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id
objvPrjUserCharEncodingRelaEN.UserName = objRow[convPrjUserCharEncodingRela.UserName].ToString().Trim(); //用户名
objvPrjUserCharEncodingRelaEN.CharEncodingId = objRow[convPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码
objvPrjUserCharEncodingRelaEN.CharEncodingName = objRow[convPrjUserCharEncodingRela.CharEncodingName].ToString().Trim(); //字符编码名称
objvPrjUserCharEncodingRelaEN.UpdUserId = objRow[convPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjUserCharEncodingRelaEN.UpdDate = objRow[convPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期
objvPrjUserCharEncodingRelaEN.Memo = objRow[convPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjUserCharEncodingRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjUserCharEncodingRelaEN);
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
public static List<clsvPrjUserCharEncodingRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjUserCharEncodingRelaEN> arrObjLst = new List<clsvPrjUserCharEncodingRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN = new clsvPrjUserCharEncodingRelaEN();
try
{
objvPrjUserCharEncodingRelaEN.mId = Int32.Parse(objRow[convPrjUserCharEncodingRela.mId].ToString().Trim()); //mId
objvPrjUserCharEncodingRelaEN.PrjId = objRow[convPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id
objvPrjUserCharEncodingRelaEN.PrjName = objRow[convPrjUserCharEncodingRela.PrjName].ToString().Trim(); //工程名称
objvPrjUserCharEncodingRelaEN.UserId = objRow[convPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id
objvPrjUserCharEncodingRelaEN.UserName = objRow[convPrjUserCharEncodingRela.UserName].ToString().Trim(); //用户名
objvPrjUserCharEncodingRelaEN.CharEncodingId = objRow[convPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码
objvPrjUserCharEncodingRelaEN.CharEncodingName = objRow[convPrjUserCharEncodingRela.CharEncodingName].ToString().Trim(); //字符编码名称
objvPrjUserCharEncodingRelaEN.UpdUserId = objRow[convPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjUserCharEncodingRelaEN.UpdDate = objRow[convPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期
objvPrjUserCharEncodingRelaEN.Memo = objRow[convPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjUserCharEncodingRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjUserCharEncodingRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjUserCharEncodingRelaEN> arrObjLst = new List<clsvPrjUserCharEncodingRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN = new clsvPrjUserCharEncodingRelaEN();
try
{
objvPrjUserCharEncodingRelaEN.mId = Int32.Parse(objRow[convPrjUserCharEncodingRela.mId].ToString().Trim()); //mId
objvPrjUserCharEncodingRelaEN.PrjId = objRow[convPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id
objvPrjUserCharEncodingRelaEN.PrjName = objRow[convPrjUserCharEncodingRela.PrjName].ToString().Trim(); //工程名称
objvPrjUserCharEncodingRelaEN.UserId = objRow[convPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id
objvPrjUserCharEncodingRelaEN.UserName = objRow[convPrjUserCharEncodingRela.UserName].ToString().Trim(); //用户名
objvPrjUserCharEncodingRelaEN.CharEncodingId = objRow[convPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码
objvPrjUserCharEncodingRelaEN.CharEncodingName = objRow[convPrjUserCharEncodingRela.CharEncodingName].ToString().Trim(); //字符编码名称
objvPrjUserCharEncodingRelaEN.UpdUserId = objRow[convPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjUserCharEncodingRelaEN.UpdDate = objRow[convPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期
objvPrjUserCharEncodingRelaEN.Memo = objRow[convPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjUserCharEncodingRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjUserCharEncodingRelaEN);
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
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjUserCharEncodingRelaEN> arrObjLst = new List<clsvPrjUserCharEncodingRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN = new clsvPrjUserCharEncodingRelaEN();
try
{
objvPrjUserCharEncodingRelaEN.mId = Int32.Parse(objRow[convPrjUserCharEncodingRela.mId].ToString().Trim()); //mId
objvPrjUserCharEncodingRelaEN.PrjId = objRow[convPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id
objvPrjUserCharEncodingRelaEN.PrjName = objRow[convPrjUserCharEncodingRela.PrjName].ToString().Trim(); //工程名称
objvPrjUserCharEncodingRelaEN.UserId = objRow[convPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id
objvPrjUserCharEncodingRelaEN.UserName = objRow[convPrjUserCharEncodingRela.UserName].ToString().Trim(); //用户名
objvPrjUserCharEncodingRelaEN.CharEncodingId = objRow[convPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码
objvPrjUserCharEncodingRelaEN.CharEncodingName = objRow[convPrjUserCharEncodingRela.CharEncodingName].ToString().Trim(); //字符编码名称
objvPrjUserCharEncodingRelaEN.UpdUserId = objRow[convPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjUserCharEncodingRelaEN.UpdDate = objRow[convPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期
objvPrjUserCharEncodingRelaEN.Memo = objRow[convPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjUserCharEncodingRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjUserCharEncodingRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjUserCharEncodingRelaEN> arrObjLst = new List<clsvPrjUserCharEncodingRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN = new clsvPrjUserCharEncodingRelaEN();
try
{
objvPrjUserCharEncodingRelaEN.mId = Int32.Parse(objRow[convPrjUserCharEncodingRela.mId].ToString().Trim()); //mId
objvPrjUserCharEncodingRelaEN.PrjId = objRow[convPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id
objvPrjUserCharEncodingRelaEN.PrjName = objRow[convPrjUserCharEncodingRela.PrjName].ToString().Trim(); //工程名称
objvPrjUserCharEncodingRelaEN.UserId = objRow[convPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id
objvPrjUserCharEncodingRelaEN.UserName = objRow[convPrjUserCharEncodingRela.UserName].ToString().Trim(); //用户名
objvPrjUserCharEncodingRelaEN.CharEncodingId = objRow[convPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码
objvPrjUserCharEncodingRelaEN.CharEncodingName = objRow[convPrjUserCharEncodingRela.CharEncodingName].ToString().Trim(); //字符编码名称
objvPrjUserCharEncodingRelaEN.UpdUserId = objRow[convPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjUserCharEncodingRelaEN.UpdDate = objRow[convPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期
objvPrjUserCharEncodingRelaEN.Memo = objRow[convPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[convPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjUserCharEncodingRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjUserCharEncodingRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjUserCharEncodingRela(ref clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN)
{
bool bolResult = vPrjUserCharEncodingRelaDA.GetvPrjUserCharEncodingRela(ref objvPrjUserCharEncodingRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjUserCharEncodingRelaEN GetObjBymId(long lngmId)
{
clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN = vPrjUserCharEncodingRelaDA.GetObjBymId(lngmId);
return objvPrjUserCharEncodingRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjUserCharEncodingRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN = vPrjUserCharEncodingRelaDA.GetFirstObj(strWhereCond);
 return objvPrjUserCharEncodingRelaEN;
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
public static clsvPrjUserCharEncodingRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN = vPrjUserCharEncodingRelaDA.GetObjByDataRow(objRow);
 return objvPrjUserCharEncodingRelaEN;
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
public static clsvPrjUserCharEncodingRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN = vPrjUserCharEncodingRelaDA.GetObjByDataRow(objRow);
 return objvPrjUserCharEncodingRelaEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvPrjUserCharEncodingRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjUserCharEncodingRelaEN GetObjBymIdFromList(long lngmId, List<clsvPrjUserCharEncodingRelaEN> lstvPrjUserCharEncodingRelaObjLst)
{
foreach (clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN in lstvPrjUserCharEncodingRelaObjLst)
{
if (objvPrjUserCharEncodingRelaEN.mId == lngmId)
{
return objvPrjUserCharEncodingRelaEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvPrjUserCharEncodingRelaDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vPrjUserCharEncodingRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vPrjUserCharEncodingRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vPrjUserCharEncodingRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvPrjUserCharEncodingRelaDA.IsExistTable();
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
 bolIsExist = vPrjUserCharEncodingRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjUserCharEncodingRelaENS">源对象</param>
 /// <param name = "objvPrjUserCharEncodingRelaENT">目标对象</param>
 public static void CopyTo(clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaENS, clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaENT)
{
try
{
objvPrjUserCharEncodingRelaENT.mId = objvPrjUserCharEncodingRelaENS.mId; //mId
objvPrjUserCharEncodingRelaENT.PrjId = objvPrjUserCharEncodingRelaENS.PrjId; //工程Id
objvPrjUserCharEncodingRelaENT.PrjName = objvPrjUserCharEncodingRelaENS.PrjName; //工程名称
objvPrjUserCharEncodingRelaENT.UserId = objvPrjUserCharEncodingRelaENS.UserId; //用户Id
objvPrjUserCharEncodingRelaENT.UserName = objvPrjUserCharEncodingRelaENS.UserName; //用户名
objvPrjUserCharEncodingRelaENT.CharEncodingId = objvPrjUserCharEncodingRelaENS.CharEncodingId; //字符编码
objvPrjUserCharEncodingRelaENT.CharEncodingName = objvPrjUserCharEncodingRelaENS.CharEncodingName; //字符编码名称
objvPrjUserCharEncodingRelaENT.UpdUserId = objvPrjUserCharEncodingRelaENS.UpdUserId; //修改用户Id
objvPrjUserCharEncodingRelaENT.UpdDate = objvPrjUserCharEncodingRelaENS.UpdDate; //修改日期
objvPrjUserCharEncodingRelaENT.Memo = objvPrjUserCharEncodingRelaENS.Memo; //说明
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
 /// <param name = "objvPrjUserCharEncodingRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN)
{
try
{
objvPrjUserCharEncodingRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjUserCharEncodingRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjUserCharEncodingRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjUserCharEncodingRelaEN.mId = objvPrjUserCharEncodingRelaEN.mId; //mId
}
if (arrFldSet.Contains(convPrjUserCharEncodingRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjUserCharEncodingRelaEN.PrjId = objvPrjUserCharEncodingRelaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convPrjUserCharEncodingRela.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjUserCharEncodingRelaEN.PrjName = objvPrjUserCharEncodingRelaEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convPrjUserCharEncodingRela.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjUserCharEncodingRelaEN.UserId = objvPrjUserCharEncodingRelaEN.UserId == "[null]" ? null :  objvPrjUserCharEncodingRelaEN.UserId; //用户Id
}
if (arrFldSet.Contains(convPrjUserCharEncodingRela.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjUserCharEncodingRelaEN.UserName = objvPrjUserCharEncodingRelaEN.UserName; //用户名
}
if (arrFldSet.Contains(convPrjUserCharEncodingRela.CharEncodingId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjUserCharEncodingRelaEN.CharEncodingId = objvPrjUserCharEncodingRelaEN.CharEncodingId; //字符编码
}
if (arrFldSet.Contains(convPrjUserCharEncodingRela.CharEncodingName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjUserCharEncodingRelaEN.CharEncodingName = objvPrjUserCharEncodingRelaEN.CharEncodingName; //字符编码名称
}
if (arrFldSet.Contains(convPrjUserCharEncodingRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjUserCharEncodingRelaEN.UpdUserId = objvPrjUserCharEncodingRelaEN.UpdUserId == "[null]" ? null :  objvPrjUserCharEncodingRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convPrjUserCharEncodingRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjUserCharEncodingRelaEN.UpdDate = objvPrjUserCharEncodingRelaEN.UpdDate == "[null]" ? null :  objvPrjUserCharEncodingRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPrjUserCharEncodingRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjUserCharEncodingRelaEN.Memo = objvPrjUserCharEncodingRelaEN.Memo == "[null]" ? null :  objvPrjUserCharEncodingRelaEN.Memo; //说明
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
 /// <param name = "objvPrjUserCharEncodingRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN)
{
try
{
if (objvPrjUserCharEncodingRelaEN.UserId == "[null]") objvPrjUserCharEncodingRelaEN.UserId = null; //用户Id
if (objvPrjUserCharEncodingRelaEN.UpdUserId == "[null]") objvPrjUserCharEncodingRelaEN.UpdUserId = null; //修改用户Id
if (objvPrjUserCharEncodingRelaEN.UpdDate == "[null]") objvPrjUserCharEncodingRelaEN.UpdDate = null; //修改日期
if (objvPrjUserCharEncodingRelaEN.Memo == "[null]") objvPrjUserCharEncodingRelaEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN)
{
 vPrjUserCharEncodingRelaDA.CheckProperty4Condition(objvPrjUserCharEncodingRelaEN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCharEncodingBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCharEncodingBL没有刷新缓存机制(clsCharEncodingBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjUserCharEncodingRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjUserCharEncodingRelaBL没有刷新缓存机制(clsPrjUserCharEncodingRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvPrjUserCharEncodingRelaObjLstCache == null)
//{
//arrvPrjUserCharEncodingRelaObjLstCache = vPrjUserCharEncodingRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjUserCharEncodingRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPrjUserCharEncodingRelaEN._CurrTabName);
List<clsvPrjUserCharEncodingRelaEN> arrvPrjUserCharEncodingRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjUserCharEncodingRelaEN> arrvPrjUserCharEncodingRelaObjLst_Sel =
arrvPrjUserCharEncodingRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvPrjUserCharEncodingRelaObjLst_Sel.Count() == 0)
{
   clsvPrjUserCharEncodingRelaEN obj = clsvPrjUserCharEncodingRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPrjUserCharEncodingRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjUserCharEncodingRelaEN> GetAllvPrjUserCharEncodingRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvPrjUserCharEncodingRelaEN> arrvPrjUserCharEncodingRelaObjLstCache = GetObjLstCache(); 
return arrvPrjUserCharEncodingRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPrjUserCharEncodingRelaEN._CurrTabName);
List<clsvPrjUserCharEncodingRelaEN> arrvPrjUserCharEncodingRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPrjUserCharEncodingRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvPrjUserCharEncodingRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvPrjUserCharEncodingRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjUserCharEncodingRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjUserCharEncodingRelaEN._RefreshTimeLst[clsvPrjUserCharEncodingRelaEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convPrjUserCharEncodingRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjUserCharEncodingRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjUserCharEncodingRela._AttributeName));
throw new Exception(strMsg);
}
var objvPrjUserCharEncodingRela = clsvPrjUserCharEncodingRelaBL.GetObjBymIdCache(lngmId);
if (objvPrjUserCharEncodingRela == null) return "";
return objvPrjUserCharEncodingRela[strOutFldName].ToString();
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
int intRecCount = clsvPrjUserCharEncodingRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjUserCharEncodingRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjUserCharEncodingRelaDA.GetRecCount();
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
int intRecCount = clsvPrjUserCharEncodingRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaCond)
{
List<clsvPrjUserCharEncodingRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjUserCharEncodingRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjUserCharEncodingRela._AttributeName)
{
if (objvPrjUserCharEncodingRelaCond.IsUpdated(strFldName) == false) continue;
if (objvPrjUserCharEncodingRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjUserCharEncodingRelaCond[strFldName].ToString());
}
else
{
if (objvPrjUserCharEncodingRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjUserCharEncodingRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjUserCharEncodingRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjUserCharEncodingRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjUserCharEncodingRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjUserCharEncodingRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjUserCharEncodingRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjUserCharEncodingRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjUserCharEncodingRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjUserCharEncodingRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjUserCharEncodingRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjUserCharEncodingRelaCond[strFldName]));
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
 List<string> arrList = clsvPrjUserCharEncodingRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjUserCharEncodingRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjUserCharEncodingRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}