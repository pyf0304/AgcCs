
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvNewsWApi
 表名:vNews(00050480)
 生成代码版本:2021.07.30.2
 生成日期:2021/07/30 16:31:10
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:新闻公告
 模块英文名:NewsBulletin
 框架-层名:WA_访问层(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
public static class clsvNewsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetNewsTypeId(this clsvNewsEN objvNewsEN, string strNewsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strNewsTypeId, convNews.NewsTypeId);
clsCheckSql.CheckFieldLen(strNewsTypeId, 1, convNews.NewsTypeId);
clsCheckSql.CheckFieldForeignKey(strNewsTypeId, 1, convNews.NewsTypeId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetNewsTypeName(this clsvNewsEN objvNewsEN, string strNewsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNewsTypeName, 50, convNews.NewsTypeName);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetNewsTitle(this clsvNewsEN objvNewsEN, string strNewsTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNewsTitle, 50, convNews.NewsTitle);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetImgPath(this clsvNewsEN objvNewsEN, string strImgPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImgPath, 500, convNews.ImgPath);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetEditPeople(this clsvNewsEN objvNewsEN, string strEditPeople, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEditPeople, 50, convNews.EditPeople);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetEditTime(this clsvNewsEN objvNewsEN, string strEditTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEditTime, 20, convNews.EditTime);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetSource(this clsvNewsEN objvNewsEN, string strSource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSource, 50, convNews.Source);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetAudit(this clsvNewsEN objvNewsEN, string strAudit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAudit, 1, convNews.Audit);
clsCheckSql.CheckFieldForeignKey(strAudit, 1, convNews.Audit);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetMemo(this clsvNewsEN objvNewsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convNews.Memo);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvNewsEN SetDeletedDate(this clsvNewsEN objvNewsEN, string strDeletedDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDeletedDate, 50, convNews.DeletedDate);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvNewsEN objvNews_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvNews_Cond.IsUpdated(convNews.Id_News) == true)
{
string strComparisonOp_Id_News = objvNews_Cond.dicFldComparisonOp[convNews.Id_News];
strWhereCond += string.Format(" And {0} {2} {1}", convNews.Id_News, objvNews_Cond.Id_News, strComparisonOp_Id_News);
}
if (objvNews_Cond.IsUpdated(convNews.NewsTypeId) == true)
{
string strComparisonOp_NewsTypeId = objvNews_Cond.dicFldComparisonOp[convNews.NewsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.NewsTypeId, objvNews_Cond.NewsTypeId, strComparisonOp_NewsTypeId);
}
if (objvNews_Cond.IsUpdated(convNews.NewsTypeName) == true)
{
string strComparisonOp_NewsTypeName = objvNews_Cond.dicFldComparisonOp[convNews.NewsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.NewsTypeName, objvNews_Cond.NewsTypeName, strComparisonOp_NewsTypeName);
}
if (objvNews_Cond.IsUpdated(convNews.NewsTitle) == true)
{
string strComparisonOp_NewsTitle = objvNews_Cond.dicFldComparisonOp[convNews.NewsTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.NewsTitle, objvNews_Cond.NewsTitle, strComparisonOp_NewsTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvNews_Cond.IsUpdated(convNews.ImgPath) == true)
{
string strComparisonOp_ImgPath = objvNews_Cond.dicFldComparisonOp[convNews.ImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.ImgPath, objvNews_Cond.ImgPath, strComparisonOp_ImgPath);
}
if (objvNews_Cond.IsUpdated(convNews.EditPeople) == true)
{
string strComparisonOp_EditPeople = objvNews_Cond.dicFldComparisonOp[convNews.EditPeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.EditPeople, objvNews_Cond.EditPeople, strComparisonOp_EditPeople);
}
if (objvNews_Cond.IsUpdated(convNews.EditTime) == true)
{
string strComparisonOp_EditTime = objvNews_Cond.dicFldComparisonOp[convNews.EditTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.EditTime, objvNews_Cond.EditTime, strComparisonOp_EditTime);
}
if (objvNews_Cond.IsUpdated(convNews.Source) == true)
{
string strComparisonOp_Source = objvNews_Cond.dicFldComparisonOp[convNews.Source];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.Source, objvNews_Cond.Source, strComparisonOp_Source);
}
if (objvNews_Cond.IsUpdated(convNews.IsTop) == true)
{
if (objvNews_Cond.IsTop == true)
{
strWhereCond += string.Format(" And {0} = '1'", convNews.IsTop);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convNews.IsTop);
}
}
if (objvNews_Cond.IsUpdated(convNews.Views) == true)
{
string strComparisonOp_Views = objvNews_Cond.dicFldComparisonOp[convNews.Views];
strWhereCond += string.Format(" And {0} {2} {1}", convNews.Views, objvNews_Cond.Views, strComparisonOp_Views);
}
if (objvNews_Cond.IsUpdated(convNews.Audit) == true)
{
string strComparisonOp_Audit = objvNews_Cond.dicFldComparisonOp[convNews.Audit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.Audit, objvNews_Cond.Audit, strComparisonOp_Audit);
}
if (objvNews_Cond.IsUpdated(convNews.Memo) == true)
{
string strComparisonOp_Memo = objvNews_Cond.dicFldComparisonOp[convNews.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.Memo, objvNews_Cond.Memo, strComparisonOp_Memo);
}
if (objvNews_Cond.IsUpdated(convNews.DeletedDate) == true)
{
string strComparisonOp_DeletedDate = objvNews_Cond.dicFldComparisonOp[convNews.DeletedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convNews.DeletedDate, objvNews_Cond.DeletedDate, strComparisonOp_DeletedDate);
}
if (objvNews_Cond.IsUpdated(convNews.IsDeleted) == true)
{
if (objvNews_Cond.IsDeleted == true)
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
 /// v新闻(vNews)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvNewsWApi
{
private static readonly string mstrApiControllerName = "vNewsApi";

 public clsvNewsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_News">表关键字</param>
 /// <returns>表对象</returns>
public static clsvNewsEN GetObjById_News(long lngId_News)
{
string strAction = "GetObjById_News";
string strErrMsg = string.Empty;
string strResult = "";
clsvNewsEN objvNewsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_News"] = lngId_News.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvNewsEN = JsonConvert.DeserializeObject<clsvNewsEN>((string)jobjReturn["returnObj"]);
return objvNewsEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "lngId_News">表关键字</param>
 /// <returns>表对象</returns>
public static clsvNewsEN GetObjById_News_WA_Cache(long lngId_News)
{
string strAction = "GetObjById_News_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvNewsEN objvNewsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_News"] = lngId_News.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvNewsEN = JsonConvert.DeserializeObject<clsvNewsEN>((string)jobjReturn["returnObj"]);
return objvNewsEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static long GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn["returnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvNewsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvNewsEN objvNewsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objvNewsEN = JsonConvert.DeserializeObject<clsvNewsEN>((string)jobjReturn["returnObj"]);
return objvNewsEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngId_News">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvNewsEN GetObjById_News_Cache(long lngId_News)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvNewsEN._CurrTabName);
List<clsvNewsEN> arrvNewsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvNewsEN> arrvNewsObjLst_Sel =
from objvNewsEN in arrvNewsObjLst_Cache
where objvNewsEN.Id_News == lngId_News
select objvNewsEN;
if (arrvNewsObjLst_Sel.Count() == 0)
{
   clsvNewsEN obj = clsvNewsWApi.GetObjById_News(lngId_News);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvNewsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvNewsEN> GetObjLst(string strWhereCond)
{
 List<clsvNewsEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvNewsEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvNewsEN> GetObjLstById_NewsLst(List<long> arrId_News)
{
 List<clsvNewsEN> arrObjLst = null; 
string strAction = "GetObjLstById_NewsLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_News);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvNewsEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "lngId_News">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvNewsEN> GetObjLstById_NewsLst_Cache(List<long> arrId_News)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvNewsEN._CurrTabName);
List<clsvNewsEN> arrvNewsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvNewsEN> arrvNewsObjLst_Sel =
from objvNewsEN in arrvNewsObjLst_Cache
where arrId_News.Contains(objvNewsEN.Id_News)
select objvNewsEN;
return arrvNewsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvNewsEN> GetObjLstById_NewsLst_WA_Cache(List<long> arrId_News)
{
 List<clsvNewsEN> arrObjLst = null; 
string strAction = "GetObjLstById_NewsLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_News);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvNewsEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvNewsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvNewsEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvNewsEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsvNewsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvNewsEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvNewsEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static List<clsvNewsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvNewsEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvNewsEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvNewsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvNewsEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvNewsEN>>((string)jobjReturn["returnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static bool IsExist(long lngId_News)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_News"] = lngId_News.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
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
public static DataTable ToDataTable(List<clsvNewsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvNewsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvNewsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvNewsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvNewsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvNewsEN.AttributeName)
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
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsNewsWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsNewsWApi没有刷新缓存机制(clsNewsWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsNewsTypeWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsNewsTypeWApi没有刷新缓存机制(clsNewsTypeWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_News");
//if (arrvNewsObjLst_Cache == null)
//{
//arrvNewsObjLst_Cache = await clsvNewsWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
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

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvNewsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvNewsEN._CurrTabName);
List<clsvNewsEN> arrvNewsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvNewsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvNewsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convNews.Id_News, Type.GetType("System.Int64"));
objDT.Columns.Add(convNews.NewsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convNews.NewsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convNews.NewsTitle, Type.GetType("System.String"));
objDT.Columns.Add(convNews.NewsContent, Type.GetType("System.String"));
objDT.Columns.Add(convNews.ImgPath, Type.GetType("System.String"));
objDT.Columns.Add(convNews.EditPeople, Type.GetType("System.String"));
objDT.Columns.Add(convNews.EditTime, Type.GetType("System.String"));
objDT.Columns.Add(convNews.Source, Type.GetType("System.String"));
objDT.Columns.Add(convNews.IsTop, Type.GetType("System.Boolean"));
objDT.Columns.Add(convNews.Views, Type.GetType("System.Int32"));
objDT.Columns.Add(convNews.Audit, Type.GetType("System.String"));
objDT.Columns.Add(convNews.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convNews.DeletedDate, Type.GetType("System.String"));
objDT.Columns.Add(convNews.IsDeleted, Type.GetType("System.Boolean"));
foreach (clsvNewsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convNews.Id_News] = objInFor[convNews.Id_News];
objDR[convNews.NewsTypeId] = objInFor[convNews.NewsTypeId];
objDR[convNews.NewsTypeName] = objInFor[convNews.NewsTypeName];
objDR[convNews.NewsTitle] = objInFor[convNews.NewsTitle];
objDR[convNews.NewsContent] = objInFor[convNews.NewsContent];
objDR[convNews.ImgPath] = objInFor[convNews.ImgPath];
objDR[convNews.EditPeople] = objInFor[convNews.EditPeople];
objDR[convNews.EditTime] = objInFor[convNews.EditTime];
objDR[convNews.Source] = objInFor[convNews.Source];
objDR[convNews.IsTop] = objInFor[convNews.IsTop];
objDR[convNews.Views] = objInFor[convNews.Views];
objDR[convNews.Audit] = objInFor[convNews.Audit];
objDR[convNews.Memo] = objInFor[convNews.Memo];
objDR[convNews.DeletedDate] = objInFor[convNews.DeletedDate];
objDR[convNews.IsDeleted] = objInFor[convNews.IsDeleted];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}