
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvClassWApi
 表名:vWebSrvClass(00050349)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
public static class  clsvWebSrvClassWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvClassId">类Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetWebSrvClassId(this clsvWebSrvClassEN objvWebSrvClassEN, string strWebSrvClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWebSrvClassId, 8, convWebSrvClass.WebSrvClassId);
clsCheckSql.CheckFieldForeignKey(strWebSrvClassId, 8, convWebSrvClass.WebSrvClassId);
objvWebSrvClassEN.WebSrvClassId = strWebSrvClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.WebSrvClassId) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.WebSrvClassId, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.WebSrvClassId] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strNameSpace">域名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetNameSpace(this clsvWebSrvClassEN objvWebSrvClassEN, string strNameSpace, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNameSpace, 50, convWebSrvClass.NameSpace);
objvWebSrvClassEN.NameSpace = strNameSpace; //域名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.NameSpace) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.NameSpace, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.NameSpace] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strWebSrvUrl">WebSrv地址</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetWebSrvUrl(this clsvWebSrvClassEN objvWebSrvClassEN, string strWebSrvUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvUrl, convWebSrvClass.WebSrvUrl);
clsCheckSql.CheckFieldLen(strWebSrvUrl, 300, convWebSrvClass.WebSrvUrl);
objvWebSrvClassEN.WebSrvUrl = strWebSrvUrl; //WebSrv地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.WebSrvUrl) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.WebSrvUrl, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.WebSrvUrl] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strPageName">页面名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetPageName(this clsvWebSrvClassEN objvWebSrvClassEN, string strPageName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPageName, convWebSrvClass.PageName);
clsCheckSql.CheckFieldLen(strPageName, 100, convWebSrvClass.PageName);
objvWebSrvClassEN.PageName = strPageName; //页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.PageName) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.PageName, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.PageName] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleAgcId">功能模块Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetFuncModuleAgcId(this clsvWebSrvClassEN objvWebSrvClassEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convWebSrvClass.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convWebSrvClass.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convWebSrvClass.FuncModuleAgcId);
objvWebSrvClassEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.FuncModuleAgcId) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.FuncModuleAgcId, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.FuncModuleAgcId] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleName">功能模块名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetFuncModuleName(this clsvWebSrvClassEN objvWebSrvClassEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convWebSrvClass.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convWebSrvClass.FuncModuleName);
objvWebSrvClassEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.FuncModuleName) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.FuncModuleName, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.FuncModuleName] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleEnName">功能模块英文名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetFuncModuleEnName(this clsvWebSrvClassEN objvWebSrvClassEN, string strFuncModuleEnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convWebSrvClass.FuncModuleEnName);
objvWebSrvClassEN.FuncModuleEnName = strFuncModuleEnName; //功能模块英文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.FuncModuleEnName) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.FuncModuleEnName, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.FuncModuleEnName] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncModuleNameSim">功能模块简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetFuncModuleNameSim(this clsvWebSrvClassEN objvWebSrvClassEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convWebSrvClass.FuncModuleNameSim);
objvWebSrvClassEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.FuncModuleNameSim) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.FuncModuleNameSim, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.FuncModuleNameSim] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedGene">是否需要生成</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetIsNeedGene(this clsvWebSrvClassEN objvWebSrvClassEN, bool bolIsNeedGene, string strComparisonOp="")
	{
objvWebSrvClassEN.IsNeedGene = bolIsNeedGene; //是否需要生成
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.IsNeedGene) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.IsNeedGene, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.IsNeedGene] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetPrjId(this clsvWebSrvClassEN objvWebSrvClassEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convWebSrvClass.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convWebSrvClass.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convWebSrvClass.PrjId);
objvWebSrvClassEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.PrjId) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.PrjId, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.PrjId] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetPrjName(this clsvWebSrvClassEN objvWebSrvClassEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjName, 30, convWebSrvClass.PrjName);
objvWebSrvClassEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.PrjName) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.PrjName, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.PrjName] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetUpdDate(this clsvWebSrvClassEN objvWebSrvClassEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convWebSrvClass.UpdDate);
objvWebSrvClassEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.UpdDate) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.UpdDate, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.UpdDate] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetUpdUser(this clsvWebSrvClassEN objvWebSrvClassEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convWebSrvClass.UpdUser);
objvWebSrvClassEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.UpdUser) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.UpdUser, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.UpdUser] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetMemo(this clsvWebSrvClassEN objvWebSrvClassEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convWebSrvClass.Memo);
objvWebSrvClassEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.Memo) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.Memo, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.Memo] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "intFuncNum">函数个数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetFuncNum(this clsvWebSrvClassEN objvWebSrvClassEN, int intFuncNum, string strComparisonOp="")
	{
objvWebSrvClassEN.FuncNum = intFuncNum; //函数个数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.FuncNum) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.FuncNum, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.FuncNum] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strClsName">类名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetClsName(this clsvWebSrvClassEN objvWebSrvClassEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsName, convWebSrvClass.ClsName);
clsCheckSql.CheckFieldLen(strClsName, 100, convWebSrvClass.ClsName);
objvWebSrvClassEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvWebSrvClassEN.dicFldComparisonOp.ContainsKey(convWebSrvClass.ClsName) == false)
{
objvWebSrvClassEN.dicFldComparisonOp.Add(convWebSrvClass.ClsName, strComparisonOp);
}
else
{
objvWebSrvClassEN.dicFldComparisonOp[convWebSrvClass.ClsName] = strComparisonOp;
}
}
return objvWebSrvClassEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvWebSrvClassEN objvWebSrvClassCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.WebSrvClassId) == true)
{
string strComparisonOpWebSrvClassId = objvWebSrvClassCond.dicFldComparisonOp[convWebSrvClass.WebSrvClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass.WebSrvClassId, objvWebSrvClassCond.WebSrvClassId, strComparisonOpWebSrvClassId);
}
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.NameSpace) == true)
{
string strComparisonOpNameSpace = objvWebSrvClassCond.dicFldComparisonOp[convWebSrvClass.NameSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass.NameSpace, objvWebSrvClassCond.NameSpace, strComparisonOpNameSpace);
}
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.WebSrvUrl) == true)
{
string strComparisonOpWebSrvUrl = objvWebSrvClassCond.dicFldComparisonOp[convWebSrvClass.WebSrvUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass.WebSrvUrl, objvWebSrvClassCond.WebSrvUrl, strComparisonOpWebSrvUrl);
}
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.PageName) == true)
{
string strComparisonOpPageName = objvWebSrvClassCond.dicFldComparisonOp[convWebSrvClass.PageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass.PageName, objvWebSrvClassCond.PageName, strComparisonOpPageName);
}
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvWebSrvClassCond.dicFldComparisonOp[convWebSrvClass.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass.FuncModuleAgcId, objvWebSrvClassCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvWebSrvClassCond.dicFldComparisonOp[convWebSrvClass.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass.FuncModuleName, objvWebSrvClassCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.FuncModuleEnName) == true)
{
string strComparisonOpFuncModuleEnName = objvWebSrvClassCond.dicFldComparisonOp[convWebSrvClass.FuncModuleEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass.FuncModuleEnName, objvWebSrvClassCond.FuncModuleEnName, strComparisonOpFuncModuleEnName);
}
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvWebSrvClassCond.dicFldComparisonOp[convWebSrvClass.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass.FuncModuleNameSim, objvWebSrvClassCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.IsNeedGene) == true)
{
if (objvWebSrvClassCond.IsNeedGene == true)
{
strWhereCond += string.Format(" And {0} = '1'", convWebSrvClass.IsNeedGene);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convWebSrvClass.IsNeedGene);
}
}
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.PrjId) == true)
{
string strComparisonOpPrjId = objvWebSrvClassCond.dicFldComparisonOp[convWebSrvClass.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass.PrjId, objvWebSrvClassCond.PrjId, strComparisonOpPrjId);
}
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.PrjName) == true)
{
string strComparisonOpPrjName = objvWebSrvClassCond.dicFldComparisonOp[convWebSrvClass.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass.PrjName, objvWebSrvClassCond.PrjName, strComparisonOpPrjName);
}
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.UpdDate) == true)
{
string strComparisonOpUpdDate = objvWebSrvClassCond.dicFldComparisonOp[convWebSrvClass.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass.UpdDate, objvWebSrvClassCond.UpdDate, strComparisonOpUpdDate);
}
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.UpdUser) == true)
{
string strComparisonOpUpdUser = objvWebSrvClassCond.dicFldComparisonOp[convWebSrvClass.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass.UpdUser, objvWebSrvClassCond.UpdUser, strComparisonOpUpdUser);
}
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.Memo) == true)
{
string strComparisonOpMemo = objvWebSrvClassCond.dicFldComparisonOp[convWebSrvClass.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass.Memo, objvWebSrvClassCond.Memo, strComparisonOpMemo);
}
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.FuncNum) == true)
{
string strComparisonOpFuncNum = objvWebSrvClassCond.dicFldComparisonOp[convWebSrvClass.FuncNum];
strWhereCond += string.Format(" And {0} {2} {1}", convWebSrvClass.FuncNum, objvWebSrvClassCond.FuncNum, strComparisonOpFuncNum);
}
if (objvWebSrvClassCond.IsUpdated(convWebSrvClass.ClsName) == true)
{
string strComparisonOpClsName = objvWebSrvClassCond.dicFldComparisonOp[convWebSrvClass.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convWebSrvClass.ClsName, objvWebSrvClassCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vWebSrv类(vWebSrvClass)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvWebSrvClassWApi
{
private static readonly string mstrApiControllerName = "vWebSrvClassApi";

 public clsvWebSrvClassWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strWebSrvClassId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWebSrvClassEN GetObjByWebSrvClassId(string strWebSrvClassId)
{
if (strWebSrvClassId == "") return null;
string strAction = "GetObjByWebSrvClassId";
clsvWebSrvClassEN objvWebSrvClassEN;
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
objvWebSrvClassEN = JsonConvert.DeserializeObject<clsvWebSrvClassEN>(strJson);
return objvWebSrvClassEN;
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
public static clsvWebSrvClassEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvWebSrvClassEN objvWebSrvClassEN;
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
objvWebSrvClassEN = JsonConvert.DeserializeObject<clsvWebSrvClassEN>(strJson);
return objvWebSrvClassEN;
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
public static List<clsvWebSrvClassEN> GetObjLst(string strWhereCond)
{
 List<clsvWebSrvClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvClassEN>>(strJson);
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
public static List<clsvWebSrvClassEN> GetObjLstByWebSrvClassIdLst(List<string> arrWebSrvClassId)
{
 List<clsvWebSrvClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvClassEN>>(strJson);
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
public static List<clsvWebSrvClassEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvWebSrvClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvClassEN>>(strJson);
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
public static List<clsvWebSrvClassEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvWebSrvClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvClassEN>>(strJson);
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
public static List<clsvWebSrvClassEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvWebSrvClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvClassEN>>(strJson);
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
public static List<clsvWebSrvClassEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvWebSrvClassEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvWebSrvClassEN>>(strJson);
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
 /// <param name = "objvWebSrvClassENS">源对象</param>
 /// <param name = "objvWebSrvClassENT">目标对象</param>
 public static void CopyTo(clsvWebSrvClassEN objvWebSrvClassENS, clsvWebSrvClassEN objvWebSrvClassENT)
{
try
{
objvWebSrvClassENT.WebSrvClassId = objvWebSrvClassENS.WebSrvClassId; //类Id
objvWebSrvClassENT.NameSpace = objvWebSrvClassENS.NameSpace; //域名
objvWebSrvClassENT.WebSrvUrl = objvWebSrvClassENS.WebSrvUrl; //WebSrv地址
objvWebSrvClassENT.PageName = objvWebSrvClassENS.PageName; //页面名称
objvWebSrvClassENT.FuncModuleAgcId = objvWebSrvClassENS.FuncModuleAgcId; //功能模块Id
objvWebSrvClassENT.FuncModuleName = objvWebSrvClassENS.FuncModuleName; //功能模块名称
objvWebSrvClassENT.FuncModuleEnName = objvWebSrvClassENS.FuncModuleEnName; //功能模块英文名称
objvWebSrvClassENT.FuncModuleNameSim = objvWebSrvClassENS.FuncModuleNameSim; //功能模块简称
objvWebSrvClassENT.IsNeedGene = objvWebSrvClassENS.IsNeedGene; //是否需要生成
objvWebSrvClassENT.PrjId = objvWebSrvClassENS.PrjId; //工程Id
objvWebSrvClassENT.PrjName = objvWebSrvClassENS.PrjName; //工程名称
objvWebSrvClassENT.UpdDate = objvWebSrvClassENS.UpdDate; //修改日期
objvWebSrvClassENT.UpdUser = objvWebSrvClassENS.UpdUser; //修改者
objvWebSrvClassENT.Memo = objvWebSrvClassENS.Memo; //说明
objvWebSrvClassENT.FuncNum = objvWebSrvClassENS.FuncNum; //函数个数
objvWebSrvClassENT.ClsName = objvWebSrvClassENS.ClsName; //类名
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
public static DataTable ToDataTable(List<clsvWebSrvClassEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvWebSrvClassEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvWebSrvClassEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvWebSrvClassEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvWebSrvClassEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvWebSrvClassEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId = "")
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvWebSrvClassWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvWebSrvClassWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvWebSrvClassEN._CurrTabName, strPrjId);
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
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvWebSrvClassEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convWebSrvClass.WebSrvClassId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass.NameSpace, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass.WebSrvUrl, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass.PageName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass.FuncModuleAgcId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass.FuncModuleEnName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass.FuncModuleNameSim, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass.IsNeedGene, Type.GetType("System.Boolean"));
objDT.Columns.Add(convWebSrvClass.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convWebSrvClass.FuncNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convWebSrvClass.ClsName, Type.GetType("System.String"));
foreach (clsvWebSrvClassEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convWebSrvClass.WebSrvClassId] = objInFor[convWebSrvClass.WebSrvClassId];
objDR[convWebSrvClass.NameSpace] = objInFor[convWebSrvClass.NameSpace];
objDR[convWebSrvClass.WebSrvUrl] = objInFor[convWebSrvClass.WebSrvUrl];
objDR[convWebSrvClass.PageName] = objInFor[convWebSrvClass.PageName];
objDR[convWebSrvClass.FuncModuleAgcId] = objInFor[convWebSrvClass.FuncModuleAgcId];
objDR[convWebSrvClass.FuncModuleName] = objInFor[convWebSrvClass.FuncModuleName];
objDR[convWebSrvClass.FuncModuleEnName] = objInFor[convWebSrvClass.FuncModuleEnName];
objDR[convWebSrvClass.FuncModuleNameSim] = objInFor[convWebSrvClass.FuncModuleNameSim];
objDR[convWebSrvClass.IsNeedGene] = objInFor[convWebSrvClass.IsNeedGene];
objDR[convWebSrvClass.PrjId] = objInFor[convWebSrvClass.PrjId];
objDR[convWebSrvClass.PrjName] = objInFor[convWebSrvClass.PrjName];
objDR[convWebSrvClass.UpdDate] = objInFor[convWebSrvClass.UpdDate];
objDR[convWebSrvClass.UpdUser] = objInFor[convWebSrvClass.UpdUser];
objDR[convWebSrvClass.Memo] = objInFor[convWebSrvClass.Memo];
objDR[convWebSrvClass.FuncNum] = objInFor[convWebSrvClass.FuncNum];
objDR[convWebSrvClass.ClsName] = objInFor[convWebSrvClass.ClsName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}