
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFunctionKeyWordWApi
 表名:CMFunctionKeyWord(00050515)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:39:47
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsCMFunctionKeyWordWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetmId(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, long lngmId, string strComparisonOp="")
	{
objCMFunctionKeyWordEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.mId) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.mId, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.mId] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmFunctionId">函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetCmFunctionId(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strCmFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFunctionId, conCMFunctionKeyWord.CmFunctionId);
clsCheckSql.CheckFieldLen(strCmFunctionId, 8, conCMFunctionKeyWord.CmFunctionId);
clsCheckSql.CheckFieldForeignKey(strCmFunctionId, 8, conCMFunctionKeyWord.CmFunctionId);
objCMFunctionKeyWordEN.CmFunctionId = strCmFunctionId; //函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.CmFunctionId) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.CmFunctionId, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.CmFunctionId] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyword">关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetKeyword(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKeyword, conCMFunctionKeyWord.Keyword);
clsCheckSql.CheckFieldLen(strKeyword, 50, conCMFunctionKeyWord.Keyword);
objCMFunctionKeyWordEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.Keyword) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.Keyword, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.Keyword] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetUpdDate(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMFunctionKeyWord.UpdDate);
objCMFunctionKeyWordEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.UpdDate) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.UpdDate, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.UpdDate] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetUpdUser(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMFunctionKeyWord.UpdUser);
objCMFunctionKeyWordEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.UpdUser) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.UpdUser, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.UpdUser] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetMemo(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMFunctionKeyWord.Memo);
objCMFunctionKeyWordEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.Memo) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.Memo, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.Memo] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSynchToServer">是否同步到Server</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetIsSynchToServer(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, bool bolIsSynchToServer, string strComparisonOp="")
	{
objCMFunctionKeyWordEN.IsSynchToServer = bolIsSynchToServer; //是否同步到Server
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.IsSynchToServer) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.IsSynchToServer, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.IsSynchToServer] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToServerDate">同步到Server日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetSynchToServerDate(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strSynchToServerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToServerDate, 20, conCMFunctionKeyWord.SynchToServerDate);
objCMFunctionKeyWordEN.SynchToServerDate = strSynchToServerDate; //同步到Server日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.SynchToServerDate) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.SynchToServerDate, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.SynchToServerDate] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToServerUser">同步到Server用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetSynchToServerUser(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strSynchToServerUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToServerUser, 20, conCMFunctionKeyWord.SynchToServerUser);
objCMFunctionKeyWordEN.SynchToServerUser = strSynchToServerUser; //同步到Server用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.SynchToServerUser) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.SynchToServerUser, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.SynchToServerUser] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSynchToClient">是否同步到Client</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetIsSynchToClient(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, bool bolIsSynchToClient, string strComparisonOp="")
	{
objCMFunctionKeyWordEN.IsSynchToClient = bolIsSynchToClient; //是否同步到Client
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.IsSynchToClient) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.IsSynchToClient, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.IsSynchToClient] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToClientDate">同步到Client库日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetSynchToClientDate(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strSynchToClientDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToClientDate, 20, conCMFunctionKeyWord.SynchToClientDate);
objCMFunctionKeyWordEN.SynchToClientDate = strSynchToClientDate; //同步到Client库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.SynchToClientDate) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.SynchToClientDate, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.SynchToClientDate] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToClientUser">同步到Client库用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetSynchToClientUser(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strSynchToClientUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToClientUser, 20, conCMFunctionKeyWord.SynchToClientUser);
objCMFunctionKeyWordEN.SynchToClientUser = strSynchToClientUser; //同步到Client库用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.SynchToClientUser) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.SynchToClientUser, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.SynchToClientUser] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynSource">同步来源</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFunctionKeyWordEN SetSynSource(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strSynSource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynSource, 50, conCMFunctionKeyWord.SynSource);
objCMFunctionKeyWordEN.SynSource = strSynSource; //同步来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFunctionKeyWordEN.dicFldComparisonOp.ContainsKey(conCMFunctionKeyWord.SynSource) == false)
{
objCMFunctionKeyWordEN.dicFldComparisonOp.Add(conCMFunctionKeyWord.SynSource, strComparisonOp);
}
else
{
objCMFunctionKeyWordEN.dicFldComparisonOp[conCMFunctionKeyWord.SynSource] = strComparisonOp;
}
}
return objCMFunctionKeyWordEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMFunctionKeyWordEN objCMFunctionKeyWordCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.mId) == true)
{
string strComparisonOpmId = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCMFunctionKeyWord.mId, objCMFunctionKeyWordCond.mId, strComparisonOpmId);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.CmFunctionId) == true)
{
string strComparisonOpCmFunctionId = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.CmFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.CmFunctionId, objCMFunctionKeyWordCond.CmFunctionId, strComparisonOpCmFunctionId);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.Keyword) == true)
{
string strComparisonOpKeyword = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.Keyword, objCMFunctionKeyWordCond.Keyword, strComparisonOpKeyword);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.UpdDate, objCMFunctionKeyWordCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.UpdUser, objCMFunctionKeyWordCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.Memo) == true)
{
string strComparisonOpMemo = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.Memo, objCMFunctionKeyWordCond.Memo, strComparisonOpMemo);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.IsSynchToServer) == true)
{
if (objCMFunctionKeyWordCond.IsSynchToServer == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunctionKeyWord.IsSynchToServer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunctionKeyWord.IsSynchToServer);
}
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.SynchToServerDate) == true)
{
string strComparisonOpSynchToServerDate = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.SynchToServerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.SynchToServerDate, objCMFunctionKeyWordCond.SynchToServerDate, strComparisonOpSynchToServerDate);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.SynchToServerUser) == true)
{
string strComparisonOpSynchToServerUser = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.SynchToServerUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.SynchToServerUser, objCMFunctionKeyWordCond.SynchToServerUser, strComparisonOpSynchToServerUser);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.IsSynchToClient) == true)
{
if (objCMFunctionKeyWordCond.IsSynchToClient == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFunctionKeyWord.IsSynchToClient);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFunctionKeyWord.IsSynchToClient);
}
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.SynchToClientDate) == true)
{
string strComparisonOpSynchToClientDate = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.SynchToClientDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.SynchToClientDate, objCMFunctionKeyWordCond.SynchToClientDate, strComparisonOpSynchToClientDate);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.SynchToClientUser) == true)
{
string strComparisonOpSynchToClientUser = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.SynchToClientUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.SynchToClientUser, objCMFunctionKeyWordCond.SynchToClientUser, strComparisonOpSynchToClientUser);
}
if (objCMFunctionKeyWordCond.IsUpdated(conCMFunctionKeyWord.SynSource) == true)
{
string strComparisonOpSynSource = objCMFunctionKeyWordCond.dicFldComparisonOp[conCMFunctionKeyWord.SynSource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFunctionKeyWord.SynSource, objCMFunctionKeyWordCond.SynSource, strComparisonOpSynSource);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
 if (objCMFunctionKeyWordEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCMFunctionKeyWordEN.sfUpdFldSetStr = objCMFunctionKeyWordEN.getsfUpdFldSetStr();
clsCMFunctionKeyWordWApi.CheckPropertyNew(objCMFunctionKeyWordEN); 
bool bolResult = clsCMFunctionKeyWordWApi.UpdateRecord(objCMFunctionKeyWordEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// 获取唯一性条件串--CMFunctionKeyWord(CM函数关键字), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CMFunctionId_KeyWord
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMFunctionKeyWordEN == null) return "";
if (objCMFunctionKeyWordEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmFunctionId = '{0}'", objCMFunctionKeyWordEN.CmFunctionId);
 sbCondition.AppendFormat(" and Keyword = '{0}'", objCMFunctionKeyWordEN.Keyword);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCMFunctionKeyWordEN.mId);
 sbCondition.AppendFormat(" and CmFunctionId = '{0}'", objCMFunctionKeyWordEN.CmFunctionId);
 sbCondition.AppendFormat(" and Keyword = '{0}'", objCMFunctionKeyWordEN.Keyword);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
try
{
clsCMFunctionKeyWordWApi.CheckPropertyNew(objCMFunctionKeyWordEN); 
bool bolResult = clsCMFunctionKeyWordWApi.AddNewRecord(objCMFunctionKeyWordEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objCMFunctionKeyWordEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strWhereCond)
{
try
{
clsCMFunctionKeyWordWApi.CheckPropertyNew(objCMFunctionKeyWordEN); 
bool bolResult = clsCMFunctionKeyWordWApi.UpdateWithCondition(objCMFunctionKeyWordEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// CM函数关键字(CMFunctionKeyWord)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCMFunctionKeyWordWApi
{
private static readonly string mstrApiControllerName = "CMFunctionKeyWordApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsCMFunctionKeyWordWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
if (!Object.Equals(null, objCMFunctionKeyWordEN.CmFunctionId) && GetStrLen(objCMFunctionKeyWordEN.CmFunctionId) > 8)
{
 throw new Exception("字段[函数Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCMFunctionKeyWordEN.Keyword) && GetStrLen(objCMFunctionKeyWordEN.Keyword) > 50)
{
 throw new Exception("字段[关键字]的长度不能超过50!");
}
if (!Object.Equals(null, objCMFunctionKeyWordEN.UpdDate) && GetStrLen(objCMFunctionKeyWordEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFunctionKeyWordEN.UpdUser) && GetStrLen(objCMFunctionKeyWordEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFunctionKeyWordEN.Memo) && GetStrLen(objCMFunctionKeyWordEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objCMFunctionKeyWordEN.SynchToServerDate) && GetStrLen(objCMFunctionKeyWordEN.SynchToServerDate) > 20)
{
 throw new Exception("字段[同步到Server日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFunctionKeyWordEN.SynchToServerUser) && GetStrLen(objCMFunctionKeyWordEN.SynchToServerUser) > 20)
{
 throw new Exception("字段[同步到Server用户]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFunctionKeyWordEN.SynchToClientDate) && GetStrLen(objCMFunctionKeyWordEN.SynchToClientDate) > 20)
{
 throw new Exception("字段[同步到Client库日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFunctionKeyWordEN.SynchToClientUser) && GetStrLen(objCMFunctionKeyWordEN.SynchToClientUser) > 20)
{
 throw new Exception("字段[同步到Client库用户]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFunctionKeyWordEN.SynSource) && GetStrLen(objCMFunctionKeyWordEN.SynSource) > 50)
{
 throw new Exception("字段[同步来源]的长度不能超过50!");
}
 objCMFunctionKeyWordEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMFunctionKeyWordEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsCMFunctionKeyWordEN objCMFunctionKeyWordEN;
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
objCMFunctionKeyWordEN = JsonConvert.DeserializeObject<clsCMFunctionKeyWordEN>(strJson);
return objCMFunctionKeyWordEN;
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
public static clsCMFunctionKeyWordEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCMFunctionKeyWordEN objCMFunctionKeyWordEN;
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
objCMFunctionKeyWordEN = JsonConvert.DeserializeObject<clsCMFunctionKeyWordEN>(strJson);
return objCMFunctionKeyWordEN;
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
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFunctionKeyWordEN> GetObjLst(string strWhereCond)
{
 List<clsCMFunctionKeyWordEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFunctionKeyWordEN>>(strJson);
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
public static List<clsCMFunctionKeyWordEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsCMFunctionKeyWordEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFunctionKeyWordEN>>(strJson);
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
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFunctionKeyWordEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCMFunctionKeyWordEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFunctionKeyWordEN>>(strJson);
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
public static List<clsCMFunctionKeyWordEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCMFunctionKeyWordEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFunctionKeyWordEN>>(strJson);
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
public static List<clsCMFunctionKeyWordEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCMFunctionKeyWordEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFunctionKeyWordEN>>(strJson);
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
public static List<clsCMFunctionKeyWordEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCMFunctionKeyWordEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFunctionKeyWordEN>>(strJson);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
try
{
 clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = clsCMFunctionKeyWordWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
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
public static int DelCMFunctionKeyWords(List<string> arrmId)
{
string strAction = "DelCMFunctionKeyWords";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelCMFunctionKeyWordsByCond(string strWhereCond)
{
string strAction = "DelCMFunctionKeyWordsByCond";
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
public static bool AddNewRecord(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFunctionKeyWordEN>(objCMFunctionKeyWordEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
 /// <param name = "objCMFunctionKeyWordEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFunctionKeyWordEN>(objCMFunctionKeyWordEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
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
public static bool UpdateRecord(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
if (string.IsNullOrEmpty(objCMFunctionKeyWordEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMFunctionKeyWordEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFunctionKeyWordEN>(objCMFunctionKeyWordEN);
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
 /// <param name = "objCMFunctionKeyWordEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCMFunctionKeyWordEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMFunctionKeyWordEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMFunctionKeyWordEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFunctionKeyWordEN>(objCMFunctionKeyWordEN);
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
 /// <param name = "objCMFunctionKeyWordENS">源对象</param>
 /// <param name = "objCMFunctionKeyWordENT">目标对象</param>
 public static void CopyTo(clsCMFunctionKeyWordEN objCMFunctionKeyWordENS, clsCMFunctionKeyWordEN objCMFunctionKeyWordENT)
{
try
{
objCMFunctionKeyWordENT.mId = objCMFunctionKeyWordENS.mId; //mId
objCMFunctionKeyWordENT.CmFunctionId = objCMFunctionKeyWordENS.CmFunctionId; //函数Id
objCMFunctionKeyWordENT.Keyword = objCMFunctionKeyWordENS.Keyword; //关键字
objCMFunctionKeyWordENT.UpdDate = objCMFunctionKeyWordENS.UpdDate; //修改日期
objCMFunctionKeyWordENT.UpdUser = objCMFunctionKeyWordENS.UpdUser; //修改者
objCMFunctionKeyWordENT.Memo = objCMFunctionKeyWordENS.Memo; //说明
objCMFunctionKeyWordENT.IsSynchToServer = objCMFunctionKeyWordENS.IsSynchToServer; //是否同步到Server
objCMFunctionKeyWordENT.SynchToServerDate = objCMFunctionKeyWordENS.SynchToServerDate; //同步到Server日期
objCMFunctionKeyWordENT.SynchToServerUser = objCMFunctionKeyWordENS.SynchToServerUser; //同步到Server用户
objCMFunctionKeyWordENT.IsSynchToClient = objCMFunctionKeyWordENS.IsSynchToClient; //是否同步到Client
objCMFunctionKeyWordENT.SynchToClientDate = objCMFunctionKeyWordENS.SynchToClientDate; //同步到Client库日期
objCMFunctionKeyWordENT.SynchToClientUser = objCMFunctionKeyWordENS.SynchToClientUser; //同步到Client库用户
objCMFunctionKeyWordENT.SynSource = objCMFunctionKeyWordENS.SynSource; //同步来源
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
public static DataTable ToDataTable(List<clsCMFunctionKeyWordEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCMFunctionKeyWordEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCMFunctionKeyWordEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCMFunctionKeyWordEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCMFunctionKeyWordEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCMFunctionKeyWordEN._AttributeName)
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
string strKey = string.Format("{0}", clsCMFunctionKeyWordEN._CurrTabName);
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
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsCMFunctionKeyWordWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCMFunctionKeyWordEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMFunctionKeyWordWApi.objCommFun4WApi.ReFreshCache();
}
}
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCMFunctionKeyWordEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCMFunctionKeyWord.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conCMFunctionKeyWord.CmFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunctionKeyWord.Keyword, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunctionKeyWord.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunctionKeyWord.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunctionKeyWord.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunctionKeyWord.IsSynchToServer, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMFunctionKeyWord.SynchToServerDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunctionKeyWord.SynchToServerUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunctionKeyWord.IsSynchToClient, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMFunctionKeyWord.SynchToClientDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunctionKeyWord.SynchToClientUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMFunctionKeyWord.SynSource, Type.GetType("System.String"));
foreach (clsCMFunctionKeyWordEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCMFunctionKeyWord.mId] = objInFor[conCMFunctionKeyWord.mId];
objDR[conCMFunctionKeyWord.CmFunctionId] = objInFor[conCMFunctionKeyWord.CmFunctionId];
objDR[conCMFunctionKeyWord.Keyword] = objInFor[conCMFunctionKeyWord.Keyword];
objDR[conCMFunctionKeyWord.UpdDate] = objInFor[conCMFunctionKeyWord.UpdDate];
objDR[conCMFunctionKeyWord.UpdUser] = objInFor[conCMFunctionKeyWord.UpdUser];
objDR[conCMFunctionKeyWord.Memo] = objInFor[conCMFunctionKeyWord.Memo];
objDR[conCMFunctionKeyWord.IsSynchToServer] = objInFor[conCMFunctionKeyWord.IsSynchToServer];
objDR[conCMFunctionKeyWord.SynchToServerDate] = objInFor[conCMFunctionKeyWord.SynchToServerDate];
objDR[conCMFunctionKeyWord.SynchToServerUser] = objInFor[conCMFunctionKeyWord.SynchToServerUser];
objDR[conCMFunctionKeyWord.IsSynchToClient] = objInFor[conCMFunctionKeyWord.IsSynchToClient];
objDR[conCMFunctionKeyWord.SynchToClientDate] = objInFor[conCMFunctionKeyWord.SynchToClientDate];
objDR[conCMFunctionKeyWord.SynchToClientUser] = objInFor[conCMFunctionKeyWord.SynchToClientUser];
objDR[conCMFunctionKeyWord.SynSource] = objInFor[conCMFunctionKeyWord.SynSource];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// CM函数关键字(CMFunctionKeyWord)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CMFunctionKeyWord : clsCommFun4BL
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
clsCMFunctionKeyWordWApi.ReFreshThisCache();
}
}

}