
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFeatureTypeWApi
 表名:PrjFeatureType(00050323)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:39:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsPrjFeatureTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeId">功能类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureTypeEN SetFeatureTypeId(this clsPrjFeatureTypeEN objPrjFeatureTypeEN, string strFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureTypeId, 2, conPrjFeatureType.FeatureTypeId);
clsCheckSql.CheckFieldForeignKey(strFeatureTypeId, 2, conPrjFeatureType.FeatureTypeId);
objPrjFeatureTypeEN.FeatureTypeId = strFeatureTypeId; //功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureTypeEN.dicFldComparisonOp.ContainsKey(conPrjFeatureType.FeatureTypeId) == false)
{
objPrjFeatureTypeEN.dicFldComparisonOp.Add(conPrjFeatureType.FeatureTypeId, strComparisonOp);
}
else
{
objPrjFeatureTypeEN.dicFldComparisonOp[conPrjFeatureType.FeatureTypeId] = strComparisonOp;
}
}
return objPrjFeatureTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeName">功能类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureTypeEN SetFeatureTypeName(this clsPrjFeatureTypeEN objPrjFeatureTypeEN, string strFeatureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeName, conPrjFeatureType.FeatureTypeName);
clsCheckSql.CheckFieldLen(strFeatureTypeName, 30, conPrjFeatureType.FeatureTypeName);
objPrjFeatureTypeEN.FeatureTypeName = strFeatureTypeName; //功能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureTypeEN.dicFldComparisonOp.ContainsKey(conPrjFeatureType.FeatureTypeName) == false)
{
objPrjFeatureTypeEN.dicFldComparisonOp.Add(conPrjFeatureType.FeatureTypeName, strComparisonOp);
}
else
{
objPrjFeatureTypeEN.dicFldComparisonOp[conPrjFeatureType.FeatureTypeName] = strComparisonOp;
}
}
return objPrjFeatureTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strFeatureTypeENName">功能类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureTypeEN SetFeatureTypeENName(this clsPrjFeatureTypeEN objPrjFeatureTypeEN, string strFeatureTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFeatureTypeENName, 30, conPrjFeatureType.FeatureTypeENName);
objPrjFeatureTypeEN.FeatureTypeENName = strFeatureTypeENName; //功能类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureTypeEN.dicFldComparisonOp.ContainsKey(conPrjFeatureType.FeatureTypeENName) == false)
{
objPrjFeatureTypeEN.dicFldComparisonOp.Add(conPrjFeatureType.FeatureTypeENName, strComparisonOp);
}
else
{
objPrjFeatureTypeEN.dicFldComparisonOp[conPrjFeatureType.FeatureTypeENName] = strComparisonOp;
}
}
return objPrjFeatureTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureTypeEN SetOrderNum(this clsPrjFeatureTypeEN objPrjFeatureTypeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conPrjFeatureType.OrderNum);
objPrjFeatureTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureTypeEN.dicFldComparisonOp.ContainsKey(conPrjFeatureType.OrderNum) == false)
{
objPrjFeatureTypeEN.dicFldComparisonOp.Add(conPrjFeatureType.OrderNum, strComparisonOp);
}
else
{
objPrjFeatureTypeEN.dicFldComparisonOp[conPrjFeatureType.OrderNum] = strComparisonOp;
}
}
return objPrjFeatureTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureTypeEN SetUpdDate(this clsPrjFeatureTypeEN objPrjFeatureTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPrjFeatureType.UpdDate);
objPrjFeatureTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureTypeEN.dicFldComparisonOp.ContainsKey(conPrjFeatureType.UpdDate) == false)
{
objPrjFeatureTypeEN.dicFldComparisonOp.Add(conPrjFeatureType.UpdDate, strComparisonOp);
}
else
{
objPrjFeatureTypeEN.dicFldComparisonOp[conPrjFeatureType.UpdDate] = strComparisonOp;
}
}
return objPrjFeatureTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureTypeEN SetUpdUser(this clsPrjFeatureTypeEN objPrjFeatureTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conPrjFeatureType.UpdUser);
objPrjFeatureTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureTypeEN.dicFldComparisonOp.ContainsKey(conPrjFeatureType.UpdUser) == false)
{
objPrjFeatureTypeEN.dicFldComparisonOp.Add(conPrjFeatureType.UpdUser, strComparisonOp);
}
else
{
objPrjFeatureTypeEN.dicFldComparisonOp[conPrjFeatureType.UpdUser] = strComparisonOp;
}
}
return objPrjFeatureTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjFeatureTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjFeatureTypeEN SetMemo(this clsPrjFeatureTypeEN objPrjFeatureTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjFeatureType.Memo);
objPrjFeatureTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjFeatureTypeEN.dicFldComparisonOp.ContainsKey(conPrjFeatureType.Memo) == false)
{
objPrjFeatureTypeEN.dicFldComparisonOp.Add(conPrjFeatureType.Memo, strComparisonOp);
}
else
{
objPrjFeatureTypeEN.dicFldComparisonOp[conPrjFeatureType.Memo] = strComparisonOp;
}
}
return objPrjFeatureTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjFeatureTypeEN objPrjFeatureTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjFeatureTypeCond.IsUpdated(conPrjFeatureType.FeatureTypeId) == true)
{
string strComparisonOpFeatureTypeId = objPrjFeatureTypeCond.dicFldComparisonOp[conPrjFeatureType.FeatureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeatureType.FeatureTypeId, objPrjFeatureTypeCond.FeatureTypeId, strComparisonOpFeatureTypeId);
}
if (objPrjFeatureTypeCond.IsUpdated(conPrjFeatureType.FeatureTypeName) == true)
{
string strComparisonOpFeatureTypeName = objPrjFeatureTypeCond.dicFldComparisonOp[conPrjFeatureType.FeatureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeatureType.FeatureTypeName, objPrjFeatureTypeCond.FeatureTypeName, strComparisonOpFeatureTypeName);
}
if (objPrjFeatureTypeCond.IsUpdated(conPrjFeatureType.FeatureTypeENName) == true)
{
string strComparisonOpFeatureTypeENName = objPrjFeatureTypeCond.dicFldComparisonOp[conPrjFeatureType.FeatureTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeatureType.FeatureTypeENName, objPrjFeatureTypeCond.FeatureTypeENName, strComparisonOpFeatureTypeENName);
}
if (objPrjFeatureTypeCond.IsUpdated(conPrjFeatureType.OrderNum) == true)
{
string strComparisonOpOrderNum = objPrjFeatureTypeCond.dicFldComparisonOp[conPrjFeatureType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conPrjFeatureType.OrderNum, objPrjFeatureTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objPrjFeatureTypeCond.IsUpdated(conPrjFeatureType.UpdDate) == true)
{
string strComparisonOpUpdDate = objPrjFeatureTypeCond.dicFldComparisonOp[conPrjFeatureType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeatureType.UpdDate, objPrjFeatureTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objPrjFeatureTypeCond.IsUpdated(conPrjFeatureType.UpdUser) == true)
{
string strComparisonOpUpdUser = objPrjFeatureTypeCond.dicFldComparisonOp[conPrjFeatureType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeatureType.UpdUser, objPrjFeatureTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objPrjFeatureTypeCond.IsUpdated(conPrjFeatureType.Memo) == true)
{
string strComparisonOpMemo = objPrjFeatureTypeCond.dicFldComparisonOp[conPrjFeatureType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjFeatureType.Memo, objPrjFeatureTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objPrjFeatureTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjFeatureTypeEN objPrjFeatureTypeEN)
{
 if (string.IsNullOrEmpty(objPrjFeatureTypeEN.FeatureTypeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objPrjFeatureTypeEN.sfUpdFldSetStr = objPrjFeatureTypeEN.getsfUpdFldSetStr();
clsPrjFeatureTypeWApi.CheckPropertyNew(objPrjFeatureTypeEN); 
bool bolResult = clsPrjFeatureTypeWApi.UpdateRecord(objPrjFeatureTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureTypeWApi.ReFreshCache();
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
 /// 获取唯一性条件串--PrjFeatureType(功能类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:FeatureTypeName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjFeatureTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsPrjFeatureTypeEN objPrjFeatureTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjFeatureTypeEN == null) return "";
if (objPrjFeatureTypeEN.FeatureTypeId == null || objPrjFeatureTypeEN.FeatureTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FeatureTypeName = '{0}'", objPrjFeatureTypeEN.FeatureTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FeatureTypeId !=  '{0}'", objPrjFeatureTypeEN.FeatureTypeId);
 sbCondition.AppendFormat(" and FeatureTypeName = '{0}'", objPrjFeatureTypeEN.FeatureTypeName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjFeatureTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjFeatureTypeEN objPrjFeatureTypeEN)
{
try
{
 if (string.IsNullOrEmpty(objPrjFeatureTypeEN.FeatureTypeId) == true || clsPrjFeatureTypeWApi.IsExist(objPrjFeatureTypeEN.FeatureTypeId) == true)
 {
     objPrjFeatureTypeEN.FeatureTypeId = clsPrjFeatureTypeWApi.GetMaxStrId();
 }
clsPrjFeatureTypeWApi.CheckPropertyNew(objPrjFeatureTypeEN); 
bool bolResult = clsPrjFeatureTypeWApi.AddNewRecord(objPrjFeatureTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureTypeWApi.ReFreshCache();
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
 /// <param name = "objPrjFeatureTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsPrjFeatureTypeEN objPrjFeatureTypeEN)
{
try
{
clsPrjFeatureTypeWApi.CheckPropertyNew(objPrjFeatureTypeEN); 
string strFeatureTypeId = clsPrjFeatureTypeWApi.AddNewRecordWithMaxId(objPrjFeatureTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureTypeWApi.ReFreshCache();
return strFeatureTypeId;
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
 /// <param name = "objPrjFeatureTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjFeatureTypeEN objPrjFeatureTypeEN, string strWhereCond)
{
try
{
clsPrjFeatureTypeWApi.CheckPropertyNew(objPrjFeatureTypeEN); 
bool bolResult = clsPrjFeatureTypeWApi.UpdateWithCondition(objPrjFeatureTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureTypeWApi.ReFreshCache();
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
public class enumPrjFeatureTypeWA
{
 /// <summary>
 /// 未知
 /// </summary>
public const string Unknown_00 = "00";
 /// <summary>
 /// 前端界面
 /// </summary>
public const string FrontInterface_01 = "01";
 /// <summary>
 /// 后端功能
 /// </summary>
public const string BackgroundFunction_02 = "02";
 /// <summary>
 /// 表功能
 /// </summary>
public const string TabFeature_03 = "03";
 /// <summary>
 /// 前端隐性
 /// </summary>
public const string FrontHiddenInterface_04 = "04";
 /// <summary>
 /// 通用功能
 /// </summary>
public const string GeneralFeature_05 = "05";
}
 /// <summary>
 /// 功能类型(PrjFeatureType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsPrjFeatureTypeWApi
{
private static readonly string mstrApiControllerName = "PrjFeatureTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsPrjFeatureTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FeatureTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[功能类型]...","0");
List<clsPrjFeatureTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FeatureTypeId";
objDDL.DataTextField="FeatureTypeName";
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

public static void BindCbo_FeatureTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPrjFeatureType.FeatureTypeId); 
List<clsPrjFeatureTypeEN> arrObjLst = clsPrjFeatureTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsPrjFeatureTypeEN objPrjFeatureTypeEN = new clsPrjFeatureTypeEN()
{
FeatureTypeId = "0",
FeatureTypeName = "选[功能类型]..."
};
arrObjLst.Insert(0, objPrjFeatureTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conPrjFeatureType.FeatureTypeId;
objComboBox.DisplayMember = conPrjFeatureType.FeatureTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsPrjFeatureTypeEN objPrjFeatureTypeEN)
{
if (!Object.Equals(null, objPrjFeatureTypeEN.FeatureTypeId) && GetStrLen(objPrjFeatureTypeEN.FeatureTypeId) > 2)
{
 throw new Exception("字段[功能类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objPrjFeatureTypeEN.FeatureTypeName) && GetStrLen(objPrjFeatureTypeEN.FeatureTypeName) > 30)
{
 throw new Exception("字段[功能类型名称]的长度不能超过30!");
}
if (!Object.Equals(null, objPrjFeatureTypeEN.FeatureTypeENName) && GetStrLen(objPrjFeatureTypeEN.FeatureTypeENName) > 30)
{
 throw new Exception("字段[功能类型英文名]的长度不能超过30!");
}
if (!Object.Equals(null, objPrjFeatureTypeEN.UpdDate) && GetStrLen(objPrjFeatureTypeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objPrjFeatureTypeEN.UpdUser) && GetStrLen(objPrjFeatureTypeEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objPrjFeatureTypeEN.Memo) && GetStrLen(objPrjFeatureTypeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objPrjFeatureTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFeatureTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjFeatureTypeEN GetObjByFeatureTypeId(string strFeatureTypeId)
{
if (strFeatureTypeId == "") return null;
string strAction = "GetObjByFeatureTypeId";
clsPrjFeatureTypeEN objPrjFeatureTypeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFeatureTypeId"] = strFeatureTypeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objPrjFeatureTypeEN = JsonConvert.DeserializeObject<clsPrjFeatureTypeEN>(strJson);
return objPrjFeatureTypeEN;
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
public static clsPrjFeatureTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsPrjFeatureTypeEN objPrjFeatureTypeEN;
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
objPrjFeatureTypeEN = JsonConvert.DeserializeObject<clsPrjFeatureTypeEN>(strJson);
return objPrjFeatureTypeEN;
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
 /// <param name = "strFeatureTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPrjFeatureTypeEN GetObjByFeatureTypeIdCache(string strFeatureTypeId)
{
if (string.IsNullOrEmpty(strFeatureTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsPrjFeatureTypeEN._CurrTabName);
List<clsPrjFeatureTypeEN> arrPrjFeatureTypeObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFeatureTypeEN> arrPrjFeatureTypeObjLst_Sel =
from objPrjFeatureTypeEN in arrPrjFeatureTypeObjLstCache
where objPrjFeatureTypeEN.FeatureTypeId == strFeatureTypeId 
select objPrjFeatureTypeEN;
if (arrPrjFeatureTypeObjLst_Sel.Count() == 0)
{
   clsPrjFeatureTypeEN obj = clsPrjFeatureTypeWApi.GetObjByFeatureTypeId(strFeatureTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrPrjFeatureTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFeatureTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFeatureTypeNameByFeatureTypeIdCache(string strFeatureTypeId)
{
if (string.IsNullOrEmpty(strFeatureTypeId) == true) return "";
//初始化列表缓存
List<clsPrjFeatureTypeEN> arrPrjFeatureTypeObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFeatureTypeEN> arrPrjFeatureTypeObjLst_Sel1 =
from objPrjFeatureTypeEN in arrPrjFeatureTypeObjLstCache
where objPrjFeatureTypeEN.FeatureTypeId == strFeatureTypeId 
select objPrjFeatureTypeEN;
List <clsPrjFeatureTypeEN> arrPrjFeatureTypeObjLst_Sel = new List<clsPrjFeatureTypeEN>();
foreach (clsPrjFeatureTypeEN obj in arrPrjFeatureTypeObjLst_Sel1)
{
arrPrjFeatureTypeObjLst_Sel.Add(obj);
}
if (arrPrjFeatureTypeObjLst_Sel.Count > 0)
{
return arrPrjFeatureTypeObjLst_Sel[0].FeatureTypeName;
}
string strErrMsgForGetObjById = string.Format("在PrjFeatureType对象缓存列表中,找不到记录[FeatureTypeId = {0}](函数:{1})", strFeatureTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPrjFeatureTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFeatureTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFeatureTypeIdCache(string strFeatureTypeId)
{
if (string.IsNullOrEmpty(strFeatureTypeId) == true) return "";
//初始化列表缓存
List<clsPrjFeatureTypeEN> arrPrjFeatureTypeObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFeatureTypeEN> arrPrjFeatureTypeObjLst_Sel1 =
from objPrjFeatureTypeEN in arrPrjFeatureTypeObjLstCache
where objPrjFeatureTypeEN.FeatureTypeId == strFeatureTypeId 
select objPrjFeatureTypeEN;
List <clsPrjFeatureTypeEN> arrPrjFeatureTypeObjLst_Sel = new List<clsPrjFeatureTypeEN>();
foreach (clsPrjFeatureTypeEN obj in arrPrjFeatureTypeObjLst_Sel1)
{
arrPrjFeatureTypeObjLst_Sel.Add(obj);
}
if (arrPrjFeatureTypeObjLst_Sel.Count > 0)
{
return arrPrjFeatureTypeObjLst_Sel[0].FeatureTypeName;
}
string strErrMsgForGetObjById = string.Format("在PrjFeatureType对象缓存列表中,找不到记录的相关名称[FeatureTypeId = {0}](函数:{1})", strFeatureTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsPrjFeatureTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjFeatureTypeEN> GetObjLst(string strWhereCond)
{
 List<clsPrjFeatureTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjFeatureTypeEN>>(strJson);
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
 /// <param name = "arrFeatureTypeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjFeatureTypeEN> GetObjLstByFeatureTypeIdLst(List<string> arrFeatureTypeId)
{
 List<clsPrjFeatureTypeEN> arrObjLst; 
string strAction = "GetObjLstByFeatureTypeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFeatureTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjFeatureTypeEN>>(strJson);
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
 /// <param name = "arrFeatureTypeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsPrjFeatureTypeEN> GetObjLstByFeatureTypeIdLstCache(List<string> arrFeatureTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsPrjFeatureTypeEN._CurrTabName);
List<clsPrjFeatureTypeEN> arrPrjFeatureTypeObjLstCache = GetObjLstCache();
IEnumerable <clsPrjFeatureTypeEN> arrPrjFeatureTypeObjLst_Sel =
from objPrjFeatureTypeEN in arrPrjFeatureTypeObjLstCache
where arrFeatureTypeId.Contains(objPrjFeatureTypeEN.FeatureTypeId)
select objPrjFeatureTypeEN;
return arrPrjFeatureTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjFeatureTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsPrjFeatureTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjFeatureTypeEN>>(strJson);
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
public static List<clsPrjFeatureTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsPrjFeatureTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjFeatureTypeEN>>(strJson);
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
public static List<clsPrjFeatureTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsPrjFeatureTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjFeatureTypeEN>>(strJson);
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
public static List<clsPrjFeatureTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsPrjFeatureTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjFeatureTypeEN>>(strJson);
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
public static int DelRecord(string strFeatureTypeId)
{
string strAction = "DelRecord";
try
{
 clsPrjFeatureTypeEN objPrjFeatureTypeEN = clsPrjFeatureTypeWApi.GetObjByFeatureTypeId(strFeatureTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFeatureTypeId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsPrjFeatureTypeWApi.ReFreshCache();
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
public static int DelPrjFeatureTypes(List<string> arrFeatureTypeId)
{
string strAction = "DelPrjFeatureTypes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFeatureTypeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsPrjFeatureTypeWApi.ReFreshCache();
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
public static int DelPrjFeatureTypesByCond(string strWhereCond)
{
string strAction = "DelPrjFeatureTypesByCond";
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
public static bool AddNewRecord(clsPrjFeatureTypeEN objPrjFeatureTypeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjFeatureTypeEN>(objPrjFeatureTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureTypeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsPrjFeatureTypeEN objPrjFeatureTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjFeatureTypeEN>(objPrjFeatureTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjFeatureTypeWApi.ReFreshCache();
var strFeatureTypeId = (string)jobjReturn0["returnStr"];
return strFeatureTypeId;
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
public static bool UpdateRecord(clsPrjFeatureTypeEN objPrjFeatureTypeEN)
{
if (string.IsNullOrEmpty(objPrjFeatureTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjFeatureTypeEN.FeatureTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjFeatureTypeEN>(objPrjFeatureTypeEN);
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
 /// <param name = "objPrjFeatureTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsPrjFeatureTypeEN objPrjFeatureTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objPrjFeatureTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjFeatureTypeEN.FeatureTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjFeatureTypeEN.FeatureTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjFeatureTypeEN>(objPrjFeatureTypeEN);
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
public static bool IsExist(string strFeatureTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFeatureTypeId"] = strFeatureTypeId
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
 /// <param name = "objPrjFeatureTypeENS">源对象</param>
 /// <param name = "objPrjFeatureTypeENT">目标对象</param>
 public static void CopyTo(clsPrjFeatureTypeEN objPrjFeatureTypeENS, clsPrjFeatureTypeEN objPrjFeatureTypeENT)
{
try
{
objPrjFeatureTypeENT.FeatureTypeId = objPrjFeatureTypeENS.FeatureTypeId; //功能类型Id
objPrjFeatureTypeENT.FeatureTypeName = objPrjFeatureTypeENS.FeatureTypeName; //功能类型名称
objPrjFeatureTypeENT.FeatureTypeENName = objPrjFeatureTypeENS.FeatureTypeENName; //功能类型英文名
objPrjFeatureTypeENT.OrderNum = objPrjFeatureTypeENS.OrderNum; //序号
objPrjFeatureTypeENT.UpdDate = objPrjFeatureTypeENS.UpdDate; //修改日期
objPrjFeatureTypeENT.UpdUser = objPrjFeatureTypeENS.UpdUser; //修改者
objPrjFeatureTypeENT.Memo = objPrjFeatureTypeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsPrjFeatureTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsPrjFeatureTypeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsPrjFeatureTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsPrjFeatureTypeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsPrjFeatureTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsPrjFeatureTypeEN._AttributeName)
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
string strKey = string.Format("{0}", clsPrjFeatureTypeEN._CurrTabName);
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
if (clsPrjFeatureTypeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPrjFeatureTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPrjFeatureTypeWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjFeatureTypeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsPrjFeatureTypeEN._CurrTabName;
List<clsPrjFeatureTypeEN> arrPrjFeatureTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrPrjFeatureTypeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsPrjFeatureTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conPrjFeatureType.FeatureTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeatureType.FeatureTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeatureType.FeatureTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeatureType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conPrjFeatureType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeatureType.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conPrjFeatureType.Memo, Type.GetType("System.String"));
foreach (clsPrjFeatureTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conPrjFeatureType.FeatureTypeId] = objInFor[conPrjFeatureType.FeatureTypeId];
objDR[conPrjFeatureType.FeatureTypeName] = objInFor[conPrjFeatureType.FeatureTypeName];
objDR[conPrjFeatureType.FeatureTypeENName] = objInFor[conPrjFeatureType.FeatureTypeENName];
objDR[conPrjFeatureType.OrderNum] = objInFor[conPrjFeatureType.OrderNum];
objDR[conPrjFeatureType.UpdDate] = objInFor[conPrjFeatureType.UpdDate];
objDR[conPrjFeatureType.UpdUser] = objInFor[conPrjFeatureType.UpdUser];
objDR[conPrjFeatureType.Memo] = objInFor[conPrjFeatureType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 功能类型(PrjFeatureType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4PrjFeatureType : clsCommFun4BL
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
clsPrjFeatureTypeWApi.ReFreshThisCache();
}
}

}