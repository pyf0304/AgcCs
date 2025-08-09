
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMClassFuncRelaBL
 表名:vCMClassFuncRela(00050510)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 19:57:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsvCMClassFuncRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMClassFuncRelaEN GetObj(this K_mId_vCMClassFuncRela myKey)
{
clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = clsvCMClassFuncRelaBL.vCMClassFuncRelaDA.GetObjBymId(myKey.Value);
return objvCMClassFuncRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassFuncRelaEN SetmId(this clsvCMClassFuncRelaEN objvCMClassFuncRelaEN, long lngmId, string strComparisonOp="")
	{
objvCMClassFuncRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(convCMClassFuncRela.mId) == false)
{
objvCMClassFuncRelaEN.dicFldComparisonOp.Add(convCMClassFuncRela.mId, strComparisonOp);
}
else
{
objvCMClassFuncRelaEN.dicFldComparisonOp[convCMClassFuncRela.mId] = strComparisonOp;
}
}
return objvCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassFuncRelaEN SetCmClassId(this clsvCMClassFuncRelaEN objvCMClassFuncRelaEN, string strCmClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmClassId, convCMClassFuncRela.CmClassId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmClassId, 8, convCMClassFuncRela.CmClassId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmClassId, 8, convCMClassFuncRela.CmClassId);
}
objvCMClassFuncRelaEN.CmClassId = strCmClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(convCMClassFuncRela.CmClassId) == false)
{
objvCMClassFuncRelaEN.dicFldComparisonOp.Add(convCMClassFuncRela.CmClassId, strComparisonOp);
}
else
{
objvCMClassFuncRelaEN.dicFldComparisonOp[convCMClassFuncRela.CmClassId] = strComparisonOp;
}
}
return objvCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassFuncRelaEN SetApplicationTypeId(this clsvCMClassFuncRelaEN objvCMClassFuncRelaEN, int? intApplicationTypeId, string strComparisonOp="")
	{
objvCMClassFuncRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(convCMClassFuncRela.ApplicationTypeId) == false)
{
objvCMClassFuncRelaEN.dicFldComparisonOp.Add(convCMClassFuncRela.ApplicationTypeId, strComparisonOp);
}
else
{
objvCMClassFuncRelaEN.dicFldComparisonOp[convCMClassFuncRela.ApplicationTypeId] = strComparisonOp;
}
}
return objvCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassFuncRelaEN SetProgLangTypeId(this clsvCMClassFuncRelaEN objvCMClassFuncRelaEN, string strProgLangTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convCMClassFuncRela.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convCMClassFuncRela.ProgLangTypeId);
}
objvCMClassFuncRelaEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(convCMClassFuncRela.ProgLangTypeId) == false)
{
objvCMClassFuncRelaEN.dicFldComparisonOp.Add(convCMClassFuncRela.ProgLangTypeId, strComparisonOp);
}
else
{
objvCMClassFuncRelaEN.dicFldComparisonOp[convCMClassFuncRela.ProgLangTypeId] = strComparisonOp;
}
}
return objvCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassFuncRelaEN SetPrjId(this clsvCMClassFuncRelaEN objvCMClassFuncRelaEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMClassFuncRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMClassFuncRela.PrjId);
}
objvCMClassFuncRelaEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(convCMClassFuncRela.PrjId) == false)
{
objvCMClassFuncRelaEN.dicFldComparisonOp.Add(convCMClassFuncRela.PrjId, strComparisonOp);
}
else
{
objvCMClassFuncRelaEN.dicFldComparisonOp[convCMClassFuncRela.PrjId] = strComparisonOp;
}
}
return objvCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassFuncRelaEN SetCmFunctionId(this clsvCMClassFuncRelaEN objvCMClassFuncRelaEN, string strCmFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFunctionId, convCMClassFuncRela.CmFunctionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFunctionId, 8, convCMClassFuncRela.CmFunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFunctionId, 8, convCMClassFuncRela.CmFunctionId);
}
objvCMClassFuncRelaEN.CmFunctionId = strCmFunctionId; //函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(convCMClassFuncRela.CmFunctionId) == false)
{
objvCMClassFuncRelaEN.dicFldComparisonOp.Add(convCMClassFuncRela.CmFunctionId, strComparisonOp);
}
else
{
objvCMClassFuncRelaEN.dicFldComparisonOp[convCMClassFuncRela.CmFunctionId] = strComparisonOp;
}
}
return objvCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassFuncRelaEN SetFunctionName(this clsvCMClassFuncRelaEN objvCMClassFuncRelaEN, string strFunctionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionName, 200, convCMClassFuncRela.FunctionName);
}
objvCMClassFuncRelaEN.FunctionName = strFunctionName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(convCMClassFuncRela.FunctionName) == false)
{
objvCMClassFuncRelaEN.dicFldComparisonOp.Add(convCMClassFuncRela.FunctionName, strComparisonOp);
}
else
{
objvCMClassFuncRelaEN.dicFldComparisonOp[convCMClassFuncRela.FunctionName] = strComparisonOp;
}
}
return objvCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassFuncRelaEN SetOrderNum(this clsvCMClassFuncRelaEN objvCMClassFuncRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convCMClassFuncRela.OrderNum);
objvCMClassFuncRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(convCMClassFuncRela.OrderNum) == false)
{
objvCMClassFuncRelaEN.dicFldComparisonOp.Add(convCMClassFuncRela.OrderNum, strComparisonOp);
}
else
{
objvCMClassFuncRelaEN.dicFldComparisonOp[convCMClassFuncRela.OrderNum] = strComparisonOp;
}
}
return objvCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassFuncRelaEN SetUpdDate(this clsvCMClassFuncRelaEN objvCMClassFuncRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMClassFuncRela.UpdDate);
}
objvCMClassFuncRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(convCMClassFuncRela.UpdDate) == false)
{
objvCMClassFuncRelaEN.dicFldComparisonOp.Add(convCMClassFuncRela.UpdDate, strComparisonOp);
}
else
{
objvCMClassFuncRelaEN.dicFldComparisonOp[convCMClassFuncRela.UpdDate] = strComparisonOp;
}
}
return objvCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassFuncRelaEN SetUpdUser(this clsvCMClassFuncRelaEN objvCMClassFuncRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMClassFuncRela.UpdUser);
}
objvCMClassFuncRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(convCMClassFuncRela.UpdUser) == false)
{
objvCMClassFuncRelaEN.dicFldComparisonOp.Add(convCMClassFuncRela.UpdUser, strComparisonOp);
}
else
{
objvCMClassFuncRelaEN.dicFldComparisonOp[convCMClassFuncRela.UpdUser] = strComparisonOp;
}
}
return objvCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassFuncRelaEN SetMemo(this clsvCMClassFuncRelaEN objvCMClassFuncRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMClassFuncRela.Memo);
}
objvCMClassFuncRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(convCMClassFuncRela.Memo) == false)
{
objvCMClassFuncRelaEN.dicFldComparisonOp.Add(convCMClassFuncRela.Memo, strComparisonOp);
}
else
{
objvCMClassFuncRelaEN.dicFldComparisonOp[convCMClassFuncRela.Memo] = strComparisonOp;
}
}
return objvCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMClassFuncRelaEN SetClsName(this clsvCMClassFuncRelaEN objvCMClassFuncRelaEN, string strClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsName, 100, convCMClassFuncRela.ClsName);
}
objvCMClassFuncRelaEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(convCMClassFuncRela.ClsName) == false)
{
objvCMClassFuncRelaEN.dicFldComparisonOp.Add(convCMClassFuncRela.ClsName, strComparisonOp);
}
else
{
objvCMClassFuncRelaEN.dicFldComparisonOp[convCMClassFuncRela.ClsName] = strComparisonOp;
}
}
return objvCMClassFuncRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaENS">源对象</param>
 /// <param name = "objvCMClassFuncRelaENT">目标对象</param>
 public static void CopyTo(this clsvCMClassFuncRelaEN objvCMClassFuncRelaENS, clsvCMClassFuncRelaEN objvCMClassFuncRelaENT)
{
try
{
objvCMClassFuncRelaENT.mId = objvCMClassFuncRelaENS.mId; //mId
objvCMClassFuncRelaENT.CmClassId = objvCMClassFuncRelaENS.CmClassId; //类Id
objvCMClassFuncRelaENT.ApplicationTypeId = objvCMClassFuncRelaENS.ApplicationTypeId; //应用程序类型ID
objvCMClassFuncRelaENT.ProgLangTypeId = objvCMClassFuncRelaENS.ProgLangTypeId; //编程语言类型Id
objvCMClassFuncRelaENT.PrjId = objvCMClassFuncRelaENS.PrjId; //工程Id
objvCMClassFuncRelaENT.CmFunctionId = objvCMClassFuncRelaENS.CmFunctionId; //函数Id
objvCMClassFuncRelaENT.FunctionName = objvCMClassFuncRelaENS.FunctionName; //功能名称
objvCMClassFuncRelaENT.OrderNum = objvCMClassFuncRelaENS.OrderNum; //序号
objvCMClassFuncRelaENT.UpdDate = objvCMClassFuncRelaENS.UpdDate; //修改日期
objvCMClassFuncRelaENT.UpdUser = objvCMClassFuncRelaENS.UpdUser; //修改者
objvCMClassFuncRelaENT.Memo = objvCMClassFuncRelaENS.Memo; //说明
objvCMClassFuncRelaENT.ClsName = objvCMClassFuncRelaENS.ClsName; //类名
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
 /// <param name = "objvCMClassFuncRelaENS">源对象</param>
 /// <returns>目标对象=>clsvCMClassFuncRelaEN:objvCMClassFuncRelaENT</returns>
 public static clsvCMClassFuncRelaEN CopyTo(this clsvCMClassFuncRelaEN objvCMClassFuncRelaENS)
{
try
{
 clsvCMClassFuncRelaEN objvCMClassFuncRelaENT = new clsvCMClassFuncRelaEN()
{
mId = objvCMClassFuncRelaENS.mId, //mId
CmClassId = objvCMClassFuncRelaENS.CmClassId, //类Id
ApplicationTypeId = objvCMClassFuncRelaENS.ApplicationTypeId, //应用程序类型ID
ProgLangTypeId = objvCMClassFuncRelaENS.ProgLangTypeId, //编程语言类型Id
PrjId = objvCMClassFuncRelaENS.PrjId, //工程Id
CmFunctionId = objvCMClassFuncRelaENS.CmFunctionId, //函数Id
FunctionName = objvCMClassFuncRelaENS.FunctionName, //功能名称
OrderNum = objvCMClassFuncRelaENS.OrderNum, //序号
UpdDate = objvCMClassFuncRelaENS.UpdDate, //修改日期
UpdUser = objvCMClassFuncRelaENS.UpdUser, //修改者
Memo = objvCMClassFuncRelaENS.Memo, //说明
ClsName = objvCMClassFuncRelaENS.ClsName, //类名
};
 return objvCMClassFuncRelaENT;
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
public static void CheckProperty4Condition(this clsvCMClassFuncRelaEN objvCMClassFuncRelaEN)
{
 clsvCMClassFuncRelaBL.vCMClassFuncRelaDA.CheckProperty4Condition(objvCMClassFuncRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMClassFuncRelaEN objvCMClassFuncRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMClassFuncRelaCond.IsUpdated(convCMClassFuncRela.mId) == true)
{
string strComparisonOpmId = objvCMClassFuncRelaCond.dicFldComparisonOp[convCMClassFuncRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMClassFuncRela.mId, objvCMClassFuncRelaCond.mId, strComparisonOpmId);
}
if (objvCMClassFuncRelaCond.IsUpdated(convCMClassFuncRela.CmClassId) == true)
{
string strComparisonOpCmClassId = objvCMClassFuncRelaCond.dicFldComparisonOp[convCMClassFuncRela.CmClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClassFuncRela.CmClassId, objvCMClassFuncRelaCond.CmClassId, strComparisonOpCmClassId);
}
if (objvCMClassFuncRelaCond.IsUpdated(convCMClassFuncRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvCMClassFuncRelaCond.dicFldComparisonOp[convCMClassFuncRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMClassFuncRela.ApplicationTypeId, objvCMClassFuncRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvCMClassFuncRelaCond.IsUpdated(convCMClassFuncRela.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvCMClassFuncRelaCond.dicFldComparisonOp[convCMClassFuncRela.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClassFuncRela.ProgLangTypeId, objvCMClassFuncRelaCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvCMClassFuncRelaCond.IsUpdated(convCMClassFuncRela.PrjId) == true)
{
string strComparisonOpPrjId = objvCMClassFuncRelaCond.dicFldComparisonOp[convCMClassFuncRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClassFuncRela.PrjId, objvCMClassFuncRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvCMClassFuncRelaCond.IsUpdated(convCMClassFuncRela.CmFunctionId) == true)
{
string strComparisonOpCmFunctionId = objvCMClassFuncRelaCond.dicFldComparisonOp[convCMClassFuncRela.CmFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClassFuncRela.CmFunctionId, objvCMClassFuncRelaCond.CmFunctionId, strComparisonOpCmFunctionId);
}
if (objvCMClassFuncRelaCond.IsUpdated(convCMClassFuncRela.FunctionName) == true)
{
string strComparisonOpFunctionName = objvCMClassFuncRelaCond.dicFldComparisonOp[convCMClassFuncRela.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClassFuncRela.FunctionName, objvCMClassFuncRelaCond.FunctionName, strComparisonOpFunctionName);
}
if (objvCMClassFuncRelaCond.IsUpdated(convCMClassFuncRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCMClassFuncRelaCond.dicFldComparisonOp[convCMClassFuncRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMClassFuncRela.OrderNum, objvCMClassFuncRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCMClassFuncRelaCond.IsUpdated(convCMClassFuncRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMClassFuncRelaCond.dicFldComparisonOp[convCMClassFuncRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClassFuncRela.UpdDate, objvCMClassFuncRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMClassFuncRelaCond.IsUpdated(convCMClassFuncRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCMClassFuncRelaCond.dicFldComparisonOp[convCMClassFuncRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClassFuncRela.UpdUser, objvCMClassFuncRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCMClassFuncRelaCond.IsUpdated(convCMClassFuncRela.Memo) == true)
{
string strComparisonOpMemo = objvCMClassFuncRelaCond.dicFldComparisonOp[convCMClassFuncRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClassFuncRela.Memo, objvCMClassFuncRelaCond.Memo, strComparisonOpMemo);
}
if (objvCMClassFuncRelaCond.IsUpdated(convCMClassFuncRela.ClsName) == true)
{
string strComparisonOpClsName = objvCMClassFuncRelaCond.dicFldComparisonOp[convCMClassFuncRela.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMClassFuncRela.ClsName, objvCMClassFuncRelaCond.ClsName, strComparisonOpClsName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCMClassFuncRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCM类函数关系(vCMClassFuncRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCMClassFuncRelaBL
{
public static RelatedActions_vCMClassFuncRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCMClassFuncRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCMClassFuncRelaDA vCMClassFuncRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCMClassFuncRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCMClassFuncRelaBL()
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
if (string.IsNullOrEmpty(clsvCMClassFuncRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMClassFuncRelaEN._ConnectString);
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
public static DataTable GetDataTable_vCMClassFuncRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCMClassFuncRelaDA.GetDataTable_vCMClassFuncRela(strWhereCond);
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
objDT = vCMClassFuncRelaDA.GetDataTable(strWhereCond);
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
objDT = vCMClassFuncRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCMClassFuncRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCMClassFuncRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCMClassFuncRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vCMClassFuncRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCMClassFuncRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCMClassFuncRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvCMClassFuncRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvCMClassFuncRelaEN> arrObjLst = new List<clsvCMClassFuncRelaEN>(); 
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
	clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN();
try
{
objvCMClassFuncRelaEN.mId = Int32.Parse(objRow[convCMClassFuncRela.mId].ToString().Trim()); //mId
objvCMClassFuncRelaEN.CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objvCMClassFuncRelaEN.ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassFuncRelaEN.ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassFuncRelaEN.PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id
objvCMClassFuncRelaEN.CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMClassFuncRelaEN.FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称
objvCMClassFuncRelaEN.OrderNum = Int32.Parse(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objvCMClassFuncRelaEN.UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objvCMClassFuncRelaEN.UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objvCMClassFuncRelaEN.Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(); //说明
objvCMClassFuncRelaEN.ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassFuncRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCMClassFuncRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvCMClassFuncRelaEN._CurrTabName);
List<clsvCMClassFuncRelaEN> arrvCMClassFuncRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvCMClassFuncRelaEN> arrvCMClassFuncRelaObjLst_Sel =
arrvCMClassFuncRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvCMClassFuncRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMClassFuncRelaEN> GetObjLst(string strWhereCond)
{
List<clsvCMClassFuncRelaEN> arrObjLst = new List<clsvCMClassFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN();
try
{
objvCMClassFuncRelaEN.mId = Int32.Parse(objRow[convCMClassFuncRela.mId].ToString().Trim()); //mId
objvCMClassFuncRelaEN.CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objvCMClassFuncRelaEN.ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassFuncRelaEN.ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassFuncRelaEN.PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id
objvCMClassFuncRelaEN.CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMClassFuncRelaEN.FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称
objvCMClassFuncRelaEN.OrderNum = Int32.Parse(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objvCMClassFuncRelaEN.UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objvCMClassFuncRelaEN.UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objvCMClassFuncRelaEN.Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(); //说明
objvCMClassFuncRelaEN.ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassFuncRelaEN);
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
public static List<clsvCMClassFuncRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCMClassFuncRelaEN> arrObjLst = new List<clsvCMClassFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN();
try
{
objvCMClassFuncRelaEN.mId = Int32.Parse(objRow[convCMClassFuncRela.mId].ToString().Trim()); //mId
objvCMClassFuncRelaEN.CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objvCMClassFuncRelaEN.ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassFuncRelaEN.ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassFuncRelaEN.PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id
objvCMClassFuncRelaEN.CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMClassFuncRelaEN.FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称
objvCMClassFuncRelaEN.OrderNum = Int32.Parse(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objvCMClassFuncRelaEN.UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objvCMClassFuncRelaEN.UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objvCMClassFuncRelaEN.Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(); //说明
objvCMClassFuncRelaEN.ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassFuncRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCMClassFuncRelaEN> GetSubObjLstCache(clsvCMClassFuncRelaEN objvCMClassFuncRelaCond)
{
List<clsvCMClassFuncRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCMClassFuncRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMClassFuncRela._AttributeName)
{
if (objvCMClassFuncRelaCond.IsUpdated(strFldName) == false) continue;
if (objvCMClassFuncRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMClassFuncRelaCond[strFldName].ToString());
}
else
{
if (objvCMClassFuncRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMClassFuncRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMClassFuncRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMClassFuncRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMClassFuncRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMClassFuncRelaCond[strFldName]));
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
public static List<clsvCMClassFuncRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCMClassFuncRelaEN> arrObjLst = new List<clsvCMClassFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN();
try
{
objvCMClassFuncRelaEN.mId = Int32.Parse(objRow[convCMClassFuncRela.mId].ToString().Trim()); //mId
objvCMClassFuncRelaEN.CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objvCMClassFuncRelaEN.ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassFuncRelaEN.ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassFuncRelaEN.PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id
objvCMClassFuncRelaEN.CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMClassFuncRelaEN.FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称
objvCMClassFuncRelaEN.OrderNum = Int32.Parse(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objvCMClassFuncRelaEN.UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objvCMClassFuncRelaEN.UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objvCMClassFuncRelaEN.Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(); //说明
objvCMClassFuncRelaEN.ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassFuncRelaEN);
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
public static List<clsvCMClassFuncRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCMClassFuncRelaEN> arrObjLst = new List<clsvCMClassFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN();
try
{
objvCMClassFuncRelaEN.mId = Int32.Parse(objRow[convCMClassFuncRela.mId].ToString().Trim()); //mId
objvCMClassFuncRelaEN.CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objvCMClassFuncRelaEN.ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassFuncRelaEN.ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassFuncRelaEN.PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id
objvCMClassFuncRelaEN.CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMClassFuncRelaEN.FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称
objvCMClassFuncRelaEN.OrderNum = Int32.Parse(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objvCMClassFuncRelaEN.UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objvCMClassFuncRelaEN.UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objvCMClassFuncRelaEN.Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(); //说明
objvCMClassFuncRelaEN.ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassFuncRelaEN);
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
List<clsvCMClassFuncRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCMClassFuncRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMClassFuncRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCMClassFuncRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCMClassFuncRelaEN> arrObjLst = new List<clsvCMClassFuncRelaEN>(); 
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
	clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN();
try
{
objvCMClassFuncRelaEN.mId = Int32.Parse(objRow[convCMClassFuncRela.mId].ToString().Trim()); //mId
objvCMClassFuncRelaEN.CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objvCMClassFuncRelaEN.ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassFuncRelaEN.ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassFuncRelaEN.PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id
objvCMClassFuncRelaEN.CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMClassFuncRelaEN.FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称
objvCMClassFuncRelaEN.OrderNum = Int32.Parse(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objvCMClassFuncRelaEN.UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objvCMClassFuncRelaEN.UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objvCMClassFuncRelaEN.Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(); //说明
objvCMClassFuncRelaEN.ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassFuncRelaEN);
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
public static List<clsvCMClassFuncRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCMClassFuncRelaEN> arrObjLst = new List<clsvCMClassFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN();
try
{
objvCMClassFuncRelaEN.mId = Int32.Parse(objRow[convCMClassFuncRela.mId].ToString().Trim()); //mId
objvCMClassFuncRelaEN.CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objvCMClassFuncRelaEN.ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassFuncRelaEN.ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassFuncRelaEN.PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id
objvCMClassFuncRelaEN.CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMClassFuncRelaEN.FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称
objvCMClassFuncRelaEN.OrderNum = Int32.Parse(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objvCMClassFuncRelaEN.UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objvCMClassFuncRelaEN.UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objvCMClassFuncRelaEN.Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(); //说明
objvCMClassFuncRelaEN.ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassFuncRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCMClassFuncRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCMClassFuncRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCMClassFuncRelaEN> arrObjLst = new List<clsvCMClassFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN();
try
{
objvCMClassFuncRelaEN.mId = Int32.Parse(objRow[convCMClassFuncRela.mId].ToString().Trim()); //mId
objvCMClassFuncRelaEN.CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objvCMClassFuncRelaEN.ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassFuncRelaEN.ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassFuncRelaEN.PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id
objvCMClassFuncRelaEN.CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMClassFuncRelaEN.FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称
objvCMClassFuncRelaEN.OrderNum = Int32.Parse(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objvCMClassFuncRelaEN.UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objvCMClassFuncRelaEN.UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objvCMClassFuncRelaEN.Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(); //说明
objvCMClassFuncRelaEN.ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassFuncRelaEN);
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
public static List<clsvCMClassFuncRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCMClassFuncRelaEN> arrObjLst = new List<clsvCMClassFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN();
try
{
objvCMClassFuncRelaEN.mId = Int32.Parse(objRow[convCMClassFuncRela.mId].ToString().Trim()); //mId
objvCMClassFuncRelaEN.CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objvCMClassFuncRelaEN.ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassFuncRelaEN.ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassFuncRelaEN.PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id
objvCMClassFuncRelaEN.CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMClassFuncRelaEN.FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称
objvCMClassFuncRelaEN.OrderNum = Int32.Parse(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objvCMClassFuncRelaEN.UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objvCMClassFuncRelaEN.UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objvCMClassFuncRelaEN.Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(); //说明
objvCMClassFuncRelaEN.ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassFuncRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMClassFuncRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCMClassFuncRelaEN> arrObjLst = new List<clsvCMClassFuncRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = new clsvCMClassFuncRelaEN();
try
{
objvCMClassFuncRelaEN.mId = Int32.Parse(objRow[convCMClassFuncRela.mId].ToString().Trim()); //mId
objvCMClassFuncRelaEN.CmClassId = objRow[convCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objvCMClassFuncRelaEN.ApplicationTypeId = objRow[convCMClassFuncRela.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMClassFuncRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMClassFuncRelaEN.ProgLangTypeId = objRow[convCMClassFuncRela.ProgLangTypeId] == DBNull.Value ? null : objRow[convCMClassFuncRela.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCMClassFuncRelaEN.PrjId = objRow[convCMClassFuncRela.PrjId] == DBNull.Value ? null : objRow[convCMClassFuncRela.PrjId].ToString().Trim(); //工程Id
objvCMClassFuncRelaEN.CmFunctionId = objRow[convCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objvCMClassFuncRelaEN.FunctionName = objRow[convCMClassFuncRela.FunctionName] == DBNull.Value ? null : objRow[convCMClassFuncRela.FunctionName].ToString().Trim(); //功能名称
objvCMClassFuncRelaEN.OrderNum = Int32.Parse(objRow[convCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objvCMClassFuncRelaEN.UpdDate = objRow[convCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objvCMClassFuncRelaEN.UpdUser = objRow[convCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[convCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objvCMClassFuncRelaEN.Memo = objRow[convCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[convCMClassFuncRela.Memo].ToString().Trim(); //说明
objvCMClassFuncRelaEN.ClsName = objRow[convCMClassFuncRela.ClsName] == DBNull.Value ? null : objRow[convCMClassFuncRela.ClsName].ToString().Trim(); //类名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMClassFuncRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCMClassFuncRela(ref clsvCMClassFuncRelaEN objvCMClassFuncRelaEN)
{
bool bolResult = vCMClassFuncRelaDA.GetvCMClassFuncRela(ref objvCMClassFuncRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMClassFuncRelaEN GetObjBymId(long lngmId)
{
clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = vCMClassFuncRelaDA.GetObjBymId(lngmId);
return objvCMClassFuncRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCMClassFuncRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = vCMClassFuncRelaDA.GetFirstObj(strWhereCond);
 return objvCMClassFuncRelaEN;
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
public static clsvCMClassFuncRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = vCMClassFuncRelaDA.GetObjByDataRow(objRow);
 return objvCMClassFuncRelaEN;
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
public static clsvCMClassFuncRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCMClassFuncRelaEN objvCMClassFuncRelaEN = vCMClassFuncRelaDA.GetObjByDataRow(objRow);
 return objvCMClassFuncRelaEN;
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
 /// <param name = "lstvCMClassFuncRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMClassFuncRelaEN GetObjBymIdFromList(long lngmId, List<clsvCMClassFuncRelaEN> lstvCMClassFuncRelaObjLst)
{
foreach (clsvCMClassFuncRelaEN objvCMClassFuncRelaEN in lstvCMClassFuncRelaObjLst)
{
if (objvCMClassFuncRelaEN.mId == lngmId)
{
return objvCMClassFuncRelaEN;
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
 lngmId = new clsvCMClassFuncRelaDA().GetFirstID(strWhereCond);
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
 arrList = vCMClassFuncRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vCMClassFuncRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vCMClassFuncRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvCMClassFuncRelaDA.IsExistTable();
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
 bolIsExist = vCMClassFuncRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvCMClassFuncRelaENS">源对象</param>
 /// <param name = "objvCMClassFuncRelaENT">目标对象</param>
 public static void CopyTo(clsvCMClassFuncRelaEN objvCMClassFuncRelaENS, clsvCMClassFuncRelaEN objvCMClassFuncRelaENT)
{
try
{
objvCMClassFuncRelaENT.mId = objvCMClassFuncRelaENS.mId; //mId
objvCMClassFuncRelaENT.CmClassId = objvCMClassFuncRelaENS.CmClassId; //类Id
objvCMClassFuncRelaENT.ApplicationTypeId = objvCMClassFuncRelaENS.ApplicationTypeId; //应用程序类型ID
objvCMClassFuncRelaENT.ProgLangTypeId = objvCMClassFuncRelaENS.ProgLangTypeId; //编程语言类型Id
objvCMClassFuncRelaENT.PrjId = objvCMClassFuncRelaENS.PrjId; //工程Id
objvCMClassFuncRelaENT.CmFunctionId = objvCMClassFuncRelaENS.CmFunctionId; //函数Id
objvCMClassFuncRelaENT.FunctionName = objvCMClassFuncRelaENS.FunctionName; //功能名称
objvCMClassFuncRelaENT.OrderNum = objvCMClassFuncRelaENS.OrderNum; //序号
objvCMClassFuncRelaENT.UpdDate = objvCMClassFuncRelaENS.UpdDate; //修改日期
objvCMClassFuncRelaENT.UpdUser = objvCMClassFuncRelaENS.UpdUser; //修改者
objvCMClassFuncRelaENT.Memo = objvCMClassFuncRelaENS.Memo; //说明
objvCMClassFuncRelaENT.ClsName = objvCMClassFuncRelaENS.ClsName; //类名
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
 /// <param name = "objvCMClassFuncRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvCMClassFuncRelaEN objvCMClassFuncRelaEN)
{
try
{
objvCMClassFuncRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCMClassFuncRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCMClassFuncRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassFuncRelaEN.mId = objvCMClassFuncRelaEN.mId; //mId
}
if (arrFldSet.Contains(convCMClassFuncRela.CmClassId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassFuncRelaEN.CmClassId = objvCMClassFuncRelaEN.CmClassId; //类Id
}
if (arrFldSet.Contains(convCMClassFuncRela.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassFuncRelaEN.ApplicationTypeId = objvCMClassFuncRelaEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convCMClassFuncRela.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassFuncRelaEN.ProgLangTypeId = objvCMClassFuncRelaEN.ProgLangTypeId == "[null]" ? null :  objvCMClassFuncRelaEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convCMClassFuncRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassFuncRelaEN.PrjId = objvCMClassFuncRelaEN.PrjId == "[null]" ? null :  objvCMClassFuncRelaEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convCMClassFuncRela.CmFunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassFuncRelaEN.CmFunctionId = objvCMClassFuncRelaEN.CmFunctionId; //函数Id
}
if (arrFldSet.Contains(convCMClassFuncRela.FunctionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassFuncRelaEN.FunctionName = objvCMClassFuncRelaEN.FunctionName == "[null]" ? null :  objvCMClassFuncRelaEN.FunctionName; //功能名称
}
if (arrFldSet.Contains(convCMClassFuncRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassFuncRelaEN.OrderNum = objvCMClassFuncRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCMClassFuncRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassFuncRelaEN.UpdDate = objvCMClassFuncRelaEN.UpdDate == "[null]" ? null :  objvCMClassFuncRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCMClassFuncRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassFuncRelaEN.UpdUser = objvCMClassFuncRelaEN.UpdUser == "[null]" ? null :  objvCMClassFuncRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCMClassFuncRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassFuncRelaEN.Memo = objvCMClassFuncRelaEN.Memo == "[null]" ? null :  objvCMClassFuncRelaEN.Memo; //说明
}
if (arrFldSet.Contains(convCMClassFuncRela.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMClassFuncRelaEN.ClsName = objvCMClassFuncRelaEN.ClsName == "[null]" ? null :  objvCMClassFuncRelaEN.ClsName; //类名
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
 /// <param name = "objvCMClassFuncRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCMClassFuncRelaEN objvCMClassFuncRelaEN)
{
try
{
if (objvCMClassFuncRelaEN.ProgLangTypeId == "[null]") objvCMClassFuncRelaEN.ProgLangTypeId = null; //编程语言类型Id
if (objvCMClassFuncRelaEN.PrjId == "[null]") objvCMClassFuncRelaEN.PrjId = null; //工程Id
if (objvCMClassFuncRelaEN.FunctionName == "[null]") objvCMClassFuncRelaEN.FunctionName = null; //功能名称
if (objvCMClassFuncRelaEN.UpdDate == "[null]") objvCMClassFuncRelaEN.UpdDate = null; //修改日期
if (objvCMClassFuncRelaEN.UpdUser == "[null]") objvCMClassFuncRelaEN.UpdUser = null; //修改者
if (objvCMClassFuncRelaEN.Memo == "[null]") objvCMClassFuncRelaEN.Memo = null; //说明
if (objvCMClassFuncRelaEN.ClsName == "[null]") objvCMClassFuncRelaEN.ClsName = null; //类名
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
public static void CheckProperty4Condition(clsvCMClassFuncRelaEN objvCMClassFuncRelaEN)
{
 vCMClassFuncRelaDA.CheckProperty4Condition(objvCMClassFuncRelaEN);
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
if (clsCMClassBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMClassBL没有刷新缓存机制(clsCMClassBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMFunctionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMFunctionBL没有刷新缓存机制(clsCMFunctionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMClassFuncRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMClassFuncRelaBL没有刷新缓存机制(clsCMClassFuncRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCMClassFuncRelaObjLstCache == null)
//{
//arrvCMClassFuncRelaObjLstCache = vCMClassFuncRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMClassFuncRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCMClassFuncRelaEN._CurrTabName);
List<clsvCMClassFuncRelaEN> arrvCMClassFuncRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvCMClassFuncRelaEN> arrvCMClassFuncRelaObjLst_Sel =
arrvCMClassFuncRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvCMClassFuncRelaObjLst_Sel.Count() == 0)
{
   clsvCMClassFuncRelaEN obj = clsvCMClassFuncRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCMClassFuncRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMClassFuncRelaEN> GetAllvCMClassFuncRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvCMClassFuncRelaEN> arrvCMClassFuncRelaObjLstCache = GetObjLstCache(); 
return arrvCMClassFuncRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMClassFuncRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCMClassFuncRelaEN._CurrTabName);
List<clsvCMClassFuncRelaEN> arrvCMClassFuncRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCMClassFuncRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvCMClassFuncRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvCMClassFuncRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCMClassFuncRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvCMClassFuncRelaEN._RefreshTimeLst[clsvCMClassFuncRelaEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-08-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convCMClassFuncRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCMClassFuncRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCMClassFuncRela._AttributeName));
throw new Exception(strMsg);
}
var objvCMClassFuncRela = clsvCMClassFuncRelaBL.GetObjBymIdCache(lngmId);
if (objvCMClassFuncRela == null) return "";
return objvCMClassFuncRela[strOutFldName].ToString();
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
int intRecCount = clsvCMClassFuncRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvCMClassFuncRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCMClassFuncRelaDA.GetRecCount();
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
int intRecCount = clsvCMClassFuncRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCMClassFuncRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCMClassFuncRelaEN objvCMClassFuncRelaCond)
{
List<clsvCMClassFuncRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCMClassFuncRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMClassFuncRela._AttributeName)
{
if (objvCMClassFuncRelaCond.IsUpdated(strFldName) == false) continue;
if (objvCMClassFuncRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMClassFuncRelaCond[strFldName].ToString());
}
else
{
if (objvCMClassFuncRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMClassFuncRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMClassFuncRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMClassFuncRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMClassFuncRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMClassFuncRelaCond[strFldName]));
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
 List<string> arrList = clsvCMClassFuncRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCMClassFuncRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCMClassFuncRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数


 #region 排序相关函数


 #endregion 排序相关函数
}
}