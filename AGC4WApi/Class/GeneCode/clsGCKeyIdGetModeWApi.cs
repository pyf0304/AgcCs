
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCKeyIdGetModeWApi
 表名:GCKeyIdGetMode(00050562)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsGCKeyIdGetModeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyIdGetModeId">GC关键字获取方式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCKeyIdGetModeEN SetKeyIdGetModeId(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strKeyIdGetModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyIdGetModeId, 4, conGCKeyIdGetMode.KeyIdGetModeId);
clsCheckSql.CheckFieldForeignKey(strKeyIdGetModeId, 4, conGCKeyIdGetMode.KeyIdGetModeId);
objGCKeyIdGetModeEN.KeyIdGetModeId = strKeyIdGetModeId; //GC关键字获取方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCKeyIdGetModeEN.dicFldComparisonOp.ContainsKey(conGCKeyIdGetMode.KeyIdGetModeId) == false)
{
objGCKeyIdGetModeEN.dicFldComparisonOp.Add(conGCKeyIdGetMode.KeyIdGetModeId, strComparisonOp);
}
else
{
objGCKeyIdGetModeEN.dicFldComparisonOp[conGCKeyIdGetMode.KeyIdGetModeId] = strComparisonOp;
}
}
return objGCKeyIdGetModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyIdGetModeName">GC关键字获取方式名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCKeyIdGetModeEN SetKeyIdGetModeName(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strKeyIdGetModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKeyIdGetModeName, conGCKeyIdGetMode.KeyIdGetModeName);
clsCheckSql.CheckFieldLen(strKeyIdGetModeName, 50, conGCKeyIdGetMode.KeyIdGetModeName);
objGCKeyIdGetModeEN.KeyIdGetModeName = strKeyIdGetModeName; //GC关键字获取方式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCKeyIdGetModeEN.dicFldComparisonOp.ContainsKey(conGCKeyIdGetMode.KeyIdGetModeName) == false)
{
objGCKeyIdGetModeEN.dicFldComparisonOp.Add(conGCKeyIdGetMode.KeyIdGetModeName, strComparisonOp);
}
else
{
objGCKeyIdGetModeEN.dicFldComparisonOp[conGCKeyIdGetMode.KeyIdGetModeName] = strComparisonOp;
}
}
return objGCKeyIdGetModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyIdGetModeENName">GC关键字获取方式英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCKeyIdGetModeEN SetKeyIdGetModeENName(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strKeyIdGetModeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKeyIdGetModeENName, conGCKeyIdGetMode.KeyIdGetModeENName);
clsCheckSql.CheckFieldLen(strKeyIdGetModeENName, 50, conGCKeyIdGetMode.KeyIdGetModeENName);
objGCKeyIdGetModeEN.KeyIdGetModeENName = strKeyIdGetModeENName; //GC关键字获取方式英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCKeyIdGetModeEN.dicFldComparisonOp.ContainsKey(conGCKeyIdGetMode.KeyIdGetModeENName) == false)
{
objGCKeyIdGetModeEN.dicFldComparisonOp.Add(conGCKeyIdGetMode.KeyIdGetModeENName, strComparisonOp);
}
else
{
objGCKeyIdGetModeEN.dicFldComparisonOp[conGCKeyIdGetMode.KeyIdGetModeENName] = strComparisonOp;
}
}
return objGCKeyIdGetModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCKeyIdGetModeEN SetUpdDate(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conGCKeyIdGetMode.UpdDate);
objGCKeyIdGetModeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCKeyIdGetModeEN.dicFldComparisonOp.ContainsKey(conGCKeyIdGetMode.UpdDate) == false)
{
objGCKeyIdGetModeEN.dicFldComparisonOp.Add(conGCKeyIdGetMode.UpdDate, strComparisonOp);
}
else
{
objGCKeyIdGetModeEN.dicFldComparisonOp[conGCKeyIdGetMode.UpdDate] = strComparisonOp;
}
}
return objGCKeyIdGetModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCKeyIdGetModeEN SetUpdUser(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conGCKeyIdGetMode.UpdUser);
objGCKeyIdGetModeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCKeyIdGetModeEN.dicFldComparisonOp.ContainsKey(conGCKeyIdGetMode.UpdUser) == false)
{
objGCKeyIdGetModeEN.dicFldComparisonOp.Add(conGCKeyIdGetMode.UpdUser, strComparisonOp);
}
else
{
objGCKeyIdGetModeEN.dicFldComparisonOp[conGCKeyIdGetMode.UpdUser] = strComparisonOp;
}
}
return objGCKeyIdGetModeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCKeyIdGetModeEN SetMemo(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conGCKeyIdGetMode.Memo);
objGCKeyIdGetModeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCKeyIdGetModeEN.dicFldComparisonOp.ContainsKey(conGCKeyIdGetMode.Memo) == false)
{
objGCKeyIdGetModeEN.dicFldComparisonOp.Add(conGCKeyIdGetMode.Memo, strComparisonOp);
}
else
{
objGCKeyIdGetModeEN.dicFldComparisonOp[conGCKeyIdGetMode.Memo] = strComparisonOp;
}
}
return objGCKeyIdGetModeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGCKeyIdGetModeEN objGCKeyIdGetModeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGCKeyIdGetModeCond.IsUpdated(conGCKeyIdGetMode.KeyIdGetModeId) == true)
{
string strComparisonOpKeyIdGetModeId = objGCKeyIdGetModeCond.dicFldComparisonOp[conGCKeyIdGetMode.KeyIdGetModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCKeyIdGetMode.KeyIdGetModeId, objGCKeyIdGetModeCond.KeyIdGetModeId, strComparisonOpKeyIdGetModeId);
}
if (objGCKeyIdGetModeCond.IsUpdated(conGCKeyIdGetMode.KeyIdGetModeName) == true)
{
string strComparisonOpKeyIdGetModeName = objGCKeyIdGetModeCond.dicFldComparisonOp[conGCKeyIdGetMode.KeyIdGetModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCKeyIdGetMode.KeyIdGetModeName, objGCKeyIdGetModeCond.KeyIdGetModeName, strComparisonOpKeyIdGetModeName);
}
if (objGCKeyIdGetModeCond.IsUpdated(conGCKeyIdGetMode.KeyIdGetModeENName) == true)
{
string strComparisonOpKeyIdGetModeENName = objGCKeyIdGetModeCond.dicFldComparisonOp[conGCKeyIdGetMode.KeyIdGetModeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCKeyIdGetMode.KeyIdGetModeENName, objGCKeyIdGetModeCond.KeyIdGetModeENName, strComparisonOpKeyIdGetModeENName);
}
if (objGCKeyIdGetModeCond.IsUpdated(conGCKeyIdGetMode.UpdDate) == true)
{
string strComparisonOpUpdDate = objGCKeyIdGetModeCond.dicFldComparisonOp[conGCKeyIdGetMode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCKeyIdGetMode.UpdDate, objGCKeyIdGetModeCond.UpdDate, strComparisonOpUpdDate);
}
if (objGCKeyIdGetModeCond.IsUpdated(conGCKeyIdGetMode.UpdUser) == true)
{
string strComparisonOpUpdUser = objGCKeyIdGetModeCond.dicFldComparisonOp[conGCKeyIdGetMode.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCKeyIdGetMode.UpdUser, objGCKeyIdGetModeCond.UpdUser, strComparisonOpUpdUser);
}
if (objGCKeyIdGetModeCond.IsUpdated(conGCKeyIdGetMode.Memo) == true)
{
string strComparisonOpMemo = objGCKeyIdGetModeCond.dicFldComparisonOp[conGCKeyIdGetMode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCKeyIdGetMode.Memo, objGCKeyIdGetModeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
 if (string.IsNullOrEmpty(objGCKeyIdGetModeEN.KeyIdGetModeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objGCKeyIdGetModeEN.sfUpdFldSetStr = objGCKeyIdGetModeEN.getsfUpdFldSetStr();
clsGCKeyIdGetModeWApi.CheckPropertyNew(objGCKeyIdGetModeEN); 
bool bolResult = clsGCKeyIdGetModeWApi.UpdateRecord(objGCKeyIdGetModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeWApi.ReFreshCache();
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
 /// 获取唯一性条件串--GCKeyIdGetMode(GC关键字获取方式), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:KeyIdGetModeName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objGCKeyIdGetModeEN == null) return "";
if (objGCKeyIdGetModeEN.KeyIdGetModeId == null || objGCKeyIdGetModeEN.KeyIdGetModeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and KeyIdGetModeName = '{0}'", objGCKeyIdGetModeEN.KeyIdGetModeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("KeyIdGetModeId !=  '{0}'", objGCKeyIdGetModeEN.KeyIdGetModeId);
 sbCondition.AppendFormat(" and KeyIdGetModeName = '{0}'", objGCKeyIdGetModeEN.KeyIdGetModeName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objGCKeyIdGetModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
try
{
 if (string.IsNullOrEmpty(objGCKeyIdGetModeEN.KeyIdGetModeId) == true || clsGCKeyIdGetModeWApi.IsExist(objGCKeyIdGetModeEN.KeyIdGetModeId) == true)
 {
     objGCKeyIdGetModeEN.KeyIdGetModeId = clsGCKeyIdGetModeWApi.GetMaxStrId();
 }
clsGCKeyIdGetModeWApi.CheckPropertyNew(objGCKeyIdGetModeEN); 
bool bolResult = clsGCKeyIdGetModeWApi.AddNewRecord(objGCKeyIdGetModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeWApi.ReFreshCache();
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
 /// <param name = "objGCKeyIdGetModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
try
{
clsGCKeyIdGetModeWApi.CheckPropertyNew(objGCKeyIdGetModeEN); 
string strKeyIdGetModeId = clsGCKeyIdGetModeWApi.AddNewRecordWithMaxId(objGCKeyIdGetModeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeWApi.ReFreshCache();
return strKeyIdGetModeId;
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
 /// <param name = "objGCKeyIdGetModeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strWhereCond)
{
try
{
clsGCKeyIdGetModeWApi.CheckPropertyNew(objGCKeyIdGetModeEN); 
bool bolResult = clsGCKeyIdGetModeWApi.UpdateWithCondition(objGCKeyIdGetModeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeWApi.ReFreshCache();
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
public class enumGCKeyIdGetModeWA
{
 /// <summary>
 /// 列表选择记录
 /// </summary>
public const string ListCheckedRecord_0001 = "0001";
 /// <summary>
 /// 界面静态变量
 /// </summary>
public const string ViewStaticVariable_0002 = "0002";
}
 /// <summary>
 /// GC关键字获取方式(GCKeyIdGetMode)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsGCKeyIdGetModeWApi
{
private static readonly string mstrApiControllerName = "GCKeyIdGetModeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsGCKeyIdGetModeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_KeyIdGetModeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[GC关键字获取方式]...","0");
List<clsGCKeyIdGetModeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="KeyIdGetModeId";
objDDL.DataTextField="KeyIdGetModeName";
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

public static void BindCbo_KeyIdGetModeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conGCKeyIdGetMode.KeyIdGetModeId); 
List<clsGCKeyIdGetModeEN> arrObjLst = clsGCKeyIdGetModeWApi.GetObjLst(strCondition).OrderBy(x=>x.KeyIdGetModeName).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = new clsGCKeyIdGetModeEN()
{
KeyIdGetModeId = "0",
KeyIdGetModeName = "选[GC关键字获取方式]..."
};
arrObjLst.Insert(0, objGCKeyIdGetModeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conGCKeyIdGetMode.KeyIdGetModeId;
objComboBox.DisplayMember = conGCKeyIdGetMode.KeyIdGetModeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
if (!Object.Equals(null, objGCKeyIdGetModeEN.KeyIdGetModeId) && GetStrLen(objGCKeyIdGetModeEN.KeyIdGetModeId) > 4)
{
 throw new Exception("字段[GC关键字获取方式Id]的长度不能超过4!");
}
if (!Object.Equals(null, objGCKeyIdGetModeEN.KeyIdGetModeName) && GetStrLen(objGCKeyIdGetModeEN.KeyIdGetModeName) > 50)
{
 throw new Exception("字段[GC关键字获取方式名]的长度不能超过50!");
}
if (!Object.Equals(null, objGCKeyIdGetModeEN.KeyIdGetModeENName) && GetStrLen(objGCKeyIdGetModeEN.KeyIdGetModeENName) > 50)
{
 throw new Exception("字段[GC关键字获取方式英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objGCKeyIdGetModeEN.UpdDate) && GetStrLen(objGCKeyIdGetModeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objGCKeyIdGetModeEN.UpdUser) && GetStrLen(objGCKeyIdGetModeEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objGCKeyIdGetModeEN.Memo) && GetStrLen(objGCKeyIdGetModeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objGCKeyIdGetModeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strKeyIdGetModeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCKeyIdGetModeEN GetObjByKeyIdGetModeId(string strKeyIdGetModeId)
{
if (strKeyIdGetModeId == "") return null;
string strAction = "GetObjByKeyIdGetModeId";
clsGCKeyIdGetModeEN objGCKeyIdGetModeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strKeyIdGetModeId"] = strKeyIdGetModeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objGCKeyIdGetModeEN = JsonConvert.DeserializeObject<clsGCKeyIdGetModeEN>(strJson);
return objGCKeyIdGetModeEN;
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
public static clsGCKeyIdGetModeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsGCKeyIdGetModeEN objGCKeyIdGetModeEN;
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
objGCKeyIdGetModeEN = JsonConvert.DeserializeObject<clsGCKeyIdGetModeEN>(strJson);
return objGCKeyIdGetModeEN;
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
 /// <param name = "strKeyIdGetModeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCKeyIdGetModeEN GetObjByKeyIdGetModeIdCache(string strKeyIdGetModeId)
{
if (string.IsNullOrEmpty(strKeyIdGetModeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsGCKeyIdGetModeEN._CurrTabName);
List<clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLstCache = GetObjLstCache();
IEnumerable <clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLst_Sel =
from objGCKeyIdGetModeEN in arrGCKeyIdGetModeObjLstCache
where objGCKeyIdGetModeEN.KeyIdGetModeId == strKeyIdGetModeId 
select objGCKeyIdGetModeEN;
if (arrGCKeyIdGetModeObjLst_Sel.Count() == 0)
{
   clsGCKeyIdGetModeEN obj = clsGCKeyIdGetModeWApi.GetObjByKeyIdGetModeId(strKeyIdGetModeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrGCKeyIdGetModeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strKeyIdGetModeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetKeyIdGetModeNameByKeyIdGetModeIdCache(string strKeyIdGetModeId)
{
if (string.IsNullOrEmpty(strKeyIdGetModeId) == true) return "";
//初始化列表缓存
List<clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLstCache = GetObjLstCache();
IEnumerable <clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLst_Sel1 =
from objGCKeyIdGetModeEN in arrGCKeyIdGetModeObjLstCache
where objGCKeyIdGetModeEN.KeyIdGetModeId == strKeyIdGetModeId 
select objGCKeyIdGetModeEN;
List <clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLst_Sel = new List<clsGCKeyIdGetModeEN>();
foreach (clsGCKeyIdGetModeEN obj in arrGCKeyIdGetModeObjLst_Sel1)
{
arrGCKeyIdGetModeObjLst_Sel.Add(obj);
}
if (arrGCKeyIdGetModeObjLst_Sel.Count > 0)
{
return arrGCKeyIdGetModeObjLst_Sel[0].KeyIdGetModeName;
}
string strErrMsgForGetObjById = string.Format("在GCKeyIdGetMode对象缓存列表中,找不到记录[KeyIdGetModeId = {0}](函数:{1})", strKeyIdGetModeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsGCKeyIdGetModeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strKeyIdGetModeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByKeyIdGetModeIdCache(string strKeyIdGetModeId)
{
if (string.IsNullOrEmpty(strKeyIdGetModeId) == true) return "";
//初始化列表缓存
List<clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLstCache = GetObjLstCache();
IEnumerable <clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLst_Sel1 =
from objGCKeyIdGetModeEN in arrGCKeyIdGetModeObjLstCache
where objGCKeyIdGetModeEN.KeyIdGetModeId == strKeyIdGetModeId 
select objGCKeyIdGetModeEN;
List <clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLst_Sel = new List<clsGCKeyIdGetModeEN>();
foreach (clsGCKeyIdGetModeEN obj in arrGCKeyIdGetModeObjLst_Sel1)
{
arrGCKeyIdGetModeObjLst_Sel.Add(obj);
}
if (arrGCKeyIdGetModeObjLst_Sel.Count > 0)
{
return arrGCKeyIdGetModeObjLst_Sel[0].KeyIdGetModeName;
}
string strErrMsgForGetObjById = string.Format("在GCKeyIdGetMode对象缓存列表中,找不到记录的相关名称[KeyIdGetModeId = {0}](函数:{1})", strKeyIdGetModeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsGCKeyIdGetModeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCKeyIdGetModeEN> GetObjLst(string strWhereCond)
{
 List<clsGCKeyIdGetModeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGCKeyIdGetModeEN>>(strJson);
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
 /// <param name = "arrKeyIdGetModeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCKeyIdGetModeEN> GetObjLstByKeyIdGetModeIdLst(List<string> arrKeyIdGetModeId)
{
 List<clsGCKeyIdGetModeEN> arrObjLst; 
string strAction = "GetObjLstByKeyIdGetModeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrKeyIdGetModeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsGCKeyIdGetModeEN>>(strJson);
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
 /// <param name = "arrKeyIdGetModeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsGCKeyIdGetModeEN> GetObjLstByKeyIdGetModeIdLstCache(List<string> arrKeyIdGetModeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsGCKeyIdGetModeEN._CurrTabName);
List<clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLstCache = GetObjLstCache();
IEnumerable <clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLst_Sel =
from objGCKeyIdGetModeEN in arrGCKeyIdGetModeObjLstCache
where arrKeyIdGetModeId.Contains(objGCKeyIdGetModeEN.KeyIdGetModeId)
select objGCKeyIdGetModeEN;
return arrGCKeyIdGetModeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCKeyIdGetModeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsGCKeyIdGetModeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGCKeyIdGetModeEN>>(strJson);
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
public static List<clsGCKeyIdGetModeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsGCKeyIdGetModeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGCKeyIdGetModeEN>>(strJson);
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
public static List<clsGCKeyIdGetModeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsGCKeyIdGetModeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGCKeyIdGetModeEN>>(strJson);
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
public static List<clsGCKeyIdGetModeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsGCKeyIdGetModeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGCKeyIdGetModeEN>>(strJson);
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
public static int DelRecord(string strKeyIdGetModeId)
{
string strAction = "DelRecord";
try
{
 clsGCKeyIdGetModeEN objGCKeyIdGetModeEN = clsGCKeyIdGetModeWApi.GetObjByKeyIdGetModeId(strKeyIdGetModeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strKeyIdGetModeId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsGCKeyIdGetModeWApi.ReFreshCache();
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
public static int DelGCKeyIdGetModes(List<string> arrKeyIdGetModeId)
{
string strAction = "DelGCKeyIdGetModes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrKeyIdGetModeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsGCKeyIdGetModeWApi.ReFreshCache();
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
public static int DelGCKeyIdGetModesByCond(string strWhereCond)
{
string strAction = "DelGCKeyIdGetModesByCond";
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
public static bool AddNewRecord(clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGCKeyIdGetModeEN>(objGCKeyIdGetModeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGCKeyIdGetModeEN>(objGCKeyIdGetModeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCKeyIdGetModeWApi.ReFreshCache();
var strKeyIdGetModeId = (string)jobjReturn0["returnStr"];
return strKeyIdGetModeId;
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
public static bool UpdateRecord(clsGCKeyIdGetModeEN objGCKeyIdGetModeEN)
{
if (string.IsNullOrEmpty(objGCKeyIdGetModeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objGCKeyIdGetModeEN.KeyIdGetModeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGCKeyIdGetModeEN>(objGCKeyIdGetModeEN);
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
 /// <param name = "objGCKeyIdGetModeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsGCKeyIdGetModeEN objGCKeyIdGetModeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objGCKeyIdGetModeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objGCKeyIdGetModeEN.KeyIdGetModeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objGCKeyIdGetModeEN.KeyIdGetModeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGCKeyIdGetModeEN>(objGCKeyIdGetModeEN);
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
public static bool IsExist(string strKeyIdGetModeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strKeyIdGetModeId"] = strKeyIdGetModeId
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
 /// <param name = "objGCKeyIdGetModeENS">源对象</param>
 /// <param name = "objGCKeyIdGetModeENT">目标对象</param>
 public static void CopyTo(clsGCKeyIdGetModeEN objGCKeyIdGetModeENS, clsGCKeyIdGetModeEN objGCKeyIdGetModeENT)
{
try
{
objGCKeyIdGetModeENT.KeyIdGetModeId = objGCKeyIdGetModeENS.KeyIdGetModeId; //GC关键字获取方式Id
objGCKeyIdGetModeENT.KeyIdGetModeName = objGCKeyIdGetModeENS.KeyIdGetModeName; //GC关键字获取方式名
objGCKeyIdGetModeENT.KeyIdGetModeENName = objGCKeyIdGetModeENS.KeyIdGetModeENName; //GC关键字获取方式英文名
objGCKeyIdGetModeENT.UpdDate = objGCKeyIdGetModeENS.UpdDate; //修改日期
objGCKeyIdGetModeENT.UpdUser = objGCKeyIdGetModeENS.UpdUser; //修改者
objGCKeyIdGetModeENT.Memo = objGCKeyIdGetModeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsGCKeyIdGetModeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsGCKeyIdGetModeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsGCKeyIdGetModeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsGCKeyIdGetModeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsGCKeyIdGetModeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsGCKeyIdGetModeEN._AttributeName)
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
string strKey = string.Format("{0}", clsGCKeyIdGetModeEN._CurrTabName);
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
if (clsGCKeyIdGetModeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsGCKeyIdGetModeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGCKeyIdGetModeWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCKeyIdGetModeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsGCKeyIdGetModeEN._CurrTabName;
List<clsGCKeyIdGetModeEN> arrGCKeyIdGetModeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrGCKeyIdGetModeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsGCKeyIdGetModeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conGCKeyIdGetMode.KeyIdGetModeId, Type.GetType("System.String"));
objDT.Columns.Add(conGCKeyIdGetMode.KeyIdGetModeName, Type.GetType("System.String"));
objDT.Columns.Add(conGCKeyIdGetMode.KeyIdGetModeENName, Type.GetType("System.String"));
objDT.Columns.Add(conGCKeyIdGetMode.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conGCKeyIdGetMode.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conGCKeyIdGetMode.Memo, Type.GetType("System.String"));
foreach (clsGCKeyIdGetModeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conGCKeyIdGetMode.KeyIdGetModeId] = objInFor[conGCKeyIdGetMode.KeyIdGetModeId];
objDR[conGCKeyIdGetMode.KeyIdGetModeName] = objInFor[conGCKeyIdGetMode.KeyIdGetModeName];
objDR[conGCKeyIdGetMode.KeyIdGetModeENName] = objInFor[conGCKeyIdGetMode.KeyIdGetModeENName];
objDR[conGCKeyIdGetMode.UpdDate] = objInFor[conGCKeyIdGetMode.UpdDate];
objDR[conGCKeyIdGetMode.UpdUser] = objInFor[conGCKeyIdGetMode.UpdUser];
objDR[conGCKeyIdGetMode.Memo] = objInFor[conGCKeyIdGetMode.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// GC关键字获取方式(GCKeyIdGetMode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4GCKeyIdGetMode : clsCommFun4BL
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
clsGCKeyIdGetModeWApi.ReFreshThisCache();
}
}

}