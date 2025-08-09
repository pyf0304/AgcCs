
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvClass4GeneCodeWApi
 表名:vWebSrvClass4GeneCode(00050372)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:43
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsvWebSrvClass4GeneCodeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvClassId">类Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetWebSrvClassId(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strWebSrvClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWebSrvClassId, 8, convWebSrvClass4GeneCode.WebSrvClassId);
clsCheckSql.CheckFieldForeignKey(strWebSrvClassId, 8, convWebSrvClass4GeneCode.WebSrvClassId);
objvWebSrvClass4GeneCodeEN.WebSrvClassId = strWebSrvClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.WebSrvClassId) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.WebSrvClassId, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.WebSrvClassId] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserName">用户名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetUserName(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 30, convWebSrvClass4GeneCode.UserName);
objvWebSrvClass4GeneCodeEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.UserName) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.UserName, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.UserName] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "intFuncNum">函数个数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetFuncNum(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, int intFuncNum, string strComparisonOp="")
	{
objvWebSrvClass4GeneCodeEN.FuncNum = intFuncNum; //函数个数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.FuncNum) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.FuncNum, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.FuncNum] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strGeneCodeDate">生成代码日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetGeneCodeDate(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strGeneCodeDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convWebSrvClass4GeneCode.GeneCodeDate);
objvWebSrvClass4GeneCodeEN.GeneCodeDate = strGeneCodeDate; //生成代码日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.GeneCodeDate) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.GeneCodeDate, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.GeneCodeDate] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strVersionGeneCode">生成代码版本</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetVersionGeneCode(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strVersionGeneCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVersionGeneCode, 30, convWebSrvClass4GeneCode.VersionGeneCode);
objvWebSrvClass4GeneCodeEN.VersionGeneCode = strVersionGeneCode; //生成代码版本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.VersionGeneCode) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.VersionGeneCode, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.VersionGeneCode] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strNameSpace">域名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetNameSpace(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strNameSpace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNameSpace, 50, convWebSrvClass4GeneCode.NameSpace);
objvWebSrvClass4GeneCodeEN.NameSpace = strNameSpace; //域名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.NameSpace) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.NameSpace, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.NameSpace] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvUrl">WebSrv地址</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetWebSrvUrl(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strWebSrvUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvUrl, convWebSrvClass4GeneCode.WebSrvUrl);
clsCheckSql.CheckFieldLen(strWebSrvUrl, 300, convWebSrvClass4GeneCode.WebSrvUrl);
objvWebSrvClass4GeneCodeEN.WebSrvUrl = strWebSrvUrl; //WebSrv地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.WebSrvUrl) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.WebSrvUrl, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.WebSrvUrl] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageName">页面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetPageName(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strPageName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPageName, convWebSrvClass4GeneCode.PageName);
clsCheckSql.CheckFieldLen(strPageName, 100, convWebSrvClass4GeneCode.PageName);
objvWebSrvClass4GeneCodeEN.PageName = strPageName; //页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.PageName) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.PageName, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.PageName] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetFuncModuleAgcId(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convWebSrvClass4GeneCode.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convWebSrvClass4GeneCode.FuncModuleAgcId);
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.FuncModuleAgcId) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.FuncModuleAgcId, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.FuncModuleAgcId] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetFuncModuleName(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convWebSrvClass4GeneCode.FuncModuleName);
objvWebSrvClass4GeneCodeEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.FuncModuleName) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.FuncModuleName, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.FuncModuleName] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">功能模块英文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetFuncModuleEnName(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convWebSrvClass4GeneCode.FuncModuleEnName);
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = strFuncModuleEnName; //功能模块英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.FuncModuleEnName) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.FuncModuleEnName, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.FuncModuleEnName] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedGene">是否需要生成</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetIsNeedGene(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, bool bolIsNeedGene, string strComparisonOp="")
	{
objvWebSrvClass4GeneCodeEN.IsNeedGene = bolIsNeedGene; //是否需要生成
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.IsNeedGene) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.IsNeedGene, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.IsNeedGene] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetPrjId(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convWebSrvClass4GeneCode.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convWebSrvClass4GeneCode.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convWebSrvClass4GeneCode.PrjId);
objvWebSrvClass4GeneCodeEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.PrjId) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.PrjId, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.PrjId] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetPrjName(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convWebSrvClass4GeneCode.PrjName);
objvWebSrvClass4GeneCodeEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.PrjName) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.PrjName, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.PrjName] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetUpdDate(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convWebSrvClass4GeneCode.UpdDate);
objvWebSrvClass4GeneCodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.UpdDate) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.UpdDate, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.UpdDate] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetMemo(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convWebSrvClass4GeneCode.Memo);
objvWebSrvClass4GeneCodeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.Memo) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.Memo, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.Memo] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId4GeneCode">UserId4GeneCode</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetUserId4GeneCode(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strUserId4GeneCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId4GeneCode, 18, convWebSrvClass4GeneCode.UserId4GeneCode);
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = strUserId4GeneCode; //UserId4GeneCode
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.UserId4GeneCode) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.UserId4GeneCode, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.UserId4GeneCode] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strClsName">类名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetClsName(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsName, convWebSrvClass4GeneCode.ClsName);
clsCheckSql.CheckFieldLen(strClsName, 100, convWebSrvClass4GeneCode.ClsName);
objvWebSrvClass4GeneCodeEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.ContainsKey(convWebSrvClass4GeneCode.ClsName) == false)
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp.Add(convWebSrvClass4GeneCode.ClsName, strComparisonOp);
}
else
{
objvWebSrvClass4GeneCodeEN.dicFldComparisonOp[convWebSrvClass4GeneCode.ClsName] = strComparisonOp;
}
}
return objvWebSrvClass4GeneCodeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.WebSrvClassId) == true)
{
string strComparisonOpWebSrvClassId = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.WebSrvClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.WebSrvClassId, objvWebSrvClass4GeneCodeCond.WebSrvClassId, strComparisonOpWebSrvClassId);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.UserName) == true)
{
string strComparisonOpUserName = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.UserName, objvWebSrvClass4GeneCodeCond.UserName, strComparisonOpUserName);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.FuncNum) == true)
{
string strComparisonOpFuncNum = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.FuncNum];
strWhereCond += string.Format(" And {0} {2} {1}", convWebSrvClass4GeneCode.FuncNum, objvWebSrvClass4GeneCodeCond.FuncNum, strComparisonOpFuncNum);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.GeneCodeDate) == true)
{
string strComparisonOpGeneCodeDate = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.GeneCodeDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.GeneCodeDate, objvWebSrvClass4GeneCodeCond.GeneCodeDate, strComparisonOpGeneCodeDate);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.VersionGeneCode) == true)
{
string strComparisonOpVersionGeneCode = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.VersionGeneCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.VersionGeneCode, objvWebSrvClass4GeneCodeCond.VersionGeneCode, strComparisonOpVersionGeneCode);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.NameSpace) == true)
{
string strComparisonOpNameSpace = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.NameSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.NameSpace, objvWebSrvClass4GeneCodeCond.NameSpace, strComparisonOpNameSpace);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.WebSrvUrl) == true)
{
string strComparisonOpWebSrvUrl = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.WebSrvUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.WebSrvUrl, objvWebSrvClass4GeneCodeCond.WebSrvUrl, strComparisonOpWebSrvUrl);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.PageName) == true)
{
string strComparisonOpPageName = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.PageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.PageName, objvWebSrvClass4GeneCodeCond.PageName, strComparisonOpPageName);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.FuncModuleAgcId, objvWebSrvClass4GeneCodeCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.FuncModuleName, objvWebSrvClass4GeneCodeCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.FuncModuleEnName, objvWebSrvClass4GeneCodeCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.IsNeedGene) == true)
{
if (objvWebSrvClass4GeneCodeCond.IsNeedGene == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWebSrvClass4GeneCode.IsNeedGene);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWebSrvClass4GeneCode.IsNeedGene);
}
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.PrjId) == true)
{
string strComparisonOpPrjId = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.PrjId, objvWebSrvClass4GeneCodeCond.PrjId, strComparisonOpPrjId);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.PrjName) == true)
{
string strComparisonOpPrjName = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.PrjName, objvWebSrvClass4GeneCodeCond.PrjName, strComparisonOpPrjName);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.UpdDate) == true)
{
string strComparisonOpUpdDate = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.UpdDate, objvWebSrvClass4GeneCodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.Memo) == true)
{
string strComparisonOpMemo = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.Memo, objvWebSrvClass4GeneCodeCond.Memo, strComparisonOpMemo);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.UserId4GeneCode) == true)
{
string strComparisonOpUserId4GeneCode = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.UserId4GeneCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.UserId4GeneCode, objvWebSrvClass4GeneCodeCond.UserId4GeneCode, strComparisonOpUserId4GeneCode);
}
if (objvWebSrvClass4GeneCodeCond.IsUpdated(convWebSrvClass4GeneCode.ClsName) == true)
{
string strComparisonOpClsName = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[convWebSrvClass4GeneCode.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass4GeneCode.ClsName, objvWebSrvClass4GeneCodeCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vWebSrvClass4GeneCode(vWebSrvClass4GeneCode)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvWebSrvClass4GeneCodeWApi
{
private static readonly string mstrApiControllerName = "vWebSrvClass4GeneCodeApi";

 public clsvWebSrvClass4GeneCodeWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strWebSrvClassId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWebSrvClass4GeneCodeEN GetObjByWebSrvClassId(string strWebSrvClassId)
{
if (strWebSrvClassId == "") return null;
string strAction = "GetObjByWebSrvClassId";
clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWebSrvClassId"] = strWebSrvClassId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvWebSrvClass4GeneCodeEN = JsonConvert.DeserializeObject<clsvWebSrvClass4GeneCodeEN>(strJson);
return objvWebSrvClass4GeneCodeEN;
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
public static string GetFirstID(string strWhereCond)
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvWebSrvClass4GeneCodeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN;
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
objvWebSrvClass4GeneCodeEN = JsonConvert.DeserializeObject<clsvWebSrvClass4GeneCodeEN>(strJson);
return objvWebSrvClass4GeneCodeEN;
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
 /// <param name = "strWebSrvClassId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvWebSrvClass4GeneCodeEN GetObjByWebSrvClassIdCache(string strWebSrvClassId,string strPrjId)
{
if (string.IsNullOrEmpty(strWebSrvClassId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvWebSrvClass4GeneCodeEN._CurrTabName, strPrjId);
List<clsvWebSrvClass4GeneCodeEN> arrvWebSrvClass4GeneCodeObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvWebSrvClass4GeneCodeEN> arrvWebSrvClass4GeneCodeObjLst_Sel =
from objvWebSrvClass4GeneCodeEN in arrvWebSrvClass4GeneCodeObjLstCache
where objvWebSrvClass4GeneCodeEN.WebSrvClassId == strWebSrvClassId 
select objvWebSrvClass4GeneCodeEN;
if (arrvWebSrvClass4GeneCodeObjLst_Sel.Count() == 0)
{
   clsvWebSrvClass4GeneCodeEN obj = clsvWebSrvClass4GeneCodeWApi.GetObjByWebSrvClassId(strWebSrvClassId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvWebSrvClass4GeneCodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLst(string strWhereCond)
{
 List<clsvWebSrvClass4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvClass4GeneCodeEN>>(strJson);
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
 /// <param name = "arrWebSrvClassId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstByWebSrvClassIdLst(List<string> arrWebSrvClassId)
{
 List<clsvWebSrvClass4GeneCodeEN> arrObjLst; 
string strAction = "GetObjLstByWebSrvClassIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrWebSrvClassId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvClass4GeneCodeEN>>(strJson);
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
 /// <param name = "arrWebSrvClassId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvWebSrvClass4GeneCodeEN> GetObjLstByWebSrvClassIdLstCache(List<string> arrWebSrvClassId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvWebSrvClass4GeneCodeEN._CurrTabName, strPrjId);
List<clsvWebSrvClass4GeneCodeEN> arrvWebSrvClass4GeneCodeObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvWebSrvClass4GeneCodeEN> arrvWebSrvClass4GeneCodeObjLst_Sel =
from objvWebSrvClass4GeneCodeEN in arrvWebSrvClass4GeneCodeObjLstCache
where arrWebSrvClassId.Contains(objvWebSrvClass4GeneCodeEN.WebSrvClassId)
select objvWebSrvClass4GeneCodeEN;
return arrvWebSrvClass4GeneCodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvClass4GeneCodeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvWebSrvClass4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvClass4GeneCodeEN>>(strJson);
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
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvWebSrvClass4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvClass4GeneCodeEN>>(strJson);
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
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvWebSrvClass4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvClass4GeneCodeEN>>(strJson);
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
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvWebSrvClass4GeneCodeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvClass4GeneCodeEN>>(strJson);
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
public static bool IsExist(string strWebSrvClassId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWebSrvClassId"] = strWebSrvClassId
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
 /// <param name = "objvWebSrvClass4GeneCodeENS">源对象</param>
 /// <param name = "objvWebSrvClass4GeneCodeENT">目标对象</param>
 public static void CopyTo(clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeENS, clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeENT)
{
try
{
objvWebSrvClass4GeneCodeENT.WebSrvClassId = objvWebSrvClass4GeneCodeENS.WebSrvClassId; //类Id
objvWebSrvClass4GeneCodeENT.UserName = objvWebSrvClass4GeneCodeENS.UserName; //用户名
objvWebSrvClass4GeneCodeENT.FuncNum = objvWebSrvClass4GeneCodeENS.FuncNum; //函数个数
objvWebSrvClass4GeneCodeENT.GeneCodeDate = objvWebSrvClass4GeneCodeENS.GeneCodeDate; //生成代码日期
objvWebSrvClass4GeneCodeENT.VersionGeneCode = objvWebSrvClass4GeneCodeENS.VersionGeneCode; //生成代码版本
objvWebSrvClass4GeneCodeENT.NameSpace = objvWebSrvClass4GeneCodeENS.NameSpace; //域名
objvWebSrvClass4GeneCodeENT.WebSrvUrl = objvWebSrvClass4GeneCodeENS.WebSrvUrl; //WebSrv地址
objvWebSrvClass4GeneCodeENT.PageName = objvWebSrvClass4GeneCodeENS.PageName; //页面名称
objvWebSrvClass4GeneCodeENT.FuncModuleAgcId = objvWebSrvClass4GeneCodeENS.FuncModuleAgcId; //功能模块Id
objvWebSrvClass4GeneCodeENT.FuncModuleName = objvWebSrvClass4GeneCodeENS.FuncModuleName; //功能模块名称
objvWebSrvClass4GeneCodeENT.FuncModuleEnName = objvWebSrvClass4GeneCodeENS.FuncModuleEnName; //功能模块英文名称
objvWebSrvClass4GeneCodeENT.IsNeedGene = objvWebSrvClass4GeneCodeENS.IsNeedGene; //是否需要生成
objvWebSrvClass4GeneCodeENT.PrjId = objvWebSrvClass4GeneCodeENS.PrjId; //工程Id
objvWebSrvClass4GeneCodeENT.PrjName = objvWebSrvClass4GeneCodeENS.PrjName; //工程名称
objvWebSrvClass4GeneCodeENT.UpdDate = objvWebSrvClass4GeneCodeENS.UpdDate; //修改日期
objvWebSrvClass4GeneCodeENT.Memo = objvWebSrvClass4GeneCodeENS.Memo; //说明
objvWebSrvClass4GeneCodeENT.UserId4GeneCode = objvWebSrvClass4GeneCodeENS.UserId4GeneCode; //UserId4GeneCode
objvWebSrvClass4GeneCodeENT.ClsName = objvWebSrvClass4GeneCodeENS.ClsName; //类名
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
public static DataTable ToDataTable(List<clsvWebSrvClass4GeneCodeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvWebSrvClass4GeneCodeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvWebSrvClass4GeneCodeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvWebSrvClass4GeneCodeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvWebSrvClass4GeneCodeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvWebSrvClass4GeneCodeEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvWebSrvClass4GeneCodeWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvWebSrvClass4GeneCodeWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvWebSrvClass4GeneCodeEN._CurrTabName, strPrjId);
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
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvWebSrvClass4GeneCodeWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvWebSrvClass4GeneCodeWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvWebSrvClass4GeneCodeEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvWebSrvClass4GeneCodeEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convWebSrvClass4GeneCode.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvWebSrvClass4GeneCodeEN._CurrTabName, strPrjId);
List<clsvWebSrvClass4GeneCodeEN> arrvWebSrvClass4GeneCodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvWebSrvClass4GeneCodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvWebSrvClass4GeneCodeEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvWebSrvClass4GeneCodeWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvWebSrvClass4GeneCodeWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvWebSrvClass4GeneCodeEN._CurrTabName, strPrjId);
List<clsvWebSrvClass4GeneCodeEN> arrvWebSrvClass4GeneCodeObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvWebSrvClass4GeneCodeObjLstCache = CacheHelper.Get<List<clsvWebSrvClass4GeneCodeEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvWebSrvClass4GeneCodeObjLstCache = CacheHelper.Get<List<clsvWebSrvClass4GeneCodeEN>>(strKey);
}
return arrvWebSrvClass4GeneCodeObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvWebSrvClass4GeneCodeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convWebSrvClass4GeneCode.WebSrvClassId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass4GeneCode.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass4GeneCode.FuncNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convWebSrvClass4GeneCode.GeneCodeDate, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass4GeneCode.VersionGeneCode, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass4GeneCode.NameSpace, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass4GeneCode.WebSrvUrl, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass4GeneCode.PageName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass4GeneCode.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass4GeneCode.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass4GeneCode.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass4GeneCode.IsNeedGene, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWebSrvClass4GeneCode.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass4GeneCode.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass4GeneCode.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass4GeneCode.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass4GeneCode.UserId4GeneCode, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass4GeneCode.ClsName, Type.GetType("System.String"));
foreach (clsvWebSrvClass4GeneCodeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convWebSrvClass4GeneCode.WebSrvClassId] = objInFor[convWebSrvClass4GeneCode.WebSrvClassId];
objDR[convWebSrvClass4GeneCode.UserName] = objInFor[convWebSrvClass4GeneCode.UserName];
objDR[convWebSrvClass4GeneCode.FuncNum] = objInFor[convWebSrvClass4GeneCode.FuncNum];
objDR[convWebSrvClass4GeneCode.GeneCodeDate] = objInFor[convWebSrvClass4GeneCode.GeneCodeDate];
objDR[convWebSrvClass4GeneCode.VersionGeneCode] = objInFor[convWebSrvClass4GeneCode.VersionGeneCode];
objDR[convWebSrvClass4GeneCode.NameSpace] = objInFor[convWebSrvClass4GeneCode.NameSpace];
objDR[convWebSrvClass4GeneCode.WebSrvUrl] = objInFor[convWebSrvClass4GeneCode.WebSrvUrl];
objDR[convWebSrvClass4GeneCode.PageName] = objInFor[convWebSrvClass4GeneCode.PageName];
objDR[convWebSrvClass4GeneCode.FuncModuleAgcId] = objInFor[convWebSrvClass4GeneCode.FuncModuleAgcId];
objDR[convWebSrvClass4GeneCode.FuncModuleName] = objInFor[convWebSrvClass4GeneCode.FuncModuleName];
objDR[convWebSrvClass4GeneCode.FuncModuleEnName] = objInFor[convWebSrvClass4GeneCode.FuncModuleEnName];
objDR[convWebSrvClass4GeneCode.IsNeedGene] = objInFor[convWebSrvClass4GeneCode.IsNeedGene];
objDR[convWebSrvClass4GeneCode.PrjId] = objInFor[convWebSrvClass4GeneCode.PrjId];
objDR[convWebSrvClass4GeneCode.PrjName] = objInFor[convWebSrvClass4GeneCode.PrjName];
objDR[convWebSrvClass4GeneCode.UpdDate] = objInFor[convWebSrvClass4GeneCode.UpdDate];
objDR[convWebSrvClass4GeneCode.Memo] = objInFor[convWebSrvClass4GeneCode.Memo];
objDR[convWebSrvClass4GeneCode.UserId4GeneCode] = objInFor[convWebSrvClass4GeneCode.UserId4GeneCode];
objDR[convWebSrvClass4GeneCode.ClsName] = objInFor[convWebSrvClass4GeneCode.ClsName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}