
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureFieldTypeRelaBL
 表名:vFeatureFieldTypeRela(00050458)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:19
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvFeatureFieldTypeRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureFieldTypeRelaEN GetObj(this K_mId_vFeatureFieldTypeRela myKey)
{
clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = clsvFeatureFieldTypeRelaBL.vFeatureFieldTypeRelaDA.GetObjBymId(myKey.Value);
return objvFeatureFieldTypeRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetmId(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, long lngmId, string strComparisonOp="")
	{
objvFeatureFieldTypeRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.mId) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.mId, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.mId] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetFeatureId(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFeatureFieldTypeRela.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFeatureFieldTypeRela.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFeatureFieldTypeRela.FeatureId);
}
objvFeatureFieldTypeRelaEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.FeatureId) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.FeatureId, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.FeatureId] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetFeatureName(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convFeatureFieldTypeRela.FeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFeatureFieldTypeRela.FeatureName);
}
objvFeatureFieldTypeRelaEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.FeatureName) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.FeatureName, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.FeatureName] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetKeyWords(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strKeyWords, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyWords, 500, convFeatureFieldTypeRela.KeyWords);
}
objvFeatureFieldTypeRelaEN.KeyWords = strKeyWords; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.KeyWords) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.KeyWords, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.KeyWords] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetFeatureTypeName(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convFeatureFieldTypeRela.FeatureTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convFeatureFieldTypeRela.FeatureTypeName);
}
objvFeatureFieldTypeRelaEN.FeatureTypeName = strFeatureTypeName; //功能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.FeatureTypeName) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.FeatureTypeName, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.FeatureTypeName] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetFieldTypeId(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strFieldTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convFeatureFieldTypeRela.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convFeatureFieldTypeRela.FieldTypeId);
}
objvFeatureFieldTypeRelaEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.FieldTypeId) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.FieldTypeId, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.FieldTypeId] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetFieldTypeName(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strFieldTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeName, 30, convFeatureFieldTypeRela.FieldTypeName);
}
objvFeatureFieldTypeRelaEN.FieldTypeName = strFieldTypeName; //字段类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.FieldTypeName) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.FieldTypeName, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.FieldTypeName] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetFieldTypeENName(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strFieldTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeENName, 30, convFeatureFieldTypeRela.FieldTypeENName);
}
objvFeatureFieldTypeRelaEN.FieldTypeENName = strFieldTypeENName; //字段类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.FieldTypeENName) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.FieldTypeENName, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.FieldTypeENName] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetOrderNum(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objvFeatureFieldTypeRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.OrderNum) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.OrderNum, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.OrderNum] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetUpdDate(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFeatureFieldTypeRela.UpdDate);
}
objvFeatureFieldTypeRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.UpdDate) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.UpdDate, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.UpdDate] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetUpdUser(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFeatureFieldTypeRela.UpdUser);
}
objvFeatureFieldTypeRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.UpdUser) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.UpdUser, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.UpdUser] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFieldTypeRelaEN SetMemo(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFeatureFieldTypeRela.Memo);
}
objvFeatureFieldTypeRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFieldTypeRelaEN.dicFldComparisonOp.ContainsKey(convFeatureFieldTypeRela.Memo) == false)
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp.Add(convFeatureFieldTypeRela.Memo, strComparisonOp);
}
else
{
objvFeatureFieldTypeRelaEN.dicFldComparisonOp[convFeatureFieldTypeRela.Memo] = strComparisonOp;
}
}
return objvFeatureFieldTypeRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaENS">源对象</param>
 /// <param name = "objvFeatureFieldTypeRelaENT">目标对象</param>
 public static void CopyTo(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaENS, clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaENT)
{
try
{
objvFeatureFieldTypeRelaENT.mId = objvFeatureFieldTypeRelaENS.mId; //mId
objvFeatureFieldTypeRelaENT.FeatureId = objvFeatureFieldTypeRelaENS.FeatureId; //功能Id
objvFeatureFieldTypeRelaENT.FeatureName = objvFeatureFieldTypeRelaENS.FeatureName; //功能名称
objvFeatureFieldTypeRelaENT.KeyWords = objvFeatureFieldTypeRelaENS.KeyWords; //关键字
objvFeatureFieldTypeRelaENT.FeatureTypeName = objvFeatureFieldTypeRelaENS.FeatureTypeName; //功能类型名称
objvFeatureFieldTypeRelaENT.FieldTypeId = objvFeatureFieldTypeRelaENS.FieldTypeId; //字段类型Id
objvFeatureFieldTypeRelaENT.FieldTypeName = objvFeatureFieldTypeRelaENS.FieldTypeName; //字段类型名
objvFeatureFieldTypeRelaENT.FieldTypeENName = objvFeatureFieldTypeRelaENS.FieldTypeENName; //字段类型英文名
objvFeatureFieldTypeRelaENT.OrderNum = objvFeatureFieldTypeRelaENS.OrderNum; //序号
objvFeatureFieldTypeRelaENT.UpdDate = objvFeatureFieldTypeRelaENS.UpdDate; //修改日期
objvFeatureFieldTypeRelaENT.UpdUser = objvFeatureFieldTypeRelaENS.UpdUser; //修改者
objvFeatureFieldTypeRelaENT.Memo = objvFeatureFieldTypeRelaENS.Memo; //说明
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
 /// <param name = "objvFeatureFieldTypeRelaENS">源对象</param>
 /// <returns>目标对象=>clsvFeatureFieldTypeRelaEN:objvFeatureFieldTypeRelaENT</returns>
 public static clsvFeatureFieldTypeRelaEN CopyTo(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaENS)
{
try
{
 clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaENT = new clsvFeatureFieldTypeRelaEN()
{
mId = objvFeatureFieldTypeRelaENS.mId, //mId
FeatureId = objvFeatureFieldTypeRelaENS.FeatureId, //功能Id
FeatureName = objvFeatureFieldTypeRelaENS.FeatureName, //功能名称
KeyWords = objvFeatureFieldTypeRelaENS.KeyWords, //关键字
FeatureTypeName = objvFeatureFieldTypeRelaENS.FeatureTypeName, //功能类型名称
FieldTypeId = objvFeatureFieldTypeRelaENS.FieldTypeId, //字段类型Id
FieldTypeName = objvFeatureFieldTypeRelaENS.FieldTypeName, //字段类型名
FieldTypeENName = objvFeatureFieldTypeRelaENS.FieldTypeENName, //字段类型英文名
OrderNum = objvFeatureFieldTypeRelaENS.OrderNum, //序号
UpdDate = objvFeatureFieldTypeRelaENS.UpdDate, //修改日期
UpdUser = objvFeatureFieldTypeRelaENS.UpdUser, //修改者
Memo = objvFeatureFieldTypeRelaENS.Memo, //说明
};
 return objvFeatureFieldTypeRelaENT;
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
public static void CheckProperty4Condition(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN)
{
 clsvFeatureFieldTypeRelaBL.vFeatureFieldTypeRelaDA.CheckProperty4Condition(objvFeatureFieldTypeRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.mId) == true)
{
string strComparisonOpmId = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureFieldTypeRela.mId, objvFeatureFieldTypeRelaCond.mId, strComparisonOpmId);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.FeatureId, objvFeatureFieldTypeRelaCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.FeatureName) == true)
{
string strComparisonOpFeatureName = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.FeatureName, objvFeatureFieldTypeRelaCond.FeatureName, strComparisonOpFeatureName);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.KeyWords) == true)
{
string strComparisonOpKeyWords = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.KeyWords];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.KeyWords, objvFeatureFieldTypeRelaCond.KeyWords, strComparisonOpKeyWords);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.FeatureTypeName) == true)
{
string strComparisonOpFeatureTypeName = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.FeatureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.FeatureTypeName, objvFeatureFieldTypeRelaCond.FeatureTypeName, strComparisonOpFeatureTypeName);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.FieldTypeId, objvFeatureFieldTypeRelaCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.FieldTypeName) == true)
{
string strComparisonOpFieldTypeName = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.FieldTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.FieldTypeName, objvFeatureFieldTypeRelaCond.FieldTypeName, strComparisonOpFieldTypeName);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.FieldTypeENName) == true)
{
string strComparisonOpFieldTypeENName = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.FieldTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.FieldTypeENName, objvFeatureFieldTypeRelaCond.FieldTypeENName, strComparisonOpFieldTypeENName);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureFieldTypeRela.OrderNum, objvFeatureFieldTypeRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.UpdDate, objvFeatureFieldTypeRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.UpdUser, objvFeatureFieldTypeRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFeatureFieldTypeRelaCond.IsUpdated(convFeatureFieldTypeRela.Memo) == true)
{
string strComparisonOpMemo = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[convFeatureFieldTypeRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFieldTypeRela.Memo, objvFeatureFieldTypeRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFeatureFieldTypeRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v功能字段类型关系(vFeatureFieldTypeRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureFieldTypeRelaBL
{
public static RelatedActions_vFeatureFieldTypeRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFeatureFieldTypeRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFeatureFieldTypeRelaDA vFeatureFieldTypeRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFeatureFieldTypeRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFeatureFieldTypeRelaBL()
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
if (string.IsNullOrEmpty(clsvFeatureFieldTypeRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFeatureFieldTypeRelaEN._ConnectString);
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
public static DataTable GetDataTable_vFeatureFieldTypeRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFeatureFieldTypeRelaDA.GetDataTable_vFeatureFieldTypeRela(strWhereCond);
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
objDT = vFeatureFieldTypeRelaDA.GetDataTable(strWhereCond);
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
objDT = vFeatureFieldTypeRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFeatureFieldTypeRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFeatureFieldTypeRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFeatureFieldTypeRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vFeatureFieldTypeRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFeatureFieldTypeRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFeatureFieldTypeRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvFeatureFieldTypeRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvFeatureFieldTypeRelaEN> arrObjLst = new List<clsvFeatureFieldTypeRelaEN>(); 
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
	clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = new clsvFeatureFieldTypeRelaEN();
try
{
objvFeatureFieldTypeRelaEN.mId = Int32.Parse(objRow[convFeatureFieldTypeRela.mId].ToString().Trim()); //mId
objvFeatureFieldTypeRelaEN.FeatureId = objRow[convFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFieldTypeRelaEN.FeatureName = objRow[convFeatureFieldTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFieldTypeRelaEN.KeyWords = objRow[convFeatureFieldTypeRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFieldTypeRelaEN.FeatureTypeName = objRow[convFeatureFieldTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFieldTypeRelaEN.FieldTypeId = objRow[convFeatureFieldTypeRela.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureFieldTypeRelaEN.FieldTypeName = objRow[convFeatureFieldTypeRela.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureFieldTypeRelaEN.FieldTypeENName = objRow[convFeatureFieldTypeRela.FieldTypeENName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFeatureFieldTypeRelaEN.OrderNum = objRow[convFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureFieldTypeRelaEN.UpdDate = objRow[convFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFieldTypeRelaEN.UpdUser = objRow[convFeatureFieldTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFieldTypeRelaEN.Memo = objRow[convFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFieldTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFieldTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFeatureFieldTypeRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvFeatureFieldTypeRelaEN._CurrTabName);
List<clsvFeatureFieldTypeRelaEN> arrvFeatureFieldTypeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureFieldTypeRelaEN> arrvFeatureFieldTypeRelaObjLst_Sel =
arrvFeatureFieldTypeRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvFeatureFieldTypeRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureFieldTypeRelaEN> GetObjLst(string strWhereCond)
{
List<clsvFeatureFieldTypeRelaEN> arrObjLst = new List<clsvFeatureFieldTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = new clsvFeatureFieldTypeRelaEN();
try
{
objvFeatureFieldTypeRelaEN.mId = Int32.Parse(objRow[convFeatureFieldTypeRela.mId].ToString().Trim()); //mId
objvFeatureFieldTypeRelaEN.FeatureId = objRow[convFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFieldTypeRelaEN.FeatureName = objRow[convFeatureFieldTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFieldTypeRelaEN.KeyWords = objRow[convFeatureFieldTypeRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFieldTypeRelaEN.FeatureTypeName = objRow[convFeatureFieldTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFieldTypeRelaEN.FieldTypeId = objRow[convFeatureFieldTypeRela.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureFieldTypeRelaEN.FieldTypeName = objRow[convFeatureFieldTypeRela.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureFieldTypeRelaEN.FieldTypeENName = objRow[convFeatureFieldTypeRela.FieldTypeENName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFeatureFieldTypeRelaEN.OrderNum = objRow[convFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureFieldTypeRelaEN.UpdDate = objRow[convFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFieldTypeRelaEN.UpdUser = objRow[convFeatureFieldTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFieldTypeRelaEN.Memo = objRow[convFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFieldTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFieldTypeRelaEN);
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
public static List<clsvFeatureFieldTypeRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureFieldTypeRelaEN> arrObjLst = new List<clsvFeatureFieldTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = new clsvFeatureFieldTypeRelaEN();
try
{
objvFeatureFieldTypeRelaEN.mId = Int32.Parse(objRow[convFeatureFieldTypeRela.mId].ToString().Trim()); //mId
objvFeatureFieldTypeRelaEN.FeatureId = objRow[convFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFieldTypeRelaEN.FeatureName = objRow[convFeatureFieldTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFieldTypeRelaEN.KeyWords = objRow[convFeatureFieldTypeRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFieldTypeRelaEN.FeatureTypeName = objRow[convFeatureFieldTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFieldTypeRelaEN.FieldTypeId = objRow[convFeatureFieldTypeRela.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureFieldTypeRelaEN.FieldTypeName = objRow[convFeatureFieldTypeRela.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureFieldTypeRelaEN.FieldTypeENName = objRow[convFeatureFieldTypeRela.FieldTypeENName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFeatureFieldTypeRelaEN.OrderNum = objRow[convFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureFieldTypeRelaEN.UpdDate = objRow[convFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFieldTypeRelaEN.UpdUser = objRow[convFeatureFieldTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFieldTypeRelaEN.Memo = objRow[convFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFieldTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFieldTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFeatureFieldTypeRelaEN> GetSubObjLstCache(clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaCond)
{
List<clsvFeatureFieldTypeRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureFieldTypeRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureFieldTypeRela._AttributeName)
{
if (objvFeatureFieldTypeRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureFieldTypeRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureFieldTypeRelaCond[strFldName].ToString());
}
else
{
if (objvFeatureFieldTypeRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureFieldTypeRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureFieldTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureFieldTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureFieldTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureFieldTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureFieldTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureFieldTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureFieldTypeRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureFieldTypeRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureFieldTypeRelaCond[strFldName]));
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
public static List<clsvFeatureFieldTypeRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFeatureFieldTypeRelaEN> arrObjLst = new List<clsvFeatureFieldTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = new clsvFeatureFieldTypeRelaEN();
try
{
objvFeatureFieldTypeRelaEN.mId = Int32.Parse(objRow[convFeatureFieldTypeRela.mId].ToString().Trim()); //mId
objvFeatureFieldTypeRelaEN.FeatureId = objRow[convFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFieldTypeRelaEN.FeatureName = objRow[convFeatureFieldTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFieldTypeRelaEN.KeyWords = objRow[convFeatureFieldTypeRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFieldTypeRelaEN.FeatureTypeName = objRow[convFeatureFieldTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFieldTypeRelaEN.FieldTypeId = objRow[convFeatureFieldTypeRela.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureFieldTypeRelaEN.FieldTypeName = objRow[convFeatureFieldTypeRela.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureFieldTypeRelaEN.FieldTypeENName = objRow[convFeatureFieldTypeRela.FieldTypeENName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFeatureFieldTypeRelaEN.OrderNum = objRow[convFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureFieldTypeRelaEN.UpdDate = objRow[convFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFieldTypeRelaEN.UpdUser = objRow[convFeatureFieldTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFieldTypeRelaEN.Memo = objRow[convFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFieldTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFieldTypeRelaEN);
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
public static List<clsvFeatureFieldTypeRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFeatureFieldTypeRelaEN> arrObjLst = new List<clsvFeatureFieldTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = new clsvFeatureFieldTypeRelaEN();
try
{
objvFeatureFieldTypeRelaEN.mId = Int32.Parse(objRow[convFeatureFieldTypeRela.mId].ToString().Trim()); //mId
objvFeatureFieldTypeRelaEN.FeatureId = objRow[convFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFieldTypeRelaEN.FeatureName = objRow[convFeatureFieldTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFieldTypeRelaEN.KeyWords = objRow[convFeatureFieldTypeRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFieldTypeRelaEN.FeatureTypeName = objRow[convFeatureFieldTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFieldTypeRelaEN.FieldTypeId = objRow[convFeatureFieldTypeRela.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureFieldTypeRelaEN.FieldTypeName = objRow[convFeatureFieldTypeRela.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureFieldTypeRelaEN.FieldTypeENName = objRow[convFeatureFieldTypeRela.FieldTypeENName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFeatureFieldTypeRelaEN.OrderNum = objRow[convFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureFieldTypeRelaEN.UpdDate = objRow[convFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFieldTypeRelaEN.UpdUser = objRow[convFeatureFieldTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFieldTypeRelaEN.Memo = objRow[convFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFieldTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFieldTypeRelaEN);
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
List<clsvFeatureFieldTypeRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFeatureFieldTypeRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureFieldTypeRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFeatureFieldTypeRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureFieldTypeRelaEN> arrObjLst = new List<clsvFeatureFieldTypeRelaEN>(); 
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
	clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = new clsvFeatureFieldTypeRelaEN();
try
{
objvFeatureFieldTypeRelaEN.mId = Int32.Parse(objRow[convFeatureFieldTypeRela.mId].ToString().Trim()); //mId
objvFeatureFieldTypeRelaEN.FeatureId = objRow[convFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFieldTypeRelaEN.FeatureName = objRow[convFeatureFieldTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFieldTypeRelaEN.KeyWords = objRow[convFeatureFieldTypeRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFieldTypeRelaEN.FeatureTypeName = objRow[convFeatureFieldTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFieldTypeRelaEN.FieldTypeId = objRow[convFeatureFieldTypeRela.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureFieldTypeRelaEN.FieldTypeName = objRow[convFeatureFieldTypeRela.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureFieldTypeRelaEN.FieldTypeENName = objRow[convFeatureFieldTypeRela.FieldTypeENName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFeatureFieldTypeRelaEN.OrderNum = objRow[convFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureFieldTypeRelaEN.UpdDate = objRow[convFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFieldTypeRelaEN.UpdUser = objRow[convFeatureFieldTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFieldTypeRelaEN.Memo = objRow[convFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFieldTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFieldTypeRelaEN);
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
public static List<clsvFeatureFieldTypeRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureFieldTypeRelaEN> arrObjLst = new List<clsvFeatureFieldTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = new clsvFeatureFieldTypeRelaEN();
try
{
objvFeatureFieldTypeRelaEN.mId = Int32.Parse(objRow[convFeatureFieldTypeRela.mId].ToString().Trim()); //mId
objvFeatureFieldTypeRelaEN.FeatureId = objRow[convFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFieldTypeRelaEN.FeatureName = objRow[convFeatureFieldTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFieldTypeRelaEN.KeyWords = objRow[convFeatureFieldTypeRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFieldTypeRelaEN.FeatureTypeName = objRow[convFeatureFieldTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFieldTypeRelaEN.FieldTypeId = objRow[convFeatureFieldTypeRela.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureFieldTypeRelaEN.FieldTypeName = objRow[convFeatureFieldTypeRela.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureFieldTypeRelaEN.FieldTypeENName = objRow[convFeatureFieldTypeRela.FieldTypeENName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFeatureFieldTypeRelaEN.OrderNum = objRow[convFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureFieldTypeRelaEN.UpdDate = objRow[convFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFieldTypeRelaEN.UpdUser = objRow[convFeatureFieldTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFieldTypeRelaEN.Memo = objRow[convFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFieldTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFieldTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFeatureFieldTypeRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFeatureFieldTypeRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureFieldTypeRelaEN> arrObjLst = new List<clsvFeatureFieldTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = new clsvFeatureFieldTypeRelaEN();
try
{
objvFeatureFieldTypeRelaEN.mId = Int32.Parse(objRow[convFeatureFieldTypeRela.mId].ToString().Trim()); //mId
objvFeatureFieldTypeRelaEN.FeatureId = objRow[convFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFieldTypeRelaEN.FeatureName = objRow[convFeatureFieldTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFieldTypeRelaEN.KeyWords = objRow[convFeatureFieldTypeRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFieldTypeRelaEN.FeatureTypeName = objRow[convFeatureFieldTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFieldTypeRelaEN.FieldTypeId = objRow[convFeatureFieldTypeRela.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureFieldTypeRelaEN.FieldTypeName = objRow[convFeatureFieldTypeRela.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureFieldTypeRelaEN.FieldTypeENName = objRow[convFeatureFieldTypeRela.FieldTypeENName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFeatureFieldTypeRelaEN.OrderNum = objRow[convFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureFieldTypeRelaEN.UpdDate = objRow[convFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFieldTypeRelaEN.UpdUser = objRow[convFeatureFieldTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFieldTypeRelaEN.Memo = objRow[convFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFieldTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFieldTypeRelaEN);
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
public static List<clsvFeatureFieldTypeRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFeatureFieldTypeRelaEN> arrObjLst = new List<clsvFeatureFieldTypeRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = new clsvFeatureFieldTypeRelaEN();
try
{
objvFeatureFieldTypeRelaEN.mId = Int32.Parse(objRow[convFeatureFieldTypeRela.mId].ToString().Trim()); //mId
objvFeatureFieldTypeRelaEN.FeatureId = objRow[convFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFieldTypeRelaEN.FeatureName = objRow[convFeatureFieldTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFieldTypeRelaEN.KeyWords = objRow[convFeatureFieldTypeRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFieldTypeRelaEN.FeatureTypeName = objRow[convFeatureFieldTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFieldTypeRelaEN.FieldTypeId = objRow[convFeatureFieldTypeRela.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureFieldTypeRelaEN.FieldTypeName = objRow[convFeatureFieldTypeRela.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureFieldTypeRelaEN.FieldTypeENName = objRow[convFeatureFieldTypeRela.FieldTypeENName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFeatureFieldTypeRelaEN.OrderNum = objRow[convFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureFieldTypeRelaEN.UpdDate = objRow[convFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFieldTypeRelaEN.UpdUser = objRow[convFeatureFieldTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFieldTypeRelaEN.Memo = objRow[convFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFieldTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFieldTypeRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureFieldTypeRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFeatureFieldTypeRelaEN> arrObjLst = new List<clsvFeatureFieldTypeRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = new clsvFeatureFieldTypeRelaEN();
try
{
objvFeatureFieldTypeRelaEN.mId = Int32.Parse(objRow[convFeatureFieldTypeRela.mId].ToString().Trim()); //mId
objvFeatureFieldTypeRelaEN.FeatureId = objRow[convFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureFieldTypeRelaEN.FeatureName = objRow[convFeatureFieldTypeRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureFieldTypeRelaEN.KeyWords = objRow[convFeatureFieldTypeRela.KeyWords] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.KeyWords].ToString().Trim(); //关键字
objvFeatureFieldTypeRelaEN.FeatureTypeName = objRow[convFeatureFieldTypeRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureFieldTypeRelaEN.FieldTypeId = objRow[convFeatureFieldTypeRela.FieldTypeId] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id
objvFeatureFieldTypeRelaEN.FieldTypeName = objRow[convFeatureFieldTypeRela.FieldTypeName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeName].ToString().Trim(); //字段类型名
objvFeatureFieldTypeRelaEN.FieldTypeENName = objRow[convFeatureFieldTypeRela.FieldTypeENName] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.FieldTypeENName].ToString().Trim(); //字段类型英文名
objvFeatureFieldTypeRelaEN.OrderNum = objRow[convFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号
objvFeatureFieldTypeRelaEN.UpdDate = objRow[convFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureFieldTypeRelaEN.UpdUser = objRow[convFeatureFieldTypeRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者
objvFeatureFieldTypeRelaEN.Memo = objRow[convFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[convFeatureFieldTypeRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFieldTypeRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFieldTypeRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFeatureFieldTypeRela(ref clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN)
{
bool bolResult = vFeatureFieldTypeRelaDA.GetvFeatureFieldTypeRela(ref objvFeatureFieldTypeRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureFieldTypeRelaEN GetObjBymId(long lngmId)
{
clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = vFeatureFieldTypeRelaDA.GetObjBymId(lngmId);
return objvFeatureFieldTypeRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFeatureFieldTypeRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = vFeatureFieldTypeRelaDA.GetFirstObj(strWhereCond);
 return objvFeatureFieldTypeRelaEN;
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
public static clsvFeatureFieldTypeRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = vFeatureFieldTypeRelaDA.GetObjByDataRow(objRow);
 return objvFeatureFieldTypeRelaEN;
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
public static clsvFeatureFieldTypeRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN = vFeatureFieldTypeRelaDA.GetObjByDataRow(objRow);
 return objvFeatureFieldTypeRelaEN;
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
 /// <param name = "lstvFeatureFieldTypeRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureFieldTypeRelaEN GetObjBymIdFromList(long lngmId, List<clsvFeatureFieldTypeRelaEN> lstvFeatureFieldTypeRelaObjLst)
{
foreach (clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN in lstvFeatureFieldTypeRelaObjLst)
{
if (objvFeatureFieldTypeRelaEN.mId == lngmId)
{
return objvFeatureFieldTypeRelaEN;
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
 lngmId = new clsvFeatureFieldTypeRelaDA().GetFirstID(strWhereCond);
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
 arrList = vFeatureFieldTypeRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vFeatureFieldTypeRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vFeatureFieldTypeRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvFeatureFieldTypeRelaDA.IsExistTable();
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
 bolIsExist = vFeatureFieldTypeRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvFeatureFieldTypeRelaENS">源对象</param>
 /// <param name = "objvFeatureFieldTypeRelaENT">目标对象</param>
 public static void CopyTo(clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaENS, clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaENT)
{
try
{
objvFeatureFieldTypeRelaENT.mId = objvFeatureFieldTypeRelaENS.mId; //mId
objvFeatureFieldTypeRelaENT.FeatureId = objvFeatureFieldTypeRelaENS.FeatureId; //功能Id
objvFeatureFieldTypeRelaENT.FeatureName = objvFeatureFieldTypeRelaENS.FeatureName; //功能名称
objvFeatureFieldTypeRelaENT.KeyWords = objvFeatureFieldTypeRelaENS.KeyWords; //关键字
objvFeatureFieldTypeRelaENT.FeatureTypeName = objvFeatureFieldTypeRelaENS.FeatureTypeName; //功能类型名称
objvFeatureFieldTypeRelaENT.FieldTypeId = objvFeatureFieldTypeRelaENS.FieldTypeId; //字段类型Id
objvFeatureFieldTypeRelaENT.FieldTypeName = objvFeatureFieldTypeRelaENS.FieldTypeName; //字段类型名
objvFeatureFieldTypeRelaENT.FieldTypeENName = objvFeatureFieldTypeRelaENS.FieldTypeENName; //字段类型英文名
objvFeatureFieldTypeRelaENT.OrderNum = objvFeatureFieldTypeRelaENS.OrderNum; //序号
objvFeatureFieldTypeRelaENT.UpdDate = objvFeatureFieldTypeRelaENS.UpdDate; //修改日期
objvFeatureFieldTypeRelaENT.UpdUser = objvFeatureFieldTypeRelaENS.UpdUser; //修改者
objvFeatureFieldTypeRelaENT.Memo = objvFeatureFieldTypeRelaENS.Memo; //说明
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
 /// <param name = "objvFeatureFieldTypeRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN)
{
try
{
objvFeatureFieldTypeRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFeatureFieldTypeRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFeatureFieldTypeRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFieldTypeRelaEN.mId = objvFeatureFieldTypeRelaEN.mId; //mId
}
if (arrFldSet.Contains(convFeatureFieldTypeRela.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFieldTypeRelaEN.FeatureId = objvFeatureFieldTypeRelaEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convFeatureFieldTypeRela.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFieldTypeRelaEN.FeatureName = objvFeatureFieldTypeRelaEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convFeatureFieldTypeRela.KeyWords, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFieldTypeRelaEN.KeyWords = objvFeatureFieldTypeRelaEN.KeyWords == "[null]" ? null :  objvFeatureFieldTypeRelaEN.KeyWords; //关键字
}
if (arrFldSet.Contains(convFeatureFieldTypeRela.FeatureTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFieldTypeRelaEN.FeatureTypeName = objvFeatureFieldTypeRelaEN.FeatureTypeName; //功能类型名称
}
if (arrFldSet.Contains(convFeatureFieldTypeRela.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFieldTypeRelaEN.FieldTypeId = objvFeatureFieldTypeRelaEN.FieldTypeId == "[null]" ? null :  objvFeatureFieldTypeRelaEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(convFeatureFieldTypeRela.FieldTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFieldTypeRelaEN.FieldTypeName = objvFeatureFieldTypeRelaEN.FieldTypeName == "[null]" ? null :  objvFeatureFieldTypeRelaEN.FieldTypeName; //字段类型名
}
if (arrFldSet.Contains(convFeatureFieldTypeRela.FieldTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFieldTypeRelaEN.FieldTypeENName = objvFeatureFieldTypeRelaEN.FieldTypeENName == "[null]" ? null :  objvFeatureFieldTypeRelaEN.FieldTypeENName; //字段类型英文名
}
if (arrFldSet.Contains(convFeatureFieldTypeRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFieldTypeRelaEN.OrderNum = objvFeatureFieldTypeRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convFeatureFieldTypeRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFieldTypeRelaEN.UpdDate = objvFeatureFieldTypeRelaEN.UpdDate == "[null]" ? null :  objvFeatureFieldTypeRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFeatureFieldTypeRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFieldTypeRelaEN.UpdUser = objvFeatureFieldTypeRelaEN.UpdUser == "[null]" ? null :  objvFeatureFieldTypeRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFeatureFieldTypeRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFieldTypeRelaEN.Memo = objvFeatureFieldTypeRelaEN.Memo == "[null]" ? null :  objvFeatureFieldTypeRelaEN.Memo; //说明
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
 /// <param name = "objvFeatureFieldTypeRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN)
{
try
{
if (objvFeatureFieldTypeRelaEN.KeyWords == "[null]") objvFeatureFieldTypeRelaEN.KeyWords = null; //关键字
if (objvFeatureFieldTypeRelaEN.FieldTypeId == "[null]") objvFeatureFieldTypeRelaEN.FieldTypeId = null; //字段类型Id
if (objvFeatureFieldTypeRelaEN.FieldTypeName == "[null]") objvFeatureFieldTypeRelaEN.FieldTypeName = null; //字段类型名
if (objvFeatureFieldTypeRelaEN.FieldTypeENName == "[null]") objvFeatureFieldTypeRelaEN.FieldTypeENName = null; //字段类型英文名
if (objvFeatureFieldTypeRelaEN.UpdDate == "[null]") objvFeatureFieldTypeRelaEN.UpdDate = null; //修改日期
if (objvFeatureFieldTypeRelaEN.UpdUser == "[null]") objvFeatureFieldTypeRelaEN.UpdUser = null; //修改者
if (objvFeatureFieldTypeRelaEN.Memo == "[null]") objvFeatureFieldTypeRelaEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaEN)
{
 vFeatureFieldTypeRelaDA.CheckProperty4Condition(objvFeatureFieldTypeRelaEN);
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
if (clsFieldTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTypeBL没有刷新缓存机制(clsFieldTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFeatureFieldTypeRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFeatureFieldTypeRelaBL没有刷新缓存机制(clsFeatureFieldTypeRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvFeatureFieldTypeRelaObjLstCache == null)
//{
//arrvFeatureFieldTypeRelaObjLstCache = vFeatureFieldTypeRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureFieldTypeRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFeatureFieldTypeRelaEN._CurrTabName);
List<clsvFeatureFieldTypeRelaEN> arrvFeatureFieldTypeRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureFieldTypeRelaEN> arrvFeatureFieldTypeRelaObjLst_Sel =
arrvFeatureFieldTypeRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvFeatureFieldTypeRelaObjLst_Sel.Count() == 0)
{
   clsvFeatureFieldTypeRelaEN obj = clsvFeatureFieldTypeRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFeatureFieldTypeRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureFieldTypeRelaEN> GetAllvFeatureFieldTypeRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvFeatureFieldTypeRelaEN> arrvFeatureFieldTypeRelaObjLstCache = GetObjLstCache(); 
return arrvFeatureFieldTypeRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureFieldTypeRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFeatureFieldTypeRelaEN._CurrTabName);
List<clsvFeatureFieldTypeRelaEN> arrvFeatureFieldTypeRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFeatureFieldTypeRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvFeatureFieldTypeRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFeatureFieldTypeRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFeatureFieldTypeRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvFeatureFieldTypeRelaEN._RefreshTimeLst[clsvFeatureFieldTypeRelaEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convFeatureFieldTypeRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFeatureFieldTypeRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFeatureFieldTypeRela._AttributeName));
throw new Exception(strMsg);
}
var objvFeatureFieldTypeRela = clsvFeatureFieldTypeRelaBL.GetObjBymIdCache(lngmId);
if (objvFeatureFieldTypeRela == null) return "";
return objvFeatureFieldTypeRela[strOutFldName].ToString();
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
int intRecCount = clsvFeatureFieldTypeRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvFeatureFieldTypeRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFeatureFieldTypeRelaDA.GetRecCount();
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
int intRecCount = clsvFeatureFieldTypeRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFeatureFieldTypeRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFeatureFieldTypeRelaEN objvFeatureFieldTypeRelaCond)
{
List<clsvFeatureFieldTypeRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureFieldTypeRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureFieldTypeRela._AttributeName)
{
if (objvFeatureFieldTypeRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureFieldTypeRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureFieldTypeRelaCond[strFldName].ToString());
}
else
{
if (objvFeatureFieldTypeRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureFieldTypeRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureFieldTypeRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureFieldTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureFieldTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureFieldTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureFieldTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureFieldTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureFieldTypeRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureFieldTypeRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureFieldTypeRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureFieldTypeRelaCond[strFldName]));
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
 List<string> arrList = clsvFeatureFieldTypeRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFeatureFieldTypeRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFeatureFieldTypeRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}