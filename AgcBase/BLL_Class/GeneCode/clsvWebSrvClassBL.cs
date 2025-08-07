
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvClassBL
 表名:vWebSrvClass(00050349)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:44:31
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
public static class  clsvWebSrvClassBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strWebSrvClassId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWebSrvClassEN GetObj(this K_WebSrvClassId_vWebSrvClass myKey)
{
clsvWebSrvClassEN objvWebSrvClassEN = clsvWebSrvClassBL.vWebSrvClassDA.GetObjByWebSrvClassId(myKey.Value);
return objvWebSrvClassEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetWebSrvClassId(this clsvWebSrvClassEN objvWebSrvClassEN, string strWebSrvClassId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvClassId, 8, convWebSrvClass.WebSrvClassId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strWebSrvClassId, 8, convWebSrvClass.WebSrvClassId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetNameSpace(this clsvWebSrvClassEN objvWebSrvClassEN, string strNameSpace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNameSpace, 50, convWebSrvClass.NameSpace);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetWebSrvUrl(this clsvWebSrvClassEN objvWebSrvClassEN, string strWebSrvUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWebSrvUrl, convWebSrvClass.WebSrvUrl);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSrvUrl, 300, convWebSrvClass.WebSrvUrl);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetPageName(this clsvWebSrvClassEN objvWebSrvClassEN, string strPageName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPageName, convWebSrvClass.PageName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageName, 100, convWebSrvClass.PageName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetFuncModuleAgcId(this clsvWebSrvClassEN objvWebSrvClassEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleAgcId, convWebSrvClass.FuncModuleAgcId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convWebSrvClass.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convWebSrvClass.FuncModuleAgcId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetFuncModuleName(this clsvWebSrvClassEN objvWebSrvClassEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convWebSrvClass.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convWebSrvClass.FuncModuleName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetFuncModuleEnName(this clsvWebSrvClassEN objvWebSrvClassEN, string strFuncModuleEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleEnName, 30, convWebSrvClass.FuncModuleEnName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetFuncModuleNameSim(this clsvWebSrvClassEN objvWebSrvClassEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convWebSrvClass.FuncModuleNameSim);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetPrjId(this clsvWebSrvClassEN objvWebSrvClassEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convWebSrvClass.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convWebSrvClass.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convWebSrvClass.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetPrjName(this clsvWebSrvClassEN objvWebSrvClassEN, string strPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convWebSrvClass.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetUpdDate(this clsvWebSrvClassEN objvWebSrvClassEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convWebSrvClass.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetUpdUser(this clsvWebSrvClassEN objvWebSrvClassEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convWebSrvClass.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetMemo(this clsvWebSrvClassEN objvWebSrvClassEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convWebSrvClass.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetFuncNum(this clsvWebSrvClassEN objvWebSrvClassEN, int? intFuncNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvWebSrvClassEN SetClsName(this clsvWebSrvClassEN objvWebSrvClassEN, string strClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClsName, convWebSrvClass.ClsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsName, 100, convWebSrvClass.ClsName);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvWebSrvClassENS">源对象</param>
 /// <param name = "objvWebSrvClassENT">目标对象</param>
 public static void CopyTo(this clsvWebSrvClassEN objvWebSrvClassENS, clsvWebSrvClassEN objvWebSrvClassENT)
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
 /// <param name = "objvWebSrvClassENS">源对象</param>
 /// <returns>目标对象=>clsvWebSrvClassEN:objvWebSrvClassENT</returns>
 public static clsvWebSrvClassEN CopyTo(this clsvWebSrvClassEN objvWebSrvClassENS)
{
try
{
 clsvWebSrvClassEN objvWebSrvClassENT = new clsvWebSrvClassEN()
{
WebSrvClassId = objvWebSrvClassENS.WebSrvClassId, //类Id
NameSpace = objvWebSrvClassENS.NameSpace, //域名
WebSrvUrl = objvWebSrvClassENS.WebSrvUrl, //WebSrv地址
PageName = objvWebSrvClassENS.PageName, //页面名称
FuncModuleAgcId = objvWebSrvClassENS.FuncModuleAgcId, //功能模块Id
FuncModuleName = objvWebSrvClassENS.FuncModuleName, //功能模块名称
FuncModuleEnName = objvWebSrvClassENS.FuncModuleEnName, //功能模块英文名称
FuncModuleNameSim = objvWebSrvClassENS.FuncModuleNameSim, //功能模块简称
IsNeedGene = objvWebSrvClassENS.IsNeedGene, //是否需要生成
PrjId = objvWebSrvClassENS.PrjId, //工程Id
PrjName = objvWebSrvClassENS.PrjName, //工程名称
UpdDate = objvWebSrvClassENS.UpdDate, //修改日期
UpdUser = objvWebSrvClassENS.UpdUser, //修改者
Memo = objvWebSrvClassENS.Memo, //说明
FuncNum = objvWebSrvClassENS.FuncNum, //函数个数
ClsName = objvWebSrvClassENS.ClsName, //类名
};
 return objvWebSrvClassENT;
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
public static void CheckProperty4Condition(this clsvWebSrvClassEN objvWebSrvClassEN)
{
 clsvWebSrvClassBL.vWebSrvClassDA.CheckProperty4Condition(objvWebSrvClassEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vWebSrvClass
{
public virtual bool UpdRelaTabDate(string strWebSrvClassId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vWebSrv类(vWebSrvClass)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvWebSrvClassBL
{
public static RelatedActions_vWebSrvClass relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvWebSrvClassDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvWebSrvClassDA vWebSrvClassDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvWebSrvClassDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvWebSrvClassBL()
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
if (string.IsNullOrEmpty(clsvWebSrvClassEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvWebSrvClassEN._ConnectString);
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
public static DataTable GetDataTable_vWebSrvClass(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vWebSrvClassDA.GetDataTable_vWebSrvClass(strWhereCond);
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
objDT = vWebSrvClassDA.GetDataTable(strWhereCond);
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
objDT = vWebSrvClassDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vWebSrvClassDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vWebSrvClassDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vWebSrvClassDA.GetDataTable_Top(objTopPara);
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
objDT = vWebSrvClassDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vWebSrvClassDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vWebSrvClassDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvWebSrvClassEN> GetObjLstByWebSrvClassIdLst(List<string> arrWebSrvClassIdLst)
{
List<clsvWebSrvClassEN> arrObjLst = new List<clsvWebSrvClassEN>(); 
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
	clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN();
try
{
objvWebSrvClassEN.WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClassEN.NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(); //域名
objvWebSrvClassEN.WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClassEN.PageName = objRow[convWebSrvClass.PageName].ToString().Trim(); //页面名称
objvWebSrvClassEN.FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClassEN.FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClassEN.FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClassEN.FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClassEN.PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(); //工程Id
objvWebSrvClassEN.PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(); //工程名称
objvWebSrvClassEN.UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClassEN.UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(); //修改者
objvWebSrvClassEN.Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(); //说明
objvWebSrvClassEN.FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClassEN.ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrWebSrvClassIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvWebSrvClassEN> GetObjLstByWebSrvClassIdLstCache(List<string> arrWebSrvClassIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvWebSrvClassEN._CurrTabName, strPrjId);
List<clsvWebSrvClassEN> arrvWebSrvClassObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvWebSrvClassEN> arrvWebSrvClassObjLst_Sel =
arrvWebSrvClassObjLstCache
.Where(x => arrWebSrvClassIdLst.Contains(x.WebSrvClassId));
return arrvWebSrvClassObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvClassEN> GetObjLst(string strWhereCond)
{
List<clsvWebSrvClassEN> arrObjLst = new List<clsvWebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN();
try
{
objvWebSrvClassEN.WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClassEN.NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(); //域名
objvWebSrvClassEN.WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClassEN.PageName = objRow[convWebSrvClass.PageName].ToString().Trim(); //页面名称
objvWebSrvClassEN.FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClassEN.FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClassEN.FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClassEN.FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClassEN.PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(); //工程Id
objvWebSrvClassEN.PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(); //工程名称
objvWebSrvClassEN.UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClassEN.UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(); //修改者
objvWebSrvClassEN.Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(); //说明
objvWebSrvClassEN.FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClassEN.ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClassEN);
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
public static List<clsvWebSrvClassEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvWebSrvClassEN> arrObjLst = new List<clsvWebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN();
try
{
objvWebSrvClassEN.WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClassEN.NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(); //域名
objvWebSrvClassEN.WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClassEN.PageName = objRow[convWebSrvClass.PageName].ToString().Trim(); //页面名称
objvWebSrvClassEN.FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClassEN.FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClassEN.FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClassEN.FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClassEN.PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(); //工程Id
objvWebSrvClassEN.PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(); //工程名称
objvWebSrvClassEN.UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClassEN.UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(); //修改者
objvWebSrvClassEN.Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(); //说明
objvWebSrvClassEN.FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClassEN.ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvWebSrvClassCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvWebSrvClassEN> GetSubObjLstCache(clsvWebSrvClassEN objvWebSrvClassCond)
{
 string strPrjId = objvWebSrvClassCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvWebSrvClassBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvWebSrvClassEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvWebSrvClassEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convWebSrvClass._AttributeName)
{
if (objvWebSrvClassCond.IsUpdated(strFldName) == false) continue;
if (objvWebSrvClassCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvClassCond[strFldName].ToString());
}
else
{
if (objvWebSrvClassCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvWebSrvClassCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvClassCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvWebSrvClassCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvWebSrvClassCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvWebSrvClassCond[strFldName]));
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
public static List<clsvWebSrvClassEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvWebSrvClassEN> arrObjLst = new List<clsvWebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN();
try
{
objvWebSrvClassEN.WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClassEN.NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(); //域名
objvWebSrvClassEN.WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClassEN.PageName = objRow[convWebSrvClass.PageName].ToString().Trim(); //页面名称
objvWebSrvClassEN.FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClassEN.FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClassEN.FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClassEN.FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClassEN.PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(); //工程Id
objvWebSrvClassEN.PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(); //工程名称
objvWebSrvClassEN.UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClassEN.UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(); //修改者
objvWebSrvClassEN.Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(); //说明
objvWebSrvClassEN.FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClassEN.ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClassEN);
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
public static List<clsvWebSrvClassEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvWebSrvClassEN> arrObjLst = new List<clsvWebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN();
try
{
objvWebSrvClassEN.WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClassEN.NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(); //域名
objvWebSrvClassEN.WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClassEN.PageName = objRow[convWebSrvClass.PageName].ToString().Trim(); //页面名称
objvWebSrvClassEN.FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClassEN.FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClassEN.FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClassEN.FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClassEN.PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(); //工程Id
objvWebSrvClassEN.PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(); //工程名称
objvWebSrvClassEN.UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClassEN.UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(); //修改者
objvWebSrvClassEN.Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(); //说明
objvWebSrvClassEN.FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClassEN.ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClassEN);
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
List<clsvWebSrvClassEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvWebSrvClassEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvClassEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvWebSrvClassEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvWebSrvClassEN> arrObjLst = new List<clsvWebSrvClassEN>(); 
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
	clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN();
try
{
objvWebSrvClassEN.WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClassEN.NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(); //域名
objvWebSrvClassEN.WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClassEN.PageName = objRow[convWebSrvClass.PageName].ToString().Trim(); //页面名称
objvWebSrvClassEN.FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClassEN.FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClassEN.FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClassEN.FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClassEN.PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(); //工程Id
objvWebSrvClassEN.PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(); //工程名称
objvWebSrvClassEN.UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClassEN.UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(); //修改者
objvWebSrvClassEN.Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(); //说明
objvWebSrvClassEN.FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClassEN.ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClassEN);
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
public static List<clsvWebSrvClassEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvWebSrvClassEN> arrObjLst = new List<clsvWebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN();
try
{
objvWebSrvClassEN.WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClassEN.NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(); //域名
objvWebSrvClassEN.WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClassEN.PageName = objRow[convWebSrvClass.PageName].ToString().Trim(); //页面名称
objvWebSrvClassEN.FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClassEN.FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClassEN.FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClassEN.FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClassEN.PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(); //工程Id
objvWebSrvClassEN.PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(); //工程名称
objvWebSrvClassEN.UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClassEN.UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(); //修改者
objvWebSrvClassEN.Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(); //说明
objvWebSrvClassEN.FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClassEN.ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvWebSrvClassEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvWebSrvClassEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvWebSrvClassEN> arrObjLst = new List<clsvWebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN();
try
{
objvWebSrvClassEN.WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClassEN.NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(); //域名
objvWebSrvClassEN.WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClassEN.PageName = objRow[convWebSrvClass.PageName].ToString().Trim(); //页面名称
objvWebSrvClassEN.FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClassEN.FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClassEN.FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClassEN.FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClassEN.PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(); //工程Id
objvWebSrvClassEN.PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(); //工程名称
objvWebSrvClassEN.UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClassEN.UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(); //修改者
objvWebSrvClassEN.Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(); //说明
objvWebSrvClassEN.FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClassEN.ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClassEN);
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
public static List<clsvWebSrvClassEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvWebSrvClassEN> arrObjLst = new List<clsvWebSrvClassEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN();
try
{
objvWebSrvClassEN.WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClassEN.NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(); //域名
objvWebSrvClassEN.WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClassEN.PageName = objRow[convWebSrvClass.PageName].ToString().Trim(); //页面名称
objvWebSrvClassEN.FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClassEN.FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClassEN.FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClassEN.FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClassEN.PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(); //工程Id
objvWebSrvClassEN.PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(); //工程名称
objvWebSrvClassEN.UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClassEN.UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(); //修改者
objvWebSrvClassEN.Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(); //说明
objvWebSrvClassEN.FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClassEN.ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClassEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvWebSrvClassEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvWebSrvClassEN> arrObjLst = new List<clsvWebSrvClassEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvClassEN objvWebSrvClassEN = new clsvWebSrvClassEN();
try
{
objvWebSrvClassEN.WebSrvClassId = objRow[convWebSrvClass.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvClassEN.NameSpace = objRow[convWebSrvClass.NameSpace] == DBNull.Value ? null : objRow[convWebSrvClass.NameSpace].ToString().Trim(); //域名
objvWebSrvClassEN.WebSrvUrl = objRow[convWebSrvClass.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvClassEN.PageName = objRow[convWebSrvClass.PageName].ToString().Trim(); //页面名称
objvWebSrvClassEN.FuncModuleAgcId = objRow[convWebSrvClass.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvClassEN.FuncModuleName = objRow[convWebSrvClass.FuncModuleName].ToString().Trim(); //功能模块名称
objvWebSrvClassEN.FuncModuleEnName = objRow[convWebSrvClass.FuncModuleEnName] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvWebSrvClassEN.FuncModuleNameSim = objRow[convWebSrvClass.FuncModuleNameSim] == DBNull.Value ? null : objRow[convWebSrvClass.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvWebSrvClassEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvClass.IsNeedGene].ToString().Trim()); //是否需要生成
objvWebSrvClassEN.PrjId = objRow[convWebSrvClass.PrjId].ToString().Trim(); //工程Id
objvWebSrvClassEN.PrjName = objRow[convWebSrvClass.PrjName] == DBNull.Value ? null : objRow[convWebSrvClass.PrjName].ToString().Trim(); //工程名称
objvWebSrvClassEN.UpdDate = objRow[convWebSrvClass.UpdDate] == DBNull.Value ? null : objRow[convWebSrvClass.UpdDate].ToString().Trim(); //修改日期
objvWebSrvClassEN.UpdUser = objRow[convWebSrvClass.UpdUser] == DBNull.Value ? null : objRow[convWebSrvClass.UpdUser].ToString().Trim(); //修改者
objvWebSrvClassEN.Memo = objRow[convWebSrvClass.Memo] == DBNull.Value ? null : objRow[convWebSrvClass.Memo].ToString().Trim(); //说明
objvWebSrvClassEN.FuncNum = objRow[convWebSrvClass.FuncNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWebSrvClass.FuncNum].ToString().Trim()); //函数个数
objvWebSrvClassEN.ClsName = objRow[convWebSrvClass.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvWebSrvClassEN.WebSrvClassId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvWebSrvClassEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvWebSrvClassEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvWebSrvClass(ref clsvWebSrvClassEN objvWebSrvClassEN)
{
bool bolResult = vWebSrvClassDA.GetvWebSrvClass(ref objvWebSrvClassEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strWebSrvClassId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvWebSrvClassEN GetObjByWebSrvClassId(string strWebSrvClassId)
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
clsvWebSrvClassEN objvWebSrvClassEN = vWebSrvClassDA.GetObjByWebSrvClassId(strWebSrvClassId);
return objvWebSrvClassEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvWebSrvClassEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvWebSrvClassEN objvWebSrvClassEN = vWebSrvClassDA.GetFirstObj(strWhereCond);
 return objvWebSrvClassEN;
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
public static clsvWebSrvClassEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvWebSrvClassEN objvWebSrvClassEN = vWebSrvClassDA.GetObjByDataRow(objRow);
 return objvWebSrvClassEN;
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
public static clsvWebSrvClassEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvWebSrvClassEN objvWebSrvClassEN = vWebSrvClassDA.GetObjByDataRow(objRow);
 return objvWebSrvClassEN;
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
 /// <param name = "lstvWebSrvClassObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvWebSrvClassEN GetObjByWebSrvClassIdFromList(string strWebSrvClassId, List<clsvWebSrvClassEN> lstvWebSrvClassObjLst)
{
foreach (clsvWebSrvClassEN objvWebSrvClassEN in lstvWebSrvClassObjLst)
{
if (objvWebSrvClassEN.WebSrvClassId == strWebSrvClassId)
{
return objvWebSrvClassEN;
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
 strWebSrvClassId = new clsvWebSrvClassDA().GetFirstID(strWhereCond);
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
 arrList = vWebSrvClassDA.GetID(strWhereCond);
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
bool bolIsExist = vWebSrvClassDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vWebSrvClassDA.IsExist(strWebSrvClassId);
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
 bolIsExist = clsvWebSrvClassDA.IsExistTable();
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
 bolIsExist = vWebSrvClassDA.IsExistTable(strTabName);
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
 /// <param name = "objvWebSrvClassEN">源简化对象</param>
 public static void SetUpdFlag(clsvWebSrvClassEN objvWebSrvClassEN)
{
try
{
objvWebSrvClassEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvWebSrvClassEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convWebSrvClass.WebSrvClassId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.WebSrvClassId = objvWebSrvClassEN.WebSrvClassId; //类Id
}
if (arrFldSet.Contains(convWebSrvClass.NameSpace, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.NameSpace = objvWebSrvClassEN.NameSpace == "[null]" ? null :  objvWebSrvClassEN.NameSpace; //域名
}
if (arrFldSet.Contains(convWebSrvClass.WebSrvUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.WebSrvUrl = objvWebSrvClassEN.WebSrvUrl; //WebSrv地址
}
if (arrFldSet.Contains(convWebSrvClass.PageName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.PageName = objvWebSrvClassEN.PageName; //页面名称
}
if (arrFldSet.Contains(convWebSrvClass.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.FuncModuleAgcId = objvWebSrvClassEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convWebSrvClass.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.FuncModuleName = objvWebSrvClassEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convWebSrvClass.FuncModuleEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.FuncModuleEnName = objvWebSrvClassEN.FuncModuleEnName == "[null]" ? null :  objvWebSrvClassEN.FuncModuleEnName; //功能模块英文名称
}
if (arrFldSet.Contains(convWebSrvClass.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.FuncModuleNameSim = objvWebSrvClassEN.FuncModuleNameSim == "[null]" ? null :  objvWebSrvClassEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convWebSrvClass.IsNeedGene, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.IsNeedGene = objvWebSrvClassEN.IsNeedGene; //是否需要生成
}
if (arrFldSet.Contains(convWebSrvClass.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.PrjId = objvWebSrvClassEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convWebSrvClass.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.PrjName = objvWebSrvClassEN.PrjName == "[null]" ? null :  objvWebSrvClassEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convWebSrvClass.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.UpdDate = objvWebSrvClassEN.UpdDate == "[null]" ? null :  objvWebSrvClassEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convWebSrvClass.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.UpdUser = objvWebSrvClassEN.UpdUser == "[null]" ? null :  objvWebSrvClassEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convWebSrvClass.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.Memo = objvWebSrvClassEN.Memo == "[null]" ? null :  objvWebSrvClassEN.Memo; //说明
}
if (arrFldSet.Contains(convWebSrvClass.FuncNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.FuncNum = objvWebSrvClassEN.FuncNum; //函数个数
}
if (arrFldSet.Contains(convWebSrvClass.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvWebSrvClassEN.ClsName = objvWebSrvClassEN.ClsName; //类名
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
 /// <param name = "objvWebSrvClassEN">源简化对象</param>
 public static void AccessFldValueNull(clsvWebSrvClassEN objvWebSrvClassEN)
{
try
{
if (objvWebSrvClassEN.NameSpace == "[null]") objvWebSrvClassEN.NameSpace = null; //域名
if (objvWebSrvClassEN.FuncModuleEnName == "[null]") objvWebSrvClassEN.FuncModuleEnName = null; //功能模块英文名称
if (objvWebSrvClassEN.FuncModuleNameSim == "[null]") objvWebSrvClassEN.FuncModuleNameSim = null; //功能模块简称
if (objvWebSrvClassEN.PrjName == "[null]") objvWebSrvClassEN.PrjName = null; //工程名称
if (objvWebSrvClassEN.UpdDate == "[null]") objvWebSrvClassEN.UpdDate = null; //修改日期
if (objvWebSrvClassEN.UpdUser == "[null]") objvWebSrvClassEN.UpdUser = null; //修改者
if (objvWebSrvClassEN.Memo == "[null]") objvWebSrvClassEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvWebSrvClassEN objvWebSrvClassEN)
{
 vWebSrvClassDA.CheckProperty4Condition(objvWebSrvClassEN);
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
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by WebSrvClassId");
//if (arrvWebSrvClassObjLstCache == null)
//{
//arrvWebSrvClassObjLstCache = vWebSrvClassDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strWebSrvClassId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvWebSrvClassEN GetObjByWebSrvClassIdCache(string strWebSrvClassId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvWebSrvClassEN._CurrTabName, strPrjId);
List<clsvWebSrvClassEN> arrvWebSrvClassObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvWebSrvClassEN> arrvWebSrvClassObjLst_Sel =
arrvWebSrvClassObjLstCache
.Where(x=> x.WebSrvClassId == strWebSrvClassId 
);
if (arrvWebSrvClassObjLst_Sel.Count() == 0)
{
   clsvWebSrvClassEN obj = clsvWebSrvClassBL.GetObjByWebSrvClassId(strWebSrvClassId);
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
return arrvWebSrvClassObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvWebSrvClassEN> GetAllvWebSrvClassObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvWebSrvClassEN> arrvWebSrvClassObjLstCache = GetObjLstCache(strPrjId); 
return arrvWebSrvClassObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvWebSrvClassEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvWebSrvClassEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvWebSrvClassEN> arrvWebSrvClassObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvWebSrvClassObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvWebSrvClassEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvWebSrvClassEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvWebSrvClassEN._RefreshTimeLst.Count == 0) return "";
return clsvWebSrvClassEN._RefreshTimeLst[clsvWebSrvClassEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convWebSrvClass.WebSrvClassId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convWebSrvClass._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convWebSrvClass._AttributeName));
throw new Exception(strMsg);
}
var objvWebSrvClass = clsvWebSrvClassBL.GetObjByWebSrvClassIdCache(strWebSrvClassId, strPrjId);
if (objvWebSrvClass == null) return "";
return objvWebSrvClass[strOutFldName].ToString();
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
int intRecCount = clsvWebSrvClassDA.GetRecCount(strTabName);
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
int intRecCount = clsvWebSrvClassDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvWebSrvClassDA.GetRecCount();
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
int intRecCount = clsvWebSrvClassDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvWebSrvClassCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvWebSrvClassEN objvWebSrvClassCond)
{
 string strPrjId = objvWebSrvClassCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvWebSrvClassBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvWebSrvClassEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvWebSrvClassEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convWebSrvClass._AttributeName)
{
if (objvWebSrvClassCond.IsUpdated(strFldName) == false) continue;
if (objvWebSrvClassCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvClassCond[strFldName].ToString());
}
else
{
if (objvWebSrvClassCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvWebSrvClassCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvWebSrvClassCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvWebSrvClassCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvWebSrvClassCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvWebSrvClassCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvWebSrvClassCond[strFldName]));
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
 List<string> arrList = clsvWebSrvClassDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vWebSrvClassDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vWebSrvClassDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}