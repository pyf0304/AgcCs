
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvNewsBL
 表名:vNews(00050480)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:05
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:新闻公告(NewsBulletin)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class clsvNewsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngId_News">表关键字</param>
 /// <returns>表对象</returns>
public static clsvNewsEN GetObj(this K_Id_News_vNews myKey)
{
clsvNewsEN objvNewsEN = clsvNewsBL.vNewsDA.GetObjById_News(myKey.Value);
return objvNewsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetId_News(this clsvNewsEN objvNewsEN, long lngId_News, string strComparisonOp="")
	{
objvNewsEN.Id_News = lngId_News; //Id_News
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvNewsEN.dicFldComparisonOp.ContainsKey(convNews.Id_News) == false)
{
objvNewsEN.dicFldComparisonOp.Add(convNews.Id_News, strComparisonOp);
}
else
{
objvNewsEN.dicFldComparisonOp[convNews.Id_News] = strComparisonOp;
}
}
return objvNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetNewsTypeId(this clsvNewsEN objvNewsEN, string strNewsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strNewsTypeId, convNews.NewsTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNewsTypeId, 1, convNews.NewsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strNewsTypeId, 1, convNews.NewsTypeId);
}
objvNewsEN.NewsTypeId = strNewsTypeId; //信息类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvNewsEN.dicFldComparisonOp.ContainsKey(convNews.NewsTypeId) == false)
{
objvNewsEN.dicFldComparisonOp.Add(convNews.NewsTypeId, strComparisonOp);
}
else
{
objvNewsEN.dicFldComparisonOp[convNews.NewsTypeId] = strComparisonOp;
}
}
return objvNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetNewsTypeName(this clsvNewsEN objvNewsEN, string strNewsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNewsTypeName, 50, convNews.NewsTypeName);
}
objvNewsEN.NewsTypeName = strNewsTypeName; //信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvNewsEN.dicFldComparisonOp.ContainsKey(convNews.NewsTypeName) == false)
{
objvNewsEN.dicFldComparisonOp.Add(convNews.NewsTypeName, strComparisonOp);
}
else
{
objvNewsEN.dicFldComparisonOp[convNews.NewsTypeName] = strComparisonOp;
}
}
return objvNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetNewsTitle(this clsvNewsEN objvNewsEN, string strNewsTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNewsTitle, 50, convNews.NewsTitle);
}
objvNewsEN.NewsTitle = strNewsTitle; //信息标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvNewsEN.dicFldComparisonOp.ContainsKey(convNews.NewsTitle) == false)
{
objvNewsEN.dicFldComparisonOp.Add(convNews.NewsTitle, strComparisonOp);
}
else
{
objvNewsEN.dicFldComparisonOp[convNews.NewsTitle] = strComparisonOp;
}
}
return objvNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetNewsContent(this clsvNewsEN objvNewsEN, string strNewsContent, string strComparisonOp="")
	{
objvNewsEN.NewsContent = strNewsContent; //信息内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvNewsEN.dicFldComparisonOp.ContainsKey(convNews.NewsContent) == false)
{
objvNewsEN.dicFldComparisonOp.Add(convNews.NewsContent, strComparisonOp);
}
else
{
objvNewsEN.dicFldComparisonOp[convNews.NewsContent] = strComparisonOp;
}
}
return objvNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetImgPath(this clsvNewsEN objvNewsEN, string strImgPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImgPath, 500, convNews.ImgPath);
}
objvNewsEN.ImgPath = strImgPath; //图片路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvNewsEN.dicFldComparisonOp.ContainsKey(convNews.ImgPath) == false)
{
objvNewsEN.dicFldComparisonOp.Add(convNews.ImgPath, strComparisonOp);
}
else
{
objvNewsEN.dicFldComparisonOp[convNews.ImgPath] = strComparisonOp;
}
}
return objvNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetEditPeople(this clsvNewsEN objvNewsEN, string strEditPeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEditPeople, 50, convNews.EditPeople);
}
objvNewsEN.EditPeople = strEditPeople; //编辑人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvNewsEN.dicFldComparisonOp.ContainsKey(convNews.EditPeople) == false)
{
objvNewsEN.dicFldComparisonOp.Add(convNews.EditPeople, strComparisonOp);
}
else
{
objvNewsEN.dicFldComparisonOp[convNews.EditPeople] = strComparisonOp;
}
}
return objvNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetEditTime(this clsvNewsEN objvNewsEN, string strEditTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEditTime, 20, convNews.EditTime);
}
objvNewsEN.EditTime = strEditTime; //编辑时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvNewsEN.dicFldComparisonOp.ContainsKey(convNews.EditTime) == false)
{
objvNewsEN.dicFldComparisonOp.Add(convNews.EditTime, strComparisonOp);
}
else
{
objvNewsEN.dicFldComparisonOp[convNews.EditTime] = strComparisonOp;
}
}
return objvNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetSource(this clsvNewsEN objvNewsEN, string strSource, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSource, 50, convNews.Source);
}
objvNewsEN.Source = strSource; //来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvNewsEN.dicFldComparisonOp.ContainsKey(convNews.Source) == false)
{
objvNewsEN.dicFldComparisonOp.Add(convNews.Source, strComparisonOp);
}
else
{
objvNewsEN.dicFldComparisonOp[convNews.Source] = strComparisonOp;
}
}
return objvNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetIsTop(this clsvNewsEN objvNewsEN, bool bolIsTop, string strComparisonOp="")
	{
objvNewsEN.IsTop = bolIsTop; //是否置顶
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvNewsEN.dicFldComparisonOp.ContainsKey(convNews.IsTop) == false)
{
objvNewsEN.dicFldComparisonOp.Add(convNews.IsTop, strComparisonOp);
}
else
{
objvNewsEN.dicFldComparisonOp[convNews.IsTop] = strComparisonOp;
}
}
return objvNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetViews(this clsvNewsEN objvNewsEN, int intViews, string strComparisonOp="")
	{
objvNewsEN.Views = intViews; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvNewsEN.dicFldComparisonOp.ContainsKey(convNews.Views) == false)
{
objvNewsEN.dicFldComparisonOp.Add(convNews.Views, strComparisonOp);
}
else
{
objvNewsEN.dicFldComparisonOp[convNews.Views] = strComparisonOp;
}
}
return objvNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetAudit(this clsvNewsEN objvNewsEN, string strAudit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAudit, 1, convNews.Audit);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAudit, 1, convNews.Audit);
}
objvNewsEN.Audit = strAudit; //审核
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvNewsEN.dicFldComparisonOp.ContainsKey(convNews.Audit) == false)
{
objvNewsEN.dicFldComparisonOp.Add(convNews.Audit, strComparisonOp);
}
else
{
objvNewsEN.dicFldComparisonOp[convNews.Audit] = strComparisonOp;
}
}
return objvNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetMemo(this clsvNewsEN objvNewsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convNews.Memo);
}
objvNewsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvNewsEN.dicFldComparisonOp.ContainsKey(convNews.Memo) == false)
{
objvNewsEN.dicFldComparisonOp.Add(convNews.Memo, strComparisonOp);
}
else
{
objvNewsEN.dicFldComparisonOp[convNews.Memo] = strComparisonOp;
}
}
return objvNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetDeletedDate(this clsvNewsEN objvNewsEN, string strDeletedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDeletedDate, 50, convNews.DeletedDate);
}
objvNewsEN.DeletedDate = strDeletedDate; //删除日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvNewsEN.dicFldComparisonOp.ContainsKey(convNews.DeletedDate) == false)
{
objvNewsEN.dicFldComparisonOp.Add(convNews.DeletedDate, strComparisonOp);
}
else
{
objvNewsEN.dicFldComparisonOp[convNews.DeletedDate] = strComparisonOp;
}
}
return objvNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetIsDeleted(this clsvNewsEN objvNewsEN, bool bolIsDeleted, string strComparisonOp="")
	{
objvNewsEN.IsDeleted = bolIsDeleted; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvNewsEN.dicFldComparisonOp.ContainsKey(convNews.IsDeleted) == false)
{
objvNewsEN.dicFldComparisonOp.Add(convNews.IsDeleted, strComparisonOp);
}
else
{
objvNewsEN.dicFldComparisonOp[convNews.IsDeleted] = strComparisonOp;
}
}
return objvNewsEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvNewsENS">源对象</param>
 /// <param name = "objvNewsENT">目标对象</param>
 public static void CopyTo(this clsvNewsEN objvNewsENS, clsvNewsEN objvNewsENT)
{
try
{
objvNewsENT.Id_News = objvNewsENS.Id_News; //Id_News
objvNewsENT.NewsTypeId = objvNewsENS.NewsTypeId; //信息类型Id
objvNewsENT.NewsTypeName = objvNewsENS.NewsTypeName; //信息类型名称
objvNewsENT.NewsTitle = objvNewsENS.NewsTitle; //信息标题
objvNewsENT.NewsContent = objvNewsENS.NewsContent; //信息内容
objvNewsENT.ImgPath = objvNewsENS.ImgPath; //图片路径
objvNewsENT.EditPeople = objvNewsENS.EditPeople; //编辑人
objvNewsENT.EditTime = objvNewsENS.EditTime; //编辑时间
objvNewsENT.Source = objvNewsENS.Source; //来源
objvNewsENT.IsTop = objvNewsENS.IsTop; //是否置顶
objvNewsENT.Views = objvNewsENS.Views; //浏览量
objvNewsENT.Audit = objvNewsENS.Audit; //审核
objvNewsENT.Memo = objvNewsENS.Memo; //说明
objvNewsENT.DeletedDate = objvNewsENS.DeletedDate; //删除日期
objvNewsENT.IsDeleted = objvNewsENS.IsDeleted; //是否删除
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
 /// <param name = "objvNewsENS">源对象</param>
 /// <returns>目标对象=>clsvNewsEN:objvNewsENT</returns>
 public static clsvNewsEN CopyTo(this clsvNewsEN objvNewsENS)
{
try
{
 clsvNewsEN objvNewsENT = new clsvNewsEN()
{
Id_News = objvNewsENS.Id_News, //Id_News
NewsTypeId = objvNewsENS.NewsTypeId, //信息类型Id
NewsTypeName = objvNewsENS.NewsTypeName, //信息类型名称
NewsTitle = objvNewsENS.NewsTitle, //信息标题
NewsContent = objvNewsENS.NewsContent, //信息内容
ImgPath = objvNewsENS.ImgPath, //图片路径
EditPeople = objvNewsENS.EditPeople, //编辑人
EditTime = objvNewsENS.EditTime, //编辑时间
Source = objvNewsENS.Source, //来源
IsTop = objvNewsENS.IsTop, //是否置顶
Views = objvNewsENS.Views, //浏览量
Audit = objvNewsENS.Audit, //审核
Memo = objvNewsENS.Memo, //说明
DeletedDate = objvNewsENS.DeletedDate, //删除日期
IsDeleted = objvNewsENS.IsDeleted, //是否删除
};
 return objvNewsENT;
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
public static void CheckProperty4Condition(this clsvNewsEN objvNewsEN)
{
 clsvNewsBL.vNewsDA.CheckProperty4Condition(objvNewsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvNewsEN objvNewsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvNewsCond.IsUpdated(convNews.Id_News) == true)
{
string strComparisonOpId_News = objvNewsCond.dicFldComparisonOp[convNews.Id_News];
strWhereCond += string.Format(" And {0} {2} {1}", convNews.Id_News, objvNewsCond.Id_News, strComparisonOpId_News);
}
if (objvNewsCond.IsUpdated(convNews.NewsTypeId) == true)
{
string strComparisonOpNewsTypeId = objvNewsCond.dicFldComparisonOp[convNews.NewsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.NewsTypeId, objvNewsCond.NewsTypeId, strComparisonOpNewsTypeId);
}
if (objvNewsCond.IsUpdated(convNews.NewsTypeName) == true)
{
string strComparisonOpNewsTypeName = objvNewsCond.dicFldComparisonOp[convNews.NewsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.NewsTypeName, objvNewsCond.NewsTypeName, strComparisonOpNewsTypeName);
}
if (objvNewsCond.IsUpdated(convNews.NewsTitle) == true)
{
string strComparisonOpNewsTitle = objvNewsCond.dicFldComparisonOp[convNews.NewsTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.NewsTitle, objvNewsCond.NewsTitle, strComparisonOpNewsTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理！
if (objvNewsCond.IsUpdated(convNews.ImgPath) == true)
{
string strComparisonOpImgPath = objvNewsCond.dicFldComparisonOp[convNews.ImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.ImgPath, objvNewsCond.ImgPath, strComparisonOpImgPath);
}
if (objvNewsCond.IsUpdated(convNews.EditPeople) == true)
{
string strComparisonOpEditPeople = objvNewsCond.dicFldComparisonOp[convNews.EditPeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.EditPeople, objvNewsCond.EditPeople, strComparisonOpEditPeople);
}
if (objvNewsCond.IsUpdated(convNews.EditTime) == true)
{
string strComparisonOpEditTime = objvNewsCond.dicFldComparisonOp[convNews.EditTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.EditTime, objvNewsCond.EditTime, strComparisonOpEditTime);
}
if (objvNewsCond.IsUpdated(convNews.Source) == true)
{
string strComparisonOpSource = objvNewsCond.dicFldComparisonOp[convNews.Source];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.Source, objvNewsCond.Source, strComparisonOpSource);
}
if (objvNewsCond.IsUpdated(convNews.IsTop) == true)
{
if (objvNewsCond.IsTop == true)
{
strWhereCond += string.Format(" And {0} = '1'", convNews.IsTop);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convNews.IsTop);
}
}
if (objvNewsCond.IsUpdated(convNews.Views) == true)
{
string strComparisonOpViews = objvNewsCond.dicFldComparisonOp[convNews.Views];
strWhereCond += string.Format(" And {0} {2} {1}", convNews.Views, objvNewsCond.Views, strComparisonOpViews);
}
if (objvNewsCond.IsUpdated(convNews.Audit) == true)
{
string strComparisonOpAudit = objvNewsCond.dicFldComparisonOp[convNews.Audit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.Audit, objvNewsCond.Audit, strComparisonOpAudit);
}
if (objvNewsCond.IsUpdated(convNews.Memo) == true)
{
string strComparisonOpMemo = objvNewsCond.dicFldComparisonOp[convNews.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.Memo, objvNewsCond.Memo, strComparisonOpMemo);
}
if (objvNewsCond.IsUpdated(convNews.DeletedDate) == true)
{
string strComparisonOpDeletedDate = objvNewsCond.dicFldComparisonOp[convNews.DeletedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.DeletedDate, objvNewsCond.DeletedDate, strComparisonOpDeletedDate);
}
if (objvNewsCond.IsUpdated(convNews.IsDeleted) == true)
{
if (objvNewsCond.IsDeleted == true)
{
strWhereCond += string.Format(" And {0} = '1'", convNews.IsDeleted);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convNews.IsDeleted);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vNews
{
public virtual bool UpdRelaTabDate(long lngId_News, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v新闻(vNews)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvNewsBL
{
public static RelatedActions_vNews relatedActions = null;

 /// <summary>
 /// 单项的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemXmlNode = "vNewsListItem";
 /// <summary>
 /// 列表的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string listXmlNode = "vNewsList";
 /// <summary>
 /// 集合的XML结点标签
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineConst4Xml)
 /// </summary>
public const string itemsXmlNode = "Items";

 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
//public static List<clsvNewsEN> arrvNewsObjLstCache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjLst4Cache)
 /// </summary>
protected static int intFindFailCount = 0;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvNewsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvNewsDA vNewsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvNewsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvNewsBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsvNewsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvNewsEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCond_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet(string strWhereCond)
{
DataSet objDS;
try
{
objDS = vNewsDA.GetDataSet(strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000001)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSet_Top(int intTopSize, string strWhereCond)
{
DataSet objDS;
try
{
objDS = vNewsDA.GetDataSet_Top(intTopSize, strWhereCond);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000002)获取表顶数据出错!(strWhereCond = {1}),{2}({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集,用DataSet表示</returns>
public static System.Data.DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataSet objDS;
try
{
objDS = vNewsDA.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDS;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000003)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataSet


 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vNews(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vNewsDA.GetDataTable_vNews(strWhereCond);
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
objDT = vNewsDA.GetDataTable(strWhereCond);
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
objDT = vNewsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vNewsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vNewsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vNewsDA.GetDataTable_Top(objTopPara);
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
objDT = vNewsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTableWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vNewsDA.GetDataTable_Top(intTopSize, strWhereCond, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000011)获取表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
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
objDT = vNewsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vNewsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPagerWithCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, bool bolIsCheckSQLAttack)
{
DataTable objDT;
try
{
objDT = vNewsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000014)获取分页表顶数据出错!(是否检查SQL攻击),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取范围中数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vNewsDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000015)获取表带范围数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_Exclude)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vNewsDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000016)获取表带范围数据出错!(同时可以排除一些关键字不检查)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByRange_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查SQL攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public static DataTable GetDataTableByRange(string strWhereCond, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
DataTable objDT;
try
{
objDT = vNewsDA.GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum, bolIsCheckSQLAttack);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000017)获取表带范围数据出错!(同时检查是否含有SQL攻击)(strWhereCond = {1}),{2}.({0})",
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
 /// <param name = "arrId_NewsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvNewsEN> GetObjLstById_NewsLst(List<long> arrId_NewsLst)
{
List<clsvNewsEN> arrObjLst = new List<clsvNewsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrId_NewsLst);
 string strWhereCond = string.Format("Id_News in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = Int32.Parse(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrId_NewsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvNewsEN> GetObjLstById_NewsLstCache(List<long> arrId_NewsLst)
{
string strKey = string.Format("{0}", clsvNewsEN._CurrTabName);
List<clsvNewsEN> arrvNewsObjLstCache = GetObjLstCache();
IEnumerable <clsvNewsEN> arrvNewsObjLst_Sel =
arrvNewsObjLstCache
.Where(x => arrId_NewsLst.Contains(x.Id_News));
return arrvNewsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvNewsEN> GetObjLst(string strWhereCond)
{
List<clsvNewsEN> arrObjLst = new List<clsvNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = Int32.Parse(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvNewsEN);
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
public static List<clsvNewsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvNewsEN> arrObjLst = new List<clsvNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = Int32.Parse(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvNewsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvNewsEN> GetSubObjLstCache(clsvNewsEN objvNewsCond)
{
List<clsvNewsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvNewsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convNews.AttributeName)
{
if (objvNewsCond.IsUpdated(strFldName) == false) continue;
if (objvNewsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvNewsCond[strFldName].ToString());
}
else
{
if (objvNewsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvNewsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvNewsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvNewsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvNewsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvNewsCond[strFldName]));
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
public static List<clsvNewsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvNewsEN> arrObjLst = new List<clsvNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = Int32.Parse(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvNewsEN);
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
public static List<clsvNewsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvNewsEN> arrObjLst = new List<clsvNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = Int32.Parse(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvNewsEN);
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
List<clsvNewsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvNewsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvNewsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvNewsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvNewsEN> arrObjLst = new List<clsvNewsEN>(); 
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
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = Int32.Parse(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvNewsEN);
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
public static List<clsvNewsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvNewsEN> arrObjLst = new List<clsvNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = Int32.Parse(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvNewsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvNewsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvNewsEN> arrObjLst = new List<clsvNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = Int32.Parse(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvNewsEN);
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
public static List<clsvNewsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvNewsEN> arrObjLst = new List<clsvNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = Int32.Parse(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static IEnumerable<clsvNewsEN> GetObjLstByPagerCache(int intPageIndex, int intPageSize, clsvNewsEN objvNewsCond, string strOrderBy)
{
List<clsvNewsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvNewsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convNews.AttributeName)
{
if (objvNewsCond.IsUpdated(strFldName) == false) continue;
if (objvNewsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvNewsCond[strFldName].ToString());
}
else
{
if (objvNewsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvNewsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvNewsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvNewsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvNewsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvNewsCond[strFldName]));
}
}
}
int intSkip = intPageSize * (intPageIndex - 1);
if (intSkip <= 0) intSkip = 0;
if (string.IsNullOrEmpty(strOrderBy) == false)
{
string[] sstrSplit = strOrderBy.Split(" ".ToCharArray());
if (sstrSplit[1].ToLower() == "asc")
{
arrObjLstSel = arrObjLstSel.OrderBy(x => x[sstrSplit[0]]);
}
else
{
arrObjLstSel = arrObjLstSel.OrderByDescending(x => x[sstrSplit[0]]);
}
}
arrObjLstSel = arrObjLstSel.Skip(intSkip).Take(intPageSize);
return arrObjLstSel;
}
 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static IEnumerable<clsvNewsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
clsvNewsEN objvNewsCond = JsonConvert.DeserializeObject<clsvNewsEN>(objPagerPara.whereCond);
if (objvNewsCond.sfFldComparisonOp == null)
{
objvNewsCond.dicFldComparisonOp = null;
}
else
{
objvNewsCond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(objvNewsCond.sfFldComparisonOp);
}
clsvNewsBL.SetUpdFlag(objvNewsCond);
 try
{
CheckProperty4Condition(objvNewsCond);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Busi000171)在输入条件中含有{0},请检查!(clsvNewsBL:GetObjLstByPagerCache)", objException.Message));
}
 return GetObjLstByPagerCache(objPagerPara.pageIndex, objPagerPara.pageSize, objvNewsCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvNewsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 return GetObjLstByRange(objRangePara.whereCond, objRangePara.orderBy, objRangePara.minNum, objRangePara.maxNum);
}

 /// <summary>
 /// 根据记录范围和条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回对象列表</returns>
public static List<clsvNewsEN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvNewsEN> arrObjLst = new List<clsvNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = Int32.Parse(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvNewsEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByRange)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvNewsEN> GetObjLstByRange(string strWhereCond, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
List<clsvNewsEN> arrObjLst = new List<clsvNewsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByRange(strWhereCond, lstExclude, strOrderBy, intMinNum, intMaxNum);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = Int32.Parse(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvNewsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvNewsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvNewsEN> arrObjLst = new List<clsvNewsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvNewsEN objvNewsEN = new clsvNewsEN();
try
{
objvNewsEN.Id_News = Int32.Parse(objRow[convNews.Id_News].ToString().Trim()); //Id_News
objvNewsEN.NewsTypeId = objRow[convNews.NewsTypeId].ToString().Trim(); //信息类型Id
objvNewsEN.NewsTypeName = objRow[convNews.NewsTypeName] == DBNull.Value ? null : objRow[convNews.NewsTypeName].ToString().Trim(); //信息类型名称
objvNewsEN.NewsTitle = objRow[convNews.NewsTitle] == DBNull.Value ? null : objRow[convNews.NewsTitle].ToString().Trim(); //信息标题
objvNewsEN.NewsContent = objRow[convNews.NewsContent] == DBNull.Value ? null : objRow[convNews.NewsContent].ToString().Trim(); //信息内容
objvNewsEN.ImgPath = objRow[convNews.ImgPath] == DBNull.Value ? null : objRow[convNews.ImgPath].ToString().Trim(); //图片路径
objvNewsEN.EditPeople = objRow[convNews.EditPeople] == DBNull.Value ? null : objRow[convNews.EditPeople].ToString().Trim(); //编辑人
objvNewsEN.EditTime = objRow[convNews.EditTime] == DBNull.Value ? null : objRow[convNews.EditTime].ToString().Trim(); //编辑时间
objvNewsEN.Source = objRow[convNews.Source] == DBNull.Value ? null : objRow[convNews.Source].ToString().Trim(); //来源
objvNewsEN.IsTop = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsTop].ToString().Trim()); //是否置顶
objvNewsEN.Views = objRow[convNews.Views] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convNews.Views].ToString().Trim()); //浏览量
objvNewsEN.Audit = objRow[convNews.Audit] == DBNull.Value ? null : objRow[convNews.Audit].ToString().Trim(); //审核
objvNewsEN.Memo = objRow[convNews.Memo] == DBNull.Value ? null : objRow[convNews.Memo].ToString().Trim(); //说明
objvNewsEN.DeletedDate = objRow[convNews.DeletedDate] == DBNull.Value ? null : objRow[convNews.DeletedDate].ToString().Trim(); //删除日期
objvNewsEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[convNews.IsDeleted].ToString().Trim()); //是否删除
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvNewsEN.Id_News, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvNewsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvNewsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvNews(ref clsvNewsEN objvNewsEN)
{
bool bolResult = vNewsDA.GetvNews(ref objvNewsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngId_News">表关键字</param>
 /// <returns>表对象</returns>
public static clsvNewsEN GetObjById_News(long lngId_News)
{
clsvNewsEN objvNewsEN = vNewsDA.GetObjById_News(lngId_News);
return objvNewsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvNewsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvNewsEN objvNewsEN = vNewsDA.GetFirstObj(strWhereCond);
 return objvNewsEN;
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
public static clsvNewsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvNewsEN objvNewsEN = vNewsDA.GetObjByDataRow(objRow);
 return objvNewsEN;
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
public static clsvNewsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvNewsEN objvNewsEN = vNewsDA.GetObjByDataRow(objRow);
 return objvNewsEN;
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
 /// <param name = "lngId_News">所给的关键字</param>
 /// <param name = "lstvNewsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvNewsEN GetObjById_NewsFromList(long lngId_News, List<clsvNewsEN> lstvNewsObjLst)
{
foreach (clsvNewsEN objvNewsEN in lstvNewsObjLst)
{
if (objvNewsEN.Id_News == lngId_News)
{
return objvNewsEN;
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
 long lngId_News;
 try
 {
 lngId_News = new clsvNewsDA().GetFirstID(strWhereCond);
 return lngId_News;
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
 arrList = vNewsDA.GetID(strWhereCond);
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
bool bolIsExist = vNewsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngId_News">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngId_News)
{
//检测记录是否存在
bool bolIsExist = vNewsDA.IsExist(lngId_News);
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
 bolIsExist = clsvNewsDA.IsExistTable();
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
 bolIsExist = vNewsDA.IsExistTable(strTabName);
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
 /// <param name = "objvNewsENS">源对象</param>
 /// <param name = "objvNewsENT">目标对象</param>
 public static void CopyTo(clsvNewsEN objvNewsENS, clsvNewsEN objvNewsENT)
{
try
{
objvNewsENT.Id_News = objvNewsENS.Id_News; //Id_News
objvNewsENT.NewsTypeId = objvNewsENS.NewsTypeId; //信息类型Id
objvNewsENT.NewsTypeName = objvNewsENS.NewsTypeName; //信息类型名称
objvNewsENT.NewsTitle = objvNewsENS.NewsTitle; //信息标题
objvNewsENT.NewsContent = objvNewsENS.NewsContent; //信息内容
objvNewsENT.ImgPath = objvNewsENS.ImgPath; //图片路径
objvNewsENT.EditPeople = objvNewsENS.EditPeople; //编辑人
objvNewsENT.EditTime = objvNewsENS.EditTime; //编辑时间
objvNewsENT.Source = objvNewsENS.Source; //来源
objvNewsENT.IsTop = objvNewsENS.IsTop; //是否置顶
objvNewsENT.Views = objvNewsENS.Views; //浏览量
objvNewsENT.Audit = objvNewsENS.Audit; //审核
objvNewsENT.Memo = objvNewsENS.Memo; //说明
objvNewsENT.DeletedDate = objvNewsENS.DeletedDate; //删除日期
objvNewsENT.IsDeleted = objvNewsENS.IsDeleted; //是否删除
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
 /// <param name = "objvNewsEN">源简化对象</param>
 public static void SetUpdFlag(clsvNewsEN objvNewsEN)
{
try
{
objvNewsEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objvNewsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convNews.Id_News, new clsStrCompareIgnoreCase())  ==  true)
{
objvNewsEN.Id_News = objvNewsEN.Id_News; //Id_News
}
if (arrFldSet.Contains(convNews.NewsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvNewsEN.NewsTypeId = objvNewsEN.NewsTypeId; //信息类型Id
}
if (arrFldSet.Contains(convNews.NewsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvNewsEN.NewsTypeName = objvNewsEN.NewsTypeName == "[null]" ? null :  objvNewsEN.NewsTypeName; //信息类型名称
}
if (arrFldSet.Contains(convNews.NewsTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvNewsEN.NewsTitle = objvNewsEN.NewsTitle == "[null]" ? null :  objvNewsEN.NewsTitle; //信息标题
}
if (arrFldSet.Contains(convNews.NewsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvNewsEN.NewsContent = objvNewsEN.NewsContent == "[null]" ? null :  objvNewsEN.NewsContent; //信息内容
}
if (arrFldSet.Contains(convNews.ImgPath, new clsStrCompareIgnoreCase())  ==  true)
{
objvNewsEN.ImgPath = objvNewsEN.ImgPath == "[null]" ? null :  objvNewsEN.ImgPath; //图片路径
}
if (arrFldSet.Contains(convNews.EditPeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvNewsEN.EditPeople = objvNewsEN.EditPeople == "[null]" ? null :  objvNewsEN.EditPeople; //编辑人
}
if (arrFldSet.Contains(convNews.EditTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvNewsEN.EditTime = objvNewsEN.EditTime == "[null]" ? null :  objvNewsEN.EditTime; //编辑时间
}
if (arrFldSet.Contains(convNews.Source, new clsStrCompareIgnoreCase())  ==  true)
{
objvNewsEN.Source = objvNewsEN.Source == "[null]" ? null :  objvNewsEN.Source; //来源
}
if (arrFldSet.Contains(convNews.IsTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvNewsEN.IsTop = objvNewsEN.IsTop; //是否置顶
}
if (arrFldSet.Contains(convNews.Views, new clsStrCompareIgnoreCase())  ==  true)
{
objvNewsEN.Views = objvNewsEN.Views; //浏览量
}
if (arrFldSet.Contains(convNews.Audit, new clsStrCompareIgnoreCase())  ==  true)
{
objvNewsEN.Audit = objvNewsEN.Audit == "[null]" ? null :  objvNewsEN.Audit; //审核
}
if (arrFldSet.Contains(convNews.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvNewsEN.Memo = objvNewsEN.Memo == "[null]" ? null :  objvNewsEN.Memo; //说明
}
if (arrFldSet.Contains(convNews.DeletedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvNewsEN.DeletedDate = objvNewsEN.DeletedDate == "[null]" ? null :  objvNewsEN.DeletedDate; //删除日期
}
if (arrFldSet.Contains(convNews.IsDeleted, new clsStrCompareIgnoreCase())  ==  true)
{
objvNewsEN.IsDeleted = objvNewsEN.IsDeleted; //是否删除
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvNewsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvNewsEN objvNewsEN)
{
try
{
if (objvNewsEN.NewsTypeName == "[null]") objvNewsEN.NewsTypeName = null; //信息类型名称
if (objvNewsEN.NewsTitle == "[null]") objvNewsEN.NewsTitle = null; //信息标题
if (objvNewsEN.NewsContent == "[null]") objvNewsEN.NewsContent = null; //信息内容
if (objvNewsEN.ImgPath == "[null]") objvNewsEN.ImgPath = null; //图片路径
if (objvNewsEN.EditPeople == "[null]") objvNewsEN.EditPeople = null; //编辑人
if (objvNewsEN.EditTime == "[null]") objvNewsEN.EditTime = null; //编辑时间
if (objvNewsEN.Source == "[null]") objvNewsEN.Source = null; //来源
if (objvNewsEN.Audit == "[null]") objvNewsEN.Audit = null; //审核
if (objvNewsEN.Memo == "[null]") objvNewsEN.Memo = null; //说明
if (objvNewsEN.DeletedDate == "[null]") objvNewsEN.DeletedDate = null; //删除日期
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckProperty4Condition(clsvNewsEN objvNewsEN)
{
 vNewsDA.CheckProperty4Condition(objvNewsEN);
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
if (clsNewsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsNewsBL没有刷新缓存机制(clsNewsBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsNewsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsNewsTypeBL没有刷新缓存机制(clsNewsTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_News");
//if (arrvNewsObjLstCache == null)
//{
//arrvNewsObjLstCache = vNewsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngId_News">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvNewsEN GetObjById_NewsCache(long lngId_News)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvNewsEN._CurrTabName);
List<clsvNewsEN> arrvNewsObjLstCache = GetObjLstCache();
IEnumerable <clsvNewsEN> arrvNewsObjLst_Sel =
arrvNewsObjLstCache
.Where(x=> x.Id_News == lngId_News 
);
if (arrvNewsObjLst_Sel.Count() == 0)
{
   clsvNewsEN obj = clsvNewsBL.GetObjById_News(lngId_News);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvNewsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvNewsEN> GetAllvNewsObjLstCache()
{
//获取缓存中的对象列表
List<clsvNewsEN> arrvNewsObjLstCache = GetObjLstCache(); 
return arrvNewsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvNewsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvNewsEN._CurrTabName);
List<clsvNewsEN> arrvNewsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvNewsObjLstCache;
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
string strKey = string.Format("{0}", clsvNewsEN._CurrTabName);
CacheHelper.Remove(strKey);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 序列化一个对象列表到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXMLStr)
 /// </summary>
 /// <param name = "lstvNewsObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjLstToXMLStr(List<clsvNewsEN> lstvNewsObjLst)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeObjLstToXML(lstvNewsObjLst, writer);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 序列化一个对象列表到XmlWriter
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToXML)
 /// </summary>
 /// <param name = "lstvNewsObjLst">[clsvNewsEN]对象列表</param>
 /// <param name = "writer">提供的一个XmlWriter对象</param>
 /// <returns>返回是否成功?</returns>
public static bool SerializeObjLstToXML(List<clsvNewsEN> lstvNewsObjLst, XmlWriter writer)
{
writer.WriteStartElement(clsvNewsBL.listXmlNode);
writer.WriteStartElement(clsvNewsBL.itemsXmlNode);
foreach (clsvNewsEN objvNewsEN in lstvNewsObjLst)
{
clsvNewsBL.SerializeXML(writer, objvNewsEN);
}
writer.WriteEndElement();
writer.WriteEndElement();
return true;
}

 /// <summary>
 /// 把一个对象序列化到XML中
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeXML)
 /// </summary>
 /// <param name = "writer">目标:序列化到的XmlWriter</param>
 /// <param name = "objvNewsEN">数据源:需要序列化的对象</param>
public static void SerializeXML(XmlWriter writer, clsvNewsEN objvNewsEN)
{
writer.WriteStartElement(clsvNewsBL.itemXmlNode);
 
writer.WriteElementString(convNews.Id_News, objvNewsEN.Id_News.ToString(CultureInfo.InvariantCulture));
 
if (objvNewsEN.NewsTypeId != null)
{
writer.WriteElementString(convNews.NewsTypeId, objvNewsEN.NewsTypeId.ToString(CultureInfo.InvariantCulture));
}
 
if (objvNewsEN.NewsTypeName != null)
{
writer.WriteElementString(convNews.NewsTypeName, objvNewsEN.NewsTypeName.ToString(CultureInfo.InvariantCulture));
}
 
if (objvNewsEN.NewsTitle != null)
{
writer.WriteElementString(convNews.NewsTitle, objvNewsEN.NewsTitle.ToString(CultureInfo.InvariantCulture));
}
 
if (objvNewsEN.NewsContent != null)
{
writer.WriteElementString(convNews.NewsContent, objvNewsEN.NewsContent.ToString(CultureInfo.InvariantCulture));
}
 
if (objvNewsEN.ImgPath != null)
{
writer.WriteElementString(convNews.ImgPath, objvNewsEN.ImgPath.ToString(CultureInfo.InvariantCulture));
}
 
if (objvNewsEN.EditPeople != null)
{
writer.WriteElementString(convNews.EditPeople, objvNewsEN.EditPeople.ToString(CultureInfo.InvariantCulture));
}
 
if (objvNewsEN.EditTime != null)
{
writer.WriteElementString(convNews.EditTime, objvNewsEN.EditTime.ToString(CultureInfo.InvariantCulture));
}
 
if (objvNewsEN.Source != null)
{
writer.WriteElementString(convNews.Source, objvNewsEN.Source.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convNews.IsTop, objvNewsEN.IsTop.ToString().ToLower(CultureInfo.InvariantCulture));
 
writer.WriteElementString(convNews.Views, objvNewsEN.Views.ToString());
 
if (objvNewsEN.Audit != null)
{
writer.WriteElementString(convNews.Audit, objvNewsEN.Audit.ToString(CultureInfo.InvariantCulture));
}
 
if (objvNewsEN.Memo != null)
{
writer.WriteElementString(convNews.Memo, objvNewsEN.Memo.ToString(CultureInfo.InvariantCulture));
}
 
if (objvNewsEN.DeletedDate != null)
{
writer.WriteElementString(convNews.DeletedDate, objvNewsEN.DeletedDate.ToString(CultureInfo.InvariantCulture));
}
 
writer.WriteElementString(convNews.IsDeleted, objvNewsEN.IsDeleted.ToString().ToLower(CultureInfo.InvariantCulture));
writer.WriteEndElement();
}

 /// <summary>
 /// 读XmlReader到一个对象
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlReader)
 /// </summary>
 /// <param name = "reader">提供的数据源:XmlReader</param>
 /// <returns>返回的一个对象</returns>
public static clsvNewsEN GetObjFromXml(System.Xml.XmlReader reader)
{
clsvNewsEN objvNewsEN = new clsvNewsEN();
reader.Read();
while (!(reader.Name == clsvNewsBL.itemXmlNode && reader.NodeType == XmlNodeType.EndElement))
{
if (reader.IsStartElement(convNews.Id_News))
{
objvNewsEN.Id_News = reader.ReadElementContentAsLong();
}
if (reader.IsStartElement(convNews.NewsTypeId))
{
objvNewsEN.NewsTypeId = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convNews.NewsTypeName))
{
objvNewsEN.NewsTypeName = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convNews.NewsTitle))
{
objvNewsEN.NewsTitle = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convNews.NewsContent))
{
objvNewsEN.NewsContent = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convNews.ImgPath))
{
objvNewsEN.ImgPath = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convNews.EditPeople))
{
objvNewsEN.EditPeople = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convNews.EditTime))
{
objvNewsEN.EditTime = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convNews.Source))
{
objvNewsEN.Source = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convNews.IsTop))
{
objvNewsEN.IsTop = reader.ReadElementContentAsBoolean();
}
if (reader.IsStartElement(convNews.Views))
{
objvNewsEN.Views = reader.ReadElementContentAsInt();
}
if (reader.IsStartElement(convNews.Audit))
{
objvNewsEN.Audit = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convNews.Memo))
{
objvNewsEN.Memo = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convNews.DeletedDate))
{
objvNewsEN.DeletedDate = reader.ReadElementContentAsString();
}
if (reader.IsStartElement(convNews.IsDeleted))
{
objvNewsEN.IsDeleted = reader.ReadElementContentAsBoolean();
}
}
return objvNewsEN;
}

 /// <summary>
 /// 读Xml字符串到一个对象
 /// 作者:潘以锋
 /// 日期:2010/10/04
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjByXmlStr)
 /// </summary>
 /// <param name = "strvNewsObjXmlStr">提供的数据源:表示一个对象的XML串</param>
 /// <returns>返回的一个对象</returns>
public static clsvNewsEN GetObjFromXmlStr(string strvNewsObjXmlStr)
{
clsvNewsEN objvNewsEN = new clsvNewsEN();
UTF8Encoding enc = new UTF8Encoding();
using (MemoryStream ms = new MemoryStream(enc.GetBytes(strvNewsObjXmlStr)))
{
XmlReaderSettings xmlrs = new XmlReaderSettings()
{
IgnoreComments = true,
IgnoreWhitespace = true
};
XmlReader reader = XmlReader.Create(ms, xmlrs);
while (reader.ReadToFollowing(clsvNewsBL.itemXmlNode))
{
objvNewsEN = GetObjFromXml(reader);
return objvNewsEN;
}
}
return objvNewsEN;
}

 /// <summary>
 /// 序列化一个对象到Xml文件
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToXMLStr)
 /// </summary>
 /// <param name = "objvNewsEN">需要序列化的对象</param>
 /// <returns>返回一个生成的XML串</returns>
public static string SerializeObjToXMLStr(clsvNewsEN objvNewsEN)
{
string strXmlFile = clsSysParaEN.strTempXMLFileName;
XmlWriterSettings settings = new XmlWriterSettings()
{
Indent = true,
IndentChars = (" ")
};
using (XmlWriter writer = XmlWriter.Create(strXmlFile, settings))
{
SerializeXML(writer, objvNewsEN);
}
string strXmlString = clsFile.GetContentFromTextFile(strXmlFile);
return strXmlString;
}

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngId_News)
{
if (strInFldName != convNews.Id_News)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convNews.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convNews.AttributeName));
throw new Exception(strMsg);
}
var objvNews = clsvNewsBL.GetObjById_NewsCache(lngId_News);
if (objvNews == null) return "";
return objvNews[strOutFldName].ToString();
}


 #region 有关JSON操作

 /// <summary>
 /// 序列化一个对象到JSON
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjToJSON)
 /// </summary>
 /// <param name = "objvNewsEN">需要序列化JSON的对象</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjToJSON(clsvNewsEN objvNewsEN)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
foreach (string strField in clsvNewsEN.AttributeName)
{
sbJSON.AppendFormat("\"{0}\":\"{1}\",", strField, objvNewsEN[strField]);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("}");
return sbJSON.ToString();
}

 /// <summary>
 /// 序列化一个对象列表到JSON串
 /// 作者:pyf
 /// 日期:2023-05-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SerializeObjLstToJSONStr)
 /// </summary>
 /// <param name = "lstvNewsObjLst">需要序列化的对象列表</param>
 /// <returns>返回一个生成的JSON串</returns>
public static string SerializeObjLstToJSONStr(List<clsvNewsEN> lstvNewsObjLst)
{
StringBuilder sbJSON = new StringBuilder();
sbJSON.Append("{");
sbJSON.AppendFormat("\"RecCount\":\"{0}\",", lstvNewsObjLst.Count);
sbJSON.Append("\"data\":[");
foreach (clsvNewsEN objvNewsEN in lstvNewsObjLst)
{
string strJSON_One = SerializeObjToJSON(objvNewsEN);
sbJSON.AppendFormat("{0},", strJSON_One);
}
sbJSON.Remove(sbJSON.Length - 1, 1);
sbJSON.Append("]}");
return sbJSON.ToString();
}


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
int intRecCount = clsvNewsDA.GetRecCount(strTabName);
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
int intRecCount = clsvNewsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvNewsDA.GetRecCount();
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
int intRecCount = clsvNewsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvNewsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvNewsEN objvNewsCond)
{
List<clsvNewsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvNewsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convNews.AttributeName)
{
if (objvNewsCond.IsUpdated(strFldName) == false) continue;
if (objvNewsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvNewsCond[strFldName].ToString());
}
else
{
if (objvNewsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvNewsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvNewsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvNewsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvNewsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvNewsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvNewsCond[strFldName]));
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
 List<string> arrList = clsvNewsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vNewsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vNewsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}