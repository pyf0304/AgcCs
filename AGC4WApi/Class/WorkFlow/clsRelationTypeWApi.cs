
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRelationTypeWApi
 表名:RelationType(00050532)
 生成代码版本:2021.07.30.2
 生成日期:2021/07/30 16:30:03
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:AGC
 工程ID:0005
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理
 模块英文名:WorkFlow
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
public static class clsRelationTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRelationTypeEN SetRelationTypeId(this clsRelationTypeEN objRelationTypeEN, string strRelationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelationTypeId, 8, conRelationType.RelationTypeId);
clsCheckSql.CheckFieldForeignKey(strRelationTypeId, 8, conRelationType.RelationTypeId);
objRelationTypeEN.RelationTypeId = strRelationTypeId; //关系类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationTypeEN.dicFldComparisonOp.ContainsKey(conRelationType.RelationTypeId) == false)
{
objRelationTypeEN.dicFldComparisonOp.Add(conRelationType.RelationTypeId, strComparisonOp);
}
else
{
objRelationTypeEN.dicFldComparisonOp[conRelationType.RelationTypeId] = strComparisonOp;
}
}
return objRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRelationTypeEN SetRelationTypeName(this clsRelationTypeEN objRelationTypeEN, string strRelationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelationTypeName, 50, conRelationType.RelationTypeName);
objRelationTypeEN.RelationTypeName = strRelationTypeName; //关系类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationTypeEN.dicFldComparisonOp.ContainsKey(conRelationType.RelationTypeName) == false)
{
objRelationTypeEN.dicFldComparisonOp.Add(conRelationType.RelationTypeName, strComparisonOp);
}
else
{
objRelationTypeEN.dicFldComparisonOp[conRelationType.RelationTypeName] = strComparisonOp;
}
}
return objRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRelationTypeEN SetRelationPropName1(this clsRelationTypeEN objRelationTypeEN, string strRelationPropName1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelationPropName1, 50, conRelationType.RelationPropName1);
objRelationTypeEN.RelationPropName1 = strRelationPropName1; //关系属性名1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationTypeEN.dicFldComparisonOp.ContainsKey(conRelationType.RelationPropName1) == false)
{
objRelationTypeEN.dicFldComparisonOp.Add(conRelationType.RelationPropName1, strComparisonOp);
}
else
{
objRelationTypeEN.dicFldComparisonOp[conRelationType.RelationPropName1] = strComparisonOp;
}
}
return objRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRelationTypeEN SetRelationPropName2(this clsRelationTypeEN objRelationTypeEN, string strRelationPropName2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRelationPropName2, 50, conRelationType.RelationPropName2);
objRelationTypeEN.RelationPropName2 = strRelationPropName2; //关系属性名2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationTypeEN.dicFldComparisonOp.ContainsKey(conRelationType.RelationPropName2) == false)
{
objRelationTypeEN.dicFldComparisonOp.Add(conRelationType.RelationPropName2, strComparisonOp);
}
else
{
objRelationTypeEN.dicFldComparisonOp[conRelationType.RelationPropName2] = strComparisonOp;
}
}
return objRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRelationTypeEN SetPrjId(this clsRelationTypeEN objRelationTypeEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conRelationType.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conRelationType.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conRelationType.PrjId);
objRelationTypeEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationTypeEN.dicFldComparisonOp.ContainsKey(conRelationType.PrjId) == false)
{
objRelationTypeEN.dicFldComparisonOp.Add(conRelationType.PrjId, strComparisonOp);
}
else
{
objRelationTypeEN.dicFldComparisonOp[conRelationType.PrjId] = strComparisonOp;
}
}
return objRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRelationTypeEN SetUpdDate(this clsRelationTypeEN objRelationTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conRelationType.UpdDate);
objRelationTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationTypeEN.dicFldComparisonOp.ContainsKey(conRelationType.UpdDate) == false)
{
objRelationTypeEN.dicFldComparisonOp.Add(conRelationType.UpdDate, strComparisonOp);
}
else
{
objRelationTypeEN.dicFldComparisonOp[conRelationType.UpdDate] = strComparisonOp;
}
}
return objRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRelationTypeEN SetUpdUser(this clsRelationTypeEN objRelationTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conRelationType.UpdUser);
objRelationTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationTypeEN.dicFldComparisonOp.ContainsKey(conRelationType.UpdUser) == false)
{
objRelationTypeEN.dicFldComparisonOp.Add(conRelationType.UpdUser, strComparisonOp);
}
else
{
objRelationTypeEN.dicFldComparisonOp[conRelationType.UpdUser] = strComparisonOp;
}
}
return objRelationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRelationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRelationTypeEN SetMemo(this clsRelationTypeEN objRelationTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conRelationType.Memo);
objRelationTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRelationTypeEN.dicFldComparisonOp.ContainsKey(conRelationType.Memo) == false)
{
objRelationTypeEN.dicFldComparisonOp.Add(conRelationType.Memo, strComparisonOp);
}
else
{
objRelationTypeEN.dicFldComparisonOp[conRelationType.Memo] = strComparisonOp;
}
}
return objRelationTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsRelationTypeEN objRelationType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objRelationType_Cond.IsUpdated(conRelationType.RelationTypeId) == true)
{
string strComparisonOp_RelationTypeId = objRelationType_Cond.dicFldComparisonOp[conRelationType.RelationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRelationType.RelationTypeId, objRelationType_Cond.RelationTypeId, strComparisonOp_RelationTypeId);
}
if (objRelationType_Cond.IsUpdated(conRelationType.RelationTypeName) == true)
{
string strComparisonOp_RelationTypeName = objRelationType_Cond.dicFldComparisonOp[conRelationType.RelationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRelationType.RelationTypeName, objRelationType_Cond.RelationTypeName, strComparisonOp_RelationTypeName);
}
if (objRelationType_Cond.IsUpdated(conRelationType.RelationPropName1) == true)
{
string strComparisonOp_RelationPropName1 = objRelationType_Cond.dicFldComparisonOp[conRelationType.RelationPropName1];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRelationType.RelationPropName1, objRelationType_Cond.RelationPropName1, strComparisonOp_RelationPropName1);
}
if (objRelationType_Cond.IsUpdated(conRelationType.RelationPropName2) == true)
{
string strComparisonOp_RelationPropName2 = objRelationType_Cond.dicFldComparisonOp[conRelationType.RelationPropName2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRelationType.RelationPropName2, objRelationType_Cond.RelationPropName2, strComparisonOp_RelationPropName2);
}
if (objRelationType_Cond.IsUpdated(conRelationType.PrjId) == true)
{
string strComparisonOp_PrjId = objRelationType_Cond.dicFldComparisonOp[conRelationType.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRelationType.PrjId, objRelationType_Cond.PrjId, strComparisonOp_PrjId);
}
if (objRelationType_Cond.IsUpdated(conRelationType.UpdDate) == true)
{
string strComparisonOp_UpdDate = objRelationType_Cond.dicFldComparisonOp[conRelationType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRelationType.UpdDate, objRelationType_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objRelationType_Cond.IsUpdated(conRelationType.UpdUser) == true)
{
string strComparisonOp_UpdUser = objRelationType_Cond.dicFldComparisonOp[conRelationType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRelationType.UpdUser, objRelationType_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objRelationType_Cond.IsUpdated(conRelationType.Memo) == true)
{
string strComparisonOp_Memo = objRelationType_Cond.dicFldComparisonOp[conRelationType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRelationType.Memo, objRelationType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objRelationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRelationTypeEN objRelationTypeEN)
{
 if (string.IsNullOrEmpty(objRelationTypeEN.RelationTypeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objRelationTypeEN.sfUpdFldSetStr = objRelationTypeEN.getsfUpdFldSetStr();
clsRelationTypeWApi.CheckPropertyNew(objRelationTypeEN); 
bool bolResult = clsRelationTypeWApi.UpdateRecord(objRelationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationTypeWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--RelationType(关系类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objRelationTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_RelationTypeName_PrjId(this clsRelationTypeEN objRelationTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objRelationTypeEN == null) return "";
if (objRelationTypeEN.RelationTypeId == null || objRelationTypeEN.RelationTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RelationTypeName = '{0}'", objRelationTypeEN.RelationTypeName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objRelationTypeEN.PrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RelationTypeId !=  '{0}'", objRelationTypeEN.RelationTypeId);
 sbCondition.AppendFormat(" and RelationTypeName = '{0}'", objRelationTypeEN.RelationTypeName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objRelationTypeEN.PrjId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objRelationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsRelationTypeEN objRelationTypeEN)
{
try
{
 if (string.IsNullOrEmpty(objRelationTypeEN.RelationTypeId) == true || clsRelationTypeWApi.IsExist(objRelationTypeEN.RelationTypeId) == true)
 {
     objRelationTypeEN.RelationTypeId = clsRelationTypeWApi.GetMaxStrId();
 }
clsRelationTypeWApi.CheckPropertyNew(objRelationTypeEN); 
bool bolResult = clsRelationTypeWApi.AddNewRecord(objRelationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationTypeWApi.ReFreshCache();
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
 /// <param name = "objRelationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsRelationTypeEN objRelationTypeEN)
{
try
{
clsRelationTypeWApi.CheckPropertyNew(objRelationTypeEN); 
string strRelationTypeId = clsRelationTypeWApi.AddNewRecordWithMaxId(objRelationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationTypeWApi.ReFreshCache();
return strRelationTypeId;
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
 /// <param name = "objRelationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRelationTypeEN objRelationTypeEN, string strWhereCond)
{
try
{
clsRelationTypeWApi.CheckPropertyNew(objRelationTypeEN); 
bool bolResult = clsRelationTypeWApi.UpdateWithCondition(objRelationTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationTypeWApi.ReFreshCache();
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
 /// 关系类型(RelationType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsRelationTypeWApi
{
private static readonly string mstrApiControllerName = "RelationTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsRelationTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_RelationTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[关系类型]...","0");
List<clsRelationTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="RelationTypeId";
objDDL.DataTextField="RelationTypeName";
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
public static void BindCbo_RelationTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conRelationType.RelationTypeId); 
List<clsRelationTypeEN> arrObjLst = clsRelationTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsRelationTypeEN objRelationTypeEN = new clsRelationTypeEN()
{
RelationTypeId = "0",
RelationTypeName = "选[关系类型]..."
};
arrObjLst.Insert(0, objRelationTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conRelationType.RelationTypeId;
objComboBox.DisplayMember = conRelationType.RelationTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsRelationTypeEN objRelationTypeEN)
{
if (!Object.Equals(null, objRelationTypeEN.RelationTypeId) && GetStrLen(objRelationTypeEN.RelationTypeId) > 8)
{
 throw new Exception("字段[关系类型Id]的长度不能超过8!");
}
if (!Object.Equals(null, objRelationTypeEN.RelationTypeName) && GetStrLen(objRelationTypeEN.RelationTypeName) > 50)
{
 throw new Exception("字段[关系类型名]的长度不能超过50!");
}
if (!Object.Equals(null, objRelationTypeEN.RelationPropName1) && GetStrLen(objRelationTypeEN.RelationPropName1) > 50)
{
 throw new Exception("字段[关系属性名1]的长度不能超过50!");
}
if (!Object.Equals(null, objRelationTypeEN.RelationPropName2) && GetStrLen(objRelationTypeEN.RelationPropName2) > 50)
{
 throw new Exception("字段[关系属性名2]的长度不能超过50!");
}
if (!Object.Equals(null, objRelationTypeEN.PrjId) && GetStrLen(objRelationTypeEN.PrjId) > 4)
{
 throw new Exception("字段[工程ID]的长度不能超过4!");
}
if (!Object.Equals(null, objRelationTypeEN.UpdDate) && GetStrLen(objRelationTypeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objRelationTypeEN.UpdUser) && GetStrLen(objRelationTypeEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objRelationTypeEN.Memo) && GetStrLen(objRelationTypeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objRelationTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRelationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRelationTypeEN GetObjByRelationTypeId(string strRelationTypeId)
{
string strAction = "GetObjByRelationTypeId";
string strErrMsg = string.Empty;
string strResult = "";
clsRelationTypeEN objRelationTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RelationTypeId"] = strRelationTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objRelationTypeEN = JsonConvert.DeserializeObject<clsRelationTypeEN>((string)jobjReturn["returnObj"]);
return objRelationTypeEN;
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
 /// <param name = "strRelationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsRelationTypeEN GetObjByRelationTypeId_WA_Cache(string strRelationTypeId)
{
string strAction = "GetObjByRelationTypeId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsRelationTypeEN objRelationTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RelationTypeId"] = strRelationTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
objRelationTypeEN = JsonConvert.DeserializeObject<clsRelationTypeEN>((string)jobjReturn["returnObj"]);
return objRelationTypeEN;
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
if ((int)jobjReturn["errorId"] == 0)
{
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsRelationTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsRelationTypeEN objRelationTypeEN = null;
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
objRelationTypeEN = JsonConvert.DeserializeObject<clsRelationTypeEN>((string)jobjReturn["returnObj"]);
return objRelationTypeEN;
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
 /// <param name = "strRelationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRelationTypeEN GetObjByRelationTypeId_Cache(string strRelationTypeId)
{
if (string.IsNullOrEmpty(strRelationTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsRelationTypeEN._CurrTabName);
List<clsRelationTypeEN> arrRelationTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsRelationTypeEN> arrRelationTypeObjLst_Sel =
from objRelationTypeEN in arrRelationTypeObjLst_Cache
where objRelationTypeEN.RelationTypeId == strRelationTypeId
select objRelationTypeEN;
if (arrRelationTypeObjLst_Sel.Count() == 0)
{
   clsRelationTypeEN obj = clsRelationTypeWApi.GetObjByRelationTypeId(strRelationTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrRelationTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strRelationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRelationTypeNameByRelationTypeId_Cache(string strRelationTypeId)
{
if (string.IsNullOrEmpty(strRelationTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsRelationTypeEN._CurrTabName);
List<clsRelationTypeEN> arrRelationTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsRelationTypeEN> arrRelationTypeObjLst_Sel1 =
from objRelationTypeEN in arrRelationTypeObjLst_Cache
where objRelationTypeEN.RelationTypeId == strRelationTypeId
select objRelationTypeEN;
List <clsRelationTypeEN> arrRelationTypeObjLst_Sel = new List<clsRelationTypeEN>();
foreach (clsRelationTypeEN obj in arrRelationTypeObjLst_Sel1)
{
arrRelationTypeObjLst_Sel.Add(obj);
}
if (arrRelationTypeObjLst_Sel.Count > 0)
{
return arrRelationTypeObjLst_Sel[0].RelationTypeName;
}
string strErrMsgForGetObjById = string.Format("在RelationType对象缓存列表中,找不到记录[RelationTypeId = {0}](函数:{1})", strRelationTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsRelationTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strRelationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRelationTypeId_Cache(string strRelationTypeId)
{
if (string.IsNullOrEmpty(strRelationTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsRelationTypeEN._CurrTabName);
List<clsRelationTypeEN> arrRelationTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsRelationTypeEN> arrRelationTypeObjLst_Sel1 =
from objRelationTypeEN in arrRelationTypeObjLst_Cache
where objRelationTypeEN.RelationTypeId == strRelationTypeId
select objRelationTypeEN;
List <clsRelationTypeEN> arrRelationTypeObjLst_Sel = new List<clsRelationTypeEN>();
foreach (clsRelationTypeEN obj in arrRelationTypeObjLst_Sel1)
{
arrRelationTypeObjLst_Sel.Add(obj);
}
if (arrRelationTypeObjLst_Sel.Count > 0)
{
return arrRelationTypeObjLst_Sel[0].RelationTypeName;
}
string strErrMsgForGetObjById = string.Format("在RelationType对象缓存列表中,找不到记录的相关名称[RelationTypeId = {0}](函数:{1})", strRelationTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsRelationTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsRelationTypeEN> GetObjLst(string strWhereCond)
{
 List<clsRelationTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsRelationTypeEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsRelationTypeEN> GetObjLstByRelationTypeIdLst(List<string> arrRelationTypeId)
{
 List<clsRelationTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByRelationTypeIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelationTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsRelationTypeEN>>((string)jobjReturn["returnObjLst"]);
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
 /// <param name = "strRelationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsRelationTypeEN> GetObjLstByRelationTypeIdLst_Cache(List<string> arrRelationTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsRelationTypeEN._CurrTabName);
List<clsRelationTypeEN> arrRelationTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsRelationTypeEN> arrRelationTypeObjLst_Sel =
from objRelationTypeEN in arrRelationTypeObjLst_Cache
where arrRelationTypeId.Contains(objRelationTypeEN.RelationTypeId)
select objRelationTypeEN;
return arrRelationTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsRelationTypeEN> GetObjLstByRelationTypeIdLst_WA_Cache(List<string> arrRelationTypeId)
{
 List<clsRelationTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByRelationTypeIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelationTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsRelationTypeEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsRelationTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsRelationTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsRelationTypeEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsRelationTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsRelationTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsRelationTypeEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsRelationTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsRelationTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsRelationTypeEN>>((string)jobjReturn["returnObjLst"]);
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
public static List<clsRelationTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsRelationTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsRelationTypeEN>>((string)jobjReturn["returnObjLst"]);
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
public static int DelRecord(string strRelationTypeId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsRelationTypeEN objRelationTypeEN = clsRelationTypeWApi.GetObjByRelationTypeId(strRelationTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strRelationTypeId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
clsRelationTypeWApi.ReFreshCache();
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
public static int DelRelationTypes(List<string> arrRelationTypeId)
{
string strAction = "DelRelationTypes";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelationTypeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
clsRelationTypeWApi.ReFreshCache();
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
public static int DelRelationTypesByCond(string strWhereCond)
{
string strAction = "DelRelationTypesByCond";
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
public static bool AddNewRecord(clsRelationTypeEN objRelationTypeEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsRelationTypeEN>(objRelationTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationTypeWApi.ReFreshCache();
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsRelationTypeEN objRelationTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsRelationTypeEN>(objRelationTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRelationTypeWApi.ReFreshCache();
var strRelationTypeId = (string)jobjReturn["returnStr"];
return strRelationTypeId;
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
public static bool UpdateRecord(clsRelationTypeEN objRelationTypeEN)
{
if (string.IsNullOrEmpty(objRelationTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objRelationTypeEN.RelationTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsRelationTypeEN>(objRelationTypeEN);
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
 /// <param name = "objRelationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsRelationTypeEN objRelationTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objRelationTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objRelationTypeEN.RelationTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objRelationTypeEN.RelationTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsRelationTypeEN>(objRelationTypeEN);
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
public static bool IsExist(string strRelationTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RelationTypeId"] = strRelationTypeId
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
if ((int)jobjReturn["errorId"] == 0)
{
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
if ((int)jobjReturn["errorId"] == 0)
{
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
 /// <param name = "objRelationTypeENS">源对象</param>
 /// <param name = "objRelationTypeENT">目标对象</param>
 public static void CopyTo(clsRelationTypeEN objRelationTypeENS, clsRelationTypeEN objRelationTypeENT)
{
try
{
objRelationTypeENT.RelationTypeId = objRelationTypeENS.RelationTypeId; //关系类型Id
objRelationTypeENT.RelationTypeName = objRelationTypeENS.RelationTypeName; //关系类型名
objRelationTypeENT.RelationPropName1 = objRelationTypeENS.RelationPropName1; //关系属性名1
objRelationTypeENT.RelationPropName2 = objRelationTypeENS.RelationPropName2; //关系属性名2
objRelationTypeENT.PrjId = objRelationTypeENS.PrjId; //工程ID
objRelationTypeENT.UpdDate = objRelationTypeENS.UpdDate; //修改日期
objRelationTypeENT.UpdUser = objRelationTypeENS.UpdUser; //修改者
objRelationTypeENT.Memo = objRelationTypeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsRelationTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsRelationTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsRelationTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsRelationTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsRelationTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsRelationTypeEN.AttributeName)
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
if (clsRelationTypeWApi.objCommFun4WApi == null)
{
strMsg = string.Format("类clsRelationTypeWApi没有刷新缓存机制(clsRelationTypeWApi.objCommFun4WApi == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RelationTypeId");
//if (arrRelationTypeObjLst_Cache == null)
//{
//arrRelationTypeObjLst_Cache = await clsRelationTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsRelationTypeEN._CurrTabName);
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
if (clsRelationTypeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsRelationTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsRelationTypeWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRelationTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsRelationTypeEN._CurrTabName);
List<clsRelationTypeEN> arrRelationTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrRelationTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsRelationTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conRelationType.RelationTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conRelationType.RelationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conRelationType.RelationPropName1, Type.GetType("System.String"));
objDT.Columns.Add(conRelationType.RelationPropName2, Type.GetType("System.String"));
objDT.Columns.Add(conRelationType.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conRelationType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conRelationType.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conRelationType.Memo, Type.GetType("System.String"));
foreach (clsRelationTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conRelationType.RelationTypeId] = objInFor[conRelationType.RelationTypeId];
objDR[conRelationType.RelationTypeName] = objInFor[conRelationType.RelationTypeName];
objDR[conRelationType.RelationPropName1] = objInFor[conRelationType.RelationPropName1];
objDR[conRelationType.RelationPropName2] = objInFor[conRelationType.RelationPropName2];
objDR[conRelationType.PrjId] = objInFor[conRelationType.PrjId];
objDR[conRelationType.UpdDate] = objInFor[conRelationType.UpdDate];
objDR[conRelationType.UpdUser] = objInFor[conRelationType.UpdUser];
objDR[conRelationType.Memo] = objInFor[conRelationType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 关系类型(RelationType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4RelationType : clsCommFun4BL
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
clsRelationTypeWApi.ReFreshThisCache();
}
}

}