
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureButtonRelaBL
 表名:vFeatureButtonRela(00050428)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:04
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
public static class  clsvFeatureButtonRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureButtonRelaEN GetObj(this K_mId_vFeatureButtonRela myKey)
{
clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = clsvFeatureButtonRelaBL.vFeatureButtonRelaDA.GetObjBymId(myKey.Value);
return objvFeatureButtonRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetmId(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, long lngmId, string strComparisonOp="")
	{
objvFeatureButtonRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.mId) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.mId, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.mId] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetApplicationTypeId(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convFeatureButtonRela.ApplicationTypeId);
objvFeatureButtonRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.ApplicationTypeId) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.ApplicationTypeId, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.ApplicationTypeId] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetApplicationTypeName(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, convFeatureButtonRela.ApplicationTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convFeatureButtonRela.ApplicationTypeName);
}
objvFeatureButtonRelaEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.ApplicationTypeName) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.ApplicationTypeName, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.ApplicationTypeName] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetApplicationTypeENName(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeENName, convFeatureButtonRela.ApplicationTypeENName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convFeatureButtonRela.ApplicationTypeENName);
}
objvFeatureButtonRelaEN.ApplicationTypeENName = strApplicationTypeENName; //应用类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.ApplicationTypeENName) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.ApplicationTypeENName, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.ApplicationTypeENName] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetFeatureId(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureId, convFeatureButtonRela.FeatureId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFeatureButtonRela.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFeatureButtonRela.FeatureId);
}
objvFeatureButtonRelaEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.FeatureId) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.FeatureId, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.FeatureId] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetFeatureName(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convFeatureButtonRela.FeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convFeatureButtonRela.FeatureName);
}
objvFeatureButtonRelaEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.FeatureName) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.FeatureName, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.FeatureName] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetFeatureTypeName(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, convFeatureButtonRela.FeatureTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, convFeatureButtonRela.FeatureTypeName);
}
objvFeatureButtonRelaEN.FeatureTypeName = strFeatureTypeName; //功能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.FeatureTypeName) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.FeatureTypeName, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.FeatureTypeName] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetButtonId(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strButtonId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonId, convFeatureButtonRela.ButtonId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strButtonId, 2, convFeatureButtonRela.ButtonId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strButtonId, 2, convFeatureButtonRela.ButtonId);
}
objvFeatureButtonRelaEN.ButtonId = strButtonId; //按钮Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.ButtonId) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.ButtonId, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.ButtonId] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetButtonName(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strButtonName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strButtonName, convFeatureButtonRela.ButtonName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strButtonName, 30, convFeatureButtonRela.ButtonName);
}
objvFeatureButtonRelaEN.ButtonName = strButtonName; //按钮名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.ButtonName) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.ButtonName, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.ButtonName] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetText(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strText, convFeatureButtonRela.Text);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strText, 30, convFeatureButtonRela.Text);
}
objvFeatureButtonRelaEN.Text = strText; //文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.Text) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.Text, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.Text] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetOrderNum(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFeatureButtonRela.OrderNum);
objvFeatureButtonRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.OrderNum) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.OrderNum, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.OrderNum] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetEventFuncName(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strEventFuncName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEventFuncName, 50, convFeatureButtonRela.EventFuncName);
}
objvFeatureButtonRelaEN.EventFuncName = strEventFuncName; //事件函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.EventFuncName) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.EventFuncName, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.EventFuncName] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetUpdDate(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFeatureButtonRela.UpdDate);
}
objvFeatureButtonRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.UpdDate) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.UpdDate, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.UpdDate] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetUpdUser(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFeatureButtonRela.UpdUser);
}
objvFeatureButtonRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.UpdUser) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.UpdUser, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.UpdUser] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureButtonRelaEN SetMemo(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFeatureButtonRela.Memo);
}
objvFeatureButtonRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureButtonRelaEN.dicFldComparisonOp.ContainsKey(convFeatureButtonRela.Memo) == false)
{
objvFeatureButtonRelaEN.dicFldComparisonOp.Add(convFeatureButtonRela.Memo, strComparisonOp);
}
else
{
objvFeatureButtonRelaEN.dicFldComparisonOp[convFeatureButtonRela.Memo] = strComparisonOp;
}
}
return objvFeatureButtonRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaENS">源对象</param>
 /// <param name = "objvFeatureButtonRelaENT">目标对象</param>
 public static void CopyTo(this clsvFeatureButtonRelaEN objvFeatureButtonRelaENS, clsvFeatureButtonRelaEN objvFeatureButtonRelaENT)
{
try
{
objvFeatureButtonRelaENT.mId = objvFeatureButtonRelaENS.mId; //mId
objvFeatureButtonRelaENT.ApplicationTypeId = objvFeatureButtonRelaENS.ApplicationTypeId; //应用程序类型ID
objvFeatureButtonRelaENT.ApplicationTypeName = objvFeatureButtonRelaENS.ApplicationTypeName; //应用程序类型名称
objvFeatureButtonRelaENT.ApplicationTypeENName = objvFeatureButtonRelaENS.ApplicationTypeENName; //应用类型英文名
objvFeatureButtonRelaENT.FeatureId = objvFeatureButtonRelaENS.FeatureId; //功能Id
objvFeatureButtonRelaENT.FeatureName = objvFeatureButtonRelaENS.FeatureName; //功能名称
objvFeatureButtonRelaENT.FeatureTypeName = objvFeatureButtonRelaENS.FeatureTypeName; //功能类型名称
objvFeatureButtonRelaENT.ButtonId = objvFeatureButtonRelaENS.ButtonId; //按钮Id
objvFeatureButtonRelaENT.ButtonName = objvFeatureButtonRelaENS.ButtonName; //按钮名称
objvFeatureButtonRelaENT.Text = objvFeatureButtonRelaENS.Text; //文本
objvFeatureButtonRelaENT.OrderNum = objvFeatureButtonRelaENS.OrderNum; //序号
objvFeatureButtonRelaENT.EventFuncName = objvFeatureButtonRelaENS.EventFuncName; //事件函数名
objvFeatureButtonRelaENT.UpdDate = objvFeatureButtonRelaENS.UpdDate; //修改日期
objvFeatureButtonRelaENT.UpdUser = objvFeatureButtonRelaENS.UpdUser; //修改者
objvFeatureButtonRelaENT.Memo = objvFeatureButtonRelaENS.Memo; //说明
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
 /// <param name = "objvFeatureButtonRelaENS">源对象</param>
 /// <returns>目标对象=>clsvFeatureButtonRelaEN:objvFeatureButtonRelaENT</returns>
 public static clsvFeatureButtonRelaEN CopyTo(this clsvFeatureButtonRelaEN objvFeatureButtonRelaENS)
{
try
{
 clsvFeatureButtonRelaEN objvFeatureButtonRelaENT = new clsvFeatureButtonRelaEN()
{
mId = objvFeatureButtonRelaENS.mId, //mId
ApplicationTypeId = objvFeatureButtonRelaENS.ApplicationTypeId, //应用程序类型ID
ApplicationTypeName = objvFeatureButtonRelaENS.ApplicationTypeName, //应用程序类型名称
ApplicationTypeENName = objvFeatureButtonRelaENS.ApplicationTypeENName, //应用类型英文名
FeatureId = objvFeatureButtonRelaENS.FeatureId, //功能Id
FeatureName = objvFeatureButtonRelaENS.FeatureName, //功能名称
FeatureTypeName = objvFeatureButtonRelaENS.FeatureTypeName, //功能类型名称
ButtonId = objvFeatureButtonRelaENS.ButtonId, //按钮Id
ButtonName = objvFeatureButtonRelaENS.ButtonName, //按钮名称
Text = objvFeatureButtonRelaENS.Text, //文本
OrderNum = objvFeatureButtonRelaENS.OrderNum, //序号
EventFuncName = objvFeatureButtonRelaENS.EventFuncName, //事件函数名
UpdDate = objvFeatureButtonRelaENS.UpdDate, //修改日期
UpdUser = objvFeatureButtonRelaENS.UpdUser, //修改者
Memo = objvFeatureButtonRelaENS.Memo, //说明
};
 return objvFeatureButtonRelaENT;
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
public static void CheckProperty4Condition(this clsvFeatureButtonRelaEN objvFeatureButtonRelaEN)
{
 clsvFeatureButtonRelaBL.vFeatureButtonRelaDA.CheckProperty4Condition(objvFeatureButtonRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFeatureButtonRelaEN objvFeatureButtonRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.mId) == true)
{
string strComparisonOpmId = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureButtonRela.mId, objvFeatureButtonRelaCond.mId, strComparisonOpmId);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureButtonRela.ApplicationTypeId, objvFeatureButtonRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.ApplicationTypeName, objvFeatureButtonRelaCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.ApplicationTypeENName) == true)
{
string strComparisonOpApplicationTypeENName = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.ApplicationTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.ApplicationTypeENName, objvFeatureButtonRelaCond.ApplicationTypeENName, strComparisonOpApplicationTypeENName);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.FeatureId, objvFeatureButtonRelaCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.FeatureName) == true)
{
string strComparisonOpFeatureName = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.FeatureName, objvFeatureButtonRelaCond.FeatureName, strComparisonOpFeatureName);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.FeatureTypeName) == true)
{
string strComparisonOpFeatureTypeName = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.FeatureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.FeatureTypeName, objvFeatureButtonRelaCond.FeatureTypeName, strComparisonOpFeatureTypeName);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.ButtonId) == true)
{
string strComparisonOpButtonId = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.ButtonId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.ButtonId, objvFeatureButtonRelaCond.ButtonId, strComparisonOpButtonId);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.ButtonName) == true)
{
string strComparisonOpButtonName = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.ButtonName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.ButtonName, objvFeatureButtonRelaCond.ButtonName, strComparisonOpButtonName);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.Text) == true)
{
string strComparisonOpText = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.Text];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.Text, objvFeatureButtonRelaCond.Text, strComparisonOpText);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureButtonRela.OrderNum, objvFeatureButtonRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.EventFuncName) == true)
{
string strComparisonOpEventFuncName = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.EventFuncName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.EventFuncName, objvFeatureButtonRelaCond.EventFuncName, strComparisonOpEventFuncName);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.UpdDate, objvFeatureButtonRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.UpdUser, objvFeatureButtonRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFeatureButtonRelaCond.IsUpdated(convFeatureButtonRela.Memo) == true)
{
string strComparisonOpMemo = objvFeatureButtonRelaCond.dicFldComparisonOp[convFeatureButtonRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureButtonRela.Memo, objvFeatureButtonRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFeatureButtonRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v功能按钮关系(vFeatureButtonRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureButtonRelaBL
{
public static RelatedActions_vFeatureButtonRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFeatureButtonRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFeatureButtonRelaDA vFeatureButtonRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFeatureButtonRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFeatureButtonRelaBL()
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
if (string.IsNullOrEmpty(clsvFeatureButtonRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFeatureButtonRelaEN._ConnectString);
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
public static DataTable GetDataTable_vFeatureButtonRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFeatureButtonRelaDA.GetDataTable_vFeatureButtonRela(strWhereCond);
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
objDT = vFeatureButtonRelaDA.GetDataTable(strWhereCond);
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
objDT = vFeatureButtonRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFeatureButtonRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFeatureButtonRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFeatureButtonRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vFeatureButtonRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFeatureButtonRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFeatureButtonRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvFeatureButtonRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvFeatureButtonRelaEN> arrObjLst = new List<clsvFeatureButtonRelaEN>(); 
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
	clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN();
try
{
objvFeatureButtonRelaEN.mId = Int32.Parse(objRow[convFeatureButtonRela.mId].ToString().Trim()); //mId
objvFeatureButtonRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureButtonRelaEN.ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureButtonRelaEN.ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureButtonRelaEN.FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureButtonRelaEN.FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureButtonRelaEN.FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureButtonRelaEN.ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id
objvFeatureButtonRelaEN.ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称
objvFeatureButtonRelaEN.Text = objRow[convFeatureButtonRela.Text].ToString().Trim(); //文本
objvFeatureButtonRelaEN.OrderNum = Int32.Parse(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()); //序号
objvFeatureButtonRelaEN.EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureButtonRelaEN.UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureButtonRelaEN.UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者
objvFeatureButtonRelaEN.Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureButtonRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureButtonRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFeatureButtonRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvFeatureButtonRelaEN._CurrTabName);
List<clsvFeatureButtonRelaEN> arrvFeatureButtonRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureButtonRelaEN> arrvFeatureButtonRelaObjLst_Sel =
arrvFeatureButtonRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvFeatureButtonRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureButtonRelaEN> GetObjLst(string strWhereCond)
{
List<clsvFeatureButtonRelaEN> arrObjLst = new List<clsvFeatureButtonRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN();
try
{
objvFeatureButtonRelaEN.mId = Int32.Parse(objRow[convFeatureButtonRela.mId].ToString().Trim()); //mId
objvFeatureButtonRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureButtonRelaEN.ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureButtonRelaEN.ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureButtonRelaEN.FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureButtonRelaEN.FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureButtonRelaEN.FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureButtonRelaEN.ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id
objvFeatureButtonRelaEN.ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称
objvFeatureButtonRelaEN.Text = objRow[convFeatureButtonRela.Text].ToString().Trim(); //文本
objvFeatureButtonRelaEN.OrderNum = Int32.Parse(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()); //序号
objvFeatureButtonRelaEN.EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureButtonRelaEN.UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureButtonRelaEN.UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者
objvFeatureButtonRelaEN.Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureButtonRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureButtonRelaEN);
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
public static List<clsvFeatureButtonRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureButtonRelaEN> arrObjLst = new List<clsvFeatureButtonRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN();
try
{
objvFeatureButtonRelaEN.mId = Int32.Parse(objRow[convFeatureButtonRela.mId].ToString().Trim()); //mId
objvFeatureButtonRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureButtonRelaEN.ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureButtonRelaEN.ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureButtonRelaEN.FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureButtonRelaEN.FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureButtonRelaEN.FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureButtonRelaEN.ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id
objvFeatureButtonRelaEN.ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称
objvFeatureButtonRelaEN.Text = objRow[convFeatureButtonRela.Text].ToString().Trim(); //文本
objvFeatureButtonRelaEN.OrderNum = Int32.Parse(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()); //序号
objvFeatureButtonRelaEN.EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureButtonRelaEN.UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureButtonRelaEN.UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者
objvFeatureButtonRelaEN.Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureButtonRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureButtonRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFeatureButtonRelaEN> GetSubObjLstCache(clsvFeatureButtonRelaEN objvFeatureButtonRelaCond)
{
List<clsvFeatureButtonRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureButtonRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureButtonRela._AttributeName)
{
if (objvFeatureButtonRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureButtonRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureButtonRelaCond[strFldName].ToString());
}
else
{
if (objvFeatureButtonRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureButtonRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureButtonRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureButtonRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureButtonRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureButtonRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureButtonRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureButtonRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureButtonRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureButtonRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureButtonRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureButtonRelaCond[strFldName]));
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
public static List<clsvFeatureButtonRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFeatureButtonRelaEN> arrObjLst = new List<clsvFeatureButtonRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN();
try
{
objvFeatureButtonRelaEN.mId = Int32.Parse(objRow[convFeatureButtonRela.mId].ToString().Trim()); //mId
objvFeatureButtonRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureButtonRelaEN.ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureButtonRelaEN.ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureButtonRelaEN.FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureButtonRelaEN.FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureButtonRelaEN.FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureButtonRelaEN.ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id
objvFeatureButtonRelaEN.ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称
objvFeatureButtonRelaEN.Text = objRow[convFeatureButtonRela.Text].ToString().Trim(); //文本
objvFeatureButtonRelaEN.OrderNum = Int32.Parse(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()); //序号
objvFeatureButtonRelaEN.EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureButtonRelaEN.UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureButtonRelaEN.UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者
objvFeatureButtonRelaEN.Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureButtonRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureButtonRelaEN);
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
public static List<clsvFeatureButtonRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFeatureButtonRelaEN> arrObjLst = new List<clsvFeatureButtonRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN();
try
{
objvFeatureButtonRelaEN.mId = Int32.Parse(objRow[convFeatureButtonRela.mId].ToString().Trim()); //mId
objvFeatureButtonRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureButtonRelaEN.ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureButtonRelaEN.ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureButtonRelaEN.FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureButtonRelaEN.FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureButtonRelaEN.FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureButtonRelaEN.ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id
objvFeatureButtonRelaEN.ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称
objvFeatureButtonRelaEN.Text = objRow[convFeatureButtonRela.Text].ToString().Trim(); //文本
objvFeatureButtonRelaEN.OrderNum = Int32.Parse(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()); //序号
objvFeatureButtonRelaEN.EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureButtonRelaEN.UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureButtonRelaEN.UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者
objvFeatureButtonRelaEN.Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureButtonRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureButtonRelaEN);
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
List<clsvFeatureButtonRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFeatureButtonRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureButtonRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFeatureButtonRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureButtonRelaEN> arrObjLst = new List<clsvFeatureButtonRelaEN>(); 
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
	clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN();
try
{
objvFeatureButtonRelaEN.mId = Int32.Parse(objRow[convFeatureButtonRela.mId].ToString().Trim()); //mId
objvFeatureButtonRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureButtonRelaEN.ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureButtonRelaEN.ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureButtonRelaEN.FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureButtonRelaEN.FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureButtonRelaEN.FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureButtonRelaEN.ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id
objvFeatureButtonRelaEN.ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称
objvFeatureButtonRelaEN.Text = objRow[convFeatureButtonRela.Text].ToString().Trim(); //文本
objvFeatureButtonRelaEN.OrderNum = Int32.Parse(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()); //序号
objvFeatureButtonRelaEN.EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureButtonRelaEN.UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureButtonRelaEN.UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者
objvFeatureButtonRelaEN.Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureButtonRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureButtonRelaEN);
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
public static List<clsvFeatureButtonRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureButtonRelaEN> arrObjLst = new List<clsvFeatureButtonRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN();
try
{
objvFeatureButtonRelaEN.mId = Int32.Parse(objRow[convFeatureButtonRela.mId].ToString().Trim()); //mId
objvFeatureButtonRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureButtonRelaEN.ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureButtonRelaEN.ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureButtonRelaEN.FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureButtonRelaEN.FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureButtonRelaEN.FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureButtonRelaEN.ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id
objvFeatureButtonRelaEN.ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称
objvFeatureButtonRelaEN.Text = objRow[convFeatureButtonRela.Text].ToString().Trim(); //文本
objvFeatureButtonRelaEN.OrderNum = Int32.Parse(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()); //序号
objvFeatureButtonRelaEN.EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureButtonRelaEN.UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureButtonRelaEN.UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者
objvFeatureButtonRelaEN.Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureButtonRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureButtonRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFeatureButtonRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFeatureButtonRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureButtonRelaEN> arrObjLst = new List<clsvFeatureButtonRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN();
try
{
objvFeatureButtonRelaEN.mId = Int32.Parse(objRow[convFeatureButtonRela.mId].ToString().Trim()); //mId
objvFeatureButtonRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureButtonRelaEN.ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureButtonRelaEN.ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureButtonRelaEN.FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureButtonRelaEN.FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureButtonRelaEN.FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureButtonRelaEN.ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id
objvFeatureButtonRelaEN.ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称
objvFeatureButtonRelaEN.Text = objRow[convFeatureButtonRela.Text].ToString().Trim(); //文本
objvFeatureButtonRelaEN.OrderNum = Int32.Parse(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()); //序号
objvFeatureButtonRelaEN.EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureButtonRelaEN.UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureButtonRelaEN.UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者
objvFeatureButtonRelaEN.Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureButtonRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureButtonRelaEN);
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
public static List<clsvFeatureButtonRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFeatureButtonRelaEN> arrObjLst = new List<clsvFeatureButtonRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN();
try
{
objvFeatureButtonRelaEN.mId = Int32.Parse(objRow[convFeatureButtonRela.mId].ToString().Trim()); //mId
objvFeatureButtonRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureButtonRelaEN.ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureButtonRelaEN.ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureButtonRelaEN.FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureButtonRelaEN.FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureButtonRelaEN.FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureButtonRelaEN.ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id
objvFeatureButtonRelaEN.ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称
objvFeatureButtonRelaEN.Text = objRow[convFeatureButtonRela.Text].ToString().Trim(); //文本
objvFeatureButtonRelaEN.OrderNum = Int32.Parse(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()); //序号
objvFeatureButtonRelaEN.EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureButtonRelaEN.UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureButtonRelaEN.UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者
objvFeatureButtonRelaEN.Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureButtonRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureButtonRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureButtonRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFeatureButtonRelaEN> arrObjLst = new List<clsvFeatureButtonRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = new clsvFeatureButtonRelaEN();
try
{
objvFeatureButtonRelaEN.mId = Int32.Parse(objRow[convFeatureButtonRela.mId].ToString().Trim()); //mId
objvFeatureButtonRelaEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureButtonRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureButtonRelaEN.ApplicationTypeName = objRow[convFeatureButtonRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFeatureButtonRelaEN.ApplicationTypeENName = objRow[convFeatureButtonRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvFeatureButtonRelaEN.FeatureId = objRow[convFeatureButtonRela.FeatureId].ToString().Trim(); //功能Id
objvFeatureButtonRelaEN.FeatureName = objRow[convFeatureButtonRela.FeatureName].ToString().Trim(); //功能名称
objvFeatureButtonRelaEN.FeatureTypeName = objRow[convFeatureButtonRela.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFeatureButtonRelaEN.ButtonId = objRow[convFeatureButtonRela.ButtonId].ToString().Trim(); //按钮Id
objvFeatureButtonRelaEN.ButtonName = objRow[convFeatureButtonRela.ButtonName].ToString().Trim(); //按钮名称
objvFeatureButtonRelaEN.Text = objRow[convFeatureButtonRela.Text].ToString().Trim(); //文本
objvFeatureButtonRelaEN.OrderNum = Int32.Parse(objRow[convFeatureButtonRela.OrderNum].ToString().Trim()); //序号
objvFeatureButtonRelaEN.EventFuncName = objRow[convFeatureButtonRela.EventFuncName] == DBNull.Value ? null : objRow[convFeatureButtonRela.EventFuncName].ToString().Trim(); //事件函数名
objvFeatureButtonRelaEN.UpdDate = objRow[convFeatureButtonRela.UpdDate] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdDate].ToString().Trim(); //修改日期
objvFeatureButtonRelaEN.UpdUser = objRow[convFeatureButtonRela.UpdUser] == DBNull.Value ? null : objRow[convFeatureButtonRela.UpdUser].ToString().Trim(); //修改者
objvFeatureButtonRelaEN.Memo = objRow[convFeatureButtonRela.Memo] == DBNull.Value ? null : objRow[convFeatureButtonRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureButtonRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureButtonRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFeatureButtonRela(ref clsvFeatureButtonRelaEN objvFeatureButtonRelaEN)
{
bool bolResult = vFeatureButtonRelaDA.GetvFeatureButtonRela(ref objvFeatureButtonRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureButtonRelaEN GetObjBymId(long lngmId)
{
clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = vFeatureButtonRelaDA.GetObjBymId(lngmId);
return objvFeatureButtonRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFeatureButtonRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = vFeatureButtonRelaDA.GetFirstObj(strWhereCond);
 return objvFeatureButtonRelaEN;
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
public static clsvFeatureButtonRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = vFeatureButtonRelaDA.GetObjByDataRow(objRow);
 return objvFeatureButtonRelaEN;
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
public static clsvFeatureButtonRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFeatureButtonRelaEN objvFeatureButtonRelaEN = vFeatureButtonRelaDA.GetObjByDataRow(objRow);
 return objvFeatureButtonRelaEN;
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
 /// <param name = "lstvFeatureButtonRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureButtonRelaEN GetObjBymIdFromList(long lngmId, List<clsvFeatureButtonRelaEN> lstvFeatureButtonRelaObjLst)
{
foreach (clsvFeatureButtonRelaEN objvFeatureButtonRelaEN in lstvFeatureButtonRelaObjLst)
{
if (objvFeatureButtonRelaEN.mId == lngmId)
{
return objvFeatureButtonRelaEN;
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
 lngmId = new clsvFeatureButtonRelaDA().GetFirstID(strWhereCond);
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
 arrList = vFeatureButtonRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vFeatureButtonRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vFeatureButtonRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvFeatureButtonRelaDA.IsExistTable();
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
 bolIsExist = vFeatureButtonRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvFeatureButtonRelaENS">源对象</param>
 /// <param name = "objvFeatureButtonRelaENT">目标对象</param>
 public static void CopyTo(clsvFeatureButtonRelaEN objvFeatureButtonRelaENS, clsvFeatureButtonRelaEN objvFeatureButtonRelaENT)
{
try
{
objvFeatureButtonRelaENT.mId = objvFeatureButtonRelaENS.mId; //mId
objvFeatureButtonRelaENT.ApplicationTypeId = objvFeatureButtonRelaENS.ApplicationTypeId; //应用程序类型ID
objvFeatureButtonRelaENT.ApplicationTypeName = objvFeatureButtonRelaENS.ApplicationTypeName; //应用程序类型名称
objvFeatureButtonRelaENT.ApplicationTypeENName = objvFeatureButtonRelaENS.ApplicationTypeENName; //应用类型英文名
objvFeatureButtonRelaENT.FeatureId = objvFeatureButtonRelaENS.FeatureId; //功能Id
objvFeatureButtonRelaENT.FeatureName = objvFeatureButtonRelaENS.FeatureName; //功能名称
objvFeatureButtonRelaENT.FeatureTypeName = objvFeatureButtonRelaENS.FeatureTypeName; //功能类型名称
objvFeatureButtonRelaENT.ButtonId = objvFeatureButtonRelaENS.ButtonId; //按钮Id
objvFeatureButtonRelaENT.ButtonName = objvFeatureButtonRelaENS.ButtonName; //按钮名称
objvFeatureButtonRelaENT.Text = objvFeatureButtonRelaENS.Text; //文本
objvFeatureButtonRelaENT.OrderNum = objvFeatureButtonRelaENS.OrderNum; //序号
objvFeatureButtonRelaENT.EventFuncName = objvFeatureButtonRelaENS.EventFuncName; //事件函数名
objvFeatureButtonRelaENT.UpdDate = objvFeatureButtonRelaENS.UpdDate; //修改日期
objvFeatureButtonRelaENT.UpdUser = objvFeatureButtonRelaENS.UpdUser; //修改者
objvFeatureButtonRelaENT.Memo = objvFeatureButtonRelaENS.Memo; //说明
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
 /// <param name = "objvFeatureButtonRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvFeatureButtonRelaEN objvFeatureButtonRelaEN)
{
try
{
objvFeatureButtonRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFeatureButtonRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFeatureButtonRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureButtonRelaEN.mId = objvFeatureButtonRelaEN.mId; //mId
}
if (arrFldSet.Contains(convFeatureButtonRela.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureButtonRelaEN.ApplicationTypeId = objvFeatureButtonRelaEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convFeatureButtonRela.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureButtonRelaEN.ApplicationTypeName = objvFeatureButtonRelaEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(convFeatureButtonRela.ApplicationTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureButtonRelaEN.ApplicationTypeENName = objvFeatureButtonRelaEN.ApplicationTypeENName; //应用类型英文名
}
if (arrFldSet.Contains(convFeatureButtonRela.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureButtonRelaEN.FeatureId = objvFeatureButtonRelaEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convFeatureButtonRela.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureButtonRelaEN.FeatureName = objvFeatureButtonRelaEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convFeatureButtonRela.FeatureTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureButtonRelaEN.FeatureTypeName = objvFeatureButtonRelaEN.FeatureTypeName; //功能类型名称
}
if (arrFldSet.Contains(convFeatureButtonRela.ButtonId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureButtonRelaEN.ButtonId = objvFeatureButtonRelaEN.ButtonId; //按钮Id
}
if (arrFldSet.Contains(convFeatureButtonRela.ButtonName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureButtonRelaEN.ButtonName = objvFeatureButtonRelaEN.ButtonName; //按钮名称
}
if (arrFldSet.Contains(convFeatureButtonRela.Text, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureButtonRelaEN.Text = objvFeatureButtonRelaEN.Text; //文本
}
if (arrFldSet.Contains(convFeatureButtonRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureButtonRelaEN.OrderNum = objvFeatureButtonRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convFeatureButtonRela.EventFuncName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureButtonRelaEN.EventFuncName = objvFeatureButtonRelaEN.EventFuncName == "[null]" ? null :  objvFeatureButtonRelaEN.EventFuncName; //事件函数名
}
if (arrFldSet.Contains(convFeatureButtonRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureButtonRelaEN.UpdDate = objvFeatureButtonRelaEN.UpdDate == "[null]" ? null :  objvFeatureButtonRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFeatureButtonRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureButtonRelaEN.UpdUser = objvFeatureButtonRelaEN.UpdUser == "[null]" ? null :  objvFeatureButtonRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFeatureButtonRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureButtonRelaEN.Memo = objvFeatureButtonRelaEN.Memo == "[null]" ? null :  objvFeatureButtonRelaEN.Memo; //说明
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
 /// <param name = "objvFeatureButtonRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFeatureButtonRelaEN objvFeatureButtonRelaEN)
{
try
{
if (objvFeatureButtonRelaEN.EventFuncName == "[null]") objvFeatureButtonRelaEN.EventFuncName = null; //事件函数名
if (objvFeatureButtonRelaEN.UpdDate == "[null]") objvFeatureButtonRelaEN.UpdDate = null; //修改日期
if (objvFeatureButtonRelaEN.UpdUser == "[null]") objvFeatureButtonRelaEN.UpdUser = null; //修改者
if (objvFeatureButtonRelaEN.Memo == "[null]") objvFeatureButtonRelaEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvFeatureButtonRelaEN objvFeatureButtonRelaEN)
{
 vFeatureButtonRelaDA.CheckProperty4Condition(objvFeatureButtonRelaEN);
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
if (clsFeatureButtonRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFeatureButtonRelaBL没有刷新缓存机制(clsFeatureButtonRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsButtonTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsButtonTabBL没有刷新缓存机制(clsButtonTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//if (arrvFeatureButtonRelaObjLstCache == null)
//{
//arrvFeatureButtonRelaObjLstCache = vFeatureButtonRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureButtonRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFeatureButtonRelaEN._CurrTabName);
List<clsvFeatureButtonRelaEN> arrvFeatureButtonRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureButtonRelaEN> arrvFeatureButtonRelaObjLst_Sel =
arrvFeatureButtonRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvFeatureButtonRelaObjLst_Sel.Count() == 0)
{
   clsvFeatureButtonRelaEN obj = clsvFeatureButtonRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFeatureButtonRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureButtonRelaEN> GetAllvFeatureButtonRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvFeatureButtonRelaEN> arrvFeatureButtonRelaObjLstCache = GetObjLstCache(); 
return arrvFeatureButtonRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureButtonRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFeatureButtonRelaEN._CurrTabName);
List<clsvFeatureButtonRelaEN> arrvFeatureButtonRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFeatureButtonRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvFeatureButtonRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFeatureButtonRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFeatureButtonRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvFeatureButtonRelaEN._RefreshTimeLst[clsvFeatureButtonRelaEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convFeatureButtonRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFeatureButtonRela._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFeatureButtonRela._AttributeName));
throw new Exception(strMsg);
}
var objvFeatureButtonRela = clsvFeatureButtonRelaBL.GetObjBymIdCache(lngmId);
if (objvFeatureButtonRela == null) return "";
return objvFeatureButtonRela[strOutFldName].ToString();
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
int intRecCount = clsvFeatureButtonRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvFeatureButtonRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFeatureButtonRelaDA.GetRecCount();
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
int intRecCount = clsvFeatureButtonRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFeatureButtonRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFeatureButtonRelaEN objvFeatureButtonRelaCond)
{
List<clsvFeatureButtonRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureButtonRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureButtonRela._AttributeName)
{
if (objvFeatureButtonRelaCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureButtonRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureButtonRelaCond[strFldName].ToString());
}
else
{
if (objvFeatureButtonRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureButtonRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureButtonRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureButtonRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureButtonRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureButtonRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureButtonRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureButtonRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureButtonRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureButtonRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureButtonRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureButtonRelaCond[strFldName]));
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
 List<string> arrList = clsvFeatureButtonRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFeatureButtonRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFeatureButtonRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}