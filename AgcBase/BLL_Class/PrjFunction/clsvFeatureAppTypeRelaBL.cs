
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureAppTypeRelaBL
 表名:vFeatureAppTypeRela(00050431)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:44
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvFeatureAppTypeRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureAppTypeRelaEN GetObj(this K_mId_vFeatureAppTypeRela myKey)
{
clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN = clsvFeatureAppTypeRelaBL.vFeatureAppTypeRelaDA.GetObjBymId(myKey.Value);
return objvFeatureAppTypeRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetmId(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, long lngmId, string strComparisonOp="")
	{
objvFeatureAppTypeRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.mId) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.mId, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.mId] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetApplicationTypeId(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convFeatureAppTypeRela.ApplicationTypeId);
objvFeatureAppTypeRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.ApplicationTypeId) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.ApplicationTypeId, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.ApplicationTypeId] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetApplicationTypeName(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, convFeatureAppTypeRela.ApplicationTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convFeatureAppTypeRela.ApplicationTypeName);
}
objvFeatureAppTypeRelaEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.ApplicationTypeName) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.ApplicationTypeName, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.ApplicationTypeName] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetApplicationTypeENName(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeENName, convFeatureAppTypeRela.ApplicationTypeENName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convFeatureAppTypeRela.ApplicationTypeENName);
}
objvFeatureAppTypeRelaEN.ApplicationTypeENName = strApplicationTypeENName; //应用类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.ApplicationTypeENName) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.ApplicationTypeENName, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.ApplicationTypeENName] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetFeatureId(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFeatureAppTypeRela.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFeatureAppTypeRela.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFeatureAppTypeRela.FeatureId);
}
objvFeatureAppTypeRelaEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.FeatureId) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.FeatureId, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.FeatureId] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetFeatureName(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convFeatureAppTypeRela.FeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFeatureAppTypeRela.FeatureName);
}
objvFeatureAppTypeRelaEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.FeatureName) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.FeatureName, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.FeatureName] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetFeatureTypeName(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convFeatureAppTypeRela.FeatureTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convFeatureAppTypeRela.FeatureTypeName);
}
objvFeatureAppTypeRelaEN.FeatureTypeName = strFeatureTypeName; //功能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.FeatureTypeName) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.FeatureTypeName, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.FeatureTypeName] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetOrderNum(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFeatureAppTypeRela.OrderNum);
objvFeatureAppTypeRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.OrderNum) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.OrderNum, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.OrderNum] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetInUse(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, bool bolInUse, string strComparisonOp="")
	{
objvFeatureAppTypeRelaEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.InUse) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.InUse, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.InUse] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetUpdDate(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFeatureAppTypeRela.UpdDate);
}
objvFeatureAppTypeRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.UpdDate) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.UpdDate, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.UpdDate] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetUpdUser(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFeatureAppTypeRela.UpdUser);
}
objvFeatureAppTypeRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.UpdUser) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.UpdUser, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.UpdUser] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureAppTypeRelaEN SetMemo(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFeatureAppTypeRela.Memo);
}
objvFeatureAppTypeRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureAppTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureAppTypeRela.Memo) == false)
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp.Add(convFeatureAppTypeRela.Memo, strComparisonOp);
}
else
{
objvFeatureAppTypeRelaEN.dicFldComparisonOp[convFeatureAppTypeRela.Memo] = strComparisonOp;
}
}
return objvFeatureAppTypeRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaENS">源对象</param>
 /// <param name = "objvFeatureAppTypeRelaENT">目标对象</param>
 public static void CopyTo(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaENS, clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaENT)
{
try
{
objvFeatureAppTypeRelaENT.mId = objvFeatureAppTypeRelaENS.mId; //mId
objvFeatureAppTypeRelaENT.ApplicationTypeId = objvFeatureAppTypeRelaENS.ApplicationTypeId; //应用程序类型ID
objvFeatureAppTypeRelaENT.ApplicationTypeName = objvFeatureAppTypeRelaENS.ApplicationTypeName; //应用程序类型名称
objvFeatureAppTypeRelaENT.ApplicationTypeENName = objvFeatureAppTypeRelaENS.ApplicationTypeENName; //应用类型英文名
objvFeatureAppTypeRelaENT.FeatureId = objvFeatureAppTypeRelaENS.FeatureId; //功能Id
objvFeatureAppTypeRelaENT.FeatureName = objvFeatureAppTypeRelaENS.FeatureName; //功能名称
objvFeatureAppTypeRelaENT.FeatureTypeName = objvFeatureAppTypeRelaENS.FeatureTypeName; //功能类型名称
objvFeatureAppTypeRelaENT.OrderNum = objvFeatureAppTypeRelaENS.OrderNum; //序号
objvFeatureAppTypeRelaENT.InUse = objvFeatureAppTypeRelaENS.InUse; //是否在用
objvFeatureAppTypeRelaENT.UpdDate = objvFeatureAppTypeRelaENS.UpdDate; //修改日期
objvFeatureAppTypeRelaENT.UpdUser = objvFeatureAppTypeRelaENS.UpdUser; //修改者
objvFeatureAppTypeRelaENT.Memo = objvFeatureAppTypeRelaENS.Memo; //说明
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
 /// <param name = "objvFeatureAppTypeRelaENS">源对象</param>
 /// <returns>目标对象=>clsvFeatureAppTypeRelaEN:objvFeatureAppTypeRelaENT</returns>
 public static clsvFeatureAppTypeRelaEN CopyTo(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaENS)
{
try
{
 clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaENT = new clsvFeatureAppTypeRelaEN()
{
mId = objvFeatureAppTypeRelaENS.mId, //mId
ApplicationTypeId = objvFeatureAppTypeRelaENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeName = objvFeatureAppTypeRelaENS.ApplicationTypeName, //应用程序类型名称
ApplicationTypeENName = objvFeatureAppTypeRelaENS.ApplicationTypeENName, //应用类型英文名
FeatureId = objvFeatureAppTypeRelaENS.FeatureId, //功能Id
FeatureName = objvFeatureAppTypeRelaENS.FeatureName, //功能名称
FeatureTypeName = objvFeatureAppTypeRelaENS.FeatureTypeName, //功能类型名称
OrderNum = objvFeatureAppTypeRelaENS.OrderNum, //序号
InUse = objvFeatureAppTypeRelaENS.InUse, //是否在用
UpdDate = objvFeatureAppTypeRelaENS.UpdDate, //修改日期
UpdUser = objvFeatureAppTypeRelaENS.UpdUser, //修改者
Memo = objvFeatureAppTypeRelaENS.Memo, //说明
};
 return objvFeatureAppTypeRelaENT;
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
public static void CheckProperty4Condition(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN)
{
 clsvFeatureAppTypeRelaBL.vFeatureAppTypeRelaDA.CheckProperty4Condition(objvFeatureAppTypeRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.mId) == true)
{
string strComparisonOpmId = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureAppTypeRela.mId, objvFeatureAppTypeRelaCond.mId, strComparisonOpmId);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureAppTypeRela.ApplicationTypeId, objvFeatureAppTypeRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.ApplicationTypeName, objvFeatureAppTypeRelaCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.ApplicationTypeENName) == true)
{
string strComparisonOpApplicationTypeENName = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.ApplicationTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.ApplicationTypeENName, objvFeatureAppTypeRelaCond.ApplicationTypeENName, strComparisonOpApplicationTypeENName);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.FeatureId, objvFeatureAppTypeRelaCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.FeatureName) == true)
{
string strComparisonOpFeatureName = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.FeatureName, objvFeatureAppTypeRelaCond.FeatureName, strComparisonOpFeatureName);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.FeatureTypeName) == true)
{
string strComparisonOpFeatureTypeName = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.FeatureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.FeatureTypeName, objvFeatureAppTypeRelaCond.FeatureTypeName, strComparisonOpFeatureTypeName);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureAppTypeRela.OrderNum, objvFeatureAppTypeRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.InUse) == true)
{
if (objvFeatureAppTypeRelaCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFeatureAppTypeRela.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFeatureAppTypeRela.InUse);
}
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.UpdDate, objvFeatureAppTypeRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.UpdUser, objvFeatureAppTypeRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFeatureAppTypeRelaCond.IsUpdated(convFeatureAppTypeRela.Memo) == true)
{
string strComparisonOpMemo = objvFeatureAppTypeRelaCond.dicFldComparisonOp[convFeatureAppTypeRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureAppTypeRela.Memo, objvFeatureAppTypeRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFeatureAppTypeRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v功能应用关系(vFeatureAppTypeRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureAppTypeRelaBL
{
public static RelatedActions_vFeatureAppTypeRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFeatureAppTypeRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFeatureAppTypeRelaDA vFeatureAppTypeRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFeatureAppTypeRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFeatureAppTypeRelaBL()
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
if (string.IsNullOrEmpty(clsvFeatureAppTypeRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFeatureAppTypeRelaEN._ConnectString);
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
public static DataTable GetDataTable_vFeatureAppTypeRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFeatureAppTypeRelaDA.GetDataTable_vFeatureAppTypeRela(strWhereCond);
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
objDT = vFeatureAppTypeRelaDA.GetDataTable(strWhereCond);
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
objDT = vFeatureAppTypeRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFeatureAppTypeRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFeatureAppTypeRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFeatureAppTypeRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vFeatureAppTypeRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFeatureAppTypeRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFeatureAppTypeRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvFeatureAppTypeRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvFeatureAppTypeRelaEN> arrObjLst = new List<clsvFeatureAppTypeRelaEN>(); 
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
	clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN = new clsvFeatureAppTypeRelaEN();
try
{
objvFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[convFeatureAppTypeRela.mId].ToString().Trim()); //mId
objvFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureAppTypeRelaEN.ApplicationTypeName = objRow[convFeatureAppTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureAppTypeRelaEN.ApplicationTypeENName = objRow[convFeatureAppTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureAppTypeRelaEN.FeatureId = objRow[convFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureAppTypeRelaEN.FeatureName = objRow[convFeatureAppTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureAppTypeRelaEN.FeatureTypeName = objRow[convFeatureAppTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[convFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objvFeatureAppTypeRelaEN.UpdDate = objRow[convFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureAppTypeRelaEN.UpdUser = objRow[convFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureAppTypeRelaEN.Memo = objRow[convFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureAppTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFeatureAppTypeRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvFeatureAppTypeRelaEN._CurrTabName);
List<clsvFeatureAppTypeRelaEN> arrvFeatureAppTypeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureAppTypeRelaEN> arrvFeatureAppTypeRelaObjLst_Sel =
arrvFeatureAppTypeRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvFeatureAppTypeRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureAppTypeRelaEN> GetObjLst(string strWhereCond)
{
List<clsvFeatureAppTypeRelaEN> arrObjLst = new List<clsvFeatureAppTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN = new clsvFeatureAppTypeRelaEN();
try
{
objvFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[convFeatureAppTypeRela.mId].ToString().Trim()); //mId
objvFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureAppTypeRelaEN.ApplicationTypeName = objRow[convFeatureAppTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureAppTypeRelaEN.ApplicationTypeENName = objRow[convFeatureAppTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureAppTypeRelaEN.FeatureId = objRow[convFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureAppTypeRelaEN.FeatureName = objRow[convFeatureAppTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureAppTypeRelaEN.FeatureTypeName = objRow[convFeatureAppTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[convFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objvFeatureAppTypeRelaEN.UpdDate = objRow[convFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureAppTypeRelaEN.UpdUser = objRow[convFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureAppTypeRelaEN.Memo = objRow[convFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureAppTypeRelaEN);
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
public static List<clsvFeatureAppTypeRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureAppTypeRelaEN> arrObjLst = new List<clsvFeatureAppTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN = new clsvFeatureAppTypeRelaEN();
try
{
objvFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[convFeatureAppTypeRela.mId].ToString().Trim()); //mId
objvFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureAppTypeRelaEN.ApplicationTypeName = objRow[convFeatureAppTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureAppTypeRelaEN.ApplicationTypeENName = objRow[convFeatureAppTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureAppTypeRelaEN.FeatureId = objRow[convFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureAppTypeRelaEN.FeatureName = objRow[convFeatureAppTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureAppTypeRelaEN.FeatureTypeName = objRow[convFeatureAppTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[convFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objvFeatureAppTypeRelaEN.UpdDate = objRow[convFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureAppTypeRelaEN.UpdUser = objRow[convFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureAppTypeRelaEN.Memo = objRow[convFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureAppTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFeatureAppTypeRelaEN> GetSubObjLstCache(clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaCond)
{
List<clsvFeatureAppTypeRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureAppTypeRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureAppTypeRela._AttributeName)
{
if (objvFeatureAppTypeRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureAppTypeRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureAppTypeRelaCond[strFldName].ToString());
}
else
{
if (objvFeatureAppTypeRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureAppTypeRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureAppTypeRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureAppTypeRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureAppTypeRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureAppTypeRelaCond[strFldName]));
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
public static List<clsvFeatureAppTypeRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFeatureAppTypeRelaEN> arrObjLst = new List<clsvFeatureAppTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN = new clsvFeatureAppTypeRelaEN();
try
{
objvFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[convFeatureAppTypeRela.mId].ToString().Trim()); //mId
objvFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureAppTypeRelaEN.ApplicationTypeName = objRow[convFeatureAppTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureAppTypeRelaEN.ApplicationTypeENName = objRow[convFeatureAppTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureAppTypeRelaEN.FeatureId = objRow[convFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureAppTypeRelaEN.FeatureName = objRow[convFeatureAppTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureAppTypeRelaEN.FeatureTypeName = objRow[convFeatureAppTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[convFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objvFeatureAppTypeRelaEN.UpdDate = objRow[convFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureAppTypeRelaEN.UpdUser = objRow[convFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureAppTypeRelaEN.Memo = objRow[convFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureAppTypeRelaEN);
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
public static List<clsvFeatureAppTypeRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFeatureAppTypeRelaEN> arrObjLst = new List<clsvFeatureAppTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN = new clsvFeatureAppTypeRelaEN();
try
{
objvFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[convFeatureAppTypeRela.mId].ToString().Trim()); //mId
objvFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureAppTypeRelaEN.ApplicationTypeName = objRow[convFeatureAppTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureAppTypeRelaEN.ApplicationTypeENName = objRow[convFeatureAppTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureAppTypeRelaEN.FeatureId = objRow[convFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureAppTypeRelaEN.FeatureName = objRow[convFeatureAppTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureAppTypeRelaEN.FeatureTypeName = objRow[convFeatureAppTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[convFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objvFeatureAppTypeRelaEN.UpdDate = objRow[convFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureAppTypeRelaEN.UpdUser = objRow[convFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureAppTypeRelaEN.Memo = objRow[convFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureAppTypeRelaEN);
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
List<clsvFeatureAppTypeRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFeatureAppTypeRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureAppTypeRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFeatureAppTypeRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureAppTypeRelaEN> arrObjLst = new List<clsvFeatureAppTypeRelaEN>(); 
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
	clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN = new clsvFeatureAppTypeRelaEN();
try
{
objvFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[convFeatureAppTypeRela.mId].ToString().Trim()); //mId
objvFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureAppTypeRelaEN.ApplicationTypeName = objRow[convFeatureAppTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureAppTypeRelaEN.ApplicationTypeENName = objRow[convFeatureAppTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureAppTypeRelaEN.FeatureId = objRow[convFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureAppTypeRelaEN.FeatureName = objRow[convFeatureAppTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureAppTypeRelaEN.FeatureTypeName = objRow[convFeatureAppTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[convFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objvFeatureAppTypeRelaEN.UpdDate = objRow[convFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureAppTypeRelaEN.UpdUser = objRow[convFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureAppTypeRelaEN.Memo = objRow[convFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureAppTypeRelaEN);
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
public static List<clsvFeatureAppTypeRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureAppTypeRelaEN> arrObjLst = new List<clsvFeatureAppTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN = new clsvFeatureAppTypeRelaEN();
try
{
objvFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[convFeatureAppTypeRela.mId].ToString().Trim()); //mId
objvFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureAppTypeRelaEN.ApplicationTypeName = objRow[convFeatureAppTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureAppTypeRelaEN.ApplicationTypeENName = objRow[convFeatureAppTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureAppTypeRelaEN.FeatureId = objRow[convFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureAppTypeRelaEN.FeatureName = objRow[convFeatureAppTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureAppTypeRelaEN.FeatureTypeName = objRow[convFeatureAppTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[convFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objvFeatureAppTypeRelaEN.UpdDate = objRow[convFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureAppTypeRelaEN.UpdUser = objRow[convFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureAppTypeRelaEN.Memo = objRow[convFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureAppTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFeatureAppTypeRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFeatureAppTypeRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureAppTypeRelaEN> arrObjLst = new List<clsvFeatureAppTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN = new clsvFeatureAppTypeRelaEN();
try
{
objvFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[convFeatureAppTypeRela.mId].ToString().Trim()); //mId
objvFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureAppTypeRelaEN.ApplicationTypeName = objRow[convFeatureAppTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureAppTypeRelaEN.ApplicationTypeENName = objRow[convFeatureAppTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureAppTypeRelaEN.FeatureId = objRow[convFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureAppTypeRelaEN.FeatureName = objRow[convFeatureAppTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureAppTypeRelaEN.FeatureTypeName = objRow[convFeatureAppTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[convFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objvFeatureAppTypeRelaEN.UpdDate = objRow[convFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureAppTypeRelaEN.UpdUser = objRow[convFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureAppTypeRelaEN.Memo = objRow[convFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureAppTypeRelaEN);
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
public static List<clsvFeatureAppTypeRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFeatureAppTypeRelaEN> arrObjLst = new List<clsvFeatureAppTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN = new clsvFeatureAppTypeRelaEN();
try
{
objvFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[convFeatureAppTypeRela.mId].ToString().Trim()); //mId
objvFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureAppTypeRelaEN.ApplicationTypeName = objRow[convFeatureAppTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureAppTypeRelaEN.ApplicationTypeENName = objRow[convFeatureAppTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureAppTypeRelaEN.FeatureId = objRow[convFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureAppTypeRelaEN.FeatureName = objRow[convFeatureAppTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureAppTypeRelaEN.FeatureTypeName = objRow[convFeatureAppTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[convFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objvFeatureAppTypeRelaEN.UpdDate = objRow[convFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureAppTypeRelaEN.UpdUser = objRow[convFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureAppTypeRelaEN.Memo = objRow[convFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureAppTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureAppTypeRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFeatureAppTypeRelaEN> arrObjLst = new List<clsvFeatureAppTypeRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN = new clsvFeatureAppTypeRelaEN();
try
{
objvFeatureAppTypeRelaEN.mId = Int32.Parse(objRow[convFeatureAppTypeRela.mId].ToString().Trim()); //mId
objvFeatureAppTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureAppTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureAppTypeRelaEN.ApplicationTypeName = objRow[convFeatureAppTypeRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureAppTypeRelaEN.ApplicationTypeENName = objRow[convFeatureAppTypeRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureAppTypeRelaEN.FeatureId = objRow[convFeatureAppTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureAppTypeRelaEN.FeatureName = objRow[convFeatureAppTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureAppTypeRelaEN.FeatureTypeName = objRow[convFeatureAppTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureAppTypeRelaEN.OrderNum = Int32.Parse(objRow[convFeatureAppTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureAppTypeRelaEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFeatureAppTypeRela.InUse].ToString().Trim()); //是否在用
objvFeatureAppTypeRelaEN.UpdDate = objRow[convFeatureAppTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureAppTypeRelaEN.UpdUser = objRow[convFeatureAppTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureAppTypeRelaEN.Memo = objRow[convFeatureAppTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureAppTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureAppTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureAppTypeRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFeatureAppTypeRela(ref clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN)
{
bool bolResult = vFeatureAppTypeRelaDA.GetvFeatureAppTypeRela(ref objvFeatureAppTypeRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureAppTypeRelaEN GetObjBymId(long lngmId)
{
clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN = vFeatureAppTypeRelaDA.GetObjBymId(lngmId);
return objvFeatureAppTypeRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFeatureAppTypeRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN = vFeatureAppTypeRelaDA.GetFirstObj(strWhereCond);
 return objvFeatureAppTypeRelaEN;
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
public static clsvFeatureAppTypeRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN = vFeatureAppTypeRelaDA.GetObjByDataRow(objRow);
 return objvFeatureAppTypeRelaEN;
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
public static clsvFeatureAppTypeRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN = vFeatureAppTypeRelaDA.GetObjByDataRow(objRow);
 return objvFeatureAppTypeRelaEN;
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
 /// <param name = "lstvFeatureAppTypeRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureAppTypeRelaEN GetObjBymIdFromList(long lngmId, List<clsvFeatureAppTypeRelaEN> lstvFeatureAppTypeRelaObjLst)
{
foreach (clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN in lstvFeatureAppTypeRelaObjLst)
{
if (objvFeatureAppTypeRelaEN.mId == lngmId)
{
return objvFeatureAppTypeRelaEN;
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
 lngmId = new clsvFeatureAppTypeRelaDA().GetFirstID(strWhereCond);
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
 arrList = vFeatureAppTypeRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vFeatureAppTypeRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vFeatureAppTypeRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvFeatureAppTypeRelaDA.IsExistTable();
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
 bolIsExist = vFeatureAppTypeRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvFeatureAppTypeRelaENS">源对象</param>
 /// <param name = "objvFeatureAppTypeRelaENT">目标对象</param>
 public static void CopyTo(clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaENS, clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaENT)
{
try
{
objvFeatureAppTypeRelaENT.mId = objvFeatureAppTypeRelaENS.mId; //mId
objvFeatureAppTypeRelaENT.ApplicationTypeId = objvFeatureAppTypeRelaENS.ApplicationTypeId; //应用程序类型ID
objvFeatureAppTypeRelaENT.ApplicationTypeName = objvFeatureAppTypeRelaENS.ApplicationTypeName; //应用程序类型名称
objvFeatureAppTypeRelaENT.ApplicationTypeENName = objvFeatureAppTypeRelaENS.ApplicationTypeENName; //应用类型英文名
objvFeatureAppTypeRelaENT.FeatureId = objvFeatureAppTypeRelaENS.FeatureId; //功能Id
objvFeatureAppTypeRelaENT.FeatureName = objvFeatureAppTypeRelaENS.FeatureName; //功能名称
objvFeatureAppTypeRelaENT.FeatureTypeName = objvFeatureAppTypeRelaENS.FeatureTypeName; //功能类型名称
objvFeatureAppTypeRelaENT.OrderNum = objvFeatureAppTypeRelaENS.OrderNum; //序号
objvFeatureAppTypeRelaENT.InUse = objvFeatureAppTypeRelaENS.InUse; //是否在用
objvFeatureAppTypeRelaENT.UpdDate = objvFeatureAppTypeRelaENS.UpdDate; //修改日期
objvFeatureAppTypeRelaENT.UpdUser = objvFeatureAppTypeRelaENS.UpdUser; //修改者
objvFeatureAppTypeRelaENT.Memo = objvFeatureAppTypeRelaENS.Memo; //说明
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
 /// <param name = "objvFeatureAppTypeRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN)
{
try
{
objvFeatureAppTypeRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFeatureAppTypeRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFeatureAppTypeRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureAppTypeRelaEN.mId = objvFeatureAppTypeRelaEN.mId; //mId
}
if (arrFldSet.Contains(convFeatureAppTypeRela.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureAppTypeRelaEN.ApplicationTypeId = objvFeatureAppTypeRelaEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convFeatureAppTypeRela.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureAppTypeRelaEN.ApplicationTypeName = objvFeatureAppTypeRelaEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(convFeatureAppTypeRela.ApplicationTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureAppTypeRelaEN.ApplicationTypeENName = objvFeatureAppTypeRelaEN.ApplicationTypeENName; //应用类型英文名
}
if (arrFldSet.Contains(convFeatureAppTypeRela.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureAppTypeRelaEN.FeatureId = objvFeatureAppTypeRelaEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convFeatureAppTypeRela.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureAppTypeRelaEN.FeatureName = objvFeatureAppTypeRelaEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convFeatureAppTypeRela.FeatureTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureAppTypeRelaEN.FeatureTypeName = objvFeatureAppTypeRelaEN.FeatureTypeName; //功能类型名称
}
if (arrFldSet.Contains(convFeatureAppTypeRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureAppTypeRelaEN.OrderNum = objvFeatureAppTypeRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convFeatureAppTypeRela.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureAppTypeRelaEN.InUse = objvFeatureAppTypeRelaEN.InUse; //是否在用
}
if (arrFldSet.Contains(convFeatureAppTypeRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureAppTypeRelaEN.UpdDate = objvFeatureAppTypeRelaEN.UpdDate == "[null]" ? null :  objvFeatureAppTypeRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFeatureAppTypeRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureAppTypeRelaEN.UpdUser = objvFeatureAppTypeRelaEN.UpdUser == "[null]" ? null :  objvFeatureAppTypeRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFeatureAppTypeRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureAppTypeRelaEN.Memo = objvFeatureAppTypeRelaEN.Memo == "[null]" ? null :  objvFeatureAppTypeRelaEN.Memo; //说明
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
 /// <param name = "objvFeatureAppTypeRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN)
{
try
{
if (objvFeatureAppTypeRelaEN.UpdDate == "[null]") objvFeatureAppTypeRelaEN.UpdDate = null; //修改日期
if (objvFeatureAppTypeRelaEN.UpdUser == "[null]") objvFeatureAppTypeRelaEN.UpdUser = null; //修改者
if (objvFeatureAppTypeRelaEN.Memo == "[null]") objvFeatureAppTypeRelaEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaEN)
{
 vFeatureAppTypeRelaDA.CheckProperty4Condition(objvFeatureAppTypeRelaEN);
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
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFeatureAppTypeRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFeatureAppTypeRelaBL没有刷新缓存机制(clsFeatureAppTypeRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvFeatureAppTypeRelaObjLstCache == null)
//{
//arrvFeatureAppTypeRelaObjLstCache = vFeatureAppTypeRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureAppTypeRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFeatureAppTypeRelaEN._CurrTabName);
List<clsvFeatureAppTypeRelaEN> arrvFeatureAppTypeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureAppTypeRelaEN> arrvFeatureAppTypeRelaObjLst_Sel =
arrvFeatureAppTypeRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvFeatureAppTypeRelaObjLst_Sel.Count() == 0)
{
   clsvFeatureAppTypeRelaEN obj = clsvFeatureAppTypeRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFeatureAppTypeRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureAppTypeRelaEN> GetAllvFeatureAppTypeRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvFeatureAppTypeRelaEN> arrvFeatureAppTypeRelaObjLstCache = GetObjLstCache(); 
return arrvFeatureAppTypeRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureAppTypeRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFeatureAppTypeRelaEN._CurrTabName);
List<clsvFeatureAppTypeRelaEN> arrvFeatureAppTypeRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFeatureAppTypeRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvFeatureAppTypeRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFeatureAppTypeRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFeatureAppTypeRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvFeatureAppTypeRelaEN._RefreshTimeLst[clsvFeatureAppTypeRelaEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convFeatureAppTypeRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFeatureAppTypeRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFeatureAppTypeRela._AttributeName));
throw new Exception(strMsg);
}
var objvFeatureAppTypeRela = clsvFeatureAppTypeRelaBL.GetObjBymIdCache(lngmId);
if (objvFeatureAppTypeRela == null) return "";
return objvFeatureAppTypeRela[strOutFldName].ToString();
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
int intRecCount = clsvFeatureAppTypeRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvFeatureAppTypeRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFeatureAppTypeRelaDA.GetRecCount();
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
int intRecCount = clsvFeatureAppTypeRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFeatureAppTypeRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFeatureAppTypeRelaEN objvFeatureAppTypeRelaCond)
{
List<clsvFeatureAppTypeRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureAppTypeRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureAppTypeRela._AttributeName)
{
if (objvFeatureAppTypeRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureAppTypeRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureAppTypeRelaCond[strFldName].ToString());
}
else
{
if (objvFeatureAppTypeRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureAppTypeRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureAppTypeRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureAppTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureAppTypeRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureAppTypeRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureAppTypeRelaCond[strFldName]));
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
 List<string> arrList = clsvFeatureAppTypeRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFeatureAppTypeRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFeatureAppTypeRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}