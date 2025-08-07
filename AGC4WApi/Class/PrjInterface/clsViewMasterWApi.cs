
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewMasterWApi
 表名:ViewMaster(00050557)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
 框架-层名:WA_访问层(CS)(WA_Access,0045)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
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
/// <summary>
/// 静态类
/// </summary>
public static class  clsViewMasterWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewMasterId">界面母版Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetViewMasterId(this clsViewMasterEN objViewMasterEN, string strViewMasterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewMasterId, 8, conViewMaster.ViewMasterId);
clsCheckSql.CheckFieldForeignKey(strViewMasterId, 8, conViewMaster.ViewMasterId);
objViewMasterEN.ViewMasterId = strViewMasterId; //界面母版Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.ViewMasterId) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.ViewMasterId, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.ViewMasterId] = strComparisonOp;
}
}
return objViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewMasterName">界面母版名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetViewMasterName(this clsViewMasterEN objViewMasterEN, string strViewMasterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewMasterName, conViewMaster.ViewMasterName);
clsCheckSql.CheckFieldLen(strViewMasterName, 50, conViewMaster.ViewMasterName);
objViewMasterEN.ViewMasterName = strViewMasterName; //界面母版名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.ViewMasterName) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.ViewMasterName, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.ViewMasterName] = strComparisonOp;
}
}
return objViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strViewMasterPath">界面母版路径</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetViewMasterPath(this clsViewMasterEN objViewMasterEN, string strViewMasterPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewMasterPath, conViewMaster.ViewMasterPath);
clsCheckSql.CheckFieldLen(strViewMasterPath, 100, conViewMaster.ViewMasterPath);
objViewMasterEN.ViewMasterPath = strViewMasterPath; //界面母版路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.ViewMasterPath) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.ViewMasterPath, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.ViewMasterPath] = strComparisonOp;
}
}
return objViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetApplicationTypeId(this clsViewMasterEN objViewMasterEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, conViewMaster.ApplicationTypeId);
objViewMasterEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.ApplicationTypeId) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.ApplicationTypeId, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.ApplicationTypeId] = strComparisonOp;
}
}
return objViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetPrjId(this clsViewMasterEN objViewMasterEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conViewMaster.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conViewMaster.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conViewMaster.PrjId);
objViewMasterEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.PrjId) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.PrjId, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.PrjId] = strComparisonOp;
}
}
return objViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetUpdDate(this clsViewMasterEN objViewMasterEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conViewMaster.UpdDate);
objViewMasterEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.UpdDate) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.UpdDate, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.UpdDate] = strComparisonOp;
}
}
return objViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetUpdUser(this clsViewMasterEN objViewMasterEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conViewMaster.UpdUser);
objViewMasterEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.UpdUser) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.UpdUser, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.UpdUser] = strComparisonOp;
}
}
return objViewMasterEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objViewMasterEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsViewMasterEN SetMemo(this clsViewMasterEN objViewMasterEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conViewMaster.Memo);
objViewMasterEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objViewMasterEN.dicFldComparisonOp.ContainsKey(conViewMaster.Memo) == false)
{
objViewMasterEN.dicFldComparisonOp.Add(conViewMaster.Memo, strComparisonOp);
}
else
{
objViewMasterEN.dicFldComparisonOp[conViewMaster.Memo] = strComparisonOp;
}
}
return objViewMasterEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsViewMasterEN objViewMasterCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objViewMasterCond.IsUpdated(conViewMaster.ViewMasterId) == true)
{
string strComparisonOpViewMasterId = objViewMasterCond.dicFldComparisonOp[conViewMaster.ViewMasterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewMaster.ViewMasterId, objViewMasterCond.ViewMasterId, strComparisonOpViewMasterId);
}
if (objViewMasterCond.IsUpdated(conViewMaster.ViewMasterName) == true)
{
string strComparisonOpViewMasterName = objViewMasterCond.dicFldComparisonOp[conViewMaster.ViewMasterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewMaster.ViewMasterName, objViewMasterCond.ViewMasterName, strComparisonOpViewMasterName);
}
if (objViewMasterCond.IsUpdated(conViewMaster.ViewMasterPath) == true)
{
string strComparisonOpViewMasterPath = objViewMasterCond.dicFldComparisonOp[conViewMaster.ViewMasterPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewMaster.ViewMasterPath, objViewMasterCond.ViewMasterPath, strComparisonOpViewMasterPath);
}
if (objViewMasterCond.IsUpdated(conViewMaster.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objViewMasterCond.dicFldComparisonOp[conViewMaster.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", conViewMaster.ApplicationTypeId, objViewMasterCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objViewMasterCond.IsUpdated(conViewMaster.PrjId) == true)
{
string strComparisonOpPrjId = objViewMasterCond.dicFldComparisonOp[conViewMaster.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewMaster.PrjId, objViewMasterCond.PrjId, strComparisonOpPrjId);
}
if (objViewMasterCond.IsUpdated(conViewMaster.UpdDate) == true)
{
string strComparisonOpUpdDate = objViewMasterCond.dicFldComparisonOp[conViewMaster.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewMaster.UpdDate, objViewMasterCond.UpdDate, strComparisonOpUpdDate);
}
if (objViewMasterCond.IsUpdated(conViewMaster.UpdUser) == true)
{
string strComparisonOpUpdUser = objViewMasterCond.dicFldComparisonOp[conViewMaster.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewMaster.UpdUser, objViewMasterCond.UpdUser, strComparisonOpUpdUser);
}
if (objViewMasterCond.IsUpdated(conViewMaster.Memo) == true)
{
string strComparisonOpMemo = objViewMasterCond.dicFldComparisonOp[conViewMaster.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conViewMaster.Memo, objViewMasterCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsViewMasterEN objViewMasterEN)
{
 if (string.IsNullOrEmpty(objViewMasterEN.ViewMasterId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objViewMasterEN.sfUpdFldSetStr = objViewMasterEN.getsfUpdFldSetStr();
clsViewMasterWApi.CheckPropertyNew(objViewMasterEN); 
bool bolResult = clsViewMasterWApi.UpdateRecord(objViewMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterWApi.ReFreshCache(objViewMasterEN.PrjId);
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
 /// 获取唯一性条件串--ViewMaster(界面母版), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PrjId_ApplicationTypeId_ViewMasterName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objViewMasterEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsViewMasterEN objViewMasterEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objViewMasterEN == null) return "";
if (objViewMasterEN.ViewMasterId == null || objViewMasterEN.ViewMasterId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewMasterEN.PrjId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewMasterEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and ViewMasterName = '{0}'", objViewMasterEN.ViewMasterName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewMasterId !=  '{0}'", objViewMasterEN.ViewMasterId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewMasterEN.PrjId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewMasterEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and ViewMasterName = '{0}'", objViewMasterEN.ViewMasterName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsViewMasterEN objViewMasterEN)
{
try
{
 if (string.IsNullOrEmpty(objViewMasterEN.ViewMasterId) == true || clsViewMasterWApi.IsExist(objViewMasterEN.ViewMasterId) == true)
 {
     objViewMasterEN.ViewMasterId = clsViewMasterWApi.GetMaxStrId();
 }
clsViewMasterWApi.CheckPropertyNew(objViewMasterEN); 
bool bolResult = clsViewMasterWApi.AddNewRecord(objViewMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterWApi.ReFreshCache(objViewMasterEN.PrjId);
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objViewMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsViewMasterEN objViewMasterEN)
{
try
{
clsViewMasterWApi.CheckPropertyNew(objViewMasterEN); 
string strViewMasterId = clsViewMasterWApi.AddNewRecordWithMaxId(objViewMasterEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterWApi.ReFreshCache(objViewMasterEN.PrjId);
return strViewMasterId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objViewMasterEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsViewMasterEN objViewMasterEN, string strWhereCond)
{
try
{
clsViewMasterWApi.CheckPropertyNew(objViewMasterEN); 
bool bolResult = clsViewMasterWApi.UpdateWithCondition(objViewMasterEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterWApi.ReFreshCache(objViewMasterEN.PrjId);
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
 /// 界面母版(ViewMaster)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsViewMasterWApi
{
private static readonly string mstrApiControllerName = "ViewMasterApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsViewMasterWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ViewMasterId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面母版]...","0");
List<clsViewMasterEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ViewMasterId";
objDDL.DataTextField="ViewMasterName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "intApplicationTypeId"></param>
 /// <param name = "strPrjId"></param>
public static void BindCbo_ViewMasterId(System.Windows.Forms.ComboBox objComboBox , int intApplicationTypeId,string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conViewMaster.ViewMasterId); 
List<clsViewMasterEN> arrObjLst = clsViewMasterWApi.GetObjLst(strCondition).OrderBy(x=>x.ViewMasterName).ToList();
var arrObjLstSel = arrObjLst.Where(x=>x.ApplicationTypeId == intApplicationTypeId&& x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsViewMasterEN objViewMasterEN = new clsViewMasterEN()
{
ViewMasterId = "0",
ViewMasterName = "选[界面母版]..."
};
arrObjLstSel.Insert(0, objViewMasterEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conViewMaster.ViewMasterId;
objComboBox.DisplayMember = conViewMaster.ViewMasterName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsViewMasterEN objViewMasterEN)
{
if (!Object.Equals(null, objViewMasterEN.ViewMasterId) && GetStrLen(objViewMasterEN.ViewMasterId) > 8)
{
 throw new Exception("字段[界面母版Id]的长度不能超过8!");
}
if (!Object.Equals(null, objViewMasterEN.ViewMasterName) && GetStrLen(objViewMasterEN.ViewMasterName) > 50)
{
 throw new Exception("字段[界面母版名]的长度不能超过50!");
}
if (!Object.Equals(null, objViewMasterEN.ViewMasterPath) && GetStrLen(objViewMasterEN.ViewMasterPath) > 100)
{
 throw new Exception("字段[界面母版路径]的长度不能超过100!");
}
if (!Object.Equals(null, objViewMasterEN.PrjId) && GetStrLen(objViewMasterEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objViewMasterEN.UpdDate) && GetStrLen(objViewMasterEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objViewMasterEN.UpdUser) && GetStrLen(objViewMasterEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objViewMasterEN.Memo) && GetStrLen(objViewMasterEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objViewMasterEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewMasterId">表关键字</param>
 /// <returns>表对象</returns>
public static clsViewMasterEN GetObjByViewMasterId(string strViewMasterId)
{
if (strViewMasterId == "") return null;
string strAction = "GetObjByViewMasterId";
clsViewMasterEN objViewMasterEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewMasterId"] = strViewMasterId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objViewMasterEN = JsonConvert.DeserializeObject<clsViewMasterEN>(strJson);
return objViewMasterEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsViewMasterEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsViewMasterEN objViewMasterEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objViewMasterEN = JsonConvert.DeserializeObject<clsViewMasterEN>(strJson);
return objViewMasterEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strViewMasterId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsViewMasterEN GetObjByViewMasterIdCache(string strViewMasterId,string strPrjId)
{
if (string.IsNullOrEmpty(strViewMasterId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsViewMasterEN._CurrTabName, strPrjId);
List<clsViewMasterEN> arrViewMasterObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewMasterEN> arrViewMasterObjLst_Sel =
from objViewMasterEN in arrViewMasterObjLstCache
where objViewMasterEN.ViewMasterId == strViewMasterId 
select objViewMasterEN;
if (arrViewMasterObjLst_Sel.Count() == 0)
{
   clsViewMasterEN obj = clsViewMasterWApi.GetObjByViewMasterId(strViewMasterId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrViewMasterObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewMasterId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetViewMasterNameByViewMasterIdCache(string strViewMasterId,string strPrjId)
{
if (string.IsNullOrEmpty(strViewMasterId) == true) return "";
//初始化列表缓存
List<clsViewMasterEN> arrViewMasterObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewMasterEN> arrViewMasterObjLst_Sel1 =
from objViewMasterEN in arrViewMasterObjLstCache
where objViewMasterEN.ViewMasterId == strViewMasterId 
select objViewMasterEN;
List <clsViewMasterEN> arrViewMasterObjLst_Sel = new List<clsViewMasterEN>();
foreach (clsViewMasterEN obj in arrViewMasterObjLst_Sel1)
{
arrViewMasterObjLst_Sel.Add(obj);
}
if (arrViewMasterObjLst_Sel.Count > 0)
{
return arrViewMasterObjLst_Sel[0].ViewMasterName;
}
string strErrMsgForGetObjById = string.Format("在ViewMaster对象缓存列表中,找不到记录[ViewMasterId = {0}](函数:{1})", strViewMasterId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsViewMasterBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strViewMasterId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByViewMasterIdCache(string strViewMasterId,string strPrjId)
{
if (string.IsNullOrEmpty(strViewMasterId) == true) return "";
//初始化列表缓存
List<clsViewMasterEN> arrViewMasterObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewMasterEN> arrViewMasterObjLst_Sel1 =
from objViewMasterEN in arrViewMasterObjLstCache
where objViewMasterEN.ViewMasterId == strViewMasterId 
select objViewMasterEN;
List <clsViewMasterEN> arrViewMasterObjLst_Sel = new List<clsViewMasterEN>();
foreach (clsViewMasterEN obj in arrViewMasterObjLst_Sel1)
{
arrViewMasterObjLst_Sel.Add(obj);
}
if (arrViewMasterObjLst_Sel.Count > 0)
{
return arrViewMasterObjLst_Sel[0].ViewMasterName;
}
string strErrMsgForGetObjById = string.Format("在ViewMaster对象缓存列表中,找不到记录的相关名称[ViewMasterId = {0}](函数:{1})", strViewMasterId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsViewMasterBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewMasterEN> GetObjLst(string strWhereCond)
{
 List<clsViewMasterEN> arrObjLst; 
string strAction = "GetObjLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsViewMasterEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// <param name = "arrViewMasterId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewMasterEN> GetObjLstByViewMasterIdLst(List<string> arrViewMasterId)
{
 List<clsViewMasterEN> arrObjLst; 
string strAction = "GetObjLstByViewMasterIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewMasterId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsViewMasterEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrViewMasterId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsViewMasterEN> GetObjLstByViewMasterIdLstCache(List<string> arrViewMasterId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsViewMasterEN._CurrTabName, strPrjId);
List<clsViewMasterEN> arrViewMasterObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsViewMasterEN> arrViewMasterObjLst_Sel =
from objViewMasterEN in arrViewMasterObjLstCache
where arrViewMasterId.Contains(objViewMasterEN.ViewMasterId)
select objViewMasterEN;
return arrViewMasterObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsViewMasterEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsViewMasterEN> arrObjLst; 
string strAction = "GetTopObjLst";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsViewMasterEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static List<clsViewMasterEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsViewMasterEN> arrObjLst; 
string strAction = "GetObjLstByRange";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsViewMasterEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static List<clsViewMasterEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsViewMasterEN> arrObjLst; 
string strAction = "GetObjLstByPager";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsViewMasterEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsViewMasterEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsViewMasterEN> arrObjLst; 
string strAction = "GetObjLstByPagerCache";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsViewMasterEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static int DelRecord(string strViewMasterId)
{
string strAction = "DelRecord";
try
{
 clsViewMasterEN objViewMasterEN = clsViewMasterWApi.GetObjByViewMasterId(strViewMasterId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strViewMasterId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsViewMasterWApi.ReFreshCache(objViewMasterEN.PrjId);
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static int DelViewMasters(List<string> arrViewMasterId)
{
string strAction = "DelViewMasters";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewMasterId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsViewMasterEN objViewMasterEN = clsViewMasterWApi.GetObjByViewMasterId(arrViewMasterId[0]);
clsViewMasterWApi.ReFreshCache(objViewMasterEN.PrjId);
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static int DelViewMastersByCond(string strWhereCond)
{
string strAction = "DelViewMastersByCond";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static bool AddNewRecord(clsViewMasterEN objViewMasterEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewMasterEN>(objViewMasterEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterWApi.ReFreshCache(objViewMasterEN.PrjId);
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>新建记录的关键字</returns>
public static string AddNewRecordWithMaxId(clsViewMasterEN objViewMasterEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewMasterEN>(objViewMasterEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsViewMasterWApi.ReFreshCache(objViewMasterEN.PrjId);
var strViewMasterId = (string)jobjReturn0["returnStr"];
return strViewMasterId;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static bool UpdateRecord(clsViewMasterEN objViewMasterEN)
{
if (string.IsNullOrEmpty(objViewMasterEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewMasterEN.ViewMasterId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewMasterEN>(objViewMasterEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// <param name = "objViewMasterEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsViewMasterEN objViewMasterEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objViewMasterEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewMasterEN.ViewMasterId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objViewMasterEN.ViewMasterId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsViewMasterEN>(objViewMasterEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static bool IsExist(string strViewMasterId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strViewMasterId"] = strViewMasterId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn0["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
{"strPrefix", strPrefix}
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase4Tab:GengetStrLen)
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
 /// <param name = "objViewMasterENS">源对象</param>
 /// <param name = "objViewMasterENT">目标对象</param>
 public static void CopyTo(clsViewMasterEN objViewMasterENS, clsViewMasterEN objViewMasterENT)
{
try
{
objViewMasterENT.ViewMasterId = objViewMasterENS.ViewMasterId; //界面母版Id
objViewMasterENT.ViewMasterName = objViewMasterENS.ViewMasterName; //界面母版名
objViewMasterENT.ViewMasterPath = objViewMasterENS.ViewMasterPath; //界面母版路径
objViewMasterENT.ApplicationTypeId = objViewMasterENS.ApplicationTypeId; //应用程序类型ID
objViewMasterENT.PrjId = objViewMasterENS.PrjId; //工程Id
objViewMasterENT.UpdDate = objViewMasterENS.UpdDate; //修改日期
objViewMasterENT.UpdUser = objViewMasterENS.UpdUser; //修改者
objViewMasterENT.Memo = objViewMasterENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsViewMasterEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsViewMasterEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsViewMasterEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsViewMasterEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsViewMasterEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsViewMasterEN._AttributeName)
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
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewMasterWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewMasterWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsViewMasterEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
}
else
{
strMsg0 = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg0);
}
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsViewMasterWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsViewMasterEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsViewMasterWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewMasterEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewMasterWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewMasterWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsViewMasterEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsViewMasterEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conViewMaster.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsViewMasterEN._CurrTabName, strPrjId);
List<clsViewMasterEN> arrViewMasterObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrViewMasterObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsViewMasterEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsViewMasterEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsViewMasterWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsViewMasterWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsViewMasterEN._CurrTabName, strPrjId);
List<clsViewMasterEN> arrViewMasterObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrViewMasterObjLstCache = CacheHelper.Get<List<clsViewMasterEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrViewMasterObjLstCache = CacheHelper.Get<List<clsViewMasterEN>>(strKey);
}
return arrViewMasterObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsViewMasterEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conViewMaster.ViewMasterId, Type.GetType("System.String"));
objDT.Columns.Add(conViewMaster.ViewMasterName, Type.GetType("System.String"));
objDT.Columns.Add(conViewMaster.ViewMasterPath, Type.GetType("System.String"));
objDT.Columns.Add(conViewMaster.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(conViewMaster.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conViewMaster.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conViewMaster.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conViewMaster.Memo, Type.GetType("System.String"));
foreach (clsViewMasterEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conViewMaster.ViewMasterId] = objInFor[conViewMaster.ViewMasterId];
objDR[conViewMaster.ViewMasterName] = objInFor[conViewMaster.ViewMasterName];
objDR[conViewMaster.ViewMasterPath] = objInFor[conViewMaster.ViewMasterPath];
objDR[conViewMaster.ApplicationTypeId] = objInFor[conViewMaster.ApplicationTypeId];
objDR[conViewMaster.PrjId] = objInFor[conViewMaster.PrjId];
objDR[conViewMaster.UpdDate] = objInFor[conViewMaster.UpdDate];
objDR[conViewMaster.UpdUser] = objInFor[conViewMaster.UpdUser];
objDR[conViewMaster.Memo] = objInFor[conViewMaster.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 界面母版(ViewMaster)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ViewMaster : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
{
string strMsg;
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
clsViewMasterWApi.ReFreshThisCache(strPrjId);
}
}

}