
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionGroupWApi
 表名:FunctionGroup(00050325)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:40:10
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsFunctionGroupWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionGroupId">函数组Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionGroupEN SetFunctionGroupId(this clsFunctionGroupEN objFunctionGroupEN, string strFunctionGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionGroupId, 4, conFunctionGroup.FunctionGroupId);
clsCheckSql.CheckFieldForeignKey(strFunctionGroupId, 4, conFunctionGroup.FunctionGroupId);
objFunctionGroupEN.FunctionGroupId = strFunctionGroupId; //函数组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionGroupEN.dicFldComparisonOp.ContainsKey(conFunctionGroup.FunctionGroupId) == false)
{
objFunctionGroupEN.dicFldComparisonOp.Add(conFunctionGroup.FunctionGroupId, strComparisonOp);
}
else
{
objFunctionGroupEN.dicFldComparisonOp[conFunctionGroup.FunctionGroupId] = strComparisonOp;
}
}
return objFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strFunctionGroupName">函数组名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionGroupEN SetFunctionGroupName(this clsFunctionGroupEN objFunctionGroupEN, string strFunctionGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionGroupName, conFunctionGroup.FunctionGroupName);
clsCheckSql.CheckFieldLen(strFunctionGroupName, 50, conFunctionGroup.FunctionGroupName);
objFunctionGroupEN.FunctionGroupName = strFunctionGroupName; //函数组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionGroupEN.dicFldComparisonOp.ContainsKey(conFunctionGroup.FunctionGroupName) == false)
{
objFunctionGroupEN.dicFldComparisonOp.Add(conFunctionGroup.FunctionGroupName, strComparisonOp);
}
else
{
objFunctionGroupEN.dicFldComparisonOp[conFunctionGroup.FunctionGroupName] = strComparisonOp;
}
}
return objFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionGroupEN SetProgLangTypeId(this clsFunctionGroupEN objFunctionGroupEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, conFunctionGroup.ProgLangTypeId);
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, conFunctionGroup.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, conFunctionGroup.ProgLangTypeId);
objFunctionGroupEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionGroupEN.dicFldComparisonOp.ContainsKey(conFunctionGroup.ProgLangTypeId) == false)
{
objFunctionGroupEN.dicFldComparisonOp.Add(conFunctionGroup.ProgLangTypeId, strComparisonOp);
}
else
{
objFunctionGroupEN.dicFldComparisonOp[conFunctionGroup.ProgLangTypeId] = strComparisonOp;
}
}
return objFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strCreateUserId">建立用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionGroupEN SetCreateUserId(this clsFunctionGroupEN objFunctionGroupEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, conFunctionGroup.CreateUserId);
clsCheckSql.CheckFieldLen(strCreateUserId, 18, conFunctionGroup.CreateUserId);
objFunctionGroupEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionGroupEN.dicFldComparisonOp.ContainsKey(conFunctionGroup.CreateUserId) == false)
{
objFunctionGroupEN.dicFldComparisonOp.Add(conFunctionGroup.CreateUserId, strComparisonOp);
}
else
{
objFunctionGroupEN.dicFldComparisonOp[conFunctionGroup.CreateUserId] = strComparisonOp;
}
}
return objFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionGroupEN SetUpdDate(this clsFunctionGroupEN objFunctionGroupEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFunctionGroup.UpdDate);
objFunctionGroupEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionGroupEN.dicFldComparisonOp.ContainsKey(conFunctionGroup.UpdDate) == false)
{
objFunctionGroupEN.dicFldComparisonOp.Add(conFunctionGroup.UpdDate, strComparisonOp);
}
else
{
objFunctionGroupEN.dicFldComparisonOp[conFunctionGroup.UpdDate] = strComparisonOp;
}
}
return objFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionGroupEN SetUpdUser(this clsFunctionGroupEN objFunctionGroupEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFunctionGroup.UpdUser);
objFunctionGroupEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionGroupEN.dicFldComparisonOp.ContainsKey(conFunctionGroup.UpdUser) == false)
{
objFunctionGroupEN.dicFldComparisonOp.Add(conFunctionGroup.UpdUser, strComparisonOp);
}
else
{
objFunctionGroupEN.dicFldComparisonOp[conFunctionGroup.UpdUser] = strComparisonOp;
}
}
return objFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionGroupEN SetMemo(this clsFunctionGroupEN objFunctionGroupEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFunctionGroup.Memo);
objFunctionGroupEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionGroupEN.dicFldComparisonOp.ContainsKey(conFunctionGroup.Memo) == false)
{
objFunctionGroupEN.dicFldComparisonOp.Add(conFunctionGroup.Memo, strComparisonOp);
}
else
{
objFunctionGroupEN.dicFldComparisonOp[conFunctionGroup.Memo] = strComparisonOp;
}
}
return objFunctionGroupEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFunctionGroupEN objFunctionGroupCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFunctionGroupCond.IsUpdated(conFunctionGroup.FunctionGroupId) == true)
{
string strComparisonOpFunctionGroupId = objFunctionGroupCond.dicFldComparisonOp[conFunctionGroup.FunctionGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionGroup.FunctionGroupId, objFunctionGroupCond.FunctionGroupId, strComparisonOpFunctionGroupId);
}
if (objFunctionGroupCond.IsUpdated(conFunctionGroup.FunctionGroupName) == true)
{
string strComparisonOpFunctionGroupName = objFunctionGroupCond.dicFldComparisonOp[conFunctionGroup.FunctionGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionGroup.FunctionGroupName, objFunctionGroupCond.FunctionGroupName, strComparisonOpFunctionGroupName);
}
if (objFunctionGroupCond.IsUpdated(conFunctionGroup.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objFunctionGroupCond.dicFldComparisonOp[conFunctionGroup.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionGroup.ProgLangTypeId, objFunctionGroupCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objFunctionGroupCond.IsUpdated(conFunctionGroup.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objFunctionGroupCond.dicFldComparisonOp[conFunctionGroup.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionGroup.CreateUserId, objFunctionGroupCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objFunctionGroupCond.IsUpdated(conFunctionGroup.UpdDate) == true)
{
string strComparisonOpUpdDate = objFunctionGroupCond.dicFldComparisonOp[conFunctionGroup.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionGroup.UpdDate, objFunctionGroupCond.UpdDate, strComparisonOpUpdDate);
}
if (objFunctionGroupCond.IsUpdated(conFunctionGroup.UpdUser) == true)
{
string strComparisonOpUpdUser = objFunctionGroupCond.dicFldComparisonOp[conFunctionGroup.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionGroup.UpdUser, objFunctionGroupCond.UpdUser, strComparisonOpUpdUser);
}
if (objFunctionGroupCond.IsUpdated(conFunctionGroup.Memo) == true)
{
string strComparisonOpMemo = objFunctionGroupCond.dicFldComparisonOp[conFunctionGroup.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionGroup.Memo, objFunctionGroupCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFunctionGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionGroupEN objFunctionGroupEN)
{
 if (string.IsNullOrEmpty(objFunctionGroupEN.FunctionGroupId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFunctionGroupEN.sfUpdFldSetStr = objFunctionGroupEN.getsfUpdFldSetStr();
clsFunctionGroupWApi.CheckPropertyNew(objFunctionGroupEN); 
bool bolResult = clsFunctionGroupWApi.UpdateRecord(objFunctionGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupWApi.ReFreshCache();
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
 /// 获取唯一性条件串--FunctionGroup(功能函数组), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FunctionGroupName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFunctionGroupEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsFunctionGroupEN objFunctionGroupEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFunctionGroupEN == null) return "";
if (objFunctionGroupEN.FunctionGroupId == null || objFunctionGroupEN.FunctionGroupId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FunctionGroupName = '{0}'", objFunctionGroupEN.FunctionGroupName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FunctionGroupId !=  '{0}'", objFunctionGroupEN.FunctionGroupId);
 sbCondition.AppendFormat(" and FunctionGroupName = '{0}'", objFunctionGroupEN.FunctionGroupName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFunctionGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFunctionGroupEN objFunctionGroupEN)
{
try
{
 if (string.IsNullOrEmpty(objFunctionGroupEN.FunctionGroupId) == true || clsFunctionGroupWApi.IsExist(objFunctionGroupEN.FunctionGroupId) == true)
 {
     objFunctionGroupEN.FunctionGroupId = clsFunctionGroupWApi.GetMaxStrId();
 }
clsFunctionGroupWApi.CheckPropertyNew(objFunctionGroupEN); 
bool bolResult = clsFunctionGroupWApi.AddNewRecord(objFunctionGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupWApi.ReFreshCache();
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
 /// <param name = "objFunctionGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFunctionGroupEN objFunctionGroupEN)
{
try
{
clsFunctionGroupWApi.CheckPropertyNew(objFunctionGroupEN); 
string strFunctionGroupId = clsFunctionGroupWApi.AddNewRecordWithMaxId(objFunctionGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupWApi.ReFreshCache();
return strFunctionGroupId;
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
 /// <param name = "objFunctionGroupEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionGroupEN objFunctionGroupEN, string strWhereCond)
{
try
{
clsFunctionGroupWApi.CheckPropertyNew(objFunctionGroupEN); 
bool bolResult = clsFunctionGroupWApi.UpdateWithCondition(objFunctionGroupEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupWApi.ReFreshCache();
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
 /// 功能函数组(FunctionGroup)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFunctionGroupWApi
{
private static readonly string mstrApiControllerName = "FunctionGroupApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsFunctionGroupWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FunctionGroupId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[功能函数组]...","0");
List<clsFunctionGroupEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FunctionGroupId";
objDDL.DataTextField="FunctionGroupName";
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

public static void BindCbo_FunctionGroupId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFunctionGroup.FunctionGroupId); 
List<clsFunctionGroupEN> arrObjLst = clsFunctionGroupWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFunctionGroupEN objFunctionGroupEN = new clsFunctionGroupEN()
{
FunctionGroupId = "0",
FunctionGroupName = "选[功能函数组]..."
};
arrObjLst.Insert(0, objFunctionGroupEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFunctionGroup.FunctionGroupId;
objComboBox.DisplayMember = conFunctionGroup.FunctionGroupName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFunctionGroupEN objFunctionGroupEN)
{
if (!Object.Equals(null, objFunctionGroupEN.FunctionGroupId) && GetStrLen(objFunctionGroupEN.FunctionGroupId) > 4)
{
 throw new Exception("字段[函数组Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFunctionGroupEN.FunctionGroupName) && GetStrLen(objFunctionGroupEN.FunctionGroupName) > 50)
{
 throw new Exception("字段[函数组名称]的长度不能超过50!");
}
if (!Object.Equals(null, objFunctionGroupEN.ProgLangTypeId) && GetStrLen(objFunctionGroupEN.ProgLangTypeId) > 2)
{
 throw new Exception("字段[编程语言类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFunctionGroupEN.CreateUserId) && GetStrLen(objFunctionGroupEN.CreateUserId) > 18)
{
 throw new Exception("字段[建立用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objFunctionGroupEN.UpdDate) && GetStrLen(objFunctionGroupEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFunctionGroupEN.UpdUser) && GetStrLen(objFunctionGroupEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objFunctionGroupEN.Memo) && GetStrLen(objFunctionGroupEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objFunctionGroupEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFunctionGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionGroupEN GetObjByFunctionGroupId(string strFunctionGroupId)
{
if (strFunctionGroupId == "") return null;
string strAction = "GetObjByFunctionGroupId";
clsFunctionGroupEN objFunctionGroupEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFunctionGroupId"] = strFunctionGroupId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objFunctionGroupEN = JsonConvert.DeserializeObject<clsFunctionGroupEN>(strJson);
return objFunctionGroupEN;
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
public static clsFunctionGroupEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsFunctionGroupEN objFunctionGroupEN;
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
objFunctionGroupEN = JsonConvert.DeserializeObject<clsFunctionGroupEN>(strJson);
return objFunctionGroupEN;
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
 /// <param name = "strFunctionGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionGroupEN GetObjByFunctionGroupIdCache(string strFunctionGroupId)
{
if (string.IsNullOrEmpty(strFunctionGroupId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsFunctionGroupEN._CurrTabName);
List<clsFunctionGroupEN> arrFunctionGroupObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionGroupEN> arrFunctionGroupObjLst_Sel =
from objFunctionGroupEN in arrFunctionGroupObjLstCache
where objFunctionGroupEN.FunctionGroupId == strFunctionGroupId 
select objFunctionGroupEN;
if (arrFunctionGroupObjLst_Sel.Count() == 0)
{
   clsFunctionGroupEN obj = clsFunctionGroupWApi.GetObjByFunctionGroupId(strFunctionGroupId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFunctionGroupObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFunctionGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFunctionGroupNameByFunctionGroupIdCache(string strFunctionGroupId)
{
if (string.IsNullOrEmpty(strFunctionGroupId) == true) return "";
//初始化列表缓存
List<clsFunctionGroupEN> arrFunctionGroupObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionGroupEN> arrFunctionGroupObjLst_Sel1 =
from objFunctionGroupEN in arrFunctionGroupObjLstCache
where objFunctionGroupEN.FunctionGroupId == strFunctionGroupId 
select objFunctionGroupEN;
List <clsFunctionGroupEN> arrFunctionGroupObjLst_Sel = new List<clsFunctionGroupEN>();
foreach (clsFunctionGroupEN obj in arrFunctionGroupObjLst_Sel1)
{
arrFunctionGroupObjLst_Sel.Add(obj);
}
if (arrFunctionGroupObjLst_Sel.Count > 0)
{
return arrFunctionGroupObjLst_Sel[0].FunctionGroupName;
}
string strErrMsgForGetObjById = string.Format("在FunctionGroup对象缓存列表中,找不到记录[FunctionGroupId = {0}](函数:{1})", strFunctionGroupId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFunctionGroupBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFunctionGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFunctionGroupIdCache(string strFunctionGroupId)
{
if (string.IsNullOrEmpty(strFunctionGroupId) == true) return "";
//初始化列表缓存
List<clsFunctionGroupEN> arrFunctionGroupObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionGroupEN> arrFunctionGroupObjLst_Sel1 =
from objFunctionGroupEN in arrFunctionGroupObjLstCache
where objFunctionGroupEN.FunctionGroupId == strFunctionGroupId 
select objFunctionGroupEN;
List <clsFunctionGroupEN> arrFunctionGroupObjLst_Sel = new List<clsFunctionGroupEN>();
foreach (clsFunctionGroupEN obj in arrFunctionGroupObjLst_Sel1)
{
arrFunctionGroupObjLst_Sel.Add(obj);
}
if (arrFunctionGroupObjLst_Sel.Count > 0)
{
return arrFunctionGroupObjLst_Sel[0].FunctionGroupName;
}
string strErrMsgForGetObjById = string.Format("在FunctionGroup对象缓存列表中,找不到记录的相关名称[FunctionGroupId = {0}](函数:{1})", strFunctionGroupId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFunctionGroupBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionGroupEN> GetObjLst(string strWhereCond)
{
 List<clsFunctionGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionGroupEN>>(strJson);
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
 /// <param name = "arrFunctionGroupId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionGroupEN> GetObjLstByFunctionGroupIdLst(List<string> arrFunctionGroupId)
{
 List<clsFunctionGroupEN> arrObjLst; 
string strAction = "GetObjLstByFunctionGroupIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFunctionGroupId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionGroupEN>>(strJson);
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
 /// <param name = "arrFunctionGroupId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsFunctionGroupEN> GetObjLstByFunctionGroupIdLstCache(List<string> arrFunctionGroupId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFunctionGroupEN._CurrTabName);
List<clsFunctionGroupEN> arrFunctionGroupObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionGroupEN> arrFunctionGroupObjLst_Sel =
from objFunctionGroupEN in arrFunctionGroupObjLstCache
where arrFunctionGroupId.Contains(objFunctionGroupEN.FunctionGroupId)
select objFunctionGroupEN;
return arrFunctionGroupObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionGroupEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFunctionGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionGroupEN>>(strJson);
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
public static List<clsFunctionGroupEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFunctionGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionGroupEN>>(strJson);
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
public static List<clsFunctionGroupEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFunctionGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionGroupEN>>(strJson);
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
public static List<clsFunctionGroupEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsFunctionGroupEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionGroupEN>>(strJson);
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
public static int DelRecord(string strFunctionGroupId)
{
string strAction = "DelRecord";
try
{
 clsFunctionGroupEN objFunctionGroupEN = clsFunctionGroupWApi.GetObjByFunctionGroupId(strFunctionGroupId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFunctionGroupId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFunctionGroupWApi.ReFreshCache();
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
public static int DelFunctionGroups(List<string> arrFunctionGroupId)
{
string strAction = "DelFunctionGroups";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFunctionGroupId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFunctionGroupWApi.ReFreshCache();
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
public static int DelFunctionGroupsByCond(string strWhereCond)
{
string strAction = "DelFunctionGroupsByCond";
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
public static bool AddNewRecord(clsFunctionGroupEN objFunctionGroupEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionGroupEN>(objFunctionGroupEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsFunctionGroupEN objFunctionGroupEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionGroupEN>(objFunctionGroupEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionGroupWApi.ReFreshCache();
var strFunctionGroupId = (string)jobjReturn0["returnStr"];
return strFunctionGroupId;
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
public static bool UpdateRecord(clsFunctionGroupEN objFunctionGroupEN)
{
if (string.IsNullOrEmpty(objFunctionGroupEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFunctionGroupEN.FunctionGroupId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionGroupEN>(objFunctionGroupEN);
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
 /// <param name = "objFunctionGroupEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFunctionGroupEN objFunctionGroupEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFunctionGroupEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFunctionGroupEN.FunctionGroupId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFunctionGroupEN.FunctionGroupId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionGroupEN>(objFunctionGroupEN);
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
public static bool IsExist(string strFunctionGroupId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFunctionGroupId"] = strFunctionGroupId
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
 /// <param name = "objFunctionGroupENS">源对象</param>
 /// <param name = "objFunctionGroupENT">目标对象</param>
 public static void CopyTo(clsFunctionGroupEN objFunctionGroupENS, clsFunctionGroupEN objFunctionGroupENT)
{
try
{
objFunctionGroupENT.FunctionGroupId = objFunctionGroupENS.FunctionGroupId; //函数组Id
objFunctionGroupENT.FunctionGroupName = objFunctionGroupENS.FunctionGroupName; //函数组名称
objFunctionGroupENT.ProgLangTypeId = objFunctionGroupENS.ProgLangTypeId; //编程语言类型Id
objFunctionGroupENT.CreateUserId = objFunctionGroupENS.CreateUserId; //建立用户Id
objFunctionGroupENT.UpdDate = objFunctionGroupENS.UpdDate; //修改日期
objFunctionGroupENT.UpdUser = objFunctionGroupENS.UpdUser; //修改者
objFunctionGroupENT.Memo = objFunctionGroupENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsFunctionGroupEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFunctionGroupEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFunctionGroupEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFunctionGroupEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFunctionGroupEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFunctionGroupEN._AttributeName)
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
public static void ReFreshThisCache()
{

string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsFunctionGroupEN._CurrTabName);
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
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsFunctionGroupWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFunctionGroupEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunctionGroupWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionGroupEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsFunctionGroupEN._CurrTabName;
List<clsFunctionGroupEN> arrFunctionGroupObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrFunctionGroupObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFunctionGroupEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFunctionGroup.FunctionGroupId, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionGroup.FunctionGroupName, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionGroup.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionGroup.CreateUserId, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionGroup.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionGroup.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionGroup.Memo, Type.GetType("System.String"));
foreach (clsFunctionGroupEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFunctionGroup.FunctionGroupId] = objInFor[conFunctionGroup.FunctionGroupId];
objDR[conFunctionGroup.FunctionGroupName] = objInFor[conFunctionGroup.FunctionGroupName];
objDR[conFunctionGroup.ProgLangTypeId] = objInFor[conFunctionGroup.ProgLangTypeId];
objDR[conFunctionGroup.CreateUserId] = objInFor[conFunctionGroup.CreateUserId];
objDR[conFunctionGroup.UpdDate] = objInFor[conFunctionGroup.UpdDate];
objDR[conFunctionGroup.UpdUser] = objInFor[conFunctionGroup.UpdUser];
objDR[conFunctionGroup.Memo] = objInFor[conFunctionGroup.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 功能函数组(FunctionGroup)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4FunctionGroup : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
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
clsFunctionGroupWApi.ReFreshThisCache();
}
}

}