
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcss_StyleBL
 表名:vcss_Style(00050471)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:00
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:样式表管理(CssManage)
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
public static class  clsvcss_StyleBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcss_StyleEN GetObj(this K_StyleId_vcss_Style myKey)
{
clsvcss_StyleEN objvcss_StyleEN = clsvcss_StyleBL.vcss_StyleDA.GetObjByStyleId(myKey.Value);
return objvcss_StyleEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetStyleId(this clsvcss_StyleEN objvcss_StyleEN, string strStyleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyleId, 8, convcss_Style.StyleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStyleId, 8, convcss_Style.StyleId);
}
objvcss_StyleEN.StyleId = strStyleId; //样式ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.StyleId) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.StyleId, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.StyleId] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetCtlTypeId(this clsvcss_StyleEN objvcss_StyleEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, convcss_Style.CtlTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, convcss_Style.CtlTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, convcss_Style.CtlTypeId);
}
objvcss_StyleEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.CtlTypeId) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.CtlTypeId, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.CtlTypeId] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetCtlTypeName(this clsvcss_StyleEN objvcss_StyleEN, string strCtlTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCtlTypeName, 30, convcss_Style.CtlTypeName);
}
objvcss_StyleEN.CtlTypeName = strCtlTypeName; //控件类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.CtlTypeName) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.CtlTypeName, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.CtlTypeName] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetStyleName(this clsvcss_StyleEN objvcss_StyleEN, string strStyleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyleName, 50, convcss_Style.StyleName);
}
objvcss_StyleEN.StyleName = strStyleName; //样式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.StyleName) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.StyleName, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.StyleName] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetStyleDesc(this clsvcss_StyleEN objvcss_StyleEN, string strStyleDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyleDesc, 1000, convcss_Style.StyleDesc);
}
objvcss_StyleEN.StyleDesc = strStyleDesc; //样式描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.StyleDesc) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.StyleDesc, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.StyleDesc] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetStyleContent(this clsvcss_StyleEN objvcss_StyleEN, string strStyleContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStyleContent, 1000, convcss_Style.StyleContent);
}
objvcss_StyleEN.StyleContent = strStyleContent; //样式内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.StyleContent) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.StyleContent, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.StyleContent] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetIsDeleted(this clsvcss_StyleEN objvcss_StyleEN, bool bolIsDeleted, string strComparisonOp="")
	{
objvcss_StyleEN.IsDeleted = bolIsDeleted; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.IsDeleted) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.IsDeleted, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.IsDeleted] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetDeletedDate(this clsvcss_StyleEN objvcss_StyleEN, string strDeletedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDeletedDate, 50, convcss_Style.DeletedDate);
}
objvcss_StyleEN.DeletedDate = strDeletedDate; //删除日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.DeletedDate) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.DeletedDate, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.DeletedDate] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetUpdDate(this clsvcss_StyleEN objvcss_StyleEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcss_Style.UpdDate);
}
objvcss_StyleEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.UpdDate) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.UpdDate, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.UpdDate] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetUpdUser(this clsvcss_StyleEN objvcss_StyleEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcss_Style.UpdUser);
}
objvcss_StyleEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.UpdUser) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.UpdUser, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.UpdUser] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcss_StyleEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcss_StyleEN SetMemo(this clsvcss_StyleEN objvcss_StyleEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcss_Style.Memo);
}
objvcss_StyleEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcss_StyleEN.dicFldComparisonOp.ContainsKey(convcss_Style.Memo) == false)
{
objvcss_StyleEN.dicFldComparisonOp.Add(convcss_Style.Memo, strComparisonOp);
}
else
{
objvcss_StyleEN.dicFldComparisonOp[convcss_Style.Memo] = strComparisonOp;
}
}
return objvcss_StyleEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcss_StyleENS">源对象</param>
 /// <param name = "objvcss_StyleENT">目标对象</param>
 public static void CopyTo(this clsvcss_StyleEN objvcss_StyleENS, clsvcss_StyleEN objvcss_StyleENT)
{
try
{
objvcss_StyleENT.StyleId = objvcss_StyleENS.StyleId; //样式ID
objvcss_StyleENT.CtlTypeId = objvcss_StyleENS.CtlTypeId; //控件类型号
objvcss_StyleENT.CtlTypeName = objvcss_StyleENS.CtlTypeName; //控件类型名
objvcss_StyleENT.StyleName = objvcss_StyleENS.StyleName; //样式名称
objvcss_StyleENT.StyleDesc = objvcss_StyleENS.StyleDesc; //样式描述
objvcss_StyleENT.StyleContent = objvcss_StyleENS.StyleContent; //样式内容
objvcss_StyleENT.IsDeleted = objvcss_StyleENS.IsDeleted; //是否删除
objvcss_StyleENT.DeletedDate = objvcss_StyleENS.DeletedDate; //删除日期
objvcss_StyleENT.UpdDate = objvcss_StyleENS.UpdDate; //修改日期
objvcss_StyleENT.UpdUser = objvcss_StyleENS.UpdUser; //修改者
objvcss_StyleENT.Memo = objvcss_StyleENS.Memo; //说明
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
 /// <param name = "objvcss_StyleENS">源对象</param>
 /// <returns>目标对象=>clsvcss_StyleEN:objvcss_StyleENT</returns>
 public static clsvcss_StyleEN CopyTo(this clsvcss_StyleEN objvcss_StyleENS)
{
try
{
 clsvcss_StyleEN objvcss_StyleENT = new clsvcss_StyleEN()
{
StyleId = objvcss_StyleENS.StyleId, //样式ID
CtlTypeId = objvcss_StyleENS.CtlTypeId, //控件类型号
CtlTypeName = objvcss_StyleENS.CtlTypeName, //控件类型名
StyleName = objvcss_StyleENS.StyleName, //样式名称
StyleDesc = objvcss_StyleENS.StyleDesc, //样式描述
StyleContent = objvcss_StyleENS.StyleContent, //样式内容
IsDeleted = objvcss_StyleENS.IsDeleted, //是否删除
DeletedDate = objvcss_StyleENS.DeletedDate, //删除日期
UpdDate = objvcss_StyleENS.UpdDate, //修改日期
UpdUser = objvcss_StyleENS.UpdUser, //修改者
Memo = objvcss_StyleENS.Memo, //说明
};
 return objvcss_StyleENT;
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
public static void CheckProperty4Condition(this clsvcss_StyleEN objvcss_StyleEN)
{
 clsvcss_StyleBL.vcss_StyleDA.CheckProperty4Condition(objvcss_StyleEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcss_StyleEN objvcss_StyleCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcss_StyleCond.IsUpdated(convcss_Style.StyleId) == true)
{
string strComparisonOpStyleId = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.StyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.StyleId, objvcss_StyleCond.StyleId, strComparisonOpStyleId);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.CtlTypeId, objvcss_StyleCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.CtlTypeName) == true)
{
string strComparisonOpCtlTypeName = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.CtlTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.CtlTypeName, objvcss_StyleCond.CtlTypeName, strComparisonOpCtlTypeName);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.StyleName) == true)
{
string strComparisonOpStyleName = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.StyleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.StyleName, objvcss_StyleCond.StyleName, strComparisonOpStyleName);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.StyleDesc) == true)
{
string strComparisonOpStyleDesc = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.StyleDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.StyleDesc, objvcss_StyleCond.StyleDesc, strComparisonOpStyleDesc);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.StyleContent) == true)
{
string strComparisonOpStyleContent = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.StyleContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.StyleContent, objvcss_StyleCond.StyleContent, strComparisonOpStyleContent);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.IsDeleted) == true)
{
if (objvcss_StyleCond.IsDeleted == true)
{
strWhereCond += string.Format(" And {0} = '1'", convcss_Style.IsDeleted);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convcss_Style.IsDeleted);
}
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.DeletedDate) == true)
{
string strComparisonOpDeletedDate = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.DeletedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.DeletedDate, objvcss_StyleCond.DeletedDate, strComparisonOpDeletedDate);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.UpdDate, objvcss_StyleCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.UpdUser, objvcss_StyleCond.UpdUser, strComparisonOpUpdUser);
}
if (objvcss_StyleCond.IsUpdated(convcss_Style.Memo) == true)
{
string strComparisonOpMemo = objvcss_StyleCond.dicFldComparisonOp[convcss_Style.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcss_Style.Memo, objvcss_StyleCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcss_Style
{
public virtual bool UpdRelaTabDate(string strStyleId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vcss_Style(vcss_Style)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcss_StyleBL
{
public static RelatedActions_vcss_Style relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcss_StyleDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcss_StyleDA vcss_StyleDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcss_StyleDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcss_StyleBL()
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
if (string.IsNullOrEmpty(clsvcss_StyleEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcss_StyleEN._ConnectString);
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
public static DataTable GetDataTable_vcss_Style(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcss_StyleDA.GetDataTable_vcss_Style(strWhereCond);
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
objDT = vcss_StyleDA.GetDataTable(strWhereCond);
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
objDT = vcss_StyleDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcss_StyleDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcss_StyleDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcss_StyleDA.GetDataTable_Top(objTopPara);
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
objDT = vcss_StyleDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcss_StyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcss_StyleDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcss_StyleEN> GetObjLstByStyleIdLst(List<string> arrStyleIdLst)
{
List<clsvcss_StyleEN> arrObjLst = new List<clsvcss_StyleEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrStyleIdLst, true);
 string strWhereCond = string.Format("StyleId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN();
try
{
objvcss_StyleEN.StyleId = objRow[convcss_Style.StyleId].ToString().Trim(); //样式ID
objvcss_StyleEN.CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objvcss_StyleEN.CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名
objvcss_StyleEN.StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(); //样式名称
objvcss_StyleEN.StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(); //样式描述
objvcss_StyleEN.StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(); //样式内容
objvcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convcss_Style.IsDeleted].ToString().Trim()); //是否删除
objvcss_StyleEN.DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(); //删除日期
objvcss_StyleEN.UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(); //修改日期
objvcss_StyleEN.UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(); //修改者
objvcss_StyleEN.Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_StyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrStyleIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcss_StyleEN> GetObjLstByStyleIdLstCache(List<string> arrStyleIdLst)
{
string strKey = string.Format("{0}", clsvcss_StyleEN._CurrTabName);
List<clsvcss_StyleEN> arrvcss_StyleObjLstCache = GetObjLstCache();
IEnumerable <clsvcss_StyleEN> arrvcss_StyleObjLst_Sel =
arrvcss_StyleObjLstCache
.Where(x => arrStyleIdLst.Contains(x.StyleId));
return arrvcss_StyleObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_StyleEN> GetObjLst(string strWhereCond)
{
List<clsvcss_StyleEN> arrObjLst = new List<clsvcss_StyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN();
try
{
objvcss_StyleEN.StyleId = objRow[convcss_Style.StyleId].ToString().Trim(); //样式ID
objvcss_StyleEN.CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objvcss_StyleEN.CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名
objvcss_StyleEN.StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(); //样式名称
objvcss_StyleEN.StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(); //样式描述
objvcss_StyleEN.StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(); //样式内容
objvcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convcss_Style.IsDeleted].ToString().Trim()); //是否删除
objvcss_StyleEN.DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(); //删除日期
objvcss_StyleEN.UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(); //修改日期
objvcss_StyleEN.UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(); //修改者
objvcss_StyleEN.Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_StyleEN);
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
public static List<clsvcss_StyleEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcss_StyleEN> arrObjLst = new List<clsvcss_StyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN();
try
{
objvcss_StyleEN.StyleId = objRow[convcss_Style.StyleId].ToString().Trim(); //样式ID
objvcss_StyleEN.CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objvcss_StyleEN.CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名
objvcss_StyleEN.StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(); //样式名称
objvcss_StyleEN.StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(); //样式描述
objvcss_StyleEN.StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(); //样式内容
objvcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convcss_Style.IsDeleted].ToString().Trim()); //是否删除
objvcss_StyleEN.DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(); //删除日期
objvcss_StyleEN.UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(); //修改日期
objvcss_StyleEN.UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(); //修改者
objvcss_StyleEN.Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_StyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcss_StyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcss_StyleEN> GetSubObjLstCache(clsvcss_StyleEN objvcss_StyleCond)
{
List<clsvcss_StyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcss_StyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcss_Style._AttributeName)
{
if (objvcss_StyleCond.IsUpdated(strFldName) == false) continue;
if (objvcss_StyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcss_StyleCond[strFldName].ToString());
}
else
{
if (objvcss_StyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcss_StyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcss_StyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcss_StyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcss_StyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcss_StyleCond[strFldName]));
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
public static List<clsvcss_StyleEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcss_StyleEN> arrObjLst = new List<clsvcss_StyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN();
try
{
objvcss_StyleEN.StyleId = objRow[convcss_Style.StyleId].ToString().Trim(); //样式ID
objvcss_StyleEN.CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objvcss_StyleEN.CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名
objvcss_StyleEN.StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(); //样式名称
objvcss_StyleEN.StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(); //样式描述
objvcss_StyleEN.StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(); //样式内容
objvcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convcss_Style.IsDeleted].ToString().Trim()); //是否删除
objvcss_StyleEN.DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(); //删除日期
objvcss_StyleEN.UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(); //修改日期
objvcss_StyleEN.UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(); //修改者
objvcss_StyleEN.Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_StyleEN);
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
public static List<clsvcss_StyleEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcss_StyleEN> arrObjLst = new List<clsvcss_StyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN();
try
{
objvcss_StyleEN.StyleId = objRow[convcss_Style.StyleId].ToString().Trim(); //样式ID
objvcss_StyleEN.CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objvcss_StyleEN.CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名
objvcss_StyleEN.StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(); //样式名称
objvcss_StyleEN.StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(); //样式描述
objvcss_StyleEN.StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(); //样式内容
objvcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convcss_Style.IsDeleted].ToString().Trim()); //是否删除
objvcss_StyleEN.DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(); //删除日期
objvcss_StyleEN.UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(); //修改日期
objvcss_StyleEN.UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(); //修改者
objvcss_StyleEN.Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_StyleEN);
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
List<clsvcss_StyleEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcss_StyleEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_StyleEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcss_StyleEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcss_StyleEN> arrObjLst = new List<clsvcss_StyleEN>(); 
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
	clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN();
try
{
objvcss_StyleEN.StyleId = objRow[convcss_Style.StyleId].ToString().Trim(); //样式ID
objvcss_StyleEN.CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objvcss_StyleEN.CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名
objvcss_StyleEN.StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(); //样式名称
objvcss_StyleEN.StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(); //样式描述
objvcss_StyleEN.StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(); //样式内容
objvcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convcss_Style.IsDeleted].ToString().Trim()); //是否删除
objvcss_StyleEN.DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(); //删除日期
objvcss_StyleEN.UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(); //修改日期
objvcss_StyleEN.UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(); //修改者
objvcss_StyleEN.Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_StyleEN);
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
public static List<clsvcss_StyleEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcss_StyleEN> arrObjLst = new List<clsvcss_StyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN();
try
{
objvcss_StyleEN.StyleId = objRow[convcss_Style.StyleId].ToString().Trim(); //样式ID
objvcss_StyleEN.CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objvcss_StyleEN.CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名
objvcss_StyleEN.StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(); //样式名称
objvcss_StyleEN.StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(); //样式描述
objvcss_StyleEN.StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(); //样式内容
objvcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convcss_Style.IsDeleted].ToString().Trim()); //是否删除
objvcss_StyleEN.DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(); //删除日期
objvcss_StyleEN.UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(); //修改日期
objvcss_StyleEN.UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(); //修改者
objvcss_StyleEN.Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_StyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcss_StyleEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcss_StyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcss_StyleEN> arrObjLst = new List<clsvcss_StyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN();
try
{
objvcss_StyleEN.StyleId = objRow[convcss_Style.StyleId].ToString().Trim(); //样式ID
objvcss_StyleEN.CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objvcss_StyleEN.CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名
objvcss_StyleEN.StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(); //样式名称
objvcss_StyleEN.StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(); //样式描述
objvcss_StyleEN.StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(); //样式内容
objvcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convcss_Style.IsDeleted].ToString().Trim()); //是否删除
objvcss_StyleEN.DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(); //删除日期
objvcss_StyleEN.UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(); //修改日期
objvcss_StyleEN.UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(); //修改者
objvcss_StyleEN.Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_StyleEN);
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
public static List<clsvcss_StyleEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcss_StyleEN> arrObjLst = new List<clsvcss_StyleEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN();
try
{
objvcss_StyleEN.StyleId = objRow[convcss_Style.StyleId].ToString().Trim(); //样式ID
objvcss_StyleEN.CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objvcss_StyleEN.CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名
objvcss_StyleEN.StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(); //样式名称
objvcss_StyleEN.StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(); //样式描述
objvcss_StyleEN.StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(); //样式内容
objvcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convcss_Style.IsDeleted].ToString().Trim()); //是否删除
objvcss_StyleEN.DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(); //删除日期
objvcss_StyleEN.UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(); //修改日期
objvcss_StyleEN.UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(); //修改者
objvcss_StyleEN.Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_StyleEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcss_StyleEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcss_StyleEN> arrObjLst = new List<clsvcss_StyleEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcss_StyleEN objvcss_StyleEN = new clsvcss_StyleEN();
try
{
objvcss_StyleEN.StyleId = objRow[convcss_Style.StyleId].ToString().Trim(); //样式ID
objvcss_StyleEN.CtlTypeId = objRow[convcss_Style.CtlTypeId].ToString().Trim(); //控件类型号
objvcss_StyleEN.CtlTypeName = objRow[convcss_Style.CtlTypeName] == DBNull.Value ? null : objRow[convcss_Style.CtlTypeName].ToString().Trim(); //控件类型名
objvcss_StyleEN.StyleName = objRow[convcss_Style.StyleName] == DBNull.Value ? null : objRow[convcss_Style.StyleName].ToString().Trim(); //样式名称
objvcss_StyleEN.StyleDesc = objRow[convcss_Style.StyleDesc] == DBNull.Value ? null : objRow[convcss_Style.StyleDesc].ToString().Trim(); //样式描述
objvcss_StyleEN.StyleContent = objRow[convcss_Style.StyleContent] == DBNull.Value ? null : objRow[convcss_Style.StyleContent].ToString().Trim(); //样式内容
objvcss_StyleEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convcss_Style.IsDeleted].ToString().Trim()); //是否删除
objvcss_StyleEN.DeletedDate = objRow[convcss_Style.DeletedDate] == DBNull.Value ? null : objRow[convcss_Style.DeletedDate].ToString().Trim(); //删除日期
objvcss_StyleEN.UpdDate = objRow[convcss_Style.UpdDate] == DBNull.Value ? null : objRow[convcss_Style.UpdDate].ToString().Trim(); //修改日期
objvcss_StyleEN.UpdUser = objRow[convcss_Style.UpdUser] == DBNull.Value ? null : objRow[convcss_Style.UpdUser].ToString().Trim(); //修改者
objvcss_StyleEN.Memo = objRow[convcss_Style.Memo] == DBNull.Value ? null : objRow[convcss_Style.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcss_StyleEN.StyleId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcss_StyleEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcss_StyleEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcss_Style(ref clsvcss_StyleEN objvcss_StyleEN)
{
bool bolResult = vcss_StyleDA.Getvcss_Style(ref objvcss_StyleEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strStyleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcss_StyleEN GetObjByStyleId(string strStyleId)
{
if (strStyleId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strStyleId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strStyleId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvcss_StyleEN objvcss_StyleEN = vcss_StyleDA.GetObjByStyleId(strStyleId);
return objvcss_StyleEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcss_StyleEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcss_StyleEN objvcss_StyleEN = vcss_StyleDA.GetFirstObj(strWhereCond);
 return objvcss_StyleEN;
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
public static clsvcss_StyleEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcss_StyleEN objvcss_StyleEN = vcss_StyleDA.GetObjByDataRow(objRow);
 return objvcss_StyleEN;
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
public static clsvcss_StyleEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcss_StyleEN objvcss_StyleEN = vcss_StyleDA.GetObjByDataRow(objRow);
 return objvcss_StyleEN;
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
 /// <param name = "strStyleId">所给的关键字</param>
 /// <param name = "lstvcss_StyleObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcss_StyleEN GetObjByStyleIdFromList(string strStyleId, List<clsvcss_StyleEN> lstvcss_StyleObjLst)
{
foreach (clsvcss_StyleEN objvcss_StyleEN in lstvcss_StyleObjLst)
{
if (objvcss_StyleEN.StyleId == strStyleId)
{
return objvcss_StyleEN;
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
 string strStyleId;
 try
 {
 strStyleId = new clsvcss_StyleDA().GetFirstID(strWhereCond);
 return strStyleId;
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
 arrList = vcss_StyleDA.GetID(strWhereCond);
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
bool bolIsExist = vcss_StyleDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strStyleId)
{
if (string.IsNullOrEmpty(strStyleId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strStyleId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vcss_StyleDA.IsExist(strStyleId);
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
 bolIsExist = clsvcss_StyleDA.IsExistTable();
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
 bolIsExist = vcss_StyleDA.IsExistTable(strTabName);
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
 /// <param name = "objvcss_StyleENS">源对象</param>
 /// <param name = "objvcss_StyleENT">目标对象</param>
 public static void CopyTo(clsvcss_StyleEN objvcss_StyleENS, clsvcss_StyleEN objvcss_StyleENT)
{
try
{
objvcss_StyleENT.StyleId = objvcss_StyleENS.StyleId; //样式ID
objvcss_StyleENT.CtlTypeId = objvcss_StyleENS.CtlTypeId; //控件类型号
objvcss_StyleENT.CtlTypeName = objvcss_StyleENS.CtlTypeName; //控件类型名
objvcss_StyleENT.StyleName = objvcss_StyleENS.StyleName; //样式名称
objvcss_StyleENT.StyleDesc = objvcss_StyleENS.StyleDesc; //样式描述
objvcss_StyleENT.StyleContent = objvcss_StyleENS.StyleContent; //样式内容
objvcss_StyleENT.IsDeleted = objvcss_StyleENS.IsDeleted; //是否删除
objvcss_StyleENT.DeletedDate = objvcss_StyleENS.DeletedDate; //删除日期
objvcss_StyleENT.UpdDate = objvcss_StyleENS.UpdDate; //修改日期
objvcss_StyleENT.UpdUser = objvcss_StyleENS.UpdUser; //修改者
objvcss_StyleENT.Memo = objvcss_StyleENS.Memo; //说明
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
 /// <param name = "objvcss_StyleEN">源简化对象</param>
 public static void SetUpdFlag(clsvcss_StyleEN objvcss_StyleEN)
{
try
{
objvcss_StyleEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcss_StyleEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcss_Style.StyleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_StyleEN.StyleId = objvcss_StyleEN.StyleId; //样式ID
}
if (arrFldSet.Contains(convcss_Style.CtlTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_StyleEN.CtlTypeId = objvcss_StyleEN.CtlTypeId; //控件类型号
}
if (arrFldSet.Contains(convcss_Style.CtlTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_StyleEN.CtlTypeName = objvcss_StyleEN.CtlTypeName == "[null]" ? null :  objvcss_StyleEN.CtlTypeName; //控件类型名
}
if (arrFldSet.Contains(convcss_Style.StyleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_StyleEN.StyleName = objvcss_StyleEN.StyleName == "[null]" ? null :  objvcss_StyleEN.StyleName; //样式名称
}
if (arrFldSet.Contains(convcss_Style.StyleDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_StyleEN.StyleDesc = objvcss_StyleEN.StyleDesc == "[null]" ? null :  objvcss_StyleEN.StyleDesc; //样式描述
}
if (arrFldSet.Contains(convcss_Style.StyleContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_StyleEN.StyleContent = objvcss_StyleEN.StyleContent == "[null]" ? null :  objvcss_StyleEN.StyleContent; //样式内容
}
if (arrFldSet.Contains(convcss_Style.IsDeleted, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_StyleEN.IsDeleted = objvcss_StyleEN.IsDeleted; //是否删除
}
if (arrFldSet.Contains(convcss_Style.DeletedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_StyleEN.DeletedDate = objvcss_StyleEN.DeletedDate == "[null]" ? null :  objvcss_StyleEN.DeletedDate; //删除日期
}
if (arrFldSet.Contains(convcss_Style.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_StyleEN.UpdDate = objvcss_StyleEN.UpdDate == "[null]" ? null :  objvcss_StyleEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcss_Style.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_StyleEN.UpdUser = objvcss_StyleEN.UpdUser == "[null]" ? null :  objvcss_StyleEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convcss_Style.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcss_StyleEN.Memo = objvcss_StyleEN.Memo == "[null]" ? null :  objvcss_StyleEN.Memo; //说明
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
 /// <param name = "objvcss_StyleEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcss_StyleEN objvcss_StyleEN)
{
try
{
if (objvcss_StyleEN.CtlTypeName == "[null]") objvcss_StyleEN.CtlTypeName = null; //控件类型名
if (objvcss_StyleEN.StyleName == "[null]") objvcss_StyleEN.StyleName = null; //样式名称
if (objvcss_StyleEN.StyleDesc == "[null]") objvcss_StyleEN.StyleDesc = null; //样式描述
if (objvcss_StyleEN.StyleContent == "[null]") objvcss_StyleEN.StyleContent = null; //样式内容
if (objvcss_StyleEN.DeletedDate == "[null]") objvcss_StyleEN.DeletedDate = null; //删除日期
if (objvcss_StyleEN.UpdDate == "[null]") objvcss_StyleEN.UpdDate = null; //修改日期
if (objvcss_StyleEN.UpdUser == "[null]") objvcss_StyleEN.UpdUser = null; //修改者
if (objvcss_StyleEN.Memo == "[null]") objvcss_StyleEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvcss_StyleEN objvcss_StyleEN)
{
 vcss_StyleDA.CheckProperty4Condition(objvcss_StyleEN);
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
if (clscss_StyleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscss_StyleBL没有刷新缓存机制(clscss_StyleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by StyleId");
//if (arrvcss_StyleObjLstCache == null)
//{
//arrvcss_StyleObjLstCache = vcss_StyleDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strStyleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcss_StyleEN GetObjByStyleIdCache(string strStyleId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcss_StyleEN._CurrTabName);
List<clsvcss_StyleEN> arrvcss_StyleObjLstCache = GetObjLstCache();
IEnumerable <clsvcss_StyleEN> arrvcss_StyleObjLst_Sel =
arrvcss_StyleObjLstCache
.Where(x=> x.StyleId == strStyleId 
);
if (arrvcss_StyleObjLst_Sel.Count() == 0)
{
   clsvcss_StyleEN obj = clsvcss_StyleBL.GetObjByStyleId(strStyleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcss_StyleObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcss_StyleEN> GetAllvcss_StyleObjLstCache()
{
//获取缓存中的对象列表
List<clsvcss_StyleEN> arrvcss_StyleObjLstCache = GetObjLstCache(); 
return arrvcss_StyleObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcss_StyleEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcss_StyleEN._CurrTabName);
List<clsvcss_StyleEN> arrvcss_StyleObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcss_StyleObjLstCache;
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
string strKey = string.Format("{0}", clsvcss_StyleEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvcss_StyleEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvcss_StyleEN._RefreshTimeLst.Count == 0) return "";
return clsvcss_StyleEN._RefreshTimeLst[clsvcss_StyleEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strStyleId)
{
if (strInFldName != convcss_Style.StyleId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcss_Style._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcss_Style._AttributeName));
throw new Exception(strMsg);
}
var objvcss_Style = clsvcss_StyleBL.GetObjByStyleIdCache(strStyleId);
if (objvcss_Style == null) return "";
return objvcss_Style[strOutFldName].ToString();
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
int intRecCount = clsvcss_StyleDA.GetRecCount(strTabName);
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
int intRecCount = clsvcss_StyleDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcss_StyleDA.GetRecCount();
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
int intRecCount = clsvcss_StyleDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcss_StyleCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcss_StyleEN objvcss_StyleCond)
{
List<clsvcss_StyleEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcss_StyleEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcss_Style._AttributeName)
{
if (objvcss_StyleCond.IsUpdated(strFldName) == false) continue;
if (objvcss_StyleCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcss_StyleCond[strFldName].ToString());
}
else
{
if (objvcss_StyleCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcss_StyleCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcss_StyleCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcss_StyleCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcss_StyleCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcss_StyleCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcss_StyleCond[strFldName]));
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
 List<string> arrList = clsvcss_StyleDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcss_StyleDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcss_StyleDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}