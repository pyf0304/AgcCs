
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvClass4GeneCodeBL
 表名:vWebSrvClass4GeneCode(00050372)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:43:47
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
public static class  clsvWebSrvClass4GeneCodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strWebSrvClassId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWebSrvClass4GeneCodeEN GetObj(this K_WebSrvClassId_vWebSrvClass4GeneCode myKey)
{
clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = clsvWebSrvClass4GeneCodeBL.vWebSrvClass4GeneCodeDA.GetObjByWebSrvClassId(myKey.Value);
return objvWebSrvClass4GeneCodeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetWebSrvClassId(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strWebSrvClassId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvClassId, 8, convWebSrvClass4GeneCode.WebSrvClassId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWebSrvClassId, 8, convWebSrvClass4GeneCode.WebSrvClassId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetUserName(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convWebSrvClass4GeneCode.UserName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetFuncNum(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, int? intFuncNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetGeneCodeDate(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strGeneCodeDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGeneCodeDate, 20, convWebSrvClass4GeneCode.GeneCodeDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetVersionGeneCode(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strVersionGeneCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionGeneCode, 30, convWebSrvClass4GeneCode.VersionGeneCode);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetNameSpace(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strNameSpace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNameSpace, 50, convWebSrvClass4GeneCode.NameSpace);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetWebSrvUrl(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strWebSrvUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvUrl, convWebSrvClass4GeneCode.WebSrvUrl);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvUrl, 300, convWebSrvClass4GeneCode.WebSrvUrl);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetPageName(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strPageName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPageName, convWebSrvClass4GeneCode.PageName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageName, 100, convWebSrvClass4GeneCode.PageName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetFuncModuleAgcId(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convWebSrvClass4GeneCode.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convWebSrvClass4GeneCode.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetFuncModuleName(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convWebSrvClass4GeneCode.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetFuncModuleEnName(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convWebSrvClass4GeneCode.FuncModuleEnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetPrjId(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convWebSrvClass4GeneCode.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convWebSrvClass4GeneCode.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convWebSrvClass4GeneCode.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetPrjName(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convWebSrvClass4GeneCode.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetUpdDate(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convWebSrvClass4GeneCode.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetMemo(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convWebSrvClass4GeneCode.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetUserId4GeneCode(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strUserId4GeneCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId4GeneCode, 18, convWebSrvClass4GeneCode.UserId4GeneCode);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClass4GeneCodeEN SetClsName(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsName, convWebSrvClass4GeneCode.ClsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsName, 100, convWebSrvClass4GeneCode.ClsName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeENS">源对象</param>
 /// <param name = "objvWebSrvClass4GeneCodeENT">目标对象</param>
 public static void CopyTo(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeENS, clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeENT)
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
 /// <param name = "objvWebSrvClass4GeneCodeENS">源对象</param>
 /// <returns>目标对象=>clsvWebSrvClass4GeneCodeEN:objvWebSrvClass4GeneCodeENT</returns>
 public static clsvWebSrvClass4GeneCodeEN CopyTo(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeENS)
{
try
{
 clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeENT = new clsvWebSrvClass4GeneCodeEN()
{
WebSrvClassId = objvWebSrvClass4GeneCodeENS.WebSrvClassId, //类Id
UserName = objvWebSrvClass4GeneCodeENS.UserName, //用户名
FuncNum = objvWebSrvClass4GeneCodeENS.FuncNum, //函数个数
GeneCodeDate = objvWebSrvClass4GeneCodeENS.GeneCodeDate, //生成代码日期
VersionGeneCode = objvWebSrvClass4GeneCodeENS.VersionGeneCode, //生成代码版本
NameSpace = objvWebSrvClass4GeneCodeENS.NameSpace, //域名
WebSrvUrl = objvWebSrvClass4GeneCodeENS.WebSrvUrl, //WebSrv地址
PageName = objvWebSrvClass4GeneCodeENS.PageName, //页面名称
FuncModuleAgcId = objvWebSrvClass4GeneCodeENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvWebSrvClass4GeneCodeENS.FuncModuleName, //功能模块名称
FuncModuleEnName = objvWebSrvClass4GeneCodeENS.FuncModuleEnName, //功能模块英文名称
IsNeedGene = objvWebSrvClass4GeneCodeENS.IsNeedGene, //是否需要生成
PrjId = objvWebSrvClass4GeneCodeENS.PrjId, //工程Id
PrjName = objvWebSrvClass4GeneCodeENS.PrjName, //工程名称
UpdDate = objvWebSrvClass4GeneCodeENS.UpdDate, //修改日期
Memo = objvWebSrvClass4GeneCodeENS.Memo, //说明
UserId4GeneCode = objvWebSrvClass4GeneCodeENS.UserId4GeneCode, //UserId4GeneCode
ClsName = objvWebSrvClass4GeneCodeENS.ClsName, //类名
};
 return objvWebSrvClass4GeneCodeENT;
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
public static void CheckProperty4Condition(this clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN)
{
 clsvWebSrvClass4GeneCodeBL.vWebSrvClass4GeneCodeDA.CheckProperty4Condition(objvWebSrvClass4GeneCodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vWebSrvClass4GeneCode
{
public virtual bool UpdRelaTabDate(string strWebSrvClassId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vWebSrvClass4GeneCode(vWebSrvClass4GeneCode)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvWebSrvClass4GeneCodeBL
{
public static RelatedActions_vWebSrvClass4GeneCode relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvWebSrvClass4GeneCodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvWebSrvClass4GeneCodeDA vWebSrvClass4GeneCodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvWebSrvClass4GeneCodeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvWebSrvClass4GeneCodeBL()
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
if (string.IsNullOrEmpty(clsvWebSrvClass4GeneCodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvWebSrvClass4GeneCodeEN._ConnectString);
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
public static DataTable GetDataTable_vWebSrvClass4GeneCode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vWebSrvClass4GeneCodeDA.GetDataTable_vWebSrvClass4GeneCode(strWhereCond);
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
objDT = vWebSrvClass4GeneCodeDA.GetDataTable(strWhereCond);
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
objDT = vWebSrvClass4GeneCodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vWebSrvClass4GeneCodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vWebSrvClass4GeneCodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vWebSrvClass4GeneCodeDA.GetDataTable_Top(objTopPara);
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
objDT = vWebSrvClass4GeneCodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vWebSrvClass4GeneCodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vWebSrvClass4GeneCodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrWebSrvClassIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstByWebSrvClassIdLst(List<string> arrWebSrvClassIdLst)
{
List<clsvWebSrvClass4GeneCodeEN> arrObjLst = new List<clsvWebSrvClass4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrWebSrvClassIdLst, true);
 string strWhereCond = string.Format("WebSrvClassId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN();
try
{
objvWebSrvClass4GeneCodeEN.WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClass4GeneCodeEN.UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名
objvWebSrvClass4GeneCodeEN.FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClass4GeneCodeEN.GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvWebSrvClass4GeneCodeEN.VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvWebSrvClass4GeneCodeEN.NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名
objvWebSrvClass4GeneCodeEN.WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClass4GeneCodeEN.PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClass4GeneCodeEN.FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClass4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClass4GeneCodeEN.PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id
objvWebSrvClass4GeneCodeEN.PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称
objvWebSrvClass4GeneCodeEN.UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClass4GeneCodeEN.Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
objvWebSrvClass4GeneCodeEN.ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClass4GeneCodeEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClass4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrWebSrvClassIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvWebSrvClass4GeneCodeEN> GetObjLstByWebSrvClassIdLstCache(List<string> arrWebSrvClassIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvWebSrvClass4GeneCodeEN._CurrTabName, strPrjId);
List<clsvWebSrvClass4GeneCodeEN> arrvWebSrvClass4GeneCodeObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvWebSrvClass4GeneCodeEN> arrvWebSrvClass4GeneCodeObjLst_Sel =
arrvWebSrvClass4GeneCodeObjLstCache
.Where(x => arrWebSrvClassIdLst.Contains(x.WebSrvClassId));
return arrvWebSrvClass4GeneCodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLst(string strWhereCond)
{
List<clsvWebSrvClass4GeneCodeEN> arrObjLst = new List<clsvWebSrvClass4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN();
try
{
objvWebSrvClass4GeneCodeEN.WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClass4GeneCodeEN.UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名
objvWebSrvClass4GeneCodeEN.FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClass4GeneCodeEN.GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvWebSrvClass4GeneCodeEN.VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvWebSrvClass4GeneCodeEN.NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名
objvWebSrvClass4GeneCodeEN.WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClass4GeneCodeEN.PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClass4GeneCodeEN.FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClass4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClass4GeneCodeEN.PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id
objvWebSrvClass4GeneCodeEN.PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称
objvWebSrvClass4GeneCodeEN.UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClass4GeneCodeEN.Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
objvWebSrvClass4GeneCodeEN.ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClass4GeneCodeEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClass4GeneCodeEN);
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
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvWebSrvClass4GeneCodeEN> arrObjLst = new List<clsvWebSrvClass4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN();
try
{
objvWebSrvClass4GeneCodeEN.WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClass4GeneCodeEN.UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名
objvWebSrvClass4GeneCodeEN.FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClass4GeneCodeEN.GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvWebSrvClass4GeneCodeEN.VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvWebSrvClass4GeneCodeEN.NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名
objvWebSrvClass4GeneCodeEN.WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClass4GeneCodeEN.PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClass4GeneCodeEN.FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClass4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClass4GeneCodeEN.PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id
objvWebSrvClass4GeneCodeEN.PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称
objvWebSrvClass4GeneCodeEN.UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClass4GeneCodeEN.Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
objvWebSrvClass4GeneCodeEN.ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClass4GeneCodeEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClass4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvWebSrvClass4GeneCodeEN> GetSubObjLstCache(clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeCond)
{
 string strPrjId = objvWebSrvClass4GeneCodeCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvWebSrvClass4GeneCodeBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvWebSrvClass4GeneCodeEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvWebSrvClass4GeneCodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convWebSrvClass4GeneCode._AttributeName)
{
if (objvWebSrvClass4GeneCodeCond.IsUpdated(strFldName) == false) continue;
if (objvWebSrvClass4GeneCodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvClass4GeneCodeCond[strFldName].ToString());
}
else
{
if (objvWebSrvClass4GeneCodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvClass4GeneCodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvWebSrvClass4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvWebSrvClass4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvWebSrvClass4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvWebSrvClass4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvWebSrvClass4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvWebSrvClass4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvWebSrvClass4GeneCodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvWebSrvClass4GeneCodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvWebSrvClass4GeneCodeCond[strFldName]));
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
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvWebSrvClass4GeneCodeEN> arrObjLst = new List<clsvWebSrvClass4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN();
try
{
objvWebSrvClass4GeneCodeEN.WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClass4GeneCodeEN.UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名
objvWebSrvClass4GeneCodeEN.FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClass4GeneCodeEN.GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvWebSrvClass4GeneCodeEN.VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvWebSrvClass4GeneCodeEN.NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名
objvWebSrvClass4GeneCodeEN.WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClass4GeneCodeEN.PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClass4GeneCodeEN.FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClass4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClass4GeneCodeEN.PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id
objvWebSrvClass4GeneCodeEN.PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称
objvWebSrvClass4GeneCodeEN.UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClass4GeneCodeEN.Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
objvWebSrvClass4GeneCodeEN.ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClass4GeneCodeEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClass4GeneCodeEN);
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
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvWebSrvClass4GeneCodeEN> arrObjLst = new List<clsvWebSrvClass4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN();
try
{
objvWebSrvClass4GeneCodeEN.WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClass4GeneCodeEN.UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名
objvWebSrvClass4GeneCodeEN.FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClass4GeneCodeEN.GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvWebSrvClass4GeneCodeEN.VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvWebSrvClass4GeneCodeEN.NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名
objvWebSrvClass4GeneCodeEN.WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClass4GeneCodeEN.PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClass4GeneCodeEN.FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClass4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClass4GeneCodeEN.PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id
objvWebSrvClass4GeneCodeEN.PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称
objvWebSrvClass4GeneCodeEN.UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClass4GeneCodeEN.Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
objvWebSrvClass4GeneCodeEN.ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClass4GeneCodeEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClass4GeneCodeEN);
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
List<clsvWebSrvClass4GeneCodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvWebSrvClass4GeneCodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvClass4GeneCodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvWebSrvClass4GeneCodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvWebSrvClass4GeneCodeEN> arrObjLst = new List<clsvWebSrvClass4GeneCodeEN>(); 
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
	clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN();
try
{
objvWebSrvClass4GeneCodeEN.WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClass4GeneCodeEN.UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名
objvWebSrvClass4GeneCodeEN.FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClass4GeneCodeEN.GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvWebSrvClass4GeneCodeEN.VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvWebSrvClass4GeneCodeEN.NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名
objvWebSrvClass4GeneCodeEN.WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClass4GeneCodeEN.PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClass4GeneCodeEN.FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClass4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClass4GeneCodeEN.PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id
objvWebSrvClass4GeneCodeEN.PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称
objvWebSrvClass4GeneCodeEN.UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClass4GeneCodeEN.Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
objvWebSrvClass4GeneCodeEN.ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClass4GeneCodeEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClass4GeneCodeEN);
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
public static List<clsvWebSrvClass4GeneCodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvWebSrvClass4GeneCodeEN> arrObjLst = new List<clsvWebSrvClass4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN();
try
{
objvWebSrvClass4GeneCodeEN.WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClass4GeneCodeEN.UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名
objvWebSrvClass4GeneCodeEN.FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClass4GeneCodeEN.GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvWebSrvClass4GeneCodeEN.VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvWebSrvClass4GeneCodeEN.NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名
objvWebSrvClass4GeneCodeEN.WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClass4GeneCodeEN.PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClass4GeneCodeEN.FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClass4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClass4GeneCodeEN.PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id
objvWebSrvClass4GeneCodeEN.PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称
objvWebSrvClass4GeneCodeEN.UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClass4GeneCodeEN.Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
objvWebSrvClass4GeneCodeEN.ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClass4GeneCodeEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClass4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvWebSrvClass4GeneCodeEN> arrObjLst = new List<clsvWebSrvClass4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN();
try
{
objvWebSrvClass4GeneCodeEN.WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClass4GeneCodeEN.UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名
objvWebSrvClass4GeneCodeEN.FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClass4GeneCodeEN.GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvWebSrvClass4GeneCodeEN.VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvWebSrvClass4GeneCodeEN.NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名
objvWebSrvClass4GeneCodeEN.WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClass4GeneCodeEN.PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClass4GeneCodeEN.FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClass4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClass4GeneCodeEN.PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id
objvWebSrvClass4GeneCodeEN.PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称
objvWebSrvClass4GeneCodeEN.UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClass4GeneCodeEN.Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
objvWebSrvClass4GeneCodeEN.ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClass4GeneCodeEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClass4GeneCodeEN);
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
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvWebSrvClass4GeneCodeEN> arrObjLst = new List<clsvWebSrvClass4GeneCodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN();
try
{
objvWebSrvClass4GeneCodeEN.WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClass4GeneCodeEN.UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名
objvWebSrvClass4GeneCodeEN.FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClass4GeneCodeEN.GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvWebSrvClass4GeneCodeEN.VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvWebSrvClass4GeneCodeEN.NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名
objvWebSrvClass4GeneCodeEN.WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClass4GeneCodeEN.PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClass4GeneCodeEN.FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClass4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClass4GeneCodeEN.PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id
objvWebSrvClass4GeneCodeEN.PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称
objvWebSrvClass4GeneCodeEN.UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClass4GeneCodeEN.Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
objvWebSrvClass4GeneCodeEN.ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClass4GeneCodeEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClass4GeneCodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvWebSrvClass4GeneCodeEN> arrObjLst = new List<clsvWebSrvClass4GeneCodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = new clsvWebSrvClass4GeneCodeEN();
try
{
objvWebSrvClass4GeneCodeEN.WebSrvClassId = objRow[convWebSrvClass4GeneCode.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClass4GeneCodeEN.UserName = objRow[convWebSrvClass4GeneCode.UserName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserName].ToString().Trim(); //用户名
objvWebSrvClass4GeneCodeEN.FuncNum = objRow[convWebSrvClass4GeneCode.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass4GeneCode.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClass4GeneCodeEN.GeneCodeDate = objRow[convWebSrvClass4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvWebSrvClass4GeneCodeEN.VersionGeneCode = objRow[convWebSrvClass4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvWebSrvClass4GeneCodeEN.NameSpace = objRow[convWebSrvClass4GeneCode.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.NameSpace].ToString().Trim(); //域名
objvWebSrvClass4GeneCodeEN.WebSrvUrl = objRow[convWebSrvClass4GeneCode.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClass4GeneCodeEN.PageName = objRow[convWebSrvClass4GeneCode.PageName].ToString().Trim(); //页面名称
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objRow[convWebSrvClass4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClass4GeneCodeEN.FuncModuleName = objRow[convWebSrvClass4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objRow[convWebSrvClass4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClass4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClass4GeneCodeEN.PrjId = objRow[convWebSrvClass4GeneCode.PrjId].ToString().Trim(); //工程Id
objvWebSrvClass4GeneCodeEN.PrjName = objRow[convWebSrvClass4GeneCode.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.PrjName].ToString().Trim(); //工程名称
objvWebSrvClass4GeneCodeEN.UpdDate = objRow[convWebSrvClass4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClass4GeneCodeEN.Memo = objRow[convWebSrvClass4GeneCode.Memo] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.Memo].ToString().Trim(); //说明
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objRow[convWebSrvClass4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convWebSrvClass4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
objvWebSrvClass4GeneCodeEN.ClsName = objRow[convWebSrvClass4GeneCode.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClass4GeneCodeEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClass4GeneCodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvWebSrvClass4GeneCode(ref clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN)
{
bool bolResult = vWebSrvClass4GeneCodeDA.GetvWebSrvClass4GeneCode(ref objvWebSrvClass4GeneCodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strWebSrvClassId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWebSrvClass4GeneCodeEN GetObjByWebSrvClassId(string strWebSrvClassId)
{
if (strWebSrvClassId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strWebSrvClassId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strWebSrvClassId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strWebSrvClassId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = vWebSrvClass4GeneCodeDA.GetObjByWebSrvClassId(strWebSrvClassId);
return objvWebSrvClass4GeneCodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvWebSrvClass4GeneCodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = vWebSrvClass4GeneCodeDA.GetFirstObj(strWhereCond);
 return objvWebSrvClass4GeneCodeEN;
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
public static clsvWebSrvClass4GeneCodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = vWebSrvClass4GeneCodeDA.GetObjByDataRow(objRow);
 return objvWebSrvClass4GeneCodeEN;
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
public static clsvWebSrvClass4GeneCodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN = vWebSrvClass4GeneCodeDA.GetObjByDataRow(objRow);
 return objvWebSrvClass4GeneCodeEN;
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
 /// <param name = "strWebSrvClassId">所给的关键字</param>
 /// <param name = "lstvWebSrvClass4GeneCodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvWebSrvClass4GeneCodeEN GetObjByWebSrvClassIdFromList(string strWebSrvClassId, List<clsvWebSrvClass4GeneCodeEN> lstvWebSrvClass4GeneCodeObjLst)
{
foreach (clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN in lstvWebSrvClass4GeneCodeObjLst)
{
if (objvWebSrvClass4GeneCodeEN.WebSrvClassId == strWebSrvClassId)
{
return objvWebSrvClass4GeneCodeEN;
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
 string strWebSrvClassId;
 try
 {
 strWebSrvClassId = new clsvWebSrvClass4GeneCodeDA().GetFirstID(strWhereCond);
 return strWebSrvClassId;
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
 arrList = vWebSrvClass4GeneCodeDA.GetID(strWhereCond);
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
bool bolIsExist = vWebSrvClass4GeneCodeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strWebSrvClassId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strWebSrvClassId)
{
if (string.IsNullOrEmpty(strWebSrvClassId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strWebSrvClassId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vWebSrvClass4GeneCodeDA.IsExist(strWebSrvClassId);
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
 bolIsExist = clsvWebSrvClass4GeneCodeDA.IsExistTable();
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
 bolIsExist = vWebSrvClass4GeneCodeDA.IsExistTable(strTabName);
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
 /// <param name = "objvWebSrvClass4GeneCodeEN">源简化对象</param>
 public static void SetUpdFlag(clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN)
{
try
{
objvWebSrvClass4GeneCodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvWebSrvClass4GeneCodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convWebSrvClass4GeneCode.WebSrvClassId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.WebSrvClassId = objvWebSrvClass4GeneCodeEN.WebSrvClassId; //类Id
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.UserName = objvWebSrvClass4GeneCodeEN.UserName == "[null]" ? null :  objvWebSrvClass4GeneCodeEN.UserName; //用户名
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.FuncNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.FuncNum = objvWebSrvClass4GeneCodeEN.FuncNum; //函数个数
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.GeneCodeDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.GeneCodeDate = objvWebSrvClass4GeneCodeEN.GeneCodeDate == "[null]" ? null :  objvWebSrvClass4GeneCodeEN.GeneCodeDate; //生成代码日期
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.VersionGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.VersionGeneCode = objvWebSrvClass4GeneCodeEN.VersionGeneCode == "[null]" ? null :  objvWebSrvClass4GeneCodeEN.VersionGeneCode; //生成代码版本
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.NameSpace, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.NameSpace = objvWebSrvClass4GeneCodeEN.NameSpace == "[null]" ? null :  objvWebSrvClass4GeneCodeEN.NameSpace; //域名
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.WebSrvUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.WebSrvUrl = objvWebSrvClass4GeneCodeEN.WebSrvUrl; //WebSrv地址
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.PageName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.PageName = objvWebSrvClass4GeneCodeEN.PageName; //页面名称
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = objvWebSrvClass4GeneCodeEN.FuncModuleAgcId == "[null]" ? null :  objvWebSrvClass4GeneCodeEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.FuncModuleName = objvWebSrvClass4GeneCodeEN.FuncModuleName == "[null]" ? null :  objvWebSrvClass4GeneCodeEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.FuncModuleEnName = objvWebSrvClass4GeneCodeEN.FuncModuleEnName == "[null]" ? null :  objvWebSrvClass4GeneCodeEN.FuncModuleEnName; //功能模块英文名称
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.IsNeedGene, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.IsNeedGene = objvWebSrvClass4GeneCodeEN.IsNeedGene; //是否需要生成
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.PrjId = objvWebSrvClass4GeneCodeEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.PrjName = objvWebSrvClass4GeneCodeEN.PrjName == "[null]" ? null :  objvWebSrvClass4GeneCodeEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.UpdDate = objvWebSrvClass4GeneCodeEN.UpdDate == "[null]" ? null :  objvWebSrvClass4GeneCodeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.Memo = objvWebSrvClass4GeneCodeEN.Memo == "[null]" ? null :  objvWebSrvClass4GeneCodeEN.Memo; //说明
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.UserId4GeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.UserId4GeneCode = objvWebSrvClass4GeneCodeEN.UserId4GeneCode == "[null]" ? null :  objvWebSrvClass4GeneCodeEN.UserId4GeneCode; //UserId4GeneCode
}
if (arrFldSet.Contains(convWebSrvClass4GeneCode.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClass4GeneCodeEN.ClsName = objvWebSrvClass4GeneCodeEN.ClsName; //类名
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
 /// <param name = "objvWebSrvClass4GeneCodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN)
{
try
{
if (objvWebSrvClass4GeneCodeEN.UserName == "[null]") objvWebSrvClass4GeneCodeEN.UserName = null; //用户名
if (objvWebSrvClass4GeneCodeEN.GeneCodeDate == "[null]") objvWebSrvClass4GeneCodeEN.GeneCodeDate = null; //生成代码日期
if (objvWebSrvClass4GeneCodeEN.VersionGeneCode == "[null]") objvWebSrvClass4GeneCodeEN.VersionGeneCode = null; //生成代码版本
if (objvWebSrvClass4GeneCodeEN.NameSpace == "[null]") objvWebSrvClass4GeneCodeEN.NameSpace = null; //域名
if (objvWebSrvClass4GeneCodeEN.FuncModuleAgcId == "[null]") objvWebSrvClass4GeneCodeEN.FuncModuleAgcId = null; //功能模块Id
if (objvWebSrvClass4GeneCodeEN.FuncModuleName == "[null]") objvWebSrvClass4GeneCodeEN.FuncModuleName = null; //功能模块名称
if (objvWebSrvClass4GeneCodeEN.FuncModuleEnName == "[null]") objvWebSrvClass4GeneCodeEN.FuncModuleEnName = null; //功能模块英文名称
if (objvWebSrvClass4GeneCodeEN.PrjName == "[null]") objvWebSrvClass4GeneCodeEN.PrjName = null; //工程名称
if (objvWebSrvClass4GeneCodeEN.UpdDate == "[null]") objvWebSrvClass4GeneCodeEN.UpdDate = null; //修改日期
if (objvWebSrvClass4GeneCodeEN.Memo == "[null]") objvWebSrvClass4GeneCodeEN.Memo = null; //说明
if (objvWebSrvClass4GeneCodeEN.UserId4GeneCode == "[null]") objvWebSrvClass4GeneCodeEN.UserId4GeneCode = null; //UserId4GeneCode
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
public static void CheckProperty4Condition(clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeEN)
{
 vWebSrvClass4GeneCodeDA.CheckProperty4Condition(objvWebSrvClass4GeneCodeEN);
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
if (clsFuncModule_AgcBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWebSrvClassBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsWebSrvClassBL没有刷新缓存机制(clsWebSrvClassBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSoftStructureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSoftStructureBL没有刷新缓存机制(clsSoftStructureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUseStateBL没有刷新缓存机制(clsUseStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsLog4GC_WebSrvClassBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsLog4GC_WebSrvClassBL没有刷新缓存机制(clsLog4GC_WebSrvClassBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by WebSrvClassId");
//if (arrvWebSrvClass4GeneCodeObjLstCache == null)
//{
//arrvWebSrvClass4GeneCodeObjLstCache = vWebSrvClass4GeneCodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strWebSrvClassId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvWebSrvClass4GeneCodeEN GetObjByWebSrvClassIdCache(string strWebSrvClassId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvWebSrvClass4GeneCodeEN._CurrTabName, strPrjId);
List<clsvWebSrvClass4GeneCodeEN> arrvWebSrvClass4GeneCodeObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvWebSrvClass4GeneCodeEN> arrvWebSrvClass4GeneCodeObjLst_Sel =
arrvWebSrvClass4GeneCodeObjLstCache
.Where(x=> x.WebSrvClassId == strWebSrvClassId 
);
if (arrvWebSrvClass4GeneCodeObjLst_Sel.Count() == 0)
{
   clsvWebSrvClass4GeneCodeEN obj = clsvWebSrvClass4GeneCodeBL.GetObjByWebSrvClassId(strWebSrvClassId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strWebSrvClassId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvWebSrvClass4GeneCodeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvWebSrvClass4GeneCodeEN> GetAllvWebSrvClass4GeneCodeObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvWebSrvClass4GeneCodeEN> arrvWebSrvClass4GeneCodeObjLstCache = GetObjLstCache(strPrjId); 
return arrvWebSrvClass4GeneCodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvWebSrvClass4GeneCodeEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvWebSrvClass4GeneCodeEN> arrvWebSrvClass4GeneCodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvWebSrvClass4GeneCodeObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvWebSrvClass4GeneCodeEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvWebSrvClass4GeneCodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvWebSrvClass4GeneCodeEN._RefreshTimeLst.Count == 0) return "";
return clsvWebSrvClass4GeneCodeEN._RefreshTimeLst[clsvWebSrvClass4GeneCodeEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strWebSrvClassId, string strPrjId)
{
if (strInFldName != convWebSrvClass4GeneCode.WebSrvClassId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convWebSrvClass4GeneCode._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convWebSrvClass4GeneCode._AttributeName));
throw new Exception(strMsg);
}
var objvWebSrvClass4GeneCode = clsvWebSrvClass4GeneCodeBL.GetObjByWebSrvClassIdCache(strWebSrvClassId, strPrjId);
if (objvWebSrvClass4GeneCode == null) return "";
return objvWebSrvClass4GeneCode[strOutFldName].ToString();
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
int intRecCount = clsvWebSrvClass4GeneCodeDA.GetRecCount(strTabName);
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
int intRecCount = clsvWebSrvClass4GeneCodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvWebSrvClass4GeneCodeDA.GetRecCount();
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
int intRecCount = clsvWebSrvClass4GeneCodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvWebSrvClass4GeneCodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvWebSrvClass4GeneCodeEN objvWebSrvClass4GeneCodeCond)
{
 string strPrjId = objvWebSrvClass4GeneCodeCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvWebSrvClass4GeneCodeBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvWebSrvClass4GeneCodeEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvWebSrvClass4GeneCodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convWebSrvClass4GeneCode._AttributeName)
{
if (objvWebSrvClass4GeneCodeCond.IsUpdated(strFldName) == false) continue;
if (objvWebSrvClass4GeneCodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvClass4GeneCodeCond[strFldName].ToString());
}
else
{
if (objvWebSrvClass4GeneCodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvWebSrvClass4GeneCodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvClass4GeneCodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvWebSrvClass4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvWebSrvClass4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvWebSrvClass4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvWebSrvClass4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvWebSrvClass4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvWebSrvClass4GeneCodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvWebSrvClass4GeneCodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvWebSrvClass4GeneCodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvWebSrvClass4GeneCodeCond[strFldName]));
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
 List<string> arrList = clsvWebSrvClass4GeneCodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vWebSrvClass4GeneCodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vWebSrvClass4GeneCodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}