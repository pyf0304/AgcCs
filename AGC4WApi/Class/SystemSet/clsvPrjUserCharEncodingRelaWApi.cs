
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjUserCharEncodingRelaWApi
 表名:vPrjUserCharEncodingRela(00050265)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:06:51
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsvPrjUserCharEncodingRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetPrjId(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjUserCharEncodingRela.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjUserCharEncodingRela.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjUserCharEncodingRela.PrjId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetPrjName(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convPrjUserCharEncodingRela.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convPrjUserCharEncodingRela.PrjName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetUserId(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 18, convPrjUserCharEncodingRela.UserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetUserName(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convPrjUserCharEncodingRela.UserName);
clsCheckSql.CheckFieldLen(strUserName, 30, convPrjUserCharEncodingRela.UserName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCharEncodingId">字符编码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetCharEncodingId(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strCharEncodingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCharEncodingId, convPrjUserCharEncodingRela.CharEncodingId);
clsCheckSql.CheckFieldLen(strCharEncodingId, 20, convPrjUserCharEncodingRela.CharEncodingId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCharEncodingName">字符编码名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetCharEncodingName(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strCharEncodingName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCharEncodingName, convPrjUserCharEncodingRela.CharEncodingName);
clsCheckSql.CheckFieldLen(strCharEncodingName, 100, convPrjUserCharEncodingRela.CharEncodingName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetUpdUserId(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convPrjUserCharEncodingRela.UpdUserId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetUpdDate(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPrjUserCharEncodingRela.UpdDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjUserCharEncodingRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjUserCharEncodingRelaEN SetMemo(this clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPrjUserCharEncodingRela.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
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
 /// v项目用户字符编码关系(vPrjUserCharEncodingRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPrjUserCharEncodingRelaWApi
{
private static readonly string mstrApiControllerName = "vPrjUserCharEncodingRelaApi";

 public clsvPrjUserCharEncodingRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjUserCharEncodingRelaEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvPrjUserCharEncodingRelaEN = JsonConvert.DeserializeObject<clsvPrjUserCharEncodingRelaEN>(strJson);
return objvPrjUserCharEncodingRelaEN;
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
public static clsvPrjUserCharEncodingRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvPrjUserCharEncodingRelaEN objvPrjUserCharEncodingRelaEN;
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
objvPrjUserCharEncodingRelaEN = JsonConvert.DeserializeObject<clsvPrjUserCharEncodingRelaEN>(strJson);
return objvPrjUserCharEncodingRelaEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjUserCharEncodingRelaEN GetObjBymIdCache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPrjUserCharEncodingRelaEN._CurrTabName);
List<clsvPrjUserCharEncodingRelaEN> arrvPrjUserCharEncodingRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjUserCharEncodingRelaEN> arrvPrjUserCharEncodingRelaObjLst_Sel =
from objvPrjUserCharEncodingRelaEN in arrvPrjUserCharEncodingRelaObjLstCache
where objvPrjUserCharEncodingRelaEN.mId == lngmId 
select objvPrjUserCharEncodingRelaEN;
if (arrvPrjUserCharEncodingRelaObjLst_Sel.Count() == 0)
{
   clsvPrjUserCharEncodingRelaEN obj = clsvPrjUserCharEncodingRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPrjUserCharEncodingRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvPrjUserCharEncodingRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjUserCharEncodingRelaEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvPrjUserCharEncodingRelaEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjUserCharEncodingRelaEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvPrjUserCharEncodingRelaEN> GetObjLstByMIdLstCache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPrjUserCharEncodingRelaEN._CurrTabName);
List<clsvPrjUserCharEncodingRelaEN> arrvPrjUserCharEncodingRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjUserCharEncodingRelaEN> arrvPrjUserCharEncodingRelaObjLst_Sel =
from objvPrjUserCharEncodingRelaEN in arrvPrjUserCharEncodingRelaObjLstCache
where arrMId.Contains(objvPrjUserCharEncodingRelaEN.mId)
select objvPrjUserCharEncodingRelaEN;
return arrvPrjUserCharEncodingRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjUserCharEncodingRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPrjUserCharEncodingRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjUserCharEncodingRelaEN>>(strJson);
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
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPrjUserCharEncodingRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjUserCharEncodingRelaEN>>(strJson);
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
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPrjUserCharEncodingRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjUserCharEncodingRelaEN>>(strJson);
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
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvPrjUserCharEncodingRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPrjUserCharEncodingRelaEN>>(strJson);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
public static DataTable ToDataTable(List<clsvPrjUserCharEncodingRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPrjUserCharEncodingRelaEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPrjUserCharEncodingRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPrjUserCharEncodingRelaEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPrjUserCharEncodingRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPrjUserCharEncodingRelaEN._AttributeName)
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
string strKey = string.Format("{0}", clsvPrjUserCharEncodingRelaEN._CurrTabName);
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
public static List<clsvPrjUserCharEncodingRelaEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvPrjUserCharEncodingRelaEN._CurrTabName;
List<clsvPrjUserCharEncodingRelaEN> arrvPrjUserCharEncodingRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvPrjUserCharEncodingRelaObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPrjUserCharEncodingRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPrjUserCharEncodingRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convPrjUserCharEncodingRela.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjUserCharEncodingRela.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjUserCharEncodingRela.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjUserCharEncodingRela.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjUserCharEncodingRela.CharEncodingId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjUserCharEncodingRela.CharEncodingName, Type.GetType("System.String"));
objDT.Columns.Add(convPrjUserCharEncodingRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convPrjUserCharEncodingRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPrjUserCharEncodingRela.Memo, Type.GetType("System.String"));
foreach (clsvPrjUserCharEncodingRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPrjUserCharEncodingRela.mId] = objInFor[convPrjUserCharEncodingRela.mId];
objDR[convPrjUserCharEncodingRela.PrjId] = objInFor[convPrjUserCharEncodingRela.PrjId];
objDR[convPrjUserCharEncodingRela.PrjName] = objInFor[convPrjUserCharEncodingRela.PrjName];
objDR[convPrjUserCharEncodingRela.UserId] = objInFor[convPrjUserCharEncodingRela.UserId];
objDR[convPrjUserCharEncodingRela.UserName] = objInFor[convPrjUserCharEncodingRela.UserName];
objDR[convPrjUserCharEncodingRela.CharEncodingId] = objInFor[convPrjUserCharEncodingRela.CharEncodingId];
objDR[convPrjUserCharEncodingRela.CharEncodingName] = objInFor[convPrjUserCharEncodingRela.CharEncodingName];
objDR[convPrjUserCharEncodingRela.UpdUserId] = objInFor[convPrjUserCharEncodingRela.UpdUserId];
objDR[convPrjUserCharEncodingRela.UpdDate] = objInFor[convPrjUserCharEncodingRela.UpdDate];
objDR[convPrjUserCharEncodingRela.Memo] = objInFor[convPrjUserCharEncodingRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}