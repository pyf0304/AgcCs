
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataNodeTypeWApi
 表名:DataNodeType(00050548)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:32
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
public static class  clsDataNodeTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataNodeTypeId">数据结点类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeTypeEN SetDataNodeTypeId(this clsDataNodeTypeEN objDataNodeTypeEN, string strDataNodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataNodeTypeId, 2, conDataNodeType.DataNodeTypeId);
clsCheckSql.CheckFieldForeignKey(strDataNodeTypeId, 2, conDataNodeType.DataNodeTypeId);
objDataNodeTypeEN.DataNodeTypeId = strDataNodeTypeId; //数据结点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeTypeEN.dicFldComparisonOp.ContainsKey(conDataNodeType.DataNodeTypeId) == false)
{
objDataNodeTypeEN.dicFldComparisonOp.Add(conDataNodeType.DataNodeTypeId, strComparisonOp);
}
else
{
objDataNodeTypeEN.dicFldComparisonOp[conDataNodeType.DataNodeTypeId] = strComparisonOp;
}
}
return objDataNodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataNodeTypeName">数据结点类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeTypeEN SetDataNodeTypeName(this clsDataNodeTypeEN objDataNodeTypeEN, string strDataNodeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataNodeTypeName, 50, conDataNodeType.DataNodeTypeName);
objDataNodeTypeEN.DataNodeTypeName = strDataNodeTypeName; //数据结点类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeTypeEN.dicFldComparisonOp.ContainsKey(conDataNodeType.DataNodeTypeName) == false)
{
objDataNodeTypeEN.dicFldComparisonOp.Add(conDataNodeType.DataNodeTypeName, strComparisonOp);
}
else
{
objDataNodeTypeEN.dicFldComparisonOp[conDataNodeType.DataNodeTypeName] = strComparisonOp;
}
}
return objDataNodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataNodeTypeENName">数据结点类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeTypeEN SetDataNodeTypeENName(this clsDataNodeTypeEN objDataNodeTypeEN, string strDataNodeTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataNodeTypeENName, 50, conDataNodeType.DataNodeTypeENName);
objDataNodeTypeEN.DataNodeTypeENName = strDataNodeTypeENName; //数据结点类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeTypeEN.dicFldComparisonOp.ContainsKey(conDataNodeType.DataNodeTypeENName) == false)
{
objDataNodeTypeEN.dicFldComparisonOp.Add(conDataNodeType.DataNodeTypeENName, strComparisonOp);
}
else
{
objDataNodeTypeEN.dicFldComparisonOp[conDataNodeType.DataNodeTypeENName] = strComparisonOp;
}
}
return objDataNodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeTypeEN SetUpdDate(this clsDataNodeTypeEN objDataNodeTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conDataNodeType.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDataNodeType.UpdDate);
objDataNodeTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeTypeEN.dicFldComparisonOp.ContainsKey(conDataNodeType.UpdDate) == false)
{
objDataNodeTypeEN.dicFldComparisonOp.Add(conDataNodeType.UpdDate, strComparisonOp);
}
else
{
objDataNodeTypeEN.dicFldComparisonOp[conDataNodeType.UpdDate] = strComparisonOp;
}
}
return objDataNodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeTypeEN SetUpdUser(this clsDataNodeTypeEN objDataNodeTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conDataNodeType.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDataNodeType.UpdUser);
objDataNodeTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeTypeEN.dicFldComparisonOp.ContainsKey(conDataNodeType.UpdUser) == false)
{
objDataNodeTypeEN.dicFldComparisonOp.Add(conDataNodeType.UpdUser, strComparisonOp);
}
else
{
objDataNodeTypeEN.dicFldComparisonOp[conDataNodeType.UpdUser] = strComparisonOp;
}
}
return objDataNodeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDataNodeTypeEN SetMemo(this clsDataNodeTypeEN objDataNodeTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDataNodeType.Memo);
objDataNodeTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDataNodeTypeEN.dicFldComparisonOp.ContainsKey(conDataNodeType.Memo) == false)
{
objDataNodeTypeEN.dicFldComparisonOp.Add(conDataNodeType.Memo, strComparisonOp);
}
else
{
objDataNodeTypeEN.dicFldComparisonOp[conDataNodeType.Memo] = strComparisonOp;
}
}
return objDataNodeTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDataNodeTypeEN objDataNodeTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDataNodeTypeCond.IsUpdated(conDataNodeType.DataNodeTypeId) == true)
{
string strComparisonOpDataNodeTypeId = objDataNodeTypeCond.dicFldComparisonOp[conDataNodeType.DataNodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeType.DataNodeTypeId, objDataNodeTypeCond.DataNodeTypeId, strComparisonOpDataNodeTypeId);
}
if (objDataNodeTypeCond.IsUpdated(conDataNodeType.DataNodeTypeName) == true)
{
string strComparisonOpDataNodeTypeName = objDataNodeTypeCond.dicFldComparisonOp[conDataNodeType.DataNodeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeType.DataNodeTypeName, objDataNodeTypeCond.DataNodeTypeName, strComparisonOpDataNodeTypeName);
}
if (objDataNodeTypeCond.IsUpdated(conDataNodeType.DataNodeTypeENName) == true)
{
string strComparisonOpDataNodeTypeENName = objDataNodeTypeCond.dicFldComparisonOp[conDataNodeType.DataNodeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeType.DataNodeTypeENName, objDataNodeTypeCond.DataNodeTypeENName, strComparisonOpDataNodeTypeENName);
}
if (objDataNodeTypeCond.IsUpdated(conDataNodeType.UpdDate) == true)
{
string strComparisonOpUpdDate = objDataNodeTypeCond.dicFldComparisonOp[conDataNodeType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeType.UpdDate, objDataNodeTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objDataNodeTypeCond.IsUpdated(conDataNodeType.UpdUser) == true)
{
string strComparisonOpUpdUser = objDataNodeTypeCond.dicFldComparisonOp[conDataNodeType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeType.UpdUser, objDataNodeTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objDataNodeTypeCond.IsUpdated(conDataNodeType.Memo) == true)
{
string strComparisonOpMemo = objDataNodeTypeCond.dicFldComparisonOp[conDataNodeType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDataNodeType.Memo, objDataNodeTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDataNodeTypeEN objDataNodeTypeEN)
{
 if (string.IsNullOrEmpty(objDataNodeTypeEN.DataNodeTypeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDataNodeTypeEN.sfUpdFldSetStr = objDataNodeTypeEN.getsfUpdFldSetStr();
clsDataNodeTypeWApi.CheckPropertyNew(objDataNodeTypeEN); 
bool bolResult = clsDataNodeTypeWApi.UpdateRecord(objDataNodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeWApi.ReFreshCache();
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
 /// 获取唯一性条件串--DataNodeType(数据结点类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DataNodeTypeName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsDataNodeTypeEN objDataNodeTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDataNodeTypeEN == null) return "";
if (objDataNodeTypeEN.DataNodeTypeId == null || objDataNodeTypeEN.DataNodeTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DataNodeTypeName = '{0}'", objDataNodeTypeEN.DataNodeTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("DataNodeTypeId !=  '{0}'", objDataNodeTypeEN.DataNodeTypeId);
 sbCondition.AppendFormat(" and DataNodeTypeName = '{0}'", objDataNodeTypeEN.DataNodeTypeName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDataNodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDataNodeTypeEN objDataNodeTypeEN)
{
try
{
 if (string.IsNullOrEmpty(objDataNodeTypeEN.DataNodeTypeId) == true || clsDataNodeTypeWApi.IsExist(objDataNodeTypeEN.DataNodeTypeId) == true)
 {
     objDataNodeTypeEN.DataNodeTypeId = clsDataNodeTypeWApi.GetMaxStrId();
 }
clsDataNodeTypeWApi.CheckPropertyNew(objDataNodeTypeEN); 
bool bolResult = clsDataNodeTypeWApi.AddNewRecord(objDataNodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeWApi.ReFreshCache();
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
 /// <param name = "objDataNodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsDataNodeTypeEN objDataNodeTypeEN)
{
try
{
clsDataNodeTypeWApi.CheckPropertyNew(objDataNodeTypeEN); 
string strDataNodeTypeId = clsDataNodeTypeWApi.AddNewRecordWithMaxId(objDataNodeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeWApi.ReFreshCache();
return strDataNodeTypeId;
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
 /// <param name = "objDataNodeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDataNodeTypeEN objDataNodeTypeEN, string strWhereCond)
{
try
{
clsDataNodeTypeWApi.CheckPropertyNew(objDataNodeTypeEN); 
bool bolResult = clsDataNodeTypeWApi.UpdateWithCondition(objDataNodeTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeWApi.ReFreshCache();
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
public class enumDataNodeTypeWA
{
 /// <summary>
 /// 关键字
 /// </summary>
public const string Keyword_01 = "01";
 /// <summary>
 /// 名称结点
 /// </summary>
public const string NameNode_02 = "02";
 /// <summary>
 /// 一般结点
 /// </summary>
public const string GeneralCode_03 = "03";
 /// <summary>
 /// 外键结点
 /// </summary>
public const string ForeignKeyNode_04 = "04";
 /// <summary>
 /// 未知
 /// </summary>
public const string Unknown_05 = "05";
}
 /// <summary>
 /// 数据结点类型(DataNodeType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDataNodeTypeWApi
{
private static readonly string mstrApiControllerName = "DataNodeTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsDataNodeTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DataNodeTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[数据结点类型]...","0");
List<clsDataNodeTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="DataNodeTypeId";
objDDL.DataTextField="DataNodeTypeName";
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

public static void BindCbo_DataNodeTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conDataNodeType.DataNodeTypeId); 
List<clsDataNodeTypeEN> arrObjLst = clsDataNodeTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsDataNodeTypeEN objDataNodeTypeEN = new clsDataNodeTypeEN()
{
DataNodeTypeId = "0",
DataNodeTypeName = "选[数据结点类型]..."
};
arrObjLst.Insert(0, objDataNodeTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conDataNodeType.DataNodeTypeId;
objComboBox.DisplayMember = conDataNodeType.DataNodeTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDataNodeTypeEN objDataNodeTypeEN)
{
if (!Object.Equals(null, objDataNodeTypeEN.DataNodeTypeId) && GetStrLen(objDataNodeTypeEN.DataNodeTypeId) > 2)
{
 throw new Exception("字段[数据结点类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objDataNodeTypeEN.DataNodeTypeName) && GetStrLen(objDataNodeTypeEN.DataNodeTypeName) > 50)
{
 throw new Exception("字段[数据结点类型名]的长度不能超过50!");
}
if (!Object.Equals(null, objDataNodeTypeEN.DataNodeTypeENName) && GetStrLen(objDataNodeTypeEN.DataNodeTypeENName) > 50)
{
 throw new Exception("字段[数据结点类型英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objDataNodeTypeEN.UpdDate) && GetStrLen(objDataNodeTypeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objDataNodeTypeEN.UpdUser) && GetStrLen(objDataNodeTypeEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objDataNodeTypeEN.Memo) && GetStrLen(objDataNodeTypeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objDataNodeTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDataNodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDataNodeTypeEN GetObjByDataNodeTypeId(string strDataNodeTypeId)
{
if (strDataNodeTypeId == "") return null;
string strAction = "GetObjByDataNodeTypeId";
clsDataNodeTypeEN objDataNodeTypeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDataNodeTypeId"] = strDataNodeTypeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objDataNodeTypeEN = JsonConvert.DeserializeObject<clsDataNodeTypeEN>(strJson);
return objDataNodeTypeEN;
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
public static clsDataNodeTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsDataNodeTypeEN objDataNodeTypeEN;
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
objDataNodeTypeEN = JsonConvert.DeserializeObject<clsDataNodeTypeEN>(strJson);
return objDataNodeTypeEN;
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
 /// <param name = "strDataNodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDataNodeTypeEN GetObjByDataNodeTypeIdCache(string strDataNodeTypeId)
{
if (string.IsNullOrEmpty(strDataNodeTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsDataNodeTypeEN._CurrTabName);
List<clsDataNodeTypeEN> arrDataNodeTypeObjLstCache = GetObjLstCache();
IEnumerable <clsDataNodeTypeEN> arrDataNodeTypeObjLst_Sel =
from objDataNodeTypeEN in arrDataNodeTypeObjLstCache
where objDataNodeTypeEN.DataNodeTypeId == strDataNodeTypeId 
select objDataNodeTypeEN;
if (arrDataNodeTypeObjLst_Sel.Count() == 0)
{
   clsDataNodeTypeEN obj = clsDataNodeTypeWApi.GetObjByDataNodeTypeId(strDataNodeTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDataNodeTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDataNodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDataNodeTypeNameByDataNodeTypeIdCache(string strDataNodeTypeId)
{
if (string.IsNullOrEmpty(strDataNodeTypeId) == true) return "";
//初始化列表缓存
List<clsDataNodeTypeEN> arrDataNodeTypeObjLstCache = GetObjLstCache();
IEnumerable <clsDataNodeTypeEN> arrDataNodeTypeObjLst_Sel1 =
from objDataNodeTypeEN in arrDataNodeTypeObjLstCache
where objDataNodeTypeEN.DataNodeTypeId == strDataNodeTypeId 
select objDataNodeTypeEN;
List <clsDataNodeTypeEN> arrDataNodeTypeObjLst_Sel = new List<clsDataNodeTypeEN>();
foreach (clsDataNodeTypeEN obj in arrDataNodeTypeObjLst_Sel1)
{
arrDataNodeTypeObjLst_Sel.Add(obj);
}
if (arrDataNodeTypeObjLst_Sel.Count > 0)
{
return arrDataNodeTypeObjLst_Sel[0].DataNodeTypeName;
}
string strErrMsgForGetObjById = string.Format("在DataNodeType对象缓存列表中,找不到记录[DataNodeTypeId = {0}](函数:{1})", strDataNodeTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsDataNodeTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strDataNodeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDataNodeTypeIdCache(string strDataNodeTypeId)
{
if (string.IsNullOrEmpty(strDataNodeTypeId) == true) return "";
//初始化列表缓存
List<clsDataNodeTypeEN> arrDataNodeTypeObjLstCache = GetObjLstCache();
IEnumerable <clsDataNodeTypeEN> arrDataNodeTypeObjLst_Sel1 =
from objDataNodeTypeEN in arrDataNodeTypeObjLstCache
where objDataNodeTypeEN.DataNodeTypeId == strDataNodeTypeId 
select objDataNodeTypeEN;
List <clsDataNodeTypeEN> arrDataNodeTypeObjLst_Sel = new List<clsDataNodeTypeEN>();
foreach (clsDataNodeTypeEN obj in arrDataNodeTypeObjLst_Sel1)
{
arrDataNodeTypeObjLst_Sel.Add(obj);
}
if (arrDataNodeTypeObjLst_Sel.Count > 0)
{
return arrDataNodeTypeObjLst_Sel[0].DataNodeTypeName;
}
string strErrMsgForGetObjById = string.Format("在DataNodeType对象缓存列表中,找不到记录的相关名称[DataNodeTypeId = {0}](函数:{1})", strDataNodeTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsDataNodeTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeTypeEN> GetObjLst(string strWhereCond)
{
 List<clsDataNodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeTypeEN>>(strJson);
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
 /// <param name = "arrDataNodeTypeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeTypeEN> GetObjLstByDataNodeTypeIdLst(List<string> arrDataNodeTypeId)
{
 List<clsDataNodeTypeEN> arrObjLst; 
string strAction = "GetObjLstByDataNodeTypeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDataNodeTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeTypeEN>>(strJson);
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
 /// <param name = "arrDataNodeTypeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsDataNodeTypeEN> GetObjLstByDataNodeTypeIdLstCache(List<string> arrDataNodeTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsDataNodeTypeEN._CurrTabName);
List<clsDataNodeTypeEN> arrDataNodeTypeObjLstCache = GetObjLstCache();
IEnumerable <clsDataNodeTypeEN> arrDataNodeTypeObjLst_Sel =
from objDataNodeTypeEN in arrDataNodeTypeObjLstCache
where arrDataNodeTypeId.Contains(objDataNodeTypeEN.DataNodeTypeId)
select objDataNodeTypeEN;
return arrDataNodeTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDataNodeTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDataNodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeTypeEN>>(strJson);
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
public static List<clsDataNodeTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDataNodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeTypeEN>>(strJson);
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
public static List<clsDataNodeTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDataNodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeTypeEN>>(strJson);
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
public static List<clsDataNodeTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsDataNodeTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDataNodeTypeEN>>(strJson);
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
public static int DelRecord(string strDataNodeTypeId)
{
string strAction = "DelRecord";
try
{
 clsDataNodeTypeEN objDataNodeTypeEN = clsDataNodeTypeWApi.GetObjByDataNodeTypeId(strDataNodeTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strDataNodeTypeId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDataNodeTypeWApi.ReFreshCache();
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
public static int DelDataNodeTypes(List<string> arrDataNodeTypeId)
{
string strAction = "DelDataNodeTypes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDataNodeTypeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDataNodeTypeWApi.ReFreshCache();
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
public static int DelDataNodeTypesByCond(string strWhereCond)
{
string strAction = "DelDataNodeTypesByCond";
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
public static bool AddNewRecord(clsDataNodeTypeEN objDataNodeTypeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataNodeTypeEN>(objDataNodeTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsDataNodeTypeEN objDataNodeTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataNodeTypeEN>(objDataNodeTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDataNodeTypeWApi.ReFreshCache();
var strDataNodeTypeId = (string)jobjReturn0["returnStr"];
return strDataNodeTypeId;
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
public static bool UpdateRecord(clsDataNodeTypeEN objDataNodeTypeEN)
{
if (string.IsNullOrEmpty(objDataNodeTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDataNodeTypeEN.DataNodeTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataNodeTypeEN>(objDataNodeTypeEN);
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
 /// <param name = "objDataNodeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDataNodeTypeEN objDataNodeTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDataNodeTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDataNodeTypeEN.DataNodeTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDataNodeTypeEN.DataNodeTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDataNodeTypeEN>(objDataNodeTypeEN);
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
public static bool IsExist(string strDataNodeTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strDataNodeTypeId"] = strDataNodeTypeId
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
 /// <param name = "objDataNodeTypeENS">源对象</param>
 /// <param name = "objDataNodeTypeENT">目标对象</param>
 public static void CopyTo(clsDataNodeTypeEN objDataNodeTypeENS, clsDataNodeTypeEN objDataNodeTypeENT)
{
try
{
objDataNodeTypeENT.DataNodeTypeId = objDataNodeTypeENS.DataNodeTypeId; //数据结点类型Id
objDataNodeTypeENT.DataNodeTypeName = objDataNodeTypeENS.DataNodeTypeName; //数据结点类型名
objDataNodeTypeENT.DataNodeTypeENName = objDataNodeTypeENS.DataNodeTypeENName; //数据结点类型英文名
objDataNodeTypeENT.UpdDate = objDataNodeTypeENS.UpdDate; //修改日期
objDataNodeTypeENT.UpdUser = objDataNodeTypeENS.UpdUser; //修改者
objDataNodeTypeENT.Memo = objDataNodeTypeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsDataNodeTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDataNodeTypeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDataNodeTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDataNodeTypeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDataNodeTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDataNodeTypeEN._AttributeName)
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
string strKey = string.Format("{0}", clsDataNodeTypeEN._CurrTabName);
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
if (clsDataNodeTypeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDataNodeTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDataNodeTypeWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDataNodeTypeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsDataNodeTypeEN._CurrTabName;
List<clsDataNodeTypeEN> arrDataNodeTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrDataNodeTypeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDataNodeTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDataNodeType.DataNodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeType.DataNodeTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeType.DataNodeTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeType.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conDataNodeType.Memo, Type.GetType("System.String"));
foreach (clsDataNodeTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDataNodeType.DataNodeTypeId] = objInFor[conDataNodeType.DataNodeTypeId];
objDR[conDataNodeType.DataNodeTypeName] = objInFor[conDataNodeType.DataNodeTypeName];
objDR[conDataNodeType.DataNodeTypeENName] = objInFor[conDataNodeType.DataNodeTypeENName];
objDR[conDataNodeType.UpdDate] = objInFor[conDataNodeType.UpdDate];
objDR[conDataNodeType.UpdUser] = objInFor[conDataNodeType.UpdUser];
objDR[conDataNodeType.Memo] = objInFor[conDataNodeType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 数据结点类型(DataNodeType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4DataNodeType : clsCommFun4BL
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
clsDataNodeTypeWApi.ReFreshThisCache();
}
}

}