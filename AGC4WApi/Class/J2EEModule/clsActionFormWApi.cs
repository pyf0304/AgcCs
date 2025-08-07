
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsActionFormWApi
 表名:ActionForm(00050138)
 生成代码版本:2020.06.21.1
 生成日期:2020/06/27 00:00:12
 生成者:
 生成服务器IP:192.168.1.10
 工程名称:AGC
 工程ID:0005
 相关数据库:tzar.tpddns.cn,19433AGC_CS12
 PrjDataBaseId:0213
 模块中文名:J2EE模块
 模块英文名:J2EEModule
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
using AGC.Const;

namespace AGC4WApi
{
public static class clsActionFormWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objActionFormEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsActionFormEN SetActionFormId(this clsActionFormEN objActionFormEN, string strActionFormId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strActionFormId, 8, clsActionFormEN.con_ActionFormId);
clsCheckSql.CheckFieldForeignKey(strActionFormId, 8, clsActionFormEN.con_ActionFormId);
objActionFormEN.ActionFormId = strActionFormId; //ActionFormId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objActionFormEN.dicFldComparisonOp.ContainsKey(clsActionFormEN.con_ActionFormId) == false)
{
objActionFormEN.dicFldComparisonOp.Add(clsActionFormEN.con_ActionFormId, strComparisonOp);
}
else
{
objActionFormEN.dicFldComparisonOp[clsActionFormEN.con_ActionFormId] = strComparisonOp;
}
}
return objActionFormEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objActionFormEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsActionFormEN SetActionFormName(this clsActionFormEN objActionFormEN, string strActionFormName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strActionFormName, clsActionFormEN.con_ActionFormName);
clsCheckSql.CheckFieldLen(strActionFormName, 100, clsActionFormEN.con_ActionFormName);
objActionFormEN.ActionFormName = strActionFormName; //ActionForm名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objActionFormEN.dicFldComparisonOp.ContainsKey(clsActionFormEN.con_ActionFormName) == false)
{
objActionFormEN.dicFldComparisonOp.Add(clsActionFormEN.con_ActionFormName, strComparisonOp);
}
else
{
objActionFormEN.dicFldComparisonOp[clsActionFormEN.con_ActionFormName] = strComparisonOp;
}
}
return objActionFormEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objActionFormEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsActionFormEN SetViewGroupId(this clsActionFormEN objActionFormEN, string strViewGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewGroupId, clsActionFormEN.con_ViewGroupId);
clsCheckSql.CheckFieldLen(strViewGroupId, 8, clsActionFormEN.con_ViewGroupId);
clsCheckSql.CheckFieldForeignKey(strViewGroupId, 8, clsActionFormEN.con_ViewGroupId);
objActionFormEN.ViewGroupId = strViewGroupId; //界面组ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objActionFormEN.dicFldComparisonOp.ContainsKey(clsActionFormEN.con_ViewGroupId) == false)
{
objActionFormEN.dicFldComparisonOp.Add(clsActionFormEN.con_ViewGroupId, strComparisonOp);
}
else
{
objActionFormEN.dicFldComparisonOp[clsActionFormEN.con_ViewGroupId] = strComparisonOp;
}
}
return objActionFormEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objActionFormEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsActionFormEN SetActionFormTypeId(this clsActionFormEN objActionFormEN, string strActionFormTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strActionFormTypeId, clsActionFormEN.con_ActionFormTypeId);
clsCheckSql.CheckFieldLen(strActionFormTypeId, 2, clsActionFormEN.con_ActionFormTypeId);
clsCheckSql.CheckFieldForeignKey(strActionFormTypeId, 2, clsActionFormEN.con_ActionFormTypeId);
objActionFormEN.ActionFormTypeId = strActionFormTypeId; //ActionForm类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objActionFormEN.dicFldComparisonOp.ContainsKey(clsActionFormEN.con_ActionFormTypeId) == false)
{
objActionFormEN.dicFldComparisonOp.Add(clsActionFormEN.con_ActionFormTypeId, strComparisonOp);
}
else
{
objActionFormEN.dicFldComparisonOp[clsActionFormEN.con_ActionFormTypeId] = strComparisonOp;
}
}
return objActionFormEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objActionFormEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsActionFormEN SetUpdDate(this clsActionFormEN objActionFormEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, clsActionFormEN.con_UpdDate);
objActionFormEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objActionFormEN.dicFldComparisonOp.ContainsKey(clsActionFormEN.con_UpdDate) == false)
{
objActionFormEN.dicFldComparisonOp.Add(clsActionFormEN.con_UpdDate, strComparisonOp);
}
else
{
objActionFormEN.dicFldComparisonOp[clsActionFormEN.con_UpdDate] = strComparisonOp;
}
}
return objActionFormEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objActionFormEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsActionFormEN SetUserId(this clsActionFormEN objActionFormEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, clsActionFormEN.con_UserId);
clsCheckSql.CheckFieldLen(strUserId, 18, clsActionFormEN.con_UserId);
objActionFormEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objActionFormEN.dicFldComparisonOp.ContainsKey(clsActionFormEN.con_UserId) == false)
{
objActionFormEN.dicFldComparisonOp.Add(clsActionFormEN.con_UserId, strComparisonOp);
}
else
{
objActionFormEN.dicFldComparisonOp[clsActionFormEN.con_UserId] = strComparisonOp;
}
}
return objActionFormEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objActionFormEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsActionFormEN SetMemo(this clsActionFormEN objActionFormEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, clsActionFormEN.con_Memo);
objActionFormEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objActionFormEN.dicFldComparisonOp.ContainsKey(clsActionFormEN.con_Memo) == false)
{
objActionFormEN.dicFldComparisonOp.Add(clsActionFormEN.con_Memo, strComparisonOp);
}
else
{
objActionFormEN.dicFldComparisonOp[clsActionFormEN.con_Memo] = strComparisonOp;
}
}
return objActionFormEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsActionFormEN objActionForm_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objActionForm_Cond.IsUpdated(clsActionFormEN.con_ActionFormId) == true)
{
string strComparisonOp_ActionFormId = objActionForm_Cond.dicFldComparisonOp[clsActionFormEN.con_ActionFormId];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsActionFormEN.con_ActionFormId, objActionForm_Cond.ActionFormId, strComparisonOp_ActionFormId);
}
if (objActionForm_Cond.IsUpdated(clsActionFormEN.con_ActionFormName) == true)
{
string strComparisonOp_ActionFormName = objActionForm_Cond.dicFldComparisonOp[clsActionFormEN.con_ActionFormName];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsActionFormEN.con_ActionFormName, objActionForm_Cond.ActionFormName, strComparisonOp_ActionFormName);
}
if (objActionForm_Cond.IsUpdated(clsActionFormEN.con_ViewGroupId) == true)
{
string strComparisonOp_ViewGroupId = objActionForm_Cond.dicFldComparisonOp[clsActionFormEN.con_ViewGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsActionFormEN.con_ViewGroupId, objActionForm_Cond.ViewGroupId, strComparisonOp_ViewGroupId);
}
if (objActionForm_Cond.IsUpdated(clsActionFormEN.con_ActionFormTypeId) == true)
{
string strComparisonOp_ActionFormTypeId = objActionForm_Cond.dicFldComparisonOp[clsActionFormEN.con_ActionFormTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsActionFormEN.con_ActionFormTypeId, objActionForm_Cond.ActionFormTypeId, strComparisonOp_ActionFormTypeId);
}
if (objActionForm_Cond.IsUpdated(clsActionFormEN.con_UpdDate) == true)
{
string strComparisonOp_UpdDate = objActionForm_Cond.dicFldComparisonOp[clsActionFormEN.con_UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsActionFormEN.con_UpdDate, objActionForm_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objActionForm_Cond.IsUpdated(clsActionFormEN.con_UserId) == true)
{
string strComparisonOp_UserId = objActionForm_Cond.dicFldComparisonOp[clsActionFormEN.con_UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsActionFormEN.con_UserId, objActionForm_Cond.UserId, strComparisonOp_UserId);
}
if (objActionForm_Cond.IsUpdated(clsActionFormEN.con_Memo) == true)
{
string strComparisonOp_Memo = objActionForm_Cond.dicFldComparisonOp[clsActionFormEN.con_Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", clsActionFormEN.con_Memo, objActionForm_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objActionFormEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsActionFormEN objActionFormEN)
{
 if (string.IsNullOrEmpty(objActionFormEN.ActionFormId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objActionFormEN.sf_UpdFldSetStr = objActionFormEN.getsf_UpdFldSetStr();
clsActionFormWApi.CheckPropertyNew(objActionFormEN); 
bool bolResult = clsActionFormWApi.UpdateRecord(objActionFormEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionFormWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objActionFormEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsActionFormEN objActionFormEN)
{
 if (string.IsNullOrEmpty(objActionFormEN.ActionFormId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsActionFormWApi.IsExist(objActionFormEN.ActionFormId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objActionFormEN.ActionFormId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsActionFormWApi.CheckPropertyNew(objActionFormEN); 
bool bolResult = clsActionFormWApi.AddNewRecord(objActionFormEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionFormWApi.ReFreshCache();
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
 /// <param name = "objActionFormEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordWithMaxId(this clsActionFormEN objActionFormEN)
{
try
{
clsActionFormWApi.CheckPropertyNew(objActionFormEN); 
bool bolResult = clsActionFormWApi.AddNewRecordWithMaxId(objActionFormEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionFormWApi.ReFreshCache();
return bolResult;
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
 /// <param name = "objActionFormEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsActionFormEN objActionFormEN, string strWhereCond)
{
try
{
clsActionFormWApi.CheckPropertyNew(objActionFormEN); 
bool bolResult = clsActionFormWApi.UpdateWithCondition(objActionFormEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionFormWApi.ReFreshCache();
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
 /// ActionForm(ActionForm)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsActionFormWApi
{
private static readonly string mstrApiControllerName = "ActionFormApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsActionFormWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ActionFormId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[ActionForm]...","0");
List<clsActionFormEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ActionFormId";
objDDL.DataTextField="ActionFormName";
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
public static void BindCbo_ActionFormId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", clsActionFormEN.con_ActionFormId); 
List<clsActionFormEN> arrObjLst = clsActionFormWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsActionFormEN objActionFormEN = new clsActionFormEN()
{
ActionFormId = "0",
ActionFormName = "选[ActionForm]..."
};
arrObjLst.Insert(0, objActionFormEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = clsActionFormEN.con_ActionFormId;
objComboBox.DisplayMember = clsActionFormEN.con_ActionFormName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsActionFormEN objActionFormEN)
{
if (!Object.Equals(null, objActionFormEN.ActionFormId) && GetStrLen(objActionFormEN.ActionFormId) > 8)
{
 throw new Exception("字段[ActionFormId]的长度不能超过8!");
}
if (!Object.Equals(null, objActionFormEN.ActionFormName) && GetStrLen(objActionFormEN.ActionFormName) > 100)
{
 throw new Exception("字段[ActionForm名称]的长度不能超过100!");
}
if (!Object.Equals(null, objActionFormEN.ViewGroupId) && GetStrLen(objActionFormEN.ViewGroupId) > 8)
{
 throw new Exception("字段[界面组ID]的长度不能超过8!");
}
if (!Object.Equals(null, objActionFormEN.ActionFormTypeId) && GetStrLen(objActionFormEN.ActionFormTypeId) > 2)
{
 throw new Exception("字段[ActionForm类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objActionFormEN.UpdDate) && GetStrLen(objActionFormEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objActionFormEN.UserId) && GetStrLen(objActionFormEN.UserId) > 18)
{
 throw new Exception("字段[用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objActionFormEN.Memo) && GetStrLen(objActionFormEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objActionFormEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strActionFormId">表关键字</param>
 /// <returns>表对象</returns>
public static clsActionFormEN GetObjByActionFormId(string strActionFormId)
{
string strAction = "GetObjByActionFormId";
string strErrMsg = string.Empty;
string strResult = "";
clsActionFormEN objActionFormEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ActionFormId"] = strActionFormId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objActionFormEN = JsonConvert.DeserializeObject<clsActionFormEN>((string)jobjReturn["ReturnObj"]);
return objActionFormEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "strActionFormId">表关键字</param>
 /// <returns>表对象</returns>
public static clsActionFormEN GetObjByActionFormId_WA_Cache(string strActionFormId)
{
string strAction = "GetObjByActionFormId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsActionFormEN objActionFormEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ActionFormId"] = strActionFormId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objActionFormEN = JsonConvert.DeserializeObject<clsActionFormEN>((string)jobjReturn["ReturnObj"]);
return objActionFormEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static clsActionFormEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsActionFormEN objActionFormEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objActionFormEN = JsonConvert.DeserializeObject<clsActionFormEN>((string)jobjReturn["ReturnObj"]);
return objActionFormEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "strActionFormId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsActionFormEN GetObjByActionFormId_Cache(string strActionFormId)
{
if (string.IsNullOrEmpty(strActionFormId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsActionFormEN._CurrTabName_S);
List<clsActionFormEN> arrActionFormObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsActionFormEN> arrActionFormObjLst_Sel =
from objActionFormEN in arrActionFormObjLst_Cache
where objActionFormEN.ActionFormId == strActionFormId
select objActionFormEN;
if (arrActionFormObjLst_Sel.Count() == 0)
{
   clsActionFormEN obj = clsActionFormWApi.GetObjByActionFormId(strActionFormId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrActionFormObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strActionFormId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetActionFormNameByActionFormId_Cache(string strActionFormId)
{
if (string.IsNullOrEmpty(strActionFormId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsActionFormEN._CurrTabName_S);
List<clsActionFormEN> arrActionFormObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsActionFormEN> arrActionFormObjLst_Sel1 =
from objActionFormEN in arrActionFormObjLst_Cache
where objActionFormEN.ActionFormId == strActionFormId
select objActionFormEN;
List <clsActionFormEN> arrActionFormObjLst_Sel = new List<clsActionFormEN>();
foreach (clsActionFormEN obj in arrActionFormObjLst_Sel1)
{
arrActionFormObjLst_Sel.Add(obj);
}
if (arrActionFormObjLst_Sel.Count > 0)
{
return arrActionFormObjLst_Sel[0].ActionFormName;
}
string strErrMsgForGetObjById = string.Format("在ActionForm对象缓存列表中,找不到记录[ActionFormId = {0}](函数:{1})", strActionFormId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsActionFormBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strActionFormId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByActionFormId_Cache(string strActionFormId)
{
if (string.IsNullOrEmpty(strActionFormId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsActionFormEN._CurrTabName_S);
List<clsActionFormEN> arrActionFormObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsActionFormEN> arrActionFormObjLst_Sel1 =
from objActionFormEN in arrActionFormObjLst_Cache
where objActionFormEN.ActionFormId == strActionFormId
select objActionFormEN;
List <clsActionFormEN> arrActionFormObjLst_Sel = new List<clsActionFormEN>();
foreach (clsActionFormEN obj in arrActionFormObjLst_Sel1)
{
arrActionFormObjLst_Sel.Add(obj);
}
if (arrActionFormObjLst_Sel.Count > 0)
{
return arrActionFormObjLst_Sel[0].ActionFormName;
}
string strErrMsgForGetObjById = string.Format("在ActionForm对象缓存列表中,找不到记录的相关名称[ActionFormId = {0}](函数:{1})", strActionFormId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsActionFormBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsActionFormEN> GetObjLst(string strWhereCond)
{
 List<clsActionFormEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsActionFormEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsActionFormEN> GetObjLstByActionFormIdLst(List<string> arrActionFormId)
{
 List<clsActionFormEN> arrObjLst = null; 
string strAction = "GetObjLstByActionFormIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrActionFormId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsActionFormEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "strActionFormId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsActionFormEN> GetObjLstByActionFormIdLst_Cache(List<string> arrActionFormId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsActionFormEN._CurrTabName_S);
List<clsActionFormEN> arrActionFormObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsActionFormEN> arrActionFormObjLst_Sel =
from objActionFormEN in arrActionFormObjLst_Cache
where arrActionFormId.Contains(objActionFormEN.ActionFormId)
select objActionFormEN;
return arrActionFormObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsActionFormEN> GetObjLstByActionFormIdLst_WA_Cache(List<string> arrActionFormId)
{
 List<clsActionFormEN> arrObjLst = null; 
string strAction = "GetObjLstByActionFormIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrActionFormId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsActionFormEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsActionFormEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsActionFormEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsActionFormEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsActionFormEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsActionFormEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsActionFormEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsActionFormEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsActionFormEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsActionFormEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsActionFormEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsActionFormEN> arrObjLst = null; 
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
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsActionFormEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static int DelRecord(string strActionFormId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strActionFormId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsActionFormWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static int DelActionForms(List<string> arrActionFormId)
{
string strAction = "DelActionForms";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrActionFormId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsActionFormWApi.ReFreshCache();
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static int DelActionFormsByCond(string strWhereCond)
{
string strAction = "DelActionFormsByCond";
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
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static bool AddNewRecord(clsActionFormEN objActionFormEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsActionFormEN>(objActionFormEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionFormWApi.ReFreshCache();
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <returns>是否成功?</returns>
public static bool AddNewRecordWithMaxId(clsActionFormEN objActionFormEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsActionFormEN>(objActionFormEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsActionFormWApi.ReFreshCache();
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsActionFormEN objActionFormEN)
{
if (string.IsNullOrEmpty(objActionFormEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objActionFormEN.ActionFormId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsActionFormEN>(objActionFormEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "objActionFormEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsActionFormEN objActionFormEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objActionFormEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objActionFormEN.ActionFormId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objActionFormEN.ActionFormId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsActionFormEN>(objActionFormEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static bool IsExist(string strActionFormId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ActionFormId"] = strActionFormId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "objActionFormENS">源对象</param>
 /// <param name = "objActionFormENT">目标对象</param>
 public static void CopyTo(clsActionFormEN objActionFormENS, clsActionFormEN objActionFormENT)
{
try
{
objActionFormENT.ActionFormId = objActionFormENS.ActionFormId; //ActionFormId
objActionFormENT.ActionFormName = objActionFormENS.ActionFormName; //ActionForm名称
objActionFormENT.ViewGroupId = objActionFormENS.ViewGroupId; //界面组ID
objActionFormENT.ActionFormTypeId = objActionFormENS.ActionFormTypeId; //ActionForm类型ID
objActionFormENT.UpdDate = objActionFormENS.UpdDate; //修改日期
objActionFormENT.UserId = objActionFormENS.UserId; //用户Id
objActionFormENT.Memo = objActionFormENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsActionFormEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsActionFormEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsActionFormEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsActionFormEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsActionFormEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsActionFormEN.AttributeName)
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
if (clsActionFormWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsActionFormWApi没有刷新缓存机制(clsActionFormWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ActionFormId");
//if (arrActionFormObjLst_Cache == null)
//{
//arrActionFormObjLst_Cache = await clsActionFormWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsActionFormEN._CurrTabName_S);
CacheHelper.Remove(strKey);
strMsg = string.Format("刷新缓存成功！({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3)); 
clsSysParaEN.objLog.WriteDebugLog(strMsg);
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
if (clsActionFormWApi.objCommFun4BL != null) 
{
 string strMsg = string.Format("刷新缓存成功！({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3)); 
clsSysParaEN.objLog.WriteDebugLog(strMsg);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsActionFormEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsActionFormWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsActionFormEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsActionFormEN._CurrTabName_S);
List<clsActionFormEN> arrActionFormObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrActionFormObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsActionFormEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conActionForm.ActionFormId, Type.GetType("System.String"));
objDT.Columns.Add(conActionForm.ActionFormName, Type.GetType("System.String"));
objDT.Columns.Add(conActionForm.ViewGroupId, Type.GetType("System.String"));
objDT.Columns.Add(conActionForm.ActionFormTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conActionForm.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conActionForm.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conActionForm.Memo, Type.GetType("System.String"));
foreach (clsActionFormEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conActionForm.ActionFormId] = objInFor[conActionForm.ActionFormId];
objDR[conActionForm.ActionFormName] = objInFor[conActionForm.ActionFormName];
objDR[conActionForm.ViewGroupId] = objInFor[conActionForm.ViewGroupId];
objDR[conActionForm.ActionFormTypeId] = objInFor[conActionForm.ActionFormTypeId];
objDR[conActionForm.UpdDate] = objInFor[conActionForm.UpdDate];
objDR[conActionForm.UserId] = objInFor[conActionForm.UserId];
objDR[conActionForm.Memo] = objInFor[conActionForm.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}