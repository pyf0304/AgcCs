
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionTypeBL
 表名:vFunctionType(00050481)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:45:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsvFunctionTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionTypeEN GetObj(this K_FuncTypeId_vFunctionType myKey)
{
clsvFunctionTypeEN objvFunctionTypeEN = clsvFunctionTypeBL.vFunctionTypeDA.GetObjByFuncTypeId(myKey.Value);
return objvFunctionTypeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetFuncTypeId(this clsvFunctionTypeEN objvFunctionTypeEN, string strFuncTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeId, 2, convFunctionType.FuncTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncTypeId, 2, convFunctionType.FuncTypeId);
}
objvFunctionTypeEN.FuncTypeId = strFuncTypeId; //函数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.FuncTypeId) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.FuncTypeId, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.FuncTypeId] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetFuncTypeName(this clsvFunctionTypeEN objvFunctionTypeEN, string strFuncTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncTypeName, convFunctionType.FuncTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeName, 20, convFunctionType.FuncTypeName);
}
objvFunctionTypeEN.FuncTypeName = strFuncTypeName; //函数类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.FuncTypeName) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.FuncTypeName, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.FuncTypeName] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetFuncTypeENName(this clsvFunctionTypeEN objvFunctionTypeEN, string strFuncTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncTypeENName, 50, convFunctionType.FuncTypeENName);
}
objvFunctionTypeEN.FuncTypeENName = strFuncTypeENName; //函数类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.FuncTypeENName) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.FuncTypeENName, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.FuncTypeENName] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetCodeTypeId(this clsvFunctionTypeEN objvFunctionTypeEN, string strCodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeId, convFunctionType.CodeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, convFunctionType.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, convFunctionType.CodeTypeId);
}
objvFunctionTypeEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.CodeTypeId) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.CodeTypeId, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.CodeTypeId] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetCodeTypeName(this clsvFunctionTypeEN objvFunctionTypeEN, string strCodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeName, convFunctionType.CodeTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeName, 50, convFunctionType.CodeTypeName);
}
objvFunctionTypeEN.CodeTypeName = strCodeTypeName; //代码类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.CodeTypeName) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.CodeTypeName, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.CodeTypeName] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetCodeTypeSimName(this clsvFunctionTypeEN objvFunctionTypeEN, string strCodeTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCodeTypeSimName, convFunctionType.CodeTypeSimName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeSimName, 50, convFunctionType.CodeTypeSimName);
}
objvFunctionTypeEN.CodeTypeSimName = strCodeTypeSimName; //简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.CodeTypeSimName) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.CodeTypeSimName, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.CodeTypeSimName] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetCodeTypeENName(this clsvFunctionTypeEN objvFunctionTypeEN, string strCodeTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeENName, 50, convFunctionType.CodeTypeENName);
}
objvFunctionTypeEN.CodeTypeENName = strCodeTypeENName; //代码类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.CodeTypeENName) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.CodeTypeENName, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.CodeTypeENName] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionTypeEN SetMemo(this clsvFunctionTypeEN objvFunctionTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunctionType.Memo);
}
objvFunctionTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionTypeEN.dicFldComparisonOp.ContainsKey(convFunctionType.Memo) == false)
{
objvFunctionTypeEN.dicFldComparisonOp.Add(convFunctionType.Memo, strComparisonOp);
}
else
{
objvFunctionTypeEN.dicFldComparisonOp[convFunctionType.Memo] = strComparisonOp;
}
}
return objvFunctionTypeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFunctionTypeENS">源对象</param>
 /// <param name = "objvFunctionTypeENT">目标对象</param>
 public static void CopyTo(this clsvFunctionTypeEN objvFunctionTypeENS, clsvFunctionTypeEN objvFunctionTypeENT)
{
try
{
objvFunctionTypeENT.FuncTypeId = objvFunctionTypeENS.FuncTypeId; //函数类型Id
objvFunctionTypeENT.FuncTypeName = objvFunctionTypeENS.FuncTypeName; //函数类型名
objvFunctionTypeENT.FuncTypeENName = objvFunctionTypeENS.FuncTypeENName; //函数类型英文名
objvFunctionTypeENT.CodeTypeId = objvFunctionTypeENS.CodeTypeId; //代码类型Id
objvFunctionTypeENT.CodeTypeName = objvFunctionTypeENS.CodeTypeName; //代码类型名
objvFunctionTypeENT.CodeTypeSimName = objvFunctionTypeENS.CodeTypeSimName; //简称
objvFunctionTypeENT.CodeTypeENName = objvFunctionTypeENS.CodeTypeENName; //代码类型英文名
objvFunctionTypeENT.Memo = objvFunctionTypeENS.Memo; //说明
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
 /// <param name = "objvFunctionTypeENS">源对象</param>
 /// <returns>目标对象=>clsvFunctionTypeEN:objvFunctionTypeENT</returns>
 public static clsvFunctionTypeEN CopyTo(this clsvFunctionTypeEN objvFunctionTypeENS)
{
try
{
 clsvFunctionTypeEN objvFunctionTypeENT = new clsvFunctionTypeEN()
{
FuncTypeId = objvFunctionTypeENS.FuncTypeId, //函数类型Id
FuncTypeName = objvFunctionTypeENS.FuncTypeName, //函数类型名
FuncTypeENName = objvFunctionTypeENS.FuncTypeENName, //函数类型英文名
CodeTypeId = objvFunctionTypeENS.CodeTypeId, //代码类型Id
CodeTypeName = objvFunctionTypeENS.CodeTypeName, //代码类型名
CodeTypeSimName = objvFunctionTypeENS.CodeTypeSimName, //简称
CodeTypeENName = objvFunctionTypeENS.CodeTypeENName, //代码类型英文名
Memo = objvFunctionTypeENS.Memo, //说明
};
 return objvFunctionTypeENT;
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
public static void CheckProperty4Condition(this clsvFunctionTypeEN objvFunctionTypeEN)
{
 clsvFunctionTypeBL.vFunctionTypeDA.CheckProperty4Condition(objvFunctionTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunctionTypeEN objvFunctionTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunctionTypeCond.IsUpdated(convFunctionType.FuncTypeId) == true)
{
string strComparisonOpFuncTypeId = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.FuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.FuncTypeId, objvFunctionTypeCond.FuncTypeId, strComparisonOpFuncTypeId);
}
if (objvFunctionTypeCond.IsUpdated(convFunctionType.FuncTypeName) == true)
{
string strComparisonOpFuncTypeName = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.FuncTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.FuncTypeName, objvFunctionTypeCond.FuncTypeName, strComparisonOpFuncTypeName);
}
if (objvFunctionTypeCond.IsUpdated(convFunctionType.FuncTypeENName) == true)
{
string strComparisonOpFuncTypeENName = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.FuncTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.FuncTypeENName, objvFunctionTypeCond.FuncTypeENName, strComparisonOpFuncTypeENName);
}
if (objvFunctionTypeCond.IsUpdated(convFunctionType.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.CodeTypeId, objvFunctionTypeCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objvFunctionTypeCond.IsUpdated(convFunctionType.CodeTypeName) == true)
{
string strComparisonOpCodeTypeName = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.CodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.CodeTypeName, objvFunctionTypeCond.CodeTypeName, strComparisonOpCodeTypeName);
}
if (objvFunctionTypeCond.IsUpdated(convFunctionType.CodeTypeSimName) == true)
{
string strComparisonOpCodeTypeSimName = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.CodeTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.CodeTypeSimName, objvFunctionTypeCond.CodeTypeSimName, strComparisonOpCodeTypeSimName);
}
if (objvFunctionTypeCond.IsUpdated(convFunctionType.CodeTypeENName) == true)
{
string strComparisonOpCodeTypeENName = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.CodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.CodeTypeENName, objvFunctionTypeCond.CodeTypeENName, strComparisonOpCodeTypeENName);
}
if (objvFunctionTypeCond.IsUpdated(convFunctionType.Memo) == true)
{
string strComparisonOpMemo = objvFunctionTypeCond.dicFldComparisonOp[convFunctionType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionType.Memo, objvFunctionTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vFunctionType(v函数类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:FuncTypeName_CodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvFunctionTypeEN objvFunctionTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvFunctionTypeEN == null) return true;
if (objvFunctionTypeEN.FuncTypeId == null || objvFunctionTypeEN.FuncTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncTypeName = '{0}'", objvFunctionTypeEN.FuncTypeName);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objvFunctionTypeEN.CodeTypeId);
if (clsvFunctionTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("FuncTypeId !=  '{0}'", objvFunctionTypeEN.FuncTypeId);
 sbCondition.AppendFormat(" and FuncTypeName = '{0}'", objvFunctionTypeEN.FuncTypeName);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objvFunctionTypeEN.CodeTypeId);
if (clsvFunctionTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vFunctionType(v函数类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FuncTypeName_CodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvFunctionTypeEN objvFunctionTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvFunctionTypeEN == null) return "";
if (objvFunctionTypeEN.FuncTypeId == null || objvFunctionTypeEN.FuncTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncTypeName = '{0}'", objvFunctionTypeEN.FuncTypeName);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objvFunctionTypeEN.CodeTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FuncTypeId !=  '{0}'", objvFunctionTypeEN.FuncTypeId);
 sbCondition.AppendFormat(" and FuncTypeName = '{0}'", objvFunctionTypeEN.FuncTypeName);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objvFunctionTypeEN.CodeTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFunctionType
{
public virtual bool UpdRelaTabDate(string strFuncTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v函数类型(vFunctionType)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFunctionTypeBL
{
public static RelatedActions_vFunctionType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFunctionTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFunctionTypeDA vFunctionTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFunctionTypeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFunctionTypeBL()
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
if (string.IsNullOrEmpty(clsvFunctionTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunctionTypeEN._ConnectString);
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
public static DataTable GetDataTable_vFunctionType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFunctionTypeDA.GetDataTable_vFunctionType(strWhereCond);
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
objDT = vFunctionTypeDA.GetDataTable(strWhereCond);
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
objDT = vFunctionTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFunctionTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFunctionTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFunctionTypeDA.GetDataTable_Top(objTopPara);
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
objDT = vFunctionTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFunctionTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFunctionTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFunctionTypeEN> GetObjLstByFuncTypeIdLst(List<string> arrFuncTypeIdLst)
{
List<clsvFunctionTypeEN> arrObjLst = new List<clsvFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncTypeIdLst, true);
 string strWhereCond = string.Format("FuncTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTypeEN objvFunctionTypeEN = new clsvFunctionTypeEN();
try
{
objvFunctionTypeEN.FuncTypeId = objRow[convFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTypeEN.FuncTypeName = objRow[convFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTypeEN.FuncTypeENName = objRow[convFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[convFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objvFunctionTypeEN.CodeTypeId = objRow[convFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTypeEN.CodeTypeName = objRow[convFunctionType.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTypeEN.CodeTypeSimName = objRow[convFunctionType.CodeTypeSimName].ToString().Trim(); //简称
objvFunctionTypeEN.CodeTypeENName = objRow[convFunctionType.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTypeEN.Memo = objRow[convFunctionType.Memo] == DBNull.Value ? null : objRow[convFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFunctionTypeEN> GetObjLstByFuncTypeIdLstCache(List<string> arrFuncTypeIdLst)
{
string strKey = string.Format("{0}", clsvFunctionTypeEN._CurrTabName);
List<clsvFunctionTypeEN> arrvFunctionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTypeEN> arrvFunctionTypeObjLst_Sel =
arrvFunctionTypeObjLstCache
.Where(x => arrFuncTypeIdLst.Contains(x.FuncTypeId));
return arrvFunctionTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTypeEN> GetObjLst(string strWhereCond)
{
List<clsvFunctionTypeEN> arrObjLst = new List<clsvFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTypeEN objvFunctionTypeEN = new clsvFunctionTypeEN();
try
{
objvFunctionTypeEN.FuncTypeId = objRow[convFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTypeEN.FuncTypeName = objRow[convFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTypeEN.FuncTypeENName = objRow[convFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[convFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objvFunctionTypeEN.CodeTypeId = objRow[convFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTypeEN.CodeTypeName = objRow[convFunctionType.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTypeEN.CodeTypeSimName = objRow[convFunctionType.CodeTypeSimName].ToString().Trim(); //简称
objvFunctionTypeEN.CodeTypeENName = objRow[convFunctionType.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTypeEN.Memo = objRow[convFunctionType.Memo] == DBNull.Value ? null : objRow[convFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTypeEN);
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
public static List<clsvFunctionTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFunctionTypeEN> arrObjLst = new List<clsvFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTypeEN objvFunctionTypeEN = new clsvFunctionTypeEN();
try
{
objvFunctionTypeEN.FuncTypeId = objRow[convFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTypeEN.FuncTypeName = objRow[convFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTypeEN.FuncTypeENName = objRow[convFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[convFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objvFunctionTypeEN.CodeTypeId = objRow[convFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTypeEN.CodeTypeName = objRow[convFunctionType.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTypeEN.CodeTypeSimName = objRow[convFunctionType.CodeTypeSimName].ToString().Trim(); //简称
objvFunctionTypeEN.CodeTypeENName = objRow[convFunctionType.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTypeEN.Memo = objRow[convFunctionType.Memo] == DBNull.Value ? null : objRow[convFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFunctionTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFunctionTypeEN> GetSubObjLstCache(clsvFunctionTypeEN objvFunctionTypeCond)
{
List<clsvFunctionTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunctionType._AttributeName)
{
if (objvFunctionTypeCond.IsUpdated(strFldName) == false) continue;
if (objvFunctionTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionTypeCond[strFldName].ToString());
}
else
{
if (objvFunctionTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunctionTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunctionTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunctionTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunctionTypeCond[strFldName]));
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
public static List<clsvFunctionTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFunctionTypeEN> arrObjLst = new List<clsvFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTypeEN objvFunctionTypeEN = new clsvFunctionTypeEN();
try
{
objvFunctionTypeEN.FuncTypeId = objRow[convFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTypeEN.FuncTypeName = objRow[convFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTypeEN.FuncTypeENName = objRow[convFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[convFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objvFunctionTypeEN.CodeTypeId = objRow[convFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTypeEN.CodeTypeName = objRow[convFunctionType.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTypeEN.CodeTypeSimName = objRow[convFunctionType.CodeTypeSimName].ToString().Trim(); //简称
objvFunctionTypeEN.CodeTypeENName = objRow[convFunctionType.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTypeEN.Memo = objRow[convFunctionType.Memo] == DBNull.Value ? null : objRow[convFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTypeEN);
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
public static List<clsvFunctionTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFunctionTypeEN> arrObjLst = new List<clsvFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTypeEN objvFunctionTypeEN = new clsvFunctionTypeEN();
try
{
objvFunctionTypeEN.FuncTypeId = objRow[convFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTypeEN.FuncTypeName = objRow[convFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTypeEN.FuncTypeENName = objRow[convFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[convFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objvFunctionTypeEN.CodeTypeId = objRow[convFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTypeEN.CodeTypeName = objRow[convFunctionType.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTypeEN.CodeTypeSimName = objRow[convFunctionType.CodeTypeSimName].ToString().Trim(); //简称
objvFunctionTypeEN.CodeTypeENName = objRow[convFunctionType.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTypeEN.Memo = objRow[convFunctionType.Memo] == DBNull.Value ? null : objRow[convFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTypeEN);
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
List<clsvFunctionTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFunctionTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFunctionTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFunctionTypeEN> arrObjLst = new List<clsvFunctionTypeEN>(); 
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
	clsvFunctionTypeEN objvFunctionTypeEN = new clsvFunctionTypeEN();
try
{
objvFunctionTypeEN.FuncTypeId = objRow[convFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTypeEN.FuncTypeName = objRow[convFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTypeEN.FuncTypeENName = objRow[convFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[convFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objvFunctionTypeEN.CodeTypeId = objRow[convFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTypeEN.CodeTypeName = objRow[convFunctionType.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTypeEN.CodeTypeSimName = objRow[convFunctionType.CodeTypeSimName].ToString().Trim(); //简称
objvFunctionTypeEN.CodeTypeENName = objRow[convFunctionType.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTypeEN.Memo = objRow[convFunctionType.Memo] == DBNull.Value ? null : objRow[convFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTypeEN);
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
public static List<clsvFunctionTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFunctionTypeEN> arrObjLst = new List<clsvFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTypeEN objvFunctionTypeEN = new clsvFunctionTypeEN();
try
{
objvFunctionTypeEN.FuncTypeId = objRow[convFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTypeEN.FuncTypeName = objRow[convFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTypeEN.FuncTypeENName = objRow[convFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[convFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objvFunctionTypeEN.CodeTypeId = objRow[convFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTypeEN.CodeTypeName = objRow[convFunctionType.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTypeEN.CodeTypeSimName = objRow[convFunctionType.CodeTypeSimName].ToString().Trim(); //简称
objvFunctionTypeEN.CodeTypeENName = objRow[convFunctionType.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTypeEN.Memo = objRow[convFunctionType.Memo] == DBNull.Value ? null : objRow[convFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFunctionTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFunctionTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFunctionTypeEN> arrObjLst = new List<clsvFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTypeEN objvFunctionTypeEN = new clsvFunctionTypeEN();
try
{
objvFunctionTypeEN.FuncTypeId = objRow[convFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTypeEN.FuncTypeName = objRow[convFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTypeEN.FuncTypeENName = objRow[convFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[convFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objvFunctionTypeEN.CodeTypeId = objRow[convFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTypeEN.CodeTypeName = objRow[convFunctionType.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTypeEN.CodeTypeSimName = objRow[convFunctionType.CodeTypeSimName].ToString().Trim(); //简称
objvFunctionTypeEN.CodeTypeENName = objRow[convFunctionType.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTypeEN.Memo = objRow[convFunctionType.Memo] == DBNull.Value ? null : objRow[convFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTypeEN);
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
public static List<clsvFunctionTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFunctionTypeEN> arrObjLst = new List<clsvFunctionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTypeEN objvFunctionTypeEN = new clsvFunctionTypeEN();
try
{
objvFunctionTypeEN.FuncTypeId = objRow[convFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTypeEN.FuncTypeName = objRow[convFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTypeEN.FuncTypeENName = objRow[convFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[convFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objvFunctionTypeEN.CodeTypeId = objRow[convFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTypeEN.CodeTypeName = objRow[convFunctionType.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTypeEN.CodeTypeSimName = objRow[convFunctionType.CodeTypeSimName].ToString().Trim(); //简称
objvFunctionTypeEN.CodeTypeENName = objRow[convFunctionType.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTypeEN.Memo = objRow[convFunctionType.Memo] == DBNull.Value ? null : objRow[convFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFunctionTypeEN> arrObjLst = new List<clsvFunctionTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionTypeEN objvFunctionTypeEN = new clsvFunctionTypeEN();
try
{
objvFunctionTypeEN.FuncTypeId = objRow[convFunctionType.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunctionTypeEN.FuncTypeName = objRow[convFunctionType.FuncTypeName].ToString().Trim(); //函数类型名
objvFunctionTypeEN.FuncTypeENName = objRow[convFunctionType.FuncTypeENName] == DBNull.Value ? null : objRow[convFunctionType.FuncTypeENName].ToString().Trim(); //函数类型英文名
objvFunctionTypeEN.CodeTypeId = objRow[convFunctionType.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunctionTypeEN.CodeTypeName = objRow[convFunctionType.CodeTypeName].ToString().Trim(); //代码类型名
objvFunctionTypeEN.CodeTypeSimName = objRow[convFunctionType.CodeTypeSimName].ToString().Trim(); //简称
objvFunctionTypeEN.CodeTypeENName = objRow[convFunctionType.CodeTypeENName] == DBNull.Value ? null : objRow[convFunctionType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvFunctionTypeEN.Memo = objRow[convFunctionType.Memo] == DBNull.Value ? null : objRow[convFunctionType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionTypeEN.FuncTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFunctionType(ref clsvFunctionTypeEN objvFunctionTypeEN)
{
bool bolResult = vFunctionTypeDA.GetvFunctionType(ref objvFunctionTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionTypeEN GetObjByFuncTypeId(string strFuncTypeId)
{
if (strFuncTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvFunctionTypeEN objvFunctionTypeEN = vFunctionTypeDA.GetObjByFuncTypeId(strFuncTypeId);
return objvFunctionTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFunctionTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFunctionTypeEN objvFunctionTypeEN = vFunctionTypeDA.GetFirstObj(strWhereCond);
 return objvFunctionTypeEN;
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
public static clsvFunctionTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFunctionTypeEN objvFunctionTypeEN = vFunctionTypeDA.GetObjByDataRow(objRow);
 return objvFunctionTypeEN;
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
public static clsvFunctionTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFunctionTypeEN objvFunctionTypeEN = vFunctionTypeDA.GetObjByDataRow(objRow);
 return objvFunctionTypeEN;
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
 /// <param name = "strFuncTypeId">所给的关键字</param>
 /// <param name = "lstvFunctionTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionTypeEN GetObjByFuncTypeIdFromList(string strFuncTypeId, List<clsvFunctionTypeEN> lstvFunctionTypeObjLst)
{
foreach (clsvFunctionTypeEN objvFunctionTypeEN in lstvFunctionTypeObjLst)
{
if (objvFunctionTypeEN.FuncTypeId == strFuncTypeId)
{
return objvFunctionTypeEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxFuncTypeId;
 try
 {
 strMaxFuncTypeId = clsvFunctionTypeDA.GetMaxStrId();
 return strMaxFuncTypeId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strFuncTypeId;
 try
 {
 strFuncTypeId = new clsvFunctionTypeDA().GetFirstID(strWhereCond);
 return strFuncTypeId;
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
 arrList = vFunctionTypeDA.GetID(strWhereCond);
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
bool bolIsExist = vFunctionTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncTypeId)
{
if (string.IsNullOrEmpty(strFuncTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vFunctionTypeDA.IsExist(strFuncTypeId);
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
 bolIsExist = clsvFunctionTypeDA.IsExistTable();
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
 bolIsExist = vFunctionTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objvFunctionTypeENS">源对象</param>
 /// <param name = "objvFunctionTypeENT">目标对象</param>
 public static void CopyTo(clsvFunctionTypeEN objvFunctionTypeENS, clsvFunctionTypeEN objvFunctionTypeENT)
{
try
{
objvFunctionTypeENT.FuncTypeId = objvFunctionTypeENS.FuncTypeId; //函数类型Id
objvFunctionTypeENT.FuncTypeName = objvFunctionTypeENS.FuncTypeName; //函数类型名
objvFunctionTypeENT.FuncTypeENName = objvFunctionTypeENS.FuncTypeENName; //函数类型英文名
objvFunctionTypeENT.CodeTypeId = objvFunctionTypeENS.CodeTypeId; //代码类型Id
objvFunctionTypeENT.CodeTypeName = objvFunctionTypeENS.CodeTypeName; //代码类型名
objvFunctionTypeENT.CodeTypeSimName = objvFunctionTypeENS.CodeTypeSimName; //简称
objvFunctionTypeENT.CodeTypeENName = objvFunctionTypeENS.CodeTypeENName; //代码类型英文名
objvFunctionTypeENT.Memo = objvFunctionTypeENS.Memo; //说明
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
 /// <param name = "objvFunctionTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsvFunctionTypeEN objvFunctionTypeEN)
{
try
{
objvFunctionTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFunctionTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFunctionType.FuncTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTypeEN.FuncTypeId = objvFunctionTypeEN.FuncTypeId; //函数类型Id
}
if (arrFldSet.Contains(convFunctionType.FuncTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTypeEN.FuncTypeName = objvFunctionTypeEN.FuncTypeName; //函数类型名
}
if (arrFldSet.Contains(convFunctionType.FuncTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTypeEN.FuncTypeENName = objvFunctionTypeEN.FuncTypeENName == "[null]" ? null :  objvFunctionTypeEN.FuncTypeENName; //函数类型英文名
}
if (arrFldSet.Contains(convFunctionType.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTypeEN.CodeTypeId = objvFunctionTypeEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(convFunctionType.CodeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTypeEN.CodeTypeName = objvFunctionTypeEN.CodeTypeName; //代码类型名
}
if (arrFldSet.Contains(convFunctionType.CodeTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTypeEN.CodeTypeSimName = objvFunctionTypeEN.CodeTypeSimName; //简称
}
if (arrFldSet.Contains(convFunctionType.CodeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTypeEN.CodeTypeENName = objvFunctionTypeEN.CodeTypeENName == "[null]" ? null :  objvFunctionTypeEN.CodeTypeENName; //代码类型英文名
}
if (arrFldSet.Contains(convFunctionType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionTypeEN.Memo = objvFunctionTypeEN.Memo == "[null]" ? null :  objvFunctionTypeEN.Memo; //说明
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
 /// <param name = "objvFunctionTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFunctionTypeEN objvFunctionTypeEN)
{
try
{
if (objvFunctionTypeEN.FuncTypeENName == "[null]") objvFunctionTypeEN.FuncTypeENName = null; //函数类型英文名
if (objvFunctionTypeEN.CodeTypeENName == "[null]") objvFunctionTypeEN.CodeTypeENName = null; //代码类型英文名
if (objvFunctionTypeEN.Memo == "[null]") objvFunctionTypeEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvFunctionTypeEN objvFunctionTypeEN)
{
 vFunctionTypeDA.CheckProperty4Condition(objvFunctionTypeEN);
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
if (clsFunctionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionTypeBL没有刷新缓存机制(clsFunctionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCodeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCodeTypeBL没有刷新缓存机制(clsCodeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncTypeId");
//if (arrvFunctionTypeObjLstCache == null)
//{
//arrvFunctionTypeObjLstCache = vFunctionTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionTypeEN GetObjByFuncTypeIdCache(string strFuncTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFunctionTypeEN._CurrTabName);
List<clsvFunctionTypeEN> arrvFunctionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTypeEN> arrvFunctionTypeObjLst_Sel =
arrvFunctionTypeObjLstCache
.Where(x=> x.FuncTypeId == strFuncTypeId 
);
if (arrvFunctionTypeObjLst_Sel.Count() == 0)
{
   clsvFunctionTypeEN obj = clsvFunctionTypeBL.GetObjByFuncTypeId(strFuncTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFunctionTypeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunctionTypeEN> GetAllvFunctionTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsvFunctionTypeEN> arrvFunctionTypeObjLstCache = GetObjLstCache(); 
return arrvFunctionTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunctionTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFunctionTypeEN._CurrTabName);
List<clsvFunctionTypeEN> arrvFunctionTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFunctionTypeObjLstCache;
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
string strKey = string.Format("{0}", clsvFunctionTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFunctionTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFunctionTypeEN._RefreshTimeLst.Count == 0) return "";
return clsvFunctionTypeEN._RefreshTimeLst[clsvFunctionTypeEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vFunctionType(v函数类型)
 /// 唯一性条件:FuncTypeName_CodeTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvFunctionTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvFunctionTypeEN objvFunctionTypeEN)
{
//检测记录是否存在
string strResult = vFunctionTypeDA.GetUniCondStr(objvFunctionTypeEN);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strFuncTypeId)
{
if (strInFldName != convFunctionType.FuncTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFunctionType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFunctionType._AttributeName));
throw new Exception(strMsg);
}
var objvFunctionType = clsvFunctionTypeBL.GetObjByFuncTypeIdCache(strFuncTypeId);
if (objvFunctionType == null) return "";
return objvFunctionType[strOutFldName].ToString();
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
int intRecCount = clsvFunctionTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsvFunctionTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFunctionTypeDA.GetRecCount();
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
int intRecCount = clsvFunctionTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFunctionTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFunctionTypeEN objvFunctionTypeCond)
{
List<clsvFunctionTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunctionType._AttributeName)
{
if (objvFunctionTypeCond.IsUpdated(strFldName) == false) continue;
if (objvFunctionTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionTypeCond[strFldName].ToString());
}
else
{
if (objvFunctionTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunctionTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunctionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunctionTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunctionTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunctionTypeCond[strFldName]));
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
 List<string> arrList = clsvFunctionTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFunctionTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFunctionTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}