
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncAccessModeWApi
 表名:FuncAccessMode(00050497)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:50:44
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
public static class  clsFuncAccessModeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncAccessModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncAccessModeId">函数操作模式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncAccessModeEN SetFuncAccessModeId(this clsFuncAccessModeEN objFuncAccessModeEN, string strFuncAccessModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncAccessModeId, 2, conFuncAccessMode.FuncAccessModeId);
clsCheckSql.CheckFieldForeignKey(strFuncAccessModeId, 2, conFuncAccessMode.FuncAccessModeId);
objFuncAccessModeEN.FuncAccessModeId = strFuncAccessModeId; //函数操作模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncAccessModeEN.dicFldComparisonOp.ContainsKey(conFuncAccessMode.FuncAccessModeId) == false)
{
objFuncAccessModeEN.dicFldComparisonOp.Add(conFuncAccessMode.FuncAccessModeId, strComparisonOp);
}
else
{
objFuncAccessModeEN.dicFldComparisonOp[conFuncAccessMode.FuncAccessModeId] = strComparisonOp;
}
}
return objFuncAccessModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncAccessModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncAccessModeName">函数操作模式名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncAccessModeEN SetFuncAccessModeName(this clsFuncAccessModeEN objFuncAccessModeEN, string strFuncAccessModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncAccessModeName, conFuncAccessMode.FuncAccessModeName);
clsCheckSql.CheckFieldLen(strFuncAccessModeName, 50, conFuncAccessMode.FuncAccessModeName);
objFuncAccessModeEN.FuncAccessModeName = strFuncAccessModeName; //函数操作模式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncAccessModeEN.dicFldComparisonOp.ContainsKey(conFuncAccessMode.FuncAccessModeName) == false)
{
objFuncAccessModeEN.dicFldComparisonOp.Add(conFuncAccessMode.FuncAccessModeName, strComparisonOp);
}
else
{
objFuncAccessModeEN.dicFldComparisonOp[conFuncAccessMode.FuncAccessModeName] = strComparisonOp;
}
}
return objFuncAccessModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncAccessModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFuncAccessModeENName">函数操作模式英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncAccessModeEN SetFuncAccessModeENName(this clsFuncAccessModeEN objFuncAccessModeEN, string strFuncAccessModeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncAccessModeENName, conFuncAccessMode.FuncAccessModeENName);
clsCheckSql.CheckFieldLen(strFuncAccessModeENName, 50, conFuncAccessMode.FuncAccessModeENName);
objFuncAccessModeEN.FuncAccessModeENName = strFuncAccessModeENName; //函数操作模式英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncAccessModeEN.dicFldComparisonOp.ContainsKey(conFuncAccessMode.FuncAccessModeENName) == false)
{
objFuncAccessModeEN.dicFldComparisonOp.Add(conFuncAccessMode.FuncAccessModeENName, strComparisonOp);
}
else
{
objFuncAccessModeEN.dicFldComparisonOp[conFuncAccessMode.FuncAccessModeENName] = strComparisonOp;
}
}
return objFuncAccessModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncAccessModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncAccessModeEN SetUpdDate(this clsFuncAccessModeEN objFuncAccessModeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFuncAccessMode.UpdDate);
objFuncAccessModeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncAccessModeEN.dicFldComparisonOp.ContainsKey(conFuncAccessMode.UpdDate) == false)
{
objFuncAccessModeEN.dicFldComparisonOp.Add(conFuncAccessMode.UpdDate, strComparisonOp);
}
else
{
objFuncAccessModeEN.dicFldComparisonOp[conFuncAccessMode.UpdDate] = strComparisonOp;
}
}
return objFuncAccessModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncAccessModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncAccessModeEN SetUpdUser(this clsFuncAccessModeEN objFuncAccessModeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFuncAccessMode.UpdUser);
objFuncAccessModeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncAccessModeEN.dicFldComparisonOp.ContainsKey(conFuncAccessMode.UpdUser) == false)
{
objFuncAccessModeEN.dicFldComparisonOp.Add(conFuncAccessMode.UpdUser, strComparisonOp);
}
else
{
objFuncAccessModeEN.dicFldComparisonOp[conFuncAccessMode.UpdUser] = strComparisonOp;
}
}
return objFuncAccessModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFuncAccessModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFuncAccessModeEN SetMemo(this clsFuncAccessModeEN objFuncAccessModeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFuncAccessMode.Memo);
objFuncAccessModeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFuncAccessModeEN.dicFldComparisonOp.ContainsKey(conFuncAccessMode.Memo) == false)
{
objFuncAccessModeEN.dicFldComparisonOp.Add(conFuncAccessMode.Memo, strComparisonOp);
}
else
{
objFuncAccessModeEN.dicFldComparisonOp[conFuncAccessMode.Memo] = strComparisonOp;
}
}
return objFuncAccessModeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFuncAccessModeEN objFuncAccessModeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFuncAccessModeCond.IsUpdated(conFuncAccessMode.FuncAccessModeId) == true)
{
string strComparisonOpFuncAccessModeId = objFuncAccessModeCond.dicFldComparisonOp[conFuncAccessMode.FuncAccessModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncAccessMode.FuncAccessModeId, objFuncAccessModeCond.FuncAccessModeId, strComparisonOpFuncAccessModeId);
}
if (objFuncAccessModeCond.IsUpdated(conFuncAccessMode.FuncAccessModeName) == true)
{
string strComparisonOpFuncAccessModeName = objFuncAccessModeCond.dicFldComparisonOp[conFuncAccessMode.FuncAccessModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncAccessMode.FuncAccessModeName, objFuncAccessModeCond.FuncAccessModeName, strComparisonOpFuncAccessModeName);
}
if (objFuncAccessModeCond.IsUpdated(conFuncAccessMode.FuncAccessModeENName) == true)
{
string strComparisonOpFuncAccessModeENName = objFuncAccessModeCond.dicFldComparisonOp[conFuncAccessMode.FuncAccessModeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncAccessMode.FuncAccessModeENName, objFuncAccessModeCond.FuncAccessModeENName, strComparisonOpFuncAccessModeENName);
}
if (objFuncAccessModeCond.IsUpdated(conFuncAccessMode.UpdDate) == true)
{
string strComparisonOpUpdDate = objFuncAccessModeCond.dicFldComparisonOp[conFuncAccessMode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncAccessMode.UpdDate, objFuncAccessModeCond.UpdDate, strComparisonOpUpdDate);
}
if (objFuncAccessModeCond.IsUpdated(conFuncAccessMode.UpdUser) == true)
{
string strComparisonOpUpdUser = objFuncAccessModeCond.dicFldComparisonOp[conFuncAccessMode.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncAccessMode.UpdUser, objFuncAccessModeCond.UpdUser, strComparisonOpUpdUser);
}
if (objFuncAccessModeCond.IsUpdated(conFuncAccessMode.Memo) == true)
{
string strComparisonOpMemo = objFuncAccessModeCond.dicFldComparisonOp[conFuncAccessMode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFuncAccessMode.Memo, objFuncAccessModeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFuncAccessModeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFuncAccessModeEN objFuncAccessModeEN)
{
 if (string.IsNullOrEmpty(objFuncAccessModeEN.FuncAccessModeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFuncAccessModeEN.sfUpdFldSetStr = objFuncAccessModeEN.getsfUpdFldSetStr();
clsFuncAccessModeWApi.CheckPropertyNew(objFuncAccessModeEN); 
bool bolResult = clsFuncAccessModeWApi.UpdateRecord(objFuncAccessModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncAccessModeWApi.ReFreshCache();
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
 /// 获取唯一性条件串--FuncAccessMode(函数操作模式), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FuncAccessModeName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFuncAccessModeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsFuncAccessModeEN objFuncAccessModeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFuncAccessModeEN == null) return "";
if (objFuncAccessModeEN.FuncAccessModeId == null || objFuncAccessModeEN.FuncAccessModeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncAccessModeName = '{0}'", objFuncAccessModeEN.FuncAccessModeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FuncAccessModeId !=  '{0}'", objFuncAccessModeEN.FuncAccessModeId);
 sbCondition.AppendFormat(" and FuncAccessModeName = '{0}'", objFuncAccessModeEN.FuncAccessModeName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFuncAccessModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFuncAccessModeEN objFuncAccessModeEN)
{
try
{
 if (string.IsNullOrEmpty(objFuncAccessModeEN.FuncAccessModeId) == true || clsFuncAccessModeWApi.IsExist(objFuncAccessModeEN.FuncAccessModeId) == true)
 {
     objFuncAccessModeEN.FuncAccessModeId = clsFuncAccessModeWApi.GetMaxStrId();
 }
clsFuncAccessModeWApi.CheckPropertyNew(objFuncAccessModeEN); 
bool bolResult = clsFuncAccessModeWApi.AddNewRecord(objFuncAccessModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncAccessModeWApi.ReFreshCache();
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
 /// <param name = "objFuncAccessModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFuncAccessModeEN objFuncAccessModeEN)
{
try
{
clsFuncAccessModeWApi.CheckPropertyNew(objFuncAccessModeEN); 
string strFuncAccessModeId = clsFuncAccessModeWApi.AddNewRecordWithMaxId(objFuncAccessModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncAccessModeWApi.ReFreshCache();
return strFuncAccessModeId;
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
 /// <param name = "objFuncAccessModeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFuncAccessModeEN objFuncAccessModeEN, string strWhereCond)
{
try
{
clsFuncAccessModeWApi.CheckPropertyNew(objFuncAccessModeEN); 
bool bolResult = clsFuncAccessModeWApi.UpdateWithCondition(objFuncAccessModeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncAccessModeWApi.ReFreshCache();
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public class enumFuncAccessModeWA
{
 /// <summary>
 /// Get
 /// </summary>
public const string Get_01 = "01";
 /// <summary>
 /// Post
 /// </summary>
public const string Post_02 = "02";
 /// <summary>
 /// Put
 /// </summary>
public const string Put_03 = "03";
 /// <summary>
 /// Delete
 /// </summary>
public const string Delete_04 = "04";
}
 /// <summary>
 /// 函数操作模式(FuncAccessMode)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFuncAccessModeWApi
{
private static readonly string mstrApiControllerName = "FuncAccessModeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsFuncAccessModeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FuncAccessModeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数操作模式]...","0");
List<clsFuncAccessModeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FuncAccessModeId";
objDDL.DataTextField="FuncAccessModeName";
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

public static void BindCbo_FuncAccessModeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFuncAccessMode.FuncAccessModeId); 
List<clsFuncAccessModeEN> arrObjLst = clsFuncAccessModeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFuncAccessModeEN objFuncAccessModeEN = new clsFuncAccessModeEN()
{
FuncAccessModeId = "0",
FuncAccessModeName = "选[函数操作模式]..."
};
arrObjLst.Insert(0, objFuncAccessModeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFuncAccessMode.FuncAccessModeId;
objComboBox.DisplayMember = conFuncAccessMode.FuncAccessModeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFuncAccessModeEN objFuncAccessModeEN)
{
if (!Object.Equals(null, objFuncAccessModeEN.FuncAccessModeId) && GetStrLen(objFuncAccessModeEN.FuncAccessModeId) > 2)
{
 throw new Exception("字段[函数操作模式Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFuncAccessModeEN.FuncAccessModeName) && GetStrLen(objFuncAccessModeEN.FuncAccessModeName) > 50)
{
 throw new Exception("字段[函数操作模式名]的长度不能超过50!");
}
if (!Object.Equals(null, objFuncAccessModeEN.FuncAccessModeENName) && GetStrLen(objFuncAccessModeEN.FuncAccessModeENName) > 50)
{
 throw new Exception("字段[函数操作模式英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objFuncAccessModeEN.UpdDate) && GetStrLen(objFuncAccessModeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFuncAccessModeEN.UpdUser) && GetStrLen(objFuncAccessModeEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objFuncAccessModeEN.Memo) && GetStrLen(objFuncAccessModeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objFuncAccessModeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncAccessModeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFuncAccessModeEN GetObjByFuncAccessModeId(string strFuncAccessModeId)
{
if (strFuncAccessModeId == "") return null;
string strAction = "GetObjByFuncAccessModeId";
clsFuncAccessModeEN objFuncAccessModeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncAccessModeId"] = strFuncAccessModeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objFuncAccessModeEN = JsonConvert.DeserializeObject<clsFuncAccessModeEN>(strJson);
return objFuncAccessModeEN;
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
public static clsFuncAccessModeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsFuncAccessModeEN objFuncAccessModeEN;
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
objFuncAccessModeEN = JsonConvert.DeserializeObject<clsFuncAccessModeEN>(strJson);
return objFuncAccessModeEN;
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
 /// <param name = "strFuncAccessModeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFuncAccessModeEN GetObjByFuncAccessModeIdCache(string strFuncAccessModeId)
{
if (string.IsNullOrEmpty(strFuncAccessModeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsFuncAccessModeEN._CurrTabName);
List<clsFuncAccessModeEN> arrFuncAccessModeObjLstCache = GetObjLstCache();
IEnumerable <clsFuncAccessModeEN> arrFuncAccessModeObjLst_Sel =
from objFuncAccessModeEN in arrFuncAccessModeObjLstCache
where objFuncAccessModeEN.FuncAccessModeId == strFuncAccessModeId 
select objFuncAccessModeEN;
if (arrFuncAccessModeObjLst_Sel.Count() == 0)
{
   clsFuncAccessModeEN obj = clsFuncAccessModeWApi.GetObjByFuncAccessModeId(strFuncAccessModeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFuncAccessModeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncAccessModeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFuncAccessModeNameByFuncAccessModeIdCache(string strFuncAccessModeId)
{
if (string.IsNullOrEmpty(strFuncAccessModeId) == true) return "";
//初始化列表缓存
List<clsFuncAccessModeEN> arrFuncAccessModeObjLstCache = GetObjLstCache();
IEnumerable <clsFuncAccessModeEN> arrFuncAccessModeObjLst_Sel1 =
from objFuncAccessModeEN in arrFuncAccessModeObjLstCache
where objFuncAccessModeEN.FuncAccessModeId == strFuncAccessModeId 
select objFuncAccessModeEN;
List <clsFuncAccessModeEN> arrFuncAccessModeObjLst_Sel = new List<clsFuncAccessModeEN>();
foreach (clsFuncAccessModeEN obj in arrFuncAccessModeObjLst_Sel1)
{
arrFuncAccessModeObjLst_Sel.Add(obj);
}
if (arrFuncAccessModeObjLst_Sel.Count > 0)
{
return arrFuncAccessModeObjLst_Sel[0].FuncAccessModeName;
}
string strErrMsgForGetObjById = string.Format("在FuncAccessMode对象缓存列表中,找不到记录[FuncAccessModeId = {0}](函数:{1})", strFuncAccessModeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFuncAccessModeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFuncAccessModeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFuncAccessModeIdCache(string strFuncAccessModeId)
{
if (string.IsNullOrEmpty(strFuncAccessModeId) == true) return "";
//初始化列表缓存
List<clsFuncAccessModeEN> arrFuncAccessModeObjLstCache = GetObjLstCache();
IEnumerable <clsFuncAccessModeEN> arrFuncAccessModeObjLst_Sel1 =
from objFuncAccessModeEN in arrFuncAccessModeObjLstCache
where objFuncAccessModeEN.FuncAccessModeId == strFuncAccessModeId 
select objFuncAccessModeEN;
List <clsFuncAccessModeEN> arrFuncAccessModeObjLst_Sel = new List<clsFuncAccessModeEN>();
foreach (clsFuncAccessModeEN obj in arrFuncAccessModeObjLst_Sel1)
{
arrFuncAccessModeObjLst_Sel.Add(obj);
}
if (arrFuncAccessModeObjLst_Sel.Count > 0)
{
return arrFuncAccessModeObjLst_Sel[0].FuncAccessModeName;
}
string strErrMsgForGetObjById = string.Format("在FuncAccessMode对象缓存列表中,找不到记录的相关名称[FuncAccessModeId = {0}](函数:{1})", strFuncAccessModeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFuncAccessModeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncAccessModeEN> GetObjLst(string strWhereCond)
{
 List<clsFuncAccessModeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncAccessModeEN>>(strJson);
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
 /// <param name = "arrFuncAccessModeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncAccessModeEN> GetObjLstByFuncAccessModeIdLst(List<string> arrFuncAccessModeId)
{
 List<clsFuncAccessModeEN> arrObjLst; 
string strAction = "GetObjLstByFuncAccessModeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncAccessModeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncAccessModeEN>>(strJson);
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
 /// <param name = "arrFuncAccessModeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsFuncAccessModeEN> GetObjLstByFuncAccessModeIdLstCache(List<string> arrFuncAccessModeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFuncAccessModeEN._CurrTabName);
List<clsFuncAccessModeEN> arrFuncAccessModeObjLstCache = GetObjLstCache();
IEnumerable <clsFuncAccessModeEN> arrFuncAccessModeObjLst_Sel =
from objFuncAccessModeEN in arrFuncAccessModeObjLstCache
where arrFuncAccessModeId.Contains(objFuncAccessModeEN.FuncAccessModeId)
select objFuncAccessModeEN;
return arrFuncAccessModeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFuncAccessModeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFuncAccessModeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncAccessModeEN>>(strJson);
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
public static List<clsFuncAccessModeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFuncAccessModeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncAccessModeEN>>(strJson);
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
public static List<clsFuncAccessModeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFuncAccessModeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncAccessModeEN>>(strJson);
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
public static List<clsFuncAccessModeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsFuncAccessModeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFuncAccessModeEN>>(strJson);
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
public static int DelRecord(string strFuncAccessModeId)
{
string strAction = "DelRecord";
try
{
 clsFuncAccessModeEN objFuncAccessModeEN = clsFuncAccessModeWApi.GetObjByFuncAccessModeId(strFuncAccessModeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFuncAccessModeId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFuncAccessModeWApi.ReFreshCache();
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
public static int DelFuncAccessModes(List<string> arrFuncAccessModeId)
{
string strAction = "DelFuncAccessModes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncAccessModeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFuncAccessModeWApi.ReFreshCache();
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
public static int DelFuncAccessModesByCond(string strWhereCond)
{
string strAction = "DelFuncAccessModesByCond";
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
public static bool AddNewRecord(clsFuncAccessModeEN objFuncAccessModeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncAccessModeEN>(objFuncAccessModeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncAccessModeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsFuncAccessModeEN objFuncAccessModeEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncAccessModeEN>(objFuncAccessModeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFuncAccessModeWApi.ReFreshCache();
var strFuncAccessModeId = (string)jobjReturn0["returnStr"];
return strFuncAccessModeId;
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
public static bool UpdateRecord(clsFuncAccessModeEN objFuncAccessModeEN)
{
if (string.IsNullOrEmpty(objFuncAccessModeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFuncAccessModeEN.FuncAccessModeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncAccessModeEN>(objFuncAccessModeEN);
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
 /// <param name = "objFuncAccessModeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFuncAccessModeEN objFuncAccessModeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFuncAccessModeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFuncAccessModeEN.FuncAccessModeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFuncAccessModeEN.FuncAccessModeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFuncAccessModeEN>(objFuncAccessModeEN);
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
public static bool IsExist(string strFuncAccessModeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFuncAccessModeId"] = strFuncAccessModeId
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
 /// <param name = "objFuncAccessModeENS">源对象</param>
 /// <param name = "objFuncAccessModeENT">目标对象</param>
 public static void CopyTo(clsFuncAccessModeEN objFuncAccessModeENS, clsFuncAccessModeEN objFuncAccessModeENT)
{
try
{
objFuncAccessModeENT.FuncAccessModeId = objFuncAccessModeENS.FuncAccessModeId; //函数操作模式Id
objFuncAccessModeENT.FuncAccessModeName = objFuncAccessModeENS.FuncAccessModeName; //函数操作模式名
objFuncAccessModeENT.FuncAccessModeENName = objFuncAccessModeENS.FuncAccessModeENName; //函数操作模式英文名
objFuncAccessModeENT.UpdDate = objFuncAccessModeENS.UpdDate; //修改日期
objFuncAccessModeENT.UpdUser = objFuncAccessModeENS.UpdUser; //修改者
objFuncAccessModeENT.Memo = objFuncAccessModeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsFuncAccessModeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFuncAccessModeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFuncAccessModeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFuncAccessModeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFuncAccessModeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFuncAccessModeEN._AttributeName)
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
string strKey = string.Format("{0}", clsFuncAccessModeEN._CurrTabName);
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
if (clsFuncAccessModeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFuncAccessModeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFuncAccessModeWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFuncAccessModeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsFuncAccessModeEN._CurrTabName;
List<clsFuncAccessModeEN> arrFuncAccessModeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrFuncAccessModeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFuncAccessModeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFuncAccessMode.FuncAccessModeId, Type.GetType("System.String"));
objDT.Columns.Add(conFuncAccessMode.FuncAccessModeName, Type.GetType("System.String"));
objDT.Columns.Add(conFuncAccessMode.FuncAccessModeENName, Type.GetType("System.String"));
objDT.Columns.Add(conFuncAccessMode.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFuncAccessMode.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conFuncAccessMode.Memo, Type.GetType("System.String"));
foreach (clsFuncAccessModeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFuncAccessMode.FuncAccessModeId] = objInFor[conFuncAccessMode.FuncAccessModeId];
objDR[conFuncAccessMode.FuncAccessModeName] = objInFor[conFuncAccessMode.FuncAccessModeName];
objDR[conFuncAccessMode.FuncAccessModeENName] = objInFor[conFuncAccessMode.FuncAccessModeENName];
objDR[conFuncAccessMode.UpdDate] = objInFor[conFuncAccessMode.UpdDate];
objDR[conFuncAccessMode.UpdUser] = objInFor[conFuncAccessMode.UpdUser];
objDR[conFuncAccessMode.Memo] = objInFor[conFuncAccessMode.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 函数操作模式(FuncAccessMode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4FuncAccessMode : clsCommFun4BL
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
clsFuncAccessModeWApi.ReFreshThisCache();
}
}

}