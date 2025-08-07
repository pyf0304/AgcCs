
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCacheUseStateWApi
 表名:CacheUseState(00050566)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:18
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsCacheUseStateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCacheUseStateEN SetmId(this clsCacheUseStateEN objCacheUseStateEN, long lngmId, string strComparisonOp="")
	{
objCacheUseStateEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCacheUseStateEN.dicFldComparisonOp.ContainsKey(conCacheUseState.mId) == false)
{
objCacheUseStateEN.dicFldComparisonOp.Add(conCacheUseState.mId, strComparisonOp);
}
else
{
objCacheUseStateEN.dicFldComparisonOp[conCacheUseState.mId] = strComparisonOp;
}
}
return objCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strUserId">用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCacheUseStateEN SetUserId(this clsCacheUseStateEN objCacheUseStateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conCacheUseState.UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, conCacheUseState.UserId);
objCacheUseStateEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCacheUseStateEN.dicFldComparisonOp.ContainsKey(conCacheUseState.UserId) == false)
{
objCacheUseStateEN.dicFldComparisonOp.Add(conCacheUseState.UserId, strComparisonOp);
}
else
{
objCacheUseStateEN.dicFldComparisonOp[conCacheUseState.UserId] = strComparisonOp;
}
}
return objCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheModeId">缓存方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCacheUseStateEN SetCacheModeId(this clsCacheUseStateEN objCacheUseStateEN, string strCacheModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCacheModeId, conCacheUseState.CacheModeId);
clsCheckSql.CheckFieldLen(strCacheModeId, 2, conCacheUseState.CacheModeId);
clsCheckSql.CheckFieldForeignKey(strCacheModeId, 2, conCacheUseState.CacheModeId);
objCacheUseStateEN.CacheModeId = strCacheModeId; //缓存方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCacheUseStateEN.dicFldComparisonOp.ContainsKey(conCacheUseState.CacheModeId) == false)
{
objCacheUseStateEN.dicFldComparisonOp.Add(conCacheUseState.CacheModeId, strComparisonOp);
}
else
{
objCacheUseStateEN.dicFldComparisonOp[conCacheUseState.CacheModeId] = strComparisonOp;
}
}
return objCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strCacheKey">缓存关键字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCacheUseStateEN SetCacheKey(this clsCacheUseStateEN objCacheUseStateEN, string strCacheKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCacheKey, conCacheUseState.CacheKey);
clsCheckSql.CheckFieldLen(strCacheKey, 50, conCacheUseState.CacheKey);
objCacheUseStateEN.CacheKey = strCacheKey; //缓存关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCacheUseStateEN.dicFldComparisonOp.ContainsKey(conCacheUseState.CacheKey) == false)
{
objCacheUseStateEN.dicFldComparisonOp.Add(conCacheUseState.CacheKey, strComparisonOp);
}
else
{
objCacheUseStateEN.dicFldComparisonOp[conCacheUseState.CacheKey] = strComparisonOp;
}
}
return objCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "intCacheSize">缓存大小</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCacheUseStateEN SetCacheSize(this clsCacheUseStateEN objCacheUseStateEN, int intCacheSize, string strComparisonOp="")
	{
objCacheUseStateEN.CacheSize = intCacheSize; //缓存大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCacheUseStateEN.dicFldComparisonOp.ContainsKey(conCacheUseState.CacheSize) == false)
{
objCacheUseStateEN.dicFldComparisonOp.Add(conCacheUseState.CacheSize, strComparisonOp);
}
else
{
objCacheUseStateEN.dicFldComparisonOp[conCacheUseState.CacheSize] = strComparisonOp;
}
}
return objCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strUseDate">使用日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCacheUseStateEN SetUseDate(this clsCacheUseStateEN objCacheUseStateEN, string strUseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUseDate, 20, conCacheUseState.UseDate);
objCacheUseStateEN.UseDate = strUseDate; //使用日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCacheUseStateEN.dicFldComparisonOp.ContainsKey(conCacheUseState.UseDate) == false)
{
objCacheUseStateEN.dicFldComparisonOp.Add(conCacheUseState.UseDate, strComparisonOp);
}
else
{
objCacheUseStateEN.dicFldComparisonOp[conCacheUseState.UseDate] = strComparisonOp;
}
}
return objCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCacheUseStateEN SetMemo(this clsCacheUseStateEN objCacheUseStateEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCacheUseState.Memo);
objCacheUseStateEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCacheUseStateEN.dicFldComparisonOp.ContainsKey(conCacheUseState.Memo) == false)
{
objCacheUseStateEN.dicFldComparisonOp.Add(conCacheUseState.Memo, strComparisonOp);
}
else
{
objCacheUseStateEN.dicFldComparisonOp[conCacheUseState.Memo] = strComparisonOp;
}
}
return objCacheUseStateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCacheUseStateEN objCacheUseStateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCacheUseStateCond.IsUpdated(conCacheUseState.mId) == true)
{
string strComparisonOpmId = objCacheUseStateCond.dicFldComparisonOp[conCacheUseState.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCacheUseState.mId, objCacheUseStateCond.mId, strComparisonOpmId);
}
if (objCacheUseStateCond.IsUpdated(conCacheUseState.UserId) == true)
{
string strComparisonOpUserId = objCacheUseStateCond.dicFldComparisonOp[conCacheUseState.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCacheUseState.UserId, objCacheUseStateCond.UserId, strComparisonOpUserId);
}
if (objCacheUseStateCond.IsUpdated(conCacheUseState.CacheModeId) == true)
{
string strComparisonOpCacheModeId = objCacheUseStateCond.dicFldComparisonOp[conCacheUseState.CacheModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCacheUseState.CacheModeId, objCacheUseStateCond.CacheModeId, strComparisonOpCacheModeId);
}
if (objCacheUseStateCond.IsUpdated(conCacheUseState.CacheKey) == true)
{
string strComparisonOpCacheKey = objCacheUseStateCond.dicFldComparisonOp[conCacheUseState.CacheKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCacheUseState.CacheKey, objCacheUseStateCond.CacheKey, strComparisonOpCacheKey);
}
if (objCacheUseStateCond.IsUpdated(conCacheUseState.CacheSize) == true)
{
string strComparisonOpCacheSize = objCacheUseStateCond.dicFldComparisonOp[conCacheUseState.CacheSize];
strWhereCond += string.Format(" And {0} {2} {1}", conCacheUseState.CacheSize, objCacheUseStateCond.CacheSize, strComparisonOpCacheSize);
}
if (objCacheUseStateCond.IsUpdated(conCacheUseState.UseDate) == true)
{
string strComparisonOpUseDate = objCacheUseStateCond.dicFldComparisonOp[conCacheUseState.UseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCacheUseState.UseDate, objCacheUseStateCond.UseDate, strComparisonOpUseDate);
}
if (objCacheUseStateCond.IsUpdated(conCacheUseState.Memo) == true)
{
string strComparisonOpMemo = objCacheUseStateCond.dicFldComparisonOp[conCacheUseState.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCacheUseState.Memo, objCacheUseStateCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCacheUseStateEN objCacheUseStateEN)
{
 if (objCacheUseStateEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCacheUseStateEN.sfUpdFldSetStr = objCacheUseStateEN.getsfUpdFldSetStr();
clsCacheUseStateWApi.CheckPropertyNew(objCacheUseStateEN); 
bool bolResult = clsCacheUseStateWApi.UpdateRecord(objCacheUseStateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateWApi.ReFreshCache(objCacheUseStateEN.UserId);
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
 /// 获取唯一性条件串--CacheUseState(缓存使用状态), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:UserId_CacheModeId_CacheKey
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCacheUseStateEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsCacheUseStateEN objCacheUseStateEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCacheUseStateEN == null) return "";
if (objCacheUseStateEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CacheModeId = '{0}'", objCacheUseStateEN.CacheModeId);
 sbCondition.AppendFormat(" and CacheKey = '{0}'", objCacheUseStateEN.CacheKey);
 sbCondition.AppendFormat(" and UserId = '{0}'", objCacheUseStateEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCacheUseStateEN.mId);
 sbCondition.AppendFormat(" and CacheModeId = '{0}'", objCacheUseStateEN.CacheModeId);
 sbCondition.AppendFormat(" and CacheKey = '{0}'", objCacheUseStateEN.CacheKey);
 sbCondition.AppendFormat(" and UserId = '{0}'", objCacheUseStateEN.UserId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCacheUseStateEN objCacheUseStateEN)
{
try
{
clsCacheUseStateWApi.CheckPropertyNew(objCacheUseStateEN); 
bool bolResult = clsCacheUseStateWApi.AddNewRecord(objCacheUseStateEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateWApi.ReFreshCache(objCacheUseStateEN.UserId);
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
 /// <param name = "objCacheUseStateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCacheUseStateEN objCacheUseStateEN, string strWhereCond)
{
try
{
clsCacheUseStateWApi.CheckPropertyNew(objCacheUseStateEN); 
bool bolResult = clsCacheUseStateWApi.UpdateWithCondition(objCacheUseStateEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateWApi.ReFreshCache(objCacheUseStateEN.UserId);
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
 /// 缓存使用状态(CacheUseState)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCacheUseStateWApi
{
private static readonly string mstrApiControllerName = "CacheUseStateApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsCacheUseStateWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_mId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[缓存使用状态]...","0");
List<clsCacheUseStateEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="mId";
objDDL.DataTextField="UserId";
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

 /// <param name = "strUserId"></param>
public static void BindCbo_mId(System.Windows.Forms.ComboBox objComboBox , string strUserId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCacheUseState.mId); 
List<clsCacheUseStateEN> arrObjLst = clsCacheUseStateWApi.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.UserId == strUserId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCacheUseStateEN objCacheUseStateEN = new clsCacheUseStateEN()
{
mId = 0,
UserId = "选[缓存使用状态]..."
};
arrObjLstSel.Insert(0, objCacheUseStateEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCacheUseState.mId;
objComboBox.DisplayMember = conCacheUseState.UserId;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCacheUseStateEN objCacheUseStateEN)
{
if (!Object.Equals(null, objCacheUseStateEN.UserId) && GetStrLen(objCacheUseStateEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objCacheUseStateEN.CacheModeId) && GetStrLen(objCacheUseStateEN.CacheModeId) > 2)
{
 throw new Exception("字段[缓存方式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCacheUseStateEN.CacheKey) && GetStrLen(objCacheUseStateEN.CacheKey) > 50)
{
 throw new Exception("字段[缓存关键字]的长度不能超过50!");
}
if (!Object.Equals(null, objCacheUseStateEN.UseDate) && GetStrLen(objCacheUseStateEN.UseDate) > 20)
{
 throw new Exception("字段[使用日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCacheUseStateEN.Memo) && GetStrLen(objCacheUseStateEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objCacheUseStateEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCacheUseStateEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsCacheUseStateEN objCacheUseStateEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objCacheUseStateEN = JsonConvert.DeserializeObject<clsCacheUseStateEN>(strJson);
return objCacheUseStateEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsCacheUseStateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCacheUseStateEN objCacheUseStateEN;
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
objCacheUseStateEN = JsonConvert.DeserializeObject<clsCacheUseStateEN>(strJson);
return objCacheUseStateEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCacheUseStateEN GetObjBymIdCache(long lngmId,string strUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
List<clsCacheUseStateEN> arrCacheUseStateObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsCacheUseStateEN> arrCacheUseStateObjLst_Sel =
from objCacheUseStateEN in arrCacheUseStateObjLstCache
where objCacheUseStateEN.mId == lngmId 
select objCacheUseStateEN;
if (arrCacheUseStateObjLst_Sel.Count() == 0)
{
   clsCacheUseStateEN obj = clsCacheUseStateWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCacheUseStateObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUserIdBymIdCache(long lngmId,string strUserId)
{
//初始化列表缓存
List<clsCacheUseStateEN> arrCacheUseStateObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsCacheUseStateEN> arrCacheUseStateObjLst_Sel1 =
from objCacheUseStateEN in arrCacheUseStateObjLstCache
where objCacheUseStateEN.mId == lngmId 
select objCacheUseStateEN;
List <clsCacheUseStateEN> arrCacheUseStateObjLst_Sel = new List<clsCacheUseStateEN>();
foreach (clsCacheUseStateEN obj in arrCacheUseStateObjLst_Sel1)
{
arrCacheUseStateObjLst_Sel.Add(obj);
}
if (arrCacheUseStateObjLst_Sel.Count > 0)
{
return arrCacheUseStateObjLst_Sel[0].UserId;
}
string strErrMsgForGetObjById = string.Format("在CacheUseState对象缓存列表中,找不到记录[mId = {0}](函数:{1})", lngmId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCacheUseStateBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBymIdCache(long lngmId,string strUserId)
{
//初始化列表缓存
List<clsCacheUseStateEN> arrCacheUseStateObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsCacheUseStateEN> arrCacheUseStateObjLst_Sel1 =
from objCacheUseStateEN in arrCacheUseStateObjLstCache
where objCacheUseStateEN.mId == lngmId 
select objCacheUseStateEN;
List <clsCacheUseStateEN> arrCacheUseStateObjLst_Sel = new List<clsCacheUseStateEN>();
foreach (clsCacheUseStateEN obj in arrCacheUseStateObjLst_Sel1)
{
arrCacheUseStateObjLst_Sel.Add(obj);
}
if (arrCacheUseStateObjLst_Sel.Count > 0)
{
return arrCacheUseStateObjLst_Sel[0].UserId;
}
string strErrMsgForGetObjById = string.Format("在CacheUseState对象缓存列表中,找不到记录的相关名称[mId = {0}](函数:{1})", lngmId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsCacheUseStateBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCacheUseStateEN> GetObjLst(string strWhereCond)
{
 List<clsCacheUseStateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCacheUseStateEN>>(strJson);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsCacheUseStateEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsCacheUseStateEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsCacheUseStateEN>>(strJson);
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
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsCacheUseStateEN> GetObjLstByMIdLstCache(List<long> arrMId, string strUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
List<clsCacheUseStateEN> arrCacheUseStateObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsCacheUseStateEN> arrCacheUseStateObjLst_Sel =
from objCacheUseStateEN in arrCacheUseStateObjLstCache
where arrMId.Contains(objCacheUseStateEN.mId)
select objCacheUseStateEN;
return arrCacheUseStateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCacheUseStateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCacheUseStateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCacheUseStateEN>>(strJson);
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
public static List<clsCacheUseStateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCacheUseStateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCacheUseStateEN>>(strJson);
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
public static List<clsCacheUseStateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCacheUseStateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCacheUseStateEN>>(strJson);
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
public static List<clsCacheUseStateEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCacheUseStateEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCacheUseStateEN>>(strJson);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
try
{
 clsCacheUseStateEN objCacheUseStateEN = clsCacheUseStateWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsCacheUseStateWApi.ReFreshCache(objCacheUseStateEN.UserId);
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
public static int DelCacheUseStates(List<string> arrmId)
{
string strAction = "DelCacheUseStates";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsCacheUseStateEN objCacheUseStateEN = clsCacheUseStateWApi.GetObjBymId(long.Parse(arrmId[0]));
clsCacheUseStateWApi.ReFreshCache(objCacheUseStateEN.UserId);
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
public static int DelCacheUseStatesByCond(string strWhereCond)
{
string strAction = "DelCacheUseStatesByCond";
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
public static bool AddNewRecord(clsCacheUseStateEN objCacheUseStateEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCacheUseStateEN>(objCacheUseStateEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateWApi.ReFreshCache(objCacheUseStateEN.UserId);
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objCacheUseStateEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCacheUseStateEN objCacheUseStateEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCacheUseStateEN>(objCacheUseStateEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCacheUseStateWApi.ReFreshCache(objCacheUseStateEN.UserId);
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsCacheUseStateEN objCacheUseStateEN)
{
if (string.IsNullOrEmpty(objCacheUseStateEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCacheUseStateEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCacheUseStateEN>(objCacheUseStateEN);
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
 /// <param name = "objCacheUseStateEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCacheUseStateEN objCacheUseStateEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCacheUseStateEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCacheUseStateEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCacheUseStateEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCacheUseStateEN>(objCacheUseStateEN);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
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
 /// <param name = "objCacheUseStateENS">源对象</param>
 /// <param name = "objCacheUseStateENT">目标对象</param>
 public static void CopyTo(clsCacheUseStateEN objCacheUseStateENS, clsCacheUseStateEN objCacheUseStateENT)
{
try
{
objCacheUseStateENT.mId = objCacheUseStateENS.mId; //mId
objCacheUseStateENT.UserId = objCacheUseStateENS.UserId; //用户Id
objCacheUseStateENT.CacheModeId = objCacheUseStateENS.CacheModeId; //缓存方式Id
objCacheUseStateENT.CacheKey = objCacheUseStateENS.CacheKey; //缓存关键字
objCacheUseStateENT.CacheSize = objCacheUseStateENS.CacheSize; //缓存大小
objCacheUseStateENT.UseDate = objCacheUseStateENS.UseDate; //使用日期
objCacheUseStateENT.Memo = objCacheUseStateENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsCacheUseStateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCacheUseStateEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCacheUseStateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCacheUseStateEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCacheUseStateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCacheUseStateEN._AttributeName)
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
public static void ReFreshThisCache(string strUserId = "")
{


if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空！(In clsCacheUseStateWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
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
public static void ReFreshCache(string strUserId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsCacheUseStateWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
CacheHelper.Remove(strKey);
clsCacheUseStateWApi.objCommFun4WApi.ReFreshCache(strUserId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCacheUseStateEN> GetObjLstCache(string strUserId)
{


if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空！(In clsCacheUseStateWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsCacheUseStateEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsCacheUseStateEN._WhereFormat, strUserId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conCacheUseState.UserId, strUserId);
}
var strKey = string.Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
List<clsCacheUseStateEN> arrCacheUseStateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrCacheUseStateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCacheUseStateEN> GetObjLstCacheFromObjLst(string strUserId,List<clsCacheUseStateEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空！(In clsCacheUseStateWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
var strKey = string.Format("{0}_{1}", clsCacheUseStateEN._CurrTabName, strUserId);
List<clsCacheUseStateEN> arrCacheUseStateObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrCacheUseStateObjLstCache = CacheHelper.Get<List<clsCacheUseStateEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.UserId == strUserId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrCacheUseStateObjLstCache = CacheHelper.Get<List<clsCacheUseStateEN>>(strKey);
}
return arrCacheUseStateObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCacheUseStateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCacheUseState.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conCacheUseState.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conCacheUseState.CacheModeId, Type.GetType("System.String"));
objDT.Columns.Add(conCacheUseState.CacheKey, Type.GetType("System.String"));
objDT.Columns.Add(conCacheUseState.CacheSize, Type.GetType("System.Int32"));
objDT.Columns.Add(conCacheUseState.UseDate, Type.GetType("System.String"));
objDT.Columns.Add(conCacheUseState.Memo, Type.GetType("System.String"));
foreach (clsCacheUseStateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCacheUseState.mId] = objInFor[conCacheUseState.mId];
objDR[conCacheUseState.UserId] = objInFor[conCacheUseState.UserId];
objDR[conCacheUseState.CacheModeId] = objInFor[conCacheUseState.CacheModeId];
objDR[conCacheUseState.CacheKey] = objInFor[conCacheUseState.CacheKey];
objDR[conCacheUseState.CacheSize] = objInFor[conCacheUseState.CacheSize];
objDR[conCacheUseState.UseDate] = objInFor[conCacheUseState.UseDate];
objDR[conCacheUseState.Memo] = objInFor[conCacheUseState.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 缓存使用状态(CacheUseState)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CacheUseState : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strUserId)
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
clsCacheUseStateWApi.ReFreshThisCache(strUserId);
}
}

}