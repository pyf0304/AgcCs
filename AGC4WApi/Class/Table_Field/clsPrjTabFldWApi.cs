
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabFldWApi
 表名:PrjTabFld(00050019)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:05
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsPrjTabFldWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetmId(this clsPrjTabFldEN objPrjTabFldEN, long lngmId, string strComparisonOp="")
	{
objPrjTabFldEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.mId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.mId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.mId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetTabId(this clsPrjTabFldEN objPrjTabFldEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conPrjTabFld.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, conPrjTabFld.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conPrjTabFld.TabId);
objPrjTabFldEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.TabId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.TabId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.TabId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetFldId(this clsPrjTabFldEN objPrjTabFldEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, conPrjTabFld.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, conPrjTabFld.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conPrjTabFld.FldId);
objPrjTabFldEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.FldId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.FldId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.FldId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetPrjId(this clsPrjTabFldEN objPrjTabFldEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conPrjTabFld.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conPrjTabFld.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conPrjTabFld.PrjId);
objPrjTabFldEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.PrjId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.PrjId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.PrjId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFieldTypeId">字段类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetFieldTypeId(this clsPrjTabFldEN objPrjTabFldEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldTypeId, conPrjTabFld.FieldTypeId);
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, conPrjTabFld.FieldTypeId);
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, conPrjTabFld.FieldTypeId);
objPrjTabFldEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.FieldTypeId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.FieldTypeId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.FieldTypeId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTabNullable">是否表中可空</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetIsTabNullable(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsTabNullable, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsTabNullable, conPrjTabFld.IsTabNullable);
objPrjTabFldEN.IsTabNullable = bolIsTabNullable; //是否表中可空
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.IsTabNullable) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.IsTabNullable, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.IsTabNullable] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTabUnique">是否表中唯一</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetIsTabUnique(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsTabUnique, string strComparisonOp="")
	{
objPrjTabFldEN.IsTabUnique = bolIsTabUnique; //是否表中唯一
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.IsTabUnique) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.IsTabUnique, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.IsTabUnique] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTabForeignKey">是否表外键</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetIsTabForeignKey(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsTabForeignKey, string strComparisonOp="")
	{
objPrjTabFldEN.IsTabForeignKey = bolIsTabForeignKey; //是否表外键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.IsTabForeignKey) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.IsTabForeignKey, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.IsTabForeignKey] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSortFld">是否排序字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetIsSortFld(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsSortFld, string strComparisonOp="")
	{
objPrjTabFldEN.IsSortFld = bolIsSortFld; //是否排序字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.IsSortFld) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.IsSortFld, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.IsSortFld] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsGeneProp">是否生成属性</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetIsGeneProp(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsGeneProp, string strComparisonOp="")
	{
objPrjTabFldEN.IsGeneProp = bolIsGeneProp; //是否生成属性
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.IsGeneProp) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.IsGeneProp, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.IsGeneProp] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsForExtendClass">用于扩展类</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetIsForExtendClass(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsForExtendClass, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsForExtendClass, conPrjTabFld.IsForExtendClass);
objPrjTabFldEN.IsForExtendClass = bolIsForExtendClass; //用于扩展类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.IsForExtendClass) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.IsForExtendClass, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.IsForExtendClass] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeIdDu">控件类型Id_du</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetCtlTypeIdDu(this clsPrjTabFldEN objPrjTabFldEN, string strCtlTypeIdDu, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCtlTypeIdDu, 2, conPrjTabFld.CtlTypeIdDu);
clsCheckSql.CheckFieldForeignKey(strCtlTypeIdDu, 2, conPrjTabFld.CtlTypeIdDu);
objPrjTabFldEN.CtlTypeIdDu = strCtlTypeIdDu; //控件类型Id_du
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.CtlTypeIdDu) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.CtlTypeIdDu, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.CtlTypeIdDu] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldDispUnitStyleId">字段显示单元样式Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetFldDispUnitStyleId(this clsPrjTabFldEN objPrjTabFldEN, string strFldDispUnitStyleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldDispUnitStyleId, 8, conPrjTabFld.FldDispUnitStyleId);
clsCheckSql.CheckFieldForeignKey(strFldDispUnitStyleId, 8, conPrjTabFld.FldDispUnitStyleId);
objPrjTabFldEN.FldDispUnitStyleId = strFldDispUnitStyleId; //字段显示单元样式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.FldDispUnitStyleId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.FldDispUnitStyleId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.FldDispUnitStyleId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strInFldId">In字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetInFldId(this clsPrjTabFldEN objPrjTabFldEN, string strInFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strInFldId, 8, conPrjTabFld.InFldId);
clsCheckSql.CheckFieldForeignKey(strInFldId, 8, conPrjTabFld.InFldId);
objPrjTabFldEN.InFldId = strInFldId; //In字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.InFldId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.InFldId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.InFldId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strDnPathId">DN路径Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetDnPathId(this clsPrjTabFldEN objPrjTabFldEN, string strDnPathId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDnPathId, 8, conPrjTabFld.DnPathId);
clsCheckSql.CheckFieldForeignKey(strDnPathId, 8, conPrjTabFld.DnPathId);
objPrjTabFldEN.DnPathId = strDnPathId; //DN路径Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.DnPathId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.DnPathId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.DnPathId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyId4Test">测试关键字Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetKeyId4Test(this clsPrjTabFldEN objPrjTabFldEN, string strKeyId4Test, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyId4Test, 50, conPrjTabFld.KeyId4Test);
objPrjTabFldEN.KeyId4Test = strKeyId4Test; //测试关键字Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.KeyId4Test) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.KeyId4Test, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.KeyId4Test] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strDisplayFormat">显示格式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetDisplayFormat(this clsPrjTabFldEN objPrjTabFldEN, string strDisplayFormat, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDisplayFormat, 50, conPrjTabFld.DisplayFormat);
objPrjTabFldEN.DisplayFormat = strDisplayFormat; //显示格式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.DisplayFormat) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.DisplayFormat, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.DisplayFormat] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsParentObj">是否父对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetIsParentObj(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsParentObj, string strComparisonOp="")
	{
objPrjTabFldEN.IsParentObj = bolIsParentObj; //是否父对象
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.IsParentObj) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.IsParentObj, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.IsParentObj] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrimaryTypeId">主键类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetPrimaryTypeId(this clsPrjTabFldEN objPrjTabFldEN, string strPrimaryTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryTypeId, conPrjTabFld.PrimaryTypeId);
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, conPrjTabFld.PrimaryTypeId);
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, conPrjTabFld.PrimaryTypeId);
objPrjTabFldEN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.PrimaryTypeId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.PrimaryTypeId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.PrimaryTypeId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strForeignKeyTabId">外键表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetForeignKeyTabId(this clsPrjTabFldEN objPrjTabFldEN, string strForeignKeyTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strForeignKeyTabId, 8, conPrjTabFld.ForeignKeyTabId);
clsCheckSql.CheckFieldForeignKey(strForeignKeyTabId, 8, conPrjTabFld.ForeignKeyTabId);
objPrjTabFldEN.ForeignKeyTabId = strForeignKeyTabId; //外键表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.ForeignKeyTabId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.ForeignKeyTabId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.ForeignKeyTabId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldOpTypeId">字段操作类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetFldOpTypeId(this clsPrjTabFldEN objPrjTabFldEN, string strFldOpTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldOpTypeId, conPrjTabFld.FldOpTypeId);
clsCheckSql.CheckFieldLen(strFldOpTypeId, 4, conPrjTabFld.FldOpTypeId);
clsCheckSql.CheckFieldForeignKey(strFldOpTypeId, 4, conPrjTabFld.FldOpTypeId);
objPrjTabFldEN.FldOpTypeId = strFldOpTypeId; //字段操作类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.FldOpTypeId) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.FldOpTypeId, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.FldOpTypeId] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "intSequenceNumber">顺序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetSequenceNumber(this clsPrjTabFldEN objPrjTabFldEN, int intSequenceNumber, string strComparisonOp="")
	{
objPrjTabFldEN.SequenceNumber = intSequenceNumber; //顺序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.SequenceNumber) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.SequenceNumber, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.SequenceNumber] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemoInTab">表中说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetMemoInTab(this clsPrjTabFldEN objPrjTabFldEN, string strMemoInTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemoInTab, 1000, conPrjTabFld.MemoInTab);
objPrjTabFldEN.MemoInTab = strMemoInTab; //表中说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.MemoInTab) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.MemoInTab, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.MemoInTab] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetErrMsg(this clsPrjTabFldEN objPrjTabFldEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conPrjTabFld.ErrMsg);
objPrjTabFldEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.ErrMsg) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.ErrMsg, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.ErrMsg] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetUpdDate(this clsPrjTabFldEN objPrjTabFldEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPrjTabFld.UpdDate);
objPrjTabFldEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.UpdDate) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.UpdDate, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.UpdDate] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetUpdUser(this clsPrjTabFldEN objPrjTabFldEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conPrjTabFld.UpdUser);
objPrjTabFldEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.UpdUser) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.UpdUser, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.UpdUser] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPrjTabFldEN SetMemo(this clsPrjTabFldEN objPrjTabFldEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPrjTabFld.Memo);
objPrjTabFldEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPrjTabFldEN.dicFldComparisonOp.ContainsKey(conPrjTabFld.Memo) == false)
{
objPrjTabFldEN.dicFldComparisonOp.Add(conPrjTabFld.Memo, strComparisonOp);
}
else
{
objPrjTabFldEN.dicFldComparisonOp[conPrjTabFld.Memo] = strComparisonOp;
}
}
return objPrjTabFldEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPrjTabFldEN objPrjTabFldCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.mId) == true)
{
string strComparisonOpmId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conPrjTabFld.mId, objPrjTabFldCond.mId, strComparisonOpmId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.TabId) == true)
{
string strComparisonOpTabId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.TabId, objPrjTabFldCond.TabId, strComparisonOpTabId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.FldId) == true)
{
string strComparisonOpFldId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.FldId, objPrjTabFldCond.FldId, strComparisonOpFldId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.PrjId) == true)
{
string strComparisonOpPrjId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.PrjId, objPrjTabFldCond.PrjId, strComparisonOpPrjId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.FieldTypeId, objPrjTabFldCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.IsTabNullable) == true)
{
if (objPrjTabFldCond.IsTabNullable == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabFld.IsTabNullable);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabFld.IsTabNullable);
}
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.IsTabUnique) == true)
{
if (objPrjTabFldCond.IsTabUnique == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabFld.IsTabUnique);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabFld.IsTabUnique);
}
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.IsTabForeignKey) == true)
{
if (objPrjTabFldCond.IsTabForeignKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabFld.IsTabForeignKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabFld.IsTabForeignKey);
}
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.IsSortFld) == true)
{
if (objPrjTabFldCond.IsSortFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabFld.IsSortFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabFld.IsSortFld);
}
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.IsGeneProp) == true)
{
if (objPrjTabFldCond.IsGeneProp == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabFld.IsGeneProp);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabFld.IsGeneProp);
}
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.IsForExtendClass) == true)
{
if (objPrjTabFldCond.IsForExtendClass == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabFld.IsForExtendClass);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabFld.IsForExtendClass);
}
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.CtlTypeIdDu) == true)
{
string strComparisonOpCtlTypeIdDu = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.CtlTypeIdDu];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.CtlTypeIdDu, objPrjTabFldCond.CtlTypeIdDu, strComparisonOpCtlTypeIdDu);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.FldDispUnitStyleId) == true)
{
string strComparisonOpFldDispUnitStyleId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.FldDispUnitStyleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.FldDispUnitStyleId, objPrjTabFldCond.FldDispUnitStyleId, strComparisonOpFldDispUnitStyleId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.InFldId) == true)
{
string strComparisonOpInFldId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.InFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.InFldId, objPrjTabFldCond.InFldId, strComparisonOpInFldId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.DnPathId) == true)
{
string strComparisonOpDnPathId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.DnPathId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.DnPathId, objPrjTabFldCond.DnPathId, strComparisonOpDnPathId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.KeyId4Test) == true)
{
string strComparisonOpKeyId4Test = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.KeyId4Test];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.KeyId4Test, objPrjTabFldCond.KeyId4Test, strComparisonOpKeyId4Test);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.DisplayFormat) == true)
{
string strComparisonOpDisplayFormat = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.DisplayFormat];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.DisplayFormat, objPrjTabFldCond.DisplayFormat, strComparisonOpDisplayFormat);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.IsParentObj) == true)
{
if (objPrjTabFldCond.IsParentObj == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPrjTabFld.IsParentObj);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPrjTabFld.IsParentObj);
}
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.PrimaryTypeId, objPrjTabFldCond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.ForeignKeyTabId) == true)
{
string strComparisonOpForeignKeyTabId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.ForeignKeyTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.ForeignKeyTabId, objPrjTabFldCond.ForeignKeyTabId, strComparisonOpForeignKeyTabId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.FldOpTypeId) == true)
{
string strComparisonOpFldOpTypeId = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.FldOpTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.FldOpTypeId, objPrjTabFldCond.FldOpTypeId, strComparisonOpFldOpTypeId);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.SequenceNumber) == true)
{
string strComparisonOpSequenceNumber = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.SequenceNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conPrjTabFld.SequenceNumber, objPrjTabFldCond.SequenceNumber, strComparisonOpSequenceNumber);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.MemoInTab) == true)
{
string strComparisonOpMemoInTab = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.MemoInTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.MemoInTab, objPrjTabFldCond.MemoInTab, strComparisonOpMemoInTab);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.ErrMsg) == true)
{
string strComparisonOpErrMsg = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.ErrMsg, objPrjTabFldCond.ErrMsg, strComparisonOpErrMsg);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.UpdDate) == true)
{
string strComparisonOpUpdDate = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.UpdDate, objPrjTabFldCond.UpdDate, strComparisonOpUpdDate);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.UpdUser) == true)
{
string strComparisonOpUpdUser = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.UpdUser, objPrjTabFldCond.UpdUser, strComparisonOpUpdUser);
}
if (objPrjTabFldCond.IsUpdated(conPrjTabFld.Memo) == true)
{
string strComparisonOpMemo = objPrjTabFldCond.dicFldComparisonOp[conPrjTabFld.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPrjTabFld.Memo, objPrjTabFldCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPrjTabFldEN objPrjTabFldEN)
{
 if (objPrjTabFldEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objPrjTabFldEN.sfUpdFldSetStr = objPrjTabFldEN.getsfUpdFldSetStr();
clsPrjTabFldWApi.CheckPropertyNew(objPrjTabFldEN); 
bool bolResult = clsPrjTabFldWApi.UpdateRecord(objPrjTabFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldWApi.ReFreshCache(objPrjTabFldEN.TabId);
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
 /// 获取唯一性条件串--PrjTabFld(工程表字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabId_FldId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPrjTabFldEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsPrjTabFldEN objPrjTabFldEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPrjTabFldEN == null) return "";
if (objPrjTabFldEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjTabFldEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objPrjTabFldEN.FldId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objPrjTabFldEN.mId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjTabFldEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objPrjTabFldEN.FldId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPrjTabFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPrjTabFldEN objPrjTabFldEN)
{
try
{
clsPrjTabFldWApi.CheckPropertyNew(objPrjTabFldEN); 
bool bolResult = clsPrjTabFldWApi.AddNewRecord(objPrjTabFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldWApi.ReFreshCache(objPrjTabFldEN.TabId);
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
 /// <param name = "objPrjTabFldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPrjTabFldEN objPrjTabFldEN, string strWhereCond)
{
try
{
clsPrjTabFldWApi.CheckPropertyNew(objPrjTabFldEN); 
bool bolResult = clsPrjTabFldWApi.UpdateWithCondition(objPrjTabFldEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldWApi.ReFreshCache(objPrjTabFldEN.TabId);
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
 /// 工程表字段(PrjTabFld)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsPrjTabFldWApi
{
private static readonly string mstrApiControllerName = "PrjTabFldApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsPrjTabFldWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsPrjTabFldEN objPrjTabFldEN)
{
if (!Object.Equals(null, objPrjTabFldEN.TabId) && GetStrLen(objPrjTabFldEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabFldEN.FldId) && GetStrLen(objPrjTabFldEN.FldId) > 8)
{
 throw new Exception("字段[字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabFldEN.PrjId) && GetStrLen(objPrjTabFldEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objPrjTabFldEN.FieldTypeId) && GetStrLen(objPrjTabFldEN.FieldTypeId) > 2)
{
 throw new Exception("字段[字段类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objPrjTabFldEN.CtlTypeIdDu) && GetStrLen(objPrjTabFldEN.CtlTypeIdDu) > 2)
{
 throw new Exception("字段[控件类型Id_du]的长度不能超过2!");
}
if (!Object.Equals(null, objPrjTabFldEN.FldDispUnitStyleId) && GetStrLen(objPrjTabFldEN.FldDispUnitStyleId) > 8)
{
 throw new Exception("字段[字段显示单元样式Id]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabFldEN.InFldId) && GetStrLen(objPrjTabFldEN.InFldId) > 8)
{
 throw new Exception("字段[In字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabFldEN.DnPathId) && GetStrLen(objPrjTabFldEN.DnPathId) > 8)
{
 throw new Exception("字段[DN路径Id]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabFldEN.KeyId4Test) && GetStrLen(objPrjTabFldEN.KeyId4Test) > 50)
{
 throw new Exception("字段[测试关键字Id]的长度不能超过50!");
}
if (!Object.Equals(null, objPrjTabFldEN.DisplayFormat) && GetStrLen(objPrjTabFldEN.DisplayFormat) > 50)
{
 throw new Exception("字段[显示格式]的长度不能超过50!");
}
if (!Object.Equals(null, objPrjTabFldEN.PrimaryTypeId) && GetStrLen(objPrjTabFldEN.PrimaryTypeId) > 2)
{
 throw new Exception("字段[主键类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objPrjTabFldEN.ForeignKeyTabId) && GetStrLen(objPrjTabFldEN.ForeignKeyTabId) > 8)
{
 throw new Exception("字段[外键表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objPrjTabFldEN.FldOpTypeId) && GetStrLen(objPrjTabFldEN.FldOpTypeId) > 4)
{
 throw new Exception("字段[字段操作类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objPrjTabFldEN.MemoInTab) && GetStrLen(objPrjTabFldEN.MemoInTab) > 1000)
{
 throw new Exception("字段[表中说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objPrjTabFldEN.ErrMsg) && GetStrLen(objPrjTabFldEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objPrjTabFldEN.UpdDate) && GetStrLen(objPrjTabFldEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objPrjTabFldEN.UpdUser) && GetStrLen(objPrjTabFldEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objPrjTabFldEN.Memo) && GetStrLen(objPrjTabFldEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objPrjTabFldEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPrjTabFldEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsPrjTabFldEN objPrjTabFldEN;
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
objPrjTabFldEN = JsonConvert.DeserializeObject<clsPrjTabFldEN>(strJson);
return objPrjTabFldEN;
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
public static clsPrjTabFldEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsPrjTabFldEN objPrjTabFldEN;
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
objPrjTabFldEN = JsonConvert.DeserializeObject<clsPrjTabFldEN>(strJson);
return objPrjTabFldEN;
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
public static clsPrjTabFldEN GetObjBymIdCache(long lngmId,string strTabId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsPrjTabFldEN._CurrTabName, strTabId);
List<clsPrjTabFldEN> arrPrjTabFldObjLstCache = GetObjLstCache(strTabId);
IEnumerable <clsPrjTabFldEN> arrPrjTabFldObjLst_Sel =
from objPrjTabFldEN in arrPrjTabFldObjLstCache
where objPrjTabFldEN.mId == lngmId 
select objPrjTabFldEN;
if (arrPrjTabFldObjLst_Sel.Count() == 0)
{
   clsPrjTabFldEN obj = clsPrjTabFldWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrPrjTabFldObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabFldEN> GetObjLst(string strWhereCond)
{
 List<clsPrjTabFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabFldEN>>(strJson);
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
public static List<clsPrjTabFldEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsPrjTabFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabFldEN>>(strJson);
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
public static IEnumerable<clsPrjTabFldEN> GetObjLstByMIdLstCache(List<long> arrMId, string strTabId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsPrjTabFldEN._CurrTabName, strTabId);
List<clsPrjTabFldEN> arrPrjTabFldObjLstCache = GetObjLstCache(strTabId);
IEnumerable <clsPrjTabFldEN> arrPrjTabFldObjLst_Sel =
from objPrjTabFldEN in arrPrjTabFldObjLstCache
where arrMId.Contains(objPrjTabFldEN.mId)
select objPrjTabFldEN;
return arrPrjTabFldObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPrjTabFldEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsPrjTabFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabFldEN>>(strJson);
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
public static List<clsPrjTabFldEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsPrjTabFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabFldEN>>(strJson);
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
public static List<clsPrjTabFldEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsPrjTabFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabFldEN>>(strJson);
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
public static List<clsPrjTabFldEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsPrjTabFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabFldEN>>(strJson);
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
 clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsPrjTabFldWApi.ReFreshCache(objPrjTabFldEN.TabId);
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
public static int DelPrjTabFlds(List<string> arrmId)
{
string strAction = "DelPrjTabFlds";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldWApi.GetObjBymId(long.Parse(arrmId[0]));
clsPrjTabFldWApi.ReFreshCache(objPrjTabFldEN.TabId);
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
public static int DelPrjTabFldsByCond(string strWhereCond)
{
string strAction = "DelPrjTabFldsByCond";
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
public static bool AddNewRecord(clsPrjTabFldEN objPrjTabFldEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjTabFldEN>(objPrjTabFldEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldWApi.ReFreshCache(objPrjTabFldEN.TabId);
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
 /// <param name = "objPrjTabFldEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsPrjTabFldEN objPrjTabFldEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjTabFldEN>(objPrjTabFldEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPrjTabFldWApi.ReFreshCache(objPrjTabFldEN.TabId);
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
public static bool UpdateRecord(clsPrjTabFldEN objPrjTabFldEN)
{
if (string.IsNullOrEmpty(objPrjTabFldEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjTabFldEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjTabFldEN>(objPrjTabFldEN);
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
 /// <param name = "objPrjTabFldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsPrjTabFldEN objPrjTabFldEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objPrjTabFldEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjTabFldEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objPrjTabFldEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPrjTabFldEN>(objPrjTabFldEN);
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
 /// <param name = "objPrjTabFldENS">源对象</param>
 /// <param name = "objPrjTabFldENT">目标对象</param>
 public static void CopyTo(clsPrjTabFldEN objPrjTabFldENS, clsPrjTabFldEN objPrjTabFldENT)
{
try
{
objPrjTabFldENT.mId = objPrjTabFldENS.mId; //mId
objPrjTabFldENT.TabId = objPrjTabFldENS.TabId; //表ID
objPrjTabFldENT.FldId = objPrjTabFldENS.FldId; //字段Id
objPrjTabFldENT.PrjId = objPrjTabFldENS.PrjId; //工程Id
objPrjTabFldENT.FieldTypeId = objPrjTabFldENS.FieldTypeId; //字段类型Id
objPrjTabFldENT.IsTabNullable = objPrjTabFldENS.IsTabNullable; //是否表中可空
objPrjTabFldENT.IsTabUnique = objPrjTabFldENS.IsTabUnique; //是否表中唯一
objPrjTabFldENT.IsTabForeignKey = objPrjTabFldENS.IsTabForeignKey; //是否表外键
objPrjTabFldENT.IsSortFld = objPrjTabFldENS.IsSortFld; //是否排序字段
objPrjTabFldENT.IsGeneProp = objPrjTabFldENS.IsGeneProp; //是否生成属性
objPrjTabFldENT.IsForExtendClass = objPrjTabFldENS.IsForExtendClass; //用于扩展类
objPrjTabFldENT.CtlTypeIdDu = objPrjTabFldENS.CtlTypeIdDu; //控件类型Id_du
objPrjTabFldENT.FldDispUnitStyleId = objPrjTabFldENS.FldDispUnitStyleId; //字段显示单元样式Id
objPrjTabFldENT.InFldId = objPrjTabFldENS.InFldId; //In字段Id
objPrjTabFldENT.DnPathId = objPrjTabFldENS.DnPathId; //DN路径Id
objPrjTabFldENT.KeyId4Test = objPrjTabFldENS.KeyId4Test; //测试关键字Id
objPrjTabFldENT.DisplayFormat = objPrjTabFldENS.DisplayFormat; //显示格式
objPrjTabFldENT.IsParentObj = objPrjTabFldENS.IsParentObj; //是否父对象
objPrjTabFldENT.PrimaryTypeId = objPrjTabFldENS.PrimaryTypeId; //主键类型ID
objPrjTabFldENT.ForeignKeyTabId = objPrjTabFldENS.ForeignKeyTabId; //外键表ID
objPrjTabFldENT.FldOpTypeId = objPrjTabFldENS.FldOpTypeId; //字段操作类型Id
objPrjTabFldENT.SequenceNumber = objPrjTabFldENS.SequenceNumber; //顺序号
objPrjTabFldENT.MemoInTab = objPrjTabFldENS.MemoInTab; //表中说明
objPrjTabFldENT.ErrMsg = objPrjTabFldENS.ErrMsg; //错误信息
objPrjTabFldENT.UpdDate = objPrjTabFldENS.UpdDate; //修改日期
objPrjTabFldENT.UpdUser = objPrjTabFldENS.UpdUser; //修改者
objPrjTabFldENT.Memo = objPrjTabFldENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsPrjTabFldEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsPrjTabFldEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsPrjTabFldEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsPrjTabFldEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsPrjTabFldEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsPrjTabFldEN._AttributeName)
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
public static void ReFreshThisCache(string strTabId = "")
{


if (string.IsNullOrEmpty(strTabId) == true)
{
  var strMsg = string.Format("参数:[strTabId]不能为空！(In clsPrjTabFldWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strTabId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strTabId]的长度:[{0}]不正确！(clsPrjTabFldWApi.ReFreshThisCache)", strTabId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsPrjTabFldEN._CurrTabName, strTabId);
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
public static void ReFreshCache(string strTabId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsPrjTabFldWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsPrjTabFldEN._CurrTabName, strTabId);
CacheHelper.Remove(strKey);
clsPrjTabFldWApi.objCommFun4WApi.ReFreshCache(strTabId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjTabFldEN> GetObjLstCache(string strTabId)
{


if (string.IsNullOrEmpty(strTabId) == true)
{
  var strMsg = string.Format("参数:[strTabId]不能为空！(In clsPrjTabFldWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strTabId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strTabId]的长度:[{0}]不正确！(clsPrjTabFldWApi.GetObjLstCache)", strTabId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsPrjTabFldEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsPrjTabFldEN._WhereFormat, strTabId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conPrjTabFld.TabId, strTabId);
}
var strKey = string.Format("{0}_{1}", clsPrjTabFldEN._CurrTabName, strTabId);
List<clsPrjTabFldEN> arrPrjTabFldObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrPrjTabFldObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPrjTabFldEN> GetObjLstCacheFromObjLst(string strTabId,List<clsPrjTabFldEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strTabId) == true)
{
  var strMsg = string.Format("参数:[strTabId]不能为空！(In clsPrjTabFldWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strTabId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strTabId]的长度:[{0}]不正确！(clsPrjTabFldWApi.GetObjLstCacheFromObjLst)", strTabId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsPrjTabFldEN._CurrTabName, strTabId);
List<clsPrjTabFldEN> arrPrjTabFldObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrPrjTabFldObjLstCache = CacheHelper.Get<List<clsPrjTabFldEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.TabId == strTabId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrPrjTabFldObjLstCache = CacheHelper.Get<List<clsPrjTabFldEN>>(strKey);
}
return arrPrjTabFldObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsPrjTabFldEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conPrjTabFld.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conPrjTabFld.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.FldId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.FieldTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.IsTabNullable, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTabFld.IsTabUnique, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTabFld.IsTabForeignKey, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTabFld.IsSortFld, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTabFld.IsGeneProp, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTabFld.IsForExtendClass, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTabFld.CtlTypeIdDu, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.FldDispUnitStyleId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.InFldId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.DnPathId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.KeyId4Test, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.DisplayFormat, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.IsParentObj, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPrjTabFld.PrimaryTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.ForeignKeyTabId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.FldOpTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.SequenceNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(conPrjTabFld.MemoInTab, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conPrjTabFld.Memo, Type.GetType("System.String"));
foreach (clsPrjTabFldEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conPrjTabFld.mId] = objInFor[conPrjTabFld.mId];
objDR[conPrjTabFld.TabId] = objInFor[conPrjTabFld.TabId];
objDR[conPrjTabFld.FldId] = objInFor[conPrjTabFld.FldId];
objDR[conPrjTabFld.PrjId] = objInFor[conPrjTabFld.PrjId];
objDR[conPrjTabFld.FieldTypeId] = objInFor[conPrjTabFld.FieldTypeId];
objDR[conPrjTabFld.IsTabNullable] = objInFor[conPrjTabFld.IsTabNullable];
objDR[conPrjTabFld.IsTabUnique] = objInFor[conPrjTabFld.IsTabUnique];
objDR[conPrjTabFld.IsTabForeignKey] = objInFor[conPrjTabFld.IsTabForeignKey];
objDR[conPrjTabFld.IsSortFld] = objInFor[conPrjTabFld.IsSortFld];
objDR[conPrjTabFld.IsGeneProp] = objInFor[conPrjTabFld.IsGeneProp];
objDR[conPrjTabFld.IsForExtendClass] = objInFor[conPrjTabFld.IsForExtendClass];
objDR[conPrjTabFld.CtlTypeIdDu] = objInFor[conPrjTabFld.CtlTypeIdDu];
objDR[conPrjTabFld.FldDispUnitStyleId] = objInFor[conPrjTabFld.FldDispUnitStyleId];
objDR[conPrjTabFld.InFldId] = objInFor[conPrjTabFld.InFldId];
objDR[conPrjTabFld.DnPathId] = objInFor[conPrjTabFld.DnPathId];
objDR[conPrjTabFld.KeyId4Test] = objInFor[conPrjTabFld.KeyId4Test];
objDR[conPrjTabFld.DisplayFormat] = objInFor[conPrjTabFld.DisplayFormat];
objDR[conPrjTabFld.IsParentObj] = objInFor[conPrjTabFld.IsParentObj];
objDR[conPrjTabFld.PrimaryTypeId] = objInFor[conPrjTabFld.PrimaryTypeId];
objDR[conPrjTabFld.ForeignKeyTabId] = objInFor[conPrjTabFld.ForeignKeyTabId];
objDR[conPrjTabFld.FldOpTypeId] = objInFor[conPrjTabFld.FldOpTypeId];
objDR[conPrjTabFld.SequenceNumber] = objInFor[conPrjTabFld.SequenceNumber];
objDR[conPrjTabFld.MemoInTab] = objInFor[conPrjTabFld.MemoInTab];
objDR[conPrjTabFld.ErrMsg] = objInFor[conPrjTabFld.ErrMsg];
objDR[conPrjTabFld.UpdDate] = objInFor[conPrjTabFld.UpdDate];
objDR[conPrjTabFld.UpdUser] = objInFor[conPrjTabFld.UpdUser];
objDR[conPrjTabFld.Memo] = objInFor[conPrjTabFld.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 工程表字段(PrjTabFld)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4PrjTabFld : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strTabId)
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
clsPrjTabFldWApi.ReFreshThisCache(strTabId);
}
}

}