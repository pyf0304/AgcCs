
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab4CodeConvBL
 表名:vFieldTab4CodeConv(00050594)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:18
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
public static class  clsvFieldTab4CodeConvBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTab4CodeConvEN GetObj(this K_FldId_vFieldTab4CodeConv myKey)
{
clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = clsvFieldTab4CodeConvBL.vFieldTab4CodeConvDA.GetObjByFldId(myKey.Value);
return objvFieldTab4CodeConvEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetFldName(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldName, 50, convFieldTab4CodeConv.FldName);
}
objvFieldTab4CodeConvEN.FldName = strFldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.FldName) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.FldName, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.FldName] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetFldId(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convFieldTab4CodeConv.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convFieldTab4CodeConv.FldId);
}
objvFieldTab4CodeConvEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.FldId) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.FldId, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.FldId] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetPrjId(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convFieldTab4CodeConv.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convFieldTab4CodeConv.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convFieldTab4CodeConv.PrjId);
}
objvFieldTab4CodeConvEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.PrjId) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.PrjId, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.PrjId] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetCodeTabId(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strCodeTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabId, 8, convFieldTab4CodeConv.CodeTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTabId, 8, convFieldTab4CodeConv.CodeTabId);
}
objvFieldTab4CodeConvEN.CodeTabId = strCodeTabId; //代码表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.CodeTabId) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.CodeTabId, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabId] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetCodeTabNameId(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strCodeTabNameId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabNameId, 8, convFieldTab4CodeConv.CodeTabNameId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTabNameId, 8, convFieldTab4CodeConv.CodeTabNameId);
}
objvFieldTab4CodeConvEN.CodeTabNameId = strCodeTabNameId; //代码_名Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.CodeTabNameId) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.CodeTabNameId, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabNameId] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetCodeTabCodeId(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strCodeTabCodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCodeId, 8, convFieldTab4CodeConv.CodeTabCodeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTabCodeId, 8, convFieldTab4CodeConv.CodeTabCodeId);
}
objvFieldTab4CodeConvEN.CodeTabCodeId = strCodeTabCodeId; //代码Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.CodeTabCodeId) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.CodeTabCodeId, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabCodeId] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetUpdDate(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convFieldTab4CodeConv.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFieldTab4CodeConv.UpdDate);
}
objvFieldTab4CodeConvEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.UpdDate) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.UpdDate, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.UpdDate] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetUpdUser(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFieldTab4CodeConv.UpdUser);
}
objvFieldTab4CodeConvEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.UpdUser) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.UpdUser, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.UpdUser] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetMemo(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFieldTab4CodeConv.Memo);
}
objvFieldTab4CodeConvEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.Memo) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.Memo, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.Memo] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetCodeTab(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strCodeTab, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTab, 50, convFieldTab4CodeConv.CodeTab);
}
objvFieldTab4CodeConvEN.CodeTab = strCodeTab; //代码表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.CodeTab) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.CodeTab, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.CodeTab] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetCodeTabName(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strCodeTabName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabName, 100, convFieldTab4CodeConv.CodeTabName);
}
objvFieldTab4CodeConvEN.CodeTabName = strCodeTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.CodeTabName) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.CodeTabName, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabName] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFieldTab4CodeConvEN SetCodeTabCode(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN, string strCodeTabCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTabCode, 50, convFieldTab4CodeConv.CodeTabCode);
}
objvFieldTab4CodeConvEN.CodeTabCode = strCodeTabCode; //代码表_代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFieldTab4CodeConvEN.dicFldComparisonOp.ContainsKey(convFieldTab4CodeConv.CodeTabCode) == false)
{
objvFieldTab4CodeConvEN.dicFldComparisonOp.Add(convFieldTab4CodeConv.CodeTabCode, strComparisonOp);
}
else
{
objvFieldTab4CodeConvEN.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabCode] = strComparisonOp;
}
}
return objvFieldTab4CodeConvEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvENS">源对象</param>
 /// <param name = "objvFieldTab4CodeConvENT">目标对象</param>
 public static void CopyTo(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvENS, clsvFieldTab4CodeConvEN objvFieldTab4CodeConvENT)
{
try
{
objvFieldTab4CodeConvENT.FldName = objvFieldTab4CodeConvENS.FldName; //字段名
objvFieldTab4CodeConvENT.FldId = objvFieldTab4CodeConvENS.FldId; //字段Id
objvFieldTab4CodeConvENT.PrjId = objvFieldTab4CodeConvENS.PrjId; //工程Id
objvFieldTab4CodeConvENT.CodeTabId = objvFieldTab4CodeConvENS.CodeTabId; //代码表Id
objvFieldTab4CodeConvENT.CodeTabNameId = objvFieldTab4CodeConvENS.CodeTabNameId; //代码_名Id
objvFieldTab4CodeConvENT.CodeTabCodeId = objvFieldTab4CodeConvENS.CodeTabCodeId; //代码Id
objvFieldTab4CodeConvENT.UpdDate = objvFieldTab4CodeConvENS.UpdDate; //修改日期
objvFieldTab4CodeConvENT.UpdUser = objvFieldTab4CodeConvENS.UpdUser; //修改者
objvFieldTab4CodeConvENT.Memo = objvFieldTab4CodeConvENS.Memo; //说明
objvFieldTab4CodeConvENT.CodeTab = objvFieldTab4CodeConvENS.CodeTab; //代码表
objvFieldTab4CodeConvENT.CodeTabName = objvFieldTab4CodeConvENS.CodeTabName; //表名
objvFieldTab4CodeConvENT.CodeTabCode = objvFieldTab4CodeConvENS.CodeTabCode; //代码表_代码
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
 /// <param name = "objvFieldTab4CodeConvENS">源对象</param>
 /// <returns>目标对象=>clsvFieldTab4CodeConvEN:objvFieldTab4CodeConvENT</returns>
 public static clsvFieldTab4CodeConvEN CopyTo(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvENS)
{
try
{
 clsvFieldTab4CodeConvEN objvFieldTab4CodeConvENT = new clsvFieldTab4CodeConvEN()
{
FldName = objvFieldTab4CodeConvENS.FldName, //字段名
FldId = objvFieldTab4CodeConvENS.FldId, //字段Id
PrjId = objvFieldTab4CodeConvENS.PrjId, //工程Id
CodeTabId = objvFieldTab4CodeConvENS.CodeTabId, //代码表Id
CodeTabNameId = objvFieldTab4CodeConvENS.CodeTabNameId, //代码_名Id
CodeTabCodeId = objvFieldTab4CodeConvENS.CodeTabCodeId, //代码Id
UpdDate = objvFieldTab4CodeConvENS.UpdDate, //修改日期
UpdUser = objvFieldTab4CodeConvENS.UpdUser, //修改者
Memo = objvFieldTab4CodeConvENS.Memo, //说明
CodeTab = objvFieldTab4CodeConvENS.CodeTab, //代码表
CodeTabName = objvFieldTab4CodeConvENS.CodeTabName, //表名
CodeTabCode = objvFieldTab4CodeConvENS.CodeTabCode, //代码表_代码
};
 return objvFieldTab4CodeConvENT;
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
public static void CheckProperty4Condition(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN)
{
 clsvFieldTab4CodeConvBL.vFieldTab4CodeConvDA.CheckProperty4Condition(objvFieldTab4CodeConvEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFieldTab4CodeConvEN objvFieldTab4CodeConvCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.FldName) == true)
{
string strComparisonOpFldName = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.FldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.FldName, objvFieldTab4CodeConvCond.FldName, strComparisonOpFldName);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.FldId) == true)
{
string strComparisonOpFldId = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.FldId, objvFieldTab4CodeConvCond.FldId, strComparisonOpFldId);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.PrjId) == true)
{
string strComparisonOpPrjId = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.PrjId, objvFieldTab4CodeConvCond.PrjId, strComparisonOpPrjId);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.CodeTabId) == true)
{
string strComparisonOpCodeTabId = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.CodeTabId, objvFieldTab4CodeConvCond.CodeTabId, strComparisonOpCodeTabId);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.CodeTabNameId) == true)
{
string strComparisonOpCodeTabNameId = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabNameId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.CodeTabNameId, objvFieldTab4CodeConvCond.CodeTabNameId, strComparisonOpCodeTabNameId);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.CodeTabCodeId) == true)
{
string strComparisonOpCodeTabCodeId = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabCodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.CodeTabCodeId, objvFieldTab4CodeConvCond.CodeTabCodeId, strComparisonOpCodeTabCodeId);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.UpdDate, objvFieldTab4CodeConvCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.UpdUser, objvFieldTab4CodeConvCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.Memo) == true)
{
string strComparisonOpMemo = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.Memo, objvFieldTab4CodeConvCond.Memo, strComparisonOpMemo);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.CodeTab) == true)
{
string strComparisonOpCodeTab = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.CodeTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.CodeTab, objvFieldTab4CodeConvCond.CodeTab, strComparisonOpCodeTab);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.CodeTabName) == true)
{
string strComparisonOpCodeTabName = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.CodeTabName, objvFieldTab4CodeConvCond.CodeTabName, strComparisonOpCodeTabName);
}
if (objvFieldTab4CodeConvCond.IsUpdated(convFieldTab4CodeConv.CodeTabCode) == true)
{
string strComparisonOpCodeTabCode = objvFieldTab4CodeConvCond.dicFldComparisonOp[convFieldTab4CodeConv.CodeTabCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFieldTab4CodeConv.CodeTabCode, objvFieldTab4CodeConvCond.CodeTabCode, strComparisonOpCodeTabCode);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFieldTab4CodeConv
{
public virtual bool UpdRelaTabDate(string strFldId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vFieldTab4CodeConv(vFieldTab4CodeConv)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFieldTab4CodeConvBL
{
public static RelatedActions_vFieldTab4CodeConv relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFieldTab4CodeConvDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFieldTab4CodeConvDA vFieldTab4CodeConvDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFieldTab4CodeConvDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFieldTab4CodeConvBL()
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
if (string.IsNullOrEmpty(clsvFieldTab4CodeConvEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFieldTab4CodeConvEN._ConnectString);
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
public static DataTable GetDataTable_vFieldTab4CodeConv(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFieldTab4CodeConvDA.GetDataTable_vFieldTab4CodeConv(strWhereCond);
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
objDT = vFieldTab4CodeConvDA.GetDataTable(strWhereCond);
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
objDT = vFieldTab4CodeConvDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFieldTab4CodeConvDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFieldTab4CodeConvDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFieldTab4CodeConvDA.GetDataTable_Top(objTopPara);
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
objDT = vFieldTab4CodeConvDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFieldTab4CodeConvDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFieldTab4CodeConvDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFldIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFieldTab4CodeConvEN> GetObjLstByFldIdLst(List<string> arrFldIdLst)
{
List<clsvFieldTab4CodeConvEN> arrObjLst = new List<clsvFieldTab4CodeConvEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFldIdLst, true);
 string strWhereCond = string.Format("FldId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN();
try
{
objvFieldTab4CodeConvEN.FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名
objvFieldTab4CodeConvEN.FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objvFieldTab4CodeConvEN.PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objvFieldTab4CodeConvEN.CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab4CodeConvEN.CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab4CodeConvEN.CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab4CodeConvEN.UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4CodeConvEN.UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objvFieldTab4CodeConvEN.Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(); //说明
objvFieldTab4CodeConvEN.CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表
objvFieldTab4CodeConvEN.CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名
objvFieldTab4CodeConvEN.CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4CodeConvEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4CodeConvEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFldIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFieldTab4CodeConvEN> GetObjLstByFldIdLstCache(List<string> arrFldIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvFieldTab4CodeConvEN._CurrTabName, strPrjId);
List<clsvFieldTab4CodeConvEN> arrvFieldTab4CodeConvObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab4CodeConvEN> arrvFieldTab4CodeConvObjLst_Sel =
arrvFieldTab4CodeConvObjLstCache
.Where(x => arrFldIdLst.Contains(x.FldId));
return arrvFieldTab4CodeConvObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab4CodeConvEN> GetObjLst(string strWhereCond)
{
List<clsvFieldTab4CodeConvEN> arrObjLst = new List<clsvFieldTab4CodeConvEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN();
try
{
objvFieldTab4CodeConvEN.FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名
objvFieldTab4CodeConvEN.FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objvFieldTab4CodeConvEN.PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objvFieldTab4CodeConvEN.CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab4CodeConvEN.CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab4CodeConvEN.CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab4CodeConvEN.UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4CodeConvEN.UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objvFieldTab4CodeConvEN.Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(); //说明
objvFieldTab4CodeConvEN.CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表
objvFieldTab4CodeConvEN.CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名
objvFieldTab4CodeConvEN.CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4CodeConvEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4CodeConvEN);
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
public static List<clsvFieldTab4CodeConvEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFieldTab4CodeConvEN> arrObjLst = new List<clsvFieldTab4CodeConvEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN();
try
{
objvFieldTab4CodeConvEN.FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名
objvFieldTab4CodeConvEN.FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objvFieldTab4CodeConvEN.PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objvFieldTab4CodeConvEN.CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab4CodeConvEN.CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab4CodeConvEN.CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab4CodeConvEN.UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4CodeConvEN.UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objvFieldTab4CodeConvEN.Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(); //说明
objvFieldTab4CodeConvEN.CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表
objvFieldTab4CodeConvEN.CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名
objvFieldTab4CodeConvEN.CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4CodeConvEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4CodeConvEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFieldTab4CodeConvEN> GetSubObjLstCache(clsvFieldTab4CodeConvEN objvFieldTab4CodeConvCond)
{
 string strPrjId = objvFieldTab4CodeConvCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvFieldTab4CodeConvBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvFieldTab4CodeConvEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab4CodeConvEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFieldTab4CodeConv._AttributeName)
{
if (objvFieldTab4CodeConvCond.IsUpdated(strFldName) == false) continue;
if (objvFieldTab4CodeConvCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab4CodeConvCond[strFldName].ToString());
}
else
{
if (objvFieldTab4CodeConvCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFieldTab4CodeConvCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab4CodeConvCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFieldTab4CodeConvCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFieldTab4CodeConvCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFieldTab4CodeConvCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFieldTab4CodeConvCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFieldTab4CodeConvCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFieldTab4CodeConvCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFieldTab4CodeConvCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFieldTab4CodeConvCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFieldTab4CodeConvCond[strFldName]));
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
public static List<clsvFieldTab4CodeConvEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFieldTab4CodeConvEN> arrObjLst = new List<clsvFieldTab4CodeConvEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN();
try
{
objvFieldTab4CodeConvEN.FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名
objvFieldTab4CodeConvEN.FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objvFieldTab4CodeConvEN.PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objvFieldTab4CodeConvEN.CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab4CodeConvEN.CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab4CodeConvEN.CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab4CodeConvEN.UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4CodeConvEN.UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objvFieldTab4CodeConvEN.Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(); //说明
objvFieldTab4CodeConvEN.CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表
objvFieldTab4CodeConvEN.CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名
objvFieldTab4CodeConvEN.CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4CodeConvEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4CodeConvEN);
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
public static List<clsvFieldTab4CodeConvEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFieldTab4CodeConvEN> arrObjLst = new List<clsvFieldTab4CodeConvEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN();
try
{
objvFieldTab4CodeConvEN.FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名
objvFieldTab4CodeConvEN.FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objvFieldTab4CodeConvEN.PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objvFieldTab4CodeConvEN.CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab4CodeConvEN.CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab4CodeConvEN.CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab4CodeConvEN.UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4CodeConvEN.UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objvFieldTab4CodeConvEN.Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(); //说明
objvFieldTab4CodeConvEN.CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表
objvFieldTab4CodeConvEN.CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名
objvFieldTab4CodeConvEN.CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4CodeConvEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4CodeConvEN);
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
List<clsvFieldTab4CodeConvEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFieldTab4CodeConvEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab4CodeConvEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFieldTab4CodeConvEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFieldTab4CodeConvEN> arrObjLst = new List<clsvFieldTab4CodeConvEN>(); 
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
	clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN();
try
{
objvFieldTab4CodeConvEN.FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名
objvFieldTab4CodeConvEN.FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objvFieldTab4CodeConvEN.PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objvFieldTab4CodeConvEN.CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab4CodeConvEN.CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab4CodeConvEN.CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab4CodeConvEN.UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4CodeConvEN.UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objvFieldTab4CodeConvEN.Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(); //说明
objvFieldTab4CodeConvEN.CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表
objvFieldTab4CodeConvEN.CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名
objvFieldTab4CodeConvEN.CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4CodeConvEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4CodeConvEN);
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
public static List<clsvFieldTab4CodeConvEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFieldTab4CodeConvEN> arrObjLst = new List<clsvFieldTab4CodeConvEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN();
try
{
objvFieldTab4CodeConvEN.FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名
objvFieldTab4CodeConvEN.FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objvFieldTab4CodeConvEN.PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objvFieldTab4CodeConvEN.CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab4CodeConvEN.CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab4CodeConvEN.CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab4CodeConvEN.UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4CodeConvEN.UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objvFieldTab4CodeConvEN.Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(); //说明
objvFieldTab4CodeConvEN.CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表
objvFieldTab4CodeConvEN.CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名
objvFieldTab4CodeConvEN.CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4CodeConvEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4CodeConvEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFieldTab4CodeConvEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFieldTab4CodeConvEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFieldTab4CodeConvEN> arrObjLst = new List<clsvFieldTab4CodeConvEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN();
try
{
objvFieldTab4CodeConvEN.FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名
objvFieldTab4CodeConvEN.FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objvFieldTab4CodeConvEN.PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objvFieldTab4CodeConvEN.CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab4CodeConvEN.CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab4CodeConvEN.CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab4CodeConvEN.UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4CodeConvEN.UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objvFieldTab4CodeConvEN.Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(); //说明
objvFieldTab4CodeConvEN.CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表
objvFieldTab4CodeConvEN.CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名
objvFieldTab4CodeConvEN.CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4CodeConvEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4CodeConvEN);
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
public static List<clsvFieldTab4CodeConvEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFieldTab4CodeConvEN> arrObjLst = new List<clsvFieldTab4CodeConvEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN();
try
{
objvFieldTab4CodeConvEN.FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名
objvFieldTab4CodeConvEN.FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objvFieldTab4CodeConvEN.PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objvFieldTab4CodeConvEN.CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab4CodeConvEN.CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab4CodeConvEN.CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab4CodeConvEN.UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4CodeConvEN.UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objvFieldTab4CodeConvEN.Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(); //说明
objvFieldTab4CodeConvEN.CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表
objvFieldTab4CodeConvEN.CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名
objvFieldTab4CodeConvEN.CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4CodeConvEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4CodeConvEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFieldTab4CodeConvEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFieldTab4CodeConvEN> arrObjLst = new List<clsvFieldTab4CodeConvEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = new clsvFieldTab4CodeConvEN();
try
{
objvFieldTab4CodeConvEN.FldName = objRow[convFieldTab4CodeConv.FldName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.FldName].ToString().Trim(); //字段名
objvFieldTab4CodeConvEN.FldId = objRow[convFieldTab4CodeConv.FldId].ToString().Trim(); //字段Id
objvFieldTab4CodeConvEN.PrjId = objRow[convFieldTab4CodeConv.PrjId].ToString().Trim(); //工程Id
objvFieldTab4CodeConvEN.CodeTabId = objRow[convFieldTab4CodeConv.CodeTabId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabId].ToString().Trim(); //代码表Id
objvFieldTab4CodeConvEN.CodeTabNameId = objRow[convFieldTab4CodeConv.CodeTabNameId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabNameId].ToString().Trim(); //代码_名Id
objvFieldTab4CodeConvEN.CodeTabCodeId = objRow[convFieldTab4CodeConv.CodeTabCodeId] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCodeId].ToString().Trim(); //代码Id
objvFieldTab4CodeConvEN.UpdDate = objRow[convFieldTab4CodeConv.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4CodeConvEN.UpdUser = objRow[convFieldTab4CodeConv.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.UpdUser].ToString().Trim(); //修改者
objvFieldTab4CodeConvEN.Memo = objRow[convFieldTab4CodeConv.Memo] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.Memo].ToString().Trim(); //说明
objvFieldTab4CodeConvEN.CodeTab = objRow[convFieldTab4CodeConv.CodeTab] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTab].ToString().Trim(); //代码表
objvFieldTab4CodeConvEN.CodeTabName = objRow[convFieldTab4CodeConv.CodeTabName] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabName].ToString().Trim(); //表名
objvFieldTab4CodeConvEN.CodeTabCode = objRow[convFieldTab4CodeConv.CodeTabCode] == DBNull.Value ? null : objRow[convFieldTab4CodeConv.CodeTabCode].ToString().Trim(); //代码表_代码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFieldTab4CodeConvEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFieldTab4CodeConvEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFieldTab4CodeConv(ref clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN)
{
bool bolResult = vFieldTab4CodeConvDA.GetvFieldTab4CodeConv(ref objvFieldTab4CodeConvEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFldId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFieldTab4CodeConvEN GetObjByFldId(string strFldId)
{
if (strFldId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFldId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFldId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFldId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = vFieldTab4CodeConvDA.GetObjByFldId(strFldId);
return objvFieldTab4CodeConvEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFieldTab4CodeConvEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = vFieldTab4CodeConvDA.GetFirstObj(strWhereCond);
 return objvFieldTab4CodeConvEN;
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
public static clsvFieldTab4CodeConvEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = vFieldTab4CodeConvDA.GetObjByDataRow(objRow);
 return objvFieldTab4CodeConvEN;
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
public static clsvFieldTab4CodeConvEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN = vFieldTab4CodeConvDA.GetObjByDataRow(objRow);
 return objvFieldTab4CodeConvEN;
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
 /// <param name = "strFldId">所给的关键字</param>
 /// <param name = "lstvFieldTab4CodeConvObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFieldTab4CodeConvEN GetObjByFldIdFromList(string strFldId, List<clsvFieldTab4CodeConvEN> lstvFieldTab4CodeConvObjLst)
{
foreach (clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN in lstvFieldTab4CodeConvObjLst)
{
if (objvFieldTab4CodeConvEN.FldId == strFldId)
{
return objvFieldTab4CodeConvEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrIdByPrefix_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix_S(string strPrefix) 
{
if (string.IsNullOrEmpty(strPrefix) == true)
{
var strMsg = string.Format("前缀不能为空.(from {0})",
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
 string strMaxFldId;
 try
 {
 strMaxFldId = new clsvFieldTab4CodeConvDA().GetMaxStrIdByPrefix(strPrefix);
 return strMaxFldId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000025)根据前缀获取最大关键字值出错, {1}.(from {0})",
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
 string strFldId;
 try
 {
 strFldId = new clsvFieldTab4CodeConvDA().GetFirstID(strWhereCond);
 return strFldId;
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
 arrList = vFieldTab4CodeConvDA.GetID(strWhereCond);
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
bool bolIsExist = vFieldTab4CodeConvDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFldId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFldId)
{
if (string.IsNullOrEmpty(strFldId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFldId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vFieldTab4CodeConvDA.IsExist(strFldId);
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
 bolIsExist = clsvFieldTab4CodeConvDA.IsExistTable();
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
 bolIsExist = vFieldTab4CodeConvDA.IsExistTable(strTabName);
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
 /// <param name = "objvFieldTab4CodeConvENS">源对象</param>
 /// <param name = "objvFieldTab4CodeConvENT">目标对象</param>
 public static void CopyTo(clsvFieldTab4CodeConvEN objvFieldTab4CodeConvENS, clsvFieldTab4CodeConvEN objvFieldTab4CodeConvENT)
{
try
{
objvFieldTab4CodeConvENT.FldName = objvFieldTab4CodeConvENS.FldName; //字段名
objvFieldTab4CodeConvENT.FldId = objvFieldTab4CodeConvENS.FldId; //字段Id
objvFieldTab4CodeConvENT.PrjId = objvFieldTab4CodeConvENS.PrjId; //工程Id
objvFieldTab4CodeConvENT.CodeTabId = objvFieldTab4CodeConvENS.CodeTabId; //代码表Id
objvFieldTab4CodeConvENT.CodeTabNameId = objvFieldTab4CodeConvENS.CodeTabNameId; //代码_名Id
objvFieldTab4CodeConvENT.CodeTabCodeId = objvFieldTab4CodeConvENS.CodeTabCodeId; //代码Id
objvFieldTab4CodeConvENT.UpdDate = objvFieldTab4CodeConvENS.UpdDate; //修改日期
objvFieldTab4CodeConvENT.UpdUser = objvFieldTab4CodeConvENS.UpdUser; //修改者
objvFieldTab4CodeConvENT.Memo = objvFieldTab4CodeConvENS.Memo; //说明
objvFieldTab4CodeConvENT.CodeTab = objvFieldTab4CodeConvENS.CodeTab; //代码表
objvFieldTab4CodeConvENT.CodeTabName = objvFieldTab4CodeConvENS.CodeTabName; //表名
objvFieldTab4CodeConvENT.CodeTabCode = objvFieldTab4CodeConvENS.CodeTabCode; //代码表_代码
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
 /// <param name = "objvFieldTab4CodeConvEN">源简化对象</param>
 public static void SetUpdFlag(clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN)
{
try
{
objvFieldTab4CodeConvEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFieldTab4CodeConvEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFieldTab4CodeConv.FldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4CodeConvEN.FldName = objvFieldTab4CodeConvEN.FldName == "[null]" ? null :  objvFieldTab4CodeConvEN.FldName; //字段名
}
if (arrFldSet.Contains(convFieldTab4CodeConv.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4CodeConvEN.FldId = objvFieldTab4CodeConvEN.FldId; //字段Id
}
if (arrFldSet.Contains(convFieldTab4CodeConv.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4CodeConvEN.PrjId = objvFieldTab4CodeConvEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convFieldTab4CodeConv.CodeTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4CodeConvEN.CodeTabId = objvFieldTab4CodeConvEN.CodeTabId == "[null]" ? null :  objvFieldTab4CodeConvEN.CodeTabId; //代码表Id
}
if (arrFldSet.Contains(convFieldTab4CodeConv.CodeTabNameId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4CodeConvEN.CodeTabNameId = objvFieldTab4CodeConvEN.CodeTabNameId == "[null]" ? null :  objvFieldTab4CodeConvEN.CodeTabNameId; //代码_名Id
}
if (arrFldSet.Contains(convFieldTab4CodeConv.CodeTabCodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4CodeConvEN.CodeTabCodeId = objvFieldTab4CodeConvEN.CodeTabCodeId == "[null]" ? null :  objvFieldTab4CodeConvEN.CodeTabCodeId; //代码Id
}
if (arrFldSet.Contains(convFieldTab4CodeConv.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4CodeConvEN.UpdDate = objvFieldTab4CodeConvEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFieldTab4CodeConv.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4CodeConvEN.UpdUser = objvFieldTab4CodeConvEN.UpdUser == "[null]" ? null :  objvFieldTab4CodeConvEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFieldTab4CodeConv.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4CodeConvEN.Memo = objvFieldTab4CodeConvEN.Memo == "[null]" ? null :  objvFieldTab4CodeConvEN.Memo; //说明
}
if (arrFldSet.Contains(convFieldTab4CodeConv.CodeTab, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4CodeConvEN.CodeTab = objvFieldTab4CodeConvEN.CodeTab == "[null]" ? null :  objvFieldTab4CodeConvEN.CodeTab; //代码表
}
if (arrFldSet.Contains(convFieldTab4CodeConv.CodeTabName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4CodeConvEN.CodeTabName = objvFieldTab4CodeConvEN.CodeTabName == "[null]" ? null :  objvFieldTab4CodeConvEN.CodeTabName; //表名
}
if (arrFldSet.Contains(convFieldTab4CodeConv.CodeTabCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvFieldTab4CodeConvEN.CodeTabCode = objvFieldTab4CodeConvEN.CodeTabCode == "[null]" ? null :  objvFieldTab4CodeConvEN.CodeTabCode; //代码表_代码
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
 /// <param name = "objvFieldTab4CodeConvEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN)
{
try
{
if (objvFieldTab4CodeConvEN.FldName == "[null]") objvFieldTab4CodeConvEN.FldName = null; //字段名
if (objvFieldTab4CodeConvEN.CodeTabId == "[null]") objvFieldTab4CodeConvEN.CodeTabId = null; //代码表Id
if (objvFieldTab4CodeConvEN.CodeTabNameId == "[null]") objvFieldTab4CodeConvEN.CodeTabNameId = null; //代码_名Id
if (objvFieldTab4CodeConvEN.CodeTabCodeId == "[null]") objvFieldTab4CodeConvEN.CodeTabCodeId = null; //代码Id
if (objvFieldTab4CodeConvEN.UpdUser == "[null]") objvFieldTab4CodeConvEN.UpdUser = null; //修改者
if (objvFieldTab4CodeConvEN.Memo == "[null]") objvFieldTab4CodeConvEN.Memo = null; //说明
if (objvFieldTab4CodeConvEN.CodeTab == "[null]") objvFieldTab4CodeConvEN.CodeTab = null; //代码表
if (objvFieldTab4CodeConvEN.CodeTabName == "[null]") objvFieldTab4CodeConvEN.CodeTabName = null; //表名
if (objvFieldTab4CodeConvEN.CodeTabCode == "[null]") objvFieldTab4CodeConvEN.CodeTabCode = null; //代码表_代码
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
public static void CheckProperty4Condition(clsvFieldTab4CodeConvEN objvFieldTab4CodeConvEN)
{
 vFieldTab4CodeConvDA.CheckProperty4Condition(objvFieldTab4CodeConvEN);
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
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTab4CodeConvBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTab4CodeConvBL没有刷新缓存机制(clsFieldTab4CodeConvBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FldId");
//if (arrvFieldTab4CodeConvObjLstCache == null)
//{
//arrvFieldTab4CodeConvObjLstCache = vFieldTab4CodeConvDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFldId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFieldTab4CodeConvEN GetObjByFldIdCache(string strFldId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFieldTab4CodeConvEN._CurrTabName, strPrjId);
List<clsvFieldTab4CodeConvEN> arrvFieldTab4CodeConvObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab4CodeConvEN> arrvFieldTab4CodeConvObjLst_Sel =
arrvFieldTab4CodeConvObjLstCache
.Where(x=> x.FldId == strFldId 
);
if (arrvFieldTab4CodeConvObjLst_Sel.Count() == 0)
{
   clsvFieldTab4CodeConvEN obj = clsvFieldTab4CodeConvBL.GetObjByFldId(strFldId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strFldId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvFieldTab4CodeConvObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTab4CodeConvEN> GetAllvFieldTab4CodeConvObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvFieldTab4CodeConvEN> arrvFieldTab4CodeConvObjLstCache = GetObjLstCache(strPrjId); 
return arrvFieldTab4CodeConvObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFieldTab4CodeConvEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvFieldTab4CodeConvEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvFieldTab4CodeConvEN> arrvFieldTab4CodeConvObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvFieldTab4CodeConvObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvFieldTab4CodeConvEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvFieldTab4CodeConvEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFieldTab4CodeConvEN._RefreshTimeLst.Count == 0) return "";
return clsvFieldTab4CodeConvEN._RefreshTimeLst[clsvFieldTab4CodeConvEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strFldId, string strPrjId)
{
if (strInFldName != convFieldTab4CodeConv.FldId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFieldTab4CodeConv._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFieldTab4CodeConv._AttributeName));
throw new Exception(strMsg);
}
var objvFieldTab4CodeConv = clsvFieldTab4CodeConvBL.GetObjByFldIdCache(strFldId, strPrjId);
if (objvFieldTab4CodeConv == null) return "";
return objvFieldTab4CodeConv[strOutFldName].ToString();
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
int intRecCount = clsvFieldTab4CodeConvDA.GetRecCount(strTabName);
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
int intRecCount = clsvFieldTab4CodeConvDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFieldTab4CodeConvDA.GetRecCount();
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
int intRecCount = clsvFieldTab4CodeConvDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFieldTab4CodeConvCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFieldTab4CodeConvEN objvFieldTab4CodeConvCond)
{
 string strPrjId = objvFieldTab4CodeConvCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvFieldTab4CodeConvBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvFieldTab4CodeConvEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvFieldTab4CodeConvEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFieldTab4CodeConv._AttributeName)
{
if (objvFieldTab4CodeConvCond.IsUpdated(strFldName) == false) continue;
if (objvFieldTab4CodeConvCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab4CodeConvCond[strFldName].ToString());
}
else
{
if (objvFieldTab4CodeConvCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFieldTab4CodeConvCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFieldTab4CodeConvCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFieldTab4CodeConvCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFieldTab4CodeConvCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFieldTab4CodeConvCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFieldTab4CodeConvCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFieldTab4CodeConvCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFieldTab4CodeConvCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFieldTab4CodeConvCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFieldTab4CodeConvCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFieldTab4CodeConvCond[strFldName]));
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
 List<string> arrList = clsvFieldTab4CodeConvDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFieldTab4CodeConvDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFieldTab4CodeConvDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}