
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureImplementationBL
 表名:vFeatureImplementation(00050394)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
public static class  clsvFeatureImplementationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureImplementationEN GetObj(this K_mId_vFeatureImplementation myKey)
{
clsvFeatureImplementationEN objvFeatureImplementationEN = clsvFeatureImplementationBL.vFeatureImplementationDA.GetObjBymId(myKey.Value);
return objvFeatureImplementationEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetmId(this clsvFeatureImplementationEN objvFeatureImplementationEN, long lngmId, string strComparisonOp="")
	{
objvFeatureImplementationEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.mId) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.mId, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.mId] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetFeatureId(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFeatureImplementation.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFeatureImplementation.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFeatureImplementation.FeatureId);
}
objvFeatureImplementationEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.FeatureId) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.FeatureId, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.FeatureId] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetFeatureName(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convFeatureImplementation.FeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFeatureImplementation.FeatureName);
}
objvFeatureImplementationEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.FeatureName) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.FeatureName, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.FeatureName] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetKeyWords(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strKeyWords, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convFeatureImplementation.KeyWords);
}
objvFeatureImplementationEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.KeyWords) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.KeyWords, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.KeyWords] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetFeatureDescription(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strFeatureDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureDescription, 4000, convFeatureImplementation.FeatureDescription);
}
objvFeatureImplementationEN.FeatureDescription = strFeatureDescription; //功能说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.FeatureDescription) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.FeatureDescription, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.FeatureDescription] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetFeatureTypeId(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeId, convFeatureImplementation.FeatureTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeId, 2, convFeatureImplementation.FeatureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureTypeId, 2, convFeatureImplementation.FeatureTypeId);
}
objvFeatureImplementationEN.FeatureTypeId = strFeatureTypeId; //功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.FeatureTypeId) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.FeatureTypeId, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.FeatureTypeId] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetFeatureTypeName(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convFeatureImplementation.FeatureTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convFeatureImplementation.FeatureTypeName);
}
objvFeatureImplementationEN.FeatureTypeName = strFeatureTypeName; //功能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.FeatureTypeName) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.FeatureTypeName, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.FeatureTypeName] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetViewImplId(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strViewImplId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewImplId, convFeatureImplementation.ViewImplId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewImplId, 4, convFeatureImplementation.ViewImplId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewImplId, 4, convFeatureImplementation.ViewImplId);
}
objvFeatureImplementationEN.ViewImplId = strViewImplId; //界面实现Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.ViewImplId) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.ViewImplId, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.ViewImplId] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetViewImplName(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strViewImplName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewImplName, 50, convFeatureImplementation.ViewImplName);
}
objvFeatureImplementationEN.ViewImplName = strViewImplName; //界面实现名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.ViewImplName) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.ViewImplName, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.ViewImplName] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetUpdDate(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFeatureImplementation.UpdDate);
}
objvFeatureImplementationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.UpdDate) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.UpdDate, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.UpdDate] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetUpdUser(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFeatureImplementation.UpdUser);
}
objvFeatureImplementationEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.UpdUser) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.UpdUser, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.UpdUser] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureImplementationEN SetMemo(this clsvFeatureImplementationEN objvFeatureImplementationEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFeatureImplementation.Memo);
}
objvFeatureImplementationEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureImplementationEN.dicFldComparisonOp.ContainsKey(convFeatureImplementation.Memo) == false)
{
objvFeatureImplementationEN.dicFldComparisonOp.Add(convFeatureImplementation.Memo, strComparisonOp);
}
else
{
objvFeatureImplementationEN.dicFldComparisonOp[convFeatureImplementation.Memo] = strComparisonOp;
}
}
return objvFeatureImplementationEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFeatureImplementationENS">源对象</param>
 /// <param name = "objvFeatureImplementationENT">目标对象</param>
 public static void CopyTo(this clsvFeatureImplementationEN objvFeatureImplementationENS, clsvFeatureImplementationEN objvFeatureImplementationENT)
{
try
{
objvFeatureImplementationENT.mId = objvFeatureImplementationENS.mId; //mId
objvFeatureImplementationENT.FeatureId = objvFeatureImplementationENS.FeatureId; //功能Id
objvFeatureImplementationENT.FeatureName = objvFeatureImplementationENS.FeatureName; //功能名称
objvFeatureImplementationENT.KeyWords = objvFeatureImplementationENS.KeyWords; //关键字
objvFeatureImplementationENT.FeatureDescription = objvFeatureImplementationENS.FeatureDescription; //功能说明
objvFeatureImplementationENT.FeatureTypeId = objvFeatureImplementationENS.FeatureTypeId; //功能类型Id
objvFeatureImplementationENT.FeatureTypeName = objvFeatureImplementationENS.FeatureTypeName; //功能类型名称
objvFeatureImplementationENT.ViewImplId = objvFeatureImplementationENS.ViewImplId; //界面实现Id
objvFeatureImplementationENT.ViewImplName = objvFeatureImplementationENS.ViewImplName; //界面实现名
objvFeatureImplementationENT.UpdDate = objvFeatureImplementationENS.UpdDate; //修改日期
objvFeatureImplementationENT.UpdUser = objvFeatureImplementationENS.UpdUser; //修改者
objvFeatureImplementationENT.Memo = objvFeatureImplementationENS.Memo; //说明
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
 /// <param name = "objvFeatureImplementationENS">源对象</param>
 /// <returns>目标对象=>clsvFeatureImplementationEN:objvFeatureImplementationENT</returns>
 public static clsvFeatureImplementationEN CopyTo(this clsvFeatureImplementationEN objvFeatureImplementationENS)
{
try
{
 clsvFeatureImplementationEN objvFeatureImplementationENT = new clsvFeatureImplementationEN()
{
mId = objvFeatureImplementationENS.mId, //mId
FeatureId = objvFeatureImplementationENS.FeatureId, //功能Id
FeatureName = objvFeatureImplementationENS.FeatureName, //功能名称
KeyWords = objvFeatureImplementationENS.KeyWords, //关键字
FeatureDescription = objvFeatureImplementationENS.FeatureDescription, //功能说明
FeatureTypeId = objvFeatureImplementationENS.FeatureTypeId, //功能类型Id
FeatureTypeName = objvFeatureImplementationENS.FeatureTypeName, //功能类型名称
ViewImplId = objvFeatureImplementationENS.ViewImplId, //界面实现Id
ViewImplName = objvFeatureImplementationENS.ViewImplName, //界面实现名
UpdDate = objvFeatureImplementationENS.UpdDate, //修改日期
UpdUser = objvFeatureImplementationENS.UpdUser, //修改者
Memo = objvFeatureImplementationENS.Memo, //说明
};
 return objvFeatureImplementationENT;
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
public static void CheckProperty4Condition(this clsvFeatureImplementationEN objvFeatureImplementationEN)
{
 clsvFeatureImplementationBL.vFeatureImplementationDA.CheckProperty4Condition(objvFeatureImplementationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFeatureImplementationEN objvFeatureImplementationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.mId) == true)
{
string strComparisonOpmId = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureImplementation.mId, objvFeatureImplementationCond.mId, strComparisonOpmId);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.FeatureId, objvFeatureImplementationCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.FeatureName) == true)
{
string strComparisonOpFeatureName = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.FeatureName, objvFeatureImplementationCond.FeatureName, strComparisonOpFeatureName);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.KeyWords) == true)
{
string strComparisonOpKeyWords = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.KeyWords, objvFeatureImplementationCond.KeyWords, strComparisonOpKeyWords);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.FeatureDescription) == true)
{
string strComparisonOpFeatureDescription = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.FeatureDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.FeatureDescription, objvFeatureImplementationCond.FeatureDescription, strComparisonOpFeatureDescription);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.FeatureTypeId) == true)
{
string strComparisonOpFeatureTypeId = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.FeatureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.FeatureTypeId, objvFeatureImplementationCond.FeatureTypeId, strComparisonOpFeatureTypeId);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.FeatureTypeName) == true)
{
string strComparisonOpFeatureTypeName = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.FeatureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.FeatureTypeName, objvFeatureImplementationCond.FeatureTypeName, strComparisonOpFeatureTypeName);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.ViewImplId) == true)
{
string strComparisonOpViewImplId = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.ViewImplId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.ViewImplId, objvFeatureImplementationCond.ViewImplId, strComparisonOpViewImplId);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.ViewImplName) == true)
{
string strComparisonOpViewImplName = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.ViewImplName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.ViewImplName, objvFeatureImplementationCond.ViewImplName, strComparisonOpViewImplName);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.UpdDate, objvFeatureImplementationCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.UpdUser, objvFeatureImplementationCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFeatureImplementationCond.IsUpdated(convFeatureImplementation.Memo) == true)
{
string strComparisonOpMemo = objvFeatureImplementationCond.dicFldComparisonOp[convFeatureImplementation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureImplementation.Memo, objvFeatureImplementationCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFeatureImplementation
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v功能实现方式(vFeatureImplementation)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureImplementationBL
{
public static RelatedActions_vFeatureImplementation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFeatureImplementationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFeatureImplementationDA vFeatureImplementationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFeatureImplementationDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFeatureImplementationBL()
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
if (string.IsNullOrEmpty(clsvFeatureImplementationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFeatureImplementationEN._ConnectString);
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
public static DataTable GetDataTable_vFeatureImplementation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFeatureImplementationDA.GetDataTable_vFeatureImplementation(strWhereCond);
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
objDT = vFeatureImplementationDA.GetDataTable(strWhereCond);
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
objDT = vFeatureImplementationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFeatureImplementationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFeatureImplementationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFeatureImplementationDA.GetDataTable_Top(objTopPara);
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
objDT = vFeatureImplementationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFeatureImplementationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFeatureImplementationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvFeatureImplementationEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvFeatureImplementationEN> arrObjLst = new List<clsvFeatureImplementationEN>(); 
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
	clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN();
try
{
objvFeatureImplementationEN.mId = Int32.Parse(objRow[convFeatureImplementation.mId].ToString().Trim()); //mId
objvFeatureImplementationEN.FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objvFeatureImplementationEN.FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称
objvFeatureImplementationEN.KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(); //关键字
objvFeatureImplementationEN.FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureImplementationEN.FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureImplementationEN.FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureImplementationEN.ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureImplementationEN.ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureImplementationEN.UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objvFeatureImplementationEN.UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objvFeatureImplementationEN.Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureImplementationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFeatureImplementationEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvFeatureImplementationEN._CurrTabName);
List<clsvFeatureImplementationEN> arrvFeatureImplementationObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureImplementationEN> arrvFeatureImplementationObjLst_Sel =
arrvFeatureImplementationObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvFeatureImplementationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureImplementationEN> GetObjLst(string strWhereCond)
{
List<clsvFeatureImplementationEN> arrObjLst = new List<clsvFeatureImplementationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN();
try
{
objvFeatureImplementationEN.mId = Int32.Parse(objRow[convFeatureImplementation.mId].ToString().Trim()); //mId
objvFeatureImplementationEN.FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objvFeatureImplementationEN.FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称
objvFeatureImplementationEN.KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(); //关键字
objvFeatureImplementationEN.FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureImplementationEN.FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureImplementationEN.FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureImplementationEN.ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureImplementationEN.ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureImplementationEN.UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objvFeatureImplementationEN.UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objvFeatureImplementationEN.Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureImplementationEN);
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
public static List<clsvFeatureImplementationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureImplementationEN> arrObjLst = new List<clsvFeatureImplementationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN();
try
{
objvFeatureImplementationEN.mId = Int32.Parse(objRow[convFeatureImplementation.mId].ToString().Trim()); //mId
objvFeatureImplementationEN.FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objvFeatureImplementationEN.FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称
objvFeatureImplementationEN.KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(); //关键字
objvFeatureImplementationEN.FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureImplementationEN.FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureImplementationEN.FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureImplementationEN.ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureImplementationEN.ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureImplementationEN.UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objvFeatureImplementationEN.UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objvFeatureImplementationEN.Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureImplementationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFeatureImplementationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFeatureImplementationEN> GetSubObjLstCache(clsvFeatureImplementationEN objvFeatureImplementationCond)
{
List<clsvFeatureImplementationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureImplementationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureImplementation._AttributeName)
{
if (objvFeatureImplementationCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureImplementationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureImplementationCond[strFldName].ToString());
}
else
{
if (objvFeatureImplementationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureImplementationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureImplementationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureImplementationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureImplementationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureImplementationCond[strFldName]));
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
public static List<clsvFeatureImplementationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFeatureImplementationEN> arrObjLst = new List<clsvFeatureImplementationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN();
try
{
objvFeatureImplementationEN.mId = Int32.Parse(objRow[convFeatureImplementation.mId].ToString().Trim()); //mId
objvFeatureImplementationEN.FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objvFeatureImplementationEN.FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称
objvFeatureImplementationEN.KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(); //关键字
objvFeatureImplementationEN.FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureImplementationEN.FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureImplementationEN.FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureImplementationEN.ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureImplementationEN.ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureImplementationEN.UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objvFeatureImplementationEN.UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objvFeatureImplementationEN.Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureImplementationEN);
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
public static List<clsvFeatureImplementationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFeatureImplementationEN> arrObjLst = new List<clsvFeatureImplementationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN();
try
{
objvFeatureImplementationEN.mId = Int32.Parse(objRow[convFeatureImplementation.mId].ToString().Trim()); //mId
objvFeatureImplementationEN.FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objvFeatureImplementationEN.FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称
objvFeatureImplementationEN.KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(); //关键字
objvFeatureImplementationEN.FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureImplementationEN.FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureImplementationEN.FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureImplementationEN.ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureImplementationEN.ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureImplementationEN.UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objvFeatureImplementationEN.UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objvFeatureImplementationEN.Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureImplementationEN);
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
List<clsvFeatureImplementationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFeatureImplementationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureImplementationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFeatureImplementationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureImplementationEN> arrObjLst = new List<clsvFeatureImplementationEN>(); 
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
	clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN();
try
{
objvFeatureImplementationEN.mId = Int32.Parse(objRow[convFeatureImplementation.mId].ToString().Trim()); //mId
objvFeatureImplementationEN.FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objvFeatureImplementationEN.FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称
objvFeatureImplementationEN.KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(); //关键字
objvFeatureImplementationEN.FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureImplementationEN.FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureImplementationEN.FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureImplementationEN.ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureImplementationEN.ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureImplementationEN.UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objvFeatureImplementationEN.UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objvFeatureImplementationEN.Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureImplementationEN);
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
public static List<clsvFeatureImplementationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureImplementationEN> arrObjLst = new List<clsvFeatureImplementationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN();
try
{
objvFeatureImplementationEN.mId = Int32.Parse(objRow[convFeatureImplementation.mId].ToString().Trim()); //mId
objvFeatureImplementationEN.FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objvFeatureImplementationEN.FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称
objvFeatureImplementationEN.KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(); //关键字
objvFeatureImplementationEN.FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureImplementationEN.FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureImplementationEN.FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureImplementationEN.ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureImplementationEN.ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureImplementationEN.UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objvFeatureImplementationEN.UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objvFeatureImplementationEN.Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureImplementationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFeatureImplementationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFeatureImplementationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureImplementationEN> arrObjLst = new List<clsvFeatureImplementationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN();
try
{
objvFeatureImplementationEN.mId = Int32.Parse(objRow[convFeatureImplementation.mId].ToString().Trim()); //mId
objvFeatureImplementationEN.FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objvFeatureImplementationEN.FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称
objvFeatureImplementationEN.KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(); //关键字
objvFeatureImplementationEN.FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureImplementationEN.FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureImplementationEN.FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureImplementationEN.ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureImplementationEN.ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureImplementationEN.UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objvFeatureImplementationEN.UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objvFeatureImplementationEN.Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureImplementationEN);
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
public static List<clsvFeatureImplementationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFeatureImplementationEN> arrObjLst = new List<clsvFeatureImplementationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN();
try
{
objvFeatureImplementationEN.mId = Int32.Parse(objRow[convFeatureImplementation.mId].ToString().Trim()); //mId
objvFeatureImplementationEN.FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objvFeatureImplementationEN.FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称
objvFeatureImplementationEN.KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(); //关键字
objvFeatureImplementationEN.FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureImplementationEN.FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureImplementationEN.FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureImplementationEN.ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureImplementationEN.ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureImplementationEN.UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objvFeatureImplementationEN.UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objvFeatureImplementationEN.Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureImplementationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureImplementationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFeatureImplementationEN> arrObjLst = new List<clsvFeatureImplementationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureImplementationEN objvFeatureImplementationEN = new clsvFeatureImplementationEN();
try
{
objvFeatureImplementationEN.mId = Int32.Parse(objRow[convFeatureImplementation.mId].ToString().Trim()); //mId
objvFeatureImplementationEN.FeatureId = objRow[convFeatureImplementation.FeatureId].ToString().Trim(); //功能Id
objvFeatureImplementationEN.FeatureName = objRow[convFeatureImplementation.FeatureName].ToString().Trim(); //功能名称
objvFeatureImplementationEN.KeyWords = objRow[convFeatureImplementation.KeyWords] == DBNull.Value ? null : objRow[convFeatureImplementation.KeyWords].ToString().Trim(); //关键字
objvFeatureImplementationEN.FeatureDescription = objRow[convFeatureImplementation.FeatureDescription] == DBNull.Value ? null : objRow[convFeatureImplementation.FeatureDescription].ToString().Trim(); //功能说明
objvFeatureImplementationEN.FeatureTypeId = objRow[convFeatureImplementation.FeatureTypeId].ToString().Trim(); //功能类型Id
objvFeatureImplementationEN.FeatureTypeName = objRow[convFeatureImplementation.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureImplementationEN.ViewImplId = objRow[convFeatureImplementation.ViewImplId].ToString().Trim(); //界面实现Id
objvFeatureImplementationEN.ViewImplName = objRow[convFeatureImplementation.ViewImplName] == DBNull.Value ? null : objRow[convFeatureImplementation.ViewImplName].ToString().Trim(); //界面实现名
objvFeatureImplementationEN.UpdDate = objRow[convFeatureImplementation.UpdDate] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdDate].ToString().Trim(); //修改日期
objvFeatureImplementationEN.UpdUser = objRow[convFeatureImplementation.UpdUser] == DBNull.Value ? null : objRow[convFeatureImplementation.UpdUser].ToString().Trim(); //修改者
objvFeatureImplementationEN.Memo = objRow[convFeatureImplementation.Memo] == DBNull.Value ? null : objRow[convFeatureImplementation.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureImplementationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureImplementationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFeatureImplementationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFeatureImplementation(ref clsvFeatureImplementationEN objvFeatureImplementationEN)
{
bool bolResult = vFeatureImplementationDA.GetvFeatureImplementation(ref objvFeatureImplementationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureImplementationEN GetObjBymId(long lngmId)
{
clsvFeatureImplementationEN objvFeatureImplementationEN = vFeatureImplementationDA.GetObjBymId(lngmId);
return objvFeatureImplementationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFeatureImplementationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFeatureImplementationEN objvFeatureImplementationEN = vFeatureImplementationDA.GetFirstObj(strWhereCond);
 return objvFeatureImplementationEN;
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
public static clsvFeatureImplementationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFeatureImplementationEN objvFeatureImplementationEN = vFeatureImplementationDA.GetObjByDataRow(objRow);
 return objvFeatureImplementationEN;
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
public static clsvFeatureImplementationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFeatureImplementationEN objvFeatureImplementationEN = vFeatureImplementationDA.GetObjByDataRow(objRow);
 return objvFeatureImplementationEN;
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
 /// <param name = "lstvFeatureImplementationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureImplementationEN GetObjBymIdFromList(long lngmId, List<clsvFeatureImplementationEN> lstvFeatureImplementationObjLst)
{
foreach (clsvFeatureImplementationEN objvFeatureImplementationEN in lstvFeatureImplementationObjLst)
{
if (objvFeatureImplementationEN.mId == lngmId)
{
return objvFeatureImplementationEN;
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
 lngmId = new clsvFeatureImplementationDA().GetFirstID(strWhereCond);
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
 arrList = vFeatureImplementationDA.GetID(strWhereCond);
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
bool bolIsExist = vFeatureImplementationDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vFeatureImplementationDA.IsExist(lngmId);
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
 bolIsExist = clsvFeatureImplementationDA.IsExistTable();
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
 bolIsExist = vFeatureImplementationDA.IsExistTable(strTabName);
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
 /// <param name = "objvFeatureImplementationENS">源对象</param>
 /// <param name = "objvFeatureImplementationENT">目标对象</param>
 public static void CopyTo(clsvFeatureImplementationEN objvFeatureImplementationENS, clsvFeatureImplementationEN objvFeatureImplementationENT)
{
try
{
objvFeatureImplementationENT.mId = objvFeatureImplementationENS.mId; //mId
objvFeatureImplementationENT.FeatureId = objvFeatureImplementationENS.FeatureId; //功能Id
objvFeatureImplementationENT.FeatureName = objvFeatureImplementationENS.FeatureName; //功能名称
objvFeatureImplementationENT.KeyWords = objvFeatureImplementationENS.KeyWords; //关键字
objvFeatureImplementationENT.FeatureDescription = objvFeatureImplementationENS.FeatureDescription; //功能说明
objvFeatureImplementationENT.FeatureTypeId = objvFeatureImplementationENS.FeatureTypeId; //功能类型Id
objvFeatureImplementationENT.FeatureTypeName = objvFeatureImplementationENS.FeatureTypeName; //功能类型名称
objvFeatureImplementationENT.ViewImplId = objvFeatureImplementationENS.ViewImplId; //界面实现Id
objvFeatureImplementationENT.ViewImplName = objvFeatureImplementationENS.ViewImplName; //界面实现名
objvFeatureImplementationENT.UpdDate = objvFeatureImplementationENS.UpdDate; //修改日期
objvFeatureImplementationENT.UpdUser = objvFeatureImplementationENS.UpdUser; //修改者
objvFeatureImplementationENT.Memo = objvFeatureImplementationENS.Memo; //说明
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
 /// <param name = "objvFeatureImplementationEN">源简化对象</param>
 public static void SetUpdFlag(clsvFeatureImplementationEN objvFeatureImplementationEN)
{
try
{
objvFeatureImplementationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFeatureImplementationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFeatureImplementation.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureImplementationEN.mId = objvFeatureImplementationEN.mId; //mId
}
if (arrFldSet.Contains(convFeatureImplementation.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureImplementationEN.FeatureId = objvFeatureImplementationEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convFeatureImplementation.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureImplementationEN.FeatureName = objvFeatureImplementationEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convFeatureImplementation.KeyWords, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureImplementationEN.KeyWords = objvFeatureImplementationEN.KeyWords == "[null]" ? null :  objvFeatureImplementationEN.KeyWords; //关键字
}
if (arrFldSet.Contains(convFeatureImplementation.FeatureDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureImplementationEN.FeatureDescription = objvFeatureImplementationEN.FeatureDescription == "[null]" ? null :  objvFeatureImplementationEN.FeatureDescription; //功能说明
}
if (arrFldSet.Contains(convFeatureImplementation.FeatureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureImplementationEN.FeatureTypeId = objvFeatureImplementationEN.FeatureTypeId; //功能类型Id
}
if (arrFldSet.Contains(convFeatureImplementation.FeatureTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureImplementationEN.FeatureTypeName = objvFeatureImplementationEN.FeatureTypeName; //功能类型名称
}
if (arrFldSet.Contains(convFeatureImplementation.ViewImplId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureImplementationEN.ViewImplId = objvFeatureImplementationEN.ViewImplId; //界面实现Id
}
if (arrFldSet.Contains(convFeatureImplementation.ViewImplName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureImplementationEN.ViewImplName = objvFeatureImplementationEN.ViewImplName == "[null]" ? null :  objvFeatureImplementationEN.ViewImplName; //界面实现名
}
if (arrFldSet.Contains(convFeatureImplementation.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureImplementationEN.UpdDate = objvFeatureImplementationEN.UpdDate == "[null]" ? null :  objvFeatureImplementationEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFeatureImplementation.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureImplementationEN.UpdUser = objvFeatureImplementationEN.UpdUser == "[null]" ? null :  objvFeatureImplementationEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFeatureImplementation.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureImplementationEN.Memo = objvFeatureImplementationEN.Memo == "[null]" ? null :  objvFeatureImplementationEN.Memo; //说明
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
 /// <param name = "objvFeatureImplementationEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFeatureImplementationEN objvFeatureImplementationEN)
{
try
{
if (objvFeatureImplementationEN.KeyWords == "[null]") objvFeatureImplementationEN.KeyWords = null; //关键字
if (objvFeatureImplementationEN.FeatureDescription == "[null]") objvFeatureImplementationEN.FeatureDescription = null; //功能说明
if (objvFeatureImplementationEN.ViewImplName == "[null]") objvFeatureImplementationEN.ViewImplName = null; //界面实现名
if (objvFeatureImplementationEN.UpdDate == "[null]") objvFeatureImplementationEN.UpdDate = null; //修改日期
if (objvFeatureImplementationEN.UpdUser == "[null]") objvFeatureImplementationEN.UpdUser = null; //修改者
if (objvFeatureImplementationEN.Memo == "[null]") objvFeatureImplementationEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvFeatureImplementationEN objvFeatureImplementationEN)
{
 vFeatureImplementationDA.CheckProperty4Condition(objvFeatureImplementationEN);
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
if (clsFeatureImplementationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFeatureImplementationBL没有刷新缓存机制(clsFeatureImplementationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewImplementationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewImplementationBL没有刷新缓存机制(clsViewImplementationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRegionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRegionTypeBL没有刷新缓存机制(clsRegionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsInOutTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsInOutTypeBL没有刷新缓存机制(clsInOutTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFeatureBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureBL没有刷新缓存机制(clsPrjFeatureBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjFeatureTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjFeatureTypeBL没有刷新缓存机制(clsPrjFeatureTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionGroupBL没有刷新缓存机制(clsFunctionGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvFeatureImplementationObjLstCache == null)
//{
//arrvFeatureImplementationObjLstCache = vFeatureImplementationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureImplementationEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFeatureImplementationEN._CurrTabName);
List<clsvFeatureImplementationEN> arrvFeatureImplementationObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureImplementationEN> arrvFeatureImplementationObjLst_Sel =
arrvFeatureImplementationObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvFeatureImplementationObjLst_Sel.Count() == 0)
{
   clsvFeatureImplementationEN obj = clsvFeatureImplementationBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFeatureImplementationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureImplementationEN> GetAllvFeatureImplementationObjLstCache()
{
//获取缓存中的对象列表
List<clsvFeatureImplementationEN> arrvFeatureImplementationObjLstCache = GetObjLstCache(); 
return arrvFeatureImplementationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureImplementationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFeatureImplementationEN._CurrTabName);
List<clsvFeatureImplementationEN> arrvFeatureImplementationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFeatureImplementationObjLstCache;
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
string strKey = string.Format("{0}", clsvFeatureImplementationEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFeatureImplementationEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFeatureImplementationEN._RefreshTimeLst.Count == 0) return "";
return clsvFeatureImplementationEN._RefreshTimeLst[clsvFeatureImplementationEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convFeatureImplementation.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFeatureImplementation._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFeatureImplementation._AttributeName));
throw new Exception(strMsg);
}
var objvFeatureImplementation = clsvFeatureImplementationBL.GetObjBymIdCache(lngmId);
if (objvFeatureImplementation == null) return "";
return objvFeatureImplementation[strOutFldName].ToString();
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
int intRecCount = clsvFeatureImplementationDA.GetRecCount(strTabName);
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
int intRecCount = clsvFeatureImplementationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFeatureImplementationDA.GetRecCount();
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
int intRecCount = clsvFeatureImplementationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFeatureImplementationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFeatureImplementationEN objvFeatureImplementationCond)
{
List<clsvFeatureImplementationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureImplementationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureImplementation._AttributeName)
{
if (objvFeatureImplementationCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureImplementationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureImplementationCond[strFldName].ToString());
}
else
{
if (objvFeatureImplementationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureImplementationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureImplementationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureImplementationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureImplementationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureImplementationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureImplementationCond[strFldName]));
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
 List<string> arrList = clsvFeatureImplementationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFeatureImplementationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFeatureImplementationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}