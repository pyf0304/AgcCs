
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnFunctionBL
 表名:vDnFunction(00050553)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:28:04
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
public static class  clsvDnFunctionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDnFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDnFunctionEN GetObj(this K_DnFunctionId_vDnFunction myKey)
{
clsvDnFunctionEN objvDnFunctionEN = clsvDnFunctionBL.vDnFunctionDA.GetObjByDnFunctionId(myKey.Value);
return objvDnFunctionEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetDnFunctionId(this clsvDnFunctionEN objvDnFunctionEN, string strDnFunctionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDnFunctionId, 8, convDnFunction.DnFunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDnFunctionId, 8, convDnFunction.DnFunctionId);
}
objvDnFunctionEN.DnFunctionId = strDnFunctionId; //DN函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.DnFunctionId) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.DnFunctionId, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.DnFunctionId] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetDnFunctionName(this clsvDnFunctionEN objvDnFunctionEN, string strDnFunctionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDnFunctionName, 50, convDnFunction.DnFunctionName);
}
objvDnFunctionEN.DnFunctionName = strDnFunctionName; //DN函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.DnFunctionName) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.DnFunctionName, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.DnFunctionName] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetAssociationMappingId(this clsvDnFunctionEN objvDnFunctionEN, string strAssociationMappingId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAssociationMappingId, 2, convDnFunction.AssociationMappingId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAssociationMappingId, 2, convDnFunction.AssociationMappingId);
}
objvDnFunctionEN.AssociationMappingId = strAssociationMappingId; //关联关系映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.AssociationMappingId) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.AssociationMappingId, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.AssociationMappingId] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetAssociationMappingName(this clsvDnFunctionEN objvDnFunctionEN, string strAssociationMappingName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAssociationMappingName, 50, convDnFunction.AssociationMappingName);
}
objvDnFunctionEN.AssociationMappingName = strAssociationMappingName; //关联关系映射名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.AssociationMappingName) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.AssociationMappingName, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.AssociationMappingName] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetImportClass(this clsvDnFunctionEN objvDnFunctionEN, string strImportClass, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImportClass, 50, convDnFunction.ImportClass);
}
objvDnFunctionEN.ImportClass = strImportClass; //导入类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.ImportClass) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.ImportClass, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.ImportClass] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetImportPath(this clsvDnFunctionEN objvDnFunctionEN, string strImportPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImportPath, 100, convDnFunction.ImportPath);
}
objvDnFunctionEN.ImportPath = strImportPath; //导入路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.ImportPath) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.ImportPath, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.ImportPath] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetPrjId(this clsvDnFunctionEN objvDnFunctionEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convDnFunction.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convDnFunction.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDnFunction.PrjId);
}
objvDnFunctionEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.PrjId) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.PrjId, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.PrjId] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetUpdDate(this clsvDnFunctionEN objvDnFunctionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDnFunction.UpdDate);
}
objvDnFunctionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.UpdDate) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.UpdDate, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.UpdDate] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetUpdUser(this clsvDnFunctionEN objvDnFunctionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convDnFunction.UpdUser);
}
objvDnFunctionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.UpdUser) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.UpdUser, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.UpdUser] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDnFunctionEN SetMemo(this clsvDnFunctionEN objvDnFunctionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDnFunction.Memo);
}
objvDnFunctionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDnFunctionEN.dicFldComparisonOp.ContainsKey(convDnFunction.Memo) == false)
{
objvDnFunctionEN.dicFldComparisonOp.Add(convDnFunction.Memo, strComparisonOp);
}
else
{
objvDnFunctionEN.dicFldComparisonOp[convDnFunction.Memo] = strComparisonOp;
}
}
return objvDnFunctionEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvDnFunctionENS">源对象</param>
 /// <param name = "objvDnFunctionENT">目标对象</param>
 public static void CopyTo(this clsvDnFunctionEN objvDnFunctionENS, clsvDnFunctionEN objvDnFunctionENT)
{
try
{
objvDnFunctionENT.DnFunctionId = objvDnFunctionENS.DnFunctionId; //DN函数Id
objvDnFunctionENT.DnFunctionName = objvDnFunctionENS.DnFunctionName; //DN函数
objvDnFunctionENT.AssociationMappingId = objvDnFunctionENS.AssociationMappingId; //关联关系映射Id
objvDnFunctionENT.AssociationMappingName = objvDnFunctionENS.AssociationMappingName; //关联关系映射名
objvDnFunctionENT.ImportClass = objvDnFunctionENS.ImportClass; //导入类
objvDnFunctionENT.ImportPath = objvDnFunctionENS.ImportPath; //导入路径
objvDnFunctionENT.PrjId = objvDnFunctionENS.PrjId; //工程Id
objvDnFunctionENT.UpdDate = objvDnFunctionENS.UpdDate; //修改日期
objvDnFunctionENT.UpdUser = objvDnFunctionENS.UpdUser; //修改者
objvDnFunctionENT.Memo = objvDnFunctionENS.Memo; //说明
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
 /// <param name = "objvDnFunctionENS">源对象</param>
 /// <returns>目标对象=>clsvDnFunctionEN:objvDnFunctionENT</returns>
 public static clsvDnFunctionEN CopyTo(this clsvDnFunctionEN objvDnFunctionENS)
{
try
{
 clsvDnFunctionEN objvDnFunctionENT = new clsvDnFunctionEN()
{
DnFunctionId = objvDnFunctionENS.DnFunctionId, //DN函数Id
DnFunctionName = objvDnFunctionENS.DnFunctionName, //DN函数
AssociationMappingId = objvDnFunctionENS.AssociationMappingId, //关联关系映射Id
AssociationMappingName = objvDnFunctionENS.AssociationMappingName, //关联关系映射名
ImportClass = objvDnFunctionENS.ImportClass, //导入类
ImportPath = objvDnFunctionENS.ImportPath, //导入路径
PrjId = objvDnFunctionENS.PrjId, //工程Id
UpdDate = objvDnFunctionENS.UpdDate, //修改日期
UpdUser = objvDnFunctionENS.UpdUser, //修改者
Memo = objvDnFunctionENS.Memo, //说明
};
 return objvDnFunctionENT;
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
public static void CheckProperty4Condition(this clsvDnFunctionEN objvDnFunctionEN)
{
 clsvDnFunctionBL.vDnFunctionDA.CheckProperty4Condition(objvDnFunctionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDnFunctionEN objvDnFunctionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDnFunctionCond.IsUpdated(convDnFunction.DnFunctionId) == true)
{
string strComparisonOpDnFunctionId = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.DnFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.DnFunctionId, objvDnFunctionCond.DnFunctionId, strComparisonOpDnFunctionId);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.DnFunctionName) == true)
{
string strComparisonOpDnFunctionName = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.DnFunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.DnFunctionName, objvDnFunctionCond.DnFunctionName, strComparisonOpDnFunctionName);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.AssociationMappingId) == true)
{
string strComparisonOpAssociationMappingId = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.AssociationMappingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.AssociationMappingId, objvDnFunctionCond.AssociationMappingId, strComparisonOpAssociationMappingId);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.AssociationMappingName) == true)
{
string strComparisonOpAssociationMappingName = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.AssociationMappingName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.AssociationMappingName, objvDnFunctionCond.AssociationMappingName, strComparisonOpAssociationMappingName);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.ImportClass) == true)
{
string strComparisonOpImportClass = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.ImportClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.ImportClass, objvDnFunctionCond.ImportClass, strComparisonOpImportClass);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.ImportPath) == true)
{
string strComparisonOpImportPath = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.ImportPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.ImportPath, objvDnFunctionCond.ImportPath, strComparisonOpImportPath);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.PrjId) == true)
{
string strComparisonOpPrjId = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.PrjId, objvDnFunctionCond.PrjId, strComparisonOpPrjId);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.UpdDate) == true)
{
string strComparisonOpUpdDate = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.UpdDate, objvDnFunctionCond.UpdDate, strComparisonOpUpdDate);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.UpdUser) == true)
{
string strComparisonOpUpdUser = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.UpdUser, objvDnFunctionCond.UpdUser, strComparisonOpUpdUser);
}
if (objvDnFunctionCond.IsUpdated(convDnFunction.Memo) == true)
{
string strComparisonOpMemo = objvDnFunctionCond.dicFldComparisonOp[convDnFunction.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDnFunction.Memo, objvDnFunctionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vDnFunction(vDnFunction), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:DNFunctionName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvDnFunctionEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvDnFunctionEN objvDnFunctionEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvDnFunctionEN == null) return true;
if (objvDnFunctionEN.DnFunctionId == null || objvDnFunctionEN.DnFunctionId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objvDnFunctionEN.DnFunctionName == null)
{
 sbCondition.AppendFormat(" and DnFunctionName is null", objvDnFunctionEN.DnFunctionName);
}
else
{
 sbCondition.AppendFormat(" and DnFunctionName = '{0}'", objvDnFunctionEN.DnFunctionName);
}
 sbCondition.AppendFormat(" and PrjId = '{0}'", objvDnFunctionEN.PrjId);
if (clsvDnFunctionBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("DnFunctionId !=  '{0}'", objvDnFunctionEN.DnFunctionId);
 sbCondition.AppendFormat(" and DnFunctionName = '{0}'", objvDnFunctionEN.DnFunctionName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objvDnFunctionEN.PrjId);
if (clsvDnFunctionBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--vDnFunction(vDnFunction), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DNFunctionName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvDnFunctionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvDnFunctionEN objvDnFunctionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvDnFunctionEN == null) return "";
if (objvDnFunctionEN.DnFunctionId == null || objvDnFunctionEN.DnFunctionId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objvDnFunctionEN.DnFunctionName == null)
{
 sbCondition.AppendFormat(" and DnFunctionName is null", objvDnFunctionEN.DnFunctionName);
}
else
{
 sbCondition.AppendFormat(" and DnFunctionName = '{0}'", objvDnFunctionEN.DnFunctionName);
}
 sbCondition.AppendFormat(" and PrjId = '{0}'", objvDnFunctionEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DnFunctionId !=  '{0}'", objvDnFunctionEN.DnFunctionId);
 sbCondition.AppendFormat(" and DnFunctionName = '{0}'", objvDnFunctionEN.DnFunctionName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objvDnFunctionEN.PrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vDnFunction
{
public virtual bool UpdRelaTabDate(string strDnFunctionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vDnFunction(vDnFunction)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvDnFunctionBL
{
public static RelatedActions_vDnFunction relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvDnFunctionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvDnFunctionDA vDnFunctionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvDnFunctionDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvDnFunctionBL()
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
if (string.IsNullOrEmpty(clsvDnFunctionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDnFunctionEN._ConnectString);
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
public static DataTable GetDataTable_vDnFunction(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vDnFunctionDA.GetDataTable_vDnFunction(strWhereCond);
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
objDT = vDnFunctionDA.GetDataTable(strWhereCond);
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
objDT = vDnFunctionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vDnFunctionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vDnFunctionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vDnFunctionDA.GetDataTable_Top(objTopPara);
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
objDT = vDnFunctionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vDnFunctionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vDnFunctionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDnFunctionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvDnFunctionEN> GetObjLstByDnFunctionIdLst(List<string> arrDnFunctionIdLst)
{
List<clsvDnFunctionEN> arrObjLst = new List<clsvDnFunctionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDnFunctionIdLst, true);
 string strWhereCond = string.Format("DnFunctionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN();
try
{
objvDnFunctionEN.DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFunctionEN.DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objvDnFunctionEN.AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFunctionEN.AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFunctionEN.ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(); //导入类
objvDnFunctionEN.ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(); //导入路径
objvDnFunctionEN.PrjId = objRow[convDnFunction.PrjId].ToString().Trim(); //工程Id
objvDnFunctionEN.UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(); //修改日期
objvDnFunctionEN.UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(); //修改者
objvDnFunctionEN.Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFunctionEN.DnFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDnFunctionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvDnFunctionEN> GetObjLstByDnFunctionIdLstCache(List<string> arrDnFunctionIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvDnFunctionEN._CurrTabName, strPrjId);
List<clsvDnFunctionEN> arrvDnFunctionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFunctionEN> arrvDnFunctionObjLst_Sel =
arrvDnFunctionObjLstCache
.Where(x => arrDnFunctionIdLst.Contains(x.DnFunctionId));
return arrvDnFunctionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFunctionEN> GetObjLst(string strWhereCond)
{
List<clsvDnFunctionEN> arrObjLst = new List<clsvDnFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN();
try
{
objvDnFunctionEN.DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFunctionEN.DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objvDnFunctionEN.AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFunctionEN.AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFunctionEN.ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(); //导入类
objvDnFunctionEN.ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(); //导入路径
objvDnFunctionEN.PrjId = objRow[convDnFunction.PrjId].ToString().Trim(); //工程Id
objvDnFunctionEN.UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(); //修改日期
objvDnFunctionEN.UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(); //修改者
objvDnFunctionEN.Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFunctionEN.DnFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFunctionEN);
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
public static List<clsvDnFunctionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvDnFunctionEN> arrObjLst = new List<clsvDnFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN();
try
{
objvDnFunctionEN.DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFunctionEN.DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objvDnFunctionEN.AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFunctionEN.AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFunctionEN.ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(); //导入类
objvDnFunctionEN.ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(); //导入路径
objvDnFunctionEN.PrjId = objRow[convDnFunction.PrjId].ToString().Trim(); //工程Id
objvDnFunctionEN.UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(); //修改日期
objvDnFunctionEN.UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(); //修改者
objvDnFunctionEN.Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFunctionEN.DnFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvDnFunctionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvDnFunctionEN> GetSubObjLstCache(clsvDnFunctionEN objvDnFunctionCond)
{
 string strPrjId = objvDnFunctionCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvDnFunctionBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvDnFunctionEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFunctionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDnFunction._AttributeName)
{
if (objvDnFunctionCond.IsUpdated(strFldName) == false) continue;
if (objvDnFunctionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDnFunctionCond[strFldName].ToString());
}
else
{
if (objvDnFunctionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDnFunctionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDnFunctionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDnFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDnFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDnFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDnFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDnFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDnFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDnFunctionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDnFunctionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDnFunctionCond[strFldName]));
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
public static List<clsvDnFunctionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvDnFunctionEN> arrObjLst = new List<clsvDnFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN();
try
{
objvDnFunctionEN.DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFunctionEN.DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objvDnFunctionEN.AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFunctionEN.AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFunctionEN.ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(); //导入类
objvDnFunctionEN.ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(); //导入路径
objvDnFunctionEN.PrjId = objRow[convDnFunction.PrjId].ToString().Trim(); //工程Id
objvDnFunctionEN.UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(); //修改日期
objvDnFunctionEN.UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(); //修改者
objvDnFunctionEN.Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFunctionEN.DnFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFunctionEN);
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
public static List<clsvDnFunctionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvDnFunctionEN> arrObjLst = new List<clsvDnFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN();
try
{
objvDnFunctionEN.DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFunctionEN.DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objvDnFunctionEN.AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFunctionEN.AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFunctionEN.ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(); //导入类
objvDnFunctionEN.ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(); //导入路径
objvDnFunctionEN.PrjId = objRow[convDnFunction.PrjId].ToString().Trim(); //工程Id
objvDnFunctionEN.UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(); //修改日期
objvDnFunctionEN.UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(); //修改者
objvDnFunctionEN.Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFunctionEN.DnFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFunctionEN);
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
List<clsvDnFunctionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvDnFunctionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFunctionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvDnFunctionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvDnFunctionEN> arrObjLst = new List<clsvDnFunctionEN>(); 
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
	clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN();
try
{
objvDnFunctionEN.DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFunctionEN.DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objvDnFunctionEN.AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFunctionEN.AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFunctionEN.ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(); //导入类
objvDnFunctionEN.ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(); //导入路径
objvDnFunctionEN.PrjId = objRow[convDnFunction.PrjId].ToString().Trim(); //工程Id
objvDnFunctionEN.UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(); //修改日期
objvDnFunctionEN.UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(); //修改者
objvDnFunctionEN.Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFunctionEN.DnFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFunctionEN);
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
public static List<clsvDnFunctionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvDnFunctionEN> arrObjLst = new List<clsvDnFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN();
try
{
objvDnFunctionEN.DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFunctionEN.DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objvDnFunctionEN.AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFunctionEN.AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFunctionEN.ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(); //导入类
objvDnFunctionEN.ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(); //导入路径
objvDnFunctionEN.PrjId = objRow[convDnFunction.PrjId].ToString().Trim(); //工程Id
objvDnFunctionEN.UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(); //修改日期
objvDnFunctionEN.UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(); //修改者
objvDnFunctionEN.Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFunctionEN.DnFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvDnFunctionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvDnFunctionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvDnFunctionEN> arrObjLst = new List<clsvDnFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN();
try
{
objvDnFunctionEN.DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFunctionEN.DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objvDnFunctionEN.AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFunctionEN.AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFunctionEN.ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(); //导入类
objvDnFunctionEN.ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(); //导入路径
objvDnFunctionEN.PrjId = objRow[convDnFunction.PrjId].ToString().Trim(); //工程Id
objvDnFunctionEN.UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(); //修改日期
objvDnFunctionEN.UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(); //修改者
objvDnFunctionEN.Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFunctionEN.DnFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFunctionEN);
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
public static List<clsvDnFunctionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvDnFunctionEN> arrObjLst = new List<clsvDnFunctionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN();
try
{
objvDnFunctionEN.DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFunctionEN.DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objvDnFunctionEN.AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFunctionEN.AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFunctionEN.ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(); //导入类
objvDnFunctionEN.ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(); //导入路径
objvDnFunctionEN.PrjId = objRow[convDnFunction.PrjId].ToString().Trim(); //工程Id
objvDnFunctionEN.UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(); //修改日期
objvDnFunctionEN.UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(); //修改者
objvDnFunctionEN.Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFunctionEN.DnFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDnFunctionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvDnFunctionEN> arrObjLst = new List<clsvDnFunctionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFunctionEN objvDnFunctionEN = new clsvDnFunctionEN();
try
{
objvDnFunctionEN.DnFunctionId = objRow[convDnFunction.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFunctionEN.DnFunctionName = objRow[convDnFunction.DnFunctionName] == DBNull.Value ? null : objRow[convDnFunction.DnFunctionName].ToString().Trim(); //DN函数
objvDnFunctionEN.AssociationMappingId = objRow[convDnFunction.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFunctionEN.AssociationMappingName = objRow[convDnFunction.AssociationMappingName] == DBNull.Value ? null : objRow[convDnFunction.AssociationMappingName].ToString().Trim(); //关联关系映射名
objvDnFunctionEN.ImportClass = objRow[convDnFunction.ImportClass] == DBNull.Value ? null : objRow[convDnFunction.ImportClass].ToString().Trim(); //导入类
objvDnFunctionEN.ImportPath = objRow[convDnFunction.ImportPath] == DBNull.Value ? null : objRow[convDnFunction.ImportPath].ToString().Trim(); //导入路径
objvDnFunctionEN.PrjId = objRow[convDnFunction.PrjId].ToString().Trim(); //工程Id
objvDnFunctionEN.UpdDate = objRow[convDnFunction.UpdDate] == DBNull.Value ? null : objRow[convDnFunction.UpdDate].ToString().Trim(); //修改日期
objvDnFunctionEN.UpdUser = objRow[convDnFunction.UpdUser] == DBNull.Value ? null : objRow[convDnFunction.UpdUser].ToString().Trim(); //修改者
objvDnFunctionEN.Memo = objRow[convDnFunction.Memo] == DBNull.Value ? null : objRow[convDnFunction.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDnFunctionEN.DnFunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDnFunctionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvDnFunctionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvDnFunction(ref clsvDnFunctionEN objvDnFunctionEN)
{
bool bolResult = vDnFunctionDA.GetvDnFunction(ref objvDnFunctionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDnFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDnFunctionEN GetObjByDnFunctionId(string strDnFunctionId)
{
if (strDnFunctionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDnFunctionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDnFunctionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDnFunctionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvDnFunctionEN objvDnFunctionEN = vDnFunctionDA.GetObjByDnFunctionId(strDnFunctionId);
return objvDnFunctionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvDnFunctionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvDnFunctionEN objvDnFunctionEN = vDnFunctionDA.GetFirstObj(strWhereCond);
 return objvDnFunctionEN;
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
public static clsvDnFunctionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvDnFunctionEN objvDnFunctionEN = vDnFunctionDA.GetObjByDataRow(objRow);
 return objvDnFunctionEN;
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
public static clsvDnFunctionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvDnFunctionEN objvDnFunctionEN = vDnFunctionDA.GetObjByDataRow(objRow);
 return objvDnFunctionEN;
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
 /// <param name = "strDnFunctionId">所给的关键字</param>
 /// <param name = "lstvDnFunctionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDnFunctionEN GetObjByDnFunctionIdFromList(string strDnFunctionId, List<clsvDnFunctionEN> lstvDnFunctionObjLst)
{
foreach (clsvDnFunctionEN objvDnFunctionEN in lstvDnFunctionObjLst)
{
if (objvDnFunctionEN.DnFunctionId == strDnFunctionId)
{
return objvDnFunctionEN;
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
 string strDnFunctionId;
 try
 {
 strDnFunctionId = new clsvDnFunctionDA().GetFirstID(strWhereCond);
 return strDnFunctionId;
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
 arrList = vDnFunctionDA.GetID(strWhereCond);
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
bool bolIsExist = vDnFunctionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDnFunctionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDnFunctionId)
{
if (string.IsNullOrEmpty(strDnFunctionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDnFunctionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vDnFunctionDA.IsExist(strDnFunctionId);
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
 bolIsExist = clsvDnFunctionDA.IsExistTable();
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
 bolIsExist = vDnFunctionDA.IsExistTable(strTabName);
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
 /// <param name = "objvDnFunctionENS">源对象</param>
 /// <param name = "objvDnFunctionENT">目标对象</param>
 public static void CopyTo(clsvDnFunctionEN objvDnFunctionENS, clsvDnFunctionEN objvDnFunctionENT)
{
try
{
objvDnFunctionENT.DnFunctionId = objvDnFunctionENS.DnFunctionId; //DN函数Id
objvDnFunctionENT.DnFunctionName = objvDnFunctionENS.DnFunctionName; //DN函数
objvDnFunctionENT.AssociationMappingId = objvDnFunctionENS.AssociationMappingId; //关联关系映射Id
objvDnFunctionENT.AssociationMappingName = objvDnFunctionENS.AssociationMappingName; //关联关系映射名
objvDnFunctionENT.ImportClass = objvDnFunctionENS.ImportClass; //导入类
objvDnFunctionENT.ImportPath = objvDnFunctionENS.ImportPath; //导入路径
objvDnFunctionENT.PrjId = objvDnFunctionENS.PrjId; //工程Id
objvDnFunctionENT.UpdDate = objvDnFunctionENS.UpdDate; //修改日期
objvDnFunctionENT.UpdUser = objvDnFunctionENS.UpdUser; //修改者
objvDnFunctionENT.Memo = objvDnFunctionENS.Memo; //说明
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
 /// <param name = "objvDnFunctionEN">源简化对象</param>
 public static void SetUpdFlag(clsvDnFunctionEN objvDnFunctionEN)
{
try
{
objvDnFunctionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvDnFunctionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convDnFunction.DnFunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFunctionEN.DnFunctionId = objvDnFunctionEN.DnFunctionId; //DN函数Id
}
if (arrFldSet.Contains(convDnFunction.DnFunctionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFunctionEN.DnFunctionName = objvDnFunctionEN.DnFunctionName == "[null]" ? null :  objvDnFunctionEN.DnFunctionName; //DN函数
}
if (arrFldSet.Contains(convDnFunction.AssociationMappingId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFunctionEN.AssociationMappingId = objvDnFunctionEN.AssociationMappingId == "[null]" ? null :  objvDnFunctionEN.AssociationMappingId; //关联关系映射Id
}
if (arrFldSet.Contains(convDnFunction.AssociationMappingName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFunctionEN.AssociationMappingName = objvDnFunctionEN.AssociationMappingName == "[null]" ? null :  objvDnFunctionEN.AssociationMappingName; //关联关系映射名
}
if (arrFldSet.Contains(convDnFunction.ImportClass, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFunctionEN.ImportClass = objvDnFunctionEN.ImportClass == "[null]" ? null :  objvDnFunctionEN.ImportClass; //导入类
}
if (arrFldSet.Contains(convDnFunction.ImportPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFunctionEN.ImportPath = objvDnFunctionEN.ImportPath == "[null]" ? null :  objvDnFunctionEN.ImportPath; //导入路径
}
if (arrFldSet.Contains(convDnFunction.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFunctionEN.PrjId = objvDnFunctionEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convDnFunction.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFunctionEN.UpdDate = objvDnFunctionEN.UpdDate == "[null]" ? null :  objvDnFunctionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convDnFunction.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFunctionEN.UpdUser = objvDnFunctionEN.UpdUser == "[null]" ? null :  objvDnFunctionEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convDnFunction.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvDnFunctionEN.Memo = objvDnFunctionEN.Memo == "[null]" ? null :  objvDnFunctionEN.Memo; //说明
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
 /// <param name = "objvDnFunctionEN">源简化对象</param>
 public static void AccessFldValueNull(clsvDnFunctionEN objvDnFunctionEN)
{
try
{
if (objvDnFunctionEN.DnFunctionName == "[null]") objvDnFunctionEN.DnFunctionName = null; //DN函数
if (objvDnFunctionEN.AssociationMappingId == "[null]") objvDnFunctionEN.AssociationMappingId = null; //关联关系映射Id
if (objvDnFunctionEN.AssociationMappingName == "[null]") objvDnFunctionEN.AssociationMappingName = null; //关联关系映射名
if (objvDnFunctionEN.ImportClass == "[null]") objvDnFunctionEN.ImportClass = null; //导入类
if (objvDnFunctionEN.ImportPath == "[null]") objvDnFunctionEN.ImportPath = null; //导入路径
if (objvDnFunctionEN.UpdDate == "[null]") objvDnFunctionEN.UpdDate = null; //修改日期
if (objvDnFunctionEN.UpdUser == "[null]") objvDnFunctionEN.UpdUser = null; //修改者
if (objvDnFunctionEN.Memo == "[null]") objvDnFunctionEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvDnFunctionEN objvDnFunctionEN)
{
 vDnFunctionDA.CheckProperty4Condition(objvDnFunctionEN);
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
if (clsAssociationMappingBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAssociationMappingBL没有刷新缓存机制(clsAssociationMappingBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDnFunctionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDnFunctionBL没有刷新缓存机制(clsDnFunctionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DnFunctionId");
//if (arrvDnFunctionObjLstCache == null)
//{
//arrvDnFunctionObjLstCache = vDnFunctionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDnFunctionId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDnFunctionEN GetObjByDnFunctionIdCache(string strDnFunctionId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvDnFunctionEN._CurrTabName, strPrjId);
List<clsvDnFunctionEN> arrvDnFunctionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFunctionEN> arrvDnFunctionObjLst_Sel =
arrvDnFunctionObjLstCache
.Where(x=> x.DnFunctionId == strDnFunctionId 
);
if (arrvDnFunctionObjLst_Sel.Count() == 0)
{
   clsvDnFunctionEN obj = clsvDnFunctionBL.GetObjByDnFunctionId(strDnFunctionId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strDnFunctionId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvDnFunctionObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDnFunctionEN> GetAllvDnFunctionObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvDnFunctionEN> arrvDnFunctionObjLstCache = GetObjLstCache(strPrjId); 
return arrvDnFunctionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDnFunctionEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvDnFunctionEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvDnFunctionEN> arrvDnFunctionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvDnFunctionObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvDnFunctionEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvDnFunctionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvDnFunctionEN._RefreshTimeLst.Count == 0) return "";
return clsvDnFunctionEN._RefreshTimeLst[clsvDnFunctionEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vDnFunction(vDnFunction)
 /// 唯一性条件:DNFunctionName_PrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvDnFunctionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvDnFunctionEN objvDnFunctionEN)
{
//检测记录是否存在
string strResult = vDnFunctionDA.GetUniCondStr(objvDnFunctionEN);
return strResult;
}


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
public static string Func(string strInFldName, string strOutFldName, string strDnFunctionId, string strPrjId)
{
if (strInFldName != convDnFunction.DnFunctionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convDnFunction._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convDnFunction._AttributeName));
throw new Exception(strMsg);
}
var objvDnFunction = clsvDnFunctionBL.GetObjByDnFunctionIdCache(strDnFunctionId, strPrjId);
if (objvDnFunction == null) return "";
return objvDnFunction[strOutFldName].ToString();
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
int intRecCount = clsvDnFunctionDA.GetRecCount(strTabName);
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
int intRecCount = clsvDnFunctionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvDnFunctionDA.GetRecCount();
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
int intRecCount = clsvDnFunctionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvDnFunctionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvDnFunctionEN objvDnFunctionCond)
{
 string strPrjId = objvDnFunctionCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvDnFunctionBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvDnFunctionEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDnFunctionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDnFunction._AttributeName)
{
if (objvDnFunctionCond.IsUpdated(strFldName) == false) continue;
if (objvDnFunctionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDnFunctionCond[strFldName].ToString());
}
else
{
if (objvDnFunctionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDnFunctionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDnFunctionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDnFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDnFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDnFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDnFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDnFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDnFunctionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDnFunctionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDnFunctionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDnFunctionCond[strFldName]));
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
 List<string> arrList = clsvDnFunctionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vDnFunctionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vDnFunctionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}