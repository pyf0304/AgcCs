
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProgLangTypeWApi
 表名:vProgLangType(00050405)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 22:07:07
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
public static class  clsvProgLangTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeId">编程语言类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetProgLangTypeId(this clsvProgLangTypeEN objvProgLangTypeEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convProgLangType.ProgLangTypeId);
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convProgLangType.ProgLangTypeId);
objvProgLangTypeEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.ProgLangTypeId) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.ProgLangTypeId, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.ProgLangTypeId] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeName">编程语言类型名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetProgLangTypeName(this clsvProgLangTypeEN objvProgLangTypeEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convProgLangType.ProgLangTypeName);
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convProgLangType.ProgLangTypeName);
objvProgLangTypeEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.ProgLangTypeName) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.ProgLangTypeName, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.ProgLangTypeName] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strProgLangTypeENName">编程语言类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetProgLangTypeENName(this clsvProgLangTypeEN objvProgLangTypeEN, string strProgLangTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProgLangTypeENName, 50, convProgLangType.ProgLangTypeENName);
objvProgLangTypeEN.ProgLangTypeENName = strProgLangTypeENName; //编程语言类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.ProgLangTypeENName) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.ProgLangTypeENName, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.ProgLangTypeENName] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCharEncodingId">字符编码</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetCharEncodingId(this clsvProgLangTypeEN objvProgLangTypeEN, string strCharEncodingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCharEncodingId, convProgLangType.CharEncodingId);
clsCheckSql.CheckFieldLen(strCharEncodingId, 20, convProgLangType.CharEncodingId);
objvProgLangTypeEN.CharEncodingId = strCharEncodingId; //字符编码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.CharEncodingId) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.CharEncodingId, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.CharEncodingId] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strCharEncodingName">字符编码名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetCharEncodingName(this clsvProgLangTypeEN objvProgLangTypeEN, string strCharEncodingName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCharEncodingName, convProgLangType.CharEncodingName);
clsCheckSql.CheckFieldLen(strCharEncodingName, 100, convProgLangType.CharEncodingName);
objvProgLangTypeEN.CharEncodingName = strCharEncodingName; //字符编码名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.CharEncodingName) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.CharEncodingName, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.CharEncodingName] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetIsVisible(this clsvProgLangTypeEN objvProgLangTypeEN, bool bolIsVisible, string strComparisonOp="")
	{
objvProgLangTypeEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.IsVisible) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.IsVisible, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.IsVisible] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetOrderNum(this clsvProgLangTypeEN objvProgLangTypeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convProgLangType.OrderNum);
objvProgLangTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.OrderNum) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.OrderNum, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.OrderNum] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetUpdDate(this clsvProgLangTypeEN objvProgLangTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convProgLangType.UpdDate);
objvProgLangTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.UpdDate) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.UpdDate, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.UpdDate] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUserId">修改用户Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetUpdUserId(this clsvProgLangTypeEN objvProgLangTypeEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convProgLangType.UpdUserId);
objvProgLangTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.UpdUserId) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.UpdUserId, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.UpdUserId] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProgLangTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProgLangTypeEN SetMemo(this clsvProgLangTypeEN objvProgLangTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convProgLangType.Memo);
objvProgLangTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProgLangTypeEN.dicFldComparisonOp.ContainsKey(convProgLangType.Memo) == false)
{
objvProgLangTypeEN.dicFldComparisonOp.Add(convProgLangType.Memo, strComparisonOp);
}
else
{
objvProgLangTypeEN.dicFldComparisonOp[convProgLangType.Memo] = strComparisonOp;
}
}
return objvProgLangTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvProgLangTypeEN objvProgLangTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvProgLangTypeCond.IsUpdated(convProgLangType.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.ProgLangTypeId, objvProgLangTypeCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.ProgLangTypeName, objvProgLangTypeCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.ProgLangTypeENName) == true)
{
string strComparisonOpProgLangTypeENName = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.ProgLangTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.ProgLangTypeENName, objvProgLangTypeCond.ProgLangTypeENName, strComparisonOpProgLangTypeENName);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.CharEncodingId) == true)
{
string strComparisonOpCharEncodingId = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.CharEncodingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.CharEncodingId, objvProgLangTypeCond.CharEncodingId, strComparisonOpCharEncodingId);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.CharEncodingName) == true)
{
string strComparisonOpCharEncodingName = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.CharEncodingName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.CharEncodingName, objvProgLangTypeCond.CharEncodingName, strComparisonOpCharEncodingName);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.IsVisible) == true)
{
if (objvProgLangTypeCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convProgLangType.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convProgLangType.IsVisible);
}
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.OrderNum) == true)
{
string strComparisonOpOrderNum = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convProgLangType.OrderNum, objvProgLangTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.UpdDate) == true)
{
string strComparisonOpUpdDate = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.UpdDate, objvProgLangTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.UpdUserId, objvProgLangTypeCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvProgLangTypeCond.IsUpdated(convProgLangType.Memo) == true)
{
string strComparisonOpMemo = objvProgLangTypeCond.dicFldComparisonOp[convProgLangType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProgLangType.Memo, objvProgLangTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public class enumvProgLangTypeWA
{
 /// <summary>
 /// AA0
 /// </summary>
public const string AA0_00 = "00";
 /// <summary>
 /// CSharp
 /// </summary>
public const string CSharp_01 = "01";
 /// <summary>
 /// JAVA
 /// </summary>
public const string JAVA_02 = "02";
 /// <summary>
 /// Swift
 /// </summary>
public const string Swift_03 = "03";
 /// <summary>
 /// JavaScript
 /// </summary>
public const string JavaScript_04 = "04";
 /// <summary>
 /// SilverLight
 /// </summary>
public const string SilverLight_05 = "05";
 /// <summary>
 /// VB
 /// </summary>
public const string VB_06 = "06";
 /// <summary>
 /// Swift3
 /// </summary>
public const string Swift3_07 = "07";
 /// <summary>
 /// Swift4
 /// </summary>
public const string Swift4_08 = "08";
 /// <summary>
 /// TypeScript
 /// </summary>
public const string TypeScript_09 = "09";
 /// <summary>
 /// Html
 /// </summary>
public const string Html_10 = "10";
}
 /// <summary>
 /// v编程语言类型(vProgLangType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvProgLangTypeWApi
{
private static readonly string mstrApiControllerName = "vProgLangTypeApi";

 public clsvProgLangTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ProgLangTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v编程语言类型]...","0");
List<clsvProgLangTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ProgLangTypeId";
objDDL.DataTextField="ProgLangTypeName";
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

public static void BindCbo_ProgLangTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convProgLangType.ProgLangTypeId); 
List<clsvProgLangTypeEN> arrObjLst = clsvProgLangTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvProgLangTypeEN objvProgLangTypeEN = new clsvProgLangTypeEN()
{
ProgLangTypeId = "0",
ProgLangTypeName = "选[v编程语言类型]..."
};
arrObjLst.Insert(0, objvProgLangTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convProgLangType.ProgLangTypeId;
objComboBox.DisplayMember = convProgLangType.ProgLangTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strProgLangTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvProgLangTypeEN GetObjByProgLangTypeId(string strProgLangTypeId)
{
if (strProgLangTypeId == "") return null;
string strAction = "GetObjByProgLangTypeId";
clsvProgLangTypeEN objvProgLangTypeEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strProgLangTypeId"] = strProgLangTypeId,
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvProgLangTypeEN = JsonConvert.DeserializeObject<clsvProgLangTypeEN>(strJson);
return objvProgLangTypeEN;
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
public static clsvProgLangTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvProgLangTypeEN objvProgLangTypeEN;
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
objvProgLangTypeEN = JsonConvert.DeserializeObject<clsvProgLangTypeEN>(strJson);
return objvProgLangTypeEN;
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
 /// <param name = "strProgLangTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvProgLangTypeEN GetObjByProgLangTypeIdCache(string strProgLangTypeId)
{
if (string.IsNullOrEmpty(strProgLangTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvProgLangTypeEN._CurrTabName);
List<clsvProgLangTypeEN> arrvProgLangTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvProgLangTypeEN> arrvProgLangTypeObjLst_Sel =
from objvProgLangTypeEN in arrvProgLangTypeObjLstCache
where objvProgLangTypeEN.ProgLangTypeId == strProgLangTypeId 
select objvProgLangTypeEN;
if (arrvProgLangTypeObjLst_Sel.Count() == 0)
{
   clsvProgLangTypeEN obj = clsvProgLangTypeWApi.GetObjByProgLangTypeId(strProgLangTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvProgLangTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strProgLangTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetProgLangTypeNameByProgLangTypeIdCache(string strProgLangTypeId)
{
if (string.IsNullOrEmpty(strProgLangTypeId) == true) return "";
//初始化列表缓存
List<clsvProgLangTypeEN> arrvProgLangTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvProgLangTypeEN> arrvProgLangTypeObjLst_Sel1 =
from objvProgLangTypeEN in arrvProgLangTypeObjLstCache
where objvProgLangTypeEN.ProgLangTypeId == strProgLangTypeId 
select objvProgLangTypeEN;
List <clsvProgLangTypeEN> arrvProgLangTypeObjLst_Sel = new List<clsvProgLangTypeEN>();
foreach (clsvProgLangTypeEN obj in arrvProgLangTypeObjLst_Sel1)
{
arrvProgLangTypeObjLst_Sel.Add(obj);
}
if (arrvProgLangTypeObjLst_Sel.Count > 0)
{
return arrvProgLangTypeObjLst_Sel[0].ProgLangTypeName;
}
string strErrMsgForGetObjById = string.Format("在vProgLangType对象缓存列表中,找不到记录[ProgLangTypeId = {0}](函数:{1})", strProgLangTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvProgLangTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strProgLangTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByProgLangTypeIdCache(string strProgLangTypeId)
{
if (string.IsNullOrEmpty(strProgLangTypeId) == true) return "";
//初始化列表缓存
List<clsvProgLangTypeEN> arrvProgLangTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvProgLangTypeEN> arrvProgLangTypeObjLst_Sel1 =
from objvProgLangTypeEN in arrvProgLangTypeObjLstCache
where objvProgLangTypeEN.ProgLangTypeId == strProgLangTypeId 
select objvProgLangTypeEN;
List <clsvProgLangTypeEN> arrvProgLangTypeObjLst_Sel = new List<clsvProgLangTypeEN>();
foreach (clsvProgLangTypeEN obj in arrvProgLangTypeObjLst_Sel1)
{
arrvProgLangTypeObjLst_Sel.Add(obj);
}
if (arrvProgLangTypeObjLst_Sel.Count > 0)
{
return arrvProgLangTypeObjLst_Sel[0].ProgLangTypeName;
}
string strErrMsgForGetObjById = string.Format("在vProgLangType对象缓存列表中,找不到记录的相关名称[ProgLangTypeId = {0}](函数:{1})", strProgLangTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvProgLangTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProgLangTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvProgLangTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProgLangTypeEN>>(strJson);
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
 /// <param name = "arrProgLangTypeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProgLangTypeEN> GetObjLstByProgLangTypeIdLst(List<string> arrProgLangTypeId)
{
 List<clsvProgLangTypeEN> arrObjLst; 
string strAction = "GetObjLstByProgLangTypeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrProgLangTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvProgLangTypeEN>>(strJson);
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
 /// <param name = "arrProgLangTypeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvProgLangTypeEN> GetObjLstByProgLangTypeIdLstCache(List<string> arrProgLangTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvProgLangTypeEN._CurrTabName);
List<clsvProgLangTypeEN> arrvProgLangTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvProgLangTypeEN> arrvProgLangTypeObjLst_Sel =
from objvProgLangTypeEN in arrvProgLangTypeObjLstCache
where arrProgLangTypeId.Contains(objvProgLangTypeEN.ProgLangTypeId)
select objvProgLangTypeEN;
return arrvProgLangTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProgLangTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvProgLangTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProgLangTypeEN>>(strJson);
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
public static List<clsvProgLangTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvProgLangTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProgLangTypeEN>>(strJson);
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
public static List<clsvProgLangTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvProgLangTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProgLangTypeEN>>(strJson);
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
public static List<clsvProgLangTypeEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvProgLangTypeEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvProgLangTypeEN>>(strJson);
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
public static bool IsExist(string strProgLangTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strProgLangTypeId"] = strProgLangTypeId
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvProgLangTypeENS">源对象</param>
 /// <param name = "objvProgLangTypeENT">目标对象</param>
 public static void CopyTo(clsvProgLangTypeEN objvProgLangTypeENS, clsvProgLangTypeEN objvProgLangTypeENT)
{
try
{
objvProgLangTypeENT.ProgLangTypeId = objvProgLangTypeENS.ProgLangTypeId; //编程语言类型Id
objvProgLangTypeENT.ProgLangTypeName = objvProgLangTypeENS.ProgLangTypeName; //编程语言类型名
objvProgLangTypeENT.ProgLangTypeENName = objvProgLangTypeENS.ProgLangTypeENName; //编程语言类型英文名
objvProgLangTypeENT.CharEncodingId = objvProgLangTypeENS.CharEncodingId; //字符编码
objvProgLangTypeENT.CharEncodingName = objvProgLangTypeENS.CharEncodingName; //字符编码名称
objvProgLangTypeENT.IsVisible = objvProgLangTypeENS.IsVisible; //是否显示
objvProgLangTypeENT.OrderNum = objvProgLangTypeENS.OrderNum; //序号
objvProgLangTypeENT.UpdDate = objvProgLangTypeENS.UpdDate; //修改日期
objvProgLangTypeENT.UpdUserId = objvProgLangTypeENS.UpdUserId; //修改用户Id
objvProgLangTypeENT.Memo = objvProgLangTypeENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsvProgLangTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvProgLangTypeEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvProgLangTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvProgLangTypeEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvProgLangTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvProgLangTypeEN._AttributeName)
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
string strKey = string.Format("{0}", clsvProgLangTypeEN._CurrTabName);
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
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvProgLangTypeEN> GetObjLstCache()
{

//初始化列表缓存
var strWhereCond = "1=1";
var strKey = clsvProgLangTypeEN._CurrTabName;
List<clsvProgLangTypeEN> arrvProgLangTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvProgLangTypeObjLstCache;
}
//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvProgLangTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convProgLangType.ProgLangTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convProgLangType.ProgLangTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convProgLangType.ProgLangTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convProgLangType.CharEncodingId, Type.GetType("System.String"));
objDT.Columns.Add(convProgLangType.CharEncodingName, Type.GetType("System.String"));
objDT.Columns.Add(convProgLangType.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convProgLangType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convProgLangType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convProgLangType.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convProgLangType.Memo, Type.GetType("System.String"));
foreach (clsvProgLangTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convProgLangType.ProgLangTypeId] = objInFor[convProgLangType.ProgLangTypeId];
objDR[convProgLangType.ProgLangTypeName] = objInFor[convProgLangType.ProgLangTypeName];
objDR[convProgLangType.ProgLangTypeENName] = objInFor[convProgLangType.ProgLangTypeENName];
objDR[convProgLangType.CharEncodingId] = objInFor[convProgLangType.CharEncodingId];
objDR[convProgLangType.CharEncodingName] = objInFor[convProgLangType.CharEncodingName];
objDR[convProgLangType.IsVisible] = objInFor[convProgLangType.IsVisible];
objDR[convProgLangType.OrderNum] = objInFor[convProgLangType.OrderNum];
objDR[convProgLangType.UpdDate] = objInFor[convProgLangType.UpdDate];
objDR[convProgLangType.UpdUserId] = objInFor[convProgLangType.UpdUserId];
objDR[convProgLangType.Memo] = objInFor[convProgLangType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}