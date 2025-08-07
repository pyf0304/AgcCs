
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCContainerTypeWApi
 表名:GCContainerType(00050563)
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
public static class  clsGCContainerTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strContainerTypeId">容器类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCContainerTypeEN SetContainerTypeId(this clsGCContainerTypeEN objGCContainerTypeEN, string strContainerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strContainerTypeId, 4, conGCContainerType.ContainerTypeId);
clsCheckSql.CheckFieldForeignKey(strContainerTypeId, 4, conGCContainerType.ContainerTypeId);
objGCContainerTypeEN.ContainerTypeId = strContainerTypeId; //容器类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCContainerTypeEN.dicFldComparisonOp.ContainsKey(conGCContainerType.ContainerTypeId) == false)
{
objGCContainerTypeEN.dicFldComparisonOp.Add(conGCContainerType.ContainerTypeId, strComparisonOp);
}
else
{
objGCContainerTypeEN.dicFldComparisonOp[conGCContainerType.ContainerTypeId] = strComparisonOp;
}
}
return objGCContainerTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strContainerTypeName">容器类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCContainerTypeEN SetContainerTypeName(this clsGCContainerTypeEN objGCContainerTypeEN, string strContainerTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strContainerTypeName, conGCContainerType.ContainerTypeName);
clsCheckSql.CheckFieldLen(strContainerTypeName, 50, conGCContainerType.ContainerTypeName);
objGCContainerTypeEN.ContainerTypeName = strContainerTypeName; //容器类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCContainerTypeEN.dicFldComparisonOp.ContainsKey(conGCContainerType.ContainerTypeName) == false)
{
objGCContainerTypeEN.dicFldComparisonOp.Add(conGCContainerType.ContainerTypeName, strComparisonOp);
}
else
{
objGCContainerTypeEN.dicFldComparisonOp[conGCContainerType.ContainerTypeName] = strComparisonOp;
}
}
return objGCContainerTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strContainerTypeENName">容器类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCContainerTypeEN SetContainerTypeENName(this clsGCContainerTypeEN objGCContainerTypeEN, string strContainerTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strContainerTypeENName, conGCContainerType.ContainerTypeENName);
clsCheckSql.CheckFieldLen(strContainerTypeENName, 50, conGCContainerType.ContainerTypeENName);
objGCContainerTypeEN.ContainerTypeENName = strContainerTypeENName; //容器类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCContainerTypeEN.dicFldComparisonOp.ContainsKey(conGCContainerType.ContainerTypeENName) == false)
{
objGCContainerTypeEN.dicFldComparisonOp.Add(conGCContainerType.ContainerTypeENName, strComparisonOp);
}
else
{
objGCContainerTypeEN.dicFldComparisonOp[conGCContainerType.ContainerTypeENName] = strComparisonOp;
}
}
return objGCContainerTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCContainerTypeEN SetUpdDate(this clsGCContainerTypeEN objGCContainerTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conGCContainerType.UpdDate);
objGCContainerTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCContainerTypeEN.dicFldComparisonOp.ContainsKey(conGCContainerType.UpdDate) == false)
{
objGCContainerTypeEN.dicFldComparisonOp.Add(conGCContainerType.UpdDate, strComparisonOp);
}
else
{
objGCContainerTypeEN.dicFldComparisonOp[conGCContainerType.UpdDate] = strComparisonOp;
}
}
return objGCContainerTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCContainerTypeEN SetUpdUser(this clsGCContainerTypeEN objGCContainerTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conGCContainerType.UpdUser);
objGCContainerTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCContainerTypeEN.dicFldComparisonOp.ContainsKey(conGCContainerType.UpdUser) == false)
{
objGCContainerTypeEN.dicFldComparisonOp.Add(conGCContainerType.UpdUser, strComparisonOp);
}
else
{
objGCContainerTypeEN.dicFldComparisonOp[conGCContainerType.UpdUser] = strComparisonOp;
}
}
return objGCContainerTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCContainerTypeEN SetMemo(this clsGCContainerTypeEN objGCContainerTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conGCContainerType.Memo);
objGCContainerTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCContainerTypeEN.dicFldComparisonOp.ContainsKey(conGCContainerType.Memo) == false)
{
objGCContainerTypeEN.dicFldComparisonOp.Add(conGCContainerType.Memo, strComparisonOp);
}
else
{
objGCContainerTypeEN.dicFldComparisonOp[conGCContainerType.Memo] = strComparisonOp;
}
}
return objGCContainerTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGCContainerTypeEN objGCContainerTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGCContainerTypeCond.IsUpdated(conGCContainerType.ContainerTypeId) == true)
{
string strComparisonOpContainerTypeId = objGCContainerTypeCond.dicFldComparisonOp[conGCContainerType.ContainerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCContainerType.ContainerTypeId, objGCContainerTypeCond.ContainerTypeId, strComparisonOpContainerTypeId);
}
if (objGCContainerTypeCond.IsUpdated(conGCContainerType.ContainerTypeName) == true)
{
string strComparisonOpContainerTypeName = objGCContainerTypeCond.dicFldComparisonOp[conGCContainerType.ContainerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCContainerType.ContainerTypeName, objGCContainerTypeCond.ContainerTypeName, strComparisonOpContainerTypeName);
}
if (objGCContainerTypeCond.IsUpdated(conGCContainerType.ContainerTypeENName) == true)
{
string strComparisonOpContainerTypeENName = objGCContainerTypeCond.dicFldComparisonOp[conGCContainerType.ContainerTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCContainerType.ContainerTypeENName, objGCContainerTypeCond.ContainerTypeENName, strComparisonOpContainerTypeENName);
}
if (objGCContainerTypeCond.IsUpdated(conGCContainerType.UpdDate) == true)
{
string strComparisonOpUpdDate = objGCContainerTypeCond.dicFldComparisonOp[conGCContainerType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCContainerType.UpdDate, objGCContainerTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objGCContainerTypeCond.IsUpdated(conGCContainerType.UpdUser) == true)
{
string strComparisonOpUpdUser = objGCContainerTypeCond.dicFldComparisonOp[conGCContainerType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCContainerType.UpdUser, objGCContainerTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objGCContainerTypeCond.IsUpdated(conGCContainerType.Memo) == true)
{
string strComparisonOpMemo = objGCContainerTypeCond.dicFldComparisonOp[conGCContainerType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCContainerType.Memo, objGCContainerTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCContainerTypeEN objGCContainerTypeEN)
{
 if (string.IsNullOrEmpty(objGCContainerTypeEN.ContainerTypeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objGCContainerTypeEN.sfUpdFldSetStr = objGCContainerTypeEN.getsfUpdFldSetStr();
clsGCContainerTypeWApi.CheckPropertyNew(objGCContainerTypeEN); 
bool bolResult = clsGCContainerTypeWApi.UpdateRecord(objGCContainerTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeWApi.ReFreshCache();
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
 /// 获取唯一性条件串--GCContainerType(GC容器类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ContainerTypeName
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsGCContainerTypeEN objGCContainerTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objGCContainerTypeEN == null) return "";
if (objGCContainerTypeEN.ContainerTypeId == null || objGCContainerTypeEN.ContainerTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ContainerTypeName = '{0}'", objGCContainerTypeEN.ContainerTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ContainerTypeId !=  '{0}'", objGCContainerTypeEN.ContainerTypeId);
 sbCondition.AppendFormat(" and ContainerTypeName = '{0}'", objGCContainerTypeEN.ContainerTypeName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGCContainerTypeEN objGCContainerTypeEN)
{
try
{
 if (string.IsNullOrEmpty(objGCContainerTypeEN.ContainerTypeId) == true || clsGCContainerTypeWApi.IsExist(objGCContainerTypeEN.ContainerTypeId) == true)
 {
     objGCContainerTypeEN.ContainerTypeId = clsGCContainerTypeWApi.GetMaxStrId();
 }
clsGCContainerTypeWApi.CheckPropertyNew(objGCContainerTypeEN); 
bool bolResult = clsGCContainerTypeWApi.AddNewRecord(objGCContainerTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeWApi.ReFreshCache();
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
 /// <param name = "objGCContainerTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsGCContainerTypeEN objGCContainerTypeEN)
{
try
{
clsGCContainerTypeWApi.CheckPropertyNew(objGCContainerTypeEN); 
string strContainerTypeId = clsGCContainerTypeWApi.AddNewRecordWithMaxId(objGCContainerTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeWApi.ReFreshCache();
return strContainerTypeId;
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
 /// <param name = "objGCContainerTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCContainerTypeEN objGCContainerTypeEN, string strWhereCond)
{
try
{
clsGCContainerTypeWApi.CheckPropertyNew(objGCContainerTypeEN); 
bool bolResult = clsGCContainerTypeWApi.UpdateWithCondition(objGCContainerTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeWApi.ReFreshCache();
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
public class enumGCContainerTypeWA
{
 /// <summary>
 /// 表格容器
 /// </summary>
public const string TableContainer_0001 = "0001";
 /// <summary>
 /// 表单控件
 /// </summary>
public const string FormControl_0002 = "0002";
 /// <summary>
 /// 行内布局
 /// </summary>
public const string FormInline_0003 = "0003";
 /// <summary>
 /// Div列表
 /// </summary>
public const string DivTable_0004 = "0004";
 /// <summary>
 /// 横向列表Li
 /// </summary>
public const string HorizontalListLi_0005 = "0005";
 /// <summary>
 /// 纵向列表Li
 /// </summary>
public const string VerticalListLi_0006 = "0006";
}
 /// <summary>
 /// GC容器类型(GCContainerType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsGCContainerTypeWApi
{
private static readonly string mstrApiControllerName = "GCContainerTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4WApi = null;

 public clsGCContainerTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ContainerTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[GC容器类型]...","0");
List<clsGCContainerTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ContainerTypeId";
objDDL.DataTextField="ContainerTypeName";
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

public static void BindCbo_ContainerTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conGCContainerType.ContainerTypeId); 
List<clsGCContainerTypeEN> arrObjLst = clsGCContainerTypeWApi.GetObjLst(strCondition).OrderBy(x=>x.ContainerTypeName).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsGCContainerTypeEN objGCContainerTypeEN = new clsGCContainerTypeEN()
{
ContainerTypeId = "0",
ContainerTypeName = "选[GC容器类型]..."
};
arrObjLst.Insert(0, objGCContainerTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conGCContainerType.ContainerTypeId;
objComboBox.DisplayMember = conGCContainerType.ContainerTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsGCContainerTypeEN objGCContainerTypeEN)
{
if (!Object.Equals(null, objGCContainerTypeEN.ContainerTypeId) && GetStrLen(objGCContainerTypeEN.ContainerTypeId) > 4)
{
 throw new Exception("字段[容器类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objGCContainerTypeEN.ContainerTypeName) && GetStrLen(objGCContainerTypeEN.ContainerTypeName) > 50)
{
 throw new Exception("字段[容器类型名]的长度不能超过50!");
}
if (!Object.Equals(null, objGCContainerTypeEN.ContainerTypeENName) && GetStrLen(objGCContainerTypeEN.ContainerTypeENName) > 50)
{
 throw new Exception("字段[容器类型英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objGCContainerTypeEN.UpdDate) && GetStrLen(objGCContainerTypeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objGCContainerTypeEN.UpdUser) && GetStrLen(objGCContainerTypeEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objGCContainerTypeEN.Memo) && GetStrLen(objGCContainerTypeEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objGCContainerTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strContainerTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCContainerTypeEN GetObjByContainerTypeId(string strContainerTypeId)
{
if (strContainerTypeId == "") return null;
string strAction = "GetObjByContainerTypeId";
clsGCContainerTypeEN objGCContainerTypeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strContainerTypeId"] = strContainerTypeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objGCContainerTypeEN = JsonConvert.DeserializeObject<clsGCContainerTypeEN>(strJson);
return objGCContainerTypeEN;
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
public static clsGCContainerTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsGCContainerTypeEN objGCContainerTypeEN;
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
objGCContainerTypeEN = JsonConvert.DeserializeObject<clsGCContainerTypeEN>(strJson);
return objGCContainerTypeEN;
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
 /// <param name = "strContainerTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCContainerTypeEN GetObjByContainerTypeIdCache(string strContainerTypeId)
{
if (string.IsNullOrEmpty(strContainerTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsGCContainerTypeEN._CurrTabName);
List<clsGCContainerTypeEN> arrGCContainerTypeObjLstCache = GetObjLstCache();
IEnumerable <clsGCContainerTypeEN> arrGCContainerTypeObjLst_Sel =
from objGCContainerTypeEN in arrGCContainerTypeObjLstCache
where objGCContainerTypeEN.ContainerTypeId == strContainerTypeId 
select objGCContainerTypeEN;
if (arrGCContainerTypeObjLst_Sel.Count() == 0)
{
   clsGCContainerTypeEN obj = clsGCContainerTypeWApi.GetObjByContainerTypeId(strContainerTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrGCContainerTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strContainerTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetContainerTypeNameByContainerTypeIdCache(string strContainerTypeId)
{
if (string.IsNullOrEmpty(strContainerTypeId) == true) return "";
//初始化列表缓存
List<clsGCContainerTypeEN> arrGCContainerTypeObjLstCache = GetObjLstCache();
IEnumerable <clsGCContainerTypeEN> arrGCContainerTypeObjLst_Sel1 =
from objGCContainerTypeEN in arrGCContainerTypeObjLstCache
where objGCContainerTypeEN.ContainerTypeId == strContainerTypeId 
select objGCContainerTypeEN;
List <clsGCContainerTypeEN> arrGCContainerTypeObjLst_Sel = new List<clsGCContainerTypeEN>();
foreach (clsGCContainerTypeEN obj in arrGCContainerTypeObjLst_Sel1)
{
arrGCContainerTypeObjLst_Sel.Add(obj);
}
if (arrGCContainerTypeObjLst_Sel.Count > 0)
{
return arrGCContainerTypeObjLst_Sel[0].ContainerTypeName;
}
string strErrMsgForGetObjById = string.Format("在GCContainerType对象缓存列表中,找不到记录[ContainerTypeId = {0}](函数:{1})", strContainerTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsGCContainerTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strContainerTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByContainerTypeIdCache(string strContainerTypeId)
{
if (string.IsNullOrEmpty(strContainerTypeId) == true) return "";
//初始化列表缓存
List<clsGCContainerTypeEN> arrGCContainerTypeObjLstCache = GetObjLstCache();
IEnumerable <clsGCContainerTypeEN> arrGCContainerTypeObjLst_Sel1 =
from objGCContainerTypeEN in arrGCContainerTypeObjLstCache
where objGCContainerTypeEN.ContainerTypeId == strContainerTypeId 
select objGCContainerTypeEN;
List <clsGCContainerTypeEN> arrGCContainerTypeObjLst_Sel = new List<clsGCContainerTypeEN>();
foreach (clsGCContainerTypeEN obj in arrGCContainerTypeObjLst_Sel1)
{
arrGCContainerTypeObjLst_Sel.Add(obj);
}
if (arrGCContainerTypeObjLst_Sel.Count > 0)
{
return arrGCContainerTypeObjLst_Sel[0].ContainerTypeName;
}
string strErrMsgForGetObjById = string.Format("在GCContainerType对象缓存列表中,找不到记录的相关名称[ContainerTypeId = {0}](函数:{1})", strContainerTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsGCContainerTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCContainerTypeEN> GetObjLst(string strWhereCond)
{
 List<clsGCContainerTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGCContainerTypeEN>>(strJson);
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
 /// <param name = "arrContainerTypeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCContainerTypeEN> GetObjLstByContainerTypeIdLst(List<string> arrContainerTypeId)
{
 List<clsGCContainerTypeEN> arrObjLst; 
string strAction = "GetObjLstByContainerTypeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrContainerTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsGCContainerTypeEN>>(strJson);
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
 /// <param name = "arrContainerTypeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsGCContainerTypeEN> GetObjLstByContainerTypeIdLstCache(List<string> arrContainerTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsGCContainerTypeEN._CurrTabName);
List<clsGCContainerTypeEN> arrGCContainerTypeObjLstCache = GetObjLstCache();
IEnumerable <clsGCContainerTypeEN> arrGCContainerTypeObjLst_Sel =
from objGCContainerTypeEN in arrGCContainerTypeObjLstCache
where arrContainerTypeId.Contains(objGCContainerTypeEN.ContainerTypeId)
select objGCContainerTypeEN;
return arrGCContainerTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCContainerTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsGCContainerTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGCContainerTypeEN>>(strJson);
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
public static List<clsGCContainerTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsGCContainerTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGCContainerTypeEN>>(strJson);
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
public static List<clsGCContainerTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsGCContainerTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGCContainerTypeEN>>(strJson);
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
public static List<clsGCContainerTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsGCContainerTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGCContainerTypeEN>>(strJson);
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
public static int DelRecord(string strContainerTypeId)
{
string strAction = "DelRecord";
try
{
 clsGCContainerTypeEN objGCContainerTypeEN = clsGCContainerTypeWApi.GetObjByContainerTypeId(strContainerTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strContainerTypeId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsGCContainerTypeWApi.ReFreshCache();
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
public static int DelGCContainerTypes(List<string> arrContainerTypeId)
{
string strAction = "DelGCContainerTypes";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrContainerTypeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsGCContainerTypeWApi.ReFreshCache();
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
public static int DelGCContainerTypesByCond(string strWhereCond)
{
string strAction = "DelGCContainerTypesByCond";
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
public static bool AddNewRecord(clsGCContainerTypeEN objGCContainerTypeEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGCContainerTypeEN>(objGCContainerTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsGCContainerTypeEN objGCContainerTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGCContainerTypeEN>(objGCContainerTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCContainerTypeWApi.ReFreshCache();
var strContainerTypeId = (string)jobjReturn0["returnStr"];
return strContainerTypeId;
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
public static bool UpdateRecord(clsGCContainerTypeEN objGCContainerTypeEN)
{
if (string.IsNullOrEmpty(objGCContainerTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objGCContainerTypeEN.ContainerTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGCContainerTypeEN>(objGCContainerTypeEN);
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
 /// <param name = "objGCContainerTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsGCContainerTypeEN objGCContainerTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objGCContainerTypeEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objGCContainerTypeEN.ContainerTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objGCContainerTypeEN.ContainerTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGCContainerTypeEN>(objGCContainerTypeEN);
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
public static bool IsExist(string strContainerTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strContainerTypeId"] = strContainerTypeId
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
 /// <param name = "objGCContainerTypeENS">源对象</param>
 /// <param name = "objGCContainerTypeENT">目标对象</param>
 public static void CopyTo(clsGCContainerTypeEN objGCContainerTypeENS, clsGCContainerTypeEN objGCContainerTypeENT)
{
try
{
objGCContainerTypeENT.ContainerTypeId = objGCContainerTypeENS.ContainerTypeId; //容器类型Id
objGCContainerTypeENT.ContainerTypeName = objGCContainerTypeENS.ContainerTypeName; //容器类型名
objGCContainerTypeENT.ContainerTypeENName = objGCContainerTypeENS.ContainerTypeENName; //容器类型英文名
objGCContainerTypeENT.UpdDate = objGCContainerTypeENS.UpdDate; //修改日期
objGCContainerTypeENT.UpdUser = objGCContainerTypeENS.UpdUser; //修改者
objGCContainerTypeENT.Memo = objGCContainerTypeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsGCContainerTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsGCContainerTypeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsGCContainerTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsGCContainerTypeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsGCContainerTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsGCContainerTypeEN._AttributeName)
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
string strKey = string.Format("{0}", clsGCContainerTypeEN._CurrTabName);
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
if (clsGCContainerTypeWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsGCContainerTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGCContainerTypeWApi.objCommFun4WApi.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCContainerTypeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsGCContainerTypeEN._CurrTabName;
List<clsGCContainerTypeEN> arrGCContainerTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrGCContainerTypeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsGCContainerTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conGCContainerType.ContainerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conGCContainerType.ContainerTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conGCContainerType.ContainerTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(conGCContainerType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conGCContainerType.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conGCContainerType.Memo, Type.GetType("System.String"));
foreach (clsGCContainerTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conGCContainerType.ContainerTypeId] = objInFor[conGCContainerType.ContainerTypeId];
objDR[conGCContainerType.ContainerTypeName] = objInFor[conGCContainerType.ContainerTypeName];
objDR[conGCContainerType.ContainerTypeENName] = objInFor[conGCContainerType.ContainerTypeENName];
objDR[conGCContainerType.UpdDate] = objInFor[conGCContainerType.UpdDate];
objDR[conGCContainerType.UpdUser] = objInFor[conGCContainerType.UpdUser];
objDR[conGCContainerType.Memo] = objInFor[conGCContainerType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// GC容器类型(GCContainerType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4GCContainerType : clsCommFun4BL
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
clsGCContainerTypeWApi.ReFreshThisCache();
}
}

}