
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsNewsWApi
 表名:News(00050478)
 生成代码版本:2021.07.30.2
 生成日期:2021/07/30 16:30:37
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
public static class clsNewsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetId_News(this clsNewsEN objNewsEN, long lngId_News, string strComparisonOp="")
	{
objNewsEN.Id_News = lngId_News; //Id_News
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.Id_News) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.Id_News, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.Id_News] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetNewsTypeId(this clsNewsEN objNewsEN, string strNewsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strNewsTypeId, conNews.NewsTypeId);
clsCheckSql.CheckFieldLen(strNewsTypeId, 1, conNews.NewsTypeId);
clsCheckSql.CheckFieldForeignKey(strNewsTypeId, 1, conNews.NewsTypeId);
objNewsEN.NewsTypeId = strNewsTypeId; //信息类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.NewsTypeId) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.NewsTypeId, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.NewsTypeId] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetNewsTitle(this clsNewsEN objNewsEN, string strNewsTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strNewsTitle, 50, conNews.NewsTitle);
objNewsEN.NewsTitle = strNewsTitle; //信息标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.NewsTitle) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.NewsTitle, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.NewsTitle] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetNewsContent(this clsNewsEN objNewsEN, string strNewsContent, string strComparisonOp="")
	{
objNewsEN.NewsContent = strNewsContent; //信息内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.NewsContent) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.NewsContent, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.NewsContent] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetImgPath(this clsNewsEN objNewsEN, string strImgPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImgPath, 500, conNews.ImgPath);
objNewsEN.ImgPath = strImgPath; //图片路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.ImgPath) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.ImgPath, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.ImgPath] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetEditPeople(this clsNewsEN objNewsEN, string strEditPeople, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEditPeople, 50, conNews.EditPeople);
objNewsEN.EditPeople = strEditPeople; //编辑人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.EditPeople) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.EditPeople, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.EditPeople] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetEditTime(this clsNewsEN objNewsEN, string strEditTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEditTime, 20, conNews.EditTime);
objNewsEN.EditTime = strEditTime; //编辑时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.EditTime) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.EditTime, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.EditTime] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetSource(this clsNewsEN objNewsEN, string strSource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSource, 50, conNews.Source);
objNewsEN.Source = strSource; //来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.Source) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.Source, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.Source] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetIsTop(this clsNewsEN objNewsEN, bool bolIsTop, string strComparisonOp="")
	{
objNewsEN.IsTop = bolIsTop; //是否置顶
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.IsTop) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.IsTop, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.IsTop] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetViews(this clsNewsEN objNewsEN, int intViews, string strComparisonOp="")
	{
objNewsEN.Views = intViews; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.Views) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.Views, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.Views] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetAudit(this clsNewsEN objNewsEN, string strAudit, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAudit, 1, conNews.Audit);
clsCheckSql.CheckFieldForeignKey(strAudit, 1, conNews.Audit);
objNewsEN.Audit = strAudit; //审核
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.Audit) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.Audit, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.Audit] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetIsDeleted(this clsNewsEN objNewsEN, bool bolIsDeleted, string strComparisonOp="")
	{
objNewsEN.IsDeleted = bolIsDeleted; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.IsDeleted) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.IsDeleted, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.IsDeleted] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetDeletedDate(this clsNewsEN objNewsEN, string strDeletedDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDeletedDate, 50, conNews.DeletedDate);
objNewsEN.DeletedDate = strDeletedDate; //删除日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.DeletedDate) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.DeletedDate, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.DeletedDate] = strComparisonOp;
}
}
return objNewsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objNewsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsNewsEN SetMemo(this clsNewsEN objNewsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conNews.Memo);
objNewsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objNewsEN.dicFldComparisonOp.ContainsKey(conNews.Memo) == false)
{
objNewsEN.dicFldComparisonOp.Add(conNews.Memo, strComparisonOp);
}
else
{
objNewsEN.dicFldComparisonOp[conNews.Memo] = strComparisonOp;
}
}
return objNewsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsNewsEN objNews_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objNews_Cond.IsUpdated(conNews.Id_News) == true)
{
string strComparisonOp_Id_News = objNews_Cond.dicFldComparisonOp[conNews.Id_News];
strWhereCond += string.Format(" And {0} {2} {1}", conNews.Id_News, objNews_Cond.Id_News, strComparisonOp_Id_News);
}
if (objNews_Cond.IsUpdated(conNews.NewsTypeId) == true)
{
string strComparisonOp_NewsTypeId = objNews_Cond.dicFldComparisonOp[conNews.NewsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.NewsTypeId, objNews_Cond.NewsTypeId, strComparisonOp_NewsTypeId);
}
if (objNews_Cond.IsUpdated(conNews.NewsTitle) == true)
{
string strComparisonOp_NewsTitle = objNews_Cond.dicFldComparisonOp[conNews.NewsTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.NewsTitle, objNews_Cond.NewsTitle, strComparisonOp_NewsTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objNews_Cond.IsUpdated(conNews.ImgPath) == true)
{
string strComparisonOp_ImgPath = objNews_Cond.dicFldComparisonOp[conNews.ImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.ImgPath, objNews_Cond.ImgPath, strComparisonOp_ImgPath);
}
if (objNews_Cond.IsUpdated(conNews.EditPeople) == true)
{
string strComparisonOp_EditPeople = objNews_Cond.dicFldComparisonOp[conNews.EditPeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.EditPeople, objNews_Cond.EditPeople, strComparisonOp_EditPeople);
}
if (objNews_Cond.IsUpdated(conNews.EditTime) == true)
{
string strComparisonOp_EditTime = objNews_Cond.dicFldComparisonOp[conNews.EditTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.EditTime, objNews_Cond.EditTime, strComparisonOp_EditTime);
}
if (objNews_Cond.IsUpdated(conNews.Source) == true)
{
string strComparisonOp_Source = objNews_Cond.dicFldComparisonOp[conNews.Source];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.Source, objNews_Cond.Source, strComparisonOp_Source);
}
if (objNews_Cond.IsUpdated(conNews.IsTop) == true)
{
if (objNews_Cond.IsTop == true)
{
strWhereCond += string.Format(" And {0} = '1'", conNews.IsTop);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conNews.IsTop);
}
}
if (objNews_Cond.IsUpdated(conNews.Views) == true)
{
string strComparisonOp_Views = objNews_Cond.dicFldComparisonOp[conNews.Views];
strWhereCond += string.Format(" And {0} {2} {1}", conNews.Views, objNews_Cond.Views, strComparisonOp_Views);
}
if (objNews_Cond.IsUpdated(conNews.Audit) == true)
{
string strComparisonOp_Audit = objNews_Cond.dicFldComparisonOp[conNews.Audit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.Audit, objNews_Cond.Audit, strComparisonOp_Audit);
}
if (objNews_Cond.IsUpdated(conNews.IsDeleted) == true)
{
if (objNews_Cond.IsDeleted == true)
{
strWhereCond += string.Format(" And {0} = '1'", conNews.IsDeleted);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conNews.IsDeleted);
}
}
if (objNews_Cond.IsUpdated(conNews.DeletedDate) == true)
{
string strComparisonOp_DeletedDate = objNews_Cond.dicFldComparisonOp[conNews.DeletedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.DeletedDate, objNews_Cond.DeletedDate, strComparisonOp_DeletedDate);
}
if (objNews_Cond.IsUpdated(conNews.Memo) == true)
{
string strComparisonOp_Memo = objNews_Cond.dicFldComparisonOp[conNews.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conNews.Memo, objNews_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsNewsEN objNewsEN)
{
 if (objNewsEN.Id_News == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objNewsEN.sfUpdFldSetStr = objNewsEN.getsfUpdFldSetStr();
clsNewsWApi.CheckPropertyNew(objNewsEN); 
bool bolResult = clsNewsWApi.UpdateRecord(objNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--News(新闻), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objNewsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_NewsTitle_EditPeople(this clsNewsEN objNewsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objNewsEN == null) return "";
if (objNewsEN.Id_News == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and NewsTitle = '{0}'", objNewsEN.NewsTitle);
 sbCondition.AppendFormat(" and EditPeople = '{0}'", objNewsEN.EditPeople);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id_News !=  {0}", objNewsEN.Id_News);
 sbCondition.AppendFormat(" and NewsTitle = '{0}'", objNewsEN.NewsTitle);
 sbCondition.AppendFormat(" and EditPeople = '{0}'", objNewsEN.EditPeople);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objNewsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsNewsEN objNewsEN)
{
try
{
clsNewsWApi.CheckPropertyNew(objNewsEN); 
bool bolResult = clsNewsWApi.AddNewRecord(objNewsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objNewsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsNewsEN objNewsEN, string strWhereCond)
{
try
{
clsNewsWApi.CheckPropertyNew(objNewsEN); 
bool bolResult = clsNewsWApi.UpdateWithCondition(objNewsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsWApi.ReFreshCache();
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
 /// 新闻(News)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsNewsWApi
{
private static readonly string mstrApiControllerName = "NewsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsNewsWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsNewsEN objNewsEN)
{
if (!Object.Equals(null, objNewsEN.NewsTypeId) && GetStrLen(objNewsEN.NewsTypeId) > 1)
{
 throw new Exception("字段[信息类型Id]的长度不能超过1!");
}
if (!Object.Equals(null, objNewsEN.NewsTitle) && GetStrLen(objNewsEN.NewsTitle) > 50)
{
 throw new Exception("字段[信息标题]的长度不能超过50!");
}
if (!Object.Equals(null, objNewsEN.ImgPath) && GetStrLen(objNewsEN.ImgPath) > 500)
{
 throw new Exception("字段[图片路径]的长度不能超过500!");
}
if (!Object.Equals(null, objNewsEN.EditPeople) && GetStrLen(objNewsEN.EditPeople) > 50)
{
 throw new Exception("字段[编辑人]的长度不能超过50!");
}
if (!Object.Equals(null, objNewsEN.EditTime) && GetStrLen(objNewsEN.EditTime) > 20)
{
 throw new Exception("字段[编辑时间]的长度不能超过20!");
}
if (!Object.Equals(null, objNewsEN.Source) && GetStrLen(objNewsEN.Source) > 50)
{
 throw new Exception("字段[来源]的长度不能超过50!");
}
if (!Object.Equals(null, objNewsEN.Audit) && GetStrLen(objNewsEN.Audit) > 1)
{
 throw new Exception("字段[审核]的长度不能超过1!");
}
if (!Object.Equals(null, objNewsEN.DeletedDate) && GetStrLen(objNewsEN.DeletedDate) > 50)
{
 throw new Exception("字段[删除日期]的长度不能超过50!");
}
if (!Object.Equals(null, objNewsEN.Memo) && GetStrLen(objNewsEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objNewsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_News">表关键字</param>
 /// <returns>表对象</returns>
public static clsNewsEN GetObjById_News(long lngId_News)
{
string strAction = "GetObjById_News";
string strErrMsg = string.Empty;
string strResult = "";
clsNewsEN objNewsEN = null;
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
objNewsEN = JsonConvert.DeserializeObject<clsNewsEN>((string)jobjReturn["returnObj"]);
return objNewsEN;
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
public static clsNewsEN GetObjById_News_WA_Cache(long lngId_News)
{
string strAction = "GetObjById_News_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsNewsEN objNewsEN = null;
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
objNewsEN = JsonConvert.DeserializeObject<clsNewsEN>((string)jobjReturn["returnObj"]);
return objNewsEN;
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
public static clsNewsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsNewsEN objNewsEN = null;
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
objNewsEN = JsonConvert.DeserializeObject<clsNewsEN>((string)jobjReturn["returnObj"]);
return objNewsEN;
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
public static clsNewsEN GetObjById_News_Cache(long lngId_News)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsNewsEN._CurrTabName);
List<clsNewsEN> arrNewsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsNewsEN> arrNewsObjLst_Sel =
from objNewsEN in arrNewsObjLst_Cache
where objNewsEN.Id_News == lngId_News
select objNewsEN;
if (arrNewsObjLst_Sel.Count() == 0)
{
   clsNewsEN obj = clsNewsWApi.GetObjById_News(lngId_News);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrNewsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsNewsEN> GetObjLst(string strWhereCond)
{
 List<clsNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsNewsEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsNewsEN> GetObjLstById_NewsLst(List<long> arrId_News)
{
 List<clsNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsNewsEN>>((string)jobjReturn["returnObjLst"]);
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
public static IEnumerable<clsNewsEN> GetObjLstById_NewsLst_Cache(List<long> arrId_News)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsNewsEN._CurrTabName);
List<clsNewsEN> arrNewsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsNewsEN> arrNewsObjLst_Sel =
from objNewsEN in arrNewsObjLst_Cache
where arrId_News.Contains(objNewsEN.Id_News)
select objNewsEN;
return arrNewsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsNewsEN> GetObjLstById_NewsLst_WA_Cache(List<long> arrId_News)
{
 List<clsNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsNewsEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsNewsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsNewsEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsNewsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsNewsEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsNewsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsNewsEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsNewsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsNewsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsNewsEN>>((string)jobjReturn["returnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(long lngId_News)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsNewsEN objNewsEN = clsNewsWApi.GetObjById_News(lngId_News);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngId_News.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
clsNewsWApi.ReFreshCache();
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
public static int DelNewss(List<string> arrId_News)
{
string strAction = "DelNewss";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_News);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
clsNewsWApi.ReFreshCache();
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
public static int DelNewssByCond(string strWhereCond)
{
string strAction = "DelNewssByCond";
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
public static bool AddNewRecord(clsNewsEN objNewsEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsNewsEN>(objNewsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objNewsEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsNewsEN objNewsEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsNewsEN>(objNewsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsNewsWApi.ReFreshCache();
var strReturnStr = (string)jobjReturn["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["errorMsg"]);
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
public static bool UpdateRecord(clsNewsEN objNewsEN)
{
if (string.IsNullOrEmpty(objNewsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objNewsEN.Id_News, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsNewsEN>(objNewsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 /// <param name = "objNewsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsNewsEN objNewsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objNewsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objNewsEN.Id_News, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objNewsEN.Id_News, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsNewsEN>(objNewsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
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
 /// <param name = "objNewsENS">源对象</param>
 /// <param name = "objNewsENT">目标对象</param>
 public static void CopyTo(clsNewsEN objNewsENS, clsNewsEN objNewsENT)
{
try
{
objNewsENT.Id_News = objNewsENS.Id_News; //Id_News
objNewsENT.NewsTypeId = objNewsENS.NewsTypeId; //信息类型Id
objNewsENT.NewsTitle = objNewsENS.NewsTitle; //信息标题
objNewsENT.NewsContent = objNewsENS.NewsContent; //信息内容
objNewsENT.ImgPath = objNewsENS.ImgPath; //图片路径
objNewsENT.EditPeople = objNewsENS.EditPeople; //编辑人
objNewsENT.EditTime = objNewsENS.EditTime; //编辑时间
objNewsENT.Source = objNewsENS.Source; //来源
objNewsENT.IsTop = objNewsENS.IsTop; //是否置顶
objNewsENT.Views = objNewsENS.Views; //浏览量
objNewsENT.Audit = objNewsENS.Audit; //审核
objNewsENT.IsDeleted = objNewsENS.IsDeleted; //是否删除
objNewsENT.DeletedDate = objNewsENS.DeletedDate; //删除日期
objNewsENT.Memo = objNewsENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsNewsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsNewsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsNewsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsNewsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsNewsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsNewsEN.AttributeName)
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_News");
//if (arrNewsObjLst_Cache == null)
//{
//arrNewsObjLst_Cache = await clsNewsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsNewsEN._CurrTabName);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsNewsWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsNewsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsNewsWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsNewsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsNewsEN._CurrTabName);
List<clsNewsEN> arrNewsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrNewsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsNewsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conNews.Id_News, Type.GetType("System.Int64"));
objDT.Columns.Add(conNews.NewsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conNews.NewsTitle, Type.GetType("System.String"));
objDT.Columns.Add(conNews.NewsContent, Type.GetType("System.String"));
objDT.Columns.Add(conNews.ImgPath, Type.GetType("System.String"));
objDT.Columns.Add(conNews.EditPeople, Type.GetType("System.String"));
objDT.Columns.Add(conNews.EditTime, Type.GetType("System.String"));
objDT.Columns.Add(conNews.Source, Type.GetType("System.String"));
objDT.Columns.Add(conNews.IsTop, Type.GetType("System.Boolean"));
objDT.Columns.Add(conNews.Views, Type.GetType("System.Int32"));
objDT.Columns.Add(conNews.Audit, Type.GetType("System.String"));
objDT.Columns.Add(conNews.IsDeleted, Type.GetType("System.Boolean"));
objDT.Columns.Add(conNews.DeletedDate, Type.GetType("System.String"));
objDT.Columns.Add(conNews.Memo, Type.GetType("System.String"));
foreach (clsNewsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conNews.Id_News] = objInFor[conNews.Id_News];
objDR[conNews.NewsTypeId] = objInFor[conNews.NewsTypeId];
objDR[conNews.NewsTitle] = objInFor[conNews.NewsTitle];
objDR[conNews.NewsContent] = objInFor[conNews.NewsContent];
objDR[conNews.ImgPath] = objInFor[conNews.ImgPath];
objDR[conNews.EditPeople] = objInFor[conNews.EditPeople];
objDR[conNews.EditTime] = objInFor[conNews.EditTime];
objDR[conNews.Source] = objInFor[conNews.Source];
objDR[conNews.IsTop] = objInFor[conNews.IsTop];
objDR[conNews.Views] = objInFor[conNews.Views];
objDR[conNews.Audit] = objInFor[conNews.Audit];
objDR[conNews.IsDeleted] = objInFor[conNews.IsDeleted];
objDR[conNews.DeletedDate] = objInFor[conNews.DeletedDate];
objDR[conNews.Memo] = objInFor[conNews.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 新闻(News)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4News : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
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
clsNewsWApi.ReFreshThisCache();
clsvNewsWApi.ReFreshThisCache();
}
}

}