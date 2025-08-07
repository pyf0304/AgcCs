
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDnFunctionWApi
 表名:DnFunction(00050552)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:17
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
public static class  clsDnFunctionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnFunctionId">DN函数Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFunctionEN SetDnFunctionId(this clsDnFunctionEN objDnFunctionEN, string strDnFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnFunctionId, 8, conDnFunction.DnFunctionId);
clsCheckSql.CheckFieldForeignKey(strDnFunctionId, 8, conDnFunction.DnFunctionId);
objDnFunctionEN.DnFunctionId = strDnFunctionId; //DN函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFunctionEN.dicFldComparisonOp.ContainsKey(conDnFunction.DnFunctionId) == false)
{
objDnFunctionEN.dicFldComparisonOp.Add(conDnFunction.DnFunctionId, strComparisonOp);
}
else
{
objDnFunctionEN.dicFldComparisonOp[conDnFunction.DnFunctionId] = strComparisonOp;
}
}
return objDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnFunctionName">DN函数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFunctionEN SetDnFunctionName(this clsDnFunctionEN objDnFunctionEN, string strDnFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnFunctionName, 50, conDnFunction.DnFunctionName);
objDnFunctionEN.DnFunctionName = strDnFunctionName; //DN函数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFunctionEN.dicFldComparisonOp.ContainsKey(conDnFunction.DnFunctionName) == false)
{
objDnFunctionEN.dicFldComparisonOp.Add(conDnFunction.DnFunctionName, strComparisonOp);
}
else
{
objDnFunctionEN.dicFldComparisonOp[conDnFunction.DnFunctionName] = strComparisonOp;
}
}
return objDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strAssociationMappingId">关联关系映射Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFunctionEN SetAssociationMappingId(this clsDnFunctionEN objDnFunctionEN, string strAssociationMappingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAssociationMappingId, conDnFunction.AssociationMappingId);
clsCheckSql.CheckFieldLen(strAssociationMappingId, 2, conDnFunction.AssociationMappingId);
clsCheckSql.CheckFieldForeignKey(strAssociationMappingId, 2, conDnFunction.AssociationMappingId);
objDnFunctionEN.AssociationMappingId = strAssociationMappingId; //关联关系映射Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFunctionEN.dicFldComparisonOp.ContainsKey(conDnFunction.AssociationMappingId) == false)
{
objDnFunctionEN.dicFldComparisonOp.Add(conDnFunction.AssociationMappingId, strComparisonOp);
}
else
{
objDnFunctionEN.dicFldComparisonOp[conDnFunction.AssociationMappingId] = strComparisonOp;
}
}
return objDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strImportClass">导入类</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFunctionEN SetImportClass(this clsDnFunctionEN objDnFunctionEN, string strImportClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImportClass, 50, conDnFunction.ImportClass);
objDnFunctionEN.ImportClass = strImportClass; //导入类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFunctionEN.dicFldComparisonOp.ContainsKey(conDnFunction.ImportClass) == false)
{
objDnFunctionEN.dicFldComparisonOp.Add(conDnFunction.ImportClass, strComparisonOp);
}
else
{
objDnFunctionEN.dicFldComparisonOp[conDnFunction.ImportClass] = strComparisonOp;
}
}
return objDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strImportPath">导入路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFunctionEN SetImportPath(this clsDnFunctionEN objDnFunctionEN, string strImportPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImportPath, 100, conDnFunction.ImportPath);
objDnFunctionEN.ImportPath = strImportPath; //导入路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFunctionEN.dicFldComparisonOp.ContainsKey(conDnFunction.ImportPath) == false)
{
objDnFunctionEN.dicFldComparisonOp.Add(conDnFunction.ImportPath, strComparisonOp);
}
else
{
objDnFunctionEN.dicFldComparisonOp[conDnFunction.ImportPath] = strComparisonOp;
}
}
return objDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFunctionEN SetPrjId(this clsDnFunctionEN objDnFunctionEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conDnFunction.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conDnFunction.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conDnFunction.PrjId);
objDnFunctionEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFunctionEN.dicFldComparisonOp.ContainsKey(conDnFunction.PrjId) == false)
{
objDnFunctionEN.dicFldComparisonOp.Add(conDnFunction.PrjId, strComparisonOp);
}
else
{
objDnFunctionEN.dicFldComparisonOp[conDnFunction.PrjId] = strComparisonOp;
}
}
return objDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFunctionEN SetUpdDate(this clsDnFunctionEN objDnFunctionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDnFunction.UpdDate);
objDnFunctionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFunctionEN.dicFldComparisonOp.ContainsKey(conDnFunction.UpdDate) == false)
{
objDnFunctionEN.dicFldComparisonOp.Add(conDnFunction.UpdDate, strComparisonOp);
}
else
{
objDnFunctionEN.dicFldComparisonOp[conDnFunction.UpdDate] = strComparisonOp;
}
}
return objDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFunctionEN SetUpdUser(this clsDnFunctionEN objDnFunctionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDnFunction.UpdUser);
objDnFunctionEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFunctionEN.dicFldComparisonOp.ContainsKey(conDnFunction.UpdUser) == false)
{
objDnFunctionEN.dicFldComparisonOp.Add(conDnFunction.UpdUser, strComparisonOp);
}
else
{
objDnFunctionEN.dicFldComparisonOp[conDnFunction.UpdUser] = strComparisonOp;
}
}
return objDnFunctionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDnFunctionEN SetMemo(this clsDnFunctionEN objDnFunctionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDnFunction.Memo);
objDnFunctionEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDnFunctionEN.dicFldComparisonOp.ContainsKey(conDnFunction.Memo) == false)
{
objDnFunctionEN.dicFldComparisonOp.Add(conDnFunction.Memo, strComparisonOp);
}
else
{
objDnFunctionEN.dicFldComparisonOp[conDnFunction.Memo] = strComparisonOp;
}
}
return objDnFunctionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDnFunctionEN objDnFunctionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDnFunctionCond.IsUpdated(conDnFunction.DnFunctionId) == true)
{
string strComparisonOpDnFunctionId = objDnFunctionCond.dicFldComparisonOp[conDnFunction.DnFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFunction.DnFunctionId, objDnFunctionCond.DnFunctionId, strComparisonOpDnFunctionId);
}
if (objDnFunctionCond.IsUpdated(conDnFunction.DnFunctionName) == true)
{
string strComparisonOpDnFunctionName = objDnFunctionCond.dicFldComparisonOp[conDnFunction.DnFunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFunction.DnFunctionName, objDnFunctionCond.DnFunctionName, strComparisonOpDnFunctionName);
}
if (objDnFunctionCond.IsUpdated(conDnFunction.AssociationMappingId) == true)
{
string strComparisonOpAssociationMappingId = objDnFunctionCond.dicFldComparisonOp[conDnFunction.AssociationMappingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFunction.AssociationMappingId, objDnFunctionCond.AssociationMappingId, strComparisonOpAssociationMappingId);
}
if (objDnFunctionCond.IsUpdated(conDnFunction.ImportClass) == true)
{
string strComparisonOpImportClass = objDnFunctionCond.dicFldComparisonOp[conDnFunction.ImportClass];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFunction.ImportClass, objDnFunctionCond.ImportClass, strComparisonOpImportClass);
}
if (objDnFunctionCond.IsUpdated(conDnFunction.ImportPath) == true)
{
string strComparisonOpImportPath = objDnFunctionCond.dicFldComparisonOp[conDnFunction.ImportPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFunction.ImportPath, objDnFunctionCond.ImportPath, strComparisonOpImportPath);
}
if (objDnFunctionCond.IsUpdated(conDnFunction.PrjId) == true)
{
string strComparisonOpPrjId = objDnFunctionCond.dicFldComparisonOp[conDnFunction.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFunction.PrjId, objDnFunctionCond.PrjId, strComparisonOpPrjId);
}
if (objDnFunctionCond.IsUpdated(conDnFunction.UpdDate) == true)
{
string strComparisonOpUpdDate = objDnFunctionCond.dicFldComparisonOp[conDnFunction.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFunction.UpdDate, objDnFunctionCond.UpdDate, strComparisonOpUpdDate);
}
if (objDnFunctionCond.IsUpdated(conDnFunction.UpdUser) == true)
{
string strComparisonOpUpdUser = objDnFunctionCond.dicFldComparisonOp[conDnFunction.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFunction.UpdUser, objDnFunctionCond.UpdUser, strComparisonOpUpdUser);
}
if (objDnFunctionCond.IsUpdated(conDnFunction.Memo) == true)
{
string strComparisonOpMemo = objDnFunctionCond.dicFldComparisonOp[conDnFunction.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDnFunction.Memo, objDnFunctionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDnFunctionEN objDnFunctionEN)
{
 if (string.IsNullOrEmpty(objDnFunctionEN.DnFunctionId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDnFunctionEN.sfUpdFldSetStr = objDnFunctionEN.getsfUpdFldSetStr();
clsDnFunctionWApi.CheckPropertyNew(objDnFunctionEN); 
bool bolResult = clsDnFunctionWApi.UpdateRecord(objDnFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFunctionWApi.ReFreshCache(objDnFunctionEN.PrjId);
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
 /// 获取唯一性条件串--DnFunction(数据结点函数), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DNFunctionName_PrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDnFunctionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsDnFunctionEN objDnFunctionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDnFunctionEN == null) return "";
if (objDnFunctionEN.DnFunctionId == null || objDnFunctionEN.DnFunctionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DnFunctionName = '{0}'", objDnFunctionEN.DnFunctionName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objDnFunctionEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DnFunctionId !=  '{0}'", objDnFunctionEN.DnFunctionId);
 sbCondition.AppendFormat(" and DnFunctionName = '{0}'", objDnFunctionEN.DnFunctionName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objDnFunctionEN.PrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDnFunctionEN objDnFunctionEN)
{
try
{
 if (string.IsNullOrEmpty(objDnFunctionEN.DnFunctionId) == true || clsDnFunctionWApi.IsExist(objDnFunctionEN.DnFunctionId) == true)
 {
     objDnFunctionEN.DnFunctionId = clsDnFunctionWApi.GetMaxStrId();
 }
clsDnFunctionWApi.CheckPropertyNew(objDnFunctionEN); 
bool bolResult = clsDnFunctionWApi.AddNewRecord(objDnFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFunctionWApi.ReFreshCache(objDnFunctionEN.PrjId);
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objDnFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDnFunctionEN objDnFunctionEN)
{
try
{
clsDnFunctionWApi.CheckPropertyNew(objDnFunctionEN); 
string strDnFunctionId = clsDnFunctionWApi.AddNewRecordWithMaxId(objDnFunctionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFunctionWApi.ReFreshCache(objDnFunctionEN.PrjId);
return strDnFunctionId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objDnFunctionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDnFunctionEN objDnFunctionEN, string strWhereCond)
{
try
{
clsDnFunctionWApi.CheckPropertyNew(objDnFunctionEN); 
bool bolResult = clsDnFunctionWApi.UpdateWithCondition(objDnFunctionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFunctionWApi.ReFreshCache(objDnFunctionEN.PrjId);
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
 /// 数据结点函数(DnFunction)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDnFunctionWApi
{
private static readonly string mstrApiControllerName = "DnFunctionApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsDnFunctionWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DnFunctionId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据结点函数]...","0");
List<clsDnFunctionEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="DnFunctionId";
objDDL.DataTextField="DnFunctionName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strPrjId"></param>
public static void BindCbo_DnFunctionId(System.Windows.Forms.ComboBox objComboBox , string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDnFunction.DnFunctionId); 
List<clsDnFunctionEN> arrObjLst = clsDnFunctionWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsDnFunctionEN objDnFunctionEN = new clsDnFunctionEN()
{
DnFunctionId = "0",
DnFunctionName = "选[数据结点函数]..."
};
arrObjLstSel.Insert(0, objDnFunctionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conDnFunction.DnFunctionId;
objComboBox.DisplayMember = conDnFunction.DnFunctionName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDnFunctionEN objDnFunctionEN)
{
if (!Object.Equals(null, objDnFunctionEN.DnFunctionId) && GetStrLen(objDnFunctionEN.DnFunctionId) > 8)
{
 throw new Exception("字段[DN函数Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDnFunctionEN.DnFunctionName) && GetStrLen(objDnFunctionEN.DnFunctionName) > 50)
{
 throw new Exception("字段[DN函数]的长度不能超过50!");
}
if (!Object.Equals(null, objDnFunctionEN.AssociationMappingId) && GetStrLen(objDnFunctionEN.AssociationMappingId) > 2)
{
 throw new Exception("字段[关联关系映射Id]的长度不能超过2!");
}
if (!Object.Equals(null, objDnFunctionEN.ImportClass) && GetStrLen(objDnFunctionEN.ImportClass) > 50)
{
 throw new Exception("字段[导入类]的长度不能超过50!");
}
if (!Object.Equals(null, objDnFunctionEN.ImportPath) && GetStrLen(objDnFunctionEN.ImportPath) > 100)
{
 throw new Exception("字段[导入路径]的长度不能超过100!");
}
if (!Object.Equals(null, objDnFunctionEN.PrjId) && GetStrLen(objDnFunctionEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objDnFunctionEN.UpdDate) && GetStrLen(objDnFunctionEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objDnFunctionEN.UpdUser) && GetStrLen(objDnFunctionEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objDnFunctionEN.Memo) && GetStrLen(objDnFunctionEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objDnFunctionEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDnFunctionEN GetObjByDnFunctionId(string strDnFunctionId)
{
if (strDnFunctionId == "") return null;
string strAction = "GetObjByDnFunctionId";
clsDnFunctionEN objDnFunctionEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDnFunctionId"] = strDnFunctionId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objDnFunctionEN = JsonConvert.DeserializeObject<clsDnFunctionEN>(strJson);
return objDnFunctionEN;
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
public static clsDnFunctionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsDnFunctionEN objDnFunctionEN;
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
objDnFunctionEN = JsonConvert.DeserializeObject<clsDnFunctionEN>(strJson);
return objDnFunctionEN;
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
 /// <param name = "strDnFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDnFunctionEN GetObjByDnFunctionIdCache(string strDnFunctionId,string strPrjId)
{
if (string.IsNullOrEmpty(strDnFunctionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsDnFunctionEN._CurrTabName, strPrjId);
List<clsDnFunctionEN> arrDnFunctionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDnFunctionEN> arrDnFunctionObjLst_Sel =
from objDnFunctionEN in arrDnFunctionObjLstCache
where objDnFunctionEN.DnFunctionId == strDnFunctionId 
select objDnFunctionEN;
if (arrDnFunctionObjLst_Sel.Count() == 0)
{
   clsDnFunctionEN obj = clsDnFunctionWApi.GetObjByDnFunctionId(strDnFunctionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDnFunctionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDnFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDnFunctionNameByDnFunctionIdCache(string strDnFunctionId,string strPrjId)
{
if (string.IsNullOrEmpty(strDnFunctionId) == true) return "";
//初始化列表缓存
List<clsDnFunctionEN> arrDnFunctionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDnFunctionEN> arrDnFunctionObjLst_Sel1 =
from objDnFunctionEN in arrDnFunctionObjLstCache
where objDnFunctionEN.DnFunctionId == strDnFunctionId 
select objDnFunctionEN;
List <clsDnFunctionEN> arrDnFunctionObjLst_Sel = new List<clsDnFunctionEN>();
foreach (clsDnFunctionEN obj in arrDnFunctionObjLst_Sel1)
{
arrDnFunctionObjLst_Sel.Add(obj);
}
if (arrDnFunctionObjLst_Sel.Count > 0)
{
return arrDnFunctionObjLst_Sel[0].DnFunctionName;
}
string strErrMsgForGetObjById = string.Format("在DnFunction对象缓存列表中,找不到记录[DnFunctionId = {0}](函数:{1})", strDnFunctionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsDnFunctionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDnFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDnFunctionIdCache(string strDnFunctionId,string strPrjId)
{
if (string.IsNullOrEmpty(strDnFunctionId) == true) return "";
//初始化列表缓存
List<clsDnFunctionEN> arrDnFunctionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDnFunctionEN> arrDnFunctionObjLst_Sel1 =
from objDnFunctionEN in arrDnFunctionObjLstCache
where objDnFunctionEN.DnFunctionId == strDnFunctionId 
select objDnFunctionEN;
List <clsDnFunctionEN> arrDnFunctionObjLst_Sel = new List<clsDnFunctionEN>();
foreach (clsDnFunctionEN obj in arrDnFunctionObjLst_Sel1)
{
arrDnFunctionObjLst_Sel.Add(obj);
}
if (arrDnFunctionObjLst_Sel.Count > 0)
{
return arrDnFunctionObjLst_Sel[0].DnFunctionName;
}
string strErrMsgForGetObjById = string.Format("在DnFunction对象缓存列表中,找不到记录的相关名称[DnFunctionId = {0}](函数:{1})", strDnFunctionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsDnFunctionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnFunctionEN> GetObjLst(string strWhereCond)
{
 List<clsDnFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnFunctionEN>>(strJson);
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
 /// <param name = "arrDnFunctionId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnFunctionEN> GetObjLstByDnFunctionIdLst(List<string> arrDnFunctionId)
{
 List<clsDnFunctionEN> arrObjLst; 
string strAction = "GetObjLstByDnFunctionIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDnFunctionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDnFunctionEN>>(strJson);
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
 /// <param name = "arrDnFunctionId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsDnFunctionEN> GetObjLstByDnFunctionIdLstCache(List<string> arrDnFunctionId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsDnFunctionEN._CurrTabName, strPrjId);
List<clsDnFunctionEN> arrDnFunctionObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsDnFunctionEN> arrDnFunctionObjLst_Sel =
from objDnFunctionEN in arrDnFunctionObjLstCache
where arrDnFunctionId.Contains(objDnFunctionEN.DnFunctionId)
select objDnFunctionEN;
return arrDnFunctionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDnFunctionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDnFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnFunctionEN>>(strJson);
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
public static List<clsDnFunctionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDnFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnFunctionEN>>(strJson);
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
public static List<clsDnFunctionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDnFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnFunctionEN>>(strJson);
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
public static List<clsDnFunctionEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsDnFunctionEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDnFunctionEN>>(strJson);
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
public static int DelRecord(string strDnFunctionId)
{
string strAction = "DelRecord";
try
{
 clsDnFunctionEN objDnFunctionEN = clsDnFunctionWApi.GetObjByDnFunctionId(strDnFunctionId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strDnFunctionId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDnFunctionWApi.ReFreshCache(objDnFunctionEN.PrjId);
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
public static int DelDnFunctions(List<string> arrDnFunctionId)
{
string strAction = "DelDnFunctions";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDnFunctionId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsDnFunctionEN objDnFunctionEN = clsDnFunctionWApi.GetObjByDnFunctionId(arrDnFunctionId[0]);
clsDnFunctionWApi.ReFreshCache(objDnFunctionEN.PrjId);
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
public static int DelDnFunctionsByCond(string strWhereCond)
{
string strAction = "DelDnFunctionsByCond";
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
public static bool AddNewRecord(clsDnFunctionEN objDnFunctionEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnFunctionEN>(objDnFunctionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFunctionWApi.ReFreshCache(objDnFunctionEN.PrjId);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsDnFunctionEN objDnFunctionEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnFunctionEN>(objDnFunctionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDnFunctionWApi.ReFreshCache(objDnFunctionEN.PrjId);
var strDnFunctionId = (string)jobjReturn0["returnStr"];
return strDnFunctionId;
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
public static bool UpdateRecord(clsDnFunctionEN objDnFunctionEN)
{
if (string.IsNullOrEmpty(objDnFunctionEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDnFunctionEN.DnFunctionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnFunctionEN>(objDnFunctionEN);
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
 /// <param name = "objDnFunctionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDnFunctionEN objDnFunctionEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDnFunctionEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDnFunctionEN.DnFunctionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDnFunctionEN.DnFunctionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDnFunctionEN>(objDnFunctionEN);
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
public static bool IsExist(string strDnFunctionId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDnFunctionId"] = strDnFunctionId
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objDnFunctionENS">源对象</param>
 /// <param name = "objDnFunctionENT">目标对象</param>
 public static void CopyTo(clsDnFunctionEN objDnFunctionENS, clsDnFunctionEN objDnFunctionENT)
{
try
{
objDnFunctionENT.DnFunctionId = objDnFunctionENS.DnFunctionId; //DN函数Id
objDnFunctionENT.DnFunctionName = objDnFunctionENS.DnFunctionName; //DN函数
objDnFunctionENT.AssociationMappingId = objDnFunctionENS.AssociationMappingId; //关联关系映射Id
objDnFunctionENT.ImportClass = objDnFunctionENS.ImportClass; //导入类
objDnFunctionENT.ImportPath = objDnFunctionENS.ImportPath; //导入路径
objDnFunctionENT.PrjId = objDnFunctionENS.PrjId; //工程Id
objDnFunctionENT.UpdDate = objDnFunctionENS.UpdDate; //修改日期
objDnFunctionENT.UpdUser = objDnFunctionENS.UpdUser; //修改者
objDnFunctionENT.Memo = objDnFunctionENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsDnFunctionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDnFunctionEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDnFunctionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDnFunctionEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDnFunctionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDnFunctionEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsDnFunctionWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsDnFunctionWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsDnFunctionEN._CurrTabName, strPrjId);
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
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsDnFunctionWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsDnFunctionEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsDnFunctionWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDnFunctionEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsDnFunctionWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsDnFunctionWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsDnFunctionEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsDnFunctionEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conDnFunction.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsDnFunctionEN._CurrTabName, strPrjId);
List<clsDnFunctionEN> arrDnFunctionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrDnFunctionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDnFunctionEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsDnFunctionEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsDnFunctionWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsDnFunctionWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsDnFunctionEN._CurrTabName, strPrjId);
List<clsDnFunctionEN> arrDnFunctionObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrDnFunctionObjLstCache = CacheHelper.Get<List<clsDnFunctionEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrDnFunctionObjLstCache = CacheHelper.Get<List<clsDnFunctionEN>>(strKey);
}
return arrDnFunctionObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDnFunctionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDnFunction.DnFunctionId, Type.GetType("System.String"));
objDT.Columns.Add(conDnFunction.DnFunctionName, Type.GetType("System.String"));
objDT.Columns.Add(conDnFunction.AssociationMappingId, Type.GetType("System.String"));
objDT.Columns.Add(conDnFunction.ImportClass, Type.GetType("System.String"));
objDT.Columns.Add(conDnFunction.ImportPath, Type.GetType("System.String"));
objDT.Columns.Add(conDnFunction.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conDnFunction.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conDnFunction.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conDnFunction.Memo, Type.GetType("System.String"));
foreach (clsDnFunctionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDnFunction.DnFunctionId] = objInFor[conDnFunction.DnFunctionId];
objDR[conDnFunction.DnFunctionName] = objInFor[conDnFunction.DnFunctionName];
objDR[conDnFunction.AssociationMappingId] = objInFor[conDnFunction.AssociationMappingId];
objDR[conDnFunction.ImportClass] = objInFor[conDnFunction.ImportClass];
objDR[conDnFunction.ImportPath] = objInFor[conDnFunction.ImportPath];
objDR[conDnFunction.PrjId] = objInFor[conDnFunction.PrjId];
objDR[conDnFunction.UpdDate] = objInFor[conDnFunction.UpdDate];
objDR[conDnFunction.UpdUser] = objInFor[conDnFunction.UpdUser];
objDR[conDnFunction.Memo] = objInFor[conDnFunction.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 数据结点函数(DnFunction)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4DnFunction : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
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
clsDnFunctionWApi.ReFreshThisCache(strPrjId);
}
}

}